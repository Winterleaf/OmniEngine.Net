


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
    [TypeConverter(typeof(TypeConverterGeneric<GroundCover_Base>))]
    public partial class GroundCover_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GroundCover_Base ts, string simobjectid)
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
        public static bool operator !=(GroundCover_Base ts, string simobjectid)
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
        public static implicit operator string( GroundCover_Base ts)
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
        public static implicit operator GroundCover_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GroundCover_Base) Omni.self.getSimObject(simobjectid,typeof(GroundCover_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GroundCover_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GroundCover_Base(int simobjectid)
            {
            return  (GroundCover) Omni.self.getSimObject((uint)simobjectid,typeof(GroundCover_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GroundCover_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GroundCover_Base(uint simobjectid)
            {
            return  (GroundCover_Base) Omni.self.getSimObject(simobjectid,typeof(GroundCover_Base));
            }
#endregion
#region Init Persists
[MemberGroup("GroundCover General")]
public arrayObject<RectF> billboardUVs;
[MemberGroup("GroundCover General")]
public arrayObject<float> clumpExponent;
[MemberGroup("GroundCover General")]
public arrayObject<float> clumpRadius;
/// <summary>
/// This is less than or equal to radius and defines when fading of cover elements begins. 
/// </summary>
[MemberGroup("GroundCover General")]
public float dissolveRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dissolveRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dissolveRadius", value.AsString());
          }
       }
/// <summary>
/// The number of cells per axis in the grid. 
/// </summary>
[MemberGroup("GroundCover General")]
public int gridSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridSize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridSize", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<bool> invertLayer;
[MemberGroup("GroundCover General")]
public arrayObject<TypeTerrainMaterialName> layer;
/// <summary>
/// Debug parameter for locking the culling frustum which will freeze the cover generation. 
/// </summary>
[MemberGroup("GroundCover Debug")]
public bool lockFrustum
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lockFrustum").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lockFrustum", value.AsString());
          }
       }
/// <summary>
/// Material used by all GroundCover segments. 
/// </summary>
[MemberGroup("GroundCover General")]
public TypeMaterialName material
       {
       get
          {
          return Omni.self.GetVar(_ID + ".material").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".material", value.AsString());
          }
       }
/// <summary>
/// The maximum amout of degrees the billboard will tilt down to match the camera. 
/// </summary>
[MemberGroup("GroundCover General")]
public float maxBillboardTiltAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxBillboardTiltAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxBillboardTiltAngle", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<int> maxClumpCount;
/// <summary>
/// The maximum amount of cover elements to include in the grid at any one time. 
/// </summary>
[MemberGroup("GroundCover General")]
public int maxElements
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxElements").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxElements", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<float> maxElevation;
[MemberGroup("GroundCover General")]
public arrayObject<float> maxSlope;
[MemberGroup("GroundCover General")]
public arrayObject<int> minClumpCount;
[MemberGroup("GroundCover General")]
public arrayObject<float> minElevation;
/// <summary>
/// Debug parameter for turning off billboard rendering. 
/// </summary>
[MemberGroup("GroundCover Debug")]
public bool noBillboards
       {
       get
          {
          return Omni.self.GetVar(_ID + ".noBillboards").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".noBillboards", value.AsString());
          }
       }
/// <summary>
/// Debug parameter for turning off shape rendering. 
/// </summary>
[MemberGroup("GroundCover Debug")]
public bool noShapes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".noShapes").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".noShapes", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<float> probability;
/// <summary>
/// Outer generation radius from the current camera position. 
/// </summary>
[MemberGroup("GroundCover General")]
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
/// Scales the various culling radii when rendering a reflection. Typically for water. 
/// </summary>
[MemberGroup("GroundCover General")]
public float reflectScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectScale", value.AsString());
          }
       }
/// <summary>
/// Debug parameter for displaying the grid cells. 
/// </summary>
[MemberGroup("GroundCover Debug")]
public bool renderCells
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderCells").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderCells", value.AsString());
          }
       }
/// <summary>
/// This RNG seed is saved and sent to clients for generating the same cover. 
/// </summary>
[MemberGroup("GroundCover General")]
public int seed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".seed").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".seed", value.AsString());
          }
       }
/// <summary>
/// This is the distance at which DTS elements are completely culled out. 
/// </summary>
[MemberGroup("GroundCover General")]
public float shapeCullRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shapeCullRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shapeCullRadius", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<String> shapeFilename;
/// <summary>
/// Whether DTS elements should cast shadows or not. 
/// </summary>
[MemberGroup("GroundCover General")]
public bool shapesCastShadows
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shapesCastShadows").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shapesCastShadows", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<float> sizeExponent;
[MemberGroup("GroundCover General")]
public arrayObject<float> sizeMax;
[MemberGroup("GroundCover General")]
public arrayObject<float> sizeMin;
/// <summary>
/// The direction of the wind. 
/// </summary>
[MemberGroup("GroundCover Wind")]
public Point2F windDirection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windDirection").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windDirection", value.AsString());
          }
       }
/// <summary>
/// Controls how often the wind gust peaks per second. 
/// </summary>
[MemberGroup("GroundCover Wind")]
public float windGustFrequency
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windGustFrequency").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windGustFrequency", value.AsString());
          }
       }
/// <summary>
/// The length in meters between peaks in the wind gust. 
/// </summary>
[MemberGroup("GroundCover Wind")]
public float windGustLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windGustLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windGustLength", value.AsString());
          }
       }
/// <summary>
/// The maximum distance in meters that the peak wind gust will displace an element. 
/// </summary>
[MemberGroup("GroundCover Wind")]
public float windGustStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windGustStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windGustStrength", value.AsString());
          }
       }
[MemberGroup("GroundCover General")]
public arrayObject<float> windScale;
/// <summary>
/// Controls the overall rapidity of the wind turbulence. 
/// </summary>
[MemberGroup("GroundCover Wind")]
public float windTurbulenceFrequency
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windTurbulenceFrequency").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windTurbulenceFrequency", value.AsString());
          }
       }
/// <summary>
/// The maximum distance in meters that the turbulence can displace a ground cover element. 
/// </summary>
[MemberGroup("GroundCover Wind")]
public float windTurbulenceStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windTurbulenceStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windTurbulenceStrength", value.AsString());
          }
       }
/// <summary>
/// Offset along the Z axis to render the ground cover. 
/// </summary>
[MemberGroup("GroundCover General")]
public float zOffset
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zOffset").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zOffset", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GroundCover_Base (){billboardUVs = new arrayObject<RectF>(8,"billboardUVs","TypeVariable",false,this);    
clumpExponent = new arrayObject<float>(8,"clumpExponent","TypeVariable",false,this);    
clumpRadius = new arrayObject<float>(8,"clumpRadius","TypeVariable",false,this);    
invertLayer = new arrayObject<bool>(8,"invertLayer","TypeVariable",false,this);    
layer = new arrayObject<TypeTerrainMaterialName>(8,"layer","TypeVariable",false,this);    
maxClumpCount = new arrayObject<int>(8,"maxClumpCount","TypeVariable",false,this);    
maxElevation = new arrayObject<float>(8,"maxElevation","TypeVariable",false,this);    
maxSlope = new arrayObject<float>(8,"maxSlope","TypeVariable",false,this);    
minClumpCount = new arrayObject<int>(8,"minClumpCount","TypeVariable",false,this);    
minElevation = new arrayObject<float>(8,"minElevation","TypeVariable",false,this);    
probability = new arrayObject<float>(8,"probability","TypeVariable",false,this);    
shapeFilename = new arrayObject<String>(8,"shapeFilename","TypeVariable",false,this);    
sizeExponent = new arrayObject<float>(8,"sizeExponent","TypeVariable",false,this);    
sizeMax = new arrayObject<float>(8,"sizeMax","TypeVariable",false,this);    
sizeMin = new arrayObject<float>(8,"sizeMin","TypeVariable",false,this);    
windScale = new arrayObject<float>(8,"windScale","TypeVariable",false,this);    
}
}}
