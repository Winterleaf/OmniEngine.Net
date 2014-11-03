


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
    [TypeConverter(typeof(TypeConverterGeneric<ParticleEmitterData_Base>))]
    public partial class ParticleEmitterData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ParticleEmitterData_Base ts, string simobjectid)
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
        public static bool operator !=(ParticleEmitterData_Base ts, string simobjectid)
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
        public static implicit operator string( ParticleEmitterData_Base ts)
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
        public static implicit operator ParticleEmitterData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ParticleEmitterData_Base) Omni.self.getSimObject(simobjectid,typeof(ParticleEmitterData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ParticleEmitterData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleEmitterData_Base(int simobjectid)
            {
            return  (ParticleEmitterData) Omni.self.getSimObject((uint)simobjectid,typeof(ParticleEmitterData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ParticleEmitterData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleEmitterData_Base(uint simobjectid)
            {
            return  (ParticleEmitterData_Base) Omni.self.getSimObject(simobjectid,typeof(ParticleEmitterData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The direction aligned particles should face, only valid if alignParticles is true. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public Point3F alignDirection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alignDirection").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alignDirection", value.AsString());
          }
       }
/// <summary>
/// If true, particles always face along the axis defined by alignDirection. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool alignParticles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alignParticles").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alignParticles", value.AsString());
          }
       }
/// <summary>
/// Used to generate the final particle color by controlling interpolation      between the particle color and the particle color multiplied by the      ambient light color. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float ambientFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ambientFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ambientFactor", value.AsString());
          }
       }
/// <summary>
/// String value that controls how emitted particles blend with the scene. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public TypeParticleBlendStyle blendStyle
       {
       get
          {          return (TypeParticleBlendStyle) Omni.self.GetVar(_ID + ".blendStyle");
          }
       set
          {
          Omni.self.SetVar(_ID + ".blendStyle", value.ToString());
          }
       }
/// <summary>
/// Distance along ejection Z axis from which to eject particles. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float ejectionOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ejectionOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ejectionOffset", value.AsString());
          }
       }
/// <summary>
/// Distance Padding along ejection Z axis from which to eject particles. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float ejectionOffsetVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ejectionOffsetVariance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ejectionOffsetVariance", value.AsString());
          }
       }
/// <summary>
/// Time (in milliseconds) between each particle ejection. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public int ejectionPeriodMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ejectionPeriodMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ejectionPeriodMS", value.AsString());
          }
       }
/// <summary>
/// Particle ejection velocity. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float ejectionVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ejectionVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ejectionVelocity", value.AsString());
          }
       }
/// <summary>
/// This particle system should not use the mixed-resolution renderer.      If your particle system has large amounts of overdraw, consider      disabling this option. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool highResOnly
       {
       get
          {
          return Omni.self.GetVar(_ID + ".highResOnly").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".highResOnly", value.AsString());
          }
       }
/// <summary>
/// Lifetime of emitted particles (in milliseconds). 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public int lifetimeMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetimeMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetimeMS", value.AsString());
          }
       }
/// <summary>
/// Variance in particle lifetime from 0 - lifetimeMS. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public int lifetimeVarianceMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetimeVarianceMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetimeVarianceMS", value.AsString());
          }
       }
/// <summary>
/// If true, particles will be oriented to face in the direction they are moving. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool orientOnVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".orientOnVelocity").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".orientOnVelocity", value.AsString());
          }
       }
/// <summary>
/// If true, Particles will always face the camera. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool orientParticles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".orientParticles").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".orientParticles", value.AsString());
          }
       }
/// <summary>
/// If false, particles emitted in the same frame have their positions      adjusted. If true, adjustment is skipped and particles will clump      together. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool overrideAdvance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".overrideAdvance").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".overrideAdvance", value.AsString());
          }
       }
/// <summary>
/// @brief List of space or TAB delimited ParticleData datablock names.\n\n     A random one of these datablocks is selected each time a particle is      emitted. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public String particles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".particles").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".particles", value.AsString());
          }
       }
/// <summary>
/// Variance in ejection period, from 1 - ejectionPeriodMS. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public int periodVarianceMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".periodVarianceMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".periodVarianceMS", value.AsString());
          }
       }
/// <summary>
/// Reference angle, from the vertical plane, to eject particles from. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float phiReferenceVel
       {
       get
          {
          return Omni.self.GetVar(_ID + ".phiReferenceVel").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".phiReferenceVel", value.AsString());
          }
       }
/// <summary>
/// Variance from the reference angle, from 0 - 360. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float phiVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".phiVariance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".phiVariance", value.AsString());
          }
       }
/// <summary>
/// Controls whether particles are rendered onto reflective surfaces like water. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool renderReflection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderReflection").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderReflection", value.AsString());
          }
       }
/// <summary>
/// @brief If true, reverses the normal draw order of particles.\n\n     Particles are normally drawn from newest to oldest, or in Z order      (furthest first) if sortParticles is true. Setting this field to      true will reverse that order: oldest first, or nearest first if      sortParticles is true. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool reverseOrder
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reverseOrder").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reverseOrder", value.AsString());
          }
       }
/// <summary>
/// For soft particles, the distance (in meters) where particles will be      faded based on the difference in depth between the particle and the      scene geometry. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float softnessDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softnessDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softnessDistance", value.AsString());
          }
       }
/// <summary>
/// If true, particles are sorted furthest to nearest.
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool sortParticles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sortParticles").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sortParticles", value.AsString());
          }
       }
/// <summary>
/// Optional texture to override ParticleData::textureName. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public String textureName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textureName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureName", value.AsString());
          }
       }
/// <summary>
/// Maximum angle, from the horizontal plane, to eject particles from. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float thetaMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".thetaMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".thetaMax", value.AsString());
          }
       }
/// <summary>
/// Minimum angle, from the horizontal plane, to eject from. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float thetaMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".thetaMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".thetaMin", value.AsString());
          }
       }
/// <summary>
/// @brief If true, use emitter specified colors instead of datablock colors.\n\n     Useful for ShapeBase dust and WheeledVehicle wheel particle emitters that use      the current material to control particle color. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool useEmitterColors
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useEmitterColors").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useEmitterColors", value.AsString());
          }
       }
/// <summary>
/// @brief If true, use emitter specified sizes instead of datablock sizes.\n     Useful for Debris particle emitters that control the particle size. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public bool useEmitterSizes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useEmitterSizes").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useEmitterSizes", value.AsString());
          }
       }
/// <summary>
/// Variance for ejection velocity, from 0 - ejectionVelocity. 
/// </summary>
[MemberGroup("ParticleEmitterData")]
public float velocityVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".velocityVariance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".velocityVariance", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Reloads the ParticleData datablocks and other fields used by this emitter.
///    @tsexample
///    // Get the editor's current particle emitter
///    %emitter = PE_EmitterEditor.currEmitter
///    // Change a field value
///    %emitter.setFieldValue( %propertyField, %value );
///    // Reload this emitter
///    %emitter.reload();
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reload(){

pInvokes.m_ts.fnParticleEmitterData_reload(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public ParticleEmitterData_Base (){}
}}
