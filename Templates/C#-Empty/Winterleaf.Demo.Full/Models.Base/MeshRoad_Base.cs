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
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<MeshRoad_Base>))]
    public partial class MeshRoad_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MeshRoad_Base ts, string simobjectid)
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
        public static bool operator !=(MeshRoad_Base ts, string simobjectid)
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
        public static implicit operator string(MeshRoad_Base ts)
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
        public static implicit operator MeshRoad_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (MeshRoad_Base) Omni.self.getSimObject(simobjectid, typeof (MeshRoad_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MeshRoad_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MeshRoad_Base(int simobjectid)
        {
            return (MeshRoad) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoad_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MeshRoad_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MeshRoad_Base(uint simobjectid)
        {
            return (MeshRoad_Base) Omni.self.getSimObject(simobjectid, typeof (MeshRoad_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Material for the bottom surface of the road. 
        /// </summary>
        [MemberGroup("MeshRoad")]
        public TypeMaterialName bottomMaterial
        {
            get { return Omni.self.GetVar(_ID + ".bottomMaterial").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".bottomMaterial", value.AsString()); }
        }

        /// <summary>
        /// Angle in degrees - MeshRoad will subdivide the spline if its curve is greater than this threshold. 
        /// </summary>
        [MemberGroup("MeshRoad")]
        public float breakAngle
        {
            get { return Omni.self.GetVar(_ID + ".breakAngle").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".breakAngle", value.AsString()); }
        }

        /// <summary>
        /// Do not modify, for internal use. 
        /// </summary>
        [MemberGroup("Internal")]
        public String Node
        {
            get { return Omni.self.GetVar(_ID + ".Node").AsString(); }
            set { Omni.self.SetVar(_ID + ".Node", value.AsString()); }
        }

        /// <summary>
        /// Material for the left, right, front, and back surfaces of the road. 
        /// </summary>
        [MemberGroup("MeshRoad")]
        public TypeMaterialName sideMaterial
        {
            get { return Omni.self.GetVar(_ID + ".sideMaterial").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".sideMaterial", value.AsString()); }
        }

        /// <summary>
        /// The length in meters of textures mapped to the MeshRoad. 
        /// </summary>
        [MemberGroup("MeshRoad")]
        public float textureLength
        {
            get { return Omni.self.GetVar(_ID + ".textureLength").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".textureLength", value.AsString()); }
        }

        /// <summary>
        /// Material for the upper surface of the road. 
        /// </summary>
        [MemberGroup("MeshRoad")]
        public TypeMaterialName topMaterial
        {
            get { return Omni.self.GetVar(_ID + ".topMaterial").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".topMaterial", value.AsString()); }
        }

        /// <summary>
        /// Subdivide segments widthwise this many times when generating vertices. 
        /// </summary>
        [MemberGroup("MeshRoad")]
        public int widthSubdivisions
        {
            get { return Omni.self.GetVar(_ID + ".widthSubdivisions").AsInt(); }
            set { Omni.self.SetVar(_ID + ".widthSubdivisions", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Intended as a helper to developers and editor scripts.                   Force trigger an inspectPostApply. This will transmit                    material and other fields ( not including nodes ) to client objects.                   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void postApply()
        {
            m_ts.fnMeshRoad_postApply(_ID);
        }

        /// <summary>
        /// Intended as a helper to developers and editor scripts.                   Force MeshRoad to recreate its geometry.                   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void regenerate()
        {
            m_ts.fnMeshRoad_regenerate(_ID);
        }

        /// <summary>
        /// Intended as a helper to developers and editor scripts.                   Sets the depth in meters of a particular node.                   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNodeDepth(int idx, float meters)
        {
            m_ts.fnMeshRoad_setNodeDepth(_ID, idx, meters);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public MeshRoad_Base()
        {
        }
    }
}