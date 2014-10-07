#region

using System;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
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
    public partial class TerrainEditor
        {
        internal string currentAction
            {
            get { return this["currentAction"]; }
            set { this["currentAction"] = value; }
            }

        [ConsoleInteraction]
        public void init()
            {
            this.attachTerrain();
            this.setBrushSize(9,9);
            new ObjectCreator("PersistenceManager", "ETerrainPersistMan").Create();
            }

        [ConsoleInteraction]
        public void setPaintMaterial(int matIndex, TerrainMaterial terrainMat)
            {
            if (!terrainMat.isObject())
                throw new Exception("TerrainEditor::setPaintMaterial - Got bad material!");
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            ETerrainEditor.paintIndex = matIndex;
            GuiBitmapCtrl ETerrainMaterialSelected = "ETerrainMaterialSelected";
            GuiButtonCtrl ETerrainMaterialSelectedEdit = "ETerrainMaterialSelectedEdit";
            GuiTextCtrl TerrainTextureText = "TerrainTextureText";
            GuiWindowCtrl ProceduralTerrainPainterDescription = "ProceduralTerrainPainterDescription";

            ETerrainEditor.paintIndex = matIndex;
            ETerrainMaterialSelected["selectedMatIndex"] = matIndex.AsString();
            ETerrainMaterialSelected["selectedMat"] = terrainMat;
            ETerrainMaterialSelected.bitmap = new TypeImageFilename(terrainMat.diffuseMap);
            ETerrainMaterialSelectedEdit["Visible"] = terrainMat.isObject().AsString();
            TerrainTextureText.text = terrainMat.getInternalName();
            ProceduralTerrainPainterDescription.text = "Generate " + terrainMat.getInternalName() + " layer";
            }

        [ConsoleInteraction]
        public void setup()
            {
            string action = this["savedAction"];
            string desc = this["savedActionDesc"];
            if (this["savedAction"] == "")
                {
                action = "brushAdjustHeight";
                }
            this.switchAction(action);
            }

        [ConsoleInteraction]
        public override void onGuiUpdate(string text)
            {
            string minHeight = Util.getWord(text, 1);
            string avgHeight = Util.getWord(text, 2);
            string maxHeight = Util.getWord(text, 3);
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            string mouseBrushInfo = " (Mouse) #: " + Util.getWord(text, 0) + "  avg: " + avgHeight + " " +
                                    ETerrainEditor.currentAction;
            string selectionInfo = "     (Selected) #: " + Util.getWord(text, 4) + "  avg: " + Util.getWord(text, 5);

            GuiTextCtrl TEMouseBrushInfo = "TEMouseBrushInfo";
            GuiTextCtrl TEMouseBrushInfo1 = "TEMouseBrushInfo1";
            GuiTextCtrl TESelectionInfo = "TESelectionInfo";
            GuiTextCtrl TESelectionInfo1 = "TESelectionInfo1";


            TEMouseBrushInfo.setValue(mouseBrushInfo);
            TEMouseBrushInfo1.setValue(mouseBrushInfo);
            TESelectionInfo.setValue(selectionInfo);
            TESelectionInfo1.setValue(selectionInfo);

            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

            EditorGuiStatusBar.setSelection("min: " + minHeight + "  avg: " + avgHeight + "  max: " + maxHeight);
            }

        [ConsoleInteraction]
        public override void onBrushChanged()
            {
            EditorGui EditorGui = "EditorGui";
            EditorGui.currentEditor.call("syncBrushInfo");
            }

        [ConsoleInteraction]
        public void toggleBrushType(SimObject brush)
            {
            this.setBrushType(brush.internalName);
            }

        [ConsoleInteraction]
        public void offsetBrush(int x, int y)
            {
            string currPos = this.getBrushPos();
            string newX = (Util.getWord(currPos, 0).AsInt() + x).AsString();
            string newY = (Util.getWord(currPos, 1).AsInt() + y).AsString();

            this.setBrushPos(new Point2I( newX + " " +  newY));
            }

        [ConsoleInteraction]
        public override void onActiveTerrainChange(string newTerrain = "")
            {
            EditorGui EditorGui = "EditorGui";
            TerrainPainter TerrainPainter = "TerrainPainter";
            if (EditorGui.currentEditor.getId() == "TerrainPainterPlugin".getID())
                TerrainPainter.setup(((TerrainEditor) "ETerrainEditor")["paintIndex"].AsInt());
            }

        [ConsoleInteraction]
        public string getActionDescription(string action)
            {
            switch (action)
                {
                    case "brushAdjustHeight":
                        return "Adjust terrain height up or down.";

                    case "raiseHeight":
                        return "Raise terrain height.";

                    case "lowerHeight":
                        return "Lower terrain height.";

                    case "smoothHeight":
                        return "Smooth terrain.";

                    case "paintNoise":
                        return "Modify terrain height using noise.";

                    case "flattenHeight":
                        return "Flatten terrain.";

                    case "setHeight":
                        return "Set terrain height to defined value.";

                    case "setEmpty":
                        return "Remove terrain collision.";

                    case "clearEmpty":
                        return "Add back terrain collision.";

                    default:
                        return "";
                }
            }

        /// This is only ment for terrain editing actions and not
        /// processed actions or the terrain material painting action.
        [ConsoleInteraction]
        public void switchAction(string action)
            {
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            string actionDesc = getActionDescription(action);


            this["currentMode"] = "paint";
            this.selectionHidden = true;
            this.currentAction = action;
            this["currentActionDesc"] = actionDesc;
            this["savedAction"] = action;
            this["savedActionDesc"] = actionDesc;

            if (action == "setEmpty" ||
                action == "clearEmpty" ||
                action == "setHeight")
                this.renderSolidBrush = true;
            else
                this.renderSolidBrush = false;

            EditorGuiStatusBar.setInfo(actionDesc);

            this.setAction(this.currentAction);
            }

        [ConsoleInteraction]
        public void onSmoothHeightmap()
            {
            editor Editor = "Editor";

            if (!this.getActiveTerrain().AsBool())
                return;
            // Show the dialog first and let the user
            // set the smoothing parameters.


            // Now create the terrain smoothing action to
            // get the work done and perform later undos.

            TerrainSmoothAction action = new ObjectCreator("TerrainSmoothAction").Create();
            action.smooth(this.getActiveTerrain().AsString(), 1.0f, 1);
            action.addToManager(Editor.getUndoManager());
            }

        [ConsoleInteraction]
        public void onSolderEdges( )
        {
            editor Editor = "Editor";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

           // # Work with all terrains on the loaded level.
           TerrainSolderEdgesAction action = new ObjectCreator("TerrainSolderEdgesAction").Create();
           action.solder();
           action.addToManager( Editor.getUndoManager() );
           ETerrainEditor.isDirty = true;
        }

        [ConsoleInteraction]
        public override void onMaterialUndo()
            {
            TerrainPainter TerrainPainter = "TerrainPainter";

            TerrainPainter.updateLayers("");
            }
        }
    }