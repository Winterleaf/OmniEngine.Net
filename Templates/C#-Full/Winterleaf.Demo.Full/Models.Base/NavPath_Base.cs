


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
    [TypeConverter(typeof(TypeConverterGeneric<NavPath_Base>))]
    public partial class NavPath_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavPath_Base ts, string simobjectid)
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
        public static bool operator !=(NavPath_Base ts, string simobjectid)
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
        public static implicit operator string( NavPath_Base ts)
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
        public static implicit operator NavPath_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (NavPath_Base) Omni.self.getSimObject(simobjectid,typeof(NavPath_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( NavPath_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavPath_Base(int simobjectid)
            {
            return  (NavPath) Omni.self.getSimObject((uint)simobjectid,typeof(NavPath_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( NavPath_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavPath_Base(uint simobjectid)
            {
            return  (NavPath_Base) Omni.self.getSimObject(simobjectid,typeof(NavPath_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Get a specified node along the path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getFlags(int idx){

return pInvokes.m_ts.fnNavPath_getFlags(_ID, idx);
}
/// <summary>
/// @brief Get the length of this path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getLength(){

return pInvokes.m_ts.fnNavPath_getLength(_ID);
}
/// <summary>
/// @brief Get a specified node along the path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getNode(int idx){

return new Point3F ( pInvokes.m_ts.fnNavPath_getNode(_ID, idx));
}
/// <summary>
/// @brief Callback when this path's NavMesh is loaded or rebuilt.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void onNavMeshUpdate(string data){

pInvokes.m_ts.fnNavPath_onNavMeshUpdate(_ID, data);
}
/// <summary>
/// @brief Callback when a particular area in this path's NavMesh is rebuilt.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void onNavMeshUpdateBox(string data){

pInvokes.m_ts.fnNavPath_onNavMeshUpdateBox(_ID, data);
}
/// <summary>
/// @brief Find a path using the already-specified path properties.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool plan(){

return pInvokes.m_ts.fnNavPath_plan(_ID);
}
/// <summary>
/// @brief Return the number of nodes in this path.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int size(){

return pInvokes.m_ts.fnNavPath_size(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public NavPath_Base (){}
}}
