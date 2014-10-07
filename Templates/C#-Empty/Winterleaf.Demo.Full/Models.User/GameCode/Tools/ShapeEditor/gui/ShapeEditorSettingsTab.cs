using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
    {
    public class ShapeEditorSettingsTab
        {
        [ConsoleInteraction(true, "ShapeEditorSettingsTab_initialize")]
        public static void initialize()
            {
            #region GuiControl (ShapeEditorSettingsTab,EditorGuiGroup)        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "ShapeEditorSettingsTab,EditorGuiGroup");
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["position"] = "0 0";
            oc_Newobject26["Extent"] = "800 600";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (EShapeEditorSettingsPage)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTabPageCtrl", "EShapeEditorSettingsPage");
            oc_Newobject25["fitBook"] = "1";
            oc_Newobject25["text"] = "Shape Editor";
            oc_Newobject25["maxLength"] = "1024";
            oc_Newobject25["Margin"] = "0 0 0 0";
            oc_Newobject25["Padding"] = "0 0 0 0";
            oc_Newobject25["AnchorTop"] = "1";
            oc_Newobject25["AnchorBottom"] = "0";
            oc_Newobject25["AnchorLeft"] = "1";
            oc_Newobject25["AnchorRight"] = "0";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject25["HorizSizing"] = "width";
            oc_Newobject25["VertSizing"] = "height";
            oc_Newobject25["position"] = "0 0";
            oc_Newobject25["Extent"] = "208 400";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject24["willFirstRespond"] = "1";
            oc_Newobject24["hScrollBar"] = "alwaysOff";
            oc_Newobject24["vScrollBar"] = "dynamic";
            oc_Newobject24["lockHorizScroll"] = "1";
            oc_Newobject24["lockVertScroll"] = "0";
            oc_Newobject24["constantThumbHeight"] = "0";
            oc_Newobject24["childMargin"] = "0 0";
            oc_Newobject24["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject24["Margin"] = "0 0 0 0";
            oc_Newobject24["Padding"] = "0 0 0 0";
            oc_Newobject24["AnchorTop"] = "1";
            oc_Newobject24["AnchorBottom"] = "0";
            oc_Newobject24["AnchorLeft"] = "1";
            oc_Newobject24["AnchorRight"] = "0";
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject24["HorizSizing"] = "width";
            oc_Newobject24["VertSizing"] = "height";
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["Extent"] = "208 400";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject23["StackingType"] = "Vertical";
            oc_Newobject23["HorizStacking"] = "Left to Right";
            oc_Newobject23["VertStacking"] = "Top to Bottom";
            oc_Newobject23["Padding"] = "0";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "1 1";
            oc_Newobject23["extent"] = "208 210";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["isDecoy"] = "0";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject14["Profile"] = "GuiRolloutProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "10 10";
            oc_Newobject14["extent"] = "208 95";
            oc_Newobject14["Caption"] = "Colors";
            oc_Newobject14["Margin"] = "0 3 0 0";
            oc_Newobject14["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject14["container"] = new ObjectCreator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject13["StackingType"] = "Vertical";
            oc_Newobject13["HorizStacking"] = "Left to Right";
            oc_Newobject13["VertStacking"] = "Top to Bottom";
            oc_Newobject13["Padding"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "0 0";
            oc_Newobject13["Extent"] = "208 0";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["isDecoy"] = "0";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["padding"] = "3";

            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColor));
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "5 10";
            oc_Newobject4["Extent"] = "208 18";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "1";
            oc_Newobject4["editorSettingsRead"] =
                "ShapeEdShapeView.sunDiffuse = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject4["editorSettingsValue"] = "ShapeEditor/SunDiffuseColor";
            oc_Newobject4["editorSettingsWrite"] = "ShapeEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Sun Diffuse:";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "0 1";
            oc_Newobject1["Extent"] = "70 16";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "80 0";
            oc_Newobject2["Extent"] = "104 18";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["internalName"] = "ColorEdit";
            oc_Newobject2["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiSwatchButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject3["color"] = "1 1 1 1";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["horizSizing"] = "left";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "188 2";
            oc_Newobject3["extent"] = "14 14";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["internalName"] = "ColorButton";
            oc_Newobject3["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject13["#Newobject4"] = oc_Newobject4;

            #region GuiControl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColor));
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "5 30";
            oc_Newobject8["Extent"] = "208 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "1";
            oc_Newobject8["editorSettingsRead"] =
                "ShapeEdShapeView.sunAmbient = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject8["editorSettingsValue"] = "ShapeEditor/SunAmbientColor";
            oc_Newobject8["editorSettingsWrite"] = "ShapeEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Sun Ambient:";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 1";
            oc_Newobject5["Extent"] = "70 16";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject8["#Newobject5"] = oc_Newobject5;

            #region GuiTextEditCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextEditCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject6["historySize"] = "0";
            oc_Newobject6["password"] = "0";
            oc_Newobject6["tabComplete"] = "0";
            oc_Newobject6["sinkAllKeyEvents"] = "0";
            oc_Newobject6["passwordMask"] = "*";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "80 0";
            oc_Newobject6["Extent"] = "104 18";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["internalName"] = "ColorEdit";
            oc_Newobject6["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject8["#Newobject6"] = oc_Newobject6;

            #region GuiSwatchButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject7["color"] = "1 1 1 1";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["horizSizing"] = "left";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "188 2";
            oc_Newobject7["extent"] = "14 14";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["internalName"] = "ColorButton";
            oc_Newobject7["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject13["#Newobject8"] = oc_Newobject8;

            #region GuiControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColor));
            
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "5 50";
            oc_Newobject12["Extent"] = "208 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "1";
            oc_Newobject12["editorSettingsRead"] =
                "ShapeEdPreviewGui-->previewBackground.color = ColorIntToFloat(EditorSettings.value(%this.editorSettingsValue));";
            oc_Newobject12["editorSettingsValue"] = "ShapeEditor/BackgroundColor";
            oc_Newobject12["editorSettingsWrite"] = "ShapeEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["text"] = "Background:";
            oc_Newobject9["maxLength"] = "1024";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 2";
            oc_Newobject9["Extent"] = "70 14";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiTextEditCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextEditCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject10["historySize"] = "0";
            oc_Newobject10["password"] = "0";
            oc_Newobject10["tabComplete"] = "0";
            oc_Newobject10["sinkAllKeyEvents"] = "0";
            oc_Newobject10["passwordMask"] = "*";
            oc_Newobject10["maxLength"] = "1024";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "80 0";
            oc_Newobject10["Extent"] = "104 18";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["internalName"] = "ColorEdit";
            oc_Newobject10["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiSwatchButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowColorButton));

            oc_Newobject11["color"] = "1 1 1 1";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["horizSizing"] = "left";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "188 2";
            oc_Newobject11["extent"] = "14 14";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["internalName"] = "ColorButton";
            oc_Newobject11["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject23["#Newobject14"] = oc_Newobject14;

            #region GuiRolloutCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject22["Profile"] = "GuiRolloutProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "10 10";
            oc_Newobject22["extent"] = "208 95";
            oc_Newobject22["Caption"] = "Grid";
            oc_Newobject22["Margin"] = "0 3 0 0";
            oc_Newobject22["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject22["container"] = new ObjectCreator.StringNoQuote("true");

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
            oc_Newobject21["position"] = "0 0";
            oc_Newobject21["Extent"] = "208 0";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["isDecoy"] = "0";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["padding"] = "3";

            #region GuiControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "");
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["text"] = "Grid Size:";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "5 1";
            oc_Newobject15["Extent"] = "70 16";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiTextEditCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextEditCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject16["historySize"] = "0";
            oc_Newobject16["password"] = "0";
            oc_Newobject16["tabComplete"] = "0";
            oc_Newobject16["sinkAllKeyEvents"] = "0";
            oc_Newobject16["passwordMask"] = "*";
            oc_Newobject16["maxLength"] = "1024";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "81 0";
            oc_Newobject16["Extent"] = "121 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "1";
            oc_Newobject16["editorSettingsRead"] =
                "ShapeEdShapeView.gridSize = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject16["editorSettingsValue"] = "ShapeEditor/GridSize";
            oc_Newobject16["editorSettingsWrite"] = "ShapeEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject21["#Newobject17"] = oc_Newobject17;

            #region GuiControl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiControl", "");
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject18["text"] = "Grid Dimension:";
            oc_Newobject18["maxLength"] = "1024";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "5 1";
            oc_Newobject18["Extent"] = "70 16";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject18"] = oc_Newobject18;

            #region GuiTextEditCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextEditCtrl", "", typeof(WorldEditor.gui.CodeBehind.ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject19["historySize"] = "0";
            oc_Newobject19["password"] = "0";
            oc_Newobject19["tabComplete"] = "0";
            oc_Newobject19["sinkAllKeyEvents"] = "0";
            oc_Newobject19["passwordMask"] = "*";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["Margin"] = "0 0 0 0";
            oc_Newobject19["Padding"] = "0 0 0 0";
            oc_Newobject19["AnchorTop"] = "1";
            oc_Newobject19["AnchorBottom"] = "0";
            oc_Newobject19["AnchorLeft"] = "1";
            oc_Newobject19["AnchorRight"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "81 0";
            oc_Newobject19["Extent"] = "121 18";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["canSaveDynamicFields"] = "1";
            oc_Newobject19["editorSettingsRead"] =
                "ShapeEdShapeView.gridDimension = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject19["editorSettingsValue"] = "ShapeEditor/GridDimension";
            oc_Newobject19["editorSettingsWrite"] = "ShapeEditorPlugin.writeSettings();";

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

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject26.Create();
            }
        }
    }