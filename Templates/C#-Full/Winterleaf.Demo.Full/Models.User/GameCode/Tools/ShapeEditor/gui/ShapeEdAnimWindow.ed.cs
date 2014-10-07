using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEdAnimWindow>))]
    public class ShapeEdAnimWindow : GuiWindowCtrl
        {
        public bool usingProxySeq
            {
            get { return this["usingProxySeq"].AsBool(); }

            set { this["usingProxySeq"] = value.AsString(); }
            }

        public float seqStartFrame
            {
            get { return this["seqStartFrame"].AsFloat(); }

            set { this["seqStartFrame"] = value.AsString(); }
            }

        public float seqEndFrame
            {
            get { return this["seqEndFrame"].AsFloat(); }

            set { this["seqEndFrame"] = value.AsString(); }
            }

        [ConsoleInteraction(true, "ShapeEdAnimWindow_initialize")]
        public static void initialize()
            {
            #region GuiWindowCtrl (ShapeEdAnimWindow)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiWindowCtrl", "ShapeEdAnimWindow",
                typeof (ShapeEdAnimWindow));
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["Profile"] = "ToolsGuiToolbarWindowProfile";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "top";
            oc_Newobject23["Position"] = new ObjectCreator.StringNoQuote("-1 SPC getWord(ShapeEdPreviewGui.extent,0)-94");
            oc_Newobject23["Extent"] = "817 53";
            oc_Newobject23["MinExtent"] = "475 53";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["Margin"] = "4 4 4 4";
            oc_Newobject23["Padding"] = "0 0 0 0";
            oc_Newobject23["AnchorTop"] = "1";
            oc_Newobject23["AnchorBottom"] = "0";
            oc_Newobject23["AnchorLeft"] = "1";
            oc_Newobject23["AnchorRight"] = "0";
            oc_Newobject23["resizeWidth"] = "1";
            oc_Newobject23["resizeHeight"] = "0";
            oc_Newobject23["canMove"] = "1";
            oc_Newobject23["canClose"] = "0";
            oc_Newobject23["canMinimize"] = "0";
            oc_Newobject23["canMaximize"] = "0";
            oc_Newobject23["minSize"] = "50 50";
            oc_Newobject23["EdgeSnap"] = "0";
            oc_Newobject23["canCollapse"] = "0";
            oc_Newobject23["text"] = "";

            #region GuiContainer ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiContainer", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["HorizSizing"] = "width";
            oc_Newobject22["VertSizing"] = "top";
            oc_Newobject22["Position"] = "5 10";
            oc_Newobject22["Extent"] = "809 ";
            oc_Newobject22["MinExtent"] = "8 8";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "top";
            oc_Newobject19["Position"] = "0 3";
            oc_Newobject19["Extent"] = "809 38";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["HorizSizing"] = "left";
            oc_Newobject1["VertSizing"] = "top";
            oc_Newobject1["position"] = "740 19";
            oc_Newobject1["Extent"] = "35 16";
            oc_Newobject1["text"] = "Frame:";

            #endregion

            oc_Newobject19["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "top";
            oc_Newobject2["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject2["position"] = "778 19";
            oc_Newobject2["Extent"] = "26 18";
            oc_Newobject2["Variable"] = "$ShapeEdCurrentFrame";

            #endregion

            oc_Newobject19["#Newobject2"] = oc_Newobject2;

            #region GuiTextEditCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject3["internalName"] = "seqIn";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "28 18";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["AltCommand"] = "ShapeEdSequences.onEditSeqInOut(\\\"in\\\", $ThisControl.getText());";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Set the In Point to the Current Frame";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["maxLength"] = "5";
            oc_Newobject3["historySize"] = "0";
            oc_Newobject3["password"] = "0";
            oc_Newobject3["tabComplete"] = "0";
            oc_Newobject3["sinkAllKeyEvents"] = "0";
            oc_Newobject3["passwordMask"] = "*";

            #endregion

            oc_Newobject19["#Newobject3"] = oc_Newobject3;

            #region GuiSliderCtrl (ShapeEdSeqSlider)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiSliderCtrl", "ShapeEdSeqSlider",
                typeof (CodeBehind.ShapeEditor.ShapeEdSeqSlider));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "35 4";
            oc_Newobject4["Extent"] = "736 20";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["range"] = "0 255";
            oc_Newobject4["ticks"] = "0";
            oc_Newobject4["value"] = "0";
            oc_Newobject4["Variable"] = "$ShapeEdCurrentFrame";

            #endregion

            oc_Newobject19["#Newobject4"] = oc_Newobject4;

            #region GuiTextEditCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject5["internalName"] = "seqOut";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "778 0";
            oc_Newobject5["Extent"] = "28 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["AltCommand"] = "ShapeEdSequences.onEditSeqInOut(\\\"out\\\", $ThisControl.getText());";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Set the Out Point to the Current Frame";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["maxLength"] = "5";
            oc_Newobject5["historySize"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["tabComplete"] = "0";
            oc_Newobject5["sinkAllKeyEvents"] = "0";
            oc_Newobject5["passwordMask"] = "*";

            #endregion

            oc_Newobject19["#Newobject5"] = oc_Newobject5;

            #region GuiControl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiControl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["HorizSizing"] = "center";
            oc_Newobject18["VertSizing"] = "top";
            oc_Newobject18["position"] = "194 17";
            oc_Newobject18["extent"] = "420 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";

            #region GuiButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "28 18";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "ShapeEdSequences.onEditSeqInOut(\\\"in\\\", ShapeEdSeqSlider.getValue());";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Set the in position to the current frame (I)";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "in";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject18["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "48 0";
            oc_Newobject7["Extent"] = "18 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ShapeEdAnimWindow.setKeyframe( ShapeEdAnimWindow-->seqIn.getText() );";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Skip to in frame (SHIFT -)";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["groupNum"] = "0";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["bitmap"] = "tools/shapeEditor/images/back_btn";

            #endregion

            oc_Newobject18["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "76 0";
            oc_Newobject8["Extent"] = "18 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "ShapeEdAnimWindow.setKeyframe( mCeil(ShapeEdSeqSlider.getValue() - 1) );";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Previous frame (-)";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["groupNum"] = "0";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["bitmap"] = "tools/shapeEditor/images/stepback_btn";
            oc_Newobject8["internalName"] = "stepBkwdBtn";

            #endregion

            oc_Newobject18["#Newobject8"] = oc_Newobject8;

            #region GuiControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "114 0";
            oc_Newobject12["Extent"] = "94 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["internalName"] = "playBkwdBtn";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "0 0";
            oc_Newobject9["Extent"] = "18 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] =
                "ShapeEdAnimWindow.setNoProxySequence(); ShapeEdAnimWindow.setThreadDirection( -1 );";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Play sequence in reverse";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["groupNum"] = "0";
            oc_Newobject9["buttonType"] = "RadioButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["bitmap"] = "tools/shapeEditor/images/playbkwd_btn";

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject10["internalName"] = "pauseBtn";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "38 0";
            oc_Newobject10["Extent"] = "18 18";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["Command"] = "ShapeEdAnimWindow.setThreadDirection( 0 );";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["ToolTip"] = "Toggle pause (SPACE)";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["groupNum"] = "0";
            oc_Newobject10["buttonType"] = "RadioButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["bitmap"] = "tools/shapeEditor/images/pause_btn";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject11["internalName"] = "playFwdBtn";
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "76 0";
            oc_Newobject11["Extent"] = "18 18";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] =
                "ShapeEdAnimWindow.setNoProxySequence(); ShapeEdAnimWindow.setThreadDirection( 1 );";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["ToolTip"] = "Play sequence";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["groupNum"] = "0";
            oc_Newobject11["buttonType"] = "RadioButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["bitmap"] = "tools/shapeEditor/images/playfwd_btn";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject18["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "228 0";
            oc_Newobject13["Extent"] = "18 18";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "ShapeEdAnimWindow.setKeyframe( mFloor(ShapeEdSeqSlider.getValue() + 1) );";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["ToolTip"] = "Next frame (+)";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["groupNum"] = "0";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["bitmap"] = "tools/shapeEditor/images/stepfwd_btn";
            oc_Newobject13["internalName"] = "stepFwdBtn";

            #endregion

            oc_Newobject18["#Newobject13"] = oc_Newobject13;

            #region GuiBitmapButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "266 0";
            oc_Newobject14["Extent"] = "18 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["Command"] = "ShapeEdAnimWindow.setKeyframe( ShapeEdAnimWindow-->seqOut.getText() );";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["ToolTip"] = "Skip to out frame (SHIFT +)";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["groupNum"] = "0";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";
            oc_Newobject14["bitmap"] = "tools/shapeEditor/images/fwd_btn";

            #endregion

            oc_Newobject18["#Newobject14"] = oc_Newobject14;

            #region GuiButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "306 0";
            oc_Newobject15["Extent"] = "28 18";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["Command"] = "ShapeEdSequences.onEditSeqInOut(\\\"out\\\", ShapeEdSeqSlider.getValue());";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["ToolTip"] = "Set the out position to the current frame (O)";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["text"] = "out";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";

            #endregion

            oc_Newobject18["#Newobject15"] = oc_Newobject15;

            #region GuiBitmapButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject16["internalName"] = "pingpong";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject16["horizSizing"] = "left";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "365 0";
            oc_Newobject16["Extent"] = "18 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["Command"] = "ShapeEdAnimWindow.togglePingPong();";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["ToolTip"] = "Toggle 'pingpong' mode on the current thread";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["groupNum"] = "0";
            oc_Newobject16["buttonType"] = "ToggleButton";
            oc_Newobject16["useMouseEvents"] = "0";
            oc_Newobject16["bitmap"] = "tools/shapeEditor/images/pingpong_btn";

            #endregion

            oc_Newobject18["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject17["internalName"] = "timeScale";
            oc_Newobject17["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject17["horizSizing"] = "left";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "390 0";
            oc_Newobject17["extent"] = "30 18";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["Text"] = "1.0";
            oc_Newobject17["AltCommand"] = "ShapeEdShapeView.setTimeScale( $ThisControl.getText() );";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["ToolTip"] = "Edit this value to change the playback speed for all threads";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiBitmapButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject20["internalName"] = "seqInBar";
            oc_Newobject20["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "39 0";
            oc_Newobject20["Extent"] = "8 13";
            oc_Newobject20["MinExtent"] = "1 1";
            oc_Newobject20["bitmap"] = "tools/shapeEditor/images/seq_bar-in";
            oc_Newobject20["ToolTip"] = "Set the In Point to the Current Frame";
            oc_Newobject20["Command"] = "ShapeEdSequences.onEditSeqInOut(\\\"in\\\", ShapeEdSeqSlider.getValue());";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject21["internalName"] = "seqOutBar";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "765 0";
            oc_Newobject21["Extent"] = "8 13";
            oc_Newobject21["MinExtent"] = "1 1";
            oc_Newobject21["bitmap"] = "tools/shapeEditor/images/seq_bar-out";
            oc_Newobject21["ToolTip"] = "Set the Out Point to the Current Frame";
            oc_Newobject21["Command"] = "ShapeEdSequences.onEditSeqInOut(\\\"out\\\", ShapeEdSeqSlider.getValue());";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject23.Create();
            }

        [ConsoleInteraction]
        public float threadPosToKeyframe(float pos)
            {
            CodeBehind.ShapeEditor.ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";
            float start, end;

            if (this.usingProxySeq)
                {
                start = Util.getWord(ShapeEdSeqSlider["range"], 0).AsFloat();
                end = Util.getWord(ShapeEdSeqSlider["range"], 1).AsFloat();
                }
            else
                {
                start = this.seqStartFrame;
                end = this.seqEndFrame;
                }

            return start + (end - start)*pos;
            }

        [ConsoleInteraction]
        public float keyframeToThreadPos(float frame)
            {
            CodeBehind.ShapeEditor.ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";
            float start, end;

            if (this.usingProxySeq)
                {
                start = Util.getWord(ShapeEdSeqSlider["range"], 0).AsFloat();
                end = Util.getWord(ShapeEdSeqSlider["range"], 1).AsFloat();
                }
            else
                {
                start = this.seqStartFrame;
                end = this.seqEndFrame;
                }

            return (frame - start)/(end - start);
            }

        [ConsoleInteraction]
        public void setKeyframe(float frame)
            {
            CodeBehind.ShapeEditor.ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";
            CodeBehind.ShapeEditor.ShapeEdThreadSlider ShapeEdThreadSlider = "ShapeEdThreadSlider";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
            GuiPopUpMenuCtrl transitionTo = ShapeEdThreadWindow.FOT("transitionTo");

            ShapeEdSeqSlider.setValue(frame, true);
            if (transitionTo.getText() == "synched position")
                ShapeEdThreadSlider.setValue(frame, true);

            // Update the position of the active thread => if outside the in/out range,
            // need to switch to the proxy sequence
            if (!this.usingProxySeq)
                {
                if ((frame < this.seqStartFrame) || (frame > this.seqEndFrame))
                    {
                    this.usingProxySeq = true;
                    string proxyName = ShapeEditor.getProxyName(ShapeEdShapeView.getThreadSequence());
                    ShapeEdShapeView.setThreadSequence(proxyName, 0, 0, false);
                    }
                }

            ShapeEdShapeView["threadPos"] = this.keyframeToThreadPos(frame).AsString();
            }

        [ConsoleInteraction]
        public void setNoProxySequence()
            {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";

            // no need to use the proxy sequence during playback
            if (this.usingProxySeq)
                {
                this.usingProxySeq = false;
                string seqName = ShapeEditor.getUnproxyName(ShapeEdShapeView.getThreadSequence());
                ShapeEdShapeView.setThreadSequence(seqName, 0, 0, false);
                ShapeEdShapeView["threadPos"] = this.keyframeToThreadPos(ShapeEdSeqSlider.getValue()).AsString();
                }
            }

        [ConsoleInteraction]
        public void togglePause()
            {
            GuiBitmapButtonCtrl pauseBtn = this.FOT("pauseBtn");
            GuiBitmapButtonCtrl playBkwdBtn = this.FOT("playBkwdBtn");
            GuiBitmapButtonCtrl playFwdBtn = this.FOT("playFwdBtn");

            if (pauseBtn.getValue().AsInt() == 0)
                {
                this["lastDirBkwd"] = playBkwdBtn.getValue();
                pauseBtn.performClick();
                }
            else
                {
                this.setNoProxySequence();
                if (this["lastDirBkwd"].AsBool())
                    playBkwdBtn.performClick();
                else
                    playFwdBtn.performClick();
                }
            }

        [ConsoleInteraction]
        public void togglePingPong()
            {
            GuiBitmapButtonCtrl pingpong = this.FOT("pingpong");
            GuiBitmapButtonCtrl playBkwdBtn = this.FOT("playBkwdBtn");
            GuiBitmapButtonCtrl playFwdBtn = this.FOT("playFwdBtn");

            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            ShapeEdShapeView["threadPingPong"] = pingpong.getValue();
            if (playFwdBtn.getValue().AsBool())
                playFwdBtn.performClick();
            else if (playBkwdBtn.getValue().AsBool())
                playBkwdBtn.performClick();
            }

        // Set the direction of the current thread (-1: reverse, 0: paused, 1: forward)
        [ConsoleInteraction]
        public void setThreadDirection(int dir)
            {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";

            GuiBitmapButtonCtrl pauseBtn = ShapeEdThreadWindow.FOT("pauseBtn");
            GuiBitmapButtonCtrl playBkwdBtn = ShapeEdThreadWindow.FOT("playBkwdBtn");
            GuiBitmapButtonCtrl playFwdBtn = ShapeEdThreadWindow.FOT("playFwdBtn");

            // Update thread direction
            ShapeEdShapeView["threadDirection"] = dir.AsString();

            // Sync the controls in the thread window
            switch (dir)
                {
                    case -1:
                        playBkwdBtn.setStateOn(true);
                        break;
                    case 0:
                        pauseBtn.setStateOn(true);
                        break;
                    case 1:
                        playFwdBtn.setStateOn(true);
                        break;
                }
            }

        // Set the sequence to play
        [ConsoleInteraction]
        public void setSequence(string seqName)
            {
            CodeBehind.ShapeEditor.ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
            GuiCheckBoxCtrl useTransitions = ShapeEdThreadWindow.FOT("useTransitions");
            GuiTextEditCtrl transitionTime = ShapeEdThreadWindow.FOT("transitionTime");
            GuiPopUpMenuCtrl transitionTo = ShapeEdThreadWindow.FOT("transitionTo");
            GuiPopUpMenuCtrl transitionTarget = ShapeEdThreadWindow.FOT("transitionTarget");

            CodeBehind.ShapeEditor.ShapeEdThreadSlider ShapeEdThreadSlider = "ShapeEdThreadSlider";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";

            float transPos;
            float transTime;
            bool transPlay;
            this.usingProxySeq = false;

            if (useTransitions.getValue().AsBool())
                {
                transTime = transitionTime.getText().AsFloat();
                if (transitionTo.getText() == "synched position")
                    transPos = -1;
                else
                    transPos = this.keyframeToThreadPos(ShapeEdThreadSlider.getValue());
                transPlay = (transitionTarget.getText() == "plays during transition");
                }
            else
                {
                transTime = 0;
                transPos = 0;
                transPlay = false;
                }

            // No transition when sequence is not changing
            if (seqName == ShapeEdShapeView.getThreadSequence())
                transTime = 0;

            if (seqName != "")
                {
                // To be able to effectively scrub through the animation, we need to have all
                // frames available, even if it was added with only a subset. If that is the
                // case, then create a proxy sequence that has all the frames instead.
                string sourceData = ShapeEditor.getSequenceSource(seqName);
                string from = Util.rtrim(Util.getFields(sourceData, 0, 1));
                int startFrame = Util.getField(sourceData, 2).AsInt();
                int endFrame = Util.getField(sourceData, 3).AsInt();
                int frameCount = Util.getField(sourceData, 4).AsInt();

                if ((startFrame != 0) || (endFrame != (frameCount - 1)))
                    {
                    string proxyName = ShapeEditor.getProxyName(seqName);
                    if (ShapeEditor.shape.getSequenceIndex(proxyName) != -1)
                        {
                        ShapeEditor.shape.removeSequence(proxyName);
                        ShapeEdShapeView.refreshThreadSequences();
                        }
                    ShapeEditor.shape.addSequence(from, proxyName);

                    // Limit the transition position to the in/out range
                    transPos = Util.mClamp(transPos, 0, 1);
                    }
                }

            ShapeEdShapeView.setThreadSequence(seqName, transTime, transPos, transPlay);
            }

        [ConsoleInteraction]
        public int getTimelineBitmapPos(int val, int width)
            {
            CodeBehind.ShapeEditor.ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";

            int frameCount = Util.getWord(ShapeEdSeqSlider["range"], 1).AsInt();
            int pos_x = Util.getWord(ShapeEdSeqSlider.getPosition().AsString(), 0).AsInt();
            int len_x = Util.getWord(ShapeEdSeqSlider.getExtent().AsString(), 0).AsInt() - width;
            return pos_x + ((len_x*val/frameCount));
            }

        // Set the in or out sequence limit
        [ConsoleInteraction]
        public void setPlaybackLimit(string limit, int val)
            {
            GuiTextEditCtrl seqIn = this.FOT("seqIn");
            GuiTextEditCtrl seqOut = this.FOT("seqOut");
            GuiBitmapButtonCtrl seqInBar = this.FOT("seqInBar");
            GuiBitmapButtonCtrl seqOutBar = this.FOT("seqOutBar");

            // Determine where to place the in/out bar on the slider
            int thumbWidth = 8; // width of the thumb bitmap
            int pos_x = this.getTimelineBitmapPos(val, thumbWidth);

            if (limit == "in")
                {
                this.seqStartFrame = val;
                seqIn.setText(val.AsString());
                seqInBar.setPosition(pos_x, 0);
                }
            else
                {
                this.seqEndFrame = val;
                seqOut.setText(val.AsString());
                seqOutBar.setPosition(pos_x, 0);
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ShapeEdAnimWindow ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null)
                ? object.ReferenceEquals(simobjectid, null)
                : ts.Equals(simobjectid);
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
        public static bool operator !=(ShapeEdAnimWindow ts, string simobjectid)
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
        public static implicit operator string(ShapeEdAnimWindow ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdAnimWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ShapeEdAnimWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdAnimWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEdAnimWindow ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdAnimWindow(int simobjectid)
            {
            return (ShapeEdAnimWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdAnimWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEdAnimWindow ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEdAnimWindow(uint simobjectid)
            {
            return (ShapeEdAnimWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdAnimWindow));
            }

        #endregion
        }
    }