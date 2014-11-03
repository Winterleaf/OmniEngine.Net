


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
    [TypeConverter(typeof(TypeConverterGeneric<River_Base>))]
    public partial class River_Base: WaterObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(River_Base ts, string simobjectid)
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
        public static bool operator !=(River_Base ts, string simobjectid)
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
        public static implicit operator string( River_Base ts)
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
        public static implicit operator River_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (River_Base) Omni.self.getSimObject(simobjectid,typeof(River_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( River_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator River_Base(int simobjectid)
            {
            return  (River) Omni.self.getSimObject((uint)simobjectid,typeof(River_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( River_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator River_Base(uint simobjectid)
            {
            return  (River_Base) Omni.self.getSimObject(simobjectid,typeof(River_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Magnitude of the force vector applied to dynamic objects within the River. 
/// </summary>
[MemberGroup("River")]
public float FlowMagnitude
       {
       get
          {
          return Omni.self.GetVar(_ID + ".FlowMagnitude").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".FlowMagnitude", value.AsString());
          }
       }
/// <summary>
/// Segments of the river at this distance in meters or greater will      render as a single unsubdivided without undulation effects. 
/// </summary>
[MemberGroup("River")]
public float LowLODDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".LowLODDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".LowLODDistance", value.AsString());
          }
       }
/// <summary>
/// For internal use, do not modify. 
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
/// Divide the River lengthwise into segments of this length in meters.      These geometric volumes are used for spacial queries like determining containment. 
/// </summary>
[MemberGroup("River")]
public float SegmentLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SegmentLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SegmentLength", value.AsString());
          }
       }
/// <summary>
/// For purposes of generating the renderable geometry River segments are further subdivided      such that no quad is of greater width or length than this distance in meters. 
/// </summary>
[MemberGroup("River")]
public float SubdivideLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".SubdivideLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".SubdivideLength", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force River to recreate its geometry.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void regenerate(){

pInvokes.m_ts.fnRiver_regenerate(_ID);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    BatchSize is not currently used.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBatchSize(float meters){

pInvokes.m_ts.fnRiver_setBatchSize(_ID, meters);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    @see SubdivideLength field.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMaxDivisionSize(float meters){

pInvokes.m_ts.fnRiver_setMaxDivisionSize(_ID, meters);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    @see SegmentLength field.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setMetersPerSegment(float meters){

pInvokes.m_ts.fnRiver_setMetersPerSegment(_ID, meters);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Sets the depth in meters of a particular node.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setNodeDepth(int idx, float meters){

pInvokes.m_ts.fnRiver_setNodeDepth(_ID, idx, meters);
}

#endregion
#region T3D Callbacks

#endregion
public River_Base (){}
}}
