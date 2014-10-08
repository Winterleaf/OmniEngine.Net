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

                pop["item[0]"] = "Rename" + '\t' + "" + '\t' +
                                 "GuiEditorTreeView.showItemRenameCtrl( GuiEditorTreeView.findItemByObjectId( guiTreePop.object ) );";
                pop["item[1]"] = "Delete" + '\t' + "" + '\t' + "GuiEditor.deleteControl( guiTreePop.object );";
                pop["item[2]"] = "-";
                pop["item[3]"] = "Locked" + '\t' + "" + '\t' +
                                 "guiTreePop.object.setLocked( !guiTreePop.object.locked ); GuiEditorTreeView.update();";
                pop["item[4]"] = "Hidden" + '\t' + "" + '\t' +
                                 "guiTreePop.object.setVisible( !guiTreePop.object.isVisible() ); GuiEditorTreeView.update();";
                pop["item[5]"] = "-";
                pop["item[6]"] = "Add New Controls Here" + '\t' + "" + '\t' +
                                 "GuiEditor.setCurrentAddSet( guiTreePop.object );";
                pop["item[7]"] = "Add Child Controls to Selection" + '\t' + "" + '\t' +
                                 "GuiEditor.selectAllControlsInSet( guiTreePop.object, false );";
                pop["item[8]"] = "Remove Child Controls from Selection" + '\t' + "" + '\t' +
                                 "GuiEditor.selectAllControlsInSet( guiTreePop.object, true );";

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
                           "tools/gui/images/treeview/hidden:" +
                           "tools/worldEditor/images/lockedHandle";

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
                popup.enableItem(7 ,(((GuiControl) obj).getCount() > 0));
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