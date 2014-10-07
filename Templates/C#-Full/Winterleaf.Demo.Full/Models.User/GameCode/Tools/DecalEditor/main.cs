using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor
    {
    public class main
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void initializeDecalEditor()
            {
            Omni.self.Print(" % - Initializing Decal Editor");
            omni.sGlobal["$decalDataFile"] = "art/decals/managedDecalData.cs";
            gui.DecalEditorGui.initialize();


            // Add ourselves to EditorGui, where all the other tools reside
            gui.DecalEditorGui DecalEditorGui = "DecalEditorGui";

            DecalEditorGui.setVisible(false);

            gui.DecalEditorGui.DecalPreviewWindow DecalPreviewWindow = "DecalPreviewWindow";

            DecalPreviewWindow.setVisible(false);
            gui.DecalEditorGui.DecalEditorWindow DecalEditorWindow = "DecalEditorWindow";
            DecalEditorWindow.setVisible(false);

            EditorGui EditorGui = "EditorGui";
            EditorGui.add(DecalEditorGui);
            EditorGui.add(DecalEditorWindow);
            EditorGui.add(DecalPreviewWindow);

            gui.DecalEditorGui.DecalEditorTabBook DecalEditorTabBook = "DecalEditorTabBook";
            DecalEditorTabBook.selectPage(0);

            ObjectCreator oc = new ObjectCreator("ScriptObject", "DecalEditorPlugin",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui.CodeBehind.DecalEditorPlugin));
            oc["editorGui"] = "DecalEditorGui";
            oc.Create();

            gui.CodeBehind.DecalEditorPlugin DecalEditorPlugin = "DecalEditorPlugin";

            DecalEditorPlugin.initialize();
            }

        [ConsoleInteraction]
        public static void destroyDecalEditor()
            {
            }
        }
    }