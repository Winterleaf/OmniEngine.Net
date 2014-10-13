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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEditorPlugin>))]
    public class ShapeEditorPlugin : EditorPlugin
    {
        private static readonly pInvokes omni = new pInvokes();

        internal ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        [ConsoleInteraction]
        public void initialize()
        {
            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "escape", "ToolsToolbarArray->WorldEditorInspectorPalette.performClick();", "");
            map.bindCmd("keyboard", "1", "ShapeEditorNoneModeBtn.performClick();", "");
            map.bindCmd("keyboard", "2", "ShapeEditorMoveModeBtn.performClick();", "");
            map.bindCmd("keyboard", "3", "ShapeEditorRotateModeBtn.performClick();", "");
            //%map.bindCmd( keyboard, "4", "ShapeEditorScaleModeBtn.performClick();", "" ); // not needed for the shape editor
            map.bindCmd("keyboard", "n", "ShapeEditorToolbar->showNodes.performClick();", "");
            map.bindCmd("keyboard", "t", "ShapeEditorToolbar->ghostMode.performClick();", "");
            map.bindCmd("keyboard", "r", "ShapeEditorToolbar->wireframeMode.performClick();", "");
            map.bindCmd("keyboard", "f", "ShapeEditorToolbar->fitToShapeBtn.performClick();", "");
            map.bindCmd("keyboard", "g", "ShapeEditorToolbar->showGridBtn.performClick();", "");
            map.bindCmd("keyboard", "h", "ShapeEdSelectWindow->tabBook.selectPage( 2 );", ""); // Load help tab
            map.bindCmd("keyboard", "l", "ShapeEdSelectWindow->tabBook.selectPage( 1 );", ""); // load Library Tab
            map.bindCmd("keyboard", "j", "ShapeEdSelectWindow->tabBook.selectPage( 0 );", ""); // load scene object Tab
            map.bindCmd("keyboard", "SPACE", "ShapeEdAnimWindow.togglePause();", "");
            map.bindCmd("keyboard", "i", "ShapeEdSequences.onEditSeqInOut(\"in\", ShapeEdSeqSlider.getValue());", "");
            map.bindCmd("keyboard", "o", "ShapeEdSequences.onEditSeqInOut(\"out\", ShapeEdSeqSlider.getValue());", "");
            map.bindCmd("keyboard", "shift -", "ShapeEdSeqSlider.setValue(ShapeEdAnimWindow-->seqIn.getText());", "");
            map.bindCmd("keyboard", "shift =", "ShapeEdSeqSlider.setValue(ShapeEdAnimWindow-->seqOut.getText());", "");
            map.bindCmd("keyboard", "=", "ShapeEdAnimWindow-->stepFwdBtn.performClick();", "");
            map.bindCmd("keyboard", "-", "ShapeEdAnimWindow-->stepBkwdBtn.performClick();", "");

            this.map = map;

            this.initSettings();
        }

        [ConsoleInteraction]
        public static void SetToggleButtonValue(GuiControl ctrl, string value)
        {
            if (ctrl.getValue() != value)
                ctrl.call("performClick");
        }

        // Replace the command field in an Editor PopupMenu item (returns the original value)
        [ConsoleInteraction]
        public string replaceMenuCmd(string menuTitle, string id, string newCmd)
        {
            EditorGui EditorGui = "EditorGui";

            MenuBuilder menu = EditorGui.findMenu(menuTitle);
            string cmd = Util.getField(menu["item[" + id + "]"], 2);
            menu.setItemCommand(id, newCmd);

            return cmd;
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Shape Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Shape Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("ShapeEditorPlugin", "ShapeEditorPalette", Util._expandFilename("tools/worldEditor/images/toolbar/shape-editor"), tooltip);

            // Add ourselves to the Editor Settings window
            //exec( "./gui/ShapeEditorSettingsTab.gui" );
            //console.Call("ShapeEditorSettingsTab_initialize");
            ShapeEditorSettingsTab.initialize();

            ESettingsWindow ESettingsWindow = "ESettingsWindow";
            ESettingsWindow.addTabPage("EShapeEditorSettingsPage");

            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            ShapeEdPropWindow.attachTo("ShapeEdSelectWindow");
            ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
            ShapeEdAnimWindow.resize(-1, 526, 593, 53);

            // Initialise gui
            ShapeEditor.ShapeEdSeqNodeTabBook ShapeEdSeqNodeTabBook = "ShapeEdSeqNodeTabBook";
            ShapeEdSeqNodeTabBook.selectPage(0);
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            GuiTabBookCtrl ShapeEdAdvancedWindowtabBook = ShapeEdAdvancedWindow.FOT("tabBook");
            ShapeEdAdvancedWindowtabBook.selectPage(0);

            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            GuiTabBookCtrl ShapeEdSelectWindowtabBook = ShapeEdSelectWindow.FOT("tabBook");
            ShapeEdSelectWindowtabBook.selectPage(0);
            ShapeEdSelectWindow.navigate("");

            ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
            GuiBitmapButtonCtrl orbitNodeBtn = ShapeEditorToolbar.FOT("orbitNodeBtn");
            SetToggleButtonValue(orbitNodeBtn, "0");
            GuiBitmapButtonCtrl ghostMode = ShapeEditorToolbar.FOT("ghostMode");
            SetToggleButtonValue(ghostMode, "0");

            // Initialise hints menu
            SimGroup ShapeHintGroup = "ShapeHintGroup";
            ShapeEditor.ShapeEdHintMenu ShapeEdHintMenu = "ShapeEdHintMenu";
            ShapeEdHintMenu.clear();
            int count = ShapeHintGroup.getCount();
            for (uint i = 0; i < count; i++)
                {
                SimObject hint = ShapeHintGroup.getObject(i);
                ShapeEdHintMenu.add(hint["objectType"], hint);
                }
        }

        [ConsoleInteraction]
        public void open(string filename)
        {
            EditorGui EditorGui = "EditorGui";
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
            ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
            ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEditor.ShapeEdNodes ShapeEdNodes = "ShapeEdNodes";
            Settings EditorSettings = "EditorSettings";
            EWorldEditor EWorldEditor = "EWorldEditor";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            ShapeEditor.ShapeEdShapeTreeView ShapeEdShapeTreeView = "ShapeEdShapeTreeView";
            ShapeEditor.ShapeEdPreviewGui ShapeEdPreviewGui = "ShapeEdPreviewGui";
            ShapeEditorActions.ShapeEdUndoManager ShapeEdUndoManager = "ShapeEdUndoManager";
            SimGroup MissionGroup = "MissionGroup";
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            editor Editor = "Editor";
            ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
            ShapeEditor ShapeEditor = "ShapeEditor";

            GuiBitmapButtonCtrl wireframeMode = ShapeEditorToolbar.FOT("wireframeMode");
            GuiBitmapButtonCtrl showAdvanced = ShapeEditorToolbar.FOT("showAdvanced");
            GuiIconButtonCtrl worldTransform = ShapeEdNodes.FOT("worldTransform");
            GuiIconButtonCtrl objectTransform = ShapeEdNodes.FOT("objectTransform");
            GuiCheckBoxCtrl highlightMaterial = ShapeEdMaterials.FOT("highlightMaterial");
            GuiCanvas Canvas = "Canvas";

            if (!this["isActivated"].AsBool())
                {
                // Activate the Shape Editor
                EditorGui.setEditor(this, false);

                // Get editor settings (note the sun angle is not configured in the settings
                // dialog, so apply the settings here instead of in readSettings)
                this.readSettings();
                ShapeEdShapeView["sunAngleX"] = EditorSettings.value("ShapeEditor/SunAngleX");
                ShapeEdShapeView["sunAngleZ"] = EditorSettings.value("ShapeEditor/SunAngleZ");
                EWorldEditor["forceLoadDAE"] = EditorSettings.value("forceLoadDAE");

                bGlobal["$wasInWireFrameMode"] = bGlobal["$gfx::wireframe"];
                wireframeMode.setStateOn(bGlobal["$gfx::wireframe"]);

                if (GlobalGizmoProfile.getFieldValue("alignment", -1) == "Object")
                    objectTransform.setStateOn(true);
                else
                    worldTransform.setStateOn(true);

                // Initialise and show the shape editor
                ShapeEdShapeTreeView.open(MissionGroup);
                ShapeEdShapeTreeView.buildVisibleTree(true);

                ShapeEdPreviewGui.setVisible(true);
                ShapeEdSelectWindow.setVisible(true);
                ShapeEdPropWindow.setVisible(true);
                ShapeEdAnimWindow.setVisible(true);
                ShapeEdAdvancedWindow.setVisible(showAdvanced.getValue().AsBool());
                ShapeEditorToolbar.setVisible(true);
                EditorGui.bringToFront(ShapeEdPreviewGui);

                ((GuiBitmapButtonCtrl) ToolsPaletteArray.FOT("WorldEditorMove")).performClick();
                this.map.push();

                // Switch to the ShapeEditor UndoManager
                this["oldUndoMgr"] = Editor.getUndoManager();
                Editor.setUndoManager(ShapeEdUndoManager);

                ShapeEdShapeView.setDisplayType(EditorGui["currentDisplayType"].AsInt());
                this.initStatusBar();

                // Customise menu bar
                this["oldCamFitCmd"] = this.replaceMenuCmd("Camera", "8", "ShapeEdShapeView.fitToShape();");
                this["oldCamFitOrbitCmd"] = this.replaceMenuCmd("Camera", "9", "ShapeEdShapeView.fitToShape();");

                base.onActivated();
                }

            // Select the new shape
            if (ShapeEditor.shape.isObject() && (ShapeEditor.shape["baseShape"] == filename))
                {
                // Shape is already selected => re-highlight the selected material if necessary
                ShapeEdMaterials.updateSelectedMaterial(highlightMaterial.getValue().AsBool());
                }
            else if (filename != "")
                {
                ShapeEditor.selectShape(filename, ShapeEditor.isDirty());

                // 'fitToShape' only works after the GUI has been rendered, so force a repaint first
                Canvas.repaint(0);
                ShapeEdShapeView.fitToShape();
                }
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";
            ShapeEditor.ShapeEdShapeTreeView ShapeEdShapeTreeView = "ShapeEdShapeTreeView";
            ShapeEditor ShapeEditor = "ShapeEditor";
            ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            GuiCanvas Canvas = "Canvas";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            this.open("");

            // Try to start with the shape selected in the world editor
            int count = EWorldEditor.getSelectionSize();
            for (int i = 0; i < count; i++)
                {
                SimObject obj = EWorldEditor.getSelectedObject(i);
                string shapeFile = ShapeEditor.getObjectShapeFile(obj);
                if (shapeFile != "")
                    {
                    if (!ShapeEditor.shape.isObject() || (ShapeEditor.shape["baseShape"] != shapeFile))
                        {
                        // Call the 'onSelect' method directly if the object is not in the
                        // MissionGroup tree (such as a Player or Projectile object).
                        ShapeEdShapeTreeView.clearSelection();
                        if (!ShapeEdShapeTreeView.selectItem(obj))
                            ShapeEdShapeTreeView.onSelect(obj, "");

                        // 'fitToShape' only works after the GUI has been rendered, so force a repaint first
                        Canvas.repaint(0);
                        ShapeEdShapeView.fitToShape();
                        }
                    break;
                    }
                }
        }

        [ConsoleInteraction]
        public void initStatusBar()
        {
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ShapeEditor ShapeEditor = "ShapeEditor";

            EditorGuiStatusBar.setInfo("Shape editor ( Shift Click ) to speed up camera.");
            if (ShapeEditor.shape != 0)
                EditorGuiStatusBar.setSelection(ShapeEditor.shape["baseShape"]);
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
            ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
            ShapeEditor.ShapeEdPreviewGui ShapeEdPreviewGui = "ShapeEdPreviewGui";
            editor Editor = "Editor";
            ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
            ShapeEditor ShapeEditor = "ShapeEditor";
            MaterialEditorPropertiesWindow MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013
            this.writeSettings();

            // Notify game objects if shape has been modified
            if (ShapeEditor.isDirty())
                ShapeEditor.shape.notifyShapeChanged();

            bGlobal["$gfx::wireframe"] = bGlobal["$wasInWireFrameMode"];

            ShapeEdMaterials.updateSelectedMaterial(false);
            ShapeEditorToolbar.setVisible(false);

            ShapeEdPreviewGui.setVisible(false);
            ShapeEdSelectWindow.setVisible(false);
            ShapeEdPropWindow.setVisible(false);
            ShapeEdAnimWindow.setVisible(false);
            ShapeEdAdvancedWindow.setVisible(false);
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            if (MaterialEditorPropertiesWindow.visible)
                ShapeEdMaterials.editSelectedMaterialEnd(true);
            //Copyright Winterleaf Entertainment L.L.C. 2013
            this.map.pop();

            // Restore the original undo manager
            Editor.setUndoManager(this["oldUndoMgr"]);

            // Restore menu bar
            this.replaceMenuCmd("Camera", "8", this["oldCamFitCmd"]);
            this.replaceMenuCmd("Camera", "9", this["oldCamFitOrbitCmd"]);

            base.onDeactivated();
        }

        [ConsoleInteraction]
        public override void onExitMission()
        {
            ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEditor ShapeEditor = "ShapeEditor";
            ShapeEditorActions.ShapeEdUndoManager ShapeEdUndoManager = "ShapeEdUndoManager";
            ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
            GuiTextListCtrl ShapeEdMaterialList = "ShapeEdMaterialList";
            ShapeEditor.ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            ShapeEditor.ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
            ShapeEditor.ShapeEdThreadList ShapeEdThreadList = "ShapeEdThreadList";

            GuiTextListCtrl mountList = ShapeEdMountWindow.FOT("mountList");
            GuiTextListCtrl seqList = ShapeEdThreadWindow.FOT("seqList");

            // unselect the current shape
            ShapeEdShapeView.setModel("");
            if (ShapeEditor.shape != 0)
                ShapeEditor.shape.delete();
            ShapeEditor.shape = 0;
            ShapeEdUndoManager.clearAll();
            ShapeEditor.setDirty(false);

            ShapeEdSequenceList.clear();
            ShapeEdNodeTreeView.removeItem(0);
            ShapeEdPropWindow.update_onNodeSelectionChanged(-1);
            ShapeEdDetailTree.removeItem(0);
            ShapeEdMaterialList.clear();

            mountList.clear();
            seqList.clear();
            ShapeEdThreadList.clear();
        }

        [ConsoleInteraction]
        public void openShape(string path, bool discardChangesToCurrent)
        {
            EditorGui EditorGui = "EditorGui";
            ShapeEditor ShapeEditor = "ShapeEditor";
            ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            EditorGui.setEditor(this, false);

            if (ShapeEditor.isDirty() && !discardChangesToCurrent)
                {
                messageBox.MessageBoxYesNo("Save Changes?", "Save changes to current shape?", "ShapeEditor.saveChanges(); ShapeEditorPlugin.openShape(\"" + path + "\");", "ShapeEditorPlugin.openShape(\"" + path + "\");");
                return;
                }

            ShapeEditor.selectShape(path, !discardChangesToCurrent);
            ShapeEdShapeView.fitToShape();
        }

        [ConsoleInteraction]
        public static void shapeEditorWireframeMode()
        {
            ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
            GuiBitmapButtonCtrl wireframeMode = ShapeEditorToolbar.FOT("wireframeMode");

            omni.bGlobal["$gfx::wireframe"] = !omni.bGlobal["$gfx::wireframe"];
            wireframeMode.setStateOn(omni.bGlobal["$gfx::wireframe"]);
        }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ShapeEditor", true);

            // Display options
            EditorSettings.setDefaultValue("BackgroundColor", "0 0 0 100");
            EditorSettings.setDefaultValue("HighlightMaterial", "1");
            EditorSettings.setDefaultValue("ShowNodes", "1");
            EditorSettings.setDefaultValue("ShowBounds", "0");
            EditorSettings.setDefaultValue("ShowObjBox", "1");
            EditorSettings.setDefaultValue("RenderMounts", "1");
            EditorSettings.setDefaultValue("RenderCollision", "0");

            // Grid
            EditorSettings.setDefaultValue("ShowGrid", "1");
            EditorSettings.setDefaultValue("GridSize", "0.1");
            EditorSettings.setDefaultValue("GridDimension", "40 40");

            // Sun
            EditorSettings.setDefaultValue("SunDiffuseColor", "255 255 255 255");
            EditorSettings.setDefaultValue("SunAmbientColor", "180 180 180 255");
            EditorSettings.setDefaultValue("SunAngleX", "45");
            EditorSettings.setDefaultValue("SunAngleZ", "135");

            // Sub-windows
            EditorSettings.setDefaultValue("AdvancedWndVisible", "1");

            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            ShapeEditor.ShapeEdPreviewGui ShapeEdPreviewGui = "ShapeEdPreviewGui";
            ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
            ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
            ShapeEditor.ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            GuiSwatchButtonCtrl previewBackground = ShapeEdPreviewGui.FOT("previewBackground");
            GuiCheckBoxCtrl highlightMaterial = ShapeEdMaterials.FOT("highlightMaterial");
            GuiBitmapButtonCtrl showNodes = ShapeEditorToolbar.FOT("showNodes");
            GuiBitmapButtonCtrl showBounds = ShapeEditorToolbar.FOT("showBounds");
            GuiBitmapButtonCtrl showObjBox = ShapeEditorToolbar.FOT("showObjBox");
            GuiBitmapButtonCtrl showAdvanced = ShapeEditorToolbar.FOT("showAdvanced");
            GuiBitmapButtonCtrl showGridBtn = ShapeEditorToolbar.FOT("showGridBtn");
            GuiBitmapButtonCtrl renderColMeshes = ShapeEditorToolbar.FOT("renderColMeshes");
            GuiCheckBoxCtrl renderMounts = ShapeEdMountWindow.FOT("renderMounts");

            EditorSettings.beginGroup("ShapeEditor", true);

            // Display options
            previewBackground["color"] = ColorPickerDlg.ColorIntToFloat(EditorSettings.value("BackgroundColor"));
            SetToggleButtonValue(highlightMaterial, EditorSettings.value("HighlightMaterial"));
            SetToggleButtonValue(showNodes, EditorSettings.value("ShowNodes"));
            SetToggleButtonValue(showBounds, EditorSettings.value("ShowBounds"));
            SetToggleButtonValue(showObjBox, EditorSettings.value("ShowObjBox"));
            SetToggleButtonValue(renderColMeshes, EditorSettings.value("RenderCollision"));
            SetToggleButtonValue(renderMounts, EditorSettings.value("RenderMounts"));

            // Grid
            SetToggleButtonValue(showGridBtn, EditorSettings.value("ShowGrid"));
            ShapeEdShapeView["gridSize"] = EditorSettings.value("GridSize");
            ShapeEdShapeView["gridDimension"] = EditorSettings.value("GridDimension");

            // Sun
            ShapeEdShapeView["sunDiffuse"] = EditorSettings.value("SunDiffuseColor");
            ShapeEdShapeView["sunAmbient"] = EditorSettings.value("SunAmbientColor");

            // Sub-windows
            SetToggleButtonValue(showAdvanced, EditorSettings.value("AdvancedWndVisible"));

            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";
            ShapeEditor.ShapeEdPreviewGui ShapeEdPreviewGui = "ShapeEdPreviewGui";
            ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
            ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
            ShapeEditor.ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            GuiSwatchButtonCtrl previewBackground = ShapeEdPreviewGui.FOT("previewBackground");
            GuiCheckBoxCtrl highlightMaterial = ShapeEdMaterials.FOT("highlightMaterial");
            GuiBitmapButtonCtrl showNodes = ShapeEditorToolbar.FOT("showNodes");
            GuiBitmapButtonCtrl showBounds = ShapeEditorToolbar.FOT("showBounds");
            GuiBitmapButtonCtrl showObjBox = ShapeEditorToolbar.FOT("showObjBox");
            GuiBitmapButtonCtrl showAdvanced = ShapeEditorToolbar.FOT("showAdvanced");
            GuiBitmapButtonCtrl showGridBtn = ShapeEditorToolbar.FOT("showGridBtn");
            GuiBitmapButtonCtrl renderColMeshes = ShapeEditorToolbar.FOT("renderColMeshes");
            GuiCheckBoxCtrl renderMounts = ShapeEdMountWindow.FOT("renderMounts");

            EditorSettings.beginGroup("ShapeEditor", true);

            // Display options
            EditorSettings.setValue("BackgroundColor", ColorPickerDlg.ColorFloatToInt(previewBackground["color"]));
            EditorSettings.setValue("HighlightMaterial", highlightMaterial.getValue());
            EditorSettings.setValue("ShowNodes", showNodes.getValue());
            EditorSettings.setValue("ShowBounds", showBounds.getValue());
            EditorSettings.setValue("ShowObjBox", showObjBox.getValue());
            EditorSettings.setValue("RenderCollision", renderColMeshes.getValue());
            EditorSettings.setValue("RenderMounts", renderMounts.getValue());

            // Grid
            EditorSettings.setValue("ShowGrid", showGridBtn.getValue());
            EditorSettings.setValue("GridSize", ShapeEdShapeView["gridSize"]);
            EditorSettings.setValue("GridDimension", ShapeEdShapeView["gridDimension"]);

            // Sun
            EditorSettings.setValue("SunDiffuseColor", ShapeEdShapeView["sunDiffuse"]);
            EditorSettings.setValue("SunAmbientColor", ShapeEdShapeView["sunAmbient"]);
            EditorSettings.setValue("SunAngleX", ShapeEdShapeView["sunAngleX"]);
            EditorSettings.setValue("SunAngleZ", ShapeEdShapeView["sunAngleZ"]);

            // Sub-windows
            EditorSettings.setValue("AdvancedWndVisible", showAdvanced.getValue());

            EditorSettings.endGroup();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ShapeEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(ShapeEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(ShapeEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ShapeEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ShapeEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEditorPlugin(int simobjectid)
        {
            return (ShapeEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEditorPlugin(uint simobjectid)
        {
            return (ShapeEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ShapeEditorPlugin));
        }

        #endregion
    }
}