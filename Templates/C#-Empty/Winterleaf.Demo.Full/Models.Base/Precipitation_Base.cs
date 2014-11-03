


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
    [TypeConverter(typeof(TypeConverterGeneric<Precipitation_Base>))]
    public partial class Precipitation_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Precipitation_Base ts, string simobjectid)
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
        public static bool operator !=(Precipitation_Base ts, string simobjectid)
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
        public static implicit operator string( Precipitation_Base ts)
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
        public static implicit operator Precipitation_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Precipitation_Base) Omni.self.getSimObject(simobjectid,typeof(Precipitation_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Precipitation_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Precipitation_Base(int simobjectid)
            {
            return  (Precipitation) Omni.self.getSimObject((uint)simobjectid,typeof(Precipitation_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Precipitation_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Precipitation_Base(uint simobjectid)
            {
            return  (Precipitation_Base) Omni.self.getSimObject(simobjectid,typeof(Precipitation_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Set to true to enable splash animations when drops collide with other surfaces. 
/// </summary>
[MemberGroup("Rendering")]
public bool animateSplashes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".animateSplashes").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".animateSplashes", value.AsString());
          }
       }
/// <summary>
/// Height (vertical dimension) of the precipitation box. 
/// </summary>
[MemberGroup("Precipitation")]
public float boxHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".boxHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".boxHeight", value.AsString());
          }
       }
/// <summary>
/// Width and depth (horizontal dimensions) of the precipitation box. 
/// </summary>
[MemberGroup("Precipitation")]
public float boxWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".boxWidth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".boxWidth", value.AsString());
          }
       }
/// <summary>
/// @brief Allow drops to collide with world objects.\n\n     If #animateSplashes is true, drops that collide with another object      will produce a simple splash animation.\n     @note This can be expensive as each drop will perform a raycast when      it is created to determine where it will hit. 
/// </summary>
[MemberGroup("Collision")]
public bool doCollision
       {
       get
          {
          return Omni.self.GetVar(_ID + ".doCollision").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".doCollision", value.AsString());
          }
       }
/// <summary>
/// @brief Length (in milliseconds) to display each drop frame.\n\n     If #dropAnimateMS = 0, drops select a single random frame at creation      that does not change throughout the drop's lifetime. If #dropAnimateMS       0, each drop cycles through the the available frames in the drop      texture at the given rate. 
/// </summary>
[MemberGroup("Rendering")]
public int dropAnimateMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropAnimateMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropAnimateMS", value.AsString());
          }
       }
/// <summary>
/// Size of each drop of precipitation. This will scale the texture. 
/// </summary>
[MemberGroup("Rendering")]
public float dropSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropSize", value.AsString());
          }
       }
/// <summary>
/// The distance at which drops begin to fade out. 
/// </summary>
[MemberGroup("Rendering")]
public float fadeDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeDist", value.AsString());
          }
       }
/// <summary>
/// The distance at which drops are completely faded out. 
/// </summary>
[MemberGroup("Rendering")]
public float fadeDistEnd
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeDistEnd").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeDistEnd", value.AsString());
          }
       }
/// <summary>
/// @brief Controls whether the Precipitation system follows the camera      or remains where it is first placed in the scene.\n\n     Set to true to make it seem like it is raining everywhere in the      level (ie. the Player will always be in the rain). Set to false      to have a single area affected by rain (ie. the Player can move in      and out of the rainy area). 
/// </summary>
[MemberGroup("Movement")]
public bool followCam
       {
       get
          {
          return Omni.self.GetVar(_ID + ".followCam").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".followCam", value.AsString());
          }
       }
/// <summary>
/// Set to 0 to disable the glow or or use it to control the intensity of each channel. 
/// </summary>
[MemberGroup("Rendering")]
public ColorF glowIntensity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".glowIntensity").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".glowIntensity", value.AsString());
          }
       }
/// <summary>
/// Allow drops to collide with Player objects; only valid if #doCollision is true. 
/// </summary>
[MemberGroup("Collision")]
public bool hitPlayers
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hitPlayers").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hitPlayers", value.AsString());
          }
       }
/// <summary>
/// Allow drops to collide with Vehicle objects; only valid if #doCollision is true. 
/// </summary>
[MemberGroup("Collision")]
public bool hitVehicles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".hitVehicles").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".hitVehicles", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum mass of a drop.\n\n     Drop mass determines how strongly the drop is affected by wind and      turbulence. On creation, the drop will be assigned a random speed      between #minMass and #minMass. 
/// </summary>
[MemberGroup("Movement")]
public float maxMass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxMass").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxMass", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum speed at which a drop will fall.\n\n     On creation, the drop will be assigned a random speed between #minSpeed      and #maxSpeed. 
/// </summary>
[MemberGroup("Movement")]
public float maxSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxSpeed", value.AsString());
          }
       }
/// <summary>
/// Radius at which precipitation drops spiral when turbulence is enabled. 
/// </summary>
[MemberGroup("Turbulence")]
public float maxTurbulence
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxTurbulence").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxTurbulence", value.AsString());
          }
       }
/// <summary>
/// @brief Minimum mass of a drop.\n\n     Drop mass determines how strongly the drop is affected by wind and      turbulence. On creation, the drop will be assigned a random speed      between #minMass and #minMass. 
/// </summary>
[MemberGroup("Movement")]
public float minMass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minMass").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minMass", value.AsString());
          }
       }
/// <summary>
/// @brief Minimum speed at which a drop will fall.\n\n     On creation, the drop will be assigned a random speed between #minSpeed      and #maxSpeed. 
/// </summary>
[MemberGroup("Movement")]
public float minSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minSpeed", value.AsString());
          }
       }
/// <summary>
/// @brief Maximum number of drops allowed to exist in the precipitation      box at any one time.\n\n     The actual number of drops in the effect depends on the current      percentage, which can change over time using modifyStorm(). 
/// </summary>
[MemberGroup("Precipitation")]
public int numDrops
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numDrops").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numDrops", value.AsString());
          }
       }
/// <summary>
/// @brief This enables precipitation rendering during reflection passes.\n\n     @note This is expensive. 
/// </summary>
[MemberGroup("Rendering")]
public bool reflect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflect").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflect", value.AsString());
          }
       }
/// <summary>
/// Set to true to include the camera velocity when calculating drop      rotation speed. 
/// </summary>
[MemberGroup("Rendering")]
public bool rotateWithCamVel
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rotateWithCamVel").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rotateWithCamVel", value.AsString());
          }
       }
/// <summary>
/// Lifetime of splashes in milliseconds. 
/// </summary>
[MemberGroup("Rendering")]
public int splashMS
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashMS").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashMS", value.AsString());
          }
       }
/// <summary>
/// Size of each splash animation when a drop collides with another surface. 
/// </summary>
[MemberGroup("Rendering")]
public float splashSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashSize", value.AsString());
          }
       }
/// <summary>
/// Speed at which precipitation drops spiral when turbulence is enabled. 
/// </summary>
[MemberGroup("Turbulence")]
public float turbulenceSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".turbulenceSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".turbulenceSpeed", value.AsString());
          }
       }
/// <summary>
/// Set to true to enable shading of the drops and splashes by the sun color. 
/// </summary>
[MemberGroup("Rendering")]
public bool useLighting
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useLighting").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useLighting", value.AsString());
          }
       }
/// <summary>
/// Set to true to make drops true (non axis-aligned) billboards. 
/// </summary>
[MemberGroup("Rendering")]
public bool useTrueBillboards
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useTrueBillboards").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useTrueBillboards", value.AsString());
          }
       }
/// <summary>
/// Check to enable turbulence. This causes precipitation drops to spiral      while falling. 
/// </summary>
[MemberGroup("Turbulence")]
public bool useTurbulence
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useTurbulence").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useTurbulence", value.AsString());
          }
       }
/// <summary>
/// Controls whether drops are affected by wind.\n     @see ForestWindEmitter 
/// </summary>
[MemberGroup("Movement")]
public bool useWind
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useWind").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useWind", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Smoothly change the maximum number of drops in the effect (from current 
///    value to #numDrops * @a percentage).
///    This method can be used to simulate a storm building or fading in intensity 
///    as the number of drops in the Precipitation box changes.
///    @param percentage New maximum number of drops value (as a percentage of 
///    #numDrops). Valid range is 0-1.
///    @param seconds Length of time (in seconds) over which to increase the drops 
///    percentage value. Set to 0 to change instantly.
///    @tsexample
///    %percentage = 0.5;  // The percentage, from 0 to 1, of the maximum drops to display
///    %seconds = 5.0;     // The length of time over which to make the change.
///    %precipitation.modifyStorm( %percentage, %seconds );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void modifyStorm(float percentage = 1.0f, float seconds = 5.0f){

pInvokes.m_ts.fnPrecipitation_modifyStorm(_ID, percentage, seconds);
}
/// <summary>
/// Sets the maximum number of drops in the effect, as a percentage of #numDrops.
///    The change occurs instantly (use modifyStorm() to change the number of drops 
///    over a period of time.
///    @param percentage New maximum number of drops value (as a percentage of 
///    #numDrops). Valid range is 0-1.
///    @tsexample
///    %percentage = 0.5;  // The percentage, from 0 to 1, of the maximum drops to display
///    %precipitation.setPercentage( %percentage );
///    @endtsexample
///    @see modifyStorm )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPercentage(float percentage = 1.0f){

pInvokes.m_ts.fnPrecipitation_setPercentage(_ID, percentage);
}
/// <summary>
/// Smoothly change the turbulence parameters over a period of time.
///    @param max New #maxTurbulence value. Set to 0 to disable turbulence.
///    @param speed New #turbulenceSpeed value.
///    @param seconds Length of time (in seconds) over which to interpolate the 
///    turbulence settings. Set to 0 to change instantly.
///    @tsexample
///    %turbulence = 0.5;     // Set the new turbulence value. Set to 0 to disable turbulence.
///    %speed = 5.0;          // The new speed of the turbulance effect.
///    %seconds = 5.0;        // The length of time over which to make the change.
///    %precipitation.setTurbulence( %turbulence, %speed, %seconds );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTurbulence(float max = 1.0f, float speed = 5.0f, float seconds = 5.0f){

pInvokes.m_ts.fnPrecipitation_setTurbulence(_ID, max, speed, seconds);
}

#endregion
#region T3D Callbacks

#endregion
public Precipitation_Base (){}
}}
