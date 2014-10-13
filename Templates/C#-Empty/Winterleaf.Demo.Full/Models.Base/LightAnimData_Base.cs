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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<LightAnimData_Base>))]
    public partial class LightAnimData_Base : SimDataBlock
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LightAnimData_Base ts, string simobjectid)
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
        public static bool operator !=(LightAnimData_Base ts, string simobjectid)
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
        public static implicit operator string(LightAnimData_Base ts)
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
        public static implicit operator LightAnimData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (LightAnimData_Base) Omni.self.getSimObject(simobjectid, typeof (LightAnimData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(LightAnimData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LightAnimData_Base(int simobjectid)
        {
            return (LightAnimData) Omni.self.getSimObject((uint) simobjectid, typeof (LightAnimData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(LightAnimData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LightAnimData_Base(uint simobjectid)
        {
            return (LightAnimData_Base) Omni.self.getSimObject(simobjectid, typeof (LightAnimData_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("Color")] public arrayObject<float> colorA;
        [MemberGroup("Color")] public arrayObject<String> colorKeys;
        [MemberGroup("Color")] public arrayObject<float> colorPeriod;
        [MemberGroup("Color")] public arrayObject<bool> colorSmooth;
        [MemberGroup("Color")] public arrayObject<float> colorZ;
        [MemberGroup("Offset")] public arrayObject<float> offsetA;
        [MemberGroup("Offset")] public arrayObject<String> offsetKeys;
        [MemberGroup("Offset")] public arrayObject<float> offsetPeriod;
        [MemberGroup("Offset")] public arrayObject<bool> offsetSmooth;
        [MemberGroup("Offset")] public arrayObject<float> offsetZ;
        [MemberGroup("Rotation")] public arrayObject<float> rotA;
        [MemberGroup("Rotation")] public arrayObject<String> rotKeys;
        [MemberGroup("Rotation")] public arrayObject<float> rotPeriod;
        [MemberGroup("Rotation")] public arrayObject<bool> rotSmooth;
        [MemberGroup("Rotation")] public arrayObject<float> rotZ;

        /// <summary>
        /// The value of the A key in the keyframe sequence. 
        /// </summary>
        [MemberGroup("Brightness")]
        public float brightnessA
        {
            get { return Omni.self.GetVar(_ID + ".brightnessA").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".brightnessA", value.AsString()); }
        }

        /// <summary>
        /// The keyframe sequence encoded into a string where characters from A to Z define      a position between the two animation values. 
        /// </summary>
        [MemberGroup("Brightness")]
        public String brightnessKeys
        {
            get { return Omni.self.GetVar(_ID + ".brightnessKeys").AsString(); }
            set { Omni.self.SetVar(_ID + ".brightnessKeys", value.AsString()); }
        }

        /// <summary>
        /// The animation time for keyframe sequence. 
        /// </summary>
        [MemberGroup("Brightness")]
        public float brightnessPeriod
        {
            get { return Omni.self.GetVar(_ID + ".brightnessPeriod").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".brightnessPeriod", value.AsString()); }
        }

        /// <summary>
        /// If true the transition between keyframes will be smooth. 
        /// </summary>
        [MemberGroup("Brightness")]
        public bool brightnessSmooth
        {
            get { return Omni.self.GetVar(_ID + ".brightnessSmooth").AsBool(); }
            set { Omni.self.SetVar(_ID + ".brightnessSmooth", value.AsString()); }
        }

        /// <summary>
        /// The value of the Z key in the keyframe sequence. 
        /// </summary>
        [MemberGroup("Brightness")]
        public float brightnessZ
        {
            get { return Omni.self.GetVar(_ID + ".brightnessZ").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".brightnessZ", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public LightAnimData_Base()
        {
            colorA = new arrayObject<float>(3, "colorA", "TypeVariable", false, this);
            colorKeys = new arrayObject<String>(3, "colorKeys", "TypeVariable", false, this);
            colorPeriod = new arrayObject<float>(3, "colorPeriod", "TypeVariable", false, this);
            colorSmooth = new arrayObject<bool>(3, "colorSmooth", "TypeVariable", false, this);
            colorZ = new arrayObject<float>(3, "colorZ", "TypeVariable", false, this);
            offsetA = new arrayObject<float>(3, "offsetA", "TypeVariable", false, this);
            offsetKeys = new arrayObject<String>(3, "offsetKeys", "TypeVariable", false, this);
            offsetPeriod = new arrayObject<float>(3, "offsetPeriod", "TypeVariable", false, this);
            offsetSmooth = new arrayObject<bool>(3, "offsetSmooth", "TypeVariable", false, this);
            offsetZ = new arrayObject<float>(3, "offsetZ", "TypeVariable", false, this);
            rotA = new arrayObject<float>(3, "rotA", "TypeVariable", false, this);
            rotKeys = new arrayObject<String>(3, "rotKeys", "TypeVariable", false, this);
            rotPeriod = new arrayObject<float>(3, "rotPeriod", "TypeVariable", false, this);
            rotSmooth = new arrayObject<bool>(3, "rotSmooth", "TypeVariable", false, this);
            rotZ = new arrayObject<float>(3, "rotZ", "TypeVariable", false, this);
        }
    }
}