using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using LevelInfo =  WinterLeaf.Demo.Full.Models.User.Extendable.LevelInfo;
using SimObject =  WinterLeaf.Demo.Full.Models.User.Extendable.SimObject;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    [TypeConverter(typeof (TypeConverterGeneric<editor>))]
    public class editor : EditManager
        {
        //------------------------------------------------------------------------------
        // Hard coded images referenced from C++ code
        //------------------------------------------------------------------------------

        //   editor/SelectHandle.png
        //   editor/DefaultHandle.png
        //   editor/LockedHandle.png
        


        //  The editor action maps are defined in editor.bind.cs
        [ConsoleInteraction(true, "editor_Initialize")]
        public static void initialize()
            {
            omni.sGlobal["$RelightCallback"] = "";
            ((ActionMap) "GlobalActionMap").bind("keyboard", "f11", "toggleEditor");
            omni.Util.eval(@"

package EditorDisconnectOverride
{
   function disconnect()
   {
Editor_Disconnect();
}
};


");
            omni.Util.activatePackage("EditorDisconnectOverride");
            }

        [ConsoleInteraction(true, "Editor_Create")]
        public static void create()
            {
            // Not much to do here, build it and they will come...
            // Only one thing... the editor is a gui control which
            // expect the Canvas to exist, so it must be constructed
            // before the editor.

            ObjectCreator oc = new ObjectCreator("EditManager", "Editor", typeof (editor));
            oc["profile"] = "GuiContentProfile";
            oc["horizSizing"] = "right";
            oc["vertSizing"] = "top";
            oc["position"] = "0 0";
            oc["extent"] = "640 480";
            oc["minExtent"] = "8 8";
            oc["visible"] = "1";
            oc["setFirstResponder"] = "0";
            oc["modal"] = "1";
            oc["helpTag"] = "0";
            oc["open"] = false;

            oc.Create();
            }

        [ConsoleInteraction]
        public UndoManager getUndoManager()
            {
            if (!this["undoManager"].isObject())
                {
                if ("EUndoManager".isObject())
                    this["undoManager"] = "EUndoManager";
                else
                    {
                    ObjectCreator oc = new ObjectCreator("UndoManager", "EUndoManager",
                        typeof (UndoManager.EUndoManager));
                    oc["numLevels"] = 200;
                    this["undoManager"] = oc.Create().AsString();
                    }
                }
            return this["undoManager"];
            }

        [ConsoleInteraction]
        public void setUndoManager(UndoManager undoMgr)
            {
            this["undoManager"] = undoMgr;
            }

        public override void onAdd()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            // Ignore Replicated fxStatic Instances.
            EWorldEditor.ignoreObjClass("fxShapeReplicatedStatic");
            }

        [ConsoleInteraction]
        public bool checkActiveLoadDone()
            {
            if ("EditorGui".isObject() && ((EditorGui) "EditorGui")["loadingMission"].AsBool())
                {
                ((GuiCanvas) "canvas").setContent("EditorGui");
                ((EditorGui) "EditorGui")["loadingMission"] = false.AsString();
                return true;
                }
            return false;
            }

        [ConsoleInteraction]
        public static void toggleEditor(bool make)
            {
            if (((GuiCanvas) "Canvas").isFullscreen())
                {
                messageBox.MessageBoxOK("Windowed Mode Required",
                    "Please switch to windowed mode to access the Mission Editor.");
                return;
                }
            editor editor = "editor";
            if (make)
                {
                string timerID = omni.console.Call("startPrecisionTimer");
                    if (omni.bGlobal["$InGuiEditor"])
                        //omni.console.Call("GuiEdit");
                        GuiEditorGui.GuiEdit("");

                if (!omni.bGlobal["$missionRunning"])
                    {
                    // Flag saying, when level is chosen, launch it with the editor open.
                    ((GuiControl) "ChooseLevelDlg")["launchInEditor"] = true.AsString();
                    //((GuiCanvas) "canvas").pushDialog("ChooseLevelDlg");
                        MenuHandlers.EditorNewLevel("");
                    }
                else
                    {
                    omni.Util.pushInstantGroup();
                    if (!"Editor".isObject())
                        {
                        create();


                        ((SimGroup) "MissionCleanup").add(editor);
                        ((SimGroup) "MissionCleanup").add(editor.getUndoManager());
                        }

                    if (WinterLeaf.Demo.Full.Models.User.Extendable. GuiCanvas.EditorIsActive())
                        {
                        if (((LevelInfo) "theLevelInfo")["Type"] == "DemoScene")
                            {
                            omni.console.commandToServer("dropPlayerAtCamera");
                            editor.close("SceneGui");
                            }
                        else
                            {
                            editor.close("PlayGui");
                            }
                        }
                    else
                        {
                        if (!omni.bGlobal["$GuiEditorBtnPressed"])
                            {
                            ((GuiCanvas) "Canvas").pushDialog("EditorLoadingGui");
                            ((GuiCanvas) "Canvas").repaint(0);
                            }
                        else
                            {
                            omni.bGlobal["$GuiEditorBtnPressed"] = false;
                            }

                        editor.open();

                        // Cancel the scheduled event to prevent
                        // the level from cycling after it's duration
                        // has elapsed.

                        omni.Util.cancel(omni.iGlobal["$Game::Schedule"]);

                        if (((LevelInfo) "theLevelInfo")["type"] == "DemoScene")
                            omni.console.commandToServer("dropCameraAtPlayer", new string[] {"true"});

                        ((GuiCanvas) "Canvas").popDialog("EditorLoadingGui");
                        }

                    omni.Util.popInstantGroup();
                    }

                string elapsed = omni.console.Call("stopPrecisionTimer", new string[] {timerID});

                omni.Util._warn("Time spent in toggleEditor() : " + (elapsed.AsFloat()/1000.0) + " s");
                }
            }


        // The scenario:
        // The editor is open and the user closes the level by any way other than
        // the file menu ( exit level ), eg. typing disconnect() in the console.
        //
        // The problem:
        // Editor::close() is not called in this scenario which means onEditorDisable
        // is not called on objects which hook into it and also gEditingMission will no
        // longer be valid.
        //
        // The solution:
        // Override the stock disconnect() function which is in game scripts from here
        // in tools so we avoid putting our code in there.
        //
        // Disclaimer:
        // If you think of a better way to do this feel free. The thing which could
        // be dangerous about this is that no one will ever realize this code overriding
        // a fairly standard and core game script from a somewhat random location.
        // If it 'did' have unforscene sideeffects who would ever find it?

        [ConsoleInteraction]
        public static void Editor_Disconnect()
            {
            editor editor = "editor";
            if ("Editor".isObject() && editor.isEditorEnabled())
                {
                if ("MainMenuGui".isObject())
                    editor.close("MainMenuGui");
                }

            omni.Util.deactivatePackage("EditorDisconnectOverride");
            omni.Util._call("disconnect");
            omni.Util.activatePackage("EditorDisconnectOverride");
            }

        [ConsoleInteraction]
        public void open()
            {
            EditorGui EditorGui = "EditorGui";
            GuiCanvas Canvas = "Canvas";
            GuiEditorGui GuiEditorGui = "GuiEditorGui";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";
            TerrainPainter TerrainPainter = "TerrainPainter";
            GuiWindowCollapseCtrl TerrainPainterPreview = "TerrainPainterPreview";
            EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
            MaterialEditorPreviewWindow MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
            MaterialEditorPropertiesWindow MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
            DatablockEditorTreeWindow DatablockEditorTreeWindow = "DatablockEditorTreeWindow";
            DatablockEditorInspectorWindow DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            DecalEditorGui.DecalEditorWindow DecalEditorWindow = "DecalEditorWindow";
            DecalEditorGui.DecalPreviewWindow DecalPreviewWindow = "DecalPreviewWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            MeshRoadEditorGui.MeshRoadEditorTreeWindow MeshRoadEditorTreeWindow = "MeshRoadEditorTreeWindow";
            MeshRoadEditorGui.MeshRoadEditorOptionsWindow MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            GuiWindowCollapseCtrl MissionAreaEditorTerrainWindow = "MissionAreaEditorTerrainWindow";
            GuiWindowCollapseCtrl MissionAreaEditorPropertiesWindow = "MissionAreaEditorPropertiesWindow";
            ParticleEditor.gui.ParticleEditor.PE_Window PE_Window = "PE_Window";
            RiverEditorGui.RiverEditorTreeWindow RiverEditorTreeWindow = "RiverEditorTreeWindow";
            RiverEditorGui.RiverEditorOptionsWindow RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            RoadEditorGui.RoadEditorTreeWindow RoadEditorTreeWindow = "RoadEditorTreeWindow";
            RoadEditorGui.RoadEditorOptionsWindow RoadEditorOptionsWindow = "RoadEditorOptionsWindow";
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";

            // prevent the mission editor from opening while the GuiEditor is open.
            if (Canvas.getContent() == GuiEditorGui.getId())
                return;

            if (!EditorGui.isInitialized)
                EditorGui.init();

            this.editorEnabled();
            Canvas.setContent(EditorGui);
            EditorGui.syncCameraGui();

            if (EWTreeWindow["wasOpen"].AsBool())
                EWTreeWindow.OpenPopOut();

            if (EWInspectorWindow["wasOpen"].AsBool())
                EWInspectorWindow.OpenPopOut();

            if (TerrainPainter["wasOpen"].AsBool())
                TerrainPainter.OpenPopOut();

            if (TerrainPainterPreview["wasOpen"].AsBool())
                TerrainPainterPreview.OpenPopOut();

            if (MaterialEditorPreviewWindow["wasOpen"].AsBool())
                MaterialEditorPreviewWindow.OpenPopOut();

            if (MaterialEditorPropertiesWindow["wasOpen"].AsBool())
                MaterialEditorPropertiesWindow.OpenPopOut();

            if (DatablockEditorTreeWindow["wasOpen"].AsBool())
                DatablockEditorTreeWindow.OpenPopOut();

            if (DatablockEditorInspectorWindow["wasOpen"].AsBool())
                DatablockEditorInspectorWindow.OpenPopOut();

            if (DecalEditorWindow["wasOpen"].AsBool())
                DecalEditorWindow.OpenPopOut();

            if (DecalPreviewWindow["wasOpen"].AsBool())
                DecalPreviewWindow.OpenPopOut();

            if (ForestEditorPalleteWindow["wasOpen"].AsBool())
                ForestEditorPalleteWindow.OpenPopOut();

            if (ForestEditorPropertiesWindow["wasOpen"].AsBool())
                ForestEditorPropertiesWindow.OpenPopOut();

            if (MeshRoadEditorTreeWindow["wasOpen"].AsBool())
                MeshRoadEditorTreeWindow.OpenPopOut();

            if (MeshRoadEditorOptionsWindow["wasOpen"].AsBool())
                MeshRoadEditorOptionsWindow.OpenPopOut();

            if (MissionAreaEditorTerrainWindow["wasOpen"].AsBool())
                MissionAreaEditorTerrainWindow.OpenPopOut();

            if (MissionAreaEditorPropertiesWindow["wasOpen"].AsBool())
                MissionAreaEditorPropertiesWindow.OpenPopOut();

            if (PE_Window["wasOpen"].AsBool())
                PE_Window.OpenPopOut();

            if (RiverEditorTreeWindow["wasOpen"].AsBool())
                RiverEditorTreeWindow.OpenPopOut();

            if (RiverEditorOptionsWindow["wasOpen"].AsBool())
                RiverEditorOptionsWindow.OpenPopOut();

            if (RoadEditorTreeWindow["wasOpen"].AsBool())
                RoadEditorTreeWindow.OpenPopOut();

            if (RoadEditorOptionsWindow["wasOpen"].AsBool())
                RoadEditorOptionsWindow.OpenPopOut();

            if (ShapeEdAdvancedWindow["wasOpen"].AsBool())
                ShapeEdAdvancedWindow.OpenPopOut();

            if (ShapeEdSelectWindow["wasOpen"].AsBool())
                ShapeEdSelectWindow.OpenPopOut();

            if (ShapeEdPropWindow["wasOpen"].AsBool())
                ShapeEdPropWindow.OpenPopOut();
            }

        [ConsoleInteraction]
        public void close(GuiControl gui)
            {
            EditorGui EditorGui = "EditorGui";
            GuiCanvas Canvas = "Canvas";
            GuiEditorGui GuiEditorGui = "GuiEditorGui";
            EWTreeWindow EWTreeWindow = "EWTreeWindow";
            TerrainPainter TerrainPainter = "TerrainPainter";
            GuiWindowCollapseCtrl TerrainPainterPreview = "TerrainPainterPreview";
            EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
            MaterialEditorPreviewWindow MaterialEditorPreviewWindow = "MaterialEditorPreviewWindow";
            MaterialEditorPropertiesWindow MaterialEditorPropertiesWindow = "MaterialEditorPropertiesWindow";
            DatablockEditorTreeWindow DatablockEditorTreeWindow = "DatablockEditorTreeWindow";
            DatablockEditorInspectorWindow DatablockEditorInspectorWindow = "DatablockEditorInspectorWindow";
            DecalEditorGui.DecalEditorWindow DecalEditorWindow = "DecalEditorWindow";
            DecalEditorGui.DecalPreviewWindow DecalPreviewWindow = "DecalPreviewWindow";
            ForestEditorGui.ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
            ForestEditorGui.ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";
            MeshRoadEditorGui.MeshRoadEditorTreeWindow MeshRoadEditorTreeWindow = "MeshRoadEditorTreeWindow";
            MeshRoadEditorGui.MeshRoadEditorOptionsWindow MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            GuiWindowCollapseCtrl MissionAreaEditorTerrainWindow = "MissionAreaEditorTerrainWindow";
            GuiWindowCollapseCtrl MissionAreaEditorPropertiesWindow = "MissionAreaEditorPropertiesWindow";
            ParticleEditor.gui.ParticleEditor.PE_Window PE_Window = "PE_Window";
            RiverEditorGui.RiverEditorTreeWindow RiverEditorTreeWindow = "RiverEditorTreeWindow";
            RiverEditorGui.RiverEditorOptionsWindow RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            RoadEditorGui.RoadEditorTreeWindow RoadEditorTreeWindow = "RoadEditorTreeWindow";
            RoadEditorGui.RoadEditorOptionsWindow RoadEditorOptionsWindow = "RoadEditorOptionsWindow";
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            

            EWTreeWindow["wasOpen"] = EWTreeWindow["isInPopup"];
            EWInspectorWindow["wasOpen"] = EWInspectorWindow["isInPopup"];
            TerrainPainter["wasOpen"] = TerrainPainter["isInPopup"];
            TerrainPainterPreview["wasOpen"] = TerrainPainterPreview["isInPopup"];
            MaterialEditorPreviewWindow["wasOpen"] = MaterialEditorPreviewWindow["isInPopup"];
            MaterialEditorPropertiesWindow["wasOpen"] = MaterialEditorPropertiesWindow["isInPopup"];
            DatablockEditorTreeWindow["wasOpen"] = DatablockEditorTreeWindow["isInPopup"];
            DatablockEditorInspectorWindow["wasOpen"] = DatablockEditorInspectorWindow["isInPopup"];
            DecalEditorWindow["wasOpen"] = DecalEditorWindow["isInPopup"];
            DecalPreviewWindow["wasOpen"] = DecalPreviewWindow["isInPopup"];
            ForestEditorPalleteWindow["wasOpen"] = ForestEditorPalleteWindow["isInPopup"];
            ForestEditorPropertiesWindow["wasOpen"] = ForestEditorPropertiesWindow["isInPopup"];
            MeshRoadEditorTreeWindow["wasOpen"] = MeshRoadEditorTreeWindow["isInPopup"];
            MeshRoadEditorOptionsWindow["wasOpen"] = MeshRoadEditorOptionsWindow["isInPopup"];
            MissionAreaEditorTerrainWindow["wasOpen"] = MissionAreaEditorTerrainWindow["isInPopup"];
            MissionAreaEditorPropertiesWindow["wasOpen"] = MissionAreaEditorPropertiesWindow["isInPopup"];
            PE_Window["wasOpen"] = PE_Window["isInPopup"];
            RiverEditorTreeWindow["wasOpen"] = RiverEditorTreeWindow["isInPopup"];
            RiverEditorOptionsWindow["wasOpen"] = RiverEditorOptionsWindow["isInPopup"];
            RoadEditorTreeWindow["wasOpen"] = RoadEditorTreeWindow["isInPopup"];
            RoadEditorOptionsWindow["wasOpen"] = RoadEditorOptionsWindow["isInPopup"];
            ShapeEdAdvancedWindow["wasOpen"] = ShapeEdAdvancedWindow["isInPopup"];
            ShapeEdSelectWindow["wasOpen"] = ShapeEdSelectWindow["isInPopup"];
            ShapeEdPropWindow["wasOpen"] = ShapeEdPropWindow["isInPopup"];

            EWTreeWindow.ClosePopOut();
            EWInspectorWindow.ClosePopOut();
            TerrainPainter.ClosePopOut();
            TerrainPainterPreview.ClosePopOut();
            MaterialEditorPreviewWindow.ClosePopOut();
            MaterialEditorPropertiesWindow.ClosePopOut();
            DatablockEditorTreeWindow.ClosePopOut();
            DatablockEditorInspectorWindow.ClosePopOut();
            DecalEditorWindow.ClosePopOut();
            DecalPreviewWindow.ClosePopOut();
            ForestEditorPalleteWindow.ClosePopOut();
            ForestEditorPropertiesWindow.ClosePopOut();
            MeshRoadEditorTreeWindow.ClosePopOut();
            MeshRoadEditorOptionsWindow.ClosePopOut();
            MissionAreaEditorTerrainWindow.ClosePopOut();
            MissionAreaEditorPropertiesWindow.ClosePopOut();
            PE_Window.ClosePopOut();
            RiverEditorTreeWindow.ClosePopOut();
            RiverEditorOptionsWindow.ClosePopOut();
            RoadEditorTreeWindow.ClosePopOut();
            RoadEditorOptionsWindow.ClosePopOut();
            ShapeEdAdvancedWindow.ClosePopOut();
            ShapeEdSelectWindow.ClosePopOut();
            ShapeEdPropWindow.ClosePopOut();

            this.editorDisabled();
            Canvas.setContent(gui);
           
            EditorGui.writeCameraSettings();

            Util._schedule("1000", "0", "checkCursor");
            checkCursor();
            }

        [ConsoleInteraction]
        public static void checkCursor()
            {
            GuiCanvas Canvas = "Canvas";

            Canvas.checkCursor();
            }

        [ConsoleInteraction]
        public void lightScene(string callback, bool forceAlways)
            {
            GuiControl RelightStatus = "RelightStatus";
            GuiProgressBitmapCtrl RelightProgress = "RelightProgress";
            GuiCanvas Canvas = "Canvas";

            if (bGlobal["$lightingMission"])
                return;

            bGlobal["$lightingMission"] = true;
            sGlobal["$RelightCallback"] = callback;
            RelightStatus.visible = true;
            RelightProgress.setValue("0");
            Canvas.repaint(0);
            omni.Util.lightScene("EditorLightingComplete", forceAlways.AsString());
            updateEditorLightingProgress();
            }

        [ConsoleInteraction]
        public static void EditorLightingComplete()
            {
            GuiControl RelightStatus = "RelightStatus";

            omni.bGlobal["$lightingMission"] = false;
            RelightStatus.visible = false;

            if (omni.sGlobal["$RelightCallback"] != "")
                {
                omni.Util.eval(omni.sGlobal["$RelightCallback"]);
                }

            omni.sGlobal["$RelightCallback"] = "";
            }

        [ConsoleInteraction]
        public static void updateEditorLightingProgress()
            {
            GuiProgressBitmapCtrl RelightProgress = "RelightProgress";

            RelightProgress.setValue(omni.sGlobal["$SceneLighting::lightingProgress"]);
            if (omni.bGlobal["$lightingMission"])
                omni.iGlobal["$lightingProgressThread"] = omni.Util._schedule("1", "0", "updateEditorLightingProgress");
            }

        [ConsoleInteraction]
        public bool validateObjectName(string name, bool mustHaveName)
            {
            if (mustHaveName && name == "")
                {
                messageBox.MessageBoxOK("Missing Object Name",
                    "No name given for object.  Please enter a valid object name.");
                return false;
                }
            if (!omni.Util.isValidObjectName(name))
                {
                messageBox.MessageBoxOK("Invalid Object Name", "'" + name + "' is not a valid object name." + '\n' +
                                                               "" + '\n' +
                                                               "Please choose a name that begins with a letter or underscore and is otherwise comprised " +
                                                               "exclusively of letters, digits, and/or underscores."
                    );
                return false;
                }
            if (name.isObject())
                {
                string filename = ((SimObject) name).getFilename();
                if (filename == "")
                    filename = "an unknown file";

                messageBox.MessageBoxOK("Invalid Object Name", "Object names must be unique, and there is an " +
                                                               "existing " + ((SimObject) name).getClassName() +
                                                               " object with the name '" + name + "' (defined " +
                                                               "in " + filename + ").  Please choose another name.");
                return false;
                }
            if (omni.Util.isClass(name))
                {
                messageBox.MessageBoxOK("Invalid Object Name",
                    "'" + name + "' is the name of an existing TorqueScript " +
                    "class.  Please choose another name.");
                return false;
                }

            return true;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(editor ts, string simobjectid)
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
        public static bool operator !=(editor ts, string simobjectid)
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
        public static implicit operator string(editor ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator editor(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (editor) Omni.self.getSimObject(simobjectid, typeof (editor));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(editor ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator editor(int simobjectid)
            {
            return (editor) Omni.self.getSimObject((uint) simobjectid, typeof (editor));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(editor ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator editor(uint simobjectid)
            {
            return (editor) Omni.self.getSimObject(simobjectid, typeof (editor));
            }

        #endregion
        }
    }