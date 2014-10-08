using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeRoadEditor()
            {
            Omni.self.Print(" % Initializing Road and Path Editor");

            //exec( "./roadEditor.cs" );
            //RoadEditor_initialize();
            roadEditor.initialize();

            //exec( "./roadEditorGui.gui" );
            //RoadEditorGui_initialize();
            RoadEditorGui.initialize();


            //exec( "./roadEditorToolbar.gui");
            //RoadEditorToolbar_initialize();
            RoadEditorToolbar.initialize();

            //exec( "./roadEditorGui.cs" );

            // Add ourselves to EditorGui, where all the other tools reside
            RoadEditorGui roadEditorGui = "RoadEditorGui";
            RoadEditorToolbar roadEditorToolbar = "RoadEditorToolbar";

            roadEditorGui.setVisible(false);
            roadEditorToolbar.setVisible(false);

            ((GuiWindowCollapseCtrl) "RoadEditorOptionsWindow").setVisible(false);
            ((GuiWindowCollapseCtrl) "RoadEditorTreeWindow").setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("RoadEditorGui");
            EditorGui.add("RoadEditorToolbar");
            EditorGui.add("RoadEditorOptionsWindow");
            EditorGui.add("RoadEditorTreeWindow");

            ObjectCreator oRoadEditorPlugin = new ObjectCreator("ScriptObject", "RoadEditorPlugin",
                typeof (RoadEditorPlugin));
            oRoadEditorPlugin["editorGui"] = "RoadEditorGui";
            oRoadEditorPlugin.Create();

            RoadEditorPlugin RoadEditorPlugin = "RoadEditorPlugin";
            RoadEditorPlugin.initialize();
            }

        [ConsoleInteraction]
        public static void destroyRoadEditor()
            {
            }
        }
    }