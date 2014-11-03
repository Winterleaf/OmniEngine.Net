


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
    [TypeConverter(typeof(TypeConverterGeneric<DebrisData_Base>))]
    public partial class DebrisData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DebrisData_Base ts, string simobjectid)
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
        public static bool operator !=(DebrisData_Base ts, string simobjectid)
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
        public static implicit operator string( DebrisData_Base ts)
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
        public static implicit operator DebrisData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (DebrisData_Base) Omni.self.getSimObject(simobjectid,typeof(DebrisData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( DebrisData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DebrisData_Base(int simobjectid)
            {
            return  (DebrisData) Omni.self.getSimObject((uint)simobjectid,typeof(DebrisData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( DebrisData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DebrisData_Base(uint simobjectid)
            {
            return  (DebrisData_Base) Omni.self.getSimObject(simobjectid,typeof(DebrisData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Radius at which the standard elasticity and friction apply.\n\nOnly used when useRaduisMass is true.\n@see useRadiusMass.\n
/// </summary>
[MemberGroup("Physical Properties")]
public float baseRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".baseRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".baseRadius", value.AsString());
          }
       }
/// <summary>
/// @brief Allowed variance in the value of numBounces.\n\nMust be less than numBounces.\n@see numBounces\n
/// </summary>
[MemberGroup("Physical Properties")]
public int bounceVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bounceVariance").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bounceVariance", value.AsString());
          }
       }
/// <summary>
/// @brief A floating-point value specifying how 'bouncy' this object is.\n\nMust be in the range of -10 to 10.\n
/// </summary>
[MemberGroup("Physical Properties")]
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
[MemberGroup("Datablocks")]
public arrayObject<ParticleEmitterData> emitters;
/// <summary>
/// @brief If true, this debris object will explode after it has bounced max times.\n\nBe sure to provide an ExplosionData datablock for this to take effect.\n@see explosion\n
/// </summary>
[MemberGroup("Behavior")]
public bool explodeOnMaxBounce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".explodeOnMaxBounce").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".explodeOnMaxBounce", value.AsString());
          }
       }
/// <summary>
/// @brief ExplosionData to spawn along with this debris object.\n\nThis is optional as not all Debris explode.\n
/// </summary>
[MemberGroup("Datablocks")]
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
/// @brief If true, this debris object will fade out when destroyed.\n\nThis fade occurs over the last second of the Debris' lifetime.\n
/// </summary>
[MemberGroup("Behavior")]
public bool fade
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fade").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fade", value.AsString());
          }
       }
/// <summary>
/// @brief A floating-point value specifying how much velocity is lost to impact and sliding friction.\n\nMust be in the range of -10 to 10.\n
/// </summary>
[MemberGroup("Physical Properties")]
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
/// How much gravity affects debris.
/// </summary>
[MemberGroup("Physical Properties")]
public float gravModifier
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gravModifier").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gravModifier", value.AsString());
          }
       }
/// <summary>
/// If true, this debris object will not collide with water, acting as if the water is not there.
/// </summary>
[MemberGroup("Behavior")]
public bool ignoreWater
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ignoreWater").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ignoreWater", value.AsString());
          }
       }
/// <summary>
/// @brief Amount of time until this debris object is destroyed.\n\nMust be in the range of 0 to 1000.\n@see lifetimeVariance
/// </summary>
[MemberGroup("Physical Properties")]
public float lifetime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetime", value.AsString());
          }
       }
/// <summary>
/// @brief Allowed variance in the value of lifetime.\n\nMust be less than lifetime.\n@see lifetime\n
/// </summary>
[MemberGroup("Physical Properties")]
public float lifetimeVariance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetimeVariance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetimeVariance", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum speed that this debris object will rotate.\n\nMust be in the range of -10000 to 10000.\n@see minSpinSpeed\n
/// </summary>
[MemberGroup("Physical Properties")]
public float maxSpinSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxSpinSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxSpinSpeed", value.AsString());
          }
       }
/// <summary>
/// @brief Minimum speed that this debris object will rotate.\n\nMust be in the range of -10000 to 1000, and must be less than maxSpinSpeed.\n@see maxSpinSpeed\n
/// </summary>
[MemberGroup("Physical Properties")]
public float minSpinSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minSpinSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minSpinSpeed", value.AsString());
          }
       }
/// <summary>
/// @brief How many times to allow this debris object to bounce until it either explodes, becomes static or snaps (defined in explodeOnMaxBounce, staticOnMaxBounce, snapOnMaxBounce).\n\n   Must be within the range of 0 to 10000.\n   @see bounceVariance\n
/// </summary>
[MemberGroup("Physical Properties")]
public int numBounces
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numBounces").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numBounces", value.AsString());
          }
       }
/// <summary>
/// @brief Object model to use for this debris object.\n\nThis shape is optional. You could have Debris made up of only particles.\n
/// </summary>
[MemberGroup("Display")]
public TypeShapeFilename shapeFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shapeFile").AsTypeShapeFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shapeFile", value.AsString());
          }
       }
/// <summary>
/// If true, this debris object will snap into a resting position on the last bounce.
/// </summary>
[MemberGroup("Behavior")]
public bool snapOnMaxBounce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapOnMaxBounce").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapOnMaxBounce", value.AsString());
          }
       }
/// <summary>
/// If true, this debris object becomes static after it has bounced max times.
/// </summary>
[MemberGroup("Behavior")]
public bool staticOnMaxBounce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".staticOnMaxBounce").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".staticOnMaxBounce", value.AsString());
          }
       }
/// <summary>
/// Max velocity magnitude.
/// </summary>
[MemberGroup("Physical Properties")]
public float terminalVelocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".terminalVelocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".terminalVelocity", value.AsString());
          }
       }
/// <summary>
/// @brief Texture imagemap to use for this debris object.\n\nNot used any more.\n
/// </summary>
[MemberGroup("Display")]
public String texture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texture").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texture", value.AsString());
          }
       }
/// <summary>
/// @brief Use mass calculations based on radius.\n\nAllows for the adjustment of elasticity and friction based on the Debris size.\n@see baseRadius\n
/// </summary>
[MemberGroup("Physical Properties")]
public bool useRadiusMass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useRadiusMass").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useRadiusMass", value.AsString());
          }
       }
/// <summary>
/// @brief Speed at which this debris object will move.\n\n@see velocityVariance\n
/// </summary>
[MemberGroup("Physical Properties")]
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
/// @brief Allowed variance in the value of velocity\n\nMust be less than velocity.\n@see velocity\n
/// </summary>
[MemberGroup("Physical Properties")]
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

#endregion
#region T3D Callbacks

#endregion
public DebrisData_Base (){emitters = new arrayObject<ParticleEmitterData>(2,"emitters","T3DObject",false,this);    
}
}}
