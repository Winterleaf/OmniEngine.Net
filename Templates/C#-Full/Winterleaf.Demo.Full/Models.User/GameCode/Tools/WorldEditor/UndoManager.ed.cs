using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.Extendable
//namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    public partial class UndoManager
        {
        [TypeConverter(typeof (TypeConverterGeneric<EUndoManager>))]
        public class EUndoManager : WinterLeaf.Demo.Full.Models.User.Extendable.UndoManager
            {
            [ConsoleInteraction]
            public override void onUndo()
                {
                }

            [ConsoleInteraction]
            public override void onRedo()
                {
                }

            [ConsoleInteraction]
            public override void onAddUndo()
                {
                }

            [ConsoleInteraction]
            public override void onRemoveUndo()
                {
                }

            [ConsoleInteraction]
            public override void onClear()
                {
                }

            [ConsoleInteraction]
            public void updateUndoMenu(MenuBuilder editMenu)
                {
                // TODO: If we ever fix the TerrainEditor and WorldEditor
                // to have descriptive UndoAction names then we can change
                // the text as part of the menu update.

                string undoName = this.getNextUndoName();
                string redoName = this.getNextRedoName();

                editMenu.setItemName(0, "Undo " + undoName);
                editMenu.setItemName(1, "Redo " + redoName);

                editMenu.enableItem(0, (undoName != ""));
                editMenu.enableItem(1, (redoName != ""));
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EUndoManager ts, string simobjectid)
                {
                return ReferenceEquals(ts, null)
                    ? ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(EUndoManager ts, string simobjectid)
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
            public static implicit operator string(EUndoManager ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EUndoManager(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EUndoManager) Omni.self.getSimObject(simobjectid, typeof (EUndoManager));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EUndoManager ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EUndoManager(int simobjectid)
                {
                return (EUndoManager) Omni.self.getSimObject((uint) simobjectid, typeof (EUndoManager));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EUndoManager ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EUndoManager(uint simobjectid)
                {
                return (EUndoManager) Omni.self.getSimObject(simobjectid, typeof (EUndoManager));
                }

            #endregion
            }
        }
    }

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class MECreateUndoAction
        {
        

        [ConsoleInteraction]
        /// A helper for submitting a creation undo action.
        public static void submit(SimObject undoObject)
            {
            editor Editor = "Editor";

            // The instant group will try to add our
            // UndoAction if we don't disable it.   
            omni.Util.pushInstantGroup();

            // Create the undo action.     
            ObjectCreator actionCreator = new ObjectCreator("MECreateUndoAction");
            actionCreator["actionName"] = "Create " + undoObject.getClassName();

            MECreateUndoAction action = actionCreator.Create();

            // Restore the instant group.
            omni.Util.popInstantGroup();

            // Set the object to undo.
            action.addObject(undoObject);

            // Submit it.
            action.addToManager(Editor.getUndoManager());
            }

        [ConsoleInteraction]
        public override void onUndone()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
            }

        [ConsoleInteraction]
        public override void onRedone()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
            }
        }

    public partial class MEDeleteUndoAction
        {
        

        //todo need to change this.
        //[ConsoleInteraction ]
        /// A helper for submitting a delete undo action.
        /// If %wordSeperated is not specified or is false it is assumed %deleteObjects
        /// is tab sperated.
        public static void submit(string deleteObjects, bool wordSeperated)
            {
            editor Editor = "Editor";

            // The instant group will try to add our
            // UndoAction if we don't disable it.   
            omni.Util.pushInstantGroup();

            // Create the undo action.     
            ObjectCreator actionCreator = new ObjectCreator("MEDeleteUndoAction");
            actionCreator["actionName"] = "Delete";

            MEDeleteUndoAction action = actionCreator.Create();

            // Restore the instant group.
            omni.Util.popInstantGroup();

            // Add the deletion objects to the action which
            // will take care of properly deleting them.
            deleteObjects = omni.Util.trim(deleteObjects);

            if (wordSeperated)
                {
                int count = omni.Util.getWordCount(deleteObjects);
                for (int i = 0; i < count; i++)
                    {
                    SimObject xobject = omni.Util.getWord(deleteObjects, i);
                    action.deleteObject(xobject);
                    }
                }
            else
                {
                int count = omni.Util.getFieldCount(deleteObjects);
                for (int i = 0; i < count; i++)
                    {
                    SimObject xobject = omni.Util.getField(deleteObjects, i);
                    action.deleteObject(xobject);
                    }
                }

            // Submit it.
            action.addToManager(Editor.getUndoManager());
            }

        [ConsoleInteraction]
        public override void onUndone()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
            }

        [ConsoleInteraction]
        public override void onRedone()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
            }
        }
    }