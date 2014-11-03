


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
    [TypeConverter(typeof(TypeConverterGeneric<AITurretShapeData_Base>))]
    public partial class AITurretShapeData_Base: TurretShapeData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AITurretShapeData_Base ts, string simobjectid)
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
        public static bool operator !=(AITurretShapeData_Base ts, string simobjectid)
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
        public static implicit operator string( AITurretShapeData_Base ts)
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
        public static implicit operator AITurretShapeData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (AITurretShapeData_Base) Omni.self.getSimObject(simobjectid,typeof(AITurretShapeData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( AITurretShapeData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AITurretShapeData_Base(int simobjectid)
            {
            return  (AITurretShapeData) Omni.self.getSimObject((uint)simobjectid,typeof(AITurretShapeData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( AITurretShapeData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AITurretShapeData_Base(uint simobjectid)
            {
            return  (AITurretShapeData_Base) Omni.self.getSimObject(simobjectid,typeof(AITurretShapeData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Maximum distance to scan.\n\n   When combined with maxScanHeading and maxScanPitch this forms a 3D scanning wedge used to initially    locate a target.\n
/// </summary>
[MemberGroup("")]
public float maxScanDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxScanDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxScanDistance", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum number of degrees to scan left and right.\n\n   @note Maximum scan heading is 90 degrees.\n
/// </summary>
[MemberGroup("")]
public float maxScanHeading
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxScanHeading").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxScanHeading", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum number of degrees to scan up and down.\n\n   @note Maximum scan pitch is 90 degrees.\n
/// </summary>
[MemberGroup("")]
public float maxScanPitch
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxScanPitch").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxScanPitch", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum distance that the weapon will fire upon a target.\n\n
/// </summary>
[MemberGroup("")]
public float maxWeaponRange
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxWeaponRange").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxWeaponRange", value.AsString());
          }
       }
/// <summary>
/// @brief How often should we perform a full scan when looking for a target.\n\n   Expressed as the number of ticks between full scans, but no less than 1.\n
/// </summary>
[MemberGroup("")]
public int scanTickFrequency
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scanTickFrequency").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scanTickFrequency", value.AsString());
          }
       }
/// <summary>
/// @brief Random amount that should be added to the scan tick frequency each scan period.\n\n   Expressed as the number of ticks to randomly add, but no less than zero.\n
/// </summary>
[MemberGroup("")]
public int scanTickFrequencyVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scanTickFrequencyVariance").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scanTickFrequencyVariance", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<bool> stateDirection;
[MemberGroup("")]
public arrayObject<bool> stateFire;
[MemberGroup("")]
public arrayObject<String> stateName;
[MemberGroup("")]
public arrayObject<bool> stateScaleAnimation;
[MemberGroup("")]
public arrayObject<bool> stateScan;
[MemberGroup("")]
public arrayObject<String> stateScript;
[MemberGroup("")]
public arrayObject<String> stateSequence;
[MemberGroup("")]
public arrayObject<float> stateTimeoutValue;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnActivated;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnAtRest;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnDeactivated;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnNoTarget;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnNotAtRest;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnTarget;
[MemberGroup("")]
public arrayObject<String> stateTransitionOnTimeout;
[MemberGroup("")]
public arrayObject<bool> stateWaitForTimeout;
/// <summary>
/// @brief How long after the turret has lost the target should it still track it.\n\n   Expressed in seconds.\n
/// </summary>
[MemberGroup("")]
public float trackLostTargetTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".trackLostTargetTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".trackLostTargetTime", value.AsString());
          }
       }
/// <summary>
/// @brief Velocity used to lead target.\n\n   If value = 0, don't lead target.\n
/// </summary>
[MemberGroup("")]
public float weaponLeadVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".weaponLeadVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".weaponLeadVelocity", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public AITurretShapeData_Base (){stateDirection = new arrayObject<bool>(31,"stateDirection","TypeVariable",false,this);    
stateFire = new arrayObject<bool>(31,"stateFire","TypeVariable",false,this);    
stateName = new arrayObject<String>(31,"stateName","TypeVariable",false,this);    
stateScaleAnimation = new arrayObject<bool>(31,"stateScaleAnimation","TypeVariable",false,this);    
stateScan = new arrayObject<bool>(31,"stateScan","TypeVariable",false,this);    
stateScript = new arrayObject<String>(31,"stateScript","TypeVariable",false,this);    
stateSequence = new arrayObject<String>(31,"stateSequence","TypeVariable",false,this);    
stateTimeoutValue = new arrayObject<float>(31,"stateTimeoutValue","TypeVariable",false,this);    
stateTransitionOnActivated = new arrayObject<String>(31,"stateTransitionOnActivated","TypeVariable",false,this);    
stateTransitionOnAtRest = new arrayObject<String>(31,"stateTransitionOnAtRest","TypeVariable",false,this);    
stateTransitionOnDeactivated = new arrayObject<String>(31,"stateTransitionOnDeactivated","TypeVariable",false,this);    
stateTransitionOnNoTarget = new arrayObject<String>(31,"stateTransitionOnNoTarget","TypeVariable",false,this);    
stateTransitionOnNotAtRest = new arrayObject<String>(31,"stateTransitionOnNotAtRest","TypeVariable",false,this);    
stateTransitionOnTarget = new arrayObject<String>(31,"stateTransitionOnTarget","TypeVariable",false,this);    
stateTransitionOnTimeout = new arrayObject<String>(31,"stateTransitionOnTimeout","TypeVariable",false,this);    
stateWaitForTimeout = new arrayObject<bool>(31,"stateWaitForTimeout","TypeVariable",false,this);    
}
}}
