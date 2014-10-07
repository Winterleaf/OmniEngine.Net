using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<MaterialEditorPlugin>))]
    public class MaterialEditorPlugin : WorldEditorPlugin
        {
        public ActionMap map
            {
            get { return this["map"]; }
            set { this["map"] = value; }
            }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";
            GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
            MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
            CubemapData matEdCubeMapPreviewMat = "matEdCubeMapPreviewMat";
            CubemapData WarnMatCubeMap = "WarnMatCubeMap";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Material Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Material Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("MaterialEditorPlugin", "MaterialEditorPalette",
                Util._expandFilename("tools/worldEditor/images/toolbar/matterial-editor"), tooltip);

            //connect editor windows
            MaterialEditorPropertiesWindow.attachTo("MaterialEditorPreviewWindow");

            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "EWorldEditorNoneModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "EWorldEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "EWorldEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "EWorldEditorScaleModeBtn.performClick();", ""); // Scale
            map.bindCmd("keyboard", "f", "FitToSelectionBtn.performClick();", ""); // Fit Camera to Selection
            map.bindCmd("keyboard", "z", "EditorGuiStatusBar.setCamera(\"Standard Camera\");", ""); // Free Camera
            map.bindCmd("keyboard", "n", "ToggleNodeBar->renderHandleBtn.performClick();", ""); // Render Node
            map.bindCmd("keyboard", "shift n", "ToggleNodeBar->renderTextBtn.performClick();", ""); // Render Node Text
            map.bindCmd("keyboard", "alt s", "MaterialEditorGui.save();", ""); // Save Material
            //%map.bindCmd( keyboard, "delete", "ToggleNodeBar->renderTextBtn.performClick();", "" );// delete Material
            map.bindCmd("keyboard", "g", "ESnapOptions-->GridSnapButton.performClick();", ""); // Grid Snappping
            map.bindCmd("keyboard", "t", "SnapToBar->objectSnapDownBtn.performClick();", ""); // Terrain Snapping
            map.bindCmd("keyboard", "b", "SnapToBar-->objectSnapBtn.performClick();", ""); // Soft Snappping
            map.bindCmd("keyboard", "v", "EWorldEditorToolbar->boundingBoxColBtn.performClick();", "");
            // Bounds Selection
            map.bindCmd("keyboard", "o",
                "objectCenterDropdown->objectBoxBtn.performClick(); objectCenterDropdown.toggle();", "");
            // Object Center
            map.bindCmd("keyboard", "p",
                "objectCenterDropdown->objectBoundsBtn.performClick(); objectCenterDropdown.toggle();", "");
            // Bounds Center
            map.bindCmd("keyboard", "k",
                "objectTransformDropdown->objectTransformBtn.performClick(); objectTransformDropdown.toggle();", "");
            // Object Transform
            map.bindCmd("keyboard", "l",
                "objectTransformDropdown->worldTransformBtn.performClick(); objectTransformDropdown.toggle();", "");
            // World Transform
            this.map = map;

            MaterialEditorGui["fileSpec"] = "Torque Material Files (materials.cs)|materials.cs|All Files (*.*)|*.*";
            MaterialEditorGui["textureFormats"] =
                "Image Files (*.png, *.jpg, *.dds, *.bmp, *.gif, *.jng. *.tga)|*.png;*.jpg;*.dds;*.bmp;*.gif;*.jng;*.tga|All Files (*.*)|*.*";
            MaterialEditorGui["modelFormats"] = "DTS Files (*.dts)|*.dts";
            MaterialEditorGui["lastTexturePath"] = "";
            MaterialEditorGui["lastTextureFile"] = "";
            MaterialEditorGui["lastModelPath"] = "";
            MaterialEditorGui["lastModelFile"] = "";
            MaterialEditorGui.currentMaterial = "";
            MaterialEditorGui["lastMaterial"] = "";
            MaterialEditorGui["currentCubemap"] = "";
            MaterialEditorGui.currentObject = "";

            MaterialEditorGui["livePreview"] = "1";
            MaterialEditorGui["currentLayer"] = "0";
            MaterialEditorGui.currentMode = "Material";
            MaterialEditorGui.currentMeshMode = "EditorShape";

            ArrayObject UnlistedCubemaps = new ObjectCreator("ArrayObject", "UnlistedCubemaps").Create();
            UnlistedCubemaps.add("unlistedCubemaps", matEdCubeMapPreviewMat);
            UnlistedCubemaps.add("unlistedCubemaps", WarnMatCubeMap);

            //MaterialEditor persistence manager
            new ObjectCreator("PersistenceManager", "matEd_PersistMan").Create();
            }

        [ConsoleInteraction]
        public override void onActivated()
            {
            GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
            GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
            EditorPlugin WorldEditorPlugin = "WorldEditorPlugin";
            MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
            GuiRolloutCtrl advancedTextureMapsRollout = "advancedTextureMapsRollout";
            GuiRolloutCtrl materialAnimationPropertiesRollout = "materialAnimationPropertiesRollout";
            GuiRolloutCtrl materialAdvancedPropertiesRollout = "materialAdvancedPropertiesRollout";
            EditorGui EditorGui = "EditorGui";
            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            if (bGlobal["$gfx::wireframe"])
                {
                bGlobal["$wasInWireFrameMode"] = true;
                bGlobal["$gfx::wireframe"] = false;
                }
            else
                {
                bGlobal["$wasInWireFrameMode"] = false;
                }
            advancedTextureMapsRollout["Expanded"] = false.AsString();
            materialAnimationPropertiesRollout["Expanded"] = false.AsString();
            materialAdvancedPropertiesRollout["Expanded"] = false.AsString();
            WorldEditorPlugin.onActivated();

            //Copyright Winterleaf Entertainment L.L.C. 2013
            MaterialEditorPropertiesWindow.setVisible(true);
            MaterialEditorPreviewWindow.setVisible(true);
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            WorldEditorToolbar.setVisible(true);

            MaterialEditorGui.currentObject = sGlobal["$Tools::materialEditorList"];
            // Execute the back end scripts that actually do the work.
            MaterialEditorGui.open();
            this.map.push();

            base.onActivated();
            }

        [ConsoleInteraction]
        public override void onEditMenuSelect(string editMenu)
            {
            EditorPlugin WorldEditorPlugin = "WorldEditorPlugin";
            WorldEditorPlugin.onEditMenuSelect(editMenu);
            }

        [ConsoleInteraction]
        public override void onDeactivated()
            {
            EditorPlugin WorldEditorPlugin = "WorldEditorPlugin";
            MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
            GuiWindowCollapseCtrl MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
            GuiWindowCollapseCtrl MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
            EditorGui EditorGui = "EditorGui";
            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013

            if (bGlobal["$wasInWireFrameMode"])
                bGlobal["$gfx::wireframe"] = true;

            WorldEditorPlugin.onDeactivated();

            MaterialEditorGui.quit();

            //Copyright Winterleaf Entertainment L.L.C. 2013
            MaterialEditorPreviewWindow.setVisible(false);
            MaterialEditorPropertiesWindow.setVisible(false);
            //Copyright Winterleaf Entertainment L.L.C. 2013   
            WorldEditorToolbar.setVisible(false);
            this.map.pop();

            base.onDeactivated();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MaterialEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(MaterialEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(MaterialEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MaterialEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MaterialEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (MaterialEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MaterialEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MaterialEditorPlugin(int simobjectid)
            {
            return (MaterialEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (MaterialEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MaterialEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MaterialEditorPlugin(uint simobjectid)
            {
            return (MaterialEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (MaterialEditorPlugin));
            }

        #endregion
        }
    }