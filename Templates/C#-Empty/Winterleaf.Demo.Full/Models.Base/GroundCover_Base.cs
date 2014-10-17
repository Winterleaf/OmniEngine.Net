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
    [TypeConverter(typeof (TypeConverterGeneric<GroundCover_Base>))]
    public partial class GroundCover_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GroundCover_Base ts, string simobjectid)
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
        public static bool operator !=(GroundCover_Base ts, string simobjectid)
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
        public static implicit operator string(GroundCover_Base ts)
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
        public static implicit operator GroundCover_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GroundCover_Base) Omni.self.getSimObject(simobjectid, typeof (GroundCover_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GroundCover_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GroundCover_Base(int simobjectid)
        {
            return (GroundCover) Omni.self.getSimObject((uint) simobjectid, typeof (GroundCover_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GroundCover_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GroundCover_Base(uint simobjectid)
        {
            return (GroundCover_Base) Omni.self.getSimObject(simobjectid, typeof (GroundCover_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("GroundCover General")] public arrayObject<RectF> billboardUVs;
        [MemberGroup("GroundCover General")] public arrayObject<float> clumpExponent;
        [MemberGroup("GroundCover General")] public arrayObject<float> clumpRadius;

        [MemberGroup("GroundCover General")] public arrayObject<bool> invertLayer;
        [MemberGroup("GroundCover General")] public arrayObject<TypeTerrainMaterialName> layer;

        [MemberGroup("GroundCover General")] public arrayObject<int> maxClumpCount;

        [MemberGroup("GroundCover General")] public arrayObject<float> maxElevation;
        [MemberGroup("GroundCover General")] public arrayObject<float> maxSlope;
        [MemberGroup("GroundCover General")] public arrayObject<int> minClumpCount;
        [MemberGroup("GroundCover General")] public arrayObject<float> minElevation;
        [MemberGroup("GroundCover General")] public arrayObject<float> probability;
        [MemberGroup("GroundCover General")] public arrayObject<String> shapeFilename;
        [MemberGroup("GroundCover General")] public arrayObject<float> sizeExponent;
        [MemberGroup("GroundCover General")] public arrayObject<float> sizeMax;
        [MemberGroup("GroundCover General")] public arrayObject<float> sizeMin;
        [MemberGroup("GroundCover General")] public arrayObject<float> windScale;

        /// <summary>
        /// This is less than or equal to radius and defines when fading of cover elements begins. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public float dissolveRadius
        {
            get { return Omni.self.GetVar(_ID + ".dissolveRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".dissolveRadius", value.AsString()); }
        }

        /// <summary>
        /// The number of cells per axis in the grid. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public int gridSize
        {
            get { return Omni.self.GetVar(_ID + ".gridSize").AsInt(); }
            set { Omni.self.SetVar(_ID + ".gridSize", value.AsString()); }
        }

        /// <summary>
        /// Debug parameter for locking the culling frustum which will freeze the cover generation. 
        /// </summary>
        [MemberGroup("GroundCover Debug")]
        public bool lockFrustum
        {
            get { return Omni.self.GetVar(_ID + ".lockFrustum").AsBool(); }
            set { Omni.self.SetVar(_ID + ".lockFrustum", value.AsString()); }
        }

        /// <summary>
        /// Material used by all GroundCover segments. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public TypeMaterialName material
        {
            get { return Omni.self.GetVar(_ID + ".material").AsTypeMaterialName(); }
            set { Omni.self.SetVar(_ID + ".material", value.AsString()); }
        }

        /// <summary>
        /// The maximum amout of degrees the billboard will tilt down to match the camera. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public float maxBillboardTiltAngle
        {
            get { return Omni.self.GetVar(_ID + ".maxBillboardTiltAngle").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxBillboardTiltAngle", value.AsString()); }
        }

        /// <summary>
        /// The maximum amount of cover elements to include in the grid at any one time. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public int maxElements
        {
            get { return Omni.self.GetVar(_ID + ".maxElements").AsInt(); }
            set { Omni.self.SetVar(_ID + ".maxElements", value.AsString()); }
        }

        /// <summary>
        /// Debug parameter for turning off billboard rendering. 
        /// </summary>
        [MemberGroup("GroundCover Debug")]
        public bool noBillboards
        {
            get { return Omni.self.GetVar(_ID + ".noBillboards").AsBool(); }
            set { Omni.self.SetVar(_ID + ".noBillboards", value.AsString()); }
        }

        /// <summary>
        /// Debug parameter for turning off shape rendering. 
        /// </summary>
        [MemberGroup("GroundCover Debug")]
        public bool noShapes
        {
            get { return Omni.self.GetVar(_ID + ".noShapes").AsBool(); }
            set { Omni.self.SetVar(_ID + ".noShapes", value.AsString()); }
        }

        /// <summary>
        /// Outer generation radius from the current camera position. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public float radius
        {
            get { return Omni.self.GetVar(_ID + ".radius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".radius", value.AsString()); }
        }

        /// <summary>
        /// Scales the various culling radii when rendering a reflection. Typically for water. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public float reflectScale
        {
            get { return Omni.self.GetVar(_ID + ".reflectScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reflectScale", value.AsString()); }
        }

        /// <summary>
        /// Debug parameter for displaying the grid cells. 
        /// </summary>
        [MemberGroup("GroundCover Debug")]
        public bool renderCells
        {
            get { return Omni.self.GetVar(_ID + ".renderCells").AsBool(); }
            set { Omni.self.SetVar(_ID + ".renderCells", value.AsString()); }
        }

        /// <summary>
        /// This RNG seed is saved and sent to clients for generating the same cover. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public int seed
        {
            get { return Omni.self.GetVar(_ID + ".seed").AsInt(); }
            set { Omni.self.SetVar(_ID + ".seed", value.AsString()); }
        }

        /// <summary>
        /// This is the distance at which DTS elements are completely culled out. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public float shapeCullRadius
        {
            get { return Omni.self.GetVar(_ID + ".shapeCullRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".shapeCullRadius", value.AsString()); }
        }

        /// <summary>
        /// Whether DTS elements should cast shadows or not. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public bool shapesCastShadows
        {
            get { return Omni.self.GetVar(_ID + ".shapesCastShadows").AsBool(); }
            set { Omni.self.SetVar(_ID + ".shapesCastShadows", value.AsString()); }
        }

        /// <summary>
        /// The direction of the wind. 
        /// </summary>
        [MemberGroup("GroundCover Wind")]
        public Point2F windDirection
        {
            get { return Omni.self.GetVar(_ID + ".windDirection").AsPoint2F(); }
            set { Omni.self.SetVar(_ID + ".windDirection", value.AsString()); }
        }

        /// <summary>
        /// Controls how often the wind gust peaks per second. 
        /// </summary>
        [MemberGroup("GroundCover Wind")]
        public float windGustFrequency
        {
            get { return Omni.self.GetVar(_ID + ".windGustFrequency").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".windGustFrequency", value.AsString()); }
        }

        /// <summary>
        /// The length in meters between peaks in the wind gust. 
        /// </summary>
        [MemberGroup("GroundCover Wind")]
        public float windGustLength
        {
            get { return Omni.self.GetVar(_ID + ".windGustLength").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".windGustLength", value.AsString()); }
        }

        /// <summary>
        /// The maximum distance in meters that the peak wind gust will displace an element. 
        /// </summary>
        [MemberGroup("GroundCover Wind")]
        public float windGustStrength
        {
            get { return Omni.self.GetVar(_ID + ".windGustStrength").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".windGustStrength", value.AsString()); }
        }

        /// <summary>
        /// Controls the overall rapidity of the wind turbulence. 
        /// </summary>
        [MemberGroup("GroundCover Wind")]
        public float windTurbulenceFrequency
        {
            get { return Omni.self.GetVar(_ID + ".windTurbulenceFrequency").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".windTurbulenceFrequency", value.AsString()); }
        }

        /// <summary>
        /// The maximum distance in meters that the turbulence can displace a ground cover element. 
        /// </summary>
        [MemberGroup("GroundCover Wind")]
        public float windTurbulenceStrength
        {
            get { return Omni.self.GetVar(_ID + ".windTurbulenceStrength").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".windTurbulenceStrength", value.AsString()); }
        }

        /// <summary>
        /// Offset along the Z axis to render the ground cover. 
        /// </summary>
        [MemberGroup("GroundCover General")]
        public float zOffset
        {
            get { return Omni.self.GetVar(_ID + ".zOffset").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".zOffset", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public GroundCover_Base()
        {
            billboardUVs = new arrayObject<RectF>(8, "billboardUVs", "TypeVariable", false, this);
            clumpExponent = new arrayObject<float>(8, "clumpExponent", "TypeVariable", false, this);
            clumpRadius = new arrayObject<float>(8, "clumpRadius", "TypeVariable", false, this);
            invertLayer = new arrayObject<bool>(8, "invertLayer", "TypeVariable", false, this);
            layer = new arrayObject<TypeTerrainMaterialName>(8, "layer", "TypeVariable", false, this);
            maxClumpCount = new arrayObject<int>(8, "maxClumpCount", "TypeVariable", false, this);
            maxElevation = new arrayObject<float>(8, "maxElevation", "TypeVariable", false, this);
            maxSlope = new arrayObject<float>(8, "maxSlope", "TypeVariable", false, this);
            minClumpCount = new arrayObject<int>(8, "minClumpCount", "TypeVariable", false, this);
            minElevation = new arrayObject<float>(8, "minElevation", "TypeVariable", false, this);
            probability = new arrayObject<float>(8, "probability", "TypeVariable", false, this);
            shapeFilename = new arrayObject<String>(8, "shapeFilename", "TypeVariable", false, this);
            sizeExponent = new arrayObject<float>(8, "sizeExponent", "TypeVariable", false, this);
            sizeMax = new arrayObject<float>(8, "sizeMax", "TypeVariable", false, this);
            sizeMin = new arrayObject<float>(8, "sizeMin", "TypeVariable", false, this);
            windScale = new arrayObject<float>(8, "windScale", "TypeVariable", false, this);
        }
    }
}