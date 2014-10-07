using System.Collections.Generic;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class missionDownload
        {
        private static readonly pInvokes omni = new pInvokes();
        private static List<string> MLoadinfo = new List<string>();

        [ConsoleInteraction(true)]
        public static void clientCmdMissionStartPhase1(string seq, string missionName, string musicTrack, string serverCRC)
            {
            GameConnection ServerConnection = "ServerConnection";
            omni.Util._echo("*** New Mission: " + missionName);
            omni.Util._echo("*** Phase 1: Download Datablocks & Targets");
            onMissionDownloadPhase1(missionName, musicTrack);
            omni.sGlobal["$ServerDatablockCacheCRC"] = serverCRC;

            string name = missionName.Replace(" ", "");
            if (name.Contains("/"))
                name = name.Substring(name.LastIndexOf("/") + 1);
            if (name.Contains("."))
                name = name.Split('.')[0];



            omni.sGlobal["$ServerDatablockCacheMissionName"] ="DBCaches/" + name + "DB.db";

            if (ServerConnection.callScript("LoadDatablocksFromFile", new[] { serverCRC }).AsBool())
                {
                omni.console.print("Loaded Datablocks from file.");
                clientCmdMissionStartPhase2(seq, missionName, true);
                }
            else
                {
                omni.console.commandToServer("MissionStartPhase1Ack", new string[] { seq });
                }
            }

        [ConsoleInteraction(true)]
        public static void onDataBlockObjectReceived(string index, string total)
            {
            onPhase1Progress((index.AsDouble() / total.AsDouble()).AsString());
            }

        [ConsoleInteraction(true)]
        public static void clientCmdMissionStartPhase2(string seq, string missionName, bool isLoadedFromFile = false)
            {
            onPhase1Complete();
            omni.Util._echo("*** Phase 2: Download Ghost Objects");
            onMissionDownloadPhase2();

            //Push the client past the datablock transmition stage.
            if (isLoadedFromFile)
                omni.console.commandToServer("MissionStartPhase2CacheAck");

            //Start next stage.
            omni.console.commandToServer("MissionStartPhase2Ack",
                new string[] { seq, omni.sGlobal["$pref::Player:PlayerDB"] });
            }

        [ConsoleInteraction(true)]
        public static void onGhostAlwaysStarted(string ghostCount)
            {
            omni.sGlobal["$ghostCount"] = ghostCount;
            omni.iGlobal["$ghostsRecvd"] = 0;
            }

        [ConsoleInteraction(true)]
        public static void onGhostAlwaysObjectReceived()
            {
            omni.iGlobal["$ghostsRecvd"] = omni.iGlobal["$ghostsRecvd"] + 1;
            onPhase2Progress((omni.fGlobal["$ghostsRecvd"] / omni.fGlobal["$ghostCount"]).AsString());
            }

        //
        //----------------------------------------------------------------------------
        //Phase 3
        //----------------------------------------------------------------------------

        [ConsoleInteraction(true)]
        public static void clientCmdMissionStartPhase3(string seq, string missionName)
            {
            onPhase2Complete();
            omni.Util.StartClientReplication();
            omni.Util.StartFoliageReplication();
            // Load the static mission decals.

            omni.console.Call("decalManagerLoad", new string[] { missionName + ".decals" });

            omni.Util._echo("*** Phase 3: Mission Lighting");
            omni.sGlobal["$MSeq"] = seq;
            omni.sGlobal["$Client::MissionFile"] = missionName;

            //Need to light the mission before we are ready.
            //The sceneLightingComplete function will complete the handshake 
            //once the scene lighting is done.
            if (omni.Util.lightScene("sceneLightingComplete", ""))
                {
                omni.Util._echo("Lighting mission....");
                omni.Util._schedule("1", "0", "updateLightingProgress");
                onMissionDownloadPhase3();
                omni.bGlobal["$lightingMission"] = true;
                }
            }

        [ConsoleInteraction(true)]
        public static void updateLightingProgress()
            {
            onPhase3Progress(omni.sGlobal["$SceneLighting::lightingProgress"]);
            if (omni.bGlobal["$lightingMission"])
                omni.iGlobal["$lightingProgressThread"] = omni.Util._schedule("1", "0", "updateLightingProgress");
            }

        [ConsoleInteraction(true)]
        public static void sceneLightingComplete()
            {
            omni.Util._echo("Mission lighting done");
            onPhase3Complete();
            //The is also the end of the mission load cycle.

            onMissionDownloadComplete();
            omni.console.commandToServer("MissionStartPhase3Ack", new string[] { omni.sGlobal["$MSeq"] });
            }

        //
        //----------------------------------------------------------------------------
        //Helper functions
        //----------------------------------------------------------------------------

        public static void connect(string server)
            {
            GameConnection conn = new ObjectCreator("ServerConnection").Create();
            ((SimGroup)"RootGroup").add(conn);
            conn.setConnectArgs(omni.sGlobal["$pref::Player::Name"]);
            conn.setJoinPassword(omni.sGlobal["$Client::Password"]);
            conn.connect(server);
            }

        public static void onMissionDownloadPhase1(string missionName, string musicTrack)
            {
            // Load the post effect presets for this mission.
            string path = "levels/" + omni.Util.fileBase(missionName) + omni.sGlobal["$PostFXManager::fileExtension"];
            if (omni.Util.isFile(path))
                ((postFXManager)"postFXManager").loadPresetHandler(path);
            else
                ((postFXManager)"postFXManager").settingsApplyDefaultPreset();

            // Close and clear the message hud (in case it's open)
            if ("MessageHud".isObject())
                ((MessageHud)"MessageHud").close();

            // Reset the loading progress controls:
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue("0");
            ((GuiTextCtrl)"LoadingProgressTxt").setValue("LOADING DATABLOCKS");
            ((GuiCanvas)"Canvas").repaint(-1);
            }

        public static void onPhase1Progress(string progress)
            {
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue(progress);
            ((GuiCanvas)"Canvas").repaint(33);
            }

        public static void onPhase1Complete()
            {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue("1");
            ((GuiCanvas)"Canvas").repaint(-1);
            }

        //----------------------------------------------------------------------------
        // Phase 2
        //----------------------------------------------------------------------------
        public static void onMissionDownloadPhase2()
            {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue("0");
            ((GuiTextCtrl)"LoadingProgressTxt").setValue("LOADING OBJECTS");
            ((GuiCanvas)"Canvas").repaint(-1);
            }

        public static void onPhase2Progress(string progress)
            {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue(progress);
            ((GuiCanvas)"Canvas").repaint(33);
            }

        public static void onPhase2Complete()
            {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue("1");
            ((GuiCanvas)"Canvas").repaint(-1);
            }

        [ConsoleInteraction(true)]
        public static void onFileChunkReceived(string fileName, float ofs, float size)
            {
            if (!"LoadingProgress".isObject())
                return;

            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue((ofs / size).AsString());
            ((GuiTextCtrl)"LoadingProgressTxt").setValue("Downloading '" + fileName + "'");
            }

        //----------------------------------------------------------------------------
        // Phase 3
        //----------------------------------------------------------------------------

        public static void onMissionDownloadPhase3()
            {
            if (!"LoadingProgress".isObject())
                return;
            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue("0");
            ((GuiTextCtrl)"LoadingProgressTxt").setValue("LIGHTING MISSION");
            ((GuiCanvas)"Canvas").repaint(-1);
            }

        public static void onPhase3Progress(string progress)
            {
            if (!"LoadingProgress".isObject())
                return;


            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue(progress);
            ((GuiCanvas)"Canvas").repaint(33);
            }

        public static void onPhase3Complete()
            {
            omni.bGlobal["$lightingMission"] = false;
            if (!"LoadingProgress".isObject())
                return;
            ((GuiTextCtrl)"LoadingProgressTxt").setValue("STARTING MISSION");
            ((GuiProgressBitmapCtrl)"LoadingProgress").setValue("1");
            ((GuiCanvas)"Canvas").repaint(-1);
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
            omni.console.error("Load info Recieved map " + mapname);


            GuiChunkedBitmapCtrl LoadingGui = "LoadingGui";
            if (((GuiCanvas)"canvas").getContent() != LoadingGui.getId())
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
                {
                chatHud.OnServerMessage(line);
                }
            }

        [ConsoleInteraction(true)]
        public static void handleLoadFailedMessage(string msgType, string msgString)
            {
            messageBox.MessageBoxOK("Mission Load Failed", msgString + "\r\nPress OK to return to the Main Menu",
                "disconnect();");
            }
        }
    }