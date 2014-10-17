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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind
{
    public class DatablockEditor
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "DatablockEditor_initialize")]
        public static void initialize()
        {
            omni.sGlobal["$DATABLOCK_EDITOR_DEFAULT_FILENAME"] = "art/datablocks/managedDatablocks.cs";
            new ObjectCreator("SimSet", "UnlistedDatablocks").Create();
        }

        //=============================================================================================
        //    Events.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorInspector>))]
        public class DatablockEditorInspector : EditorInspectorBase
        {
            internal UndoAction currentFieldEditAction
            {
                get { return this["currentFieldEditAction"]; }
                set { this["currentFieldEditAction"] = value; }
            }

            [ConsoleInteraction]
            public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
            {
                DatablockEditorPlugin DatablockEditorPlugin = "DatablockEditorPlugin";
                // Same work to do as for the regular WorldEditor Inspector.
                ((Inspector) "Inspector").onInspectorFieldModified(objectx, fieldName, arrayIndex, oldValue, newValue);

                DatablockEditorPlugin.flagDatablockAsDirty(objectx, true);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
            {
                ((GuiMLTextCtrl) "DatablockFieldInfoControl").setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ")" + '\n' + "<font:Arial:14>" + fieldDoc);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onBeginCompoundEdit()
            {
                editor Editor = "Editor";
                Editor.getUndoManager().pushCompound("Multiple Field Edit");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onEndCompoundEdit()
            {
                editor Editor = "Editor";
                Editor.getUndoManager().popCompound();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onClear()
            {
                ((GuiMLTextCtrl) "DatablockFieldInfoControl").setText("");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DatablockEditorInspector ts, string simobjectid)
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
            public static bool operator !=(DatablockEditorInspector ts, string simobjectid)
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
            public static implicit operator string(DatablockEditorInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DatablockEditorInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DatablockEditorInspector) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DatablockEditorInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DatablockEditorInspector(int simobjectid)
            {
                return (DatablockEditorInspector) Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DatablockEditorInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DatablockEditorInspector(uint simobjectid)
            {
                return (DatablockEditorInspector) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorInspector));
            }

            #endregion
        }

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorTree>))]
        public class DatablockEditorTree : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onDeleteSelection()
            {
                this["undoDeleteList"] = "";
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override bool onDeleteObject(SimObject objectx)
            {
                // Append it to our list.
                this["undoDeleteList"] = this["undoDeleteList"] + '\t' + objectx;

                // We're gonna delete this ourselves in the
                // completion callback.
                return true;
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onObjectDeleteCompleted()
            {
                //MEDeleteUndoAction::submit( %this.undoDeleteList );

                // Let the world editor know to 
                // clear its selection.
                //EWorldEditor.clearSelection();
                //EWorldEditor.isDirty = true;
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onClearSelected()
            {
                ((DatablockEditorInspector) "DatablockEditorInspector").inspect("0");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onAddSelection(int itemOrObjectId, bool isLastSelection)
            {
                DatablockEditorPlugin DatablockEditorPlugin = "DatablockEditorPlugin";

                SimObject obj = this.getItemValue(itemOrObjectId);

                if (!obj.isObject())
                    this.selectItem(itemOrObjectId, false);
                else
                    DatablockEditorPlugin.selectDatablock(obj, true, true);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onRemoveSelection(int itemOrObjectId)
            {
                DatablockEditorPlugin DatablockEditorPlugin = "DatablockEditorPlugin";

                SimObject obj = this.getItemValue(itemOrObjectId);
                if (obj.isObject())
                    DatablockEditorPlugin.unselectDatablock(obj, true);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onRightMouseUp(int itemId, string mousePos, SimObject objectx)
            {
                SimObject datablock = this.getItemValue(itemId);
                if (!datablock.isObject())
                    return;

                if (!((MenuBuilder) "DatablockEditorTreePopup").isObject())
                    {
                    ObjectCreator ocf = new ObjectCreator("PopupMenu", "DatablockEditorTreePopup", typeof (MenuBuilder));
                    ocf["isPopup"] = true.AsString();

                    ocf["item[0]"] = "Delete" + '\t' + "" + '\t' + "DatablockEditorPlugin.selectDatablock( %this.datablockObject ); DatablockEditorPlugin.deleteDatablock( %this.datablockObject );";
                    ocf["item[1]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' + "EditorOpenDeclarationInTorsion( %this.datablockObject );";

                    ocf["datablockObject"] = "";

                    ocf.Create();
                    }

                ((PopupMenu) "DatablockEditorTreePopup")["datablockObject"] = datablock;
                ((PopupMenu) "DatablockEditorTreePopup").showPopup("Canvas");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DatablockEditorTree ts, string simobjectid)
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
            public static bool operator !=(DatablockEditorTree ts, string simobjectid)
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
            public static implicit operator string(DatablockEditorTree ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DatablockEditorTree(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DatablockEditorTree) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DatablockEditorTree ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DatablockEditorTree(int simobjectid)
            {
                return (DatablockEditorTree) Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DatablockEditorTree ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DatablockEditorTree(uint simobjectid)
            {
                return (DatablockEditorTree) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTree));
            }

            #endregion
        }

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorTreeTabBook>))]
        public class DatablockEditorTreeTabBook : GuiTabBookCtrl
        {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
            {
                GuiWindowCollapseCtrl DatablockEditorTreeWindow = "DatablockEditorTreeWindow";
                GuiBitmapButtonCtrl DeleteSelection = DatablockEditorTreeWindow.findObjectByInternalName("DeleteSelection", true);
                GuiBitmapButtonCtrl CreateSelection = DatablockEditorTreeWindow.findObjectByInternalName("CreateSelection", true);

                switch (index)
                    {
                        case 0:
                            DeleteSelection.visible = true;
                            CreateSelection.visible = false;
                            break;

                        case 1:
                            DeleteSelection.visible = false;
                            CreateSelection.visible = true;
                            break;
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DatablockEditorTreeTabBook ts, string simobjectid)
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
            public static bool operator !=(DatablockEditorTreeTabBook ts, string simobjectid)
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
            public static implicit operator string(DatablockEditorTreeTabBook ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DatablockEditorTreeTabBook(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DatablockEditorTreeTabBook) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTreeTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DatablockEditorTreeTabBook ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DatablockEditorTreeTabBook(int simobjectid)
            {
                return (DatablockEditorTreeTabBook) Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorTreeTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DatablockEditorTreeTabBook ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DatablockEditorTreeTabBook(uint simobjectid)
            {
                return (DatablockEditorTreeTabBook) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTreeTabBook));
            }

            #endregion
        }
    }
}