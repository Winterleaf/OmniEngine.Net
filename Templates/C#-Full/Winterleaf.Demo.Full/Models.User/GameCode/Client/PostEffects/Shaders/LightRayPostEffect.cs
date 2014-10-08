#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<LightRayPostEffect>))]
    public class LightRayPostEffect : PostEffect
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void preProcess()
            {
            this["targetScale"] = sGlobal["$LightRayPostFX::resolutionScale"] + " " +
                                  sGlobal["$LightRayPostFX::resolutionScale"];
            }

        public override void setShaderConsts()
            {
            setShaderConst("$brightScalar", sGlobal["$LightRayPostFX::brightScalar"]);
            PostEffect pfx = findObjectByInternalName("final", true);

            pfx.setShaderConst("$numSamples", sGlobal["$LightRayPostFX::numSamples"]);
            pfx.setShaderConst("$density", sGlobal["$LightRayPostFX::density"]);
            pfx.setShaderConst("$weight", sGlobal["$LightRayPostFX::weight"]);
            pfx.setShaderConst("$decay", sGlobal["$LightRayPostFX::decay"]);
            pfx.setShaderConst("$exposure", sGlobal["$LightRayPostFX::exposure"]);
            }

        public static void initialize()
            {
            omni.dGlobal["$LightRayPostFX::brightScalar"] = 0.75;
            omni.dGlobal["$LightRayPostFX::numSamples"] = 40;
            omni.dGlobal["$LightRayPostFX::density"] = 0.94;
            omni.dGlobal["$LightRayPostFX::weight"] = 5.65;
            omni.dGlobal["$LightRayPostFX::decay"] = 1.0;
            omni.dGlobal["$LightRayPostFX::exposure"] = 0.0005;
            omni.dGlobal["$LightRayPostFX::resolutionScale"] = 1.0;

            SingletonCreator ts = new SingletonCreator("ShaderData", "LightRayOccludeShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/lightRay/lightRayOccludeP.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "LightRayShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/postFxV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/lightRay/lightRayP.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "LightRayStateBlock : PFX_DefaultStateBlock");
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts.Create();


            SingletonCreator LightRayPostFX = new SingletonCreator("PostEffect", "LightRayPostFX",
                typeof (LightRayPostEffect));
            LightRayPostFX["isEnabled"] = true;
            LightRayPostFX["allowReflectPass"] = false;

            LightRayPostFX["renderTime"] = "PFXBeforeBin";
            LightRayPostFX["renderBin"] = "EditorBin";
            LightRayPostFX["renderPriority"] = 10;

            LightRayPostFX["shader"] = "LightRayOccludeShader";
            LightRayPostFX["stateBlock"] = "LightRayStateBlock";
            LightRayPostFX["texture[0]"] = "$backBuffer";
            LightRayPostFX["texture[1]"] = "#prepass";
            LightRayPostFX["target"] = "$outTex";
            LightRayPostFX["targetFormat"] = "GFXFormatR16G16B16A16F";

            ObjectCreator final = new ObjectCreator("PostEffect", "LightRayPostFX_final");
            final["shader"] = "LightRayShader";
            final["stateBlock"] = "LightRayStateBlock";
            final["internalName"] = "final";
            final["texture[0]"] = "$inTex";
            final["texture[1]"] = "$backBuffer";
            final["target"] = "$backBuffer";
            LightRayPostFX["#1"] = final;

            LightRayPostFX.Create();
            }

       
        }
    }