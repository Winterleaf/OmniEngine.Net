using System.Collections.Generic;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class postFX
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "PFX_DefaultStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_PassthruShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/passthruP.hlsl";

            //   OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
            //   OGLPixelShaderFile   = "shaders/common/postFx/gl/passthruP.glsl";

            ts["samplerNames[0]"] = "$inputTex";

            ts["pixVersion"] = 2.0;
            ts.Create();
            }

        public static void initPostEffects()
            {
            CausticsPostEffect.initialize();
            ChromaticLensPostFX.initialize();
            DOFPostEffect.initialize();
            EdgeAAPostEffect.initialize();
            FlashFxPostEffect.initialize();
            FogPostEffect.initialize();
            TurbulencePostEffect.initialize();
            UnderwaterFogPostEffect.initialize();
            FXAA_PostEffect.initialize();
            GammaPostEffect.initialize();
            GlowPostEffect.initialize();
            HDRPostEffect.initialize();
            LightRayPostEffect.initialize();
            //LightRayPostUnderwaterFX.initialize();
            MLAAPostEffect.initialize();
            MotionBlurPostEffect.initialize();
            OVRBarrelDistortionMonoPostEffect.initialize();
            SSAOPostEffect.initialize();

            postFXManager.createGui();

            omni.Util.exec("core/scripts/client/postFx/default.postfxpreset.cs", false, false);
            }

        public static void SetPostFXToDefault()
            {
            Dictionary<string, string> ValueToLoad = new Dictionary<string, string>();
            ValueToLoad.Add("$PostFXManager::Settings::DOF::BlurCurveFar", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::BlurCurveNear", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::BlurMax", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::BlurMin", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::EnableAutoFocus", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::EnableDOF", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::FocusRangeMax", "");
            ValueToLoad.Add("$PostFXManager::Settings::DOF::FocusRangeMin", "");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::adaptRate", "2");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::blueShiftColor", "1.05 0.97 1.27");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::brightPassThreshold", "1");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::enableBloom", "1");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::enableBlueShift", "0");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::enableToneMapping", "1");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::gaussMean", "0");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::gaussMultiplier", "0.3");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::gaussStdDev", "0.8");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::keyValue", "0.18");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::minLuminace", "0.001");
            ValueToLoad.Add("$PostFXManager::Settings::HDR::whiteCutoff", "1");
            ValueToLoad.Add("$PostFXManager::Settings::LightRays::brightScalar", "0.75");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::blurDepthTol", "0.001");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::blurNormalTol", "0.95");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lDepthMax", "2");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lDepthMin", "0.2");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lDepthPow", "0.2");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lNormalPow", "2");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lNormalTol", "-0.5");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lRadius", "1");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::lStrength", "10");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::overallStrength", "2");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::quality", "0");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sDepthMax", "1");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sDepthMin", "0.1");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sDepthPow", "1");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sNormalPow", "1");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sNormalTol", "0");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sRadius", "0.1");
            ValueToLoad.Add("$PostFXManager::Settings::SSAO::sStrength", "6");
            ValueToLoad.Add("$PostFXManager::Settings::ColorCorrectionRamp",
                "core/scripts/client/postFx/null_color_ramp.png");

            //Todo Settings - Switch this back when fixed.
            //Settings.SetVariables("default.postfxpreset.cs", ValueToLoad);
            }
        }
    }