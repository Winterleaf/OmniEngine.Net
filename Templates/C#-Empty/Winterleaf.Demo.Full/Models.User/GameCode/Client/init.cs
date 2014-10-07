#region

using System;
using System.IO;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.ChooseLevel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.Content_Browser;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

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

            omni.Util.setNetPort(0,false);

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
                init.loadLoadingGui("loadLoadingGui");
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
                    Server.server.createAndConnectToLocalServer("SinglePlayer", file);
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