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
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<WheeledVehicleTire_Base>))]
    public partial class WheeledVehicleTire_Base : SimDataBlock
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WheeledVehicleTire_Base ts, string simobjectid)
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
        public static bool operator !=(WheeledVehicleTire_Base ts, string simobjectid)
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
        public static implicit operator string(WheeledVehicleTire_Base ts)
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
        public static implicit operator WheeledVehicleTire_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (WheeledVehicleTire_Base) Omni.self.getSimObject(simobjectid, typeof (WheeledVehicleTire_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(WheeledVehicleTire_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WheeledVehicleTire_Base(int simobjectid)
        {
            return (WheeledVehicleTire) Omni.self.getSimObject((uint) simobjectid, typeof (WheeledVehicleTire_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(WheeledVehicleTire_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WheeledVehicleTire_Base(uint simobjectid)
        {
            return (WheeledVehicleTire_Base) Omni.self.getSimObject(simobjectid, typeof (WheeledVehicleTire_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Tire friction when the wheel is slipping (no traction). 
        /// </summary>
        [MemberGroup("")]
        public float kineticFriction
        {
            get { return Omni.self.GetVar(_ID + ".kineticFriction").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".kineticFriction", value.AsString()); }
        }

        /// <summary>
        /// Damping force applied against lateral forces generated by the tire.\n\n   @see lateralForce 
        /// </summary>
        [MemberGroup("")]
        public float lateralDamping
        {
            get { return Omni.self.GetVar(_ID + ".lateralDamping").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lateralDamping", value.AsString()); }
        }

        /// <summary>
        /// @brief Tire force perpendicular to the direction of movement.\n\n   Lateral force can in simple terms be considered left/right steering    force. WheeledVehicles are acted upon by forces generated by their tires    and the lateralForce measures the magnitude of the force exerted on the    vehicle when the tires are deformed along the x-axis. With real wheeled    vehicles, tires are constantly being deformed and it is the interplay of    deformation forces which determines how a vehicle moves. In Torque's    simulation of vehicle physics, tire deformation obviously can't be handled    with absolute realism, but the interplay of a vehicle's velocity, its    engine's torque and braking forces, and its wheels' friction, lateral    deformation, lateralDamping, lateralRelaxation, longitudinal deformation,    longitudinalDamping, and longitudinalRelaxation forces, along with its    wheels' angular velocity are combined to create a robust real-time    physical simulation.\n\n   For this field, the larger the value supplied for the lateralForce, the    larger the effect steering maneuvers can have. In Torque tire forces are    applied at a vehicle's wheel hubs. 
        /// </summary>
        [MemberGroup("")]
        public float lateralForce
        {
            get { return Omni.self.GetVar(_ID + ".lateralForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lateralForce", value.AsString()); }
        }

        /// <summary>
        /// @brief Relaxing force applied against lateral forces generated by the tire.\n\n   The lateralRelaxation force measures how strongly the tire effectively    un-deforms.\n\n@see lateralForce 
        /// </summary>
        [MemberGroup("")]
        public float lateralRelaxation
        {
            get { return Omni.self.GetVar(_ID + ".lateralRelaxation").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lateralRelaxation", value.AsString()); }
        }

        /// <summary>
        /// Damping force applied against longitudinal forces generated by the tire.\n\n   @see longitudinalForce 
        /// </summary>
        [MemberGroup("")]
        public float longitudinalDamping
        {
            get { return Omni.self.GetVar(_ID + ".longitudinalDamping").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".longitudinalDamping", value.AsString()); }
        }

        /// <summary>
        /// @brief Tire force in the direction of movement.\n\n   Longitudinal force can in simple terms be considered forward/backward    movement force. WheeledVehicles are acted upon by forces generated by    their tires and the longitudinalForce measures the magnitude of the    force exerted on the vehicle when the tires are deformed along the y-axis.\n\n   For this field, the larger the value, the larger the effect    acceleration/deceleration inputs have.\n\n   @see lateralForce 
        /// </summary>
        [MemberGroup("")]
        public float longitudinalForce
        {
            get { return Omni.self.GetVar(_ID + ".longitudinalForce").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".longitudinalForce", value.AsString()); }
        }

        /// <summary>
        /// @brief Relaxing force applied against longitudinal forces generated by the tire.\n\n   The longitudinalRelaxation force measures how strongly the tire effectively    un-deforms.\n\n   @see longitudinalForce 
        /// </summary>
        [MemberGroup("")]
        public float longitudinalRelaxation
        {
            get { return Omni.self.GetVar(_ID + ".longitudinalRelaxation").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".longitudinalRelaxation", value.AsString()); }
        }

        /// <summary>
        /// The mass of the wheel.\nCurrently unused. 
        /// </summary>
        [MemberGroup("")]
        public float mass
        {
            get { return Omni.self.GetVar(_ID + ".mass").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".mass", value.AsString()); }
        }

        /// <summary>
        /// @brief The radius of the wheel.\n\n   The radius is determined from the bounding box of the shape provided    in the shapefile field, and does not need to be specified in script.    The tire should be built with its hub axis along the object's Y-axis. 
        /// </summary>
        [MemberGroup("")]
        public float radius
        {
            get { return Omni.self.GetVar(_ID + ".radius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".radius", value.AsString()); }
        }

        /// <summary>
        /// Tire restitution.\nCurrently unused. 
        /// </summary>
        [MemberGroup("")]
        public float restitution
        {
            get { return Omni.self.GetVar(_ID + ".restitution").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".restitution", value.AsString()); }
        }

        /// <summary>
        /// The path to the shape to use for the wheel. 
        /// </summary>
        [MemberGroup("")]
        public TypeShapeFilename shapeFile
        {
            get { return Omni.self.GetVar(_ID + ".shapeFile").AsTypeShapeFilename(); }
            set { Omni.self.SetVar(_ID + ".shapeFile", value.AsString()); }
        }

        /// <summary>
        /// Tire friction when the wheel is not slipping (has traction). 
        /// </summary>
        [MemberGroup("")]
        public float staticFriction
        {
            get { return Omni.self.GetVar(_ID + ".staticFriction").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".staticFriction", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public WheeledVehicleTire_Base()
        {
        }
    }
}