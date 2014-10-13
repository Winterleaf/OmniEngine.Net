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
    [TypeConverter(typeof (TypeConverterGeneric<SplashData_Base>))]
    public partial class SplashData_Base : GameBaseData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SplashData_Base ts, string simobjectid)
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
        public static bool operator !=(SplashData_Base ts, string simobjectid)
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
        public static implicit operator string(SplashData_Base ts)
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
        public static implicit operator SplashData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SplashData_Base) Omni.self.getSimObject(simobjectid, typeof (SplashData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SplashData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SplashData_Base(int simobjectid)
        {
            return (SplashData) Omni.self.getSimObject((uint) simobjectid, typeof (SplashData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SplashData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SplashData_Base(uint simobjectid)
        {
            return (SplashData_Base) Omni.self.getSimObject(simobjectid, typeof (SplashData_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("")] public arrayObject<ColorF> colors;
        [MemberGroup("")] public arrayObject<ParticleEmitterData> emitter;
        [MemberGroup("")] public arrayObject<String> texture;
        [MemberGroup("")] public arrayObject<float> times;

        /// <summary>
        /// Constant acceleration value to place upon the splash effect.\n
        /// </summary>
        [MemberGroup("")]
        public float acceleration
        {
            get { return Omni.self.GetVar(_ID + ".acceleration").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".acceleration", value.AsString()); }
        }

        /// <summary>
        /// Time to delay, in milliseconds, before actually starting this effect.\n
        /// </summary>
        [MemberGroup("")]
        public int delayMS
        {
            get { return Omni.self.GetVar(_ID + ".delayMS").AsInt(); }
            set { Omni.self.SetVar(_ID + ".delayMS", value.AsString()); }
        }

        /// <summary>
        /// Time variance for delayMS.\n
        /// </summary>
        [MemberGroup("")]
        public int delayVariance
        {
            get { return Omni.self.GetVar(_ID + ".delayVariance").AsInt(); }
            set { Omni.self.SetVar(_ID + ".delayVariance", value.AsString()); }
        }

        /// <summary>
        /// Rotational angle to create a splash ring.\n
        /// </summary>
        [MemberGroup("")]
        public float ejectionAngle
        {
            get { return Omni.self.GetVar(_ID + ".ejectionAngle").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".ejectionAngle", value.AsString()); }
        }

        /// <summary>
        /// Frequency in which to emit splash rings.\n
        /// </summary>
        [MemberGroup("")]
        public float ejectionFreq
        {
            get { return Omni.self.GetVar(_ID + ".ejectionFreq").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".ejectionFreq", value.AsString()); }
        }

        /// <summary>
        /// ExplosionData object to create at the creation position of this splash effect.\n
        /// </summary>
        [MemberGroup("")]
        public ExplosionData explosion
        {
            get { return Omni.self.GetVar(_ID + ".explosion"); }
            set { Omni.self.SetVar(_ID + ".explosion", value.ToString()); }
        }

        /// <summary>
        /// Height for the splash to reach.\n
        /// </summary>
        [MemberGroup("")]
        public float height
        {
            get { return Omni.self.GetVar(_ID + ".height").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".height", value.AsString()); }
        }

        /// <summary>
        /// Lifetime for this effect, in milliseconds.\n
        /// </summary>
        [MemberGroup("")]
        public int lifetimeMS
        {
            get { return Omni.self.GetVar(_ID + ".lifetimeMS").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lifetimeMS", value.AsString()); }
        }

        /// <summary>
        /// Time variance for lifetimeMS.\n
        /// </summary>
        [MemberGroup("")]
        public int lifetimeVariance
        {
            get { return Omni.self.GetVar(_ID + ".lifetimeVariance").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lifetimeVariance", value.AsString()); }
        }

        /// <summary>
        /// Number of ejection points in the splash ring.\n
        /// </summary>
        [MemberGroup("")]
        public int numSegments
        {
            get { return Omni.self.GetVar(_ID + ".numSegments").AsInt(); }
            set { Omni.self.SetVar(_ID + ".numSegments", value.AsString()); }
        }

        /// <summary>
        /// Lifetime, in milliseconds, for a splash ring.\n
        /// </summary>
        [MemberGroup("")]
        public float ringLifetime
        {
            get { return Omni.self.GetVar(_ID + ".ringLifetime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".ringLifetime", value.AsString()); }
        }

        /// <summary>
        /// The scale of this splashing effect, defined as the F32 points X, Y, Z.\n
        /// </summary>
        [MemberGroup("")]
        public Point3F scale
        {
            get { return Omni.self.GetVar(_ID + ".scale").AsPoint3F(); }
            set { Omni.self.SetVar(_ID + ".scale", value.AsString()); }
        }

        /// <summary>
        /// SFXProfile effect to play.\n
        /// </summary>
        [MemberGroup("")]
        public SFXProfile soundProfile
        {
            get { return Omni.self.GetVar(_ID + ".soundProfile"); }
            set { Omni.self.SetVar(_ID + ".soundProfile", value.ToString()); }
        }

        /// <summary>
        /// Starting radius size of a splash ring.\n
        /// </summary>
        [MemberGroup("")]
        public float startRadius
        {
            get { return Omni.self.GetVar(_ID + ".startRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".startRadius", value.AsString()); }
        }

        /// <summary>
        /// Factor in which to apply the texture to the splash ring, 0.0f - 1.0f.\n
        /// </summary>
        [MemberGroup("")]
        public float texFactor
        {
            get { return Omni.self.GetVar(_ID + ".texFactor").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".texFactor", value.AsString()); }
        }

        /// <summary>
        /// Amount to wrap the texture around the splash ring, 0.0f - 1.0f.\n
        /// </summary>
        [MemberGroup("")]
        public float texWrap
        {
            get { return Omni.self.GetVar(_ID + ".texWrap").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".texWrap", value.AsString()); }
        }

        /// <summary>
        /// Velocity for the splash effect to travel.\n
        /// </summary>
        [MemberGroup("")]
        public float velocity
        {
            get { return Omni.self.GetVar(_ID + ".velocity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".velocity", value.AsString()); }
        }

        /// <summary>
        /// Width for the X and Y coordinates to create this effect within.
        /// </summary>
        [MemberGroup("")]
        public float width
        {
            get { return Omni.self.GetVar(_ID + ".width").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".width", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public SplashData_Base()
        {
            colors = new arrayObject<ColorF>(4, "colors", "TypeVariable", false, this);
            emitter = new arrayObject<ParticleEmitterData>(3, "emitter", "T3DObject", false, this);
            texture = new arrayObject<String>(2, "texture", "TypeVariable", false, this);
            times = new arrayObject<float>(4, "times", "TypeVariable", false, this);
        }
    }
}