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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui.CodeBehind
{
    [TypeConverter(typeof (ForestEditorPlugin))]
    public class ForestEditorPlugin : EditorPlugin
    {
        public ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        [ConsoleInteraction]
        public void initialize()
        {
            ObjectCreator oc_Newobject3 = new ObjectCreator("SimSet", "ForestTools");

            ObjectCreator oc_Newobject2 = new ObjectCreator("ForestBrushTool");
            oc_Newobject2["internalName"] = "BrushTool";
            oc_Newobject2["toolTip"] = "Paint Tool";
            oc_Newobject2["buttonImage"] = "tools/forest/images/brushTool";

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            ObjectCreator oc_Newobject1 = new ObjectCreator("ForestSelectionTool");
            oc_Newobject1["internalName"] = "SelectionTool";
            oc_Newobject1["toolTip"] = "Selection Tool";
            oc_Newobject1["buttonImage"] = "tools/forest/images/selectionTool";
            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            oc_Newobject3.Create();

            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "ForestEditorSelectModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "ForestEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "ForestEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "ForestEditorScaleModeBtn.performClick();", ""); // Scale
            map.bindCmd("keyboard", "5", "ForestEditorPaintModeBtn.performClick();", ""); // Paint
            map.bindCmd("keyboard", "6", "ForestEditorEraseModeBtn.performClick();", ""); // Erase
            map.bindCmd("keyboard", "7", "ForestEditorEraseSelectedModeBtn.performClick();", ""); // EraseSelected   
            map.bindCmd("keyboard", "8", "ForestEditorDropToGroundModeBtn.performClick();", ""); // DropTheBeat
            //%map.bindCmd( keyboard, "backspace", "ForestEditorGui.onDeleteKey();", "" );
            //%map.bindCmd( keyboard, "delete", "ForestEditorGui.onDeleteKey();", "" );   
            this.map = map;
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            ForestEditorGui.ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            SimSet ForestItemDataSet = "ForestItemDataSet";
            ForestEditorGui.ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";
            EditorGui EditorGui = "EditorGui";
            ForestEditorGui.ForestEditTabBook ForestEditTabBook = "ForestEditTabBook";
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";

            new ObjectCreator("PersistenceManager", "ForestDataManager").Create();

            const string brushPath = "art/forest/brushes.cs";
            if (!Util.isFile(brushPath))
                Util.createPath(brushPath);

            // This creates the ForestBrushGroup, all brushes, and elements.
            Util.exec(brushPath, false, false);

            SimGroup ForestBrushGroup = "ForestBrushGroup";

            if (!ForestBrushGroup.isObject())
                {
                ForestBrushGroup = new ObjectCreator("SimGroup", "ForestBrushGroup").Create();
                this["showError"] = true.AsString();
                }

            ForestEditBrushTree.open(ForestBrushGroup);

            if (!ForestItemDataSet.isObject())
                ForestItemDataSet = new ObjectCreator("SimSet", "ForestItemDataSet").Create();

            ForestEditMeshTree.open(ForestItemDataSet);

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Forest Editor", "", this);

            // Add ourselves to the tools menu.
            string tooltip = "Forest Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("ForestEditorPlugin", "ForestEditorPalette", Util._expandFilename("tools/forestEditor/images/forest-editor-btn"), tooltip);

            //connect editor windows
            ForestEditorPalleteWindow.attachTo(ForestEditorPropertiesWindow);
            ForestEditTabBook.selectPage(0);
        }

        [ConsoleInteraction]
        public override void onWorldEditorShutdown()
        {
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            PersistenceManager ForestDataManager = "ForestDataManager";

            if (ForestBrushGroup.isObject())
                ForestBrushGroup.delete();
            if (ForestDataManager.isObject())
                ForestDataManager.delete();
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            EditorGui EditorGui = "EditorGui";
            ForestEditorGui ForestEditorGui = "ForestEditorGui";
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
            ForestEditorGui.ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";
            ForestEditorGui.ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            ForestEditorGui.ForestEditTabBook ForestEditTabBook = "ForestEditTabBook";
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            SimSet ForestItemDataSet = "ForestItemDataSet";
            SimSet ForestTools = "ForestTools";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            GuiBitmapButtonCtrl ForestEditorPaintModeBtn = "ForestEditorPaintModeBtn";
            GuiBitmapButtonCtrl ForestEditorSelectModeBtn = "ForestEditorSelectModeBtn";
            GuiBitmapButtonCtrl ForestEditorMoveModeBtn = "ForestEditorMoveModeBtn";
            GuiBitmapButtonCtrl ForestEditorRotateModeBtn = "ForestEditorRotateModeBtn";
            GuiBitmapButtonCtrl ForestEditorScaleModeBtn = "ForestEditorScaleModeBtn";
            GuiBitmapButtonCtrl ForestEditorEraseModeBtn = "ForestEditorEraseModeBtn";
            GuiBitmapButtonCtrl ForestEditorEraseSelectedModeBtn = "ForestEditorEraseSelectedModeBtn";
            GuiBitmapButtonCtrl ForestEditorDropToGroundModeBtn = "ForestEditorDropToGroundModeBtn";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            ForestBrushTool BrushTool = ForestTools.FOF("BrushTool");

            string mode;

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            EditorGui.bringToFront(ForestEditorGui);
            ForestEditorGui.setVisible(true);
            ForestEditorPalleteWindow.setVisible(true);
            ForestEditorPropertiesWindow.setVisible(true);
            ForestEditorGui.makeFirstResponder(true);
            //ForestEditToolbar.setVisible( true );

            this.map.push();
            base.onActivated();

            ForestEditBrushTree.open(ForestBrushGroup);
            ForestEditMeshTree.open(ForestItemDataSet);

            // Open the Brush tab.
            ForestEditTabBook.selectPage(0);

            // Sync the pallete button state

            // And toolbar.
            SimObject tool = ForestEditorGui.getActiveTool();
            if (tool.isObject())
                tool.call("onActivated");

            if (!tool.isObject())
                {
                ForestEditorPaintModeBtn.performClick();

                if (ForestEditBrushTree.getItemCount() > 0)
                    ForestEditBrushTree.selectItem(0, true);
                }
            else if (tool == SelectionTool)
                {
                mode = GlobalGizmoProfile["mode"];
                switch (mode)
                    {
                        case "None":
                            ForestEditorSelectModeBtn.performClick();
                            break;
                        case "Move":
                            ForestEditorMoveModeBtn.performClick();
                            break;
                        case "Rotate":
                            ForestEditorRotateModeBtn.performClick();
                            break;
                        case "Scale":
                            ForestEditorScaleModeBtn.performClick();
                            break;
                    }
                }
            else if (tool == BrushTool)
                {
                mode = BrushTool["mode"];
                switch (mode)
                    {
                        case "Paint":
                            ForestEditorPaintModeBtn.performClick();
                            break;
                        case "Erase":
                            ForestEditorEraseModeBtn.performClick();
                            break;
                        case "EraseSelected":
                            ForestEditorEraseSelectedModeBtn.performClick();
                            break;
                        case "DropToGround":
                            ForestEditorDropToGroundModeBtn.performClick();
                            break;
                    }
                }

            if (this["showError"].AsBool())
                messageBox.MessageBoxOK("Error", "Your art/forest folder does not contain a valid brushes.cs. Brushes you create will not be saved!");
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
            ForestEditorGui ForestEditorGui = "ForestEditorGui";
            PersistenceManager ForestDataManager = "ForestDataManager";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013
            ForestEditorGui.setVisible(false);
            ForestEditorPalleteWindow.setVisible(false);
            ForestEditorPropertiesWindow.setVisible(false);

            SimObject tool = ForestEditorGui.getActiveTool();
            if (tool.isObject())
                tool.call("onDeactivated");

            // Also take this opportunity to save.
            ForestDataManager.saveDirty();

            this.map.pop();

            base.onDeactivated();
        }

        [ConsoleInteraction]
        public override bool isDirty()
        {
            ForestEditorGui ForestEditorGui = "ForestEditorGui";

            bool dirty = this["dirty"].AsBool() || ForestEditorGui.isDirty();
            return dirty;
        }

        [ConsoleInteraction]
        public override void clearDirty()
        {
            this["dirty"] = false.AsString();
        }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
        {
            PersistenceManager ForestDataManager = "ForestDataManager";
            Forest theForest = "theForest";
            SimGroup ForestBrushGroup = "ForestBrushGroup";

            ForestDataManager.saveDirty();

            if (theForest.isObject())
                theForest.saveDataFile(theForest.dataFile);

            ForestBrushGroup.save("art/forest/brushes.cs", false, "");
        }

        [ConsoleInteraction]
        public override void onEditorSleep()
        {
        }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
        {
            SimSet ForestTools = "ForestTools";
            ForestEditorGui ForestEditorGui = "ForestEditorGui";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");

            bool hasSelection = false;

            ForestSelectionTool selTool = SelectionTool;
            if (ForestEditorGui.getActiveTool() == selTool._iID)
                {
                if (selTool.getSelectionCount() > 0)
                    hasSelection = true;
                }

            ((PopupMenu) editMenu).enableItem(3, hasSelection); // Cut
            ((PopupMenu) editMenu).enableItem(4, hasSelection); // Copy
            ((PopupMenu) editMenu).enableItem(5, hasSelection); // Paste  
            ((PopupMenu) editMenu).enableItem(6, hasSelection); // Delete
            ((PopupMenu) editMenu).enableItem(8, hasSelection); // Deselect
        }

        [ConsoleInteraction]
        public override void handleDelete()
        {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.deleteSelection();
        }

        [ConsoleInteraction]
        public override void handleDeselect()
        {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.clearSelection();
        }

        [ConsoleInteraction]
        public override void handleCut()
        {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.cutSelection();
        }

        [ConsoleInteraction]
        public override void handleCopy()
        {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.copySelection();
        }

        [ConsoleInteraction]
        public override void handlePaste()
        {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.pasteSelection();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(ForestEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(ForestEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ForestEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ForestEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorPlugin(int simobjectid)
        {
            return (ForestEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ForestEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestEditorPlugin(uint simobjectid)
        {
            return (ForestEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPlugin));
        }

        #endregion
    }
}