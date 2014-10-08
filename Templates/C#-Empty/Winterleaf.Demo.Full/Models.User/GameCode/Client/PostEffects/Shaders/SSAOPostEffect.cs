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
    [TypeConverter(typeof (TypeConverterGeneric<SSAOPostEffect>))]
    public class SSAOPostEffect : PostEffect
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd()
            {
            this["wasVis"] = "Uninitialized";
            this["quality"] = "Uninitialized";
            }

        public override void preProcess()
            {
            if (sGlobal["$SSAOPostFx::quality"] != this["quality"])
                {
                this["quality"] = Util.mClamp(Util.mRound(console.GetVarFloat("$SSAOPostFx::quality")), 0, 2).AsString();
                setShaderMacro("QUALITY", this["quality"].AsInt().AsString());
                }
            this["targetScale"] = sGlobal["$SSAOPostFx::targetScale"];
            }

        public override void setShaderConsts()
            {
            setShaderConst("$texSize1", "0");
            setShaderConst("$overallStrength", sGlobal["$SSAOPostFx::overallStrength"]);
            //thisobj.setShaderConst("$",);
            setShaderConst("$sRadius", sGlobal["$SSAOPostFx::sRadius"]);
            setShaderConst("$sStrength", sGlobal["$SSAOPostFx::sStrength"]);
            setShaderConst("$sDepthMin", sGlobal["$SSAOPostFx::sDepthMin"]);
            setShaderConst("$sDepthMax", sGlobal["$SSAOPostFx::sDepthMax"]);
            setShaderConst("$sDepthPow", sGlobal["$SSAOPostFx::sDepthPow"]);
            setShaderConst("$sNormalTol", sGlobal["$SSAOPostFx::sNormalTol"]);
            setShaderConst("$sNormalPow", sGlobal["$SSAOPostFx::sNormalPow"]);
            setShaderConst("$lRadius", sGlobal["$SSAOPostFx::lRadius"]);
            setShaderConst("$lStrength", sGlobal["$SSAOPostFx::lStrength"]);
            setShaderConst("$lDepthMin", sGlobal["$SSAOPostFx::lDepthMin"]);
            setShaderConst("$lDepthMax", sGlobal["$SSAOPostFx::lDepthMax"]);
            setShaderConst("$lDepthPow", sGlobal["$SSAOPostFx::lDepthPow"]);
            setShaderConst("$lNormalTol", sGlobal["$SSAOPostFx::lNormalTol"]);
            setShaderConst("$lNormalPow", sGlobal["$SSAOPostFx::lNormalPow"]);

            PostEffect blur = findObjectByInternalName("blurY", false);
            blur.setShaderConst("$blurDepthTol", sGlobal["$SSAOPostFx::blurDepthTol"]);
            blur.setShaderConst("$blurNormalTol", sGlobal["$SSAOPostFx::blurNormalTol"]);

            blur = findObjectByInternalName("blurX", false);
            blur.setShaderConst("$blurDepthTol", sGlobal["$SSAOPostFx::blurDepthTol"]);
            blur.setShaderConst("$blurNormalTol", sGlobal["$SSAOPostFx::blurNormalTol"]);

            blur = findObjectByInternalName("blurY2", false);
            blur.setShaderConst("$blurDepthTol", sGlobal["$SSAOPostFx::blurDepthTol"]);
            blur.setShaderConst("$blurNormalTol", sGlobal["$SSAOPostFx::blurNormalTol"]);

            blur = findObjectByInternalName("blurX2", false);
            blur.setShaderConst("$blurDepthTol", sGlobal["$SSAOPostFx::blurDepthTol"]);
            blur.setShaderConst("$blurNormalTol", sGlobal["$SSAOPostFx::blurNormalTol"]);
            }

        public override bool onEnabled()
            {
            // This tells the AL shaders to reload and sample
            // from our #ssaoMask texture target. 
            bGlobal["$AL::UseSSAOMask"] = true;
            return true;
            }

        public override void onDisabled()
            {
            bGlobal["$AL::UseSSAOMask"] = false;
            }

        public static void initialize()
            {
            omni.dGlobal["$SSAOPostFx::overallStrength"] = 2.0;

            // TODO: Add small/large param docs.

            // The small radius SSAO settings.
            omni.dGlobal["$SSAOPostFx::sRadius"] = 0.1;
            omni.dGlobal["$SSAOPostFx::sStrength"] = 6.0;
            omni.dGlobal["$SSAOPostFx::sDepthMin"] = 0.1;
            omni.dGlobal["$SSAOPostFx::sDepthMax"] = 1.0;
            omni.dGlobal["$SSAOPostFx::sDepthPow"] = 1.0;
            omni.dGlobal["$SSAOPostFx::sNormalTol"] = 0.0;
            omni.dGlobal["$SSAOPostFx::sNormalPow"] = 1.0;

            // The large radius SSAO settings.
            omni.dGlobal["$SSAOPostFx::lRadius"] = 1.0;
            omni.dGlobal["$SSAOPostFx::lStrength"] = 10.0;
            omni.dGlobal["$SSAOPostFx::lDepthMin"] = 0.2;
            omni.dGlobal["$SSAOPostFx::lDepthMax"] = 2.0;
            omni.dGlobal["$SSAOPostFx::lDepthPow"] = 0.2;
            omni.dGlobal["$SSAOPostFx::lNormalTol"] = -0.5;
            omni.dGlobal["$SSAOPostFx::lNormalPow"] = 2.0;

            // Valid values: 0, 1, 2
            omni.iGlobal["$SSAOPostFx::quality"] = 0;

            //
            omni.dGlobal["$SSAOPostFx::blurDepthTol"] = 0.001;

            // 
            omni.dGlobal["$SSAOPostFx::blurNormalTol"] = 0.95;

            //
            omni.sGlobal["$SSAOPostFx::targetScale"] = "0.5 0.5";

            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "SSAOStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            ts["samplerStates[1]"] = "SamplerWrapLinear";
            ts["samplerStates[2]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "SSAOBlurStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "SSAOShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/ssao/SSAO_P.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "SSAOBlurYShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/ssao/SSAO_Blur_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/ssao/SSAO_Blur_P.hlsl";
            ts["pixVersion"] = 3.0;
            ts["defines"] = "BLUR_DIR=float2(0.0,1.0)";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "SSAOBlurXShader : SSAOBlurYShader");
            ts["defines"] = "BLUR_DIR=float2(1.0,0.0)";
            ts.Create();

            SingletonCreator SSAOPostFx = new SingletonCreator("PostEffect", "SSAOPostFx", typeof (SSAOPostEffect));
            SSAOPostFx["allowReflectPass"] = false;
            SSAOPostFx["renderTime"] = "PFXBeforeBin";
            SSAOPostFx["renderBin"] = "AL_LightBinMgr";
            SSAOPostFx["renderPriority"] = 10;
            SSAOPostFx["shader"] = "SSAOShader";
            SSAOPostFx["stateBlock"] = "SSAOStateBlock";
            SSAOPostFx["texture[0]"] = "#prepass";
            SSAOPostFx["texture[1]"] = "core/scripts/client/postFx/noise.png";
            SSAOPostFx["texture[2]"] = "#ssao_pow_table";
            SSAOPostFx["target"] = "$outTex";
            SSAOPostFx["targetScale"] = "0.5 0.5";
            //SSAOPostFx["targetViewport"] = "PFXTargetViewport_GFXViewport";
            SSAOPostFx["targetViewport"] = "PFXTargetViewport_NamedInTexture0";

            SingletonCreator blurY = new SingletonCreator("PostEffect", "SSAOPostFx_blurY");
            blurY["internalName"] = "blurY";
            blurY["shader"] = "SSAOBlurYShader";
            blurY["stateBlock"] = "SSAOBlurStateBlock";
            blurY["texture[0]"] = "$inTex";
            blurY["texture[1]"] = "#prepass";
            blurY["target"] = "$outTex";
            SSAOPostFx["#1"] = blurY;

            SingletonCreator blurX = new SingletonCreator("PostEffect", "SSAOPostFx_blurX");
            blurX["internalName"] = "blurX";
            blurX["shader"] = "SSAOBlurXShader";
            blurX["stateBlock"] = "SSAOBlurStateBlock";
            blurX["texture[0]"] = "$inTex";
            blurX["texture[1]"] = "#prepass";
            blurX["target"] = "$outTex";
            SSAOPostFx["#2"] = blurX;

            SingletonCreator blurY2 = new SingletonCreator("PostEffect", "SSAOPostFx_blurY2");
            blurY2["internalName"] = "blurY2";
            blurY2["shader"] = "SSAOBlurYShader";
            blurY2["stateBlock"] = "SSAOBlurStateBlock";
            blurY2["texture[0]"] = "$inTex";
            blurY2["texture[1]"] = "#prepass";
            blurY2["target"] = "$outTex";
            SSAOPostFx["#3"] = blurY2;

            SingletonCreator blurX2 = new SingletonCreator("PostEffect", "SSAOPostFx_blurX2");
            blurX2["internalName"] = "blurX2";
            blurX2["shader"] = "SSAOBlurXShader";
            blurX2["stateBlock"] = "SSAOBlurStateBlock";
            blurX2["texture[0]"] = "$inTex";
            blurX2["texture[1]"] = "#prepass";
            // We write to a mask texture which is then
            // read by the lighting shaders to mask ambient.
            blurX2["target"] = "#ssaoMask";
            SSAOPostFx["#4"] = blurX2;
            SSAOPostFx.Create();

            ts = new SingletonCreator("PostEffect", "SSAOVizPostFx");
            ts["allowReflectPass"] = false;
            ts["shader"] = "PFX_PassthruShader";
            ts["stateBlock"] = "PFX_DefaultStateBlock";
            ts["texture[0]"] = "#ssaoMask";
            ts["target"] = "$backbuffer";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "SSAOPowTableShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/ssao/SSAO_PowerTable_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/ssao/SSAO_PowerTable_P.hlsl";
            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "SSAOPowTablePostFx");
            ts["shader"] = "SSAOPowTableShader";
            ts["stateBlock"] = "PFX_DefaultStateBlock";
            ts["renderTime"] = "PFXTexGenOnDemand";
            ts["target"] = "#ssao_pow_table";
            ts["targetFormat"] = "GFXFormatR16F";
            ts["targetSize"] = "256 1";
            ts.Create();
            }
        }
    }