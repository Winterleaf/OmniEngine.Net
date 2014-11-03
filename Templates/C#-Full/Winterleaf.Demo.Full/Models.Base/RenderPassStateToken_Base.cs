


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
    [TypeConverter(typeof(TypeConverterGeneric<RenderPassStateToken_Base>))]
    public partial class RenderPassStateToken_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RenderPassStateToken_Base ts, string simobjectid)
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
        public static bool operator !=(RenderPassStateToken_Base ts, string simobjectid)
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
        public static implicit operator string( RenderPassStateToken_Base ts)
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
        public static implicit operator RenderPassStateToken_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RenderPassStateToken_Base) Omni.self.getSimObject(simobjectid,typeof(RenderPassStateToken_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RenderPassStateToken_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RenderPassStateToken_Base(int simobjectid)
            {
            return  (RenderPassStateToken) Omni.self.getSimObject((uint)simobjectid,typeof(RenderPassStateToken_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RenderPassStateToken_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RenderPassStateToken_Base(uint simobjectid)
            {
            return  (RenderPassStateToken_Base) Omni.self.getSimObject(simobjectid,typeof(RenderPassStateToken_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Enables or disables this token.
/// </summary>
[MemberGroup("")]
public bool enabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".enabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".enabled", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Disables the token.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void disable(){

pInvokes.m_ts.fnRenderPassStateToken_disable(_ID);
}
/// <summary>
/// @brief Enables the token. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void enable(){

pInvokes.m_ts.fnRenderPassStateToken_enable(_ID);
}
/// <summary>
/// @brief Toggles the token from enabled to disabled or vice versa. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void toggle(){

pInvokes.m_ts.fnRenderPassStateToken_toggle(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public RenderPassStateToken_Base (){}
}}
