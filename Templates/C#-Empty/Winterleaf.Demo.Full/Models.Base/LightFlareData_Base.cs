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
    [TypeConverter(typeof (TypeConverterGeneric<LightFlareData_Base>))]
    public partial class LightFlareData_Base : SimDataBlock
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LightFlareData_Base ts, string simobjectid)
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
        public static bool operator !=(LightFlareData_Base ts, string simobjectid)
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
        public static implicit operator string(LightFlareData_Base ts)
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
        public static implicit operator LightFlareData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (LightFlareData_Base) Omni.self.getSimObject(simobjectid, typeof (LightFlareData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(LightFlareData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LightFlareData_Base(int simobjectid)
        {
            return (LightFlareData) Omni.self.getSimObject((uint) simobjectid, typeof (LightFlareData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(LightFlareData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LightFlareData_Base(uint simobjectid)
        {
            return (LightFlareData_Base) Omni.self.getSimObject(simobjectid, typeof (LightFlareData_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("FlareElements")] public arrayObject<float> elementDist;
        [MemberGroup("FlareElements")] public arrayObject<RectF> elementRect;
        [MemberGroup("FlareElements")] public arrayObject<bool> elementRotate;
        [MemberGroup("FlareElements")] public arrayObject<float> elementScale;
        [MemberGroup("FlareElements")] public arrayObject<ColorF> elementTint;
        [MemberGroup("FlareElements")] public arrayObject<bool> elementUseLightColor;

        /// <summary>
        /// Allows the user to disable this flare globally for any lights referencing it. 
        /// </summary>
        [MemberGroup("FlareElements")]
        public bool flareEnabled
        {
            get { return Omni.self.GetVar(_ID + ".flareEnabled").AsBool(); }
            set { Omni.self.SetVar(_ID + ".flareEnabled", value.AsString()); }
        }

        /// <summary>
        /// The texture / sprite sheet for this flare. 
        /// </summary>
        [MemberGroup("FlareElements")]
        public TypeImageFilename flareTexture
        {
            get { return Omni.self.GetVar(_ID + ".flareTexture").AsTypeImageFilename(); }
            set { Omni.self.SetVar(_ID + ".flareTexture", value.AsString()); }
        }

        /// <summary>
        /// If positive an occlusion query is used to test flare visibility, else it uses simple raycasts. 
        /// </summary>
        [MemberGroup("LightFlareData")]
        public float occlusionRadius
        {
            get { return Omni.self.GetVar(_ID + ".occlusionRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".occlusionRadius", value.AsString()); }
        }

        /// <summary>
        /// Size scale applied to all elements of the flare. 
        /// </summary>
        [MemberGroup("LightFlareData")]
        public float overallScale
        {
            get { return Omni.self.GetVar(_ID + ".overallScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".overallScale", value.AsString()); }
        }

        /// <summary>
        /// If false the flare does not render in reflections, else only non-zero distance elements are rendered. 
        /// </summary>
        [MemberGroup("LightFlareData")]
        public bool renderReflectPass
        {
            get { return Omni.self.GetVar(_ID + ".renderReflectPass").AsBool(); }
            set { Omni.self.SetVar(_ID + ".renderReflectPass", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply                   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void apply()
        {
            m_ts.fnLightFlareData_apply(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public LightFlareData_Base()
        {
            elementDist = new arrayObject<float>(20, "elementDist", "TypeVariable", false, this);
            elementRect = new arrayObject<RectF>(20, "elementRect", "TypeVariable", false, this);
            elementRotate = new arrayObject<bool>(20, "elementRotate", "TypeVariable", false, this);
            elementScale = new arrayObject<float>(20, "elementScale", "TypeVariable", false, this);
            elementTint = new arrayObject<ColorF>(20, "elementTint", "TypeVariable", false, this);
            elementUseLightColor = new arrayObject<bool>(20, "elementUseLightColor", "TypeVariable", false, this);
        }
    }
}