using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<DecalEditorPlugin>))]
    public class DecalEditorPlugin : EditorPlugin
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
            map.bindCmd("keyboard", "5", "EDecalEditorAddDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "1", "EDecalEditorSelectDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "2", "EDecalEditorMoveDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "3", "EDecalEditorRotateDecalBtn.performClick();", "");
            map.bindCmd("keyboard", "4", "EDecalEditorScaleDecalBtn.performClick();", "");

            this.map = map;

            new ObjectCreator("PersistenceManager", "DecalPMan").Create();
            }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Decal Editor", "", "DecalEditorPlugin");

            // Add ourselves to the ToolsToolbar
            string tooltip = "Decal Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("DecalEditorPlugin", "DecalEditorPalette",
                Util._expandFilename("tools/decalEditor/decal-editor"), tooltip);

            //connect editor windows   
            DecalPreviewWindow.attachTo(DecalEditorWindow);

            //set initial palette setting
            this["paletteSelection"] = "AddDecalMode";
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            EditorGui.bringToFront(DecalEditorGui);
            DecalEditorGui.setVisible(true);
            DecalEditorGui.makeFirstResponder(true);
            DecalPreviewWindow.setVisible(true);
            DecalEditorWindow.setVisible(true);

            this.map.push();

            //WORKAROUND: due to the gizmo mode being stored on its profile (which may be shared),
            //  we may end up with a mismatch between the editor mode and gizmo mode here.
            //  Reset mode explicitly here to work around this.
            DecalEditorGui.setMode(DecalEditorGui.getMode());

            // Set the current palette selection
            DecalEditorGui.paletteSync(this["paletteSelection"]);

            // Store this on a dynamic field
            // in order to restore whatever setting
            // the user had before.
            this["prevGizmoAlignment"] = GlobalGizmoProfile["alignment"];

            // The DecalEditor always uses Object alignment.
            GlobalGizmoProfile["alignment"] = "Object";

            DecalEditorGui.rebuildInstanceTree();

            // These could perhaps be the node details like the shape editor
            //ShapeEdPropWindow.syncNodeDetails(-1);

            base.onActivated();
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            DecalEditorGui.setVisible(false);
            DecalPreviewWindow.setVisible(false);
            DecalEditorWindow.setVisible(false);

            this.map.pop();

            // Remember last palette selection
            this["paletteSelection"] = DecalEditorGui.getMode();

            // Restore the previous Gizmo
            // alignment settings.
            GlobalGizmoProfile["alignment"] = this["prevGizmoAlignment"];

            base.onDeactivated();
            }

        [ConsoleInteraction]
        public override bool isDirty()
            {
            PersistenceManager DecalPMan = "DecalPMan";
            bool dirty = DecalPMan.hasDirty();

            dirty |= Util.decalManagerDirty();
            return dirty;
            }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
            {
            PersistenceManager DecalPMan = "DecalPMan";

            DecalPMan.saveDirty();
            Util.decalManagerSave(missionFile + ".decals");
            }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
            {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";

            bool hasSelection = DecalEditorGui.getSelectionCount() > 0;

            ((PopupMenu) editMenu).enableItem(3, false); // Cut
            ((PopupMenu) editMenu).enableItem(4, false); // Copy
            ((PopupMenu) editMenu).enableItem(5, false); // Paste 
            ((PopupMenu) editMenu).enableItem(6, hasSelection); // Delete
            ((PopupMenu) editMenu).enableItem(8, false); // Deselect 

            // NOTE: If you want to implement Cut, Copy, Paste, or Deselect
            // for this editor simply enable the menu items when it is appropriate
            // and fill in the method stubs below.
            }

        [ConsoleInteraction]
        public override void handleDelete()
            {
            DecalEditorGui DecalEditorGui = "DecalEditorGui";
            DecalEditorGui.deleteSelectedDecal();
            }

        [ConsoleInteraction]
        public override void handleDeselect()
            {
            }

        [ConsoleInteraction]
        public override void handleCut()
            {
            }

        [ConsoleInteraction]
        public override void handleCopy()
            {
            }

        [ConsoleInteraction]
        public override void handlePaste()
            {
            }

        [ConsoleInteraction]
        public override bool handleEscape()
            {
            return true;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DecalEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(DecalEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(DecalEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DecalEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (DecalEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (DecalEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DecalEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DecalEditorPlugin(int simobjectid)
            {
            return (DecalEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (DecalEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DecalEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DecalEditorPlugin(uint simobjectid)
            {
            return (DecalEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (DecalEditorPlugin));
            }

        #endregion
        }
    }