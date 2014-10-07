using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<FXAA_PostEffect>))]
    public class FXAA_PostEffect : PostEffect
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "FXAA_StateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "FXAA_ShaderData");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/fxaa/fxaaV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/fxaa/fxaaP.hlsl";

            ts["samplerNames[0]"] = "$colorTex";

            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "FXAA_PostEffect", typeof (FXAA_PostEffect));
            ts["isEnabled"] = false;

            ts["allowReflectPass"] = false;
            ts["renderTime"] = "PFXAfterDiffuse";

            ts["texture[0]"] = "$backBuffer";

            ts["target"] = "$backBuffer";

            ts["stateBlock"] = "FXAA_StateBlock";
            ts["shader"] = "FXAA_ShaderData";
            ts.Create();
            }
        }
    }