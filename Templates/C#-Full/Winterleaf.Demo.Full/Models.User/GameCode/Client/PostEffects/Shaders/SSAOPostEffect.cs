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

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
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