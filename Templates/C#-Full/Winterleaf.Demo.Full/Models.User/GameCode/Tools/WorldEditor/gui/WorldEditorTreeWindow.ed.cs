using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class WorldEditorTreeWindow
        {
        [ConsoleInteraction(true, "WorldEditorTreeWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "0 0";
            oc_Newobject26["Extent"] = "800 600";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (EWTreeWindow)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiWindowCollapseCtrl", "EWTreeWindow",
                typeof (EWTreeWindow));
            oc_Newobject25["AllowPopWindow"] = "1";
            oc_Newobject25["name"] = "EWTreeWindow";
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["internalName"] = "TreeWindow";
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject25["Position"] =
                new ObjectCreator.StringNoQuote(
                    "firstWord($pref::Video::mode) - 209         SPC getWord(EditorGuiToolbar.extent, 1) -1");
            oc_Newobject25["Extent"] = "210 324";
            oc_Newobject25["MinExtent"] = "210 140";
            oc_Newobject25["HorizSizing"] = "windowRelative";
            oc_Newobject25["VertSizing"] = "windowRelative";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["Margin"] = "8 8 8 8";
            oc_Newobject25["Padding"] = "0 0 0 0";
            oc_Newobject25["AnchorTop"] = "1";
            oc_Newobject25["AnchorBottom"] = "0";
            oc_Newobject25["AnchorLeft"] = "1";
            oc_Newobject25["AnchorRight"] = "0";
            oc_Newobject25["resizeWidth"] = "1";
            oc_Newobject25["resizeHeight"] = "1";
            oc_Newobject25["canMove"] = "1";
            oc_Newobject25["canClose"] = "0";
            oc_Newobject25["canMinimize"] = "0";
            oc_Newobject25["canMaximize"] = "0";
            oc_Newobject25["minSize"] = "50 50";
            oc_Newobject25["closeCommand"] = "EWTreeWindow.setVisible(false);";
            oc_Newobject25["EdgeSnap"] = "1";
            oc_Newobject25["text"] = "Scene Tree";

            #region GuiTabBookCtrl (EditorTreeTabBook)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTabBookCtrl", "EditorTreeTabBook",
                typeof (EditorTree.EditorTreeTabBook));
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["internalName"] = "EditorTree";
            oc_Newobject21["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "height";
            oc_Newobject21["position"] = "6 27";
            oc_Newobject21["Extent"] = "197 289";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["Margin"] = "3 2 3 3";
            oc_Newobject21["Docking"] = "client";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["TabPosition"] = "Top";
            oc_Newobject21["TabMargin"] = "0";
            oc_Newobject21["MinTabWidth"] = "64";

            #region GuiTabPageCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["position"] = "0 19";
            oc_Newobject5["Extent"] = "197 271";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Scene";
            oc_Newobject5["maxLength"] = "1024";

            #region GuiTextEditCtrl ( EditorTreeFilter )        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "EditorTreeFilter",
                typeof (treeViewFilterCtrls.GuiTreeViewFilterText));
            oc_Newobject1["position"] = "2 4";
            oc_Newobject1["extent"] = "175 18";
            oc_Newobject1["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "bottom";
            //oc_Newobject1["class"] = "GuiTreeViewFilterText";
            oc_Newobject1["treeView"] = new ObjectCreator.StringNoQuote("EditorTree");

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "",
                typeof (treeViewFilterCtrls.GuiTreeViewFilterClearButton));
            oc_Newobject2["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "180 5";
            oc_Newobject2["Extent"] = "17 17";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            //oc_Newobject2["class"] = "GuiTreeViewFilterClearButton";
            oc_Newobject2["textCtrl"] = new ObjectCreator.StringNoQuote("EditorTreeFilter");

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["Position"] = "0 25";
            oc_Newobject4["Extent"] = "197 246";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "dynamic";
            oc_Newobject4["vScrollBar"] = "dynamic";
            oc_Newobject4["lockHorizScroll"] = "false";
            oc_Newobject4["lockVertScroll"] = "false";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "0 0";

            #region GuiTreeViewCtrl (EditorTree)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTreeViewCtrl", "EditorTree", typeof (EditorTree));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "1 1";
            oc_Newobject3["Extent"] = "193 21";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["tabSize"] = "16";
            oc_Newobject3["textOffset"] = "2";
            oc_Newobject3["fullRowSelect"] = "0";
            oc_Newobject3["itemHeight"] = "21";
            oc_Newobject3["destroyTreeOnSleep"] = "1";
            oc_Newobject3["MouseDragging"] = "1";
            oc_Newobject3["MultipleSelections"] = "1";
            oc_Newobject3["DeleteObjectAllowed"] = "1";
            oc_Newobject3["DragToItemAllowed"] = "1";
            oc_Newobject3["showRoot"] = "1";
            oc_Newobject3["useInspectorTooltips"] = "1";
            oc_Newobject3["tooltipOnWidthOnly"] = "1";
            oc_Newobject3["showObjectIds"] = "0";
            oc_Newobject3["showClassNames"] = "0";
            oc_Newobject3["showObjectNames"] = "1";
            oc_Newobject3["showInternalNames"] = "1";
            oc_Newobject3["showClassNameForUnnamedObjects"] = "1";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject21["#Newobject5"] = oc_Newobject5;

            #region GuiTabPageCtrl (EWCreatorWindow)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTabPageCtrl", "EWCreatorWindow",
                typeof (Creator.EWCreatorWindow));
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["internalName"] = "CreatorWindow";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject20["HorizSizing"] = "width";
            oc_Newobject20["VertSizing"] = "height";
            oc_Newobject20["position"] = "0 19";
            oc_Newobject20["Extent"] = "208 274";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["text"] = "Library";
            oc_Newobject20["maxLength"] = "1024";

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "GuiInspectorProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "0 0";
            oc_Newobject6["Extent"] = "198 271";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "0";
            oc_Newobject6["Visible"] = "1";

            #endregion

            oc_Newobject20["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapBorderCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["Extent"] = "198 271";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "0";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";

            #endregion

            oc_Newobject20["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapBorderCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "0 25";
            oc_Newobject8["Extent"] = "198 246";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";

            #endregion

            oc_Newobject20["#Newobject8"] = oc_Newobject8;

            #region GuiContainer ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiContainer", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "height";
            oc_Newobject11["Position"] = "-4 47";
            oc_Newobject11["Extent"] = "206 228";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "4 4 4 4";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "EditorLightScrollProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "4 4";
            oc_Newobject10["Extent"] = "198 220";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Docking"] = "Client";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["willFirstRespond"] = "1";
            oc_Newobject10["hScrollBar"] = "dynamic";
            oc_Newobject10["vScrollBar"] = "alwaysOff";
            oc_Newobject10["lockHorizScroll"] = "false";
            oc_Newobject10["lockVertScroll"] = "true";
            oc_Newobject10["constantThumbHeight"] = "0";
            oc_Newobject10["childMargin"] = "0 0";

            #region GuiDynamicCtrlArrayControl (CreatorIconArray)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiDynamicCtrlArrayControl", "CreatorIconArray");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "height";
            oc_Newobject9["Position"] = "1 1";
            oc_Newobject9["Extent"] = "197 218";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["colCount"] = "20";
            oc_Newobject9["colSize"] = "64";
            oc_Newobject9["rowCount"] = "0";
            oc_Newobject9["RowSize"] = "32";
            oc_Newobject9["rowSpacing"] = "4";
            oc_Newobject9["colSpacing"] = "4";
            oc_Newobject9["frozen"] = "0";
            oc_Newobject9["autoCellSize"] = "1";
            oc_Newobject9["fillRowFirst"] = "0";
            oc_Newobject9["dynamicSize"] = "1";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject20["#Newobject11"] = oc_Newobject11;

            #region GuiControl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "-3 2";
            oc_Newobject19["Extent"] = "202 55";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (CreatorNavUpButton)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "CreatorNavUpButton");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "9 28";
            oc_Newobject12["Extent"] = "20 19";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "EWCreatorWindow.navigateUp();";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["groupNum"] = "0";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["Bitmap"] = "tools/gui/images/folderUp";
            oc_Newobject12["autoSize"] = "0";

            #endregion

            oc_Newobject19["#Newobject12"] = oc_Newobject12;

            #region GuiPopUpMenuCtrl (CreatorPopupMenu)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiPopUpMenuCtrl", "CreatorPopupMenu",
                typeof (Creator.CreatorPopupMenu));
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "32 28";
            oc_Newobject13["Extent"] = "163 18";
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
            oc_Newobject13["text"] = "Objects";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["maxPopupHeight"] = "200";
            oc_Newobject13["sbUsesNAColor"] = "0";
            oc_Newobject13["reverseTextList"] = "0";
            oc_Newobject13["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject19["#Newobject13"] = oc_Newobject13;

            #region GuiTabBookCtrl (CreatorTabBook)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTabBookCtrl", "CreatorTabBook",
                typeof (Creator.CreatorTabBook));
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject18["HorizSizing"] = "width";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "6 4";
            oc_Newobject18["Extent"] = "198 21";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Docking"] = "None";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["TabPosition"] = "Top";
            oc_Newobject18["TabMargin"] = "4";
            oc_Newobject18["MinTabWidth"] = "49";

            #region GuiTabPageCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "height";
            oc_Newobject14["Position"] = "0 0";
            oc_Newobject14["Extent"] = "0 0";
            oc_Newobject14["MinExtent"] = "0 0";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "0";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["text"] = "Scripted";
            oc_Newobject14["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject14"] = oc_Newobject14;

            #region GuiTabPageCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "height";
            oc_Newobject15["Position"] = "0 0";
            oc_Newobject15["Extent"] = "0 0";
            oc_Newobject15["MinExtent"] = "0 0";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "0";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["text"] = "Meshes";
            oc_Newobject15["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject15"] = oc_Newobject15;

            #region GuiTabPageCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "height";
            oc_Newobject16["Position"] = "0 0";
            oc_Newobject16["Extent"] = "0 0";
            oc_Newobject16["MinExtent"] = "0 0";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "Level";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject16"] = oc_Newobject16;

            #region GuiTabPageCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "height";
            oc_Newobject17["Position"] = "0 0";
            oc_Newobject17["Extent"] = "0 0";
            oc_Newobject17["MinExtent"] = "0 0";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["text"] = "Prefabs";
            oc_Newobject17["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject25["#Newobject21"] = oc_Newobject21;

            #region GuiBitmapButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["internalName"] = "LockSelection";
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject22["HorizSizing"] = "left";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "157 26";
            oc_Newobject22["Extent"] = "16 16";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["Command"] = "EWorldEditor.lockSelection(true); EditorTree.toggleLock();";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["ToolTip"] = "Lock Selection";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["bitmap"] = "tools/gui/images/lock";
            oc_Newobject22["buttonType"] = "ToggleButton";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["text"] = "";
            oc_Newobject22["useMouseEvents"] = "0";

            #endregion

            oc_Newobject25["#Newobject22"] = oc_Newobject22;

            #region GuiBitmapButtonCtrl (EWAddSimGroupButton)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapButtonCtrl", "EWAddSimGroupButton",
                typeof (EditorGui.EWAddSimGroupButton));
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["internalName"] = "AddSimGroup";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject23["HorizSizing"] = "left";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "173 26";
            oc_Newobject23["Extent"] = "16 16";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["ToolTip"] = "Add Sim Group";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["bitmap"] = "tools/gui/images/add-simgroup-btn";
            oc_Newobject23["buttonType"] = "PushButton";
            oc_Newobject23["groupNum"] = "-1";
            oc_Newobject23["text"] = "";
            oc_Newobject23["useMouseEvents"] = "0";
            oc_Newobject23["useModifiers"] = "1";

            #endregion

            oc_Newobject25["#Newobject23"] = oc_Newobject23;

            #region GuiBitmapButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["internalName"] = "DeleteSelection";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject24["HorizSizing"] = "left";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["Position"] = "189 26";
            oc_Newobject24["Extent"] = "16 16";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["Command"] = "EditorMenuEditDelete();";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["ToolTip"] = "Delete Selection";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["bitmap"] = "tools/gui/images/delete";
            oc_Newobject24["buttonType"] = "PushButton";
            oc_Newobject24["groupNum"] = "-1";
            oc_Newobject24["text"] = "";
            oc_Newobject24["useMouseEvents"] = "0";

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject26.Create();
            }
        }
    }