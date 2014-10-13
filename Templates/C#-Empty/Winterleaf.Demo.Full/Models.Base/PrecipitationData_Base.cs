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
    [TypeConverter(typeof (TypeConverterGeneric<PrecipitationData_Base>))]
    public partial class PrecipitationData_Base : GameBaseData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PrecipitationData_Base ts, string simobjectid)
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
        public static bool operator !=(PrecipitationData_Base ts, string simobjectid)
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
        public static implicit operator string(PrecipitationData_Base ts)
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
        public static implicit operator PrecipitationData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (PrecipitationData_Base) Omni.self.getSimObject(simobjectid, typeof (PrecipitationData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PrecipitationData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PrecipitationData_Base(int simobjectid)
        {
            return (PrecipitationData) Omni.self.getSimObject((uint) simobjectid, typeof (PrecipitationData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PrecipitationData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PrecipitationData_Base(uint simobjectid)
        {
            return (PrecipitationData_Base) Omni.self.getSimObject(simobjectid, typeof (PrecipitationData_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// The name of the shader used for raindrops. 
        /// </summary>
        [MemberGroup("")]
        public String dropShader
        {
            get { return Omni.self.GetVar(_ID + ".dropShader").AsString(); }
            set { Omni.self.SetVar(_ID + ".dropShader", value.AsString()); }
        }

        /// <summary>
        /// @brief How many rows and columns are in the raindrop texture.\n\n   For example, if the texture has 16 raindrops arranged in a grid, this    field should be set to 4. 
        /// </summary>
        [MemberGroup("")]
        public int dropsPerSide
        {
            get { return Omni.self.GetVar(_ID + ".dropsPerSide").AsInt(); }
            set { Omni.self.SetVar(_ID + ".dropsPerSide", value.AsString()); }
        }

        /// <summary>
        /// @brief Texture filename for drop particles.\n\n   The drop texture can contain several different drop sub-textures    arranged in a grid. There must be the same number of rows as columns. A    random frame will be chosen for each drop. 
        /// </summary>
        [MemberGroup("")]
        public String dropTexture
        {
            get { return Omni.self.GetVar(_ID + ".dropTexture").AsString(); }
            set { Omni.self.SetVar(_ID + ".dropTexture", value.AsString()); }
        }

        /// <summary>
        /// Looping SFXProfile effect to play while Precipitation is active. 
        /// </summary>
        [MemberGroup("")]
        public SFXTrack soundProfile
        {
            get { return Omni.self.GetVar(_ID + ".soundProfile"); }
            set { Omni.self.SetVar(_ID + ".soundProfile", value.ToString()); }
        }

        /// <summary>
        /// @brief How many rows and columns are in the splash texture.\n\n   For example, if the texture has 9 splashes arranged in a grid, this    field should be set to 3. 
        /// </summary>
        [MemberGroup("")]
        public int splashesPerSide
        {
            get { return Omni.self.GetVar(_ID + ".splashesPerSide").AsInt(); }
            set { Omni.self.SetVar(_ID + ".splashesPerSide", value.AsString()); }
        }

        /// <summary>
        /// The name of the shader used for splashes. 
        /// </summary>
        [MemberGroup("")]
        public String splashShader
        {
            get { return Omni.self.GetVar(_ID + ".splashShader").AsString(); }
            set { Omni.self.SetVar(_ID + ".splashShader", value.AsString()); }
        }

        /// <summary>
        /// @brief Texture filename for splash particles.\n\n   The splash texture can contain several different splash sub-textures    arranged in a grid. There must be the same number of rows as columns. A    random frame will be chosen for each splash. 
        /// </summary>
        [MemberGroup("")]
        public String splashTexture
        {
            get { return Omni.self.GetVar(_ID + ".splashTexture").AsString(); }
            set { Omni.self.SetVar(_ID + ".splashTexture", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public PrecipitationData_Base()
        {
        }
    }
}