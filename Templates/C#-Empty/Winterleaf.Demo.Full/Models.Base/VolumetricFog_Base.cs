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
    [TypeConverter(typeof (TypeConverterGeneric<VolumetricFog_Base>))]
    public partial class VolumetricFog_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(VolumetricFog_Base ts, string simobjectid)
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
        public static bool operator !=(VolumetricFog_Base ts, string simobjectid)
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
        public static implicit operator string(VolumetricFog_Base ts)
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
        public static implicit operator VolumetricFog_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (VolumetricFog_Base) Omni.self.getSimObject(simobjectid, typeof (VolumetricFog_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(VolumetricFog_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator VolumetricFog_Base(int simobjectid)
        {
            return (VolumetricFog) Omni.self.getSimObject((uint) simobjectid, typeof (VolumetricFog_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(VolumetricFog_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator VolumetricFog_Base(uint simobjectid)
        {
            return (VolumetricFog_Base) Omni.self.getSimObject(simobjectid, typeof (VolumetricFog_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Fog color RGBA (Alpha is ignored)
        /// </summary>
        [MemberGroup("VolumetricFogData")]
        public ColorI FogColor
        {
            get { return Omni.self.GetVar(_ID + ".FogColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".FogColor", value.AsString()); }
        }

        /// <summary>
        /// Overal fog density value (0 disables the fog).
        /// </summary>
        [MemberGroup("VolumetricFogData")]
        public float FogDensity
        {
            get { return Omni.self.GetVar(_ID + ".FogDensity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".FogDensity", value.AsString()); }
        }

        /// <summary>
        /// Set to true if volumetric fog should continue while submerged.
        /// </summary>
        [MemberGroup("VolumetricFogData")]
        public bool IgnoreWater
        {
            get { return Omni.self.GetVar(_ID + ".IgnoreWater").AsBool(); }
            set { Omni.self.SetVar(_ID + ".IgnoreWater", value.AsString()); }
        }

        /// <summary>
        /// Min size (in pixels) for fog to be rendered.
        /// </summary>
        [MemberGroup("VolumetricFogData")]
        public float MinSize
        {
            get { return Omni.self.GetVar(_ID + ".MinSize").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".MinSize", value.AsString()); }
        }

        /// <summary>
        /// Overall strength of the density modulation (0 disables modulation).
        /// </summary>
        [MemberGroup("VolumetricFogModulation")]
        public float modStrength
        {
            get { return Omni.self.GetVar(_ID + ".modStrength").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".modStrength", value.AsString()); }
        }

        /// <summary>
        /// Overall primary speed of the density modulation (x-speed(u) y-speed(v))
        /// </summary>
        [MemberGroup("VolumetricFogModulation")]
        public Point2F PrimSpeed
        {
            get { return Omni.self.GetVar(_ID + ".PrimSpeed").AsPoint2F(); }
            set { Omni.self.SetVar(_ID + ".PrimSpeed", value.AsString()); }
        }

        /// <summary>
        /// Overall secundary speed of the density modulation (x-speed(u) y-speed(v))
        /// </summary>
        [MemberGroup("VolumetricFogModulation")]
        public Point2F SecSpeed
        {
            get { return Omni.self.GetVar(_ID + ".SecSpeed").AsPoint2F(); }
            set { Omni.self.SetVar(_ID + ".SecSpeed", value.AsString()); }
        }

        /// <summary>
        /// Path and filename of the model file (.DTS, .DAE) to use for this Volume.
        /// </summary>
        [MemberGroup("VolumetricFogData")]
        public TypeShapeFilename shapeName
        {
            get { return Omni.self.GetVar(_ID + ".shapeName").AsTypeShapeFilename(); }
            set { Omni.self.SetVar(_ID + ".shapeName", value.AsString()); }
        }

        /// <summary>
        /// A texture which contains Fogdensity modulator in the red channel and color with 1-green channel. No texture disables modulation.
        /// </summary>
        [MemberGroup("VolumetricFogModulation")]
        public TypeImageFilename texture
        {
            get { return Omni.self.GetVar(_ID + ".texture").AsTypeImageFilename(); }
            set { Omni.self.SetVar(_ID + ".texture", value.AsString()); }
        }

        /// <summary>
        /// How many times the texture is mapped to the object.
        /// </summary>
        [MemberGroup("VolumetricFogModulation")]
        public float tiles
        {
            get { return Omni.self.GetVar(_ID + ".tiles").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".tiles", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Changes the color of the fog.
        /// 	@params new_color the new fog color (rgb 0-255, a is ignored.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void SetFogColor(ColorI new_color)
        {
            m_ts.fnVolumetricFog_SetFogColor(_ID, new_color.AsString());
        }

        /// <summary>
        /// @brief Changes the color of the fog.
        /// 	@params new_color the new fog color (rgb 0.0 - 1.0, a is ignored.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void SetFogColorF(ColorF new_color)
        {
            m_ts.fnVolumetricFog_SetFogColorF(_ID, new_color.AsString());
        }

        /// <summary>
        /// @brief Changes the density of the fog.
        /// 	@params new_density the new fog density.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void SetFogDensity(float new_density)
        {
            m_ts.fnVolumetricFog_SetFogDensity(_ID, new_density);
        }

        /// <summary>
        /// @brief Changes the modulation of the fog.
        /// 	@params new_strenght the new strength of the modulation.
        /// 	@params new_speed1 the new speed (x y) of the modulation layer 1.
        /// 	@params new_speed2 the new speed (x y) of the modulation layer 2.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void SetFogModulation(float new_strenght, Point2F new_speed1, Point2F new_speed2)
        {
            m_ts.fnVolumetricFog_SetFogModulation(_ID, new_strenght, new_speed1.AsString(), new_speed2.AsString());
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called when an object enters the volume of the Fog instance.	@param obj the controlobject entering the fog.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEnterFog(string obj)
        {
        }

        /// <summary>
        /// @brief Called when an object left the volume of the Fog instance.	@param obj the controlobject leaving the fog.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onLeaveFog(string obj)
        {
        }

        #endregion

        public VolumetricFog_Base()
        {
        }
    }
}