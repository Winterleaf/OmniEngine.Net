


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
    [TypeConverter(typeof(TypeConverterGeneric<RenderPassManager_Base>))]
    public partial class RenderPassManager_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RenderPassManager_Base ts, string simobjectid)
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
        public static bool operator !=(RenderPassManager_Base ts, string simobjectid)
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
        public static implicit operator string( RenderPassManager_Base ts)
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
        public static implicit operator RenderPassManager_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RenderPassManager_Base) Omni.self.getSimObject(simobjectid,typeof(RenderPassManager_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RenderPassManager_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RenderPassManager_Base(int simobjectid)
            {
            return  (RenderPassManager) Omni.self.getSimObject((uint)simobjectid,typeof(RenderPassManager_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RenderPassManager_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RenderPassManager_Base(uint simobjectid)
            {
            return  (RenderPassManager_Base) Omni.self.getSimObject(simobjectid,typeof(RenderPassManager_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Add as a render bin manager to the pass. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addManager(string renderBin){

pInvokes.m_ts.fnRenderPassManager_addManager(_ID, renderBin);
}
/// <summary>
/// Returns the render bin manager at the index or null if the index is out of range. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getManager(int index){

return pInvokes.m_ts.fnRenderPassManager_getManager(_ID, index);
}
/// <summary>
/// Returns the total number of bin managers. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getManagerCount(){

return pInvokes.m_ts.fnRenderPassManager_getManagerCount(_ID);
}
/// <summary>
/// Removes a render bin manager. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeManager(string renderBin){

pInvokes.m_ts.fnRenderPassManager_removeManager(_ID, renderBin);
}

#endregion
#region T3D Callbacks

#endregion
public RenderPassManager_Base (){}
}}
