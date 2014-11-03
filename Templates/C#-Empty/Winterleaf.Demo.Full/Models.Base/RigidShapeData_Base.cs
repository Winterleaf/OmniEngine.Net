


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
    [TypeConverter(typeof(TypeConverterGeneric<RigidShapeData_Base>))]
    public partial class RigidShapeData_Base: ShapeBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RigidShapeData_Base ts, string simobjectid)
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
        public static bool operator !=(RigidShapeData_Base ts, string simobjectid)
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
        public static implicit operator string( RigidShapeData_Base ts)
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
        public static implicit operator RigidShapeData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RigidShapeData_Base) Omni.self.getSimObject(simobjectid,typeof(RigidShapeData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RigidShapeData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RigidShapeData_Base(int simobjectid)
            {
            return  (RigidShapeData) Omni.self.getSimObject((uint)simobjectid,typeof(RigidShapeData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RigidShapeData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RigidShapeData_Base(uint simobjectid)
            {
            return  (RigidShapeData_Base) Omni.self.getSimObject(simobjectid,typeof(RigidShapeData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// How much friction this object has. Lower values will cause the object to appear to be more slippery.
/// </summary>
[MemberGroup("")]
public float bodyFriction
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bodyFriction").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bodyFriction", value.AsString());
          }
       }
/// <summary>
/// The percentage of kinetic energy kept by this object in a collision.
/// </summary>
[MemberGroup("")]
public float bodyRestitution
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bodyRestitution").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bodyRestitution", value.AsString());
          }
       }
/// <summary>
/// Scalar rate at which the third person camera offset decays, per tick.\n
/// </summary>
[MemberGroup("Camera")]
public float cameraDecay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraDecay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraDecay", value.AsString());
          }
       }
/// <summary>
/// Scalar amount by which the third person camera lags the object, relative to the object's linear velocity.\n
/// </summary>
[MemberGroup("Camera")]
public float cameraLag
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraLag").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraLag", value.AsString());
          }
       }
/// <summary>
/// The vertical offset of the object's camera.\n
/// </summary>
[MemberGroup("Camera")]
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
/// Specifies whether the camera's rotation matrix, and the render eye transform are multiplied during camera updates.\n
/// </summary>
[MemberGroup("Camera")]
public bool cameraRoll
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cameraRoll").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cameraRoll", value.AsString());
          }
       }
/// <summary>
/// Collision distance tolerance.
/// </summary>
[MemberGroup("")]
public float collisionTol
       {
       get
          {
          return Omni.self.GetVar(_ID + ".collisionTol").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".collisionTol", value.AsString());
          }
       }
/// <summary>
/// Contact velocity tolerance.
/// </summary>
[MemberGroup("")]
public float contactTol
       {
       get
          {
          return Omni.self.GetVar(_ID + ".contactTol").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".contactTol", value.AsString());
          }
       }
/// <summary>
/// Used to simulate the constant drag acting on the object
/// </summary>
[MemberGroup("Forces")]
public float dragForce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dragForce").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dragForce", value.AsString());
          }
       }
/// <summary>
/// Array of pointers to ParticleEmitterData datablocks which will be used to emit particles at object/terrain contact point.\n
/// </summary>
[MemberGroup("Particle Effects")]
public ParticleEmitterData dustEmitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dustEmitter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".dustEmitter", value.ToString());
          }
       }
/// <summary>
/// Height of dust effects.\n
/// </summary>
[MemberGroup("Particle Effects")]
public float dustHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dustHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dustHeight", value.AsString());
          }
       }
/// <summary>
/// Particle emitter used to create a dust trail for the moving object.\n
/// </summary>
[MemberGroup("Particle Effects")]
public ParticleEmitterData dustTrailEmitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dustTrailEmitter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".dustTrailEmitter", value.ToString());
          }
       }
/// <summary>
/// The AudioProfile will be used to produce sounds when emerging from water.\n
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName exitingWater
       {
       get
          {
          return Omni.self.GetVar(_ID + ".exitingWater").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".exitingWater", value.AsString());
          }
       }
/// <summary>
/// The minimum velocity at which the exit splash sound will be played when emerging from water.\n
/// </summary>
[MemberGroup("Sounds")]
public float exitSplashSoundVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".exitSplashSoundVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".exitSplashSoundVelocity", value.AsString());
          }
       }
/// <summary>
/// Sound to play when body impacts with at least hardImpactSpeed. 
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName hardImpactSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hardImpactSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hardImpactSound", value.AsString());
          }
       }
/// <summary>
/// Minimum speed at which the object must be travelling for the hard impact sound to be played.
/// </summary>
[MemberGroup("")]
public float hardImpactSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hardImpactSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hardImpactSpeed", value.AsString());
          }
       }
/// <summary>
/// The minimum velocity at which the hard splash sound will be played when impacting water.\n
/// </summary>
[MemberGroup("Sounds")]
public float hardSplashSoundVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hardSplashSoundVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hardSplashSoundVelocity", value.AsString());
          }
       }
/// <summary>
/// The AudioProfile will be used to produce sounds when a soft impact with water occurs.\n
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName impactWaterEasy
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactWaterEasy").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactWaterEasy", value.AsString());
          }
       }
/// <summary>
/// The AudioProfile will be used to produce sounds when a hard impact with water occurs.\n
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName impactWaterHard
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactWaterHard").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactWaterHard", value.AsString());
          }
       }
/// <summary>
/// The AudioProfile will be used to produce sounds when a medium impact with water occurs.\n
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName impactWaterMedium
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactWaterMedium").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactWaterMedium", value.AsString());
          }
       }
/// <summary>
/// Number of physics steps to process per tick.
/// </summary>
[MemberGroup("")]
public int integration
       {
       get
          {
          return Omni.self.GetVar(_ID + ".integration").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".integration", value.AsString());
          }
       }
/// <summary>
/// Size of inertial box.
/// </summary>
[MemberGroup("")]
public Point3F massBox
       {
       get
          {
          return Omni.self.GetVar(_ID + ".massBox").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".massBox", value.AsString());
          }
       }
/// <summary>
/// Center of mass for rigid body.
/// </summary>
[MemberGroup("")]
public Point3F massCenter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".massCenter").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".massCenter", value.AsString());
          }
       }
/// <summary>
/// Maximum drag available to this object.
/// </summary>
[MemberGroup("")]
public float maxDrag
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxDrag").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxDrag", value.AsString());
          }
       }
/// <summary>
/// The minimum velocity at which the medium splash sound will be played when impacting water.\n
/// </summary>
[MemberGroup("Sounds")]
public float mediumSplashSoundVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mediumSplashSoundVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mediumSplashSoundVelocity", value.AsString());
          }
       }
/// <summary>
/// Minimum drag available to this object.
/// </summary>
[MemberGroup("")]
public float minDrag
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minDrag").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minDrag", value.AsString());
          }
       }
/// <summary>
/// Minimum collision speed to classify collision as impact (triggers onImpact on server object). 
/// </summary>
[MemberGroup("")]
public float minImpactSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minImpactSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minImpactSpeed", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float minRollSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minRollSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minRollSpeed", value.AsString());
          }
       }
/// <summary>
/// Sound to play when body impacts with at least softImageSpeed but less than hardImpactSpeed. 
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName softImpactSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softImpactSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softImpactSound", value.AsString());
          }
       }
/// <summary>
/// Minimum speed at which this object must be travelling for the soft impact sound to be played.
/// </summary>
[MemberGroup("")]
public float softImpactSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softImpactSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softImpactSpeed", value.AsString());
          }
       }
/// <summary>
/// The minimum velocity at which the soft splash sound will be played when impacting water.\n
/// </summary>
[MemberGroup("Sounds")]
public float softSplashSoundVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softSplashSoundVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".softSplashSoundVelocity", value.AsString());
          }
       }
[MemberGroup("Particle Effects")]
public arrayObject<ParticleEmitterData> splashEmitter;
/// <summary>
/// The simulated frequency modulation of a splash generated by this object. Multiplied along with speed and time elapsed when determining splash emition rate.\n
/// </summary>
[MemberGroup("Particle Effects")]
public float splashFreqMod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashFreqMod").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashFreqMod", value.AsString());
          }
       }
/// <summary>
/// The threshold speed at which we consider the object's movement to have stopped when updating splash effects.\n
/// </summary>
[MemberGroup("Particle Effects")]
public float splashVelEpsilon
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashVelEpsilon").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashVelEpsilon", value.AsString());
          }
       }
/// <summary>
/// Maximum height from the ground at which the object will generate dust.\n
/// </summary>
[MemberGroup("Particle Effects")]
public float triggerDustHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".triggerDustHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".triggerDustHeight", value.AsString());
          }
       }
/// <summary>
/// The scalar applied to the vertical portion of the velocity drag acting on a object.
/// </summary>
[MemberGroup("Forces")]
public float vertFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".vertFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".vertFactor", value.AsString());
          }
       }
/// <summary>
/// The AudioProfile will be used to produce sounds when a water wake is displayed.\n
/// </summary>
[MemberGroup("Sounds")]
public TypeSFXTrackName waterWakeSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".waterWakeSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".waterWakeSound", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public RigidShapeData_Base (){splashEmitter = new arrayObject<ParticleEmitterData>(2,"splashEmitter","T3DObject",false,this);    
}
}}
