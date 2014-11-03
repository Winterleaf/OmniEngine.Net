


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiSliderCtrl_Base>))]
    public partial class GuiSliderCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiSliderCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiSliderCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiSliderCtrl_Base ts)
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
        public static implicit operator GuiSliderCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiSliderCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSliderCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiSliderCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiSliderCtrl_Base(int simobjectid)
            {
            return  (GuiSliderCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiSliderCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiSliderCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiSliderCtrl_Base(uint simobjectid)
            {
            return  (GuiSliderCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiSliderCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Min and max values corresponding to left and right slider position. 
/// </summary>
[MemberGroup("Slider")]
public Point2F range
       {
       get
          {
          return Omni.self.GetVar(_ID + ".range").AsPoint2F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".range", value.AsString());
          }
       }
/// <summary>
/// Whether to snap the slider to tick marks. 
/// </summary>
[MemberGroup("Slider")]
public bool snap
       {
       get
          {
          return Omni.self.GetVar(_ID + ".snap").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".snap", value.AsString());
          }
       }
/// <summary>
/// Spacing between tick marks in pixels. 0=off. 
/// </summary>
[MemberGroup("Slider")]
public int ticks
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ticks").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ticks", value.AsString());
          }
       }
/// <summary>
/// The value corresponding to the current slider position. 
/// </summary>
[MemberGroup("Slider")]
public float value
       {
       get
          {
          return Omni.self.GetVar(_ID + ".value").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".value", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the current value of the slider based on the position of the thumb.
///    @return Slider position (from range.x to range.y). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  float getValue(){

return pInvokes.m_ts.fnGuiSliderCtrl_getValue(_ID);
}
/// <summary>
/// Returns true if the thumb is currently being dragged by the user.  This method is mainly useful 
///    for scrubbing type sliders where the slider position is sync'd to a changing value.  When the 
///    user is dragging the thumb, however, the sync'ing should pause and not get in the way of the user. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isThumbBeingDragged(){

return pInvokes.m_ts.fnGuiSliderCtrl_isThumbBeingDragged(_ID);
}
/// <summary>
/// Set position of the thumb on the slider.
///    @param pos New slider position (from range.x to range.y)
///    @param doCallback If true, the altCommand callback will be invoked )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setValue(float pos, bool doCallback = false){

pInvokes.m_ts.fnGuiSliderCtrl_setValue(_ID, pos, doCallback);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the left mouse button is dragged across the slider. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDragged(){}

#endregion
public GuiSliderCtrl_Base (){}
}}
