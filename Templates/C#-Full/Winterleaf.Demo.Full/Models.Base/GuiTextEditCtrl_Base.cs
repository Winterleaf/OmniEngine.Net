// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiTextEditCtrl_Base>))]
    public partial class GuiTextEditCtrl_Base : GuiTextCtrl
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
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiTextEditCtrl_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(GuiTextEditCtrl_Base ts)
        {
            if (ReferenceEquals(ts, null))
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
            return (GuiTextEditCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTextEditCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiTextEditCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTextEditCtrl_Base(int simobjectid)
        {
            return (GuiTextEditCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiTextEditCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiTextEditCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTextEditCtrl_Base(uint simobjectid)
        {
            return (GuiTextEditCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTextEditCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// If the attempted text cannot be entered, this sound effect will be played.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public TypeSFXTrackName deniedSound
        {
            get { return Omni.self.GetVar(_ID + ".deniedSound").AsTypeSFXTrackName(); }
            set { Omni.self.SetVar(_ID + ".deniedSound", value.AsString()); }
        }

        /// <summary>
        /// Script command to be called when the Escape key is pressed.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public String escapeCommand
        {
            get { return Omni.self.GetVar(_ID + ".escapeCommand").AsString(); }
            set { Omni.self.SetVar(_ID + ".escapeCommand", value.AsString()); }
        }

        /// <summary>
        /// How large of a history buffer to maintain.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public int historySize
        {
            get { return Omni.self.GetVar(_ID + ".historySize").AsInt(); }
            set { Omni.self.SetVar(_ID + ".historySize", value.AsString()); }
        }

        /// <summary>
        /// If true, all characters entered will be stored in the control, however will display as the character stored in passwordMask.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public bool password
        {
            get { return Omni.self.GetVar(_ID + ".password").AsBool(); }
            set { Omni.self.SetVar(_ID + ".password", value.AsString()); }
        }

        /// <summary>
        /// If 'password' is true, this is the character that will be used to mask the characters in the control.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public String passwordMask
        {
            get { return Omni.self.GetVar(_ID + ".passwordMask").AsString(); }
            set { Omni.self.SetVar(_ID + ".passwordMask", value.AsString()); }
        }

        /// <summary>
        /// If true, every key event will act as if the Enter key was pressed.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public bool sinkAllKeyEvents
        {
            get { return Omni.self.GetVar(_ID + ".sinkAllKeyEvents").AsBool(); }
            set { Omni.self.SetVar(_ID + ".sinkAllKeyEvents", value.AsString()); }
        }

        /// <summary>
        /// If true, when the 'tab' key is pressed, it will act as if the Enter key was pressed on the control.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public bool tabComplete
        {
            get { return Omni.self.GetVar(_ID + ".tabComplete").AsBool(); }
            set { Omni.self.SetVar(_ID + ".tabComplete", value.AsString()); }
        }

        /// <summary>
        /// Script command to be called when the first validater is lost.\n
        /// </summary>
        [MemberGroup("Text Input")]
        public String validate
        {
            get { return Omni.self.GetVar(_ID + ".validate").AsString(); }
            set { Omni.self.SetVar(_ID + ".validate", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// textEditCtrl.selectText( %startBlock, %endBlock ) )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void selectText(int startBlock, int endBlock)
        {
            m_ts.fn_GuiTextEditCtrl_selectText(_ID, startBlock, endBlock);
        }

        /// <summary>
        /// @brief Unselects all selected text in the control.   @tsexample   // Inform the control to unselect all of its selected text   %thisGuiTextEditCtrl.clearSelectedText();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearSelectedText()
        {
            m_ts.fnGuiTextEditCtrl_clearSelectedText(_ID);
        }

        /// <summary>
        /// @brief Force a validation to occur.   @tsexample   // Inform the control to force a validation of its text.   %thisGuiTextEditCtrl.forceValidateText();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void forceValidateText()
        {
            m_ts.fnGuiTextEditCtrl_forceValidateText(_ID);
        }

        /// <summary>
        /// @brief Returns the current position of the text cursor in the control.   @tsexample   // Acquire the cursor position in the control   %position = %thisGuiTextEditCtrl.getCursorPost();   @endtsexample   @return Text cursor position within the control.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getCursorPos()
        {
            return m_ts.fnGuiTextEditCtrl_getCursorPos(_ID);
        }

        /// <summary>
        /// @brief Acquires the current text displayed in this control.   @tsexample   // Acquire the value of the text control.   %text = %thisGuiTextEditCtrl.getText();   @endtsexample   @return The current text within the control.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getText()
        {
            return m_ts.fnGuiTextEditCtrl_getText(_ID);
        }

        /// <summary>
        /// @brief Checks to see if all text in the control has been selected.   @tsexample   // Check to see if all text has been selected or not.   %allSelected = %thisGuiTextEditCtrl.isAllTextSelected();   @endtsexample   @return True if all text in the control is selected, otherwise false.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isAllTextSelected()
        {
            return m_ts.fnGuiTextEditCtrl_isAllTextSelected(_ID);
        }

        /// <summary>
        /// @brief Selects all text within the control.   @tsexample   // Inform the control to select all of its text.   %thisGuiTextEditCtrl.selectAllText();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void selectAllText()
        {
            m_ts.fnGuiTextEditCtrl_selectAllText(_ID);
        }

        /// <summary>
        /// @brief Sets the text cursor at the defined position within the control.   @param position Text position to set the text cursor.   @tsexample   // Define the cursor position   %position = \"12\";   // Inform the GuiTextEditCtrl control to place the text cursor at the defined position   %thisGuiTextEditCtrl.setCursorPos(%position);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCursorPos(int position)
        {
            m_ts.fnGuiTextEditCtrl_setCursorPos(_ID, position);
        }

        /// <summary>
        /// @brief Sets the text in the control.   @param text Text to place in the control.   @tsexample   // Define the text to display   %text = \"Text!\"   // Inform the GuiTextEditCtrl to display the defined text   %thisGuiTextEditCtrl.setText(%text);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void setText(string text)
        {
            m_ts.fnGuiTextEditCtrl_setText(_ID, text);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called if tabComplete is true, and the 'tab' key is pressed.   @param val Input to mimick the '1' sent by the actual tab key button press.   @tsexample   // Tab key has been pressed, causing the callback to occur.   GuiTextEditCtrl::onTabComplete(%this,%val)   	{   		//Code to run when the onTabComplete callback occurs   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTabComplete(string val)
        {
        }

        /// <summary>
        /// @brief Called when the 'Return' or 'Enter' key is pressed.   @tsexample   // Return or Enter key was pressed, causing the callback to occur.   GuiTextEditCtrl::onReturn(%this)   	{   		// Code to run when the onReturn callback occurs   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onReturn()
        {
        }

        /// <summary>
        /// @brief Called whenever the control is validated.   @tsexample   // The control gets validated, causing the callback to occur   GuiTextEditCtrl::onValidated(%this)   	{   		// Code to run when the control is validated   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onValidate()
        {
        }

        /// <summary>
        /// @brief Called whenever the cursor changes position.   @tsexample   // The control gets validated, causing the callback to occur   GuiTextEditCtrl::onChangeCursorPos(%this)   	{   		// Code to run when the control is validated   	}   @endtsexample   @see GuiTextCtrl   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onChangeCursorPos(int newPosition)
        {
        }

        #endregion

        public GuiTextEditCtrl_Base()
        {
        }
    }
}