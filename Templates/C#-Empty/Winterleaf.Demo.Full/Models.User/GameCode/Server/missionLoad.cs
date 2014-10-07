#region

using System.Linq;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;


#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class missionLoad
        {
        /// <summary>
        /// Do not change this file, if you need to add code modify the mission class, missionLoadDM.
        /// </summary>

        public static missionLoadBase __missionLoadBase;

        private static object __missionLoadBaseLock = new object();

        public static missionLoadBase _missionLoadBase
            {
            get
                {
                lock (__missionLoadBaseLock)
                    {
                    if (__missionLoadBase == null)
                        __missionLoadBase = new missionLoadBase();//This is where you specify your class for your mission.  You can change this while the game is running if needed.
                    }
                return __missionLoadBase;
                }
            set
                {
                lock (__missionLoadBaseLock)
                    {
                    __missionLoadBase = null;//Let's force garbage collection.
                    __missionLoadBase = value;
                    }
                }
            }

        public static void InitMissionLoad()
            {
            _missionLoadBase.InitMissionLoad();
            }

        [ConsoleInteraction(true)]
        public static void loadMission(string missionName, bool isFirstMission)
            {
            _missionLoadBase.loadMission(missionName, isFirstMission);
            }

        //-----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void LoadMissionStage2()
            {
            _missionLoadBase.LoadMissionStage2();
            }

        //-----------------------------------------------------------------------------

        public static void EndMission()
            {
            _missionLoadBase.EndMission();
            }

        //-----------------------------------------------------------------------------

        public static void ResetMission()
            {
            _missionLoadBase.ResetMission();
            }

        [ConsoleInteraction(true)]
        public static void onGameDurationEnd()
            {
            _missionLoadBase.onGameDurationEnd();
            }

        public static void cycleGame()
            {
            _missionLoadBase.cycleGame();
            }

        [ConsoleInteraction(true)]
        public static void gameCoreDestroyServer(string serverSession)
            {
            _missionLoadBase.gameCoreDestroyServer(serverSession);
            }

        [ConsoleInteraction(true)]
        public static void onCycleExec()
            {
            _missionLoadBase.onCycleExec();
            }

        [ConsoleInteraction(true)]
        public static void onCyclePauseEnd()
            {
            _missionLoadBase.onCyclePauseEnd();
            }

        [ConsoleInteraction(true)]
        public static void serverCmdMissionStartPhase1Ack(GameConnection client, int seq)
            {
            _missionLoadBase.serverCmdMissionStartPhase1Ack(client, seq);
            }

        [ConsoleInteraction(true)]
        public static void serverCmdMissionStartPhase2CacheAck(GameConnection client)
            {
            _missionLoadBase.serverCmdMissionStartPhase2CacheAck(client);
            }

        [ConsoleInteraction(true)]
        public static void serverCmdMissionStartPhase2Ack(GameConnection client, string seq, PlayerData playerDB)
            {
            _missionLoadBase.serverCmdMissionStartPhase2Ack(client, seq, playerDB);
            }

        [ConsoleInteraction(true)]
        public static void serverCmdMissionStartPhase3Ack(GameConnection client, string seq)
            {
            _missionLoadBase.serverCmdMissionStartPhase3Ack(client, seq);
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