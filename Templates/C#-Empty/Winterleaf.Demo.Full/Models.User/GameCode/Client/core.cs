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

#region

using System;
using System.Collections.Generic;
using System.IO;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Enviroment;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Misc;
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
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "core", "materials.cs.dso", SearchOption.AllDirectories);

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

            files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "core", "materials.cs", SearchOption.AllDirectories);
            foreach (string file in files)
                {
                if (!filesloaded.Contains(file.Substring(startposition)))
                    omni.Util.exec(file.Substring(startposition).Replace("\\", "/"), false, false);
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
                    omni.console.Call(omni.sGlobal["$keybindMap[" + i + "]"], "save", new[] {omni.Util.getPrefsPath("bind.cs"), i == 0 ? "false" : "true"});
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
                    messageBox.MessageBoxYesNoCancel("Level Modified", "Level has been modified in the Editor. Save?", "EditorDoExitMission(1);", "EditorDoExitMission();", "");
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
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "materials.cs.dso", SearchOption.AllDirectories);

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

            files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "materials.cs", SearchOption.AllDirectories);
            foreach (string file in files)
                {
                if (!filesloaded.Contains(file.Substring(startposition)))
                    omni.Util.exec(file.Substring(startposition).Replace("\\", "/"), false, false);
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