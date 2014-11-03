


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
    [TypeConverter(typeof(TypeConverterGeneric<LevelInfo_Base>))]
    public partial class LevelInfo_Base: NetObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LevelInfo_Base ts, string simobjectid)
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
        public static bool operator !=(LevelInfo_Base ts, string simobjectid)
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
        public static implicit operator string( LevelInfo_Base ts)
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
        public static implicit operator LevelInfo_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (LevelInfo_Base) Omni.self.getSimObject(simobjectid,typeof(LevelInfo_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( LevelInfo_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LevelInfo_Base(int simobjectid)
            {
            return  (LevelInfo) Omni.self.getSimObject((uint)simobjectid,typeof(LevelInfo_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( LevelInfo_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LevelInfo_Base(uint simobjectid)
            {
            return  (LevelInfo_Base) Omni.self.getSimObject(simobjectid,typeof(LevelInfo_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Enable expanded support for mixing static and dynamic lighting (more costly) 
/// </summary>
[MemberGroup("Lighting")]
public bool advancedLightmapSupport
       {
       get
          {
          return Omni.self.GetVar(_ID + ".advancedLightmapSupport").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".advancedLightmapSupport", value.AsString());
          }
       }
/// <summary>
/// Interpolation curve to use for blending from one ambient light color to a different one. 
/// </summary>
[MemberGroup("Lighting")]
public EaseF ambientLightBlendCurve
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ambientLightBlendCurve").AsEaseF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ambientLightBlendCurve", value.AsString());
          }
       }
/// <summary>
/// Number of seconds it takes to blend from one ambient light color to a different one. 
/// </summary>
[MemberGroup("Lighting")]
public float ambientLightBlendPhase
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ambientLightBlendPhase").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ambientLightBlendPhase", value.AsString());
          }
       }
/// <summary>
/// The color used to clear the background before the scene or any GUIs are rendered. 
/// </summary>
[MemberGroup("LevelInfo")]
public ColorI canvasClearColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".canvasClearColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".canvasClearColor", value.AsString());
          }
       }
/// <summary>
/// NearPlane bias used when rendering Decal and DecalRoad. This should be tuned to the visibleDistance in your level. 
/// </summary>
[MemberGroup("Visibility")]
public float decalBias
       {
       get
          {
          return Omni.self.GetVar(_ID + ".decalBias").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".decalBias", value.AsString());
          }
       }
/// <summary>
/// A height in meters for altitude fog falloff. 
/// </summary>
[MemberGroup("Fog")]
public float fogAtmosphereHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fogAtmosphereHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fogAtmosphereHeight", value.AsString());
          }
       }
/// <summary>
/// The default color for the scene fog. 
/// </summary>
[MemberGroup("Fog")]
public ColorF fogColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fogColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fogColor", value.AsString());
          }
       }
/// <summary>
/// The 0 to 1 density value for the exponential fog falloff. 
/// </summary>
[MemberGroup("Fog")]
public float fogDensity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fogDensity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fogDensity", value.AsString());
          }
       }
/// <summary>
/// An offset from the camera in meters for moving the start of the fog effect. 
/// </summary>
[MemberGroup("Fog")]
public float fogDensityOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fogDensityOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fogDensityOffset", value.AsString());
          }
       }
/// <summary>
/// Point4F(left, right, top, bottom) - Offset to allow non axis aligned frustum. For full frustum use (0,1,0,1) 
/// </summary>
[MemberGroup("Visibility")]
public Point4F frustumOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".frustumOffset").AsPoint4F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".frustumOffset", value.AsString());
          }
       }
/// <summary>
/// Closest distance from the camera's position to render the world. 
/// </summary>
[MemberGroup("Visibility")]
public float nearClip
       {
       get
          {
          return Omni.self.GetVar(_ID + ".nearClip").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".nearClip", value.AsString());
          }
       }
/// <summary>
/// The global ambient sound environment. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXAmbienceName soundAmbience
       {
       get
          {
          return Omni.self.GetVar(_ID + ".soundAmbience").AsTypeSFXAmbienceName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundAmbience", value.AsString());
          }
       }
/// <summary>
/// The distance attenuation model to use. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXDistanceModel soundDistanceModel
       {
       get
          {          return (TypeSFXDistanceModel) Omni.self.GetVar(_ID + ".soundDistanceModel");
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundDistanceModel", value.ToString());
          }
       }
/// <summary>
/// Furthest distance fromt he camera's position to render the world. 
/// </summary>
[MemberGroup("Visibility")]
public float visibleDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".visibleDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".visibleDistance", value.AsString());
          }
       }
/// <summary>
/// Furthest distance fromt he camera's position to render players. 
/// </summary>
[MemberGroup("Visibility")]
public float visibleDistance_Ghost
       {
       get
          {
          return Omni.self.GetVar(_ID + ".visibleDistance_Ghost").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".visibleDistance_Ghost", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ( LevelInfo, setNearClip, void, 3, 3, ( F32 nearClip ))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNearClip(string a2){

pInvokes.m_ts.fnLevelInfo_setNearClip(_ID, a2);
}

#endregion
#region T3D Callbacks

#endregion
public LevelInfo_Base (){}
}}
