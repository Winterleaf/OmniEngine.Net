using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<ColorPickerDlg>))]
    public class ColorPickerDlg : GuiColorPickerCtrl
        {
        

        [ConsoleInteraction(true, "ColorPickerDlg_initialize")]
        public static void initialize()
            {
            #region GuiColorPickerCtrl (ColorPickerDlg,EditorGuiGroup)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiColorPickerCtrl", "ColorPickerDlg,EditorGuiGroup",
                typeof (ColorPickerDlg));
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = "0 0";
            oc_Newobject25["Extent"] = "800 600";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["DisplayMode"] = "Dropper";
            oc_Newobject25["ActionOnMove"] = "1";

            #region GuiWindowCtrl (GuiPickerDlg)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiWindowCtrl", "GuiPickerDlg");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject24["HorizSizing"] = "windowRelative";
            oc_Newobject24["VertSizing"] = "windowRelative";
            oc_Newobject24["position"] = "170 100";
            oc_Newobject24["Extent"] = "348 347";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["text"] = "Color Picker";
            oc_Newobject24["maxLength"] = "255";
            oc_Newobject24["resizeWidth"] = "0";
            oc_Newobject24["resizeHeight"] = "0";
            oc_Newobject24["canMove"] = "1";
            oc_Newobject24["canClose"] = "1";
            oc_Newobject24["canMinimize"] = "0";
            oc_Newobject24["canMaximize"] = "0";
            oc_Newobject24["minSize"] = "50 50";
            oc_Newobject24["closeCommand"] =
                "DoColorPickerCancelCallback(); ColorPickerDlg.getRoot().popDialog(ColorPickerDlg);";

            #region GuiBitmapBorderCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject1["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject1["position"] = "3 24";
            oc_Newobject1["Extent"] = "255 258";

            #endregion

            oc_Newobject24["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapBorderCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject2["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject2["position"] = "263 23";
            oc_Newobject2["Extent"] = "25 261";

            #endregion

            oc_Newobject24["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapBorderCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject3["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject3["position"] = "292 37";
            oc_Newobject3["Extent"] = "52 99";

            #endregion

            oc_Newobject24["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapBorderCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject4["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject4["position"] = "292 209";
            oc_Newobject4["Extent"] = "52 75";

            #endregion

            oc_Newobject24["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapBorderCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject5["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject5["position"] = "3 287";
            oc_Newobject5["Extent"] = "341 24";

            #endregion

            oc_Newobject24["#Newobject5"] = oc_Newobject5;

            #region GuiColorPickerCtrl (ColorBlendSelect)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiColorPickerCtrl", "ColorBlendSelect");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "3 24";
            oc_Newobject6["Extent"] = "255 258";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["command"] = "updateRGBValues(1);";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["baseColor"] = "1 0 0 1";
            oc_Newobject6["PickColor"] = "0 0 0 1";
            oc_Newobject6["SelectorGap"] = "1";
            oc_Newobject6["DisplayMode"] = "BlendColor";
            oc_Newobject6["ActionOnMove"] = "1";

            #endregion

            oc_Newobject24["#Newobject6"] = oc_Newobject6;

            #region GuiColorPickerCtrl (ColorRangeSelect)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiColorPickerCtrl", "ColorRangeSelect");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "264 24";
            oc_Newobject7["Extent"] = "21 257";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "updatePickerBaseColor(1);";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["baseColor"] = "1 0 0 1";
            oc_Newobject7["PickColor"] = "1 0 0 1";
            oc_Newobject7["SelectorGap"] = "1";
            oc_Newobject7["DisplayMode"] = "VertColor";
            oc_Newobject7["ActionOnMove"] = "1";

            #endregion

            oc_Newobject24["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "298 215";
            oc_Newobject8["Extent"] = "8 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["text"] = "R";
            oc_Newobject8["maxLength"] = "255";

            #endregion

            oc_Newobject24["#Newobject8"] = oc_Newobject8;

            #region GuiTextEditCtrl (Channel_R_Val)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "Channel_R_Val");
            oc_Newobject9["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "307 215";
            oc_Newobject9["Extent"] = "34 18";
            oc_Newobject9["text"] = "0";
            oc_Newobject9["maxLength"] = "4";
            oc_Newobject9["altCommand"] = "setColorInfo();";

            #endregion

            oc_Newobject24["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "297 238";
            oc_Newobject10["Extent"] = "8 18";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["text"] = "G";
            oc_Newobject10["maxLength"] = "255";

            #endregion

            oc_Newobject24["#Newobject10"] = oc_Newobject10;

            #region GuiTextEditCtrl (Channel_G_Val)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextEditCtrl", "Channel_G_Val");
            oc_Newobject11["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "307 238";
            oc_Newobject11["Extent"] = "34 18";
            oc_Newobject11["text"] = "0";
            oc_Newobject11["maxLength"] = "4";
            oc_Newobject11["altCommand"] = "setColorInfo();";

            #endregion

            oc_Newobject24["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "298 261";
            oc_Newobject12["Extent"] = "8 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["text"] = "B";
            oc_Newobject12["maxLength"] = "255";

            #endregion

            oc_Newobject24["#Newobject12"] = oc_Newobject12;

            #region GuiTextEditCtrl (Channel_B_Val)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "Channel_B_Val");
            oc_Newobject13["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "307 261";
            oc_Newobject13["Extent"] = "34 18";
            oc_Newobject13["text"] = "0";
            oc_Newobject13["maxLength"] = "4";
            oc_Newobject13["altCommand"] = "setColorInfo();";

            #endregion

            oc_Newobject24["#Newobject13"] = oc_Newobject13;

            #region GuiControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject17["class"] = "AggregateControl";
            oc_Newobject17["position"] = "2 290";
            oc_Newobject17["Extent"] = "341 18";

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "267 0";
            oc_Newobject14["Extent"] = "29 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["text"] = "Alpha";
            oc_Newobject14["maxLength"] = "255";

            #endregion

            oc_Newobject17["#Newobject14"] = oc_Newobject14;

            #region GuiSliderCtrl (ColorAlphaSelect)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiSliderCtrl", "ColorAlphaSelect");
            oc_Newobject15["internalName"] = "slider";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "5 3";
            oc_Newobject15["Extent"] = "251 13";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["altCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); updateColorPickerAlpha( $ThisControl.getValue() );";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["range"] = "0 1";
            oc_Newobject15["ticks"] = "0";
            oc_Newobject15["value"] = "1";

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiTextEditCtrl (Channel_A_Val)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextEditCtrl", "Channel_A_Val");
            oc_Newobject16["internalName"] = "textEdit";
            oc_Newobject16["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "305 0";
            oc_Newobject16["Extent"] = "34 18";
            oc_Newobject16["text"] = "0";
            oc_Newobject16["maxLength"] = "4";
            oc_Newobject16["altCommand"] =
                "$ThisControl.getParent().updateFromChild($ThisControl); updateColorPickerAlpha( $ThisControl.getValue() );";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject24["#Newobject17"] = oc_Newobject17;

            #region GuiSwatchButtonCtrl (myColor)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiSwatchButtonCtrl", "myColor");
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["position"] = "293 38";
            oc_Newobject18["Extent"] = "50 50";

            #endregion

            oc_Newobject24["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["text"] = "New";
            oc_Newobject19["position"] = "306 22";
            oc_Newobject19["Extent"] = "26 14";

            #endregion

            oc_Newobject24["#Newobject19"] = oc_Newobject19;

            #region GuiSwatchButtonCtrl (oldColor)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiSwatchButtonCtrl", "oldColor");
            oc_Newobject20["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["position"] = "293 85";
            oc_Newobject20["Extent"] = "50 50";

            #endregion

            oc_Newobject24["#Newobject20"] = oc_Newobject20;

            #region GuiTextCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["text"] = "Old";
            oc_Newobject21["position"] = "310 138";
            oc_Newobject21["Extent"] = "26 14";

            #endregion

            oc_Newobject24["#Newobject21"] = oc_Newobject21;

            #region GuiButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "144 316";
            oc_Newobject22["Extent"] = "115 24";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["Command"] = "DoColorPickerCallback();";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["text"] = "Select";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["buttonType"] = "PushButton";
            oc_Newobject22["useMouseEvents"] = "0";

            #endregion

            oc_Newobject24["#Newobject22"] = oc_Newobject22;

            #region GuiButtonCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "268 316";
            oc_Newobject23["Extent"] = "73 24";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["Command"] = "DoColorPickerCancelCallback();";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["text"] = "Cancel";
            oc_Newobject23["groupNum"] = "-1";
            oc_Newobject23["buttonType"] = "PushButton";
            oc_Newobject23["useMouseEvents"] = "0";

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject25.Create();

            omni.sGlobal["$ColorPickerCallback"] = ""; // Control that we need to update
            omni.sGlobal["$ColorPickerCancelCallback"] = "";
            omni.sGlobal["$ColorPickerUpdateCallback"] = "";
            omni.iGlobal["$ColorCallbackType"] = 1; // ColorI
            }

        [ConsoleInteraction]
        public static string ColorFloatToInt(string color)
            {
            string red = omni.Util.getWord(color, 0);
            string green = omni.Util.getWord(color, 1);
            string blue = omni.Util.getWord(color, 2);
            string alpha = omni.Util.getWord(color, 3);

            return omni.Util.mCeil(red.AsFloat()*255).AsString() + " " + omni.Util.mCeil(green.AsFloat()*255).AsString() +
                   " " + omni.Util.mCeil(blue.AsFloat()*255).AsString() + " " +
                   omni.Util.mCeil(alpha.AsFloat()*255).AsString();
            }

        [ConsoleInteraction]
        public static string ColorIntToFloat(string color)
            {
            string red = omni.Util.getWord(color, 0);
            string green = omni.Util.getWord(color, 1);
            string blue = omni.Util.getWord(color, 2);
            string alpha = omni.Util.getWord(color, 3);

            return (red.AsFloat()/255).AsString() + " " + (green.AsFloat()/255).AsString() + " " +
                   (blue.AsFloat()/255).AsString() + " " + (alpha.AsFloat()/255).AsString();
            }

        [ConsoleInteraction]
        // This function pushes the color picker dialog and returns to a callback the selected value
        public static void GetColorI(string currentColor, string callback, string root, string updateCallback,
            string cancelCallback)
            {
            GuiSwatchButtonCtrl oldColor = "oldColor";
            GuiSwatchButtonCtrl myColor = "myColor";
            GuiColorPickerCtrl ColorRangeSelect = "ColorRangeSelect";
            GuiColorPickerCtrl ColorBlendSelect = "ColorBlendSelect";
            GuiSliderCtrl ColorAlphaSelect = "ColorAlphaSelect";
            GuiCanvas Canvas = "Canvas";
            GuiTextEditCtrl Channel_A_Val = "Channel_A_Val";
            ColorPickerDlg ColorPickerDlg = "ColorPickerDlg";

            omni.bGlobal["$ColorPickerSignal"] = true;
            omni.sGlobal["$ColorPickerCallback"] = callback;
            omni.sGlobal["$ColorPickerCancelCallback"] = cancelCallback;
            omni.sGlobal["$ColorPickerUpdateCallback"] = updateCallback;
            omni.iGlobal["$ColorCallbackType"] = 1; // ColorI

            oldColor.color = ColorIntToFloat(currentColor).AsColorF();
            myColor.color = ColorIntToFloat(currentColor).AsColorF();

            ColorRangeSelect.showReticle = true;
            ColorBlendSelect.showReticle = true;

            // Set the range according to int
            ColorAlphaSelect.range = "0 255".AsPoint2F();

            // Set the RGBA displays accordingly
            float red = omni.Util.getWord(currentColor, 0).AsFloat()/255;
            float green = omni.Util.getWord(currentColor, 1).AsFloat()/255;
            float blue = omni.Util.getWord(currentColor, 2).AsFloat()/255;
            float alpha = omni.Util.getWord(currentColor, 3).AsFloat();

            // set the initial range blend to correct color, no alpha needed
            // this should also set the color blend select right now
            ColorRangeSelect.baseColor = (red.AsString() + " " + green.AsString() + " " + blue.AsString() + " " + "1.0").AsColorF();
            ColorRangeSelect.updateColor();

            if (!root.isObject())
                root = Canvas;

            ((GuiCanvas) root).pushDialog(ColorPickerDlg);

            // update the alpha value first
            ColorAlphaSelect.setValue(alpha.AsString());
            Channel_A_Val.setText(alpha.AsString());
            }

        [ConsoleInteraction]
        public static void GetColorF(string currentColor, string callback, string root, string updateCallback,
            string cancelCallback)
            {
            GuiSwatchButtonCtrl oldColor = "oldColor";
            GuiSwatchButtonCtrl myColor = "myColor";
            GuiColorPickerCtrl ColorRangeSelect = "ColorRangeSelect";
            GuiColorPickerCtrl ColorBlendSelect = "ColorBlendSelect";
            GuiSliderCtrl ColorAlphaSelect = "ColorAlphaSelect";
            GuiCanvas Canvas = "Canvas";
            GuiTextEditCtrl Channel_A_Val = "Channel_A_Val";
            ColorPickerDlg ColorPickerDlg = "ColorPickerDlg";

            omni.bGlobal["$ColorPickerSignal"] = true;
            omni.sGlobal["$ColorPickerCallback"] = callback;
            omni.sGlobal["$ColorPickerCancelCallback"] = cancelCallback;
            omni.sGlobal["$ColorPickerUpdateCallback"] = updateCallback;
            omni.iGlobal["$ColorCallbackType"] = 2; // ColorF

            oldColor.color = currentColor.AsColorF();
            myColor.color = currentColor.AsColorF();

            ColorRangeSelect.showReticle = true;
            ColorBlendSelect.showReticle = true;

            // Set the range according to float
            ColorAlphaSelect.range = "0 1".AsPoint2F();

            // Set the RGBA displays accordingly
            string red = omni.Util.getWord(currentColor, 0);
            string green = omni.Util.getWord(currentColor, 1);
            string blue = omni.Util.getWord(currentColor, 2);
            string alpha = omni.Util.getWord(currentColor, 3);

            // set the initial range blend to correct color, no alpha needed
            // this should also set the color blend select right now
            ColorRangeSelect.baseColor = (red + " " + green + " " + blue + " " + "1.0").AsColorF();
            ColorRangeSelect.updateColor();

            if (!root.isObject())
                root = Canvas;
            ((GuiCanvas) root).pushDialog(ColorPickerDlg);

            // update the alpha value first
            ColorAlphaSelect.setValue(alpha);
            Channel_A_Val.setText(alpha);
            }

        [ConsoleInteraction]
        // This function is used to update the text controls at the top
        public static void setColorInfo()
            {
            GuiTextEditCtrl Channel_R_Val = "Channel_R_Val";
            GuiTextEditCtrl Channel_G_Val = "Channel_G_Val";
            GuiTextEditCtrl Channel_B_Val = "Channel_B_Val";
            GuiColorPickerCtrl ColorBlendSelect = "ColorBlendSelect";

            string red = Channel_R_Val.getValue();
            string green = Channel_G_Val.getValue();
            string blue = Channel_B_Val.getValue();

            if (omni.iGlobal["$ColorCallbackType"] == 1)
                {
                red = (red.AsFloat()/255).AsString();
                green = (green.AsFloat()/255).AsString();
                blue = (blue.AsFloat()/255).AsString();
                }

            omni.iGlobal["$ColorPickerSignal"] = 1;

            ColorBlendSelect.baseColor = (red + " " + green + " " + blue + " " + "1.0").AsColorF();
            ColorBlendSelect.updateColor();
            }

        [ConsoleInteraction]
        // return mycolor.color
        public static void DoColorPickerCallback()
            {
            ColorPickerDlg ColorPickerDlg = "ColorPickerDlg";
            GuiSwatchButtonCtrl myColor = "myColor";

            omni.Util.eval(omni.sGlobal["$ColorPickerCallback"] + "(\"" +
                            constructNewColor(myColor.color.AsString(), omni.iGlobal["$ColorCallbackType"]) + "\");");
            ((GuiCanvas) ColorPickerDlg.getRoot()).popDialog(ColorPickerDlg);
            }

        [ConsoleInteraction]
        public static void DoColorPickerCancelCallback()
            {
            ColorPickerDlg ColorPickerDlg = "ColorPickerDlg";
            GuiSwatchButtonCtrl oldColor = "oldColor";

            ((GuiCanvas) ColorPickerDlg.getRoot()).popDialog(ColorPickerDlg);
            if (omni.sGlobal["$ColorPickerCancelCallback"] != "")
                omni.Util.eval(omni.sGlobal["$ColorPickerCancelCallback"] + "(\"" +
                                constructNewColor(oldColor.color.AsString(), omni.iGlobal["$ColorCallbackType"]) +
                                "\");");
            }

        [ConsoleInteraction]
        public static void DoColorPickerUpdateCallback()
            {
            GuiSwatchButtonCtrl myColor = "myColor";

            if (omni.sGlobal["$ColorPickerUpdateCallback"] != "")
                omni.Util.eval(omni.sGlobal["$ColorPickerUpdateCallback"] + "(\"" +
                                constructNewColor(myColor.color.AsString(), omni.iGlobal["$ColorCallbackType"]) + "\");");
            }

        [ConsoleInteraction]
        // this is called from ColorRangeSelect.updateColor
        public static void updatePickerBaseColor(bool location)
            {
            GuiColorPickerCtrl ColorRangeSelect = "ColorRangeSelect";
            GuiColorPickerCtrl ColorBlendSelect = "ColorBlendSelect";

            string pickColor;

            if (omni.bGlobal["$ColorPickerSignal"] && location)
                pickColor = ColorRangeSelect.baseColor.AsString();
            else
                pickColor = ColorRangeSelect.pickColor.AsString();

            omni.bGlobal["$ColorPickerSignal"] = true;

            string red = omni.Util.getWord(pickColor, 0);
            string green = omni.Util.getWord(pickColor, 1);
            string blue = omni.Util.getWord(pickColor, 2);
            string alpha = omni.Util.getWord(pickColor, 3);

            ColorBlendSelect.baseColor = (red + " " + green + " " + blue + " " + "1.0").AsColorF();
            ColorBlendSelect.updateColor();
            }

        [ConsoleInteraction]
        // this is called from ColorBlendSelect.updateColor
        public static void updateRGBValues(bool location)
            {
            GuiColorPickerCtrl ColorBlendSelect = "ColorBlendSelect";
            GuiTextEditCtrl Channel_R_Val = "Channel_R_Val";
            GuiTextEditCtrl Channel_G_Val = "Channel_G_Val";
            GuiTextEditCtrl Channel_B_Val = "Channel_B_Val";
            GuiSwatchButtonCtrl myColor = "myColor";

            string pickColor;

            //update the color based on where it came from
            if (omni.bGlobal["$ColorPickerSignal"] && location)
                pickColor = ColorBlendSelect.baseColor.AsString();
            else
                pickColor = ColorBlendSelect.pickColor.AsString();

            //lets prepare the color
            string red = omni.Util.getWord(pickColor, 0);
            string green = omni.Util.getWord(pickColor, 1);
            string blue = omni.Util.getWord(pickColor, 2);
            //the alpha should be grabbed from mycolor
            string alpha = omni.Util.getWord(myColor.color.AsString(), 3);

            // set the color!
            myColor.color = (red + " " + green + " " + blue + " " + alpha).AsColorF();

            DoColorPickerUpdateCallback();

            //update differently depending on type
            if (omni.iGlobal["$ColorCallbackType"] == 1)
                {
                red = omni.Util.mCeil(red.AsFloat()*255).AsString();
                blue = omni.Util.mCeil(blue.AsFloat()*255).AsString();
                green = omni.Util.mCeil(green.AsFloat()*255).AsString();
                }
            else
                {
                red = omni.Util.mFloatLength(red.AsFloat(), 3);
                blue = omni.Util.mFloatLength(blue.AsFloat(), 3);
                green = omni.Util.mFloatLength(green.AsFloat(), 3);
                }

            // changes current color values
            Channel_R_Val.setValue(red);
            Channel_G_Val.setValue(green);
            Channel_B_Val.setValue(blue);

            omni.bGlobal["$ColorPickerSignal"] = false;
            }

        [ConsoleInteraction]
        public static void updateColorPickerAlpha(string alphaVal)
            {
            GuiSwatchButtonCtrl myColor = "myColor";

            //lets prepare the color
            string red = omni.Util.getWord(myColor.color.AsString(), 0);
            string green = omni.Util.getWord(myColor.color.AsString(), 1);
            string blue = omni.Util.getWord(myColor.color.AsString(), 2);
            string alpha = alphaVal;

            if (omni.iGlobal["$ColorCallbackType"] == 1)
                alpha = (alpha.AsFloat()/255).AsString();

            myColor.color = (red + " " + green + " " + blue + " " + alpha).AsColorF();

            DoColorPickerUpdateCallback();
            }

        [ConsoleInteraction]
        public static string constructNewColor(string pickColor, int colorType)
            {
            string red = omni.Util.getWord(pickColor, 0);
            string green = omni.Util.getWord(pickColor, 1);
            string blue = omni.Util.getWord(pickColor, 2);
            string alpha = omni.Util.getWord(pickColor, 3); // Copyright (C) 2013 WinterLeaf Entertainment LLC.

            // Update the text controls to reflect new color
            //setColorInfo(red, green, blue, alpha);
            if (colorType == 1) // ColorI
                return omni.Util.mCeil(red.AsFloat()*255).AsString() + " " +
                       omni.Util.mCeil(green.AsFloat()*255).AsString() + " " +
                       omni.Util.mCeil(blue.AsFloat()*255).AsString() + " " +
                       /* Copyright (C) 2013 WinterLeaf Entertainment LLC. */
                       omni.Util.mCeil(alpha.AsFloat()*255).AsString();
            else // ColorF
                return red + " " + green + " " + blue + " " + alpha;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ColorPickerDlg ts, string simobjectid)
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
        public static bool operator !=(ColorPickerDlg ts, string simobjectid)
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
        public static implicit operator string(ColorPickerDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ColorPickerDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ColorPickerDlg) Omni.self.getSimObject(simobjectid, typeof (ColorPickerDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ColorPickerDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ColorPickerDlg(int simobjectid)
            {
            return (ColorPickerDlg) Omni.self.getSimObject((uint) simobjectid, typeof (ColorPickerDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ColorPickerDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ColorPickerDlg(uint simobjectid)
            {
            return (ColorPickerDlg) Omni.self.getSimObject(simobjectid, typeof (ColorPickerDlg));
            }

        #endregion
        }
    }