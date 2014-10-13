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
    [TypeConverter(typeof (TypeConverterGeneric<Settings_Base>))]
    public partial class Settings_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Settings_Base ts, string simobjectid)
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
        public static bool operator !=(Settings_Base ts, string simobjectid)
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
        public static implicit operator string(Settings_Base ts)
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
        public static implicit operator Settings_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Settings_Base) Omni.self.getSimObject(simobjectid, typeof (Settings_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Settings_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Settings_Base(int simobjectid)
        {
            return (Settings) Omni.self.getSimObject((uint) simobjectid, typeof (Settings_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Settings_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Settings_Base(uint simobjectid)
        {
            return (Settings_Base) Omni.self.getSimObject(simobjectid, typeof (Settings_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// The file path and name to be saved to and loaded from.
        /// </summary>
        [MemberGroup("")]
        public String file
        {
            get { return Omni.self.GetVar(_ID + ".file").AsString(); }
            set { Omni.self.SetVar(_ID + ".file", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// settingObj.beginGroup(groupName, fromStart = false);)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void beginGroup(string groupName, bool includeDefaults = false)
        {
            m_ts.fn_Settings_beginGroup(_ID, groupName, includeDefaults);
        }

        /// <summary>
        /// settingObj.clearGroups();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearGroups()
        {
            m_ts.fn_Settings_clearGroups(_ID);
        }

        /// <summary>
        /// settingObj.endGroup();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void endGroup()
        {
            m_ts.fn_Settings_endGroup(_ID);
        }

        /// <summary>
        /// , false, false), settingObj.findFirstValue();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string findFirstValue(string pattern = "", bool deepSearch = false, bool includeDefaults = false)
        {
            return m_ts.fn_Settings_findFirstValue(_ID, pattern, deepSearch, includeDefaults);
        }

        /// <summary>
        /// settingObj.findNextValue();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string findNextValue()
        {
            return m_ts.fn_Settings_findNextValue(_ID);
        }

        /// <summary>
        /// settingObj.getCurrentGroups();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getCurrentGroups()
        {
            return m_ts.fn_Settings_getCurrentGroups(_ID);
        }

        /// <summary>
        /// %success = settingObj.read();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool read()
        {
            return m_ts.fn_Settings_read(_ID);
        }

        /// <summary>
        /// settingObj.remove(settingName, includeDefaults = false);)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void remove(string settingName, bool includeDefaults = false)
        {
            m_ts.fn_Settings_remove(_ID, settingName, includeDefaults);
        }

        /// <summary>
        /// settingObj.setDefaultValue(settingName, value);)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setDefaultValue(string settingName, string value)
        {
            m_ts.fn_Settings_setDefaultValue(_ID, settingName, value);
        }

        /// <summary>
        /// ), settingObj.setValue(settingName, value);)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setValue(string settingName, string value = "")
        {
            m_ts.fn_Settings_setValue(_ID, settingName, value);
        }

        /// <summary>
        /// ), settingObj.value(settingName, defaultValue);)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string value(string settingName, string defaultValue = "")
        {
            return m_ts.fn_Settings_value(_ID, settingName, defaultValue);
        }

        /// <summary>
        /// (Settings, write, bool, 2, 2, %success = settingObj.write();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool write()
        {
            return m_ts.fnSettings_write(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public Settings_Base()
        {
        }
    }
}