


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiMLTextCtrl_Base>))]
    public partial class GuiMLTextCtrl_Base: GuiControl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiMLTextCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiMLTextCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiMLTextCtrl_Base ts)
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
        public static implicit operator GuiMLTextCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiMLTextCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMLTextCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiMLTextCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMLTextCtrl_Base(int simobjectid)
            {
            return  (GuiMLTextCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiMLTextCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiMLTextCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMLTextCtrl_Base(uint simobjectid)
            {
            return  (GuiMLTextCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiMLTextCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, the control will allow characters to have unique colors.
/// </summary>
[MemberGroup("Text")]
public bool allowColorChars
       {
       get
          {
          return Omni.self.GetVar(_ID + ".allowColorChars").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".allowColorChars", value.AsString());
          }
       }
/// <summary>
/// If the text will not fit in the control, the deniedSound is played.
/// </summary>
[MemberGroup("Text")]
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
/// The number of blank pixels to place between each line.\n
/// </summary>
[MemberGroup("Text")]
public int lineSpacing
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lineSpacing").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lineSpacing", value.AsString());
          }
       }
/// <summary>
/// Maximum number of characters that the control will display.
/// </summary>
[MemberGroup("Text")]
public int maxChars
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxChars").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxChars", value.AsString());
          }
       }
/// <summary>
/// Text to display in this control.
/// </summary>
[MemberGroup("Text")]
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
/// If true, the mouse cursor will turn into a hand cursor while over a link in the text.\n																							 This is dependant on the markup language used by the GuiMLTextCtrl\n
/// </summary>
[MemberGroup("Text")]
public bool useURLMouseCursor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useURLMouseCursor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useURLMouseCursor", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Appends the text in the control with additional text. Also .
///    @param text New text to append to the existing text.
///    @param reformat If true, the control will also be visually reset (defaults to true).
///    @tsexample
///    // Define new text to add
///    %text = \"New Text to Add\";
///    // Set reformat boolean
///    %reformat = \"true\";
///    // Inform the control to add the new text
///    %thisGuiMLTextCtrl.addText(%text,%reformat);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addText(string text, bool reformat = true){

pInvokes.m_ts.fnGuiMLTextCtrl_addText(_ID, text, reformat);
}
/// <summary>
/// @brief Forces the text control to reflow the text after new text is added, possibly resizing the control.
///    @tsexample
///    // Define new text to add
///    %newText = \"BACON!\";
///    // Add the new text to the control
///    %thisGuiMLTextCtrl.addText(%newText);
///    // Inform the GuiMLTextCtrl object to force a reflow to ensure the added text fits properly.
///    %thisGuiMLTextCtrl.forceReflow();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceReflow(){

pInvokes.m_ts.fnGuiMLTextCtrl_forceReflow(_ID);
}
/// <summary>
/// @brief Returns the text from the control, including TorqueML characters.
///    @tsexample
///    // Get the text displayed in the control
///    %controlText = %thisGuiMLTextCtrl.getText();
///    @endtsexample
///    @return Text string displayed in the control, including any TorqueML characters.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getText(){

return pInvokes.m_ts.fnGuiMLTextCtrl_getText(_ID);
}
/// <summary>
/// @brief Scroll to the bottom of the text.
///    @tsexample
///    // Inform GuiMLTextCtrl object to scroll to its bottom
///    %thisGuiMLTextCtrl.scrollToBottom();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollToBottom(){

pInvokes.m_ts.fnGuiMLTextCtrl_scrollToBottom(_ID);
}
/// <summary>
/// @brief Scroll down to a specified tag.
///    Detailed description
///    @param tagID TagID to scroll the control to
///    @tsexample
///    // Define the TagID we want to scroll the control to
///    %tagId = \"4\";
///    // Inform the GuiMLTextCtrl to scroll to the defined TagID
///    %thisGuiMLTextCtrl.scrollToTag(%tagId);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollToTag(int tagID){

pInvokes.m_ts.fnGuiMLTextCtrl_scrollToTag(_ID, tagID);
}
/// <summary>
/// @brief Scroll to the top of the text.
///    @tsexample
///    // Inform GuiMLTextCtrl object to scroll to its top
///    %thisGuiMLTextCtrl.scrollToTop();
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void scrollToTop(int param1, int param2){

pInvokes.m_ts.fnGuiMLTextCtrl_scrollToTop(_ID, param1, param2);
}
/// <summary>
/// @brief Sets the alpha value of the control.
///    @param alphaVal n - 1.0 floating value for the alpha
///    @tsexample
///    // Define the alphe value
///    %alphaVal = \"0.5\";
///    // Inform the control to update its alpha value.
///    %thisGuiMLTextCtrl.setAlpha(%alphaVal);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAlpha(float alphaVal){

pInvokes.m_ts.fnGuiMLTextCtrl_setAlpha(_ID, alphaVal);
}
/// <summary>
/// @brief Change the text cursor's position to a new defined offset within the text in the control.
///    @param newPos Offset to place cursor.
///    @tsexample
///    // Define cursor offset position
///    %position = \"23\";
///    // Inform the GuiMLTextCtrl object to move the cursor to the new position.
///    %thisGuiMLTextCtrl.setCursorPosition(%position);
///    @endtsexample
///    @return Returns true if the cursor position moved, or false if the position was not changed.
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setCursorPosition(int newPos){

return pInvokes.m_ts.fnGuiMLTextCtrl_setCursorPosition(_ID, newPos);
}
/// <summary>
/// @brief Set the text contained in the control.
///    @param text The text to display in the control.
///    @tsexample
///    // Define the text to display
///    %text = \"Nifty Control Text\";
///    // Set the text displayed within the control
///    %thisGuiMLTextCtrl.setText(%text);
///    @endtsexample
///    @see GuiControl)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setText(string text){

pInvokes.m_ts.fnGuiMLTextCtrl_setText(_ID, text);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called whenever a URL was clicked on within the control.   @param url The URL address that was clicked on.   @tsexample   // A URL address was clicked on in the control, causing the callback to occur.   GuiMLTextCtrl::onUrl(%this,%url)   	{   		// Code to run whenever a URL was clicked on   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onURL(string url){}

        /// <summary>
        /// @brief Called whenever the control size changes.   @param width The new width value for the control   @param maxY The current maximum allowed Y value for the control   @tsexample   // Control size changed, causing the callback to occur.   GuiMLTextCtrl::onResize(%this,%width,%maxY)   	{   		// Code to call when the control size changes   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onResize(string width, string maxY){}

#endregion
public GuiMLTextCtrl_Base (){}
}}
