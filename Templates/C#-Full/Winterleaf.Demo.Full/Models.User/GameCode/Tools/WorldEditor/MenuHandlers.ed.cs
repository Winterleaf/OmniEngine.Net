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
using System.ComponentModel;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.ChooseLevel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using Path = System.IO.Path;
using SaveFileDialog = System.Windows.Forms.SaveFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
{
    public class MenuHandlers
    {
        [ConsoleInteraction(true, "MenuHandlers_initialize")]
        public static void initialize()
        {
            pInvokes.sGlobal["$Pref::WorldEditor::FileSpec"] = "Torque Mission Files (*.mis)|*.mis|All Files (*.*)|*.*";

            // Package that gets temporarily activated to toggle editor after mission loading.
            // Deactivates itself.
            string package = @"package BootEditor {

            function GameConnection::initialControlSet( %this )
            {
            Parent::initialControlSet( %this );
   
            toggleEditor( true );
            deactivatePackage(""BootEditor"");
            }

            };";
            pInvokes.Util.eval(package);

            //pInvokes.Util.deactivatePackage("BootEditor");
        }

        /// Checks the various dirty flags and returns true if the 
        /// mission or other related resources need to be saved.  
        [ConsoleInteraction]
        public static bool EditorIsDirty()
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            EWorldEditor EWorldEditor = "EWorldEditor";
            PersistenceManager ETerrainPersistMan = "ETerrainPersistMan";
            SimSet EditorPluginSet = "EditorPluginSet";

            // We kept a hard coded test here, but we could break these
            // into the registered tools if we wanted to.
            bool isDirty = (ETerrainEditor.isObject() && (ETerrainEditor["isMissionDirty"].AsBool() || ETerrainEditor["isDirty"].AsBool())) || (EWorldEditor.isObject() && EWorldEditor.isDirty) || (ETerrainPersistMan.isObject() && ETerrainPersistMan.hasDirty());

            // Give the editor plugins a chance to set the dirty flag.
            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin obj = EditorPluginSet.getObject(i);
                isDirty |= obj.isDirty();
                }

            return isDirty;
        }

        /// Clears all the dirty state without saving.
        [ConsoleInteraction]
        public static void EditorClearDirty()
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            EWorldEditor EWorldEditor = "EWorldEditor";
            PersistenceManager ETerrainPersistMan = "ETerrainPersistMan";
            SimSet EditorPluginSet = "EditorPluginSet";

            EWorldEditor.isDirty = false;
            ETerrainEditor.isDirty = false;
            ETerrainEditor.isMissionDirty = false;
            ETerrainPersistMan.clearAll();

            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin obj = EditorPluginSet.getObject(i);
                obj.clearDirty();
                }
        }

        [ConsoleInteraction]
        public static void EditorQuitGame()
        {
            if (EditorIsDirty() && !pInvokes.Util.isWebDemo())
                messageBox.MessageBoxYesNoCancel("Level Modified", "Would you like to save your changes before quitting?", "EditorSaveMissionMenu(); quit();", "quit();", "");
            else
                pInvokes.console.Call("quit");
        }

        [ConsoleInteraction]
        public static void EditorExitMission()
        {
            if (EditorIsDirty() && !pInvokes.Util.isWebDemo())
                messageBox.MessageBoxYesNoCancel("Level Modified", "Would you like to save your changes before exiting?", "EditorDoExitMission(true);", "EditorDoExitMission(false);", "");
            else
                EditorDoExitMission(false);
        }

        [ConsoleInteraction]
        public static void EditorDoExitMission(bool saveFirst)
        {
            GuiChunkedBitmapCtrl MainMenuGui = "MainMenuGui";
            editor Editor = "Editor";

            if (saveFirst && !pInvokes.Util.isWebDemo())
                EditorSaveMissionMenu();
            else
                EditorClearDirty();

            if (MainMenuGui.isObject())
                Editor.close(MainMenuGui);

            pInvokes.console.Call("disconnect");
        }

        [ConsoleInteraction]
        public static void EditorOpenTorsionProject(string projectFile)
        {
            Settings EditorSettings = "EditorSettings";

            // Make sure we have a valid path to the Torsion installation.

            string torsionPath = EditorSettings.value("WorldEditor/torsionPath");
            if (!pInvokes.Util.isFile(torsionPath))
                {
                messageBox.MessageBoxOK("Torsion Not Found", "Torsion not found at '" + torsionPath + "'.  Please set the correct path in the preferences.");
                return;
                }

            // Determine the path to the .torsion file.

            if (projectFile == "")
                {
                string projectName = pInvokes.Util.fileBase(pInvokes.Util.getExecutableName());
                projectFile = pInvokes.Util.makeFullPath(projectName + ".torsion", "");
                if (!pInvokes.Util.isFile(projectFile))
                    {
                    projectFile = pInvokes.Util.findFirstFile("*.torsion", false);
                    if (!pInvokes.Util.isFile(projectFile))
                        {
                        messageBox.MessageBoxOK("Project File Not Found", "Cannot find .torsion project file in '" + pInvokes.Util.getMainDotCsDir() + "'.");
                        return;
                        }
                    }
                }

            // Open the project in Torsion.

            pInvokes.Util.shellExecute(torsionPath, "\"" + projectFile + "\"");
        }

        [ConsoleInteraction]
        public static void EditorOpenFileInTorsion(string file, string line)
        {
            Settings EditorSettings = "EditorSettings";

            // Make sure we have a valid path to the Torsion installation.

            string torsionPath = EditorSettings.value("WorldEditor/torsionPath");
            if (!pInvokes.Util.isFile(torsionPath))
                {
                messageBox.MessageBoxOK("Torsion Not Found", "Torsion not found at '" + torsionPath + "'.  Please set the correct path in the preferences.");
                return;
                }

            // If no file was specified, take the current mission file.

            if (file == "")
                file = pInvokes.Util.makeFullPath(pInvokes.sGlobal["$Server::MissionFile"], "");

            // Open the file in Torsion.

            string args = "\"" + file;
            if (line != "")
                args = args + ":" + line;
            args = args + "\"";

            pInvokes.Util.shellExecute(torsionPath, args);
        }

        [ConsoleInteraction]
        public static void EditorOpenDeclarationInTorsion(SimObject xobject)
        {
            string fileName = xobject.getFilename();
            if (fileName == "")
                return;

            EditorOpenFileInTorsion(pInvokes.Util.makeFullPath(fileName, "'"), xobject.getDeclarationLine().AsString());
        }

        [ConsoleInteraction]
        public static void EditorNewLevel(string file)
        {
            editor Editor = "Editor";
            EditorGui EditorGui = "EditorGui";
            Settings EditorSettings = "EditorSettings";

            if (pInvokes.Util.isWebDemo())
                return;

            bool saveFirst = false;
            if (EditorIsDirty())
                {
                pInvokes.Util._error("knob");
                saveFirst = pInvokes.Util.messageBox("Mission Modified", "Would you like to save changes to the current mission \"" + pInvokes.sGlobal["$Server::MissionFile"] + "\" before creating a new mission?", "SaveDontSave", "Question") == pInvokes.iGlobal["$MROk"];
                }

            if (saveFirst)
                EditorSaveMission();

            // Clear dirty flags first to avoid duplicate dialog box from EditorOpenMission()
            if (Editor.isObject())
                {
                EditorClearDirty();
                Editor.getUndoManager().clearAll();
                }

            if (file == "")
                file = EditorSettings.value("WorldEditor/newLevelFile");

            if (!pInvokes.bGlobal["$missionRunning"])
                {
                pInvokes.Util.activatePackage("BootEditor");
                chooseLevelDlg.StartLevel(file, "");
                }
            else
                EditorOpenMission(file);

            //EWorldEditor.isDirty = true;
            //ETerrainEditor.isDirty = true;
            EditorGui["saveAs"] = true.AsString();
        }

        [ConsoleInteraction]
        public static void EditorSaveMissionMenu()
        {
            EditorGui EditorGui = "EditorGui";

            if (!pInvokes.bGlobal["$Pref::disableSaving"] && !pInvokes.Util.isWebDemo())
                {
                if (EditorGui["saveAs"].AsBool())
                    EditorSaveMissionAs("");
                else
                    EditorSaveMission();
                }
            else
                EditorSaveMissionMenuDisableSave();
        }

        [ConsoleInteraction]
        public static bool EditorSaveMission()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            SimGroup MissionGroup = "MissionGroup";
            PersistenceManager ETerrainPersistMan = "ETerrainPersistMan";
            SimSet EditorPluginSet = "EditorPluginSet";
            EditorGui EditorGui = "EditorGui";

            // just save the mission without renaming it

            // first check for dirty and read-only files:
            if ((EWorldEditor.isDirty || ETerrainEditor.isMissionDirty) && !pInvokes.Util.isWriteableFileName(pInvokes.sGlobal["$Server::MissionFile"]))
                {
                pInvokes.Util.messageBox("Error", "Mission file \"" + pInvokes.sGlobal["$Server::MissionFile"] + "\" is read-only.  Continue?", "Ok", "Stop");
                return false;
                }
            if (ETerrainEditor.isDirty)
                {
                // Find all of the terrain files
                pInvokes.Util.initContainerTypeSearch(pInvokes.uGlobal["$TypeMasks::TerrainObjectType"], false);

                TerrainBlock terrainObject;
                while ((terrainObject = pInvokes.Util.containerSearchNext(false)) != 0)
                    {
                    if (!pInvokes.Util.isWriteableFileName(terrainObject["terrainFile"]))
                        {
                        if (pInvokes.Util.messageBox("Error", "Terrain file \"" + terrainObject["terrainFile"] + "\" is read-only.  Continue?", "Ok", "Stop") == pInvokes.iGlobal["$MROk"])
                            continue;
                        else
                            return false;
                        }
                    }
                }

            // now write the terrain and mission files out:

            if (EWorldEditor.isDirty || ETerrainEditor["isMissionDirty"].AsBool())
                MissionGroup.save(pInvokes.sGlobal["$Server::MissionFile"], false, "");
            if (ETerrainEditor["isDirty"].AsBool())
                {
                // Find all of the terrain files
                pInvokes.Util.initContainerTypeSearch(pInvokes.uGlobal["$TypeMasks::TerrainObjectType"], false);

                TerrainBlock terrainObject;
                while ((terrainObject = pInvokes.Util.containerSearchNext(false)) != 0)
                    terrainObject.save(terrainObject["terrainFile"]);
                }

            ETerrainPersistMan.saveDirty();

            // Give EditorPlugins a chance to save.
            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin obj = EditorPluginSet.getObject(i);
                if (obj.isDirty())
                    obj.onSaveMission(pInvokes.sGlobal["$Server::MissionFile"]);
                }

            EditorClearDirty();

            EditorGui["saveAs"] = false.AsString();

            return true;
        }

        [ConsoleInteraction]
        public static void EditorSaveMissionMenuDisableSave()
        {
            GuiCanvas Canvas = "Canvas";
            GenericPromptDialog GenericPromptDialog = "GenericPromptDialog";

            GuiWindowCtrl GenericPromptWindow = GenericPromptDialog.FOT("GenericPromptWindow");
            GuiTextCtrl GenericPromptText = GenericPromptDialog.FOT("GenericPromptText");

            GenericPromptWindow["text"] = "Warning";
            GenericPromptText.setText("Saving disabled in demo mode.");
            Canvas.pushDialog(GenericPromptDialog);
        }

        [ConsoleInteraction]
        public static void EditorSaveMissionAs(string missionName)
        {
            Settings EditorSettings = "EditorSettings";
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorGui EditorGui = "EditorGui";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            if (!pInvokes.bGlobal["$Pref::disableSaving"] && !pInvokes.Util.isWebDemo())
                {
                // If we didn't get passed a new mission name then
                // prompt the user for one.
                if (missionName == "")
                    {
                    SaveFileDialog sfd = new SaveFileDialog {Filter = pInvokes.sGlobal["$Pref::WorldEditor::FileSpec"], InitialDirectory = Path.Combine(Environment.CurrentDirectory, EditorSettings.value("LevelInformation/levelsDirectory")), OverwritePrompt = true,};

                    DialogResult dr = Dialogs.SaveFileDialog(ref sfd);

                    switch (dr)
                        {
                            case DialogResult.OK:
                                string filename = Dialogs.GetForwardSlashFile(sfd.FileName);
                                // Immediately override/set the levelsDirectory
                                EditorSettings.setValue("LevelInformation/levelsDirectory", pInvokes.console.Call("collapseFilename", new string[] {pInvokes.Util.filePath(filename)}));

                                missionName = filename;
                                break;
                            case DialogResult.Abort:
                            case DialogResult.Ignore:
                            case DialogResult.No:
                            case DialogResult.Cancel:
                            case DialogResult.None:
                                return;
                        }
                    }

                if (pInvokes.Util.fileExt(missionName) != ".mis")
                    missionName = missionName + ".mis";

                EWorldEditor.isDirty = true;
                string saveMissionFile = pInvokes.sGlobal["$Server::MissionFile"];

                pInvokes.sGlobal["$Server::MissionFile"] = missionName;

                bool copyTerrainsFailed = false;

                // Rename all the terrain files.  Save all previous names so we can
                // reset them if saving fails.
                string newMissionName = pInvokes.Util.fileBase(missionName);
                string oldMissionName = pInvokes.Util.fileBase(saveMissionFile);

                pInvokes.Util.initContainerTypeSearch(pInvokes.uGlobal["$TypeMasks::TerrainObjectType"]);
                ScriptObject savedTerrNames = new ObjectCreator("ScriptObject").Create();
                for (int i = 0;; i++)
                    {
                    string nterrainObject = pInvokes.Util.containerSearchNext(false);
                    if (nterrainObject == "")
                        break;
                    TerrainBlock terrainObject = nterrainObject; //pInvokes.Util.containerSearchNext(false);
                    //if (terrainObject == null)
                    //    break;

                    savedTerrNames["array[" + i + "]"] = terrainObject["terrainFile"];

                    string terrainFilePath = pInvokes.Util.makeRelativePath(pInvokes.Util.filePath(terrainObject["terrainFile"]), pInvokes.Util.getMainDotCsDir());
                    string terrainFileName = pInvokes.Util.fileName(terrainObject["terrainFile"]);

                    // Workaround to have terrains created in an unsaved "New Level..." mission
                    // moved to the correct place.

                    if (EditorGui["saveAs"].AsBool() && terrainFilePath == "tools/art/terrains")
                        terrainFilePath = "art/terrains";

                    // Try and follow the existing naming convention.
                    // If we can't, use systematic terrain file names.
                    if (pInvokes.Util.strstr(terrainFileName, oldMissionName) >= 0)
                        terrainFileName = pInvokes.Util.strreplace(terrainFileName, oldMissionName, newMissionName);
                    else
                        terrainFileName = newMissionName + "_" + i + ".ter";

                    string newTerrainFile = terrainFilePath + "/" + terrainFileName;

                    if (!pInvokes.Util.isWriteableFileName(newTerrainFile))
                        {
                        if (pInvokes.Util.messageBox("Error", "Terrain file \"" + newTerrainFile + "\" is read-only.  Continue?", "Ok", "Stop") == pInvokes.iGlobal["$MROk"])
                            continue;
                        else
                            {
                            copyTerrainsFailed = true;
                            break;
                            }
                        }

                    if (!terrainObject.save(newTerrainFile))
                        {
                        pInvokes.Util._error("Failed to save '" + newTerrainFile + "'");
                        copyTerrainsFailed = true;
                        break;
                        }

                    terrainObject["terrainFile"] = newTerrainFile;
                    }

                ETerrainEditor.isDirty = false;

                // Save the mission.
                if (copyTerrainsFailed || !EditorSaveMission())
                    {
                    // It failed, so restore the mission and terrain filenames.

                    pInvokes.sGlobal["$Server::MissionFile"] = saveMissionFile;

                    pInvokes.Util.initContainerTypeSearch(pInvokes.uGlobal["$TypeMasks::TerrainObjectType"], false);
                    for (int i = 0;; i++)
                        {
                        TerrainBlock terrainObject = pInvokes.Util.containerSearchNext(false);
                        if (terrainObject == null)
                            break;

                        terrainObject["terrainFile"] = savedTerrNames["array[" + i + "]"];
                        }
                    }

                savedTerrNames.delete();
                }
            else
                EditorSaveMissionMenuDisableSave();
        }

        [ConsoleInteraction]
        public static void EditorOpenMission(string filename)
        {
            Settings EditorSettings = "EditorSettings";
            editor Editor = "Editor";
            GuiChunkedBitmapCtrl LoadingGui = "LoadingGui";
            EditorGui EditorGui = "EditorGui";
            SimSet MissionCleanup = "MissionCleanup";

            if (EditorIsDirty() && !pInvokes.Util.isWebDemo())
                {
                // "EditorSaveBeforeLoad();", "getLoadFilename(\"*.mis\", \"EditorDoLoadMission\");"
                if (pInvokes.Util.messageBox("Mission Modified", "Would you like to save changes to the current mission \"" + pInvokes.sGlobal["$Server::MissionFile"] + "\" before opening a new mission?", "SaveDontSave", "Question") == pInvokes.iGlobal["$MROk"])
                    {
                    if (!EditorSaveMission())
                        return;
                    }
                }

            if (filename == "")
                {
                OpenFileDialog ofd = new OpenFileDialog {Filter = pInvokes.sGlobal["$Pref::WorldEditor::FileSpec"], InitialDirectory = EditorSettings.value("LevelInformation/levelsDirectory"), CheckFileExists = true, Multiselect = false};

                DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

                switch (dr)
                    {
                        case DialogResult.OK:
                            filename = Dialogs.GetForwardSlashFile(ofd.FileName);
                            // Immediately override/set the levelsDirectory
                            EditorSettings.setValue("LevelInformation/levelsDirectory", pInvokes.console.Call("collapseFilename", new string[] {pInvokes.Util.filePath(filename)}));
                            break;
                        case DialogResult.Abort:
                        case DialogResult.Ignore:
                        case DialogResult.No:
                        case DialogResult.Cancel:
                        case DialogResult.None:
                            return;
                    }
                }

            // close the current editor, it will get cleaned up by MissionCleanup
            if (Editor.isObject())
                Editor.close(LoadingGui);

            EditorClearDirty();

            // If we haven't yet connnected, create a server now.
            // Otherwise just load the mission.

            if (!pInvokes.bGlobal["$missionRunning"])
                {
                pInvokes.Util.activatePackage("BootEditor");
                chooseLevelDlg.StartLevel(filename, "");
                }
            else
                {
                missionLoad.loadMission(filename, true);

                pInvokes.Util.pushInstantGroup();

                // recreate and open the editor
                //Editor::create();
                pInvokes.console.Call("Editor_Create");
                MissionCleanup.add(Editor);
                MissionCleanup.add(Editor.getUndoManager());
                EditorGui["loadingMission"] = true.AsString();
                Editor.open();

                pInvokes.Util.popInstantGroup();
                }
        }

        [ConsoleInteraction]
        public static void EditorExportToCollada()
        {
            EditorGui EditorGui = "EditorGui";
            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";
            ShapeEditor.gui.CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            EWorldEditor EWorldEditor = "EWorldEditor";

            if (!pInvokes.bGlobal["$Pref::disableSaving"] && !pInvokes.Util.isWebDemo())
                {
                SaveFileDialog sfd = new SaveFileDialog {Filter = @"COLLADA Files (*.dae)|*.dae", InitialDirectory = pInvokes.sGlobal["$Pref::WorldEditor::LastPath"], FileName = "", OverwritePrompt = true,};

                string exportFile = "";

                DialogResult dr = Dialogs.SaveFileDialog(ref sfd);

                switch (dr)
                    {
                        case DialogResult.OK:
                            exportFile = Dialogs.GetForwardSlashFile(sfd.FileName);
                            pInvokes.sGlobal["$Pref::WorldEditor::LastPath"] = pInvokes.Util.filePath(exportFile);
                            break;
                        case DialogResult.Abort:
                        case DialogResult.Ignore:
                        case DialogResult.No:
                        case DialogResult.Cancel:
                        case DialogResult.None:
                            return;
                    }

                if (pInvokes.Util.fileExt(exportFile) != ".dae")
                    exportFile = exportFile + ".dae";

                if (EditorGui.currentEditor.getId() == ShapeEditorPlugin.getId())
                    ShapeEdShapeView.exportToCollada(exportFile);
                else
                    EWorldEditor.colladaExportSelection(exportFile);
                }
        }

        [ConsoleInteraction]
        public static void EditorMakePrefab()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";

            // Should this be protected or not?
            if (!pInvokes.bGlobal["$Pref::disableSaving"] && !pInvokes.Util.isWebDemo())
                {
                SaveFileDialog sfd = new SaveFileDialog {Filter = @"Prefab Files (*.prefab)|*.prefab", InitialDirectory = pInvokes.sGlobal["$Pref::WorldEditor::LastPath"], FileName = "", OverwritePrompt = true,};

                string saveFile = "";

                DialogResult dr = Dialogs.SaveFileDialog(ref sfd);

                switch (dr)
                    {
                        case DialogResult.OK:
                            saveFile = Dialogs.GetForwardSlashFile(sfd.FileName);
                            pInvokes.sGlobal["$Pref::WorldEditor::LastPath"] = pInvokes.Util.filePath(saveFile);
                            break;
                        case DialogResult.Abort:
                        case DialogResult.Ignore:
                        case DialogResult.No:
                        case DialogResult.Cancel:
                        case DialogResult.None:
                            return;
                    }

                if (pInvokes.Util.fileExt(saveFile) != ".prefab")
                    saveFile = saveFile + ".prefab";

                EWorldEditor.makeSelectionPrefab(saveFile);

                EditorTree.buildVisibleTree(true);
                Creator.CreatorPopupMenu CreatorPopupMenu = "CreatorPopupMenu";
                CreatorPopupMenu.setSelected(CreatorPopupMenu.getSelected());
                }
        }

        [ConsoleInteraction]
        public static void EditorExplodePrefab()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";

            //echo( "EditorExplodePrefab()" );  
            EWorldEditor.explodeSelectedPrefab();
            EditorTree.buildVisibleTree(true);
        }

        [ConsoleInteraction]
        public static void EditorMount()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            pInvokes.Util._echo("EditorMount");

            int size = EWorldEditor.getSelectionSize();
            if (size != 2)
                return;

            SimObject a = EWorldEditor.getSelectedObject(0);
            SimObject b = EWorldEditor.getSelectedObject(1);

            //a.mountObject( b, 0 );
            EWorldEditor.mountRelative(a, b);
        }

        [ConsoleInteraction]
        public static void EditorUnmount()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            pInvokes.Util._echo("EditorUnmount");

            SimObject obj = EWorldEditor.getSelectedObject(0);
            obj.call("unmount");
        }

        [ConsoleInteraction]
        public static void EditorMenuEditDelete()
        {
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.currentEditor.isObject())
                EditorGui.currentEditor.handleDelete();
        }

        [ConsoleInteraction]
        public static void EditorMenuEditDeselect()
        {
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.currentEditor.isObject())
                EditorGui.currentEditor.handleDeselect();
        }

        [ConsoleInteraction]
        public static void EditorMenuEditCut()
        {
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.currentEditor.isObject())
                EditorGui.currentEditor.handleCut();
        }

        [ConsoleInteraction]
        public static void EditorMenuEditCopy()
        {
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.currentEditor.isObject())
                EditorGui.currentEditor.handleCopy();
        }

        [ConsoleInteraction]
        public static void EditorMenuEditPaste()
        {
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.currentEditor.isObject())
                EditorGui.currentEditor.handlePaste();
        }

        [TypeConverter(typeof (EditorAlignBoundsMenu))]
        public class EditorAlignBoundsMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                EWorldEditor EWorldEditor = "EWorldEditor";

                // Have the editor align all selected objects by the selected bounds.
                EWorldEditor.alignByBounds(pInvokes.Util.getField(this["item[" + id + "]"], 2).AsInt());

                return true;
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                // Allow the parent to set the menu's default state
                base.setupDefaultState();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorAlignBoundsMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorAlignBoundsMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorAlignBoundsMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorAlignBoundsMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorAlignBoundsMenu) Omni.self.getSimObject(simobjectid, typeof (EditorAlignBoundsMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorAlignBoundsMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorAlignBoundsMenu(int simobjectid)
            {
                return (EditorAlignBoundsMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorAlignBoundsMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorAlignBoundsMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorAlignBoundsMenu(uint simobjectid)
            {
                return (EditorAlignBoundsMenu) Omni.self.getSimObject(simobjectid, typeof (EditorAlignBoundsMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorAlignCenterMenu))]
        public class EditorAlignCenterMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                EWorldEditor EWorldEditor = "EWorldEditor";

                // Have the editor align all selected objects by the selected axis.
                EWorldEditor.alignByAxis(pInvokes.Util.getField(this["item[" + id + "]"], 2).AsInt());

                return true;
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                // Allow the parent to set the menu's default state
                base.setupDefaultState();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorAlignCenterMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorAlignCenterMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorAlignCenterMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorAlignCenterMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorAlignCenterMenu) Omni.self.getSimObject(simobjectid, typeof (EditorAlignCenterMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorAlignCenterMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorAlignCenterMenu(int simobjectid)
            {
                return (EditorAlignCenterMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorAlignCenterMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorAlignCenterMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorAlignCenterMenu(uint simobjectid)
            {
                return (EditorAlignCenterMenu) Omni.self.getSimObject(simobjectid, typeof (EditorAlignCenterMenu));
            }

            #endregion
        }

        //////////////////////////////////////////////////////////////////////////
        // File Menu Handlers
        //////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////
        // Camera Menu Handler
        //////////////////////////////////////////////////////////////////////////

        [TypeConverter(typeof (EditorCameraMenu))]
        public class EditorCameraMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                if (id == "0" || id == "1")
                    {
                    // Handle the Free Camera/Orbit Camera toggle
                    this.checkRadioItem(0, 1, id.AsInt());
                    }

                return base.onSelectItem(id, text);
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                // Set the Free Camera/Orbit Camera check marks
                this.checkRadioItem(0, 1, 0);
                base.setupDefaultState();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorCameraMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorCameraMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorCameraMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorCameraMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorCameraMenu) Omni.self.getSimObject(simobjectid, typeof (EditorCameraMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorCameraMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorCameraMenu(int simobjectid)
            {
                return (EditorCameraMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorCameraMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorCameraMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorCameraMenu(uint simobjectid)
            {
                return (EditorCameraMenu) Omni.self.getSimObject(simobjectid, typeof (EditorCameraMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorCameraSpeedMenu))]
        public class EditorCameraSpeedMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                EWorldEditor.EWorldEditorCameraSpeed EWorldEditorCameraSpeed = "EWorldEditorCameraSpeed";
                EditorGui.CameraSpeedDropdownCtrlContainer CameraSpeedDropdownCtrlContainer = "CameraSpeedDropdownCtrlContainer";

                GuiSliderCtrl Slider = CameraSpeedDropdownCtrlContainer.FOT("slider");

                // Grab and set speed
                float speed = pInvokes.Util.getField(this["item[" + id + "]"], 2).AsFloat();
                pInvokes.fGlobal["$Camera::movementSpeed"] = speed;

                // Update Editor
                this.checkRadioItem(0, 6, id.AsInt());

                // Update Toolbar TextEdit
                EWorldEditorCameraSpeed.setText(pInvokes.fGlobal["$Camera::movementSpeed"].AsString());

                // Update Toolbar Slider
                Slider.setValue(pInvokes.fGlobal["$Camera::movementSpeed"].AsString());

                return true;
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                EditorGui EditorGui = "EditorGui";
                Settings EditorSettings = "EditorSettings";
                EWorldEditor.EWorldEditorCameraSpeed EWorldEditorCameraSpeed = "EWorldEditorCameraSpeed";
                EditorGui.CameraSpeedDropdownCtrlContainer CameraSpeedDropdownCtrlContainer = "CameraSpeedDropdownCtrlContainer";

                GuiSliderCtrl Slider = CameraSpeedDropdownCtrlContainer.FOT("slider");

                // Setup camera speed gui's. Both menu and editorgui
                this.setupGuiControls();

                //Grab and set speed
                string defaultSpeed = EditorSettings.value("LevelInformation/levels/" + EditorGui["levelName"] + "/cameraSpeed");
                if (defaultSpeed == "")
                    {
                    // Update Editor with default speed
                    defaultSpeed = "25";
                    }
                pInvokes.fGlobal["$Camera::movementSpeed"] = defaultSpeed.AsFloat();

                // Update Toolbar TextEdit
                EWorldEditorCameraSpeed.setText(defaultSpeed);

                // Update Toolbar Slider
                Slider.setValue(defaultSpeed);

                base.setupDefaultState();
            }

            [ConsoleInteraction]
            public void setupGuiControls()
            {
                EditorGui EditorGui = "EditorGui";
                Settings EditorSettings = "EditorSettings";
                EditorGui.CameraSpeedDropdownCtrlContainer CameraSpeedDropdownCtrlContainer = "CameraSpeedDropdownCtrlContainer";

                GuiSliderCtrl Slider = CameraSpeedDropdownCtrlContainer.FOT("slider");

                // Default levelInfo params
                float minSpeed = 5;
                float maxSpeed = 200;

                float speedA = EditorSettings.value("LevelInformation/levels/" + EditorGui["levelName"] + "/cameraSpeedMin").AsFloat();
                float speedB = EditorSettings.value("LevelInformation/levels/" + EditorGui["levelName"] + "/cameraSpeedMax").AsFloat();
                if (speedA < speedB)
                    {
                    if (speedA == 0.0)
                        {
                        if (speedB > 1)
                            minSpeed = 1;
                        else
                            minSpeed = (float) 0.1;
                        }
                    else
                        minSpeed = speedA;

                    maxSpeed = speedB;
                    }

                // Set up the camera speed items
                float inc = ((maxSpeed - minSpeed)/(this.getItemCount() - 1));
                for (int i = 0; i < this.getItemCount(); i++)
                    this["item[" + i + "]"] = pInvokes.Util.setField(this["item[" + i + "]"], 2, (minSpeed + (inc*i)).AsString());

                // Set up min/max camera slider range
                Slider.range = (minSpeed + " " + maxSpeed).AsPoint2F();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorCameraSpeedMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorCameraSpeedMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorCameraSpeedMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorCameraSpeedMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorCameraSpeedMenu) Omni.self.getSimObject(simobjectid, typeof (EditorCameraSpeedMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorCameraSpeedMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorCameraSpeedMenu(int simobjectid)
            {
                return (EditorCameraSpeedMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorCameraSpeedMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorCameraSpeedMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorCameraSpeedMenu(uint simobjectid)
            {
                return (EditorCameraSpeedMenu) Omni.self.getSimObject(simobjectid, typeof (EditorCameraSpeedMenu));
            }

            #endregion
        }

        //////////////////////////////////////////////////////////////////////////
        // World Menu Handler Object Menu
        //////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////////////

        [TypeConverter(typeof (EditorDropTypeMenu))]
        public class EditorDropTypeMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                EWorldEditor EWorldEditor = "EWorldEditor";

                // This sets up which drop script function to use when
                // a drop type is selected in the menu.
                EWorldEditor.dropType = pInvokes.Util.getField(this["item[" + id + "]"], 2);

                this.checkRadioItem(0, (this.getItemCount() - 1), id.AsInt());

                return true;
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                EWorldEditor EWorldEditor = "EWorldEditor";

                // Check the radio item for the currently set drop type.

                int numItems = this.getItemCount();

                int dropTypeIndex = 0;
                for (; dropTypeIndex < numItems; dropTypeIndex++)
                    {
                    if (pInvokes.Util.getField(this["item[" + dropTypeIndex + "]"], 2) == EWorldEditor["dropType"])
                        break;
                    }

                // Default to screenCenter if we didn't match anything.        
                if (dropTypeIndex > (numItems - 1))
                    dropTypeIndex = 4;

                this.checkRadioItem(0, (numItems - 1), dropTypeIndex);

                base.setupDefaultState();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorDropTypeMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorDropTypeMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorDropTypeMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorDropTypeMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorDropTypeMenu) Omni.self.getSimObject(simobjectid, typeof (EditorDropTypeMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorDropTypeMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorDropTypeMenu(int simobjectid)
            {
                return (EditorDropTypeMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorDropTypeMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorDropTypeMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorDropTypeMenu(uint simobjectid)
            {
                return (EditorDropTypeMenu) Omni.self.getSimObject(simobjectid, typeof (EditorDropTypeMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorEditMenu))]
        public class EditorEditMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override void onMenuSelect()
            {
                editor Editor = "Editor";
                EditorGui EditorGui = "EditorGui";

                // UndoManager is in charge of enabling or disabling the undo/redo items.
                Editor.getUndoManager().call("updateUndoMenu", this);

                // SICKHEAD: It a perfect world we would abstract 
                // cut/copy/paste with a generic selection object 
                // which would know how to process itself.         

                // Give the active editor a chance at fixing up
                // the state of the edit menu.
                // Do we really need this check here?
                if (EditorGui.currentEditor.isObject())
                    EditorGui.currentEditor.onEditMenuSelect(this);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorEditMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorEditMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorEditMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorEditMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorEditMenu) Omni.self.getSimObject(simobjectid, typeof (EditorEditMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorEditMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorEditMenu(int simobjectid)
            {
                return (EditorEditMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorEditMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorEditMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorEditMenu(uint simobjectid)
            {
                return (EditorEditMenu) Omni.self.getSimObject(simobjectid, typeof (EditorEditMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorFileMenu))]
        public class EditorFileMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override void onMenuSelect()
            {
                // don't do this since it won't exist if this is a "demo"
                if (!Util.isWebDemo())
                    this.enableItem(2, EditorIsDirty());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorFileMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorFileMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorFileMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorFileMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorFileMenu) Omni.self.getSimObject(simobjectid, typeof (EditorFileMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorFileMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorFileMenu(int simobjectid)
            {
                return (EditorFileMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorFileMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorFileMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorFileMenu(uint simobjectid)
            {
                return (EditorFileMenu) Omni.self.getSimObject(simobjectid, typeof (EditorFileMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorFreeCameraTypeMenu))]
        public class EditorFreeCameraTypeMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                // Handle the camera type radio
                this.checkRadioItem(0, 2, id.AsInt());

                return base.onSelectItem(id, text);
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                // Set the camera type check marks
                this.checkRadioItem(0, 2, 0);
                base.setupDefaultState();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorFreeCameraTypeMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorFreeCameraTypeMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorFreeCameraTypeMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorFreeCameraTypeMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorFreeCameraTypeMenu) Omni.self.getSimObject(simobjectid, typeof (EditorFreeCameraTypeMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorFreeCameraTypeMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorFreeCameraTypeMenu(int simobjectid)
            {
                return (EditorFreeCameraTypeMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorFreeCameraTypeMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorFreeCameraTypeMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorFreeCameraTypeMenu(uint simobjectid)
            {
                return (EditorFreeCameraTypeMenu) Omni.self.getSimObject(simobjectid, typeof (EditorFreeCameraTypeMenu));
            }

            #endregion
        }

        //////////////////////////////////////////////////////////////////////////

        [TypeConverter(typeof (EditorHelpMenu))]
        public class EditorHelpMenu : MenuBuilder
        {
            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorHelpMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorHelpMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorHelpMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorHelpMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorHelpMenu) Omni.self.getSimObject(simobjectid, typeof (EditorHelpMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorHelpMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorHelpMenu(int simobjectid)
            {
                return (EditorHelpMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorHelpMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorHelpMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorHelpMenu(uint simobjectid)
            {
                return (EditorHelpMenu) Omni.self.getSimObject(simobjectid, typeof (EditorHelpMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorPlayerCameraTypeMenu))]
        public class EditorPlayerCameraTypeMenu : MenuBuilder
        {
            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorPlayerCameraTypeMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorPlayerCameraTypeMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorPlayerCameraTypeMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorPlayerCameraTypeMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorPlayerCameraTypeMenu) Omni.self.getSimObject(simobjectid, typeof (EditorPlayerCameraTypeMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorPlayerCameraTypeMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorPlayerCameraTypeMenu(int simobjectid)
            {
                return (EditorPlayerCameraTypeMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorPlayerCameraTypeMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorPlayerCameraTypeMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorPlayerCameraTypeMenu(uint simobjectid)
            {
                return (EditorPlayerCameraTypeMenu) Omni.self.getSimObject(simobjectid, typeof (EditorPlayerCameraTypeMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorToolsMenu))]
        public class EditorToolsMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override bool onSelectItem(string id, string text)
            {
                EditorGui EditorGui = "EditorGui";

                string toolName = pInvokes.Util.getField(this["item[" + id + "]"], 2);

                //In the torquescript they passed a local variable called %paletteName as the second parameter.
                //Well, in reality it's expecting a bool, so an unitialized variable is false by default, so they were sending false
                //but it was misleading as hell since unless you coded the other part you had no idea what the variable was used for.
                //Really GG?  no one could clean up this code?
                EditorGui.setEditor(toolName, false);

                this.checkRadioItem(0, this.getItemCount(), id.AsInt());
                return true;
            }

            [ConsoleInteraction]
            public override void setupDefaultState()
            {
                base.setupDefaultState();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorToolsMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorToolsMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorToolsMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorToolsMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorToolsMenu) Omni.self.getSimObject(simobjectid, typeof (EditorToolsMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorToolsMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorToolsMenu(int simobjectid)
            {
                return (EditorToolsMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorToolsMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorToolsMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorToolsMenu(uint simobjectid)
            {
                return (EditorToolsMenu) Omni.self.getSimObject(simobjectid, typeof (EditorToolsMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorViewMenu))]
        public class EditorViewMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override void onMenuSelect()
            {
                EWorldEditor EWorldEditor = "EWorldEditor";
                this.checkItem(1, EWorldEditor.renderOrthoGrid);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorViewMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorViewMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorViewMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorViewMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorViewMenu) Omni.self.getSimObject(simobjectid, typeof (EditorViewMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorViewMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorViewMenu(int simobjectid)
            {
                return (EditorViewMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorViewMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorViewMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorViewMenu(uint simobjectid)
            {
                return (EditorViewMenu) Omni.self.getSimObject(simobjectid, typeof (EditorViewMenu));
            }

            #endregion
        }

        [TypeConverter(typeof (EditorWorldMenu))]
        public class EditorWorldMenu : MenuBuilder
        {
            [ConsoleInteraction]
            public override void onMenuSelect()
            {
                EWorldEditor EWorldEditor = "EWorldEditor";

                int selSize = EWorldEditor.getSelectionSize();
                int lockCount = EWorldEditor.getSelectionLockCount();
                int hideCount = EWorldEditor.getSelectionHiddenCount();

                this.enableItem(0, (lockCount < selSize)); // Lock Selection
                this.enableItem(1, (lockCount > 0)); // Unlock Selection
                this.enableItem(3, (hideCount < selSize)); // Hide Selection
                this.enableItem(4, (hideCount > 0)); // Show Selection
                this.enableItem(6, (selSize > 1 && lockCount == 0)); // Align bounds
                this.enableItem(7, (selSize > 1 && lockCount == 0)); // Align center
                this.enableItem(9, (selSize > 0 && lockCount == 0)); // Reset Transforms
                this.enableItem(10, (selSize > 0 && lockCount == 0)); // Reset Selected Rotation
                this.enableItem(11, (selSize > 0 && lockCount == 0)); // Reset Selected Scale
                this.enableItem(12, (selSize > 0 && lockCount == 0)); // Transform Selection
                this.enableItem(14, (selSize > 0 && lockCount == 0)); // Drop Selection

                this.enableItem(17, (selSize > 0)); // Make Prefab
                this.enableItem(18, (selSize > 0)); // Explode Prefab   

                this.enableItem(20, (selSize > 1)); // Mount
                this.enableItem(21, (selSize > 0)); // Unmount
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorWorldMenu ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public override bool Equals(object obj)
            {
                return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(EditorWorldMenu ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(EditorWorldMenu ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorWorldMenu(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EditorWorldMenu) Omni.self.getSimObject(simobjectid, typeof (EditorWorldMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorWorldMenu ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorWorldMenu(int simobjectid)
            {
                return (EditorWorldMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorWorldMenu));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorWorldMenu ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorWorldMenu(uint simobjectid)
            {
                return (EditorWorldMenu) Omni.self.getSimObject(simobjectid, typeof (EditorWorldMenu));
            }

            #endregion
        }

        //////////////////////////////////////////////////////////////////////////
    }
}