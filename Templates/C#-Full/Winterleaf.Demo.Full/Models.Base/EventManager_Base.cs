


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
    [TypeConverter(typeof(TypeConverterGeneric<EventManager_Base>))]
    public partial class EventManager_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EventManager_Base ts, string simobjectid)
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
        public static bool operator !=(EventManager_Base ts, string simobjectid)
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
        public static implicit operator string( EventManager_Base ts)
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
        public static implicit operator EventManager_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (EventManager_Base) Omni.self.getSimObject(simobjectid,typeof(EventManager_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( EventManager_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EventManager_Base(int simobjectid)
            {
            return  (EventManager) Omni.self.getSimObject((uint)simobjectid,typeof(EventManager_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( EventManager_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EventManager_Base(uint simobjectid)
            {
            return  (EventManager_Base) Omni.self.getSimObject(simobjectid,typeof(EventManager_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// List of events currently waiting 
/// </summary>
[MemberGroup("")]
public String queue
       {
       get
          {
          return Omni.self.GetVar(_ID + ".queue").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".queue", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ()
///               Print all registered events to the console. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dumpEvents(){

pInvokes.m_ts.fn_EventManager_dumpEvents(_ID);
}
/// <summary>
/// ), ( String event )
///               Print all subscribers to an event to the console.
///               @param event The event whose subscribers are to be printed. If this parameter isn't specified, all events will be dumped. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dumpSubscribers(string listenerName = ""){

pInvokes.m_ts.fn_EventManager_dumpSubscribers(_ID, listenerName);
}
/// <summary>
/// ( String event )
///               Check if an event is registered or not.
///               @param event The event to check.
///               @return Whether or not the event exists. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isRegisteredEvent(string evt){

return pInvokes.m_ts.fn_EventManager_isRegisteredEvent(_ID, evt);
}
/// <summary>
/// ), ( String event, String data )
///               ~Trigger an event.
///               @param event The event to trigger.
///               @param data The data associated with the event.
///               @return Whether or not the event was dispatched successfully. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool postEvent(string evt, string data = ""){

return pInvokes.m_ts.fn_EventManager_postEvent(_ID, evt, data);
}
/// <summary>
/// ( String event )
///               Register an event with the event manager.
///               @param event The event to register.
///               @return Whether or not the event was registered successfully. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool registerEvent(string evt){

return pInvokes.m_ts.fn_EventManager_registerEvent(_ID, evt);
}
/// <summary>
/// ( SimObject listener, String event )
///               Remove a listener from an event.
///               @param listener The listener to remove.
///               @param event The event to be removed from.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void remove(string listenerName, string evt){

pInvokes.m_ts.fn_EventManager_remove(_ID, listenerName, evt);
}
/// <summary>
/// ( SimObject listener )
///               Remove a listener from all events.
///               @param listener The listener to remove.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeAll(string listenerName){

pInvokes.m_ts.fn_EventManager_removeAll(_ID, listenerName);
}
/// <summary>
/// ), ( SimObject listener, String event, String callback )
///               Subscribe a listener to an event.
///               @param listener The listener to subscribe.
///               @param event The event to subscribe to.
///               @param callback Optional method name to receive the event notification. If this is not specified, \"on[event]\" will be used.
///               @return Whether or not the subscription was successful. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool subscribe(string listenerName, string evt, string callback = ""){

return pInvokes.m_ts.fn_EventManager_subscribe(_ID, listenerName, evt, callback);
}
/// <summary>
/// ( String event )
///               Remove an event from the EventManager.
///               @param event The event to remove. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void unregisterEvent(string evt){

pInvokes.m_ts.fn_EventManager_unregisterEvent(_ID, evt);
}

#endregion
#region T3D Callbacks

#endregion
public EventManager_Base (){}
}}
