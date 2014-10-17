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

#region

using WinterLeaf.Demo.Full.Models.Base;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
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

            console.commandToServer("EditorOrbitCameraSelectChange", new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});

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
            console.commandToServer("EditorOrbitCameraSelectChange", new string[] {count.AsString(), getSelectionCentroid().AsString()});
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
            console.commandToServer("EditorOrbitCameraSelectChange", new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});

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
            console.commandToServer("EditorOrbitCameraSelectChange", new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});

            EditorGuiStatusBar.setSelectionObjectsByCount(getSelectionSize().AsString());
            // Update the Transform Selection window

            ETransformSelection.onSelectionChanged();
        }

        [ConsoleInteraction]
        public override void onSelectionCentroidChanged()
        {
            Inspector Inspector = "Inspector";
            console.commandToServer("EditorOrbitCameraSelectChange", new string[] {getSelectionSize().AsString(), getSelectionCentroid().AsString()});
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
                setActiveSelection(new ObjectCreator("WorldEditorSelection", "EWorldEditorSelection").Create().AsString());
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
            GameCode.Tools.Gui.SaveFileDialog.getSaveFilename("~/editor/*.mac|mac file", this + ".doExport", "selection.mac");
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
            GameCode.Tools.Gui.OpenFileDialog.getLoadFilename("~/editor/*.mac|mac file", this + ".doImport", "");
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
            ((Inspector) "Inspector").refresh();
        }
    }
}