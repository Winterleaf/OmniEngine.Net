using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class ToolsToolbar
        {
        [ConsoleInteraction(true, "ToolsToolbar_initialize")]
        public static void initialize()
            {
            #region GuiContainer (EWToolsToolbar)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiContainer", "EWToolsToolbar",
                typeof (EditorGui.EWToolsToolbar));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "0";
            oc_Newobject4["internalName"] = "ToolsToolbar";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "editorMenubarProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 31";
            oc_Newobject4["Extent"] = new ObjectCreator.StringNoQuote("(29 + 4) * 15 + 12 SPC \"33\"");
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isClosed"] = "0";
            oc_Newobject4["isDynamic"] = "0";

            #region GuiDynamicCtrlArrayControl (ToolsToolbarArray)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiDynamicCtrlArrayControl", "ToolsToolbarArray");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "4 3";
            oc_Newobject1["Extent"] = "290 32";
            oc_Newobject1["MinExtent"] = "1024 32";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["colCount"] = "1";
            oc_Newobject1["colSize"] = "29";
            oc_Newobject1["RowSize"] = "27";
            oc_Newobject1["rowSpacing"] = "2";
            oc_Newobject1["colSpacing"] = "4";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["internalName"] = "resizeArrow";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] =
                new ObjectCreator.StringNoQuote("getWord(EWToolsToolbar.Extent, 0) - 7 SPC \"0\"");
            oc_Newobject2["extent"] = "7 33";
            oc_Newobject2["MinExtent"] = "7 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "EWToolsToolbar.ToggleSize();";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Collapse Toolbar";
            oc_Newobject2["hovertime"] = "750";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["bitmap"] = "tools/gui/images/collapse-toolbar";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiDecoyCtrl (EWToolsToolbarDecoy)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiDecoyCtrl", "EWToolsToolbarDecoy", typeof(EditorGui.EWToolsToolbarDecoy));
            oc_Newobject3["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "1 1";
            oc_Newobject3["extent"] = "35 31";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "0";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["useMouseEvents"] = "1";
            oc_Newobject3["isDecoy"] = "1";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject4.Create();
            }
        }
    }