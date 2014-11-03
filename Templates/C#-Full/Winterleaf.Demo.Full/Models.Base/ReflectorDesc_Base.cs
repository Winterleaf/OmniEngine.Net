


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
    [TypeConverter(typeof(TypeConverterGeneric<ReflectorDesc_Base>))]
    public partial class ReflectorDesc_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ReflectorDesc_Base ts, string simobjectid)
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
        public static bool operator !=(ReflectorDesc_Base ts, string simobjectid)
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
        public static implicit operator string( ReflectorDesc_Base ts)
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
        public static implicit operator ReflectorDesc_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ReflectorDesc_Base) Omni.self.getSimObject(simobjectid,typeof(ReflectorDesc_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ReflectorDesc_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ReflectorDesc_Base(int simobjectid)
            {
            return  (ReflectorDesc) Omni.self.getSimObject((uint)simobjectid,typeof(ReflectorDesc_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ReflectorDesc_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ReflectorDesc_Base(uint simobjectid)
            {
            return  (ReflectorDesc_Base) Omni.self.getSimObject(simobjectid,typeof(ReflectorDesc_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Scale applied to lod calculation of objects rendering into      this reflection ( modulates $pref::TS::detailAdjust ). 
/// </summary>
[MemberGroup("ReflectorDesc")]
public float detailAdjust
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailAdjust").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailAdjust", value.AsString());
          }
       }
/// <summary>
/// Far plane distance to use when rendering reflections. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public float farDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".farDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".farDist", value.AsString());
          }
       }
/// <summary>
/// If less than maxRateMs has elapsed since this relfection was last      updated, then do not update it again. This 'skip' can be disabled by      setting maxRateMs to zero. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public int maxRateMs
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxRateMs").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxRateMs", value.AsString());
          }
       }
/// <summary>
/// Near plane distance to use when rendering this reflection. Adjust      this to limit self-occlusion artifacts. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public float nearDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".nearDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".nearDist", value.AsString());
          }
       }
/// <summary>
/// Object types which render into this reflection. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public int objectTypeMask
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objectTypeMask").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objectTypeMask", value.AsString());
          }
       }
/// <summary>
/// Priority for updating this reflection, relative to others. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public float priority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".priority").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".priority", value.AsString());
          }
       }
/// <summary>
/// Size in pixels of the (square) reflection texture. For a cubemap      this value is interpreted as size of each face. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public int texSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texSize", value.AsString());
          }
       }
/// <summary>
/// Type of reflection to generate. Temp: plane = 0, cubemap = 1     this value is interpreted as. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public int type
       {
       get
          {
          return Omni.self.GetVar(_ID + ".type").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".type", value.AsString());
          }
       }
/// <summary>
/// If available on the device use HOQs to determine if the reflective object      is visible before updating its reflection. 
/// </summary>
[MemberGroup("ReflectorDesc")]
public bool useOcclusionQuery
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useOcclusionQuery").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useOcclusionQuery", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public ReflectorDesc_Base (){}
}}
