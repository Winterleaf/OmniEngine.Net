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
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment�s prior written consent; or
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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<FlyingVehicleData_Base>))]
    public partial class FlyingVehicleData_Base : VehicleData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FlyingVehicleData_Base ts, string simobjectid)
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
        public static bool operator !=(FlyingVehicleData_Base ts, string simobjectid)
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
        public static implicit operator string(FlyingVehicleData_Base ts)
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
        public static implicit operator FlyingVehicleData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (FlyingVehicleData_Base) Omni.self.getSimObject(simobjectid, typeof (FlyingVehicleData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(FlyingVehicleData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FlyingVehicleData_Base(int simobjectid)
        {
            return (FlyingVehicleData) Omni.self.getSimObject((uint) simobjectid, typeof (FlyingVehicleData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(FlyingVehicleData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FlyingVehicleData_Base(uint simobjectid)
        {
            return (FlyingVehicleData_Base) Omni.self.getSimObject(simobjectid, typeof (FlyingVehicleData_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// @brief Corrective torque applied to level out the vehicle when moving at less    than maxAutoSpeed.\n\n   The torque is inversely proportional to vehicle speed. 
        /// </summary>
        [MemberGroup("")]
        public float autoAngularForce
        {
            get { return Omni.self.GetVar(_ID + ".autoAngularForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".autoAngularForce", value.AsString()); }
        }

        /// <summary>
        /// @brief Scale factor applied to steering input if speed is less than    maxAutoSpeed to.improve handling at very low speeds.\n\n   Smaller values make steering less sensitive. 
        /// </summary>
        [MemberGroup("")]
        public float autoInputDamping
        {
            get { return Omni.self.GetVar(_ID + ".autoInputDamping").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".autoInputDamping", value.AsString()); }
        }

        /// <summary>
        /// @brief Corrective force applied to slow the vehicle when moving at less than    maxAutoSpeed.\n\n   The force is inversely proportional to vehicle speed. 
        /// </summary>
        [MemberGroup("")]
        public float autoLinearForce
        {
            get { return Omni.self.GetVar(_ID + ".autoLinearForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".autoLinearForce", value.AsString()); }
        }

        /// <summary>
        /// @brief Emitter to generate particles for backward jet thrust.\n\n   Backward jet thrust particles are emitted from model nodes JetNozzleX    and JetNozzleY. 
        /// </summary>
        [MemberGroup("")]
        public ParticleEmitterData backwardJetEmitter
        {
            get { return Omni.self.GetVar(_ID + ".backwardJetEmitter"); }
            set { Omni.self.SetVar(_ID + ".backwardJetEmitter", value.ToString()); }
        }

        /// <summary>
        /// @brief The vehicle's height off the ground when useCreateHeight is active.\n\n   This can help avoid problems with spawning the vehicle. 
        /// </summary>
        [MemberGroup("")]
        public float createHoverHeight
        {
            get { return Omni.self.GetVar(_ID + ".createHoverHeight").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".createHoverHeight", value.AsString()); }
        }

        /// <summary>
        /// @brief Emitter to generate particles for downward jet thrust.\n\n   Downward jet thrust particles are emitted from model nodes JetNozzle2    and JetNozzle3. 
        /// </summary>
        [MemberGroup("")]
        public ParticleEmitterData downJetEmitter
        {
            get { return Omni.self.GetVar(_ID + ".downJetEmitter"); }
            set { Omni.self.SetVar(_ID + ".downJetEmitter", value.ToString()); }
        }

        /// <summary>
        /// Looping engine sound. 
        /// </summary>
        [MemberGroup("")]
        public SFXProfile engineSound
        {
            get { return Omni.self.GetVar(_ID + ".engineSound"); }
            set { Omni.self.SetVar(_ID + ".engineSound", value.ToString()); }
        }

        /// <summary>
        /// @brief Emitter to generate particles for forward jet thrust.\n\n   Forward jet thrust particles are emitted from model nodes JetNozzle0    and JetNozzle1. 
        /// </summary>
        [MemberGroup("")]
        public ParticleEmitterData forwardJetEmitter
        {
            get { return Omni.self.GetVar(_ID + ".forwardJetEmitter"); }
            set { Omni.self.SetVar(_ID + ".forwardJetEmitter", value.ToString()); }
        }

        /// <summary>
        /// @brief Damping force in the opposite direction to sideways velocity.\n\n   Provides \bite\ into the wind for climbing/diving and turning). 
        /// </summary>
        [MemberGroup("")]
        public float horizontalSurfaceForce
        {
            get { return Omni.self.GetVar(_ID + ".horizontalSurfaceForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".horizontalSurfaceForce", value.AsString()); }
        }

        /// <summary>
        /// The vehicle's height off the ground when at rest. 
        /// </summary>
        [MemberGroup("")]
        public float hoverHeight
        {
            get { return Omni.self.GetVar(_ID + ".hoverHeight").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".hoverHeight", value.AsString()); }
        }

        /// <summary>
        /// Looping sound to play while the vehicle is jetting. 
        /// </summary>
        [MemberGroup("")]
        public SFXProfile jetSound
        {
            get { return Omni.self.GetVar(_ID + ".jetSound"); }
            set { Omni.self.SetVar(_ID + ".jetSound", value.ToString()); }
        }

        /// <summary>
        /// @brief Maximum X and Y (horizontal plane) maneuvering force.\n\n   The actual force applied depends on the current thrust. 
        /// </summary>
        [MemberGroup("")]
        public float maneuveringForce
        {
            get { return Omni.self.GetVar(_ID + ".maneuveringForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maneuveringForce", value.AsString()); }
        }

        /// <summary>
        /// Maximum speed for automatic vehicle control assistance - vehicles    travelling at speeds above this value do not get control assitance. 
        /// </summary>
        [MemberGroup("")]
        public float maxAutoSpeed
        {
            get { return Omni.self.GetVar(_ID + ".maxAutoSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxAutoSpeed", value.AsString()); }
        }

        /// <summary>
        /// Minimum speed at which to start generating contrail particles. 
        /// </summary>
        [MemberGroup("")]
        public float minTrailSpeed
        {
            get { return Omni.self.GetVar(_ID + ".minTrailSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".minTrailSpeed", value.AsString()); }
        }

        /// <summary>
        /// @brief Damping torque against rolling maneuvers (rotation about the y-axis),    proportional to linear velocity.\n\n   Acts to adjust roll to a stable position over time as the vehicle moves. 
        /// </summary>
        [MemberGroup("")]
        public float rollForce
        {
            get { return Omni.self.GetVar(_ID + ".rollForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".rollForce", value.AsString()); }
        }

        /// <summary>
        /// Rotational drag factor (slows vehicle rotation speed in all axes). 
        /// </summary>
        [MemberGroup("")]
        public float rotationalDrag
        {
            get { return Omni.self.GetVar(_ID + ".rotationalDrag").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".rotationalDrag", value.AsString()); }
        }

        /// <summary>
        /// @brief Maximum X and Z (sideways and vertical) steering force.\n\n   The actual force applied depends on the current steering input. 
        /// </summary>
        [MemberGroup("")]
        public float steeringForce
        {
            get { return Omni.self.GetVar(_ID + ".steeringForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".steeringForce", value.AsString()); }
        }

        /// <summary>
        /// Roll force induced by sideways steering input value (controls how much    the vehicle rolls when turning). 
        /// </summary>
        [MemberGroup("")]
        public float steeringRollForce
        {
            get { return Omni.self.GetVar(_ID + ".steeringRollForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".steeringRollForce", value.AsString()); }
        }

        /// <summary>
        /// Emitter to generate contrail particles from model nodes contrail0 - contrail3. 
        /// </summary>
        [MemberGroup("")]
        public ParticleEmitterData trailEmitter
        {
            get { return Omni.self.GetVar(_ID + ".trailEmitter"); }
            set { Omni.self.SetVar(_ID + ".trailEmitter", value.ToString()); }
        }

        /// <summary>
        /// @brief Damping force in the opposite direction to vertical velocity.\n\n   Controls side slip; lower numbers give more slide. 
        /// </summary>
        [MemberGroup("")]
        public float verticalSurfaceForce
        {
            get { return Omni.self.GetVar(_ID + ".verticalSurfaceForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".verticalSurfaceForce", value.AsString()); }
        }

        /// <summary>
        /// Multiplier applied to the jetForce (defined in VehicleData) when thrusting vertically. 
        /// </summary>
        [MemberGroup("")]
        public float vertThrustMultiple
        {
            get { return Omni.self.GetVar(_ID + ".vertThrustMultiple").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".vertThrustMultiple", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public FlyingVehicleData_Base()
        {
        }
    }
}