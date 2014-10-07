using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor
{
    public class main
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void initializeNavEditor()
        {
            omni.Util._echo(" % - Initializing Navigation Editor");

            omni.iGlobal["$Nav::WalkFlag"] = 1 << 0;
            omni.iGlobal["$Nav::SwimFlag"] = 1 << 1;
            omni.iGlobal["$Nav::JumpFlag"] = 1 << 2;
            omni.iGlobal["$Nav::LedgeFlag"] = 1 << 3;
            omni.iGlobal["$Nav::DropFlag"] = 1 << 4;
            omni.iGlobal["$Nav::ClimbFlag"] = 1 << 5;
            omni.iGlobal["$Nav::TeleportFlag"] = 1 << 6;

            // Execute all relevant scripts and GUIs.
            //exec("./NavEditor.cs");
            NavEditorProfiles.initialize();
            //exec("./NavEditorGui.gui");
            gui.NavEditorGui.initialize();
            //exec("./NavEditorToolbar.gui");
            gui.NavEditorToolbar.initialize();
            //exec("./NavEditorGui.cs");
            //exec("./NavEditorAboutDlg.gui");
            NavEditorAboutDlg.initialize();
            //exec("./NavEditorConsoleDlg.gui");
            gui.NavEditorConsoleDlg.initialize();
            //exec("./CreateNewNavMeshDlg.gui");
            CreateNewNavMeshDlg.initialize();

            // Add ourselves to EditorGui, where all the other tools reside
            NavEditorGui NavEditorGui = "NavEditorGui";
            GuiControl NavEditorToolbar = "NavEditorToolbar";
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiWindowCollapseCtrl NavEditorTreeWindow = "NavEditorTreeWindow";
            GuiWindowCtrl NavEditorConsoleDlg = "NavEditorConsoleDlg";
            NavEditorGui.setVisible(false);  
            NavEditorToolbar.setVisible(false); 
            NavEditorOptionsWindow.setVisible(false);
            NavEditorTreeWindow.setVisible(false);
            NavEditorConsoleDlg.setVisible(false);

            EditorGui EditorGui = "EditorGui";
            EditorGui.add(NavEditorGui);
            EditorGui.add(NavEditorToolbar);
            EditorGui.add(NavEditorOptionsWindow);
            EditorGui.add(NavEditorTreeWindow);
            EditorGui.add(NavEditorConsoleDlg);

            var oc = new ObjectCreator("ScriptObject", "NavEditorPlugin", typeof(NavEditorPlugin));
            oc["editorGui"] = NavEditorGui;
            oc.Create();

            // Bind shortcuts for the nav editor.
            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "ENavEditorSelectModeBtn.performClick();", "");
            map.bindCmd("keyboard", "2", "ENavEditorLinkModeBtn.performClick();", "");
            map.bindCmd("keyboard", "3", "ENavEditorCoverModeBtn.performClick();", "");
            map.bindCmd("keyboard", "4", "ENavEditorTileModeBtn.performClick();", "");
            map.bindCmd("keyboard", "5", "ENavEditorTestModeBtn.performClick();", "");
            map.bindCmd("keyboard", "c", "NavEditorConsoleBtn.performClick();", "");
            NavEditorPlugin NavEditorPlugin = "NavEditorPlugin";
            NavEditorPlugin.map = map;

            NavEditorPlugin.initSettings();
        }

        [ConsoleInteraction]
        public static void destroyNavEditor()
        {
        }
    }
}
