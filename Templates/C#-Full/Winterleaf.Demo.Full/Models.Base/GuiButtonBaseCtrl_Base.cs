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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiButtonBaseCtrl_Base>))]
    public partial class GuiButtonBaseCtrl_Base : GuiControl
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
        public static bool operator !=(GuiButtonBaseCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiButtonBaseCtrl_Base ts)
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
        public static implicit operator GuiButtonBaseCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiButtonBaseCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiButtonBaseCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiButtonBaseCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiButtonBaseCtrl_Base(int simobjectid)
        {
            return (GuiButtonBaseCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiButtonBaseCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiButtonBaseCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiButtonBaseCtrl_Base(uint simobjectid)
        {
            return (GuiButtonBaseCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiButtonBaseCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Button behavior type.\n 
        /// </summary>
        [MemberGroup("Button")]
        public TypeGuiButtonType buttonType
        {
            get { return (TypeGuiButtonType) Omni.self.GetVar(_ID + ".buttonType"); }
            set { Omni.self.SetVar(_ID + ".buttonType", value.ToString()); }
        }

        /// <summary>
        /// Changes the texture of the control 
        /// </summary>
        [MemberGroup("Button")]
        public TypeImageFilename changeTexture
        {
            get { return Omni.self.GetVar(_ID + ".changeTexture").AsTypeImageFilename(); }
            set { Omni.self.SetVar(_ID + ".changeTexture", value.AsString()); }
        }

        /// <summary>
        /// Radio button toggle group number. All radio buttons that are assigned the same #groupNum and that      are parented to the same control will synchronize their toggle state, i.e. if one radio button is toggled on      all other radio buttons in its group will be toggled off.\n\n     The default group is -1. 
        /// </summary>
        [MemberGroup("Button")]
        public int groupNum
        {
            get { return Omni.self.GetVar(_ID + ".groupNum").AsInt(); }
            set { Omni.self.SetVar(_ID + ".groupNum", value.AsString()); }
        }

        /// <summary>
        /// Text label to display on button (if button class supports text labels). 
        /// </summary>
        [MemberGroup("Button")]
        public String text
        {
            get { return Omni.self.GetVar(_ID + ".text").AsString(); }
            set { Omni.self.SetVar(_ID + ".text", value.AsString()); }
        }

        /// <summary>
        /// ID of string in string table to use for text label on button.\n\n     @see setTextID\n     @see GuiControl::langTableMod\n     @see LangTable\n\n 
        /// </summary>
        [MemberGroup("Button")]
        public String textID
        {
            get { return Omni.self.GetVar(_ID + ".textID").AsString(); }
            set { Omni.self.SetVar(_ID + ".textID", value.AsString()); }
        }

        /// <summary>
        /// If true, mouse events will be passed on to script. Default is false.\n 
        /// </summary>
        [MemberGroup("Button")]
        public bool useMouseEvents
        {
            get { return Omni.self.GetVar(_ID + ".useMouseEvents").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useMouseEvents", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Get the text display on the button's label (if any).   @return The button's label. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getText()
        {
            return m_ts.fnGuiButtonBaseCtrl_getText(_ID);
        }

        /// <summary>
        /// Simulate a click on the button.   This method will trigger the button's action just as if the button had been pressed by the    user. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void performClick()
        {
            m_ts.fnGuiButtonBaseCtrl_performClick(_ID);
        }

        /// <summary>
        /// Reset the mousing state of the button.   This method should not generally be called. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void resetState()
        {
            m_ts.fnGuiButtonBaseCtrl_resetState(_ID);
        }

        /// <summary>
        /// For toggle or radio buttons, set whether the button is currently activated or not.  For radio buttons,    toggling a button on will toggle all other radio buttons in its group to off.   @param isOn If true, the button will be toggled on (if not already); if false, it will be toggled off.   @note Toggling the state of a button with this method will em>not/em> not trigger the action associated with the       button.  To do that, use performClick(). )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setStateOn(bool isOn = true)
        {
            m_ts.fnGuiButtonBaseCtrl_setStateOn(_ID, isOn);
        }

        /// <summary>
        /// Set the text displayed on the button's label.   @param text The text to display as the button's text label.   @note Not all buttons render text labels.   @see getText   @see setTextID )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setText(string text)
        {
            m_ts.fnGuiButtonBaseCtrl_setText(_ID, text);
        }

        /// <summary>
        /// Set the text displayed on the button's label using a string from the string table    assigned to the control.   @param id Name of the variable that contains the integer string ID.  Used to look up       string in table.   @note Not all buttons render text labels.   @see setText   @see getText   @see GuiControl::langTableMod   @see LangTable   @ref Gui_i18n )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTextID(string id)
        {
            m_ts.fnGuiButtonBaseCtrl_setTextID(_ID, id);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// If #useMouseEvents is true, this is called when the left mouse button is pressed on an (active)    button. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseDown()
        {
        }

        /// <summary>
        /// If #useMouseEvents is true, this is called when the left mouse button is release over an (active)    button.   @note To trigger actions, better use onClick() since onMouseUp() will also be called when the mouse was       not originally pressed on the button. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseUp()
        {
        }

        /// <summary>
        /// Called when the left mouse button is double-clicked on the button. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDoubleClick()
        {
        }

        /// <summary>
        /// Called when the right mouse button is clicked on the button. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onRightClick()
        {
        }

        /// <summary>
        /// If #useMouseEvents is true, this is called when the mouse cursor moves over the button (only if the button    is the front-most visible control, though). )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseEnter()
        {
        }

        /// <summary>
        /// If #useMouseEvents is true, this is called when the mouse cursor moves off the button (only if the button    had previously received an onMouseEvent() event). )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseLeave()
        {
        }

        /// <summary>
        /// If #useMouseEvents is true, this is called when a left mouse button drag is detected, i.e. when the user    pressed the left mouse button on the control and then moves the mouse over a certain distance threshold with    the mouse button still pressed. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseDragged()
        {
        }

        #endregion

        public GuiButtonBaseCtrl_Base()
        {
        }
    }
}