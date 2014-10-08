using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<AL_NormalsVisualizePostEffect>))]
    public class AL_NormalsVisualizePostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("PostEffect", "AL_NormalsVisualize",
                typeof (AL_NormalsVisualizePostEffect));
            ts["shader"] = "AL_NormalsVisualizeShader";
            ts["stateBlock"] = "AL_DefaultVisualizeState";
            ts["texture[0]"] = "#prepass";
            ts["target"] = "$backBuffer";
            ts["renderPriority"] = 9999;
            ts.Create();
            }

        public override bool onEnabled()
            {
            ((PostEffect) "AL_DepthVisualize").disable();
            ((PostEffect) "AL_LightColorVisualize").disable();
            ((PostEffect) "AL_LightSpecularVisualize").disable();
            bGlobal["$AL_DepthVisualizeVar"] = false;
            bGlobal["$AL_LightColorVisualizeVar"] = false;
            bGlobal["$AL_LightSpecularVisualizeVar"] = false;

            return true;
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }