using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<MotionBlurPostEffect>))]
    public class MotionBlurPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("ShaderData", "PFX_MotionBlurShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl"; //we use the bare-bones postFxV.hlsl
            ts["DXPixelShaderFile"] = "shaders/common/postFx/motionBlurP.hlsl"; //new pixel shader
            ts["pixVersion"] = 3.0;
            ts.Create();

            SingletonCreator MotionBlurFX = new SingletonCreator("PostEffect", "MotionBlurFX",
                typeof (MotionBlurPostEffect));
            MotionBlurFX["isEnabled"] = false;
            MotionBlurFX["renderTime"] = "PFXAfterDiffuse";
            MotionBlurFX["shader"] = "PFX_MotionBlurShader";
            MotionBlurFX["stateBlock"] = "PFX_DefaultStateBlock";
            MotionBlurFX["texture[0]"] = "$backbuffer";
            MotionBlurFX["texture[1]"] = "#prepass";
            MotionBlurFX["target"] = "$backBuffer";
            MotionBlurFX.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void setShaderConsts()
            {
            setShaderConst("$velocityMultiplier", "3000");
            }
        }
    }