//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

#include "platform/platform.h"
#include "gui/3d/guiTSControl.h"

#include "console/engineAPI.h"
#include "scene/sceneManager.h"
#include "lighting/lightManager.h"
#include "gfx/sim/debugDraw.h"
#include "gfx/gfxTransformSaver.h"
#include "gfx/screenshot.h"
#include "math/mathUtils.h"
#include "gui/core/guiCanvas.h"
#include "scene/reflectionManager.h"
#include "postFx/postEffectManager.h"
#include "gfx/gfxTransformSaver.h"


IMPLEMENT_CONOBJECT( GuiTSCtrl );

ConsoleDocClass( GuiTSCtrl,
   "@brief Abstract base class for controls that render 3D scenes.\n\n"
   
   "GuiTSCtrl is the base class for controls that render 3D camera views in Torque.  The class itself "
   "does not implement a concrete scene rendering.  Use GuiObjectView to display invidiual shapes in "
   "the Gui and GameTSCtrl to render full scenes.\n\n"
   
   "@see GameTSCtrl\n"
   "@see GuiObjectView\n"
   "@ingroup Gui3D\n"
);

U32 GuiTSCtrl::smFrameCount = 0;
Vector<GuiTSCtrl*> GuiTSCtrl::smAwakeTSCtrls;

ImplementEnumType( GuiTSRenderStyles,
   "Style of rendering for a GuiTSCtrl.\n\n"
   "@ingroup Gui3D" )
	{ GuiTSCtrl::RenderStyleStandard,         "standard"              },
	{ GuiTSCtrl::RenderStyleStereoSideBySide, "stereo side by side"   },
EndImplementEnumType;


//-----------------------------------------------------------------------------

namespace 
{
   void _drawLine( const Point3F &p0, const Point3F &p1, const ColorI &color, F32 width )
   {
      F32 x1, x2, y1, y2, z1, z2;

      x1 = p0.x;
      y1 = p0.y;
      z1 = p0.z;
      x2 = p1.x;
      y2 = p1.y;
      z2 = p1.z;

      //
      // Convert Line   a----------b
      //
      // Into Quad      v0---------v1
      //                 a         b
      //                v2---------v3
      //

      Point2F start(x1, y1);
      Point2F end(x2, y2);
      Point2F perp, lineVec;

      // handle degenerate case where point a = b
      if(x1 == x2 && y1 == y2)
      {
         perp.set(0.0f, width * 0.5f);
         lineVec.set(0.1f, 0.0f);
      }
      else
      {
         perp.set(start.y - end.y, end.x - start.x);
         lineVec.set(end.x - start.x, end.y - start.y);
         perp.normalize(width * 0.5f);
         lineVec.normalize(0.1f);
      }
      start -= lineVec;
      end   += lineVec;

      GFXVertexBufferHandle<GFXVertexPC> verts(GFX, 4, GFXBufferTypeVolatile);
      verts.lock();

      verts[0].point.set( start.x+perp.x, start.y+perp.y, z1 );
      verts[1].point.set( end.x+perp.x, end.y+perp.y, z2 );
      verts[2].point.set( start.x-perp.x, start.y-perp.y, z1 );
      verts[3].point.set( end.x-perp.x, end.y-perp.y, z2 );

      verts[0].color = color;
      verts[1].color = color;
      verts[2].color = color;
      verts[3].color = color;

      verts.unlock();
      GFX->setVertexBuffer( verts );

      GFXStateBlockDesc desc;
      desc.setCullMode(GFXCullNone);
      desc.setZReadWrite(false);
      desc.setBlend(true, GFXBlendSrcAlpha, GFXBlendInvSrcAlpha);
      GFX->setStateBlockByDesc( desc );

      GFX->drawPrimitive( GFXTriangleStrip, 0, 2 );
   }
}

//-----------------------------------------------------------------------------

GuiTSCtrl::GuiTSCtrl()
{
   mCameraZRot = 0;
   mForceFOV = 0;
   mReflectPriority = 1.0f;

   mRenderStyle = RenderStyleStandard;

   mSaveModelview.identity();
   mSaveProjection.identity();
   mSaveViewport.set( 0, 0, 10, 10 );
   mSaveWorldToScreenScale.set( 0, 0 );

   mLastCameraQuery.cameraMatrix.identity();
   mLastCameraQuery.fov = 45.0f;
   mLastCameraQuery.object = NULL;
   mLastCameraQuery.farPlane = 10.0f;
   mLastCameraQuery.nearPlane = 0.01f;

   mLastCameraQuery.frustumOffset = Point4F::Zero;
   mForceFrustumOffset = Point4F::Zero;
   mForceAspect = 0.0f;
   mCameraRoll = 0.0f;
   mEnableAugmentations = false;

   mLastCameraQuery.projectionOffset = Point2F::Zero;
   mLastCameraQuery.eyeOffset = Point3F::Zero;

   mLastCameraQuery.ortho = false;
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::initPersistFields()
{
   addGroup( "Camera" );
   
      addField("cameraZRot", TypeF32, Offset(mCameraZRot, GuiTSCtrl),
         "Z rotation angle of camera." );
      addField("forceFOV",   TypeF32, Offset(mForceFOV,   GuiTSCtrl),
         "The vertical field of view in degrees or zero to use the normal camera FOV." );
         
      addField("forceFrustumOffset",   TypePoint4F, Offset(mForceFrustumOffset,   GuiTSCtrl),
         "." );
      addField("forceAspect",   TypeF32, Offset(mForceAspect,   GuiTSCtrl),
         "." );
      addField("cameraRoll",   TypeF32, Offset(mCameraRoll,   GuiTSCtrl),
         "." );
      addField("enableAugmentations",   TypeBool, Offset(mEnableAugmentations,   GuiTSCtrl),
         "." );
	  

   endGroup( "Camera" );
   
   addGroup( "Rendering" );
   
      addField( "reflectPriority", TypeF32, Offset( mReflectPriority, GuiTSCtrl ),
         "The share of the per-frame reflection update work this control's rendering should run.\n"
         "The reflect update priorities of all visible GuiTSCtrls are added together and each control is assigned "
         "a share of the per-frame reflection update time according to its percentage of the total priority value." );

      addField("renderStyle", TYPEID< RenderStyles >(), Offset(mRenderStyle, GuiTSCtrl),
         "Indicates how this control should render its contents." );

   endGroup( "Rendering" );
   
   Parent::initPersistFields();
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::consoleInit()
{
   Con::addVariable("$TSControl::frameCount", TypeS32, &smFrameCount, "The number of frames that have been rendered since this control was created.\n"
	   "@ingroup Rendering\n");
}

//-----------------------------------------------------------------------------

bool GuiTSCtrl::onWake()
{
   if ( !Parent::onWake() )
      return false;

   // Add ourselves to the active viewport list.
   AssertFatal( !smAwakeTSCtrls.contains( this ), 
      "GuiTSCtrl::onWake - This control is already in the awake list!" );
   smAwakeTSCtrls.push_back( this );

   return true;
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::onSleep()
{
   Parent::onSleep();

   AssertFatal( smAwakeTSCtrls.contains( this ), 
      "GuiTSCtrl::onSleep - This control is not in the awake list!" );
   smAwakeTSCtrls.remove( this );
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::onPreRender()
{
   setUpdate();
}

//-----------------------------------------------------------------------------

bool GuiTSCtrl::processCameraQuery(CameraQuery *)
{
   return false;
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::renderWorld(const RectI& /*updateRect*/)
{
}

//-----------------------------------------------------------------------------

F32 GuiTSCtrl::projectRadius( F32 dist, F32 radius ) const
{
   // Fixup any negative or zero distance so we
   // don't get a divide by zero.
   dist = dist > 0.0f ? dist : 0.001f;
   return ( radius / dist ) * mSaveWorldToScreenScale.y;   
}

//-----------------------------------------------------------------------------

bool GuiTSCtrl::project( const Point3F &pt, Point3F *dest ) const
{
   return MathUtils::mProjectWorldToScreen(pt,dest,mSaveViewport,mSaveModelview,mSaveProjection);
}

//-----------------------------------------------------------------------------

bool GuiTSCtrl::unproject( const Point3F &pt, Point3F *dest ) const
{
   MathUtils::mProjectScreenToWorld(pt,dest,mSaveViewport,mSaveModelview,mSaveProjection,mLastCameraQuery.farPlane,mLastCameraQuery.nearPlane);
   return true;
}

//-----------------------------------------------------------------------------

F32 GuiTSCtrl::calculateViewDistance(F32 radius)
{
   F32 fov = mLastCameraQuery.fov;
   F32 wwidth;
   F32 wheight;
   F32 renderWidth = (mRenderStyle == RenderStyleStereoSideBySide) ? F32(getWidth())*0.5f : F32(getWidth());
   F32 renderHeight = F32(getHeight());
   F32 aspectRatio = renderWidth / renderHeight;
   
   // Use the FOV to calculate the viewport height scale
   // then generate the width scale from the aspect ratio.
   if(!mLastCameraQuery.ortho)
   {
      wheight = mLastCameraQuery.nearPlane * mTan(mLastCameraQuery.fov / 2.0f);
      wwidth = aspectRatio * wheight;
   }
   else
   {
      wheight = mLastCameraQuery.fov;
      wwidth = aspectRatio * wheight;
   }

   // Now determine if we should use the width 
   // fov or height fov.
   //
   // If the window is taller than it is wide, use the 
   // width fov to keep the object completely in view.
   if (wheight > wwidth)
      fov = mAtan( wwidth / mLastCameraQuery.nearPlane ) * 2.0f;

   return radius / mTan(fov / 2.0f);
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::onRender(Point2I offset, const RectI &updateRect)
{
	// Save the current transforms so we can restore
   // it for child control rendering below.
   GFXTransformSaver saver;

   if(!processCameraQuery(&mLastCameraQuery))
   {
      // We have no camera, but render the GUI children 
      // anyway.  This makes editing GuiTSCtrl derived
      // controls easier in the GuiEditor.
      renderChildControls( offset, updateRect );
      return;
   }

   // Set up the appropriate render style
   U32 prevRenderStyle = GFX->getCurrentRenderStyle();
   Point2F prevProjectionOffset = GFX->getCurrentProjectionOffset();
   Point3F prevEyeOffset = GFX->getStereoEyeOffset();
   if(mRenderStyle == RenderStyleStereoSideBySide)
   {
      GFX->setCurrentRenderStyle(GFXDevice::RS_StereoSideBySide);
      GFX->setCurrentProjectionOffset(mLastCameraQuery.projectionOffset);
      GFX->setStereoEyeOffset(mLastCameraQuery.eyeOffset);
   }
   else
   {
      GFX->setCurrentRenderStyle(GFXDevice::RS_Standard);
   }

   if(mEnableAugmentations)
   {
       if(mForceFOV != 0.0)
          mLastCameraQuery.fov = mDegToRad(mForceFOV);
    
       if(mForceFrustumOffset.z != 0.0f && mForceFrustumOffset.w != 0.0f)
          mLastCameraQuery.frustumOffset = mForceFrustumOffset;
    
       if(mCameraRoll != 0.0)
       {
          if(mCameraRoll == -90.0f)
          {
             Point3F vec, vec2;
             mLastCameraQuery.cameraMatrix.getColumn(0, &vec);
             mLastCameraQuery.cameraMatrix.getColumn(2, &vec2);
             vec2.neg();
     
             mLastCameraQuery.cameraMatrix.setColumn(0, vec2);
             mLastCameraQuery.cameraMatrix.setColumn(2, vec);
          }
       }
   }

   if ( mReflectPriority > 0 )
   {
      // Get the total reflection priority.
      F32 totalPriority = 0;
      for ( U32 i=0; i < smAwakeTSCtrls.size(); i++ )
         if ( smAwakeTSCtrls[i]->isVisible() )
            totalPriority += smAwakeTSCtrls[i]->mReflectPriority;

      REFLECTMGR->update(  mReflectPriority / totalPriority,
                           getExtent(),
                           mLastCameraQuery );
   }

   if(mForceFOV != 0)
      mLastCameraQuery.fov = mDegToRad(mForceFOV);

   if(mCameraZRot)
   {
      MatrixF rotMat(EulerF(0, 0, mDegToRad(mCameraZRot)));
      mLastCameraQuery.cameraMatrix.mul(rotMat);
   }

   // set up the camera and viewport stuff:
   F32 wwidth;
   F32 wheight;
   F32 renderWidth = (mRenderStyle == RenderStyleStereoSideBySide) ? F32(getWidth())*0.5f : F32(getWidth());
   F32 renderHeight = F32(getHeight());
   F32 aspectRatio = renderWidth / renderHeight;
   
   // Use the FOV to calculate the viewport height scale
   // then generate the width scale from the aspect ratio.
   if(!mLastCameraQuery.ortho)
   {
      wheight = mLastCameraQuery.nearPlane * mTan(mLastCameraQuery.fov / 2.0f);
      wwidth = aspectRatio * wheight;
   }
   else
   {
      wheight = mLastCameraQuery.fov;
      wwidth = aspectRatio * wheight;
   }

   F32 hscale = wwidth * 2.0f / renderWidth;
   F32 vscale = wheight * 2.0f / renderHeight;

   Frustum frustum;
   if(mRenderStyle == RenderStyleStereoSideBySide)
   {
      F32 left = 0.0f * hscale - wwidth;
      F32 right = renderWidth * hscale - wwidth;
      F32 top = wheight - vscale * 0.0f;
      F32 bottom = wheight - vscale * renderHeight;

      frustum.set( mLastCameraQuery.ortho, left, right, top, bottom, mLastCameraQuery.nearPlane, mLastCameraQuery.farPlane );
   }
   else
   {
      F32 left = (updateRect.point.x - offset.x) * hscale - wwidth;
      F32 right = (updateRect.point.x + updateRect.extent.x - offset.x) * hscale - wwidth;
      F32 top = wheight - vscale * (updateRect.point.y - offset.y);
      F32 bottom = wheight - vscale * (updateRect.point.y + updateRect.extent.y - offset.y);

      frustum.set( mLastCameraQuery.ortho, left, right, top, bottom, mLastCameraQuery.nearPlane, mLastCameraQuery.farPlane );
   }

	// Manipulate the frustum for tiled screenshots
	const bool screenShotMode = gScreenShot && gScreenShot->isPending();
   if ( screenShotMode )
   {
      gScreenShot->tileFrustum( frustum );      
      GFX->setViewMatrix(MatrixF::Identity);
   }

   if(mLastCameraQuery.frustumOffset.z != 0.0f && mLastCameraQuery.frustumOffset.w != 0.0f)
   {
      frustum.offsetFrustum(mLastCameraQuery.frustumOffset);
      GFX->setViewMatrix(MatrixF::Identity);
   }
      
   RectI tempRect = updateRect;
   
#ifdef TORQUE_OS_MAC
   Point2I screensize = getRoot()->getWindowSize();
   tempRect.point.y = screensize.y - (tempRect.point.y + tempRect.extent.y);
#endif

   GFX->setViewport( tempRect );

   // Clear the zBuffer so GUI doesn't hose object rendering accidentally
   GFX->clear( GFXClearZBuffer , ColorI(20,20,20), 1.0f, 0 );

   GFX->setFrustum( frustum );
   if(mLastCameraQuery.ortho)
   {
      mOrthoWidth = frustum.getWidth();
      mOrthoHeight = frustum.getHeight();
   }

   // We're going to be displaying this render at size of this control in
   // pixels - let the scene know so that it can calculate e.g. reflections
   // correctly for that final display result.
   gClientSceneGraph->setDisplayTargetResolution(getExtent());

   // Set the GFX world matrix to the world-to-camera transform, but don't 
   // change the cameraMatrix in mLastCameraQuery. This is because 
   // mLastCameraQuery.cameraMatrix is supposed to contain the camera-to-world
   // transform. In-place invert would save a copy but mess up any GUIs that
   // depend on that value.
   MatrixF worldToCamera = mLastCameraQuery.cameraMatrix;
   worldToCamera.inverse();
   GFX->setWorldMatrix( worldToCamera );

   mSaveProjection = GFX->getProjectionMatrix();
   mSaveModelview = GFX->getWorldMatrix();
   mSaveViewport = updateRect;
   mSaveWorldToScreenScale = GFX->getWorldToScreenScale();
   mSaveFrustum = GFX->getFrustum();
   mSaveFrustum.setTransform( mLastCameraQuery.cameraMatrix );

   // Set the default non-clip projection as some 
   // objects depend on this even in non-reflect cases.
   gClientSceneGraph->setNonClipProjection( mSaveProjection );

   // Give the post effect manager the worldToCamera, and cameraToScreen matrices
   PFXMGR->setFrameMatrices( mSaveModelview, mSaveProjection );

   renderWorld(updateRect);
   DebugDrawer::get()->render();

	// Restore the previous matrix state before
   // we begin rendering the child controls.
   saver.restore();

   // Restore the render style and any stereo parameters
   GFX->setCurrentRenderStyle(prevRenderStyle);
   GFX->setCurrentProjectionOffset(prevProjectionOffset);
   GFX->setStereoEyeOffset(prevEyeOffset);

   // Allow subclasses to render 2D elements.
   GFX->setClipRect(updateRect);
   renderGui( offset, updateRect );

   renderChildControls(offset, updateRect);
   smFrameCount++;
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::drawLine( Point3F p0, Point3F p1, const ColorI &color, F32 width )
{   
   if ( !mSaveFrustum.clipSegment( p0, p1 ) )
      return;

   MathUtils::mProjectWorldToScreen( p0, &p0, mSaveViewport, mSaveModelview, mSaveProjection );   
   MathUtils::mProjectWorldToScreen( p1, &p1, mSaveViewport, mSaveModelview, mSaveProjection );   

   p0.x = mClampF( p0.x, 0.0f, mSaveViewport.extent.x );
   p0.y = mClampF( p0.y, 0.0f, mSaveViewport.extent.y );
   p1.x = mClampF( p1.x, 0.0f, mSaveViewport.extent.x );
   p1.y = mClampF( p1.y, 0.0f, mSaveViewport.extent.y );
   p0.z = p1.z = 0.0f;

   _drawLine( p0, p1, color, width );
}

//-----------------------------------------------------------------------------

void GuiTSCtrl::drawLineList( const Vector<Point3F> &points, const ColorI &color, F32 width )
{
   for ( S32 i = 0; i < points.size() - 1; i++ )
      drawLine( points[i], points[i+1], color, width );
}

const char* GuiTSCtrl::getClickVector( Point2I mousePoint )
{
	// write world position
	Point3F camPos;
	mLastCameraQuery.cameraMatrix.getColumn(3, &camPos);
	//dSprintf(wp, 32, "%g %g %g", camPos.x, camPos.y, camPos.z);

	char *vec = Con::getArgBuffer(32);
	Point3F fp(mousePoint.x, mousePoint.y, 1.0);
	Point3F ray;
	unproject(fp, &ray);
	ray -= camPos;
	ray.normalizeSafe();
	dSprintf(vec, 32, "%g %g %g", ray.x, ray.y, ray.z);

	return vec;
}

const char * GuiTSCtrl::getWorldPosition( Point2I mousePoint )
{
	// write world position
	char *wp = Con::getArgBuffer(32);
	Point3F camPos;
	mLastCameraQuery.cameraMatrix.getColumn(3, &camPos);
	dSprintf(wp, 32, "%g %g %g", camPos.x, camPos.y, camPos.z);

	return wp;
}

//=============================================================================
//    Console Methods.
//=============================================================================
// MARK: ---- Console Methods ----

//-----------------------------------------------------------------------------

DefineEngineMethod( GuiTSCtrl, unproject, Point3F, ( Point3F screenPosition ),,
   "Transform 3D screen-space coordinates (x, y, depth) to world space.\n"
   "This method can be, for example, used to find the world-space position relating to the current mouse cursor position.\n"
   "@param screenPosition The x/y position on the screen plus the depth from the screen-plane outwards.\n"
   "@return The world-space position corresponding to the given screen-space coordinates." )
{
   Point3F worldPos;
   object->unproject( screenPosition, &worldPos );
   return worldPos;
}

//-----------------------------------------------------------------------------

DefineEngineMethod( GuiTSCtrl, project, Point3F, ( Point3F worldPosition ),,
   "Transform world-space coordinates to screen-space (x, y, depth) coordinates.\n"
   "@param worldPosition The world-space position to transform to screen-space.\n"
   "@return The " )
{
   Point3F screenPos;
   object->project( worldPosition, &screenPos );
   return screenPos;
}

//-----------------------------------------------------------------------------

DefineEngineMethod( GuiTSCtrl, getWorldToScreenScale, Point2F, (),,
   "Get the ratio between world-space units and pixels.\n"
   "@return The amount of world-space units covered by the extent of a single pixel." )
{
   return object->getWorldToScreenScale();
}

//-----------------------------------------------------------------------------

DefineEngineMethod( GuiTSCtrl, calculateViewDistance, F32, ( F32 radius ),,
   "Given the camera's current FOV, get the distance from the camera's viewpoint at which the given radius will fit in the render area.\n"
   "@param radius Radius in world-space units which should fit in the view.\n"
   "@return The distance from the viewpoint at which the given radius would be fully visible." )
{
   return object->calculateViewDistance( radius );
}

DefineEngineMethod(GuiTSCtrl, getClickVector, const char*, (Point2I mousePoint ),, "")
{
	return object->getClickVector(mousePoint);
}

DefineEngineMethod(GuiTSCtrl, getWorldPosition, const char*, (Point2I mousePoint ),, "")
{
	return object->getWorldPosition(mousePoint);
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) F32  __cdecl wle_fnGuiTSCtrl_calculateViewDistance(char * x__object, F32 radius)
{
GuiTSCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	return (F32)( 0);
{
  return (F32)( object->calculateViewDistance( radius ));
};
}
extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiTSCtrl_getClickVector(char * x__object, char * x__mousePoint,  char* retval)
{
dSprintf(retval,16384,"");
GuiTSCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
Point2I mousePoint = Point2I();
sscanf(x__mousePoint,"%i %i",&mousePoint.x,&mousePoint.y);
const char* wle_returnObject;
{
	{wle_returnObject =object->getClickVector(mousePoint);
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiTSCtrl_getWorldPosition(char * x__object, char * x__mousePoint,  char* retval)
{
dSprintf(retval,16384,"");
GuiTSCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
Point2I mousePoint = Point2I();
sscanf(x__mousePoint,"%i %i",&mousePoint.x,&mousePoint.y);
const char* wle_returnObject;
{
	{wle_returnObject =object->getWorldPosition(mousePoint);
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiTSCtrl_getWorldToScreenScale(char * x__object,  char* retval)
{
dSprintf(retval,1024,"");
GuiTSCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
Point2F wle_returnObject;
{
   {wle_returnObject =object->getWorldToScreenScale();
dSprintf(retval,1024,"%f %f ",wle_returnObject.x,wle_returnObject.y);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiTSCtrl_project(char * x__object, char * x__worldPosition,  char* retval)
{
dSprintf(retval,1024,"");
GuiTSCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
Point3F worldPosition = Point3F();
sscanf(x__worldPosition,"%f %f %f",&worldPosition.x,&worldPosition.y,&worldPosition.z);
Point3F wle_returnObject;
{
   Point3F screenPos;
   object->project( worldPosition, &screenPos );
   {wle_returnObject =screenPos;
dSprintf(retval,1024,"%f %f %f ",wle_returnObject.x,wle_returnObject.y,wle_returnObject.z);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiTSCtrl_unproject(char * x__object, char * x__screenPosition,  char* retval)
{
dSprintf(retval,1024,"");
GuiTSCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
Point3F screenPosition = Point3F();
sscanf(x__screenPosition,"%f %f %f",&screenPosition.x,&screenPosition.y,&screenPosition.z);
Point3F wle_returnObject;
{
   Point3F worldPos;
   object->unproject( screenPosition, &worldPos );
   {wle_returnObject =worldPos;
dSprintf(retval,1024,"%f %f %f ",wle_returnObject.x,wle_returnObject.y,wle_returnObject.z);
return;
}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

