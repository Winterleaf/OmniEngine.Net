


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
    [TypeConverter(typeof(TypeConverterGeneric<VehicleData_Base>))]
    public partial class VehicleData_Base: ShapeBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(VehicleData_Base ts, string simobjectid)
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
        public static bool operator !=(VehicleData_Base ts, string simobjectid)
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
        public static implicit operator string( VehicleData_Base ts)
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
        public static implicit operator VehicleData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (VehicleData_Base) Omni.self.getSimObject(simobjectid,typeof(VehicleData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( VehicleData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator VehicleData_Base(int simobjectid)
            {
            return  (VehicleData) Omni.self.getSimObject((uint)simobjectid,typeof(VehicleData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( VehicleData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator VehicleData_Base(uint simobjectid)
            {
            return  (VehicleData_Base) Omni.self.getSimObject(simobjectid,typeof(VehicleData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Collision friction coefficient.\nHow well this object will slide against    objects it collides with. 
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
/// Collision 'bounciness'.\nNormally in the range 0 (not bouncy at all) to    1 (100% bounciness). 
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
/// How quickly the camera moves back towards the vehicle when stopped.\n\n   @see cameraLag. 
/// </summary>
[MemberGroup("")]
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
/// @brief How much the camera lags behind the vehicle depending on vehicle speed.\n\n   Increasing this value will make the camera fall further behind the vehicle    as it accelerates away.\n\n@see cameraDecay. 
/// </summary>
[MemberGroup("")]
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
/// Vertical (Z axis) height of the camera above the vehicle. 
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
/// If true, the camera will roll with the vehicle. If false, the camera will    always have the positive Z axis as up. 
/// </summary>
[MemberGroup("")]
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
/// @brief Damage to this vehicle after a collision (multiplied by collision    velocity).\n\nCurrently unused. 
/// </summary>
[MemberGroup("")]
public float collDamageMultiplier
       {
       get
          {
          return Omni.self.GetVar(_ID + ".collDamageMultiplier").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".collDamageMultiplier", value.AsString());
          }
       }
/// <summary>
/// Minimum collision velocity to cause damage to this vehicle.\nCurrently unused. 
/// </summary>
[MemberGroup("")]
public float collDamageThresholdVel
       {
       get
          {
          return Omni.self.GetVar(_ID + ".collDamageThresholdVel").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".collDamageThresholdVel", value.AsString());
          }
       }
/// <summary>
/// Minimum distance between objects for them to be considered as colliding. 
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
/// Maximum relative velocity between objects for collisions to be resolved    as contacts.\nVelocities greater than this are handled as collisions. 
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
[MemberGroup("")]
public arrayObject<ParticleEmitterData> damageEmitter;
[MemberGroup("")]
public arrayObject<Point3F> damageEmitterOffset;
[MemberGroup("")]
public arrayObject<float> damageLevelTolerance;
/// <summary>
/// Dust particle emitter.\n\n@see triggerDustHeight\n\n@see dustHeight
/// </summary>
[MemberGroup("")]
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
/// Height above ground at which to emit particles from the dustEmitter. 
/// </summary>
[MemberGroup("")]
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
/// Sound to play when exiting the water. 
/// </summary>
[MemberGroup("")]
public SFXProfile exitingWater
       {
       get
          {
          return Omni.self.GetVar(_ID + ".exitingWater");
          }
       set
          {
          Omni.self.SetVar(_ID + ".exitingWater", value.ToString());
          }
       }
/// <summary>
/// Minimum velocity when leaving the water for the exitingWater sound to play. 
/// </summary>
[MemberGroup("")]
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
/// @brief Sound to play on a 'hard' impact.\n\n   This sound is played if the impact speed = hardImpactSpeed.\n\n   @see hardImpactSpeed 
/// </summary>
[MemberGroup("")]
public SFXProfile hardImpactSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hardImpactSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".hardImpactSound", value.ToString());
          }
       }
/// <summary>
/// Minimum collision speed for the hardImpactSound to be played. 
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
/// Minimum velocity when entering the water for the imapactWaterHard sound    to play.\n\n@see impactWaterHard 
/// </summary>
[MemberGroup("")]
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
/// Sound to play when entering the water with speed = softSplashSoundVelocity    and  mediumSplashSoundVelocity. 
/// </summary>
[MemberGroup("")]
public SFXProfile impactWaterEasy
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactWaterEasy");
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactWaterEasy", value.ToString());
          }
       }
/// <summary>
/// Sound to play when entering the water with speed = hardSplashSoundVelocity. 
/// </summary>
[MemberGroup("")]
public SFXProfile impactWaterHard
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactWaterHard");
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactWaterHard", value.ToString());
          }
       }
/// <summary>
/// Sound to play when entering the water with speed = mediumSplashSoundVelocity    and  hardSplashSoundVelocity. 
/// </summary>
[MemberGroup("")]
public SFXProfile impactWaterMedium
       {
       get
          {
          return Omni.self.GetVar(_ID + ".impactWaterMedium");
          }
       set
          {
          Omni.self.SetVar(_ID + ".impactWaterMedium", value.ToString());
          }
       }
/// <summary>
/// Number of integration steps per tick.\nIncrease this to improve simulation    stability (also increases simulation processing time). 
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
/// @brief Energy amount to drain for each tick the vehicle is jetting.\n\n   Once the vehicle's energy level reaches 0, it will no longer be able to jet. 
/// </summary>
[MemberGroup("")]
public float jetEnergyDrain
       {
       get
          {
          return Omni.self.GetVar(_ID + ".jetEnergyDrain").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".jetEnergyDrain", value.AsString());
          }
       }
/// <summary>
/// @brief Additional force applied to the vehicle when it is jetting.\n\n   For WheeledVehicles, the force is applied in the forward direction. For    FlyingVehicles, the force is applied in the thrust direction. 
/// </summary>
[MemberGroup("")]
public float jetForce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".jetForce").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".jetForce", value.AsString());
          }
       }
/// <summary>
/// @brief Define the box used to estimate the vehicle's moment of inertia.\n\n   Currently only used by WheeledVehicle; other vehicle types use a    unit sphere to compute inertia. 
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
/// Defines the vehicle's center of mass (offset from the origin of the model). 
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
/// Maximum drag coefficient.\nCurrently unused. 
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
/// Maximum yaw (horizontal) and pitch (vertical) steering angle in radians. 
/// </summary>
[MemberGroup("")]
public float maxSteeringAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxSteeringAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxSteeringAngle", value.AsString());
          }
       }
/// <summary>
/// Minimum velocity when entering the water for the imapactWaterMedium sound    to play.\n\n@see impactWaterMedium 
/// </summary>
[MemberGroup("")]
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
/// Minimum drag coefficient.\nCurrently only used by FlyingVehicle. 
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
/// Minimum collision speed for the onImpact callback to be invoked. 
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
/// Minimum vehicle energy level to begin jetting. 
/// </summary>
[MemberGroup("")]
public float minJetEnergy
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minJetEnergy").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minJetEnergy", value.AsString());
          }
       }
/// <summary>
/// Unused 
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
/// Number of damageEmitterOffset values to use for each damageEmitter.\n\n   @see damageEmitterOffset 
/// </summary>
[MemberGroup("")]
public float numDmgEmitterAreas
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numDmgEmitterAreas").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numDmgEmitterAreas", value.AsString());
          }
       }
/// <summary>
/// If true, steering does not auto-centre while the vehicle is being steered by its driver. 
/// </summary>
[MemberGroup("")]
public bool powerSteering
       {
       get
          {
          return Omni.self.GetVar(_ID + ".powerSteering").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".powerSteering", value.AsString());
          }
       }
/// <summary>
/// @brief Sound to play on a 'soft' impact.\n\n   This sound is played if the impact speed is  hardImpactSpeed and =    softImpactSpeed.\n\n   @see softImpactSpeed 
/// </summary>
[MemberGroup("")]
public SFXProfile softImpactSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".softImpactSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".softImpactSound", value.ToString());
          }
       }
/// <summary>
/// Minimum collision speed for the softImpactSound to be played. 
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
/// Minimum velocity when entering the water for the imapactWaterEasy sound    to play.\n\n@see impactWaterEasy 
/// </summary>
[MemberGroup("")]
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
[MemberGroup("")]
public arrayObject<ParticleEmitterData> splashEmitter;
/// <summary>
/// @brief Number of splash particles to generate based on vehicle speed.\n\n   This value is multiplied by the current speed to determine how many    particles to generate each frame. 
/// </summary>
[MemberGroup("")]
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
/// Minimum speed when moving through water to generate splash particles. 
/// </summary>
[MemberGroup("")]
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
/// Rate at which the vehicle's steering returns to forwards when it is moving. 
/// </summary>
[MemberGroup("")]
public float steeringReturn
       {
       get
          {
          return Omni.self.GetVar(_ID + ".steeringReturn").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".steeringReturn", value.AsString());
          }
       }
/// <summary>
/// Amount of effect the vehicle's speed has on its rate of steering return. 
/// </summary>
[MemberGroup("")]
public float steeringReturnSpeedScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".steeringReturnSpeedScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".steeringReturnSpeedScale", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum height above surface to emit dust particles.\n\n   If the vehicle is less than triggerDustHeight above a static surface    with a material that has 'showDust' set to true, the vehicle will emit    particles from the dustEmitter. 
/// </summary>
[MemberGroup("")]
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
/// Looping sound to play while moving through the water. 
/// </summary>
[MemberGroup("")]
public SFXProfile waterWakeSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".waterWakeSound");
          }
       set
          {
          Omni.self.SetVar(_ID + ".waterWakeSound", value.ToString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the vehicle enters liquid.   @param obj the Vehicle object   @param coverage percentage of the vehicle's bounding box covered by the liquid   @param type type of liquid the vehicle has entered )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterLiquid(Vehicle obj, float coverage, string type){}

        /// <summary>
        /// Called when the vehicle leaves liquid.   @param obj the Vehicle object   @param type type of liquid the vehicle has left )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveLiquid(Vehicle obj, string type){}

#endregion
public VehicleData_Base (){damageEmitter = new arrayObject<ParticleEmitterData>(2+1,"damageEmitter","T3DObject",false,this);    
damageEmitterOffset = new arrayObject<Point3F>(2,"damageEmitterOffset","TypeVariable",false,this);    
damageLevelTolerance = new arrayObject<float>(2,"damageLevelTolerance","TypeVariable",false,this);    
splashEmitter = new arrayObject<ParticleEmitterData>(2,"splashEmitter","T3DObject",false,this);    
}
}}
