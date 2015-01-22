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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<RiverEditorPlugin>))]
    public class RiverEditorPlugin : EditorPlugin
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
            map.bindCmd("keyboard", "backspace", "RiverEditorGui.deleteNode();", "");
            map.bindCmd("keyboard", "1", "RiverEditorGui.prepSelectionMode();", "");
            map.bindCmd("keyboard", "2", "ToolsPaletteArray->RiverEditorMoveMode.performClick();", "");
            map.bindCmd("keyboard", "3", "ToolsPaletteArray->RiverEditorRotateMode.performClick();", "");
            map.bindCmd("keyboard", "4", "ToolsPaletteArray->RiverEditorScaleMode.performClick();", "");
            map.bindCmd("keyboard", "5", "ToolsPaletteArray->RiverEditorAddRiverMode.performClick();", "");
            map.bindCmd("keyboard", "=", "ToolsPaletteArray->RiverEditorInsertPointMode.performClick();", "");
            map.bindCmd("keyboard", "numpadadd", "ToolsPaletteArray->RiverEditorInsertPointMode.performClick();", "");
            map.bindCmd("keyboard", "-", "ToolsPaletteArray->RiverEditorRemovePointMode.performClick();", "");
            map.bindCmd("keyboard", "numpadminus", "ToolsPaletteArray->RiverEditorRemovePointMode.performClick();", "");
            map.bindCmd("keyboard", "z", "RiverEditorShowSplineBtn.performClick();", "");
            map.bindCmd("keyboard", "x", "RiverEditorWireframeBtn.performClick();", "");
            map.bindCmd("keyboard", "v", "RiverEditorShowRoadBtn.performClick();", "");
            this.map = map;

            this.initSettings();
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";
            ESettingsWindow ESettingsWindow = "ESettingsWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("River Editor", "", "RiverEditorPlugin");

            // Add ourselves to the ToolsToolbar
            string tooltip = "River Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("RiverEditorPlugin", "RiverEditorPalette", Util._expandFilename("tools/worldEditor/images/toolbar/river-editor"), tooltip);

            //connect editor windows   
            ((GuiWindowCollapseCtrl) "RiverEditorOptionsWindow").attachTo("RiverEditorTreeWindow");

            // Add ourselves to the Editor Settings window
            //exec( "./RiverEditorSettingsTab.gui" );
            console.Call("RiverEditorSettingsTab_initialize");
            ESettingsWindow.addTabPage("ERiverEditorSettingsPage");
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            RiverEditorGui RiverEditorGui = "RiverEditorGui";
            GuiControl RiverEditorToolbar = "RiverEditorToolbar";
            GuiWindowCollapseCtrl RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            GuiWindowCollapseCtrl RiverEditorTreeWindow = "RiverEditorTreeWindow";
            GuiTreeViewCtrl RiverTreeView = "RiverTreeView";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            EditorGui EditorGui = "EditorGui";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013
            this.readSettings();

            bGlobal["$River::EditorOpen"] = true;

            ((GuiBitmapButtonCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName("RiverEditorAddRiverMode", false)).performClick();
            EditorGui.bringToFront("RiverEditorGui");

            RiverEditorGui.setVisible(true);
            RiverEditorGui.makeFirstResponder(true);
            RiverEditorToolbar.setVisible(true);

            RiverEditorOptionsWindow.setVisible(true);
            RiverEditorTreeWindow.setVisible(true);

            RiverTreeView.open("ServerRiverSet", true);
            this.map.push();

            // Store this on a dynamic field
            // in order to restore whatever setting
            // the user had before.
            this["prevGizmoAlignment"] = GlobalGizmoProfile["alignment"];

            // The DecalEditor always uses Object alignment.
            GlobalGizmoProfile["alignment"] = "Object";

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("River editor.");
            EditorGuiStatusBar.setSelection("");

            // Allow the Gui to setup.
            RiverEditorGui.onEditorActivated();

            base.onActivated();
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            RiverEditorGui RiverEditorGui = "RiverEditorGui";
            GuiControl RiverEditorToolbar = "RiverEditorToolbar";
            GuiWindowCollapseCtrl RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            GuiWindowCollapseCtrl RiverEditorTreeWindow = "RiverEditorTreeWindow";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013

            this.writeSettings();

            bGlobal["$River::EditorOpen"] = false;

            RiverEditorGui.setVisible(false);
            RiverEditorToolbar.setVisible(false);
            RiverEditorOptionsWindow.setVisible(false);
            RiverEditorTreeWindow.setVisible(false);
            this.map.pop();

            // Restore the previous Gizmo
            // alignment settings.
            GlobalGizmoProfile["alignment"] = this["prevGizmoAlignment"];

            // Allow the Gui to cleanup.
            RiverEditorGui.onEditorDeactivated();

            base.onDeactivated();
        }

        public override void onEditMenuSelect(string editMenu)
        {
            bool hasSelection = false;

            if (((GuiRiverEditorCtrl) "RiverEditorGui")["river"].isObject())
                hasSelection = true;

            ((PopupMenu) editMenu).enableItem(3, false); // Cut
            ((PopupMenu) editMenu).enableItem(4, false); // Copy
            ((PopupMenu) editMenu).enableItem(5, false); // Paste 
            ((PopupMenu) editMenu).enableItem(6, hasSelection); // Delete
            ((PopupMenu) editMenu).enableItem(8, false); // Deselect 
        }

        [ConsoleInteraction]
        public override void handleDelete()
        {
            ((GuiRiverEditorCtrl) "RiverEditorGui").deleteNode();
        }

        [ConsoleInteraction]
        public override bool handleEscape()
        {
            return ((RiverEditorGui) "RiverEditorGui").onEscapePressed();
        }

        [ConsoleInteraction]
        public override bool isDirty()
        {
            return ((RiverEditorGui) "RiverEditorGui").isDirty;
        }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
        {
            RiverEditorGui RiverEditorGui = "RiverEditorGui";
            if (RiverEditorGui.isDirty)
                {
                ((SimGroup) "MissionGroup").save(missionFile, false, "");
                RiverEditorGui.isDirty = false;
                }
        }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("RiverEditor", true);

            EditorSettings.setDefaultValue("DefaultWidth", "10");
            EditorSettings.setDefaultValue("DefaultDepth", "5");
            EditorSettings.setDefaultValue("DefaultNormal", "0 0 1");
            EditorSettings.setDefaultValue("HoverSplineColor", "255 0 0 255");
            EditorSettings.setDefaultValue("SelectedSplineColor", "0 255 0 255");
            EditorSettings.setDefaultValue("HoverNodeColor", "255 255 255 255"); //<-- Not currently used

            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiRiverEditorCtrl RiverEditorGui = "RiverEditorGui";

            EditorSettings.beginGroup("RiverEditor", true);

            RiverEditorGui["DefaultWidth"] = EditorSettings.value("DefaultWidth");
            RiverEditorGui["DefaultDepth"] = EditorSettings.value("DefaultDepth");
            RiverEditorGui["DefaultNormal"] = EditorSettings.value("DefaultNormal");
            RiverEditorGui["HoverSplineColor"] = EditorSettings.value("HoverSplineColor");
            RiverEditorGui["SelectedSplineColor"] = EditorSettings.value("SelectedSplineColor");
            RiverEditorGui["HoverNodeColor"] = EditorSettings.value("HoverNodeColor");

            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiRiverEditorCtrl RiverEditorGui = "RiverEditorGui";

            EditorSettings.beginGroup("RiverEditor", true);

            EditorSettings.setValue("DefaultWidth", RiverEditorGui["DefaultWidth"]);
            EditorSettings.setValue("DefaultDepth", RiverEditorGui["DefaultDepth"]);
            EditorSettings.setValue("DefaultNormal", RiverEditorGui["DefaultNormal"]);
            EditorSettings.setValue("HoverSplineColor", RiverEditorGui["HoverSplineColor"]);
            EditorSettings.setValue("SelectedSplineColor", RiverEditorGui["SelectedSplineColor"]);
            EditorSettings.setValue("HoverNodeColor", RiverEditorGui["HoverNodeColor"]);

            EditorSettings.endGroup();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RiverEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(RiverEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(RiverEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator RiverEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (RiverEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (RiverEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RiverEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RiverEditorPlugin(int simobjectid)
        {
            return (RiverEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (RiverEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RiverEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RiverEditorPlugin(uint simobjectid)
        {
            return (RiverEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (RiverEditorPlugin));
        }

        #endregion
    }
}