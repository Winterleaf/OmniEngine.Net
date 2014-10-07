using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Enviroment
    {
    public class scatterSky
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("GFXStateBlockData", "ScatterSkySBData");
            sc["cullDefined"] = true;
            sc["cullMode"] = "GFXCullNone";

            sc["zDefined"] = true;
            sc["zEnable"] = true;
            sc["zWriteEnable"] = false;
            sc["zFunc"] = "GFXCmpLessEqual";

            sc["samplersDefined"] = true;
            sc["samplerStates[0]"] = "SamplerClampLinear";
            sc["samplerStates[1]"] = "SamplerClampLinear";
            sc["vertexColorEnable"] = true;
            sc.Create();

            sc = new SingletonCreator("ShaderData", "ScatterSkyShaderData");
            sc["DXVertexShaderFile"] = "shaders/common/scatterSkyV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/scatterSkyP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/scatterSkyV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/scatterSkyP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();
            }
        }
    }