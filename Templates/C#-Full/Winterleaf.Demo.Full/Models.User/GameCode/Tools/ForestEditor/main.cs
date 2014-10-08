using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeForestEditor()
            {
            Omni.self.Print(" % - Initializing Forest Editor");
            gui.ForestEditor.initialize();
            gui.ForestEditorGui.initialize();
            gui.ForestEditToolbar.initialize();


            ((gui.ForestEditorGui) "ForestEditorGui").setVisible(false);
            ((GuiWindowCollapseCtrl) "ForestEditorPalleteWindow").setVisible(false);
            ((GuiWindowCollapseCtrl) "ForestEditorPropertiesWindow").setVisible(false);
            ((gui.ForestEditToolbar) "ForestEditToolbar").setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("ForestEditorGui");
            EditorGui.add("ForestEditorPalleteWindow");
            EditorGui.add("ForestEditorPropertiesWindow");
            EditorGui.add("ForestEditToolbar");

            ObjectCreator oc = new ObjectCreator("ScriptObject", "ForestEditorPlugin",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui.CodeBehind.ForestEditorPlugin));
            oc["editorGui"] = "ForestEditorGui";
            oc.Create();


            ((gui.CodeBehind.ForestEditorPlugin) "ForestEditorPlugin").initialize();
            }

        [ConsoleInteraction]
        public static void destroyForestEditor()
            {
            }
        }
    }