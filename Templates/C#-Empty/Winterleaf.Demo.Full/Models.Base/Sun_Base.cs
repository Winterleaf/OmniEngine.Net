


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
    [TypeConverter(typeof(TypeConverterGeneric<Sun_Base>))]
    public partial class Sun_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Sun_Base ts, string simobjectid)
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
        public static bool operator !=(Sun_Base ts, string simobjectid)
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
        public static implicit operator string( Sun_Base ts)
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
        public static implicit operator Sun_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Sun_Base) Omni.self.getSimObject(simobjectid,typeof(Sun_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Sun_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Sun_Base(int simobjectid)
            {
            return  (Sun) Omni.self.getSimObject((uint)simobjectid,typeof(Sun_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Sun_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Sun_Base(uint simobjectid)
            {
            return  (Sun_Base) Omni.self.getSimObject(simobjectid,typeof(Sun_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Color shading applied to surfaces not      in direct contact with light source, such as in the shadows or interiors.
/// </summary>
[MemberGroup("Lighting")]
public ColorF ambient
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ambient").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ambient", value.AsString());
          }
       }
/// <summary>
/// The horizontal angle of the sun measured clockwise from the positive Y world axis. 
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
/// Adjust the Sun's global contrast/intensity
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
/// Enables/disables shadows cast by objects due to Sun light
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
/// Color shading applied to surfaces in direct contact with light source.
/// </summary>
[MemberGroup("Lighting")]
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
/// Enable or disable rendering of the corona sprite. 
/// </summary>
[MemberGroup("Corona")]
public bool coronaEnabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coronaEnabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coronaEnabled", value.AsString());
          }
       }
/// <summary>
/// Texture for the corona sprite. 
/// </summary>
[MemberGroup("Corona")]
public TypeMaterialName coronaMaterial
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coronaMaterial").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coronaMaterial", value.AsString());
          }
       }
/// <summary>
/// Controls size the corona sprite renders, specified as a fractional amount of the screen height. 
/// </summary>
[MemberGroup("Corona")]
public float coronaScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coronaScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coronaScale", value.AsString());
          }
       }
/// <summary>
/// Modulates the corona sprite color ( if coronaUseLightColor is false ). 
/// </summary>
[MemberGroup("Corona")]
public ColorF coronaTint
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coronaTint").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coronaTint", value.AsString());
          }
       }
/// <summary>
/// Modulate the corona sprite color by the color of the light ( overrides coronaTint ). 
/// </summary>
[MemberGroup("Corona")]
public bool coronaUseLightColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coronaUseLightColor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coronaUseLightColor", value.AsString());
          }
       }
/// <summary>
/// The elevation angle of the sun above or below the horizon. 
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
/// Datablock for the flare produced by the Sun 
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

#endregion
#region Member Functions
/// <summary>
/// animate( F32 duration, F32 startAzimuth, F32 endAzimuth, F32 startElevation, F32 endElevation ))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void animate(float duration, float startAzimuth, float endAzimuth, float startElevation, float endElevation){

pInvokes.m_ts.fn_Sun_animate(_ID, duration, startAzimuth, endAzimuth, startElevation, endElevation);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void apply(){

pInvokes.m_ts.fn_Sun_apply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public Sun_Base (){}
}}
