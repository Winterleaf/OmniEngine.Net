using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
            public static bool operator !=(ActionCreateDatablock ts, string simobjectid)
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
                return
                    (ActionCreateDatablock) Omni.self.getSimObject((uint) simobjectid, typeof (ActionCreateDatablock));
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
            public static bool operator !=(ActionDeleteDatablock ts, string simobjectid)
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
                return
                    (ActionDeleteDatablock) Omni.self.getSimObject((uint) simobjectid, typeof (ActionDeleteDatablock));
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
            public static bool operator !=(BaseDatablockEdAction ts, string simobjectid)
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
                return
                    (BaseDatablockEdAction) Omni.self.getSimObject((uint) simobjectid, typeof (BaseDatablockEdAction));
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