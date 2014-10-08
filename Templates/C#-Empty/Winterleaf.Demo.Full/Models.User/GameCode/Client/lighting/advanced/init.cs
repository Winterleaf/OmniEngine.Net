using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.advanced
    {
    public class init
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            shaders.initialize();
            lightViz.initialize();
            shadowViz.initialize();
            }

        [ConsoleInteraction(true)]
        public static void onActivateAdvancedLM()
            {
            if (omni.sGlobal["$platform"] == "macos")
                return;
            if (omni.sGlobal["$platform"] == "xenon")
                return;
            ((RenderFormatToken) "AL_FormatToken").enable();
            }

        [ConsoleInteraction(true)]
        public static void onDeactivateAdvancedLM()
            {
            ((RenderFormatToken) "AL_FormatToken").disable();
            }

        [ConsoleInteraction(true)]
        public static void setAdvancedLighting()
            {
            omni.Util.setLightManager("Advanced Lighting");
            }
        }
    }