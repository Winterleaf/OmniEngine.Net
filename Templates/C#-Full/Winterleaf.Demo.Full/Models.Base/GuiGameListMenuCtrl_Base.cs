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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiGameListMenuCtrl_Base>))]
    public partial class GuiGameListMenuCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiGameListMenuCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiGameListMenuCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiGameListMenuCtrl_Base ts)
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
        public static implicit operator GuiGameListMenuCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiGameListMenuCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiGameListMenuCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiGameListMenuCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiGameListMenuCtrl_Base(int simobjectid)
        {
            return (GuiGameListMenuCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiGameListMenuCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiGameListMenuCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiGameListMenuCtrl_Base(uint simobjectid)
        {
            return (GuiGameListMenuCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiGameListMenuCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Script callback when the 'A' button is pressed. 'A' inputs are Keyboard: A, Return, Space; Gamepad: A, Start 
        /// </summary>
        [MemberGroup("")]
        public String callbackOnA
        {
            get { return Omni.self.GetVar(_ID + ".callbackOnA").AsString(); }
            set { Omni.self.SetVar(_ID + ".callbackOnA", value.AsString()); }
        }

        /// <summary>
        /// Script callback when the 'B' button is pressed. 'B' inputs are Keyboard: B, Esc, Backspace, Delete; Gamepad: B, Back 
        /// </summary>
        [MemberGroup("")]
        public String callbackOnB
        {
            get { return Omni.self.GetVar(_ID + ".callbackOnB").AsString(); }
            set { Omni.self.SetVar(_ID + ".callbackOnB", value.AsString()); }
        }

        /// <summary>
        /// Script callback when the 'X' button is pressed. 'X' inputs are Keyboard: X; Gamepad: X 
        /// </summary>
        [MemberGroup("")]
        public String callbackOnX
        {
            get { return Omni.self.GetVar(_ID + ".callbackOnX").AsString(); }
            set { Omni.self.SetVar(_ID + ".callbackOnX", value.AsString()); }
        }

        /// <summary>
        /// Script callback when the 'Y' button is pressed. 'Y' inputs are Keyboard: Y; Gamepad: Y 
        /// </summary>
        [MemberGroup("")]
        public String callbackOnY
        {
            get { return Omni.self.GetVar(_ID + ".callbackOnY").AsString(); }
            set { Omni.self.SetVar(_ID + ".callbackOnY", value.AsString()); }
        }

        /// <summary>
        /// Enable debug rendering 
        /// </summary>
        [MemberGroup("")]
        public bool debugRender
        {
            get { return Omni.self.GetVar(_ID + ".debugRender").AsBool(); }
            set { Omni.self.SetVar(_ID + ".debugRender", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Activates the current row. The script callback of  the current row will be called (if it has one). )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void activateRow()
        {
            m_ts.fnGuiGameListMenuCtrl_activateRow(_ID);
        }

        /// <summary>
        /// Add a row to the list control.   @param label The text to display on the row as a label.   @param callback Name of a script function to use as a callback when this row is activated.   @param icon [optional] Index of the icon to use as a marker.   @param yPad [optional] An extra amount of height padding before the row. Does nothing on the first row.   @param useHighlightIcon [optional] Does this row use the highlight icon?.   @param enabled [optional] If this row is initially enabled. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addRow(string label, string callback, int icon = -1, int yPad = 0, bool useHighlightIcon = true, bool enabled = true)
        {
            m_ts.fnGuiGameListMenuCtrl_addRow(_ID, label, callback, icon, yPad, useHighlightIcon, enabled);
        }

        /// <summary>
        /// Gets the number of rows on the control.   @return (int) The number of rows on the control. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRowCount()
        {
            return m_ts.fnGuiGameListMenuCtrl_getRowCount(_ID);
        }

        /// <summary>
        /// Gets the label displayed on the specified row.   @param row Index of the row to get the label of.   @return The label for the row. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getRowLabel(int row)
        {
            return m_ts.fnGuiGameListMenuCtrl_getRowLabel(_ID, row);
        }

        /// <summary>
        /// Gets the index of the currently selected row.   @return Index of the selected row. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelectedRow()
        {
            return m_ts.fnGuiGameListMenuCtrl_getSelectedRow(_ID);
        }

        /// <summary>
        /// Determines if the specified row is enabled or disabled.   @param row The row to set the enabled status of.   @return True if the specified row is enabled. False if the row is not enabled or the given index was not valid. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isRowEnabled(int row)
        {
            return m_ts.fnGuiGameListMenuCtrl_isRowEnabled(_ID, row);
        }

        /// <summary>
        /// Sets a row's enabled status according to the given parameters.   @param row The index to check for validity.   @param enabled Indicate true to enable the row or false to disable it. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRowEnabled(int row, bool enabled)
        {
            m_ts.fnGuiGameListMenuCtrl_setRowEnabled(_ID, row, enabled);
        }

        /// <summary>
        /// Sets the label on the given row.   @param row Index of the row to set the label on.   @param label Text to set as the label of the row. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRowLabel(int row, string label)
        {
            m_ts.fnGuiGameListMenuCtrl_setRowLabel(_ID, row, label);
        }

        /// <summary>
        /// Sets the selected row. Only rows that are enabled can be selected.   @param row Index of the row to set as selected. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelected(int row)
        {
            m_ts.fnGuiGameListMenuCtrl_setSelected(_ID, row);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when the selected row changes. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onChange()
        {
        }

        #endregion

        public GuiGameListMenuCtrl_Base()
        {
        }
    }
}