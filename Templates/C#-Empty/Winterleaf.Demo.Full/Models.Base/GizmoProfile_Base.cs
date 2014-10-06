


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
    [TypeConverter(typeof(TypeConverterGeneric<GizmoProfile_Base>))]
    public partial class GizmoProfile_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GizmoProfile_Base ts, string simobjectid)
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
        public static bool operator !=(GizmoProfile_Base ts, string simobjectid)
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
        public static implicit operator string( GizmoProfile_Base ts)
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
        public static implicit operator GizmoProfile_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GizmoProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GizmoProfile_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GizmoProfile_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GizmoProfile_Base(int simobjectid)
            {
            return  (GizmoProfile) Omni.self.getSimObject((uint)simobjectid,typeof(GizmoProfile_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GizmoProfile_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GizmoProfile_Base(uint simobjectid)
            {
            return  (GizmoProfile_Base) Omni.self.getSimObject(simobjectid,typeof(GizmoProfile_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public TypeGizmoAlignment alignment
       {
       get
          {          return (TypeGizmoAlignment) Omni.self.GetVar(_ID + ".alignment");
          }
       set
          {
          Omni.self.SetVar(_ID + ".alignment", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool allowSnapRotations
       {
       get
          {
          return Omni.self.GetVar(_ID + ".allowSnapRotations").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".allowSnapRotations", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool allowSnapScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".allowSnapScale").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".allowSnapScale", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int flags
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flags").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flags", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public ColorI gridColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridColor", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public Point3F gridSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gridSize").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gridSize", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public TypeGizmoMode mode
       {
       get
          {          return (TypeGizmoMode) Omni.self.GetVar(_ID + ".mode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".mode", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float planeDim
       {
       get
          {
          return Omni.self.GetVar(_ID + ".planeDim").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".planeDim", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool renderInfoText
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderInfoText").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderInfoText", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool renderMoveGrid
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderMoveGrid").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderMoveGrid", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool renderPlane
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderPlane").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderPlane", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool renderPlaneHashes
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderPlaneHashes").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderPlaneHashes", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool renderSolid
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderSolid").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderSolid", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool renderWhenUsed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderWhenUsed").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderWhenUsed", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float rotateScalar
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rotateScalar").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rotateScalar", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float rotationSnap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rotationSnap").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rotationSnap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float scaleScalar
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleScalar").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleScalar", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public float scaleSnap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleSnap").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleSnap", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int screenLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".screenLength").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".screenLength", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public bool snapToGrid
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snapToGrid").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snapToGrid", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GizmoProfile_Base (){}
}}
