


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
    [TypeConverter(typeof(TypeConverterGeneric<ForestWindEmitter_Base>))]
    public partial class ForestWindEmitter_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestWindEmitter_Base ts, string simobjectid)
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
        public static bool operator !=(ForestWindEmitter_Base ts, string simobjectid)
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
        public static implicit operator string( ForestWindEmitter_Base ts)
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
        public static implicit operator ForestWindEmitter_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ForestWindEmitter_Base) Omni.self.getSimObject(simobjectid,typeof(ForestWindEmitter_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ForestWindEmitter_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestWindEmitter_Base(int simobjectid)
            {
            return  (ForestWindEmitter) Omni.self.getSimObject((uint)simobjectid,typeof(ForestWindEmitter_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ForestWindEmitter_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestWindEmitter_Base(uint simobjectid)
            {
            return  (ForestWindEmitter_Base) Omni.self.getSimObject(simobjectid,typeof(ForestWindEmitter_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The frequency of gusting in seconds. 
/// </summary>
[MemberGroup("ForestWind")]
public float gustFrequency
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gustFrequency").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gustFrequency", value.AsString());
          }
       }
/// <summary>
/// The maximum strength of a gust. 
/// </summary>
[MemberGroup("ForestWind")]
public float gustStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gustStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gustStrength", value.AsString());
          }
       }
/// <summary>
/// The amount of random wobble added to gust and turbulence vectors. 
/// </summary>
[MemberGroup("ForestWind")]
public float gustWobbleStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gustWobbleStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gustWobbleStrength", value.AsString());
          }
       }
/// <summary>
/// The amount of degrees the wind direction can drift (both positive and negative). 
/// </summary>
[MemberGroup("ForestWind")]
public float gustYawAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gustYawAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gustYawAngle", value.AsString());
          }
       }
/// <summary>
/// The frequency of wind yaw drift, in seconds. 
/// </summary>
[MemberGroup("ForestWind")]
public float gustYawFrequency
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gustYawFrequency").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gustYawFrequency", value.AsString());
          }
       }
/// <summary>
/// Determines if the emitter is mounted to another object. 
/// </summary>
[MemberGroup("ForestWind")]
public bool hasMount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hasMount").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hasMount", value.AsString());
          }
       }
/// <summary>
/// Determines if the emitter is a global direction or local radial emitter. 
/// </summary>
[MemberGroup("ForestWind")]
public bool radialEmitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".radialEmitter").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".radialEmitter", value.AsString());
          }
       }
/// <summary>
/// The radius of the emitter for local radial emitters. 
/// </summary>
[MemberGroup("ForestWind")]
public float radius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".radius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".radius", value.AsString());
          }
       }
/// <summary>
/// The strength of the wind force. 
/// </summary>
[MemberGroup("ForestWind")]
public float strength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".strength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".strength", value.AsString());
          }
       }
/// <summary>
/// The frequency of gust turbulence, in seconds. 
/// </summary>
[MemberGroup("ForestWind")]
public float turbulenceFrequency
       {
       get
          {
          return Omni.self.GetVar(_ID + ".turbulenceFrequency").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".turbulenceFrequency", value.AsString());
          }
       }
/// <summary>
/// The strength of gust turbulence. 
/// </summary>
[MemberGroup("ForestWind")]
public float turbulenceStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".turbulenceStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".turbulenceStrength", value.AsString());
          }
       }
/// <summary>
/// Determines if the emitter will be counted in wind calculations. 
/// </summary>
[MemberGroup("ForestWind")]
public bool windEnabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windEnabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windEnabled", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Mounts the wind emitter to another scene object
/// 
///    @param objectID Unique ID of the object wind emitter should attach to
///    
///    @tsexample
///    // Wind emitter previously created and named %windEmitter
///    // Going to attach it to the player, making him a walking wind storm
///    %windEmitter.attachToObject(%player);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void attachToObject(uint objectID){

pInvokes.m_ts.fnForestWindEmitter_attachToObject(_ID, objectID);
}

#endregion
#region T3D Callbacks

#endregion
public ForestWindEmitter_Base (){}
}}
