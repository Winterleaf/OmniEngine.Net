using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui
    {
    [TypeConverter(typeof (MaterialEditorPreviewWindow))]
    public class MaterialEditorPreviewWindow : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction(true, "MaterialEditorPreviewWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiControl", "");
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["internalName"] = "MatEdPreviewWindowContainer";
            oc_Newobject45["Enabled"] = "1";
            oc_Newobject45["isContainer"] = "1";
            oc_Newobject45["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject45["HorizSizing"] = "width";
            oc_Newobject45["VertSizing"] = "height";
            oc_Newobject45["Position"] = "0 0";
            oc_Newobject45["Extent"] = "800 600";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (MaterialEditorPreviewWindow)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiWindowCollapseCtrl", "MaterialEditorPreviewWindow",
                typeof (MaterialEditorPreviewWindow));
            oc_Newobject10["AllowPopWindow"] = "1";
            oc_Newobject10["internalName"] = "MaterialEditorPreviewWindow";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject10["HorizSizing"] = "windowRelative";
            oc_Newobject10["VertSizing"] = "windowRelative";
            oc_Newobject10["Extent"] = "210 251 ";
            oc_Newobject10["MinExtent"] = "210 150";
            oc_Newobject10["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209          SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "4 4 4 4";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["resizeWidth"] = "1";
            oc_Newobject10["resizeHeight"] = "1";
            oc_Newobject10["canMove"] = "1";
            oc_Newobject10["canClose"] = "0";
            oc_Newobject10["canMinimize"] = "0";
            oc_Newobject10["canMaximize"] = "0";
            oc_Newobject10["closeCommand"] = "MaterialEditorPreviewWindow.setVisible(false);";
            oc_Newobject10["minSize"] = "50 50";
            oc_Newobject10["EdgeSnap"] = "1";
            oc_Newobject10["text"] = "Material Preview";

            #region GuiContainer (matEd_previewPanel)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiContainer", "matEd_previewPanel");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["position"] = "4 45";
            oc_Newobject4["Extent"] = "202 202";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Docking"] = "Client";
            oc_Newobject4["Margin"] = "24 1 3 3 ";

            #region GuiSwatchButtonCtrl (matEd_previewBackground)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiSwatchButtonCtrl", "matEd_previewBackground");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["position"] = "-1 -1";
            oc_Newobject1["Extent"] = "204 204";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["color"] = "0 0 0 .8";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiContainer ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiContainer", "");
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "-1 -1";
            oc_Newobject2["Extent"] = "204 204";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiMaterialPreview (matEd_previewObjectView)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiMaterialPreview", "matEd_previewObjectView");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["position"] = "1 1";
            oc_Newobject3["Extent"] = "199 199";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["cameraZRot"] = "0";
            oc_Newobject3["forceFOV"] = "0";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject10["#Newobject4"] = oc_Newobject4;

            #region GuiPopUpMenuCtrl (matEd_quickPreview_Popup)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiPopUpMenuCtrl", "matEd_quickPreview_Popup");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "4 24";
            oc_Newobject5["Extent"] = "67 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "MaterialEditorGui.updatePreviewObject();";
            oc_Newobject5["ToolTip"] = "Changes the Preview Mesh";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Sphere";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["maxPopupHeight"] = "200";
            oc_Newobject5["sbUsesNAColor"] = "0";
            oc_Newobject5["reverseTextList"] = "0";
            oc_Newobject5["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiSwatchButtonCtrl (MaterialPreviewBackgroundPicker)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiSwatchButtonCtrl", "MaterialPreviewBackgroundPicker");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject6["HorizSizing"] = "left";
            oc_Newobject6["VertSizing"] = "top";
            oc_Newobject6["position"] = "189 229";
            oc_Newobject6["Extent"] = "14 14";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] =
                "getColorF($thisControl.color, \\\"MaterialEditorGui.updatePreviewBackground\\\");";
            oc_Newobject6["color"] = "0 0 0 .8";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiSwatchButtonCtrl (matEd_ambientLightColorPicker)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiSwatchButtonCtrl", "matEd_ambientLightColorPicker");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["color"] = "1 1 1 1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "81 28";
            oc_Newobject7["Extent"] = "14 14";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "getColorF($ThisControl.color, \\\"MaterialEditorGui.updateAmbientColor\\\");";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["ToolTip"] = "Change Ambient Light Color";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiSwatchButtonCtrl (matEd_lightColorPicker)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiSwatchButtonCtrl", "matEd_lightColorPicker");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["color"] = "1 1 1 1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "75 23";
            oc_Newobject8["Extent"] = "14 14";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "getColorF($ThisControl.color, \\\"MaterialEditorGui.updateLightColor\\\");";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["ToolTip"] = "Change Normal Light Color";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiCheckboxCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiCheckboxCtrl", "");
            oc_Newobject9["position"] = "108 25";
            oc_Newobject9["Extent"] = "98 18";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject9["Variable"] = "MaterialEditorGui.livePreview";
            oc_Newobject9["Command"] = "MaterialEditorGui.updateLivePreview($ThisControl.getValue());";
            oc_Newobject9["text"] = "Preview in World";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject45["#Newobject10"] = oc_Newobject10;

            #region GuiWindowCtrl (matEd_cubemapEditor)        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiWindowCtrl", "matEd_cubemapEditor");
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["Enabled"] = "1";
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject39["HorizSizing"] = "center";
            oc_Newobject39["VertSizing"] = "center";
            oc_Newobject39["position"] = "200 257";
            oc_Newobject39["Extent"] = "478 248";
            oc_Newobject39["MinExtent"] = "478 248";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["Visible"] = "0";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["Margin"] = "0 0 0 0";
            oc_Newobject39["Padding"] = "0 0 0 0";
            oc_Newobject39["AnchorTop"] = "1";
            oc_Newobject39["AnchorBottom"] = "0";
            oc_Newobject39["AnchorLeft"] = "1";
            oc_Newobject39["AnchorRight"] = "0";
            oc_Newobject39["resizeWidth"] = "0";
            oc_Newobject39["resizeHeight"] = "0";
            oc_Newobject39["canMove"] = "1";
            oc_Newobject39["canClose"] = "1";
            oc_Newobject39["canMinimize"] = "0";
            oc_Newobject39["canMaximize"] = "0";
            oc_Newobject39["minSize"] = "50 50";
            oc_Newobject39["EdgeSnap"] = "1";
            oc_Newobject39["closeCommand"] = "MaterialEditorGui.hideCubemapEditor(true);";
            oc_Newobject39["text"] = "Cubemap Editor";

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject11["position"] = "307 40";
            oc_Newobject11["Extent"] = "30 16";
            oc_Newobject11["text"] = "Name";

            #endregion

            oc_Newobject39["#Newobject11"] = oc_Newobject11;

            #region GuiTextEditCtrl (matEd_cubemapEd_activeCubemapNameTxt)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextEditCtrl", "matEd_cubemapEd_activeCubemapNameTxt");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "338 40";
            oc_Newobject12["Extent"] = "131 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["text"] = "myCubemap 1";
            oc_Newobject12["maxLength"] = "1024";
            oc_Newobject12["AltCommand"] = "MaterialEditorGui.editCubemapName($ThisControl.getText());";

            #endregion

            oc_Newobject39["#Newobject12"] = oc_Newobject12;

            #region GuiButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject13["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject13["position"] = "339 216";
            oc_Newobject13["Extent"] = "74 24";
            oc_Newobject13["text"] = "Select";
            oc_Newobject13["command"] = "MaterialEditorGui.selectCubemap();";

            #endregion

            oc_Newobject39["#Newobject13"] = oc_Newobject13;

            #region GuiButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject14["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject14["position"] = "417 216";
            oc_Newobject14["Extent"] = "52 24";
            oc_Newobject14["text"] = "Cancel";
            oc_Newobject14["command"] = "MaterialEditorGui.hideCubemapEditor(true);";

            #endregion

            oc_Newobject39["#Newobject14"] = oc_Newobject14;

            #region GuiScrollCtrl (matEd_cubemapEd_availableCubemapScroller)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiScrollCtrl", "matEd_cubemapEd_availableCubemapScroller");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "5 40";
            oc_Newobject16["Extent"] = "154 203";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["willFirstRespond"] = "1";
            oc_Newobject16["hScrollBar"] = "alwaysOff";
            oc_Newobject16["vScrollBar"] = "dynamic";
            oc_Newobject16["lockHorizScroll"] = "true";
            oc_Newobject16["lockVertScroll"] = "false";
            oc_Newobject16["constantThumbHeight"] = "0";
            oc_Newobject16["childMargin"] = "0 0";

            #region GuiListBoxCtrl (matEd_cubemapEd_availableCubemapList)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiListBoxCtrl", "matEd_cubemapEd_availableCubemapList",
                typeof (CodeBehind.MaterialEditor.MaterialEditorGui.matEd_cubemapEd_availableCubemapList));
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiListBoxProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "2 2";
            oc_Newobject15["Extent"] = "128 2";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["AllowMultipleSelections"] = "0";
            oc_Newobject15["fitParentWidth"] = "1";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject39["#Newobject16"] = oc_Newobject16;

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject17["position"] = "6 22";
            oc_Newobject17["Extent"] = "67 16";
            oc_Newobject17["text"] = "Cubemaps";

            #endregion

            oc_Newobject39["#Newobject17"] = oc_Newobject17;

            #region GuiBitmapCtrl (matEd_cubemapEd_XPos)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapCtrl", "matEd_cubemapEd_XPos");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "299 106";
            oc_Newobject18["Extent"] = "64 64";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject18["wrap"] = "0";

            #endregion

            oc_Newobject39["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl (matEd_cubeMapEd_xPosTxt)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "matEd_cubeMapEd_xPosTxt");
            oc_Newobject19["position"] = "304 110";
            oc_Newobject19["Extent"] = "57 10";
            oc_Newobject19["text"] = "+ X  Right";

            #endregion

            oc_Newobject39["#Newobject19"] = oc_Newobject19;

            #region GuiBitmapButtonCtrl (matEd_cubeMapEd_updateXPOSImg)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiBitmapButtonCtrl", "matEd_cubeMapEd_updateXPOSImg");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "299 106";
            oc_Newobject20["Extent"] = "64 64";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["Command"] = "MaterialEditorGui.editCubemapImage(\\\"0\\\", $ThisControl.bitmap );";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["ToolTip"] = "When using Static Cubemaps, select your CubeMap by clicking here.";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "PushButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject39["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapCtrl (matEd_cubemapEd_XNeg)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapCtrl", "matEd_cubemapEd_XNeg");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "167 106";
            oc_Newobject21["Extent"] = "64 64";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject21["wrap"] = "0";

            #endregion

            oc_Newobject39["#Newobject21"] = oc_Newobject21;

            #region GuiTextCtrl (matEd_cubeMapEd_xNegTxt)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextCtrl", "matEd_cubeMapEd_xNegTxt");
            oc_Newobject22["position"] = "171 110";
            oc_Newobject22["Extent"] = "57 10";
            oc_Newobject22["text"] = "- X  Left";

            #endregion

            oc_Newobject39["#Newobject22"] = oc_Newobject22;

            #region GuiBitmapButtonCtrl (matEd_cubeMapEd_updateXNEGImg)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapButtonCtrl", "matEd_cubeMapEd_updateXNEGImg");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "167 106";
            oc_Newobject23["Extent"] = "64 64";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["Command"] = "MaterialEditorGui.editCubemapImage(\\\"1\\\", $ThisControl.bitmap );";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["ToolTip"] = "When using Static Cubemaps, select your CubeMap by clicking here.";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["groupNum"] = "-1";
            oc_Newobject23["buttonType"] = "PushButton";
            oc_Newobject23["useMouseEvents"] = "0";
            oc_Newobject23["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject39["#Newobject23"] = oc_Newobject23;

            #region GuiBitmapCtrl (matEd_cubemapEd_YPos)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiBitmapCtrl", "matEd_cubemapEd_YPos");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "233 172";
            oc_Newobject24["Extent"] = "64 64";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject24["wrap"] = "0";

            #endregion

            oc_Newobject39["#Newobject24"] = oc_Newobject24;

            #region GuiTextCtrl (matEd_cubeMapEd_yPosTxt)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextCtrl", "matEd_cubeMapEd_yPosTxt");
            oc_Newobject25["position"] = "237 175";
            oc_Newobject25["Extent"] = "57 10";
            oc_Newobject25["text"] = "+ Y  Front";

            #endregion

            oc_Newobject39["#Newobject25"] = oc_Newobject25;

            #region GuiBitmapButtonCtrl (matEd_cubeMapEd_updateYPOSImg)        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiBitmapButtonCtrl", "matEd_cubeMapEd_updateYPOSImg");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["position"] = "233 172";
            oc_Newobject26["Extent"] = "64 64";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["Command"] = "MaterialEditorGui.editCubemapImage(\\\"3\\\", $ThisControl.bitmap );";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["ToolTip"] = "When using Static Cubemaps, select your CubeMap by clicking here.";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["groupNum"] = "-1";
            oc_Newobject26["buttonType"] = "PushButton";
            oc_Newobject26["useMouseEvents"] = "0";
            oc_Newobject26["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject39["#Newobject26"] = oc_Newobject26;

            #region GuiBitmapCtrl (matEd_cubemapEd_YNeG)        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiBitmapCtrl", "matEd_cubemapEd_YNeG");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = "233 40";
            oc_Newobject27["Extent"] = "64 64";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject27["wrap"] = "0";

            #endregion

            oc_Newobject39["#Newobject27"] = oc_Newobject27;

            #region GuiTextCtrl (matEd_cubeMapEd_yNegTxt)        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextCtrl", "matEd_cubeMapEd_yNegTxt");
            oc_Newobject28["position"] = "237 44";
            oc_Newobject28["Extent"] = "57 10";
            oc_Newobject28["text"] = "- Y  Back";

            #endregion

            oc_Newobject39["#Newobject28"] = oc_Newobject28;

            #region GuiBitmapButtonCtrl (matEd_cubeMapEd_updateYNegImg)        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiBitmapButtonCtrl", "matEd_cubeMapEd_updateYNegImg");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = "233 40";
            oc_Newobject29["Extent"] = "64 64";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["Command"] = "MaterialEditorGui.editCubemapImage(\\\"2\\\", $ThisControl.bitmap );";
            oc_Newobject29["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["ToolTip"] = "When using Static Cubemaps, select your CubeMap by clicking here.";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["groupNum"] = "-1";
            oc_Newobject29["buttonType"] = "PushButton";
            oc_Newobject29["useMouseEvents"] = "0";
            oc_Newobject29["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject39["#Newobject29"] = oc_Newobject29;

            #region GuiBitmapCtrl (matEd_cubemapEd_ZPos)        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiBitmapCtrl", "matEd_cubemapEd_ZPos");
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["Enabled"] = "1";
            oc_Newobject30["isContainer"] = "0";
            oc_Newobject30["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = "233 106";
            oc_Newobject30["Extent"] = "64 64";
            oc_Newobject30["MinExtent"] = "8 2";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject30["wrap"] = "0";

            #endregion

            oc_Newobject39["#Newobject30"] = oc_Newobject30;

            #region GuiTextCtrl (matEd_cubeMapEd_zPosTxt)        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiTextCtrl", "matEd_cubeMapEd_zPosTxt");
            oc_Newobject31["position"] = "237 110";
            oc_Newobject31["Extent"] = "57 10";
            oc_Newobject31["text"] = "+ Z  Top";

            #endregion

            oc_Newobject39["#Newobject31"] = oc_Newobject31;

            #region GuiBitmapButtonCtrl (matEd_cubeMapEd_updateZPosImg)        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiBitmapButtonCtrl", "matEd_cubeMapEd_updateZPosImg");
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["Enabled"] = "1";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["position"] = "233 106";
            oc_Newobject32["Extent"] = "64 64";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["Command"] = "MaterialEditorGui.editCubemapImage(\\\"4\\\", $ThisControl.bitmap );";
            oc_Newobject32["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject32["ToolTip"] = "When using Static Cubemaps, select your CubeMap by clicking here.";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["groupNum"] = "-1";
            oc_Newobject32["buttonType"] = "PushButton";
            oc_Newobject32["useMouseEvents"] = "0";
            oc_Newobject32["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject39["#Newobject32"] = oc_Newobject32;

            #region GuiBitmapCtrl (matEd_cubemapEd_ZNeg)        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiBitmapCtrl", "matEd_cubemapEd_ZNeg");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["Enabled"] = "1";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["position"] = "365 106";
            oc_Newobject33["Extent"] = "64 64";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject33["wrap"] = "0";

            #endregion

            oc_Newobject39["#Newobject33"] = oc_Newobject33;

            #region GuiTextCtrl (matEd_cubeMapEd_zNegTxt)        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextCtrl", "matEd_cubeMapEd_zNegTxt");
            oc_Newobject34["position"] = "369 110";
            oc_Newobject34["Extent"] = "57 10";
            oc_Newobject34["text"] = "- Z  Bottom";

            #endregion

            oc_Newobject39["#Newobject34"] = oc_Newobject34;

            #region GuiBitmapButtonCtrl (matEd_cubeMapEd_updateZNegImg)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiBitmapButtonCtrl", "matEd_cubeMapEd_updateZNegImg");
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["Enabled"] = "1";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject35["HorizSizing"] = "right";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["position"] = "365 106";
            oc_Newobject35["Extent"] = "64 64";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["Command"] = "MaterialEditorGui.editCubemapImage(\\\"5\\\", $ThisControl.bitmap );";
            oc_Newobject35["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject35["ToolTip"] = "When using Static Cubemaps, select your CubeMap by clicking here.";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["groupNum"] = "-1";
            oc_Newobject35["buttonType"] = "PushButton";
            oc_Newobject35["useMouseEvents"] = "0";
            oc_Newobject35["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject39["#Newobject35"] = oc_Newobject35;

            #region GuiBitmapButtonCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject36["canSaveDynamicFields"] = "0";
            oc_Newobject36["Enabled"] = "1";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject36["HorizSizing"] = "right";
            oc_Newobject36["VertSizing"] = "top";
            oc_Newobject36["position"] = "128 23";
            oc_Newobject36["Extent"] = "17 17";
            oc_Newobject36["MinExtent"] = "8 2";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["Visible"] = "1";
            oc_Newobject36["Command"] = "matEd_addCubemapWindow.setVisible(1);";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["tooltip"] = "Create New Cubemap";
            oc_Newobject36["bitmap"] = "tools/gui/images/new";
            oc_Newobject36["groupNum"] = "-1";
            oc_Newobject36["buttonType"] = "PushButton";
            oc_Newobject36["useMouseEvents"] = "0";

            #endregion

            oc_Newobject39["#Newobject36"] = oc_Newobject36;

            #region GuiBitmapButtonCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject37["HorizSizing"] = "right";
            oc_Newobject37["VertSizing"] = "top";
            oc_Newobject37["position"] = "143 23";
            oc_Newobject37["Extent"] = "17 17";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["Command"] = "MaterialEditorGui.showDeleteCubemapDialog();";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["tooltip"] = "Delete Cubemap";
            oc_Newobject37["bitmap"] = "tools/gui/images/delete";
            oc_Newobject37["groupNum"] = "-1";
            oc_Newobject37["buttonType"] = "PushButton";
            oc_Newobject37["useMouseEvents"] = "0";

            #endregion

            oc_Newobject39["#Newobject37"] = oc_Newobject37;

            #region GuiBitmapButtonCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject38["internalName"] = "saveCubemap";
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["Enabled"] = "1";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject38["HorizSizing"] = "right";
            oc_Newobject38["VertSizing"] = "top";
            oc_Newobject38["position"] = "106 23";
            oc_Newobject38["Extent"] = "17 17";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["Command"] = "MaterialEditorGui.showSaveCubemapDialog();";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["tooltip"] = "Save Cubemap";
            oc_Newobject38["bitmap"] = "tools/gui/images/save-icon";
            oc_Newobject38["groupNum"] = "-1";
            oc_Newobject38["buttonType"] = "PushButton";
            oc_Newobject38["useMouseEvents"] = "0";

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject45["#Newobject39"] = oc_Newobject39;

            #region GuiWindowCtrl (matEd_addCubemapWindow)        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiWindowCtrl", "matEd_addCubemapWindow");
            oc_Newobject44["canSaveDynamicFields"] = "0";
            oc_Newobject44["isContainer"] = "1";
            oc_Newobject44["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject44["HorizSizing"] = "center";
            oc_Newobject44["VertSizing"] = "center";
            oc_Newobject44["position"] = "362 333";
            oc_Newobject44["Extent"] = "300 99";
            oc_Newobject44["MinExtent"] = "48 92";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["Visible"] = "0";
            oc_Newobject44["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["Margin"] = "0 0 0 0";
            oc_Newobject44["Padding"] = "0 0 0 0";
            oc_Newobject44["AnchorTop"] = "1";
            oc_Newobject44["AnchorBottom"] = "0";
            oc_Newobject44["AnchorLeft"] = "1";
            oc_Newobject44["AnchorRight"] = "0";
            oc_Newobject44["resizeWidth"] = "1";
            oc_Newobject44["resizeHeight"] = "1";
            oc_Newobject44["canMove"] = "1";
            oc_Newobject44["canClose"] = "0";
            oc_Newobject44["canMinimize"] = "0";
            oc_Newobject44["canMaximize"] = "0";
            oc_Newobject44["minSize"] = "50 50";
            oc_Newobject44["EdgeSnap"] = "1";
            oc_Newobject44["text"] = "Create Cubemap";

            #region GuiTextEditCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["internalName"] = "cubemapName";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject40["HorizSizing"] = "right";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["position"] = "96 35";
            oc_Newobject40["Extent"] = "196 18";
            oc_Newobject40["MinExtent"] = "8 2";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["Margin"] = "0 0 0 0";
            oc_Newobject40["Padding"] = "0 0 0 0";
            oc_Newobject40["AnchorTop"] = "1";
            oc_Newobject40["AnchorBottom"] = "0";
            oc_Newobject40["AnchorLeft"] = "1";
            oc_Newobject40["AnchorRight"] = "0";
            oc_Newobject40["maxLength"] = "1024";
            oc_Newobject40["historySize"] = "0";
            oc_Newobject40["password"] = "0";
            oc_Newobject40["tabComplete"] = "0";
            oc_Newobject40["sinkAllKeyEvents"] = "0";
            oc_Newobject40["AltCommand"] = "";
            oc_Newobject40["passwordMask"] = "*";

            #endregion

            oc_Newobject44["#Newobject40"] = oc_Newobject40;

            #region GuiTextCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["isContainer"] = "0";
            oc_Newobject41["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["position"] = "12 36";
            oc_Newobject41["Extent"] = "77 16";
            oc_Newobject41["MinExtent"] = "8 2";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["Margin"] = "0 0 0 0";
            oc_Newobject41["Padding"] = "0 0 0 0";
            oc_Newobject41["AnchorTop"] = "1";
            oc_Newobject41["AnchorBottom"] = "0";
            oc_Newobject41["AnchorLeft"] = "1";
            oc_Newobject41["AnchorRight"] = "0";
            oc_Newobject41["maxLength"] = "1024";
            oc_Newobject41["text"] = "Cubemap Name";

            #endregion

            oc_Newobject44["#Newobject41"] = oc_Newobject41;

            #region GuiButtonCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject42["canSaveDynamicFields"] = "0";
            oc_Newobject42["isContainer"] = "0";
            oc_Newobject42["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject42["HorizSizing"] = "right";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["position"] = "96 68";
            oc_Newobject42["Extent"] = "126 22";
            oc_Newobject42["MinExtent"] = "8 2";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["groupNum"] = "-1";
            oc_Newobject42["buttonType"] = "PushButton";
            oc_Newobject42["useMouseEvents"] = "0";
            oc_Newobject42["text"] = "Create";
            oc_Newobject42["Command"] =
                "MaterialEditorGui.addCubemap( matEd_addCubemapWindow-->cubemapName.getText() );matEd_addCubemapWindow.setVisible(0);";

            #endregion

            oc_Newobject44["#Newobject42"] = oc_Newobject42;

            #region GuiButtonCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject43["HorizSizing"] = "right";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["position"] = "228 68";
            oc_Newobject43["Extent"] = "64 22";
            oc_Newobject43["MinExtent"] = "8 2";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["Visible"] = "1";
            oc_Newobject43["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["groupNum"] = "-1";
            oc_Newobject43["buttonType"] = "PushButton";
            oc_Newobject43["useMouseEvents"] = "0";
            oc_Newobject43["text"] = "Cancel";
            oc_Newobject43["Command"] = "matEd_addCubemapWindow.setVisible(0);";

            #endregion

            oc_Newobject44["#Newobject43"] = oc_Newobject43;

            #endregion

            oc_Newobject45["#Newobject44"] = oc_Newobject44;

            #endregion

            oc_Newobject45.Create();
            }

        [ConsoleInteraction]
        public override void onPopWindow()
            {
            EditorGui.DeactivateAll();
            ((WorldEditorPlugin) "MaterialEditorPlugin").onActivated();
            }

        [ConsoleInteraction]
        public override void onPopWindowClosed()
            {
            EditorGui.DeactivateAll();
            ((WorldEditorPlugin) "MaterialEditorPlugin").onActivated();
            this.attachTo("MaterialEditorPropertiesWindow");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MaterialEditorPreviewWindow ts, string simobjectid)
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
        public static bool operator !=(MaterialEditorPreviewWindow ts, string simobjectid)
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
        public static implicit operator string(MaterialEditorPreviewWindow ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MaterialEditorPreviewWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (MaterialEditorPreviewWindow) Omni.self.getSimObject(simobjectid, typeof (MaterialEditorPreviewWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MaterialEditorPreviewWindow ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MaterialEditorPreviewWindow(int simobjectid)
            {
            return
                (MaterialEditorPreviewWindow)
                    Omni.self.getSimObject((uint) simobjectid, typeof (MaterialEditorPreviewWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MaterialEditorPreviewWindow ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MaterialEditorPreviewWindow(uint simobjectid)
            {
            return
                (MaterialEditorPreviewWindow) Omni.self.getSimObject(simobjectid, typeof (MaterialEditorPreviewWindow));
            }

        #endregion
        }
    }