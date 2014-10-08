#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
    {
    [TypeConverter(typeof (TypeConverterGeneric<MLAAPostEffect>))]
    public class MLAAPostEffect : PostEffect
        {
        // An implementation of "Practical Morphological Anti-Aliasing" from 
        // GPU Pro 2 by Jorge Jimenez, Belen Masia, Jose I. Echevarria, 
        // Fernando Navarro, and Diego Gutierrez.
        //
        // http://www.iryoku.com/mlaa/

        // NOTE: This is currently disabled in favor of FXAA.  See 
        // core\scripts\client\canvas.cs if you want to re-enable it.

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void setShaderConsts()
            {
            setShaderConst("$lumaCoefficients", this["lumaCoefficients"]);
            setShaderConst("$threshold", this["threshold"]);
            setShaderConst("$depthThreshold", this["depthThreshold"]);
            }

        public static void initialize()
            {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData",
                "MLAA_EdgeDetectStateBlock : PFX_DefaultStateBlock");
            // Mark the edge pixels in stencil.
            ts["stencilDefined"] = true;
            ts["stencilEnable"] = true;
            ts["stencilPassOp"] = "GFXStencilOpReplace";
            ts["stencilFunc"] = "GFXCmpAlways";
            ts["stencilRef"] = 1;
            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "MLAA_EdgeDetectionShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/mlaa/offsetV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/mlaa/edgeDetectionP.hlsl";
            ts["samplerNames[0]"] = "$colorMapG";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData",
                "MLAA_BlendWeightCalculationStateBlock : PFX_DefaultStateBlock");
            // Here we want to process only marked pixels.
            ts["stencilDefined"] = true;
            ts["stencilEnable"] = true;
            ts["stencilPassOp"] = "GFXStencilOpKeep";
            ts["stencilFunc"] = "GFXCmpEqual";
            ts["stencilRef"] = 1;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts["samplerStates[2]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "MLAA_BlendWeightCalculationShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/mlaa/passthruV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/mlaa/blendWeightCalculationP.hlsl";

            ts["samplerNames[0]"] = "$edgesMap";
            ts["samplerNames[1]"] = "$edgesMapL";
            ts["samplerNames[2]"] = "$areaMap";

            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "MLAA_NeighborhoodBlendingStateBlock : PFX_DefaultStateBlock");
            // Here we want to process only marked pixels too.
            ts["stencilDefined"] = true;
            ts["stencilEnable"] = true;
            ts["stencilPassOp"] = "GFXStencilOpKeep";
            ts["stencilFunc"] = "GFXCmpEqual";
            ts["stencilRef"] = 1;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts["samplerStates[2]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "MLAA_NeighborhoodBlendingShader");

            ts["DXVertexShaderFile"] = "shaders/common/postFx/mlaa/offsetV.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/mlaa/neighborhoodBlendingP.hlsl";

            ts["samplerNames[0]"] = "$blendMap";
            ts["samplerNames[1]"] = "$colorMapL";
            ts["samplerNames[2]"] = "$colorMap";

            ts["pixVersion"] = 3.0;
            ts.Create();

            SingletonCreator MLAAFx = new SingletonCreator("PostEffect", "MLAAFx", typeof (MLAAPostEffect));
            MLAAFx["isEnabled"] = false;

            MLAAFx["allowReflectPass"] = false;
            MLAAFx["renderTime"] = "PFXAfterDiffuse";

            MLAAFx["texture[0]"] = "$backBuffer"; //colorMapG      
            MLAAFx["texture[1]"] = "#prepass"; // Used for depth detection

            MLAAFx["target"] = "$outTex";
            MLAAFx["targetClear"] = "PFXTargetClear_OnDraw";
            MLAAFx["targetClearColor"] = "0 0 0 0";

            MLAAFx["stateBlock"] = "MLAA_EdgeDetectStateBlock";
            MLAAFx["shader"] = "MLAA_EdgeDetectionShader";

            // The luma calculation weights which can be user adjustable
            // per-scene if nessasary.  The default value of...
            //
            //    0.2126 0.7152 0.0722 
            //
            // ... is the HDTV ITU-R Recommendation BT. 709.
            MLAAFx["lumaCoefficients"] = "0.2126 0.7152 0.0722";

            // The tweakable color threshold used to select
            // the range of edge pixels to blend.
            MLAAFx["threshold"] = 0.1;

            // The depth delta threshold used to select
            // the range of edge pixels to blend.
            MLAAFx["depthThreshold"] = 0.01;

            ObjectCreator blendingWeightsCalculation = new ObjectCreator("PostEffect", "MLAAFx_blendingWeightsCalculation");
            blendingWeightsCalculation["internalName"] = "blendingWeightsCalculation";

            blendingWeightsCalculation["target"] = "$outTex";
            blendingWeightsCalculation["targetClear"] = "PFXTargetClear_OnDraw";

            blendingWeightsCalculation["shader"] = "MLAA_BlendWeightCalculationShader";
            blendingWeightsCalculation["stateBlock"] = "MLAA_BlendWeightCalculationStateBlock";

            blendingWeightsCalculation["texture[0]"] = "$inTex"; // Edges mask    
            blendingWeightsCalculation["texture[1]"] = "$inTex"; // Edges mask 
            blendingWeightsCalculation["texture[2]"] = "core/scripts/client/postFX/AreaMap33.dds";

            MLAAFx["#1"] = blendingWeightsCalculation;

            ObjectCreator neighborhoodBlending = new ObjectCreator("PostEffect", "MLAAFx_neighborhoodBlending");
            neighborhoodBlending["internalName"] = "neighborhoodBlending";

            neighborhoodBlending["shader"] = "MLAA_NeighborhoodBlendingShader";
            neighborhoodBlending["stateBlock"] = "MLAA_NeighborhoodBlendingStateBlock";

            neighborhoodBlending["texture[0]"] = "$inTex"; // Blend weights
            neighborhoodBlending["texture[1]"] = "$backBuffer";
            neighborhoodBlending["texture[2]"] = "$backBuffer";
            MLAAFx["#2"] = neighborhoodBlending;

            MLAAFx.Create();
            }
        }
    }