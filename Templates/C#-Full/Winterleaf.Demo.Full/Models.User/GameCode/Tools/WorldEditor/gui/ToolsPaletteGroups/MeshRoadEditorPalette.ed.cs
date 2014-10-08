using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
    {
    public class MeshRoadEditorPalette
        {
        public static uint initialize()
            {
            #region GuiControl (MeshRoadEditorPalette,EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "MeshRoadEditorPalette,EditorGuiGroup");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (EMeshRoadEditorSelectModeBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorSelectModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorSelectModeBtn));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "MeshRoadEditorSelectMode";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "0 0";
            oc_Newobject1["Extent"] = "25 19";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "MeshRoadEditorGui.prepSelectionMode();";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Select Mesh Road (1)";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "tools/gui/images/menubar/arrow";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorMoveModeBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorMoveModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorMoveModeBtn));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "MeshRoadEditorMoveMode";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "25 19";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorMoveMode\\\");";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Move Point (2)";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/road-river/move-point";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorRotateModeBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorRotateModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorRotateModeBtn));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "MeshRoadEditorRotateMode";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "25 19";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorRotateMode\\\");";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Rotate Point (3)";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/road-river/rotate-point";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorScaleModeBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorScaleModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorScaleModeBtn));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "MeshRoadEditorScaleMode";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "25 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorScaleMode\\\");";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Scale Point (4)";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/road-river/scale-point";
            oc_Newobject4["buttonType"] = "RadioButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorAddModeBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorAddModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorAddModeBtn));
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "MeshRoadEditorAddRoadMode";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "25 19";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorAddRoadMode\\\");";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Create Road (5)";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/worldEditor/images/road-river/add-mesh-road";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorInsertModeBtn)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorInsertModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorInsertModeBtn));
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "MeshRoadEditorInsertPointMode";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "25 19";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorInsertPointMode\\\");";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Insert Point (+)";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["bitmap"] = "tools/worldEditor/images/road-river/add-point";
            oc_Newobject6["buttonType"] = "RadioButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorRemoveModeBtn)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorRemoveModeBtn",
                typeof (MeshRoadEditorGui.EMeshRoadEditorRemoveModeBtn));
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "MeshRoadEditorRemovePointMode";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "0 0";
            oc_Newobject7["Extent"] = "25 19";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorRemovePointMode\\\");";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Remove Point (-)";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["bitmap"] = "tools/worldEditor/images/road-river/subtract-point";
            oc_Newobject7["buttonType"] = "RadioButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            return oc_Newobject8.Create();
            }
        }
    }