using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game
    {
    public class missionLoadBase : pInvokes
        {
        

        public virtual void InitMissionLoad()
            {
            iGlobal["$MissionLoadPause"] = 5000;
            }

        public virtual void loadMission(string missionName, bool isFirstMission)
            {
            EndMission();
            console.print("*** LOADING MISSION: " + missionName);
            console.print("*** Stage 1 load");

            // Reset all of these

            centerPrint.ClearCenterPrintAll();
            centerPrint.ClearBottomPrintAll();

            // increment the mission sequence (used for ghost sequencing)

            iGlobal["$missionSequence"] = iGlobal["$missionSequence"] + 1;


            bGlobal["$missionRunning"] = false;

            sGlobal["$Server::MissionFile"] = missionName;

            sGlobal["$Server::LoadFailMsg"] = string.Empty;


            // Extract mission info from the mission file,
            // including the display name and stuff to send
            // to the client.

            levelInfo.BuildLoadInfo(missionName);

            // Download mission info to the clients
            foreach (
                GameConnection client in
                    ClientGroup.Where(client => !((GameConnection)client).isAIControlled()))
                client.sendLoadInfoToClient();


            // Now that we've sent the LevelInfo to the clients
            // clear it so that it won't conflict with the actual
            // LevelInfo loaded in the level
            levelInfo.ClearLoadInfo();

            // if this isn't the first mission, allow some time for the server
            // to transmit information to the clients:
            if (isFirstMission || sGlobal["$Server::ServerType"] == "SinglePlayer")
                LoadMissionStage2();
            else
                Util._schedule(sGlobal["$MissionLoadPause"], "0", "loadMissionStage2");
            }

        public virtual void LoadMissionStage2()
            {
            console.print("*** Stage 2 load CSHARP");
            // Create the mission group off the ServerGroup

            sGlobal["$instantGroup"] = "ServerGroup";


            // Make sure the mission exists
            string file = sGlobal["$Server::MissionFile"];
            if (!Util.isFile(file))
                sGlobal["$Server::LoadFailMsg"] = "Could not find mission " + file;
            else
                {
                // Calculate the mission CRC.  The CRC is used by the clients
                // to caching mission lighting.
                iGlobal["$missionCRC"] = Util.getFileCRC(file);

                //Looked at making this one a dll direct call, doesn't appear
                //it can be easily converted.
                // Exec the mission.  The MissionGroup (loaded components) is added to the ServerGroup
                Util.exec(console.GetVarString("$Server::MissionFile"), false, false);

                if (!"MissionGroup".isObject())
                    sGlobal["$Server::LoadFailMsg"] = "No 'MissionGroup' found in mission " + file;
                }
            if (sGlobal["$Server::LoadFailMsg"] != string.Empty)
                {
                // Inform clients that are already connected
                foreach (GameConnection client in ClientGroup)
                    message.MessageClient(client, "MsgLoadFailed",
                        sGlobal["$Server::LoadFailMsg"]);
                return;
                }
            // Set mission name.


            if ("theLevelInfo".isObject())
                sGlobal["$Server::MissionName"] = ((LevelInfo)"theLevelInfo")["levelName"];


            // Mission cleanup group.  This is where run time components will reside.  The MissionCleanup
            // group will be added to the ServerGroup.

            SimSet missioncleanup = new ObjectCreator("SimGroup", "MissionCleanup").Create();
            // Make the MissionCleanup group the place where all new objects will automatically be added.
            sGlobal["$instantGroup"] = missioncleanup;


            // Create the Game object
            game.createGame();


            console.pathOnMissionLoadDone();

            // Mission loading done...
            console.warn("*** Mission loaded");

            bGlobal["$missionRunning"] = true;

            // Start all the clients in the mission
            foreach (GameConnection client in ClientGroup)
                client.loadMission();


            game.onMissionLoaded();
            }

        public virtual void EndMission()
            {
            if (!"MissionGroup".isObject())
                return;

            console.print("*** ENDING MISSION");
            // Inform the game code we're done.


            // Inform the game code we're done.
            game.onMissionEnded();


            // Inform the clients
            foreach (GameConnection client in ClientGroup)
                {
                client.endMission();
                client.resetGhosting();
                client.clearPaths();
                }

            if ("MissionGroup".isObject())
                "MissionGroup".delete();


            if ("MissionCleanup".isObject())
                "MissionCleanup".delete();

            sGlobal["$instantGroup"] = "ServerGroup";

            console.clearServerPaths();
            }

        public virtual void ResetMission()
            {
            console.print("*** MISSION RESET");
            // Remove any temporary mission objects


            if ("MissionCleanup".isObject())
                "MissionCleanup".delete();

            sGlobal["$instantGroup"] = "ServerGroup";

            SimSet MissionCleanup = new ObjectCreator("SimGroup", "MissionCleanup").Create();

            sGlobal["$instantGroup"] = MissionCleanup;

            console.clearServerPaths();

            // Recreate the Game object

            game.createGame();


            Util.pathOnMissionLoadDone();


            // Allow the Game object to reset the mission
            game.onMissionReset();
            }

        public virtual void onGameDurationEnd()
            {
            if (bGlobal["$Game::Duration"] && !EditorIsActive() && !GuiEditorIsActive())
                cycleGame();
            }

        public virtual void cycleGame()
            {
            if (((ScriptObject)"Game")["allowCycling"].AsBool())
                {
                if (!bGlobal["$Game::Cycling"])
                    {
                    bGlobal["$Game::Cycling"] = true;
                    iGlobal["$Game::Schedule"] = Util._schedule("0", "0", "onCycleExec");
                    }
                }
            else
                {
                // We're done with the whole game
                missionLoad.EndMission();
                // Destroy server to remove all connected clients after they've seen the
                // end game GUI.
                Util._schedule((iGlobal["$Game::EndGamePause"] * 1000).AsString(), "0", "gameCoreDestroyServer",
                    sGlobal["$Server::Session"]);
                }
            }

        public virtual void gameCoreDestroyServer(string serverSession)
            {
            if (serverSession == sGlobal["$Server::Session"])
                {
                if ("LocalClientConnection".isObject())
                    console.Call("disconnect");
                else
                    server.destroyServer();
                }
            }

        public virtual void onCycleExec()
            {
            missionLoad.EndMission();
            iGlobal["$Game::Schedule"] = Util._schedule(
                (iGlobal["$Game::EndGamePause"] * 1000).AsString(), "0", "onCyclePauseEnd");
            }

        public virtual void onCyclePauseEnd()
            {
            bGlobal["$Game::Cycling"] = false;
            // Just restart the missions for now.
            missionLoad.loadMission(sGlobal["$Server::MissionFile"], false);
            }

        public virtual void serverCmdMissionStartPhase1Ack(GameConnection client, int seq)
            {
            // Make sure to ignore calls from a previous mission load
            if (seq != iGlobal["$missionSequence"] || !bGlobal["$MissionRunning"])
                return;
            if (client["currentPhase"].AsDouble() != 0.0)
                return;

            client["currentPhase"] = "1";
            // Start with the CRC

            client.setMissionCRC(iGlobal["$missionCRC"]);

            // Send over the datablocks...
            // OnDataBlocksDone will get called when have confirmation
            // that they've all been received.
            console.print("Transmitting Datablocks");
            client.transmitDataBlocks(iGlobal["$missionSequence"]);
            }

        public virtual void serverCmdMissionStartPhase2CacheAck(GameConnection client)
            {
            client["currentPhase"] = "1.5";
            }

        public virtual void serverCmdMissionStartPhase2Ack(GameConnection client, string seq, PlayerData playerDB)
            {
            // Make sure to ignore calls from a previous mission load
            if (seq != sGlobal["$missionSequence"] || !bGlobal["$MissionRunning"])
                return;
            if (client["currentPhase"].AsDouble() != 1.5)
                return;

            client["currentPhase"] = "2";
            // Set the player datablock choice

            client["playerDB"] = playerDB;

            // Update mod paths, this needs to get there before the objects.
            client.transmitPaths();

            // Start ghosting objects to the client
            client.activateGhosting();
            }

        public virtual void serverCmdMissionStartPhase3Ack(GameConnection client, string seq)
            {
            if (seq != sGlobal["$missionSequence"] || !bGlobal["$MissionRunning"])
                return;
            if (client["currentPhase"].AsDouble() != 2.0)
                return;

            client["currentPhase"] = "3";
            // Server is ready to drop into the game

            if (iGlobal["$Pref::Server::MinPlayers"] > 1)

                console.Call("PlayerReady", new string[] { client });
            else
                {
                client.startMission();
                client.onClientEnterGame();
                }
            }

        public static bool EditorIsActive()
            {
            return ("EditorGui".isObject() && ((GuiCanvas)"Canvas").getContent() == "EditorGui".getID());
            }

        public static bool GuiEditorIsActive()
            {
            return ("GuiEditorGui".isObject() && ((GuiCanvas)"Canvas").getContent() == "GuiEditorGui".getID());
            }
        }
    }
