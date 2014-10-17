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

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders
{
    [TypeConverter(typeof (TypeConverterGeneric<DOFPostEffect>))]
    public class DOFPostEffect : PostEffect, IConvertible
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        /*

        ================================================================================
         The DOFPostEffect API
        ================================================================================

        DOFPostEffect::setFocalDist( %dist )

        @summary
        This method is for manually controlling the focus distance. It will have no 
        effect if auto focus is currently enabled. Makes use of the parameters set by 
        setFocusParams.

        @param dist 
        float distance in meters

        --------------------------------------------------------------------------------

        DOFPostEffect::setAutoFocus( %enabled )

        @summary
        This method sets auto focus enabled or disabled. Makes use of the parameters set 
        by setFocusParams. When auto focus is enabled it determines the focal depth
        by performing a raycast at the screen-center.

        @param enabled
        bool

        --------------------------------------------------------------------------------

        DOFPostEffect::setFocusParams( %nearBlurMax, %farBlurMax, %minRange, %maxRange, %nearSlope, %farSlope )

        Set the parameters that control how the near and far equations are calculated
        from the focal distance. If you are not using auto focus you will need to call
        setFocusParams PRIOR to calling setFocalDist.

        @param nearBlurMax   
        float between 0.0 and 1.0
        The max allowed value of near blur.

        @param farBlurMax    
        float between 0.0 and 1.0
        The max allowed value of far blur.

        @param minRange/maxRange 
        float in meters
        The distance range around the focal distance that remains in focus is a lerp 
        between the min/maxRange using the normalized focal distance as the parameter. 
        The point is to allow the focal range to expand as you focus farther away since this is 
        visually appealing.

        Note: since min/maxRange are lerped by the "normalized" focal distance it is
        dependant on the visible distance set in your level.

        @param nearSlope
        float less than zero
        The slope of the near equation. A small number causes bluriness to increase gradually
        at distances closer than the focal distance. A large number causes bluriness to 
        increase quickly.

        @param farSlope
        float greater than zero
        The slope of the far equation. A small number causes bluriness to increase gradually
        at distances farther than the focal distance. A large number causes bluriness to
        increase quickly.

        Note: To rephrase, the min/maxRange parameters control how much area around the
        focal distance is completely in focus where the near/farSlope parameters control
        how quickly or slowly bluriness increases at distances outside of that range.

        ================================================================================
         Examples
        ================================================================================

        Example1: Turn on DOF while zoomed in with a weapon.

        NOTE: These are not real callbacks! Hook these up to your code where appropriate!

        function onSniperZoom()
        {
           // Parameterize how you want DOF to look.
           DOFPostEffect.setFocusParams( 0.3, 0.3, 50, 500, -5, 5 );
   
           // Turn on auto focus
           DOFPostEffect.setAutoFocus( true );
   
           // Turn on the PostEffect
           DOFPostEffect.enable();
        }

        function onSniperUnzoom()
        {
           // Turn off the PostEffect
           DOFPostEffect.disable();
        }

        Example2: Manually control DOF with the mouse wheel.

        // Somewhere on startup...

        // Parameterize how you want DOF to look.
        DOFPostEffect.setFocusParams( 0.3, 0.3, 50, 500, -5, 5 );

        // Turn off auto focus
        DOFPostEffect.setAutoFocus( false );

        // Turn on the PostEffect
        DOFPostEffect.enable();


        NOTE: These are not real callbacks! Hook these up to your code where appropriate!

        function onMouseWheelUp()
        {
           // Since setFocalDist is really just a wrapper to assign to the focalDist
           // dynamic field we can shortcut and increment it directly.
           DOFPostEffect.focalDist += 8;
        }

        function onMouseWheelDown()
        {
           DOFPostEffect.focalDist -= 8;
        }
        */

        public static void initialize()
        {
            SingletonCreator ts = new SingletonCreator("GFXStateBlockData", "PFX_DefaultDOFStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampPoint";
            ts["samplerStates[1]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "PFX_DOFCalcCoCStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "PFX_DOFDownSampleStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampPoint";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "PFX_DOFBlurStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts.Create();

            ts = new SingletonCreator("GFXStateBlockData", "PFX_DOFFinalStateBlock");
            ts["zDefined"] = true;
            ts["zEnable"] = false;
            ts["zWriteEnable"] = false;

            ts["samplersDefined"] = true;
            ts["samplerStates[0]"] = "SamplerClampLinear";
            ts["samplerStates[1]"] = "SamplerClampLinear";
            ts["samplerStates[2]"] = "SamplerClampLinear";
            ts["samplerStates[3]"] = "SamplerClampPoint";

            ts["blendDefined"] = true;
            ts["blendEnable"] = true;
            ts["blendDest"] = "GFXBlendInvSrcAlpha";
            ts["blendSrc"] = "GFXBlendOne";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_DOFDownSampleShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/dof/DOF_DownSample_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/dof/DOF_DownSample_P.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_DOFBlurYShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/dof/DOF_Gausian_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/dof/DOF_Gausian_P.hlsl";
            ts["pixVersion"] = 2.0;
            ts["defines"] = "BLUR_DIR=float2(0.0,1.0)";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_DOFBlurXShader : PFX_DOFBlurYShader");
            ts["defines"] = "BLUR_DIR=float2(1.0,0.0)";
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_DOFCalcCoCShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/dof/DOF_CalcCoC_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/dof/DOF_CalcCoC_P.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_DOFSmallBlurShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/dof/DOF_SmallBlur_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/dof/DOF_SmallBlur_P.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("ShaderData", "PFX_DOFFinalShader");
            ts["DXVertexShaderFile"] = "shaders/common/postFx/dof/DOF_Final_V.hlsl";
            ts["DXPixelShaderFile"] = "shaders/common/postFx/dof/DOF_Final_P.hlsl";
            ts["pixVersion"] = 3.0;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "DOFPostEffect", typeof (DOFPostEffect));
            ts["renderTime"] = "PFXAfterBin";
            ts["renderBin"] = "GlowBin";
            ts["renderPriority"] = 0.1;

            ts["shader"] = "PFX_DOFDownSampleShader";
            ts["stateBlock"] = "PFX_DOFDownSampleStateBlock";
            ts["texture[0]"] = "$backBuffer";
            ts["texture[1]"] = "#prepass";
            ts["target"] = "#shrunk";
            ts["targetScale"] = "0.25 0.25";

            ts["isEnabled"] = false;
            ts.Create();

            ts = new SingletonCreator("PostEffect", "DOFBlurY");
            ts["shader"] = "PFX_DOFBlurYShader";
            ts["stateBlock"] = "PFX_DOFBlurStateBlock";
            ts["texture[0]"] = "#shrunk";
            ts["target"] = "$outTex";
            ts.Create();

            ((DOFPostEffect) "DOFPostEffect").add("DOFBlurY");

            ts = new SingletonCreator("PostEffect", "DOFBlurX");
            ts["shader"] = "PFX_DOFBlurXShader";
            ts["stateBlock"] = "PFX_DOFBlurStateBlock";
            ts["texture[0]"] = "$inTex";
            ts["target"] = "#largeBlur";
            ts.Create();

            ((DOFPostEffect) "DOFPostEffect").add("DOFBlurX");

            ts = new SingletonCreator("PostEffect", "DOFCalcCoC");
            ts["shader"] = "PFX_DOFCalcCoCShader";
            ts["stateBlock"] = "PFX_DOFCalcCoCStateBlock";
            ts["texture[0]"] = "#shrunk";
            ts["texture[1]"] = "#largeBlur";
            ts["target"] = "$outTex";
            ts.Create();

            ((DOFPostEffect) "DOFPostEffect").add("DOFCalcCoC");

            ts = new SingletonCreator("PostEffect", "DOFSmallBlur");
            ts["shader"] = "PFX_DOFSmallBlurShader";
            ts["stateBlock"] = "PFX_DefaultDOFStateBlock";
            ts["texture[0]"] = "$inTex";
            ts["target"] = "$outTex";
            ts.Create();

            ((DOFPostEffect) "DOFPostEffect").add("DOFSmallBlur");

            ts = new SingletonCreator("PostEffect", "DOFFinalPFX");
            ts["shader"] = "PFX_DOFFinalShader";
            ts["stateBlock"] = "PFX_DOFFinalStateBlock";
            ts["texture[0]"] = "$backBuffer";
            ts["texture[1]"] = "$inTex";
            ts["texture[2]"] = "#largeBlur";
            ts["texture[3]"] = "#prepass";
            ts["target"] = "$backBuffer";
            ts.Create();

            ((DOFPostEffect) "DOFPostEffect").add("DOFFinalPFX");
        }

        [ConsoleInteraction(true)]
        public virtual void setLerpDist(string d0, string d1, string d2)
        {
            this["lerpScale"] = (-1.0/d0.AsFloat()).AsString() + " " + (-1.0/d1.AsFloat()).AsString() + " " + (-1.0/d2.AsFloat()).AsString() + " " + (1.0/d2.AsFloat()).AsString();

            string lerpbias = "1.0 ";
            lerpbias += ((1 - d2.AsFloat())/d1.AsFloat()).AsString() + " ";
            lerpbias += (1.0/d2.AsFloat()).AsString() + " ";
            lerpbias += ((d2.AsFloat() - 1.0)/d2.AsFloat()).AsString();

            this["lerpBias"] = lerpbias;
        }

        [ConsoleInteraction(true)]
        public virtual void autoFocus()
        {
            GameConnection serverconnection = "ServerConnection";
            ShapeBase camera = serverconnection.getCameraObject();

            const uint mask = (uint) (SceneObjectTypesAsUint.StaticObjectType | SceneObjectTypesAsUint.TerrainObjectType);

            Point3F fvec = camera.getEyeVector();
            Point3F start = camera.getEyePoint();
            Point3F end = Util.VectorAdd(start, Util.VectorScale(fvec, fGlobal["$Param::FarDist"]));

            string result = Util.containerRayCast(start, end, mask, camera, true);

            string hitPos = Util.getWords(result, 1, 3);
            string focDist = sGlobal["$Param::FarDist"];
            if (hitPos != string.Empty)
                focDist = Util.VectorDist(new Point3F(hitPos), start).AsString();

            this["focalDist"] = focDist;
        }

        [ConsoleInteraction(true)]
        public virtual void setAutoFocus(bool enabled)
        {
            this["autoFocusEnabled"] = enabled.AsString();
        }

        [ConsoleInteraction(true)]
        public void setFocusParams(float nearBlurMax, float farBlurMax, float minRange, float maxRange, float nearSlope, float farSlope)
        {
            this["nearBlurMax"] = nearBlurMax.AsString();
            this["farBlurMax"] = farBlurMax.AsString();
            this["minRange"] = minRange.AsString();
            this["maxRange"] = maxRange.AsString();
            this["nearSlope"] = nearSlope.AsString();
            this["farSlope"] = farSlope.AsString();
        }

        [ConsoleInteraction(true)]
        public void setFocalDist(string dist)
        {
            this["focalDist"] = dist;
        }

        public override void setShaderConsts()
        {
            if (this["autoFocusEnabled"].AsBool())
                autoFocus();

            float fd = this["focalDist"].AsFloat()/fGlobal["$Param::FarDist"];
            double range = Util.mLerp(this["minRange"].AsFloat(), this["maxRange"].AsFloat(), fd)/fGlobal["$Param::FarDist"]*.5;
            // We work in "depth" space rather than real-world units for the
            // rest of this method...

            // Given the focal distance and the range around it we want in focus
            // we can determine the near-end-distance and far-start-distance

            double ned = Util.getMax(fd - (float) range, (float) 0.0);
            double fsd = Util.getMin(fd + (float) range, (float) 1.0);
            // near slope
            float nsl = this["nearSlope"].AsFloat();
            // Given slope of near blur equation and the near end dist and amount (x2,y2)
            // solve for the y-intercept
            // y = mx + b
            // so...
            // y - mx = b

            float b = (float) 0.0 - nsl*(float) ned;
            string eqNear = nsl.AsString() + " " + b.AsString() + " 0.0";

            // Do the same for the far blur equation...

            float fsl = this["farSlope"].AsFloat();
            b = (float) 0.0 - fsl*(float) fsd;

            string eqFar = fsl.AsString() + " " + b.AsString() + " " + "1.0";

            PostEffect DOFFinalPFX = "DOFFinalPFX";

            this.setShaderConst("$dofEqWorld", eqNear);
            DOFFinalPFX.setShaderConst("$dofEqFar", eqFar);
            this.setShaderConst("$maxWorldCoC", this["nearBlurMax"]);
            DOFFinalPFX.setShaderConst("$maxFarCoC", this["farBlurMax"]);
            DOFFinalPFX.setShaderConst("$dofLerpScale", this["lerpScale"]);
            DOFFinalPFX.setShaderConst("$dofLerpBias", this["lerpBias"]);
        }

        public override void onAdd()
        {
            // The weighted distribution of CoC value to the three blur textures
            // in the order small, medium, large. Most likely you will not need to
            // change this value.
            setLerpDist("0.2", "0.3", "0.5");

            this["autoFocusEnabled"] = false.AsString();
            this["focalDist"] = "0";
            this["nearBlurMax"] = ".5";
            this["farBlurMax"] = ".5";
            this["minRange"] = "50";
            this["maxRange"] = "500";
            this["nearSlope"] = "-5";
            this["farSlope"] = "5";
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DOFPostEffect ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(DOFPostEffect ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(DOFPostEffect ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DOFPostEffect(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DOFPostEffect) Omni.self.getSimObject(simobjectid, typeof (DOFPostEffect));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DOFPostEffect ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DOFPostEffect(int simobjectid)
        {
            return (DOFPostEffect) Omni.self.getSimObject((uint) simobjectid, typeof (DOFPostEffect));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DOFPostEffect ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DOFPostEffect(uint simobjectid)
        {
            return (DOFPostEffect) Omni.self.getSimObject(simobjectid, typeof (DOFPostEffect));
        }

        #endregion
    }
}