//-----------------------------------------------------------------------------
// Walkabout Navigation Toolkit
// Copyright (c) 2012 Daniel Buckmaster
// Permission is NOT granted to freely distribute the contents of this file.
//-----------------------------------------------------------------------------

#ifndef _GUINAVEDITORCTRL_H_
#define _GUINAVEDITORCTRL_H_

#ifndef _EDITTSCTRL_H_
#include "gui/worldEditor/editTSCtrl.h"
#endif
#ifndef _UNDO_H_
#include "util/undo.h"
#endif
#ifndef _GIZMO_H_
#include "gui/worldEditor/gizmo.h"
#endif

#include "navMesh.h"
#include "T3D/aiPlayer.h"

struct ObjectRenderInst;
class SceneManager;
class SceneRenderState;
class BaseMatInstance;

class GuiNavEditorCtrl : public EditTSCtrl
{
   typedef EditTSCtrl Parent;
   friend class GuiNavEditorUndoAction;

public:
   static const String mSelectMode;
   static const String mLinkMode;
   static const String mCoverMode;
   static const String mTileMode;
   static const String mTestMode;

   GuiNavEditorCtrl();
   ~GuiNavEditorCtrl();

   DECLARE_CONOBJECT(GuiNavEditorCtrl);

   DECLARE_CALLBACK(void, onLinkDeselected, ());
   DECLARE_CALLBACK(void, onPlayerDeselected, ());
   DECLARE_CALLBACK(void, onPlayerSelected, (S32 linkDataFlags));
   DECLARE_CALLBACK(void, onLinkSelected, (S32 linkDataFlags));
   DECLARE_CALLBACK(void, onModeSet, (String mode));
   DECLARE_CALLBACK(void, paletteSync, (String mode));

   /// @name SimObject
   /// @{

   bool onAdd();
   static void initPersistFields();

   /// @}

   /// @name GuiControl
   /// @{

   virtual void onSleep();
   virtual void onRender(Point2I offset, const RectI &updateRect);

   /// @}

   /// @name EditTSCtrl
   /// @{

   void get3DCursor(GuiCursor *&cursor, bool &visible, const Gui3DMouseEvent &event_);
   bool get3DCentre(Point3F &pos);
   void on3DMouseDown(const Gui3DMouseEvent & event);
   void on3DMouseUp(const Gui3DMouseEvent & event);
   void on3DMouseMove(const Gui3DMouseEvent & event);
   void on3DMouseDragged(const Gui3DMouseEvent & event);
   void on3DMouseEnter(const Gui3DMouseEvent & event);
   void on3DMouseLeave(const Gui3DMouseEvent & event);
   void updateGuiInfo();      
   void renderScene(const RectI & updateRect);

   /// @}

   /// @name GuiNavEditorCtrl
   /// @{

   bool getStaticPos(const Gui3DMouseEvent & event, Point3F &tpos);

   void setMode(String mode, bool sourceShortcut);
   String getMode() { return mMode; }

   void selectMesh(NavMesh *mesh);
   void deselect();

   S32 getMeshId();
   S32 getPlayerId();

   String mSpawnClass;
   String mSpawnDatablock;

   void deleteLink();
   void setLinkFlags(const LinkData &d);

   void buildTile();

   void spawnPlayer(const Point3F &pos);

   /// @}

protected:

   void _prepRenderImage(SceneManager* sceneGraph, const SceneRenderState* sceneState);

   void submitUndo(const UTF8 *name = "Action");

   GFXStateBlockRef mZDisableSB;
   GFXStateBlockRef mZEnableSB;

   bool mSavedDrag;
   bool mIsDirty;

   String mMode;

   /// Currently-selected NavMesh.
   SimObjectPtr<NavMesh> mMesh;

   /// @name Link mode
   /// @{

   Point3F mLinkStart;
   S32 mCurLink;
   S32 mLink;

   /// @}

   /// @name Tile mode
   /// @{

   S32 mCurTile;
   S32 mTile;

   duDebugDrawTorque dd;

   /// @}

   /// @name Test mode
   /// @{

   SimObjectPtr<AIPlayer> mPlayer;
   SimObjectPtr<AIPlayer> mCurPlayer;

   /// @}

   Gui3DMouseEvent mLastMouseEvent;

#define InvalidMousePoint Point2I(-100,-100)
   Point2I mStartDragMousePoint;
};

class GuiNavEditorUndoAction : public UndoAction
{
public:
   GuiNavEditorUndoAction(const UTF8* actionName) : UndoAction(actionName)
   {
   }

   GuiNavEditorCtrl *mNavEditor;         

   SimObjectId mObjId;
   F32 mMetersPerSegment;
   U32 mSegmentsPerBatch;

   virtual void undo();
   virtual void redo() { undo(); }
};

#endif



