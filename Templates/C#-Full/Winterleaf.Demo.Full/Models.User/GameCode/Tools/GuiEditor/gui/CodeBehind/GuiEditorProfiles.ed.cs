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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
{
    public class GuiEditorProfiles
    {
        internal static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "GuiEditorProfiles_initialize")]
        public static void initialize()
        {
            omni.sGlobal["$GUI_EDITOR_DEFAULT_PROFILE_FILENAME"] = "art/gui/customProfiles.cs";
            omni.sGlobal["$GUI_EDITOR_DEFAULT_PROFILE_CATEGORY"] = "Other";
        }

        //=============================================================================================
        //    GuiEditorProfilesTree.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        //=============================================================================================
        //    GuiEditorProfileChangeManager.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorProfileChangeManager>))]
        public class GuiEditorProfileChangeManager : SimGroup
        {
            [ConsoleInteraction]
            public void registerEdit(string profile, string fieldName, string arrayIndex, string oldValue)
            {
                // Early-out if we already have a registered edit on the same field.

                for (uint i = 0; i < this.getCount(); i++)
                    {
                    SimObject obj = this.getObject(i);
                    if (obj["profile"] != profile)
                        continue;

                    if (obj["fieldName"] == fieldName && obj["arrayIndex"] == arrayIndex)
                        return;
                    }

                // Create a new change record.

                ObjectCreator oc = new ObjectCreator("ScriptObject");
                oc["parentGroup"] = this;
                oc["profile"] = profile;
                oc["fieldName"] = fieldName;
                oc["arrayIndex"] = arrayIndex;
                oc["oldValue"] = oldValue;

                oc.Create();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void clearEdits(string profile)
            {
                for (uint i = 0; i < this.getCount(); i ++)
                    {
                    SimObject obj = this.getObject(i);
                    if (obj["profile"] != profile)
                        continue;

                    obj.delete();
                    i --;
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void revertEdits(SimObject profile)
            {
                for (uint i = 0; i < this.getCount(); i ++)
                    {
                    SimObject obj = this.getObject(i);
                    if (obj["profile"] != profile)
                        continue;

                    profile.setFieldValue(obj["fieldName"], obj["oldValue"], obj["arrayIndex"].AsInt());

                    obj.delete();
                    i --;
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public string getEdits(string profile)
            {
                SimSet set = new ObjectCreator("SimSet").Create();

                for (uint i = 0; i < this.getCount(); i++)
                    {
                    SimObject obj = this.getObject(i);
                    if (obj["profile"] == profile)
                        set.add(obj);
                    }
                return set;
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorProfileChangeManager ts, string simobjectid)
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
            public static bool operator !=(GuiEditorProfileChangeManager ts, string simobjectid)
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
            public static implicit operator string(GuiEditorProfileChangeManager ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorProfileChangeManager(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorProfileChangeManager) Omni.self.getSimObject(simobjectid, typeof (GuiEditorProfileChangeManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorProfileChangeManager ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorProfileChangeManager(int simobjectid)
            {
                return (GuiEditorProfileChangeManager) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorProfileChangeManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorProfileChangeManager ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorProfileChangeManager(uint simobjectid)
            {
                return (GuiEditorProfileChangeManager) Omni.self.getSimObject(simobjectid, typeof (GuiEditorProfileChangeManager));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorProfileInspector>))]
        public class GuiEditorProfileInspector : EditorInspectorBase
        {
            internal UndoAction currentFieldEditAction
            {
                get { return this["currentFieldEditAction"]; }
                set { this["currentFieldEditAction"] = value; }
            }

            [ConsoleInteraction]
            public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
            {
                GuiMLTextCtrl GuiEditorProfileFieldInfo = "GuiEditorProfileFieldInfo";

                GuiEditorProfileFieldInfo.setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") " + '\n' + "<font:Arial:14>" + fieldDoc);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onFieldAdded(string objectx, string fieldName)
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                GuiEditor.setProfileDirty(objectx, true, false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onFieldRemoved(string objectx, string fieldName)
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                GuiEditor.setProfileDirty(objectx, true, false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onFieldRenamed(string objectx, string oldFieldName, string newFieldName)
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                GuiEditor.setProfileDirty(objectx, true, false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
            {
                SimObject obj = objectx;
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
                GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";
                GuiEditorProfileChangeManager GuiEditorProfileChangeManager = "GuiEditorProfileChangeManager";
                ProfilePane ProfilePane = "ProfilePane";

                GuiEditor.setProfileDirty(obj, true, false);

                // If it's the name field, make sure to sync up the treeview.

                if (fieldName == "name")
                    GuiEditorProfilesTree.onProfileRenamed(obj, newValue);

                // Add change record.

                //GuiEditorProfileChangeManager.registerEdit(obj, fieldName, oldValue);
                GuiEditorProfileChangeManager.registerEdit(obj, fieldName, arrayIndex, oldValue);

                // Add undo.

                Util.pushInstantGroup();

                string nameOrClass = obj.getName();
                if (nameOrClass == "")
                    nameOrClass = obj.getClassName();

                ObjectCreator oc = new ObjectCreator("InspectorFieldUndoAction");
                oc["actionName"] = nameOrClass + "." + fieldName + " Change";

                oc["objectId"] = obj.getId();
                oc["fieldName"] = fieldName;
                oc["fieldValue"] = oldValue;
                oc["arrayIndex"] = arrayIndex;

                oc["inspectorGui"] = this;

                InspectorFieldUndoAction action = oc.Create();

                Util.popInstantGroup();
                action.addToManager(ProfilePane.getUndoManager());
                //GuiEditor.updateUndoMenu();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onInspectorPreFieldModification(string fieldName, string arrayIndex)
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                Util.pushInstantGroup();
                //UndoManager undoManager = GuiEditor.getUndoManager();

                SimObject objectx = this.getInspectObject();

                string nameOrClass = objectx.getName();
                if (nameOrClass == "")
                    nameOrClass = objectx.getClassName();

                ObjectCreator oc = new ObjectCreator("InspectorFieldUndoAction");
                oc["actionName"] = nameOrClass + "." + fieldName + " Change";

                oc["objectId"] = objectx.getId();
                oc["fieldName"] = fieldName;
                oc["fieldValue"] = objectx.getFieldValue(fieldName, arrayIndex == "(null)" ? -1 : arrayIndex.AsInt());
                oc["arrayIndex"] = arrayIndex;

                oc["inspectorGui"] = this;

                InspectorFieldUndoAction action = oc.Create();

                this.currentFieldEditAction = action;
                Util.popInstantGroup();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onInspectorPostFieldModification()
            {
                GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";
                GuiEditorProfileChangeManager GuiEditorProfileChangeManager = "GuiEditorProfileChangeManager";
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
                ProfilePane ProfilePane = "ProfilePane";

                UndoAction action = this.currentFieldEditAction;
                SimObject objectx = action["objectId"];
                string fieldName = action["fieldName"];
                string arrayIndex = action["arrayIndex"];
                string oldValue = action["fieldValue"];
                string newValue = objectx.getFieldValue(fieldName, arrayIndex == "(null)" ? -1 : arrayIndex.AsInt());

                // If it's the name field, make sure to sync up the treeview.

                if (action["fieldName"] == "name")
                    GuiEditorProfilesTree.onProfileRenamed(objectx, newValue);

                ProfilePane.onProfileSelected();

                // Add change record.

                GuiEditorProfileChangeManager.registerEdit(objectx, fieldName, arrayIndex, oldValue);

                this.currentFieldEditAction.addToManager(ProfilePane.getUndoManager());
                this.currentFieldEditAction = "";

                //GuiEditor.updateUndoMenu();
                GuiEditor.setProfileDirty(objectx, true, false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onInspectorDiscardFieldModification()
            {
                this.currentFieldEditAction.undo();
                this.currentFieldEditAction.delete();
                this.currentFieldEditAction = "";
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorProfileInspector ts, string simobjectid)
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
            public static bool operator !=(GuiEditorProfileInspector ts, string simobjectid)
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
            public static implicit operator string(GuiEditorProfileInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorProfileInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorProfileInspector) Omni.self.getSimObject(simobjectid, typeof (GuiEditorProfileInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorProfileInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorProfileInspector(int simobjectid)
            {
                return (GuiEditorProfileInspector) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorProfileInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorProfileInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorProfileInspector(uint simobjectid)
            {
                return (GuiEditorProfileInspector) Omni.self.getSimObject(simobjectid, typeof (GuiEditorProfileInspector));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorProfilesTree>))]
        public class GuiEditorProfilesTree : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public void init()
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
                SimSet GuiDataGroup = "GuiDataGroup";

                this.clear();

                int defaultGroup = this.insertItem(0, "Default", "-1", "", 1, 1);
                int otherGroup = this.insertItem(0, sGlobal["$GUI_EDITOR_DEFAULT_PROFILE_CATEGORY"], "-1", "", 1, 1);

                for (uint i = 0; i < GuiDataGroup.getCount(); i++)
                    {
                    SimObject obj = GuiDataGroup.getObject(i);
                    if (!obj.isMemberOfClass("GuiControlProfile"))
                        continue;

                    // If it's an Editor profile, skip if showing them is not enabled.

                    if (obj["category"] == "Editor" && !GuiEditor["showEditorProfiles"].AsBool())
                        continue;

                    // Create a visible name.

                    string name = obj.getName();
                    if (name == "")
                        name = "<Unnamed>";
                    string text = name + " (" + obj.getId() + ")";

                    // Find which group to put the control in.

                    bool isDefaultProfile = GuiEditor.isDefaultProfile(name);

                    int group;
                    if (isDefaultProfile)
                        group = defaultGroup;
                    else if (obj["category"] != "")
                        {
                        group = this.findChildItemByName(0, obj["category"]);
                        if (group == 0)
                            group = this.insertItem(0, obj["category"], "", "", 1, 1);
                        }
                    else
                        group = otherGroup;

                    // Insert the item.

                    this.insertItem(group, text, obj.getId().AsString(), "", 1, 1);
                    }

                this.sort(0, true, true, false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onSelect(string id, string y)
            {
                GuiEditorProfileInspector GuiEditorProfileInspector = "GuiEditorProfileInspector";
                GuiTextEditCtrl GuiEditorProfileFileName = "GuiEditorProfileFileName";
                ProfilePane ProfilePane = "ProfilePane";

                GuiControlProfile obj = this.getItemValue(id.AsInt());
                if (obj == 0)
                    return;

                GuiEditorProfileInspector.inspect(obj);

                ProfilePane.onProfileSelected();

                string fileName = obj.getFilename();
                if (fileName == "")
                    fileName = sGlobal["$GUI_EDITOR_DEFAULT_PROFILE_FILENAME"];

                GuiEditorProfileFileName.setText(fileName);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onUnselect(int itemOrObjectId)
            {
                GuiEditorProfileInspector GuiEditorProfileInspector = "GuiEditorProfileInspector";
                GuiTextEditCtrl GuiEditorProfileFileName = "GuiEditorProfileFileName";

                GuiEditorProfileInspector.inspect("0");
                GuiEditorProfileFileName.setText("");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onProfileRenamed(string profile, string newName)
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                int item = this.findItemByValue(profile.getID().AsString());
                if (item == -1)
                    return;

                string newText = newName + " (" + profile.getID() + ")";
                if (GuiEditor.isProfileDirty(profile))
                    newText = newText + " *";

                this.editItem(item, newText, profile.getID().AsString());
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public string getSelectedProfile()
            {
                return this.getItemValue(this.getSelectedItem());
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void setSelectedProfile(string profile)
            {
                int id = this.findItemByValue(profile.getID().AsString());
                this.selectItem(id);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorProfilesTree ts, string simobjectid)
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
            public static bool operator !=(GuiEditorProfilesTree ts, string simobjectid)
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
            public static implicit operator string(GuiEditorProfilesTree ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorProfilesTree(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorProfilesTree) Omni.self.getSimObject(simobjectid, typeof (GuiEditorProfilesTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorProfilesTree ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorProfilesTree(int simobjectid)
            {
                return (GuiEditorProfilesTree) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorProfilesTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorProfilesTree ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorProfilesTree(uint simobjectid)
            {
                return (GuiEditorProfilesTree) Omni.self.getSimObject(simobjectid, typeof (GuiEditorProfilesTree));
            }

            #endregion
        }
    }
}