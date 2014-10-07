#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<EdgeAAPostEffect>))]
    public class EdgeAAPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "PFX_DefaultEdgeAAStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            //samplerStates[1] = SamplerWrapPoint;
            ts.Create();


            ts = new SingletonCreator("ShaderData", "PFX_EdgeAADetectShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/edgeaa/edgeDetectP.hlsl";

            //OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
            //OGLPixelShaderFile   = "shaders/common/postFx/gl/passthruP.glsl";

            ts["samplerNames[0]"] = "$inputTex";

            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_EdgeAAShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/edgeaa/edgeAAV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/edgeaa/edgeAAP.hlsl";

            //OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
            //OGLPixelShaderFile   = "shaders/common/postFx/gl/passthruP.glsl";

            ts["samplerNames[0]"] = "$inputTex";

            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_EdgeAADebugShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/edgeaa/dbgEdgeDisplayP.hlsl";

            //OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
            //OGLPixelShaderFile   = "shaders/common/postFx/gl/passthruP.glsl";

            ts["samplerNames[0]"] = "$inputTex";

            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "EdgeDetectPostEffect");
            ts["renderTime"] = "PFXBeforeBin";
            ts["renderBin"] = "ObjTranslucentBin";
            //renderPriority = 0.1;
            ts["targetScale"] = "0.5 0.5";

            ts["shader"] = "PFX_EdgeAADetectShader";
            ts["stateBlock"] = "PFX_DefaultEdgeAAStateBlock";
            ts["texture[0]"] = "#prepass";
            ts["target"] = "#edge";

            ts["isEnabled"] = false;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "EdgeAAPostEffect", typeof (EdgeAAPostEffect));
            ts["renderTime"] = "PFXAfterDiffuse";
            //renderBin = "ObjTranslucentBin";      
            //renderPriority = 0.1;

            ts["shader"] = "PFX_EdgeAAShader";
            ts["stateBlock"] = "PFX_DefaultEdgeAAStateBlock";
            ts["texture[0]"] = "#edge";
            ts["texture[1]"] = "$backBuffer";
            ts["target"] = "$backBuffer";
            ts.Create();

            ts = new SingletonCreator("PostEffect", "Debug_EdgeAAPostEffect");
            ts["renderTime"] = "PFXAfterDiffuse";
            //renderBin = "ObjTranslucentBin";      
            //renderPriority = 0.1;

            ts["shader"] = "PFX_EdgeAADebugShader";
            ts["stateBlock"] = "PFX_DefaultEdgeAAStateBlock";
            ts["texture[0]"] = "#edge";
            ts["target"] = "$backBuffer";
            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }