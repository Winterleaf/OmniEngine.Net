// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.Panels;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools
{
    public class main
    {
        private static string[] EditorsToLoad = new string[] {"editorClasses", //Must be first
            "base", //Must be second
            "worldEditor", //Must be third, rest don't matter.
            "ConvexEditor", "DatablockEditor", "Debugger", "DecalEditor", "ForestEditor", "GuiEditor", "InGameEditor", "MaterialEditor", "MeshRoadEditor", "MissionAreaEditor", "ObjectExplorer", "ParticleEditor", "PhysicsTools", "RiverEditor", "RoadEditor", "ShapeEditor", "NavEditor"};

        public static void initialize()
        {
            pInvokes.Util._echo("-------------------->Loading Tools");
            //---------------------------------------------------------------------------------------------
            // Path to the folder that contains the editors we will load.
            //---------------------------------------------------------------------------------------------
            pInvokes.sGlobal["$Tools::resourcePath"] = "tools/";

            // These must be loaded first, in this order, before anything else is loaded
            pInvokes.sGlobal["$Tools::loadFirst"] = "editorClasses base worldEditor";

            //---------------------------------------------------------------------------------------------
            // Object that holds the simObject id that the materialEditor uses to interpret its material list
            //---------------------------------------------------------------------------------------------

            pInvokes.sGlobal["$Tools::materialEditorList"] = "";

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
            pInvokes.console.Eval(ToExecute);
            pInvokes.Util.activatePackage("Tools");
        }

        [ConsoleInteraction]
        public static void tools_onStart()
        {
            ObjectCreator oc = new ObjectCreator("Settings", "EditorSettings");
            oc["file"] = "tools/settings.xml";
            Settings EditorSettings = oc.Create();

            //new Settings(EditorSettings) { file = "tools/settings.xml"; };
            EditorSettings.read();

            pInvokes.Util._echo(" % - Initializing Tools");

            // Default file path when saving from the editor (such as prefabs)
            if (pInvokes.sGlobal["$Pref::WorldEditor::LastPath"] == "")
                pInvokes.sGlobal["$Pref::WorldEditor::LastPath"] = pInvokes.Util.getMainDotCsDir();

            // Common GUI stuff.

            //exec( "./gui/cursors.ed.cs" );
            //pInvokes.Util.exec("tools/gui/profiles.ed.cs", false, false);
            profiles.initialize();
            NavPanelProfiles.initialize();

            // Make sure we get editor profiles before any GUI's
            // BUG: these dialogs are needed earlier in the init sequence, and should be moved to
            // common, along with the guiProfiles they depend on.
            pInvokes.Util.exec("tools/gui/guiDialogs.ed.cs", false, false);
            guiDialogs.initialize();

            //%toggle = $Scripts::ignoreDSOs;
            //$Scripts::ignoreDSOs = true;

            pInvokes.uGlobal["$ignoredDatablockSet"] = new ObjectCreator("SimSet").Create();

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
                if (pInvokes.Util.isFunction(initializeFunction))
                    pInvokes.Util._call(initializeFunction);
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
            pInvokes.console.Call_Classname("EditorIconRegistry", "loadFromPath", new[] {"tools/classIcons/"});

            // Load up the tools resources. All the editors are initialized at this point, so
            // resources can override, redefine, or add functionality.
            //      Tools::LoadResources( $Tools::resourcePath );
            LoadResources(pInvokes.sGlobal["$Tools::resourcePath"]);
        }

        [ConsoleInteraction]
        public static void tools_startToolTime(string tool)
        {
            if (pInvokes.sGlobal["$toolDataToolCount"] == "")
                pInvokes.sGlobal["$toolDataToolCount"] = "0";

            if (pInvokes.sGlobal["$toolDataToolEntry[" + tool + "]"] != "true")
                {
                pInvokes.sGlobal["$toolDataToolEntry[" + tool + "]"] = "true";
                pInvokes.sGlobal["$toolDataToolList[" + pInvokes.sGlobal["$toolDataToolCount"] + "]"] = tool;
                pInvokes.iGlobal["$toolDataToolCount"]++;
                pInvokes.iGlobal["$toolDataClickCount[" + tool + "]"] = 0;
                }

            pInvokes.iGlobal["$toolDataStartTime[" + tool + "]"] = pInvokes.Util.getSimTime();
            pInvokes.iGlobal["$toolDataClickCount[" + tool + "]"]++;
        }

        [ConsoleInteraction]
        public static void tools_endtoolTime(string tool)
        {
            int startTime = 0;
            if (pInvokes.sGlobal["$toolDataStartTime[" + tool + "]"] != "")
                startTime = pInvokes.iGlobal["$toolDataStartTime[" + tool + "]"];

            if (pInvokes.sGlobal["$toolDataTotalTime[" + tool + "]"] == "")
                pInvokes.iGlobal["$toolDataTotalTime[" + tool + "]"] = 0;

            pInvokes.iGlobal["$toolDataTotalTime[" + tool + "]"] += pInvokes.Util.getSimTime() - startTime;
        }

        [ConsoleInteraction]
        public static void tools_dumpToolData()
        {
            int count = pInvokes.iGlobal["$toolDataToolCount"];
            for (int i = 0; i < count; i++)
                {
                string tool = pInvokes.sGlobal["$toolDataToolList[" + i + "]"];
                int totalTime = pInvokes.iGlobal["$toolDataTotalTime[" + tool + "]"];
                int clickCount = pInvokes.iGlobal["$toolDataClickCount[" + tool + "]"];
                pInvokes.Util._echo("---");
                pInvokes.Util._echo("Tool: " + tool);
                pInvokes.Util._echo("Time (Seconds): " + (totalTime/1000));
                pInvokes.Util._echo("Activated: " + clickCount);
                pInvokes.Util._echo("---");
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
            pInvokes.console.Call_Classname("EditorIconRegistry", "clear");

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
                if (pInvokes.Util.isFunction(destroyfunction))
                    pInvokes.Util._call(destroyfunction);
                }
        }

        public static void LoadResources(string path)
        {
            string resourcesPath = path + "resources/";
            string resourcesList = pInvokes.Util.getDirectoryList(resourcesPath, 0);

            int wordCount = pInvokes.Util.getFieldCount(resourcesList);
            for (int i = 0; i < wordCount; i++)
                {
                string resource = pInvokes.Util.getField(resourcesList, i);
                if (pInvokes.Util.isFile(resourcesPath + resource + "/resourceDatabase.cs"))
                    pInvokes.console.Call_Classname("ResourceObject", "load", new string[] {path, resource});
                }
        }
    }
}