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

using System.Linq;
using Winterleaf.Demo.Full.Dedicated.Models.User.CustomObjects.Utilities;
using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.Game
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
            foreach (GameConnection client in
                ClientGroup.Where(client => !((GameConnection) client).isAIControlled()))
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
                    message.MessageClient(client, "MsgLoadFailed", sGlobal["$Server::LoadFailMsg"]);
                return;
                }
            // Set mission name.

            if ("theLevelInfo".isObject())
                sGlobal["$Server::MissionName"] = ((LevelInfo) "theLevelInfo")["levelName"];

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
            if (((ScriptObject) "Game")["allowCycling"].AsBool())
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
                Util._schedule((iGlobal["$Game::EndGamePause"]*1000).AsString(), "0", "gameCoreDestroyServer", sGlobal["$Server::Session"]);
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
            iGlobal["$Game::Schedule"] = Util._schedule((iGlobal["$Game::EndGamePause"]*1000).AsString(), "0", "onCyclePauseEnd");
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

                console.Call("PlayerReady", new string[] {client});
            else
                {
                client.startMission();
                client.onClientEnterGame();
                }
        }

        public static bool EditorIsActive()
        {
            return ("EditorGui".isObject() && ((GuiCanvas) "Canvas").getContent() == "EditorGui".getID());
        }

        public static bool GuiEditorIsActive()
        {
            return ("GuiEditorGui".isObject() && ((GuiCanvas) "Canvas").getContent() == "GuiEditorGui".getID());
        }
    }
}