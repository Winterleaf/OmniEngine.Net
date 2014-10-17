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

using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Lighting.advanced
{
    public class shaders
    {
        public static readonly pInvokes omni = new pInvokes();

        public static void initialize()
        {
            ObjectCreator tch = new ObjectCreator("GFXStateBlockData", "AL_VectorLightState");

            tch["blendDefined"] = true;
            tch["blendEnable"] = true;
            tch["blendSrc"] = "GFXBlendOne";
            tch["blendDest"] = "GFXBlendOne";
            tch["blendOp"] = "GFXBlendOpAdd";

            tch["zDefined"] = true;
            tch["zEnable"] = false;
            tch["zWriteEnable"] = false;

            tch["samplersDefined"] = true;
            tch["samplerStates[0]"] = "SamplerClampPoint"; // G-buffer
            tch["samplerStates[1]"] = "SamplerClampPoint";
            // Shadow Map (Do not change this to linear, as all cards can not filter equally.)
            tch["samplerStates[2]"] = "SamplerClampLinear"; // SSAO Mask
            tch["samplerStates[3]"] = "SamplerWrapPoint"; // Random Direction Map

            tch["cullDefined"] = true;
            tch["cullMode"] = "GFXCullNone";

            tch["stencilDefined"] = true;
            tch["stencilEnable"] = true;
            tch["stencilFailOp"] = "GFXStencilOpKeep";
            tch["stencilZFailOp"] = "GFXStencilOpKeep";
            tch["stencilPassOp"] = "GFXStencilOpKeep";
            tch["stencilFunc"] = "GFXCmpLess";
            tch["stencilRef"] = 0;
            tch.Create();

            // Vector Light Material
            tch = new ObjectCreator("ShaderData", "AL_VectorLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/farFrustumQuadV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/vectorLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/farFrustumQuadV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/vectorLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_VectorLightMaterial");
            tch["shader"] = "AL_VectorLightShader";
            tch["stateBlock"] = "AL_VectorLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["sampler[\"ShadowMap\"]"] = "$dynamiclight";
            tch["sampler[\"ssaoMask\"]"] = "#ssaoMask";

            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;
            tch.Create();

            // Convex-geometry light states
            tch = new ObjectCreator("GFXStateBlockData", "AL_ConvexLightState");
            tch["blendDefined"] = true;
            tch["blendEnable"] = true;
            tch["blendSrc"] = "GFXBlendOne";
            tch["blendDest"] = "GFXBlendOne";
            tch["blendOp"] = "GFXBlendOpAdd";

            tch["zDefined"] = true;
            tch["zEnable"] = true;
            tch["zWriteEnable"] = false;
            tch["zFunc"] = "GFXCmpGreaterEqual";

            tch["samplersDefined"] = true;
            tch["samplerStates[0]"] = "SamplerClampPoint"; // G-buffer
            tch["samplerStates[1]"] = "SamplerClampPoint";
            // Shadow Map (Do not use linear, these are perspective projections)
            tch["samplerStates[2]"] = "SamplerClampLinear"; // Cookie Map   
            tch["samplerStates[3]"] = "SamplerWrapPoint"; // Random Direction Map

            tch["cullDefined"] = true;
            tch["cullMode"] = "GFXCullCW";

            tch["stencilDefined"] = true;
            tch["stencilEnable"] = true;
            tch["stencilFailOp"] = "GFXStencilOpKeep";
            tch["stencilZFailOp"] = "GFXStencilOpKeep";
            tch["stencilPassOp"] = "GFXStencilOpKeep";
            tch["stencilFunc"] = "GFXCmpLess";
            tch["stencilRef"] = 0;
            tch.Create();

            // Point Light Material
            tch = new ObjectCreator("ShaderData", "AL_PointLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/convexGeometryV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/pointLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/convexGeometryV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/pointLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_PointLightMaterial");
            tch["shader"] = "AL_PointLightShader";
            tch["stateBlock"] = "AL_ConvexLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["sampler[\"shadowMap\"]"] = "$dynamiclight";
            tch["sampler[\"cookieTex\"]"] = "$dynamiclightmask";

            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;
            tch.Create();

            // Spot Light Material
            tch = new ObjectCreator("ShaderData", "AL_SpotLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/convexGeometryV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/spotLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/convexGeometryV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/spotLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_SpotLightMaterial");
            tch["shader"] = "AL_SpotLightShader";
            tch["stateBlock"] = "AL_ConvexLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["sampler[\"shadowMap\"]"] = "$dynamiclight";
            tch["sampler[\"cookieTex\"]"] = "$dynamiclightmask";

            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;

            tch.Create();

            // This material is used for generating prepass 
            // materials for objects that do not have materials.
            tch = new ObjectCreator("Material", "AL_DefaultPrePassMaterial");
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //
            tch["diffuseColor[0]"] = "1 1 1 1";
            tch.Create();

            // This material is used for generating shadow 
            // materials for objects that do not have materials.
            tch = new ObjectCreator("Material", "AL_DefaultShadowMaterial");
            // We need something in the first pass else it 
            // won't create a proper material instance.  
            //
            // We use color here because some objects may not
            // have texture coords in their vertex format... 
            // for example like terrain.
            //
            tch["diffuseColor[0]"] = "1 1 1 1";

            // This is here mostly for terrain which uses
            // this material to create its shadow material.
            //
            // At sunset/sunrise the sun is looking thru 
            // backsides of the terrain which often are not
            // closed.  By changing the material to be double
            // sided we avoid holes in the shadowed geometry.
            //
            tch["doubleSided"] = true;
            tch.Create();

            // Particle System Point Light Material
            tch = new ObjectCreator("ShaderData", "AL_ParticlePointLightShader");
            tch["DXVertexShaderFile"] = "shaders/common/lighting/advanced/particlePointLightV.hlsl";
            tch["DXPixelShaderFile"] = "shaders/common/lighting/advanced/particlePointLightP.hlsl";

            tch["OGLVertexShaderFile"] = "shaders/common/lighting/advanced/gl/convexGeometryV.glsl";
            tch["OGLPixelShaderFile"] = "shaders/common/lighting/advanced/gl/pointLightP.glsl";

            tch["pixVersion"] = 3.0;
            tch.Create();

            tch = new ObjectCreator("CustomMaterial", "AL_ParticlePointLightMaterial");
            tch["shader"] = "AL_ParticlePointLightShader";
            tch["stateBlock"] = "AL_ConvexLightState";

            tch["sampler[\"prePassBuffer\"]"] = "#prepass";
            tch["target"] = "lightinfo";

            tch["pixVersion"] = 3.0;
            tch.Create();
        }
    }
}