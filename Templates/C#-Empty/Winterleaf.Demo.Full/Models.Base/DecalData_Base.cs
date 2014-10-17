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
    [TypeConverter(typeof (TypeConverterGeneric<DecalData_Base>))]
    public partial class DecalData_Base : SimDataBlock
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DecalData_Base ts, string simobjectid)
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
        public static bool operator !=(DecalData_Base ts, string simobjectid)
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
        public static implicit operator string(DecalData_Base ts)
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
        public static implicit operator DecalData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DecalData_Base) Omni.self.getSimObject(simobjectid, typeof (DecalData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DecalData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DecalData_Base(int simobjectid)
        {
            return (DecalData) Omni.self.getSimObject((uint) simobjectid, typeof (DecalData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DecalData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DecalData_Base(uint simobjectid)
        {
            return (DecalData_Base) Omni.self.getSimObject(simobjectid, typeof (DecalData_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("Texturing")] public arrayObject<RectF> textureCoords;

        /// <summary>
        /// The angle in degrees used to clip geometry that faces away from the      decal projection direction. 
        /// </summary>
        [MemberGroup("Rendering")]
        public float clippingAngle
        {
            get { return Omni.self.GetVar(_ID + ".clippingAngle").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".clippingAngle", value.AsString()); }
        }

        /// <summary>
        /// @brief LOD value - size in pixels at which decals of this type are      fully faded out.\n\n     This should be a smaller value than #fadeStartPixelSize. 
        /// </summary>
        [MemberGroup("Rendering")]
        public float fadeEndPixelSize
        {
            get { return Omni.self.GetVar(_ID + ".fadeEndPixelSize").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fadeEndPixelSize", value.AsString()); }
        }

        /// <summary>
        /// @brief LOD value - size in pixels at which decals of this type begin      to fade out.\n\n     This should be a larger value than #fadeEndPixelSize. However, you may      also set this to a negative value to disable lod-based fading. 
        /// </summary>
        [MemberGroup("Rendering")]
        public float fadeStartPixelSize
        {
            get { return Omni.self.GetVar(_ID + ".fadeStartPixelSize").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fadeStartPixelSize", value.AsString()); }
        }

        /// <summary>
        /// @brief Time (in milliseconds) over which to fade out the decal before      deleting it at the end of its lifetime.\n\n     @see lifeSpan 
        /// </summary>
        [MemberGroup("Decal")]
        public int fadeTime
        {
            get { return Omni.self.GetVar(_ID + ".fadeTime").AsInt(); }
            set { Omni.self.SetVar(_ID + ".fadeTime", value.AsString()); }
        }

        /// <summary>
        /// Index of the texture rectangle within the imagemap to use for this decal. 
        /// </summary>
        [MemberGroup("Texturing")]
        public int frame
        {
            get { return Omni.self.GetVar(_ID + ".frame").AsInt(); }
            set { Omni.self.SetVar(_ID + ".frame", value.AsString()); }
        }

        /// <summary>
        /// Time (in milliseconds) before this decal will be automatically deleted. 
        /// </summary>
        [MemberGroup("Decal")]
        public int lifeSpan
        {
            get { return Omni.self.GetVar(_ID + ".lifeSpan").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lifeSpan", value.AsString()); }
        }

        /// <summary>
        /// Material to use for this decal. 
        /// </summary>
        [MemberGroup("Decal")]
        public TypeMaterialName material
        {
            get { return Omni.self.GetVar(_ID + ".material").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".material", value.AsString()); }
        }

        /// <summary>
        /// If true, a random frame from the imagemap is selected for each      instance of the decal. 
        /// </summary>
        [MemberGroup("Texturing")]
        public bool randomize
        {
            get { return Omni.self.GetVar(_ID + ".randomize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".randomize", value.AsString()); }
        }

        /// <summary>
        /// Default renderPriority for decals of this type (determines draw      order when decals overlap). 
        /// </summary>
        [MemberGroup("Rendering")]
        public sbyte renderPriority
        {
            get { return Omni.self.GetVar(_ID + ".renderPriority").AsSbyte(); }
            set { Omni.self.SetVar(_ID + ".renderPriority", value.AsString()); }
        }

        /// <summary>
        /// Width and height of the decal in meters before scale is applied. 
        /// </summary>
        [MemberGroup("Decal")]
        public float size
        {
            get { return Omni.self.GetVar(_ID + ".size").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".size", value.AsString()); }
        }

        /// <summary>
        /// @brief Number of columns in the supplied imagemap.\n\n     Use #texRows and #texCols if the imagemap frames are arranged in a      grid; use #textureCoords to manually specify UV coordinates for      irregular sized frames. 
        /// </summary>
        [MemberGroup("Texturing")]
        public int texCols
        {
            get { return Omni.self.GetVar(_ID + ".texCols").AsInt(); }
            set { Omni.self.SetVar(_ID + ".texCols", value.AsString()); }
        }

        /// <summary>
        /// @brief Number of rows in the supplied imagemap.\n\n     Use #texRows and #texCols if the imagemap frames are arranged in a      grid; use #textureCoords to manually specify UV coordinates for      irregular sized frames. 
        /// </summary>
        [MemberGroup("Texturing")]
        public int texRows
        {
            get { return Omni.self.GetVar(_ID + ".texRows").AsInt(); }
            set { Omni.self.SetVar(_ID + ".texRows", value.AsString()); }
        }

        /// <summary>
        /// Number of individual frames in the imagemap (maximum 16). 
        /// </summary>
        [MemberGroup("Texturing")]
        public int textureCoordCount
        {
            get { return Omni.self.GetVar(_ID + ".textureCoordCount").AsInt(); }
            set { Omni.self.SetVar(_ID + ".textureCoordCount", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Recompute the imagemap sub-texture rectangles for this DecalData.   @tsexample   // Inform the decal object to reload its imagemap and frame data.   %decalData.texRows = 4;   %decalData.postApply();   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void postApply()
        {
            m_ts.fnDecalData_postApply(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public DecalData_Base()
        {
            textureCoords = new arrayObject<RectF>(16, "textureCoords", "TypeVariable", false, this);
        }
    }
}