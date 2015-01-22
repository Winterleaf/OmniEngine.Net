﻿// WinterLeaf Entertainment
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
using System.Collections.Generic;
using System.Linq;
using Winterleaf.Demo.Full.Dedicated.Models.User.CustomObjects.Utilities;
using Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.Extendable
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

            message.MessageAllExcept(this, "-1", "MsgClientDrop", console.ColorEncode(@"\c1%1 has left the game."), this["playerName"], this);

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
            message.MessageClient(this, "MsgConnectionError", "", sGlobal["$Pref::Server::ConnectionError"]);
            // Send mission information to the client
            sendLoadInfoToClient();
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

            this["gender"] = "Male";
            this["armor"] = "Light";
            this["race"] = "human";
            this["skin"] = console.addTaggedString("base");

            setPlayerName(name);
            this["team"] = "";
            this["score"] = "0";

            console.print("CADD: " + this + " " + this.getAddress());

            // If the mission is running, go ahead download it to the client
            if (bGlobal["$missionRunning"])
                loadMission();
            else if (sGlobal["$Server::LoadFailMsg"] != "")
                message.MessageClient(this, "MsgLoadFailed", sGlobal["$Server::LoadFailMsg"]);

            iGlobal["$Server::PlayerCount"] += 1;
        }

        #endregion

        #region Score Keeping

        public virtual void IncKills(GameConnection client, string kill, string dontmessageall)
        {
            if (!console.isObject(client))
                return;
            console.SetVar(client + ".kills", console.GetVarInt(client + ".kills") + int.Parse(kill));
            if (dontmessageall == "0")
                message.MessageAll("MsgClientScoreChanged", "", console.GetVarString(client + ".score"), console.GetVarString(client + ".kills"), console.GetVarString(client + "deaths"), client);
        }

        public virtual void IncDeaths(GameConnection client, string death, string dontmessageall)
        {
            if (!console.isObject(client))
                return;
            console.SetVar(string.Format("{0}.deaths", client), console.GetVarInt(string.Format("{0}.deaths", client)) + int.Parse(death));
            if (dontmessageall == "0")
                message.MessageAll("MsgClientScoreChanged", "", console.GetVarString(client + ".score"), console.GetVarString(client + ".kills"), console.GetVarString(client + ".deaths"), client);
        }

        public virtual void IncScore(GameConnection client, string score, string dontmessageall)
        {
            if (!console.isObject(client))
                return;
            console.SetVar(client + ".score", console.GetVarInt(client + ".score") + int.Parse(score));
            if (dontmessageall == "0")
                message.MessageAll("MsgClientScoreChanged", "", console.GetVarString(client + ".score"), console.GetVarString(client + "kills"), console.GetVarString(client + ".deaths"), client);
        }

        public virtual int GetScore(GameConnection client)
        {
            return client["score"].AsInt();
        }

        public virtual int GetKills(GameConnection client)
        {
            return client["kills"].AsInt();
        }

        public virtual int GetDeaths(GameConnection client)
        {
            return client["deaths"].AsInt();
        }

        #endregion

        #region Enter/Leave Mission Area

        public virtual void onLeaveMissionArea()
        {
            message.MessageClient(this, "MsgClientJoin", pInvokes.console.ColorEncode(@"\c2Now leaving the mission area!"));
        }

        public virtual void onEnterMissionArea()
        {
            message.MessageClient(this, "MsgClientJoin", pInvokes.console.ColorEncode(@"\c2Now entering the mission area!"));
        }

        #endregion

        #region Camera/Player Creation

        #region Player Creation

        public virtual TransformF PointInSpawnSphere(Player objectToSpawn, SpawnSphere spawnSphere)
        {
            bool spawnLocationFound = false;
            int attemptsToSpawn = 0;

            TransformF spherLocationP3F = new TransformF();

            while (!spawnLocationFound && attemptsToSpawn < 5)
                {
                spherLocationP3F = spawnSphere.getTransform();

                Random r = new Random();

                float angleY = (float) tMath.mDegToRad((r.NextDouble()*100)*tMath.M_2PI_F);
                float angleXZ = (float) tMath.mDegToRad((r.NextDouble()*100)*tMath.M_2PI_F);

                int radius = spawnSphere["radius"].AsInt();
                spherLocationP3F.mPositionX += (float) (Math.Cos(angleY)*Math.Sin(angleXZ)*(r.Next(radius*-1, radius)));
                spherLocationP3F.mPositionY += (float) (Math.Cos(angleXZ)*(r.Next(radius*-1, radius)));
                spawnLocationFound = true;

                // Now have to check that another object doesn't already exist at this spot.
                // Use the bounding box of the object to check if where we are about to spawn in is
                // clear.

                TransformF boundingboxsize = new TransformF(((SimDataBlock) objectToSpawn.getDataBlock())["boundingBox"]);
                float searchRadius = boundingboxsize.mPositionX;
                float boxSizeY = boundingboxsize.mPositionY;
                if (boxSizeY > searchRadius)
                    searchRadius = boxSizeY;
                List<UInt32> objectsfound = console.ContainerRadiusSearch(spherLocationP3F.GetPosition(), searchRadius, (UInt32) SceneObjectTypesAsUint.PlayerObjectType, false);
                if (objectsfound.Count > 0)
                    spawnLocationFound = false;

                attemptsToSpawn++;
                }
            if (!spawnLocationFound)
                {
                spherLocationP3F = spawnSphere.getTransform();
                console.warn("WARNING: Could not spawn player after 5 times");
                }
            return spherLocationP3F;
        }

        public virtual void setPlayerName(string name)
        {
            this["sendGuid"] = "0";

            // Minimum length requirements
            name = Util.strToPlayerName(name).Trim();
            if (name.Length < 3)
                name = "Poser";

            // Make sure the alias is unique, we'll hit something eventually
            if (!IsNameUnique(name))
                {
                bool isUnique = false;
                string nametry = "NotSet";
                for (int suffix = 1; !isUnique; suffix++)
                    {
                    nametry = name + "." + suffix;
                    isUnique = IsNameUnique(nametry);
                    }
                name = nametry;
                }
            this["nameBase"] = name;
            this["playerName"] = console.addTaggedString(console.ColorEncode(string.Format(@"\cp\c8{0}\co", name)));
        }

        public virtual bool IsNameUnique(string name)
        {
            foreach (GameConnection client in ClientGroup)
                {
                string rawName = "";

                if (client["playerName"].Trim().Length > 0)
                    rawName = Util.stripChars(Util.detag(console.getTaggedString(client["playerName"])), console.ColorEncode(@"\cp\co\c6\c8\c9"));
                if (name == rawName)
                    return false;
                }
            return true;
        }

        public virtual string pickPlayerSpawnPoint(string spawnGroups)
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

            SpawnSphere DefaultPlayerSpawnSphere = null;

            DefaultPlayerSpawnSphere = "DefaultPlayerSpawnSphere";

            if (DefaultPlayerSpawnSphere.isObject())
                {
                ObjectCreator spawn = new ObjectCreator("SpawnSphere", "DefaultPlayerSpawnSphere");
                spawn["dataBlock"] = "SpawnSphereMarker";
                spawn["spawnClass"] = sGlobal["$Game::DefaultPlayerClass"];
                spawn["spawnDatablock"] = sGlobal["$Game::DefaultPlayerDataBlock"];
                SpawnSphere spawnid = spawn.Create();
                ((SimSet) "MissionCleanup").pushToBack(spawnid);
                }

            return DefaultPlayerSpawnSphere;
        }

        public virtual bool SpawnPlayer(string spawnpoint, bool nocontrol)
        {
            Player player = this["player"];

            if (player.isObject())
                {
                console.error("Attempting to create a player for a client that already has one!");
                return false;
                }

            if ((spawnpoint.Split(' ').GetUpperBound(0) == 0) && (spawnpoint.isObject()))
                {
                // Attempt to treat %spawnPoint as an object
                string spawnclass = sGlobal["$Game::DefaultPlayerClass"];
                string spawndatablock = sGlobal["$Game::DefaultPlayerDataBlock"];

                SimObject ospawnpoint = spawnpoint;

                // Overrides by the %spawnPoint
                if (ospawnpoint["spawnClass"] != "")
                    {
                    spawnclass = ospawnpoint["spawnClass"];
                    //spawndatablock = ospawnpoint["spawnDataBlock"];
                    }

                else if (ospawnpoint["spawnDatablock"] != "")
                    {
                    // This may seem redundant given the above but it allows
                    // the SpawnSphere to override the datablock without
                    // overriding the default player class
                    spawndatablock = ospawnpoint["spawnDatablock"];
                    }
                string spawnproperties = ospawnpoint["spawnProperties"];
                string spawnScript = ospawnpoint["spawnScript"];

                // Spawn with the engine's Sim::spawnObject() function
                player = Util.spawnObject(spawnclass, spawndatablock, "", spawnproperties, spawnScript, typeof (Player).FullName);

                //player.TickCounterNotifyServer = true;
                //player.TickCounterAdd("TestCheck", 100);

                //player.TickNotifyBefore = true;
                //player.TickNotifyClient = true;
                //player.TickNotifyServer = true;
                //player.TickNotifyBefore = true;

                // If we have an object do some initial setup
                if (console.isObject(player))
                    {
                    // Pick a location within the spawn sphere.
                    player.setTransform(PointInSpawnSphere(player, (spawnpoint)));
                    }
                else
                    {
                    // If we weren't able to create the player object then warn the user
                    // When the player clicks OK in one of these message boxes, we will fall through
                    // to the "if (!isObject(%player))" check below.
                    if (console.GetVarString(spawndatablock).Trim() != "")
                        console.warn("Unable to create a player with class " + spawnclass + " and datablock " + spawndatablock + ".\n\nStarting as an Observer instead.");
                    else
                        console.warn("Unable to create a player with class " + spawnclass + ".\n\nStarting as an Observer instead.");
                    }
                }
            else
                {
                // Create a default player
                player = console.SpawnObject(sGlobal["$Game::DefaultPlayerClass"], sGlobal["$Game::DefaultPlayerDataBlock"], string.Empty, string.Empty, string.Empty);

                if (player.isMemberOfClass("Player"))
                    //if (SimObject.SimObject_isMemberOfClass(player, "Player"))
                    console.warn("Trying to spawn a class that does not derive from player!!!!!");
                // Treat %spawnPoint as a transform
                player.setTransform(new TransformF(spawnpoint));
                }

            // Update the default camera to start with the player
            if (!console.isObject(player))
                {
                this["spawnCamera"] = spawnpoint;
                return false;
                }

            ((SimSet) "MissionCleanup").pushToBack(player);
            // Update the default camera to start with the player

            // Store the client object on the player object for
            // future reference
            player["client"] = this;

            // If the player's client has some owned turrets, make sure we let them
            // know that we're a friend too.

            if (this["ownedTurrets"].AsInt() >= 1)
                {
                SimSet turrets = this["ownedTurrets"];
                for (uint i = 0; i < turrets.getCount(); i++)
                    ((AITurretShape) turrets.getObject(i)).addToIgnoreList(player);
                }

            player.setShapeName(this["playerName"]);

            SimDataBlock playerdata = player.getDataBlock();

            player.setEnergyLevel(playerdata["maxEnergy"].AsFloat());

            if (this["skin"] != string.Empty)
                {
                string availableSkins = playerdata["availableSkins"];
                foreach (GameConnection other in ClientGroup.Where(other => other != this))
                    {
                    availableSkins = availableSkins.Replace(console.GetVarString(other + ".skin"), " ");

                    availableSkins = availableSkins.Replace("  ", " ");
                    }
                List<string> availskin = availableSkins.Split('\t').ToList();
                if (availskin.Count > 0)
                    {
                    int r = new Random().Next(0, availskin.Count - 1);
                    this["skin"] = availskin[r];
                    }
                }

            player.setSkinName(this["skin"]);
            this["player"] = player;
            console.error("--->Player ID is " + player);

            SimObject control = null;
            if (console.GetVarString("$startWorldEditor") == "1")
                {
                control = this["camera"];
                Camera c = this["camera"];
                c.setMode("Fly");
                console.Call("EditorGui", "syncCameraGui");
                }
            else
                control = player;

            if (!nocontrol)
                this.setControlObject(control);

            int team = new Random().Next(1, 2);

            player.AddObjectTo_MobSearchGroup(team);

            message.MessageClient(this, "System", "Your on Team " + team);

            console.error(DateTime.Now + " --- PLAYER JOIN::Name '" + Util.StripMLControlChars(player.getShapeName()) + "'::ID '" + player + "'");
            return true;
        }

        public virtual void LoadOut(Player player)
        {
            player.clearWeaponCycle();

            player.setInventory("Ryder", 1);
            player.setInventory("RyderClip", player.maxInventory("RyderClip"));
            player.setInventory("RyderAmmo", player.maxInventory("RyderAmmo"));

            player.addToWeaponCycle("Ryder");

            player.setInventory("Lurker", 1);
            player.setInventory("LurkerClip", player.maxInventory("LurkerClip"));
            player.setInventory("LurkerAmmo", player.maxInventory("LurkerAmmo"));

            player.addToWeaponCycle("Lurker");

            player.setInventory("LurkerGrenadeLauncher", 1);
            player.setInventory("LurkerGrenadeAmmo", player.maxInventory("LurkerGrenadeAmmo"));

            player.addToWeaponCycle("LurkerGrenadeLauncher");

            player.setInventory("ProxMine", player.maxInventory("ProxMine"));

            player.addToWeaponCycle("ProxMine");

            player.setInventory("DeployableTurret", player.maxInventory("DeployableTurret"));
            player.addToWeaponCycle("DeployableTurret");

            SimDataBlock playerdatablock = player.getDataBlock();
            string junk = playerdatablock["mainWeapon.image"];

            player.mountImage(junk == string.Empty ? "LurkerWeaponImage" : junk, 0, true, string.Empty);

            //ShapeBase.mountImage(player, junk == "" ? junk : "LurkerWeaponImage", 0, true, "");
        }

        public virtual void preparePlayer()
        {
            string playerSpawnPoint = pickPlayerSpawnPoint(sGlobal["$Game::DefaultPlayerSpawnGroups"]);

            if (SpawnPlayer(playerSpawnPoint, false))

                LoadOut(this["player"]);
        }

        #endregion

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

        #region Ammo Hud

        public virtual void setAmmoAmountHud(int amount, int amountinClips)
        {
            if (console.isObject(this))
                // Util._commandToClient("SetAmmoAmountHud", amount.AsString(), amountinClips.AsString());
                console.commandToClient(this, "SetAmmoAmountHud", new[] {amount.AsString(), amountinClips.AsString()});
        }

        public virtual void refreshWeaponHud(int amount, string preview, string ret, string zoomRet, int amountInClips)
        {
            if (console.isObject(this))
                console.commandToClient(this, "RefreshWeaponHud", new[] {amount.AsString(), preview, ret, zoomRet, amountInClips.AsString()});
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
        public virtual void sendLoadInfoToClient()
        {
            LevelInfo theLevelInfo = "theLevelInfo";

            message.MessageClient(this, "MsgLoadInfo", string.Empty, theLevelInfo["levelName"]);

            for (int i = 0; theLevelInfo["desc[" + i + "]"] != string.Empty; i++)

                message.MessageClient(this, "MsgLoadDescripition", string.Empty, theLevelInfo["desc[" + i + "]"]);

            message.MessageClient(this, "MsgLoadInfoDone", string.Empty);
        }

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

            // Setup game parameters, the onConnect method currently starts
            // everyone with a 0 score.

            this["score"] = "0";
            this["kills"] = "0";
            this["deaths"] = "0";

            // weaponHUD

            this.refreshWeaponHud(0, string.Empty, string.Empty, string.Empty, 0);

            // Prepare the player object.

            preparePlayer();

            message.MessageClient(this, "MsgClientJoin", "Current Players: " + ClientGroup.Count);

            // Inform the client we've joined up
            message.MessageClient(this, "MsgClientJoin", @"\c2Welcome to the Torque demo app %1.", this["playerName"], this, this["sendGuid"], this["team"], this["score"], this["kills"], this["deaths"], this["isAiControlled"], this["isAdmin"], this["isSuperAdmin"]);

            //// Inform all the other clients of the new guy

            message.MessageAllExcept(this, "-1", "MsgClientJoin", @"\c1%1 joined the game.", this["playerName"], this, this["sendGuid"], this["team"], this["score"], this["kills"], this["deaths"], this["isAiControlled"], this["isAdmin"], this["isSuperAdmin"]);
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
            if (this.isObject())
                {
                if (this["ownedTurrets"] == string.Empty)
                    this["ownedTurrets"] = new ObjectCreator("SimSet").Create().AsString();

                SimSet simSet = this["ownedTurrets"];

                for (uint i = 0; i < simSet.getCount(); i++)
                    ((SimObject) simSet.getObject(i)).schedule("10", "delete");
                }

            // clear the weaponHUD
            this.refreshWeaponHud(0, string.Empty, string.Empty, string.Empty, 0);

            Player player = this["player"];

            // Clear out the name on the corpse
            player.setShapeName(string.Empty);

            // Update the numerical Health HUD

            //PlayerUpdateHealth(player);

            // Switch the client over to the death cam and unhook the player object.
            Camera camera = this["camera"];

            if (camera.isObject() && player.isObject())
                {
                camera.setMode("Corpse", player, string.Empty, string.Empty);
                //camera.call("setMode", "Corpse", player, string.Empty, string.Empty);
                this.setControlObject(camera);
                }
            else
                console.print("------------>Failed to Switch the client over to the death cam.");

            this["player"] = "0";

            // Display damage appropriate kill message
            string sendMsgFunction = "sendMsgClientKilled_" + damagetype;
            //if (!console.isFunction(sendMsgFunction))
            //    {
            //    sendMsgFunction = "sendMsgClientKilled_Default";
            //    }

            console.Call(sendMsgFunction, new string[] {"MsgClientKilled", this, sourceclient, damloc});
            // Dole out points and check for win
            if ((damagetype == "Suicide") || (sourceclient == this))
                {
                IncDeaths(this, "1", "1");
                IncScore(this, "-1", "0");
                }
            else
                {
                IncDeaths(this, "1", "0");
                IncScore(sourceclient, "1", "1");
                IncKills(sourceclient, "1", "0");
                }

            if (iGlobal["$Game::EndGameScore"] > 0 && sourceclient["kills"].AsInt() >= iGlobal["$Game::EndGameScore"])
                missionLoad.cycleGame();
        }
    }
}
