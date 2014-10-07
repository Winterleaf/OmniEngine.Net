#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<GammaPostEffect>))]
    public class GammaPostEffect : PostEffect
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void preProcess()
            {
            if (this["texture[1]"] != mColorCorrectionFileName) // sGlobal["$HDRPostFX::colorCorrectionRamp"])
                this.setTexture(1, mColorCorrectionFileName); // sGlobal["$HDRPostFX::colorCorrectionRamp"]);
            }

        public override void setShaderConsts()
            {
            float clampedGamma = Util.mClamp(fGlobal["$pref::Video::Gamma"], (float) 0.001, (float) 2.2);
            this.setShaderConst("$OneOverGamma", (1/clampedGamma).AsString());
            }

        public override void onDisabled()
            {
            }

        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("ShaderData", "GammaShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/gammaP.hlsl";

            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "GammaStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("PostEffect", "GammaPostFX", typeof (GammaPostEffect));
            ts["isEnabled"] = false;
            ts["allowReflectPass"] = false;

            ts["renderTime"] = "PFXBeforeBin";
            ts["renderBin"] = "EditorBin";
            ts["renderPriority"] = 9999;

            ts["shader"] = "GammaShader";
            ts["stateBlock"] = "GammaStateBlock";

            ts["texture[0]"] = "$backBuffer";
            ts["texture[1]"] = '"' + mColorCorrectionFileName + '"'; // "$HDRPostFX::colorCorrectionRamp";
            ts.Create();
            }
        }
    }