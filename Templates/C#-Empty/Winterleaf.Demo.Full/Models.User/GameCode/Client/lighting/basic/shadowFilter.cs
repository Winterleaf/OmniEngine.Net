using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.basic
    {
    public class shadowFilter
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("ShaderData", "BL_ShadowFilterShaderV");
            ts["DXVertexShaderFile"] = "shaders/common/lighting/basic/shadowFilterV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/lighting/basic/shadowFilterP.hlsl";

            ts["OGLVertexShaderFile"] = "shaders/common/lighting/basic/gl/shadowFilterV.glsl";
            ts["OGLPixelShaderFile"] = "shaders/common/lighting/basic/gl/shadowFilterP.glsl";

            ts["samplerNames[0]"] = "$diffuseMap";

            ts["defines"] = "BLUR_DIR=float2(1.0,0.0)";

            ts["pixVersion"] = 2.0;
            ts.Create();
            ts = new SingletonCreator("ShaderData", "BL_ShadowFilterShaderH : BL_ShadowFilterShaderV");
            ts["defines"] = "BLUR_DIR=float2(0.0,1.0)";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "BL_ShadowFilterSB : PFX_DefaultStateBlock");
            ts["colorWriteDefined"] = true;
            ts["colorWriteRed"] = false;
            ts["colorWriteGreen"] = false;
            ts["colorWriteBlue"] = false;
            ts["blendDefined"] = true;
            ts["blendEnable"] = true;
            ts.Create();
            BL_ShadowFilterPostEffect.initialize();
            }
        }
    }