using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.advanced
    {
    public partial class shadowViz
        {
        public static void initialize()
            {
            initialize_CS();
            Initialize_Gui();
            }

        public static void initialize_CS()
            {
            ObjectCreator tch = new ObjectCreator("ShaderData", "AL_ShadowVisualizeShader");
            tch["DXVertexShaderFile"] = "shaders/common/guiMaterialV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/dbgShadowVisualizeP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/gl/guiMaterialV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/dbgShadowVisualizeP.glsl";

            tch["pixVersion"] = 2.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_ShadowVisualizeMaterial");
            tch["shader"] = "AL_ShadowVisualizeShader";
            tch["stateBlock"] = "AL_DepthVisualizeState";

            tch["sampler[\"shadowMap\"]"] = "#AL_ShadowVizTexture";
            tch["sampler[\"depthViz\"]"] = "core/scripts/client/lighting/advanced/depthviz";

            tch["pixVersion"] = 2.0;
            tch.Create();

            SingletonCreator ts = new SingletonCreator("GuiControlProfile", "AL_ShadowLabelTextProfile");
            ts["fontColor"] = "0 0 0";
            ts["autoSizeWidth"] = true;
            ts["autoSizeHeight"] = true;
            ts["justify"] = "left";
            ts["fontSize"] = 14;
            ts.Create();
            }

        [ConsoleInteraction(true)]
        public static void toggleShadowViz()
            {
            if (((GuiControl) "AL_ShadowVizOverlayCtrl").isAwake())
                {
                omni.Util.setShadowVizLight("0");
                ((GuiCanvas) "Canvas").popDialog("AL_ShadowVizOverlayCtrl");
                }
            else
                {
                ((GuiCanvas) "Canvas").pushDialog("AL_ShadowVizOverlayCtrl", 100);
                _setShadowVizLight(omni.console.Call("EWorldEditor", "getSelectedObject", new[] {"0"}), false);
                }
            }

        [ConsoleInteraction(true)]
        public static void _setShadowVizLight(string light, bool force)
            {
            GuiControl AL_ShadowVizOverlayCtrl = "AL_ShadowVizOverlayCtrl";


            if (!AL_ShadowVizOverlayCtrl.isAwake())
                return;
            if (AL_ShadowVizOverlayCtrl["isLocked"].AsBool() && !force)
                return;

            string sizeAndAspect = "";
            if (light.isObject())
                {
                //todo Got a bug here I think, don't know enough about lighting to debug it at the moment.  the sizeAndAspect is always blank.
                string clientLight = client.serverToClientObject(light.AsInt()).AsString();
                //console.Call("serverToClientObject", new string[] { light });
                sizeAndAspect = omni.Util.setShadowVizLight(clientLight);
                }

            omni.console.Call(AL_ShadowVizOverlayCtrl.findObjectByInternalName("MatCtrl", true), "setMaterial",
                new[] {"AL_ShadowVisualizeMaterial"});
            string text = "ShadowViz";

            if (light.isObject() && sizeAndAspect != "")
                text = text + ":" + sizeAndAspect.Split(' ')[0] + " x " + sizeAndAspect.Split(' ')[1];

            omni.console.SetVar(AL_ShadowVizOverlayCtrl.findObjectByInternalName("WindowCtrl", true), text);
            }

        [ConsoleInteraction(true)]
        public static void showShadowVizForLight(string light)
            {
            GuiControl AL_ShadowVizOverlayCtrl = "AL_ShadowVizOverlayCtrl";

            if (!AL_ShadowVizOverlayCtrl.isAwake())
                ((GuiCanvas) "Canvas").pushDialog(AL_ShadowVizOverlayCtrl, 100);

            _setShadowVizLight(light, true);
            }

        [ConsoleInteraction(true)]
        public static void lockShadowViz()
            {
            ((GuiControl) "AL_ShadowVizOverlayCtrl")["islocked"] = true.AsString();
            }

        [ConsoleInteraction(true)]
        public static void unlockShadowViz()
            {
            ((GuiControl) "AL_ShadowVizOverlayCtrl")["islocked"] = false.AsString();
            }
        }
    }