


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
    [TypeConverter(typeof(TypeConverterGeneric<SplashData_Base>))]
    public partial class SplashData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SplashData_Base ts, string simobjectid)
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
        public static bool operator !=(SplashData_Base ts, string simobjectid)
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
        public static implicit operator string( SplashData_Base ts)
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
        public static implicit operator SplashData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SplashData_Base) Omni.self.getSimObject(simobjectid,typeof(SplashData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SplashData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SplashData_Base(int simobjectid)
            {
            return  (SplashData) Omni.self.getSimObject((uint)simobjectid,typeof(SplashData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SplashData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SplashData_Base(uint simobjectid)
            {
            return  (SplashData_Base) Omni.self.getSimObject(simobjectid,typeof(SplashData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Constant acceleration value to place upon the splash effect.\n
/// </summary>
[MemberGroup("")]
public float acceleration
       {
       get
          {
          return Omni.self.GetVar(_ID + ".acceleration").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".acceleration", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<ColorF> colors;
/// <summary>
/// Time to delay, in milliseconds, before actually starting this effect.\n
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
/// Time variance for delayMS.\n
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
/// <summary>
/// Rotational angle to create a splash ring.\n
/// </summary>
[MemberGroup("")]
public float ejectionAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ejectionAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ejectionAngle", value.AsString());
          }
       }
/// <summary>
/// Frequency in which to emit splash rings.\n
/// </summary>
[MemberGroup("")]
public float ejectionFreq
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ejectionFreq").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ejectionFreq", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<ParticleEmitterData> emitter;
/// <summary>
/// ExplosionData object to create at the creation position of this splash effect.\n
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
/// Height for the splash to reach.\n
/// </summary>
[MemberGroup("")]
public float height
       {
       get
          {
          return Omni.self.GetVar(_ID + ".height").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".height", value.AsString());
          }
       }
/// <summary>
/// Lifetime for this effect, in milliseconds.\n
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
/// Time variance for lifetimeMS.\n
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
/// Number of ejection points in the splash ring.\n
/// </summary>
[MemberGroup("")]
public int numSegments
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numSegments").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numSegments", value.AsString());
          }
       }
/// <summary>
/// Lifetime, in milliseconds, for a splash ring.\n
/// </summary>
[MemberGroup("")]
public float ringLifetime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ringLifetime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ringLifetime", value.AsString());
          }
       }
/// <summary>
/// The scale of this splashing effect, defined as the F32 points X, Y, Z.\n
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
/// SFXProfile effect to play.\n
/// </summary>
[MemberGroup("")]
public SFXProfile soundProfile
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
/// <summary>
/// Starting radius size of a splash ring.\n
/// </summary>
[MemberGroup("")]
public float startRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".startRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".startRadius", value.AsString());
          }
       }
/// <summary>
/// Factor in which to apply the texture to the splash ring, 0.0f - 1.0f.\n
/// </summary>
[MemberGroup("")]
public float texFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texFactor", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<String> texture;
/// <summary>
/// Amount to wrap the texture around the splash ring, 0.0f - 1.0f.\n
/// </summary>
[MemberGroup("")]
public float texWrap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texWrap").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texWrap", value.AsString());
          }
       }
[MemberGroup("")]
public arrayObject<float> times;
/// <summary>
/// Velocity for the splash effect to travel.\n
/// </summary>
[MemberGroup("")]
public float velocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".velocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".velocity", value.AsString());
          }
       }
/// <summary>
/// Width for the X and Y coordinates to create this effect within.
/// </summary>
[MemberGroup("")]
public float width
       {
       get
          {
          return Omni.self.GetVar(_ID + ".width").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".width", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SplashData_Base (){colors = new arrayObject<ColorF>(4,"colors","TypeVariable",false,this);    
emitter = new arrayObject<ParticleEmitterData>(3,"emitter","T3DObject",false,this);    
texture = new arrayObject<String>(2,"texture","TypeVariable",false,this);    
times = new arrayObject<float>(4,"times","TypeVariable",false,this);    
}
}}
