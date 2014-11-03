


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
    [TypeConverter(typeof(TypeConverterGeneric<TCPObject_Base>))]
    public partial class TCPObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TCPObject_Base ts, string simobjectid)
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
        public static bool operator !=(TCPObject_Base ts, string simobjectid)
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
        public static implicit operator string( TCPObject_Base ts)
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
        public static implicit operator TCPObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TCPObject_Base) Omni.self.getSimObject(simobjectid,typeof(TCPObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TCPObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TCPObject_Base(int simobjectid)
            {
            return  (TCPObject) Omni.self.getSimObject((uint)simobjectid,typeof(TCPObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TCPObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TCPObject_Base(uint simobjectid)
            {
            return  (TCPObject_Base) Omni.self.getSimObject(simobjectid,typeof(TCPObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Connect to the given address.
/// 
///    @param address Server address (including port) to connect to.
/// 
///    @tsexample
///       // Set the address.
///       %address = \"www.garagegames.com:80\";
/// 
///       // Inform this TCPObject to connect to the specified address.
///       %thisTCPObj.connect(%address);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void connect(string address){

pInvokes.m_ts.fnTCPObject_connect(_ID, address);
}
/// <summary>
/// @brief Disconnect from whatever this TCPObject is currently connected to, if anything.
/// 
///    @tsexample
///       // Inform this TCPObject to disconnect from anything it is currently connected to.
///       %thisTCPObj.disconnect();
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void disconnect(){

pInvokes.m_ts.fnTCPObject_disconnect(_ID);
}
/// <summary>
/// @brief Start listening on the specified port for connections.
/// 
///    This method starts a listener which looks for incoming TCP connections to a port.  
///    You must overload the onConnectionRequest callback to create a new TCPObject to 
///    read, write, or reject the new connection.
/// 
///    @param port Port for this TCPObject to start listening for connections on.
/// 
///    @tsexample
/// 
///     // Create a listener on port 8080.
///     new TCPObject( TCPListener );
///     TCPListener.listen( 8080 );
/// 
///     function TCPListener::onConnectionRequest( %this, %address, %id )
///     {
///        // Create a new object to manage the connection.
///        new TCPObject( TCPClient, %id );
///     }
/// 
///     function TCPClient::onLine( %this, %line )
///     {
///        // Print the line of text from client.
///        echo( %line );
///     }
/// 
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void listen(uint port){

pInvokes.m_ts.fnTCPObject_listen(_ID, port);
}
/// <summary>
/// @brief Transmits the data string to the connected computer.
/// 
///    This method is used to send text data to the connected computer regardless if we initiated the 
///    connection using connect(), or listening to a port using listen().
/// 
///    @param data The data string to send.
/// 
///    @tsexample
///       // Set the command data
///       %data = \"GET \" @ $RSSFeed::serverURL @ \" HTTP/1.0\\r\\";
///       %data = %data @ \"Host: \" @ $RSSFeed::serverName @ \"\\r\\";
///       %data = %data @ \"User-Agent: \" @ $RSSFeed::userAgent @ \"\\r\\\r\\"
/// 
///       // Send the command to the connected server.
///       %thisTCPObj.send(%data);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void send(string data){

pInvokes.m_ts.fnTCPObject_send(_ID, data);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called whenever a connection request is made.   This callback is used when the TCPObject is listening to a port and a client is attempting to connect.   @param address Server address connecting from.   @param ID Connection ID   @see listen()   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectionRequest(string address, string ID){}

        /// <summary>
        /// @brief Called whenever a line of data is sent to this TCPObject.   This callback is called when the received data contains a newline @\ character, or    the connection has been disconnected and the TCPObject's buffer is flushed.   @param line Data sent from the server.   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLine(string line){}

        /// <summary>
        /// Called whenever the DNS has been resolved.   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDNSResolved(){}

        /// <summary>
        /// Called whenever the DNS has failed to resolve.   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDNSFailed(){}

        /// <summary>
        /// Called whenever a connection is established with a server.   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnected(){}

        /// <summary>
        /// Called whenever a connection has failed to be established with a server.   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnectFailed(){}

        /// <summary>
        /// Called whenever the TCPObject disconnects from whatever it is currently connected to.   )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDisconnect(){}

#endregion
public TCPObject_Base (){}
}}
