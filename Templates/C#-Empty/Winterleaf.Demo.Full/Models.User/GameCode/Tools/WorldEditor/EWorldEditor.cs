// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
{
    [TypeConverter(typeof (EWorldEditor))]
    public class EWorldEditor : Extendable.WorldEditor
    {
        public bool objectsUseBoxCenter
        {
            get { return this["objectsUseBoxCenter"].AsBool(); }
            set { this["objectsUseBoxCenter"] = value.AsString(); }
        }

        public bool gridSnap
        {
            get { return this["gridSnap"].AsBool(); }

            set { this["gridSnap"] = value.AsString(); }
        }

        [ConsoleInteraction]
        public bool getGridSnap()
        {
            return this.gridSnap;
        }

        [ConsoleInteraction]
        public void setGridSnap(bool value)
        {
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            this.gridSnap = value;
            GlobalGizmoProfile["snapToGrid"] = value.AsString();
            this.syncGui();
        }

        [ConsoleInteraction]
        public string getGridSize()
        {
            return this["gridSize"];
        }

        [ConsoleInteraction]
        public void setGridSize(string value)
        {
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            GlobalGizmoProfile.gridSize = (value + ' ' + value + ' ' + value).AsPoint3F();
            this["gridSize"] = value;

            this.syncGui();
        }

        //-----------------------------------------------------------------------------
        [ConsoleInteraction]
        public bool areAllSelectedObjectsOfType(string className)
        {
            SimSet activeSelection = this.getActiveSelection();
            if (!activeSelection.isObject())
                return false;

            int count = activeSelection.getCount();
            for (uint i = 0; i < count; i ++)
                {
                SimObject obj = activeSelection.getObject(i);
                if (!obj.isMemberOfClass(className))
                    return false;
                }

            return true;
        }

        //-----------------------------------------------------------------------------
        [ConsoleInteraction]
        public void syncGui()
        {
            EditorTree EditorTree = "EditorTree";
            editor Editor = "Editor";
            EditorGui EditorGui = "EditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";
            GuiControl EWorldEditorToolbar = "EWorldEditorToolbar";
            EditorGui.objectCenterDropdown objectCenterDropdown = "objectCenterDropdown";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            EditorGui.objectTransformDropdown objectTransformDropdown = "objectTransformDropdown";
            GuiControl SnapToBar = "SnapToBar";
            ESnapOptions ESnapOptions = "ESnapOptions";

            MenuHandlers.EditorEditMenu EditMenu = EditorGui.menuBar.FOT("EditMenu");
            GuiBitmapButtonCtrl LockSelection = EWTreeWindow.FOT("LockSelection");
            GuiBitmapButtonCtrl boundingBoxColBtn = EWorldEditorToolbar.FOT("boundingBoxColBtn");
            GuiBitmapButtonCtrl centerObject = EWorldEditorToolbar.FOT("centerObject");
            GuiIconButtonCtrl objectBoundsBtn = objectCenterDropdown.FOT("objectBoundsBtn");
            GuiIconButtonCtrl objectBoxBtn = objectCenterDropdown.FOT("objectBoxBtn");
            GuiBitmapButtonCtrl objectTransform = EWorldEditorToolbar.FOT("objectTransform");
            GuiBitmapButtonCtrl renderHandleBtn = EWorldEditorToolbar.FOT("renderHandleBtn");
            GuiBitmapButtonCtrl renderTextBtn = EWorldEditorToolbar.FOT("renderTextBtn");
            GuiTextEditCtrl softSnapSizeTextEdit = EWorldEditorToolbar.FOT("softSnapSizeTextEdit");
            GuiIconButtonCtrl objectTransformBtn = objectTransformDropdown.FOT("objectTransformBtn");
            GuiIconButtonCtrl worldTransformBtn = objectTransformDropdown.FOT("worldTransformBtn");
            GuiBitmapButtonCtrl objectSnapBtn = SnapToBar.FOT("objectSnapBtn");
            GuiBitmapButtonCtrl objectGridSnapBtn = SnapToBar.FOT("objectGridSnapBtn");
            GuiTextEditCtrl SnapSize = ESnapOptions.FOT("SnapSize");
            GuiTextEditCtrl GridSize = ESnapOptions.FOT("gridSize");
            GuiCheckBoxCtrl GridSnapButton = ESnapOptions.FOT("GridSnapButton");
            GuiButtonCtrl NoSnapButton = ESnapOptions.FOT("NoSnapButton");

            this.syncToolPalette();

            EditorTree.update();
            Editor.getUndoManager().call("updateUndoMenu", EditMenu);
            EditorGuiStatusBar.setSelectionObjectsByCount(this.getSelectionSize().AsString());

            LockSelection.setStateOn(this.getSelectionLockCount() > 0);

            boundingBoxColBtn.setStateOn(this["boundingBoxCollision"].AsBool());

            if (this.objectsUseBoxCenter)
                {
                centerObject.setBitmap("tools/gui/images/menubar/bounds-center");
                objectBoundsBtn.setStateOn(true);
                }
            else
                {
                centerObject.setBitmap("tools/gui/images/menubar/object-center");
                objectBoxBtn.setStateOn(true);
                }

            if (GlobalGizmoProfile.getFieldValue("alignment", -1) == "Object")
                {
                objectTransform.setBitmap("tools/gui/images/menubar/object-transform");
                objectTransformBtn.setStateOn(true);
                }
            else
                {
                objectTransform.setBitmap("tools/gui/images/menubar/world-transform");
                worldTransformBtn.setStateOn(true);
                }

            renderHandleBtn.setStateOn(this["renderObjHandle"].AsBool());
            renderTextBtn.setStateOn(this["renderObjText"].AsBool());

            objectSnapBtn.setStateOn(this.getSoftSnap());
            softSnapSizeTextEdit.setText(this.getSoftSnapSize().AsString());
            SnapSize.setText(this.getSoftSnapSize().AsString());
            GridSize.setText(this.getGridSize());

            GridSnapButton.setStateOn(this.getGridSnap());
            objectGridSnapBtn.setStateOn(this.getGridSnap());
            NoSnapButton.setStateOn(!this.stickToGround && !this.getSoftSnap() && !this.getGridSnap());
        }

        [ConsoleInteraction]
        public void syncToolPalette()
        {
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            EWorldEditorNoneModeBtn EWorldEditorNoneModeBtn = "EWorldEditorNoneModeBtn";
            EWorldEditorMoveModeBtn EWorldEditorMoveModeBtn = "EWorldEditorMoveModeBtn";
            EWorldEditorRotateModeBtn EWorldEditorRotateModeBtn = "EWorldEditorRotateModeBtn";
            EWorldEditorScaleModeBtn EWorldEditorScaleModeBtn = "EWorldEditorScaleModeBtn";

            switch (GlobalGizmoProfile["mode"])
                {
                    case "None":
                        EWorldEditorNoneModeBtn.performClick();
                        return;
                    case "Move":
                        EWorldEditorMoveModeBtn.performClick();
                        return;
                    case "Rotate":
                        EWorldEditorRotateModeBtn.performClick();
                        return;
                    case "Scale":
                        EWorldEditorScaleModeBtn.performClick();
                        return;
                }
        }

        [ConsoleInteraction]
        public void addSimGroup(bool groupCurrentSelection)
        {
            SimGroup MissionGroup = "MissionGroup";
            editor Editor = "Editor";
            EditorTree EditorTree = "EditorTree";

            SimSet activeSelection = this.getActiveSelection();
            if (activeSelection.getObjectIndex(MissionGroup) != -1)
                {
                messageBox.MessageBoxOK("Error", "Cannot add MissionGroup to a new SimGroup");
                return;
                }

            // Find our parent.

            SimGroup parent = MissionGroup;
            if (!groupCurrentSelection && activeSelection.isObject() && activeSelection.getCount() > 0)
                {
                SimObject firstSelectedObject = activeSelection.getObject(0);
                if (firstSelectedObject.isMemberOfClass("SimGroup"))
                    parent = (SimGroup) firstSelectedObject;
                else if (firstSelectedObject.getId() != MissionGroup.getId())
                    parent = firstSelectedObject["parentGroup"];
                }

            // If we are about to do a group-selected as well,
            // starting recording an undo compound.

            if (groupCurrentSelection)
                Editor.getUndoManager().pushCompound("Group Selected");

            // Create the SimGroup.

            ObjectCreator objectCreator = new ObjectCreator("SimGroup");
            objectCreator["parentGroup"] = parent;

            SimGroup xobject = objectCreator.Create();

            Extendable.MECreateUndoAction.submit(xobject);

            // Put selected objects into the group, if requested.

            if (groupCurrentSelection && activeSelection.isObject())
                {
                UndoActionReparentObjects UndoActionReparentObjects = "UndoActionReparentObjects";
                UndoActionReparentObjects undo = UndoActionReparentObjects.create(EditorTree);

                int numObjects = activeSelection.getCount();
                for (uint i = 0; i < numObjects; i ++)
                    {
                    SimObject sel = activeSelection.getObject(i);
                    undo.add(sel, sel.parentGroup, xobject);
                    xobject.add(sel);
                    }

                undo.addToManager(Editor.getUndoManager());
                }

            // Stop recording for group-selected.

            if (groupCurrentSelection)
                Editor.getUndoManager().popCompound();

            // When not grouping selection, make the newly created SimGroup the
            // current selection.

            if (!groupCurrentSelection)
                {
                this.clearSelection();
                this.selectObject(xobject);
                }

            // Refresh the Gui.

            this.syncGui();
        }

        [ConsoleInteraction]
        public void toggleLockChildren(SimGroup simGroup)
        {
            for (uint i = 0; i < simGroup.getCount(); i++)
                {
                SimObject child = simGroup.getObject(i);
                if (child.isMemberOfClass("SimGroup"))
                    this.toggleLockChildren((SimGroup) child);
                else
                    child.setLocked(!child["locked"].AsBool());
                }

            this.syncGui();
        }

        [ConsoleInteraction]
        public void toggleHideChildren(SimGroup simGroup)
        {
            for (uint i = 0; i < simGroup.getCount(); i++)
                {
                SimObject child = simGroup.getObject(i);
                if (child.isMemberOfClass("SimGroup"))
                    this.toggleHideChildren((SimGroup) child);
                else
                    this.hideObject(child, (!child["hidden"].AsBool()));
                }

            this.syncGui();
        }

        [ConsoleInteraction]
        public void convertSelectionToPolyhedralObjects(string className)
        {
            editor Editor = "Editor";

            SimGroup group = this.getNewObjectGroup();
            UndoManager undoManager = Editor.getUndoManager();

            SimSet activeSelection = this.getActiveSelection();
            while (activeSelection.getCount() != 0)
                {
                SimObject oldObject = activeSelection.getObject(0);
                SimObject newObject = this.createPolyhedralObject(className, oldObject);
                if (newObject.isObject())
                    {
                    undoManager.pushCompound("Convert ConvexShape to " + className);
                    newObject.parentGroup = oldObject.parentGroup;
                    Extendable.MECreateUndoAction.submit(newObject);
                    Extendable.MEDeleteUndoAction.submit(oldObject, false);
                    undoManager.popCompound();
                    }
                }
        }

        [ConsoleInteraction]
        public void convertSelectionToConvexShape()
        {
            editor Editor = "Editor";

            SimGroup group = this.getNewObjectGroup();
            UndoManager undoManager = Editor.getUndoManager();

            SimSet activeSelection = this.getActiveSelection();
            while (activeSelection.getCount() != 0)
                {
                SimObject oldObject = activeSelection.getObject(0);
                SimObject newObject = this.createConvexShapeFrom(oldObject);
                if (newObject.isObject())
                    {
                    undoManager.pushCompound("Convert " + oldObject.getClassName() + " to ConvexShape");
                    newObject.parentGroup = oldObject.parentGroup;
                    Extendable.MECreateUndoAction.submit(newObject);
                    Extendable.MEDeleteUndoAction.submit(oldObject, false);
                    undoManager.popCompound();
                    }
                }
        }

        [ConsoleInteraction]
        public override string getNewObjectGroup()
        {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

            return EWCreatorWindow.getNewObjectGroup();
        }

        [ConsoleInteraction]
        public void deleteMissionObject(SimObject xobject)
        {
            EditorTree EditorTree = "EditorTree";

            // Unselect in editor tree.

            int id = EditorTree.findItemByObjectId(xobject);
            EditorTree.selectItem(id, false);

            // Delete object.

            Extendable.MEDeleteUndoAction.submit(xobject, false);
            this.isDirty = true;
            EditorTree.buildVisibleTree(true);
        }

        [ConsoleInteraction]
        public void selectAllObjectsInSet(SimGroup set, bool deselect)
        {
            if (!set.isObject())
                return;

            for (uint i = 0; i < set.getCount(); i++)
                {
                SimObject obj = set.getObject(i);

                if (deselect)
                    this.unselectObject(obj);
                else
                    this.selectObject(obj);
                }
        }

        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (EWorldEditorAlignPopup))]
        public class EWorldEditorAlignPopup : GuiPopUpMenuCtrl
        {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
            {
                GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

                if (GlobalGizmoProfile["mode"] == "Scale" && text == "World")
                    {
                    this.setSelected(1);
                    return;
                    }

                GlobalGizmoProfile.alignment = text;
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorAlignPopup ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorAlignPopup ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorAlignPopup ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorAlignPopup(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorAlignPopup) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorAlignPopup));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorAlignPopup ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorAlignPopup(int simobjectid)
            {
                return (EWorldEditorAlignPopup) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorAlignPopup));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorAlignPopup ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorAlignPopup(uint simobjectid)
            {
                return (EWorldEditorAlignPopup) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorAlignPopup));
            }

            #endregion
        }

        [TypeConverter(typeof (EWorldEditorCameraSpeed))]
        public class EWorldEditorCameraSpeed : GuiTextEditCtrl
        {
            [ConsoleInteraction]
            public void updateMenuBar(GuiControl editorBarCtrl)
            {
                EditorGui.CameraSpeedDropdownCtrlContainer CameraSpeedDropdownCtrlContainer = "CameraSpeedDropdownCtrlContainer";
                MenuHandlers.EditorCameraSpeedMenu EditorCameraSpeedOptions = "EditorCameraSpeedOptions";
                GuiSliderCtrl slider = CameraSpeedDropdownCtrlContainer.FOT("slider");

                string value;

                // Update Toolbar TextEdit
                if (editorBarCtrl.getId() == slider.getId())
                    {
                    value = ((GuiSliderCtrl) editorBarCtrl).getValue().AsString();
                    this.setText(value);
                    sGlobal["$Camera::movementSpeed"] = value;
                    }

                // Update Toolbar Slider
                if (editorBarCtrl.getId() == this.getId())
                    {
                    value = ((GuiTextEditCtrl) editorBarCtrl).getText();
                    if (value != "")
                        {
                        if (value.AsFloat() <= 0) // camera speed must be >= 0
                            {
                            value = "1";
                            editorBarCtrl.call("setText", value);
                            }
                        slider.setValue(value);
                        sGlobal["$Camera::movementSpeed"] = value;
                        }
                    }

                // Update Editor
                EditorCameraSpeedOptions.checkRadioItem(0, 6, -1);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorCameraSpeed ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorCameraSpeed ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorCameraSpeed ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorCameraSpeed(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorCameraSpeed) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorCameraSpeed));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorCameraSpeed ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorCameraSpeed(int simobjectid)
            {
                return (EWorldEditorCameraSpeed) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorCameraSpeed));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorCameraSpeed ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorCameraSpeed(uint simobjectid)
            {
                return (EWorldEditorCameraSpeed) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorCameraSpeed));
            }

            #endregion
        }

        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (EWorldEditorMoveModeBtn))]
        public class EWorldEditorMoveModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
                EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

                GlobalGizmoProfile["mode"] = "Move";

                string cmdCtrl = "CTRL";
                if (sGlobal["$platform"] == "macos")
                    cmdCtrl = "CMD";

                EditorGuiStatusBar.setInfo("Move selection.  SHIFT while dragging duplicates objects.  " + cmdCtrl + " to toggle soft snap.  ALT to toggle grid snap.");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorMoveModeBtn ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorMoveModeBtn ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorMoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorMoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorMoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorMoveModeBtn(int simobjectid)
            {
                return (EWorldEditorMoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorMoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorMoveModeBtn(uint simobjectid)
            {
                return (EWorldEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorMoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (EWorldEditorNoneModeBtn))]
        public class EWorldEditorNoneModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
                EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

                GlobalGizmoProfile.mode = "None";

                EditorGuiStatusBar.setInfo("Selection arrow.");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorNoneModeBtn ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorNoneModeBtn ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorNoneModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorNoneModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorNoneModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorNoneModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorNoneModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorNoneModeBtn(int simobjectid)
            {
                return (EWorldEditorNoneModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorNoneModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorNoneModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorNoneModeBtn(uint simobjectid)
            {
                return (EWorldEditorNoneModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorNoneModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (EWorldEditorRotateModeBtn))]
        public class EWorldEditorRotateModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
                EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

                GlobalGizmoProfile["mode"] = "Rotate";

                EditorGuiStatusBar.setInfo("Rotate selection.");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorRotateModeBtn ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorRotateModeBtn ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorRotateModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorRotateModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorRotateModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorRotateModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorRotateModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorRotateModeBtn(int simobjectid)
            {
                return (EWorldEditorRotateModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorRotateModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorRotateModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorRotateModeBtn(uint simobjectid)
            {
                return (EWorldEditorRotateModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorRotateModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (EWorldEditorScaleModeBtn))]
        public class EWorldEditorScaleModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
                EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

                GlobalGizmoProfile["mode"] = "Scale";

                EditorGuiStatusBar.setInfo("Scale selection.");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorScaleModeBtn ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorScaleModeBtn ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorScaleModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorScaleModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorScaleModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorScaleModeBtn(int simobjectid)
            {
                return (EWorldEditorScaleModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorScaleModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorScaleModeBtn(uint simobjectid)
            {
                return (EWorldEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorScaleModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (EWorldEditorToggleCamera))]
        public class EWorldEditorToggleCamera : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public void toggleBitmap()
            {
                string image;
                string currentImage = this.bitmap;

                if (currentImage == "tools/worldEditor/images/toolbar/player")
                    image = "tools/worldEditor/images/toolbar/camera";
                else
                    image = "tools/worldEditor/images/toolbar/player";

                this.setBitmap(image);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorToggleCamera ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EWorldEditorToggleCamera ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EWorldEditorToggleCamera ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorToggleCamera(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EWorldEditorToggleCamera) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorToggleCamera));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorToggleCamera ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorToggleCamera(int simobjectid)
            {
                return (EWorldEditorToggleCamera) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorToggleCamera));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorToggleCamera ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorToggleCamera(uint simobjectid)
            {
                return (EWorldEditorToggleCamera) Omni.self.getSimObject(simobjectid, typeof (EWorldEditorToggleCamera));
            }

            #endregion
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EWorldEditor ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(EWorldEditor ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(EWorldEditor ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EWorldEditor(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (EWorldEditor) Omni.self.getSimObject(simobjectid, typeof (EWorldEditor));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EWorldEditor ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EWorldEditor(int simobjectid)
        {
            return (EWorldEditor) Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditor));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EWorldEditor ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EWorldEditor(uint simobjectid)
        {
            return (EWorldEditor) Omni.self.getSimObject(simobjectid, typeof (EWorldEditor));
        }

        #endregion
    }
}