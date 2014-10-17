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
    [TypeConverter(typeof (TypeConverterGeneric<GuiMLTextCtrl_Base>))]
    public partial class GuiMLTextCtrl_Base : GuiControl
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
        public static bool operator !=(GuiMLTextCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiMLTextCtrl_Base ts)
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
        public static implicit operator GuiMLTextCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiMLTextCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiMLTextCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiMLTextCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiMLTextCtrl_Base(int simobjectid)
        {
            return (GuiMLTextCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiMLTextCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiMLTextCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiMLTextCtrl_Base(uint simobjectid)
        {
            return (GuiMLTextCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiMLTextCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// If true, the control will allow characters to have unique colors.
        /// </summary>
        [MemberGroup("Text")]
        public bool allowColorChars
        {
            get { return Omni.self.GetVar(_ID + ".allowColorChars").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowColorChars", value.AsString()); }
        }

        /// <summary>
        /// If the text will not fit in the control, the deniedSound is played.
        /// </summary>
        [MemberGroup("Text")]
        public TypeSFXTrackName deniedSound
        {
            get { return Omni.self.GetVar(_ID + ".deniedSound").AsTypeSFXTrackName(); }
            set { Omni.self.SetVar(_ID + ".deniedSound", value.AsString()); }
        }

        /// <summary>
        /// The number of blank pixels to place between each line.\n
        /// </summary>
        [MemberGroup("Text")]
        public int lineSpacing
        {
            get { return Omni.self.GetVar(_ID + ".lineSpacing").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lineSpacing", value.AsString()); }
        }

        /// <summary>
        /// Maximum number of characters that the control will display.
        /// </summary>
        [MemberGroup("Text")]
        public int maxChars
        {
            get { return Omni.self.GetVar(_ID + ".maxChars").AsInt(); }
            set { Omni.self.SetVar(_ID + ".maxChars", value.AsString()); }
        }

        /// <summary>
        /// Text to display in this control.
        /// </summary>
        [MemberGroup("Text")]
        public String text
        {
            get { return Omni.self.GetVar(_ID + ".text").AsString(); }
            set { Omni.self.SetVar(_ID + ".text", value.AsString()); }
        }

        /// <summary>
        /// If true, the mouse cursor will turn into a hand cursor while over a link in the text.\n																							 This is dependant on the markup language used by the GuiMLTextCtrl\n
        /// </summary>
        [MemberGroup("Text")]
        public bool useURLMouseCursor
        {
            get { return Omni.self.GetVar(_ID + ".useURLMouseCursor").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useURLMouseCursor", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Appends the text in the control with additional text. Also .   @param text New text to append to the existing text.   @param reformat If true, the control will also be visually reset (defaults to true).   @tsexample   // Define new text to add   %text = \"New Text to Add\";   // Set reformat boolean   %reformat = \"true\";   // Inform the control to add the new text   %thisGuiMLTextCtrl.addText(%text,%reformat);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addText(string text, bool reformat = true)
        {
            m_ts.fnGuiMLTextCtrl_addText(_ID, text, reformat);
        }

        /// <summary>
        /// @brief Forces the text control to reflow the text after new text is added, possibly resizing the control.   @tsexample   // Define new text to add   %newText = \"BACON!\";   // Add the new text to the control   %thisGuiMLTextCtrl.addText(%newText);   // Inform the GuiMLTextCtrl object to force a reflow to ensure the added text fits properly.   %thisGuiMLTextCtrl.forceReflow();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void forceReflow()
        {
            m_ts.fnGuiMLTextCtrl_forceReflow(_ID);
        }

        /// <summary>
        /// @brief Returns the text from the control, including TorqueML characters.   @tsexample   // Get the text displayed in the control   %controlText = %thisGuiMLTextCtrl.getText();   @endtsexample   @return Text string displayed in the control, including any TorqueML characters.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getText()
        {
            return m_ts.fnGuiMLTextCtrl_getText(_ID);
        }

        /// <summary>
        /// @brief Scroll to the bottom of the text.   @tsexample   // Inform GuiMLTextCtrl object to scroll to its bottom   %thisGuiMLTextCtrl.scrollToBottom();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void scrollToBottom()
        {
            m_ts.fnGuiMLTextCtrl_scrollToBottom(_ID);
        }

        /// <summary>
        /// @brief Scroll down to a specified tag.   Detailed description   @param tagID TagID to scroll the control to   @tsexample   // Define the TagID we want to scroll the control to   %tagId = \"4\";   // Inform the GuiMLTextCtrl to scroll to the defined TagID   %thisGuiMLTextCtrl.scrollToTag(%tagId);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void scrollToTag(int tagID)
        {
            m_ts.fnGuiMLTextCtrl_scrollToTag(_ID, tagID);
        }

        /// <summary>
        /// @brief Scroll to the top of the text.   @tsexample   // Inform GuiMLTextCtrl object to scroll to its top   %thisGuiMLTextCtrl.scrollToTop();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void scrollToTop(int param1, int param2)
        {
            m_ts.fnGuiMLTextCtrl_scrollToTop(_ID, param1, param2);
        }

        /// <summary>
        /// @brief Sets the alpha value of the control.   @param alphaVal n - 1.0 floating value for the alpha   @tsexample   // Define the alphe value   %alphaVal = \"0.5\";   // Inform the control to update its alpha value.   %thisGuiMLTextCtrl.setAlpha(%alphaVal);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAlpha(float alphaVal)
        {
            m_ts.fnGuiMLTextCtrl_setAlpha(_ID, alphaVal);
        }

        /// <summary>
        /// @brief Change the text cursor's position to a new defined offset within the text in the control.   @param newPos Offset to place cursor.   @tsexample   // Define cursor offset position   %position = \"23\";   // Inform the GuiMLTextCtrl object to move the cursor to the new position.   %thisGuiMLTextCtrl.setCursorPosition(%position);   @endtsexample   @return Returns true if the cursor position moved, or false if the position was not changed.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setCursorPosition(int newPos)
        {
            return m_ts.fnGuiMLTextCtrl_setCursorPosition(_ID, newPos);
        }

        /// <summary>
        /// @brief Set the text contained in the control.   @param text The text to display in the control.   @tsexample   // Define the text to display   %text = \"Nifty Control Text\";   // Set the text displayed within the control   %thisGuiMLTextCtrl.setText(%text);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setText(string text)
        {
            m_ts.fnGuiMLTextCtrl_setText(_ID, text);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called whenever a URL was clicked on within the control.   @param url The URL address that was clicked on.   @tsexample   // A URL address was clicked on in the control, causing the callback to occur.   GuiMLTextCtrl::onUrl(%this,%url)   	{   		// Code to run whenever a URL was clicked on   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onURL(string url)
        {
        }

        /// <summary>
        /// @brief Called whenever the control size changes.   @param width The new width value for the control   @param maxY The current maximum allowed Y value for the control   @tsexample   // Control size changed, causing the callback to occur.   GuiMLTextCtrl::onResize(%this,%width,%maxY)   	{   		// Code to call when the control size changes   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onResize(string width, string maxY)
        {
        }

        #endregion

        public GuiMLTextCtrl_Base()
        {
        }
    }
}