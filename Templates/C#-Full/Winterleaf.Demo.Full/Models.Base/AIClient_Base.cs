


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
    [TypeConverter(typeof(TypeConverterGeneric<AIClient_Base>))]
    public partial class AIClient_Base: AIConnection
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AIClient_Base ts, string simobjectid)
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
        public static bool operator !=(AIClient_Base ts, string simobjectid)
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
        public static implicit operator string( AIClient_Base ts)
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
        public static implicit operator AIClient_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (AIClient_Base) Omni.self.getSimObject(simobjectid,typeof(AIClient_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( AIClient_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AIClient_Base(int simobjectid)
            {
            return  (AIClient) Omni.self.getSimObject((uint)simobjectid,typeof(AIClient_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( AIClient_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AIClient_Base(uint simobjectid)
            {
            return  (AIClient_Base) Omni.self.getSimObject(simobjectid,typeof(AIClient_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ai.getAimLocation(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getAimLocation(){

return pInvokes.m_ts.fn_AIClient_getAimLocation(_ID);
}
/// <summary>
/// ai.getLocation(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLocation(){

return pInvokes.m_ts.fn_AIClient_getLocation(_ID);
}
/// <summary>
/// ai.getMoveDestination(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getMoveDestination(){

return pInvokes.m_ts.fn_AIClient_getMoveDestination(_ID);
}
/// <summary>
/// ai.getTargetObject(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getTargetObject(){

return pInvokes.m_ts.fn_AIClient_getTargetObject(_ID);
}
/// <summary>
/// ai.missionCycleCleanup(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void missionCycleCleanup(){

pInvokes.m_ts.fn_AIClient_missionCycleCleanup(_ID);
}
/// <summary>
/// ai.move(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void move(){

pInvokes.m_ts.fn_AIClient_move(_ID);
}
/// <summary>
/// ai.moveForward(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void moveForward(){

pInvokes.m_ts.fn_AIClient_moveForward(_ID);
}
/// <summary>
/// ai.setAimLocation( x y z ); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAimLocation(Point3F v){

pInvokes.m_ts.fn_AIClient_setAimLocation(_ID, v.AsString());
}
/// <summary>
/// ai.setMoveDestination( x y z ); )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMoveDestination(Point3F v){

pInvokes.m_ts.fn_AIClient_setMoveDestination(_ID, v.AsString());
}
/// <summary>
/// ai.setMoveSpeed( float ); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMoveSpeed(float speed){

pInvokes.m_ts.fn_AIClient_setMoveSpeed(_ID, speed);
}
/// <summary>
/// ai.setTargetObject( obj ); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTargetObject(string objName){

pInvokes.m_ts.fn_AIClient_setTargetObject(_ID, objName);
}
/// <summary>
/// ai.stop(); ) 
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stop(){

pInvokes.m_ts.fn_AIClient_stop(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onConnect(string idString){}

#endregion
public AIClient_Base (){}
}}
