#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<ChromaticLensPostFX>))]
    public class ChromaticLensPostFX : PostEffect
        {
        

        public static void initialize()
            {
            omni.bGlobal["$CAPostFx::enabled"] = false;

            // The lens distortion coefficient.
            omni.dGlobal["$CAPostFx::distCoeffecient"] = -0.05;

            // The cubic distortion value.
            omni.dGlobal["$CAPostFx::cubeDistortionFactor"] = -0.1;

            // The amount and direction of the maxium shift for
            // the red, green, and blue channels.
            omni.sGlobal["$CAPostFx::colorDistortionFactor"] = "0.005 -0.005 0.01";

            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "PFX_DefaultChromaticLensStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_ChromaticLensShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/chromaticLens.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "ChromaticLensPostFX", typeof (ChromaticLensPostFX));
            ts["renderTime"] = "PFXAfterDiffuse";
            ts["renderPriority"] = 0.2;
            ts["isEnabled"] = false;
            ts["allowReflectPass"] = false;

            ts["shader"] = "PFX_ChromaticLensShader";
            ts["stateBlock"] = "PFX_DefaultChromaticLensStateBlock";
            ts["texture[0]"] = "$backBuffer";
            ts["target"] = "$backBuffer";
            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void setShaderConsts()
            {
            setShaderConst("$distCoeff", sGlobal["$CAPostFx::distCoeffecient"]);
            setShaderConst("$cubeDistort", sGlobal["$CAPostFx::cubeDistortionFactor"]);
            setShaderConst("$colorDistort", sGlobal["$CAPostFx::colorDistortionFactor"]);
            }
        }
    }