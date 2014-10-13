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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<TSStatic_Base>))]
    public partial class TSStatic_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TSStatic_Base ts, string simobjectid)
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
        public static bool operator !=(TSStatic_Base ts, string simobjectid)
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
        public static implicit operator string(TSStatic_Base ts)
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
        public static implicit operator TSStatic_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TSStatic_Base) Omni.self.getSimObject(simobjectid, typeof (TSStatic_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TSStatic_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TSStatic_Base(int simobjectid)
        {
            return (TSStatic) Omni.self.getSimObject((uint) simobjectid, typeof (TSStatic_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TSStatic_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TSStatic_Base(uint simobjectid)
        {
            return (TSStatic_Base) Omni.self.getSimObject(simobjectid, typeof (TSStatic_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// @brief Allow a Player to walk up sloping polygons in the TSStatic (based on the collisionType).\n\n     When set to false, the slightest bump will stop the player from walking on top of the object.\n
        /// </summary>
        [MemberGroup("Collision")]
        public bool allowPlayerStep
        {
            get { return Omni.self.GetVar(_ID + ".allowPlayerStep").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowPlayerStep", value.AsString()); }
        }

        /// <summary>
        /// The type of mesh data to use for collision queries. 
        /// </summary>
        [MemberGroup("Collision")]
        public TypeTSMeshType collisionType
        {
            get { return (TypeTSMeshType) Omni.self.GetVar(_ID + ".collisionType"); }
            set { Omni.self.SetVar(_ID + ".collisionType", value.ToString()); }
        }

        /// <summary>
        /// The type of mesh data used to clip decal polygons against. 
        /// </summary>
        [MemberGroup("Collision")]
        public TypeTSMeshType decalType
        {
            get { return (TypeTSMeshType) Omni.self.GetVar(_ID + ".decalType"); }
            set { Omni.self.SetVar(_ID + ".decalType", value.ToString()); }
        }

        /// <summary>
        /// Forces rendering to a particular detail level. 
        /// </summary>
        [MemberGroup("Debug")]
        public int forceDetail
        {
            get { return Omni.self.GetVar(_ID + ".forceDetail").AsInt(); }
            set { Omni.self.SetVar(_ID + ".forceDetail", value.AsString()); }
        }

        /// <summary>
        /// Enables detailed culling of meshes within the TSStatic. Should only be used      with large complex shapes like buildings which contain many submeshes. 
        /// </summary>
        [MemberGroup("Rendering")]
        public bool meshCulling
        {
            get { return Omni.self.GetVar(_ID + ".meshCulling").AsBool(); }
            set { Omni.self.SetVar(_ID + ".meshCulling", value.AsString()); }
        }

        /// <summary>
        /// Enables translucent sorting of the TSStatic by its origin instead of the bounds. 
        /// </summary>
        [MemberGroup("Rendering")]
        public bool originSort
        {
            get { return Omni.self.GetVar(_ID + ".originSort").AsBool(); }
            set { Omni.self.SetVar(_ID + ".originSort", value.AsString()); }
        }

        /// <summary>
        /// Enables automatic playing of the animation sequence named \ambient\ (if it exists) when the TSStatic is loaded.
        /// </summary>
        [MemberGroup("Rendering")]
        public bool playAmbient
        {
            get { return Omni.self.GetVar(_ID + ".playAmbient").AsBool(); }
            set { Omni.self.SetVar(_ID + ".playAmbient", value.AsString()); }
        }

        /// <summary>
        /// Debug rendering mode shows the normals for each point in the TSStatic's mesh. 
        /// </summary>
        [MemberGroup("Debug")]
        public float renderNormals
        {
            get { return Omni.self.GetVar(_ID + ".renderNormals").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".renderNormals", value.AsString()); }
        }

        /// <summary>
        /// %Path and filename of the model file (.DTS, .DAE) to use for this TSStatic. 
        /// </summary>
        [MemberGroup("Media")]
        public TypeShapeFilename shapeName
        {
            get { return Omni.self.GetVar(_ID + ".shapeName").AsTypeShapeFilename(); }
            set { Omni.self.SetVar(_ID + ".shapeName", value.AsString()); }
        }

        /// <summary>
        /// @brief The skin applied to the shape.\n\n   'Skinning' the shape effectively renames the material targets, allowing    different materials to be used on different instances of the same model.\n\n   Any material targets that start with the old skin name have that part    of the name replaced with the new skin name. The initial old skin name is    \base\. For example, if a new skin of \blue\ was applied to a model    that had material targets ibase_body/i and iface/i, the new targets    would be iblue_body/i and iface/i. Note that iface/i was not    renamed since it did not start with the old skin name of \base\.\n\n   To support models that do not use the default \base\ naming convention,    you can also specify the part of the name to replace in the skin field    itself. For example, if a model had a material target called ishapemat/i,    we could apply a new skin \shape=blue\, and the material target would be    renamed to ibluemat/i (note \shape\ has been replaced with \blue\).\n\n   Multiple skin updates can also be applied at the same time by separating    them with a semicolon. For example: \base=blue;face=happy_face\.\n\n   Material targets are only renamed if an existing Material maps to that    name, or if there is a diffuse texture in the model folder with the same    name as the new target.\n\n 
        /// </summary>
        [MemberGroup("Media")]
        public String skin
        {
            get { return Omni.self.GetVar(_ID + ".skin").AsString(); }
            set { Omni.self.SetVar(_ID + ".skin", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// ,NULL,NULL),   @brief Change one of the materials on the shape.   This method changes materials per mapTo with others. The material that    is being replaced is mapped to unmapped_mat as a part of this transition.   @note Warning, right now this only sort of works. It doesn't do a live    update like it should.   @param mapTo the name of the material target to remap (from getTargetName)   @param oldMat the old Material that was mapped    @param newMat the new Material to map   @tsexample      // remap the first material in the shape      %mapTo = %obj.getTargetName( 0 );      %obj.changeMaterial( %mapTo, 0, MyMaterial );   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void changeMaterial(string mapTo = "", string oldMat = null, string newMat = null)
        {
            if (oldMat == null)
                oldMat = null;
            if (newMat == null)
                newMat = null;

            m_ts.fnTSStatic_changeMaterial(_ID, mapTo, oldMat, newMat);
        }

        /// <summary>
        /// @brief Get the model filename used by this shape.   @return the shape filename   @tsexample		// Acquire the model filename used on this shape.		%modelFilename = %obj.getModelFile();   @endtsexample   )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getModelFile()
        {
            return m_ts.fnTSStatic_getModelFile(_ID);
        }

        /// <summary>
        /// Get the number of materials in the shape.   @return the number of materials in the shape.   @see getTargetName())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getTargetCount()
        {
            return m_ts.fnTSStatic_getTargetCount(_ID);
        }

        /// <summary>
        /// Get the name of the indexed shape material.   @param index index of the material to get (valid range is 0 - getTargetCount()-1).   @return the name of the indexed material.   @see getTargetCount())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getTargetName(int index = 0)
        {
            return m_ts.fnTSStatic_getTargetName(_ID, index);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public TSStatic_Base()
        {
        }
    }
}