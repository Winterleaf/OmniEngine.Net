using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<TurbulencePostEffect>))]
    public class TurbulencePostEffect : PostEffect
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData",
                "PFX_TurbulenceStateBlock : PFX_DefaultStateBlock");
            ts["zDefined"] = false;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";

            ts = new SingletonCreator("ShaderData", "PFX_TurbulenceShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/turbulenceP.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "TurbulenceFx", typeof (TurbulencePostEffect));
            ts["isEnabled"] = "$PostFXManager::PostFX::Enabled";
            ts["allowReflectPass"] = true;
            ts["renderTime"] = "PFXAfterBin";
            ts["renderBin"] = "GlowBin";
            ts["renderPriority"] = 0.5;
            ts["shader"] = "PFX_TurbulenceShader";
            ts["stateBlock"] = "PFX_myShaderStateBlock";
            ts["texture[0]"] = "$backBuffer";
            ts.Create();
            }
        }
    }