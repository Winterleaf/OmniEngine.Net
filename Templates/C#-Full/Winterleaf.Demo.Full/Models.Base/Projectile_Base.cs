


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
    [TypeConverter(typeof(TypeConverterGeneric<Projectile_Base>))]
    public partial class Projectile_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Projectile_Base ts, string simobjectid)
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
        public static bool operator !=(Projectile_Base ts, string simobjectid)
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
        public static implicit operator string( Projectile_Base ts)
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
        public static implicit operator Projectile_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Projectile_Base) Omni.self.getSimObject(simobjectid,typeof(Projectile_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Projectile_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Projectile_Base(int simobjectid)
            {
            return  (Projectile) Omni.self.getSimObject((uint)simobjectid,typeof(Projectile_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Projectile_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Projectile_Base(uint simobjectid)
            {
            return  (Projectile_Base) Omni.self.getSimObject(simobjectid,typeof(Projectile_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Starting position for the projectile.\n\n
/// </summary>
[MemberGroup("Physics")]
public Point3F initialPosition
       {
       get
          {
          return Omni.self.GetVar(_ID + ".initialPosition").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".initialPosition", value.AsString());
          }
       }
/// <summary>
/// @brief Starting velocity for the projectile.\n\n
/// </summary>
[MemberGroup("Physics")]
public Point3F initialVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".initialVelocity").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".initialVelocity", value.AsString());
          }
       }
/// <summary>
/// @brief ID number of the object that fired the projectile.\n\n   @note If the projectile was fired by a WeaponImage, sourceObject will be    the object that owns the WeaponImage. This is usually the player.
/// </summary>
[MemberGroup("Source")]
public int sourceObject
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sourceObject").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sourceObject", value.AsString());
          }
       }
/// <summary>
/// @brief The sourceObject's weapon slot that the projectile originates from.\n\n
/// </summary>
[MemberGroup("Source")]
public int sourceSlot
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sourceSlot").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sourceSlot", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Updates the projectile's positional and collision information.
///                                        This function will first delete the projectile if it is a server object and is outside it's ProjectileData::lifetime. 
///                                        Also responsible for applying gravity, determining collisions, triggering explosions, 
///                                        emitting trail particles, and calculating bounces if necessary.
/// 									            @param seconds Amount of time, in seconds since the simulation's start, to advance.
/// 									            @tsexample
/// 									               // Tell the projectile to process a simulation event, and provide the amount of time
/// 										            // that has passed since the simulation began.
/// 										            %seconds = 2.0;
/// 										            %projectile.presimulate(%seconds);
/// 									            @endtsexample
///                                        @note This function is not called if the SimObject::hidden is true.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void presimulate(float seconds = 1.0f){

pInvokes.m_ts.fnProjectile_presimulate(_ID, seconds);
}

#endregion
#region T3D Callbacks

#endregion
public Projectile_Base (){}
}}
