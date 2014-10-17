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

using System.Collections.Generic;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game
{
    /// <summary>
    /// This class serves as the default code for the game code.
    /// this file should not be modified, but instead inherited and assigned to _gameBase member variable inside game.cs.
    /// </summary>
    public class gameBase : pInvokes
    {

        public virtual void initGame()
        {
            // Game duration in secs, no limit if the duration is set to 0
            iGlobal["$Game::Duration"] = 20*60;

            // When a client score reaches this value, the game is ended.
            iGlobal["$Game::EndGameScore"] = 30;

            // Pause while looking over the end game screen (in secs)
            iGlobal["$Game::EndGamePause"] = 10;
        }

        public virtual void loadDatablockFiles(List<string> datablockFiles, bool recurse)
        {
            if (recurse)
                {
                game.recursiveLoadDatablockFiles(datablockFiles, 9999);
                return;
                }
            int count = datablockFiles.Count;
            for (int i = 0; i < count; i++)
                {
                string file = datablockFiles[i];
                if (!Util.isFile(file))
                    continue;
                Util.exec(file, false, false);
                }
        }

        public virtual void recursiveLoadDatablockFiles(List<string> datablockFiles, int previousErrors)
        {
            List<string> badDatablocks = new List<string>();
            int newerrors = 0;
            foreach (string file in datablockFiles)
                {
                if (!Util.isFile(file))
                    {
                    Util._echo("Did not find '" + file + "'.");
                    continue;
                    }
                iGlobal["$Con::objectCopyFailures"] = 0;
                Util.exec(file, false, false);
                if (iGlobal["$Con::objectCopyFailures"] <= 0)
                    continue;
                badDatablocks.Add(file);
                newerrors++;
                }
            if (newerrors != previousErrors)
                game.recursiveLoadDatablockFiles(badDatablocks, newerrors);
        }

        public virtual void onServerCreated()
        {
            // Server::GameType is sent to the master server.
            // This variable should uniquely identify your game and/or mod.
            sGlobal["$Server::GameType"] = sGlobal["$appName"];

            // Server::MissionType sent to the master server.  Clients can
            // filter servers based on mission type.
            sGlobal["$Server::MissionType"] = "Deathmatch";

            // GameStartTime is the sim time the game started. Used to calculated
            // game elapsed time.
            iGlobal["$Game::StartTime"] = 0;

            // Create the server physics world.
            Util.physicsInitWorld("server");

            // Load up any objects or datablocks saved to the editor managed scripts
            List<string> datablockFiles = new List<string>();

            datablockFiles.Add("art/particles/managedParticleData.cs");
            datablockFiles.Add("art/particles/managedParticleEmitterData.cs");
            datablockFiles.Add("art/decals/managedDecalData.cs");
            datablockFiles.Add("art/datablocks/managedDatablocks.cs");
            datablockFiles.Add("art/forest/managedItemData.cs");
            datablockFiles.Add("art/datablocks/datablockExec.cs");
            game.loadDatablockFiles(datablockFiles, true);

            //Todo This is where ScriptExec usually is
            ScriptExec();

            // Keep track of when the game started
            dGlobal["$Game::StartTime"] = dGlobal["$Sim::Time"];
        }

        public virtual void ScriptExec()
        {
            iGlobal["$Camera::movementSpeed"] = 40;

            // Respawntime is the amount of time it takes for a static "auto-respawn"
            // object, such as an ammo box or weapon, to re-appear after it's been
            // picked up.  Any item marked as "static" is automaticlly respawned.
            iGlobal["$Item::RespawnTime"] = 30*1000;
            // Poptime represents how long dynamic items (those that are thrown or
            // dropped) will last in the world before being deleted.
            iGlobal["$Item::PopTime"] = 30*1000;

            iGlobal["$WeaponSlot"] = 0;

            // Timeouts for corpse deletion.
            iGlobal["$CorpseTimeoutValue"] = 45*1000;
            // Respawntime is the amount of time it takes for a static "auto-respawn"
            // turret to re-appear after it's been picked up.  Any turret marked as "static"
            // is automaticlly respawned.
            iGlobal["$TurretShape::RespawnTime"] = 30*1000;

            // DestroyedFadeDelay is the how long a destroyed turret sticks around before it
            // fades out and is deleted.
            iGlobal["$TurretShape::DestroyedFadeDelay"] = 5*1000;
        }

        public virtual void onServerDestroyed()
        {
            // This function is called as part of a server shutdown.
            Util.physicsDestroyWorld("server");
            // Clean up the GameCore package here as it persists over the
            // life of the server.

            if (Util.isPackage("GameCore"))
                Util.deactivatePackage("GameCore");
        }

        public virtual void endGame()
        {
            if (!bGlobal["$Game::Running"])
                {
                console.error("endGame: No game running.");
                return;
                }
            // Stop any game timers
            Util.cancel(iGlobal["$Game::Schedule"]);

            AI.AI.deleteAI();

            foreach (GameConnection client in ClientGroup)
                console.commandToClient(client, "GameEnd", new[] {sGlobal["$Game::EndGamePause"]});

            bGlobal["$Game::Running"] = false;
        }

        public virtual void onMissionEnded()
        {
            Util.physicsStopSimulation("server");
            game.endGame();
            Util.cancel(iGlobal["$Game::Schedule"]);
            bGlobal["$Game::Running"] = false;
            bGlobal["$Game::Cycling"] = false;
        }

        public virtual void onMissionLoaded()
        {
            //startGame();
            Server.game.initGameVars();

            ScriptObject game = "Game";
            sGlobal["$Game::Duration"] = game["duration"];
            sGlobal["$Game::EndGameScore"] = game["endgameScore"];
            sGlobal["$Game::EndGamePause"] = game["endgamePause"];

            Util.physicsStartSimulation("server");
            Server.game.startGame();
        }

        public virtual void startGame()
        {
            if (bGlobal["$Game::Running"])
                {
                Util._error("startGame: End the game first!");
                return;
                }
            // Inform the client we're starting up
            foreach (GameConnection client in ClientGroup)
                {
                console.commandToClient(client, "GameStart");
                client["score"] = "0";
                client["kills"] = "0";
                client["deaths"] = "0";
                }

            if (bGlobal["$Game::Duration"])
                iGlobal["$Game::Schedule"] = ((ScriptObject) "Game").schedule((iGlobal["$Game::Duration"]*1000).AsString(), "onGameDurationEnd");

            bGlobal["$Game::Running"] = true;
        }

        public virtual void initGameVars()
        {
            //-----------------------------------------------------------------------------
            // What kind of "player" is spawned is either controlled directly by the
            // SpawnSphere or it defaults back to the values set here. This also controls
            // which SimGroups to attempt to select the spawn sphere's from by walking down
            // the list of SpawnGroups till it finds a valid spawn object.
            //-----------------------------------------------------------------------------
            sGlobal["$Game::DefaultPlayerClass"] = "Player";
            sGlobal["$Game::DefaultPlayerDataBlock"] = "DefaultPlayerData";
            sGlobal["$Game::DefaultPlayerSpawnGroups"] = "PlayerSpawnPoints PlayerDropPoints";

            //-----------------------------------------------------------------------------
            // What kind of "camera" is spawned is either controlled directly by the
            // SpawnSphere or it defaults back to the values set here. This also controls
            // which SimGroups to attempt to select the spawn sphere's from by walking down
            // the list of SpawnGroups till it finds a valid spawn object.
            //-----------------------------------------------------------------------------
            sGlobal["$Game::DefaultCameraClass"] = "Camera";
            sGlobal["$Game::DefaultCameraDataBlock"] = "Observer";
            sGlobal["$Game::DefaultCameraSpawnGroups"] = "CameraSpawnPoints PlayerSpawnPoints PlayerDropPoints";

            // Set the gameplay parameters
            ScriptObject game = "Game";

            game["duration"] = sGlobal["$Game::Duration"];
            game["endgameScore"] = sGlobal["$Game::EndGameScore"];
            game["endgamePause"] = sGlobal["$Game::EndGamePause"];
            game["allowCycling"] = false.AsString(); // Is mission cycling allowed?
        }

        public virtual ScriptObject createGame()
        {
            if ("theLevelInfo".isObject())
                sGlobal["$Server::MissionType"] = ((LevelInfo) "theLevelInfo")["gameType"];
            else
                sGlobal["$Server::MissionType"] = string.Empty;

            if (sGlobal["$Server::MissionType"] == string.Empty)
                sGlobal["$Server::MissionType"] = "Deathmatch";

            return new ObjectCreator("ScriptObject", "Game").Create();
        }

        public virtual void onMissionReset()
        {
        }
    }
}