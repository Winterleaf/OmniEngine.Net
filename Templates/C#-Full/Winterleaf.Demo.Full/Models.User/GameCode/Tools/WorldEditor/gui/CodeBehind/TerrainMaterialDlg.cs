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
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<TerrainMaterialDlg>))]
    public class TerrainMaterialDlg : GuiControl
    {
        internal int matIndex
        {
            get { return this["matIndex"].AsInt(); }
            set { this["matIndex"] = value.AsString(); }
        }

        internal string onApplyCallback
        {
            get { return this["onApplyCallback"]; }
            set { this["onApplyCallback"] = value; }
        }

        [ConsoleInteraction]
        public void show(int matIndex, string terrMat, string onApplyCallback)
        {
            ((GuiCanvas) "Canvas").pushDialog(this);
            this.matIndex = matIndex;
            this.onApplyCallback = onApplyCallback;

            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);
            int item = matLibTree.findItemByObjectId(terrMat.AsInt());
            if (item != -1)
                {
                matLibTree.selectItem(item);
                matLibTree.scrollVisible(item);
                }
            else
                {
                for (int i = 1; i < matLibTree.getItemCount(); i++)
                    {
                    SimObject oterrMat = matLibTree.getItemValue(i);
                    if (oterrMat.getClassName() == "TerrainMaterial")
                        {
                        matLibTree.selectItem(i, true);
                        matLibTree.scrollVisible(i);
                        break;
                        }
                    }
                }
        }

        [ConsoleInteraction]
        public void showByObjectID(string matObjectID, string onApplyCallback)
        {
            ((GuiCanvas) "canvas").pushDialog(this);
            matIndex = -1;
            this.onApplyCallback = onApplyCallback;
            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);
            matLibTree.clearSelection();
            int item = matLibTree.findItemByObjectId(matObjectID.AsInt());
            if (item == -1)
                {
                matLibTree.selectItem(item);
                matLibTree.scrollVisible(item);
                }
        }

        public override void onWake()
        {
            if (!"ETerrainMaterialPersistMan".isObject())
                new ObjectCreator("PersistenceManager", "ETerrainMaterialPersistMan").Create();

            if (!"TerrainMaterialDlgNewGroup".isObject())
                new ObjectCreator("SimGroup", "TerrainMaterialDlgNewGroup").Create();

            if (!"TerrainMaterialDlgDeleteGroup".isObject())
                new ObjectCreator("SimGroup", "TerrainMaterialDlgDeleteGroup").Create();

            // Snapshot the materials.
            this.snapshotMaterials();

            this.buildTree();

            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);
            //matLibTree.clear();

            //matLibTree.open("TerrainMaterialSet", false);
            matLibTree.buildVisibleTree(true);

            //int item = matLibTree.getFirstRootItem();
            matLibTree.expandItem(2);

            //matLibTree.selectItem(1);
            //activateMaterialCtrls(true);
        }

        public override void onSleep()
        {
            if ("TerrainMaterialDlgSnapshot".isObject())
                "TerrainMaterialDlgSnapshot".delete();
            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);
            matLibTree.clear();
        }

        [ConsoleInteraction]
        public void buildTree()
        {
            // Refresh the material list.
            GuiTreeViewCtrl matLibTree = FOT("matLibTree");
            matLibTree.clear();

            int root = matLibTree.insertItem(0, "RootMaterial", "RootMaterial", "");

            //TerrainPainterAddition
            SimSet TerrainMaterialSet = "TerrainMaterialSet";
            for (uint i = 0; i < TerrainMaterialSet.getCount(); i++)
                {
                TerrainMaterial mat = TerrainMaterialSet.getObject(i);
                if (!mat.isObject())
                    continue;

                string terrainFolderName = mat["terrainFolder"];
                if (terrainFolderName == "")
                    terrainFolderName = "Unused";

                int folder = matLibTree.findItemByName(terrainFolderName);
                if (folder == 0)
                    folder = matLibTree.insertItem(root, terrainFolderName, terrainFolderName, "");

                if (matLibTree.getParentItem(folder) == root)
                    matLibTree.insertObject(folder, mat, true);
                }
        }

        [ConsoleInteraction]
        public void setTerrainFolder(string terrainFolder)
        {
            TerrainMaterial mat = this["activeMat"];
            GuiTreeViewCtrl matLibTree = FOT("matLibTree");

            if (mat.isObject())
                {
                mat["terrainFolder"] = terrainFolder;
                matLibTree.buildVisibleTree(false);
                }
        }

        [ConsoleInteraction]
        public void dialogApply()
        {
            SimGroup TerrainMaterialDlgNewGroup = "TerrainMaterialDlgNewGroup";
            SimGroup TerrainMaterialDlgDeleteGroup = "TerrainMaterialDlgDeleteGroup";
            PersistenceManager ETerrainMaterialPersistMan = "ETerrainMaterialPersistMan";
            TerrainPainter TerrainPainter = "TerrainPainter";
            SimGroup RootGroup = "RootGroup";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            // Move all new materials we have created to the root group.
            int newCount = TerrainMaterialDlgNewGroup.getCount();
            for (uint i = 0; i < newCount; i++)
                RootGroup.add(TerrainMaterialDlgNewGroup.getObject(i));

            // Finalize deletion of all removed materials.
            int deletedCount = TerrainMaterialDlgDeleteGroup.getCount();
            for (uint i = 0; i < deletedCount; i++)
                {
                SimObject mat = TerrainMaterialDlgDeleteGroup.getObject(i);
                ETerrainMaterialPersistMan.removeObjectFromFile(mat);

                int _matIndex = ETerrainEditor.getMaterialIndex(mat.internalName);
                if (_matIndex != -1)
                    {
                    ETerrainEditor.removeMaterial(matIndex);
                    TerrainPainter.updateLayers("");
                    }
                mat.delete();
                }
            // Make sure we save any changes to the current selection.
            saveDirtyMaterial(this["activeMat"]);
            // Save all changes.
            ETerrainMaterialPersistMan.saveDirty();

            // Delete the snapshot.
            "TerrainMaterialDlgSnapshot".delete();

            ((GuiCanvas) "Canvas").popDialog(this);

            Util._call(onApplyCallback, this["activeMat"], this.matIndex.AsString());
        }

        [ConsoleInteraction]
        public void dialogCancel()
        {
            PersistenceManager ETerrainMaterialPersistMan = "ETerrainMaterialPersistMan";
            SimGroup TerrainMaterialDlgNewGroup = "TerrainMaterialDlgNewGroup";
            SimGroup TerrainMaterialDlgDeleteGroup = "TerrainMaterialDlgDeleteGroup";

            // Restore material properties we have changed.
            this.restoreMaterials();

            // Clear the persistence manager state.

            ETerrainMaterialPersistMan.clearAll();

            // Delete all new object we have created.

            TerrainMaterialDlgNewGroup.clear();

            // Restore materials we have marked for deletion.

            int deletedCount = TerrainMaterialDlgDeleteGroup.getCount();
            for (uint i = 0; i < deletedCount; i++)
                {
                SimObject mat = TerrainMaterialDlgDeleteGroup.getObject(i);
                mat.parentGroup = "RootGroup";

                ((SimSet) "TerrainMaterialSet").add(mat);
                }
            ((GuiCanvas) "Canvas").popDialog(this);
        }

        [ConsoleInteraction]
        public void setMaterialName(string newName)
        {
            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);
            SimObject mat = this["activeMat"];
            if (mat.internalName != newName)
                {
                SimObject existingMat = ((SimSet) "TerrainMaterialSet").findObjectByInternalName(newName, true);
                if (existingMat.isObject())
                    messageBox.MessageBoxOK("Error", "There already is a terrain material called '" + newName + "'.");
                else
                    {
                    mat.setInternalName(newName);
                    matLibTree.buildVisibleTree(false);
                    }
                }
        }

        [ConsoleInteraction]
        public void changeBase()
        {
            GuiBitmapCtrl ctrl = this.findObjectByInternalName("baseTexCtrl", true);
            string file = ctrl.bitmap;
            if (file.StartsWith("tools/"))
                file = "";

            file = _selectTextureFileDialog(file);
            if (file == "")
                {
                if (ctrl.bitmap != "")
                    file = ctrl.bitmap;
                else
                    file = "tools/materialeditor/gui/unknownImage";
                }

            file = Util.makeRelativePath(file, Util.getMainDotCsDir());
            ctrl.setBitmapX(file);
        }

        [ConsoleInteraction]
        public void changeDetail()
        {
            GuiBitmapCtrl ctrl = this.findObjectByInternalName("detailTexCtrl", true);
            string file = ctrl.bitmap;
            if (file.StartsWith("tools/"))
                file = "";

            file = _selectTextureFileDialog(file);
            if (file == "")
                {
                if (ctrl.bitmap != "")
                    file = ctrl.bitmap;
                else
                    file = "tools/materialeditor/gui/unknownImage";
                }

            file = Util.makeRelativePath(file, Util.getMainDotCsDir());
            ctrl.setBitmapX(file);
        }

        [ConsoleInteraction]
        public void changeMacro()
        {
            GuiBitmapCtrl ctrl = this.findObjectByInternalName("macroTexCtrl", true);
            string file = ctrl.bitmap;
            if (file.StartsWith("tools/"))
                file = "";
            file = _selectTextureFileDialog(file);

            if (file == "")
                {
                if (ctrl.bitmap != "")
                    file = ctrl.bitmap;
                else
                    file = "tools/materialeditor/gui/unknownImage";
                }
            file = Util.makeRelativePath(file, Util.getMainDotCsDir());
            ctrl.setBitmapX(file);
        }

        [ConsoleInteraction]
        public void changeNormal()
        {
            GuiBitmapCtrl ctrl = this.findObjectByInternalName("normTexCtrl", true);
            string file = ctrl.bitmap;
            if (file.StartsWith("tools/"))
                file = "";
            file = _selectTextureFileDialog(file);

            if (file == "")
                {
                if (ctrl.bitmap != "")
                    file = ctrl.bitmap;
                else
                    file = "tools/materialeditor/gui/unknownImage";
                }
            file = Util.makeRelativePath(file, Util.getMainDotCsDir());
            ctrl.setBitmapX(file);
        }

        [ConsoleInteraction]
        public void newMat()
        {
            // Create a unique material name.
            string matName = Util.getUniqueInternalName("newMaterial", "TerrainMaterialSet", true);
            // Create the new material.
            ObjectCreator oc = new ObjectCreator("TerrainMaterial");
            oc["internalName"] = matName;
            oc["parentGroup"] = "TerrainMaterialDlgNewGroup";

            TerrainMaterial newMat = oc.Create();

            newMat.setFilename("art/terrains/materials.cs");
            // Mark it as dirty and to be saved in the default location.
            PersistenceManager ETerrainMaterialPersistMan = "ETerrainMaterialPersistMan";
            ETerrainMaterialPersistMan.setDirty(newMat, "art/terrains/materials.cs");
            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);

            //TerrainPainterAddition
            int root = matLibTree.findItemByName("RootMaterial");

            int folder = matLibTree.findItemByName("Unused");
            if (folder == 0)
                folder = matLibTree.insertItem(root, "Unused", "Unused", "");
            matLibTree.insertObject(folder, newMat, true);

            matLibTree.buildVisibleTree(true);
            SimObject item = matLibTree.findItemByObjectId(newMat);
            matLibTree.selectItem(item);
        }

        [ConsoleInteraction]
        public void deleteMat()
        {
            SimSet TerrainMaterialSet = "TerrainMaterialSet";
            SimGroup TerrainMaterialDlgDeleteGroup = "TerrainMaterialDlgDeleteGroup";
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            if (!this["activeMat"].isObject())
                return;

            // Cannot delete this material if it is the only one left on the Terrain
            if ((ETerrainEditor.getMaterialCount() == 1) && ETerrainEditor.getMaterialIndex(((SimObject) this["activeMat"]).internalName) != -1)
                {
                messageBox.MessageBoxOK("Error", "Cannot delete this Material, it is the only Material still in use by the active Terrain.");
                return;
                }
            TerrainMaterialSet.remove(this["activeMat"]);
            TerrainMaterialDlgDeleteGroup.add(this["activeMat"]);
            GuiTreeViewCtrl matLibTree = this.findObjectByInternalName("matLibTree", true);
            buildTree();
            //matLibTree.open("TerrainMaterialSet", false);
            //matLibTree.selectItem(1);
        }

        [ConsoleInteraction]
        public void activateMaterialCtrls(bool active)
        {
            GuiContainer parent = this.findObjectByInternalName("matSettingsParent", true);
            int count = parent.getCount();
            for (uint i = 0; i < count; i++)
                ((GuiControl) parent.getObject(i)).setActive(active);
        }

        [ConsoleInteraction]
        public void onSelect(SimObject item)
        {
            if (item.GetType() == typeof (TerrainMaterial))
                setActiveMaterial(item.unSafeCast<TerrainMaterial>());
            else
                setActiveMaterial(0);
        }

        [ConsoleInteraction]
        public void onUnSelect(TerrainMaterial item)
        {
            saveDirtyMaterial(item);
            setActiveMaterial(0);
        }

        [ConsoleInteraction]
        public void setActiveMaterial(TerrainMaterial mat)
        {
            if (mat.isObject())
                {
                GuiTextEditCtrl matNameCtrl = this.findObjectByInternalName("matNameCtrl", true);
                GuiBitmapCtrl baseTexCtrl = this.findObjectByInternalName("baseTexCtrl", true);
                GuiBitmapCtrl detailTexCtrl = this.findObjectByInternalName("detailTexCtrl", true);
                GuiBitmapCtrl macroTexCtrl = this.findObjectByInternalName("macroTexCtrl", true);
                GuiBitmapCtrl normTexCtrl = this.findObjectByInternalName("normTexCtrl", true);
                GuiTextEditCtrl detSizeCtrl = this.findObjectByInternalName("detSizeCtrl", true);
                GuiTextEditCtrl baseSizeCtrl = this.findObjectByInternalName("baseSizeCtrl", true);
                GuiTextEditCtrl detStrengthCtrl = this.findObjectByInternalName("detStrengthCtrl", true);
                GuiTextEditCtrl detDistanceCtrl = this.findObjectByInternalName("detDistanceCtrl", true);
                GuiCheckBoxCtrl sideProjectionCtrl = this.findObjectByInternalName("sideProjectionCtrl", true);
                GuiTextEditCtrl parallaxScaleCtrl = this.findObjectByInternalName("parallaxScaleCtrl", true);

                GuiTextEditCtrl macroSizeCtrl = this.findObjectByInternalName("macroSizeCtrl", true);
                GuiTextEditCtrl macroStrengthCtrl = this.findObjectByInternalName("macroStrengthCtrl", true);
                GuiTextEditCtrl macroDistanceCtrl = this.findObjectByInternalName("macroDistanceCtrl", true);

                //TerrainPainterAddition
                GuiTextEditCtrl terrainFolderCtrl = FOT("terrainFolderCtrl");

                this["activeMat"] = mat;

                matNameCtrl.setText(mat.internalName);

                baseTexCtrl.setBitmapX(mat.diffuseMap == "" ? "tools/materialeditor/gui/unknownImage" : mat.diffuseMap);
                detailTexCtrl.setBitmapX(mat.detailMap == "" ? "tools/materialeditor/gui/unknownImage" : mat.detailMap);
                macroTexCtrl.setBitmapX(mat.macroMap == "" ? "tools/materialeditor/gui/unknownImage" : mat.macroMap);
                normTexCtrl.setBitmapX(mat.normalMap == "" ? "tools/materialeditor/gui/unknownImage" : mat.normalMap);

                detSizeCtrl.setText(mat.detailSize.AsString());
                baseSizeCtrl.setText(mat.diffuseSize.AsString());
                detStrengthCtrl.setText(mat.detailStrength.AsString());
                detDistanceCtrl.setText(mat.detailDistance.AsString());
                sideProjectionCtrl.setValue(mat.useSideProjection.AsString());
                parallaxScaleCtrl.setText(mat.parallaxScale.AsString());

                macroSizeCtrl.setText(mat.macroSize.AsString());
                macroStrengthCtrl.setText(mat.macroStrength.AsString());
                macroDistanceCtrl.setText(mat.macroDistance.AsString());

                //TerrainPainterAddition
                terrainFolderCtrl.setText(mat["terrainFolder"]);
                activateMaterialCtrls(true);
                }
            else
                {
                this["activeMat"] = "0";
                activateMaterialCtrls(false);
                }
        }

        [ConsoleInteraction]
        public void saveDirtyMaterial(TerrainMaterial mat)
        {
            // Skip over obviously bad cases.
            if (!mat.isObject())
                return;

            GuiTextEditCtrl matNameCtrl = this.findObjectByInternalName("matNameCtrl", true);
            GuiBitmapCtrl baseTexCtrl = this.findObjectByInternalName("baseTexCtrl", true);
            GuiBitmapCtrl detailTexCtrl = this.findObjectByInternalName("detailTexCtrl", true);
            GuiBitmapCtrl macroTexCtrl = this.findObjectByInternalName("macroTexCtrl", true);
            GuiBitmapCtrl normTexCtrl = this.findObjectByInternalName("normTexCtrl", true);
            GuiTextEditCtrl detSizeCtrl = this.findObjectByInternalName("detSizeCtrl", true);
            GuiTextEditCtrl baseSizeCtrl = this.findObjectByInternalName("baseSizeCtrl", true);
            GuiTextEditCtrl detStrengthCtrl = this.findObjectByInternalName("detStrengthCtrl", true);
            GuiTextEditCtrl detDistanceCtrl = this.findObjectByInternalName("detDistanceCtrl", true);
            GuiCheckBoxCtrl sideProjectionCtrl = this.findObjectByInternalName("sideProjectionCtrl", true);
            GuiTextEditCtrl parallaxScaleCtrl = this.findObjectByInternalName("parallaxScaleCtrl", true);

            GuiTextEditCtrl macroSizeCtrl = this.findObjectByInternalName("macroSizeCtrl", true);
            GuiTextEditCtrl macroStrengthCtrl = this.findObjectByInternalName("macroStrengthCtrl", true);
            GuiTextEditCtrl macroDistanceCtrl = this.findObjectByInternalName("macroDistanceCtrl", true);

            //TerrainPainterAddition
            GuiTextEditCtrl terrainFolderCtrl = FOT("terrainFolderCtrl");

            // Read out properties from the dialog.
            string newDiffuse = "";
            string newNormal = "";
            string newDetail = "";
            string newMacro = "";

            string newName = matNameCtrl.getText();

            if (baseTexCtrl.bitmap != "tools/materialeditor/gui/unknownImage")
                newDiffuse = baseTexCtrl.bitmap;

            if (normTexCtrl.bitmap != "tools/materialeditor/gui/unknownImage")
                newNormal = normTexCtrl.bitmap;

            if (detailTexCtrl.bitmap != "tools/materialeditor/gui/unknownImage")
                newDetail = detailTexCtrl.bitmap;

            if (macroTexCtrl.bitmap != "tools/materialeditor/gui/unknownImage")
                newMacro = macroTexCtrl.bitmap;

            string detailSize = detSizeCtrl.getText();
            string diffuseSize = baseSizeCtrl.getText();
            string detailStrength = detStrengthCtrl.getText();
            string detailDistance = detDistanceCtrl.getText();
            string useSideProjection = sideProjectionCtrl.getValue();
            string parallaxScale = parallaxScaleCtrl.getText();

            string macroSize = macroSizeCtrl.getText();
            string macroStrength = macroStrengthCtrl.getText();
            string macroDistance = macroDistanceCtrl.getText();

            string terrainFolder = terrainFolderCtrl.getText();

            if (mat.internalName == newName && mat.diffuseMap == newDiffuse && mat.normalMap == newNormal && mat.detailMap == newDetail && mat["macroMap"] == newMacro && mat["detailSize"] == detailSize && mat["diffuseSize"] == diffuseSize && mat["detailStrength"] == detailStrength && mat["detailDistance"] == detailDistance && mat["useSideProjection"] == useSideProjection && mat["macroSize"] == macroSize && mat["macroStrength"] == macroStrength && mat["macroDistance"] == macroDistance && mat.parallaxScale.AsString() == parallaxScale && mat["terrainFolder"] == terrainFolder)
                return;

            // Make sure the material name is unique.
            if (mat.internalName != newName)
                {
                TerrainMaterial existingMat = ((SimSet) "TerrainMaterialSet").findObjectByInternalName(newName, true);
                if (existingMat.isObject())
                    {
                    messageBox.MessageBoxOK("Error", "There already is a terrain material called '" + newName + "'.");
                    // Reset the name edit control to the old name.
                    matNameCtrl.setText(mat.internalName);
                    }
                else
                    mat.setInternalName(newName);
                }
            mat["diffuseMap"] = newDiffuse;
            mat["normalMap"] = newNormal;
            mat["detailMap"] = newDetail;
            mat["macroMap"] = newMacro;
            mat["detailSize"] = detailSize;
            mat["diffuseSize"] = diffuseSize;
            mat["detailStrength"] = detailStrength;
            mat["detailDistance"] = detailDistance;
            mat["macroSize"] = macroSize;
            mat["macroStrength"] = macroStrength;
            mat["macroDistance"] = macroDistance;
            mat["useSideProjection"] = useSideProjection;
            mat["parallaxScale"] = parallaxScale;

            //TerrainPainterAddition
            mat["terrainFolder"] = terrainFolder;

            // Mark the material as dirty and needing saving.

            string fileName = mat.getFilename();
            if (fileName == "")
                fileName = "art/terrains/materials.cs";

            PersistenceManager ETerrainMaterialPersistMan = "ETerrainMaterialPersistMan";
            ETerrainMaterialPersistMan.setDirty(mat, fileName);
        }

        [ConsoleInteraction]
        public void snapshotMaterials()
        {
            if (!"TerrainMaterialDlgSnapshot".isObject())
                new ObjectCreator("SimGroup", "TerrainMaterialDlgSnapshot").Create();

            SimGroup group = "TerrainMaterialDlgSnapshot";
            SimSet TerrainMaterialSet = "TerrainMaterialSet";
            group.clear();

            int matCount = TerrainMaterialSet.getCount();
            for (uint i = 0; i < matCount; i++)
                {
                TerrainMaterial mat = TerrainMaterialSet.getObject(i);
                if (!mat.isMemberOfClass("TerrainMaterial"))
                    continue;

                ObjectCreator oc = new ObjectCreator("ScriptObject");
                oc["parentGroup"] = group.ID;
                oc["material"] = mat;
                oc["internalName"] = mat["internalName"];
                oc["diffuseMap"] = mat["diffuseMap"];
                oc["normalMap"] = mat["normalMap"];
                oc["detailMap"] = mat["detailMap"];
                oc["macroMap"] = mat["macroMap"];
                oc["detailSize"] = mat["detailSize"];
                oc["diffuseSize"] = mat["diffuseSize"];
                oc["detailStrength"] = mat["detailStrength"];
                oc["detailDistance"] = mat["detailDistance"];
                oc["macroSize"] = mat["macroSize"];
                oc["macroStrength"] = mat["macroStrength"];
                oc["macroDistance"] = mat["macroDistance"];
                oc["useSideProjection"] = mat["useSideProjection"];
                oc["parallaxScale"] = mat["parallaxScale"];
                oc.Create();
                }
        }

        [ConsoleInteraction]
        public void restoreMaterials()
        {
            if (!"TerrainMaterialDlgSnapshot".isObject())
                {
                Util._error("TerrainMaterial::restoreMaterials - no snapshot present");
                return;
                }

            SimGroup TerrainMaterialDlgSnapshot = "TerrainMaterialDlgSnapshot";

            int count = TerrainMaterialDlgSnapshot.getCount();
            for (uint i = 0; i < count; i++)
                {
                ScriptObject obj = TerrainMaterialDlgSnapshot.getObject(i);

                TerrainMaterial mat = obj["material"];
                mat.setInternalName(obj.internalName);
                mat.diffuseMap = obj["diffuseMap"];
                mat.normalMap = obj["normalMap"];
                mat.detailMap = obj["detailMap"];
                mat.macroMap = obj["macroMap"];
                mat["detailSize"] = obj["detailSize"];
                mat["diffuseSize"] = obj["diffuseSize"];
                mat["detailStrength"] = obj["detailStrength"];
                mat["detailDistance"] = obj["detailDistance"];
                mat["macroSize"] = obj["macroSize"];
                mat["macroStrength"] = obj["macroStrength"];
                mat["macroDistance"] = obj["macroDistance"];
                mat["useSideProjection"] = obj["useSideProjection"];
                mat["parallaxScale"] = obj["parallaxScale"];
                }
        }

        [ConsoleInteraction]
        public string _selectTextureFileDialog(string defaultFileName)
        {
            if (sGlobal["$Pref::TerrainEditor::LastPath"] == "")
                sGlobal["$Pref::TerrainEditor::LastPath"] = "art/terrains";

            OpenFileDialog ofd = new OpenFileDialog {InitialDirectory = sGlobal["$Pref::TerrainEditor::LastPath"], Filter = sGlobal["$TerrainEditor::TextureFileSpec"], FileName = defaultFileName, CheckFileExists = true, Multiselect = false};

            string file = "";

            DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

            switch (dr)
                {
                    case DialogResult.Abort:
                    case DialogResult.Ignore:
                    case DialogResult.No:
                    case DialogResult.Cancel:
                    case DialogResult.None:
                        return "";
                    case DialogResult.OK:
                        file = Dialogs.GetForwardSlashFile(ofd.FileName);
                        sGlobal["$Pref::TerrainEditor::LastPath"] = Util.filePath(file);
                        break;
                }

            file = Util.filePath(file) + "/" + Util.fileBase(file);

            return file;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainMaterialDlg ts, string simobjectid)
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
        public static bool operator !=(TerrainMaterialDlg ts, string simobjectid)
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
        public static implicit operator string(TerrainMaterialDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainMaterialDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TerrainMaterialDlg) Omni.self.getSimObject(simobjectid, typeof (TerrainMaterialDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainMaterialDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainMaterialDlg(int simobjectid)
        {
            return (TerrainMaterialDlg) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainMaterialDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainMaterialDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainMaterialDlg(uint simobjectid)
        {
            return (TerrainMaterialDlg) Omni.self.getSimObject(simobjectid, typeof (TerrainMaterialDlg));
        }

        #endregion
    }
}