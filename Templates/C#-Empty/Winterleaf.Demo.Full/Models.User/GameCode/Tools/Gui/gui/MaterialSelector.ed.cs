using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<MaterialSelector>))]
    public class MaterialSelector : GuiWindowCtrl
        {
        

        internal string selectCallback
            {
            get { return this["selectCallback"]; }
            set { this["selectCallback"] = value; }
            }

        internal bool terrainMaterials
            {
            get { return this["terrainMaterials"].AsBool(); }
            set { this["terrainMaterials"] = value.AsString(); }
            }

        internal string returnType
            {
            get { return this["returnType"]; }
            set { this["returnType"] = value; }
            }

        internal string selectedPreviewImagePath
            {
            get { return this["selectedPreviewImagePath"]; }
            set { this["selectedPreviewImagePath"] = value; }
            }

        internal string currentFilter
            {
            get { return this["currentFilter"]; }
            set { this["currentFilter"] = value; }
            }

        internal ArrayObject currentStaticFilter
            {
            get { return this["currentStaticFilter"]; }
            set { this["currentStaticFilter"] = value; }
            }

        internal SimObject selectedMaterial
            {
            get { return this["selectedMaterial"]; }
            set { this["selectedMaterial"] = value; }
            }

        internal int currentPreviewPage
            {
            get { return this["currentPreviewPage"].AsInt(); }
            set { this["currentPreviewPage"] = value.AsString(); }
            }

        internal int staticFilterObjects
            {
            get { return this["staticFilterObjects"].AsInt(); }
            set { this["staticFilterObjects"] = value.AsString(); }
            }

        internal int totalPages
            {
            get { return this["totalPages"].AsInt(); }
            set { this["totalPages"] = value.AsString(); }
            }

        [ConsoleInteraction(true, "MaterialSelector_initialize")]
        public static void initialize()
            {
            #region GuiControl (MaterialSelectorOverlay, EditorGuiGroup)        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiControl", "MaterialSelectorOverlay, EditorGuiGroup");
            oc_Newobject42["canSaveDynamicFields"] = "0";
            oc_Newobject42["Profile"] = "GuiOverlayProfile";
            oc_Newobject42["Enabled"] = "1";
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["HorizSizing"] = "right";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["Position"] = "0 0";
            oc_Newobject42["Extent"] = "1024 768";
            oc_Newobject42["MinExtent"] = "8 2";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["hovertime"] = "1000";

            #region GuiWindowCtrl (MaterialSelector)        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiWindowCtrl", "MaterialSelector",
                typeof (MaterialSelector));
            oc_Newobject36["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject36["HorizSizing"] = "center";
            oc_Newobject36["VertSizing"] = "center";
            oc_Newobject36["resizeWidth"] = "1";
            oc_Newobject36["resizeHeight"] = "1";
            oc_Newobject36["canClose"] = "1";
            oc_Newobject36["canMinimize"] = "0";
            oc_Newobject36["canMaximize"] = "0";
            oc_Newobject36["position"] = "72 98";
            oc_Newobject36["extent"] = " 766 550";
            oc_Newobject36["MinExtent"] = "383 274";
            oc_Newobject36["text"] = "Material Selector";
            oc_Newobject36["closeCommand"] = "MaterialSelector.hideDialog();";
            oc_Newobject36["EdgeSnap"] = "0";
            oc_Newobject36["canCollapse"] = "0";
            oc_Newobject36["visible"] = "0";

            #region GuiContainer ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiContainer", "");
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "4 22";
            oc_Newobject1["Extent"] = "120 31";
            oc_Newobject1["Profile"] = "inspectorStyleRolloutDarkProfile";

            #endregion

            oc_Newobject36["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "10 23";
            oc_Newobject2["extent"] = "30 16";
            oc_Newobject2["text"] = "Filters";

            #endregion

            oc_Newobject36["#Newobject2"] = oc_Newobject2;

            #region GuiContainer ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiContainer", "");
            oc_Newobject5["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["Position"] = "4 39";
            oc_Newobject5["Extent"] = "120 507";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["isContainer"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "128 355";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Docking"] = "Client";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "alwaysOff";
            oc_Newobject4["vScrollBar"] = "dynamic";
            oc_Newobject4["lockHorizScroll"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject4["lockVertScroll"] = "false";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "0 0";
            oc_Newobject4["mouseWheelScrollSpeed"] = "-1";

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "filterArray";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "18 0";
            oc_Newobject3["Extent"] = "128 195";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["dynamicSize"] = "1";
            oc_Newobject3["rowSpacing"] = "2";
            oc_Newobject3["colSize"] = "128";
            oc_Newobject3["rowSize"] = "18";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject36["#Newobject5"] = oc_Newobject5;

            #region GuiContainer ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiContainer", "");
            oc_Newobject6["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject6["Position"] = "128 22";
            oc_Newobject6["Extent"] = "480 31";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["isContainer"] = "1";

            #endregion

            oc_Newobject36["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "133 23";
            oc_Newobject7["extent"] = "53 16";
            oc_Newobject7["text"] = "Materials";

            #endregion

            oc_Newobject36["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "left";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "594 24";
            oc_Newobject8["Extent"] = "15 15";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "MaterialSelector.createNewMaterial();";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["tooltip"] = "Create New Unmapped Material";
            oc_Newobject8["bitmap"] = "tools/gui/images/new";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";

            #endregion

            oc_Newobject36["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "578 24";
            oc_Newobject9["Extent"] = "15 15";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "MaterialSelector.showDeleteDialog();";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["tooltip"] = "Delete Material";
            oc_Newobject9["bitmap"] = "tools/gui/images/delete";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";

            #endregion

            oc_Newobject36["#Newobject9"] = oc_Newobject9;

            #region GuiContainer ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiContainer", "");
            oc_Newobject23["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["Position"] = "128 39";
            oc_Newobject23["Extent"] = "480 507";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "height";
            oc_Newobject23["isContainer"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "height";
            oc_Newobject13["Position"] = "0 0";
            oc_Newobject13["Extent"] = "480 507";
            oc_Newobject13["MinExtent"] = "8 8";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["isDecoy"] = "0";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["Docking"] = "Client";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["willFirstRespond"] = "1";
            oc_Newobject13["hScrollBar"] = "alwaysOff";
            oc_Newobject13["vScrollBar"] = "dynamic";
            oc_Newobject13["lockHorizScroll"] = "true";
            oc_Newobject13["lockVertScroll"] = "false";
            oc_Newobject13["constantThumbHeight"] = "0";
            oc_Newobject13["childMargin"] = "0 0";
            oc_Newobject13["mouseWheelScrollSpeed"] = "-1";

            #region GuiStackControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "0 0";
            oc_Newobject12["Extent"] = "128 0";
            oc_Newobject12["changeChildPosition"] = new ObjectCreator.StringNoQuote("0");
            oc_Newobject12["changeChildSizeToFit"] = new ObjectCreator.StringNoQuote("1");

            #region GuiControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "");
            oc_Newobject10["Extent"] = "0 4";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["internalName"] = "materialSelection";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "3 0";
            oc_Newobject11["Extent"] = "128 0";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["dynamicSize"] = "1";
            oc_Newobject11["autoCellSize"] = "1";
            oc_Newobject11["rowSpacing"] = "2";
            oc_Newobject11["colSpacing"] = "2";
            oc_Newobject11["margin"] = "2";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject23["#Newobject13"] = oc_Newobject13;

            #region GuiContainer ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiContainer", "");
            oc_Newobject22["internalName"] = "materialPreviewControlContainer";
            oc_Newobject22["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["Position"] = "0 0";
            oc_Newobject22["Extent"] = "480 20";
            oc_Newobject22["HorizSizing"] = "width";
            oc_Newobject22["VertSizing"] = "height";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Docking"] = "Bottom";

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "0 2";
            oc_Newobject14["extent"] = "100 16";
            oc_Newobject14["text"] = "Thumbnails per Page:";

            #endregion

            oc_Newobject22["#Newobject14"] = oc_Newobject14;

            #region GuiPopupMenuCtrlEx ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiPopupMenuCtrlEx", "");
            oc_Newobject15["internalName"] = "materialPreviewCountPopup";
            oc_Newobject15["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject15["Position"] = "104 2";
            oc_Newobject15["Extent"] = "40 18";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Command"] = "MaterialSelector.thumbnailCountUpdate();";
            oc_Newobject15["reverseTextList"] = "0";
            oc_Newobject15["Text"] = "16";

            #endregion

            oc_Newobject22["#Newobject15"] = oc_Newobject15;

            #region GuiStackControl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject21["internalName"] = "materialPreviewButtonStack";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["Position"] = "480 2";
            oc_Newobject21["Extent"] = "0 16";
            oc_Newobject21["dynamic"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject21["dynamicPos"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject21["stackingType"] = "Horizontal";
            oc_Newobject21["changeChildPosition"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject21["changeChildSizeToFit"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject21["padding"] = new ObjectCreator.StringNoQuote("2");

            #region GuiButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "0 0";
            oc_Newobject16["Extent"] = "20 16";
            oc_Newobject16["MinExtent"] = "8 8";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["isDecoy"] = "0";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["Command"] = "MaterialSelector.firstPage();";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["tooltip"] = "First";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["text"] = "|<";
            oc_Newobject16["groupNum"] = "-1";
            oc_Newobject16["buttonType"] = "PushButton";
            oc_Newobject16["useMouseEvents"] = "1";

            #endregion

            oc_Newobject21["#Newobject16"] = oc_Newobject16;

            #region GuiButtonCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "0 0";
            oc_Newobject17["Extent"] = "20 16";
            oc_Newobject17["MinExtent"] = "8 8";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["isDecoy"] = "0";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["Command"] = "MaterialSelector.previousPage();";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["tooltip"] = "Previous";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["text"] = "<";
            oc_Newobject17["groupNum"] = "-1";
            oc_Newobject17["buttonType"] = "PushButton";
            oc_Newobject17["useMouseEvents"] = "1";

            #endregion

            oc_Newobject21["#Newobject17"] = oc_Newobject17;

            #region GuiStackControl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject18["internalName"] = "materialPreviewPagesStack";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "0 0";
            oc_Newobject18["Extent"] = "0 16";
            oc_Newobject18["dynamic"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject18["stackingType"] = "Horizontal";
            oc_Newobject18["changeChildPosition"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject18["changeChildSizeToFit"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject18["padding"] = new ObjectCreator.StringNoQuote("2");

            #endregion

            oc_Newobject21["#Newobject18"] = oc_Newobject18;

            #region GuiButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "0 0";
            oc_Newobject19["Extent"] = "20 16";
            oc_Newobject19["MinExtent"] = "8 8";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["isDecoy"] = "0";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["Command"] = "MaterialSelector.nextPage();";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["tooltip"] = "Next";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["text"] = ">";
            oc_Newobject19["groupNum"] = "-1";
            oc_Newobject19["buttonType"] = "PushButton";
            oc_Newobject19["useMouseEvents"] = "1";

            #endregion

            oc_Newobject21["#Newobject19"] = oc_Newobject19;

            #region GuiButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["Position"] = "0 0";
            oc_Newobject20["Extent"] = "20 16";
            oc_Newobject20["MinExtent"] = "8 8";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["isDecoy"] = "0";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["Command"] = "MaterialSelector.lastPage();";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["tooltip"] = "Last";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["text"] = ">|";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "PushButton";
            oc_Newobject20["useMouseEvents"] = "1";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject36["#Newobject23"] = oc_Newobject23;

            #region GuiContainer ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiContainer", "");
            oc_Newobject24["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject24["Position"] = "612 206";
            oc_Newobject24["Extent"] = "150 31";
            oc_Newobject24["HorizSizing"] = "left";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["isContainer"] = "1";

            #endregion

            oc_Newobject36["#Newobject24"] = oc_Newobject24;

            #region GuiTextCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject25["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["HorizSizing"] = "left";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = "618 207";
            oc_Newobject25["extent"] = "84 16";
            oc_Newobject25["text"] = "Material Tags";

            #endregion

            oc_Newobject36["#Newobject25"] = oc_Newobject25;

            #region GuiContainer ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiContainer", "");
            oc_Newobject28["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject28["Position"] = "612 223";
            oc_Newobject28["Extent"] = "150 295";
            oc_Newobject28["HorizSizing"] = "left";
            oc_Newobject28["VertSizing"] = "height";
            oc_Newobject28["isContainer"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "1";
            oc_Newobject27["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject27["HorizSizing"] = "width";
            oc_Newobject27["VertSizing"] = "height";
            oc_Newobject27["Position"] = "0 0";
            oc_Newobject27["Extent"] = "128 195";
            oc_Newobject27["MinExtent"] = "8 8";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["isDecoy"] = "0";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["Docking"] = "Client";
            oc_Newobject27["Margin"] = "0 0 0 0";
            oc_Newobject27["Padding"] = "0 0 0 0";
            oc_Newobject27["AnchorTop"] = "1";
            oc_Newobject27["AnchorBottom"] = "0";
            oc_Newobject27["AnchorLeft"] = "1";
            oc_Newobject27["AnchorRight"] = "0";
            oc_Newobject27["willFirstRespond"] = "1";
            oc_Newobject27["hScrollBar"] = "alwaysOff";
            oc_Newobject27["vScrollBar"] = "dynamic";
            oc_Newobject27["lockHorizScroll"] = "true";
            oc_Newobject27["lockVertScroll"] = "false";
            oc_Newobject27["constantThumbHeight"] = "0";
            oc_Newobject27["childMargin"] = "0 0";
            oc_Newobject27["mouseWheelScrollSpeed"] = "-1";

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["internalName"] = "materialCategories";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["HorizSizing"] = "width";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "0 0";
            oc_Newobject26["Extent"] = "128 195";
            oc_Newobject26["MinExtent"] = "8 8";
            oc_Newobject26["dynamicSize"] = "1";
            oc_Newobject26["rowSpacing"] = "2";
            oc_Newobject26["colSize"] = "128";
            oc_Newobject26["rowSize"] = "18";

            #endregion

            oc_Newobject27["#Newobject26"] = oc_Newobject26;

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject36["#Newobject28"] = oc_Newobject28;

            #region GuiContainer ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiContainer", "");
            oc_Newobject30["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject30["Position"] = "612 22";
            oc_Newobject30["Extent"] = "150 167";
            oc_Newobject30["HorizSizing"] = "left";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["isContainer"] = "1";

            #region GuiBitmapCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject29["internalName"] = "previewSelection";
            oc_Newobject29["HorizSizing"] = "left";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["position"] = "1 18";
            oc_Newobject29["extent"] = "148 148";
            oc_Newobject29["bitmap"] = "";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject36["#Newobject30"] = oc_Newobject30;

            #region GuiTextCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject31["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["HorizSizing"] = "left";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = "618 23";
            oc_Newobject31["extent"] = "84 16";
            oc_Newobject31["text"] = "Diffuse Preview";

            #endregion

            oc_Newobject36["#Newobject31"] = oc_Newobject31;

            #region GuiBitmapCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject32["HorizSizing"] = "left";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject32["position"] = "612 39";
            oc_Newobject32["extent"] = "150 150";
            oc_Newobject32["bitmap"] = "tools/worldEditor/images/terrainpainter/terrain-painter-border-large";
            oc_Newobject32["visible"] = new ObjectCreator.StringNoQuote("false");

            #endregion

            oc_Newobject36["#Newobject32"] = oc_Newobject32;

            #region GuiTextCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject33["internalName"] = "previewSelectionText";
            oc_Newobject33["HorizSizing"] = "left";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["profile"] = "ToolsGuiTextProfile";
            oc_Newobject33["position"] = "613 189";
            oc_Newobject33["extent"] = "149 16";
            oc_Newobject33["text"] = "";

            #endregion

            oc_Newobject36["#Newobject33"] = oc_Newobject33;

            #region GuiButtonCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject34["internalName"] = "SelectButton";
            oc_Newobject34["HorizSizing"] = "left";
            oc_Newobject34["VertSizing"] = "top";
            oc_Newobject34["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject34["position"] = "612 522";
            oc_Newobject34["extent"] = "94 24";
            oc_Newobject34["text"] = "Select";
            oc_Newobject34["command"] = "MaterialSelector.selectMaterial( MaterialSelector.selectedMaterial );";

            #endregion

            oc_Newobject36["#Newobject34"] = oc_Newobject34;

            #region GuiButtonCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject35["HorizSizing"] = "left";
            oc_Newobject35["VertSizing"] = "top";
            oc_Newobject35["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject35["position"] = "710 522";
            oc_Newobject35["extent"] = "52 24";
            oc_Newobject35["text"] = "Cancel";
            oc_Newobject35["command"] = "MaterialSelector.hideDialog();";

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject42["#Newobject36"] = oc_Newobject36;

            #region GuiWindowCtrl (MaterialSelector_addFilterWindow)        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiWindowCtrl", "MaterialSelector_addFilterWindow");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject41["HorizSizing"] = "center";
            oc_Newobject41["VertSizing"] = "center";
            oc_Newobject41["position"] = "362 333";
            oc_Newobject41["Extent"] = "272 99";
            oc_Newobject41["MinExtent"] = "48 92";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "0";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["Margin"] = "0 0 0 0";
            oc_Newobject41["Padding"] = "0 0 0 0";
            oc_Newobject41["AnchorTop"] = "1";
            oc_Newobject41["AnchorBottom"] = "0";
            oc_Newobject41["AnchorLeft"] = "1";
            oc_Newobject41["AnchorRight"] = "0";
            oc_Newobject41["resizeWidth"] = "1";
            oc_Newobject41["resizeHeight"] = "1";
            oc_Newobject41["canMove"] = "1";
            oc_Newobject41["canClose"] = "0";
            oc_Newobject41["canMinimize"] = "0";
            oc_Newobject41["canMaximize"] = "0";
            oc_Newobject41["minSize"] = "50 50";
            oc_Newobject41["EdgeSnap"] = "1";
            oc_Newobject41["text"] = "Create New Tag";

            #region GuiTextEditCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["internalName"] = "tagName";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject37["HorizSizing"] = "right";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["position"] = "64 35";
            oc_Newobject37["Extent"] = "196 18";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["Margin"] = "0 0 0 0";
            oc_Newobject37["Padding"] = "0 0 0 0";
            oc_Newobject37["AnchorTop"] = "1";
            oc_Newobject37["AnchorBottom"] = "0";
            oc_Newobject37["AnchorLeft"] = "1";
            oc_Newobject37["AnchorRight"] = "0";
            oc_Newobject37["maxLength"] = "1024";
            oc_Newobject37["historySize"] = "0";
            oc_Newobject37["password"] = "0";
            oc_Newobject37["tabComplete"] = "0";
            oc_Newobject37["sinkAllKeyEvents"] = "0";
            oc_Newobject37["passwordMask"] = "*";

            #endregion

            oc_Newobject41["#Newobject37"] = oc_Newobject37;

            #region GuiTextCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject38["HorizSizing"] = "right";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["position"] = "12 35";
            oc_Newobject38["Extent"] = "52 16";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["Margin"] = "0 0 0 0";
            oc_Newobject38["Padding"] = "0 0 0 0";
            oc_Newobject38["AnchorTop"] = "1";
            oc_Newobject38["AnchorBottom"] = "0";
            oc_Newobject38["AnchorLeft"] = "1";
            oc_Newobject38["AnchorRight"] = "0";
            oc_Newobject38["maxLength"] = "1024";
            oc_Newobject38["text"] = "Tag Name";

            #endregion

            oc_Newobject41["#Newobject38"] = oc_Newobject38;

            #region GuiButtonCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["isContainer"] = "0";
            oc_Newobject39["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject39["HorizSizing"] = "right";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["position"] = "64 68";
            oc_Newobject39["Extent"] = "126 22";
            oc_Newobject39["MinExtent"] = "8 2";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["Visible"] = "1";
            oc_Newobject39["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["groupNum"] = "-1";
            oc_Newobject39["buttonType"] = "PushButton";
            oc_Newobject39["useMouseEvents"] = "0";
            oc_Newobject39["text"] = "Create";
            oc_Newobject39["Command"] =
                "MaterialSelector.createFilter( MaterialSelector_addFilterWindow-->tagName.getText() );MaterialSelector_addFilterWindow.setVisible(0);";

            #endregion

            oc_Newobject41["#Newobject39"] = oc_Newobject39;

            #region GuiButtonCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject40["HorizSizing"] = "right";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["position"] = "196 68";
            oc_Newobject40["Extent"] = "64 22";
            oc_Newobject40["MinExtent"] = "8 2";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["groupNum"] = "-1";
            oc_Newobject40["buttonType"] = "PushButton";
            oc_Newobject40["useMouseEvents"] = "0";
            oc_Newobject40["text"] = "Cancel";
            oc_Newobject40["Command"] = "MaterialSelector_addFilterWindow.setVisible(0);";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject42.Create();

            omni.sGlobal["$Pref::MaterialSelector::CurrentStaticFilter"] = "MaterialFilterAllArray";
            omni.sGlobal["$Pref::MaterialSelector::CurrentFilter"] = ""; //ALL
            omni.iGlobal["$Pref::MaterialSelector::ThumbnailCountIndex"] = 0;

            new ObjectCreator("PersistenceManager", "MaterialSelectorPerMan").Create();

            Material WarningMaterial = "WarningMaterial";
            Material materialEd_previewMaterial = "materialEd_previewMaterial";
            Material notDirtyMaterial = "notDirtyMaterial";
            Material materialEd_cubemapEd_cubeMapPreview = "materialEd_cubemapEd_cubeMapPreview";
            CubemapData matEdCubeMapPreviewMat = "matEdCubeMapPreviewMat";
            CustomMaterial materialEd_justAlphaMaterial = "materialEd_justAlphaMaterial";
            ShaderData materialEd_justAlphaShader = "materialEd_justAlphaShader";

            ArrayObject UnlistedMaterials = new ObjectCreator("ArrayObject", "UnlistedMaterials").Create();
            UnlistedMaterials.add("unlistedMaterials", WarningMaterial);
            UnlistedMaterials.add("unlistedMaterials", materialEd_previewMaterial);
            UnlistedMaterials.add("unlistedMaterials", notDirtyMaterial);
            UnlistedMaterials.add("unlistedMaterials", materialEd_cubemapEd_cubeMapPreview);
            UnlistedMaterials.add("unlistedMaterials", matEdCubeMapPreviewMat);
            UnlistedMaterials.add("unlistedMaterials", materialEd_justAlphaMaterial);
            UnlistedMaterials.add("unlistedMaterials", materialEd_justAlphaShader);
            }

        [ConsoleInteraction]
        public void selectMaterial(Material material)
            {
            SimSet TerrainMaterialSet = "TerrainMaterialSet";

            string name = "";

            if (this.terrainMaterials)
                {
                name = material.getName();
                material = TerrainMaterialSet.findObjectByInternalName(name, false);
                }
            else
                {
                name =  material.getName();
                }

            // The callback function should be ready to intake the returned material
            //eval("materialEd_previewMaterial." + propertyField + " = " + value + ";");
            if (this.returnType == "name")
                Util.eval("" + this.selectCallback + "(" + name + ");");
            else if (this.returnType == "index")
                {
                int index = -1;
                if (this.terrainMaterials)
                    {
                    TerrainEditor ETerrainEditor = "ETerrainEditor";
                    // Obtain the index into the terrain's material list
                    string mats = ETerrainEditor.getMaterials();
                    for (int i = 0; i < Util.getRecordCount(mats); i++)
                        {
                        string matInternalName = Util.getRecord(mats, i);
                        if (matInternalName == name)
                            {
                            index = i;
                            break;
                            }
                        }
                    }
                else
                    {
                    SimSet materialSet = "materialSet";

                    // Obtain the index into the material set
                    for (uint i = 0; i < materialSet.getCount(); i++)
                        {
                        SimObject obj = materialSet.getObject(i);
                        if (obj.getName() == name)
                            {
                            index = (int) i;
                            break;
                            }
                        }
                    }

                Util.eval("" + this.selectCallback + "(" + index + ");");
                }
            else
                Util.eval("" + this.selectCallback + "(" + material + ");");
            this.hideDialog();
            }

        [ConsoleInteraction]
        public void showDialog(string selectCallback, string returnType)
            {
            if (this.isVisible())
                return;

            this.showDialogBase(selectCallback, returnType, false);
            }

        [ConsoleInteraction]
        public void showTerrainDialog(string selectCallback, string returnType)
            {
            this.showDialogBase(selectCallback, returnType, true);
            }

        [ConsoleInteraction]
        public void showDialogBase(string selectCallback, string returnType, bool useTerrainMaterials)
            {
            GuiPopUpMenuCtrlEx materialPreviewCountPopup = this.FOT("materialPreviewCountPopup");
            GuiCanvas Canvas = "Canvas";
            GuiControl MaterialSelectorOverlay = "MaterialSelectorOverlay";

            // Set the select callback
            this.selectCallback = selectCallback;
            this.returnType = returnType;

            this.currentFilter = sGlobal["$Pref::MaterialSelector::CurrentFilter"];

            this.terrainMaterials = useTerrainMaterials;

            materialPreviewCountPopup.clear();
            materialPreviewCountPopup.add("10", 0);
            materialPreviewCountPopup.add("15", 1);
            materialPreviewCountPopup.add("25", 2);
            materialPreviewCountPopup.add("50", 3);
            materialPreviewCountPopup.add("75", 4);
            materialPreviewCountPopup.add("100",5);
            materialPreviewCountPopup.setSelected(iGlobal["$Pref::MaterialSelector::ThumbnailCountIndex"]);

            Canvas.pushDialog(MaterialSelectorOverlay);
            this.setVisible(true);
            this.buildStaticFilters();

            this.currentStaticFilter = sGlobal["$Pref::MaterialSelector::CurrentStaticFilter"];

            this.selectedMaterial = "";
            this.loadMaterialFilters();
            }

        [ConsoleInteraction]
        public void hideDialog()
            {
            GuiCanvas Canvas = "Canvas";
            GuiControl MaterialSelectorOverlay = "MaterialSelectorOverlay";

            this.breakdown();
            this.setVisible(false);
            Canvas.popDialog(MaterialSelectorOverlay);
            }

        [ConsoleInteraction]
        public void breakdown()
            {
            ArrayObject MaterialFilterAllArray = "MaterialFilterAllArray";
            ArrayObject MaterialFilterMappedArray = "MaterialFilterMappedArray";
            ArrayObject MaterialFilterUnmappedArray = "MaterialFilterUnmappedArray";
            ArrayObject MatEdPreviewArray = "MatEdPreviewArray";

            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");
            GuiDynamicCtrlArrayControl materialSelection = this.FOT("materialSelection");
            GuiDynamicCtrlArrayControl materialCategories = this.FOT("materialCategories");

            sGlobal["$Pref::MaterialSelector::CurrentStaticFilter"] = this.currentStaticFilter.name;
            sGlobal["$Pref::MaterialSelector::CurrentFilter"] = this.currentFilter;

            filterArray.deleteAllObjects();
            materialSelection.deleteAllObjects();
            MatEdPreviewArray.delete();

            materialCategories.deleteAllObjects();
            MaterialFilterAllArray.delete();
            MaterialFilterMappedArray.delete();
            MaterialFilterUnmappedArray.delete();
            }

        [ConsoleInteraction]
        public void buildStaticFilters()
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            SimSet materialSet = "materialSet";
            SimSet TerrainMaterialSet = "TerrainMaterialSet";
            ArrayObject UnlistedMaterials = "UnlistedMaterials";
            GuiCheckBoxCtrl MaterialFilterAllArrayCheckbox = "MaterialFilterAllArrayCheckbox";
            GuiCheckBoxCtrl MaterialFilterMappedArrayCheckbox = "MaterialFilterMappedArrayCheckbox";
            GuiCheckBoxCtrl MaterialFilterUnmappedArrayCheckbox = "MaterialFilterUnmappedArrayCheckbox";

            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            // if you want to add any more containers to staticFilterObjects, here's
            // where to do it

            //TODO

            #region GuiControl  ()        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiControl ", "");

            #region GuiContainer ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiContainer", "");
            oc_Newobject46["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject46["Position"] = "0 0";
            oc_Newobject46["Extent"] = "128 18";
            oc_Newobject46["HorizSizing"] = "right";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["isContainer"] = "1";
            oc_Newobject46["parentGroup"] = new ObjectCreator.StringNoQuote("%filter");

            #region GuiContainer ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiContainer", "");
            oc_Newobject44["profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject44["Position"] = "-1 0";
            oc_Newobject44["Extent"] = "128 32";
            oc_Newobject44["HorizSizing"] = "right";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["isContainer"] = "1";

            #endregion

            oc_Newobject46["#Newobject44"] = oc_Newobject44;

            #region GuiTextCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject45["Profile"] = "EditorTextProfile";
            oc_Newobject45["position"] = "5 0";
            oc_Newobject45["Extent"] = "118 18";
            oc_Newobject45["text"] = "Types";

            #endregion

            oc_Newobject46["#Newobject45"] = oc_Newobject45;

            #endregion

            oc_Newobject58["#Newobject46"] = oc_Newobject46;

            #region GuiContainer ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiContainer", "");
            oc_Newobject48["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject48["Position"] = "415 191";
            oc_Newobject48["Extent"] = "128 18";
            oc_Newobject48["HorizSizing"] = "right";
            oc_Newobject48["VertSizing"] = "bottom";
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["parentGroup"] = new ObjectCreator.StringNoQuote("%filter");

            #region GuiCheckBoxCtrl (MaterialFilterAllArrayCheckbox)        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiCheckBoxCtrl", "MaterialFilterAllArrayCheckbox");
            oc_Newobject47["Profile"] = "ToolsGuiCheckBoxListProfile";
            oc_Newobject47["position"] = "5 2";
            oc_Newobject47["Extent"] = "118 18";
            oc_Newobject47["text"] = "All";
            oc_Newobject47["Command"] = "MaterialSelector.switchStaticFilters(\\\"MaterialFilterAllArray\\\");";

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject58["#Newobject48"] = oc_Newobject48;

            #region GuiContainer ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiContainer", "");
            oc_Newobject50["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject50["Position"] = "415 191";
            oc_Newobject50["Extent"] = "128 18";
            oc_Newobject50["HorizSizing"] = "right";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["isContainer"] = "1";
            oc_Newobject50["parentGroup"] = new ObjectCreator.StringNoQuote("%filter");

            #region GuiCheckBoxCtrl (MaterialFilterMappedArrayCheckbox)        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiCheckBoxCtrl", "MaterialFilterMappedArrayCheckbox");
            oc_Newobject49["Profile"] = "ToolsGuiCheckBoxListProfile";
            oc_Newobject49["position"] = "5 2";
            oc_Newobject49["Extent"] = "118 18";
            oc_Newobject49["text"] = "Mapped";
            oc_Newobject49["Command"] = "MaterialSelector.switchStaticFilters(\\\"MaterialFilterMappedArray\\\");";

            #endregion

            oc_Newobject50["#Newobject49"] = oc_Newobject49;

            #endregion

            oc_Newobject58["#Newobject50"] = oc_Newobject50;

            #region GuiContainer ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiContainer", "");
            oc_Newobject52["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject52["Position"] = "415 191";
            oc_Newobject52["Extent"] = "128 18";
            oc_Newobject52["HorizSizing"] = "right";
            oc_Newobject52["VertSizing"] = "bottom";
            oc_Newobject52["isContainer"] = "1";
            oc_Newobject52["parentGroup"] = new ObjectCreator.StringNoQuote("%filter");

            #region GuiCheckBoxCtrl (MaterialFilterUnmappedArrayCheckbox)        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiCheckBoxCtrl", "MaterialFilterUnmappedArrayCheckbox");
            oc_Newobject51["Profile"] = "ToolsGuiCheckBoxListProfile";
            oc_Newobject51["position"] = "5 2";
            oc_Newobject51["Extent"] = "118 18";
            oc_Newobject51["text"] = "Unmapped";
            oc_Newobject51["Command"] = "MaterialSelector.switchStaticFilters(\\\"MaterialFilterUnmappedArray\\\");";

            #endregion

            oc_Newobject52["#Newobject51"] = oc_Newobject51;

            #endregion

            oc_Newobject58["#Newobject52"] = oc_Newobject52;

            #region GuiContainer ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiContainer", "");
            oc_Newobject57["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject57["Position"] = "0 0";
            oc_Newobject57["Extent"] = "128 18";
            oc_Newobject57["HorizSizing"] = "right";
            oc_Newobject57["VertSizing"] = "bottom";
            oc_Newobject57["isContainer"] = "1";
            oc_Newobject57["parentGroup"] = new ObjectCreator.StringNoQuote("%filter");

            #region GuiContainer ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiContainer", "");
            oc_Newobject53["profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject53["Position"] = "-1 0";
            oc_Newobject53["Extent"] = "128 32";
            oc_Newobject53["HorizSizing"] = "right";
            oc_Newobject53["VertSizing"] = "bottom";
            oc_Newobject53["isContainer"] = "1";

            #endregion

            oc_Newobject57["#Newobject53"] = oc_Newobject53;

            #region GuiTextCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject54["Profile"] = "EditorTextProfile";
            oc_Newobject54["position"] = "5 0";
            oc_Newobject54["Extent"] = "118 18";
            oc_Newobject54["text"] = "Tags";

            #endregion

            oc_Newobject57["#Newobject54"] = oc_Newobject54;

            #region GuiBitmapButtonCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["Enabled"] = "1";
            oc_Newobject55["isContainer"] = "0";
            oc_Newobject55["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject55["HorizSizing"] = "left";
            oc_Newobject55["VertSizing"] = "bottom";
            oc_Newobject55["position"] = "105 2";
            oc_Newobject55["Extent"] = "15 15";
            oc_Newobject55["MinExtent"] = "8 2";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["Command"] =
                "MaterialSelector_addFilterWindow.setVisible(1); MaterialSelectorOverlay.pushToBack(MaterialSelector_addFilterWindow);";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["tooltip"] = "Create New Tag";
            oc_Newobject55["bitmap"] = "tools/gui/images/new";
            oc_Newobject55["groupNum"] = "-1";
            oc_Newobject55["buttonType"] = "PushButton";
            oc_Newobject55["useMouseEvents"] = "0";

            #endregion

            oc_Newobject57["#Newobject55"] = oc_Newobject55;

            #region GuiBitmapButtonCtrl ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject56["canSaveDynamicFields"] = "0";
            oc_Newobject56["Enabled"] = "1";
            oc_Newobject56["isContainer"] = "0";
            oc_Newobject56["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject56["HorizSizing"] = "left";
            oc_Newobject56["VertSizing"] = "bottom";
            oc_Newobject56["position"] = "89 2";
            oc_Newobject56["Extent"] = "13 13";
            oc_Newobject56["MinExtent"] = "8 2";
            oc_Newobject56["canSave"] = "1";
            oc_Newobject56["Visible"] = "1";
            oc_Newobject56["Command"] = "MaterialSelector.clearMaterialFilters();";
            oc_Newobject56["hovertime"] = "1000";
            oc_Newobject56["tooltip"] = "Clear Selected Tag";
            oc_Newobject56["bitmap"] = "tools/gui/images/clear-btn";
            oc_Newobject56["groupNum"] = "-1";
            oc_Newobject56["buttonType"] = "PushButton";
            oc_Newobject56["useMouseEvents"] = "0";

            #endregion

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #endregion

            oc_Newobject58["#Newobject57"] = oc_Newobject57;

            #endregion

            GuiControl staticFilterContainer = oc_Newobject58.Create();

            int filterCount = staticFilterContainer.getCount();
            for (; filterCount != 0; filterCount--)
                filterArray.addGuiControl(staticFilterContainer.getObject(0));

            this.staticFilterObjects = filterArray.getCount();

            staticFilterContainer.delete();

            // Create our category array used in the selector, this code should be taken out
            // in order to make the material selector agnostic
            ArrayObject MaterialFilterAllArray = new ObjectCreator("ArrayObject", "MaterialFilterAllArray").Create();
            ArrayObject MaterialFilterMappedArray =
                new ObjectCreator("ArrayObject", "MaterialFilterMappedArray").Create();
            ArrayObject MaterialFilterUnmappedArray =
                new ObjectCreator("ArrayObject", "MaterialFilterUnmappedArray").Create();

            string mats = "";
            int count = 0;
            if (this.terrainMaterials)
                {
                mats = ETerrainEditor.getTerrainBlocksMaterialList();
                count = Util.getRecordCount(mats);
                }
            else
                {
                count = materialSet.getCount();
                }

            for (uint i = 0; i < count; i++)
                {
                Material material;
                // Process terrain materials
                if (this.terrainMaterials)
                    {
                    string matInternalName = Util.getRecord(mats, (int) i);
                    material = TerrainMaterialSet.findObjectByInternalName(matInternalName, false);

                    // Is there no material info for this slot?
                    if (!material.isObject())
                        continue;

                    // Add to the appropriate filters
                    MaterialFilterMappedArray.add("", material);
                    MaterialFilterAllArray.add("", material);

                    continue;
                    }

                // Process regular materials here
                material = materialSet.getObject(i);

                bool unlistedFound = false;
                for (int k = 0; k < UnlistedMaterials.count(); k++)
                    {
                    unlistedFound = false;
                    if (UnlistedMaterials.getValue(k) == material.name)
                        {
                        unlistedFound = true;
                        break;
                        }
                    }

                if (unlistedFound)
                    continue;

                if (material.mapTo == "" || material.mapTo == "unmapped_mat")
                    {
                    MaterialFilterUnmappedArray.add("", material.name);
                    //running through the existing tag names
                    for (int j = 0; material.getFieldValue("materialTag" + j, -1) != ""; j++)
                        MaterialFilterUnmappedArray.add(material.getFieldValue("materialTag" + j, -1), material.name);
                    }
                else
                    {
                    MaterialFilterMappedArray.add("", material.name);
                    for (int j = 0; material.getFieldValue("materialTag" + j, -1) != ""; j++)
                        MaterialFilterMappedArray.add(material.getFieldValue("materialTag" + j, -1), material.name);
                    }

                MaterialFilterAllArray.add("", material.name);
                for (int j = 0; material.getFieldValue("materialTag" + j, -1) != ""; j++)
                    MaterialFilterAllArray.add(material.getFieldValue("materialTag" + j, -1), material.name);
                }

            MaterialFilterAllArrayCheckbox.setText("All ( " + MaterialFilterAllArray.count() + " ) ");
            MaterialFilterMappedArrayCheckbox.setText("Mapped ( " + MaterialFilterMappedArray.count() + " ) ");
            MaterialFilterUnmappedArrayCheckbox.setText("Unmapped ( " + MaterialFilterUnmappedArray.count() + " ) ");
            }

        [ConsoleInteraction]
        public void preloadFilter()
            {
            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            string selectedFilter = "";
            for (uint i = (uint) this.staticFilterObjects; i < filterArray.getCount(); i++)
                {
                    if (((GuiCheckBoxCtrl)((SimSet)filterArray.getObject(i)).getObject(0)).getValue().AsInt() == 1)
                    {
                    if (selectedFilter == "")
                        selectedFilter = ((SimObject) ((SimSet) filterArray.getObject(i)).getObject(0))["filter"];
                    else
                        selectedFilter = selectedFilter + " " +
                                         ((SimObject) ((SimSet) filterArray.getObject(i)).getObject(0))["filter"];
                    }
                }
            this.loadFilter(selectedFilter);
            }

        [ConsoleInteraction]
        public void loadFilter(string selectedFilter, string staticFilter = "")
            {
            ArrayObject MatEdScheduleArray = "MatEdScheduleArray";
            ArrayObject MatEdPreviewArray = "MatEdPreviewArray";

            GuiDynamicCtrlArrayControl materialSelection = this.FOT("materialSelection");
            GuiStackControl materialPreviewPagesStack = this.FOT("materialPreviewPagesStack");
            GuiPopUpMenuCtrlEx materialPreviewCountPopup = this.FOT("materialPreviewCountPopup");

            // manage schedule array properly
            if (!MatEdScheduleArray.isObject())
                MatEdScheduleArray = new ObjectCreator("ArrayObject", "MatEdScheduleArray").Create();

            // if we select another list... delete all schedules that were created by 
            // previous load
            for (int i = 0; i < MatEdScheduleArray.count(); i++)
                Util.cancel(MatEdScheduleArray.getKey(i).AsInt());

            // we have to empty out the list; so when we create new schedules, these dont linger
            MatEdScheduleArray.empty();

            // manage preview array
            if (!MatEdPreviewArray.isObject())
                MatEdPreviewArray = new ObjectCreator("ArrayObject", "MatEdPreviewArray").Create();

            // we have to empty out the list; so when we create new guicontrols, these dont linger
            MatEdPreviewArray.empty();
            materialSelection.deleteAllObjects();
            materialPreviewPagesStack.deleteAllObjects();

            // changed to accomadate tagging. dig through the array for each tag name,
            // call unique value, sort, and we have a perfect set of materials
            if (staticFilter != "")
                this.currentStaticFilter = staticFilter;

            this.currentFilter = selectedFilter;

            ArrayObject filteredObjectsArray = new ObjectCreator("ArrayObject").Create();

            int previewsPerPage = materialPreviewCountPopup.getTextById(materialPreviewCountPopup.getSelected()).AsInt();

            int tagCount = Util.getWordCount(this.currentFilter);
            if (tagCount != 0)
                {
                for (int j = 0; j < tagCount; j++)
                    {
                    for (int i = 0; i < this.currentStaticFilter.count(); i++)
                        {
                        string currentTag = Util.getWord(this.currentFilter, j);
                        if (this.currentStaticFilter.getKey(i) == currentTag)
                            filteredObjectsArray.add(this.currentStaticFilter.getKey(i),
                                this.currentStaticFilter.getValue(i));
                        }
                    }

                filteredObjectsArray.uniqueValue();
                filteredObjectsArray.sortd();

                this.totalPages = Util.mCeil(filteredObjectsArray.count()/previewsPerPage);

                //Can we maintain the current preview page, or should we go to page 1?
                if ((this.currentPreviewPage*previewsPerPage) >= filteredObjectsArray.count())
                    this.currentPreviewPage = 0;

                // Build out the pages buttons
                this.buildPagesButtons(this.currentPreviewPage, this.totalPages);

                int previewCount = previewsPerPage;
                int possiblePreviewCount = filteredObjectsArray.count() - this.currentPreviewPage*previewsPerPage;
                if (possiblePreviewCount < previewCount)
                    previewCount = possiblePreviewCount;

                int start = this.currentPreviewPage*previewsPerPage;
                for (int i = start; i < start + previewCount; i++)
                    this.buildPreviewArray(filteredObjectsArray.getValue(i));

                filteredObjectsArray.delete();
                }
            else
                {
                this.currentStaticFilter.sortd();

                // Rebuild the static filter list without tagged materials
                ArrayObject noTagArray = new ObjectCreator("ArrayObject").Create();
                for (int i = 0; i < this.currentStaticFilter.count(); i++)
                    {
                    if (this.currentStaticFilter.getKey(i) != "")
                        continue;

                    SimObject material = this.currentStaticFilter.getValue(i);

                    // CustomMaterials are not available for selection
                    if (!material.isObject() || material.isMemberOfClass("CustomMaterial"))
                        continue;

                    noTagArray.add("", material);
                    }

                this.totalPages = Util.mCeil(noTagArray.count()/previewsPerPage);

                //Can we maintain the current preview page, or should we go to page 1?
                if ((this.currentPreviewPage*previewsPerPage) >= noTagArray.count())
                    this.currentPreviewPage = 0;

                // Build out the pages buttons
                this.buildPagesButtons(this.currentPreviewPage, this.totalPages);

                int previewCount = previewsPerPage;
                int possiblePreviewCount = noTagArray.count() - this.currentPreviewPage*previewsPerPage;
                if (possiblePreviewCount < previewCount)
                    previewCount = possiblePreviewCount;

                int start = this.currentPreviewPage*previewsPerPage;
                for (int i = start; i < start + previewCount; i++)
                    {
                    this.buildPreviewArray(noTagArray.getValue(i));
                    }
                }


            this.loadImages(0);
            }

        [ConsoleInteraction]
        public void buildPreviewArray(Material material)
            {
            GuiDynamicCtrlArrayControl materialSelection = this.FOT("materialSelection");
            ArrayObject MatEdPreviewArray = "MatEdPreviewArray";

            string matName = "";

            // CustomMaterials are not available for selection
            if (!material.isObject() || material.isMemberOfClass("CustomMaterial"))
                return;

            string previewImage = "";

            if (material.isMemberOfClass("TerrainMaterial"))
                {
                matName = material.getInternalName();

                if (material["diffuseMap"] == "")
                    previewImage = "core/art/warnmat";
                else
                    previewImage = material["diffuseMap"];
                }
            else if (material.toneMap[0] == "" && material.diffuseMap[0] == "" && !material.cubemap.isObject())
                {
                matName = material.name;
                previewImage = "core/art/warnmat";
                }
            else
                {
                matName = material.name;

                if (material.toneMap[0] != "")
                    previewImage = material.toneMap[0].Value;
                else if (material.diffuseMap[0] != "")
                    previewImage = material.diffuseMap[0];
                else if (((SimObject) material.cubemap)["cubeFace[0]"] != "")
                    previewImage = ((SimObject) material.cubemap)["cubeFace[0]"];

                //previewImage = MaterialEditorGui.searchForTexture( material,  previewImage );

                // were going to use a couple of string commands in order to properly
                // find out what the img src path is 
                // **NEW** this needs to be updated with the above, but has some timing issues
                string materialDiffuse = previewImage;
                string materialPath = material.getFilename();

                if (Util.strchr(materialDiffuse, "/") == "")
                    {
                    int k = 0;
                    while (Util.strpos(materialPath, "/", k) != -1)
                        {
                        int foo = Util.strpos(materialPath, "/", k);
                        k = foo + 1;
                        }

                    string foobar = Util.getSubStr(materialPath, k, 99);
                    previewImage = Util.strreplace(materialPath, foobar, previewImage);
                    }
                else
                    previewImage = Util.strreplace(materialPath, materialPath, previewImage);
                }

            // it may seem goofy why the checkbox can't be instanciated inside the container
            // reason being its because we need to store the checkbox ctrl in order to make changes
            // on it later in the function. 

            #region GuiControl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiControl", "");
            oc_Newobject63["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject63["Position"] = "0 0";
            oc_Newobject63["Extent"] = "74 87";
            oc_Newobject63["HorizSizing"] = "right";
            oc_Newobject63["VertSizing"] = "bottom";
            oc_Newobject63["isContainer"] = "1";

            #region GuiTextCtrl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject62["position"] = "7 71";
            oc_Newobject62["profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject62["extent"] = "64 16";
            oc_Newobject62["text"] = matName;

            #endregion

            oc_Newobject63["#Newobject62"] = oc_Newobject62;

            #endregion

            GuiControl container = oc_Newobject63.Create();

            #region GuiBitmapButtonCtrl ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject65["internalName"] = matName;
            oc_Newobject65["HorizSizing"] = "right";
            oc_Newobject65["VertSizing"] = "bottom";
            oc_Newobject65["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject65["position"] = "7 4";
            oc_Newobject65["extent"] = "64 64";
            oc_Newobject65["buttonType"] = "PushButton";
            oc_Newobject65["bitmap"] = "";
            oc_Newobject65["Command"] = "";
            oc_Newobject65["text"] = "Loading...";
            oc_Newobject65["useStates"] = new ObjectCreator.StringNoQuote("false");

            #region GuiBitmapButtonCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject64["HorizSizing"] = "right";
            oc_Newobject64["VertSizing"] = "bottom";
            oc_Newobject64["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject64["position"] = "0 0";
            oc_Newobject64["extent"] = "64 64";
            oc_Newobject64["Variable"] = "";
            oc_Newobject64["buttonType"] = "ToggleButton";
            oc_Newobject64["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";
            oc_Newobject64["groupNum"] = "0";
            oc_Newobject64["text"] = "";

            #endregion

            oc_Newobject65["#Newobject64"] = oc_Newobject64;

            #endregion

            GuiBitmapButtonCtrl previewButton = oc_Newobject65.Create();

            #region GuiButtonCtrl ()        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject66["internalName"] = matName + "Border";
            oc_Newobject66["HorizSizing"] = "right";
            oc_Newobject66["VertSizing"] = "bottom";
            oc_Newobject66["profile"] = "ToolsGuiThumbHighlightButtonProfile";
            oc_Newobject66["position"] = "3 0";
            oc_Newobject66["extent"] = "72 88";
            oc_Newobject66["Variable"] = "";
            oc_Newobject66["buttonType"] = "ToggleButton";
            oc_Newobject66["tooltip"] = matName;
            oc_Newobject66["Command"] =
                "MaterialSelector.updateSelection( $ThisControl.getParent().getObject(1).internalName, $ThisControl.getParent().getObject(1).bitmap );";
            oc_Newobject66["groupNum"] = "0";
            oc_Newobject66["text"] = "";

            #endregion

            GuiControl previewBorder = oc_Newobject66.Create();

            container.add(previewButton);
            container.add(previewBorder);
            // add to the gui control array
            materialSelection.add(container);

            // add to the array object for reference later
            MatEdPreviewArray.add(previewButton, previewImage);
            }

        [ConsoleInteraction]
        public void loadImages(int materialNum)
            {
            ArrayObject MatEdPreviewArray = "MatEdPreviewArray";
            ArrayObject MatEdScheduleArray = "MatEdScheduleArray";

            // this will save us from spinning our wheels in case we don't exist
            if (!this.visible)
                return;

            // this schedule is here to dynamically load images
            GuiBitmapButtonCtrl previewButton = MatEdPreviewArray.getKey(materialNum);
            string previewImage = MatEdPreviewArray.getValue(materialNum);

            previewButton.setBitmap(previewImage);
            previewButton.setText("");

            materialNum++;

            if (materialNum < MatEdPreviewArray.count())
                {
                int tempSchedule = this.schedule("64", "loadImages", materialNum.AsString());
                MatEdScheduleArray.add(tempSchedule.AsString(), materialNum.AsString());
                }
            }

        [ConsoleInteraction]
        public void clearMaterialFilters()
            {
            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            for (uint i = (uint) this.staticFilterObjects; i < filterArray.getCount(); i++)
                ((GuiButtonCtrl) ((SimSet) filterArray.getObject(i)).getObject(0)).setStateOn(false);

            this.loadFilter("", "");
            }

        [ConsoleInteraction]
        public void loadMaterialFilters()
            {
            ArrayObject MaterialFilterAllArray = "MaterialFilterAllArray";

            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            ArrayObject filteredTypesArray = new ObjectCreator("ArrayObject").Create();

            filteredTypesArray.duplicate(MaterialFilterAllArray);
            filteredTypesArray.uniqueKey();

            // sort the the keys before we do anything
            filteredTypesArray.sortkd();

            Util.eval(this.currentStaticFilter.name + "Checkbox.setStateOn(1);");
            // it may seem goofy why the checkbox can't be instanciated inside the container
            // reason being its because we need to store the checkbox ctrl in order to make changes
            // on it later in the function. 
            string selectedFilter = "";
            for (int i = 0; i < filteredTypesArray.count(); i++)
                {
                string filter = filteredTypesArray.getKey(i);
                if (filter == "")
                    continue;

                #region GuiControl ()        oc_Newobject67

                ObjectCreator oc_Newobject67 = new ObjectCreator("GuiControl", "");
                oc_Newobject67["profile"] = "ToolsGuiDefaultProfile";
                oc_Newobject67["Position"] = "0 0";
                oc_Newobject67["Extent"] = "128 18";
                oc_Newobject67["HorizSizing"] = "right";
                oc_Newobject67["VertSizing"] = "bottom";
                oc_Newobject67["isContainer"] = "1";

                #endregion

                GuiControl container = oc_Newobject67.Create();

                #region GuiCheckBoxCtrl ()        oc_Newobject68

                ObjectCreator oc_Newobject68 = new ObjectCreator("GuiCheckBoxCtrl", "");
                oc_Newobject68["Profile"] = "ToolsGuiCheckBoxListProfile";
                oc_Newobject68["position"] = "5 1";
                oc_Newobject68["Extent"] = "118 18";
                oc_Newobject68["Command"] = "";
                oc_Newobject68["groupNum"] = "0";
                oc_Newobject68["buttonType"] = "ToggleButton";
                oc_Newobject68["text"] = filter + " ( " + MaterialFilterAllArray.countKey(filter) + " )";
                oc_Newobject68["filter"] = filter;
                oc_Newobject68["Command"] = "MaterialSelector.preloadFilter();";

                #endregion

                GuiCheckBoxCtrl checkbox = oc_Newobject68.Create();


                container.add(checkbox);
                filterArray.add(container);

                int tagCount = Util.getWordCount(this.currentFilter);
                for (int j = 0; j < tagCount; j++)
                    {
                    if (filter == Util.getWord(this.currentFilter, j))
                        {
                        if (selectedFilter == "")
                            selectedFilter = filter;
                        else
                            selectedFilter = selectedFilter + " " + filter;

                        checkbox.setStateOn(true);
                        }
                    }
                }

            this.loadFilter(selectedFilter);

            filteredTypesArray.delete();
            }

        [ConsoleInteraction]
        // create category and update current material if there is one
        public void createFilter(string filter)
            {
            ArrayObject MaterialFilterAllArray = "MaterialFilterAllArray";
            GuiWindowCtrl MaterialSelector_addFilterWindow = "MaterialSelector_addFilterWindow";
            GuiTextEditCtrl tagName = MaterialSelector_addFilterWindow.FOT("tagName");

            //TODO
            string existingFilters = "";

            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            if (filter == existingFilters)
                {
                messageBox.MessageBoxOK("Error", "Can not create blank filter.");
                return;
                }

            for (uint i = (uint) this.staticFilterObjects; i < filterArray.getCount(); i++)
                {
                existingFilters = ((SimObject) ((SimSet) filterArray.getObject(i)).getObject(0))["filter"];
                if (filter == existingFilters)
                    {
                    messageBox.MessageBoxOK("Error", "Can not create two filters of the same name.");
                    return;
                    }
                }

            #region GuiControl ()        oc_Newobject71

            ObjectCreator oc_Newobject71 = new ObjectCreator("GuiControl", "");
            oc_Newobject71["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject71["Position"] = "0 0";
            oc_Newobject71["Extent"] = "128 18";
            oc_Newobject71["HorizSizing"] = "right";
            oc_Newobject71["VertSizing"] = "bottom";
            oc_Newobject71["isContainer"] = "1";

            #region GuiCheckBoxCtrl ()        oc_Newobject70

            ObjectCreator oc_Newobject70 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject70["Profile"] = "ToolsGuiCheckBoxListProfile";
            oc_Newobject70["position"] = "5 1";
            oc_Newobject70["Extent"] = "118 18";
            oc_Newobject70["Command"] = "";
            oc_Newobject70["groupNum"] = "0";
            oc_Newobject70["buttonType"] = "ToggleButton";
            oc_Newobject70["text"] = filter + " ( " + MaterialFilterAllArray.countKey(filter) + " )";
            oc_Newobject70["filter"] = filter;
            oc_Newobject70["Command"] = "MaterialSelector.preloadFilter();";

            #endregion

            oc_Newobject71["#Newobject70"] = oc_Newobject70;

            #endregion

            GuiControl container = oc_Newobject71.Create();

            filterArray.add(container);

            // if selection exists, lets reselect it to refresh it
            if (this.selectedMaterial.isObject())
                this.updateSelection(this.selectedMaterial, this.selectedPreviewImagePath);

            // material category text field to blank
            tagName.setText("");
            }

        [ConsoleInteraction]
        public void updateSelection(SimObject material, string previewImagePath)
            {
            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");
            GuiDynamicCtrlArrayControl materialCategories = this.FOT("materialCategories");
            GuiTextCtrl previewSelectionText = this.FOT("previewSelectionText");
            GuiBitmapCtrl previewSelection = this.FOT("previewSelection");

            // the material selector will visually update per material information
            // after we move away from the material. eg: if we remove a field from the material,
            // the empty checkbox will still be there until you move fro and to the material again

            bool isMaterialBorder = false;
            isMaterialBorder = this.FOT(material + "Border").isObject();
            if (isMaterialBorder)
                {
                ((GuiButtonCtrl) this.FOT(material + "Border")).setStateOn(true);
                }

            bool isMaterialBorderPrevious = false;
            isMaterialBorderPrevious = this.FOT(sGlobal["$prevSelectedMaterialHL"] + "Border").isObject();
            if (isMaterialBorderPrevious)
                {
                ((GuiButtonCtrl) this.FOT(sGlobal["$prevSelectedMaterialHL"] + "Border")).setStateOn(false);
                }

            materialCategories.deleteAllObjects();
            this.selectedMaterial = material;
            this.selectedPreviewImagePath = previewImagePath;
            previewSelectionText.setText(material.name);
            previewSelection.setBitmapX(previewImagePath);

            // running through the existing list of categorynames in the left, so yes
            // some might exist on the left only temporary if not given a home
            for (uint i = (uint) this.staticFilterObjects; i < filterArray.getCount(); i++)
                {
                string filter = ((SimObject) ((SimSet) filterArray.getObject(i)).getObject(0))["filter"];

                #region GuiCheckBoxCtrl ()        oc_Newobject72

                ObjectCreator oc_Newobject72 = new ObjectCreator("GuiCheckBoxCtrl", "");
                oc_Newobject72["materialName"] = material.name;
                oc_Newobject72["Profile"] = "ToolsGuiCheckBoxListProfile";
                oc_Newobject72["position"] = "5 2";
                oc_Newobject72["Extent"] = "118 18";
                oc_Newobject72["Command"] =
                    "MaterialSelector.updateMaterialTags( $ThisControl.materialName, $ThisControl.getText(), $ThisControl.getValue() );";
                oc_Newobject72["text"] = filter;

                #endregion

                GuiCheckBoxCtrl checkbox = oc_Newobject72.Create();

                materialCategories.add(checkbox);
                // crawl through material for categories in order to check or not
                bool filterFound = false;
                for (int j = 0; material.getFieldValue("materialTag" + j, -1) != ""; j++)
                    {
                    string tag = material.getFieldValue("materialTag" + j, -1);

                    if (tag == filter)
                        {
                        filterFound = true;
                        break;
                        }
                    }

                if (filterFound)
                    checkbox.setStateOn(true);
                else
                    checkbox.setStateOn(false);
                }

            sGlobal["$prevSelectedMaterialHL"] = material;
            }

        [ConsoleInteraction]
        public void updateMaterialTags(Material material, string tag, bool tagValue)
            {
            ArrayObject MaterialFilterAllArray = "MaterialFilterAllArray";
            ArrayObject MaterialFilterUnmappedArray = "MaterialFilterUnmappedArray";
            ArrayObject MaterialFilterMappedArray = "MaterialFilterMappedArray";
            PersistenceManager MaterialSelectorPerMan = "MaterialSelectorPerMan";

            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");
            ArrayObject secondStaticFilter;
            string lastTagField = "";

            if (tagValue)
                {
                MaterialFilterAllArray.add(tag, material);
                if (material.mapTo == "" || material.mapTo == "unmapped_mat")
                    secondStaticFilter = MaterialFilterUnmappedArray;
                else
                    secondStaticFilter = MaterialFilterMappedArray;

                secondStaticFilter.add(tag, material);

                bool createdTag = false;
                for (int i = 0; !createdTag; i++)
                    {
                    string materialTag = material.getFieldValue("materialTag" + i, -1);
                    if (materialTag == "")
                        {
                        Util.eval(material + ".materialTag" + i + "=" + tag + ";");
                        createdTag = true;

                        for (uint j = (uint) this.staticFilterObjects; j < filterArray.getCount(); j++)
                            {
                            if (tag == ((SimObject) ((SimSet) filterArray.getObject(j)).getObject(0))["filter"])
                            {
                                int count =
                                    Util.getWord(
                                        ((GuiCheckBoxCtrl) ((SimSet) filterArray.getObject(j)).getObject(0)).getText(),
                                        2).AsInt();
                                count++;
                                    ((GuiCheckBoxCtrl) ((SimSet) filterArray.getObject(j)).getObject(0)).setText(
                                        tag + " ( " + count + " )");
                                }
                            }

                        break;
                        }
                    }
                }
            else
                {
                // Remove the material from the "all" category
                for (int i = 0; i < MaterialFilterAllArray.count(); i++)
                    {
                    if (MaterialFilterAllArray.getKey(i) == tag)
                        {
                        if (MaterialFilterAllArray.getValue(i) == material)
                            {
                            MaterialFilterAllArray.erase(i);
                            break;
                            }
                        }
                    }

                // Figure out what the material's other category is
                if (material.mapTo == "" || material.mapTo == "unmapped_mat")
                    secondStaticFilter = MaterialFilterUnmappedArray;
                else
                    secondStaticFilter = MaterialFilterMappedArray;

                // Remove the material from its other category
                for (int i = 0; i < secondStaticFilter.count(); i++)
                    {
                    if (secondStaticFilter.getKey(i) == tag)
                        {
                        if (secondStaticFilter.getValue(i) == material)
                            {
                            secondStaticFilter.erase(i);
                            break;
                            }
                        }
                    }


                this.updateFilterCount(tag, false);

                string tagField = this.getTagField(material, tag);
                lastTagField = this.getLastTagField(material);
                string lastValidTagField = this.getLastValidTagField(material, tag);

                if (tagField == lastValidTagField || lastValidTagField == "")
                    {
                    MaterialSelectorPerMan.removeField(material, tagField);
                    }
                else
                    {
                    // Replace the current tagFieldValue with the last tagFieldValue
                    string lastValidTag = material.getFieldValue(lastValidTagField, -1);
                    material.setFieldValue(tagField, lastValidTag, -1);

                    // Remove the last tagFieldValue
                    MaterialSelectorPerMan.removeField(material, lastTagField);
                    }
                }

            // so were not going to save materials that dont current exist...
            // technically all the data is stored in dynamic fields if the user feels like saving
            // their auto-generated or new material
            if (material.getFilename() != "" &&
                material.getFilename() != "tools/gui/MaterialSelector.ed.gui" &&
                material.getFilename() != "tools/materialEditor/scripts/materialEditor.ed.cs")
                {
                MaterialSelectorPerMan.setDirty(material);
                MaterialSelectorPerMan.saveDirty();
                MaterialSelectorPerMan.removeDirty(material);

                if (!tagValue)
                    material.setFieldValue(lastTagField, "", -1);
                }
            }

        [ConsoleInteraction]
        public void updateFilterCount(string tag, bool add)
            {
            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            for (uint i = (uint) this.staticFilterObjects; i < filterArray.getCount(); i++)
                {
                if (tag == ((SimObject) ((SimSet) filterArray.getObject(i)).getObject(0))["filter"])
                    {
                    // Get the filter count and apply the operation
                    int idx =
                        Util.getWord(
                            ((GuiCheckBoxCtrl) ((SimSet) filterArray.getObject(i)).getObject(0)).getText(), 2)
                            .AsInt();

                    if (add)
                        idx++;
                    else
                        idx--;

                    ((GuiCheckBoxCtrl)((SimSet)filterArray.getObject(i)).getObject(0)).setText( tag + " ( " + idx + " )");
                    }
                }
            }

        [ConsoleInteraction]
        // this should create a new material pretty nicely
        public void createNewMaterial()
            {
            ArrayObject MaterialFilterAllArray = "MaterialFilterAllArray";
            ArrayObject MaterialFilterUnmappedArray = "MaterialFilterUnmappedArray";
            GuiCheckBoxCtrl MaterialFilterAllArrayCheckbox = "MaterialFilterAllArrayCheckbox";
            GuiCheckBoxCtrl MaterialFilterUnmappedArrayCheckbox = "MaterialFilterUnmappedArrayCheckbox";

            GuiDynamicCtrlArrayControl materialSelection = this.FOT("materialSelection");

            // look for a newMaterial name to grab
            string materialName = Util.getUniqueName("newMaterial");

            #region Material (materialName)        oc_Newobject73

            ObjectCreator oc_Newobject73 = new ObjectCreator("Material", materialName);
            oc_Newobject73["diffuseMap[0]"] = "core/art/warnMat";
            oc_Newobject73["mapTo"] = "unmapped_mat";
            oc_Newobject73["parentGroup"] = new ObjectCreator.StringNoQuote("RootGroup");

            #endregion

            Material material = oc_Newobject73.Create();

            // add one to All filter
            MaterialFilterAllArray.add("", material.name);
            MaterialFilterAllArrayCheckbox.setText("All ( " + MaterialFilterAllArray.count() + 1 + " ) ");

            MaterialFilterUnmappedArray.add("", material.name);
            MaterialFilterUnmappedArrayCheckbox.setText("Unmapped ( " + MaterialFilterUnmappedArray.count() + 1 + " ) ");

            if (this.currentStaticFilter != "MaterialFilterMappedArray")
                {
                // create the new material gui

                #region GuiControl ()        oc_Newobject75

                ObjectCreator oc_Newobject75 = new ObjectCreator("GuiControl", "");
                oc_Newobject75["profile"] = "ToolsGuiDefaultProfile";
                oc_Newobject75["Position"] = "0 0";
                oc_Newobject75["Extent"] = "74 85";
                oc_Newobject75["HorizSizing"] = "right";
                oc_Newobject75["VertSizing"] = "bottom";
                oc_Newobject75["isContainer"] = "1";

                #region GuiTextCtrl ()        oc_Newobject74

                ObjectCreator oc_Newobject74 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject74["position"] = "10 70";
                oc_Newobject74["profile"] = "ToolsGuiTextCenterProfile";
                oc_Newobject74["extent"] = "64 16";
                oc_Newobject74["text"] = material.name;

                #endregion

                oc_Newobject75["#Newobject74"] = oc_Newobject74;

                #endregion

                GuiControl container = oc_Newobject75.Create();

                #region GuiBitmapButtonCtrl ()        oc_Newobject77

                ObjectCreator oc_Newobject77 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                oc_Newobject77["internalName"] = material.name;
                oc_Newobject77["HorizSizing"] = "right";
                oc_Newobject77["VertSizing"] = "bottom";
                oc_Newobject77["profile"] = "ToolsGuiButtonProfile";
                oc_Newobject77["position"] = "7 4";
                oc_Newobject77["extent"] = "64 64";
                oc_Newobject77["buttonType"] = "PushButton";
                oc_Newobject77["bitmap"] = "core/art/warnMat";
                oc_Newobject77["Command"] = "";
                oc_Newobject77["text"] = "Loading...";
                oc_Newobject77["useStates"] = new ObjectCreator.StringNoQuote("false");

                #region GuiBitmapButtonCtrl ()        oc_Newobject76

                ObjectCreator oc_Newobject76 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                oc_Newobject76["HorizSizing"] = "right";
                oc_Newobject76["VertSizing"] = "bottom";
                oc_Newobject76["profile"] = "ToolsGuiButtonProfile";
                oc_Newobject76["position"] = "0 0";
                oc_Newobject76["extent"] = "64 64";
                oc_Newobject76["Variable"] = "";
                oc_Newobject76["buttonType"] = "ToggleButton";
                oc_Newobject76["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";
                oc_Newobject76["groupNum"] = "0";
                oc_Newobject76["text"] = "";

                #endregion

                oc_Newobject77["#Newobject76"] = oc_Newobject76;

                #endregion

                GuiBitmapButtonCtrl previewButton = oc_Newobject77.Create();

                #region GuiButtonCtrl ()        oc_Newobject78

                ObjectCreator oc_Newobject78 = new ObjectCreator("GuiButtonCtrl", "");
                oc_Newobject78["internalName"] = material.name + "Border";
                oc_Newobject78["HorizSizing"] = "right";
                oc_Newobject78["VertSizing"] = "bottom";
                oc_Newobject78["profile"] = "ToolsGuiThumbHighlightButtonProfile";
                oc_Newobject78["position"] = "3 0";
                oc_Newobject78["extent"] = "72 88";
                oc_Newobject78["Variable"] = "";
                oc_Newobject78["buttonType"] = "ToggleButton";
                oc_Newobject78["tooltip"] = material.name;
                oc_Newobject78["Command"] =
                    "MaterialSelector.updateSelection( $ThisControl.getParent().getObject(1).internalName, $ThisControl.getParent().getObject(1).bitmap );";
                oc_Newobject78["groupNum"] = "0";
                oc_Newobject78["text"] = "";

                #endregion

                GuiButtonCtrl previewBorder = oc_Newobject78.Create();

                container.add(previewButton);
                container.add(previewBorder);
                // add to the gui control array
                materialSelection.add(container);
                }

            // select me
            this.updateSelection(material, "core/art/warnMat.png");
            }

        [ConsoleInteraction]
        //needs to be deleted with the persistence manager and needs to be blanked out of the matmanager
        //also need to update instances... i guess which is the tricky part....
        public void showDeleteDialog()
            {
            ArrayObject MaterialFilterUnmappedArray = "MaterialFilterUnmappedArray";

            SimObject material = this.selectedMaterial;
            string secondFilter = "MaterialFilterMappedArray";
            string secondFilterName = "Mapped";

            for (int i = 0; i < MaterialFilterUnmappedArray.count(); i++)
                {
                if (MaterialFilterUnmappedArray.getValue(i) == material)
                    {
                    secondFilter = "MaterialFilterUnmappedArray";
                    secondFilterName = "Unmapped";
                    break;
                    }
                }

            if (material.isObject())
                {
                messageBox.MessageBoxYesNoCancel("Delete Material?",
                    "Are you sure you want to delete<br><br>" + material.getName() +
                    "<br><br> Material deletion won't take affect until the engine is quit.",
                    "MaterialSelector.deleteMaterial( " + material + ", " + secondFilter + ", " + secondFilterName +
                    " );",
                    "",
                    "");
                }
            }

        [ConsoleInteraction]
        public void deleteMaterial(SimObject materialName, ArrayObject secondFilter, string secondFilterName)
            {
            ArrayObject MaterialFilterAllArray = "MaterialFilterAllArray";
            ArrayObject UnlistedMaterials = "UnlistedMaterials";
            PersistenceManager MaterialSelectorPerMan = "MaterialSelectorPerMan";
            GuiCheckBoxCtrl MaterialFilterAllArrayCheckbox = "MaterialFilterAllArrayCheckbox";

            GuiDynamicCtrlArrayControl filterArray = this.FOT("filterArray");

            if (!materialName.isObject())
                return;

            for (int i = 0; i <= MaterialFilterAllArray.countValue(materialName); i++)
                {
                int index = MaterialFilterAllArray.getIndexFromValue(materialName);
                MaterialFilterAllArray.erase(index);
                }
            MaterialFilterAllArrayCheckbox.setText("All ( " + (MaterialFilterAllArray.count() - 1) + " ) ");

            GuiCheckBoxCtrl checkbox = secondFilter + "Checkbox";
            for (int k = 0; k <= secondFilter.countValue(materialName); k++)
                {
                int index = secondFilter.getIndexFromValue(materialName);
                secondFilter.erase(index);
                }

            checkbox.setText(secondFilterName + " ( " + (secondFilter.count() - 1) + " ) ");

            for (int i = 0; materialName.getFieldValue("materialTag" + i, -1) != ""; i++)
                {
                string materialTag = materialName.getFieldValue("materialTag" + i, -1);

                for (uint j = (uint) this.staticFilterObjects; j < filterArray.getCount(); j++)
                    {
                    if (materialTag == ((SimObject) ((SimSet) filterArray.getObject(j)).getObject(0))["filter"])
                        {
                        int count =
                            Util.getWord(
                                ((GuiCheckBoxCtrl)((SimSet)filterArray.getObject(j)).getObject(0)).getText(), 2)
                                .AsInt();
                        count--;
                            ((GuiCheckBoxCtrl) ((SimSet) filterArray.getObject(j)).getObject(0)).setText(materialTag +
                                                                                                         " ( " + count +
                                                                                                         " )");
                        }
                    }
                }


            UnlistedMaterials.add("unlistedMaterials", materialName);

            if (materialName.getFilename() != "" &&
                materialName.getFilename() != "tools/gui/MaterialSelector.ed.gui" &&
                materialName.getFilename() != "tools/materialEditor/scripts/materialEditor.ed.cs")
                {
                MaterialSelectorPerMan.removeObjectFromFile(materialName);
                MaterialSelectorPerMan.saveDirty();
                }

            this.preloadFilter();
            //MaterialSelector.selectMaterial( "WarningMaterial" );
            }

        [ConsoleInteraction]
        public void switchStaticFilters(string staticFilter)
            {
            GuiCheckBoxCtrl MaterialFilterAllArrayCheckbox = "MaterialFilterAllArrayCheckbox";
            GuiCheckBoxCtrl MaterialFilterMappedArrayCheckbox = "MaterialFilterMappedArrayCheckbox";
            GuiCheckBoxCtrl MaterialFilterUnmappedArrayCheckbox = "MaterialFilterUnmappedArrayCheckbox";

            switch (staticFilter)
                {
                    case "MaterialFilterAllArray":
                        MaterialFilterAllArrayCheckbox.setStateOn(true);
                        MaterialFilterMappedArrayCheckbox.setStateOn(false);
                        MaterialFilterUnmappedArrayCheckbox.setStateOn(false);
                        break;
                    case "MaterialFilterMappedArray":
                        MaterialFilterMappedArrayCheckbox.setStateOn(true);
                        MaterialFilterAllArrayCheckbox.setStateOn(false);
                        MaterialFilterUnmappedArrayCheckbox.setStateOn(false);
                        break;
                    case "MaterialFilterUnmappedArray":
                        MaterialFilterUnmappedArrayCheckbox.setStateOn(true);
                        MaterialFilterAllArrayCheckbox.setStateOn(false);
                        MaterialFilterMappedArrayCheckbox.setStateOn(false);
                        break;
                }

            // kinda goofy were passing a class variable... we can't do an empty check right now
            // on load filter because we actually pass "" as a filter...
            this.loadFilter(this.currentFilter, staticFilter);
            }

        // Tagging Functionality

        [ConsoleInteraction]
        public string getTagField(SimObject material, string tag)
            {
            string tagField = "";
            for (int i = 0; material.getFieldValue("materialTag" + i, -1) != ""; i++)
                {
                string loopTag = material.getFieldValue("materialTag" + i, -1);
                if (tag == loopTag)
                    {
                    tagField = "materialTag" + i;
                    break;
                    }
                }

            return tagField;
            }

        [ConsoleInteraction]
        public string getLastTagField(SimObject material)
            {
            string tagField = "";

            for (int i = 0; material.getFieldValue("materialTag" + i, -1) != ""; i++)
                {
                tagField = "materialTag" + i;
                }

            return tagField;
            }

        [ConsoleInteraction]
        public string getLastValidTagField(SimObject material, string invalidTag)
            {
            string tag, tagField = "";

            for (int i = 0; material.getFieldValue("materialTag" + i, -1) != ""; i++)
                {
                tag = material.getFieldValue("materialTag" + i, -1);
                // Can't equal our invalid tag
                if (tag == invalidTag)
                    continue;

                // Set our last found tag
                tagField = "materialTag" + i;
                }

            return tagField;
            }

        // Preview Page Navigation

        [ConsoleInteraction]
        public void firstPage()
            {
            this.currentPreviewPage = 0;
            this.loadFilter(this.currentFilter, this.currentStaticFilter);
            }

        [ConsoleInteraction]
        public void previousPage()
            {
            this.currentPreviewPage--;
            if (this.currentPreviewPage < 0)
                this.currentPreviewPage = 0;

            this.loadFilter(this.currentFilter, this.currentStaticFilter);
            }

        [ConsoleInteraction]
        public void nextPage()
            {
            this.currentPreviewPage++;
            if (this.currentPreviewPage >= this.totalPages)
                this.currentPreviewPage = this.totalPages - 1;
            if (this.currentPreviewPage < 0)
                this.currentPreviewPage = 0;

            this.loadFilter(this.currentFilter, this.currentStaticFilter);
            }

        [ConsoleInteraction]
        public void lastPage()
            {
            this.currentPreviewPage = this.totalPages - 1;
            if (this.currentPreviewPage < 0)
                this.currentPreviewPage = 0;

            this.loadFilter(this.currentFilter, this.currentStaticFilter);
            }

        [ConsoleInteraction]
        public void selectPage(int page)
            {
            this.currentPreviewPage = page;
            this.loadFilter(this.currentFilter, this.currentStaticFilter);
            }

        [ConsoleInteraction]
        public void thumbnailCountUpdate()
            {
            GuiPopUpMenuCtrlEx materialPreviewCountPopup = this.FOT("materialPreviewCountPopup");

            iGlobal["$Pref::MaterialSelector::ThumbnailCountIndex"] = materialPreviewCountPopup.getSelected();
            this.loadFilter(this.currentFilter, this.currentStaticFilter);
            }

        [ConsoleInteraction]
        public void buildPagesButtons(int currentPage, int totalPages)
            {
            GuiStackControl materialPreviewPagesStack = this.FOT("materialPreviewPagesStack");

            bool startbracket, endbracket;
            int start, end;
            // We don't want any more than 8 pages at a time.
            if (totalPages > 8)
                {
                // We attempt to display up to 2 pages before the current page
                start = currentPage - 2;
                if (start <= 0)
                    {
                    start = 0;
                    startbracket = false;
                    }
                else
                    {
                    startbracket = true;
                    }

                if ((totalPages - start) < 8)
                    {
                    // Move start closer to the beginning to maintain 8 pages
                    start = totalPages - 8;
                    }

                end = start + 8;
                if (end >= totalPages)
                    {
                    end = totalPages;
                    endbracket = false;
                    }
                else
                    {
                    endbracket = true;
                    }
                }
            else
                {
                start = 0;
                end = totalPages;
                startbracket = false;
                endbracket = false;
                }

            if (startbracket)
                {
                #region GuiTextCtrl ()        oc_Newobject79

                ObjectCreator oc_Newobject79 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject79["profile"] = "ToolsGuiTextCenterProfile";
                oc_Newobject79["HorizSizing"] = "right";
                oc_Newobject79["VertSizing"] = "bottom";
                oc_Newobject79["position"] = "0 2";
                oc_Newobject79["extent"] = "14 16";
                oc_Newobject79["MinExtent"] = "8 8";
                oc_Newobject79["text"] = "...";

                #endregion

                GuiTextCtrl control = oc_Newobject79.Create();
                materialPreviewPagesStack.add(control);
                }

            for (int i = start; i < end; i++)
                {
                GuiControl control = "";
                if (i != currentPage)
                    {
                    #region GuiButtonCtrl ()        oc_Newobject80

                    ObjectCreator oc_Newobject80 = new ObjectCreator("GuiButtonCtrl", "");
                    oc_Newobject80["canSaveDynamicFields"] = "0";
                    oc_Newobject80["Enabled"] = "1";
                    oc_Newobject80["isContainer"] = "0";
                    oc_Newobject80["Profile"] = "ToolsGuiTextCenterProfile";
                    oc_Newobject80["HorizSizing"] = "right";
                    oc_Newobject80["VertSizing"] = "bottom";
                    oc_Newobject80["Position"] = "0 0";
                    oc_Newobject80["Extent"] = "14 16";
                    oc_Newobject80["MinExtent"] = "8 8";
                    oc_Newobject80["canSave"] = "1";
                    oc_Newobject80["isDecoy"] = "0";
                    oc_Newobject80["Visible"] = "1";
                    oc_Newobject80["Command"] = "MaterialSelector.schedule(0, selectPage, " + i + ");";
                    oc_Newobject80["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject80["hovertime"] = "1000";
                    oc_Newobject80["text"] = i + 1;
                    oc_Newobject80["groupNum"] = "-1";
                    oc_Newobject80["buttonType"] = "PushButton";
                    oc_Newobject80["useMouseEvents"] = "1";

                    #endregion

                    control = oc_Newobject80.Create();
                    }
                else
                    {
                    #region GuiTextCtrl ()        oc_Newobject81

                    ObjectCreator oc_Newobject81 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject81["profile"] = "ToolsGuiTextBoldCenterProfile";
                    oc_Newobject81["HorizSizing"] = "right";
                    oc_Newobject81["VertSizing"] = "bottom";
                    oc_Newobject81["position"] = "0 2";
                    oc_Newobject81["extent"] = "14 16";
                    oc_Newobject81["MinExtent"] = "8 8";
                    oc_Newobject81["text"] = i + 1;

                    #endregion

                    control = oc_Newobject81.Create();
                    }

                materialPreviewPagesStack.add(control);
                }

            if (endbracket)
                {
                #region GuiTextCtrl ()        oc_Newobject82

                ObjectCreator oc_Newobject82 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject82["profile"] = "ToolsGuiTextCenterProfile";
                oc_Newobject82["HorizSizing"] = "right";
                oc_Newobject82["VertSizing"] = "bottom";
                oc_Newobject82["position"] = "0 2";
                oc_Newobject82["extent"] = "14 16";
                oc_Newobject82["MinExtent"] = "8 8";
                oc_Newobject82["text"] = "...";

                #endregion

                GuiTextCtrl control = oc_Newobject82.Create();
                materialPreviewPagesStack.add(control);
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MaterialSelector ts, string simobjectid)
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
        public static bool operator !=(MaterialSelector ts, string simobjectid)
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
        public static implicit operator string(MaterialSelector ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MaterialSelector(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MaterialSelector) Omni.self.getSimObject(simobjectid, typeof (MaterialSelector));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MaterialSelector ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MaterialSelector(int simobjectid)
            {
            return (MaterialSelector) Omni.self.getSimObject((uint) simobjectid, typeof (MaterialSelector));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MaterialSelector ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MaterialSelector(uint simobjectid)
            {
            return (MaterialSelector) Omni.self.getSimObject(simobjectid, typeof (MaterialSelector));
            }

        #endregion
        }
    }