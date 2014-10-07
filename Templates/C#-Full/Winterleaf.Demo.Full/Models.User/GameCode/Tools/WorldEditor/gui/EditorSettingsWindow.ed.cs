using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class EditorSettingsWindow
        {
        [ConsoleInteraction(true, "EditorSettingsWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl (EditorSettingsWindow,EditorGuiGroup)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiControl", "EditorSettingsWindow,EditorGuiGroup");
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "800 600";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "1";

            #region GuiWindowCollapseCtrl (ESettingsWindow)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCollapseCtrl", "ESettingsWindow",
                typeof (ESettingsWindow));
            oc_Newobject4["AllowPopWindow"] = "1";
            oc_Newobject4["internalName"] = "EditorSettingsWindow";
            oc_Newobject4["resizeWidth"] = "0";
            oc_Newobject4["resizeHeight"] = "1";
            oc_Newobject4["canMove"] = "1";
            oc_Newobject4["canClose"] = "1";
            oc_Newobject4["canMinimize"] = "0";
            oc_Newobject4["canMaximize"] = "0";
            oc_Newobject4["minSize"] = "50 50";
            oc_Newobject4["EdgeSnap"] = "1";
            oc_Newobject4["text"] = "Editor Settings";
            oc_Newobject4["closeCommand"] = "ESettingsWindow.hideDialog();";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "30 200";
            oc_Newobject4["Extent"] = "319 320";
            oc_Newobject4["MinExtent"] = "319 100";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiTabBookCtrl (ESettingsWindowTabBook)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTabBookCtrl", "ESettingsWindowTabBook");
            oc_Newobject1["TabPosition"] = "Top";
            oc_Newobject1["TabMargin"] = "7";
            oc_Newobject1["MinTabWidth"] = "64";
            oc_Newobject1["TabHeight"] = "0";
            oc_Newobject1["AllowReorder"] = "0";
            oc_Newobject1["FrontTabPadding"] = "0";
            oc_Newobject1["Docking"] = "Client";
            oc_Newobject1["Margin"] = "3 1 4 3";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTabBookNoBitmapProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "201 21";
            oc_Newobject1["Extent"] = "334 425";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiScrollCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject3["willFirstRespond"] = "1";
            oc_Newobject3["hScrollBar"] = "AlwaysOff";
            oc_Newobject3["vScrollBar"] = "dynamic";
            oc_Newobject3["lockHorizScroll"] = "0";
            oc_Newobject3["lockVertScroll"] = "0";
            oc_Newobject3["constantThumbHeight"] = "0";
            oc_Newobject3["childMargin"] = "0 0";
            oc_Newobject3["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject3["Docking"] = "Left";
            oc_Newobject3["Margin"] = "3 1 3 -1";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "1 21";
            oc_Newobject3["Extent"] = "100 425";
            oc_Newobject3["MinExtent"] = "100 50";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiTextListCtrl (ESettingsWindowList)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextListCtrl", "ESettingsWindowList",
                typeof (ESettingsWindow.ESettingsWindowList));
            oc_Newobject2["AllowMultipleSelections"] = "1";
            oc_Newobject2["fitParentWidth"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiListBoxProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "1 1";
            oc_Newobject2["Extent"] = "100 2";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject5.Create();
            }
        }
    }