


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
    [TypeConverter(typeof(TypeConverterGeneric<Message_Base>))]
    public partial class Message_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Message_Base ts, string simobjectid)
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
        public static bool operator !=(Message_Base ts, string simobjectid)
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
        public static implicit operator string( Message_Base ts)
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
        public static implicit operator Message_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Message_Base) Omni.self.getSimObject(simobjectid,typeof(Message_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Message_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Message_Base(int simobjectid)
            {
            return  (Message) Omni.self.getSimObject((uint)simobjectid,typeof(Message_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Message_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Message_Base(uint simobjectid)
            {
            return  (Message_Base) Omni.self.getSimObject(simobjectid,typeof(Message_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// () Increment the reference count for this message)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addReference(){

pInvokes.m_ts.fn_Message_addReference(_ID);
}
/// <summary>
/// () Decrement the reference count for this message)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void freeReference(){

pInvokes.m_ts.fn_Message_freeReference(_ID);
}
/// <summary>
/// () Get message type (script class name or C++ class name if no script defined class))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getType(){

return pInvokes.m_ts.fn_Message_getType(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Script callback when a message is first created and registered.				   @tsexample				   function Message::onAdd(%this)				   {				   	// Perform on add code here				   }				   @endtsexample				   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

        /// <summary>
        /// Script callback when a message is deleted.				   @tsexample				   function Message::onRemove(%this)				   {				   	// Perform on remove code here				   }				   @endtsexample				   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemove(){}

#endregion
public Message_Base (){}
}}
