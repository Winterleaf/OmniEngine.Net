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
    [TypeConverter(typeof (TypeConverterGeneric<GuiTextListCtrl_Base>))]
    public partial class GuiTextListCtrl_Base : GuiArrayCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTextListCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTextListCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiTextListCtrl_Base ts)
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
        public static implicit operator GuiTextListCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiTextListCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTextListCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiTextListCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTextListCtrl_Base(int simobjectid)
        {
            return (GuiTextListCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiTextListCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiTextListCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTextListCtrl_Base(uint simobjectid)
        {
            return (GuiTextListCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTextListCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// If true, text exceeding a column's given width will get clipped.\n 
        /// </summary>
        [MemberGroup("")]
        public bool clipColumnText
        {
            get { return Omni.self.GetVar(_ID + ".clipColumnText").AsBool(); }
            set { Omni.self.SetVar(_ID + ".clipColumnText", value.AsString()); }
        }

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

        #endregion

        #region Member Functions

        /// <summary>
        /// ,-1),   @brief Adds a new row at end of the list with the defined id and text.   If index is used, then the new row is inserted at the row location of 'index'.   @param id Id of the new row.   @param text Text to display at the new row.   @param index Index to insert the new row at. If not used, new row will be placed at the end of the list.   @tsexample   // Define the id   %id = \"4\";   // Define the text to display   %text = \"Display Text\"   // Define the index (optional)   %index = \"2\"   // Inform the GuiTextListCtrl control to add the new row with the defined information.   %rowIndex = %thisGuiTextListCtrl.addRow(%id,%text,%index);   @endtsexample   @return Returns the row index of the new row. If 'index' was defined, then this just returns the number of rows in the list.   @see References)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int addRow(int id = 0, string text = "", int index = -1)
        {
            return m_ts.fnGuiTextListCtrl_addRow(_ID, id, text, index);
        }

        /// <summary>
        /// @brief Clear the list.   @tsexample   // Inform the GuiTextListCtrl control to clear its contents   %thisGuiTextListCtrl.clear();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void clear()
        {
            m_ts.fnGuiTextListCtrl_clear(_ID);
        }

        /// <summary>
        /// @brief Set the selection to nothing.   @tsexample   // Deselect anything that is currently selected   %thisGuiTextListCtrl.clearSelection();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearSelection()
        {
            m_ts.fnGuiTextListCtrl_clearSelection(_ID);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findColumnTextIndex(int columnId, string columnText)
        {
            return m_ts.fnGuiTextListCtrl_findColumnTextIndex(_ID, columnId, columnText);
        }

        /// <summary>
        /// @brief Find needle in the list, and return the row number it was found in.   @param needle Text to find in the list.   @tsexample   // Define the text to find in the list   %needle = \"Text To Find\";   // Request the row number that contains the defined text to find   %rowNumber = %thisGuiTextListCtrl.findTextIndex(%needle);   @endtsexample   @return Row number that the defined text was found in,   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findTextIndex(string needle)
        {
            return m_ts.fnGuiTextListCtrl_findTextIndex(_ID, needle);
        }

        /// <summary>
        /// @brief Get the row ID for an index.   @param index Index to get the RowID at   @tsexample   // Define the index   %index = \"3\";   // Request the row ID at the defined index   %rowId = %thisGuiTextListCtrl.getRowId(%index);   @endtsexample   @return RowId at the defined index.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRowId(int index)
        {
            return m_ts.fnGuiTextListCtrl_getRowId(_ID, index);
        }

        /// <summary>
        /// @brief Get the row number for a specified id.   @param id Id to get the row number at   @tsexample   // Define the id   %id = \"4\";   // Request the row number from the GuiTextListCtrl control at the defined id.   %rowNumber = %thisGuiTextListCtrl.getRowNumById(%id);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRowNumById(int id)
        {
            return m_ts.fnGuiTextListCtrl_getRowNumById(_ID, id);
        }

        /// <summary>
        /// @brief Get the text of the row with the specified index.   @param index Row index to acquire the text at.   @tsexample   // Define the row index   %index = \"5\";   // Request the text from the row at the defined index   %rowText = %thisGuiTextListCtrl.getRowText(%index);   @endtsexample   @return Text at the defined row index.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getRowText(int index)
        {
            return m_ts.fnGuiTextListCtrl_getRowText(_ID, index);
        }

        /// <summary>
        /// @brief Get the text of a row with the specified id.   @tsexample   // Define the id   %id = \"4\";   // Inform the GuiTextListCtrl control to return the text at the defined row id   %rowText = %thisGuiTextListCtrl.getRowTextById(%id);   @endtsexample   @return Row text at the requested row id.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getRowTextById(int id)
        {
            return m_ts.fnGuiTextListCtrl_getRowTextById(_ID, id);
        }

        /// <summary>
        /// @brief Get the ID of the currently selected item.   @tsexample   // Acquire the ID of the selected item in the list.   %id = %thisGuiTextListCtrl.getSelectedId();   @endtsexample   @return The id of the selected item in the list.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelectedId()
        {
            return m_ts.fnGuiTextListCtrl_getSelectedId(_ID);
        }

        /// <summary>
        /// @brief Returns the selected row index (not the row ID).   @tsexample   // Acquire the selected row index   %rowIndex = %thisGuiTextListCtrl.getSelectedRow();   @endtsexample   @return Index of the selected row   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelectedRow()
        {
            return m_ts.fnGuiTextListCtrl_getSelectedRow(_ID);
        }

        /// <summary>
        /// @brief Check if the specified row is currently active or not.   @param rowNum Row number to check the active state.   @tsexample   // Define the row number   %rowNum = \"5\";   // Request the active state of the defined row number from the GuiTextListCtrl control.   %rowActiveState = %thisGuiTextListCtrl.isRowActive(%rowNum);   @endtsexample   @return Active state of the defined row number.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isRowActive(int rowNum)
        {
            return m_ts.fnGuiTextListCtrl_isRowActive(_ID, rowNum);
        }

        /// <summary>
        /// @brief Remove a row from the table, based on its index.   @param index Row index to remove from the list.   @tsexample   // Define the row index   %index = \"4\";   // Inform the GuiTextListCtrl control to remove the row at the defined row index   %thisGuiTextListCtrl.removeRow(%index);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeRow(int index)
        {
            m_ts.fnGuiTextListCtrl_removeRow(_ID, index);
        }

        /// <summary>
        /// @brief Remove row with the specified id.   @param id Id to remove the row entry at   @tsexample   // Define the id   %id = \"4\";   // Inform the GuiTextListCtrl control to remove the row at the defined id   %thisGuiTextListCtrl.removeRowById(%id);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeRowById(int id)
        {
            m_ts.fnGuiTextListCtrl_removeRowById(_ID, id);
        }

        /// <summary>
        /// @brief Get the number of rows.   @tsexample   // Get the number of rows in the list   %rowCount = %thisGuiTextListCtrl.rowCount();   @endtsexample   @return Number of rows in the list.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int rowCount()
        {
            return m_ts.fnGuiTextListCtrl_rowCount(_ID);
        }

        /// <summary>
        /// @brief Scroll so the specified row is visible   @param rowNum Row number to make visible   @tsexample   // Define the row number to make visible   %rowNum = \"4\";   // Inform the GuiTextListCtrl control to scroll the list so the defined rowNum is visible.   %thisGuiTextListCtrl.scrollVisible(%rowNum);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void scrollVisible(int rowNum)
        {
            m_ts.fnGuiTextListCtrl_scrollVisible(_ID, rowNum);
        }

        /// <summary>
        /// @brief Mark a specified row as active/not.   @param rowNum Row number to change the active state.   @param active Boolean active state to set the row number.   @tsexample   // Define the row number   %rowNum = \"4\";   // Define the boolean active state   %active = \"true\";   // Informthe GuiTextListCtrl control to set the defined active state at the defined row number.   %thisGuiTextListCtrl.setRowActive(%rowNum,%active);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRowActive(int rowNum, bool active)
        {
            m_ts.fnGuiTextListCtrl_setRowActive(_ID, rowNum, active);
        }

        /// <summary>
        /// @brief Sets the text at the defined id.   @param id Id to change.   @param text Text to use at the Id.   @tsexample   // Define the id   %id = \"4\";   // Define the text   %text = \"Text To Display\";   // Inform the GuiTextListCtrl control to display the defined text at the defined id   %thisGuiTextListCtrl.setRowById(%id,%text);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRowById(int id, string text)
        {
            m_ts.fnGuiTextListCtrl_setRowById(_ID, id, text);
        }

        /// <summary>
        /// @brief Finds the specified entry by id, then marks its row as selected.   @param id Entry within the text list to make selected.   @tsexample   // Define the id   %id = \"5\";   // Inform the GuiTextListCtrl control to set the defined id entry as selected   %thisGuiTextListCtrl.setSelectedById(%id);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectedById(int id)
        {
            m_ts.fnGuiTextListCtrl_setSelectedById(_ID, id);
        }

        /// <summary>
        /// @briefSelects the specified row.   @param rowNum Row number to set selected.   @tsexample   // Define the row number to set selected   %rowNum = \"4\";   %guiTextListCtrl.setSelectedRow(%rowNum);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelectedRow(int rowNum)
        {
            m_ts.fnGuiTextListCtrl_setSelectedRow(_ID, rowNum);
        }

        /// <summary>
        /// @brief Performs a standard (alphabetical) sort on the values in the specified column.   @param columnId Column ID to perform the sort on.   @param increasing If false, sort will be performed in reverse.   @tsexample   // Define the columnId   %id = \"1\";   // Define if we are increasing or not   %increasing = \"false\";   // Inform the GuiTextListCtrl to perform the sort operation   %thisGuiTextListCtrl.sort(%id,%increasing);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sort(int columnId, bool increasing = true)
        {
            m_ts.fnGuiTextListCtrl_sort(_ID, columnId, increasing);
        }

        /// <summary>
        /// @brief Perform a numerical sort on the values in the specified column.   Detailed description   @param columnId Column ID to perform the sort on.   @param increasing If false, sort will be performed in reverse.   @tsexample   // Define the columnId   %id = \"1\";   // Define if we are increasing or not   %increasing = \"false\";   // Inform the GuiTextListCtrl to perform the sort operation   %thisGuiTextListCtrl.sortNumerical(%id,%increasing);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortNumerical(int columnID, bool increasing = true)
        {
            m_ts.fnGuiTextListCtrl_sortNumerical(_ID, columnID, increasing);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called when the delete key has been pressed.   @param id Id of the selected item in the list   @tsexample   // The delete key was pressed while the GuiTextListCtrl was in focus, causing the callback to occur.   GuiTextListCtrl::onDeleteKey(%this,%id)   	{   		// Code to run when the delete key is pressed   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDeleteKey(string id)
        {
        }

        #endregion

        public GuiTextListCtrl_Base()
        {
        }
    }
}