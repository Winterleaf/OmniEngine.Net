using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class shaders
        {
        public static void initialize_CustomShaders()
            {
            //*****************************************************************************
            // Shaders  ( For Custom Materials )
            //*****************************************************************************
            }

        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("ShaderData", "ParticlesShaderData");
            sc["DXVertexShaderFile"] = "shaders/common/particlesV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/particlesP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/particlesV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/particlesP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();

            sc = new SingletonCreator("ShaderData", "OffscreenParticleCompositeShaderData");
            sc["DXVertexShaderFile"] = "shaders/common/particleCompositeV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/particleCompositeP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/particleCompositeV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/particleCompositeP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();

            //-----------------------------------------------------------------------------
            // Planar Reflection
            //-----------------------------------------------------------------------------

            sc = new SingletonCreator("ShaderData", "ReflectBump");
            sc["DXVertexShaderFile"] = "shaders/common/planarReflectBumpV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/planarReflectBumpP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/planarReflectBumpV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/planarReflectBumpP.glsl";

            sc["samplerNames[0]"] = "$diffuseMap";
            sc["samplerNames[1]"] = "$refractMap";
            sc["samplerNames[2]"] = "$bumpMap";

            sc["pixVersion"] = 2.0;
            sc.Create();

            sc = new SingletonCreator("ShaderData", "Reflect");
            sc["DXVertexShaderFile"] = "shaders/common/planarReflectV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/planarReflectP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/planarReflectV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/planarReflectP.glsl";

            sc["samplerNames[0]"] = "$diffuseMap";
            sc["samplerNames[1]"] = "$refractMap";

            sc["pixVersion"] = 1.4;
            sc.Create();

            //-----------------------------------------------------------------------------
            // fxFoliageReplicator
            //-----------------------------------------------------------------------------
            sc = new SingletonCreator("ShaderData", "fxFoliageReplicatorShader");
            sc["DXVertexShaderFile"] = "shaders/common/fxFoliageReplicatorV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/fxFoliageReplicatorP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/gl/fxFoliageReplicatorV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/gl/fxFoliageReplicatorP.glsl";

            sc["samplerNames[0]"] = "$diffuseMap";
            sc["samplerNames[1]"] = "$alphaMap";

            sc["pixVersion"] = 1.4;
            sc.Create();

            sc = new SingletonCreator("ShaderData", "VolumetricFogPrePassShader");
            sc["DXVertexShaderFile"] = "shaders/common/VolumetricFog/VFogPreV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/VolumetricFog/VFogPreP.hlsl";
            sc["pixVersion"] = 3.0;
            sc.Create();

            sc = new SingletonCreator("ShaderData", "VolumetricFogShader");
            sc["DXVertexShaderFile"] = "shaders/common/VolumetricFog/VFogV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/VolumetricFog/VFogP.hlsl";
            sc["pixVersion"] = 3.0;
            sc.Create();
            }
        }
    }