


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiClockHud_Base>))]
    public partial class GuiClockHud_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiClockHud_Base ts, string simobjectid)
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
        public static bool operator !=(GuiClockHud_Base ts, string simobjectid)
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
        public static implicit operator string( GuiClockHud_Base ts)
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
        public static implicit operator GuiClockHud_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiClockHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiClockHud_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiClockHud_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiClockHud_Base(int simobjectid)
            {
            return  (GuiClockHud) Omni.self.getSimObject((uint)simobjectid,typeof(GuiClockHud_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiClockHud_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiClockHud_Base(uint simobjectid)
            {
            return  (GuiClockHud_Base) Omni.self.getSimObject(simobjectid,typeof(GuiClockHud_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Standard color for the background of the control. 
/// </summary>
[MemberGroup("Misc")]
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
[MemberGroup("Misc")]
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
/// If true, draws a background color behind the control.
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
/// If true, draws a frame around the control. 
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
/// <summary>
/// Color for the text on this control. 
/// </summary>
[MemberGroup("Misc")]
public ColorF textColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textColor", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Returns the current time, in seconds.
/// 													@return timeInseconds Current time, in seconds
/// 													@tsexample
/// 														// Get the current time from the GuiClockHud control
/// 														%timeInSeconds = %guiClockHud.getTime();
/// 													@endtsexample
/// 				  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getTime(){

return pInvokes.m_ts.fnGuiClockHud_getTime(_ID);
}
/// <summary>
/// @brief Sets a time for a countdown clock.
///    												Setting the time like this will cause the clock to count backwards from the specified time.
/// 													@param timeInSeconds Time to set the clock, in seconds (IE: 00:02 would be 120)
/// 													@see setTime
/// 				  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setReverseTime(float timeInSeconds = 60){

pInvokes.m_ts.fnGuiClockHud_setReverseTime(_ID, timeInSeconds);
}
/// <summary>
/// Sets the current base time for the clock.
/// 													@param timeInSeconds Time to set the clock, in seconds (IE: 00:02 would be 120)
/// 													@tsexample
/// 														// Define the time, in seconds
/// 														%timeInSeconds = 120;
/// 														// Change the time on the GuiClockHud control
/// 														%guiClockHud.setTime(%timeInSeconds);
/// 													@endtsexample
/// 				  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTime(float timeInSeconds = 60){

pInvokes.m_ts.fnGuiClockHud_setTime(_ID, timeInSeconds);
}

#endregion
#region T3D Callbacks

#endregion
public GuiClockHud_Base (){}
}}
