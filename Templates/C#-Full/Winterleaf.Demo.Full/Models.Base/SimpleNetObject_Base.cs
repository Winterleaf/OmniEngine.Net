


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
    [TypeConverter(typeof(TypeConverterGeneric<SimpleNetObject_Base>))]
    public partial class SimpleNetObject_Base: NetObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimpleNetObject_Base ts, string simobjectid)
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
        public static bool operator !=(SimpleNetObject_Base ts, string simobjectid)
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
        public static implicit operator string( SimpleNetObject_Base ts)
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
        public static implicit operator SimpleNetObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SimpleNetObject_Base) Omni.self.getSimObject(simobjectid,typeof(SimpleNetObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SimpleNetObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimpleNetObject_Base(int simobjectid)
            {
            return  (SimpleNetObject) Omni.self.getSimObject((uint)simobjectid,typeof(SimpleNetObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SimpleNetObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimpleNetObject_Base(uint simobjectid)
            {
            return  (SimpleNetObject_Base) Omni.self.getSimObject(simobjectid,typeof(SimpleNetObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Sets the internal message variable.
/// 
///    SimpleNetObject is set up to automatically transmit this new message to 
///    all connected clients.  It will appear in the clients' console.
/// 
///    @param msg The new message to send
///    
///    @tsexample
///       // On the server, create a new SimpleNetObject.  This is a ghost always
///       // object so it will be immediately ghosted to all connected clients.
///       $s = new SimpleNetObject();
/// 
///       // All connected clients will see the following in their console:
///       // 
///       // Got message: Hello World!
/// 
///       // Now again on the server, change the message.  This will cause it to
///       // be sent to all connected clients.
///       $s.setMessage(\"A new message from me!\");
/// 
///       // All connected clients will now see in their console:
///       // 
///       // Go message: A new message from me!
///    @endtsexample
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMessage(string msg){

pInvokes.m_ts.fnSimpleNetObject_setMessage(_ID, msg);
}

#endregion
#region T3D Callbacks

#endregion
public SimpleNetObject_Base (){}
}}
