


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
    [TypeConverter(typeof(TypeConverterGeneric<WaterPlane_Base>))]
    public partial class WaterPlane_Base: WaterObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WaterPlane_Base ts, string simobjectid)
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
        public static bool operator !=(WaterPlane_Base ts, string simobjectid)
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
        public static implicit operator string( WaterPlane_Base ts)
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
        public static implicit operator WaterPlane_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WaterPlane_Base) Omni.self.getSimObject(simobjectid,typeof(WaterPlane_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WaterPlane_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WaterPlane_Base(int simobjectid)
            {
            return  (WaterPlane) Omni.self.getSimObject((uint)simobjectid,typeof(WaterPlane_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WaterPlane_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WaterPlane_Base(uint simobjectid)
            {
            return  (WaterPlane_Base) Omni.self.getSimObject(simobjectid,typeof(WaterPlane_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Duplicate of gridElementSize for backwards compatility
/// </summary>
[MemberGroup("WaterPlane")]
public float gridElementSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridElementSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridElementSize", value.AsString());
          }
       }
/// <summary>
/// Spacing between vertices in the WaterBlock mesh 
/// </summary>
[MemberGroup("WaterPlane")]
public int gridSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridSize", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public WaterPlane_Base (){}
}}
