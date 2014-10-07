using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeShapeEditor()
            {
            Omni.self.Print(" % - Initializing Shape Editor");

            ShapeEditorProfiles.initialize();
            ShapeEdPreviewWindow.initialize();
            ShapeEdAnimWindow.initialize();
            ShapeEdAdvancedWindow.initialize();
            ShapeEditorToolbar.initialize();
            ShapeEdSelectWindow.initialize();
            ShapeEdPropWindow.initialize();
            gui.CodeBehind.ShapeEditor.initialize();
            ShapeEditorHints.initialize();
            ShapeEditorActions.initialize();

            // Add windows to editor gui
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind.ShapeEditor.ShapeEdPreviewGui
                ShapeEdPreviewGui = "ShapeEdPreviewGui";
            ShapeEdPreviewGui.setVisible(false);

            ShapeEdAnimWindow shapeEdAnimWindow = "ShapeEdAnimWindow";

            shapeEdAnimWindow.setVisible(false);

            ShapeEditorToolbar shapeEditorToolbar = "ShapeEditorToolbar";

            shapeEditorToolbar.setVisible(false);

            ShapeEdSelectWindow shapeEdSelectWindow = "ShapeEdSelectWindow";
            shapeEdSelectWindow.setVisible(false);
            ShapeEdPropWindow shapeEdPropWindow = "ShapeEdPropWindow";
            shapeEdPropWindow.setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("ShapeEdPreviewGui");
            EditorGui.add("ShapeEdAnimWindow");
            EditorGui.add("ShapeEdAdvancedWindow");

            EditorGui.add("ShapeEditorToolbar");
            EditorGui.add("ShapeEdSelectWindow");
            EditorGui.add("ShapeEdPropWindow");


            ObjectCreator oShapeEditorPlugin = new ObjectCreator("ScriptObject", "ShapeEditorPlugin",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind.ShapeEditorPlugin));
            oShapeEditorPlugin["editorGui"] = "ShapeEdShapeView";
            oShapeEditorPlugin.Create();

            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";

            ShapeEditorPlugin.initialize();
            }

        [ConsoleInteraction]
        public static void destroyShapeEditor()
            {
            }
        }
    }