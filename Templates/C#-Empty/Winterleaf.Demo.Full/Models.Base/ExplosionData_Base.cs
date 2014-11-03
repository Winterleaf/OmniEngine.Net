


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
    [TypeConverter(typeof(TypeConverterGeneric<ExplosionData_Base>))]
    public partial class ExplosionData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ExplosionData_Base ts, string simobjectid)
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
        public static bool operator !=(ExplosionData_Base ts, string simobjectid)
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
        public static implicit operator string( ExplosionData_Base ts)
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
        public static implicit operator ExplosionData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ExplosionData_Base) Omni.self.getSimObject(simobjectid,typeof(ExplosionData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ExplosionData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ExplosionData_Base(int simobjectid)
            {
            return  (ExplosionData) Omni.self.getSimObject((uint)simobjectid,typeof(ExplosionData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ExplosionData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ExplosionData_Base(uint simobjectid)
            {
            return  (ExplosionData_Base) Omni.self.getSimObject(simobjectid,typeof(ExplosionData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Amplitude of camera shaking, defined in the \X Y Z\ axes.\n\n   Set any value to 0 to disable shaking in that axis. 
/// </summary>
[MemberGroup("")]
public Point3F camShakeAmp
       {
       get
          {
          return Omni.self.GetVar(_ID + ".camShakeAmp").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".camShakeAmp", value.AsString());
          }
       }
/// <summary>
/// Duration (in seconds) to shake the camera. 
/// </summary>
[MemberGroup("")]
public float camShakeDuration
       {
       get
          {
          return Omni.self.GetVar(_ID + ".camShakeDuration").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".camShakeDuration", value.AsString());
          }
       }
/// <summary>
/// Falloff value for the camera shake. 
/// </summary>
[MemberGroup("")]
public float camShakeFalloff
       {
       get
          {
          return Omni.self.GetVar(_ID + ".camShakeFalloff").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".camShakeFalloff", value.AsString());
          }
       }
/// <summary>
/// Frequency of camera shaking, defined in the \X Y Z\ axes. 
/// </summary>
[MemberGroup("")]
public Point3F camShakeFreq
       {
       get
          {
          return Omni.self.GetVar(_ID + ".camShakeFreq").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".camShakeFreq", value.AsString());
          }
       }
/// <summary>
/// Radial distance that a camera's position must be within relative to the    center of the explosion to be shaken. 
/// </summary>
[MemberGroup("")]
public float camShakeRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".camShakeRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".camShakeRadius", value.AsString());
          }
       }
/// <summary>
/// List of DebrisData objects to spawn with this explosion. 
/// </summary>
[MemberGroup("")]
public DebrisData debris
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debris");
          }
       set
          {
          Omni.self.SetVar(_ID + ".debris", value.ToString());
          }
       }
/// <summary>
/// Number of debris objects to create. 
/// </summary>
[MemberGroup("")]
public int debrisNum
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisNum").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisNum", value.AsString());
          }
       }
/// <summary>
/// Variance in the number of debris objects to create (must be from 0 - debrisNum). 
/// </summary>
[MemberGroup("")]
public int debrisNumVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisNumVariance").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisNumVariance", value.AsString());
          }
       }
/// <summary>
/// Maximum reference angle, from the vertical plane, to eject debris from. 
/// </summary>
[MemberGroup("")]
public float debrisPhiMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisPhiMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisPhiMax", value.AsString());
          }
       }
/// <summary>
/// Minimum reference angle, from the vertical plane, to eject debris from. 
/// </summary>
[MemberGroup("")]
public float debrisPhiMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisPhiMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisPhiMin", value.AsString());
          }
       }
/// <summary>
/// Maximum angle, from the horizontal plane, to eject debris from. 
/// </summary>
[MemberGroup("")]
public float debrisThetaMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisThetaMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisThetaMax", value.AsString());
          }
       }
/// <summary>
/// Minimum angle, from the horizontal plane, to eject debris from. 
/// </summary>
[MemberGroup("")]
public float debrisThetaMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisThetaMin").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisThetaMin", value.AsString());
          }
       }
/// <summary>
/// Velocity to toss debris at. 
/// </summary>
[MemberGroup("")]
public float debrisVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisVelocity", value.AsString());
          }
       }
/// <summary>
/// Variance in the debris initial velocity (must be = 0). 
/// </summary>
[MemberGroup("")]
public float debrisVelocityVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".debrisVelocityVariance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".debrisVelocityVariance", value.AsString());
          }
       }
/// <summary>
/// Amount of time, in milliseconds, to delay the start of the explosion effect    from the creation of the Explosion object. 
/// </summary>
[MemberGroup("")]
public int delayMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".delayMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".delayMS", value.AsString());
          }
       }
/// <summary>
/// Variance, in milliseconds, of delayMS. 
/// </summary>
[MemberGroup("")]
public int delayVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".delayVariance").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".delayVariance", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<ParticleEmitterData> emitter;
/// <summary>
/// \X Y Z\ scale factor applied to the explosionShape model at the start    of the explosion. 
/// </summary>
[MemberGroup("")]
public Point3F explosionScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".explosionScale").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".explosionScale", value.AsString());
          }
       }
/// <summary>
/// @brief Optional DTS or DAE shape to place at the center of the explosion.\n\n   The iambient/i animation of this model will be played automatically at    the start of the explosion. 
/// </summary>
[MemberGroup("")]
public TypeShapeFilename explosionShape
       {
       get
          {
          return Omni.self.GetVar(_ID + ".explosionShape").AsTypeShapeFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".explosionShape", value.AsString());
          }
       }
/// <summary>
/// Controls whether the visual effects of the explosion always face the camera. 
/// </summary>
[MemberGroup("")]
public bool faceViewer
       {
       get
          {
          return Omni.self.GetVar(_ID + ".faceViewer").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".faceViewer", value.AsString());
          }
       }
/// <summary>
/// @brief Lifetime, in milliseconds, of the Explosion object.\n\n   @note If explosionShape is defined and contains an iambient/i animation,    this field is ignored, and the playSpeed scaled duration of the animation    is used instead. 
/// </summary>
[MemberGroup("")]
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
/// Variance, in milliseconds, of the lifetimeMS of the Explosion object.\n 
/// </summary>
[MemberGroup("")]
public int lifetimeVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetimeVariance").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetimeVariance", value.AsString());
          }
       }
/// <summary>
/// @brief Final brightness of the PointLight created by this explosion.\n\n   @see lightStartBrightness 
/// </summary>
[MemberGroup("")]
public float lightEndBrightness
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightEndBrightness").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightEndBrightness", value.AsString());
          }
       }
/// <summary>
/// @brief Final color of the PointLight created by this explosion.\n\n   @see lightStartColor 
/// </summary>
[MemberGroup("")]
public ColorF lightEndColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightEndColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightEndColor", value.AsString());
          }
       }
/// <summary>
/// @brief Final radius of the PointLight created by this explosion.\n\n   @see lightStartRadius 
/// </summary>
[MemberGroup("")]
public float lightEndRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightEndRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightEndRadius", value.AsString());
          }
       }
/// <summary>
/// Distance (in the explosion normal direction) of the PointLight position    from the explosion center. 
/// </summary>
[MemberGroup("")]
public float lightNormalOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightNormalOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightNormalOffset", value.AsString());
          }
       }
/// <summary>
/// @brief Initial brightness of the PointLight created by this explosion.\n\n   Brightness is linearly interpolated from lightStartBrightness to    lightEndBrightness over the lifetime of the explosion.\n   @see lifetimeMS 
/// </summary>
[MemberGroup("")]
public float lightStartBrightness
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightStartBrightness").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightStartBrightness", value.AsString());
          }
       }
/// <summary>
/// @brief Initial color of the PointLight created by this explosion.\n\n   Color is linearly interpolated from lightStartColor to lightEndColor    over the lifetime of the explosion.\n   @see lifetimeMS 
/// </summary>
[MemberGroup("")]
public ColorF lightStartColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightStartColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightStartColor", value.AsString());
          }
       }
/// <summary>
/// @brief Initial radius of the PointLight created by this explosion.\n\n   Radius is linearly interpolated from lightStartRadius to lightEndRadius    over the lifetime of the explosion.\n   @see lifetimeMS 
/// </summary>
[MemberGroup("")]
public float lightStartRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lightStartRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lightStartRadius", value.AsString());
          }
       }
/// <summary>
/// @brief Offset distance (in a random direction) of the center of the explosion    from the Explosion object position.\n\n   Most often used to create some variance in position for subExplosion effects. 
/// </summary>
[MemberGroup("")]
public float offset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".offset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".offset", value.AsString());
          }
       }
/// <summary>
/// @brief Density of the particle cloud created at the start of the explosion.\n\n   @see particleEmitter 
/// </summary>
[MemberGroup("")]
public int particleDensity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".particleDensity").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".particleDensity", value.AsString());
          }
       }
/// <summary>
/// @brief Emitter used to generate a cloud of particles at the start of the explosion.\n\n   Explosions can generate two different particle effects. The first is a    single burst of particles at the start of the explosion emitted in a    spherical cloud using particleEmitter.\n\n   The second effect spawns the list of ParticleEmitters given by the emitter[]    field. These emitters generate particles in the normal way throughout the    lifetime of the explosion. 
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
/// @brief Radial distance from the explosion center at which cloud particles    are emitted.\n\n   @see particleEmitter 
/// </summary>
[MemberGroup("")]
public float particleRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".particleRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".particleRadius", value.AsString());
          }
       }
/// <summary>
/// Time scale at which to play the explosionShape iambient/i sequence. 
/// </summary>
[MemberGroup("")]
public float playSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".playSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".playSpeed", value.AsString());
          }
       }
/// <summary>
/// Controls whether the camera shakes during this explosion. 
/// </summary>
[MemberGroup("")]
public bool shakeCamera
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shakeCamera").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shakeCamera", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<Point3F> sizes;
/// <summary>
/// Non-looping sound effect that will be played at the start of the explosion. 
/// </summary>
[MemberGroup("")]
public SFXTrack soundProfile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".soundProfile");
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundProfile", value.ToString());
          }
       }
[MemberGroup("")]
public arrayObject<ExplosionData> subExplosion;
[MemberGroup("")]
public arrayObject<float> times;

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public ExplosionData_Base (){emitter = new arrayObject<ParticleEmitterData>(4,"emitter","T3DObject",false,this);    
sizes = new arrayObject<Point3F>(4,"sizes","TypeVariable",false,this);    
subExplosion = new arrayObject<ExplosionData>(5,"subExplosion","T3DObject",false,this);    
times = new arrayObject<float>(4,"times","TypeVariable",false,this);    
}
}}
