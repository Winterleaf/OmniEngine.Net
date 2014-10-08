using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.shadowMaps
    {
    public class init
        {
        public static void initialize()
            {
            ObjectCreator tch = new ObjectCreator("ShaderData", "BlurDepthShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/shadowMap/boxFilterV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/shadowMap/boxFilterP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/shadowMap/gl/boxFilterV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/shadowMap/gl/boxFilterP.glsl";
            tch["pixVersion"] = 2.0;
            tch.Create();
            }
        }
    }