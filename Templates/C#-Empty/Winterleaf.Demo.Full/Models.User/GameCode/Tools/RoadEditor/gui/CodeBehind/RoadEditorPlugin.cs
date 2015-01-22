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
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<RoadEditorPlugin>))]
    public class RoadEditorPlugin : EditorPlugin
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
            map.bindCmd("keyboard", "backspace", "RoadEditorGui.onDeleteKey();", "");
            map.bindCmd("keyboard", "1", "RoadEditorGui.prepSelectionMode();", "");
            map.bindCmd("keyboard", "2", "ToolsPaletteArray->RoadEditorMoveMode.performClick();", "");
            map.bindCmd("keyboard", "4", "ToolsPaletteArray->RoadEditorScaleMode.performClick();", "");
            map.bindCmd("keyboard", "5", "ToolsPaletteArray->RoadEditorAddRoadMode.performClick();", "");
            map.bindCmd("keyboard", "=", "ToolsPaletteArray->RoadEditorInsertPointMode.performClick();", "");
            map.bindCmd("keyboard", "numpadadd", "ToolsPaletteArray->RoadEditorInsertPointMode.performClick();", "");
            map.bindCmd("keyboard", "-", "ToolsPaletteArray->RoadEditorRemovePointMode.performClick();", "");
            map.bindCmd("keyboard", "numpadminus", "ToolsPaletteArray->RoadEditorRemovePointMode.performClick();", "");
            map.bindCmd("keyboard", "z", "RoadEditorShowSplineBtn.performClick();", "");
            map.bindCmd("keyboard", "x", "RoadEditorWireframeBtn.performClick();", "");
            map.bindCmd("keyboard", "v", "RoadEditorShowRoadBtn.performClick();", "");
            this.map = map;

            this.initSettings();
        }

        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Road and Path Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Road Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("RoadEditorPlugin", "RoadEditorPalette", pInvokes.Util._expandFilename("tools/worldEditor/images/toolbar/road-path-editor"), tooltip);

            //connect editor windows
            ((GuiWindowCollapseCtrl) "RoadEditorOptionsWindow").attachTo("RoadEditorTreeWindow");

            // Add ourselves to the Editor Settings window
            //exec( "./RoadEditorSettingsTab.gui" );
            pInvokes.console.Call("RoadEditorSettingsTab_initialize");
            ((ESettingsWindow) "ESettingsWindow").addTabPage("ERoadEditorSettingsPage");
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            RoadEditorGui RoadEditorGui = "RoadEditorGui";
            GuiControl RoadEditorToolbar = "RoadEditorToolbar";
            GuiWindowCollapseCtrl RoadEditorOptionsWindow = "RoadEditorOptionsWindow";
            GuiWindowCollapseCtrl RoadEditorTreeWindow = "RoadEditorTreeWindow";
            GuiTreeViewCtrl RoadTreeView = "RoadTreeView";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            EditorGui EditorGui = "EditorGui";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   

            this.readSettings();

            ((GuiBitmapButtonCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName("RoadEditorAddRoadMode", false)).performClick();

            EditorGui.bringToFront(RoadEditorGui);

            RoadEditorGui.setVisible(true);
            RoadEditorGui.makeFirstResponder(true);
            RoadEditorToolbar.setVisible(true);

            RoadEditorOptionsWindow.setVisible(true);
            RoadEditorTreeWindow.setVisible(true);

            RoadTreeView.open("ServerDecalRoadSet", true);

            this.map.push();

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("Road editor.");
            EditorGuiStatusBar.setSelection("");

            base.onActivated();
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            GuiRoadEditorCtrl RoadEditorGui = "RoadEditorGui";
            GuiControl RoadEditorToolbar = "RoadEditorToolbar";
            GuiWindowCollapseCtrl RoadEditorOptionsWindow = "RoadEditorOptionsWindow";
            GuiWindowCollapseCtrl RoadEditorTreeWindow = "RoadEditorTreeWindow";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013

            this.writeSettings();

            RoadEditorGui.setVisible(false);
            RoadEditorToolbar.setVisible(false);
            RoadEditorOptionsWindow.setVisible(false);
            RoadEditorTreeWindow.setVisible(false);
            this.map.pop();

            base.onDeactivated();
        }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
        {
            bool hasSelection = false;

            if (((GuiRoadEditorCtrl) "RoadEditorGui")["road"].isObject())
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
            ((RoadEditorGui) "RoadEditorGui").onDeleteKey();
        }

        [ConsoleInteraction]
        public override bool handleEscape()
        {
            return ((RoadEditorGui) "RoadEditorGui").onEscapePressed();
        }

        [ConsoleInteraction]
        public override bool isDirty()
        {
            return ((GuiRoadEditorCtrl) "RoadEditorGui")["isDirty"].AsBool();
        }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
        {
            GuiRoadEditorCtrl RoadEditorGui = "RoadEditorGui";
            if (RoadEditorGui["isDirty"].AsBool())
                {
                ((SimGroup) "MissionGroup").save(missionFile, false, "");
                RoadEditorGui["isDirty"] = false.AsString();
                }
        }

        [ConsoleInteraction]
        public override bool? setEditorFunction(string overrideGroup = "")
        {
            bool terrainExists = AggregateControl.parseMissionGroup("TerrainBlock");
            //   pInvokes.console.Call("parseMissionGroup", new string[] { "TerrainBlock" }).AsBool();

            if (terrainExists == false)
                messageBox.MessageBoxYesNoCancel("No Terrain", "Would you like to create a New Terrain?", "Canvas.pushDialog(CreateNewTerrainGui);");

            return terrainExists;
        }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("RoadEditor", true);

            EditorSettings.setDefaultValue("DefaultWidth", "10");
            EditorSettings.setDefaultValue("HoverSplineColor", "255 0 0 255");
            EditorSettings.setDefaultValue("SelectedSplineColor", "0 255 0 255");
            EditorSettings.setDefaultValue("HoverNodeColor", "255 255 255 255"); //<-- Not currently used
            EditorSettings.setDefaultValue("MaterialName", "DefaultDecalRoadMaterial");

            EditorSettings.endGroup();
        }

        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiRoadEditorCtrl RoadEditorGui = "RoadEditorGui";

            EditorSettings.beginGroup("RoadEditor", true);

            RoadEditorGui["DefaultWidth"] = EditorSettings.value("DefaultWidth");
            RoadEditorGui["HoverSplineColor"] = EditorSettings.value("HoverSplineColor");
            RoadEditorGui["SelectedSplineColor"] = EditorSettings.value("SelectedSplineColor");
            RoadEditorGui["HoverNodeColor"] = EditorSettings.value("HoverNodeColor");
            RoadEditorGui["materialName"] = EditorSettings.value("MaterialName");

            EditorSettings.endGroup();
        }

        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiRoadEditorCtrl RoadEditorGui = "RoadEditorGui";

            EditorSettings.beginGroup("RoadEditor", true);

            EditorSettings.setValue("DefaultWidth", RoadEditorGui["DefaultWidth"]);
            EditorSettings.setValue("HoverSplineColor", RoadEditorGui["HoverSplineColor"]);
            EditorSettings.setValue("SelectedSplineColor", RoadEditorGui["SelectedSplineColor"]);
            EditorSettings.setValue("HoverNodeColor", RoadEditorGui["HoverNodeColor"]);
            EditorSettings.setValue("MaterialName", RoadEditorGui["materialName"]);

            EditorSettings.endGroup();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RoadEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(RoadEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(RoadEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator RoadEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (RoadEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (RoadEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RoadEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RoadEditorPlugin(int simobjectid)
        {
            return (RoadEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (RoadEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RoadEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RoadEditorPlugin(uint simobjectid)
        {
            return (RoadEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (RoadEditorPlugin));
        }

        #endregion
    }
}