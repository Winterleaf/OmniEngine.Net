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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    public class missionDownload
    {
        private static List<string> MLoadinfo = new List<string>();

        [ConsoleInteraction(true)]
        public static void clientCmdMissionStartPhase1(string seq, string missionName, string musicTrack, string serverCRC)
        {
            GameConnection ServerConnection = "ServerConnection";
            pInvokes.Util._echo("*** New Mission: " + missionName);
            pInvokes.Util._echo("*** Phase 1: Download Datablocks & Targets");
            onMissionDownloadPhase1(missionName, musicTrack);
            pInvokes.sGlobal["$ServerDatablockCacheCRC"] = serverCRC;

            string name = missionName.Replace(" ", "");
            if (name.Contains("/"))
                name = name.Substring(name.LastIndexOf("/") + 1);
            if (name.Contains("."))
                name = name.Split('.')[0];

            pInvokes.sGlobal["$ServerDatablockCacheMissionName"] = "DBCaches/" + name + "DB.db";

            if (ServerConnection.callScript("LoadDatablocksFromFile", new[] {serverCRC}).AsBool())
                {
                pInvokes.console.print("Loaded Datablocks from file.");
                clientCmdMissionStartPhase2(seq, missionName, true);
                }
            else
                pInvokes.console.commandToServer("MissionStartPhase1Ack", new string[] {seq});
        }

        [ConsoleInteraction(true)]
        public static void onDataBlockObjectReceived(string index, string total)
        {
            onPhase1Progress((index.AsDouble()/total.AsDouble()).AsString());
        }

        [ConsoleInteraction(true)]
        public static void clientCmdMissionStartPhase2(string seq, string missionName, bool isLoadedFromFile = false)
        {
            onPhase1Complete();
            pInvokes.Util._echo("*** Phase 2: Download Ghost Objects");
            onMissionDownloadPhase2();

            //Push the client past the datablock transmition stage.
            if (isLoadedFromFile)
                pInvokes.console.commandToServer("MissionStartPhase2CacheAck");

            //Start next stage.
            pInvokes.console.commandToServer("MissionStartPhase2Ack", new string[] {seq, pInvokes.sGlobal["$pref::Player:PlayerDB"]});
        }

        [ConsoleInteraction(true)]
        public static void onGhostAlwaysStarted(string ghostCount)
        {
            pInvokes.sGlobal["$ghostCount"] = ghostCount;
            pInvokes.iGlobal["$ghostsRecvd"] = 0;
        }

        [ConsoleInteraction(true)]
        public static void onGhostAlwaysObjectReceived()
        {
            pInvokes.iGlobal["$ghostsRecvd"] = pInvokes.iGlobal["$ghostsRecvd"] + 1;
            onPhase2Progress((pInvokes.fGlobal["$ghostsRecvd"]/pInvokes.fGlobal["$ghostCount"]).AsString());
        }

        //
        //----------------------------------------------------------------------------
        //Phase 3
        //----------------------------------------------------------------------------

        [ConsoleInteraction(true)]
        public static void clientCmdMissionStartPhase3(string seq, string missionName)
        {
            onPhase2Complete();
            pInvokes.Util.StartClientReplication();
            pInvokes.Util.StartFoliageReplication();
            // Load the static mission decals.

            pInvokes.console.Call("decalManagerLoad", new string[] {missionName + ".decals"});

            pInvokes.Util._echo("*** Phase 3: Mission Lighting");
            pInvokes.sGlobal["$MSeq"] = seq;
            pInvokes.sGlobal["$Client::MissionFile"] = missionName;

            //Need to light the mission before we are ready.
            //The sceneLightingComplete function will complete the handshake
            //once the scene lighting is done.
            if (pInvokes.Util.lightScene("sceneLightingComplete", ""))
                {
                pInvokes.Util._echo("Lighting mission....");
                pInvokes.Util._schedule("1", "0", "updateLightingProgress");
                onMissionDownloadPhase3();
                pInvokes.bGlobal["$lightingMission"] = true;
                }
        }

        [ConsoleInteraction(true)]
        public static void updateLightingProgress()
        {
            onPhase3Progress(pInvokes.sGlobal["$SceneLighting::lightingProgress"]);
            if (pInvokes.bGlobal["$lightingMission"])
                pInvokes.iGlobal["$lightingProgressThread"] = pInvokes.Util._schedule("1", "0", "updateLightingProgress");
        }

        [ConsoleInteraction(true)]
        public static void sceneLightingComplete()
        {
            pInvokes.Util._echo("Mission lighting done");
            onPhase3Complete();
            //The is also the end of the mission load cycle.

            onMissionDownloadComplete();
            pInvokes.console.commandToServer("MissionStartPhase3Ack", new string[] {pInvokes.sGlobal["$MSeq"]});
        }

        //
        //----------------------------------------------------------------------------
        //Helper functions
        //----------------------------------------------------------------------------

        public static void connect(string server)
        {
            GameConnection conn = new ObjectCreator("ServerConnection").Create();
            ((SimGroup) "RootGroup").add(conn);
            conn.setConnectArgs(pInvokes.sGlobal["$pref::Player::Name"]);
            conn.setJoinPassword(pInvokes.sGlobal["$Client::Password"]);
            conn.connect(server);
        }

        public static void onMissionDownloadPhase1(string missionName, string musicTrack)
        {
            // Load the post effect presets for this mission.
            string path = "levels/" + pInvokes.Util.fileBase(missionName) + pInvokes.sGlobal["$PostFXManager::fileExtension"];
            if (pInvokes.Util.isFile(path))
                ((postFXManager) "postFXManager").loadPresetHandler(path);
            else
                ((postFXManager) "postFXManager").settingsApplyDefaultPreset();

            // Close and clear the message hud (in case it's open)
            if ("MessageHud".isObject())
                ((MessageHud) "MessageHud").close();

            // Reset the loading progress controls:
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("0");
            ((GuiTextCtrl) "LoadingProgressTxt").setValue("LOADING DATABLOCKS");
            ((GuiCanvas) "Canvas").repaint(-1);
        }

        public static void onPhase1Progress(string progress)
        {
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue(progress);
            ((GuiCanvas) "Canvas").repaint(33);
        }

        public static void onPhase1Complete()
        {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");
            ((GuiCanvas) "Canvas").repaint(-1);
        }

        //----------------------------------------------------------------------------
        // Phase 2
        //----------------------------------------------------------------------------
        public static void onMissionDownloadPhase2()
        {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("0");
            ((GuiTextCtrl) "LoadingProgressTxt").setValue("LOADING OBJECTS");
            ((GuiCanvas) "Canvas").repaint(-1);
        }

        public static void onPhase2Progress(string progress)
        {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue(progress);
            ((GuiCanvas) "Canvas").repaint(33);
        }

        public static void onPhase2Complete()
        {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");
            ((GuiCanvas) "Canvas").repaint(-1);
        }

        [ConsoleInteraction(true)]
        public static void onFileChunkReceived(string fileName, float ofs, float size)
        {
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue((ofs/size).AsString());
            ((GuiTextCtrl) "LoadingProgressTxt").setValue("Downloading '" + fileName + "'");
        }

        //----------------------------------------------------------------------------
        // Phase 3
        //----------------------------------------------------------------------------

        public static void onMissionDownloadPhase3()
        {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("0");
            ((GuiTextCtrl) "LoadingProgressTxt").setValue("LIGHTING MISSION");
            ((GuiCanvas) "Canvas").repaint(-1);
        }

        public static void onPhase3Progress(string progress)
        {
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue(progress);
            ((GuiCanvas) "Canvas").repaint(33);
        }

        public static void onPhase3Complete()
        {
            pInvokes.bGlobal["$lightingMission"] = false;
            if (!"LoadingProgress".isObject())
                return;
            ((GuiTextCtrl) "LoadingProgressTxt").setValue("STARTING MISSION");
            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");
            ((GuiCanvas) "Canvas").repaint(-1);
        }

        //----------------------------------------------------------------------------
        // Mission loading done!
        //----------------------------------------------------------------------------

        public static void onMissionDownloadComplete()
        {
            // Client will shortly be dropped into the game, so this is
            // good place for any last minute gui cleanup.
        }

        public static void initialize()
        {
            message.addMessageCallback("MsgLoadInfo", "handleLoadInfoMessage");
            message.addMessageCallback("MsgLoadDescripition", "handleLoadDescriptionMessage");
            message.addMessageCallback("MsgLoadInfoDone", "handleLoadInfoDoneMessage");
            message.addMessageCallback("MsgLoadFailed", "handleLoadFailedMessage");
        }

        [ConsoleInteraction(true)]
        public static void handleLoadInfoMessage(string msgType, string msgString, string mapname)
        {
            pInvokes.console.error("Load info Recieved map " + mapname);

            GuiChunkedBitmapCtrl LoadingGui = "LoadingGui";
            if (((GuiCanvas) "canvas").getContent() != LoadingGui.getId())
                init.loadLoadingGui("LOADING MISSION FILE " + mapname);

            if (mapname.Trim() != "")
                MLoadinfo.Clear();
            MLoadinfo.Add("LOADING MISSION FILE " + mapname);
            for (int line = 0; line < LoadingGui["qLineCount"].AsInt(); line++)
                {
                LoadingGui["qLine[" + line.AsString() + "]"] = "";
                LoadingGui["qLineCount"] = (line + 1).AsString();
                }
        }

        [ConsoleInteraction(true)]
        public static void handleLoadDescriptionMessage(string msgType, string msgString, string line)
        {
            GuiChunkedBitmapCtrl LoadingGui = "LoadingGui";

            MLoadinfo.Add(line);

            int l = LoadingGui["qLineCount"].AsInt();
            LoadingGui["qLine[" + l.AsString() + "]"] = line;
            l++;
            LoadingGui["qLineCount"] = l.AsString();
        }

        [ConsoleInteraction(true)]
        public static void handleLoadInfoDoneMessage(string msgType, string msgString)
        {
            // This will get called after the last description line is sent.
            //onServerMessage
            foreach (string line in MLoadinfo)
                chatHud.OnServerMessage(line);
        }

        [ConsoleInteraction(true)]
        public static void handleLoadFailedMessage(string msgType, string msgString)
        {
            messageBox.MessageBoxOK("Mission Load Failed", msgString + "\r\nPress OK to return to the Main Menu", "disconnect();");
        }
    }
}
