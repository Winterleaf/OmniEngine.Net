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
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiPopUpMenuCtrlEx_Base>))]
    public partial class GuiPopUpMenuCtrlEx_Base : GuiTextCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiPopUpMenuCtrlEx_Base ts, string simobjectid)
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
        public static bool operator !=(GuiPopUpMenuCtrlEx_Base ts, string simobjectid)
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
        public static implicit operator string(GuiPopUpMenuCtrlEx_Base ts)
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
        public static implicit operator GuiPopUpMenuCtrlEx_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiPopUpMenuCtrlEx_Base) Omni.self.getSimObject(simobjectid, typeof (GuiPopUpMenuCtrlEx_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiPopUpMenuCtrlEx_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiPopUpMenuCtrlEx_Base(int simobjectid)
        {
            return (GuiPopUpMenuCtrlEx) Omni.self.getSimObject((uint) simobjectid, typeof (GuiPopUpMenuCtrlEx_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiPopUpMenuCtrlEx_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiPopUpMenuCtrlEx_Base(uint simobjectid)
        {
            return (GuiPopUpMenuCtrlEx_Base) Omni.self.getSimObject(simobjectid, typeof (GuiPopUpMenuCtrlEx_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// , -1, 0), (string name, int idNum, int scheme=0))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void add(string name = "", int idNum = -1, uint scheme = 0)
        {
            m_ts.fn_GuiPopUpMenuCtrlEx_add(_ID, name, idNum, scheme);
        }

        /// <summary>
        /// (S32 entry))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearEntry(int entry)
        {
            m_ts.fn_GuiPopUpMenuCtrlEx_clearEntry(_ID, entry);
        }

        /// <summary>
        /// (string text)              Returns the id of the first entry containing the specified text or -1 if not found.			  @param text String value used for the query			  @return Numerical ID of entry containing the text.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findText(string text)
        {
            return m_ts.fn_GuiPopUpMenuCtrlEx_findText(_ID, text);
        }

        /// <summary>
        /// @brief Get color of an entry's box			  @param id ID number of entry to query			  @return ColorI in the format of \"Red Green Blue Alpha\", each of with is a value between 0 - 255)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public ColorI getColorById(int id)
        {
            return new ColorI(m_ts.fn_GuiPopUpMenuCtrlEx_getColorById(_ID, id));
        }

        /// <summary>
        /// @brief Flag that causes each new text addition to replace the current entry			  @param True to turn on replacing, false to disable it)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void replaceText(int boolVal)
        {
            m_ts.fn_GuiPopUpMenuCtrlEx_replaceText(_ID, boolVal);
        }

        /// <summary>
        /// @brief This fills the popup with a classrep's field enumeration type info.              More of a helper function than anything.   If console access to the field list is added,               at least for the enumerated types, then this should go away.			  @param class Name of the class containing the enum			  @param enum Name of the enum value to acces)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setEnumContent(string className, string enumName)
        {
            m_ts.fn_GuiPopUpMenuCtrlEx_setEnumContent(_ID, className, enumName);
        }

        /// <summary>
        /// ([scriptCallback=true])			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setFirstSelected(bool scriptCallback = true)
        {
            m_ts.fn_GuiPopUpMenuCtrlEx_setFirstSelected(_ID, scriptCallback);
        }

        /// <summary>
        /// (int id, [scriptCallback=true])			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelected(int id, bool scriptCallback = true)
        {
            m_ts.fn_GuiPopUpMenuCtrlEx_setSelected(_ID, id, scriptCallback);
        }

        /// <summary>
        /// @brief Get the size of the menu			  @return Number of entries in the menu)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int size()
        {
            return m_ts.fn_GuiPopUpMenuCtrlEx_size(_ID);
        }

        /// <summary>
        /// @brief Add a category to the list.				   Acts as a separator between entries, allowing for sub-lists				   @param text Name of the new category)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addCategory(string text)
        {
            m_ts.fnGuiPopUpMenuCtrlEx_addCategory(_ID, text);
        }

        /// <summary>
        /// @brief Create a new scheme and add it to the list of choices for when a new text entry is added.				   @param id Numerical id associated with this scheme				   @param fontColor The base text font color. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.				   @param fontColorHL Color of text when being highlighted. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.				   @param fontColorSel Color of text when being selected. Formatted as \"Red Green Blue\", each a numerical between 0 and 255.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addScheme(int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL)
        {
            m_ts.fnGuiPopUpMenuCtrlEx_addScheme(_ID, id, fontColor.AsString(), fontColorHL.AsString(), fontColorSEL.AsString());
        }

        /// <summary>
        /// @brief Clear the popup list.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void clear()
        {
            m_ts.fnGuiPopUpMenuCtrlEx_clear(_ID);
        }

        /// <summary>
        /// @brief Manually force this control to collapse and close.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void forceClose()
        {
            m_ts.fnGuiPopUpMenuCtrlEx_forceClose(_ID);
        }

        /// <summary>
        /// @brief Manually for the onAction function, which updates everything in this control.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void forceOnAction()
        {
            m_ts.fnGuiPopUpMenuCtrlEx_forceOnAction(_ID);
        }

        /// <summary>
        /// @brief Get the current selection of the menu.				   @return Returns the ID of the currently selected entry)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelected()
        {
            return m_ts.fnGuiPopUpMenuCtrlEx_getSelected(_ID);
        }

        /// <summary>
        /// @brief Get the.				   Detailed description				   @param param Description				   @tsexample				   // Comment				   code();				   @endtsexample				   @return Returns current text in string format)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getText()
        {
            return m_ts.fnGuiPopUpMenuCtrlEx_getText(_ID);
        }

        /// <summary>
        /// @brief Get the text of an entry based on an ID.				   @param id The ID assigned to the entry being queried				   @return String contained by the specified entry, NULL if empty or bad ID)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getTextById(int id)
        {
            return m_ts.fnGuiPopUpMenuCtrlEx_getTextById(_ID, id);
        }

        /// <summary>
        /// @brief Clears selection in the menu.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNoneSelected(int param)
        {
            m_ts.fnGuiPopUpMenuCtrlEx_setNoneSelected(_ID, param);
        }

        /// <summary>
        /// @brief Set the current text to a specified value.				   @param text String containing new text to set)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void setText(string text)
        {
            m_ts.fnGuiPopUpMenuCtrlEx_setText(_ID, text);
        }

        /// <summary>
        /// @brief Sort the list alphabetically.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sort()
        {
            m_ts.fnGuiPopUpMenuCtrlEx_sort(_ID);
        }

        /// <summary>
        /// @brief Sort the list by ID.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortID()
        {
            m_ts.fnGuiPopUpMenuCtrlEx_sortID(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onHotTrackItem(string id)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onSelect(string id, string text)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onCancel()
        {
        }

        #endregion

        public GuiPopUpMenuCtrlEx_Base()
        {
        }
    }
}