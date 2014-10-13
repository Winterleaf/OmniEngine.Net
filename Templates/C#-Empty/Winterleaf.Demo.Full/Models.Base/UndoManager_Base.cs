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
    [TypeConverter(typeof (TypeConverterGeneric<UndoManager_Base>))]
    public partial class UndoManager_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(UndoManager_Base ts, string simobjectid)
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
        public static bool operator !=(UndoManager_Base ts, string simobjectid)
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
        public static implicit operator string(UndoManager_Base ts)
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
        public static implicit operator UndoManager_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (UndoManager_Base) Omni.self.getSimObject(simobjectid, typeof (UndoManager_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(UndoManager_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator UndoManager_Base(int simobjectid)
        {
            return (UndoManager) Omni.self.getSimObject((uint) simobjectid, typeof (UndoManager_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(UndoManager_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator UndoManager_Base(uint simobjectid)
        {
            return (UndoManager_Base) Omni.self.getSimObject(simobjectid, typeof (UndoManager_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Number of undo and redo levels.
        /// </summary>
        [MemberGroup("")]
        public int numLevels
        {
            get { return Omni.self.GetVar(_ID + ".numLevels").AsInt(); }
            set { Omni.self.SetVar(_ID + ".numLevels", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Clears the undo manager.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clearAll()
        {
            m_ts.fn_UndoManager_clearAll(_ID);
        }

        /// <summary>
        /// UndoManager.getNextRedoName();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getNextRedoName()
        {
            return m_ts.fn_UndoManager_getNextRedoName(_ID);
        }

        /// <summary>
        /// UndoManager.getNextUndoName();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getNextUndoName()
        {
            return m_ts.fn_UndoManager_getNextUndoName(_ID);
        }

        /// <summary>
        /// (index))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRedoAction(int index)
        {
            return m_ts.fn_UndoManager_getRedoAction(_ID, index);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRedoCount()
        {
            return m_ts.fn_UndoManager_getRedoCount(_ID);
        }

        /// <summary>
        /// (index))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getRedoName(int index)
        {
            return m_ts.fn_UndoManager_getRedoName(_ID, index);
        }

        /// <summary>
        /// (index))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getUndoAction(int index)
        {
            return m_ts.fn_UndoManager_getUndoAction(_ID, index);
        }

        /// <summary>
        /// )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getUndoCount()
        {
            return m_ts.fn_UndoManager_getUndoCount(_ID);
        }

        /// <summary>
        /// (index))
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getUndoName(int index)
        {
            return m_ts.fn_UndoManager_getUndoName(_ID, index);
        }

        /// <summary>
        /// ( bool discard=false ) - Pop the current CompoundUndoAction off the stack. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void popCompound(bool discard = false)
        {
            m_ts.fn_UndoManager_popCompound(_ID, discard);
        }

        /// <summary>
        /// \"\"), ( string name=\"\" ) - Push a CompoundUndoAction onto the compound stack for assembly. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string pushCompound(string name = "\"\"")
        {
            return m_ts.fn_UndoManager_pushCompound(_ID, name);
        }

        /// <summary>
        /// UndoManager.redo();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void redo()
        {
            m_ts.fn_UndoManager_redo(_ID);
        }

        /// <summary>
        /// UndoManager.undo();)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void undo()
        {
            m_ts.fn_UndoManager_undo(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onClear()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onRemoveUndo()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onUndo()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onRedo()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onAddUndo()
        {
        }

        #endregion

        public UndoManager_Base()
        {
        }
    }
}