using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

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
                ((Inspector)"Inspector").onInspectorFieldModified(objectx, fieldName,arrayIndex, oldValue, newValue);

                DatablockEditorPlugin.flagDatablockAsDirty(objectx, true);
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
                {
                ((GuiMLTextCtrl) "DatablockFieldInfoControl").setText("<font:ArialBold:14>" + fieldName +
                                                                        "<font:ArialItalic:14> (" + fieldTypeStr +
                                                                        ")" + '\n' + "<font:Arial:14>" + fieldDoc);
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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
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
                return
                    (DatablockEditorInspector)
                        Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorInspector));
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
                    ObjectCreator ocf =
                        new ObjectCreator("PopupMenu", "DatablockEditorTreePopup", typeof (MenuBuilder));
                    ocf["isPopup"] = true.AsString();

                    ocf["item[0]"] = "Delete" + '\t' + "" + '\t' +
                                     "DatablockEditorPlugin.selectDatablock( %this.datablockObject ); DatablockEditorPlugin.deleteDatablock( %this.datablockObject );";
                    ocf["item[1]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' +
                                     "EditorOpenDeclarationInTorsion( %this.datablockObject );";

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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
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
                GuiBitmapButtonCtrl DeleteSelection =
                    DatablockEditorTreeWindow.findObjectByInternalName("DeleteSelection", true);
                GuiBitmapButtonCtrl CreateSelection =
                    DatablockEditorTreeWindow.findObjectByInternalName("CreateSelection", true);

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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
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
                return
                    (DatablockEditorTreeTabBook)
                        Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTreeTabBook));
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
                return
                    (DatablockEditorTreeTabBook)
                        Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorTreeTabBook));
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
                return
                    (DatablockEditorTreeTabBook)
                        Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTreeTabBook));
                }

            #endregion
            }
        }
    }