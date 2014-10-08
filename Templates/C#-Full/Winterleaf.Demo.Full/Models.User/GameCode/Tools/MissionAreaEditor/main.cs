using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeMissionAreaEditor()
            {
            Omni.self.Print(" % - Initializing Mission Area Editor");

            //exec( "./missionAreaEditor.ed.cs" );
            //MissionAreaEditor_initialize();
            gui.MissionAreaEditor.initialize();
            //exec( "./missionAreaEditorGui.ed.gui" );
            //MissionAreaEditorGui_initialize();
            MissionAreaEditorGui.initialize();
            //exec( "./missionAreaEditorGui.ed.cs" );

            // Add ourselves to EditorGui, where all the other tools reside
            MissionAreaEditorGui oMissionAreaEditorGui = "MissionAreaEditorGui";

            oMissionAreaEditorGui.setVisible(false);

            GuiWindowCollapseCtrl MissionAreaEditorTerrainWindow = "MissionAreaEditorTerrainWindow";

            MissionAreaEditorTerrainWindow.setVisible(false);

            GuiWindowCollapseCtrl MissionAreaEditorPropertiesWindow = "MissionAreaEditorPropertiesWindow";
            MissionAreaEditorPropertiesWindow.setVisible(false);

            EditorGui EditorGui = "EditorGui";

            EditorGui.add("MissionAreaEditorGui");
            EditorGui.add("MissionAreaEditorTerrainWindow");
            EditorGui.add("MissionAreaEditorPropertiesWindow");

            ObjectCreator ocMissionAreaEditorPlugin = new ObjectCreator("ScriptObject", "MissionAreaEditorPlugin",
                typeof (MissionAreaEditorPlugin));
            ocMissionAreaEditorPlugin["editorGui"] = "MissionAreaEditorGui";
            ocMissionAreaEditorPlugin.Create();


            MissionAreaEditorPlugin oMissionAreaEditorPlugin = "MissionAreaEditorPlugin";

            oMissionAreaEditorPlugin.initialize();
            }

        [ConsoleInteraction]
        public static void destroyMissionAreaEditor()
            {
            }
        }
    }