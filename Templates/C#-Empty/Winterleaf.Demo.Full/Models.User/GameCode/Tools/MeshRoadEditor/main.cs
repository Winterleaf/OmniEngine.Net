using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeMeshRoadEditor()
            {
            Omni.self.Print(" % - Initializing Mesh Road Editor");

            //exec( "./meshRoadEditor.cs" );
            //MeshRoadEditor_initialize();
            gui.MeshRoadEditor.initialize();
            //exec( "./meshRoadEditorGui.gui" );
            //MeshRoadEditorGui_initialize();
            MeshRoadEditorGui.initialize();
            //exec( "./meshRoadEditorToolbar.gui");
            //MeshRoadEditorToolbar_initialize();
            MeshRoadEditorToolbar.initialize();
            //exec( "./meshRoadEditorGui.cs" );

            MeshRoadEditorGui xMeshRoadEditorGui = "MeshRoadEditorGui";

            xMeshRoadEditorGui.setVisible(false);

            GuiWindowCollapseCtrl MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";

            MeshRoadEditorOptionsWindow.setVisible(false);
            MeshRoadEditorToolbar oMeshRoadEditorToolbar = "MeshRoadEditorToolbar";

            oMeshRoadEditorToolbar.setVisible(false);

            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui.MeshRoadEditorGui.
                MeshRoadEditorTreeWindow
                MeshRoadEditorTreeWindow = "MeshRoadEditorTreeWindow";

            MeshRoadEditorTreeWindow.setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("MeshRoadEditorGui");
            EditorGui.add("MeshRoadEditorOptionsWindow");
            EditorGui.add("MeshRoadEditorToolbar");
            EditorGui.add("MeshRoadEditorTreeWindow");

            ObjectCreator oMeshRoadEditorPlugin = new ObjectCreator("ScriptObject", "MeshRoadEditorPlugin",
                typeof (
                    WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui.CodeBehind.MeshRoadEditorPlugin));
            oMeshRoadEditorPlugin["editorGui"] = "MeshRoadEditorGui";
            oMeshRoadEditorPlugin.Create();

            gui.CodeBehind.MeshRoadEditorPlugin mrep = "MeshRoadEditorPlugin";


            mrep.initialize();
            }

        [ConsoleInteraction]
        public static void destroyMeshRoadEditor()
            {
            }
        }
    }