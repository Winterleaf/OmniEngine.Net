using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class clientCmd
        {
        private static readonly pInvokes omni = new pInvokes();
        //-----------------------------------------------------------------------------
        // Server Admin Commands
        //-----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void SAD(string password)
            {
            if (password.Trim() != "")
                omni.console.commandToServer("SAD", new[] { password });
            }

        [ConsoleInteraction(true)]
        public static void SadSetPassword(string password)
            {
            omni.console.commandToServer("SADSetPassword", new[] { password });
            }

        //----------------------------------------------------------------------------
        // Misc server commands
        //----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void clientCmdSyncClock(string time)
            {
            // Time update from the server, this is only sent at the start of a mission
            // or when a client joins a game in progress.
            }

        
        }
    }