using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<RoadEditorPlugin>))]
    public class MeshRoadEditorPlugin : EditorPlugin
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
            map.bindCmd("keyboard", "backspace", "MeshRoadEditorGui.deleteNode();", "");
            map.bindCmd("keyboard", "1", "MeshRoadEditorGui.prepSelectionMode();", "");
            map.bindCmd("keyboard", "2", "ToolsPaletteArray->MeshRoadEditorMoveMode.performClick();", "");
            map.bindCmd("keyboard", "3", "ToolsPaletteArray->MeshRoadEditorRotateMode.performClick();", "");
            map.bindCmd("keyboard", "4", "ToolsPaletteArray->MeshRoadEditorScaleMode.performClick();", "");
            map.bindCmd("keyboard", "5", "ToolsPaletteArray->MeshRoadEditorAddRoadMode.performClick();", "");
            map.bindCmd("keyboard", "=", "ToolsPaletteArray->MeshRoadEditorInsertPointMode.performClick();", "");
            map.bindCmd("keyboard", "numpadadd", "ToolsPaletteArray->MeshRoadEditorInsertPointMode.performClick();", "");
            map.bindCmd("keyboard", "-", "ToolsPaletteArray->MeshRoadEditorRemovePointMode.performClick();", "");
            map.bindCmd("keyboard", "numpadminus", "ToolsPaletteArray->MeshRoadEditorRemovePointMode.performClick();",
                "");
            map.bindCmd("keyboard", "z", "MeshRoadEditorShowSplineBtn.performClick();", "");
            map.bindCmd("keyboard", "x", "MeshRoadEditorWireframeBtn.performClick();", "");
            map.bindCmd("keyboard", "v", "MeshRoadEditorShowRoadBtn.performClick();", "");
            this.map = map;

            this.initSettings();
            }

        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            ESettingsWindow ESettingsWindow = "ESettingsWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Mesh Road Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Mesh Road Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("MeshRoadEditorPlugin", "MeshRoadEditorPalette",
                Util._expandFilename("tools/worldEditor/images/toolbar/mesh-road-editor"), tooltip);

            //connect editor windows
            ((GuiWindowCollapseCtrl) "MeshRoadEditorOptionsWindow").attachTo("MeshRoadEditorTreeWindow");

            // Add ourselves to the Editor Settings window
            //exec( "./meshRoadEditorSettingsTab.gui" );
            omni.console.Call("MeshRoadEditorSettingsTab_initialize");
            ESettingsWindow.addTabPage("EMeshRoadEditorSettingsPage");
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            GuiMeshRoadEditorCtrl MeshRoadEditorGui = "MeshRoadEditorGui";
            GuiControl MeshRoadEditorToolbar = "MeshRoadEditorToolbar";
            GuiWindowCollapseCtrl MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            MeshRoadEditorGui.MeshRoadEditorTreeWindow MeshRoadEditorTreeWindow = "MeshRoadEditorTreeWindow";
            GuiTreeViewCtrl MeshRoadTreeView = "MeshRoadTreeView";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            EditorGui EditorGui = "EditorGui";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            this.readSettings();

            ((GuiBitmapButtonCtrl)
                ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName(
                    "MeshRoadEditorAddRoadMode", false)).performClick();
            EditorGui.bringToFront("MeshRoadEditorGui");
            MeshRoadEditorGui.setVisible(true);
            MeshRoadEditorGui.makeFirstResponder(true);
            MeshRoadEditorOptionsWindow.setVisible(true);
            MeshRoadEditorToolbar.setVisible(true);
            MeshRoadEditorTreeWindow.setVisible(true);
            MeshRoadTreeView.open("ServerMeshRoadSet", true);
            this.map.push();

            // Store this on a dynamic field
            // in order to restore whatever setting
            // the user had before.
            this["prevGizmoAlignment"] = GlobalGizmoProfile["alignment"];

            // The DecalEditor always uses Object alignment.
            GlobalGizmoProfile["alignment"] = "Object";

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("Mesh road editor.");
            EditorGuiStatusBar.setSelection("");

            base.onActivated();
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            GuiMeshRoadEditorCtrl MeshRoadEditorGui = "MeshRoadEditorGui";
            GuiControl MeshRoadEditorToolbar = "MeshRoadEditorToolbar";
            GuiWindowCollapseCtrl MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            MeshRoadEditorGui.MeshRoadEditorTreeWindow MeshRoadEditorTreeWindow = "MeshRoadEditorTreeWindow";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            this.writeSettings();

            MeshRoadEditorGui.setVisible(false);
            MeshRoadEditorOptionsWindow.setVisible(false);
            MeshRoadEditorToolbar.setVisible(false);
            MeshRoadEditorTreeWindow.setVisible(false);
            this.map.pop();

            // Restore the previous Gizmo
            // alignment settings.
            GlobalGizmoProfile["alignment"] = this["prevGizmoAlignment"];

            base.onDeactivated();
            }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
            {
            bool hasSelection = false;

            if (((GuiMeshRoadEditorCtrl) "MeshRoadEditorGui")["road"].isObject())
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
            ((MeshRoadEditorGui) "MeshRoadEditorGui").deleteNode();
            }

        [ConsoleInteraction]
        public override bool handleEscape()
            {
            return ((MeshRoadEditorGui) "MeshRoadEditorGui").onEscapePressed();
            }

        [ConsoleInteraction]
        public override bool isDirty()
            {
            return ((MeshRoadEditorGui) "MeshRoadEditorGui").isDirty;
            }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
            {
            MeshRoadEditorGui MeshRoadEditorGui = "MeshRoadEditorGui";
            if (MeshRoadEditorGui.isDirty)
                {
                ((SimGroup) "MissionGroup").save(missionFile, false, "");
                MeshRoadEditorGui.isDirty = false;
                }
            }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        public void initSettings()
            {
            Settings EditorSettings = "EditorSettings";
            EditorSettings.beginGroup("MeshRoadEditor", true);

            EditorSettings.setDefaultValue("DefaultWidth", "10");
            EditorSettings.setDefaultValue("DefaultDepth", "5");
            EditorSettings.setDefaultValue("DefaultNormal", "0 0 1");
            EditorSettings.setDefaultValue("HoverSplineColor", "255 0 0 255");
            EditorSettings.setDefaultValue("SelectedSplineColor", "0 255 0 255");
            EditorSettings.setDefaultValue("HoverNodeColor", "255 255 255 255"); //<-- Not currently used
            EditorSettings.setDefaultValue("TopMaterialName", "DefaultRoadMaterialTop");
            EditorSettings.setDefaultValue("BottomMaterialName", "DefaultRoadMaterialOther");
            EditorSettings.setDefaultValue("SideMaterialName", "DefaultRoadMaterialOther");

            EditorSettings.endGroup();
            }

        public void readSettings()
            {
            Settings EditorSettings = "EditorSettings";
            GuiMeshRoadEditorCtrl MeshRoadEditorGui = "MeshRoadEditorGui";

            EditorSettings.beginGroup("MeshRoadEditor", true);

            MeshRoadEditorGui["DefaultWidth"] = EditorSettings.value("DefaultWidth");
            MeshRoadEditorGui["DefaultDepth"] = EditorSettings.value("DefaultDepth");
            MeshRoadEditorGui["DefaultNormal"] = EditorSettings.value("DefaultNormal");
            MeshRoadEditorGui["HoverSplineColor"] = EditorSettings.value("HoverSplineColor");
            MeshRoadEditorGui["SelectedSplineColor"] = EditorSettings.value("SelectedSplineColor");
            MeshRoadEditorGui["HoverNodeColor"] = EditorSettings.value("HoverNodeColor");
            MeshRoadEditorGui["topMaterialName"] = EditorSettings.value("TopMaterialName");
            MeshRoadEditorGui["bottomMaterialName"] = EditorSettings.value("BottomMaterialName");
            MeshRoadEditorGui["sideMaterialName"] = EditorSettings.value("SideMaterialName");

            EditorSettings.endGroup();
            }

        public void writeSettings()
            {
            Settings EditorSettings = "EditorSettings";
            GuiMeshRoadEditorCtrl MeshRoadEditorGui = "MeshRoadEditorGui";

            EditorSettings.beginGroup("MeshRoadEditor", true);

            EditorSettings.setValue("DefaultWidth", MeshRoadEditorGui["DefaultWidth"]);
            EditorSettings.setValue("DefaultDepth", MeshRoadEditorGui["DefaultDepth"]);
            EditorSettings.setValue("DefaultNormal", MeshRoadEditorGui["DefaultNormal"]);
            EditorSettings.setValue("HoverSplineColor", MeshRoadEditorGui["HoverSplineColor"]);
            EditorSettings.setValue("SelectedSplineColor", MeshRoadEditorGui["SelectedSplineColor"]);
            EditorSettings.setValue("HoverNodeColor", MeshRoadEditorGui["HoverNodeColor"]);
            EditorSettings.setValue("TopMaterialName", MeshRoadEditorGui["topMaterialName"]);
            EditorSettings.setValue("BottomMaterialName", MeshRoadEditorGui["bottomMaterialName"]);
            EditorSettings.setValue("SideMaterialName", MeshRoadEditorGui["sideMaterialName"]);

            EditorSettings.endGroup();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MeshRoadEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(MeshRoadEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(MeshRoadEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MeshRoadEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MeshRoadEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MeshRoadEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MeshRoadEditorPlugin(int simobjectid)
            {
            return (MeshRoadEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MeshRoadEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MeshRoadEditorPlugin(uint simobjectid)
            {
            return (MeshRoadEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorPlugin));
            }

        #endregion
        }
    }