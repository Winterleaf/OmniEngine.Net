


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
    [TypeConverter(typeof(TypeConverterGeneric<SpotLight_Base>))]
    public partial class SpotLight_Base: LightBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SpotLight_Base ts, string simobjectid)
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
        public static bool operator !=(SpotLight_Base ts, string simobjectid)
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
        public static implicit operator string( SpotLight_Base ts)
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
        public static implicit operator SpotLight_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SpotLight_Base) Omni.self.getSimObject(simobjectid,typeof(SpotLight_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SpotLight_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SpotLight_Base(int simobjectid)
            {
            return  (SpotLight) Omni.self.getSimObject((uint)simobjectid,typeof(SpotLight_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SpotLight_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SpotLight_Base(uint simobjectid)
            {
            return  (SpotLight_Base) Omni.self.getSimObject(simobjectid,typeof(SpotLight_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("Light")]
public float innerAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".innerAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".innerAngle", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Light")]
public float outerAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".outerAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".outerAngle", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("Light")]
public float range
       {
       get
          {
          return Omni.self.GetVar(_ID + ".range").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".range", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SpotLight_Base (){}
}}
