


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiButtonBaseCtrl_Base>))]
    public partial class GuiButtonBaseCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiButtonBaseCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiButtonBaseCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiButtonBaseCtrl_Base ts)
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
        public static implicit operator GuiButtonBaseCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiButtonBaseCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiButtonBaseCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiButtonBaseCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiButtonBaseCtrl_Base(int simobjectid)
            {
            return  (GuiButtonBaseCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiButtonBaseCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiButtonBaseCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiButtonBaseCtrl_Base(uint simobjectid)
            {
            return  (GuiButtonBaseCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiButtonBaseCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Button behavior type.\n 
/// </summary>
[MemberGroup("Button")]
public TypeGuiButtonType buttonType
       {
       get
          {          return (TypeGuiButtonType) Omni.self.GetVar(_ID + ".buttonType");
          }
       set
          {
          Omni.self.SetVar(_ID + ".buttonType", value.ToString());
          }
       }
/// <summary>
/// Changes the texture of the control 
/// </summary>
[MemberGroup("Button")]
public TypeImageFilename changeTexture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".changeTexture").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".changeTexture", value.AsString());
          }
       }
/// <summary>
/// Radio button toggle group number. All radio buttons that are assigned the same #groupNum and that      are parented to the same control will synchronize their toggle state, i.e. if one radio button is toggled on      all other radio buttons in its group will be toggled off.\n\n     The default group is -1. 
/// </summary>
[MemberGroup("Button")]
public int groupNum
       {
       get
          {
          return Omni.self.GetVar(_ID + ".groupNum").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".groupNum", value.AsString());
          }
       }
/// <summary>
/// Text label to display on button (if button class supports text labels). 
/// </summary>
[MemberGroup("Button")]
public String text
       {
       get
          {
          return Omni.self.GetVar(_ID + ".text").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".text", value.AsString());
          }
       }
/// <summary>
/// ID of string in string table to use for text label on button.\n\n     @see setTextID\n     @see GuiControl::langTableMod\n     @see LangTable\n\n 
/// </summary>
[MemberGroup("Button")]
public String textID
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textID").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textID", value.AsString());
          }
       }
/// <summary>
/// If true, mouse events will be passed on to script. Default is false.\n 
/// </summary>
[MemberGroup("Button")]
public bool useMouseEvents
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useMouseEvents").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useMouseEvents", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the text display on the button's label (if any).
///    @return The button's label. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getText(){

return pInvokes.m_ts.fnGuiButtonBaseCtrl_getText(_ID);
}
/// <summary>
/// Simulate a click on the button.
///    This method will trigger the button's action just as if the button had been pressed by the 
///    user. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void performClick(){

pInvokes.m_ts.fnGuiButtonBaseCtrl_performClick(_ID);
}
/// <summary>
/// Reset the mousing state of the button.
///    This method should not generally be called. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetState(){

pInvokes.m_ts.fnGuiButtonBaseCtrl_resetState(_ID);
}
/// <summary>
/// For toggle or radio buttons, set whether the button is currently activated or not.  For radio buttons, 
///    toggling a button on will toggle all other radio buttons in its group to off.
///    @param isOn If true, the button will be toggled on (if not already); if false, it will be toggled off.
///    @note Toggling the state of a button with this method will em>not/em> not trigger the action associated with the 
///       button.  To do that, use performClick(). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setStateOn(bool isOn = true){

pInvokes.m_ts.fnGuiButtonBaseCtrl_setStateOn(_ID, isOn);
}
/// <summary>
/// Set the text displayed on the button's label.
///    @param text The text to display as the button's text label.
///    @note Not all buttons render text labels.
///    @see getText
///    @see setTextID )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setText(string text){

pInvokes.m_ts.fnGuiButtonBaseCtrl_setText(_ID, text);
}
/// <summary>
/// Set the text displayed on the button's label using a string from the string table 
///    assigned to the control.
///    @param id Name of the variable that contains the integer string ID.  Used to look up 
///       string in table.
///    @note Not all buttons render text labels.
///    @see setText
///    @see getText
///    @see GuiControl::langTableMod
///    @see LangTable
///    @ref Gui_i18n )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTextID(string id){

pInvokes.m_ts.fnGuiButtonBaseCtrl_setTextID(_ID, id);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// If #useMouseEvents is true, this is called when the left mouse button is pressed on an (active)    button. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDown(){}

        /// <summary>
        /// If #useMouseEvents is true, this is called when the left mouse button is release over an (active)    button.   @note To trigger actions, better use onClick() since onMouseUp() will also be called when the mouse was       not originally pressed on the button. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseUp(){}

        /// <summary>
        /// Called when the left mouse button is double-clicked on the button. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDoubleClick(){}

        /// <summary>
        /// Called when the right mouse button is clicked on the button. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRightClick(){}

        /// <summary>
        /// If #useMouseEvents is true, this is called when the mouse cursor moves over the button (only if the button    is the front-most visible control, though). )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseEnter(){}

        /// <summary>
        /// If #useMouseEvents is true, this is called when the mouse cursor moves off the button (only if the button    had previously received an onMouseEvent() event). )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseLeave(){}

        /// <summary>
        /// If #useMouseEvents is true, this is called when a left mouse button drag is detected, i.e. when the user    pressed the left mouse button on the control and then moves the mouse over a certain distance threshold with    the mouse button still pressed. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMouseDragged(){}

#endregion
public GuiButtonBaseCtrl_Base (){}
}}
