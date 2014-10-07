using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<UnderwaterFogPostEffect>))]
    public class UnderwaterFogPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("PostEffect", "UnderwaterFogPostFx",
                typeof (UnderwaterFogPostEffect));
            ts["oneFrameOnly"] = true;
            ts["onThisFrame"] = false;

            // Let the fog effect render during the 
            // reflection pass.
            ts["allowReflectPass"] = true;

            ts["renderTime"] = "PFXBeforeBin";
            ts["renderBin"] = "ObjTranslucentBin";

            ts["shader"] = "UnderwaterFogPassShader";
            ts["stateBlock"] = "UnderwaterFogPassStateBlock";
            ts["texture[0]"] = "#prepass";
            ts["texture[1]"] = "$backBuffer";
            ts["texture[2]"] = "#waterDepthGradMap";

            // Needs to happen after the FogPostFx
            ts["renderPriority"] = 4;

            ts["isEnabled"] = false;
            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }