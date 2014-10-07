using System.Collections.Generic;
using System.ComponentModel;
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
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditCanvas>))]
    public class GuiEditCanvas : GuiControl
        {
        internal MenuBar menuBar
            {
            get { return this["menuBar"]; }
            set { this["menuBar"] = value; }
            }

        [ConsoleInteraction]
        public override void onAdd()
            {
            // this.setWindowTitle("Torque Gui Editor");
            iGlobal["$GUI_EDITOR_MENU_EDGESNAP_INDEX"] = 0;
            iGlobal["$GUI_EDITOR_MENU_CENTERSNAP_INDEX"] = 1;
            iGlobal["$GUI_EDITOR_MENU_GUIDESNAP_INDEX"] = 3;
            iGlobal["$GUI_EDITOR_MENU_CONTROLSNAP_INDEX"] = 4;
            iGlobal["$GUI_EDITOR_MENU_CANVASSNAP_INDEX"] = 5;
            iGlobal["$GUI_EDITOR_MENU_GRIDSNAP_INDEX"] = 6;
            iGlobal["$GUI_EDITOR_MENU_DRAWGUIDES_INDEX"] = 8;
            iGlobal["$GUI_EDITOR_MENU_FULLBOXSELECT_INDEX"] = 21;

            this.onCreateMenu();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onRemove()
            {
            GuiEditorGui GuiEditorGui = "GuiEditorGui";

            if (GuiEditorGui.menuGroup.isObject())
                GuiEditorGui.delete();

            // cleanup
            this.onDestroyMenu();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        /// Create the Gui Editor menu bar.
        public void onCreateMenu()
            {
            GuiCanvas Canvas = "Canvas";

            if (this.menuBar.isObject())
                return;

            //set up cmdctrl variable so that it matches OS standards
            string cmdCtrl = "", redoShortcut = "";

            if (sGlobal["$platform"] == "macos")
                {
                cmdCtrl = "cmd";
                redoShortcut = "Cmd-Shift Z";
                }
            else
                {
                cmdCtrl = "Ctrl";
                redoShortcut = "Ctrl Y";
                }

            // Menu bar

            #region MenuBar ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("MenuBar", "");
            oc_Newobject7["dynamicItemInsertPos"] = new ObjectCreator.StringNoQuote("3");

            #region PopupMenu ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc_Newobject1["barTitle"] = "File";
            oc_Newobject1["internalName"] = "FileMenu";
            oc_Newobject1["item[0]"] = "New Gui..." + '\t' + cmdCtrl + ' ' + "N" + '\t' + this + ".create();";
            oc_Newobject1["item[1]"] = "Open..." + '\t' + cmdCtrl + ' ' + "O" + '\t' + this + ".open();";
            oc_Newobject1["item[2]"] = "Save" + '\t' + cmdCtrl + ' ' + "S" + '\t' + this + ".save( false, true );";
            oc_Newobject1["item[3]"] = "Save As..." + '\t' + cmdCtrl + "-Shift S" + '\t' + this + ".save( false );";
            oc_Newobject1["item[4]"] = "Save Selected As..." + '\t' + cmdCtrl + "-Alt S" + '\t' + this +
                                       ".save( true );";
            oc_Newobject1["item[5]"] = "-";
            oc_Newobject1["item[6]"] = "Revert Gui" + '\t' + "" + '\t' + this + ".revert();";
            oc_Newobject1["item[7]"] = "Add Gui From File..." + '\t' + "" + '\t' + this + ".append();";
            oc_Newobject1["item[8]"] = "-";
            oc_Newobject1["item[9]"] = "Open Gui File in Torsion" + '\t' + "" + '\t' + this + ".openInTorsion();";
            oc_Newobject1["item[10]"] = "-";
            oc_Newobject1["item[11]"] = "Close Editor" + '\t' + "F10" + '\t' + this + ".quit();";
            oc_Newobject1["item[12]"] = "Quit" + '\t' + cmdCtrl + ' ' + "Q" + '\t' + "quit();";

            #endregion

            oc_Newobject7["#Newobject1"] = oc_Newobject1;

            #region PopupMenu ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc_Newobject2["barTitle"] = "Edit";
            oc_Newobject2["internalName"] = "EditMenu";
            oc_Newobject2["item[0]"] = "Undo" + '\t' + cmdCtrl + ' ' + "Z" + '\t' + "GuiEditor.undo();";
            oc_Newobject2["item[1]"] = "Redo" + '\t' + redoShortcut + '\t' + "GuiEditor.redo();";
            oc_Newobject2["item[2]"] = "-";
            oc_Newobject2["item[3]"] = "Cut" + '\t' + cmdCtrl + ' ' + "X" + '\t' +
                                       "GuiEditor.saveSelection(); GuiEditor.deleteSelection();";
            oc_Newobject2["item[4]"] = "Copy" + '\t' + cmdCtrl + ' ' + "C" + '\t' + "GuiEditor.saveSelection();";
            oc_Newobject2["item[5]"] = "Paste" + '\t' + cmdCtrl + ' ' + "V" + '\t' + "GuiEditor.loadSelection();";
            oc_Newobject2["item[6]"] = "-";
            oc_Newobject2["item[7]"] = "Select All" + '\t' + cmdCtrl + ' ' + "A" + '\t' + "GuiEditor.selectAll();";
            oc_Newobject2["item[8]"] = "Deselect All" + '\t' + cmdCtrl + ' ' + "D" + '\t' +
                                       "GuiEditor.clearSelection();";
            oc_Newobject2["item[9]"] = "Select Parent(s)" + '\t' + cmdCtrl + "-Alt Up" + '\t' +
                                       "GuiEditor.selectParents();";
            oc_Newobject2["item[10]"] = "Select Children" + '\t' + cmdCtrl + "-Alt Down" + '\t' +
                                        "GuiEditor.selectChildren();";
            oc_Newobject2["item[11]"] = "Add Parent(s) to Selection" + '\t' + cmdCtrl + "-Alt-Shift Up" + '\t' +
                                        "GuiEditor.selectParents( true );";
            oc_Newobject2["item[12]"] = "Add Children to Selection" + '\t' + cmdCtrl + "-Alt-Shift Down" + '\t' +
                                        "GuiEditor.selectChildren( true );";
            oc_Newobject2["item[13]"] = "Select..." + '\t' + "" + '\t' + "GuiEditorSelectDlg.toggleVisibility();";
            oc_Newobject2["item[14]"] = "-";
            oc_Newobject2["item[15]"] = "Lock/Unlock Selection" + '\t' + cmdCtrl + ' ' + "L" + '\t' +
                                        "GuiEditor.toggleLockSelection();";
            oc_Newobject2["item[16]"] = "Hide/Unhide Selection" + '\t' + cmdCtrl + ' ' + "H" + '\t' +
                                        "GuiEditor.toggleHideSelection();";
            oc_Newobject2["item[17]"] = "-";
            oc_Newobject2["item[18]"] = "Group Selection" + '\t' + cmdCtrl + ' ' + "G" + '\t' +
                                        "GuiEditor.groupSelected();";
            oc_Newobject2["item[19]"] = "Ungroup Selection" + '\t' + cmdCtrl + "-Shift G" + '\t' +
                                        "GuiEditor.ungroupSelected();";
            oc_Newobject2["item[20]"] = "-";
            oc_Newobject2["item[21]"] = "Full Box Selection" + '\t' + "" + '\t' + "GuiEditor.toggleFullBoxSelection();";
            oc_Newobject2["item[22]"] = "-";
            oc_Newobject2["item[23]"] = "Grid Size" + '\t' + cmdCtrl + ' ' + "," + '\t' + "GuiEditor.showPrefsDialog();";

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region PopupMenu ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc_Newobject3["barTitle"] = "Layout";
            oc_Newobject3["internalName"] = "LayoutMenu";
            oc_Newobject3["item[0]"] = "Align Left" + '\t' + cmdCtrl + ' ' + "Left" + '\t' + "GuiEditor.Justify(0);";
            oc_Newobject3["item[1]"] = "Center Horizontally" + '\t' + "" + '\t' + "GuiEditor.Justify(1);";
            oc_Newobject3["item[2]"] = "Align Right" + '\t' + cmdCtrl + ' ' + "Right" + '\t' + "GuiEditor.Justify(2);";
            oc_Newobject3["item[3]"] = "-";
            oc_Newobject3["item[4]"] = "Align Top" + '\t' + cmdCtrl + ' ' + "Up" + '\t' + "GuiEditor.Justify(3);";
            oc_Newobject3["item[5]"] = "Center Vertically" + '\t' + "" + '\t' + "GuiEditor.Justify(7);";
            oc_Newobject3["item[6]"] = "Align Bottom" + '\t' + cmdCtrl + ' ' + "Down" + '\t' + "GuiEditor.Justify(4);";
            oc_Newobject3["item[7]"] = "-";
            oc_Newobject3["item[8]"] = "Space Vertically" + '\t' + "" + '\t' + "GuiEditor.Justify(5);";
            oc_Newobject3["item[9]"] = "Space Horizontally" + '\t' + "" + '\t' + "GuiEditor.Justify(6);";
            oc_Newobject3["item[10]"] = "-";
            oc_Newobject3["item[11]"] = "Fit into Parent(s)" + '\t' + "" + '\t' + "GuiEditor.fitIntoParents();";
            oc_Newobject3["item[12]"] = "Fit Width to Parent(s)" + '\t' + "" + '\t' +
                                        "GuiEditor.fitIntoParents( true, false );";
            oc_Newobject3["item[13]"] = "Fit Height to Parent(s)" + '\t' + "" + '\t' +
                                        "GuiEditor.fitIntoParents( false, true );";
            oc_Newobject3["item[14]"] = "-";
            oc_Newobject3["item[15]"] = "Bring to Front" + '\t' + "" + '\t' + "GuiEditor.BringToFront();";
            oc_Newobject3["item[16]"] = "Send to Back" + '\t' + "" + '\t' + "GuiEditor.PushToBack();";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region PopupMenu ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc_Newobject4["barTitle"] = "Move";
            oc_Newobject4["internalName"] = "MoveMenu";
            oc_Newobject4["item[0]"] = "Nudge Left" + '\t' + "Left" + '\t' + "GuiEditor.moveSelection( -1, 0);";
            oc_Newobject4["item[1]"] = "Nudge Right" + '\t' + "Right" + '\t' + "GuiEditor.moveSelection( 1, 0);";
            oc_Newobject4["item[2]"] = "Nudge Up" + '\t' + "Up" + '\t' + "GuiEditor.moveSelection( 0, -1);";
            oc_Newobject4["item[3]"] = "Nudge Down" + '\t' + "Down" + '\t' + "GuiEditor.moveSelection( 0, 1 );";
            oc_Newobject4["item[4]"] = "-";
            oc_Newobject4["item[5]"] = "Big Nudge Left" + '\t' + "Shift Left" + '\t' +
                                       "GuiEditor.moveSelection( - GuiEditor.snap2gridsize, 0 );";
            oc_Newobject4["item[6]"] = "Big Nudge Right" + '\t' + "Shift Right" + '\t' +
                                       "GuiEditor.moveSelection( GuiEditor.snap2gridsize, 0 );";
            oc_Newobject4["item[7]"] = "Big Nudge Up" + '\t' + "Shift Up" + '\t' +
                                       "GuiEditor.moveSelection( 0, - GuiEditor.snap2gridsize );";
            oc_Newobject4["item[8]"] = "Big Nudge Down" + '\t' + "Shift Down" + '\t' +
                                       "GuiEditor.moveSelection( 0, GuiEditor.snap2gridsize );";

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region PopupMenu ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc_Newobject5["barTitle"] = "Snap";
            oc_Newobject5["internalName"] = "SnapMenu";
            oc_Newobject5["item[0]"] = "Snap Edges" + '\t' + "Alt-Shift E" + '\t' + "GuiEditor.toggleEdgeSnap();";
            oc_Newobject5["item[1]"] = "Snap Centers" + '\t' + "Alt-Shift C" + '\t' + "GuiEditor.toggleCenterSnap();";
            oc_Newobject5["item[2]"] = "-";
            oc_Newobject5["item[3]"] = "Snap to Guides" + '\t' + "Alt-Shift G" + '\t' + "GuiEditor.toggleGuideSnap();";
            oc_Newobject5["item[4]"] = "Snap to Controls" + '\t' + "Alt-Shift T" + '\t' +
                                       "GuiEditor.toggleControlSnap();";
            oc_Newobject5["item[5]"] = "Snap to Canvas" + '\t' + "" + '\t' + "GuiEditor.toggleCanvasSnap();";
            oc_Newobject5["item[6]"] = "Snap to Grid" + '\t' + "" + '\t' + "GuiEditor.toggleGridSnap();";
            oc_Newobject5["item[7]"] = "-";
            oc_Newobject5["item[8]"] = "Show Guides" + '\t' + "" + '\t' + "GuiEditor.toggleDrawGuides();";
            oc_Newobject5["item[9]"] = "Clear Guides" + '\t' + "" + '\t' + "GuiEditor.clearGuides();";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region PopupMenu ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            oc_Newobject6["internalName"] = "HelpMenu";
            oc_Newobject6["barTitle"] = "Help";
            oc_Newobject6["item[0]"] = "Online Documentation..." + '\t' + "Alt F1" + '\t' +
                                       "gotoWebPage( GuiEditor.documentationURL );";
            oc_Newobject6["item[1]"] = "Offline User Guid..." + '\t' + "" + '\t' +
                                       "gotoWebPage( GuiEditor.documentationLocal );";
            oc_Newobject6["item[2]"] = "Offline Reference Guide..." + '\t' + "" + '\t' +
                                       "shellExecute( GuiEditor.documentationReference );";
            oc_Newobject6["item[3]"] = "-";
            oc_Newobject6["item[4]"] = "Torque 3D Public Forums..." + '\t' + "" + '\t' +
                                       "gotoWebPage( \\\"http://www.garagegames.com/community/forums/73\\\" );";
            oc_Newobject6["item[5]"] = "Torque 3D Private Forums..." + '\t' + "" + '\t' +
                                       "gotoWebPage( \\\"http://www.garagegames.com/community/forums/63\\\" );";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            this.menuBar = oc_Newobject7.Create();
            this.menuBar.attachToCanvas(Canvas, 0);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        /// Called before onSleep when the canvas content is changed
        public void onDestroyMenu()
            {
            if (!this.menuBar.isObject())
                return;

            // Destroy menus      
            while (this.menuBar.getCount() != 0)
                this.menuBar.getObject(0).delete();

            this.menuBar.removeFromCanvas();
            this.menuBar.delete();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onWindowClose()
            {
            this.quit();
            }

        //=============================================================================================
        //    Menu Commands.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void create()
            {
            GuiEditorNewGuiDialog GuiEditorNewGuiDialog = "GuiEditorNewGuiDialog";
            GuiCanvas Canvas = "Canvas";

            GuiEditorNewGuiDialog.init("NewGui", "GuiControl");

            Canvas.pushDialog(GuiEditorNewGuiDialog);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void load(string filename)
            {
            GuiEditorStatusBar GuiEditorStatusBar = "GuiEditorStatusBar";
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            string newRedefineBehavior = "replaceExisting";
            if (Util.isDefined("$GuiEditor::loadRedefineBehavior"))
                {
                // This trick allows to choose different redefineBehaviors when loading
                // GUIs.  This is useful, for example, when loading GUIs that would lead to
                // problems when loading with their correct names because script behavior
                // would immediately attach.
                //
                // This allows to also edit the GUI editor's own GUI inside itself.

                newRedefineBehavior = sGlobal["$GuiEditor::loadRedefineBehavior"];
                }

            // Allow stomping objects while exec'ing the GUI file as we want to
            // pull the file's objects even if we have another version of the GUI
            // already loaded.

            string oldRedefineBehavior = sGlobal["$Con::redefineBehavior"];
            sGlobal["$Con::redefineBehavior"] = newRedefineBehavior;

            // Load up the gui.
            Util.exec(filename);
            GuiControl guiContent = Util.eval("return %guiContent;");
            //GuiControl guiContent = Util.eval(filename);

            sGlobal["$Con::redefineBehavior"] = oldRedefineBehavior;

            // The GUI file should have contained a GUIControl which should now be in the instant
            // group. And, it should be the only thing in the group.
            //TODO
            if (!guiContent.isObject())
                {
                Util.messageBox(Util.getEngineName(),
                    "You have loaded a Gui file that was created before this version.  It has been loaded but you must open it manually from the content list dropdown",
                    "Ok", "Information");
                return;
                }

            GuiEditor.openForEditing(guiContent);

            GuiEditorStatusBar.print("Loaded '" + filename + "'");
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void openInTorsion()
            {
            GuiControl GuiEditorContent = "GuiEditorContent";
            if (GuiEditorContent.getCount() == 0)
                return;

            string guiObject = GuiEditorContent.getObject(0);
            MenuHandlers.EditorOpenDeclarationInTorsion(guiObject);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void open()
            {
            GuiEditorFileDialog.GuiBuilder GuiBuilder = "GuiBuilder";

            string openFileName = GuiBuilder.getOpenName("");
            if (openFileName == "")
                return;

            // Make sure the file is valid.
            if ((!Util.isFile(openFileName)) && (!Util.isFile(openFileName + ".dso")))
                return;

            this.load(openFileName);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void save(bool selectedOnly, bool noPrompt)
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            GuiControl GuiEditorContent = "GuiEditorContent";
            GuiEditorStatusBar GuiEditorStatusBar = "GuiEditorStatusBar";

            SimObject currentObject;
            // Get the control we should save.

            if (selectedOnly)
                {
                SimSet selected = GuiEditor.getSelection();
                if (selected.getCount() == 0)
                    return;
                else if (selected.getCount() > 1)
                    {
                    Util.messageBox("Invalid selection",
                        "Only a single control hierarchy can be saved to a file.  Make sure you have selected only one control in the tree view.",
                        "", "");
                    return;
                    }

                currentObject = selected.getObject(0);
                }
            else if (GuiEditorContent.getCount() > 0)
                currentObject = GuiEditorContent.getObject(0);
            else
                return;

            // Store the current guide set on the control.

            GuiEditor.writeGuides(currentObject);
            currentObject.canSaveDynamicFields = true; // Make sure the guides get saved out.

            // Construct a base filename.

            string name;
            if (currentObject.getName() != "")
                name = currentObject.getName() + ".gui";
            else
                name = "Untitled.gui";

            // Construct a path.

            string currentFile;

            if (selectedOnly
                && currentObject != GuiEditorContent.getObject(0)
                && currentObject.getFilename() == ((SimObject) GuiEditorContent.getObject(0)).getFilename())
                {
                // Selected child control that hasn't been yet saved to its own file.

                currentFile = GuiEditor["LastPath"] + "/" + name;
                currentFile = Util.makeRelativePath(currentFile, Util.getMainDotCsDir());
                }
            else
                {
                currentFile = currentObject.getFilename();
                if (currentFile == "")
                    {
                    // No file name set on control.  Force a prompt.
                    noPrompt = false;

                    if (GuiEditor["LastPath"] != "")
                        {
                        currentFile = GuiEditor["LastPath"] + "/" + name;
                        currentFile = Util.makeRelativePath(currentFile, Util.getMainDotCsDir());
                        }
                    else
                        currentFile = Util._expandFilename(name);
                    }
                else
                    currentFile = Util._expandFilename(currentFile);
                }

            // Get the filename.

            string filename;

            if (!noPrompt)
                {
                filename = GuiEditorFileDialog.GuiBuilder.GetSaveName(currentFile);
                // console.Call_Classname("GuiBuilder", "getSaveName", new string[] {currentFile} );
                if (filename == "")
                    return;
                }
            else
                filename = currentFile;

            // Save the Gui.

            if (Util.isWriteableFileName(filename))
                {
                //
                // Extract any existent TorqueScript before writing out to disk
                //
                FileObject fileObject = new ObjectCreator("FileObject").Create();
                fileObject.openForRead(filename);
                bool skipLines = true;
                bool beforeObject = true;
                // var++ does not post-increment var, in torquescript, it pre-increments it,
                // because ++var is illegal. 
                //int lines = -1;
                //int beforeLines = -1;
                skipLines = false;

                //string[] beforeNewFileLines = new string[]{};
                //string[] newFileLines = new string[]{};

                List<string> beforeNewFileLines = new List<string>();
                List<string> newFileLines = new List<string>();

                while (!fileObject.isEOF())
                    {
                    string line = fileObject.readLine();
                    if (line == "//--- OBJECT WRITE BEGIN ---")
                        skipLines = true;
                    else if (line == "//--- OBJECT WRITE END ---")
                        {
                        skipLines = false;
                        beforeObject = false;
                        }
                    else if (skipLines == false)
                        {
                        if (beforeObject)
                            beforeNewFileLines.Add(line);
                            //beforeNewFileLines[ beforeLines++ ] = line;
                        else
                            //newFileLines[ lines++ ] = line;
                            newFileLines.Add(line);
                        }
                    }
                fileObject.close();
                fileObject.delete();

                FileObject fo = new ObjectCreator("FileObject").Create();
                fo.openForWrite(filename);

                // Write out the captured TorqueScript that was before the object before the object
                foreach (string line in beforeNewFileLines)
                    {
                    fo.writeLine(line);
                    }

                //for(int i = 0; i <= beforeLines; i++)
                //    fo.writeLine( beforeNewFileLines[ i ] );

                fo.writeLine("//--- OBJECT WRITE BEGIN ---");
                fo.writeObject(currentObject, "%guiContent = ");
                fo.writeLine("//--- OBJECT WRITE END ---");

                // Write out captured TorqueScript below Gui object
                //for( int i = 0; i <= lines; i++ )
                //    fo.writeLine( newFileLines[ i ] );
                foreach (string line in newFileLines)
                    {
                    fo.writeLine(line);
                    }

                fo.close();
                fo.delete();

                currentObject.setFilename(Util.makeRelativePath(filename, Util.getMainDotCsDir()));

                GuiEditorStatusBar.print("Saved file '" + currentObject.getFilename() + "'");
                }
            else
                Util.messageBox("Error writing to file",
                    "There was an error writing to file '" + currentFile + "'. The file may be read-only.", "Ok",
                    "Error");
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void append()
            {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            GuiControl GuiEditorContent = "GuiEditorContent";
            GuiEditorStatusBar GuiEditorStatusBar = "GuiEditorStatusBar";

            // Get filename.

            string openFileName = console.Call_Classname("GuiBuilder", "getOpenName");
            if (openFileName == ""
                || (!Util.isFile(openFileName)
                    && !Util.isFile(openFileName + ".dso")))
                return;

            // Exec file.

            string oldRedefineBehavior = sGlobal["$Con::redefineBehavior"];
            sGlobal["$Con::redefineBehavior"] = "renameNew";

            //TODO
            GuiControl guiContent = Util.eval(openFileName);
            sGlobal["$Con::redefineBehavior"] = oldRedefineBehavior;

            // Find guiContent.

            if (!guiContent.isObject())
                {
                Util.messageBox("Error loading GUI file",
                    "The GUI content controls could not be found.  This function can only be used with files saved by the GUI editor.",
                    "Ok", "Error");
                return;
                }

            if (GuiEditorContent.getCount() == 0)
                GuiEditor.openForEditing(guiContent);
            else
                {
                ((SimSet) GuiEditor.getCurrentAddSet()).add(guiContent);
                GuiEditor.readGuides(guiContent);
                GuiEditor.onAddNewCtrl(guiContent);
                GuiEditor.onHierarchyChanged();
                }

            GuiEditorStatusBar.print("Appended controls from '" + openFileName + "'");
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void revert()
            {
            GuiControl GuiEditorContent = "GuiEditorContent";

            if (GuiEditorContent.getCount() == 0)
                return;

            SimObject gui = GuiEditorContent.getObject(0);
            string filename = gui.getFilename();
            if (filename == "")
                return;

            if (
                Util.messageBox("Revert Gui", "Really revert the current Gui?  This cannot be undone.", "OkCancel",
                    "Question") == iGlobal["$MROk"])
                this.load(filename);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void close()
            {
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void quit()
            {
            GuiEditorGui GuiEditorGui = "GuiEditorGui";
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            SimSet GuiGroup = "GuiGroup";
            GuiCanvas Canvas = "Canvas";
            PostEffect MLAAFx = "MLAAFx";

            this.close();
            GuiGroup.add(GuiEditorGui);
            // we must not delete a window while in its event handler, or we foul the event dispatch mechanism
            this.schedule("10", "delete");

            Canvas.setContent(GuiEditor["lastContent"]);
            bGlobal["$InGuiEditor"] = false;

            //Temp fix to disable MLAA when in GUI editor
            if (MLAAFx.isObject() && bGlobal["$MLAAFxGuiEditorTemp"])
                {
                MLAAFx.isEnabled = true;
                bGlobal["$MLAAFxGuiEditorTemp"] = false;
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditCanvas ts, string simobjectid)
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
        public static bool operator !=(GuiEditCanvas ts, string simobjectid)
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
        public static implicit operator string(GuiEditCanvas ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditCanvas(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GuiEditCanvas) Omni.self.getSimObject(simobjectid, typeof (GuiEditCanvas));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditCanvas ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditCanvas(int simobjectid)
            {
            return (GuiEditCanvas) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditCanvas));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditCanvas ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditCanvas(uint simobjectid)
            {
            return (GuiEditCanvas) Omni.self.getSimObject(simobjectid, typeof (GuiEditCanvas));
            }

        #endregion
        }
    }