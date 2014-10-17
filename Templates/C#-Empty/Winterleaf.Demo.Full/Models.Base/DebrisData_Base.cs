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
    [TypeConverter(typeof (TypeConverterGeneric<DebrisData_Base>))]
    public partial class DebrisData_Base : GameBaseData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DebrisData_Base ts, string simobjectid)
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
        public static bool operator !=(DebrisData_Base ts, string simobjectid)
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
        public static implicit operator string(DebrisData_Base ts)
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
        public static implicit operator DebrisData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DebrisData_Base) Omni.self.getSimObject(simobjectid, typeof (DebrisData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DebrisData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DebrisData_Base(int simobjectid)
        {
            return (DebrisData) Omni.self.getSimObject((uint) simobjectid, typeof (DebrisData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DebrisData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DebrisData_Base(uint simobjectid)
        {
            return (DebrisData_Base) Omni.self.getSimObject(simobjectid, typeof (DebrisData_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("Datablocks")] public arrayObject<ParticleEmitterData> emitters;

        /// <summary>
        /// @brief Radius at which the standard elasticity and friction apply.\n\nOnly used when useRaduisMass is true.\n@see useRadiusMass.\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float baseRadius
        {
            get { return Omni.self.GetVar(_ID + ".baseRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".baseRadius", value.AsString()); }
        }

        /// <summary>
        /// @brief Allowed variance in the value of numBounces.\n\nMust be less than numBounces.\n@see numBounces\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public int bounceVariance
        {
            get { return Omni.self.GetVar(_ID + ".bounceVariance").AsInt(); }
            set { Omni.self.SetVar(_ID + ".bounceVariance", value.AsString()); }
        }

        /// <summary>
        /// @brief A floating-point value specifying how 'bouncy' this object is.\n\nMust be in the range of -10 to 10.\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float elasticity
        {
            get { return Omni.self.GetVar(_ID + ".elasticity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".elasticity", value.AsString()); }
        }

        /// <summary>
        /// @brief If true, this debris object will explode after it has bounced max times.\n\nBe sure to provide an ExplosionData datablock for this to take effect.\n@see explosion\n
        /// </summary>
        [MemberGroup("Behavior")]
        public bool explodeOnMaxBounce
        {
            get { return Omni.self.GetVar(_ID + ".explodeOnMaxBounce").AsBool(); }
            set { Omni.self.SetVar(_ID + ".explodeOnMaxBounce", value.AsString()); }
        }

        /// <summary>
        /// @brief ExplosionData to spawn along with this debris object.\n\nThis is optional as not all Debris explode.\n
        /// </summary>
        [MemberGroup("Datablocks")]
        public ExplosionData explosion
        {
            get { return Omni.self.GetVar(_ID + ".explosion"); }
            set { Omni.self.SetVar(_ID + ".explosion", value.ToString()); }
        }

        /// <summary>
        /// @brief If true, this debris object will fade out when destroyed.\n\nThis fade occurs over the last second of the Debris' lifetime.\n
        /// </summary>
        [MemberGroup("Behavior")]
        public bool fade
        {
            get { return Omni.self.GetVar(_ID + ".fade").AsBool(); }
            set { Omni.self.SetVar(_ID + ".fade", value.AsString()); }
        }

        /// <summary>
        /// @brief A floating-point value specifying how much velocity is lost to impact and sliding friction.\n\nMust be in the range of -10 to 10.\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float friction
        {
            get { return Omni.self.GetVar(_ID + ".friction").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".friction", value.AsString()); }
        }

        /// <summary>
        /// How much gravity affects debris.
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float gravModifier
        {
            get { return Omni.self.GetVar(_ID + ".gravModifier").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".gravModifier", value.AsString()); }
        }

        /// <summary>
        /// If true, this debris object will not collide with water, acting as if the water is not there.
        /// </summary>
        [MemberGroup("Behavior")]
        public bool ignoreWater
        {
            get { return Omni.self.GetVar(_ID + ".ignoreWater").AsBool(); }
            set { Omni.self.SetVar(_ID + ".ignoreWater", value.AsString()); }
        }

        /// <summary>
        /// @brief Amount of time until this debris object is destroyed.\n\nMust be in the range of 0 to 1000.\n@see lifetimeVariance
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float lifetime
        {
            get { return Omni.self.GetVar(_ID + ".lifetime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lifetime", value.AsString()); }
        }

        /// <summary>
        /// @brief Allowed variance in the value of lifetime.\n\nMust be less than lifetime.\n@see lifetime\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float lifetimeVariance
        {
            get { return Omni.self.GetVar(_ID + ".lifetimeVariance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lifetimeVariance", value.AsString()); }
        }

        /// <summary>
        /// @brief Maximum speed that this debris object will rotate.\n\nMust be in the range of -10000 to 10000.\n@see minSpinSpeed\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float maxSpinSpeed
        {
            get { return Omni.self.GetVar(_ID + ".maxSpinSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxSpinSpeed", value.AsString()); }
        }

        /// <summary>
        /// @brief Minimum speed that this debris object will rotate.\n\nMust be in the range of -10000 to 1000, and must be less than maxSpinSpeed.\n@see maxSpinSpeed\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float minSpinSpeed
        {
            get { return Omni.self.GetVar(_ID + ".minSpinSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".minSpinSpeed", value.AsString()); }
        }

        /// <summary>
        /// @brief How many times to allow this debris object to bounce until it either explodes, becomes static or snaps (defined in explodeOnMaxBounce, staticOnMaxBounce, snapOnMaxBounce).\n\n   Must be within the range of 0 to 10000.\n   @see bounceVariance\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public int numBounces
        {
            get { return Omni.self.GetVar(_ID + ".numBounces").AsInt(); }
            set { Omni.self.SetVar(_ID + ".numBounces", value.AsString()); }
        }

        /// <summary>
        /// @brief Object model to use for this debris object.\n\nThis shape is optional. You could have Debris made up of only particles.\n
        /// </summary>
        [MemberGroup("Display")]
        public TypeShapeFilename shapeFile
        {
            get { return Omni.self.GetVar(_ID + ".shapeFile").AsTypeShapeFilename(); }
            set { Omni.self.SetVar(_ID + ".shapeFile", value.AsString()); }
        }

        /// <summary>
        /// If true, this debris object will snap into a resting position on the last bounce.
        /// </summary>
        [MemberGroup("Behavior")]
        public bool snapOnMaxBounce
        {
            get { return Omni.self.GetVar(_ID + ".snapOnMaxBounce").AsBool(); }
            set { Omni.self.SetVar(_ID + ".snapOnMaxBounce", value.AsString()); }
        }

        /// <summary>
        /// If true, this debris object becomes static after it has bounced max times.
        /// </summary>
        [MemberGroup("Behavior")]
        public bool staticOnMaxBounce
        {
            get { return Omni.self.GetVar(_ID + ".staticOnMaxBounce").AsBool(); }
            set { Omni.self.SetVar(_ID + ".staticOnMaxBounce", value.AsString()); }
        }

        /// <summary>
        /// Max velocity magnitude.
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float terminalVelocity
        {
            get { return Omni.self.GetVar(_ID + ".terminalVelocity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".terminalVelocity", value.AsString()); }
        }

        /// <summary>
        /// @brief Texture imagemap to use for this debris object.\n\nNot used any more.\n
        /// </summary>
        [MemberGroup("Display")]
        public String texture
        {
            get { return Omni.self.GetVar(_ID + ".texture").AsString(); }
            set { Omni.self.SetVar(_ID + ".texture", value.AsString()); }
        }

        /// <summary>
        /// @brief Use mass calculations based on radius.\n\nAllows for the adjustment of elasticity and friction based on the Debris size.\n@see baseRadius\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public bool useRadiusMass
        {
            get { return Omni.self.GetVar(_ID + ".useRadiusMass").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useRadiusMass", value.AsString()); }
        }

        /// <summary>
        /// @brief Speed at which this debris object will move.\n\n@see velocityVariance\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float velocity
        {
            get { return Omni.self.GetVar(_ID + ".velocity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".velocity", value.AsString()); }
        }

        /// <summary>
        /// @brief Allowed variance in the value of velocity\n\nMust be less than velocity.\n@see velocity\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float velocityVariance
        {
            get { return Omni.self.GetVar(_ID + ".velocityVariance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".velocityVariance", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public DebrisData_Base()
        {
            emitters = new arrayObject<ParticleEmitterData>(2, "emitters", "T3DObject", false, this);
        }
    }
}