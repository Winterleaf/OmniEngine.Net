using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
            EditorGui.addToToolsToolbar("RiverEditorPlugin", "RiverEditorPalette",
                Util._expandFilename("tools/worldEditor/images/toolbar/river-editor"), tooltip);

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

            omni.bGlobal["$River::EditorOpen"] = true;

            ((GuiBitmapButtonCtrl)
                ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName(
                    "RiverEditorAddRiverMode", false)).performClick();
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

            omni.bGlobal["$River::EditorOpen"] = false;

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
        public static bool operator !=(RiverEditorPlugin ts, string simobjectid)
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