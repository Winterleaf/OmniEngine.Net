


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
    [TypeConverter(typeof(TypeConverterGeneric<TerrainMaterial_Base>))]
    public partial class TerrainMaterial_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainMaterial_Base ts, string simobjectid)
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
        public static bool operator !=(TerrainMaterial_Base ts, string simobjectid)
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
        public static implicit operator string( TerrainMaterial_Base ts)
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
        public static implicit operator TerrainMaterial_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TerrainMaterial_Base) Omni.self.getSimObject(simobjectid,typeof(TerrainMaterial_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TerrainMaterial_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainMaterial_Base(int simobjectid)
            {
            return  (TerrainMaterial) Omni.self.getSimObject((uint)simobjectid,typeof(TerrainMaterial_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TerrainMaterial_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainMaterial_Base(uint simobjectid)
            {
            return  (TerrainMaterial_Base) Omni.self.getSimObject(simobjectid,typeof(TerrainMaterial_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Changes how far camera can see the detail map rendering on the material 
/// </summary>
[MemberGroup("")]
public float detailDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailDistance", value.AsString());
          }
       }
/// <summary>
/// Detail map for the material 
/// </summary>
[MemberGroup("")]
public String detailMap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailMap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailMap", value.AsString());
          }
       }
/// <summary>
/// Used to scale the detail map to the material square 
/// </summary>
[MemberGroup("")]
public float detailSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailSize", value.AsString());
          }
       }
/// <summary>
/// Exponentially sharpens or lightens the detail map rendering on the material 
/// </summary>
[MemberGroup("")]
public float detailStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".detailStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".detailStrength", value.AsString());
          }
       }
/// <summary>
/// Base texture for the material 
/// </summary>
[MemberGroup("")]
public String diffuseMap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".diffuseMap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".diffuseMap", value.AsString());
          }
       }
/// <summary>
/// Used to scale the diffuse map to the material square 
/// </summary>
[MemberGroup("")]
public float diffuseSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".diffuseSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".diffuseSize", value.AsString());
          }
       }
/// <summary>
/// Changes how far camera can see the Macro map rendering on the material 
/// </summary>
[MemberGroup("")]
public float macroDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".macroDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".macroDistance", value.AsString());
          }
       }
/// <summary>
/// Macro map for the material 
/// </summary>
[MemberGroup("")]
public String macroMap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".macroMap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".macroMap", value.AsString());
          }
       }
/// <summary>
/// Used to scale the Macro map to the material square 
/// </summary>
[MemberGroup("")]
public float macroSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".macroSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".macroSize", value.AsString());
          }
       }
/// <summary>
/// Exponentially sharpens or lightens the Macro map rendering on the material 
/// </summary>
[MemberGroup("")]
public float macroStrength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".macroStrength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".macroStrength", value.AsString());
          }
       }
/// <summary>
/// Bump map for the material 
/// </summary>
[MemberGroup("")]
public String normalMap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".normalMap").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".normalMap", value.AsString());
          }
       }
/// <summary>
/// Used to scale the height from the normal map to give some self 	  occlusion effect (aka parallax) to the terrain material 
/// </summary>
[MemberGroup("")]
public float parallaxScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".parallaxScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".parallaxScale", value.AsString());
          }
       }
/// <summary>
/// Makes that terrain material project along the sides of steep 	  slopes instead of projected downwards
/// </summary>
[MemberGroup("")]
public bool useSideProjection
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useSideProjection").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useSideProjection", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public TerrainMaterial_Base (){}
}}
