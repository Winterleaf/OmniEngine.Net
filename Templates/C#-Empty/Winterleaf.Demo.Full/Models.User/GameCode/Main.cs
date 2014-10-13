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
using System.Linq;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode
{
    /// <summary>
    /// This is a required file, replaces main.cs in the root directory
    /// </summary>
    /// 
    public static class Main
    {
        private static readonly pInvokes omni = new pInvokes();

        /// <summary>
        /// Main entry point into the scripts.
        /// MANDITORY FUNCTION
        /// </summary>
        /// <param name="argc"></param>
        /// <param name="argv"></param>
        [ConsoleInteraction(true)]
        public static int main(int argc, string[] argv)
        {
            //t3d.Util._call("enableWinConsole", "true");
            //t3d.sGlobal["$test[1]"] = "test";
            //Console.WriteLine(t3d.sGlobal["$test[1]"]);

            // 

            // Set the name of our application
            omni.sGlobal["$appName"] = "Full";
            // The directory it is run from
            omni.sGlobal["$defaultGame"] = "scripts";
            // Set profile directory
            omni.sGlobal["$Pref::Video::ProfilePath"] = "core/profile";

            omni.bGlobal["$displayHelp"] = false;

            omni.bGlobal["$isDedicated"] = false;

            omni.iGlobal["$dirCount"] = 2;

            omni.sGlobal["$userDirs"] = omni.sGlobal["$defaultGame"] + ";art;levels";

            mainParseArgs();

            // load tools scripts if we're a tool build
            //if (omni.Util.isToolBuild() && !omni.bGlobal["$isDedicated"])
            //    omni.sGlobal["$userDirs"] = "tools;" + omni.sGlobal["$userDirs"];

            // Parse the executable arguments with the standard
            // function from core/main.cs

            if (omni.iGlobal["$dirCount"] == 0)
                {
                omni.sGlobal["$userDirs"] = omni.sGlobal["$defaultGame"];
                omni.iGlobal["$dirCount"] = 1;
                }

            //-----------------------------------------------------------------------------
            // Display a splash window immediately to improve app responsiveness before
            // engine is initialized and main window created

            if (!omni.bGlobal["$isDedicated"])
                omni.Util.displaySplashWindow("art/gui/omni.bmp");

            if (!omni.bGlobal["$logModeSpecified"])
                {
                if (omni.sGlobal["$platform"] != "xbox" && omni.sGlobal["$platform"] != "xenon")
                    omni.Util.setLogMode(6);
                }

            omni.Util.nextToken("$userDirs", "currentMod", ";");

            omni.console.print("--------- Loading DIRS ---------");

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
            omni.console.Eval(@"
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
            GameConnection.initialize();
            SetConstantsForReferencingVideoResolutionPreference();

            loadDirs(omni.sGlobal["$userDirs"]);

            //-----> Load tools here
            if (omni.Util.isToolBuild() && !omni.bGlobal["$isDedicated"])
                //omni.sGlobal["$userDirs"] = "tools;" + omni.sGlobal["$userDirs"];

                Tools.main.initialize();

            //We don't need this no more, no more scripts!
            // if (omni.iGlobal["$dirCount"] == 0)
            // {
            // omni.Util._call("enableWinConsole", "true");
            // omni.console.error("Error: Unable to load any specified directories");
            //Main.Quit();
            //t3d.Util.quit();
            //}

            // Parse the command line arguments
            omni.console.print("--------- Parsing Arguments ---------");

            mainParseArgs();

            if (omni.bGlobal["$displayHelp"])
                {
                omni.console.Call("enableWinConsole", new[] {"true"});
                displayHelp();
                //t3d.Util.quit();
                Quit();
                }
            else
                {
                //due to the Tools, this must be called through the console.
                omni.console.Call("onStart");
                //onStart();
                omni.console.print("Engine initialized...");
                if (omni.sGlobal["$platform"] == "xenon")
                    {
                    const string mission = "levels//Empty Terrain.mis";
                    omni.console.print("Xbox360 Autoloading level: '" + mission + "'");
                    string serverType = omni.bGlobal["$pref::HostMultiPlayer"] ? "MultiPlayer" : "SinglePlayer";
                    server.createAndConnectToLocalServer(serverType, mission);
                    }
                }

            for (int i = 1; i < omni.iGlobal["$Game::argc"]; i++)
                {
                if (!omni.bGlobal["$argUsed[" + i + "]"])
                    {
                    if (omni.sGlobal["$Game::argv[" + i + "]"].Trim() != "")
                        omni.console.error("Error: Unknown command line argument: " + omni.sGlobal["$Game::argv[" + i + "]"]);
                    }
                }

            GuiCanvas canvas = "Canvas";

            if (omni.bGlobal["$startWorldEditor"])
                {
                canvas.setCursor("DefaultCursor");
                canvas.setContent("EditorChooseLevelGui");
                }
            else if (omni.bGlobal["$startGUIEditor"])
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
            omni.console.print("Calling " + dir + "/main.cs");
            omni.Util.exec(dir + "/main.cs", false, false);
        }

        [ConsoleInteraction(true)]
        public static void onMainExit()
        {
            if (omni.bGlobal["$Server::Dedicated"])
                server.destroyServer();
            else
                omni.console.Call("disconnect");

            omni.Util.physicsDestroy();

            omni.console.print("Exporting client prefs");

            //Todo Settings - Switch this back when fixed.
            omni.Util.export("$pref::*", "prefs.client.cs", false);
            //omni.Util.exportToSettings("$pref::*", "scripts/client/prefs.cs", false);
            //            t3d.Util.exportToSettings("$Pref::*", "scripts/client/prefs1.cs", true);

            omni.console.print("Exporting server prefs");

            //Todo Settings - Switch this back when fixed.
            omni.Util.export("$Pref::Server::*", "prefs.server.cs", false);
            //omni.Util.exportToSettings("$Pref::Server::*", "scripts/server/prefs.cs", false);

            omni.console.Call_Classname("BanList", "Export", new[] {"prefs.banlist.cs"});

            core.shutdownCore();

            Omni.self.StopEngine();
        }

        [ConsoleInteraction(true)]
        public static bool isScriptFile(string path)
        {
            if (omni.Util.isFile(path + ".dso") || omni.Util.isFile(path))
                return true;
            return false;
        }

        public static void loadDirs(string dirPath)
        {
            string[] directorypaths = dirPath.Split(';');
            for (int i = directorypaths.Count() - 1; i >= 0; i--)
                {
                if (omni.Util.exec(directorypaths[i] + "/main.cs", false, false))
                    continue;
                omni.console.error("Error: Unable to find specified directory: " + directorypaths[i]);
                omni.iGlobal["$dirCount"]--;
                }
        }

        public static void displayHelp()
        {
            omni.console.error("Torque Demo command line options:\n" + "  -log <logmode>         Logging behavior; see main.cs comments for details\n" + "  -game <game_name>      Reset list of mods to only contain <game_name>\n" + "  <game_name>            Works like the -game argument\n" + "  -dir <dir_name>        Add <dir_name> to list of directories\n" + "  -console               Open a separate console\n" + "  -show <shape>          Deprecated\n" + "  -jSave  <file_name>    Record a journal\n" + "  -jPlay  <file_name>    Play back a journal\n" + "  -jDebug <file_name>    Play back a journal and issue an int3 at the end\n" + "  -help                  Display this help message\n");
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
            return omni.Util.nextToken(list, "", delim);
        }

        [ConsoleInteraction(true)]
        public static void mainParseArgs()
        {
            for (int i = 1; i < omni.iGlobal["$Game::argc"]; i++)
                {
                string arg = omni.sGlobal["$Game::argv[" + i + "]"];
                string nextArg = omni.sGlobal["$Game::argv[" + (i + 1) + "]"];
                bool hasNextarg = omni.iGlobal["$Game::argc"] - i > 1;
                omni.bGlobal["$logModeSpecified"] = false;
                Console.WriteLine(arg);
                switch (arg)
                    {
                        case "-log":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                if (nextArg.AsInt() != 0)
                                    nextArg += 4;
                                omni.Util.setLogMode(nextArg.AsInt());
                                omni.bGlobal["$logModeSpecified"] = true;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -log <Mode: 0,1,2>");
                            break;
                        case "-console":
                            omni.console.Call("enableWinConsole", new string[] {"true"});
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-jSave":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.Util._echo("Saving event log to journal: '" + nextArg + ".");
                                omni.Util.saveJournal(nextArg);
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -jSave <journal_name>");
                            break;
                        case "-jPlay":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.Util.playJournal(nextArg);
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -jPlay <journal_name>");
                            break;
                        case "-jPlayToVideo":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$VideoCapture::journalName"] = nextArg;
                                omni.bGlobal["$VideoCapture::captureFromJournal"] = true;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -jPlayToVideo <journal_name>");
                            break;

                        case "-vidCapFile":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$VideoCapture::fileName"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -vidCapFile <ouput_video_name>");
                            break;
                        case "-vidCapFPS":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$VideoCapture::fps"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -vidCapFPS <ouput_video_framerate>");
                            break;

                        case "-vidCapEncoder":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$VideoCapture::encoder"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -vidCapEncoder <ouput_video_encoder>");
                            break;
                        case "-vidCapWidth":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$videoCapture::width"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -vidCapWidth <ouput_video_width>");
                            break;
                        case "-vidCapHeight":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$videoCapture::height"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -vidCapHeight <ouput_video_height>");
                            break;
                        case "-jDebug":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.Util.playJournal(nextArg);
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -jDebug <journal_name>");
                            break;
                        case "-level":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                if (!nextArg.EndsWith(".mis"))
                                    {
                                    omni.sGlobal["$levelToLoad"] = nextArg + ".mis";
                                    omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                    i++;
                                    }
                                else
                                    {
                                    omni.sGlobal["$levelToLoad"] = nextArg;
                                    omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                    i++;
                                    }
                                }
                            else
                                omni.console.error("Error: Missing Command Line argument. Usage: -level <level file name (no path), with or without extension>");
                            break;

                        case "-worldeditor":
                            omni.bGlobal["$startWorldEditor"] = true;
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;

                        case "-guieditor":
                            omni.bGlobal["$startGUIEditor"] = true;
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-help":
                            omni.bGlobal["$displayHelp"] = true;
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-compileAll":
                            omni.bGlobal["$compileAll"] = true;
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-compileTools":
                            omni.bGlobal["$compileTools"] = true;
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-genScript":
                            omni.bGlobal["$genScript"] = true;
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;

                        case "-fullscreen":
                            omni.console.Call("setFullScreen", new[] {"true"});
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-windowed":
                            omni.console.Call("setFullScreen", new[] {"false"});
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-openGL":
                            omni.sGlobal["$pref::Video::displayDevice"] = "OpenGL";
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-directX":
                            omni.sGlobal["$pref::Video::displayDevice"] = "D3D";
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-voodoo2":
                            omni.sGlobal["$pref::Video::displayDevice"] = "Voodoo2";
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-autoVideo":
                            omni.sGlobal["$pref::Video::displayDevice"] = "";
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-prefs":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.Util.exec(nextArg, true, true);
                                omni.iGlobal["$argUsed[" + i + "]"]++;
                                i++;
                                }
                            else
                                omni.Util._error("Error: Missing Command Line argument. Usage: -prefs <path/script.cs>");
                            break;
                        case "-dedicated":
                            omni.bGlobal["$Server::Dedicated"] = true;
                            omni.bGlobal["$isDedicated"] = true;
                            omni.console.Call("enableWinConsole", new[] {"true"});
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            break;
                        case "-mission":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$missionArg"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.console.error("Error: Missing Command Line argument. Usage: -mission <filename>");
                            break;
                        case "-connect":
                            omni.iGlobal["$argUsed[" + i + "]"]++;
                            if (hasNextarg)
                                {
                                omni.sGlobal["$JoinGameAddress"] = nextArg;
                                omni.iGlobal["$argUsed[" + (i + 1) + "]"]++;
                                i++;
                                }
                            else
                                omni.console.error("Error: Missing Command Line argument. Usage: -connect <ip_address>");
                            break;
                    }
                }

            if (omni.bGlobal["$VideoCapture::captureFromJournal"] && (omni.sGlobal["$VideoCapture::journalName"] != ""))
                {
                if (omni.sGlobal["$VideoCapture::fileName"] == "")
                    omni.sGlobal["$VideoCapture::fileName"] = omni.sGlobal["$VideoCapture::journalName"];

                if (omni.sGlobal["$VideoCapture::encoder"] == "")
                    omni.sGlobal["$VideoCapture::encoder"] = "THEORA";

                if (omni.sGlobal["$VideoCapture::fps"] == "")
                    omni.sGlobal["$VideoCapture::fps"] = "30";

                if (omni.sGlobal["$videoCapture::width"] == "")
                    omni.sGlobal["$videoCapture::width"] = "0";

                if (omni.sGlobal["$videoCapture::height"] == "")
                    omni.sGlobal["$videoCapture::height"] = "0";

                omni.Util.playJournalToVideo(omni.sGlobal["$VideoCapture::journalName"], omni.sGlobal["$VideoCapture::fileName"], omni.sGlobal["$VideoCapture::encoder"], omni.fGlobal["$VideoCapture::fps"], new Point2I(omni.sGlobal["$videoCapture::width"].AsInt(), omni.sGlobal["$videoCapture::height"].AsInt()));
                }
        }

        public static void SetConstantsForReferencingVideoResolutionPreference()
        {
            omni.iGlobal["$WORD::RES_X"] = 0;
            omni.iGlobal["$WORD::RES_Y"] = 1;
            omni.iGlobal["$WORD::FULLSCREEN"] = 2;
            omni.iGlobal["$WORD::BITDEPTH"] = 3;
            omni.iGlobal["$WORD::REFRESH"] = 4;
            omni.iGlobal["$WORD::AA"] = 5;
        }

        [ConsoleInteraction(true)]
        public static void onMainStart()
        {
            #region FPS

            client.LoadDefaults();
            server.LoadDefaults();

            #endregion

            // Here is where we will do the video device stuff, so it overwrites the defaults
            // First set the PCI device variables (yes AGP/PCI-E works too)
            omni.iGlobal["$isFirstPersonVar"] = 1;
            // Uncomment to enable AdvancedLighting on the Mac (T3D 2009 Beta 3)
            omni.bGlobal["$pref::machax::enableAdvancedLighting"] = true;

            // Uncomment to disable ShaderGen, useful when debugging
            //omni.bGlobal["$ShaderGen::GenNewShaders"] = false;

            // Uncomment to dump disassembly for any shader that is compiled to disk.
            // These will appear as shadername_dis.txt in the same path as the
            // hlsl or glsl shader.   
            //omni.bGlobal["$gfx::disassembleAllShaders"] = true;

            // Uncomment useNVPerfHud to allow you to start up correctly
            // when you drop your executable onto NVPerfHud
            //omni.bGlobal["$Video::useNVPerfHud"] = true;

            // Uncomment these to allow you to force your app into using
            // a specific pixel shader version (0 is for fixed function)
            //omni.bGlobal["$pref::Video::forcePixVersion"] = true;
            //omni.iGlobal["$pref::Video::forcedPixVersion"] = 0;

            //if (omni.sGlobal["$platform"] == "macos")
            //omni.sGlobal["$pref::Video::displayDevice"] = "OpenGL";
            //else
            //omni.sGlobal["$pref::Video::displayDevice"] = "D3D9";
            core.initializeCore();

            omni.Util._echo(" % - Initialized Core");

            #region FPS

            omni.console.print("\n--------- Initializing Directory: scripts ---------");

            // Init the physics plugin.
            omni.Util.physicsInit("Bullet");

            // Start up the audio system.
            audio.sfxStartup();

            messageBox.initialize();

            // Server gets loaded for all sessions, since clients
            // can host in-game servers.
            server.initServer();

            // Start up in either client, or dedicated server mode
            if (omni.bGlobal["$Server::Dedicated"])
                server.initDedicated();
            else
                init.initClient();

            #endregion
        }

        [ConsoleInteraction(true)]
        public static void mainloadKeybindings()
        {
            omni.iGlobal["$keybindCount"] = 0;
            // Load up the active projects keybinds.
            if (omni.Util.isFunction("setupKeybinds"))
                omni.console.Call("setupKeybinds");
        }

    }

}