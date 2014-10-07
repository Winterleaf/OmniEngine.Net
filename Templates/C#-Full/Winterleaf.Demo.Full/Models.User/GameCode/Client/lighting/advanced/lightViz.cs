using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.advanced
    {
    public class lightViz
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            ObjectCreator tch = new ObjectCreator("GFXStateBlockData", "AL_DepthVisualizeState");
            tch["zDefined"] = true;
            tch["zEnable"] = false;
            tch["zWriteEnable"] = false;

            tch["samplersDefined"] = true;
            tch["samplerStates[0]"] = "SamplerClampPoint"; // depth    
            tch["samplerStates[1]"] = "SamplerClampLinear"; // viz color lookup
            tch.Create();

            tch = new ObjectCreator("GFXStateBlockData", "AL_DefaultVisualizeState");
            tch["blendDefined"] = true;
            tch["blendEnable"] = true;
            tch["blendSrc"] = "GFXBlendSrcAlpha";
            tch["blendDest"] = "GFXBlendInvSrcAlpha";

            tch["zDefined"] = true;
            tch["zEnable"] = false;
            tch["zWriteEnable"] = false;

            tch["samplersDefined"] = true;
            tch["samplerStates[0]"] = "SamplerClampPoint"; // #prepass
            tch["samplerStates[1]"] = "SamplerClampLinear"; // depthviz
            tch.Create();

            tch = new ObjectCreator("ShaderData", "AL_DepthVisualizeShader");
            tch["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/dbgDepthVisualizeP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/postFx/postFxV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/dbgDepthVisualizeP.glsl";

            tch["samplerNames[0]"] = "prepassBuffer";
            tch["samplerNames[1]"] = "depthViz";

            tch["pixVersion"] = 2.0;
            tch.Create();

            AL_DepthVisualPostEffect.initialize();

            tch = new ObjectCreator("ShaderData", "AL_NormalsVisualizeShader");
            tch["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/dbgNormalVisualizeP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/postFx/postFxV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/dbgNormalVisualizeP.glsl";

            tch["samplerNames[0]"] = "prepassTex";

            tch["pixVersion"] = 2.0;
            tch.Create();

            AL_NormalsVisualizePostEffect.initialize();
            tch = new ObjectCreator("ShaderData", "AL_LightColorVisualizeShader");
            tch["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/dbgLightColorVisualizeP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/postFx/postFxV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/dl/dbgLightColorVisualizeP.glsl";

            tch["samplerNames[0]"] = "lightInfoBuffer";

            tch["pixVersion"] = 2.0;
            tch.Create();

            AL_LightColorVisualizePostEffect.initialize();
            tch = new ObjectCreator("ShaderData", "AL_LightSpecularVisualizeShader");
            tch["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/dbgLightSpecularVisualizeP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/postFx/postFxV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/dl/dbgLightSpecularVisualizeP.glsl";

            tch["samplerNames[0]"] = "lightInfoBuffer";

            tch["pixVersion"] = 2.0;
            tch.Create();

            AL_LightSpecularVisualizePostEffect.initialize();
            }

        [ConsoleInteraction(true)]
        public static void toggleDepthViz(string enabled)
            {
            if (enabled == "")
                {
                omni.bGlobal["$AL_DepthVisualizeVar"] = !((PostEffect) "AL_DepthVisualize").isEnabled;
                ((PostEffect) "AL_DepthVisualize").toggle();
                }
            else if (enabled.AsBool())
                ((PostEffect) "AL_DepthVisualize").enable();
            else if (!enabled.AsBool())
                ((PostEffect) "AL_DepthVisualize").disable();
            }

        [ConsoleInteraction(true)]
        public static void toggleNormalsViz(string enabled)
            {
            if (enabled == "")
                {
                omni.bGlobal["$AL_NormalsVisualizeVar"] = !((PostEffect) "AL_NormalsVisualize").isEnabled;
                ((PostEffect) "AL_NormalsVisualize").toggle();
                }
            else if (enabled.AsBool())
                ((PostEffect) "AL_NormalsVisualize").enable();
            else if (!enabled.AsBool())
                ((PostEffect) "AL_NormalsVisualize").disable();
            }

        [ConsoleInteraction(true)]
        public static void toggleLightColorViz(string enabled)
            {
            if (enabled == "")
                {
                omni.bGlobal["$AL_LightColorVisualizeVar"] = !((PostEffect) "AL_LightColorVisualize").isEnabled;
                ((PostEffect) "AL_LightColorVisualize").toggle();
                }
            else if (enabled.AsBool())
                ((PostEffect) "AL_LightColorVisualize").enable();
            else if (!enabled.AsBool())
                ((PostEffect) "AL_LightColorVisualize").disable();
            }

        [ConsoleInteraction(true)]
        public static void toggleLightSpecularViz(string enabled)
            {
            if (enabled == "")
                {
                omni.bGlobal["$AL_LightSpecularVisualizeVar"] = !((PostEffect) "AL_LightSpecularVisualize").isEnabled;
                ((PostEffect) "AL_LightSpecularVisualize").toggle();
                }
            else if (enabled.AsBool())
                ((PostEffect) "AL_LightSpecularVisualize").enable();
            else if (!enabled.AsBool())
                ((PostEffect) "AL_LightSpecularVisualize").disable();
            }
        }
    }