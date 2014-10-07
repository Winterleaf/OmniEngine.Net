using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
// +todo:
//
// - split node transform editboxes into X Y Z and rot X Y Z with spin controls
//   to allow easier manual editing
// - add groundspeed editing ( use same format as node transform editing )
//
// Known bugs/limitations:
//
// - resizing the GuiTextListCtrl should resize the columns as well
// - modifying the from/in/out properties of a sequence will change the sequence
//   order in the shape ( since it results in remove/add sequence commands )
// - deleting a node should not delete its children as well?
//
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEditor>))]
    public class ShapeEditor : ScriptObject
        {
        

        internal TSShapeConstructor shape
            {
            get { return this["shape"]; }
            set { this["shape"] = value; }
            }

        //------------------------------------------------------------------------------
        // Utility Methods
        //------------------------------------------------------------------------------
        [ConsoleInteraction(true, "ShapeEditor_initialize")]
        public static void initialize()
            {
            if (!"ShapeEditor".isObject())
                {
                ObjectCreator shapeEditor = new ObjectCreator("ScriptObject", "ShapeEditor", typeof (ShapeEditor));
                shapeEditor["shape"] = "-1";
                shapeEditor["deletedCount"] = "0";
                shapeEditor.Create();
                }
            }

        // Capitalise the first letter of the input string
        [ConsoleInteraction]
        public static string strcapitalise(string str)
            {
            int len = omni.Util.strlen(str);
            return omni.Util.strupr(omni.Util.getSubStr(str, 0, 1)) + omni.Util.getSubStr(str, 1, len - 1);
            }

        [ConsoleInteraction]
        public string getObjectShapeFile(SimObject obj)
            {
            // Get the path to the shape file used by the given object (not perfect, but
            // works for the vast majority of object types)
            string path = "";
            if (obj.isMemberOfClass("TSStatic"))
                path = obj["shapeName"];
            else if (obj.isMemberOfClass("PhysicsShape"))
                path = ((SimObject) obj.getDataBlock())["shapeName"];
            else if (obj.isMemberOfClass("GameBase"))
                path = ((SimObject) obj.getDataBlock())["shapeFile"];

            return path;
            }

        // Check if the given name already exists
        [ConsoleInteraction]
        public bool nameExists(string type, string name)
            {
            if (this.shape == -1)
                return false;

            if (type == "node")
                return (this.shape.getNodeIndex(name) >= 0);
            else if (type == "sequence")
                return (this.shape.getSequenceIndex(name) >= 0);
            else if (type == "object")
                return (this.shape.getObjectIndex(name) >= 0);

            return false;
            }

        // Check if the given 'hint' name exists (spaces could also be underscores)
        [ConsoleInteraction]
        public bool hintNameExists(string type, string name)
            {
            if (this.nameExists(type, name))
                return true;

            // If the name contains spaces, try replacing with underscores
            name = Util.strreplace(name, " ", "_");
            if (this.nameExists(type, name))
                return true;

            return false;
            }

        // Generate a unique name from a given base by appending an integer
        [ConsoleInteraction]
        public string getUniqueName(string type, string name)
            {
            string uniqueName = "";
            for (int idx = 1; idx < 100; idx++)
                {
                uniqueName = name + idx;
                if (!this.nameExists(type, uniqueName))
                    break;
                }

            return uniqueName;
            }

        [ConsoleInteraction]
        public string getProxyName(string seqName)
            {
            return "__proxy__" + seqName;
            }

        [ConsoleInteraction]
        public string getUnproxyName(string proxyName)
            {
            return Util.strreplace(proxyName, "__proxy__", "");
            }

        [ConsoleInteraction]
        public string getBackupName(string seqName)
            {
            return "__backup__" + seqName;
            }

        // Check if this mesh name is a collision hint
        [ConsoleInteraction]
        public bool isCollisionMesh(string name)
            {
            return (Util.startsWith(name, "ColBox", true) ||
                    Util.startsWith(name, "ColSphere", true) ||
                    Util.startsWith(name, "ColCapsule", true) ||
                    Util.startsWith(name, "ColConvex", true));
            }

        [ConsoleInteraction]
        public string getSequenceSource(string seqName)
            {
            string source = this.shape.getSequenceSource(seqName);

            // Use the sequence name as the source for DTS built-in sequences
            string src0 = Util.getField(source, 0);
            string src1 = Util.getField(source, 1);
            if (src0 == src1)
                source = Util.setField(source, 1, "");
            if (src0 == "")
                source = Util.setField(source, 0, seqName);

            return source;
            }

        // Recursively get names for a node and its children
        [ConsoleInteraction]
        public string getNodeNames(string nodeName, string names, string exclude)
            {
            if (nodeName == exclude)
                return names;

            int count = this.shape.getNodeChildCount(nodeName);
            for (int i = 0; i < count; i++)
                {
                string childName = this.shape.getNodeChildName(nodeName, i);
                names = this.getNodeNames(childName, names, exclude);
                }

            names = names + '\t' + nodeName;

            return Util.trim(names);
            }

        // Get the list of meshes for a particular object
        [ConsoleInteraction]
        public string getObjectMeshList(string name)
            {
            string list = "";
            int count = this.shape.getMeshCount(name);
            for (int i = 0; i < count; i++)
                list = list + '\t' + this.shape.getMeshName(name, i);
            return Util.trim(list);
            }

        // Get the list of meshes for a particular detail level
        [ConsoleInteraction]
        public string getDetailMeshList(string detSize)
            {
            string list = "";
            int objCount = this.shape.getObjectCount();
            for (int i = 0; i < objCount; i++)
                {
                string objName = this.shape.getObjectName(i);
                int meshCount = this.shape.getMeshCount(objName);
                for (int j = 0; j < meshCount; j++)
                    {
                    string size = this.shape.getMeshSize(objName, j).AsString();
                    if (size == detSize)
                        list = list + '\t' + this.shape.getMeshName(objName, j);
                    }
                }
            return Util.trim(list);
            }

        [ConsoleInteraction]
        public bool isDirty()
            {
            GuiWindowCollapseCtrl ShapeEdPropWindow = "ShapeEdPropWindow";
            GuiBitmapButtonCtrl saveBtn = ShapeEdPropWindow.FOT("saveBtn");
            return (this.shape.isObject() && saveBtn.isActive());
            }

        [ConsoleInteraction]
        public void setDirty(bool dirty)
            {
            GuiWindowCollapseCtrl ShapeEdPropWindow = "ShapeEdPropWindow";
            GuiBitmapButtonCtrl saveBtn = ShapeEdPropWindow.FOT("saveBtn");
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";

            if (dirty)
                ShapeEdSelectWindow.text = "Shapes *";
            else
                ShapeEdSelectWindow.text = "Shapes";

            saveBtn.setActive(dirty);
            }

        [ConsoleInteraction]
        public void saveChanges()
            {
            if (this.shape.isObject())
                {
                this.saveConstructor(this.shape);
                this.shape.writeChangeSet();
                this.shape.notifyShapeChanged(); // Force game objects to reload shape
                this.setDirty(false);
                }
            }

        //------------------------------------------------------------------------------
        // Shape Selection
        //------------------------------------------------------------------------------

        public string findConstructor(string path)
            {
            SimSet TSShapeConstructorGroup = "TSShapeConstructorGroup";
            int count = TSShapeConstructorGroup.getCount();
            for (uint i = 0; i < count; i++)
                {
                SimObject obj = TSShapeConstructorGroup.getObject(i);
                if (obj["baseShape"] == path)
                    return obj;
                }
            return "-1";
            }

        [ConsoleInteraction]
        public string createConstructor(string path)
            {
            string name = strcapitalise(Util.fileBase(path)) + strcapitalise(Util.getSubStr(Util.fileExt(path), 1, 3));
            name = Util.strreplace(name, "-", "_");
            name = Util.strreplace(name, ".", "_");
            name = Util.getUniqueName(name);
            ObjectCreator tempCreator = new ObjectCreator("TSShapeConstructor", name);
            tempCreator["baseShape"] = path;

            TSShapeConstructor temp = tempCreator.Create();
            return temp;
            }

        [ConsoleInteraction]
        public void saveConstructor(SimObject constructor)
            {
            string savepath = Util.filePath(constructor["baseShape"]) + "/" + Util.fileBase(constructor["baseShape"]) +
                              ".cs";
            PersistenceManager shapeEd_perMan = new ObjectCreator("PersistenceManager", "shapeEd_perMan").Create();
            shapeEd_perMan.setDirty(constructor, savepath);
            shapeEd_perMan.saveDirtyObject(constructor);
            shapeEd_perMan.delete();
            }

        [ConsoleInteraction]
        public void selectShape(string path, bool saveOld)
            {
            ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEditorActions.ShapeEdUndoManager ShapeEdUndoManager = "ShapeEdUndoManager";
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
            ShapeEdColWindow ShapeEdColWindow = "ShapeEdColWindow";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

            ShapeEdShapeView.setModel("");

            if (saveOld)
                {
                // Save changes to a TSShapeConstructor script
                this.saveChanges();
                }
            else if (this.isDirty())
                {
                // Purge all unsaved changes
                string oldPath = this.shape["baseShape"];
                this.shape.delete();
                this.shape = 0;

                Util.reloadResource(oldPath); // Force game objects to reload shape
                }

            // Initialise the shape preview window
            if (!ShapeEdShapeView.setModel(path))
                {
                messageBox.MessageBoxOK("Error", "Failed to load '" + path + "'. Check the console for error messages.");
                return;
                }

            ShapeEdShapeView.fitToShape();

            ShapeEdUndoManager.clearAll();
            this.setDirty(false);

            // Get ( or create ) the TSShapeConstructor object for this shape
            this.shape = this.findConstructor(path);
            if (this.shape <= 0)
                {
                this.shape = this.createConstructor(path);
                if (this.shape <= 0)
                    {
                    Util._error("ShapeEditor: Error - could not select " + path);
                    return;
                    }
                }

            // Initialise the editor windows
            ShapeEdAdvancedWindow.update_onShapeSelectionChanged();
            ShapeEdMountWindow.update_onShapeSelectionChanged();
            ShapeEdThreadWindow.update_onShapeSelectionChanged();
            ShapeEdColWindow.update_onShapeSelectionChanged();
            ShapeEdPropWindow.update_onShapeSelectionChanged();
            ShapeEdShapeView.refreshShape();

            // Update object type hints
            ShapeEdSelectWindow.updateHints();

            // Update editor status bar
            EditorGuiStatusBar.setSelection(path);
            }

        [ConsoleInteraction]
        public void autoAddDetails(SimObject dest)
            {
            // Sets of LOD files are named like:
            //
            // MyShape_LOD200.dae
            // MyShape_LOD64.dae
            // MyShape_LOD2.dae
            //
            // Determine the base name of the input file (MyShape_LOD in the example above)
            // and use that to find any other shapes in the set.
            ShapeEditor ShapeEditor = "ShapeEditor";
            ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

            string baseShape = Util.fileBase(dest["baseShape"]);
            int pos = Util.strstr(baseShape, "_LOD");
            if (pos < 0)
                {
                Util._echo("Not an LOD shape file");
                return;
                }

            baseShape = Util.getSubStr(baseShape, 0, pos + 4);

            Util._echo("Base is: " + baseShape);

            string filePatterns = Util.filePath(dest["baseShape"]) + "/" + baseShape + "*" +
                                  Util.fileExt(dest["baseShape"]);

            Util._echo("Pattern is: " + filePatterns);

            string fullPath = Util.findFirstFileMultiExpr(filePatterns, false);
            while (fullPath != "")
                {
                fullPath = Util.makeRelativePath(fullPath, Util.getMainDotCsDir());

                if (fullPath != dest["baseShape"])
                    {
                    Util._echo("Found LOD shape file: " + fullPath);

                    // Determine the detail size ( number after the base name ), then add the
                    // new mesh
                    string size = Util.strreplace(Util.fileBase(fullPath), baseShape, "");
                    ShapeEditor.addLODFromFile(dest, fullPath, size, false);
                    }

                fullPath = Util.findNextFileMultiExpr(filePatterns);
                }

            if (this.shape == dest)
                {
                ShapeEdShapeView.refreshShape();
                ShapeEdDetails.update_onDetailsChanged();
                }
            }

        [ConsoleInteraction]
        public string addLODFromFile(SimObject dest, string filename, string size, bool allowUnmatched)
            {
            // Get (or create) a TSShapeConstructor object for the source shape. Need to
            // exec the script manually as the resource may not have been loaded yet

            ShapeEditor ShapeEditor = "ShapeEditor";

            string csPath = Util.filePath(filename) + "/" + Util.fileBase(filename) + ".cs";
            if (Util.isFile(csPath))
                Util.exec(csPath, false, false);

            SimObject source = ShapeEditor.findConstructor(filename);
            if (source == 0)
                source = ShapeEditor.createConstructor(filename);
            source["lodType"] = "SingleSize";
            source["singleDetailSize"] = size;

            // Create a temporary TSStatic to ensure the resource is loaded
            ObjectCreator tempCreator = new ObjectCreator("TSStatic");
            tempCreator["shapeName"] = filename;
            tempCreator["collisionType"] = "None";

            TSStatic temp = tempCreator.Create();

            string meshList = "";
            if (temp.isObject())
                {
                // Add a new mesh for each object in the source shape
                int objCount = source.call("getObjectCount").AsInt();
                for (int i = 0; i < objCount; i++)
                    {
                    string objName = source.call("getObjectName", i.AsString());

                    Util._echo("Checking for object " + objName);

                    if (allowUnmatched || (dest.call("getObjectIndex", objName).AsInt() != -1))
                        {
                        // Add the source object's highest LOD mesh to the destination shape
                        Util._echo("Adding detail size" + ' ' + size + ' ' + "for object" + ' ' + objName);
                        string srcName = source.call("getMeshName", objName, "0");
                        string destName = objName + ' ' + size;
                        dest.call("addMesh", destName, filename, srcName);
                        meshList = meshList + '\t' + destName;
                        }
                    }

                temp.delete();
                }

            return Util.trim(meshList);
            }

        //------------------------------------------------------------------------------
        // Helper functions for creating and applying GUI operations

        //[ConsoleInteraction]
        public T createAction<T>(string desc)
            {
            Util.pushInstantGroup();
            ObjectCreator actionCreator = new ObjectCreator("UndoScriptAction", "", typeof(T));
            //action["class"] = className;
            //action["superClass"] = "BaseShapeEdAction";
            actionCreator["actionName"] = desc;
            actionCreator["done"] = "0";

            T action = myReflections.ChangeType<T>(actionCreator.Create());

            Util.popInstantGroup();
            return action;
            }

        [ConsoleInteraction]
        public void doAction(ShapeEditorActions.BaseShapeEdAction action)
            {
            ShapeEditor ShapeEditor = "ShapeEditor";
            ShapeEditorActions.ShapeEdUndoManager ShapeEdUndoManager = "ShapeEdUndoManager";

            if (action.doit())
                {
                ShapeEditor.setDirty(true);
                action.addToManager(ShapeEdUndoManager);
                }
            else
                {
                messageBox.MessageBoxOK("Error",
                    action["actionName"] + ' ' + "failed. Check the console for error messages.", "");
                }
            }

        [ConsoleInteraction]
        public void doRemoveShapeData(string type, string name)
            {
            // Removing data from the shape cannot be undone => so warn the user first
            messageBox.MessageBoxYesNo("Warning", "Deleting a " + type + " cannot be undone. Do " +
                                                  "you want to continue?",
                "ShapeEditor.doRemove" + type + "( \"" + name + "\" );", "");
            }

        //------------------------------------------------------------------------------
        // Add node
        [ConsoleInteraction]
        public void doAddNode(string nodeName, string parentName, string transform)
            {
            var action = this.createAction<ShapeEditorActions.ActionAddNode>("Add node");
            action["nodeName"] = nodeName;
            action["parentName"] = parentName;
            action["transform"] = transform;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Remove node
        [ConsoleInteraction]
        public void doRemoveNode(string nodeName)
            {
            ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            var action = this.createAction<ShapeEditorActions.ActionRemoveNode>("Remove node");
            action["nodeName"] = nodeName;
            action["nodeChildIndex"] = ShapeEdNodeTreeView.getChildIndexByName(nodeName).AsString();

            // Need to delete all child nodes of this node as well, so recursively collect
            // all of the names.
            action["nameList"] = this.getNodeNames(nodeName, "", "");
            action["nameCount"] = Util.getFieldCount(action["nameList"]).AsString();
            for (int i = 0; i < action["nameCount"].AsInt(); i++)
                action["names[" + i + "]"] = Util.getField(action["nameList"], i);

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Rename node
        [ConsoleInteraction]
        public void doRenameNode(string oldName, string newName)
            {
            var action = this.createAction<ShapeEditorActions.ActionRenameNode>("Rename node");
            action["oldName"] = oldName;
            action["newName"] = newName;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Set node parent
        [ConsoleInteraction]
        public void doSetNodeParent(string name, string parent)
            {
            if (parent == "<root>")
                parent = "";

            var action = this.createAction<ShapeEditorActions.ActionSetNodeParent>("Set parent node");
            action["nodeName"] = name;
            action["parentName"] = parent;
            action["oldParentName"] = this.shape.getNodeParentName(name);

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit node transform
        [ConsoleInteraction]
        public void doEditNodeTransform(string nodeName, string newTransform, bool isWorld, string gizmoID)
            {
            ShapeEditorActions.ShapeEdUndoManager ShapeEdUndoManager = "ShapeEdUndoManager";

            // If dragging the 3D gizmo, combine all movement into a single action. Undoing
            // that action will return the node to where it was when the gizmo drag started.
            ShapeEditorActions.BaseShapeEdAction last = ShapeEdUndoManager.getUndoAction((ShapeEdUndoManager.getUndoCount() - 1));
            if ((last != -1) && (last["class"] == "ActionEditNodeTransform") &&
                (last["nodeName"] == nodeName) && (last["gizmoID"].AsInt() != -1) && (last["gizmoID"] == gizmoID))
                {
                // Use the last action to do the edit, and modify it so it only applies
                // the latest transform
                last["newTransform"] = newTransform;
                last["isWorld"] = isWorld.AsString();
                last.doit();
                this.setDirty(true);
                }
            else
                {
                var action = this.createAction<ShapeEditorActions.ActionEditNodeTransform>("Edit node transform");
                action["nodeName"] = nodeName;
                action["newTransform"] = newTransform;
                action["isWorld"] = isWorld.AsString();
                action["gizmoID"] = gizmoID;
                action["oldTransform"] = this.shape.getNodeTransform(nodeName, isWorld).AsString();

                this.doAction(action);
                }
            }

        //------------------------------------------------------------------------------
        // Add sequence
        [ConsoleInteraction]
        public void doAddSequence(string seqName, string from, string start, string end)
            {
            var action = this.createAction<ShapeEditorActions.ActionAddSequence>("Add sequence");
            action["seqName"] = seqName;
            action["origFrom"] = from;
            action["from"] = from;
            action["start"] = start;
            action["end"] = end;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Remove sequence

        [ConsoleInteraction]
        public void doRemoveSequence(string seqName)
            {
            var action = this.createAction<ShapeEditorActions.ActionRemoveSequence>("Remove sequence");
            action["seqName"] = seqName;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Rename sequence
        [ConsoleInteraction]
        public void doRenameSequence(string oldName, string newName)
            {
            var action = this.createAction<ShapeEditorActions.ActionRenameSequence>("Rename sequence");
            action["oldName"] = oldName;
            action["newName"] = newName;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit sequence source data ( parent, start or end )
        [ConsoleInteraction]
        public void doEditSeqSource(string seqName, string from, string start, string end)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditSeqSource>("Edit sequence source data");
            action["seqName"] = seqName;
            action["origFrom"] = from;
            action["from"] = from;
            action["start"] = start;
            action["end"] = end;

            // To support undo, the sequence will be renamed instead of removed (undo just
            // removes the added sequence and renames the original back). Generate a unique
            // name for the backed up sequence
            action["seqBackup"] = this.getUniqueName("sequence", "__backup__" + action["seqName"] + " ");

            // If editing an internal sequence, the source is the renamed backup
            if (action["from"] == action["seqName"])
                action["from"] = action["seqBackup"];

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit cyclic flag
        [ConsoleInteraction]
        public void doEditCyclic(string seqName, string cyclic)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditCyclic>("Toggle cyclic flag");
            action["seqName"] = seqName;
            action["cyclic"] = cyclic;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit blend properties
        [ConsoleInteraction]
        public void doEditBlend(string seqName, string blend, string blendSeq, string blendFrame)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditBlend>("Edit blend properties");
            action["seqName"] = seqName;
            action["blend"] = blend;
            action["blendSeq"] = blendSeq;
            action["blendFrame"] = blendFrame;

            // Store the current blend settings
            string oldBlend = this.shape.getSequenceBlend(seqName);
            action["oldBlend"] = Util.getField(oldBlend, 0);
            action["oldBlendSeq"] = Util.getField(oldBlend, 1);
            action["oldBlendFrame"] = Util.getField(oldBlend, 2);

            // Use new values if the old ones do not exist ( for blend sequences embedded
            // in the DTS/DSQ file )
            if (action["oldBlendSeq"] == "")
                action["oldBlendSeq"] = action["blendSeq"];
            if (action["oldBlendFrame"] == "")
                action["oldBlendFrame"] = action["blendFrame"];

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit sequence priority
        [ConsoleInteraction]
        public void doEditSequencePriority(string seqName, string newPriority)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditSequencePriority>("Edit sequence priority");
            action["seqName"] = seqName;
            action["newPriority"] = newPriority;
            action["oldPriority"] = this.shape.getSequencePriority(seqName).AsString();

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit sequence ground speed
        [ConsoleInteraction]
        public void doEditSequenceGroundSpeed(string seqName, string newSpeed)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditSequenceGroundSpeed>("Edit sequence ground speed");
            action["seqName"] = seqName;
            action["newSpeed"] = newSpeed;
            action["oldSpeed"] = this.shape.getSequenceGroundSpeed(seqName);

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Add trigger
        [ConsoleInteraction]
        public void doAddTrigger(string seqName, string frame, string state)
            {
            var action = this.createAction<ShapeEditorActions.ActionAddTrigger>("Add trigger");
            action["seqName"] = seqName;
            action["frame"] = frame;
            action["state"] = state;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Remove trigger
        [ConsoleInteraction]
        public void doRemoveTrigger(string seqName, string frame, string state)
            {
            var action = this.createAction<ShapeEditorActions.ActionRemoveTrigger>("Remove trigger");
            action["seqName"] = seqName;
            action["frame"] = frame;
            action["state"] = state;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit trigger
        [ConsoleInteraction]
        public void doEditTrigger(string seqName, string oldFrame, string oldState, string frame, string state)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditTrigger>("Edit trigger");
            action["seqName"] = seqName;
            action["oldFrame"] = oldFrame;
            action["oldState"] = oldState;
            action["frame"] = frame;
            action["state"] = state;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Rename detail
        [ConsoleInteraction]
        public void doRenameDetail(string oldName, string newName)
            {
            var action = this.createAction<ShapeEditorActions.ActionRenameDetail>("Rename detail");
            action["oldName"] = oldName;
            action["newName"] = newName;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit detail size
        [ConsoleInteraction]
        public void doEditDetailSize(int oldSize, string newSize)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditDetailSize>("Edit detail size");
            action["oldSize"] = oldSize.AsString();
            action["newSize"] = newSize;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Rename object
        [ConsoleInteraction]
        public void doRenameObject(string oldName, string newName)
            {
            var action = this.createAction<ShapeEditorActions.ActionRenameObject>("Rename object");
            action["oldName"] = oldName;
            action["newName"] = newName;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit mesh size
        public void doEditMeshSize(string meshName, string size)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditMeshSize>("Edit mesh size");
            action["meshName"] = Util.stripTrailingNumber(meshName);
            action["oldSize"] = Util.getTrailingNumber(meshName).AsString();
            action["newSize"] = size;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit billboard type
        [ConsoleInteraction]
        public void doEditMeshBillboard(string meshName, string type)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditMeshBillboard>("Edit mesh billboard");
            action["meshName"] = meshName;
            action["oldType"] = this.shape.getMeshType(meshName);
            action["newType"] = type;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Edit object node
        [ConsoleInteraction]
        public void doSetObjectNode(string objName, string node)
            {
            var action = this.createAction<ShapeEditorActions.ActionSetObjectNode>("Set object node");
            action["objName"] = objName;
            action["oldNode"] = this.shape.getObjectNode(objName);
            action["newNode"] = node;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Remove mesh
        [ConsoleInteraction]
        public void doRemoveMesh(string meshName)
            {
            var action = this.createAction<ShapeEditorActions.ActionRemoveMesh>("Remove mesh");
            action["meshName"] = meshName;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Add meshes from file
        [ConsoleInteraction]
        public void doAddMeshFromFile(string filename, string size)
            {
            var action = this.createAction<ShapeEditorActions.ActionAddMeshFromFile>("Add mesh from file");
            action["filename"] = filename;
            action["size"] = size;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Add/edit collision geometry
        public void doEditCollision(string type, string target, string depth, string merge, string concavity,
            string maxVerts, string boxMax, string sphereMax, string capsuleMax)
            {
            ShapeEdColWindow ShapeEdColWindow = "ShapeEdColWindow";

            string colData = ShapeEdColWindow["lastColSettings"];

            var action = this.createAction<ShapeEditorActions.ActionEditCollision>("Edit shape collision");

            action["oldType"] = Util.getField(colData, 0);
            action["oldTarget"] = Util.getField(colData, 1);
            action["oldDepth"] = Util.getField(colData, 2);
            action["oldMerge"] = Util.getField(colData, 3);
            action["oldConcavity"] = Util.getField(colData, 4);
            action["oldMaxVerts"] = Util.getField(colData, 5);
            action["oldBoxMax"] = Util.getField(colData, 6);
            action["oldSphereMax"] = Util.getField(colData, 7);
            action["oldCapsuleMax"] = Util.getField(colData, 8);

            action["newType"] = type;
            action["newTarget"] = target;
            action["newDepth"] = depth;
            action["newMerge"] = merge;
            action["newConcavity"] = concavity;
            action["newMaxVerts"] = maxVerts;
            action["newBoxMax"] = boxMax;
            action["newSphereMax"] = sphereMax;
            action["newCapsuleMax"] = capsuleMax;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Remove Detail

        public void doRemoveDetail(string size)
            {
            var action = this.createAction<ShapeEditorActions.ActionRemoveDetail>("Remove detail level");
            action["size"] = size;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Add/edit imposter
        public void doEditImposter(int dl, string detailSize, string bbEquatorSteps, string bbPolarSteps,
            string bbDetailLevel, string bbDimension, string bbIncludePoles, string bbPolarAngle)
            {
            var action = this.createAction<ShapeEditorActions.ActionEditImposter>("Edit imposter");
            action["oldDL"] = dl.AsString();
            if (action["oldDL"].AsInt() != -1)
                {
                action["oldSize"] = this.shape.getDetailLevelSize(dl).AsString();
                action["oldImposter"] = this.shape.getImposterSettings(dl);
                }
            action["newSize"] = detailSize;
            action["newImposter"] = "1" + '\t' + bbEquatorSteps + '\t' + bbPolarSteps + '\t' + bbDetailLevel + '\t' +
                                    bbDimension + '\t' + bbIncludePoles + '\t' + bbPolarAngle;

            this.doAction(action);
            }

        //------------------------------------------------------------------------------
        // Remove imposter
        [ConsoleInteraction]
        public void doRemoveImposter()
            {
            var action = this.createAction<ShapeEditorActions.ActionRemoveImposter>("Remove imposter");
            int dl = this.shape.getImposterDetailLevel();
            if (dl != -1)
                {
                action["oldSize"] = this.shape.getDetailLevelSize(dl).AsString();
                action["oldImposter"] = this.shape.getImposterSettings(dl);
                this.doAction(action);
                }
            }

        //------------------------------------------------------------------------------
        // Update bounds
        [ConsoleInteraction]
        public void doSetBounds()
            {
            ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            var action = this.createAction<ShapeEditorActions.ActionSetBounds>("Set bounds");
            action["oldBounds"] = this.shape.getBounds().AsString();
            action["newBounds"] = ShapeEdShapeView.computeShapeBounds().AsString();

            this.doAction(action);
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdColWindow>))]
        public class ShapeEdColWindow : GuiContainer
            {
            //------------------------------------------------------------------------------
            // Collision editing
            //------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onWake()
                {
                GuiPopUpMenuCtrl colType = this.FOT("colType");

                colType.clear();
                colType.add("Box");
                colType.add("Sphere");
                colType.add("Capsule");
                colType.add("10-DOP X");
                colType.add("10-DOP Y");
                colType.add("10-DOP Z");
                colType.add("18-DOP");
                colType.add("26-DOP");
                colType.add("Convex Hulls");
                }

            [ConsoleInteraction]
            public void update_onShapeSelectionChanged()
                {
                GuiPopUpMenuCtrl colTarget = this.FOT("colTarget");
                ShapeEditor ShapeEditor = "ShapeEditor";

                this["lastColSettings"] = "" + '\t' + "Bounds";

                // Initialise collision mesh target list
                colTarget.clear();
                colTarget.add("Bounds");
                int objCount = ShapeEditor.shape.getObjectCount();
                for (int i = 0; i < objCount; i++)
                    colTarget.add(ShapeEditor.shape.getObjectName(i));

                colTarget.setSelected(colTarget.findText("Bounds"), false);
                }

            [ConsoleInteraction]
            public void update_onCollisionChanged()
                {
                GuiPopUpMenuCtrl colType = this.FOT("colType");
                GuiPopUpMenuCtrl colTarget = this.FOT("colTarget");
                GuiBitmapCtrl hullInactive = this.FOT("hullInactive");
                GuiSliderCtrl hullDepth = this.FOT("hullDepth");
                GuiSliderCtrl hullMergeThreshold = this.FOT("hullMergeThreshold");
                GuiSliderCtrl hullConcaveThreshold = this.FOT("hullConcaveThreshold");
                GuiSliderCtrl hullMaxBoxError = this.FOT("hullMaxBoxError");
                GuiSliderCtrl hullMaxVerts = this.FOT("hullMaxVerts");
                GuiSliderCtrl hullMaxSphereError = this.FOT("hullMaxSphereError");
                GuiSliderCtrl hullMaxCapsuleError = this.FOT("hullMaxCapsuleError");
                GuiTextCtrl hullDepthText = this.FOT("hullDepthText");
                GuiTextCtrl hullMergeText = this.FOT("hullMergeText");
                GuiTextCtrl hullConcaveText = this.FOT("hullConcaveText");
                GuiTextCtrl hullMaxVertsText = this.FOT("hullMaxVertsText");
                GuiTextCtrl hullMaxBoxErrorText = this.FOT("hullMaxBoxErrorText");
                GuiTextCtrl hullMaxSphereErrorText = this.FOT("hullMaxSphereErrorText");
                GuiTextCtrl hullMaxCapsuleErrorText = this.FOT("hullMaxCapsuleErrorText");

                // Sync collision settings
                string colData = this["lastColSettings"];

                int typeId = colType.findText(Util.getField(colData, 0));
                colType.setSelected(typeId, false);

                int targetId = colTarget.findText(Util.getField(colData, 1));
                colTarget.setSelected(targetId, false);

                if (colType.getText() == "Convex Hulls")
                    {
                    hullInactive.setVisible(false);
                    hullDepth.setValue(Util.getField(colData, 2));
                    hullDepthText.setText(Util.mFloor(hullDepth.getValue()).AsString());
                    hullMergeThreshold.setValue(Util.getField(colData, 3));
                    hullMergeText.setText(Util.mFloor(hullMergeThreshold.getValue()).AsString());
                    hullConcaveThreshold.setValue(Util.getField(colData, 4));
                    hullConcaveText.setText(Util.mFloor(hullConcaveThreshold.getValue()).AsString());
                    hullMaxVerts.setValue(Util.getField(colData, 5));
                    hullMaxVertsText.setText(Util.mFloor(hullMaxVerts.getValue()).AsString());
                    hullMaxBoxError.setValue(Util.getField(colData, 6));
                    hullMaxBoxErrorText.setText(Util.mFloor(hullMaxBoxError.getValue()).AsString());
                    hullMaxSphereError.setValue(Util.getField(colData, 7));
                    hullMaxSphereErrorText.setText(Util.mFloor(hullMaxSphereError.getValue()).AsString());
                    hullMaxCapsuleError.setValue(Util.getField(colData, 8));
                    hullMaxCapsuleErrorText.setText(Util.mFloor(hullMaxCapsuleError.getValue()).AsString());
                    }
                else
                    {
                    hullInactive.setVisible(true);
                    }
                }

            [ConsoleInteraction]
            public void editCollision()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";

                // If the shape already contains a collision detail size-1, warn the user
                // that it will be removed
                if ((ShapeEditor.shape.getDetailLevelIndex(-1) >= 0) &&
                    (Util.getField(this["lastColSettings"], 0) == ""))
                    {
                    messageBox.MessageBoxYesNo("Warning", "Existing collision geometry at detail size " +
                                                          "-1 will be removed, and this cannot be undone. Do you want to continue?",
                        "ShapeEdColWindow.editCollisionOK();", "");
                    }
                else
                    {
                    this.editCollisionOK();
                    }
                }

            [ConsoleInteraction]
            public void editCollisionOK()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiPopUpMenuCtrl colType = this.FOT("colType");
                GuiPopUpMenuCtrl colTarget = this.FOT("colTarget");
                GuiSliderCtrl hullDepth = this.FOT("hullDepth");
                GuiSliderCtrl hullMergeThreshold = this.FOT("hullMergeThreshold");
                GuiSliderCtrl hullConcaveThreshold = this.FOT("hullConcaveThreshold");
                GuiSliderCtrl hullMaxBoxError = this.FOT("hullMaxBoxError");
                GuiSliderCtrl hullMaxVerts = this.FOT("hullMaxVerts");
                GuiSliderCtrl hullMaxSphereError = this.FOT("hullMaxSphereError");
                GuiSliderCtrl hullMaxCapsuleError = this.FOT("hullMaxCapsuleError");

                string type = colType.getText();
                string target = colTarget.getText();
                float depth = hullDepth.getValue();
                float merge = hullMergeThreshold.getValue();
                float concavity = hullConcaveThreshold.getValue();
                float maxVerts = hullMaxVerts.getValue();
                float maxBox = hullMaxBoxError.getValue();
                float maxSphere = hullMaxSphereError.getValue();
                float maxCapsule = hullMaxCapsuleError.getValue();

                ShapeEditor.doEditCollision(type, target, depth.AsString(), merge.AsString(), concavity.AsString(),
                    maxVerts.AsString(),
                    maxBox.AsString(), maxSphere.AsString(), maxCapsule.AsString());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdColWindow ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdColWindow ts, string simobjectid)
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
            public static implicit operator string(ShapeEdColWindow ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdColWindow(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdColWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdColWindow));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdColWindow ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdColWindow(int simobjectid)
                {
                return (ShapeEdColWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdColWindow));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdColWindow ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdColWindow(uint simobjectid)
                {
                return (ShapeEdColWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdColWindow));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdDetailTree>))]
        public class ShapeEdDetailTree : GuiTreeViewCtrl
            {
            [ConsoleInteraction]
            public override void onDefineIcons()
                {
                // Set the tree view icon indices and texture paths
                this["_imageNone"] = "0";
                this["_imageHidden"] = "1";

                string icons = ":" + // no icon
                               "tools/gui/images/visible_i:"; // hidden

                this.buildIconTable(icons);
                }

            // Return true if the item in the details tree view is a detail level (false if
            // a mesh)
            [ConsoleInteraction]
            public bool isDetailItem(int id)
                {
                return (this.getParentItem(id) == 1);
                }

            // Get the detail level index from the ID of an item in the details tree view
            [ConsoleInteraction]
            public int getDetailLevelFromItem(int id)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                string detSize;

                if (this.isDetailItem(id))
                    detSize = this.getItemValue(id);
                else
                    detSize = this.getItemValue(this.getParentItem(id));
                return ShapeEditor.shape.getDetailLevelIndex(detSize.AsInt());
                }

            [ConsoleInteraction]
            public int addMeshEntry(string name, bool noSync)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

                // Add new detail level if required
                int size = Util.getTrailingNumber(name);
                int detailID = this.findItemByValue(size.AsString());
                if (detailID <= 0)
                    {
                    int dl = ShapeEditor.shape.getDetailLevelIndex(size);
                    string detName = ShapeEditor.shape.getDetailLevelName(dl);
                    detailID = this.insertItem(1, detName, size.AsString(), "", 1, 1);

                    // Sort details by decreasing size
                    for (int sibling = this.getPrevSibling(detailID);
                        (sibling > 0) && (this.getItemValue(sibling).AsInt() < size);
                        sibling = this.getPrevSibling(detailID))
                        this.moveItemUp(detailID);

                    if (!noSync)
                        ShapeEdDetails.update_onDetailsChanged();
                    }
                return this.insertItem(detailID, name, "", "", 1, 1);
                }

            [ConsoleInteraction]
            public void removeMeshEntry(string name, int size)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

                size = Util.getTrailingNumber(name);
                int id = this.findItemByName(name);
                if (ShapeEditor.shape.getDetailLevelIndex(size) < 0)
                    {
                    // Last mesh of a detail level has been removed => remove the detail level
                    this.removeItem(this.getParentItem(id));
                    ShapeEdDetails.update_onDetailsChanged();
                    }
                else
                    this.removeItem(id);
                }

            [ConsoleInteraction]
            
            public override void onSelect(string ID, string y)
                {
                int id = ID.AsInt();
                ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiTextEditCtrl meshName = ShapeEdDetails.FOT("meshName");
                GuiTextEditCtrl meshSize = ShapeEdDetails.FOT("meshSize");
                GuiBitmapCtrl editMeshInactive = ShapeEdDetails.FOT("editMeshInactive");
                GuiPopUpMenuCtrl bbType = ShapeEdDetails.FOT("bbType");
                GuiPopUpMenuCtrl objectNode = ShapeEdDetails.FOT("objectNode");

                string name = this.getItemText(id);
                string baseName = Util.stripTrailingNumber(name);
                int size = Util.getTrailingNumber(name);

                meshName.setText(baseName);
                meshSize.setText(size.AsString());

                // Select the appropriate detail level
                int dl = this.getDetailLevelFromItem(id);
                ShapeEdShapeView["currentDL"] = dl.AsString();

                if (this.isDetailItem(id))
                    {
                    // Selected a detail => disable mesh controls
                    editMeshInactive.setVisible(true);
                    ShapeEdShapeView["selectedObject"] = "-1";
                    ShapeEdShapeView["selectedObjDetail"] = "0";
                    }
                else
                    {
                    // Selected a mesh => sync mesh controls
                    editMeshInactive.setVisible(false);

                    switch (ShapeEditor.shape.getMeshType(name))
                        {
                            case "normal":
                                bbType.setSelected(0, false);
                                break;
                            case "billboard":
                                bbType.setSelected(1, false);
                                break;
                            case "billboardzaxis":
                                bbType.setSelected(2, false);
                                break;
                        }

                    string node = ShapeEditor.shape.getObjectNode(baseName);
                    if (node == "")
                        node = "<root>";
                    objectNode.setSelected(objectNode.findText(node), false);
                    ShapeEdShapeView["selectedObject"] = ShapeEditor.shape.getObjectIndex(baseName).AsString();
                    ShapeEdShapeView["selectedObjDetail"] = dl.AsString();
                    }
                }

            [ConsoleInteraction]
            public override void onRightMouseUp(int itemId, string mousePos, SimObject objectx)
                {
                // Open context menu if this is a Mesh item
                MenuBuilder ShapeEdMeshPopup = "ShapeEdMeshPopup";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                GuiCanvas Canvas = "Canvas";

                if (!this.isDetailItem(itemId))
                    {
                    if (!ShapeEdMeshPopup.isObject())
                        {
                        ObjectCreator shapecCreator = new ObjectCreator("PopupMenu", "ShapeEdMeshPopup",
                            typeof (MenuBuilder));
                        shapecCreator["isPopup"] = true.AsString();

                        shapecCreator["item[0]"] = "Hidden" + '\t' + "" + '\t' +
                                                   "ShapeEdDetailTree.onHideMeshItem( ShapeEdMeshPopup._objName, !ShapeEdMeshPopup._itemHidden );";
                        shapecCreator["item[1]"] = "-";
                        shapecCreator["item[2]"] = "Hide all" + '\t' + "" + '\t' +
                                                   "ShapeEdDetailTree.onHideMeshItem( \\\"\\\", true );";
                        shapecCreator["item[3]"] = "Show all" + '\t' + "" + '\t' +
                                                   "ShapeEdDetailTree.onHideMeshItem( \\\"\\\", false );";

                        ShapeEdMeshPopup = shapecCreator.Create();
                        }

                    ShapeEdMeshPopup["_objName"] = Util.stripTrailingNumber(this.getItemText(itemId));
                    ShapeEdMeshPopup["_itemHidden"] =
                        ShapeEdShapeView.getMeshHidden(ShapeEdMeshPopup["_objName"]).AsString();

                    ShapeEdMeshPopup.checkItem(0, ShapeEdMeshPopup["_itemHidden"].AsBool());
                    ShapeEdMeshPopup.showPopup(Canvas);
                    }
                }

            [ConsoleInteraction]
            public void onHideMeshItem(string objName, bool hide)
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

                string imageId;
                if (hide)
                    imageId = this["_imageHidden"];
                else
                    imageId = this["_imageNone"];

                if (objName == "")
                    {
                    // Show/hide all
                    ShapeEdShapeView.setAllMeshesHidden(hide);
                    for (int parent = this.getChild(this.getFirstRootItem());
                        parent > 0;
                        parent = this.getNextSibling(parent
                            ))
                        for (int child = this.getChild(parent);
                            child > 0;
                            child = this.getNextSibling(child))
                            this.setItemImages(child, imageId.AsSbyte(), imageId.AsSbyte());
                    }
                else
                    {
                    // Show/hide all meshes for this object
                    ShapeEdShapeView.setMeshHidden(objName, hide);
                    int count = ShapeEditor.shape.getMeshCount(objName);
                    for (int i = 0; i < count; i++)
                        {
                        string meshName = ShapeEditor.shape.getMeshName(objName, i);
                        int id = ShapeEdDetailTree.findItemByName(meshName);
                        if (id > 0)
                            this.setItemImages(id, imageId.AsSbyte(), imageId.AsSbyte());
                        }
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdDetailTree ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdDetailTree ts, string simobjectid)
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
            public static implicit operator string(ShapeEdDetailTree ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdDetailTree(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdDetailTree) Omni.self.getSimObject(simobjectid, typeof (ShapeEdDetailTree));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdDetailTree ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdDetailTree(int simobjectid)
                {
                return (ShapeEdDetailTree) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdDetailTree));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdDetailTree ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdDetailTree(uint simobjectid)
                {
                return (ShapeEdDetailTree) Omni.self.getSimObject(simobjectid, typeof (ShapeEdDetailTree));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdDetails>))]
        public class ShapeEdDetails : GuiTabPageCtrl
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

                GuiPopUpMenuCtrl bbType = this.FOT("bbType");
                GuiPopUpMenuCtrl addGeomTo = this.FOT("addGeomTo");

                // Initialise popup menus
                bbType.clear();
                bbType.add("None", 0);
                bbType.add("Billboard", 1);
                bbType.add("Z Billboard", 2);

                addGeomTo.clear();
                addGeomTo.add("current detail", 0);
                addGeomTo.add("new detail", 1);
                addGeomTo.setSelected(0, false);

                ShapeEdDetailTree.onDefineIcons();
                }

            [ConsoleInteraction]
            public void update_onDetailsChanged()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiBitmapCtrl imposterInactive = ShapeEdAdvancedWindow.FOT("imposterInactive");
                GuiSliderCtrl detailSlider = ShapeEdAdvancedWindow.FOT("detailSlider");
                GuiCheckBoxCtrl bbUseImposters = ShapeEdAdvancedWindow.FOT("bbUseImposters");
                GuiCheckBoxCtrl bbIncludePoles = ShapeEdAdvancedWindow.FOT("bbIncludePoles");
                GuiTextEditCtrl bbEquatorSteps = ShapeEdAdvancedWindow.FOT("bbEquatorSteps");
                GuiTextEditCtrl bbPolarSteps = ShapeEdAdvancedWindow.FOT("bbPolarSteps");
                GuiTextEditCtrl bbDetailLevel = ShapeEdAdvancedWindow.FOT("bbDetailLevel");
                GuiTextEditCtrl bbDimension = ShapeEdAdvancedWindow.FOT("bbDimension");
                GuiTextEditCtrl bbPolarAngle = ShapeEdAdvancedWindow.FOT("bbPolarAngle");

                int detailCount = ShapeEditor.shape.getDetailLevelCount();
                detailSlider["range"] = "0" + ' ' + (detailCount - 1);
                if (detailCount >= 2)
                    detailSlider["ticks"] = (detailCount - 2).AsString();
                else
                    detailSlider["ticks"] = "0";

                // Initialise imposter settings
                bbUseImposters.setValue((ShapeEditor.shape.getImposterDetailLevel() != -1).AsString());

                // Update detail parameters
                if (ShapeEdShapeView["currentDL"].AsInt() < detailCount)
                    {
                    string settings = ShapeEditor.shape.getImposterSettings(ShapeEdShapeView["currentDL"].AsInt());
                    bool isImposter = Util.getWord(settings, 0).AsBool();

                    imposterInactive.setVisible(!isImposter);

                    bbEquatorSteps.setText(Util.getField(settings, 1));
                    bbPolarSteps.setText(Util.getField(settings, 2));
                    bbDetailLevel.setText(Util.getField(settings, 3));
                    bbDimension.setText(Util.getField(settings, 4));
                    bbIncludePoles.setValue(Util.getField(settings, 5));
                    bbPolarAngle.setText(Util.getField(settings, 6));
                    }
                }

            [ConsoleInteraction]
            public void onEditName()
                {
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiTextEditCtrl meshName = this.FOT("meshName");

                string newName = meshName.getText();

                // Check if we are renaming a detail or a mesh
                int id = ShapeEdDetailTree.getSelectedItem();
                string oldName = ShapeEdDetailTree.getItemText(id);

                if (ShapeEdDetailTree.isDetailItem(id))
                    {
                    // Rename the selected detail level
                    int oldSize = Util.getTrailingNumber(oldName);
                    ShapeEditor.doRenameDetail(oldName, newName + oldSize);
                    }
                else
                    {
                    // Rename the selected mesh
                    ShapeEditor.doRenameObject(Util.stripTrailingNumber(oldName), newName);
                    }
                }

            [ConsoleInteraction]
            public void onEditSize()
                {
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiTextEditCtrl meshSize = this.FOT("meshSize");

                string newSize = meshSize.getText();

                // Check if we are changing the size for a detail or a mesh
                int id = ShapeEdDetailTree.getSelectedItem();
                if (ShapeEdDetailTree.isDetailItem(id))
                    {
                    // Change the size of the selected detail level
                    int oldSize = ShapeEdDetailTree.getItemValue(id).AsInt();
                    ShapeEditor.doEditDetailSize(oldSize, newSize);
                    }
                else
                    {
                    // Change the size of the selected mesh
                    string meshName = ShapeEdDetailTree.getItemText(id);
                    ShapeEditor.doEditMeshSize(meshName, newSize);
                    }
                }

            [ConsoleInteraction]
            public void onEditBBType()
                {
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiPopUpMenuCtrl thisbbType = this.FOT("bbType");

                // This command is only valid for meshes (not details)
                int id = ShapeEdDetailTree.getSelectedItem();
                if (!ShapeEdDetailTree.isDetailItem(id))
                    {
                    string meshName = ShapeEdDetailTree.getItemText(id);
                    string bbType = thisbbType.getText();
                    switch (bbType)
                        {
                            case "None":
                                bbType = "normal";
                                break;
                            case "Billboard":
                                bbType = "billboard";
                                break;
                            case "Z Billboard":
                                bbType = "billboardzaxis";
                                break;
                        }
                    ShapeEditor.doEditMeshBillboard(meshName, bbType);
                    }
                }

            [ConsoleInteraction]
            public void onSetObjectNode()
                {
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiPopUpMenuCtrl objectNode = this.FOT("objectNode");

                // This command is only valid for meshes (not details)
                int id = ShapeEdDetailTree.getSelectedItem();
                if (!ShapeEdDetailTree.isDetailItem(id))
                    {
                    string meshName = ShapeEdDetailTree.getItemText(id);
                    string objName = Util.stripTrailingNumber(meshName);
                    string node = objectNode.getText();
                    if (node == "<root>")
                        node = "";
                    ShapeEditor.doSetObjectNode(objName, node);
                    }
                }

            [ConsoleInteraction]
            public void onAddMeshFromFile(string path)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiPopUpMenuCtrl addGeomTo = this.FOT("addGeomTo");
                int size;

                if (path == "")
                    {
                    WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename("DTS Files|*.dts|COLLADA Files|*.dae|Google Earth Files|*.kmz",
                        this + ".onAddMeshFromFile", this["lastPath"]);
                    return;
                    }

                path = Util.makeRelativePath(path, Util.getMainDotCsDir());
                this["lastPath"] = path;

                // Determine the detail level to use for the new geometry
                if (addGeomTo.getText() == "current detail")
                    {
                    size = ShapeEditor.shape.getDetailLevelSize(ShapeEdShapeView["currentDL"].AsInt());
                    }
                else
                    {
                    // Check if the file has an LODXXX hint at the end of it
                    string basePath = Util.fileBase(path);
                    int pos = Util.strstr(basePath, "_LOD");
                    if (pos > 0)
                        size = (Util.getSubStr(basePath, pos + 4, Util.strlen(basePath)) + 0).AsInt();
                    else
                        size = 2;

                    // Make sure size is not in use
                    while (ShapeEditor.shape.getDetailLevelIndex(size) != -1)
                        size++;
                    }

                ShapeEditor.doAddMeshFromFile(path, size.AsString());
                }

            [ConsoleInteraction]
            public void onDeleteMesh()
                {
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
                ShapeEditor ShapeEditor = "ShapeEditor";

                int id = ShapeEdDetailTree.getSelectedItem();
                if (ShapeEdDetailTree.isDetailItem(id))
                    {
                    string detSize = ShapeEdDetailTree.getItemValue(id);
                    ShapeEditor.doRemoveShapeData("Detail", detSize);
                    }
                else
                    {
                    string name = ShapeEdDetailTree.getItemText(id);
                    ShapeEditor.doRemoveShapeData("Mesh", name);
                    }
                }

            [ConsoleInteraction]
            public void onToggleImposter(bool useImposter)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                bool hasImposterDetail = (ShapeEditor.shape.getImposterDetailLevel() != -1);
                if (useImposter == hasImposterDetail)
                    return;

                if (useImposter)
                    {
                    int detailSize = 0;
                    // Determine an unused detail size
                    for (detailSize = 0; detailSize < 50; detailSize++)
                        {
                        if (ShapeEditor.shape.getDetailLevelIndex(detailSize) == -1)
                            break;
                        }

                    // Set some initial values for the imposter
                    int bbEquatorSteps = 6;
                    int bbPolarSteps = 0;
                    int bbDetailLevel = 0;
                    int bbDimension = 128;
                    int bbIncludePoles = 0;
                    int bbPolarAngle = 0;

                    // Add a new imposter detail level to the shape
                    ShapeEditor.doEditImposter(-1, detailSize.AsString(), bbEquatorSteps.AsString(),
                        bbPolarSteps.AsString(),
                        bbDetailLevel.AsString(), bbDimension.AsString(), bbIncludePoles.AsString(),
                        bbPolarAngle.AsString());
                    }
                else
                    {
                    // Remove the imposter detail level
                    ShapeEditor.doRemoveImposter();
                    }
                }

            [ConsoleInteraction]
            public void onEditImposter()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";

                GuiTextEditCtrl ShapeEdAdvancedWindowbbDimension = ShapeEdAdvancedWindow.FOT("bbDimension");
                GuiTextEditCtrl ShapeEdAdvancedWindowbbDetailLevel = ShapeEdAdvancedWindow.FOT("bbDetailLevel");
                GuiTextEditCtrl ShapeEdAdvancedWindowbbEquatorSteps = ShapeEdAdvancedWindow.FOT("bbEquatorSteps");
                GuiTextEditCtrl ShapeEdAdvancedWindowbbPolarSteps = ShapeEdAdvancedWindow.FOT("bbPolarSteps");
                GuiTextEditCtrl ShapeEdAdvancedWindowbbPolarAngle = ShapeEdAdvancedWindow.FOT("bbPolarAngle");
                GuiCheckBoxCtrl ShapeEdAdvancedWindowbbIncludePoles = ShapeEdAdvancedWindow.FOT("bbIncludePoles");

                // Modify the parameters of the current imposter detail level
                int detailSize = ShapeEditor.shape.getDetailLevelSize(ShapeEdShapeView["currentDL"].AsInt());
                int bbDimension = ShapeEdAdvancedWindowbbDimension.getText().AsInt();
                int bbDetailLevel = ShapeEdAdvancedWindowbbDetailLevel.getText().AsInt();
                int bbEquatorSteps = ShapeEdAdvancedWindowbbEquatorSteps.getText().AsInt();
                int bbIncludePoles = ShapeEdAdvancedWindowbbIncludePoles.getValue().AsInt();
                int bbPolarSteps = ShapeEdAdvancedWindowbbPolarSteps.getText().AsInt();
                int bbPolarAngle = ShapeEdAdvancedWindowbbPolarAngle.getText().AsInt();

                ShapeEditor.doEditImposter(ShapeEdShapeView["currentDL"].AsInt(), detailSize.AsString(),
                    bbEquatorSteps.AsString(), bbPolarSteps.AsString(), bbDetailLevel.AsString(), bbDimension.AsString(),
                    bbIncludePoles.AsString(), bbPolarAngle.AsString());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdDetails ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdDetails ts, string simobjectid)
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
            public static implicit operator string(ShapeEdDetails ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdDetails(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdDetails) Omni.self.getSimObject(simobjectid, typeof (ShapeEdDetails));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdDetails ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdDetails(int simobjectid)
                {
                return (ShapeEdDetails) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdDetails));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdDetails ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdDetails(uint simobjectid)
                {
                return (ShapeEdDetails) Omni.self.getSimObject(simobjectid, typeof (ShapeEdDetails));
                }

            #endregion
            }

        //------------------------------------------------------------------------------
        // Shape Hints
        //------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdHintMenu>))]
        public class ShapeEdHintMenu : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
                ShapeEdSelectWindow.updateHints();
                }

            [ConsoleInteraction]
            public void processHint(string type, string hint)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";

                string name = Util.getField(hint, 0);
                string desc = Util.getField(hint, 1);

                // check for arrayed names (ending in 0-N or 1-N)
                int pos = Util.strstr(name, "0-");
                if (pos == -1)
                    pos = Util.strstr(name, "1-");

                if (pos > 0)
                    {
                    // arrayed name => add controls for each name in the array, but collapse
                    // consecutive indices where possible. eg.  if the model only has nodes
                    // mount1-3, we should create: mount0 (red), mount1-3 (green), mount4-31 (red)
                    string Base = Util.getSubStr(name, 0, pos); // array name
                    int first = Util.getSubStr(name, pos, 1).AsInt(); // first index
                    int last = Util.getSubStr(name, pos + 2, 3).AsInt(); // last index

                    // get the state of the first element
                    int arrayStart = first;
                    bool prevPresent = ShapeEditor.hintNameExists(type, Base + first);

                    for (int j = first + 1; j <= last; j++)
                        {
                        // if the state of this element is different to the previous one, we
                        // need to add a hint
                        bool present = ShapeEditor.hintNameExists(type, Base + j);
                        if (present != prevPresent)
                            {
                            ShapeEdSelectWindow.addObjectHint(type, Base, desc, prevPresent,
                                arrayStart.AsString(), (j - 1).AsString());
                            arrayStart = j;
                            prevPresent = present;
                            }
                        }

                    // add hint for the last group
                    ShapeEdSelectWindow.addObjectHint(type, Base, desc, prevPresent, arrayStart.AsString(),
                        last.AsString());
                    }
                else
                    {
                    // non-arrayed name
                    bool present = ShapeEditor.hintNameExists(type, name);
                    ShapeEdSelectWindow.addObjectHint(type, name, desc, present, "", "");
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdHintMenu ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdHintMenu ts, string simobjectid)
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
            public static implicit operator string(ShapeEdHintMenu ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdHintMenu(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdHintMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdHintMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdHintMenu ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdHintMenu(int simobjectid)
                {
                return (ShapeEdHintMenu) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdHintMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdHintMenu ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdHintMenu(uint simobjectid)
                {
                return (ShapeEdHintMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdHintMenu));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdMaterials>))]
        public class ShapeEdMaterials : GuiTabPageCtrl
            {
            public Material selectedMaterial
                {
                get { return this["selectedMaterial"]; }
                set { this["selectedMaterial"] = value; }
                }

            public TSStatic tempShape
                {
                get { return this["tempShape"]; }
                set { this["tempShape"] = value; }
                }

            [ConsoleInteraction]
            public void updateMaterialList()
                {
                GuiTextListCtrl ShapeEdMaterialList = "ShapeEdMaterialList";
                ShapeEditor ShapeEditor = "ShapeEditor";
                Material WarningMaterial = "WarningMaterial";

                GuiContainer materialListHeader = this.FOT("materialListHeader");

                // --- MATERIALS + '\t' + ---
                ShapeEdMaterialList.clear();
                ShapeEdMaterialList.addRow(-2, "Name" + '\t' + "Mapped", -1);
                ShapeEdMaterialList.setRowActive(-2, false);
                ShapeEdMaterialList.addRow(-1, "<none>", -1);
                int count = ShapeEditor.shape.getTargetCount();
                for (int i = 0; i < count; i++)
                    {
                    string matName = ShapeEditor.shape.getTargetName(i);
                    string mapped = Util.getMaterialMapping(matName);
                    if (mapped == "")
                        ShapeEdMaterialList.addRow(WarningMaterial.getId(), matName + '\t' + "unmapped", -1);
                    else
                        ShapeEdMaterialList.addRow(mapped.getID(), matName + '\t' + mapped, -1);
                    }

                materialListHeader.setExtent(new Point2F( Util.getWord(ShapeEdMaterialList["extent"], 0) + ' ' + "19"));
                }

            [ConsoleInteraction]
            public void updateSelectedMaterial(bool highlight)
                {
                GuiTextListCtrl ShapeEdMaterialList = "ShapeEdMaterialList";

                // Remove the highlight effect from the old selection
                if (this.selectedMaterial.isObject())
                    {
                    this.selectedMaterial.diffuseMap[1] = this["savedMap"].AsTypeImageFilename();
                    this.selectedMaterial.reload();
                    }

                // Apply the highlight effect to the new selected material
                this["selectedMapTo"] =
                    Util.getField(ShapeEdMaterialList.getRowText(ShapeEdMaterialList.getSelectedRow()), 0);
                if (ShapeEdMaterialList.getSelectedId() != -1)
                    {
                    this.selectedMaterial = ShapeEdMaterialList.getSelectedId();
                    this["savedMap"] = this.selectedMaterial.diffuseMap[1];
                    if (highlight && this.selectedMaterial.isObject())
                        {
                        this.selectedMaterial.diffuseMap[1] =
                            "tools/shapeEditor/images/highlight_material".AsTypeImageFilename();
                        this.selectedMaterial.reload();
                        }
                    }
                }

            [ConsoleInteraction]
            public void editSelectedMaterial()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                MaterialEditorPropertiesWindow MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                MaterialEditorPreviewWindow MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui.SubMaterialSelector SubMaterialSelector =
                    "SubMaterialSelector";
                ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                GuiBitmapButtonCtrl MatEd_phoBreadcrumb = "MatEd_phoBreadcrumb";
                GuiRolloutCtrl advancedTextureMapsRollout = "advancedTextureMapsRollout";
                GuiRolloutCtrl materialAnimationPropertiesRollout = "materialAnimationPropertiesRollout";
                GuiRolloutCtrl materialAdvancedPropertiesRollout = "materialAdvancedPropertiesRollout";

                if (this.selectedMaterial.isObject())
                    {
                    // Remove the highlight effect from the selected material, then switch
                    // to the Material Editor
                    this.updateSelectedMaterial(false);

                    // Create a temporary TSStatic so the MaterialEditor can query the model's
                    // materials.
                    Util.pushInstantGroup();
                    ObjectCreator tempCreator = new ObjectCreator("TSStatic");
                    tempCreator["shapeName"] = ShapeEditor.shape["baseShape"];
                    tempCreator["collisionType"] = "None";

                    this.tempShape = tempCreator.Create();
                    Util.popInstantGroup();

                    MaterialEditorGui.currentMaterial = this.selectedMaterial;
                    MaterialEditorGui.currentObject = sGlobal["$Tools::materialEditorList"] = this.tempShape;

                    ShapeEdSelectWindow.setVisible(false);
                    ShapeEdPropWindow.setVisible(false);

                    //      EditorGui-->
                    MaterialEditorPropertiesWindow.setVisible(true);
                    //      EditorGui-->
                    MaterialEditorPreviewWindow.setVisible(true);

                    MatEd_phoBreadcrumb.setVisible(true);
                    MatEd_phoBreadcrumb["command"] = "ShapeEdMaterials.editSelectedMaterialEnd();";

                    advancedTextureMapsRollout["Expanded"] = false.AsString();
                    materialAnimationPropertiesRollout["Expanded"] = false.AsString();
                    materialAdvancedPropertiesRollout["Expanded"] = false.AsString();

                    MaterialEditorGui.open();
                    MaterialEditorGui.setActiveMaterial(this.selectedMaterial);

                    int id = SubMaterialSelector.findText(this["selectedMapTo"]);
                    if (id != -1)
                        SubMaterialSelector.setSelected(id);
                    }
                }

            [ConsoleInteraction]
            public void editSelectedMaterialEnd(bool closeEditor)
                {
                MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                MaterialEditorPropertiesWindow MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
                MaterialEditorPreviewWindow MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
                GuiBitmapButtonCtrl MatEd_phoBreadcrumb = "MatEd_phoBreadcrumb";
                ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                MatEd_phoBreadcrumb.setVisible(false);
                MatEd_phoBreadcrumb["command"] = "";

                MaterialEditorGui.quit();
                //   EditorGui-->
                MaterialEditorPreviewWindow.setVisible(false);
                //   EditorGui-->
                MaterialEditorPropertiesWindow.setVisible(false);

                // Delete the temporary TSStatic
                if (this.tempShape.isObject())
                    this.tempShape.delete();

                if (!closeEditor)
                    {
                    ShapeEdSelectWindow.setVisible(true);
                    ShapeEdPropWindow.setVisible(true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdMaterials ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdMaterials ts, string simobjectid)
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
            public static implicit operator string(ShapeEdMaterials ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMaterials(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdMaterials) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMaterials));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdMaterials ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMaterials(int simobjectid)
                {
                return (ShapeEdMaterials) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdMaterials));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdMaterials ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdMaterials(uint simobjectid)
                {
                return (ShapeEdMaterials) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMaterials));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdMountSeqSlider>))]
        public class ShapeEdMountSeqSlider : GuiSliderCtrl
            {
            [ConsoleInteraction]
            public override void onMouseDragged()
                {
                ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextListCtrl mountList = ShapeEdMountWindow.FOT("mountList");
                GuiBitmapButtonCtrl mountPlayBtn = ShapeEdMountWindow.FOT("mountPlayBtn");

                int row = mountList.getSelectedRow();
                if (row > 0)
                    {
                    ShapeEdShapeView.setMountThreadPos(row - 1, this.getValue());

                    // Pause the sequence when the slider is dragged
                    ShapeEdShapeView.setMountThreadDir(row - 1, 0);
                    mountPlayBtn.setStateOn(false);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdMountSeqSlider ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdMountSeqSlider ts, string simobjectid)
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
            public static implicit operator string(ShapeEdMountSeqSlider ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMountSeqSlider(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdMountSeqSlider) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMountSeqSlider));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdMountSeqSlider ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMountSeqSlider(int simobjectid)
                {
                return
                    (ShapeEdMountSeqSlider) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdMountSeqSlider));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdMountSeqSlider ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdMountSeqSlider(uint simobjectid)
                {
                return (ShapeEdMountSeqSlider) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMountSeqSlider));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdMountShapeMenu>))]
        public class ShapeEdMountShapeMenu : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";

                if (text == "Browse...")
                    {
                    // Allow the user to browse for an external model file
                    WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename("DTS Files|*.dts|COLLADA Files|*.dae|Google Earth Files|*.kmz",
                        this + ".onBrowseSelect", this["lastPath"]);
                    }
                else
                    {
                    // Modify the current mount
                    ShapeEdMountWindow.updateSelectedMount();
                    }
                }

            [ConsoleInteraction]
            public void onBrowseSelect(string path)
                {
                ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";

                path = Util.makeRelativePath(path, Util.getMainDotCsDir());
                this["lastPath"] = path;
                this.setText(path);

                // Add entry if unique
                if (this.findText(path) == -1)
                    this.add(path);

                ShapeEdMountWindow.updateSelectedMount();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdMountShapeMenu ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdMountShapeMenu ts, string simobjectid)
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
            public static implicit operator string(ShapeEdMountShapeMenu ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMountShapeMenu(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdMountShapeMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMountShapeMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdMountShapeMenu ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMountShapeMenu(int simobjectid)
                {
                return
                    (ShapeEdMountShapeMenu) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdMountShapeMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdMountShapeMenu ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdMountShapeMenu(uint simobjectid)
                {
                return (ShapeEdMountShapeMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMountShapeMenu));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdMountWindow>))]
        public class ShapeEdMountWindow : GuiContainer
            {
            internal int mounts
                {
                get { return this["mounts"].AsInt(); }
                set { this["mounts"] = value.AsString(); }
                }

            //------------------------------------------------------------------------------
            // Mounted Shapes
            //------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onWake()
                {
                ShapeEdMountShapeMenu ShapeEdMountShapeMenu = "ShapeEdMountShapeMenu";

                GuiPopUpMenuCtrl mountType = this.FOT("mountType");
                GuiPopUpMenuCtrl mountSeq = this.FOT("mountSeq");
                GuiBitmapButtonCtrl mountPlayBtn = this.FOT("mountPlayBtn");

                mountType.clear();
                mountType.add("Object", 0);
                mountType.add("Image", 1);
                mountType.add("Wheel", 2);
                mountType.setSelected(1, false);

                mountSeq.clear();
                mountSeq.add("<rootpose>", 0);
                mountSeq.setSelected(0, false);
                mountPlayBtn.setStateOn(false);

                // Only add the Browse entry the first time so we keep any files the user has
                // set up previously
                if (ShapeEdMountShapeMenu.size() == 0)
                    {
                    ShapeEdMountShapeMenu.add("Browse...", 0);
                    ShapeEdMountShapeMenu.setSelected(0, false);
                    }
                }

            [ConsoleInteraction]
            public bool isMountableNode(string nodeName)
                {
                return (Util.startsWith(nodeName, "mount", false) || Util.startsWith(nodeName, "hub", false));
                }

            [ConsoleInteraction]
            public void update_onShapeSelectionChanged()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiPopUpMenuCtrl mountNode = this.FOT("mountNode");
                GuiPopUpMenuCtrl mountSeq = this.FOT("mountSeq");

                this.unmountAll();

                // Initialise the dropdown menus
                mountNode.clear();
                mountNode.add("<origin>");
                int count = ShapeEditor.shape.getNodeCount();
                for (int i = 0; i < count; i++)
                    {
                    string name = ShapeEditor.shape.getNodeName(i);
                    if (this.isMountableNode(name))
                        mountNode.add(name);
                    }
                mountNode.sort();
                mountNode.setFirstSelected();

                mountSeq.clear();
                mountSeq.add("<rootpose>", 0);
                mountSeq.setSelected(0, false);
                }

            [ConsoleInteraction]
            public void update_onMountSelectionChanged()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdMountShapeMenu ShapeEdMountShapeMenu = "ShapeEdMountShapeMenu";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                ShapeEdMountSeqSlider ShapeEdMountSeqSlider = "ShapeEdMountSeqSlider";

                GuiTextListCtrl mountList = this.FOT("mountList");
                GuiPopUpMenuCtrl mountNode = this.FOT("mountNode");
                GuiPopUpMenuCtrl mountSeq = this.FOT("mountSeq");
                GuiPopUpMenuCtrl mountType = this.FOT("mountType");
                GuiBitmapButtonCtrl mountPlayBtn = this.FOT("mountPlayBtn");

                int row = mountList.getSelectedRow();
                if (row > 0)
                    {
                    string text = mountList.getRowText(row);
                    string shapePath = Util.getField(text, 0);

                    ShapeEdMountShapeMenu.setText(shapePath);
                    mountNode.setText(Util.getField(text, 2));
                    mountType.setText(Util.getField(text, 3));

                    // Fill in sequence list
                    mountSeq.clear();
                    mountSeq.add("<rootpose>", 0);

                    SimObject tss = ShapeEditor.findConstructor(shapePath);
                    if (!tss.isObject())
                        tss = ShapeEditor.createConstructor(shapePath);
                    if (tss.isObject())
                        {
                        int count = tss.call("getSequenceCount").AsInt();
                        for (int i = 0; i < count; i++)
                            mountSeq.add(tss.call("getSequenceName", i.AsString()));
                        }

                    // Select the currently playing sequence
                    int slot = row - 1;
                    string seq = ShapeEdShapeView.getMountThreadSequence(slot);
                    int id = mountSeq.findText(seq);
                    if (id == -1)
                        id = 0;
                    mountSeq.setSelected(id, false);

                    ShapeEdMountSeqSlider.setValue(ShapeEdShapeView.getMountThreadPos(slot).AsString());
                    mountPlayBtn.setStateOn((int) ShapeEdShapeView.getMountThreadPos(slot) != 0);
                    }
                }

            [ConsoleInteraction]
            public void updateSelectedMount()
                {
                GuiTextListCtrl mountList = this.FOT("mountList");

                int row = mountList.getSelectedRow();
                if (row > 0)
                    this.mountShape(row - 1);
                }

            [ConsoleInteraction]
            public void setMountThreadSequence()
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextListCtrl mountList = this.FOT("mountList");
                GuiPopUpMenuCtrl mountSeq = this.FOT("mountSeq");
                GuiBitmapButtonCtrl mountPlayBtn = this.FOT("mountPlayBtn");

                int row = mountList.getSelectedRow();
                if (row > 0)
                    {
                    ShapeEdShapeView.setMountThreadSequence(row - 1, mountSeq.getText());
                    ShapeEdShapeView.setMountThreadDir(row - 1, mountPlayBtn.getValue().AsFloat());
                    }
                }

            [ConsoleInteraction]
            public void toggleMountThreadPlayback()
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextListCtrl mountList = this.FOT("mountList");
                GuiBitmapButtonCtrl mountPlayBtn = this.FOT("mountPlayBtn");

                int row = mountList.getSelectedRow();
                if (row > 0)
                    ShapeEdShapeView.setMountThreadDir(row - 1, mountPlayBtn.getValue().AsFloat());
                }

            [ConsoleInteraction]
            public void mountShape(int slot)
                {
                ShapeEdMountShapeMenu ShapeEdMountShapeMenu = "ShapeEdMountShapeMenu";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextListCtrl mountList = this.FOT("mountList");
                GuiPopUpMenuCtrl mountNode = this.FOT("mountNode");
                GuiPopUpMenuCtrl mountType = this.FOT("mountType");

                string model = ShapeEdMountShapeMenu.getText();
                string node = mountNode.getText();
                string type = mountType.getText();

                if (model == "Browse...")
                    model = "core/art/shapes/octahedron.dts";

                if (ShapeEdShapeView.mountShape(model, node, type, slot))
                    {
                    int id;
                    string rowText = model + '\t' + Util.fileName(model) + '\t' + node + '\t' + type;
                    if (slot == -1)
                        {
                        id = this.mounts++;
                        mountList.addRow(id, rowText, -1);
                        }
                    else
                        {
                        id = mountList.getRowId(slot + 1);
                        mountList.setRowById(id, rowText);
                        }

                    mountList.setSelectedById(id);
                    }
                else
                    {
                    messageBox.MessageBoxOK("Error",
                        "Failed to mount \"" + model + "\". Check the console for error messages.", "");
                    }
                }

            [ConsoleInteraction]
            public void unmountShape()
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextListCtrl mountList = this.FOT("mountList");

                int row = mountList.getSelectedRow();
                if (row > 0)
                    {
                    ShapeEdShapeView.unmountShape(row - 1);
                    mountList.removeRow(row);

                    // Select the next row (if any)
                    int count = mountList.rowCount();
                    if (row >= count)
                        row = count - 1;
                    if (row > 0)
                        mountList.setSelectedRow(row);
                    }
                }

            [ConsoleInteraction]
            public void unmountAll()
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                GuiTextListCtrl mountList = this.FOT("mountList");

                ShapeEdShapeView.unmountAll();
                mountList.clear();
                mountList.addRow(-1, "FullPath" + '\t' + "Filename" + '\t' + "Node" + '\t' + "Type", -1);
                mountList.setRowActive(-1, false);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdMountWindow ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdMountWindow ts, string simobjectid)
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
            public static implicit operator string(ShapeEdMountWindow ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMountWindow(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdMountWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMountWindow));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdMountWindow ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdMountWindow(int simobjectid)
                {
                return (ShapeEdMountWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdMountWindow));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdMountWindow ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdMountWindow(uint simobjectid)
                {
                return (ShapeEdMountWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdMountWindow));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdNodeParentMenu>))]
        public class ShapeEdNodeParentMenu : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
                ShapeEditor ShapeEditor = "ShapeEditor";

                int selectId = ShapeEdNodeTreeView.getSelectedItem();
                if (selectId > 0)
                    {
                    string name = ShapeEdNodeTreeView.getItemText(selectId);
                    ShapeEditor.doSetNodeParent(name, text);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdNodeParentMenu ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdNodeParentMenu ts, string simobjectid)
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
            public static implicit operator string(ShapeEdNodeParentMenu ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdNodeParentMenu(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdNodeParentMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdNodeParentMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdNodeParentMenu ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdNodeParentMenu(int simobjectid)
                {
                return
                    (ShapeEdNodeParentMenu) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdNodeParentMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdNodeParentMenu ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdNodeParentMenu(uint simobjectid)
                {
                return (ShapeEdNodeParentMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdNodeParentMenu));
                }

            #endregion
            }

        //------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdNodeTreeView>))]
        public class ShapeEdNodeTreeView : GuiTreeViewCtrl
            {
            [ConsoleInteraction]
            public override void onClearSelection()
                {
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

                ShapeEdPropWindow.update_onNodeSelectionChanged(-1);
                }

            [ConsoleInteraction]
            public override void onSelect(string ID, string y)
                {
                int id = ID.AsInt();
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                // Update the node name and transform controls
                ShapeEdPropWindow.update_onNodeSelectionChanged(id);

                // Update orbit position if orbiting the selected node
                if (ShapeEdShapeView["orbitNode"].AsBool())
                    {
                    string name = this.getItemText(id);
                    string transform = ShapeEditor.shape.getNodeTransform(name, true).AsString();
                    ShapeEdShapeView.setOrbitPos(Util.getWords(transform, 0, 2).AsPoint3F());
                    }
                }

            // Determine the index of a node in the tree relative to its parent
            [ConsoleInteraction]
            public int getChildIndexByName(string name)
                {
                int id = this.findItemByName(name);
                int parentId = this.getParentItem(id);
                int childId = this.getChild(parentId);
                if (childId <= 0)
                    return 0; // bad!

                int index = 0;
                while (childId != id)
                    {
                    childId = this.getNextSibling(childId);
                    index++;
                    }

                return index;
                }

            // Add a node and its children to the node tree view
            [ConsoleInteraction]
            public int addNodeTree(string nodeName)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";

                // Abort if already added => something dodgy has happened and we'd end up
                // recursing indefinitely
                if (this.findItemByName(nodeName) != 0)
                    {
                    Util._error("Recursion error in ShapeEdNodeTreeView::addNodeTree");
                    return 0;
                    }

                // Find parent and add me to it
                string parentName = ShapeEditor.shape.getNodeParentName(nodeName);
                if (parentName == "")
                    parentName = "<root>";

                int parentId = this.findItemByName(parentName);
                int id = this.insertItem(parentId, nodeName, "0", "", 1, 1);

                // Add children
                int count = ShapeEditor.shape.getNodeChildCount(nodeName);
                for (int i = 0; i < count; i++)
                    this.addNodeTree(ShapeEditor.shape.getNodeChildName(nodeName, i));

                return id;
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdNodeTreeView ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdNodeTreeView ts, string simobjectid)
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
            public static implicit operator string(ShapeEdNodeTreeView ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdNodeTreeView(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdNodeTreeView) Omni.self.getSimObject(simobjectid, typeof (ShapeEdNodeTreeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdNodeTreeView ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdNodeTreeView(int simobjectid)
                {
                return (ShapeEdNodeTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdNodeTreeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdNodeTreeView ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdNodeTreeView(uint simobjectid)
                {
                return (ShapeEdNodeTreeView) Omni.self.getSimObject(simobjectid, typeof (ShapeEdNodeTreeView));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdNodes>))]
        public class ShapeEdNodes : GuiTabPageCtrl
            {
            [ConsoleInteraction]
            public void onAddNode(string name)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";

                // Add a new node, using the currently selected node as the initial parent
                if (name == "")
                    name = ShapeEditor.getUniqueName("node", "myNode");

                int id = ShapeEdNodeTreeView.getSelectedItem();
                string parent = "";
                if (id <= 0)
                    parent = "";
                else
                    parent = ShapeEdNodeTreeView.getItemText(id);

                ShapeEditor.doAddNode(name, parent, "0 0 0 0 0 1 0");
                }

            [ConsoleInteraction]
            public void onDeleteNode()
                {
                ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
                ShapeEditor ShapeEditor = "ShapeEditor";

                // Remove the node and all its children from the shape
                int id = ShapeEdNodeTreeView.getSelectedItem();
                if (id > 0)
                    {
                    string name = ShapeEdNodeTreeView.getItemText(id);
                    ShapeEditor.doRemoveShapeData("Node", name);
                    }
                }

            [ConsoleInteraction]
            public void onEditName()
                {
                ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
                GuiTextEditCtrl nodeName = FOT("nodeName");
                ShapeEditor ShapeEditor = "ShapeEditor";

                int id = ShapeEdNodeTreeView.getSelectedItem();
                if (id > 0)
                    {
                    string oldName = ShapeEdNodeTreeView.getItemText(id);
                    string newName = nodeName.getText();
                    if (newName != "")
                        ShapeEditor.doRenameNode(oldName, newName);
                    }
                }

            [ConsoleInteraction]
            public void onEditTransform()
                {
                ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiTextEditCtrl nodePosition = this.FOT("nodePosition");
                GuiTextEditCtrl nodeRotation = this.FOT("nodeRotation");
                GuiIconButtonCtrl worldTransform = this.FOT("worldTransform");

                int id = ShapeEdNodeTreeView.getSelectedItem();
                if (id > 0)
                    {
                    string name = ShapeEdNodeTreeView.getItemText(id);

                    // Get the node transform from the gui
                    string pos = nodePosition.getText();
                    string rot = nodeRotation.getText();
                    string txfm = pos + ' ' + rot;
                    bool isWorld = worldTransform.getValue().AsBool();

                    // Do a quick sanity check to avoid setting wildly invalid transforms
                    for (int i = 0; i < 7; i++) // "x y z aa.x aa.y aa.z aa.angle"
                        {
                        if (Util.getWord(txfm, i) == "")
                            return;
                        }

                    ShapeEditor.doEditNodeTransform(name, txfm, isWorld, "-1");
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdNodes ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdNodes ts, string simobjectid)
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
            public static implicit operator string(ShapeEdNodes ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdNodes(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdNodes) Omni.self.getSimObject(simobjectid, typeof (ShapeEdNodes));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdNodes ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdNodes(int simobjectid)
                {
                return (ShapeEdNodes) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdNodes));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdNodes ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdNodes(uint simobjectid)
                {
                return (ShapeEdNodes) Omni.self.getSimObject(simobjectid, typeof (ShapeEdNodes));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdPreviewGui>))]
        public class ShapeEdPreviewGui : GuiContainer
            {
            //------------------------------------------------------------------------------
            // Shape Preview
            //------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void updatePreviewBackground(string color)
                {
                ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";

                GuiSwatchButtonCtrl previewBackground = this.FOT("previewBackground");
                GuiSwatchButtonCtrl previewBackgroundPicker = ShapeEditorToolbar.FOT("previewBackgroundPicker");

                previewBackground["color"] = color;
                previewBackgroundPicker["color"] = color;
                }

            [ConsoleInteraction]
            public static void showShapeEditorPreview()
                {
                ShapeEditorToolbar ShapeEditorToolbar = "ShapeEditorToolbar";
                ShapeEdPreviewGui ShapeEdPreviewGui = "ShapeEdPreviewGui";

                GuiCheckBoxCtrl showPreview = ShapeEditorToolbar.FOT("showPreview");

                bool visible = showPreview.getValue().AsBool();
                ShapeEdPreviewGui.setVisible(visible);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdPreviewGui ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdPreviewGui ts, string simobjectid)
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
            public static implicit operator string(ShapeEdPreviewGui ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdPreviewGui(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdPreviewGui) Omni.self.getSimObject(simobjectid, typeof (ShapeEdPreviewGui));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdPreviewGui ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdPreviewGui(int simobjectid)
                {
                return (ShapeEdPreviewGui) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdPreviewGui));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdPreviewGui ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdPreviewGui(uint simobjectid)
                {
                return (ShapeEdPreviewGui) Omni.self.getSimObject(simobjectid, typeof (ShapeEdPreviewGui));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSelectMenu>))]
        public class ShapeEdSelectMenu : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
                string split = Util.strreplace(text, "/", " ");
                ShapeEdSelectWindow.navigate(split);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdSelectMenu ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdSelectMenu ts, string simobjectid)
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
            public static implicit operator string(ShapeEdSelectMenu ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSelectMenu(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdSelectMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSelectMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdSelectMenu ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSelectMenu(int simobjectid)
                {
                return (ShapeEdSelectMenu) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSelectMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdSelectMenu ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdSelectMenu(uint simobjectid)
                {
                return (ShapeEdSelectMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSelectMenu));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSeqFromMenu>))]
        public class ShapeEdSeqFromMenu : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";

                if (text == "Browse...")
                    {
                    // Reset menu text
                    string seqName = ShapeEdSequenceList.getSelectedName();
                    string seqFrom = Util.rtrim(Util.getFields(ShapeEditor.getSequenceSource(seqName), 0, 1));
                    this.setText(seqFrom);

                    // Allow the user to browse for an external source of animation data
                    WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename("DSQ Files|*.dsq|COLLADA Files|*.dae|Google Earth Files|*.kmz",
                        this + ".onBrowseSelect",
                        this["lastPath"]);
                    }
                else
                    {
                    ShapeEdSequences.onEditSequenceSource(text);
                    }
                }

            [ConsoleInteraction]
            public void onBrowseSelect(string path)
                {
                ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";

                path = Util.makeRelativePath(path, Util.getMainDotCsDir());
                this["lastPath"] = path;
                this.setText(path);
                ShapeEdSequences.onEditSequenceSource(path);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdSeqFromMenu ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdSeqFromMenu ts, string simobjectid)
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
            public static implicit operator string(ShapeEdSeqFromMenu ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqFromMenu(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdSeqFromMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSeqFromMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdSeqFromMenu ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqFromMenu(int simobjectid)
                {
                return (ShapeEdSeqFromMenu) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSeqFromMenu));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdSeqFromMenu ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqFromMenu(uint simobjectid)
                {
                return (ShapeEdSeqFromMenu) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSeqFromMenu));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSeqNodeTabBook>))]
        public class ShapeEdSeqNodeTabBook : GuiTabBookCtrl
            {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
                {
                ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
                GuiBitmapButtonCtrl newBtn = ShapeEdPropWindow.FOT("newBtn");
                GuiBitmapButtonCtrl deleteBtn = ShapeEdPropWindow.FOT("deleteBtn");
                ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
                GuiContainer materialListHeader = ShapeEdMaterials.FOT("materialListHeader");
                GuiTextListCtrl ShapeEdMaterialList = "ShapeEdMaterialList";

                this["activePage"] = text;

                switch (text)
                    {
                        case "Seq":
                            newBtn["ToolTip"] = "Add new sequence";
                            newBtn["Command"] = "ShapeEdSequences.onAddSequence();";
                            newBtn.setActive(true);
                            deleteBtn["ToolTip"] = "Delete selected sequence (cannot be undone)";
                            deleteBtn["Command"] = "ShapeEdSequences.onDeleteSequence();";
                            deleteBtn.setActive(true);
                            break;

                        case "Node":
                            newBtn["ToolTip"] = "Add new node";
                            newBtn["Command"] = "ShapeEdNodes.onAddNode();";
                            newBtn.setActive(true);
                            deleteBtn["ToolTip"] = "Delete selected node (cannot be undone)";
                            deleteBtn["Command"] = "ShapeEdNodes.onDeleteNode();";
                            deleteBtn.setActive(true);
                            break;

                        case "Detail":
                            newBtn["ToolTip"] = "";
                            newBtn["Command"] = "";
                            newBtn.setActive(false);
                            deleteBtn["ToolTip"] = "Delete the selected mesh or detail level (cannot be undone)";
                            deleteBtn["Command"] = "ShapeEdDetails.onDeleteMesh();";
                            deleteBtn.setActive(true);
                            break;

                        case "Mat":
                            newBtn["ToolTip"] = "";
                            newBtn["Command"] = "";
                            newBtn.setActive(false);
                            deleteBtn["ToolTip"] = "";
                            deleteBtn["Command"] = "";
                            deleteBtn.setActive(false);

                            // For some reason, the header is not resized correctly until the Materials + '\t' + has been
                            // displayed at least once, so resize it here too
                            materialListHeader.setExtent(new Point2F( Util.getWord(ShapeEdMaterialList["extent"], 0) + ' ' + "19"));
                            break;
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdSeqNodeTabBook ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdSeqNodeTabBook ts, string simobjectid)
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
            public static implicit operator string(ShapeEdSeqNodeTabBook ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqNodeTabBook(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdSeqNodeTabBook) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSeqNodeTabBook));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdSeqNodeTabBook ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqNodeTabBook(int simobjectid)
                {
                return
                    (ShapeEdSeqNodeTabBook) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSeqNodeTabBook));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdSeqNodeTabBook ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqNodeTabBook(uint simobjectid)
                {
                return (ShapeEdSeqNodeTabBook) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSeqNodeTabBook));
                }

            #endregion
            }

        //------------------------------------------------------------------------------
        // Threads and Animation
        //------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSeqSlider>))]
        public class ShapeEdSeqSlider : GuiSliderCtrl
            {
            [ConsoleInteraction]
            public override void onMouseDragged()
                {
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
                GuiBitmapButtonCtrl pauseBtn = ShapeEdAnimWindow.FOT("pauseBtn");

                // Pause the active thread when the slider is dragged
                if (pauseBtn.getValue().AsInt() == 0)
                    pauseBtn.performClick();

                ShapeEdAnimWindow.setKeyframe(this.getValue());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdSeqSlider ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdSeqSlider ts, string simobjectid)
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
            public static implicit operator string(ShapeEdSeqSlider ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqSlider(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdSeqSlider) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSeqSlider));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdSeqSlider ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqSlider(int simobjectid)
                {
                return (ShapeEdSeqSlider) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSeqSlider));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdSeqSlider ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdSeqSlider(uint simobjectid)
                {
                return (ShapeEdSeqSlider) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSeqSlider));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSequenceList>))]
        public class ShapeEdSequenceList : GuiTextListCtrl
            {
            // Get the name of the currently selected sequence
            [ConsoleInteraction]
            public string getSelectedName()
                {
                int row = this.getSelectedRow();
                return (row > 1) ? this.getItemName(row) : ""; // ignore header row
                }

            // Get the sequence name from the indexed row
            [ConsoleInteraction]
            public string getItemName(int row)
                {
                return Util.getField(this.getRowText(row), 0);
                }

            // Get the index in the list of the sequence with the given name
            [ConsoleInteraction]
            public int getItemIndex(string name)
                {
                for (int i = 1; i < this.rowCount(); i++) // ignore header row
                    {
                    if (this.getItemName(i) == name)
                        return i;
                    }
                return -1;
                }

            // Change one of the fields in the sequence list
            [ConsoleInteraction]
            public void editColumn(string name, int col, string text)
                {
                ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
                GuiTextListCtrl seqList = ShapeEdThreadWindow.FOT("seqList");

                int row = this.getItemIndex(name);
                string rowText = Util.setField(this.getRowText(row), col, text);

                // Update the Properties and Thread sequence lists
                int id = this.getRowId(row);
                if (col == 0)
                    seqList.setRowById(id, text); // Sync name in Thread window
                this.setRowById(id, rowText);
                }

            [ConsoleInteraction]
            public int addItem(string name)
                {
                return this.insertItem(name, this.rowCount());
                }

            [ConsoleInteraction]
            public int insertItem(string name, int index)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";

                GuiTextListCtrl seqList = ShapeEdThreadWindow.FOT("seqList");
                string cyclic = ShapeEditor.shape.getSequenceCyclic(name) ? "yes" : "no";
                string blend = Util.getField(ShapeEditor.shape.getSequenceBlend(name), 0).AsBool()
                    ? "yes"
                    : "no";
                int frameCount = ShapeEditor.shape.getSequenceFrameCount(name);
                string priority = ShapeEditor.shape.getSequencePriority(name).AsString();

                // Add the item to the Properties and Thread sequence lists
                this["seqId"] = ((this["seqId"]).AsInt() + 1).AsString(); // use this to keep the row IDs synchronised
                seqList.addRow(this["seqId"].AsInt(), name, index - 1); // no header row
                return this.addRow(this["seqId"].AsInt(),
                    name + '\t' + cyclic + '\t' + blend + '\t' + frameCount + '\t' + priority, index);
                }

            [ConsoleInteraction]
            public void removeItem(string name)
                {
                ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";

                GuiTextListCtrl seqList = ShapeEdThreadWindow.FOT("seqList");

                int index = this.getItemIndex(name);
                if (index >= 0)
                    {
                    this.removeRow(index);
                    seqList.removeRow(index - 1); // no header row
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdSequenceList ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdSequenceList ts, string simobjectid)
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
            public static implicit operator string(ShapeEdSequenceList ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSequenceList(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdSequenceList) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSequenceList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdSequenceList ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSequenceList(int simobjectid)
                {
                return (ShapeEdSequenceList) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSequenceList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdSequenceList ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdSequenceList(uint simobjectid)
                {
                return (ShapeEdSequenceList) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSequenceList));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSequences>))]
        public class ShapeEdSequences : GuiTabPageCtrl
            {
            [ConsoleInteraction]
            public void onEditSeqInOut(string type, string value)
                {
                GuiTextEditCtrl endFrame = this.FOT("endFrame");
                GuiTextEditCtrl startFrame = this.FOT("startFrame");
                ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";

                int frameCount = Util.getWord(ShapeEdSeqSlider["range"], 1).AsInt();

                // Force value to a frame index within the slider range
                float val = value.AsFloat();
                val = Util.mRound(val);
                if (val < 0)
                    val = 0;
                if (val > frameCount)
                    val = frameCount;

                // Enforce 'in' value must be < 'out' value
                if (type == "in")
                    {
                    if (val >= endFrame.getText().AsInt())
                        val = endFrame.getText().AsInt() - 1;
                    startFrame.setText(val.AsString());
                    }
                else
                    {
                    if (val <= startFrame.getText().AsInt())
                        val = startFrame.getText().AsInt() + 1;
                    endFrame.setText(val.AsString());
                    }

                this.onEditSequenceSource("");
                }

            [ConsoleInteraction]
            public void onEditSequenceSource(string from)
                {
                GuiTextEditCtrl endFrame = this.FOT("endFrame");
                GuiTextEditCtrl startFrame = this.FOT("startFrame");
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";

                // ignore for shapes without sequences
                if (ShapeEditor.shape.getSequenceCount() == 0)
                    return;

                string start = startFrame.getText();
                string end = endFrame.getText();

                if ((start != "") && (end != ""))
                    {
                    string seqName = ShapeEdSequenceList.getSelectedName();
                    string oldSource = ShapeEditor.getSequenceSource(seqName);

                    if (from == "")
                        from = Util.rtrim(Util.getFields(oldSource, 0, 0));

                    if (Util.getFields(oldSource, 0, 3) != (from + '\t' + "" + '\t' + start + '\t' + end))
                        ShapeEditor.doEditSeqSource(seqName, from, start, end);
                    }
                }

            [ConsoleInteraction]
            public void onToggleCyclic()
                {
                GuiCheckBoxCtrl cyclicFlag = this.FOT("cyclicFlag");
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEditor ShapeEditor = "ShapeEditor";

                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    string cyclic = cyclicFlag.getValue();
                    ShapeEditor.doEditCyclic(seqName, cyclic);
                    }
                }

            [ConsoleInteraction]
            public void onEditPriority()
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiTextEditCtrl priority = this.FOT("priority");

                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    string newPriority = priority.getText();
                    if (newPriority != "")
                        ShapeEditor.doEditSequencePriority(seqName, newPriority);
                    }
                }

            [ConsoleInteraction]
            public void onEditBlend()
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiCheckBoxCtrl blendFlag = this.FOT("blendFlag");
                GuiPopUpMenuCtrl blendSeq = this.FOT("blendSeq");
                GuiTextEditCtrl blendFrame = this.FOT("blendFrame");

                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    // Get the blend flags (current and new)
                    string oldBlendData = ShapeEditor.shape.getSequenceBlend(seqName);
                    string oldBlend = Util.getField(oldBlendData, 0);
                    bool blend = blendFlag.getValue().AsBool();

                    // Ignore changes to the blend reference for non-blend sequences
                    if (!oldBlend.AsBool() && !blend)
                        return;

                    // OK - we're trying to change the blend properties of this sequence. The
                    // new reference sequence and frame must be set.
                    blendSeq = blendSeq.getText();
                    blendFrame = blendFrame.getText();
                    if ((blendSeq == "") || (blendFrame == ""))
                        {
                        messageBox.MessageBoxOK("Blend reference not set", "The blend reference sequence and " +
                                                                           "frame must be set before changing the blend flag or frame.");
                        blendFlag.setStateOn(oldBlend.AsBool());
                        return;
                        }

                    // Get the current blend properties (use new values if not specified)
                    string oldBlendSeq = Util.getField(oldBlendData, 1);
                    if (oldBlendSeq == "")
                        oldBlendSeq = blendSeq;
                    string oldBlendFrame = Util.getField(oldBlendData, 2);
                    if (oldBlendFrame == "")
                        oldBlendFrame = blendFrame;

                    // Check if there is anything to do
                    if ((oldBlend + '\t' + oldBlendSeq + '\t' + oldBlendFrame) !=
                        (blend.AsString() + '\t' + blendSeq + '\t' + blendFrame))
                        ShapeEditor.doEditBlend(seqName, blend.AsString(), blendSeq, blendFrame);
                    }
                }

            [ConsoleInteraction]
            public void onAddSequence(string name)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEdSeqFromMenu ShapeEdSeqFromMenu = "ShapeEdSeqFromMenu";

                GuiTextEditCtrl endFrame = this.FOT("endFrame");
                GuiTextEditCtrl startFrame = this.FOT("startFrame");

                if (name == "")
                    name = ShapeEditor.getUniqueName("sequence", "mySequence");

                // Use the currently selected sequence as the base
                string from = ShapeEdSequenceList.getSelectedName();
                int row = ShapeEdSequenceList.getSelectedRow();
                if ((row < 2) && (ShapeEdSequenceList.rowCount() > 2))
                    row = 2;
                if (from == "")
                    {
                    // No sequence selected => open dialog to browse for one
        WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename("DSQ Files|*.dsq|COLLADA Files|*.dae|Google Earth Files|*.kmz",
                        this + ".onAddSequenceFromBrowse", ShapeEdSeqFromMenu["lastPath"]);
                    return;
                    }
                else
                    {
                    // Add the new sequence
                    string start = startFrame.getText();
                    string end = endFrame.getText();
                    ShapeEditor.doAddSequence(name, from, start, end);
                    }
                }

            [ConsoleInteraction]
            public void onAddSequenceFromBrowse(string path)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSeqFromMenu ShapeEdSeqFromMenu = "ShapeEdSeqFromMenu";

                // Add a new sequence from the browse path
                path = Util.makeRelativePath(path, Util.getMainDotCsDir());
                ShapeEdSeqFromMenu["lastPath"] = path;

                string name = ShapeEditor.getUniqueName("sequence", "mySequence");
                ShapeEditor.doAddSequence(name, path, "0", "-1");
                }

            // Delete the selected sequence
            [ConsoleInteraction]
            public void onDeleteSequence()
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";

                int row = ShapeEdSequenceList.getSelectedRow();
                if (row != -1)
                    {
                    string seqName = ShapeEdSequenceList.getItemName(row);
                    ShapeEditor.doRemoveShapeData("Sequence", seqName);
                    }
                }

            [ConsoleInteraction]
            public void onEditName()
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                GuiTextEditCtrl sequenceName = this.FOT("seqName");

                ShapeEditor ShapeEditor = "ShapeEditor";

                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    string newName = sequenceName.getText();
                    if (newName != "")
                        ShapeEditor.doRenameSequence(seqName, newName);
                    }
                }

            [ConsoleInteraction]
            public void onAddTrigger()
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";
                ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";
                ShapeEditor ShapeEditor = "ShapeEditor";

                // Can only add triggers if a sequence is selected
                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    // Add a new trigger at the current frame
                    int frame =(int) Util.mRound(ShapeEdSeqSlider.getValue());
                    float state = ShapeEdTriggerList.rowCount()%30;
                    ShapeEditor.doAddTrigger(seqName, frame.AsString(), state.AsString());
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdSequences ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdSequences ts, string simobjectid)
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
            public static implicit operator string(ShapeEdSequences ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSequences(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdSequences) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSequences));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdSequences ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdSequences(int simobjectid)
                {
                return (ShapeEdSequences) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSequences));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdSequences ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdSequences(uint simobjectid)
                {
                return (ShapeEdSequences) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSequences));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdShapeTreeView>))]
        public class ShapeEdShapeTreeView : GuiTreeViewCtrl
            {
            // Handle a selection in the MissionGroup shape selector
            [ConsoleInteraction]
            public override void onSelect(string obj, string y)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
                SimGroup ShapeHintGroup = "ShapeHintGroup";
                ShapeEdHintMenu ShapeEdHintMenu = "ShapeEdHintMenu";

                string path = ShapeEditor.getObjectShapeFile(obj);
                if (path != "")
                    ShapeEdSelectWindow.onSelect(path);

                // Set the object type (for required nodes and sequences display)
                string objClass = obj.call("getClassName");
                int hintId = -1;

                int count = ShapeHintGroup.getCount();
                for (uint i = 0; i < count; i++)
                    {
                    SimObject hint = ShapeHintGroup.getObject(i);
                    if (objClass == hint["objectType"])
                        {
                        hintId = hint;
                        break;
                        }
                    else if (Util.isMemberOfClass(objClass, hint["objectType"]))
                        {
                        hintId = hint;
                        }
                    }
                ShapeEdHintMenu.setSelected(hintId);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdShapeTreeView ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdShapeTreeView ts, string simobjectid)
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
            public static implicit operator string(ShapeEdShapeTreeView ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdShapeTreeView(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdShapeTreeView) Omni.self.getSimObject(simobjectid, typeof (ShapeEdShapeTreeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdShapeTreeView ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdShapeTreeView(int simobjectid)
                {
                return (ShapeEdShapeTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdShapeTreeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdShapeTreeView ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdShapeTreeView(uint simobjectid)
                {
                return (ShapeEdShapeTreeView) Omni.self.getSimObject(simobjectid, typeof (ShapeEdShapeTreeView));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdShapeView>))]
        public class ShapeEdShapeView : GuiShapeEdPreview
            {
            [ConsoleInteraction]
            public override void onNodeSelected(string index)
                {
                ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
                ShapeEditor ShapeEditor = "ShapeEditor";

                ShapeEdNodeTreeView.clearSelection();
                if (index.AsInt() > 0)
                    {
                    string name = ShapeEditor.shape.getNodeName(index.AsInt());
                    int id = ShapeEdNodeTreeView.findItemByName(name);
                    if (id > 0)
                        ShapeEdNodeTreeView.selectItem(id);
                    }
                }

            [ConsoleInteraction]
            public override void onEditNodeTransform(string node, string txfm, string gizmoID)
                {
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEditor.doEditNodeTransform(node, txfm, true, gizmoID);
                }

            [ConsoleInteraction]
            public override void onThreadPosChanged(float pos, bool inTransition)
                {
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
                ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";
                ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
                ShapeEdThreadSlider ShapeEdThreadSlider = "ShapeEdThreadSlider";

                GuiPopUpMenuCtrl transitionTo = ShapeEdThreadWindow.FOT("transitionTo");

                // Update sliders
                float frame = ShapeEdAnimWindow.threadPosToKeyframe(pos);
                ShapeEdSeqSlider.setValue(frame, true);

                if (transitionTo.getText() == "synched position")
                    {
                    ShapeEdThreadSlider.setValue(frame, true);

                    // Highlight the slider during transitions
                    if (inTransition)
                        ShapeEdThreadSlider["profile"] = "GuiShapeEdTransitionSliderProfile";
                    else
                        ShapeEdThreadSlider["profile"] = "ToolsGuiSliderProfile";
                    }
                }

            [ConsoleInteraction]
            public void onDetailChanged()
                {
                ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
                ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
                ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

                GuiSliderCtrl detailSlider = ShapeEdAdvancedWindow.FOT("detailSlider");
                GuiTextEditCtrl detailSize = ShapeEdAdvancedWindow.FOT("detailSize");

                // Update slider
                if (Util.mRound(detailSlider.getValue()) != this["currentDL"].AsInt())
                    detailSlider.setValue(this["currentDL"]);
                detailSize.setText(this["detailSize"]);

                ShapeEdDetails.update_onDetailsChanged();

                int id = ShapeEdDetailTree.getSelectedItem();
                if ((id <= 0) || (this["currentDL"].AsInt() != ShapeEdDetailTree.getDetailLevelFromItem(id)))
                    {
                    id = ShapeEdDetailTree.findItemByValue(this["detailSize"]);
                    if (id > 0)
                        {
                        ShapeEdDetailTree.clearSelection();
                        ShapeEdDetailTree.selectItem(id);
                        }
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdShapeView ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdShapeView ts, string simobjectid)
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
            public static implicit operator string(ShapeEdShapeView ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdShapeView(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdShapeView) Omni.self.getSimObject(simobjectid, typeof (ShapeEdShapeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdShapeView ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdShapeView(int simobjectid)
                {
                return (ShapeEdShapeView) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdShapeView));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdShapeView ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdShapeView(uint simobjectid)
                {
                return (ShapeEdShapeView) Omni.self.getSimObject(simobjectid, typeof (ShapeEdShapeView));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdThreadList>))]
        public class ShapeEdThreadList : GuiTextListCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string row, string text)
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                ShapeEditor ShapeEditor = "ShapeEditor";
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";

                GuiBitmapButtonCtrl pauseBtn = ShapeEdAnimWindow.FOT("pauseBtn");
                GuiBitmapButtonCtrl playBkwdBtn = ShapeEdAnimWindow.FOT("playBkwdBtn");
                GuiBitmapButtonCtrl playFwdBtn = ShapeEdAnimWindow.FOT("playFwdBtn");
                GuiBitmapButtonCtrl pingpong = ShapeEdAnimWindow.FOT("pingpong");

                ShapeEdShapeView["activeThread"] = this.getSelectedRow().AsString();

                // Select the active thread's sequence in the list
                string seqName = ShapeEdShapeView.getThreadSequence();
                if (seqName == "")
                    seqName = "<rootpose>";
                else if (Util.startsWith(seqName, "__proxy__", true))
                    seqName = ShapeEditor.getUnproxyName(seqName);

                int seqIndex = ShapeEdSequenceList.getItemIndex(seqName);
                ShapeEdSequenceList.setSelectedRow(seqIndex);

                // Update the playback controls
                switch (ShapeEdShapeView.threadDirection)
                    {
                        case -1:
                            playBkwdBtn.performClick();
                            break;
                        case 0:
                            pauseBtn.performClick();
                            break;
                        case 1:
                            playFwdBtn.performClick();
                            break;
                    }
                console.Call("SetToggleButtonValue", new string[] {pingpong, ShapeEdShapeView["threadPingPong"]});
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdThreadList ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdThreadList ts, string simobjectid)
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
            public static implicit operator string(ShapeEdThreadList ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadList(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdThreadList) Omni.self.getSimObject(simobjectid, typeof (ShapeEdThreadList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdThreadList ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadList(int simobjectid)
                {
                return (ShapeEdThreadList) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdThreadList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdThreadList ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadList(uint simobjectid)
                {
                return (ShapeEdThreadList) Omni.self.getSimObject(simobjectid, typeof (ShapeEdThreadList));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdThreadSlider>))]
        public class ShapeEdThreadSlider : GuiSliderCtrl
            {
            [ConsoleInteraction]
            public override void onMouseDragged()
                {
                ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
                GuiPopUpMenuCtrl transitionTo = ShapeEdThreadWindow.FOT("transitionTo");

                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
                GuiBitmapButtonCtrl pauseBtn = ShapeEdAnimWindow.FOT("pauseBtn");

                if (transitionTo.getText() == "synched position")
                    {
                    // Pause the active thread when the slider is dragged
                    if (pauseBtn.getValue().AsInt() == 0)
                        pauseBtn.performClick();

                    ShapeEdAnimWindow.setKeyframe(this.getValue());
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdThreadSlider ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdThreadSlider ts, string simobjectid)
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
            public static implicit operator string(ShapeEdThreadSlider ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadSlider(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdThreadSlider) Omni.self.getSimObject(simobjectid, typeof (ShapeEdThreadSlider));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdThreadSlider ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadSlider(int simobjectid)
                {
                return (ShapeEdThreadSlider) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdThreadSlider));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdThreadSlider ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadSlider(uint simobjectid)
                {
                return (ShapeEdThreadSlider) Omni.self.getSimObject(simobjectid, typeof (ShapeEdThreadSlider));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdThreadWindow>))]
        public class ShapeEdThreadWindow : GuiContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiCheckBoxCtrl useTransitions = this.FOT("useTransitions");
                GuiTextEditCtrl transitionTime = this.FOT("transitionTime");
                GuiPopUpMenuCtrl transitionTo = this.FOT("transitionTo");
                GuiPopUpMenuCtrl transitionTarget = this.FOT("transitionTarget");

                useTransitions.setValue("1");
                transitionTime.setText("0.5");

                transitionTo.clear();
                transitionTo.add("synched position", 0);
                transitionTo.add("slider position", 1);
                transitionTo.setSelected(0);

                transitionTarget.clear();
                transitionTarget.add("plays during transition", 0);
                transitionTarget.add("pauses during transition", 1);
                transitionTarget.setSelected(0);
                }

            // Update the GUI in response to the shape selection changing
            [ConsoleInteraction]
            public void update_onShapeSelectionChanged()
                {
                ShapeEdThreadList ShapeEdThreadList = "ShapeEdThreadList";
                GuiTextListCtrl seqList = this.FOT("seqList");

                ShapeEdThreadList.clear();
                seqList.clear();
                seqList.addRow(0, "<rootpose>", -1);
                }

            [ConsoleInteraction]
            public void onAddThread()
                {
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
                ShapeEdThreadList ShapeEdThreadList = "ShapeEdThreadList";

                int threadID = this["threadID"].AsInt();

                ShapeEdShapeView.addThread();
                ShapeEdThreadList.addRow(threadID++, ShapeEdThreadList.rowCount().AsString(), -1);
                ShapeEdThreadList.setSelectedRow(ShapeEdThreadList.rowCount() - 1);
                }

            [ConsoleInteraction]
            public void onRemoveThread()
                {
                ShapeEdThreadList ShapeEdThreadList = "ShapeEdThreadList";
                ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

                if (ShapeEdThreadList.rowCount() > 1)
                    {
                    // Remove the selected thread
                    int row = ShapeEdThreadList.getSelectedRow();
                    ShapeEdShapeView.removeThread(row);
                    ShapeEdThreadList.removeRow(row);

                    // Update list (threads are always numbered 0-N)
                    int rowCount = ShapeEdThreadList.rowCount();
                    for (int i = row; i < rowCount; i++)
                        ShapeEdThreadList.setRowById(ShapeEdThreadList.getRowId(i), i.AsString());

                    // Select the next thread
                    if (row >= rowCount)
                        row = rowCount - 1;

                    ShapeEdThreadList.setSelectedRow(row);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdThreadWindow ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdThreadWindow ts, string simobjectid)
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
            public static implicit operator string(ShapeEdThreadWindow ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadWindow(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdThreadWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdThreadWindow));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdThreadWindow ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadWindow(int simobjectid)
                {
                return (ShapeEdThreadWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdThreadWindow));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdThreadWindow ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdThreadWindow(uint simobjectid)
                {
                return (ShapeEdThreadWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdThreadWindow));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdTriggerList>))]
        public class ShapeEdTriggerList : GuiTextListCtrl
            {
            public int triggerId
                {
                get { return this["triggerId"].AsInt(); }
                set { this["triggerId"] = value.AsString(); }
                }

            [ConsoleInteraction]
            public string getTriggerText(int frame, float state)
                {
                // First column is invisible and used only for sorting
                float sortKey = (frame*1000) + (Util.mAbs(state)*10) + ((state > 0) ? 1 : 0);
                return sortKey + '\t' + frame + '\t' + Util.mAbs(state) + '\t' + ((state > 0) ? "on" : "off");
                }

            [ConsoleInteraction]
            public void addItem(int frame, float state)
                {
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";

                GuiTextEditCtrl seqIn = ShapeEdAnimWindow.FOT("seqIn");

                // Add to text list
                float row = this.addRow(this.triggerId, this.getTriggerText(frame, state), -1);
                this.sortNumerical(0, true);

                // Add marker to animation timeline
                int pos = ShapeEdAnimWindow.getTimelineBitmapPos(seqIn.getText().AsInt() + frame, 2);

                #region GuiBitmapCtrl ()        ctrl

                ObjectCreator ctrlCreator = new ObjectCreator("GuiBitmapCtrl", "");
                ctrlCreator["internalName"] = "trigger" + this.triggerId;
                ctrlCreator["Profile"] = "ToolsGuiDefaultProfile";
                ctrlCreator["HorizSizing"] = "right";
                ctrlCreator["VertSizing"] = "bottom";
                ctrlCreator["position"] = pos + ' ' + "0";
                ctrlCreator["Extent"] = "2 12";
                ctrlCreator["bitmap"] = "tools/shapeEditor/images/trigger_marker";

                #endregion

                GuiBitmapCtrl ctrl = ctrlCreator.Create();


                ((GuiControl) ShapeEdAnimWindow.getObject(0)).addGuiControl(ctrl);
                this.triggerId++;
                }

            [ConsoleInteraction]
            public void removeItem(int frame, float state)
                {
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";

                // Remove from text list
                int row = this.findTextIndex(this.getTriggerText(frame, state));
                if (row > 0)
                    {
                    GuiBitmapCtrl trigger = ShapeEdAnimWindow.FOT("trigger" + this.getRowId(row));
                    trigger.delete();
                    this.removeRow(row);
                    }
                }

            [ConsoleInteraction]
            public void removeAll()
                {
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";

                int count = this.rowCount();
                for (int row = count - 1; row > 0; row--)
                    {
                    GuiBitmapCtrl trigger = ShapeEdAnimWindow.FOT("trigger" + this.getRowId(row));
                    trigger.delete();
                    this.removeRow(row);
                    }
                }

            [ConsoleInteraction]
            public void updateItem(int oldFrame, float oldState, int frame, float state)
                {
                ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";

                GuiTextEditCtrl seqIn = ShapeEdAnimWindow.FOT("seqIn");

                // Update text list entry
                string oldText = this.getTriggerText(oldFrame, oldState);
                int row = this.getSelectedRow();
                if ((row <= 0) || (this.getRowText(row) != oldText))
                    row = this.findTextIndex(oldText);
                if (row > 0)
                    {
                    int updatedId = this.getRowId(row);
                    string newText = this.getTriggerText(frame, state);
                    this.setRowById(updatedId, newText);

                    // keep selected row the same
                    int selectedId = this.getSelectedId();
                    this.sortNumerical(0, true);
                    this.setSelectedById(selectedId);

                    // Update animation timeline marker
                    if (frame != oldFrame)
                        {
                        int pos = ShapeEdAnimWindow.getTimelineBitmapPos(seqIn.getText().AsInt() + frame, 2);
                        GuiBitmapCtrl ctrl = ShapeEdAnimWindow.FOT("trigger" + updatedId);

                        ctrl["position"] = pos + ' ' + "0";
                        }
                    }
                }

            [ConsoleInteraction]
            public void onDeleteSelection()
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEditor ShapeEditor = "ShapeEditor";

                // Can only delete a trigger if a sequence and trigger are selected
                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    int row = this.getSelectedRow();
                    if (row > 0)
                        {
                        string text = this.getRowText(row);
                        int frame = Util.getWord(text, 1).AsInt();
                        float state = Util.getWord(text, 2).AsFloat();
                        state *= (Util.getWord(text, 3) == "on") ? 1 : -1;
                        ShapeEditor.doRemoveTrigger(seqName, frame.AsString(), state.AsString());
                        }
                    }
                }

            [ConsoleInteraction]
            public void onEditSelection()
                {
                ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
                ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";
                ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";
                ShapeEditor ShapeEditor = "ShapeEditor";

                GuiTextEditCtrl triggerFrame = ShapeEdSequences.FOT("triggerFrame");
                GuiTextEditCtrl triggerNum = ShapeEdSequences.FOT("triggerNum");
                GuiCheckBoxCtrl triggerOnOff = ShapeEdSequences.FOT("triggerOnOff");

                // Can only edit triggers if a sequence and trigger are selected
                string seqName = ShapeEdSequenceList.getSelectedName();
                if (seqName != "")
                    {
                    int row = ShapeEdTriggerList.getSelectedRow();
                    if (row > 0)
                        {
                        string text = this.getRowText(row);
                        string oldFrame = Util.getWord(text, 1);
                        float oldState = Util.getWord(text, 2).AsFloat();
                        oldState *= (Util.getWord(text, 3) == "on") ? 1 : -1;

                        int frame =(int) Util.mRound(triggerFrame.getText().AsFloat());
                        int state = (int)Util.mRound(Util.mAbs(triggerNum.getText().AsFloat()));
                        state *= triggerOnOff.getValue().AsBool() ? 1 : -1;

                        if ((frame >= 0) && (state != 0))
                            ShapeEditor.doEditTrigger(seqName, oldFrame, oldState.AsString(), frame.AsString(),
                                state.AsString());
                        }
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ShapeEdTriggerList ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ShapeEdTriggerList ts, string simobjectid)
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
            public static implicit operator string(ShapeEdTriggerList ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdTriggerList(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdTriggerList) Omni.self.getSimObject(simobjectid, typeof (ShapeEdTriggerList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdTriggerList ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdTriggerList(int simobjectid)
                {
                return (ShapeEdTriggerList) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdTriggerList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdTriggerList ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdTriggerList(uint simobjectid)
                {
                return (ShapeEdTriggerList) Omni.self.getSimObject(simobjectid, typeof (ShapeEdTriggerList));
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
        public static bool operator ==(ShapeEditor ts, string simobjectid)
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
        public static bool operator !=(ShapeEditor ts, string simobjectid)
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
        public static implicit operator string(ShapeEditor ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEditor(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ShapeEditor) Omni.self.getSimObject(simobjectid, typeof (ShapeEditor));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEditor ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEditor(int simobjectid)
            {
            return (ShapeEditor) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEditor));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEditor ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEditor(uint simobjectid)
            {
            return (ShapeEditor) Omni.self.getSimObject(simobjectid, typeof (ShapeEditor));
            }

        #endregion

        //------------------------------------------------------------------------------
        // Material Editing
        //------------------------------------------------------------------------------
        }
    }