using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeDatablockEditor()
            {
            Omni.self.Print(" % Initializing Datablock Editor");
            gui.CodeBehind.DatablockEditor.initialize();
            DatablockEditorTreeWindow.initialize();
            DatablockEditorInspectorWindow.initialize();
            DatablockEditorCreatePrompt.initialize();

            // Add ourselves to EditorGui, where all the other tools reside
            DatablockEditorInspectorWindow oDatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";

            oDatablockEditorInspectorWindow.setVisible(false);
            DatablockEditorTreeWindow oDatablockEditorTreeWindow = "DatablockEditorTreeWindow";
            oDatablockEditorTreeWindow.setVisible(false);
            EditorGui EditorGui = "EditorGui";
            EditorGui.add("DatablockEditorInspectorWindow");
            EditorGui.add("DatablockEditorTreeWindow");

            ObjectCreator o = new ObjectCreator("ScriptObject", "DatablockEditorPlugin",
                typeof (
                    WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind.DatablockEditorPlugin
                    ));
            o["editorGui"] = "EWorldEditor";
            o.Create();
            gui.CodeBehind.DatablockEditorPlugin p = "DatablockEditorPlugin";

            p.initialize();
            }

        [ConsoleInteraction]
        public static void destroyDatablockEditor()
            {
            }
        }
    }