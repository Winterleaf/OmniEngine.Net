#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    [TypeConverter(typeof(TypeConverterGeneric<Inspector>))]
    public class Inspector : EditorInspectorBase
        {
        internal UndoAction currentFieldEditAction
            {
            get { return this["currentFieldEditAction"]; }
            set { this["currentFieldEditAction"] = value; }
            }

        [ConsoleInteraction]
        public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
        {
            SimObject obj = objectx;
            editor Editor = "Editor";
            // The instant group will try to add our
            // UndoAction if we don't disable it.  
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

            // If it's a datablock, initiate a retransmit.  Don't do so
            // immediately so as the actual field value will only be set
            // by the inspector code after this method has returned.

            if (obj.isMemberOfClass("SimDataBlock"))
                obj.schedule("1", "reloadOnLocalClient");

            // Restore the instant group.
            Util.popInstantGroup();

            action.addToManager(Editor.getUndoManager());

            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.isDirty = true;

            // Update the selection
            if (EWorldEditor.getSelectionSize() > 0 &&
                (fieldName == "position" || fieldName == "rotation" || fieldName == "scale"))
                EWorldEditor.invalidateSelectionCentroid();
            }

        [ConsoleInteraction]
        public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
            {
            ((GuiMLTextCtrl) "FieldInfoControl").setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" +
                                                           fieldTypeStr + ") \r\n<font:Arial:14>" + fieldDoc);
            }

        [ConsoleInteraction]
        public void onInspectorPreFieldModification(string fieldName, string arrayIndex)
            {
            Util.pushInstantGroup();
            editor Editor = "Editor";

            UndoManager undoManager = Editor.getUndoManager();

            int numOfObjects = this.getNumInspectObjects();

            UndoAction action = "0";
            if (numOfObjects > 1)
                action = undoManager.pushCompound("Multiple Field Edit");

            for (uint i = 0; i < numOfObjects; i++)
                {
                SimObject obj = getInspectObject(i);

                string nameOrClass = obj.getName();

                if (nameOrClass == "")
                    nameOrClass = obj.getClassName();

                ObjectCreator oc = new ObjectCreator("InspectorFieldUndoAction");
                oc["actionName"] = nameOrClass + "." + fieldName + " Change";
                oc["objectId"] = obj.getId();
                oc["fieldName"] = fieldName;
                oc["fieldValue"] = obj.getFieldValue(fieldName, arrayIndex == "(null)" ? -1 : arrayIndex.AsInt());
                oc["arrayIndex"] = arrayIndex;
                oc["inspectorGui"] = this;

                InspectorFieldUndoAction undo = oc.Create();

                if (numOfObjects > 1)
                    undo.addToManager(undoManager);
                else
                    {
                    action = undo;
                    break;
                    }
                }
            this["currentFieldEditAction"] = action;
            Util.popInstantGroup();
            }

        [ConsoleInteraction]
        public void onInspectorPostFieldModification()
            {
            editor Editor = "Editor";
            if (currentFieldEditAction.isMemberOfClass("CompoundUndoAction"))
                Editor.getUndoManager().popCompound();
            else
                currentFieldEditAction.addToManager(Editor.getUndoManager());

            currentFieldEditAction = "";

            ((EWorldEditor) "EWorldEditor").isDirty = true;
            }

        [ConsoleInteraction]
        public void onInspectorDiscardFieldModification()
            {
            editor Editor = "Editor";
            currentFieldEditAction.undo();

            if (currentFieldEditAction.isMemberOfClass("CompoundUndoAction"))
                Editor.getUndoManager().popCompound(true);
            else
                currentFieldEditAction.delete();

            this.currentFieldEditAction = "";
            }

        [ConsoleInteraction]
        public void inspect(SimObject obj)
            {
            string name = "";
            if (obj.isObject())
                name = obj.getName();
            else
                ((GuiMLTextCtrl) "FieldInfoControl").setText("");

            base.inspect(obj);
            }

        [ConsoleInteraction]
        public override void onBeginCompoundEdit()
            {
            editor Editor = "Editor";
            Editor.getUndoManager().pushCompound("Multiple Field Edit");
            }

        [ConsoleInteraction]
        public override void onEndCompoundEdit()
            {
            editor Editor = "Editor";
            Editor.getUndoManager().popCompound();
            }

        [ConsoleInteraction]
        public virtual void onCancelCompoundEdit()
            {
            editor Editor = "Editor";
            Editor.getUndoManager().popCompound(true);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Inspector ts, string simobjectid)
        {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(Inspector ts, string simobjectid)
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
        public static implicit operator string(Inspector ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator Inspector(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Inspector)Omni.self.getSimObject(simobjectid, typeof(Inspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Inspector ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Inspector(int simobjectid)
        {
            return (Inspector)Omni.self.getSimObject((uint)simobjectid, typeof(Inspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Inspector ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Inspector(uint simobjectid)
        {
            return (Inspector)Omni.self.getSimObject(simobjectid, typeof(Inspector));
        }

        #endregion
        }
    }