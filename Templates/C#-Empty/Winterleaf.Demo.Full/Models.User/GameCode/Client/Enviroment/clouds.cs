using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Enviroment
    {
    public class clouds
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("ShaderData", "CloudLayerShader");
            sc["DXVertexShaderFile"] = "shaders/common/cloudLayerV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/cloudLayerP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/cloudLayerV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/cloudLayerP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();

            sc = new SingletonCreator("ShaderData", "BasicCloudsShader");
            sc["DXVertexShaderFile"] = "shaders/common/basicCloudsV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/basicCloudsP.hlsl";

            //OGLVertexShaderFile = "shaders/common/gl/basicCloudsV.glsl";
            //OGLPixelShaderFile = "shaders/common/gl/basicCloudsP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();
            }
        }
    }