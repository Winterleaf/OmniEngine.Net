using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class mission
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            // Whether the local client is currently running a mission.
            omni.bGlobal["$Client::missionRunning"] = false;
            // Sequence number for currently running mission.
            omni.iGlobal["$Client::missionSeq"] = -1;
            }

        // Called when mission is started.

        public static void clientStartMission()
            {
            // The client recieves a mission start right before
            // being dropped into the game.
            omni.Util.physicsStartSimulation("client");
            // Start game audio effects channels.
            ((SFXSource) "AudioChannelEffects").play(-1);
            // Create client mission cleanup group.
            new ObjectCreator("SimGroup", "ClientMissionCleanup").Create();
            omni.bGlobal["$Client::missionRunning"] = true;
            }

        // Called when mission is ended (either through disconnect or
        // mission end client command).

        public static void clientEndMission()
            {
            // Stop physics simulation on client.
            omni.Util.physicsStopSimulation("client");
            // Stop game audio effects channels.

            ((SFXSource) "AudioChannelEffects").stop(-1);

            omni.console.Call("decalManagerClear");
            // Delete client mission cleanup group. 

            ((SimGroup) "ClientMissionCleanup").delete();

            omni.Util.clearClientPaths();

            omni.bGlobal["$Client::missionRunning"] = false;
            }

        //----------------------------------------------------------------------------
        // Mission start / end events sent from the server
        //----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void clientCmdMissionStart(string seq)
            {
            clientStartMission();

            omni.sGlobal["$Client::missionSeq"] = seq;
            }

        [ConsoleInteraction(true)]
        public static void clientCmdMissionEnd(string seq)
            {
            if (!omni.bGlobal["$Client::missionRunning"] || omni.sGlobal["$Client::missionSeq"] != seq)
                return;
            clientEndMission();
            omni.iGlobal["$Client::missionSeq"] = -1;
            }

        /// Expands the name of a mission into the full 
        /// mission path and extension.
        public static string expandMissionFileName(string missionFile)
            {
            // Expand any escapes in it.

            missionFile = omni.Util._expandFilename(missionFile);
            string newMission = "";
            if (!omni.Util.isFile(missionFile))
                {
                if (!missionFile.Trim().EndsWith(".mis"))
                    newMission = missionFile.Trim() + ".mis";

                if (!omni.Util.isFile(newMission))
                    {
                    newMission = omni.Util._expandFilename("levels/" + newMission);

                    if (!omni.Util.isFile(newMission))
                        {
                        omni.console.warn("The mission file '" + missionFile + "' was not found.");
                        return "";
                        }
                    }
                missionFile = newMission;
                }
            return missionFile;
            }

        /// Load a single player level on the local server.
        public static bool loadLevel(string missionNameOrFile)
            {
            // Expand the mission name... this allows you to enter
            // just the name and not the full path and extension.
            string missionFile = expandMissionFileName(missionNameOrFile);
            if (missionFile == "")
                return false;
            // Show the loading screen immediately.

            if (((GuiChunkedBitmapCtrl) "LoadingGui").isObject())
                {
                //if it can't find the loading gui it will throw an exception and leave the try block.

                ((GuiCanvas) "Canvas").setContent("LoadingGui");
                ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");
                ((GuiTextCtrl) "LoadingProgressTxt").setValue("LOADING MISSION FILE");
                ((GuiCanvas) "Canvas").repaint(0);
                }


            // Prepare and launch the server.
            return Server.server.createAndConnectToLocalServer("SinglePlayer", missionFile);
            }
        }
    }