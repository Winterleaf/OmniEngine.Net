using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof(TypeConverterGeneric<CausticsPostEffect>))]
    public class CausticsPostEffect : PostEffect
        {


        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void preProcess()
        {
            Console.WriteLine("");
        }

        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "PFX_CausticsStateBlock : PFX_DefaultStateBlock");
            ts["blendDefined"] = true;
            ts["blendEnable"] = true;
            ts["blendSrc"] = "GFXBlendOne";
            ts["blendDest"] = "GFXBlendOne";

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerWrapLinear";
            ts["samplerStates[2]"] = "SamplerWrapLinear";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_CausticsShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/caustics/causticsP.hlsl";

            //OGLVertexShaderFile  = "shaders/common/postFx/gl//postFxV.glsl";
            //OGLPixelShaderFile   = "shaders/common/postFx/gl/passthruP.glsl";

            ts["samplerNames[0]"] = "$prepassTex";
            ts["samplerNames[1]"] = "$causticsTex1";
            ts["samplerNames[2]"] = "$causticsTex2";

            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "CausticsPFX", typeof(CausticsPostEffect));
            ts["requirements"] = "None";
            ts["isEnabled"] = false;
            ts["renderTime"] = "PFXBeforeBin";
            ts["renderBin"] = "ObjTranslucentBin";
            //renderPriority = 0.1;

            ts["shader"] = "PFX_CausticsShader";
            ts["stateBlock"] = "PFX_CausticsStateBlock";
            ts["texture[0]"] = "#prepass";
            ts["texture[1]"] = "core/scripts/client/postFx/textures/caustics_1.png";
            ts["texture[2]"] = "core/scripts/client/postFx/textures/caustics_2.png";
            ts["target"] = "$backBuffer";
            ts.Create();

            
            omni.iGlobal["$CausticsPFX::refTime"] = omni.Util.getSimTime();
            omni.sGlobal["$CausticsPFX::color"] = "1.0 1.0 1.0 1.0";
            }

        //private static  CausticsPostEffect cpf;

        public override void setShaderConsts()
            {
            //cpf.texture[1] = new TypeImageFilename( "core/scripts/client/postFx/textures/caustics_1.png");
            //cpf.texture[2] = new TypeImageFilename( "core/scripts/client/postFx/textures/caustics_2.png");

            this.setShaderConst("$refTime", omni.sGlobal["$CausticsPFX::refTime"]);
            setShaderConst("$colorize", omni.sGlobal["$CausticsPFX::color"]);
            }
        }
    }