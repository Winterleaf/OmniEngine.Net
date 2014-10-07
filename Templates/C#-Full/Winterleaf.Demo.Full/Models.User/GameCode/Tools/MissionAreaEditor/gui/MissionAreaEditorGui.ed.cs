using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<MissionAreaEditorGui>))]
    public class MissionAreaEditorGui : GuiMissionAreaEditorCtrl
        {
        public MissionArea missionArea
            {
            get { return this["missionArea"]; }
            set { this["missionArea"] = value; }
            }

        [ConsoleInteraction(true, "MissionAreaEditorGui_initialize")]
        public static void initialize()
            {
            #region GuiMissionAreaEditorCtrl (MissionAreaEditorGui, EditorGuiGroup)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiMissionAreaEditorCtrl",
                "MissionAreaEditorGui, EditorGuiGroup", typeof (MissionAreaEditorGui));
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "MissionAreaEditorProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "height";
            oc_Newobject11["Position"] = "0 0";
            oc_Newobject11["Extent"] = "800 600";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Docking"] = "None";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "0";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "0";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["cameraZRot"] = "0";
            oc_Newobject11["forceFOV"] = "0";
            oc_Newobject11["renderMissionArea"] = "0";
            oc_Newobject11["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject11["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject11["allowBorderMove"] = "0";
            oc_Newobject11["borderMovePixelSize"] = "20";
            oc_Newobject11["borderMoveSpeed"] = "0.1";
            oc_Newobject11["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject11["consoleFillColor"] = "0 0 0 0";
            oc_Newobject11["consoleSphereLevel"] = "1";
            oc_Newobject11["consoleCircleSegments"] = "32";
            oc_Newobject11["consoleLineWidth"] = "1";
            oc_Newobject11["GizmoProfile"] = "GlobalGizmoProfile";

            #region GuiWindowCollapseCtrl (MissionAreaEditorTerrainWindow)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiWindowCollapseCtrl", "MissionAreaEditorTerrainWindow");
            oc_Newobject3["internalName"] = "MissionAreaEditorTerrainWindow";
            oc_Newobject3["AllowPopWindow"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject3["HorizSizing"] = "windowRelative";
            oc_Newobject3["VertSizing"] = "windowRelative";
            oc_Newobject3["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) - 1");
            oc_Newobject3["Extent"] = "210 230";
            oc_Newobject3["MinExtent"] = "210 100";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["resizeWidth"] = "1";
            oc_Newobject3["resizeHeight"] = "1";
            oc_Newobject3["canMove"] = "1";
            oc_Newobject3["canClose"] = "0";
            oc_Newobject3["canMinimize"] = "0";
            oc_Newobject3["canMaximize"] = "0";
            oc_Newobject3["minSize"] = "50 50";
            oc_Newobject3["EdgeSnap"] = "1";
            oc_Newobject3["text"] = "Mission Area";

            #region GuiContainer ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiContainer", "");
            oc_Newobject2["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["Position"] = "5 25";
            oc_Newobject2["Extent"] = "200 200";
            oc_Newobject2["Docking"] = "Client";
            oc_Newobject2["Margin"] = "3 1 3 3 ";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["isContainer"] = "1";

            #region GuiMissionAreaCtrl (MissionAreaEditorTerrainEditor)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiMissionAreaCtrl", "MissionAreaEditorTerrainEditor",
                typeof (MissionAreaEditorTerrainEditor));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "EditorDefaultProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["Extent"] = "200 200";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["wrap"] = "0";
            oc_Newobject1["enableMirroring"] = "0";
            oc_Newobject1["mirrorIndex"] = "0";
            oc_Newobject1["mirrorLineColor"] = "255 0 255 255";
            oc_Newobject1["mirrorArrowColor"] = "255 0 255 128";
            oc_Newobject1["handleFrameColor"] = "255 255 255 255";
            oc_Newobject1["handleFillColor"] = "0 0 0 255";
            oc_Newobject1["defaultObjectColor"] = "0 255 0 100";
            oc_Newobject1["waterObjectColor"] = "0 0 255 100";
            oc_Newobject1["missionBoundsColor"] = "255 0 0 255";
            oc_Newobject1["cameraColor"] = "255 0 0 255";
            oc_Newobject1["squareBitmap"] = "1";
            oc_Newobject1["enableEditing"] = "0";
            oc_Newobject1["renderCamera"] = "1";
            oc_Newobject1["handleBitmap"] = "tools/missionAreaEditor/images/DefaultHandle.png";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiWindowCollapseCtrl (MissionAreaEditorPropertiesWindow)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiWindowCollapseCtrl",
                "MissionAreaEditorPropertiesWindow");
            oc_Newobject10["internalName"] = "MissionAreaEditorPropertiesWindow";
            oc_Newobject10["AllowPopWindow"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject10["HorizSizing"] = "windowRelative";
            oc_Newobject10["VertSizing"] = "windowRelative";
            oc_Newobject10["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209          SPC getWord(EditorGuiToolbar.extent, 1) + getWord(MissionAreaEditorTerrainWindow.extent, 1) - 2");
            oc_Newobject10["Extent"] = "210 466";
            oc_Newobject10["MinExtent"] = "210 300";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "0";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "0";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["resizeWidth"] = "1";
            oc_Newobject10["resizeHeight"] = "1";
            oc_Newobject10["canMove"] = "1";
            oc_Newobject10["canClose"] = "0";
            oc_Newobject10["canMinimize"] = "0";
            oc_Newobject10["canMaximize"] = "0";
            oc_Newobject10["minSize"] = "50 50";
            oc_Newobject10["EdgeSnap"] = "1";
            oc_Newobject10["text"] = "Properties";

            #region GuiContainer ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiContainer", "");
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "4 112";
            oc_Newobject5["Extent"] = "202 31";
            oc_Newobject5["Docking"] = "Top";
            oc_Newobject5["Margin"] = "0 0 3 3";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "5 0";
            oc_Newobject4["Extent"] = "121 18";
            oc_Newobject4["text"] = "Mission Area Properties";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiScrollCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "height";
            oc_Newobject7["Position"] = "4 129";
            oc_Newobject7["Extent"] = "202 357";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Docking"] = "Client";
            oc_Newobject7["Margin"] = "-14 0 3 3";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "0";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "0";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["willFirstRespond"] = "1";
            oc_Newobject7["hScrollBar"] = "alwaysOff";
            oc_Newobject7["vScrollBar"] = "dynamic";
            oc_Newobject7["lockHorizScroll"] = "true";
            oc_Newobject7["lockVertScroll"] = "false";
            oc_Newobject7["constantThumbHeight"] = "0";
            oc_Newobject7["childMargin"] = "0 0";

            #region GuiInspector (MissionAreaInspector)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiInspector", "MissionAreaInspector",
                typeof (MissionAreaInspector));
            oc_Newobject6["StackingType"] = "Vertical";
            oc_Newobject6["HorizStacking"] = "Left to Right";
            oc_Newobject6["VertStacking"] = "Top to Bottom";
            oc_Newobject6["Padding"] = "1";
            oc_Newobject6["name"] = "MissionAreaInspector";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "1 1";
            oc_Newobject6["Extent"] = "178 16";
            oc_Newobject6["MinExtent"] = "16 16";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["dividerMargin"] = "5";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiContainer ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiContainer", "");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "1 0";
            oc_Newobject9["Extent"] = "202 42";
            oc_Newobject9["Docking"] = "Bottom";
            oc_Newobject9["Margin"] = "0 0 3 3";

            #region GuiMLTextCtrl (MissionAreaFieldInfoControl)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiMLTextCtrl", "MissionAreaFieldInfoControl");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "top";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "202 42";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["lineSpacing"] = "2";
            oc_Newobject8["allowColorChars"] = "0";
            oc_Newobject8["maxChars"] = "-1";
            oc_Newobject8["useURLMouseCursor"] = "0";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject11.Create();
            }

        [ConsoleInteraction]
        public void onEditorActivated()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            GuiMissionAreaCtrl MissionAreaEditorTerrainEditor = "MissionAreaEditorTerrainEditor";
            EWorldEditor.clearSelection();

            MissionArea ma = Util.getMissionAreaServerObject();
            EWorldEditor.selectObject(ma);
            EWorldEditor.syncGui();
            MissionAreaEditorTerrainEditor.updateTerrain();
            this.setSelectedMissionArea(ma);
            this.onMissionAreaSelected(this.getSelectedMissionArea());
            }

        [ConsoleInteraction]
        public void onEditorDeactivated()
            {
            }

        [ConsoleInteraction]
        public void onMissionAreaSelected(string missionArea)
            {
            GuiMissionAreaCtrl MissionAreaEditorTerrainEditor = "MissionAreaEditorTerrainEditor";
            GuiInspector MissionAreaInspector = "MissionAreaInspector";

            this.missionArea = missionArea;
            MissionAreaEditorTerrainEditor.setMissionArea(missionArea);
            MissionAreaInspector.inspect(missionArea);
            }

        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<MissionAreaEditorTerrainEditor>))]
        public class MissionAreaEditorTerrainEditor : GuiMissionAreaCtrl
            {
            [ConsoleInteraction]
            public override void onMissionAreaModified()
                {
                GuiInspector MissionAreaInspector = "MissionAreaInspector";
                MissionAreaInspector.refresh();
                }

            [ConsoleInteraction]
            public override void onUndo()
                {
                GuiInspector MissionAreaInspector = "MissionAreaInspector";
                MissionAreaInspector.refresh();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MissionAreaEditorTerrainEditor ts, string simobjectid)
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
            public static bool operator !=(MissionAreaEditorTerrainEditor ts, string simobjectid)
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
            public static implicit operator string(MissionAreaEditorTerrainEditor ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MissionAreaEditorTerrainEditor(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (MissionAreaEditorTerrainEditor)
                        Omni.self.getSimObject(simobjectid, typeof (MissionAreaEditorTerrainEditor));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MissionAreaEditorTerrainEditor ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MissionAreaEditorTerrainEditor(int simobjectid)
                {
                return
                    (MissionAreaEditorTerrainEditor)
                        Omni.self.getSimObject((uint) simobjectid, typeof (MissionAreaEditorTerrainEditor));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MissionAreaEditorTerrainEditor ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MissionAreaEditorTerrainEditor(uint simobjectid)
                {
                return
                    (MissionAreaEditorTerrainEditor)
                        Omni.self.getSimObject(simobjectid, typeof (MissionAreaEditorTerrainEditor));
                }

            #endregion
            }

        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<MissionAreaInspector>))]
        public class MissionAreaInspector : GuiInspector
            {
            [ConsoleInteraction]
            public void inspect(SimObject obj)
                {
                GuiMLTextCtrl MissionAreaFieldInfoControl = "MissionAreaFieldInfoControl";
                string name = "";
                if (obj.isObject())
                    name = obj.getName();
                else
                    MissionAreaFieldInfoControl.setText("");

                //RiverInspectorNameEdit.setValue( %name );
                base.inspect(obj);
                }

            [ConsoleInteraction]
            public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
                {
                    Inspector Inspector = "Inspector";

                // Same work to do as for the regular WorldEditor Inspector.
                    Inspector.onInspectorFieldModified(objectx, fieldName,arrayIndex, oldValue, newValue);
                }

            [ConsoleInteraction]
            public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
                {
                GuiMLTextCtrl MissionAreaFieldInfoControl = "MissionAreaFieldInfoControl";
                MissionAreaFieldInfoControl.setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" +
                                                    fieldTypeStr + ") " + '\n' + "<font:Arial:14>" + fieldDoc);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MissionAreaInspector ts, string simobjectid)
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
            public static bool operator !=(MissionAreaInspector ts, string simobjectid)
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
            public static implicit operator string(MissionAreaInspector ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MissionAreaInspector(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (MissionAreaInspector) Omni.self.getSimObject(simobjectid, typeof (MissionAreaInspector));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MissionAreaInspector ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MissionAreaInspector(int simobjectid)
                {
                return (MissionAreaInspector) Omni.self.getSimObject((uint) simobjectid, typeof (MissionAreaInspector));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MissionAreaInspector ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MissionAreaInspector(uint simobjectid)
                {
                return (MissionAreaInspector) Omni.self.getSimObject(simobjectid, typeof (MissionAreaInspector));
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
        public static bool operator ==(MissionAreaEditorGui ts, string simobjectid)
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
        public static bool operator !=(MissionAreaEditorGui ts, string simobjectid)
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
        public static implicit operator string(MissionAreaEditorGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MissionAreaEditorGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MissionAreaEditorGui) Omni.self.getSimObject(simobjectid, typeof (MissionAreaEditorGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MissionAreaEditorGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MissionAreaEditorGui(int simobjectid)
            {
            return (MissionAreaEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (MissionAreaEditorGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MissionAreaEditorGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MissionAreaEditorGui(uint simobjectid)
            {
            return (MissionAreaEditorGui) Omni.self.getSimObject(simobjectid, typeof (MissionAreaEditorGui));
            }

        #endregion
        }
    }