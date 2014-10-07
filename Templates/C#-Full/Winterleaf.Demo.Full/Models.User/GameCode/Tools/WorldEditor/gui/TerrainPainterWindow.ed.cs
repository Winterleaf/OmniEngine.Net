using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    [TypeConverter(typeof (TerrainPainterWindow))]
    public class TerrainPainterWindow : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction(true, "TerrainPainterWindow_initialize")]
        public static uint initialize()
            {
            #region GuiControl (TerrainPainterContainer,EditorGuiGroup)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControl", "TerrainPainterContainer,EditorGuiGroup");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "0 0";
            oc_Newobject11["Extent"] = "800 600";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (TerrainPainter)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiWindowCollapseCtrl", "TerrainPainter",
                typeof (TerrainPainter));
            oc_Newobject3["AllowPopWindow"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "TerrainPainter";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject3["HorizSizing"] = "windowRelative";
            oc_Newobject3["VertSizing"] = "windowRelative";
            oc_Newobject3["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1)+249");
            oc_Newobject3["Extent"] = "210 446";
            oc_Newobject3["MinExtent"] = "210 100";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "0";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Docking"] = "None";
            oc_Newobject3["Margin"] = "4 4 4 4";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "0";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "0";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["resizeWidth"] = "1";
            oc_Newobject3["resizeHeight"] = "1";
            oc_Newobject3["canMove"] = "1";
            oc_Newobject3["canClose"] = "0";
            oc_Newobject3["canMinimize"] = "0";
            oc_Newobject3["canMaximize"] = "0";
            oc_Newobject3["minSize"] = "152 300";
            oc_Newobject3["closeCommand"] = "TerrainPainter.parentGroup.setVisible(false);";
            oc_Newobject3["EdgeSnap"] = "1";
            oc_Newobject3["text"] = "Terrain Painter Material Selector";

            #region GuiTextEditCtrl (TerrainSelectorTextEdit)        oc_Newobject100

            ObjectCreator oc_Newobject100 = new ObjectCreator("GuiTextEditCtrl", "TerrainSelectorTextEdit", typeof(TerrainPainter.TerrainSelectorTextEdit));
            oc_Newobject100["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject100["HorizSizing"] = "width";
            oc_Newobject100["VertSizing"] = "bottom";
            oc_Newobject100["position"] = "4 25";
            oc_Newobject100["Extent"] = "177 18";

            #endregion

            oc_Newobject3["#Newobject100"] = oc_Newobject100;

            #region GuiBitmapButtonCtrl (TerrainSelectorClearButton)        oc_Newobject101

            ObjectCreator oc_Newobject101 = new ObjectCreator("GuiBitmapButtonCtrl", "TerrainSelectorClearButton", typeof(TerrainPainter.TerrainSelectorClearButton));
            oc_Newobject101["canSaveDynamicFields"] = "0";
            oc_Newobject101["isContainer"] = "0";
            oc_Newobject101["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject101["HorizSizing"] = "left";
            oc_Newobject101["VertSizing"] = "bottom";
            oc_Newobject101["position"] = "187 25";
            oc_Newobject101["Extent"] = "17 17";
            oc_Newobject101["MinExtent"] = "8 2";
            oc_Newobject101["canSave"] = "1";
            oc_Newobject101["Visible"] = "1";
            oc_Newobject101["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject101["groupNum"] = "-1";
            oc_Newobject101["buttonType"] = "PushButton";
            oc_Newobject101["useMouseEvents"] = "0";
            oc_Newobject101["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject101["textCtrl"] = new ObjectCreator.StringNoQuote("TerrainSelectorTextEdit");

            #endregion

            oc_Newobject3["#Newobject101"] = oc_Newobject101;

            #region GuiScrollCtrl ( EPainterScroll )        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "EPainterScroll");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "4 47";
            oc_Newobject2["Extent"] = "202 395";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Docking"] = "Bottom";
            oc_Newobject2["Margin"] = "3 1 3 3";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "true";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";

            #region GuiStackControl ( EPainterStack )        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiStackControl", "EPainterStack");
            oc_Newobject1["StackingType"] = "Vertical";
            oc_Newobject1["HorizStacking"] = "Left to Right";
            oc_Newobject1["VertStacking"] = "Top to Bottom";
            oc_Newobject1["Padding"] = "-2";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "theMaterialList";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "1 3";
            oc_Newobject1["Extent"] = "200 16";
            oc_Newobject1["MinExtent"] = "16 16";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["isDecoy"] = "0";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiWindowCollapseCtrl (TerrainPainterPreview)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiWindowCollapseCtrl", "TerrainPainterPreview",
                typeof (TerrainPainterWindow));
            oc_Newobject10["AllowPopWindow"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "TerrainPainterPreview";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject10["HorizSizing"] = "windowRelative";
            oc_Newobject10["VertSizing"] = "windowRelative";
            oc_Newobject10["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject10["Extent"] = "210 251";
            oc_Newobject10["MinExtent"] = "210 251";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["isDecoy"] = "0";
            oc_Newobject10["Visible"] = "0";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Docking"] = "None";
            oc_Newobject10["Margin"] = "4 4 4 4";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "0";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "0";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["resizeWidth"] = "1";
            oc_Newobject10["resizeHeight"] = "1";
            oc_Newobject10["canMove"] = "1";
            oc_Newobject10["canClose"] = "0";
            oc_Newobject10["canMinimize"] = "0";
            oc_Newobject10["canMaximize"] = "0";
            oc_Newobject10["minSize"] = "152 300";
            oc_Newobject10["closeCommand"] = "TerrainPainter.parentGroup.setVisible(false);";
            oc_Newobject10["EdgeSnap"] = "1";
            oc_Newobject10["text"] = "Terrain Painter Material Preview";

            #region GuiContainer ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiContainer", "");
            oc_Newobject6["Docking"] = "Client";
            oc_Newobject6["Margin"] = "3 22 3 3";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "4 24";
            oc_Newobject6["Extent"] = "202 202";

            #region GuiBitmapCtrl (ETerrainMaterialSelected)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "ETerrainMaterialSelected");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "202 202";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["wrap"] = "0";
            oc_Newobject4["bitmap"] = "tools/materialeditor/gui/unknownImage";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl (ETerrainMaterialSelectedBorder)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "ETerrainMaterialSelectedBorder");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "202 202";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/worldEditor/images/terrainpainter/terrain-painter-border-large";
            oc_Newobject5["wrap"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl (ETerrainMaterialSelectedEdit)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "ETerrainMaterialSelectedEdit");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "left";
            oc_Newobject7["VertSizing"] = "top";
            oc_Newobject7["Position"] = "170 229";
            oc_Newobject7["Extent"] = "36 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "0";
            oc_Newobject7["Command"] =
                "TerrainMaterialDlg.show(ETerrainMaterialSelected.selectedMatIndex, ETerrainMaterialSelected.selectedMat, EPainter_TerrainMaterialUpdateCallback);";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Edit";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl (TerrainTextureText)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "TerrainTextureText");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "top";
            oc_Newobject8["Position"] = "5 230";
            oc_Newobject8["Extent"] = "162 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "None";
            oc_Newobject8["maxLength"] = "1024";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "GuiButtonProfile";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "100 229";
            oc_Newobject9["Extent"] = "50 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "autoLayers();";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["tooltip"] = "Generate a layer mask for this material.";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["text"] = "AutoPaint";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            return oc_Newobject11.Create();
            }

        public override void onPopWindow()
            {
            EditorGui.DeactivateAll();
            CodeBehind.PlugIns.TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            TerrainPainterPlugin.onActivated();
            }

        public override void onPopWindowClosed()
            {
            EditorGui.DeactivateAll();
            CodeBehind.PlugIns.TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            TerrainPainterPlugin.onActivated();
            TerrainPainter TerrainPainter = "TerrainPainter";
            TerrainPainter.attachTo("TerrainPainterPreview");
            }
        }
    }