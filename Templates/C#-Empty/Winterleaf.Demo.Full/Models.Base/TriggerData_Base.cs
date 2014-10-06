


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
    [TypeConverter(typeof(TypeConverterGeneric<TriggerData_Base>))]
    public partial class TriggerData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TriggerData_Base ts, string simobjectid)
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
        public static bool operator !=(TriggerData_Base ts, string simobjectid)
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
        public static implicit operator string( TriggerData_Base ts)
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
        public static implicit operator TriggerData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TriggerData_Base) Omni.self.getSimObject(simobjectid,typeof(TriggerData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TriggerData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TriggerData_Base(int simobjectid)
            {
            return  (TriggerData) Omni.self.getSimObject((uint)simobjectid,typeof(TriggerData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TriggerData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TriggerData_Base(uint simobjectid)
            {
            return  (TriggerData_Base) Omni.self.getSimObject(simobjectid,typeof(TriggerData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Forces Trigger callbacks to only be called on clients.
/// </summary>
[MemberGroup("Callbacks")]
public bool clientSide
       {
       get
          {
          return Omni.self.GetVar(_ID + ".clientSide").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".clientSide", value.AsString());
          }
       }
/// <summary>
/// @brief Time in milliseconds between calls to onTickTrigger() while at least one object is within a Trigger's bounds.\n\n     @see onTickTrigger()\n
/// </summary>
[MemberGroup("Callbacks")]
public int tickPeriodMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tickPeriodMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tickPeriodMS", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when an object enters the volume of the Trigger instance using this TriggerData.   @param trigger the Trigger instance whose volume the object entered   @param obj the object that entered the volume of the Trigger instance )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterTrigger(Trigger trigger, GameBase obj){}

        /// <summary>
        /// @brief Called every tickPeriodMS number of milliseconds (as specified in the TriggerData) whenever    one or more objects are inside the volume of the trigger.   The Trigger has methods to retrieve the objects that are within the Trigger's bounds if you    want to do something with them in this callback.   @param trigger the Trigger instance whose volume the object is inside      @see tickPeriodMS   @see Trigger::getNumObjects()   @see Trigger::getObject())
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTickTrigger(Trigger trigger){}

        /// <summary>
        /// @brief Called when an object leaves the volume of the Trigger instance using this TriggerData.   @param trigger the Trigger instance whose volume the object left   @param obj the object that left the volume of the Trigger instance )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveTrigger(Trigger trigger, GameBase obj){}

#endregion
public TriggerData_Base (){}
}}
