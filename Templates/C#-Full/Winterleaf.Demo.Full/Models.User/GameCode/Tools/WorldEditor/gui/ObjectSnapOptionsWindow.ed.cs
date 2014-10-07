using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class ObjectSnapOptionsWindow
        {
        [ConsoleInteraction(true, "ObjectSnapOptionsWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl (ObjectSnapOptionsContainer, EditorGuiGroup)        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiControl", "ObjectSnapOptionsContainer, EditorGuiGroup");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["Enabled"] = "1";
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["Profile"] = "ToolsGuiModelessDialogProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["Position"] = "0 0";
            oc_Newobject41["Extent"] = "800 600";
            oc_Newobject41["MinExtent"] = "8 2";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["isDecoy"] = "0";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (ESnapOptions)        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiWindowCollapseCtrl", "ESnapOptions",
                typeof (ESnapOptions));
            oc_Newobject40["AllowPopWindow"] = "1";
            oc_Newobject40["internalName"] = "SnapOptionsWindow";
            oc_Newobject40["Enabled"] = "1";
            oc_Newobject40["isContainer"] = "1";
            oc_Newobject40["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject40["HorizSizing"] = "windowRelative";
            oc_Newobject40["VertSizing"] = "windowRelative";
            oc_Newobject40["resizeWidth"] = "0";
            oc_Newobject40["resizeHeight"] = "1";
            oc_Newobject40["canClose"] = "1";
            oc_Newobject40["canMinimize"] = "0";
            oc_Newobject40["canMaximize"] = "0";
            oc_Newobject40["position"] = "400 31";
            oc_Newobject40["extent"] = " 175 257";
            oc_Newobject40["MinExtent"] = "175 130";
            oc_Newobject40["text"] = "Snap Options";
            oc_Newobject40["closeCommand"] = "ESnapOptions.hideDialog();";
            oc_Newobject40["EdgeSnap"] = "0";
            oc_Newobject40["canCollapse"] = "0";
            oc_Newobject40["visible"] = "0";
            oc_Newobject40["Margin"] = "5 5 5 5";
            oc_Newobject40["Padding"] = "5 5 5 5";

            #region GuiTabBookCtrl (ESnapOptionsTabBook)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiTabBookCtrl", "ESnapOptionsTabBook");
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["isContainer"] = "1";
            oc_Newobject35["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject35["HorizSizing"] = "width";
            oc_Newobject35["VertSizing"] = "height";
            oc_Newobject35["Position"] = "5 52";
            oc_Newobject35["Extent"] = "190 240";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["Docking"] = "Client";
            oc_Newobject35["Margin"] = "3 22 3 3";
            oc_Newobject35["Padding"] = "0 0 0 0";
            oc_Newobject35["AnchorTop"] = "1";
            oc_Newobject35["AnchorBottom"] = "0";
            oc_Newobject35["AnchorLeft"] = "1";
            oc_Newobject35["AnchorRight"] = "0";
            oc_Newobject35["TabPosition"] = "Top";
            oc_Newobject35["TabMargin"] = "10";
            oc_Newobject35["MinTabWidth"] = "8";

            #region GuiTabPageCtrl (ESnapOptionsTabTerrain)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTabPageCtrl", "ESnapOptionsTabTerrain");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "height";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Position"] = "0 19";
            oc_Newobject13["Extent"] = "190 220";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "0";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["Docking"] = "None";
            oc_Newobject13["text"] = "Terrain";
            oc_Newobject13["maxLength"] = "255";
            oc_Newobject13["command"] = "toggleSnappingOptions(\\\"terrain\\\");";

            #region GuiScrollCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "height";
            oc_Newobject12["Docking"] = "Client";
            oc_Newobject12["Position"] = "4 12";
            oc_Newobject12["Extent"] = "156 190";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["isDecoy"] = "0";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["willFirstRespond"] = "1";
            oc_Newobject12["hScrollBar"] = "alwaysOff";
            oc_Newobject12["vScrollBar"] = "dynamic";
            oc_Newobject12["lockHorizScroll"] = "true";
            oc_Newobject12["lockVertScroll"] = "false";
            oc_Newobject12["constantThumbHeight"] = "0";
            oc_Newobject12["childMargin"] = "2 2";

            #region GuiStackControl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject11["StackingType"] = "Vertical";
            oc_Newobject11["HorizStacking"] = "Left to Right";
            oc_Newobject11["VertStacking"] = "Top to Bottom";
            oc_Newobject11["Padding"] = "0";
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "0 0";
            oc_Newobject11["Extent"] = "190 90";
            oc_Newobject11["MinExtent"] = "16 16";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["internalName"] = "TerrainSnapAlignment";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "0 18";
            oc_Newobject9["Extent"] = "190 72";
            oc_Newobject9["MinExtent"] = "16 16";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["isDecoy"] = "0";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["colCount"] = "2";
            oc_Newobject9["colSize"] = "78";
            oc_Newobject9["rowSize"] = "20";
            oc_Newobject9["rowSpacing"] = "2";
            oc_Newobject9["colSpacing"] = "2";
            oc_Newobject9["dynamicSize"] = new ObjectCreator.StringNoQuote("true");

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["Extent"] = "190 18";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["text"] = "  Alignment:";
            oc_Newobject1["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiRadioCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiRadioCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "NoAlignment";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiRadioProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "40 18";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"None\\\");";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["text"] = "None";
            oc_Newobject2["groupNum"] = "1";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiIconButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "negX";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "40 20";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"-X\\\");";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "- X Axis";
            oc_Newobject3["iconBitmap"] = "tools/gui/images/axis-icon_-x";
            oc_Newobject3["textMargin"] = "24";
            oc_Newobject3["groupNum"] = "1";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiIconButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "posX";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "40 20";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"+X\\\");";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["text"] = "+ X Axis";
            oc_Newobject4["iconBitmap"] = "tools/gui/images/axis-icon_x";
            oc_Newobject4["textMargin"] = "24";
            oc_Newobject4["groupNum"] = "1";
            oc_Newobject4["buttonType"] = "RadioButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiIconButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "negY";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "40 20";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"-Y\\\");";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = "- Y Axis";
            oc_Newobject5["iconBitmap"] = "tools/gui/images/axis-icon_-y";
            oc_Newobject5["textMargin"] = "24";
            oc_Newobject5["groupNum"] = "1";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiIconButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "posY";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "40 20";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"+Y\\\");";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "+ Y Axis";
            oc_Newobject6["iconBitmap"] = "tools/gui/images/axis-icon_y";
            oc_Newobject6["textMargin"] = "24";
            oc_Newobject6["groupNum"] = "1";
            oc_Newobject6["buttonType"] = "RadioButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiIconButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "negZ";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "0 0";
            oc_Newobject7["Extent"] = "40 20";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"-Z\\\");";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "- Z Axis";
            oc_Newobject7["iconBitmap"] = "tools/gui/images/axis-icon_-z";
            oc_Newobject7["textMargin"] = "24";
            oc_Newobject7["groupNum"] = "1";
            oc_Newobject7["buttonType"] = "RadioButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiIconButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["internalName"] = "posZ";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "40 20";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "ESnapOptions.setTerrainSnapAlignment(\\\"+Z\\\");";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["text"] = "+ Z Axis";
            oc_Newobject8["iconBitmap"] = "tools/gui/images/axis-icon_z";
            oc_Newobject8["textMargin"] = "24";
            oc_Newobject8["groupNum"] = "1";
            oc_Newobject8["buttonType"] = "RadioButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["useInactiveState"] = "0";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiCheckBoxCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject10["text"] = "Snap to object bounding box";
            oc_Newobject10["groupNum"] = "1";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "top";
            oc_Newobject10["position"] = "4 249";
            oc_Newobject10["extent"] = "165 24";
            oc_Newobject10["minExtent"] = "8 8";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["Variable"] = "EWorldEditor.dropAtBounds";
            oc_Newobject10["Command"] = "EWorldEditor.dropAtBounds = $ThisControl.getValue();";
            oc_Newobject10["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject35["#Newobject13"] = oc_Newobject13;

            #region GuiTabPageCtrl (ESnapOptionsTabSoft)        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTabPageCtrl", "ESnapOptionsTabSoft");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject34["HorizSizing"] = "width";
            oc_Newobject34["VertSizing"] = "height";
            oc_Newobject34["Margin"] = "0 0 0 0";
            oc_Newobject34["Position"] = "0 19";
            oc_Newobject34["Extent"] = "190 220";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "0";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["Docking"] = "None";
            oc_Newobject34["text"] = "Soft";
            oc_Newobject34["maxLength"] = "255";
            oc_Newobject34["command"] = "toggleSnappingOptions(\\\"soft\\\");";

            #region GuiScrollCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["Enabled"] = "1";
            oc_Newobject33["isContainer"] = "1";
            oc_Newobject33["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject33["HorizSizing"] = "width";
            oc_Newobject33["VertSizing"] = "height";
            oc_Newobject33["Docking"] = "Client";
            oc_Newobject33["Position"] = "4 12";
            oc_Newobject33["Extent"] = "186 190";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["isDecoy"] = "0";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["Margin"] = "0 0 0 0";
            oc_Newobject33["Padding"] = "0 0 0 0";
            oc_Newobject33["AnchorTop"] = "1";
            oc_Newobject33["AnchorBottom"] = "0";
            oc_Newobject33["AnchorLeft"] = "1";
            oc_Newobject33["AnchorRight"] = "0";
            oc_Newobject33["willFirstRespond"] = "1";
            oc_Newobject33["hScrollBar"] = "alwaysOff";
            oc_Newobject33["vScrollBar"] = "dynamic";
            oc_Newobject33["lockHorizScroll"] = "true";
            oc_Newobject33["lockVertScroll"] = "false";
            oc_Newobject33["constantThumbHeight"] = "0";
            oc_Newobject33["childMargin"] = "2 2";

            #region GuiStackControl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject32["StackingType"] = "Vertical";
            oc_Newobject32["HorizStacking"] = "Left to Right";
            oc_Newobject32["VertStacking"] = "Top to Bottom";
            oc_Newobject32["Padding"] = "5";
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["internalName"] = "theVisOptionsList";
            oc_Newobject32["Enabled"] = "1";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["Position"] = "2 2";
            oc_Newobject32["Extent"] = "190 190";
            oc_Newobject32["MinExtent"] = "16 16";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["isDecoy"] = "0";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiControl", "");
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["Position"] = "0 0";
            oc_Newobject16["Extent"] = "190 18";
            oc_Newobject16["MinExtent"] = "16 16";
            oc_Newobject16["Visible"] = "1";

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "0 0";
            oc_Newobject14["Extent"] = "90 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["text"] = "Snap Size:";
            oc_Newobject14["maxLength"] = "1024";

            #endregion

            oc_Newobject16["#Newobject14"] = oc_Newobject14;

            #region GuiTextEditCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject15["internalName"] = "SnapSize";
            oc_Newobject15["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject15["HorizSizing"] = "left";
            oc_Newobject15["position"] = "136 0";
            oc_Newobject15["Extent"] = "44 18";
            oc_Newobject15["text"] = "2.0";
            oc_Newobject15["maxLength"] = "6";
            oc_Newobject15["AltCommand"] = "ESnapOptions.setSoftSnapSize();";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject32["#Newobject16"] = oc_Newobject16;

            #region GuiControl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "");
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["Position"] = "0 0";
            oc_Newobject26["Extent"] = "190 90";
            oc_Newobject26["MinExtent"] = "16 16";
            oc_Newobject26["Visible"] = "1";

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["internalName"] = "SoftSnapAlignment";
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["Position"] = "0 0";
            oc_Newobject25["Extent"] = "190 90";
            oc_Newobject25["MinExtent"] = "16 16";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["isDecoy"] = "0";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["colCount"] = "2";
            oc_Newobject25["colSize"] = "78";
            oc_Newobject25["rowSize"] = "20";
            oc_Newobject25["rowSpacing"] = "2";
            oc_Newobject25["colSpacing"] = "2";

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "0 0";
            oc_Newobject17["Extent"] = "190 18";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["text"] = "  Alignment:";
            oc_Newobject17["maxLength"] = "1024";

            #endregion

            oc_Newobject25["#Newobject17"] = oc_Newobject17;

            #region GuiRadioCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiRadioCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["internalName"] = "NoAlignment";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiRadioProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "0 0";
            oc_Newobject18["Extent"] = "40 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["isDecoy"] = "0";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"None\\\");";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["text"] = "None";
            oc_Newobject18["groupNum"] = "1";
            oc_Newobject18["buttonType"] = "RadioButton";
            oc_Newobject18["useMouseEvents"] = "0";
            oc_Newobject18["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject18"] = oc_Newobject18;

            #region GuiIconButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["internalName"] = "negX";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "0 0";
            oc_Newobject19["Extent"] = "40 20";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["isDecoy"] = "0";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"-X\\\");";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["text"] = "- X Axis";
            oc_Newobject19["iconBitmap"] = "tools/gui/images/axis-icon_-x";
            oc_Newobject19["textMargin"] = "24";
            oc_Newobject19["groupNum"] = "1";
            oc_Newobject19["buttonType"] = "RadioButton";
            oc_Newobject19["useMouseEvents"] = "0";
            oc_Newobject19["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject19"] = oc_Newobject19;

            #region GuiIconButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["internalName"] = "posX";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["Position"] = "0 0";
            oc_Newobject20["Extent"] = "40 20";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["isDecoy"] = "0";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"+X\\\");";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["text"] = "+ X Axis";
            oc_Newobject20["iconBitmap"] = "tools/gui/images/axis-icon_x";
            oc_Newobject20["textMargin"] = "24";
            oc_Newobject20["groupNum"] = "1";
            oc_Newobject20["buttonType"] = "RadioButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject20"] = oc_Newobject20;

            #region GuiIconButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["internalName"] = "negY";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["Position"] = "0 0";
            oc_Newobject21["Extent"] = "40 20";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["isDecoy"] = "0";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"-Y\\\");";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["text"] = "- Y Axis";
            oc_Newobject21["iconBitmap"] = "tools/gui/images/axis-icon_-y";
            oc_Newobject21["textMargin"] = "24";
            oc_Newobject21["groupNum"] = "1";
            oc_Newobject21["buttonType"] = "RadioButton";
            oc_Newobject21["useMouseEvents"] = "0";
            oc_Newobject21["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject21"] = oc_Newobject21;

            #region GuiIconButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["internalName"] = "posY";
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "0 0";
            oc_Newobject22["Extent"] = "40 20";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["isDecoy"] = "0";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"+Y\\\");";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["text"] = "+ Y Axis";
            oc_Newobject22["iconBitmap"] = "tools/gui/images/axis-icon_y";
            oc_Newobject22["textMargin"] = "24";
            oc_Newobject22["groupNum"] = "1";
            oc_Newobject22["buttonType"] = "RadioButton";
            oc_Newobject22["useMouseEvents"] = "0";
            oc_Newobject22["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject22"] = oc_Newobject22;

            #region GuiIconButtonCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["internalName"] = "negZ";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "0 0";
            oc_Newobject23["Extent"] = "40 20";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["isDecoy"] = "0";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"-Z\\\");";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["text"] = "- Z Axis";
            oc_Newobject23["iconBitmap"] = "tools/gui/images/axis-icon_-z";
            oc_Newobject23["textMargin"] = "24";
            oc_Newobject23["groupNum"] = "1";
            oc_Newobject23["buttonType"] = "RadioButton";
            oc_Newobject23["useMouseEvents"] = "0";
            oc_Newobject23["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject23"] = oc_Newobject23;

            #region GuiIconButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["internalName"] = "posZ";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiIconButtonSmallProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["Position"] = "0 0";
            oc_Newobject24["Extent"] = "40 20";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["isDecoy"] = "0";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["Command"] = "ESnapOptions.setSoftSnapAlignment(\\\"+Z\\\");";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["text"] = "+ Z Axis";
            oc_Newobject24["iconBitmap"] = "tools/gui/images/axis-icon_z";
            oc_Newobject24["textMargin"] = "24";
            oc_Newobject24["groupNum"] = "1";
            oc_Newobject24["buttonType"] = "RadioButton";
            oc_Newobject24["useMouseEvents"] = "0";
            oc_Newobject24["useInactiveState"] = "0";

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject32["#Newobject26"] = oc_Newobject26;

            #region GuiCheckBoxCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject27["internalName"] = "RenderSnapBounds";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject27["position"] = "1 0";
            oc_Newobject27["Extent"] = "190 18";
            oc_Newobject27["text"] = "Render Snap Bounds";
            oc_Newobject27["Command"] = "ESnapOptions.toggleRenderSnapBounds();";

            #endregion

            oc_Newobject32["#Newobject27"] = oc_Newobject27;

            #region GuiCheckBoxCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject28["internalName"] = "RenderSnappedTriangle";
            oc_Newobject28["Enabled"] = "1";
            oc_Newobject28["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject28["position"] = "1 0";
            oc_Newobject28["Extent"] = "190 18";
            oc_Newobject28["text"] = "Render Snapped Triangle";
            oc_Newobject28["Command"] = "ESnapOptions.toggleRenderSnappedTriangle();";

            #endregion

            oc_Newobject32["#Newobject28"] = oc_Newobject28;

            #region GuiControl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiControl", "");
            oc_Newobject31["Enabled"] = "1";
            oc_Newobject31["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["HorizSizing"] = "width";
            oc_Newobject31["Position"] = "0 0";
            oc_Newobject31["Extent"] = "190 18";
            oc_Newobject31["MinExtent"] = "16 16";
            oc_Newobject31["Visible"] = "1";

            #region GuiTextCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = "0 0";
            oc_Newobject29["Extent"] = "110 18";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["Margin"] = "0 0 0 0";
            oc_Newobject29["Padding"] = "0 0 0 0";
            oc_Newobject29["AnchorTop"] = "1";
            oc_Newobject29["AnchorBottom"] = "0";
            oc_Newobject29["AnchorLeft"] = "1";
            oc_Newobject29["AnchorRight"] = "0";
            oc_Newobject29["text"] = "Backface Tolerance:";
            oc_Newobject29["maxLength"] = "1024";

            #endregion

            oc_Newobject31["#Newobject29"] = oc_Newobject29;

            #region GuiTextEditCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject30["internalName"] = "SnapBackfaceTolerance";
            oc_Newobject30["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject30["HorizSizing"] = "left";
            oc_Newobject30["position"] = "136 0";
            oc_Newobject30["Extent"] = "44 18";
            oc_Newobject30["text"] = "0.5";
            oc_Newobject30["maxLength"] = "6";
            oc_Newobject30["AltCommand"] = "ESnapOptions.getSoftSnapBackfaceTolerance();";

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject32["#Newobject31"] = oc_Newobject31;

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject34["#Newobject33"] = oc_Newobject33;

            #endregion

            oc_Newobject35["#Newobject34"] = oc_Newobject34;

            #endregion

            oc_Newobject40["#Newobject35"] = oc_Newobject35;

            #region GuiCheckBoxCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject36["text"] = "Grid Snapping";
            oc_Newobject36["groupNum"] = "1";
            oc_Newobject36["useMouseEvents"] = "0";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["horizSizing"] = "right";
            oc_Newobject36["vertSizing"] = "top";
            oc_Newobject36["position"] = "4 231";
            oc_Newobject36["extent"] = "95 24";
            oc_Newobject36["minExtent"] = "8 8";
            oc_Newobject36["visible"] = "1";
            oc_Newobject36["active"] = "1";
            oc_Newobject36["command"] = "toggleSnappingOptions(\\\"grid\\\");";
            oc_Newobject36["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["internalName"] = "GridSnapButton";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject40["#Newobject36"] = oc_Newobject36;

            #region GuiTextCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject37["text"] = "Size";
            oc_Newobject37["maxLength"] = "1024";
            oc_Newobject37["margin"] = "0 0 0 0";
            oc_Newobject37["padding"] = "0 0 0 0";
            oc_Newobject37["anchorTop"] = "1";
            oc_Newobject37["anchorBottom"] = "0";
            oc_Newobject37["anchorLeft"] = "1";
            oc_Newobject37["anchorRight"] = "0";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject37["horizSizing"] = "left";
            oc_Newobject37["vertSizing"] = "top";
            oc_Newobject37["position"] = "103 234";
            oc_Newobject37["extent"] = "25 18";
            oc_Newobject37["minExtent"] = "8 2";
            oc_Newobject37["visible"] = "1";
            oc_Newobject37["active"] = "1";
            oc_Newobject37["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject40["#Newobject37"] = oc_Newobject37;

            #region GuiTextEditCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject38["historySize"] = "0";
            oc_Newobject38["password"] = "0";
            oc_Newobject38["tabComplete"] = "0";
            oc_Newobject38["sinkAllKeyEvents"] = "0";
            oc_Newobject38["passwordMask"] = "�";
            oc_Newobject38["text"] = "2.0";
            oc_Newobject38["maxLength"] = "6";
            oc_Newobject38["margin"] = "0 0 0 0";
            oc_Newobject38["padding"] = "0 0 0 0";
            oc_Newobject38["anchorTop"] = "1";
            oc_Newobject38["anchorBottom"] = "0";
            oc_Newobject38["anchorLeft"] = "1";
            oc_Newobject38["anchorRight"] = "0";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject38["horizSizing"] = "left";
            oc_Newobject38["vertSizing"] = "top";
            oc_Newobject38["position"] = "127 235";
            oc_Newobject38["extent"] = "44 18";
            oc_Newobject38["minExtent"] = "8 2";
            oc_Newobject38["visible"] = "1";
            oc_Newobject38["active"] = "1";
            oc_Newobject38["altCommand"] = "ESnapOptions.setGridSnapSize();";
            oc_Newobject38["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["internalName"] = "gridSize";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject40["#Newobject38"] = oc_Newobject38;

            #region GuiButtonCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject39["internalName"] = "NoSnapButton";
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["Enabled"] = "1";
            oc_Newobject39["isContainer"] = "0";
            oc_Newobject39["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject39["HorizSizing"] = "left";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["Position"] = "133 23";
            oc_Newobject39["Extent"] = "38 18";
            oc_Newobject39["MinExtent"] = "8 8";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["Visible"] = "1";
            oc_Newobject39["Command"] = "toggleSnappingOptions(\\\"\\\");";
            oc_Newobject39["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["text"] = "Off";
            oc_Newobject39["groupNum"] = "1";
            oc_Newobject39["buttonType"] = "ToggleButton";
            oc_Newobject39["useMouseEvents"] = "0";

            #endregion

            oc_Newobject40["#Newobject39"] = oc_Newobject39;

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject41.Create();
            }
        }
    }