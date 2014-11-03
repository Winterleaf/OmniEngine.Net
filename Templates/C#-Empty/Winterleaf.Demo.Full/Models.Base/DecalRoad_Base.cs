


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
    [TypeConverter(typeof(TypeConverterGeneric<DecalRoad_Base>))]
    public partial class DecalRoad_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DecalRoad_Base ts, string simobjectid)
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
        public static bool operator !=(DecalRoad_Base ts, string simobjectid)
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
        public static implicit operator string( DecalRoad_Base ts)
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
        public static implicit operator DecalRoad_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (DecalRoad_Base) Omni.self.getSimObject(simobjectid,typeof(DecalRoad_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( DecalRoad_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DecalRoad_Base(int simobjectid)
            {
            return  (DecalRoad) Omni.self.getSimObject((uint)simobjectid,typeof(DecalRoad_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( DecalRoad_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DecalRoad_Base(uint simobjectid)
            {
            return  (DecalRoad_Base) Omni.self.getSimObject(simobjectid,typeof(DecalRoad_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Angle in degrees - DecalRoad will subdivided the spline if its curve is greater than this threshold. 
/// </summary>
[MemberGroup("DecalRoad")]
public float breakAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".breakAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".breakAngle", value.AsString());
          }
       }
/// <summary>
/// Material used for rendering. 
/// </summary>
[MemberGroup("DecalRoad")]
public TypeMaterialName material
       {
       get
          {
          return Omni.self.GetVar(_ID + ".material").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".material", value.AsString());
          }
       }
/// <summary>
/// Do not modify, for internal use. 
/// </summary>
[MemberGroup("Internal")]
public String node
       {
       get
          {
          return Omni.self.GetVar(_ID + ".node").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".node", value.AsString());
          }
       }
/// <summary>
/// DecalRoad(s) are rendered in descending renderPriority order. 
/// </summary>
[MemberGroup("DecalRoad")]
public int renderPriority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderPriority").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderPriority", value.AsString());
          }
       }
/// <summary>
/// The length in meters of textures mapped to the DecalRoad 
/// </summary>
[MemberGroup("DecalRoad")]
public float textureLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textureLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureLength", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force trigger an inspectPostApply. This will transmit 
///                    the material and other fields ( not including nodes ) 
///                    to client objects.
///                   )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fnDecalRoad_postApply(_ID);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force DecalRoad to update it's spline and reclip geometry.
///                   )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void regenerate(){

pInvokes.m_ts.fnDecalRoad_regenerate(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public DecalRoad_Base (){}
}}
