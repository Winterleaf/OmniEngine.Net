


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiSpeedometerHud_Base>))]
    public partial class GuiSpeedometerHud_Base: GuiBitmapCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiSpeedometerHud_Base ts, string simobjectid)
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
        public static bool operator !=(GuiSpeedometerHud_Base ts, string simobjectid)
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
        public static implicit operator string( GuiSpeedometerHud_Base ts)
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
        public static implicit operator GuiSpeedometerHud_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiSpeedometerHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSpeedometerHud_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiSpeedometerHud_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiSpeedometerHud_Base(int simobjectid)
            {
            return  (GuiSpeedometerHud) Omni.self.getSimObject((uint)simobjectid,typeof(GuiSpeedometerHud_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiSpeedometerHud_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiSpeedometerHud_Base(uint simobjectid)
            {
            return  (GuiSpeedometerHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSpeedometerHud_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Center of the needle, offset from the GuiSpeedometerHud control top    left corner 
/// </summary>
[MemberGroup("Needle")]
public Point2F center
       {
       get
          {
          return Omni.self.GetVar(_ID + ".center").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".center", value.AsString());
          }
       }
/// <summary>
/// Color of the needle 
/// </summary>
[MemberGroup("Needle")]
public ColorF color
       {
       get
          {
          return Omni.self.GetVar(_ID + ".color").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".color", value.AsString());
          }
       }
/// <summary>
/// Length of the needle from center to end 
/// </summary>
[MemberGroup("Needle")]
public float length
       {
       get
          {
          return Omni.self.GetVar(_ID + ".length").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".length", value.AsString());
          }
       }
/// <summary>
/// Angle (in radians) of the needle when the Vehicle speed is = maxSpeed.    An angle of 0 points right, 90 points up etc). 
/// </summary>
[MemberGroup("Needle")]
public float maxAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxAngle", value.AsString());
          }
       }
/// <summary>
/// Maximum Vehicle speed (in Torque units per second) to represent on the    speedo (Vehicle speeds greater than this are clamped to maxSpeed). 
/// </summary>
[MemberGroup("Needle")]
public float maxSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxSpeed", value.AsString());
          }
       }
/// <summary>
/// Angle (in radians) of the needle when the Vehicle speed is 0. An angle    of 0 points right, 90 points up etc). 
/// </summary>
[MemberGroup("Needle")]
public float minAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".minAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".minAngle", value.AsString());
          }
       }
/// <summary>
/// Length of the needle from center to tail 
/// </summary>
[MemberGroup("Needle")]
public float tail
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tail").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tail", value.AsString());
          }
       }
/// <summary>
/// Width of the needle 
/// </summary>
[MemberGroup("Needle")]
public float width
       {
       get
          {
          return Omni.self.GetVar(_ID + ".width").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".width", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiSpeedometerHud_Base (){}
}}
