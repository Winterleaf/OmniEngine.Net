using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<OVRBarrelDistortionMonoPostEffect>))]
    public class OVRBarrelDistortionMonoPostEffect : PostEffect
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void initialize()
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive"))
                return;

            SingletonCreator ts = new SingletonCreator("ShaderData", "OVRMonoToStereoShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/oculusvr/monoToStereoP.hlsl";
            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "OVRBarrelDistortionShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/oculusvr/barrelDistortionP.hlsl";
            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "OVRBarrelDistortionChromaShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/oculusvr/barrelDistortionChromaP.hlsl";
            ts["pixVersion"] = "2.0";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "OVRBarrelDistortionStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("BarrelDistortionPostEffect", "OVRBarrelDistortionPostFX");
            ts["isEnabled"] = false;
            ts["allowReflectPass"] = false;

            ts["renderTime"] = "PFXAfterDiffuse";
            ts["renderPriority"] = 100;

            // The barrel distortion   
            ts["shader"] = "OVRBarrelDistortionShader";
            ts["stateBlock"] = "OVRBarrelDistortionStateBlock";

            ts["texture[0]"] = "$backBuffer";

            ts["scaleOutput"] = 1.25;
            ts.Create();

            //-----------------------------------------------------------------------------
            SingletonCreator OVRBarrelDistortionChromaPostFX = new SingletonCreator("BarrelDistortionPostEffect",
                "OVRBarrelDistortionChromaPostFX", typeof (OVRBarrelDistortionMonoPostEffect));

            OVRBarrelDistortionChromaPostFX["isEnabled"] = false;
            OVRBarrelDistortionChromaPostFX["allowReflectPass"] = false;

            OVRBarrelDistortionChromaPostFX["renderTime"] = "PFXAfterDiffuse";
            OVRBarrelDistortionChromaPostFX["renderPriority"] = 100;

            OVRBarrelDistortionChromaPostFX["shader"] = "OVRBarrelDistortionChromaShader";
            OVRBarrelDistortionChromaPostFX["stateBlock"] = "OVRBarrelDistortionStateBlock";

            OVRBarrelDistortionChromaPostFX["texture[0]"] = "$backBuffer";

            OVRBarrelDistortionChromaPostFX["scaleOutput"] = 1.25;
            //-----------------------------------------------------------------------------

            SingletonCreator OVRBarrelDistortionMonoPostFX = new SingletonCreator("PostEffect",
                "OVRBarrelDistortionMonoPostFX", typeof (OVRBarrelDistortionMonoPostEffect));
            OVRBarrelDistortionMonoPostFX["isEnabled"] = false;
            OVRBarrelDistortionMonoPostFX["allowReflectPass"] = false;

            OVRBarrelDistortionMonoPostFX["renderTime"] = "PFXAfterDiffuse";
            OVRBarrelDistortionMonoPostFX["renderPriority"] = 100;

            // Converts the mono display to a stereo one   
            OVRBarrelDistortionMonoPostFX["shader"] = "OVRMonoToStereoShader";
            OVRBarrelDistortionMonoPostFX["stateBlock"] = "OVRBarrelDistortionStateBlock";

            OVRBarrelDistortionMonoPostFX["texture[0]"] = "$backBuffer";
            OVRBarrelDistortionMonoPostFX["target"] = "$outTex";

            // The actual barrel distortion   

            ObjectCreator tch = new ObjectCreator("BarrelDistortionPostEffect", "OVRBarrelDistortionMonoStage2PostFX");
            tch["shader"] = "OVRBarrelDistortionShader";
            tch["stateBlock"] = "OVRBarrelDistortionStateBlock";
            tch["texture[0]"] = "$inTex";
            tch["target"] = "$backBuffer";
            tch["scaleOutput"] = 1.25;
            OVRBarrelDistortionMonoPostFX["#1"] = tch;
            OVRBarrelDistortionMonoPostFX.Create();
            }

        public override void setShaderConsts()
            {
            string xOffsets = omni.console.Call("getOVRHMDEyeXOffsets", new string[] {"0"});
            setShaderConst("$LensXOffsets", xOffsets);
            }
        }
    }