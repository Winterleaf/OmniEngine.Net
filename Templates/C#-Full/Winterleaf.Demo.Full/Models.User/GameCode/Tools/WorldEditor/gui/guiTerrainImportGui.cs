using System;
using System.ComponentModel;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<guiTerrainImportGui>))]
    public class guiTerrainImportGui : GuiControl
        {
        

        [ConsoleInteraction(true, "guiTerrainImportGui_initialize")]
        public static void initialize()
            {
            #region GuiControl (TerrainImportGui, EditorGuiGroup)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "TerrainImportGui, EditorGuiGroup",
                typeof (guiTerrainImportGui));
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "0 0";
            oc_Newobject22["Extent"] = "800 600";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["isDecoy"] = "0";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["internalName"] = "TerrainImport";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject21["HorizSizing"] = "center";
            oc_Newobject21["VertSizing"] = "center";
            oc_Newobject21["Position"] = "119 84";
            oc_Newobject21["Extent"] = "391 257";
            oc_Newobject21["MinExtent"] = "391 257";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["isDecoy"] = "0";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "1";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "1";
            oc_Newobject21["resizeWidth"] = "1";
            oc_Newobject21["resizeHeight"] = "0";
            oc_Newobject21["canMove"] = "1";
            oc_Newobject21["canClose"] = "1";
            oc_Newobject21["canMinimize"] = "0";
            oc_Newobject21["canMaximize"] = "0";
            oc_Newobject21["minSize"] = "4 4";
            oc_Newobject21["closeCommand"] = "Canvas.popDialog( TerrainImportGui );";
            oc_Newobject21["EdgeSnap"] = "0";
            oc_Newobject21["text"] = "Import Terrain Height Map";

            #region GuiTextEditCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "HeightfieldFilename";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "top";
            oc_Newobject1["Position"] = "10 85";
            oc_Newobject1["Extent"] = "298 18";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["isDecoy"] = "0";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["text"] = " ";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["historySize"] = "0";
            oc_Newobject1["password"] = "0";
            oc_Newobject1["tabComplete"] = "0";
            oc_Newobject1["sinkAllKeyEvents"] = "0";
            oc_Newobject1["passwordMask"] = "*";

            #endregion

            oc_Newobject21["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "top";
            oc_Newobject2["Position"] = "11 66";
            oc_Newobject2["Extent"] = "120 20";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["text"] = "Height Map Image:";
            oc_Newobject2["maxLength"] = "1024";

            #endregion

            oc_Newobject21["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "left";
            oc_Newobject3["VertSizing"] = "top";
            oc_Newobject3["Position"] = "316 83";
            oc_Newobject3["Extent"] = "65 22";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "TerrainImportGui.browseForHeightfield();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "Browse...";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject21["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "MetersPerPixel";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject4["HorizSizing"] = "left";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["Position"] = "226 44";
            oc_Newobject4["Extent"] = "82 18";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["text"] = "1";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["password"] = "0";
            oc_Newobject4["tabComplete"] = "0";
            oc_Newobject4["sinkAllKeyEvents"] = "0";
            oc_Newobject4["passwordMask"] = "*";

            #endregion

            oc_Newobject21["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "top";
            oc_Newobject5["Position"] = "226 26";
            oc_Newobject5["Extent"] = "88 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Meters Per Pixel";
            oc_Newobject5["maxLength"] = "1024";

            #endregion

            oc_Newobject21["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "left";
            oc_Newobject6["VertSizing"] = "top";
            oc_Newobject6["Position"] = "316 26";
            oc_Newobject6["Extent"] = "64 18";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Height Scale:";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject21["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "HeightScale";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject7["HorizSizing"] = "left";
            oc_Newobject7["VertSizing"] = "top";
            oc_Newobject7["Position"] = "316 44";
            oc_Newobject7["Extent"] = "64 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["text"] = "256";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";
            oc_Newobject7["passwordMask"] = "*";

            #endregion

            oc_Newobject21["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "10 112";
            oc_Newobject8["Extent"] = "365 2";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["bitmap"] = "tools/gui/images/separator-v";
            oc_Newobject8["wrap"] = "0";

            #endregion

            oc_Newobject21["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "top";
            oc_Newobject9["Position"] = "14 123";
            oc_Newobject9["Extent"] = "74 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["isDecoy"] = "0";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "1";
            oc_Newobject9["text"] = "Texture Map";
            oc_Newobject9["maxLength"] = "1024";

            #endregion

            oc_Newobject21["#Newobject9"] = oc_Newobject9;

            #region GuiButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["HorizSizing"] = "left";
            oc_Newobject10["VertSizing"] = "top";
            oc_Newobject10["Position"] = "341 142";
            oc_Newobject10["Extent"] = "18 18";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["isDecoy"] = "0";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["Command"] = "TerrainImportGui.browseForOpacityMap();";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["text"] = "+";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "PushButton";
            oc_Newobject10["useMouseEvents"] = "0";

            #endregion

            oc_Newobject21["#Newobject10"] = oc_Newobject10;

            #region GuiButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject11["HorizSizing"] = "left";
            oc_Newobject11["VertSizing"] = "top";
            oc_Newobject11["Position"] = "341 165";
            oc_Newobject11["Extent"] = "18 18";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "TerrainImportGui.removeOpacitymap();";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["text"] = "-";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";

            #endregion

            oc_Newobject21["#Newobject11"] = oc_Newobject11;

            #region GuiButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "top";
            oc_Newobject12["Position"] = "195 225";
            oc_Newobject12["Extent"] = "88 24";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["isDecoy"] = "0";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "TerrainImportGui.import();";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["text"] = "Import";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["useMouseEvents"] = "0";

            #endregion

            oc_Newobject21["#Newobject12"] = oc_Newobject12;

            #region GuiScrollCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["internalName"] = "OpacityLayerScroll";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "top";
            oc_Newobject14["Position"] = "10 142";
            oc_Newobject14["Extent"] = "326 75";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["isDecoy"] = "0";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["willFirstRespond"] = "1";
            oc_Newobject14["hScrollBar"] = "alwaysOff";
            oc_Newobject14["vScrollBar"] = "dynamic";
            oc_Newobject14["lockHorizScroll"] = "true";
            oc_Newobject14["lockVertScroll"] = "false";
            oc_Newobject14["constantThumbHeight"] = "0";
            oc_Newobject14["childMargin"] = "0 0";

            #region GuiTextListCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextListCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["internalName"] = "OpacityLayerTextList";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiTextListProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "top";
            oc_Newobject13["Position"] = "1 1";
            oc_Newobject13["Extent"] = "293 2";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["isDecoy"] = "0";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["AltCommand"] = "TerrainImportGui.onOpacityListDblClick();";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["enumerate"] = "0";
            oc_Newobject13["resizeCell"] = "1";
            oc_Newobject13["columns"] = "0 250 300";
            oc_Newobject13["fitParentWidth"] = "1";
            oc_Newobject13["clipColumnText"] = "1";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject21["#Newobject14"] = oc_Newobject14;

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject15["HorizSizing"] = "left";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "264 123";
            oc_Newobject15["Extent"] = "48 18";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["isDecoy"] = "0";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["text"] = "Channels";
            oc_Newobject15["maxLength"] = "1024";

            #endregion

            oc_Newobject21["#Newobject15"] = oc_Newobject15;

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "11 26";
            oc_Newobject16["Extent"] = "64 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["isDecoy"] = "0";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "Name:";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject21["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "TerrainName";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "10 44";
            oc_Newobject17["Extent"] = "206 18";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["isDecoy"] = "0";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["text"] = "theTerrain";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["historySize"] = "0";
            oc_Newobject17["password"] = "0";
            oc_Newobject17["tabComplete"] = "0";
            oc_Newobject17["sinkAllKeyEvents"] = "0";
            oc_Newobject17["passwordMask"] = "*";

            #endregion

            oc_Newobject21["#Newobject17"] = oc_Newobject17;

            #region GuiButtonCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject18["HorizSizing"] = "left";
            oc_Newobject18["VertSizing"] = "top";
            oc_Newobject18["Position"] = "341 199";
            oc_Newobject18["Extent"] = "40 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["isDecoy"] = "0";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["Command"] = "TerrainImportGui.onOpacityListDblClick();";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["text"] = "Edit";
            oc_Newobject18["groupNum"] = "-1";
            oc_Newobject18["buttonType"] = "PushButton";
            oc_Newobject18["useMouseEvents"] = "0";

            #endregion

            oc_Newobject21["#Newobject18"] = oc_Newobject18;

            #region GuiButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject19["HorizSizing"] = "left";
            oc_Newobject19["VertSizing"] = "top";
            oc_Newobject19["Position"] = "293 225";
            oc_Newobject19["Extent"] = "88 24";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["isDecoy"] = "0";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["Command"] = "Canvas.popDialog( TerrainImportGui );";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["text"] = "Cancel";
            oc_Newobject19["groupNum"] = "-1";
            oc_Newobject19["buttonType"] = "PushButton";
            oc_Newobject19["useMouseEvents"] = "0";

            #endregion

            oc_Newobject21["#Newobject19"] = oc_Newobject19;

            #region GuiCheckBoxCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject20["text"] = " Flip Y axis?";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "ToggleButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["position"] = "12 222";
            oc_Newobject20["extent"] = "140 30";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["profile"] = "GuiCheckBoxProfile";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["active"] = "1";
            oc_Newobject20["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["internalName"] = "FlipYAxis";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject22.Create();


            omni.sGlobal["$TerrainImportGui::HeightFieldFilter"] =
                "Heightfield Files (*.png, *.bmp, *.jpg, *.gif)|*.png;*.bmp;*.jpg;*.gif|All Files (*.*)|*.*";
            omni.sGlobal["$TerrainImportGui::OpacityMapFilter"] =
                "Opacity Map Files (*.png, *.bmp, *.jpg, *.gif)|*.png;*.bmp;*.jpg;*.gif|All Files (*.*)|*.*";
            }

        /*
        function TerrainImportGui::onWake( %this )
        {   
           if ( !isObject( %this.namesArray ) )
              %this.namesArray = new ArrayObject();

           if ( !isObject( %this.channelsArray ) )
              %this.channelsArray = new ArrayObject();
        }
         * */

        public override void onWake()
            {
            if (!this["namesArray"].isObject())
                this["namesArray"] = new ObjectCreator("ArrayObject").Create().AsString();

            if (!this["channelsArray"].isObject())
                this["channelsArray"] = new ObjectCreator("ArrayObject").Create().AsString();
            }

        [ConsoleInteraction]
        public void import()
            {
            // Gather all the import settings.
            GuiTextEditCtrl HeightfieldFilename = this.findObjectByInternalName("HeightfieldFilename", true);
            string heightMapPng = HeightfieldFilename.getText();
            GuiTextEditCtrl MetersPerPixel = this.findObjectByInternalName("MetersPerPixel", true);
            string metersPerPixel = MetersPerPixel.getText();
            GuiTextEditCtrl HeightScale = findObjectByInternalName("HeightScale", true);
            string heightScale = HeightScale.getText();
            GuiCheckBoxCtrl FlipYAxis = findObjectByInternalName("FlipYAxis", true);
            bool flipYAxis = FlipYAxis.isStateOn();

            editor Editor = "Editor";
            // Grab and validate terrain object name.

            string terrainName = ((GuiTextEditCtrl) this.findObjectByInternalName("TerrainName", true)).getText();

            if (!terrainName.isObject() && ((SimObject) terrainName).isMemberOfClass("TerrainBlock") &&
                !Editor.validateObjectName(terrainName, false))
                return;

            string opacityNames = "";
            string materialNames = "";

            GuiTextListCtrl opacityList = this.findObjectByInternalName("OpacityLayerTextList", true);


            ArrayObject namesArray = this["namesArray"];
            ArrayObject channelsArray = this["channelsArray"];
            for (int i = 0; i < opacityList.rowCount(); i++)
                {
                string itemText = opacityList.getRowTextById(i);
                string opacityName = namesArray.getValue(i);
                string channelInfo = channelsArray.getValue(i);
                string channel = Util.getWord(channelInfo, 0);

                string materialName = Util.getField(itemText, 2);
                opacityNames += opacityName + "\t" + channel + "\n";
                materialNames += materialName + "\n";
                }

            int updated = Util.nameToID(terrainName);
            // This will update an existing terrain with the name %terrainName,
            // or create a new one if %terrainName isn't a TerrainBlock

            String obj = console.Call_Classname("TerrainBlock", "import",
                new string[]
                    {
                    terrainName, heightMapPng, metersPerPixel, heightScale, opacityNames, materialNames,
                    flipYAxis.AsString()
                    });

            ((GuiCanvas) "Canvas").popDialog(this);

            if (obj.isObject())
                {
                if (obj != updated.AsString())
                    // created a new TerrainBlock
                    // Submit an undo action. 
                    Extendable.MECreateUndoAction.submit(obj);

                EWorldEditor EWorldEditor = "EWorldEditor";

                if (!EWorldEditor.isObject())
                    throw new Exception("ObjectBuilderGui::processNewObject - EWorldEditor is missing!");

                // Select it in the editor.
                EWorldEditor.clearSelection();
                EWorldEditor.selectObject(obj);
                // When we drop the selection don't store undo
                // state for it... the creation deals with it.

                EWorldEditor.dropSelection(obj.AsBool());

                EWorldEditor.isDirty = true;
                //Copyright Winterleaf Entertainment L.L.C. 2013   
                ((TerrainPainter) "TerrainPainter").updateLayers("");
                //Copyright Winterleaf Entertainment L.L.C. 2013      
                }
            else
                {
                messageBox.MessageBoxOK("Import Terrain", "Terrain import failed! Check console for error messages.",
                    "Ok");
                }
            }


        /*

        function TerrainImportGui::doOpenDialog( %this, %filter, %callback )
        {
           %dlg = new OpenFileDialog()
           {
              Filters = %filter;
              DefaultFile = %currentFile;
              ChangePath = false;
              MustExist = true;
              MultipleFiles = false;
           };
   
           if(filePath( %currentFile ) !$= "")
              %dlg.DefaultPath = filePath(%currentFile);
           else
              %dlg.DefaultPath = getMainDotCSDir();
      
           if(%dlg.Execute())
              eval(%callback @ "(\"" @ %dlg.FileName @ "\");");
   
   
           %dlg.delete();
        }
        */

        [ConsoleInteraction]
        public void doOpenDialog(string filter, string callback)
            {
            var ofd = new System.Windows.Forms. OpenFileDialog
            {
                Filter = filter,
                FileName = sGlobal["$currentFile"],
                CheckFileExists = true,
                Multiselect = false
            };

            if (Util.filePath(sGlobal["$currentFile"]) != "")
                ofd.InitialDirectory = sGlobal["$currentFile"];
            else
                ofd.InitialDirectory = Util.getMainDotCsDir();

            DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

            /*ObjectCreator oc = new ObjectCreator("OpenFileDialog");
            oc["Filters"] = filter;
            oc["DefaultFile"] = new ObjectCreator.StringNoQuote("$currentFile");
            oc["ChangePath"] = false;
            oc["MustExist"] = true;
            oc["MultipleFiles"] = false;

            coOpenFileDialog dlg = oc.Create();

            if (Util.filePath(sGlobal["$currentFile"]) != "")
                dlg["DefaultPath"] = sGlobal["$currentFile"];
            else
                dlg["DefaultPath"] = Util.getMainDotCsDir();

            if (dlg.Execute())*/
            string file = Dialogs.GetForwardSlashFile(ofd.FileName);
            if (dr == DialogResult.OK)
                
                Util.eval(callback + "(\"" + file + "\");");

            //dlg.schedule("1", "delete");
            //dlg.delete();
            }

        [ConsoleInteraction]
        public static void TerrainImportGui_SetHeightfield(string name)
            {
            ((GuiTextEditCtrl)
                ((GuiControl) "TerrainImportGui").findObjectByInternalName("HeightfieldFilename", true)).setText(name);
            }

        /*
        function TerrainImportGui_SetHeightfield( %name )
        {
           TerrainImportGui-->HeightfieldFilename.setText( %name );
        }
        */

        [ConsoleInteraction]
        public void browseForHeightfield()
            {
            doOpenDialog(sGlobal["$TerrainImportGui::HeightFieldFilter"], "TerrainImportGui_SetHeightfield");
            }

        /*

        function TerrainImportGui::browseForHeightfield( %this )
        {
           %this.doOpenDialog( $TerrainImportGui::HeightFieldFilter, "TerrainImportGui_SetHeightfield" );
        }

         */

        [ConsoleInteraction]
        public static void TerrainImportGuiAddOpacityMap(string name)
            {
            // TODO: Need to actually look at
            // the file here and figure
            // out how many channels it has.
            string txt = omni.Util.makeRelativePath(name, omni.Util.getWorkingDirectory());
            // Will need to do this stuff
            // once per channel in the file
            // currently it works with just grayscale.   

            string channelsTxt = "R\tG\tB\tA";
            string bitmapInfo = omni.Util.getBitmapInfo(name);

            string channelCount = omni.Util.getWord(bitmapInfo, 2);

            GuiTextListCtrl opacityList =
                ((GuiControl) "TerrainImportGui").findObjectByInternalName("OpacityLayerTextList", true);

            guiTerrainImportGui TerrainImportGui = "TerrainImportGui";
            ArrayObject namesArray = TerrainImportGui["namesArray"];
            ArrayObject channelsArray = TerrainImportGui["channelsArray"];


            for (int i = 0; i < channelCount.AsInt(); i++)
                {
                namesArray.push_back(txt, name);
                channelsArray.push_back(txt, omni.Util.getWord(channelsTxt, i) + "/t" + channelCount);
                //TerrainImportGui.namesArray.echo();   
                int count = opacityList.rowCount();
                opacityList.addRow(count, txt + "/t" + omni.Util.getWord(channelsTxt, i), -1);
                }
            //OpacityMapListBox.addItem( %name );
            }

        /*      
              function TerrainImportGui::browseForOpacityMap( %this )
        {
           TerrainImportGui.doOpenDialog( $TerrainImportGui::OpacityMapFilter, "TerrainImportGuiAddOpacityMap" );
        }
        */

        [ConsoleInteraction]
        public void browseForOpacityMap()
            {
            doOpenDialog(sGlobal["$TerrainImportGui::OpacityMapFilter"], "TerrainImportGuiAddOpacityMap");
            }

        [ConsoleInteraction]
        public void removeOpacitymap()
            {
            GuiTextListCtrl opacityList =
                ((GuiControl) "TerrainImportGui").findObjectByInternalName("OpacityLayerTextList", true);
            int itemIdx = opacityList.getSelectedId();
            if (itemIdx < 0)
                return;

            ArrayObject namesArray = this["namesArray"];
            ArrayObject channelsArray = this["channelsArray"];

            namesArray.erase(itemIdx);
            channelsArray.erase(itemIdx);

            opacityList.removeRowById(itemIdx);
            }

        /*
        function TerrainImportGui::onOpacityListDblClick( %this )
        {
           %opacityList = %this-->OpacityLayerTextList;
   
           //echo( "Double clicked the opacity list control!" );
           %itemIdx = %opacityList.getSelectedId();
           if ( %itemIdx < 0 )
              return;

           %this.activeIdx = %itemIdx;
   
           %rowTxt = %opacityList.getRowTextById( %itemIdx );
           %matTxt = getField( %rowTxt, 2 );
           %matId = getField( %rowTxt, 3 );
         
           TerrainMaterialDlg.showByObjectId( %matId, TerrainImportGui_TerrainMaterialApplyCallback );
        }
         * */

        [ConsoleInteraction]
        public void onOpacityListDblClick()
            {
            GuiTextListCtrl opacityList =
                ((GuiControl) "TerrainImportGui").findObjectByInternalName("OpacityLayerTextList", true);

            int itemIdx = opacityList.getSelectedId();

            if (itemIdx < 0)
                return;

            this["activeIdx"] = itemIdx.AsString();
            string rowTxt = opacityList.getRowTextById(itemIdx);
            string matTxt = Util.getField(rowTxt, 2);
            string matID = Util.getField(rowTxt, 3);
            "TerrainMaterialDlg".call("showByObjectId",
                new string[] {matID, "TerrainImportGui_TerrainMaterialApplyCallback"});
            }

        [ConsoleInteraction]
        public static void TerrainImportGui_TerrainMaterialApplyCallback(string mat, string matIndex)
            {
            // Skip over a bad selection.
            if (!mat.isObject())
                return;
            GuiTextListCtrl opacityList =
                ((GuiControl) "TerrainImportGui").findObjectByInternalName("OpacityLayerTextList", true);
            string itemIdx = ((SimObject) "TerrainImportGui")["activeIdx"];

            if (itemIdx.AsInt() < 0 || itemIdx == "")
                return;

            string rowTxt = opacityList.getRowTextById(itemIdx.AsInt());

            int columTxtCount = omni.Util.getFieldCount(rowTxt);

            if (columTxtCount > 2)
                rowTxt = omni.Util.getFields(rowTxt, 0, 1);

            opacityList.setRowById(itemIdx.AsInt(), rowTxt + "\t" + ((SimObject) mat).internalName + "/t" + mat);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(guiTerrainImportGui ts, string simobjectid)
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
        public static bool operator !=(guiTerrainImportGui ts, string simobjectid)
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
        public static implicit operator string(guiTerrainImportGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator guiTerrainImportGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (guiTerrainImportGui) Omni.self.getSimObject(simobjectid, typeof (guiTerrainImportGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(guiTerrainImportGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator guiTerrainImportGui(int simobjectid)
            {
            return (guiTerrainImportGui) Omni.self.getSimObject((uint) simobjectid, typeof (guiTerrainImportGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(guiTerrainImportGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator guiTerrainImportGui(uint simobjectid)
            {
            return (guiTerrainImportGui) Omni.self.getSimObject(simobjectid, typeof (guiTerrainImportGui));
            }

        #endregion
        }
    }