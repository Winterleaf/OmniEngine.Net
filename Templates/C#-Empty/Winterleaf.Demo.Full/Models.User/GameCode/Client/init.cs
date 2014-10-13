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

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.Content_Browser;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    public class init
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true)]
        public static void initClient()
        {
            omni.console.print("\n--------- Initializing " + omni.sGlobal["$appName"] + ": Client Scripts ---------");

            // Make sure this variable reflects the correct state.
            omni.bGlobal["$Server::Dedicated"] = false;

            // Game information used to query the master server
            omni.sGlobal["$Client::GameTypeQuery"] = omni.sGlobal["$appName"];
            omni.sGlobal["$Client::MissionTypeQuery"] = "Any";

            // These should be game specific GuiProfiles.  Custom profiles are saved out
            // from the Gui Editor.  Either of these may override any that already exist.

            defaultGameProfiles.Initialize();
            customProfiles.Initialize();
            // The common module provides basic client functionality
            client.initBaseClient();

            // Use our prefs to configure our Canvas/Window
            canvas.configureCanvas();

            // Load up the Game GUIs
            //omni.Util.exec("art/gui/PlayGui.gui", false, false);
            playGui.initialize();

            //omni.Util.exec("art/gui/playerList.gui", false, false);

            //omni.Util.exec("art/gui/hudlessGui.gui", false, false);
            hudlessGui.initialize();

            // Load up the shell GUIs

            //omni.Util.exec("art/gui/mainMenuGui.gui", false, false);
            mainMenuGui.initialize();

            //omni.Util.exec("art/gui/joinServerDlg.gui", false, false);
            JoinServerDlg.initialize();

            //omni.Util.exec("art/gui/endGameGui.gui", false, false);
            endGameGui.initialize();

            //omni.Util.exec("art/gui/StartupGui.gui", false, false);
            startupGui.initialize();

            //omni.Util.exec("art/gui/chooseLevelDlg.gui", false, false);
            //chooseLevelDlg.Initialize();

            //omni.Util.exec("art/gui/loadingGui.gui", false, false);
            loadingGui.initialize();

            //omni.Util.exec("art/gui/optionsDlg.gui", false, false);
            OptionsDlg.initialize();

            ToolsDlg.initialize();

            CBObjectRenameCtrl.initialize();

            ContentBrowserGui.initialize();

            //omni.Util.exec("art/gui/remapDlg.gui", false, false);
            RemapDlg.initialize();

            //omni.Util.exec("scripts/gui/optionsDlg.cs", false, false);
            Misc.initialize();

            // Client scripts
            missionDownload.initialize();
            // Load useful Materials
            shaders.initialize_CustomShaders();

            // Default player key bindings
            defaultBind.initialize();

            if (omni.Util.isFile("scripts/client/config.cs"))
                omni.Util.exec("scripts/client/config.cs", false, false);

            //string[] files = Directory.GetFiles( System.IO.Path.Combine( AppDomain.CurrentDomain.BaseDirectory,@"art\gui"), "*.png", SearchOption.AllDirectories);
            //foreach (string file in files)
            //    {
            //    ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitMapCtrl", "");
            //    oc_Newobject1["Enabled"] = "1";
            //    oc_Newobject1["isContainer"] = "0";
            //    oc_Newobject1["Profile"] = "GuiDefaultProfile";
            //    oc_Newobject1["HorizSizing"] = "right";
            //    oc_Newobject1["VertSizing"] = "bottom";
            //    oc_Newobject1["position"] = "10 31";
            //    oc_Newobject1["Extent"] = "400 300";
            //    oc_Newobject1["MinExtent"] = "8 2";
            //    oc_Newobject1["canSave"] = "1";
            //    oc_Newobject1["Visible"] = "1";
            //    oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            //    oc_Newobject1["hovertime"] = "1000";
            //    oc_Newobject1["bitmap"] = file;
            //    oc_Newobject1["wrap"] = "0";
            //    oc_Newobject1.Create();
            //    }

            core.loadMaterials();

            // Really shouldn't be starting the networking unless we are
            // going to connect to a remote server, or host a multi-player
            // game.

            omni.Util.setNetPort(0, false);

            omni.console.Call("setDefaultFov", new[] {omni.sGlobal["$pref::Player::defaultFov"]});
            omni.console.Call("setZoomSpeed", new[] {omni.sGlobal["$pref::Player::zoomSpeed"]});
            audioData.initialize();

            // Start up the main menu... this is separated out into a
            // method for easier mod override

            if (omni.bGlobal["$startWorldEditor"] || omni.bGlobal["$startGUIEditor"])
                // Editor GUI's will start up in the primary main.cs once
                // engine is initialized.
                return;

            if (omni.sGlobal["$JoinGameAddress"] != "")
                {
                loadLoadingGui("loadLoadingGui");
                missionDownload.connect(omni.sGlobal["$JoinGameAddress"]);
                }
            else
                {
                // Otherwise go to the splash screen.
                ((GuiCanvas) "canvas").setCursor("DefaultCursor");
                startupGui.loadStartup();
                //omni.console.Call("loadStartup");
                }
        }

        [ConsoleInteraction(true)]
        public static void loadMainMenu()
        {
            // Startup the client with the Main menu...
            if ("MainMenuGui".isObject())
                ((GuiCanvas) "Canvas").setContent("MainMenuGui");

            ((GuiCanvas) "Canvas").setCursor("DefaultCursor");

            // first check if we have a level file to load

            if (omni.sGlobal["$levelToLoad"] != "")
                {
                string levelfile = "levels/";

                if (!omni.sGlobal["$levelToLoad"].EndsWith(".mis"))
                    levelfile += omni.sGlobal["$levelToLoad"] + ".mis";
                else
                    levelfile += omni.sGlobal["$levelToLoad"];
                // Clear out the $levelToLoad so we don't attempt to load the level again
                // later on.

                omni.sGlobal["$levelToLoad"] = "";

                string file = omni.Util.findFirstFile(levelfile, false);
                if (file != "")
                    server.createAndConnectToLocalServer("SinglePlayer", file);
                }
        }

        [ConsoleInteraction(true)]
        public static void loadLoadingGui(string displayText)
        {
            ((GuiCanvas) "Canvas").setContent("LoadingGui");
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");

            if (displayText != "")
                ((GuiTextCtrl) "LoadingProgressTxt").setValue(displayText);
            else
                ((GuiTextCtrl) "LoadingProgressTxt").setValue("WAITING FOR SERVER");

            ((GuiCanvas) "Canvas").repaint(0);
        }
    }
}