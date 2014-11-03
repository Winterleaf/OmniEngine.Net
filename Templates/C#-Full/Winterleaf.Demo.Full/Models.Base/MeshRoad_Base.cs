


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
    [TypeConverter(typeof(TypeConverterGeneric<MeshRoad_Base>))]
    public partial class MeshRoad_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MeshRoad_Base ts, string simobjectid)
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
        public static bool operator !=(MeshRoad_Base ts, string simobjectid)
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
        public static implicit operator string( MeshRoad_Base ts)
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
        public static implicit operator MeshRoad_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (MeshRoad_Base) Omni.self.getSimObject(simobjectid,typeof(MeshRoad_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( MeshRoad_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MeshRoad_Base(int simobjectid)
            {
            return  (MeshRoad) Omni.self.getSimObject((uint)simobjectid,typeof(MeshRoad_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( MeshRoad_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MeshRoad_Base(uint simobjectid)
            {
            return  (MeshRoad_Base) Omni.self.getSimObject(simobjectid,typeof(MeshRoad_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Material for the bottom surface of the road. 
/// </summary>
[MemberGroup("MeshRoad")]
public TypeMaterialName bottomMaterial
       {
       get
          {
          return Omni.self.GetVar(_ID + ".bottomMaterial").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".bottomMaterial", value.AsString());
          }
       }
/// <summary>
/// Angle in degrees - MeshRoad will subdivide the spline if its curve is greater than this threshold. 
/// </summary>
[MemberGroup("MeshRoad")]
public float breakAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".breakAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".breakAngle", value.AsString());
          }
       }
/// <summary>
/// Do not modify, for internal use. 
/// </summary>
[MemberGroup("Internal")]
public String Node
       {
       get
          {
          return Omni.self.GetVar(_ID + ".Node").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".Node", value.AsString());
          }
       }
/// <summary>
/// Material for the left, right, front, and back surfaces of the road. 
/// </summary>
[MemberGroup("MeshRoad")]
public TypeMaterialName sideMaterial
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sideMaterial").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sideMaterial", value.AsString());
          }
       }
/// <summary>
/// The length in meters of textures mapped to the MeshRoad. 
/// </summary>
[MemberGroup("MeshRoad")]
public float textureLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textureLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureLength", value.AsString());
          }
       }
/// <summary>
/// Material for the upper surface of the road. 
/// </summary>
[MemberGroup("MeshRoad")]
public TypeMaterialName topMaterial
       {
       get
          {
          return Omni.self.GetVar(_ID + ".topMaterial").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".topMaterial", value.AsString());
          }
       }
/// <summary>
/// Subdivide segments widthwise this many times when generating vertices. 
/// </summary>
[MemberGroup("MeshRoad")]
public int widthSubdivisions
       {
       get
          {
          return Omni.self.GetVar(_ID + ".widthSubdivisions").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".widthSubdivisions", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force trigger an inspectPostApply. This will transmit 
///                    material and other fields ( not including nodes ) to client objects.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fnMeshRoad_postApply(_ID);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force MeshRoad to recreate its geometry.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void regenerate(){

pInvokes.m_ts.fnMeshRoad_regenerate(_ID);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Sets the depth in meters of a particular node.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodeDepth(int idx, float meters){

pInvokes.m_ts.fnMeshRoad_setNodeDepth(_ID, idx, meters);
}

#endregion
#region T3D Callbacks

#endregion
public MeshRoad_Base (){}
}}
