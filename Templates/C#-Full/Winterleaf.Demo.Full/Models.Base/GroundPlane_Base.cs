


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
    [TypeConverter(typeof(TypeConverterGeneric<GroundPlane_Base>))]
    public partial class GroundPlane_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GroundPlane_Base ts, string simobjectid)
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
        public static bool operator !=(GroundPlane_Base ts, string simobjectid)
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
        public static implicit operator string( GroundPlane_Base ts)
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
        public static implicit operator GroundPlane_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GroundPlane_Base) Omni.self.getSimObject(simobjectid,typeof(GroundPlane_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GroundPlane_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GroundPlane_Base(int simobjectid)
            {
            return  (GroundPlane) Omni.self.getSimObject((uint)simobjectid,typeof(GroundPlane_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GroundPlane_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GroundPlane_Base(uint simobjectid)
            {
            return  (GroundPlane_Base) Omni.self.getSimObject(simobjectid,typeof(GroundPlane_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Name of Material used to render %GroundPlane's surface. 
/// </summary>
[MemberGroup("Plane")]
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
/// Scale of texture repeat in the U direction. 
/// </summary>
[MemberGroup("Plane")]
public float scaleU
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleU").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleU", value.AsString());
          }
       }
/// <summary>
/// Scale of texture repeat in the V direction. 
/// </summary>
[MemberGroup("Plane")]
public float scaleV
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scaleV").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scaleV", value.AsString());
          }
       }
/// <summary>
/// Square size in meters to which %GroundPlane subdivides its geometry. 
/// </summary>
[MemberGroup("Plane")]
public float squareSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".squareSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".squareSize", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force trigger an inspectPostApply. This will transmit 
///                    material and other fields to client objects.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fnGroundPlane_postApply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GroundPlane_Base (){}
}}
