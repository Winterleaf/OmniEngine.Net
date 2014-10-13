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
    [TypeConverter(typeof (TypeConverterGeneric<PhysicsDebrisData_Base>))]
    public partial class PhysicsDebrisData_Base : GameBaseData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PhysicsDebrisData_Base ts, string simobjectid)
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
        public static bool operator !=(PhysicsDebrisData_Base ts, string simobjectid)
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
        public static implicit operator string(PhysicsDebrisData_Base ts)
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
        public static implicit operator PhysicsDebrisData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (PhysicsDebrisData_Base) Omni.self.getSimObject(simobjectid, typeof (PhysicsDebrisData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PhysicsDebrisData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PhysicsDebrisData_Base(int simobjectid)
        {
            return (PhysicsDebrisData) Omni.self.getSimObject((uint) simobjectid, typeof (PhysicsDebrisData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PhysicsDebrisData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PhysicsDebrisData_Base(uint simobjectid)
        {
            return (PhysicsDebrisData_Base) Omni.self.getSimObject(simobjectid, typeof (PhysicsDebrisData_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// @brief Value that reduces an object's rotational velocity over time.\n\n     Larger values will cause velocity to decay quicker.\n\n 
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float angularDamping
        {
            get { return Omni.self.GetVar(_ID + ".angularDamping").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".angularDamping", value.AsString()); }
        }

        /// <summary>
        /// @brief Minimum rotational velocity before the shape can be put to sleep.\n\n     This should be a positive value. Shapes put to sleep will not be simulated in order to save system resources.\n\n     @note The shape must be dynamic.
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float angularSleepThreshold
        {
            get { return Omni.self.GetVar(_ID + ".angularSleepThreshold").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".angularSleepThreshold", value.AsString()); }
        }

        /// <summary>
        /// @brief The density of this shape for purposes of calculating buoyant forces.\n\n     The result of the calculated buoyancy is relative to the density of the WaterObject the PhysicsDebris is within.     @see WaterObject::density
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float buoyancyDensity
        {
            get { return Omni.self.GetVar(_ID + ".buoyancyDensity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".buoyancyDensity", value.AsString()); }
        }

        /// <summary>
        /// @brief Determines if the shape's shadow should be cast onto the environment.\n\n 
        /// </summary>
        [MemberGroup("Display")]
        public bool castShadows
        {
            get { return Omni.self.GetVar(_ID + ".castShadows").AsBool(); }
            set { Omni.self.SetVar(_ID + ".castShadows", value.AsString()); }
        }

        /// <summary>
        /// @brief Coefficient of kinetic %friction to be applied to the shape.\n\n     Kinetic %friction reduces the velocity of a moving object while it is in contact with a surface.      A larger coefficient will result in a larger reduction in velocity.      A shape's friction should be smaller than it's staticFriction, but greater than 0.\n\n     @note This value is only applied while an object is in motion. For an object starting at rest, see PhysicsDebrisData::staticFriction
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float friction
        {
            get { return Omni.self.GetVar(_ID + ".friction").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".friction", value.AsString()); }
        }

        /// <summary>
        /// @brief Base time, in seconds, that debris persists after time of creation.\n\n     @note A %PhysicsDebris' lifetime multiplied by it's $pref::PhysicsDebris::lifetimeScale      must be equal to or greater than 1.0.\n\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float lifetime
        {
            get { return Omni.self.GetVar(_ID + ".lifetime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lifetime", value.AsString()); }
        }

        /// <summary>
        /// @brief Range of variation randomly applied to lifetime when debris is created.\n\n     Represents the maximum amount of seconds that will be added or subtracted to a shape's base lifetime.      A value of 0 will apply the same lifetime to each shape created.\n\n
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float lifetimeVariance
        {
            get { return Omni.self.GetVar(_ID + ".lifetimeVariance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lifetimeVariance", value.AsString()); }
        }

        /// <summary>
        /// @brief Value that reduces an object's linear velocity over time.\n\n     Larger values will cause velocity to decay quicker.\n\n 
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float linearDamping
        {
            get { return Omni.self.GetVar(_ID + ".linearDamping").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".linearDamping", value.AsString()); }
        }

        /// <summary>
        /// @brief Minimum linear velocity before the shape can be put to sleep.\n\n     This should be a positive value. Shapes put to sleep will not be simulated in order to save system resources.\n\n     @note The shape must be dynamic.
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float linearSleepThreshold
        {
            get { return Omni.self.GetVar(_ID + ".linearSleepThreshold").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".linearSleepThreshold", value.AsString()); }
        }

        /// <summary>
        /// @brief Value representing the mass of the shape.\n\n     A shape's mass influences the magnitude of any force applied to it.      @note All PhysicsDebris objects are dynamic.
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float mass
        {
            get { return Omni.self.GetVar(_ID + ".mass").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".mass", value.AsString()); }
        }

        /// <summary>
        /// @brief Bounce coeffecient applied to the shape in response to a collision.\n\n     Restitution is a ratio of a shape's velocity before and after a collision.      A value of 0 will zero out a shape's post-collision velocity, making it stop on contact.      Larger values will remove less velocity after a collision, making it \'bounce\' with greater force.      Normal %restitution values range between 0 and 1.0.     @note Values near or equaling 1.0 are likely to cause undesirable results in the physics simulation.      Because of this, it is reccomended to avoid values close to 1.0
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float restitution
        {
            get { return Omni.self.GetVar(_ID + ".restitution").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".restitution", value.AsString()); }
        }

        /// <summary>
        /// @brief Path to the .DAE or .DTS file to use for this shape.\n\n     Compatable with Live-Asset Reloading.
        /// </summary>
        [MemberGroup("Display")]
        public TypeShapeFilename shapeFile
        {
            get { return Omni.self.GetVar(_ID + ".shapeFile").AsTypeShapeFilename(); }
            set { Omni.self.SetVar(_ID + ".shapeFile", value.AsString()); }
        }

        /// <summary>
        /// @brief Coefficient of static %friction to be applied to the shape.\n\n     Static %friction determines the force needed to start moving an at-rest object in contact with a surface.      If the force applied onto shape cannot overcome the force of static %friction, the shape will remain at rest.      A higher coefficient will require a larger force to start motion.      This value should be both greater than 0 and the PhysicsDebrisData::friction.\n\n     @note This value is only applied while an object is at rest. For an object in motion, see PhysicsDebrisData::friction
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float staticFriction
        {
            get { return Omni.self.GetVar(_ID + ".staticFriction").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".staticFriction", value.AsString()); }
        }

        /// <summary>
        /// @brief Scale to apply to linear and angular dampening while underwater.\n\n      @see angularDamping linearDamping 
        /// </summary>
        [MemberGroup("Physical Properties")]
        public float waterDampingScale
        {
            get { return Omni.self.GetVar(_ID + ".waterDampingScale").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".waterDampingScale", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Loads some information to have readily available at simulation time.   Forces generation of shaders, materials, and other data used by the %PhysicsDebris object.    This function should be used while a level is loading in order to shorten    the amount of time to create a PhysicsDebris in game.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void preload()
        {
            m_ts.fn_PhysicsDebrisData_preload(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public PhysicsDebrisData_Base()
        {
        }
    }
}