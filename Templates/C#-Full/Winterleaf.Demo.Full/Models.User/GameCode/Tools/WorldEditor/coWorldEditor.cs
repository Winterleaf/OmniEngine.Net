#region


using WinterLeaf.Demo.Full.Models.Base;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class WorldEditor : WorldEditor_Base
        {
        [ConsoleInteraction]
        public void onSelect(SimObject obj)
            {
            EditorTree EditorTree = "EditorTree";
            EditorTree.addSelection(obj, true);
            Util.setShadowVizLight(obj);
            if (obj.isObject() && obj.isMethod("onEditorSelect"))
                obj.call("onEditorSelect", getSelectionSize().AsString());


            EditorGui EditorGui = "EditorGui";
            EditorGui.currentEditor.onObjectSelected(obj);

            // Inform the camera

            console.commandToServer("EditorOrbitCameraSelectChange",
                new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});

            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            EditorGuiStatusBar.setSelectionObjectsByCount(getSelectionSize().AsString());

            // Update the materialEditorList

            iGlobal["$Tools::materialEditorList"] = obj.getId();

            // Used to help the Material Editor( the M.E doesn't utilize its own TS control )
            // so this dirty extension is used to fake it, just like the women I use to date...
            GuiWindowCollapseCtrl womanIUseToDate = "MaterialEditorPreviewWindow";
            GuiControl theOtherTramp = "MaterialEditorGui";
            if (womanIUseToDate.isVisible())
                theOtherTramp.call("prepareActiveObject");


            // Update the Transform Selection window

            ETransformSelection ETransformSelection = "ETransformSelection";
            ETransformSelection.onSelectionChanged();
            }

        [ConsoleInteraction]
        public void onMultiSelect(SimSet set)
            {
            EditorTree EditorTree = "EditorTree";
            EditorGui EditorGui = "EditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ETransformSelection ETransformSelection = "ETransformSelection";
            int count = set.getCount();
            int i = 0;
            for (uint x = 0; x < set.getCount(); x++)
                {
                SimObject obj = set.getObject(x);
                if (obj.isMethod("onEditorSelect"))
                    obj.call("onEditorSelect", count.AsString());

                i++;

                EditorTree.addSelection(obj, i == count);
                EditorGui.currentEditor.onObjectSelected(obj);
                }
            // Inform the camera
            console.commandToServer("EditorOrbitCameraSelectChange",
                new string[] {count.AsString(), getSelectionCentroid().AsString()});
            EditorGuiStatusBar.setSelectionObjectsByCount(getSelectionSize().AsString());

            // Update the Transform Selection window, if it is
            // visible.

            if (ETransformSelection.isVisible())
                ETransformSelection.onSelectionChanged();
            }

        [ConsoleInteraction]
        public void onUnSelect(SimObject obj)
            {
            EditorGui EditorGui = "EditorGui";
            Inspector Inspector = "Inspector";
            EditorTree EditorTree = "EditorTree";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ETransformSelection ETransformSelection = "ETransformSelection";

            if (obj.isObject() && obj.isMethod("onEditorUnselect"))
                obj.call("onEditorUnselect");

            EditorGui.currentEditor.onObjectDeselected(obj);

            Inspector.removeInspect(obj);
            EditorTree.removeSelection(obj);

            // Inform the camera
            console.commandToServer("EditorOrbitCameraSelectChange",
                new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});

            EditorGuiStatusBar.setSelectionObjectsByCount(getSelectionSize().AsString());

            // Update the Transform Selection window

            ETransformSelection.onSelectionChanged();
            }

        [ConsoleInteraction]
        public override void onClearSelection()
            {
            EditorGui EditorGui = "EditorGui";
            Inspector Inspector = "Inspector";
            EditorTree EditorTree = "EditorTree";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ETransformSelection ETransformSelection = "ETransformSelection";
            EditorGui.currentEditor.onSelectionCleared();
            EditorTree.clearSelection();

            // Inform the camera
            console.commandToServer("EditorOrbitCameraSelectChange",
                new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});

            EditorGuiStatusBar.setSelectionObjectsByCount(getSelectionSize().AsString());
            // Update the Transform Selection window

            ETransformSelection.onSelectionChanged();
            }

        [ConsoleInteraction]
        public override void onSelectionCentroidChanged()
            {
                Inspector Inspector = "Inspector";
            console.commandToServer("EditorOrbitCameraSelectChange",
                new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});
            // Refresh inspector.
            Inspector.refresh();
            }

        [ConsoleInteraction]
        public void init()
            {
            // add objclasses which we do not want to collide with
            this.ignoreObjClass("sky");

            // editing modes
            this["numEditModes"] = "3";
            this["editMode[0]"] = "move";
            this["editMode[1]"] = "rotate";
            this["editMode[2]"] = "scale";

            // context menu
            ObjectCreator oc = new ObjectCreator("GuiControl", "WEContextPopupDlg, EditorGuiGroup");
            oc["profile"] = "ToolsGuiModelessDialogProfile";
            oc["horizSizing"] = "width";
            oc["vertSizing"] = "height";
            oc["position"] = "0 0";
            oc["extent"] = "640 480";
            oc["minExtent"] = "8 8";
            oc["visible"] = "1";
            oc["setFirstResponder"] = "0";
            oc["modal"] = "1";

            ObjectCreator oc1 = new ObjectCreator("GuiPopUpMenuCtrl", "WEContextPopup");
            oc1["profile"] = "ToolsGuiScrollProfile";
            oc1["position"] = "0 0";
            oc1["extent"] = "0 0";
            oc1["minExtent"] = "0 0";
            oc1["maxPopupHeight"] = "200";
            oc1["command"] = "canvas.popDialog(WEContextPopupDlg);";

            oc["#1"] = oc1;
            oc.Create();

            ((GuiPopUpMenuCtrl) "WEContextPopup").setVisible(false);
            // Make sure we have an active selection set.

            if (!getActiveSelection().AsBool())
                {
                setActiveSelection(
                    new ObjectCreator("WorldEditorSelection", "EWorldEditorSelection").Create().AsString());
                }
            }

        [ConsoleInteraction]
        public virtual void onDblClick(SimObject obj)
            {
            }

        [ConsoleInteraction]
        public virtual void onClick(SimObject obj)
            {
                Inspector Inspector = "Inspector";
            Inspector.inspect(obj);
            }

        [ConsoleInteraction]
        public virtual void onEndDrag(SimObject obj)
            {
                Inspector Inspector = "Inspector";
            Inspector.inspect(obj);
            Inspector.apply();
            }

        [ConsoleInteraction]
        public virtual void export()
            {
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.SaveFileDialog.getSaveFilename("~/editor/*.mac|mac file", this + ".doExport", "selection.mac");
            }

        [ConsoleInteraction]
        public virtual void doExport(string file)
            {
            SimGroup missionGroup = "missionGroup";
            missionGroup.save("~editor/" + file, true, "");
            }

        [ConsoleInteraction]
        public virtual void import()
            {
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename("~/editor/*.mac|mac file", this + ".doImport", "");
            }

        [ConsoleInteraction]
        public virtual void doImport(string file)
            {
            Util.exec("~/editor/" + file, false, false);
            }

        [ConsoleInteraction]
        public override void onGuiUpdate(string text)
            {
            }

        [ConsoleInteraction]
        public virtual int getSelectionLockCount()
            {
            int ret = 0;
            for (int i = 0; i < getSelectionSize(); i++)
                {
                SimObject obj = this.getSelectedObject(i);
                if (obj.lockedx)
                    ret++;
                }
            return ret;
            }

        [ConsoleInteraction]
        public virtual int getSelectionHiddenCount()
            {
            int ret = 0;
            for (int i = 0; i < getSelectionSize(); i++)
                {
                SimObject obj = getSelectedObject(i);
                if (obj.hidden)
                    ret++;
                }
            return ret;
            }

        [ConsoleInteraction]
        public virtual void dropCameraToSelection()
            {
            if (this.getSelectionSize() == 0)
                return;

            Point3F pos = new Point3F(getSelectionCentroid());
            TransformF cam = ((Camera) ((GameConnection) "LocalClientConnection")["camera"]).getTransform();

            cam.mPositionX = pos.x;
            cam.mPositionY = pos.y;
            cam.mPositionZ = pos.z;

            ((Camera) ((GameConnection) "LocalClientConnection")["camera"]).setTransform(cam);
            }

        [ConsoleInteraction]
        public virtual void moveSelectionInPlace()
            {
            string saveDropType = this["dropType"];
            this["dropType"] = "atCentroid";
            this.copySelection();
            this.call("deleteSelection");
            this.pasteSelection();
            this["dropType"] = saveDropType;
            }

        [ConsoleInteraction]
        public virtual void addSelectionToAddGroup()
            {
            for (int i = 0; i < getSelectionSize(); i++)
                {
                SimObject obj = getSelectedObject(i);
                sGlobal["$InstantGroup"].call("add", new string[] {obj});
                }
            }

        [ConsoleInteraction]
        public virtual void resetTransforms()
            {
            addUndoState();

            for (int i = 0; i < getSelectionSize(); i++)
                {
                SceneObject obj = getSelectedObject(i);
                TransformF transform = obj.getTransform();
                transform.mOrientationX = 0;
                transform.mOrientationY = 0;
                transform.mOrientationZ = 0;
                transform.MAngle = 0;

                obj.setTransform(transform);
                obj.setScale(new Point3F(1, 1, 1));
                }
            }

        [ConsoleInteraction]
        public virtual void onAddSelected(SimObject obj)
            {
            ((EditorTree) "EditorTree").addSelection(obj, true);
            }

        [ConsoleInteraction]
        public virtual void onWorldEditorUndo()
            {
                ((Inspector)"Inspector").refresh();
            }
        }
    }