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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GFXSamplerStateData_Base>))]
    public partial class GFXSamplerStateData_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GFXSamplerStateData_Base ts, string simobjectid)
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
        public static bool operator !=(GFXSamplerStateData_Base ts, string simobjectid)
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
        public static implicit operator string(GFXSamplerStateData_Base ts)
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
        public static implicit operator GFXSamplerStateData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GFXSamplerStateData_Base) Omni.self.getSimObject(simobjectid, typeof (GFXSamplerStateData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GFXSamplerStateData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GFXSamplerStateData_Base(int simobjectid)
        {
            return (GFXSamplerStateData) Omni.self.getSimObject((uint) simobjectid, typeof (GFXSamplerStateData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GFXSamplerStateData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GFXSamplerStateData_Base(uint simobjectid)
        {
            return (GFXSamplerStateData_Base) Omni.self.getSimObject(simobjectid, typeof (GFXSamplerStateData_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// The texture address mode for the u coordinate. The default is GFXAddressWrap. 
        /// </summary>
        [MemberGroup("Address Mode")]
        public TypeGFXTextureAddressMode addressModeU
        {
            get { return (TypeGFXTextureAddressMode) Omni.self.GetVar(_ID + ".addressModeU"); }
            set { Omni.self.SetVar(_ID + ".addressModeU", value.ToString()); }
        }

        /// <summary>
        /// The texture address mode for the v coordinate. The default is GFXAddressWrap. 
        /// </summary>
        [MemberGroup("Address Mode")]
        public TypeGFXTextureAddressMode addressModeV
        {
            get { return (TypeGFXTextureAddressMode) Omni.self.GetVar(_ID + ".addressModeV"); }
            set { Omni.self.SetVar(_ID + ".addressModeV", value.ToString()); }
        }

        /// <summary>
        /// The texture address mode for the w coordinate. The default is GFXAddressWrap. 
        /// </summary>
        [MemberGroup("Address Mode")]
        public TypeGFXTextureAddressMode addressModeW
        {
            get { return (TypeGFXTextureAddressMode) Omni.self.GetVar(_ID + ".addressModeW"); }
            set { Omni.self.SetVar(_ID + ".addressModeW", value.ToString()); }
        }

        /// <summary>
        /// The first alpha argument for the texture stage. The default value is GFXTATexture. 
        /// </summary>
        [MemberGroup("Alpha Op")]
        public TypeGFXTextureArgument alphaArg1
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".alphaArg1"); }
            set { Omni.self.SetVar(_ID + ".alphaArg1", value.ToString()); }
        }

        /// <summary>
        /// The second alpha argument for the texture stage. The default value is GFXTADiffuse. 
        /// </summary>
        [MemberGroup("Alpha Op")]
        public TypeGFXTextureArgument alphaArg2
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".alphaArg2"); }
            set { Omni.self.SetVar(_ID + ".alphaArg2", value.ToString()); }
        }

        /// <summary>
        /// The third alpha channel selector operand for triadic operations (multiply, add, and linearly interpolate). The default value is GFXTACurrent. 
        /// </summary>
        [MemberGroup("Alpha Op")]
        public TypeGFXTextureArgument alphaArg3
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".alphaArg3"); }
            set { Omni.self.SetVar(_ID + ".alphaArg3", value.ToString()); }
        }

        /// <summary>
        /// The texture alpha blending operation. The default value is GFXTOPModulate. 
        /// </summary>
        [MemberGroup("Alpha Op")]
        public TypeGFXTextureOp alphaOp
        {
            get { return (TypeGFXTextureOp) Omni.self.GetVar(_ID + ".alphaOp"); }
            set { Omni.self.SetVar(_ID + ".alphaOp", value.ToString()); }
        }

        /// <summary>
        /// The first color argument for the texture stage. The default value is GFXTACurrent. 
        /// </summary>
        [MemberGroup("Color Op")]
        public TypeGFXTextureArgument colorArg1
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".colorArg1"); }
            set { Omni.self.SetVar(_ID + ".colorArg1", value.ToString()); }
        }

        /// <summary>
        /// The second color argument for the texture stage. The default value is GFXTATexture. 
        /// </summary>
        [MemberGroup("Color Op")]
        public TypeGFXTextureArgument colorArg2
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".colorArg2"); }
            set { Omni.self.SetVar(_ID + ".colorArg2", value.ToString()); }
        }

        /// <summary>
        /// The third color argument for triadic operations (multiply, add, and linearly interpolate). The default value is GFXTACurrent. 
        /// </summary>
        [MemberGroup("Color Op")]
        public TypeGFXTextureArgument colorArg3
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".colorArg3"); }
            set { Omni.self.SetVar(_ID + ".colorArg3", value.ToString()); }
        }

        /// <summary>
        /// The texture magnification filter. The default is GFXTextureFilterLinear. 
        /// </summary>
        [MemberGroup("Filter State")]
        public TypeGFXTextureFilterType magFilter
        {
            get { return (TypeGFXTextureFilterType) Omni.self.GetVar(_ID + ".magFilter"); }
            set { Omni.self.SetVar(_ID + ".magFilter", value.ToString()); }
        }

        /// <summary>
        /// The maximum texture anisotropy. The default value is 1. 
        /// </summary>
        [MemberGroup("Filter State")]
        public int maxAnisotropy
        {
            get { return Omni.self.GetVar(_ID + ".maxAnisotropy").AsInt(); }
            set { Omni.self.SetVar(_ID + ".maxAnisotropy", value.AsString()); }
        }

        /// <summary>
        /// The texture minification filter. The default is GFXTextureFilterLinear. 
        /// </summary>
        [MemberGroup("Filter State")]
        public TypeGFXTextureFilterType minFilter
        {
            get { return (TypeGFXTextureFilterType) Omni.self.GetVar(_ID + ".minFilter"); }
            set { Omni.self.SetVar(_ID + ".minFilter", value.ToString()); }
        }

        /// <summary>
        /// The texture mipmap filter used during minification. The default is GFXTextureFilterLinear. 
        /// </summary>
        [MemberGroup("Filter State")]
        public TypeGFXTextureFilterType mipFilter
        {
            get { return (TypeGFXTextureFilterType) Omni.self.GetVar(_ID + ".mipFilter"); }
            set { Omni.self.SetVar(_ID + ".mipFilter", value.ToString()); }
        }

        /// <summary>
        /// The mipmap level of detail bias. The default value is zero. 
        /// </summary>
        [MemberGroup("Filter State")]
        public float mipLODBias
        {
            get { return Omni.self.GetVar(_ID + ".mipLODBias").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".mipLODBias", value.AsString()); }
        }

        /// <summary>
        /// The selection of the destination register for the result of this stage. The default is GFXTACurrent. 
        /// </summary>
        [MemberGroup("")]
        public TypeGFXTextureArgument resultArg
        {
            get { return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".resultArg"); }
            set { Omni.self.SetVar(_ID + ".resultArg", value.ToString()); }
        }

        /// <summary>
        /// The texture color blending operation. The default value is GFXTOPDisable which disables the sampler. 
        /// </summary>
        [MemberGroup("Color Op")]
        public TypeGFXTextureOp textureColorOp
        {
            get { return (TypeGFXTextureOp) Omni.self.GetVar(_ID + ".textureColorOp"); }
            set { Omni.self.SetVar(_ID + ".textureColorOp", value.ToString()); }
        }

        /// <summary>
        /// Sets the texture transform state. The default is GFXTTFFDisable. 
        /// </summary>
        [MemberGroup("")]
        public TypeGFXTextureTransformFlags textureTransform
        {
            get { return (TypeGFXTextureTransformFlags) Omni.self.GetVar(_ID + ".textureTransform"); }
            set { Omni.self.SetVar(_ID + ".textureTransform", value.ToString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public GFXSamplerStateData_Base()
        {
        }
    }
}