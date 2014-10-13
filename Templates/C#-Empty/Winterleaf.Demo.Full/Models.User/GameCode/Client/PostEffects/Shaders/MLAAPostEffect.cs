// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
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
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "MLAA_EdgeDetectStateBlock : PFX_DefaultStateBlock");
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

            ts = new SingletonCreator("GFXStateBlockData", "MLAA_BlendWeightCalculationStateBlock : PFX_DefaultStateBlock");
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