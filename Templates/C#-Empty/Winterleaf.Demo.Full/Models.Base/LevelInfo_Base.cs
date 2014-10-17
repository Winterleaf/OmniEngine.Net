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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<LevelInfo_Base>))]
    public partial class LevelInfo_Base : NetObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LevelInfo_Base ts, string simobjectid)
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
        public static bool operator !=(LevelInfo_Base ts, string simobjectid)
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
        public static implicit operator string(LevelInfo_Base ts)
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
        public static implicit operator LevelInfo_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (LevelInfo_Base) Omni.self.getSimObject(simobjectid, typeof (LevelInfo_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(LevelInfo_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LevelInfo_Base(int simobjectid)
        {
            return (LevelInfo) Omni.self.getSimObject((uint) simobjectid, typeof (LevelInfo_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(LevelInfo_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LevelInfo_Base(uint simobjectid)
        {
            return (LevelInfo_Base) Omni.self.getSimObject(simobjectid, typeof (LevelInfo_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Enable expanded support for mixing static and dynamic lighting (more costly) 
        /// </summary>
        [MemberGroup("Lighting")]
        public bool advancedLightmapSupport
        {
            get { return Omni.self.GetVar(_ID + ".advancedLightmapSupport").AsBool(); }
            set { Omni.self.SetVar(_ID + ".advancedLightmapSupport", value.AsString()); }
        }

        /// <summary>
        /// Interpolation curve to use for blending from one ambient light color to a different one. 
        /// </summary>
        [MemberGroup("Lighting")]
        public EaseF ambientLightBlendCurve
        {
            get { return Omni.self.GetVar(_ID + ".ambientLightBlendCurve").AsEaseF(); }
            set { Omni.self.SetVar(_ID + ".ambientLightBlendCurve", value.AsString()); }
        }

        /// <summary>
        /// Number of seconds it takes to blend from one ambient light color to a different one. 
        /// </summary>
        [MemberGroup("Lighting")]
        public float ambientLightBlendPhase
        {
            get { return Omni.self.GetVar(_ID + ".ambientLightBlendPhase").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".ambientLightBlendPhase", value.AsString()); }
        }

        /// <summary>
        /// The color used to clear the background before the scene or any GUIs are rendered. 
        /// </summary>
        [MemberGroup("LevelInfo")]
        public ColorI canvasClearColor
        {
            get { return Omni.self.GetVar(_ID + ".canvasClearColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".canvasClearColor", value.AsString()); }
        }

        /// <summary>
        /// NearPlane bias used when rendering Decal and DecalRoad. This should be tuned to the visibleDistance in your level. 
        /// </summary>
        [MemberGroup("Visibility")]
        public float decalBias
        {
            get { return Omni.self.GetVar(_ID + ".decalBias").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".decalBias", value.AsString()); }
        }

        /// <summary>
        /// A height in meters for altitude fog falloff. 
        /// </summary>
        [MemberGroup("Fog")]
        public float fogAtmosphereHeight
        {
            get { return Omni.self.GetVar(_ID + ".fogAtmosphereHeight").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fogAtmosphereHeight", value.AsString()); }
        }

        /// <summary>
        /// The default color for the scene fog. 
        /// </summary>
        [MemberGroup("Fog")]
        public ColorF fogColor
        {
            get { return Omni.self.GetVar(_ID + ".fogColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".fogColor", value.AsString()); }
        }

        /// <summary>
        /// The 0 to 1 density value for the exponential fog falloff. 
        /// </summary>
        [MemberGroup("Fog")]
        public float fogDensity
        {
            get { return Omni.self.GetVar(_ID + ".fogDensity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fogDensity", value.AsString()); }
        }

        /// <summary>
        /// An offset from the camera in meters for moving the start of the fog effect. 
        /// </summary>
        [MemberGroup("Fog")]
        public float fogDensityOffset
        {
            get { return Omni.self.GetVar(_ID + ".fogDensityOffset").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fogDensityOffset", value.AsString()); }
        }

        /// <summary>
        /// Point4F(left, right, top, bottom) - Offset to allow non axis aligned frustum. For full frustum use (0,1,0,1) 
        /// </summary>
        [MemberGroup("Visibility")]
        public Point4F frustumOffset
        {
            get { return Omni.self.GetVar(_ID + ".frustumOffset").AsPoint4F(); }
            set { Omni.self.SetVar(_ID + ".frustumOffset", value.AsString()); }
        }

        /// <summary>
        /// Closest distance from the camera's position to render the world. 
        /// </summary>
        [MemberGroup("Visibility")]
        public float nearClip
        {
            get { return Omni.self.GetVar(_ID + ".nearClip").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".nearClip", value.AsString()); }
        }

        /// <summary>
        /// The global ambient sound environment. 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXAmbienceName soundAmbience
        {
            get { return Omni.self.GetVar(_ID + ".soundAmbience").AsTypeSFXAmbienceName(); }
            set { Omni.self.SetVar(_ID + ".soundAmbience", value.AsString()); }
        }

        /// <summary>
        /// The distance attenuation model to use. 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXDistanceModel soundDistanceModel
        {
            get { return (TypeSFXDistanceModel) Omni.self.GetVar(_ID + ".soundDistanceModel"); }
            set { Omni.self.SetVar(_ID + ".soundDistanceModel", value.ToString()); }
        }

        /// <summary>
        /// Furthest distance fromt he camera's position to render the world. 
        /// </summary>
        [MemberGroup("Visibility")]
        public float visibleDistance
        {
            get { return Omni.self.GetVar(_ID + ".visibleDistance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".visibleDistance", value.AsString()); }
        }

        /// <summary>
        /// Furthest distance fromt he camera's position to render players. 
        /// </summary>
        [MemberGroup("Visibility")]
        public float visibleDistance_Ghost
        {
            get { return Omni.self.GetVar(_ID + ".visibleDistance_Ghost").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".visibleDistance_Ghost", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// ( LevelInfo, setNearClip, void, 3, 3, ( F32 nearClip ))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNearClip(string a2)
        {
            m_ts.fnLevelInfo_setNearClip(_ID, a2);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public LevelInfo_Base()
        {
        }
    }
}