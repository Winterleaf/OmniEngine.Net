using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns
    {
    [TypeConverter(typeof (TypeConverterGeneric<TerrainEditorPlugin>))]
    public class TerrainEditorPlugin : EditorPlugin
        {
        

        internal ActionMap map
            {
            get { return this["map"]; }
            set { this["map"] = value; }
            }

        [ConsoleInteraction]
        public static void LoadTerrainEditorTextureFileSpec()
            {
            omni.sGlobal["$TerrainEditor::TextureFileSpec"] =
                "Image Files (*.png, *.jpg, *.dds)|*.png;*.jpg;*.dds|All Files (*.*)|*.*";
            }

        [ConsoleInteraction]
        public override bool? setEditorFunction(string overrideGroup = "")
            {
            bool terrainExists = AggregateControl.parseMissionGroup("TerrainBlock");
            //   console.Call("parseMissionGroup", new string[] { "TerrainBlock" });
            if (terrainExists == false)
                messageBox.MessageBoxYesNoCancel("No Terrain", "Would you like to create a New Terrain?",
                    "Canvas.pushDialog(CreateNewTerrainGui);");

            return terrainExists;
            }

        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            base.onWorldEditorStartup();
            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Terrain Editor", "", this);
            // Add ourselves to the ToolsToolbar
            string tooltip = "Terrain Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("TerrainEditorPlugin", "TerrainEditorPalette",
                Util._expandFilename("tools/worldEditor/images/toolbar/sculpt-terrain"), tooltip);

            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "ToolsPaletteArray->brushAdjustHeight.performClick();", ""); //Grab Terrain
            map.bindCmd("keyboard", "2", "ToolsPaletteArray->raiseHeight.performClick();", ""); // Raise Height
            map.bindCmd("keyboard", "3", "ToolsPaletteArray->lowerHeight.performClick();", ""); // Lower Height
            map.bindCmd("keyboard", "4", "ToolsPaletteArray->smoothHeight.performClick();", ""); // Average Height
            map.bindCmd("keyboard", "5", "ToolsPaletteArray->smoothSlope.performClick();", ""); // Smooth Slope
            map.bindCmd("keyboard", "6", "ToolsPaletteArray->paintNoise.performClick();", ""); // Noise
            map.bindCmd("keyboard", "7", "ToolsPaletteArray->flattenHeight.performClick();", ""); // Flatten
            map.bindCmd("keyboard", "8", "ToolsPaletteArray->setHeight.performClick();", ""); // Set Height
            map.bindCmd("keyboard", "9", "ToolsPaletteArray->setEmpty.performClick();", ""); // Clear Terrain
            map.bindCmd("keyboard", "0", "ToolsPaletteArray->clearEmpty.performClick();", ""); // Restore Terrain
            map.bindCmd("keyboard", "v", "EWTerrainEditToolbarBrushType->ellipse.performClick();", ""); // Circle Brush
            map.bindCmd("keyboard", "b", "EWTerrainEditToolbarBrushType->box.performClick();", ""); // Box Brush
            map.bindCmd("keyboard", "=", "TerrainEditorPlugin.keyboardModifyBrushSize(1);", ""); // +1 Brush Size
            map.bindCmd("keyboard", "+", "TerrainEditorPlugin.keyboardModifyBrushSize(1);", ""); // +1 Brush Size
            map.bindCmd("keyboard", "-", "TerrainEditorPlugin.keyboardModifyBrushSize(-1);", ""); // -1 Brush Size
            map.bindCmd("keyboard", "[", "TerrainEditorPlugin.keyboardModifyBrushSize(-5);", ""); // -5 Brush Size
            map.bindCmd("keyboard", "]", "TerrainEditorPlugin.keyboardModifyBrushSize(5);", ""); // +5 Brush Size

            this["map"] = map;

            ObjectCreator oc = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));
            //oc["superClass"] = "MenuBuilder";

            oc["barTitle"] = "Terrain";

            oc["item[0]"] = "Smooth Heightmap" + "\t" + "" + "\t" + "ETerrainEditor.onSmoothHeightmap();";
            oc["item[1]"] = "Solder Edges" + "\t" + "" + "\t" + "ETerrainEditor.onSolderEdges();";

            this["terrainMenu"] = oc.Create().AsString();
            }

        public override void onActivated()
            {
            base.onActivated();
            EditorGui EditorGui = "EditorGui";
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            GuiControl EWTerrainEditToolbar = "EWTerrainEditToolbar";
            TerrainEditorPlugin TerrainEditorPlugin = "TerrainEditorPlugin";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            Settings EditorSettings = "EditorSettings";

            EditorGui.readTerrainEditorSettings();

            string action = EditorSettings.value("TerrainEditor/currentAction");

            ETerrainEditor.switchAction(action);

            GuiButtonCtrl ctrl =
                (((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName(action, true));

            ctrl.setStateOn(true);

            GuiBitmapButtonCtrl octrl =
                ((GuiControl) "EWTerrainEditToolbarBrushType").findObjectByInternalName("ellipse", true);
            octrl.performClick();

            EditorGui.menuBar.insert(this["terrainMenu"], EditorGui.menuBar["dynamicItemInsertPos"].AsInt());

            EditorGui.bringToFront(ETerrainEditor);
            ETerrainEditor.setVisible(true);
            ETerrainEditor.attachTerrain();
            ETerrainEditor.makeFirstResponder(true);

            EWTerrainEditToolbar.setVisible(true);
            ETerrainEditor.onBrushChanged();
            ETerrainEditor.setup();
            TerrainEditorPlugin.syncBrushInfo();

            EditorGuiStatusBar.setSelection("");

            ((ActionMap) map).push();
            }

        public override void onDeactivated()
            {
            base.onDeactivated();
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            EditorGui EditorGui = "EditorGui";

            console.Call("endToolTime", new string[] {"TerrainEditor"});
            ((EditorGui) "EditorGui").writeTerrainEditorSettings();
            ((GuiControl) "EWTerrainEditToolbar").setVisible(false);
            ETerrainEditor.setVisible(false);

            EditorGui.menuBar.remove(this["terrainMenu"]);

            map.pop();
            }

        [ConsoleInteraction]
        public void syncBrushInfo()
            {
            GuiControl TerrainBrushSizeTextEditContainer = "TerrainBrushSizeTextEditContainer";
            GuiControl TerrainBrushPressureTextEditContainer = "TerrainBrushPressureTextEditContainer";
            GuiControl TerrainBrushSoftnessTextEditContainer = "TerrainBrushSoftnessTextEditContainer";
            GuiControl TerrainSetHeightTextEditContainer = "TerrainSetHeightTextEditContainer";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            GuiTextEditCtrl tTerrainBrushSizeTextEditContainer =
                TerrainBrushSizeTextEditContainer.findObjectByInternalName("textEdit", true);

            GuiTextEditCtrl tTerrainBrushPressureTextEditContainer =
                TerrainBrushPressureTextEditContainer.findObjectByInternalName("textEdit", true);

            GuiTextEditCtrl tTerrainBrushSoftnessTextEditContainer =
                TerrainBrushSoftnessTextEditContainer.findObjectByInternalName("textEdit", true);

            GuiTextEditCtrl tTerrainSetHeightTextEditContainer =
                TerrainSetHeightTextEditContainer.findObjectByInternalName("textEdit", true);

            tTerrainBrushSizeTextEditContainer.text = Util.getWord(ETerrainEditor.getBrushSize(), 0);
            tTerrainBrushPressureTextEditContainer.text = (ETerrainEditor.getBrushPressure()*100).AsString();
            tTerrainBrushSoftnessTextEditContainer.text = (ETerrainEditor.getBrushSoftness()*100).AsString();
            tTerrainSetHeightTextEditContainer.text = (ETerrainEditor.setHeightVal.AsString());

            string brushType = ETerrainEditor.getBrushType();

            Util.eval("EWTerrainEditToolbar-->" + brushType + ".setStateOn(1);");
            }

        [ConsoleInteraction]
        public void validateBrushSize()
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            int minBrushSize = 1;
            int maxBrushSize = Util.getWord(ETerrainEditor["maxBrushSize"], 0).AsInt();

            int val = ((SimObject) sGlobal["$ThisControl"]).call("getText").AsInt();

            if (val < minBrushSize)
                sGlobal["$ThisControl"].call("setValue", new string[] {minBrushSize.AsString()});
            else if (val > maxBrushSize)
                sGlobal["$ThisControl"].call("setValue", new string[] {maxBrushSize.AsString()});
            }

        public virtual void keyboardModifyBrushSize(int amt)
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            int val =
                ((GuiTextEditCtrl)
                    ((GuiControl) "TerrainBrushSizeTextEditContainer").findObjectByInternalName("textEdit", true))
                    .getText().AsInt();

            val = val + amt;

            ((GuiTextEditCtrl)
                ((GuiControl) "TerrainBrushSizeTextEditContainer").findObjectByInternalName("textEdit", true))
                .setValue(val.AsString());

            ((GuiTextEditCtrl)
                ((GuiControl) "TerrainBrushSizeTextEditContainer").findObjectByInternalName("textEdit", true))
                .forceValidateText();

            ETerrainEditor.setBrushSize(val);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(TerrainEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(TerrainEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (TerrainEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (TerrainEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainEditorPlugin(int simobjectid)
            {
            return (TerrainEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainEditorPlugin(uint simobjectid)
            {
            return (TerrainEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (TerrainEditorPlugin));
            }

        #endregion
        }
    }