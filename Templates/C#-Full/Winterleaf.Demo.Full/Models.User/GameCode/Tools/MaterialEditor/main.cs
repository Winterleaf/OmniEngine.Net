using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeMaterialEditor()
            {
            Omni.self.Print(" % - Initializing Material Editor");

            MaterialEditorPreviewWindow.initialize();

            MaterialEditorPropertiesWindow.initialize();


            MaterialEditorPreviewWindow oMaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
            oMaterialEditorPreviewWindow.setVisible(false);

            GuiWindowCtrl matEd_cubemapEditor = "matEd_cubemapEditor";
            matEd_cubemapEditor.setVisible(false);

            GuiWindowCtrl matEd_addCubemapWindow = "matEd_addCubemapWindow";
            matEd_addCubemapWindow.setVisible(false);

            MaterialEditorPropertiesWindow oMaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
            oMaterialEditorPropertiesWindow.setVisible(false);

            EditorGui EditorGui = "EditorGui";
            EditorGui.add("MaterialEditorPreviewWindow");
            EditorGui.add("matEd_cubemapEditor");
            EditorGui.add("matEd_addCubemapWindow");
            EditorGui.add("MaterialEditorPropertiesWindow");
            }

        [ConsoleInteraction]
        public static void destroyMaterialEditor()
            {
            }
        }
    }