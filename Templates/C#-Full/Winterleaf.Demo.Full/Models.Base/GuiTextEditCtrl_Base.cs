


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTextEditCtrl_Base>))]
    public partial class GuiTextEditCtrl_Base: GuiTextCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTextEditCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTextEditCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTextEditCtrl_Base ts)
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
        public static implicit operator GuiTextEditCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTextEditCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextEditCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTextEditCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTextEditCtrl_Base(int simobjectid)
            {
            return  (GuiTextEditCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTextEditCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTextEditCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTextEditCtrl_Base(uint simobjectid)
            {
            return  (GuiTextEditCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTextEditCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If the attempted text cannot be entered, this sound effect will be played.\n
/// </summary>
[MemberGroup("Text Input")]
public TypeSFXTrackName deniedSound
       {
       get
          {
          return Omni.self.GetVar(_ID + ".deniedSound").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".deniedSound", value.AsString());
          }
       }
/// <summary>
/// Script command to be called when the Escape key is pressed.\n
/// </summary>
[MemberGroup("Text Input")]
public String escapeCommand
       {
       get
          {
          return Omni.self.GetVar(_ID + ".escapeCommand").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".escapeCommand", value.AsString());
          }
       }
/// <summary>
/// How large of a history buffer to maintain.\n
/// </summary>
[MemberGroup("Text Input")]
public int historySize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".historySize").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".historySize", value.AsString());
          }
       }
/// <summary>
/// If true, all characters entered will be stored in the control, however will display as the character stored in passwordMask.\n
/// </summary>
[MemberGroup("Text Input")]
public bool password
       {
       get
          {
          return Omni.self.GetVar(_ID + ".password").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".password", value.AsString());
          }
       }
/// <summary>
/// If 'password' is true, this is the character that will be used to mask the characters in the control.\n
/// </summary>
[MemberGroup("Text Input")]
public String passwordMask
       {
       get
          {
          return Omni.self.GetVar(_ID + ".passwordMask").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".passwordMask", value.AsString());
          }
       }
/// <summary>
/// If true, every key event will act as if the Enter key was pressed.\n
/// </summary>
[MemberGroup("Text Input")]
public bool sinkAllKeyEvents
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sinkAllKeyEvents").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sinkAllKeyEvents", value.AsString());
          }
       }
/// <summary>
/// If true, when the 'tab' key is pressed, it will act as if the Enter key was pressed on the control.\n
/// </summary>
[MemberGroup("Text Input")]
public bool tabComplete
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tabComplete").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tabComplete", value.AsString());
          }
       }
/// <summary>
/// Script command to be called when the first validater is lost.\n
/// </summary>
[MemberGroup("Text Input")]
public String validate
       {
       get
          {
          return Omni.self.GetVar(_ID + ".validate").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".validate", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// textEditCtrl.selectText( %startBlock, %endBlock ) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectText(int startBlock, int endBlock){

pInvokes.m_ts.fn_GuiTextEditCtrl_selectText(_ID, startBlock, endBlock);
}
/// <summary>
/// @brief Unselects all selected text in the control.
///    @tsexample
///    // Inform the control to unselect all of its selected text
///    %thisGuiTextEditCtrl.clearSelectedText();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearSelectedText(){

pInvokes.m_ts.fnGuiTextEditCtrl_clearSelectedText(_ID);
}
/// <summary>
/// @brief Force a validation to occur.
///    @tsexample
///    // Inform the control to force a validation of its text.
///    %thisGuiTextEditCtrl.forceValidateText();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceValidateText(){

pInvokes.m_ts.fnGuiTextEditCtrl_forceValidateText(_ID);
}
/// <summary>
/// @brief Returns the current position of the text cursor in the control.
///    @tsexample
///    // Acquire the cursor position in the control
///    %position = %thisGuiTextEditCtrl.getCursorPost();
///    @endtsexample
///    @return Text cursor position within the control.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getCursorPos(){

return pInvokes.m_ts.fnGuiTextEditCtrl_getCursorPos(_ID);
}
/// <summary>
/// @brief Acquires the current text displayed in this control.
///    @tsexample
///    // Acquire the value of the text control.
///    %text = %thisGuiTextEditCtrl.getText();
///    @endtsexample
///    @return The current text within the control.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getText(){

return pInvokes.m_ts.fnGuiTextEditCtrl_getText(_ID);
}
/// <summary>
/// @brief Checks to see if all text in the control has been selected.
///    @tsexample
///    // Check to see if all text has been selected or not.
///    %allSelected = %thisGuiTextEditCtrl.isAllTextSelected();
///    @endtsexample
///    @return True if all text in the control is selected, otherwise false.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isAllTextSelected(){

return pInvokes.m_ts.fnGuiTextEditCtrl_isAllTextSelected(_ID);
}
/// <summary>
/// @brief Selects all text within the control.
///    @tsexample
///    // Inform the control to select all of its text.
///    %thisGuiTextEditCtrl.selectAllText();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void selectAllText(){

pInvokes.m_ts.fnGuiTextEditCtrl_selectAllText(_ID);
}
/// <summary>
/// @brief Sets the text cursor at the defined position within the control.
///    @param position Text position to set the text cursor.
///    @tsexample
///    // Define the cursor position
///    %position = \"12\";
///    // Inform the GuiTextEditCtrl control to place the text cursor at the defined position
///    %thisGuiTextEditCtrl.setCursorPos(%position);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCursorPos(int position){

pInvokes.m_ts.fnGuiTextEditCtrl_setCursorPos(_ID, position);
}
/// <summary>
/// @brief Sets the text in the control.
///    @param text Text to place in the control.
///    @tsexample
///    // Define the text to display
///    %text = \"Text!\"
///    // Inform the GuiTextEditCtrl to display the defined text
///    %thisGuiTextEditCtrl.setText(%text);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  new  void setText(string text){

pInvokes.m_ts.fnGuiTextEditCtrl_setText(_ID, text);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called if tabComplete is true, and the 'tab' key is pressed.   @param val Input to mimick the '1' sent by the actual tab key button press.   @tsexample   // Tab key has been pressed, causing the callback to occur.   GuiTextEditCtrl::onTabComplete(%this,%val)   	{   		//Code to run when the onTabComplete callback occurs   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTabComplete(string val){}

        /// <summary>
        /// @brief Called when the 'Return' or 'Enter' key is pressed.   @tsexample   // Return or Enter key was pressed, causing the callback to occur.   GuiTextEditCtrl::onReturn(%this)   	{   		// Code to run when the onReturn callback occurs   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onReturn(){}

        /// <summary>
        /// @brief Called whenever the control is validated.   @tsexample   // The control gets validated, causing the callback to occur   GuiTextEditCtrl::onValidated(%this)   	{   		// Code to run when the control is validated   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onValidate(){}

        /// <summary>
        /// @brief Called whenever the cursor changes position.   @tsexample   // The control gets validated, causing the callback to occur   GuiTextEditCtrl::onChangeCursorPos(%this)   	{   		// Code to run when the control is validated   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onChangeCursorPos(int newPosition){}

#endregion
public GuiTextEditCtrl_Base (){}
}}
