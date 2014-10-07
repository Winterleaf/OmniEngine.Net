using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorInspectFields>))]
    public class GuiEditorInspectFields : EditorInspectorBase
        {
        internal UndoAction currentFieldEditAction
        {
            get { return this["currentFieldEditAction"]; }
            set { this["currentFieldEditAction"] = value; }
        }
        // Core for the main Gui Editor inspector that shows the properties of
        // the currently selected control.


        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void update(string inspectTarget)
            {
            this.inspect(inspectTarget);
            }

        //=============================================================================================
        //    Event Handlers.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
        {
            SimObject obj = objectx;
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

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

            // Restore the instant group.
            Util.popInstantGroup();

            action.addToManager(GuiEditor.getUndoManager());

            GuiEditor.updateUndoMenu();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onInspectorPreFieldModification(string fieldName, string arrayIndex)
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            Util.pushInstantGroup();
            UndoManager undoManager = GuiEditor.getUndoManager();

            string action = "";
            int numObjects = this.getNumInspectObjects();
            if (numObjects > 1)
                action = undoManager.pushCompound("Multiple Field Edit");

            for (uint i = 0; i < numObjects; i ++)
                {
                SimObject obj = this.getInspectObject(i);

                string nameOrClass = obj.getName();
                if (nameOrClass == "")
                    nameOrClass = obj.getClassName();

                ObjectCreator oc = new ObjectCreator("InspectorFieldUndoAction");
                oc["actionName"] = nameOrClass + "." + fieldName + " Change";

                oc["objectId"] = obj.getId();
                oc["fieldName"] = fieldName;
                oc["fieldValue"] = obj.getFieldValue(fieldName, arrayIndex == "(null)" ? -1 : arrayIndex.AsInt() );
                oc["arrayIndex"] = arrayIndex;

                oc["inspectorGui"] = this;

                InspectorFieldUndoAction undo = oc.Create();

                if (numObjects > 1)
                    undo.addToManager(undoManager);
                else
                    {
                    action = undo;
                    break;
                    }
                }

            this.currentFieldEditAction = action;
            Util.popInstantGroup();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onInspectorPostFieldModification()
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            if (this.currentFieldEditAction.isMemberOfClass("CompoundUndoAction"))
                {
                // Finish multiple field edit.
                GuiEditor.getUndoManager().popCompound();
                }
            else
                {
                // Queue single field undo.
                this.currentFieldEditAction.addToManager(GuiEditor.getUndoManager());
                }

            this.currentFieldEditAction = "";
            GuiEditor.updateUndoMenu();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onInspectorDiscardFieldModification()
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            this.currentFieldEditAction.undo();

            if (this.currentFieldEditAction.isMemberOfClass("CompoundUndoAction"))
                {
                // Multiple field editor.  Pop and discard.
                GuiEditor.getUndoManager().popCompound(true);
                }
            else
                {
                // Single field edit.  Just kill undo action.
                this.currentFieldEditAction.delete();
                }

            this.currentFieldEditAction = "";
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
            {
            GuiMLTextCtrl GuiEditorFieldInfo = "GuiEditorFieldInfo";

            GuiEditorFieldInfo.setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr +
                                       ") " + '\n' + "<font:Arial:14>" + fieldDoc);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onBeginCompoundEdit()
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            GuiEditor.getUndoManager().pushCompound("Multiple Field Edits");
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onEndCompoundEdit()
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            GuiEditor.getUndoManager().popCompound();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorInspectFields ts, string simobjectid)
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
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(GuiEditorInspectFields ts, string simobjectid)
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
        public static implicit operator string(GuiEditorInspectFields ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorInspectFields(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorInspectFields) Omni.self.getSimObject(simobjectid, typeof (GuiEditorInspectFields));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorInspectFields ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorInspectFields(int simobjectid)
            {
            return (GuiEditorInspectFields) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorInspectFields));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorInspectFields ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorInspectFields(uint simobjectid)
            {
            return (GuiEditorInspectFields) Omni.self.getSimObject(simobjectid, typeof (GuiEditorInspectFields));
            }

        #endregion
        }
    }