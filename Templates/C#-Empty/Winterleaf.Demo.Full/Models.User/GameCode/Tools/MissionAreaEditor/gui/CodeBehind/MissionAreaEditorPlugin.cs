using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (MissionAreaEditorPlugin))]
    public class MissionAreaEditorPlugin : EditorPlugin
        {
        [ConsoleInteraction]
        public void initialize()
            {
            this.initSettings();
            }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl MissionAreaEditorPropertiesWindow = "MissionAreaEditorPropertiesWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Mission Area Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Mission Area Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("MissionAreaEditorPlugin", "MissionAreaEditorPalette",
                Util._expandFilename("tools/missionAreaEditor/images/mission-area"), tooltip);

            //connect editor windows   
            MissionAreaEditorPropertiesWindow.attachTo("MissionAreaEditorTerrainWindow");
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            GuiWindowCollapseCtrl MissionAreaEditorPropertiesWindow = "MissionAreaEditorPropertiesWindow";
            GuiWindowCollapseCtrl MissionAreaEditorTerrainWindow = "MissionAreaEditorTerrainWindow";
            MissionAreaEditorGui MissionAreaEditorGui = "MissionAreaEditorGui";
            EditorGui EditorGui = "EditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            this.readSettings();

            EditorGui.bringToFront("MissionAreaEditorGui");

            MissionAreaEditorGui.setVisible(true);
            MissionAreaEditorGui.makeFirstResponder(true);

            MissionAreaEditorTerrainWindow.setVisible(true);
            MissionAreaEditorPropertiesWindow.setVisible(true);

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("Mission Area Editor.");
            EditorGuiStatusBar.setSelection("");

            // Allow the Gui to setup.
            MissionAreaEditorGui.onEditorActivated();

            base.onActivated();
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            GuiWindowCollapseCtrl MissionAreaEditorPropertiesWindow = "MissionAreaEditorPropertiesWindow";
            GuiWindowCollapseCtrl MissionAreaEditorTerrainWindow = "MissionAreaEditorTerrainWindow";
            MissionAreaEditorGui MissionAreaEditorGui = "MissionAreaEditorGui";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            this.writeSettings();

            MissionAreaEditorGui.setVisible(false);
            MissionAreaEditorTerrainWindow.setVisible(false);
            MissionAreaEditorPropertiesWindow.setVisible(false);

            // Allow the Gui to cleanup.
            MissionAreaEditorGui.onEditorDeactivated();

            base.onDeactivated();
            }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("MissionAreaEditor", true);

            EditorSettings.setDefaultValue("MissionBoundsColor", "255 255 255");

            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void readSettings()
            {
            Settings EditorSettings = "EditorSettings";
            GuiMissionAreaCtrl MissionAreaEditorTerrainEditor = "MissionAreaEditorTerrainEditor";

            EditorSettings.beginGroup("MissionAreaEditor", true);

            MissionAreaEditorTerrainEditor["missionBoundsColor"] = EditorSettings.value("MissionBoundsColor");

            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void writeSettings()
            {
            Settings EditorSettings = "EditorSettings";
            GuiMissionAreaCtrl MissionAreaEditorTerrainEditor = "MissionAreaEditorTerrainEditor";

            EditorSettings.beginGroup("MissionAreaEditor", true);

            EditorSettings.setValue("MissionBoundsColor", MissionAreaEditorTerrainEditor["missionBoundsColor"]);

            EditorSettings.endGroup();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MissionAreaEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(MissionAreaEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(MissionAreaEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MissionAreaEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MissionAreaEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (MissionAreaEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MissionAreaEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MissionAreaEditorPlugin(int simobjectid)
            {
            return
                (MissionAreaEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (MissionAreaEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MissionAreaEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MissionAreaEditorPlugin(uint simobjectid)
            {
            return (MissionAreaEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (MissionAreaEditorPlugin));
            }

        #endregion
        }
    }