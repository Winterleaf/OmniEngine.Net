using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (EditorTree))]
    public class EditorTree : GuiTreeViewCtrl
        {
        public UndoActionReparentObjects reparentUndoAction
            {
            get { return this["reparentUndoAction"]; }
            set { this["reparentUndoAction"] = value; }
            }

        public string undoDeleteList
            {
            get { return this["undoDeleteList"]; }
            set { this["undoDeleteList"] = value; }
            }

        [ConsoleInteraction]
        public override void onDeleteSelection()
            {
            this.undoDeleteList = "";
            }

        [ConsoleInteraction]
        public override bool onDeleteObject(SimObject objectx)
            {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";
            SimGroup MissionGroup = "MissionGroup";

            // Don't delete locked objects
            if (objectx["locked"].AsBool())
                return true;

            if (objectx == EWCreatorWindow["objectGroup"])
                EWCreatorWindow.setNewObjectGroup(MissionGroup);

            // Append it to our list.
            this.undoDeleteList = this.undoDeleteList + '\t' + objectx;

            // We're gonna delete this ourselves in the
            // completion callback.
            return true;
            }

        [ConsoleInteraction]
        public override void onObjectDeleteCompleted()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            // This can be called when a deletion is attempted but nothing was
            // actually deleted ( cannot delete the root of the tree ) so only submit
            // the undo if we really deleted something.
            if (this.undoDeleteList != "")
                Extendable.MEDeleteUndoAction.submit(this.undoDeleteList, false);

            // Let the world editor know to 
            // clear its selection.
            EWorldEditor.clearSelection();
            EWorldEditor.isDirty = true;
            }

        [ConsoleInteraction]
        public void onClearSelected()
            {
            //TODO
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.clearSelection();
            }

        [ConsoleInteraction]
        public override void onInspect(int itemOrObjectId)
            {
                Inspector Inspector = "Inspector";

            Inspector.inspect(itemOrObjectId);
            }

        [ConsoleInteraction]
        public void toggleLock()
            {
            EWTreeWindow EWTreeWindow = "EWTreeWindow";
            GuiBitmapButtonCtrl LockSelection = EWTreeWindow.FOT("LockSelection");
            GuiBitmapButtonCtrl DeleteSelection = EWTreeWindow.FOT("DeleteSelection");

            if (LockSelection.command == "EWorldEditor.lockSelection(true); EditorTree.toggleLock();")
                {
                LockSelection.command = "EWorldEditor.lockSelection(false); EditorTree.toggleLock();";
                DeleteSelection.command = "";
                }
            else
                {
                LockSelection.command = "EWorldEditor.lockSelection(true); EditorTree.toggleLock();";
                DeleteSelection.command = "EditorMenuEditDelete();";
                }
            }

        [ConsoleInteraction]
        public override void onAddSelection(int obj, bool isLastSelection)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";
            Inspector Inspector = "Inspector";

            GuiBitmapButtonCtrl LockSelection = EWTreeWindow.FOT("LockSelection");
            GuiBitmapButtonCtrl DeleteSelection = EWTreeWindow.FOT("DeleteSelection");

            EWorldEditor.selectObject(obj.AsString());

            int selSize = EWorldEditor.getSelectionSize();
            int lockCount = EWorldEditor.getSelectionLockCount();

            if (lockCount < selSize)
                {
                LockSelection.setStateOn(false);
                LockSelection.command = "EWorldEditor.lockSelection(true); EditorTree.toggleLock();";
                }
            else if (lockCount > 0)
                {
                LockSelection.setStateOn(true);
                LockSelection.command = "EWorldEditor.lockSelection(false); EditorTree.toggleLock();";
                }

            if (selSize > 0 && lockCount == 0)
                DeleteSelection.command = "EditorMenuEditDelete();";
            else
                DeleteSelection.command = "";

            if (isLastSelection)
                Inspector.addInspect(obj.AsString());
            else
                Inspector.addInspect(obj.AsString(), false);
            }

        [ConsoleInteraction]
        public override void onRemoveSelection(int obj)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            Inspector Inspector = "Inspector";

            EWorldEditor.unselectObject(obj.AsString());
            Inspector.removeInspect(obj.AsString());
            }

        [ConsoleInteraction]
        public override void onSelect(string x, string y)
            {
            }

        [ConsoleInteraction]
        public override void onUnselect(int obj)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.unselectObject(obj.AsString());
            }

        [ConsoleInteraction]
        public override void onDragDropped()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.isDirty = true;
            }

        [ConsoleInteraction]
        public override void onAddGroupSelected(SimGroup @group)
            {
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";

            EWCreatorWindow.setNewObjectGroup(group);
            }

        [ConsoleInteraction]
        public override void onRightMouseUp(int itemId, string mousePos, SimObject obj)
            {
            MenuBuilder popup;
            GuiCanvas Canvas = "Canvas";

            bool haveObjectEntries = false;
            bool haveLockAndHideEntries = true;

            // Handle multi-selection.
            if (this.getSelectedItemsCount() > 1)
                {
                popup = "ETMultiSelectionContextPopup";
                if (!popup.isObject())
                    {
                    ObjectCreator popCreator = new ObjectCreator("PopupMenu", "ETMultiSelectionContextPopup",
                        typeof (MenuBuilder));
                    popCreator["isPopup"] = true.AsString();

                    popCreator["item[0]"] = "Delete" + '\t' + "" + '\t' + "EditorMenuEditDelete();";
                    popCreator["item[1]"] = "Group" + '\t' + "" + '\t' + "EWorldEditor.addSimGroup( true );";

                    popup = popCreator.Create();
                    }
                }

                // Open context menu if this is a CameraBookmark
            else if (obj.isMemberOfClass("CameraBookmark"))
                {
                popup = "ETCameraBookmarkContextPopup";
                if (!popup.isObject())
                    {
                    ObjectCreator popupCreator =
                        new ObjectCreator("PopupMenu", "ETCameraBookmarkContextPopup", typeof (MenuBuilder));
                    popupCreator["isPopup"] = true.AsString();

                    popupCreator["item[0]"] = "Go To Bookmark" + '\t' + "" + '\t' +
                                              "EditorGui.jumpToBookmark( this.bookmark.getInternalName() );";

                    popupCreator["bookmark"] = "-1";

                    popup = popupCreator.Create();
                    }

                ((MenuBuilder) "ETCameraBookmarkContextPopup")["bookmark"] = obj;
                }
   
                // Open context menu if this is set CameraBookmarks group.
            else if (obj.name == "CameraBookmarks")
                {
                popup = "ETCameraBookmarksGroupContextPopup";
                if (!popup.isObject())
                    {
                    popup =
                        new ObjectCreator("PopupMenu", "ETCameraBookmarksGroupContextPopup", typeof (MenuBuilder))
                            .Create();
                    popup.isPopup = true;

                    popup.addItem("0", "Add Camera Bookmark" + '\t' + "" + '\t' + "EditorGui.addCameraBookmarkByGui();");
                    }
                }

                // Open context menu if this is a SimGroup
            else if (obj.isMemberOfClass("SimGroup"))
                {
                popup = "ETSimGroupContextPopup";
                if (!popup.isObject())
                    {
                    ObjectCreator popupCreator = new ObjectCreator("PopupMenu", "ETSimGroupContextPopup",
                        typeof (MenuBuilder));
                    popupCreator["isPopup"] = true.AsString();

                    popupCreator["item[0]"] = "Rename" + '\t' + "" + '\t' +
                                              "EditorTree.showItemRenameCtrl( EditorTree.findItemByObjectId( ETSimGroupContextPopup.object ) );";
                    popupCreator["item[1]"] = "Delete" + '\t' + "" + '\t' +
                                              "EWorldEditor.deleteMissionObject( ETSimGroupContextPopup.object );";
                    popupCreator["item[2]"] = "Inspect" + '\t' + "" + '\t' +
                                              "inspectObject( ETSimGroupContextPopup.object );";
                    popupCreator["item[3]"] = "-";
                    popupCreator["item[4]"] = "Toggle Lock Children" + '\t' + "" + '\t' +
                                              "EWorldEditor.toggleLockChildren( ETSimGroupContextPopup.object );";
                    popupCreator["item[5]"] = "Toggle Hide Children" + '\t' + "" + '\t' +
                                              "EWorldEditor.toggleHideChildren( ETSimGroupContextPopup.object );";
                    popupCreator["item[6]"] = "-";
                    popupCreator["item[7]"] = "Group" + '\t' + "" + '\t' + "EWorldEditor.addSimGroup( true );";
                    popupCreator["item[8]"] = "-";
                    popupCreator["item[9]"] = "Add New Objects Here" + '\t' + "" + '\t' +
                                              "EWCreatorWindow.setNewObjectGroup( ETSimGroupContextPopup.object );";
                    popupCreator["item[10]"] = "Add Children to Selection" + '\t' + "" + '\t' +
                                               "EWorldEditor.selectAllObjectsInSet( ETSimGroupContextPopup.object, false );";
                    popupCreator["item[11]"] = "Remove Children from Selection" + '\t' + "" + '\t' +
                                               "EWorldEditor.selectAllObjectsInSet( ETSimGroupContextPopup.object, true );";

                    popupCreator["object"] = "-1";

                    popup = popupCreator.Create();
                    }

                popup["object"] = obj;

                bool hasChildren = ((SimGroup) obj).getCount() > 0;
                popup.enableItem(10, hasChildren);
                popup.enableItem(11, hasChildren);

                haveObjectEntries = true;
                haveLockAndHideEntries = false;
                }
   
                // Open generic context menu.
            else
                {
                popup = "ETContextPopup";
                if (!popup.isObject())
                    {
                    ObjectCreator popCreator = new ObjectCreator("PopupMenu", "ETContextPopup", typeof (MenuBuilder));
                    popCreator["isPopup"] = true.AsString();

                    popCreator["item[0]"] = "Rename" + '\t' + "" + '\t' +
                                            "EditorTree.showItemRenameCtrl( EditorTree.findItemByObjectId( ETContextPopup.object ) );";
                    popCreator["item[1]"] = "Delete" + '\t' + "" + '\t' +
                                            "EWorldEditor.deleteMissionObject( ETContextPopup.object );";
                    popCreator["item[2]"] = "Inspect" + '\t' + "" + '\t' + "inspectObject( ETContextPopup.object );";
                    popCreator["item[3]"] = "-";
                    popCreator["item[4]"] = "Locked" + '\t' + "" + '\t' +
                                            "ETContextPopup.object.setLocked( !ETContextPopup.object.locked ); EWorldEditor.syncGui();";
                    popCreator["item[5]"] = "Hidden" + '\t' + "" + '\t' +
                                            "EWorldEditor.hideObject( ETContextPopup.object, !ETContextPopup.object.hidden ); EWorldEditor.syncGui();";
                    popCreator["item[6]"] = "-";
                    popCreator["item[7]"] = "Group" + '\t' + "" + '\t' + "EWorldEditor.addSimGroup( true );";

                    popCreator["object"] = "-1";

                    popup = popCreator.Create();
                    }

                // Specialized version for ConvexShapes. 
                if (obj.isMemberOfClass("ConvexShape"))
                    {
                    popup = "ETConvexShapeContextPopup";
                    if (!popup.isObject())
                        {
                        ObjectCreator popCreator =
                            new ObjectCreator("PopupMenu", "ETConvexShapeContextPopup", typeof (MenuBuilder));
                        popCreator["isPopup"] = true.AsString();

                        popCreator["item[8]"] = "-";
                        popCreator["item[9]"] = "Convert to Zone" + '\t' + "" + '\t' +
                                                "EWorldEditor.convertSelectionToPolyhedralObjects( \\\"Zone\\\" );";
                        popCreator["item[10]"] = "Convert to Portal" + '\t' + "" + '\t' +
                                                 "EWorldEditor.convertSelectionToPolyhedralObjects( \\\"Portal\\\" );";
                        popCreator["item[11]"] = "Convert to Occluder" + '\t' + "" + '\t' +
                                                 "EWorldEditor.convertSelectionToPolyhedralObjects( \\\"OcclusionVolume\\\" );";
                        popCreator["item[12]"] = "Convert to Sound Space" + '\t' + "" + '\t' +
                                                 "EWorldEditor.convertSelectionToPolyhedralObjects( \\\"SFXSpace\\\" );";

                        popup = popCreator.Create();
                        }
                    }
      
                    // Specialized version for polyhedral objects.
                else if (obj.isMemberOfClass("Zone") ||
                         obj.isMemberOfClass("Portal") ||
                         obj.isMemberOfClass("OcclusionVolume") ||
                         obj.isMemberOfClass("SFXSpace"))
                    {
                    popup = "ETPolyObjectContextPopup";
                    if (!popup.isObject())
                        {
                        ObjectCreator popCreator =
                            new ObjectCreator("PopupMenu", "ETPolyObjectContextPopup", typeof (MenuBuilder));
                        popCreator["isPopup"] = true.AsString();

                        popCreator["item[8]"] = "-";
                        popCreator["item[9]"] = "Convert to ConvexShape" + '\t' + "" + '\t' +
                                                "EWorldEditor.convertSelectionToConvexShape();";

                        popup = popCreator.Create();
                        }
                    }

                popup["object"] = obj;
                haveObjectEntries = true;
                }

            if (haveObjectEntries)
                {
                popup.enableItem(0, (obj.isNameChangeAllowed() && obj.getName() != "MissionGroup"));
                popup.enableItem(1, (obj.getName() != "MissionGroup"));
                if (haveLockAndHideEntries)
                    {
                    popup.checkItem(4, obj["locked"].AsBool());
                    popup.checkItem(5, obj.hidden);
                    }
                popup.enableItem(7, this.isItemSelected(itemId));
                }

            popup.showPopup(Canvas);
            }

        [ConsoleInteraction]
        public void positionContextMenu(SimObject menu)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            if ((Util.getWord(menu["position"], 0).AsInt() + Util.getWord(menu["extent"], 0).AsInt()) >
                Util.getWord(EWorldEditor["extent"], 0).AsInt())
                {
                int posx = Util.getWord(menu["position"], 0).AsInt();
                int offset = Util.getWord(EWorldEditor["extent"], 0).AsInt() -
                             (posx + Util.getWord(menu["extent"], 0).AsInt()) - 5;
                posx += offset;
                menu["position"] = posx + " " + Util.getWord(menu["position"], 1);
                }
            }

        [ConsoleInteraction]
        public bool isValidDragTarget(int id, SimObject obj)
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            if (obj.isMemberOfClass("Path"))
                return EWorldEditor.areAllSelectedObjectsOfType("Marker");
            if (obj.name == "CameraBookmarks")
                return EWorldEditor.areAllSelectedObjectsOfType("CameraBookmark");
            else
                return (obj.getClassName() == "SimGroup");
            }

        [ConsoleInteraction]
        public override void onBeginReparenting()
            {
            UndoActionReparentObjects UndoActionReparentObjects = "UndoActionReparentObjects";

            if (this.reparentUndoAction.isObject())
                this.reparentUndoAction.delete();

            UndoActionReparentObjects action = UndoActionReparentObjects.create(this);

            this.reparentUndoAction = action;
            }

        [ConsoleInteraction]
        public override void onReparent(int obj, int oldParent, int newParent)
            {
            this.reparentUndoAction.add(obj, oldParent.AsString(), newParent.AsString());
            }

        [ConsoleInteraction]
        public override void onEndReparenting()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            editor Editor = "Editor";

            UndoActionReparentObjects action = this.reparentUndoAction;
            this.reparentUndoAction = "";

            if (action.numObjects > 0)
                {
                if (action.numObjects == 1)
                    action.actionName = "Reparent Object";
                else
                    action.actionName = "Reparent Objects";

                action.addToManager(Editor.getUndoManager());

                EWorldEditor.syncGui();
                }
            else
                action.delete();
            }

        [ConsoleInteraction]
        public void update()
            {
            this.buildVisibleTree(false);
            }

        //------------------------------------------------------------------------------

        // Tooltip for TSStatic
        [ConsoleInteraction]
        public string GetTooltipTSStatic(SimObject obj)
            {
            return "Shape: " + obj["shapeName"];
            }

        // Tooltip for ShapeBase
        [ConsoleInteraction]
        public string GetTooltipShapeBase(SimObject obj)
            {
            return "Datablock: " + obj["dataBlock"];
            }

        // Tooltip for StaticShape
        [ConsoleInteraction]
        public string GetTooltipStaticShape(SimObject obj)
            {
            return "Datablock: " + obj["dataBlock"];
            }

        // Tooltip for Item
        [ConsoleInteraction]
        public string GetTooltipItem(SimObject obj)
            {
            return "Datablock: " + obj["dataBlock"];
            }

        // Tooltip for RigidShape
        [ConsoleInteraction]
        public string GetTooltipRigidShape(SimObject obj)
            {
            return "Datablock: " + obj["dataBlock"];
            }

        // Tooltip for Prefab
        [ConsoleInteraction]
        public string GetTooltipPrefab(SimObject obj)
            {
            return "File: " + obj["filename"];
            }

        // Tooltip for GroundCover
        [ConsoleInteraction]
        public string GetTooltipGroundCover(SimObject obj)
            {
            string text = "Material: " + obj["material"];
            for (int i = 0; i < 8; i++)
                {
                if (obj["probability[" + i + "]"].AsInt() > 0 && obj["shapeFilename[" + i + "]"] != "")
                    {
                    text = text + '\n' + "Shape " + i + ": " + obj["shapeFilename[" + i + "]"];
                    }
                }
            return text;
            }

        // Tooltip for SFXEmitter
        [ConsoleInteraction]
        public string GetTooltipSFXEmitter(SimObject obj)
            {
            if (obj["fileName"] == "")
                return "Track: " + obj["track"];
            else
                return "File: " + obj["fileName"];
            }

        // Tooltip for ParticleEmitterNode
        [ConsoleInteraction]
        public string GetTooltipParticleEmitterNode(SimObject obj)
            {
            string text = "Datablock: " + obj["dataBlock"];
            text = text + '\n' + "Emitter: " + obj["emitter"];
            return text;
            }

        // Tooltip for WorldEditorSelection
        [ConsoleInteraction]
        public string GetTooltipWorldEditorSelection(SimObject obj)
            {
            string text = "Objects: " + obj.call("getCount");

            if (!obj.getCanSave())
                text = text + '\n' + "Persistent: No";
            else
                text = text + '\n' + "Persistent: Yes";

            return text;
            }

        public class EditorTreeTabBook : GuiTabBookCtrl
            {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
                {
                EWTreeWindow EWTreeWindow = "EWTreeWindow";

                GuiBitmapButtonCtrl DeleteSelection = EWTreeWindow.FOT("DeleteSelection");
                GuiBitmapButtonCtrl LockSelection = EWTreeWindow.FOT("LockSelection");
                GuiBitmapButtonCtrl AddSimGroup = EWTreeWindow.FOT("AddSimGroup");

                if (this.getSelectedPage() == 0)
                    {
                    DeleteSelection.visible = true;
                    LockSelection.visible = true;
                    AddSimGroup.visible = true;
                    }
                else
                    {
                    DeleteSelection.visible = false;
                    LockSelection.visible = false;
                    AddSimGroup.visible = false;
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorTreeTabBook ts, string simobjectid)
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
            public static bool operator !=(EditorTreeTabBook ts, string simobjectid)
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
            public static implicit operator string(EditorTreeTabBook ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorTreeTabBook(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EditorTreeTabBook) Omni.self.getSimObject(simobjectid, typeof (EditorTreeTabBook));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorTreeTabBook ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorTreeTabBook(int simobjectid)
                {
                return (EditorTreeTabBook) Omni.self.getSimObject((uint) simobjectid, typeof (EditorTreeTabBook));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorTreeTabBook ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorTreeTabBook(uint simobjectid)
                {
                return (EditorTreeTabBook) Omni.self.getSimObject(simobjectid, typeof (EditorTreeTabBook));
                }

            #endregion
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorTree ts, string simobjectid)
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
        public static bool operator !=(EditorTree ts, string simobjectid)
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
        public static implicit operator string(EditorTree ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorTree(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorTree) Omni.self.getSimObject(simobjectid, typeof (EditorTree));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorTree ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorTree(int simobjectid)
            {
            return (EditorTree) Omni.self.getSimObject((uint) simobjectid, typeof (EditorTree));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorTree ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorTree(uint simobjectid)
            {
            return (EditorTree) Omni.self.getSimObject(simobjectid, typeof (EditorTree));
            }

        #endregion
        }
    }