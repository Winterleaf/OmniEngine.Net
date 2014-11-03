


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
    [TypeConverter(typeof(TypeConverterGeneric<TimeOfDay_Base>))]
    public partial class TimeOfDay_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TimeOfDay_Base ts, string simobjectid)
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
        public static bool operator !=(TimeOfDay_Base ts, string simobjectid)
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
        public static implicit operator string( TimeOfDay_Base ts)
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
        public static implicit operator TimeOfDay_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TimeOfDay_Base) Omni.self.getSimObject(simobjectid,typeof(TimeOfDay_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TimeOfDay_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TimeOfDay_Base(int simobjectid)
            {
            return  (TimeOfDay) Omni.self.getSimObject((uint)simobjectid,typeof(TimeOfDay_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TimeOfDay_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TimeOfDay_Base(uint simobjectid)
            {
            return  (TimeOfDay_Base) Omni.self.getSimObject(simobjectid,typeof(TimeOfDay_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The angle in degrees between global equator and tropic. 
/// </summary>
[MemberGroup("TimeOfDay")]
public float axisTilt
       {
       get
          {
          return Omni.self.GetVar(_ID + ".axisTilt").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".axisTilt", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("TimeOfDay")]
public float azimuthOverride
       {
       get
          {
          return Omni.self.GetVar(_ID + ".azimuthOverride").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".azimuthOverride", value.AsString());
          }
       }
/// <summary>
/// The length of a virtual day in real world seconds. 
/// </summary>
[MemberGroup("TimeOfDay")]
public float dayLength
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dayLength").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dayLength", value.AsString());
          }
       }
/// <summary>
/// Scalar applied to time that elapses while the sun is up. 
/// </summary>
[MemberGroup("TimeOfDay")]
public float dayScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dayScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dayScale", value.AsString());
          }
       }
/// <summary>
/// Scalar applied to time that elapses while the sun is down. 
/// </summary>
[MemberGroup("TimeOfDay")]
public float nightScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".nightScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".nightScale", value.AsString());
          }
       }
/// <summary>
/// True when the TimeOfDay object is operating. 
/// </summary>
[MemberGroup("TimeOfDay")]
public bool play
       {
       get
          {
          return Omni.self.GetVar(_ID + ".play").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".play", value.AsString());
          }
       }
/// <summary>
///  
/// </summary>
[MemberGroup("TimeOfDay")]
public float startTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".startTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".startTime", value.AsString());
          }
       }
/// <summary>
/// Current time of day. 
/// </summary>
[MemberGroup("TimeOfDay")]
public float time
       {
       get
          {
          return Omni.self.GetVar(_ID + ".time").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".time", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addTimeOfDayEvent(float elevation, string identifier){

pInvokes.m_ts.fnTimeOfDay_addTimeOfDayEvent(_ID, elevation, identifier);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void animate(float elevation, float degreesPerSecond){

pInvokes.m_ts.fnTimeOfDay_animate(_ID, elevation, degreesPerSecond);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setDayLength(float seconds){

pInvokes.m_ts.fnTimeOfDay_setDayLength(_ID, seconds);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPlay(bool enabled){

pInvokes.m_ts.fnTimeOfDay_setPlay(_ID, enabled);
}
/// <summary>
///  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTimeOfDay(float time){

pInvokes.m_ts.fnTimeOfDay_setTimeOfDay(_ID, time);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTimeEvent(string identifier, string currentTime, string currentElevation){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAnimateStart(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAnimateDone(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(){}

#endregion
public TimeOfDay_Base (){}
}}
