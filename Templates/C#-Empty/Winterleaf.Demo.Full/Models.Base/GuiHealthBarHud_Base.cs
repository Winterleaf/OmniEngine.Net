


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiHealthBarHud_Base>))]
    public partial class GuiHealthBarHud_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiHealthBarHud_Base ts, string simobjectid)
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
        public static bool operator !=(GuiHealthBarHud_Base ts, string simobjectid)
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
        public static implicit operator string( GuiHealthBarHud_Base ts)
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
        public static implicit operator GuiHealthBarHud_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiHealthBarHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiHealthBarHud_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiHealthBarHud_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiHealthBarHud_Base(int simobjectid)
            {
            return  (GuiHealthBarHud) Omni.self.getSimObject((uint)simobjectid,typeof(GuiHealthBarHud_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiHealthBarHud_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiHealthBarHud_Base(uint simobjectid)
            {
            return  (GuiHealthBarHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiHealthBarHud_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// As the health bar depletes, this color will represent the health loss amount. 
/// </summary>
[MemberGroup("Colors")]
public ColorF damageFillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".damageFillColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".damageFillColor", value.AsString());
          }
       }
/// <summary>
/// If true, display the energy value rather than the damage value. 
/// </summary>
[MemberGroup("Misc")]
public bool displayEnergy
       {
       get
          {
          return Omni.self.GetVar(_ID + ".displayEnergy").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".displayEnergy", value.AsString());
          }
       }
/// <summary>
/// Standard color for the background of the control. 
/// </summary>
[MemberGroup("Colors")]
public ColorF fillColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fillColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fillColor", value.AsString());
          }
       }
/// <summary>
/// Color for the control's frame. 
/// </summary>
[MemberGroup("Colors")]
public ColorF frameColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".frameColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".frameColor", value.AsString());
          }
       }
/// <summary>
/// Speed at which the control will pulse. 
/// </summary>
[MemberGroup("Pulse")]
public int pulseRate
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pulseRate").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pulseRate", value.AsString());
          }
       }
/// <summary>
/// Health level the control must be under before the control will pulse. 
/// </summary>
[MemberGroup("Pulse")]
public float pulseThreshold
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pulseThreshold").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pulseThreshold", value.AsString());
          }
       }
/// <summary>
/// If true, we draw the background color of the control. 
/// </summary>
[MemberGroup("Misc")]
public bool showFill
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showFill").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showFill", value.AsString());
          }
       }
/// <summary>
/// If true, we draw the frame of the control. 
/// </summary>
[MemberGroup("Misc")]
public bool showFrame
       {
       get
          {
          return Omni.self.GetVar(_ID + ".showFrame").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".showFrame", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GuiHealthBarHud_Base (){}
}}
