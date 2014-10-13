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
    [TypeConverter(typeof (TypeConverterGeneric<GuiInspector_Base>))]
    public partial class GuiInspector_Base : GuiStackControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiInspector_Base ts, string simobjectid)
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
        public static bool operator !=(GuiInspector_Base ts, string simobjectid)
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
        public static implicit operator string(GuiInspector_Base ts)
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
        public static implicit operator GuiInspector_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiInspector_Base) Omni.self.getSimObject(simobjectid, typeof (GuiInspector_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiInspector_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiInspector_Base(int simobjectid)
        {
            return (GuiInspector) Omni.self.getSimObject((uint) simobjectid, typeof (GuiInspector_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiInspector_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiInspector_Base(uint simobjectid)
        {
            return (GuiInspector_Base) Omni.self.getSimObject(simobjectid, typeof (GuiInspector_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// ( id object, (bool autoSync = true) ) - Add the object to the list of objects being inspected. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addInspect(string className, bool autoSync = true)
        {
            m_ts.fn_GuiInspector_addInspect(_ID, className, autoSync);
        }

        /// <summary>
        /// apply() - Force application of inspected object's attributes )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void apply()
        {
            m_ts.fn_GuiInspector_apply(_ID);
        }

        /// <summary>
        /// getInspectObject( int index=0 ) - Returns currently inspected object )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getInspectObject(uint index = 0)
        {
            return m_ts.fn_GuiInspector_getInspectObject(_ID, index);
        }

        /// <summary>
        /// () - Return the number of objects currently being inspected. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNumInspectObjects()
        {
            return m_ts.fn_GuiInspector_getNumInspectObjects(_ID);
        }

        /// <summary>
        /// Inspect(Object))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void inspect(string className)
        {
            m_ts.fn_GuiInspector_inspect(_ID, className);
        }

        /// <summary>
        /// Reinspect the currently selected object. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void refresh()
        {
            m_ts.fn_GuiInspector_refresh(_ID);
        }

        /// <summary>
        /// ( id object ) - Remove the object from the list of objects being inspected. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeInspect(string obj)
        {
            m_ts.fn_GuiInspector_removeInspect(_ID, obj);
        }

        /// <summary>
        /// setName(NewObjectName))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void setName(string newObjectName)
        {
            m_ts.fn_GuiInspector_setName(_ID, newObjectName);
        }

        /// <summary>
        /// setObjectField( fieldname, data ) - Set a named fields value on the inspected object if it exists. This triggers all the usual callbacks that would occur if the field had been changed through the gui. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setObjectField(string fieldname, string data)
        {
            m_ts.fn_GuiInspector_setObjectField(_ID, fieldname, data);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onClear()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void beginCompoundUndo()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void endCompoundUndo()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onBeginCompoundEdit()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEndCompoundEdit()
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onFieldRightClick(string field)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onFieldAdded(string objectx, string fieldName)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onFieldRemoved(string objectx, string fieldName)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onFieldRenameAlreadyDefined(string objectx, string oldFieldName, string newFieldName)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onFieldRenamed(string objectx, string oldFieldName, string newFieldName)
        {
        }

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
        {
        }

        #endregion

        public GuiInspector_Base()
        {
        }
    }
}