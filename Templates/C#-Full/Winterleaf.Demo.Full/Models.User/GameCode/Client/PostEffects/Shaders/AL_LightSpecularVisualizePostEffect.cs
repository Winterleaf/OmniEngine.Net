using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<AL_LightSpecularVisualizePostEffect>))]
    public class AL_LightSpecularVisualizePostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("PostEffect", "AL_LightSpecularVisualize",
                typeof (AL_LightSpecularVisualizePostEffect));

            ts["shader"] = "AL_LightSpecularVisualizeShader";
            ts["stateBlock"] = "AL_DefaultVisualizeState";
            ts["texture[0]"] = "#lightinfo";
            ts["target"] = "$backBuffer";
            ts["renderPriority"] = 9999;
            ts.Create();
            }

        public override bool onEnabled()
            {
            ((PostEffect) "AL_NormalsVisualize").disable();
            ((PostEffect) "AL_DepthVisualize").disable();
            ((PostEffect) "AL_LightColorVisualize").disable();
            bGlobal["$AL_NormalsVisualizeVar"] = false;
            bGlobal["$AL_DepthVisualizeVar"] = false;
            bGlobal["$AL_LightColorVisualizeVar"] = false;

            return true;
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }