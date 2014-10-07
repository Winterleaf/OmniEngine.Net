using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.Panels;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools
    {
    public class main
        {
        private static readonly pInvokes omni = new pInvokes();

        private static string[] EditorsToLoad = new string[]
            {
            "editorClasses", //Must be first
            "base", //Must be second
            "worldEditor", //Must be third, rest don't matter.
            "ConvexEditor",
            "DatablockEditor",
            "Debugger",
            "DecalEditor",
            "ForestEditor",
            "GuiEditor",
            "InGameEditor",
            "MaterialEditor",
            "MeshRoadEditor",
            "MissionAreaEditor",
            "ObjectExplorer",
            "ParticleEditor",
            "PhysicsTools",
            "RiverEditor",
            "RoadEditor",
            "ShapeEditor",
            "NavEditor"
            };

        public static void initialize()
            {
            omni.Util._echo("-------------------->Loading Tools");
            //---------------------------------------------------------------------------------------------
            // Path to the folder that contains the editors we will load.
            //---------------------------------------------------------------------------------------------
            omni.sGlobal["$Tools::resourcePath"] = "tools/";

            // These must be loaded first, in this order, before anything else is loaded
            omni.sGlobal["$Tools::loadFirst"] = "editorClasses base worldEditor";

            //---------------------------------------------------------------------------------------------
            // Object that holds the simObject id that the materialEditor uses to interpret its material list
            //---------------------------------------------------------------------------------------------

            omni.sGlobal["$Tools::materialEditorList"] = "";

            String ToExecute = @"
package Tools
    {
    function loadKeyBindings()
        {
        Parent::loadKeybindings();
        }
    function onStart()
        {
        Parent::onStart();
        tools_onStart();
        }
    function startToolTime(%tool)
        {
        tools_startToolTime(%tool);
        }
    function endToolTime(%tool)
        {
        tools_endToolTime(%tool);
        }
    function dumpToolData()
        {
        tools_dumpToolData();
        }
    function onExit()
        {
        tools_onExit();
        Parent::onExit();
        EditorSettings.write();
        }   
    };
";
            omni.console.Eval(ToExecute);
            omni.Util.activatePackage("Tools");
            }

        [ConsoleInteraction]
        public static void tools_onStart()
            {
            ObjectCreator oc = new ObjectCreator("Settings", "EditorSettings");
            oc["file"] = "tools/settings.xml";
            Settings EditorSettings = oc.Create();


            //new Settings(EditorSettings) { file = "tools/settings.xml"; };
            EditorSettings.read();

            omni.Util._echo(" % - Initializing Tools");

            // Default file path when saving from the editor (such as prefabs)
            if (omni.sGlobal["$Pref::WorldEditor::LastPath"] == "")
                {
                omni.sGlobal["$Pref::WorldEditor::LastPath"] = omni.Util.getMainDotCsDir();
                }

            // Common GUI stuff.


            //exec( "./gui/cursors.ed.cs" );
            //omni.Util.exec("tools/gui/profiles.ed.cs", false, false);
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.profiles.initialize();
            NavPanelProfiles.initialize();

            // Make sure we get editor profiles before any GUI's
            // BUG: these dialogs are needed earlier in the init sequence, and should be moved to
            // common, along with the guiProfiles they depend on.
            omni.Util.exec("tools/gui/guiDialogs.ed.cs", false, false);
            Gui.guiDialogs.initialize();

            //%toggle = $Scripts::ignoreDSOs;
            //$Scripts::ignoreDSOs = true;


            omni.uGlobal["$ignoredDatablockSet"] = new ObjectCreator("SimSet").Create();


            //// fill the list of editors
            //$editors[count] = getWordCount( $Tools::loadFirst );
            //for ( %i = 0; %i < $editors[count]; %i++ )
            //{
            //   $editors[%i] = getWord( $Tools::loadFirst, %i );
            //}

            //%pattern = $Tools::resourcePath @ "/*/main.cs";
            //%folder = findFirstFile( %pattern );
            //if ( %folder $= "")
            //{
            //   // if we have absolutely no matches for main.cs, we look for main.cs.dso
            //   %pattern = $Tools::resourcePath @ "/*/main.cs.dso";
            //   %folder = findFirstFile( %pattern );
            //}
            //while ( %folder !$= "" )
            //{
            //   if( filePath( %folder ) !$= "tools" ) // Skip the actual 'tools' folder...we want the children
            //   {
            //      %folder = filePath( %folder );
            //      %editor = fileName( %folder );
            //      if ( IsDirectory( %folder ) )
            //      {
            //         // Yes, this sucks and should be done better
            //         if ( strstr( $Tools::loadFirst, %editor ) == -1 )
            //         {
            //            $editors[$editors[count]] = %editor;
            //            $editors[count]++;
            //         }
            //      }
            //   }
            //   %folder = findNextFile( %pattern );
            //}

            // initialize every editor
            SimSet EditorPluginSet = new ObjectCreator("SimSet", "EditorPluginSet").Create();
            //new SimSet( EditorPluginSet );      
            foreach (string editor in EditorsToLoad)
                {
                string initializeFunction = "initialize" + editor;
                if (omni.Util.isFunction(initializeFunction))
                    omni.Util._call(initializeFunction);
                }
            //%count = $editors[count];
            //for ( %i = 0; %i < %count; %i++ )
            //{
            //   exec( "./" @ $editors[%i] @ "/main.cs" );

            //   %initializeFunction = "initialize" @ $editors[%i];
            //   if( isFunction( %initializeFunction ) )
            //      call( %initializeFunction );
            //}

            // Popuplate the default SimObject icons that 
            // are used by the various editors.
            //EditorIconRegistry::loadFromPath( "tools/classIcons/" );
            omni.console.Call_Classname("EditorIconRegistry", "loadFromPath", new[] {"tools/classIcons/"});

            // Load up the tools resources. All the editors are initialized at this point, so
            // resources can override, redefine, or add functionality.
            //      Tools::LoadResources( $Tools::resourcePath );
            LoadResources(omni.sGlobal["$Tools::resourcePath"]);
            }

        [ConsoleInteraction]
        public static void tools_startToolTime(string tool)
            {
            if (omni.sGlobal["$toolDataToolCount"] == "")
                omni.sGlobal["$toolDataToolCount"] = "0";

            if (omni.sGlobal["$toolDataToolEntry[" + tool + "]"] != "true")
                {
                omni.sGlobal["$toolDataToolEntry[" + tool + "]"] = "true";
                omni.sGlobal["$toolDataToolList[" + omni.sGlobal["$toolDataToolCount"] + "]"] = tool;
                omni.iGlobal["$toolDataToolCount"]++;
                omni.iGlobal["$toolDataClickCount[" + tool + "]"] = 0;
                }

            omni.iGlobal["$toolDataStartTime[" + tool + "]"] = omni.Util.getSimTime();
            omni.iGlobal["$toolDataClickCount[" + tool + "]"]++;
            }

        [ConsoleInteraction]
        public static void tools_endtoolTime(string tool)
            {
            int startTime = 0;
            if (omni.sGlobal["$toolDataStartTime[" + tool + "]"] != "")
                startTime = omni.iGlobal["$toolDataStartTime[" + tool + "]"];

            if (omni.sGlobal["$toolDataTotalTime[" + tool + "]"] == "")
                omni.iGlobal["$toolDataTotalTime[" + tool + "]"] = 0;

            omni.iGlobal["$toolDataTotalTime[" + tool + "]"] += omni.Util.getSimTime() - startTime;
            }

        [ConsoleInteraction]
        public static void tools_dumpToolData()
            {
            int count = omni.iGlobal["$toolDataToolCount"];
            for (int i = 0; i < count; i++)
                {
                string tool = omni.sGlobal["$toolDataToolList[" + i + "]"];
                int totalTime = omni.iGlobal["$toolDataTotalTime[" + tool + "]"];
                int clickCount = omni.iGlobal["$toolDataClickCount[" + tool + "]"];
                omni.Util._echo("---");
                omni.Util._echo("Tool: " + tool);
                omni.Util._echo("Time (Seconds): " + (totalTime/1000));
                omni.Util._echo("Activated: " + clickCount);
                omni.Util._echo("---");
                }
            }

        [ConsoleInteraction]
        public static void tools_onExit()
            {
            //Copyright Winterleaf Entertainment L.L.C. 2013
            ((GuiWindowCtrl) "ShapeEdPropWindow").ClosePopOut();
            ((GuiWindowCtrl) "ShapeEdSelectWindow").ClosePopOut();
            ((GuiWindowCtrl) "ShapeEdAdvancedWindow").ClosePopOut();
            ((GuiWindowCtrl) "RoadEditorOptionsWindow").ClosePopOut();
            ((GuiWindowCtrl) "RoadEditorTreeWindow").ClosePopOut();
            ((GuiWindowCtrl) "RiverEditorOptionsWindow").ClosePopOut();
            ((GuiWindowCtrl) "RiverEditorTreeWindow").ClosePopOut();
            ((GuiWindowCtrl) "PE_Window").ClosePopOut();
            ((GuiWindowCtrl) "MissionAreaEditorPropertiesWindow").ClosePopOut();
            ((GuiWindowCtrl) "MissionAreaEditorTerrainWindow").ClosePopOut();
            ((GuiWindowCtrl) "MeshRoadEditorOptionsWindow").ClosePopOut();
            ((GuiWindowCtrl) "MeshRoadEditorTreeWindow").ClosePopOut();
            ((GuiWindowCtrl) "ForestEditorPropertiesWindow").ClosePopOut();
            ((GuiWindowCtrl) "ForestEditorPalleteWindow").ClosePopOut();
            ((GuiWindowCtrl) "DecalPreviewWindow").ClosePopOut();
            ((GuiWindowCtrl) "DecalEditorWindow").ClosePopOut();
            ((GuiWindowCtrl) "DatablockEditorInspectorWindow").ClosePopOut();
            ((GuiWindowCtrl) "DatablockEditorTreeWindow").ClosePopOut();
            ((GuiWindowCtrl) "MaterialEditorPropertiesWindow").ClosePopOut();
            ((GuiWindowCtrl) "MaterialEditorPreviewWindow").ClosePopOut();
            ((GuiWindowCtrl) "TerrainPainterPreview").ClosePopOut();
            ((GuiWindowCtrl) "TerrainPainter").ClosePopOut();
            ((GuiWindowCtrl) "EWInspectorWindow").ClosePopOut();
            ((GuiWindowCtrl) "EWTreeWindow").ClosePopOut();
            ((GuiWindowCtrl) "ConsoleDlgWindow").ClosePopOut();
            ((GuiWindowCtrl) "ppOptionsWindow").ClosePopOut();
            ((GuiWindowCtrl) "ESettingsWindow").ClosePopOut();
            ((GuiWindowCtrl) "EManageBookmarks").ClosePopOut();
            ((GuiWindowCtrl) "EManageSFXParameters").ClosePopOut();
            ((GuiWindowCtrl) "ESnapOptions").ClosePopOut();
            ((GuiWindowCtrl) "ESelectObjectsWindow").ClosePopOut();
//Copyright Winterleaf Entertainment L.L.C. 2013      
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.isInitialized)
                EditorGui.shutdown();

            // Free all the icon images in the registry.
            //EditorIconRegistry::clear();
            omni.console.Call_Classname("EditorIconRegistry", "clear");

            // Save any Layouts we might be using
            //GuiFormManager::SaveLayout(LevelBuilder, Default, User);

            //%count = $editors[count];
            //for (%i = 0; %i < %count; %i++)
            //{
            //   %destroyFunction = "destroy" @ $editors[%i];
            //   if( isFunction( %destroyFunction ) )
            //      call( %destroyFunction );
            //}
            //      }
            foreach (string editor in EditorsToLoad)
                {
                string destroyfunction = "destroy" + editor;
                if (omni.Util.isFunction(destroyfunction))
                    omni.Util._call(destroyfunction);
                }
            }

        public static void LoadResources(string path)
            {
            string resourcesPath = path + "resources/";
            string resourcesList = omni.Util.getDirectoryList(resourcesPath, 0);

            int wordCount = omni.Util.getFieldCount(resourcesList);
            for (int i = 0; i < wordCount; i++)
                {
                string resource = omni.Util.getField(resourcesList, i);
                if (omni.Util.isFile(resourcesPath + resource + "/resourceDatabase.cs"))
                    omni.console.Call_Classname("ResourceObject", "load", new string[] {path, resource});
                }
            }
        }
    }