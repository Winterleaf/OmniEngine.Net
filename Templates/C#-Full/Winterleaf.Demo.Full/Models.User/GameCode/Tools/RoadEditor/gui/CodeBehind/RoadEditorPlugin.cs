using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
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
            EditorGui.addToToolsToolbar("RoadEditorPlugin", "RoadEditorPalette",
                omni.Util._expandFilename("tools/worldEditor/images/toolbar/road-path-editor"), tooltip);

            //connect editor windows
            ((GuiWindowCollapseCtrl) "RoadEditorOptionsWindow").attachTo("RoadEditorTreeWindow");

            // Add ourselves to the Editor Settings window
            //exec( "./RoadEditorSettingsTab.gui" );
            omni.console.Call("RoadEditorSettingsTab_initialize");
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

            ((GuiBitmapButtonCtrl)
                ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName("RoadEditorAddRoadMode",
                    false)).performClick();

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
            //   omni.console.Call("parseMissionGroup", new string[] { "TerrainBlock" }).AsBool();

            if (terrainExists == false)
                messageBox.MessageBoxYesNoCancel("No Terrain", "Would you like to create a New Terrain?",
                    "Canvas.pushDialog(CreateNewTerrainGui);");

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
        public static bool operator !=(RoadEditorPlugin ts, string simobjectid)
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