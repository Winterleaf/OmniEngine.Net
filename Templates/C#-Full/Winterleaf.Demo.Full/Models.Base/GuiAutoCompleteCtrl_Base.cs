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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiAutoCompleteCtrl_Base>))]
    public partial class GuiAutoCompleteCtrl_Base : GuiTextEditCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiAutoCompleteCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiAutoCompleteCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiAutoCompleteCtrl_Base ts)
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
        public static implicit operator GuiAutoCompleteCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiAutoCompleteCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiAutoCompleteCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiAutoCompleteCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiAutoCompleteCtrl_Base(int simobjectid)
        {
            return (GuiAutoCompleteCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiAutoCompleteCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiAutoCompleteCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiAutoCompleteCtrl_Base(uint simobjectid)
        {
            return (GuiAutoCompleteCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiAutoCompleteCtrl_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// ( GuiAutoCompleteCtrl, add, void, 3, 5, (string name, int idNum, int scheme=0))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void add(string a2, string a3 = "", string a4 = "")
        {
            m_ts.fnGuiAutoCompleteCtrl_add(_ID, a2, a3, a4);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, addScheme, void, 6, 6, (int id, ColorI fontColor, ColorI fontColorHL, ColorI fontColorSEL))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addScheme(string a2, string a3, string a4, string a5)
        {
            m_ts.fnGuiAutoCompleteCtrl_addScheme(_ID, a2, a3, a4, a5);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, changeTextById, void, 4, 4, ( int id, string text ) )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void changeTextById(string a2, string a3)
        {
            m_ts.fnGuiAutoCompleteCtrl_changeTextById(_ID, a2, a3);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, clear, void, 2, 2, Clear the popup list.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void clear()
        {
            m_ts.fnGuiAutoCompleteCtrl_clear(_ID);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, clearEntry, void, 3, 3, (S32 entry))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearEntry(string a2)
        {
            m_ts.fnGuiAutoCompleteCtrl_clearEntry(_ID, a2);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, findText, S32, 3, 3, (string text)              Returns the position of the first entry containing the specified text.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int findText(string a2)
        {
            return m_ts.fnGuiAutoCompleteCtrl_findText(_ID, a2);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, forceClose, void, 2, 2, )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void forceClose()
        {
            m_ts.fnGuiAutoCompleteCtrl_forceClose(_ID);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, forceOnAction, void, 2, 2, )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void forceOnAction()
        {
            m_ts.fnGuiAutoCompleteCtrl_forceOnAction(_ID);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, getSelected, S32, 2, 2, )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getSelected()
        {
            return m_ts.fnGuiAutoCompleteCtrl_getSelected(_ID);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, getText, void, 2, 2, )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void getText()
        {
            m_ts.fnGuiAutoCompleteCtrl_getText(_ID);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, getTextById, const char*, 3, 3,  (int id))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getTextById(string a2)
        {
            return m_ts.fnGuiAutoCompleteCtrl_getTextById(_ID, a2);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, replaceText, void, 3, 3, (bool doReplaceText))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void replaceText(string a2)
        {
            m_ts.fnGuiAutoCompleteCtrl_replaceText(_ID, a2);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, setEnumContent, void, 4, 4, (string class, string enum)              This fills the popup with a classrep's field enumeration type info.              More of a helper function than anything.   If console access to the field list is added,               at least for the enumerated types, then this should go away..)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setEnumContent(string a2, string a3)
        {
            m_ts.fnGuiAutoCompleteCtrl_setEnumContent(_ID, a2, a3);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, setFirstSelected, void, 2, 3, ([scriptCallback=true]))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setFirstSelected(string a2 = "")
        {
            m_ts.fnGuiAutoCompleteCtrl_setFirstSelected(_ID, a2);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, setNoneSelected, void, 2, 2, )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setNoneSelected()
        {
            m_ts.fnGuiAutoCompleteCtrl_setNoneSelected(_ID);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, setSelected, void, 3, 4, (int id, [scriptCallback=true]))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setSelected(string a2, string a3 = "")
        {
            m_ts.fnGuiAutoCompleteCtrl_setSelected(_ID, a2, a3);
        }

        /// <summary>
        /// ( GuiAutoCompleteCtrl, size, S32, 2, 2, Get the size of the menu - the number of entries in it.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int size()
        {
            return m_ts.fnGuiAutoCompleteCtrl_size(_ID);
        }

        /// <summary>
        /// (GuiAutoCompleteCtrl, sort, void, 2, 2, Sort the list alphabetically.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sort()
        {
            m_ts.fnGuiAutoCompleteCtrl_sort(_ID);
        }

        /// <summary>
        /// (GuiAutoCompleteCtrl, sortID, void, 2, 2, Sort the list by ID.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sortID()
        {
            m_ts.fnGuiAutoCompleteCtrl_sortID(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiAutoCompleteCtrl_Base()
        {
        }
    }
}