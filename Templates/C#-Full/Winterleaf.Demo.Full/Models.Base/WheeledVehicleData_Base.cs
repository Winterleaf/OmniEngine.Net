


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
    [TypeConverter(typeof(TypeConverterGeneric<WheeledVehicleData_Base>))]
    public partial class WheeledVehicleData_Base: VehicleData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WheeledVehicleData_Base ts, string simobjectid)
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
        public static bool operator !=(WheeledVehicleData_Base ts, string simobjectid)
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
        public static implicit operator string( WheeledVehicleData_Base ts)
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
        public static implicit operator WheeledVehicleData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WheeledVehicleData_Base) Omni.self.getSimObject(simobjectid,typeof(WheeledVehicleData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WheeledVehicleData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WheeledVehicleData_Base(int simobjectid)
            {
            return  (WheeledVehicleData) Omni.self.getSimObject((uint)simobjectid,typeof(WheeledVehicleData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WheeledVehicleData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WheeledVehicleData_Base(uint simobjectid)
            {
            return  (WheeledVehicleData_Base) Omni.self.getSimObject(simobjectid,typeof(WheeledVehicleData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Torque applied when braking.\n\n   This controls how fast the vehicle will stop when the brakes are applied. 
/// </summary>
[MemberGroup("")]
public float brakeTorque
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brakeTorque").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brakeTorque", value.AsString());
          }
       }
/// <summary>
/// @brief Braking torque applied by the engine when the throttle and brake    are both 0.\n\n   This controls how quickly the vehicle will coast to a stop. 
/// </summary>
[MemberGroup("")]
public float engineBrake
       {
       get
          {
          return Omni.self.GetVar(_ID + ".engineBrake").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".engineBrake", value.AsString());
          }
       }
/// <summary>
/// @brief Looping engine sound.\n\n   The pitch is dynamically adjusted based on the current engine RPM 
/// </summary>
[MemberGroup("")]
public SFXTrack engineSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".engineSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".engineSound", value.ToString());
          }
       }
/// <summary>
/// @brief Torque available from the engine at 100% throttle.\n\n   This controls vehicle acceleration. ie. how fast it will reach maximum speed. 
/// </summary>
[MemberGroup("")]
public float engineTorque
       {
       get
          {
          return Omni.self.GetVar(_ID + ".engineTorque").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".engineTorque", value.AsString());
          }
       }
/// <summary>
/// Looping sound played when the vehicle is jetting. 
/// </summary>
[MemberGroup("")]
public SFXTrack jetSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".jetSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".jetSound", value.ToString());
          }
       }
/// <summary>
/// @brief Maximum linear velocity of each wheel.\n\n   This caps the maximum speed of the vehicle. 
/// </summary>
[MemberGroup("")]
public float maxWheelSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxWheelSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxWheelSpeed", value.AsString());
          }
       }
/// <summary>
/// @brief Looping sound played while any of the wheels is slipping.\n\n   The volume is dynamically adjusted based on how much the wheels are slipping. 
/// </summary>
[MemberGroup("")]
public SFXTrack squealSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".squealSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".squealSound", value.ToString());
          }
       }
/// <summary>
/// ParticleEmitterData datablock used to generate particles from each wheel    when the vehicle is moving and the wheel is in contact with the ground.
/// </summary>
[MemberGroup("")]
public ParticleEmitterData tireEmitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tireEmitter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".tireEmitter", value.ToString());
          }
       }
/// <summary>
/// Sound played when the wheels impact the ground.\nCurrently unused. 
/// </summary>
[MemberGroup("")]
public SFXTrack WheelImpactSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".WheelImpactSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".WheelImpactSound", value.ToString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public WheeledVehicleData_Base (){}
}}
