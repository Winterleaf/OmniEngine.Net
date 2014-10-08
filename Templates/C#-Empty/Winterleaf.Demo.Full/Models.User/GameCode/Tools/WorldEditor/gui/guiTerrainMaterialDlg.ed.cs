using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class guiTerrainMaterialDlg
        {
        [ConsoleInteraction(true, "guiTerrainMaterialDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (TerrainMaterialDlg, EditorGuiGroup)        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiControl", "TerrainMaterialDlg, EditorGuiGroup",
                typeof (TerrainMaterialDlg));
            oc_Newobject66["canSaveDynamicFields"] = "0";
            oc_Newobject66["isContainer"] = "1";
            oc_Newobject66["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject66["HorizSizing"] = "right";
            oc_Newobject66["VertSizing"] = "bottom";
            oc_Newobject66["position"] = "0 0";
            oc_Newobject66["Extent"] = "800 768";
            oc_Newobject66["MinExtent"] = "8 2";
            oc_Newobject66["canSave"] = "1";
            oc_Newobject66["Visible"] = "1";
            oc_Newobject66["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject66["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject65["canSaveDynamicFields"] = "0";
            oc_Newobject65["isContainer"] = "1";
            oc_Newobject65["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject65["HorizSizing"] = "center";
            oc_Newobject65["VertSizing"] = "center";
            oc_Newobject65["position"] = "221 151";
            oc_Newobject65["Extent"] = "394 464";
            oc_Newobject65["MinExtent"] = "358 432";
            oc_Newobject65["canSave"] = "1";
            oc_Newobject65["Visible"] = "1";
            oc_Newobject65["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject65["hovertime"] = "1000";
            oc_Newobject65["Docking"] = "None";
            oc_Newobject65["Margin"] = "4 4 4 4";
            oc_Newobject65["Padding"] = "0 0 0 0";
            oc_Newobject65["AnchorTop"] = "0";
            oc_Newobject65["AnchorBottom"] = "0";
            oc_Newobject65["AnchorLeft"] = "0";
            oc_Newobject65["AnchorRight"] = "0";
            oc_Newobject65["resizeWidth"] = "1";
            oc_Newobject65["resizeHeight"] = "1";
            oc_Newobject65["canMove"] = "1";
            oc_Newobject65["canClose"] = "1";
            oc_Newobject65["canMinimize"] = "0";
            oc_Newobject65["canMaximize"] = "0";
            oc_Newobject65["minSize"] = "50 50";
            oc_Newobject65["closeCommand"] = "TerrainMaterialDlg.dialogCancel();";
            oc_Newobject65["EdgeSnap"] = "0";
            oc_Newobject65["text"] = "Terrain Materials Editor";

            #region GuiContainer ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiContainer", "");
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "6 25";
            oc_Newobject4["Extent"] = "189 64";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "5 0";
            oc_Newobject1["Extent"] = "91 18";
            oc_Newobject1["text"] = "Terrain Materials";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "top";
            oc_Newobject2["position"] = "160 2";
            oc_Newobject2["Extent"] = "15 15";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "TerrainMaterialDlg.newMat();";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["bitmap"] = "tools/gui/images/new";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "left";
            oc_Newobject3["VertSizing"] = "top";
            oc_Newobject3["position"] = "173 2";
            oc_Newobject3["Extent"] = "15 15";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "TerrainMaterialDlg.deleteMat();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl (TerrainTreeFilter)        oc_Newobject100

            ObjectCreator oc_Newobject100 = new ObjectCreator("GuiTextEditCtrl", "TerrainTreeFilter", typeof(treeViewFilterCtrls.GuiTreeViewFilterText));
            oc_Newobject100["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject100["HorizSizing"] = "width";
            oc_Newobject100["VertSizing"] = "bottom";
            oc_Newobject100["Position"] = "1 19";
            oc_Newobject100["Extent"] = "160 18";
            oc_Newobject100["treeView"] = new ObjectCreator.StringNoQuote("TerrainMaterialTreeView");

            #endregion

            oc_Newobject4["#Newobject100"] = oc_Newobject100;

            #region GuiBitmapButtonCtrl ()        oc_Newobject101

            ObjectCreator oc_Newobject101 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof(treeViewFilterCtrls.GuiTreeViewFilterClearButton));
            oc_Newobject101["canSaveDynamicFields"] = "0";
            oc_Newobject101["isContainer"] = "0";
            oc_Newobject101["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject101["HorizSizing"] = "left";
            oc_Newobject101["VertSizing"] = "bottom";
            oc_Newobject101["position"] = "168 21";
            oc_Newobject101["Extent"] = "17 17";
            oc_Newobject101["MinExtent"] = "8 2";
            oc_Newobject101["canSave"] = "1";
            oc_Newobject101["Visible"] = "1";
            oc_Newobject101["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject101["hovertime"] = "1000";
            oc_Newobject101["groupNum"] = "-1";
            oc_Newobject101["buttonType"] = "PushButton";
            oc_Newobject101["useMouseEvents"] = "0";
            oc_Newobject101["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject101["textCtrl"] = new ObjectCreator.StringNoQuote("TerrainTreeFilter");

            #endregion

            oc_Newobject4["#Newobject101"] = oc_Newobject101;

            #endregion

            oc_Newobject65["#Newobject4"] = oc_Newobject4;

            #region GuiContainer ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiContainer", "");
            oc_Newobject57["canSaveDynamicFields"] = "0";
            oc_Newobject57["internalName"] = "matSettingsParent";
            oc_Newobject57["isContainer"] = "1";
            oc_Newobject57["Profile"] = "inspectorStyleRolloutProfile";
            oc_Newobject57["HorizSizing"] = "left";
            oc_Newobject57["VertSizing"] = "height";
            oc_Newobject57["position"] = "202 26";
            oc_Newobject57["Extent"] = "185 390";
            oc_Newobject57["MinExtent"] = "8 2";
            oc_Newobject57["canSave"] = "1";
            oc_Newobject57["Visible"] = "1";
            oc_Newobject57["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject57["hovertime"] = "1000";
            oc_Newobject57["Margin"] = "0 0 0 0";
            oc_Newobject57["Padding"] = "0 0 0 0";
            oc_Newobject57["AnchorTop"] = "1";
            oc_Newobject57["AnchorBottom"] = "0";
            oc_Newobject57["AnchorLeft"] = "1";
            oc_Newobject57["AnchorRight"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "1 0";
            oc_Newobject5["Extent"] = "183 2";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "core/art/gui/images/separator-v";
            oc_Newobject5["wrap"] = "0";

            #endregion

            oc_Newobject57["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "8 22";
            oc_Newobject6["Extent"] = "44 17";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Name";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject57["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["internalName"] = "matNameCtrl";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "39 21";
            oc_Newobject7["Extent"] = "143 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";
            oc_Newobject7["passwordMask"] = "*";
            oc_Newobject7["altCommand"] = "TerrainMaterialDlg.setMaterialName( $ThisControl.getText() );";

            #endregion

            oc_Newobject57["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiInspectorTitleTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "8 0";
            oc_Newobject8["Extent"] = "117 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "Material Properties";
            oc_Newobject8["maxLength"] = "1024";

            #endregion

            oc_Newobject57["#Newobject8"] = oc_Newobject8;

            #region GuiContainer ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiContainer", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["HorizSizing"] = "width";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "6 43";
            oc_Newobject18["Extent"] = "185 75";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";

            #region GuiCheckBoxCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject9["internalName"] = "sideProjectionCtrl";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "55 54";
            oc_Newobject9["Extent"] = "119 16";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["text"] = " Use Side Projection";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "ToggleButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["useInactiveState"] = "0";

            #endregion

            oc_Newobject18["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject10["internalName"] = "baseTexCtrl";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "1 1";
            oc_Newobject10["Extent"] = "47 47";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject10["wrap"] = "0";

            #endregion

            oc_Newobject18["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "1 1";
            oc_Newobject11["Extent"] = "48 48";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "TerrainMaterialDlg.changeBase();";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["ToolTip"] = "Change the Active Diffuse Map for this layer";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject18["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "EditorTextProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "56 -3";
            oc_Newobject12["Extent"] = "39 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["text"] = "Diffuse";
            oc_Newobject12["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject12"] = oc_Newobject12;

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "56 16";
            oc_Newobject13["Extent"] = "116 17";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["text"] = "None";
            oc_Newobject13["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject13"] = oc_Newobject13;

            #region GuiButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject14["HorizSizing"] = "left";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "116 0";
            oc_Newobject14["Extent"] = "40 16";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["Command"] = "TerrainMaterialDlg.changeBase();";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["text"] = "Edit";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";

            #endregion

            oc_Newobject18["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["HorizSizing"] = "left";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "159 0";
            oc_Newobject15["Extent"] = "16 16";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["Command"] =
                "TerrainMaterialDlg-->baseTexCtrl.setBitmap(\\\"tools/materialeditor/gui/unknownImage\\\");";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject18["#Newobject15"] = oc_Newobject15;

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "132 35";
            oc_Newobject16["Extent"] = "39 16";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "0";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "0";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "Size";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject17["internalName"] = "baseSizeCtrl";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "94 34";
            oc_Newobject17["Extent"] = "34 18";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "0";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "0";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["historySize"] = "0";
            oc_Newobject17["password"] = "0";
            oc_Newobject17["tabComplete"] = "0";
            oc_Newobject17["sinkAllKeyEvents"] = "0";
            oc_Newobject17["passwordMask"] = "*";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject57["#Newobject18"] = oc_Newobject18;

            #region GuiBitmapCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "6 116";
            oc_Newobject19["Extent"] = "175 2";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["bitmap"] = "tools/gui/images/separator-v";
            oc_Newobject19["wrap"] = "0";

            #endregion

            oc_Newobject57["#Newobject19"] = oc_Newobject19;

            #region GuiContainer ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiContainer", "");
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["isContainer"] = "1";
            oc_Newobject28["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject28["HorizSizing"] = "width";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["position"] = "6 295";
            oc_Newobject28["Extent"] = "185 50";
            oc_Newobject28["MinExtent"] = "8 2";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["Margin"] = "0 0 0 0";
            oc_Newobject28["Padding"] = "0 0 0 0";
            oc_Newobject28["AnchorTop"] = "1";
            oc_Newobject28["AnchorBottom"] = "0";
            oc_Newobject28["AnchorLeft"] = "1";
            oc_Newobject28["AnchorRight"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject20["internalName"] = "normTexCtrl";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "1 1";
            oc_Newobject20["Extent"] = "47 47";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject20["wrap"] = "0";

            #endregion

            oc_Newobject28["#Newobject20"] = oc_Newobject20;

            #region GuiTextCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "EditorTextProfile";
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "56 -3";
            oc_Newobject21["Extent"] = "39 18";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["text"] = "Normal";
            oc_Newobject21["maxLength"] = "1024";

            #endregion

            oc_Newobject28["#Newobject21"] = oc_Newobject21;

            #region GuiBitmapButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "1 1";
            oc_Newobject22["Extent"] = "48 48";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["Command"] = "TerrainMaterialDlg.changeNormal();";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["ToolTip"] = "Change the active Normal Map for this layer.";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["buttonType"] = "PushButton";
            oc_Newobject22["useMouseEvents"] = "0";
            oc_Newobject22["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject28["#Newobject22"] = oc_Newobject22;

            #region GuiTextCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "56 15";
            oc_Newobject23["Extent"] = "116 17";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["Margin"] = "0 0 0 0";
            oc_Newobject23["Padding"] = "0 0 0 0";
            oc_Newobject23["AnchorTop"] = "1";
            oc_Newobject23["AnchorBottom"] = "0";
            oc_Newobject23["AnchorLeft"] = "1";
            oc_Newobject23["AnchorRight"] = "0";
            oc_Newobject23["text"] = "None";
            oc_Newobject23["maxLength"] = "1024";

            #endregion

            oc_Newobject28["#Newobject23"] = oc_Newobject23;

            #region GuiButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject24["HorizSizing"] = "left";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "116 0";
            oc_Newobject24["Extent"] = "40 16";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["Command"] = "TerrainMaterialDlg.changeNormal();";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["text"] = "Edit";
            oc_Newobject24["groupNum"] = "-1";
            oc_Newobject24["buttonType"] = "PushButton";
            oc_Newobject24["useMouseEvents"] = "0";

            #endregion

            oc_Newobject28["#Newobject24"] = oc_Newobject24;

            #region GuiBitmapButtonCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["HorizSizing"] = "left";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = "159 0";
            oc_Newobject25["Extent"] = "16 16";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["Command"] =
                "TerrainMaterialDlg-->normTexCtrl.setBitmap(\\\"tools/materialeditor/gui/unknownImage\\\");";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["groupNum"] = "-1";
            oc_Newobject25["buttonType"] = "PushButton";
            oc_Newobject25["useMouseEvents"] = "0";
            oc_Newobject25["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject28["#Newobject25"] = oc_Newobject25;

            #region GuiTextCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["position"] = "92 34";
            oc_Newobject26["Extent"] = "77 16";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["Margin"] = "0 0 0 0";
            oc_Newobject26["Padding"] = "0 0 0 0";
            oc_Newobject26["AnchorTop"] = "1";
            oc_Newobject26["AnchorBottom"] = "0";
            oc_Newobject26["AnchorLeft"] = "1";
            oc_Newobject26["AnchorRight"] = "0";
            oc_Newobject26["text"] = "Parallax Scale";
            oc_Newobject26["maxLength"] = "1024";

            #endregion

            oc_Newobject28["#Newobject26"] = oc_Newobject26;

            #region GuiTextEditCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject27["internalName"] = "parallaxScaleCtrl";
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = "55 33";
            oc_Newobject27["Extent"] = "34 18";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["Margin"] = "0 0 0 0";
            oc_Newobject27["Padding"] = "0 0 0 0";
            oc_Newobject27["AnchorTop"] = "0";
            oc_Newobject27["AnchorBottom"] = "0";
            oc_Newobject27["AnchorLeft"] = "0";
            oc_Newobject27["AnchorRight"] = "0";
            oc_Newobject27["text"] = "0.00";
            oc_Newobject27["maxLength"] = "1024";
            oc_Newobject27["historySize"] = "0";
            oc_Newobject27["password"] = "0";
            oc_Newobject27["tabComplete"] = "0";
            oc_Newobject27["sinkAllKeyEvents"] = "0";
            oc_Newobject27["passwordMask"] = "*";

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject57["#Newobject28"] = oc_Newobject28;

            #region GuiBitmapCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject29["bitmap"] = "tools/gui/images/separator-v";
            oc_Newobject29["wrap"] = "0";
            oc_Newobject29["position"] = "6 288";
            oc_Newobject29["extent"] = "175 2";
            oc_Newobject29["minExtent"] = "8 2";
            oc_Newobject29["horizSizing"] = "width";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["active"] = "1";
            oc_Newobject29["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject57["#Newobject29"] = oc_Newobject29;

            #region GuiContainer ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiContainer", "");
            oc_Newobject42["margin"] = "0 0 0 0";
            oc_Newobject42["padding"] = "0 0 0 0";
            oc_Newobject42["anchorTop"] = "1";
            oc_Newobject42["anchorBottom"] = "0";
            oc_Newobject42["anchorLeft"] = "1";
            oc_Newobject42["anchorRight"] = "0";
            oc_Newobject42["position"] = "6 122";
            oc_Newobject42["extent"] = "185 72";
            oc_Newobject42["minExtent"] = "8 2";
            oc_Newobject42["horizSizing"] = "width";
            oc_Newobject42["vertSizing"] = "bottom";
            oc_Newobject42["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject42["visible"] = "1";
            oc_Newobject42["active"] = "1";
            oc_Newobject42["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["canSaveDynamicFields"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject30["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject30["wrap"] = "0";
            oc_Newobject30["position"] = "1 1";
            oc_Newobject30["extent"] = "47 47";
            oc_Newobject30["minExtent"] = "8 2";
            oc_Newobject30["horizSizing"] = "right";
            oc_Newobject30["vertSizing"] = "bottom";
            oc_Newobject30["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["active"] = "1";
            oc_Newobject30["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["isContainer"] = "0";
            oc_Newobject30["internalName"] = "macroTexCtrl";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject30"] = oc_Newobject30;

            #region GuiBitmapButtonCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject31["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";
            oc_Newobject31["bitmapMode"] = "Stretched";
            oc_Newobject31["autoFitExtents"] = "0";
            oc_Newobject31["useModifiers"] = "0";
            oc_Newobject31["useStates"] = "1";
            oc_Newobject31["groupNum"] = "-1";
            oc_Newobject31["buttonType"] = "PushButton";
            oc_Newobject31["useMouseEvents"] = "0";
            oc_Newobject31["position"] = "1 1";
            oc_Newobject31["extent"] = "48 48";
            oc_Newobject31["minExtent"] = "8 2";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["active"] = "1";
            oc_Newobject31["command"] = "TerrainMaterialDlg.changeMacro();";
            oc_Newobject31["tooltipProfile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["tooltip"] = "Change the active Macro Map for this layer.";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject31"] = oc_Newobject31;

            #region GuiTextCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject32["text"] = "Macro";
            oc_Newobject32["maxLength"] = "1024";
            oc_Newobject32["margin"] = "0 0 0 0";
            oc_Newobject32["padding"] = "0 0 0 0";
            oc_Newobject32["anchorTop"] = "1";
            oc_Newobject32["anchorBottom"] = "0";
            oc_Newobject32["anchorLeft"] = "1";
            oc_Newobject32["anchorRight"] = "0";
            oc_Newobject32["position"] = "56 -3";
            oc_Newobject32["extent"] = "34 18";
            oc_Newobject32["minExtent"] = "8 2";
            oc_Newobject32["horizSizing"] = "right";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["profile"] = "EditorTextProfile";
            oc_Newobject32["visible"] = "1";
            oc_Newobject32["active"] = "1";
            oc_Newobject32["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject32"] = oc_Newobject32;

            #region GuiTextCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject33["text"] = "None";
            oc_Newobject33["maxLength"] = "1024";
            oc_Newobject33["margin"] = "0 0 0 0";
            oc_Newobject33["padding"] = "0 0 0 0";
            oc_Newobject33["anchorTop"] = "1";
            oc_Newobject33["anchorBottom"] = "0";
            oc_Newobject33["anchorLeft"] = "1";
            oc_Newobject33["anchorRight"] = "0";
            oc_Newobject33["position"] = "56 17";
            oc_Newobject33["extent"] = "116 17";
            oc_Newobject33["minExtent"] = "8 2";
            oc_Newobject33["horizSizing"] = "width";
            oc_Newobject33["vertSizing"] = "bottom";
            oc_Newobject33["profile"] = "ToolsGuiTextProfile";
            oc_Newobject33["visible"] = "1";
            oc_Newobject33["active"] = "1";
            oc_Newobject33["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject33"] = oc_Newobject33;

            #region GuiButtonCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject34["text"] = "Edit";
            oc_Newobject34["groupNum"] = "-1";
            oc_Newobject34["buttonType"] = "PushButton";
            oc_Newobject34["useMouseEvents"] = "0";
            oc_Newobject34["position"] = "116 0";
            oc_Newobject34["extent"] = "40 16";
            oc_Newobject34["minExtent"] = "8 2";
            oc_Newobject34["horizSizing"] = "left";
            oc_Newobject34["vertSizing"] = "bottom";
            oc_Newobject34["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject34["visible"] = "1";
            oc_Newobject34["active"] = "1";
            oc_Newobject34["command"] = "TerrainMaterialDlg.changeMacro();";
            oc_Newobject34["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject34"] = oc_Newobject34;

            #region GuiBitmapButtonCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject35["bitmap"] = "tools/gui/images/delete";
            oc_Newobject35["bitmapMode"] = "Stretched";
            oc_Newobject35["autoFitExtents"] = "0";
            oc_Newobject35["useModifiers"] = "0";
            oc_Newobject35["useStates"] = "1";
            oc_Newobject35["groupNum"] = "-1";
            oc_Newobject35["buttonType"] = "PushButton";
            oc_Newobject35["useMouseEvents"] = "0";
            oc_Newobject35["position"] = "159 0";
            oc_Newobject35["extent"] = "16 16";
            oc_Newobject35["minExtent"] = "8 2";
            oc_Newobject35["horizSizing"] = "left";
            oc_Newobject35["vertSizing"] = "bottom";
            oc_Newobject35["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject35["visible"] = "1";
            oc_Newobject35["active"] = "1";
            oc_Newobject35["command"] =
                "TerrainMaterialDlg-->macroTexCtrl.setBitmap(\\\"tools/materialeditor/gui/unknownImage\\\");";
            oc_Newobject35["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject35"] = oc_Newobject35;

            #region GuiTextCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject36["text"] = "Size";
            oc_Newobject36["maxLength"] = "1024";
            oc_Newobject36["margin"] = "0 0 0 0";
            oc_Newobject36["padding"] = "0 0 0 0";
            oc_Newobject36["anchorTop"] = "0";
            oc_Newobject36["anchorBottom"] = "0";
            oc_Newobject36["anchorLeft"] = "0";
            oc_Newobject36["anchorRight"] = "0";
            oc_Newobject36["position"] = "132 33";
            oc_Newobject36["extent"] = "39 16";
            oc_Newobject36["minExtent"] = "8 2";
            oc_Newobject36["horizSizing"] = "right";
            oc_Newobject36["vertSizing"] = "bottom";
            oc_Newobject36["profile"] = "ToolsGuiTextProfile";
            oc_Newobject36["visible"] = "1";
            oc_Newobject36["active"] = "1";
            oc_Newobject36["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject36"] = oc_Newobject36;

            #region GuiTextEditCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject37["historySize"] = "0";
            oc_Newobject37["tabComplete"] = "0";
            oc_Newobject37["sinkAllKeyEvents"] = "0";
            oc_Newobject37["password"] = "0";
            oc_Newobject37["passwordMask"] = "*";
            oc_Newobject37["maxLength"] = "1024";
            oc_Newobject37["margin"] = "0 0 0 0";
            oc_Newobject37["padding"] = "0 0 0 0";
            oc_Newobject37["anchorTop"] = "0";
            oc_Newobject37["anchorBottom"] = "0";
            oc_Newobject37["anchorLeft"] = "0";
            oc_Newobject37["anchorRight"] = "0";
            oc_Newobject37["position"] = "94 32";
            oc_Newobject37["extent"] = "34 18";
            oc_Newobject37["minExtent"] = "8 2";
            oc_Newobject37["horizSizing"] = "right";
            oc_Newobject37["vertSizing"] = "bottom";
            oc_Newobject37["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject37["visible"] = "1";
            oc_Newobject37["active"] = "1";
            oc_Newobject37["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["internalName"] = "macroSizeCtrl";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject37"] = oc_Newobject37;

            #region GuiTextCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject38["text"] = "Strength";
            oc_Newobject38["maxLength"] = "1024";
            oc_Newobject38["margin"] = "0 0 0 0";
            oc_Newobject38["padding"] = "0 0 0 0";
            oc_Newobject38["anchorTop"] = "0";
            oc_Newobject38["anchorBottom"] = "0";
            oc_Newobject38["anchorLeft"] = "0";
            oc_Newobject38["anchorRight"] = "0";
            oc_Newobject38["position"] = "39 54";
            oc_Newobject38["extent"] = "46 16";
            oc_Newobject38["minExtent"] = "8 2";
            oc_Newobject38["horizSizing"] = "right";
            oc_Newobject38["vertSizing"] = "bottom";
            oc_Newobject38["profile"] = "ToolsGuiTextProfile";
            oc_Newobject38["visible"] = "1";
            oc_Newobject38["active"] = "1";
            oc_Newobject38["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject38"] = oc_Newobject38;

            #region GuiTextEditCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject39["historySize"] = "0";
            oc_Newobject39["tabComplete"] = "0";
            oc_Newobject39["sinkAllKeyEvents"] = "0";
            oc_Newobject39["password"] = "0";
            oc_Newobject39["passwordMask"] = "*";
            oc_Newobject39["maxLength"] = "1024";
            oc_Newobject39["margin"] = "0 0 0 0";
            oc_Newobject39["padding"] = "0 0 0 0";
            oc_Newobject39["anchorTop"] = "0";
            oc_Newobject39["anchorBottom"] = "0";
            oc_Newobject39["anchorLeft"] = "0";
            oc_Newobject39["anchorRight"] = "0";
            oc_Newobject39["position"] = "1 53";
            oc_Newobject39["extent"] = "34 18";
            oc_Newobject39["minExtent"] = "8 2";
            oc_Newobject39["horizSizing"] = "right";
            oc_Newobject39["vertSizing"] = "bottom";
            oc_Newobject39["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject39["visible"] = "1";
            oc_Newobject39["active"] = "1";
            oc_Newobject39["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["isContainer"] = "0";
            oc_Newobject39["internalName"] = "macroStrengthCtrl";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject39"] = oc_Newobject39;

            #region GuiTextCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject40["text"] = "Distance";
            oc_Newobject40["maxLength"] = "1024";
            oc_Newobject40["margin"] = "0 0 0 0";
            oc_Newobject40["padding"] = "0 0 0 0";
            oc_Newobject40["anchorTop"] = "0";
            oc_Newobject40["anchorBottom"] = "0";
            oc_Newobject40["anchorLeft"] = "0";
            oc_Newobject40["anchorRight"] = "0";
            oc_Newobject40["position"] = "132 54";
            oc_Newobject40["extent"] = "45 16";
            oc_Newobject40["minExtent"] = "8 2";
            oc_Newobject40["horizSizing"] = "right";
            oc_Newobject40["vertSizing"] = "bottom";
            oc_Newobject40["profile"] = "ToolsGuiTextProfile";
            oc_Newobject40["visible"] = "1";
            oc_Newobject40["active"] = "1";
            oc_Newobject40["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject40"] = oc_Newobject40;

            #region GuiTextEditCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject41["historySize"] = "0";
            oc_Newobject41["tabComplete"] = "0";
            oc_Newobject41["sinkAllKeyEvents"] = "0";
            oc_Newobject41["password"] = "0";
            oc_Newobject41["passwordMask"] = "*";
            oc_Newobject41["maxLength"] = "1024";
            oc_Newobject41["margin"] = "0 0 0 0";
            oc_Newobject41["padding"] = "0 0 0 0";
            oc_Newobject41["anchorTop"] = "0";
            oc_Newobject41["anchorBottom"] = "0";
            oc_Newobject41["anchorLeft"] = "0";
            oc_Newobject41["anchorRight"] = "0";
            oc_Newobject41["position"] = "94 53";
            oc_Newobject41["extent"] = "34 18";
            oc_Newobject41["minExtent"] = "8 2";
            oc_Newobject41["horizSizing"] = "right";
            oc_Newobject41["vertSizing"] = "bottom";
            oc_Newobject41["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject41["visible"] = "1";
            oc_Newobject41["active"] = "1";
            oc_Newobject41["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["isContainer"] = "0";
            oc_Newobject41["internalName"] = "macroDistanceCtrl";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject57["#Newobject42"] = oc_Newobject42;

            #region GuiBitmapCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject43["HorizSizing"] = "width";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["position"] = "6 200";
            oc_Newobject43["Extent"] = "175 2";
            oc_Newobject43["MinExtent"] = "8 2";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["Visible"] = "1";
            oc_Newobject43["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["bitmap"] = "tools/gui/images/separator-v";
            oc_Newobject43["wrap"] = "0";

            #endregion

            oc_Newobject57["#Newobject43"] = oc_Newobject43;

            #region GuiContainer ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiContainer", "");
            oc_Newobject56["canSaveDynamicFields"] = "0";
            oc_Newobject56["isContainer"] = "1";
            oc_Newobject56["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject56["HorizSizing"] = "width";
            oc_Newobject56["VertSizing"] = "bottom";
            oc_Newobject56["position"] = "6 206";
            oc_Newobject56["Extent"] = "185 72";
            oc_Newobject56["MinExtent"] = "8 2";
            oc_Newobject56["canSave"] = "1";
            oc_Newobject56["Visible"] = "1";
            oc_Newobject56["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject56["hovertime"] = "1000";
            oc_Newobject56["Margin"] = "0 0 0 0";
            oc_Newobject56["Padding"] = "0 0 0 0";
            oc_Newobject56["AnchorTop"] = "1";
            oc_Newobject56["AnchorBottom"] = "0";
            oc_Newobject56["AnchorLeft"] = "1";
            oc_Newobject56["AnchorRight"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject44["internalName"] = "detailTexCtrl";
            oc_Newobject44["canSaveDynamicFields"] = "0";
            oc_Newobject44["isContainer"] = "0";
            oc_Newobject44["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject44["HorizSizing"] = "right";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["position"] = "1 1";
            oc_Newobject44["Extent"] = "47 47";
            oc_Newobject44["MinExtent"] = "8 2";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["Visible"] = "1";
            oc_Newobject44["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject44["wrap"] = "0";

            #endregion

            oc_Newobject56["#Newobject44"] = oc_Newobject44;

            #region GuiBitmapButtonCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["position"] = "1 1";
            oc_Newobject45["Extent"] = "48 48";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["Command"] = "TerrainMaterialDlg.changeDetail();";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject45["ToolTip"] = "Change the active Detail Map for this layer.";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["groupNum"] = "-1";
            oc_Newobject45["buttonType"] = "PushButton";
            oc_Newobject45["useMouseEvents"] = "0";
            oc_Newobject45["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject56["#Newobject45"] = oc_Newobject45;

            #region GuiTextCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject46["canSaveDynamicFields"] = "0";
            oc_Newobject46["isContainer"] = "0";
            oc_Newobject46["Profile"] = "EditorTextProfile";
            oc_Newobject46["HorizSizing"] = "right";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["position"] = "56 -3";
            oc_Newobject46["Extent"] = "30 18";
            oc_Newobject46["MinExtent"] = "8 2";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["Visible"] = "1";
            oc_Newobject46["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["Margin"] = "0 0 0 0";
            oc_Newobject46["Padding"] = "0 0 0 0";
            oc_Newobject46["AnchorTop"] = "1";
            oc_Newobject46["AnchorBottom"] = "0";
            oc_Newobject46["AnchorLeft"] = "1";
            oc_Newobject46["AnchorRight"] = "0";
            oc_Newobject46["text"] = "Detail";
            oc_Newobject46["maxLength"] = "1024";

            #endregion

            oc_Newobject56["#Newobject46"] = oc_Newobject46;

            #region GuiTextCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject47["canSaveDynamicFields"] = "0";
            oc_Newobject47["isContainer"] = "0";
            oc_Newobject47["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject47["HorizSizing"] = "width";
            oc_Newobject47["VertSizing"] = "bottom";
            oc_Newobject47["position"] = "56 16";
            oc_Newobject47["Extent"] = "116 17";
            oc_Newobject47["MinExtent"] = "8 2";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["Visible"] = "1";
            oc_Newobject47["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["Margin"] = "0 0 0 0";
            oc_Newobject47["Padding"] = "0 0 0 0";
            oc_Newobject47["AnchorTop"] = "1";
            oc_Newobject47["AnchorBottom"] = "0";
            oc_Newobject47["AnchorLeft"] = "1";
            oc_Newobject47["AnchorRight"] = "0";
            oc_Newobject47["text"] = "None";
            oc_Newobject47["maxLength"] = "1024";

            #endregion

            oc_Newobject56["#Newobject47"] = oc_Newobject47;

            #region GuiButtonCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject48["canSaveDynamicFields"] = "0";
            oc_Newobject48["isContainer"] = "0";
            oc_Newobject48["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject48["HorizSizing"] = "left";
            oc_Newobject48["VertSizing"] = "bottom";
            oc_Newobject48["position"] = "116 0";
            oc_Newobject48["Extent"] = "40 16";
            oc_Newobject48["MinExtent"] = "8 2";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["Visible"] = "1";
            oc_Newobject48["Command"] = "TerrainMaterialDlg.changeDetail();";
            oc_Newobject48["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["text"] = "Edit";
            oc_Newobject48["groupNum"] = "-1";
            oc_Newobject48["buttonType"] = "PushButton";
            oc_Newobject48["useMouseEvents"] = "0";

            #endregion

            oc_Newobject56["#Newobject48"] = oc_Newobject48;

            #region GuiBitmapButtonCtrl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject49["canSaveDynamicFields"] = "0";
            oc_Newobject49["isContainer"] = "0";
            oc_Newobject49["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject49["HorizSizing"] = "left";
            oc_Newobject49["VertSizing"] = "bottom";
            oc_Newobject49["position"] = "159 0";
            oc_Newobject49["Extent"] = "16 16";
            oc_Newobject49["MinExtent"] = "8 2";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["Visible"] = "1";
            oc_Newobject49["Command"] =
                "TerrainMaterialDlg-->detailTexCtrl.setBitmap(\\\"tools/materialeditor/gui/unknownImage\\\");";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["groupNum"] = "-1";
            oc_Newobject49["buttonType"] = "PushButton";
            oc_Newobject49["useMouseEvents"] = "0";
            oc_Newobject49["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject56["#Newobject49"] = oc_Newobject49;

            #region GuiTextCtrl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject50["canSaveDynamicFields"] = "0";
            oc_Newobject50["isContainer"] = "0";
            oc_Newobject50["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject50["HorizSizing"] = "right";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["position"] = "132 33";
            oc_Newobject50["Extent"] = "39 16";
            oc_Newobject50["MinExtent"] = "8 2";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["Visible"] = "1";
            oc_Newobject50["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["Margin"] = "0 0 0 0";
            oc_Newobject50["Padding"] = "0 0 0 0";
            oc_Newobject50["AnchorTop"] = "0";
            oc_Newobject50["AnchorBottom"] = "0";
            oc_Newobject50["AnchorLeft"] = "0";
            oc_Newobject50["AnchorRight"] = "0";
            oc_Newobject50["text"] = "Size";
            oc_Newobject50["maxLength"] = "1024";

            #endregion

            oc_Newobject56["#Newobject50"] = oc_Newobject50;

            #region GuiTextEditCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject51["internalName"] = "detSizeCtrl";
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["isContainer"] = "0";
            oc_Newobject51["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject51["HorizSizing"] = "right";
            oc_Newobject51["VertSizing"] = "bottom";
            oc_Newobject51["position"] = "94 32";
            oc_Newobject51["Extent"] = "34 18";
            oc_Newobject51["MinExtent"] = "8 2";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["Margin"] = "0 0 0 0";
            oc_Newobject51["Padding"] = "0 0 0 0";
            oc_Newobject51["AnchorTop"] = "0";
            oc_Newobject51["AnchorBottom"] = "0";
            oc_Newobject51["AnchorLeft"] = "0";
            oc_Newobject51["AnchorRight"] = "0";
            oc_Newobject51["maxLength"] = "1024";
            oc_Newobject51["historySize"] = "0";
            oc_Newobject51["password"] = "0";
            oc_Newobject51["tabComplete"] = "0";
            oc_Newobject51["sinkAllKeyEvents"] = "0";
            oc_Newobject51["passwordMask"] = "*";

            #endregion

            oc_Newobject56["#Newobject51"] = oc_Newobject51;

            #region GuiTextCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["isContainer"] = "0";
            oc_Newobject52["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject52["HorizSizing"] = "right";
            oc_Newobject52["VertSizing"] = "bottom";
            oc_Newobject52["position"] = "39 54";
            oc_Newobject52["Extent"] = "46 16";
            oc_Newobject52["MinExtent"] = "8 2";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["Visible"] = "1";
            oc_Newobject52["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["Margin"] = "0 0 0 0";
            oc_Newobject52["Padding"] = "0 0 0 0";
            oc_Newobject52["AnchorTop"] = "0";
            oc_Newobject52["AnchorBottom"] = "0";
            oc_Newobject52["AnchorLeft"] = "0";
            oc_Newobject52["AnchorRight"] = "0";
            oc_Newobject52["text"] = "Strength";
            oc_Newobject52["maxLength"] = "1024";

            #endregion

            oc_Newobject56["#Newobject52"] = oc_Newobject52;

            #region GuiTextEditCtrl ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject53["internalName"] = "detStrengthCtrl";
            oc_Newobject53["canSaveDynamicFields"] = "0";
            oc_Newobject53["isContainer"] = "0";
            oc_Newobject53["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject53["HorizSizing"] = "right";
            oc_Newobject53["VertSizing"] = "bottom";
            oc_Newobject53["position"] = "1 53";
            oc_Newobject53["Extent"] = "34 18";
            oc_Newobject53["MinExtent"] = "8 2";
            oc_Newobject53["canSave"] = "1";
            oc_Newobject53["Visible"] = "1";
            oc_Newobject53["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject53["hovertime"] = "1000";
            oc_Newobject53["Margin"] = "0 0 0 0";
            oc_Newobject53["Padding"] = "0 0 0 0";
            oc_Newobject53["AnchorTop"] = "0";
            oc_Newobject53["AnchorBottom"] = "0";
            oc_Newobject53["AnchorLeft"] = "0";
            oc_Newobject53["AnchorRight"] = "0";
            oc_Newobject53["maxLength"] = "1024";
            oc_Newobject53["historySize"] = "0";
            oc_Newobject53["password"] = "0";
            oc_Newobject53["tabComplete"] = "0";
            oc_Newobject53["sinkAllKeyEvents"] = "0";
            oc_Newobject53["passwordMask"] = "*";

            #endregion

            oc_Newobject56["#Newobject53"] = oc_Newobject53;

            #region GuiTextCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject54["canSaveDynamicFields"] = "0";
            oc_Newobject54["isContainer"] = "0";
            oc_Newobject54["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject54["HorizSizing"] = "right";
            oc_Newobject54["VertSizing"] = "bottom";
            oc_Newobject54["position"] = "132 54";
            oc_Newobject54["Extent"] = "45 16";
            oc_Newobject54["MinExtent"] = "8 2";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["Visible"] = "1";
            oc_Newobject54["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject54["hovertime"] = "1000";
            oc_Newobject54["Margin"] = "0 0 0 0";
            oc_Newobject54["Padding"] = "0 0 0 0";
            oc_Newobject54["AnchorTop"] = "0";
            oc_Newobject54["AnchorBottom"] = "0";
            oc_Newobject54["AnchorLeft"] = "0";
            oc_Newobject54["AnchorRight"] = "0";
            oc_Newobject54["text"] = "Distance";
            oc_Newobject54["maxLength"] = "1024";

            #endregion

            oc_Newobject56["#Newobject54"] = oc_Newobject54;

            #region GuiTextEditCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject55["internalName"] = "detDistanceCtrl";
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["isContainer"] = "0";
            oc_Newobject55["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject55["HorizSizing"] = "right";
            oc_Newobject55["VertSizing"] = "bottom";
            oc_Newobject55["position"] = "94 53";
            oc_Newobject55["Extent"] = "34 18";
            oc_Newobject55["MinExtent"] = "8 2";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["Margin"] = "0 0 0 0";
            oc_Newobject55["Padding"] = "0 0 0 0";
            oc_Newobject55["AnchorTop"] = "0";
            oc_Newobject55["AnchorBottom"] = "0";
            oc_Newobject55["AnchorLeft"] = "0";
            oc_Newobject55["AnchorRight"] = "0";
            oc_Newobject55["maxLength"] = "1024";
            oc_Newobject55["historySize"] = "0";
            oc_Newobject55["password"] = "0";
            oc_Newobject55["tabComplete"] = "0";
            oc_Newobject55["sinkAllKeyEvents"] = "0";
            oc_Newobject55["passwordMask"] = "*";

            #endregion

            oc_Newobject56["#Newobject55"] = oc_Newobject55;

            #endregion

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #region GuiBitmapCtrl ()        oc_Newobject102

            ObjectCreator oc_Newobject102 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject102["canSaveDynamicFields"] = "0";
            oc_Newobject102["isContainer"] = "0";
            oc_Newobject102["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject102["HorizSizing"] = "width";
            oc_Newobject102["VertSizing"] = "bottom";
            oc_Newobject102["position"] = "6 360";
            oc_Newobject102["Extent"] = "183 2";
            oc_Newobject102["MinExtent"] = "8 2";
            oc_Newobject102["canSave"] = "1";
            oc_Newobject102["Visible"] = "1";
            oc_Newobject102["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject102["hovertime"] = "1000";
            oc_Newobject102["bitmap"] = "tools/gui/images/separator-v";
            oc_Newobject102["wrap"] = "0";

            #endregion

            oc_Newobject57["#Newobject102"] = oc_Newobject102;

            #region GuiTextCtrl ()        oc_Newobject103

            ObjectCreator oc_Newobject103 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject103["canSaveDynamicFields"] = "0";
            oc_Newobject103["isContainer"] = "0";
            oc_Newobject103["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject103["HorizSizing"] = "right";
            oc_Newobject103["VertSizing"] = "bottom";
            oc_Newobject103["position"] = "8 368";
            oc_Newobject103["Extent"] = "59 17";
            oc_Newobject103["MinExtent"] = "8 2";
            oc_Newobject103["canSave"] = "1";
            oc_Newobject103["Visible"] = "1";
            oc_Newobject103["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject103["hovertime"] = "1000";
            oc_Newobject103["Margin"] = "0 0 0 0";
            oc_Newobject103["Padding"] = "0 0 0 0";
            oc_Newobject103["AnchorTop"] = "0";
            oc_Newobject103["AnchorBottom"] = "0";
            oc_Newobject103["AnchorLeft"] = "0";
            oc_Newobject103["AnchorRight"] = "0";
            oc_Newobject103["text"] = "Folder Name";
            oc_Newobject103["maxLength"] = "1024";

            #endregion

            oc_Newobject57["#Newobject103"] = oc_Newobject103;

            #region GuiTextEditCtrl ()        oc_Newobject104

            ObjectCreator oc_Newobject104 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject104["internalName"] = "terrainFolderCtrl";
            oc_Newobject104["canSaveDynamicFields"] = "0";
            oc_Newobject104["isContainer"] = "0";
            oc_Newobject104["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject104["HorizSizing"] = "right";
            oc_Newobject104["VertSizing"] = "bottom";
            oc_Newobject104["position"] = "71 367";
            oc_Newobject104["Extent"] = "106 18";
            oc_Newobject104["MinExtent"] = "8 2";
            oc_Newobject104["canSave"] = "1";
            oc_Newobject104["Visible"] = "1";
            oc_Newobject104["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject104["hovertime"] = "1000";
            oc_Newobject104["altCommand"] = "TerrainMaterialDlg.setTerrainFolder( $ThisControl.getText() );";
            oc_Newobject104["Margin"] = "0 0 0 0";
            oc_Newobject104["Padding"] = "0 0 0 0";
            oc_Newobject104["AnchorTop"] = "0";
            oc_Newobject104["AnchorBottom"] = "0";
            oc_Newobject104["AnchorLeft"] = "0";
            oc_Newobject104["AnchorRight"] = "0";
            oc_Newobject104["maxLength"] = "1024";
            oc_Newobject104["historySize"] = "0";
            oc_Newobject104["password"] = "0";
            oc_Newobject104["tabComplete"] = "0";
            oc_Newobject104["sinkAllKeyEvents"] = "0";
            oc_Newobject104["passwordMask"] = "*";

            #endregion

            oc_Newobject57["#Newobject104"] = oc_Newobject104;

            #endregion

            oc_Newobject65["#Newobject57"] = oc_Newobject57;

            #region GuiControl ()        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiControl", "");
            oc_Newobject60["canSaveDynamicFields"] = "0";
            oc_Newobject60["isContainer"] = "1";
            oc_Newobject60["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject60["HorizSizing"] = "width";
            oc_Newobject60["VertSizing"] = "height";
            oc_Newobject60["position"] = "6 65";
            oc_Newobject60["Extent"] = "189 352";
            oc_Newobject60["MinExtent"] = "8 2";
            oc_Newobject60["canSave"] = "1";
            oc_Newobject60["Visible"] = "1";
            oc_Newobject60["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject60["hovertime"] = "1000";

            #region GuiScrollCtrl ()        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject59["canSaveDynamicFields"] = "0";
            oc_Newobject59["isContainer"] = "1";
            oc_Newobject59["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject59["HorizSizing"] = "width";
            oc_Newobject59["VertSizing"] = "height";
            oc_Newobject59["position"] = "0 0";
            oc_Newobject59["Extent"] = "189 374";
            oc_Newobject59["MinExtent"] = "8 2";
            oc_Newobject59["canSave"] = "1";
            oc_Newobject59["Visible"] = "1";
            oc_Newobject59["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject59["hovertime"] = "1000";
            oc_Newobject59["Margin"] = "0 0 0 0";
            oc_Newobject59["Padding"] = "0 0 0 0";
            oc_Newobject59["AnchorTop"] = "1";
            oc_Newobject59["AnchorBottom"] = "0";
            oc_Newobject59["AnchorLeft"] = "1";
            oc_Newobject59["AnchorRight"] = "0";
            oc_Newobject59["willFirstRespond"] = "1";
            oc_Newobject59["hScrollBar"] = "dynamic";
            oc_Newobject59["vScrollBar"] = "dynamic";
            oc_Newobject59["lockHorizScroll"] = "false";
            oc_Newobject59["lockVertScroll"] = "false";
            oc_Newobject59["constantThumbHeight"] = "0";
            oc_Newobject59["childMargin"] = "0 0";
            oc_Newobject59["mouseWheelScrollSpeed"] = "-1";

            #region GuiTreeViewCtrl (TerrainMaterialTreeView)        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiTreeViewCtrl", "TerrainMaterialTreeView", typeof(TerrainMaterialTreeCtrl));
            oc_Newobject58["internalName"] = "matLibTree";
            oc_Newobject58["canSaveDynamicFields"] = "0";
            //oc_Newobject58["class"] = "TerrainMaterialTreeCtrl";
            //oc_Newobject58["className"] = "TerrainMaterialTreeCtrl";
            oc_Newobject58["isContainer"] = "1";
            oc_Newobject58["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject58["HorizSizing"] = "right";
            oc_Newobject58["VertSizing"] = "bottom";
            oc_Newobject58["position"] = "1 1";
            oc_Newobject58["Extent"] = "125 84";
            oc_Newobject58["MinExtent"] = "8 2";
            oc_Newobject58["canSave"] = "1";
            oc_Newobject58["Visible"] = "1";
            oc_Newobject58["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject58["hovertime"] = "1000";
            oc_Newobject58["tabSize"] = "16";
            oc_Newobject58["textOffset"] = "2";
            oc_Newobject58["fullRowSelect"] = "0";
            oc_Newobject58["itemHeight"] = "21";
            oc_Newobject58["destroyTreeOnSleep"] = "1";
            oc_Newobject58["MouseDragging"] = "0";
            oc_Newobject58["MultipleSelections"] = "0";
            oc_Newobject58["DeleteObjectAllowed"] = "0";
            oc_Newobject58["DragToItemAllowed"] = "0";
            oc_Newobject58["ClearAllOnSingleSelection"] = "1";
            oc_Newobject58["showRoot"] = "0";
            oc_Newobject58["internalNamesOnly"] = "1";
            oc_Newobject58["objectNamesOnly"] = "0";

            #endregion

            oc_Newobject59["#Newobject58"] = oc_Newobject58;

            #endregion

            oc_Newobject60["#Newobject59"] = oc_Newobject59;

            #endregion

            oc_Newobject65["#Newobject60"] = oc_Newobject60;

            #region GuiButtonCtrl ()        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject61["canSaveDynamicFields"] = "0";
            oc_Newobject61["isContainer"] = "0";
            oc_Newobject61["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject61["HorizSizing"] = "left";
            oc_Newobject61["VertSizing"] = "top";
            oc_Newobject61["position"] = "202 426";
            oc_Newobject61["Extent"] = "98 22";
            oc_Newobject61["MinExtent"] = "8 2";
            oc_Newobject61["canSave"] = "1";
            oc_Newobject61["Visible"] = "1";
            oc_Newobject61["Command"] = "TerrainMaterialDlg.dialogApply();";
            oc_Newobject61["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject61["hovertime"] = "1000";
            oc_Newobject61["text"] = "Apply&Select";
            oc_Newobject61["groupNum"] = "-1";
            oc_Newobject61["buttonType"] = "PushButton";
            oc_Newobject61["useMouseEvents"] = "0";

            #endregion

            oc_Newobject65["#Newobject61"] = oc_Newobject61;

            #region GuiButtonCtrl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject62["canSaveDynamicFields"] = "0";
            oc_Newobject62["isContainer"] = "0";
            oc_Newobject62["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject62["HorizSizing"] = "left";
            oc_Newobject62["VertSizing"] = "top";
            oc_Newobject62["position"] = "307 426";
            oc_Newobject62["Extent"] = "80 22";
            oc_Newobject62["MinExtent"] = "8 2";
            oc_Newobject62["canSave"] = "1";
            oc_Newobject62["Visible"] = "1";
            oc_Newobject62["Command"] = "TerrainMaterialDlg.dialogCancel();";
            oc_Newobject62["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject62["hovertime"] = "1000";
            oc_Newobject62["text"] = "Cancel";
            oc_Newobject62["groupNum"] = "-1";
            oc_Newobject62["buttonType"] = "PushButton";
            oc_Newobject62["useMouseEvents"] = "0";

            #endregion

            oc_Newobject65["#Newobject62"] = oc_Newobject62;

            #region GuiBitmapCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject64["internalName"] = "inactiveOverlay";
            oc_Newobject64["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject64["HorizSizing"] = "left";
            oc_Newobject64["VertSizing"] = "height";
            oc_Newobject64["position"] = "199 23";
            oc_Newobject64["Extent"] = "190 267";
            oc_Newobject64["isContainer"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject64["Visible"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject64["bitmap"] = "tools/gui/images/inactive-overlay";

            #region GuiTextCtrl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject63["internalName"] = "inactiveOverlayDlg";
            oc_Newobject63["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject63["HorizSizing"] = "width";
            oc_Newobject63["VertSizing"] = "center";
            oc_Newobject63["position"] = "0 104";
            oc_Newobject63["Extent"] = "190 64";
            oc_Newobject63["text"] = "Inactive";

            #endregion

            oc_Newobject64["#Newobject63"] = oc_Newobject63;

            #endregion

            oc_Newobject65["#Newobject64"] = oc_Newobject64;

            #endregion

            oc_Newobject66["#Newobject65"] = oc_Newobject65;

            #endregion

            oc_Newobject66.Create();
            }
        }
    }