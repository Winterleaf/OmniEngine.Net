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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Enums;
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<NavEditorPlugin>))]
    public class NavEditorPlugin : EditorPlugin
    {
        public ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        public TypeGizmoAlignment prevGizmoAlignment
        {
            get { return this["prevGizmoAlignment"]; }
            set { this["prevGizmoAlignment"] = value.AsString(); }
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            // Add ourselves to the window menu.
            EditorGui EditorGui = "EditorGui";

            string accel = EditorGui.addToEditorsMenu("Navigation Editor", "", this);

            // Add ourselves to the ToolsToolbar.
            string tooltip = "Navigation Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("NavEditorPlugin", "NavEditorPalette", Util._expandFilename("tools/navEditor/images/nav-editor"), tooltip);

            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            NavEditorOptionsWindow.attachTo("NavEditorTreeWindow");

            // Add ourselves to the Editor Settings window.
            //exec("./NavEditorSettingsTab.gui");
            ENavEditorSettingsPage.initialize();

            ESettingsWindow ESettingsWindow = "ESettingsWindow";
            ESettingsWindow.addTabPage("ENavEditorSettingsPage");

            ENavEditorSettingsPage NavEditorSettingsPage = "ENavEditorSettingsPage";
            NavEditorSettingsPage.init();

            // Add items to World Editor Creator
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";
            EWCreatorWindow.beginGroup("Navigation");

            EWCreatorWindow.registerMissionObject("NavMesh", "Navigation mesh", "", "");
            EWCreatorWindow.registerMissionObject("NavPath", "Path", "", "");
            EWCreatorWindow.registerMissionObject("CoverPoint", "Cover point", "", "");

            EWCreatorWindow.endGroup("Navigation");
        }

        [ConsoleInteraction]
        public override void onActivated()
        {
            readSettings();

            // Set a global variable so everyone knows we're editing!
            bGlobal["$Nav::EditorOpen"] = true;

            // Start off in Select mode.
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            GuiBitmapButtonCtrl NavEditorSelectMode = ToolsPaletteArray.FOT("NavEditorSelectMode");
            NavEditorSelectMode.performClick();

            EditorGui EditorGui = "EditorGui";
            NavEditorGui NavEditorGui = "NavEditorGui";
            EditorGui.bringToFront(NavEditorGui);

            NavEditorGui.setVisible(true);
            NavEditorGui.makeFirstResponder(true);
            GuiControl NavEditorToolbar = "NavEditorToolbar";
            NavEditorToolbar.setVisible(true);

            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiWindowCollapseCtrl NavEditorTreeWindow = "NavEditorTreeWindow";
            NavEditorOptionsWindow.setVisible(true);
            NavEditorTreeWindow.setVisible(true);

            // Inspect the ServerNavMeshSet, which contains all the NavMesh objects
            // in the mission.
            SimSet ServerNavMeshSet = "ServerNavMeshSet";
            if (!Util.isObject(ServerNavMeshSet))
                ServerNavMeshSet = new ObjectCreator("SimSet", "ServerNavMeshSet").Create();
            if (ServerNavMeshSet.getCount() == 0)
                messageBox.MessageBoxYesNo("No NavMesh", "There is no NavMesh in this level. Would you like to create one?" + " " + "If not, please use the World Editor to create a new NavMesh.", "Canvas.pushDialog(CreateNewNavMeshDlg);");
            NavTreeView NavTreeView = "NavTreeView";
            NavTreeView.open(ServerNavMeshSet, true);

            // Push our keybindings to the top. (See initializeNavEditor for where this
            // map was created.)
            map.push();

            // Store this on a dynamic field
            // in order to restore whatever setting
            // the user had before.
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            prevGizmoAlignment = GlobalGizmoProfile.alignment;

            // Always use Object alignment.
            GlobalGizmoProfile.alignment = "Object";

            // Set the status bar here until all tool have been hooked up
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            EditorGuiStatusBar.setInfo("Navigation editor.");
            EditorGuiStatusBar.setSelection("");

            // Allow the Gui to setup.
            NavEditorGui.onEditorActivated();

            base.onActivated();
        }

        [ConsoleInteraction]
        public override void onDeactivated()
        {
            writeSettings();

            bGlobal["$Nav::EditorOpen"] = false;

            NavEditorGui NavEditorGui = "NavEditorGui";
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiWindowCollapseCtrl NavEditorTreeWindow = "NavEditorTreeWindow";
            GuiControl NavEditorToolbar = "NavEditorToolbar";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            NavEditorGui.setVisible(false);
            NavEditorToolbar.setVisible(false);
            NavEditorOptionsWindow.setVisible(false);
            NavEditorTreeWindow.setVisible(false);
            map.pop();

            // Restore the previous Gizmo alignment settings.
            GlobalGizmoProfile.alignment = prevGizmoAlignment;

            // Allow the Gui to cleanup.
            NavEditorGui.onEditorDeactivated();

            base.onDeactivated();
        }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
        {
            bool hasSelection = false;
        }

        [ConsoleInteraction]
        public override void handleDelete()
        {
            NavEditorGui NavEditorGui = "NavEditorGui";

            // Event happens when the user hits 'delete'.
            NavEditorGui.deleteSelected();
        }

        [ConsoleInteraction]
        public override bool handleEscape()
        {
            NavEditorGui NavEditorGui = "NavEditorGui";
            return NavEditorGui.onEscapePressed();
        }

        [ConsoleInteraction]
        public override bool isDirty()
        {
            NavEditorGui NavEditorGui = "NavEditorGui";
            return NavEditorGui.isDirty;
        }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
        {
            NavEditorGui NavEditorGui = "NavEditorGui";
            if (NavEditorGui.isDirty)
                {
                SimGroup MissionGroup = "MissionGroup";
                MissionGroup.save(missionFile);
                NavEditorGui.isDirty = false;
                }
        }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";
            EditorSettings.beginGroup("NavEditor", true);

            EditorSettings.setDefaultValue("SpawnClass", "AIPlayer");
            EditorSettings.setDefaultValue("SpawnDatablock", "DefaultPlayerData");

            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            NavEditorGui NavEditorGui = "NavEditorGui";

            EditorSettings.beginGroup("NavEditor", true);

            NavEditorGui.spawnClass = EditorSettings.value("SpawnClass");
            NavEditorGui.spawnDatablock = EditorSettings.value("SpawnDatablock");

            EditorSettings.endGroup();
        }

        [ConsoleInteraction]
        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";
            NavEditorGui NavEditorGui = "NavEditorGui";
            EditorSettings.beginGroup("NavEditor", true);

            EditorSettings.setValue("SpawnClass", NavEditorGui.spawnClass);
            EditorSettings.setValue("SpawnDatablock", NavEditorGui.spawnDatablock);

            EditorSettings.endGroup();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(NavEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(NavEditorPlugin ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator NavEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (NavEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavEditorPlugin(int simobjectid)
        {
            return (NavEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (NavEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavEditorPlugin ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavEditorPlugin(uint simobjectid)
        {
            return (NavEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (NavEditorPlugin));
        }

        #endregion
    }

    [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowPopup>))]
    public class ESettingsWindowPopup : GuiPopUpMenuCtrlEx
    {
        [ConsoleInteraction]
        public override void onWake()
        {
            Settings EditorSettings = "EditorSettings";
            setSelected(findText(EditorSettings.value(this["editorSettingsValue"])));
        }

        [ConsoleInteraction]
        public override void onSelect(string id, string text)
        {
            Settings EditorSettings = "EditorSettings";
            EditorSettings.setValue(this["editorSettingsValue"], getText());
            Util.eval(this["editorSettingsRead"]);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ESettingsWindowPopup ts, string simobjectid)
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
        public static bool operator !=(ESettingsWindowPopup ts, string simobjectid)
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
        public static implicit operator string(ESettingsWindowPopup ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ESettingsWindowPopup(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ESettingsWindowPopup) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowPopup));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ESettingsWindowPopup ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ESettingsWindowPopup(int simobjectid)
        {
            return (ESettingsWindowPopup) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowPopup));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ESettingsWindowPopup ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ESettingsWindowPopup(uint simobjectid)
        {
            return (ESettingsWindowPopup) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowPopup));
        }

        #endregion
    }
}