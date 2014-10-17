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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind
{
    public class DatablockEditorUndo
    {
        //=============================================================================================
        //    BaseDatablockEdAction.
        //=============================================================================================

        //=============================================================================================
        //    ActionCreateDatablock.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionCreateDatablock>))]
        public class ActionCreateDatablock : BaseDatablockEdAction
        {
            public override void redo()
            {
                db["name"] = this["dbName"];

                editor.PM.setDirty(db, this["fname"]);
                editor.addExistingItem(db, false);
                editor.selectDatablock(db);
                editor.flagInspectorAsDirty(true);

                ((SimSet) "UnlistedDatablocks").remove(db);
            }

            //---------------------------------------------------------------------------------------------

            public override void undo()
            {
                int itemId = treeView.findItemByName(db["name"]);
                if (itemId == -1)
                    itemId = treeView.findItemByName(db["name"] + " *");

                treeView.removeItem(itemId);
                editor.resetSelectedDatablock();
                editor.PM.removeDirty(db);

                this["dbName"] = db["name"];
                db["name"] = "";

                ((SimSet) "UnlistedDatablocks").add(this["db"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionCreateDatablock ts, string simobjectid)
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
            public static bool operator !=(ActionCreateDatablock ts, string simobjectid)
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
            public static implicit operator string(ActionCreateDatablock ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateDatablock(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionCreateDatablock) Omni.self.getSimObject(simobjectid, typeof (ActionCreateDatablock));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionCreateDatablock ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateDatablock(int simobjectid)
            {
                return (ActionCreateDatablock) Omni.self.getSimObject((uint) simobjectid, typeof (ActionCreateDatablock));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionCreateDatablock ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionCreateDatablock(uint simobjectid)
            {
                return (ActionCreateDatablock) Omni.self.getSimObject(simobjectid, typeof (ActionCreateDatablock));
            }

            #endregion
        }

        //=============================================================================================
        //    ActionDeleteDatablock.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionDeleteDatablock>))]
        public class ActionDeleteDatablock : BaseDatablockEdAction
        {
            public override void redo()
            {
                int itemId = treeView.findItemByName(db["name"]);
                if (itemId == -1)
                    itemId = treeView.findItemByName(db["name"] + " *");

                // Remove from tree and file.

                treeView.removeItem(db);
                editor.resetSelectedDatablock();
                if (db.getFilename() != "")
                    editor.PM.removeObjectFromFile(db);

                // Unassign name.

                this["dbName"] = db["name"];
                db["name"] = "";

                // Add to unlisted.

                ((SimSet) "UnlistedDatablocks").add(db);
            }

            //---------------------------------------------------------------------------------------------

            public override void undo()
            {
                // Restore name.

                db["name"] = this["dbName"];

                // Add to tree and select.

                editor.addExistingItem(db, true);
                editor.selectDatablock(db);

                // Mark as dirty.

                editor.PM.setDirty(db, this["fname"]);
                editor.syncDirtyState();

                // Remove from unlisted.

                ((SimSet) "UnlistedDatablocks").remove(db);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionDeleteDatablock ts, string simobjectid)
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
            public static bool operator !=(ActionDeleteDatablock ts, string simobjectid)
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
            public static implicit operator string(ActionDeleteDatablock ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteDatablock(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ActionDeleteDatablock) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteDatablock));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionDeleteDatablock ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteDatablock(int simobjectid)
            {
                return (ActionDeleteDatablock) Omni.self.getSimObject((uint) simobjectid, typeof (ActionDeleteDatablock));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionDeleteDatablock ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionDeleteDatablock(uint simobjectid)
            {
                return (ActionDeleteDatablock) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteDatablock));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<UndoScriptAction>))]
        public class BaseDatablockEdAction : UndoScriptAction
        {
            public GuiTreeViewCtrl treeView
            {
                get { return this["treeView"]; }
                set { this["treeView"] = value; }
            }

            public DatablockEditorPlugin editor
            {
                get { return this["editor"]; }
                set { this["editor"] = value; }
            }

            public SimObject db
            {
                get { return this["db"]; }
                set { this["db"] = value; }
            }

            public override void redo()
            {
            }

            //---------------------------------------------------------------------------------------------

            public override void undo()
            {
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(BaseDatablockEdAction ts, string simobjectid)
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
            public static bool operator !=(BaseDatablockEdAction ts, string simobjectid)
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
            public static implicit operator string(BaseDatablockEdAction ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator BaseDatablockEdAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (BaseDatablockEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseDatablockEdAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(BaseDatablockEdAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator BaseDatablockEdAction(int simobjectid)
            {
                return (BaseDatablockEdAction) Omni.self.getSimObject((uint) simobjectid, typeof (BaseDatablockEdAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(BaseDatablockEdAction ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator BaseDatablockEdAction(uint simobjectid)
            {
                return (BaseDatablockEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseDatablockEdAction));
            }

            #endregion
        }
    }
}