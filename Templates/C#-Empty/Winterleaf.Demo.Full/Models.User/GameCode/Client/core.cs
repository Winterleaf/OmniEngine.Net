#region

using System;
using System.Collections.Generic;
using System.IO;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Enviroment;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Misc;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class core
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initializeCore()
            {
            
            if (omni.bGlobal["$coreInitialized"])
                return;

            ActionMap GlobalActionMap = "GlobalActionMap";
            GlobalActionMap.bind("keyboard", "tilde", "toggleConsole");
            GlobalActionMap.bind("keyboard", "alt tilde", "ShowNewTools");
            GlobalActionMap.bind("keyboard", "ctrl p", "doScreenShot");
            GlobalActionMap.bindCmd("keyboard", "alt enter", "Canvas.attemptFullscreenToggle();", "");
            GlobalActionMap.bindCmd("keyboard", "alt k", "cls();", "");

            audio.initialize();
            canvas.initialize();
            GuiCanvas.initialize();
            //omni.Util.exec("core/scripts/client/cursor.cs", false, false);
            //omni.Util.exec("core/scripts/client/persistenceManagerTest.cs", false, false);

            // Content.
            omni.Util.exec("core/art/gui/profiles.cs", false, false);
            //omni.Util.exec("core/scripts/gui/cursors.cs", false, false);
            cursor.initialize();

            audioEnviroments.initialize();
            audioDescriptions.initialize();
            audioStates.initialize();
            audioAmbiences.initialize();


            // Input devices
            // omni.Util.exec("core/scripts/client/oculusVR.cs", false, false);

            omni.Util.setRandomSeed((DateTime.Now.Millisecond + 1)*(DateTime.Now.Second + 1));

            // Set up networking.
            omni.Util.setNetPort(0);

            // Initialize the canvas.
            canvas.initializeCanvas();

            // Start processing file change events. 
            omni.Util.startFileChangeNotifications();

            // Core Guis.

            //omni.Util.exec("core/art/gui/console.gui", false, false);
            ConsoleDlg.initialize();


            //omni.Util.exec("core/art/gui/consoleVarDlg.gui", false, false);
            ConsoleVarDlg.initialize();
            omni.Util.exec("core/art/gui/netGraphGui.gui", false, false);

            // Gui Helper Scripts.
            //omni.Util.exec("core/scripts/gui/help.cs", false, false);

            // Random Scripts.
            //omni.Util.exec("core/scripts/client/screenshot.cs", false, false);
            screenshot.initialize();
            //omni.Util.exec("core/scripts/client/helperfuncs.cs", false, false);
            // Client scripts
            metrics.initialize();
            //omni.Util.exec("core/scripts/client/recordings.cs", false, false);
            centerPrint.initialize();
            loadCoreMaterials();
            commonMaterialData.intialize();
            shaders.initialize();
            materials.initialize();

            terrainBlock.initialize();
            water.initialize();
            scatterSky.initialize();
            clouds.initialize();

            // Initialize all core post effects.   
            postFX.initialize();
            postFX.initPostEffects();


            // Initialize the post effect manager.
            postFXManager.createGui();
            ((postFXManager) "PostFXManager").settingsApplyDefaultPreset();
            ((GuiCanvas) "Canvas").setCursor("DefaultCursor");

            //Need to call this function through the console because loadKeyBindings is part of a packaged used in tools
            omni.console.Call("loadKeybindings");

            omni.bGlobal["$coreInitialized"] = true;
            }

        [ConsoleInteraction(true)]
        public static void loadCoreMaterials()
            {
            List<string> filesloaded = new List<string>();
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "core", "materials.cs.dso",
                SearchOption.AllDirectories);

            int startposition = AppDomain.CurrentDomain.BaseDirectory.Length;
            foreach (string file in files)
                {
                if (File.Exists(file.Substring(0, file.Length - 4)))
                    {
                    omni.Util.exec(file.Substring(startposition, file.Length - 4).Replace("\\", "/"), false, false);
                    filesloaded.Add(file.Substring(startposition, file.Length - 4));
                    }
                else
                    {
                    omni.Util.exec(file.Substring(startposition).Replace("\\", "/"), false, false);
                    filesloaded.Add(file.Substring(startposition));
                    }
                }

            files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "core", "materials.cs",
                SearchOption.AllDirectories);
            foreach (string file in files)
                {
                if (!filesloaded.Contains(file.Substring(startposition)))
                    {
                    omni.Util.exec(file.Substring(startposition).Replace("\\", "/"), false, false);
                    }
                }
            }

        /// <summary>
        /// //---------------------------------------------------------------------------------------------
        /// shutdownCore
        /// Shuts down core game functionality.
        /// </summary>
        [ConsoleInteraction(true)]
        public static void shutdownCore()
            {
            // Stop file change events.
            omni.Util.stopFileChangeNotifications();
            audio.sfxShutdown();
            }

        /// <summary>
        /// Suppose to save all of the keybindings, but I cannot find in any of the code where this function
        /// is referenced or used.
        /// </summary>
        [ConsoleInteraction(true)]
        public static void dumpKeybindings()
            {
            for (int i = 0; i < omni.iGlobal["$keybindCount"]; i++)
                {
                if (omni.sGlobal["$keybindMap[" + i + "]"].isObject())
                    {
                    // Save and delete.
                    ModelBase t = omni.sGlobal["$keybindMap[" + i + "]"];
                    Console.WriteLine(t._ID);
                    omni.console.Call(omni.sGlobal["$keybindMap[" + i + "]"], "save",
                        new[] {omni.Util.getPrefsPath("bind.cs"), i == 0 ? "false" : "true"});
                    omni.sGlobal["$keybindMap[" + i + "]"].delete();
                    }
                }
            }

        [ConsoleInteraction(true)]
        public static void handleEscape()
            {
            if ("EditorGui".isObject())
                {
                if (((GuiCanvas) "Canvas").getContent() == ((ModelBase) "EditorGui")._iID)
                    {
                    omni.console.Call("EditorGui", "handleEscape");
                    return;
                    }
                else if (omni.console.Call("EditorIsDirty").AsBool())
                    {
                    messageBox.MessageBoxYesNoCancel("Level Modified",
                        "Level has been modified in the Editor. Save?", "EditorDoExitMission(1);",
                        "EditorDoExitMission();", "");
                    return;
                    }
                }
            if ("GuiEditor".isObject())
                {
                if (((GuiEditorGui.GuiEditor) "GuiEditor").isAwake())
                    {
                    ((GuiEditCanvas) "GuiEditCanvas").quit();
                    return;
                    }
                }

            if (((GameTSCtrl) "PlayGui").isAwake())
                omni.console.Call("escapeFromGame");
            }

        [ConsoleInteraction(true)]
        public static void reloadCoreMaterials()
            {
            omni.Util.reloadTextures();
            loadCoreMaterials();
            omni.Util.reInitMaterials();
            }

        /// <summary>
        /// Load all material.cs files
        /// </summary>
        public static void loadMaterials()
            {
            List<string> filesloaded = new List<string>();
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "materials.cs.dso",SearchOption.AllDirectories);

            int startposition = AppDomain.CurrentDomain.BaseDirectory.Length;
            foreach (string file in files)
                {
                if (File.Exists(file.Substring(0, file.Length - 4)))
                    {
                    omni.Util.exec(file.Substring(startposition, file.Length - 4).Replace("\\", "/"), false, false);
                    filesloaded.Add(file.Substring(startposition, file.Length - 4));
                    }
                else
                    {
                    omni.Util.exec(file.Substring(startposition).Replace("\\", "/"), false, false);
                    filesloaded.Add(file.Substring(startposition));
                    }
                }

            files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "materials.cs",SearchOption.AllDirectories);
            foreach (string file in files)
                {
                if (!filesloaded.Contains(file.Substring(startposition)))
                    {
                    omni.Util.exec(file.Substring(startposition).Replace("\\", "/"), false, false);
                    }
                }

            //in the torquescript version they do yet another pass against files in the path/materialEditor folder which
            //to me seems redundant since it would have been already loaded from the above code.
            //I sure hope I'm not missing something here.
            }

        [ConsoleInteraction(true)]
        public static void reloadMaterials()
            {
            omni.Util.reloadTextures();
            loadMaterials();
            omni.Util.reInitMaterials();
            }
        }
    }