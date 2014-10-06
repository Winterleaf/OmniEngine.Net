


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
    [TypeConverter(typeof(TypeConverterGeneric<WaterObject_Base>))]
    public partial class WaterObject_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WaterObject_Base ts, string simobjectid)
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
        public static bool operator !=(WaterObject_Base ts, string simobjectid)
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
        public static implicit operator string( WaterObject_Base ts)
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
        public static implicit operator WaterObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WaterObject_Base) Omni.self.getSimObject(simobjectid,typeof(WaterObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WaterObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WaterObject_Base(int simobjectid)
            {
            return  (WaterObject) Omni.self.getSimObject((uint)simobjectid,typeof(WaterObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WaterObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WaterObject_Base(uint simobjectid)
            {
            return  (WaterObject_Base) Omni.self.getSimObject(simobjectid,typeof(WaterObject_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Changes color of water fog. 
/// </summary>
[MemberGroup("WaterObject")]
public ColorI baseColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".baseColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".baseColor", value.AsString());
          }
       }
/// <summary>
/// Relative opacity or transparency of the water surface. 
/// </summary>
[MemberGroup("Basic Lighting")]
public float clarity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".clarity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".clarity", value.AsString());
          }
       }
/// <summary>
/// Cubemap used instead of reflection texture if fullReflect is off. 
/// </summary>
[MemberGroup("Reflect")]
public TypeCubemapName cubemap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cubemap").AsTypeCubemapName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cubemap", value.AsString());
          }
       }
/// <summary>
/// Affects buoyancy of an object, thus affecting the Z velocity of a player (jumping, falling, etc.
/// </summary>
[MemberGroup("WaterObject")]
public float density
       {
       get
          {
          return Omni.self.GetVar(_ID + ".density").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".density", value.AsString());
          }
       }
/// <summary>
/// Depth in world units, the max range of the color gradient texture. 
/// </summary>
[MemberGroup("Misc")]
public float depthGradientMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".depthGradientMax").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".depthGradientMax", value.AsString());
          }
       }
/// <summary>
/// 1D texture defining the base water color by depth 
/// </summary>
[MemberGroup("Misc")]
public TypeImageFilename depthGradientTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".depthGradientTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".depthGradientTex", value.AsString());
          }
       }
/// <summary>
/// Max distance that distortion algorithm is performed. 		 The lower, the more distorted the effect.
/// </summary>
[MemberGroup("Distortion")]
public float distortEndDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".distortEndDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".distortEndDist", value.AsString());
          }
       }
/// <summary>
/// Determines the scaling down of distortion 		 in shallow water.
/// </summary>
[MemberGroup("Distortion")]
public float distortFullDepth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".distortFullDepth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".distortFullDepth", value.AsString());
          }
       }
/// <summary>
/// Determines start of distortion effect where water		  surface intersects the camera near plane.
/// </summary>
[MemberGroup("Distortion")]
public float distortStartDist
       {
       get
          {
          return Omni.self.GetVar(_ID + ".distortStartDist").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".distortStartDist", value.AsString());
          }
       }
/// <summary>
/// When true the water colors don't react to changes to environment lighting. 
/// </summary>
[MemberGroup("WaterObject")]
public bool emissive
       {
       get
          {
          return Omni.self.GetVar(_ID + ".emissive").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".emissive", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("WaterObject")]
public float foamAmbientLerp
       {
       get
          {
          return Omni.self.GetVar(_ID + ".foamAmbientLerp").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".foamAmbientLerp", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<Point2F> foamDir;
/// <summary>
///  
/// </summary>
[MemberGroup("WaterObject")]
public float foamMaxDepth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".foamMaxDepth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".foamMaxDepth", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<float> foamOpacity;
/// <summary>
///  
/// </summary>
[MemberGroup("WaterObject")]
public float foamRippleInfluence
       {
       get
          {
          return Omni.self.GetVar(_ID + ".foamRippleInfluence").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".foamRippleInfluence", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<float> foamSpeed;
/// <summary>
/// Diffuse texture for foam in shallow water (advanced lighting only) 
/// </summary>
[MemberGroup("WaterObject")]
public TypeImageFilename foamTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".foamTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".foamTex", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<Point2F> foamTexScale;
/// <summary>
/// Extent of fresnel affecting reflection fogging. 
/// </summary>
[MemberGroup("WaterObject")]
public float fresnelBias
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fresnelBias").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fresnelBias", value.AsString());
          }
       }
/// <summary>
/// Measures intensity of affect on reflection based on fogging. 
/// </summary>
[MemberGroup("WaterObject")]
public float fresnelPower
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fresnelPower").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fresnelPower", value.AsString());
          }
       }
/// <summary>
/// Enables dynamic reflection rendering. 
/// </summary>
[MemberGroup("Reflect")]
public bool fullReflect
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fullReflect").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fullReflect", value.AsString());
          }
       }
/// <summary>
/// Liquid type of WaterBlock, such as water, ocean, lava		  Currently only Water is defined and used.
/// </summary>
[MemberGroup("WaterObject")]
public String liquidType
       {
       get
          {
          return Omni.self.GetVar(_ID + ".liquidType").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".liquidType", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("WaterObject")]
public float overallFoamOpacity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".overallFoamOpacity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".overallFoamOpacity", value.AsString());
          }
       }
/// <summary>
/// Master variable affecting entire surface
/// </summary>
[MemberGroup("WaterObject")]
public float overallRippleMagnitude
       {
       get
          {
          return Omni.self.GetVar(_ID + ".overallRippleMagnitude").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".overallRippleMagnitude", value.AsString());
          }
       }
/// <summary>
/// Master variable affecting entire body 		  of water's undulation 
/// </summary>
[MemberGroup("WaterObject")]
public float overallWaveMagnitude
       {
       get
          {
          return Omni.self.GetVar(_ID + ".overallWaveMagnitude").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".overallWaveMagnitude", value.AsString());
          }
       }
/// <summary>
/// scale up or down the detail level for objects rendered in a reflection 
/// </summary>
[MemberGroup("Reflect")]
public float reflectDetailAdjust
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectDetailAdjust").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectDetailAdjust", value.AsString());
          }
       }
/// <summary>
/// Overall scalar to the reflectivity of the water surface. 
/// </summary>
[MemberGroup("Reflect")]
public float reflectivity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectivity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectivity", value.AsString());
          }
       }
/// <summary>
/// Affects the sort time of reflected objects. 
/// </summary>
[MemberGroup("Reflect")]
public int reflectMaxRateMs
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectMaxRateMs").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectMaxRateMs", value.AsString());
          }
       }
/// <summary>
/// always use z up as the reflection normal 
/// </summary>
[MemberGroup("Reflect")]
public bool reflectNormalUp
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectNormalUp").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectNormalUp", value.AsString());
          }
       }
/// <summary>
/// Affects the sort order of reflected objects. 
/// </summary>
[MemberGroup("Reflect")]
public float reflectPriority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectPriority").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectPriority", value.AsString());
          }
       }
/// <summary>
/// The texture size used for reflections (square) 
/// </summary>
[MemberGroup("Reflect")]
public int reflectTexSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectTexSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectTexSize", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<Point2F> rippleDir;
[MemberGroup("WaterObject")]
public arrayObject<float> rippleMagnitude;
[MemberGroup("WaterObject")]
public arrayObject<float> rippleSpeed;
/// <summary>
/// Normal map used to simulate small surface ripples 
/// </summary>
[MemberGroup("WaterObject")]
public TypeImageFilename rippleTex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rippleTex").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rippleTex", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<Point2F> rippleTexScale;
/// <summary>
/// Ambient sound environment when listener is submerged. 
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
/// Color used for specularity on the water surface ( sun only ). 
/// </summary>
[MemberGroup("WaterObject")]
public ColorF specularColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".specularColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".specularColor", value.AsString());
          }
       }
/// <summary>
/// Power used for specularity on the water surface ( sun only ). 
/// </summary>
[MemberGroup("WaterObject")]
public float specularPower
       {
       get
          {
          return Omni.self.GetVar(_ID + ".specularPower").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".specularPower", value.AsString());
          }
       }
/// <summary>
/// Changes the color shading of objects beneath		  the water surface.
/// </summary>
[MemberGroup("Basic Lighting")]
public ColorI underwaterColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".underwaterColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".underwaterColor", value.AsString());
          }
       }
/// <summary>
/// turn off reflection rendering when occluded (delayed). 
/// </summary>
[MemberGroup("Reflect")]
public bool useOcclusionQuery
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useOcclusionQuery").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useOcclusionQuery", value.AsString());
          }
       }
/// <summary>
/// Affects drag force applied to an object submerged in this container. 
/// </summary>
[MemberGroup("WaterObject")]
public float viscosity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".viscosity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".viscosity", value.AsString());
          }
       }
/// <summary>
/// Intensity of underwater fogging. 
/// </summary>
[MemberGroup("Underwater Fogging")]
public float waterFogDensity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".waterFogDensity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".waterFogDensity", value.AsString());
          }
       }
/// <summary>
/// Delta, or limit, applied to waterFogDensity. 
/// </summary>
[MemberGroup("Underwater Fogging")]
public float waterFogDensityOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".waterFogDensityOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".waterFogDensityOffset", value.AsString());
          }
       }
[MemberGroup("WaterObject")]
public arrayObject<Point2F> waveDir;
[MemberGroup("WaterObject")]
public arrayObject<float> waveMagnitude;
[MemberGroup("WaterObject")]
public arrayObject<float> waveSpeed;
/// <summary>
/// The refract color intensity scaled at wetDepth. 
/// </summary>
[MemberGroup("Underwater Fogging")]
public float wetDarkening
       {
       get
          {
          return Omni.self.GetVar(_ID + ".wetDarkening").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".wetDarkening", value.AsString());
          }
       }
/// <summary>
/// The depth in world units at which full darkening will be received,		  giving a wet look to objects underwater. 
/// </summary>
[MemberGroup("Underwater Fogging")]
public float wetDepth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".wetDepth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".wetDepth", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public WaterObject_Base (){foamDir = new arrayObject<Point2F>(2,"foamDir","TypeVariable",false,this);    
foamOpacity = new arrayObject<float>(2,"foamOpacity","TypeVariable",false,this);    
foamSpeed = new arrayObject<float>(2,"foamSpeed","TypeVariable",false,this);    
foamTexScale = new arrayObject<Point2F>(2,"foamTexScale","TypeVariable",false,this);    
rippleDir = new arrayObject<Point2F>(3,"rippleDir","TypeVariable",false,this);    
rippleMagnitude = new arrayObject<float>(3,"rippleMagnitude","TypeVariable",false,this);    
rippleSpeed = new arrayObject<float>(3,"rippleSpeed","TypeVariable",false,this);    
rippleTexScale = new arrayObject<Point2F>(3,"rippleTexScale","TypeVariable",false,this);    
waveDir = new arrayObject<Point2F>(3,"waveDir","TypeVariable",false,this);    
waveMagnitude = new arrayObject<float>(3,"waveMagnitude","TypeVariable",false,this);    
waveSpeed = new arrayObject<float>(3,"waveSpeed","TypeVariable",false,this);    
}
}}
