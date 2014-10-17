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
    [TypeConverter(typeof (TypeConverterGeneric<GuiTableControl_Base>))]
    public partial class GuiTableControl_Base : GuiScrollCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTableControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTableControl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiTableControl_Base ts)
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
        public static implicit operator GuiTableControl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiTableControl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTableControl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiTableControl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTableControl_Base(int simobjectid)
        {
            return (GuiTableControl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiTableControl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiTableControl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTableControl_Base(uint simobjectid)
        {
            return (GuiTableControl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTableControl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// A vector of column offsets. The number of values determines the number of columns in the table.\n 
        /// </summary>
        [MemberGroup("")]
        public VectorInt columns
        {
            get { return Omni.self.GetVar(_ID + ".columns").AsVectorInt(); }
            set { Omni.self.SetVar(_ID + ".columns", value.AsString()); }
        }

        /// <summary>
        /// If true, the width of this control will match the width of its parent.\n
        /// </summary>
        [MemberGroup("")]
        public bool fitParentWidth
        {
            get { return Omni.self.GetVar(_ID + ".fitParentWidth").AsBool(); }
            set { Omni.self.SetVar(_ID + ".fitParentWidth", value.AsString()); }
        }

        /// <summary>
        /// The size of the heading.\n 
        /// </summary>
        [MemberGroup("")]
        public int headingSize
        {
            get { return Omni.self.GetVar(_ID + ".headingSize").AsInt(); }
            set { Omni.self.SetVar(_ID + ".headingSize", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addChildRow(string text, int index)
        {
            m_ts.fnGuiTableControl_addChildRow(_ID, text, index);
        }

        /// <summary>
        /// )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addHeading(string text, int index)
        {
            m_ts.fnGuiTableControl_addHeading(_ID, text, index);
        }

        /// <summary>
        /// )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearChildren()
        {
            m_ts.fnGuiTableControl_clearChildren(_ID);
        }

        /// <summary>
        /// )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findColumnTextIndex(int columnId, string columnText)
        {
            return m_ts.fnGuiTableControl_findColumnTextIndex(_ID, columnId, columnText);
        }

        /// <summary>
        /// @brief Returns the selected row index (not the row ID).
        ///    @tsexample
        ///    // Acquire the selected row index
        ///    %rowIndex = %thisGuiTextListCtrl.getSelectedRow();
        ///    @endtsexample
        ///    @return Index of the selected row
        ///    @see GuiControl)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelectedRow()
        {
            return m_ts.fnGuiTableControl_getSelectedRow(_ID);
        }

        /// <summary>
        /// )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setColumnSort(int column, bool ascending)
        {
            m_ts.fnGuiTableControl_setColumnSort(_ID, column, ascending);
        }

        /// <summary>
        /// @briefSelects the specified row.
        ///    @param rowNum Row number to set selected.
        ///    @tsexample
        ///    // Define the row number to set selected
        ///    %rowNum = \"4\";
        ///    %guiTextListCtrl.setSelectedRow(%rowNum);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectedRow(int rowNum)
        {
            m_ts.fnGuiTableControl_setSelectedRow(_ID, rowNum);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Callback when the column is sorted. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onSortedColumn(int columnId, string columnName, bool increasing)
        {
        }

        /// <summary>
        /// @brief Called whenever an item in the list is selected.   @param cellid The ID of the cell that was selected   @param text The text in the selected cel   @tsexample   // A cel in the control was selected, causing the callback to occur   GuiTextListCtrl::onSelect(%this,%callid,%text)   	{   		// Code to run when a cel item is selected   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onSelect(string cellid, string text)
        {
        }

        #endregion

        public GuiTableControl_Base()
        {
        }
    }
}