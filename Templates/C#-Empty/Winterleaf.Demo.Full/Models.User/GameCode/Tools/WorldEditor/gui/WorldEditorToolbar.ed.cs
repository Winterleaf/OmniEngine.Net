using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class WorldEditorToolbar
        {
        [ConsoleInteraction(true, "WorldEditorToolbar_initialize")]
        public static void initialize()
            {
            #region GuiControl (EWorldEditorToolbar, EditorGuiGroup)        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiControl", "EWorldEditorToolbar, EditorGuiGroup");
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["internalName"] = "WorldEditorToolbar";
            oc_Newobject38["Enabled"] = "1";
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject38["HorizSizing"] = "right";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["Position"] = "306 0";
            oc_Newobject38["Extent"] = new ObjectCreator.StringNoQuote("\"550\" SPC getWord(EditorGuiToolbar.extent, 1)");
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "1";

            #region GuiStackControl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject37["StackingType"] = "Horizontal";
            oc_Newobject37["HorizStacking"] = "Left to Right";
            oc_Newobject37["VertStacking"] = "Top to Bottom";
            oc_Newobject37["Padding"] = "0";
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject37["HorizSizing"] = "width";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["Position"] = "0 3";
            oc_Newobject37["Extent"] = "190 31";
            oc_Newobject37["MinExtent"] = "16 16";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["isDecoy"] = "0";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["changeChildSizeToFit"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject37["padding"] = "2";

            #region GuiBitmapButtonCtrl (FitToSelectionBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "FitToSelectionBtn");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "2 3";
            oc_Newobject1["Extent"] = "29 27";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "commandToServer('EditorCameraAutoFit', EWorldEditor.getSelectionRadius()+1);";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Fit View To Selection (F)";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "tools/gui/images/menubar/fit-selection";
            oc_Newobject1["text"] = "";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject37["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["position"] = "34 3";
            oc_Newobject2["Extent"] = "2 26";
            oc_Newobject2["MinExtent"] = "1 1";
            oc_Newobject2["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject37["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["profile"] = "ToolsGuiTextProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "37 7";
            oc_Newobject3["extent"] = "77 16";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["text"] = " World Settings";
            oc_Newobject3["maxLength"] = "255";
            oc_Newobject3["helpTag"] = "0";

            #endregion

            oc_Newobject37["#Newobject3"] = oc_Newobject3;

            #region GuiControl (SnapToBar)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "SnapToBar");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["Position"] = "116 3";
            oc_Newobject9["Extent"] = "123 27";
            oc_Newobject9["Padding"] = "4";

            #region GuiBitmapButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "snappingSettingsBtn";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "29 27";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ESnapOptions.ToggleVisibility();";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Snapping Options";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "ToggleButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["buttonMargin"] = "0 0";
            oc_Newobject5["bitmap"] = "tools/gui/images/menubar/snapping-settings";

            #region GuiBitmapCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject4["HorizSizing"] = "left";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["Position"] = "23 21";
            oc_Newobject4["Extent"] = "4 4";
            oc_Newobject4["MinExtent"] = "4 4";
            oc_Newobject4["bitmap"] = "tools/gui/images/dropdown-button-arrow";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "objectGridSnapBtn";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "31 0";
            oc_Newobject6["Extent"] = "29 27";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "toggleSnappingOptions(\\\"grid\\\");";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Toggles grid snapping (G)";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "ToggleButton";
            oc_Newobject6["useMouseEvents"] = "0";
            //oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["bitmap"] = "tools/gui/images/menubar/snap-grid";
            oc_Newobject6["textMargin"] = "4";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "objectSnapDownBtn";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "62 0";
            oc_Newobject7["Extent"] = "29 27";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "toggleSnappingOptions(\\\"terrain\\\");";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "All objects will snap to the terrain (T)";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "ToggleButton";
            oc_Newobject7["useMouseEvents"] = "0";
            //oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["bitmap"] = "tools/gui/images/menubar/snap-terrain";
            oc_Newobject7["textMargin"] = "4";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["internalName"] = "objectSnapBtn";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "93 0";
            oc_Newobject8["Extent"] = "29 27";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "toggleSnappingOptions(\\\"soft\\\");";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Soft object snapping to other objects (B)";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "ToggleButton";
            oc_Newobject8["useMouseEvents"] = "0";
            //oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["bitmap"] = "tools/gui/images/menubar/snap-objects";
            oc_Newobject8["textMargin"] = "4";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject37["#Newobject9"] = oc_Newobject9;

            #region GuiControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["internalName"] = "softSnapSizeTextEditContainer";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "178 5";
            oc_Newobject12["Extent"] = "56 22";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiTextEditCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "softSnapSizeTextEdit";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 2";
            oc_Newobject10["Extent"] = "42 16";
            oc_Newobject10["MinExtent"] = "8 16";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["AltCommand"] =
                "EWorldEditor.setSoftSnapSize( $ThisControl.getText() ); EWorldEditor.syncGui();";
            oc_Newobject10["tooltip"] = "Object Snapping Distance";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["text"] = "9";
            oc_Newobject10["maxLength"] = "6";
            oc_Newobject10["historySize"] = "0";
            oc_Newobject10["password"] = "0";
            oc_Newobject10["tabComplete"] = "0";
            oc_Newobject10["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "34 2";
            oc_Newobject11["Extent"] = "18 18";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "Canvas.pushDialog(softSnapSizeSliderCtrlContainer);";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["ToolTip"] = "Changes size of the soft snap region";
            oc_Newobject11["hovertime"] = "750";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject37["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["position"] = "269 3";
            oc_Newobject13["Extent"] = "2 26";
            oc_Newobject13["MinExtent"] = "1 1";
            oc_Newobject13["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject37["#Newobject13"] = oc_Newobject13;

            #region GuiBitmapButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["internalName"] = "boundingBoxColBtn";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "274 3";
            oc_Newobject14["Extent"] = "29 27";
            oc_Newobject14["MinExtent"] = "8 8";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["Variable"] = "EWorldEditor.boundingBoxCollision";
            oc_Newobject14["Command"] = "EWorldEditor.boundingBoxCollision = $ThisControl.getValue();";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["ToolTip"] = "Object bounds selection toggle (V)";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["bitmap"] = "tools/gui/images/menubar/select-bounds";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "ToggleButton";
            oc_Newobject14["useMouseEvents"] = "0";

            #endregion

            oc_Newobject37["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["position"] = "307 3";
            oc_Newobject15["Extent"] = "2 26";
            oc_Newobject15["MinExtent"] = "1 1";
            oc_Newobject15["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject37["#Newobject15"] = oc_Newobject15;

            #region GuiControl (ToggleButtonBar)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiControl", "ToggleButtonBar");
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["Position"] = "313 3";
            oc_Newobject20["Extent"] = "65 27";

            #region GuiBitmapButtonCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "centerObject";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "0 0";
            oc_Newobject17["Extent"] = "29 27";
            oc_Newobject17["MinExtent"] = "8 8";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["Command"] = "objectCenterDropdown.toggle();";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["ToolTip"] = "Toggles object center (O) and bounds center (P)";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["bitmap"] = "tools/gui/images/menubar/object-center";
            oc_Newobject17["text"] = "Button";
            oc_Newobject17["groupNum"] = "-1";
            oc_Newobject17["buttonType"] = "ToggleButton";
            oc_Newobject17["useMouseEvents"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject16["HorizSizing"] = "left";
            oc_Newobject16["VertSizing"] = "top";
            oc_Newobject16["Position"] = "23 21";
            oc_Newobject16["Extent"] = "4 4";
            oc_Newobject16["MinExtent"] = "4 4";
            oc_Newobject16["bitmap"] = "tools/gui/images/dropdown-button-arrow";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject20["#Newobject17"] = oc_Newobject17;

            #region GuiBitmapButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["internalName"] = "objectTransform";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "31 0";
            oc_Newobject19["Extent"] = "29 27";
            oc_Newobject19["MinExtent"] = "8 8";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["Command"] = "objectTransformDropdown.toggle();";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["ToolTip"] = "Toggles object transform (K) and world transform (L)";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["bitmap"] = "tools/gui/images/menubar/world-transform";
            oc_Newobject19["groupNum"] = "-1";
            oc_Newobject19["buttonType"] = "ToggleButton";
            oc_Newobject19["text"] = "";

            #region GuiBitmapCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject18["HorizSizing"] = "left";
            oc_Newobject18["VertSizing"] = "top";
            oc_Newobject18["Position"] = "23 21";
            oc_Newobject18["Extent"] = "4 4";
            oc_Newobject18["MinExtent"] = "4 4";
            oc_Newobject18["bitmap"] = "tools/gui/images/dropdown-button-arrow";

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject37["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["position"] = "379 3";
            oc_Newobject21["Extent"] = "2 26";
            oc_Newobject21["MinExtent"] = "1 1";
            oc_Newobject21["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject37["#Newobject21"] = oc_Newobject21;

            #region GuiControl (ToggleNodeBar)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiControl", "ToggleNodeBar");
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["Position"] = "386 3";
            oc_Newobject24["Extent"] = "63 27";

            #region GuiBitmapButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["internalName"] = "renderHandleBtn";
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "0 0";
            oc_Newobject22["Extent"] = "29 27";
            oc_Newobject22["MinExtent"] = "8 8";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["Variable"] = "EWorldEditor.renderObjHandle";
            oc_Newobject22["Command"] = "EWorldEditor.renderObjHandle = $ThisControl.getValue();";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["ToolTip"] = "Enables Render of Object Node Icons (N)";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["bitmap"] = "tools/gui/images/menubar/object-node-icon";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["buttonType"] = "ToggleButton";
            oc_Newobject22["useMouseEvents"] = "0";

            #endregion

            oc_Newobject24["#Newobject22"] = oc_Newobject22;

            #region GuiBitmapButtonCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["internalName"] = "renderTextBtn";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "33 0";
            oc_Newobject23["Extent"] = "29 27";
            oc_Newobject23["MinExtent"] = "8 8";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["Variable"] = "EWorldEditor.renderObjText";
            oc_Newobject23["Command"] = "EWorldEditor.renderObjText = $ThisControl.getValue();";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["ToolTip"] = "Enables Render of Object Node Lables (SHIFT N)";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["bitmap"] = "tools/gui/images/menubar/object-node-lable";
            oc_Newobject23["text"] = "";
            oc_Newobject23["groupNum"] = "-1";
            oc_Newobject23["buttonType"] = "ToggleButton";
            oc_Newobject23["useMouseEvents"] = "0";

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject37["#Newobject24"] = oc_Newobject24;

            #region GuiBitmapCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["position"] = "379 3";
            oc_Newobject25["Extent"] = "2 26";
            oc_Newobject25["MinExtent"] = "1 1";
            oc_Newobject25["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject37["#Newobject25"] = oc_Newobject25;

            #region GuiControl (PrefabBar)        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiControl", "PrefabBar");
            oc_Newobject28["isContainer"] = "1";
            oc_Newobject28["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject28["Position"] = "386 3";
            oc_Newobject28["Extent"] = "63 27";
            oc_Newobject28["visible"] = new ObjectCreator.StringNoQuote("true");

            #region GuiBitmapButtonCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["internalName"] = "makePrefabBtn";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "0 0";
            oc_Newobject26["Extent"] = "29 27";
            oc_Newobject26["MinExtent"] = "8 8";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["Variable"] = "";
            oc_Newobject26["Command"] = "EditorMakePrefab();";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["ToolTip"] = "Make the Selection a Prefab.";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["bitmap"] = "tools/gui/images/menubar/selection-to-prefab";
            oc_Newobject26["groupNum"] = "-1";
            oc_Newobject26["buttonType"] = "PushButton";
            oc_Newobject26["useMouseEvents"] = "0";

            #endregion

            oc_Newobject28["#Newobject26"] = oc_Newobject26;

            #region GuiBitmapButtonCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["internalName"] = "explodePrefabBtn";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["Position"] = "33 0";
            oc_Newobject27["Extent"] = "29 27";
            oc_Newobject27["MinExtent"] = "8 8";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["Variable"] = "";
            oc_Newobject27["Command"] = "EditorExplodePrefab();";
            oc_Newobject27["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject27["ToolTip"] = "Explode the Selected Prefab.";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["bitmap"] = "tools/gui/images/menubar/explode-prefab";
            oc_Newobject27["text"] = "";
            oc_Newobject27["groupNum"] = "-1";
            oc_Newobject27["buttonType"] = "PushButton";
            oc_Newobject27["useMouseEvents"] = "0";

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject37["#Newobject28"] = oc_Newobject28;

            #region GuiContainer (objectCenterDropdown)        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiContainer", "objectCenterDropdown",
                typeof (EditorGui.objectCenterDropdown));
            oc_Newobject32["Profile"] = "IconDropdownProfile";
            oc_Newobject32["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(EWorldEditorToolbar.position, 0)+getWord(ToggleButtonBar.Position, 0)+getWord(EWorldEditorToolbar-->centerObject.position, 0)-5 SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject32["Extent"] = "132 62";
            oc_Newobject32["isContainer"] = "1";
            oc_Newobject32["visible"] = "0";

            #region GuiIconButtonCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["internalName"] = "objectBoxBtn";
            oc_Newobject29["Enabled"] = "1";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["Position"] = "5 5";
            oc_Newobject29["Extent"] = "122 25";
            oc_Newobject29["MinExtent"] = "8 8";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["Command"] =
                "EWorldEditor.objectsUseBoxCenter = 0; EWorldEditor.syncGui(); objectCenterDropdown.toggle(); ";
            oc_Newobject29["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["ToolTip"] = "Use object defined center (O)";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["iconBitmap"] = "tools/gui/images/menubar/object-center_n";
            oc_Newobject29["text"] = "Object Center";
            oc_Newobject29["buttonMargin"] = "0 4";
            oc_Newobject29["textMargin"] = "38";
            oc_Newobject29["groupNum"] = "0";
            oc_Newobject29["buttonType"] = "RadioButton";
            oc_Newobject29["useMouseEvents"] = "0";

            #endregion

            oc_Newobject32["#Newobject29"] = oc_Newobject29;

            #region GuiIconButtonCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["internalName"] = "objectBoundsBtn";
            oc_Newobject30["Enabled"] = "1";
            oc_Newobject30["isContainer"] = "0";
            oc_Newobject30["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["Position"] = "5 33 ";
            oc_Newobject30["Extent"] = "122 25";
            oc_Newobject30["MinExtent"] = "8 8";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["Command"] =
                "EWorldEditor.objectsUseBoxCenter = 1; EWorldEditor.syncGui(); objectCenterDropdown.toggle(); ";
            oc_Newobject30["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["ToolTip"] = "Use bounding box center (P)";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["iconBitmap"] = "tools/gui/images/menubar/bounds-center_n";
            oc_Newobject30["text"] = "Bounds Center";
            oc_Newobject30["buttonMargin"] = "0 4";
            oc_Newobject30["textMargin"] = "38";
            oc_Newobject30["groupNum"] = "0";
            oc_Newobject30["buttonType"] = "RadioButton";
            oc_Newobject30["useMouseEvents"] = "0";

            #endregion

            oc_Newobject32["#Newobject30"] = oc_Newobject30;

            #region GuiDecoyCtrl (objectCenterDropdownDecoy)        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiDecoyCtrl", "objectCenterDropdownDecoy",
                typeof (EditorGui.objectCenterDropdownDecoy));
            oc_Newobject31["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["position"] = "0 0";
            oc_Newobject31["extent"] = "132 62";
            oc_Newobject31["minExtent"] = "8 8";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["helpTag"] = "0";
            oc_Newobject31["useMouseEvents"] = "1";
            oc_Newobject31["isDecoy"] = "1";

            #endregion

            oc_Newobject32["#Newobject31"] = oc_Newobject31;

            #endregion

            oc_Newobject37["#Newobject32"] = oc_Newobject32;

            #region GuiContainer (objectTransformDropdown)        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiContainer", "objectTransformDropdown",
                typeof (EditorGui.objectTransformDropdown));
            oc_Newobject36["Profile"] = "IconDropdownProfile";
            oc_Newobject36["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(EWorldEditorToolbar.position, 0)+getWord(ToggleButtonBar.position, 0)+getWord(EWorldEditorToolbar-->objectTransform.position, 0)-5 SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject36["Extent"] = "147 62";
            oc_Newobject36["isContainer"] = "1";
            oc_Newobject36["visible"] = "0";

            #region GuiIconButtonCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["internalName"] = "worldTransformBtn";
            oc_Newobject33["Enabled"] = "1";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "GuiIconProfile";
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["Position"] = "5 5";
            oc_Newobject33["Extent"] = "137 25";
            oc_Newobject33["MinExtent"] = "8 8";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["Command"] =
                "GlobalGizmoProfile.setFieldValue(alignment, World);  EWorldEditor.syncGui(); objectTransformDropdown.toggle(); ";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["ToolTip"] = "Use world normal for transformations (L)";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["iconBitmap"] = "tools/gui/images/menubar/world-transform_n";
            oc_Newobject33["text"] = "World Transform";
            oc_Newobject33["buttonMargin"] = "0 4";
            oc_Newobject33["textMargin"] = "38";
            oc_Newobject33["groupNum"] = "0";
            oc_Newobject33["buttonType"] = "RadioButton";
            oc_Newobject33["useMouseEvents"] = "0";

            #endregion

            oc_Newobject36["#Newobject33"] = oc_Newobject33;

            #region GuiIconButtonCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["internalName"] = "objectTransformBtn";
            oc_Newobject34["Enabled"] = "1";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["Position"] = "5 33";
            oc_Newobject34["Extent"] = "137 25";
            oc_Newobject34["MinExtent"] = "8 8";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["Command"] =
                "GlobalGizmoProfile.setFieldValue(alignment, Object); EWorldEditor.syncGui(); objectTransformDropdown.toggle(); ";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["ToolTip"] = "Use object normal for transformations (K)";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["iconBitmap"] = "tools/gui/images/menubar/object-transform_n";
            oc_Newobject34["text"] = "Object Transform";
            oc_Newobject34["buttonMargin"] = "0 4";
            oc_Newobject34["textMargin"] = "38";
            oc_Newobject34["groupNum"] = "0";
            oc_Newobject34["buttonType"] = "RadioButton";
            oc_Newobject34["useMouseEvents"] = "0";

            #endregion

            oc_Newobject36["#Newobject34"] = oc_Newobject34;

            #region GuiDecoyCtrl (objectTransformDropdownDecoy)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiDecoyCtrl", "objectTransformDropdownDecoy",
                typeof (EditorGui.objectTransformDropdownDecoy));
            oc_Newobject35["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject35["horizSizing"] = "right";
            oc_Newobject35["vertSizing"] = "bottom";
            oc_Newobject35["position"] = "0 0";
            oc_Newobject35["extent"] = "147 62";
            oc_Newobject35["minExtent"] = "8 8";
            oc_Newobject35["visible"] = "1";
            oc_Newobject35["helpTag"] = "0";
            oc_Newobject35["useMouseEvents"] = "1";
            oc_Newobject35["isDecoy"] = "1";

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject38.Create();

            #region GuiMouseEventCtrl (softSnapSizeSliderCtrlContainer, EditorGuiGroup)        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiMouseEventCtrl",
                "softSnapSizeSliderCtrlContainer, EditorGuiGroup", typeof (EditorGui.softSnapSizeSliderCtrlContainer));
            oc_Newobject40["horizSizing"] = "right";
            oc_Newobject40["vertSizing"] = "bottom";
            oc_Newobject40["position"] = "0 0";
            oc_Newobject40["extent"] = "1024 768";
            oc_Newobject40["minExtent"] = "8 8";
            oc_Newobject40["visible"] = "1";
            oc_Newobject40["helpTag"] = "0";
            //oc_Newobject40["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["internalName"] = "slider";
            oc_Newobject39["isContainer"] = "0";
            oc_Newobject39["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject39["HorizSizing"] = "right";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["position"] =
                new ObjectCreator.StringNoQuote(
                    "firstWord(EWorldEditorToolbar-->softSnapSizeTextEdit.getGlobalPosition()) - 12 SPC          (getWord(EWorldEditorToolbar-->softSnapSizeTextEdit.getGlobalPosition(), 1)) + 18");
            oc_Newobject39["Extent"] = "112 20";
            oc_Newobject39["MinExtent"] = "8 2";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["Visible"] = "1";
            oc_Newobject39["AltCommand"] = "softSnapSizeSliderCtrlContainer.onSliderChanged();";
            oc_Newobject39["range"] = "0.01 10";
            oc_Newobject39["ticks"] = "0";
            oc_Newobject39["value"] = "0";

            #endregion

            oc_Newobject40["#Newobject39"] = oc_Newobject39;

            #endregion

            oc_Newobject40.Create();
            }
        }
    }