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

using System.Linq;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
{
    public class server
    {
        public static void LoadDefaults()
        {
            // List of master servers to query, each one is tried in order
            // until one responds
            pInvokes.iGlobal["$Pref::Server::RegionMask"] = 2;
            pInvokes.sGlobal["$pref::Master[0]"] = "2:master.garagegames.com:28002";

            // Information about the server
            pInvokes.sGlobal["$Pref::Server::Name"] = "Torque 3D Server";
            pInvokes.sGlobal["$Pref::Server::Info"] = "This is a Torque 3D server.";

            // The connection error message is transmitted to the client immediatly
            // on connection, if any further error occures during the connection
            // process, such as network traffic mismatch, or missing files, this error
            // message is display. This message should be replaced with information
            // usefull to the client, such as the url or ftp address of where the
            // latest version of the game can be obtained.
            pInvokes.sGlobal["$Pref::Server::ConnectionError"] = "You do not have the correct version of the FPS starter kit or " + "the related art needed to play on this server, please contact " + "the server operator for more information.";

            // The network port is also defined by the client, this value 
            // overrides pref::net::port for dedicated servers
            pInvokes.iGlobal["$Pref::Server::Port"] = 28000;

            // If the password is set, clients must provide it in order
            // to connect to the server
            pInvokes.sGlobal["$Pref::Server::Password"] = string.Empty;

            // Password for admin clients
            pInvokes.sGlobal["$Pref::Server::AdminPassword"] = string.Empty;

            // Misc server settings.
            pInvokes.iGlobal["$Pref::Server::MaxPlayers"] = 64;
            pInvokes.iGlobal["$Pref::Server::TimeLimit"] = 20; // In minutes
            pInvokes.iGlobal["$Pref::Server::KickBanTime"] = 300; // specified in seconds
            pInvokes.iGlobal["$Pref::Server::BanTime"] = 1800; // specified in seconds
            pInvokes.iGlobal["$Pref::Server::FloodProtectionEnabled"] = 1;
            pInvokes.iGlobal["$Pref::Server::MaxChatLen"] = 120;

            pInvokes.sGlobal["$Pref::Server::Net::ClientGameConnectionModelClass"] = typeof (GameConnection).FullName;

            //todo Now add your own game specific server preferences as well as any overloaded core defaults here.

            // Finally load the preferences saved from the last
            // game execution if they exist.
            if (pInvokes.sGlobal["$platform"] != "xenon")
                {
                //Todo Settings - Switch this back when fixed.
                pInvokes.Util.exec("prefs.server.cs", false, false);
                //Settings.LoadSection("scripts/server/prefs.cs");
                }
            else
                pInvokes.Util._error("Not loading server prefs.cs on Xbox360");
        }

        public static void initDedicated()
        {
            pInvokes.console.Call("enableWinConsole", new[] {"true"});
            //con.Eval("enableWinConsole(true);");
            pInvokes.console.print(@"\n--------- Starting Dedicated Server ---------");
            // Make sure this variable reflects the correct state.
            pInvokes.bGlobal["$Server::Dedicated"] = true;
            // The server isn't started unless a mission has been specified.
            if (pInvokes.sGlobal["$missionArg"] != string.Empty)
                createServer("MultiPlayer", pInvokes.sGlobal["$missionArg"]);

            else
                pInvokes.console.print("No mission specified (use -mission filename)");
        }

        public static void initServer()
        {
            pInvokes.console.print("\n--------- Initializing " + pInvokes.sGlobal["$appName"] + ": Server Scripts ---------");
            // Server::Status is returned in the Game Info Query and represents the
            // current status of the server. This string sould be very short.
            pInvokes.sGlobal["$Server::Status"] = "Unknown";
            // Turn on testing/debug script functions
            pInvokes.bGlobal["$Server::TestCheats"] = false;
            // Specify where the mission files are.
            pInvokes.sGlobal["$Server::MissionFileSpec"] = "levels/*.mis";

            // The common module provides the basic server functionality
            initBaseServer();

            // Load up game server support scripts
            game.initGame();
        }

        public static void initBaseServer()
        {
            // Base server functionality
            missionLoad.InitMissionLoad();
            game.initGame();
            spawn.init();
            pInvokes.iGlobal["$Camera::movementSpeed"] = 30;
            Client.CenterPrint.centerPrint.initialize();
        }

        public static void portInit(int port)
        {
            int failCount = 0;
            while (failCount < 10 && !pInvokes.Util.setNetPort(port))
                {
                pInvokes.console.print("Port init failed on port " + port + " trying next port.");
                port++;
                failCount++;
                }
        }

        /// <summary>
        /// Create a server of the given type, load the given level, and then
        /// create a local client connection to the server.
        //
        /// @return true if successful.
        /// 
        /// 
        /// </summary>
        /// <param name="serverType"></param>
        /// <param name="level"></param>
        [ConsoleInteraction(true)]
        public static bool createAndConnectToLocalServer(string serverType, string level)
        {
            if (!createServer(serverType, level))
                return false;

            GameConnection conn = new ObjectCreator("GameConnection", "ServerConnection", pInvokes.sGlobal["$Pref::Server::Net::ClientGameConnectionModelClass"]).Create();

            ((SimGroup) "RootGroup").add(conn);

            conn.setConnectArgs(pInvokes.sGlobal["$pref::Player::Name"]);
            conn.setJoinPassword(pInvokes.sGlobal["$Client::Password"]);

            if (conn.connectLocal() != string.Empty)
                {
                conn.delete();
                destroyServer();
                return false;
                }
            return true;
        }

        /// <summary>
        /// Create a server with either a "SinglePlayer" or "MultiPlayer" type
        /// Specify the level to load on the server
        /// </summary>
        /// <param name="serverType"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        [ConsoleInteraction(true)]
        public static bool createServer(string serverType, string level)
        {
            pInvokes.iGlobal["$Server::Session"]++;

            if (level == string.Empty)
                {
                pInvokes.console.error("createServer(): level name unspecified");
                return false;
                }

            level = pInvokes.Util.makeRelativePath(level, pInvokes.Util.getWorkingDirectory());
            destroyServer();

            pInvokes.iGlobal["$missionSequence"] = 0;
            pInvokes.iGlobal["$Server::PlayerCount"] = 0;
            pInvokes.sGlobal["$Server::ServerType"] = serverType;
            pInvokes.sGlobal["$Server::LoadFailMsg"] = string.Empty;
            pInvokes.bGlobal["$Physics::isSinglePlayer"] = true;
            // Setup for multi-player, the network must have been
            // initialized before now.

            if (serverType == "MultiPlayer")
                {
                //pInvokes.iGlobal["$pref::Net::PacketRateToClient"] = 32;
                //pInvokes.iGlobal["$pref::Net::PacketRateToServer"] = 32;
                //pInvokes.iGlobal["$pref::Net::PacketSize"] = 200;

                pInvokes.bGlobal["$Physics::isSinglePlayer"] = false;
                pInvokes.console.print("Starting multiplayer mode");

                // Make sure the network port is set to the correct pref.
                portInit(pInvokes.iGlobal["$Pref::Server::Port"]);

                pInvokes.Util.allowConnections(true);

                if (pInvokes.sGlobal["$pref::Net::DisplayOnMaster"] != "Never")
                    pInvokes.Util._schedule("0", "0", "startHeartBeat");
                }

            // Create the ServerGroup that will persist for the lifetime of the server.
            new ObjectCreator("SimGroup", "ServerGroup").Create();

            pInvokes.Util.exec("core/art/datablocks/datablockExec.cs", false, false);

            game.onServerCreated();

            pInvokes.console.Call("loadMission", new[] {level, "true"});

            return true;
        }

        /// <summary>
        /// Shut down the server
        /// </summary>
        [ConsoleInteraction(true)]
        public static void destroyServer()
        {
            pInvokes.sGlobal["$Server::ServerType"] = string.Empty;
            pInvokes.Util.allowConnections(false);

            pInvokes.console.Call("stopHeartbeat");

            pInvokes.bGlobal["$missionRunning"] = false;

            // End any running levels

            missionLoad.EndMission();

            game.onServerDestroyed();

            // Delete all the server objects
            if ("ServerGroup".isObject())
                "ServerGroup".delete();

            // Delete all the connections:
            while (pInvokes.ClientGroup.Count().AsBool())
                pInvokes.ClientGroup[0].AsString().delete();

            pInvokes.sGlobal["$Server::GuidList"] = string.Empty;

            // Delete all the data blocks...
            pInvokes.Util.deleteDataBlocks();

            // Save any server settings
            pInvokes.console.print("Exporting server prefs...");

            //Todo Settings - Switch this back when fixed.
            pInvokes.Util.export("$Pref::Server::*", "core/scripts/prefs.cs", false);
            //pInvokes.Util.exportToSettings("$Pref::Server::*", "core/scripts/prefs.cs", false);

            // Increase the server session number.  This is used to make sure we're
            // working with the server session we think we are.
            pInvokes.iGlobal["$Server::Session"]++;
        }

        [ConsoleInteraction(true)]
        public static string onServerInfoQuery()
        {
            return "Doing Ok";
        }

        [ConsoleInteraction(true)]
        public static void resetServerDefaults()
        {
            pInvokes.console.print("Resetting server defaults...");
            LoadDefaults();

            //Todo Settings - Switch this back when fixed.
            //Settings.LoadSection("core/scripts/prefs.cs");
            pInvokes.Util.exec("core/scripts/prefs.cs", false, false);

            // Reload the current level
            missionLoad.loadMission(pInvokes.sGlobal["$Server::MissionFile"], false);
        }
    }
}