using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<AL_DepthVisualPostEffect>))]
    public class AL_DepthVisualPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("PostEffect", "AL_DepthVisualize",
                typeof (AL_DepthVisualPostEffect));
            ts["shader"] = "AL_DepthVisualizeShader";
            ts["stateBlock"] = "AL_DefaultVisualizeState";
            ts["texture[0]"] = "#prepass";
            ts["texture[1]"] = "core/scripts/client/lighting/advanced/depthviz.png";
            ts["target"] = "$backBuffer";
            ts["renderPriority"] = 9999;
            ts.Create();
            }

        public override bool onEnabled()
            {
            ((PostEffect) "AL_NormalsVisualize").disable();
            ((PostEffect) "AL_LightColorVisualize").disable();
            ((PostEffect) "AL_LightSpecularVisualize").disable();
            bGlobal["$AL_NormalsVisualizeVar"] = false;
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