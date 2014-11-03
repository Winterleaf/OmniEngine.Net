


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
    [TypeConverter(typeof(TypeConverterGeneric<ScatterSky_Base>))]
    public partial class ScatterSky_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ScatterSky_Base ts, string simobjectid)
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
        public static bool operator !=(ScatterSky_Base ts, string simobjectid)
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
        public static implicit operator string( ScatterSky_Base ts)
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
        public static implicit operator ScatterSky_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ScatterSky_Base) Omni.self.getSimObject(simobjectid,typeof(ScatterSky_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ScatterSky_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ScatterSky_Base(int simobjectid)
            {
            return  (ScatterSky) Omni.self.getSimObject((uint)simobjectid,typeof(ScatterSky_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ScatterSky_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ScatterSky_Base(uint simobjectid)
            {
            return  (ScatterSky_Base) Omni.self.getSimObject(simobjectid,typeof(ScatterSky_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Modulates the ambient color of sunlight. 
/// </summary>
[MemberGroup("ScatterSky")]
public ColorF ambientScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ambientScale").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ambientScale", value.AsString());
          }
       }
/// <summary>
/// The horizontal angle of the sun measured clockwise from the positive Y world axis. This field is networked. 
/// </summary>
[MemberGroup("Orbit")]
public float azimuth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".azimuth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".azimuth", value.AsString());
          }
       }
/// <summary>
/// The brightness of the ScatterSky's light object. 
/// </summary>
[MemberGroup("Lighting")]
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
/// Enables/disables shadows cast by objects due to ScatterSky light. 
/// </summary>
[MemberGroup("Lighting")]
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
/// Tints the sky the color specified, the alpha controls the brigthness. The brightness is multipled by the value of colorizeAmt. 
/// </summary>
[MemberGroup("ScatterSky")]
public ColorF colorize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorize").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorize", value.AsString());
          }
       }
/// <summary>
/// Controls how much the the alpha component of colorize brigthens the sky. Setting to 0 returns default behavior. 
/// </summary>
[MemberGroup("ScatterSky")]
public float colorizeAmount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorizeAmount").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorizeAmount", value.AsString());
          }
       }
/// <summary>
/// The elevation angle of the sun above or below the horizon. This field is networked. 
/// </summary>
[MemberGroup("Orbit")]
public float elevation
       {
       get
          {
          return Omni.self.GetVar(_ID + ".elevation").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".elevation", value.AsString());
          }
       }
/// <summary>
/// Controls the contrast of the sky and sun during daytime. 
/// </summary>
[MemberGroup("ScatterSky")]
public float exposure
       {
       get
          {
          return Omni.self.GetVar(_ID + ".exposure").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".exposure", value.AsString());
          }
       }
/// <summary>
/// Changes the size and intensity of the flare. 
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
/// Datablock for the flare produced by the ScatterSky. 
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
/// Modulates the fog color. Note that this overrides the LevelInfo.fogColor      property, so you should not use LevelInfo.fogColor if the level contains      a ScatterSky object. 
/// </summary>
[MemberGroup("ScatterSky")]
public ColorF fogScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fogScale").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fogScale", value.AsString());
          }
       }
/// <summary>
/// The horizontal angle of the moon measured clockwise from the positive Y world axis. This is not animated by time or networked. 
/// </summary>
[MemberGroup("Orbit")]
public float moonAzimuth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moonAzimuth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moonAzimuth", value.AsString());
          }
       }
/// <summary>
/// The elevation angle of the moon above or below the horizon. This is not animated by time or networked. 
/// </summary>
[MemberGroup("Orbit")]
public float moonElevation
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moonElevation").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moonElevation", value.AsString());
          }
       }
/// <summary>
/// Enable or disable rendering of the moon sprite during night. 
/// </summary>
[MemberGroup("Night")]
public bool moonEnabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moonEnabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moonEnabled", value.AsString());
          }
       }
/// <summary>
/// Color of light cast by the directional light during night. 
/// </summary>
[MemberGroup("Night")]
public ColorF moonLightColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moonLightColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moonLightColor", value.AsString());
          }
       }
/// <summary>
/// Material for the moon sprite. 
/// </summary>
[MemberGroup("Night")]
public TypeMaterialName moonMat
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moonMat").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moonMat", value.AsString());
          }
       }
/// <summary>
/// Controls size the moon sprite renders, specified as a fractional amount of the screen height. 
/// </summary>
[MemberGroup("Night")]
public float moonScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".moonScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".moonScale", value.AsString());
          }
       }
/// <summary>
/// The ambient color during night. Also used for the sky color if useNightCubemap is false. 
/// </summary>
[MemberGroup("Night")]
public ColorF nightColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".nightColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".nightColor", value.AsString());
          }
       }
/// <summary>
/// Cubemap visible during night. 
/// </summary>
[MemberGroup("Night")]
public TypeCubemapName nightCubemap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".nightCubemap").AsTypeCubemapName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".nightCubemap", value.AsString());
          }
       }
/// <summary>
/// The fog color during night. 
/// </summary>
[MemberGroup("Night")]
public ColorF nightFogColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".nightFogColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".nightFogColor", value.AsString());
          }
       }
/// <summary>
/// Controls how blue the atmosphere is during the day. 
/// </summary>
[MemberGroup("ScatterSky")]
public float rayleighScattering
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rayleighScattering").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rayleighScattering", value.AsString());
          }
       }
/// <summary>
/// Global brightness and intensity applied to the sky and objects in the level. 
/// </summary>
[MemberGroup("ScatterSky")]
public float skyBrightness
       {
       get
          {
          return Omni.self.GetVar(_ID + ".skyBrightness").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".skyBrightness", value.AsString());
          }
       }
/// <summary>
/// Modulates the directional color of sunlight. 
/// </summary>
[MemberGroup("ScatterSky")]
public ColorF sunScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sunScale").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sunScale", value.AsString());
          }
       }
/// <summary>
/// Affects the size of the sun's disk. 
/// </summary>
[MemberGroup("ScatterSky")]
public float sunSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sunSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sunSize", value.AsString());
          }
       }
/// <summary>
/// Transition to the nightCubemap during night. If false we use nightColor. 
/// </summary>
[MemberGroup("Night")]
public bool useNightCubemap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useNightCubemap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useNightCubemap", value.AsString());
          }
       }
/// <summary>
/// Offsets the scatterSky to avoid canvas rendering. Use 5000 or greater for the initial adjustment 
/// </summary>
[MemberGroup("ScatterSky")]
public float zoffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zoffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zoffset", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Apply a full network update of all fields to all clients.
///                   )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void applyChanges(){

pInvokes.m_ts.fnScatterSky_applyChanges(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public ScatterSky_Base (){}
}}
