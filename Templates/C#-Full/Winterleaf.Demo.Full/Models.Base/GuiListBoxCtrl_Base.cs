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
    [TypeConverter(typeof (TypeConverterGeneric<GuiListBoxCtrl_Base>))]
    public partial class GuiListBoxCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiListBoxCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiListBoxCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiListBoxCtrl_Base ts)
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
        public static implicit operator GuiListBoxCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiListBoxCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiListBoxCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiListBoxCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiListBoxCtrl_Base(int simobjectid)
        {
            return (GuiListBoxCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiListBoxCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiListBoxCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiListBoxCtrl_Base(uint simobjectid)
        {
            return (GuiListBoxCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiListBoxCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// If true, will allow the selection of multiple items in the listbox.\n
        /// </summary>
        [MemberGroup("")]
        public bool allowMultipleSelections
        {
            get { return Omni.self.GetVar(_ID + ".allowMultipleSelections").AsBool(); }
            set { Omni.self.SetVar(_ID + ".allowMultipleSelections", value.AsString()); }
        }

        /// <summary>
        /// If true, colored items will render a colored rectangular bullet next to the item text.\n
        /// </summary>
        [MemberGroup("")]
        public bool colorBullet
        {
            get { return Omni.self.GetVar(_ID + ".colorBullet").AsBool(); }
            set { Omni.self.SetVar(_ID + ".colorBullet", value.AsString()); }
        }

        /// <summary>
        /// If true, the width of the listbox will match the width of its parent control.\n
        /// </summary>
        [MemberGroup("")]
        public bool fitParentWidth
        {
            get { return Omni.self.GetVar(_ID + ".fitParentWidth").AsBool(); }
            set { Omni.self.SetVar(_ID + ".fitParentWidth", value.AsString()); }
        }

        /// <summary>
        /// A script snippet to control what is displayed in the list for a SimObject. Within this snippet, $ThisControl is bound to the guiListBoxCtrl and $ThisObject to the contained object in question.\n
        /// </summary>
        [MemberGroup("")]
        public String makeNameCallback
        {
            get { return Omni.self.GetVar(_ID + ".makeNameCallback").AsString(); }
            set { Omni.self.SetVar(_ID + ".makeNameCallback", value.AsString()); }
        }

        /// <summary>
        /// If populated with the name of another GuiListBoxCtrl, then this list box will mirror the contents of the mirrorSet listbox.\n
        /// </summary>
        [MemberGroup("")]
        public String mirrorSet
        {
            get { return Omni.self.GetVar(_ID + ".mirrorSet").AsString(); }
            set { Omni.self.SetVar(_ID + ".mirrorSet", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Checks if there is an item with the exact text of what is passed in, and if so   the item is removed from the list and adds that item's data to the filtered list.   @param itemName Name of the item that we wish to add to the filtered item list of the GuiListBoxCtrl.   @tsexample   // Define the itemName that we wish to add to the filtered item list.   %itemName = \"This Item Name\";   // Add the item name to the filtered item list.   %thisGuiListBoxCtrl.addFilteredItem(%filteredItemName);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addFilteredItem(string newItem)
        {
            m_ts.fnGuiListBoxCtrl_addFilteredItem(_ID, newItem);
        }

        /// <summary>
        ///  ),   @brief Adds an item to the end of the list with an optional color.   @param newItem New item to add to the list.   @param color Optional color parameter to add to the new item.   @tsexample   // Define the item to add to the list.   %newItem = \"Gideon's Blue Coat\";   // Define the optional color for the new list item.   %color = \"0.0 0.0 1.0\";   // Inform the GuiListBoxCtrl object to add the item to the end of the list with the defined color.   %thisGuiListBoxCtrl.addItem(%newItem,%color);   @endtsexample   @return If not void, return value and description   @see GuiControl   @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int addItem(string newItem, string color = "")
        {
            return m_ts.fnGuiListBoxCtrl_addItem(_ID, newItem, color);
        }

        /// <summary>
        /// @brief Removes any custom coloring from an item at the defined index id in the list.   @param index Index id for the item to clear any custom color from.   @tsexample   // Define the index id   %index = \"4\";   // Request the GuiListBoxCtrl object to remove any custom coloring from the defined index entry   %thisGuiListBoxCtrl.clearItemColor(%index);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearItemColor(int index)
        {
            m_ts.fnGuiListBoxCtrl_clearItemColor(_ID, index);
        }

        /// <summary>
        /// @brief Clears all the items in the listbox.   @tsexample   // Inform the GuiListBoxCtrl object to clear all items from its list.   %thisGuiListBoxCtrl.clearItems();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearItems()
        {
            m_ts.fnGuiListBoxCtrl_clearItems(_ID);
        }

        /// <summary>
        /// @brief Sets all currently selected items to unselected.   Detailed description   @tsexample   // Inform the GuiListBoxCtrl object to set all of its items to unselected./n   %thisGuiListBoxCtrl.clearSelection();   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearSelection()
        {
            m_ts.fnGuiListBoxCtrl_clearSelection(_ID);
        }

        /// <summary>
        /// @brief Removes the list entry at the requested index id from the control and clears the memory associated with it.   @param itemIndex Index id location to remove the item from.   @tsexample   // Define the index id we want to remove from the list   %itemIndex = \"8\";   // Inform the GuiListBoxCtrl object to remove the item at the defined index id.   %thisGuiListBoxCtrl.deleteItem(%itemIndex);   @endtsexample   @see References)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void deleteItem(int itemIndex)
        {
            m_ts.fnGuiListBoxCtrl_deleteItem(_ID, itemIndex);
        }

        /// <summary>
        /// @brief Informs the GuiListBoxCtrl object to mirror the contents of the GuiListBoxCtrl stored in the mirrorSet field.   @tsexample   \\ Inform the object to mirror the object located at %thisGuiListBox.mirrorSet   %thisGuiListBox.doMirror();   @endtsexample   @see GuiCore)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void doMirror()
        {
            m_ts.fnGuiListBoxCtrl_doMirror(_ID);
        }

        /// <summary>
        /// @brief Returns index of item with matching text or -1 if none found.   @param findText Text in the list to find.   @param isCaseSensitive If true, the search will be case sensitive.   @tsexample   // Define the text we wish to find in the list.   %findText = \"Hickory Smoked Gideon\"/n/n   // Define if this is a case sensitive search or not.   %isCaseSensitive = \"false\";   // Ask the GuiListBoxCtrl object what item id in the list matches the requested text.   %matchingId = %thisGuiListBoxCtrl.findItemText(%findText,%isCaseSensitive);   @endtsexample   @return Index id of item with matching text or -1 if none found.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findItemText(string findText, bool bCaseSensitive = false)
        {
            return m_ts.fnGuiListBoxCtrl_findItemText(_ID, findText, bCaseSensitive);
        }

        /// <summary>
        /// @brief Returns the number of items in the list.   @tsexample   // Request the number of items in the list of the GuiListBoxCtrl object.   %listItemCount = %thisGuiListBoxCtrl.getItemCount();   @endtsexample   @return The number of items in the list.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getItemCount()
        {
            return m_ts.fnGuiListBoxCtrl_getItemCount(_ID);
        }

        /// <summary>
        /// @brief Returns the object associated with an item. This only makes sense if you are mirroring a simset.   @param index Index id to request the associated item from.   @tsexample   // Define the index id   %index = \"12\";   // Request the item from the GuiListBoxCtrl object   %object = %thisGuiListBoxCtrl.getItemObject(%index);   @endtsexample   @return The object associated with the item in the list.   @see References)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getItemObject(int index)
        {
            return m_ts.fnGuiListBoxCtrl_getItemObject(_ID, index);
        }

        /// <summary>
        /// @brief Returns the text of the item at the specified index.   @param index Index id to return the item text from.   @tsexample   // Define the index id entry to request the text from   %index = \"12\";   // Request the item id text from the GuiListBoxCtrl object.   %text = %thisGuiListBoxCtrl.getItemText(%index);   @endtsexample   @return The text of the requested index id.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getItemText(int index)
        {
            return m_ts.fnGuiListBoxCtrl_getItemText(_ID, index);
        }

        /// <summary>
        /// @brief Request the item index for the item that was last clicked.   @tsexample   // Request the item index for the last clicked item in the list   %lastClickedIndex = %thisGuiListBoxCtrl.getLastClickItem();   @endtsexample   @return Index id for the last clicked item in the list.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getLastClickItem()
        {
            return m_ts.fnGuiListBoxCtrl_getLastClickItem(_ID);
        }

        /// <summary>
        /// @brief Returns the number of items currently selected.   @tsexample   // Request the number of currently selected items   %selectedItemCount = %thisGuiListBoxCtrl.getSelCount();   @endtsexample   @return Number of currently selected items.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelCount()
        {
            return m_ts.fnGuiListBoxCtrl_getSelCount(_ID);
        }

        /// <summary>
        /// @brief Returns the selected items index or -1 if none selected. If multiple selections exist it returns the first selected item.    @tsexample   // Request the index id of the currently selected item   %selectedItemId = %thisGuiListBoxCtrl.getSelectedItem();   @endtsexample   @return The selected items index or -1 if none selected.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelectedItem()
        {
            return m_ts.fnGuiListBoxCtrl_getSelectedItem(_ID);
        }

        /// <summary>
        /// @brief Returns a space delimited list of the selected items indexes in the list.   @tsexample   // Request a space delimited list of the items in the GuiListBoxCtrl object.   %selectionList = %thisGuiListBoxCtrl.getSelectedItems();   @endtsexample   @return Space delimited list of the selected items indexes in the list   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getSelectedItems()
        {
            return m_ts.fnGuiListBoxCtrl_getSelectedItems(_ID);
        }

        /// <summary>
        /// @brief Inserts an item into the list at the specified index and returns the index assigned or -1 on error.   @param text Text item to add.   @param index Index id to insert the list item text at.   @tsexample   // Define the text to insert   %text = \"Secret Agent Gideon\";   // Define the index entry to insert the text at   %index = \"14\";   // In form the GuiListBoxCtrl object to insert the text at the defined index.   %assignedId = %thisGuiListBoxCtrl.insertItem(%text,%index);   @endtsexample   @return If successful will return the index id assigned. If unsuccessful, will return -1.   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void insertItem(string text, int index)
        {
            m_ts.fnGuiListBoxCtrl_insertItem(_ID, text, index);
        }

        /// <summary>
        /// @brief Removes an item of the entered name from the filtered items list.   @param itemName Name of the item to remove from the filtered list.   @tsexample   // Define the itemName that you wish to remove.   %itemName = \"This Item Name\";   // Remove the itemName from the GuiListBoxCtrl   %thisGuiListBoxCtrl.removeFilteredItem(%itemName);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeFilteredItem(string itemName)
        {
            m_ts.fnGuiListBoxCtrl_removeFilteredItem(_ID, itemName);
        }

        /// <summary>
        /// @brief Sets the currently selected item at the specified index.   @param indexId Index Id to set selected.   @tsexample   // Define the index id that we wish to select.   %selectId = \"4\";   // Inform the GuiListBoxCtrl object to set the requested index as selected.   %thisGuiListBoxCtrl.setCurSel(%selectId);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCurSel(int indexId)
        {
            m_ts.fnGuiListBoxCtrl_setCurSel(_ID, indexId);
        }

        /// <summary>
        /// @brief Sets the current selection range from index start to stop. If no stop is specified it sets from start index to the end of the list   @param indexStart Index Id to start selection.   @param indexStop Index Id to end selection.   @tsexample   // Set start id   %indexStart = \"3\";   // Set end id   %indexEnd = \"6\";   // Request the GuiListBoxCtrl object to select the defined range.   %thisGuiListBoxCtrl.setCurSelRange(%indexStart,%indexEnd);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCurSelRange(int indexStart, int indexStop = 999999)
        {
            m_ts.fnGuiListBoxCtrl_setCurSelRange(_ID, indexStart, indexStop);
        }

        /// <summary>
        /// @brief Sets the color of a single list entry at the specified index id.   @param index Index id to modify the color of in the list.   @param color Color value to set the list entry to.   @tsexample   // Define the index id value   %index = \"5\";   // Define the color value   %color = \"1.0 0.0 0.0\";   // Inform the GuiListBoxCtrl object to change the color of the requested index   %thisGuiListBoxCtrl.setItemColor(%index,%color);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setItemColor(int index, ColorF color)
        {
            m_ts.fnGuiListBoxCtrl_setItemColor(_ID, index, color.AsString());
        }

        /// <summary>
        /// @brief Sets the items text at the specified index.   @param index Index id to set the item text at.   @param newtext Text to change the list item at index id to.   @tsexample   // Define the index id/n   %index = \"12\";   // Define the text to set the list item to   %newtext = \"Gideon's Fancy Goggles\";   // Inform the GuiListBoxCtrl object to change the text at the requested index   %thisGuiListBoxCtrl.setItemText(%index,%newText);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setItemText(int index, string newtext)
        {
            m_ts.fnGuiListBoxCtrl_setItemText(_ID, index, newtext);
        }

        /// <summary>
        /// @brief Set the tooltip text to display for the given list item.   @param index Index id to change the tooltip text   @param text Text for the tooltip.   @tsexample   // Define the index id   %index = \"12\";   // Define the tooltip text   %tooltip = \"Gideon's goggles can see through space and time.\"   // Inform the GuiListBoxCtrl object to set the tooltop for the item at the defined index id   %thisGuiListBoxCtrl.setItemToolTip(%index,%tooltip);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setItemTooltip(int index, string text)
        {
            m_ts.fnGuiListBoxCtrl_setItemTooltip(_ID, index, text);
        }

        /// <summary>
        /// @brief Enable or disable multiple selections for this GuiListBoxCtrl object.   @param allowMultSelections Boolean variable to set the use of multiple selections or not.   @tsexample   // Define the multiple selection use state.   %allowMultSelections = \"true\";   // Set the allow  multiple selection state on the GuiListBoxCtrl object.   %thisGuiListBoxCtrl.setMultipleSelection(%allowMultSelections);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMultipleSelection(bool allowMultSelections)
        {
            m_ts.fnGuiListBoxCtrl_setMultipleSelection(_ID, allowMultSelections);
        }

        /// <summary>
        /// @brief Sets the item at the index specified to selected or not.   Detailed description   @param index Item index to set selected or unselected.   @param setSelected Boolean selection state to set the requested item index.   @tsexample   // Define the index   %index = \"5\";   // Define the selection state   %selected = \"true\"   // Inform the GuiListBoxCtrl object of the new selection state for the requested index entry.   %thisGuiListBoxCtrl.setSelected(%index,%selected);   @endtsexample   @see GuiControl)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelected(int index, bool setSelected = true)
        {
            m_ts.fnGuiListBoxCtrl_setSelected(_ID, index, setSelected);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called whenever the mouse is dragged across the control.   @tsexample   // Mouse is dragged across the control, causing the callback to occur.   GuiListBoxCtrl::onMouseDragged(%this)   	{   		// Code to run whenever the mouse is dragged across the control   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseDragged()
        {
        }

        /// <summary>
        /// @brief Called whenever a selected item in the list is cleared.   @tsexample   // A selected item is cleared, causing the callback to occur.   GuiListBoxCtrl::onClearSelection(%this)   	{   		// Code to run whenever a selected item is cleared   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onClearSelection()
        {
        }

        /// <summary>
        /// @brief Called whenever a selected item in the list has been unselected.   @param index Index id of the item that was unselected   @param itemText Text for the list entry at the index id that was unselected   @tsexample   // A selected item is unselected, causing the callback to occur   GuiListBoxCtrl::onUnSelect(%this, %indexId, %itemText)   	{   		// Code to run whenever a selected list item is unselected   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onUnSelect(string index, string itemText)
        {
        }

        /// <summary>
        /// @brief Called whenever an item in the list is selected.   @param index Index id for the item in the list that was selected.   @param itemText Text for the list item at the index that was selected.   @tsexample   // An item in the list is selected, causing the callback to occur   GuiListBoxCtrl::onSelect(%this, %index, %itemText)   	{   		// Code to run whenever an item in the list is selected   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onSelect(string index, string itemText)
        {
        }

        /// <summary>
        /// @brief Called whenever an item in the list has been double clicked.   @tsexample   // An item in the list is double clicked, causing the callback to occur.   GuiListBoxCtrl::onDoubleClick(%this)   	{   		// Code to run whenever an item in the control has been double clicked   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDoubleClick()
        {
        }

        /// <summary>
        /// @brief Called whenever the mouse has previously been clicked down (onMouseDown) and has now been raised on the control.   If an item in the list was hit during the click cycle, then the index id of the clicked object along with how many clicks occured are passed   into the callback.   Detailed description   @param itemHit Index id for the list item that was hit   @param mouseClickCount How many mouse clicks occured on this list item   @tsexample   // Mouse was previously clicked down, and now has been released, causing the callback to occur.   GuiListBoxCtrl::onMouseUp(%this, %itemHit, %mouseClickCount)   	{   		// Code to call whenever the mouse has been clicked and released on the control   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMouseUp(string itemHit, string mouseClickCount)
        {
        }

        /// <summary>
        /// @brief Called whenever the Delete key on the keyboard has been pressed while in this control.   @tsexample   // The delete key on the keyboard has been pressed while this control is in focus, causing the callback to occur.   GuiListBoxCtrl::onDeleteKey(%this)   	{   		// Code to call whenever the delete key is pressed   	}   @endtsexample   @see GuiControl)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDeleteKey()
        {
        }

        /// <summary>
        /// @brief Checks if a list item at a defined index id is mirrored, and returns the result.   @param indexIdString Index id of the list to check.   @tsexample   // Engine has requested of the script level to determine if a list entry is mirrored or not.   GuiListBoxCtrl::isObjectMirrored(%this, %indexIdString)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual bool isObjectMirrored(string indexIdString)
        {
            return "0".AsBool();
        }

        #endregion

        public GuiListBoxCtrl_Base()
        {
        }
    }
}