using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<metricsGui>))]
    public class metricsGui : GuiControl
        {
        public static void initialize()
            {
            #region GuiControl (MetricsGui)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiControl", "MetricsGui", typeof (metricsGui));
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["Profile"] = "GuiModelessDialogProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "0 0";
            oc_Newobject23["Extent"] = "200 330";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["isDecoy"] = "0";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";

            #region GuiWindowCtrl (MetricsWindow)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiWindowCtrl", "MetricsWindow");
            oc_Newobject22["text"] = "Metrics Selection";
            oc_Newobject22["resizeWidth"] = "1";
            oc_Newobject22["resizeHeight"] = "1";
            oc_Newobject22["canMove"] = "1";
            oc_Newobject22["canClose"] = "1";
            oc_Newobject22["canMinimize"] = "0";
            oc_Newobject22["canMaximize"] = "0";
            oc_Newobject22["canCollapse"] = "0";
            oc_Newobject22["edgeSnap"] = "1";
            oc_Newobject22["setTitle"] = "0";
            oc_Newobject22["ShowTitle"] = "1";
            oc_Newobject22["AllowPopWindow"] = "1";
            oc_Newobject22["closeCommand"] = "toggleMetricsGui();";
            oc_Newobject22["isInPopup"] = "0";
            oc_Newobject22["margin"] = "0 0 0 0";
            oc_Newobject22["padding"] = "0 0 0 0";
            oc_Newobject22["anchorTop"] = "1";
            oc_Newobject22["anchorBottom"] = "0";
            oc_Newobject22["anchorLeft"] = "1";
            oc_Newobject22["anchorRight"] = "0";
            oc_Newobject22["position"] = "0 20";
            oc_Newobject22["extent"] = "200 330";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["maxExtent"] = "200 330";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["profile"] = "GuiWindowProfile";
            oc_Newobject22["controlFontColor"] = "0 0 0 0";
            oc_Newobject22["controlFillColor"] = "0 0 0 0";
            oc_Newobject22["backgroundColor"] = "255 255 255 255";
            oc_Newobject22["controlFontSize"] = "14";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["alphaValue"] = "1";
            oc_Newobject22["mouseOverAlphaValue"] = "1";
            oc_Newobject22["alphaFadeTime"] = "1000";
            oc_Newobject22["moveControl"] = "1";
            oc_Newobject22["lockControl"] = "0";
            oc_Newobject22["windowSettings"] = "1";
            oc_Newobject22["alpha"] = "1";
            oc_Newobject22["mouseOverAlpha"] = "1";
            oc_Newobject22["alphaFade"] = "1";
            oc_Newobject22["contextFontColor"] = "0";
            oc_Newobject22["contextBackColor"] = "0";
            oc_Newobject22["contextFillColor"] = "0";
            oc_Newobject22["contextFontSize"] = "0";
            oc_Newobject22["editable"] = "0";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";

            #region GuiPanel ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiPanel", "");
            oc_Newobject21["docking"] = "Top";
            oc_Newobject21["margin"] = "0 0 0 0";
            oc_Newobject21["padding"] = "0 0 0 0";
            oc_Newobject21["anchorTop"] = "1";
            oc_Newobject21["anchorBottom"] = "1";
            oc_Newobject21["anchorLeft"] = "1";
            oc_Newobject21["anchorRight"] = "1";
            oc_Newobject21["position"] = "1 0";
            oc_Newobject21["extent"] = "200 330";
            oc_Newobject21["minExtent"] = "16 16";
            oc_Newobject21["maxExtent"] = "1920 1080";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["profile"] = "GuiDefaultProfile";
            oc_Newobject21["controlFontColor"] = "0 0 0 0";
            oc_Newobject21["controlFillColor"] = "0 0 0 0";
            oc_Newobject21["backgroundColor"] = "255 255 255 255";
            oc_Newobject21["controlFontSize"] = "14";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["alphaValue"] = "1";
            oc_Newobject21["mouseOverAlphaValue"] = "1";
            oc_Newobject21["alphaFadeTime"] = "1000";
            oc_Newobject21["moveControl"] = "0";
            oc_Newobject21["lockControl"] = "0";
            oc_Newobject21["windowSettings"] = "1";
            oc_Newobject21["alpha"] = "1";
            oc_Newobject21["mouseOverAlpha"] = "1";
            oc_Newobject21["alphaFade"] = "1";
            oc_Newobject21["contextFontColor"] = "0";
            oc_Newobject21["contextBackColor"] = "0";
            oc_Newobject21["contextFillColor"] = "0";
            oc_Newobject21["contextFontSize"] = "0";
            oc_Newobject21["editable"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";

            #region GuiCheckBoxCtrl (fpsMetrics)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiCheckBoxCtrl", "fpsMetrics", typeof (chkMetric));
            oc_Newobject1["text"] = "FPS";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "ToggleButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["position"] = "17 0";
            oc_Newobject1["extent"] = "140 15";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "1920 1080";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiCheckBoxProfile";
            oc_Newobject1["controlFontColor"] = "0 0 0 0";
            oc_Newobject1["backgroundColor"] = "255 255 255 255";
            oc_Newobject1["controlFontSize"] = "14";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["alphaValue"] = "1";
            oc_Newobject1["mouseOverAlphaValue"] = "1";
            oc_Newobject1["alphaFadeTime"] = "1000";
            oc_Newobject1["windowSettings"] = "1";
            oc_Newobject1["alpha"] = "1";
            oc_Newobject1["mouseOverAlpha"] = "1";
            oc_Newobject1["alphaFade"] = "1";
            oc_Newobject1["contextFontColor"] = "0";
            oc_Newobject1["contextBackColor"] = "0";
            oc_Newobject1["contextFontSize"] = "0";
            oc_Newobject1["editable"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject1"] = oc_Newobject1;

            #region GuiCheckBoxCtrl (gfxMetrics)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiCheckBoxCtrl", "gfxMetrics", typeof (chkMetric));
            oc_Newobject2["text"] = "GFX";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "ToggleButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["position"] = "17 15";
            oc_Newobject2["extent"] = "140 15";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "1920 1080";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiCheckBoxProfile";
            oc_Newobject2["controlFontColor"] = "0 0 0 0";
            oc_Newobject2["backgroundColor"] = "255 255 255 255";
            oc_Newobject2["controlFontSize"] = "14";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["alphaValue"] = "1";
            oc_Newobject2["mouseOverAlphaValue"] = "1";
            oc_Newobject2["alphaFadeTime"] = "1000";
            oc_Newobject2["windowSettings"] = "1";
            oc_Newobject2["alpha"] = "1";
            oc_Newobject2["mouseOverAlpha"] = "1";
            oc_Newobject2["alphaFade"] = "1";
            oc_Newobject2["contextFontColor"] = "0";
            oc_Newobject2["contextBackColor"] = "0";
            oc_Newobject2["contextFontSize"] = "0";
            oc_Newobject2["editable"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject2"] = oc_Newobject2;

            #region GuiCheckBoxCtrl (terrainMetrics)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiCheckBoxCtrl", "terrainMetrics", typeof (chkMetric));
            oc_Newobject3["text"] = "Terrain";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "ToggleButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["position"] = "17 30";
            oc_Newobject3["extent"] = "140 15";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["maxExtent"] = "1920 1080";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiCheckBoxProfile";
            oc_Newobject3["controlFontColor"] = "0 0 0 0";
            oc_Newobject3["backgroundColor"] = "255 255 255 255";
            oc_Newobject3["controlFontSize"] = "14";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["alphaValue"] = "1";
            oc_Newobject3["mouseOverAlphaValue"] = "1";
            oc_Newobject3["alphaFadeTime"] = "1000";
            oc_Newobject3["windowSettings"] = "1";
            oc_Newobject3["alpha"] = "1";
            oc_Newobject3["mouseOverAlpha"] = "1";
            oc_Newobject3["alphaFade"] = "1";
            oc_Newobject3["contextFontColor"] = "0";
            oc_Newobject3["contextBackColor"] = "0";
            oc_Newobject3["contextFontSize"] = "0";
            oc_Newobject3["editable"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject3"] = oc_Newobject3;

            #region GuiCheckBoxCtrl (netMetrics)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiCheckBoxCtrl", "netMetrics", typeof (chkMetric));
            oc_Newobject4["text"] = "Net";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "ToggleButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["position"] = "17 45";
            oc_Newobject4["extent"] = "140 15";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["maxExtent"] = "1920 1080";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiCheckBoxProfile";
            oc_Newobject4["controlFontColor"] = "0 0 0 0";
            oc_Newobject4["backgroundColor"] = "255 255 255 255";
            oc_Newobject4["controlFontSize"] = "14";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["alphaValue"] = "1";
            oc_Newobject4["mouseOverAlphaValue"] = "1";
            oc_Newobject4["alphaFadeTime"] = "1000";
            oc_Newobject4["windowSettings"] = "1";
            oc_Newobject4["alpha"] = "1";
            oc_Newobject4["mouseOverAlpha"] = "1";
            oc_Newobject4["alphaFade"] = "1";
            oc_Newobject4["contextFontColor"] = "0";
            oc_Newobject4["contextBackColor"] = "0";
            oc_Newobject4["contextFontSize"] = "0";
            oc_Newobject4["editable"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject4"] = oc_Newobject4;

            #region GuiCheckBoxCtrl (groundCoverMetrics)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiCheckBoxCtrl", "groundCoverMetrics", typeof (chkMetric));
            oc_Newobject5["text"] = "Ground Cover";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "ToggleButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["position"] = "17 60";
            oc_Newobject5["extent"] = "140 15";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "1920 1080";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiCheckBoxProfile";
            oc_Newobject5["controlFontColor"] = "0 0 0 0";
            oc_Newobject5["backgroundColor"] = "255 255 255 255";
            oc_Newobject5["controlFontSize"] = "14";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["alphaValue"] = "1";
            oc_Newobject5["mouseOverAlphaValue"] = "1";
            oc_Newobject5["alphaFadeTime"] = "1000";
            oc_Newobject5["windowSettings"] = "1";
            oc_Newobject5["alpha"] = "1";
            oc_Newobject5["mouseOverAlpha"] = "1";
            oc_Newobject5["alphaFade"] = "1";
            oc_Newobject5["contextFontColor"] = "0";
            oc_Newobject5["contextBackColor"] = "0";
            oc_Newobject5["contextFontSize"] = "0";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject5"] = oc_Newobject5;

            #region GuiCheckBoxCtrl (sfxMetrics)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiCheckBoxCtrl", "sfxMetrics", typeof (chkMetric));
            oc_Newobject6["text"] = "SFX";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "ToggleButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["position"] = "17 75";
            oc_Newobject6["extent"] = "140 15";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "1920 1080";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiCheckBoxProfile";
            oc_Newobject6["controlFontColor"] = "0 0 0 0";
            oc_Newobject6["backgroundColor"] = "255 255 255 255";
            oc_Newobject6["controlFontSize"] = "14";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["alphaValue"] = "1";
            oc_Newobject6["mouseOverAlphaValue"] = "1";
            oc_Newobject6["alphaFadeTime"] = "1000";
            oc_Newobject6["windowSettings"] = "1";
            oc_Newobject6["alpha"] = "1";
            oc_Newobject6["mouseOverAlpha"] = "1";
            oc_Newobject6["alphaFade"] = "1";
            oc_Newobject6["contextFontColor"] = "0";
            oc_Newobject6["contextBackColor"] = "0";
            oc_Newobject6["contextFontSize"] = "0";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject6"] = oc_Newobject6;

            #region GuiCheckBoxCtrl (sfxSourcesMetrics)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiCheckBoxCtrl", "sfxSourcesMetrics", typeof (chkMetric));
            oc_Newobject7["text"] = "SFX Sources";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "ToggleButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["position"] = "17 90";
            oc_Newobject7["extent"] = "140 15";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["maxExtent"] = "1920 1080";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiCheckBoxProfile";
            oc_Newobject7["controlFontColor"] = "0 0 0 0";
            oc_Newobject7["backgroundColor"] = "255 255 255 255";
            oc_Newobject7["controlFontSize"] = "14";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["alphaValue"] = "1";
            oc_Newobject7["mouseOverAlphaValue"] = "1";
            oc_Newobject7["alphaFadeTime"] = "1000";
            oc_Newobject7["windowSettings"] = "1";
            oc_Newobject7["alpha"] = "1";
            oc_Newobject7["mouseOverAlpha"] = "1";
            oc_Newobject7["alphaFade"] = "1";
            oc_Newobject7["contextFontColor"] = "0";
            oc_Newobject7["contextBackColor"] = "0";
            oc_Newobject7["contextFontSize"] = "0";
            oc_Newobject7["editable"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject7"] = oc_Newobject7;

            #region GuiCheckBoxCtrl (sfxStatesMetrics)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiCheckBoxCtrl", "sfxStatesMetrics", typeof (chkMetric));
            oc_Newobject8["text"] = "SFX States";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "ToggleButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["position"] = "17 105";
            oc_Newobject8["extent"] = "140 15";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["maxExtent"] = "1920 1080";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["profile"] = "GuiCheckBoxProfile";
            oc_Newobject8["controlFontColor"] = "0 0 0 0";
            oc_Newobject8["backgroundColor"] = "255 255 255 255";
            oc_Newobject8["controlFontSize"] = "14";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["alphaValue"] = "1";
            oc_Newobject8["mouseOverAlphaValue"] = "1";
            oc_Newobject8["alphaFadeTime"] = "1000";
            oc_Newobject8["windowSettings"] = "1";
            oc_Newobject8["alpha"] = "1";
            oc_Newobject8["mouseOverAlpha"] = "1";
            oc_Newobject8["alphaFade"] = "1";
            oc_Newobject8["contextFontColor"] = "0";
            oc_Newobject8["contextBackColor"] = "0";
            oc_Newobject8["contextFontSize"] = "0";
            oc_Newobject8["editable"] = "0";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject8"] = oc_Newobject8;

            #region GuiCheckBoxCtrl (timeMetrics)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiCheckBoxCtrl", "timeMetrics", typeof (chkMetric));
            oc_Newobject9["text"] = "Time";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "ToggleButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["position"] = "17 120";
            oc_Newobject9["extent"] = "140 15";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["maxExtent"] = "1920 1080";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["profile"] = "GuiCheckBoxProfile";
            oc_Newobject9["controlFontColor"] = "0 0 0 0";
            oc_Newobject9["backgroundColor"] = "255 255 255 255";
            oc_Newobject9["controlFontSize"] = "14";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["alphaValue"] = "1";
            oc_Newobject9["mouseOverAlphaValue"] = "1";
            oc_Newobject9["alphaFadeTime"] = "1000";
            oc_Newobject9["windowSettings"] = "1";
            oc_Newobject9["alpha"] = "1";
            oc_Newobject9["mouseOverAlpha"] = "1";
            oc_Newobject9["alphaFade"] = "1";
            oc_Newobject9["contextFontColor"] = "0";
            oc_Newobject9["contextBackColor"] = "0";
            oc_Newobject9["contextFontSize"] = "0";
            oc_Newobject9["editable"] = "0";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject9"] = oc_Newobject9;

            #region GuiCheckBoxCtrl (reflectMetrics)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiCheckBoxCtrl", "reflectMetrics", typeof (chkMetric));
            oc_Newobject10["text"] = "Reflect";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "ToggleButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["position"] = "17 135";
            oc_Newobject10["extent"] = "140 15";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["maxExtent"] = "1920 1080";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["profile"] = "GuiCheckBoxProfile";
            oc_Newobject10["controlFontColor"] = "0 0 0 0";
            oc_Newobject10["backgroundColor"] = "255 255 255 255";
            oc_Newobject10["controlFontSize"] = "14";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["alphaValue"] = "1";
            oc_Newobject10["mouseOverAlphaValue"] = "1";
            oc_Newobject10["alphaFadeTime"] = "1000";
            oc_Newobject10["windowSettings"] = "1";
            oc_Newobject10["alpha"] = "1";
            oc_Newobject10["mouseOverAlpha"] = "1";
            oc_Newobject10["alphaFade"] = "1";
            oc_Newobject10["contextFontColor"] = "0";
            oc_Newobject10["contextBackColor"] = "0";
            oc_Newobject10["contextFontSize"] = "0";
            oc_Newobject10["editable"] = "0";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject10"] = oc_Newobject10;

            #region GuiCheckBoxCtrl (decalMetrics)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiCheckBoxCtrl", "decalMetrics", typeof (chkMetric));
            oc_Newobject11["text"] = "Decal";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "ToggleButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["position"] = "17 150";
            oc_Newobject11["extent"] = "140 15";
            oc_Newobject11["minExtent"] = "8 2";
            oc_Newobject11["maxExtent"] = "1920 1080";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["profile"] = "GuiCheckBoxProfile";
            oc_Newobject11["controlFontColor"] = "0 0 0 0";
            oc_Newobject11["backgroundColor"] = "255 255 255 255";
            oc_Newobject11["controlFontSize"] = "14";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["alphaValue"] = "1";
            oc_Newobject11["mouseOverAlphaValue"] = "1";
            oc_Newobject11["alphaFadeTime"] = "1000";
            oc_Newobject11["windowSettings"] = "1";
            oc_Newobject11["alpha"] = "1";
            oc_Newobject11["mouseOverAlpha"] = "1";
            oc_Newobject11["alphaFade"] = "1";
            oc_Newobject11["contextFontColor"] = "0";
            oc_Newobject11["contextBackColor"] = "0";
            oc_Newobject11["contextFontSize"] = "0";
            oc_Newobject11["editable"] = "0";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject11"] = oc_Newobject11;

            #region GuiCheckBoxCtrl (renderMetrics)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiCheckBoxCtrl", "renderMetrics", typeof (chkMetric));
            oc_Newobject12["text"] = "Render";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "ToggleButton";
            oc_Newobject12["useMouseEvents"] = "0";
            oc_Newobject12["position"] = "17 165";
            oc_Newobject12["extent"] = "140 15";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["maxExtent"] = "1920 1080";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["profile"] = "GuiCheckBoxProfile";
            oc_Newobject12["controlFontColor"] = "0 0 0 0";
            oc_Newobject12["backgroundColor"] = "255 255 255 255";
            oc_Newobject12["controlFontSize"] = "14";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["alphaValue"] = "1";
            oc_Newobject12["mouseOverAlphaValue"] = "1";
            oc_Newobject12["alphaFadeTime"] = "1000";
            oc_Newobject12["windowSettings"] = "1";
            oc_Newobject12["alpha"] = "1";
            oc_Newobject12["mouseOverAlpha"] = "1";
            oc_Newobject12["alphaFade"] = "1";
            oc_Newobject12["contextFontColor"] = "0";
            oc_Newobject12["contextBackColor"] = "0";
            oc_Newobject12["contextFontSize"] = "0";
            oc_Newobject12["editable"] = "0";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject12"] = oc_Newobject12;

            #region GuiCheckBoxCtrl (shadowMetrics)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiCheckBoxCtrl", "shadowMetrics", typeof (chkMetric));
            oc_Newobject13["text"] = "Shadow";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "ToggleButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["position"] = "17 180";
            oc_Newobject13["extent"] = "140 15";
            oc_Newobject13["minExtent"] = "8 2";
            oc_Newobject13["maxExtent"] = "1920 1080";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["profile"] = "GuiCheckBoxProfile";
            oc_Newobject13["controlFontColor"] = "0 0 0 0";
            oc_Newobject13["backgroundColor"] = "255 255 255 255";
            oc_Newobject13["controlFontSize"] = "14";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["alphaValue"] = "1";
            oc_Newobject13["mouseOverAlphaValue"] = "1";
            oc_Newobject13["alphaFadeTime"] = "1000";
            oc_Newobject13["windowSettings"] = "1";
            oc_Newobject13["alpha"] = "1";
            oc_Newobject13["mouseOverAlpha"] = "1";
            oc_Newobject13["alphaFade"] = "1";
            oc_Newobject13["contextFontColor"] = "0";
            oc_Newobject13["contextBackColor"] = "0";
            oc_Newobject13["contextFontSize"] = "0";
            oc_Newobject13["editable"] = "0";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject13"] = oc_Newobject13;

            #region GuiCheckBoxCtrl (basicShadowMetrics)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiCheckBoxCtrl", "basicShadowMetrics", typeof (chkMetric));
            oc_Newobject14["text"] = "Basic Shadow";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "ToggleButton";
            oc_Newobject14["useMouseEvents"] = "0";
            oc_Newobject14["position"] = "17 195";
            oc_Newobject14["extent"] = "140 15";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["maxExtent"] = "1920 1080";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["profile"] = "GuiCheckBoxProfile";
            oc_Newobject14["controlFontColor"] = "0 0 0 0";
            oc_Newobject14["backgroundColor"] = "255 255 255 255";
            oc_Newobject14["controlFontSize"] = "14";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["alphaValue"] = "1";
            oc_Newobject14["mouseOverAlphaValue"] = "1";
            oc_Newobject14["alphaFadeTime"] = "1000";
            oc_Newobject14["windowSettings"] = "1";
            oc_Newobject14["alpha"] = "1";
            oc_Newobject14["mouseOverAlpha"] = "1";
            oc_Newobject14["alphaFade"] = "1";
            oc_Newobject14["contextFontColor"] = "0";
            oc_Newobject14["contextBackColor"] = "0";
            oc_Newobject14["contextFontSize"] = "0";
            oc_Newobject14["editable"] = "0";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject14"] = oc_Newobject14;

            #region GuiCheckBoxCtrl (lightMetrics)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiCheckBoxCtrl", "lightMetrics", typeof (chkMetric));
            oc_Newobject15["text"] = "Light";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "ToggleButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["position"] = "17 210";
            oc_Newobject15["extent"] = "140 15";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["maxExtent"] = "1920 1080";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["profile"] = "GuiCheckBoxProfile";
            oc_Newobject15["controlFontColor"] = "0 0 0 0";
            oc_Newobject15["backgroundColor"] = "255 255 255 255";
            oc_Newobject15["controlFontSize"] = "14";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["alphaValue"] = "1";
            oc_Newobject15["mouseOverAlphaValue"] = "1";
            oc_Newobject15["alphaFadeTime"] = "1000";
            oc_Newobject15["windowSettings"] = "1";
            oc_Newobject15["alpha"] = "1";
            oc_Newobject15["mouseOverAlpha"] = "1";
            oc_Newobject15["alphaFade"] = "1";
            oc_Newobject15["contextFontColor"] = "0";
            oc_Newobject15["contextBackColor"] = "0";
            oc_Newobject15["contextFontSize"] = "0";
            oc_Newobject15["editable"] = "0";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject15"] = oc_Newobject15;

            #region GuiCheckBoxCtrl (particleMetrics)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiCheckBoxCtrl", "particleMetrics", typeof (chkMetric));
            oc_Newobject16["text"] = "Particle";
            oc_Newobject16["groupNum"] = "-1";
            oc_Newobject16["buttonType"] = "ToggleButton";
            oc_Newobject16["useMouseEvents"] = "0";
            oc_Newobject16["position"] = "17 225";
            oc_Newobject16["extent"] = "140 15";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["maxExtent"] = "1920 1080";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["profile"] = "GuiCheckBoxProfile";
            oc_Newobject16["controlFontColor"] = "0 0 0 0";
            oc_Newobject16["backgroundColor"] = "255 255 255 255";
            oc_Newobject16["controlFontSize"] = "14";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["alphaValue"] = "1";
            oc_Newobject16["mouseOverAlphaValue"] = "1";
            oc_Newobject16["alphaFadeTime"] = "1000";
            oc_Newobject16["windowSettings"] = "1";
            oc_Newobject16["alpha"] = "1";
            oc_Newobject16["mouseOverAlpha"] = "1";
            oc_Newobject16["alphaFade"] = "1";
            oc_Newobject16["contextFontColor"] = "0";
            oc_Newobject16["contextBackColor"] = "0";
            oc_Newobject16["contextFontSize"] = "0";
            oc_Newobject16["editable"] = "0";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject16"] = oc_Newobject16;

            #region GuiCheckBoxCtrl (partMetrics)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiCheckBoxCtrl", "partMetrics", typeof (chkMetric));
            oc_Newobject17["text"] = "Part";
            oc_Newobject17["groupNum"] = "-1";
            oc_Newobject17["buttonType"] = "ToggleButton";
            oc_Newobject17["useMouseEvents"] = "0";
            oc_Newobject17["position"] = "17 240";
            oc_Newobject17["extent"] = "140 15";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["maxExtent"] = "1920 1080";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["profile"] = "GuiCheckBoxProfile";
            oc_Newobject17["controlFontColor"] = "0 0 0 0";
            oc_Newobject17["backgroundColor"] = "255 255 255 255";
            oc_Newobject17["controlFontSize"] = "14";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["alphaValue"] = "1";
            oc_Newobject17["mouseOverAlphaValue"] = "1";
            oc_Newobject17["alphaFadeTime"] = "1000";
            oc_Newobject17["windowSettings"] = "1";
            oc_Newobject17["alpha"] = "1";
            oc_Newobject17["mouseOverAlpha"] = "1";
            oc_Newobject17["alphaFade"] = "1";
            oc_Newobject17["contextFontColor"] = "0";
            oc_Newobject17["contextBackColor"] = "0";
            oc_Newobject17["contextFontSize"] = "0";
            oc_Newobject17["editable"] = "0";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject17"] = oc_Newobject17;

            #region GuiCheckBoxCtrl (audioMetrics)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiCheckBoxCtrl", "audioMetrics", typeof (chkMetric));
            oc_Newobject18["text"] = "Audio";
            oc_Newobject18["groupNum"] = "-1";
            oc_Newobject18["buttonType"] = "ToggleButton";
            oc_Newobject18["useMouseEvents"] = "0";
            oc_Newobject18["position"] = "17 255";
            oc_Newobject18["extent"] = "140 15";
            oc_Newobject18["minExtent"] = "8 2";
            oc_Newobject18["maxExtent"] = "1920 1080";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["profile"] = "GuiCheckBoxProfile";
            oc_Newobject18["controlFontColor"] = "0 0 0 0";
            oc_Newobject18["backgroundColor"] = "255 255 255 255";
            oc_Newobject18["controlFontSize"] = "14";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["alphaValue"] = "1";
            oc_Newobject18["mouseOverAlphaValue"] = "1";
            oc_Newobject18["alphaFadeTime"] = "1000";
            oc_Newobject18["windowSettings"] = "1";
            oc_Newobject18["alpha"] = "1";
            oc_Newobject18["mouseOverAlpha"] = "1";
            oc_Newobject18["alphaFade"] = "1";
            oc_Newobject18["contextFontColor"] = "0";
            oc_Newobject18["contextBackColor"] = "0";
            oc_Newobject18["contextFontSize"] = "0";
            oc_Newobject18["editable"] = "0";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject18"] = oc_Newobject18;

            #region GuiCheckBoxCtrl (videoMetrics)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiCheckBoxCtrl", "videoMetrics", typeof (chkMetric));
            oc_Newobject19["text"] = "Video";
            oc_Newobject19["groupNum"] = "-1";
            oc_Newobject19["buttonType"] = "ToggleButton";
            oc_Newobject19["useMouseEvents"] = "0";
            oc_Newobject19["position"] = "17 270";
            oc_Newobject19["extent"] = "140 15";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["maxExtent"] = "1920 1080";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["profile"] = "GuiCheckBoxProfile";
            oc_Newobject19["controlFontColor"] = "0 0 0 0";
            oc_Newobject19["backgroundColor"] = "255 255 255 255";
            oc_Newobject19["controlFontSize"] = "14";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["active"] = "1";
            oc_Newobject19["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["alphaValue"] = "1";
            oc_Newobject19["mouseOverAlphaValue"] = "1";
            oc_Newobject19["alphaFadeTime"] = "1000";
            oc_Newobject19["windowSettings"] = "1";
            oc_Newobject19["alpha"] = "1";
            oc_Newobject19["mouseOverAlpha"] = "1";
            oc_Newobject19["alphaFade"] = "1";
            oc_Newobject19["contextFontColor"] = "0";
            oc_Newobject19["contextBackColor"] = "0";
            oc_Newobject19["contextFontSize"] = "0";
            oc_Newobject19["editable"] = "0";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject19"] = oc_Newobject19;

            #region GuiCheckBoxCtrl (imposterMetrics)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiCheckBoxCtrl", "imposterMetrics", typeof (chkMetric));
            oc_Newobject20["text"] = "Imposter";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "ToggleButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["position"] = "17 285";
            oc_Newobject20["extent"] = "140 15";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["maxExtent"] = "1920 1080";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["profile"] = "GuiCheckBoxProfile";
            oc_Newobject20["controlFontColor"] = "0 0 0 0";
            oc_Newobject20["backgroundColor"] = "255 255 255 255";
            oc_Newobject20["controlFontSize"] = "14";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["active"] = "1";
            oc_Newobject20["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["alphaValue"] = "1";
            oc_Newobject20["mouseOverAlphaValue"] = "1";
            oc_Newobject20["alphaFadeTime"] = "1000";
            oc_Newobject20["windowSettings"] = "1";
            oc_Newobject20["alpha"] = "1";
            oc_Newobject20["mouseOverAlpha"] = "1";
            oc_Newobject20["alphaFade"] = "1";
            oc_Newobject20["contextFontColor"] = "0";
            oc_Newobject20["contextBackColor"] = "0";
            oc_Newobject20["contextFontSize"] = "0";
            oc_Newobject20["editable"] = "0";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject23.Create();
            }


        [ConsoleInteraction]
        public static void toggleMetricsGui()
            {
            MenuHandlers.EditorHelpMenu DiagnosticMenu = "DiagnosticMenu";
            metricsGui mg = "MetricsGui";
            if (mg.isAwake())
                {
                if (((GuiWindowCtrl) "MetricsWindow").isInPopup)
                    ((GuiWindowCtrl) "MetricsWindow").ClosePopOut();

                ((GuiCanvas) "canvas").popDialog("MetricsGui");

                if (((GuiWindowCtrl) "FrameOverlayGuiWindow").isInPopup)
                    ((GuiWindowCtrl) "FrameOverlayGuiWindow").ClosePopOut();

                ((GuiCanvas) "Canvas").popDialog("FrameOverlayGui");

                metrics.Metrics("");
                DiagnosticMenu.checkItem(1, false);
                }
            else
                {
                ((GuiCanvas) "canvas").pushDialog("MetricsGui");

                DiagnosticMenu.checkItem(1, true);
                }
            }

        [TypeConverter(typeof (TypeConverterGeneric<chkMetric>))]
        public class chkMetric : GuiCheckBoxCtrl
            {
            public static string[] metricsTypes = new string[]
                {
                "fpsMetrics",
                "gfxMetrics",
                "terrainMetrics",
                "netMetrics",
                "groundCoverMetrics",
                "sfxMetrics",
                "sfxSourcesMetrics",
                "sfxStatesMetrics",
                "timeMetrics",
                "reflectMetrics",
                "decalMetrics",
                "renderMetrics",
                "shadowMetrics",
                "basicShadowMetrics",
                "lightMetrics",
                "particleMetrics",
                "partMetrics",
                "audioMetrics",
                "videoMetrics",
                "imposterMetrics"
                };

            public override void onClick(string SelectedidString)
                {
                bool addedFirst = false;
                string metricsToTurnOn = "";
                foreach (string ctrl in metricsTypes)
                    {
                    GuiCheckBoxCtrl chk = ctrl;
                    if (chk.isStateOn())
                        {
                        if (addedFirst)
                            metricsToTurnOn += " ";
                        metricsToTurnOn += ctrl.Replace("Metrics", "");
                        addedFirst = true;
                        }
                    }
                metrics.Metrics(metricsToTurnOn);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(chkMetric ts, string simobjectid)
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
            public static bool operator !=(chkMetric ts, string simobjectid)
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
            public static implicit operator string(chkMetric ts)
                {
                if (object.ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator chkMetric(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (chkMetric) Omni.self.getSimObject(simobjectid, typeof (chkMetric));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(chkMetric ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator chkMetric(int simobjectid)
                {
                return (chkMetric) Omni.self.getSimObject((uint) simobjectid, typeof (chkMetric));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(chkMetric ts)
                {
                return (uint) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator chkMetric(uint simobjectid)
                {
                return (chkMetric) Omni.self.getSimObject(simobjectid, typeof (chkMetric));
                }

            #endregion
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(metricsGui ts, string simobjectid)
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
        public static bool operator !=(metricsGui ts, string simobjectid)
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
        public static implicit operator string(metricsGui ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator metricsGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (metricsGui) Omni.self.getSimObject(simobjectid, typeof (metricsGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(metricsGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator metricsGui(int simobjectid)
            {
            return (metricsGui) Omni.self.getSimObject((uint) simobjectid, typeof (metricsGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(metricsGui ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator metricsGui(uint simobjectid)
            {
            return (metricsGui) Omni.self.getSimObject(simobjectid, typeof (metricsGui));
            }

        #endregion
        }
    }