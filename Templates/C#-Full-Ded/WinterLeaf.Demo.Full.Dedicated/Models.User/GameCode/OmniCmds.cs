using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;

namespace Winterleaf.Demo.Full.Dedicated.Models.User.GameCode
    {
    class OmniCmds
        {
        [ConsoleInteraction]
        public static void OmniDebug(bool on = true)
        {
            Omni.self.Debugging = on;
        }
        }
    }
