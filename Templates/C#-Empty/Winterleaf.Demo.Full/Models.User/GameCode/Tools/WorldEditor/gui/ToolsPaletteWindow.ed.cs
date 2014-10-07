using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class ToolsPaletteWindow
        {
        [ConsoleInteraction(true, "ToolsPaletteWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "1024 768";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";

            #region GuiWindowCtrl (EWToolsPaletteWindow)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiWindowCtrl", "EWToolsPaletteWindow",
                typeof (EWToolsPaletteWindow));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "ToolsPaletteWindow";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiToolbarWindowProfile";
            oc_Newobject2["HorizSizing"] = "windowRelative";
            oc_Newobject2["VertSizing"] = "windowRelative";
            oc_Newobject2["Extent"] = "36 24";
            oc_Newobject2["MinExtent"] = "36 24";
            oc_Newobject2["Position"] = "-1 63";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "4 4 4 4";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["resizeWidth"] = "0";
            oc_Newobject2["resizeHeight"] = "0";
            oc_Newobject2["canMove"] = "1";
            oc_Newobject2["canClose"] = "0";
            oc_Newobject2["canMinimize"] = "0";
            oc_Newobject2["canMaximize"] = "0";
            oc_Newobject2["minSize"] = "50 50";
            oc_Newobject2["EdgeSnap"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["text"] = "";
            oc_Newobject2["class"] = "EWToolsPaletteWindowClass";

            #region GuiDynamicCtrlArrayControl (ToolsPaletteArray)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiDynamicCtrlArrayControl", "ToolsPaletteArray");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 15";
            oc_Newobject1["Extent"] = "35 514";
            oc_Newobject1["MinExtent"] = "35 514";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["colCount"] = "1";
            oc_Newobject1["colSize"] = "26";
            oc_Newobject1["RowSize"] = "22";
            oc_Newobject1["rowSpacing"] = "3";
            oc_Newobject1["colSpacing"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject3.Create();
            }
        }
    }