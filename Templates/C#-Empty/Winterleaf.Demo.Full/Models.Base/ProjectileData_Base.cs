


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
    [TypeConverter(typeof(TypeConverterGeneric<ProjectileData_Base>))]
    public partial class ProjectileData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ProjectileData_Base ts, string simobjectid)
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
        public static bool operator !=(ProjectileData_Base ts, string simobjectid)
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
        public static implicit operator string( ProjectileData_Base ts)
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
        public static implicit operator ProjectileData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ProjectileData_Base) Omni.self.getSimObject(simobjectid,typeof(ProjectileData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ProjectileData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ProjectileData_Base(int simobjectid)
            {
            return  (ProjectileData) Omni.self.getSimObject((uint)simobjectid,typeof(ProjectileData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ProjectileData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ProjectileData_Base(uint simobjectid)
            {
            return  (ProjectileData_Base) Omni.self.getSimObject(simobjectid,typeof(ProjectileData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Amount of time, in milliseconds, before the projectile will cause damage or explode on impact.\n\n   This value must be equal to or less than the projectile's lifetime.\n\n   @see lifetime
/// </summary>
[MemberGroup("")]
public int armingDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".armingDelay").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".armingDelay", value.AsString());
          }
       }
/// <summary>
/// @brief Influences post-bounce velocity of a projectile that does not explode on contact.\n\n   Scales the velocity from a bounce after friction is taken into account.    A value of 1.0 will leave it's velocity unchanged while values greater than 1.0 will increase it.\n
/// </summary>
[MemberGroup("")]
public float bounceElasticity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bounceElasticity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bounceElasticity", value.AsString());
          }
       }
/// <summary>
/// @brief Factor to reduce post-bounce velocity of a projectile that does not explode on contact.\n\n   Reduces bounce velocity by this factor and a multiple of the tangent to impact.    Used to simulate surface friction.\n
/// </summary>
[MemberGroup("")]
public float bounceFriction
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bounceFriction").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bounceFriction", value.AsString());
          }
       }
/// <summary>
/// @brief Decal datablock used for decals placed at projectile explosion points.\n\n
/// </summary>
[MemberGroup("")]
public DecalData decal
       {
       get
          {
          return Omni.self.GetVar(_ID + ".decal");
          }
       set
          {
          Omni.self.SetVar(_ID + ".decal", value.ToString());
          }
       }
/// <summary>
/// @brief Explosion datablock used when the projectile explodes outside of water.\n\n
/// </summary>
[MemberGroup("")]
public ExplosionData explosion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".explosion");
          }
       set
          {
          Omni.self.SetVar(_ID + ".explosion", value.ToString());
          }
       }
/// <summary>
/// @brief Amount of time, in milliseconds, before the projectile begins to fade out.\n\n   This value must be smaller than the projectile's lifetime to have an affect.
/// </summary>
[MemberGroup("")]
public int fadeDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeDelay").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeDelay", value.AsString());
          }
       }
/// <summary>
/// @brief Scales the influence of gravity on the projectile.\n\n   The larger this value is, the more that gravity will affect the projectile.    A value of 1.0 will assume \normal\ influence upon it.\n   The magnitude of gravity is assumed to be 9.81 m/s/s\n\n   @note ProjectileData::isBallistic must be true for this to have any affect.
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
/// 
/// </summary>
[MemberGroup("")]
public float impactForce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactForce").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactForce", value.AsString());
          }
       }
/// <summary>
/// @brief Detetmines if the projectile should be affected by gravity and whether or not    it bounces before exploding.\n\n
/// </summary>
[MemberGroup("")]
public bool isBallistic
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isBallistic").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isBallistic", value.AsString());
          }
       }
/// <summary>
/// @brief Amount of time, in milliseconds, before the projectile is removed from the simulation.\n\n   Used with fadeDelay to determine the transparency of the projectile at a given time.    A projectile may exist up to a maximum of 131040ms (or 4095 ticks) as defined by Projectile::MaxLivingTicks in the source code.   @see fadeDelay
/// </summary>
[MemberGroup("")]
public int lifetime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetime", value.AsString());
          }
       }
/// <summary>
/// @brief LightDescription datablock used for lights attached to the projectile.\n\n
/// </summary>
[MemberGroup("")]
public LightDescription lightDesc
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightDesc");
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightDesc", value.ToString());
          }
       }
/// <summary>
/// @brief Amount of velocity the projectile recieves from the \muzzle\ of the gun.\n\n   Used with velInheritFactor to determine the initial velocity of the projectile.    This value is never modified by the engine.\n\n   @note This value by default is not transmitted between the server and the client.\n\n   @see velInheritFactor
/// </summary>
[MemberGroup("")]
public float muzzleVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".muzzleVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".muzzleVelocity", value.AsString());
          }
       }
/// <summary>
/// @brief Particle emitter datablock used to generate particles while the projectile is outside of water.\n\n   @note If datablocks are defined for both particleEmitter and particleWaterEmitter, both effects will play    as the projectile enters or leaves water.\n\n   @see particleWaterEmitter\n
/// </summary>
[MemberGroup("")]
public ParticleEmitterData particleEmitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".particleEmitter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".particleEmitter", value.ToString());
          }
       }
/// <summary>
/// @brief Particle emitter datablock used to generate particles while the projectile is submerged in water.\n\n   @note If datablocks are defined for both particleWaterEmitter and particleEmitter , both effects will play    as the projectile enters or leaves water.\n\n   @see particleEmitter\n
/// </summary>
[MemberGroup("")]
public ParticleEmitterData particleWaterEmitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".particleWaterEmitter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".particleWaterEmitter", value.ToString());
          }
       }
/// <summary>
/// @brief File path to the model of the projectile.\n\n
/// </summary>
[MemberGroup("")]
public TypeShapeFilename projectileShapeName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".projectileShapeName").AsTypeShapeFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".projectileShapeName", value.AsString());
          }
       }
/// <summary>
/// @brief Scale to apply to the projectile's size.\n\n   @note This is applied after SceneObject::scale\n
/// </summary>
[MemberGroup("")]
public Point3F scale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scale").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scale", value.AsString());
          }
       }
/// <summary>
/// @brief SFXTrack datablock used to play sounds while in flight.\n\n
/// </summary>
[MemberGroup("")]
public TypeSFXTrackName sound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sound", value.AsString());
          }
       }
/// <summary>
/// @brief Splash datablock used to create splash effects as the projectile enters or leaves water\n\n
/// </summary>
[MemberGroup("")]
public SplashData splash
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splash");
          }
       set
          {
          Omni.self.SetVar(_ID + ".splash", value.ToString());
          }
       }
/// <summary>
/// @brief Amount of velocity the projectile recieves from the source that created it.\n\n   Use an amount between 0 and 1 for the best effect.    This value is never modified by the engine.\n   @note This value by default is not transmitted between the server and the client.
/// </summary>
[MemberGroup("")]
public float velInheritFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".velInheritFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".velInheritFactor", value.AsString());
          }
       }
/// <summary>
/// @brief Explosion datablock used when the projectile explodes underwater.\n\n
/// </summary>
[MemberGroup("")]
public ExplosionData waterExplosion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".waterExplosion");
          }
       set
          {
          Omni.self.SetVar(_ID + ".waterExplosion", value.ToString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when a projectile explodes.                   This function is only called on server objects.                   @param proj The exploding projectile.				   @param pos The position of the explosion.				   @param fade The current fadeValue of the projectile, affects its visibility.				   @see Projectile				  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onExplode(Projectile proj, Point3F pos, float fade){}

        /// <summary>
        /// @brief Called when a projectile collides with another object.                   This function is only called on server objects.				   @param proj The projectile colliding with SceneObject col.				   @param col The SceneObject hit by the projectile.				   @param fade The current fadeValue of the projectile, affects its visibility.				   @param pos The position of the collision.                   @param normal The normal of the collision.				   @see Projectile				  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCollision(Projectile proj, SceneObject col, float fade, Point3F pos, Point3F normal){}

#endregion
public ProjectileData_Base (){}
}}
