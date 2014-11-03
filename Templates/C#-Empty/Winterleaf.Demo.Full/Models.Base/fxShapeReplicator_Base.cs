


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
    [TypeConverter(typeof(TypeConverterGeneric<fxShapeReplicator_Base>))]
    public partial class fxShapeReplicator_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(fxShapeReplicator_Base ts, string simobjectid)
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
        public static bool operator !=(fxShapeReplicator_Base ts, string simobjectid)
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
        public static implicit operator string( fxShapeReplicator_Base ts)
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
        public static implicit operator fxShapeReplicator_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (fxShapeReplicator_Base) Omni.self.getSimObject(simobjectid,typeof(fxShapeReplicator_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( fxShapeReplicator_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator fxShapeReplicator_Base(int simobjectid)
            {
            return  (fxShapeReplicator) Omni.self.getSimObject((uint)simobjectid,typeof(fxShapeReplicator_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( fxShapeReplicator_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator fxShapeReplicator_Base(uint simobjectid)
            {
            return  (fxShapeReplicator_Base) Omni.self.getSimObject(simobjectid,typeof(fxShapeReplicator_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Align shapes to surface normal when set. 
/// </summary>
[MemberGroup("Restraints")]
public bool AlignToTerrain
       {
       get
          {
          return Omni.self.GetVar(_ID + ".AlignToTerrain").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".AlignToTerrain", value.AsString());
          }
       }
/// <summary>
/// Maximum surface angle allowed for shape instances. 
/// </summary>
[MemberGroup("Restraints")]
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
/// Shapes will be placed on Static shapes when set. 
/// </summary>
[MemberGroup("Restraints")]
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
/// Shapes will be placed on terrain when set. 
/// </summary>
[MemberGroup("Restraints")]
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
/// Shapes will be placed on/under water when set. 
/// </summary>
[MemberGroup("Restraints")]
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
/// Shapes will be placed on water when set. Requires AllowOnWater. 
/// </summary>
[MemberGroup("Restraints")]
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
/// Replicated shapes are hidden when set to true. 
/// </summary>
[MemberGroup("Debugging")]
public bool HideReplications
       {
       get
          {
          return Omni.self.GetVar(_ID + ".HideReplications").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".HideReplications", value.AsString());
          }
       }
/// <summary>
/// Placement area inner radius on the X axis 
/// </summary>
[MemberGroup("Placement Radius")]
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
[MemberGroup("Placement Radius")]
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
/// Allow physics interactions with shapes. 
/// </summary>
[MemberGroup("Restraints")]
public bool Interactions
       {
       get
          {
          return Omni.self.GetVar(_ID + ".Interactions").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".Interactions", value.AsString());
          }
       }
/// <summary>
/// Offset shapes by this amount vertically. 
/// </summary>
[MemberGroup("Object Transforms")]
public int OffsetZ
       {
       get
          {
          return Omni.self.GetVar(_ID + ".OffsetZ").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".OffsetZ", value.AsString());
          }
       }
/// <summary>
/// Placement area outer radius on the X axis 
/// </summary>
[MemberGroup("Placement Radius")]
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
[MemberGroup("Placement Radius")]
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
/// Random seed for shape placement. 
/// </summary>
[MemberGroup("Replications")]
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
/// Maximum shape instance count. 
/// </summary>
[MemberGroup("Replications")]
public int ShapeCount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeCount").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeCount", value.AsString());
          }
       }
/// <summary>
/// Filename of shape to replicate. 
/// </summary>
[MemberGroup("Media")]
public TypeShapeFilename ShapeFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeFile").AsTypeShapeFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeFile", value.AsString());
          }
       }
/// <summary>
/// Number of times to try placing a shape instance before giving up. 
/// </summary>
[MemberGroup("Replications")]
public int ShapeRetries
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeRetries").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeRetries", value.AsString());
          }
       }
/// <summary>
/// Maximum shape rotation angles. 
/// </summary>
[MemberGroup("Object Transforms")]
public Point3F ShapeRotateMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeRotateMax").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeRotateMax", value.AsString());
          }
       }
/// <summary>
/// Minimum shape rotation angles.
/// </summary>
[MemberGroup("Object Transforms")]
public Point3F ShapeRotateMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeRotateMin").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeRotateMin", value.AsString());
          }
       }
/// <summary>
/// Maximum shape scale. 
/// </summary>
[MemberGroup("Object Transforms")]
public Point3F ShapeScaleMax
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeScaleMax").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeScaleMax", value.AsString());
          }
       }
/// <summary>
/// Minimum shape scale. 
/// </summary>
[MemberGroup("Object Transforms")]
public Point3F ShapeScaleMin
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ShapeScaleMin").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ShapeScaleMin", value.AsString());
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
/// Surface normals will be multiplied by these values when AlignToTerrain is enabled. 
/// </summary>
[MemberGroup("Restraints")]
public Point3F TerrainAlignment
       {
       get
          {
          return Omni.self.GetVar(_ID + ".TerrainAlignment").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".TerrainAlignment", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public fxShapeReplicator_Base (){}
}}
