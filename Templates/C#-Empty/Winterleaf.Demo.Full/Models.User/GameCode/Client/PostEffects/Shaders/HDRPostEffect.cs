#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<HDRPostEffect>))]
    internal class HDRPostEffect : PostEffect
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void setShaderConsts()
            {
            setShaderConst("$brightPassThreshold", sGlobal["$HDRPostFX::brightPassThreshold"]);
            setShaderConst("$g_fMiddleGray", sGlobal["$HDRPostFX::keyValue"]);
            PostEffect bloomh = findObjectByInternalName("bloomH", true);

            bloomh.setShaderConst("$gaussMultiplier", sGlobal["$HDRPostFX::gaussMultiplier"]);
            bloomh.setShaderConst("$gaussMean", sGlobal["$HDRPostFX::gaussMean"]);
            bloomh.setShaderConst("$gaussStdDev", sGlobal["$HDRPostFX::gaussStdDev"]);

            PostEffect bloomV = findObjectByInternalName("bloomV", true);

            bloomV.setShaderConst("$gaussMultiplier", sGlobal["$HDRPostFX::gaussMultiplier"]);
            bloomV.setShaderConst("$gaussMean", sGlobal["$HDRPostFX::gaussMean"]);
            bloomV.setShaderConst("$gaussStdDev", sGlobal["$HDRPostFX::gaussStdDev"]);

            double minLuminace = dGlobal["$HDRPostFX::minLuminace"];

            if (minLuminace <= 0.0)
                minLuminace = 0.00001;

            ((PostEffect) findObjectByInternalName("adaptLum", true)).setShaderConst("$g_fMinLuminace",
                minLuminace.AsString());
            ((PostEffect) findObjectByInternalName("finalLum", true)).setShaderConst("$adaptRate",
                sGlobal["$HDRPostFX::adaptRate"]);

            PostEffect combinePass = findObjectByInternalName("combinePass", true);
            combinePass.setShaderConst("$g_fEnableToneMapping", sGlobal["$HDRPostFX::enableToneMapping"]);
            combinePass.setShaderConst("$g_fMiddleGray", sGlobal["$HDRPostFX::keyValue"]);

            combinePass.setShaderConst("$g_fBloomScale", sGlobal["$HDRPostFX::enableBloom"]);
            combinePass.setShaderConst("$g_fEnableBlueShift", sGlobal["$HDRPostFX::enableBlueShift"]);
            combinePass.setShaderConst("$g_fBlueShiftColor", sGlobal["$HDRPostFX::blueShiftColor"]);

            float clampedGamma = Util.mClamp(fGlobal["$pref::Video::Gamma"], (float) 0.001, (float) 2.2);
            combinePass.setShaderConst("$g_fOneOverGamma", (1/clampedGamma).AsString());
            float whiteCutoff = fGlobal["$HDRPostFX::whiteCutoff"]*fGlobal["$HDRPostFX::whiteCutoff"]*
                                fGlobal["$HDRPostFX::whiteCutoff"]*fGlobal["$HDRPostFX::whiteCutoff"];
            combinePass.setShaderConst("$g_fWhiteCutoff", whiteCutoff.AsString());
            }

        public override void preProcess()
            {
            PostEffect combinePass = findObjectByInternalName("combinePass", true);
            if (combinePass[".texture[3]"] != mColorCorrectionFileName) // sGlobal["$HDRPostFX::colorCorrectionRamp"])
                combinePass.setTexture(3, mColorCorrectionFileName); // sGlobal["$HDRPostFX::colorCorrectionRamp"]);
            }

        public override bool onEnabled()
            {
            // We don't allow hdr on OSX yet.
            if (sGlobal["$platform"] == "macos")
                return false;

            // See what HDR format would be best.
            //%format = getBestHDRFormat();
            TypeGFXFormat format = Util.getBestHDRFormat();
            if ((format == TypeGFXFormat.GFXFormatDXT1) || (format == TypeGFXFormat.GFXFormatR8G8B8A8))
                // We didn't get a valid HDR format... so fail.
                return false;
            // HDR does it's own gamma calculation so 
            // disable this postFx.

            ((PostEffect) "GammaPostFX").disable();

            // Set the right global shader define for HDR.
            switch (format.Tag)
                {
                    case "GFXFormatR10G10B10A2":
                        Util.addGlobalShaderMacro("TORQUE_HDR_RGB10", string.Empty);
                        break;
                    case "GFXFormatR16G16B16A16":
                        Util.addGlobalShaderMacro("TORQUE_HDR_RGB16", string.Empty);
                        break;
                }

            console.print("HDR FORMAT: " + format.ToString());
            // Change the format of the offscreen surface
            // to an HDR compatible format.

            ((SimObject) "AL_FormatToken")["format"] = format.ToString();

            Util.setReflectFormat(format);
            // Reset the light manager which will ensure the new
            // hdr encoding takes effect in all the shaders and
            // that the offscreen surface is enabled.
            Util.resetLightManager();

            return true;
            }

        public override void onDisabled()
            {
            // Enable a special GammaCorrection PostFX when this is disabled.
            ((PostEffect) "GammaPostFX").enable();

            //%format = "GFXFormatR8G8B8A8";
            //AL_FormatToken.format = %format;
            ((SimObject) "AL_FormatToken")["format"] = "GFXFormatR8G8B8A8";

            // Restore the non-HDR offscreen surface format.
            //setReflectFormat( %format );
            Util.setReflectFormat(TypeGFXFormat.GFXFormatR8G8B8A8);

            //removeGlobalShaderMacro( "TORQUE_HDR_RGB10" );
            Util.removeGlobalShaderMacro("TORQUE_HDR_RGB10");

            //removeGlobalShaderMacro( "TORQUE_HDR_RGB16" );
            Util.removeGlobalShaderMacro("TORQUE_HDR_RGB16");

            //resetLightManager();
            Util.resetLightManager();
            }

        public static void initialize()
            {
            // Blends between the scene and the tone mapped scene.
            omni.dGlobal["$HDRPostFX::enableToneMapping"] = 1.0;

            // The tone mapping middle grey or exposure value used
            // to adjust the overall "balance" of the image.
            //
            // 0.18 is fairly common value.
            //
            omni.dGlobal["$HDRPostFX::keyValue"] = 0.18;

            // The minimum luninace value to allow when tone mapping 
            // the scene.  Is particularly useful if your scene very 
            // dark or has a black ambient color in places.
            omni.dGlobal["$HDRPostFX::minLuminace"] = 0.001;

            // The lowest luminance value which is mapped to white.  This
            // is usually set to the highest visible luminance in your 
            // scene.  By setting this to smaller values you get a contrast
            // enhancement.
            omni.dGlobal["$HDRPostFX::whiteCutoff"] = 1.0;

            // The rate of adaptation from the previous and new 
            // average scene luminance. 
            omni.dGlobal["$HDRPostFX::adaptRate"] = 2.0;


            // Blends between the scene and the blue shifted version
            // of the scene for a cinematic desaturated night effect.
            omni.dGlobal["$HDRPostFX::enableBlueShift"] = 0.0;

            // The blue shift color value.
            omni.sGlobal["$HDRPostFX::blueShiftColor"] = "1.05 0.97 1.27";


            // Blends between the scene and the bloomed scene.
            omni.dGlobal["$HDRPostFX::enableBloom"] = 1.0;

            // The threshold luminace value for pixels which are
            // considered "bright" and need to be bloomed.
            omni.dGlobal["$HDRPostFX::brightPassThreshold"] = 1.0;

            // These are used in the gaussian blur of the
            // bright pass for the bloom effect.
            omni.dGlobal["$HDRPostFX::gaussMultiplier"] = 0.3;
            omni.dGlobal["$HDRPostFX::gaussMean"] = 0.0;
            omni.dGlobal["$HDRPostFX::gaussStdDev"] = 0.8;

            // The 1x255 color correction ramp texture used
            // by both the HDR shader and the GammaPostFx shader
            // for doing full screen color correction. 
            //omni.sGlobal["$HDRPostFX::colorCorrectionRamp"] = "core/scripts/client/postFx/null_color_ramp.png";
            mColorCorrectionFileName = "core/scripts/client/postFx/null_color_ramp.png";

            SingletonCreator sts = new SingletonCreator("ShaderData", "HDR_BrightPassShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/brightPassFilterP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_DownScale4x4Shader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/hdr/downScale4x4V.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/downScale4x4P.hlsl";
            sts["pixVersion"] = 2.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_BloomGaussBlurHShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/bloomGaussBlurHP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_BloomGaussBlurVShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/bloomGaussBlurVP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_SampleLumShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/sampleLumInitialP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_DownSampleLumShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/sampleLumIterativeP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_CalcAdaptedLumShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/calculateAdaptedLumP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("ShaderData", "HDR_CombineShader");
            sts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            sts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/finalPassCombineP.hlsl";
            sts["pixVersion"] = 3.0;
            sts.Create();

            sts = new SingletonCreator("GFXStateBlockData", "HDR_SampleStateBlock : PFX_DefaultStateBlock");
            sts["samplersDefined"] = true;
            sts["samplerStates[0]"] = "SamplerClampPoint";
            sts["samplerStates[1]"] = "SamplerClampPoint";
            sts.Create();

            sts = new SingletonCreator("GFXStateBlockData", "HDR_DownSampleStateBlock : PFX_DefaultStateBlock");
            sts["samplersDefined"] = true;
            sts["samplerStates[0]"] = "SamplerClampLinear";
            sts["samplerStates[1]"] = "SamplerClampLinear";
            sts.Create();

            sts = new SingletonCreator("GFXStateBlockData", "HDR_CombineStateBlock : PFX_DefaultStateBlock");
            sts["samplersDefined"] = true;
            sts["samplerStates[0]"] = "SamplerClampPoint";
            sts["samplerStates[1]"] = "SamplerClampLinear";
            sts["samplerStates[2]"] = "SamplerClampLinear";
            sts["samplerStates[3]"] = "SamplerClampLinear";
            sts.Create();

            sts = new SingletonCreator("GFXStateBlockData", "HDRStateBlock");
            sts["samplersDefined"] = true;
            sts["samplerStates[0]"] = "SamplerClampLinear";
            sts["samplerStates[1]"] = "SamplerClampLinear";
            sts["samplerStates[2]"] = "SamplerClampLinear";
            sts["samplerStates[3]"] = "SamplerClampLinear";

            sts["blendDefined"] = true;
            sts["blendDest"] = "GFXBlendOne";
            sts["blendSrc"] = "GFXBlendZero";

            sts["zDefined"] = true;
            sts["zEnable"] = false;
            sts["zWriteEnable"] = false;

            sts["cullDefined"] = true;
            sts["cullMode"] = "GFXCullNone";
            sts.Create();

            SingletonCreator HDRPostFX = new SingletonCreator("PostEffect", "HDRPostFX", typeof (HDRPostEffect));
            HDRPostFX["isEnabled"] = false;
            HDRPostFX["allowReflectPass"] = false;

            // Resolve the HDR before we render any editor stuff
            // and before we resolve the scene to the backbuffer.
            HDRPostFX["renderTime"] = "PFXBeforeBin";
            HDRPostFX["renderBin"] = "EditorBin";
            HDRPostFX["renderPriority"] = 9999;

            // The bright pass generates a bloomed version of 
            // the scene for pixels which are brighter than a 
            // fixed threshold value.
            //
            // This is then used in the final HDR combine pass
            // at the end of this post effect chain.
            //

            HDRPostFX["shader"] = "HDR_BrightPassShader";
            HDRPostFX["stateBlock"] = "HDR_DownSampleStateBlock";
            HDRPostFX["texture[0]"] = "$backBuffer";
            HDRPostFX["texture[1]"] = "#adaptedLum";
            HDRPostFX["target"] = "$outTex";
            HDRPostFX["targetFormat"] = "GFXFormatR16G16B16A16F";
            HDRPostFX["targetScale"] = "0.5 0.5";

            ObjectCreator pe1 = new ObjectCreator("PostEffect", "HDRPostFX_DownScale4x4Shader");
            pe1["shader"] = "HDR_DownScale4x4Shader";
            pe1["stateBlock"] = "HDR_DownSampleStateBlock";
            pe1["texture[0]"] = "$inTex";
            pe1["target"] = "$outTex";
            pe1["targetFormat"] = "GFXFormatR16G16B16A16F";
            pe1["targetScale"] = "0.25 0.25";
            HDRPostFX["#1"] = pe1;

            ObjectCreator bloomH = new ObjectCreator("PostEffect", "HDRPostFX_bloomH");
            bloomH["internalName"] = "bloomH";
            bloomH["shader"] = "HDR_BloomGaussBlurHShader";
            bloomH["stateBlock"] = "HDR_DownSampleStateBlock";
            bloomH["texture[0]"] = "$inTex";
            bloomH["target"] = "$outTex";
            bloomH["targetFormat"] = "GFXFormatR16G16B16A16F";
            HDRPostFX["#2"] = bloomH;

            ObjectCreator bloomV = new ObjectCreator("PostEffect", "HDRPostFX_bloomV");
            bloomV["internalName"] = "bloomV";
            bloomV["shader"] = "HDR_BloomGaussBlurVShader";
            bloomV["stateBlock"] = "HDR_DownSampleStateBlock";
            bloomV["texture[0]"] = "$inTex";
            bloomV["target"] = "#bloomFinal";
            bloomV["targetFormat"] = "GFXFormatR16G16B16A16F";
            HDRPostFX["#3"] = bloomV;

            ObjectCreator adaptLum = new ObjectCreator("PostEffect", "HDRPostFX_adaptLum");

            #region adaptLum

            adaptLum["internalName"] = "adaptLum";
            adaptLum["shader"] = "HDR_SampleLumShader";
            adaptLum["stateBlock"] = "HDR_DownSampleStateBlock";
            adaptLum["texture[0]"] = "$backBuffer";
            adaptLum["target"] = "$outTex";
            adaptLum["targetScale"] = "0.0625 0.0625"; // 1/16th
            adaptLum["targetFormat"] = "GFXFormatR16F";

            ObjectCreator HDR_DownSampleLumShader1 = new ObjectCreator("PostEffect", "HDRPostFX_DownSampleLumShader1");
            HDR_DownSampleLumShader1["shader"] = "HDR_DownSampleLumShader";
            HDR_DownSampleLumShader1["stateBlock"] = "HDR_DownSampleStateBlock";
            HDR_DownSampleLumShader1["texture[0]"] = "$inTex";
            HDR_DownSampleLumShader1["target"] = "$outTex";
            HDR_DownSampleLumShader1["targetScale"] = "0.25 0.25"; // 1/4
            HDR_DownSampleLumShader1["targetFormat"] = "GFXFormatR16F";
            adaptLum["#1"] = HDR_DownSampleLumShader1;

            ObjectCreator HDR_DownSampleLumShader2 = new ObjectCreator("PostEffect", "HDRPostFX_DownSampleLumShader2");
            HDR_DownSampleLumShader2["shader"] = "HDR_DownSampleLumShader";
            HDR_DownSampleLumShader2["stateBlock"] = "HDR_DownSampleStateBlock";
            HDR_DownSampleLumShader2["texture[0]"] = "$inTex";
            HDR_DownSampleLumShader2["target"] = "$outTex";
            HDR_DownSampleLumShader2["targetScale"] = "0.25 0.25"; // 1/4
            HDR_DownSampleLumShader2["targetFormat"] = "GFXFormatR16F";
            adaptLum["#2"] = HDR_DownSampleLumShader2;

            ObjectCreator HDR_DownSampleLumShader3 = new ObjectCreator("PostEffect", "HDRPostFX_DownSampleLumShader3");
            HDR_DownSampleLumShader3["shader"] = "HDR_DownSampleLumShader";
            HDR_DownSampleLumShader3["stateBlock"] = "HDR_DownSampleStateBlock";
            HDR_DownSampleLumShader3["texture[0]"] = "$inTex";
            HDR_DownSampleLumShader3["target"] = "$outTex";
            HDR_DownSampleLumShader3["targetScale"] = "0.25 0.25"; // At this point the target should be 1x1.
            HDR_DownSampleLumShader3["targetFormat"] = "GFXFormatR16F";
            adaptLum["#3"] = HDR_DownSampleLumShader3;

            ObjectCreator finalLum = new ObjectCreator("PostEffect", "HDRPostFX_finalLum");
            finalLum["internalName"] = "finalLum";
            finalLum["shader"] = "HDR_CalcAdaptedLumShader";
            finalLum["stateBlock"] = "HDR_DownSampleStateBlock";
            finalLum["texture[0]"] = "$inTex";
            finalLum["texture[1]"] = "#adaptedLum";
            finalLum["target"] = "#adaptedLum";
            finalLum["targetFormat"] = "GFXFormatR16F";
            finalLum["targetClear"] = "PFXTargetClear_OnCreate";
            finalLum["targetClearColor"] = "1 1 1 1";
            adaptLum["#4"] = finalLum;

            #endregion

            HDRPostFX["#4"] = adaptLum;

            ObjectCreator combinePass = new ObjectCreator("PostEffect", "HDRPostFX_combinePass");
            combinePass["internalName"] = "combinePass";
            combinePass["shader"] = "HDR_CombineShader";
            combinePass["stateBlock"] = "HDR_CombineStateBlock";
            combinePass["texture[0]"] = "$backBuffer";
            combinePass["texture[1]"] = "#adaptedLum";
            combinePass["texture[2]"] = "#bloomFinal";
            combinePass["texture[3]"] = mColorCorrectionFileName; // "$HDRPostFX::colorCorrectionRamp";

            combinePass["target"] = "$backBuffer";
            HDRPostFX["#5"] = combinePass;

            HDRPostFX.Create();


            SingletonCreator ts = new SingletonCreator("ShaderData", "LuminanceVisShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/hdr/luminanceVisP.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "LuminanceVisStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts.Create();


            ts = new SingletonCreator("PostEffect", "LuminanceVisPostFX");
            ts["isEnabled"] = false;
            ts["allowReflectPass"] = false;

            // Render before we do any editor rendering.  
            ts["renderTime"] = "PFXBeforeBin";
            ts["renderBin"] = "EditorBin";
            ts["renderPriority"] = 9999;

            ts["shader"] = "LuminanceVisShader";
            ts["stateBlock"] = "LuminanceVisStateBlock";
            ts["texture[0]"] = "$backBuffer";
            ts["target"] = "$backBuffer";
            //targetScale = "0.0625 0.0625"; // 1/16th
            //targetFormat = "GFXFormatR16F";

            ts.Create();
            }
        }
    }