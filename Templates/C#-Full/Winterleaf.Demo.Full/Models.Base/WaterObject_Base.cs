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
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<WaterObject_Base>))]
    public partial class WaterObject_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WaterObject_Base ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(WaterObject_Base ts, string simobjectid)
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
        public static implicit operator string(WaterObject_Base ts)
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
        public static implicit operator WaterObject_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (WaterObject_Base) Omni.self.getSimObject(simobjectid, typeof (WaterObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(WaterObject_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WaterObject_Base(int simobjectid)
        {
            return (WaterObject) Omni.self.getSimObject((uint) simobjectid, typeof (WaterObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(WaterObject_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WaterObject_Base(uint simobjectid)
        {
            return (WaterObject_Base) Omni.self.getSimObject(simobjectid, typeof (WaterObject_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("WaterObject")] public arrayObject<Point2F> foamDir;
        [MemberGroup("WaterObject")] public arrayObject<float> foamOpacity;
        [MemberGroup("WaterObject")] public arrayObject<float> foamSpeed;
        [MemberGroup("WaterObject")] public arrayObject<Point2F> foamTexScale;
        [MemberGroup("WaterObject")] public arrayObject<Point2F> rippleDir;
        [MemberGroup("WaterObject")] public arrayObject<float> rippleMagnitude;
        [MemberGroup("WaterObject")] public arrayObject<float> rippleSpeed;
        [MemberGroup("WaterObject")] public arrayObject<Point2F> rippleTexScale;
        [MemberGroup("WaterObject")] public arrayObject<Point2F> waveDir;
        [MemberGroup("WaterObject")] public arrayObject<float> waveMagnitude;
        [MemberGroup("WaterObject")] public arrayObject<float> waveSpeed;

        /// <summary>
        /// Changes color of water fog. 
        /// </summary>
        [MemberGroup("WaterObject")]
        public ColorI baseColor
        {
            get { return Omni.self.GetVar(_ID + ".baseColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".baseColor", value.AsString()); }
        }

        /// <summary>
        /// Relative opacity or transparency of the water surface. 
        /// </summary>
        [MemberGroup("Basic Lighting")]
        public float clarity
        {
            get { return Omni.self.GetVar(_ID + ".clarity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".clarity", value.AsString()); }
        }

        /// <summary>
        /// Cubemap used instead of reflection texture if fullReflect is off. 
        /// </summary>
        [MemberGroup("Reflect")]
        public TypeCubemapName cubemap
        {
            get { return Omni.self.GetVar(_ID + ".cubemap").AsTypeCubemapName(); }
            set { Omni.self.SetVar(_ID + ".cubemap", value.AsString()); }
        }

        /// <summary>
        /// Affects buoyancy of an object, thus affecting the Z velocity of a player (jumping, falling, etc.
        /// </summary>
        [MemberGroup("WaterObject")]
        public float density
        {
            get { return Omni.self.GetVar(_ID + ".density").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".density", value.AsString()); }
        }

        /// <summary>
        /// Depth in world units, the max range of the color gradient texture. 
        /// </summary>
        [MemberGroup("Misc")]
        public float depthGradientMax
        {
            get { return Omni.self.GetVar(_ID + ".depthGradientMax").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".depthGradientMax", value.AsString()); }
        }

        /// <summary>
        /// 1D texture defining the base water color by depth 
        /// </summary>
        [MemberGroup("Misc")]
        public TypeImageFilename depthGradientTex
        {
            get { return Omni.self.GetVar(_ID + ".depthGradientTex").AsTypeImageFilename(); }
            set { Omni.self.SetVar(_ID + ".depthGradientTex", value.AsString()); }
        }

        /// <summary>
        /// Max distance that distortion algorithm is performed. 		 The lower, the more distorted the effect.
        /// </summary>
        [MemberGroup("Distortion")]
        public float distortEndDist
        {
            get { return Omni.self.GetVar(_ID + ".distortEndDist").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".distortEndDist", value.AsString()); }
        }

        /// <summary>
        /// Determines the scaling down of distortion 		 in shallow water.
        /// </summary>
        [MemberGroup("Distortion")]
        public float distortFullDepth
        {
            get { return Omni.self.GetVar(_ID + ".distortFullDepth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".distortFullDepth", value.AsString()); }
        }

        /// <summary>
        /// Determines start of distortion effect where water		  surface intersects the camera near plane.
        /// </summary>
        [MemberGroup("Distortion")]
        public float distortStartDist
        {
            get { return Omni.self.GetVar(_ID + ".distortStartDist").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".distortStartDist", value.AsString()); }
        }

        /// <summary>
        /// When true the water colors don't react to changes to environment lighting. 
        /// </summary>
        [MemberGroup("WaterObject")]
        public bool emissive
        {
            get { return Omni.self.GetVar(_ID + ".emissive").AsBool(); }
            set { Omni.self.SetVar(_ID + ".emissive", value.AsString()); }
        }

        /// <summary>
        ///  
        /// </summary>
        [MemberGroup("WaterObject")]
        public float foamAmbientLerp
        {
            get { return Omni.self.GetVar(_ID + ".foamAmbientLerp").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".foamAmbientLerp", value.AsString()); }
        }

        /// <summary>
        ///  
        /// </summary>
        [MemberGroup("WaterObject")]
        public float foamMaxDepth
        {
            get { return Omni.self.GetVar(_ID + ".foamMaxDepth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".foamMaxDepth", value.AsString()); }
        }

        /// <summary>
        ///  
        /// </summary>
        [MemberGroup("WaterObject")]
        public float foamRippleInfluence
        {
            get { return Omni.self.GetVar(_ID + ".foamRippleInfluence").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".foamRippleInfluence", value.AsString()); }
        }

        /// <summary>
        /// Diffuse texture for foam in shallow water (advanced lighting only) 
        /// </summary>
        [MemberGroup("WaterObject")]
        public TypeImageFilename foamTex
        {
            get { return Omni.self.GetVar(_ID + ".foamTex").AsTypeImageFilename(); }
            set { Omni.self.SetVar(_ID + ".foamTex", value.AsString()); }
        }

        /// <summary>
        /// Extent of fresnel affecting reflection fogging. 
        /// </summary>
        [MemberGroup("WaterObject")]
        public float fresnelBias
        {
            get { return Omni.self.GetVar(_ID + ".fresnelBias").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fresnelBias", value.AsString()); }
        }

        /// <summary>
        /// Measures intensity of affect on reflection based on fogging. 
        /// </summary>
        [MemberGroup("WaterObject")]
        public float fresnelPower
        {
            get { return Omni.self.GetVar(_ID + ".fresnelPower").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fresnelPower", value.AsString()); }
        }

        /// <summary>
        /// Enables dynamic reflection rendering. 
        /// </summary>
        [MemberGroup("Reflect")]
        public bool fullReflect
        {
            get { return Omni.self.GetVar(_ID + ".fullReflect").AsBool(); }
            set { Omni.self.SetVar(_ID + ".fullReflect", value.AsString()); }
        }

        /// <summary>
        /// Liquid type of WaterBlock, such as water, ocean, lava		  Currently only Water is defined and used.
        /// </summary>
        [MemberGroup("WaterObject")]
        public String liquidType
        {
            get { return Omni.self.GetVar(_ID + ".liquidType").AsString(); }
            set { Omni.self.SetVar(_ID + ".liquidType", value.AsString()); }
        }

        /// <summary>
        ///  
        /// </summary>
        [MemberGroup("WaterObject")]
        public float overallFoamOpacity
        {
            get { return Omni.self.GetVar(_ID + ".overallFoamOpacity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".overallFoamOpacity", value.AsString()); }
        }

        /// <summary>
        /// Master variable affecting entire surface
        /// </summary>
        [MemberGroup("WaterObject")]
        public float overallRippleMagnitude
        {
            get { return Omni.self.GetVar(_ID + ".overallRippleMagnitude").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".overallRippleMagnitude", value.AsString()); }
        }

        /// <summary>
        /// Master variable affecting entire body 		  of water's undulation 
        /// </summary>
        [MemberGroup("WaterObject")]
        public float overallWaveMagnitude
        {
            get { return Omni.self.GetVar(_ID + ".overallWaveMagnitude").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".overallWaveMagnitude", value.AsString()); }
        }

        /// <summary>
        /// scale up or down the detail level for objects rendered in a reflection 
        /// </summary>
        [MemberGroup("Reflect")]
        public float reflectDetailAdjust
        {
            get { return Omni.self.GetVar(_ID + ".reflectDetailAdjust").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reflectDetailAdjust", value.AsString()); }
        }

        /// <summary>
        /// Overall scalar to the reflectivity of the water surface. 
        /// </summary>
        [MemberGroup("Reflect")]
        public float reflectivity
        {
            get { return Omni.self.GetVar(_ID + ".reflectivity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reflectivity", value.AsString()); }
        }

        /// <summary>
        /// Affects the sort time of reflected objects. 
        /// </summary>
        [MemberGroup("Reflect")]
        public int reflectMaxRateMs
        {
            get { return Omni.self.GetVar(_ID + ".reflectMaxRateMs").AsInt(); }
            set { Omni.self.SetVar(_ID + ".reflectMaxRateMs", value.AsString()); }
        }

        /// <summary>
        /// always use z up as the reflection normal 
        /// </summary>
        [MemberGroup("Reflect")]
        public bool reflectNormalUp
        {
            get { return Omni.self.GetVar(_ID + ".reflectNormalUp").AsBool(); }
            set { Omni.self.SetVar(_ID + ".reflectNormalUp", value.AsString()); }
        }

        /// <summary>
        /// Affects the sort order of reflected objects. 
        /// </summary>
        [MemberGroup("Reflect")]
        public float reflectPriority
        {
            get { return Omni.self.GetVar(_ID + ".reflectPriority").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reflectPriority", value.AsString()); }
        }

        /// <summary>
        /// The texture size used for reflections (square) 
        /// </summary>
        [MemberGroup("Reflect")]
        public int reflectTexSize
        {
            get { return Omni.self.GetVar(_ID + ".reflectTexSize").AsInt(); }
            set { Omni.self.SetVar(_ID + ".reflectTexSize", value.AsString()); }
        }

        /// <summary>
        /// Normal map used to simulate small surface ripples 
        /// </summary>
        [MemberGroup("WaterObject")]
        public TypeImageFilename rippleTex
        {
            get { return Omni.self.GetVar(_ID + ".rippleTex").AsTypeImageFilename(); }
            set { Omni.self.SetVar(_ID + ".rippleTex", value.AsString()); }
        }

        /// <summary>
        /// Ambient sound environment when listener is submerged. 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXAmbienceName soundAmbience
        {
            get { return Omni.self.GetVar(_ID + ".soundAmbience").AsTypeSFXAmbienceName(); }
            set { Omni.self.SetVar(_ID + ".soundAmbience", value.AsString()); }
        }

        /// <summary>
        /// Color used for specularity on the water surface ( sun only ). 
        /// </summary>
        [MemberGroup("WaterObject")]
        public ColorF specularColor
        {
            get { return Omni.self.GetVar(_ID + ".specularColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".specularColor", value.AsString()); }
        }

        /// <summary>
        /// Power used for specularity on the water surface ( sun only ). 
        /// </summary>
        [MemberGroup("WaterObject")]
        public float specularPower
        {
            get { return Omni.self.GetVar(_ID + ".specularPower").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".specularPower", value.AsString()); }
        }

        /// <summary>
        /// Changes the color shading of objects beneath		  the water surface.
        /// </summary>
        [MemberGroup("Basic Lighting")]
        public ColorI underwaterColor
        {
            get { return Omni.self.GetVar(_ID + ".underwaterColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".underwaterColor", value.AsString()); }
        }

        /// <summary>
        /// turn off reflection rendering when occluded (delayed). 
        /// </summary>
        [MemberGroup("Reflect")]
        public bool useOcclusionQuery
        {
            get { return Omni.self.GetVar(_ID + ".useOcclusionQuery").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useOcclusionQuery", value.AsString()); }
        }

        /// <summary>
        /// Affects drag force applied to an object submerged in this container. 
        /// </summary>
        [MemberGroup("WaterObject")]
        public float viscosity
        {
            get { return Omni.self.GetVar(_ID + ".viscosity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".viscosity", value.AsString()); }
        }

        /// <summary>
        /// Intensity of underwater fogging. 
        /// </summary>
        [MemberGroup("Underwater Fogging")]
        public float waterFogDensity
        {
            get { return Omni.self.GetVar(_ID + ".waterFogDensity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".waterFogDensity", value.AsString()); }
        }

        /// <summary>
        /// Delta, or limit, applied to waterFogDensity. 
        /// </summary>
        [MemberGroup("Underwater Fogging")]
        public float waterFogDensityOffset
        {
            get { return Omni.self.GetVar(_ID + ".waterFogDensityOffset").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".waterFogDensityOffset", value.AsString()); }
        }

        /// <summary>
        /// The refract color intensity scaled at wetDepth. 
        /// </summary>
        [MemberGroup("Underwater Fogging")]
        public float wetDarkening
        {
            get { return Omni.self.GetVar(_ID + ".wetDarkening").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".wetDarkening", value.AsString()); }
        }

        /// <summary>
        /// The depth in world units at which full darkening will be received,		  giving a wet look to objects underwater. 
        /// </summary>
        [MemberGroup("Underwater Fogging")]
        public float wetDepth
        {
            get { return Omni.self.GetVar(_ID + ".wetDepth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".wetDepth", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public WaterObject_Base()
        {
            foamDir = new arrayObject<Point2F>(2, "foamDir", "TypeVariable", false, this);
            foamOpacity = new arrayObject<float>(2, "foamOpacity", "TypeVariable", false, this);
            foamSpeed = new arrayObject<float>(2, "foamSpeed", "TypeVariable", false, this);
            foamTexScale = new arrayObject<Point2F>(2, "foamTexScale", "TypeVariable", false, this);
            rippleDir = new arrayObject<Point2F>(3, "rippleDir", "TypeVariable", false, this);
            rippleMagnitude = new arrayObject<float>(3, "rippleMagnitude", "TypeVariable", false, this);
            rippleSpeed = new arrayObject<float>(3, "rippleSpeed", "TypeVariable", false, this);
            rippleTexScale = new arrayObject<Point2F>(3, "rippleTexScale", "TypeVariable", false, this);
            waveDir = new arrayObject<Point2F>(3, "waveDir", "TypeVariable", false, this);
            waveMagnitude = new arrayObject<float>(3, "waveMagnitude", "TypeVariable", false, this);
            waveSpeed = new arrayObject<float>(3, "waveSpeed", "TypeVariable", false, this);
        }
    }
}