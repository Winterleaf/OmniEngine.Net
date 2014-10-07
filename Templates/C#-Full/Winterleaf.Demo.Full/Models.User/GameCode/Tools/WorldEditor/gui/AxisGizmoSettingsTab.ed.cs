using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class AxisGizmoSettingsTab
        {
        [ConsoleInteraction(true, "AxisGizmoSettingsTab_initialize")]
        public static void initialize()
            {
            #region GuiControl (AxisGizmoSettingsTab,EditorGuiGroup)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiControl", "AxisGizmoSettingsTab,EditorGuiGroup");
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["extent"] = "1024 768";
            oc_Newobject24["minExtent"] = "8 2";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["active"] = "1";
            oc_Newobject24["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (EAxisGizmoSettingsPage)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTabPageCtrl", "EAxisGizmoSettingsPage");
            oc_Newobject23["fitBook"] = "1";
            oc_Newobject23["text"] = "Axis Gizmo";
            oc_Newobject23["maxLength"] = "1024";
            oc_Newobject23["margin"] = "0 0 0 0";
            oc_Newobject23["padding"] = "0 0 0 0";
            oc_Newobject23["anchorTop"] = "1";
            oc_Newobject23["anchorBottom"] = "0";
            oc_Newobject23["anchorLeft"] = "1";
            oc_Newobject23["anchorRight"] = "0";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject23["horizSizing"] = "width";
            oc_Newobject23["vertSizing"] = "height";
            oc_Newobject23["position"] = "0 0";
            oc_Newobject23["extent"] = "208 568";
            oc_Newobject23["minExtent"] = "8 2";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["active"] = "1";
            oc_Newobject23["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject22["willFirstRespond"] = "1";
            oc_Newobject22["hScrollBar"] = "alwaysOff";
            oc_Newobject22["vScrollBar"] = "dynamic";
            oc_Newobject22["lockHorizScroll"] = "1";
            oc_Newobject22["lockVertScroll"] = "0";
            oc_Newobject22["constantThumbHeight"] = "0";
            oc_Newobject22["childMargin"] = "0 0";
            oc_Newobject22["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject22["margin"] = "0 0 0 0";
            oc_Newobject22["padding"] = "0 0 0 0";
            oc_Newobject22["anchorTop"] = "1";
            oc_Newobject22["anchorBottom"] = "0";
            oc_Newobject22["anchorLeft"] = "1";
            oc_Newobject22["anchorRight"] = "0";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject22["horizSizing"] = "width";
            oc_Newobject22["vertSizing"] = "height";
            oc_Newobject22["position"] = "0 0";
            oc_Newobject22["extent"] = "208 568";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject21["StackingType"] = "Vertical";
            oc_Newobject21["HorizStacking"] = "Left to Right";
            oc_Newobject21["VertStacking"] = "Top to Bottom";
            oc_Newobject21["Padding"] = "0";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "1 1";
            oc_Newobject21["extent"] = "208 210";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["isDecoy"] = "0";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject9["Profile"] = "GuiRolloutProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "10 10";
            oc_Newobject9["extent"] = "208 95";
            oc_Newobject9["Caption"] = "Gizmo";
            oc_Newobject9["Margin"] = "0 0 0 -3";
            oc_Newobject9["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject9["container"] = new ObjectCreator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject8["StackingType"] = "Vertical";
            oc_Newobject8["HorizStacking"] = "Left to Right";
            oc_Newobject8["VertStacking"] = "Top to Bottom";
            oc_Newobject8["Padding"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "208 0";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiContainer", "");
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "-1 0";
            oc_Newobject7["Extent"] = "208 79";
            oc_Newobject7["Docking"] = "none";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Rotate Scalar:";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 6";
            oc_Newobject1["extent"] = "70 14";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["text"] = "0.8";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject2["horizSizing"] = "width";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "81 5";
            oc_Newobject2["extent"] = "121 18";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "1";
            //oc_Newobject2["class"] = "ESettingsWindowTextEdit";
            oc_Newobject2["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject2["editorSettingsValue"] = "AxisGizmo/mouseRotateScalar";
            oc_Newobject2["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Scale Scalar:";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "5 26";
            oc_Newobject3["extent"] = "70 14";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["password"] = "0";
            oc_Newobject4["tabComplete"] = "0";
            oc_Newobject4["sinkAllKeyEvents"] = "0";
            oc_Newobject4["passwordMask"] = "*";
            oc_Newobject4["text"] = "0.8";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "81 24";
            oc_Newobject4["extent"] = "121 17";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "1";
            //oc_Newobject4["class"] = "ESettingsWindowTextEdit";
            oc_Newobject4["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject4["editorSettingsValue"] = "AxisGizmo/mouseScaleScalar";
            oc_Newobject4["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiCheckBoxCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject5["useInactiveState"] = "0";
            oc_Newobject5["text"] = "Render When Manipulated";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "ToggleButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "5 44";
            oc_Newobject5["extent"] = "140 14";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "1";
            //oc_Newobject5["class"] = "ESettingsWindowCheckbox";
            oc_Newobject5["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject5["editorSettingsValue"] = "AxisGizmo/renderWhenUsed";
            oc_Newobject5["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiCheckBoxCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject6["useInactiveState"] = "0";
            oc_Newobject6["text"] = "Render Tool Text";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "ToggleButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "5 61";
            oc_Newobject6["extent"] = "140 14";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "1";
            // oc_Newobject6["class"] = "ESettingsWindowCheckbox";
            oc_Newobject6["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject6["editorSettingsValue"] = "AxisGizmo/renderInfoText";
            oc_Newobject6["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject21["#Newobject9"] = oc_Newobject9;

            #region GuiRolloutCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject20["Profile"] = "GuiRolloutProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "10 10";
            oc_Newobject20["extent"] = "208 95";
            oc_Newobject20["Caption"] = "Grid";
            oc_Newobject20["Margin"] = "0 0 0 -3";
            oc_Newobject20["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject20["container"] = new ObjectCreator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject19["StackingType"] = "Vertical";
            oc_Newobject19["HorizStacking"] = "Left to Right";
            oc_Newobject19["VertStacking"] = "Top to Bottom";
            oc_Newobject19["Padding"] = "0";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "0 0";
            oc_Newobject19["Extent"] = "208 0";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["isDecoy"] = "0";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiContainer", "");
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "-1 0";
            oc_Newobject18["Extent"] = "208 82";
            oc_Newobject18["Docking"] = "none";

            #region GuiCheckBoxCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject10["useInactiveState"] = "0";
            oc_Newobject10["text"] = "Render Plane";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "ToggleButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "5 4";
            oc_Newobject10["extent"] = "140 14";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "1";
            // oc_Newobject10["class"] = "ESettingsWindowCheckbox";
            oc_Newobject10["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject10["editorSettingsValue"] = "AxisGizmo/Grid/renderPlane";
            oc_Newobject10["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject18["#Newobject10"] = oc_Newobject10;

            #region GuiCheckBoxCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject11["useInactiveState"] = "0";
            oc_Newobject11["text"] = "Render Plane Hashes";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "ToggleButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "5 21";
            oc_Newobject11["extent"] = "140 14";
            oc_Newobject11["minExtent"] = "8 2";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "1";
            //oc_Newobject11["class"] = "ESettingsWindowCheckbox";
            oc_Newobject11["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject11["editorSettingsValue"] = "AxisGizmo/Grid/renderPlaneHashes";
            oc_Newobject11["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject18["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["text"] = "Plane Size:";
            oc_Newobject12["maxLength"] = "1024";
            oc_Newobject12["margin"] = "0 0 0 0";
            oc_Newobject12["padding"] = "0 0 0 0";
            oc_Newobject12["anchorTop"] = "1";
            oc_Newobject12["anchorBottom"] = "0";
            oc_Newobject12["anchorLeft"] = "1";
            oc_Newobject12["anchorRight"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "5 40";
            oc_Newobject12["extent"] = "70 14";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject18["#Newobject12"] = oc_Newobject12;

            #region GuiTextEditCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject13["historySize"] = "0";
            oc_Newobject13["password"] = "0";
            oc_Newobject13["tabComplete"] = "0";
            oc_Newobject13["sinkAllKeyEvents"] = "0";
            oc_Newobject13["passwordMask"] = "*";
            oc_Newobject13["text"] = "500";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["margin"] = "0 0 0 0";
            oc_Newobject13["padding"] = "0 0 0 0";
            oc_Newobject13["anchorTop"] = "1";
            oc_Newobject13["anchorBottom"] = "0";
            oc_Newobject13["anchorLeft"] = "1";
            oc_Newobject13["anchorRight"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject13["horizSizing"] = "width";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["position"] = "81 38";
            oc_Newobject13["extent"] = "121 17";
            oc_Newobject13["minExtent"] = "8 2";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "1";
            //oc_Newobject13["class"] = "ESettingsWindowTextEdit";
            oc_Newobject13["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject13["editorSettingsValue"] = "AxisGizmo/Grid/planeDim";
            oc_Newobject13["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject18["#Newobject13"] = oc_Newobject13;

            #region GuiControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "",
                typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["horizSizing"] = "width";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["position"] = "5 58";
            oc_Newobject17["extent"] = "208 18";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "1";
            //oc_Newobject17["class"] = "ESettingsWindowColor";
            oc_Newobject17["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject17["editorSettingsValue"] = "AxisGizmo/Grid/gridColor";
            oc_Newobject17["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["text"] = "Plane Color:";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["margin"] = "0 0 0 0";
            oc_Newobject14["padding"] = "0 0 0 0";
            oc_Newobject14["anchorTop"] = "1";
            oc_Newobject14["anchorBottom"] = "0";
            oc_Newobject14["anchorLeft"] = "1";
            oc_Newobject14["anchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["position"] = "0 2";
            oc_Newobject14["extent"] = "70 14";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject17["#Newobject14"] = oc_Newobject14;

            #region GuiTextEditCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject15["historySize"] = "0";
            oc_Newobject15["password"] = "0";
            oc_Newobject15["tabComplete"] = "0";
            oc_Newobject15["sinkAllKeyEvents"] = "0";
            oc_Newobject15["passwordMask"] = "*";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["margin"] = "0 0 0 0";
            oc_Newobject15["padding"] = "0 0 0 0";
            oc_Newobject15["anchorTop"] = "1";
            oc_Newobject15["anchorBottom"] = "0";
            oc_Newobject15["anchorLeft"] = "1";
            oc_Newobject15["anchorRight"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject15["horizSizing"] = "width";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["position"] = "76 0";
            oc_Newobject15["extent"] = "104 18";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["internalName"] = "ColorEdit";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "1";
            //oc_Newobject15["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiSwatchButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiSwatchButtonCtrl", "",
                typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject16["color"] = "0 0 0 0";
            oc_Newobject16["groupNum"] = "-1";
            oc_Newobject16["buttonType"] = "PushButton";
            oc_Newobject16["useMouseEvents"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["horizSizing"] = "left";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["position"] = "184 2";
            oc_Newobject16["extent"] = "14 14";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["internalName"] = "ColorButton";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "1";
            // oc_Newobject16["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject24.Create();
            }
        }
    }