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
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorTreeView>))]
    public class GuiEditorTreeView : GuiTreeViewCtrl
    {
        internal MenuBuilder contextMenu
        {
            get { return this["contextMenu"]; }
            set { this["contextMenu"] = value; }
        }

        internal MenuBuilder contextMenuMultiSel
        {
            get { return this["contextMenuMultiSel"]; }
            set { this["contextMenuMultiSel"] = value; }
        }

        internal UndoActionReparentObjects reparentUndoAction
        {
            get { return this["reparentUndoAction"]; }
            set { this["reparentUndoAction"] = value; }
        }

        [ConsoleInteraction]
        public void init()
        {
            if (!this.contextMenu.isObject())
                {
                ObjectCreator pop = new ObjectCreator("PopupMenu", "guiTreePop", typeof (MenuBuilder));
                pop["isPopup"] = true;

                pop["item[0]"] = "Rename" + '\t' + "" + '\t' + "GuiEditorTreeView.showItemRenameCtrl( GuiEditorTreeView.findItemByObjectId( guiTreePop.object ) );";
                pop["item[1]"] = "Delete" + '\t' + "" + '\t' + "GuiEditor.deleteControl( guiTreePop.object );";
                pop["item[2]"] = "-";
                pop["item[3]"] = "Locked" + '\t' + "" + '\t' + "guiTreePop.object.setLocked( !guiTreePop.object.locked ); GuiEditorTreeView.update();";
                pop["item[4]"] = "Hidden" + '\t' + "" + '\t' + "guiTreePop.object.setVisible( !guiTreePop.object.isVisible() ); GuiEditorTreeView.update();";
                pop["item[5]"] = "-";
                pop["item[6]"] = "Add New Controls Here" + '\t' + "" + '\t' + "GuiEditor.setCurrentAddSet( guiTreePop.object );";
                pop["item[7]"] = "Add Child Controls to Selection" + '\t' + "" + '\t' + "GuiEditor.selectAllControlsInSet( guiTreePop.object, false );";
                pop["item[8]"] = "Remove Child Controls from Selection" + '\t' + "" + '\t' + "GuiEditor.selectAllControlsInSet( guiTreePop.object, true );";

                pop["object"] = -1;

                this.contextMenu = pop.Create();
                }

            if (!this.contextMenuMultiSel.isObject())
                {
                ObjectCreator multiSel = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
                multiSel["isPopup"] = true;

                multiSel["item[0]"] = "Delete" + '\t' + "" + '\t' + "GuiEditor.deleteSelection();";

                this.contextMenuMultiSel = multiSel.Create();
                }
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void update()
        {
            GuiControl GuiEditorContent = "GuiEditorContent";
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            SimObject obj = GuiEditorContent.getObject(0);

            if (!obj.isObject())
                this.clear();
            else
                {
                // Open inspector tree.

                this.open(obj);

                // Sync selection with GuiEditor.

                this.clearSelection();

                SimSet selection = GuiEditor.getSelection();
                int count = selection.getCount();

                for (uint i = 0; i < count; i ++)
                    this.addSelection(selection.getObject(i).AsInt(), false);
                }
        }

        //=============================================================================================
        //    Event Handlers.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        public override void onDefineIcons()
        {
            string icons = ":" + // Default1
                           ":" + // SimGroup1
                           ":" + // SimGroup2
                           ":" + // SimGroup3
                           ":" + // SimGroup4
                           "tools/gui/images/treeview/hidden:" + "tools/worldEditor/images/lockedHandle";

            this.buildIconTable(icons);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onRightMouseDown(string item, string pts, string obj)
        {
            GuiCanvas Canvas = "Canvas";

            MenuBuilder popup;

            if (this.getSelectedItemsCount() > 1)
                {
                popup = this.contextMenuMultiSel;
                popup.showPopup(Canvas);
                }
            else if (obj.isObject())
                {
                popup = this.contextMenu;

                popup.checkItem(3, ((GuiControl) obj)["locked"].AsBool());
                popup.checkItem(4, (!((GuiControl) obj).isVisible()));

                popup.enableItem(6, ((GuiControl) obj).isContainer);
                popup.enableItem(7, (((GuiControl) obj).getCount() > 0));
                popup.enableItem(8, (((GuiControl) obj).getCount() > 0));

                popup["object"] = obj;
                popup.showPopup(Canvas);
                }
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onAddSelection(int ctrl, bool isLastSelection)
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            GuiEditor.dontSyncTreeViewSelection = true;
            GuiEditor.addSelection(ctrl);
            GuiEditor.dontSyncTreeViewSelection = false;
            GuiEditor.setFirstResponderX();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onRemoveSelection(int ctrl)
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            GuiEditor.dontSyncTreeViewSelection = true;
            GuiEditor.removeSelection(ctrl);
            GuiEditor.dontSyncTreeViewSelection = false;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onDeleteSelection()
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            GuiEditor.clearSelection();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onSelect(string obj, string y)
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";

            if (obj.isObject())
                {
                GuiEditor.dontSyncTreeViewSelection = true;
                GuiEditor.select(obj);
                GuiEditor.dontSyncTreeViewSelection = false;
                GuiEditorInspectFields.update(obj);
                }
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override bool isValidDragTarget(int id, string obj)
        {
            return (((GuiControl) obj).isContainer || ((GuiControl) obj).getCount() > 0);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onBeginReparenting()
        {
            UndoActionReparentObjects UndoActionReparentObjects = "UndoActionReparentObjects";

            if (this.reparentUndoAction.isObject())
                this.reparentUndoAction.delete();

            UndoActionReparentObjects action = UndoActionReparentObjects.create(this);

            this.reparentUndoAction = action;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onReparent(int obj, int oldParent, int newParent)
        {
            this.reparentUndoAction.add(obj, oldParent.AsString(), newParent.AsString());
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onEndReparenting()
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            UndoActionReparentObjects action = this.reparentUndoAction;
            this.reparentUndoAction = "";

            if (action.numObjects > 0)
                {
                if (action.numObjects == 1)
                    action.actionName = "Reparent Control";
                else
                    action.actionName = "Reparent Controls";

                action.addToManager(GuiEditor.getUndoManager());

                GuiEditor.updateUndoMenu();
                }
            else
                action.delete();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorTreeView ts, string simobjectid)
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
        public static bool operator !=(GuiEditorTreeView ts, string simobjectid)
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
        public static implicit operator string(GuiEditorTreeView ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorTreeView(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorTreeView) Omni.self.getSimObject(simobjectid, typeof (GuiEditorTreeView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorTreeView ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorTreeView(int simobjectid)
        {
            return (GuiEditorTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorTreeView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorTreeView ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorTreeView(uint simobjectid)
        {
            return (GuiEditorTreeView) Omni.self.getSimObject(simobjectid, typeof (GuiEditorTreeView));
        }

        #endregion
    }
}