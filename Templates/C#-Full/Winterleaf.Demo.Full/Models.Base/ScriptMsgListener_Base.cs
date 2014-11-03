


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
    [TypeConverter(typeof(TypeConverterGeneric<ScriptMsgListener_Base>))]
    public partial class ScriptMsgListener_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ScriptMsgListener_Base ts, string simobjectid)
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
        public static bool operator !=(ScriptMsgListener_Base ts, string simobjectid)
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
        public static implicit operator string( ScriptMsgListener_Base ts)
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
        public static implicit operator ScriptMsgListener_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ScriptMsgListener_Base) Omni.self.getSimObject(simobjectid,typeof(ScriptMsgListener_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ScriptMsgListener_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ScriptMsgListener_Base(int simobjectid)
            {
            return  (ScriptMsgListener) Omni.self.getSimObject((uint)simobjectid,typeof(ScriptMsgListener_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ScriptMsgListener_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ScriptMsgListener_Base(uint simobjectid)
            {
            return  (ScriptMsgListener_Base) Omni.self.getSimObject(simobjectid,typeof(ScriptMsgListener_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// Script callback when a listener is first created and registered.				   @tsexample				   function ScriptMsgListener::onAdd(%this)				   {				   	// Perform on add code here				   }				   @endtsexample				   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

        /// <summary>
        /// Script callback when a listener is deleted.				   @tsexample				   function ScriptMsgListener::onRemove(%this)				   {				   	// Perform on remove code here				   }				   @endtsexample				   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemove(){}

        /// <summary>
        /// Called when the listener has received a message.   @param queue The name of the queue the message was dispatched to   @param event The name of the event (function) that was triggered   @param data The data (parameters) for the message   @return false to prevent other listeners receiving this message, true otherwise )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool onMessageReceived(string queue, string eventx, string data){return "0".AsBool();}

        /// <summary>
        /// Called when a message object (not just the message data) is passed to a listener.   @param queue The name of the queue the message was dispatched to   @param msg The message object   @return false to prevent other listeners receiving this message, true otherwise    @see Message   @see onMessageReceived)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  bool onMessageObjectReceived(string queue, Message msg){return "0".AsBool();}

        /// <summary>
        /// @brief Callback for when the listener is added to a queue	The default implementation of onAddToQueue() and onRemoveFromQueue() 	provide tracking of the queues this listener is added to through the 	mQueues member. Overrides of onAddToQueue() or onRemoveFromQueue() 	should ensure they call the parent implementation in any overrides.	@param queue The name of the queue that the listener added to   	@see onRemoveFromQueue())
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddToQueue(string queue){}

        /// <summary>
        /// @brief Callback for when the listener is removed from a queue	The default implementation of onAddToQueue() and onRemoveFromQueue() 	provide tracking of the queues this listener is added to through the 	mQueues member. Overrides of onAddToQueue() or onRemoveFromQueue() 	should ensure they call the parent implementation in any overrides.	@param queue The name of the queue that the listener was removed from   	@see onAddToQueue())
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemoveFromQueue(string queue){}

#endregion
public ScriptMsgListener_Base (){}
}}
