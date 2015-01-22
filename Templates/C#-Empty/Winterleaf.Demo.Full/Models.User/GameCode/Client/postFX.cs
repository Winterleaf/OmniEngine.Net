// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.Collections.Generic;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    public class postFX
    {
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

            pInvokes.Util.exec("core/scripts/client/postFx/default.postfxpreset.cs", false, false);
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
            ValueToLoad.Add("$PostFXManager::Settings::ColorCorrectionRamp", "core/scripts/client/postFx/null_color_ramp.png");

            //Todo Settings - Switch this back when fixed.
            //Settings.SetVariables("default.postfxpreset.cs", ValueToLoad);
        }
    }
}