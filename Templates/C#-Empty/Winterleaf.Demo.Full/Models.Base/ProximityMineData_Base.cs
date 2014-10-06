


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
    [TypeConverter(typeof(TypeConverterGeneric<ProximityMineData_Base>))]
    public partial class ProximityMineData_Base: ItemData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ProximityMineData_Base ts, string simobjectid)
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
        public static bool operator !=(ProximityMineData_Base ts, string simobjectid)
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
        public static implicit operator string( ProximityMineData_Base ts)
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
        public static implicit operator ProximityMineData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ProximityMineData_Base) Omni.self.getSimObject(simobjectid,typeof(ProximityMineData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ProximityMineData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ProximityMineData_Base(int simobjectid)
            {
            return  (ProximityMineData) Omni.self.getSimObject((uint)simobjectid,typeof(ProximityMineData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ProximityMineData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ProximityMineData_Base(uint simobjectid)
            {
            return  (ProximityMineData_Base) Omni.self.getSimObject(simobjectid,typeof(ProximityMineData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Delay (in seconds) from when the mine is placed to when it becomes active. 
/// </summary>
[MemberGroup("Arming")]
public float armingDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".armingDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".armingDelay", value.AsString());
          }
       }
/// <summary>
/// Sound to play when the mine is armed (starts at the same time as    the iarmed/i sequence if defined). 
/// </summary>
[MemberGroup("Arming")]
public TypeSFXTrackName armingSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".armingSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".armingSound", value.AsString());
          }
       }
/// <summary>
/// @brief Delay (in seconds) from arming until the mine automatically    triggers and explodes, even if no object has entered the trigger area.\n\n   Set to 0 to disable. 
/// </summary>
[MemberGroup("Triggering")]
public float autoTriggerDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoTriggerDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoTriggerDelay", value.AsString());
          }
       }
/// <summary>
/// @brief Offset from the mine's origin where the explosion emanates from.   Sometimes a thrown mine may be slightly sunk into the ground. This can be just    enough to cause the explosion to occur under the ground, especially on flat    ground, which can end up blocking the explosion. This offset along the mine's    'up' normal allows you to raise the explosion origin to a better height.
/// </summary>
[MemberGroup("Explosion")]
public float explosionOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".explosionOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".explosionOffset", value.AsString());
          }
       }
/// <summary>
/// Delay (in seconds) from when the mine is triggered until it explodes. 
/// </summary>
[MemberGroup("Triggering")]
public float triggerDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".triggerDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".triggerDelay", value.AsString());
          }
       }
/// <summary>
/// @brief Controls whether the mine can be triggered by the object that owns it.\n\n   For example, a player could deploy mines that are only dangerous to other    players and not himself. 
/// </summary>
[MemberGroup("Triggering")]
public bool triggerOnOwner
       {
       get
          {
          return Omni.self.GetVar(_ID + ".triggerOnOwner").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".triggerOnOwner", value.AsString());
          }
       }
/// <summary>
/// Distance at which an activated mine will detect other objects and explode. 
/// </summary>
[MemberGroup("Triggering")]
public float triggerRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".triggerRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".triggerRadius", value.AsString());
          }
       }
/// <summary>
/// Sound to play when the mine is triggered (starts at the same time as    the itriggered/i sequence if defined). 
/// </summary>
[MemberGroup("Triggering")]
public TypeSFXTrackName triggerSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".triggerSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".triggerSound", value.AsString());
          }
       }
/// <summary>
/// Speed above which moving objects within the trigger radius will trigger the mine 
/// </summary>
[MemberGroup("Triggering")]
public float triggerSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".triggerSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".triggerSpeed", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// Callback invoked when an object triggers the ProximityMine.   @param obj The ProximityMine object   @param target The object that triggered the mine   @note This callback is only invoked on the server.   @see ProximityMine)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTriggered(ProximityMine obj, SceneObject target){}

        /// <summary>
        /// Callback invoked when a ProximityMine is about to explode.   @param obj The ProximityMine object   @param pos The position of the mine explosion   @note This callback is only invoked on the server.   @see ProximityMine)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onExplode(ProximityMine obj, Point3F pos){}

#endregion
public ProximityMineData_Base (){}
}}
