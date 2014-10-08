using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (ForestEditorPlugin))]
    public class ForestEditorPlugin : EditorPlugin
        {
        public ActionMap map
            {
            get { return this["map"]; }
            set { this["map"] = value; }
            }

        [ConsoleInteraction]
        public void initialize()
            {
            ObjectCreator oc_Newobject3 = new ObjectCreator("SimSet", "ForestTools");

            ObjectCreator oc_Newobject2 = new ObjectCreator("ForestBrushTool");
            oc_Newobject2["internalName"] = "BrushTool";
            oc_Newobject2["toolTip"] = "Paint Tool";
            oc_Newobject2["buttonImage"] = "tools/forest/images/brushTool";

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            ObjectCreator oc_Newobject1 = new ObjectCreator("ForestSelectionTool");
            oc_Newobject1["internalName"] = "SelectionTool";
            oc_Newobject1["toolTip"] = "Selection Tool";
            oc_Newobject1["buttonImage"] = "tools/forest/images/selectionTool";
            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            oc_Newobject3.Create();

            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "ForestEditorSelectModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "ForestEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "ForestEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "ForestEditorScaleModeBtn.performClick();", ""); // Scale
            map.bindCmd("keyboard", "5", "ForestEditorPaintModeBtn.performClick();", ""); // Paint
            map.bindCmd("keyboard", "6", "ForestEditorEraseModeBtn.performClick();", ""); // Erase
            map.bindCmd("keyboard", "7", "ForestEditorEraseSelectedModeBtn.performClick();", ""); // EraseSelected   
            map.bindCmd("keyboard", "8", "ForestEditorDropToGroundModeBtn.performClick();", "");  // DropTheBeat
            //%map.bindCmd( keyboard, "backspace", "ForestEditorGui.onDeleteKey();", "" );
            //%map.bindCmd( keyboard, "delete", "ForestEditorGui.onDeleteKey();", "" );   
            this.map = map;
            }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
            {
            ForestEditorGui.ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            SimSet ForestItemDataSet = "ForestItemDataSet";
            ForestEditorGui.ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";
            EditorGui EditorGui = "EditorGui";
            ForestEditorGui.ForestEditTabBook ForestEditTabBook = "ForestEditTabBook";
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";

            new ObjectCreator("PersistenceManager", "ForestDataManager").Create();

            const string brushPath = "art/forest/brushes.cs";
            if (!Util.isFile(brushPath))
                Util.createPath(brushPath);

            // This creates the ForestBrushGroup, all brushes, and elements.
            Util.exec(brushPath, false, false);

            SimGroup ForestBrushGroup = "ForestBrushGroup";

            if (!ForestBrushGroup.isObject())
                {
                ForestBrushGroup = new ObjectCreator("SimGroup", "ForestBrushGroup").Create();
                this["showError"] = true.AsString();
                }

            ForestEditBrushTree.open(ForestBrushGroup);

            if (!ForestItemDataSet.isObject())
                ForestItemDataSet = new ObjectCreator("SimSet", "ForestItemDataSet").Create();

            ForestEditMeshTree.open(ForestItemDataSet);

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Forest Editor", "", this);

            // Add ourselves to the tools menu.
            string tooltip = "Forest Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("ForestEditorPlugin", "ForestEditorPalette",
                Util._expandFilename("tools/forestEditor/images/forest-editor-btn"), tooltip);

            //connect editor windows
            ForestEditorPalleteWindow.attachTo(ForestEditorPropertiesWindow);
            ForestEditTabBook.selectPage(0);
            }

        [ConsoleInteraction]
        public override void onWorldEditorShutdown()
            {
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            PersistenceManager ForestDataManager = "ForestDataManager";

            if (ForestBrushGroup.isObject())
                ForestBrushGroup.delete();
            if (ForestDataManager.isObject())
                ForestDataManager.delete();
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            EditorGui EditorGui = "EditorGui";
            ForestEditorGui ForestEditorGui = "ForestEditorGui";
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
            ForestEditorGui.ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";
            ForestEditorGui.ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            ForestEditorGui.ForestEditTabBook ForestEditTabBook = "ForestEditTabBook";
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            SimSet ForestItemDataSet = "ForestItemDataSet";
            SimSet ForestTools = "ForestTools";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            GuiBitmapButtonCtrl ForestEditorPaintModeBtn = "ForestEditorPaintModeBtn";
            GuiBitmapButtonCtrl ForestEditorSelectModeBtn = "ForestEditorSelectModeBtn";
            GuiBitmapButtonCtrl ForestEditorMoveModeBtn = "ForestEditorMoveModeBtn";
            GuiBitmapButtonCtrl ForestEditorRotateModeBtn = "ForestEditorRotateModeBtn";
            GuiBitmapButtonCtrl ForestEditorScaleModeBtn = "ForestEditorScaleModeBtn";
            GuiBitmapButtonCtrl ForestEditorEraseModeBtn = "ForestEditorEraseModeBtn";
            GuiBitmapButtonCtrl ForestEditorEraseSelectedModeBtn = "ForestEditorEraseSelectedModeBtn";
            GuiBitmapButtonCtrl ForestEditorDropToGroundModeBtn = "ForestEditorDropToGroundModeBtn";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            ForestBrushTool BrushTool = ForestTools.FOF("BrushTool");

            string mode;

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            EditorGui.bringToFront(ForestEditorGui);
            ForestEditorGui.setVisible(true);
            ForestEditorPalleteWindow.setVisible(true);
            ForestEditorPropertiesWindow.setVisible(true);
            ForestEditorGui.makeFirstResponder(true);
            //ForestEditToolbar.setVisible( true );

            this.map.push();
            base.onActivated();

            ForestEditBrushTree.open(ForestBrushGroup);
            ForestEditMeshTree.open(ForestItemDataSet);

            // Open the Brush tab.
            ForestEditTabBook.selectPage(0);

            // Sync the pallete button state

            // And toolbar.
            SimObject tool = ForestEditorGui.getActiveTool();
            if (tool.isObject())
                tool.call("onActivated");

            if (!tool.isObject())
                {
                ForestEditorPaintModeBtn.performClick();

                if (ForestEditBrushTree.getItemCount() > 0)
                    {
                    ForestEditBrushTree.selectItem(0, true);
                    }
                }
            else if (tool == SelectionTool)
                {
                mode = GlobalGizmoProfile["mode"];
                switch (mode)
                    {
                        case "None":
                            ForestEditorSelectModeBtn.performClick();
                            break;
                        case "Move":
                            ForestEditorMoveModeBtn.performClick();
                            break;
                        case "Rotate":
                            ForestEditorRotateModeBtn.performClick();
                            break;
                        case "Scale":
                            ForestEditorScaleModeBtn.performClick();
                            break;
                    }
                }
            else if (tool == BrushTool)
                {
                mode = BrushTool["mode"];
                switch (mode)
                    {
                        case "Paint":
                            ForestEditorPaintModeBtn.performClick();
                            break;
                        case "Erase":
                            ForestEditorEraseModeBtn.performClick();
                            break;
                        case "EraseSelected":
                            ForestEditorEraseSelectedModeBtn.performClick();
                            break;
                        case "DropToGround":
                            ForestEditorDropToGroundModeBtn.performClick();
                            break;
                    }
                }

            if (this["showError"].AsBool())
                messageBox.MessageBoxOK("Error",
                    "Your art/forest folder does not contain a valid brushes.cs. Brushes you create will not be saved!");
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
            ForestEditorGui ForestEditorGui = "ForestEditorGui";
            PersistenceManager ForestDataManager = "ForestDataManager";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013
            ForestEditorGui.setVisible(false);
            ForestEditorPalleteWindow.setVisible(false);
            ForestEditorPropertiesWindow.setVisible(false);

            SimObject tool = ForestEditorGui.getActiveTool();
            if (tool.isObject())
                tool.call("onDeactivated");

            // Also take this opportunity to save.
            ForestDataManager.saveDirty();

            this.map.pop();

            base.onDeactivated();
            }

        [ConsoleInteraction]
        public override bool isDirty()
            {
            ForestEditorGui ForestEditorGui = "ForestEditorGui";

            bool dirty = this["dirty"].AsBool() || ForestEditorGui.isDirty();
            return dirty;
            }

        [ConsoleInteraction]
        public override void clearDirty()
            {
            this["dirty"] = false.AsString();
            }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
            {
            PersistenceManager ForestDataManager = "ForestDataManager";
            Forest theForest = "theForest";
            SimGroup ForestBrushGroup = "ForestBrushGroup";

            ForestDataManager.saveDirty();

            if (theForest.isObject())
                {

                theForest.saveDataFile(theForest.dataFile);
                }

            ForestBrushGroup.save("art/forest/brushes.cs", false, "");
            }

        [ConsoleInteraction]
        public override void onEditorSleep()
            {
            }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
            {
            SimSet ForestTools = "ForestTools";
            ForestEditorGui ForestEditorGui = "ForestEditorGui";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");

            bool hasSelection = false;

            ForestSelectionTool selTool = SelectionTool;
            if (ForestEditorGui.getActiveTool() == selTool._iID)
                if (selTool.getSelectionCount() > 0)
                    hasSelection = true;

            ((PopupMenu) editMenu).enableItem(3, hasSelection); // Cut
            ((PopupMenu) editMenu).enableItem(4, hasSelection); // Copy
            ((PopupMenu) editMenu).enableItem(5, hasSelection); // Paste  
            ((PopupMenu) editMenu).enableItem(6, hasSelection); // Delete
            ((PopupMenu) editMenu).enableItem(8, hasSelection); // Deselect
            }

        [ConsoleInteraction]
        public override void handleDelete()
            {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.deleteSelection();
            }

        [ConsoleInteraction]
        public override void handleDeselect()
            {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.clearSelection();
            }

        [ConsoleInteraction]
        public override void handleCut()
            {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.cutSelection();
            }

        [ConsoleInteraction]
        public override void handleCopy()
            {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.copySelection();
            }

        [ConsoleInteraction]
        public override void handlePaste()
            {
            SimSet ForestTools = "ForestTools";

            ForestSelectionTool SelectionTool = ForestTools.FOF("SelectionTool");
            SelectionTool.pasteSelection();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(ForestEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(ForestEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ForestEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ForestEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorPlugin(int simobjectid)
            {
            return (ForestEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ForestEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestEditorPlugin(uint simobjectid)
            {
            return (ForestEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPlugin));
            }

        #endregion
        }
    }