using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Enviroment
    {
    public class terrainBlock
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("ShaderData", "TerrainBlendShader");
            sc["DXVertexShaderFile"] = "shaders/common/terrain/blendV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/terrain/blendP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/terrain/gl/blendV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/terrain/gl/blendP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();
            }
        }
    }