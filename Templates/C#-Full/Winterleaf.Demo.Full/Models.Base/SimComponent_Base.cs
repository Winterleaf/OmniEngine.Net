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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<SimComponent_Base>))]
    public partial class SimComponent_Base : NetObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SimComponent_Base ts, string simobjectid)
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
        public static bool operator !=(SimComponent_Base ts, string simobjectid)
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
        public static implicit operator string(SimComponent_Base ts)
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
        public static implicit operator SimComponent_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SimComponent_Base) Omni.self.getSimObject(simobjectid, typeof (SimComponent_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SimComponent_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SimComponent_Base(int simobjectid)
        {
            return (SimComponent) Omni.self.getSimObject((uint) simobjectid, typeof (SimComponent_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SimComponent_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SimComponent_Base(uint simobjectid)
        {
            return (SimComponent_Base) Omni.self.getSimObject(simobjectid, typeof (SimComponent_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Places the object in a component set for later use in new levels. 
        /// </summary>
        [MemberGroup("Component")]
        public bool Template
        {
            get { return Omni.self.GetVar(_ID + ".Template").AsBool(); }
            set { Omni.self.SetVar(_ID + ".Template", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// (idx) Get the component corresponding to the given index.			  @param idx An integer index value corresponding to the desired component.			  @return The id of the component at the given index as an integer)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getComponent(int idx)
        {
            return m_ts.fn_SimComponent_getComponent(_ID, idx);
        }

        /// <summary>
        /// () Get the current component count			  @return The number of components in the list as an integer)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getComponentCount()
        {
            return m_ts.fn_SimComponent_getComponentCount(_ID);
        }

        /// <summary>
        /// () Check whether SimComponent is currently a template			  @return true if is a template and false if not)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool getIsTemplate()
        {
            return m_ts.fn_SimComponent_getIsTemplate(_ID);
        }

        /// <summary>
        /// () Check whether SimComponent is currently enabled			  @return true if enabled and false if not)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new bool isEnabled()
        {
            return m_ts.fn_SimComponent_isEnabled(_ID);
        }

        /// <summary>
        /// (enabled) Sets or unsets the enabled flag			  @param enabled Boolean value			  @return No return value)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void setEnabled(bool enabled)
        {
            m_ts.fn_SimComponent_setEnabled(_ID, enabled);
        }

        /// <summary>
        /// (template) Sets or unsets the template flag			  @param template Boolean value			  @return No return value)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setIsTemplate(bool templateFlag)
        {
            m_ts.fn_SimComponent_setIsTemplate(_ID, templateFlag);
        }

        /// <summary>
        /// ( SimComponent, addComponents, bool, 3, 64, %obj.addComponents( %compObjName, %compObjName2, ... );			  Adds additional components to current list.			  @param Up to 62 component names			  @return Returns true on success, false otherwise.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool addComponents(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "", string a20 = "", string a21 = "", string a22 = "", string a23 = "", string a24 = "", string a25 = "", string a26 = "", string a27 = "", string a28 = "", string a29 = "", string a30 = "", string a31 = "", string a32 = "", string a33 = "", string a34 = "", string a35 = "", string a36 = "", string a37 = "", string a38 = "", string a39 = "", string a40 = "", string a41 = "", string a42 = "", string a43 = "", string a44 = "", string a45 = "", string a46 = "", string a47 = "", string a48 = "", string a49 = "", string a50 = "", string a51 = "", string a52 = "", string a53 = "", string a54 = "", string a55 = "", string a56 = "", string a57 = "", string a58 = "", string a59 = "", string a60 = "", string a61 = "", string a62 = "", string a63 = "")
        {
            return m_ts.fnSimComponent_addComponents(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
        }

        /// <summary>
        /// ( SimComponent, removeComponents, bool, 3, 64, %obj.removeComponents( %compObjName, %compObjName2, ... );			  Removes components by name from current list.			  @param objNamex Up to 62 component names			  @return Returns true on success, false otherwise.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool removeComponents(string a2, string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "", string a14 = "", string a15 = "", string a16 = "", string a17 = "", string a18 = "", string a19 = "", string a20 = "", string a21 = "", string a22 = "", string a23 = "", string a24 = "", string a25 = "", string a26 = "", string a27 = "", string a28 = "", string a29 = "", string a30 = "", string a31 = "", string a32 = "", string a33 = "", string a34 = "", string a35 = "", string a36 = "", string a37 = "", string a38 = "", string a39 = "", string a40 = "", string a41 = "", string a42 = "", string a43 = "", string a44 = "", string a45 = "", string a46 = "", string a47 = "", string a48 = "", string a49 = "", string a50 = "", string a51 = "", string a52 = "", string a53 = "", string a54 = "", string a55 = "", string a56 = "", string a57 = "", string a58 = "", string a59 = "", string a60 = "", string a61 = "", string a62 = "", string a63 = "")
        {
            return m_ts.fnSimComponent_removeComponents(_ID, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53, a54, a55, a56, a57, a58, a59, a60, a61, a62, a63);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when a component is removed.   @targetId target ID   )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onComponentAdd(string targetId)
        {
        }

        /// <summary>
        /// Called when a component is removed.   @targetId target ID   )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onComponentRemove(string targetId)
        {
        }

        #endregion

        public SimComponent_Base()
        {
        }
    }
}