﻿// WinterLeaf Entertainment
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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using SaveFileDialog = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.SaveFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorPlugin>))]
    public class DatablockEditorPlugin : WorldEditorPlugin
    {
        internal ActionMap map
        {
            get { return this["map"]; }
            set { this["map"] = value; }
        }

        internal PersistenceManager PM
        {
            get { return this["PM"]; }
            set { this["PM"] = value; }
        }

        [ConsoleInteraction]
        public void initialize()
        {
            this.PM = new ObjectCreator("PersistenceManager").Create();

            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "backspace", "DatablockEditorPlugin.onDeleteKey();", "");
            map.bindCmd("keyboard", "delete", "DatablockEditorPlugin.onDeleteKey();", "");
            this.map = map;

            this.initSettings();
        }

        public void init()
        {
            if (!((GuiTreeViewCtrl) "DatablockEditorTree").getItemCount().AsBool())
                this.populateTrees();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
        {
            EditorGui EditorGui = "EditorGui";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Datablock Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Datablock Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("DatablockEditorPlugin", "DatablockEditorPalette", Util._expandFilename("tools/worldEditor/images/toolbar/datablock-editor"), tooltip);

            //connect editor windows
            ((GuiWindowCollapseCtrl) "DatablockEditorInspectorWindow").attachTo("DatablockEditorTreeWindow");
        }

        //---------------------------------------------------------------------------------------------

        public override void onActivated()
        {
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl DatablockEditorTreeWindow = "DatablockEditorTreeWindow";
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            Extendable.WorldEditor EWorldEditor = "EWorldEditor";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            ((GuiControl) EditorGui.findObjectByInternalName("WorldEditorToolbar", true)).setVisible(false);
            EditorGui.bringToFront("DatablockEditorPlugin");

            DatablockEditorTreeWindow.setVisible(true);
            DatablockEditorInspectorWindow.setVisible(true);
            DatablockEditorInspectorWindow.makeFirstResponder(true);

            this.map.push();

            // Set the status bar here until all tool have been hooked up
            EditorGuiStatusBar.setInfo("Datablock editor.");

            int numSelected = this.getNumSelectedDatablocks();
            if (numSelected == 0)
                EditorGuiStatusBar.setSelection("");
            else
                EditorGuiStatusBar.setSelection(numSelected + " datablocks selected");

            this.init();
            this.readSettings();

            if (EWorldEditor.getSelectionSize() == 1)
                this.onObjectSelected(EWorldEditor.getSelectedObject(0));

            base.onActivated();
        }

        //---------------------------------------------------------------------------------------------

        public override void onDeactivated()
        {
            GuiWindowCollapseCtrl DatablockEditorTreeWindow = "DatablockEditorTreeWindow";
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            this.writeSettings();

            DatablockEditorInspectorWindow.setVisible(false);
            DatablockEditorTreeWindow.setVisible(false);
            this.map.pop();

            base.onDeactivated();
        }

        //---------------------------------------------------------------------------------------------

        public override void onExitMission()
        {
            ((GuiTreeViewCtrl) "DatablockEditorTree").clear();
            ((GuiInspector) "DatablockEditorInspector").inspect("");
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void openDatablock(string datablock)
        {
            EditorGui EditorGui = "EditorGui";

            EditorGui.setEditor("DatablockEditorPlugin", false);
            this.selectDatablock(datablock);
            ((GuiTabBookCtrl) "DatablockEditorTreeTabBook")["selectedPage"] = "0";
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override bool? setEditorFunction(string overrideGroup = "")
        {
            return true;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onObjectSelected(SimObject obj)
        {
            // Select datablock of object if this is a GameBase object.

            if (obj.isMemberOfClass("GameBase"))
                this.selectDatablock(obj.getDataBlock());
            else if (obj.isMemberOfClass("SFXEmitter") && obj["track"].isObject())
                this.selectDatablock(obj["track"].AsString());
            else if (obj.isMemberOfClass("LightBase") && obj["animationType"].isObject())
                this.selectDatablock(obj["animationType"].AsString());
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void populateTrees()
        {
            GuiTreeViewCtrl DatablockEditorTree = "DatablockEditorTree";
            GuiTreeViewCtrl DatablockEditorTypeTree = "DatablockEditorTypeTree";
            SimSet set;

            // Populate datablock tree.
            if (this["excludeClientOnlyDatablocks"].AsBool())
                set = "DataBlockGroup";
            else
                set = "DataBlockSet";

            DatablockEditorTree.clear();

            int count = set.getCount();
            for (uint i = 0; i < count; i++)
                {
                bool unlistedFound = false;
                string datablock = set.getObject(i);
                int id = datablock.getID();

                int anotherCount = ((SimSet) "UnlistedDatablocks").getCount();
                for (uint j = 0; j < anotherCount; j++)
                    {
                    if (((SimSet) "UnlistedDatablocks").getObject(j) == datablock)
                        {
                        unlistedFound = true;
                        break;
                        }
                    }
                if (unlistedFound)
                    continue;

                this.addExistingItem(datablock, true);
                }

            DatablockEditorTree.sort(0, true, false, false);

            // Populate datablock type tree.

            string classList = Util.enumerateConsoleClasses("SimDatablock");
            DatablockEditorTypeTree.clear();

            foreach (string datablockClass in classList.Split('\t'))
                {
                if (!this.isExcludedDatablockType(datablockClass) && DatablockEditorTypeTree.findItemByName(datablockClass) == 0)
                    DatablockEditorTypeTree.insertItem(0, datablockClass, "", "", 0, 0);
                }

            DatablockEditorTypeTree.sort(0, false, false, false);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public int addExistingItem(SimObject datablock, bool dontSort)
        {
            GuiTreeViewCtrl tree = "DatablockEditorTree";

            // Look up class at root level.  Create if needed.

            string className = datablock.getClassName();
            int parentID = tree.findItemByName(className);
            if (parentID == 0)
                parentID = tree.insertItem(0, className, "", "", 0, 0);

            // If the datablock is already there, don't
            // do anything.

            if (tree.findItemByValue(datablock.getId().AsString()).AsBool())
                return 0;

            // It doesn't exist so add it.

            string name = datablock.getName();
            if (this.PM.isDirty(datablock))
                name = name + " *";

            int id = tree.insertItem(parentID, name, datablock.getId().AsString(), "", 0, 0);
            if (!dontSort)
                tree.sort(parentID, false, false, false);

            return id;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public bool isExcludedDatablockType(string className)
        {
            switch (className)
                {
                    case "SimDatablock":
                        return true;
                    case "SFXTrack": // Abstract.
                        return true;
                    case "SFXFMODEvent": // Internally created.
                        return true;
                    case "SFXFMODEventGroup": // Internally created.
                        return true;
                }
            return false;
        }

        //=============================================================================================
        //    Settings.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("DatablockEditor", true);

            EditorSettings.setDefaultValue("libraryTab", "0");

            EditorSettings.endGroup();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiTabBookCtrl DatablockEditorTreeTabBook = "DatablockEditorTreeTabBook";

            EditorSettings.beginGroup("DatablockEditor", true);

            DatablockEditorTreeTabBook.selectPage(EditorSettings.value("libraryTab").AsInt());
            SimObject db = EditorSettings.value("selectedDatablock");
            if (db.isObject() && db.isMemberOfClass("SimDatablock"))
                this.selectDatablock(db);

            EditorSettings.endGroup();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void writeSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiTabBookCtrl DatablockEditorTreeTabBook = "DatablockEditorTreeTabBook";

            EditorSettings.beginGroup("DatablockEditor", true);

            EditorSettings.setValue("libraryTab", DatablockEditorTreeTabBook.getSelectedPage().AsString());
            if (this.getNumSelectedDatablocks() > 0)
                EditorSettings.setValue("selectedDatablock", this.getSelectedDatablock().getName());

            EditorSettings.endGroup();
        }

        //=============================================================================================
        //    Persistence.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override bool isDirty()
        {
            return this.PM.hasDirty();
        }

        //---------------------------------------------------------------------------------------------

        /// Return true if any of the currently selected datablocks has unsaved changes.
        [ConsoleInteraction]
        public bool selectedDatablockIsDirty()
        {
            GuiTreeViewCtrl tree = "DatablockEditorTree";

            int count = tree.getSelectedItemsCount();
            string selected = tree.getSelectedItemList();

            foreach (string id in selected.Split(' '))
                {
                string db = tree.getItemValue(id.AsInt());
                if (this.PM.isDirty(db))
                    return true;
                }

            return false;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void syncDirtyState()
        {
            GuiTreeViewCtrl tree = "DatablockEditorTree";

            int count = tree.getSelectedItemsCount();
            string selected = tree.getSelectedItemList();
            bool haveDirty = false;

            foreach (string id in selected.Split(' '))
                {
                if (id.Trim() == "")
                    continue;
                string db = tree.getItemValue(id.AsInt());
                if (this.PM.isDirty(db))
                    {
                    this.flagDatablockAsDirty(db, true);
                    haveDirty = true;
                    }
                else
                    this.flagDatablockAsDirty(db, false);
                }

            this.flagInspectorAsDirty(haveDirty);
        }

        //---------------------------------------------------------------------------------------------

        ///
        [ConsoleInteraction]
        public void flagInspectorAsDirty(bool dirty)
        {
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            if (dirty)
                DatablockEditorInspectorWindow["text"] = "Datablock *";
            else
                DatablockEditorInspectorWindow["text"] = "Datablock";
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void flagDatablockAsDirty(SimObject datablock, bool dirty)
        {
            GuiTreeViewCtrl tree = "DatablockEditorTree";

            int id = tree.findItemByValue(datablock.getId().AsString());
            if (id == 0)
                return;

            // Tag the item caption and sync the persistence manager.

            if (dirty)
                {
                tree.editItem(id, datablock.getName() + " *", datablock.getId().AsString());
                this.PM.setDirty(datablock);
                }
            else
                {
                tree.editItem(id, datablock.getName(), datablock.getId().AsString());
                this.PM.removeDirty(datablock);
                }

            // Sync the inspector dirty state.

            this.flagInspectorAsDirty(this.PM.hasDirty());
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void showSaveNewFileDialog()
        {
            string currentFile = ((SimObject) this.getSelectedDatablock()).getFilename();
            SaveFileDialog.getSaveFilename("TorqueScript Files|*.cs|All Files|*.*", +this + ".saveNewFileFinish", currentFile, false);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void saveNewFileFinish(string newFileName)
        {
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";

            // Clear the first responder to capture any inspector changes
            GuiControl ctrl = ((GuiCanvas) "canvas").getFirstResponder();
            if (ctrl.isObject())
                ctrl.clearFirstResponder(false);

            GuiTreeViewCtrl tree = "DatablockEditorTree";
            int count = tree.getSelectedItemsCount();
            string selected = tree.getSelectedItemList();

            foreach (string id in selected.Split(' '))
                {
                //TODO
                SimObject db = tree.getItemValue(id.AsInt());
                //db = this.getSelectedDatablock();

                // Remove from current file.

                string oldFileName = db.getFilename();
                if (oldFileName != "")
                    this.PM.removeObjectFromFile(db, oldFileName);

                // Save to new file.

                this.PM.setDirty(db, newFileName);
                if (this.PM.saveDirtyObject(db))
                    {
                    // Clear dirty state.

                    this.flagDatablockAsDirty(db, false);
                    }
                }

            ((GuiTextEditCtrl) DatablockEditorInspectorWindow.findObjectByInternalName("DatablockFile", true)).setText(newFileName);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void save()
        {
            // Clear the first responder to capture any inspector changes
            GuiControl ctrl = ((GuiCanvas) "canvas").getFirstResponder();
            if (ctrl.isObject())
                ctrl.clearFirstResponder(false);

            GuiTreeViewCtrl tree = "DatablockEditorTree";
            string selected = tree.getSelectedItemList();

            foreach (string id in selected.Split(' '))
                {
                string db = tree.getItemValue(id.AsInt());
                if (this.PM.isDirty(db))
                    {
                    this.PM.saveDirtyObject(db);
                    this.flagDatablockAsDirty(db, false);
                    }
                }
        }

        //=============================================================================================
        //    Selection.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public int getNumSelectedDatablocks()
        {
            return ((GuiTreeViewCtrl) "DatablockEditorTree").getSelectedItemsCount();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public string getSelectedDatablock(string index = "")
        {
            GuiTreeViewCtrl tree = "DatablockEditorTree";
            if (tree.getSelectedItemsCount() == 0)
                return "0";

            int id;
            if (index == "")
                id = tree.getSelectedItem();
            else
                id = (int) (tree.getSelectedItemList().Split(' ')).GetValue(index.AsInt());

            return tree.getItemValue(id);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void resetSelectedDatablock()
        {
            GuiTreeViewCtrl DatablockEditorTree = "DatablockEditorTree";
            DatablockEditor.DatablockEditorInspector DatablockEditorInspector = "DatablockEditorInspector";
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

            DatablockEditorTree.clearSelection();
            DatablockEditorInspector.inspect("0");
            ((GuiTextEditCtrl) DatablockEditorInspectorWindow.findObjectByInternalName("DatablockFile", true)).setText("");

            EditorGuiStatusBar.setSelection("");
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void selectDatablockCheck(string datablock)
        {
            if (this.selectedDatablockIsDirty())
                this.showSaveNewFileDialog();
            else
                this.selectDatablock(datablock);
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void selectDatablock(SimObject datablock, bool add = false, bool dontSyncTree = false)
        {
            GuiTreeViewCtrl DatablockEditorTree = "DatablockEditorTree";
            GuiInspector DatablockEditorInspector = "DatablockEditorInspector";
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

            if (add)
                DatablockEditorInspector.addInspect(datablock);
            else
                DatablockEditorInspector.inspect(datablock);

            if (!dontSyncTree)
                {
                int id = DatablockEditorTree.findItemByValue(datablock);

                if (!add)
                    DatablockEditorTree.clearSelection();

                DatablockEditorTree.selectItem(id, true);
                DatablockEditorTree.scrollVisible(id);
                }

            this.syncDirtyState();

            // Update the filename text field.

            int numSelected = this.getNumSelectedDatablocks();
            GuiTextEditCtrl fileNameField = DatablockEditorInspectorWindow.findObjectByInternalName("DatablockFile", true);

            if (numSelected == 1)
                {
                string fileName = datablock.getFilename();
                fileNameField.setText(fileName != "" ? fileName : sGlobal["$DATABLOCK_EDITOR_DEFAULT_FILENAME"]);
                }
            else
                fileNameField.setText("");

            EditorGuiStatusBar.setSelection(this.getNumSelectedDatablocks() + " Datablocks Selected");
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void unselectDatablock(string datablock, bool dontSyncTree)
        {
            GuiTreeViewCtrl DatablockEditorTree = "DatablockEditorTree";
            GuiInspector DatablockEditorInspector = "DatablockEditorInspector";
            GuiWindowCollapseCtrl DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

            DatablockEditorInspector.removeInspect(datablock);

            if (!dontSyncTree)
                {
                int id = DatablockEditorTree.findItemByValue(datablock.getID().AsString());
                DatablockEditorTree.selectItem(id, false);
                }

            this.syncDirtyState();

            // If we have exactly one selected datablock remaining, re-enable
            // the save-as button.

            int numSelected = this.getNumSelectedDatablocks();
            if (numSelected == 1)
                {
                ((GuiBitmapButtonCtrl) DatablockEditorInspectorWindow.findObjectByInternalName("saveAsButton", true)).setActive(true);

                GuiTextEditCtrl fileNameField = DatablockEditorInspectorWindow.findObjectByInternalName("DatablockFile", true);
                fileNameField.setText(((SimObject) this.getSelectedDatablock()).getFilename());
                fileNameField.setActive(true);
                }

            EditorGuiStatusBar.setSelection(this.getNumSelectedDatablocks() + " Datablocks Selected");
        }

        //=============================================================================================
        //    Creation and Deletion.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void deleteDatablock()
        {
            GuiTreeViewCtrl tree = "DatablockEditorTree";
            editor Editor = "Editor";

            // If we have more than single datablock selected,
            // turn our undos into a compound undo.

            int numSelected = tree.getSelectedItemsCount();
            if (numSelected > 1)
                Editor.getUndoManager().pushCompound("Delete Multiple Datablocks");

            for (int i = 0; i < numSelected; i++)
                {
                int id = tree.getSelectedItem(i);
                SimObject db = tree.getItemValue(id);

                string fileName = db.getFilename();

                // Remove the datablock from the tree.

                tree.removeItem(id);

                // Create undo.

                UndoScriptAction action = this.createUndo<DatablockEditorUndo.ActionDeleteDatablock>("Delete Datablock");
                action["db"] = db;
                action["dbName"] = db.getName();
                action["fname"] = fileName;

                this.submitUndo(action);

                // Kill the datablock in the file.

                if (fileName != "")
                    this.PM.removeObjectFromFile(db);

                ((SimSet) "UnlistedDatablocks").add(db);

                // Show some confirmation.

                if (numSelected == 1)
                    messageBox.MessageBoxOK("Datablock Deleted", "The datablock (" + db.getName() + ") has been removed from " + "it's file (" + db.getFilename() + ") and upon restart will cease to exist");
                }

            // Close compound, if we were deleting multiple datablocks.

            if (numSelected > 1)
                Editor.getUndoManager().popCompound();

            // Show confirmation for multiple datablocks.

            if (numSelected > 1)
                messageBox.MessageBoxOK("Datablocks Deleted", "The datablocks have been deleted and upon restart will cease to exist.");

            // Clear selection.

            this.resetSelectedDatablock();
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void createDatablock()
        {
            GuiTreeViewCtrl DatablockEditorTypeTree = "DatablockEditorTypeTree";
            GuiControl DatablockEditorCreatePrompt = "DatablockEditorCreatePrompt";

            string className = DatablockEditorTypeTree.getItemText(DatablockEditorTypeTree.getSelectedItem());
            if (className != "")
                {
                // Need to prompt for a name.

                ((GuiTextEditCtrl) DatablockEditorCreatePrompt.findObjectByInternalName("CreateDatablockName", true)).setText("Name");
                ((GuiTextEditCtrl) DatablockEditorCreatePrompt.findObjectByInternalName("CreateDatablockName", true)).selectAllText();

                // Populate the copy source dropdown.

                GuiPopUpMenuCtrl list = DatablockEditorCreatePrompt.findObjectByInternalName("CopySourceDropdown", true);
                list.clear();
                list.add("", 0);

                SimSet set = "DataBlockSet";
                int count = set.getCount();
                for (uint i = 0; i < count; i++)
                    {
                    SimObject datablock = set.getObject(i);
                    string datablockClass = datablock.getClassName();

                    if (!Util.isMemberOfClass(datablockClass, className))
                        continue;

                    list.add(datablock.getName(), ((int) i + 1));
                    }

                // Set up state of client-side checkbox.

                GuiCheckBoxCtrl clientSideCheckBox = DatablockEditorCreatePrompt.findObjectByInternalName("ClientSideCheckBox", true);
                bool canBeClientSide = this.canBeClientSideDatablock(className);
                clientSideCheckBox.setStateOn(canBeClientSide);
                clientSideCheckBox.setActive(canBeClientSide);

                // Show the dialog.

                ((GuiCanvas) "canvas").pushDialog(DatablockEditorCreatePrompt, 0, true);
                }
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void createPromptNameCheck()
        {
            GuiControl DatablockEditorCreatePrompt = "DatablockEditorCreatePrompt";
            editor Editor = "Editor";
            GuiPopUpMenuCtrl copySourceDropdown = DatablockEditorCreatePrompt.findObjectByInternalName("copySourceDropdown", true);

            string name = ((GuiTextEditCtrl) DatablockEditorCreatePrompt.findObjectByInternalName("CreateDatablockName", true)).getText();
            if (!Editor.validateObjectName(name, true))
                return;

            // Fetch the copy source and clear the list.

            string copySource = copySourceDropdown.getText();
            copySourceDropdown.clear();

            // Remove the dialog and create the datablock.

            ((GuiCanvas) "canvas").popDialog(DatablockEditorCreatePrompt);
            this.createDatablockFinish(name, copySource);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void createDatablockFinish(string name, string copySource)
        {
            GuiTreeViewCtrl DatablockEditorTypeTree = "DatablockEditorTypeTree";
            GuiControl DatablockEditorCreatePrompt = "DatablockEditorCreatePrompt";

            string className = DatablockEditorTypeTree.getItemText(DatablockEditorTypeTree.getSelectedItem());
            if (className != "")
                {
                UndoScriptAction action = this.createUndo<DatablockEditorUndo.ActionCreateDatablock>("Create New Datablock");
                string dbType;

                if (((GuiCheckBoxCtrl) DatablockEditorCreatePrompt.findObjectByInternalName("ClientSideCheckBox", true)).isStateOn())
                    dbType = "singleton ";
                else
                    dbType = "datablock ";

                string eval;
                if (copySource != "")
                    eval = dbType + className + "(" + name + " : " + copySource + ") { canSaveDynamicFields = \"1\"; };";
                else
                    eval = dbType + className + "(" + name + ") { canSaveDynamicFields = \"1\"; };";

                string res = Util.eval(eval);

                action["db"] = name.getID().AsString();
                action["dbName"] = name;
                action["fname"] = sGlobal["$DATABLOCK_EDITOR_DEFAULT_FILENAME"];

                this.submitUndo(action);

                action.redo();
                }
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public bool canBeClientSideDatablock(string className)
        {
            switch (className)
                {
                    case "SFXProfile":
                    case "SFXPlayList":
                    case "SFXAmbience":
                    case "SFXEnvironment":
                    case "SFXState":
                    case "SFXDescription":
                    case "SFXFMODProject":
                        return true;

                    default:
                        return false;
                }
        }

        //---------------------------------------------------------------------------------------------

        // [ConsoleInteraction]
        public string createUndo<T>(string desc)
        {
            Util.pushInstantGroup();
            ObjectCreator ocf = new ObjectCreator("UndoScriptAction", "", typeof (T));

            //ocf["class"] = className;
            ocf["superClass"] = "BaseDatablockEdAction";
            ocf["actionName"] = desc;
            ocf["editor"] = "DatablockEditorPlugin";
            ocf["treeview"] = "DatablockEditorTree";
            ocf["inspector"] = "DatablockEditorInspector";

            UndoScriptAction action = ocf.Create();

            Util.popInstantGroup();
            return action;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void submitUndo(UndoScriptAction action)
        {
            editor Editor = "Editor";

            action.addToManager(Editor.getUndoManager());
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DatablockEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(DatablockEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(DatablockEditorPlugin ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DatablockEditorPlugin(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DatablockEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DatablockEditorPlugin ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DatablockEditorPlugin(int simobjectid)
        {
            return (DatablockEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorPlugin));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DatablockEditorPlugin ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DatablockEditorPlugin(uint simobjectid)
        {
            return (DatablockEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorPlugin));
        }

        #endregion
    }
}