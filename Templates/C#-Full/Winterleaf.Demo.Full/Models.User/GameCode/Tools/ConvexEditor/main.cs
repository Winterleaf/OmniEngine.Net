using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeConvexEditor()
            {
            Omni.self.Print(" % - Initializing Sketch Tool");
            gui.ConvexEditor.initialize();
            ConvexEditorGui.initialize();
            ConvexEditorToolbar.initialize();
            ((ConvexEditorGui) "ConvexEditorGui").setVisible(false);
            ((GuiWindowCollapseCtrl) "ConvexEditorOptionsWindow").setVisible(false);
            ((GuiWindowCollapseCtrl) "ConvexEditorTreeWindow").setVisible(false);
            ((ConvexEditorToolbar) "ConvexEditorToolbar").setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("ConvexEditorGui");
            EditorGui.add("ConvexEditorOptionsWindow");
            EditorGui.add("ConvexEditorTreeWindow");
            EditorGui.add("ConvexEditorToolbar");

            ObjectCreator oConvexEditorPlugin = new ObjectCreator("ScriptObject", "ConvexEditorPlugin",
                typeof (gui.CodeBehind.ConvexEditorPlugin));
            oConvexEditorPlugin["editorGui"] = "ConvexEditorGui";
            gui.CodeBehind.ConvexEditorPlugin aConvexEditorPlugin = oConvexEditorPlugin.Create();


            // Note that we use the WorldEditor's Toolbar.

            aConvexEditorPlugin.initialize();
            }
        }
    }