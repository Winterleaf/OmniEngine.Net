


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
    [TypeConverter(typeof(TypeConverterGeneric<fxFoliageReplicator_Base>))]
    public partial class fxFoliageReplicator_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(fxFoliageReplicator_Base ts, string simobjectid)
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
        public static bool operator !=(fxFoliageReplicator_Base ts, string simobjectid)
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
        public static implicit operator string( fxFoliageReplicator_Base ts)
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
        public static implicit operator fxFoliageReplicator_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (fxFoliageReplicator_Base) Omni.self.getSimObject(simobjectid,typeof(fxFoliageReplicator_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( fxFoliageReplicator_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator fxFoliageReplicator_Base(int simobjectid)
            {
            return  (fxFoliageReplicator) Omni.self.getSimObject((uint)simobjectid,typeof(fxFoliageReplicator_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( fxFoliageReplicator_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator fxFoliageReplicator_Base(uint simobjectid)
            {
            return  (fxFoliageReplicator_Base) Omni.self.getSimObject(simobjectid,typeof(fxFoliageReplicator_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Maximum surface angle allowed for foliage instances. 
/// </summary>
[MemberGroup("Restrictions")]
public int AllowedTerrainSlope
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AllowedTerrainSlope").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AllowedTerrainSlope", value.AsString());
          }
       }
/// <summary>
/// Foliage will be placed on Static shapes when set. 
/// </summary>
[MemberGroup("Restrictions")]
public bool AllowOnStatics
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AllowOnStatics").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AllowOnStatics", value.AsString());
          }
       }
/// <summary>
/// Foliage will be placed on terrain when set. 
/// </summary>
[MemberGroup("Restrictions")]
public bool AllowOnTerrain
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AllowOnTerrain").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AllowOnTerrain", value.AsString());
          }
       }
/// <summary>
/// Foliage will be placed on/under water when set. 
/// </summary>
[MemberGroup("Restrictions")]
public bool AllowOnWater
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AllowOnWater").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AllowOnWater", value.AsString());
          }
       }
/// <summary>
/// Foliage will be placed on water when set. Requires AllowOnWater. 
/// </summary>
[MemberGroup("Restrictions")]
public bool AllowWaterSurface
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AllowWaterSurface").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AllowWaterSurface", value.AsString());
          }
       }
/// <summary>
/// Minimum alpha value allowed on foliage instances. 
/// </summary>
[MemberGroup("Culling")]
public float AlphaCutoff
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AlphaCutoff").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AlphaCutoff", value.AsString());
          }
       }
/// <summary>
/// Minimum size of culling bins. Must be = 8 and = OuterRadius. 
/// </summary>
[MemberGroup("Culling")]
public int CullResolution
       {
       get
          {
          return Omni.self.GetVar(_ID + ".CullResolution").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".CullResolution", value.AsString());
          }
       }
/// <summary>
/// Height multiplier for drawn culling bins.
/// </summary>
[MemberGroup("Debugging")]
public float DebugBoxHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".DebugBoxHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".DebugBoxHeight", value.AsString());
          }
       }
/// <summary>
/// Region beyond ViewDistance where foliage fades in/out. 
/// </summary>
[MemberGroup("Culling")]
public float FadeInRegion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FadeInRegion").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FadeInRegion", value.AsString());
          }
       }
/// <summary>
/// Region before ViewClosest where foliage fades in/out. 
/// </summary>
[MemberGroup("Culling")]
public float FadeOutRegion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FadeOutRegion").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FadeOutRegion", value.AsString());
          }
       }
/// <summary>
/// Maintain aspect ratio of image if true. This option ignores MaxWidth. 
/// </summary>
[MemberGroup("Dimensions")]
public bool FixAspectRatio
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FixAspectRatio").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FixAspectRatio", value.AsString());
          }
       }
/// <summary>
/// Use only MaxWidth and MaxHeight for billboard size. Ignores MinWidth and MinHeight. 
/// </summary>
[MemberGroup("Dimensions")]
public bool FixSizeToMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FixSizeToMax").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FixSizeToMax", value.AsString());
          }
       }
/// <summary>
/// Maximum foliage instance count. 
/// </summary>
[MemberGroup("Media")]
public int FoliageCount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FoliageCount").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FoliageCount", value.AsString());
          }
       }
/// <summary>
/// Image file for the foliage texture. 
/// </summary>
[MemberGroup("Media")]
public String FoliageFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FoliageFile").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FoliageFile", value.AsString());
          }
       }
/// <summary>
/// Number of times to try placing a foliage instance before giving up. 
/// </summary>
[MemberGroup("Media")]
public int FoliageRetries
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FoliageRetries").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FoliageRetries", value.AsString());
          }
       }
/// <summary>
/// Alpha of the foliage at ground level. 0 = transparent, 1 = opaque. 
/// </summary>
[MemberGroup("Culling")]
public float GroundAlpha
       {
       get
          {
          return Omni.self.GetVar(_ID + ".GroundAlpha").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".GroundAlpha", value.AsString());
          }
       }
/// <summary>
/// Foliage is hidden when set to true. 
/// </summary>
[MemberGroup("Debugging")]
public bool HideFoliage
       {
       get
          {
          return Omni.self.GetVar(_ID + ".HideFoliage").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".HideFoliage", value.AsString());
          }
       }
/// <summary>
/// Placement area inner radius on the X axis 
/// </summary>
[MemberGroup("Area")]
public int InnerRadiusX
       {
       get
          {
          return Omni.self.GetVar(_ID + ".InnerRadiusX").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".InnerRadiusX", value.AsString());
          }
       }
/// <summary>
/// Placement area inner radius on the Y axis 
/// </summary>
[MemberGroup("Area")]
public int InnerRadiusY
       {
       get
          {
          return Omni.self.GetVar(_ID + ".InnerRadiusY").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".InnerRadiusY", value.AsString());
          }
       }
/// <summary>
/// Foliage should be illuminated with changing lights when true. 
/// </summary>
[MemberGroup("Lighting")]
public bool LightOn
       {
       get
          {
          return Omni.self.GetVar(_ID + ".LightOn").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".LightOn", value.AsString());
          }
       }
/// <summary>
/// Foliage instances have the same lighting when set and LightOn is set. 
/// </summary>
[MemberGroup("Lighting")]
public bool LightSync
       {
       get
          {
          return Omni.self.GetVar(_ID + ".LightSync").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".LightSync", value.AsString());
          }
       }
/// <summary>
/// Time before foliage illumination cycle repeats. 
/// </summary>
[MemberGroup("Lighting")]
public float LightTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".LightTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".LightTime", value.AsString());
          }
       }
/// <summary>
/// Maximum height of foliage billboards 
/// </summary>
[MemberGroup("Dimensions")]
public float MaxHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MaxHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MaxHeight", value.AsString());
          }
       }
/// <summary>
/// Maximum luminance for foliage instances. 
/// </summary>
[MemberGroup("Lighting")]
public float MaxLuminance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MaxLuminance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MaxLuminance", value.AsString());
          }
       }
/// <summary>
/// Maximum sway cycle time in seconds. 
/// </summary>
[MemberGroup("Animation")]
public float MaxSwayTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MaxSwayTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MaxSwayTime", value.AsString());
          }
       }
/// <summary>
/// Maximum width of foliage billboards 
/// </summary>
[MemberGroup("Dimensions")]
public float MaxWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MaxWidth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MaxWidth", value.AsString());
          }
       }
/// <summary>
/// Minimum height of foliage billboards 
/// </summary>
[MemberGroup("Dimensions")]
public float MinHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MinHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MinHeight", value.AsString());
          }
       }
/// <summary>
/// Minimum luminance for foliage instances. 
/// </summary>
[MemberGroup("Lighting")]
public float MinLuminance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MinLuminance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MinLuminance", value.AsString());
          }
       }
/// <summary>
/// Minumum sway cycle time in seconds. 
/// </summary>
[MemberGroup("Animation")]
public float MinSwayTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MinSwayTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MinSwayTime", value.AsString());
          }
       }
/// <summary>
/// Minimum width of foliage billboards 
/// </summary>
[MemberGroup("Dimensions")]
public float MinWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".MinWidth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".MinWidth", value.AsString());
          }
       }
/// <summary>
/// Offset billboards by this amount vertically. 
/// </summary>
[MemberGroup("Dimensions")]
public float OffsetZ
       {
       get
          {
          return Omni.self.GetVar(_ID + ".OffsetZ").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".OffsetZ", value.AsString());
          }
       }
/// <summary>
/// Placement area outer radius on the X axis 
/// </summary>
[MemberGroup("Area")]
public int OuterRadiusX
       {
       get
          {
          return Omni.self.GetVar(_ID + ".OuterRadiusX").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".OuterRadiusX", value.AsString());
          }
       }
/// <summary>
/// Placement area outer radius on the Y axis 
/// </summary>
[MemberGroup("Area")]
public int OuterRadiusY
       {
       get
          {
          return Omni.self.GetVar(_ID + ".OuterRadiusY").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".OuterRadiusY", value.AsString());
          }
       }
/// <summary>
/// Height of the placement ring in world units. 
/// </summary>
[MemberGroup("Debugging")]
public int PlacementAreaHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".PlacementAreaHeight").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".PlacementAreaHeight", value.AsString());
          }
       }
/// <summary>
/// Color of the placement ring. 
/// </summary>
[MemberGroup("Debugging")]
public ColorF PlacementColour
       {
       get
          {
          return Omni.self.GetVar(_ID + ".PlacementColour").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".PlacementColour", value.AsString());
          }
       }
/// <summary>
/// Randomly flip billboards left-to-right. 
/// </summary>
[MemberGroup("Dimensions")]
public bool RandomFlip
       {
       get
          {
          return Omni.self.GetVar(_ID + ".RandomFlip").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".RandomFlip", value.AsString());
          }
       }
/// <summary>
/// Random seed for foliage placement. 
/// </summary>
[MemberGroup("Media")]
public int Seed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".Seed").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".Seed", value.AsString());
          }
       }
/// <summary>
/// Draw placement rings when set to true. 
/// </summary>
[MemberGroup("Debugging")]
public bool ShowPlacementArea
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShowPlacementArea").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShowPlacementArea", value.AsString());
          }
       }
/// <summary>
/// Front-to-back sway magnitude. 
/// </summary>
[MemberGroup("Animation")]
public float SwayMagFront
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SwayMagFront").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SwayMagFront", value.AsString());
          }
       }
/// <summary>
/// Left-to-right sway magnitude. 
/// </summary>
[MemberGroup("Animation")]
public float SwayMagSide
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SwayMagSide").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SwayMagSide", value.AsString());
          }
       }
/// <summary>
/// Foliage should sway randomly when true. 
/// </summary>
[MemberGroup("Animation")]
public bool SwayOn
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SwayOn").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SwayOn", value.AsString());
          }
       }
/// <summary>
/// Foliage instances should sway together when true and SwayOn is enabled. 
/// </summary>
[MemberGroup("Animation")]
public bool SwaySync
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SwaySync").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SwaySync", value.AsString());
          }
       }
/// <summary>
/// Use culling bins when enabled. 
/// </summary>
[MemberGroup("Culling")]
public bool UseCulling
       {
       get
          {
          return Omni.self.GetVar(_ID + ".UseCulling").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".UseCulling", value.AsString());
          }
       }
/// <summary>
/// Culling bins are drawn when set to true. 
/// </summary>
[MemberGroup("Debugging")]
public bool UseDebugInfo
       {
       get
          {
          return Omni.self.GetVar(_ID + ".UseDebugInfo").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".UseDebugInfo", value.AsString());
          }
       }
/// <summary>
/// Use camera facing billboards ( including the z axis ). 
/// </summary>
[MemberGroup("Dimensions")]
public bool UseTrueBillboards
       {
       get
          {
          return Omni.self.GetVar(_ID + ".UseTrueBillboards").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".UseTrueBillboards", value.AsString());
          }
       }
/// <summary>
/// Minimum distance from camera where foliage appears. 
/// </summary>
[MemberGroup("Culling")]
public float ViewClosest
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ViewClosest").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ViewClosest", value.AsString());
          }
       }
/// <summary>
/// Maximum distance from camera where foliage appears. 
/// </summary>
[MemberGroup("Culling")]
public float ViewDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ViewDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ViewDistance", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public fxFoliageReplicator_Base (){}
}}
