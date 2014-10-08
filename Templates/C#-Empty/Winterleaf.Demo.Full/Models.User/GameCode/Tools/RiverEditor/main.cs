using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeRiverEditor()
            {
            Omni.self.Print(" % - Initializing River Editor");
            gui.RiverEditor.initialize();
            RiverEditorGui.initialize();
            RiverEditorToolbar.initialize();
            // Add ourselves to EditorGui, where all the other tools reside
            RiverEditorGui riverEditorGui = "RiverEditorGui";

            riverEditorGui.setVisible(false);

            RiverEditorToolbar oRiverEditorToolbar = "RiverEditorToolbar";

            oRiverEditorToolbar.setVisible(false);
            ((GuiWindowCollapseCtrl) "RiverEditorOptionsWindow").setVisible(false);
            GuiWindowCollapseCtrl RiverEditorTreeWindow = "RiverEditorTreeWindow";
            RiverEditorTreeWindow.setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("RiverEditorGui");
            EditorGui.add("RiverEditorToolbar");
            EditorGui.add("RiverEditorOptionsWindow");
            EditorGui.add("RiverEditorTreeWindow");

            ObjectCreator oRiverEditorPlugin = new ObjectCreator("ScriptObject", "RiverEditorPlugin",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui.CodeBehind.RiverEditorPlugin));
            oRiverEditorPlugin["editorGui"] = "RiverEditorGui";
            oRiverEditorPlugin.Create();

            gui.CodeBehind.RiverEditorPlugin RiverEditorPlugin = "RiverEditorPlugin";

            RiverEditorPlugin.initialize();
            }

        [ConsoleInteraction]
        public static void destroyRiverEditor()
            {
            }
        }
    }