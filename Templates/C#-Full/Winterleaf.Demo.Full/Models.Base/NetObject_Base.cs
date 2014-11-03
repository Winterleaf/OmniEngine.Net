


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
    [TypeConverter(typeof(TypeConverterGeneric<NetObject_Base>))]
    public partial class NetObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NetObject_Base ts, string simobjectid)
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
        public static bool operator !=(NetObject_Base ts, string simobjectid)
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
        public static implicit operator string( NetObject_Base ts)
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
        public static implicit operator NetObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (NetObject_Base) Omni.self.getSimObject(simobjectid,typeof(NetObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( NetObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NetObject_Base(int simobjectid)
            {
            return  (NetObject) Omni.self.getSimObject((uint)simobjectid,typeof(NetObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( NetObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NetObject_Base(uint simobjectid)
            {
            return  (NetObject_Base) Omni.self.getSimObject(simobjectid,typeof(NetObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Undo the effects of a scopeToClient() call.
/// 
///    @param client The connection to remove this object's scoping from 
///    
///    @see scopeToClient())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearScopeToClient(string client){

pInvokes.m_ts.fnNetObject_clearScopeToClient(_ID, client);
}
/// <summary>
/// @brief Returns a pointer to the client object when on a local connection.
/// 
///    Short-Circuit-Networking: this is only valid for a local-client / singleplayer situation.
/// 
///    @returns the SimObject ID of the client object.
/// 
///    @tsexample
///       // Psuedo-code, some values left out for this example
///       %node = new ParticleEmitterNode(){};
///       %clientObject = %node.getClientObject();
///       if(isObject(%clientObject)
///       	%clientObject.setTransform(\"0 0 0\");
///    @endtsexample
///    
///    @see @ref local_connections)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getClientObject(){

return pInvokes.m_ts.fnNetObject_getClientObject(_ID);
}
/// <summary>
/// @brief Get the ghost index of this object from the server.
/// 
///    @returns The ghost ID of this NetObject on the server
/// 
///    @tsexample
///       %ghostID = LocalClientConnection.getGhostId( %serverObject );
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getGhostID(){

return pInvokes.m_ts.fnNetObject_getGhostID(_ID);
}
/// <summary>
/// @brief Returns a pointer to the client object when on a local connection.
/// 
///    Short-Circuit-Netorking: this is only valid for a local-client / singleplayer situation.
///    
///    @returns The SimObject ID of the server object.
///    @tsexample
///       // Psuedo-code, some values left out for this example
///       %node = new ParticleEmitterNode(){};
///       %serverObject = %node.getServerObject();
///       if(isObject(%serverObject)
///       	%serverObject.setTransform(\"0 0 0\");
///    @endtsexample
///    
///    @see @ref local_connections)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getServerObject(){

return pInvokes.m_ts.fnNetObject_getServerObject(_ID);
}
/// <summary>
/// @brief Called to check if an object resides on the clientside.
///    @return True if the object resides on the client, false otherwise.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isClientObject(){

return pInvokes.m_ts.fnNetObject_isClientObject(_ID);
}
/// <summary>
/// @brief Checks if an object resides on the server.
///    @return True if the object resides on the server, false otherwise.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isServerObject(){

return pInvokes.m_ts.fnNetObject_isServerObject(_ID);
}
/// <summary>
/// @brief Cause the NetObject to be forced as scoped on the specified NetConnection.
/// 
///    @param client The connection this object will always be scoped to
/// 
///    @tsexample
///       // Called to create new cameras in TorqueScript
///       // %this - The active GameConnection
///       // %spawnPoint - The spawn point location where we creat the camera
///       function GameConnection::spawnCamera(%this, %spawnPoint)
///       {
///       	// If this connection's camera exists
///       	if(isObject(%this.camera))
///       	{
///       		// Add it to the mission group to be cleaned up later
///       		MissionCleanup.add( %this.camera );
///       		// Force it to scope to the client side
///       		%this.camera.scopeToClient(%this);
///       	}
///       }
///    @endtsexample
///    
///    @see clearScopeToClient())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scopeToClient(string client){

pInvokes.m_ts.fnNetObject_scopeToClient(_ID, client);
}
/// <summary>
/// @brief Always scope this object on all connections.
/// 
///    The object is marked as ScopeAlways and is immediately ghosted to 
///    all active connections.  This function has no effect if the object 
///    is not marked as Ghostable.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setScopeAlways(){

pInvokes.m_ts.fnNetObject_setScopeAlways(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public NetObject_Base (){}
}}
