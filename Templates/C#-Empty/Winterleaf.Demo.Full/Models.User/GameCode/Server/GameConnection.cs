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
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    partial class GameConnection
    {
        #region Static Variables

        #endregion

        #region Overrides

        public override void onDrop(string disconnectReason)
        {
            onClientLeaveGame();

            RemoveFromServerGuidList(this["guid"]);

            console.removeTaggedString(this["playerName"]);

            console.print(string.Format("CDROP: {0} {1}", this, this.getAddress()));

            iGlobal["$Server::PlayerCount"] -= 1;

            if (iGlobal["$Server::PlayerCount"] == 0 && bGlobal["$Server::Dedicated"])
                Util._schedule("0", "0", "resetServerDefaults");
        }

        /// <summary>
        ///-----------------------------------------------------------------------------
        /// This script function is called before a client connection
        /// is accepted.  Returning "" will accept the connection,
        /// anything else will be sent back as an error to the client.
        /// All the connect args are passed also to onConnectRequest
        ///
        /// NOTE: Need to fallback to Con::execute() as IMPLEMENT_CALLBACK does not 
        /// support variadic functions.
        ///todo research this a bit, from what I read this function can take up to 16 params.  It's a console execute because of variable args.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="netAddress"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [ConsoleInteraction(true)]
        public virtual string onConnectRequest(GameConnection client, string netAddress, string name)
        {
            console.print(string.Format("Connect request from:{0}", netAddress));
            return iGlobal["$Server::PlayerCount"] >= iGlobal["$Pref::Server::MaxPlayers"] ? "CR_SERVERFULL" : "";
        }

        /// <summary>
        /// NOTE: Need to fallback to Con::execute() as IMPLEMENT_CALLBACK does not  support variadic functions.
        /// </summary>
        /// <param name="name"></param>
        [ConsoleInteraction(true)]
        public virtual void onConnect(string name)
        {
            // Send down the connection error info, the client is
            // responsible for displaying this message if a connection
            // error occures.

            // Simulated client lag for testing...
            // %client.setSimulatedNetParams(0.1, 30);

            // Get the client's unique id:
            // %authInfo = %client.getAuthInfo();
            // %client.guid = getField( %authInfo, 3 );

            this["guid"] = "0";

            AddToServerGuidList(this["guid"]);
            // Set admin status
            if (this.getAddress() == "local")
                {
                this["isAdmin"] = true.AsString();
                this["isSuperAdmin"] = true.AsString();
                }
            else
                {
                this["isAdmin"] = false.AsString();
                this["isSuperAdmin"] = false.AsString();
                }
            // Save client preferences on the connection object for later use.

            console.print("CADD: " + this + " " + this.getAddress());

            // If the mission is running, go ahead download it to the client
            if (bGlobal["$missionRunning"])
                loadMission();

            iGlobal["$Server::PlayerCount"] += 1;
        }

        #endregion

        #region Enter/Leave Mission Area

        public virtual void onLeaveMissionArea()
        {
        }

        public virtual void onEnterMissionArea()
        {
        }

        #endregion

        #region Camera/Player Creation

        #region Camera Creation

        public virtual string pickCameraSpawnPoint(string spawnGroups)
        {
            SimObject spawnpoint = null;
            String[] lspawngroups = spawnGroups.Split(' ');

            foreach (SimSet group in lspawngroups)
                {
                if (!group.isObject())
                    continue;
                spawnpoint = group.getRandom();
                if (spawnpoint.isObject())
                    return spawnpoint;
                }
            SpawnSphere DefaultCameraSpawnSphere = "DefaultCameraSpawnSphere";
            if (!DefaultCameraSpawnSphere.isObject())
                {
                ObjectCreator spawn = new ObjectCreator("SpawnSphere", "DefaultCameraSpawnSphere");
                spawn["dataBlock"] = "SpawnSphereMarker";
                spawn["spawnClass"] = sGlobal["$Game::DefaultCameraClass"];
                spawn["spawnDatablock"] = sGlobal["$Game::DefaultCameraDataBlock"];
                SpawnSphere spawnobj = spawn.Create();

                ((SimSet) "MissionCleanup").pushToBack(spawnobj);
                }

            return DefaultCameraSpawnSphere;
        }

        public virtual void spawnCamera(string spawnPoint)
        {
            Camera camera = this["camera"];

            //string camera = console.GetVarString(thisobj + ".camera");

            // Set the control object to the default camera
            if (!camera.isObject())
                {
                camera = Util.spawnObject(sGlobal["$Game::DefaultCameraClass"], sGlobal["$Game::DefaultCameraDataBlock"]);
                this["camera"] = camera;
                }

            // If we have a camera then set up some properties
            if (!camera.isObject())
                return;

            ((SimSet) "MissionCleanup").pushToBack(camera);

            camera.scopeToClient(this);

            this.setControlObject(camera);

            if (spawnPoint == string.Empty)
                return;

            // Attempt to treat %spawnPoint as an object

            if (Util.getWordCount(spawnPoint) == 1 && console.isObject(spawnPoint))
                camera.setTransform(((SpawnSphere) spawnPoint).getTransform());
            else
                camera.setTransform(new TransformF(spawnPoint));
        }

        #endregion

        #endregion

        #region Guid Registration

        public virtual void AddToServerGuidList(string guid)
        {
            int count = Util.getFieldCount(sGlobal["$Server::GuidList"]);
            for (int i = 0; i < count; i++)
                {
                if (Util.getField(console.GetVarString("$Server::GuidList"), i) == guid)
                    return;
                }
            sGlobal["$Server::GuidList"] = sGlobal["$Server::GuidList"] == string.Empty ? guid : sGlobal["$Server::GuidList"];
        }

        public virtual void RemoveFromServerGuidList(string guid)
        {
            int count = Util.getFieldCount(sGlobal["$Server::GuidList"]);
            for (int i = 0; i < count; i++)
                {
                if (Util.getField(sGlobal["$Server::GuidList"], i) != guid)
                    continue;
                sGlobal["$Server::GuidList"] = Util.removeField(sGlobal["$Server::GuidList"], i);
                return;
                }
        }

        #endregion

        #region Messaging

        [ConsoleInteraction(true)]
        public virtual void spamMessageTimeout()
        {
            if (this["spamMessageCount"].AsInt() > 0)
                this["spamMessageCount"] = (this["spamMessageCount"].AsInt() - 1).AsString();
        }

        [ConsoleInteraction(true)]
        public virtual void spamReset()
        {
            this["isSpamming"] = false.AsString();
        }

        #endregion

        #region MissionDownload

        public override void onDataBlocksDone(uint sequence)
        {
            // Make sure to ignore calls from a previous mission load
            if (sequence != iGlobal["$missionSequence"])
                return;
            if (this["currentPhase"].AsInt() != 1)
                return;
            this["currentPhase"] = "1.5";
            // On to the next phase
            if (this.isObject())
                console.commandToClient(this, "MissionStartPhase2", new[] {sGlobal["$missionSequence"], sGlobal["$Server::MissionFile"]});
        }

        /// <summary>
        /// Not sure where this gets called from, can't find reference in C++ or TS
        /// </summary>
        /// <param name="client"></param>
        [ConsoleInteraction(true)]
        public void clientWantsGhostAlwaysRetry(GameConnection client)
        {
            if (bGlobal["$MissionRunning"])
                client.activateGhosting();
        }

        public override void onGhostAlwaysObjectsReceived()
        {
            console.commandToClient(this, "MissionStartPhase3", new[] {sGlobal["$missionSequence"], sGlobal["$Server::MissionFile"]});
        }

        #endregion

        [ConsoleInteraction(true)]
        public virtual void loadMission()
        {
            // Send over the information that will display the server info
            // when we learn it got there, we'll send the data blocks

            this["currentPhase"] = "0";

            if (this.isAIControlled())
                this.onClientEnterGame();
            else
                {
                if (this.isObject())
                    console.commandToClient(this, "MissionStartPhase1", new[] {sGlobal["$missionSequence"], sGlobal["$Server::MissionFile"], sGlobal["MissionGroup.musicTrack"], sGlobal["$ServerDatablockCacheCRC"]});
                console.print("*** Sending mission load to client: " + sGlobal["$Server::MissionFile"]);
                }
        }

        [ConsoleInteraction(true)]
        public virtual void startMission()
        {
            // Inform the client the mission starting

            console.commandToClient(this, "missionstart", new[] {sGlobal["$missionSequence"]});
        }

        [ConsoleInteraction(true)]
        public virtual void endMission()
        {
            // Inform the client the mission is done.  Note that if this is
            // called as part of the server destruction routine, the client will
            // actually never see this comment since the client connection will
            // be destroyed before another round of command processing occurs.
            // In this case, the client will only see the disconnect from the server
            // and should manually trigger a mission cleanup.
            //Util._commandToClient(this, "MissionEnd", sGlobal["$missionSequence"]);
            console.commandToClient(this, "MissionEnd", new[] {sGlobal["$missionSequence"]});
        }

        [ConsoleInteraction(true)]
        public virtual void syncClock(string time)
        {
            console.commandToClient(this, "syncClock", new[] {time});
        }

        [ConsoleInteraction(true)]
        public virtual void onClientEnterGame()
        {
            Util._error("Client " + this.ID + " has connected.");
            // Sync the client's clocks to the server's

            double simtime = dGlobal["$Sim::Time"];

            double starttime = dGlobal["$Game::StartTime"];

            double result = simtime - starttime;

            console.commandToClient(this, "SyncClock", new[] {result.AsString()});

            // Find a spawn point for the camera
            // This function currently relies on some helper functions defined in
            // core/scripts/server/spawn.cs. For custom spawn behaviors one can either
            // override the properties on the SpawnSphere's or directly override the
            // functions themselves.
            string cameraSpawnPoint = pickCameraSpawnPoint(sGlobal["$Game::DefaultCameraSpawnGroups"]);
            //%cameraSpawnPoint = pickCameraSpawnPoint($Game::DefaultCameraSpawnGroups);
            // Spawn a camera for this client using the found %spawnPoint

            spawnCamera(cameraSpawnPoint);
        }

        [ConsoleInteraction(true)]
        public virtual void onClientLeaveGame()
        {
            if (((Camera) this["camera"]).isObject())
                ((Camera) this["camera"]).delete();

            if (((Player) this["player"]).isObject())
                ((Player) this["player"]).delete();
        }

        [ConsoleInteraction(true)]
        public virtual void onDeath(GameBase sourceobject, GameConnection sourceclient, string damagetype, string damloc)
        {
        }
    }
}