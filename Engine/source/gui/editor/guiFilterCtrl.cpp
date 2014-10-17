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
#include "gui/editor/guiFilterCtrl.h"

#include "console/engineAPI.h"
#include "console/console.h"
#include "console/consoleTypes.h"
#include "guiFilterCtrl.h"
#include "math/mMath.h"
#include "gfx/gfxDrawUtil.h"


IMPLEMENT_CONOBJECT(GuiFilterCtrl);

ConsoleDocClass( GuiFilterCtrl,
				"@brief A control that displays a Catmull-Rom spline through a number of control points.\n\n"
				"Currently editor use only, no real application without extension.\n\n "
				"@internal");

GuiFilterCtrl::GuiFilterCtrl()
{
   mControlPointRequest = 7;
   mFilter.setSize(7);
   mShowIdentity = true;
   mIdentity.set( 0.0f, 1.0f );
   identity();
   mCurKnot = -1;
}

void GuiFilterCtrl::initPersistFields()
{
   addField("controlPoints", TypeS32, Offset(mControlPointRequest, GuiFilterCtrl),
      "Total number of control points in the spline curve." );
   addField("filter", TypeF32Vector, Offset(mFilter, GuiFilterCtrl),
      "Vector of control points." );
   addField("showIdentity", TypeBool, Offset(mShowIdentity, GuiFilterCtrl), "@internal" );
   addField("identity", TypePoint2F, Offset(mIdentity, GuiFilterCtrl), "@internal");

   Parent::initPersistFields();

   // Copyright (C) 2013 WinterLeaf Entertainment LLC.
   //  @Copyright start

   removeField( "loveControl" );

   removeField( "moveControl" );

   // @Copyright end
}

//ConsoleMethod( GuiFilterCtrl, getValue, const char*, 2, 2, "Return a tuple containing all the values in the filter."
DefineConsoleMethod( GuiFilterCtrl, getValue, const char*, (), , "Return a tuple containing all the values in the filter."
			  "@internal")
{
   //TORQUE_UNUSED(argv);
   static char buffer[512];
   const Filter *filter = object->get();
   *buffer = 0;

   for (U32 i=0; i < filter->size(); i++)
   {
      char value[32];
      dSprintf(value, 31, "%1.5f ", *(filter->begin()+i) );
      dStrcat(buffer, value);
   }

   return buffer;
}

ConsoleMethod( GuiFilterCtrl, setValue, void, 3, 20, "(f1, f2, ...)"
              "Reset the filter to use the specified points, spread equidistantly across the domain."
			  "@internal")
{
   Filter filter;

   argc -= 2;
   argv += 2;

   filter.set(argc, argv);
	object->set(filter);
}

//ConsoleMethod( GuiFilterCtrl, identity, void, 2, 2, "Reset the filtering."
DefineConsoleMethod( GuiFilterCtrl, identity, void, (), , "Reset the filtering."
			  "@internal")
{
   object->identity();
}

bool GuiFilterCtrl::onWake()
{
   if (!Parent::onWake())
      return false;

   if (U32(mControlPointRequest) != mFilter.size())
   {
      mFilter.setSize(mControlPointRequest);
      identity();
   }

   mCurKnot = -1;

   return true;
}


void GuiFilterCtrl::identity()
{
   S32 size = mFilter.size()-1;
   for (U32 i=0; S32(i) <= size; i++)
   {
      F32 step = (F32)i/(F32)size;
      mFilter[i] = mLerp( mIdentity.x, mIdentity.y, step );
   }
}


void GuiFilterCtrl::onMouseDown(const GuiEvent &event)
{
   mouseLock();
   setFirstResponder();

   Point2I p = globalToLocalCoord(event.mousePoint);

   // determine which knot (offset same as in onRender)
   F32 w = F32(getWidth()-4) / F32(mFilter.size()-1);
   F32 val = (F32(p.x) + (w / 2.f)) / w;
   mCurKnot = S32(val);

   mFilter[mCurKnot] = 1.0f - F32(getMin(getMax(0, p.y), getHeight())/(F32)getHeight());
   setUpdate();
}


void GuiFilterCtrl::onMouseDragged(const GuiEvent &event)
{
   if ( mCurKnot < 0 )
      return;

   mouseLock();
   setFirstResponder();

   Point2I p = globalToLocalCoord(event.mousePoint);
   mFilter[mCurKnot] = 1.0f - F32(getMin(getMax(0, p.y), getHeight())/(F32)getHeight());
   setUpdate();
}

void GuiFilterCtrl::onMouseUp(const GuiEvent &)
{
   if ( mCurKnot < 0 )
      return;

   mouseUnlock();
   execConsoleCallback();
}

void GuiFilterCtrl::onPreRender()
{
   if(U32(mControlPointRequest) != mFilter.size())
   {
      mFilter.setSize(mControlPointRequest);
      identity();
      setUpdate();
   }
}

void GuiFilterCtrl::onRender(Point2I offset, const RectI &updateRect)
{
   Point2I pos = offset;
   Point2I ext = getExtent();

   RectI r(pos, ext);
   GFX->getDrawUtil()->drawRectFill(r, ColorI(255,255,255));
   GFX->getDrawUtil()->drawRect(r, ColorI(0,0,0));

   // shrink by 2 pixels
   pos.x += 2;
   pos.y += 2;
   ext.x -= 4;
   ext.y -= 4;

   // draw the identity line
   if ( mShowIdentity )
   {
      GFX->getDrawUtil()->drawLine( pos.x, pos.y + ( ext.y * ( 1.0f - mIdentity.x ) ), 
                                    pos.x + ext.x, pos.y + ( ext.y * ( 1.0f - mIdentity.y ) ), 
                                    ColorF( 0.9f, 0.9f, 0.9f ) );
   }

   // draw the curv
   GFXVertexBufferHandle<GFXVertexPC> verts(GFX, ext.x, GFXBufferTypeVolatile);

   verts.lock();

   F32 scale = 1.f / F32( ext.x );
   for ( U32 i = 0; i < ext.x; i++)
   {
      F32 index = F32(i) * scale;
      S32 y = (S32)(ext.y*(1.0f-mFilter.getValue(index)));

      verts[i].point.set( (F32)(pos.x + i), (F32)(pos.y + y), 0.0f );
      verts[i].color = GFXVertexColor( ColorF( 0.4f, 0.4f, 0.4f ) );
   }

   verts.unlock();

   GFX->setVertexBuffer( verts );
   GFX->drawPrimitive( GFXLineStrip, 0, ext.x - 1 );

   // draw the knots
   for (U32 k=0; k < mFilter.size(); k++)
   {
      RectI r;
      r.point.x = (S32)(((F32)ext.x/(F32)(mFilter.size()-1)*(F32)k));
      r.point.y = (S32)(ext.y - ((F32)ext.y * mFilter[k]));
      r.point += pos + Point2I(-2,-2);
      r.extent = Point2I(5,5);

      GFX->getDrawUtil()->drawRectFill(r, ColorI(255,0,0));
   }

   renderChildControls(offset, updateRect);
}



//--------------------------------------
void Filter::set(S32 argc, const char *argv[])
{
   setSize(0);
   if (argc == 1)
   {  // in the form of one string "1.0 1.0 1.0"
      char list[1024];
      dStrcpy(list, *argv);    // strtok modifies the string so we need to copy it
      char *value = dStrtok(list, " ");
      while (value)
      {
         push_back(dAtof(value));
         value = dStrtok(NULL, " ");
      }
   }
   else
   {  // in the form of seperate strings "1.0" "1.0" "1.0"
      for (; argc ; argc--, argv++)
         push_back(dAtof(*argv));
   }
}


//--------------------------------------
F32 Filter::getValue(F32 x) const
{
   if (size() < 2)
      return 0.0f;

   x = mClampF(x, 0.0f, 1.0f);
   x *= F32(size()-1);

   F32 p0,p1,p2,p3;
   S32 i1 = (S32)mFloor(x);
   S32 i2 = i1+1;
   F32 dt = x - F32(i1);

   p1 = *(begin()+i1);
   p2 = *(begin()+i2);

   if (i1 == 0)
      p0 = p1 + (p1 - p2);
   else
      p0 = *(begin()+i1-1);

   if (i2 == S32(size()-1))
      p3 = p2 + (p2 - p1);
   else
      p3 = *(begin()+i2+1);

   return mClampF( mCatmullrom(dt, p0, p1, p2, p3), 0.0f, 1.0f );
}


















































//---------------DNTC AUTO-GENERATED---------------//
#include <vector>

#include <string>

#include "core/strings/stringFunctions.h"

//---------------DO NOT MODIFY CODE BELOW----------//

extern "C" __declspec(dllexport) void  __cdecl wle_fn_GuiFilterCtrl_getValue(char * x__object,  char* retval)
{
dSprintf(retval,16384,"");
GuiFilterCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* wle_returnObject;
{
      static char buffer[512];
   const Filter *filter = object->get();
   *buffer = 0;
   for (U32 i=0; i < filter->size(); i++)
   {
      char value[32];
      dSprintf(value, 31, "%1.5f ", *(filter->begin()+i) );
      dStrcat(buffer, value);
   }
   {wle_returnObject =buffer;
if (!wle_returnObject) 
return;
dSprintf(retval,16384,"%s",wle_returnObject);
return;
}
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fn_GuiFilterCtrl_identity(char * x__object)
{
GuiFilterCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
{
   object->identity();
}
}
extern "C" __declspec(dllexport) void  __cdecl wle_fnGuiFilterCtrl_setValue(char * x__object, char * x__a2, char * x__a3, char * x__a4, char * x__a5, char * x__a6, char * x__a7, char * x__a8, char * x__a9, char * x__a10, char * x__a11, char * x__a12, char * x__a13, char * x__a14, char * x__a15, char * x__a16, char * x__a17, char * x__a18, char * x__a19)
{
GuiFilterCtrl* object; Sim::findObject(x__object, object ); 
if (!object)
	 return;
const char* a2 = (const char*)x__a2;
const char* a3 = (const char*)x__a3;
const char* a4 = (const char*)x__a4;
const char* a5 = (const char*)x__a5;
const char* a6 = (const char*)x__a6;
const char* a7 = (const char*)x__a7;
const char* a8 = (const char*)x__a8;
const char* a9 = (const char*)x__a9;
const char* a10 = (const char*)x__a10;
const char* a11 = (const char*)x__a11;
const char* a12 = (const char*)x__a12;
const char* a13 = (const char*)x__a13;
const char* a14 = (const char*)x__a14;
const char* a15 = (const char*)x__a15;
const char* a16 = (const char*)x__a16;
const char* a17 = (const char*)x__a17;
const char* a18 = (const char*)x__a18;
const char* a19 = (const char*)x__a19;
{
S32 argc = 20;
if ( dStrlen(a19) == 0 )
if ( dStrlen(a18) == 0 )
if ( dStrlen(a17) == 0 )
if ( dStrlen(a16) == 0 )
if ( dStrlen(a15) == 0 )
if ( dStrlen(a14) == 0 )
if ( dStrlen(a13) == 0 )
if ( dStrlen(a12) == 0 )
if ( dStrlen(a11) == 0 )
if ( dStrlen(a10) == 0 )
if ( dStrlen(a9) == 0 )
if ( dStrlen(a8) == 0 )
if ( dStrlen(a7) == 0 )
if ( dStrlen(a6) == 0 )
if ( dStrlen(a5) == 0 )
if ( dStrlen(a4) == 0 )
if ( dStrlen(a3) == 0 )
argc=3;
else
argc=4;
else
argc=5;
else
argc=6;
else
argc=7;
else
argc=8;
else
argc=9;
else
argc=10;
else
argc=11;
else
argc=12;
else
argc=13;
else
argc=14;
else
argc=15;
else
argc=16;
else
argc=17;
else
argc=18;
else
argc=19;
else
argc=20;
std::vector<const char*> arguments;
arguments.push_back("");
arguments.push_back("");
arguments.push_back(a2);
if ( argc >3 )
arguments.push_back(a3);
if ( argc >4 )
arguments.push_back(a4);
if ( argc >5 )
arguments.push_back(a5);
if ( argc >6 )
arguments.push_back(a6);
if ( argc >7 )
arguments.push_back(a7);
if ( argc >8 )
arguments.push_back(a8);
if ( argc >9 )
arguments.push_back(a9);
if ( argc >10 )
arguments.push_back(a10);
if ( argc >11 )
arguments.push_back(a11);
if ( argc >12 )
arguments.push_back(a12);
if ( argc >13 )
arguments.push_back(a13);
if ( argc >14 )
arguments.push_back(a14);
if ( argc >15 )
arguments.push_back(a15);
if ( argc >16 )
arguments.push_back(a16);
if ( argc >17 )
arguments.push_back(a17);
if ( argc >18 )
arguments.push_back(a18);
if ( argc >19 )
arguments.push_back(a19);
const char** argv = &arguments[0];
{
   Filter filter;
   argc -= 2;
   argv += 2;
   filter.set(argc, argv);
	object->set(filter);
}
}
}
//---------------END DNTC AUTO-GENERATED-----------//

