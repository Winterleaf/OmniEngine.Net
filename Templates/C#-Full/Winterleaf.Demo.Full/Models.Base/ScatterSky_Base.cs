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
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ScatterSky_Base>))]
    public partial class ScatterSky_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ScatterSky_Base ts, string simobjectid)
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
        public static bool operator !=(ScatterSky_Base ts, string simobjectid)
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
        public static implicit operator string(ScatterSky_Base ts)
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
        public static implicit operator ScatterSky_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ScatterSky_Base) Omni.self.getSimObject(simobjectid, typeof (ScatterSky_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ScatterSky_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ScatterSky_Base(int simobjectid)
        {
            return (ScatterSky) Omni.self.getSimObject((uint) simobjectid, typeof (ScatterSky_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ScatterSky_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ScatterSky_Base(uint simobjectid)
        {
            return (ScatterSky_Base) Omni.self.getSimObject(simobjectid, typeof (ScatterSky_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Modulates the ambient color of sunlight. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public ColorF ambientScale
        {
            get { return Omni.self.GetVar(_ID + ".ambientScale").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".ambientScale", value.AsString()); }
        }

        /// <summary>
        /// The horizontal angle of the sun measured clockwise from the positive Y world axis. This field is networked. 
        /// </summary>
        [MemberGroup("Orbit")]
        public float azimuth
        {
            get { return Omni.self.GetVar(_ID + ".azimuth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".azimuth", value.AsString()); }
        }

        /// <summary>
        /// The brightness of the ScatterSky's light object. 
        /// </summary>
        [MemberGroup("Lighting")]
        public float brightness
        {
            get { return Omni.self.GetVar(_ID + ".brightness").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".brightness", value.AsString()); }
        }

        /// <summary>
        /// Enables/disables shadows cast by objects due to ScatterSky light. 
        /// </summary>
        [MemberGroup("Lighting")]
        public bool castShadows
        {
            get { return Omni.self.GetVar(_ID + ".castShadows").AsBool(); }
            set { Omni.self.SetVar(_ID + ".castShadows", value.AsString()); }
        }

        /// <summary>
        /// Tints the sky the color specified, the alpha controls the brigthness. The brightness is multipled by the value of colorizeAmt. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public ColorF colorize
        {
            get { return Omni.self.GetVar(_ID + ".colorize").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".colorize", value.AsString()); }
        }

        /// <summary>
        /// Controls how much the the alpha component of colorize brigthens the sky. Setting to 0 returns default behavior. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public float colorizeAmount
        {
            get { return Omni.self.GetVar(_ID + ".colorizeAmount").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".colorizeAmount", value.AsString()); }
        }

        /// <summary>
        /// The elevation angle of the sun above or below the horizon. This field is networked. 
        /// </summary>
        [MemberGroup("Orbit")]
        public float elevation
        {
            get { return Omni.self.GetVar(_ID + ".elevation").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".elevation", value.AsString()); }
        }

        /// <summary>
        /// Controls the contrast of the sky and sun during daytime. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public float exposure
        {
            get { return Omni.self.GetVar(_ID + ".exposure").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".exposure", value.AsString()); }
        }

        /// <summary>
        /// Changes the size and intensity of the flare. 
        /// </summary>
        [MemberGroup("Misc")]
        public float flareScale
        {
            get { return Omni.self.GetVar(_ID + ".flareScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".flareScale", value.AsString()); }
        }

        /// <summary>
        /// Datablock for the flare produced by the ScatterSky. 
        /// </summary>
        [MemberGroup("Misc")]
        public LightFlareData flareType
        {
            get { return Omni.self.GetVar(_ID + ".flareType"); }
            set { Omni.self.SetVar(_ID + ".flareType", value.ToString()); }
        }

        /// <summary>
        /// Modulates the fog color. Note that this overrides the LevelInfo.fogColor      property, so you should not use LevelInfo.fogColor if the level contains      a ScatterSky object. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public ColorF fogScale
        {
            get { return Omni.self.GetVar(_ID + ".fogScale").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".fogScale", value.AsString()); }
        }

        /// <summary>
        /// The horizontal angle of the moon measured clockwise from the positive Y world axis. This is not animated by time or networked. 
        /// </summary>
        [MemberGroup("Orbit")]
        public float moonAzimuth
        {
            get { return Omni.self.GetVar(_ID + ".moonAzimuth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".moonAzimuth", value.AsString()); }
        }

        /// <summary>
        /// The elevation angle of the moon above or below the horizon. This is not animated by time or networked. 
        /// </summary>
        [MemberGroup("Orbit")]
        public float moonElevation
        {
            get { return Omni.self.GetVar(_ID + ".moonElevation").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".moonElevation", value.AsString()); }
        }

        /// <summary>
        /// Enable or disable rendering of the moon sprite during night. 
        /// </summary>
        [MemberGroup("Night")]
        public bool moonEnabled
        {
            get { return Omni.self.GetVar(_ID + ".moonEnabled").AsBool(); }
            set { Omni.self.SetVar(_ID + ".moonEnabled", value.AsString()); }
        }

        /// <summary>
        /// Color of light cast by the directional light during night. 
        /// </summary>
        [MemberGroup("Night")]
        public ColorF moonLightColor
        {
            get { return Omni.self.GetVar(_ID + ".moonLightColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".moonLightColor", value.AsString()); }
        }

        /// <summary>
        /// Material for the moon sprite. 
        /// </summary>
        [MemberGroup("Night")]
        public TypeMaterialName moonMat
        {
            get { return Omni.self.GetVar(_ID + ".moonMat").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".moonMat", value.AsString()); }
        }

        /// <summary>
        /// Controls size the moon sprite renders, specified as a fractional amount of the screen height. 
        /// </summary>
        [MemberGroup("Night")]
        public float moonScale
        {
            get { return Omni.self.GetVar(_ID + ".moonScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".moonScale", value.AsString()); }
        }

        /// <summary>
        /// The ambient color during night. Also used for the sky color if useNightCubemap is false. 
        /// </summary>
        [MemberGroup("Night")]
        public ColorF nightColor
        {
            get { return Omni.self.GetVar(_ID + ".nightColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".nightColor", value.AsString()); }
        }

        /// <summary>
        /// Cubemap visible during night. 
        /// </summary>
        [MemberGroup("Night")]
        public TypeCubemapName nightCubemap
        {
            get { return Omni.self.GetVar(_ID + ".nightCubemap").AsTypeCubemapName(); }
            set { Omni.self.SetVar(_ID + ".nightCubemap", value.AsString()); }
        }

        /// <summary>
        /// The fog color during night. 
        /// </summary>
        [MemberGroup("Night")]
        public ColorF nightFogColor
        {
            get { return Omni.self.GetVar(_ID + ".nightFogColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".nightFogColor", value.AsString()); }
        }

        /// <summary>
        /// Controls how blue the atmosphere is during the day. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public float rayleighScattering
        {
            get { return Omni.self.GetVar(_ID + ".rayleighScattering").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".rayleighScattering", value.AsString()); }
        }

        /// <summary>
        /// Global brightness and intensity applied to the sky and objects in the level. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public float skyBrightness
        {
            get { return Omni.self.GetVar(_ID + ".skyBrightness").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".skyBrightness", value.AsString()); }
        }

        /// <summary>
        /// Modulates the directional color of sunlight. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public ColorF sunScale
        {
            get { return Omni.self.GetVar(_ID + ".sunScale").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".sunScale", value.AsString()); }
        }

        /// <summary>
        /// Affects the size of the sun's disk. 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public float sunSize
        {
            get { return Omni.self.GetVar(_ID + ".sunSize").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".sunSize", value.AsString()); }
        }

        /// <summary>
        /// Transition to the nightCubemap during night. If false we use nightColor. 
        /// </summary>
        [MemberGroup("Night")]
        public bool useNightCubemap
        {
            get { return Omni.self.GetVar(_ID + ".useNightCubemap").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useNightCubemap", value.AsString()); }
        }

        /// <summary>
        /// Offsets the scatterSky to avoid canvas rendering. Use 5000 or greater for the initial adjustment 
        /// </summary>
        [MemberGroup("ScatterSky")]
        public float zoffset
        {
            get { return Omni.self.GetVar(_ID + ".zoffset").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".zoffset", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Apply a full network update of all fields to all clients.                  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void applyChanges()
        {
            m_ts.fnScatterSky_applyChanges(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public ScatterSky_Base()
        {
        }
    }
}