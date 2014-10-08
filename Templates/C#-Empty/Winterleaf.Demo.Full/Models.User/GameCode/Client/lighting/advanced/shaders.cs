using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.advanced
    {
    public class shaders
        {
        public static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            ObjectCreator tch = new ObjectCreator("GFXStateBlockData", "AL_VectorLightState");

            tch["blendDefined"] = true;
            tch["blendEnable"] = true;
            tch["blendSrc"] = "GFXBlendOne";
            tch["blendDest"] = "GFXBlendOne";
            tch["blendOp"] = "GFXBlendOpAdd";

            tch["zDefined"] = true;
            tch["zEnable"] = false;
            tch["zWriteEnable"] = false;

            tch["samplersDefined"] = true;
            tch["samplerStates[0]"] = "SamplerClampPoint"; // G-buffer
            tch["samplerStates[1]"] = "SamplerClampPoint";
            // Shadow Map (Do not change this to linear, as all cards can not filter equally.)
            tch["samplerStates[2]"] = "SamplerClampLinear"; // SSAO Mask
            tch["samplerStates[3]"] = "SamplerWrapPoint"; // Random Direction Map

            tch["cullDefined"] = true;
            tch["cullMode"] = "GFXCullNone";

            tch["stencilDefined"] = true;
            tch["stencilEnable"] = true;
            tch["stencilFailOp"] = "GFXStencilOpKeep";
            tch["stencilZFailOp"] = "GFXStencilOpKeep";
            tch["stencilPassOp"] = "GFXStencilOpKeep";
            tch["stencilFunc"] = "GFXCmpLess";
            tch["stencilRef"] = 0;
            tch.Create();

            // Vector Light Material
            tch = new ObjectCreator("ShaderData", "AL_VectorLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/farFrustumQuadV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/vectorLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/farFrustumQuadV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/vectorLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_VectorLightMaterial");
            tch["shader"] = "AL_VectorLightShader";
            tch["stateBlock"] = "AL_VectorLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["sampler[\"ShadowMap\"]"] = "$dynamiclight";
            tch["sampler[\"ssaoMask\"]"] = "#ssaoMask";

            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;
            tch.Create();

            // Convex-geometry light states
            tch = new ObjectCreator("GFXStateBlockData", "AL_ConvexLightState");
            tch["blendDefined"] = true;
            tch["blendEnable"] = true;
            tch["blendSrc"] = "GFXBlendOne";
            tch["blendDest"] = "GFXBlendOne";
            tch["blendOp"] = "GFXBlendOpAdd";

            tch["zDefined"] = true;
            tch["zEnable"] = true;
            tch["zWriteEnable"] = false;
            tch["zFunc"] = "GFXCmpGreaterEqual";

            tch["samplersDefined"] = true;
            tch["samplerStates[0]"] = "SamplerClampPoint"; // G-buffer
            tch["samplerStates[1]"] = "SamplerClampPoint";
            // Shadow Map (Do not use linear, these are perspective projections)
            tch["samplerStates[2]"] = "SamplerClampLinear"; // Cookie Map   
            tch["samplerStates[3]"] = "SamplerWrapPoint"; // Random Direction Map

            tch["cullDefined"] = true;
            tch["cullMode"] = "GFXCullCW";

            tch["stencilDefined"] = true;
            tch["stencilEnable"] = true;
            tch["stencilFailOp"] = "GFXStencilOpKeep";
            tch["stencilZFailOp"] = "GFXStencilOpKeep";
            tch["stencilPassOp"] = "GFXStencilOpKeep";
            tch["stencilFunc"] = "GFXCmpLess";
            tch["stencilRef"] = 0;
            tch.Create();

            // Point Light Material
            tch = new ObjectCreator("ShaderData", "AL_PointLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/convexGeometryV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/pointLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/convexGeometryV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/pointLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_PointLightMaterial");
            tch["shader"] = "AL_PointLightShader";
            tch["stateBlock"] = "AL_ConvexLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["sampler[\"shadowMap\"]"] = "$dynamiclight";
            tch["sampler[\"cookieTex\"]"] = "$dynamiclightmask";

            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;
            tch.Create();

            // Spot Light Material
            tch = new ObjectCreator("ShaderData", "AL_SpotLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/convexGeometryV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/spotLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/convexGeometryV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/spotLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_SpotLightMaterial");
            tch["shader"] = "AL_SpotLightShader";
            tch["stateBlock"] = "AL_ConvexLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["sampler[\"shadowMap\"]"] = "$dynamiclight";
            tch["sampler[\"cookieTex\"]"] = "$dynamiclightmask";

            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;

            tch.Create();

            // This material is used for generating prepass 
            // materials for objects that do not have materials.
            tch = new ObjectCreator("Material", "AL_DefaultPrePassMaterial");
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //
            tch["diffuseColor[0]"] = "1 1 1 1";
            tch.Create();

            // This material is used for generating shadow 
            // materials for objects that do not have materials.
            tch = new ObjectCreator("Material", "AL_DefaultShadowMaterial");
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //
            tch["diffuseColor[0]"] = "1 1 1 1";

            // This is here mostly for terrain which uses
            // this material to create its shadow material.
            //
            // At sunset/sunrise the sun is looking thru 
            // backsides of the terrain which often are not
            // closed.  By changing the material to be double
            // sided we avoid holes in the shadowed geometry.
            //
            tch["doubleSided"] = true;
            tch.Create();

            // Particle System Point Light Material
            tch = new ObjectCreator("ShaderData", "AL_ParticlePointLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/particlePointLightV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/particlePointLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/convexGeometryV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/pointLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_ParticlePointLightMaterial");
            tch["shader"] = "AL_ParticlePointLightShader";
            tch["stateBlock"] = "AL_ConvexLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;
            tch.Create();
            }
        }
    }