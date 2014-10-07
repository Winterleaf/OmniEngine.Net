using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class GeneralSettingsTab
        {
        [ConsoleInteraction(true, "GeneralSettingsTab_initialize")]
        public static void initialize()
            {
            #region GuiControl (GeneralSettingsTab,EditorGuiGroup)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "GeneralSettingsTab,EditorGuiGroup");
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["extent"] = "1024 768";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (EGeneralSettingsPage)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTabPageCtrl", "EGeneralSettingsPage");
            oc_Newobject8["fitBook"] = "1";
            oc_Newobject8["text"] = "General Settings";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["extent"] = "432 568";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["horizSizing"] = "width";
            oc_Newobject8["vertSizing"] = "height";
            oc_Newobject8["profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject7["willFirstRespond"] = "1";
            oc_Newobject7["hScrollBar"] = "alwaysOff";
            oc_Newobject7["vScrollBar"] = "dynamic";
            oc_Newobject7["lockHorizScroll"] = "1";
            oc_Newobject7["lockVertScroll"] = "0";
            oc_Newobject7["constantThumbHeight"] = "0";
            oc_Newobject7["childMargin"] = "0 0";
            oc_Newobject7["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject7["margin"] = "0 0 0 0";
            oc_Newobject7["padding"] = "0 0 0 0";
            oc_Newobject7["anchorTop"] = "1";
            oc_Newobject7["anchorBottom"] = "0";
            oc_Newobject7["anchorLeft"] = "1";
            oc_Newobject7["anchorRight"] = "0";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["extent"] = "432 568";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["horizSizing"] = "width";
            oc_Newobject7["vertSizing"] = "height";
            oc_Newobject7["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject6["stackingType"] = "Vertical";
            oc_Newobject6["horizStacking"] = "Left to Right";
            oc_Newobject6["vertStacking"] = "Top to Bottom";
            oc_Newobject6["padding"] = "0";
            oc_Newobject6["dynamicSize"] = "1";
            oc_Newobject6["changeChildSizeToFit"] = "1";
            oc_Newobject6["changeChildPosition"] = "1";
            oc_Newobject6["position"] = "1 1";
            oc_Newobject6["extent"] = "430 41";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["horizSizing"] = "width";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #region GuiRolloutCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject5["caption"] = "Paths";
            oc_Newobject5["margin"] = "0 3 0 0";
            oc_Newobject5["defaultHeight"] = "40";
            oc_Newobject5["expanded"] = "1";
            oc_Newobject5["clickCollapse"] = "1";
            oc_Newobject5["hideHeader"] = "0";
            oc_Newobject5["autoCollapseSiblings"] = "0";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["extent"] = "430 41";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiRolloutProfile";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject4["stackingType"] = "Vertical";
            oc_Newobject4["horizStacking"] = "Left to Right";
            oc_Newobject4["vertStacking"] = "Top to Bottom";
            oc_Newobject4["padding"] = "3";
            oc_Newobject4["dynamicSize"] = "1";
            oc_Newobject4["changeChildSizeToFit"] = "1";
            oc_Newobject4["changeChildPosition"] = "1";
            oc_Newobject4["position"] = "0 20";
            oc_Newobject4["extent"] = "430 18";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["extent"] = "430 18";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "New Level";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "5 1";
            oc_Newobject1["extent"] = "70 16";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["text"] = "tools/levels/BlankRoom.mis";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "81 0";
            oc_Newobject2["extent"] = "345 17";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["horizSizing"] = "width";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "1";
            //oc_Newobject2["class"] = "ESettingsWindowTextEdit";
            oc_Newobject2["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject2["editorSettingsValue"] = "WorldEditor/newLevelFile";
            oc_Newobject2["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
            }
        }
    }