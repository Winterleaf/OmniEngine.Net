#region

using System;
using System.Linq;
using System.Windows.Forms;
using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;


using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.GameCode
{
    /// <summary>
    /// This is a required file, replaces main.cs in the root directory
    /// </summary>
    ///

    public static class Main
    {
        /// <summary>
        /// Main entry point into the scripts.
        /// MANDITORY FUNCTION
        /// </summary>
        /// <param name="argc"></param>
        /// <param name="argv"></param>
        [ConsoleInteraction(true)]
        public static int main(int argc, string[] argv)
        {
            //pInvokes.Util._call("enableWinConsole", "true");
            //pInvokes.sGlobal["$test[1]"] = "test";
            //Console.WriteLine(pInvokes.sGlobal["$test[1]"]);

            //


            // Set the name of our application
            pInvokes.sGlobal["$appName"] = "Full";
            // The directory it is run from
            pInvokes.sGlobal["$defaultGame"] = "scripts";
            // Set profile directory
            pInvokes.sGlobal["$Pref::Video::ProfilePath"] = "core/profile";

            pInvokes.bGlobal["$displayHelp"] = false;

            pInvokes.bGlobal["$isDedicated"] = false;

            pInvokes.iGlobal["$dirCount"] = 2;

            pInvokes.sGlobal["$userDirs"] = pInvokes.sGlobal["$defaultGame"] + ";art;levels";


            mainParseArgs();

            // load tools scripts if we're a tool build
            //if (pInvokes.Util.isToolBuild() && !pInvokes.bGlobal["$isDedicated"])
            //    pInvokes.sGlobal["$userDirs"] = "tools;" + pInvokes.sGlobal["$userDirs"];

            // Parse the executable arguments with the standard
            // function from core/main.cs


            if (pInvokes.iGlobal["$dirCount"] == 0)
            {
                pInvokes.sGlobal["$userDirs"] = pInvokes.sGlobal["$defaultGame"];
                pInvokes.iGlobal["$dirCount"] = 1;
            }

            //-----------------------------------------------------------------------------
            // Display a splash window immediately to improve app responsiveness before
            // engine is initialized and main window created

            if (!pInvokes.bGlobal["$isDedicated"])
            {
                pInvokes.Util.displaySplashWindow("art/gui/pInvokes.bmp");
            }

            if (!pInvokes.bGlobal["$logModeSpecified"])
            {
                if (pInvokes.sGlobal["$platform"] != "xbox" && pInvokes.sGlobal["$platform"] != "xenon")
                    pInvokes.Util.setLogMode(6);
            }

            pInvokes.Util.nextToken("$userDirs", "currentMod", ";");

            pInvokes.console.print("--------- Loading DIRS ---------");


            /*Ok, so here is the deal.  Until the tools are converted to a OMNI toolset we need to allow support of
             * packages in some way.  Since packages require a base function and then override it we needed to
             * provide the basic torquescript functions for onStart,onExit,parseArgs.  Instead of putting any
             * code into them, we just put a call back to our C# function.
             *
             * So for example we defined a torquescript function onStart() it calls onMainStart() and onMainStart is wired via reflections
             * to the C# function event_onMainStart.  Thus we satisfy the requirements of packages, in which the base function
             * must exist outside of a package to be overriden by a package.  Therefore, since the Tools are still all in TorqueScript,
             * the Tools Package can now override onStart, onExit and parseArgs.
             *
             *
             * Pretty slick....
             */
            pInvokes.console.Eval(@"
                function onStart()
                    {
                    onMainStart();
                    }
                function onExit()
                    {
                    onMainExit();
                    }
                function parseArgs()
                    {
                    mainParseArgs();
                    }
                function loadKeybindings()
                    {
                    mainloadKeybindings();
                    }
                ");
            // GameConnection.initialize();
            SetConstantsForReferencingVideoResolutionPreference();


            loadDirs(pInvokes.sGlobal["$userDirs"]);

            //-----> Load tools here
            // Parse the command line arguments
            pInvokes.console.print("--------- Parsing Arguments ---------");

            mainParseArgs();

            if (pInvokes.bGlobal["$displayHelp"])
            {
                pInvokes.console.Call("enableWinConsole", new[] { "true" });
                displayHelp();
                //pInvokes.Util.quit();
                Main.Quit();
            }
            else
            {
                //due to the Tools, this must be called through the console.
                pInvokes.console.Call("onStart");
                //onStart();
                pInvokes.console.print("Engine initialized...");
                if (pInvokes.sGlobal["$platform"] == "xenon")
                {
                    const string mission = "levels//Empty Terrain.mis";
                    pInvokes.console.print("Xbox360 Autoloading level: '" + mission + "'");
                    string serverType = pInvokes.bGlobal["$pref::HostMultiPlayer"] ? "MultiPlayer" : "SinglePlayer";
                    Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.server.createAndConnectToLocalServer(serverType, mission);
                }
            }

            for (int i = 1; i < pInvokes.iGlobal["$Game::argc"]; i++)
            {
                if (!pInvokes.bGlobal["$argUsed[" + i + "]"])
                    if (pInvokes.sGlobal["$Game::argv[" + i + "]"].Trim() != "")
                        pInvokes.console.error("Error: Unknown command line argument: " +
                                           pInvokes.sGlobal["$Game::argv[" + i + "]"]);
            }

            GuiCanvas canvas = "Canvas";

            if (pInvokes.bGlobal["$startWorldEditor"])
            {
                canvas.setCursor("DefaultCursor");
                canvas.setContent("EditorChooseLevelGui");
            }
            else if (pInvokes.bGlobal["$startGUIEditor"])
            {
                canvas.setCursor("DefaultCursor");
                canvas.setContent("EditorChooseGUI");
            }


            return 1;
        }

        /// <summary>
        /// MANDITORY FUNCTION
        /// </summary>
        [ConsoleInteraction(true)]
        public static void Quit()
        {
            if (Omni.self.IsRunning)
                onMainExit();
        }

        /// <summary>
        /// MANDITORY FUNCTION
        /// </summary>
        [ConsoleInteraction(true)]
        public static void quitWithErrorMessage(string message)
        {
            MessageBox.Show(message, "Error");
            Omni.self.StopEngine();
        }

        [ConsoleInteraction(true)]
        public static void loadDir(string dir)
        {
            pushBack("$useDirs", dir, ";");
            if (!isScriptFile(dir + "/main.cs"))
                return;
            pInvokes.console.print("Calling " + dir + "/main.cs");
            pInvokes.Util.exec(dir + "/main.cs", false, false);
        }


        [ConsoleInteraction(true)]
        public static void onMainExit()
        {
            if (pInvokes.bGlobal["$Server::Dedicated"])
                Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.server.destroyServer();
            else
                pInvokes.console.Call("disconnect");

            pInvokes.Util.physicsDestroy();

            pInvokes.console.print("Exporting client prefs");

            //Todo Settings - Switch this back when fixed.
            pInvokes.Util.export("$pref::*", "prefs.client.cs", false);
            //pInvokes.Util.exportToSettings("$pref::*", "scripts/client/prefs.cs", false);
            //            pInvokes.Util.exportToSettings("$Pref::*", "scripts/client/prefs1.cs", true);

            pInvokes.console.print("Exporting server prefs");

            //Todo Settings - Switch this back when fixed.
            pInvokes.Util.export("$Pref::Server::*", "prefs.server.cs", false);
            //pInvokes.Util.exportToSettings("$Pref::Server::*", "scripts/server/prefs.cs", false);

            pInvokes.console.Call_Classname("BanList", "Export", new[] { "prefs.banlist.cs" });

            pInvokes.Util.stopFileChangeNotifications();

            Omni.self.StopEngine();
        }


        [ConsoleInteraction(true)]
        public static bool isScriptFile(string path)
        {
            if (pInvokes.Util.isFile(path + ".dso") || pInvokes.Util.isFile(path))
                return true;
            return false;
        }

        public static void loadDirs(string dirPath)
        {
            string[] directorypaths = dirPath.Split(';');
            for (int i = directorypaths.Count() - 1; i >= 0; i--)
            {
                if (pInvokes.Util.exec(directorypaths[i] + "/main.cs", false, false))
                    continue;
                pInvokes.console.error("Error: Unable to find specified directory: " + directorypaths[i]);
                pInvokes.iGlobal["$dirCount"]--;
            }
        }


        public static void displayHelp()
        {
            pInvokes.console.error("Torque Demo command line options:\n" +
                               "  -log <logmode>         Logging behavior; see main.cs comments for details\n" +
                               "  -game <game_name>      Reset list of mods to only contain <game_name>\n" +
                               "  <game_name>            Works like the -game argument\n" +
                               "  -dir <dir_name>        Add <dir_name> to list of directories\n" +
                               "  -console               Open a separate console\n" +
                               "  -show <shape>          Deprecated\n" + "  -jSave  <file_name>    Record a journal\n" +
                               "  -jPlay  <file_name>    Play back a journal\n" +
                               "  -jDebug <file_name>    Play back a journal and issue an int3 at the end\n" +
                               "  -help                  Display this help message\n");
        }

        public static string pushFront(string list, string token, string delim)
        {
            if (list != "")
                return token + delim + list;
            return token;
        }

        public static string pushBack(string list, string token, string delim)
        {
            if (list != "")
                return list + delim + token;
            return token;
        }

        public static string popFront(string list, string delim)
        {
            return pInvokes.Util.nextToken(list, "", delim);
        }

        [ConsoleInteraction(true)]
        public static void mainParseArgs()
        {
            for (int i = 1; i < pInvokes.iGlobal["$Game::argc"]; i++)
            {
                string arg = pInvokes.sGlobal["$Game::argv[" + i + "]"];
                string nextArg = pInvokes.sGlobal["$Game::argv[" + (i + 1) + "]"];
                bool hasNextarg = pInvokes.iGlobal["$Game::argc"] - i > 1;
                pInvokes.bGlobal["$logModeSpecified"] = false;
                System.Console.WriteLine(arg);
                switch (arg)
                {
                    case "-log":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            if (nextArg.AsInt() != 0)
                            {
                                nextArg += 4;
                            }
                            pInvokes.Util.setLogMode(nextArg.AsInt());
                            pInvokes.bGlobal["$logModeSpecified"] = true;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error("Error: Missing Command Line argument. Usage: -log <Mode: 0,1,2>");
                        }
                        break;
                    case "-console":
                        pInvokes.console.Call("enableWinConsole", new string[] { "true" });
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-jSave":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.Util._echo("Saving event log to journal: '" + nextArg + ".");
                            pInvokes.Util.saveJournal(nextArg);
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error("Error: Missing Command Line argument. Usage: -jSave <journal_name>");
                        }
                        break;
                    case "-jPlay":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.Util.playJournal(nextArg);
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error("Error: Missing Command Line argument. Usage: -jPlay <journal_name>");
                        }
                        break;
                    case "-jPlayToVideo":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$VideoCapture::journalName"] = nextArg;
                            pInvokes.bGlobal["$VideoCapture::captureFromJournal"] = true;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                            pInvokes.Util._error(
                                "Error: Missing Command Line argument. Usage: -jPlayToVideo <journal_name>");
                        break;

                    case "-vidCapFile":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$VideoCapture::fileName"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error(
                                "Error: Missing Command Line argument. Usage: -vidCapFile <ouput_video_name>");
                        }
                        break;
                    case "-vidCapFPS":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$VideoCapture::fps"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error(
                                "Error: Missing Command Line argument. Usage: -vidCapFPS <ouput_video_framerate>");
                        }
                        break;

                    case "-vidCapEncoder":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$VideoCapture::encoder"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error(
                                "Error: Missing Command Line argument. Usage: -vidCapEncoder <ouput_video_encoder>");
                        }
                        break;
                    case "-vidCapWidth":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$videoCapture::width"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error(
                                "Error: Missing Command Line argument. Usage: -vidCapWidth <ouput_video_width>");
                        }
                        break;
                    case "-vidCapHeight":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$videoCapture::height"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error(
                                "Error: Missing Command Line argument. Usage: -vidCapHeight <ouput_video_height>");
                        }
                        break;
                    case "-jDebug":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.Util.playJournal(nextArg);
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error("Error: Missing Command Line argument. Usage: -jDebug <journal_name>");
                        }
                        break;
                    case "-level":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            if (!nextArg.EndsWith(".mis"))
                            {
                                pInvokes.sGlobal["$levelToLoad"] = nextArg + ".mis";
                                pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                            }
                            else
                            {
                                pInvokes.sGlobal["$levelToLoad"] = nextArg;
                                pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                            }
                        }
                        else
                        {
                            pInvokes.console.error(
                                "Error: Missing Command Line argument. Usage: -level <level file name (no path), with or without extension>");
                        }
                        break;

                    case "-worldeditor":
                        pInvokes.bGlobal["$startWorldEditor"] = true;
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;

                    case "-guieditor":
                        pInvokes.bGlobal["$startGUIEditor"] = true;
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-help":
                        pInvokes.bGlobal["$displayHelp"] = true;
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-compileAll":
                        pInvokes.bGlobal["$compileAll"] = true;
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-compileTools":
                        pInvokes.bGlobal["$compileTools"] = true;
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-genScript":
                        pInvokes.bGlobal["$genScript"] = true;
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;

                    case "-fullscreen":
                        pInvokes.console.Call("setFullScreen", new[] { "true" });
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-windowed":
                        pInvokes.console.Call("setFullScreen", new[] { "false" });
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-openGL":
                        pInvokes.sGlobal["$pref::Video::displayDevice"] = "OpenGL";
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-directX":
                        pInvokes.sGlobal["$pref::Video::displayDevice"] = "D3D";
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-voodoo2":
                        pInvokes.sGlobal["$pref::Video::displayDevice"] = "Voodoo2";
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-autoVideo":
                        pInvokes.sGlobal["$pref::Video::displayDevice"] = "";
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-prefs":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.Util.exec(nextArg, true, true);
                            pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                            i++;
                        }
                        else
                        {
                            pInvokes.Util._error("Error: Missing Command Line argument. Usage: -prefs <path/script.cs>");
                        }
                        break;
                    case "-dedicated":
                        pInvokes.bGlobal["$Server::Dedicated"] = true;
                        pInvokes.bGlobal["$isDedicated"] = true;
                        pInvokes.console.Call("enableWinConsole", new[] { "true" });
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        break;
                    case "-mission":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$missionArg"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                            pInvokes.console.error("Error: Missing Command Line argument. Usage: -mission <filename>");
                        break;
                    case "-connect":
                        pInvokes.iGlobal["$argUsed[" + i + "]"]++;
                        if (hasNextarg)
                        {
                            pInvokes.sGlobal["$JoinGameAddress"] = nextArg;
                            pInvokes.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                            i++;
                        }
                        else
                            pInvokes.console.error("Error: Missing Command Line argument. Usage: -connect <ip_address>");
                        break;
                }
            }

            if (pInvokes.bGlobal["$VideoCapture::captureFromJournal"] && (pInvokes.sGlobal["$VideoCapture::journalName"] != ""))
            {
                if (pInvokes.sGlobal["$VideoCapture::fileName"] == "")
                    pInvokes.sGlobal["$VideoCapture::fileName"] = pInvokes.sGlobal["$VideoCapture::journalName"];

                if (pInvokes.sGlobal["$VideoCapture::encoder"] == "")
                    pInvokes.sGlobal["$VideoCapture::encoder"] = "THEORA";

                if (pInvokes.sGlobal["$VideoCapture::fps"] == "")
                    pInvokes.sGlobal["$VideoCapture::fps"] = "30";

                if (pInvokes.sGlobal["$videoCapture::width"] == "")
                    pInvokes.sGlobal["$videoCapture::width"] = "0";

                if (pInvokes.sGlobal["$videoCapture::height"] == "")
                    pInvokes.sGlobal["$videoCapture::height"] = "0";

                pInvokes.Util.playJournalToVideo(pInvokes.sGlobal["$VideoCapture::journalName"],
                    pInvokes.sGlobal["$VideoCapture::fileName"], pInvokes.sGlobal["$VideoCapture::encoder"],
                    pInvokes.fGlobal["$VideoCapture::fps"],
                    new Point2I(pInvokes.sGlobal["$videoCapture::width"].AsInt(),
                        pInvokes.sGlobal["$videoCapture::height"].AsInt()));
            }
        }

        public static void SetConstantsForReferencingVideoResolutionPreference()
        {
            pInvokes.iGlobal["$WORD::RES_X"] = 0;
            pInvokes.iGlobal["$WORD::RES_Y"] = 1;
            pInvokes.iGlobal["$WORD::FULLSCREEN"] = 2;
            pInvokes.iGlobal["$WORD::BITDEPTH"] = 3;
            pInvokes.iGlobal["$WORD::REFRESH"] = 4;
            pInvokes.iGlobal["$WORD::AA"] = 5;
        }

        [ConsoleInteraction(true)]
        public static void onMainStart()
        {
            #region FPS


            Server.server.LoadDefaults();

            #endregion

            // Here is where we will do the video device stuff, so it overwrites the defaults
            // First set the PCI device variables (yes AGP/PCI-E works too)
            pInvokes.iGlobal["$isFirstPersonVar"] = 1;
            // Uncomment to enable AdvancedLighting on the Mac (T3D 2009 Beta 3)
            pInvokes.bGlobal["$pref::machax::enableAdvancedLighting"] = true;

            // Uncomment to disable ShaderGen, useful when debugging
            //pInvokes.bGlobal["$ShaderGen::GenNewShaders"] = false;

            // Uncomment to dump disassembly for any shader that is compiled to disk.
            // These will appear as shadername_dis.txt in the same path as the
            // hlsl or glsl shader.
            //pInvokes.bGlobal["$gfx::disassembleAllShaders"] = true;

            // Uncomment useNVPerfHud to allow you to start up correctly
            // when you drop your executable onto NVPerfHud
            //pInvokes.bGlobal["$Video::useNVPerfHud"] = true;

            // Uncomment these to allow you to force your app into using
            // a specific pixel shader version (0 is for fixed function)
            //pInvokes.bGlobal["$pref::Video::forcePixVersion"] = true;
            //pInvokes.iGlobal["$pref::Video::forcedPixVersion"] = 0;

            //if (pInvokes.sGlobal["$platform"] == "macos")
            //pInvokes.sGlobal["$pref::Video::displayDevice"] = "OpenGL";
            //else
            //pInvokes.sGlobal["$pref::Video::displayDevice"] = "D3D9";
            if (pInvokes.bGlobal["$isDedicated"])
                {
                    pInvokes.Util.setRandomSeed((DateTime.Now.Millisecond + 1) * (DateTime.Now.Second + 1));
                    // Set up networking.
                    pInvokes.Util.setNetPort(0);
                    // Initialize the canvas.
                    pInvokes.console.Call_Classname("GFXInit", "createNullDevice");
                    // Start processing file change events.
                    pInvokes.Util.startFileChangeNotifications();
                }






            pInvokes.Util._echo(" % - Initialized Core");

            #region FPS

            pInvokes.console.print("\n--------- Initializing Directory: scripts ---------");

            // Init the physics plugin.
            pInvokes.Util.physicsInit("Bullet");

            // Start up the audio system.
            //audio.sfxStartup();


            //messageBox.initialize();

            // Server gets loaded for all sessions, since clients
            // can host in-game servers.
            Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.server.initServer();

            // Start up in either client, or dedicated server mode

            Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.server.initDedicated();


            #endregion
        }

        [ConsoleInteraction(true)]
        public static void mainloadKeybindings()
        {
            pInvokes.iGlobal["$keybindCount"] = 0;
            // Load up the active projects keybinds.
            if (pInvokes.Util.isFunction("setupKeybinds"))
                pInvokes.console.Call("setupKeybinds");
        }




    }


}
