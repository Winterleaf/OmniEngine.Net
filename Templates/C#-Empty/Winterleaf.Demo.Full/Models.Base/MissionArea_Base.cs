


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
    [TypeConverter(typeof(TypeConverterGeneric<MissionArea_Base>))]
    public partial class MissionArea_Base: NetObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MissionArea_Base ts, string simobjectid)
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
        public static bool operator !=(MissionArea_Base ts, string simobjectid)
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
        public static implicit operator string( MissionArea_Base ts)
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
        public static implicit operator MissionArea_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (MissionArea_Base) Omni.self.getSimObject(simobjectid,typeof(MissionArea_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( MissionArea_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MissionArea_Base(int simobjectid)
            {
            return  (MissionArea) Omni.self.getSimObject((uint)simobjectid,typeof(MissionArea_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( MissionArea_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MissionArea_Base(uint simobjectid)
            {
            return  (MissionArea_Base) Omni.self.getSimObject(simobjectid,typeof(MissionArea_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Four corners (X1, X2, Y1, Y2) that makes up the level's boundaries
/// </summary>
[MemberGroup("Dimensions")]
public RectI area
       {
       get
          {
          return Omni.self.GetVar(_ID + ".area").AsRectI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".area", value.AsString());
          }
       }
/// <summary>
/// Represents the top of the mission area, used by FlyingVehicle. 
/// </summary>
[MemberGroup("Dimensions")]
public float flightCeiling
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flightCeiling").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flightCeiling", value.AsString());
          }
       }
/// <summary>
/// Distance from ceiling before FlyingVehicle thrust is cut off. 
/// </summary>
[MemberGroup("Dimensions")]
public float flightCeilingRange
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flightCeilingRange").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flightCeilingRange", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Returns 4 fields: starting x, starting y, extents x, extents y.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getArea(){

return pInvokes.m_ts.fnMissionArea_getArea(_ID);
}
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force trigger an inspectPostApply. This will transmit 
///                    material and other fields ( not including nodes ) to client objects.
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fnMissionArea_postApply(_ID);
}
/// <summary>
/// @brief - Defines the size of the MissionArea
/// 			  param x Starting X coordinate position for MissionArea
/// 			  param y Starting Y coordinate position for MissionArea
/// 			  param width New width of the MissionArea
/// 			  param height New height of the MissionArea
///            @note Only the server object may be set.
/// 			  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setArea(int x, int y, int width, int height){

pInvokes.m_ts.fnMissionArea_setArea(_ID, x, y, width, height);
}

#endregion
#region T3D Callbacks

#endregion
public MissionArea_Base (){}
}}
