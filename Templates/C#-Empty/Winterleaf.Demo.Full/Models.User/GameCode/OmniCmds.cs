using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;

namespace WinterLeaf.Demo.Full.Models.User.GameCode
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
