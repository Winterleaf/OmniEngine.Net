using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.Profiles;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using AddFMODProjectDlg = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.AddFMODProjectDlg;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    public class Main
        {
        [ConsoleInteraction]
        public static void initializeWorldEditor()
            {
            Omni.self.Print(" % - Initializing World Editor");
            Profiles.initialize();
            Cursor.initialize();
            guiCreateNewTerrainGui.initialize();
            GenericPromptDialog.initialize();
            guiTerrainImportGui.initialize();
            guiTerrainExportGui.initialize();
            EditorGui.initialize();
            objectBuilderGui.initialize();
            TerrainEditorVSettingsGui.initialize();
            EditorChooseLevelGui.initialize();
            VisibilityLayerWindow.initialize();
            ManageBookmarksWindow.initialize();
            ManageSFXParametersWindow.initialize();
            TimeAdjustGui.initialize();
            AddFMODProjectDlg.initialize();
            SelectObjectsWindow.initialize();
            ProceduralTerrainPainterGui.initialize();
            MenuHandlers.initialize();
            editor.initialize();
            editor_bind_ed.initialize();
            EditorGui.editorPrefsInitialize();
            ESelectObjectsWindow.initialize();
            TerrainEditorPlugin.LoadTerrainEditorTextureFileSpec();
            // Create the default editor plugins before calling buildMenus.
            ObjectCreator oWorldEditorPlugin = new ObjectCreator("ScriptObject", "WorldEditorPlugin",
                typeof (WorldEditorPlugin));
            oWorldEditorPlugin["editorGui"] = "EWorldEditor";
            oWorldEditorPlugin.Create();

            // aka. The ObjectEditor.
            ObjectCreator oWorldEditorInspectorPlugin = new ObjectCreator("ScriptObject", "WorldEditorInspectorPlugin",
                typeof (WorldEditorInspectorPlugin));
            oWorldEditorInspectorPlugin["editorGui"] = "EWorldEditor";
            oWorldEditorInspectorPlugin.Create();

            ObjectCreator oTerrainEditorPlugin = new ObjectCreator("ScriptObject", "TerrainEditorPlugin",
                typeof (TerrainEditorPlugin));
            oTerrainEditorPlugin["editorGui"] = "ETerrainEditor";
            oTerrainEditorPlugin.Create();

            ObjectCreator oTerrainPainterPlugin = new ObjectCreator("ScriptObject", "TerrainPainterPlugin",
                typeof (TerrainPainterPlugin));
            oTerrainPainterPlugin["editorGui"] = "ETerrainEditor";
            oTerrainPainterPlugin.Create();

            ObjectCreator oMaterialEditorPlugin = new ObjectCreator("ScriptObject", "MaterialEditorPlugin",
                typeof (MaterialEditor.gui.CodeBehind.MaterialEditorPlugin));
            oMaterialEditorPlugin["editorGui"] = "EWorldEditor";
            oMaterialEditorPlugin.Create();

            // Expose stock visibility/debug options.
            EVisibility EVisibility = "EVisibility";

            EVisibility.addOption("Render: Zones", "$Zone::isRenderable", "");
            EVisibility.addOption("Render: Portals", "$Portal::isRenderable", "");
            EVisibility.addOption("Render: Occlusion Volumes", "$OcclusionVolume::isRenderable", "");
            EVisibility.addOption("Render: Triggers", "$Trigger::renderTriggers", "");
            EVisibility.addOption("Render: PhysicalZones", "$PhysicalZone::renderZones", "");
            EVisibility.addOption("Render: Sound Emitters", "$SFXEmitter::renderEmitters", "");
            EVisibility.addOption("Render: Mission Area", "EWorldEditor.renderMissionArea", "");
            EVisibility.addOption("Render: Sound Spaces", "$SFXSpace::isRenderable", "");
            EVisibility.addOption("Wireframe Mode", "$gfx::wireframe", "");
            EVisibility.addOption("Debug Render: Player Collision", "$Player::renderCollision", "");
            EVisibility.addOption("Debug Render: Terrain", "TerrainBlock::debugRender", "");
            EVisibility.addOption("Debug Render: Decals", "$Decals::debugRender", "");
            EVisibility.addOption("Debug Render: Light Frustums", "$Light::renderLightFrustums", "");
            EVisibility.addOption("Debug Render: Bounding Boxes", "$Scene::renderBoundingBoxes", "");
            EVisibility.addOption("AL: Disable Shadows", "$Shadows::disable", "");
            EVisibility.addOption("AL: Light Color Viz", "$AL_LightColorVisualizeVar", "toggleLightColorViz");
            EVisibility.addOption("AL: Light Specular Viz", "$AL_LightSpecularVisualizeVar", "toggleLightSpecularViz");
            EVisibility.addOption("AL: Normals Viz", "$AL_NormalsVisualizeVar", "toggleNormalsViz");
            EVisibility.addOption("AL: Depth Viz", "$AL_DepthVisualizeVar", "toggleDepthViz");
            EVisibility.addOption("Frustum Lock", "$Scene::lockCull", "");
            EVisibility.addOption("Disable Zone Culling", "$Scene::disableZoneCulling", "");
            EVisibility.addOption("Disable Terrain Occlusion", "$Scene::disableTerrainOcclusion", "");
            }

        [ConsoleInteraction]
        public static void destroyWorldEditor()
            {
            }
        }
    }