


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
    [TypeConverter(typeof(TypeConverterGeneric<AIConnection_Base>))]
    public partial class AIConnection_Base: GameConnection
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AIConnection_Base ts, string simobjectid)
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
        public static bool operator !=(AIConnection_Base ts, string simobjectid)
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
        public static implicit operator string( AIConnection_Base ts)
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
        public static implicit operator AIConnection_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (AIConnection_Base) Omni.self.getSimObject(simobjectid,typeof(AIConnection_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( AIConnection_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AIConnection_Base(int simobjectid)
            {
            return  (AIConnection) Omni.self.getSimObject((uint)simobjectid,typeof(AIConnection_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( AIConnection_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AIConnection_Base(uint simobjectid)
            {
            return  (AIConnection_Base) Omni.self.getSimObject(simobjectid,typeof(AIConnection_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  string getAddress(){

return pInvokes.m_ts.fn_AIConnection_getAddress(_ID);
}
/// <summary>
/// getFreeLook()
///               Is freelook on for the current move?)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getFreeLook(){

return pInvokes.m_ts.fn_AIConnection_getFreeLook(_ID);
}
/// <summary>
/// (string field)
///               Get the given field of a move.
///               @param field One of {'x','y','z','yaw','pitch','roll'}
///               @returns The requested field on the current move.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getMove(string field){

return pInvokes.m_ts.fn_AIConnection_getMove(_ID, field);
}
/// <summary>
/// (int trigger)
///               Is the given trigger set?)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getTrigger(int idx){

return pInvokes.m_ts.fn_AIConnection_getTrigger(_ID, idx);
}
/// <summary>
/// (bool isFreeLook)
///               Enable/disable freelook on the current move.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFreeLook(bool isFreeLook){

pInvokes.m_ts.fn_AIConnection_setFreeLook(_ID, isFreeLook);
}
/// <summary>
/// (string field, float value)
///               Set a field on the current move.
///               @param   field One of {'x','y','z','yaw','pitch','roll'}
///               @param   value Value to set field to.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMove(string field, float value){

pInvokes.m_ts.fn_AIConnection_setMove(_ID, field, value);
}
/// <summary>
/// (int trigger, bool set)
///               Set a trigger.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTrigger(int idx, bool set){

pInvokes.m_ts.fn_AIConnection_setTrigger(_ID, idx, set);
}

#endregion
#region T3D Callbacks

#endregion
public AIConnection_Base (){}
}}
