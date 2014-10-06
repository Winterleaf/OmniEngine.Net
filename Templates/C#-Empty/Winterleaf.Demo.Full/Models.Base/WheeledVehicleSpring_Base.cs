


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<WheeledVehicleSpring_Base>))]
    public partial class WheeledVehicleSpring_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WheeledVehicleSpring_Base ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(WheeledVehicleSpring_Base ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( WheeledVehicleSpring_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator WheeledVehicleSpring_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WheeledVehicleSpring_Base) Omni.self.getSimObject(simobjectid,typeof(WheeledVehicleSpring_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WheeledVehicleSpring_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WheeledVehicleSpring_Base(int simobjectid)
            {
            return  (WheeledVehicleSpring) Omni.self.getSimObject((uint)simobjectid,typeof(WheeledVehicleSpring_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WheeledVehicleSpring_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WheeledVehicleSpring_Base(uint simobjectid)
            {
            return  (WheeledVehicleSpring_Base) Omni.self.getSimObject(simobjectid,typeof(WheeledVehicleSpring_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Force applied to equalize extension of the spring on the opposite    wheel.\n\n   This force helps to keep the suspension balanced when opposite wheels    are at different heights. 
/// </summary>
[MemberGroup("")]
public float antiSwayForce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".antiSwayForce").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".antiSwayForce", value.AsString());
          }
       }
/// <summary>
/// @brief Force applied to slow changes to the extension of this spring.\n\n   Increasing this makes the suspension stiffer which can help stabilise    bouncy vehicles. 
/// </summary>
[MemberGroup("")]
public float damping
       {
       get
          {
          return Omni.self.GetVar(_ID + ".damping").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".damping", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum spring force (when compressed to minimum length, 0).\n\n   Increasing this will make the vehicle suspension ride higher (for a given    vehicle mass), and also make the vehicle more bouncy when landing jumps. 
/// </summary>
[MemberGroup("")]
public float force
       {
       get
          {
          return Omni.self.GetVar(_ID + ".force").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".force", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum spring length. ie. how far the wheel can extend from the    root hub position.\n\n   This should be set to the vertical (Z) distance the hub travels in the    associated spring animation. 
/// </summary>
[MemberGroup("")]
public float length
       {
       get
          {
          return Omni.self.GetVar(_ID + ".length").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".length", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public WheeledVehicleSpring_Base (){}
}}
