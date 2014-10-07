using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
            get
            {
                return this["map"];
            }
            set
            {
                this["map"] = value;
            }
        }

        public TypeGizmoAlignment prevGizmoAlignment
        {
            get
            {
                return this["prevGizmoAlignment"];
            }
            set
            {
                this["prevGizmoAlignment"] = value.AsString();
            }
        }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            // Add ourselves to the window menu.
            EditorGui EditorGui = "EditorGui";

            string accel = EditorGui.addToEditorsMenu("Navigation Editor", "", this);

            // Add ourselves to the ToolsToolbar.
            string tooltip = "Navigation Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("NavEditorPlugin", "NavEditorPalette",
                Util._expandFilename("tools/navEditor/images/nav-editor"), tooltip);

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
                messageBox.MessageBoxYesNo("No NavMesh",
                    "There is no NavMesh in this level. Would you like to create one?" + " " +
                    "If not, please use the World Editor to create a new NavMesh.",
                    "Canvas.pushDialog(CreateNewNavMeshDlg);");
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
        public static bool operator ==( NavEditorPlugin ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=( NavEditorPlugin ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( NavEditorPlugin ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator  NavEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return ( NavEditorPlugin) Omni.self.getSimObject(simobjectid, typeof ( NavEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( NavEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator  NavEditorPlugin(int simobjectid)
            {
            return ( NavEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof ( NavEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( NavEditorPlugin ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator  NavEditorPlugin(uint simobjectid)
            {
            return ( NavEditorPlugin) Omni.self.getSimObject(simobjectid, typeof ( NavEditorPlugin));
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
        public static bool operator ==( ESettingsWindowPopup ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=( ESettingsWindowPopup ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( ESettingsWindowPopup ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator  ESettingsWindowPopup(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return ( ESettingsWindowPopup) Omni.self.getSimObject(simobjectid, typeof ( ESettingsWindowPopup));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ESettingsWindowPopup ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator  ESettingsWindowPopup(int simobjectid)
            {
            return ( ESettingsWindowPopup) Omni.self.getSimObject((uint) simobjectid, typeof ( ESettingsWindowPopup));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ESettingsWindowPopup ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator  ESettingsWindowPopup(uint simobjectid)
            {
            return ( ESettingsWindowPopup) Omni.self.getSimObject(simobjectid, typeof ( ESettingsWindowPopup));
            }

        #endregion
    }
}
