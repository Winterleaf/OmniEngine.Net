


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
    [TypeConverter(typeof(TypeConverterGeneric<CoverPoint_Base>))]
    public partial class CoverPoint_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CoverPoint_Base ts, string simobjectid)
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
        public static bool operator !=(CoverPoint_Base ts, string simobjectid)
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
        public static implicit operator string( CoverPoint_Base ts)
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
        public static implicit operator CoverPoint_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (CoverPoint_Base) Omni.self.getSimObject(simobjectid,typeof(CoverPoint_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( CoverPoint_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CoverPoint_Base(int simobjectid)
            {
            return  (CoverPoint) Omni.self.getSimObject((uint)simobjectid,typeof(CoverPoint_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( CoverPoint_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CoverPoint_Base(uint simobjectid)
            {
            return  (CoverPoint_Base) Omni.self.getSimObject(simobjectid,typeof(CoverPoint_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Returns true if someone is already using this cover point.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isOccupied(){

return pInvokes.m_ts.fnCoverPoint_isOccupied(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public CoverPoint_Base (){}
}}
