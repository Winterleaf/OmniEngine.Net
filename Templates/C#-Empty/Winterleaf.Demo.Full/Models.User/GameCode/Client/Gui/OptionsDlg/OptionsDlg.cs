using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
    {
    [TypeConverter(typeof(TypeConverterGeneric<OptionsDlg>))]
    public class OptionsDlg : GuiControl
        {


        public static void initialize()
            {
            #region GuiControl (OptionsDlg)        oc_Newobject65
            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiControl", "OptionsDlg");
            oc_Newobject65["position"] = "0 0";
            oc_Newobject65["extent"] = "1024 768";
            oc_Newobject65["minExtent"] = "8 8";
            oc_Newobject65["maxExtent"] = "1920 1080";
            oc_Newobject65["horizSizing"] = "width";
            oc_Newobject65["vertSizing"] = "height";
            oc_Newobject65["profile"] = "GuiOverlayProfile";
            oc_Newobject65["controlFontColor"] = "0 0 0 0";
            oc_Newobject65["controlFillColor"] = "0 0 0 0";
            oc_Newobject65["backgroundColor"] = "255 255 255 255";
            oc_Newobject65["controlFontSize"] = "14";
            oc_Newobject65["visible"] = "1";
            oc_Newobject65["active"] = "1";
            oc_Newobject65["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject65["hovertime"] = "1000";
            oc_Newobject65["isContainer"] = "1";
            oc_Newobject65["alphaValue"] = "1";
            oc_Newobject65["mouseOverAlphaValue"] = "1";
            oc_Newobject65["alphaFadeTime"] = "1000";
            oc_Newobject65["moveControl"] = "0";
            oc_Newobject65["lockControl"] = "0";
            oc_Newobject65["windowSettings"] = "1";
            oc_Newobject65["alpha"] = "1";
            oc_Newobject65["mouseOverAlpha"] = "1";
            oc_Newobject65["alphaFade"] = "1";
            oc_Newobject65["contextFontColor"] = "0";
            oc_Newobject65["contextBackColor"] = "0";
            oc_Newobject65["contextFillColor"] = "0";
            oc_Newobject65["contextFontSize"] = "0";
            oc_Newobject65["editable"] = "0";
            oc_Newobject65["canSave"] = "1";
            oc_Newobject65["canSaveDynamicFields"] = "1";
            oc_Newobject65["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.optionsdlg";
            oc_Newobject65["Enabled"] = "1";
            oc_Newobject65["fixedAspectRatio"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject64
            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject64["text"] = "Options";
            oc_Newobject64["resizeWidth"] = "0";
            oc_Newobject64["resizeHeight"] = "0";
            oc_Newobject64["canMove"] = "1";
            oc_Newobject64["canClose"] = "1";
            oc_Newobject64["canMinimize"] = "0";
            oc_Newobject64["canMaximize"] = "0";
            oc_Newobject64["canCollapse"] = "0";
            oc_Newobject64["closeCommand"] = "OptionsDlg.CloseScreen();";
            oc_Newobject64["edgeSnap"] = "0";
            oc_Newobject64["setTitle"] = "0";
            oc_Newobject64["ShowTitle"] = "1";
            oc_Newobject64["AllowPopWindow"] = "0";
            oc_Newobject64["isInPopup"] = "0";
            oc_Newobject64["margin"] = "0 0 0 0";
            oc_Newobject64["padding"] = "0 0 0 0";
            oc_Newobject64["anchorTop"] = "1";
            oc_Newobject64["anchorBottom"] = "0";
            oc_Newobject64["anchorLeft"] = "1";
            oc_Newobject64["anchorRight"] = "0";
            oc_Newobject64["position"] = "323 232";
            oc_Newobject64["extent"] = "378 356";
            oc_Newobject64["minExtent"] = "8 8";
            oc_Newobject64["maxExtent"] = "1920 1080";
            oc_Newobject64["horizSizing"] = "center";
            oc_Newobject64["vertSizing"] = "center";
            oc_Newobject64["profile"] = "GuiWindowProfile";
            oc_Newobject64["controlFontColor"] = "0 0 0 0";
            oc_Newobject64["controlFillColor"] = "0 0 0 0";
            oc_Newobject64["backgroundColor"] = "255 255 255 255";
            oc_Newobject64["controlFontSize"] = "14";
            oc_Newobject64["visible"] = "1";
            oc_Newobject64["active"] = "1";
            oc_Newobject64["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject64["hovertime"] = "1000";
            oc_Newobject64["isContainer"] = "1";
            oc_Newobject64["alphaValue"] = "1";
            oc_Newobject64["mouseOverAlphaValue"] = "1";
            oc_Newobject64["alphaFadeTime"] = "1000";
            oc_Newobject64["moveControl"] = "1";
            oc_Newobject64["lockControl"] = "0";
            oc_Newobject64["windowSettings"] = "1";
            oc_Newobject64["alpha"] = "1";
            oc_Newobject64["mouseOverAlpha"] = "1";
            oc_Newobject64["alphaFade"] = "1";
            oc_Newobject64["contextFontColor"] = "0";
            oc_Newobject64["contextBackColor"] = "0";
            oc_Newobject64["contextFillColor"] = "0";
            oc_Newobject64["contextFontSize"] = "0";
            oc_Newobject64["editable"] = "0";
            oc_Newobject64["canSave"] = "1";
            oc_Newobject64["canSaveDynamicFields"] = "0";
            oc_Newobject64["Enabled"] = "1";

            #region GuiBitmapBorderCtrl ()        oc_Newobject7
            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject7["position"] = "9 55";
            oc_Newobject7["extent"] = "358 242";
            oc_Newobject7["minExtent"] = "8 8";
            oc_Newobject7["maxExtent"] = "1920 1080";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiTabBorderProfile";
            oc_Newobject7["controlFontColor"] = "0 0 0 0";
            oc_Newobject7["controlFillColor"] = "0 0 0 0";
            oc_Newobject7["backgroundColor"] = "255 255 255 255";
            oc_Newobject7["controlFontSize"] = "14";
            oc_Newobject7["visible"] = "0";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["alphaValue"] = "1";
            oc_Newobject7["mouseOverAlphaValue"] = "1";
            oc_Newobject7["alphaFadeTime"] = "1000";
            oc_Newobject7["moveControl"] = "0";
            oc_Newobject7["lockControl"] = "0";
            oc_Newobject7["windowSettings"] = "1";
            oc_Newobject7["alpha"] = "1";
            oc_Newobject7["mouseOverAlpha"] = "1";
            oc_Newobject7["alphaFade"] = "1";
            oc_Newobject7["contextFontColor"] = "0";
            oc_Newobject7["contextBackColor"] = "0";
            oc_Newobject7["contextFillColor"] = "0";
            oc_Newobject7["contextFontSize"] = "0";
            oc_Newobject7["internalName"] = "OptControlsPane";
            oc_Newobject7["hidden"] = "1";
            oc_Newobject7["editable"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject2
            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "alwaysOn";
            oc_Newobject2["lockHorizScroll"] = "1";
            oc_Newobject2["lockVertScroll"] = "0";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "5 24";
            oc_Newobject2["extent"] = "347 152";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["maxExtent"] = "1920 1080";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiScrollProfile";
            oc_Newobject2["controlFontColor"] = "0 0 0 0";
            oc_Newobject2["controlFillColor"] = "0 0 0 0";
            oc_Newobject2["backgroundColor"] = "255 255 255 255";
            oc_Newobject2["controlFontSize"] = "14";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["alphaValue"] = "1";
            oc_Newobject2["mouseOverAlphaValue"] = "1";
            oc_Newobject2["alphaFadeTime"] = "1000";
            oc_Newobject2["windowSettings"] = "1";
            oc_Newobject2["alpha"] = "1";
            oc_Newobject2["mouseOverAlpha"] = "1";
            oc_Newobject2["alphaFade"] = "1";
            oc_Newobject2["contextFontColor"] = "0";
            oc_Newobject2["contextBackColor"] = "0";
            oc_Newobject2["contextFillColor"] = "0";
            oc_Newobject2["contextFontSize"] = "0";
            oc_Newobject2["editable"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";

            #region GuiTextListCtrl ()        oc_Newobject1
            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextListCtrl", "");
            oc_Newobject1["columns"] = "0 160";
            oc_Newobject1["fitParentWidth"] = "1";
            oc_Newobject1["clipColumnText"] = "0";
            oc_Newobject1["position"] = "1 1";
            oc_Newobject1["extent"] = "332 416";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["maxExtent"] = "1920 1080";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiDefaultProfile";
            oc_Newobject1["controlFontColor"] = "0 0 0 0";
            oc_Newobject1["controlFillColor"] = "0 0 0 0";
            oc_Newobject1["backgroundColor"] = "255 255 255 255";
            oc_Newobject1["controlFontSize"] = "14";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["altCommand"] = "OptionsDlg.doRemap();";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["alphaValue"] = "1";
            oc_Newobject1["mouseOverAlphaValue"] = "1";
            oc_Newobject1["alphaFadeTime"] = "1000";
            oc_Newobject1["moveControl"] = "0";
            oc_Newobject1["lockControl"] = "0";
            oc_Newobject1["windowSettings"] = "1";
            oc_Newobject1["alpha"] = "1";
            oc_Newobject1["mouseOverAlpha"] = "1";
            oc_Newobject1["alphaFade"] = "1";
            oc_Newobject1["contextFontColor"] = "0";
            oc_Newobject1["contextBackColor"] = "0";
            oc_Newobject1["contextFillColor"] = "0";
            oc_Newobject1["contextFontSize"] = "0";
            oc_Newobject1["internalName"] = "OptRemapList";
            oc_Newobject1["editable"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3
            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Control Name";
            oc_Newobject3["maxLength"] = "255";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["position"] = "6 6";
            oc_Newobject3["extent"] = "64 18";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["maxExtent"] = "1920 1080";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiTextProfile";
            oc_Newobject3["controlFontColor"] = "0 0 0 0";
            oc_Newobject3["controlFillColor"] = "0 0 0 0";
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
            oc_Newobject3["moveControl"] = "0";
            oc_Newobject3["lockControl"] = "0";
            oc_Newobject3["windowSettings"] = "1";
            oc_Newobject3["alpha"] = "1";
            oc_Newobject3["mouseOverAlpha"] = "1";
            oc_Newobject3["alphaFade"] = "1";
            oc_Newobject3["contextFontColor"] = "0";
            oc_Newobject3["contextBackColor"] = "0";
            oc_Newobject3["contextFillColor"] = "0";
            oc_Newobject3["contextFontSize"] = "0";
            oc_Newobject3["editable"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4
            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Control Binding";
            oc_Newobject4["maxLength"] = "255";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["position"] = "165 6";
            oc_Newobject4["extent"] = "72 18";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["maxExtent"] = "1920 1080";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiTextProfile";
            oc_Newobject4["controlFontColor"] = "0 0 0 0";
            oc_Newobject4["controlFillColor"] = "0 0 0 0";
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
            oc_Newobject4["moveControl"] = "0";
            oc_Newobject4["lockControl"] = "0";
            oc_Newobject4["windowSettings"] = "1";
            oc_Newobject4["alpha"] = "1";
            oc_Newobject4["mouseOverAlpha"] = "1";
            oc_Newobject4["alphaFade"] = "1";
            oc_Newobject4["contextFontColor"] = "0";
            oc_Newobject4["contextBackColor"] = "0";
            oc_Newobject4["contextFillColor"] = "0";
            oc_Newobject4["contextFontSize"] = "0";
            oc_Newobject4["editable"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiSliderCtrl (OptMouseSensitivity)        oc_Newobject5
            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiSliderCtrl", "OptMouseSensitivity");
            oc_Newobject5["range"] = "0.02 2";
            oc_Newobject5["ticks"] = "10";
            oc_Newobject5["snap"] = "0";
            oc_Newobject5["value"] = "1";
            oc_Newobject5["position"] = "105 182";
            oc_Newobject5["extent"] = "244 18";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "1920 1080";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiSliderProfile";
            oc_Newobject5["controlFontColor"] = "0 0 0 0";
            oc_Newobject5["controlFillColor"] = "0 0 0 0";
            oc_Newobject5["backgroundColor"] = "255 255 255 255";
            oc_Newobject5["controlFontSize"] = "14";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["command"] = "OptMouseSetSensitivity(OptMouseSensitivity.value);";
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
            oc_Newobject5["contextFillColor"] = "0";
            oc_Newobject5["contextFontSize"] = "0";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6
            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "Mouse Sensitivity:";
            oc_Newobject6["maxLength"] = "255";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["position"] = "15 182";
            oc_Newobject6["extent"] = "85 18";
            oc_Newobject6["minExtent"] = "8 8";
            oc_Newobject6["maxExtent"] = "1920 1080";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiTextProfile";
            oc_Newobject6["controlFontColor"] = "0 0 0 0";
            oc_Newobject6["controlFillColor"] = "0 0 0 0";
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
            oc_Newobject6["moveControl"] = "0";
            oc_Newobject6["lockControl"] = "0";
            oc_Newobject6["windowSettings"] = "1";
            oc_Newobject6["alpha"] = "1";
            oc_Newobject6["mouseOverAlpha"] = "1";
            oc_Newobject6["alphaFade"] = "1";
            oc_Newobject6["contextFontColor"] = "0";
            oc_Newobject6["contextBackColor"] = "0";
            oc_Newobject6["contextFillColor"] = "0";
            oc_Newobject6["contextFontSize"] = "0";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject64["#Newobject7"] = oc_Newobject7;

            #region GuiButtonCtrl ()        oc_Newobject8
            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject8["text"] = "Done";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["position"] = "300 326";
            oc_Newobject8["extent"] = "60 23";
            oc_Newobject8["minExtent"] = "8 8";
            oc_Newobject8["maxExtent"] = "1920 1080";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["profile"] = "GuiButtonProfile";
            oc_Newobject8["controlFontColor"] = "0 0 0 0";
            oc_Newobject8["backgroundColor"] = "255 255 255 255";
            oc_Newobject8["controlFontSize"] = "14";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["command"] = "OptionsDlg.CloseScreen();";
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

            oc_Newobject64["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapBorderCtrl ()        oc_Newobject26
            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject26["position"] = "9 55";
            oc_Newobject26["extent"] = "358 210";
            oc_Newobject26["minExtent"] = "8 8";
            oc_Newobject26["maxExtent"] = "1920 1080";
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["profile"] = "GuiTabBorderProfile";
            oc_Newobject26["controlFontColor"] = "0 0 0 0";
            oc_Newobject26["controlFillColor"] = "0 0 0 0";
            oc_Newobject26["backgroundColor"] = "255 255 255 255";
            oc_Newobject26["controlFontSize"] = "14";
            oc_Newobject26["visible"] = "0";
            oc_Newobject26["active"] = "1";
            oc_Newobject26["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["alphaValue"] = "1";
            oc_Newobject26["mouseOverAlphaValue"] = "1";
            oc_Newobject26["alphaFadeTime"] = "1000";
            oc_Newobject26["moveControl"] = "0";
            oc_Newobject26["lockControl"] = "0";
            oc_Newobject26["windowSettings"] = "1";
            oc_Newobject26["alpha"] = "1";
            oc_Newobject26["mouseOverAlpha"] = "1";
            oc_Newobject26["alphaFade"] = "1";
            oc_Newobject26["contextFontColor"] = "0";
            oc_Newobject26["contextBackColor"] = "0";
            oc_Newobject26["contextFillColor"] = "0";
            oc_Newobject26["contextFontSize"] = "0";
            oc_Newobject26["internalName"] = "OptAudioPane";
            oc_Newobject26["hidden"] = "1";
            oc_Newobject26["editable"] = "0";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";

            #region GuiMLTextCtrl ()        oc_Newobject9
            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiMLTextCtrl", "");
            oc_Newobject9["lineSpacing"] = "2";
            oc_Newobject9["allowColorChars"] = "0";
            oc_Newobject9["maxChars"] = "-1";
            oc_Newobject9["useURLMouseCursor"] = "0";
            oc_Newobject9["position"] = "149 10";
            oc_Newobject9["extent"] = "190 14";
            oc_Newobject9["minExtent"] = "8 8";
            oc_Newobject9["maxExtent"] = "1920 1080";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["profile"] = "GuiMLTextProfile";
            oc_Newobject9["controlFontColor"] = "0 0 0 0";
            oc_Newobject9["controlFillColor"] = "0 0 0 0";
            oc_Newobject9["backgroundColor"] = "255 255 255 255";
            oc_Newobject9["controlFontSize"] = "-1";
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
            oc_Newobject9["contextFillColor"] = "0";
            oc_Newobject9["contextFontSize"] = "0";
            oc_Newobject9["internalName"] = "OptAudioInfo";
            oc_Newobject9["editable"] = "0";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            #endregion

            oc_Newobject26["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10
            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["text"] = "Audio Provider:";
            oc_Newobject10["maxLength"] = "255";
            oc_Newobject10["margin"] = "0 0 0 0";
            oc_Newobject10["padding"] = "0 0 0 0";
            oc_Newobject10["anchorTop"] = "1";
            oc_Newobject10["anchorBottom"] = "0";
            oc_Newobject10["anchorLeft"] = "1";
            oc_Newobject10["anchorRight"] = "0";
            oc_Newobject10["position"] = "16 16";
            oc_Newobject10["extent"] = "75 18";
            oc_Newobject10["minExtent"] = "8 8";
            oc_Newobject10["maxExtent"] = "1920 1080";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["profile"] = "GuiTextProfile";
            oc_Newobject10["controlFontColor"] = "0 0 0 0";
            oc_Newobject10["controlFillColor"] = "0 0 0 0";
            oc_Newobject10["backgroundColor"] = "255 255 255 255";
            oc_Newobject10["controlFontSize"] = "-1";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["alphaValue"] = "1";
            oc_Newobject10["mouseOverAlphaValue"] = "1";
            oc_Newobject10["alphaFadeTime"] = "1000";
            oc_Newobject10["moveControl"] = "0";
            oc_Newobject10["lockControl"] = "0";
            oc_Newobject10["windowSettings"] = "1";
            oc_Newobject10["alpha"] = "1";
            oc_Newobject10["mouseOverAlpha"] = "1";
            oc_Newobject10["alphaFade"] = "1";
            oc_Newobject10["contextFontColor"] = "0";
            oc_Newobject10["contextBackColor"] = "0";
            oc_Newobject10["contextFillColor"] = "0";
            oc_Newobject10["contextFontSize"] = "0";
            oc_Newobject10["editable"] = "0";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            #endregion

            oc_Newobject26["#Newobject10"] = oc_Newobject10;

            #region GuiPopUpMenuCtrl (OptAudioProviderList)        oc_Newobject11
            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiPopUpMenuCtrl", "OptAudioProviderList");
            oc_Newobject11["maxPopupHeight"] = "200";
            oc_Newobject11["sbUsesNAColor"] = "0";
            oc_Newobject11["reverseTextList"] = "0";
            oc_Newobject11["bitmapBounds"] = "16 16";
            oc_Newobject11["text"] = "DirectSound";
            oc_Newobject11["maxLength"] = "255";
            oc_Newobject11["margin"] = "0 0 0 0";
            oc_Newobject11["padding"] = "0 0 0 0";
            oc_Newobject11["anchorTop"] = "1";
            oc_Newobject11["anchorBottom"] = "0";
            oc_Newobject11["anchorLeft"] = "1";
            oc_Newobject11["anchorRight"] = "0";
            oc_Newobject11["position"] = "101 15";
            oc_Newobject11["extent"] = "240 18";
            oc_Newobject11["minExtent"] = "8 8";
            oc_Newobject11["maxExtent"] = "1920 1080";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject11["controlFontColor"] = "0 0 0 0";
            oc_Newobject11["controlFillColor"] = "0 0 0 0";
            oc_Newobject11["backgroundColor"] = "255 255 255 255";
            oc_Newobject11["controlFontSize"] = "-1";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["alphaValue"] = "1";
            oc_Newobject11["mouseOverAlphaValue"] = "1";
            oc_Newobject11["alphaFadeTime"] = "1000";
            oc_Newobject11["moveControl"] = "0";
            oc_Newobject11["lockControl"] = "0";
            oc_Newobject11["windowSettings"] = "1";
            oc_Newobject11["alpha"] = "1";
            oc_Newobject11["mouseOverAlpha"] = "1";
            oc_Newobject11["alphaFade"] = "1";
            oc_Newobject11["contextFontColor"] = "0";
            oc_Newobject11["contextBackColor"] = "0";
            oc_Newobject11["contextFillColor"] = "0";
            oc_Newobject11["contextFontSize"] = "0";
            oc_Newobject11["editable"] = "0";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.optaudioproviderlist";
            oc_Newobject11["Enabled"] = "1";
            #endregion

            oc_Newobject26["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12
            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["text"] = "Audio Device:";
            oc_Newobject12["maxLength"] = "255";
            oc_Newobject12["margin"] = "0 0 0 0";
            oc_Newobject12["padding"] = "0 0 0 0";
            oc_Newobject12["anchorTop"] = "1";
            oc_Newobject12["anchorBottom"] = "0";
            oc_Newobject12["anchorLeft"] = "1";
            oc_Newobject12["anchorRight"] = "0";
            oc_Newobject12["position"] = "23 48";
            oc_Newobject12["extent"] = "75 18";
            oc_Newobject12["minExtent"] = "8 8";
            oc_Newobject12["maxExtent"] = "1920 1080";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["profile"] = "GuiTextProfile";
            oc_Newobject12["controlFontColor"] = "0 0 0 0";
            oc_Newobject12["controlFillColor"] = "0 0 0 0";
            oc_Newobject12["backgroundColor"] = "255 255 255 255";
            oc_Newobject12["controlFontSize"] = "-1";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["alphaValue"] = "1";
            oc_Newobject12["mouseOverAlphaValue"] = "1";
            oc_Newobject12["alphaFadeTime"] = "1000";
            oc_Newobject12["moveControl"] = "0";
            oc_Newobject12["lockControl"] = "0";
            oc_Newobject12["windowSettings"] = "1";
            oc_Newobject12["alpha"] = "1";
            oc_Newobject12["mouseOverAlpha"] = "1";
            oc_Newobject12["alphaFade"] = "1";
            oc_Newobject12["contextFontColor"] = "0";
            oc_Newobject12["contextBackColor"] = "0";
            oc_Newobject12["contextFillColor"] = "0";
            oc_Newobject12["contextFontSize"] = "0";
            oc_Newobject12["editable"] = "0";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            #endregion

            oc_Newobject26["#Newobject12"] = oc_Newobject12;

            #region GuiPopUpMenuCtrl (OptAudioDeviceList)        oc_Newobject13
            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiPopUpMenuCtrl", "OptAudioDeviceList");
            oc_Newobject13["maxPopupHeight"] = "200";
            oc_Newobject13["sbUsesNAColor"] = "0";
            oc_Newobject13["reverseTextList"] = "0";
            oc_Newobject13["bitmapBounds"] = "16 16";
            oc_Newobject13["text"] = "Speakers / Headphones (IDT High Definition Audio CODEC)";
            oc_Newobject13["maxLength"] = "255";
            oc_Newobject13["margin"] = "0 0 0 0";
            oc_Newobject13["padding"] = "0 0 0 0";
            oc_Newobject13["anchorTop"] = "1";
            oc_Newobject13["anchorBottom"] = "0";
            oc_Newobject13["anchorLeft"] = "1";
            oc_Newobject13["anchorRight"] = "0";
            oc_Newobject13["position"] = "101 47";
            oc_Newobject13["extent"] = "240 18";
            oc_Newobject13["minExtent"] = "8 8";
            oc_Newobject13["maxExtent"] = "1920 1080";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject13["controlFontColor"] = "0 0 0 0";
            oc_Newobject13["controlFillColor"] = "0 0 0 0";
            oc_Newobject13["backgroundColor"] = "255 255 255 255";
            oc_Newobject13["controlFontSize"] = "-1";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["alphaValue"] = "1";
            oc_Newobject13["mouseOverAlphaValue"] = "1";
            oc_Newobject13["alphaFadeTime"] = "1000";
            oc_Newobject13["moveControl"] = "0";
            oc_Newobject13["lockControl"] = "0";
            oc_Newobject13["windowSettings"] = "1";
            oc_Newobject13["alpha"] = "1";
            oc_Newobject13["mouseOverAlpha"] = "1";
            oc_Newobject13["alphaFade"] = "1";
            oc_Newobject13["contextFontColor"] = "0";
            oc_Newobject13["contextBackColor"] = "0";
            oc_Newobject13["contextFillColor"] = "0";
            oc_Newobject13["contextFontSize"] = "0";
            oc_Newobject13["editable"] = "0";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.optaudiodevicelist";
            oc_Newobject13["Enabled"] = "1";
            #endregion

            oc_Newobject26["#Newobject13"] = oc_Newobject13;

            #region GuiControl ()        oc_Newobject16
            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiControl", "");
            oc_Newobject16["position"] = "18 84";
            oc_Newobject16["extent"] = "325 17";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["maxExtent"] = "1920 1080";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["profile"] = "GuiDefaultProfile";
            oc_Newobject16["controlFontColor"] = "0 0 0 0";
            oc_Newobject16["controlFillColor"] = "0 0 0 0";
            oc_Newobject16["backgroundColor"] = "255 255 255 255";
            oc_Newobject16["controlFontSize"] = "-1";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["alphaValue"] = "1";
            oc_Newobject16["mouseOverAlphaValue"] = "1";
            oc_Newobject16["alphaFadeTime"] = "1000";
            oc_Newobject16["moveControl"] = "0";
            oc_Newobject16["lockControl"] = "0";
            oc_Newobject16["windowSettings"] = "1";
            oc_Newobject16["alpha"] = "1";
            oc_Newobject16["mouseOverAlpha"] = "1";
            oc_Newobject16["alphaFade"] = "1";
            oc_Newobject16["contextFontColor"] = "0";
            oc_Newobject16["contextBackColor"] = "0";
            oc_Newobject16["contextFillColor"] = "0";
            oc_Newobject16["contextFontSize"] = "0";
            oc_Newobject16["editable"] = "0";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";

            #region GuiTextCtrl ()        oc_Newobject14
            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["text"] = "Master Volume";
            oc_Newobject14["maxLength"] = "255";
            oc_Newobject14["margin"] = "0 0 0 0";
            oc_Newobject14["padding"] = "0 0 0 0";
            oc_Newobject14["anchorTop"] = "1";
            oc_Newobject14["anchorBottom"] = "0";
            oc_Newobject14["anchorLeft"] = "1";
            oc_Newobject14["anchorRight"] = "0";
            oc_Newobject14["position"] = "0 0";
            oc_Newobject14["extent"] = "72 18";
            oc_Newobject14["minExtent"] = "8 8";
            oc_Newobject14["maxExtent"] = "1920 1080";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject14["controlFontColor"] = "0 0 0 0";
            oc_Newobject14["controlFillColor"] = "0 0 0 0";
            oc_Newobject14["backgroundColor"] = "255 255 255 255";
            oc_Newobject14["controlFontSize"] = "-1";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["alphaValue"] = "1";
            oc_Newobject14["mouseOverAlphaValue"] = "1";
            oc_Newobject14["alphaFadeTime"] = "1000";
            oc_Newobject14["moveControl"] = "0";
            oc_Newobject14["lockControl"] = "0";
            oc_Newobject14["windowSettings"] = "1";
            oc_Newobject14["alpha"] = "1";
            oc_Newobject14["mouseOverAlpha"] = "1";
            oc_Newobject14["alphaFade"] = "1";
            oc_Newobject14["contextFontColor"] = "0";
            oc_Newobject14["contextBackColor"] = "0";
            oc_Newobject14["contextFillColor"] = "0";
            oc_Newobject14["contextFontSize"] = "0";
            oc_Newobject14["editable"] = "0";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            #endregion

            oc_Newobject16["#Newobject14"] = oc_Newobject14;

            #region GuiSliderCtrl ()        oc_Newobject15
            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject15["range"] = "0 1";
            oc_Newobject15["ticks"] = "0";
            oc_Newobject15["snap"] = "0";
            oc_Newobject15["value"] = "0.8";
            oc_Newobject15["position"] = "85 1";
            oc_Newobject15["extent"] = "240 14";
            oc_Newobject15["minExtent"] = "8 8";
            oc_Newobject15["maxExtent"] = "1920 1080";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["profile"] = "GuiSliderProfile";
            oc_Newobject15["controlFontColor"] = "0 0 0 0";
            oc_Newobject15["controlFillColor"] = "0 0 0 0";
            oc_Newobject15["backgroundColor"] = "255 255 255 255";
            oc_Newobject15["controlFontSize"] = "-1";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["altCommand"] = "OptAudioUpdateMasterVolume( $thisControl.value );";
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
            oc_Newobject15["contextFillColor"] = "0";
            oc_Newobject15["contextFontSize"] = "0";
            oc_Newobject15["internalName"] = "OptAudioVolumeMaster";
            oc_Newobject15["editable"] = "0";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject26["#Newobject16"] = oc_Newobject16;

            #region GuiControl ()        oc_Newobject19
            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControl", "");
            oc_Newobject19["position"] = "9 115";
            oc_Newobject19["extent"] = "334 17";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["maxExtent"] = "1920 1080";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["profile"] = "GuiDefaultProfile";
            oc_Newobject19["controlFontColor"] = "0 0 0 0";
            oc_Newobject19["controlFillColor"] = "0 0 0 0";
            oc_Newobject19["backgroundColor"] = "255 255 255 255";
            oc_Newobject19["controlFontSize"] = "-1";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["active"] = "1";
            oc_Newobject19["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["alphaValue"] = "1";
            oc_Newobject19["mouseOverAlphaValue"] = "1";
            oc_Newobject19["alphaFadeTime"] = "1000";
            oc_Newobject19["moveControl"] = "0";
            oc_Newobject19["lockControl"] = "0";
            oc_Newobject19["windowSettings"] = "1";
            oc_Newobject19["alpha"] = "1";
            oc_Newobject19["mouseOverAlpha"] = "1";
            oc_Newobject19["alphaFade"] = "1";
            oc_Newobject19["contextFontColor"] = "0";
            oc_Newobject19["contextBackColor"] = "0";
            oc_Newobject19["contextFillColor"] = "0";
            oc_Newobject19["contextFontSize"] = "0";
            oc_Newobject19["editable"] = "0";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";

            #region GuiTextCtrl ()        oc_Newobject17
            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["text"] = "Interface Volume";
            oc_Newobject17["maxLength"] = "255";
            oc_Newobject17["margin"] = "0 0 0 0";
            oc_Newobject17["padding"] = "0 0 0 0";
            oc_Newobject17["anchorTop"] = "1";
            oc_Newobject17["anchorBottom"] = "0";
            oc_Newobject17["anchorLeft"] = "1";
            oc_Newobject17["anchorRight"] = "0";
            oc_Newobject17["position"] = "0 0";
            oc_Newobject17["extent"] = "82 18";
            oc_Newobject17["minExtent"] = "8 8";
            oc_Newobject17["maxExtent"] = "1920 1080";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject17["controlFontColor"] = "0 0 0 0";
            oc_Newobject17["controlFillColor"] = "0 0 0 0";
            oc_Newobject17["backgroundColor"] = "255 255 255 255";
            oc_Newobject17["controlFontSize"] = "-1";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["alphaValue"] = "1";
            oc_Newobject17["mouseOverAlphaValue"] = "1";
            oc_Newobject17["alphaFadeTime"] = "1000";
            oc_Newobject17["moveControl"] = "0";
            oc_Newobject17["lockControl"] = "0";
            oc_Newobject17["windowSettings"] = "1";
            oc_Newobject17["alpha"] = "1";
            oc_Newobject17["mouseOverAlpha"] = "1";
            oc_Newobject17["alphaFade"] = "1";
            oc_Newobject17["contextFontColor"] = "0";
            oc_Newobject17["contextBackColor"] = "0";
            oc_Newobject17["contextFillColor"] = "0";
            oc_Newobject17["contextFontSize"] = "0";
            oc_Newobject17["editable"] = "0";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            #endregion

            oc_Newobject19["#Newobject17"] = oc_Newobject17;

            #region GuiSliderCtrl ()        oc_Newobject18
            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject18["range"] = "0 1";
            oc_Newobject18["ticks"] = "0";
            oc_Newobject18["snap"] = "0";
            oc_Newobject18["value"] = "1";
            oc_Newobject18["position"] = "94 2";
            oc_Newobject18["extent"] = "240 13";
            oc_Newobject18["minExtent"] = "8 8";
            oc_Newobject18["maxExtent"] = "1920 1080";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["profile"] = "GuiSliderProfile";
            oc_Newobject18["controlFontColor"] = "0 0 0 0";
            oc_Newobject18["controlFillColor"] = "0 0 0 0";
            oc_Newobject18["backgroundColor"] = "255 255 255 255";
            oc_Newobject18["controlFontSize"] = "-1";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["altCommand"] = "OptAudioUpdateChannelVolume(AudioGui, $thisControl.value);";
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
            oc_Newobject18["contextFillColor"] = "0";
            oc_Newobject18["contextFontSize"] = "0";
            oc_Newobject18["internalName"] = "OptAudioVolumeShell";
            oc_Newobject18["editable"] = "0";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject26["#Newobject19"] = oc_Newobject19;

            #region GuiControl ()        oc_Newobject22
            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "");
            oc_Newobject22["position"] = "18 146";
            oc_Newobject22["extent"] = "325 17";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["maxExtent"] = "1920 1080";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["profile"] = "GuiDefaultProfile";
            oc_Newobject22["controlFontColor"] = "0 0 0 0";
            oc_Newobject22["controlFillColor"] = "0 0 0 0";
            oc_Newobject22["backgroundColor"] = "255 255 255 255";
            oc_Newobject22["controlFontSize"] = "-1";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["alphaValue"] = "1";
            oc_Newobject22["mouseOverAlphaValue"] = "1";
            oc_Newobject22["alphaFadeTime"] = "1000";
            oc_Newobject22["moveControl"] = "0";
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

            #region GuiTextCtrl ()        oc_Newobject20
            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject20["text"] = "Effects Volume";
            oc_Newobject20["maxLength"] = "255";
            oc_Newobject20["margin"] = "0 0 0 0";
            oc_Newobject20["padding"] = "0 0 0 0";
            oc_Newobject20["anchorTop"] = "1";
            oc_Newobject20["anchorBottom"] = "0";
            oc_Newobject20["anchorLeft"] = "1";
            oc_Newobject20["anchorRight"] = "0";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["extent"] = "74 18";
            oc_Newobject20["minExtent"] = "8 8";
            oc_Newobject20["maxExtent"] = "1920 1080";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject20["controlFontColor"] = "0 0 0 0";
            oc_Newobject20["controlFillColor"] = "0 0 0 0";
            oc_Newobject20["backgroundColor"] = "255 255 255 255";
            oc_Newobject20["controlFontSize"] = "-1";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["active"] = "1";
            oc_Newobject20["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["alphaValue"] = "1";
            oc_Newobject20["mouseOverAlphaValue"] = "1";
            oc_Newobject20["alphaFadeTime"] = "1000";
            oc_Newobject20["moveControl"] = "0";
            oc_Newobject20["lockControl"] = "0";
            oc_Newobject20["windowSettings"] = "1";
            oc_Newobject20["alpha"] = "1";
            oc_Newobject20["mouseOverAlpha"] = "1";
            oc_Newobject20["alphaFade"] = "1";
            oc_Newobject20["contextFontColor"] = "0";
            oc_Newobject20["contextBackColor"] = "0";
            oc_Newobject20["contextFillColor"] = "0";
            oc_Newobject20["contextFontSize"] = "0";
            oc_Newobject20["editable"] = "0";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiSliderCtrl ()        oc_Newobject21
            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject21["range"] = "0 1";
            oc_Newobject21["ticks"] = "0";
            oc_Newobject21["snap"] = "0";
            oc_Newobject21["value"] = "1";
            oc_Newobject21["position"] = "85 2";
            oc_Newobject21["extent"] = "240 13";
            oc_Newobject21["minExtent"] = "8 8";
            oc_Newobject21["maxExtent"] = "1920 1080";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["profile"] = "GuiSliderProfile";
            oc_Newobject21["controlFontColor"] = "0 0 0 0";
            oc_Newobject21["controlFillColor"] = "0 0 0 0";
            oc_Newobject21["backgroundColor"] = "255 255 255 255";
            oc_Newobject21["controlFontSize"] = "-1";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["altCommand"] = "OptAudioUpdateChannelVolume(AudioEffect, $thisControl.value);";
            oc_Newobject21["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["alphaValue"] = "1";
            oc_Newobject21["mouseOverAlphaValue"] = "1";
            oc_Newobject21["alphaFadeTime"] = "1000";
            oc_Newobject21["windowSettings"] = "1";
            oc_Newobject21["alpha"] = "1";
            oc_Newobject21["mouseOverAlpha"] = "1";
            oc_Newobject21["alphaFade"] = "1";
            oc_Newobject21["contextFontColor"] = "0";
            oc_Newobject21["contextBackColor"] = "0";
            oc_Newobject21["contextFillColor"] = "0";
            oc_Newobject21["contextFontSize"] = "0";
            oc_Newobject21["internalName"] = "OptAudioVolumeSim";
            oc_Newobject21["editable"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject26["#Newobject22"] = oc_Newobject22;

            #region GuiControl ()        oc_Newobject25
            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiControl", "");
            oc_Newobject25["position"] = "23 177";
            oc_Newobject25["extent"] = "320 17";
            oc_Newobject25["minExtent"] = "8 2";
            oc_Newobject25["maxExtent"] = "1920 1080";
            oc_Newobject25["horizSizing"] = "right";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["profile"] = "GuiDefaultProfile";
            oc_Newobject25["controlFontColor"] = "0 0 0 0";
            oc_Newobject25["controlFillColor"] = "0 0 0 0";
            oc_Newobject25["backgroundColor"] = "255 255 255 255";
            oc_Newobject25["controlFontSize"] = "-1";
            oc_Newobject25["visible"] = "1";
            oc_Newobject25["active"] = "1";
            oc_Newobject25["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["alphaValue"] = "1";
            oc_Newobject25["mouseOverAlphaValue"] = "1";
            oc_Newobject25["alphaFadeTime"] = "1000";
            oc_Newobject25["moveControl"] = "0";
            oc_Newobject25["lockControl"] = "0";
            oc_Newobject25["windowSettings"] = "1";
            oc_Newobject25["alpha"] = "1";
            oc_Newobject25["mouseOverAlpha"] = "1";
            oc_Newobject25["alphaFade"] = "1";
            oc_Newobject25["contextFontColor"] = "0";
            oc_Newobject25["contextBackColor"] = "0";
            oc_Newobject25["contextFillColor"] = "0";
            oc_Newobject25["contextFontSize"] = "0";
            oc_Newobject25["editable"] = "0";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["Enabled"] = "1";

            #region GuiSliderCtrl ()        oc_Newobject23
            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject23["range"] = "0 1";
            oc_Newobject23["ticks"] = "0";
            oc_Newobject23["snap"] = "0";
            oc_Newobject23["value"] = "1";
            oc_Newobject23["position"] = "80 2";
            oc_Newobject23["extent"] = "240 13";
            oc_Newobject23["minExtent"] = "8 8";
            oc_Newobject23["maxExtent"] = "1920 1080";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["profile"] = "GuiSliderProfile";
            oc_Newobject23["controlFontColor"] = "0 0 0 0";
            oc_Newobject23["controlFillColor"] = "0 0 0 0";
            oc_Newobject23["backgroundColor"] = "255 255 255 255";
            oc_Newobject23["controlFontSize"] = "-1";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["active"] = "1";
            oc_Newobject23["altCommand"] = "OptAudioUpdateChannelVolume(AudioMusic, $thisControl.value);";
            oc_Newobject23["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["alphaValue"] = "1";
            oc_Newobject23["mouseOverAlphaValue"] = "1";
            oc_Newobject23["alphaFadeTime"] = "1000";
            oc_Newobject23["windowSettings"] = "1";
            oc_Newobject23["alpha"] = "1";
            oc_Newobject23["mouseOverAlpha"] = "1";
            oc_Newobject23["alphaFade"] = "1";
            oc_Newobject23["contextFontColor"] = "0";
            oc_Newobject23["contextBackColor"] = "0";
            oc_Newobject23["contextFillColor"] = "0";
            oc_Newobject23["contextFontSize"] = "0";
            oc_Newobject23["internalName"] = "OptAudioVolumeMusic";
            oc_Newobject23["editable"] = "0";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["Enabled"] = "1";
            #endregion

            oc_Newobject25["#Newobject23"] = oc_Newobject23;

            #region GuiTextCtrl ()        oc_Newobject24
            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject24["text"] = "Music Volume";
            oc_Newobject24["maxLength"] = "255";
            oc_Newobject24["margin"] = "0 0 0 0";
            oc_Newobject24["padding"] = "0 0 0 0";
            oc_Newobject24["anchorTop"] = "1";
            oc_Newobject24["anchorBottom"] = "0";
            oc_Newobject24["anchorLeft"] = "1";
            oc_Newobject24["anchorRight"] = "0";
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["extent"] = "67 18";
            oc_Newobject24["minExtent"] = "8 8";
            oc_Newobject24["maxExtent"] = "1920 1080";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject24["controlFontColor"] = "0 0 0 0";
            oc_Newobject24["controlFillColor"] = "0 0 0 0";
            oc_Newobject24["backgroundColor"] = "255 255 255 255";
            oc_Newobject24["controlFontSize"] = "-1";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["active"] = "1";
            oc_Newobject24["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["alphaValue"] = "1";
            oc_Newobject24["mouseOverAlphaValue"] = "1";
            oc_Newobject24["alphaFadeTime"] = "1000";
            oc_Newobject24["moveControl"] = "0";
            oc_Newobject24["lockControl"] = "0";
            oc_Newobject24["windowSettings"] = "1";
            oc_Newobject24["alpha"] = "1";
            oc_Newobject24["mouseOverAlpha"] = "1";
            oc_Newobject24["alphaFade"] = "1";
            oc_Newobject24["contextFontColor"] = "0";
            oc_Newobject24["contextBackColor"] = "0";
            oc_Newobject24["contextFillColor"] = "0";
            oc_Newobject24["contextFontSize"] = "0";
            oc_Newobject24["editable"] = "0";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";
            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject64["#Newobject26"] = oc_Newobject26;

            #region GuiBitmapBorderCtrl ()        oc_Newobject58
            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject58["position"] = "9 53";
            oc_Newobject58["extent"] = "358 257";
            oc_Newobject58["minExtent"] = "8 8";
            oc_Newobject58["maxExtent"] = "1920 1080";
            oc_Newobject58["horizSizing"] = "right";
            oc_Newobject58["vertSizing"] = "bottom";
            oc_Newobject58["profile"] = "GuiTabBorderProfile";
            oc_Newobject58["controlFontColor"] = "0 0 0 0";
            oc_Newobject58["controlFillColor"] = "0 0 0 0";
            oc_Newobject58["backgroundColor"] = "255 255 255 255";
            oc_Newobject58["controlFontSize"] = "14";
            oc_Newobject58["visible"] = "1";
            oc_Newobject58["active"] = "1";
            oc_Newobject58["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject58["hovertime"] = "1000";
            oc_Newobject58["isContainer"] = "1";
            oc_Newobject58["alphaValue"] = "1";
            oc_Newobject58["mouseOverAlphaValue"] = "1";
            oc_Newobject58["alphaFadeTime"] = "1000";
            oc_Newobject58["moveControl"] = "0";
            oc_Newobject58["lockControl"] = "0";
            oc_Newobject58["windowSettings"] = "1";
            oc_Newobject58["alpha"] = "1";
            oc_Newobject58["mouseOverAlpha"] = "1";
            oc_Newobject58["alphaFade"] = "1";
            oc_Newobject58["contextFontColor"] = "0";
            oc_Newobject58["contextBackColor"] = "0";
            oc_Newobject58["contextFillColor"] = "0";
            oc_Newobject58["contextFontSize"] = "0";
            oc_Newobject58["internalName"] = "OptGraphicsPane";
            oc_Newobject58["editable"] = "0";
            oc_Newobject58["canSave"] = "1";
            oc_Newobject58["canSaveDynamicFields"] = "0";
            oc_Newobject58["Enabled"] = "1";

            #region GuiTextCtrl ()        oc_Newobject27
            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject27["text"] = "Display Driver:";
            oc_Newobject27["maxLength"] = "255";
            oc_Newobject27["margin"] = "0 0 0 0";
            oc_Newobject27["padding"] = "0 0 0 0";
            oc_Newobject27["anchorTop"] = "1";
            oc_Newobject27["anchorBottom"] = "0";
            oc_Newobject27["anchorLeft"] = "1";
            oc_Newobject27["anchorRight"] = "0";
            oc_Newobject27["position"] = "11 8";
            oc_Newobject27["extent"] = "70 18";
            oc_Newobject27["minExtent"] = "8 8";
            oc_Newobject27["maxExtent"] = "1920 1080";
            oc_Newobject27["horizSizing"] = "right";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["profile"] = "GuiTextProfile";
            oc_Newobject27["controlFontColor"] = "0 0 0 0";
            oc_Newobject27["controlFillColor"] = "0 0 0 0";
            oc_Newobject27["backgroundColor"] = "255 255 255 255";
            oc_Newobject27["controlFontSize"] = "14";
            oc_Newobject27["visible"] = "1";
            oc_Newobject27["active"] = "1";
            oc_Newobject27["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["alphaValue"] = "1";
            oc_Newobject27["mouseOverAlphaValue"] = "1";
            oc_Newobject27["alphaFadeTime"] = "1000";
            oc_Newobject27["moveControl"] = "0";
            oc_Newobject27["lockControl"] = "0";
            oc_Newobject27["windowSettings"] = "1";
            oc_Newobject27["alpha"] = "1";
            oc_Newobject27["mouseOverAlpha"] = "1";
            oc_Newobject27["alphaFade"] = "1";
            oc_Newobject27["contextFontColor"] = "0";
            oc_Newobject27["contextBackColor"] = "0";
            oc_Newobject27["contextFillColor"] = "0";
            oc_Newobject27["contextFontSize"] = "0";
            oc_Newobject27["editable"] = "0";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject27"] = oc_Newobject27;

            #region GuiTextCtrl ()        oc_Newobject28
            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject28["text"] = "Resolution:";
            oc_Newobject28["maxLength"] = "255";
            oc_Newobject28["margin"] = "0 0 0 0";
            oc_Newobject28["padding"] = "0 0 0 0";
            oc_Newobject28["anchorTop"] = "1";
            oc_Newobject28["anchorBottom"] = "0";
            oc_Newobject28["anchorLeft"] = "1";
            oc_Newobject28["anchorRight"] = "0";
            oc_Newobject28["position"] = "11 35";
            oc_Newobject28["extent"] = "53 18";
            oc_Newobject28["minExtent"] = "8 8";
            oc_Newobject28["maxExtent"] = "1920 1080";
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["profile"] = "GuiTextProfile";
            oc_Newobject28["controlFontColor"] = "0 0 0 0";
            oc_Newobject28["controlFillColor"] = "0 0 0 0";
            oc_Newobject28["backgroundColor"] = "255 255 255 255";
            oc_Newobject28["controlFontSize"] = "14";
            oc_Newobject28["visible"] = "1";
            oc_Newobject28["active"] = "1";
            oc_Newobject28["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["alphaValue"] = "1";
            oc_Newobject28["mouseOverAlphaValue"] = "1";
            oc_Newobject28["alphaFadeTime"] = "1000";
            oc_Newobject28["moveControl"] = "0";
            oc_Newobject28["lockControl"] = "0";
            oc_Newobject28["windowSettings"] = "1";
            oc_Newobject28["alpha"] = "1";
            oc_Newobject28["mouseOverAlpha"] = "1";
            oc_Newobject28["alphaFade"] = "1";
            oc_Newobject28["contextFontColor"] = "0";
            oc_Newobject28["contextBackColor"] = "0";
            oc_Newobject28["contextFillColor"] = "0";
            oc_Newobject28["contextFontSize"] = "0";
            oc_Newobject28["editable"] = "0";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject28"] = oc_Newobject28;

            #region GuiCheckBoxCtrl ()        oc_Newobject29
            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject29["text"] = "Fullscreen";
            oc_Newobject29["groupNum"] = "-1";
            oc_Newobject29["buttonType"] = "ToggleButton";
            oc_Newobject29["useMouseEvents"] = "0";
            oc_Newobject29["position"] = "11 62";
            oc_Newobject29["extent"] = "85 18";
            oc_Newobject29["minExtent"] = "8 8";
            oc_Newobject29["maxExtent"] = "1920 1080";
            oc_Newobject29["horizSizing"] = "right";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["profile"] = "GuiCheckBoxProfile";
            oc_Newobject29["controlFontColor"] = "0 0 0 0";
            oc_Newobject29["backgroundColor"] = "255 255 255 255";
            oc_Newobject29["controlFontSize"] = "14";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["active"] = "1";
            oc_Newobject29["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject29["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["alphaValue"] = "1";
            oc_Newobject29["mouseOverAlphaValue"] = "1";
            oc_Newobject29["alphaFadeTime"] = "1000";
            oc_Newobject29["windowSettings"] = "1";
            oc_Newobject29["alpha"] = "1";
            oc_Newobject29["mouseOverAlpha"] = "1";
            oc_Newobject29["alphaFade"] = "1";
            oc_Newobject29["contextFontColor"] = "0";
            oc_Newobject29["contextBackColor"] = "0";
            oc_Newobject29["contextFontSize"] = "0";
            oc_Newobject29["internalName"] = "OptGraphicsFullscreenToggle";
            oc_Newobject29["editable"] = "0";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject29"] = oc_Newobject29;

            #region GuiPopUpMenuCtrl (OptGraphicsDriverMenu)        oc_Newobject30
            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiPopUpMenuCtrl", "OptGraphicsDriverMenu");
            oc_Newobject30["maxPopupHeight"] = "200";
            oc_Newobject30["sbUsesNAColor"] = "0";
            oc_Newobject30["reverseTextList"] = "0";
            oc_Newobject30["bitmapBounds"] = "16 16";
            oc_Newobject30["text"] = "ATI Mobility Radeon HD 5730  (D3D9)";
            oc_Newobject30["maxLength"] = "255";
            oc_Newobject30["margin"] = "0 0 0 0";
            oc_Newobject30["padding"] = "0 0 0 0";
            oc_Newobject30["anchorTop"] = "1";
            oc_Newobject30["anchorBottom"] = "0";
            oc_Newobject30["anchorLeft"] = "1";
            oc_Newobject30["anchorRight"] = "0";
            oc_Newobject30["position"] = "88 8";
            oc_Newobject30["extent"] = "258 18";
            oc_Newobject30["minExtent"] = "8 8";
            oc_Newobject30["maxExtent"] = "1920 1080";
            oc_Newobject30["horizSizing"] = "right";
            oc_Newobject30["vertSizing"] = "bottom";
            oc_Newobject30["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject30["controlFontColor"] = "0 0 0 0";
            oc_Newobject30["controlFillColor"] = "0 0 0 0";
            oc_Newobject30["backgroundColor"] = "255 255 255 255";
            oc_Newobject30["controlFontSize"] = "14";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["active"] = "1";
            oc_Newobject30["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["isContainer"] = "0";
            oc_Newobject30["alphaValue"] = "1";
            oc_Newobject30["mouseOverAlphaValue"] = "1";
            oc_Newobject30["alphaFadeTime"] = "1000";
            oc_Newobject30["moveControl"] = "0";
            oc_Newobject30["lockControl"] = "0";
            oc_Newobject30["windowSettings"] = "1";
            oc_Newobject30["alpha"] = "1";
            oc_Newobject30["mouseOverAlpha"] = "1";
            oc_Newobject30["alphaFade"] = "1";
            oc_Newobject30["contextFontColor"] = "0";
            oc_Newobject30["contextBackColor"] = "0";
            oc_Newobject30["contextFillColor"] = "0";
            oc_Newobject30["contextFontSize"] = "0";
            oc_Newobject30["editable"] = "0";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.optgraphicsdrivermenu";
            oc_Newobject30["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject30"] = oc_Newobject30;

            #region GuiPopUpMenuCtrl ()        oc_Newobject31
            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject31["maxPopupHeight"] = "200";
            oc_Newobject31["sbUsesNAColor"] = "0";
            oc_Newobject31["reverseTextList"] = "0";
            oc_Newobject31["bitmapBounds"] = "16 16";
            oc_Newobject31["text"] = "1024 X 768 (4:3)";
            oc_Newobject31["maxLength"] = "255";
            oc_Newobject31["margin"] = "0 0 0 0";
            oc_Newobject31["padding"] = "0 0 0 0";
            oc_Newobject31["anchorTop"] = "1";
            oc_Newobject31["anchorBottom"] = "0";
            oc_Newobject31["anchorLeft"] = "1";
            oc_Newobject31["anchorRight"] = "0";
            oc_Newobject31["position"] = "67 35";
            oc_Newobject31["extent"] = "127 18";
            oc_Newobject31["minExtent"] = "8 8";
            oc_Newobject31["maxExtent"] = "1920 1080";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject31["controlFontColor"] = "0 0 0 0";
            oc_Newobject31["controlFillColor"] = "0 0 0 0";
            oc_Newobject31["backgroundColor"] = "255 255 255 255";
            oc_Newobject31["controlFontSize"] = "14";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["active"] = "1";
            oc_Newobject31["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject31["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["alphaValue"] = "1";
            oc_Newobject31["mouseOverAlphaValue"] = "1";
            oc_Newobject31["alphaFadeTime"] = "1000";
            oc_Newobject31["moveControl"] = "0";
            oc_Newobject31["lockControl"] = "0";
            oc_Newobject31["windowSettings"] = "1";
            oc_Newobject31["alpha"] = "1";
            oc_Newobject31["mouseOverAlpha"] = "1";
            oc_Newobject31["alphaFade"] = "1";
            oc_Newobject31["contextFontColor"] = "0";
            oc_Newobject31["contextBackColor"] = "0";
            oc_Newobject31["contextFillColor"] = "0";
            oc_Newobject31["contextFontSize"] = "0";
            oc_Newobject31["internalName"] = "OptGraphicsResolutionMenu";
            oc_Newobject31["editable"] = "0";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject31"] = oc_Newobject31;

            #region GuiTextCtrl ()        oc_Newobject32
            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject32["text"] = "Refresh:";
            oc_Newobject32["maxLength"] = "255";
            oc_Newobject32["margin"] = "0 0 0 0";
            oc_Newobject32["padding"] = "0 0 0 0";
            oc_Newobject32["anchorTop"] = "1";
            oc_Newobject32["anchorBottom"] = "0";
            oc_Newobject32["anchorLeft"] = "1";
            oc_Newobject32["anchorRight"] = "0";
            oc_Newobject32["position"] = "207 35";
            oc_Newobject32["extent"] = "45 18";
            oc_Newobject32["minExtent"] = "8 2";
            oc_Newobject32["maxExtent"] = "1920 1080";
            oc_Newobject32["horizSizing"] = "right";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["profile"] = "GuiTextProfile";
            oc_Newobject32["controlFontColor"] = "0 0 0 0";
            oc_Newobject32["controlFillColor"] = "0 0 0 0";
            oc_Newobject32["backgroundColor"] = "255 255 255 255";
            oc_Newobject32["controlFontSize"] = "14";
            oc_Newobject32["visible"] = "1";
            oc_Newobject32["active"] = "1";
            oc_Newobject32["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["alphaValue"] = "1";
            oc_Newobject32["mouseOverAlphaValue"] = "1";
            oc_Newobject32["alphaFadeTime"] = "1000";
            oc_Newobject32["moveControl"] = "0";
            oc_Newobject32["lockControl"] = "0";
            oc_Newobject32["windowSettings"] = "1";
            oc_Newobject32["alpha"] = "1";
            oc_Newobject32["mouseOverAlpha"] = "1";
            oc_Newobject32["alphaFade"] = "1";
            oc_Newobject32["contextFontColor"] = "0";
            oc_Newobject32["contextBackColor"] = "0";
            oc_Newobject32["contextFillColor"] = "0";
            oc_Newobject32["contextFontSize"] = "0";
            oc_Newobject32["editable"] = "0";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject32"] = oc_Newobject32;

            #region GuiPopUpMenuCtrl ()        oc_Newobject33
            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject33["maxPopupHeight"] = "200";
            oc_Newobject33["sbUsesNAColor"] = "0";
            oc_Newobject33["reverseTextList"] = "0";
            oc_Newobject33["bitmapBounds"] = "16 16";
            oc_Newobject33["text"] = "60";
            oc_Newobject33["maxLength"] = "255";
            oc_Newobject33["margin"] = "0 0 0 0";
            oc_Newobject33["padding"] = "0 0 0 0";
            oc_Newobject33["anchorTop"] = "1";
            oc_Newobject33["anchorBottom"] = "0";
            oc_Newobject33["anchorLeft"] = "1";
            oc_Newobject33["anchorRight"] = "0";
            oc_Newobject33["position"] = "252 35";
            oc_Newobject33["extent"] = "49 18";
            oc_Newobject33["minExtent"] = "8 2";
            oc_Newobject33["maxExtent"] = "1920 1080";
            oc_Newobject33["horizSizing"] = "right";
            oc_Newobject33["vertSizing"] = "bottom";
            oc_Newobject33["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject33["controlFontColor"] = "0 0 0 0";
            oc_Newobject33["controlFillColor"] = "0 0 0 0";
            oc_Newobject33["backgroundColor"] = "255 255 255 255";
            oc_Newobject33["controlFontSize"] = "14";
            oc_Newobject33["visible"] = "1";
            oc_Newobject33["active"] = "1";
            oc_Newobject33["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject33["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["alphaValue"] = "1";
            oc_Newobject33["mouseOverAlphaValue"] = "1";
            oc_Newobject33["alphaFadeTime"] = "1000";
            oc_Newobject33["moveControl"] = "0";
            oc_Newobject33["lockControl"] = "0";
            oc_Newobject33["windowSettings"] = "1";
            oc_Newobject33["alpha"] = "1";
            oc_Newobject33["mouseOverAlpha"] = "1";
            oc_Newobject33["alphaFade"] = "1";
            oc_Newobject33["contextFontColor"] = "0";
            oc_Newobject33["contextBackColor"] = "0";
            oc_Newobject33["contextFillColor"] = "0";
            oc_Newobject33["contextFontSize"] = "0";
            oc_Newobject33["internalName"] = "OptRefreshSelectMenu";
            oc_Newobject33["editable"] = "0";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject33"] = oc_Newobject33;

            #region GuiTextCtrl ()        oc_Newobject34
            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject34["text"] = "Mesh Quality:";
            oc_Newobject34["maxLength"] = "255";
            oc_Newobject34["margin"] = "0 0 0 0";
            oc_Newobject34["padding"] = "0 0 0 0";
            oc_Newobject34["anchorTop"] = "1";
            oc_Newobject34["anchorBottom"] = "0";
            oc_Newobject34["anchorLeft"] = "1";
            oc_Newobject34["anchorRight"] = "0";
            oc_Newobject34["position"] = "21 91";
            oc_Newobject34["extent"] = "62 18";
            oc_Newobject34["minExtent"] = "8 2";
            oc_Newobject34["maxExtent"] = "1920 1080";
            oc_Newobject34["horizSizing"] = "right";
            oc_Newobject34["vertSizing"] = "bottom";
            oc_Newobject34["profile"] = "GuiTextProfile";
            oc_Newobject34["controlFontColor"] = "0 0 0 0";
            oc_Newobject34["controlFillColor"] = "0 0 0 0";
            oc_Newobject34["backgroundColor"] = "255 255 255 255";
            oc_Newobject34["controlFontSize"] = "14";
            oc_Newobject34["visible"] = "1";
            oc_Newobject34["active"] = "1";
            oc_Newobject34["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["alphaValue"] = "1";
            oc_Newobject34["mouseOverAlphaValue"] = "1";
            oc_Newobject34["alphaFadeTime"] = "1000";
            oc_Newobject34["moveControl"] = "0";
            oc_Newobject34["lockControl"] = "0";
            oc_Newobject34["windowSettings"] = "1";
            oc_Newobject34["alpha"] = "1";
            oc_Newobject34["mouseOverAlpha"] = "1";
            oc_Newobject34["alphaFade"] = "1";
            oc_Newobject34["contextFontColor"] = "0";
            oc_Newobject34["contextBackColor"] = "0";
            oc_Newobject34["contextFillColor"] = "0";
            oc_Newobject34["contextFontSize"] = "0";
            oc_Newobject34["editable"] = "0";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject34"] = oc_Newobject34;

            #region GuiPopUpMenuCtrl ()        oc_Newobject35
            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject35["maxPopupHeight"] = "200";
            oc_Newobject35["sbUsesNAColor"] = "0";
            oc_Newobject35["reverseTextList"] = "0";
            oc_Newobject35["bitmapBounds"] = "16 16";
            oc_Newobject35["text"] = "Normal";
            oc_Newobject35["maxLength"] = "255";
            oc_Newobject35["margin"] = "0 0 0 0";
            oc_Newobject35["padding"] = "0 0 0 0";
            oc_Newobject35["anchorTop"] = "1";
            oc_Newobject35["anchorBottom"] = "0";
            oc_Newobject35["anchorLeft"] = "1";
            oc_Newobject35["anchorRight"] = "0";
            oc_Newobject35["position"] = "90 91";
            oc_Newobject35["extent"] = "78 18";
            oc_Newobject35["minExtent"] = "8 2";
            oc_Newobject35["maxExtent"] = "1920 1080";
            oc_Newobject35["horizSizing"] = "right";
            oc_Newobject35["vertSizing"] = "bottom";
            oc_Newobject35["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject35["controlFontColor"] = "0 0 0 0";
            oc_Newobject35["controlFillColor"] = "0 0 0 0";
            oc_Newobject35["backgroundColor"] = "255 255 255 255";
            oc_Newobject35["controlFontSize"] = "14";
            oc_Newobject35["visible"] = "1";
            oc_Newobject35["active"] = "1";
            oc_Newobject35["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject35["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["alphaValue"] = "1";
            oc_Newobject35["mouseOverAlphaValue"] = "1";
            oc_Newobject35["alphaFadeTime"] = "1000";
            oc_Newobject35["moveControl"] = "0";
            oc_Newobject35["lockControl"] = "0";
            oc_Newobject35["windowSettings"] = "1";
            oc_Newobject35["alpha"] = "1";
            oc_Newobject35["mouseOverAlpha"] = "1";
            oc_Newobject35["alphaFade"] = "1";
            oc_Newobject35["contextFontColor"] = "0";
            oc_Newobject35["contextBackColor"] = "0";
            oc_Newobject35["contextFillColor"] = "0";
            oc_Newobject35["contextFontSize"] = "0";
            oc_Newobject35["internalName"] = "OptMeshQualityPopup";
            oc_Newobject35["class"] = "GraphicsQualityPopup";
            oc_Newobject35["editable"] = "0";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.graphicsqualitypopup";
            oc_Newobject35["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject35"] = oc_Newobject35;

            #region GuiPopUpMenuCtrl ()        oc_Newobject36
            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject36["maxPopupHeight"] = "200";
            oc_Newobject36["sbUsesNAColor"] = "0";
            oc_Newobject36["reverseTextList"] = "0";
            oc_Newobject36["bitmapBounds"] = "16 16";
            oc_Newobject36["text"] = "Normal";
            oc_Newobject36["maxLength"] = "255";
            oc_Newobject36["margin"] = "0 0 0 0";
            oc_Newobject36["padding"] = "0 0 0 0";
            oc_Newobject36["anchorTop"] = "1";
            oc_Newobject36["anchorBottom"] = "0";
            oc_Newobject36["anchorLeft"] = "1";
            oc_Newobject36["anchorRight"] = "0";
            oc_Newobject36["position"] = "90 118";
            oc_Newobject36["extent"] = "78 18";
            oc_Newobject36["minExtent"] = "8 2";
            oc_Newobject36["maxExtent"] = "1920 1080";
            oc_Newobject36["horizSizing"] = "right";
            oc_Newobject36["vertSizing"] = "bottom";
            oc_Newobject36["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject36["controlFontColor"] = "0 0 0 0";
            oc_Newobject36["controlFillColor"] = "0 0 0 0";
            oc_Newobject36["backgroundColor"] = "255 255 255 255";
            oc_Newobject36["controlFontSize"] = "14";
            oc_Newobject36["visible"] = "1";
            oc_Newobject36["active"] = "1";
            oc_Newobject36["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject36["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["alphaValue"] = "1";
            oc_Newobject36["mouseOverAlphaValue"] = "1";
            oc_Newobject36["alphaFadeTime"] = "1000";
            oc_Newobject36["moveControl"] = "0";
            oc_Newobject36["lockControl"] = "0";
            oc_Newobject36["windowSettings"] = "1";
            oc_Newobject36["alpha"] = "1";
            oc_Newobject36["mouseOverAlpha"] = "1";
            oc_Newobject36["alphaFade"] = "1";
            oc_Newobject36["contextFontColor"] = "0";
            oc_Newobject36["contextBackColor"] = "0";
            oc_Newobject36["contextFillColor"] = "0";
            oc_Newobject36["contextFontSize"] = "0";
            oc_Newobject36["internalName"] = "OptTextureQualityPopup";
            oc_Newobject36["class"] = "GraphicsQualityPopup";
            oc_Newobject36["editable"] = "0";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["canSaveDynamicFields"] = "0";
            oc_Newobject36["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.graphicsqualitypopup";
            oc_Newobject36["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject36"] = oc_Newobject36;

            #region GuiTextCtrl ()        oc_Newobject37
            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject37["text"] = "Texture Quality:";
            oc_Newobject37["maxLength"] = "255";
            oc_Newobject37["margin"] = "0 0 0 0";
            oc_Newobject37["padding"] = "0 0 0 0";
            oc_Newobject37["anchorTop"] = "1";
            oc_Newobject37["anchorBottom"] = "0";
            oc_Newobject37["anchorLeft"] = "1";
            oc_Newobject37["anchorRight"] = "0";
            oc_Newobject37["position"] = "11 118";
            oc_Newobject37["extent"] = "77 18";
            oc_Newobject37["minExtent"] = "8 2";
            oc_Newobject37["maxExtent"] = "1920 1080";
            oc_Newobject37["horizSizing"] = "right";
            oc_Newobject37["vertSizing"] = "bottom";
            oc_Newobject37["profile"] = "GuiTextProfile";
            oc_Newobject37["controlFontColor"] = "0 0 0 0";
            oc_Newobject37["controlFillColor"] = "0 0 0 0";
            oc_Newobject37["backgroundColor"] = "255 255 255 255";
            oc_Newobject37["controlFontSize"] = "14";
            oc_Newobject37["visible"] = "1";
            oc_Newobject37["active"] = "1";
            oc_Newobject37["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["alphaValue"] = "1";
            oc_Newobject37["mouseOverAlphaValue"] = "1";
            oc_Newobject37["alphaFadeTime"] = "1000";
            oc_Newobject37["moveControl"] = "0";
            oc_Newobject37["lockControl"] = "0";
            oc_Newobject37["windowSettings"] = "1";
            oc_Newobject37["alpha"] = "1";
            oc_Newobject37["mouseOverAlpha"] = "1";
            oc_Newobject37["alphaFade"] = "1";
            oc_Newobject37["contextFontColor"] = "0";
            oc_Newobject37["contextBackColor"] = "0";
            oc_Newobject37["contextFillColor"] = "0";
            oc_Newobject37["contextFontSize"] = "0";
            oc_Newobject37["editable"] = "0";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject37"] = oc_Newobject37;

            #region GuiPopUpMenuCtrl ()        oc_Newobject38
            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject38["maxPopupHeight"] = "200";
            oc_Newobject38["sbUsesNAColor"] = "0";
            oc_Newobject38["reverseTextList"] = "0";
            oc_Newobject38["bitmapBounds"] = "16 16";
            oc_Newobject38["text"] = "Normal";
            oc_Newobject38["maxLength"] = "255";
            oc_Newobject38["margin"] = "0 0 0 0";
            oc_Newobject38["padding"] = "0 0 0 0";
            oc_Newobject38["anchorTop"] = "1";
            oc_Newobject38["anchorBottom"] = "0";
            oc_Newobject38["anchorLeft"] = "1";
            oc_Newobject38["anchorRight"] = "0";
            oc_Newobject38["position"] = "90 143";
            oc_Newobject38["extent"] = "78 18";
            oc_Newobject38["minExtent"] = "8 2";
            oc_Newobject38["maxExtent"] = "1920 1080";
            oc_Newobject38["horizSizing"] = "right";
            oc_Newobject38["vertSizing"] = "bottom";
            oc_Newobject38["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject38["controlFontColor"] = "0 0 0 0";
            oc_Newobject38["controlFillColor"] = "0 0 0 0";
            oc_Newobject38["backgroundColor"] = "255 255 255 255";
            oc_Newobject38["controlFontSize"] = "14";
            oc_Newobject38["visible"] = "1";
            oc_Newobject38["active"] = "1";
            oc_Newobject38["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject38["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["alphaValue"] = "1";
            oc_Newobject38["mouseOverAlphaValue"] = "1";
            oc_Newobject38["alphaFadeTime"] = "1000";
            oc_Newobject38["moveControl"] = "0";
            oc_Newobject38["lockControl"] = "0";
            oc_Newobject38["windowSettings"] = "1";
            oc_Newobject38["alpha"] = "1";
            oc_Newobject38["mouseOverAlpha"] = "1";
            oc_Newobject38["alphaFade"] = "1";
            oc_Newobject38["contextFontColor"] = "0";
            oc_Newobject38["contextBackColor"] = "0";
            oc_Newobject38["contextFillColor"] = "0";
            oc_Newobject38["contextFontSize"] = "0";
            oc_Newobject38["internalName"] = "OptLightingQualityPopup";
            oc_Newobject38["class"] = "GraphicsQualityPopup";
            oc_Newobject38["editable"] = "0";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.graphicsqualitypopup";
            oc_Newobject38["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject38"] = oc_Newobject38;

            #region GuiTextCtrl ()        oc_Newobject39
            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject39["text"] = "Lighting Quality:";
            oc_Newobject39["maxLength"] = "255";
            oc_Newobject39["margin"] = "0 0 0 0";
            oc_Newobject39["padding"] = "0 0 0 0";
            oc_Newobject39["anchorTop"] = "1";
            oc_Newobject39["anchorBottom"] = "0";
            oc_Newobject39["anchorLeft"] = "1";
            oc_Newobject39["anchorRight"] = "0";
            oc_Newobject39["position"] = "11 143";
            oc_Newobject39["extent"] = "73 18";
            oc_Newobject39["minExtent"] = "8 2";
            oc_Newobject39["maxExtent"] = "1920 1080";
            oc_Newobject39["horizSizing"] = "right";
            oc_Newobject39["vertSizing"] = "bottom";
            oc_Newobject39["profile"] = "GuiTextProfile";
            oc_Newobject39["controlFontColor"] = "0 0 0 0";
            oc_Newobject39["controlFillColor"] = "0 0 0 0";
            oc_Newobject39["backgroundColor"] = "255 255 255 255";
            oc_Newobject39["controlFontSize"] = "14";
            oc_Newobject39["visible"] = "1";
            oc_Newobject39["active"] = "1";
            oc_Newobject39["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["isContainer"] = "0";
            oc_Newobject39["alphaValue"] = "1";
            oc_Newobject39["mouseOverAlphaValue"] = "1";
            oc_Newobject39["alphaFadeTime"] = "1000";
            oc_Newobject39["moveControl"] = "0";
            oc_Newobject39["lockControl"] = "0";
            oc_Newobject39["windowSettings"] = "1";
            oc_Newobject39["alpha"] = "1";
            oc_Newobject39["mouseOverAlpha"] = "1";
            oc_Newobject39["alphaFade"] = "1";
            oc_Newobject39["contextFontColor"] = "0";
            oc_Newobject39["contextBackColor"] = "0";
            oc_Newobject39["contextFillColor"] = "0";
            oc_Newobject39["contextFontSize"] = "0";
            oc_Newobject39["editable"] = "0";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject39"] = oc_Newobject39;

            #region GuiTextCtrl ()        oc_Newobject40
            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject40["text"] = "Effect Quality:";
            oc_Newobject40["maxLength"] = "255";
            oc_Newobject40["margin"] = "0 0 0 0";
            oc_Newobject40["padding"] = "0 0 0 0";
            oc_Newobject40["anchorTop"] = "1";
            oc_Newobject40["anchorBottom"] = "0";
            oc_Newobject40["anchorLeft"] = "1";
            oc_Newobject40["anchorRight"] = "0";
            oc_Newobject40["position"] = "191 91";
            oc_Newobject40["extent"] = "73 18";
            oc_Newobject40["minExtent"] = "8 2";
            oc_Newobject40["maxExtent"] = "1920 1080";
            oc_Newobject40["horizSizing"] = "right";
            oc_Newobject40["vertSizing"] = "bottom";
            oc_Newobject40["profile"] = "GuiTextProfile";
            oc_Newobject40["controlFontColor"] = "0 0 0 0";
            oc_Newobject40["controlFillColor"] = "0 0 0 0";
            oc_Newobject40["backgroundColor"] = "255 255 255 255";
            oc_Newobject40["controlFontSize"] = "14";
            oc_Newobject40["visible"] = "1";
            oc_Newobject40["active"] = "1";
            oc_Newobject40["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["alphaValue"] = "1";
            oc_Newobject40["mouseOverAlphaValue"] = "1";
            oc_Newobject40["alphaFadeTime"] = "1000";
            oc_Newobject40["moveControl"] = "0";
            oc_Newobject40["lockControl"] = "0";
            oc_Newobject40["windowSettings"] = "1";
            oc_Newobject40["alpha"] = "1";
            oc_Newobject40["mouseOverAlpha"] = "1";
            oc_Newobject40["alphaFade"] = "1";
            oc_Newobject40["contextFontColor"] = "0";
            oc_Newobject40["contextBackColor"] = "0";
            oc_Newobject40["contextFillColor"] = "0";
            oc_Newobject40["contextFontSize"] = "0";
            oc_Newobject40["editable"] = "0";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject40"] = oc_Newobject40;

            #region GuiPopUpMenuCtrl ()        oc_Newobject41
            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject41["maxPopupHeight"] = "200";
            oc_Newobject41["sbUsesNAColor"] = "0";
            oc_Newobject41["reverseTextList"] = "0";
            oc_Newobject41["bitmapBounds"] = "16 16";
            oc_Newobject41["maxLength"] = "255";
            oc_Newobject41["margin"] = "0 0 0 0";
            oc_Newobject41["padding"] = "0 0 0 0";
            oc_Newobject41["anchorTop"] = "1";
            oc_Newobject41["anchorBottom"] = "0";
            oc_Newobject41["anchorLeft"] = "1";
            oc_Newobject41["anchorRight"] = "0";
            oc_Newobject41["position"] = "263 91";
            oc_Newobject41["extent"] = "78 18";
            oc_Newobject41["minExtent"] = "8 2";
            oc_Newobject41["maxExtent"] = "1920 1080";
            oc_Newobject41["horizSizing"] = "right";
            oc_Newobject41["vertSizing"] = "bottom";
            oc_Newobject41["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject41["controlFontColor"] = "0 0 0 0";
            oc_Newobject41["controlFillColor"] = "0 0 0 0";
            oc_Newobject41["backgroundColor"] = "255 255 255 255";
            oc_Newobject41["controlFontSize"] = "14";
            oc_Newobject41["visible"] = "1";
            oc_Newobject41["active"] = "1";
            oc_Newobject41["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject41["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["isContainer"] = "0";
            oc_Newobject41["alphaValue"] = "1";
            oc_Newobject41["mouseOverAlphaValue"] = "1";
            oc_Newobject41["alphaFadeTime"] = "1000";
            oc_Newobject41["moveControl"] = "0";
            oc_Newobject41["lockControl"] = "0";
            oc_Newobject41["windowSettings"] = "1";
            oc_Newobject41["alpha"] = "1";
            oc_Newobject41["mouseOverAlpha"] = "1";
            oc_Newobject41["alphaFade"] = "1";
            oc_Newobject41["contextFontColor"] = "0";
            oc_Newobject41["contextBackColor"] = "0";
            oc_Newobject41["contextFillColor"] = "0";
            oc_Newobject41["contextFontSize"] = "0";
            oc_Newobject41["internalName"] = "OptEffectQualityPopup";
            oc_Newobject41["class"] = "GraphicsQualityPopup";
            oc_Newobject41["editable"] = "0";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.graphicsqualitypopup";
            oc_Newobject41["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject41"] = oc_Newobject41;

            #region GuiTextCtrl ()        oc_Newobject42
            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject42["text"] = "Shader Quality:";
            oc_Newobject42["maxLength"] = "255";
            oc_Newobject42["margin"] = "0 0 0 0";
            oc_Newobject42["padding"] = "0 0 0 0";
            oc_Newobject42["anchorTop"] = "1";
            oc_Newobject42["anchorBottom"] = "0";
            oc_Newobject42["anchorLeft"] = "1";
            oc_Newobject42["anchorRight"] = "0";
            oc_Newobject42["position"] = "186 118";
            oc_Newobject42["extent"] = "77 18";
            oc_Newobject42["minExtent"] = "8 2";
            oc_Newobject42["maxExtent"] = "1920 1080";
            oc_Newobject42["horizSizing"] = "right";
            oc_Newobject42["vertSizing"] = "bottom";
            oc_Newobject42["profile"] = "GuiTextProfile";
            oc_Newobject42["controlFontColor"] = "0 0 0 0";
            oc_Newobject42["controlFillColor"] = "0 0 0 0";
            oc_Newobject42["backgroundColor"] = "255 255 255 255";
            oc_Newobject42["controlFontSize"] = "14";
            oc_Newobject42["visible"] = "1";
            oc_Newobject42["active"] = "1";
            oc_Newobject42["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["isContainer"] = "0";
            oc_Newobject42["alphaValue"] = "1";
            oc_Newobject42["mouseOverAlphaValue"] = "1";
            oc_Newobject42["alphaFadeTime"] = "1000";
            oc_Newobject42["moveControl"] = "0";
            oc_Newobject42["lockControl"] = "0";
            oc_Newobject42["windowSettings"] = "1";
            oc_Newobject42["alpha"] = "1";
            oc_Newobject42["mouseOverAlpha"] = "1";
            oc_Newobject42["alphaFade"] = "1";
            oc_Newobject42["contextFontColor"] = "0";
            oc_Newobject42["contextBackColor"] = "0";
            oc_Newobject42["contextFillColor"] = "0";
            oc_Newobject42["contextFontSize"] = "0";
            oc_Newobject42["editable"] = "0";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["canSaveDynamicFields"] = "0";
            oc_Newobject42["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject42"] = oc_Newobject42;

            #region GuiPopUpMenuCtrl ()        oc_Newobject43
            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject43["maxPopupHeight"] = "200";
            oc_Newobject43["sbUsesNAColor"] = "0";
            oc_Newobject43["reverseTextList"] = "0";
            oc_Newobject43["bitmapBounds"] = "16 16";
            oc_Newobject43["text"] = "High";
            oc_Newobject43["maxLength"] = "255";
            oc_Newobject43["margin"] = "0 0 0 0";
            oc_Newobject43["padding"] = "0 0 0 0";
            oc_Newobject43["anchorTop"] = "1";
            oc_Newobject43["anchorBottom"] = "0";
            oc_Newobject43["anchorLeft"] = "1";
            oc_Newobject43["anchorRight"] = "0";
            oc_Newobject43["position"] = "263 118";
            oc_Newobject43["extent"] = "78 18";
            oc_Newobject43["minExtent"] = "8 2";
            oc_Newobject43["maxExtent"] = "1920 1080";
            oc_Newobject43["horizSizing"] = "right";
            oc_Newobject43["vertSizing"] = "bottom";
            oc_Newobject43["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject43["controlFontColor"] = "0 0 0 0";
            oc_Newobject43["controlFillColor"] = "0 0 0 0";
            oc_Newobject43["backgroundColor"] = "255 255 255 255";
            oc_Newobject43["controlFontSize"] = "14";
            oc_Newobject43["visible"] = "1";
            oc_Newobject43["active"] = "1";
            oc_Newobject43["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject43["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["alphaValue"] = "1";
            oc_Newobject43["mouseOverAlphaValue"] = "1";
            oc_Newobject43["alphaFadeTime"] = "1000";
            oc_Newobject43["moveControl"] = "0";
            oc_Newobject43["lockControl"] = "0";
            oc_Newobject43["windowSettings"] = "1";
            oc_Newobject43["alpha"] = "1";
            oc_Newobject43["mouseOverAlpha"] = "1";
            oc_Newobject43["alphaFade"] = "1";
            oc_Newobject43["contextFontColor"] = "0";
            oc_Newobject43["contextBackColor"] = "0";
            oc_Newobject43["contextFillColor"] = "0";
            oc_Newobject43["contextFontSize"] = "0";
            oc_Newobject43["internalName"] = "OptShaderQualityPopup";
            oc_Newobject43["class"] = "GraphicsQualityPopup";
            oc_Newobject43["editable"] = "0";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.graphicsqualitypopup";
            oc_Newobject43["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject43"] = oc_Newobject43;

            #region GuiTextCtrl ()        oc_Newobject44
            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject44["text"] = "Particle Quality:";
            oc_Newobject44["maxLength"] = "255";
            oc_Newobject44["margin"] = "0 0 0 0";
            oc_Newobject44["padding"] = "0 0 0 0";
            oc_Newobject44["anchorTop"] = "1";
            oc_Newobject44["anchorBottom"] = "0";
            oc_Newobject44["anchorLeft"] = "1";
            oc_Newobject44["anchorRight"] = "0";
            oc_Newobject44["position"] = "180 180";
            oc_Newobject44["extent"] = "73 18";
            oc_Newobject44["minExtent"] = "8 2";
            oc_Newobject44["maxExtent"] = "1920 1080";
            oc_Newobject44["horizSizing"] = "right";
            oc_Newobject44["vertSizing"] = "bottom";
            oc_Newobject44["profile"] = "GuiTextProfile";
            oc_Newobject44["controlFontColor"] = "0 0 0 0";
            oc_Newobject44["controlFillColor"] = "0 0 0 0";
            oc_Newobject44["backgroundColor"] = "255 255 255 255";
            oc_Newobject44["controlFontSize"] = "14";
            oc_Newobject44["visible"] = "0";
            oc_Newobject44["active"] = "1";
            oc_Newobject44["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["isContainer"] = "0";
            oc_Newobject44["alphaValue"] = "1";
            oc_Newobject44["mouseOverAlphaValue"] = "1";
            oc_Newobject44["alphaFadeTime"] = "1000";
            oc_Newobject44["moveControl"] = "0";
            oc_Newobject44["lockControl"] = "0";
            oc_Newobject44["windowSettings"] = "1";
            oc_Newobject44["alpha"] = "1";
            oc_Newobject44["mouseOverAlpha"] = "1";
            oc_Newobject44["alphaFade"] = "1";
            oc_Newobject44["contextFontColor"] = "0";
            oc_Newobject44["contextBackColor"] = "0";
            oc_Newobject44["contextFillColor"] = "0";
            oc_Newobject44["contextFontSize"] = "0";
            oc_Newobject44["hidden"] = "1";
            oc_Newobject44["editable"] = "0";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["canSaveDynamicFields"] = "0";
            oc_Newobject44["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject44"] = oc_Newobject44;

            #region GuiPopUpMenuCtrl ()        oc_Newobject45
            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject45["maxPopupHeight"] = "200";
            oc_Newobject45["sbUsesNAColor"] = "0";
            oc_Newobject45["reverseTextList"] = "0";
            oc_Newobject45["bitmapBounds"] = "16 16";
            oc_Newobject45["maxLength"] = "255";
            oc_Newobject45["margin"] = "0 0 0 0";
            oc_Newobject45["padding"] = "0 0 0 0";
            oc_Newobject45["anchorTop"] = "1";
            oc_Newobject45["anchorBottom"] = "0";
            oc_Newobject45["anchorLeft"] = "1";
            oc_Newobject45["anchorRight"] = "0";
            oc_Newobject45["position"] = "263 180";
            oc_Newobject45["extent"] = "78 18";
            oc_Newobject45["minExtent"] = "8 2";
            oc_Newobject45["maxExtent"] = "1920 1080";
            oc_Newobject45["horizSizing"] = "right";
            oc_Newobject45["vertSizing"] = "bottom";
            oc_Newobject45["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject45["controlFontColor"] = "0 0 0 0";
            oc_Newobject45["controlFillColor"] = "0 0 0 0";
            oc_Newobject45["backgroundColor"] = "255 255 255 255";
            oc_Newobject45["controlFontSize"] = "14";
            oc_Newobject45["visible"] = "0";
            oc_Newobject45["active"] = "1";
            oc_Newobject45["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject45["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["alphaValue"] = "1";
            oc_Newobject45["mouseOverAlphaValue"] = "1";
            oc_Newobject45["alphaFadeTime"] = "1000";
            oc_Newobject45["moveControl"] = "0";
            oc_Newobject45["lockControl"] = "0";
            oc_Newobject45["windowSettings"] = "1";
            oc_Newobject45["alpha"] = "1";
            oc_Newobject45["mouseOverAlpha"] = "1";
            oc_Newobject45["alphaFade"] = "1";
            oc_Newobject45["contextFontColor"] = "0";
            oc_Newobject45["contextBackColor"] = "0";
            oc_Newobject45["contextFillColor"] = "0";
            oc_Newobject45["contextFontSize"] = "0";
            oc_Newobject45["internalName"] = "OptParticleQualityPopup";
            oc_Newobject45["class"] = "GraphicsQualityPopup";
            oc_Newobject45["hidden"] = "1";
            oc_Newobject45["editable"] = "0";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["WLE_OVERRIDE_PROXY_CLASSTYPE"] = "WinterLeaf.Demo.Full.Models.User.GameCode.client.gui.optionsdlg.graphicsqualitypopup";
            oc_Newobject45["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject45"] = oc_Newobject45;

            #region GuiTextCtrl ()        oc_Newobject46
            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject46["text"] = "Anisotropic Filtering:";
            oc_Newobject46["maxLength"] = "255";
            oc_Newobject46["margin"] = "0 0 0 0";
            oc_Newobject46["padding"] = "0 0 0 0";
            oc_Newobject46["anchorTop"] = "1";
            oc_Newobject46["anchorBottom"] = "0";
            oc_Newobject46["anchorLeft"] = "1";
            oc_Newobject46["anchorRight"] = "0";
            oc_Newobject46["position"] = "22 167";
            oc_Newobject46["extent"] = "105 18";
            oc_Newobject46["minExtent"] = "8 2";
            oc_Newobject46["maxExtent"] = "1920 1080";
            oc_Newobject46["horizSizing"] = "right";
            oc_Newobject46["vertSizing"] = "bottom";
            oc_Newobject46["profile"] = "GuiTextProfile";
            oc_Newobject46["controlFontColor"] = "0 0 0 0";
            oc_Newobject46["controlFillColor"] = "0 0 0 0";
            oc_Newobject46["backgroundColor"] = "255 255 255 255";
            oc_Newobject46["controlFontSize"] = "14";
            oc_Newobject46["visible"] = "1";
            oc_Newobject46["active"] = "1";
            oc_Newobject46["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["isContainer"] = "0";
            oc_Newobject46["alphaValue"] = "1";
            oc_Newobject46["mouseOverAlphaValue"] = "1";
            oc_Newobject46["alphaFadeTime"] = "1000";
            oc_Newobject46["moveControl"] = "0";
            oc_Newobject46["lockControl"] = "0";
            oc_Newobject46["windowSettings"] = "1";
            oc_Newobject46["alpha"] = "1";
            oc_Newobject46["mouseOverAlpha"] = "1";
            oc_Newobject46["alphaFade"] = "1";
            oc_Newobject46["contextFontColor"] = "0";
            oc_Newobject46["contextBackColor"] = "0";
            oc_Newobject46["contextFillColor"] = "0";
            oc_Newobject46["contextFontSize"] = "0";
            oc_Newobject46["editable"] = "0";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["canSaveDynamicFields"] = "0";
            oc_Newobject46["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject46"] = oc_Newobject46;

            #region GuiPopUpMenuCtrl ()        oc_Newobject47
            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject47["maxPopupHeight"] = "200";
            oc_Newobject47["sbUsesNAColor"] = "0";
            oc_Newobject47["reverseTextList"] = "0";
            oc_Newobject47["bitmapBounds"] = "16 16";
            oc_Newobject47["text"] = "Off";
            oc_Newobject47["maxLength"] = "255";
            oc_Newobject47["margin"] = "0 0 0 0";
            oc_Newobject47["padding"] = "0 0 0 0";
            oc_Newobject47["anchorTop"] = "1";
            oc_Newobject47["anchorBottom"] = "0";
            oc_Newobject47["anchorLeft"] = "1";
            oc_Newobject47["anchorRight"] = "0";
            oc_Newobject47["position"] = "123 167";
            oc_Newobject47["extent"] = "45 18";
            oc_Newobject47["minExtent"] = "8 2";
            oc_Newobject47["maxExtent"] = "1920 1080";
            oc_Newobject47["horizSizing"] = "right";
            oc_Newobject47["vertSizing"] = "bottom";
            oc_Newobject47["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject47["controlFontColor"] = "0 0 0 0";
            oc_Newobject47["controlFillColor"] = "0 0 0 0";
            oc_Newobject47["backgroundColor"] = "255 255 255 255";
            oc_Newobject47["controlFontSize"] = "14";
            oc_Newobject47["visible"] = "1";
            oc_Newobject47["active"] = "1";
            oc_Newobject47["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject47["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["isContainer"] = "0";
            oc_Newobject47["alphaValue"] = "1";
            oc_Newobject47["mouseOverAlphaValue"] = "1";
            oc_Newobject47["alphaFadeTime"] = "1000";
            oc_Newobject47["moveControl"] = "0";
            oc_Newobject47["lockControl"] = "0";
            oc_Newobject47["windowSettings"] = "1";
            oc_Newobject47["alpha"] = "1";
            oc_Newobject47["mouseOverAlpha"] = "1";
            oc_Newobject47["alphaFade"] = "1";
            oc_Newobject47["contextFontColor"] = "0";
            oc_Newobject47["contextBackColor"] = "0";
            oc_Newobject47["contextFillColor"] = "0";
            oc_Newobject47["contextFontSize"] = "0";
            oc_Newobject47["internalName"] = "OptAnisotropicPopup";
            oc_Newobject47["editable"] = "0";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["canSaveDynamicFields"] = "0";
            oc_Newobject47["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject47"] = oc_Newobject47;

            #region GuiCheckBoxCtrl ()        oc_Newobject48
            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject48["text"] = "Vertical Sync";
            oc_Newobject48["groupNum"] = "-1";
            oc_Newobject48["buttonType"] = "ToggleButton";
            oc_Newobject48["useMouseEvents"] = "0";
            oc_Newobject48["position"] = "92 62";
            oc_Newobject48["extent"] = "85 18";
            oc_Newobject48["minExtent"] = "8 8";
            oc_Newobject48["maxExtent"] = "1920 1080";
            oc_Newobject48["horizSizing"] = "right";
            oc_Newobject48["vertSizing"] = "bottom";
            oc_Newobject48["profile"] = "GuiCheckBoxProfile";
            oc_Newobject48["controlFontColor"] = "0 0 0 0";
            oc_Newobject48["backgroundColor"] = "255 255 255 255";
            oc_Newobject48["controlFontSize"] = "14";
            oc_Newobject48["visible"] = "1";
            oc_Newobject48["active"] = "1";
            oc_Newobject48["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject48["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["isContainer"] = "0";
            oc_Newobject48["alphaValue"] = "1";
            oc_Newobject48["mouseOverAlphaValue"] = "1";
            oc_Newobject48["alphaFadeTime"] = "1000";
            oc_Newobject48["windowSettings"] = "1";
            oc_Newobject48["alpha"] = "1";
            oc_Newobject48["mouseOverAlpha"] = "1";
            oc_Newobject48["alphaFade"] = "1";
            oc_Newobject48["contextFontColor"] = "0";
            oc_Newobject48["contextBackColor"] = "0";
            oc_Newobject48["contextFontSize"] = "0";
            oc_Newobject48["internalName"] = "OptGraphicsVSyncToggle";
            oc_Newobject48["editable"] = "0";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["canSaveDynamicFields"] = "0";
            oc_Newobject48["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject48"] = oc_Newobject48;

            #region GuiButtonCtrl ()        oc_Newobject49
            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject49["text"] = "Auto Detect Quality";
            oc_Newobject49["groupNum"] = "-1";
            oc_Newobject49["buttonType"] = "PushButton";
            oc_Newobject49["useMouseEvents"] = "0";
            oc_Newobject49["position"] = "212 176";
            oc_Newobject49["extent"] = "110 27";
            oc_Newobject49["minExtent"] = "8 2";
            oc_Newobject49["maxExtent"] = "1920 1080";
            oc_Newobject49["horizSizing"] = "right";
            oc_Newobject49["vertSizing"] = "bottom";
            oc_Newobject49["profile"] = "GuiButtonProfile";
            oc_Newobject49["controlFontColor"] = "0 0 0 0";
            oc_Newobject49["backgroundColor"] = "255 255 255 255";
            oc_Newobject49["controlFontSize"] = "14";
            oc_Newobject49["visible"] = "1";
            oc_Newobject49["active"] = "1";
            oc_Newobject49["command"] = "OptionsDlg._autoDetectQuality();";
            oc_Newobject49["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["isContainer"] = "0";
            oc_Newobject49["alphaValue"] = "1";
            oc_Newobject49["mouseOverAlphaValue"] = "1";
            oc_Newobject49["alphaFadeTime"] = "1000";
            oc_Newobject49["windowSettings"] = "1";
            oc_Newobject49["alpha"] = "1";
            oc_Newobject49["mouseOverAlpha"] = "1";
            oc_Newobject49["alphaFade"] = "1";
            oc_Newobject49["contextFontColor"] = "0";
            oc_Newobject49["contextBackColor"] = "0";
            oc_Newobject49["contextFontSize"] = "0";
            oc_Newobject49["editable"] = "0";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["canSaveDynamicFields"] = "0";
            oc_Newobject49["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject49"] = oc_Newobject49;

            #region GuiPopUpMenuCtrl ()        oc_Newobject50
            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject50["maxPopupHeight"] = "200";
            oc_Newobject50["sbUsesNAColor"] = "0";
            oc_Newobject50["reverseTextList"] = "0";
            oc_Newobject50["bitmapBounds"] = "16 16";
            oc_Newobject50["text"] = "Off";
            oc_Newobject50["maxLength"] = "255";
            oc_Newobject50["margin"] = "0 0 0 0";
            oc_Newobject50["padding"] = "0 0 0 0";
            oc_Newobject50["anchorTop"] = "1";
            oc_Newobject50["anchorBottom"] = "0";
            oc_Newobject50["anchorLeft"] = "1";
            oc_Newobject50["anchorRight"] = "0";
            oc_Newobject50["position"] = "263 143";
            oc_Newobject50["extent"] = "78 18";
            oc_Newobject50["minExtent"] = "8 2";
            oc_Newobject50["maxExtent"] = "1920 1080";
            oc_Newobject50["horizSizing"] = "right";
            oc_Newobject50["vertSizing"] = "bottom";
            oc_Newobject50["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject50["controlFontColor"] = "0 0 0 0";
            oc_Newobject50["controlFillColor"] = "0 0 0 0";
            oc_Newobject50["backgroundColor"] = "255 255 255 255";
            oc_Newobject50["controlFontSize"] = "14";
            oc_Newobject50["visible"] = "1";
            oc_Newobject50["active"] = "1";
            oc_Newobject50["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject50["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["isContainer"] = "0";
            oc_Newobject50["alphaValue"] = "1";
            oc_Newobject50["mouseOverAlphaValue"] = "1";
            oc_Newobject50["alphaFadeTime"] = "1000";
            oc_Newobject50["moveControl"] = "0";
            oc_Newobject50["lockControl"] = "0";
            oc_Newobject50["windowSettings"] = "1";
            oc_Newobject50["alpha"] = "1";
            oc_Newobject50["mouseOverAlpha"] = "1";
            oc_Newobject50["alphaFade"] = "1";
            oc_Newobject50["contextFontColor"] = "0";
            oc_Newobject50["contextBackColor"] = "0";
            oc_Newobject50["contextFillColor"] = "0";
            oc_Newobject50["contextFontSize"] = "0";
            oc_Newobject50["internalName"] = "OptAAQualityPopup";
            oc_Newobject50["editable"] = "0";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["canSaveDynamicFields"] = "0";
            oc_Newobject50["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject50"] = oc_Newobject50;

            #region GuiTextCtrl ()        oc_Newobject51
            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject51["text"] = "Anti-aliasing";
            oc_Newobject51["maxLength"] = "255";
            oc_Newobject51["margin"] = "0 0 0 0";
            oc_Newobject51["padding"] = "0 0 0 0";
            oc_Newobject51["anchorTop"] = "1";
            oc_Newobject51["anchorBottom"] = "0";
            oc_Newobject51["anchorLeft"] = "1";
            oc_Newobject51["anchorRight"] = "0";
            oc_Newobject51["position"] = "191 143";
            oc_Newobject51["extent"] = "73 18";
            oc_Newobject51["minExtent"] = "8 2";
            oc_Newobject51["maxExtent"] = "1920 1080";
            oc_Newobject51["horizSizing"] = "right";
            oc_Newobject51["vertSizing"] = "bottom";
            oc_Newobject51["profile"] = "GuiTextProfile";
            oc_Newobject51["controlFontColor"] = "0 0 0 0";
            oc_Newobject51["controlFillColor"] = "0 0 0 0";
            oc_Newobject51["backgroundColor"] = "255 255 255 255";
            oc_Newobject51["controlFontSize"] = "14";
            oc_Newobject51["visible"] = "1";
            oc_Newobject51["active"] = "1";
            oc_Newobject51["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["isContainer"] = "0";
            oc_Newobject51["alphaValue"] = "1";
            oc_Newobject51["mouseOverAlphaValue"] = "1";
            oc_Newobject51["alphaFadeTime"] = "1000";
            oc_Newobject51["moveControl"] = "0";
            oc_Newobject51["lockControl"] = "0";
            oc_Newobject51["windowSettings"] = "1";
            oc_Newobject51["alpha"] = "1";
            oc_Newobject51["mouseOverAlpha"] = "1";
            oc_Newobject51["alphaFade"] = "1";
            oc_Newobject51["contextFontColor"] = "0";
            oc_Newobject51["contextBackColor"] = "0";
            oc_Newobject51["contextFillColor"] = "0";
            oc_Newobject51["contextFontSize"] = "0";
            oc_Newobject51["editable"] = "0";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject51"] = oc_Newobject51;

            #region GuiControl ()        oc_Newobject54
            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiControl", "");
            oc_Newobject54["position"] = "0 210";
            oc_Newobject54["extent"] = "352 15";
            oc_Newobject54["minExtent"] = "8 2";
            oc_Newobject54["maxExtent"] = "1920 1080";
            oc_Newobject54["horizSizing"] = "width";
            oc_Newobject54["vertSizing"] = "bottom";
            oc_Newobject54["profile"] = "GuiDefaultProfile";
            oc_Newobject54["controlFontColor"] = "0 0 0 0";
            oc_Newobject54["controlFillColor"] = "0 0 0 0";
            oc_Newobject54["backgroundColor"] = "255 255 255 255";
            oc_Newobject54["controlFontSize"] = "14";
            oc_Newobject54["visible"] = "1";
            oc_Newobject54["active"] = "1";
            oc_Newobject54["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject54["hovertime"] = "1000";
            oc_Newobject54["isContainer"] = "1";
            oc_Newobject54["alphaValue"] = "1";
            oc_Newobject54["mouseOverAlphaValue"] = "1";
            oc_Newobject54["alphaFadeTime"] = "1000";
            oc_Newobject54["moveControl"] = "0";
            oc_Newobject54["lockControl"] = "0";
            oc_Newobject54["windowSettings"] = "1";
            oc_Newobject54["alpha"] = "1";
            oc_Newobject54["mouseOverAlpha"] = "1";
            oc_Newobject54["alphaFade"] = "1";
            oc_Newobject54["contextFontColor"] = "0";
            oc_Newobject54["contextBackColor"] = "0";
            oc_Newobject54["contextFillColor"] = "0";
            oc_Newobject54["contextFontSize"] = "0";
            oc_Newobject54["internalName"] = "GammaSliderContainer";
            oc_Newobject54["editable"] = "0";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["canSaveDynamicFields"] = "0";
            oc_Newobject54["Enabled"] = "1";

            #region GuiSliderCtrl ()        oc_Newobject52
            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject52["range"] = "0.001 2.2";
            oc_Newobject52["ticks"] = "0";
            oc_Newobject52["snap"] = "0";
            oc_Newobject52["value"] = "1.44995";
            oc_Newobject52["position"] = "78 -2";
            oc_Newobject52["extent"] = "268 15";
            oc_Newobject52["minExtent"] = "8 2";
            oc_Newobject52["maxExtent"] = "1920 1080";
            oc_Newobject52["horizSizing"] = "right";
            oc_Newobject52["vertSizing"] = "bottom";
            oc_Newobject52["profile"] = "GuiSliderProfile";
            oc_Newobject52["controlFontColor"] = "0 0 0 0";
            oc_Newobject52["controlFillColor"] = "0 0 0 0";
            oc_Newobject52["backgroundColor"] = "255 255 255 255";
            oc_Newobject52["controlFontSize"] = "14";
            oc_Newobject52["visible"] = "1";
            oc_Newobject52["active"] = "1";
            oc_Newobject52["variable"] = "$pref::Video::Gamma";
            oc_Newobject52["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["isContainer"] = "0";
            oc_Newobject52["alphaValue"] = "1";
            oc_Newobject52["mouseOverAlphaValue"] = "1";
            oc_Newobject52["alphaFadeTime"] = "1000";
            oc_Newobject52["windowSettings"] = "1";
            oc_Newobject52["alpha"] = "1";
            oc_Newobject52["mouseOverAlpha"] = "1";
            oc_Newobject52["alphaFade"] = "1";
            oc_Newobject52["contextFontColor"] = "0";
            oc_Newobject52["contextBackColor"] = "0";
            oc_Newobject52["contextFillColor"] = "0";
            oc_Newobject52["contextFontSize"] = "0";
            oc_Newobject52["editable"] = "0";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["Enabled"] = "1";
            #endregion

            oc_Newobject54["#Newobject52"] = oc_Newobject52;

            #region GuiTextCtrl ()        oc_Newobject53
            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject53["text"] = "Gamma:";
            oc_Newobject53["maxLength"] = "255";
            oc_Newobject53["margin"] = "0 0 0 0";
            oc_Newobject53["padding"] = "0 0 0 0";
            oc_Newobject53["anchorTop"] = "1";
            oc_Newobject53["anchorBottom"] = "0";
            oc_Newobject53["anchorLeft"] = "1";
            oc_Newobject53["anchorRight"] = "0";
            oc_Newobject53["position"] = "22 -4";
            oc_Newobject53["extent"] = "105 18";
            oc_Newobject53["minExtent"] = "8 2";
            oc_Newobject53["maxExtent"] = "1920 1080";
            oc_Newobject53["horizSizing"] = "right";
            oc_Newobject53["vertSizing"] = "bottom";
            oc_Newobject53["profile"] = "GuiTextProfile";
            oc_Newobject53["controlFontColor"] = "0 0 0 0";
            oc_Newobject53["controlFillColor"] = "0 0 0 0";
            oc_Newobject53["backgroundColor"] = "255 255 255 255";
            oc_Newobject53["controlFontSize"] = "14";
            oc_Newobject53["visible"] = "1";
            oc_Newobject53["active"] = "1";
            oc_Newobject53["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject53["hovertime"] = "1000";
            oc_Newobject53["isContainer"] = "0";
            oc_Newobject53["alphaValue"] = "1";
            oc_Newobject53["mouseOverAlphaValue"] = "1";
            oc_Newobject53["alphaFadeTime"] = "1000";
            oc_Newobject53["moveControl"] = "0";
            oc_Newobject53["lockControl"] = "0";
            oc_Newobject53["windowSettings"] = "1";
            oc_Newobject53["alpha"] = "1";
            oc_Newobject53["mouseOverAlpha"] = "1";
            oc_Newobject53["alphaFade"] = "1";
            oc_Newobject53["contextFontColor"] = "0";
            oc_Newobject53["contextBackColor"] = "0";
            oc_Newobject53["contextFillColor"] = "0";
            oc_Newobject53["contextFontSize"] = "0";
            oc_Newobject53["editable"] = "0";
            oc_Newobject53["canSave"] = "1";
            oc_Newobject53["canSaveDynamicFields"] = "0";
            oc_Newobject53["Enabled"] = "1";
            #endregion

            oc_Newobject54["#Newobject53"] = oc_Newobject53;

            #endregion

            oc_Newobject58["#Newobject54"] = oc_Newobject54;

            #region GuiCheckBoxCtrl ()        oc_Newobject55
            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject55["text"] = "Hardware Acc";
            oc_Newobject55["groupNum"] = "-1";
            oc_Newobject55["buttonType"] = "ToggleButton";
            oc_Newobject55["useMouseEvents"] = "0";
            oc_Newobject55["position"] = "193 56";
            oc_Newobject55["extent"] = "140 30";
            oc_Newobject55["minExtent"] = "8 2";
            oc_Newobject55["maxExtent"] = "1920 1080";
            oc_Newobject55["horizSizing"] = "right";
            oc_Newobject55["vertSizing"] = "bottom";
            oc_Newobject55["profile"] = "GuiCheckBoxProfile";
            oc_Newobject55["controlFontColor"] = "0 0 0 0";
            oc_Newobject55["backgroundColor"] = "255 255 255 255";
            oc_Newobject55["controlFontSize"] = "14";
            oc_Newobject55["visible"] = "1";
            oc_Newobject55["active"] = "1";
            oc_Newobject55["command"] = "OptionsDlg._updateApplyState();";
            oc_Newobject55["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["isContainer"] = "0";
            oc_Newobject55["alphaValue"] = "1";
            oc_Newobject55["mouseOverAlphaValue"] = "1";
            oc_Newobject55["alphaFadeTime"] = "1000";
            oc_Newobject55["windowSettings"] = "1";
            oc_Newobject55["alpha"] = "1";
            oc_Newobject55["mouseOverAlpha"] = "1";
            oc_Newobject55["alphaFade"] = "1";
            oc_Newobject55["contextFontColor"] = "0";
            oc_Newobject55["contextBackColor"] = "0";
            oc_Newobject55["contextFontSize"] = "0";
            oc_Newobject55["internalName"] = "OptHardwareAcc";
            oc_Newobject55["editable"] = "0";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject55"] = oc_Newobject55;

            #region GuiTextCtrl ()        oc_Newobject56
            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject56["text"] = "Far distance Clip";
            oc_Newobject56["maxLength"] = "1024";
            oc_Newobject56["margin"] = "0 0 0 0";
            oc_Newobject56["padding"] = "0 0 0 0";
            oc_Newobject56["anchorTop"] = "1";
            oc_Newobject56["anchorBottom"] = "0";
            oc_Newobject56["anchorLeft"] = "1";
            oc_Newobject56["anchorRight"] = "0";
            oc_Newobject56["position"] = "15 230";
            oc_Newobject56["extent"] = "85 14";
            oc_Newobject56["minExtent"] = "8 2";
            oc_Newobject56["maxExtent"] = "1920 1080";
            oc_Newobject56["horizSizing"] = "right";
            oc_Newobject56["vertSizing"] = "bottom";
            oc_Newobject56["profile"] = "GuiTextProfile";
            oc_Newobject56["controlFontColor"] = "0 0 0 0";
            oc_Newobject56["controlFillColor"] = "0 0 0 0";
            oc_Newobject56["backgroundColor"] = "255 255 255 255";
            oc_Newobject56["controlFontSize"] = "14";
            oc_Newobject56["visible"] = "1";
            oc_Newobject56["active"] = "1";
            oc_Newobject56["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject56["hovertime"] = "1000";
            oc_Newobject56["isContainer"] = "1";
            oc_Newobject56["alphaValue"] = "1";
            oc_Newobject56["mouseOverAlphaValue"] = "1";
            oc_Newobject56["alphaFadeTime"] = "1000";
            oc_Newobject56["moveControl"] = "0";
            oc_Newobject56["lockControl"] = "0";
            oc_Newobject56["windowSettings"] = "1";
            oc_Newobject56["alpha"] = "1";
            oc_Newobject56["mouseOverAlpha"] = "1";
            oc_Newobject56["alphaFade"] = "1";
            oc_Newobject56["contextFontColor"] = "0";
            oc_Newobject56["contextBackColor"] = "0";
            oc_Newobject56["contextFillColor"] = "0";
            oc_Newobject56["contextFontSize"] = "0";
            oc_Newobject56["editable"] = "0";
            oc_Newobject56["canSave"] = "1";
            oc_Newobject56["canSaveDynamicFields"] = "0";
            oc_Newobject56["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject56"] = oc_Newobject56;
            #region GuiTextCtrl ()        oc_Newobject56a
            ObjectCreator oc_Newobject56a = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject56a["variable"] = "$pref::Camera::FarDistance";
            oc_Newobject56a["maxLength"] = "1024";
            oc_Newobject56a["margin"] = "0 0 0 0";
            oc_Newobject56a["padding"] = "0 0 0 0";
            oc_Newobject56a["anchorTop"] = "1";
            oc_Newobject56a["anchorBottom"] = "0";
            oc_Newobject56a["anchorLeft"] = "1";
            oc_Newobject56a["anchorRight"] = "0";
            oc_Newobject56a["position"] = "105 230";
            oc_Newobject56a["extent"] = "65 14";
            oc_Newobject56a["minExtent"] = "8 2";
            oc_Newobject56a["maxExtent"] = "1920 1080";
            oc_Newobject56a["horizSizing"] = "right";
            oc_Newobject56a["vertSizing"] = "bottom";
            oc_Newobject56a["profile"] = "GuiTextProfile";
            oc_Newobject56a["controlFontColor"] = "0 0 0 0";
            oc_Newobject56a["controlFillColor"] = "0 0 0 0";
            oc_Newobject56a["backgroundColor"] = "255 255 255 255";
            oc_Newobject56a["controlFontSize"] = "14";
            oc_Newobject56a["visible"] = "1";
            oc_Newobject56a["active"] = "1";
            oc_Newobject56a["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject56a["hovertime"] = "1000";
            oc_Newobject56a["isContainer"] = "1";
            oc_Newobject56a["alphaValue"] = "1";
            oc_Newobject56a["mouseOverAlphaValue"] = "1";
            oc_Newobject56a["alphaFadeTime"] = "1000";
            oc_Newobject56a["moveControl"] = "0";
            oc_Newobject56a["lockControl"] = "0";
            oc_Newobject56a["windowSettings"] = "1";
            oc_Newobject56a["alpha"] = "1";
            oc_Newobject56a["mouseOverAlpha"] = "1";
            oc_Newobject56a["alphaFade"] = "1";
            oc_Newobject56a["contextFontColor"] = "0";
            oc_Newobject56a["contextBackColor"] = "0";
            oc_Newobject56a["contextFillColor"] = "0";
            oc_Newobject56a["contextFontSize"] = "0";
            oc_Newobject56a["editable"] = "0";
            oc_Newobject56a["canSave"] = "1";
            oc_Newobject56a["canSaveDynamicFields"] = "0";
            oc_Newobject56a["Enabled"] = "1";
            #endregion
            oc_Newobject58["#Newobject56a"] = oc_Newobject56a;

            #region GuiSliderCtrl (FarDistanceClipSlider)        oc_Newobject57
            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiSliderCtrl", "FarDistanceClipSlider");
            oc_Newobject57["range"] = "0 1000";
            oc_Newobject57["ticks"] = "0";
            oc_Newobject57["snap"] = "0";
            oc_Newobject57["value"] = "500";
            oc_Newobject57["position"] = "170 229"; //"108 229";
            oc_Newobject57["extent"] = "177 26"; //"237 26";
            oc_Newobject57["minExtent"] = "8 2";
            oc_Newobject57["maxExtent"] = "1920 1080";
            oc_Newobject57["horizSizing"] = "right";
            oc_Newobject57["vertSizing"] = "bottom";
            oc_Newobject57["profile"] = "GuiSliderProfile";
            oc_Newobject57["controlFontColor"] = "0 0 0 0";
            oc_Newobject57["controlFillColor"] = "0 0 0 0";
            oc_Newobject57["backgroundColor"] = "255 255 255 255";
            oc_Newobject57["controlFontSize"] = "14";
            oc_Newobject57["visible"] = "1";
            oc_Newobject57["active"] = "1";
            oc_Newobject57["variable"] = "$pref::Camera::FarDistance";
            oc_Newobject57["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject57["hovertime"] = "1000";
            oc_Newobject57["isContainer"] = "0";
            oc_Newobject57["alphaValue"] = "1";
            oc_Newobject57["mouseOverAlphaValue"] = "1";
            oc_Newobject57["alphaFadeTime"] = "1000";
            oc_Newobject57["windowSettings"] = "1";
            oc_Newobject57["alpha"] = "1";
            oc_Newobject57["mouseOverAlpha"] = "1";
            oc_Newobject57["alphaFade"] = "1";
            oc_Newobject57["contextFontColor"] = "0";
            oc_Newobject57["contextBackColor"] = "0";
            oc_Newobject57["contextFillColor"] = "0";
            oc_Newobject57["contextFontSize"] = "0";
            oc_Newobject57["editable"] = "0";
            oc_Newobject57["canSave"] = "1";
            oc_Newobject57["canSaveDynamicFields"] = "0";
            oc_Newobject57["Enabled"] = "1";
            #endregion

            oc_Newobject58["#Newobject57"] = oc_Newobject57;

            #endregion

            oc_Newobject64["#Newobject58"] = oc_Newobject58;

            #region GuiControl ()        oc_Newobject59
            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiControl", "");
            oc_Newobject59["position"] = "9 55";
            oc_Newobject59["extent"] = "357 208";
            oc_Newobject59["minExtent"] = "8 8";
            oc_Newobject59["maxExtent"] = "1920 1080";
            oc_Newobject59["horizSizing"] = "right";
            oc_Newobject59["vertSizing"] = "bottom";
            oc_Newobject59["profile"] = "GuiWindowProfile";
            oc_Newobject59["controlFontColor"] = "0 0 0 0";
            oc_Newobject59["controlFillColor"] = "0 0 0 0";
            oc_Newobject59["backgroundColor"] = "255 255 255 255";
            oc_Newobject59["controlFontSize"] = "14";
            oc_Newobject59["visible"] = "0";
            oc_Newobject59["active"] = "1";
            oc_Newobject59["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject59["hovertime"] = "1000";
            oc_Newobject59["isContainer"] = "1";
            oc_Newobject59["alphaValue"] = "1";
            oc_Newobject59["mouseOverAlphaValue"] = "1";
            oc_Newobject59["alphaFadeTime"] = "1000";
            oc_Newobject59["moveControl"] = "0";
            oc_Newobject59["lockControl"] = "0";
            oc_Newobject59["windowSettings"] = "1";
            oc_Newobject59["alpha"] = "1";
            oc_Newobject59["mouseOverAlpha"] = "1";
            oc_Newobject59["alphaFade"] = "1";
            oc_Newobject59["contextFontColor"] = "0";
            oc_Newobject59["contextBackColor"] = "0";
            oc_Newobject59["contextFillColor"] = "0";
            oc_Newobject59["contextFontSize"] = "0";
            oc_Newobject59["internalName"] = "OptNetworkPane";
            oc_Newobject59["hidden"] = "1";
            oc_Newobject59["editable"] = "0";
            oc_Newobject59["canSave"] = "1";
            oc_Newobject59["canSaveDynamicFields"] = "0";
            oc_Newobject59["Enabled"] = "1";
            #endregion

            oc_Newobject64["#Newobject59"] = oc_Newobject59;

            #region GuiButtonCtrl ()        oc_Newobject60
            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject60["text"] = "Graphics";
            oc_Newobject60["groupNum"] = "-1";
            oc_Newobject60["buttonType"] = "RadioButton";
            oc_Newobject60["useMouseEvents"] = "0";
            oc_Newobject60["position"] = "9 33";
            oc_Newobject60["extent"] = "117 23";
            oc_Newobject60["minExtent"] = "8 8";
            oc_Newobject60["maxExtent"] = "1920 1080";
            oc_Newobject60["horizSizing"] = "right";
            oc_Newobject60["vertSizing"] = "bottom";
            oc_Newobject60["profile"] = "GuiButtonTabProfile";
            oc_Newobject60["controlFontColor"] = "0 0 0 0";
            oc_Newobject60["backgroundColor"] = "255 255 255 255";
            oc_Newobject60["controlFontSize"] = "14";
            oc_Newobject60["visible"] = "1";
            oc_Newobject60["active"] = "1";
            oc_Newobject60["command"] = "optionsDlg.setPane(Graphics);";
            oc_Newobject60["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject60["hovertime"] = "1000";
            oc_Newobject60["isContainer"] = "0";
            oc_Newobject60["alphaValue"] = "1";
            oc_Newobject60["mouseOverAlphaValue"] = "1";
            oc_Newobject60["alphaFadeTime"] = "1000";
            oc_Newobject60["windowSettings"] = "1";
            oc_Newobject60["alpha"] = "1";
            oc_Newobject60["mouseOverAlpha"] = "1";
            oc_Newobject60["alphaFade"] = "1";
            oc_Newobject60["contextFontColor"] = "0";
            oc_Newobject60["contextBackColor"] = "0";
            oc_Newobject60["contextFontSize"] = "0";
            oc_Newobject60["internalName"] = "OptGraphicsButton";
            oc_Newobject60["editable"] = "0";
            oc_Newobject60["canSave"] = "1";
            oc_Newobject60["canSaveDynamicFields"] = "0";
            oc_Newobject60["Enabled"] = "1";
            #endregion

            oc_Newobject64["#Newobject60"] = oc_Newobject60;

            #region GuiButtonCtrl ()        oc_Newobject61
            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject61["text"] = "Audio";
            oc_Newobject61["groupNum"] = "-1";
            oc_Newobject61["buttonType"] = "RadioButton";
            oc_Newobject61["useMouseEvents"] = "0";
            oc_Newobject61["position"] = "126 33";
            oc_Newobject61["extent"] = "117 23";
            oc_Newobject61["minExtent"] = "8 8";
            oc_Newobject61["maxExtent"] = "1920 1080";
            oc_Newobject61["horizSizing"] = "right";
            oc_Newobject61["vertSizing"] = "bottom";
            oc_Newobject61["profile"] = "GuiButtonTabProfile";
            oc_Newobject61["controlFontColor"] = "0 0 0 0";
            oc_Newobject61["backgroundColor"] = "255 255 255 255";
            oc_Newobject61["controlFontSize"] = "14";
            oc_Newobject61["visible"] = "1";
            oc_Newobject61["active"] = "1";
            oc_Newobject61["command"] = "optionsDlg.setPane(Audio);";
            oc_Newobject61["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject61["hovertime"] = "1000";
            oc_Newobject61["isContainer"] = "0";
            oc_Newobject61["alphaValue"] = "1";
            oc_Newobject61["mouseOverAlphaValue"] = "1";
            oc_Newobject61["alphaFadeTime"] = "1000";
            oc_Newobject61["windowSettings"] = "1";
            oc_Newobject61["alpha"] = "1";
            oc_Newobject61["mouseOverAlpha"] = "1";
            oc_Newobject61["alphaFade"] = "1";
            oc_Newobject61["contextFontColor"] = "0";
            oc_Newobject61["contextBackColor"] = "0";
            oc_Newobject61["contextFontSize"] = "0";
            oc_Newobject61["editable"] = "0";
            oc_Newobject61["canSave"] = "1";
            oc_Newobject61["canSaveDynamicFields"] = "0";
            oc_Newobject61["Enabled"] = "1";
            #endregion

            oc_Newobject64["#Newobject61"] = oc_Newobject61;

            #region GuiButtonCtrl ()        oc_Newobject62
            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject62["text"] = "Controls";
            oc_Newobject62["groupNum"] = "-1";
            oc_Newobject62["buttonType"] = "RadioButton";
            oc_Newobject62["useMouseEvents"] = "0";
            oc_Newobject62["position"] = "243 33";
            oc_Newobject62["extent"] = "117 23";
            oc_Newobject62["minExtent"] = "8 8";
            oc_Newobject62["maxExtent"] = "1920 1080";
            oc_Newobject62["horizSizing"] = "right";
            oc_Newobject62["vertSizing"] = "bottom";
            oc_Newobject62["profile"] = "GuiButtonTabProfile";
            oc_Newobject62["controlFontColor"] = "0 0 0 0";
            oc_Newobject62["backgroundColor"] = "255 255 255 255";
            oc_Newobject62["controlFontSize"] = "14";
            oc_Newobject62["visible"] = "1";
            oc_Newobject62["active"] = "1";
            oc_Newobject62["command"] = "optionsDlg.setPane(Controls);";
            oc_Newobject62["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject62["hovertime"] = "1000";
            oc_Newobject62["isContainer"] = "0";
            oc_Newobject62["alphaValue"] = "1";
            oc_Newobject62["mouseOverAlphaValue"] = "1";
            oc_Newobject62["alphaFadeTime"] = "1000";
            oc_Newobject62["windowSettings"] = "1";
            oc_Newobject62["alpha"] = "1";
            oc_Newobject62["mouseOverAlpha"] = "1";
            oc_Newobject62["alphaFade"] = "1";
            oc_Newobject62["contextFontColor"] = "0";
            oc_Newobject62["contextBackColor"] = "0";
            oc_Newobject62["contextFontSize"] = "0";
            oc_Newobject62["editable"] = "0";
            oc_Newobject62["canSave"] = "1";
            oc_Newobject62["canSaveDynamicFields"] = "0";
            oc_Newobject62["Enabled"] = "1";
            #endregion

            oc_Newobject64["#Newobject62"] = oc_Newobject62;

            #region GuiButtonCtrl ()        oc_Newobject63
            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject63["text"] = "Apply";
            oc_Newobject63["groupNum"] = "-1";
            oc_Newobject63["buttonType"] = "PushButton";
            oc_Newobject63["useMouseEvents"] = "0";
            oc_Newobject63["position"] = "231 326";
            oc_Newobject63["extent"] = "60 23";
            oc_Newobject63["minExtent"] = "8 8";
            oc_Newobject63["maxExtent"] = "1920 1080";
            oc_Newobject63["horizSizing"] = "right";
            oc_Newobject63["vertSizing"] = "bottom";
            oc_Newobject63["profile"] = "GuiButtonProfile";
            oc_Newobject63["controlFontColor"] = "0 0 0 0";
            oc_Newobject63["backgroundColor"] = "255 255 255 255";
            oc_Newobject63["controlFontSize"] = "14";
            oc_Newobject63["visible"] = "1";
            oc_Newobject63["active"] = "1";
            oc_Newobject63["command"] = "optionsDlg.applyGraphics();";
            oc_Newobject63["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject63["hovertime"] = "1000";
            oc_Newobject63["isContainer"] = "0";
            oc_Newobject63["alphaValue"] = "1";
            oc_Newobject63["mouseOverAlphaValue"] = "1";
            oc_Newobject63["alphaFadeTime"] = "1000";
            oc_Newobject63["windowSettings"] = "1";
            oc_Newobject63["alpha"] = "1";
            oc_Newobject63["mouseOverAlpha"] = "1";
            oc_Newobject63["alphaFade"] = "1";
            oc_Newobject63["contextFontColor"] = "0";
            oc_Newobject63["contextBackColor"] = "0";
            oc_Newobject63["contextFontSize"] = "0";
            oc_Newobject63["internalName"] = "apply";
            oc_Newobject63["editable"] = "0";
            oc_Newobject63["canSave"] = "1";
            oc_Newobject63["canSaveDynamicFields"] = "0";
            oc_Newobject63["Enabled"] = "1";
            #endregion

            oc_Newobject64["#Newobject63"] = oc_Newobject63;

            #endregion

            oc_Newobject65["#Newobject64"] = oc_Newobject64;

            #endregion
            oc_Newobject65.Create();
            }


        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public static string _makePrettyResString(string resString)
            {
            string width = omni.Util.getWord(resString, omni.iGlobal["$WORD::RES_X"]);
            string height = omni.Util.getWord(resString, omni.iGlobal["$WORD::RES_Y"]);

            float aspect = width.AsFloat() / height.AsFloat();

            aspect = (float)Math.Round(aspect, 2); // omni.Util.mRound(aspect * 100.0f) * .01f;
            string newaspect = "";
            if (aspect == 1.33f)
                newaspect = "4:3";
            else if (aspect == 1.78f)
                newaspect = "16:9";

            string outRes = width + " X " + height;
            if (newaspect != "")
                outRes = outRes + " (" + newaspect + ")";
            return outRes;
            }

        [ConsoleInteraction(true)]
        public void setPane(string pane)
            {
            ((GuiBitmapBorderCtrl)findObjectByInternalName("OptAudioPane", true)).setVisible(false);
            ((GuiBitmapBorderCtrl)findObjectByInternalName("OptGraphicsPane", true)).setVisible(false);
            ((GuiControl)findObjectByInternalName("OptNetworkPane", true)).setVisible(false);
            ((GuiBitmapBorderCtrl)findObjectByInternalName("OptControlsPane", true)).setVisible(false);

            ((GuiControl)findObjectByInternalName("Opt" + pane + "Pane", true)).setVisible(true);

            fillRemapList();

            // Update the state of the apply button.
            _updateApplyState();
            }

        public override void onWake()
            {
            if (Util.isFunction("getWebDeployment") && Util.getWebDeployment())
                {
                // Cannot enable full screen under web deployment
                ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsFullscreenToggle", true)).setStateOn(false);
                ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsFullscreenToggle", true)).setVisible(false);
                }
            else
                ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsFullscreenToggle", true)).setStateOn(
                    ((GuiCanvas)"Canvas").isFullscreen());

            ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsVSyncToggle", true)).setStateOn(
                !bGlobal["$pref::Video::disableVerticalSync"]);
            initResMenu();

            int resSelID =
                ((GuiPopUpMenuCtrl)findObjectByInternalName("OptGraphicsResolutionMenu", true)).findText(
                    _makePrettyResString(sGlobal["$pref::Video::Canvas::mode"]));
            if (resSelID != -1)
                ((GuiPopUpMenuCtrl)findObjectByInternalName("OptGraphicsResolutionMenu", true)).setSelected(
                    resSelID);

            ((GuiPopUpMenuCtrl)"OptGraphicsDriverMenu").clear();

            string buffer = Util.getDisplayDeviceList();
            int count = Util.getFieldCount(buffer);
            for (int i = 0; i < count; i++)
                ((GuiPopUpMenuCtrl)"OptGraphicsDriverMenu").add(Util.getField(buffer, i), i);

            int selId = ((GuiPopUpMenuCtrl)"OptGraphicsDriverMenu").findText(Util.getDisplayDeviceInformation());

            if (selId == -1)
                ((GuiPopUpMenuCtrl)"OptGraphicsDriverMenu").setFirstSelected();
            else
                ((GuiPopUpMenuCtrl)"OptGraphicsDriverMenu").setSelected(selId);

            ((GraphicsQualityPopup)findObjectByInternalName("OptMeshQualityPopup", true)).init("MeshQualityGroup");
            ((GraphicsQualityPopup)findObjectByInternalName("OptTextureQualityPopup", true)).init("TextureQualityGroup");
            ((GraphicsQualityPopup)findObjectByInternalName("OptLightingQualityPopup", true)).init(
                "LightingQualityGroup");
            ((GraphicsQualityPopup)findObjectByInternalName("OptShaderQualityPopup", true)).init("ShaderQualityGroup");


            // Setup the anisotropic filtering menu.
            GuiPopUpMenuCtrl ansioCtrl = findObjectByInternalName("OptAnisotropicPopup", true);
            ansioCtrl.clear();
            ansioCtrl.add("Off", 0);
            ansioCtrl.add("4X", 4);
            ansioCtrl.add("8X", 8);
            ansioCtrl.add("16X", 16);
            ansioCtrl.setSelected(sGlobal["$pref::Video::defaultAnisotropy"].AsInt(), true);
            // set up the Refresh Rate menu.


            GuiPopUpMenuCtrl refreshMenu = findObjectByInternalName("OptRefreshSelectMenu", true);
            refreshMenu.clear();
            refreshMenu.add("60", 60);
            refreshMenu.add("75", 75);
            refreshMenu.setSelected(Util.getWord(sGlobal["$pref::Video::Canvas::mode"], iGlobal["$WORD::REFRESH"]).AsInt());

            // Audio
            //OptAudioHardwareToggle.setStateOn($pref::SFX::useHardware);
            //OptAudioHardwareToggle.setActive( true );

            ((GuiSliderCtrl)findObjectByInternalName("OptAudioVolumeMaster", true)).setValue(
                sGlobal["$pref::SFX::masterVolume"]);
            ((GuiSliderCtrl)findObjectByInternalName("OptAudioVolumeShell", true)).setValue(
                sGlobal["$pref::SFX::channelVolume[" + sGlobal["$GuiAudioType"] + "]"]);

            ((GuiSliderCtrl)findObjectByInternalName("OptAudioVolumeSim", true)).setValue(
                sGlobal["$pref::SFX::channelVolume[" + sGlobal["$SimAudioType"] + "]"]);
            ((GuiSliderCtrl)findObjectByInternalName("OptAudioVolumeMusic", true)).setValue(
                sGlobal["$pref::SFX::channelVolume[" + sGlobal["$MusicAudioType"] + "]"]);

            GuiPopUpMenuCtrl OptAudioProviderList = "OptAudioProviderList";
            OptAudioProviderList.clear();
            buffer = Util.sfxGetAvailableDevices();
            count = Util.getRecordCount(buffer);
            for (int i = 0; i < count; i++)
                {
                string record = Util.getRecord(buffer, i);
                string provider = Util.getField(record, 0);
                if (OptAudioProviderList.findText(provider) == -1)
                    OptAudioProviderList.add(provider, i);
                }
            OptAudioProviderList.sort();

            selId = OptAudioProviderList.findText(sGlobal["$pref::SFX::provider"]);
            if (selId == -1)
                OptAudioProviderList.setFirstSelected();
            else
                OptAudioProviderList.setSelected(selId);

            // Populate the Anti-aliasing popup.
            console.print("Current Mode: " + sGlobal["$pref::Video::Canvas::mode"]);
            GuiPopUpMenuCtrl aaMenu = findObjectByInternalName("OptAAQualityPopup", true);
            aaMenu.clear();
            aaMenu.add("Off", 0);
            aaMenu.add("1x", 1);
            aaMenu.add("2x", 2);
            aaMenu.add("4x", 4);

            try
                {
                int AA = sGlobal["$pref::Video::Canvas::mode"].Split(' ')[5].AsInt();
                aaMenu.setSelected(AA);
                }
            catch (Exception)
                {
                aaMenu.setSelected(0);
                }



            ((GuiSliderCtrl)"OptMouseSensitivity").value = fGlobal["$pref::Input::LinkMouseSensitivity"];
            // Set the graphics pane to start.

            ((GuiButtonCtrl)findObjectByInternalName("OptGraphicsButton", true)).performClick();
            }

        public override void onSleep()
            {
            // write out the control config into the rw/config.cs file
            ((ActionMap)"moveMap").save("scripts/client/config.cs", false);
            }

        [ConsoleInteraction(true)]
        public void initResMenu()
            {
            GuiPopUpMenuCtrl resMenu = findObjectByInternalName("OptGraphicsResolutionMenu", true);
            resMenu.clear();
            // If we are in a browser then we can't change our resolution through
            // the options dialog
            int count = 0;
            if (Util.getWebDeployment())
                {
                string currRes = Util.getWords(((GuiCanvas)"Canvas").getVideoMode(), iGlobal["$WORD::RES_X"],
                    iGlobal["$WORD::RES_Y"]);
                resMenu.add(currRes, count);
                count++;
                return;
                }
            // Loop through all and add all valid resolutions
            int resCount = ((GuiCanvas)"Canvas").getModeCount();
            for (int i = 0; i < resCount; i++)
                {
                string testResString = ((GuiCanvas)"Canvas").getMode(i);
                string testRes = _makePrettyResString(testResString);
                // Only add to list if it isn't there already.
                if (resMenu.findText(testRes) == -1)
                    {
                    resMenu.add(testRes, i);
                    count++;
                    }
                }
            resMenu.sort();
            }

        [ConsoleInteraction(true)]
        public bool applyGraphics(bool testNeedApply)
            {
            string newAdapter = ((GuiPopUpMenuCtrl)"OptGraphicsDriverMenu").getText();
            int numAdapters = console.Call_Classname("GFXInit", "getAdapterCount").AsInt();
            string newDevice = sGlobal["$pref::Video::displayDevice"];

            for (int i = 0; i < numAdapters; i++)
                {
                if (console.Call_Classname("GFXInit", "getAdapterName", new string[] { i.AsString() }) == newAdapter)
                    {
                    newDevice = console.Call_Classname("GFXInit", "getAdapterType", new string[] { i.AsString() });
                    break;
                    }
                }
            // Change the device.
            if (newDevice != sGlobal["$pref::Video::displayDevice"])
                {
                if (testNeedApply)
                    return true;

                sGlobal["$pref::Video::displayDevice"] = newDevice;
                if (newAdapter != Util.getDisplayDeviceInformation())
                    messageBox.MessageBoxOK("Change requires restart",
                        "Please restart the game for a display device change to take effect.", "");
                }

            string newRes = "";
            // Gather the new video mode.
            if (Util.getWebDeployment())
                newRes = ((GuiPopUpMenuCtrl)findObjectByInternalName("OptGraphicsResolutionMenu", true)).getText();
            else
                newRes = Util.getWords(((GuiCanvas)"Canvas").getMode(
                    ((GuiPopUpMenuCtrl)findObjectByInternalName("OptGraphicsResolutionMenu", true)).getSelected()),
                    iGlobal["$WORD::RES_X"],
                    iGlobal["$WORD::RES_Y"]);

            int newBpp = 32; //... its not 1997 anymore.
            bool newFullScreen =
                ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsFullscreenToggle", true)).getValue().AsBool();
            int newRefresh = ((GuiPopUpMenuCtrl)findObjectByInternalName("OptRefreshSelectMenu", true)).getSelected();
            string newVsync =
                (!((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsVSyncToggle", true)).getValue().AsBool())
                    .AsString();
            int newFSAA = ((GuiPopUpMenuCtrl)findObjectByInternalName("OptAAQualityPopup", true)).getSelected();
            // Under web deployment we can't be full screen.

            bool newHardwareAcc = ((GuiCheckBoxCtrl)findObjectByInternalName("OptHardwareAcc", true)).getValue().AsBool();

            if (newHardwareAcc == bGlobal["$pref::Video::disableHardwareAA"])
                {
                if (testNeedApply)
                    return true;
                bGlobal["$pref::Video::disableHardwareAA"] = !newHardwareAcc;
                }

            Point3F deskRes;
            float deskResX;
            float deskResY;

            if (Util.getWebDeployment())
                newFullScreen = false;
            else if (!newFullScreen)
                {
                // If we're in windowed mode switch the fullscreen check
                // if the resolution is bigger than the desktop.
                deskRes = Util.getDesktopResolution();
                deskResX = deskRes.x;
                deskResY = deskRes.y;
                if (!(deskRes.x == 0.0 && deskRes.y == 0.0))
                    if ((Util.getWord(newRes, iGlobal["$WORD::RES_X"]).AsFloat() > deskResX) ||
                        (Util.getWord(newRes, iGlobal["$WORD::RES_Y"]).AsFloat() > deskResY))
                        {
                        newFullScreen = true;
                        ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsFullscreenToggle", true)).setStateOn(
                            true);
                        }
                }
            // Build the final mode string.
            string newMode = newRes + " " + newFullScreen + " " + newBpp + " " + newRefresh + " " + newFSAA;

            if (newMode != sGlobal["$pref::Video::Canvas::mode"] ||
                newVsync != sGlobal["$pref::Video::disableVerticalSync"])
                {
                if (testNeedApply)
                    return true;

                sGlobal["$pref::Video::Canvas::mode"] = newMode;
                console.print("New Video Mode: " + newMode);

                sGlobal["$pref::Video::disableVerticalSync"] = newVsync;
                ((GuiCheckBoxCtrl)findObjectByInternalName("OptGraphicsVSyncToggle", true)).setStateOn(
                    !bGlobal["$pref::Video::disableVerticalSync"]);
                canvas.configureCanvas();
                }
            // Test and apply the graphics settings.

            if (((GraphicsQualityPopup)findObjectByInternalName("OptMeshQualityPopup", true)).apply(
                "MeshQualityGroup", testNeedApply)) return true;
            if (
                ((GraphicsQualityPopup)findObjectByInternalName("OptTextureQualityPopup", true)).apply(
                    "TextureQualityGroup", testNeedApply)) return true;
            if (
                ((GraphicsQualityPopup)findObjectByInternalName("OptLightingQualityPopup", true)).apply(
                    "LightingQualityGroup", testNeedApply)) return true;
            if (
                ((GraphicsQualityPopup)findObjectByInternalName("OptShaderQualityPopup", true)).apply(
                    "ShaderQualityGroup", testNeedApply)) return true;

            // Check the anisotropic filtering.  
            int level = ((GuiPopUpMenuCtrl)findObjectByInternalName("OptAnisotropicPopup", true)).getSelected();
            if (level != iGlobal["$pref::Video::defaultAnisotropy"])
                {
                if (testNeedApply)
                    return true;

                iGlobal["$pref::Video::defaultAnisotropy"] = level;
                }
            // If we're applying the state then recheck the 
            // state to update the apply button.
            if (!testNeedApply)
                _updateApplyState();

            omni.Util.export("$pref::*", "prefs.client.cs", false);
            return false;
            }

        [ConsoleInteraction(true)]
        public void _updateApplyState()
            {
            GuiButtonCtrl applyCtrl = ((GuiButtonCtrl)findObjectByInternalName("Apply", true));
            GuiBitmapBorderCtrl graphicsPane = findObjectByInternalName("OptGraphicsPane", true);

            applyCtrl.active = graphicsPane.isVisible() && applyGraphics(true);
            }

        [ConsoleInteraction(true)]
        public void _autoDetectQuality()
            {
            string msg = client.GraphicsQualityAutodetect();
            onWake();
            if (msg != "")
                messageBox.MessageBoxOK("Notice", msg, "");
            }

        [ConsoleInteraction(true)]
        public void fillRemapList()
            {
            GuiTextListCtrl remapList = findObjectByInternalName("OptRemapList", true);
            remapList.clear();
            for (int i = 0; i < iGlobal["$RemapCount"]; i++)
                remapList.addRow(i, buildFullMapString(i), -1);
            }

        [ConsoleInteraction(true)]
        public void doRemap()
            {
            GuiTextListCtrl remapList = findObjectByInternalName("OptRemapList", true);
            int selId = remapList.getSelectedId();
            string name = sGlobal["$RemapName[" + selId + "]"];

            ((GuiTextCtrl)remapList.findObjectByInternalName("OptRemapText", true)).setText("Re-bind '" + name +
                                                                                               "' to....");
            ((GuiInputCtrl)"OptRemapInputCtrl")["index"] = selId.AsString();
            ((GuiCanvas)"Canvas").pushDialog("RemapDlg");
            }

        [ConsoleInteraction(true)]
        public static string buildFullMapString(int index)
            {
            string name = omni.sGlobal["$RemapName[" + index + "]"];
            string cmd = omni.sGlobal["$RemapCmd[" + index + "]"];
            string temp = ((ActionMap)"moveMap").getBinding(cmd);

            if (temp == "")
                return name + "\t" + "";

            string mapString = "";

            int count = omni.Util.getFieldCount(temp);
            for (int i = 0; i < count; i += 2)
                {
                if (mapString != "")
                    mapString = mapString + ", ";
                string device = omni.Util.getField(temp, i + 0);
                string obj = omni.Util.getField(temp, i + 1);
                mapString = mapString + getMapDisplayName(device, obj);
                }
            return name + "\t" + mapString;
            }

        [ConsoleInteraction(true)]
        public static string getMapDisplayName(string device, string action)
            {
            string mods = "";
            string Object = "";
            string instance = "";

            if (device == "keyboard")
                return action;
            else if (omni.Util.strstr(device, "mouse") != -1)
                {
                // Substitute "mouse" for "button" in the action string:
                int pos = omni.Util.strstr(action, "button");
                if (pos != -1)
                    {
                    mods = omni.Util.getSubStr(action, 0, pos);
                    Object = omni.Util.getSubStr(action, pos, 1000);
                    instance = omni.Util.getSubStr(Object, omni.Util.strlen("button"), 1000);
                    return mods + "mouse" + (instance.AsInt() + 1);
                    }
                else
                    omni.console.error("Mouse input object other than button passed to getDisplayMapName!");
                }
            else if (omni.Util.strstr(device, "joystick") != -1)
                {
                int pos = omni.Util.strstr(action, "button");
                if (pos != -1)
                    {
                    mods = omni.Util.getSubStr(action, 0, pos);
                    Object = omni.Util.getSubStr(action, pos, 1000);
                    instance = omni.Util.getSubStr(Object, omni.Util.strlen("button"), 1000);
                    return mods + "joystick" + (instance.AsInt() + 1);
                    }
                else
                    {
                    pos = omni.Util.strstr(action, "pov");
                    if (pos != -1)
                        {
                        int wordCount = omni.Util.getWordCount(action);
                        mods = (wordCount > 1) ? omni.Util.getWords(action, 0, wordCount - 2) + " " : "";
                        Object = omni.Util.getWord(action, wordCount - 1);
                        switch (Object)
                            {
                            case "upov":
                                Object = "POV1 up";
                                break;
                            case "dpov":
                                Object = "POV1 down";
                                break;
                            case "lpov":
                                Object = "POV1 left";
                                break;
                            case "rpov":
                                Object = "POV1 right";
                                break;
                            case "upov2":
                                Object = "POV2 up";
                                break;
                            case "dpov2":
                                Object = "POV2 down";
                                break;
                            case "lpov2":
                                Object = "POV2 left";
                                break;
                            case "rpov2":
                                Object = "POV2 right";
                                break;
                            default:
                                Object = "??";
                                break;
                            }
                        return mods + Object;
                        }

                    else
                        omni.console.error("Unsupported Joystick input object passed to getDisplayMapName!");
                    }
                }
            return "??";
            }

        [ConsoleInteraction]
        public void CloseScreen()
            {
            ((canvas)"Canvas").popDialog("optionsDlg");
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OptionsDlg ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(OptionsDlg ts, string simobjectid)
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
        public static implicit operator string(OptionsDlg ts)
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
        public static implicit operator OptionsDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (OptionsDlg)Omni.self.getSimObject(simobjectid, typeof(OptionsDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(OptionsDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator OptionsDlg(int simobjectid)
            {
            return (OptionsDlg)Omni.self.getSimObject((uint)simobjectid, typeof(OptionsDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(OptionsDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator OptionsDlg(uint simobjectid)
            {
            return (OptionsDlg)Omni.self.getSimObject(simobjectid, typeof(OptionsDlg));
            }

        #endregion
        }
    }