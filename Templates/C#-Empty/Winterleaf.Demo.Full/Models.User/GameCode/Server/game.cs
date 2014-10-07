#region

using System.Collections.Generic;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class game
        {
        private static gameBase __gameBase;
        private static object __gameBaseLock = new object();

        public static gameBase _gameBase
            {
            get
                {
                lock (__gameBaseLock)
                    {
                    if (__gameBase == null)
                        __gameBase = new gameBase();
                    return __gameBase;
                    }
                }
            set
                {
                lock (__gameBaseLock)
                    {
                    __gameBase = null;
                    __gameBase = value;
                    }
                }
            }


        public static void initGame()
            {
            _gameBase.initGame();
            }

        public static void loadDatablockFiles(List<string> datablockFiles, bool recurse)
            {
            _gameBase.loadDatablockFiles(datablockFiles, recurse);
            }

        public static void recursiveLoadDatablockFiles(List<string> datablockFiles, int previousErrors)
            {
            _gameBase.recursiveLoadDatablockFiles(datablockFiles, previousErrors);
            }

        public static void onServerCreated()
            {
            _gameBase.onServerCreated();
            }

        public static void ScriptExec()
            {
            _gameBase.ScriptExec();
            }

        public static void onServerDestroyed()
            {
            _gameBase.onServerDestroyed();
            }

        public static void endGame()
            {
            _gameBase.endGame();
            }

        public static void onMissionEnded()
            {
            _gameBase.onMissionEnded();
            }

        public static void onMissionLoaded()
            {
            _gameBase.onMissionLoaded();
            }

        public static void startGame()
            {
            _gameBase.startGame();
            }

        public static void initGameVars()
            {
            _gameBase.initGameVars();
            }

        public static ScriptObject createGame()
            {
            return _gameBase.createGame();
            }

        public static void onMissionReset()
            {
            _gameBase.onMissionReset();
            }

        }
    }