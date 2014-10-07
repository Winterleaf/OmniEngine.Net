#region

using System;
using System.Linq;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class server
        {
        public static pInvokes t3d = new pInvokes();

        public static void LoadDefaults()
            {
            // List of master servers to query, each one is tried in order
            // until one responds
            t3d.iGlobal["$Pref::Server::RegionMask"] = 2;
            t3d.sGlobal["$pref::Master[0]"] = "2:master.garagegames.com:28002";

            // Information about the server
            t3d.sGlobal["$Pref::Server::Name"] = "Torque 3D Server";
            t3d.sGlobal["$Pref::Server::Info"] = "This is a Torque 3D server.";

            // The connection error message is transmitted to the client immediatly
            // on connection, if any further error occures during the connection
            // process, such as network traffic mismatch, or missing files, this error
            // message is display. This message should be replaced with information
            // usefull to the client, such as the url or ftp address of where the
            // latest version of the game can be obtained.
            t3d.sGlobal["$Pref::Server::ConnectionError"] =
                "You do not have the correct version of the FPS starter kit or " +
                "the related art needed to play on this server, please contact " +
                "the server operator for more information.";

            // The network port is also defined by the client, this value 
            // overrides pref::net::port for dedicated servers
            t3d.iGlobal["$Pref::Server::Port"] = 28000;

            // If the password is set, clients must provide it in order
            // to connect to the server
            t3d.sGlobal["$Pref::Server::Password"] = string.Empty;

            // Password for admin clients
            t3d.sGlobal["$Pref::Server::AdminPassword"] = string.Empty;

            // Misc server settings.
            t3d.iGlobal["$Pref::Server::MaxPlayers"] = 64;
            t3d.iGlobal["$Pref::Server::TimeLimit"] = 20; // In minutes
            t3d.iGlobal["$Pref::Server::KickBanTime"] = 300; // specified in seconds
            t3d.iGlobal["$Pref::Server::BanTime"] = 1800; // specified in seconds
            t3d.iGlobal["$Pref::Server::FloodProtectionEnabled"] = 1;
            t3d.iGlobal["$Pref::Server::MaxChatLen"] = 120;


            t3d.sGlobal["$Pref::Server::Net::ClientGameConnectionModelClass"] = typeof(GameConnectionDM).FullName;

            //todo Now add your own game specific server preferences as well as any overloaded core defaults here.

            // Finally load the preferences saved from the last
            // game execution if they exist.
            if (t3d.sGlobal["$platform"] != "xenon")
                {
                //Todo Settings - Switch this back when fixed.
                t3d.Util.exec("prefs.server.cs", false, false);
                //Settings.LoadSection("scripts/server/prefs.cs");
                }
            else
                {
                t3d.Util._error("Not loading server prefs.cs on Xbox360");
                }


            }

        public static void initDedicated()
            {
            t3d.console.Call("enableWinConsole", new[] { "true" });
            //con.Eval("enableWinConsole(true);");
            t3d.console.print(@"\n--------- Starting Dedicated Server ---------");
            // Make sure this variable reflects the correct state.
            t3d.bGlobal["$Server::Dedicated"] = true;
            // The server isn't started unless a mission has been specified.
            if (t3d.sGlobal["$missionArg"] != string.Empty)
                createServer("MultiPlayer", t3d.sGlobal["$missionArg"]);

            else
                t3d.console.print("No mission specified (use -mission filename)");
            }

        public static void initServer()
            {
            t3d.console.print("\n--------- Initializing " + t3d.sGlobal["$appName"] + ": Server Scripts ---------");
            // Server::Status is returned in the Game Info Query and represents the
            // current status of the server. This string sould be very short.
            t3d.sGlobal["$Server::Status"] = "Unknown";
            // Turn on testing/debug script functions
            t3d.bGlobal["$Server::TestCheats"] = false;
            // Specify where the mission files are.
            t3d.sGlobal["$Server::MissionFileSpec"] = "levels/*.mis";

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
            t3d.iGlobal["$Camera::movementSpeed"] = 30;
            Models.User.GameCode.Client.CenterPrint.centerPrint.initialize();
            }

        public static void portInit(int port)
            {
            int failCount = 0;
            while (failCount < 10 && !t3d.Util.setNetPort(port))
                {
                t3d.console.print("Port init failed on port " + port + " trying next port.");
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

            GameConnection conn = new ObjectCreator("GameConnection", "ServerConnection", t3d.sGlobal["$Pref::Server::Net::ClientGameConnectionModelClass"]).Create();

            ((SimGroup)"RootGroup").add(conn);

            conn.setConnectArgs(t3d.sGlobal["$pref::Player::Name"]);
            conn.setJoinPassword(t3d.sGlobal["$Client::Password"]);

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
            t3d.iGlobal["$Server::Session"]++;

            if (level == string.Empty)
                {
                t3d.console.error("createServer(): level name unspecified");
                return false;
                }

            level = t3d.Util.makeRelativePath(level, t3d.Util.getWorkingDirectory());
            destroyServer();

            t3d.iGlobal["$missionSequence"] = 0;
            t3d.iGlobal["$Server::PlayerCount"] = 0;
            t3d.sGlobal["$Server::ServerType"] = serverType;
            t3d.sGlobal["$Server::LoadFailMsg"] = string.Empty;
            t3d.bGlobal["$Physics::isSinglePlayer"] = true;
            // Setup for multi-player, the network must have been
            // initialized before now.

            if (serverType == "MultiPlayer")
                {
                //t3d.iGlobal["$pref::Net::PacketRateToClient"] = 32;
                //t3d.iGlobal["$pref::Net::PacketRateToServer"] = 32;
                //t3d.iGlobal["$pref::Net::PacketSize"] = 200;

                t3d.bGlobal["$Physics::isSinglePlayer"] = false;
                t3d.console.print("Starting multiplayer mode");

                // Make sure the network port is set to the correct pref.
                portInit(t3d.iGlobal["$Pref::Server::Port"]);

                t3d.Util.allowConnections(true);

                if (t3d.sGlobal["$pref::Net::DisplayOnMaster"] != "Never")
                    t3d.Util._schedule("0", "0", "startHeartBeat");
                }

            // Create the ServerGroup that will persist for the lifetime of the server.
            new ObjectCreator("SimGroup", "ServerGroup").Create();

            t3d.Util.exec("core/art/datablocks/datablockExec.cs", false, false);

            game.onServerCreated();


            t3d.console.Call("loadMission", new[] { level, "true" });

            return true;
            }

        /// <summary>
        /// Shut down the server
        /// </summary>
        [ConsoleInteraction(true)]
        public static void destroyServer()
            {
            t3d.sGlobal["$Server::ServerType"] = string.Empty;
            t3d.Util.allowConnections(false);

            t3d.console.Call("stopHeartbeat");

            t3d.bGlobal["$missionRunning"] = false;

            // End any running levels

            missionLoad.EndMission();

            game.onServerDestroyed();

            // Delete all the server objects
            if ("ServerGroup".isObject())
                "ServerGroup".delete();

            // Delete all the connections:
            while (t3d.ClientGroup.Count().AsBool())
                t3d.ClientGroup[0].AsString().delete();

            t3d.sGlobal["$Server::GuidList"] = string.Empty;

            // Delete all the data blocks...
            t3d.Util.deleteDataBlocks();

            // Save any server settings
            t3d.console.print("Exporting server prefs...");

            //Todo Settings - Switch this back when fixed.
            t3d.Util.export("$Pref::Server::*", "core/scripts/prefs.cs", false);
            //t3d.Util.exportToSettings("$Pref::Server::*", "core/scripts/prefs.cs", false);

            // Increase the server session number.  This is used to make sure we're
            // working with the server session we think we are.
            t3d.iGlobal["$Server::Session"]++;
            }

        [ConsoleInteraction(true)]
        public static string onServerInfoQuery()
            {
            return "Doing Ok";
            }

        [ConsoleInteraction(true)]
        public static void resetServerDefaults()
            {
            t3d.console.print("Resetting server defaults...");
            LoadDefaults();

            //Todo Settings - Switch this back when fixed.
            //Settings.LoadSection("core/scripts/prefs.cs");
            t3d.Util.exec("core/scripts/prefs.cs", false, false);

            // Reload the current level
            missionLoad.loadMission(t3d.sGlobal["$Server::MissionFile"], false);
            }
        }
    }