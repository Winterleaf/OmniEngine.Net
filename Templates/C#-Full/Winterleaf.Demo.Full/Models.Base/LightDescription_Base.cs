


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
    [TypeConverter(typeof(TypeConverterGeneric<LightDescription_Base>))]
    public partial class LightDescription_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LightDescription_Base ts, string simobjectid)
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
        public static bool operator !=(LightDescription_Base ts, string simobjectid)
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
        public static implicit operator string( LightDescription_Base ts)
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
        public static implicit operator LightDescription_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (LightDescription_Base) Omni.self.getSimObject(simobjectid,typeof(LightDescription_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( LightDescription_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LightDescription_Base(int simobjectid)
            {
            return  (LightDescription) Omni.self.getSimObject((uint)simobjectid,typeof(LightDescription_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( LightDescription_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LightDescription_Base(uint simobjectid)
            {
            return  (LightDescription_Base) Omni.self.getSimObject(simobjectid,typeof(LightDescription_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The length of time in seconds for a single playback of the light animation 
/// </summary>
[MemberGroup("Light Animation")]
public float animationPeriod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".animationPeriod").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".animationPeriod", value.AsString());
          }
       }
/// <summary>
/// The phase used to offset the animation start time to vary the animation of nearby lights. 
/// </summary>
[MemberGroup("Light Animation")]
public float animationPhase
       {
       get
          {
          return Omni.self.GetVar(_ID + ".animationPhase").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".animationPhase", value.AsString());
          }
       }
/// <summary>
/// Datablock containing light animation information (LightAnimData) 
/// </summary>
[MemberGroup("Light Animation")]
public LightAnimData animationType
       {
       get
          {
          return Omni.self.GetVar(_ID + ".animationType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".animationType", value.ToString());
          }
       }
/// <summary>
/// Adjusts the lights power, 0 being off completely. 
/// </summary>
[MemberGroup("Light")]
public float brightness
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brightness").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brightness", value.AsString());
          }
       }
/// <summary>
/// Enables/disabled shadow casts by this light. 
/// </summary>
[MemberGroup("Light")]
public bool castShadows
       {
       get
          {
          return Omni.self.GetVar(_ID + ".castShadows").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".castShadows", value.AsString());
          }
       }
/// <summary>
/// Changes the base color hue of the light. 
/// </summary>
[MemberGroup("Light")]
public ColorF color
       {
       get
          {
          return Omni.self.GetVar(_ID + ".color").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".color", value.AsString());
          }
       }
/// <summary>
/// Globally scales all features of the light flare 
/// </summary>
[MemberGroup("Misc")]
public float flareScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flareScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flareScale", value.AsString());
          }
       }
/// <summary>
/// Datablock containing light flare information (LightFlareData) 
/// </summary>
[MemberGroup("Misc")]
public LightFlareData flareType
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flareType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".flareType", value.ToString());
          }
       }
/// <summary>
/// Controls the size (radius) of the light 
/// </summary>
[MemberGroup("Light")]
public float range
       {
       get
          {
          return Omni.self.GetVar(_ID + ".range").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".range", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Force an inspectPostApply call for the benefit of tweaking via the console
///    
///    Normally this functionality is only exposed to objects via the World Editor, once changes have been made. 
///    Exposing apply to script allows you to make changes to it on the fly without the World Editor.
/// 
///    @note This is intended for debugging and tweaking, not for game play
/// 
///    @tsexample
///    // Change a property of the light description
///    RocketLauncherLightDesc.brightness = 10;
///    // Make it so
///    RocketLauncherLightDesc.apply();
///    
///    @endtsexample
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void apply(){

pInvokes.m_ts.fnLightDescription_apply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public LightDescription_Base (){}
}}
