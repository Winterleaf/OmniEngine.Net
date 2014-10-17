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
    [TypeConverter(typeof (TypeConverterGeneric<Sun_Base>))]
    public partial class Sun_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Sun_Base ts, string simobjectid)
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
        public static bool operator !=(Sun_Base ts, string simobjectid)
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
        public static implicit operator string(Sun_Base ts)
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
        public static implicit operator Sun_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Sun_Base) Omni.self.getSimObject(simobjectid, typeof (Sun_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Sun_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Sun_Base(int simobjectid)
        {
            return (Sun) Omni.self.getSimObject((uint) simobjectid, typeof (Sun_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Sun_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Sun_Base(uint simobjectid)
        {
            return (Sun_Base) Omni.self.getSimObject(simobjectid, typeof (Sun_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Color shading applied to surfaces not      in direct contact with light source, such as in the shadows or interiors.
        /// </summary>
        [MemberGroup("Lighting")]
        public ColorF ambient
        {
            get { return Omni.self.GetVar(_ID + ".ambient").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".ambient", value.AsString()); }
        }

        /// <summary>
        /// The horizontal angle of the sun measured clockwise from the positive Y world axis. 
        /// </summary>
        [MemberGroup("Orbit")]
        public float azimuth
        {
            get { return Omni.self.GetVar(_ID + ".azimuth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".azimuth", value.AsString()); }
        }

        /// <summary>
        /// Adjust the Sun's global contrast/intensity
        /// </summary>
        [MemberGroup("Lighting")]
        public float brightness
        {
            get { return Omni.self.GetVar(_ID + ".brightness").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".brightness", value.AsString()); }
        }

        /// <summary>
        /// Enables/disables shadows cast by objects due to Sun light
        /// </summary>
        [MemberGroup("Lighting")]
        public bool castShadows
        {
            get { return Omni.self.GetVar(_ID + ".castShadows").AsBool(); }
            set { Omni.self.SetVar(_ID + ".castShadows", value.AsString()); }
        }

        /// <summary>
        /// Color shading applied to surfaces in direct contact with light source.
        /// </summary>
        [MemberGroup("Lighting")]
        public ColorF color
        {
            get { return Omni.self.GetVar(_ID + ".color").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".color", value.AsString()); }
        }

        /// <summary>
        /// Enable or disable rendering of the corona sprite. 
        /// </summary>
        [MemberGroup("Corona")]
        public bool coronaEnabled
        {
            get { return Omni.self.GetVar(_ID + ".coronaEnabled").AsBool(); }
            set { Omni.self.SetVar(_ID + ".coronaEnabled", value.AsString()); }
        }

        /// <summary>
        /// Texture for the corona sprite. 
        /// </summary>
        [MemberGroup("Corona")]
        public TypeMaterialName coronaMaterial
        {
            get { return Omni.self.GetVar(_ID + ".coronaMaterial").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".coronaMaterial", value.AsString()); }
        }

        /// <summary>
        /// Controls size the corona sprite renders, specified as a fractional amount of the screen height. 
        /// </summary>
        [MemberGroup("Corona")]
        public float coronaScale
        {
            get { return Omni.self.GetVar(_ID + ".coronaScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".coronaScale", value.AsString()); }
        }

        /// <summary>
        /// Modulates the corona sprite color ( if coronaUseLightColor is false ). 
        /// </summary>
        [MemberGroup("Corona")]
        public ColorF coronaTint
        {
            get { return Omni.self.GetVar(_ID + ".coronaTint").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".coronaTint", value.AsString()); }
        }

        /// <summary>
        /// Modulate the corona sprite color by the color of the light ( overrides coronaTint ). 
        /// </summary>
        [MemberGroup("Corona")]
        public bool coronaUseLightColor
        {
            get { return Omni.self.GetVar(_ID + ".coronaUseLightColor").AsBool(); }
            set { Omni.self.SetVar(_ID + ".coronaUseLightColor", value.AsString()); }
        }

        /// <summary>
        /// The elevation angle of the sun above or below the horizon. 
        /// </summary>
        [MemberGroup("Orbit")]
        public float elevation
        {
            get { return Omni.self.GetVar(_ID + ".elevation").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".elevation", value.AsString()); }
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
        /// Datablock for the flare produced by the Sun 
        /// </summary>
        [MemberGroup("Misc")]
        public LightFlareData flareType
        {
            get { return Omni.self.GetVar(_ID + ".flareType"); }
            set { Omni.self.SetVar(_ID + ".flareType", value.ToString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// animate( F32 duration, F32 startAzimuth, F32 endAzimuth, F32 startElevation, F32 endElevation ))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void animate(float duration, float startAzimuth, float endAzimuth, float startElevation, float endElevation)
        {
            m_ts.fn_Sun_animate(_ID, duration, startAzimuth, endAzimuth, startElevation, endElevation);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void apply()
        {
            m_ts.fn_Sun_apply(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public Sun_Base()
        {
        }
    }
}