


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
    [TypeConverter(typeof(TypeConverterGeneric<TurretShapeData_Base>))]
    public partial class TurretShapeData_Base: ItemData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TurretShapeData_Base ts, string simobjectid)
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
        public static bool operator !=(TurretShapeData_Base ts, string simobjectid)
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
        public static implicit operator string( TurretShapeData_Base ts)
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
        public static implicit operator TurretShapeData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TurretShapeData_Base) Omni.self.getSimObject(simobjectid,typeof(TurretShapeData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TurretShapeData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TurretShapeData_Base(int simobjectid)
            {
            return  (TurretShapeData) Omni.self.getSimObject((uint)simobjectid,typeof(TurretShapeData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TurretShapeData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TurretShapeData_Base(uint simobjectid)
            {
            return  (TurretShapeData_Base) Omni.self.getSimObject(simobjectid,typeof(TurretShapeData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Vertical (Z axis) height of the camera above the turret. 
/// </summary>
[MemberGroup("")]
public float cameraOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraOffset", value.AsString());
          }
       }
/// <summary>
/// @brief Degrees per second rotation.\n\n   A value of 0 means no rotation is allowed. A value less than 0 means the rotation is instantaneous.\n
/// </summary>
[MemberGroup("")]
public float headingRate
       {
       get
          {
          return Omni.self.GetVar(_ID + ".headingRate").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".headingRate", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum number of degrees to rotate from center.\n\n   A value of 180 or more degrees indicates the turret may rotate completely around.\n
/// </summary>
[MemberGroup("")]
public float maxHeading
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxHeading").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxHeading", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum number of degrees to rotate up from straight ahead.\n\n
/// </summary>
[MemberGroup("")]
public float maxPitch
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxPitch").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxPitch", value.AsString());
          }
       }
/// <summary>
/// @brief Minimum number of degrees to rotate down from straight ahead.\n\n
/// </summary>
[MemberGroup("")]
public float minPitch
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minPitch").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minPitch", value.AsString());
          }
       }
/// <summary>
/// @brief Degrees per second rotation.\n\n   A value of 0 means no rotation is allowed. A value less than 0 means the rotation is instantaneous.\n
/// </summary>
[MemberGroup("")]
public float pitchRate
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pitchRate").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pitchRate", value.AsString());
          }
       }
/// <summary>
/// @brief Does the turret's mounted weapon(s) start in a loaded state.\n\n   True indicates that all mounted weapons start in a loaded state.\n   @see ShapeBase::setImageLoaded()
/// </summary>
[MemberGroup("")]
public bool startLoaded
       {
       get
          {
          return Omni.self.GetVar(_ID + ".startLoaded").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".startLoaded", value.AsString());
          }
       }
/// <summary>
/// @brief Set how the mounted weapons are linked and triggered.\n\n   ulliFireTogether: All weapons fire under trigger 0./li   liGroupedFire: Weapon mounts 0,2 fire under trigger 0, mounts 1,3 fire under trigger 1./li   liIndividualFire: Each weapon mount fires under its own trigger 0-3./li/ul\n   @see TurretShapeFireLinkType
/// </summary>
[MemberGroup("")]
public TypeTurretShapeFireLinkType weaponLinkType
       {
       get
          {          return (TypeTurretShapeFireLinkType) Omni.self.GetVar(_ID + ".weaponLinkType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".weaponLinkType", value.ToString());
          }
       }
/// <summary>
/// @brief Should the turret allow only z rotations.\n\n   True indicates that the turret may only be rotated on its z axis, just like the Item class.    This keeps the turret always upright regardless of the surface it lands on.\n
/// </summary>
[MemberGroup("")]
public bool zRotOnly
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zRotOnly").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zRotOnly", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Informs the TurretShapeData object that a player is mounting it.   @param turret The TurretShape object.   @param obj The player that is mounting.   @param node The node the player is mounting to.   @note Server side only.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMountObject(TurretShape turret, SceneObject obj, int node){}

        /// <summary>
        /// @brief Informs the TurretShapeData object that a player is unmounting it.   @param turret The TurretShape object.   @param obj The player that is unmounting.   @note Server side only.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUnmountObject(TurretShape turret, SceneObject obj){}

        /// <summary>
        /// @brief Informs the TurretData object that it is now sticking to another object.   This callback is only called if the TurretData::sticky property for this Turret is true.   @param obj The Turret object that is colliding.   @note Server side only.   @see TurretShape, TurretData)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStickyCollision(TurretShape obj){}

#endregion
public TurretShapeData_Base (){}
}}
