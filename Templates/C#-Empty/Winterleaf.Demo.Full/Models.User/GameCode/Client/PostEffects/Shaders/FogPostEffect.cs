#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<FogPostEffect>))]
    public class FogPostEffect : PostEffect
        {
        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("ShaderData", "FogPassShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/fogP.hlsl";

            //   OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
            //   OGLPixelShaderFile   = "shaders/common/postFx/gl/fogP.glsl";

            ts["samplerNames[0]"] = "$prepassTex";
            ts["samplerNames[1]"] = "$backbuffer";

            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "FogPassStateBlock : PFX_DefaultStateBlock");
            ts["blendDefined"] = true;
            ts["blendEnable"] = true;
            ts["blendSrc"] = "GFXBlendSrcAlpha";
            ts["blendDest"] = "GFXBlendInvSrcAlpha";
            ts.Create();

            ts = new SingletonCreator("PostEffect", "FogPostFx", typeof (FogPostEffect));
            // We forward render the reflection pass
            // so it does its own fogging.
            ts["allowReflectPass"] = false;

            ts["renderTime"] = "PFXBeforeBin";
            ts["renderBin"] = "ObjTranslucentBin";

            ts["shader"] = "FogPassShader";
            ts["stateBlock"] = "FogPassStateBlock";
            ts["texture[0]"] = "#prepass";
            ts["texture[1]"] = "$backBuffer";

            ts["renderPriority"] = 5;

            ts["isEnabled"] = true;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "UnderwaterFogPassShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/underwaterFogP.hlsl";

            //   OGLVertexShaderFile  = "shaders/common/postFx/gl/postFxV.glsl";
            //   OGLPixelShaderFile   = "shaders/common/postFx/gl/fogP.glsl";

            ts["samplerNames[0]"] = "$prepassTex";
            ts["samplerNames[1]"] = "$backbuffer";

            ts["pixVersion"] = 2.0;
            ts.Create();


            ts = new SingletonCreator("GFXStateBlockData", "UnderwaterFogPassStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            ts["samplerStates[1]"] = "SamplerClampPoint";
            ts["samplerStates[2]"] = "SamplerClampLinear";
            ts.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }
        }
    }