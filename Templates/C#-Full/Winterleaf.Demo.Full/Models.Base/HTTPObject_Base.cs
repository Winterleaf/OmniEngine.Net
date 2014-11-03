


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
    [TypeConverter(typeof(TypeConverterGeneric<HTTPObject_Base>))]
    public partial class HTTPObject_Base: TCPObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(HTTPObject_Base ts, string simobjectid)
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
        public static bool operator !=(HTTPObject_Base ts, string simobjectid)
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
        public static implicit operator string( HTTPObject_Base ts)
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
        public static implicit operator HTTPObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (HTTPObject_Base) Omni.self.getSimObject(simobjectid,typeof(HTTPObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( HTTPObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator HTTPObject_Base(int simobjectid)
            {
            return  (HTTPObject) Omni.self.getSimObject((uint)simobjectid,typeof(HTTPObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( HTTPObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator HTTPObject_Base(uint simobjectid)
            {
            return  (HTTPObject_Base) Omni.self.getSimObject(simobjectid,typeof(HTTPObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
///  ),
///    @brief Send a GET command to a server to send or retrieve data.
/// 
///    @param Address HTTP web address to send this get call to. Be sure to include the port at the end (IE: \"www.garagegames.com:80\").
///    @param requirstURI Specific location on the server to access (IE: \"index.php\".)
///    @param query Optional. Actual data to transmit to the server. Can be anything required providing it sticks with limitations of the HTTP protocol. 
///    If you were building the URL manually, this is the text that follows the question mark.  For example: http://www.google.com/ig/api?b>weather=Las-Vegas,US/b>
///    
///    @tsexample
/// 	   // Create an HTTP object for communications
/// 	   %httpObj = new HTTPObject();
/// 	   // Specify a URL to transmit to
///       %url = \"www.garagegames.com:80\";
/// 	   // Specify a URI to communicate with
/// 	   %URI = \"/index.php\";
/// 	   // Specify a query to send.
/// 	   %query = \"\";
/// 	   // Send the GET command to the server
/// 	   %httpObj.get(%url,%URI,%query);
///    @endtsexample
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void get(string Address, string requirstURI, string query = ""){

pInvokes.m_ts.fnHTTPObject_get(_ID, Address, requirstURI, query);
}
/// <summary>
/// @brief Send POST command to a server to send or retrieve data.
/// 
///    @param Address HTTP web address to send this get call to. Be sure to include the port at the end (IE: \"www.garagegames.com:80\").
///    @param requirstURI Specific location on the server to access (IE: \"index.php\".)
///    @param query Actual data to transmit to the server. Can be anything required providing it sticks with limitations of the HTTP protocol. 
///    @param post Submission data to be processed.
///    
///    @note The post() method is currently non-functional.
/// 
///    @tsexample
/// 	   // Create an HTTP object for communications
/// 	   %httpObj = new HTTPObject();
/// 	   // Specify a URL to transmit to
///       %url = \"www.garagegames.com:80\";
/// 	   // Specify a URI to communicate with
/// 	   %URI = \"/index.php\";
/// 	   // Specify a query to send.
/// 	   %query = \"\";
/// 	   // Specify the submission data.
/// 	   %post = \"\";
/// 	   // Send the POST command to the server
/// 	   %httpObj.POST(%url,%URI,%query,%post);
///    @endtsexample
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void post(string Address, string requirstURI, string query, string post){

pInvokes.m_ts.fnHTTPObject_post(_ID, Address, requirstURI, query, post);
}

#endregion
#region T3D Callbacks

#endregion
public HTTPObject_Base (){}
}}
