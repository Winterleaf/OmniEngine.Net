using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns
    {
    [TypeConverter(typeof (WorldEditorInspectorPlugin))]
    public class WorldEditorInspectorPlugin : WorldEditorPlugin
        {
        internal ActionMap map
            {
            get { return this["map"]; }
            set { this["map"] = value; }
            }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";

            base.onWorldEditorStartup();

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Object Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Object Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("WorldEditorInspectorPlugin", "WorldEditorInspectorPalette",
                Util._expandFilename("tools/worldEditor/images/toolbar/transform-objects"), tooltip);

            //connect editor windows
            EWInspectorWindow.attachTo(EWTreeWindow);

            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "EWorldEditorNoneModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "EWorldEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "EWorldEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "EWorldEditorScaleModeBtn.performClick();", ""); // Scale
            map.bindCmd("keyboard", "f", "FitToSelectionBtn.performClick();", ""); // Fit Camera to Selection
            map.bindCmd("keyboard", "z", "EditorGuiStatusBar.setCamera(\"Standard Camera\");", ""); // Free camera
            map.bindCmd("keyboard", "n", "ToggleNodeBar->renderHandleBtn.performClick();", ""); // Render Node
            map.bindCmd("keyboard", "shift n", "ToggleNodeBar->renderTextBtn.performClick();", ""); // Render Node Text
            map.bindCmd("keyboard", "g", "ESnapOptions-->GridSnapButton.performClick();", ""); // Grid Snappping
            map.bindCmd("keyboard", "t", "SnapToBar->objectSnapDownBtn.performClick();", ""); // Terrain Snapping
            map.bindCmd("keyboard", "b", "SnapToBar-->objectSnapBtn.performClick();", ""); // Soft Snappping
            map.bindCmd("keyboard", "v", "EWorldEditorToolbar->boundingBoxColBtn.performClick();", "");
            // Bounds Selection
            map.bindCmd("keyboard", "o",
                "objectCenterDropdown->objectBoxBtn.performClick(); objectCenterDropdown.toggle();", "");
            // Object Center
            map.bindCmd("keyboard", "p",
                "objectCenterDropdown->objectBoundsBtn.performClick(); objectCenterDropdown.toggle();", "");
            // Bounds Center
            map.bindCmd("keyboard", "k",
                "objectTransformDropdown->objectTransformBtn.performClick(); objectTransformDropdown.toggle();", "");
            // Object Transform
            map.bindCmd("keyboard", "l",
                "objectTransformDropdown->worldTransformBtn.performClick(); objectTransformDropdown.toggle();", "");
            // World Transform
            this.map = map;
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            EditorGui EditorGui = "EditorGui";
            EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";

            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            base.onActivated();
            EWInspectorWindow.setVisible(true);
            EWTreeWindow.setVisible(true);
            //Copyright Winterleaf Entertainment L.L.C. 2013
            WorldEditorToolbar.setVisible(true);
            this.map.push();
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            EditorGui EditorGui = "EditorGui";
            EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";

            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            base.onDeactivated();
            EWInspectorWindow.setVisible(false);
            EWTreeWindow.setVisible(false);
            //Copyright Winterleaf Entertainment L.L.C. 2013
            WorldEditorToolbar.setVisible(false);
            this.map.pop();
            }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            bool canCutCopy = EWorldEditor.getSelectionSize() > 0;
            ((PopupMenu) editMenu).enableItem(3, canCutCopy); // Cut
            ((PopupMenu) editMenu).enableItem(4, canCutCopy); // Copy      
            ((PopupMenu) editMenu).enableItem(5, EWorldEditor.canPasteSelection()); // Paste

            int selSize = EWorldEditor.getSelectionSize();
            int lockCount = EWorldEditor.getSelectionLockCount();
            int hideCount = EWorldEditor.getSelectionHiddenCount();
            ((PopupMenu) editMenu).enableItem(6, (selSize > 0 && lockCount != selSize));
            // Delete Selection

            ((PopupMenu) editMenu).enableItem(8, canCutCopy); // Deselect  
            }

        [ConsoleInteraction]
        public override void handleDelete()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";

            // The tree handles deletion and notifies the
            // world editor to clear its selection.  
            //
            // This is because non-SceneObject elements like
            // SimGroups also need to be destroyed.
            //
            // See EditorTree::onObjectDeleteCompleted().
            int selSize = EWorldEditor.getSelectionSize();
            if (selSize > 0)
                EditorTree.deleteSelection();
            }

        [ConsoleInteraction]
        public override void handleDeselect()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.clearSelection();
            }

        [ConsoleInteraction]
        public override void handleCut()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.cutSelection();
            }

        [ConsoleInteraction]
        public override void handleCopy()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.copySelection();
            }

        [ConsoleInteraction]
        public override void handlePaste()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.pasteSelection();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WorldEditorInspectorPlugin ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null)
                ? object.ReferenceEquals(simobjectid, null)
                : ts.Equals(simobjectid);
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
        public static bool operator !=(WorldEditorInspectorPlugin ts, string simobjectid)
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
        public static implicit operator string(WorldEditorInspectorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator WorldEditorInspectorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (WorldEditorInspectorPlugin) Omni.self.getSimObject(simobjectid, typeof (WorldEditorInspectorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(WorldEditorInspectorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WorldEditorInspectorPlugin(int simobjectid)
            {
            return
                (WorldEditorInspectorPlugin)
                    Omni.self.getSimObject((uint) simobjectid, typeof (WorldEditorInspectorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(WorldEditorInspectorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WorldEditorInspectorPlugin(uint simobjectid)
            {
            return (WorldEditorInspectorPlugin) Omni.self.getSimObject(simobjectid, typeof (WorldEditorInspectorPlugin));
            }

        #endregion
        }
    }