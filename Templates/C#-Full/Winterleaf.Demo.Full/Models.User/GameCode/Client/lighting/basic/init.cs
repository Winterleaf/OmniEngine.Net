using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.basic
    {
    public class init
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            omni.console.print("\n--------- Initializing Shadow Filter ---------");
            shadowFilter.initialize();
            omni.console.print("\n--------- Finished Initializing Shadow Filter ---------");

            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "BL_ProjectedShadowSBData");
            ts["blendDefined"] = true;
            ts["blendEnable"] = true;
            ts["blendSrc"] = "GFXBlendDestColor";
            ts["blendDest"] = "GFXBlendZero";

            ts["zDefined"] = true;
            ts["zEnable"] = true;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["vertexColorEnable"] = true;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "BL_ProjectedShadowShaderData");
            ts["DXVertexShaderFile"] = "shaders/common/projectedShadowV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/projectedShadowP.hlsl";

            ts["OGLVertexShaderFile"] = "shaders/common/gl/projectedShadowV.glsl";
            ts["OGLPixelShaderFile"] = "shaders/common/gl/projectedShadowP.glsl";

            ts["pixVersion"] = 2.0;
            ts.Create();

            ts = new SingletonCreator("CustomMaterial", "BL_ProjectedShadowMaterial");
            ts["sampler[\"inputTex\"]"] = "$miscbuff";

            ts["shader"] = "BL_ProjectedShadowShaderData";
            ts["stateBlock"] = "BL_ProjectedShadowSBData";
            ts["version"] = 2.0;
            ts["forwardLit"] = true;
            ts.Create();
            }

        [ConsoleInteraction(true)]
        public static void onActivateBasicLM()
            {
            // If HDR is enabled... enable the special format token.
            if ((omni.sGlobal["$platform"] == "macos") || ((PostEffect) "HDRPostFx").isEnabledX())
                ((RenderFormatToken) "AL_FormatToken").enable();
            // Create render pass for projected shadow.

            RenderPassManager BL_ProjectedShadowRPM =
                new ObjectCreator("RenderPassManager", "BL_ProjectedShadowRPM").Create();

            // Create the mesh bin and add it to the manager.

            RenderMeshMgr meshbin = new ObjectCreator("RenderMeshMgr").Create();

            BL_ProjectedShadowRPM.addManager(meshbin);
            // Add both to the root group so that it doesn't
            // end up in the MissionCleanup instant group.

            SimSet rootGroup = "RootGroup";
            rootGroup.pushToBack(BL_ProjectedShadowRPM);
            rootGroup.pushToBack(meshbin);
            }

        [ConsoleInteraction(true)]
        public static void onDeactivateBasicLM()
            {
            // Delete the pass manager which also deletes the bin.
            "BL_ProjectedShadowRPM".delete();
            }

        [ConsoleInteraction(true)]
        public static void setBasicLighting()
            {
            omni.Util.setLightManager("Basic Lighting");
            }
        }
    }