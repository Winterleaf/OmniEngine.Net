using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<ConvexEditorPlugin>))]
    public class ConvexEditorPlugin : EditorPlugin
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
            map.bindCmd("keyboard", "1", "ConvexEditorNoneModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "ConvexEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "ConvexEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "ConvexEditorScaleModeBtn.performClick();", ""); // Scale      
            this.map = map;

            this.initSettings();
            }

        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            MenuBuilder ConvexActionsMenu = "ConvexActionsMenu";
            ESettingsWindow ESettingsWindow = "ESettingsWindow";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Sketch Tool", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Sketch Tool (" + accel + ")";
            EditorGui.addToToolsToolbar("ConvexEditorPlugin", "ConvexEditorPalette",
                omni.Util._expandFilename("tools/convexEditor/images/convex-editor-btn"), tooltip);

            //connect editor windows
            ((GuiWindowCollapseCtrl) "ConvexEditorOptionsWindow").attachTo("ConvexEditorTreeWindow");

            // Allocate our special menu.
            // It will be added/removed when this editor is activated/deactivated.

            if (!ConvexActionsMenu.isObject())
                {
                SingletonCreator ocf = new SingletonCreator("PopupMenu", "ConvexActionsMenu", typeof (MenuBuilder));
                ocf["barTitle"] = "Sketch";

                ocf["item[0]"] = "Hollow Selected Shape" + '\t' + "" + '\t' + "ConvexEditorGui.hollowSelection();";
                ocf["item[1]"] = "Recenter Selected Shape" + '\t' + "" + '\t' + "ConvexEditorGui.recenterSelection();";

                ConvexActionsMenu = ocf.Create();
                }

            this["popupMenu"] = ConvexActionsMenu;

            //exec( "./convexEditorSettingsTab.ed.gui" );
            omni.console.Call("ConvexEditorSettingsTab_initialize");
            ESettingsWindow.addTabPage("EConvexEditorSettingsPage");
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            EditorGui EditorGui = "EditorGui";
            MenuBar menuBar = EditorGui["menuBar"];
            GuiControl ConvexEditorToolbar = "ConvexEditorToolbar";
            GuiConvexEditorCtrl ConvexEditorGui = "ConvexEditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            this.readSettings();

            EditorGui.bringToFront(ConvexEditorGui);
            ConvexEditorGui.setVisible(true);
            ConvexEditorToolbar.setVisible(true);
            ConvexEditorGui.makeFirstResponder(true);
            this.map.push();

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("Sketch Tool.");
            EditorGuiStatusBar.setSelection("");

            // Add our menu.
            menuBar.insert("ConvexActionsMenu", menuBar["dynamicItemInsertPos"].AsInt());

            // Sync the pallete button state with the gizmo mode.
            string mode = GlobalGizmoProfile["mode"];
            switch (mode)
                {
                    case "None":
                        ((GuiBitmapButtonCtrl) "ConvexEditorNoneModeBtn").performClick();
                        break;
                    case "Move":
                        ((GuiBitmapButtonCtrl) "ConvexEditorMoveModeBtn").performClick();
                        break;
                    case "Rotate":
                        ((GuiBitmapButtonCtrl) "ConvexEditorRotateModeBtn").performClick();
                        break;
                    case "Scale":
                        ((GuiBitmapButtonCtrl) "ConvexEditorScaleModeBtn").performClick();
                        break;
                }

            base.onActivated();
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            EditorGui EditorGui = "EditorGui";
            MenuBar menuBar = EditorGui["menuBar"];
            GuiControl ConvexEditorToolbar = "ConvexEditorToolbar";
            GuiConvexEditorCtrl ConvexEditorGui = "ConvexEditorGui";
            GuiWindowCollapseCtrl ConvexEditorOptionsWindow = "ConvexEditorOptionsWindow";
            GuiWindowCollapseCtrl ConvexEditorTreeWindow = "ConvexEditorTreeWindow";


            this.writeSettings();

            ConvexEditorGui.setVisible(false);
            ConvexEditorOptionsWindow.setVisible(false);
            ConvexEditorTreeWindow.setVisible(false);
            ConvexEditorToolbar.setVisible(false);
            this.map.pop();

            // Remove our menu.
            menuBar.remove("ConvexActionsMenu");

            base.onDeactivated();
            }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
            {
            bool hasSelection = false;

            if (((GuiConvexEditorCtrl) "ConvexEditorGui").hasSelection().AsBool())
                hasSelection = true;

            ((MenuBuilder) editMenu).enableItem(3, false); // Cut
            ((MenuBuilder) editMenu).enableItem(4, false); // Copy
            ((MenuBuilder) editMenu).enableItem(5, false); // Paste 
            ((MenuBuilder) editMenu).enableItem(6, hasSelection); // Delete
            ((MenuBuilder) editMenu).enableItem(8, hasSelection); // Deselect    
            }

        [ConsoleInteraction]
        public override void handleDelete()
            {
            ((GuiConvexEditorCtrl) "ConvexEditorGui").handleDelete();
            }

        [ConsoleInteraction]
        public override void handleDeselect()
            {
            ((GuiConvexEditorCtrl) "ConvexEditorGui").handleDeselect();
            }

        [ConsoleInteraction]
        public override void handleCut()
            {
            //WorldEditorInspectorPlugin.handleCut();
            }

        [ConsoleInteraction]
        public override void handleCopy()
            {
            //WorldEditorInspectorPlugin.handleCopy();
            }

        [ConsoleInteraction]
        public override void handlePaste()
            {
            //WorldEditorInspectorPlugin.handlePaste();
            }

        [ConsoleInteraction]
        public override bool isDirty()
            {
            return ((GuiConvexEditorCtrl) "ConvexEditorGui")["isDirty"].AsBool();
            }

        [ConsoleInteraction]
        public override void onSaveMission(string missionFile)
            {
            GuiConvexEditorCtrl ConvexEditorGui = "ConvexEditorGui";
            if (ConvexEditorGui["isDirty"].AsBool())
                {
                ((SimGroup) "MissionGroup").save(missionFile, false, "");
                ConvexEditorGui["isDirty"] = false.AsString();
                }
            }

        //-----------------------------------------------------------------------------
        // Settings
        //-----------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ConvexEditor", true);
            EditorSettings.setDefaultValue("MaterialName", "Grid512_OrangeLines_Mat");
            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void readSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ConvexEditor", true);
            ((GuiConvexEditorCtrl) "ConvexEditorGui")["materialName"] = EditorSettings.value("MaterialName");
            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void writeSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ConvexEditor", true);
            EditorSettings.setValue("MaterialName", ((GuiConvexEditorCtrl) "ConvexEditorGui")["materialName"]);
            EditorSettings.endGroup();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConvexEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(ConvexEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(ConvexEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ConvexEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConvexEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorPlugin(int simobjectid)
            {
            return (ConvexEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ConvexEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConvexEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConvexEditorPlugin(uint simobjectid)
            {
            return (ConvexEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorPlugin));
            }

        #endregion
        }
    }