using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Recordings
    {
    public class recordings
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true)]
        public static void StartSelectedDemo()
            {
            // first unit is filename
            GuiTextListCtrl RecordingsDlgList = "RecordingsDlgList";
            int sel = RecordingsDlgList.getSelectedId();
            string rowText = RecordingsDlgList.getRowTextById(sel);

            string file = omni.sGlobal["$currentMod"] + "/recordings/" + omni.Util.getField(rowText, 0) + ".rec";

            GameConnection ServerConnection = new ObjectCreator("GameConnection", "ServerConnection").Create();
            ((SimGroup) "RootGroup").add(ServerConnection);

            // Start up important client-side stuff, such as the group
            // for particle emitters.  This doesn't get launched during a demo
            // as we short circuit the whole mission loading sequence.
            mission.clientStartMission();

            if (ServerConnection.playDemo(file))
                {
                ((GuiCanvas) "canvas").setContent("PlayGui");
                ((GuiCanvas) "canvas").popDialog("RecordingsDlg");
                ServerConnection.call("prepDemoPlayback");
                }
            else
                {
                messageBox.MessageBoxOK("Playback Failed", "Demo playback failed for file '" + file + "'.", "");
                if ("ServerConnection".isObject())
                    "ServerConnection".delete();
                }
            }

        public static void startDemoRecord()
            {
            GameConnection ServerConnection = "ServerConnection";
            ServerConnection.stopRecording();

            if (ServerConnection.isDemoPlaying())
                return;
            string file = "";
            int i = 0;
            for (i = 0; i < 1000; i++)
                {
                string num = i.AsString();
                if (i < 10)
                    num = "0" + i;
                if (i < 100)
                    num = "0" + num;

                file = omni.sGlobal["$currentMod"] + "/recordings/demo" + num + ".rec";
                if (!omni.Util.isFile(file))
                    break;
                }
            if (i == 1000)
                return;

            omni.sGlobal["$DemoFileName"] = file;
            ((chatHud) "ChatHud").AddLine(@"\c4Recording to file [\c2" + file + @"\cr].");
            ServerConnection.call("prepDemoRecord");
            ServerConnection.startRecording(file);

            // make sure start worked
            if (ServerConnection.isDemoRecording())
                {
                omni.Util._call("deleteFile", file);
                ((chatHud) "ChatHud").AddLine(@"\c3 *** Failed to record to file [\c2" + file + @"\cr].");
                omni.sGlobal["$DemoFileName"] = "";
                }
            }

        public static void stopDemoRecord()
            {
            GameConnection ServerConnection = "ServerConnection";
            if (ServerConnection.isDemoRecording())
                {
                ((chatHud) "ChatHud").AddLine(@"\c4Recording file [\c2" + omni.sGlobal["$DemoFileName"] +
                                              @"\cr] finished.");
                ServerConnection.stopRecording();
                }
            }

        public static void demoPlaybackComplete()
            {
            omni.Util._call("disconnect");
            // Clean up important client-side stuff, such as the group
            // for particle emitters and the decal manager.  This doesn't get 
            // launched during a demo as we short circuit the whole mission 
            // handling functionality.

            mission.clientEndMission();

            if ("MainMenuGui".isObject())
                ((GuiCanvas) "canvas").setContent("MainMenuGui");

            ((GuiCanvas) "canvas").pushDialog("RecordingsDlg");
            }
        }
    }