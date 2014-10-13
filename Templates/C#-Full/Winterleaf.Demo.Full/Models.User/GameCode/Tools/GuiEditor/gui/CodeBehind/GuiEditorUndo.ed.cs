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
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
{
    public class GuiEditorUndo
    {
        private static readonly pInvokes omni = new pInvokes();

        [TypeConverter(typeof (TypeConverterGeneric<GenericUndoAction>))]
        public class GenericUndoAction : UndoScriptAction
        {
            //------------------------------------------------------------------------------
            // Undo Any State Change.

            [ConsoleInteraction]
            public string create()
            {
                // The instant group will try to add our
                // UndoAction if we don't disable it. 
                omni.Util.pushInstantGroup();

                GenericUndoAction act = new ObjectCreator("UndoScriptAction", "", typeof (GenericUndoAction)).Create();

                act.actionName = "Edit Objects";

                // Restore the instant group.
                omni.Util.popInstantGroup();

                return act;
            }

            [ConsoleInteraction]
            public void watch(SimObject objectx)
            {
                // make sure we're working with the object id, because it cannot change.
                //object = object.getId();

                int fieldCount = objectx.getFieldCount();
                int dynFieldCount = objectx.getDynamicFieldCount();

                // inspect all the fields on the object, including dyanamic ones.
                // record field names and values.
                for (int i = 0; i < fieldCount; i++)
                    {
                    string field = objectx.getField(i);
                    this["fieldNames[" + objectx + "]"] = this["fieldNames[" + objectx + "]"] + ' ' + field;
                    this["fieldValues[" + objectx + "," + field + "]"] = objectx.getFieldValue(field, -1);
                    }

                for (int i = 0; i < dynFieldCount; i++)
                    {
                    string field = objectx.getDynamicField(i);
                    this["fieldNames[" + objectx + "]"] = this["fieldNames[" + objectx + "]"] + ' ' + field;
                    this["fieldValues[" + objectx + "," + field + "]"] = objectx.getFieldValue(field, -1);
                    }
                // clean spurious spaces from the field name list
                this["fieldNames[" + objectx + "]"] = omni.Util.trim(this["fieldNames[" + objectx + "]"]);
                // record that we know this object
                this["objectIds[" + objectx + "]"] = "1";
                this["objectIdList"] = this["objectIdList"] + ' ' + objectx;
            }

            [ConsoleInteraction]
            public bool learn(SimObject objectx)
            {
                // make sure we're working with the object id, because it cannot change.
                //object = object.getId();

                int fieldCount = objectx.getFieldCount();
                int dynFieldCount = objectx.getDynamicFieldCount();

                // inspect all the fields on the objectx, including dyanamic ones.
                // record field names and values.
                for (int i = 0; i < fieldCount; i++)
                    {
                    string field = objectx.getField(i);
                    this["newFieldNames[" + objectx + "]"] = this["newFieldNames[" + objectx + "]"] + ' ' + field;
                    this["newFieldValues[" + objectx + "," + field + "]"] = objectx.getFieldValue(field, -1);
                    }
                for (int i = 0; i < dynFieldCount; i++)
                    {
                    string field = objectx.getDynamicField(i);
                    this["newFieldNames[" + objectx + "]"] = this["newFieldNames[" + objectx + "]"] + ' ' + field;
                    this["newFieldValues[" + objectx + "," + field + "]"] = objectx.getFieldValue(field, -1);
                    }

                // trim
                this["newFieldNames[" + objectx + "]"] = omni.Util.trim(this["newFieldNames[" + objectx + "]"]);

                // look for differences
                //----------------------------------------------------------------------
                bool diffs = false;
                string newFieldNames = this["newFieldNames[" + objectx + "]"];
                string oldFieldNames = this["fieldNames[" + objectx + "]"];
                int numNewFields = omni.Util.getWordCount(newFieldNames);
                int numOldFields = omni.Util.getWordCount(oldFieldNames);
                // compare the old field list to the new field list.
                // if a field is on the old list that isn't on the new list, 
                // add it to the newNullFields list.
                string newNullFields = "", oldNullFields = "";

                for (int i = 0; i < numOldFields; i++)
                    {
                    string field = Util.getWord(oldFieldNames, i);
                    string newVal = this["newFieldValues[" + objectx + "," + field + "]"];
                    string oldVal = this["fieldValues[" + objectx + "," + field + "]"];
                    if (newVal != oldVal)
                        {
                        diffs = true;
                        if (newVal == "")
                            newNullFields = newNullFields + ' ' + field;
                        }
                    }
                // scan the new field list
                // add missing fields to the oldNullFields list
                for (int i = 0; i < numNewFields; i++)
                    {
                    string field = Util.getWord(newFieldNames, i);
                    string newVal = this["newFieldValues[" + objectx + "," + field + "]"];
                    string oldVal = this["fieldValues[" + objectx + "," + field + "]"];
                    if (newVal != oldVal)
                        {
                        diffs = true;
                        if (oldVal == "")
                            oldNullFields = oldNullFields + ' ' + field;
                        }
                    }
                this["newNullFields[" + objectx + "]"] = Util.trim(newNullFields);
                this["oldNullFields[" + objectx + "]"] = Util.trim(oldNullFields);

                return diffs;
            }

            [ConsoleInteraction]
            public void watchSet(SimSet set)
            {
                // scan the set
                // this.watch each object.
                int setcount = set.getCount();
                uint i = 0;
                for (; i < setcount; i++)
                    {
                    SimObject objectx = set.getObject(i);
                    this.watch(objectx);
                    }
            }

            [ConsoleInteraction]
            public bool learnSet(SimSet set)
            {
                // scan the set
                // this.learn any objects that we have a this.objectIds[] entry for.
                bool diffs = false;
                for (uint i = 0; i < set.getCount(); i++)
                    {
                    SimObject objectx = set.getObject(i);
                    if (this["objectIds[" + objectx + "]"].AsInt() != 1)
                        continue;

                    if (this.learn(objectx))
                        diffs = true;
                    }

                return diffs;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                // set the objects to the old values
                // scan through our objects
                string objectList = this["objectIdList"];
                for (int i = 0; i < Util.getWordCount(objectList); i++)
                    {
                    SimObject objectx = Util.getWord(objectList, i);
                    // scan through the old extant fields
                    string fieldNames = this["fieldNames[" + objectx + "]"];
                    for (int j = 0; j < Util.getWordCount(fieldNames); j++)
                        {
                        string field = Util.getWord(fieldNames, j);
                        objectx.setFieldValue(field, this["fieldValues[" + objectx + "," + field + "]"], -1);
                        }
                    // null out the fields in the null list
                    fieldNames = this["oldNullFields[" + objectx + "]"];
                    for (int j = 0; j < Util.getWordCount(fieldNames); j++)
                        {
                        string field = Util.getWord(fieldNames, j);
                        objectx.setFieldValue(field, "", -1);
                        }
                    }

                // update the tree view
                if (this["tree"].isObject())
                    this["tree"].call("update");
            }

            [ConsoleInteraction]
            public override void redo()
            {
                // set the objects to the new values
                // set the objects to the new values
                // scan through our objects
                string objectList = this["objectIdList"];
                for (int i = 0; i < Util.getWordCount(objectList); i++)
                    {
                    SimObject objectx = Util.getWord(objectList, i);
                    // scan through the new extant fields
                    string fieldNames = this["newFieldNames[" + objectx + "]"];
                    for (int j = 0; j < Util.getWordCount(fieldNames); j++)
                        {
                        string field = Util.getWord(fieldNames, j);
                        objectx.setFieldValue(field, this["newFieldValues[" + objectx + "," + field + "]"], -1);
                        }
                    // null out the fields in the null list
                    fieldNames = this["newNullFields[" + objectx + "]"];
                    for (int j = 0; j < Util.getWordCount(fieldNames); j++)
                        {
                        string field = Util.getWord(fieldNames, j);
                        objectx.setFieldValue(field, "", -1);
                        }
                    }

                // update the tree view
                if (this["tree"].isObject())
                    this["tree"].call("update");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GenericUndoAction ts, string simobjectid)
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
            public static bool operator !=(GenericUndoAction ts, string simobjectid)
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
            public static implicit operator string(GenericUndoAction ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GenericUndoAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GenericUndoAction) Omni.self.getSimObject(simobjectid, typeof (GenericUndoAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GenericUndoAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GenericUndoAction(int simobjectid)
            {
                return (GenericUndoAction) Omni.self.getSimObject((uint) simobjectid, typeof (GenericUndoAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GenericUndoAction ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GenericUndoAction(uint simobjectid)
            {
                return (GenericUndoAction) Omni.self.getSimObject(simobjectid, typeof (GenericUndoAction));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorGroupAction>))]
        public class GuiEditorGroupAction : GuiEditorGroupUngroupAction
        {
            [ConsoleInteraction]
            public string create(SimSet set, string root)
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
                // Create action object.

                omni.Util.pushInstantGroup();
                ObjectCreator undoAct = new ObjectCreator("UndoScriptAction", "", typeof (GuiEditorGroupAction));
                undoAct["actionName"] = "Group";
                undoAct["count"] = 1;

                ObjectCreator groupCreator = new ObjectCreator("ScriptObject", "", typeof (GuiEditorGroup));
                groupCreator["count"] = set.getCount();
                groupCreator["groupParent"] = GuiEditor.getCurrentAddSet();
                undoAct["group[0]"] = groupCreator.Create().AsString();

                undoAct["#object"] = groupCreator;
                GuiEditorGroupAction action = undoAct.Create();

                omni.Util.popInstantGroup();

                // Add objects from set to group.

                SimObject group = action["group[0]"];
                int num = set.getCount();
                for (uint i = 0; i < num; i ++)
                    {
                    SimObject ctrl = set.getObject(i);
                    if (ctrl != root)
                        group["ctrl[" + i + "]"] = ctrl;
                    }

                return action;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                this.ungroupControls();
            }

            [ConsoleInteraction]
            public override void redo()
            {
                this.groupControls();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorGroupAction ts, string simobjectid)
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
            public static bool operator !=(GuiEditorGroupAction ts, string simobjectid)
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
            public static implicit operator string(GuiEditorGroupAction ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorGroupAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorGroupAction) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGroupAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorGroupAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorGroupAction(int simobjectid)
            {
                return (GuiEditorGroupAction) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorGroupAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorGroupAction ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorGroupAction(uint simobjectid)
            {
                return (GuiEditorGroupAction) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGroupAction));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorGroupUngroupAction>))]
        public class GuiEditorGroupUngroupAction : UndoScriptAction
        {
            public int count
            {
                get { return this["count"].AsInt(); }
                set { this["count"] = value.AsString(); }
            }

            [ConsoleInteraction]
            public void groupControls()
            {
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                for (int i = 0; i < this.count; i ++)
                    this["group[" + i + "]"].call("group");

                GuiEditorTreeView.update();
            }

            [ConsoleInteraction]
            public void ungroupControls()
            {
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                for (int i = 0; i < this.count; i ++)
                    this["group[" + i + "]"].call("ungroup");

                GuiEditorTreeView.update();
            }

            [ConsoleInteraction]
            public override void onRemove()
            {
                for (int i = 0; i < this.count; i ++)
                    {
                    if (this["group[" + i + "]"].isObject())
                        this["group[" + i + "]"].delete();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorGroupUngroupAction ts, string simobjectid)
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
            public static bool operator !=(GuiEditorGroupUngroupAction ts, string simobjectid)
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
            public static implicit operator string(GuiEditorGroupUngroupAction ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorGroupUngroupAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorGroupUngroupAction) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGroupUngroupAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorGroupUngroupAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorGroupUngroupAction(int simobjectid)
            {
                return (GuiEditorGroupUngroupAction) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorGroupUngroupAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorGroupUngroupAction ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorGroupUngroupAction(uint simobjectid)
            {
                return (GuiEditorGroupUngroupAction) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGroupUngroupAction));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorUndoManager>))]
        public class GuiEditorUndoManager : UndoManager
        {
            [ConsoleInteraction]
            public override void onAddUndo()
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                GuiEditor.updateUndoMenu();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorUndoManager ts, string simobjectid)
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
            public static bool operator !=(GuiEditorUndoManager ts, string simobjectid)
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
            public static implicit operator string(GuiEditorUndoManager ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorUndoManager(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorUndoManager) Omni.self.getSimObject(simobjectid, typeof (GuiEditorUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorUndoManager ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorUndoManager(int simobjectid)
            {
                return (GuiEditorUndoManager) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorUndoManager ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorUndoManager(uint simobjectid)
            {
                return (GuiEditorUndoManager) Omni.self.getSimObject(simobjectid, typeof (GuiEditorUndoManager));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorUngroupAction>))]
        public class GuiEditorUngroupAction : GuiEditorGroupUngroupAction
        {
            [ConsoleInteraction]
            public string create(SimSet set, string root)
            {
                // Create action object.

                omni.Util.pushInstantGroup();
                ObjectCreator oc = new ObjectCreator("UndoScriptAction", "", typeof (GuiEditorUngroupAction));
                oc["actionName"] = "Ungroup";

                GuiEditorUngroupAction action = oc.Create();

                // Add groups from set to action.

                int groupCount = 0;
                int numInSet = set.getCount();
                for (uint i = 0; i < numInSet; i++)
                    {
                    SimObject obj = set.getObject(i);
                    if (obj.getClassName() == "GuiControl" && obj != root)
                        {
                        // Create group object.

                        ObjectCreator groupOc = new ObjectCreator("ScriptObject", "", typeof (GuiEditorGroup));
                        groupOc["count"] = ((SimSet) obj).getCount();
                        groupOc["groupParent"] = obj.parentGroup;
                        groupOc["groupObject"] = obj;

                        GuiEditorGroup group = groupOc.Create();

                        action["group[" + groupCount + "]"] = group;
                        groupCount ++;

                        // Add controls.

                        int numControls = ((SimSet) obj).getCount();
                        for (uint j = 0; j < numControls; j ++)
                            group["ctrl[" + j + "]"] = ((SimSet) obj).getObject(j);
                        }
                    }

                omni.Util.popInstantGroup();

                action.count = groupCount;
                return action;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                this.groupControls();
            }

            [ConsoleInteraction]
            public override void redo()
            {
                this.ungroupControls();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorUngroupAction ts, string simobjectid)
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
            public static bool operator !=(GuiEditorUngroupAction ts, string simobjectid)
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
            public static implicit operator string(GuiEditorUngroupAction ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorUngroupAction(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorUngroupAction) Omni.self.getSimObject(simobjectid, typeof (GuiEditorUngroupAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorUngroupAction ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorUngroupAction(int simobjectid)
            {
                return (GuiEditorUngroupAction) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorUngroupAction));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorUngroupAction ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorUngroupAction(uint simobjectid)
            {
                return (GuiEditorUngroupAction) Omni.self.getSimObject(simobjectid, typeof (GuiEditorUngroupAction));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<UndoActionAddDelete>))]
        public class UndoActionAddDelete : UndoScriptAction
        {
            public int objCount
            {
                get { return this["objCount"].AsInt(); }
                set { this["objCount"] = value.AsString(); }
            }

            public bool designatedDeleter
            {
                get { return this["designatedDeleter"].AsBool(); }
                set { this["designatedDeleter"] = value.AsString(); }
            }

            public GuiTreeViewCtrl tree
            {
                get { return this["tree"]; }
                set { this["tree"] = value; }
            }

            //[ConsoleInteraction]
            //-----------------------------------------------------------------------------------------
            // Behavior common to Add and Delete UndoActions
            public virtual T create<T>(SimSet set, string trash, string treeView, bool clearNames)
            {
                // record objects
                // record parents
                // record trash
                // return new subclass %class of UndoActionAddDelete

                // The instant group will try to add our
                // UndoAction if we don't disable it. 
                omni.Util.pushInstantGroup();

                UndoScriptAction act = new ObjectCreator("UndoScriptAction", "", typeof (T)).Create();

                // Restore the instant group.
                omni.Util.popInstantGroup();

                for (uint i = 0; i < set.getCount(); i++)
                    {
                    GuiControl obj = set.getObject(i);

                    act["object[" + i + "]"] = obj.getId().AsString();
                    act["parent[" + i + "]"] = obj.getParent();
                    act["objectName[" + i + "]"] = obj.name;

                    // Clear object name so we don't get name clashes with the trash.

                    if (clearNames)
                        obj.name = "".AsTypeName();
                    }

                act["objCount"] = set.getCount().AsString();
                act["trash"] = trash;
                act["tree"] = treeView;

                return myReflections.ChangeType<T>(act);
            }

            [ConsoleInteraction]
            public void trashObjects()
            {
                // Move objects to trash.

                for (int i = 0; i < this.objCount; i ++)
                    {
                    SimObject objectx = this["object[" + i + "]"];

                    ((SimSet) this["trash"]).add(objectx);
                    objectx.name = "".AsTypeName();
                    }

                // Note that we're responsible for deleting those objects we've moved to the trash.

                this.designatedDeleter = true;

                // Update the tree view.

                if (this.tree.isObject())
                    this.tree.call("update");
            }

            [ConsoleInteraction]
            public void restoreObjects()
            {
                // Move objects to saved parent and restore names.

                for (int i = 0; i < this.objCount; i ++)
                    {
                    SimObject objectx = this["object[" + i + "]"];
                    objectx.name = this["objectName[" + i + "]"].AsTypeName();
                    ((SimSet) this["parent[" + i + "]"]).add(objectx);
                    }

                // Note that we no longer own the objects, and should not delete them when we're deleted.

                this.designatedDeleter = false;

                // Update the tree view.

                if (this.tree.isObject())
                    this.tree.call("update");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(UndoActionAddDelete ts, string simobjectid)
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
            public static bool operator !=(UndoActionAddDelete ts, string simobjectid)
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
            public static implicit operator string(UndoActionAddDelete ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator UndoActionAddDelete(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (UndoActionAddDelete) Omni.self.getSimObject(simobjectid, typeof (UndoActionAddDelete));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(UndoActionAddDelete ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator UndoActionAddDelete(int simobjectid)
            {
                return (UndoActionAddDelete) Omni.self.getSimObject((uint) simobjectid, typeof (UndoActionAddDelete));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(UndoActionAddDelete ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator UndoActionAddDelete(uint simobjectid)
            {
                return (UndoActionAddDelete) Omni.self.getSimObject(simobjectid, typeof (UndoActionAddDelete));
            }

            #endregion
        }

        //-----------------------------------------------------------------------------------------
        // Undo adding an object
        [TypeConverter(typeof (TypeConverterGeneric<UndoActionAddObject>))]
        public class UndoActionAddObject : UndoActionAddDelete
        {
            [ConsoleInteraction]
            public UndoActionAddObject create(SimSet set, string trash, string treeView, bool clearNames)
            {
                //UndoActionAddDelete UndoActionAddDelete = "UndoActionAddDelete";

                UndoActionAddObject act = base.create<UndoActionAddObject>(set, trash, treeView, false);
                act.actionName = "Add Objects";
                return act;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                this.trashObjects();
            }

            [ConsoleInteraction]
            public override void redo()
            {
                this.restoreObjects();
            }

            [ConsoleInteraction]
            public override void onRemove()
            {
                // if this undoAction owns objects in the trash, delete them.
                if (!this.designatedDeleter)
                    return;

                for (int i = 0; i < this.objCount; i++)
                    this["object[" + i + "]"].delete();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(UndoActionAddObject ts, string simobjectid)
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
            public static bool operator !=(UndoActionAddObject ts, string simobjectid)
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
            public static implicit operator string(UndoActionAddObject ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator UndoActionAddObject(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (UndoActionAddObject) Omni.self.getSimObject(simobjectid, typeof (UndoActionAddObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(UndoActionAddObject ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator UndoActionAddObject(int simobjectid)
            {
                return (UndoActionAddObject) Omni.self.getSimObject((uint) simobjectid, typeof (UndoActionAddObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(UndoActionAddObject ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator UndoActionAddObject(uint simobjectid)
            {
                return (UndoActionAddObject) Omni.self.getSimObject(simobjectid, typeof (UndoActionAddObject));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<UndoActionDeleteObject>))]
        public class UndoActionDeleteObject : UndoActionAddDelete
        {
            [ConsoleInteraction]
            public UndoActionDeleteObject create(SimSet set, string trash, string treeView, bool clearNames)
            {
                //UndoActionAddDelete UndoActionAddDelete = "UndoActionAddDelete";

                UndoActionDeleteObject act = base.create<UndoActionDeleteObject>(set, trash, treeView, true);
                act.designatedDeleter = true;
                act.actionName = "Delete Objects";
                return act;
            }

            [ConsoleInteraction]
            public override void undo()
            {
                this.restoreObjects();
            }

            [ConsoleInteraction]
            public override void redo()
            {
                this.trashObjects();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(UndoActionDeleteObject ts, string simobjectid)
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
            public static bool operator !=(UndoActionDeleteObject ts, string simobjectid)
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
            public static implicit operator string(UndoActionDeleteObject ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator UndoActionDeleteObject(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (UndoActionDeleteObject) Omni.self.getSimObject(simobjectid, typeof (UndoActionDeleteObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(UndoActionDeleteObject ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator UndoActionDeleteObject(int simobjectid)
            {
                return (UndoActionDeleteObject) Omni.self.getSimObject((uint) simobjectid, typeof (UndoActionDeleteObject));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(UndoActionDeleteObject ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator UndoActionDeleteObject(uint simobjectid)
            {
                return (UndoActionDeleteObject) Omni.self.getSimObject(simobjectid, typeof (UndoActionDeleteObject));
            }

            #endregion
        }
    }
}