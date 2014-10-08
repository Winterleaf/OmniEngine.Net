using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Enviroment
    {
    public class water
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("ShaderData", "WaterShader");
            sc["DXVertexShaderFile"] = "shaders/common/water/waterV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/water/waterP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/water/gl/waterV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/water/gl/waterP.glsl";

            sc["pixVersion"] = 3.0;
            sc.Create();

            sc = new SingletonCreator("GFXSamplerStateData", "WaterSampler");
            sc["textureColorOp"] = "GFXTOPModulate";
            sc["addressModeU"] = "GFXAddressWrap";
            sc["addressModeV"] = "GFXAddressWrap";
            sc["addressModeW"] = "GFXAddressWrap";
            sc["magFilter"] = "GFXTextureFilterLinear";
            sc["minFilter"] = "GFXTextureFilterAnisotropic";
            sc["mipFilter"] = "GFXTextureFilterLinear";
            sc["maxAnisotropy"] = 4;
            sc.Create();

            sc = new SingletonCreator("GFXStateBlockData", "WaterStateBlock");
            sc["samplersDefined"] = true;
            sc["samplerStates[0]"] = "WaterSampler"; // noise
            sc["samplerStates[1]"] = "SamplerClampPoint"; // #prepass
            sc["samplerStates[2]"] = "SamplerClampLinear"; // $reflectbuff
            sc["samplerStates[3]"] = "SamplerClampPoint"; // $backbuff
            sc["samplerStates[4]"] = "SamplerWrapLinear"; // $cubemap   
            sc["samplerStates[5]"] = "SamplerWrapLinear"; // foam     
            sc["samplerStates[6]"] = "SamplerClampLinear"; // depthMap ( color gradient ) 
            sc["cullDefined"] = true;
            sc["cullMode"] = "GFXCullCCW";
            sc.Create();

            sc = new SingletonCreator("GFXStateBlockData", "UnderWaterStateBlock : WaterStateBlock");
            sc["cullMode"] = "GFXCullCW";
            sc.Create();

            sc = new SingletonCreator("CustomMaterial", "WaterMat");
            sc["sampler[\"prepassTex\"]"] = "#prepass";
            sc["sampler[\"reflectMap\"]"] = "$reflectbuff";
            sc["sampler[\"refractBuff\"]"] = "$backbuff";

            sc["shader"] = "WaterShader";
            sc["stateBlock"] = "WaterStateBlock";
            sc["version"] = 3.0;

            sc["useAnisotropic[0]"] = true;
            sc.Create();

            //-----------------------------------------------------------------------------
            // Underwater
            //-----------------------------------------------------------------------------

            sc = new SingletonCreator("ShaderData", "UnderWaterShader");
            sc["DXVertexShaderFile"] = "shaders/common/water/waterV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/water/waterP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/water/gl/waterV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/water/gl/waterP.glsl";

            sc["defines"] = "UNDERWATER";
            sc["pixVersion"] = 3.0;
            sc.Create();

            sc = new SingletonCreator("CustomMaterial", "UnderwaterMat");
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.   
            //sampler["bumpMap"] = "core/art/water/noise02";
            //sampler["foamMap"] = "core/art/water/foam";
            sc["sampler[\"prepassTex\"]"] = "#prepass";
            sc["sampler[\"reflectMap\"]"] = "$reflectbuff";
            sc["sampler[\"refractBuff\"]"] = "$backbuff";

            sc["shader"] = "UnderWaterShader";
            sc["stateBlock"] = "UnderWaterStateBlock";
            sc["specular"] = "0.75 0.75 0.75 1.0";
            sc["specularPower"] = 48.0;
            sc["version"] = 3.0;
            sc.Create();

            //-----------------------------------------------------------------------------
            // Basic Water
            //-----------------------------------------------------------------------------

            sc = new SingletonCreator("ShaderData", "WaterBasicShader");
            sc["DXVertexShaderFile"] = "shaders/common/water/waterBasicV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/water/waterBasicP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/water/gl/waterBasicV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/water/gl/waterBasicP.glsl";

            sc["pixVersion"] = 2.0;
            sc.Create();

            sc = new SingletonCreator("GFXStateBlockData", "WaterBasicStateBlock");
            sc["samplersDefined"] = true;
            sc["samplerStates[0]"] = "WaterSampler"; // noise
            sc["samplerStates[2]"] = "SamplerClampLinear"; // $reflectbuff
            sc["samplerStates[3]"] = "SamplerClampPoint"; // $backbuff
            sc["samplerStates[4]"] = "SamplerWrapLinear"; // $cubemap
            sc["cullDefined"] = true;
            sc["cullMode"] = "GFXCullCCW";
            sc.Create();

            sc = new SingletonCreator("GFXStateBlockData", "UnderWaterBasicStateBlock : WaterBasicStateBlock");
            sc["cullMode"] = "GFXCullCW";
            sc.Create();

            sc = new SingletonCreator("CustomMaterial", "WaterBasicMat");
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.     
            //sampler["bumpMap"] = "core/art/water/noise02";
            //sampler["skyMap"] = "$cubemap";   

            //sampler["prepassTex"] = "#prepass";
            sc["sampler[\"reflectMap\"]"] = "$reflectbuff";
            sc["sampler[\"refractBuff\"]"] = "$backbuff";

            sc["cubemap"] = "NewLevelSkyCubemap";
            sc["shader"] = "WaterBasicShader";
            sc["stateBlock"] = "WaterBasicStateBlock";
            sc["version"] = 2.0;
            sc.Create();

            //-----------------------------------------------------------------------------
            // Basic UnderWater
            //-----------------------------------------------------------------------------

            sc = new SingletonCreator("ShaderData", "UnderWaterBasicShader");
            sc["DXVertexShaderFile"] = "shaders/common/water/waterBasicV.hlsl";
            sc["DXPixelShaderFile"] = "shaders/common/water/waterBasicP.hlsl";

            sc["OGLVertexShaderFile"] = "shaders/common/water/gl/waterBasicV.glsl";
            sc["OGLPixelShaderFile"] = "shaders/common/water/gl/waterBasicP.glsl";

            sc["defines"] = "UNDERWATER=2";
            sc["pixVersion"] = 2.0;
            sc.Create();

            sc = new SingletonCreator("CustomMaterial", "UnderwaterBasicMat");
            // These samplers are set in code not here.
            // This is to allow different WaterObject instances
            // to use this same material but override these textures
            // per instance.  
            //sampler["bumpMap"] = "core/art/water/noise02";
            //samplers["skyMap"] = "$cubemap";  

            //sampler["prepassTex"] = "#prepass";
            sc["sampler[\"refractBuff\"]"] = "$backbuff";

            sc["shader"] = "UnderWaterBasicShader";
            sc["stateBlock"] = "UnderWaterBasicStateBlock";
            sc["version"] = 2.0;
            sc.Create();
            }
        }
    }