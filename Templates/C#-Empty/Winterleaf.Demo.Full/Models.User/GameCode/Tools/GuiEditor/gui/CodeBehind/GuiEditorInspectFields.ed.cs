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
                oc["fieldValue"] = obj.getFieldValue(fieldName, arrayIndex == "(null)" ? -1 : arrayIndex.AsInt());
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

            GuiEditorFieldInfo.setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") " + '\n' + "<font:Arial:14>" + fieldDoc);
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
        public static bool operator !=(GuiEditorInspectFields ts, string simobjectid)
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