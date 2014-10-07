using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<MaterialEditorPropertiesWindow>))]
    public class MaterialEditorPropertiesWindow : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction(true, "MaterialEditorPropertiesWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl (MaterialEditorGui,EditorGuiGroup)        oc_Newobject224

            ObjectCreator oc_Newobject224 = new ObjectCreator("GuiControl", "MaterialEditorGui,EditorGuiGroup",
                typeof (CodeBehind.MaterialEditor.MaterialEditorGui));
            oc_Newobject224["canSaveDynamicFields"] = "0";
            oc_Newobject224["internalName"] = "MatEdPropertiesWindowContainer";
            oc_Newobject224["Enabled"] = "1";
            oc_Newobject224["isContainer"] = "1";
            oc_Newobject224["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject224["HorizSizing"] = "right";
            oc_Newobject224["VertSizing"] = "bottom";
            oc_Newobject224["Position"] = "0 0";
            oc_Newobject224["Extent"] = "1024 768";
            oc_Newobject224["MinExtent"] = "8 2";
            oc_Newobject224["canSave"] = "1";
            oc_Newobject224["Visible"] = "1";
            oc_Newobject224["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (MaterialEditorPropertiesWindow)        oc_Newobject223

            ObjectCreator oc_Newobject223 = new ObjectCreator("GuiWindowCollapseCtrl", "MaterialEditorPropertiesWindow",
                typeof (MaterialEditorPropertiesWindow));
            oc_Newobject223["AllowPopWindow"] = "1";
            oc_Newobject223["canSaveDynamicFields"] = "0";
            oc_Newobject223["internalName"] = "MaterialEditorPropertiesWindow";
            oc_Newobject223["Enabled"] = "1";
            oc_Newobject223["isContainer"] = "1";
            oc_Newobject223["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject223["HorizSizing"] = "windowRelative";
            oc_Newobject223["VertSizing"] = "windowRelative";
            oc_Newobject223["Extent"] = "210 446";
            oc_Newobject223["MinExtent"] = "210 316";
            oc_Newobject223["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) + getWord(MaterialEditorPreviewWindow.extent, 1) - 2");
            oc_Newobject223["canSave"] = "1";
            oc_Newobject223["Visible"] = "1";
            oc_Newobject223["hovertime"] = "1000";
            oc_Newobject223["Margin"] = "4 4 4 4";
            oc_Newobject223["Padding"] = "0 0 0 0";
            oc_Newobject223["AnchorTop"] = "1";
            oc_Newobject223["AnchorBottom"] = "0";
            oc_Newobject223["AnchorLeft"] = "1";
            oc_Newobject223["AnchorRight"] = "0";
            oc_Newobject223["resizeWidth"] = "1";
            oc_Newobject223["resizeHeight"] = "1";
            oc_Newobject223["canMove"] = "1";
            oc_Newobject223["canClose"] = "0";
            oc_Newobject223["canMinimize"] = "0";
            oc_Newobject223["canMaximize"] = "0";
            oc_Newobject223["closeCommand"] = "MaterialEditorPropertiesWindow.setVisible(false);";
            oc_Newobject223["minSize"] = "50 50";
            oc_Newobject223["EdgeSnap"] = "1";
            oc_Newobject223["text"] = "Material Properties";

            #region GuiContainer ()        oc_Newobject222

            ObjectCreator oc_Newobject222 = new ObjectCreator("GuiContainer", "");
            oc_Newobject222["isContainer"] = "1";
            oc_Newobject222["Docking"] = "Client";
            oc_Newobject222["Margin"] = "3 1 3 3";
            oc_Newobject222["Position"] = "4 24";
            oc_Newobject222["Extent"] = "202 668";

            #region GuiContainer ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiContainer", "");
            oc_Newobject12["Position"] = "0 21";
            oc_Newobject12["Extent"] = "202 39";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["Visible"] = "1";

            #region GuiContainer (MatEdMaterialMode)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiContainer", "MatEdMaterialMode");
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "202 39";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["Visible"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["Position"] = "1 1";
            oc_Newobject1["Extent"] = "39 16";
            oc_Newobject1["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject1["text"] = "Material";

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject2["internalName"] = "selMaterialName";
            oc_Newobject2["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["AltCommand"] =
                "MaterialEditorGui.setMaterialDirty();MaterialEditorGui.updateActiveMaterialName($ThisControl.getText());";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "45 0";
            oc_Newobject2["Extent"] = "158 18";
            oc_Newobject2["text"] = "";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["Position"] = "1 21";
            oc_Newobject3["Extent"] = "39 16";
            oc_Newobject3["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject3["text"] = "Target";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["internalName"] = "selMaterialMapTo";
            oc_Newobject4["Position"] = "46 21";
            oc_Newobject4["Extent"] = "141 16";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["text"] = "";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject12["#Newobject5"] = oc_Newobject5;

            #region GuiContainer (MatEdTargetMode)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiContainer", "MatEdTargetMode");
            oc_Newobject11["Position"] = "0 0";
            oc_Newobject11["Extent"] = "202 39";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["Visible"] = "1";

            #region GuiBitmapButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["Position"] = "186 23";
            oc_Newobject6["Extent"] = "17 17";
            oc_Newobject6["HorizSizing"] = "left";
            oc_Newobject6["tooltip"] = "Swap material on the object with existing";
            oc_Newobject6["bitmap"] = "tools/materialEditor/gui/change-material-btn";
            oc_Newobject6["command"] =
                "materialSelector.showDialog(\\\"MaterialEditorGui.showMaterialChangeSaveDialog\\\");";

            #endregion

            oc_Newobject11["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["internalName"] = "selMaterialName";
            oc_Newobject7["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject7["AltCommand"] =
                "MaterialEditorGui.setMaterialDirty();MaterialEditorGui.updateActiveMaterialName($ThisControl.getText());";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "76 21";
            oc_Newobject7["Extent"] = "107 18";
            oc_Newobject7["text"] = "myMaterial 1";

            #endregion

            oc_Newobject11["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["internalName"] = "selMaterialMapTo";
            oc_Newobject8["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject8["Position"] = "1 1";
            oc_Newobject8["Extent"] = "70 16";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["text"] = "";

            #endregion

            oc_Newobject11["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject9["Position"] = "1 21";
            oc_Newobject9["Extent"] = "70 16";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["text"] = "Material";

            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiPopupMenuCtrlEx (SubMaterialSelector)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiPopupMenuCtrlEx", "SubMaterialSelector",
                typeof (CodeBehind.MaterialEditor.MaterialEditorGui.SubMaterialSelector));
            oc_Newobject10["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject10["Position"] = "76 0";
            oc_Newobject10["Extent"] = "126 17";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["text"] = "";
            oc_Newobject10["tooltip"] = "Target Material";
            oc_Newobject10["Command"] = "SubMaterialSelector.onSelect();";
            oc_Newobject10["reverseTextList"] = "0";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject222["#Newobject12"] = oc_Newobject12;

            #region GuiScrollCtrl (matEd_scrollControl)        oc_Newobject213

            ObjectCreator oc_Newobject213 = new ObjectCreator("GuiScrollCtrl", "matEd_scrollControl");
            oc_Newobject213["canSaveDynamicFields"] = "0";
            oc_Newobject213["Enabled"] = "1";
            oc_Newobject213["isContainer"] = "1";
            oc_Newobject213["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject213["HorizSizing"] = "width";
            oc_Newobject213["VertSizing"] = "height";
            oc_Newobject213["position"] = "0 65";
            oc_Newobject213["Extent"] = "202 603";
            oc_Newobject213["MinExtent"] = "8 2";
            oc_Newobject213["canSave"] = "1";
            oc_Newobject213["Visible"] = "1";
            oc_Newobject213["hovertime"] = "1000";
            oc_Newobject213["willFirstRespond"] = "1";
            oc_Newobject213["hScrollBar"] = "alwaysOff";
            oc_Newobject213["vScrollBar"] = "dynamic";
            oc_Newobject213["lockHorizScroll"] = "true";
            oc_Newobject213["lockVertScroll"] = "false";
            oc_Newobject213["constantThumbHeight"] = "0";
            oc_Newobject213["childMargin"] = "0 0";

            #region GuiStackControl (MatEd_scrollContents)        oc_Newobject212

            ObjectCreator oc_Newobject212 = new ObjectCreator("GuiStackControl", "MatEd_scrollContents");
            oc_Newobject212["StackingType"] = "Vertical";
            oc_Newobject212["HorizStacking"] = "Left to Right";
            oc_Newobject212["VertStacking"] = "Top to Bottom";
            oc_Newobject212["Padding"] = "0";
            oc_Newobject212["isContainer"] = "1";
            oc_Newobject212["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject212["HorizSizing"] = "width";
            oc_Newobject212["VertSizing"] = "bottom";
            oc_Newobject212["position"] = "0 0";
            oc_Newobject212["Extent"] = "187 0";
            oc_Newobject212["MinExtent"] = "8 2";
            oc_Newobject212["canSave"] = "1";
            oc_Newobject212["isDecoy"] = "0";
            oc_Newobject212["Visible"] = "1";
            oc_Newobject212["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject212["hovertime"] = "1000";

            #region GuiPopUpMenuCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["internalName"] = "MaterialLayerCtrl";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiPopUpMenuTabProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "0 0";
            oc_Newobject13["Extent"] = "112 18";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "MaterialEditorGui.changeLayer( $ThisControl.getText() );";
            oc_Newobject13["ToolTip"] = "Changes the material layer being edited";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["text"] = "Layer 0";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["maxPopupHeight"] = "200";
            oc_Newobject13["sbUsesNAColor"] = "0";
            oc_Newobject13["reverseTextList"] = "0";
            oc_Newobject13["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject212["#Newobject13"] = oc_Newobject13;

            #region GuiRolloutCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject40["class"] = "BehaviorQuickEditRollout";
            oc_Newobject40["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject40["Profile"] = "GuiRolloutProfile";
            oc_Newobject40["HorizSizing"] = "width";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["Position"] = "0 0";
            oc_Newobject40["Extent"] = "185 0";
            oc_Newobject40["Caption"] = "Basic Texture Maps";
            oc_Newobject40["Margin"] = "4 4 4 0";
            oc_Newobject40["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject40["container"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject40["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
            oc_Newobject40["object"] = new ObjectCreator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject39["StackingType"] = "Vertical";
            oc_Newobject39["HorizStacking"] = "Left to Right";
            oc_Newobject39["VertStacking"] = "Top to Bottom";
            oc_Newobject39["Padding"] = "0";
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["Enabled"] = "1";
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject39["HorizSizing"] = "width";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["Position"] = "1 3";
            oc_Newobject39["Extent"] = "185 16";
            oc_Newobject39["MinExtent"] = "16 16";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["isDecoy"] = "0";
            oc_Newobject39["Visible"] = "1";
            oc_Newobject39["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiContainer", "");
            oc_Newobject22["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["position"] = "6 21";
            oc_Newobject22["Extent"] = "185 52";
            oc_Newobject22["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["internalName"] = "diffuseMapDisplayBitmap";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "1 1";
            oc_Newobject14["Extent"] = "48 48";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject14["wrap"] = "0";

            #endregion

            oc_Newobject22["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "1 1";
            oc_Newobject15["Extent"] = "48 48";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["Command"] = "MaterialEditorGui.updateTextureMap(\\\"diffuse\\\", 1);";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["ToolTip"] = "Change the Active Diffuse Map for this layer";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject22["#Newobject15"] = oc_Newobject15;

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "EditorTextProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "56 -3";
            oc_Newobject16["Extent"] = "72 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "Diffuse Map";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject22["#Newobject16"] = oc_Newobject16;

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "diffuseMapNameText";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "56 16";
            oc_Newobject17["Extent"] = "134 17";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["text"] = "None";
            oc_Newobject17["maxLength"] = "1024";

            #endregion

            oc_Newobject22["#Newobject17"] = oc_Newobject17;

            #region GuiSwatchButtonCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["internalName"] = "colorTintSwatch";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "55 33";
            oc_Newobject18["Extent"] = "16 16";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["Command"] =
                "getColorF(materialEd_previewMaterial.diffuseColor[MaterialEditorGui.currentLayer], \\\"MaterialEditorGui.updateColorMultiply\\\");";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["groupNum"] = "-1";
            oc_Newobject18["buttonType"] = "PushButton";
            oc_Newobject18["useMouseEvents"] = "0";

            #endregion

            oc_Newobject22["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["text"] = "Color";
            oc_Newobject19["position"] = "74 34";
            oc_Newobject19["Extent"] = "30 15";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject20["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject20["text"] = "Edit";
            oc_Newobject20["HorizSizing"] = "left";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "134 34";
            oc_Newobject20["Extent"] = "40 16";
            oc_Newobject20["buttonType"] = "PushButton";
            oc_Newobject20["command"] = "MaterialEditorGui.updateTextureMap(\\\"diffuse\\\", 1);";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "177 34";
            oc_Newobject21["Extent"] = "16 16";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["Command"] = "MaterialEditorGui.updateTextureMap(\\\"diffuse\\\", 0);";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["groupNum"] = "-1";
            oc_Newobject21["buttonType"] = "PushButton";
            oc_Newobject21["useMouseEvents"] = "0";
            oc_Newobject21["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject39["#Newobject22"] = oc_Newobject22;

            #region GuiBitmapCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject23["position"] = "6 75";
            oc_Newobject23["extent"] = "175 2";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject39["#Newobject23"] = oc_Newobject23;

            #region GuiContainer ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiContainer", "");
            oc_Newobject30["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject30["isContainer"] = "1";
            oc_Newobject30["position"] = "6 79";
            oc_Newobject30["Extent"] = "185 52";
            oc_Newobject30["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["internalName"] = "normalMapDisplayBitmap";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "1 1";
            oc_Newobject24["Extent"] = "48 48";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject24["wrap"] = "0";

            #endregion

            oc_Newobject30["#Newobject24"] = oc_Newobject24;

            #region GuiTextCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "EditorTextProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = "56 -3";
            oc_Newobject25["Extent"] = "72 18";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["Margin"] = "0 0 0 0";
            oc_Newobject25["Padding"] = "0 0 0 0";
            oc_Newobject25["AnchorTop"] = "1";
            oc_Newobject25["AnchorBottom"] = "0";
            oc_Newobject25["AnchorLeft"] = "1";
            oc_Newobject25["AnchorRight"] = "0";
            oc_Newobject25["text"] = "Normal Map";
            oc_Newobject25["maxLength"] = "1024";

            #endregion

            oc_Newobject30["#Newobject25"] = oc_Newobject25;

            #region GuiBitmapButtonCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["position"] = "1 1";
            oc_Newobject26["Extent"] = "48 48";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["Command"] = "MaterialEditorGui.updateTextureMap(\\\"normal\\\", 1);";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["ToolTip"] = "Change the active Normal Map for this layer.";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["groupNum"] = "-1";
            oc_Newobject26["buttonType"] = "PushButton";
            oc_Newobject26["useMouseEvents"] = "0";
            oc_Newobject26["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject30["#Newobject26"] = oc_Newobject26;

            #region GuiTextCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["internalName"] = "normalMapNameText";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject27["HorizSizing"] = "width";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = "56 16";
            oc_Newobject27["Extent"] = "143 17";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["Margin"] = "0 0 0 0";
            oc_Newobject27["Padding"] = "0 0 0 0";
            oc_Newobject27["AnchorTop"] = "1";
            oc_Newobject27["AnchorBottom"] = "0";
            oc_Newobject27["AnchorLeft"] = "1";
            oc_Newobject27["AnchorRight"] = "0";
            oc_Newobject27["text"] = "None";
            oc_Newobject27["maxLength"] = "1024";

            #endregion

            oc_Newobject30["#Newobject27"] = oc_Newobject27;

            #region GuiButtonCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject28["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject28["text"] = "Edit";
            oc_Newobject28["HorizSizing"] = "left";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["position"] = "134 34";
            oc_Newobject28["Extent"] = "40 16";
            oc_Newobject28["buttonType"] = "PushButton";
            oc_Newobject28["command"] = "MaterialEditorGui.updateTextureMap(\\\"normal\\\", 1);";

            #endregion

            oc_Newobject30["#Newobject28"] = oc_Newobject28;

            #region GuiBitmapButtonCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["HorizSizing"] = "left";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = "177 34";
            oc_Newobject29["Extent"] = "16 16";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["Command"] = "MaterialEditorGui.updateTextureMap(\\\"normal\\\", 0);";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["groupNum"] = "-1";
            oc_Newobject29["buttonType"] = "PushButton";
            oc_Newobject29["useMouseEvents"] = "0";
            oc_Newobject29["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject39["#Newobject30"] = oc_Newobject30;

            #region GuiBitmapCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject31["position"] = "6 360";
            oc_Newobject31["extent"] = "175 2";
            oc_Newobject31["HorizSizing"] = "width";
            oc_Newobject31["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject39["#Newobject31"] = oc_Newobject31;

            #region GuiContainer ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiContainer", "");
            oc_Newobject38["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["position"] = "6 364";
            oc_Newobject38["Extent"] = "185 52";
            oc_Newobject38["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["internalName"] = "specMapDisplayBitmap";
            oc_Newobject32["Enabled"] = "1";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["position"] = "1 1";
            oc_Newobject32["Extent"] = "48 48";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject32["wrap"] = "0";

            #endregion

            oc_Newobject38["#Newobject32"] = oc_Newobject32;

            #region GuiTextCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["Enabled"] = "1";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "EditorTextProfile";
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["position"] = "56 -3";
            oc_Newobject33["Extent"] = "72 18";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["Margin"] = "0 0 0 0";
            oc_Newobject33["Padding"] = "0 0 0 0";
            oc_Newobject33["AnchorTop"] = "1";
            oc_Newobject33["AnchorBottom"] = "0";
            oc_Newobject33["AnchorLeft"] = "1";
            oc_Newobject33["AnchorRight"] = "0";
            oc_Newobject33["text"] = "Spec Map";
            oc_Newobject33["maxLength"] = "1024";

            #endregion

            oc_Newobject38["#Newobject33"] = oc_Newobject33;

            #region GuiBitmapButtonCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["Enabled"] = "1";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["position"] = "1 1";
            oc_Newobject34["Extent"] = "48 48";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["Command"] = "MaterialEditorGui.updateSpecMap(1);";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject34["ToolTip"] = "Change the active Tone Map for this layer.";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["groupNum"] = "-1";
            oc_Newobject34["buttonType"] = "PushButton";
            oc_Newobject34["useMouseEvents"] = "0";
            oc_Newobject34["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject38["#Newobject34"] = oc_Newobject34;

            #region GuiTextCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["internalName"] = "specMapNameText";
            oc_Newobject35["Enabled"] = "1";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject35["HorizSizing"] = "width";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["position"] = "56 16";
            oc_Newobject35["Extent"] = "143 17";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["Margin"] = "0 0 0 0";
            oc_Newobject35["Padding"] = "0 0 0 0";
            oc_Newobject35["AnchorTop"] = "1";
            oc_Newobject35["AnchorBottom"] = "0";
            oc_Newobject35["AnchorLeft"] = "1";
            oc_Newobject35["AnchorRight"] = "0";
            oc_Newobject35["text"] = "None";
            oc_Newobject35["maxLength"] = "1024";

            #endregion

            oc_Newobject38["#Newobject35"] = oc_Newobject35;

            #region GuiButtonCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject36["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject36["text"] = "Edit";
            oc_Newobject36["HorizSizing"] = "left";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["position"] = "134 34";
            oc_Newobject36["Extent"] = "40 16";
            oc_Newobject36["buttonType"] = "PushButton";
            oc_Newobject36["command"] = "MaterialEditorGui.updateSpecMap(1);";

            #endregion

            oc_Newobject38["#Newobject36"] = oc_Newobject36;

            #region GuiBitmapButtonCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject37["HorizSizing"] = "left";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["position"] = "177 34";
            oc_Newobject37["Extent"] = "16 16";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["Command"] = "MaterialEditorGui.updateSpecMap(0);";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["groupNum"] = "-1";
            oc_Newobject37["buttonType"] = "PushButton";
            oc_Newobject37["useMouseEvents"] = "0";
            oc_Newobject37["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #region GuiBitmapCtrl ()        oc_Newobject000011
            var oc_Newobject000011 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject000011["position"] = "6 360";
            oc_Newobject000011["extent"] = "175 2";
            oc_Newobject000011["HorizSizing"] = "width";
            oc_Newobject000011["bitmap"] = "core/art/gui/images/separator-v";
            #endregion
            oc_Newobject39["#Newobject000011"] = oc_Newobject000011;

            #region GuiContainer ()        oc_Newobject00008
            var oc_Newobject00008 = new ObjectCreator("GuiContainer", "");
            oc_Newobject00008["profile"] = "GuiDefaultProfile";
            oc_Newobject00008["isContainer"] = "1";
            oc_Newobject00008["position"] = "6 364";
            oc_Newobject00008["Extent"] = "185 52";
            oc_Newobject00008["HorizSizing"] = "width";
            if (true)
            {

                #region GuiBitmapCtrl ()        oc_Newobject000021
                var oc_Newobject000021 = new ObjectCreator("GuiBitmapCtrl", "");
                oc_Newobject000021["canSaveDynamicFields"] = "0";
                oc_Newobject000021["internalName"] = "accuMapDisplayBitmap";
                oc_Newobject000021["Enabled"] = "1";
                oc_Newobject000021["isContainer"] = "0";
                oc_Newobject000021["Profile"] = "GuiDefaultProfile";
                oc_Newobject000021["HorizSizing"] = "right";
                oc_Newobject000021["VertSizing"] = "bottom";
                oc_Newobject000021["position"] = "1 1";
                oc_Newobject000021["Extent"] = "48 48";
                oc_Newobject000021["MinExtent"] = "8 2";
                oc_Newobject000021["canSave"] = "1";
                oc_Newobject000021["Visible"] = "1";
                oc_Newobject000021["hovertime"] = "1000";
                oc_Newobject000021["bitmap"] = "tools/materialeditor/gui/unknownImage";
                oc_Newobject000021["wrap"] = "0";
                #endregion

                oc_Newobject00008["#Newobject000021"] = oc_Newobject000021;

                #region GuiTextCtrl ()        oc_Newobject000031
                var oc_Newobject000031 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject000031["canSaveDynamicFields"] = "0";
                oc_Newobject000031["Enabled"] = "1";
                oc_Newobject000031["isContainer"] = "0";
                oc_Newobject000031["Profile"] = "EditorTextProfile";
                oc_Newobject000031["HorizSizing"] = "right";
                oc_Newobject000031["VertSizing"] = "bottom";
                oc_Newobject000031["position"] = "56 -3";
                oc_Newobject000031["Extent"] = "72 18";
                oc_Newobject000031["MinExtent"] = "8 2";
                oc_Newobject000031["canSave"] = "1";
                oc_Newobject000031["Visible"] = "1";
                oc_Newobject000031["hovertime"] = "1000";
                oc_Newobject000031["Margin"] = "0 0 0 0";
                oc_Newobject000031["Padding"] = "0 0 0 0";
                oc_Newobject000031["AnchorTop"] = "1";
                oc_Newobject000031["AnchorBottom"] = "0";
                oc_Newobject000031["AnchorLeft"] = "1";
                oc_Newobject000031["AnchorRight"] = "0";
                oc_Newobject000031["text"] = "Accu Map";
                oc_Newobject000031["maxLength"] = "1024";
                #endregion

                oc_Newobject00008["#Newobject000031"] = oc_Newobject000031;

                #region GuiBitmapButtonCtrl ()        oc_Newobject000041
                var oc_Newobject000041 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                oc_Newobject000041["canSaveDynamicFields"] = "0";
                oc_Newobject000041["Enabled"] = "1";
                oc_Newobject000041["isContainer"] = "0";
                oc_Newobject000041["Profile"] = "GuiDefaultProfile";
                oc_Newobject000041["HorizSizing"] = "right";
                oc_Newobject000041["VertSizing"] = "bottom";
                oc_Newobject000041["position"] = "1 1";
                oc_Newobject000041["Extent"] = "48 48";
                oc_Newobject000041["MinExtent"] = "8 2";
                oc_Newobject000041["canSave"] = "1";
                oc_Newobject000041["Visible"] = "1";
                oc_Newobject000041["Command"] = "MaterialEditorGui.updateAccuMap(1);";
                oc_Newobject000041["tooltipprofile"] = "GuiDefaultProfile";
                oc_Newobject000041["ToolTip"] = "Change the active Accu Map for this layer.";
                oc_Newobject000041["hovertime"] = "1000";
                oc_Newobject000041["groupNum"] = "-1";
                oc_Newobject000041["buttonType"] = "PushButton";
                oc_Newobject000041["useMouseEvents"] = "0";
                oc_Newobject000041["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";
                #endregion

                oc_Newobject00008["#Newobject000041"] = oc_Newobject000041;

                #region GuiTextCtrl ()        oc_Newobject00005
                var oc_Newobject00005 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject00005["canSaveDynamicFields"] = "0";
                oc_Newobject00005["internalName"] = "accuMapNameText";
                oc_Newobject00005["Enabled"] = "1";
                oc_Newobject00005["isContainer"] = "0";
                oc_Newobject00005["Profile"] = "GuiTextProfile";
                oc_Newobject00005["HorizSizing"] = "width";
                oc_Newobject00005["VertSizing"] = "bottom";
                oc_Newobject00005["position"] = "56 16";
                oc_Newobject00005["Extent"] = "143 17";
                oc_Newobject00005["MinExtent"] = "8 2";
                oc_Newobject00005["canSave"] = "1";
                oc_Newobject00005["Visible"] = "1";
                oc_Newobject00005["hovertime"] = "1000";
                oc_Newobject00005["Margin"] = "0 0 0 0";
                oc_Newobject00005["Padding"] = "0 0 0 0";
                oc_Newobject00005["AnchorTop"] = "1";
                oc_Newobject00005["AnchorBottom"] = "0";
                oc_Newobject00005["AnchorLeft"] = "1";
                oc_Newobject00005["AnchorRight"] = "0";
                oc_Newobject00005["text"] = "None";
                oc_Newobject00005["maxLength"] = "1024";
                #endregion

                oc_Newobject00008["#Newobject00005"] = oc_Newobject00005;

                #region GuiButtonCtrl ()        oc_Newobject00006
                var oc_Newobject00006 = new ObjectCreator("GuiButtonCtrl", "");
                oc_Newobject00006["profile"] = "GuiButtonProfile";
                oc_Newobject00006["text"] = "Edit";
                oc_Newobject00006["HorizSizing"] = "left";
                oc_Newobject00006["VertSizing"] = "bottom";
                oc_Newobject00006["position"] = "134 34";
                oc_Newobject00006["Extent"] = "40 16";
                oc_Newobject00006["buttonType"] = "PushButton";
                oc_Newobject00006["command"] = "MaterialEditorGui.updateAccuMap(1);";
                #endregion

                oc_Newobject00008["#Newobject00006"] = oc_Newobject00006;

                #region GuiBitmapButtonCtrl ()        oc_Newobject00007
                var oc_Newobject00007 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                oc_Newobject00007["canSaveDynamicFields"] = "0";
                oc_Newobject00007["Enabled"] = "1";
                oc_Newobject00007["isContainer"] = "0";
                oc_Newobject00007["Profile"] = "GuiDefaultProfile";
                oc_Newobject00007["HorizSizing"] = "left";
                oc_Newobject00007["VertSizing"] = "bottom";
                oc_Newobject00007["position"] = "177 34";
                oc_Newobject00007["Extent"] = "16 16";
                oc_Newobject00007["MinExtent"] = "8 2";
                oc_Newobject00007["canSave"] = "1";
                oc_Newobject00007["Visible"] = "1";
                oc_Newobject00007["Command"] = "MaterialEditorGui.updateAccuMap(0);";
                oc_Newobject00007["hovertime"] = "1000";
                oc_Newobject00007["groupNum"] = "-1";
                oc_Newobject00007["buttonType"] = "PushButton";
                oc_Newobject00007["useMouseEvents"] = "0";
                oc_Newobject00007["bitmap"] = "tools/gui/images/delete";
                #endregion

                oc_Newobject00008["#Newobject00007"] = oc_Newobject00007;

            }
            #endregion
            oc_Newobject39["#Newobject00008"] = oc_Newobject00008;

            #endregion

            oc_Newobject40["#Newobject39"] = oc_Newobject39;

            #endregion

            oc_Newobject212["#Newobject40"] = oc_Newobject40;

          //  #region GuiRolloutCtrl ()        oc_Newobject300

          //  ObjectCreator oc_Newobject300 = new ObjectCreator("GuiRolloutCtrl", "");
          //  oc_Newobject300["class"] = "BehaviorQuickEditRollout";
          //  oc_Newobject300["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
          //  oc_Newobject300["Profile"] = "GuiRolloutProfile";
          //  oc_Newobject300["HorizSizing"] = "width";
          //  oc_Newobject300["VertSizing"] = "bottom";
          //  oc_Newobject300["Position"] = "0 0";
          //  oc_Newobject300["Extent"] = "185 0";
          //  oc_Newobject300["Caption"] = "Shader Maps";
          //  oc_Newobject300["Expanded"] = new ObjectCreator.StringNoQuote("false");
          //  oc_Newobject300["Margin"] = "4 4 4 0";
          //  oc_Newobject300["DragSizable"] = new ObjectCreator.StringNoQuote("false");
          //  oc_Newobject300["container"] = new ObjectCreator.StringNoQuote("true");
          //  oc_Newobject300["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
          //  oc_Newobject300["object"] = new ObjectCreator.StringNoQuote("%behavior");

          //  #region GuiStackControl ()        oc_Newobject301

          //  ObjectCreator oc_Newobject301 = new ObjectCreator("GuiStackControl", "");
          //  oc_Newobject301["StackingType"] = "Vertical";
          //  oc_Newobject301["HorizStacking"] = "Left to Right";
          //  oc_Newobject301["VertStacking"] = "Top to Bottom";
          //  oc_Newobject301["Padding"] = "0";
          //  oc_Newobject301["canSaveDynamicFields"] = "0";
          //  oc_Newobject301["Enabled"] = "1";
          //  oc_Newobject301["isContainer"] = "1";
          //  oc_Newobject301["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject301["HorizSizing"] = "width";
          //  oc_Newobject301["VertSizing"] = "bottom";
          //  oc_Newobject301["Position"] = "1 3";
          //  oc_Newobject301["Extent"] = "185 16";
          //  oc_Newobject301["MinExtent"] = "16 16";
          //  oc_Newobject301["canSave"] = "1";
          //  oc_Newobject301["isDecoy"] = "0";
          //  oc_Newobject301["Visible"] = "1";
          //  oc_Newobject301["tooltipprofile"] = "ToolsGuiToolTipProfile";
          //  oc_Newobject301["hovertime"] = "1000";

          //  #region GuiContainer ()        oc_Newobject302

          //  ObjectCreator oc_Newobject302 = new ObjectCreator("GuiContainer", "");
          //  oc_Newobject302["profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject302["isContainer"] = "1";
          //  oc_Newobject302["position"] = "6 136";
          //  oc_Newobject302["Extent"] = "185 52";
          //  oc_Newobject302["HorizSizing"] = "width";

          //  #region GuiBitmapCtrl ()        oc_Newobject303

          //  ObjectCreator oc_Newobject303 = new ObjectCreator("GuiBitmapCtrl", "");
          //  oc_Newobject303["canSaveDynamicFields"] = "0";
          //  oc_Newobject303["internalName"] = "furMapDisplayBitmap";
          //  oc_Newobject303["Enabled"] = "1";
          //  oc_Newobject303["isContainer"] = "0";
          //  oc_Newobject303["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject303["HorizSizing"] = "right";
          //  oc_Newobject303["VertSizing"] = "bottom";
          //  oc_Newobject303["position"] = "1 1";
          //  oc_Newobject303["Extent"] = "48 48";
          //  oc_Newobject303["MinExtent"] = "8 2";
          //  oc_Newobject303["canSave"] = "1";
          //  oc_Newobject303["Visible"] = "1";
          //  oc_Newobject303["hovertime"] = "1000";
          //  oc_Newobject303["bitmap"] = "tools/materialeditor/gui/unknownImage";
          //  oc_Newobject303["wrap"] = "0";

          //  #endregion

          //  oc_Newobject302["#Newobject303"] = oc_Newobject303;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject304

          //  ObjectCreator oc_Newobject304 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject304["canSaveDynamicFields"] = "0";
          //  oc_Newobject304["Enabled"] = "1";
          //  oc_Newobject304["isContainer"] = "0";
          //  oc_Newobject304["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject304["HorizSizing"] = "right";
          //  oc_Newobject304["VertSizing"] = "bottom";
          //  oc_Newobject304["position"] = "1 1";
          //  oc_Newobject304["Extent"] = "48 48";
          //  oc_Newobject304["MinExtent"] = "8 2";
          //  oc_Newobject304["canSave"] = "1";
          //  oc_Newobject304["Visible"] = "1";
          //  oc_Newobject304["Command"] = "MaterialEditorGui.updateTextureMap(\\\"fur\\\", 1);";
          //  oc_Newobject304["tooltipprofile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject304["ToolTip"] = "Change the active Fur Map for this layer.";
          //  oc_Newobject304["hovertime"] = "1000";
          //  oc_Newobject304["groupNum"] = "-1";
          //  oc_Newobject304["buttonType"] = "PushButton";
          //  oc_Newobject304["useMouseEvents"] = "0";
          //  oc_Newobject304["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

          //  #endregion

          //  oc_Newobject302["#Newobject304"] = oc_Newobject304;

          //  #region GuiTextCtrl ()        oc_Newobject305

          //  ObjectCreator oc_Newobject305 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject305["canSaveDynamicFields"] = "0";
          //  oc_Newobject305["Enabled"] = "1";
          //  oc_Newobject305["isContainer"] = "0";
          //  oc_Newobject305["Profile"] = "EditorTextProfile";
          //  oc_Newobject305["HorizSizing"] = "right";
          //  oc_Newobject305["VertSizing"] = "bottom";
          //  oc_Newobject305["position"] = "56 -3";
          //  oc_Newobject305["Extent"] = "72 18";
          //  oc_Newobject305["MinExtent"] = "8 2";
          //  oc_Newobject305["canSave"] = "1";
          //  oc_Newobject305["Visible"] = "1";
          //  oc_Newobject305["hovertime"] = "1000";
          //  oc_Newobject305["Margin"] = "0 0 0 0";
          //  oc_Newobject305["Padding"] = "0 0 0 0";
          //  oc_Newobject305["AnchorTop"] = "1";
          //  oc_Newobject305["AnchorBottom"] = "0";
          //  oc_Newobject305["AnchorLeft"] = "1";
          //  oc_Newobject305["AnchorRight"] = "0";
          //  oc_Newobject305["text"] = "Fur Map";
          //  oc_Newobject305["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject302["#Newobject305"] = oc_Newobject305;

          //  #region GuiTextCtrl ()        oc_Newobject306

          //  ObjectCreator oc_Newobject306 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject306["canSaveDynamicFields"] = "0";
          //  oc_Newobject306["internalName"] = "furMapNameText";
          //  oc_Newobject306["Enabled"] = "1";
          //  oc_Newobject306["isContainer"] = "0";
          //  oc_Newobject306["Profile"] = "ToolsGuiTextProfile";
          //  oc_Newobject306["HorizSizing"] = "width";
          //  oc_Newobject306["VertSizing"] = "bottom";
          //  oc_Newobject306["position"] = "56 16";
          //  oc_Newobject306["Extent"] = "143 17";
          //  oc_Newobject306["MinExtent"] = "8 2";
          //  oc_Newobject306["canSave"] = "1";
          //  oc_Newobject306["Visible"] = "1";
          //  oc_Newobject306["hovertime"] = "1000";
          //  oc_Newobject306["Margin"] = "0 0 0 0";
          //  oc_Newobject306["Padding"] = "0 0 0 0";
          //  oc_Newobject306["AnchorTop"] = "1";
          //  oc_Newobject306["AnchorBottom"] = "0";
          //  oc_Newobject306["AnchorLeft"] = "1";
          //  oc_Newobject306["AnchorRight"] = "0";
          //  oc_Newobject306["text"] = "None";
          //  oc_Newobject306["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject302["#Newobject306"] = oc_Newobject306;

          //  #region GuiButtonCtrl ()        oc_Newobject307

          //  ObjectCreator oc_Newobject307 = new ObjectCreator("GuiButtonCtrl", "");
          //  oc_Newobject307["profile"] = "ToolsGuiButtonProfile";
          //  oc_Newobject307["text"] = "Edit";
          //  oc_Newobject307["HorizSizing"] = "left";
          //  oc_Newobject307["VertSizing"] = "bottom";
          //  oc_Newobject307["position"] = "134 34";
          //  oc_Newobject307["Extent"] = "40 16";
          //  oc_Newobject307["buttonType"] = "PushButton";
          //  oc_Newobject307["command"] = "MaterialEditorGui.updateTextureMap(\\\"fur\\\", 1);";

          //  #endregion

          //  oc_Newobject302["#Newobject307"] = oc_Newobject307;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject308

          //  ObjectCreator oc_Newobject308 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject308["canSaveDynamicFields"] = "0";
          //  oc_Newobject308["Enabled"] = "1";
          //  oc_Newobject308["isContainer"] = "0";
          //  oc_Newobject308["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject308["HorizSizing"] = "left";
          //  oc_Newobject308["VertSizing"] = "bottom";
          //  oc_Newobject308["position"] = "177 34";
          //  oc_Newobject308["Extent"] = "16 16";
          //  oc_Newobject308["MinExtent"] = "8 2";
          //  oc_Newobject308["canSave"] = "1";
          //  oc_Newobject308["Visible"] = "1";
          //  oc_Newobject308["Command"] = "MaterialEditorGui.updateTextureMap(\\\"fur\\\", 0);";
          //  oc_Newobject308["hovertime"] = "1000";
          //  oc_Newobject308["groupNum"] = "-1";
          //  oc_Newobject308["buttonType"] = "PushButton";
          //  oc_Newobject308["useMouseEvents"] = "0";
          //  oc_Newobject308["bitmap"] = "tools/gui/images/delete";

          //  #endregion

          //  oc_Newobject302["#Newobject308"] = oc_Newobject308;

          //  #endregion

          //  oc_Newobject301["#Newobject302"] = oc_Newobject302;

          //  #region GuiBitmapCtrl ()        oc_Newobject309

          //  ObjectCreator oc_Newobject309 = new ObjectCreator("GuiBitmapCtrl", "");
          //  oc_Newobject309["position"] = "6 189";
          //  oc_Newobject309["extent"] = "175 2";
          //  oc_Newobject309["HorizSizing"] = "width";
          //  oc_Newobject309["bitmap"] = "tools/gui/images/separator-v";

          //  #endregion

          //  oc_Newobject301["#Newobject309"] = oc_Newobject309;

          //  #region GuiContainer ()        oc_Newobject310

          //  //ObjectCreator oc_Newobject310 = new ObjectCreator("GuiContainer", "");
          //  //oc_Newobject310["profile"] = "ToolsGuiDefaultProfile";
          //  //oc_Newobject310["isContainer"] = "1";
          //  //oc_Newobject310["position"] = "6 136";
          //  //oc_Newobject310["Extent"] = "185 52";
          //  //oc_Newobject310["HorizSizing"] = "width";

          //  #region GuiBitmapCtrl ()        oc_Newobject311

          //  //ObjectCreator oc_Newobject311 = new ObjectCreator("GuiBitmapCtrl", "");
          //  //oc_Newobject311["canSaveDynamicFields"] = "0";
          //  //oc_Newobject311["internalName"] = "skinMapDisplayBitmap";
          //  //oc_Newobject311["Enabled"] = "1";
          //  //oc_Newobject311["isContainer"] = "0";
          //  //oc_Newobject311["Profile"] = "ToolsGuiDefaultProfile";
          //  //oc_Newobject311["HorizSizing"] = "right";
          //  //oc_Newobject311["VertSizing"] = "bottom";
          //  //oc_Newobject311["position"] = "1 1";
          //  //oc_Newobject311["Extent"] = "48 48";
          //  //oc_Newobject311["MinExtent"] = "8 2";
          //  //oc_Newobject311["canSave"] = "1";
          //  //oc_Newobject311["Visible"] = "1";
          //  //oc_Newobject311["hovertime"] = "1000";
          //  //oc_Newobject311["bitmap"] = "tools/materialeditor/gui/unknownImage";
          //  //oc_Newobject311["wrap"] = "0";

          //  #endregion

          ////  oc_Newobject310["#Newobject311"] = oc_Newobject311;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject312

          //  //ObjectCreator oc_Newobject312 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  //oc_Newobject312["canSaveDynamicFields"] = "0";
          //  //oc_Newobject312["Enabled"] = "1";
          //  //oc_Newobject312["isContainer"] = "0";
          //  //oc_Newobject312["Profile"] = "ToolsGuiDefaultProfile";
          //  //oc_Newobject312["HorizSizing"] = "right";
          //  //oc_Newobject312["VertSizing"] = "bottom";
          //  //oc_Newobject312["position"] = "1 1";
          //  //oc_Newobject312["Extent"] = "48 48";
          //  //oc_Newobject312["MinExtent"] = "8 2";
          //  //oc_Newobject312["canSave"] = "1";
          //  //oc_Newobject312["Visible"] = "1";
          //  //oc_Newobject312["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skin\\\", 1);";
          //  //oc_Newobject312["tooltipprofile"] = "ToolsGuiDefaultProfile";
          //  //oc_Newobject312["ToolTip"] = "Change the active Skin Map for this layer.";
          //  //oc_Newobject312["hovertime"] = "1000";
          //  //oc_Newobject312["groupNum"] = "-1";
          //  //oc_Newobject312["buttonType"] = "PushButton";
          //  //oc_Newobject312["useMouseEvents"] = "0";
          //  //oc_Newobject312["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

          //  #endregion

          // // oc_Newobject310["#Newobject312"] = oc_Newobject312;

          //  #region GuiTextCtrl ()        oc_Newobject313

          //  //ObjectCreator oc_Newobject313 = new ObjectCreator("GuiTextCtrl", "");
          //  //oc_Newobject313["canSaveDynamicFields"] = "0";
          //  //oc_Newobject313["Enabled"] = "1";
          //  //oc_Newobject313["isContainer"] = "0";
          //  //oc_Newobject313["Profile"] = "EditorTextProfile";
          //  //oc_Newobject313["HorizSizing"] = "right";
          //  //oc_Newobject313["VertSizing"] = "bottom";
          //  //oc_Newobject313["position"] = "56 -3";
          //  //oc_Newobject313["Extent"] = "72 18";
          //  //oc_Newobject313["MinExtent"] = "8 2";
          //  //oc_Newobject313["canSave"] = "1";
          //  //oc_Newobject313["Visible"] = "1";
          //  //oc_Newobject313["hovertime"] = "1000";
          //  //oc_Newobject313["Margin"] = "0 0 0 0";
          //  //oc_Newobject313["Padding"] = "0 0 0 0";
          //  //oc_Newobject313["AnchorTop"] = "1";
          //  //oc_Newobject313["AnchorBottom"] = "0";
          //  //oc_Newobject313["AnchorLeft"] = "1";
          //  //oc_Newobject313["AnchorRight"] = "0";
          //  //oc_Newobject313["text"] = "Skin Map";
          //  //oc_Newobject313["maxLength"] = "1024";

          //  #endregion

          ////  oc_Newobject310["#Newobject313"] = oc_Newobject313;

          //  #region GuiTextCtrl ()        oc_Newobject314

          //  //ObjectCreator oc_Newobject314 = new ObjectCreator("GuiTextCtrl", "");
          //  //oc_Newobject314["canSaveDynamicFields"] = "0";
          //  //oc_Newobject314["internalName"] = "skinMapNameText";
          //  //oc_Newobject314["Enabled"] = "1";
          //  //oc_Newobject314["isContainer"] = "0";
          //  //oc_Newobject314["Profile"] = "ToolsGuiTextProfile";
          //  //oc_Newobject314["HorizSizing"] = "width";
          //  //oc_Newobject314["VertSizing"] = "bottom";
          //  //oc_Newobject314["position"] = "56 16";
          //  //oc_Newobject314["Extent"] = "143 17";
          //  //oc_Newobject314["MinExtent"] = "8 2";
          //  //oc_Newobject314["canSave"] = "1";
          //  //oc_Newobject314["Visible"] = "1";
          //  //oc_Newobject314["hovertime"] = "1000";
          //  //oc_Newobject314["Margin"] = "0 0 0 0";
          //  //oc_Newobject314["Padding"] = "0 0 0 0";
          //  //oc_Newobject314["AnchorTop"] = "1";
          //  //oc_Newobject314["AnchorBottom"] = "0";
          //  //oc_Newobject314["AnchorLeft"] = "1";
          //  //oc_Newobject314["AnchorRight"] = "0";
          //  //oc_Newobject314["text"] = "None";
          //  //oc_Newobject314["maxLength"] = "1024";

          //  #endregion

          // // oc_Newobject310["#Newobject314"] = oc_Newobject314;

          //  #region GuiButtonCtrl ()        oc_Newobject315

          //  //ObjectCreator oc_Newobject315 = new ObjectCreator("GuiButtonCtrl", "");
          //  //oc_Newobject315["profile"] = "ToolsGuiButtonProfile";
          //  //oc_Newobject315["text"] = "Edit";
          //  //oc_Newobject315["HorizSizing"] = "left";
          //  //oc_Newobject315["VertSizing"] = "bottom";
          //  //oc_Newobject315["position"] = "134 34";
          //  //oc_Newobject315["Extent"] = "40 16";
          //  //oc_Newobject315["buttonType"] = "PushButton";
          //  //oc_Newobject315["command"] = "MaterialEditorGui.updateTextureMap(\\\"skin\\\", 1);";

          //  #endregion

          //  //oc_Newobject310["#Newobject315"] = oc_Newobject315;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject316

          //  //ObjectCreator oc_Newobject316 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  //oc_Newobject316["canSaveDynamicFields"] = "0";
          //  //oc_Newobject316["Enabled"] = "1";
          //  //oc_Newobject316["isContainer"] = "0";
          //  //oc_Newobject316["Profile"] = "ToolsGuiDefaultProfile";
          //  //oc_Newobject316["HorizSizing"] = "left";
          //  //oc_Newobject316["VertSizing"] = "bottom";
          //  //oc_Newobject316["position"] = "177 34";
          //  //oc_Newobject316["Extent"] = "16 16";
          //  //oc_Newobject316["MinExtent"] = "8 2";
          //  //oc_Newobject316["canSave"] = "1";
          //  //oc_Newobject316["Visible"] = "1";
          //  //oc_Newobject316["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skin\\\", 0);";
          //  //oc_Newobject316["hovertime"] = "1000";
          //  //oc_Newobject316["groupNum"] = "-1";
          //  //oc_Newobject316["buttonType"] = "PushButton";
          //  //oc_Newobject316["useMouseEvents"] = "0";
          //  //oc_Newobject316["bitmap"] = "tools/gui/images/delete";

          //  #endregion

          ////  oc_Newobject310["#Newobject316"] = oc_Newobject316;

          //  #endregion

          //  //oc_Newobject301["#Newobject310"] = oc_Newobject310;

          //  #region GuiContainer ()        oc_Newobject317

          //  ObjectCreator oc_Newobject317 = new ObjectCreator("GuiContainer", "");
          //  oc_Newobject317["profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject317["isContainer"] = "1";
          //  oc_Newobject317["position"] = "6 136";
          //  oc_Newobject317["Extent"] = "185 52";
          //  oc_Newobject317["HorizSizing"] = "width";

          //  #region GuiBitmapCtrl ()        oc_Newobject318

          //  ObjectCreator oc_Newobject318 = new ObjectCreator("GuiBitmapCtrl", "");
          //  oc_Newobject318["canSaveDynamicFields"] = "0";
          //  oc_Newobject318["internalName"] = "skinPoreMapDisplayBitmap";
          //  oc_Newobject318["Enabled"] = "1";
          //  oc_Newobject318["isContainer"] = "0";
          //  oc_Newobject318["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject318["HorizSizing"] = "right";
          //  oc_Newobject318["VertSizing"] = "bottom";
          //  oc_Newobject318["position"] = "1 1";
          //  oc_Newobject318["Extent"] = "48 48";
          //  oc_Newobject318["MinExtent"] = "8 2";
          //  oc_Newobject318["canSave"] = "1";
          //  oc_Newobject318["Visible"] = "1";
          //  oc_Newobject318["hovertime"] = "1000";
          //  oc_Newobject318["bitmap"] = "tools/materialeditor/gui/unknownImage";
          //  oc_Newobject318["wrap"] = "0";

          //  #endregion

          //  oc_Newobject317["#Newobject318"] = oc_Newobject318;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject319

          //  ObjectCreator oc_Newobject319 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject319["canSaveDynamicFields"] = "0";
          //  oc_Newobject319["Enabled"] = "1";
          //  oc_Newobject319["isContainer"] = "0";
          //  oc_Newobject319["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject319["HorizSizing"] = "right";
          //  oc_Newobject319["VertSizing"] = "bottom";
          //  oc_Newobject319["position"] = "1 1";
          //  oc_Newobject319["Extent"] = "48 48";
          //  oc_Newobject319["MinExtent"] = "8 2";
          //  oc_Newobject319["canSave"] = "1";
          //  oc_Newobject319["Visible"] = "1";
          //  oc_Newobject319["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinPore\\\", 1);";
          //  oc_Newobject319["tooltipprofile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject319["ToolTip"] = "Change the active Skin Pore Map for this layer.";
          //  oc_Newobject319["hovertime"] = "1000";
          //  oc_Newobject319["groupNum"] = "-1";
          //  oc_Newobject319["buttonType"] = "PushButton";
          //  oc_Newobject319["useMouseEvents"] = "0";
          //  oc_Newobject319["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

          //  #endregion

          //  oc_Newobject317["#Newobject319"] = oc_Newobject319;

          //  #region GuiTextCtrl ()        oc_Newobject320

          //  ObjectCreator oc_Newobject320 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject320["canSaveDynamicFields"] = "0";
          //  oc_Newobject320["Enabled"] = "1";
          //  oc_Newobject320["isContainer"] = "0";
          //  oc_Newobject320["Profile"] = "EditorTextProfile";
          //  oc_Newobject320["HorizSizing"] = "right";
          //  oc_Newobject320["VertSizing"] = "bottom";
          //  oc_Newobject320["position"] = "56 -3";
          //  oc_Newobject320["Extent"] = "72 18";
          //  oc_Newobject320["MinExtent"] = "8 2";
          //  oc_Newobject320["canSave"] = "1";
          //  oc_Newobject320["Visible"] = "1";
          //  oc_Newobject320["hovertime"] = "1000";
          //  oc_Newobject320["Margin"] = "0 0 0 0";
          //  oc_Newobject320["Padding"] = "0 0 0 0";
          //  oc_Newobject320["AnchorTop"] = "1";
          //  oc_Newobject320["AnchorBottom"] = "0";
          //  oc_Newobject320["AnchorLeft"] = "1";
          //  oc_Newobject320["AnchorRight"] = "0";
          //  oc_Newobject320["text"] = "Skin Pore Map";
          //  oc_Newobject320["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject317["#Newobject320"] = oc_Newobject320;

          //  #region GuiTextCtrl ()        oc_Newobject321

          //  ObjectCreator oc_Newobject321 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject321["canSaveDynamicFields"] = "0";
          //  oc_Newobject321["internalName"] = "skinPoreMapNameText";
          //  oc_Newobject321["Enabled"] = "1";
          //  oc_Newobject321["isContainer"] = "0";
          //  oc_Newobject321["Profile"] = "ToolsGuiTextProfile";
          //  oc_Newobject321["HorizSizing"] = "width";
          //  oc_Newobject321["VertSizing"] = "bottom";
          //  oc_Newobject321["position"] = "56 16";
          //  oc_Newobject321["Extent"] = "143 17";
          //  oc_Newobject321["MinExtent"] = "8 2";
          //  oc_Newobject321["canSave"] = "1";
          //  oc_Newobject321["Visible"] = "1";
          //  oc_Newobject321["hovertime"] = "1000";
          //  oc_Newobject321["Margin"] = "0 0 0 0";
          //  oc_Newobject321["Padding"] = "0 0 0 0";
          //  oc_Newobject321["AnchorTop"] = "1";
          //  oc_Newobject321["AnchorBottom"] = "0";
          //  oc_Newobject321["AnchorLeft"] = "1";
          //  oc_Newobject321["AnchorRight"] = "0";
          //  oc_Newobject321["text"] = "None";
          //  oc_Newobject321["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject317["#Newobject321"] = oc_Newobject321;

          //  #region GuiButtonCtrl ()        oc_Newobject322

          //  ObjectCreator oc_Newobject322 = new ObjectCreator("GuiButtonCtrl", "");
          //  oc_Newobject322["profile"] = "ToolsGuiButtonProfile";
          //  oc_Newobject322["text"] = "Edit";
          //  oc_Newobject322["HorizSizing"] = "left";
          //  oc_Newobject322["VertSizing"] = "bottom";
          //  oc_Newobject322["position"] = "134 34";
          //  oc_Newobject322["Extent"] = "40 16";
          //  oc_Newobject322["buttonType"] = "PushButton";
          //  oc_Newobject322["command"] = "MaterialEditorGui.updateTextureMap(\\\"skinPore\\\", 1);";

          //  #endregion

          //  oc_Newobject317["#Newobject322"] = oc_Newobject322;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject323

          //  ObjectCreator oc_Newobject323 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject323["canSaveDynamicFields"] = "0";
          //  oc_Newobject323["Enabled"] = "1";
          //  oc_Newobject323["isContainer"] = "0";
          //  oc_Newobject323["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject323["HorizSizing"] = "left";
          //  oc_Newobject323["VertSizing"] = "bottom";
          //  oc_Newobject323["position"] = "177 34";
          //  oc_Newobject323["Extent"] = "16 16";
          //  oc_Newobject323["MinExtent"] = "8 2";
          //  oc_Newobject323["canSave"] = "1";
          //  oc_Newobject323["Visible"] = "1";
          //  oc_Newobject323["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinPore\\\", 0);";
          //  oc_Newobject323["hovertime"] = "1000";
          //  oc_Newobject323["groupNum"] = "-1";
          //  oc_Newobject323["buttonType"] = "PushButton";
          //  oc_Newobject323["useMouseEvents"] = "0";
          //  oc_Newobject323["bitmap"] = "tools/gui/images/delete";

          //  #endregion

          //  oc_Newobject317["#Newobject323"] = oc_Newobject323;

          //  #endregion

          //  oc_Newobject301["#Newobject317"] = oc_Newobject317;

          //  #region GuiContainer ()        oc_Newobject324

          //  ObjectCreator oc_Newobject324 = new ObjectCreator("GuiContainer", "");
          //  oc_Newobject324["profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject324["isContainer"] = "1";
          //  oc_Newobject324["position"] = "6 136";
          //  oc_Newobject324["Extent"] = "185 52";
          //  oc_Newobject324["HorizSizing"] = "width";

          //  #region GuiBitmapCtrl ()        oc_Newobject325

          //  ObjectCreator oc_Newobject325 = new ObjectCreator("GuiBitmapCtrl", "");
          //  oc_Newobject325["canSaveDynamicFields"] = "0";
          //  oc_Newobject325["internalName"] = "skinForeheadMapDisplayBitmap";
          //  oc_Newobject325["Enabled"] = "1";
          //  oc_Newobject325["isContainer"] = "0";
          //  oc_Newobject325["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject325["HorizSizing"] = "right";
          //  oc_Newobject325["VertSizing"] = "bottom";
          //  oc_Newobject325["position"] = "1 1";
          //  oc_Newobject325["Extent"] = "48 48";
          //  oc_Newobject325["MinExtent"] = "8 2";
          //  oc_Newobject325["canSave"] = "1";
          //  oc_Newobject325["Visible"] = "1";
          //  oc_Newobject325["hovertime"] = "1000";
          //  oc_Newobject325["bitmap"] = "tools/materialeditor/gui/unknownImage";
          //  oc_Newobject325["wrap"] = "0";

          //  #endregion

          //  oc_Newobject324["#Newobject325"] = oc_Newobject325;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject326

          //  ObjectCreator oc_Newobject326 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject326["canSaveDynamicFields"] = "0";
          //  oc_Newobject326["Enabled"] = "1";
          //  oc_Newobject326["isContainer"] = "0";
          //  oc_Newobject326["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject326["HorizSizing"] = "right";
          //  oc_Newobject326["VertSizing"] = "bottom";
          //  oc_Newobject326["position"] = "1 1";
          //  oc_Newobject326["Extent"] = "48 48";
          //  oc_Newobject326["MinExtent"] = "8 2";
          //  oc_Newobject326["canSave"] = "1";
          //  oc_Newobject326["Visible"] = "1";
          //  oc_Newobject326["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinForehead\\\", 1);";
          //  oc_Newobject326["tooltipprofile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject326["ToolTip"] = "Change the active Skin Forehead Map for this layer.";
          //  oc_Newobject326["hovertime"] = "1000";
          //  oc_Newobject326["groupNum"] = "-1";
          //  oc_Newobject326["buttonType"] = "PushButton";
          //  oc_Newobject326["useMouseEvents"] = "0";
          //  oc_Newobject326["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

          //  #endregion

          //  oc_Newobject324["#Newobject326"] = oc_Newobject326;

          //  #region GuiTextCtrl ()        oc_Newobject327

          //  ObjectCreator oc_Newobject327 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject327["canSaveDynamicFields"] = "0";
          //  oc_Newobject327["Enabled"] = "1";
          //  oc_Newobject327["isContainer"] = "0";
          //  oc_Newobject327["Profile"] = "EditorTextProfile";
          //  oc_Newobject327["HorizSizing"] = "right";
          //  oc_Newobject327["VertSizing"] = "bottom";
          //  oc_Newobject327["position"] = "56 -3";
          //  oc_Newobject327["Extent"] = "72 18";
          //  oc_Newobject327["MinExtent"] = "8 2";
          //  oc_Newobject327["canSave"] = "1";
          //  oc_Newobject327["Visible"] = "1";
          //  oc_Newobject327["hovertime"] = "1000";
          //  oc_Newobject327["Margin"] = "0 0 0 0";
          //  oc_Newobject327["Padding"] = "0 0 0 0";
          //  oc_Newobject327["AnchorTop"] = "1";
          //  oc_Newobject327["AnchorBottom"] = "0";
          //  oc_Newobject327["AnchorLeft"] = "1";
          //  oc_Newobject327["AnchorRight"] = "0";
          //  oc_Newobject327["text"] = "Skin Forehead Map";
          //  oc_Newobject327["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject324["#Newobject327"] = oc_Newobject327;

          //  #region GuiTextCtrl ()        oc_Newobject328

          //  ObjectCreator oc_Newobject328 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject328["canSaveDynamicFields"] = "0";
          //  oc_Newobject328["internalName"] = "skinForeheadMapNameText";
          //  oc_Newobject328["Enabled"] = "1";
          //  oc_Newobject328["isContainer"] = "0";
          //  oc_Newobject328["Profile"] = "ToolsGuiTextProfile";
          //  oc_Newobject328["HorizSizing"] = "width";
          //  oc_Newobject328["VertSizing"] = "bottom";
          //  oc_Newobject328["position"] = "56 16";
          //  oc_Newobject328["Extent"] = "143 17";
          //  oc_Newobject328["MinExtent"] = "8 2";
          //  oc_Newobject328["canSave"] = "1";
          //  oc_Newobject328["Visible"] = "1";
          //  oc_Newobject328["hovertime"] = "1000";
          //  oc_Newobject328["Margin"] = "0 0 0 0";
          //  oc_Newobject328["Padding"] = "0 0 0 0";
          //  oc_Newobject328["AnchorTop"] = "1";
          //  oc_Newobject328["AnchorBottom"] = "0";
          //  oc_Newobject328["AnchorLeft"] = "1";
          //  oc_Newobject328["AnchorRight"] = "0";
          //  oc_Newobject328["text"] = "None";
          //  oc_Newobject328["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject324["#Newobject328"] = oc_Newobject328;

          //  #region GuiButtonCtrl ()        oc_Newobject329

          //  ObjectCreator oc_Newobject329 = new ObjectCreator("GuiButtonCtrl", "");
          //  oc_Newobject329["profile"] = "ToolsGuiButtonProfile";
          //  oc_Newobject329["text"] = "Edit";
          //  oc_Newobject329["HorizSizing"] = "left";
          //  oc_Newobject329["VertSizing"] = "bottom";
          //  oc_Newobject329["position"] = "134 34";
          //  oc_Newobject329["Extent"] = "40 16";
          //  oc_Newobject329["buttonType"] = "PushButton";
          //  oc_Newobject329["command"] = "MaterialEditorGui.updateTextureMap(\\\"skinForehead\\\", 1);";

          //  #endregion

          //  oc_Newobject324["#Newobject329"] = oc_Newobject329;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject330

          //  ObjectCreator oc_Newobject330 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject330["canSaveDynamicFields"] = "0";
          //  oc_Newobject330["Enabled"] = "1";
          //  oc_Newobject330["isContainer"] = "0";
          //  oc_Newobject330["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject330["HorizSizing"] = "left";
          //  oc_Newobject330["VertSizing"] = "bottom";
          //  oc_Newobject330["position"] = "177 34";
          //  oc_Newobject330["Extent"] = "16 16";
          //  oc_Newobject330["MinExtent"] = "8 2";
          //  oc_Newobject330["canSave"] = "1";
          //  oc_Newobject330["Visible"] = "1";
          //  oc_Newobject330["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinForehead\\\", 0);";
          //  oc_Newobject330["hovertime"] = "1000";
          //  oc_Newobject330["groupNum"] = "-1";
          //  oc_Newobject330["buttonType"] = "PushButton";
          //  oc_Newobject330["useMouseEvents"] = "0";
          //  oc_Newobject330["bitmap"] = "tools/gui/images/delete";

          //  #endregion

          //  oc_Newobject324["#Newobject330"] = oc_Newobject330;

          //  #endregion

          //  oc_Newobject301["#Newobject324"] = oc_Newobject324;

          //  #region GuiContainer ()        oc_Newobject331

          //  ObjectCreator oc_Newobject331 = new ObjectCreator("GuiContainer", "");
          //  oc_Newobject331["profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject331["isContainer"] = "1";
          //  oc_Newobject331["position"] = "6 136";
          //  oc_Newobject331["Extent"] = "185 52";
          //  oc_Newobject331["HorizSizing"] = "width";

          //  #region GuiBitmapCtrl ()        oc_Newobject332

          //  ObjectCreator oc_Newobject332 = new ObjectCreator("GuiBitmapCtrl", "");
          //  oc_Newobject332["canSaveDynamicFields"] = "0";
          //  oc_Newobject332["internalName"] = "skinNoseMapDisplayBitmap";
          //  oc_Newobject332["Enabled"] = "1";
          //  oc_Newobject332["isContainer"] = "0";
          //  oc_Newobject332["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject332["HorizSizing"] = "right";
          //  oc_Newobject332["VertSizing"] = "bottom";
          //  oc_Newobject332["position"] = "1 1";
          //  oc_Newobject332["Extent"] = "48 48";
          //  oc_Newobject332["MinExtent"] = "8 2";
          //  oc_Newobject332["canSave"] = "1";
          //  oc_Newobject332["Visible"] = "1";
          //  oc_Newobject332["hovertime"] = "1000";
          //  oc_Newobject332["bitmap"] = "tools/materialeditor/gui/unknownImage";
          //  oc_Newobject332["wrap"] = "0";

          //  #endregion

          //  oc_Newobject331["#Newobject332"] = oc_Newobject332;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject333

          //  ObjectCreator oc_Newobject333 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject333["canSaveDynamicFields"] = "0";
          //  oc_Newobject333["Enabled"] = "1";
          //  oc_Newobject333["isContainer"] = "0";
          //  oc_Newobject333["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject333["HorizSizing"] = "right";
          //  oc_Newobject333["VertSizing"] = "bottom";
          //  oc_Newobject333["position"] = "1 1";
          //  oc_Newobject333["Extent"] = "48 48";
          //  oc_Newobject333["MinExtent"] = "8 2";
          //  oc_Newobject333["canSave"] = "1";
          //  oc_Newobject333["Visible"] = "1";
          //  oc_Newobject333["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinNose\\\", 1);";
          //  oc_Newobject333["tooltipprofile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject333["ToolTip"] = "Change the active Skin Nose Map for this layer.";
          //  oc_Newobject333["hovertime"] = "1000";
          //  oc_Newobject333["groupNum"] = "-1";
          //  oc_Newobject333["buttonType"] = "PushButton";
          //  oc_Newobject333["useMouseEvents"] = "0";
          //  oc_Newobject333["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

          //  #endregion

          //  oc_Newobject331["#Newobject333"] = oc_Newobject333;

          //  #region GuiTextCtrl ()        oc_Newobject334

          //  ObjectCreator oc_Newobject334 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject334["canSaveDynamicFields"] = "0";
          //  oc_Newobject334["Enabled"] = "1";
          //  oc_Newobject334["isContainer"] = "0";
          //  oc_Newobject334["Profile"] = "EditorTextProfile";
          //  oc_Newobject334["HorizSizing"] = "right";
          //  oc_Newobject334["VertSizing"] = "bottom";
          //  oc_Newobject334["position"] = "56 -3";
          //  oc_Newobject334["Extent"] = "72 18";
          //  oc_Newobject334["MinExtent"] = "8 2";
          //  oc_Newobject334["canSave"] = "1";
          //  oc_Newobject334["Visible"] = "1";
          //  oc_Newobject334["hovertime"] = "1000";
          //  oc_Newobject334["Margin"] = "0 0 0 0";
          //  oc_Newobject334["Padding"] = "0 0 0 0";
          //  oc_Newobject334["AnchorTop"] = "1";
          //  oc_Newobject334["AnchorBottom"] = "0";
          //  oc_Newobject334["AnchorLeft"] = "1";
          //  oc_Newobject334["AnchorRight"] = "0";
          //  oc_Newobject334["text"] = "Skin Nose Map";
          //  oc_Newobject334["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject331["#Newobject334"] = oc_Newobject334;

          //  #region GuiTextCtrl ()        oc_Newobject335

          //  ObjectCreator oc_Newobject335 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject335["canSaveDynamicFields"] = "0";
          //  oc_Newobject335["internalName"] = "skinNoseMapNameText";
          //  oc_Newobject335["Enabled"] = "1";
          //  oc_Newobject335["isContainer"] = "0";
          //  oc_Newobject335["Profile"] = "ToolsGuiTextProfile";
          //  oc_Newobject335["HorizSizing"] = "width";
          //  oc_Newobject335["VertSizing"] = "bottom";
          //  oc_Newobject335["position"] = "56 16";
          //  oc_Newobject335["Extent"] = "143 17";
          //  oc_Newobject335["MinExtent"] = "8 2";
          //  oc_Newobject335["canSave"] = "1";
          //  oc_Newobject335["Visible"] = "1";
          //  oc_Newobject335["hovertime"] = "1000";
          //  oc_Newobject335["Margin"] = "0 0 0 0";
          //  oc_Newobject335["Padding"] = "0 0 0 0";
          //  oc_Newobject335["AnchorTop"] = "1";
          //  oc_Newobject335["AnchorBottom"] = "0";
          //  oc_Newobject335["AnchorLeft"] = "1";
          //  oc_Newobject335["AnchorRight"] = "0";
          //  oc_Newobject335["text"] = "None";
          //  oc_Newobject335["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject331["#Newobject335"] = oc_Newobject335;

          //  #region GuiButtonCtrl ()        oc_Newobject336

          //  ObjectCreator oc_Newobject336 = new ObjectCreator("GuiButtonCtrl", "");
          //  oc_Newobject336["profile"] = "ToolsGuiButtonProfile";
          //  oc_Newobject336["text"] = "Edit";
          //  oc_Newobject336["HorizSizing"] = "left";
          //  oc_Newobject336["VertSizing"] = "bottom";
          //  oc_Newobject336["position"] = "134 34";
          //  oc_Newobject336["Extent"] = "40 16";
          //  oc_Newobject336["buttonType"] = "PushButton";
          //  oc_Newobject336["command"] = "MaterialEditorGui.updateTextureMap(\\\"skinNose\\\", 1);";

          //  #endregion

          //  oc_Newobject331["#Newobject336"] = oc_Newobject336;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject337

          //  ObjectCreator oc_Newobject337 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject337["canSaveDynamicFields"] = "0";
          //  oc_Newobject337["Enabled"] = "1";
          //  oc_Newobject337["isContainer"] = "0";
          //  oc_Newobject337["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject337["HorizSizing"] = "left";
          //  oc_Newobject337["VertSizing"] = "bottom";
          //  oc_Newobject337["position"] = "177 34";
          //  oc_Newobject337["Extent"] = "16 16";
          //  oc_Newobject337["MinExtent"] = "8 2";
          //  oc_Newobject337["canSave"] = "1";
          //  oc_Newobject337["Visible"] = "1";
          //  oc_Newobject337["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinNose\\\", 0);";
          //  oc_Newobject337["hovertime"] = "1000";
          //  oc_Newobject337["groupNum"] = "-1";
          //  oc_Newobject337["buttonType"] = "PushButton";
          //  oc_Newobject337["useMouseEvents"] = "0";
          //  oc_Newobject337["bitmap"] = "tools/gui/images/delete";

          //  #endregion

          //  oc_Newobject331["#Newobject337"] = oc_Newobject337;

          //  #endregion

          //  oc_Newobject301["#Newobject331"] = oc_Newobject331;

          //  #region GuiContainer ()        oc_Newobject338

          //  ObjectCreator oc_Newobject338 = new ObjectCreator("GuiContainer", "");
          //  oc_Newobject338["profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject338["isContainer"] = "1";
          //  oc_Newobject338["position"] = "6 136";
          //  oc_Newobject338["Extent"] = "185 52";
          //  oc_Newobject338["HorizSizing"] = "width";

          //  #region GuiBitmapCtrl ()        oc_Newobject339

          //  ObjectCreator oc_Newobject339 = new ObjectCreator("GuiBitmapCtrl", "");
          //  oc_Newobject339["canSaveDynamicFields"] = "0";
          //  oc_Newobject339["internalName"] = "skinCheekMapDisplayBitmap";
          //  oc_Newobject339["Enabled"] = "1";
          //  oc_Newobject339["isContainer"] = "0";
          //  oc_Newobject339["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject339["HorizSizing"] = "right";
          //  oc_Newobject339["VertSizing"] = "bottom";
          //  oc_Newobject339["position"] = "1 1";
          //  oc_Newobject339["Extent"] = "48 48";
          //  oc_Newobject339["MinExtent"] = "8 2";
          //  oc_Newobject339["canSave"] = "1";
          //  oc_Newobject339["Visible"] = "1";
          //  oc_Newobject339["hovertime"] = "1000";
          //  oc_Newobject339["bitmap"] = "tools/materialeditor/gui/unknownImage";
          //  oc_Newobject339["wrap"] = "0";

          //  #endregion

          //  oc_Newobject338["#Newobject339"] = oc_Newobject339;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject340

          //  ObjectCreator oc_Newobject340 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject340["canSaveDynamicFields"] = "0";
          //  oc_Newobject340["Enabled"] = "1";
          //  oc_Newobject340["isContainer"] = "0";
          //  oc_Newobject340["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject340["HorizSizing"] = "right";
          //  oc_Newobject340["VertSizing"] = "bottom";
          //  oc_Newobject340["position"] = "1 1";
          //  oc_Newobject340["Extent"] = "48 48";
          //  oc_Newobject340["MinExtent"] = "8 2";
          //  oc_Newobject340["canSave"] = "1";
          //  oc_Newobject340["Visible"] = "1";
          //  oc_Newobject340["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinCheek\\\", 1);";
          //  oc_Newobject340["tooltipprofile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject340["ToolTip"] = "Change the active Skin Cheek Map for this layer.";
          //  oc_Newobject340["hovertime"] = "1000";
          //  oc_Newobject340["groupNum"] = "-1";
          //  oc_Newobject340["buttonType"] = "PushButton";
          //  oc_Newobject340["useMouseEvents"] = "0";
          //  oc_Newobject340["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

          //  #endregion

          //  oc_Newobject338["#Newobject340"] = oc_Newobject340;

          //  #region GuiTextCtrl ()        oc_Newobject341

          //  ObjectCreator oc_Newobject341 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject341["canSaveDynamicFields"] = "0";
          //  oc_Newobject341["Enabled"] = "1";
          //  oc_Newobject341["isContainer"] = "0";
          //  oc_Newobject341["Profile"] = "EditorTextProfile";
          //  oc_Newobject341["HorizSizing"] = "right";
          //  oc_Newobject341["VertSizing"] = "bottom";
          //  oc_Newobject341["position"] = "56 -3";
          //  oc_Newobject341["Extent"] = "72 18";
          //  oc_Newobject341["MinExtent"] = "8 2";
          //  oc_Newobject341["canSave"] = "1";
          //  oc_Newobject341["Visible"] = "1";
          //  oc_Newobject341["hovertime"] = "1000";
          //  oc_Newobject341["Margin"] = "0 0 0 0";
          //  oc_Newobject341["Padding"] = "0 0 0 0";
          //  oc_Newobject341["AnchorTop"] = "1";
          //  oc_Newobject341["AnchorBottom"] = "0";
          //  oc_Newobject341["AnchorLeft"] = "1";
          //  oc_Newobject341["AnchorRight"] = "0";
          //  oc_Newobject341["text"] = "Skin Cheek Map";
          //  oc_Newobject341["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject338["#Newobject341"] = oc_Newobject341;

          //  #region GuiTextCtrl ()        oc_Newobject342

          //  ObjectCreator oc_Newobject342 = new ObjectCreator("GuiTextCtrl", "");
          //  oc_Newobject342["canSaveDynamicFields"] = "0";
          //  oc_Newobject342["internalName"] = "skinCheekMapNameText";
          //  oc_Newobject342["Enabled"] = "1";
          //  oc_Newobject342["isContainer"] = "0";
          //  oc_Newobject342["Profile"] = "ToolsGuiTextProfile";
          //  oc_Newobject342["HorizSizing"] = "width";
          //  oc_Newobject342["VertSizing"] = "bottom";
          //  oc_Newobject342["position"] = "56 16";
          //  oc_Newobject342["Extent"] = "143 17";
          //  oc_Newobject342["MinExtent"] = "8 2";
          //  oc_Newobject342["canSave"] = "1";
          //  oc_Newobject342["Visible"] = "1";
          //  oc_Newobject342["hovertime"] = "1000";
          //  oc_Newobject342["Margin"] = "0 0 0 0";
          //  oc_Newobject342["Padding"] = "0 0 0 0";
          //  oc_Newobject342["AnchorTop"] = "1";
          //  oc_Newobject342["AnchorBottom"] = "0";
          //  oc_Newobject342["AnchorLeft"] = "1";
          //  oc_Newobject342["AnchorRight"] = "0";
          //  oc_Newobject342["text"] = "None";
          //  oc_Newobject342["maxLength"] = "1024";

          //  #endregion

          //  oc_Newobject338["#Newobject342"] = oc_Newobject342;

          //  #region GuiButtonCtrl ()        oc_Newobject343

          //  ObjectCreator oc_Newobject343 = new ObjectCreator("GuiButtonCtrl", "");
          //  oc_Newobject343["profile"] = "ToolsGuiButtonProfile";
          //  oc_Newobject343["text"] = "Edit";
          //  oc_Newobject343["HorizSizing"] = "left";
          //  oc_Newobject343["VertSizing"] = "bottom";
          //  oc_Newobject343["position"] = "134 34";
          //  oc_Newobject343["Extent"] = "40 16";
          //  oc_Newobject343["buttonType"] = "PushButton";
          //  oc_Newobject343["command"] = "MaterialEditorGui.updateTextureMap(\\\"skinCheek\\\", 1);";

          //  #endregion

          //  oc_Newobject338["#Newobject343"] = oc_Newobject343;

          //  #region GuiBitmapButtonCtrl ()        oc_Newobject344

          //  ObjectCreator oc_Newobject344 = new ObjectCreator("GuiBitmapButtonCtrl", "");
          //  oc_Newobject344["canSaveDynamicFields"] = "0";
          //  oc_Newobject344["Enabled"] = "1";
          //  oc_Newobject344["isContainer"] = "0";
          //  oc_Newobject344["Profile"] = "ToolsGuiDefaultProfile";
          //  oc_Newobject344["HorizSizing"] = "left";
          //  oc_Newobject344["VertSizing"] = "bottom";
          //  oc_Newobject344["position"] = "177 34";
          //  oc_Newobject344["Extent"] = "16 16";
          //  oc_Newobject344["MinExtent"] = "8 2";
          //  oc_Newobject344["canSave"] = "1";
          //  oc_Newobject344["Visible"] = "1";
          //  oc_Newobject344["Command"] = "MaterialEditorGui.updateTextureMap(\\\"skinCheek\\\", 0);";
          //  oc_Newobject344["hovertime"] = "1000";
          //  oc_Newobject344["groupNum"] = "-1";
          //  oc_Newobject344["buttonType"] = "PushButton";
          //  oc_Newobject344["useMouseEvents"] = "0";
          //  oc_Newobject344["bitmap"] = "tools/gui/images/delete";

          //  #endregion

          //  oc_Newobject338["#Newobject344"] = oc_Newobject344;

          //  #endregion

          //  oc_Newobject301["#Newobject338"] = oc_Newobject338;

          //  #endregion

          //  oc_Newobject300["#Newobject301"] = oc_Newobject301;

          //  #endregion

          //  oc_Newobject212["#Newobject300"] = oc_Newobject300;

            #region GuiRolloutCtrl (advancedTextureMapsRollout)        oc_Newobject93

            ObjectCreator oc_Newobject93 = new ObjectCreator("GuiRolloutCtrl", "advancedTextureMapsRollout");
            oc_Newobject93["class"] = "BehaviorQuickEditRollout";
            oc_Newobject93["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject93["Profile"] = "GuiRolloutProfile";
            oc_Newobject93["HorizSizing"] = "width";
            oc_Newobject93["VertSizing"] = "bottom";
            oc_Newobject93["Position"] = "0 0";
            oc_Newobject93["Extent"] = "185 0";
            oc_Newobject93["Caption"] = "Advanced Texture Maps";
            oc_Newobject93["Expanded"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject93["Margin"] = "4 4 4 0";
            oc_Newobject93["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject93["container"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject93["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
            oc_Newobject93["object"] = new ObjectCreator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject92

            ObjectCreator oc_Newobject92 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject92["StackingType"] = "Vertical";
            oc_Newobject92["HorizStacking"] = "Left to Right";
            oc_Newobject92["VertStacking"] = "Top to Bottom";
            oc_Newobject92["Padding"] = "0";
            oc_Newobject92["canSaveDynamicFields"] = "0";
            oc_Newobject92["Enabled"] = "1";
            oc_Newobject92["isContainer"] = "1";
            oc_Newobject92["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject92["HorizSizing"] = "width";
            oc_Newobject92["VertSizing"] = "bottom";
            oc_Newobject92["Position"] = "1 3";
            oc_Newobject92["Extent"] = "185 16";
            oc_Newobject92["MinExtent"] = "16 16";
            oc_Newobject92["canSave"] = "1";
            oc_Newobject92["isDecoy"] = "0";
            oc_Newobject92["Visible"] = "1";
            oc_Newobject92["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject92["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiContainer", "");
            oc_Newobject49["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject49["isContainer"] = "1";
            oc_Newobject49["position"] = "6 193";
            oc_Newobject49["Extent"] = "185 52";
            oc_Newobject49["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["internalName"] = "detailMapDisplayBitmap";
            oc_Newobject41["Enabled"] = "1";
            oc_Newobject41["isContainer"] = "0";
            oc_Newobject41["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["position"] = "1 1";
            oc_Newobject41["Extent"] = "48 48";
            oc_Newobject41["MinExtent"] = "8 2";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject41["wrap"] = "0";

            #endregion

            oc_Newobject49["#Newobject41"] = oc_Newobject41;

            #region GuiBitmapButtonCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject42["canSaveDynamicFields"] = "0";
            oc_Newobject42["Enabled"] = "1";
            oc_Newobject42["isContainer"] = "0";
            oc_Newobject42["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject42["HorizSizing"] = "right";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["position"] = "1 1";
            oc_Newobject42["Extent"] = "48 48";
            oc_Newobject42["MinExtent"] = "8 2";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["Command"] = "MaterialEditorGui.updateTextureMap(\\\"detail\\\", 1);";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject42["ToolTip"] = "Change the active Detail Map for this layer.";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["groupNum"] = "-1";
            oc_Newobject42["buttonType"] = "PushButton";
            oc_Newobject42["useMouseEvents"] = "0";
            oc_Newobject42["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject49["#Newobject42"] = oc_Newobject42;

            #region GuiTextCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject43["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject43["position"] = "56 34";
            oc_Newobject43["Extent"] = "29 16";
            oc_Newobject43["text"] = "Scale";

            #endregion

            oc_Newobject49["#Newobject43"] = oc_Newobject43;

            #region GuiTextEditCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject44["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject44["internalName"] = "detailScaleTextEdit";
            oc_Newobject44["position"] = "87 33";
            oc_Newobject44["Extent"] = "28 18";
            oc_Newobject44["text"] = "0";
            oc_Newobject44["maxLength"] = "2";
            oc_Newobject44["AltCommand"] = "MaterialEditorGui.updateDetailScale($ThisControl.getText());";

            #endregion

            oc_Newobject49["#Newobject44"] = oc_Newobject44;

            #region GuiTextCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["Enabled"] = "1";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["Profile"] = "EditorTextProfile";
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["position"] = "56 -3";
            oc_Newobject45["Extent"] = "72 18";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["Margin"] = "0 0 0 0";
            oc_Newobject45["Padding"] = "0 0 0 0";
            oc_Newobject45["AnchorTop"] = "1";
            oc_Newobject45["AnchorBottom"] = "0";
            oc_Newobject45["AnchorLeft"] = "1";
            oc_Newobject45["AnchorRight"] = "0";
            oc_Newobject45["text"] = "Detail Map";
            oc_Newobject45["maxLength"] = "1024";

            #endregion

            oc_Newobject49["#Newobject45"] = oc_Newobject45;

            #region GuiTextCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject46["canSaveDynamicFields"] = "0";
            oc_Newobject46["internalName"] = "detailMapNameText";
            oc_Newobject46["Enabled"] = "1";
            oc_Newobject46["isContainer"] = "0";
            oc_Newobject46["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["position"] = "56 16";
            oc_Newobject46["Extent"] = "143 17";
            oc_Newobject46["MinExtent"] = "8 2";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["Visible"] = "1";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["Margin"] = "0 0 0 0";
            oc_Newobject46["Padding"] = "0 0 0 0";
            oc_Newobject46["AnchorTop"] = "1";
            oc_Newobject46["AnchorBottom"] = "0";
            oc_Newobject46["AnchorLeft"] = "1";
            oc_Newobject46["AnchorRight"] = "0";
            oc_Newobject46["text"] = "None";
            oc_Newobject46["maxLength"] = "1024";

            #endregion

            oc_Newobject49["#Newobject46"] = oc_Newobject46;

            #region GuiButtonCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject47["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject47["text"] = "Edit";
            oc_Newobject47["HorizSizing"] = "left";
            oc_Newobject47["VertSizing"] = "bottom";
            oc_Newobject47["position"] = "134 34";
            oc_Newobject47["Extent"] = "40 16";
            oc_Newobject47["buttonType"] = "PushButton";
            oc_Newobject47["command"] = "MaterialEditorGui.updateTextureMap(\\\"detail\\\", 1);";

            #endregion

            oc_Newobject49["#Newobject47"] = oc_Newobject47;

            #region GuiBitmapButtonCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject48["canSaveDynamicFields"] = "0";
            oc_Newobject48["Enabled"] = "1";
            oc_Newobject48["isContainer"] = "0";
            oc_Newobject48["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject48["HorizSizing"] = "left";
            oc_Newobject48["VertSizing"] = "bottom";
            oc_Newobject48["position"] = "177 34";
            oc_Newobject48["Extent"] = "16 16";
            oc_Newobject48["MinExtent"] = "8 2";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["Visible"] = "1";
            oc_Newobject48["Command"] = "MaterialEditorGui.updateTextureMap(\\\"detail\\\", 0);";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["groupNum"] = "-1";
            oc_Newobject48["buttonType"] = "PushButton";
            oc_Newobject48["useMouseEvents"] = "0";
            oc_Newobject48["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject49["#Newobject48"] = oc_Newobject48;

            #endregion

            oc_Newobject92["#Newobject49"] = oc_Newobject49;

            #region GuiBitmapCtrl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject50["position"] = "6 246";
            oc_Newobject50["extent"] = "175 2";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject92["#Newobject50"] = oc_Newobject50;

            #region GuiContainer ()        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiContainer", "");
            oc_Newobject59["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject59["isContainer"] = "1";
            oc_Newobject59["position"] = "6 136";
            oc_Newobject59["Extent"] = "185 52";
            oc_Newobject59["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["internalName"] = "detailNormalMapDisplayBitmap";
            oc_Newobject51["Enabled"] = "1";
            oc_Newobject51["isContainer"] = "0";
            oc_Newobject51["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject51["HorizSizing"] = "right";
            oc_Newobject51["VertSizing"] = "bottom";
            oc_Newobject51["position"] = "1 1";
            oc_Newobject51["Extent"] = "48 48";
            oc_Newobject51["MinExtent"] = "8 2";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject51["wrap"] = "0";

            #endregion

            oc_Newobject59["#Newobject51"] = oc_Newobject51;

            #region GuiBitmapButtonCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["Enabled"] = "1";
            oc_Newobject52["isContainer"] = "0";
            oc_Newobject52["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject52["HorizSizing"] = "right";
            oc_Newobject52["VertSizing"] = "bottom";
            oc_Newobject52["position"] = "1 1";
            oc_Newobject52["Extent"] = "48 48";
            oc_Newobject52["MinExtent"] = "8 2";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["Visible"] = "1";
            oc_Newobject52["Command"] = "MaterialEditorGui.updateTextureMap(\\\"detailNormal\\\", 1);";
            oc_Newobject52["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject52["ToolTip"] = "Change the active DetailNormal Map for this layer.";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["groupNum"] = "-1";
            oc_Newobject52["buttonType"] = "PushButton";
            oc_Newobject52["useMouseEvents"] = "0";
            oc_Newobject52["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject59["#Newobject52"] = oc_Newobject52;

            #region GuiTextCtrl ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject53["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject53["position"] = "56 34";
            oc_Newobject53["Extent"] = "29 16";
            oc_Newobject53["text"] = "Strength";

            #endregion

            oc_Newobject59["#Newobject53"] = oc_Newobject53;

            #region GuiTextEditCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject54["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject54["internalName"] = "detailNormalStrengthTextEdit";
            oc_Newobject54["position"] = "87 33";
            oc_Newobject54["Extent"] = "28 18";
            oc_Newobject54["text"] = "0";
            oc_Newobject54["maxLength"] = "3";
            oc_Newobject54["AltCommand"] = "MaterialEditorGui.updateDetailNormalStrength($ThisControl.getText());";

            #endregion

            oc_Newobject59["#Newobject54"] = oc_Newobject54;

            #region GuiTextCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["Enabled"] = "1";
            oc_Newobject55["isContainer"] = "0";
            oc_Newobject55["Profile"] = "EditorTextProfile";
            oc_Newobject55["HorizSizing"] = "right";
            oc_Newobject55["VertSizing"] = "bottom";
            oc_Newobject55["position"] = "56 -3";
            oc_Newobject55["Extent"] = "72 18";
            oc_Newobject55["MinExtent"] = "8 2";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["Margin"] = "0 0 0 0";
            oc_Newobject55["Padding"] = "0 0 0 0";
            oc_Newobject55["AnchorTop"] = "1";
            oc_Newobject55["AnchorBottom"] = "0";
            oc_Newobject55["AnchorLeft"] = "1";
            oc_Newobject55["AnchorRight"] = "0";
            oc_Newobject55["text"] = "Detail Normal Map";
            oc_Newobject55["maxLength"] = "1024";

            #endregion

            oc_Newobject59["#Newobject55"] = oc_Newobject55;

            #region GuiTextCtrl ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject56["canSaveDynamicFields"] = "0";
            oc_Newobject56["internalName"] = "detailNormalMapNameText";
            oc_Newobject56["Enabled"] = "1";
            oc_Newobject56["isContainer"] = "0";
            oc_Newobject56["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject56["HorizSizing"] = "width";
            oc_Newobject56["VertSizing"] = "bottom";
            oc_Newobject56["position"] = "56 16";
            oc_Newobject56["Extent"] = "143 17";
            oc_Newobject56["MinExtent"] = "8 2";
            oc_Newobject56["canSave"] = "1";
            oc_Newobject56["Visible"] = "1";
            oc_Newobject56["hovertime"] = "1000";
            oc_Newobject56["Margin"] = "0 0 0 0";
            oc_Newobject56["Padding"] = "0 0 0 0";
            oc_Newobject56["AnchorTop"] = "1";
            oc_Newobject56["AnchorBottom"] = "0";
            oc_Newobject56["AnchorLeft"] = "1";
            oc_Newobject56["AnchorRight"] = "0";
            oc_Newobject56["text"] = "None";
            oc_Newobject56["maxLength"] = "1024";

            #endregion

            oc_Newobject59["#Newobject56"] = oc_Newobject56;

            #region GuiButtonCtrl ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject57["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject57["text"] = "Edit";
            oc_Newobject57["HorizSizing"] = "left";
            oc_Newobject57["VertSizing"] = "bottom";
            oc_Newobject57["position"] = "134 34";
            oc_Newobject57["Extent"] = "40 16";
            oc_Newobject57["buttonType"] = "PushButton";
            oc_Newobject57["command"] = "MaterialEditorGui.updateTextureMap(\\\"detailNormal\\\", 1);";

            #endregion

            oc_Newobject59["#Newobject57"] = oc_Newobject57;

            #region GuiBitmapButtonCtrl ()        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject58["canSaveDynamicFields"] = "0";
            oc_Newobject58["Enabled"] = "1";
            oc_Newobject58["isContainer"] = "0";
            oc_Newobject58["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject58["HorizSizing"] = "left";
            oc_Newobject58["VertSizing"] = "bottom";
            oc_Newobject58["position"] = "177 34";
            oc_Newobject58["Extent"] = "16 16";
            oc_Newobject58["MinExtent"] = "8 2";
            oc_Newobject58["canSave"] = "1";
            oc_Newobject58["Visible"] = "1";
            oc_Newobject58["Command"] = "MaterialEditorGui.updateTextureMap(\\\"detailNormal\\\", 0);";
            oc_Newobject58["hovertime"] = "1000";
            oc_Newobject58["groupNum"] = "-1";
            oc_Newobject58["buttonType"] = "PushButton";
            oc_Newobject58["useMouseEvents"] = "0";
            oc_Newobject58["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject59["#Newobject58"] = oc_Newobject58;

            #endregion

            oc_Newobject92["#Newobject59"] = oc_Newobject59;

            #region GuiBitmapCtrl ()        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject60["position"] = "6 189";
            oc_Newobject60["extent"] = "175 2";
            oc_Newobject60["HorizSizing"] = "width";
            oc_Newobject60["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject92["#Newobject60"] = oc_Newobject60;

            #region GuiContainer ()        oc_Newobject67

            ObjectCreator oc_Newobject67 = new ObjectCreator("GuiContainer", "");
            oc_Newobject67["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject67["isContainer"] = "1";
            oc_Newobject67["position"] = "6 136";
            oc_Newobject67["Extent"] = "185 52";
            oc_Newobject67["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject61["canSaveDynamicFields"] = "0";
            oc_Newobject61["internalName"] = "overlayMapDisplayBitmap";
            oc_Newobject61["Enabled"] = "1";
            oc_Newobject61["isContainer"] = "0";
            oc_Newobject61["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject61["HorizSizing"] = "right";
            oc_Newobject61["VertSizing"] = "bottom";
            oc_Newobject61["position"] = "1 1";
            oc_Newobject61["Extent"] = "48 48";
            oc_Newobject61["MinExtent"] = "8 2";
            oc_Newobject61["canSave"] = "1";
            oc_Newobject61["Visible"] = "1";
            oc_Newobject61["hovertime"] = "1000";
            oc_Newobject61["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject61["wrap"] = "0";

            #endregion

            oc_Newobject67["#Newobject61"] = oc_Newobject61;

            #region GuiBitmapButtonCtrl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject62["canSaveDynamicFields"] = "0";
            oc_Newobject62["Enabled"] = "1";
            oc_Newobject62["isContainer"] = "0";
            oc_Newobject62["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject62["HorizSizing"] = "right";
            oc_Newobject62["VertSizing"] = "bottom";
            oc_Newobject62["position"] = "1 1";
            oc_Newobject62["Extent"] = "48 48";
            oc_Newobject62["MinExtent"] = "8 2";
            oc_Newobject62["canSave"] = "1";
            oc_Newobject62["Visible"] = "1";
            oc_Newobject62["Command"] = "MaterialEditorGui.updateTextureMap(\\\"overlay\\\", 1);";
            oc_Newobject62["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject62["ToolTip"] = "Change the active Overlay Map for this layer.";
            oc_Newobject62["hovertime"] = "1000";
            oc_Newobject62["groupNum"] = "-1";
            oc_Newobject62["buttonType"] = "PushButton";
            oc_Newobject62["useMouseEvents"] = "0";
            oc_Newobject62["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject67["#Newobject62"] = oc_Newobject62;

            #region GuiTextCtrl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject63["canSaveDynamicFields"] = "0";
            oc_Newobject63["Enabled"] = "1";
            oc_Newobject63["isContainer"] = "0";
            oc_Newobject63["Profile"] = "EditorTextProfile";
            oc_Newobject63["HorizSizing"] = "right";
            oc_Newobject63["VertSizing"] = "bottom";
            oc_Newobject63["position"] = "56 -3";
            oc_Newobject63["Extent"] = "72 18";
            oc_Newobject63["MinExtent"] = "8 2";
            oc_Newobject63["canSave"] = "1";
            oc_Newobject63["Visible"] = "1";
            oc_Newobject63["hovertime"] = "1000";
            oc_Newobject63["Margin"] = "0 0 0 0";
            oc_Newobject63["Padding"] = "0 0 0 0";
            oc_Newobject63["AnchorTop"] = "1";
            oc_Newobject63["AnchorBottom"] = "0";
            oc_Newobject63["AnchorLeft"] = "1";
            oc_Newobject63["AnchorRight"] = "0";
            oc_Newobject63["text"] = "Overlay Map";
            oc_Newobject63["maxLength"] = "1024";

            #endregion

            oc_Newobject67["#Newobject63"] = oc_Newobject63;

            #region GuiTextCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject64["canSaveDynamicFields"] = "0";
            oc_Newobject64["internalName"] = "overlayMapNameText";
            oc_Newobject64["Enabled"] = "1";
            oc_Newobject64["isContainer"] = "0";
            oc_Newobject64["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject64["HorizSizing"] = "width";
            oc_Newobject64["VertSizing"] = "bottom";
            oc_Newobject64["position"] = "56 16";
            oc_Newobject64["Extent"] = "143 17";
            oc_Newobject64["MinExtent"] = "8 2";
            oc_Newobject64["canSave"] = "1";
            oc_Newobject64["Visible"] = "1";
            oc_Newobject64["hovertime"] = "1000";
            oc_Newobject64["Margin"] = "0 0 0 0";
            oc_Newobject64["Padding"] = "0 0 0 0";
            oc_Newobject64["AnchorTop"] = "1";
            oc_Newobject64["AnchorBottom"] = "0";
            oc_Newobject64["AnchorLeft"] = "1";
            oc_Newobject64["AnchorRight"] = "0";
            oc_Newobject64["text"] = "None";
            oc_Newobject64["maxLength"] = "1024";

            #endregion

            oc_Newobject67["#Newobject64"] = oc_Newobject64;

            #region GuiButtonCtrl ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject65["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject65["text"] = "Edit";
            oc_Newobject65["HorizSizing"] = "left";
            oc_Newobject65["VertSizing"] = "bottom";
            oc_Newobject65["position"] = "134 34";
            oc_Newobject65["Extent"] = "40 16";
            oc_Newobject65["buttonType"] = "PushButton";
            oc_Newobject65["command"] = "MaterialEditorGui.updateTextureMap(\\\"overlay\\\", 1);";

            #endregion

            oc_Newobject67["#Newobject65"] = oc_Newobject65;

            #region GuiBitmapButtonCtrl ()        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject66["canSaveDynamicFields"] = "0";
            oc_Newobject66["Enabled"] = "1";
            oc_Newobject66["isContainer"] = "0";
            oc_Newobject66["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject66["HorizSizing"] = "left";
            oc_Newobject66["VertSizing"] = "bottom";
            oc_Newobject66["position"] = "177 34";
            oc_Newobject66["Extent"] = "16 16";
            oc_Newobject66["MinExtent"] = "8 2";
            oc_Newobject66["canSave"] = "1";
            oc_Newobject66["Visible"] = "1";
            oc_Newobject66["Command"] = "MaterialEditorGui.updateTextureMap(\\\"overlay\\\", 0);";
            oc_Newobject66["hovertime"] = "1000";
            oc_Newobject66["groupNum"] = "-1";
            oc_Newobject66["buttonType"] = "PushButton";
            oc_Newobject66["useMouseEvents"] = "0";
            oc_Newobject66["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject67["#Newobject66"] = oc_Newobject66;

            #endregion

            oc_Newobject92["#Newobject67"] = oc_Newobject67;

            #region GuiBitmapCtrl ()        oc_Newobject68

            ObjectCreator oc_Newobject68 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject68["position"] = "6 189";
            oc_Newobject68["extent"] = "175 2";
            oc_Newobject68["HorizSizing"] = "width";
            oc_Newobject68["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject92["#Newobject68"] = oc_Newobject68;

            #region GuiContainer ()        oc_Newobject75

            ObjectCreator oc_Newobject75 = new ObjectCreator("GuiContainer", "");
            oc_Newobject75["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject75["isContainer"] = "1";
            oc_Newobject75["position"] = "6 250";
            oc_Newobject75["Extent"] = "185 52";
            oc_Newobject75["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject69

            ObjectCreator oc_Newobject69 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject69["canSaveDynamicFields"] = "0";
            oc_Newobject69["internalName"] = "lightMapDisplayBitmap";
            oc_Newobject69["Enabled"] = "1";
            oc_Newobject69["isContainer"] = "0";
            oc_Newobject69["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject69["HorizSizing"] = "right";
            oc_Newobject69["VertSizing"] = "bottom";
            oc_Newobject69["position"] = "1 1";
            oc_Newobject69["Extent"] = "48 48";
            oc_Newobject69["MinExtent"] = "8 2";
            oc_Newobject69["canSave"] = "1";
            oc_Newobject69["Visible"] = "1";
            oc_Newobject69["hovertime"] = "1000";
            oc_Newobject69["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject69["wrap"] = "0";

            #endregion

            oc_Newobject75["#Newobject69"] = oc_Newobject69;

            #region GuiTextCtrl ()        oc_Newobject70

            ObjectCreator oc_Newobject70 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject70["canSaveDynamicFields"] = "0";
            oc_Newobject70["Enabled"] = "1";
            oc_Newobject70["isContainer"] = "0";
            oc_Newobject70["Profile"] = "EditorTextProfile";
            oc_Newobject70["HorizSizing"] = "right";
            oc_Newobject70["VertSizing"] = "bottom";
            oc_Newobject70["position"] = "56 -3";
            oc_Newobject70["Extent"] = "72 18";
            oc_Newobject70["MinExtent"] = "8 2";
            oc_Newobject70["canSave"] = "1";
            oc_Newobject70["Visible"] = "1";
            oc_Newobject70["hovertime"] = "1000";
            oc_Newobject70["Margin"] = "0 0 0 0";
            oc_Newobject70["Padding"] = "0 0 0 0";
            oc_Newobject70["AnchorTop"] = "1";
            oc_Newobject70["AnchorBottom"] = "0";
            oc_Newobject70["AnchorLeft"] = "1";
            oc_Newobject70["AnchorRight"] = "0";
            oc_Newobject70["text"] = "Light Map";
            oc_Newobject70["maxLength"] = "1024";

            #endregion

            oc_Newobject75["#Newobject70"] = oc_Newobject70;

            #region GuiBitmapButtonCtrl ()        oc_Newobject71

            ObjectCreator oc_Newobject71 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject71["canSaveDynamicFields"] = "0";
            oc_Newobject71["Enabled"] = "1";
            oc_Newobject71["isContainer"] = "0";
            oc_Newobject71["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject71["HorizSizing"] = "right";
            oc_Newobject71["VertSizing"] = "bottom";
            oc_Newobject71["position"] = "1 1";
            oc_Newobject71["Extent"] = "48 48";
            oc_Newobject71["MinExtent"] = "8 2";
            oc_Newobject71["canSave"] = "1";
            oc_Newobject71["Visible"] = "1";
            oc_Newobject71["Command"] = "MaterialEditorGui.updateTextureMap(\\\"light\\\", 1);";
            oc_Newobject71["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject71["ToolTip"] = "Change the active light Map for this layer.";
            oc_Newobject71["hovertime"] = "1000";
            oc_Newobject71["groupNum"] = "-1";
            oc_Newobject71["buttonType"] = "PushButton";
            oc_Newobject71["useMouseEvents"] = "0";
            oc_Newobject71["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject75["#Newobject71"] = oc_Newobject71;

            #region GuiTextCtrl ()        oc_Newobject72

            ObjectCreator oc_Newobject72 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject72["canSaveDynamicFields"] = "0";
            oc_Newobject72["internalName"] = "lightMapNameText";
            oc_Newobject72["Enabled"] = "1";
            oc_Newobject72["isContainer"] = "0";
            oc_Newobject72["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject72["HorizSizing"] = "width";
            oc_Newobject72["VertSizing"] = "bottom";
            oc_Newobject72["position"] = "56 16";
            oc_Newobject72["Extent"] = "143 17";
            oc_Newobject72["MinExtent"] = "8 2";
            oc_Newobject72["canSave"] = "1";
            oc_Newobject72["Visible"] = "1";
            oc_Newobject72["hovertime"] = "1000";
            oc_Newobject72["Margin"] = "0 0 0 0";
            oc_Newobject72["Padding"] = "0 0 0 0";
            oc_Newobject72["AnchorTop"] = "1";
            oc_Newobject72["AnchorBottom"] = "0";
            oc_Newobject72["AnchorLeft"] = "1";
            oc_Newobject72["AnchorRight"] = "0";
            oc_Newobject72["text"] = "None";
            oc_Newobject72["maxLength"] = "1024";

            #endregion

            oc_Newobject75["#Newobject72"] = oc_Newobject72;

            #region GuiButtonCtrl ()        oc_Newobject73

            ObjectCreator oc_Newobject73 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject73["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject73["text"] = "Edit";
            oc_Newobject73["HorizSizing"] = "left";
            oc_Newobject73["VertSizing"] = "bottom";
            oc_Newobject73["position"] = "134 34";
            oc_Newobject73["Extent"] = "40 16";
            oc_Newobject73["buttonType"] = "PushButton";
            oc_Newobject73["command"] = "MaterialEditorGui.updateTextureMap(\\\"light\\\", 1);";

            #endregion

            oc_Newobject75["#Newobject73"] = oc_Newobject73;

            #region GuiBitmapButtonCtrl ()        oc_Newobject74

            ObjectCreator oc_Newobject74 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject74["canSaveDynamicFields"] = "0";
            oc_Newobject74["Enabled"] = "1";
            oc_Newobject74["isContainer"] = "0";
            oc_Newobject74["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject74["HorizSizing"] = "left";
            oc_Newobject74["VertSizing"] = "bottom";
            oc_Newobject74["position"] = "177 34";
            oc_Newobject74["Extent"] = "16 16";
            oc_Newobject74["MinExtent"] = "8 2";
            oc_Newobject74["canSave"] = "1";
            oc_Newobject74["Visible"] = "1";
            oc_Newobject74["Command"] = "MaterialEditorGui.updateTextureMap(\\\"light\\\", 0);";
            oc_Newobject74["hovertime"] = "1000";
            oc_Newobject74["groupNum"] = "-1";
            oc_Newobject74["buttonType"] = "PushButton";
            oc_Newobject74["useMouseEvents"] = "0";
            oc_Newobject74["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject75["#Newobject74"] = oc_Newobject74;

            #endregion

            oc_Newobject92["#Newobject75"] = oc_Newobject75;

            #region GuiBitmapCtrl ()        oc_Newobject76

            ObjectCreator oc_Newobject76 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject76["position"] = "6 303";
            oc_Newobject76["extent"] = "175 2";
            oc_Newobject76["HorizSizing"] = "width";
            oc_Newobject76["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject92["#Newobject76"] = oc_Newobject76;

            #region GuiContainer ()        oc_Newobject83

            ObjectCreator oc_Newobject83 = new ObjectCreator("GuiContainer", "");
            oc_Newobject83["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject83["isContainer"] = "1";
            oc_Newobject83["position"] = "6 307";
            oc_Newobject83["Extent"] = "185 52";
            oc_Newobject83["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject77

            ObjectCreator oc_Newobject77 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject77["canSaveDynamicFields"] = "0";
            oc_Newobject77["internalName"] = "toneMapDisplayBitmap";
            oc_Newobject77["Enabled"] = "1";
            oc_Newobject77["isContainer"] = "0";
            oc_Newobject77["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject77["HorizSizing"] = "right";
            oc_Newobject77["VertSizing"] = "bottom";
            oc_Newobject77["position"] = "1 1";
            oc_Newobject77["Extent"] = "48 48";
            oc_Newobject77["MinExtent"] = "8 2";
            oc_Newobject77["canSave"] = "1";
            oc_Newobject77["Visible"] = "1";
            oc_Newobject77["hovertime"] = "1000";
            oc_Newobject77["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject77["wrap"] = "0";

            #endregion

            oc_Newobject83["#Newobject77"] = oc_Newobject77;

            #region GuiTextCtrl ()        oc_Newobject78

            ObjectCreator oc_Newobject78 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject78["canSaveDynamicFields"] = "0";
            oc_Newobject78["Enabled"] = "1";
            oc_Newobject78["isContainer"] = "0";
            oc_Newobject78["Profile"] = "EditorTextProfile";
            oc_Newobject78["HorizSizing"] = "right";
            oc_Newobject78["VertSizing"] = "bottom";
            oc_Newobject78["position"] = "56 -3";
            oc_Newobject78["Extent"] = "72 18";
            oc_Newobject78["MinExtent"] = "8 2";
            oc_Newobject78["canSave"] = "1";
            oc_Newobject78["Visible"] = "1";
            oc_Newobject78["hovertime"] = "1000";
            oc_Newobject78["Margin"] = "0 0 0 0";
            oc_Newobject78["Padding"] = "0 0 0 0";
            oc_Newobject78["AnchorTop"] = "1";
            oc_Newobject78["AnchorBottom"] = "0";
            oc_Newobject78["AnchorLeft"] = "1";
            oc_Newobject78["AnchorRight"] = "0";
            oc_Newobject78["text"] = "Tone Map";
            oc_Newobject78["maxLength"] = "1024";

            #endregion

            oc_Newobject83["#Newobject78"] = oc_Newobject78;

            #region GuiBitmapButtonCtrl ()        oc_Newobject79

            ObjectCreator oc_Newobject79 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject79["canSaveDynamicFields"] = "0";
            oc_Newobject79["Enabled"] = "1";
            oc_Newobject79["isContainer"] = "0";
            oc_Newobject79["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject79["HorizSizing"] = "right";
            oc_Newobject79["VertSizing"] = "bottom";
            oc_Newobject79["position"] = "1 1";
            oc_Newobject79["Extent"] = "48 48";
            oc_Newobject79["MinExtent"] = "8 2";
            oc_Newobject79["canSave"] = "1";
            oc_Newobject79["Visible"] = "1";
            oc_Newobject79["Command"] = "MaterialEditorGui.updateTextureMap(\\\"tone\\\", 1);";
            oc_Newobject79["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject79["ToolTip"] = "Change the active Tone Map for this layer.";
            oc_Newobject79["hovertime"] = "1000";
            oc_Newobject79["groupNum"] = "-1";
            oc_Newobject79["buttonType"] = "PushButton";
            oc_Newobject79["useMouseEvents"] = "0";
            oc_Newobject79["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject83["#Newobject79"] = oc_Newobject79;

            #region GuiTextCtrl ()        oc_Newobject80

            ObjectCreator oc_Newobject80 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject80["canSaveDynamicFields"] = "0";
            oc_Newobject80["internalName"] = "toneMapNameText";
            oc_Newobject80["Enabled"] = "1";
            oc_Newobject80["isContainer"] = "0";
            oc_Newobject80["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject80["HorizSizing"] = "width";
            oc_Newobject80["VertSizing"] = "bottom";
            oc_Newobject80["position"] = "56 16";
            oc_Newobject80["Extent"] = "143 17";
            oc_Newobject80["MinExtent"] = "8 2";
            oc_Newobject80["canSave"] = "1";
            oc_Newobject80["Visible"] = "1";
            oc_Newobject80["hovertime"] = "1000";
            oc_Newobject80["Margin"] = "0 0 0 0";
            oc_Newobject80["Padding"] = "0 0 0 0";
            oc_Newobject80["AnchorTop"] = "1";
            oc_Newobject80["AnchorBottom"] = "0";
            oc_Newobject80["AnchorLeft"] = "1";
            oc_Newobject80["AnchorRight"] = "0";
            oc_Newobject80["text"] = "None";
            oc_Newobject80["maxLength"] = "1024";

            #endregion

            oc_Newobject83["#Newobject80"] = oc_Newobject80;

            #region GuiButtonCtrl ()        oc_Newobject81

            ObjectCreator oc_Newobject81 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject81["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject81["text"] = "Edit";
            oc_Newobject81["HorizSizing"] = "left";
            oc_Newobject81["VertSizing"] = "bottom";
            oc_Newobject81["position"] = "134 34";
            oc_Newobject81["Extent"] = "40 16";
            oc_Newobject81["buttonType"] = "PushButton";
            oc_Newobject81["command"] = "MaterialEditorGui.updateTextureMap(\\\"tone\\\", 1);";

            #endregion

            oc_Newobject83["#Newobject81"] = oc_Newobject81;

            #region GuiBitmapButtonCtrl ()        oc_Newobject82

            ObjectCreator oc_Newobject82 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject82["canSaveDynamicFields"] = "0";
            oc_Newobject82["Enabled"] = "1";
            oc_Newobject82["isContainer"] = "0";
            oc_Newobject82["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject82["HorizSizing"] = "left";
            oc_Newobject82["VertSizing"] = "bottom";
            oc_Newobject82["position"] = "177 34";
            oc_Newobject82["Extent"] = "16 16";
            oc_Newobject82["MinExtent"] = "8 2";
            oc_Newobject82["canSave"] = "1";
            oc_Newobject82["Visible"] = "1";
            oc_Newobject82["Command"] = "MaterialEditorGui.updateTextureMap(\\\"tone\\\", 0);";
            oc_Newobject82["hovertime"] = "1000";
            oc_Newobject82["groupNum"] = "-1";
            oc_Newobject82["buttonType"] = "PushButton";
            oc_Newobject82["useMouseEvents"] = "0";
            oc_Newobject82["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject83["#Newobject82"] = oc_Newobject82;

            #endregion

            oc_Newobject92["#Newobject83"] = oc_Newobject83;

            #region GuiBitmapCtrl ()        oc_Newobject84

            ObjectCreator oc_Newobject84 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject84["position"] = "6 357";
            oc_Newobject84["extent"] = "175 2";
            oc_Newobject84["HorizSizing"] = "width";
            oc_Newobject84["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject92["#Newobject84"] = oc_Newobject84;

            #region GuiContainer ()        oc_Newobject91

            ObjectCreator oc_Newobject91 = new ObjectCreator("GuiContainer", "");
            oc_Newobject91["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject91["isContainer"] = "1";
            oc_Newobject91["position"] = "6 359";
            oc_Newobject91["Extent"] = "185 52";
            oc_Newobject91["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject85

            ObjectCreator oc_Newobject85 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject85["canSaveDynamicFields"] = "0";
            oc_Newobject85["internalName"] = "envMapDisplayBitmap";
            oc_Newobject85["Enabled"] = "1";
            oc_Newobject85["isContainer"] = "0";
            oc_Newobject85["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject85["HorizSizing"] = "right";
            oc_Newobject85["VertSizing"] = "bottom";
            oc_Newobject85["position"] = "1 1";
            oc_Newobject85["Extent"] = "48 48";
            oc_Newobject85["MinExtent"] = "8 2";
            oc_Newobject85["canSave"] = "1";
            oc_Newobject85["Visible"] = "1";
            oc_Newobject85["hovertime"] = "1000";
            oc_Newobject85["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject85["wrap"] = "0";

            #endregion

            oc_Newobject91["#Newobject85"] = oc_Newobject85;

            #region GuiTextCtrl ()        oc_Newobject86

            ObjectCreator oc_Newobject86 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject86["canSaveDynamicFields"] = "0";
            oc_Newobject86["Enabled"] = "1";
            oc_Newobject86["isContainer"] = "0";
            oc_Newobject86["Profile"] = "EditorTextProfile";
            oc_Newobject86["HorizSizing"] = "right";
            oc_Newobject86["VertSizing"] = "bottom";
            oc_Newobject86["position"] = "56 -3";
            oc_Newobject86["Extent"] = "72 18";
            oc_Newobject86["MinExtent"] = "8 2";
            oc_Newobject86["canSave"] = "1";
            oc_Newobject86["Visible"] = "1";
            oc_Newobject86["hovertime"] = "1000";
            oc_Newobject86["Margin"] = "0 0 0 0";
            oc_Newobject86["Padding"] = "0 0 0 0";
            oc_Newobject86["AnchorTop"] = "1";
            oc_Newobject86["AnchorBottom"] = "0";
            oc_Newobject86["AnchorLeft"] = "1";
            oc_Newobject86["AnchorRight"] = "0";
            oc_Newobject86["text"] = "Env Map";
            oc_Newobject86["maxLength"] = "1024";

            #endregion

            oc_Newobject91["#Newobject86"] = oc_Newobject86;

            #region GuiBitmapButtonCtrl ()        oc_Newobject87

            ObjectCreator oc_Newobject87 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject87["canSaveDynamicFields"] = "0";
            oc_Newobject87["Enabled"] = "1";
            oc_Newobject87["isContainer"] = "0";
            oc_Newobject87["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject87["HorizSizing"] = "right";
            oc_Newobject87["VertSizing"] = "bottom";
            oc_Newobject87["position"] = "1 1";
            oc_Newobject87["Extent"] = "48 48";
            oc_Newobject87["MinExtent"] = "8 2";
            oc_Newobject87["canSave"] = "1";
            oc_Newobject87["Visible"] = "1";
            oc_Newobject87["Command"] = "MaterialEditorGui.updateTextureMap(\\\"env\\\", 1);";
            oc_Newobject87["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject87["ToolTip"] = "Change the active Environment Map for this layer.";
            oc_Newobject87["hovertime"] = "1000";
            oc_Newobject87["groupNum"] = "-1";
            oc_Newobject87["buttonType"] = "PushButton";
            oc_Newobject87["useMouseEvents"] = "0";
            oc_Newobject87["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject91["#Newobject87"] = oc_Newobject87;

            #region GuiTextCtrl ()        oc_Newobject88

            ObjectCreator oc_Newobject88 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject88["canSaveDynamicFields"] = "0";
            oc_Newobject88["internalName"] = "envMapNameText";
            oc_Newobject88["Enabled"] = "1";
            oc_Newobject88["isContainer"] = "0";
            oc_Newobject88["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject88["HorizSizing"] = "width";
            oc_Newobject88["VertSizing"] = "bottom";
            oc_Newobject88["position"] = "56 16";
            oc_Newobject88["Extent"] = "143 17";
            oc_Newobject88["MinExtent"] = "8 2";
            oc_Newobject88["canSave"] = "1";
            oc_Newobject88["Visible"] = "1";
            oc_Newobject88["hovertime"] = "1000";
            oc_Newobject88["Margin"] = "0 0 0 0";
            oc_Newobject88["Padding"] = "0 0 0 0";
            oc_Newobject88["AnchorTop"] = "1";
            oc_Newobject88["AnchorBottom"] = "0";
            oc_Newobject88["AnchorLeft"] = "1";
            oc_Newobject88["AnchorRight"] = "0";
            oc_Newobject88["text"] = "None";
            oc_Newobject88["maxLength"] = "1024";

            #endregion

            oc_Newobject91["#Newobject88"] = oc_Newobject88;

            #region GuiButtonCtrl ()        oc_Newobject89

            ObjectCreator oc_Newobject89 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject89["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject89["text"] = "Edit";
            oc_Newobject89["HorizSizing"] = "left";
            oc_Newobject89["VertSizing"] = "bottom";
            oc_Newobject89["position"] = "134 34";
            oc_Newobject89["Extent"] = "40 16";
            oc_Newobject89["buttonType"] = "PushButton";
            oc_Newobject89["command"] = "MaterialEditorGui.updateTextureMap(\\\"env\\\", 1);";

            #endregion

            oc_Newobject91["#Newobject89"] = oc_Newobject89;

            #region GuiBitmapButtonCtrl ()        oc_Newobject90

            ObjectCreator oc_Newobject90 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject90["canSaveDynamicFields"] = "0";
            oc_Newobject90["Enabled"] = "1";
            oc_Newobject90["isContainer"] = "0";
            oc_Newobject90["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject90["HorizSizing"] = "left";
            oc_Newobject90["VertSizing"] = "bottom";
            oc_Newobject90["position"] = "177 34";
            oc_Newobject90["Extent"] = "16 16";
            oc_Newobject90["MinExtent"] = "8 2";
            oc_Newobject90["canSave"] = "1";
            oc_Newobject90["Visible"] = "1";
            oc_Newobject90["Command"] = "MaterialEditorGui.updateTextureMap(\\\"env\\\", 0);";
            oc_Newobject90["hovertime"] = "1000";
            oc_Newobject90["groupNum"] = "-1";
            oc_Newobject90["buttonType"] = "PushButton";
            oc_Newobject90["useMouseEvents"] = "0";
            oc_Newobject90["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject91["#Newobject90"] = oc_Newobject90;

            #endregion

            oc_Newobject92["#Newobject91"] = oc_Newobject91;

            #endregion

            oc_Newobject93["#Newobject92"] = oc_Newobject92;

            #endregion

            oc_Newobject212["#Newobject93"] = oc_Newobject93;

            #region GuiRolloutCtrl ()        oc_Newobject00027
            var oc_Newobject00027 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject00027["class"] = "BehaviorQuickEditRollout";
            oc_Newobject00027["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject00027["Profile"] = "GuiRolloutProfile";
            oc_Newobject00027["HorizSizing"] = "width";
            oc_Newobject00027["VertSizing"] = "bottom";
            oc_Newobject00027["Position"] = "0 0";
            oc_Newobject00027["Extent"] = "195 0";
            oc_Newobject00027["Caption"] = "Accumulation Properties";
            oc_Newobject00027["Margin"] = "-1 0 0 0";
            oc_Newobject00027["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject00027["container"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject00027["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
            oc_Newobject00027["object"] = new ObjectCreator.StringNoQuote("%behavior");
            if (true)
            {

                #region GuiStackControl ()        oc_Newobject00026
                var oc_Newobject00026 = new ObjectCreator("GuiStackControl", "");
                oc_Newobject00026["StackingType"] = "Vertical";
                oc_Newobject00026["HorizStacking"] = "Left to Right";
                oc_Newobject00026["VertStacking"] = "Top to Bottom";
                oc_Newobject00026["Padding"] = "0";
                oc_Newobject00026["canSaveDynamicFields"] = "0";
                oc_Newobject00026["Enabled"] = "1";
                oc_Newobject00026["isContainer"] = "1";
                oc_Newobject00026["Profile"] = "GuiDefaultProfile";
                oc_Newobject00026["HorizSizing"] = "width";
                oc_Newobject00026["VertSizing"] = "bottom";
                oc_Newobject00026["Position"] = "1 3";
                oc_Newobject00026["Extent"] = "195 16";
                oc_Newobject00026["MinExtent"] = "16 16";
                oc_Newobject00026["canSave"] = "1";
                oc_Newobject00026["isDecoy"] = "0";
                oc_Newobject00026["Visible"] = "1";
                oc_Newobject00026["tooltipprofile"] = "GuiToolTipProfile";
                oc_Newobject00026["hovertime"] = "1000";
                if (true)
                {

                    #region GuiContainer ()        oc_Newobject00005
                    var oc_Newobject00005 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject00005["profile"] = "GuiTransparentProfile";
                    oc_Newobject00005["isContainer"] = "1";
                    oc_Newobject00005["position"] = "0 0";
                    oc_Newobject00005["Extent"] = "195 24";
                    oc_Newobject00005["HorizSizing"] = "width";
                    if (true)
                    {

                        #region GuiTextCtrl ()        oc_Newobject0001
                        var oc_Newobject0001 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject0001["canSaveDynamicFields"] = "0";
                        oc_Newobject0001["Enabled"] = "1";
                        oc_Newobject0001["isContainer"] = "0";
                        oc_Newobject0001["Profile"] = "GuiTextRightProfile";
                        oc_Newobject0001["HorizSizing"] = "right";
                        oc_Newobject0001["VertSizing"] = "bottom";
                        oc_Newobject0001["position"] = "8 3";
                        oc_Newobject0001["Extent"] = "54 16";
                        oc_Newobject0001["MinExtent"] = "8 2";
                        oc_Newobject0001["canSave"] = "1";
                        oc_Newobject0001["Visible"] = "1";
                        oc_Newobject0001["hovertime"] = "1000";
                        oc_Newobject0001["Margin"] = "0 0 0 0";
                        oc_Newobject0001["Padding"] = "0 0 0 0";
                        oc_Newobject0001["AnchorTop"] = "1";
                        oc_Newobject0001["AnchorBottom"] = "0";
                        oc_Newobject0001["AnchorLeft"] = "1";
                        oc_Newobject0001["AnchorRight"] = "0";
                        oc_Newobject0001["text"] = "Scale";
                        oc_Newobject0001["maxLength"] = "1024";
                        #endregion

                        oc_Newobject00005["#Newobject00001"] = oc_Newobject0001;

                        #region GuiControl ()        oc_Newobject0004
                        var oc_Newobject0004 = new ObjectCreator("GuiControl", "", typeof(AggregateControl));
                        //oc_Newobject0004["class"] = "AggregateControl";
                        oc_Newobject0004["position"] = "70 3";
                        oc_Newobject0004["Extent"] = "96 20";
                        if (true)
                        {

                            #region GuiSliderCtrl ()        oc_Newobject0002
                            var oc_Newobject0002 = new ObjectCreator("GuiSliderCtrl", "");
                            oc_Newobject0002["canSaveDynamicFields"] = "0";
                            oc_Newobject0002["internalName"] = "accuScaleSlider";
                            oc_Newobject0002["Enabled"] = "1";
                            oc_Newobject0002["isContainer"] = "0";
                            oc_Newobject0002["Profile"] = "GuiSliderProfile";
                            oc_Newobject0002["HorizSizing"] = "right";
                            oc_Newobject0002["VertSizing"] = "bottom";
                            oc_Newobject0002["position"] = "0 2";
                            oc_Newobject0002["Extent"] = "61 14";
                            oc_Newobject0002["MinExtent"] = "8 2";
                            oc_Newobject0002["canSave"] = "1";
                            oc_Newobject0002["Visible"] = "1";
                            oc_Newobject0002["Command"] = "MaterialEditorGui.updateActiveMaterial(\\\"accuScale[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, true);";
                            oc_Newobject0002["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuScale[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, false);";
                            oc_Newobject0002["tooltipprofile"] = "GuiDefaultProfile";
                            oc_Newobject0002["ToolTip"] = "Sets the scale of the accu map.";
                            oc_Newobject0002["hovertime"] = "1000";
                            oc_Newobject0002["range"] = "0.03125 32";
                            oc_Newobject0002["ticks"] = "0";
                            oc_Newobject0002["value"] = "1";
                            #endregion
                            oc_Newobject0004["#Newobject00002"] = oc_Newobject0002;

                            #region GuiTextEditCtrl ()        oc_Newobject0003
                            var oc_Newobject0003 = new ObjectCreator("GuiTextEditCtrl", "");
                            oc_Newobject0003["canSaveDynamicFields"] = "0";
                            oc_Newobject0003["internalName"] = "accuScaleTextEdit";
                            oc_Newobject0003["Enabled"] = "1";
                            oc_Newobject0003["isContainer"] = "0";
                            oc_Newobject0003["Profile"] = "GuiTextEditProfile";
                            oc_Newobject0003["HorizSizing"] = "right";
                            oc_Newobject0003["VertSizing"] = "bottom";
                            oc_Newobject0003["position"] = "64 0";
                            oc_Newobject0003["Extent"] = "29 18";
                            oc_Newobject0003["MinExtent"] = "8 2";
                            oc_Newobject0003["canSave"] = "1";
                            oc_Newobject0003["Visible"] = "1";
                            oc_Newobject0003["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuScale[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
                            oc_Newobject0003["hovertime"] = "1000";
                            oc_Newobject0003["AnchorTop"] = "1";
                            oc_Newobject0003["AnchorBottom"] = "0";
                            oc_Newobject0003["AnchorLeft"] = "1";
                            oc_Newobject0003["AnchorRight"] = "0";
                            oc_Newobject0003["text"] = "1";
                            oc_Newobject0003["maxLength"] = "3";
                            #endregion

                            oc_Newobject0004["#Newobject00003"] = oc_Newobject0003;

                        }
                        #endregion

                        oc_Newobject00005["#Newobject00004"] = oc_Newobject0004;

                    }
                    #endregion

                    oc_Newobject00026["#Newobject00005"] = oc_Newobject00005;

                    #region GuiContainer ()        oc_Newobject00010
                    var oc_Newobject00010 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject00010["profile"] = "GuiTransparentProfile";
                    oc_Newobject00010["isContainer"] = "1";
                    oc_Newobject00010["position"] = "0 0";
                    oc_Newobject00010["Extent"] = "195 24";
                    oc_Newobject00010["HorizSizing"] = "width";
                    if (true)
                    {

                        #region GuiTextCtrl ()        oc_Newobject00006
                        var oc_Newobject00006 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00006["canSaveDynamicFields"] = "0";
                        oc_Newobject00006["Enabled"] = "1";
                        oc_Newobject00006["isContainer"] = "0";
                        oc_Newobject00006["Profile"] = "GuiTextRightProfile";
                        oc_Newobject00006["HorizSizing"] = "right";
                        oc_Newobject00006["VertSizing"] = "bottom";
                        oc_Newobject00006["position"] = "8 3";
                        oc_Newobject00006["Extent"] = "54 16";
                        oc_Newobject00006["MinExtent"] = "8 2";
                        oc_Newobject00006["canSave"] = "1";
                        oc_Newobject00006["Visible"] = "1";
                        oc_Newobject00006["hovertime"] = "1000";
                        oc_Newobject00006["Margin"] = "0 0 0 0";
                        oc_Newobject00006["Padding"] = "0 0 0 0";
                        oc_Newobject00006["AnchorTop"] = "1";
                        oc_Newobject00006["AnchorBottom"] = "0";
                        oc_Newobject00006["AnchorLeft"] = "1";
                        oc_Newobject00006["AnchorRight"] = "0";
                        oc_Newobject00006["text"] = "Direction";
                        oc_Newobject00006["maxLength"] = "1024";
                        #endregion

                        oc_Newobject00010["#Newobject00006"] = oc_Newobject00006;

                        #region GuiControl ()        oc_Newobject00009
                        var oc_Newobject00009 = new ObjectCreator("GuiControl", "", typeof(AggregateControl));
                        //oc_Newobject00009["class"] = "AggregateControl";
                        oc_Newobject00009["position"] = "70 3";
                        oc_Newobject00009["Extent"] = "96 20";
                        if (true)
                        {

                            #region GuiSliderCtrl ()        oc_Newobject00007
                            var oc_Newobject00007 = new ObjectCreator("GuiSliderCtrl", "");
                            oc_Newobject00007["canSaveDynamicFields"] = "0";
                            oc_Newobject00007["internalName"] = "accuDirectionSlider";
                            oc_Newobject00007["Enabled"] = "1";
                            oc_Newobject00007["isContainer"] = "0";
                            oc_Newobject00007["Profile"] = "GuiSliderProfile";
                            oc_Newobject00007["HorizSizing"] = "right";
                            oc_Newobject00007["VertSizing"] = "bottom";
                            oc_Newobject00007["position"] = "0 2";
                            oc_Newobject00007["Extent"] = "61 14";
                            oc_Newobject00007["MinExtent"] = "8 2";
                            oc_Newobject00007["canSave"] = "1";
                            oc_Newobject00007["Visible"] = "1";
                            oc_Newobject00007["Command"] = "MaterialEditorGui.updateActiveMaterial(\\\"accuDirection[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, true);";
                            oc_Newobject00007["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuDirection[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, false);";
                            oc_Newobject00007["tooltipprofile"] = "GuiDefaultProfile";
                            oc_Newobject00007["ToolTip"] = "Sets the direction of the accu map.";
                            oc_Newobject00007["hovertime"] = "1000";
                            oc_Newobject00007["range"] = "-1 1";
                            oc_Newobject00007["ticks"] = "0";
                            oc_Newobject00007["value"] = "-1";
                            #endregion

                            oc_Newobject00009["#Newobject00007"] = oc_Newobject00007;

                            #region GuiTextEditCtrl ()        oc_Newobject0008
                            var oc_Newobject0008 = new ObjectCreator("GuiTextEditCtrl", "");
                            oc_Newobject0008["canSaveDynamicFields"] = "0";
                            oc_Newobject0008["internalName"] = "accuDirectionTextEdit";
                            oc_Newobject0008["Enabled"] = "1";
                            oc_Newobject0008["isContainer"] = "0";
                            oc_Newobject0008["Profile"] = "GuiTextEditProfile";
                            oc_Newobject0008["HorizSizing"] = "right";
                            oc_Newobject0008["VertSizing"] = "bottom";
                            oc_Newobject0008["position"] = "64 0";
                            oc_Newobject0008["Extent"] = "29 18";
                            oc_Newobject0008["MinExtent"] = "8 2";
                            oc_Newobject0008["canSave"] = "1";
                            oc_Newobject0008["Visible"] = "1";
                            oc_Newobject0008["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuDirection[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
                            oc_Newobject0008["hovertime"] = "1000";
                            oc_Newobject0008["AnchorTop"] = "1";
                            oc_Newobject0008["AnchorBottom"] = "0";
                            oc_Newobject0008["AnchorLeft"] = "1";
                            oc_Newobject0008["AnchorRight"] = "0";
                            oc_Newobject0008["text"] = "-1";
                            oc_Newobject0008["maxLength"] = "3";
                            #endregion

                            oc_Newobject00009["#Newobject00008"] = oc_Newobject0008;

                        }
                        #endregion

                        oc_Newobject00010["#Newobject00009"] = oc_Newobject00009;

                    }
                    #endregion

                    oc_Newobject00026["#Newobject00010"] = oc_Newobject00010;

                    #region GuiContainer ()        oc_Newobject00015
                    var oc_Newobject00015 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject00015["profile"] = "GuiTransparentProfile";
                    oc_Newobject00015["isContainer"] = "1";
                    oc_Newobject00015["position"] = "0 0";
                    oc_Newobject00015["Extent"] = "195 24";
                    oc_Newobject00015["HorizSizing"] = "width";
                    if (true)
                    {

                        #region GuiTextCtrl ()        oc_Newobject00011
                        var oc_Newobject00011 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00011["canSaveDynamicFields"] = "0";
                        oc_Newobject00011["Enabled"] = "1";
                        oc_Newobject00011["isContainer"] = "0";
                        oc_Newobject00011["Profile"] = "GuiTextRightProfile";
                        oc_Newobject00011["HorizSizing"] = "right";
                        oc_Newobject00011["VertSizing"] = "bottom";
                        oc_Newobject00011["position"] = "8 3";
                        oc_Newobject00011["Extent"] = "54 16";
                        oc_Newobject00011["MinExtent"] = "8 2";
                        oc_Newobject00011["canSave"] = "1";
                        oc_Newobject00011["Visible"] = "1";
                        oc_Newobject00011["hovertime"] = "1000";
                        oc_Newobject00011["Margin"] = "0 0 0 0";
                        oc_Newobject00011["Padding"] = "0 0 0 0";
                        oc_Newobject00011["AnchorTop"] = "1";
                        oc_Newobject00011["AnchorBottom"] = "0";
                        oc_Newobject00011["AnchorLeft"] = "1";
                        oc_Newobject00011["AnchorRight"] = "0";
                        oc_Newobject00011["text"] = "Strength";
                        oc_Newobject00011["maxLength"] = "1024";
                        #endregion

                        oc_Newobject00015["#Newobject00011"] = oc_Newobject00011;

                        #region GuiControl ()        oc_Newobject00014
                        var oc_Newobject00014 = new ObjectCreator("GuiControl", "", typeof(AggregateControl));
                        //oc_Newobject00014["class"] = "AggregateControl";
                        oc_Newobject00014["position"] = "70 3";
                        oc_Newobject00014["Extent"] = "96 20";
                        if (true)
                        {

                            #region GuiSliderCtrl ()        oc_Newobject00012
                            var oc_Newobject00012 = new ObjectCreator("GuiSliderCtrl", "");
                            oc_Newobject00012["canSaveDynamicFields"] = "0";
                            oc_Newobject00012["internalName"] = "accuStrengthSlider";
                            oc_Newobject00012["Enabled"] = "1";
                            oc_Newobject00012["isContainer"] = "0";
                            oc_Newobject00012["Profile"] = "GuiSliderProfile";
                            oc_Newobject00012["HorizSizing"] = "right";
                            oc_Newobject00012["VertSizing"] = "bottom";
                            oc_Newobject00012["position"] = "0 2";
                            oc_Newobject00012["Extent"] = "61 14";
                            oc_Newobject00012["MinExtent"] = "8 2";
                            oc_Newobject00012["canSave"] = "1";
                            oc_Newobject00012["Visible"] = "1";
                            oc_Newobject00012["Command"] = "MaterialEditorGui.updateActiveMaterial(\\\"accuStrength[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, true);";
                            oc_Newobject00012["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuStrength[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, false);";
                            oc_Newobject00012["tooltipprofile"] = "GuiDefaultProfile";
                            oc_Newobject00012["ToolTip"] = "Sets the strength of the accu map.";
                            oc_Newobject00012["hovertime"] = "1000";
                            oc_Newobject00012["range"] = "0 1";
                            oc_Newobject00012["ticks"] = "0";
                            oc_Newobject00012["value"] = "0.6";
                            #endregion

                            oc_Newobject00014["#Newobject00012"] = oc_Newobject00012;

                            #region GuiTextEditCtrl ()        oc_Newobject00013
                            var oc_Newobject00013 = new ObjectCreator("GuiTextEditCtrl", "");
                            oc_Newobject00013["canSaveDynamicFields"] = "0";
                            oc_Newobject00013["internalName"] = "accuStrengthTextEdit";
                            oc_Newobject00013["Enabled"] = "1";
                            oc_Newobject00013["isContainer"] = "0";
                            oc_Newobject00013["Profile"] = "GuiTextEditProfile";
                            oc_Newobject00013["HorizSizing"] = "right";
                            oc_Newobject00013["VertSizing"] = "bottom";
                            oc_Newobject00013["position"] = "64 0";
                            oc_Newobject00013["Extent"] = "29 18";
                            oc_Newobject00013["MinExtent"] = "8 2";
                            oc_Newobject00013["canSave"] = "1";
                            oc_Newobject00013["Visible"] = "1";
                            oc_Newobject00013["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuStrength[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
                            oc_Newobject00013["hovertime"] = "1000";
                            oc_Newobject00013["AnchorTop"] = "1";
                            oc_Newobject00013["AnchorBottom"] = "0";
                            oc_Newobject00013["AnchorLeft"] = "1";
                            oc_Newobject00013["AnchorRight"] = "0";
                            oc_Newobject00013["text"] = "0.6";
                            oc_Newobject00013["maxLength"] = "3";
                            #endregion

                            oc_Newobject00014["#Newobject00013"] = oc_Newobject00013;

                        }
                        #endregion

                        oc_Newobject00015["#Newobject00014"] = oc_Newobject00014;

                    }
                    #endregion

                    oc_Newobject00026["#Newobject00015"] = oc_Newobject00015;

                    #region GuiContainer ()        oc_Newobject00020
                    var oc_Newobject00020 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject00020["profile"] = "GuiTransparentProfile";
                    oc_Newobject00020["isContainer"] = "1";
                    oc_Newobject00020["position"] = "0 0";
                    oc_Newobject00020["Extent"] = "195 24";
                    oc_Newobject00020["HorizSizing"] = "width";
                    if (true)
                    {

                        #region GuiTextCtrl ()        oc_Newobject00016
                        var oc_Newobject00016 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00016["canSaveDynamicFields"] = "0";
                        oc_Newobject00016["Enabled"] = "1";
                        oc_Newobject00016["isContainer"] = "0";
                        oc_Newobject00016["Profile"] = "GuiTextRightProfile";
                        oc_Newobject00016["HorizSizing"] = "right";
                        oc_Newobject00016["VertSizing"] = "bottom";
                        oc_Newobject00016["position"] = "8 3";
                        oc_Newobject00016["Extent"] = "54 16";
                        oc_Newobject00016["MinExtent"] = "8 2";
                        oc_Newobject00016["canSave"] = "1";
                        oc_Newobject00016["Visible"] = "1";
                        oc_Newobject00016["hovertime"] = "1000";
                        oc_Newobject00016["Margin"] = "0 0 0 0";
                        oc_Newobject00016["Padding"] = "0 0 0 0";
                        oc_Newobject00016["AnchorTop"] = "1";
                        oc_Newobject00016["AnchorBottom"] = "0";
                        oc_Newobject00016["AnchorLeft"] = "1";
                        oc_Newobject00016["AnchorRight"] = "0";
                        oc_Newobject00016["text"] = "Coverage";
                        oc_Newobject00016["maxLength"] = "1024";
                        #endregion

                        oc_Newobject00020["#Newobject00016"] = oc_Newobject00016;

                        #region GuiControl ()        oc_Newobject00019
                        var oc_Newobject00019 = new ObjectCreator("GuiControl", "", typeof(AggregateControl));
                        //oc_Newobject00019["class"] = "AggregateControl";
                        oc_Newobject00019["position"] = "70 3";
                        oc_Newobject00019["Extent"] = "96 20";
                        if (true)
                        {

                            #region GuiSliderCtrl ()        oc_Newobject00017
                            var oc_Newobject00017 = new ObjectCreator("GuiSliderCtrl", "");
                            oc_Newobject00017["canSaveDynamicFields"] = "0";
                            oc_Newobject00017["internalName"] = "accuCoverageSlider";
                            oc_Newobject00017["Enabled"] = "1";
                            oc_Newobject00017["isContainer"] = "0";
                            oc_Newobject00017["Profile"] = "GuiSliderProfile";
                            oc_Newobject00017["HorizSizing"] = "right";
                            oc_Newobject00017["VertSizing"] = "bottom";
                            oc_Newobject00017["position"] = "0 2";
                            oc_Newobject00017["Extent"] = "61 14";
                            oc_Newobject00017["MinExtent"] = "8 2";
                            oc_Newobject00017["canSave"] = "1";
                            oc_Newobject00017["Visible"] = "1";
                            oc_Newobject00017["Command"] = "MaterialEditorGui.updateActiveMaterial(\\\"accuCoverage[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, true);";
                            oc_Newobject00017["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuCoverage[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, false);";
                            oc_Newobject00017["tooltipprofile"] = "GuiDefaultProfile";
                            oc_Newobject00017["ToolTip"] = "Sets the coverage of the accu map.";
                            oc_Newobject00017["hovertime"] = "1000";
                            oc_Newobject00017["range"] = "0 2";
                            oc_Newobject00017["ticks"] = "0";
                            oc_Newobject00017["value"] = "1";
                            #endregion

                            oc_Newobject00019["#Newobject00017"] = oc_Newobject00017;

                            #region GuiTextEditCtrl ()        oc_Newobject00018
                            var oc_Newobject00018 = new ObjectCreator("GuiTextEditCtrl", "");
                            oc_Newobject00018["canSaveDynamicFields"] = "0";
                            oc_Newobject00018["internalName"] = "accuCoverageTextEdit";
                            oc_Newobject00018["Enabled"] = "1";
                            oc_Newobject00018["isContainer"] = "0";
                            oc_Newobject00018["Profile"] = "GuiTextEditProfile";
                            oc_Newobject00018["HorizSizing"] = "right";
                            oc_Newobject00018["VertSizing"] = "bottom";
                            oc_Newobject00018["position"] = "64 0";
                            oc_Newobject00018["Extent"] = "29 18";
                            oc_Newobject00018["MinExtent"] = "8 2";
                            oc_Newobject00018["canSave"] = "1";
                            oc_Newobject00018["Visible"] = "1";
                            oc_Newobject00018["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuCoverage[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
                            oc_Newobject00018["hovertime"] = "1000";
                            oc_Newobject00018["AnchorTop"] = "1";
                            oc_Newobject00018["AnchorBottom"] = "0";
                            oc_Newobject00018["AnchorLeft"] = "1";
                            oc_Newobject00018["AnchorRight"] = "0";
                            oc_Newobject00018["text"] = "1";
                            oc_Newobject00018["maxLength"] = "3";
                            #endregion

                            oc_Newobject00019["#Newobject00018"] = oc_Newobject00018;

                        }
                        #endregion

                        oc_Newobject00020["#Newobject00019"] = oc_Newobject00019;

                    }
                    #endregion

                    oc_Newobject00026["#Newobject00020"] = oc_Newobject00020;

                    #region GuiContainer ()        oc_Newobject00025
                    var oc_Newobject00025 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject00025["profile"] = "GuiTransparentProfile";
                    oc_Newobject00025["isContainer"] = "1";
                    oc_Newobject00025["position"] = "0 0";
                    oc_Newobject00025["Extent"] = "195 24";
                    oc_Newobject00025["HorizSizing"] = "width";
                    if (true)
                    {

                        #region GuiTextCtrl ()        oc_Newobject00021
                        var oc_Newobject00021 = new ObjectCreator("GuiTextCtrl", "");
                        oc_Newobject00021["canSaveDynamicFields"] = "0";
                        oc_Newobject00021["Enabled"] = "1";
                        oc_Newobject00021["isContainer"] = "0";
                        oc_Newobject00021["Profile"] = "GuiTextRightProfile";
                        oc_Newobject00021["HorizSizing"] = "right";
                        oc_Newobject00021["VertSizing"] = "bottom";
                        oc_Newobject00021["position"] = "8 3";
                        oc_Newobject00021["Extent"] = "54 16";
                        oc_Newobject00021["MinExtent"] = "8 2";
                        oc_Newobject00021["canSave"] = "1";
                        oc_Newobject00021["Visible"] = "1";
                        oc_Newobject00021["hovertime"] = "1000";
                        oc_Newobject00021["Margin"] = "0 0 0 0";
                        oc_Newobject00021["Padding"] = "0 0 0 0";
                        oc_Newobject00021["AnchorTop"] = "1";
                        oc_Newobject00021["AnchorBottom"] = "0";
                        oc_Newobject00021["AnchorLeft"] = "1";
                        oc_Newobject00021["AnchorRight"] = "0";
                        oc_Newobject00021["text"] = "Specular scale";
                        oc_Newobject00021["maxLength"] = "1024";
                        #endregion

                        oc_Newobject00025["#Newobject00021"] = oc_Newobject00021;

                        #region GuiControl ()        oc_Newobject00024
                        var oc_Newobject00024 = new ObjectCreator("GuiControl", "", typeof(AggregateControl));
                        //oc_Newobject00024["class"] = "AggregateControl";
                        oc_Newobject00024["position"] = "70 3";
                        oc_Newobject00024["Extent"] = "96 20";
                        if (true)
                        {

                            #region GuiSliderCtrl ()        oc_Newobject00022
                            var oc_Newobject00022 = new ObjectCreator("GuiSliderCtrl", "");
                            oc_Newobject00022["canSaveDynamicFields"] = "0";
                            oc_Newobject00022["internalName"] = "accuSpecularSlider";
                            oc_Newobject00022["Enabled"] = "1";
                            oc_Newobject00022["isContainer"] = "0";
                            oc_Newobject00022["Profile"] = "GuiSliderProfile";
                            oc_Newobject00022["HorizSizing"] = "right";
                            oc_Newobject00022["VertSizing"] = "bottom";
                            oc_Newobject00022["position"] = "0 2";
                            oc_Newobject00022["Extent"] = "61 14";
                            oc_Newobject00022["MinExtent"] = "8 2";
                            oc_Newobject00022["canSave"] = "1";
                            oc_Newobject00022["Visible"] = "1";
                            oc_Newobject00022["Command"] = "MaterialEditorGui.updateActiveMaterial(\\\"accuSpecular[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, true);";
                            oc_Newobject00022["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuSpecular[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, false);";
                            oc_Newobject00022["tooltipprofile"] = "GuiDefaultProfile";
                            oc_Newobject00022["ToolTip"] = "Sets the specular scale over the accu map.";
                            oc_Newobject00022["hovertime"] = "1000";
                            oc_Newobject00022["range"] = "0 2";
                            oc_Newobject00022["ticks"] = "0";
                            oc_Newobject00022["value"] = "1";
                            #endregion

                            oc_Newobject00024["#Newobject00022"] = oc_Newobject00022;

                            #region GuiTextEditCtrl ()        oc_Newobject00023
                            var oc_Newobject00023 = new ObjectCreator("GuiTextEditCtrl", "");
                            oc_Newobject00023["canSaveDynamicFields"] = "0";
                            oc_Newobject00023["internalName"] = "accuSpecularTextEdit";
                            oc_Newobject00023["Enabled"] = "1";
                            oc_Newobject00023["isContainer"] = "0";
                            oc_Newobject00023["Profile"] = "GuiTextEditProfile";
                            oc_Newobject00023["HorizSizing"] = "right";
                            oc_Newobject00023["VertSizing"] = "bottom";
                            oc_Newobject00023["position"] = "64 0";
                            oc_Newobject00023["Extent"] = "29 18";
                            oc_Newobject00023["MinExtent"] = "8 2";
                            oc_Newobject00023["canSave"] = "1";
                            oc_Newobject00023["Visible"] = "1";
                            oc_Newobject00023["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"accuSpecular[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
                            oc_Newobject00023["hovertime"] = "1000";
                            oc_Newobject00023["AnchorTop"] = "1";
                            oc_Newobject00023["AnchorBottom"] = "0";
                            oc_Newobject00023["AnchorLeft"] = "1";
                            oc_Newobject00023["AnchorRight"] = "0";
                            oc_Newobject00023["text"] = "1";
                            oc_Newobject00023["maxLength"] = "3";
                            #endregion

                            oc_Newobject00024["#Newobject00023"] = oc_Newobject00023;

                        }
                        #endregion

                        oc_Newobject00025["#Newobject00024"] = oc_Newobject00024;

                    }
                    #endregion

                    oc_Newobject00026["#Newobject00025"] = oc_Newobject00025;

                }
                #endregion

                oc_Newobject00027["#Newobject00026"] = oc_Newobject00026;

            }
            #endregion

            oc_Newobject212["#Newobject00027"] = oc_Newobject00027;

            #region GuiRolloutCtrl ()        oc_Newobject118

            ObjectCreator oc_Newobject118 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject118["class"] = "BehaviorQuickEditRollout";
            oc_Newobject118["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject118["Profile"] = "GuiRolloutProfile";
            oc_Newobject118["HorizSizing"] = "width";
            oc_Newobject118["VertSizing"] = "bottom";
            oc_Newobject118["Position"] = "0 0";
            oc_Newobject118["Extent"] = "185 0";
            oc_Newobject118["Caption"] = "Lighting Properties";
            oc_Newobject118["Margin"] = "-1 0 0 0";
            oc_Newobject118["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject118["container"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject118["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
            oc_Newobject118["object"] = new ObjectCreator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject117

            ObjectCreator oc_Newobject117 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject117["StackingType"] = "Vertical";
            oc_Newobject117["HorizStacking"] = "Left to Right";
            oc_Newobject117["VertStacking"] = "Top to Bottom";
            oc_Newobject117["Padding"] = "0";
            oc_Newobject117["canSaveDynamicFields"] = "0";
            oc_Newobject117["Enabled"] = "1";
            oc_Newobject117["isContainer"] = "1";
            oc_Newobject117["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject117["HorizSizing"] = "width";
            oc_Newobject117["VertSizing"] = "bottom";
            oc_Newobject117["Position"] = "1 3";
            oc_Newobject117["Extent"] = "185 16";
            oc_Newobject117["MinExtent"] = "16 16";
            oc_Newobject117["canSave"] = "1";
            oc_Newobject117["isDecoy"] = "0";
            oc_Newobject117["Visible"] = "1";
            oc_Newobject117["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject117["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject99

            ObjectCreator oc_Newobject99 = new ObjectCreator("GuiContainer", "");
            oc_Newobject99["profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject99["isContainer"] = "1";
            oc_Newobject99["position"] = "0 0";
            oc_Newobject99["Extent"] = "185 44";
            oc_Newobject99["HorizSizing"] = "width";

            #region GuiCheckBoxCtrl ()        oc_Newobject94

            ObjectCreator oc_Newobject94 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject94["canSaveDynamicFields"] = "0";
            oc_Newobject94["internalName"] = "pixelSpecularCheckbox";
            oc_Newobject94["Enabled"] = "1";
            oc_Newobject94["isContainer"] = "0";
            oc_Newobject94["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject94["HorizSizing"] = "right";
            oc_Newobject94["VertSizing"] = "bottom";
            oc_Newobject94["position"] = "8 4";
            oc_Newobject94["Extent"] = "57 16";
            oc_Newobject94["MinExtent"] = "8 2";
            oc_Newobject94["canSave"] = "1";
            oc_Newobject94["Visible"] = "1";
            oc_Newobject94["Command"] = "MaterialEditorGui.updateSpecularCheckbox($ThisControl.getValue());";
            oc_Newobject94["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject94["ToolTip"] = "Enables the use of Pixel Specular for this layer.";
            oc_Newobject94["hovertime"] = "1000";
            oc_Newobject94["text"] = "Specular";
            oc_Newobject94["groupNum"] = "-1";
            oc_Newobject94["buttonType"] = "ToggleButton";
            oc_Newobject94["useMouseEvents"] = "0";
            oc_Newobject94["useInactiveState"] = "0";

            #endregion

            oc_Newobject99["#Newobject94"] = oc_Newobject94;

            #region GuiSwatchButtonCtrl ()        oc_Newobject95

            ObjectCreator oc_Newobject95 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject95["canSaveDynamicFields"] = "0";
            oc_Newobject95["internalName"] = "specularColorSwatch";
            oc_Newobject95["Enabled"] = "1";
            oc_Newobject95["isContainer"] = "0";
            oc_Newobject95["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject95["HorizSizing"] = "right";
            oc_Newobject95["VertSizing"] = "bottom";
            oc_Newobject95["position"] = "69 4";
            oc_Newobject95["Extent"] = "16 16";
            oc_Newobject95["MinExtent"] = "8 2";
            oc_Newobject95["canSave"] = "1";
            oc_Newobject95["Visible"] = "1";
            oc_Newobject95["Command"] =
                "getColorF(materialEd_previewMaterial.specular[MaterialEditorGui.currentLayer], \\\"MaterialEditorGui.updateSpecular\\\");";
            oc_Newobject95["hovertime"] = "1000";
            oc_Newobject95["groupNum"] = "-1";
            oc_Newobject95["buttonType"] = "PushButton";
            oc_Newobject95["useMouseEvents"] = "0";

            #endregion

            oc_Newobject99["#Newobject95"] = oc_Newobject95;

            #region GuiTextCtrl ()        oc_Newobject00001
            ObjectCreator oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject00001["HorizSizing"] = "right";
            oc_Newobject00001["VertSizing"] = "bottom";
            oc_Newobject00001["position"] = "9 26";
            oc_Newobject00001["Extent"] = "72 16";
            oc_Newobject00001["text"] = "Spec strength";
            #endregion

            oc_Newobject99["#Newobject00001"] = oc_Newobject00001;

            #region GuiControl ()        oc_Newobject98

            ObjectCreator oc_Newobject98 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject98["class"] = "AggregateControl";
            oc_Newobject98["position"] = "91 4";
            oc_Newobject98["Extent"] = "96 20";

            #region GuiSliderCtrl ()        oc_Newobject96

            ObjectCreator oc_Newobject96 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject96["canSaveDynamicFields"] = "0";
            oc_Newobject96["internalName"] = "specularPowerSlider";
            oc_Newobject96["Enabled"] = "1";
            oc_Newobject96["isContainer"] = "0";
            oc_Newobject96["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject96["HorizSizing"] = "right";
            oc_Newobject96["VertSizing"] = "bottom";
            oc_Newobject96["position"] = "0 1";
            oc_Newobject96["Extent"] = "61 14";
            oc_Newobject96["MinExtent"] = "8 2";
            oc_Newobject96["canSave"] = "1";
            oc_Newobject96["Visible"] = "1";
            oc_Newobject96["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"specularPower[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", mCeil($ThisControl.getValue()), true, true);";
            oc_Newobject96["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"specularPower[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", mCeil($ThisControl.getValue()), true, false);";
            oc_Newobject96["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject96["ToolTip"] = "Sets the strength of the Pixel Specular value.";
            oc_Newobject96["hovertime"] = "1000";
            oc_Newobject96["range"] = "1 128";
            oc_Newobject96["ticks"] = "0";
            oc_Newobject96["value"] = "1";

            #endregion

            oc_Newobject98["#Newobject96"] = oc_Newobject96;

            #region GuiTextEditCtrl ()        oc_Newobject97

            ObjectCreator oc_Newobject97 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject97["canSaveDynamicFields"] = "0";
            oc_Newobject97["internalName"] = "specularPowerTextEdit";
            oc_Newobject97["Enabled"] = "1";
            oc_Newobject97["isContainer"] = "0";
            oc_Newobject97["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject97["HorizSizing"] = "right";
            oc_Newobject97["VertSizing"] = "bottom";
            oc_Newobject97["position"] = "64 0";
            oc_Newobject97["Extent"] = "29 18";
            oc_Newobject97["MinExtent"] = "8 2";
            oc_Newobject97["canSave"] = "1";
            oc_Newobject97["Visible"] = "1";
            oc_Newobject97["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"specularPower[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", mCeil($ThisControl.getValue()));";
            oc_Newobject97["hovertime"] = "1000";
            oc_Newobject97["AnchorTop"] = "1";
            oc_Newobject97["AnchorBottom"] = "0";
            oc_Newobject97["AnchorLeft"] = "1";
            oc_Newobject97["AnchorRight"] = "0";
            oc_Newobject97["text"] = "32";
            oc_Newobject97["maxLength"] = "3";

            #endregion

            oc_Newobject98["#Newobject97"] = oc_Newobject97;

            #endregion

            oc_Newobject99["#Newobject98"] = oc_Newobject98;

            #region GuiControl ()        oc_Newobject00004

            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00004 = new ObjectCreator("GuiControl", "", typeof(AggregateControl));
            oc_Newobject00004["position"] = "91 26";
            oc_Newobject00004["Extent"] = "96 20";
            if (true)
            {

                #region GuiSliderCtrl ()        oc_Newobject00002
                oc_Newobject00002 = new ObjectCreator("GuiSliderCtrl", "");
                oc_Newobject00002["canSaveDynamicFields"] = "0";
                oc_Newobject00002["internalName"] = "specularStrengthSlider";
                oc_Newobject00002["Enabled"] = "1";
                oc_Newobject00002["isContainer"] = "0";
                oc_Newobject00002["Profile"] = "ToolsGuiSliderProfile";
                oc_Newobject00002["HorizSizing"] = "right";
                oc_Newobject00002["VertSizing"] = "bottom";
                oc_Newobject00002["position"] = "0 1";
                oc_Newobject00002["Extent"] = "61 14";
                oc_Newobject00002["MinExtent"] = "8 2";
                oc_Newobject00002["canSave"] = "1";
                oc_Newobject00002["Visible"] = "1";
                oc_Newobject00002["Command"] = "MaterialEditorGui.updateActiveMaterial(\\\"specularStrength[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, true);";
                oc_Newobject00002["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"specularStrength[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue(), true, false);";
                oc_Newobject00002["tooltipprofile"] = "ToolsGuiDefaultProfile";
                oc_Newobject00002["ToolTip"] = "Sets the strength of the Pixel Specular value.";
                oc_Newobject00002["hovertime"] = "1000";
                oc_Newobject00002["range"] = "0 5";
                oc_Newobject00002["ticks"] = "0";
                oc_Newobject00002["value"] = "1";
                #endregion

                oc_Newobject00004["#Newobject00002"] = oc_Newobject00002;

                #region GuiTextEditCtrl ()        oc_Newobject00003
                oc_Newobject00003 = new ObjectCreator("GuiTextEditCtrl", "");
                oc_Newobject00003["canSaveDynamicFields"] = "0";
                oc_Newobject00003["internalName"] = "specularStrengthTextEdit";
                oc_Newobject00003["Enabled"] = "1";
                oc_Newobject00003["isContainer"] = "0";
                oc_Newobject00003["Profile"] = "ToolsGuiTextEditProfile";
                oc_Newobject00003["HorizSizing"] = "right";
                oc_Newobject00003["VertSizing"] = "bottom";
                oc_Newobject00003["position"] = "64 0";
                oc_Newobject00003["Extent"] = "29 18";
                oc_Newobject00003["MinExtent"] = "8 2";
                oc_Newobject00003["canSave"] = "1";
                oc_Newobject00003["Visible"] = "1";
                oc_Newobject00003["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"specularStrength[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
                oc_Newobject00003["hovertime"] = "1000";
                oc_Newobject00003["AnchorTop"] = "1";
                oc_Newobject00003["AnchorBottom"] = "0";
                oc_Newobject00003["AnchorLeft"] = "1";
                oc_Newobject00003["AnchorRight"] = "0";
                oc_Newobject00003["text"] = "1";
                oc_Newobject00003["maxLength"] = "3";
                #endregion

                oc_Newobject00004["#Newobject00003"] = oc_Newobject00003;

            }
            #endregion

            oc_Newobject99["#Newobject00004"] = oc_Newobject00004;

            #endregion

            oc_Newobject117["#Newobject99"] = oc_Newobject99;

            #region GuiContainer ()        oc_Newobject102

            ObjectCreator oc_Newobject102 = new ObjectCreator("GuiContainer", "");
            oc_Newobject102["profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject102["isContainer"] = "1";
            oc_Newobject102["position"] = "0 0";
            oc_Newobject102["Extent"] = "185 22";
            oc_Newobject102["HorizSizing"] = "width";

            #region GuiCheckBoxCtrl ()        oc_Newobject100

            ObjectCreator oc_Newobject100 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject100["canSaveDynamicFields"] = "0";
            oc_Newobject100["internalName"] = "glowCheckbox";
            oc_Newobject100["Enabled"] = "1";
            oc_Newobject100["isContainer"] = "0";
            oc_Newobject100["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject100["HorizSizing"] = "right";
            oc_Newobject100["VertSizing"] = "bottom";
            oc_Newobject100["position"] = "70 4";
            oc_Newobject100["Extent"] = "40 16";
            oc_Newobject100["MinExtent"] = "8 2";
            oc_Newobject100["canSave"] = "1";
            oc_Newobject100["Visible"] = "1";
            oc_Newobject100["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"glow[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
            oc_Newobject100["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject100["ToolTip"] = "Determines if this layer will Glow or not.";
            oc_Newobject100["hovertime"] = "1000";
            oc_Newobject100["text"] = "Glow";
            oc_Newobject100["groupNum"] = "-1";
            oc_Newobject100["buttonType"] = "ToggleButton";
            oc_Newobject100["useMouseEvents"] = "0";
            oc_Newobject100["useInactiveState"] = "0";

            #endregion

            oc_Newobject102["#Newobject100"] = oc_Newobject100;

            #region GuiCheckBoxCtrl ()        oc_Newobject101

            ObjectCreator oc_Newobject101 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject101["canSaveDynamicFields"] = "0";
            oc_Newobject101["internalName"] = "emissiveCheckbox";
            oc_Newobject101["Enabled"] = "1";
            oc_Newobject101["isContainer"] = "0";
            oc_Newobject101["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject101["HorizSizing"] = "right";
            oc_Newobject101["VertSizing"] = "bottom";
            oc_Newobject101["position"] = "8 4";
            oc_Newobject101["Extent"] = "60 16";
            oc_Newobject101["MinExtent"] = "8 2";
            oc_Newobject101["canSave"] = "1";
            oc_Newobject101["Visible"] = "1";
            oc_Newobject101["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"emissive[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\",$ThisControl.getValue());";
            oc_Newobject101["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject101["ToolTip"] =
                "Emissive causes an object to not be affected by lights. Good for light sources.";
            oc_Newobject101["hovertime"] = "1000";
            oc_Newobject101["text"] = "Emissive";
            oc_Newobject101["groupNum"] = "-1";
            oc_Newobject101["buttonType"] = "ToggleButton";
            oc_Newobject101["useMouseEvents"] = "0";
            oc_Newobject101["useInactiveState"] = "0";

            #endregion

            oc_Newobject102["#Newobject101"] = oc_Newobject101;

            #endregion

            oc_Newobject117["#Newobject102"] = oc_Newobject102;

            #region GuiContainer ()        oc_Newobject107

            ObjectCreator oc_Newobject107 = new ObjectCreator("GuiContainer", "");
            oc_Newobject107["profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject107["isContainer"] = "1";
            oc_Newobject107["position"] = "0 0";
            oc_Newobject107["Extent"] = "185 24";
            oc_Newobject107["HorizSizing"] = "width";

            #region GuiTextCtrl ()        oc_Newobject103

            ObjectCreator oc_Newobject103 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject103["canSaveDynamicFields"] = "0";
            oc_Newobject103["Enabled"] = "1";
            oc_Newobject103["isContainer"] = "0";
            oc_Newobject103["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject103["HorizSizing"] = "right";
            oc_Newobject103["VertSizing"] = "bottom";
            oc_Newobject103["position"] = "8 3";
            oc_Newobject103["Extent"] = "54 16";
            oc_Newobject103["MinExtent"] = "8 2";
            oc_Newobject103["canSave"] = "1";
            oc_Newobject103["Visible"] = "1";
            oc_Newobject103["hovertime"] = "1000";
            oc_Newobject103["Margin"] = "0 0 0 0";
            oc_Newobject103["Padding"] = "0 0 0 0";
            oc_Newobject103["AnchorTop"] = "1";
            oc_Newobject103["AnchorBottom"] = "0";
            oc_Newobject103["AnchorLeft"] = "1";
            oc_Newobject103["AnchorRight"] = "0";
            oc_Newobject103["text"] = "Parallax";
            oc_Newobject103["maxLength"] = "1024";

            #endregion

            oc_Newobject107["#Newobject103"] = oc_Newobject103;

            #region GuiControl ()        oc_Newobject106

            ObjectCreator oc_Newobject106 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject106["class"] = "AggregateControl";
            oc_Newobject106["position"] = "70 3";
            oc_Newobject106["Extent"] = "115 20";

            #region GuiSliderCtrl ()        oc_Newobject104

            ObjectCreator oc_Newobject104 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject104["canSaveDynamicFields"] = "0";
            oc_Newobject104["internalName"] = "parallaxSlider";
            oc_Newobject104["Enabled"] = "1";
            oc_Newobject104["isContainer"] = "0";
            oc_Newobject104["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject104["HorizSizing"] = "right";
            oc_Newobject104["VertSizing"] = "bottom";
            oc_Newobject104["position"] = "0 2";
            oc_Newobject104["Extent"] = "82 15";
            oc_Newobject104["MinExtent"] = "8 2";
            oc_Newobject104["canSave"] = "1";
            oc_Newobject104["Visible"] = "1";
            oc_Newobject104["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"parallaxScale[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\",$ThisControl.getValue(), true, true);";
            oc_Newobject104["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateActiveMaterial(\\\"parallaxScale[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\",$ThisControl.getValue(), true, false);";
            oc_Newobject104["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject104["ToolTip"] = "Parallax Scale";
            oc_Newobject104["hovertime"] = "1000";
            oc_Newobject104["range"] = "0 1";
            oc_Newobject104["ticks"] = "0";
            oc_Newobject104["value"] = "0";

            #endregion

            oc_Newobject106["#Newobject104"] = oc_Newobject104;

            #region GuiTextEditCtrl ()        oc_Newobject105

            ObjectCreator oc_Newobject105 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject105["canSaveDynamicFields"] = "0";
            oc_Newobject105["internalName"] = "parallaxTextEdit";
            oc_Newobject105["Enabled"] = "1";
            oc_Newobject105["isContainer"] = "0";
            oc_Newobject105["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject105["HorizSizing"] = "right";
            oc_Newobject105["VertSizing"] = "bottom";
            oc_Newobject105["position"] = "85 0";
            oc_Newobject105["Extent"] = "29 18";
            oc_Newobject105["MinExtent"] = "8 2";
            oc_Newobject105["canSave"] = "1";
            oc_Newobject105["Visible"] = "1";
            oc_Newobject105["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateActiveMaterial(\\\"parallaxScale[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\",$ThisControl.getValue());";
            oc_Newobject105["hovertime"] = "1000";
            oc_Newobject105["AnchorTop"] = "1";
            oc_Newobject105["AnchorBottom"] = "0";
            oc_Newobject105["AnchorLeft"] = "1";
            oc_Newobject105["AnchorRight"] = "0";
            oc_Newobject105["text"] = "0";
            oc_Newobject105["maxLength"] = "3";

            #endregion

            oc_Newobject106["#Newobject105"] = oc_Newobject105;

            #endregion

            oc_Newobject107["#Newobject106"] = oc_Newobject106;

            #endregion

            oc_Newobject117["#Newobject107"] = oc_Newobject107;

            #region GuiContainer ()        oc_Newobject116

            ObjectCreator oc_Newobject116 = new ObjectCreator("GuiContainer", "");
            oc_Newobject116["profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject116["isContainer"] = "1";
            oc_Newobject116["position"] = "0 0";
            oc_Newobject116["Extent"] = "185 84";
            oc_Newobject116["HorizSizing"] = "width";

            #region GuiCheckBoxCtrl ()        oc_Newobject108

            ObjectCreator oc_Newobject108 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject108["canSaveDynamicFields"] = "0";
            oc_Newobject108["internalName"] = "useAnisoCheckbox";
            oc_Newobject108["Enabled"] = "1";
            oc_Newobject108["isContainer"] = "0";
            oc_Newobject108["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject108["HorizSizing"] = "right";
            oc_Newobject108["VertSizing"] = "bottom";
            oc_Newobject108["position"] = "8 4";
            oc_Newobject108["Extent"] = "108 16";
            oc_Newobject108["MinExtent"] = "8 2";
            oc_Newobject108["canSave"] = "1";
            oc_Newobject108["Visible"] = "1";
            oc_Newobject108["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"useAnisotropic[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
            oc_Newobject108["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject108["ToolTip"] = "Enables the use of anisotropic filtering for this layer.";
            oc_Newobject108["hovertime"] = "1000";
            oc_Newobject108["text"] = "Anisotropic filtering";
            oc_Newobject108["groupNum"] = "-1";
            oc_Newobject108["buttonType"] = "ToggleButton";
            oc_Newobject108["useMouseEvents"] = "0";
            oc_Newobject108["useInactiveState"] = "0";

            #endregion

            oc_Newobject116["#Newobject108"] = oc_Newobject108;

            #region GuiCheckBoxCtrl ()        oc_Newobject109

            ObjectCreator oc_Newobject109 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject109["canSaveDynamicFields"] = "0";
            oc_Newobject109["internalName"] = "vertLitCheckbox";
            oc_Newobject109["Enabled"] = "1";
            oc_Newobject109["isContainer"] = "0";
            oc_Newobject109["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject109["HorizSizing"] = "right";
            oc_Newobject109["VertSizing"] = "bottom";
            oc_Newobject109["position"] = "8 25";
            oc_Newobject109["Extent"] = "102 16";
            oc_Newobject109["MinExtent"] = "8 2";
            oc_Newobject109["canSave"] = "1";
            oc_Newobject109["Visible"] = "1";
            oc_Newobject109["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"vertLit[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
            oc_Newobject109["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject109["ToolTip"] = "Enables the use of vertex lighting for this layer.";
            oc_Newobject109["hovertime"] = "1000";
            oc_Newobject109["text"] = "Vertex lit";
            oc_Newobject109["groupNum"] = "-1";
            oc_Newobject109["buttonType"] = "ToggleButton";
            oc_Newobject109["useMouseEvents"] = "0";
            oc_Newobject109["useInactiveState"] = "0";

            #endregion

            oc_Newobject116["#Newobject109"] = oc_Newobject109;

            #region GuiCheckBoxCtrl ()        oc_Newobject110

            ObjectCreator oc_Newobject110 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject110["canSaveDynamicFields"] = "0";
            oc_Newobject110["internalName"] = "vertLitCheckbox";
            oc_Newobject110["Enabled"] = "1";
            oc_Newobject110["isContainer"] = "0";
            oc_Newobject110["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject110["HorizSizing"] = "right";
            oc_Newobject110["VertSizing"] = "bottom";
            oc_Newobject110["position"] = "113 25";
            oc_Newobject110["Extent"] = "102 16";
            oc_Newobject110["MinExtent"] = "8 2";
            oc_Newobject110["canSave"] = "1";
            oc_Newobject110["Visible"] = "1";
            oc_Newobject110["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"vertColor[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
            oc_Newobject110["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject110["ToolTip"] = "Multiply vertex colors with diffuse colors for this layer.";
            oc_Newobject110["hovertime"] = "1000";
            oc_Newobject110["text"] = "Vertex colors";
            oc_Newobject110["groupNum"] = "-1";
            oc_Newobject110["buttonType"] = "ToggleButton";
            oc_Newobject110["useMouseEvents"] = "0";
            oc_Newobject110["useInactiveState"] = "0";

            #endregion

            oc_Newobject116["#Newobject110"] = oc_Newobject110;

            #region GuiCheckBoxCtrl ()        oc_Newobject111

            ObjectCreator oc_Newobject111 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject111["canSaveDynamicFields"] = "0";
            oc_Newobject111["internalName"] = "subSurfaceCheckbox";
            oc_Newobject111["Enabled"] = "1";
            oc_Newobject111["isContainer"] = "0";
            oc_Newobject111["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject111["HorizSizing"] = "right";
            oc_Newobject111["VertSizing"] = "bottom";
            oc_Newobject111["position"] = "8 46";
            oc_Newobject111["Extent"] = "79 16";
            oc_Newobject111["MinExtent"] = "8 2";
            oc_Newobject111["canSave"] = "1";
            oc_Newobject111["Visible"] = "1";
            oc_Newobject111["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"subSurface[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getValue());";
            oc_Newobject111["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject111["ToolTip"] = "Enables the use of subsurface scattering for this layer.";
            oc_Newobject111["hovertime"] = "1000";
            oc_Newobject111["text"] = "Sub Surface";
            oc_Newobject111["groupNum"] = "-1";
            oc_Newobject111["buttonType"] = "ToggleButton";
            oc_Newobject111["useMouseEvents"] = "0";
            oc_Newobject111["useInactiveState"] = "0";

            #endregion

            oc_Newobject116["#Newobject111"] = oc_Newobject111;

            #region GuiSwatchButtonCtrl ()        oc_Newobject112

            ObjectCreator oc_Newobject112 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject112["canSaveDynamicFields"] = "0";
            oc_Newobject112["internalName"] = "subSurfaceColorSwatch";
            oc_Newobject112["Enabled"] = "1";
            oc_Newobject112["isContainer"] = "0";
            oc_Newobject112["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject112["HorizSizing"] = "right";
            oc_Newobject112["VertSizing"] = "bottom";
            oc_Newobject112["position"] = "90 46";
            oc_Newobject112["Extent"] = "16 16";
            oc_Newobject112["MinExtent"] = "8 2";
            oc_Newobject112["canSave"] = "1";
            oc_Newobject112["Visible"] = "1";
            oc_Newobject112["Command"] =
                "getColorF(materialEd_previewMaterial.subSurfaceColor[MaterialEditorGui.currentLayer], \\\"MaterialEditorGui.updateSubSurfaceColor\\\");";
            oc_Newobject112["tooltip"] = "Set the subsurface scattering color";
            oc_Newobject112["hovertime"] = "1000";
            oc_Newobject112["groupNum"] = "-1";
            oc_Newobject112["buttonType"] = "PushButton";
            oc_Newobject112["useMouseEvents"] = "0";

            #endregion

            oc_Newobject116["#Newobject112"] = oc_Newobject112;

            #region GuiTextEditCtrl ()        oc_Newobject113

            ObjectCreator oc_Newobject113 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject113["canSaveDynamicFields"] = "0";
            oc_Newobject113["internalName"] = "subSurfaceRolloffTextEdit";
            oc_Newobject113["Enabled"] = "1";
            oc_Newobject113["isContainer"] = "0";
            oc_Newobject113["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject113["HorizSizing"] = "right";
            oc_Newobject113["VertSizing"] = "bottom";
            oc_Newobject113["position"] = "114 45";
            oc_Newobject113["Extent"] = "29 18";
            oc_Newobject113["MinExtent"] = "8 2";
            oc_Newobject113["canSave"] = "1";
            oc_Newobject113["Visible"] = "1";
            oc_Newobject113["tooltip"] = "Set the subsurface rolloff factor";
            oc_Newobject113["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"subSurfaceRolloff[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getText());";
            oc_Newobject113["hovertime"] = "1000";
            oc_Newobject113["AnchorTop"] = "1";
            oc_Newobject113["AnchorBottom"] = "0";
            oc_Newobject113["AnchorLeft"] = "1";
            oc_Newobject113["AnchorRight"] = "0";
            oc_Newobject113["text"] = "32";
            oc_Newobject113["maxLength"] = "5";

            #endregion

            oc_Newobject116["#Newobject113"] = oc_Newobject113;

            #region GuiTextCtrl ()        oc_Newobject114

            ObjectCreator oc_Newobject114 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject114["HorizSizing"] = "right";
            oc_Newobject114["VertSizing"] = "bottom";
            oc_Newobject114["position"] = "9 65";
            oc_Newobject114["Extent"] = "89 16";
            oc_Newobject114["text"] = "Minnaert constant";

            #endregion

            oc_Newobject116["#Newobject114"] = oc_Newobject114;

            #region GuiTextEditCtrl ()        oc_Newobject115

            ObjectCreator oc_Newobject115 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject115["canSaveDynamicFields"] = "0";
            oc_Newobject115["internalName"] = "minnaertTextEdit";
            oc_Newobject115["Enabled"] = "1";
            oc_Newobject115["isContainer"] = "0";
            oc_Newobject115["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject115["HorizSizing"] = "right";
            oc_Newobject115["VertSizing"] = "bottom";
            oc_Newobject115["position"] = "114 65";
            oc_Newobject115["Extent"] = "29 18";
            oc_Newobject115["MinExtent"] = "8 2";
            oc_Newobject115["canSave"] = "1";
            oc_Newobject115["Visible"] = "1";
            oc_Newobject115["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"minnaertConstant[\\\" @ MaterialEditorGui.currentLayer @ \\\"]\\\", $ThisControl.getText());";
            oc_Newobject115["hovertime"] = "1000";
            oc_Newobject115["AnchorTop"] = "1";
            oc_Newobject115["AnchorBottom"] = "0";
            oc_Newobject115["AnchorLeft"] = "1";
            oc_Newobject115["AnchorRight"] = "0";
            oc_Newobject115["text"] = "32";
            oc_Newobject115["maxLength"] = "3";

            #endregion

            oc_Newobject116["#Newobject115"] = oc_Newobject115;

            #endregion

            oc_Newobject117["#Newobject116"] = oc_Newobject116;

            #endregion

            oc_Newobject118["#Newobject117"] = oc_Newobject117;

            #endregion

            oc_Newobject212["#Newobject118"] = oc_Newobject118;

            #region GuiRolloutCtrl (materialAnimationPropertiesRollout)        oc_Newobject183

            ObjectCreator oc_Newobject183 = new ObjectCreator("GuiRolloutCtrl", "materialAnimationPropertiesRollout");
            oc_Newobject183["class"] = "BehaviorQuickEditRollout";
            oc_Newobject183["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject183["Profile"] = "GuiRolloutProfile";
            oc_Newobject183["HorizSizing"] = "width";
            oc_Newobject183["VertSizing"] = "bottom";
            oc_Newobject183["Position"] = "0 0";
            oc_Newobject183["Extent"] = "185 0";
            oc_Newobject183["Caption"] = "Animation Properties";
            oc_Newobject183["Margin"] = "-1 0 0 0";
            oc_Newobject183["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject183["Expanded"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject183["container"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject183["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
            oc_Newobject183["object"] = new ObjectCreator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject182

            ObjectCreator oc_Newobject182 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject182["StackingType"] = "Vertical";
            oc_Newobject182["HorizStacking"] = "Left to Right";
            oc_Newobject182["VertStacking"] = "Top to Bottom";
            oc_Newobject182["Padding"] = "0";
            oc_Newobject182["canSaveDynamicFields"] = "0";
            oc_Newobject182["Enabled"] = "1";
            oc_Newobject182["isContainer"] = "1";
            oc_Newobject182["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject182["HorizSizing"] = "width";
            oc_Newobject182["VertSizing"] = "bottom";
            oc_Newobject182["Position"] = "1 3";
            oc_Newobject182["Extent"] = "185 16";
            oc_Newobject182["MinExtent"] = "16 16";
            oc_Newobject182["canSave"] = "1";
            oc_Newobject182["isDecoy"] = "0";
            oc_Newobject182["Visible"] = "1";
            oc_Newobject182["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject182["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject136

            ObjectCreator oc_Newobject136 = new ObjectCreator("GuiContainer", "");
            oc_Newobject136["profile"] = "inspectorStyleRolloutInnerProfile";
            oc_Newobject136["isContainer"] = "1";
            oc_Newobject136["position"] = "-1 96";
            oc_Newobject136["Extent"] = "185 94";
            oc_Newobject136["HorizSizing"] = "width";

            #region GuiCheckboxCtrl ()        oc_Newobject119

            ObjectCreator oc_Newobject119 = new ObjectCreator("GuiCheckboxCtrl", "");
            oc_Newobject119["canSaveDynamicFields"] = "0";
            oc_Newobject119["internalName"] = "RotationAnimation";
            oc_Newobject119["Enabled"] = "1";
            oc_Newobject119["isContainer"] = "0";
            oc_Newobject119["Profile"] = "ToolsGuiInspectorCheckBoxTitleProfile";
            oc_Newobject119["HorizSizing"] = "right";
            oc_Newobject119["VertSizing"] = "bottom";
            oc_Newobject119["position"] = "4 -1";
            oc_Newobject119["Extent"] = "112 18";
            oc_Newobject119["MinExtent"] = "8 2";
            oc_Newobject119["canSave"] = "1";
            oc_Newobject119["Visible"] = "1";
            oc_Newobject119["Command"] = "MaterialEditorGui.updateAnimationFlags();";
            oc_Newobject119["hovertime"] = "1000";
            oc_Newobject119["Margin"] = "0 0 0 0";
            oc_Newobject119["Padding"] = "0 0 0 0";
            oc_Newobject119["AnchorTop"] = "1";
            oc_Newobject119["AnchorBottom"] = "0";
            oc_Newobject119["AnchorLeft"] = "1";
            oc_Newobject119["AnchorRight"] = "0";
            oc_Newobject119["text"] = "Rotation Animation";
            oc_Newobject119["maxLength"] = "1024";

            #endregion

            oc_Newobject136["#Newobject119"] = oc_Newobject119;

            #region GuiControl ()        oc_Newobject123

            ObjectCreator oc_Newobject123 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject123["class"] = "AggregateControl";
            oc_Newobject123["position"] = "0 29";
            oc_Newobject123["Extent"] = "135 20";

            #region GuiTextCtrl ()        oc_Newobject120

            ObjectCreator oc_Newobject120 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject120["HorizSizing"] = "right";
            oc_Newobject120["VertSizing"] = "bottom";
            oc_Newobject120["position"] = "11 1";
            oc_Newobject120["Extent"] = "12 16";
            oc_Newobject120["text"] = "U";

            #endregion

            oc_Newobject123["#Newobject120"] = oc_Newobject120;

            #region GuiSliderCtrl ()        oc_Newobject121

            ObjectCreator oc_Newobject121 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject121["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject121["internalName"] = "RotationSliderU";
            oc_Newobject121["HorizSizing"] = "right";
            oc_Newobject121["VertSizing"] = "bottom";
            oc_Newobject121["position"] = "25 2";
            oc_Newobject121["Extent"] = "68 15";
            oc_Newobject121["Command"] = "MaterialEditorGui.updateRotationOffset(true, true);";
            oc_Newobject121["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateRotationOffset(true, false);";
            oc_Newobject121["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject121["ToolTip"] = "Change U Scroll Direction";
            oc_Newobject121["hovertime"] = "1000";
            oc_Newobject121["range"] = "-1 0";
            oc_Newobject121["ticks"] = "0";
            oc_Newobject121["value"] = "0";

            #endregion

            oc_Newobject123["#Newobject121"] = oc_Newobject121;

            #region GuiTextEditCtrl ()        oc_Newobject122

            ObjectCreator oc_Newobject122 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject122["internalName"] = "RotationTextEditU";
            oc_Newobject122["HorizSizing"] = "right";
            oc_Newobject122["VertSizing"] = "bottom";
            oc_Newobject122["position"] = "98 0";
            oc_Newobject122["Extent"] = "34 18";
            oc_Newobject122["text"] = "0";
            oc_Newobject122["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl);";

            #endregion

            oc_Newobject123["#Newobject122"] = oc_Newobject122;

            #endregion

            oc_Newobject136["#Newobject123"] = oc_Newobject123;

            #region GuiControl ()        oc_Newobject127

            ObjectCreator oc_Newobject127 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject127["class"] = "AggregateControl";
            oc_Newobject127["position"] = "0 50";
            oc_Newobject127["Extent"] = "135 20";

            #region GuiTextCtrl ()        oc_Newobject124

            ObjectCreator oc_Newobject124 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject124["HorizSizing"] = "right";
            oc_Newobject124["VertSizing"] = "bottom";
            oc_Newobject124["position"] = "11 1";
            oc_Newobject124["Extent"] = "12 16";
            oc_Newobject124["text"] = "V";

            #endregion

            oc_Newobject127["#Newobject124"] = oc_Newobject124;

            #region GuiSliderCtrl ()        oc_Newobject125

            ObjectCreator oc_Newobject125 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject125["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject125["internalName"] = "RotationSliderV";
            oc_Newobject125["HorizSizing"] = "right";
            oc_Newobject125["VertSizing"] = "bottom";
            oc_Newobject125["position"] = "25 2";
            oc_Newobject125["Extent"] = "68 15";
            oc_Newobject125["Command"] = "MaterialEditorGui.updateRotationOffset(true, true);";
            oc_Newobject125["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateRotationOffset(true, false);";
            oc_Newobject125["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject125["ToolTip"] = "Change V Scroll Direction";
            oc_Newobject125["hovertime"] = "1000";
            oc_Newobject125["range"] = "-1 0";
            oc_Newobject125["ticks"] = "0";
            oc_Newobject125["value"] = "0";

            #endregion

            oc_Newobject127["#Newobject125"] = oc_Newobject125;

            #region GuiTextEditCtrl ()        oc_Newobject126

            ObjectCreator oc_Newobject126 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject126["internalName"] = "RotationTextEditV";
            oc_Newobject126["HorizSizing"] = "right";
            oc_Newobject126["VertSizing"] = "bottom";
            oc_Newobject126["position"] = "98 0";
            oc_Newobject126["Extent"] = "34 18";
            oc_Newobject126["text"] = "0";
            oc_Newobject126["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateRotationOffset();";

            #endregion

            oc_Newobject127["#Newobject126"] = oc_Newobject126;

            #endregion

            oc_Newobject136["#Newobject127"] = oc_Newobject127;

            #region GuiTextCtrl ()        oc_Newobject128

            ObjectCreator oc_Newobject128 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject128["HorizSizing"] = "right";
            oc_Newobject128["VertSizing"] = "bottom";
            oc_Newobject128["position"] = "98 16";
            oc_Newobject128["Extent"] = "34 16";
            oc_Newobject128["text"] = "Pivot";

            #endregion

            oc_Newobject136["#Newobject128"] = oc_Newobject128;

            #region GuiBitmapCtrl ()        oc_Newobject131

            ObjectCreator oc_Newobject131 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject131["HorizSizing"] = "right";
            oc_Newobject131["VertSizing"] = "bottom";
            oc_Newobject131["position"] = "136 20";
            oc_Newobject131["Extent"] = "48 48";
            oc_Newobject131["isContainer"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject131["bitmap"] = "";

            #region GuiBitmapCtrl ()        oc_Newobject129

            ObjectCreator oc_Newobject129 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject129["HorizSizing"] = "right";
            oc_Newobject129["VertSizing"] = "bottom";
            oc_Newobject129["position"] = "0 0";
            oc_Newobject129["Extent"] = "48 48";
            oc_Newobject129["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder_n";

            #endregion

            oc_Newobject131["#Newobject129"] = oc_Newobject129;

            #region GuiBitmapCtrl ()        oc_Newobject130

            ObjectCreator oc_Newobject130 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject130["internalName"] = "RotationCrosshair";
            oc_Newobject130["HorizSizing"] = "right";
            oc_Newobject130["VertSizing"] = "bottom";
            oc_Newobject130["position"] = "20 20";
            oc_Newobject130["Extent"] = "7 7";
            oc_Newobject130["MinExtent"] = "0 0";
            oc_Newobject130["bitmap"] = "tools/gui/images/crosshair_blue";

            #endregion

            oc_Newobject131["#Newobject130"] = oc_Newobject130;

            #endregion

            oc_Newobject136["#Newobject131"] = oc_Newobject131;

            #region GuiControl ()        oc_Newobject135

            ObjectCreator oc_Newobject135 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject135["class"] = "AggregateControl";
            oc_Newobject135["position"] = "0 70";
            oc_Newobject135["Extent"] = "187 20";

            #region GuiTextCtrl ()        oc_Newobject132

            ObjectCreator oc_Newobject132 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject132["HorizSizing"] = "right";
            oc_Newobject132["VertSizing"] = "bottom";
            oc_Newobject132["position"] = "11 0";
            oc_Newobject132["Extent"] = "43 16";
            oc_Newobject132["text"] = "Speed";

            #endregion

            oc_Newobject135["#Newobject132"] = oc_Newobject132;

            #region GuiSliderCtrl ()        oc_Newobject133

            ObjectCreator oc_Newobject133 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject133["canSaveDynamicFields"] = "0";
            oc_Newobject133["internalName"] = "RotationSpeedSlider";
            oc_Newobject133["Enabled"] = "1";
            oc_Newobject133["isContainer"] = "0";
            oc_Newobject133["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject133["HorizSizing"] = "right";
            oc_Newobject133["VertSizing"] = "bottom";
            oc_Newobject133["position"] = "49 3";
            oc_Newobject133["Extent"] = "95 16";
            oc_Newobject133["MinExtent"] = "8 2";
            oc_Newobject133["canSave"] = "1";
            oc_Newobject133["Visible"] = "1";
            oc_Newobject133["Command"] = "MaterialEditorGui.updateRotationSpeed(true, true);";
            oc_Newobject133["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateRotationSpeed(true, false);";
            oc_Newobject133["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject133["ToolTip"] = "Scrolling Speed";
            oc_Newobject133["hovertime"] = "1000";
            oc_Newobject133["range"] = "-10 10";
            oc_Newobject133["ticks"] = "0";
            oc_Newobject133["value"] = "0";

            #endregion

            oc_Newobject135["#Newobject133"] = oc_Newobject133;

            #region GuiTextEditCtrl ()        oc_Newobject134

            ObjectCreator oc_Newobject134 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject134["canSaveDynamicFields"] = "0";
            oc_Newobject134["internalName"] = "RotationSpeedTextEdit";
            oc_Newobject134["Enabled"] = "1";
            oc_Newobject134["isContainer"] = "0";
            oc_Newobject134["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject134["HorizSizing"] = "right";
            oc_Newobject134["VertSizing"] = "bottom";
            oc_Newobject134["position"] = "150 1";
            oc_Newobject134["Extent"] = "34 18";
            oc_Newobject134["MinExtent"] = "8 2";
            oc_Newobject134["canSave"] = "1";
            oc_Newobject134["Visible"] = "1";
            oc_Newobject134["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateRotationSpeed();";
            oc_Newobject134["hovertime"] = "1000";
            oc_Newobject134["Margin"] = "0 0 0 0";
            oc_Newobject134["Padding"] = "0 0 0 0";
            oc_Newobject134["AnchorTop"] = "1";
            oc_Newobject134["AnchorBottom"] = "0";
            oc_Newobject134["AnchorLeft"] = "1";
            oc_Newobject134["AnchorRight"] = "0";
            oc_Newobject134["text"] = "0";
            oc_Newobject134["maxLength"] = "1024";
            oc_Newobject134["historySize"] = "0";
            oc_Newobject134["password"] = "0";
            oc_Newobject134["tabComplete"] = "0";
            oc_Newobject134["sinkAllKeyEvents"] = "0";
            oc_Newobject134["passwordMask"] = "*";

            #endregion

            oc_Newobject135["#Newobject134"] = oc_Newobject134;

            #endregion

            oc_Newobject136["#Newobject135"] = oc_Newobject135;

            #endregion

            oc_Newobject182["#Newobject136"] = oc_Newobject136;

            #region GuiContainer ()        oc_Newobject155

            ObjectCreator oc_Newobject155 = new ObjectCreator("GuiContainer", "");
            oc_Newobject155["profile"] = "inspectorStyleRolloutInnerProfile";
            oc_Newobject155["isContainer"] = "1";
            oc_Newobject155["position"] = "-1 191";
            oc_Newobject155["Extent"] = "185 94";
            oc_Newobject155["HorizSizing"] = "width";

            #region GuiCheckboxCtrl ()        oc_Newobject137

            ObjectCreator oc_Newobject137 = new ObjectCreator("GuiCheckboxCtrl", "");
            oc_Newobject137["canSaveDynamicFields"] = "0";
            oc_Newobject137["internalName"] = "ScrollAnimation";
            oc_Newobject137["Enabled"] = "1";
            oc_Newobject137["isContainer"] = "0";
            oc_Newobject137["Profile"] = "ToolsGuiInspectorCheckBoxTitleProfile";
            oc_Newobject137["HorizSizing"] = "right";
            oc_Newobject137["VertSizing"] = "bottom";
            oc_Newobject137["position"] = "4 -1";
            oc_Newobject137["Extent"] = "112 18";
            oc_Newobject137["MinExtent"] = "8 2";
            oc_Newobject137["canSave"] = "1";
            oc_Newobject137["Visible"] = "1";
            oc_Newobject137["hovertime"] = "1000";
            oc_Newobject137["Margin"] = "0 0 0 0";
            oc_Newobject137["Padding"] = "0 0 0 0";
            oc_Newobject137["AnchorTop"] = "1";
            oc_Newobject137["AnchorBottom"] = "0";
            oc_Newobject137["AnchorLeft"] = "1";
            oc_Newobject137["AnchorRight"] = "0";
            oc_Newobject137["Command"] = "MaterialEditorGui.updateAnimationFlags();";
            oc_Newobject137["text"] = "Scroll Animation";
            oc_Newobject137["maxLength"] = "1024";

            #endregion

            oc_Newobject155["#Newobject137"] = oc_Newobject137;

            #region GuiControl ()        oc_Newobject141

            ObjectCreator oc_Newobject141 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            // oc_Newobject141["class"] = "AggregateControl";
            oc_Newobject141["position"] = "0 29";
            oc_Newobject141["Extent"] = "135 20";

            #region GuiTextCtrl ()        oc_Newobject138

            ObjectCreator oc_Newobject138 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject138["HorizSizing"] = "right";
            oc_Newobject138["VertSizing"] = "bottom";
            oc_Newobject138["position"] = "11 1";
            oc_Newobject138["Extent"] = "12 16";
            oc_Newobject138["text"] = "U";

            #endregion

            oc_Newobject141["#Newobject138"] = oc_Newobject138;

            #region GuiSliderCtrl ()        oc_Newobject139

            ObjectCreator oc_Newobject139 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject139["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject139["internalName"] = "ScrollSliderU";
            oc_Newobject139["HorizSizing"] = "right";
            oc_Newobject139["VertSizing"] = "bottom";
            oc_Newobject139["position"] = "25 2";
            oc_Newobject139["Extent"] = "68 15";
            oc_Newobject139["Command"] = "MaterialEditorGui.updateScrollOffset(true, true);";
            oc_Newobject139["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateScrollOffset(true, false);";
            oc_Newobject139["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject139["ToolTip"] = "Change U Scroll Direction";
            oc_Newobject139["hovertime"] = "1000";
            oc_Newobject139["range"] = "-1 1";
            oc_Newobject139["ticks"] = "0";
            oc_Newobject139["value"] = "0";

            #endregion

            oc_Newobject141["#Newobject139"] = oc_Newobject139;

            #region GuiTextEditCtrl ()        oc_Newobject140

            ObjectCreator oc_Newobject140 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject140["internalName"] = "ScrollTextEditU";
            oc_Newobject140["HorizSizing"] = "right";
            oc_Newobject140["VertSizing"] = "bottom";
            oc_Newobject140["position"] = "98 0";
            oc_Newobject140["Extent"] = "34 18";
            oc_Newobject140["text"] = "0";
            oc_Newobject140["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateScrollOffset();";

            #endregion

            oc_Newobject141["#Newobject140"] = oc_Newobject140;

            #endregion

            oc_Newobject155["#Newobject141"] = oc_Newobject141;

            #region GuiControl ()        oc_Newobject145

            ObjectCreator oc_Newobject145 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            // oc_Newobject145["class"] = "AggregateControl";
            oc_Newobject145["position"] = "0 50";
            oc_Newobject145["Extent"] = "135 20";

            #region GuiTextCtrl ()        oc_Newobject142

            ObjectCreator oc_Newobject142 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject142["HorizSizing"] = "right";
            oc_Newobject142["VertSizing"] = "bottom";
            oc_Newobject142["position"] = "11 1";
            oc_Newobject142["Extent"] = "12 16";
            oc_Newobject142["text"] = "V";

            #endregion

            oc_Newobject145["#Newobject142"] = oc_Newobject142;

            #region GuiSliderCtrl ()        oc_Newobject143

            ObjectCreator oc_Newobject143 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject143["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject143["internalName"] = "ScrollSliderV";
            oc_Newobject143["HorizSizing"] = "right";
            oc_Newobject143["VertSizing"] = "bottom";
            oc_Newobject143["position"] = "25 2";
            oc_Newobject143["Extent"] = "68 15";
            oc_Newobject143["Command"] = "MaterialEditorGui.updateScrollOffset(true, true);";
            oc_Newobject143["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateScrollOffset(true, false);";
            oc_Newobject143["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject143["ToolTip"] = "Change V Scroll Direction";
            oc_Newobject143["hovertime"] = "1000";
            oc_Newobject143["range"] = "-1 1";
            oc_Newobject143["ticks"] = "0";
            oc_Newobject143["value"] = "0";

            #endregion

            oc_Newobject145["#Newobject143"] = oc_Newobject143;

            #region GuiTextEditCtrl ()        oc_Newobject144

            ObjectCreator oc_Newobject144 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject144["internalName"] = "ScrollTextEditV";
            oc_Newobject144["HorizSizing"] = "right";
            oc_Newobject144["VertSizing"] = "bottom";
            oc_Newobject144["position"] = "98 0";
            oc_Newobject144["Extent"] = "34 18";
            oc_Newobject144["text"] = "0";
            oc_Newobject144["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateScrollOffset();";

            #endregion

            oc_Newobject145["#Newobject144"] = oc_Newobject144;

            #endregion

            oc_Newobject155["#Newobject145"] = oc_Newobject145;

            #region GuiTextCtrl ()        oc_Newobject146

            ObjectCreator oc_Newobject146 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject146["HorizSizing"] = "right";
            oc_Newobject146["VertSizing"] = "bottom";
            oc_Newobject146["position"] = "98 16";
            oc_Newobject146["Extent"] = "34 16";
            oc_Newobject146["text"] = "Offset";

            #endregion

            oc_Newobject155["#Newobject146"] = oc_Newobject146;

            #region GuiBitmapCtrl ()        oc_Newobject150

            ObjectCreator oc_Newobject150 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject150["HorizSizing"] = "right";
            oc_Newobject150["VertSizing"] = "bottom";
            oc_Newobject150["position"] = "136 20";
            oc_Newobject150["Extent"] = "48 48";
            oc_Newobject150["isContainer"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject150["bitmap"] = "";

            #region GuiBitmapCtrl ()        oc_Newobject147

            ObjectCreator oc_Newobject147 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject147["HorizSizing"] = "right";
            oc_Newobject147["VertSizing"] = "bottom";
            oc_Newobject147["position"] = "0 0";
            oc_Newobject147["Extent"] = "48 48";
            oc_Newobject147["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder_n";

            #endregion

            oc_Newobject150["#Newobject147"] = oc_Newobject147;

            #region GuiBitmapCtrl ()        oc_Newobject148

            ObjectCreator oc_Newobject148 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject148["HorizSizing"] = "right";
            oc_Newobject148["VertSizing"] = "bottom";
            oc_Newobject148["position"] = "20 20";
            oc_Newobject148["Extent"] = "7 7";
            oc_Newobject148["MinExtent"] = "7 7";
            oc_Newobject148["bitmap"] = "tools/gui/images/crosshair";

            #endregion

            oc_Newobject150["#Newobject148"] = oc_Newobject148;

            #region GuiBitmapCtrl ()        oc_Newobject149

            ObjectCreator oc_Newobject149 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject149["internalName"] = "ScrollCrosshair";
            oc_Newobject149["HorizSizing"] = "right";
            oc_Newobject149["VertSizing"] = "bottom";
            oc_Newobject149["position"] = "20 20";
            oc_Newobject149["Extent"] = "7 7";
            oc_Newobject149["MinExtent"] = "0 0";
            oc_Newobject149["bitmap"] = "tools/gui/images/crosshair_blue";

            #endregion

            oc_Newobject150["#Newobject149"] = oc_Newobject149;

            #endregion

            oc_Newobject155["#Newobject150"] = oc_Newobject150;

            #region GuiControl ()        oc_Newobject154

            ObjectCreator oc_Newobject154 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            // oc_Newobject154["class"] = "AggregateControl";
            oc_Newobject154["position"] = "0 70";
            oc_Newobject154["Extent"] = "187 20";

            #region GuiTextCtrl ()        oc_Newobject151

            ObjectCreator oc_Newobject151 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject151["HorizSizing"] = "right";
            oc_Newobject151["VertSizing"] = "bottom";
            oc_Newobject151["position"] = "11 0";
            oc_Newobject151["Extent"] = "43 16";
            oc_Newobject151["text"] = "Speed";

            #endregion

            oc_Newobject154["#Newobject151"] = oc_Newobject151;

            #region GuiSliderCtrl ()        oc_Newobject152

            ObjectCreator oc_Newobject152 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject152["canSaveDynamicFields"] = "0";
            oc_Newobject152["internalName"] = "ScrollSpeedSlider";
            oc_Newobject152["Enabled"] = "1";
            oc_Newobject152["isContainer"] = "0";
            oc_Newobject152["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject152["HorizSizing"] = "right";
            oc_Newobject152["VertSizing"] = "bottom";
            oc_Newobject152["position"] = "49 3";
            oc_Newobject152["Extent"] = "95 16";
            oc_Newobject152["MinExtent"] = "8 2";
            oc_Newobject152["canSave"] = "1";
            oc_Newobject152["Visible"] = "1";
            oc_Newobject152["Command"] = "MaterialEditorGui.updateScrollSpeed(true, true);";
            oc_Newobject152["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateScrollSpeed(true, false);";
            oc_Newobject152["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject152["ToolTip"] = "Scrolling Speed";
            oc_Newobject152["hovertime"] = "1000";
            oc_Newobject152["range"] = "0 10";
            oc_Newobject152["ticks"] = "0";
            oc_Newobject152["value"] = "0";

            #endregion

            oc_Newobject154["#Newobject152"] = oc_Newobject152;

            #region GuiTextEditCtrl ()        oc_Newobject153

            ObjectCreator oc_Newobject153 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject153["canSaveDynamicFields"] = "0";
            oc_Newobject153["internalName"] = "ScrollSpeedTextEdit";
            oc_Newobject153["Enabled"] = "1";
            oc_Newobject153["isContainer"] = "0";
            oc_Newobject153["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject153["HorizSizing"] = "right";
            oc_Newobject153["VertSizing"] = "bottom";
            oc_Newobject153["position"] = "150 1";
            oc_Newobject153["Extent"] = "34 18";
            oc_Newobject153["MinExtent"] = "8 2";
            oc_Newobject153["canSave"] = "1";
            oc_Newobject153["Visible"] = "1";
            oc_Newobject153["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl);MaterialEditorGui.updateScrollSpeed();";
            oc_Newobject153["hovertime"] = "1000";
            oc_Newobject153["Margin"] = "0 0 0 0";
            oc_Newobject153["Padding"] = "0 0 0 0";
            oc_Newobject153["AnchorTop"] = "1";
            oc_Newobject153["AnchorBottom"] = "0";
            oc_Newobject153["AnchorLeft"] = "1";
            oc_Newobject153["AnchorRight"] = "0";
            oc_Newobject153["text"] = "0";
            oc_Newobject153["maxLength"] = "1024";
            oc_Newobject153["historySize"] = "0";
            oc_Newobject153["password"] = "0";
            oc_Newobject153["tabComplete"] = "0";
            oc_Newobject153["sinkAllKeyEvents"] = "0";
            oc_Newobject153["passwordMask"] = "*";

            #endregion

            oc_Newobject154["#Newobject153"] = oc_Newobject153;

            #endregion

            oc_Newobject155["#Newobject154"] = oc_Newobject154;

            #endregion

            oc_Newobject182["#Newobject155"] = oc_Newobject155;

            #region GuiContainer ()        oc_Newobject171

            ObjectCreator oc_Newobject171 = new ObjectCreator("GuiContainer", "");
            oc_Newobject171["profile"] = "inspectorStyleRolloutInnerProfile";
            oc_Newobject171["isContainer"] = "1";
            oc_Newobject171["position"] = "-1 287";
            oc_Newobject171["Extent"] = "185 85";
            oc_Newobject171["HorizSizing"] = "width";

            #region GuiCheckboxCtrl ()        oc_Newobject156

            ObjectCreator oc_Newobject156 = new ObjectCreator("GuiCheckboxCtrl", "");
            oc_Newobject156["Profile"] = "ToolsGuiInspectorCheckBoxTitleProfile";
            oc_Newobject156["internalName"] = "WaveAnimation";
            oc_Newobject156["HorizSizing"] = "right";
            oc_Newobject156["VertSizing"] = "bottom";
            oc_Newobject156["position"] = "4 -1";
            oc_Newobject156["Extent"] = "155 16";
            oc_Newobject156["MinExtent"] = "8 2";
            oc_Newobject156["text"] = " Wave Animation";
            oc_Newobject156["Command"] = "MaterialEditorGui.updateAnimationFlags();";
            oc_Newobject156["groupNum"] = "-1";

            #endregion

            oc_Newobject171["#Newobject156"] = oc_Newobject156;

            #region GuiCheckboxCtrl ()        oc_Newobject157

            ObjectCreator oc_Newobject157 = new ObjectCreator("GuiCheckboxCtrl", "");
            oc_Newobject157["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject157["internalName"] = "ScaleAnimation";
            oc_Newobject157["HorizSizing"] = "right";
            oc_Newobject157["VertSizing"] = "bottom";
            oc_Newobject157["position"] = "139 24";
            oc_Newobject157["Extent"] = "45 16";
            oc_Newobject157["MinExtent"] = "8 2";
            oc_Newobject157["text"] = "Scale";
            oc_Newobject157["Command"] = "MaterialEditorGui.updateAnimationFlags();";
            oc_Newobject157["groupNum"] = "-1";

            #endregion

            oc_Newobject171["#Newobject157"] = oc_Newobject157;

            #region GuiTextCtrl ()        oc_Newobject158

            ObjectCreator oc_Newobject158 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject158["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject158["HorizSizing"] = "right";
            oc_Newobject158["VertSizing"] = "bottom";
            oc_Newobject158["position"] = "10 22";
            oc_Newobject158["Extent"] = "59 16";
            oc_Newobject158["text"] = " Wave Type";

            #endregion

            oc_Newobject171["#Newobject158"] = oc_Newobject158;

            #region GuiContainer ()        oc_Newobject162

            ObjectCreator oc_Newobject162 = new ObjectCreator("GuiContainer", "");
            oc_Newobject162["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject162["internalName"] = "WaveButtonContainer";
            oc_Newobject162["position"] = "72 25";
            oc_Newobject162["Extent"] = "49 13";
            oc_Newobject162["isContainer"] = "1";

            #region GuiBitmapButtonCtrl ()        oc_Newobject159

            ObjectCreator oc_Newobject159 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject159["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject159["buttonType"] = "RadioButton";
            oc_Newobject159["position"] = "1 0";
            oc_Newobject159["Extent"] = "13 13";
            oc_Newobject159["bitmap"] = "tools/materialEditor/gui/wav-sine";
            oc_Newobject159["command"] = "MaterialEditorGui.updateWaveType();";
            oc_Newobject159["tooltip"] = "Sine Wave";
            oc_Newobject159["hovertime"] = "1000";
            oc_Newobject159["groupNum"] = "0";
            oc_Newobject159["waveType"] = "Sin";

            #endregion

            oc_Newobject162["#Newobject159"] = oc_Newobject159;

            #region GuiBitmapButtonCtrl ()        oc_Newobject160

            ObjectCreator oc_Newobject160 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject160["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject160["buttonType"] = "RadioButton";
            oc_Newobject160["position"] = "17 0";
            oc_Newobject160["Extent"] = "13 13";
            oc_Newobject160["bitmap"] = "tools/materialEditor/gui/wav-triangle";
            oc_Newobject160["command"] = "MaterialEditorGui.updateWaveType();";
            oc_Newobject160["tooltip"] = "Triangle Wave";
            oc_Newobject160["hovertime"] = "1000";
            oc_Newobject160["groupNum"] = "0";
            oc_Newobject160["waveType"] = "Triangle";

            #endregion

            oc_Newobject162["#Newobject160"] = oc_Newobject160;

            #region GuiBitmapButtonCtrl ()        oc_Newobject161

            ObjectCreator oc_Newobject161 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject161["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject161["buttonType"] = "RadioButton";
            oc_Newobject161["position"] = "33 0";
            oc_Newobject161["Extent"] = "13 13";
            oc_Newobject161["bitmap"] = "tools/materialEditor/gui/wav-square";
            oc_Newobject161["command"] = "MaterialEditorGui.updateWaveType();";
            oc_Newobject161["tooltip"] = "Square Wave";
            oc_Newobject161["hovertime"] = "1000";
            oc_Newobject161["groupNum"] = "0";
            oc_Newobject161["waveType"] = "Square";

            #endregion

            oc_Newobject162["#Newobject161"] = oc_Newobject161;

            #endregion

            oc_Newobject171["#Newobject162"] = oc_Newobject162;

            #region GuiControl ()        oc_Newobject166

            ObjectCreator oc_Newobject166 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject166["class"] = "AggregateControl";
            oc_Newobject166["position"] = "0 61";
            oc_Newobject166["Extent"] = "187 20";

            #region GuiTextCtrl ()        oc_Newobject163

            ObjectCreator oc_Newobject163 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject163["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject163["HorizSizing"] = "right";
            oc_Newobject163["VertSizing"] = "bottom";
            oc_Newobject163["position"] = "16 1";
            oc_Newobject163["Extent"] = "64 16";
            oc_Newobject163["text"] = "Frequency";

            #endregion

            oc_Newobject166["#Newobject163"] = oc_Newobject163;

            #region GuiTextEditCtrl ()        oc_Newobject164

            ObjectCreator oc_Newobject164 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject164["canSaveDynamicFields"] = "0";
            oc_Newobject164["internalName"] = "WaveTextEditFreq";
            oc_Newobject164["Enabled"] = "1";
            oc_Newobject164["isContainer"] = "0";
            oc_Newobject164["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject164["HorizSizing"] = "right";
            oc_Newobject164["VertSizing"] = "bottom";
            oc_Newobject164["position"] = "150 1";
            oc_Newobject164["Extent"] = "34 18";
            oc_Newobject164["MinExtent"] = "8 2";
            oc_Newobject164["canSave"] = "1";
            oc_Newobject164["Visible"] = "1";
            oc_Newobject164["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateWaveFreq();";
            oc_Newobject164["hovertime"] = "1000";
            oc_Newobject164["Margin"] = "0 0 0 0";
            oc_Newobject164["Padding"] = "0 0 0 0";
            oc_Newobject164["AnchorTop"] = "1";
            oc_Newobject164["AnchorBottom"] = "0";
            oc_Newobject164["AnchorLeft"] = "1";
            oc_Newobject164["AnchorRight"] = "0";
            oc_Newobject164["text"] = "0";
            oc_Newobject164["maxLength"] = "1024";
            oc_Newobject164["historySize"] = "0";
            oc_Newobject164["password"] = "0";
            oc_Newobject164["tabComplete"] = "0";
            oc_Newobject164["sinkAllKeyEvents"] = "0";
            oc_Newobject164["passwordMask"] = "*";

            #endregion

            oc_Newobject166["#Newobject164"] = oc_Newobject164;

            #region GuiSliderCtrl ()        oc_Newobject165

            ObjectCreator oc_Newobject165 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject165["canSaveDynamicFields"] = "0";
            oc_Newobject165["internalName"] = "WaveSliderFreq";
            oc_Newobject165["Enabled"] = "1";
            oc_Newobject165["isContainer"] = "0";
            oc_Newobject165["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject165["HorizSizing"] = "right";
            oc_Newobject165["VertSizing"] = "bottom";
            oc_Newobject165["position"] = "72 3";
            oc_Newobject165["Extent"] = "74 16";
            oc_Newobject165["MinExtent"] = "8 2";
            oc_Newobject165["canSave"] = "1";
            oc_Newobject165["Visible"] = "1";
            oc_Newobject165["Command"] = "MaterialEditorGui.updateWaveFreq(true, true);";
            oc_Newobject165["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateWaveFreq(true, false);";
            oc_Newobject165["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject165["ToolTip"] = "Changes Wave Frequency";
            oc_Newobject165["hovertime"] = "1000";
            oc_Newobject165["range"] = "0 10";
            oc_Newobject165["ticks"] = "0";
            oc_Newobject165["value"] = "0";

            #endregion

            oc_Newobject166["#Newobject165"] = oc_Newobject165;

            #endregion

            oc_Newobject171["#Newobject166"] = oc_Newobject166;

            #region GuiControl ()        oc_Newobject170

            ObjectCreator oc_Newobject170 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject170["class"] = "AggregateControl";
            oc_Newobject170["position"] = "0 40";
            oc_Newobject170["Extent"] = "187 20";

            #region GuiTextCtrl ()        oc_Newobject167

            ObjectCreator oc_Newobject167 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject167["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject167["HorizSizing"] = "right";
            oc_Newobject167["VertSizing"] = "bottom";
            oc_Newobject167["position"] = "21 1";
            oc_Newobject167["Extent"] = "64 16";
            oc_Newobject167["text"] = "Amplitude";

            #endregion

            oc_Newobject170["#Newobject167"] = oc_Newobject167;

            #region GuiTextEditCtrl ()        oc_Newobject168

            ObjectCreator oc_Newobject168 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject168["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject168["internalName"] = "WaveTextEditAmp";
            oc_Newobject168["HorizSizing"] = "right";
            oc_Newobject168["VertSizing"] = "bottom";
            oc_Newobject168["position"] = "150 1";
            oc_Newobject168["Extent"] = "34 18";
            oc_Newobject168["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateWaveAmp();";
            oc_Newobject168["hovertime"] = "1000";
            oc_Newobject168["text"] = "0";

            #endregion

            oc_Newobject170["#Newobject168"] = oc_Newobject168;

            #region GuiSliderCtrl ()        oc_Newobject169

            ObjectCreator oc_Newobject169 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject169["canSaveDynamicFields"] = "0";
            oc_Newobject169["internalName"] = "WaveSliderAmp";
            oc_Newobject169["Enabled"] = "1";
            oc_Newobject169["isContainer"] = "0";
            oc_Newobject169["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject169["HorizSizing"] = "right";
            oc_Newobject169["VertSizing"] = "bottom";
            oc_Newobject169["position"] = "72 3";
            oc_Newobject169["Extent"] = "74 16";
            oc_Newobject169["MinExtent"] = "8 2";
            oc_Newobject169["canSave"] = "1";
            oc_Newobject169["Visible"] = "1";
            oc_Newobject169["Command"] = "MaterialEditorGui.updateWaveAmp(true, true);";
            oc_Newobject169["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateWaveAmp(true, false);";
            oc_Newobject169["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject169["ToolTip"] = "Changes Wave Amplitude";
            oc_Newobject169["hovertime"] = "1000";
            oc_Newobject169["range"] = "0 1";
            oc_Newobject169["ticks"] = "0";
            oc_Newobject169["value"] = "0";

            #endregion

            oc_Newobject170["#Newobject169"] = oc_Newobject169;

            #endregion

            oc_Newobject171["#Newobject170"] = oc_Newobject170;

            #endregion

            oc_Newobject182["#Newobject171"] = oc_Newobject171;

            #region GuiContainer ()        oc_Newobject181

            ObjectCreator oc_Newobject181 = new ObjectCreator("GuiContainer", "");
            oc_Newobject181["profile"] = "inspectorStyleRolloutInnerProfile";
            oc_Newobject181["isContainer"] = "1";
            oc_Newobject181["position"] = "-1 373";
            oc_Newobject181["Extent"] = "185 66";
            oc_Newobject181["HorizSizing"] = "width";

            #region GuiCheckboxCtrl ()        oc_Newobject172

            ObjectCreator oc_Newobject172 = new ObjectCreator("GuiCheckboxCtrl", "");
            oc_Newobject172["Profile"] = "ToolsGuiInspectorCheckBoxTitleProfile";
            oc_Newobject172["internalName"] = "SequenceAnimation";
            oc_Newobject172["HorizSizing"] = "right";
            oc_Newobject172["VertSizing"] = "bottom";
            oc_Newobject172["position"] = "4 0";
            oc_Newobject172["Extent"] = "130 16";
            oc_Newobject172["MinExtent"] = "8 2";
            oc_Newobject172["text"] = "Image Sequence";
            oc_Newobject172["Command"] = "MaterialEditorGui.updateAnimationFlags();";
            oc_Newobject172["groupNum"] = "-1";

            #endregion

            oc_Newobject181["#Newobject172"] = oc_Newobject172;

            #region GuiControl ()        oc_Newobject176

            ObjectCreator oc_Newobject176 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            //oc_Newobject176["class"] = "AggregateControl";
            oc_Newobject176["position"] = "0 21";
            oc_Newobject176["Extent"] = "187 20";

            #region GuiTextCtrl ()        oc_Newobject173

            ObjectCreator oc_Newobject173 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject173["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject173["HorizSizing"] = "right";
            oc_Newobject173["VertSizing"] = "bottom";
            oc_Newobject173["position"] = "5 1";
            oc_Newobject173["Extent"] = "64 16";
            oc_Newobject173["text"] = "Frames / Sec";

            #endregion

            oc_Newobject176["#Newobject173"] = oc_Newobject173;

            #region GuiTextEditCtrl ()        oc_Newobject174

            ObjectCreator oc_Newobject174 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject174["canSaveDynamicFields"] = "0";
            oc_Newobject174["internalName"] = "SequenceTextEditFPS";
            oc_Newobject174["Enabled"] = "1";
            oc_Newobject174["isContainer"] = "0";
            oc_Newobject174["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject174["HorizSizing"] = "right";
            oc_Newobject174["VertSizing"] = "bottom";
            oc_Newobject174["position"] = "150 1";
            oc_Newobject174["Extent"] = "34 18";
            oc_Newobject174["MinExtent"] = "8 2";
            oc_Newobject174["canSave"] = "1";
            oc_Newobject174["Visible"] = "1";
            oc_Newobject174["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateSequenceFPS();";
            oc_Newobject174["hovertime"] = "1000";
            oc_Newobject174["Margin"] = "0 0 0 0";
            oc_Newobject174["Padding"] = "0 0 0 0";
            oc_Newobject174["AnchorTop"] = "1";
            oc_Newobject174["AnchorBottom"] = "0";
            oc_Newobject174["AnchorLeft"] = "1";
            oc_Newobject174["AnchorRight"] = "0";
            oc_Newobject174["text"] = "0";
            oc_Newobject174["maxLength"] = "1024";

            #endregion

            oc_Newobject176["#Newobject174"] = oc_Newobject174;

            #region GuiSliderCtrl ()        oc_Newobject175

            ObjectCreator oc_Newobject175 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject175["canSaveDynamicFields"] = "0";
            oc_Newobject175["internalName"] = "SequenceSliderFPS";
            oc_Newobject175["Enabled"] = "1";
            oc_Newobject175["isContainer"] = "0";
            oc_Newobject175["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject175["HorizSizing"] = "right";
            oc_Newobject175["VertSizing"] = "bottom";
            oc_Newobject175["position"] = "72 3";
            oc_Newobject175["Extent"] = "74 16";
            oc_Newobject175["MinExtent"] = "8 2";
            oc_Newobject175["canSave"] = "1";
            oc_Newobject175["Visible"] = "1";
            oc_Newobject175["Command"] = "MaterialEditorGui.updateSequenceFPS(true, true);";
            oc_Newobject175["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateSequenceFPS(true, false);";
            oc_Newobject175["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject175["ToolTip"] = "How many frames to display per second.";
            oc_Newobject175["hovertime"] = "1000";
            oc_Newobject175["range"] = "0 30";
            oc_Newobject175["ticks"] = "0";
            oc_Newobject175["value"] = "0";

            #endregion

            oc_Newobject176["#Newobject175"] = oc_Newobject175;

            #endregion

            oc_Newobject181["#Newobject176"] = oc_Newobject176;

            #region GuiControl ()        oc_Newobject180

            ObjectCreator oc_Newobject180 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            // oc_Newobject180["class"] = "AggregateControl";
            oc_Newobject180["position"] = "0 42";
            oc_Newobject180["Extent"] = "187 20";

            #region GuiTextCtrl ()        oc_Newobject177

            ObjectCreator oc_Newobject177 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject177["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject177["HorizSizing"] = "right";
            oc_Newobject177["VertSizing"] = "bottom";
            oc_Newobject177["position"] = "33 1";
            oc_Newobject177["Extent"] = "43 16";
            oc_Newobject177["text"] = "Frames";

            #endregion

            oc_Newobject180["#Newobject177"] = oc_Newobject177;

            #region GuiTextEditCtrl ()        oc_Newobject178

            ObjectCreator oc_Newobject178 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject178["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject178["internalName"] = "SequenceTextEditSSS";
            oc_Newobject178["HorizSizing"] = "right";
            oc_Newobject178["VertSizing"] = "bottom";
            oc_Newobject178["position"] = "150 1";
            oc_Newobject178["Extent"] = "34 18";
            oc_Newobject178["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateSequenceSSS();";
            oc_Newobject178["hovertime"] = "1000";
            oc_Newobject178["text"] = "0";

            #endregion

            oc_Newobject180["#Newobject178"] = oc_Newobject178;

            #region GuiSliderCtrl ()        oc_Newobject179

            ObjectCreator oc_Newobject179 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject179["canSaveDynamicFields"] = "0";
            oc_Newobject179["internalName"] = "SequenceSliderSSS";
            oc_Newobject179["Enabled"] = "1";
            oc_Newobject179["isContainer"] = "0";
            oc_Newobject179["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject179["HorizSizing"] = "right";
            oc_Newobject179["VertSizing"] = "bottom";
            oc_Newobject179["position"] = "72 3";
            oc_Newobject179["Extent"] = "74 16";
            oc_Newobject179["MinExtent"] = "8 2";
            oc_Newobject179["canSave"] = "1";
            oc_Newobject179["Visible"] = "1";
            oc_Newobject179["Command"] = "MaterialEditorGui.updateSequenceSSS(true, true);";
            oc_Newobject179["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateSequenceSSS(true, false);";
            oc_Newobject179["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject179["ToolTip"] = "How many frames in the sequence.";
            oc_Newobject179["hovertime"] = "1000";
            oc_Newobject179["range"] = "0 100";
            oc_Newobject179["ticks"] = "0";
            oc_Newobject179["value"] = "0";

            #endregion

            oc_Newobject180["#Newobject179"] = oc_Newobject179;

            #endregion

            oc_Newobject181["#Newobject180"] = oc_Newobject180;

            #endregion

            oc_Newobject182["#Newobject181"] = oc_Newobject181;

            #endregion

            oc_Newobject183["#Newobject182"] = oc_Newobject182;

            #endregion

            oc_Newobject212["#Newobject183"] = oc_Newobject183;

            #region GuiRolloutCtrl (materialAdvancedPropertiesRollout)        oc_Newobject211

            ObjectCreator oc_Newobject211 = new ObjectCreator("GuiRolloutCtrl", "materialAdvancedPropertiesRollout");
            oc_Newobject211["class"] = "BehaviorQuickEditRollout";
            oc_Newobject211["superclass"] = new ObjectCreator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject211["Profile"] = "GuiRolloutProfile";
            oc_Newobject211["HorizSizing"] = "width";
            oc_Newobject211["VertSizing"] = "bottom";
            oc_Newobject211["Position"] = "0 0";
            oc_Newobject211["Extent"] = "202 0";
            oc_Newobject211["Caption"] = "Advanced (all layers)";
            oc_Newobject211["Margin"] = "4 4 4 0";
            oc_Newobject211["DragSizable"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject211["container"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject211["parentRollout"] = new ObjectCreator.StringNoQuote("%this.rollout");
            oc_Newobject211["object"] = new ObjectCreator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject210

            ObjectCreator oc_Newobject210 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject210["StackingType"] = "Vertical";
            oc_Newobject210["HorizStacking"] = "Left to Right";
            oc_Newobject210["VertStacking"] = "Top to Bottom";
            oc_Newobject210["Padding"] = "0";
            oc_Newobject210["canSaveDynamicFields"] = "0";
            oc_Newobject210["Enabled"] = "1";
            oc_Newobject210["isContainer"] = "1";
            oc_Newobject210["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject210["HorizSizing"] = "width";
            oc_Newobject210["VertSizing"] = "bottom";
            oc_Newobject210["Position"] = "1 3";
            oc_Newobject210["Extent"] = "202 16";

            #region GuiContainer ()        oc_Newobject193

            ObjectCreator oc_Newobject193 = new ObjectCreator("GuiContainer", "");
            oc_Newobject193["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject193["isContainer"] = "1";
            oc_Newobject193["HorizSizing"] = "width";
            oc_Newobject193["VertSizing"] = "bottom";
            oc_Newobject193["Position"] = "0 0";
            oc_Newobject193["Extent"] = "210 71";

            #region GuiPopUpMenuCtrl ()        oc_Newobject184

            ObjectCreator oc_Newobject184 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject184["internalName"] = "blendingTypePopUp";
            oc_Newobject184["canSaveDynamicFields"] = "0";
            oc_Newobject184["Enabled"] = "1";
            oc_Newobject184["isContainer"] = "0";
            oc_Newobject184["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject184["HorizSizing"] = "width";
            oc_Newobject184["VertSizing"] = "bottom";
            oc_Newobject184["position"] = "3 2";
            oc_Newobject184["Extent"] = "83 18";
            oc_Newobject184["MinExtent"] = "8 2";
            oc_Newobject184["canSave"] = "1";
            oc_Newobject184["Visible"] = "1";
            oc_Newobject184["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"translucentBlendOp\\\",$ThisControl.getValue());";
            oc_Newobject184["ToolTip"] = "Determines the type of blending to be applied on the transparent object.";
            oc_Newobject184["hovertime"] = "1000";
            oc_Newobject184["Margin"] = "0 0 0 0";
            oc_Newobject184["Padding"] = "0 0 0 0";
            oc_Newobject184["AnchorTop"] = "1";
            oc_Newobject184["AnchorBottom"] = "0";
            oc_Newobject184["AnchorLeft"] = "1";
            oc_Newobject184["AnchorRight"] = "0";
            oc_Newobject184["text"] = "LerpAlpha";
            oc_Newobject184["maxLength"] = "1024";
            oc_Newobject184["maxPopupHeight"] = "200";
            oc_Newobject184["sbUsesNAColor"] = "0";
            oc_Newobject184["reverseTextList"] = "0";
            oc_Newobject184["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject193["#Newobject184"] = oc_Newobject184;

            #region GuiCheckBoxCtrl ()        oc_Newobject185

            ObjectCreator oc_Newobject185 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject185["canSaveDynamicFields"] = "0";
            oc_Newobject185["internalName"] = "alphaTestCheckBox";
            oc_Newobject185["Enabled"] = "1";
            oc_Newobject185["isContainer"] = "0";
            oc_Newobject185["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject185["HorizSizing"] = "right";
            oc_Newobject185["VertSizing"] = "bottom";
            oc_Newobject185["position"] = "3 39";
            oc_Newobject185["Extent"] = "106 16";
            oc_Newobject185["MinExtent"] = "8 2";
            oc_Newobject185["canSave"] = "1";
            oc_Newobject185["Visible"] = "1";
            oc_Newobject185["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"alphaTest\\\",$ThisControl.getValue());";
            oc_Newobject185["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject185["ToolTip"] =
                "When enabled, caused pixels under a specific alpha threshold to get discarded rather than be computed. Only valid for transparent objects.";
            oc_Newobject185["hovertime"] = "1000";
            oc_Newobject185["text"] = "Alpha Threshold";
            oc_Newobject185["groupNum"] = "-1";
            oc_Newobject185["buttonType"] = "ToggleButton";
            oc_Newobject185["useMouseEvents"] = "0";
            oc_Newobject185["useInactiveState"] = "0";

            #endregion

            oc_Newobject193["#Newobject185"] = oc_Newobject185;

            #region GuiControl ()        oc_Newobject188

            ObjectCreator oc_Newobject188 = new ObjectCreator("GuiControl", "",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Common.AggregateControl));
            // oc_Newobject188["class"] = "AggregateControl";
            oc_Newobject188["HorizSizing"] = "width";
            oc_Newobject188["position"] = "100 39";
            oc_Newobject188["Extent"] = "187 20";

            #region GuiSliderCtrl ()        oc_Newobject186

            ObjectCreator oc_Newobject186 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject186["canSaveDynamicFields"] = "0";
            oc_Newobject186["internalName"] = "alphaRefSlider";
            oc_Newobject186["Enabled"] = "1";
            oc_Newobject186["isContainer"] = "0";
            oc_Newobject186["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject186["HorizSizing"] = "width";
            oc_Newobject186["VertSizing"] = "bottom";
            oc_Newobject186["position"] = "0 3";
            oc_Newobject186["Extent"] = "45 14";
            oc_Newobject186["MinExtent"] = "8 2";
            oc_Newobject186["canSave"] = "1";
            oc_Newobject186["Visible"] = "1";
            oc_Newobject186["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"alphaRef\\\",$ThisControl.getValue(), true, true );";
            oc_Newobject186["AltCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"alphaRef\\\",$ThisControl.getValue(), true, false );";
            oc_Newobject186["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject186["ToolTip"] =
                "Sets the minimum transparency value that a pixel must have to be calculated. Anything below this value will simply not be rendered at all.";
            oc_Newobject186["hovertime"] = "1000";
            oc_Newobject186["range"] = "0 255";
            oc_Newobject186["ticks"] = "0";
            oc_Newobject186["value"] = "0";

            #endregion

            oc_Newobject188["#Newobject186"] = oc_Newobject186;

            #region GuiTextEditCtrl ()        oc_Newobject187

            ObjectCreator oc_Newobject187 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject187["canSaveDynamicFields"] = "0";
            oc_Newobject187["internalName"] = "alphaRefTextEdit";
            oc_Newobject187["Enabled"] = "1";
            oc_Newobject187["isContainer"] = "0";
            oc_Newobject187["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject187["HorizSizing"] = "left";
            oc_Newobject187["VertSizing"] = "bottom";
            oc_Newobject187["position"] = "49 0";
            oc_Newobject187["Extent"] = "27 18";
            oc_Newobject187["MinExtent"] = "8 2";
            oc_Newobject187["canSave"] = "1";
            oc_Newobject187["Visible"] = "1";
            oc_Newobject187["Command"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); MaterialEditorGui.updateActiveMaterial(\\\"alphaRef\\\",$ThisControl.getValue());";
            oc_Newobject187["hovertime"] = "1000";
            oc_Newobject187["Margin"] = "0 0 0 0";
            oc_Newobject187["Padding"] = "0 0 0 0";
            oc_Newobject187["AnchorTop"] = "1";
            oc_Newobject187["AnchorBottom"] = "0";
            oc_Newobject187["AnchorLeft"] = "1";
            oc_Newobject187["AnchorRight"] = "0";
            oc_Newobject187["text"] = "100";
            oc_Newobject187["maxLength"] = "1024";

            #endregion

            oc_Newobject188["#Newobject187"] = oc_Newobject187;

            #endregion

            oc_Newobject193["#Newobject188"] = oc_Newobject188;

            #region GuiCheckBoxCtrl ()        oc_Newobject189

            ObjectCreator oc_Newobject189 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject189["canSaveDynamicFields"] = "0";
            oc_Newobject189["internalName"] = "transZWriteCheckBox";
            oc_Newobject189["Enabled"] = "1";
            oc_Newobject189["isContainer"] = "0";
            oc_Newobject189["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject189["HorizSizing"] = "right";
            oc_Newobject189["VertSizing"] = "bottom";
            oc_Newobject189["position"] = "3 23";
            oc_Newobject189["Extent"] = "112 16";
            oc_Newobject189["MinExtent"] = "8 2";
            oc_Newobject189["canSave"] = "1";
            oc_Newobject189["Visible"] = "1";
            oc_Newobject189["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"translucentZWrite\\\",$ThisControl.getValue());";
            oc_Newobject189["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject189["ToolTip"] =
                "Can be used to help force a proper Z-Ordering when Z-Ordering issues occur. Only valid for materials with Transparency.";
            oc_Newobject189["hovertime"] = "1000";
            oc_Newobject189["text"] = "Transparent Z-Write";
            oc_Newobject189["groupNum"] = "-1";
            oc_Newobject189["buttonType"] = "ToggleButton";
            oc_Newobject189["useMouseEvents"] = "0";
            oc_Newobject189["useInactiveState"] = "0";

            #endregion

            oc_Newobject193["#Newobject189"] = oc_Newobject189;

            #region GuiCheckBoxCtrl ()        oc_Newobject190

            ObjectCreator oc_Newobject190 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject190["canSaveDynamicFields"] = "0";
            oc_Newobject190["internalName"] = "translucentCheckbox";
            oc_Newobject190["Enabled"] = "1";
            oc_Newobject190["isContainer"] = "0";
            oc_Newobject190["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject190["HorizSizing"] = "left";
            oc_Newobject190["VertSizing"] = "bottom";
            oc_Newobject190["position"] = "89 3";
            oc_Newobject190["Extent"] = "107 16";
            oc_Newobject190["MinExtent"] = "8 2";
            oc_Newobject190["canSave"] = "1";
            oc_Newobject190["Visible"] = "1";
            oc_Newobject190["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"translucent\\\",$ThisControl.getValue());";
            oc_Newobject190["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject190["ToolTip"] = "Sets material to use transparent blending modes.";
            oc_Newobject190["hovertime"] = "1000";
            oc_Newobject190["text"] = "Transparency";
            oc_Newobject190["groupNum"] = "-1";
            oc_Newobject190["buttonType"] = "ToggleButton";
            oc_Newobject190["useMouseEvents"] = "0";
            oc_Newobject190["useInactiveState"] = "0";

            #endregion

            oc_Newobject193["#Newobject190"] = oc_Newobject190;

            #region GuiCheckBoxCtrl ()        oc_Newobject191

            ObjectCreator oc_Newobject191 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject191["canSaveDynamicFields"] = "0";
            oc_Newobject191["internalName"] = "castShadows";
            oc_Newobject191["Enabled"] = "1";
            oc_Newobject191["isContainer"] = "0";
            oc_Newobject191["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject191["HorizSizing"] = "right";
            oc_Newobject191["VertSizing"] = "bottom";
            oc_Newobject191["position"] = "3 55";
            oc_Newobject191["Extent"] = "112 16";
            oc_Newobject191["MinExtent"] = "8 2";
            oc_Newobject191["canSave"] = "1";
            oc_Newobject191["Visible"] = "1";
            oc_Newobject191["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"castShadows\\\", $ThisControl.getValue());";
            oc_Newobject191["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject191["ToolTip"] = "Alows object to cast shadows.";
            oc_Newobject191["hovertime"] = "1000";
            oc_Newobject191["text"] = "Cast Shadows";
            oc_Newobject191["groupNum"] = "-1";
            oc_Newobject191["buttonType"] = "ToggleButton";
            oc_Newobject191["useMouseEvents"] = "0";
            oc_Newobject191["useInactiveState"] = "0";

            #endregion

            oc_Newobject193["#Newobject191"] = oc_Newobject191;

            #region GuiCheckBoxCtrl ()        oc_Newobject192

            ObjectCreator oc_Newobject192 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject192["canSaveDynamicFields"] = "0";
            oc_Newobject192["internalName"] = "doubleSidedCheckBox";
            oc_Newobject192["Enabled"] = "1";
            oc_Newobject192["isContainer"] = "0";
            oc_Newobject192["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject192["HorizSizing"] = "right";
            oc_Newobject192["VertSizing"] = "bottom";
            oc_Newobject192["position"] = "100 56";
            oc_Newobject192["Extent"] = "85 16";
            oc_Newobject192["MinExtent"] = "8 2";
            oc_Newobject192["canSave"] = "1";
            oc_Newobject192["Visible"] = "1";
            oc_Newobject192["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"doubleSided\\\",$ThisControl.getValue());";
            oc_Newobject192["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject192["ToolTip"] =
                "Determines if this material will be rendered from both sides of the polygon, or just the \'front facing\' side. ";
            oc_Newobject192["hovertime"] = "1000";
            oc_Newobject192["text"] = "Double Sided";
            oc_Newobject192["groupNum"] = "-1";
            oc_Newobject192["buttonType"] = "ToggleButton";
            oc_Newobject192["useMouseEvents"] = "0";
            oc_Newobject192["useInactiveState"] = "0";

            #endregion

            oc_Newobject193["#Newobject192"] = oc_Newobject192;

            #endregion

            oc_Newobject210["#Newobject193"] = oc_Newobject193;

            #region GuiContainer ()        oc_Newobject198

            ObjectCreator oc_Newobject198 = new ObjectCreator("GuiContainer", "");
            oc_Newobject198["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject198["isContainer"] = "1";
            oc_Newobject198["HorizSizing"] = "width";
            oc_Newobject198["VertSizing"] = "bottom";
            oc_Newobject198["Position"] = "0 95";
            oc_Newobject198["Extent"] = "212 25";

            #region GuiBitmapCtrl ()        oc_Newobject194

            ObjectCreator oc_Newobject194 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject194["position"] = "2 2";
            oc_Newobject194["extent"] = "192 2";
            oc_Newobject194["HorizSizing"] = "width";
            oc_Newobject194["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject198["#Newobject194"] = oc_Newobject194;

            #region GuiTextCtrl (matEd_reflectionPropertiesText)        oc_Newobject195

            ObjectCreator oc_Newobject195 = new ObjectCreator("GuiTextCtrl", "matEd_reflectionPropertiesText");
            oc_Newobject195["canSaveDynamicFields"] = "0";
            oc_Newobject195["Enabled"] = "1";
            oc_Newobject195["isContainer"] = "0";
            oc_Newobject195["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject195["HorizSizing"] = "left";
            oc_Newobject195["VertSizing"] = "bottom";
            oc_Newobject195["position"] = "91 6";
            oc_Newobject195["Extent"] = "80 18";
            oc_Newobject195["MinExtent"] = "8 2";
            oc_Newobject195["canSave"] = "1";
            oc_Newobject195["Visible"] = "1";
            oc_Newobject195["hovertime"] = "1000";
            oc_Newobject195["Margin"] = "0 0 0 0";
            oc_Newobject195["Padding"] = "0 0 0 0";
            oc_Newobject195["AnchorTop"] = "1";
            oc_Newobject195["AnchorBottom"] = "0";
            oc_Newobject195["AnchorLeft"] = "1";
            oc_Newobject195["AnchorRight"] = "0";
            oc_Newobject195["text"] = "Reflection";
            oc_Newobject195["maxLength"] = "1024";

            #endregion

            oc_Newobject198["#Newobject195"] = oc_Newobject195;

            #region GuiPopUpMenuCtrl ()        oc_Newobject196

            ObjectCreator oc_Newobject196 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject196["canSaveDynamicFields"] = "0";
            oc_Newobject196["internalName"] = "reflectionTypePopUp";
            oc_Newobject196["Enabled"] = "1";
            oc_Newobject196["isContainer"] = "0";
            oc_Newobject196["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject196["HorizSizing"] = "width";
            oc_Newobject196["VertSizing"] = "bottom";
            oc_Newobject196["position"] = "3 6";
            oc_Newobject196["Extent"] = "84 18";
            oc_Newobject196["MinExtent"] = "8 2";
            oc_Newobject196["canSave"] = "1";
            oc_Newobject196["Visible"] = "1";
            oc_Newobject196["Command"] = "MaterialEditorGui.updateReflectionType($ThisControl.getText());";
            oc_Newobject196["ToolTip"] = "Determines the type of blending to be applied on the transparent object.";
            oc_Newobject196["hovertime"] = "1000";
            oc_Newobject196["Margin"] = "0 0 0 0";
            oc_Newobject196["Padding"] = "0 0 0 0";
            oc_Newobject196["AnchorTop"] = "1";
            oc_Newobject196["AnchorBottom"] = "0";
            oc_Newobject196["AnchorLeft"] = "1";
            oc_Newobject196["AnchorRight"] = "0";
            oc_Newobject196["text"] = "None";
            oc_Newobject196["maxLength"] = "1024";
            oc_Newobject196["maxPopupHeight"] = "200";
            oc_Newobject196["sbUsesNAColor"] = "0";
            oc_Newobject196["reverseTextList"] = "0";
            oc_Newobject196["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject198["#Newobject196"] = oc_Newobject196;

            #region GuiButtonCtrl (matEd_cubemapEditBtn)        oc_Newobject197

            ObjectCreator oc_Newobject197 = new ObjectCreator("GuiButtonCtrl", "matEd_cubemapEditBtn");
            oc_Newobject197["internalName"] = "matEd_cubemapEditBtn";
            oc_Newobject197["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject197["HorizSizing"] = "left";
            oc_Newobject197["VertSizing"] = "bottom";
            oc_Newobject197["position"] = "143 6 28";
            oc_Newobject197["Extent"] = "33 18";
            oc_Newobject197["Command"] = "MaterialEditorGui.showCubemapEditor();";
            oc_Newobject197["text"] = "Edit";

            #endregion

            oc_Newobject198["#Newobject197"] = oc_Newobject197;

            #endregion

            oc_Newobject210["#Newobject198"] = oc_Newobject198;

            #region GuiContainer ()        oc_Newobject209

            ObjectCreator oc_Newobject209 = new ObjectCreator("GuiContainer", "");
            oc_Newobject209["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject209["isContainer"] = "1";
            oc_Newobject209["HorizSizing"] = "width";
            oc_Newobject209["VertSizing"] = "bottom";
            oc_Newobject209["Position"] = "0 122";
            oc_Newobject209["Extent"] = "212 80";

            #region GuiBitmapCtrl ()        oc_Newobject199

            ObjectCreator oc_Newobject199 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject199["position"] = "2 2";
            oc_Newobject199["extent"] = "192 2";
            oc_Newobject199["HorizSizing"] = "width";
            oc_Newobject199["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject209["#Newobject199"] = oc_Newobject199;

            #region GuiTextCtrl ()        oc_Newobject200

            ObjectCreator oc_Newobject200 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject200["text"] = "Effect Colors[0:1]";
            oc_Newobject200["position"] = "1 6";
            oc_Newobject200["extent"] = "86 15";
            oc_Newobject200["profile"] = "ToolsGuiDefaultProfile";

            #endregion

            oc_Newobject209["#Newobject200"] = oc_Newobject200;

            #region GuiSwatchButtonCtrl ()        oc_Newobject201

            ObjectCreator oc_Newobject201 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject201["color"] = "1 1 1 1";
            oc_Newobject201["groupNum"] = "-1";
            oc_Newobject201["buttonType"] = "PushButton";
            oc_Newobject201["useMouseEvents"] = "0";
            oc_Newobject201["position"] = "89 6";
            oc_Newobject201["extent"] = "16 16";
            oc_Newobject201["minExtent"] = "8 2";
            oc_Newobject201["horizSizing"] = "right";
            oc_Newobject201["vertSizing"] = "bottom";
            oc_Newobject201["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject201["visible"] = "1";
            oc_Newobject201["active"] = "1";
            oc_Newobject201["command"] =
                "getColorF(materialEd_previewMaterial.effectColor[0], \\\"MaterialEditorGui.updateEffectColor0\\\");";
            oc_Newobject201["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject201["hovertime"] = "1000";
            oc_Newobject201["isContainer"] = "0";
            oc_Newobject201["internalName"] = "effectColor0Swatch";

            #endregion

            oc_Newobject209["#Newobject201"] = oc_Newobject201;

            #region GuiSwatchButtonCtrl ()        oc_Newobject202

            ObjectCreator oc_Newobject202 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject202["color"] = "1 1 1 1";
            oc_Newobject202["groupNum"] = "-1";
            oc_Newobject202["buttonType"] = "PushButton";
            oc_Newobject202["useMouseEvents"] = "0";
            oc_Newobject202["position"] = "109 6";
            oc_Newobject202["extent"] = "16 16";
            oc_Newobject202["minExtent"] = "8 2";
            oc_Newobject202["horizSizing"] = "right";
            oc_Newobject202["vertSizing"] = "bottom";
            oc_Newobject202["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject202["visible"] = "1";
            oc_Newobject202["active"] = "1";
            oc_Newobject202["command"] =
                "getColorF(materialEd_previewMaterial.effectColor[1], \\\"MaterialEditorGui.updateEffectColor1\\\");";
            oc_Newobject202["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject202["hovertime"] = "1000";
            oc_Newobject202["isContainer"] = "0";
            oc_Newobject202["internalName"] = "effectColor1Swatch";

            #endregion

            oc_Newobject209["#Newobject202"] = oc_Newobject202;

            #region GuiCheckBoxCtrl ()        oc_Newobject203

            ObjectCreator oc_Newobject203 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject203["text"] = "Show Footprints";
            oc_Newobject203["groupNum"] = "-1";
            oc_Newobject203["buttonType"] = "ToggleButton";
            oc_Newobject203["useMouseEvents"] = "0";
            oc_Newobject203["position"] = "1 24";
            oc_Newobject203["extent"] = "93 16";
            oc_Newobject203["minExtent"] = "8 2";
            oc_Newobject203["horizSizing"] = "right";
            oc_Newobject203["vertSizing"] = "bottom";
            oc_Newobject203["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject203["visible"] = "1";
            oc_Newobject203["active"] = "1";
            oc_Newobject203["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"showFootprints\\\", $ThisControl.getValue());";
            oc_Newobject203["tooltipProfile"] = "ToolsGuiDefaultProfile";
            oc_Newobject203["tooltip"] = "Enables Player footprints on surfaces that use this Material.";
            oc_Newobject203["hovertime"] = "1000";
            oc_Newobject203["isContainer"] = "0";
            oc_Newobject203["internalName"] = "showFootprintsCheckbox";

            #endregion

            oc_Newobject209["#Newobject203"] = oc_Newobject203;

            #region GuiCheckBoxCtrl ()        oc_Newobject204

            ObjectCreator oc_Newobject204 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject204["text"] = "Show Dust";
            oc_Newobject204["groupNum"] = "-1";
            oc_Newobject204["buttonType"] = "ToggleButton";
            oc_Newobject204["useMouseEvents"] = "0";
            oc_Newobject204["position"] = "110 24";
            oc_Newobject204["extent"] = "68 16";
            oc_Newobject204["minExtent"] = "8 2";
            oc_Newobject204["horizSizing"] = "right";
            oc_Newobject204["vertSizing"] = "bottom";
            oc_Newobject204["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject204["visible"] = "1";
            oc_Newobject204["active"] = "1";
            oc_Newobject204["Command"] =
                "MaterialEditorGui.updateActiveMaterial(\\\"showDust\\\", $ThisControl.getValue());";
            oc_Newobject204["tooltipProfile"] = "ToolsGuiDefaultProfile";
            oc_Newobject204["tooltip"] = "Enables dust particles on surfaces that use this Material.";
            oc_Newobject204["hovertime"] = "1000";
            oc_Newobject204["isContainer"] = "0";
            oc_Newobject204["internalName"] = "showDustCheckbox";

            #endregion

            oc_Newobject209["#Newobject204"] = oc_Newobject204;

            #region GuiTextCtrl ()        oc_Newobject205

            ObjectCreator oc_Newobject205 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject205["text"] = "Footstep sound";
            oc_Newobject205["position"] = "1 43";
            oc_Newobject205["extent"] = "77 15";
            oc_Newobject205["profile"] = "ToolsGuiDefaultProfile";

            #endregion

            oc_Newobject209["#Newobject205"] = oc_Newobject205;

            #region GuiPopUpMenuCtrl ()        oc_Newobject206

            ObjectCreator oc_Newobject206 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject206["maxPopupHeight"] = "200";
            oc_Newobject206["sbUsesNAColor"] = "0";
            oc_Newobject206["reverseTextList"] = "0";
            oc_Newobject206["bitmapBounds"] = "16 16";
            oc_Newobject206["text"] = "None";
            oc_Newobject206["maxLength"] = "1024";
            oc_Newobject206["margin"] = "0 0 0 0";
            oc_Newobject206["padding"] = "0 0 0 0";
            oc_Newobject206["anchorTop"] = "1";
            oc_Newobject206["anchorBottom"] = "0";
            oc_Newobject206["anchorLeft"] = "1";
            oc_Newobject206["anchorRight"] = "0";
            oc_Newobject206["position"] = "80 42";
            oc_Newobject206["extent"] = "105 18";
            oc_Newobject206["minExtent"] = "8 2";
            oc_Newobject206["horizSizing"] = "width";
            oc_Newobject206["vertSizing"] = "bottom";
            oc_Newobject206["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject206["visible"] = "1";
            oc_Newobject206["active"] = "1";
            oc_Newobject206["command"] =
                "MaterialEditorGui.updateBehaviorSound(\\\"Footstep\\\", $ThisControl.getText());";
            oc_Newobject206["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject206["tooltip"] = "Determines the footstep sound to use when the Player walks on this Material.";
            oc_Newobject206["hovertime"] = "1000";
            oc_Newobject206["isContainer"] = "0";
            oc_Newobject206["internalName"] = "footstepSoundPopUp";

            #endregion

            oc_Newobject209["#Newobject206"] = oc_Newobject206;

            #region GuiTextCtrl ()        oc_Newobject207

            ObjectCreator oc_Newobject207 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject207["text"] = "Impact sound";
            oc_Newobject207["position"] = "1 63";
            oc_Newobject207["extent"] = "64 15";
            oc_Newobject207["profile"] = "ToolsGuiDefaultProfile";

            #endregion

            oc_Newobject209["#Newobject207"] = oc_Newobject207;

            #region GuiPopUpMenuCtrl ()        oc_Newobject208

            ObjectCreator oc_Newobject208 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject208["maxPopupHeight"] = "200";
            oc_Newobject208["sbUsesNAColor"] = "0";
            oc_Newobject208["reverseTextList"] = "0";
            oc_Newobject208["bitmapBounds"] = "16 16";
            oc_Newobject208["text"] = "None";
            oc_Newobject208["maxLength"] = "1024";
            oc_Newobject208["margin"] = "0 0 0 0";
            oc_Newobject208["padding"] = "0 0 0 0";
            oc_Newobject208["anchorTop"] = "1";
            oc_Newobject208["anchorBottom"] = "0";
            oc_Newobject208["anchorLeft"] = "1";
            oc_Newobject208["anchorRight"] = "0";
            oc_Newobject208["position"] = "80 62";
            oc_Newobject208["extent"] = "105 18";
            oc_Newobject208["minExtent"] = "8 2";
            oc_Newobject208["horizSizing"] = "width";
            oc_Newobject208["vertSizing"] = "bottom";
            oc_Newobject208["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject208["visible"] = "1";
            oc_Newobject208["active"] = "1";
            oc_Newobject208["command"] =
                "MaterialEditorGui.updateBehaviorSound(\\\"Impact\\\", $ThisControl.getText());";
            oc_Newobject208["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject208["tooltip"] =
                "Determines the impact sound to use when an object collides with this Material.";
            oc_Newobject208["hovertime"] = "1000";
            oc_Newobject208["isContainer"] = "0";
            oc_Newobject208["internalName"] = "impactSoundPopUp";

            #endregion

            oc_Newobject209["#Newobject208"] = oc_Newobject208;

            #endregion

            oc_Newobject210["#Newobject209"] = oc_Newobject209;

            #endregion

            oc_Newobject211["#Newobject210"] = oc_Newobject210;

            #endregion

            oc_Newobject212["#Newobject211"] = oc_Newobject211;

            #endregion

            oc_Newobject213["#Newobject212"] = oc_Newobject212;

            #endregion

            oc_Newobject222["#Newobject213"] = oc_Newobject213;

            #region GuiBitmapButtonCtrl (MatEd_phoBreadcrumb)        oc_Newobject214

            ObjectCreator oc_Newobject214 = new ObjectCreator("GuiBitmapButtonCtrl", "MatEd_phoBreadcrumb");
            oc_Newobject214["canSaveDynamicFields"] = "0";
            oc_Newobject214["Enabled"] = "1";
            oc_Newobject214["isContainer"] = "0";
            oc_Newobject214["HorizSizing"] = "right";
            oc_Newobject214["VertSizing"] = "bottom";
            oc_Newobject214["position"] = "-1 0";
            oc_Newobject214["Extent"] = "20 19";
            oc_Newobject214["MinExtent"] = "8 2";
            oc_Newobject214["canSave"] = "1";
            oc_Newobject214["Visible"] = "0";
            oc_Newobject214["hovertime"] = "1000";
            oc_Newobject214["bitmap"] = "tools/gui/images/folderUp";
            oc_Newobject214["tooltip"] = "Go back to previous editor";
            oc_Newobject214["groupNum"] = "-1";
            oc_Newobject214["buttonType"] = "PushButton";
            oc_Newobject214["useMouseEvents"] = "0";

            #endregion

            oc_Newobject222["#Newobject214"] = oc_Newobject214;

            #region GuiBitmapButtonCtrl (MatEd_editMaterial)        oc_Newobject215

            ObjectCreator oc_Newobject215 = new ObjectCreator("GuiBitmapButtonCtrl", "MatEd_editMaterial");
            oc_Newobject215["canSaveDynamicFields"] = "0";
            oc_Newobject215["Enabled"] = "1";
            oc_Newobject215["isContainer"] = "0";
            oc_Newobject215["HorizSizing"] = "left";
            oc_Newobject215["VertSizing"] = "bottom";
            oc_Newobject215["position"] = "86 1";
            oc_Newobject215["Extent"] = "16 16";
            oc_Newobject215["MinExtent"] = "8 2";
            oc_Newobject215["canSave"] = "1";
            oc_Newobject215["Visible"] = "1";
            oc_Newobject215["Command"] = "materialSelector.showDialog(\\\"MaterialEditorGui.switchMaterial\\\");";
            oc_Newobject215["hovertime"] = "1000";
            oc_Newobject215["bitmap"] = "tools/gui/images/open-file";
            oc_Newobject215["tooltip"] = "Open Existing Material";
            oc_Newobject215["groupNum"] = "-1";
            oc_Newobject215["buttonType"] = "PushButton";
            oc_Newobject215["useMouseEvents"] = "0";

            #endregion

            oc_Newobject222["#Newobject215"] = oc_Newobject215;

            #region GuiBitmapButtonCtrl ()        oc_Newobject216

            ObjectCreator oc_Newobject216 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject216["canSaveDynamicFields"] = "0";
            oc_Newobject216["Enabled"] = "1";
            oc_Newobject216["isContainer"] = "0";
            oc_Newobject216["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject216["HorizSizing"] = "left";
            oc_Newobject216["VertSizing"] = "bottom";
            oc_Newobject216["position"] = "106 1";
            oc_Newobject216["Extent"] = "16 16";
            oc_Newobject216["MinExtent"] = "8 2";
            oc_Newobject216["canSave"] = "1";
            oc_Newobject216["Visible"] = "1";
            oc_Newobject216["Command"] = "MaterialEditorGui.createNewMaterial();";
            oc_Newobject216["hovertime"] = "1000";
            oc_Newobject216["groupNum"] = "-1";
            oc_Newobject216["text"] = "";
            oc_Newobject216["tooltip"] = "Create New Material";
            oc_Newobject216["buttonType"] = "PushButton";
            oc_Newobject216["useMouseEvents"] = "0";
            oc_Newobject216["bitmap"] = "tools/gui/images/new";

            #endregion

            oc_Newobject222["#Newobject216"] = oc_Newobject216;

            #region GuiBitmapButtonCtrl ()        oc_Newobject217

            ObjectCreator oc_Newobject217 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject217["canSaveDynamicFields"] = "0";
            oc_Newobject217["Enabled"] = "1";
            oc_Newobject217["isContainer"] = "0";
            oc_Newobject217["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject217["HorizSizing"] = "left";
            oc_Newobject217["VertSizing"] = "bottom";
            oc_Newobject217["position"] = "123 1";
            oc_Newobject217["Extent"] = "16 16";
            oc_Newobject217["MinExtent"] = "8 2";
            oc_Newobject217["canSave"] = "1";
            oc_Newobject217["Visible"] = "1";
            oc_Newobject217["Command"] = "MaterialEditorGui.save();";
            oc_Newobject217["hovertime"] = "1000";
            oc_Newobject217["groupNum"] = "-1";
            oc_Newobject217["text"] = "";
            oc_Newobject217["tooltip"] = "Save Material (ALT S)";
            oc_Newobject217["buttonType"] = "PushButton";
            oc_Newobject217["useMouseEvents"] = "0";
            oc_Newobject217["bitmap"] = "tools/gui/images/save-icon";

            #endregion

            oc_Newobject222["#Newobject217"] = oc_Newobject217;

            #region GuiBitmapCtrl ()        oc_Newobject218

            ObjectCreator oc_Newobject218 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject218["position"] = "147 1";
            oc_Newobject218["Extent"] = "2 16";
            oc_Newobject218["minExtent"] = "2 16";
            oc_Newobject218["HorizSizing"] = "left";
            oc_Newobject218["VertSizing"] = "bottom";
            oc_Newobject218["bitmap"] = "tools/gui/images/separator-h";

            #endregion

            oc_Newobject222["#Newobject218"] = oc_Newobject218;

            #region GuiBitmapButtonCtrl ()        oc_Newobject219

            ObjectCreator oc_Newobject219 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject219["canSaveDynamicFields"] = "0";
            oc_Newobject219["Enabled"] = "1";
            oc_Newobject219["isContainer"] = "0";
            oc_Newobject219["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject219["HorizSizing"] = "left";
            oc_Newobject219["VertSizing"] = "bottom";
            oc_Newobject219["position"] = "151 1";
            oc_Newobject219["Extent"] = "17 17";
            oc_Newobject219["MinExtent"] = "8 2";
            oc_Newobject219["canSave"] = "1";
            oc_Newobject219["Visible"] = "1";
            oc_Newobject219["Command"] = "MaterialEditorGui.refreshMaterial();";
            oc_Newobject219["hovertime"] = "1000";
            oc_Newobject219["tooltip"] = "Revert Material to Saved";
            oc_Newobject219["text"] = "";
            oc_Newobject219["bitmap"] = "tools/gui/images/reset-icon";
            oc_Newobject219["groupNum"] = "-1";
            oc_Newobject219["buttonType"] = "PushButton";
            oc_Newobject219["useMouseEvents"] = "0";

            #endregion

            oc_Newobject222["#Newobject219"] = oc_Newobject219;

            #region GuiBitmapButtonCtrl ()        oc_Newobject220

            ObjectCreator oc_Newobject220 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject220["canSaveDynamicFields"] = "0";
            oc_Newobject220["Enabled"] = "1";
            oc_Newobject220["isContainer"] = "0";
            oc_Newobject220["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject220["HorizSizing"] = "left";
            oc_Newobject220["VertSizing"] = "bottom";
            oc_Newobject220["position"] = "168 1";
            oc_Newobject220["Extent"] = "17 17";
            oc_Newobject220["MinExtent"] = "8 2";
            oc_Newobject220["canSave"] = "1";
            oc_Newobject220["Visible"] = "1";
            oc_Newobject220["Command"] = "MaterialEditorGui.clearMaterial();";
            oc_Newobject220["hovertime"] = "1000";
            oc_Newobject220["tooltip"] = "Clear All Material Properties";
            oc_Newobject220["text"] = "";
            oc_Newobject220["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject220["groupNum"] = "-1";
            oc_Newobject220["buttonType"] = "PushButton";
            oc_Newobject220["useMouseEvents"] = "0";

            #endregion

            oc_Newobject222["#Newobject220"] = oc_Newobject220;

            #region GuiBitmapButtonCtrl ()        oc_Newobject221

            ObjectCreator oc_Newobject221 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject221["canSaveDynamicFields"] = "0";
            oc_Newobject221["Enabled"] = "1";
            oc_Newobject221["isContainer"] = "0";
            oc_Newobject221["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject221["HorizSizing"] = "left";
            oc_Newobject221["VertSizing"] = "bottom";
            oc_Newobject221["position"] = "185 1";
            oc_Newobject221["Extent"] = "17 17";
            oc_Newobject221["MinExtent"] = "8 2";
            oc_Newobject221["canSave"] = "1";
            oc_Newobject221["Visible"] = "1";
            oc_Newobject221["hovertime"] = "1000";
            oc_Newobject221["tooltip"] = "Delete Material from File";
            oc_Newobject221["text"] = "";
            oc_Newobject221["bitmap"] = "tools/gui/images/delete";
            oc_Newobject221["groupNum"] = "-1";
            oc_Newobject221["buttonType"] = "PushButton";
            oc_Newobject221["useMouseEvents"] = "0";
            oc_Newobject221["Command"] = "MaterialEditorGui.deleteMaterial();";

            #endregion

            oc_Newobject222["#Newobject221"] = oc_Newobject221;

            #endregion

            oc_Newobject223["#Newobject222"] = oc_Newobject222;

            #endregion

            oc_Newobject224["#Newobject223"] = oc_Newobject223;

            #endregion

            oc_Newobject224.Create();

            #region GuiControl (matEdNonModalGroup, EditorGuiGroup)        oc_Newobject239

            ObjectCreator oc_Newobject239 = new ObjectCreator("GuiControl", "matEdNonModalGroup, EditorGuiGroup");
            oc_Newobject239["canSaveDynamicFields"] = "0";
            oc_Newobject239["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject239["Enabled"] = "1";
            oc_Newobject239["isContainer"] = "1";
            oc_Newobject239["HorizSizing"] = "right";
            oc_Newobject239["VertSizing"] = "bottom";
            oc_Newobject239["Position"] = "0 0";
            oc_Newobject239["Extent"] = "1024 768";
            oc_Newobject239["MinExtent"] = "8 2";
            oc_Newobject239["canSave"] = "1";
            oc_Newobject239["Visible"] = "1";
            oc_Newobject239["hovertime"] = "1000";

            #region GuiWindowCtrl (matEdSaveDialog)        oc_Newobject229

            ObjectCreator oc_Newobject229 = new ObjectCreator("GuiWindowCtrl", "matEdSaveDialog");
            oc_Newobject229["canSaveDynamicFields"] = "0";
            oc_Newobject229["Enabled"] = "1";
            oc_Newobject229["isContainer"] = "1";
            oc_Newobject229["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject229["HorizSizing"] = "center";
            oc_Newobject229["VertSizing"] = "center";
            oc_Newobject229["position"] = "197 221";
            oc_Newobject229["Extent"] = "336 104";
            oc_Newobject229["MinExtent"] = "8 2";
            oc_Newobject229["canSave"] = "1";
            oc_Newobject229["Visible"] = "0";
            oc_Newobject229["hovertime"] = "1000";
            oc_Newobject229["Margin"] = "0 0 0 0";
            oc_Newobject229["Padding"] = "0 0 0 0";
            oc_Newobject229["AnchorTop"] = "1";
            oc_Newobject229["AnchorBottom"] = "0";
            oc_Newobject229["AnchorLeft"] = "1";
            oc_Newobject229["AnchorRight"] = "0";
            oc_Newobject229["resizeWidth"] = "0";
            oc_Newobject229["resizeHeight"] = "0";
            oc_Newobject229["canMove"] = "0";
            oc_Newobject229["canClose"] = "0";
            oc_Newobject229["canMinimize"] = "0";
            oc_Newobject229["canMaximize"] = "0";
            oc_Newobject229["minSize"] = "50 50";
            oc_Newobject229["EdgeSnap"] = "1";
            oc_Newobject229["text"] = "Material Not Saved!";

            #region GuiButtonCtrl (matEd_notSavedWindow_Save)        oc_Newobject225

            ObjectCreator oc_Newobject225 = new ObjectCreator("GuiButtonCtrl", "matEd_notSavedWindow_Save");
            oc_Newobject225["canSaveDynamicFields"] = "0";
            oc_Newobject225["Enabled"] = "1";
            oc_Newobject225["isContainer"] = "0";
            oc_Newobject225["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject225["HorizSizing"] = "right";
            oc_Newobject225["VertSizing"] = "bottom";
            oc_Newobject225["position"] = "8 69";
            oc_Newobject225["Extent"] = "121 24";
            oc_Newobject225["MinExtent"] = "8 2";
            oc_Newobject225["canSave"] = "1";
            oc_Newobject225["Visible"] = "1";
            oc_Newobject225["Command"] = "matEdSaveDialog.dialogSave();";
            oc_Newobject225["hovertime"] = "1000";
            oc_Newobject225["text"] = "Save";
            oc_Newobject225["groupNum"] = "-1";
            oc_Newobject225["buttonType"] = "PushButton";
            oc_Newobject225["useMouseEvents"] = "0";

            #endregion

            oc_Newobject229["#Newobject225"] = oc_Newobject225;

            #region GuiTextCtrl (matEd_materialNotSavedText)        oc_Newobject226

            ObjectCreator oc_Newobject226 = new ObjectCreator("GuiTextCtrl", "matEd_materialNotSavedText");
            oc_Newobject226["canSaveDynamicFields"] = "0";
            oc_Newobject226["Enabled"] = "1";
            oc_Newobject226["isContainer"] = "0";
            oc_Newobject226["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject226["HorizSizing"] = "right";
            oc_Newobject226["VertSizing"] = "bottom";
            oc_Newobject226["position"] = "7 35";
            oc_Newobject226["Extent"] = "318 18";
            oc_Newobject226["MinExtent"] = "8 2";
            oc_Newobject226["canSave"] = "1";
            oc_Newobject226["Visible"] = "1";
            oc_Newobject226["hovertime"] = "1000";
            oc_Newobject226["Margin"] = "0 0 0 0";
            oc_Newobject226["Padding"] = "0 0 0 0";
            oc_Newobject226["AnchorTop"] = "1";
            oc_Newobject226["AnchorBottom"] = "0";
            oc_Newobject226["AnchorLeft"] = "1";
            oc_Newobject226["AnchorRight"] = "0";
            oc_Newobject226["text"] = "This material has unsaved changes. Do you wish to save?";
            oc_Newobject226["maxLength"] = "1024";

            #endregion

            oc_Newobject229["#Newobject226"] = oc_Newobject226;

            #region GuiButtonCtrl (matEd_notSavedWindow_DontSave)        oc_Newobject227

            ObjectCreator oc_Newobject227 = new ObjectCreator("GuiButtonCtrl", "matEd_notSavedWindow_DontSave");
            oc_Newobject227["canSaveDynamicFields"] = "0";
            oc_Newobject227["Enabled"] = "1";
            oc_Newobject227["isContainer"] = "0";
            oc_Newobject227["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject227["HorizSizing"] = "right";
            oc_Newobject227["VertSizing"] = "bottom";
            oc_Newobject227["position"] = "157 69";
            oc_Newobject227["Extent"] = "80 24";
            oc_Newobject227["MinExtent"] = "8 2";
            oc_Newobject227["canSave"] = "1";
            oc_Newobject227["Visible"] = "1";
            oc_Newobject227["Command"] = "matEdSaveDialog.dialogDontSave();";
            oc_Newobject227["hovertime"] = "1000";
            oc_Newobject227["text"] = "Don\'t Save";
            oc_Newobject227["groupNum"] = "-1";
            oc_Newobject227["buttonType"] = "PushButton";
            oc_Newobject227["useMouseEvents"] = "0";

            #endregion

            oc_Newobject229["#Newobject227"] = oc_Newobject227;

            #region GuiButtonCtrl (matEd_notSavedWindow_Cancel)        oc_Newobject228

            ObjectCreator oc_Newobject228 = new ObjectCreator("GuiButtonCtrl", "matEd_notSavedWindow_Cancel");
            oc_Newobject228["canSaveDynamicFields"] = "0";
            oc_Newobject228["Enabled"] = "1";
            oc_Newobject228["isContainer"] = "0";
            oc_Newobject228["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject228["HorizSizing"] = "right";
            oc_Newobject228["VertSizing"] = "bottom";
            oc_Newobject228["position"] = "245 69";
            oc_Newobject228["Extent"] = "80 24";
            oc_Newobject228["MinExtent"] = "8 2";
            oc_Newobject228["canSave"] = "1";
            oc_Newobject228["Visible"] = "1";
            oc_Newobject228["Command"] = "matEdSaveDialog.dialogCancel();";
            oc_Newobject228["hovertime"] = "1000";
            oc_Newobject228["text"] = "Cancel";
            oc_Newobject228["groupNum"] = "-1";
            oc_Newobject228["buttonType"] = "PushButton";
            oc_Newobject228["useMouseEvents"] = "0";

            #endregion

            oc_Newobject229["#Newobject228"] = oc_Newobject228;

            #endregion

            oc_Newobject239["#Newobject229"] = oc_Newobject229;

            #region GuiWindowCtrl (matEd_changeCategoryDialog)        oc_Newobject238

            ObjectCreator oc_Newobject238 = new ObjectCreator("GuiWindowCtrl", "matEd_changeCategoryDialog");
            oc_Newobject238["canSaveDynamicFields"] = "0";
            oc_Newobject238["Enabled"] = "1";
            oc_Newobject238["isContainer"] = "1";
            oc_Newobject238["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject238["HorizSizing"] = "right";
            oc_Newobject238["VertSizing"] = "bottom";
            oc_Newobject238["position"] = "288 144";
            oc_Newobject238["Extent"] = "248 133";
            oc_Newobject238["MinExtent"] = "8 2";
            oc_Newobject238["canSave"] = "1";
            oc_Newobject238["Visible"] = "0";
            oc_Newobject238["hovertime"] = "1000";
            oc_Newobject238["Margin"] = "0 0 0 0";
            oc_Newobject238["Padding"] = "0 0 0 0";
            oc_Newobject238["AnchorTop"] = "1";
            oc_Newobject238["AnchorBottom"] = "0";
            oc_Newobject238["AnchorLeft"] = "1";
            oc_Newobject238["AnchorRight"] = "0";
            oc_Newobject238["resizeWidth"] = "0";
            oc_Newobject238["resizeHeight"] = "0";
            oc_Newobject238["canMove"] = "0";
            oc_Newobject238["canClose"] = "0";
            oc_Newobject238["canMinimize"] = "0";
            oc_Newobject238["canMaximize"] = "0";
            oc_Newobject238["minSize"] = "50 50";
            oc_Newobject238["EdgeSnap"] = "1";
            oc_Newobject238["text"] = "Change Material Category";

            #region GuiPopUpMenuCtrl (matEd_changeCategory_categoryList)        oc_Newobject230

            ObjectCreator oc_Newobject230 = new ObjectCreator("GuiPopUpMenuCtrl", "matEd_changeCategory_categoryList");
            oc_Newobject230["canSaveDynamicFields"] = "0";
            oc_Newobject230["Enabled"] = "1";
            oc_Newobject230["isContainer"] = "0";
            oc_Newobject230["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject230["HorizSizing"] = "right";
            oc_Newobject230["VertSizing"] = "bottom";
            oc_Newobject230["position"] = "10 32";
            oc_Newobject230["Extent"] = "183 18";
            oc_Newobject230["MinExtent"] = "8 2";
            oc_Newobject230["canSave"] = "1";
            oc_Newobject230["Visible"] = "1";
            oc_Newobject230["hovertime"] = "1000";
            oc_Newobject230["Margin"] = "0 0 0 0";
            oc_Newobject230["Padding"] = "0 0 0 0";
            oc_Newobject230["AnchorTop"] = "1";
            oc_Newobject230["AnchorBottom"] = "0";
            oc_Newobject230["AnchorLeft"] = "1";
            oc_Newobject230["AnchorRight"] = "0";
            oc_Newobject230["maxLength"] = "1024";
            oc_Newobject230["maxPopupHeight"] = "200";
            oc_Newobject230["sbUsesNAColor"] = "0";
            oc_Newobject230["reverseTextList"] = "0";
            oc_Newobject230["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject238["#Newobject230"] = oc_Newobject230;

            #region GuiButtonCtrl (matEd_changeCategory_okayBtn)        oc_Newobject231

            ObjectCreator oc_Newobject231 = new ObjectCreator("GuiButtonCtrl", "matEd_changeCategory_okayBtn");
            oc_Newobject231["canSaveDynamicFields"] = "0";
            oc_Newobject231["Enabled"] = "1";
            oc_Newobject231["isContainer"] = "0";
            oc_Newobject231["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject231["HorizSizing"] = "right";
            oc_Newobject231["VertSizing"] = "bottom";
            oc_Newobject231["position"] = "10 97";
            oc_Newobject231["Extent"] = "137 24";
            oc_Newobject231["MinExtent"] = "8 2";
            oc_Newobject231["canSave"] = "1";
            oc_Newobject231["Visible"] = "1";
            oc_Newobject231["Command"] = "MaterialEditorGui.okayChangeCategoryDialog();";
            oc_Newobject231["hovertime"] = "1000";
            oc_Newobject231["text"] = "Update Category";
            oc_Newobject231["groupNum"] = "-1";
            oc_Newobject231["buttonType"] = "PushButton";
            oc_Newobject231["useMouseEvents"] = "0";

            #endregion

            oc_Newobject238["#Newobject231"] = oc_Newobject231;

            #region GuiButtonCtrl (matEd_changeCategory_cancelBtn)        oc_Newobject232

            ObjectCreator oc_Newobject232 = new ObjectCreator("GuiButtonCtrl", "matEd_changeCategory_cancelBtn");
            oc_Newobject232["canSaveDynamicFields"] = "0";
            oc_Newobject232["Enabled"] = "1";
            oc_Newobject232["isContainer"] = "0";
            oc_Newobject232["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject232["HorizSizing"] = "right";
            oc_Newobject232["VertSizing"] = "bottom";
            oc_Newobject232["position"] = "159 97";
            oc_Newobject232["Extent"] = "80 24";
            oc_Newobject232["MinExtent"] = "8 2";
            oc_Newobject232["canSave"] = "1";
            oc_Newobject232["Visible"] = "1";
            oc_Newobject232["Command"] = "MaterialEditorGui.cancelChangeCategoryDialog();";
            oc_Newobject232["hovertime"] = "1000";
            oc_Newobject232["text"] = "Cancel";
            oc_Newobject232["groupNum"] = "-1";
            oc_Newobject232["buttonType"] = "PushButton";
            oc_Newobject232["useMouseEvents"] = "0";

            #endregion

            oc_Newobject238["#Newobject232"] = oc_Newobject232;

            #region GuiButtonCtrl (matEd_changeCategory_addCatBtn)        oc_Newobject233

            ObjectCreator oc_Newobject233 = new ObjectCreator("GuiButtonCtrl", "matEd_changeCategory_addCatBtn");
            oc_Newobject233["canSaveDynamicFields"] = "0";
            oc_Newobject233["Enabled"] = "1";
            oc_Newobject233["isContainer"] = "0";
            oc_Newobject233["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject233["HorizSizing"] = "right";
            oc_Newobject233["VertSizing"] = "bottom";
            oc_Newobject233["position"] = "200 60";
            oc_Newobject233["Extent"] = "39 18";
            oc_Newobject233["MinExtent"] = "8 2";
            oc_Newobject233["canSave"] = "1";
            oc_Newobject233["Visible"] = "1";
            oc_Newobject233["Command"] = "MaterialEditorGui.addCategory();";
            oc_Newobject233["hovertime"] = "1000";
            oc_Newobject233["text"] = "New";
            oc_Newobject233["groupNum"] = "-1";
            oc_Newobject233["buttonType"] = "PushButton";
            oc_Newobject233["useMouseEvents"] = "0";

            #endregion

            oc_Newobject238["#Newobject233"] = oc_Newobject233;

            #region GuiTextEditCtrl (matEd_changeCategory_catNameEntry)        oc_Newobject234

            ObjectCreator oc_Newobject234 = new ObjectCreator("GuiTextEditCtrl", "matEd_changeCategory_catNameEntry");
            oc_Newobject234["canSaveDynamicFields"] = "0";
            oc_Newobject234["Enabled"] = "1";
            oc_Newobject234["isContainer"] = "0";
            oc_Newobject234["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject234["HorizSizing"] = "right";
            oc_Newobject234["VertSizing"] = "bottom";
            oc_Newobject234["position"] = "10 60";
            oc_Newobject234["Extent"] = "183 18";
            oc_Newobject234["MinExtent"] = "8 2";
            oc_Newobject234["canSave"] = "1";
            oc_Newobject234["Visible"] = "1";
            oc_Newobject234["hovertime"] = "1000";
            oc_Newobject234["Margin"] = "0 0 0 0";
            oc_Newobject234["Padding"] = "0 0 0 0";
            oc_Newobject234["AnchorTop"] = "1";
            oc_Newobject234["AnchorBottom"] = "0";
            oc_Newobject234["AnchorLeft"] = "1";
            oc_Newobject234["AnchorRight"] = "0";
            oc_Newobject234["maxLength"] = "1024";
            oc_Newobject234["historySize"] = "0";
            oc_Newobject234["password"] = "0";
            oc_Newobject234["tabComplete"] = "0";
            oc_Newobject234["sinkAllKeyEvents"] = "0";
            oc_Newobject234["passwordMask"] = "*";

            #endregion

            oc_Newobject238["#Newobject234"] = oc_Newobject234;

            #region GuiWindowCtrl (matEd_changeCategory_ErrorDialog)        oc_Newobject237

            ObjectCreator oc_Newobject237 = new ObjectCreator("GuiWindowCtrl", "matEd_changeCategory_ErrorDialog");
            oc_Newobject237["canSaveDynamicFields"] = "0";
            oc_Newobject237["Enabled"] = "1";
            oc_Newobject237["isContainer"] = "1";
            oc_Newobject237["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject237["HorizSizing"] = "right";
            oc_Newobject237["VertSizing"] = "bottom";
            oc_Newobject237["position"] = "8 18";
            oc_Newobject237["Extent"] = "232 113";
            oc_Newobject237["MinExtent"] = "8 2";
            oc_Newobject237["canSave"] = "1";
            oc_Newobject237["Visible"] = "0";
            oc_Newobject237["hovertime"] = "1000";
            oc_Newobject237["Margin"] = "0 0 0 0";
            oc_Newobject237["Padding"] = "0 0 0 0";
            oc_Newobject237["AnchorTop"] = "1";
            oc_Newobject237["AnchorBottom"] = "0";
            oc_Newobject237["AnchorLeft"] = "1";
            oc_Newobject237["AnchorRight"] = "0";
            oc_Newobject237["resizeWidth"] = "0";
            oc_Newobject237["resizeHeight"] = "0";
            oc_Newobject237["canMove"] = "0";
            oc_Newobject237["canClose"] = "0";
            oc_Newobject237["canMinimize"] = "0";
            oc_Newobject237["canMaximize"] = "0";
            oc_Newobject237["minSize"] = "50 50";
            oc_Newobject237["EdgeSnap"] = "1";
            oc_Newobject237["text"] = "Category Change Error";

            #region GuiButtonCtrl (matEd_changeCategory_Error_Button)        oc_Newobject235

            ObjectCreator oc_Newobject235 = new ObjectCreator("GuiButtonCtrl", "matEd_changeCategory_Error_Button");
            oc_Newobject235["canSaveDynamicFields"] = "0";
            oc_Newobject235["Enabled"] = "1";
            oc_Newobject235["isContainer"] = "0";
            oc_Newobject235["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject235["HorizSizing"] = "right";
            oc_Newobject235["VertSizing"] = "bottom";
            oc_Newobject235["position"] = "72 81";
            oc_Newobject235["Extent"] = "80 24";
            oc_Newobject235["MinExtent"] = "8 2";
            oc_Newobject235["canSave"] = "1";
            oc_Newobject235["Visible"] = "1";
            oc_Newobject235["Command"] = "MaterialEditorGui.okChangeCategoryErrorDialog();";
            oc_Newobject235["hovertime"] = "1000";
            oc_Newobject235["text"] = "Ok";
            oc_Newobject235["groupNum"] = "-1";
            oc_Newobject235["buttonType"] = "PushButton";
            oc_Newobject235["useMouseEvents"] = "0";

            #endregion

            oc_Newobject237["#Newobject235"] = oc_Newobject235;

            #region GuiTextCtrl (matEd_changeCategory_error_Text)        oc_Newobject236

            ObjectCreator oc_Newobject236 = new ObjectCreator("GuiTextCtrl", "matEd_changeCategory_error_Text");
            oc_Newobject236["canSaveDynamicFields"] = "0";
            oc_Newobject236["Enabled"] = "1";
            oc_Newobject236["isContainer"] = "0";
            oc_Newobject236["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject236["HorizSizing"] = "right";
            oc_Newobject236["VertSizing"] = "bottom";
            oc_Newobject236["position"] = "8 31";
            oc_Newobject236["Extent"] = "215 40";
            oc_Newobject236["MinExtent"] = "8 2";
            oc_Newobject236["canSave"] = "1";
            oc_Newobject236["Visible"] = "1";
            oc_Newobject236["hovertime"] = "1000";
            oc_Newobject236["Margin"] = "0 0 0 0";
            oc_Newobject236["Padding"] = "0 0 0 0";
            oc_Newobject236["AnchorTop"] = "1";
            oc_Newobject236["AnchorBottom"] = "0";
            oc_Newobject236["AnchorLeft"] = "1";
            oc_Newobject236["AnchorRight"] = "0";
            oc_Newobject236["text"] = "Text goes here!";
            oc_Newobject236["maxLength"] = "1024";

            #endregion

            oc_Newobject237["#Newobject236"] = oc_Newobject236;

            #endregion

            oc_Newobject238["#Newobject237"] = oc_Newobject237;

            #endregion

            oc_Newobject239["#Newobject238"] = oc_Newobject238;

            #endregion

            oc_Newobject239.Create();
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
        public static bool operator ==(MaterialEditorPropertiesWindow ts, string simobjectid)
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
        public static bool operator !=(MaterialEditorPropertiesWindow ts, string simobjectid)
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
        public static implicit operator string(MaterialEditorPropertiesWindow ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MaterialEditorPropertiesWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (MaterialEditorPropertiesWindow)
                    Omni.self.getSimObject(simobjectid, typeof (MaterialEditorPropertiesWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MaterialEditorPropertiesWindow ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MaterialEditorPropertiesWindow(int simobjectid)
            {
            return
                (MaterialEditorPropertiesWindow)
                    Omni.self.getSimObject((uint) simobjectid, typeof (MaterialEditorPropertiesWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MaterialEditorPropertiesWindow ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MaterialEditorPropertiesWindow(uint simobjectid)
            {
            return
                (MaterialEditorPropertiesWindow)
                    Omni.self.getSimObject(simobjectid, typeof (MaterialEditorPropertiesWindow));
            }

        #endregion
        }
    }