


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
    [TypeConverter(typeof(TypeConverterGeneric<VolumetricFog_Base>))]
    public partial class VolumetricFog_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(VolumetricFog_Base ts, string simobjectid)
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
        public static bool operator !=(VolumetricFog_Base ts, string simobjectid)
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
        public static implicit operator string( VolumetricFog_Base ts)
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
        public static implicit operator VolumetricFog_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (VolumetricFog_Base) Omni.self.getSimObject(simobjectid,typeof(VolumetricFog_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( VolumetricFog_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator VolumetricFog_Base(int simobjectid)
            {
            return  (VolumetricFog) Omni.self.getSimObject((uint)simobjectid,typeof(VolumetricFog_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( VolumetricFog_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator VolumetricFog_Base(uint simobjectid)
            {
            return  (VolumetricFog_Base) Omni.self.getSimObject(simobjectid,typeof(VolumetricFog_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Object size in pixels at which the FX-fading kicks in (0 disables fading).
/// </summary>
[MemberGroup("VolumetricFogData")]
public float FadeSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FadeSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FadeSize", value.AsString());
          }
       }
/// <summary>
/// Fog color RGBA (Alpha is ignored)
/// </summary>
[MemberGroup("VolumetricFogData")]
public ColorI FogColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FogColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FogColor", value.AsString());
          }
       }
/// <summary>
/// Overal fog density value (0 disables the fog).
/// </summary>
[MemberGroup("VolumetricFogData")]
public float FogDensity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FogDensity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FogDensity", value.AsString());
          }
       }
/// <summary>
/// Set to true if volumetric fog should continue while submerged.
/// </summary>
[MemberGroup("VolumetricFogData")]
public bool IgnoreWater
       {
       get
          {
          return Omni.self.GetVar(_ID + ".IgnoreWater").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".IgnoreWater", value.AsString());
          }
       }
/// <summary>
/// Min size (in pixels) for fog to be rendered.
/// </summary>
[MemberGroup("VolumetricFogData")]
public float MinSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MinSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MinSize", value.AsString());
          }
       }
/// <summary>
/// Overall strength of the density modulation (0 disables modulation).
/// </summary>
[MemberGroup("VolumetricFogModulation")]
public float modStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".modStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".modStrength", value.AsString());
          }
       }
/// <summary>
/// Overall primary speed of the density modulation (x-speed(u) y-speed(v))
/// </summary>
[MemberGroup("VolumetricFogModulation")]
public Point2F PrimSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".PrimSpeed").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".PrimSpeed", value.AsString());
          }
       }
/// <summary>
/// Overall secundary speed of the density modulation (x-speed(u) y-speed(v))
/// </summary>
[MemberGroup("VolumetricFogModulation")]
public Point2F SecSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SecSpeed").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SecSpeed", value.AsString());
          }
       }
/// <summary>
/// Path and filename of the model file (.DTS, .DAE) to use for this Volume.
/// </summary>
[MemberGroup("VolumetricFogData")]
public TypeShapeFilename shapeName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shapeName").AsTypeShapeFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shapeName", value.AsString());
          }
       }
/// <summary>
/// A texture which contains Fogdensity modulator in the red channel and color with 1-green channel. No texture disables modulation.
/// </summary>
[MemberGroup("VolumetricFogModulation")]
public TypeImageFilename texture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texture").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texture", value.AsString());
          }
       }
/// <summary>
/// How many times the texture is mapped to the object.
/// </summary>
[MemberGroup("VolumetricFogModulation")]
public float tiles
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tiles").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tiles", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Changes the color of the fog.
/// 	@params new_color the new fog color (rgb 0-255, a is ignored.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void SetFogColor(ColorI new_color){

pInvokes.m_ts.fnVolumetricFog_SetFogColor(_ID, new_color.AsString());
}
/// <summary>
/// @brief Changes the color of the fog.
/// 	@params new_color the new fog color (rgb 0.0 - 1.0, a is ignored.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void SetFogColorF(ColorF new_color){

pInvokes.m_ts.fnVolumetricFog_SetFogColorF(_ID, new_color.AsString());
}
/// <summary>
/// @brief Changes the density of the fog.
/// 	@params new_density the new fog density.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void SetFogDensity(float new_density){

pInvokes.m_ts.fnVolumetricFog_SetFogDensity(_ID, new_density);
}
/// <summary>
/// @brief Changes the modulation of the fog.
/// 	@params new_strenght the new strength of the modulation.
/// 	@params new_speed1 the new speed (x y) of the modulation layer 1.
/// 	@params new_speed2 the new speed (x y) of the modulation layer 2.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void SetFogModulation(float new_strenght, Point2F new_speed1, Point2F new_speed2){

pInvokes.m_ts.fnVolumetricFog_SetFogModulation(_ID, new_strenght, new_speed1.AsString(), new_speed2.AsString());
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when an object enters the volume of the Fog instance.	@param obj the controlobject entering the fog.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterFog(string obj){}

        /// <summary>
        /// @brief Called when an object left the volume of the Fog instance.	@param obj the controlobject leaving the fog.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveFog(string obj){}

#endregion
public VolumetricFog_Base (){}
}}
