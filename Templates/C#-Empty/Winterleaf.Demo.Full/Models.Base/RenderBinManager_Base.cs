


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
    [TypeConverter(typeof(TypeConverterGeneric<RenderBinManager_Base>))]
    public partial class RenderBinManager_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RenderBinManager_Base ts, string simobjectid)
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
        public static bool operator !=(RenderBinManager_Base ts, string simobjectid)
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
        public static implicit operator string( RenderBinManager_Base ts)
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
        public static implicit operator RenderBinManager_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RenderBinManager_Base) Omni.self.getSimObject(simobjectid,typeof(RenderBinManager_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RenderBinManager_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RenderBinManager_Base(int simobjectid)
            {
            return  (RenderBinManager) Omni.self.getSimObject((uint)simobjectid,typeof(RenderBinManager_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RenderBinManager_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RenderBinManager_Base(uint simobjectid)
            {
            return  (RenderBinManager_Base) Omni.self.getSimObject(simobjectid,typeof(RenderBinManager_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Sets the render bin type which limits what render instances are added to this bin. 
/// </summary>
[MemberGroup("")]
public String binType
       {
       get
          {
          return Omni.self.GetVar(_ID + ".binType").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".binType", value.AsString());
          }
       }
/// <summary>
/// Defines the order for adding instances in relation to other bins. 
/// </summary>
[MemberGroup("")]
public float processAddOrder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".processAddOrder").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".processAddOrder", value.AsString());
          }
       }
/// <summary>
/// Defines the order for rendering in relation to other bins. 
/// </summary>
[MemberGroup("")]
public float renderOrder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderOrder").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderOrder", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Returns the bin type string. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getBinType(){

return pInvokes.m_ts.fnRenderBinManager_getBinType(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public RenderBinManager_Base (){}
}}
