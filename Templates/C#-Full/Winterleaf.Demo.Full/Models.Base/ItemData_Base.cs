


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
    [TypeConverter(typeof(TypeConverterGeneric<ItemData_Base>))]
    public partial class ItemData_Base: ShapeBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ItemData_Base ts, string simobjectid)
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
        public static bool operator !=(ItemData_Base ts, string simobjectid)
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
        public static implicit operator string( ItemData_Base ts)
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
        public static implicit operator ItemData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ItemData_Base) Omni.self.getSimObject(simobjectid,typeof(ItemData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ItemData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ItemData_Base(int simobjectid)
            {
            return  (ItemData) Omni.self.getSimObject((uint)simobjectid,typeof(ItemData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ItemData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ItemData_Base(uint simobjectid)
            {
            return  (ItemData_Base) Omni.self.getSimObject(simobjectid,typeof(ItemData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// A floating-point value specifying how 'bouncy' this ItemData is.
/// </summary>
[MemberGroup("")]
public float elasticity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".elasticity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".elasticity", value.AsString());
          }
       }
/// <summary>
/// A floating-point value specifying how much velocity is lost to impact and sliding friction.
/// </summary>
[MemberGroup("")]
public float friction
       {
       get
          {
          return Omni.self.GetVar(_ID + ".friction").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".friction", value.AsString());
          }
       }
/// <summary>
/// Floating point value to multiply the existing gravity with, just for this ItemData.
/// </summary>
[MemberGroup("")]
public float gravityMod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gravityMod").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gravityMod", value.AsString());
          }
       }
/// <summary>
/// @brief Color value to make this light. Example: \1.0,1.0,1.0\\n\n   @see lightType\n
/// </summary>
[MemberGroup("")]
public ColorF lightColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightColor", value.AsString());
          }
       }
/// <summary>
/// @brief If true, this ItemData will only cast a light if the Item for this ItemData has a static value of true.\n\n   @see lightType\n
/// </summary>
[MemberGroup("")]
public bool lightOnlyStatic
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightOnlyStatic").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightOnlyStatic", value.AsString());
          }
       }
/// <summary>
/// @brief Distance from the center point of this ItemData for the light to affect\n\n   @see lightType\n
/// </summary>
[MemberGroup("")]
public float lightRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightRadius", value.AsString());
          }
       }
/// <summary>
/// @brief Time value for the light of this ItemData, used to control the pulse speed of the PulsingLight LightType.\n\n   @see lightType\n
/// </summary>
[MemberGroup("")]
public int lightTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightTime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightTime", value.AsString());
          }
       }
/// <summary>
/// Type of light to apply to this ItemData. Options are NoLight, ConstantLight, PulsingLight. Default is NoLight. 
/// </summary>
[MemberGroup("")]
public TypeItemLightType lightType
       {
       get
          {          return (TypeItemLightType) Omni.self.GetVar(_ID + ".lightType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightType", value.ToString());
          }
       }
/// <summary>
/// Maximum velocity that this ItemData is able to move.
/// </summary>
[MemberGroup("")]
public float maxVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxVelocity", value.AsString());
          }
       }
/// <summary>
/// @brief Determines if only simple server-side collision will be used (for pick ups).\n\n   If set to true then only simple, server-side collision detection will be used. This is often the case    if the item is used for a pick up object, such as ammo. If set to false then a full collision volume    will be used as defined by the shape. The default is true.\n   @note Only applies when using a physics library.\n   @see TurretShape and ProximityMine for examples that should set this to false to allow them to be    shot by projectiles.\n
/// </summary>
[MemberGroup("")]
public bool simpleServerCollision
       {
       get
          {
          return Omni.self.GetVar(_ID + ".simpleServerCollision").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".simpleServerCollision", value.AsString());
          }
       }
/// <summary>
/// @brief If true, ItemData will 'stick' to any surface it collides with.\n\n   When an item does stick to a surface, the Item::onStickyCollision() callback is called. The Item has methods to retrieve    the world position and normal the Item is stuck to.\n   @note Valid objects to stick to must be of StaticShapeObjectType.\n
/// </summary>
[MemberGroup("")]
public bool sticky
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sticky").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sticky", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public ItemData_Base (){}
}}
