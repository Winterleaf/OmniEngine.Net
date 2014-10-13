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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<ConvexEditorPlugin>))]
    public class ConvexEditorPlugin : EditorPlugin
    {

        internal ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        [ConsoleInteraction]
        public void initialize()
        {
            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "ConvexEditorNoneModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "ConvexEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "ConvexEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "ConvexEditorScaleModeBtn.performClick();", ""); // Scale      
            this.map = map;

            this.initSettings();
        }

        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";
            MenuBuilder ConvexActionsMenu = "ConvexActionsMenu";
            ESettingsWindow ESettingsWindow = "ESettingsWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Sketch Tool", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Sketch Tool (" + accel + ")";
            EditorGui.addToToolsToolbar("ConvexEditorPlugin", "ConvexEditorPalette", omni.Util._expandFilename("tools/convexEditor/images/convex-editor-btn"), tooltip);

            //connect editor windows
            ((GuiWindowCollapseCtrl) "ConvexEditorOptionsWindow").attachTo("ConvexEditorTreeWindow");

            // Allocate our special menu.
            // It will be added/removed when this editor is activated/deactivated.

            if (!ConvexActionsMenu.isObject())
                {
                SingletonCreator ocf = new SingletonCreator("PopupMenu", "ConvexActionsMenu", typeof (MenuBuilder));
                ocf["barTitle"] = "Sketch";

                ocf["item[0]"] = "Hollow Selected Shape" + '\t' + "" + '\t' + "ConvexEditorGui.hollowSelection();";
                ocf["item[1]"] = "Recenter Selected Shape" + '\t' + "" + '\t' + "ConvexEditorGui.recenterSelection();";

                ConvexActionsMenu = ocf.Create();
                }

            this["popupMenu"] = ConvexActionsMenu;

            //exec( "./convexEditorSettingsTab.ed.gui" );
            omni.console.Call("ConvexEditorSettingsTab_initialize");
            ESettingsWindow.addTabPage("EConvexEditorSettingsPage");
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            EditorGui EditorGui = "EditorGui";
            MenuBar menuBar = EditorGui["menuBar"];
            GuiControl ConvexEditorToolbar = "ConvexEditorToolbar";
            GuiConvexEditorCtrl ConvexEditorGui = "ConvexEditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            this.readSettings();

            EditorGui.bringToFront(ConvexEditorGui);
            ConvexEditorGui.setVisible(true);
            ConvexEditorToolbar.setVisible(true);
            ConvexEditorGui.makeFirstResponder(true);
            this.map.push();

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("Sketch Tool.");
            EditorGuiStatusBar.setSelection("");

            // Add our menu.
            menuBar.insert("ConvexActionsMenu", menuBar["dynamicItemInsertPos"].AsInt());

            // Sync the pallete button state with the gizmo mode.
            string mode = GlobalGizmoProfile["mode"];
            switch (mode)
                {
                    case "None":
                        ((GuiBitmapButtonCtrl) "ConvexEditorNoneModeBtn").performClick();
                        break;
                    case "Move":
                        ((GuiBitmapButtonCtrl) "ConvexEditorMoveModeBtn").performClick();
                        break;
                    case "Rotate":
                        ((GuiBitmapButtonCtrl) "ConvexEditorRotateModeBtn").performClick();
                        break;
                    case "Scale":
                        ((GuiBitmapButtonCtrl) "ConvexEditorScaleModeBtn").performClick();
                        break;
                }

            base.onActivated();
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            EditorGui EditorGui = "EditorGui";
            MenuBar menuBar = EditorGui["menuBar"];
            GuiControl ConvexEditorToolbar = "ConvexEditorToolbar";
            GuiConvexEditorCtrl ConvexEditorGui = "ConvexEditorGui";
            GuiWindowCollapseCtrl ConvexEditorOptionsWindow = "ConvexEditorOptionsWindow";
            GuiWindowCollapseCtrl ConvexEditorTreeWindow = "ConvexEditorTreeWindow";

            this.writeSettings();

            ConvexEditorGui.setVisible(false);
            ConvexEditorOptionsWindow.setVisible(false);
            ConvexEditorTreeWindow.setVisible(false);
            ConvexEditorToolbar.setVisible(false);
            this.map.pop();

            // Remove our menu.
            menuBar.remove("ConvexActionsMenu");

            base.onDeactivated();
        }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
        {
            bool hasSelection = false;

            if (((GuiConvexEditorCtrl) "ConvexEditorGui").hasSelection().AsBool())
                hasSelection = true;

            ((MenuBuilder) editMenu).enableItem(3, false); // Cut
            ((MenuBuilder) editMenu).enableItem(4, false); // Copy
            ((MenuBuilder) editMenu).enableItem(5, false); // Paste 
            ((MenuBuilder) editMenu).enableItem(6, hasSelection); // Delete
            ((MenuBuilder) editMenu).enableItem(8, hasSelection); // Deselect    
        }

        [ConsoleInteraction]
        public override void handleDelete()
        {
            ((GuiConvexEditorCtrl) "ConvexEditorGui").handleDelete();
        }

        [ConsoleInteraction]
        public override void handleDeselect()
        {
            ((GuiConvexEditorCtrl) "ConvexEditorGui").handleDeselect();
        }

        [ConsoleInteraction]
        public override void handleCut()
        {
            //WorldEditorInspectorPlugin.handleCut();
        }

        [ConsoleInteraction]
        public override void handleCopy()
        {
            //WorldEditorInspectorPlugin.handleCopy();
        }

        [ConsoleInteraction]
        public override void handlePaste()
        {
            //WorldEditorInspectorPlugin.handlePaste();
        }

        [ConsoleInteraction]
        public override bool isDirty()
        {
            return ((GuiConvexEditorCtrl) "ConvexEditorGui")["isDirty"].AsBool();
        }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
        {
            GuiConvexEditorCtrl ConvexEditorGui = "ConvexEditorGui";
            if (ConvexEditorGui["isDirty"].AsBool())
                {
                ((SimGroup) "MissionGroup").save(missionFile, false, "");
                ConvexEditorGui["isDirty"] = false.AsString();
                }
        }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ConvexEditor", true);
            EditorSettings.setDefaultValue("MaterialName", "Grid512_OrangeLines_Mat");
            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ConvexEditor", true);
            ((GuiConvexEditorCtrl) "ConvexEditorGui")["materialName"] = EditorSettings.value("MaterialName");
            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ConvexEditor", true);
            EditorSettings.setValue("MaterialName", ((GuiConvexEditorCtrl) "ConvexEditorGui")["materialName"]);
            EditorSettings.endGroup();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConvexEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(ConvexEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(ConvexEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ConvexEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConvexEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorPlugin(int simobjectid)
        {
            return (ConvexEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ConvexEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConvexEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConvexEditorPlugin(uint simobjectid)
        {
            return (ConvexEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorPlugin));
        }

        #endregion
    }
}