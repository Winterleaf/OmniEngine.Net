


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
    [TypeConverter(typeof(TypeConverterGeneric<LightBase_Base>))]
    public partial class LightBase_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LightBase_Base ts, string simobjectid)
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
        public static bool operator !=(LightBase_Base ts, string simobjectid)
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
        public static implicit operator string( LightBase_Base ts)
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
        public static implicit operator LightBase_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (LightBase_Base) Omni.self.getSimObject(simobjectid,typeof(LightBase_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( LightBase_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LightBase_Base(int simobjectid)
            {
            return  (LightBase) Omni.self.getSimObject((uint)simobjectid,typeof(LightBase_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( LightBase_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LightBase_Base(uint simobjectid)
            {
            return  (LightBase_Base) Omni.self.getSimObject(simobjectid,typeof(LightBase_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Toggles animation for the light on and off 
/// </summary>
[MemberGroup("Light Animation")]
public bool animate
       {
       get
          {
          return Omni.self.GetVar(_ID + ".animate").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".animate", value.AsString());
          }
       }
/// <summary>
/// The length of time in seconds for a single playback of the light animation (must be  0) 
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
/// Enables/Disables the object rendering and functionality in the scene. 
/// </summary>
[MemberGroup("Light")]
public bool isEnabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isEnabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isEnabled", value.AsString());
          }
       }
/// <summary>
/// Used for sorting of lights by the light manager. 		 Priority determines if a light has a stronger effect than, those with a lower value 
/// </summary>
[MemberGroup("Light")]
public float priority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".priority").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".priority", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Stops the light animation. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pauseAnimation(){

pInvokes.m_ts.fn_LightBase_pauseAnimation(_ID);
}
/// <summary>
/// ), ( [LightAnimData anim] )\t
///    Plays a light animation on the light.  If no LightAnimData is passed the 
///    existing one is played.
///    @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void playAnimation(string anim = ""){

pInvokes.m_ts.fn_LightBase_playAnimation(_ID, anim);
}
/// <summary>
/// @brief Toggles the light on and off
///    
///    @param state Turns the light on (true) or off (false)
/// 
///    @tsexample
///    // Disable the light
///    CrystalLight.setLightEnabled(false);
///    // Renable the light
///    CrystalLight.setLightEnabled(true);
///    
///    @endtsexample
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setLightEnabled(bool state){

pInvokes.m_ts.fnLightBase_setLightEnabled(_ID, state);
}

#endregion
#region T3D Callbacks

#endregion
public LightBase_Base (){}
}}
