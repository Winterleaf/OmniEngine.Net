#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<GlowPostEffect>))]
    public class GlowPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("ShaderData", "PFX_GlowBlurVertShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/glowBlurV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/glowBlurP.hlsl";

            //   OGLVertexShaderFile  = "shaders/common/postFx/glowBlurV.glsl";
            //   OGLPixelShaderFile   = "shaders/common/postFx/glowBlurP.glsl";

            ts["defines"] = "BLUR_DIR=float2(0.0,1.0)";

            ts["samplerNames[0]"] = "$diffuseMap";

            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_GlowBlurHorzShader : PFX_GlowBlurVertShader");
            ts["defines"] = "BLUR_DIR=float2(1.0,0.0)";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "PFX_GlowCombineStateBlock : PFX_DefaultStateBlock ");
            // Use alpha test to save some fillrate 
            // on the non-glowing areas of the scene.
            ts["alphaDefined"] = true;
            ts["alphaTestEnable"] = true;
            ts["alphaTestRef"] = 1;
            ts["alphaTestFunc"] = "GFXCmpGreaterEqual";

            // Do a one to one blend.
            ts["blendDefined"] = true;
            ts["blendEnable"] = true;
            ts["blendSrc"] = "GFXBlendOne";
            ts["blendDest"] = "GFXBlendOne";
            ts.Create();

            ts = new SingletonCreator("PostEffect", "GlowPostFx", typeof (GlowPostEffect));
            // Do not allow the glow effect to work in reflection 
            // passes by default so we don't do the extra drawing.
            ts["allowReflectPass"] = false;

            ts["renderTime"] = "PFXAfterBin";
            ts["renderBin"] = "GlowBin";
            ts["renderPriority"] = 1;

            // First we down sample the glow buffer.   
            ts["shader"] = "PFX_PassthruShader";
            ts["stateBlock"] = "PFX_DefaultStateBlock";
            ts["texture[0]"] = "#glowbuffer";
            ts["target"] = "$outTex";
            ts["targetScale"] = "0.5 0.5";

            ts["isEnabled"] = true;

            // Blur vertically
            ObjectCreator tch = new ObjectCreator("PostEffect", "GlowPostFx_VertShader");
            tch["shader"] = "PFX_GlowBlurVertShader";
            tch["stateBlock"] = "PFX_DefaultStateBlock";
            tch["texture[0]"] = "$inTex";
            tch["target"] = "$outTex";
            ts["#1"] = tch;

            ObjectCreator tch1 = new ObjectCreator("PostEffect", "GlowPostFx_HorzShader");
            tch1["shader"] = "PFX_GlowBlurHorzShader";
            tch1["stateBlock"] = "PFX_DefaultStateBlock";
            tch1["texture[0]"] = "$inTex";
            tch1["target"] = "$outTex";
            ts["#2"] = tch1;

            ObjectCreator tch2 = new ObjectCreator("PostEffect", "GlowPostFx_PassThru");
            tch2["shader"] = "PFX_PassthruShader";
            tch2["stateBlock"] = "PFX_GlowCombineStateBlock";
            tch2["texture[0]"] = "$inTex";
            tch2["target"] = "$backBuffer";
            ts["#3"] = tch2;

            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }