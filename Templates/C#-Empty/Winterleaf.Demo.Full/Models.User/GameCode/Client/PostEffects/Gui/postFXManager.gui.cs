using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Shaders;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui
    {
    [TypeConverter(typeof(TypeConverterGeneric<postFXManager>))]
    public class postFXManager : GuiControl
        {
        private static bool guicreated = false;


        public static void initialize()
            {
                #region GuiControl (PostFXManager)        oc_Newobject159
                ObjectCreator oc_Newobject159 = new ObjectCreator("GuiControl", "PostFXManager",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.postFXManager));
                oc_Newobject159["position"] = "0 0";
                oc_Newobject159["extent"] = "1280 720";
                oc_Newobject159["minExtent"] = "8 8";
                oc_Newobject159["maxExtent"] = "1920 1080";
                oc_Newobject159["horizSizing"] = "width";
                oc_Newobject159["vertSizing"] = "height";
                oc_Newobject159["profile"] = "GuiModelessDialogProfile";
                oc_Newobject159["controlFontColor"] = "0 0 0 0";
                oc_Newobject159["controlFillColor"] = "0 0 0 0";
                oc_Newobject159["backgroundColor"] = "255 255 255 255";
                oc_Newobject159["controlFontSize"] = "14";
                oc_Newobject159["visible"] = "1";
                oc_Newobject159["active"] = "1";
                oc_Newobject159["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject159["hovertime"] = "1000";
                oc_Newobject159["isContainer"] = "1";
                oc_Newobject159["alphaValue"] = "1";
                oc_Newobject159["mouseOverAlphaValue"] = "1";
                oc_Newobject159["alphaFadeTime"] = "1000";
                oc_Newobject159["moveControl"] = "0";
                oc_Newobject159["lockControl"] = "0";
                oc_Newobject159["windowSettings"] = "1";
                oc_Newobject159["alpha"] = "1";
                oc_Newobject159["mouseOverAlpha"] = "1";
                oc_Newobject159["alphaFade"] = "1";
                oc_Newobject159["contextFontColor"] = "0";
                oc_Newobject159["contextBackColor"] = "0";
                oc_Newobject159["contextFillColor"] = "0";
                oc_Newobject159["contextFontSize"] = "0";
                oc_Newobject159["editable"] = "0";
                oc_Newobject159["canSave"] = "1";
                oc_Newobject159["canSaveDynamicFields"] = "1";
                oc_Newobject159["Enabled"] = "1";

                #region DbgFileView ()        oc_Newobject1
                ObjectCreator oc_Newobject1 = new ObjectCreator("DbgFileView", "");
                oc_Newobject1["position"] = "0 0";
                oc_Newobject1["extent"] = "8 2";
                oc_Newobject1["minExtent"] = "8 2";
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
                oc_Newobject1["editable"] = "0";
                oc_Newobject1["canSave"] = "1";
                oc_Newobject1["canSaveDynamicFields"] = "0";
                oc_Newobject1["Enabled"] = "1";
                #endregion

                oc_Newobject159["#Newobject1"] = oc_Newobject1;

                #region GuiWindowCtrl (ppOptionsWindow)        oc_Newobject158
                ObjectCreator oc_Newobject158 = new ObjectCreator("GuiWindowCtrl", "ppOptionsWindow");
                oc_Newobject158["text"] = "PostFX Manager";
                oc_Newobject158["resizeWidth"] = "0";
                oc_Newobject158["resizeHeight"] = "0";
                oc_Newobject158["canMove"] = "1";
                oc_Newobject158["canClose"] = "1";
                oc_Newobject158["canMinimize"] = "0";
                oc_Newobject158["canMaximize"] = "0";
                oc_Newobject158["canCollapse"] = "0";
                oc_Newobject158["closeCommand"] = "Canvas.popDialog(PostFXManager);";
                oc_Newobject158["edgeSnap"] = "0";
                oc_Newobject158["setTitle"] = "0";
                oc_Newobject158["ShowTitle"] = "1";
                oc_Newobject158["AllowPopWindow"] = "0";
                oc_Newobject158["isInPopup"] = "0";
                oc_Newobject158["margin"] = "0 0 0 0";
                oc_Newobject158["padding"] = "0 0 0 0";
                oc_Newobject158["anchorTop"] = "1";
                oc_Newobject158["anchorBottom"] = "0";
                oc_Newobject158["anchorLeft"] = "1";
                oc_Newobject158["anchorRight"] = "0";
                oc_Newobject158["position"] = "237 216";
                oc_Newobject158["extent"] = "618 336";
                oc_Newobject158["minExtent"] = "8 8";
                oc_Newobject158["maxExtent"] = "1920 1080";
                oc_Newobject158["horizSizing"] = "center";
                oc_Newobject158["vertSizing"] = "center";
                oc_Newobject158["profile"] = "GuiWindowProfile";
                oc_Newobject158["controlFontColor"] = "0 0 0 0";
                oc_Newobject158["controlFillColor"] = "0 0 0 0";
                oc_Newobject158["backgroundColor"] = "255 255 255 255";
                oc_Newobject158["controlFontSize"] = "14";
                oc_Newobject158["visible"] = "1";
                oc_Newobject158["active"] = "1";
                oc_Newobject158["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject158["hovertime"] = "1000";
                oc_Newobject158["isContainer"] = "1";
                oc_Newobject158["alphaValue"] = "1";
                oc_Newobject158["mouseOverAlphaValue"] = "1";
                oc_Newobject158["alphaFadeTime"] = "1000";
                oc_Newobject158["moveControl"] = "1";
                oc_Newobject158["lockControl"] = "0";
                oc_Newobject158["windowSettings"] = "1";
                oc_Newobject158["alpha"] = "1";
                oc_Newobject158["mouseOverAlpha"] = "1";
                oc_Newobject158["alphaFade"] = "1";
                oc_Newobject158["contextFontColor"] = "0";
                oc_Newobject158["contextBackColor"] = "0";
                oc_Newobject158["contextFillColor"] = "0";
                oc_Newobject158["contextFontSize"] = "0";
                oc_Newobject158["editable"] = "0";
                oc_Newobject158["canSave"] = "1";
                oc_Newobject158["canSaveDynamicFields"] = "0";
                oc_Newobject158["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject2
                ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject2["position"] = "11 77";
                oc_Newobject2["extent"] = "602 216";
                oc_Newobject2["minExtent"] = "8 2";
                oc_Newobject2["maxExtent"] = "1920 1080";
                oc_Newobject2["horizSizing"] = "right";
                oc_Newobject2["vertSizing"] = "bottom";
                oc_Newobject2["profile"] = "GuiTabBorderProfile";
                oc_Newobject2["controlFontColor"] = "0 0 0 0";
                oc_Newobject2["controlFillColor"] = "0 0 0 0";
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
                oc_Newobject2["moveControl"] = "0";
                oc_Newobject2["lockControl"] = "0";
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
                #endregion

                oc_Newobject158["#Newobject2"] = oc_Newobject2;

                #region GuiTabBookCtrl (ppOptionsTabBook)        oc_Newobject150
                ObjectCreator oc_Newobject150 = new ObjectCreator("GuiTabBookCtrl", "ppOptionsTabBook");
                oc_Newobject150["tabPosition"] = "Top";
                oc_Newobject150["tabMargin"] = "7";
                oc_Newobject150["minTabWidth"] = "64";
                oc_Newobject150["tabHeight"] = "20";
                oc_Newobject150["allowReorder"] = "0";
                oc_Newobject150["defaultPage"] = "-1";
                oc_Newobject150["selectedPage"] = "2";
                oc_Newobject150["frontTabPadding"] = "0";
                oc_Newobject150["margin"] = "0 0 0 0";
                oc_Newobject150["padding"] = "0 0 0 0";
                oc_Newobject150["anchorTop"] = "1";
                oc_Newobject150["anchorBottom"] = "0";
                oc_Newobject150["anchorLeft"] = "1";
                oc_Newobject150["anchorRight"] = "0";
                oc_Newobject150["position"] = "11 58";
                oc_Newobject150["extent"] = "600 233";
                oc_Newobject150["minExtent"] = "8 2";
                oc_Newobject150["maxExtent"] = "1920 1080";
                oc_Newobject150["horizSizing"] = "right";
                oc_Newobject150["vertSizing"] = "bottom";
                oc_Newobject150["profile"] = "GuiTabBookProfile";
                oc_Newobject150["controlFontColor"] = "0 0 0 0";
                oc_Newobject150["controlFillColor"] = "0 0 0 0";
                oc_Newobject150["backgroundColor"] = "255 255 255 255";
                oc_Newobject150["controlFontSize"] = "14";
                oc_Newobject150["visible"] = "1";
                oc_Newobject150["active"] = "1";
                oc_Newobject150["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject150["hovertime"] = "1000";
                oc_Newobject150["isContainer"] = "1";
                oc_Newobject150["alphaValue"] = "1";
                oc_Newobject150["mouseOverAlphaValue"] = "1";
                oc_Newobject150["alphaFadeTime"] = "1000";
                oc_Newobject150["windowSettings"] = "1";
                oc_Newobject150["alpha"] = "1";
                oc_Newobject150["mouseOverAlpha"] = "1";
                oc_Newobject150["alphaFade"] = "1";
                oc_Newobject150["contextFontColor"] = "0";
                oc_Newobject150["contextBackColor"] = "0";
                oc_Newobject150["contextFillColor"] = "0";
                oc_Newobject150["contextFontSize"] = "0";
                oc_Newobject150["editable"] = "0";
                oc_Newobject150["canSave"] = "1";
                oc_Newobject150["canSaveDynamicFields"] = "0";
                oc_Newobject150["Enabled"] = "1";

                #region GuiTabPageCtrl (ppOptionsImageTab)        oc_Newobject18
                ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsImageTab");
                oc_Newobject18["fitBook"] = "1";
                oc_Newobject18["text"] = "Image";
                oc_Newobject18["maxLength"] = "1024";
                oc_Newobject18["docking"] = "None";
                oc_Newobject18["margin"] = "0 0 0 0";
                oc_Newobject18["padding"] = "0 0 0 0";
                oc_Newobject18["anchorTop"] = "1";
                oc_Newobject18["anchorBottom"] = "1";
                oc_Newobject18["anchorLeft"] = "1";
                oc_Newobject18["anchorRight"] = "1";
                oc_Newobject18["position"] = "0 20";
                oc_Newobject18["extent"] = "525 213";
                oc_Newobject18["minExtent"] = "8 2";
                oc_Newobject18["maxExtent"] = "1920 1080";
                oc_Newobject18["horizSizing"] = "right";
                oc_Newobject18["vertSizing"] = "bottom";
                oc_Newobject18["profile"] = "GuiTabPageProfile";
                oc_Newobject18["controlFontColor"] = "0 0 0 0";
                oc_Newobject18["controlFillColor"] = "0 0 0 0";
                oc_Newobject18["backgroundColor"] = "255 255 255 255";
                oc_Newobject18["controlFontSize"] = "10";
                oc_Newobject18["visible"] = "0";
                oc_Newobject18["active"] = "1";
                oc_Newobject18["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject18["tooltip"] = "Options for the Light Rays postFX";
                oc_Newobject18["hovertime"] = "1000";
                oc_Newobject18["isContainer"] = "1";
                oc_Newobject18["alphaValue"] = "1";
                oc_Newobject18["mouseOverAlphaValue"] = "1";
                oc_Newobject18["alphaFadeTime"] = "1000";
                oc_Newobject18["moveControl"] = "0";
                oc_Newobject18["lockControl"] = "0";
                oc_Newobject18["windowSettings"] = "1";
                oc_Newobject18["alpha"] = "1";
                oc_Newobject18["mouseOverAlpha"] = "1";
                oc_Newobject18["alphaFade"] = "1";
                oc_Newobject18["contextFontColor"] = "0";
                oc_Newobject18["contextBackColor"] = "0";
                oc_Newobject18["contextFillColor"] = "0";
                oc_Newobject18["contextFontSize"] = "0";
                oc_Newobject18["hidden"] = "1";
                oc_Newobject18["editable"] = "0";
                oc_Newobject18["canSave"] = "1";
                oc_Newobject18["canSaveDynamicFields"] = "0";
                oc_Newobject18["Enabled"] = "1";

                #region GuiCheckBoxCtrl (ppOptionsEnableImageOpt)        oc_Newobject3
                ObjectCreator oc_Newobject3 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableImageOpt", typeof(ppOptionsEnableImageOpt));
                oc_Newobject3["text"] = "Enable";
                oc_Newobject3["groupNum"] = "-1";
                oc_Newobject3["buttonType"] = "ToggleButton";
                oc_Newobject3["useMouseEvents"] = "0";
                oc_Newobject3["position"] = "329 7";
                oc_Newobject3["extent"] = "53 20";
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
                oc_Newobject3["tooltip"] = "Enable/Disable the light rays postFX";
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

                oc_Newobject18["#Newobject3"] = oc_Newobject3;

                #region GuiSliderCtrl (ppOptionsImageOptDesaturation)        oc_Newobject4
                ObjectCreator oc_Newobject4 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptDesaturation", typeof(ppOptionsImageOptDesaturation));
                oc_Newobject4["range"] = "0 1";
                oc_Newobject4["ticks"] = "50";
                oc_Newobject4["snap"] = "0";
                oc_Newobject4["value"] = "0";
                oc_Newobject4["position"] = "108 61";
                oc_Newobject4["extent"] = "273 25";
                oc_Newobject4["minExtent"] = "8 2";
                oc_Newobject4["maxExtent"] = "1920 1080";
                oc_Newobject4["horizSizing"] = "right";
                oc_Newobject4["vertSizing"] = "bottom";
                oc_Newobject4["profile"] = "GuiSliderProfile";
                oc_Newobject4["controlFontColor"] = "0 0 0 0";
                oc_Newobject4["controlFillColor"] = "0 0 0 0";
                oc_Newobject4["backgroundColor"] = "255 255 255 255";
                oc_Newobject4["controlFontSize"] = "14";
                oc_Newobject4["visible"] = "1";
                oc_Newobject4["active"] = "1";
                oc_Newobject4["variable"] = "$ImageOptFX::Desaturation";
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
                oc_Newobject4["contextFillColor"] = "0";
                oc_Newobject4["contextFontSize"] = "0";
                oc_Newobject4["editable"] = "0";
                oc_Newobject4["canSave"] = "1";
                oc_Newobject4["canSaveDynamicFields"] = "0";
                oc_Newobject4["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject4"] = oc_Newobject4;

                #region GuiTextCtrl ()        oc_Newobject5
                ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject5["text"] = "Desaturation";
                oc_Newobject5["maxLength"] = "1024";
                oc_Newobject5["margin"] = "0 0 0 0";
                oc_Newobject5["padding"] = "0 0 0 0";
                oc_Newobject5["anchorTop"] = "1";
                oc_Newobject5["anchorBottom"] = "0";
                oc_Newobject5["anchorLeft"] = "1";
                oc_Newobject5["anchorRight"] = "0";
                oc_Newobject5["position"] = "17 61";
                oc_Newobject5["extent"] = "64 25";
                oc_Newobject5["minExtent"] = "8 2";
                oc_Newobject5["maxExtent"] = "1920 1080";
                oc_Newobject5["horizSizing"] = "right";
                oc_Newobject5["vertSizing"] = "bottom";
                oc_Newobject5["profile"] = "GuiTextProfile";
                oc_Newobject5["controlFontColor"] = "0 0 0 0";
                oc_Newobject5["controlFillColor"] = "0 0 0 0";
                oc_Newobject5["backgroundColor"] = "255 255 255 255";
                oc_Newobject5["controlFontSize"] = "14";
                oc_Newobject5["visible"] = "1";
                oc_Newobject5["active"] = "1";
                oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject5["hovertime"] = "1000";
                oc_Newobject5["isContainer"] = "1";
                oc_Newobject5["alphaValue"] = "1";
                oc_Newobject5["mouseOverAlphaValue"] = "1";
                oc_Newobject5["alphaFadeTime"] = "1000";
                oc_Newobject5["moveControl"] = "0";
                oc_Newobject5["lockControl"] = "0";
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

                oc_Newobject18["#Newobject5"] = oc_Newobject5;

                #region GuiSliderCtrl (ppOptionsImageOptToned)        oc_Newobject6
                ObjectCreator oc_Newobject6 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptToned", typeof(ppOptionsImageOptToned));
                oc_Newobject6["range"] = "0 1";
                oc_Newobject6["ticks"] = "50";
                oc_Newobject6["snap"] = "0";
                oc_Newobject6["value"] = "0";
                oc_Newobject6["position"] = "108 92";
                oc_Newobject6["extent"] = "273 25";
                oc_Newobject6["minExtent"] = "8 2";
                oc_Newobject6["maxExtent"] = "1920 1080";
                oc_Newobject6["horizSizing"] = "right";
                oc_Newobject6["vertSizing"] = "bottom";
                oc_Newobject6["profile"] = "GuiSliderProfile";
                oc_Newobject6["controlFontColor"] = "0 0 0 0";
                oc_Newobject6["controlFillColor"] = "0 0 0 0";
                oc_Newobject6["backgroundColor"] = "255 255 255 255";
                oc_Newobject6["controlFontSize"] = "14";
                oc_Newobject6["visible"] = "1";
                oc_Newobject6["active"] = "1";
                oc_Newobject6["variable"] = "$ImageOptFX::Toned";
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
                oc_Newobject6["contextFillColor"] = "0";
                oc_Newobject6["contextFontSize"] = "0";
                oc_Newobject6["editable"] = "0";
                oc_Newobject6["canSave"] = "1";
                oc_Newobject6["canSaveDynamicFields"] = "0";
                oc_Newobject6["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject6"] = oc_Newobject6;

                #region GuiTextCtrl ()        oc_Newobject7
                ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject7["text"] = "Toned";
                oc_Newobject7["maxLength"] = "1024";
                oc_Newobject7["margin"] = "0 0 0 0";
                oc_Newobject7["padding"] = "0 0 0 0";
                oc_Newobject7["anchorTop"] = "1";
                oc_Newobject7["anchorBottom"] = "0";
                oc_Newobject7["anchorLeft"] = "1";
                oc_Newobject7["anchorRight"] = "0";
                oc_Newobject7["position"] = "17 91";
                oc_Newobject7["extent"] = "64 25";
                oc_Newobject7["minExtent"] = "8 2";
                oc_Newobject7["maxExtent"] = "1920 1080";
                oc_Newobject7["horizSizing"] = "right";
                oc_Newobject7["vertSizing"] = "bottom";
                oc_Newobject7["profile"] = "GuiTextProfile";
                oc_Newobject7["controlFontColor"] = "0 0 0 0";
                oc_Newobject7["controlFillColor"] = "0 0 0 0";
                oc_Newobject7["backgroundColor"] = "255 255 255 255";
                oc_Newobject7["controlFontSize"] = "14";
                oc_Newobject7["visible"] = "1";
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
                oc_Newobject7["editable"] = "0";
                oc_Newobject7["canSave"] = "1";
                oc_Newobject7["canSaveDynamicFields"] = "0";
                oc_Newobject7["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject7"] = oc_Newobject7;

                #region GuiSliderCtrl (ppOptionsImageOptGamma)        oc_Newobject8
                ObjectCreator oc_Newobject8 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptGamma", typeof(ppOptionsImageOptGamma));
                oc_Newobject8["range"] = "0 1";
                oc_Newobject8["ticks"] = "50";
                oc_Newobject8["snap"] = "0";
                oc_Newobject8["value"] = "0";
                oc_Newobject8["position"] = "108 123";
                oc_Newobject8["extent"] = "273 25";
                oc_Newobject8["minExtent"] = "8 2";
                oc_Newobject8["maxExtent"] = "1920 1080";
                oc_Newobject8["horizSizing"] = "right";
                oc_Newobject8["vertSizing"] = "bottom";
                oc_Newobject8["profile"] = "GuiSliderProfile";
                oc_Newobject8["controlFontColor"] = "0 0 0 0";
                oc_Newobject8["controlFillColor"] = "0 0 0 0";
                oc_Newobject8["backgroundColor"] = "255 255 255 255";
                oc_Newobject8["controlFontSize"] = "14";
                oc_Newobject8["visible"] = "1";
                oc_Newobject8["active"] = "1";
                oc_Newobject8["variable"] = "$ImageOptFX::Gamma";
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
                oc_Newobject8["contextFillColor"] = "0";
                oc_Newobject8["contextFontSize"] = "0";
                oc_Newobject8["editable"] = "0";
                oc_Newobject8["canSave"] = "1";
                oc_Newobject8["canSaveDynamicFields"] = "0";
                oc_Newobject8["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject8"] = oc_Newobject8;

                #region GuiTextCtrl ()        oc_Newobject9
                ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject9["text"] = "Gamma";
                oc_Newobject9["maxLength"] = "1024";
                oc_Newobject9["margin"] = "0 0 0 0";
                oc_Newobject9["padding"] = "0 0 0 0";
                oc_Newobject9["anchorTop"] = "1";
                oc_Newobject9["anchorBottom"] = "0";
                oc_Newobject9["anchorLeft"] = "1";
                oc_Newobject9["anchorRight"] = "0";
                oc_Newobject9["position"] = "17 121";
                oc_Newobject9["extent"] = "64 25";
                oc_Newobject9["minExtent"] = "8 2";
                oc_Newobject9["maxExtent"] = "1920 1080";
                oc_Newobject9["horizSizing"] = "right";
                oc_Newobject9["vertSizing"] = "bottom";
                oc_Newobject9["profile"] = "GuiTextProfile";
                oc_Newobject9["controlFontColor"] = "0 0 0 0";
                oc_Newobject9["controlFillColor"] = "0 0 0 0";
                oc_Newobject9["backgroundColor"] = "255 255 255 255";
                oc_Newobject9["controlFontSize"] = "14";
                oc_Newobject9["visible"] = "1";
                oc_Newobject9["active"] = "1";
                oc_Newobject9["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject9["hovertime"] = "1000";
                oc_Newobject9["isContainer"] = "1";
                oc_Newobject9["alphaValue"] = "1";
                oc_Newobject9["mouseOverAlphaValue"] = "1";
                oc_Newobject9["alphaFadeTime"] = "1000";
                oc_Newobject9["moveControl"] = "0";
                oc_Newobject9["lockControl"] = "0";
                oc_Newobject9["windowSettings"] = "1";
                oc_Newobject9["alpha"] = "1";
                oc_Newobject9["mouseOverAlpha"] = "1";
                oc_Newobject9["alphaFade"] = "1";
                oc_Newobject9["contextFontColor"] = "0";
                oc_Newobject9["contextBackColor"] = "0";
                oc_Newobject9["contextFillColor"] = "0";
                oc_Newobject9["contextFontSize"] = "0";
                oc_Newobject9["editable"] = "0";
                oc_Newobject9["canSave"] = "1";
                oc_Newobject9["canSaveDynamicFields"] = "0";
                oc_Newobject9["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject9"] = oc_Newobject9;

                #region GuiTextCtrl ()        oc_Newobject10
                ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject10["text"] = "Red";
                oc_Newobject10["maxLength"] = "1024";
                oc_Newobject10["margin"] = "0 0 0 0";
                oc_Newobject10["padding"] = "0 0 0 0";
                oc_Newobject10["anchorTop"] = "1";
                oc_Newobject10["anchorBottom"] = "0";
                oc_Newobject10["anchorLeft"] = "1";
                oc_Newobject10["anchorRight"] = "0";
                oc_Newobject10["position"] = "17 151";
                oc_Newobject10["extent"] = "64 25";
                oc_Newobject10["minExtent"] = "8 2";
                oc_Newobject10["maxExtent"] = "1920 1080";
                oc_Newobject10["horizSizing"] = "right";
                oc_Newobject10["vertSizing"] = "bottom";
                oc_Newobject10["profile"] = "GuiTextProfile";
                oc_Newobject10["controlFontColor"] = "0 0 0 0";
                oc_Newobject10["controlFillColor"] = "0 0 0 0";
                oc_Newobject10["backgroundColor"] = "255 255 255 255";
                oc_Newobject10["controlFontSize"] = "14";
                oc_Newobject10["visible"] = "1";
                oc_Newobject10["active"] = "1";
                oc_Newobject10["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject10["hovertime"] = "1000";
                oc_Newobject10["isContainer"] = "1";
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

                oc_Newobject18["#Newobject10"] = oc_Newobject10;

                #region GuiTextCtrl ()        oc_Newobject11
                ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject11["text"] = "Green";
                oc_Newobject11["maxLength"] = "1024";
                oc_Newobject11["margin"] = "0 0 0 0";
                oc_Newobject11["padding"] = "0 0 0 0";
                oc_Newobject11["anchorTop"] = "1";
                oc_Newobject11["anchorBottom"] = "0";
                oc_Newobject11["anchorLeft"] = "1";
                oc_Newobject11["anchorRight"] = "0";
                oc_Newobject11["position"] = "175 151";
                oc_Newobject11["extent"] = "34 25";
                oc_Newobject11["minExtent"] = "8 2";
                oc_Newobject11["maxExtent"] = "1920 1080";
                oc_Newobject11["horizSizing"] = "right";
                oc_Newobject11["vertSizing"] = "bottom";
                oc_Newobject11["profile"] = "GuiTextProfile";
                oc_Newobject11["controlFontColor"] = "0 0 0 0";
                oc_Newobject11["controlFillColor"] = "0 0 0 0";
                oc_Newobject11["backgroundColor"] = "255 255 255 255";
                oc_Newobject11["controlFontSize"] = "14";
                oc_Newobject11["visible"] = "1";
                oc_Newobject11["active"] = "1";
                oc_Newobject11["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject11["hovertime"] = "1000";
                oc_Newobject11["isContainer"] = "1";
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
                oc_Newobject11["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject11"] = oc_Newobject11;

                #region GuiSliderCtrl (ppOptionsImageOptGreen)        oc_Newobject12
                ObjectCreator oc_Newobject12 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptGreen", typeof(ppOptionsImageOptGreen));
                oc_Newobject12["range"] = "0 1";
                oc_Newobject12["ticks"] = "10";
                oc_Newobject12["snap"] = "0";
                oc_Newobject12["value"] = "0";
                oc_Newobject12["position"] = "216 154";
                oc_Newobject12["extent"] = "60 25";
                oc_Newobject12["minExtent"] = "8 2";
                oc_Newobject12["maxExtent"] = "1920 1080";
                oc_Newobject12["horizSizing"] = "right";
                oc_Newobject12["vertSizing"] = "bottom";
                oc_Newobject12["profile"] = "GuiSliderProfile";
                oc_Newobject12["controlFontColor"] = "0 0 0 0";
                oc_Newobject12["controlFillColor"] = "0 0 0 0";
                oc_Newobject12["backgroundColor"] = "255 255 255 255";
                oc_Newobject12["controlFontSize"] = "14";
                oc_Newobject12["visible"] = "1";
                oc_Newobject12["active"] = "1";
                oc_Newobject12["variable"] = "$ImageOptFX::ScaleG";
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
                oc_Newobject12["contextFillColor"] = "0";
                oc_Newobject12["contextFontSize"] = "0";
                oc_Newobject12["editable"] = "0";
                oc_Newobject12["canSave"] = "1";
                oc_Newobject12["canSaveDynamicFields"] = "0";
                oc_Newobject12["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject12"] = oc_Newobject12;

                #region GuiSliderCtrl (ppOptionsImageOptRed)        oc_Newobject13
                ObjectCreator oc_Newobject13 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptRed", typeof(ppOptionsImageOptRed));
                oc_Newobject13["range"] = "0 1";
                oc_Newobject13["ticks"] = "10";
                oc_Newobject13["snap"] = "0";
                oc_Newobject13["value"] = "0";
                oc_Newobject13["position"] = "108 154";
                oc_Newobject13["extent"] = "60 25";
                oc_Newobject13["minExtent"] = "8 2";
                oc_Newobject13["maxExtent"] = "1920 1080";
                oc_Newobject13["horizSizing"] = "right";
                oc_Newobject13["vertSizing"] = "bottom";
                oc_Newobject13["profile"] = "GuiSliderProfile";
                oc_Newobject13["controlFontColor"] = "0 0 0 0";
                oc_Newobject13["controlFillColor"] = "0 0 0 0";
                oc_Newobject13["backgroundColor"] = "255 255 255 255";
                oc_Newobject13["controlFontSize"] = "14";
                oc_Newobject13["visible"] = "1";
                oc_Newobject13["active"] = "1";
                oc_Newobject13["variable"] = "$ImageOptFX::ScaleR";
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
                oc_Newobject13["contextFillColor"] = "0";
                oc_Newobject13["contextFontSize"] = "0";
                oc_Newobject13["editable"] = "0";
                oc_Newobject13["canSave"] = "1";
                oc_Newobject13["canSaveDynamicFields"] = "0";
                oc_Newobject13["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject13"] = oc_Newobject13;

                #region GuiTextCtrl ()        oc_Newobject14
                ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject14["text"] = "Sharpen";
                oc_Newobject14["maxLength"] = "1024";
                oc_Newobject14["margin"] = "0 0 0 0";
                oc_Newobject14["padding"] = "0 0 0 0";
                oc_Newobject14["anchorTop"] = "1";
                oc_Newobject14["anchorBottom"] = "0";
                oc_Newobject14["anchorLeft"] = "1";
                oc_Newobject14["anchorRight"] = "0";
                oc_Newobject14["position"] = "17 26";
                oc_Newobject14["extent"] = "64 25";
                oc_Newobject14["minExtent"] = "8 2";
                oc_Newobject14["maxExtent"] = "1920 1080";
                oc_Newobject14["horizSizing"] = "right";
                oc_Newobject14["vertSizing"] = "bottom";
                oc_Newobject14["profile"] = "GuiTextProfile";
                oc_Newobject14["controlFontColor"] = "0 0 0 0";
                oc_Newobject14["controlFillColor"] = "0 0 0 0";
                oc_Newobject14["backgroundColor"] = "255 255 255 255";
                oc_Newobject14["controlFontSize"] = "14";
                oc_Newobject14["visible"] = "1";
                oc_Newobject14["active"] = "1";
                oc_Newobject14["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject14["hovertime"] = "1000";
                oc_Newobject14["isContainer"] = "1";
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

                oc_Newobject18["#Newobject14"] = oc_Newobject14;

                #region GuiSliderCtrl (ppOptionsImageOptSharpen)        oc_Newobject15
                ObjectCreator oc_Newobject15 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptSharpen", typeof(ppOptionsImageOptSharpen));
                oc_Newobject15["range"] = "0 10";
                oc_Newobject15["ticks"] = "50";
                oc_Newobject15["snap"] = "0";
                oc_Newobject15["value"] = "0";
                oc_Newobject15["position"] = "108 31";
                oc_Newobject15["extent"] = "273 25";
                oc_Newobject15["minExtent"] = "8 2";
                oc_Newobject15["maxExtent"] = "1920 1080";
                oc_Newobject15["horizSizing"] = "right";
                oc_Newobject15["vertSizing"] = "bottom";
                oc_Newobject15["profile"] = "GuiSliderProfile";
                oc_Newobject15["controlFontColor"] = "0 0 0 0";
                oc_Newobject15["controlFillColor"] = "0 0 0 0";
                oc_Newobject15["backgroundColor"] = "255 255 255 255";
                oc_Newobject15["controlFontSize"] = "14";
                oc_Newobject15["visible"] = "1";
                oc_Newobject15["active"] = "1";
                oc_Newobject15["variable"] = "$ImageOptFX::Sharpen";
                oc_Newobject15["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject15["tooltip"] = "$ImageOptFX::Sharpen";
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
                oc_Newobject15["editable"] = "0";
                oc_Newobject15["canSave"] = "1";
                oc_Newobject15["canSaveDynamicFields"] = "0";
                oc_Newobject15["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject15"] = oc_Newobject15;

                #region GuiTextCtrl ()        oc_Newobject16
                ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject16["text"] = "Blue";
                oc_Newobject16["maxLength"] = "1024";
                oc_Newobject16["margin"] = "0 0 0 0";
                oc_Newobject16["padding"] = "0 0 0 0";
                oc_Newobject16["anchorTop"] = "1";
                oc_Newobject16["anchorBottom"] = "0";
                oc_Newobject16["anchorLeft"] = "1";
                oc_Newobject16["anchorRight"] = "0";
                oc_Newobject16["position"] = "285 151";
                oc_Newobject16["extent"] = "27 25";
                oc_Newobject16["minExtent"] = "8 2";
                oc_Newobject16["maxExtent"] = "1920 1080";
                oc_Newobject16["horizSizing"] = "right";
                oc_Newobject16["vertSizing"] = "bottom";
                oc_Newobject16["profile"] = "GuiTextProfile";
                oc_Newobject16["controlFontColor"] = "0 0 0 0";
                oc_Newobject16["controlFillColor"] = "0 0 0 0";
                oc_Newobject16["backgroundColor"] = "255 255 255 255";
                oc_Newobject16["controlFontSize"] = "14";
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
                #endregion

                oc_Newobject18["#Newobject16"] = oc_Newobject16;

                #region GuiSliderCtrl (ppOptionsImageOptBlue)        oc_Newobject17
                ObjectCreator oc_Newobject17 = new ObjectCreator("GuiSliderCtrl", "ppOptionsImageOptBlue", typeof(ppOptionsImageOptBlue));
                oc_Newobject17["range"] = "0 1";
                oc_Newobject17["ticks"] = "10";
                oc_Newobject17["snap"] = "0";
                oc_Newobject17["value"] = "0";
                oc_Newobject17["position"] = "324 154";
                oc_Newobject17["extent"] = "60 25";
                oc_Newobject17["minExtent"] = "8 2";
                oc_Newobject17["maxExtent"] = "1920 1080";
                oc_Newobject17["horizSizing"] = "right";
                oc_Newobject17["vertSizing"] = "bottom";
                oc_Newobject17["profile"] = "GuiSliderProfile";
                oc_Newobject17["controlFontColor"] = "0 0 0 0";
                oc_Newobject17["controlFillColor"] = "0 0 0 0";
                oc_Newobject17["backgroundColor"] = "255 255 255 255";
                oc_Newobject17["controlFontSize"] = "14";
                oc_Newobject17["visible"] = "1";
                oc_Newobject17["active"] = "1";
                oc_Newobject17["variable"] = "$ImageOptFX::ScaleB";
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
                oc_Newobject17["contextFillColor"] = "0";
                oc_Newobject17["contextFontSize"] = "0";
                oc_Newobject17["editable"] = "0";
                oc_Newobject17["canSave"] = "1";
                oc_Newobject17["canSaveDynamicFields"] = "0";
                oc_Newobject17["Enabled"] = "1";
                #endregion

                oc_Newobject18["#Newobject17"] = oc_Newobject17;

                #endregion

                oc_Newobject150["#Newobject18"] = oc_Newobject18;

                #region GuiTabPageCtrl (ppOptionsSSAOTab)        oc_Newobject57
                ObjectCreator oc_Newobject57 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSSAOTab");
                oc_Newobject57["fitBook"] = "1";
                oc_Newobject57["text"] = "SSAO";
                oc_Newobject57["maxLength"] = "1024";
                oc_Newobject57["docking"] = "None";
                oc_Newobject57["margin"] = "0 0 0 0";
                oc_Newobject57["padding"] = "0 0 0 0";
                oc_Newobject57["anchorTop"] = "1";
                oc_Newobject57["anchorBottom"] = "1";
                oc_Newobject57["anchorLeft"] = "1";
                oc_Newobject57["anchorRight"] = "1";
                oc_Newobject57["position"] = "0 20";
                oc_Newobject57["extent"] = "525 213";
                oc_Newobject57["minExtent"] = "8 2";
                oc_Newobject57["maxExtent"] = "1920 1080";
                oc_Newobject57["horizSizing"] = "right";
                oc_Newobject57["vertSizing"] = "bottom";
                oc_Newobject57["profile"] = "GuiTabPageProfile";
                oc_Newobject57["controlFontColor"] = "0 0 0 0";
                oc_Newobject57["controlFillColor"] = "0 0 0 0";
                oc_Newobject57["backgroundColor"] = "255 255 255 255";
                oc_Newobject57["controlFontSize"] = "10";
                oc_Newobject57["visible"] = "0";
                oc_Newobject57["active"] = "1";
                oc_Newobject57["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject57["tooltip"] = "Options for the Screen Space Ambient Occlusion postFX";
                oc_Newobject57["hovertime"] = "1000";
                oc_Newobject57["isContainer"] = "1";
                oc_Newobject57["alphaValue"] = "1";
                oc_Newobject57["mouseOverAlphaValue"] = "1";
                oc_Newobject57["alphaFadeTime"] = "1000";
                oc_Newobject57["moveControl"] = "0";
                oc_Newobject57["lockControl"] = "0";
                oc_Newobject57["windowSettings"] = "1";
                oc_Newobject57["alpha"] = "1";
                oc_Newobject57["mouseOverAlpha"] = "1";
                oc_Newobject57["alphaFade"] = "1";
                oc_Newobject57["contextFontColor"] = "0";
                oc_Newobject57["contextBackColor"] = "0";
                oc_Newobject57["contextFillColor"] = "0";
                oc_Newobject57["contextFontSize"] = "0";
                oc_Newobject57["hidden"] = "1";
                oc_Newobject57["editable"] = "0";
                oc_Newobject57["canSave"] = "1";
                oc_Newobject57["canSaveDynamicFields"] = "0";
                oc_Newobject57["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject19
                ObjectCreator oc_Newobject19 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject19["position"] = "12 30";
                oc_Newobject19["extent"] = "365 170";
                oc_Newobject19["minExtent"] = "8 2";
                oc_Newobject19["maxExtent"] = "1920 1080";
                oc_Newobject19["horizSizing"] = "right";
                oc_Newobject19["vertSizing"] = "bottom";
                oc_Newobject19["profile"] = "GuiTabBorderProfile";
                oc_Newobject19["controlFontColor"] = "0 0 0 0";
                oc_Newobject19["controlFillColor"] = "0 0 0 0";
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
                oc_Newobject19["canSaveDynamicFields"] = "1";
                oc_Newobject19["Enabled"] = "1";
                #endregion

                oc_Newobject57["#Newobject19"] = oc_Newobject19;

                #region GuiTabBookCtrl (ppOptionsSSAOOptions)        oc_Newobject55
                ObjectCreator oc_Newobject55 = new ObjectCreator("GuiTabBookCtrl", "ppOptionsSSAOOptions");
                oc_Newobject55["tabPosition"] = "Top";
                oc_Newobject55["tabMargin"] = "7";
                oc_Newobject55["minTabWidth"] = "64";
                oc_Newobject55["tabHeight"] = "20";
                oc_Newobject55["allowReorder"] = "0";
                oc_Newobject55["defaultPage"] = "-1";
                oc_Newobject55["selectedPage"] = "1";
                oc_Newobject55["frontTabPadding"] = "0";
                oc_Newobject55["margin"] = "0 0 0 0";
                oc_Newobject55["padding"] = "0 0 0 0";
                oc_Newobject55["anchorTop"] = "1";
                oc_Newobject55["anchorBottom"] = "0";
                oc_Newobject55["anchorLeft"] = "1";
                oc_Newobject55["anchorRight"] = "0";
                oc_Newobject55["position"] = "12 11";
                oc_Newobject55["extent"] = "362 185";
                oc_Newobject55["minExtent"] = "8 2";
                oc_Newobject55["maxExtent"] = "1920 1080";
                oc_Newobject55["horizSizing"] = "right";
                oc_Newobject55["vertSizing"] = "bottom";
                oc_Newobject55["profile"] = "GuiTabBookProfile";
                oc_Newobject55["controlFontColor"] = "0 0 0 0";
                oc_Newobject55["controlFillColor"] = "0 0 0 0";
                oc_Newobject55["backgroundColor"] = "255 255 255 255";
                oc_Newobject55["controlFontSize"] = "14";
                oc_Newobject55["visible"] = "1";
                oc_Newobject55["active"] = "1";
                oc_Newobject55["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject55["hovertime"] = "1000";
                oc_Newobject55["isContainer"] = "1";
                oc_Newobject55["alphaValue"] = "1";
                oc_Newobject55["mouseOverAlphaValue"] = "1";
                oc_Newobject55["alphaFadeTime"] = "1000";
                oc_Newobject55["windowSettings"] = "1";
                oc_Newobject55["alpha"] = "1";
                oc_Newobject55["mouseOverAlpha"] = "1";
                oc_Newobject55["alphaFade"] = "1";
                oc_Newobject55["contextFontColor"] = "0";
                oc_Newobject55["contextBackColor"] = "0";
                oc_Newobject55["contextFillColor"] = "0";
                oc_Newobject55["contextFontSize"] = "0";
                oc_Newobject55["editable"] = "0";
                oc_Newobject55["canSave"] = "1";
                oc_Newobject55["canSaveDynamicFields"] = "0";
                oc_Newobject55["Enabled"] = "1";

                #region GuiTabPageCtrl (ppOptionsSSAOGeneralTab)        oc_Newobject28
                ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSSAOGeneralTab");
                oc_Newobject28["fitBook"] = "1";
                oc_Newobject28["text"] = "General";
                oc_Newobject28["maxLength"] = "1024";
                oc_Newobject28["docking"] = "None";
                oc_Newobject28["margin"] = "0 0 0 0";
                oc_Newobject28["padding"] = "0 0 0 0";
                oc_Newobject28["anchorTop"] = "1";
                oc_Newobject28["anchorBottom"] = "1";
                oc_Newobject28["anchorLeft"] = "1";
                oc_Newobject28["anchorRight"] = "1";
                oc_Newobject28["position"] = "0 20";
                oc_Newobject28["extent"] = "362 165";
                oc_Newobject28["minExtent"] = "8 2";
                oc_Newobject28["maxExtent"] = "1920 1080";
                oc_Newobject28["horizSizing"] = "right";
                oc_Newobject28["vertSizing"] = "bottom";
                oc_Newobject28["profile"] = "GuiTabPageProfile";
                oc_Newobject28["controlFontColor"] = "0 0 0 0";
                oc_Newobject28["controlFillColor"] = "0 0 0 0";
                oc_Newobject28["backgroundColor"] = "255 255 255 255";
                oc_Newobject28["controlFontSize"] = "10";
                oc_Newobject28["visible"] = "0";
                oc_Newobject28["active"] = "1";
                oc_Newobject28["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject28["tooltip"] = "Contains general overall settings for the SSAO postFX";
                oc_Newobject28["hovertime"] = "1000";
                oc_Newobject28["isContainer"] = "1";
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
                oc_Newobject28["hidden"] = "1";
                oc_Newobject28["editable"] = "0";
                oc_Newobject28["canSave"] = "1";
                oc_Newobject28["canSaveDynamicFields"] = "0";
                oc_Newobject28["Enabled"] = "1";

                #region GuiTextCtrl (ppOptionsSSAOOverallStrengthLabel)        oc_Newobject20
                ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOOverallStrengthLabel");
                oc_Newobject20["text"] = "Overall Strength";
                oc_Newobject20["maxLength"] = "1024";
                oc_Newobject20["margin"] = "0 0 0 0";
                oc_Newobject20["padding"] = "0 0 0 0";
                oc_Newobject20["anchorTop"] = "1";
                oc_Newobject20["anchorBottom"] = "0";
                oc_Newobject20["anchorLeft"] = "1";
                oc_Newobject20["anchorRight"] = "0";
                oc_Newobject20["position"] = "31 57";
                oc_Newobject20["extent"] = "77 18";
                oc_Newobject20["minExtent"] = "8 2";
                oc_Newobject20["maxExtent"] = "1920 1080";
                oc_Newobject20["horizSizing"] = "right";
                oc_Newobject20["vertSizing"] = "bottom";
                oc_Newobject20["profile"] = "GuiTextProfile";
                oc_Newobject20["controlFontColor"] = "0 0 0 0";
                oc_Newobject20["controlFillColor"] = "0 0 0 0";
                oc_Newobject20["backgroundColor"] = "255 255 255 255";
                oc_Newobject20["controlFontSize"] = "14";
                oc_Newobject20["visible"] = "1";
                oc_Newobject20["active"] = "1";
                oc_Newobject20["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject20["tooltip"] = "Controls the overall strength of the Ambient Occlusion effect.";
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

                oc_Newobject28["#Newobject20"] = oc_Newobject20;

                #region GuiTextCtrl (ppOptionsSSAOBlurDepthLabel)        oc_Newobject21
                ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOBlurDepthLabel");
                oc_Newobject21["text"] = "Blur (Softness)";
                oc_Newobject21["maxLength"] = "1024";
                oc_Newobject21["margin"] = "0 0 0 0";
                oc_Newobject21["padding"] = "0 0 0 0";
                oc_Newobject21["anchorTop"] = "1";
                oc_Newobject21["anchorBottom"] = "0";
                oc_Newobject21["anchorLeft"] = "1";
                oc_Newobject21["anchorRight"] = "0";
                oc_Newobject21["position"] = "38 85";
                oc_Newobject21["extent"] = "73 18";
                oc_Newobject21["minExtent"] = "8 2";
                oc_Newobject21["maxExtent"] = "1920 1080";
                oc_Newobject21["horizSizing"] = "right";
                oc_Newobject21["vertSizing"] = "bottom";
                oc_Newobject21["profile"] = "GuiTextProfile";
                oc_Newobject21["controlFontColor"] = "0 0 0 0";
                oc_Newobject21["controlFillColor"] = "0 0 0 0";
                oc_Newobject21["backgroundColor"] = "255 255 255 255";
                oc_Newobject21["controlFontSize"] = "14";
                oc_Newobject21["visible"] = "1";
                oc_Newobject21["active"] = "1";
                oc_Newobject21["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject21["tooltip"] = "Controls the amount of softness in the SSAO, overall.";
                oc_Newobject21["hovertime"] = "1000";
                oc_Newobject21["isContainer"] = "0";
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
                #endregion

                oc_Newobject28["#Newobject21"] = oc_Newobject21;

                #region GuiTextCtrl (ppOptionsSSAOBlurNormalLabel)        oc_Newobject22
                ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOBlurNormalLabel");
                oc_Newobject22["text"] = "Blur (Normal Maps)";
                oc_Newobject22["maxLength"] = "1024";
                oc_Newobject22["margin"] = "0 0 0 0";
                oc_Newobject22["padding"] = "0 0 0 0";
                oc_Newobject22["anchorTop"] = "1";
                oc_Newobject22["anchorBottom"] = "0";
                oc_Newobject22["anchorLeft"] = "1";
                oc_Newobject22["anchorRight"] = "0";
                oc_Newobject22["position"] = "19 112";
                oc_Newobject22["extent"] = "92 18";
                oc_Newobject22["minExtent"] = "8 2";
                oc_Newobject22["maxExtent"] = "1920 1080";
                oc_Newobject22["horizSizing"] = "right";
                oc_Newobject22["vertSizing"] = "bottom";
                oc_Newobject22["profile"] = "GuiTextProfile";
                oc_Newobject22["controlFontColor"] = "0 0 0 0";
                oc_Newobject22["controlFillColor"] = "0 0 0 0";
                oc_Newobject22["backgroundColor"] = "255 255 255 255";
                oc_Newobject22["controlFontSize"] = "14";
                oc_Newobject22["visible"] = "1";
                oc_Newobject22["active"] = "1";
                oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject22["tooltip"] = "Controls the amount of softness in the SSAO, in the normal maps.";
                oc_Newobject22["hovertime"] = "1000";
                oc_Newobject22["isContainer"] = "0";
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
                #endregion

                oc_Newobject28["#Newobject22"] = oc_Newobject22;

                #region GuiPopUpMenuCtrl (ppOptionsSSAOQuality)        oc_Newobject23
                ObjectCreator oc_Newobject23 = new ObjectCreator("GuiPopUpMenuCtrl", "ppOptionsSSAOQuality",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOQuality));
                oc_Newobject23["maxPopupHeight"] = "200";
                oc_Newobject23["sbUsesNAColor"] = "0";
                oc_Newobject23["reverseTextList"] = "0";
                oc_Newobject23["bitmapBounds"] = "16 16";
                oc_Newobject23["text"] = "Low";
                oc_Newobject23["maxLength"] = "1024";
                oc_Newobject23["margin"] = "0 0 0 0";
                oc_Newobject23["padding"] = "0 0 0 0";
                oc_Newobject23["anchorTop"] = "1";
                oc_Newobject23["anchorBottom"] = "0";
                oc_Newobject23["anchorLeft"] = "1";
                oc_Newobject23["anchorRight"] = "0";
                oc_Newobject23["position"] = "120 28";
                oc_Newobject23["extent"] = "211 20";
                oc_Newobject23["minExtent"] = "8 2";
                oc_Newobject23["maxExtent"] = "1920 1080";
                oc_Newobject23["horizSizing"] = "right";
                oc_Newobject23["vertSizing"] = "bottom";
                oc_Newobject23["profile"] = "GuiPopUpMenuProfile";
                oc_Newobject23["controlFontColor"] = "0 0 0 0";
                oc_Newobject23["controlFillColor"] = "0 0 0 0";
                oc_Newobject23["backgroundColor"] = "255 255 255 255";
                oc_Newobject23["controlFontSize"] = "14";
                oc_Newobject23["visible"] = "1";
                oc_Newobject23["active"] = "1";
                oc_Newobject23["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject23["hovertime"] = "1000";
                oc_Newobject23["isContainer"] = "0";
                oc_Newobject23["alphaValue"] = "1";
                oc_Newobject23["mouseOverAlphaValue"] = "1";
                oc_Newobject23["alphaFadeTime"] = "1000";
                oc_Newobject23["moveControl"] = "0";
                oc_Newobject23["lockControl"] = "0";
                oc_Newobject23["windowSettings"] = "1";
                oc_Newobject23["alpha"] = "1";
                oc_Newobject23["mouseOverAlpha"] = "1";
                oc_Newobject23["alphaFade"] = "1";
                oc_Newobject23["contextFontColor"] = "0";
                oc_Newobject23["contextBackColor"] = "0";
                oc_Newobject23["contextFillColor"] = "0";
                oc_Newobject23["contextFontSize"] = "0";
                oc_Newobject23["editable"] = "0";
                oc_Newobject23["canSave"] = "1";
                oc_Newobject23["canSaveDynamicFields"] = "0";
                oc_Newobject23["Enabled"] = "1";
                #endregion

                oc_Newobject28["#Newobject23"] = oc_Newobject23;

                #region GuiTextCtrl (ppOptionsSSAOQualityLabel)        oc_Newobject24
                ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOQualityLabel");
                oc_Newobject24["text"] = "Quality";
                oc_Newobject24["maxLength"] = "1024";
                oc_Newobject24["margin"] = "0 0 0 0";
                oc_Newobject24["padding"] = "0 0 0 0";
                oc_Newobject24["anchorTop"] = "1";
                oc_Newobject24["anchorBottom"] = "0";
                oc_Newobject24["anchorLeft"] = "1";
                oc_Newobject24["anchorRight"] = "0";
                oc_Newobject24["position"] = "76 29";
                oc_Newobject24["extent"] = "32 18";
                oc_Newobject24["minExtent"] = "8 2";
                oc_Newobject24["maxExtent"] = "1920 1080";
                oc_Newobject24["horizSizing"] = "right";
                oc_Newobject24["vertSizing"] = "bottom";
                oc_Newobject24["profile"] = "GuiTextProfile";
                oc_Newobject24["controlFontColor"] = "0 0 0 0";
                oc_Newobject24["controlFillColor"] = "0 0 0 0";
                oc_Newobject24["backgroundColor"] = "255 255 255 255";
                oc_Newobject24["controlFontSize"] = "14";
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

                oc_Newobject28["#Newobject24"] = oc_Newobject24;

                #region GuiSliderCtrl (ppOptionsSSAOOverallStrength)        oc_Newobject25
                ObjectCreator oc_Newobject25 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOOverallStrength",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOOverallStrength));
                oc_Newobject25["range"] = "0 50";
                oc_Newobject25["ticks"] = "1000";
                oc_Newobject25["snap"] = "0";
                oc_Newobject25["value"] = "2";
                oc_Newobject25["position"] = "120 56";
                oc_Newobject25["extent"] = "211 17";
                oc_Newobject25["minExtent"] = "8 2";
                oc_Newobject25["maxExtent"] = "1920 1080";
                oc_Newobject25["horizSizing"] = "right";
                oc_Newobject25["vertSizing"] = "bottom";
                oc_Newobject25["profile"] = "GuiSliderBoxProfile";
                oc_Newobject25["controlFontColor"] = "0 0 0 0";
                oc_Newobject25["controlFillColor"] = "0 0 0 0";
                oc_Newobject25["backgroundColor"] = "255 255 255 255";
                oc_Newobject25["controlFontSize"] = "14";
                oc_Newobject25["visible"] = "1";
                oc_Newobject25["active"] = "1";
                oc_Newobject25["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject25["hovertime"] = "1000";
                oc_Newobject25["isContainer"] = "0";
                oc_Newobject25["alphaValue"] = "1";
                oc_Newobject25["mouseOverAlphaValue"] = "1";
                oc_Newobject25["alphaFadeTime"] = "1000";
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
                #endregion

                oc_Newobject28["#Newobject25"] = oc_Newobject25;

                #region GuiSliderCtrl (ppOptionsSSAOBlurDepth)        oc_Newobject26
                ObjectCreator oc_Newobject26 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOBlurDepth",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOBlurDepth));
                oc_Newobject26["range"] = "0 0.3";
                oc_Newobject26["ticks"] = "1000";
                oc_Newobject26["snap"] = "0";
                oc_Newobject26["value"] = "0.001";
                oc_Newobject26["position"] = "120 86";
                oc_Newobject26["extent"] = "211 17";
                oc_Newobject26["minExtent"] = "8 2";
                oc_Newobject26["maxExtent"] = "1920 1080";
                oc_Newobject26["horizSizing"] = "right";
                oc_Newobject26["vertSizing"] = "bottom";
                oc_Newobject26["profile"] = "GuiSliderBoxProfile";
                oc_Newobject26["controlFontColor"] = "0 0 0 0";
                oc_Newobject26["controlFillColor"] = "0 0 0 0";
                oc_Newobject26["backgroundColor"] = "255 255 255 255";
                oc_Newobject26["controlFontSize"] = "14";
                oc_Newobject26["visible"] = "1";
                oc_Newobject26["active"] = "1";
                oc_Newobject26["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject26["hovertime"] = "1000";
                oc_Newobject26["isContainer"] = "0";
                oc_Newobject26["alphaValue"] = "1";
                oc_Newobject26["mouseOverAlphaValue"] = "1";
                oc_Newobject26["alphaFadeTime"] = "1000";
                oc_Newobject26["windowSettings"] = "1";
                oc_Newobject26["alpha"] = "1";
                oc_Newobject26["mouseOverAlpha"] = "1";
                oc_Newobject26["alphaFade"] = "1";
                oc_Newobject26["contextFontColor"] = "0";
                oc_Newobject26["contextBackColor"] = "0";
                oc_Newobject26["contextFillColor"] = "0";
                oc_Newobject26["contextFontSize"] = "0";
                oc_Newobject26["editable"] = "0";
                oc_Newobject26["canSave"] = "1";
                oc_Newobject26["canSaveDynamicFields"] = "0";
                oc_Newobject26["Enabled"] = "1";
                #endregion

                oc_Newobject28["#Newobject26"] = oc_Newobject26;

                #region GuiSliderCtrl (ppOptionsSSAOBlurNormal)        oc_Newobject27
                ObjectCreator oc_Newobject27 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOBlurNormal",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOBlurNormal));
                oc_Newobject27["range"] = "0 1";
                oc_Newobject27["ticks"] = "1000";
                oc_Newobject27["snap"] = "0";
                oc_Newobject27["value"] = "0.95";
                oc_Newobject27["position"] = "119 113";
                oc_Newobject27["extent"] = "212 17";
                oc_Newobject27["minExtent"] = "8 2";
                oc_Newobject27["maxExtent"] = "1920 1080";
                oc_Newobject27["horizSizing"] = "right";
                oc_Newobject27["vertSizing"] = "bottom";
                oc_Newobject27["profile"] = "GuiSliderBoxProfile";
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

                oc_Newobject28["#Newobject27"] = oc_Newobject27;

                #endregion

                oc_Newobject55["#Newobject28"] = oc_Newobject28;

                #region GuiTabPageCtrl (ppOptionsSSAONearTab)        oc_Newobject41
                ObjectCreator oc_Newobject41 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSSAONearTab");
                oc_Newobject41["fitBook"] = "1";
                oc_Newobject41["text"] = "Near";
                oc_Newobject41["maxLength"] = "1024";
                oc_Newobject41["docking"] = "None";
                oc_Newobject41["margin"] = "0 0 0 0";
                oc_Newobject41["padding"] = "0 0 0 0";
                oc_Newobject41["anchorTop"] = "1";
                oc_Newobject41["anchorBottom"] = "1";
                oc_Newobject41["anchorLeft"] = "1";
                oc_Newobject41["anchorRight"] = "1";
                oc_Newobject41["position"] = "0 20";
                oc_Newobject41["extent"] = "362 165";
                oc_Newobject41["minExtent"] = "8 2";
                oc_Newobject41["maxExtent"] = "1920 1080";
                oc_Newobject41["horizSizing"] = "right";
                oc_Newobject41["vertSizing"] = "bottom";
                oc_Newobject41["profile"] = "GuiTabPageProfile";
                oc_Newobject41["controlFontColor"] = "0 0 0 0";
                oc_Newobject41["controlFillColor"] = "0 0 0 0";
                oc_Newobject41["backgroundColor"] = "255 255 255 255";
                oc_Newobject41["controlFontSize"] = "10";
                oc_Newobject41["visible"] = "1";
                oc_Newobject41["active"] = "1";
                oc_Newobject41["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject41["tooltip"] = "Contains settings for the near range ambient occlusion aspect of the SSAO postFX";
                oc_Newobject41["hovertime"] = "1000";
                oc_Newobject41["isContainer"] = "1";
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
                oc_Newobject41["editable"] = "0";
                oc_Newobject41["canSave"] = "1";
                oc_Newobject41["canSaveDynamicFields"] = "0";
                oc_Newobject41["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsSSAONearRadius)        oc_Newobject29
                ObjectCreator oc_Newobject29 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAONearRadius",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAONearRadius));
                oc_Newobject29["range"] = "0.001 5";
                oc_Newobject29["ticks"] = "1000";
                oc_Newobject29["snap"] = "0";
                oc_Newobject29["value"] = "0.1";
                oc_Newobject29["position"] = "122 17";
                oc_Newobject29["extent"] = "221 17";
                oc_Newobject29["minExtent"] = "8 2";
                oc_Newobject29["maxExtent"] = "1920 1080";
                oc_Newobject29["horizSizing"] = "right";
                oc_Newobject29["vertSizing"] = "bottom";
                oc_Newobject29["profile"] = "GuiSliderBoxProfile";
                oc_Newobject29["controlFontColor"] = "0 0 0 0";
                oc_Newobject29["controlFillColor"] = "0 0 0 0";
                oc_Newobject29["backgroundColor"] = "255 255 255 255";
                oc_Newobject29["controlFontSize"] = "14";
                oc_Newobject29["visible"] = "1";
                oc_Newobject29["active"] = "1";
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
                oc_Newobject29["contextFillColor"] = "0";
                oc_Newobject29["contextFontSize"] = "0";
                oc_Newobject29["editable"] = "0";
                oc_Newobject29["canSave"] = "1";
                oc_Newobject29["canSaveDynamicFields"] = "0";
                oc_Newobject29["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject29"] = oc_Newobject29;

                #region GuiSliderCtrl (ppOptionsSSAONearDepthMin)        oc_Newobject30
                ObjectCreator oc_Newobject30 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAONearDepthMin",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAONearDepthMin));
                oc_Newobject30["range"] = "0 5";
                oc_Newobject30["ticks"] = "1000";
                oc_Newobject30["snap"] = "0";
                oc_Newobject30["value"] = "0.1";
                oc_Newobject30["position"] = "122 62";
                oc_Newobject30["extent"] = "221 17";
                oc_Newobject30["minExtent"] = "8 2";
                oc_Newobject30["maxExtent"] = "1920 1080";
                oc_Newobject30["horizSizing"] = "right";
                oc_Newobject30["vertSizing"] = "bottom";
                oc_Newobject30["profile"] = "GuiSliderBoxProfile";
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
                oc_Newobject30["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject30"] = oc_Newobject30;

                #region GuiSliderCtrl (ppOptionsSSAONearStrength)        oc_Newobject31
                ObjectCreator oc_Newobject31 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAONearStrength",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAONearStrength));
                oc_Newobject31["range"] = "0 20";
                oc_Newobject31["ticks"] = "1000";
                oc_Newobject31["snap"] = "0";
                oc_Newobject31["value"] = "6";
                oc_Newobject31["position"] = "122 39";
                oc_Newobject31["extent"] = "221 17";
                oc_Newobject31["minExtent"] = "8 2";
                oc_Newobject31["maxExtent"] = "1920 1080";
                oc_Newobject31["horizSizing"] = "right";
                oc_Newobject31["vertSizing"] = "bottom";
                oc_Newobject31["profile"] = "GuiSliderBoxProfile";
                oc_Newobject31["controlFontColor"] = "0 0 0 0";
                oc_Newobject31["controlFillColor"] = "0 0 0 0";
                oc_Newobject31["backgroundColor"] = "255 255 255 255";
                oc_Newobject31["controlFontSize"] = "14";
                oc_Newobject31["visible"] = "1";
                oc_Newobject31["active"] = "1";
                oc_Newobject31["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject31["hovertime"] = "1000";
                oc_Newobject31["isContainer"] = "0";
                oc_Newobject31["alphaValue"] = "1";
                oc_Newobject31["mouseOverAlphaValue"] = "1";
                oc_Newobject31["alphaFadeTime"] = "1000";
                oc_Newobject31["windowSettings"] = "1";
                oc_Newobject31["alpha"] = "1";
                oc_Newobject31["mouseOverAlpha"] = "1";
                oc_Newobject31["alphaFade"] = "1";
                oc_Newobject31["contextFontColor"] = "0";
                oc_Newobject31["contextBackColor"] = "0";
                oc_Newobject31["contextFillColor"] = "0";
                oc_Newobject31["contextFontSize"] = "0";
                oc_Newobject31["editable"] = "0";
                oc_Newobject31["canSave"] = "1";
                oc_Newobject31["canSaveDynamicFields"] = "0";
                oc_Newobject31["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject31"] = oc_Newobject31;

                #region GuiTextCtrl (ppOptionsSSAONearRadiusLabel)        oc_Newobject32
                ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAONearRadiusLabel");
                oc_Newobject32["text"] = "Radius";
                oc_Newobject32["maxLength"] = "1024";
                oc_Newobject32["margin"] = "0 0 0 0";
                oc_Newobject32["padding"] = "0 0 0 0";
                oc_Newobject32["anchorTop"] = "1";
                oc_Newobject32["anchorBottom"] = "0";
                oc_Newobject32["anchorLeft"] = "1";
                oc_Newobject32["anchorRight"] = "0";
                oc_Newobject32["position"] = "80 16";
                oc_Newobject32["extent"] = "34 18";
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
                oc_Newobject32["tooltip"] = "Controls the near/small radius SSAO reach.";
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

                oc_Newobject41["#Newobject32"] = oc_Newobject32;

                #region GuiTextCtrl (ppOptionsSSAONearStrengthLabel)        oc_Newobject33
                ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAONearStrengthLabel");
                oc_Newobject33["text"] = "Strength";
                oc_Newobject33["maxLength"] = "1024";
                oc_Newobject33["margin"] = "0 0 0 0";
                oc_Newobject33["padding"] = "0 0 0 0";
                oc_Newobject33["anchorTop"] = "1";
                oc_Newobject33["anchorBottom"] = "0";
                oc_Newobject33["anchorLeft"] = "1";
                oc_Newobject33["anchorRight"] = "0";
                oc_Newobject33["position"] = "73 38";
                oc_Newobject33["extent"] = "41 18";
                oc_Newobject33["minExtent"] = "8 2";
                oc_Newobject33["maxExtent"] = "1920 1080";
                oc_Newobject33["horizSizing"] = "right";
                oc_Newobject33["vertSizing"] = "bottom";
                oc_Newobject33["profile"] = "GuiTextProfile";
                oc_Newobject33["controlFontColor"] = "0 0 0 0";
                oc_Newobject33["controlFillColor"] = "0 0 0 0";
                oc_Newobject33["backgroundColor"] = "255 255 255 255";
                oc_Newobject33["controlFontSize"] = "14";
                oc_Newobject33["visible"] = "1";
                oc_Newobject33["active"] = "1";
                oc_Newobject33["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject33["tooltip"] = "Controls the near/small radius SSAO strength.";
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
                oc_Newobject33["editable"] = "0";
                oc_Newobject33["canSave"] = "1";
                oc_Newobject33["canSaveDynamicFields"] = "0";
                oc_Newobject33["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject33"] = oc_Newobject33;

                #region GuiTextCtrl (ppOptionsSSAONearDepthMinLabel)        oc_Newobject34
                ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAONearDepthMinLabel");
                oc_Newobject34["text"] = "Depth Min";
                oc_Newobject34["maxLength"] = "1024";
                oc_Newobject34["margin"] = "0 0 0 0";
                oc_Newobject34["padding"] = "0 0 0 0";
                oc_Newobject34["anchorTop"] = "1";
                oc_Newobject34["anchorBottom"] = "0";
                oc_Newobject34["anchorLeft"] = "1";
                oc_Newobject34["anchorRight"] = "0";
                oc_Newobject34["position"] = "66 61";
                oc_Newobject34["extent"] = "48 18";
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
                oc_Newobject34["tooltip"] = "Controls the near/small radius SSAO minimum depth value.";
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

                oc_Newobject41["#Newobject34"] = oc_Newobject34;

                #region GuiTextCtrl (ppOptionsSSAONearDepthMaxLabel)        oc_Newobject35
                ObjectCreator oc_Newobject35 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAONearDepthMaxLabel");
                oc_Newobject35["text"] = "Depth Max";
                oc_Newobject35["maxLength"] = "1024";
                oc_Newobject35["margin"] = "0 0 0 0";
                oc_Newobject35["padding"] = "0 0 0 0";
                oc_Newobject35["anchorTop"] = "1";
                oc_Newobject35["anchorBottom"] = "0";
                oc_Newobject35["anchorLeft"] = "1";
                oc_Newobject35["anchorRight"] = "0";
                oc_Newobject35["position"] = "62 85";
                oc_Newobject35["extent"] = "52 18";
                oc_Newobject35["minExtent"] = "8 2";
                oc_Newobject35["maxExtent"] = "1920 1080";
                oc_Newobject35["horizSizing"] = "right";
                oc_Newobject35["vertSizing"] = "bottom";
                oc_Newobject35["profile"] = "GuiTextProfile";
                oc_Newobject35["controlFontColor"] = "0 0 0 0";
                oc_Newobject35["controlFillColor"] = "0 0 0 0";
                oc_Newobject35["backgroundColor"] = "255 255 255 255";
                oc_Newobject35["controlFontSize"] = "14";
                oc_Newobject35["visible"] = "1";
                oc_Newobject35["active"] = "1";
                oc_Newobject35["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject35["tooltip"] = "Controls the near/small radius SSAO maximum depth value.";
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
                oc_Newobject35["editable"] = "0";
                oc_Newobject35["canSave"] = "1";
                oc_Newobject35["canSaveDynamicFields"] = "0";
                oc_Newobject35["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject35"] = oc_Newobject35;

                #region GuiSliderCtrl (ppOptionsSSAONearDepthMax)        oc_Newobject36
                ObjectCreator oc_Newobject36 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAONearDepthMax",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAONearDepthMax));
                oc_Newobject36["range"] = "0 50";
                oc_Newobject36["ticks"] = "1000";
                oc_Newobject36["snap"] = "0";
                oc_Newobject36["value"] = "1";
                oc_Newobject36["position"] = "122 86";
                oc_Newobject36["extent"] = "221 17";
                oc_Newobject36["minExtent"] = "8 2";
                oc_Newobject36["maxExtent"] = "1920 1080";
                oc_Newobject36["horizSizing"] = "right";
                oc_Newobject36["vertSizing"] = "bottom";
                oc_Newobject36["profile"] = "GuiSliderBoxProfile";
                oc_Newobject36["controlFontColor"] = "0 0 0 0";
                oc_Newobject36["controlFillColor"] = "0 0 0 0";
                oc_Newobject36["backgroundColor"] = "255 255 255 255";
                oc_Newobject36["controlFontSize"] = "14";
                oc_Newobject36["visible"] = "1";
                oc_Newobject36["active"] = "1";
                oc_Newobject36["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject36["hovertime"] = "1000";
                oc_Newobject36["isContainer"] = "0";
                oc_Newobject36["alphaValue"] = "1";
                oc_Newobject36["mouseOverAlphaValue"] = "1";
                oc_Newobject36["alphaFadeTime"] = "1000";
                oc_Newobject36["windowSettings"] = "1";
                oc_Newobject36["alpha"] = "1";
                oc_Newobject36["mouseOverAlpha"] = "1";
                oc_Newobject36["alphaFade"] = "1";
                oc_Newobject36["contextFontColor"] = "0";
                oc_Newobject36["contextBackColor"] = "0";
                oc_Newobject36["contextFillColor"] = "0";
                oc_Newobject36["contextFontSize"] = "0";
                oc_Newobject36["editable"] = "0";
                oc_Newobject36["canSave"] = "1";
                oc_Newobject36["canSaveDynamicFields"] = "0";
                oc_Newobject36["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject36"] = oc_Newobject36;

                #region GuiSliderCtrl (ppOptionsSSAONearToleranceNormal)        oc_Newobject37
                ObjectCreator oc_Newobject37 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAONearToleranceNormal",
                typeof(
                    WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAONearToleranceNormal));
                oc_Newobject37["range"] = "0 2";
                oc_Newobject37["ticks"] = "1000";
                oc_Newobject37["snap"] = "0";
                oc_Newobject37["value"] = "0";
                oc_Newobject37["position"] = "122 133";
                oc_Newobject37["extent"] = "103 17";
                oc_Newobject37["minExtent"] = "8 2";
                oc_Newobject37["maxExtent"] = "1920 1080";
                oc_Newobject37["horizSizing"] = "right";
                oc_Newobject37["vertSizing"] = "bottom";
                oc_Newobject37["profile"] = "GuiSliderBoxProfile";
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

                oc_Newobject41["#Newobject37"] = oc_Newobject37;

                #region GuiSliderCtrl (ppOptionsSSAONearTolerancePower)        oc_Newobject38
                ObjectCreator oc_Newobject38 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAONearTolerancePower",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAONearTolerancePower
                    ));
                oc_Newobject38["range"] = "0 2";
                oc_Newobject38["ticks"] = "1000";
                oc_Newobject38["snap"] = "0";
                oc_Newobject38["value"] = "1";
                oc_Newobject38["position"] = "246 133";
                oc_Newobject38["extent"] = "97 17";
                oc_Newobject38["minExtent"] = "8 2";
                oc_Newobject38["maxExtent"] = "1920 1080";
                oc_Newobject38["horizSizing"] = "right";
                oc_Newobject38["vertSizing"] = "bottom";
                oc_Newobject38["profile"] = "GuiSliderBoxProfile";
                oc_Newobject38["controlFontColor"] = "0 0 0 0";
                oc_Newobject38["controlFillColor"] = "0 0 0 0";
                oc_Newobject38["backgroundColor"] = "255 255 255 255";
                oc_Newobject38["controlFontSize"] = "14";
                oc_Newobject38["visible"] = "1";
                oc_Newobject38["active"] = "1";
                oc_Newobject38["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject38["hovertime"] = "1000";
                oc_Newobject38["isContainer"] = "0";
                oc_Newobject38["alphaValue"] = "1";
                oc_Newobject38["mouseOverAlphaValue"] = "1";
                oc_Newobject38["alphaFadeTime"] = "1000";
                oc_Newobject38["windowSettings"] = "1";
                oc_Newobject38["alpha"] = "1";
                oc_Newobject38["mouseOverAlpha"] = "1";
                oc_Newobject38["alphaFade"] = "1";
                oc_Newobject38["contextFontColor"] = "0";
                oc_Newobject38["contextBackColor"] = "0";
                oc_Newobject38["contextFillColor"] = "0";
                oc_Newobject38["contextFontSize"] = "0";
                oc_Newobject38["editable"] = "0";
                oc_Newobject38["canSave"] = "1";
                oc_Newobject38["canSaveDynamicFields"] = "0";
                oc_Newobject38["Enabled"] = "1";
                #endregion

                oc_Newobject41["#Newobject38"] = oc_Newobject38;

                #region GuiTextCtrl (ppOptionsSSAONearToleranceLabel2)        oc_Newobject39
                ObjectCreator oc_Newobject39 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAONearToleranceLabel2");
                oc_Newobject39["text"] = "Tolerance / Power";
                oc_Newobject39["maxLength"] = "1024";
                oc_Newobject39["margin"] = "0 0 0 0";
                oc_Newobject39["padding"] = "0 0 0 0";
                oc_Newobject39["anchorTop"] = "1";
                oc_Newobject39["anchorBottom"] = "0";
                oc_Newobject39["anchorLeft"] = "1";
                oc_Newobject39["anchorRight"] = "0";
                oc_Newobject39["position"] = "24 132";
                oc_Newobject39["extent"] = "92 18";
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

                oc_Newobject41["#Newobject39"] = oc_Newobject39;

                #region GuiTextCtrl (ppOptionsSSAONearToleranceLabel1)        oc_Newobject40
                ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAONearToleranceLabel1");
                oc_Newobject40["text"] = "Normal Maps : ";
                oc_Newobject40["maxLength"] = "1024";
                oc_Newobject40["margin"] = "0 0 0 0";
                oc_Newobject40["padding"] = "0 0 0 0";
                oc_Newobject40["anchorTop"] = "1";
                oc_Newobject40["anchorBottom"] = "0";
                oc_Newobject40["anchorLeft"] = "1";
                oc_Newobject40["anchorRight"] = "0";
                oc_Newobject40["position"] = "19 113";
                oc_Newobject40["extent"] = "71 18";
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

                oc_Newobject41["#Newobject40"] = oc_Newobject40;

                #endregion

                oc_Newobject55["#Newobject41"] = oc_Newobject41;

                #region GuiTabPageCtrl (ppOptionsSSAOFarTab)        oc_Newobject54
                ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSSAOFarTab");
                oc_Newobject54["fitBook"] = "1";
                oc_Newobject54["text"] = "Far";
                oc_Newobject54["maxLength"] = "1024";
                oc_Newobject54["docking"] = "None";
                oc_Newobject54["margin"] = "0 0 0 0";
                oc_Newobject54["padding"] = "0 0 0 0";
                oc_Newobject54["anchorTop"] = "1";
                oc_Newobject54["anchorBottom"] = "1";
                oc_Newobject54["anchorLeft"] = "1";
                oc_Newobject54["anchorRight"] = "1";
                oc_Newobject54["position"] = "0 20";
                oc_Newobject54["extent"] = "362 165";
                oc_Newobject54["minExtent"] = "8 2";
                oc_Newobject54["maxExtent"] = "1920 1080";
                oc_Newobject54["horizSizing"] = "right";
                oc_Newobject54["vertSizing"] = "bottom";
                oc_Newobject54["profile"] = "GuiTabPageProfile";
                oc_Newobject54["controlFontColor"] = "0 0 0 0";
                oc_Newobject54["controlFillColor"] = "0 0 0 0";
                oc_Newobject54["backgroundColor"] = "255 255 255 255";
                oc_Newobject54["controlFontSize"] = "10";
                oc_Newobject54["visible"] = "0";
                oc_Newobject54["active"] = "1";
                oc_Newobject54["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject54["tooltip"] = "Contains settings for the far range ambient occlusion aspect of the SSAO postFX";
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
                oc_Newobject54["hidden"] = "1";
                oc_Newobject54["editable"] = "0";
                oc_Newobject54["canSave"] = "1";
                oc_Newobject54["canSaveDynamicFields"] = "0";
                oc_Newobject54["Enabled"] = "1";

                #region GuiTextCtrl (ppOptionsSSAOFarRadiusLabel)        oc_Newobject42
                ObjectCreator oc_Newobject42 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOFarRadiusLabel");
                oc_Newobject42["text"] = "Radius";
                oc_Newobject42["maxLength"] = "1024";
                oc_Newobject42["margin"] = "0 0 0 0";
                oc_Newobject42["padding"] = "0 0 0 0";
                oc_Newobject42["anchorTop"] = "1";
                oc_Newobject42["anchorBottom"] = "0";
                oc_Newobject42["anchorLeft"] = "1";
                oc_Newobject42["anchorRight"] = "0";
                oc_Newobject42["position"] = "80 16";
                oc_Newobject42["extent"] = "34 18";
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
                oc_Newobject42["tooltip"] = "Controls the far/large radius SSAO reach.";
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

                oc_Newobject54["#Newobject42"] = oc_Newobject42;

                #region GuiSliderCtrl (ppOptionsSSAOFarRadius)        oc_Newobject43
                ObjectCreator oc_Newobject43 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOFarRadius",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOFarRadius));
                oc_Newobject43["range"] = "0.001 5";
                oc_Newobject43["ticks"] = "1000";
                oc_Newobject43["snap"] = "0";
                oc_Newobject43["value"] = "1";
                oc_Newobject43["position"] = "122 17";
                oc_Newobject43["extent"] = "221 17";
                oc_Newobject43["minExtent"] = "8 2";
                oc_Newobject43["maxExtent"] = "1920 1080";
                oc_Newobject43["horizSizing"] = "right";
                oc_Newobject43["vertSizing"] = "bottom";
                oc_Newobject43["profile"] = "GuiSliderBoxProfile";
                oc_Newobject43["controlFontColor"] = "0 0 0 0";
                oc_Newobject43["controlFillColor"] = "0 0 0 0";
                oc_Newobject43["backgroundColor"] = "255 255 255 255";
                oc_Newobject43["controlFontSize"] = "14";
                oc_Newobject43["visible"] = "1";
                oc_Newobject43["active"] = "1";
                oc_Newobject43["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject43["hovertime"] = "1000";
                oc_Newobject43["isContainer"] = "0";
                oc_Newobject43["alphaValue"] = "1";
                oc_Newobject43["mouseOverAlphaValue"] = "1";
                oc_Newobject43["alphaFadeTime"] = "1000";
                oc_Newobject43["windowSettings"] = "1";
                oc_Newobject43["alpha"] = "1";
                oc_Newobject43["mouseOverAlpha"] = "1";
                oc_Newobject43["alphaFade"] = "1";
                oc_Newobject43["contextFontColor"] = "0";
                oc_Newobject43["contextBackColor"] = "0";
                oc_Newobject43["contextFillColor"] = "0";
                oc_Newobject43["contextFontSize"] = "0";
                oc_Newobject43["editable"] = "0";
                oc_Newobject43["canSave"] = "1";
                oc_Newobject43["canSaveDynamicFields"] = "0";
                oc_Newobject43["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject43"] = oc_Newobject43;

                #region GuiTextCtrl (ppOptionsSSAOFarStrengthLabel)        oc_Newobject44
                ObjectCreator oc_Newobject44 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOFarStrengthLabel");
                oc_Newobject44["text"] = "Strength";
                oc_Newobject44["maxLength"] = "1024";
                oc_Newobject44["margin"] = "0 0 0 0";
                oc_Newobject44["padding"] = "0 0 0 0";
                oc_Newobject44["anchorTop"] = "1";
                oc_Newobject44["anchorBottom"] = "0";
                oc_Newobject44["anchorLeft"] = "1";
                oc_Newobject44["anchorRight"] = "0";
                oc_Newobject44["position"] = "73 38";
                oc_Newobject44["extent"] = "41 18";
                oc_Newobject44["minExtent"] = "8 2";
                oc_Newobject44["maxExtent"] = "1920 1080";
                oc_Newobject44["horizSizing"] = "right";
                oc_Newobject44["vertSizing"] = "bottom";
                oc_Newobject44["profile"] = "GuiTextProfile";
                oc_Newobject44["controlFontColor"] = "0 0 0 0";
                oc_Newobject44["controlFillColor"] = "0 0 0 0";
                oc_Newobject44["backgroundColor"] = "255 255 255 255";
                oc_Newobject44["controlFontSize"] = "14";
                oc_Newobject44["visible"] = "1";
                oc_Newobject44["active"] = "1";
                oc_Newobject44["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject44["tooltip"] = "Controls the far/large radius SSAO strength.";
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
                oc_Newobject44["editable"] = "0";
                oc_Newobject44["canSave"] = "1";
                oc_Newobject44["canSaveDynamicFields"] = "0";
                oc_Newobject44["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject44"] = oc_Newobject44;

                #region GuiSliderCtrl (ppOptionsSSAOFarStrength)        oc_Newobject45
                ObjectCreator oc_Newobject45 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOFarStrength",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOFarStrength));
                oc_Newobject45["range"] = "0 20";
                oc_Newobject45["ticks"] = "1000";
                oc_Newobject45["snap"] = "0";
                oc_Newobject45["value"] = "10";
                oc_Newobject45["position"] = "122 39";
                oc_Newobject45["extent"] = "221 17";
                oc_Newobject45["minExtent"] = "8 2";
                oc_Newobject45["maxExtent"] = "1920 1080";
                oc_Newobject45["horizSizing"] = "right";
                oc_Newobject45["vertSizing"] = "bottom";
                oc_Newobject45["profile"] = "GuiSliderBoxProfile";
                oc_Newobject45["controlFontColor"] = "0 0 0 0";
                oc_Newobject45["controlFillColor"] = "0 0 0 0";
                oc_Newobject45["backgroundColor"] = "255 255 255 255";
                oc_Newobject45["controlFontSize"] = "14";
                oc_Newobject45["visible"] = "1";
                oc_Newobject45["active"] = "1";
                oc_Newobject45["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject45["hovertime"] = "1000";
                oc_Newobject45["isContainer"] = "0";
                oc_Newobject45["alphaValue"] = "1";
                oc_Newobject45["mouseOverAlphaValue"] = "1";
                oc_Newobject45["alphaFadeTime"] = "1000";
                oc_Newobject45["windowSettings"] = "1";
                oc_Newobject45["alpha"] = "1";
                oc_Newobject45["mouseOverAlpha"] = "1";
                oc_Newobject45["alphaFade"] = "1";
                oc_Newobject45["contextFontColor"] = "0";
                oc_Newobject45["contextBackColor"] = "0";
                oc_Newobject45["contextFillColor"] = "0";
                oc_Newobject45["contextFontSize"] = "0";
                oc_Newobject45["editable"] = "0";
                oc_Newobject45["canSave"] = "1";
                oc_Newobject45["canSaveDynamicFields"] = "0";
                oc_Newobject45["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject45"] = oc_Newobject45;

                #region GuiTextCtrl (ppOptionsSSAOFarDepthMinLabel)        oc_Newobject46
                ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOFarDepthMinLabel");
                oc_Newobject46["text"] = "Depth Min";
                oc_Newobject46["maxLength"] = "1024";
                oc_Newobject46["margin"] = "0 0 0 0";
                oc_Newobject46["padding"] = "0 0 0 0";
                oc_Newobject46["anchorTop"] = "1";
                oc_Newobject46["anchorBottom"] = "0";
                oc_Newobject46["anchorLeft"] = "1";
                oc_Newobject46["anchorRight"] = "0";
                oc_Newobject46["position"] = "66 61";
                oc_Newobject46["extent"] = "48 18";
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
                oc_Newobject46["tooltip"] = "Controls the far/large radius SSAO minimum depth.";
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

                oc_Newobject54["#Newobject46"] = oc_Newobject46;

                #region GuiSliderCtrl (ppOptionsSSAOFarDepthMin)        oc_Newobject47
                ObjectCreator oc_Newobject47 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOFarDepthMin",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOFarDepthMin));
                oc_Newobject47["range"] = "0 5";
                oc_Newobject47["ticks"] = "1000";
                oc_Newobject47["snap"] = "0";
                oc_Newobject47["value"] = "0.2";
                oc_Newobject47["position"] = "122 62";
                oc_Newobject47["extent"] = "221 17";
                oc_Newobject47["minExtent"] = "8 2";
                oc_Newobject47["maxExtent"] = "1920 1080";
                oc_Newobject47["horizSizing"] = "right";
                oc_Newobject47["vertSizing"] = "bottom";
                oc_Newobject47["profile"] = "GuiSliderBoxProfile";
                oc_Newobject47["controlFontColor"] = "0 0 0 0";
                oc_Newobject47["controlFillColor"] = "0 0 0 0";
                oc_Newobject47["backgroundColor"] = "255 255 255 255";
                oc_Newobject47["controlFontSize"] = "14";
                oc_Newobject47["visible"] = "1";
                oc_Newobject47["active"] = "1";
                oc_Newobject47["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject47["hovertime"] = "1000";
                oc_Newobject47["isContainer"] = "0";
                oc_Newobject47["alphaValue"] = "1";
                oc_Newobject47["mouseOverAlphaValue"] = "1";
                oc_Newobject47["alphaFadeTime"] = "1000";
                oc_Newobject47["windowSettings"] = "1";
                oc_Newobject47["alpha"] = "1";
                oc_Newobject47["mouseOverAlpha"] = "1";
                oc_Newobject47["alphaFade"] = "1";
                oc_Newobject47["contextFontColor"] = "0";
                oc_Newobject47["contextBackColor"] = "0";
                oc_Newobject47["contextFillColor"] = "0";
                oc_Newobject47["contextFontSize"] = "0";
                oc_Newobject47["editable"] = "0";
                oc_Newobject47["canSave"] = "1";
                oc_Newobject47["canSaveDynamicFields"] = "0";
                oc_Newobject47["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject47"] = oc_Newobject47;

                #region GuiTextCtrl (ppOptionsSSAOFarDepthMaxLabel)        oc_Newobject48
                ObjectCreator oc_Newobject48 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOFarDepthMaxLabel");
                oc_Newobject48["text"] = "Depth Max";
                oc_Newobject48["maxLength"] = "1024";
                oc_Newobject48["margin"] = "0 0 0 0";
                oc_Newobject48["padding"] = "0 0 0 0";
                oc_Newobject48["anchorTop"] = "1";
                oc_Newobject48["anchorBottom"] = "0";
                oc_Newobject48["anchorLeft"] = "1";
                oc_Newobject48["anchorRight"] = "0";
                oc_Newobject48["position"] = "62 85";
                oc_Newobject48["extent"] = "52 18";
                oc_Newobject48["minExtent"] = "8 2";
                oc_Newobject48["maxExtent"] = "1920 1080";
                oc_Newobject48["horizSizing"] = "right";
                oc_Newobject48["vertSizing"] = "bottom";
                oc_Newobject48["profile"] = "GuiTextProfile";
                oc_Newobject48["controlFontColor"] = "0 0 0 0";
                oc_Newobject48["controlFillColor"] = "0 0 0 0";
                oc_Newobject48["backgroundColor"] = "255 255 255 255";
                oc_Newobject48["controlFontSize"] = "14";
                oc_Newobject48["visible"] = "1";
                oc_Newobject48["active"] = "1";
                oc_Newobject48["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject48["tooltip"] = "Controls the far/large radius SSAO maximum.";
                oc_Newobject48["hovertime"] = "1000";
                oc_Newobject48["isContainer"] = "0";
                oc_Newobject48["alphaValue"] = "1";
                oc_Newobject48["mouseOverAlphaValue"] = "1";
                oc_Newobject48["alphaFadeTime"] = "1000";
                oc_Newobject48["moveControl"] = "0";
                oc_Newobject48["lockControl"] = "0";
                oc_Newobject48["windowSettings"] = "1";
                oc_Newobject48["alpha"] = "1";
                oc_Newobject48["mouseOverAlpha"] = "1";
                oc_Newobject48["alphaFade"] = "1";
                oc_Newobject48["contextFontColor"] = "0";
                oc_Newobject48["contextBackColor"] = "0";
                oc_Newobject48["contextFillColor"] = "0";
                oc_Newobject48["contextFontSize"] = "0";
                oc_Newobject48["editable"] = "0";
                oc_Newobject48["canSave"] = "1";
                oc_Newobject48["canSaveDynamicFields"] = "0";
                oc_Newobject48["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject48"] = oc_Newobject48;

                #region GuiSliderCtrl (ppOptionsSSAOFarDepthMax)        oc_Newobject49
                ObjectCreator oc_Newobject49 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOFarDepthMax",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOFarDepthMax));
                oc_Newobject49["range"] = "0 5";
                oc_Newobject49["ticks"] = "1000";
                oc_Newobject49["snap"] = "0";
                oc_Newobject49["value"] = "2";
                oc_Newobject49["position"] = "122 86";
                oc_Newobject49["extent"] = "221 17";
                oc_Newobject49["minExtent"] = "8 2";
                oc_Newobject49["maxExtent"] = "1920 1080";
                oc_Newobject49["horizSizing"] = "right";
                oc_Newobject49["vertSizing"] = "bottom";
                oc_Newobject49["profile"] = "GuiSliderBoxProfile";
                oc_Newobject49["controlFontColor"] = "0 0 0 0";
                oc_Newobject49["controlFillColor"] = "0 0 0 0";
                oc_Newobject49["backgroundColor"] = "255 255 255 255";
                oc_Newobject49["controlFontSize"] = "14";
                oc_Newobject49["visible"] = "1";
                oc_Newobject49["active"] = "1";
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
                oc_Newobject49["contextFillColor"] = "0";
                oc_Newobject49["contextFontSize"] = "0";
                oc_Newobject49["editable"] = "0";
                oc_Newobject49["canSave"] = "1";
                oc_Newobject49["canSaveDynamicFields"] = "0";
                oc_Newobject49["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject49"] = oc_Newobject49;

                #region GuiTextCtrl (ppOptionsSSAOFarToleranceLabel1)        oc_Newobject50
                ObjectCreator oc_Newobject50 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAOFarToleranceLabel1");
                oc_Newobject50["text"] = "Normal Maps :";
                oc_Newobject50["maxLength"] = "1024";
                oc_Newobject50["margin"] = "0 0 0 0";
                oc_Newobject50["padding"] = "0 0 0 0";
                oc_Newobject50["anchorTop"] = "1";
                oc_Newobject50["anchorBottom"] = "0";
                oc_Newobject50["anchorLeft"] = "1";
                oc_Newobject50["anchorRight"] = "0";
                oc_Newobject50["position"] = "6 113";
                oc_Newobject50["extent"] = "72 18";
                oc_Newobject50["minExtent"] = "8 2";
                oc_Newobject50["maxExtent"] = "1920 1080";
                oc_Newobject50["horizSizing"] = "right";
                oc_Newobject50["vertSizing"] = "bottom";
                oc_Newobject50["profile"] = "GuiTextProfile";
                oc_Newobject50["controlFontColor"] = "0 0 0 0";
                oc_Newobject50["controlFillColor"] = "0 0 0 0";
                oc_Newobject50["backgroundColor"] = "255 255 255 255";
                oc_Newobject50["controlFontSize"] = "14";
                oc_Newobject50["visible"] = "1";
                oc_Newobject50["active"] = "1";
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
                oc_Newobject50["editable"] = "0";
                oc_Newobject50["canSave"] = "1";
                oc_Newobject50["canSaveDynamicFields"] = "0";
                oc_Newobject50["Enabled"] = "1";
                #endregion

                oc_Newobject54["#Newobject50"] = oc_Newobject50;

                #region GuiTextCtrl ()        oc_Newobject51
                ObjectCreator oc_Newobject51 = new ObjectCreator("GuiTextCtrl", "");
                oc_Newobject51["text"] = "Tolerance / Power";
                oc_Newobject51["maxLength"] = "1024";
                oc_Newobject51["margin"] = "0 0 0 0";
                oc_Newobject51["padding"] = "0 0 0 0";
                oc_Newobject51["anchorTop"] = "1";
                oc_Newobject51["anchorBottom"] = "0";
                oc_Newobject51["anchorLeft"] = "1";
                oc_Newobject51["anchorRight"] = "0";
                oc_Newobject51["position"] = "24 132";
                oc_Newobject51["extent"] = "90 18";
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

                oc_Newobject54["#Newobject51"] = oc_Newobject51;

                #region GuiSliderCtrl (ppOptionsSSAOFarToleranceNormal)        oc_Newobject52
                ObjectCreator oc_Newobject52 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOFarToleranceNormal",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOFarToleranceNormal)
                    );
                oc_Newobject52["range"] = "0 2";
                oc_Newobject52["ticks"] = "1000";
                oc_Newobject52["snap"] = "0";
                oc_Newobject52["value"] = "0";
                oc_Newobject52["position"] = "122 133";
                oc_Newobject52["extent"] = "100 17";
                oc_Newobject52["minExtent"] = "8 2";
                oc_Newobject52["maxExtent"] = "1920 1080";
                oc_Newobject52["horizSizing"] = "right";
                oc_Newobject52["vertSizing"] = "bottom";
                oc_Newobject52["profile"] = "GuiSliderBoxProfile";
                oc_Newobject52["controlFontColor"] = "0 0 0 0";
                oc_Newobject52["controlFillColor"] = "0 0 0 0";
                oc_Newobject52["backgroundColor"] = "255 255 255 255";
                oc_Newobject52["controlFontSize"] = "14";
                oc_Newobject52["visible"] = "1";
                oc_Newobject52["active"] = "1";
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

                #region GuiSliderCtrl (ppOptionsSSAOFarTolerancePower)        oc_Newobject53
                ObjectCreator oc_Newobject53 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAOFarTolerancePower",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsSSAOFarTolerancePower));
                oc_Newobject53["range"] = "0 2";
                oc_Newobject53["ticks"] = "1000";
                oc_Newobject53["snap"] = "0";
                oc_Newobject53["value"] = "2";
                oc_Newobject53["position"] = "239 133";
                oc_Newobject53["extent"] = "104 17";
                oc_Newobject53["minExtent"] = "8 2";
                oc_Newobject53["maxExtent"] = "1920 1080";
                oc_Newobject53["horizSizing"] = "right";
                oc_Newobject53["vertSizing"] = "bottom";
                oc_Newobject53["profile"] = "GuiSliderBoxProfile";
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

                oc_Newobject55["#Newobject54"] = oc_Newobject54;

                #endregion

                oc_Newobject57["#Newobject55"] = oc_Newobject55;

                #region GuiCheckBoxCtrl (ppOptionsEnableSSAO)        oc_Newobject56
                ObjectCreator oc_Newobject56 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableSSAO",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsEnableSSAO));
                oc_Newobject56["text"] = "Enable";
                oc_Newobject56["groupNum"] = "-1";
                oc_Newobject56["buttonType"] = "ToggleButton";
                oc_Newobject56["useMouseEvents"] = "0";
                oc_Newobject56["position"] = "329 7";
                oc_Newobject56["extent"] = "53 20";
                oc_Newobject56["minExtent"] = "8 2";
                oc_Newobject56["maxExtent"] = "1920 1080";
                oc_Newobject56["horizSizing"] = "right";
                oc_Newobject56["vertSizing"] = "bottom";
                oc_Newobject56["profile"] = "GuiCheckBoxProfile";
                oc_Newobject56["controlFontColor"] = "0 0 0 0";
                oc_Newobject56["backgroundColor"] = "255 255 255 255";
                oc_Newobject56["controlFontSize"] = "14";
                oc_Newobject56["visible"] = "1";
                oc_Newobject56["active"] = "1";
                oc_Newobject56["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject56["tooltip"] = "Enable/Disable the SSAO postFX";
                oc_Newobject56["hovertime"] = "1000";
                oc_Newobject56["isContainer"] = "0";
                oc_Newobject56["alphaValue"] = "1";
                oc_Newobject56["mouseOverAlphaValue"] = "1";
                oc_Newobject56["alphaFadeTime"] = "1000";
                oc_Newobject56["windowSettings"] = "1";
                oc_Newobject56["alpha"] = "1";
                oc_Newobject56["mouseOverAlpha"] = "1";
                oc_Newobject56["alphaFade"] = "1";
                oc_Newobject56["contextFontColor"] = "0";
                oc_Newobject56["contextBackColor"] = "0";
                oc_Newobject56["contextFontSize"] = "0";
                oc_Newobject56["editable"] = "0";
                oc_Newobject56["canSave"] = "1";
                oc_Newobject56["canSaveDynamicFields"] = "0";
                oc_Newobject56["Enabled"] = "1";
                #endregion

                oc_Newobject57["#Newobject56"] = oc_Newobject56;

                #endregion

                oc_Newobject150["#Newobject57"] = oc_Newobject57;

                #region GuiTabPageCtrl (ppOptionsSSAO2Tab)        oc_Newobject68
                ObjectCreator oc_Newobject68 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSSAO2Tab");
                oc_Newobject68["fitBook"] = "1";
                oc_Newobject68["text"] = "SSAO 2";
                oc_Newobject68["maxLength"] = "1024";
                oc_Newobject68["margin"] = "0 0 0 0";
                oc_Newobject68["padding"] = "0 0 0 0";
                oc_Newobject68["anchorTop"] = "1";
                oc_Newobject68["anchorBottom"] = "0";
                oc_Newobject68["anchorLeft"] = "1";
                oc_Newobject68["anchorRight"] = "0";
                oc_Newobject68["position"] = "0 20";
                oc_Newobject68["extent"] = "525 213";
                oc_Newobject68["minExtent"] = "8 2";
                oc_Newobject68["maxExtent"] = "1920 1080";
                oc_Newobject68["horizSizing"] = "right";
                oc_Newobject68["vertSizing"] = "bottom";
                oc_Newobject68["profile"] = "GuiTabPageProfile";
                oc_Newobject68["controlFontColor"] = "0 0 0 0";
                oc_Newobject68["controlFillColor"] = "0 0 0 0";
                oc_Newobject68["backgroundColor"] = "255 255 255 255";
                oc_Newobject68["controlFontSize"] = "10";
                oc_Newobject68["visible"] = "1";
                oc_Newobject68["active"] = "1";
                oc_Newobject68["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject68["hovertime"] = "1000";
                oc_Newobject68["isContainer"] = "1";
                oc_Newobject68["alphaValue"] = "1";
                oc_Newobject68["mouseOverAlphaValue"] = "1";
                oc_Newobject68["alphaFadeTime"] = "1000";
                oc_Newobject68["moveControl"] = "0";
                oc_Newobject68["lockControl"] = "0";
                oc_Newobject68["windowSettings"] = "1";
                oc_Newobject68["alpha"] = "1";
                oc_Newobject68["mouseOverAlpha"] = "1";
                oc_Newobject68["alphaFade"] = "1";
                oc_Newobject68["contextFontColor"] = "0";
                oc_Newobject68["contextBackColor"] = "0";
                oc_Newobject68["contextFillColor"] = "0";
                oc_Newobject68["contextFontSize"] = "0";
                oc_Newobject68["editable"] = "0";
                oc_Newobject68["canSave"] = "1";
                oc_Newobject68["canSaveDynamicFields"] = "0";
                oc_Newobject68["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject58
                ObjectCreator oc_Newobject58 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject58["position"] = "12 30";
                oc_Newobject58["extent"] = "407 170";
                oc_Newobject58["minExtent"] = "8 2";
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
                oc_Newobject58["isContainer"] = "0";
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
                oc_Newobject58["editable"] = "0";
                oc_Newobject58["canSave"] = "1";
                oc_Newobject58["canSaveDynamicFields"] = "1";
                oc_Newobject58["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject58"] = oc_Newobject58;

                #region GuiCheckBoxCtrl (ppOptionsEnableSSAO2)        oc_Newobject59
                ObjectCreator oc_Newobject59 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableSSAO2", typeof(ppOptionsEnableSSAO2));
                oc_Newobject59["text"] = "Enable";
                oc_Newobject59["groupNum"] = "-1";
                oc_Newobject59["buttonType"] = "ToggleButton";
                oc_Newobject59["useMouseEvents"] = "0";
                oc_Newobject59["position"] = "329 7";
                oc_Newobject59["extent"] = "53 20";
                oc_Newobject59["minExtent"] = "8 2";
                oc_Newobject59["maxExtent"] = "1920 1080";
                oc_Newobject59["horizSizing"] = "right";
                oc_Newobject59["vertSizing"] = "bottom";
                oc_Newobject59["profile"] = "GuiCheckBoxProfile";
                oc_Newobject59["controlFontColor"] = "0 0 0 0";
                oc_Newobject59["backgroundColor"] = "255 255 255 255";
                oc_Newobject59["controlFontSize"] = "14";
                oc_Newobject59["visible"] = "1";
                oc_Newobject59["active"] = "1";
                oc_Newobject59["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject59["tooltip"] = "Enable/Disable the SSAO2 postFX";
                oc_Newobject59["hovertime"] = "1000";
                oc_Newobject59["isContainer"] = "0";
                oc_Newobject59["alphaValue"] = "1";
                oc_Newobject59["mouseOverAlphaValue"] = "1";
                oc_Newobject59["alphaFadeTime"] = "1000";
                oc_Newobject59["windowSettings"] = "1";
                oc_Newobject59["alpha"] = "1";
                oc_Newobject59["mouseOverAlpha"] = "1";
                oc_Newobject59["alphaFade"] = "1";
                oc_Newobject59["contextFontColor"] = "0";
                oc_Newobject59["contextBackColor"] = "0";
                oc_Newobject59["contextFontSize"] = "0";
                oc_Newobject59["editable"] = "0";
                oc_Newobject59["canSave"] = "1";
                oc_Newobject59["canSaveDynamicFields"] = "0";
                oc_Newobject59["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject59"] = oc_Newobject59;

                #region GuiTextCtrl (ppOptionsSSAO2IntensityLabel)        oc_Newobject60
                ObjectCreator oc_Newobject60 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAO2IntensityLabel");
                oc_Newobject60["text"] = "Intensity";
                oc_Newobject60["maxLength"] = "1024";
                oc_Newobject60["margin"] = "0 0 0 0";
                oc_Newobject60["padding"] = "0 0 0 0";
                oc_Newobject60["anchorTop"] = "1";
                oc_Newobject60["anchorBottom"] = "0";
                oc_Newobject60["anchorLeft"] = "1";
                oc_Newobject60["anchorRight"] = "0";
                oc_Newobject60["position"] = "50 50";
                oc_Newobject60["extent"] = "67 16";
                oc_Newobject60["minExtent"] = "8 2";
                oc_Newobject60["maxExtent"] = "1920 1080";
                oc_Newobject60["horizSizing"] = "right";
                oc_Newobject60["vertSizing"] = "bottom";
                oc_Newobject60["profile"] = "GuiTextProfile";
                oc_Newobject60["controlFontColor"] = "0 0 0 0";
                oc_Newobject60["controlFillColor"] = "0 0 0 0";
                oc_Newobject60["backgroundColor"] = "255 255 255 255";
                oc_Newobject60["controlFontSize"] = "14";
                oc_Newobject60["visible"] = "1";
                oc_Newobject60["active"] = "1";
                oc_Newobject60["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject60["tooltip"] = "The intensity of SSAO2";
                oc_Newobject60["hovertime"] = "1000";
                oc_Newobject60["isContainer"] = "0";
                oc_Newobject60["alphaValue"] = "1";
                oc_Newobject60["mouseOverAlphaValue"] = "1";
                oc_Newobject60["alphaFadeTime"] = "1000";
                oc_Newobject60["moveControl"] = "0";
                oc_Newobject60["lockControl"] = "0";
                oc_Newobject60["windowSettings"] = "1";
                oc_Newobject60["alpha"] = "1";
                oc_Newobject60["mouseOverAlpha"] = "1";
                oc_Newobject60["alphaFade"] = "1";
                oc_Newobject60["contextFontColor"] = "0";
                oc_Newobject60["contextBackColor"] = "0";
                oc_Newobject60["contextFillColor"] = "0";
                oc_Newobject60["contextFontSize"] = "0";
                oc_Newobject60["editable"] = "0";
                oc_Newobject60["canSave"] = "1";
                oc_Newobject60["canSaveDynamicFields"] = "0";
                oc_Newobject60["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject60"] = oc_Newobject60;

                #region GuiSliderCtrl (ppOptionsSSAO2Intensity)        oc_Newobject61
                ObjectCreator oc_Newobject61 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAO2Intensity");
                oc_Newobject61["range"] = "0 1";
                oc_Newobject61["ticks"] = "1000";
                oc_Newobject61["snap"] = "0";
                oc_Newobject61["value"] = "0";
                oc_Newobject61["position"] = "150 50";
                oc_Newobject61["extent"] = "224 17";
                oc_Newobject61["minExtent"] = "8 2";
                oc_Newobject61["maxExtent"] = "1920 1080";
                oc_Newobject61["horizSizing"] = "right";
                oc_Newobject61["vertSizing"] = "bottom";
                oc_Newobject61["profile"] = "GuiSliderBoxProfile";
                oc_Newobject61["controlFontColor"] = "0 0 0 0";
                oc_Newobject61["controlFillColor"] = "0 0 0 0";
                oc_Newobject61["backgroundColor"] = "255 255 255 255";
                oc_Newobject61["controlFontSize"] = "14";
                oc_Newobject61["visible"] = "1";
                oc_Newobject61["active"] = "1";
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
                oc_Newobject61["contextFillColor"] = "0";
                oc_Newobject61["contextFontSize"] = "0";
                oc_Newobject61["editable"] = "0";
                oc_Newobject61["canSave"] = "1";
                oc_Newobject61["canSaveDynamicFields"] = "0";
                oc_Newobject61["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject61"] = oc_Newobject61;

                #region GuiTextCtrl (ppOptionsSSAO2RadiusLabel)        oc_Newobject62
                ObjectCreator oc_Newobject62 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAO2RadiusLabel");
                oc_Newobject62["text"] = "Radius";
                oc_Newobject62["maxLength"] = "1024";
                oc_Newobject62["margin"] = "0 0 0 0";
                oc_Newobject62["padding"] = "0 0 0 0";
                oc_Newobject62["anchorTop"] = "1";
                oc_Newobject62["anchorBottom"] = "0";
                oc_Newobject62["anchorLeft"] = "1";
                oc_Newobject62["anchorRight"] = "0";
                oc_Newobject62["position"] = "50 80";
                oc_Newobject62["extent"] = "67 16";
                oc_Newobject62["minExtent"] = "8 2";
                oc_Newobject62["maxExtent"] = "1920 1080";
                oc_Newobject62["horizSizing"] = "right";
                oc_Newobject62["vertSizing"] = "bottom";
                oc_Newobject62["profile"] = "GuiTextProfile";
                oc_Newobject62["controlFontColor"] = "0 0 0 0";
                oc_Newobject62["controlFillColor"] = "0 0 0 0";
                oc_Newobject62["backgroundColor"] = "255 255 255 255";
                oc_Newobject62["controlFontSize"] = "14";
                oc_Newobject62["visible"] = "1";
                oc_Newobject62["active"] = "1";
                oc_Newobject62["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject62["tooltip"] = "The radius of SSAO2";
                oc_Newobject62["hovertime"] = "1000";
                oc_Newobject62["isContainer"] = "0";
                oc_Newobject62["alphaValue"] = "1";
                oc_Newobject62["mouseOverAlphaValue"] = "1";
                oc_Newobject62["alphaFadeTime"] = "1000";
                oc_Newobject62["moveControl"] = "0";
                oc_Newobject62["lockControl"] = "0";
                oc_Newobject62["windowSettings"] = "1";
                oc_Newobject62["alpha"] = "1";
                oc_Newobject62["mouseOverAlpha"] = "1";
                oc_Newobject62["alphaFade"] = "1";
                oc_Newobject62["contextFontColor"] = "0";
                oc_Newobject62["contextBackColor"] = "0";
                oc_Newobject62["contextFillColor"] = "0";
                oc_Newobject62["contextFontSize"] = "0";
                oc_Newobject62["editable"] = "0";
                oc_Newobject62["canSave"] = "1";
                oc_Newobject62["canSaveDynamicFields"] = "0";
                oc_Newobject62["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject62"] = oc_Newobject62;

                #region GuiSliderCtrl (ppOptionsSSAO2Radius)        oc_Newobject63
                ObjectCreator oc_Newobject63 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAO2Radius");
                oc_Newobject63["range"] = "0 1";
                oc_Newobject63["ticks"] = "1000";
                oc_Newobject63["snap"] = "0";
                oc_Newobject63["value"] = "0";
                oc_Newobject63["position"] = "150 80";
                oc_Newobject63["extent"] = "224 17";
                oc_Newobject63["minExtent"] = "8 2";
                oc_Newobject63["maxExtent"] = "1920 1080";
                oc_Newobject63["horizSizing"] = "right";
                oc_Newobject63["vertSizing"] = "bottom";
                oc_Newobject63["profile"] = "GuiSliderBoxProfile";
                oc_Newobject63["controlFontColor"] = "0 0 0 0";
                oc_Newobject63["controlFillColor"] = "0 0 0 0";
                oc_Newobject63["backgroundColor"] = "255 255 255 255";
                oc_Newobject63["controlFontSize"] = "14";
                oc_Newobject63["visible"] = "1";
                oc_Newobject63["active"] = "1";
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
                oc_Newobject63["contextFillColor"] = "0";
                oc_Newobject63["contextFontSize"] = "0";
                oc_Newobject63["editable"] = "0";
                oc_Newobject63["canSave"] = "1";
                oc_Newobject63["canSaveDynamicFields"] = "0";
                oc_Newobject63["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject63"] = oc_Newobject63;

                #region GuiTextCtrl (ppOptionsSSAO2BiasLabel)        oc_Newobject64
                ObjectCreator oc_Newobject64 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAO2BiasLabel");
                oc_Newobject64["text"] = "Bias";
                oc_Newobject64["maxLength"] = "1024";
                oc_Newobject64["margin"] = "0 0 0 0";
                oc_Newobject64["padding"] = "0 0 0 0";
                oc_Newobject64["anchorTop"] = "1";
                oc_Newobject64["anchorBottom"] = "0";
                oc_Newobject64["anchorLeft"] = "1";
                oc_Newobject64["anchorRight"] = "0";
                oc_Newobject64["position"] = "50 110";
                oc_Newobject64["extent"] = "67 16";
                oc_Newobject64["minExtent"] = "8 2";
                oc_Newobject64["maxExtent"] = "1920 1080";
                oc_Newobject64["horizSizing"] = "right";
                oc_Newobject64["vertSizing"] = "bottom";
                oc_Newobject64["profile"] = "GuiTextProfile";
                oc_Newobject64["controlFontColor"] = "0 0 0 0";
                oc_Newobject64["controlFillColor"] = "0 0 0 0";
                oc_Newobject64["backgroundColor"] = "255 255 255 255";
                oc_Newobject64["controlFontSize"] = "14";
                oc_Newobject64["visible"] = "1";
                oc_Newobject64["active"] = "1";
                oc_Newobject64["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject64["tooltip"] = "The bias value of SSAO2";
                oc_Newobject64["hovertime"] = "1000";
                oc_Newobject64["isContainer"] = "0";
                oc_Newobject64["alphaValue"] = "1";
                oc_Newobject64["mouseOverAlphaValue"] = "1";
                oc_Newobject64["alphaFadeTime"] = "1000";
                oc_Newobject64["moveControl"] = "0";
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
                #endregion

                oc_Newobject68["#Newobject64"] = oc_Newobject64;

                #region GuiSliderCtrl (ppOptionsSSAO2Bias)        oc_Newobject65
                ObjectCreator oc_Newobject65 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAO2Bias");
                oc_Newobject65["range"] = "0 1";
                oc_Newobject65["ticks"] = "1000";
                oc_Newobject65["snap"] = "0";
                oc_Newobject65["value"] = "0";
                oc_Newobject65["position"] = "150 110";
                oc_Newobject65["extent"] = "224 17";
                oc_Newobject65["minExtent"] = "8 2";
                oc_Newobject65["maxExtent"] = "1920 1080";
                oc_Newobject65["horizSizing"] = "right";
                oc_Newobject65["vertSizing"] = "bottom";
                oc_Newobject65["profile"] = "GuiSliderBoxProfile";
                oc_Newobject65["controlFontColor"] = "0 0 0 0";
                oc_Newobject65["controlFillColor"] = "0 0 0 0";
                oc_Newobject65["backgroundColor"] = "255 255 255 255";
                oc_Newobject65["controlFontSize"] = "14";
                oc_Newobject65["visible"] = "1";
                oc_Newobject65["active"] = "1";
                oc_Newobject65["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject65["hovertime"] = "1000";
                oc_Newobject65["isContainer"] = "0";
                oc_Newobject65["alphaValue"] = "1";
                oc_Newobject65["mouseOverAlphaValue"] = "1";
                oc_Newobject65["alphaFadeTime"] = "1000";
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
                oc_Newobject65["canSaveDynamicFields"] = "0";
                oc_Newobject65["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject65"] = oc_Newobject65;

                #region GuiTextCtrl (ppOptionsSSAO2ScaleLabel)        oc_Newobject66
                ObjectCreator oc_Newobject66 = new ObjectCreator("GuiTextCtrl", "ppOptionsSSAO2ScaleLabel");
                oc_Newobject66["text"] = "Scale";
                oc_Newobject66["maxLength"] = "1024";
                oc_Newobject66["margin"] = "0 0 0 0";
                oc_Newobject66["padding"] = "0 0 0 0";
                oc_Newobject66["anchorTop"] = "1";
                oc_Newobject66["anchorBottom"] = "0";
                oc_Newobject66["anchorLeft"] = "1";
                oc_Newobject66["anchorRight"] = "0";
                oc_Newobject66["position"] = "50 140";
                oc_Newobject66["extent"] = "67 16";
                oc_Newobject66["minExtent"] = "8 2";
                oc_Newobject66["maxExtent"] = "1920 1080";
                oc_Newobject66["horizSizing"] = "right";
                oc_Newobject66["vertSizing"] = "bottom";
                oc_Newobject66["profile"] = "GuiTextProfile";
                oc_Newobject66["controlFontColor"] = "0 0 0 0";
                oc_Newobject66["controlFillColor"] = "0 0 0 0";
                oc_Newobject66["backgroundColor"] = "255 255 255 255";
                oc_Newobject66["controlFontSize"] = "14";
                oc_Newobject66["visible"] = "1";
                oc_Newobject66["active"] = "1";
                oc_Newobject66["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject66["tooltip"] = "The scale of SSAO2";
                oc_Newobject66["hovertime"] = "1000";
                oc_Newobject66["isContainer"] = "0";
                oc_Newobject66["alphaValue"] = "1";
                oc_Newobject66["mouseOverAlphaValue"] = "1";
                oc_Newobject66["alphaFadeTime"] = "1000";
                oc_Newobject66["moveControl"] = "0";
                oc_Newobject66["lockControl"] = "0";
                oc_Newobject66["windowSettings"] = "1";
                oc_Newobject66["alpha"] = "1";
                oc_Newobject66["mouseOverAlpha"] = "1";
                oc_Newobject66["alphaFade"] = "1";
                oc_Newobject66["contextFontColor"] = "0";
                oc_Newobject66["contextBackColor"] = "0";
                oc_Newobject66["contextFillColor"] = "0";
                oc_Newobject66["contextFontSize"] = "0";
                oc_Newobject66["editable"] = "0";
                oc_Newobject66["canSave"] = "1";
                oc_Newobject66["canSaveDynamicFields"] = "0";
                oc_Newobject66["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject66"] = oc_Newobject66;

                #region GuiSliderCtrl (ppOptionsSSAO2Scale)        oc_Newobject67
                ObjectCreator oc_Newobject67 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSSAO2Scale");
                oc_Newobject67["range"] = "0 1";
                oc_Newobject67["ticks"] = "1000";
                oc_Newobject67["snap"] = "0";
                oc_Newobject67["value"] = "0";
                oc_Newobject67["position"] = "150 140";
                oc_Newobject67["extent"] = "224 17";
                oc_Newobject67["minExtent"] = "8 2";
                oc_Newobject67["maxExtent"] = "1920 1080";
                oc_Newobject67["horizSizing"] = "right";
                oc_Newobject67["vertSizing"] = "bottom";
                oc_Newobject67["profile"] = "GuiSliderBoxProfile";
                oc_Newobject67["controlFontColor"] = "0 0 0 0";
                oc_Newobject67["controlFillColor"] = "0 0 0 0";
                oc_Newobject67["backgroundColor"] = "255 255 255 255";
                oc_Newobject67["controlFontSize"] = "14";
                oc_Newobject67["visible"] = "1";
                oc_Newobject67["active"] = "1";
                oc_Newobject67["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject67["hovertime"] = "1000";
                oc_Newobject67["isContainer"] = "0";
                oc_Newobject67["alphaValue"] = "1";
                oc_Newobject67["mouseOverAlphaValue"] = "1";
                oc_Newobject67["alphaFadeTime"] = "1000";
                oc_Newobject67["windowSettings"] = "1";
                oc_Newobject67["alpha"] = "1";
                oc_Newobject67["mouseOverAlpha"] = "1";
                oc_Newobject67["alphaFade"] = "1";
                oc_Newobject67["contextFontColor"] = "0";
                oc_Newobject67["contextBackColor"] = "0";
                oc_Newobject67["contextFillColor"] = "0";
                oc_Newobject67["contextFontSize"] = "0";
                oc_Newobject67["editable"] = "0";
                oc_Newobject67["canSave"] = "1";
                oc_Newobject67["canSaveDynamicFields"] = "0";
                oc_Newobject67["Enabled"] = "1";
                #endregion

                oc_Newobject68["#Newobject67"] = oc_Newobject67;

                #endregion

                oc_Newobject150["#Newobject68"] = oc_Newobject68;

                #region GuiTabPageCtrl (ppOptionsHDRTab)        oc_Newobject99
                ObjectCreator oc_Newobject99 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsHDRTab");
                oc_Newobject99["fitBook"] = "1";
                oc_Newobject99["text"] = "HDR";
                oc_Newobject99["maxLength"] = "1024";
                oc_Newobject99["docking"] = "None";
                oc_Newobject99["margin"] = "0 0 0 0";
                oc_Newobject99["padding"] = "0 0 0 0";
                oc_Newobject99["anchorTop"] = "1";
                oc_Newobject99["anchorBottom"] = "1";
                oc_Newobject99["anchorLeft"] = "1";
                oc_Newobject99["anchorRight"] = "1";
                oc_Newobject99["position"] = "0 20";
                oc_Newobject99["extent"] = "525 213";
                oc_Newobject99["minExtent"] = "8 2";
                oc_Newobject99["maxExtent"] = "1920 1080";
                oc_Newobject99["horizSizing"] = "right";
                oc_Newobject99["vertSizing"] = "bottom";
                oc_Newobject99["profile"] = "GuiTabPageProfile";
                oc_Newobject99["controlFontColor"] = "0 0 0 0";
                oc_Newobject99["controlFillColor"] = "0 0 0 0";
                oc_Newobject99["backgroundColor"] = "255 255 255 255";
                oc_Newobject99["controlFontSize"] = "10";
                oc_Newobject99["visible"] = "0";
                oc_Newobject99["active"] = "1";
                oc_Newobject99["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject99["tooltip"] = "Options for the High Definition Range Lighting postFX";
                oc_Newobject99["hovertime"] = "1000";
                oc_Newobject99["isContainer"] = "1";
                oc_Newobject99["alphaValue"] = "1";
                oc_Newobject99["mouseOverAlphaValue"] = "1";
                oc_Newobject99["alphaFadeTime"] = "1000";
                oc_Newobject99["moveControl"] = "0";
                oc_Newobject99["lockControl"] = "0";
                oc_Newobject99["windowSettings"] = "1";
                oc_Newobject99["alpha"] = "1";
                oc_Newobject99["mouseOverAlpha"] = "1";
                oc_Newobject99["alphaFade"] = "1";
                oc_Newobject99["contextFontColor"] = "0";
                oc_Newobject99["contextBackColor"] = "0";
                oc_Newobject99["contextFillColor"] = "0";
                oc_Newobject99["contextFontSize"] = "0";
                oc_Newobject99["hidden"] = "1";
                oc_Newobject99["editable"] = "0";
                oc_Newobject99["canSave"] = "1";
                oc_Newobject99["canSaveDynamicFields"] = "0";
                oc_Newobject99["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject69
                ObjectCreator oc_Newobject69 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject69["position"] = "12 30";
                oc_Newobject69["extent"] = "363 172";
                oc_Newobject69["minExtent"] = "8 2";
                oc_Newobject69["maxExtent"] = "1920 1080";
                oc_Newobject69["horizSizing"] = "right";
                oc_Newobject69["vertSizing"] = "bottom";
                oc_Newobject69["profile"] = "GuiTabBorderProfile";
                oc_Newobject69["controlFontColor"] = "0 0 0 0";
                oc_Newobject69["controlFillColor"] = "0 0 0 0";
                oc_Newobject69["backgroundColor"] = "255 255 255 255";
                oc_Newobject69["controlFontSize"] = "14";
                oc_Newobject69["visible"] = "1";
                oc_Newobject69["active"] = "1";
                oc_Newobject69["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject69["hovertime"] = "1000";
                oc_Newobject69["isContainer"] = "0";
                oc_Newobject69["alphaValue"] = "1";
                oc_Newobject69["mouseOverAlphaValue"] = "1";
                oc_Newobject69["alphaFadeTime"] = "1000";
                oc_Newobject69["moveControl"] = "0";
                oc_Newobject69["lockControl"] = "0";
                oc_Newobject69["windowSettings"] = "1";
                oc_Newobject69["alpha"] = "1";
                oc_Newobject69["mouseOverAlpha"] = "1";
                oc_Newobject69["alphaFade"] = "1";
                oc_Newobject69["contextFontColor"] = "0";
                oc_Newobject69["contextBackColor"] = "0";
                oc_Newobject69["contextFillColor"] = "0";
                oc_Newobject69["contextFontSize"] = "0";
                oc_Newobject69["editable"] = "0";
                oc_Newobject69["canSave"] = "1";
                oc_Newobject69["canSaveDynamicFields"] = "1";
                oc_Newobject69["Enabled"] = "1";
                #endregion

                oc_Newobject99["#Newobject69"] = oc_Newobject69;

                #region GuiTabBookCtrl (ppOptionsHDROptions)        oc_Newobject95
                ObjectCreator oc_Newobject95 = new ObjectCreator("GuiTabBookCtrl", "ppOptionsHDROptions");
                oc_Newobject95["tabPosition"] = "Top";
                oc_Newobject95["tabMargin"] = "7";
                oc_Newobject95["minTabWidth"] = "64";
                oc_Newobject95["tabHeight"] = "20";
                oc_Newobject95["allowReorder"] = "0";
                oc_Newobject95["defaultPage"] = "-1";
                oc_Newobject95["selectedPage"] = "2";
                oc_Newobject95["frontTabPadding"] = "0";
                oc_Newobject95["margin"] = "0 0 0 0";
                oc_Newobject95["padding"] = "0 0 0 0";
                oc_Newobject95["anchorTop"] = "1";
                oc_Newobject95["anchorBottom"] = "0";
                oc_Newobject95["anchorLeft"] = "1";
                oc_Newobject95["anchorRight"] = "0";
                oc_Newobject95["position"] = "12 11";
                oc_Newobject95["extent"] = "365 195";
                oc_Newobject95["minExtent"] = "8 2";
                oc_Newobject95["maxExtent"] = "1920 1080";
                oc_Newobject95["horizSizing"] = "right";
                oc_Newobject95["vertSizing"] = "bottom";
                oc_Newobject95["profile"] = "GuiTabBookProfile";
                oc_Newobject95["controlFontColor"] = "0 0 0 0";
                oc_Newobject95["controlFillColor"] = "0 0 0 0";
                oc_Newobject95["backgroundColor"] = "255 255 255 255";
                oc_Newobject95["controlFontSize"] = "14";
                oc_Newobject95["visible"] = "1";
                oc_Newobject95["active"] = "1";
                oc_Newobject95["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject95["hovertime"] = "1000";
                oc_Newobject95["isContainer"] = "1";
                oc_Newobject95["alphaValue"] = "1";
                oc_Newobject95["mouseOverAlphaValue"] = "1";
                oc_Newobject95["alphaFadeTime"] = "1000";
                oc_Newobject95["windowSettings"] = "1";
                oc_Newobject95["alpha"] = "1";
                oc_Newobject95["mouseOverAlpha"] = "1";
                oc_Newobject95["alphaFade"] = "1";
                oc_Newobject95["contextFontColor"] = "0";
                oc_Newobject95["contextBackColor"] = "0";
                oc_Newobject95["contextFillColor"] = "0";
                oc_Newobject95["contextFontSize"] = "0";
                oc_Newobject95["editable"] = "0";
                oc_Newobject95["canSave"] = "1";
                oc_Newobject95["canSaveDynamicFields"] = "0";
                oc_Newobject95["Enabled"] = "1";

                #region GuiTabPageCtrl (ppOptionsHDRBrightnessTab)        oc_Newobject80
                ObjectCreator oc_Newobject80 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsHDRBrightnessTab");
                oc_Newobject80["fitBook"] = "1";
                oc_Newobject80["text"] = "Brightness";
                oc_Newobject80["maxLength"] = "1024";
                oc_Newobject80["docking"] = "None";
                oc_Newobject80["margin"] = "0 0 0 0";
                oc_Newobject80["padding"] = "0 0 0 0";
                oc_Newobject80["anchorTop"] = "1";
                oc_Newobject80["anchorBottom"] = "1";
                oc_Newobject80["anchorLeft"] = "1";
                oc_Newobject80["anchorRight"] = "1";
                oc_Newobject80["position"] = "0 20";
                oc_Newobject80["extent"] = "365 175";
                oc_Newobject80["minExtent"] = "8 2";
                oc_Newobject80["maxExtent"] = "1920 1080";
                oc_Newobject80["horizSizing"] = "right";
                oc_Newobject80["vertSizing"] = "bottom";
                oc_Newobject80["profile"] = "GuiTabPageProfile";
                oc_Newobject80["controlFontColor"] = "0 0 0 0";
                oc_Newobject80["controlFillColor"] = "0 0 0 0";
                oc_Newobject80["backgroundColor"] = "255 255 255 255";
                oc_Newobject80["controlFontSize"] = "10";
                oc_Newobject80["visible"] = "0";
                oc_Newobject80["active"] = "1";
                oc_Newobject80["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject80["tooltip"] = "Contains settings related to the brightness of the HDR postFX";
                oc_Newobject80["hovertime"] = "1000";
                oc_Newobject80["isContainer"] = "1";
                oc_Newobject80["alphaValue"] = "1";
                oc_Newobject80["mouseOverAlphaValue"] = "1";
                oc_Newobject80["alphaFadeTime"] = "1000";
                oc_Newobject80["moveControl"] = "0";
                oc_Newobject80["lockControl"] = "0";
                oc_Newobject80["windowSettings"] = "1";
                oc_Newobject80["alpha"] = "1";
                oc_Newobject80["mouseOverAlpha"] = "1";
                oc_Newobject80["alphaFade"] = "1";
                oc_Newobject80["contextFontColor"] = "0";
                oc_Newobject80["contextBackColor"] = "0";
                oc_Newobject80["contextFillColor"] = "0";
                oc_Newobject80["contextFontSize"] = "0";
                oc_Newobject80["hidden"] = "1";
                oc_Newobject80["editable"] = "0";
                oc_Newobject80["canSave"] = "1";
                oc_Newobject80["canSaveDynamicFields"] = "0";
                oc_Newobject80["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsHDRMinLuminance)        oc_Newobject70
                ObjectCreator oc_Newobject70 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRMinLuminance",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRMinLuminance));
                oc_Newobject70["range"] = "0 1";
                oc_Newobject70["ticks"] = "1000";
                oc_Newobject70["snap"] = "0";
                oc_Newobject70["value"] = "0";
                oc_Newobject70["position"] = "132 77";
                oc_Newobject70["extent"] = "206 17";
                oc_Newobject70["minExtent"] = "8 2";
                oc_Newobject70["maxExtent"] = "1920 1080";
                oc_Newobject70["horizSizing"] = "right";
                oc_Newobject70["vertSizing"] = "bottom";
                oc_Newobject70["profile"] = "GuiSliderBoxProfile";
                oc_Newobject70["controlFontColor"] = "0 0 0 0";
                oc_Newobject70["controlFillColor"] = "0 0 0 0";
                oc_Newobject70["backgroundColor"] = "255 255 255 255";
                oc_Newobject70["controlFontSize"] = "14";
                oc_Newobject70["visible"] = "1";
                oc_Newobject70["active"] = "1";
                oc_Newobject70["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject70["tooltip"] = "Value : 0";
                oc_Newobject70["hovertime"] = "1000";
                oc_Newobject70["isContainer"] = "0";
                oc_Newobject70["alphaValue"] = "1";
                oc_Newobject70["mouseOverAlphaValue"] = "1";
                oc_Newobject70["alphaFadeTime"] = "1000";
                oc_Newobject70["windowSettings"] = "1";
                oc_Newobject70["alpha"] = "1";
                oc_Newobject70["mouseOverAlpha"] = "1";
                oc_Newobject70["alphaFade"] = "1";
                oc_Newobject70["contextFontColor"] = "0";
                oc_Newobject70["contextBackColor"] = "0";
                oc_Newobject70["contextFillColor"] = "0";
                oc_Newobject70["contextFontSize"] = "0";
                oc_Newobject70["editable"] = "0";
                oc_Newobject70["canSave"] = "1";
                oc_Newobject70["canSaveDynamicFields"] = "0";
                oc_Newobject70["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject70"] = oc_Newobject70;

                #region GuiSliderCtrl (ppOptionsHDRKeyValue)        oc_Newobject71
                ObjectCreator oc_Newobject71 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRKeyValue",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRKeyValue));
                oc_Newobject71["range"] = "0 1";
                oc_Newobject71["ticks"] = "1000";
                oc_Newobject71["snap"] = "0";
                oc_Newobject71["value"] = "0.0459184";
                oc_Newobject71["position"] = "132 50";
                oc_Newobject71["extent"] = "206 17";
                oc_Newobject71["minExtent"] = "8 2";
                oc_Newobject71["maxExtent"] = "1920 1080";
                oc_Newobject71["horizSizing"] = "right";
                oc_Newobject71["vertSizing"] = "bottom";
                oc_Newobject71["profile"] = "GuiSliderBoxProfile";
                oc_Newobject71["controlFontColor"] = "0 0 0 0";
                oc_Newobject71["controlFillColor"] = "0 0 0 0";
                oc_Newobject71["backgroundColor"] = "255 255 255 255";
                oc_Newobject71["controlFontSize"] = "14";
                oc_Newobject71["visible"] = "1";
                oc_Newobject71["active"] = "1";
                oc_Newobject71["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject71["tooltip"] = "Value : 0.0459184";
                oc_Newobject71["hovertime"] = "1000";
                oc_Newobject71["isContainer"] = "0";
                oc_Newobject71["alphaValue"] = "1";
                oc_Newobject71["mouseOverAlphaValue"] = "1";
                oc_Newobject71["alphaFadeTime"] = "1000";
                oc_Newobject71["windowSettings"] = "1";
                oc_Newobject71["alpha"] = "1";
                oc_Newobject71["mouseOverAlpha"] = "1";
                oc_Newobject71["alphaFade"] = "1";
                oc_Newobject71["contextFontColor"] = "0";
                oc_Newobject71["contextBackColor"] = "0";
                oc_Newobject71["contextFillColor"] = "0";
                oc_Newobject71["contextFontSize"] = "0";
                oc_Newobject71["editable"] = "0";
                oc_Newobject71["canSave"] = "1";
                oc_Newobject71["canSaveDynamicFields"] = "0";
                oc_Newobject71["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject71"] = oc_Newobject71;

                #region GuiTextCtrl (ppOptionsHDRKeyValueLabel)        oc_Newobject72
                ObjectCreator oc_Newobject72 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRKeyValueLabel");
                oc_Newobject72["text"] = "Key Value";
                oc_Newobject72["maxLength"] = "1024";
                oc_Newobject72["margin"] = "0 0 0 0";
                oc_Newobject72["padding"] = "0 0 0 0";
                oc_Newobject72["anchorTop"] = "1";
                oc_Newobject72["anchorBottom"] = "0";
                oc_Newobject72["anchorLeft"] = "1";
                oc_Newobject72["anchorRight"] = "0";
                oc_Newobject72["position"] = "69 50";
                oc_Newobject72["extent"] = "52 16";
                oc_Newobject72["minExtent"] = "8 2";
                oc_Newobject72["maxExtent"] = "1920 1080";
                oc_Newobject72["horizSizing"] = "right";
                oc_Newobject72["vertSizing"] = "bottom";
                oc_Newobject72["profile"] = "GuiTextProfile";
                oc_Newobject72["controlFontColor"] = "0 0 0 0";
                oc_Newobject72["controlFillColor"] = "0 0 0 0";
                oc_Newobject72["backgroundColor"] = "255 255 255 255";
                oc_Newobject72["controlFontSize"] = "-1";
                oc_Newobject72["visible"] = "1";
                oc_Newobject72["active"] = "1";
                oc_Newobject72["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject72["tooltip"] = "The tone mapping middle grey or exposure value used to adjust the overall balance of the image.";
                oc_Newobject72["hovertime"] = "1000";
                oc_Newobject72["isContainer"] = "0";
                oc_Newobject72["alphaValue"] = "1";
                oc_Newobject72["mouseOverAlphaValue"] = "1";
                oc_Newobject72["alphaFadeTime"] = "1000";
                oc_Newobject72["moveControl"] = "0";
                oc_Newobject72["lockControl"] = "0";
                oc_Newobject72["windowSettings"] = "1";
                oc_Newobject72["alpha"] = "1";
                oc_Newobject72["mouseOverAlpha"] = "1";
                oc_Newobject72["alphaFade"] = "1";
                oc_Newobject72["contextFontColor"] = "0";
                oc_Newobject72["contextBackColor"] = "0";
                oc_Newobject72["contextFillColor"] = "0";
                oc_Newobject72["contextFontSize"] = "0";
                oc_Newobject72["editable"] = "0";
                oc_Newobject72["canSave"] = "1";
                oc_Newobject72["canSaveDynamicFields"] = "0";
                oc_Newobject72["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject72"] = oc_Newobject72;

                #region GuiTextCtrl (ppOptionsHDRMinLuminanceLabel)        oc_Newobject73
                ObjectCreator oc_Newobject73 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRMinLuminanceLabel");
                oc_Newobject73["text"] = "Minimum Luminance";
                oc_Newobject73["maxLength"] = "1024";
                oc_Newobject73["margin"] = "0 0 0 0";
                oc_Newobject73["padding"] = "0 0 0 0";
                oc_Newobject73["anchorTop"] = "1";
                oc_Newobject73["anchorBottom"] = "0";
                oc_Newobject73["anchorLeft"] = "1";
                oc_Newobject73["anchorRight"] = "0";
                oc_Newobject73["position"] = "25 77";
                oc_Newobject73["extent"] = "96 16";
                oc_Newobject73["minExtent"] = "8 2";
                oc_Newobject73["maxExtent"] = "1920 1080";
                oc_Newobject73["horizSizing"] = "right";
                oc_Newobject73["vertSizing"] = "bottom";
                oc_Newobject73["profile"] = "GuiTextProfile";
                oc_Newobject73["controlFontColor"] = "0 0 0 0";
                oc_Newobject73["controlFillColor"] = "0 0 0 0";
                oc_Newobject73["backgroundColor"] = "255 255 255 255";
                oc_Newobject73["controlFontSize"] = "-1";
                oc_Newobject73["visible"] = "1";
                oc_Newobject73["active"] = "1";
                oc_Newobject73["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject73["tooltip"] = "The minimum luminance value to allow when tone mapping the scene. This is particularly useful if your scene is very dark or has a black ambient color in places.";
                oc_Newobject73["hovertime"] = "1000";
                oc_Newobject73["isContainer"] = "0";
                oc_Newobject73["alphaValue"] = "1";
                oc_Newobject73["mouseOverAlphaValue"] = "1";
                oc_Newobject73["alphaFadeTime"] = "1000";
                oc_Newobject73["moveControl"] = "0";
                oc_Newobject73["lockControl"] = "0";
                oc_Newobject73["windowSettings"] = "1";
                oc_Newobject73["alpha"] = "1";
                oc_Newobject73["mouseOverAlpha"] = "1";
                oc_Newobject73["alphaFade"] = "1";
                oc_Newobject73["contextFontColor"] = "0";
                oc_Newobject73["contextBackColor"] = "0";
                oc_Newobject73["contextFillColor"] = "0";
                oc_Newobject73["contextFontSize"] = "0";
                oc_Newobject73["editable"] = "0";
                oc_Newobject73["canSave"] = "1";
                oc_Newobject73["canSaveDynamicFields"] = "0";
                oc_Newobject73["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject73"] = oc_Newobject73;

                #region GuiTextCtrl (ppOptionsHDRWhiteCutoffLabel)        oc_Newobject74
                ObjectCreator oc_Newobject74 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRWhiteCutoffLabel");
                oc_Newobject74["text"] = "White Cutoff";
                oc_Newobject74["maxLength"] = "1024";
                oc_Newobject74["margin"] = "0 0 0 0";
                oc_Newobject74["padding"] = "0 0 0 0";
                oc_Newobject74["anchorTop"] = "1";
                oc_Newobject74["anchorBottom"] = "0";
                oc_Newobject74["anchorLeft"] = "1";
                oc_Newobject74["anchorRight"] = "0";
                oc_Newobject74["position"] = "56 104";
                oc_Newobject74["extent"] = "65 16";
                oc_Newobject74["minExtent"] = "8 2";
                oc_Newobject74["maxExtent"] = "1920 1080";
                oc_Newobject74["horizSizing"] = "right";
                oc_Newobject74["vertSizing"] = "bottom";
                oc_Newobject74["profile"] = "GuiTextProfile";
                oc_Newobject74["controlFontColor"] = "0 0 0 0";
                oc_Newobject74["controlFillColor"] = "0 0 0 0";
                oc_Newobject74["backgroundColor"] = "255 255 255 255";
                oc_Newobject74["controlFontSize"] = "-1";
                oc_Newobject74["visible"] = "1";
                oc_Newobject74["active"] = "1";
                oc_Newobject74["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject74["tooltip"] = "The cutoff level for the white levels in the brightness.";
                oc_Newobject74["hovertime"] = "1000";
                oc_Newobject74["isContainer"] = "0";
                oc_Newobject74["alphaValue"] = "1";
                oc_Newobject74["mouseOverAlphaValue"] = "1";
                oc_Newobject74["alphaFadeTime"] = "1000";
                oc_Newobject74["moveControl"] = "0";
                oc_Newobject74["lockControl"] = "0";
                oc_Newobject74["windowSettings"] = "1";
                oc_Newobject74["alpha"] = "1";
                oc_Newobject74["mouseOverAlpha"] = "1";
                oc_Newobject74["alphaFade"] = "1";
                oc_Newobject74["contextFontColor"] = "0";
                oc_Newobject74["contextBackColor"] = "0";
                oc_Newobject74["contextFillColor"] = "0";
                oc_Newobject74["contextFontSize"] = "0";
                oc_Newobject74["editable"] = "0";
                oc_Newobject74["canSave"] = "1";
                oc_Newobject74["canSaveDynamicFields"] = "0";
                oc_Newobject74["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject74"] = oc_Newobject74;

                #region GuiSliderCtrl (ppOptionsHDRWhiteCutoff)        oc_Newobject75
                ObjectCreator oc_Newobject75 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRWhiteCutoff",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRWhiteCutoff));
                oc_Newobject75["range"] = "0 1";
                oc_Newobject75["ticks"] = "1000";
                oc_Newobject75["snap"] = "0";
                oc_Newobject75["value"] = "0.52551";
                oc_Newobject75["position"] = "132 104";
                oc_Newobject75["extent"] = "206 17";
                oc_Newobject75["minExtent"] = "8 2";
                oc_Newobject75["maxExtent"] = "1920 1080";
                oc_Newobject75["horizSizing"] = "right";
                oc_Newobject75["vertSizing"] = "bottom";
                oc_Newobject75["profile"] = "GuiSliderBoxProfile";
                oc_Newobject75["controlFontColor"] = "0 0 0 0";
                oc_Newobject75["controlFillColor"] = "0 0 0 0";
                oc_Newobject75["backgroundColor"] = "255 255 255 255";
                oc_Newobject75["controlFontSize"] = "14";
                oc_Newobject75["visible"] = "1";
                oc_Newobject75["active"] = "1";
                oc_Newobject75["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject75["tooltip"] = "Value : 0.52551";
                oc_Newobject75["hovertime"] = "1000";
                oc_Newobject75["isContainer"] = "0";
                oc_Newobject75["alphaValue"] = "1";
                oc_Newobject75["mouseOverAlphaValue"] = "1";
                oc_Newobject75["alphaFadeTime"] = "1000";
                oc_Newobject75["windowSettings"] = "1";
                oc_Newobject75["alpha"] = "1";
                oc_Newobject75["mouseOverAlpha"] = "1";
                oc_Newobject75["alphaFade"] = "1";
                oc_Newobject75["contextFontColor"] = "0";
                oc_Newobject75["contextBackColor"] = "0";
                oc_Newobject75["contextFillColor"] = "0";
                oc_Newobject75["contextFontSize"] = "0";
                oc_Newobject75["editable"] = "0";
                oc_Newobject75["canSave"] = "1";
                oc_Newobject75["canSaveDynamicFields"] = "0";
                oc_Newobject75["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject75"] = oc_Newobject75;

                #region GuiSliderCtrl (ppOptionsHDRBrightnessAdaptRate)        oc_Newobject76
                ObjectCreator oc_Newobject76 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRBrightnessAdaptRate",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRBrightnessAdaptRate
                    ));
                oc_Newobject76["range"] = "0 10";
                oc_Newobject76["ticks"] = "1000";
                oc_Newobject76["snap"] = "0";
                oc_Newobject76["value"] = "2";
                oc_Newobject76["position"] = "132 132";
                oc_Newobject76["extent"] = "205 17";
                oc_Newobject76["minExtent"] = "8 2";
                oc_Newobject76["maxExtent"] = "1920 1080";
                oc_Newobject76["horizSizing"] = "right";
                oc_Newobject76["vertSizing"] = "bottom";
                oc_Newobject76["profile"] = "GuiSliderBoxProfile";
                oc_Newobject76["controlFontColor"] = "0 0 0 0";
                oc_Newobject76["controlFillColor"] = "0 0 0 0";
                oc_Newobject76["backgroundColor"] = "255 255 255 255";
                oc_Newobject76["controlFontSize"] = "14";
                oc_Newobject76["visible"] = "1";
                oc_Newobject76["active"] = "1";
                oc_Newobject76["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject76["hovertime"] = "1000";
                oc_Newobject76["isContainer"] = "0";
                oc_Newobject76["alphaValue"] = "1";
                oc_Newobject76["mouseOverAlphaValue"] = "1";
                oc_Newobject76["alphaFadeTime"] = "1000";
                oc_Newobject76["windowSettings"] = "1";
                oc_Newobject76["alpha"] = "1";
                oc_Newobject76["mouseOverAlpha"] = "1";
                oc_Newobject76["alphaFade"] = "1";
                oc_Newobject76["contextFontColor"] = "0";
                oc_Newobject76["contextBackColor"] = "0";
                oc_Newobject76["contextFillColor"] = "0";
                oc_Newobject76["contextFontSize"] = "0";
                oc_Newobject76["editable"] = "0";
                oc_Newobject76["canSave"] = "1";
                oc_Newobject76["canSaveDynamicFields"] = "0";
                oc_Newobject76["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject76"] = oc_Newobject76;

                #region GuiTextCtrl (ppOptionsHDRBrightnessAdaptRateLabel)        oc_Newobject77
                ObjectCreator oc_Newobject77 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRBrightnessAdaptRateLabel");
                oc_Newobject77["text"] = "Brightness Adapt Rate";
                oc_Newobject77["maxLength"] = "1024";
                oc_Newobject77["margin"] = "0 0 0 0";
                oc_Newobject77["padding"] = "0 0 0 0";
                oc_Newobject77["anchorTop"] = "1";
                oc_Newobject77["anchorBottom"] = "0";
                oc_Newobject77["anchorLeft"] = "1";
                oc_Newobject77["anchorRight"] = "0";
                oc_Newobject77["position"] = "12 132";
                oc_Newobject77["extent"] = "109 16";
                oc_Newobject77["minExtent"] = "8 2";
                oc_Newobject77["maxExtent"] = "1920 1080";
                oc_Newobject77["horizSizing"] = "right";
                oc_Newobject77["vertSizing"] = "bottom";
                oc_Newobject77["profile"] = "GuiTextProfile";
                oc_Newobject77["controlFontColor"] = "0 0 0 0";
                oc_Newobject77["controlFillColor"] = "0 0 0 0";
                oc_Newobject77["backgroundColor"] = "255 255 255 255";
                oc_Newobject77["controlFontSize"] = "-1";
                oc_Newobject77["visible"] = "1";
                oc_Newobject77["active"] = "1";
                oc_Newobject77["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject77["tooltip"] = "The speed at which the view adjusts to the new lighting in the environment.";
                oc_Newobject77["hovertime"] = "1000";
                oc_Newobject77["isContainer"] = "0";
                oc_Newobject77["alphaValue"] = "1";
                oc_Newobject77["mouseOverAlphaValue"] = "1";
                oc_Newobject77["alphaFadeTime"] = "1000";
                oc_Newobject77["moveControl"] = "0";
                oc_Newobject77["lockControl"] = "0";
                oc_Newobject77["windowSettings"] = "1";
                oc_Newobject77["alpha"] = "1";
                oc_Newobject77["mouseOverAlpha"] = "1";
                oc_Newobject77["alphaFade"] = "1";
                oc_Newobject77["contextFontColor"] = "0";
                oc_Newobject77["contextBackColor"] = "0";
                oc_Newobject77["contextFillColor"] = "0";
                oc_Newobject77["contextFontSize"] = "0";
                oc_Newobject77["editable"] = "0";
                oc_Newobject77["canSave"] = "1";
                oc_Newobject77["canSaveDynamicFields"] = "0";
                oc_Newobject77["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject77"] = oc_Newobject77;

                #region GuiTextCtrl (ppOptionsHDRKeyValueLabel1)        oc_Newobject78
                ObjectCreator oc_Newobject78 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRKeyValueLabel1");
                oc_Newobject78["text"] = "Tone Mapping Contrast";
                oc_Newobject78["maxLength"] = "1024";
                oc_Newobject78["margin"] = "0 0 0 0";
                oc_Newobject78["padding"] = "0 0 0 0";
                oc_Newobject78["anchorTop"] = "1";
                oc_Newobject78["anchorBottom"] = "0";
                oc_Newobject78["anchorLeft"] = "1";
                oc_Newobject78["anchorRight"] = "0";
                oc_Newobject78["position"] = "10 24";
                oc_Newobject78["extent"] = "111 16";
                oc_Newobject78["minExtent"] = "8 2";
                oc_Newobject78["maxExtent"] = "1920 1080";
                oc_Newobject78["horizSizing"] = "right";
                oc_Newobject78["vertSizing"] = "bottom";
                oc_Newobject78["profile"] = "GuiTextProfile";
                oc_Newobject78["controlFontColor"] = "0 0 0 0";
                oc_Newobject78["controlFillColor"] = "0 0 0 0";
                oc_Newobject78["backgroundColor"] = "255 255 255 255";
                oc_Newobject78["controlFontSize"] = "-1";
                oc_Newobject78["visible"] = "1";
                oc_Newobject78["active"] = "1";
                oc_Newobject78["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject78["tooltip"] = "Tone mapping contrast is the amount of scene to blend, with the tone mapped HDR scene. Lower values are recommended but higher values give a strong contrasted darker shadowed look.";
                oc_Newobject78["hovertime"] = "1000";
                oc_Newobject78["isContainer"] = "0";
                oc_Newobject78["alphaValue"] = "1";
                oc_Newobject78["mouseOverAlphaValue"] = "1";
                oc_Newobject78["alphaFadeTime"] = "1000";
                oc_Newobject78["moveControl"] = "0";
                oc_Newobject78["lockControl"] = "0";
                oc_Newobject78["windowSettings"] = "1";
                oc_Newobject78["alpha"] = "1";
                oc_Newobject78["mouseOverAlpha"] = "1";
                oc_Newobject78["alphaFade"] = "1";
                oc_Newobject78["contextFontColor"] = "0";
                oc_Newobject78["contextBackColor"] = "0";
                oc_Newobject78["contextFillColor"] = "0";
                oc_Newobject78["contextFontSize"] = "0";
                oc_Newobject78["editable"] = "0";
                oc_Newobject78["canSave"] = "1";
                oc_Newobject78["canSaveDynamicFields"] = "0";
                oc_Newobject78["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject78"] = oc_Newobject78;

                #region GuiSliderCtrl (ppOptionsHDRToneMappingAmount)        oc_Newobject79
                ObjectCreator oc_Newobject79 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRToneMappingAmount",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRToneMappingAmount));
                oc_Newobject79["range"] = "0 1";
                oc_Newobject79["ticks"] = "1000";
                oc_Newobject79["snap"] = "0";
                oc_Newobject79["value"] = "0.265306";
                oc_Newobject79["position"] = "132 24";
                oc_Newobject79["extent"] = "206 17";
                oc_Newobject79["minExtent"] = "8 2";
                oc_Newobject79["maxExtent"] = "1920 1080";
                oc_Newobject79["horizSizing"] = "right";
                oc_Newobject79["vertSizing"] = "bottom";
                oc_Newobject79["profile"] = "GuiSliderBoxProfile";
                oc_Newobject79["controlFontColor"] = "0 0 0 0";
                oc_Newobject79["controlFillColor"] = "0 0 0 0";
                oc_Newobject79["backgroundColor"] = "255 255 255 255";
                oc_Newobject79["controlFontSize"] = "14";
                oc_Newobject79["visible"] = "1";
                oc_Newobject79["active"] = "1";
                oc_Newobject79["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject79["tooltip"] = "value : 0.265306";
                oc_Newobject79["hovertime"] = "1000";
                oc_Newobject79["isContainer"] = "0";
                oc_Newobject79["alphaValue"] = "1";
                oc_Newobject79["mouseOverAlphaValue"] = "1";
                oc_Newobject79["alphaFadeTime"] = "1000";
                oc_Newobject79["windowSettings"] = "1";
                oc_Newobject79["alpha"] = "1";
                oc_Newobject79["mouseOverAlpha"] = "1";
                oc_Newobject79["alphaFade"] = "1";
                oc_Newobject79["contextFontColor"] = "0";
                oc_Newobject79["contextBackColor"] = "0";
                oc_Newobject79["contextFillColor"] = "0";
                oc_Newobject79["contextFontSize"] = "0";
                oc_Newobject79["editable"] = "0";
                oc_Newobject79["canSave"] = "1";
                oc_Newobject79["canSaveDynamicFields"] = "0";
                oc_Newobject79["Enabled"] = "1";
                #endregion

                oc_Newobject80["#Newobject79"] = oc_Newobject79;

                #endregion

                oc_Newobject95["#Newobject80"] = oc_Newobject80;

                #region GuiTabPageCtrl (ppOptionsHDRBloomTab)        oc_Newobject90
                ObjectCreator oc_Newobject90 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsHDRBloomTab");
                oc_Newobject90["fitBook"] = "1";
                oc_Newobject90["text"] = "Bloom";
                oc_Newobject90["maxLength"] = "1024";
                oc_Newobject90["docking"] = "None";
                oc_Newobject90["margin"] = "0 0 0 0";
                oc_Newobject90["padding"] = "0 0 0 0";
                oc_Newobject90["anchorTop"] = "1";
                oc_Newobject90["anchorBottom"] = "1";
                oc_Newobject90["anchorLeft"] = "1";
                oc_Newobject90["anchorRight"] = "1";
                oc_Newobject90["position"] = "0 20";
                oc_Newobject90["extent"] = "365 175";
                oc_Newobject90["minExtent"] = "8 2";
                oc_Newobject90["maxExtent"] = "1920 1080";
                oc_Newobject90["horizSizing"] = "right";
                oc_Newobject90["vertSizing"] = "bottom";
                oc_Newobject90["profile"] = "GuiTabPageProfile";
                oc_Newobject90["controlFontColor"] = "0 0 0 0";
                oc_Newobject90["controlFillColor"] = "0 0 0 0";
                oc_Newobject90["backgroundColor"] = "255 255 255 255";
                oc_Newobject90["controlFontSize"] = "10";
                oc_Newobject90["visible"] = "0";
                oc_Newobject90["active"] = "1";
                oc_Newobject90["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject90["tooltip"] = "Contains settings related to the blooming aspect of the HDR postFX";
                oc_Newobject90["hovertime"] = "1000";
                oc_Newobject90["isContainer"] = "1";
                oc_Newobject90["alphaValue"] = "1";
                oc_Newobject90["mouseOverAlphaValue"] = "1";
                oc_Newobject90["alphaFadeTime"] = "1000";
                oc_Newobject90["moveControl"] = "0";
                oc_Newobject90["lockControl"] = "0";
                oc_Newobject90["windowSettings"] = "1";
                oc_Newobject90["alpha"] = "1";
                oc_Newobject90["mouseOverAlpha"] = "1";
                oc_Newobject90["alphaFade"] = "1";
                oc_Newobject90["contextFontColor"] = "0";
                oc_Newobject90["contextBackColor"] = "0";
                oc_Newobject90["contextFillColor"] = "0";
                oc_Newobject90["contextFontSize"] = "0";
                oc_Newobject90["hidden"] = "1";
                oc_Newobject90["editable"] = "0";
                oc_Newobject90["canSave"] = "1";
                oc_Newobject90["canSaveDynamicFields"] = "0";
                oc_Newobject90["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsHDRBloomBlurMultiplier)        oc_Newobject81
                ObjectCreator oc_Newobject81 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRBloomBlurMultiplier",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRBloomBlurMultiplier
                    ));
                oc_Newobject81["range"] = "0 5";
                oc_Newobject81["ticks"] = "1000";
                oc_Newobject81["snap"] = "0";
                oc_Newobject81["value"] = "0.502645";
                oc_Newobject81["position"] = "132 70";
                oc_Newobject81["extent"] = "199 17";
                oc_Newobject81["minExtent"] = "8 2";
                oc_Newobject81["maxExtent"] = "1920 1080";
                oc_Newobject81["horizSizing"] = "right";
                oc_Newobject81["vertSizing"] = "bottom";
                oc_Newobject81["profile"] = "GuiSliderBoxProfile";
                oc_Newobject81["controlFontColor"] = "0 0 0 0";
                oc_Newobject81["controlFillColor"] = "0 0 0 0";
                oc_Newobject81["backgroundColor"] = "255 255 255 255";
                oc_Newobject81["controlFontSize"] = "14";
                oc_Newobject81["visible"] = "1";
                oc_Newobject81["active"] = "1";
                oc_Newobject81["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject81["tooltip"] = "Value : 0.502645";
                oc_Newobject81["hovertime"] = "1000";
                oc_Newobject81["isContainer"] = "0";
                oc_Newobject81["alphaValue"] = "1";
                oc_Newobject81["mouseOverAlphaValue"] = "1";
                oc_Newobject81["alphaFadeTime"] = "1000";
                oc_Newobject81["windowSettings"] = "1";
                oc_Newobject81["alpha"] = "1";
                oc_Newobject81["mouseOverAlpha"] = "1";
                oc_Newobject81["alphaFade"] = "1";
                oc_Newobject81["contextFontColor"] = "0";
                oc_Newobject81["contextBackColor"] = "0";
                oc_Newobject81["contextFillColor"] = "0";
                oc_Newobject81["contextFontSize"] = "0";
                oc_Newobject81["editable"] = "0";
                oc_Newobject81["canSave"] = "1";
                oc_Newobject81["canSaveDynamicFields"] = "0";
                oc_Newobject81["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject81"] = oc_Newobject81;

                #region GuiSliderCtrl (ppOptionsHDRBloomBlurMean)        oc_Newobject82
                ObjectCreator oc_Newobject82 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRBloomBlurMean",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRBloomBlurMean));
                oc_Newobject82["range"] = "0 1";
                oc_Newobject82["ticks"] = "1000";
                oc_Newobject82["snap"] = "0";
                oc_Newobject82["value"] = "0.510526";
                oc_Newobject82["position"] = "132 97";
                oc_Newobject82["extent"] = "200 17";
                oc_Newobject82["minExtent"] = "8 2";
                oc_Newobject82["maxExtent"] = "1920 1080";
                oc_Newobject82["horizSizing"] = "right";
                oc_Newobject82["vertSizing"] = "bottom";
                oc_Newobject82["profile"] = "GuiSliderBoxProfile";
                oc_Newobject82["controlFontColor"] = "0 0 0 0";
                oc_Newobject82["controlFillColor"] = "0 0 0 0";
                oc_Newobject82["backgroundColor"] = "255 255 255 255";
                oc_Newobject82["controlFontSize"] = "14";
                oc_Newobject82["visible"] = "1";
                oc_Newobject82["active"] = "1";
                oc_Newobject82["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject82["tooltip"] = "Value : 0.510526";
                oc_Newobject82["hovertime"] = "1000";
                oc_Newobject82["isContainer"] = "0";
                oc_Newobject82["alphaValue"] = "1";
                oc_Newobject82["mouseOverAlphaValue"] = "1";
                oc_Newobject82["alphaFadeTime"] = "1000";
                oc_Newobject82["windowSettings"] = "1";
                oc_Newobject82["alpha"] = "1";
                oc_Newobject82["mouseOverAlpha"] = "1";
                oc_Newobject82["alphaFade"] = "1";
                oc_Newobject82["contextFontColor"] = "0";
                oc_Newobject82["contextBackColor"] = "0";
                oc_Newobject82["contextFillColor"] = "0";
                oc_Newobject82["contextFontSize"] = "0";
                oc_Newobject82["editable"] = "0";
                oc_Newobject82["canSave"] = "1";
                oc_Newobject82["canSaveDynamicFields"] = "0";
                oc_Newobject82["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject82"] = oc_Newobject82;

                #region GuiSliderCtrl (ppOptionsHDRBloomBlurStdDev)        oc_Newobject83
                ObjectCreator oc_Newobject83 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRBloomBlurStdDev",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRBloomBlurStdDev));
                oc_Newobject83["range"] = "0 3";
                oc_Newobject83["ticks"] = "1000";
                oc_Newobject83["snap"] = "0";
                oc_Newobject83["value"] = "1.4127";
                oc_Newobject83["position"] = "132 123";
                oc_Newobject83["extent"] = "199 17";
                oc_Newobject83["minExtent"] = "8 2";
                oc_Newobject83["maxExtent"] = "1920 1080";
                oc_Newobject83["horizSizing"] = "right";
                oc_Newobject83["vertSizing"] = "bottom";
                oc_Newobject83["profile"] = "GuiSliderBoxProfile";
                oc_Newobject83["controlFontColor"] = "0 0 0 0";
                oc_Newobject83["controlFillColor"] = "0 0 0 0";
                oc_Newobject83["backgroundColor"] = "255 255 255 255";
                oc_Newobject83["controlFontSize"] = "14";
                oc_Newobject83["visible"] = "1";
                oc_Newobject83["active"] = "1";
                oc_Newobject83["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject83["tooltip"] = "Value : 1.4127";
                oc_Newobject83["hovertime"] = "1000";
                oc_Newobject83["isContainer"] = "0";
                oc_Newobject83["alphaValue"] = "1";
                oc_Newobject83["mouseOverAlphaValue"] = "1";
                oc_Newobject83["alphaFadeTime"] = "1000";
                oc_Newobject83["windowSettings"] = "1";
                oc_Newobject83["alpha"] = "1";
                oc_Newobject83["mouseOverAlpha"] = "1";
                oc_Newobject83["alphaFade"] = "1";
                oc_Newobject83["contextFontColor"] = "0";
                oc_Newobject83["contextBackColor"] = "0";
                oc_Newobject83["contextFillColor"] = "0";
                oc_Newobject83["contextFontSize"] = "0";
                oc_Newobject83["editable"] = "0";
                oc_Newobject83["canSave"] = "1";
                oc_Newobject83["canSaveDynamicFields"] = "0";
                oc_Newobject83["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject83"] = oc_Newobject83;

                #region GuiTextCtrl (ppOptionsHDRBlurMultiplierLabel)        oc_Newobject84
                ObjectCreator oc_Newobject84 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRBlurMultiplierLabel");
                oc_Newobject84["text"] = "Blur Multiplier";
                oc_Newobject84["maxLength"] = "1024";
                oc_Newobject84["margin"] = "0 0 0 0";
                oc_Newobject84["padding"] = "0 0 0 0";
                oc_Newobject84["anchorTop"] = "1";
                oc_Newobject84["anchorBottom"] = "0";
                oc_Newobject84["anchorLeft"] = "1";
                oc_Newobject84["anchorRight"] = "0";
                oc_Newobject84["position"] = "59 70";
                oc_Newobject84["extent"] = "63 16";
                oc_Newobject84["minExtent"] = "8 2";
                oc_Newobject84["maxExtent"] = "1920 1080";
                oc_Newobject84["horizSizing"] = "right";
                oc_Newobject84["vertSizing"] = "bottom";
                oc_Newobject84["profile"] = "GuiTextProfile";
                oc_Newobject84["controlFontColor"] = "0 0 0 0";
                oc_Newobject84["controlFillColor"] = "0 0 0 0";
                oc_Newobject84["backgroundColor"] = "255 255 255 255";
                oc_Newobject84["controlFontSize"] = "-1";
                oc_Newobject84["visible"] = "1";
                oc_Newobject84["active"] = "1";
                oc_Newobject84["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject84["tooltip"] = "The amount of blur to apply to the bloomed areas in the HDR.";
                oc_Newobject84["hovertime"] = "1000";
                oc_Newobject84["isContainer"] = "0";
                oc_Newobject84["alphaValue"] = "1";
                oc_Newobject84["mouseOverAlphaValue"] = "1";
                oc_Newobject84["alphaFadeTime"] = "1000";
                oc_Newobject84["moveControl"] = "0";
                oc_Newobject84["lockControl"] = "0";
                oc_Newobject84["windowSettings"] = "1";
                oc_Newobject84["alpha"] = "1";
                oc_Newobject84["mouseOverAlpha"] = "1";
                oc_Newobject84["alphaFade"] = "1";
                oc_Newobject84["contextFontColor"] = "0";
                oc_Newobject84["contextBackColor"] = "0";
                oc_Newobject84["contextFillColor"] = "0";
                oc_Newobject84["contextFontSize"] = "0";
                oc_Newobject84["editable"] = "0";
                oc_Newobject84["canSave"] = "1";
                oc_Newobject84["canSaveDynamicFields"] = "0";
                oc_Newobject84["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject84"] = oc_Newobject84;

                #region GuiTextCtrl (ppOptionsHDRBlurMeanLabel)        oc_Newobject85
                ObjectCreator oc_Newobject85 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRBlurMeanLabel");
                oc_Newobject85["text"] = "Blur mean value";
                oc_Newobject85["maxLength"] = "1024";
                oc_Newobject85["margin"] = "0 0 0 0";
                oc_Newobject85["padding"] = "0 0 0 0";
                oc_Newobject85["anchorTop"] = "1";
                oc_Newobject85["anchorBottom"] = "0";
                oc_Newobject85["anchorLeft"] = "1";
                oc_Newobject85["anchorRight"] = "0";
                oc_Newobject85["position"] = "38 97";
                oc_Newobject85["extent"] = "84 16";
                oc_Newobject85["minExtent"] = "8 2";
                oc_Newobject85["maxExtent"] = "1920 1080";
                oc_Newobject85["horizSizing"] = "right";
                oc_Newobject85["vertSizing"] = "bottom";
                oc_Newobject85["profile"] = "GuiTextProfile";
                oc_Newobject85["controlFontColor"] = "0 0 0 0";
                oc_Newobject85["controlFillColor"] = "0 0 0 0";
                oc_Newobject85["backgroundColor"] = "255 255 255 255";
                oc_Newobject85["controlFontSize"] = "-1";
                oc_Newobject85["visible"] = "1";
                oc_Newobject85["active"] = "1";
                oc_Newobject85["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject85["hovertime"] = "1000";
                oc_Newobject85["isContainer"] = "0";
                oc_Newobject85["alphaValue"] = "1";
                oc_Newobject85["mouseOverAlphaValue"] = "1";
                oc_Newobject85["alphaFadeTime"] = "1000";
                oc_Newobject85["moveControl"] = "0";
                oc_Newobject85["lockControl"] = "0";
                oc_Newobject85["windowSettings"] = "1";
                oc_Newobject85["alpha"] = "1";
                oc_Newobject85["mouseOverAlpha"] = "1";
                oc_Newobject85["alphaFade"] = "1";
                oc_Newobject85["contextFontColor"] = "0";
                oc_Newobject85["contextBackColor"] = "0";
                oc_Newobject85["contextFillColor"] = "0";
                oc_Newobject85["contextFontSize"] = "0";
                oc_Newobject85["editable"] = "0";
                oc_Newobject85["canSave"] = "1";
                oc_Newobject85["canSaveDynamicFields"] = "0";
                oc_Newobject85["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject85"] = oc_Newobject85;

                #region GuiTextCtrl (ppOptionsHDRBlurStandardDevianceLabel)        oc_Newobject86
                ObjectCreator oc_Newobject86 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRBlurStandardDevianceLabel");
                oc_Newobject86["text"] = "Blur Std Dev value";
                oc_Newobject86["maxLength"] = "1024";
                oc_Newobject86["margin"] = "0 0 0 0";
                oc_Newobject86["padding"] = "0 0 0 0";
                oc_Newobject86["anchorTop"] = "1";
                oc_Newobject86["anchorBottom"] = "0";
                oc_Newobject86["anchorLeft"] = "1";
                oc_Newobject86["anchorRight"] = "0";
                oc_Newobject86["position"] = "23 123";
                oc_Newobject86["extent"] = "99 16";
                oc_Newobject86["minExtent"] = "8 2";
                oc_Newobject86["maxExtent"] = "1920 1080";
                oc_Newobject86["horizSizing"] = "right";
                oc_Newobject86["vertSizing"] = "bottom";
                oc_Newobject86["profile"] = "GuiTextProfile";
                oc_Newobject86["controlFontColor"] = "0 0 0 0";
                oc_Newobject86["controlFillColor"] = "0 0 0 0";
                oc_Newobject86["backgroundColor"] = "255 255 255 255";
                oc_Newobject86["controlFontSize"] = "-1";
                oc_Newobject86["visible"] = "1";
                oc_Newobject86["active"] = "1";
                oc_Newobject86["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject86["hovertime"] = "1000";
                oc_Newobject86["isContainer"] = "0";
                oc_Newobject86["alphaValue"] = "1";
                oc_Newobject86["mouseOverAlphaValue"] = "1";
                oc_Newobject86["alphaFadeTime"] = "1000";
                oc_Newobject86["moveControl"] = "0";
                oc_Newobject86["lockControl"] = "0";
                oc_Newobject86["windowSettings"] = "1";
                oc_Newobject86["alpha"] = "1";
                oc_Newobject86["mouseOverAlpha"] = "1";
                oc_Newobject86["alphaFade"] = "1";
                oc_Newobject86["contextFontColor"] = "0";
                oc_Newobject86["contextBackColor"] = "0";
                oc_Newobject86["contextFillColor"] = "0";
                oc_Newobject86["contextFontSize"] = "0";
                oc_Newobject86["editable"] = "0";
                oc_Newobject86["canSave"] = "1";
                oc_Newobject86["canSaveDynamicFields"] = "0";
                oc_Newobject86["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject86"] = oc_Newobject86;

                #region GuiTextCtrl (ppOptionsHDRBloomBrightPassThresholdLabel)        oc_Newobject87
                ObjectCreator oc_Newobject87 = new ObjectCreator("GuiTextCtrl", "ppOptionsHDRBloomBrightPassThresholdLabel");
                oc_Newobject87["text"] = "Bright pass threshold";
                oc_Newobject87["maxLength"] = "1024";
                oc_Newobject87["margin"] = "0 0 0 0";
                oc_Newobject87["padding"] = "0 0 0 0";
                oc_Newobject87["anchorTop"] = "1";
                oc_Newobject87["anchorBottom"] = "0";
                oc_Newobject87["anchorLeft"] = "1";
                oc_Newobject87["anchorRight"] = "0";
                oc_Newobject87["position"] = "19 43";
                oc_Newobject87["extent"] = "103 16";
                oc_Newobject87["minExtent"] = "8 2";
                oc_Newobject87["maxExtent"] = "1920 1080";
                oc_Newobject87["horizSizing"] = "right";
                oc_Newobject87["vertSizing"] = "bottom";
                oc_Newobject87["profile"] = "GuiTextProfile";
                oc_Newobject87["controlFontColor"] = "0 0 0 0";
                oc_Newobject87["controlFillColor"] = "0 0 0 0";
                oc_Newobject87["backgroundColor"] = "255 255 255 255";
                oc_Newobject87["controlFontSize"] = "-1";
                oc_Newobject87["visible"] = "1";
                oc_Newobject87["active"] = "1";
                oc_Newobject87["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject87["tooltip"] = "The bright pass threshold controls how bright the brightest areas of the scene are in the HDR.";
                oc_Newobject87["hovertime"] = "1000";
                oc_Newobject87["isContainer"] = "0";
                oc_Newobject87["alphaValue"] = "1";
                oc_Newobject87["mouseOverAlphaValue"] = "1";
                oc_Newobject87["alphaFadeTime"] = "1000";
                oc_Newobject87["moveControl"] = "0";
                oc_Newobject87["lockControl"] = "0";
                oc_Newobject87["windowSettings"] = "1";
                oc_Newobject87["alpha"] = "1";
                oc_Newobject87["mouseOverAlpha"] = "1";
                oc_Newobject87["alphaFade"] = "1";
                oc_Newobject87["contextFontColor"] = "0";
                oc_Newobject87["contextBackColor"] = "0";
                oc_Newobject87["contextFillColor"] = "0";
                oc_Newobject87["contextFontSize"] = "0";
                oc_Newobject87["editable"] = "0";
                oc_Newobject87["canSave"] = "1";
                oc_Newobject87["canSaveDynamicFields"] = "0";
                oc_Newobject87["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject87"] = oc_Newobject87;

                #region GuiSliderCtrl (ppOptionsHDRBloomBlurBrightPassThreshold)        oc_Newobject88
                ObjectCreator oc_Newobject88 = new ObjectCreator("GuiSliderCtrl", "ppOptionsHDRBloomBlurBrightPassThreshold",
                typeof(
                    WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.
                        ppOptionsHDRBloomBlurBrightPassThreshold));
                oc_Newobject88["range"] = "0 5";
                oc_Newobject88["ticks"] = "1000";
                oc_Newobject88["snap"] = "0";
                oc_Newobject88["value"] = "1.60526";
                oc_Newobject88["position"] = "132 43";
                oc_Newobject88["extent"] = "200 17";
                oc_Newobject88["minExtent"] = "8 2";
                oc_Newobject88["maxExtent"] = "1920 1080";
                oc_Newobject88["horizSizing"] = "right";
                oc_Newobject88["vertSizing"] = "bottom";
                oc_Newobject88["profile"] = "GuiSliderBoxProfile";
                oc_Newobject88["controlFontColor"] = "0 0 0 0";
                oc_Newobject88["controlFillColor"] = "0 0 0 0";
                oc_Newobject88["backgroundColor"] = "255 255 255 255";
                oc_Newobject88["controlFontSize"] = "14";
                oc_Newobject88["visible"] = "1";
                oc_Newobject88["active"] = "1";
                oc_Newobject88["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject88["tooltip"] = "Value : 1.60526";
                oc_Newobject88["hovertime"] = "1000";
                oc_Newobject88["isContainer"] = "0";
                oc_Newobject88["alphaValue"] = "1";
                oc_Newobject88["mouseOverAlphaValue"] = "1";
                oc_Newobject88["alphaFadeTime"] = "1000";
                oc_Newobject88["windowSettings"] = "1";
                oc_Newobject88["alpha"] = "1";
                oc_Newobject88["mouseOverAlpha"] = "1";
                oc_Newobject88["alphaFade"] = "1";
                oc_Newobject88["contextFontColor"] = "0";
                oc_Newobject88["contextBackColor"] = "0";
                oc_Newobject88["contextFillColor"] = "0";
                oc_Newobject88["contextFontSize"] = "0";
                oc_Newobject88["editable"] = "0";
                oc_Newobject88["canSave"] = "1";
                oc_Newobject88["canSaveDynamicFields"] = "0";
                oc_Newobject88["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject88"] = oc_Newobject88;

                #region GuiCheckBoxCtrl (ppOptionsHDRBloom)        oc_Newobject89
                ObjectCreator oc_Newobject89 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsHDRBloom",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRBloom));
                oc_Newobject89["text"] = " Enable Bloom";
                oc_Newobject89["groupNum"] = "-1";
                oc_Newobject89["buttonType"] = "ToggleButton";
                oc_Newobject89["useMouseEvents"] = "0";
                oc_Newobject89["position"] = "250 9";
                oc_Newobject89["extent"] = "85 24";
                oc_Newobject89["minExtent"] = "8 2";
                oc_Newobject89["maxExtent"] = "1920 1080";
                oc_Newobject89["horizSizing"] = "right";
                oc_Newobject89["vertSizing"] = "bottom";
                oc_Newobject89["profile"] = "GuiCheckBoxProfile";
                oc_Newobject89["controlFontColor"] = "0 0 0 0";
                oc_Newobject89["backgroundColor"] = "255 255 255 255";
                oc_Newobject89["controlFontSize"] = "14";
                oc_Newobject89["visible"] = "1";
                oc_Newobject89["active"] = "1";
                oc_Newobject89["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject89["tooltip"] = "Enables or disables the bloom (glowing effect) of the HDR PostFX.";
                oc_Newobject89["hovertime"] = "1000";
                oc_Newobject89["isContainer"] = "0";
                oc_Newobject89["alphaValue"] = "1";
                oc_Newobject89["mouseOverAlphaValue"] = "1";
                oc_Newobject89["alphaFadeTime"] = "1000";
                oc_Newobject89["windowSettings"] = "1";
                oc_Newobject89["alpha"] = "1";
                oc_Newobject89["mouseOverAlpha"] = "1";
                oc_Newobject89["alphaFade"] = "1";
                oc_Newobject89["contextFontColor"] = "0";
                oc_Newobject89["contextBackColor"] = "0";
                oc_Newobject89["contextFontSize"] = "0";
                oc_Newobject89["editable"] = "0";
                oc_Newobject89["canSave"] = "1";
                oc_Newobject89["canSaveDynamicFields"] = "0";
                oc_Newobject89["Enabled"] = "1";
                #endregion

                oc_Newobject90["#Newobject89"] = oc_Newobject89;

                #endregion

                oc_Newobject95["#Newobject90"] = oc_Newobject90;

                #region GuiTabPageCtrl (ppOptionsHDRBloomEffectsTab)        oc_Newobject94
                ObjectCreator oc_Newobject94 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsHDRBloomEffectsTab");
                oc_Newobject94["fitBook"] = "1";
                oc_Newobject94["text"] = "Effects";
                oc_Newobject94["maxLength"] = "1024";
                oc_Newobject94["docking"] = "None";
                oc_Newobject94["margin"] = "0 0 0 0";
                oc_Newobject94["padding"] = "0 0 0 0";
                oc_Newobject94["anchorTop"] = "1";
                oc_Newobject94["anchorBottom"] = "1";
                oc_Newobject94["anchorLeft"] = "1";
                oc_Newobject94["anchorRight"] = "1";
                oc_Newobject94["position"] = "0 20";
                oc_Newobject94["extent"] = "365 175";
                oc_Newobject94["minExtent"] = "8 2";
                oc_Newobject94["maxExtent"] = "1920 1080";
                oc_Newobject94["horizSizing"] = "right";
                oc_Newobject94["vertSizing"] = "bottom";
                oc_Newobject94["profile"] = "GuiTabPageProfile";
                oc_Newobject94["controlFontColor"] = "0 0 0 0";
                oc_Newobject94["controlFillColor"] = "0 0 0 0";
                oc_Newobject94["backgroundColor"] = "255 255 255 255";
                oc_Newobject94["controlFontSize"] = "10";
                oc_Newobject94["visible"] = "1";
                oc_Newobject94["active"] = "1";
                oc_Newobject94["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject94["tooltip"] = "Contains settings related to the effects the HDR postFX can offer";
                oc_Newobject94["hovertime"] = "1000";
                oc_Newobject94["isContainer"] = "1";
                oc_Newobject94["alphaValue"] = "1";
                oc_Newobject94["mouseOverAlphaValue"] = "1";
                oc_Newobject94["alphaFadeTime"] = "1000";
                oc_Newobject94["moveControl"] = "0";
                oc_Newobject94["lockControl"] = "0";
                oc_Newobject94["windowSettings"] = "1";
                oc_Newobject94["alpha"] = "1";
                oc_Newobject94["mouseOverAlpha"] = "1";
                oc_Newobject94["alphaFade"] = "1";
                oc_Newobject94["contextFontColor"] = "0";
                oc_Newobject94["contextBackColor"] = "0";
                oc_Newobject94["contextFillColor"] = "0";
                oc_Newobject94["contextFontSize"] = "0";
                oc_Newobject94["editable"] = "0";
                oc_Newobject94["canSave"] = "1";
                oc_Newobject94["canSaveDynamicFields"] = "0";
                oc_Newobject94["Enabled"] = "1";

                #region GuiCheckBoxCtrl (ppOptionsHDREffectsBlueShift)        oc_Newobject91
                ObjectCreator oc_Newobject91 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsHDREffectsBlueShift",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDREffectsBlueShift));
                oc_Newobject91["text"] = " Enable Color Shift";
                oc_Newobject91["groupNum"] = "-1";
                oc_Newobject91["buttonType"] = "ToggleButton";
                oc_Newobject91["useMouseEvents"] = "0";
                oc_Newobject91["position"] = "11 4";
                oc_Newobject91["extent"] = "117 24";
                oc_Newobject91["minExtent"] = "8 2";
                oc_Newobject91["maxExtent"] = "1920 1080";
                oc_Newobject91["horizSizing"] = "right";
                oc_Newobject91["vertSizing"] = "bottom";
                oc_Newobject91["profile"] = "GuiCheckBoxProfile";
                oc_Newobject91["controlFontColor"] = "0 0 0 0";
                oc_Newobject91["backgroundColor"] = "255 255 255 255";
                oc_Newobject91["controlFontSize"] = "14";
                oc_Newobject91["visible"] = "1";
                oc_Newobject91["active"] = "1";
                oc_Newobject91["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject91["tooltip"] = "Enables a scene tinting/Blue shift based on the color selected below.";
                oc_Newobject91["hovertime"] = "1000";
                oc_Newobject91["isContainer"] = "0";
                oc_Newobject91["alphaValue"] = "1";
                oc_Newobject91["mouseOverAlphaValue"] = "1";
                oc_Newobject91["alphaFadeTime"] = "1000";
                oc_Newobject91["windowSettings"] = "1";
                oc_Newobject91["alpha"] = "1";
                oc_Newobject91["mouseOverAlpha"] = "1";
                oc_Newobject91["alphaFade"] = "1";
                oc_Newobject91["contextFontColor"] = "0";
                oc_Newobject91["contextBackColor"] = "0";
                oc_Newobject91["contextFontSize"] = "0";
                oc_Newobject91["editable"] = "0";
                oc_Newobject91["canSave"] = "1";
                oc_Newobject91["canSaveDynamicFields"] = "0";
                oc_Newobject91["Enabled"] = "1";
                #endregion

                oc_Newobject94["#Newobject91"] = oc_Newobject91;

                #region GuiColorPickerCtrl (ppOptionsHDREffectsBlueShiftColorBlend)        oc_Newobject92
                ObjectCreator oc_Newobject92 = new ObjectCreator("GuiColorPickerCtrl", "ppOptionsHDREffectsBlueShiftColorBlend",
                typeof(
                    WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.
                        ppOptionsHDREffectsBlueShiftColorBlend));
                oc_Newobject92["baseColor"] = "1 0 0.0235294 1";
                oc_Newobject92["pickColor"] = "0 0 0 1";
                oc_Newobject92["selectorGap"] = "1";
                oc_Newobject92["displayMode"] = "BlendColor";
                oc_Newobject92["actionOnMove"] = "1";
                oc_Newobject92["showReticle"] = "1";
                oc_Newobject92["position"] = "10 29";
                oc_Newobject92["extent"] = "344 110";
                oc_Newobject92["minExtent"] = "8 2";
                oc_Newobject92["maxExtent"] = "1920 1080";
                oc_Newobject92["horizSizing"] = "right";
                oc_Newobject92["vertSizing"] = "bottom";
                oc_Newobject92["profile"] = "GuiDefaultProfile";
                oc_Newobject92["controlFontSize"] = "14";
                oc_Newobject92["visible"] = "1";
                oc_Newobject92["active"] = "1";
                oc_Newobject92["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject92["tooltip"] = "Select a color";
                oc_Newobject92["hovertime"] = "1000";
                oc_Newobject92["isContainer"] = "0";
                oc_Newobject92["alphaValue"] = "1";
                oc_Newobject92["mouseOverAlphaValue"] = "1";
                oc_Newobject92["alphaFadeTime"] = "1000";
                oc_Newobject92["moveControl"] = "0";
                oc_Newobject92["lockControl"] = "0";
                oc_Newobject92["windowSettings"] = "1";
                oc_Newobject92["alpha"] = "1";
                oc_Newobject92["mouseOverAlpha"] = "1";
                oc_Newobject92["alphaFade"] = "1";
                oc_Newobject92["contextFontSize"] = "0";
                oc_Newobject92["editable"] = "0";
                oc_Newobject92["canSave"] = "1";
                oc_Newobject92["canSaveDynamicFields"] = "0";
                oc_Newobject92["Enabled"] = "1";
                #endregion

                oc_Newobject94["#Newobject92"] = oc_Newobject92;

                #region GuiColorPickerCtrl (ppOptionsHDREffectsBlueShiftColorBaseColor)        oc_Newobject93
                ObjectCreator oc_Newobject93 = new ObjectCreator("GuiColorPickerCtrl", "ppOptionsHDREffectsBlueShiftColorBaseColor",
                typeof(
                    WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.
                        ppOptionsHDREffectsBlueShiftColorBaseColor));
                oc_Newobject93["baseColor"] = "1 0 0.0235294 1";
                oc_Newobject93["pickColor"] = "0 0 0 1";
                oc_Newobject93["selectorGap"] = "1";
                oc_Newobject93["displayMode"] = "HorizColor";
                oc_Newobject93["actionOnMove"] = "1";
                oc_Newobject93["showReticle"] = "1";
                oc_Newobject93["position"] = "10 142";
                oc_Newobject93["extent"] = "343 21";
                oc_Newobject93["minExtent"] = "8 2";
                oc_Newobject93["maxExtent"] = "1920 1080";
                oc_Newobject93["horizSizing"] = "right";
                oc_Newobject93["vertSizing"] = "bottom";
                oc_Newobject93["profile"] = "GuiDefaultProfile";
                oc_Newobject93["controlFontSize"] = "14";
                oc_Newobject93["visible"] = "1";
                oc_Newobject93["active"] = "1";
                oc_Newobject93["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject93["tooltip"] = "Select a color";
                oc_Newobject93["hovertime"] = "1000";
                oc_Newobject93["isContainer"] = "0";
                oc_Newobject93["alphaValue"] = "1";
                oc_Newobject93["mouseOverAlphaValue"] = "1";
                oc_Newobject93["alphaFadeTime"] = "1000";
                oc_Newobject93["moveControl"] = "0";
                oc_Newobject93["lockControl"] = "0";
                oc_Newobject93["windowSettings"] = "1";
                oc_Newobject93["alpha"] = "1";
                oc_Newobject93["mouseOverAlpha"] = "1";
                oc_Newobject93["alphaFade"] = "1";
                oc_Newobject93["contextFontSize"] = "0";
                oc_Newobject93["editable"] = "0";
                oc_Newobject93["canSave"] = "1";
                oc_Newobject93["canSaveDynamicFields"] = "0";
                oc_Newobject93["Enabled"] = "1";
                #endregion

                oc_Newobject94["#Newobject93"] = oc_Newobject93;

                #endregion

                oc_Newobject95["#Newobject94"] = oc_Newobject94;

                #endregion

                oc_Newobject99["#Newobject95"] = oc_Newobject95;

                #region GuiCheckBoxCtrl (ppOptionsHDRToneMapping)        oc_Newobject96
                ObjectCreator oc_Newobject96 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsHDRToneMapping",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsHDRToneMapping));
                oc_Newobject96["text"] = " Enable Tone Mapping";
                oc_Newobject96["groupNum"] = "-1";
                oc_Newobject96["buttonType"] = "ToggleButton";
                oc_Newobject96["useMouseEvents"] = "0";
                oc_Newobject96["position"] = "18 8";
                oc_Newobject96["extent"] = "120 24";
                oc_Newobject96["minExtent"] = "8 2";
                oc_Newobject96["maxExtent"] = "1920 1080";
                oc_Newobject96["horizSizing"] = "right";
                oc_Newobject96["vertSizing"] = "bottom";
                oc_Newobject96["profile"] = "GuiCheckBoxProfile";
                oc_Newobject96["controlFontColor"] = "0 0 0 0";
                oc_Newobject96["backgroundColor"] = "255 255 255 255";
                oc_Newobject96["controlFontSize"] = "14";
                oc_Newobject96["visible"] = "0";
                oc_Newobject96["active"] = "1";
                oc_Newobject96["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject96["tooltip"] = "Enables or disabled tone mapping on the HDR. The tone mapping balanced the brightness levels during the HDR process. Recommended";
                oc_Newobject96["hovertime"] = "1000";
                oc_Newobject96["isContainer"] = "0";
                oc_Newobject96["alphaValue"] = "1";
                oc_Newobject96["mouseOverAlphaValue"] = "1";
                oc_Newobject96["alphaFadeTime"] = "1000";
                oc_Newobject96["windowSettings"] = "1";
                oc_Newobject96["alpha"] = "1";
                oc_Newobject96["mouseOverAlpha"] = "1";
                oc_Newobject96["alphaFade"] = "1";
                oc_Newobject96["contextFontColor"] = "0";
                oc_Newobject96["contextBackColor"] = "0";
                oc_Newobject96["contextFontSize"] = "0";
                oc_Newobject96["hidden"] = "1";
                oc_Newobject96["editable"] = "0";
                oc_Newobject96["canSave"] = "1";
                oc_Newobject96["canSaveDynamicFields"] = "0";
                oc_Newobject96["Enabled"] = "1";
                #endregion

                oc_Newobject99["#Newobject96"] = oc_Newobject96;

                #region GuiCheckBoxCtrl (ppOptionsEnableHDR)        oc_Newobject97
                ObjectCreator oc_Newobject97 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableHDR",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsEnableHDR));
                oc_Newobject97["text"] = "Enable";
                oc_Newobject97["groupNum"] = "-1";
                oc_Newobject97["buttonType"] = "ToggleButton";
                oc_Newobject97["useMouseEvents"] = "0";
                oc_Newobject97["position"] = "329 7";
                oc_Newobject97["extent"] = "53 20";
                oc_Newobject97["minExtent"] = "8 2";
                oc_Newobject97["maxExtent"] = "1920 1080";
                oc_Newobject97["horizSizing"] = "right";
                oc_Newobject97["vertSizing"] = "bottom";
                oc_Newobject97["profile"] = "GuiCheckBoxProfile";
                oc_Newobject97["controlFontColor"] = "0 0 0 0";
                oc_Newobject97["backgroundColor"] = "255 255 255 255";
                oc_Newobject97["controlFontSize"] = "14";
                oc_Newobject97["visible"] = "1";
                oc_Newobject97["active"] = "1";
                oc_Newobject97["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject97["tooltip"] = "Enable/Disable the HDR postFX (takes some time to initialise, be patient)";
                oc_Newobject97["hovertime"] = "1000";
                oc_Newobject97["isContainer"] = "0";
                oc_Newobject97["alphaValue"] = "1";
                oc_Newobject97["mouseOverAlphaValue"] = "1";
                oc_Newobject97["alphaFadeTime"] = "1000";
                oc_Newobject97["windowSettings"] = "1";
                oc_Newobject97["alpha"] = "1";
                oc_Newobject97["mouseOverAlpha"] = "1";
                oc_Newobject97["alphaFade"] = "1";
                oc_Newobject97["contextFontColor"] = "0";
                oc_Newobject97["contextBackColor"] = "0";
                oc_Newobject97["contextFontSize"] = "0";
                oc_Newobject97["editable"] = "0";
                oc_Newobject97["canSave"] = "1";
                oc_Newobject97["canSaveDynamicFields"] = "0";
                oc_Newobject97["Enabled"] = "1";
                #endregion

                oc_Newobject99["#Newobject97"] = oc_Newobject97;

                #region GuiCheckBoxCtrl (ppOptionsEnableHDRDebug)        oc_Newobject98
                ObjectCreator oc_Newobject98 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableHDRDebug",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsEnableHDRDebug));
                oc_Newobject98["text"] = "Debug";
                oc_Newobject98["groupNum"] = "-1";
                oc_Newobject98["buttonType"] = "ToggleButton";
                oc_Newobject98["useMouseEvents"] = "0";
                oc_Newobject98["position"] = "262 7";
                oc_Newobject98["extent"] = "53 20";
                oc_Newobject98["minExtent"] = "8 2";
                oc_Newobject98["maxExtent"] = "1920 1080";
                oc_Newobject98["horizSizing"] = "right";
                oc_Newobject98["vertSizing"] = "bottom";
                oc_Newobject98["profile"] = "GuiCheckBoxProfile";
                oc_Newobject98["controlFontColor"] = "0 0 0 0";
                oc_Newobject98["backgroundColor"] = "255 255 255 255";
                oc_Newobject98["controlFontSize"] = "14";
                oc_Newobject98["visible"] = "1";
                oc_Newobject98["active"] = "1";
                oc_Newobject98["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject98["hovertime"] = "1000";
                oc_Newobject98["isContainer"] = "0";
                oc_Newobject98["alphaValue"] = "1";
                oc_Newobject98["mouseOverAlphaValue"] = "1";
                oc_Newobject98["alphaFadeTime"] = "1000";
                oc_Newobject98["windowSettings"] = "1";
                oc_Newobject98["alpha"] = "1";
                oc_Newobject98["mouseOverAlpha"] = "1";
                oc_Newobject98["alphaFade"] = "1";
                oc_Newobject98["contextFontColor"] = "0";
                oc_Newobject98["contextBackColor"] = "0";
                oc_Newobject98["contextFontSize"] = "0";
                oc_Newobject98["editable"] = "0";
                oc_Newobject98["canSave"] = "1";
                oc_Newobject98["canSaveDynamicFields"] = "0";
                oc_Newobject98["Enabled"] = "1";
                #endregion

                oc_Newobject99["#Newobject98"] = oc_Newobject98;

                #endregion

                oc_Newobject150["#Newobject99"] = oc_Newobject99;

                #region GuiTabPageCtrl (ppOptionsLightRaysTab)        oc_Newobject103
                ObjectCreator oc_Newobject103 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsLightRaysTab");
                oc_Newobject103["fitBook"] = "1";
                oc_Newobject103["text"] = "Light Rays";
                oc_Newobject103["maxLength"] = "1024";
                oc_Newobject103["docking"] = "None";
                oc_Newobject103["margin"] = "0 0 0 0";
                oc_Newobject103["padding"] = "0 0 0 0";
                oc_Newobject103["anchorTop"] = "1";
                oc_Newobject103["anchorBottom"] = "1";
                oc_Newobject103["anchorLeft"] = "1";
                oc_Newobject103["anchorRight"] = "1";
                oc_Newobject103["position"] = "0 20";
                oc_Newobject103["extent"] = "525 213";
                oc_Newobject103["minExtent"] = "8 2";
                oc_Newobject103["maxExtent"] = "1920 1080";
                oc_Newobject103["horizSizing"] = "right";
                oc_Newobject103["vertSizing"] = "bottom";
                oc_Newobject103["profile"] = "GuiTabPageProfile";
                oc_Newobject103["controlFontColor"] = "0 0 0 0";
                oc_Newobject103["controlFillColor"] = "0 0 0 0";
                oc_Newobject103["backgroundColor"] = "255 255 255 255";
                oc_Newobject103["controlFontSize"] = "10";
                oc_Newobject103["visible"] = "0";
                oc_Newobject103["active"] = "1";
                oc_Newobject103["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject103["tooltip"] = "Options for the Light Rays postFX";
                oc_Newobject103["hovertime"] = "1000";
                oc_Newobject103["isContainer"] = "1";
                oc_Newobject103["alphaValue"] = "1";
                oc_Newobject103["mouseOverAlphaValue"] = "1";
                oc_Newobject103["alphaFadeTime"] = "1000";
                oc_Newobject103["moveControl"] = "0";
                oc_Newobject103["lockControl"] = "0";
                oc_Newobject103["windowSettings"] = "1";
                oc_Newobject103["alpha"] = "1";
                oc_Newobject103["mouseOverAlpha"] = "1";
                oc_Newobject103["alphaFade"] = "1";
                oc_Newobject103["contextFontColor"] = "0";
                oc_Newobject103["contextBackColor"] = "0";
                oc_Newobject103["contextFillColor"] = "0";
                oc_Newobject103["contextFontSize"] = "0";
                oc_Newobject103["hidden"] = "1";
                oc_Newobject103["editable"] = "0";
                oc_Newobject103["canSave"] = "1";
                oc_Newobject103["canSaveDynamicFields"] = "0";
                oc_Newobject103["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsLightRaysBrightScalar)        oc_Newobject100
                ObjectCreator oc_Newobject100 = new ObjectCreator("GuiSliderCtrl", "ppOptionsLightRaysBrightScalar",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsLightRaysBrightScalar));
                oc_Newobject100["range"] = "0 5";
                oc_Newobject100["ticks"] = "1000";
                oc_Newobject100["snap"] = "0";
                oc_Newobject100["value"] = "0.75";
                oc_Newobject100["position"] = "96 96";
                oc_Newobject100["extent"] = "264 17";
                oc_Newobject100["minExtent"] = "8 2";
                oc_Newobject100["maxExtent"] = "1920 1080";
                oc_Newobject100["horizSizing"] = "right";
                oc_Newobject100["vertSizing"] = "bottom";
                oc_Newobject100["profile"] = "GuiSliderBoxProfile";
                oc_Newobject100["controlFontColor"] = "0 0 0 0";
                oc_Newobject100["controlFillColor"] = "0 0 0 0";
                oc_Newobject100["backgroundColor"] = "255 255 255 255";
                oc_Newobject100["controlFontSize"] = "14";
                oc_Newobject100["visible"] = "1";
                oc_Newobject100["active"] = "1";
                oc_Newobject100["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject100["hovertime"] = "1000";
                oc_Newobject100["isContainer"] = "0";
                oc_Newobject100["alphaValue"] = "1";
                oc_Newobject100["mouseOverAlphaValue"] = "1";
                oc_Newobject100["alphaFadeTime"] = "1000";
                oc_Newobject100["windowSettings"] = "1";
                oc_Newobject100["alpha"] = "1";
                oc_Newobject100["mouseOverAlpha"] = "1";
                oc_Newobject100["alphaFade"] = "1";
                oc_Newobject100["contextFontColor"] = "0";
                oc_Newobject100["contextBackColor"] = "0";
                oc_Newobject100["contextFillColor"] = "0";
                oc_Newobject100["contextFontSize"] = "0";
                oc_Newobject100["editable"] = "0";
                oc_Newobject100["canSave"] = "1";
                oc_Newobject100["canSaveDynamicFields"] = "0";
                oc_Newobject100["Enabled"] = "1";
                #endregion

                oc_Newobject103["#Newobject100"] = oc_Newobject100;

                #region GuiTextCtrl (ppOptionsLightRaysBrightnessScalarLabel)        oc_Newobject101
                ObjectCreator oc_Newobject101 = new ObjectCreator("GuiTextCtrl", "ppOptionsLightRaysBrightnessScalarLabel");
                oc_Newobject101["text"] = "Brightness";
                oc_Newobject101["maxLength"] = "1024";
                oc_Newobject101["margin"] = "0 0 0 0";
                oc_Newobject101["padding"] = "0 0 0 0";
                oc_Newobject101["anchorTop"] = "1";
                oc_Newobject101["anchorBottom"] = "0";
                oc_Newobject101["anchorLeft"] = "1";
                oc_Newobject101["anchorRight"] = "0";
                oc_Newobject101["position"] = "26 98";
                oc_Newobject101["extent"] = "87 15";
                oc_Newobject101["minExtent"] = "8 2";
                oc_Newobject101["maxExtent"] = "1920 1080";
                oc_Newobject101["horizSizing"] = "right";
                oc_Newobject101["vertSizing"] = "bottom";
                oc_Newobject101["profile"] = "GuiTextProfile";
                oc_Newobject101["controlFontColor"] = "0 0 0 0";
                oc_Newobject101["controlFillColor"] = "0 0 0 0";
                oc_Newobject101["backgroundColor"] = "255 255 255 255";
                oc_Newobject101["controlFontSize"] = "14";
                oc_Newobject101["visible"] = "1";
                oc_Newobject101["active"] = "1";
                oc_Newobject101["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject101["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject101["hovertime"] = "1000";
                oc_Newobject101["isContainer"] = "0";
                oc_Newobject101["alphaValue"] = "1";
                oc_Newobject101["mouseOverAlphaValue"] = "1";
                oc_Newobject101["alphaFadeTime"] = "1000";
                oc_Newobject101["moveControl"] = "0";
                oc_Newobject101["lockControl"] = "0";
                oc_Newobject101["windowSettings"] = "1";
                oc_Newobject101["alpha"] = "1";
                oc_Newobject101["mouseOverAlpha"] = "1";
                oc_Newobject101["alphaFade"] = "1";
                oc_Newobject101["contextFontColor"] = "0";
                oc_Newobject101["contextBackColor"] = "0";
                oc_Newobject101["contextFillColor"] = "0";
                oc_Newobject101["contextFontSize"] = "0";
                oc_Newobject101["editable"] = "0";
                oc_Newobject101["canSave"] = "1";
                oc_Newobject101["canSaveDynamicFields"] = "0";
                oc_Newobject101["Enabled"] = "1";
                #endregion

                oc_Newobject103["#Newobject101"] = oc_Newobject101;

                #region GuiCheckBoxCtrl (ppOptionsEnableLightRays)        oc_Newobject102
                ObjectCreator oc_Newobject102 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableLightRays",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsEnableLightRays));
                oc_Newobject102["text"] = "Enable";
                oc_Newobject102["groupNum"] = "-1";
                oc_Newobject102["buttonType"] = "ToggleButton";
                oc_Newobject102["useMouseEvents"] = "0";
                oc_Newobject102["position"] = "329 7";
                oc_Newobject102["extent"] = "53 20";
                oc_Newobject102["minExtent"] = "8 2";
                oc_Newobject102["maxExtent"] = "1920 1080";
                oc_Newobject102["horizSizing"] = "right";
                oc_Newobject102["vertSizing"] = "bottom";
                oc_Newobject102["profile"] = "GuiCheckBoxProfile";
                oc_Newobject102["controlFontColor"] = "0 0 0 0";
                oc_Newobject102["backgroundColor"] = "255 255 255 255";
                oc_Newobject102["controlFontSize"] = "14";
                oc_Newobject102["visible"] = "1";
                oc_Newobject102["active"] = "1";
                oc_Newobject102["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject102["tooltip"] = "Enable/Disable the light rays postFX";
                oc_Newobject102["hovertime"] = "1000";
                oc_Newobject102["isContainer"] = "0";
                oc_Newobject102["alphaValue"] = "1";
                oc_Newobject102["mouseOverAlphaValue"] = "1";
                oc_Newobject102["alphaFadeTime"] = "1000";
                oc_Newobject102["windowSettings"] = "1";
                oc_Newobject102["alpha"] = "1";
                oc_Newobject102["mouseOverAlpha"] = "1";
                oc_Newobject102["alphaFade"] = "1";
                oc_Newobject102["contextFontColor"] = "0";
                oc_Newobject102["contextBackColor"] = "0";
                oc_Newobject102["contextFontSize"] = "0";
                oc_Newobject102["editable"] = "0";
                oc_Newobject102["canSave"] = "1";
                oc_Newobject102["canSaveDynamicFields"] = "0";
                oc_Newobject102["Enabled"] = "1";
                #endregion

                oc_Newobject103["#Newobject102"] = oc_Newobject102;

                #endregion

                oc_Newobject150["#Newobject103"] = oc_Newobject103;

                #region GuiTabPageCtrl (ppOptionsDOFTab)        oc_Newobject123
                ObjectCreator oc_Newobject123 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsDOFTab");
                oc_Newobject123["fitBook"] = "1";
                oc_Newobject123["text"] = "DOF";
                oc_Newobject123["maxLength"] = "1024";
                oc_Newobject123["docking"] = "None";
                oc_Newobject123["margin"] = "0 0 0 0";
                oc_Newobject123["padding"] = "0 0 0 0";
                oc_Newobject123["anchorTop"] = "1";
                oc_Newobject123["anchorBottom"] = "1";
                oc_Newobject123["anchorLeft"] = "1";
                oc_Newobject123["anchorRight"] = "1";
                oc_Newobject123["position"] = "0 20";
                oc_Newobject123["extent"] = "525 213";
                oc_Newobject123["minExtent"] = "8 2";
                oc_Newobject123["maxExtent"] = "1920 1080";
                oc_Newobject123["horizSizing"] = "right";
                oc_Newobject123["vertSizing"] = "bottom";
                oc_Newobject123["profile"] = "GuiTabPageProfile";
                oc_Newobject123["controlFontColor"] = "0 0 0 0";
                oc_Newobject123["controlFillColor"] = "0 0 0 0";
                oc_Newobject123["backgroundColor"] = "255 255 255 255";
                oc_Newobject123["controlFontSize"] = "10";
                oc_Newobject123["visible"] = "0";
                oc_Newobject123["active"] = "1";
                oc_Newobject123["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject123["tooltip"] = "Options for the Depth Of Field postFX";
                oc_Newobject123["hovertime"] = "1000";
                oc_Newobject123["isContainer"] = "1";
                oc_Newobject123["alphaValue"] = "1";
                oc_Newobject123["mouseOverAlphaValue"] = "1";
                oc_Newobject123["alphaFadeTime"] = "1000";
                oc_Newobject123["moveControl"] = "0";
                oc_Newobject123["lockControl"] = "0";
                oc_Newobject123["windowSettings"] = "1";
                oc_Newobject123["alpha"] = "1";
                oc_Newobject123["mouseOverAlpha"] = "1";
                oc_Newobject123["alphaFade"] = "1";
                oc_Newobject123["contextFontColor"] = "0";
                oc_Newobject123["contextBackColor"] = "0";
                oc_Newobject123["contextFillColor"] = "0";
                oc_Newobject123["contextFontSize"] = "0";
                oc_Newobject123["hidden"] = "1";
                oc_Newobject123["editable"] = "0";
                oc_Newobject123["canSave"] = "1";
                oc_Newobject123["canSaveDynamicFields"] = "0";
                oc_Newobject123["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject104
                ObjectCreator oc_Newobject104 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject104["position"] = "14 28";
                oc_Newobject104["extent"] = "362 170";
                oc_Newobject104["minExtent"] = "8 2";
                oc_Newobject104["maxExtent"] = "1920 1080";
                oc_Newobject104["horizSizing"] = "right";
                oc_Newobject104["vertSizing"] = "bottom";
                oc_Newobject104["profile"] = "GuiTabBorderProfile";
                oc_Newobject104["controlFontColor"] = "0 0 0 0";
                oc_Newobject104["controlFillColor"] = "0 0 0 0";
                oc_Newobject104["backgroundColor"] = "255 255 255 255";
                oc_Newobject104["controlFontSize"] = "14";
                oc_Newobject104["visible"] = "1";
                oc_Newobject104["active"] = "1";
                oc_Newobject104["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject104["hovertime"] = "1000";
                oc_Newobject104["isContainer"] = "0";
                oc_Newobject104["alphaValue"] = "1";
                oc_Newobject104["mouseOverAlphaValue"] = "1";
                oc_Newobject104["alphaFadeTime"] = "1000";
                oc_Newobject104["moveControl"] = "0";
                oc_Newobject104["lockControl"] = "0";
                oc_Newobject104["windowSettings"] = "1";
                oc_Newobject104["alpha"] = "1";
                oc_Newobject104["mouseOverAlpha"] = "1";
                oc_Newobject104["alphaFade"] = "1";
                oc_Newobject104["contextFontColor"] = "0";
                oc_Newobject104["contextBackColor"] = "0";
                oc_Newobject104["contextFillColor"] = "0";
                oc_Newobject104["contextFontSize"] = "0";
                oc_Newobject104["editable"] = "0";
                oc_Newobject104["canSave"] = "1";
                oc_Newobject104["canSaveDynamicFields"] = "1";
                oc_Newobject104["Enabled"] = "1";
                #endregion

                oc_Newobject123["#Newobject104"] = oc_Newobject104;

                #region GuiTabBookCtrl ()        oc_Newobject121
                ObjectCreator oc_Newobject121 = new ObjectCreator("GuiTabBookCtrl", "");
                oc_Newobject121["tabPosition"] = "Top";
                oc_Newobject121["tabMargin"] = "7";
                oc_Newobject121["minTabWidth"] = "64";
                oc_Newobject121["tabHeight"] = "20";
                oc_Newobject121["allowReorder"] = "0";
                oc_Newobject121["defaultPage"] = "-1";
                oc_Newobject121["selectedPage"] = "1";
                oc_Newobject121["frontTabPadding"] = "0";
                oc_Newobject121["margin"] = "0 0 0 0";
                oc_Newobject121["padding"] = "0 0 0 0";
                oc_Newobject121["anchorTop"] = "1";
                oc_Newobject121["anchorBottom"] = "0";
                oc_Newobject121["anchorLeft"] = "1";
                oc_Newobject121["anchorRight"] = "0";
                oc_Newobject121["position"] = "14 9";
                oc_Newobject121["extent"] = "360 189";
                oc_Newobject121["minExtent"] = "8 2";
                oc_Newobject121["maxExtent"] = "1920 1080";
                oc_Newobject121["horizSizing"] = "right";
                oc_Newobject121["vertSizing"] = "bottom";
                oc_Newobject121["profile"] = "GuiTabBookProfile";
                oc_Newobject121["controlFontColor"] = "0 0 0 0";
                oc_Newobject121["controlFillColor"] = "0 0 0 0";
                oc_Newobject121["backgroundColor"] = "255 255 255 255";
                oc_Newobject121["controlFontSize"] = "14";
                oc_Newobject121["visible"] = "1";
                oc_Newobject121["active"] = "1";
                oc_Newobject121["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject121["hovertime"] = "1000";
                oc_Newobject121["isContainer"] = "1";
                oc_Newobject121["alphaValue"] = "1";
                oc_Newobject121["mouseOverAlphaValue"] = "1";
                oc_Newobject121["alphaFadeTime"] = "1000";
                oc_Newobject121["windowSettings"] = "1";
                oc_Newobject121["alpha"] = "1";
                oc_Newobject121["mouseOverAlpha"] = "1";
                oc_Newobject121["alphaFade"] = "1";
                oc_Newobject121["contextFontColor"] = "0";
                oc_Newobject121["contextBackColor"] = "0";
                oc_Newobject121["contextFillColor"] = "0";
                oc_Newobject121["contextFontSize"] = "0";
                oc_Newobject121["editable"] = "0";
                oc_Newobject121["canSave"] = "1";
                oc_Newobject121["canSaveDynamicFields"] = "0";
                oc_Newobject121["Enabled"] = "1";

                #region GuiTabPageCtrl (ppOptionsDOFGeneralTab)        oc_Newobject107
                ObjectCreator oc_Newobject107 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsDOFGeneralTab");
                oc_Newobject107["fitBook"] = "1";
                oc_Newobject107["text"] = "General";
                oc_Newobject107["maxLength"] = "1024";
                oc_Newobject107["docking"] = "None";
                oc_Newobject107["margin"] = "0 0 0 0";
                oc_Newobject107["padding"] = "0 0 0 0";
                oc_Newobject107["anchorTop"] = "1";
                oc_Newobject107["anchorBottom"] = "1";
                oc_Newobject107["anchorLeft"] = "1";
                oc_Newobject107["anchorRight"] = "1";
                oc_Newobject107["position"] = "0 20";
                oc_Newobject107["extent"] = "360 169";
                oc_Newobject107["minExtent"] = "8 2";
                oc_Newobject107["maxExtent"] = "1920 1080";
                oc_Newobject107["horizSizing"] = "right";
                oc_Newobject107["vertSizing"] = "bottom";
                oc_Newobject107["profile"] = "GuiTabPageProfile";
                oc_Newobject107["controlFontColor"] = "0 0 0 0";
                oc_Newobject107["controlFillColor"] = "0 0 0 0";
                oc_Newobject107["backgroundColor"] = "255 255 255 255";
                oc_Newobject107["controlFontSize"] = "10";
                oc_Newobject107["visible"] = "0";
                oc_Newobject107["active"] = "1";
                oc_Newobject107["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject107["tooltip"] = "Contains general settings related to the DOF system";
                oc_Newobject107["hovertime"] = "1000";
                oc_Newobject107["isContainer"] = "1";
                oc_Newobject107["alphaValue"] = "1";
                oc_Newobject107["mouseOverAlphaValue"] = "1";
                oc_Newobject107["alphaFadeTime"] = "1000";
                oc_Newobject107["moveControl"] = "0";
                oc_Newobject107["lockControl"] = "0";
                oc_Newobject107["windowSettings"] = "1";
                oc_Newobject107["alpha"] = "1";
                oc_Newobject107["mouseOverAlpha"] = "1";
                oc_Newobject107["alphaFade"] = "1";
                oc_Newobject107["contextFontColor"] = "0";
                oc_Newobject107["contextBackColor"] = "0";
                oc_Newobject107["contextFillColor"] = "0";
                oc_Newobject107["contextFontSize"] = "0";
                oc_Newobject107["hidden"] = "1";
                oc_Newobject107["editable"] = "0";
                oc_Newobject107["canSave"] = "1";
                oc_Newobject107["canSaveDynamicFields"] = "0";
                oc_Newobject107["Enabled"] = "1";

                #region GuiCheckBoxCtrl (ppOptionsDOFEnableDOF)        oc_Newobject105
                ObjectCreator oc_Newobject105 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsDOFEnableDOF");
                oc_Newobject105["text"] = "Enable DOF";
                oc_Newobject105["groupNum"] = "-1";
                oc_Newobject105["buttonType"] = "ToggleButton";
                oc_Newobject105["useMouseEvents"] = "0";
                oc_Newobject105["position"] = "31 43";
                oc_Newobject105["extent"] = "140 30";
                oc_Newobject105["minExtent"] = "8 2";
                oc_Newobject105["maxExtent"] = "1920 1080";
                oc_Newobject105["horizSizing"] = "right";
                oc_Newobject105["vertSizing"] = "bottom";
                oc_Newobject105["profile"] = "GuiCheckBoxProfile";
                oc_Newobject105["controlFontColor"] = "0 0 0 0";
                oc_Newobject105["backgroundColor"] = "255 255 255 255";
                oc_Newobject105["controlFontSize"] = "14";
                oc_Newobject105["visible"] = "1";
                oc_Newobject105["active"] = "1";
                oc_Newobject105["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject105["hovertime"] = "1000";
                oc_Newobject105["isContainer"] = "0";
                oc_Newobject105["alphaValue"] = "1";
                oc_Newobject105["mouseOverAlphaValue"] = "1";
                oc_Newobject105["alphaFadeTime"] = "1000";
                oc_Newobject105["windowSettings"] = "1";
                oc_Newobject105["alpha"] = "1";
                oc_Newobject105["mouseOverAlpha"] = "1";
                oc_Newobject105["alphaFade"] = "1";
                oc_Newobject105["contextFontColor"] = "0";
                oc_Newobject105["contextBackColor"] = "0";
                oc_Newobject105["contextFontSize"] = "0";
                oc_Newobject105["editable"] = "0";
                oc_Newobject105["canSave"] = "1";
                oc_Newobject105["canSaveDynamicFields"] = "0";
                oc_Newobject105["Enabled"] = "1";
                #endregion

                oc_Newobject107["#Newobject105"] = oc_Newobject105;

                #region GuiCheckBoxCtrl (ppOptionsDOFEnableAutoFocus)        oc_Newobject106
                ObjectCreator oc_Newobject106 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsDOFEnableAutoFocus",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFEnableAutoFocus));
                oc_Newobject106["text"] = "Enable Auto Focus";
                oc_Newobject106["groupNum"] = "-1";
                oc_Newobject106["buttonType"] = "ToggleButton";
                oc_Newobject106["useMouseEvents"] = "0";
                oc_Newobject106["position"] = "31 89";
                oc_Newobject106["extent"] = "140 30";
                oc_Newobject106["minExtent"] = "8 2";
                oc_Newobject106["maxExtent"] = "1920 1080";
                oc_Newobject106["horizSizing"] = "right";
                oc_Newobject106["vertSizing"] = "bottom";
                oc_Newobject106["profile"] = "GuiCheckBoxProfile";
                oc_Newobject106["controlFontColor"] = "0 0 0 0";
                oc_Newobject106["backgroundColor"] = "255 255 255 255";
                oc_Newobject106["controlFontSize"] = "14";
                oc_Newobject106["visible"] = "1";
                oc_Newobject106["active"] = "1";
                oc_Newobject106["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject106["hovertime"] = "1000";
                oc_Newobject106["isContainer"] = "0";
                oc_Newobject106["alphaValue"] = "1";
                oc_Newobject106["mouseOverAlphaValue"] = "1";
                oc_Newobject106["alphaFadeTime"] = "1000";
                oc_Newobject106["windowSettings"] = "1";
                oc_Newobject106["alpha"] = "1";
                oc_Newobject106["mouseOverAlpha"] = "1";
                oc_Newobject106["alphaFade"] = "1";
                oc_Newobject106["contextFontColor"] = "0";
                oc_Newobject106["contextBackColor"] = "0";
                oc_Newobject106["contextFontSize"] = "0";
                oc_Newobject106["editable"] = "0";
                oc_Newobject106["canSave"] = "1";
                oc_Newobject106["canSaveDynamicFields"] = "0";
                oc_Newobject106["Enabled"] = "1";
                #endregion

                oc_Newobject107["#Newobject106"] = oc_Newobject106;

                #endregion

                oc_Newobject121["#Newobject107"] = oc_Newobject107;

                #region GuiTabPageCtrl (ppOptionsDOFAutoFocusTab)        oc_Newobject120
                ObjectCreator oc_Newobject120 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsDOFAutoFocusTab");
                oc_Newobject120["fitBook"] = "1";
                oc_Newobject120["text"] = "Auto Focus";
                oc_Newobject120["maxLength"] = "1024";
                oc_Newobject120["docking"] = "None";
                oc_Newobject120["margin"] = "0 0 0 0";
                oc_Newobject120["padding"] = "0 0 0 0";
                oc_Newobject120["anchorTop"] = "1";
                oc_Newobject120["anchorBottom"] = "1";
                oc_Newobject120["anchorLeft"] = "1";
                oc_Newobject120["anchorRight"] = "1";
                oc_Newobject120["position"] = "0 20";
                oc_Newobject120["extent"] = "360 169";
                oc_Newobject120["minExtent"] = "8 2";
                oc_Newobject120["maxExtent"] = "1920 1080";
                oc_Newobject120["horizSizing"] = "right";
                oc_Newobject120["vertSizing"] = "bottom";
                oc_Newobject120["profile"] = "GuiTabPageProfile";
                oc_Newobject120["controlFontColor"] = "0 0 0 0";
                oc_Newobject120["controlFillColor"] = "0 0 0 0";
                oc_Newobject120["backgroundColor"] = "255 255 255 255";
                oc_Newobject120["controlFontSize"] = "10";
                oc_Newobject120["visible"] = "1";
                oc_Newobject120["active"] = "1";
                oc_Newobject120["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject120["tooltip"] = "Contains settings related to the fine control of the auto focus system";
                oc_Newobject120["hovertime"] = "1000";
                oc_Newobject120["isContainer"] = "1";
                oc_Newobject120["alphaValue"] = "1";
                oc_Newobject120["mouseOverAlphaValue"] = "1";
                oc_Newobject120["alphaFadeTime"] = "1000";
                oc_Newobject120["moveControl"] = "0";
                oc_Newobject120["lockControl"] = "0";
                oc_Newobject120["windowSettings"] = "1";
                oc_Newobject120["alpha"] = "1";
                oc_Newobject120["mouseOverAlpha"] = "1";
                oc_Newobject120["alphaFade"] = "1";
                oc_Newobject120["contextFontColor"] = "0";
                oc_Newobject120["contextBackColor"] = "0";
                oc_Newobject120["contextFillColor"] = "0";
                oc_Newobject120["contextFontSize"] = "0";
                oc_Newobject120["editable"] = "0";
                oc_Newobject120["canSave"] = "1";
                oc_Newobject120["canSaveDynamicFields"] = "0";
                oc_Newobject120["Enabled"] = "1";

                #region GuiTextCtrl (ppOptionsDOFNearBlurMaxLabel)        oc_Newobject108
                ObjectCreator oc_Newobject108 = new ObjectCreator("GuiTextCtrl", "ppOptionsDOFNearBlurMaxLabel");
                oc_Newobject108["text"] = "Near Blur Max";
                oc_Newobject108["maxLength"] = "1024";
                oc_Newobject108["margin"] = "0 0 0 0";
                oc_Newobject108["padding"] = "0 0 0 0";
                oc_Newobject108["anchorTop"] = "1";
                oc_Newobject108["anchorBottom"] = "0";
                oc_Newobject108["anchorLeft"] = "1";
                oc_Newobject108["anchorRight"] = "0";
                oc_Newobject108["position"] = "36 8";
                oc_Newobject108["extent"] = "67 16";
                oc_Newobject108["minExtent"] = "8 2";
                oc_Newobject108["maxExtent"] = "1920 1080";
                oc_Newobject108["horizSizing"] = "right";
                oc_Newobject108["vertSizing"] = "bottom";
                oc_Newobject108["profile"] = "GuiTextProfile";
                oc_Newobject108["controlFontColor"] = "0 0 0 0";
                oc_Newobject108["controlFillColor"] = "0 0 0 0";
                oc_Newobject108["backgroundColor"] = "255 255 255 255";
                oc_Newobject108["controlFontSize"] = "14";
                oc_Newobject108["visible"] = "1";
                oc_Newobject108["active"] = "1";
                oc_Newobject108["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject108["tooltip"] = "The max allowed value of near blur";
                oc_Newobject108["hovertime"] = "1000";
                oc_Newobject108["isContainer"] = "0";
                oc_Newobject108["alphaValue"] = "1";
                oc_Newobject108["mouseOverAlphaValue"] = "1";
                oc_Newobject108["alphaFadeTime"] = "1000";
                oc_Newobject108["moveControl"] = "0";
                oc_Newobject108["lockControl"] = "0";
                oc_Newobject108["windowSettings"] = "1";
                oc_Newobject108["alpha"] = "1";
                oc_Newobject108["mouseOverAlpha"] = "1";
                oc_Newobject108["alphaFade"] = "1";
                oc_Newobject108["contextFontColor"] = "0";
                oc_Newobject108["contextBackColor"] = "0";
                oc_Newobject108["contextFillColor"] = "0";
                oc_Newobject108["contextFontSize"] = "0";
                oc_Newobject108["editable"] = "0";
                oc_Newobject108["canSave"] = "1";
                oc_Newobject108["canSaveDynamicFields"] = "0";
                oc_Newobject108["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject108"] = oc_Newobject108;

                #region GuiSliderCtrl (ppOptionsDOFFarBlurMinSlider)        oc_Newobject109
                ObjectCreator oc_Newobject109 = new ObjectCreator("GuiSliderCtrl", "ppOptionsDOFFarBlurMinSlider",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFFarBlurMinSlider));
                oc_Newobject109["range"] = "0 1";
                oc_Newobject109["ticks"] = "1000";
                oc_Newobject109["snap"] = "0";
                oc_Newobject109["value"] = "0";
                oc_Newobject109["position"] = "120 8";
                oc_Newobject109["extent"] = "224 17";
                oc_Newobject109["minExtent"] = "8 2";
                oc_Newobject109["maxExtent"] = "1920 1080";
                oc_Newobject109["horizSizing"] = "right";
                oc_Newobject109["vertSizing"] = "bottom";
                oc_Newobject109["profile"] = "GuiSliderBoxProfile";
                oc_Newobject109["controlFontColor"] = "0 0 0 0";
                oc_Newobject109["controlFillColor"] = "0 0 0 0";
                oc_Newobject109["backgroundColor"] = "255 255 255 255";
                oc_Newobject109["controlFontSize"] = "14";
                oc_Newobject109["visible"] = "1";
                oc_Newobject109["active"] = "1";
                oc_Newobject109["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject109["hovertime"] = "1000";
                oc_Newobject109["isContainer"] = "0";
                oc_Newobject109["alphaValue"] = "1";
                oc_Newobject109["mouseOverAlphaValue"] = "1";
                oc_Newobject109["alphaFadeTime"] = "1000";
                oc_Newobject109["windowSettings"] = "1";
                oc_Newobject109["alpha"] = "1";
                oc_Newobject109["mouseOverAlpha"] = "1";
                oc_Newobject109["alphaFade"] = "1";
                oc_Newobject109["contextFontColor"] = "0";
                oc_Newobject109["contextBackColor"] = "0";
                oc_Newobject109["contextFillColor"] = "0";
                oc_Newobject109["contextFontSize"] = "0";
                oc_Newobject109["editable"] = "0";
                oc_Newobject109["canSave"] = "1";
                oc_Newobject109["canSaveDynamicFields"] = "0";
                oc_Newobject109["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject109"] = oc_Newobject109;

                #region GuiTextCtrl (ppOptionsDOFFarBlurMaxLabel)        oc_Newobject110
                ObjectCreator oc_Newobject110 = new ObjectCreator("GuiTextCtrl", "ppOptionsDOFFarBlurMaxLabel");
                oc_Newobject110["text"] = "Far Blur Max";
                oc_Newobject110["maxLength"] = "1024";
                oc_Newobject110["margin"] = "0 0 0 0";
                oc_Newobject110["padding"] = "0 0 0 0";
                oc_Newobject110["anchorTop"] = "1";
                oc_Newobject110["anchorBottom"] = "0";
                oc_Newobject110["anchorLeft"] = "1";
                oc_Newobject110["anchorRight"] = "0";
                oc_Newobject110["position"] = "43 34";
                oc_Newobject110["extent"] = "60 16";
                oc_Newobject110["minExtent"] = "8 2";
                oc_Newobject110["maxExtent"] = "1920 1080";
                oc_Newobject110["horizSizing"] = "right";
                oc_Newobject110["vertSizing"] = "bottom";
                oc_Newobject110["profile"] = "GuiTextProfile";
                oc_Newobject110["controlFontColor"] = "0 0 0 0";
                oc_Newobject110["controlFillColor"] = "0 0 0 0";
                oc_Newobject110["backgroundColor"] = "255 255 255 255";
                oc_Newobject110["controlFontSize"] = "14";
                oc_Newobject110["visible"] = "1";
                oc_Newobject110["active"] = "1";
                oc_Newobject110["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject110["tooltip"] = "The max allowed value of far blur";
                oc_Newobject110["hovertime"] = "1000";
                oc_Newobject110["isContainer"] = "0";
                oc_Newobject110["alphaValue"] = "1";
                oc_Newobject110["mouseOverAlphaValue"] = "1";
                oc_Newobject110["alphaFadeTime"] = "1000";
                oc_Newobject110["moveControl"] = "0";
                oc_Newobject110["lockControl"] = "0";
                oc_Newobject110["windowSettings"] = "1";
                oc_Newobject110["alpha"] = "1";
                oc_Newobject110["mouseOverAlpha"] = "1";
                oc_Newobject110["alphaFade"] = "1";
                oc_Newobject110["contextFontColor"] = "0";
                oc_Newobject110["contextBackColor"] = "0";
                oc_Newobject110["contextFillColor"] = "0";
                oc_Newobject110["contextFontSize"] = "0";
                oc_Newobject110["editable"] = "0";
                oc_Newobject110["canSave"] = "1";
                oc_Newobject110["canSaveDynamicFields"] = "0";
                oc_Newobject110["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject110"] = oc_Newobject110;

                #region GuiSliderCtrl (ppOptionsDOFFarBlurMaxSlider)        oc_Newobject111
                ObjectCreator oc_Newobject111 = new ObjectCreator("GuiSliderCtrl", "ppOptionsDOFFarBlurMaxSlider",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFFarBlurMaxSlider));
                oc_Newobject111["range"] = "0 1";
                oc_Newobject111["ticks"] = "1000";
                oc_Newobject111["snap"] = "0";
                oc_Newobject111["value"] = "0";
                oc_Newobject111["position"] = "120 34";
                oc_Newobject111["extent"] = "224 17";
                oc_Newobject111["minExtent"] = "8 2";
                oc_Newobject111["maxExtent"] = "1920 1080";
                oc_Newobject111["horizSizing"] = "right";
                oc_Newobject111["vertSizing"] = "bottom";
                oc_Newobject111["profile"] = "GuiSliderBoxProfile";
                oc_Newobject111["controlFontColor"] = "0 0 0 0";
                oc_Newobject111["controlFillColor"] = "0 0 0 0";
                oc_Newobject111["backgroundColor"] = "255 255 255 255";
                oc_Newobject111["controlFontSize"] = "14";
                oc_Newobject111["visible"] = "1";
                oc_Newobject111["active"] = "1";
                oc_Newobject111["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject111["hovertime"] = "1000";
                oc_Newobject111["isContainer"] = "0";
                oc_Newobject111["alphaValue"] = "1";
                oc_Newobject111["mouseOverAlphaValue"] = "1";
                oc_Newobject111["alphaFadeTime"] = "1000";
                oc_Newobject111["windowSettings"] = "1";
                oc_Newobject111["alpha"] = "1";
                oc_Newobject111["mouseOverAlpha"] = "1";
                oc_Newobject111["alphaFade"] = "1";
                oc_Newobject111["contextFontColor"] = "0";
                oc_Newobject111["contextBackColor"] = "0";
                oc_Newobject111["contextFillColor"] = "0";
                oc_Newobject111["contextFontSize"] = "0";
                oc_Newobject111["editable"] = "0";
                oc_Newobject111["canSave"] = "1";
                oc_Newobject111["canSaveDynamicFields"] = "0";
                oc_Newobject111["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject111"] = oc_Newobject111;

                #region GuiTextCtrl (ppOptionsDOFFocusRangeMinLabel)        oc_Newobject112
                ObjectCreator oc_Newobject112 = new ObjectCreator("GuiTextCtrl", "ppOptionsDOFFocusRangeMinLabel");
                oc_Newobject112["text"] = "Focus Range (Min)";
                oc_Newobject112["maxLength"] = "1024";
                oc_Newobject112["margin"] = "0 0 0 0";
                oc_Newobject112["padding"] = "0 0 0 0";
                oc_Newobject112["anchorTop"] = "1";
                oc_Newobject112["anchorBottom"] = "0";
                oc_Newobject112["anchorLeft"] = "1";
                oc_Newobject112["anchorRight"] = "0";
                oc_Newobject112["position"] = "13 61";
                oc_Newobject112["extent"] = "90 16";
                oc_Newobject112["minExtent"] = "8 2";
                oc_Newobject112["maxExtent"] = "1920 1080";
                oc_Newobject112["horizSizing"] = "right";
                oc_Newobject112["vertSizing"] = "bottom";
                oc_Newobject112["profile"] = "GuiTextProfile";
                oc_Newobject112["controlFontColor"] = "0 0 0 0";
                oc_Newobject112["controlFillColor"] = "0 0 0 0";
                oc_Newobject112["backgroundColor"] = "255 255 255 255";
                oc_Newobject112["controlFontSize"] = "14";
                oc_Newobject112["visible"] = "1";
                oc_Newobject112["active"] = "1";
                oc_Newobject112["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject112["tooltip"] = "The distance range around the focal distance that remains in focus (in meters, minimum distance in focus) focal distance it is\\r\\ndependant on the visible distance set in your level";
                oc_Newobject112["hovertime"] = "1000";
                oc_Newobject112["isContainer"] = "0";
                oc_Newobject112["alphaValue"] = "1";
                oc_Newobject112["mouseOverAlphaValue"] = "1";
                oc_Newobject112["alphaFadeTime"] = "1000";
                oc_Newobject112["moveControl"] = "0";
                oc_Newobject112["lockControl"] = "0";
                oc_Newobject112["windowSettings"] = "1";
                oc_Newobject112["alpha"] = "1";
                oc_Newobject112["mouseOverAlpha"] = "1";
                oc_Newobject112["alphaFade"] = "1";
                oc_Newobject112["contextFontColor"] = "0";
                oc_Newobject112["contextBackColor"] = "0";
                oc_Newobject112["contextFillColor"] = "0";
                oc_Newobject112["contextFontSize"] = "0";
                oc_Newobject112["editable"] = "0";
                oc_Newobject112["canSave"] = "1";
                oc_Newobject112["canSaveDynamicFields"] = "0";
                oc_Newobject112["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject112"] = oc_Newobject112;

                #region GuiSliderCtrl (ppOptionsDOFFocusRangeMinSlider)        oc_Newobject113
                ObjectCreator oc_Newobject113 = new ObjectCreator("GuiSliderCtrl", "ppOptionsDOFFocusRangeMinSlider",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFFocusRangeMinSlider
                    ));
                oc_Newobject113["range"] = "0.01 1000";
                oc_Newobject113["ticks"] = "1000";
                oc_Newobject113["snap"] = "0";
                oc_Newobject113["value"] = "0.01";
                oc_Newobject113["position"] = "120 61";
                oc_Newobject113["extent"] = "224 17";
                oc_Newobject113["minExtent"] = "8 2";
                oc_Newobject113["maxExtent"] = "1920 1080";
                oc_Newobject113["horizSizing"] = "right";
                oc_Newobject113["vertSizing"] = "bottom";
                oc_Newobject113["profile"] = "GuiSliderBoxProfile";
                oc_Newobject113["controlFontColor"] = "0 0 0 0";
                oc_Newobject113["controlFillColor"] = "0 0 0 0";
                oc_Newobject113["backgroundColor"] = "255 255 255 255";
                oc_Newobject113["controlFontSize"] = "14";
                oc_Newobject113["visible"] = "1";
                oc_Newobject113["active"] = "1";
                oc_Newobject113["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject113["hovertime"] = "1000";
                oc_Newobject113["isContainer"] = "0";
                oc_Newobject113["alphaValue"] = "1";
                oc_Newobject113["mouseOverAlphaValue"] = "1";
                oc_Newobject113["alphaFadeTime"] = "1000";
                oc_Newobject113["windowSettings"] = "1";
                oc_Newobject113["alpha"] = "1";
                oc_Newobject113["mouseOverAlpha"] = "1";
                oc_Newobject113["alphaFade"] = "1";
                oc_Newobject113["contextFontColor"] = "0";
                oc_Newobject113["contextBackColor"] = "0";
                oc_Newobject113["contextFillColor"] = "0";
                oc_Newobject113["contextFontSize"] = "0";
                oc_Newobject113["editable"] = "0";
                oc_Newobject113["canSave"] = "1";
                oc_Newobject113["canSaveDynamicFields"] = "0";
                oc_Newobject113["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject113"] = oc_Newobject113;

                #region GuiTextCtrl (ppOptionsDOFFocusRangeMaxLabel)        oc_Newobject114
                ObjectCreator oc_Newobject114 = new ObjectCreator("GuiTextCtrl", "ppOptionsDOFFocusRangeMaxLabel");
                oc_Newobject114["text"] = "Focus Range (Max)";
                oc_Newobject114["maxLength"] = "1024";
                oc_Newobject114["margin"] = "0 0 0 0";
                oc_Newobject114["padding"] = "0 0 0 0";
                oc_Newobject114["anchorTop"] = "1";
                oc_Newobject114["anchorBottom"] = "0";
                oc_Newobject114["anchorLeft"] = "1";
                oc_Newobject114["anchorRight"] = "0";
                oc_Newobject114["position"] = "9 88";
                oc_Newobject114["extent"] = "95 16";
                oc_Newobject114["minExtent"] = "8 2";
                oc_Newobject114["maxExtent"] = "1920 1080";
                oc_Newobject114["horizSizing"] = "right";
                oc_Newobject114["vertSizing"] = "bottom";
                oc_Newobject114["profile"] = "GuiTextProfile";
                oc_Newobject114["controlFontColor"] = "0 0 0 0";
                oc_Newobject114["controlFillColor"] = "0 0 0 0";
                oc_Newobject114["backgroundColor"] = "255 255 255 255";
                oc_Newobject114["controlFontSize"] = "14";
                oc_Newobject114["visible"] = "1";
                oc_Newobject114["active"] = "1";
                oc_Newobject114["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject114["tooltip"] = "The distance range around the focal distance that remains in focus (in meters, maximum distance in focus) focal distance it is\\r\\ndependant on the visible distance set in your level";
                oc_Newobject114["hovertime"] = "1000";
                oc_Newobject114["isContainer"] = "0";
                oc_Newobject114["alphaValue"] = "1";
                oc_Newobject114["mouseOverAlphaValue"] = "1";
                oc_Newobject114["alphaFadeTime"] = "1000";
                oc_Newobject114["moveControl"] = "0";
                oc_Newobject114["lockControl"] = "0";
                oc_Newobject114["windowSettings"] = "1";
                oc_Newobject114["alpha"] = "1";
                oc_Newobject114["mouseOverAlpha"] = "1";
                oc_Newobject114["alphaFade"] = "1";
                oc_Newobject114["contextFontColor"] = "0";
                oc_Newobject114["contextBackColor"] = "0";
                oc_Newobject114["contextFillColor"] = "0";
                oc_Newobject114["contextFontSize"] = "0";
                oc_Newobject114["editable"] = "0";
                oc_Newobject114["canSave"] = "1";
                oc_Newobject114["canSaveDynamicFields"] = "0";
                oc_Newobject114["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject114"] = oc_Newobject114;

                #region GuiSliderCtrl (ppOptionsDOFFocusRangeMaxSlider)        oc_Newobject115
                ObjectCreator oc_Newobject115 = new ObjectCreator("GuiSliderCtrl", "ppOptionsDOFFocusRangeMaxSlider",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFFocusRangeMaxSlider
                    ));
                oc_Newobject115["range"] = "0.01 1000";
                oc_Newobject115["ticks"] = "1000";
                oc_Newobject115["snap"] = "0";
                oc_Newobject115["value"] = "0.01";
                oc_Newobject115["position"] = "119 87";
                oc_Newobject115["extent"] = "224 17";
                oc_Newobject115["minExtent"] = "8 2";
                oc_Newobject115["maxExtent"] = "1920 1080";
                oc_Newobject115["horizSizing"] = "right";
                oc_Newobject115["vertSizing"] = "bottom";
                oc_Newobject115["profile"] = "GuiSliderBoxProfile";
                oc_Newobject115["controlFontColor"] = "0 0 0 0";
                oc_Newobject115["controlFillColor"] = "0 0 0 0";
                oc_Newobject115["backgroundColor"] = "255 255 255 255";
                oc_Newobject115["controlFontSize"] = "14";
                oc_Newobject115["visible"] = "1";
                oc_Newobject115["active"] = "1";
                oc_Newobject115["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject115["hovertime"] = "1000";
                oc_Newobject115["isContainer"] = "0";
                oc_Newobject115["alphaValue"] = "1";
                oc_Newobject115["mouseOverAlphaValue"] = "1";
                oc_Newobject115["alphaFadeTime"] = "1000";
                oc_Newobject115["windowSettings"] = "1";
                oc_Newobject115["alpha"] = "1";
                oc_Newobject115["mouseOverAlpha"] = "1";
                oc_Newobject115["alphaFade"] = "1";
                oc_Newobject115["contextFontColor"] = "0";
                oc_Newobject115["contextBackColor"] = "0";
                oc_Newobject115["contextFillColor"] = "0";
                oc_Newobject115["contextFontSize"] = "0";
                oc_Newobject115["editable"] = "0";
                oc_Newobject115["canSave"] = "1";
                oc_Newobject115["canSaveDynamicFields"] = "0";
                oc_Newobject115["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject115"] = oc_Newobject115;

                #region GuiTextCtrl (ppOptionsDOFBurCurveNearLabel)        oc_Newobject116
                ObjectCreator oc_Newobject116 = new ObjectCreator("GuiTextCtrl", "ppOptionsDOFBurCurveNearLabel");
                oc_Newobject116["text"] = "Blur Curve Near";
                oc_Newobject116["maxLength"] = "1024";
                oc_Newobject116["margin"] = "0 0 0 0";
                oc_Newobject116["padding"] = "0 0 0 0";
                oc_Newobject116["anchorTop"] = "1";
                oc_Newobject116["anchorBottom"] = "0";
                oc_Newobject116["anchorLeft"] = "1";
                oc_Newobject116["anchorRight"] = "0";
                oc_Newobject116["position"] = "27 114";
                oc_Newobject116["extent"] = "77 16";
                oc_Newobject116["minExtent"] = "8 2";
                oc_Newobject116["maxExtent"] = "1920 1080";
                oc_Newobject116["horizSizing"] = "right";
                oc_Newobject116["vertSizing"] = "bottom";
                oc_Newobject116["profile"] = "GuiTextProfile";
                oc_Newobject116["controlFontColor"] = "0 0 0 0";
                oc_Newobject116["controlFillColor"] = "0 0 0 0";
                oc_Newobject116["backgroundColor"] = "255 255 255 255";
                oc_Newobject116["controlFontSize"] = "14";
                oc_Newobject116["visible"] = "1";
                oc_Newobject116["active"] = "1";
                oc_Newobject116["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject116["tooltip"] = "A small number causes bluriness to increase gradually\\r\\nat distances closer than the focal distance. A large number causes bluriness to \\r\\nincrease quickly";
                oc_Newobject116["hovertime"] = "1000";
                oc_Newobject116["isContainer"] = "0";
                oc_Newobject116["alphaValue"] = "1";
                oc_Newobject116["mouseOverAlphaValue"] = "1";
                oc_Newobject116["alphaFadeTime"] = "1000";
                oc_Newobject116["moveControl"] = "0";
                oc_Newobject116["lockControl"] = "0";
                oc_Newobject116["windowSettings"] = "1";
                oc_Newobject116["alpha"] = "1";
                oc_Newobject116["mouseOverAlpha"] = "1";
                oc_Newobject116["alphaFade"] = "1";
                oc_Newobject116["contextFontColor"] = "0";
                oc_Newobject116["contextBackColor"] = "0";
                oc_Newobject116["contextFillColor"] = "0";
                oc_Newobject116["contextFontSize"] = "0";
                oc_Newobject116["editable"] = "0";
                oc_Newobject116["canSave"] = "1";
                oc_Newobject116["canSaveDynamicFields"] = "0";
                oc_Newobject116["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject116"] = oc_Newobject116;

                #region GuiSliderCtrl (ppOptionsDOFBlurCurveNearSlider)        oc_Newobject117
                ObjectCreator oc_Newobject117 = new ObjectCreator("GuiSliderCtrl", "ppOptionsDOFBlurCurveNearSlider",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFBlurCurveNearSlider
                    ));
                oc_Newobject117["range"] = "0 50";
                oc_Newobject117["ticks"] = "1000";
                oc_Newobject117["snap"] = "0";
                oc_Newobject117["value"] = "0";
                oc_Newobject117["position"] = "119 114";
                oc_Newobject117["extent"] = "225 17";
                oc_Newobject117["minExtent"] = "8 2";
                oc_Newobject117["maxExtent"] = "1920 1080";
                oc_Newobject117["horizSizing"] = "right";
                oc_Newobject117["vertSizing"] = "bottom";
                oc_Newobject117["profile"] = "GuiSliderBoxProfile";
                oc_Newobject117["controlFontColor"] = "0 0 0 0";
                oc_Newobject117["controlFillColor"] = "0 0 0 0";
                oc_Newobject117["backgroundColor"] = "255 255 255 255";
                oc_Newobject117["controlFontSize"] = "14";
                oc_Newobject117["visible"] = "1";
                oc_Newobject117["active"] = "1";
                oc_Newobject117["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject117["hovertime"] = "1000";
                oc_Newobject117["isContainer"] = "0";
                oc_Newobject117["alphaValue"] = "1";
                oc_Newobject117["mouseOverAlphaValue"] = "1";
                oc_Newobject117["alphaFadeTime"] = "1000";
                oc_Newobject117["windowSettings"] = "1";
                oc_Newobject117["alpha"] = "1";
                oc_Newobject117["mouseOverAlpha"] = "1";
                oc_Newobject117["alphaFade"] = "1";
                oc_Newobject117["contextFontColor"] = "0";
                oc_Newobject117["contextBackColor"] = "0";
                oc_Newobject117["contextFillColor"] = "0";
                oc_Newobject117["contextFontSize"] = "0";
                oc_Newobject117["editable"] = "0";
                oc_Newobject117["canSave"] = "1";
                oc_Newobject117["canSaveDynamicFields"] = "0";
                oc_Newobject117["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject117"] = oc_Newobject117;

                #region GuiTextCtrl (ppOptionsDOFBlurCurveFarLabel)        oc_Newobject118
                ObjectCreator oc_Newobject118 = new ObjectCreator("GuiTextCtrl", "ppOptionsDOFBlurCurveFarLabel");
                oc_Newobject118["text"] = "Blur Curve Far";
                oc_Newobject118["maxLength"] = "1024";
                oc_Newobject118["margin"] = "0 0 0 0";
                oc_Newobject118["padding"] = "0 0 0 0";
                oc_Newobject118["anchorTop"] = "1";
                oc_Newobject118["anchorBottom"] = "0";
                oc_Newobject118["anchorLeft"] = "1";
                oc_Newobject118["anchorRight"] = "0";
                oc_Newobject118["position"] = "33 139";
                oc_Newobject118["extent"] = "70 16";
                oc_Newobject118["minExtent"] = "8 2";
                oc_Newobject118["maxExtent"] = "1920 1080";
                oc_Newobject118["horizSizing"] = "right";
                oc_Newobject118["vertSizing"] = "bottom";
                oc_Newobject118["profile"] = "GuiTextProfile";
                oc_Newobject118["controlFontColor"] = "0 0 0 0";
                oc_Newobject118["controlFillColor"] = "0 0 0 0";
                oc_Newobject118["backgroundColor"] = "255 255 255 255";
                oc_Newobject118["controlFontSize"] = "14";
                oc_Newobject118["visible"] = "1";
                oc_Newobject118["active"] = "1";
                oc_Newobject118["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject118["tooltip"] = "A small number causes bluriness to increase gradually\\r\\nat distances closer than the focal distance. A large number causes bluriness to \\r\\nincrease quickly";
                oc_Newobject118["hovertime"] = "1000";
                oc_Newobject118["isContainer"] = "0";
                oc_Newobject118["alphaValue"] = "1";
                oc_Newobject118["mouseOverAlphaValue"] = "1";
                oc_Newobject118["alphaFadeTime"] = "1000";
                oc_Newobject118["moveControl"] = "0";
                oc_Newobject118["lockControl"] = "0";
                oc_Newobject118["windowSettings"] = "1";
                oc_Newobject118["alpha"] = "1";
                oc_Newobject118["mouseOverAlpha"] = "1";
                oc_Newobject118["alphaFade"] = "1";
                oc_Newobject118["contextFontColor"] = "0";
                oc_Newobject118["contextBackColor"] = "0";
                oc_Newobject118["contextFillColor"] = "0";
                oc_Newobject118["contextFontSize"] = "0";
                oc_Newobject118["editable"] = "0";
                oc_Newobject118["canSave"] = "1";
                oc_Newobject118["canSaveDynamicFields"] = "0";
                oc_Newobject118["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject118"] = oc_Newobject118;

                #region GuiSliderCtrl (ppOptionsDOFBlurCurveFarSlider)        oc_Newobject119
                ObjectCreator oc_Newobject119 = new ObjectCreator("GuiSliderCtrl", "ppOptionsDOFBlurCurveFarSlider",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsDOFBlurCurveFarSlider));
                oc_Newobject119["range"] = "0 50";
                oc_Newobject119["ticks"] = "1000";
                oc_Newobject119["snap"] = "0";
                oc_Newobject119["value"] = "0";
                oc_Newobject119["position"] = "119 141";
                oc_Newobject119["extent"] = "224 17";
                oc_Newobject119["minExtent"] = "8 2";
                oc_Newobject119["maxExtent"] = "1920 1080";
                oc_Newobject119["horizSizing"] = "right";
                oc_Newobject119["vertSizing"] = "bottom";
                oc_Newobject119["profile"] = "GuiSliderBoxProfile";
                oc_Newobject119["controlFontColor"] = "0 0 0 0";
                oc_Newobject119["controlFillColor"] = "0 0 0 0";
                oc_Newobject119["backgroundColor"] = "255 255 255 255";
                oc_Newobject119["controlFontSize"] = "14";
                oc_Newobject119["visible"] = "1";
                oc_Newobject119["active"] = "1";
                oc_Newobject119["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject119["hovertime"] = "1000";
                oc_Newobject119["isContainer"] = "0";
                oc_Newobject119["alphaValue"] = "1";
                oc_Newobject119["mouseOverAlphaValue"] = "1";
                oc_Newobject119["alphaFadeTime"] = "1000";
                oc_Newobject119["windowSettings"] = "1";
                oc_Newobject119["alpha"] = "1";
                oc_Newobject119["mouseOverAlpha"] = "1";
                oc_Newobject119["alphaFade"] = "1";
                oc_Newobject119["contextFontColor"] = "0";
                oc_Newobject119["contextBackColor"] = "0";
                oc_Newobject119["contextFillColor"] = "0";
                oc_Newobject119["contextFontSize"] = "0";
                oc_Newobject119["editable"] = "0";
                oc_Newobject119["canSave"] = "1";
                oc_Newobject119["canSaveDynamicFields"] = "0";
                oc_Newobject119["Enabled"] = "1";
                #endregion

                oc_Newobject120["#Newobject119"] = oc_Newobject119;

                #endregion

                oc_Newobject121["#Newobject120"] = oc_Newobject120;

                #endregion

                oc_Newobject123["#Newobject121"] = oc_Newobject121;

                #region GuiCheckBoxCtrl (ppOptionsEnableDOF)        oc_Newobject122
                ObjectCreator oc_Newobject122 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableDOF",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsEnableDOF));
                oc_Newobject122["text"] = "Enable";
                oc_Newobject122["groupNum"] = "-1";
                oc_Newobject122["buttonType"] = "ToggleButton";
                oc_Newobject122["useMouseEvents"] = "0";
                oc_Newobject122["position"] = "329 7";
                oc_Newobject122["extent"] = "53 20";
                oc_Newobject122["minExtent"] = "8 2";
                oc_Newobject122["maxExtent"] = "1920 1080";
                oc_Newobject122["horizSizing"] = "right";
                oc_Newobject122["vertSizing"] = "bottom";
                oc_Newobject122["profile"] = "GuiCheckBoxProfile";
                oc_Newobject122["controlFontColor"] = "0 0 0 0";
                oc_Newobject122["backgroundColor"] = "255 255 255 255";
                oc_Newobject122["controlFontSize"] = "14";
                oc_Newobject122["visible"] = "1";
                oc_Newobject122["active"] = "1";
                oc_Newobject122["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject122["tooltip"] = "Enable/Disable the Depth of field postFX";
                oc_Newobject122["hovertime"] = "1000";
                oc_Newobject122["isContainer"] = "0";
                oc_Newobject122["alphaValue"] = "1";
                oc_Newobject122["mouseOverAlphaValue"] = "1";
                oc_Newobject122["alphaFadeTime"] = "1000";
                oc_Newobject122["windowSettings"] = "1";
                oc_Newobject122["alpha"] = "1";
                oc_Newobject122["mouseOverAlpha"] = "1";
                oc_Newobject122["alphaFade"] = "1";
                oc_Newobject122["contextFontColor"] = "0";
                oc_Newobject122["contextBackColor"] = "0";
                oc_Newobject122["contextFontSize"] = "0";
                oc_Newobject122["editable"] = "0";
                oc_Newobject122["canSave"] = "1";
                oc_Newobject122["canSaveDynamicFields"] = "0";
                oc_Newobject122["Enabled"] = "1";
                #endregion

                oc_Newobject123["#Newobject122"] = oc_Newobject122;

                #endregion

                oc_Newobject150["#Newobject123"] = oc_Newobject123;

                #region GuiTabPageCtrl (ppOptionsSharpnessTab)        oc_Newobject131
                ObjectCreator oc_Newobject131 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSharpnessTab");
                oc_Newobject131["fitBook"] = "1";
                oc_Newobject131["text"] = "Sharpness";
                oc_Newobject131["maxLength"] = "1024";
                oc_Newobject131["docking"] = "None";
                oc_Newobject131["margin"] = "0 0 0 0";
                oc_Newobject131["padding"] = "0 0 0 0";
                oc_Newobject131["anchorTop"] = "1";
                oc_Newobject131["anchorBottom"] = "0";
                oc_Newobject131["anchorLeft"] = "1";
                oc_Newobject131["anchorRight"] = "0";
                oc_Newobject131["position"] = "0 20";
                oc_Newobject131["extent"] = "525 213";
                oc_Newobject131["minExtent"] = "8 2";
                oc_Newobject131["maxExtent"] = "1920 1080";
                oc_Newobject131["horizSizing"] = "right";
                oc_Newobject131["vertSizing"] = "bottom";
                oc_Newobject131["profile"] = "GuiTabPageProfile";
                oc_Newobject131["controlFontColor"] = "0 0 0 0";
                oc_Newobject131["controlFillColor"] = "0 0 0 0";
                oc_Newobject131["backgroundColor"] = "255 255 255 255";
                oc_Newobject131["controlFontSize"] = "10";
                oc_Newobject131["visible"] = "0";
                oc_Newobject131["active"] = "1";
                oc_Newobject131["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject131["tooltip"] = "Options for the range based Image Sharpen filter postFX";
                oc_Newobject131["hovertime"] = "1000";
                oc_Newobject131["isContainer"] = "1";
                oc_Newobject131["alphaValue"] = "1";
                oc_Newobject131["mouseOverAlphaValue"] = "1";
                oc_Newobject131["alphaFadeTime"] = "1000";
                oc_Newobject131["moveControl"] = "0";
                oc_Newobject131["lockControl"] = "0";
                oc_Newobject131["windowSettings"] = "1";
                oc_Newobject131["alpha"] = "1";
                oc_Newobject131["mouseOverAlpha"] = "1";
                oc_Newobject131["alphaFade"] = "1";
                oc_Newobject131["contextFontColor"] = "0";
                oc_Newobject131["contextBackColor"] = "0";
                oc_Newobject131["contextFillColor"] = "0";
                oc_Newobject131["contextFontSize"] = "0";
                oc_Newobject131["hidden"] = "1";
                oc_Newobject131["editable"] = "0";
                oc_Newobject131["canSave"] = "1";
                oc_Newobject131["canSaveDynamicFields"] = "0";
                oc_Newobject131["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsSharpenWidth)        oc_Newobject124
                ObjectCreator oc_Newobject124 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSharpenWidth", typeof(ppOptionsSharpenWidth));
                oc_Newobject124["range"] = "5 30";
                oc_Newobject124["ticks"] = "1000";
                oc_Newobject124["snap"] = "0";
                oc_Newobject124["value"] = "5";
                oc_Newobject124["position"] = "31 62";
                oc_Newobject124["extent"] = "332 17";
                oc_Newobject124["minExtent"] = "8 2";
                oc_Newobject124["maxExtent"] = "1920 1080";
                oc_Newobject124["horizSizing"] = "right";
                oc_Newobject124["vertSizing"] = "bottom";
                oc_Newobject124["profile"] = "GuiSliderBoxProfile";
                oc_Newobject124["controlFontColor"] = "0 0 0 0";
                oc_Newobject124["controlFillColor"] = "0 0 0 0";
                oc_Newobject124["backgroundColor"] = "255 255 255 255";
                oc_Newobject124["controlFontSize"] = "14";
                oc_Newobject124["visible"] = "1";
                oc_Newobject124["active"] = "1";
                oc_Newobject124["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject124["hovertime"] = "1000";
                oc_Newobject124["isContainer"] = "0";
                oc_Newobject124["alphaValue"] = "1";
                oc_Newobject124["mouseOverAlphaValue"] = "1";
                oc_Newobject124["alphaFadeTime"] = "1000";
                oc_Newobject124["windowSettings"] = "1";
                oc_Newobject124["alpha"] = "1";
                oc_Newobject124["mouseOverAlpha"] = "1";
                oc_Newobject124["alphaFade"] = "1";
                oc_Newobject124["contextFontColor"] = "0";
                oc_Newobject124["contextBackColor"] = "0";
                oc_Newobject124["contextFillColor"] = "0";
                oc_Newobject124["contextFontSize"] = "0";
                oc_Newobject124["editable"] = "0";
                oc_Newobject124["canSave"] = "1";
                oc_Newobject124["canSaveDynamicFields"] = "0";
                oc_Newobject124["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject124"] = oc_Newobject124;

                #region GuiTextCtrl (ppOptionSharpnessWidthLabel)        oc_Newobject125
                ObjectCreator oc_Newobject125 = new ObjectCreator("GuiTextCtrl", "ppOptionSharpnessWidthLabel");
                oc_Newobject125["text"] = "Sharpen Width";
                oc_Newobject125["maxLength"] = "1024";
                oc_Newobject125["margin"] = "0 0 0 0";
                oc_Newobject125["padding"] = "0 0 0 0";
                oc_Newobject125["anchorTop"] = "1";
                oc_Newobject125["anchorBottom"] = "0";
                oc_Newobject125["anchorLeft"] = "1";
                oc_Newobject125["anchorRight"] = "0";
                oc_Newobject125["position"] = "158 44";
                oc_Newobject125["extent"] = "74 15";
                oc_Newobject125["minExtent"] = "8 2";
                oc_Newobject125["maxExtent"] = "1920 1080";
                oc_Newobject125["horizSizing"] = "right";
                oc_Newobject125["vertSizing"] = "bottom";
                oc_Newobject125["profile"] = "GuiTextProfile";
                oc_Newobject125["controlFontColor"] = "0 0 0 0";
                oc_Newobject125["controlFillColor"] = "0 0 0 0";
                oc_Newobject125["backgroundColor"] = "255 255 255 255";
                oc_Newobject125["controlFontSize"] = "14";
                oc_Newobject125["visible"] = "1";
                oc_Newobject125["active"] = "1";
                oc_Newobject125["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject125["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject125["hovertime"] = "1000";
                oc_Newobject125["isContainer"] = "0";
                oc_Newobject125["alphaValue"] = "1";
                oc_Newobject125["mouseOverAlphaValue"] = "1";
                oc_Newobject125["alphaFadeTime"] = "1000";
                oc_Newobject125["moveControl"] = "0";
                oc_Newobject125["lockControl"] = "0";
                oc_Newobject125["windowSettings"] = "1";
                oc_Newobject125["alpha"] = "1";
                oc_Newobject125["mouseOverAlpha"] = "1";
                oc_Newobject125["alphaFade"] = "1";
                oc_Newobject125["contextFontColor"] = "0";
                oc_Newobject125["contextBackColor"] = "0";
                oc_Newobject125["contextFillColor"] = "0";
                oc_Newobject125["contextFontSize"] = "0";
                oc_Newobject125["editable"] = "0";
                oc_Newobject125["canSave"] = "1";
                oc_Newobject125["canSaveDynamicFields"] = "0";
                oc_Newobject125["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject125"] = oc_Newobject125;

                #region GuiTextCtrl (ppOptionSharpnessWidthLabel1)        oc_Newobject126
                ObjectCreator oc_Newobject126 = new ObjectCreator("GuiTextCtrl", "ppOptionSharpnessWidthLabel1");
                oc_Newobject126["text"] = "Sharpen Strength";
                oc_Newobject126["maxLength"] = "1024";
                oc_Newobject126["margin"] = "0 0 0 0";
                oc_Newobject126["padding"] = "0 0 0 0";
                oc_Newobject126["anchorTop"] = "1";
                oc_Newobject126["anchorBottom"] = "0";
                oc_Newobject126["anchorLeft"] = "1";
                oc_Newobject126["anchorRight"] = "0";
                oc_Newobject126["position"] = "153 94";
                oc_Newobject126["extent"] = "87 15";
                oc_Newobject126["minExtent"] = "8 2";
                oc_Newobject126["maxExtent"] = "1920 1080";
                oc_Newobject126["horizSizing"] = "right";
                oc_Newobject126["vertSizing"] = "bottom";
                oc_Newobject126["profile"] = "GuiTextProfile";
                oc_Newobject126["controlFontColor"] = "0 0 0 0";
                oc_Newobject126["controlFillColor"] = "0 0 0 0";
                oc_Newobject126["backgroundColor"] = "255 255 255 255";
                oc_Newobject126["controlFontSize"] = "14";
                oc_Newobject126["visible"] = "1";
                oc_Newobject126["active"] = "1";
                oc_Newobject126["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject126["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject126["hovertime"] = "1000";
                oc_Newobject126["isContainer"] = "0";
                oc_Newobject126["alphaValue"] = "1";
                oc_Newobject126["mouseOverAlphaValue"] = "1";
                oc_Newobject126["alphaFadeTime"] = "1000";
                oc_Newobject126["moveControl"] = "0";
                oc_Newobject126["lockControl"] = "0";
                oc_Newobject126["windowSettings"] = "1";
                oc_Newobject126["alpha"] = "1";
                oc_Newobject126["mouseOverAlpha"] = "1";
                oc_Newobject126["alphaFade"] = "1";
                oc_Newobject126["contextFontColor"] = "0";
                oc_Newobject126["contextBackColor"] = "0";
                oc_Newobject126["contextFillColor"] = "0";
                oc_Newobject126["contextFontSize"] = "0";
                oc_Newobject126["editable"] = "0";
                oc_Newobject126["canSave"] = "1";
                oc_Newobject126["canSaveDynamicFields"] = "0";
                oc_Newobject126["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject126"] = oc_Newobject126;

                #region GuiSliderCtrl (ppOptionsSharpenStrength)        oc_Newobject127
                ObjectCreator oc_Newobject127 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSharpenStrength", typeof(ppOptionsSharpenStrength));
                oc_Newobject127["range"] = "0.1 20";
                oc_Newobject127["ticks"] = "1000";
                oc_Newobject127["snap"] = "0";
                oc_Newobject127["value"] = "0.1";
                oc_Newobject127["position"] = "31 113";
                oc_Newobject127["extent"] = "333 17";
                oc_Newobject127["minExtent"] = "8 2";
                oc_Newobject127["maxExtent"] = "1920 1080";
                oc_Newobject127["horizSizing"] = "right";
                oc_Newobject127["vertSizing"] = "bottom";
                oc_Newobject127["profile"] = "GuiSliderBoxProfile";
                oc_Newobject127["controlFontColor"] = "0 0 0 0";
                oc_Newobject127["controlFillColor"] = "0 0 0 0";
                oc_Newobject127["backgroundColor"] = "255 255 255 255";
                oc_Newobject127["controlFontSize"] = "14";
                oc_Newobject127["visible"] = "1";
                oc_Newobject127["active"] = "1";
                oc_Newobject127["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject127["hovertime"] = "1000";
                oc_Newobject127["isContainer"] = "0";
                oc_Newobject127["alphaValue"] = "1";
                oc_Newobject127["mouseOverAlphaValue"] = "1";
                oc_Newobject127["alphaFadeTime"] = "1000";
                oc_Newobject127["windowSettings"] = "1";
                oc_Newobject127["alpha"] = "1";
                oc_Newobject127["mouseOverAlpha"] = "1";
                oc_Newobject127["alphaFade"] = "1";
                oc_Newobject127["contextFontColor"] = "0";
                oc_Newobject127["contextBackColor"] = "0";
                oc_Newobject127["contextFillColor"] = "0";
                oc_Newobject127["contextFontSize"] = "0";
                oc_Newobject127["editable"] = "0";
                oc_Newobject127["canSave"] = "1";
                oc_Newobject127["canSaveDynamicFields"] = "0";
                oc_Newobject127["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject127"] = oc_Newobject127;

                #region GuiTextCtrl (ppOptionSharpnessWidthLabel11)        oc_Newobject128
                ObjectCreator oc_Newobject128 = new ObjectCreator("GuiTextCtrl", "ppOptionSharpnessWidthLabel11");
                oc_Newobject128["text"] = "Sharpen Range";
                oc_Newobject128["maxLength"] = "1024";
                oc_Newobject128["margin"] = "0 0 0 0";
                oc_Newobject128["padding"] = "0 0 0 0";
                oc_Newobject128["anchorTop"] = "1";
                oc_Newobject128["anchorBottom"] = "0";
                oc_Newobject128["anchorLeft"] = "1";
                oc_Newobject128["anchorRight"] = "0";
                oc_Newobject128["position"] = "158 143";
                oc_Newobject128["extent"] = "78 15";
                oc_Newobject128["minExtent"] = "8 2";
                oc_Newobject128["maxExtent"] = "1920 1080";
                oc_Newobject128["horizSizing"] = "right";
                oc_Newobject128["vertSizing"] = "bottom";
                oc_Newobject128["profile"] = "GuiTextProfile";
                oc_Newobject128["controlFontColor"] = "0 0 0 0";
                oc_Newobject128["controlFillColor"] = "0 0 0 0";
                oc_Newobject128["backgroundColor"] = "255 255 255 255";
                oc_Newobject128["controlFontSize"] = "14";
                oc_Newobject128["visible"] = "1";
                oc_Newobject128["active"] = "1";
                oc_Newobject128["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject128["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject128["hovertime"] = "1000";
                oc_Newobject128["isContainer"] = "0";
                oc_Newobject128["alphaValue"] = "1";
                oc_Newobject128["mouseOverAlphaValue"] = "1";
                oc_Newobject128["alphaFadeTime"] = "1000";
                oc_Newobject128["moveControl"] = "0";
                oc_Newobject128["lockControl"] = "0";
                oc_Newobject128["windowSettings"] = "1";
                oc_Newobject128["alpha"] = "1";
                oc_Newobject128["mouseOverAlpha"] = "1";
                oc_Newobject128["alphaFade"] = "1";
                oc_Newobject128["contextFontColor"] = "0";
                oc_Newobject128["contextBackColor"] = "0";
                oc_Newobject128["contextFillColor"] = "0";
                oc_Newobject128["contextFontSize"] = "0";
                oc_Newobject128["editable"] = "0";
                oc_Newobject128["canSave"] = "1";
                oc_Newobject128["canSaveDynamicFields"] = "0";
                oc_Newobject128["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject128"] = oc_Newobject128;

                #region GuiSliderCtrl (ppOptionsSharpenRange)        oc_Newobject129
                ObjectCreator oc_Newobject129 = new ObjectCreator("GuiSliderCtrl", "ppOptionsSharpenRange", typeof(ppOptionsSharpenRange));
                oc_Newobject129["range"] = "32 512";
                oc_Newobject129["ticks"] = "1000";
                oc_Newobject129["snap"] = "0";
                oc_Newobject129["value"] = "32";
                oc_Newobject129["position"] = "30 161";
                oc_Newobject129["extent"] = "334 17";
                oc_Newobject129["minExtent"] = "8 2";
                oc_Newobject129["maxExtent"] = "1920 1080";
                oc_Newobject129["horizSizing"] = "right";
                oc_Newobject129["vertSizing"] = "bottom";
                oc_Newobject129["profile"] = "GuiSliderBoxProfile";
                oc_Newobject129["controlFontColor"] = "0 0 0 0";
                oc_Newobject129["controlFillColor"] = "0 0 0 0";
                oc_Newobject129["backgroundColor"] = "255 255 255 255";
                oc_Newobject129["controlFontSize"] = "14";
                oc_Newobject129["visible"] = "1";
                oc_Newobject129["active"] = "1";
                oc_Newobject129["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject129["hovertime"] = "1000";
                oc_Newobject129["isContainer"] = "0";
                oc_Newobject129["alphaValue"] = "1";
                oc_Newobject129["mouseOverAlphaValue"] = "1";
                oc_Newobject129["alphaFadeTime"] = "1000";
                oc_Newobject129["windowSettings"] = "1";
                oc_Newobject129["alpha"] = "1";
                oc_Newobject129["mouseOverAlpha"] = "1";
                oc_Newobject129["alphaFade"] = "1";
                oc_Newobject129["contextFontColor"] = "0";
                oc_Newobject129["contextBackColor"] = "0";
                oc_Newobject129["contextFillColor"] = "0";
                oc_Newobject129["contextFontSize"] = "0";
                oc_Newobject129["editable"] = "0";
                oc_Newobject129["canSave"] = "1";
                oc_Newobject129["canSaveDynamicFields"] = "0";
                oc_Newobject129["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject129"] = oc_Newobject129;

                #region GuiCheckBoxCtrl (ppOptionsEnableSharpness)        oc_Newobject130
                ObjectCreator oc_Newobject130 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableSharpness", typeof(ppOptionsEnableSharpness));
                oc_Newobject130["text"] = "Enable";
                oc_Newobject130["groupNum"] = "-1";
                oc_Newobject130["buttonType"] = "ToggleButton";
                oc_Newobject130["useMouseEvents"] = "0";
                oc_Newobject130["position"] = "329 7";
                oc_Newobject130["extent"] = "53 20";
                oc_Newobject130["minExtent"] = "8 2";
                oc_Newobject130["maxExtent"] = "1920 1080";
                oc_Newobject130["horizSizing"] = "right";
                oc_Newobject130["vertSizing"] = "bottom";
                oc_Newobject130["profile"] = "GuiCheckBoxProfile";
                oc_Newobject130["controlFontColor"] = "0 0 0 0";
                oc_Newobject130["backgroundColor"] = "255 255 255 255";
                oc_Newobject130["controlFontSize"] = "14";
                oc_Newobject130["visible"] = "1";
                oc_Newobject130["active"] = "1";
                oc_Newobject130["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject130["tooltip"] = "Enable/Disable the Sharpness postFX";
                oc_Newobject130["hovertime"] = "1000";
                oc_Newobject130["isContainer"] = "0";
                oc_Newobject130["alphaValue"] = "1";
                oc_Newobject130["mouseOverAlphaValue"] = "1";
                oc_Newobject130["alphaFadeTime"] = "1000";
                oc_Newobject130["windowSettings"] = "1";
                oc_Newobject130["alpha"] = "1";
                oc_Newobject130["mouseOverAlpha"] = "1";
                oc_Newobject130["alphaFade"] = "1";
                oc_Newobject130["contextFontColor"] = "0";
                oc_Newobject130["contextBackColor"] = "0";
                oc_Newobject130["contextFontSize"] = "0";
                oc_Newobject130["editable"] = "0";
                oc_Newobject130["canSave"] = "1";
                oc_Newobject130["canSaveDynamicFields"] = "0";
                oc_Newobject130["Enabled"] = "1";
                #endregion

                oc_Newobject131["#Newobject130"] = oc_Newobject130;

                #endregion

                oc_Newobject150["#Newobject131"] = oc_Newobject131;

                #region GuiTabPageCtrl (ppOptionsNightvisionTab)        oc_Newobject149
                ObjectCreator oc_Newobject149 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsNightvisionTab");
                oc_Newobject149["fitBook"] = "1";
                oc_Newobject149["text"] = "Nightvision";
                oc_Newobject149["maxLength"] = "1024";
                oc_Newobject149["docking"] = "None";
                oc_Newobject149["margin"] = "0 0 0 0";
                oc_Newobject149["padding"] = "0 0 0 0";
                oc_Newobject149["anchorTop"] = "1";
                oc_Newobject149["anchorBottom"] = "1";
                oc_Newobject149["anchorLeft"] = "1";
                oc_Newobject149["anchorRight"] = "1";
                oc_Newobject149["position"] = "0 20";
                oc_Newobject149["extent"] = "525 213";
                oc_Newobject149["minExtent"] = "8 2";
                oc_Newobject149["maxExtent"] = "1920 1080";
                oc_Newobject149["horizSizing"] = "right";
                oc_Newobject149["vertSizing"] = "bottom";
                oc_Newobject149["profile"] = "GuiTabPageProfile";
                oc_Newobject149["controlFontColor"] = "0 0 0 0";
                oc_Newobject149["controlFillColor"] = "0 0 0 0";
                oc_Newobject149["backgroundColor"] = "255 255 255 255";
                oc_Newobject149["controlFontSize"] = "10";
                oc_Newobject149["visible"] = "0";
                oc_Newobject149["active"] = "1";
                oc_Newobject149["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject149["tooltip"] = "Options for the Night Vision Goggles postFX";
                oc_Newobject149["hovertime"] = "1000";
                oc_Newobject149["isContainer"] = "1";
                oc_Newobject149["alphaValue"] = "1";
                oc_Newobject149["mouseOverAlphaValue"] = "1";
                oc_Newobject149["alphaFadeTime"] = "1000";
                oc_Newobject149["moveControl"] = "0";
                oc_Newobject149["lockControl"] = "0";
                oc_Newobject149["windowSettings"] = "1";
                oc_Newobject149["alpha"] = "1";
                oc_Newobject149["mouseOverAlpha"] = "1";
                oc_Newobject149["alphaFade"] = "1";
                oc_Newobject149["contextFontColor"] = "0";
                oc_Newobject149["contextBackColor"] = "0";
                oc_Newobject149["contextFillColor"] = "0";
                oc_Newobject149["contextFontSize"] = "0";
                oc_Newobject149["hidden"] = "1";
                oc_Newobject149["editable"] = "0";
                oc_Newobject149["canSave"] = "1";
                oc_Newobject149["canSaveDynamicFields"] = "0";
                oc_Newobject149["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject132
                ObjectCreator oc_Newobject132 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject132["position"] = "10 31";
                oc_Newobject132["extent"] = "369 173";
                oc_Newobject132["minExtent"] = "8 2";
                oc_Newobject132["maxExtent"] = "1920 1080";
                oc_Newobject132["horizSizing"] = "right";
                oc_Newobject132["vertSizing"] = "bottom";
                oc_Newobject132["profile"] = "GuiTabBorderProfile";
                oc_Newobject132["controlFontColor"] = "0 0 0 0";
                oc_Newobject132["controlFillColor"] = "0 0 0 0";
                oc_Newobject132["backgroundColor"] = "255 255 255 255";
                oc_Newobject132["controlFontSize"] = "14";
                oc_Newobject132["visible"] = "1";
                oc_Newobject132["active"] = "1";
                oc_Newobject132["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject132["hovertime"] = "1000";
                oc_Newobject132["isContainer"] = "0";
                oc_Newobject132["alphaValue"] = "1";
                oc_Newobject132["mouseOverAlphaValue"] = "1";
                oc_Newobject132["alphaFadeTime"] = "1000";
                oc_Newobject132["moveControl"] = "0";
                oc_Newobject132["lockControl"] = "0";
                oc_Newobject132["windowSettings"] = "1";
                oc_Newobject132["alpha"] = "1";
                oc_Newobject132["mouseOverAlpha"] = "1";
                oc_Newobject132["alphaFade"] = "1";
                oc_Newobject132["contextFontColor"] = "0";
                oc_Newobject132["contextBackColor"] = "0";
                oc_Newobject132["contextFillColor"] = "0";
                oc_Newobject132["contextFontSize"] = "0";
                oc_Newobject132["editable"] = "0";
                oc_Newobject132["canSave"] = "1";
                oc_Newobject132["canSaveDynamicFields"] = "0";
                oc_Newobject132["Enabled"] = "1";
                #endregion

                oc_Newobject149["#Newobject132"] = oc_Newobject132;

                #region GuiTabBookCtrl (ppOptionsNVTabs)        oc_Newobject147
                ObjectCreator oc_Newobject147 = new ObjectCreator("GuiTabBookCtrl", "ppOptionsNVTabs");
                oc_Newobject147["tabPosition"] = "Top";
                oc_Newobject147["tabMargin"] = "7";
                oc_Newobject147["minTabWidth"] = "64";
                oc_Newobject147["tabHeight"] = "20";
                oc_Newobject147["allowReorder"] = "0";
                oc_Newobject147["defaultPage"] = "-1";
                oc_Newobject147["selectedPage"] = "1";
                oc_Newobject147["frontTabPadding"] = "0";
                oc_Newobject147["margin"] = "0 0 0 0";
                oc_Newobject147["padding"] = "0 0 0 0";
                oc_Newobject147["anchorTop"] = "1";
                oc_Newobject147["anchorBottom"] = "0";
                oc_Newobject147["anchorLeft"] = "1";
                oc_Newobject147["anchorRight"] = "0";
                oc_Newobject147["position"] = "10 12";
                oc_Newobject147["extent"] = "369 192";
                oc_Newobject147["minExtent"] = "8 2";
                oc_Newobject147["maxExtent"] = "1920 1080";
                oc_Newobject147["horizSizing"] = "right";
                oc_Newobject147["vertSizing"] = "bottom";
                oc_Newobject147["profile"] = "GuiTabBookProfile";
                oc_Newobject147["controlFontColor"] = "0 0 0 0";
                oc_Newobject147["controlFillColor"] = "0 0 0 0";
                oc_Newobject147["backgroundColor"] = "255 255 255 255";
                oc_Newobject147["controlFontSize"] = "14";
                oc_Newobject147["visible"] = "1";
                oc_Newobject147["active"] = "1";
                oc_Newobject147["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject147["hovertime"] = "1000";
                oc_Newobject147["isContainer"] = "1";
                oc_Newobject147["alphaValue"] = "1";
                oc_Newobject147["mouseOverAlphaValue"] = "1";
                oc_Newobject147["alphaFadeTime"] = "1000";
                oc_Newobject147["windowSettings"] = "1";
                oc_Newobject147["alpha"] = "1";
                oc_Newobject147["mouseOverAlpha"] = "1";
                oc_Newobject147["alphaFade"] = "1";
                oc_Newobject147["contextFontColor"] = "0";
                oc_Newobject147["contextBackColor"] = "0";
                oc_Newobject147["contextFillColor"] = "0";
                oc_Newobject147["contextFontSize"] = "0";
                oc_Newobject147["editable"] = "0";
                oc_Newobject147["canSave"] = "1";
                oc_Newobject147["canSaveDynamicFields"] = "0";
                oc_Newobject147["Enabled"] = "1";

                #region GuiTabPageCtrl (ppOptionsNVBrightnessTab)        oc_Newobject139
                ObjectCreator oc_Newobject139 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsNVBrightnessTab");
                oc_Newobject139["fitBook"] = "1";
                oc_Newobject139["text"] = "Brightness";
                oc_Newobject139["maxLength"] = "1024";
                oc_Newobject139["docking"] = "None";
                oc_Newobject139["margin"] = "0 0 0 0";
                oc_Newobject139["padding"] = "0 0 0 0";
                oc_Newobject139["anchorTop"] = "1";
                oc_Newobject139["anchorBottom"] = "0";
                oc_Newobject139["anchorLeft"] = "1";
                oc_Newobject139["anchorRight"] = "0";
                oc_Newobject139["position"] = "0 20";
                oc_Newobject139["extent"] = "369 172";
                oc_Newobject139["minExtent"] = "8 2";
                oc_Newobject139["maxExtent"] = "1920 1080";
                oc_Newobject139["horizSizing"] = "right";
                oc_Newobject139["vertSizing"] = "bottom";
                oc_Newobject139["profile"] = "GuiTabPageProfile";
                oc_Newobject139["controlFontColor"] = "0 0 0 0";
                oc_Newobject139["controlFillColor"] = "0 0 0 0";
                oc_Newobject139["backgroundColor"] = "255 255 255 255";
                oc_Newobject139["controlFontSize"] = "10";
                oc_Newobject139["visible"] = "0";
                oc_Newobject139["active"] = "1";
                oc_Newobject139["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject139["tooltip"] = "Contains settings related to the night vision Brightness controls";
                oc_Newobject139["hovertime"] = "1000";
                oc_Newobject139["isContainer"] = "1";
                oc_Newobject139["alphaValue"] = "1";
                oc_Newobject139["mouseOverAlphaValue"] = "1";
                oc_Newobject139["alphaFadeTime"] = "1000";
                oc_Newobject139["moveControl"] = "0";
                oc_Newobject139["lockControl"] = "0";
                oc_Newobject139["windowSettings"] = "1";
                oc_Newobject139["alpha"] = "1";
                oc_Newobject139["mouseOverAlpha"] = "1";
                oc_Newobject139["alphaFade"] = "1";
                oc_Newobject139["contextFontColor"] = "0";
                oc_Newobject139["contextBackColor"] = "0";
                oc_Newobject139["contextFillColor"] = "0";
                oc_Newobject139["contextFontSize"] = "0";
                oc_Newobject139["hidden"] = "1";
                oc_Newobject139["editable"] = "0";
                oc_Newobject139["canSave"] = "1";
                oc_Newobject139["canSaveDynamicFields"] = "0";
                oc_Newobject139["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsNVBright)        oc_Newobject133
                ObjectCreator oc_Newobject133 = new ObjectCreator("GuiSliderCtrl", "ppOptionsNVBright", typeof(ppOptionsNVBright));
                oc_Newobject133["range"] = "0.1 1";
                oc_Newobject133["ticks"] = "1000";
                oc_Newobject133["snap"] = "0";
                oc_Newobject133["value"] = "0.1";
                oc_Newobject133["position"] = "119 34";
                oc_Newobject133["extent"] = "233 17";
                oc_Newobject133["minExtent"] = "8 2";
                oc_Newobject133["maxExtent"] = "1920 1080";
                oc_Newobject133["horizSizing"] = "right";
                oc_Newobject133["vertSizing"] = "bottom";
                oc_Newobject133["profile"] = "GuiSliderBoxProfile";
                oc_Newobject133["controlFontColor"] = "0 0 0 0";
                oc_Newobject133["controlFillColor"] = "0 0 0 0";
                oc_Newobject133["backgroundColor"] = "255 255 255 255";
                oc_Newobject133["controlFontSize"] = "14";
                oc_Newobject133["visible"] = "1";
                oc_Newobject133["active"] = "1";
                oc_Newobject133["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject133["hovertime"] = "1000";
                oc_Newobject133["isContainer"] = "0";
                oc_Newobject133["alphaValue"] = "1";
                oc_Newobject133["mouseOverAlphaValue"] = "1";
                oc_Newobject133["alphaFadeTime"] = "1000";
                oc_Newobject133["windowSettings"] = "1";
                oc_Newobject133["alpha"] = "1";
                oc_Newobject133["mouseOverAlpha"] = "1";
                oc_Newobject133["alphaFade"] = "1";
                oc_Newobject133["contextFontColor"] = "0";
                oc_Newobject133["contextBackColor"] = "0";
                oc_Newobject133["contextFillColor"] = "0";
                oc_Newobject133["contextFontSize"] = "0";
                oc_Newobject133["editable"] = "0";
                oc_Newobject133["canSave"] = "1";
                oc_Newobject133["canSaveDynamicFields"] = "0";
                oc_Newobject133["Enabled"] = "1";
                #endregion

                oc_Newobject139["#Newobject133"] = oc_Newobject133;

                #region GuiTextCtrl (ppOptionNVBrightLabel)        oc_Newobject134
                ObjectCreator oc_Newobject134 = new ObjectCreator("GuiTextCtrl", "ppOptionNVBrightLabel");
                oc_Newobject134["text"] = "Overbright threshold";
                oc_Newobject134["maxLength"] = "1024";
                oc_Newobject134["margin"] = "0 0 0 0";
                oc_Newobject134["padding"] = "0 0 0 0";
                oc_Newobject134["anchorTop"] = "1";
                oc_Newobject134["anchorBottom"] = "0";
                oc_Newobject134["anchorLeft"] = "1";
                oc_Newobject134["anchorRight"] = "0";
                oc_Newobject134["position"] = "10 36";
                oc_Newobject134["extent"] = "98 15";
                oc_Newobject134["minExtent"] = "8 2";
                oc_Newobject134["maxExtent"] = "1920 1080";
                oc_Newobject134["horizSizing"] = "right";
                oc_Newobject134["vertSizing"] = "bottom";
                oc_Newobject134["profile"] = "GuiTextProfile";
                oc_Newobject134["controlFontColor"] = "0 0 0 0";
                oc_Newobject134["controlFillColor"] = "0 0 0 0";
                oc_Newobject134["backgroundColor"] = "255 255 255 255";
                oc_Newobject134["controlFontSize"] = "-1";
                oc_Newobject134["visible"] = "1";
                oc_Newobject134["active"] = "1";
                oc_Newobject134["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject134["tooltip"] = "The luminance threshold at which it becomes overbright";
                oc_Newobject134["hovertime"] = "1000";
                oc_Newobject134["isContainer"] = "0";
                oc_Newobject134["alphaValue"] = "1";
                oc_Newobject134["mouseOverAlphaValue"] = "1";
                oc_Newobject134["alphaFadeTime"] = "1000";
                oc_Newobject134["moveControl"] = "0";
                oc_Newobject134["lockControl"] = "0";
                oc_Newobject134["windowSettings"] = "1";
                oc_Newobject134["alpha"] = "1";
                oc_Newobject134["mouseOverAlpha"] = "1";
                oc_Newobject134["alphaFade"] = "1";
                oc_Newobject134["contextFontColor"] = "0";
                oc_Newobject134["contextBackColor"] = "0";
                oc_Newobject134["contextFillColor"] = "0";
                oc_Newobject134["contextFontSize"] = "0";
                oc_Newobject134["editable"] = "0";
                oc_Newobject134["canSave"] = "1";
                oc_Newobject134["canSaveDynamicFields"] = "0";
                oc_Newobject134["Enabled"] = "1";
                #endregion

                oc_Newobject139["#Newobject134"] = oc_Newobject134;

                #region GuiSliderCtrl (ppOptionsNVLowMul)        oc_Newobject135
                ObjectCreator oc_Newobject135 = new ObjectCreator("GuiSliderCtrl", "ppOptionsNVLowMul", typeof(ppOptionsNVLowMul));
                oc_Newobject135["range"] = "0.1 20";
                oc_Newobject135["ticks"] = "1000";
                oc_Newobject135["snap"] = "0";
                oc_Newobject135["value"] = "0.1";
                oc_Newobject135["position"] = "119 90";
                oc_Newobject135["extent"] = "233 17";
                oc_Newobject135["minExtent"] = "8 2";
                oc_Newobject135["maxExtent"] = "1920 1080";
                oc_Newobject135["horizSizing"] = "right";
                oc_Newobject135["vertSizing"] = "bottom";
                oc_Newobject135["profile"] = "GuiSliderBoxProfile";
                oc_Newobject135["controlFontColor"] = "0 0 0 0";
                oc_Newobject135["controlFillColor"] = "0 0 0 0";
                oc_Newobject135["backgroundColor"] = "255 255 255 255";
                oc_Newobject135["controlFontSize"] = "14";
                oc_Newobject135["visible"] = "1";
                oc_Newobject135["active"] = "1";
                oc_Newobject135["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject135["hovertime"] = "1000";
                oc_Newobject135["isContainer"] = "0";
                oc_Newobject135["alphaValue"] = "1";
                oc_Newobject135["mouseOverAlphaValue"] = "1";
                oc_Newobject135["alphaFadeTime"] = "1000";
                oc_Newobject135["windowSettings"] = "1";
                oc_Newobject135["alpha"] = "1";
                oc_Newobject135["mouseOverAlpha"] = "1";
                oc_Newobject135["alphaFade"] = "1";
                oc_Newobject135["contextFontColor"] = "0";
                oc_Newobject135["contextBackColor"] = "0";
                oc_Newobject135["contextFillColor"] = "0";
                oc_Newobject135["contextFontSize"] = "0";
                oc_Newobject135["editable"] = "0";
                oc_Newobject135["canSave"] = "1";
                oc_Newobject135["canSaveDynamicFields"] = "0";
                oc_Newobject135["Enabled"] = "1";
                #endregion

                oc_Newobject139["#Newobject135"] = oc_Newobject135;

                #region GuiTextCtrl (ppOptionNVLowLabel)        oc_Newobject136
                ObjectCreator oc_Newobject136 = new ObjectCreator("GuiTextCtrl", "ppOptionNVLowLabel");
                oc_Newobject136["text"] = "Low Multiplier";
                oc_Newobject136["maxLength"] = "1024";
                oc_Newobject136["margin"] = "0 0 0 0";
                oc_Newobject136["padding"] = "0 0 0 0";
                oc_Newobject136["anchorTop"] = "1";
                oc_Newobject136["anchorBottom"] = "0";
                oc_Newobject136["anchorLeft"] = "1";
                oc_Newobject136["anchorRight"] = "0";
                oc_Newobject136["position"] = "40 91";
                oc_Newobject136["extent"] = "66 15";
                oc_Newobject136["minExtent"] = "8 2";
                oc_Newobject136["maxExtent"] = "1920 1080";
                oc_Newobject136["horizSizing"] = "right";
                oc_Newobject136["vertSizing"] = "bottom";
                oc_Newobject136["profile"] = "GuiTextProfile";
                oc_Newobject136["controlFontColor"] = "0 0 0 0";
                oc_Newobject136["controlFillColor"] = "0 0 0 0";
                oc_Newobject136["backgroundColor"] = "255 255 255 255";
                oc_Newobject136["controlFontSize"] = "-1";
                oc_Newobject136["visible"] = "1";
                oc_Newobject136["active"] = "1";
                oc_Newobject136["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject136["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject136["hovertime"] = "1000";
                oc_Newobject136["isContainer"] = "0";
                oc_Newobject136["alphaValue"] = "1";
                oc_Newobject136["mouseOverAlphaValue"] = "1";
                oc_Newobject136["alphaFadeTime"] = "1000";
                oc_Newobject136["moveControl"] = "0";
                oc_Newobject136["lockControl"] = "0";
                oc_Newobject136["windowSettings"] = "1";
                oc_Newobject136["alpha"] = "1";
                oc_Newobject136["mouseOverAlpha"] = "1";
                oc_Newobject136["alphaFade"] = "1";
                oc_Newobject136["contextFontColor"] = "0";
                oc_Newobject136["contextBackColor"] = "0";
                oc_Newobject136["contextFillColor"] = "0";
                oc_Newobject136["contextFontSize"] = "0";
                oc_Newobject136["editable"] = "0";
                oc_Newobject136["canSave"] = "1";
                oc_Newobject136["canSaveDynamicFields"] = "0";
                oc_Newobject136["Enabled"] = "1";
                #endregion

                oc_Newobject139["#Newobject136"] = oc_Newobject136;

                #region GuiTextCtrl (ppOptionNVHighLabel)        oc_Newobject137
                ObjectCreator oc_Newobject137 = new ObjectCreator("GuiTextCtrl", "ppOptionNVHighLabel");
                oc_Newobject137["text"] = "High Multiplier";
                oc_Newobject137["maxLength"] = "1024";
                oc_Newobject137["margin"] = "0 0 0 0";
                oc_Newobject137["padding"] = "0 0 0 0";
                oc_Newobject137["anchorTop"] = "1";
                oc_Newobject137["anchorBottom"] = "0";
                oc_Newobject137["anchorLeft"] = "1";
                oc_Newobject137["anchorRight"] = "0";
                oc_Newobject137["position"] = "40 115";
                oc_Newobject137["extent"] = "70 15";
                oc_Newobject137["minExtent"] = "8 2";
                oc_Newobject137["maxExtent"] = "1920 1080";
                oc_Newobject137["horizSizing"] = "right";
                oc_Newobject137["vertSizing"] = "bottom";
                oc_Newobject137["profile"] = "GuiTextProfile";
                oc_Newobject137["controlFontColor"] = "0 0 0 0";
                oc_Newobject137["controlFillColor"] = "0 0 0 0";
                oc_Newobject137["backgroundColor"] = "255 255 255 255";
                oc_Newobject137["controlFontSize"] = "-1";
                oc_Newobject137["visible"] = "1";
                oc_Newobject137["active"] = "1";
                oc_Newobject137["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject137["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject137["hovertime"] = "1000";
                oc_Newobject137["isContainer"] = "0";
                oc_Newobject137["alphaValue"] = "1";
                oc_Newobject137["mouseOverAlphaValue"] = "1";
                oc_Newobject137["alphaFadeTime"] = "1000";
                oc_Newobject137["moveControl"] = "0";
                oc_Newobject137["lockControl"] = "0";
                oc_Newobject137["windowSettings"] = "1";
                oc_Newobject137["alpha"] = "1";
                oc_Newobject137["mouseOverAlpha"] = "1";
                oc_Newobject137["alphaFade"] = "1";
                oc_Newobject137["contextFontColor"] = "0";
                oc_Newobject137["contextBackColor"] = "0";
                oc_Newobject137["contextFillColor"] = "0";
                oc_Newobject137["contextFontSize"] = "0";
                oc_Newobject137["editable"] = "0";
                oc_Newobject137["canSave"] = "1";
                oc_Newobject137["canSaveDynamicFields"] = "0";
                oc_Newobject137["Enabled"] = "1";
                #endregion

                oc_Newobject139["#Newobject137"] = oc_Newobject137;

                #region GuiSliderCtrl (ppOptionsNVHighMul)        oc_Newobject138
                ObjectCreator oc_Newobject138 = new ObjectCreator("GuiSliderCtrl", "ppOptionsNVHighMul", typeof(ppOptionsNVHighMul));
                oc_Newobject138["range"] = "1 100";
                oc_Newobject138["ticks"] = "1000";
                oc_Newobject138["snap"] = "0";
                oc_Newobject138["value"] = "1";
                oc_Newobject138["position"] = "119 114";
                oc_Newobject138["extent"] = "233 17";
                oc_Newobject138["minExtent"] = "8 2";
                oc_Newobject138["maxExtent"] = "1920 1080";
                oc_Newobject138["horizSizing"] = "right";
                oc_Newobject138["vertSizing"] = "bottom";
                oc_Newobject138["profile"] = "GuiSliderBoxProfile";
                oc_Newobject138["controlFontColor"] = "0 0 0 0";
                oc_Newobject138["controlFillColor"] = "0 0 0 0";
                oc_Newobject138["backgroundColor"] = "255 255 255 255";
                oc_Newobject138["controlFontSize"] = "14";
                oc_Newobject138["visible"] = "1";
                oc_Newobject138["active"] = "1";
                oc_Newobject138["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject138["hovertime"] = "1000";
                oc_Newobject138["isContainer"] = "0";
                oc_Newobject138["alphaValue"] = "1";
                oc_Newobject138["mouseOverAlphaValue"] = "1";
                oc_Newobject138["alphaFadeTime"] = "1000";
                oc_Newobject138["windowSettings"] = "1";
                oc_Newobject138["alpha"] = "1";
                oc_Newobject138["mouseOverAlpha"] = "1";
                oc_Newobject138["alphaFade"] = "1";
                oc_Newobject138["contextFontColor"] = "0";
                oc_Newobject138["contextBackColor"] = "0";
                oc_Newobject138["contextFillColor"] = "0";
                oc_Newobject138["contextFontSize"] = "0";
                oc_Newobject138["editable"] = "0";
                oc_Newobject138["canSave"] = "1";
                oc_Newobject138["canSaveDynamicFields"] = "0";
                oc_Newobject138["Enabled"] = "1";
                #endregion

                oc_Newobject139["#Newobject138"] = oc_Newobject138;

                #endregion

                oc_Newobject147["#Newobject139"] = oc_Newobject139;

                #region GuiTabPageCtrl (ppOptionsNVDistortionTab)        oc_Newobject146
                ObjectCreator oc_Newobject146 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsNVDistortionTab");
                oc_Newobject146["fitBook"] = "1";
                oc_Newobject146["text"] = "Distortion";
                oc_Newobject146["maxLength"] = "1024";
                oc_Newobject146["docking"] = "None";
                oc_Newobject146["margin"] = "0 0 0 0";
                oc_Newobject146["padding"] = "0 0 0 0";
                oc_Newobject146["anchorTop"] = "1";
                oc_Newobject146["anchorBottom"] = "0";
                oc_Newobject146["anchorLeft"] = "1";
                oc_Newobject146["anchorRight"] = "0";
                oc_Newobject146["position"] = "0 20";
                oc_Newobject146["extent"] = "369 172";
                oc_Newobject146["minExtent"] = "8 2";
                oc_Newobject146["maxExtent"] = "1920 1080";
                oc_Newobject146["horizSizing"] = "right";
                oc_Newobject146["vertSizing"] = "bottom";
                oc_Newobject146["profile"] = "GuiTabPageProfile";
                oc_Newobject146["controlFontColor"] = "0 0 0 0";
                oc_Newobject146["controlFillColor"] = "0 0 0 0";
                oc_Newobject146["backgroundColor"] = "255 255 255 255";
                oc_Newobject146["controlFontSize"] = "10";
                oc_Newobject146["visible"] = "1";
                oc_Newobject146["active"] = "1";
                oc_Newobject146["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject146["tooltip"] = "Contains settings related to the distorition effect in the Night vision postFX";
                oc_Newobject146["hovertime"] = "1000";
                oc_Newobject146["isContainer"] = "1";
                oc_Newobject146["alphaValue"] = "1";
                oc_Newobject146["mouseOverAlphaValue"] = "1";
                oc_Newobject146["alphaFadeTime"] = "1000";
                oc_Newobject146["moveControl"] = "0";
                oc_Newobject146["lockControl"] = "0";
                oc_Newobject146["windowSettings"] = "1";
                oc_Newobject146["alpha"] = "1";
                oc_Newobject146["mouseOverAlpha"] = "1";
                oc_Newobject146["alphaFade"] = "1";
                oc_Newobject146["contextFontColor"] = "0";
                oc_Newobject146["contextBackColor"] = "0";
                oc_Newobject146["contextFillColor"] = "0";
                oc_Newobject146["contextFontSize"] = "0";
                oc_Newobject146["editable"] = "0";
                oc_Newobject146["canSave"] = "1";
                oc_Newobject146["canSaveDynamicFields"] = "0";
                oc_Newobject146["Enabled"] = "1";

                #region GuiSliderCtrl (ppOptionsNVDistMul)        oc_Newobject140
                ObjectCreator oc_Newobject140 = new ObjectCreator("GuiSliderCtrl", "ppOptionsNVDistMul", typeof(ppOptionsNVDistMul));
                oc_Newobject140["range"] = "0.1 1";
                oc_Newobject140["ticks"] = "1000";
                oc_Newobject140["snap"] = "0";
                oc_Newobject140["value"] = "0.1";
                oc_Newobject140["position"] = "116 50";
                oc_Newobject140["extent"] = "233 17";
                oc_Newobject140["minExtent"] = "8 2";
                oc_Newobject140["maxExtent"] = "1920 1080";
                oc_Newobject140["horizSizing"] = "right";
                oc_Newobject140["vertSizing"] = "bottom";
                oc_Newobject140["profile"] = "GuiSliderBoxProfile";
                oc_Newobject140["controlFontColor"] = "0 0 0 0";
                oc_Newobject140["controlFillColor"] = "0 0 0 0";
                oc_Newobject140["backgroundColor"] = "255 255 255 255";
                oc_Newobject140["controlFontSize"] = "14";
                oc_Newobject140["visible"] = "1";
                oc_Newobject140["active"] = "1";
                oc_Newobject140["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject140["hovertime"] = "1000";
                oc_Newobject140["isContainer"] = "0";
                oc_Newobject140["alphaValue"] = "1";
                oc_Newobject140["mouseOverAlphaValue"] = "1";
                oc_Newobject140["alphaFadeTime"] = "1000";
                oc_Newobject140["windowSettings"] = "1";
                oc_Newobject140["alpha"] = "1";
                oc_Newobject140["mouseOverAlpha"] = "1";
                oc_Newobject140["alphaFade"] = "1";
                oc_Newobject140["contextFontColor"] = "0";
                oc_Newobject140["contextBackColor"] = "0";
                oc_Newobject140["contextFillColor"] = "0";
                oc_Newobject140["contextFontSize"] = "0";
                oc_Newobject140["editable"] = "0";
                oc_Newobject140["canSave"] = "1";
                oc_Newobject140["canSaveDynamicFields"] = "0";
                oc_Newobject140["Enabled"] = "1";
                #endregion

                oc_Newobject146["#Newobject140"] = oc_Newobject140;

                #region GuiTextCtrl (ppOptionNDistFreqLabel)        oc_Newobject141
                ObjectCreator oc_Newobject141 = new ObjectCreator("GuiTextCtrl", "ppOptionNDistFreqLabel");
                oc_Newobject141["text"] = "Distortion frequency";
                oc_Newobject141["maxLength"] = "1024";
                oc_Newobject141["margin"] = "0 0 0 0";
                oc_Newobject141["padding"] = "0 0 0 0";
                oc_Newobject141["anchorTop"] = "1";
                oc_Newobject141["anchorBottom"] = "0";
                oc_Newobject141["anchorLeft"] = "1";
                oc_Newobject141["anchorRight"] = "0";
                oc_Newobject141["position"] = "10 77";
                oc_Newobject141["extent"] = "98 15";
                oc_Newobject141["minExtent"] = "8 2";
                oc_Newobject141["maxExtent"] = "1920 1080";
                oc_Newobject141["horizSizing"] = "right";
                oc_Newobject141["vertSizing"] = "bottom";
                oc_Newobject141["profile"] = "GuiTextProfile";
                oc_Newobject141["controlFontColor"] = "0 0 0 0";
                oc_Newobject141["controlFillColor"] = "0 0 0 0";
                oc_Newobject141["backgroundColor"] = "255 255 255 255";
                oc_Newobject141["controlFontSize"] = "14";
                oc_Newobject141["visible"] = "1";
                oc_Newobject141["active"] = "1";
                oc_Newobject141["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject141["tooltip"] = "The luminance threshold at which it becomes overbright";
                oc_Newobject141["hovertime"] = "1000";
                oc_Newobject141["isContainer"] = "0";
                oc_Newobject141["alphaValue"] = "1";
                oc_Newobject141["mouseOverAlphaValue"] = "1";
                oc_Newobject141["alphaFadeTime"] = "1000";
                oc_Newobject141["moveControl"] = "0";
                oc_Newobject141["lockControl"] = "0";
                oc_Newobject141["windowSettings"] = "1";
                oc_Newobject141["alpha"] = "1";
                oc_Newobject141["mouseOverAlpha"] = "1";
                oc_Newobject141["alphaFade"] = "1";
                oc_Newobject141["contextFontColor"] = "0";
                oc_Newobject141["contextBackColor"] = "0";
                oc_Newobject141["contextFillColor"] = "0";
                oc_Newobject141["contextFontSize"] = "0";
                oc_Newobject141["editable"] = "0";
                oc_Newobject141["canSave"] = "1";
                oc_Newobject141["canSaveDynamicFields"] = "0";
                oc_Newobject141["Enabled"] = "1";
                #endregion

                oc_Newobject146["#Newobject141"] = oc_Newobject141;

                #region GuiSliderCtrl (ppOptionsNVDistFreq)        oc_Newobject142
                ObjectCreator oc_Newobject142 = new ObjectCreator("GuiSliderCtrl", "ppOptionsNVDistFreq", typeof(ppOptionsNVDistFreq));
                oc_Newobject142["range"] = "0.1 20";
                oc_Newobject142["ticks"] = "1000";
                oc_Newobject142["snap"] = "0";
                oc_Newobject142["value"] = "0.1";
                oc_Newobject142["position"] = "116 75";
                oc_Newobject142["extent"] = "233 17";
                oc_Newobject142["minExtent"] = "8 2";
                oc_Newobject142["maxExtent"] = "1920 1080";
                oc_Newobject142["horizSizing"] = "right";
                oc_Newobject142["vertSizing"] = "bottom";
                oc_Newobject142["profile"] = "GuiSliderBoxProfile";
                oc_Newobject142["controlFontColor"] = "0 0 0 0";
                oc_Newobject142["controlFillColor"] = "0 0 0 0";
                oc_Newobject142["backgroundColor"] = "255 255 255 255";
                oc_Newobject142["controlFontSize"] = "14";
                oc_Newobject142["visible"] = "1";
                oc_Newobject142["active"] = "1";
                oc_Newobject142["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject142["hovertime"] = "1000";
                oc_Newobject142["isContainer"] = "0";
                oc_Newobject142["alphaValue"] = "1";
                oc_Newobject142["mouseOverAlphaValue"] = "1";
                oc_Newobject142["alphaFadeTime"] = "1000";
                oc_Newobject142["windowSettings"] = "1";
                oc_Newobject142["alpha"] = "1";
                oc_Newobject142["mouseOverAlpha"] = "1";
                oc_Newobject142["alphaFade"] = "1";
                oc_Newobject142["contextFontColor"] = "0";
                oc_Newobject142["contextBackColor"] = "0";
                oc_Newobject142["contextFillColor"] = "0";
                oc_Newobject142["contextFontSize"] = "0";
                oc_Newobject142["editable"] = "0";
                oc_Newobject142["canSave"] = "1";
                oc_Newobject142["canSaveDynamicFields"] = "0";
                oc_Newobject142["Enabled"] = "1";
                #endregion

                oc_Newobject146["#Newobject142"] = oc_Newobject142;

                #region GuiTextCtrl (ppOptionNVDistRollLabel)        oc_Newobject143
                ObjectCreator oc_Newobject143 = new ObjectCreator("GuiTextCtrl", "ppOptionNVDistRollLabel");
                oc_Newobject143["text"] = "Distortion Roll";
                oc_Newobject143["maxLength"] = "1024";
                oc_Newobject143["margin"] = "0 0 0 0";
                oc_Newobject143["padding"] = "0 0 0 0";
                oc_Newobject143["anchorTop"] = "1";
                oc_Newobject143["anchorBottom"] = "0";
                oc_Newobject143["anchorLeft"] = "1";
                oc_Newobject143["anchorRight"] = "0";
                oc_Newobject143["position"] = "41 102";
                oc_Newobject143["extent"] = "67 15";
                oc_Newobject143["minExtent"] = "8 2";
                oc_Newobject143["maxExtent"] = "1920 1080";
                oc_Newobject143["horizSizing"] = "right";
                oc_Newobject143["vertSizing"] = "bottom";
                oc_Newobject143["profile"] = "GuiTextProfile";
                oc_Newobject143["controlFontColor"] = "0 0 0 0";
                oc_Newobject143["controlFillColor"] = "0 0 0 0";
                oc_Newobject143["backgroundColor"] = "255 255 255 255";
                oc_Newobject143["controlFontSize"] = "14";
                oc_Newobject143["visible"] = "1";
                oc_Newobject143["active"] = "1";
                oc_Newobject143["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject143["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject143["hovertime"] = "1000";
                oc_Newobject143["isContainer"] = "0";
                oc_Newobject143["alphaValue"] = "1";
                oc_Newobject143["mouseOverAlphaValue"] = "1";
                oc_Newobject143["alphaFadeTime"] = "1000";
                oc_Newobject143["moveControl"] = "0";
                oc_Newobject143["lockControl"] = "0";
                oc_Newobject143["windowSettings"] = "1";
                oc_Newobject143["alpha"] = "1";
                oc_Newobject143["mouseOverAlpha"] = "1";
                oc_Newobject143["alphaFade"] = "1";
                oc_Newobject143["contextFontColor"] = "0";
                oc_Newobject143["contextBackColor"] = "0";
                oc_Newobject143["contextFillColor"] = "0";
                oc_Newobject143["contextFontSize"] = "0";
                oc_Newobject143["editable"] = "0";
                oc_Newobject143["canSave"] = "1";
                oc_Newobject143["canSaveDynamicFields"] = "0";
                oc_Newobject143["Enabled"] = "1";
                #endregion

                oc_Newobject146["#Newobject143"] = oc_Newobject143;

                #region GuiTextCtrl (ppOptionNVDistMulLabel)        oc_Newobject144
                ObjectCreator oc_Newobject144 = new ObjectCreator("GuiTextCtrl", "ppOptionNVDistMulLabel");
                oc_Newobject144["text"] = "Distortion Multiplier";
                oc_Newobject144["maxLength"] = "1024";
                oc_Newobject144["margin"] = "0 0 0 0";
                oc_Newobject144["padding"] = "0 0 0 0";
                oc_Newobject144["anchorTop"] = "1";
                oc_Newobject144["anchorBottom"] = "0";
                oc_Newobject144["anchorLeft"] = "1";
                oc_Newobject144["anchorRight"] = "0";
                oc_Newobject144["position"] = "18 51";
                oc_Newobject144["extent"] = "90 15";
                oc_Newobject144["minExtent"] = "8 2";
                oc_Newobject144["maxExtent"] = "1920 1080";
                oc_Newobject144["horizSizing"] = "right";
                oc_Newobject144["vertSizing"] = "bottom";
                oc_Newobject144["profile"] = "GuiTextProfile";
                oc_Newobject144["controlFontColor"] = "0 0 0 0";
                oc_Newobject144["controlFillColor"] = "0 0 0 0";
                oc_Newobject144["backgroundColor"] = "255 255 255 255";
                oc_Newobject144["controlFontSize"] = "14";
                oc_Newobject144["visible"] = "1";
                oc_Newobject144["active"] = "1";
                oc_Newobject144["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject144["tooltip"] = "Controls how bright the rays and the object casting them are in the scene.";
                oc_Newobject144["hovertime"] = "1000";
                oc_Newobject144["isContainer"] = "0";
                oc_Newobject144["alphaValue"] = "1";
                oc_Newobject144["mouseOverAlphaValue"] = "1";
                oc_Newobject144["alphaFadeTime"] = "1000";
                oc_Newobject144["moveControl"] = "0";
                oc_Newobject144["lockControl"] = "0";
                oc_Newobject144["windowSettings"] = "1";
                oc_Newobject144["alpha"] = "1";
                oc_Newobject144["mouseOverAlpha"] = "1";
                oc_Newobject144["alphaFade"] = "1";
                oc_Newobject144["contextFontColor"] = "0";
                oc_Newobject144["contextBackColor"] = "0";
                oc_Newobject144["contextFillColor"] = "0";
                oc_Newobject144["contextFontSize"] = "0";
                oc_Newobject144["editable"] = "0";
                oc_Newobject144["canSave"] = "1";
                oc_Newobject144["canSaveDynamicFields"] = "0";
                oc_Newobject144["Enabled"] = "1";
                #endregion

                oc_Newobject146["#Newobject144"] = oc_Newobject144;

                #region GuiSliderCtrl (ppOptionsNVDistRoll)        oc_Newobject145
                ObjectCreator oc_Newobject145 = new ObjectCreator("GuiSliderCtrl", "ppOptionsNVDistRoll", typeof(ppOptionsNVDistRoll));
                oc_Newobject145["range"] = "1 100";
                oc_Newobject145["ticks"] = "1000";
                oc_Newobject145["snap"] = "0";
                oc_Newobject145["value"] = "1";
                oc_Newobject145["position"] = "116 101";
                oc_Newobject145["extent"] = "233 17";
                oc_Newobject145["minExtent"] = "8 2";
                oc_Newobject145["maxExtent"] = "1920 1080";
                oc_Newobject145["horizSizing"] = "right";
                oc_Newobject145["vertSizing"] = "bottom";
                oc_Newobject145["profile"] = "GuiSliderBoxProfile";
                oc_Newobject145["controlFontColor"] = "0 0 0 0";
                oc_Newobject145["controlFillColor"] = "0 0 0 0";
                oc_Newobject145["backgroundColor"] = "255 255 255 255";
                oc_Newobject145["controlFontSize"] = "14";
                oc_Newobject145["visible"] = "1";
                oc_Newobject145["active"] = "1";
                oc_Newobject145["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject145["hovertime"] = "1000";
                oc_Newobject145["isContainer"] = "0";
                oc_Newobject145["alphaValue"] = "1";
                oc_Newobject145["mouseOverAlphaValue"] = "1";
                oc_Newobject145["alphaFadeTime"] = "1000";
                oc_Newobject145["windowSettings"] = "1";
                oc_Newobject145["alpha"] = "1";
                oc_Newobject145["mouseOverAlpha"] = "1";
                oc_Newobject145["alphaFade"] = "1";
                oc_Newobject145["contextFontColor"] = "0";
                oc_Newobject145["contextBackColor"] = "0";
                oc_Newobject145["contextFillColor"] = "0";
                oc_Newobject145["contextFontSize"] = "0";
                oc_Newobject145["editable"] = "0";
                oc_Newobject145["canSave"] = "1";
                oc_Newobject145["canSaveDynamicFields"] = "0";
                oc_Newobject145["Enabled"] = "1";
                #endregion

                oc_Newobject146["#Newobject145"] = oc_Newobject145;

                #endregion

                oc_Newobject147["#Newobject146"] = oc_Newobject146;

                #endregion

                oc_Newobject149["#Newobject147"] = oc_Newobject147;

                #region GuiCheckBoxCtrl (ppOptionsEnableNV)        oc_Newobject148
                ObjectCreator oc_Newobject148 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableNV", typeof(ppOptionsEnableNV));
                oc_Newobject148["text"] = "Enable";
                oc_Newobject148["groupNum"] = "-1";
                oc_Newobject148["buttonType"] = "ToggleButton";
                oc_Newobject148["useMouseEvents"] = "0";
                oc_Newobject148["position"] = "329 7";
                oc_Newobject148["extent"] = "53 20";
                oc_Newobject148["minExtent"] = "8 2";
                oc_Newobject148["maxExtent"] = "1920 1080";
                oc_Newobject148["horizSizing"] = "right";
                oc_Newobject148["vertSizing"] = "bottom";
                oc_Newobject148["profile"] = "GuiCheckBoxProfile";
                oc_Newobject148["controlFontColor"] = "0 0 0 0";
                oc_Newobject148["backgroundColor"] = "255 255 255 255";
                oc_Newobject148["controlFontSize"] = "14";
                oc_Newobject148["visible"] = "1";
                oc_Newobject148["active"] = "1";
                oc_Newobject148["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject148["tooltip"] = "Enable/Disable the Night Vision postFX";
                oc_Newobject148["hovertime"] = "1000";
                oc_Newobject148["isContainer"] = "0";
                oc_Newobject148["alphaValue"] = "1";
                oc_Newobject148["mouseOverAlphaValue"] = "1";
                oc_Newobject148["alphaFadeTime"] = "1000";
                oc_Newobject148["windowSettings"] = "1";
                oc_Newobject148["alpha"] = "1";
                oc_Newobject148["mouseOverAlpha"] = "1";
                oc_Newobject148["alphaFade"] = "1";
                oc_Newobject148["contextFontColor"] = "0";
                oc_Newobject148["contextBackColor"] = "0";
                oc_Newobject148["contextFontSize"] = "0";
                oc_Newobject148["editable"] = "0";
                oc_Newobject148["canSave"] = "1";
                oc_Newobject148["canSaveDynamicFields"] = "0";
                oc_Newobject148["Enabled"] = "1";
                #endregion

                oc_Newobject149["#Newobject148"] = oc_Newobject148;

                #endregion

                oc_Newobject150["#Newobject149"] = oc_Newobject149;

                #region GuiTabPageCtrl (ppOptionsSNALTab)        oc_Newobject160
                ObjectCreator oc_Newobject160 = new ObjectCreator("GuiTabPageCtrl", "ppOptionsSNALTab");
                oc_Newobject160["fitBook"] = "1";
                oc_Newobject160["text"] = "SNAL";
                oc_Newobject160["maxLength"] = "1024";
                oc_Newobject160["margin"] = "0 0 0 0";
                oc_Newobject160["padding"] = "0 0 0 0";
                oc_Newobject160["anchorTop"] = "1";
                oc_Newobject160["anchorBottom"] = "0";
                oc_Newobject160["anchorLeft"] = "1";
                oc_Newobject160["anchorRight"] = "0";
                oc_Newobject160["position"] = "0 20";
                oc_Newobject160["extent"] = "600 213";
                oc_Newobject160["minExtent"] = "8 2";
                oc_Newobject160["maxExtent"] = "1920 1080";
                oc_Newobject160["horizSizing"] = "right";
                oc_Newobject160["vertSizing"] = "bottom";
                oc_Newobject160["profile"] = "GuiTabPageProfile";
                oc_Newobject160["controlFontColor"] = "0 0 0 0";
                oc_Newobject160["controlFillColor"] = "0 0 0 0";
                oc_Newobject160["backgroundColor"] = "255 255 255 255";
                oc_Newobject160["controlFontSize"] = "10";
                oc_Newobject160["visible"] = "1";
                oc_Newobject160["active"] = "1";
                oc_Newobject160["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject160["hovertime"] = "1000";
                oc_Newobject160["isContainer"] = "1";
                oc_Newobject160["alphaValue"] = "1";
                oc_Newobject160["mouseOverAlphaValue"] = "1";
                oc_Newobject160["alphaFadeTime"] = "1000";
                oc_Newobject160["moveControl"] = "0";
                oc_Newobject160["lockControl"] = "0";
                oc_Newobject160["windowSettings"] = "1";
                oc_Newobject160["alpha"] = "1";
                oc_Newobject160["mouseOverAlpha"] = "1";
                oc_Newobject160["alphaFade"] = "1";
                oc_Newobject160["contextFontColor"] = "0";
                oc_Newobject160["contextBackColor"] = "0";
                oc_Newobject160["contextFillColor"] = "0";
                oc_Newobject160["contextFontSize"] = "0";
                oc_Newobject160["editable"] = "0";
                oc_Newobject160["canSave"] = "1";
                oc_Newobject160["canSaveDynamicFields"] = "0";
                oc_Newobject160["Enabled"] = "1";

                #region GuiBitmapBorderCtrl ()        oc_Newobject161
                ObjectCreator oc_Newobject161 = new ObjectCreator("GuiBitmapBorderCtrl", "");
                oc_Newobject161["position"] = "12 14";
                oc_Newobject161["extent"] = "564 187";
                oc_Newobject161["minExtent"] = "8 2";
                oc_Newobject161["maxExtent"] = "1920 1080";
                oc_Newobject161["horizSizing"] = "right";
                oc_Newobject161["vertSizing"] = "bottom";
                oc_Newobject161["profile"] = "GuiTabBorderProfile";
                oc_Newobject161["controlFontColor"] = "0 0 0 0";
                oc_Newobject161["controlFillColor"] = "0 0 0 0";
                oc_Newobject161["backgroundColor"] = "255 255 255 255";
                oc_Newobject161["controlFontSize"] = "14";
                oc_Newobject161["visible"] = "1";
                oc_Newobject161["active"] = "1";
                oc_Newobject161["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject161["hovertime"] = "1000";
                oc_Newobject161["isContainer"] = "0";
                oc_Newobject161["alphaValue"] = "1";
                oc_Newobject161["mouseOverAlphaValue"] = "1";
                oc_Newobject161["alphaFadeTime"] = "1000";
                oc_Newobject161["moveControl"] = "0";
                oc_Newobject161["lockControl"] = "0";
                oc_Newobject161["windowSettings"] = "1";
                oc_Newobject161["alpha"] = "1";
                oc_Newobject161["mouseOverAlpha"] = "1";
                oc_Newobject161["alphaFade"] = "1";
                oc_Newobject161["contextFontColor"] = "0";
                oc_Newobject161["contextBackColor"] = "0";
                oc_Newobject161["contextFillColor"] = "0";
                oc_Newobject161["contextFontSize"] = "0";
                oc_Newobject161["editable"] = "0";
                oc_Newobject161["canSave"] = "1";
                oc_Newobject161["canSaveDynamicFields"] = "0";
                oc_Newobject161["Enabled"] = "1";
                #endregion

                oc_Newobject160["#Newobject161"] = oc_Newobject161;

                #region GuiCheckBoxCtrl (ppOptionsEnableSNAL)        oc_Newobject162
                ObjectCreator oc_Newobject162 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnableSNAL");
                oc_Newobject162["text"] = "Enable";
                oc_Newobject162["groupNum"] = "-1";
                oc_Newobject162["buttonType"] = "ToggleButton";
                oc_Newobject162["useMouseEvents"] = "0";
                oc_Newobject162["position"] = "414 27";
                oc_Newobject162["extent"] = "140 30";
                oc_Newobject162["minExtent"] = "8 2";
                oc_Newobject162["maxExtent"] = "1920 1080";
                oc_Newobject162["horizSizing"] = "right";
                oc_Newobject162["vertSizing"] = "bottom";
                oc_Newobject162["profile"] = "GuiCheckBoxProfile";
                oc_Newobject162["controlFontColor"] = "0 0 0 0";
                oc_Newobject162["backgroundColor"] = "255 255 255 255";
                oc_Newobject162["controlFontSize"] = "14";
                oc_Newobject162["visible"] = "1";
                oc_Newobject162["active"] = "1";
                oc_Newobject162["variable"] = "$AL::SNALRender";
                oc_Newobject162["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject162["tooltip"] = "Enables Shaded Normal Ambient Lighting.";
                oc_Newobject162["hovertime"] = "1000";
                oc_Newobject162["isContainer"] = "0";
                oc_Newobject162["alphaValue"] = "1";
                oc_Newobject162["mouseOverAlphaValue"] = "1";
                oc_Newobject162["alphaFadeTime"] = "1000";
                oc_Newobject162["windowSettings"] = "1";
                oc_Newobject162["alpha"] = "1";
                oc_Newobject162["mouseOverAlpha"] = "1";
                oc_Newobject162["alphaFade"] = "1";
                oc_Newobject162["contextFontColor"] = "0";
                oc_Newobject162["contextBackColor"] = "0";
                oc_Newobject162["contextFontSize"] = "0";
                oc_Newobject162["editable"] = "0";
                oc_Newobject162["canSave"] = "1";
                oc_Newobject162["canSaveDynamicFields"] = "0";
                oc_Newobject162["Enabled"] = "1";
                #endregion

                oc_Newobject160["#Newobject162"] = oc_Newobject162;

                #endregion

                oc_Newobject150["#Newobject160"] = oc_Newobject160;

                #endregion

                oc_Newobject158["#Newobject150"] = oc_Newobject150;

                #region GuiButtonCtrl (ppOptionsApply)        oc_Newobject151
                ObjectCreator oc_Newobject151 = new ObjectCreator("GuiButtonCtrl", "ppOptionsApply");
                oc_Newobject151["text"] = "Apply";
                oc_Newobject151["groupNum"] = "-1";
                oc_Newobject151["buttonType"] = "PushButton";
                oc_Newobject151["useMouseEvents"] = "0";
                oc_Newobject151["position"] = "429 303";
                oc_Newobject151["extent"] = "93 23";
                oc_Newobject151["minExtent"] = "8 8";
                oc_Newobject151["maxExtent"] = "1920 1080";
                oc_Newobject151["horizSizing"] = "right";
                oc_Newobject151["vertSizing"] = "bottom";
                oc_Newobject151["profile"] = "GuiButtonProfile";
                oc_Newobject151["controlFontColor"] = "0 0 0 0";
                oc_Newobject151["backgroundColor"] = "255 255 255 255";
                oc_Newobject151["controlFontSize"] = "14";
                oc_Newobject151["visible"] = "1";
                oc_Newobject151["active"] = "1";
                oc_Newobject151["command"] = "PostFXManager.settingsApplyAll(); Canvas.popDialog(PostFXManager);";
                oc_Newobject151["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject151["tooltip"] = "Apply the settings and close this dialog";
                oc_Newobject151["hovertime"] = "1000";
                oc_Newobject151["isContainer"] = "0";
                oc_Newobject151["alphaValue"] = "1";
                oc_Newobject151["mouseOverAlphaValue"] = "1";
                oc_Newobject151["alphaFadeTime"] = "1000";
                oc_Newobject151["windowSettings"] = "1";
                oc_Newobject151["alpha"] = "1";
                oc_Newobject151["mouseOverAlpha"] = "1";
                oc_Newobject151["alphaFade"] = "1";
                oc_Newobject151["contextFontColor"] = "0";
                oc_Newobject151["contextBackColor"] = "0";
                oc_Newobject151["contextFontSize"] = "0";
                oc_Newobject151["editable"] = "0";
                oc_Newobject151["canSave"] = "1";
                oc_Newobject151["canSaveDynamicFields"] = "0";
                oc_Newobject151["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject151"] = oc_Newobject151;

                #region GuiButtonCtrl (ppOptionsSavePreset)        oc_Newobject152
                ObjectCreator oc_Newobject152 = new ObjectCreator("GuiButtonCtrl", "ppOptionsSavePreset");
                oc_Newobject152["text"] = "Save Preset...";
                oc_Newobject152["groupNum"] = "-1";
                oc_Newobject152["buttonType"] = "PushButton";
                oc_Newobject152["useMouseEvents"] = "0";
                oc_Newobject152["position"] = "180 303";
                oc_Newobject152["extent"] = "93 23";
                oc_Newobject152["minExtent"] = "8 8";
                oc_Newobject152["maxExtent"] = "1920 1080";
                oc_Newobject152["horizSizing"] = "right";
                oc_Newobject152["vertSizing"] = "bottom";
                oc_Newobject152["profile"] = "GuiButtonProfile";
                oc_Newobject152["controlFontColor"] = "0 0 0 0";
                oc_Newobject152["backgroundColor"] = "255 255 255 255";
                oc_Newobject152["controlFontSize"] = "14";
                oc_Newobject152["visible"] = "1";
                oc_Newobject152["active"] = "1";
                oc_Newobject152["command"] = "PostFXManager.savePresetFile();";
                oc_Newobject152["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject152["tooltip"] = "Save the preset to a file to disk for later use (use postfx::applyPreset)";
                oc_Newobject152["hovertime"] = "1000";
                oc_Newobject152["isContainer"] = "0";
                oc_Newobject152["alphaValue"] = "1";
                oc_Newobject152["mouseOverAlphaValue"] = "1";
                oc_Newobject152["alphaFadeTime"] = "1000";
                oc_Newobject152["windowSettings"] = "1";
                oc_Newobject152["alpha"] = "1";
                oc_Newobject152["mouseOverAlpha"] = "1";
                oc_Newobject152["alphaFade"] = "1";
                oc_Newobject152["contextFontColor"] = "0";
                oc_Newobject152["contextBackColor"] = "0";
                oc_Newobject152["contextFontSize"] = "0";
                oc_Newobject152["editable"] = "0";
                oc_Newobject152["canSave"] = "1";
                oc_Newobject152["canSaveDynamicFields"] = "0";
                oc_Newobject152["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject152"] = oc_Newobject152;

                #region GuiButtonCtrl (ppOptionsLoadPreset)        oc_Newobject153
                ObjectCreator oc_Newobject153 = new ObjectCreator("GuiButtonCtrl", "ppOptionsLoadPreset");
                oc_Newobject153["text"] = "Load Preset...";
                oc_Newobject153["groupNum"] = "-1";
                oc_Newobject153["buttonType"] = "PushButton";
                oc_Newobject153["useMouseEvents"] = "0";
                oc_Newobject153["position"] = "41 303";
                oc_Newobject153["extent"] = "93 23";
                oc_Newobject153["minExtent"] = "8 8";
                oc_Newobject153["maxExtent"] = "1920 1080";
                oc_Newobject153["horizSizing"] = "right";
                oc_Newobject153["vertSizing"] = "bottom";
                oc_Newobject153["profile"] = "GuiButtonProfile";
                oc_Newobject153["controlFontColor"] = "0 0 0 0";
                oc_Newobject153["backgroundColor"] = "255 255 255 255";
                oc_Newobject153["controlFontSize"] = "14";
                oc_Newobject153["visible"] = "1";
                oc_Newobject153["active"] = "1";
                oc_Newobject153["command"] = "PostFXManager.loadPresetFile();";
                oc_Newobject153["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject153["tooltip"] = "Load a post FX preset file from disk";
                oc_Newobject153["hovertime"] = "1000";
                oc_Newobject153["isContainer"] = "0";
                oc_Newobject153["alphaValue"] = "1";
                oc_Newobject153["mouseOverAlphaValue"] = "1";
                oc_Newobject153["alphaFadeTime"] = "1000";
                oc_Newobject153["windowSettings"] = "1";
                oc_Newobject153["alpha"] = "1";
                oc_Newobject153["mouseOverAlpha"] = "1";
                oc_Newobject153["alphaFade"] = "1";
                oc_Newobject153["contextFontColor"] = "0";
                oc_Newobject153["contextBackColor"] = "0";
                oc_Newobject153["contextFontSize"] = "0";
                oc_Newobject153["editable"] = "0";
                oc_Newobject153["canSave"] = "1";
                oc_Newobject153["canSaveDynamicFields"] = "0";
                oc_Newobject153["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject153"] = oc_Newobject153;

                #region GuiCheckBoxCtrl (ppOptionsEnable)        oc_Newobject154
                ObjectCreator oc_Newobject154 = new ObjectCreator("GuiCheckBoxCtrl", "ppOptionsEnable",
                typeof(WinterLeaf.Demo.Full.Models.User.GameCode.Client.PostEffects.Gui.ppOptionsEnable));
                oc_Newobject154["text"] = "Enable PostFX System";
                oc_Newobject154["groupNum"] = "-1";
                oc_Newobject154["buttonType"] = "ToggleButton";
                oc_Newobject154["useMouseEvents"] = "0";
                oc_Newobject154["position"] = "13 25";
                oc_Newobject154["extent"] = "127 30";
                oc_Newobject154["minExtent"] = "8 2";
                oc_Newobject154["maxExtent"] = "1920 1080";
                oc_Newobject154["horizSizing"] = "right";
                oc_Newobject154["vertSizing"] = "bottom";
                oc_Newobject154["profile"] = "GuiCheckBoxProfile";
                oc_Newobject154["controlFontColor"] = "0 0 0 0";
                oc_Newobject154["backgroundColor"] = "255 255 255 255";
                oc_Newobject154["controlFontSize"] = "14";
                oc_Newobject154["visible"] = "1";
                oc_Newobject154["active"] = "1";
                oc_Newobject154["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject154["tooltip"] = "Enable or Disable the postFX system";
                oc_Newobject154["hovertime"] = "1000";
                oc_Newobject154["isContainer"] = "0";
                oc_Newobject154["alphaValue"] = "1";
                oc_Newobject154["mouseOverAlphaValue"] = "1";
                oc_Newobject154["alphaFadeTime"] = "1000";
                oc_Newobject154["windowSettings"] = "1";
                oc_Newobject154["alpha"] = "1";
                oc_Newobject154["mouseOverAlpha"] = "1";
                oc_Newobject154["alphaFade"] = "1";
                oc_Newobject154["contextFontColor"] = "0";
                oc_Newobject154["contextBackColor"] = "0";
                oc_Newobject154["contextFontSize"] = "0";
                oc_Newobject154["editable"] = "0";
                oc_Newobject154["canSave"] = "1";
                oc_Newobject154["canSaveDynamicFields"] = "0";
                oc_Newobject154["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject154"] = oc_Newobject154;

                #region GuiPopUpMenuCtrl (ppOptionsQuality)        oc_Newobject155
                ObjectCreator oc_Newobject155 = new ObjectCreator("GuiPopUpMenuCtrl", "ppOptionsQuality");
                oc_Newobject155["maxPopupHeight"] = "200";
                oc_Newobject155["sbUsesNAColor"] = "0";
                oc_Newobject155["reverseTextList"] = "0";
                oc_Newobject155["bitmapBounds"] = "16 16";
                oc_Newobject155["maxLength"] = "1024";
                oc_Newobject155["margin"] = "0 0 0 0";
                oc_Newobject155["padding"] = "0 0 0 0";
                oc_Newobject155["anchorTop"] = "1";
                oc_Newobject155["anchorBottom"] = "0";
                oc_Newobject155["anchorLeft"] = "1";
                oc_Newobject155["anchorRight"] = "0";
                oc_Newobject155["position"] = "392 30";
                oc_Newobject155["extent"] = "122 21";
                oc_Newobject155["minExtent"] = "8 2";
                oc_Newobject155["maxExtent"] = "1920 1080";
                oc_Newobject155["horizSizing"] = "right";
                oc_Newobject155["vertSizing"] = "bottom";
                oc_Newobject155["profile"] = "GuiPopUpMenuProfile";
                oc_Newobject155["controlFontColor"] = "0 0 0 0";
                oc_Newobject155["controlFillColor"] = "0 0 0 0";
                oc_Newobject155["backgroundColor"] = "255 255 255 255";
                oc_Newobject155["controlFontSize"] = "14";
                oc_Newobject155["visible"] = "1";
                oc_Newobject155["active"] = "1";
                oc_Newobject155["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject155["tooltip"] = "Used to adjust the quality/performance settings of the PostFX system. Some PostFX may not adhere to the settings in this dialog.";
                oc_Newobject155["hovertime"] = "1000";
                oc_Newobject155["isContainer"] = "0";
                oc_Newobject155["alphaValue"] = "1";
                oc_Newobject155["mouseOverAlphaValue"] = "1";
                oc_Newobject155["alphaFadeTime"] = "1000";
                oc_Newobject155["moveControl"] = "0";
                oc_Newobject155["lockControl"] = "0";
                oc_Newobject155["windowSettings"] = "1";
                oc_Newobject155["alpha"] = "1";
                oc_Newobject155["mouseOverAlpha"] = "1";
                oc_Newobject155["alphaFade"] = "1";
                oc_Newobject155["contextFontColor"] = "0";
                oc_Newobject155["contextBackColor"] = "0";
                oc_Newobject155["contextFillColor"] = "0";
                oc_Newobject155["contextFontSize"] = "0";
                oc_Newobject155["editable"] = "0";
                oc_Newobject155["canSave"] = "1";
                oc_Newobject155["canSaveDynamicFields"] = "0";
                oc_Newobject155["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject155"] = oc_Newobject155;

                #region GuiTextCtrl (ppOptionsQualityLabel)        oc_Newobject156
                ObjectCreator oc_Newobject156 = new ObjectCreator("GuiTextCtrl", "ppOptionsQualityLabel");
                oc_Newobject156["text"] = "Quality";
                oc_Newobject156["maxLength"] = "1024";
                oc_Newobject156["margin"] = "0 0 0 0";
                oc_Newobject156["padding"] = "0 0 0 0";
                oc_Newobject156["anchorTop"] = "1";
                oc_Newobject156["anchorBottom"] = "0";
                oc_Newobject156["anchorLeft"] = "1";
                oc_Newobject156["anchorRight"] = "0";
                oc_Newobject156["position"] = "340 39";
                oc_Newobject156["extent"] = "39 12";
                oc_Newobject156["minExtent"] = "8 2";
                oc_Newobject156["maxExtent"] = "1920 1080";
                oc_Newobject156["horizSizing"] = "right";
                oc_Newobject156["vertSizing"] = "bottom";
                oc_Newobject156["profile"] = "GuiTextProfile";
                oc_Newobject156["controlFontColor"] = "0 0 0 0";
                oc_Newobject156["controlFillColor"] = "0 0 0 0";
                oc_Newobject156["backgroundColor"] = "255 255 255 255";
                oc_Newobject156["controlFontSize"] = "14";
                oc_Newobject156["visible"] = "1";
                oc_Newobject156["active"] = "1";
                oc_Newobject156["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject156["tooltip"] = "Used to adjust the quality/performance settings of the PostFX system. Some PostFX may not adhere to the settings in this dialog.";
                oc_Newobject156["hovertime"] = "1000";
                oc_Newobject156["isContainer"] = "0";
                oc_Newobject156["alphaValue"] = "1";
                oc_Newobject156["mouseOverAlphaValue"] = "1";
                oc_Newobject156["alphaFadeTime"] = "1000";
                oc_Newobject156["moveControl"] = "0";
                oc_Newobject156["lockControl"] = "0";
                oc_Newobject156["windowSettings"] = "1";
                oc_Newobject156["alpha"] = "1";
                oc_Newobject156["mouseOverAlpha"] = "1";
                oc_Newobject156["alphaFade"] = "1";
                oc_Newobject156["contextFontColor"] = "0";
                oc_Newobject156["contextBackColor"] = "0";
                oc_Newobject156["contextFillColor"] = "0";
                oc_Newobject156["contextFontSize"] = "0";
                oc_Newobject156["editable"] = "0";
                oc_Newobject156["canSave"] = "1";
                oc_Newobject156["canSaveDynamicFields"] = "0";
                oc_Newobject156["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject156"] = oc_Newobject156;

                #region GuiButtonCtrl (ppOptionsOk1)        oc_Newobject157
                ObjectCreator oc_Newobject157 = new ObjectCreator("GuiButtonCtrl", "ppOptionsOk1");
                oc_Newobject157["text"] = "Revert";
                oc_Newobject157["groupNum"] = "-1";
                oc_Newobject157["buttonType"] = "PushButton";
                oc_Newobject157["useMouseEvents"] = "0";
                oc_Newobject157["position"] = "303 303";
                oc_Newobject157["extent"] = "93 23";
                oc_Newobject157["minExtent"] = "8 8";
                oc_Newobject157["maxExtent"] = "1920 1080";
                oc_Newobject157["horizSizing"] = "right";
                oc_Newobject157["vertSizing"] = "bottom";
                oc_Newobject157["profile"] = "GuiButtonProfile";
                oc_Newobject157["controlFontColor"] = "0 0 0 0";
                oc_Newobject157["backgroundColor"] = "255 255 255 255";
                oc_Newobject157["controlFontSize"] = "14";
                oc_Newobject157["visible"] = "1";
                oc_Newobject157["active"] = "1";
                oc_Newobject157["command"] = "postProcessOptionsDlg.applySettings(); Canvas.popDialog(postProcessOptionsDlg);";
                oc_Newobject157["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject157["tooltip"] = "Revert any changes made since opening the dialog";
                oc_Newobject157["hovertime"] = "1000";
                oc_Newobject157["isContainer"] = "0";
                oc_Newobject157["alphaValue"] = "1";
                oc_Newobject157["mouseOverAlphaValue"] = "1";
                oc_Newobject157["alphaFadeTime"] = "1000";
                oc_Newobject157["windowSettings"] = "1";
                oc_Newobject157["alpha"] = "1";
                oc_Newobject157["mouseOverAlpha"] = "1";
                oc_Newobject157["alphaFade"] = "1";
                oc_Newobject157["contextFontColor"] = "0";
                oc_Newobject157["contextBackColor"] = "0";
                oc_Newobject157["contextFontSize"] = "0";
                oc_Newobject157["editable"] = "0";
                oc_Newobject157["canSave"] = "1";
                oc_Newobject157["canSaveDynamicFields"] = "0";
                oc_Newobject157["Enabled"] = "1";
                #endregion

                oc_Newobject158["#Newobject157"] = oc_Newobject157;

                #endregion

                oc_Newobject159["#Newobject158"] = oc_Newobject158;

                #endregion
                oc_Newobject159.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void createGui()
            {
            omni.sGlobal["$PostFXManager::defaultPreset"] = "core/scripts/client/postFx/default.postfxpreset.cs";

            // Used to name the saved files.
            omni.sGlobal["$PostFXManager::fileExtension"] = ".postfxpreset.cs";

            // The filter string for file open/save dialogs.
            omni.sGlobal["$PostFXManager::fileFilter"] = "Post Effect Presets|*.postfxpreset.cs";

            // Enable / disable PostFX when loading presets or just apply the settings?
            omni.bGlobal["$PostFXManager::forceEnableFromPresets"] = true;

            omni.bGlobal["$PostFXManager::vebose"] = true;

            if (!guicreated)
                {
                //until I rip out gui's I need to execute the script.
                //omni.Util.exec("core/scripts/client/postFx/postFXManager.gui", false, false);
                initialize();
                guicreated = true;
                }
            }

        public void postVerbose(string msg)
            {
            if (bGlobal["$PostFXManager::vebose"])
                console.print(msg);
            }


        public bool getEnableResultFromControl(GuiControl control)
            {
            return (control.getValue().AsInt() == 1);
            }

        public override void onDialogPush()
            {
            //Apply the settings to the controls
            postVerbose("% - PostFX Manager - Loading GUI.");
            settingsRefreshAll();
            }

        public void settingsSetEnabled(bool bEnablePostFX)
            {
            bGlobal["$PostFXManager::PostFX::Enabled"] = bEnablePostFX;
            //if to enable the postFX, apply the ones that are enabled
            if (bEnablePostFX)
                {
                if (bGlobal["$PostFXManager::PostFX::EnableSSAO"])
                    ((PostEffect)"SSAOPostFx").enable();
                else
                    ((PostEffect)"SSAOPostFx").disable();

                if (bGlobal["$PostFXManager::PostFX::EnableSSAO2"])
                    ((PostEffect)"SSAO2PostFx").enable();
                else
                    ((PostEffect)"SSAO2PostFx").disable();

                if (bGlobal["$PostFXManager::PostFX::EnableHDR"])
                    ((PostEffect)"HDRPostFX").enable();
                else
                    ((PostEffect)"HDRPostFX").disable();

                if (bGlobal["$PostFXManager::PostFX::EnableLightRays"])
                    ((PostEffect)"LightRayPostFX").enable();
                else
                    ((PostEffect)"LightRayPostFX").disable();

                if (bGlobal["$PostFXManager::PostFX::EnableDOF"])
                    ((PostEffect)"DOFPostEffect").enable();
                else
                    ((PostEffect)"DOFPostEffect").disable();

                if ( bGlobal["$PostFXManager::PostFX::EnableImageOpt"] )
                    ((PostEffect)"ImageOptFX").enable();
                else
                    ((PostEffect)"ImageOptFX").disable();

                postVerbose("% - PostFX Manager - PostFX enabled");
                }
            else
                {
                ((PostEffect)"SSAOPostFx").disable();
                ((PostEffect)"SSAO2PostFx").disable();
                ((PostEffect)"HDRPostFX").disable();
                ((PostEffect)"LightRayPostFX").disable();
                ((PostEffect)"DOFPostEffect").disable();

                ((PostEffect)"ImageOptFX").disable();
                postVerbose("% - PostFX Manager - PostFX disabled");
                }
            }

        public void settingsEffectSetEnabled(string sName, bool bEnable)
            {
            PostEffect postEffect = null;
            switch (sName)
                {
                case "SSAO":
                    postEffect = "SSAOPostFx";
                    bGlobal["$PostFXManager::PostFX::EnableSSAO"] = bEnable;
                    break;
                case "SSAO2":
                    postEffect = "SSAO2PostFx";
                    bGlobal["$PostFXManager::PostFX::EnableSSAO2"] = bEnable;
                    break;
                case "HDR":
                    postEffect = "HDRPostFX";
                    bGlobal["$PostFXManager::PostFX::EnableHDR"] = bEnable;
                    break;
                case "LightRays":
                    postEffect = "LightRayPostFX";
                    bGlobal["$PostFXManager::PostFX::EnableLightRays"] = bEnable;
                    break;
                case "DOF":
                    postEffect = "DOFPostEffect";
                    bGlobal["$PostFXManager::PostFX::EnableDOF"] = bEnable;
                    break;
                case "Sharp":
                    postEffect = "SharpnessPostFX";
                    bGlobal["$PostFXManager::PostFX::EnableSharpness"] = bEnable;
                    break;
                case "NV":
                    postEffect = "NightVisionPostFX";
                    //bGlobal["$PostFXManager::PostFX::EnableDOF"] = bEnable;
                    break;
                case "ImageOpt":
                    postEffect = "ImageOptFX";
                    bGlobal["$PostFXManager::PostFX::EnableImageOpt"] = bEnable;
                    break;
                default:
                    return;
                }

            if (bEnable)
                {
                postEffect.enable();
                postVerbose("% - PostFX Manager - " + sName + " enabled");
                }
            else
                {
                postEffect.disable();
                postVerbose("% - PostFX Manager - " + sName + " disabled");
                }
            }

        public void settingsRefreshSSAO()
            {
            //Apply the enabled flag
            ((GuiCheckBoxCtrl)"ppOptionsEnableSSAO").setValue(
                bGlobal["$PostFXManager::PostFX::EnableSSAO"].AsString());

            //Add the items we need to display

            GuiPopUpMenuCtrl ppOptionsSSAOQuality = "ppOptionsSSAOQuality";
            ppOptionsSSAOQuality.clear();
            ppOptionsSSAOQuality.add("Low", 0);
            ppOptionsSSAOQuality.add("Medium", 1);
            ppOptionsSSAOQuality.add("High", 2);

            //Set the selected, after adding the items!
            ppOptionsSSAOQuality.setSelected(sGlobal["$SSAOPostFx::quality"].AsInt());

            //SSAO - Set the values of the sliders, General Tab
            ((GuiSliderCtrl)"ppOptionsSSAOOverallStrength").setValue(sGlobal["$SSAOPostFx::overallStrength"]);
            ((GuiSliderCtrl)"ppOptionsSSAOBlurDepth").setValue(sGlobal["$SSAOPostFx::blurDepthTol"]);
            ((GuiSliderCtrl)"ppOptionsSSAOBlurNormal").setValue(sGlobal["$SSAOPostFx::blurNormalTol"]);

            //SSAO - Set the values for the near tab
            ((GuiSliderCtrl)"ppOptionsSSAONearDepthMax").setValue(sGlobal["$SSAOPostFx::sDepthMax"]);
            ((GuiSliderCtrl)"ppOptionsSSAONearDepthMin").setValue(sGlobal["$SSAOPostFx::sDepthMin"]);
            ((GuiSliderCtrl)"ppOptionsSSAONearRadius").setValue(sGlobal["$SSAOPostFx::sRadius"]);
            ((GuiSliderCtrl)"ppOptionsSSAONearStrength").setValue(sGlobal["$SSAOPostFx::sStrength"]);
            ((GuiSliderCtrl)"ppOptionsSSAONearToleranceNormal").setValue(sGlobal["$SSAOPostFx::sNormalTol"]);
            ((GuiSliderCtrl)"ppOptionsSSAONearTolerancePower").setValue(sGlobal["$SSAOPostFx::sNormalPow"]);

            //SSAO - Set the values for the far tab
            ((GuiSliderCtrl)"ppOptionsSSAOFarDepthMax").setValue(sGlobal["$SSAOPostFx::lDepthMax"]);
            ((GuiSliderCtrl)"ppOptionsSSAOFarDepthMin").setValue(sGlobal["$SSAOPostFx::lDepthMin"]);
            ((GuiSliderCtrl)"ppOptionsSSAOFarRadius").setValue(sGlobal["$SSAOPostFx::lRadius"]);
            ((GuiSliderCtrl)"ppOptionsSSAOFarStrength").setValue(sGlobal["$SSAOPostFx::lStrength"]);
            ((GuiSliderCtrl)"ppOptionsSSAOFarToleranceNormal").setValue(sGlobal["$SSAOPostFx::lNormalTol"]);
            ((GuiSliderCtrl)"ppOptionsSSAOFarTolerancePower").setValue(sGlobal["$SSAOPostFx::lNormalPow"]);
            }

        //SSAO 2
        public void settingsRefreshSSAO2()
            {
            //Apply the enabled flag
            ((GuiCheckBoxCtrl)"ppOptionsEnableSSAO2").setValue(
                bGlobal["$PostFXManager::PostFX::EnableSSAO2"].AsString());

            //SSAO - Set the values of the sliders, General Tab
            ((GuiSliderCtrl)"ppOptionsSSAO2Intensity").setValue(sGlobal["$SSAO2PostFx::intensity"]);
            ((GuiSliderCtrl)"ppOptionsSSAO2Radius").setValue(sGlobal["$SSAO2PostFx::radius"]);
            ((GuiSliderCtrl)"ppOptionsSSAO2Bias").setValue(sGlobal["$SSAO2PostFx::bias"]);
            ((GuiSliderCtrl)"ppOptionsSSAO2Scale").setValue(sGlobal["$SSAO2PostFx::scale"]);
            }

        public void settingsRefreshHDR()
            {
            //Apply the enabled flag 
            ((GuiCheckBoxCtrl)"ppOptionsEnableHDR").setValue(sGlobal["$PostFXManager::PostFX::EnableHDR"]);

            ((GuiCheckBoxCtrl)"ppOptionsHDRBloom").setValue(sGlobal["$HDRPostFX::enableBloom"]);

            ((GuiSliderCtrl)"ppOptionsHDRBloomBlurBrightPassThreshold").setValue(
                sGlobal["$HDRPostFX::brightPassThreshold"]);

            ((GuiSliderCtrl)"ppOptionsHDRBloomBlurMean").setValue(sGlobal["$HDRPostFX::gaussMean"]);
            ((GuiSliderCtrl)"ppOptionsHDRBloomBlurMultiplier").setValue(sGlobal["$HDRPostFX::gaussMultiplier"]);
            ((GuiSliderCtrl)"ppOptionsHDRBloomBlurStdDev").setValue(sGlobal["$HDRPostFX::gaussStdDev"]);
            ((GuiSliderCtrl)"ppOptionsHDRBrightnessAdaptRate").setValue(sGlobal["$HDRPostFX::adaptRate"]);

            ((GuiCheckBoxCtrl)"ppOptionsHDREffectsBlueShift").setValue(sGlobal["$HDRPostFX::enableBlueShift"]);

            ((GuiColorPickerCtrl)"ppOptionsHDREffectsBlueShiftColor").baseColor =
                new ColorF(sGlobal["$HDRPostFX::blueShiftColor"]);
            ((GuiColorPickerCtrl)"ppOptionsHDREffectsBlueShiftColor").pickColor =
                new ColorF(sGlobal["$HDRPostFX::blueShiftColor"]);

            ((GuiSliderCtrl)"ppOptionsHDRKeyValue").setValue(sGlobal["$HDRPostFX::keyValue"]);


            ((GuiSliderCtrl)"ppOptionsHDRMinLuminance").setValue(sGlobal["$HDRPostFX::minLuminace"]);

            ((GuiCheckBoxCtrl)"ppOptionsHDRToneMapping").setValue(sGlobal["$HDRPostFX::enableToneMapping"]);


            ((GuiSliderCtrl)"ppOptionsHDRToneMappingAmount").setValue(sGlobal["$HDRPostFX::enableToneMapping"]);
            ((GuiSliderCtrl)"ppOptionsHDRWhiteCutoff").setValue(sGlobal["$HDRPostFX::whiteCutoff"]);

            ((GuiTextEditCtrl)this.findObjectByInternalName("ColorCorrectionFileName", true)).text =
                Extendable.PostEffect.mColorCorrectionFileName; // sGlobal["$HDRPostFX::colorCorrectionRamp"];
            }

        public void settingsRefreshLightrays()
            {
            //Apply the enabled flag 
            ((GuiCheckBoxCtrl)"ppOptionsEnableLightRays").setValue(sGlobal["$PostFXManager::PostFX::EnableLightRays"]);
            ((GuiSliderCtrl)"ppOptionsLightRaysBrightScalar").setValue(sGlobal["$LightRayPostFX::brightScalar"]);
            }

        public void settingsRefreshDOF()
            {
            //Apply the enabled flag 
            ((GuiCheckBoxCtrl)"ppOptionsEnableDOF").setValue(sGlobal["$PostFXManager::PostFX::EnableDOF"]);

            ((GuiCheckBoxCtrl)"ppOptionsDOFEnableAutoFocus").setValue(sGlobal["$DOFPostFx::EnableAutoFocus"]);

            ((GuiSliderCtrl)"ppOptionsDOFFarBlurMinSlider").setValue(sGlobal["$DOFPostFx::BlurMin"]);
            ((GuiSliderCtrl)"ppOptionsDOFFarBlurMaxSlider").setValue(sGlobal["$DOFPostFx::BlurMax"]);

            ((GuiSliderCtrl)"ppOptionsDOFFocusRangeMinSlider").setValue(sGlobal["$DOFPostFx::FocusRangeMin"]);
            ((GuiSliderCtrl)"ppOptionsDOFFocusRangeMaxSlider").setValue(sGlobal["$DOFPostFx::FocusRangeMax"]);

            ((GuiSliderCtrl)"ppOptionsDOFBlurCurveNearSlider").setValue(sGlobal["$DOFPostFx::BlurCurveNear"]);
            ((GuiSliderCtrl)"ppOptionsDOFBlurCurveFarSlider").setValue(sGlobal["$DOFPostFx::BlurCurveFar"]);
            }

        public void settingsRefreshImageOpt()
        {
            ppOptionsEnableImageOpt ppOptionsEnableImageOpt = "ppOptionsEnableImageOpt";
            ppOptionsImageOptSharpen ppOptionsImageOptSharpen = "ppOptionsImageOptSharpen";
            ppOptionsImageOptDesaturation ppOptionsImageOptDesaturation = "ppOptionsImageOptDesaturation";
            ppOptionsImageOptToned ppOptionsImageOptToned = "ppOptionsImageOptToned";
            ppOptionsImageOptGamma ppOptionsImageOptGamma = "ppOptionsImageOptGamma";
            ppOptionsImageOptRed ppOptionsImageOptRed = "ppOptionsImageOptRed";
            ppOptionsImageOptGreen ppOptionsImageOptGreen = "ppOptionsImageOptGreen";
            ppOptionsImageOptBlue ppOptionsImageOptBlue = "ppOptionsImageOptBlue";

          //Apply the enabled flag 
           ppOptionsEnableImageOpt.setValue(sGlobal["$PostFXManager::PostFX::EnableImageOpt"]);
   
           ppOptionsImageOptSharpen.setValue(sGlobal["$ImageOptFX::Sharpen"]);
           ppOptionsImageOptDesaturation.setValue(sGlobal["$ImageOptFX::Desaturation"]);
           ppOptionsImageOptToned.setValue(sGlobal["$ImageOptFX::Toned"]);
           ppOptionsImageOptGamma.setValue(sGlobal["$ImageOptFX::Gamma"]);
           ppOptionsImageOptRed.setValue(sGlobal["$ImageOptFX::ScaleR"]);
           ppOptionsImageOptGreen.setValue(sGlobal["$ImageOptFX::ScaleG"]);
           ppOptionsImageOptBlue.setValue(sGlobal["$ImageOptFX::ScaleB"]);   
        }

        public void settingsRefreshSharpness()
        {
            ppOptionsEnableSharpness ppOptionsEnableSharpness = "ppOptionsEnableSharpness";
            ppOptionsSharpenRange ppOptionsSharpenRange = "ppOptionsSharpenRange";
            ppOptionsSharpenStrength ppOptionsSharpenStrength = "ppOptionsSharpenStrength";
            ppOptionsSharpenWidth ppOptionsSharpenWidth = "ppOptionsSharpenWidth";

          //Apply the enabled flag 
           ppOptionsEnableSharpness.setValue(sGlobal["$PostFXManager::PostFX::EnableSharpness"]);   
 

           ppOptionsSharpenRange.setValue(sGlobal["$SharpPostFx::sharpRange"]);
           ppOptionsSharpenStrength.setValue(sGlobal["$SharpPostFx::sharpPower"]);
           ppOptionsSharpenWidth.setValue(sGlobal["$SharpPostFx::sharpWidth"]);
   
        }

        public void settingsRefreshNightVision()
        {
            ppOptionsEnableNV ppOptionsEnableNV = "ppOptionsEnableNV";
            ppOptionsNVDistFreq ppOptionsNVDistFreq = "ppOptionsNVDistFreq";
            ppOptionsNVDistMul ppOptionsNVDistMul = "ppOptionsNVDistMul";
            ppOptionsNVDistRoll ppOptionsNVDistRoll = "ppOptionsNVDistRoll";
            ppOptionsNVBright ppOptionsNVBright = "ppOptionsNVBright";
            ppOptionsNVHighMul ppOptionsNVHighMul = "ppOptionsNVHighMul";
            ppOptionsNVLowMul ppOptionsNVLowMul = "ppOptionsNVLowMul";

           //Apply the enabled flag 
           ppOptionsEnableNV.setValue(sGlobal["$PostFXManager::PostFX::EnableNightVision"]);
   
           ppOptionsNVDistFreq.setValue(sGlobal["$NVPostFx::DistFreq"]);
           ppOptionsNVDistMul.setValue(sGlobal["$NVPostFx::DistMul"]);
           ppOptionsNVDistRoll.setValue(sGlobal["$NVPostFx::DistRoll"]);

           ppOptionsNVBright.setValue(sGlobal["$NVPostFx::brightThreshold"]);
           ppOptionsNVHighMul.setValue(sGlobal["$NVPostFx::highMultiplier"]);
           ppOptionsNVLowMul.setValue(sGlobal["$NVPostFx::lowMultiplier"]);
 
        }


        public void settingsRefreshAll()
            {
            sGlobal["$PostFXManager::PostFX::Enabled"] = sGlobal["$pref::enablePostEffects"];
            bGlobal["$PostFXManager::PostFX::EnableSSAO"] = ((PostEffect)"SSAOPostFx").isEnabledX();
            bGlobal["$PostFXManager::PostFX::EnableSSAO2"] = ((PostEffect)"SSAO2PostFx").isEnabledX();
            bGlobal["$PostFXManager::PostFX::EnableHDR"] = ((PostEffect)"HDRPostFX").isEnabledX();
            bGlobal["$PostFXManager::PostFX::EnableLightRays"] = ((PostEffect)"LightRayPostFX").isEnabledX();
            bGlobal["$PostFXManager::PostFX::EnableDOF"] = ((PostEffect)"DOFPostEffect").isEnabledX();
            sGlobal["$PostFXManager::PostFX::EnableSharpness"] = "";
            sGlobal["$PostFXManager::PostFX::EnableNightVision"] = "";
            bGlobal["$PostFXManager::PostFX::EnableImageOpt"] = ((PostEffect)"ImageOptFX").isEnabledX();

            //For all the postFX here, apply the active settings in the system
            //to the gui controls.

            settingsRefreshSSAO2();
            settingsRefreshSSAO();
            settingsRefreshHDR();
            settingsRefreshLightrays();
            settingsRefreshDOF();
            settingsRefreshImageOpt();
            settingsRefreshSharpness();
            settingsRefreshNightVision();

            ((GuiCheckBoxCtrl)"ppOptionsEnable").setValue(sGlobal["$PostFXManager::PostFX::Enabled"]);

            postVerbose("% - PostFX Manager - GUI values updated.");
            }

        public void settingsApplyFromPreset()
            {
            postVerbose("% - PostFX Manager - Applying from preset");

            //SSAO Settings
            sGlobal["$SSAOPostFx::blurDepthTol"] = sGlobal["$PostFXManager::Settings::SSAO::blurDepthTol"];
            sGlobal[" $SSAOPostFx::blurNormalTol"] = sGlobal["$PostFXManager::Settings::SSAO::blurNormalTol"];
            sGlobal["$SSAOPostFx::lDepthMax"] = sGlobal["$PostFXManager::Settings::SSAO::lDepthMax"];
            sGlobal["$SSAOPostFx::lDepthMin"] = sGlobal["$PostFXManager::Settings::SSAO::lDepthMin"];
            sGlobal["$SSAOPostFx::lDepthPow"] = sGlobal["$PostFXManager::Settings::SSAO::lDepthPow"];
            sGlobal["$SSAOPostFx::lNormalPow"] = sGlobal["$PostFXManager::Settings::SSAO::lNormalPow"];
            sGlobal["$SSAOPostFx::lNormalTol"] = sGlobal["$PostFXManager::Settings::SSAO::lNormalTol"];
            sGlobal["$SSAOPostFx::lRadius"] = sGlobal["$PostFXManager::Settings::SSAO::lRadius"];
            sGlobal["$SSAOPostFx::lStrength"] = sGlobal["$PostFXManager::Settings::SSAO::lStrength"];
            sGlobal["$SSAOPostFx::overallStrength"] = sGlobal["$PostFXManager::Settings::SSAO::overallStrength"];
            sGlobal["$SSAOPostFx::quality"] = sGlobal["$PostFXManager::Settings::SSAO::quality"];
            sGlobal["$SSAOPostFx::sDepthMax"] = sGlobal["$PostFXManager::Settings::SSAO::sDepthMax"];
            sGlobal["$SSAOPostFx::sDepthMin"] = sGlobal["$PostFXManager::Settings::SSAO::sDepthMin"];
            sGlobal["$SSAOPostFx::sDepthPow"] = sGlobal["$PostFXManager::Settings::SSAO::sDepthPow"];
            sGlobal["$SSAOPostFx::sNormalPow"] = sGlobal["$PostFXManager::Settings::SSAO::sNormalPow"];
            sGlobal["$SSAOPostFx::sNormalTol"] = sGlobal["$PostFXManager::Settings::SSAO::sNormalTol"];
            sGlobal["$SSAOPostFx::sRadius"] = sGlobal["$PostFXManager::Settings::SSAO::sRadius"];
            sGlobal["$SSAOPostFx::sStrength"] = sGlobal["$PostFXManager::Settings::SSAO::sStrength"];

            sGlobal["$SSAO2PostFx::intensity"] = sGlobal["$PostFXManager::Settings::SSAO2::intensity"];
            sGlobal["$SSAO2PostFx::radius"] = sGlobal["$PostFXManager::Settings::SSAO2::radius"];
            sGlobal["$SSAO2PostFx::scale"] = sGlobal["$PostFXManager::Settings::SSAO2::scale"];
            sGlobal["$SSAO2PostFx::bias"] = sGlobal["$PostFXManager::Settings::SSAO2::bias"];

            //HDR settings
            sGlobal["$HDRPostFX::adaptRate"] = sGlobal["$PostFXManager::Settings::HDR::adaptRate"];
            sGlobal["$HDRPostFX::blueShiftColor"] = sGlobal["$PostFXManager::Settings::HDR::blueShiftColor"];
            sGlobal["$HDRPostFX::brightPassThreshold"] = sGlobal["$PostFXManager::Settings::HDR::brightPassThreshold"];
            sGlobal["$HDRPostFX::enableBloom"] = sGlobal["$PostFXManager::Settings::HDR::enableBloom"];
            sGlobal["$HDRPostFX::enableBlueShift"] = sGlobal["$PostFXManager::Settings::HDR::enableBlueShift"];
            sGlobal["$HDRPostFX::enableToneMapping"] = sGlobal["$PostFXManager::Settings::HDR::enableToneMapping"];
            sGlobal["$HDRPostFX::gaussMean"] = sGlobal["$PostFXManager::Settings::HDR::gaussMean"];
            sGlobal["$HDRPostFX::gaussMultiplier"] = sGlobal["$PostFXManager::Settings::HDR::gaussMultiplier"];
            sGlobal["$HDRPostFX::gaussStdDev"] = sGlobal["$PostFXManager::Settings::HDR::gaussStdDev"];
            sGlobal["$HDRPostFX::keyValue"] = sGlobal["$PostFXManager::Settings::HDR::keyValue"];
            sGlobal["$HDRPostFX::minLuminace"] = sGlobal["$PostFXManager::Settings::HDR::minLuminace"];
            sGlobal["$HDRPostFX::whiteCutoff"] = sGlobal["$PostFXManager::Settings::HDR::whiteCutoff"];
            //sGlobal["$HDRPostFX::colorCorrectionRamp"] = sGlobal["$PostFXManager::Settings::ColorCorrectionRamp"];
            Extendable.PostEffect.mColorCorrectionFileName = sGlobal["$PostFXManager::Settings::ColorCorrectionRamp"];

            //Light rays settings
            sGlobal["$LightRayPostFX::brightScalar"] = sGlobal["$PostFXManager::Settings::LightRays::brightScalar"];

            //DOF settings   
            sGlobal["$DOFPostFx::EnableAutoFocus"] = sGlobal["$PostFXManager::Settings::DOF::EnableAutoFocus"];
            sGlobal["$DOFPostFx::BlurMin"] = sGlobal["$PostFXManager::Settings::DOF::BlurMin"];
            sGlobal["$DOFPostFx::BlurMax"] = sGlobal["$PostFXManager::Settings::DOF::BlurMax"];
            sGlobal["$DOFPostFx::FocusRangeMin"] = sGlobal["$PostFXManager::Settings::DOF::FocusRangeMin"];
            sGlobal["$DOFPostFx::FocusRangeMax"] = sGlobal["$PostFXManager::Settings::DOF::FocusRangeMax"];
            sGlobal["$DOFPostFx::BlurCurveNear"] = sGlobal["$PostFXManager::Settings::DOF::BlurCurveNear"];
            sGlobal["$DOFPostFx::BlurCurveFar"] = sGlobal["$PostFXManager::Settings::DOF::BlurCurveFar"];

            //Sharpen effect settings
            sGlobal["$SharpPostFx::sharpRange"] = sGlobal["$PostFXManager::Settings::Sharpen::sharpRange"];
            sGlobal["$SharpPostFx::sharpWidth"] = sGlobal["$PostFXManager::Settings::Sharpen::sharpWidth"];
            sGlobal["$SharpPostFx::sharpPower"] = sGlobal["$PostFXManager::Settings::Sharpen::sharpPower"];
   
            //Night vision 
            sGlobal["$NVPostFx::brightThreshold"] = sGlobal["$PostFXManager::Settings::NightVision::brightThreshold"];
            sGlobal["$NVPostFx::DistFreq"] = sGlobal["$PostFXManager::Settings::NightVision::DistFreq"];
            sGlobal["$NVPostFx::DistMul"] = sGlobal["$PostFXManager::Settings::NightVision::DistMul"];
            sGlobal["$NVPostFx::DistRoll"] = sGlobal["$PostFXManager::Settings::NightVision::DistRoll"];
            sGlobal["$NVPostFx::lowMultiplier"] = sGlobal["$PostFXManager::Settings::NightVision::lowMultiplier"];
            sGlobal["$NVPostFx::highMultiplier"] = sGlobal["$PostFXManager::Settings::NightVision::highMultiplier"];

            // Image Optimization
            sGlobal["$ImageOptFX::Desaturation"]           = sGlobal["$PostFXManager::Settings::ImageOpt::Desaturation"];
            sGlobal["$ImageOptFX::Toned"]                  = sGlobal["$PostFXManager::Settings::ImageOpt::Toned"];
            sGlobal["$ImageOptFX::LightColor"]             = sGlobal["$PostFXManager::Settings::ImageOpt::LightColor"];
            sGlobal["$ImageOptFX::DarkColor"]              = sGlobal["$PostFXManager::Settings::ImageOpt::DarkColor"];
            sGlobal["$ImageOptFX::Gamma"]                  = sGlobal["$PostFXManager::Settings::ImageOpt::Gamma"];
            sGlobal["$ImageOptFX::ScaleR"]                 = sGlobal["$PostFXManager::Settings::ImageOpt::ScaleR"];
            sGlobal["$ImageOptFX::ScaleG"]                 = sGlobal["$PostFXManager::Settings::ImageOpt::ScaleG"];
            sGlobal["$ImageOptFX::ScaleB"]                 = sGlobal["$PostFXManager::Settings::ImageOpt::ScaleB"];
            sGlobal["$ImageOptFX::Sharpen"]                = sGlobal["$PostFXManager::Settings::ImageOpt::Sharpen"];

            if (bGlobal["$PostFXManager::forceEnableFromPresets"])
                {
                sGlobal["$PostFXManager::PostFX::Enabled"] = sGlobal["$PostFXManager::Settings::EnablePostFX"];
                sGlobal["$PostFXManager::PostFX::EnableNightVision"] = sGlobal["$PostFXManager::Settings::EnableNightVision"];
                sGlobal["$PostFXManager::PostFX::EnableSharpen"] = sGlobal["$PostFXManager::Settings::EnableSharpen"];
                sGlobal["$PostFXManager::PostFX::EnableDOF"] = sGlobal["$PostFXManager::Settings::EnableDOF"];
                sGlobal["$PostFXManager::PostFX::EnableLightRays"] =
                    sGlobal["$PostFXManager::Settings::EnableLightRays"];
                sGlobal["$PostFXManager::PostFX::EnableHDR"] = sGlobal["$PostFXManager::Settings::EnableHDR"];
                sGlobal["$PostFXManager::PostFX::EnableSSAO"] = sGlobal["$PostFXManager::Settings::EnabledSSAO"];
                sGlobal["$PostFXManager::PostFX::EnableSSAO2"] = sGlobal["$PostFXManager::Settings::EnabledSSAO2"];
                sGlobal["$PostFXManager::PostFX::EnableImageOpt"] = sGlobal["$PostFXManager::Settings::EnableImageOpt"];
                settingsSetEnabled(true);
                }

            //make sure we apply the correct settings to the DOF
            ppOptionsUpdateDOFSettings();

            // Update the actual GUI controls if its awake ( otherwise it will when opened ).
            if (isAwake())
                settingsRefreshAll();
            }

        public void settingsApplyImageOpt()
        {    
           sGlobal["$PostFXManager::Settings::ImageOpt::Desaturation"] = sGlobal["$ImageOptFX::Desaturation"];
           sGlobal["$PostFXManager::Settings::ImageOpt::Toned"] = sGlobal["$ImageOptFX::Toned"];
           sGlobal["$PostFXManager::Settings::ImageOpt::LightColor"] = sGlobal["$ImageOptFX::LightColor"];
           sGlobal["$PostFXManager::Settings::ImageOpt::DarkColor"] = sGlobal["$ImageOptFX::DarkColor"];
           sGlobal["$PostFXManager::Settings::ImageOpt::Gamma"] = sGlobal["$ImageOptFX::Gamma"];
           sGlobal["$PostFXManager::Settings::ImageOpt::ScaleR"] = sGlobal["$ImageOptFX::ScaleR"] ;
           sGlobal["$PostFXManager::Settings::ImageOpt::ScaleG"] = sGlobal["$ImageOptFX::ScaleG"];
           sGlobal["$PostFXManager::Settings::ImageOpt::ScaleB"] = sGlobal["$ImageOptFX::ScaleB"];
           sGlobal["$PostFXManager::Settings::ImageOpt::Sharpen"] = sGlobal["$ImageOptFX::Sharpen"];
   
           postVerbose("% - PostFX Manager - Settings Saved - Image Optimization");   
        }

        public void settingsApplySSAO()
            {
            sGlobal["$PostFXManager::Settings::SSAO::blurDepthTol"] = sGlobal["$SSAOPostFx::blurDepthTol"];
            sGlobal["$PostFXManager::Settings::SSAO::blurNormalTol"] = sGlobal["$SSAOPostFx::blurNormalTol"];
            sGlobal["$PostFXManager::Settings::SSAO::lDepthMax"] = sGlobal["$SSAOPostFx::lDepthMax"];
            sGlobal["$PostFXManager::Settings::SSAO::lDepthMin"] = sGlobal["$SSAOPostFx::lDepthMin"];
            sGlobal["$PostFXManager::Settings::SSAO::lDepthPow"] = sGlobal["$SSAOPostFx::lDepthPow"];
            sGlobal["$PostFXManager::Settings::SSAO::lNormalPow"] = sGlobal["$SSAOPostFx::lNormalPow"];
            sGlobal["$PostFXManager::Settings::SSAO::lNormalTol"] = sGlobal["$SSAOPostFx::lNormalTol"];
            sGlobal["$PostFXManager::Settings::SSAO::lRadius"] = sGlobal["$SSAOPostFx::lRadius"];
            sGlobal["$PostFXManager::Settings::SSAO::lStrength"] = sGlobal["$SSAOPostFx::lStrength"];
            sGlobal["$PostFXManager::Settings::SSAO::overallStrength"] = sGlobal["$SSAOPostFx::overallStrength"];
            sGlobal["$PostFXManager::Settings::SSAO::quality"] = sGlobal["$SSAOPostFx::quality"];
            sGlobal["$PostFXManager::Settings::SSAO::sDepthMax"] = sGlobal["$SSAOPostFx::sDepthMax"];
            sGlobal["$PostFXManager::Settings::SSAO::sDepthMin"] = sGlobal["$SSAOPostFx::sDepthMin"];
            sGlobal["$PostFXManager::Settings::SSAO::sDepthPow"] = sGlobal["$SSAOPostFx::sDepthPow"];
            sGlobal["$PostFXManager::Settings::SSAO::sNormalPow"] = sGlobal["$SSAOPostFx::sNormalPow"];
            sGlobal["$PostFXManager::Settings::SSAO::sNormalTol"] = sGlobal["$SSAOPostFx::sNormalTol"];
            sGlobal["$PostFXManager::Settings::SSAO::sRadius"] = sGlobal["$SSAOPostFx::sRadius"];
            sGlobal["$PostFXManager::Settings::SSAO::sStrength"] = sGlobal["$SSAOPostFx::sStrength"];

            postVerbose("% - PostFX Manager - Settings Saved - SSAO");
            }

        public void settingsApplySSAO2()
            {
            sGlobal["$PostFXManager::Settings::SSAO2::intensity"] = sGlobal["$SSAO2PostFx::intensity"];
            sGlobal["$PostFXManager::Settings::SSAO2::radius"] = sGlobal["$SSAO2PostFx::radius"];
            sGlobal["$PostFXManager::Settings::SSAO2::scale"] = sGlobal["$SSAO2PostFx::scale"];
            sGlobal["$PostFXManager::Settings::SSAO2::bias"] = sGlobal["$SSAO2PostFx::bias"];

            postVerbose("% - PostFX Manager - Settings Saved - SSAO2");
            }

        public void settingsApplyHDR()
            {
            sGlobal["$PostFXManager::Settings::HDR::adaptRate"] = sGlobal["$HDRPostFX::adaptRate"];
            sGlobal["$PostFXManager::Settings::HDR::blueShiftColor"] = sGlobal["$HDRPostFX::blueShiftColor"];
            sGlobal["$PostFXManager::Settings::HDR::brightPassThreshold"] = sGlobal["$HDRPostFX::brightPassThreshold"];
            sGlobal["$PostFXManager::Settings::HDR::enableBloom"] = sGlobal["$HDRPostFX::enableBloom"];
            sGlobal["$PostFXManager::Settings::HDR::enableBlueShift"] = sGlobal["$HDRPostFX::enableBlueShift"];
            sGlobal["$PostFXManager::Settings::HDR::enableToneMapping"] = sGlobal["$HDRPostFX::enableToneMapping"];
            sGlobal["$PostFXManager::Settings::HDR::gaussMean"] = sGlobal["$HDRPostFX::gaussMean"];
            sGlobal["$PostFXManager::Settings::HDR::gaussMultiplier"] = sGlobal["$HDRPostFX::gaussMultiplier"];
            sGlobal["$PostFXManager::Settings::HDR::gaussStdDev"] = sGlobal["$HDRPostFX::gaussStdDev"];
            sGlobal["$PostFXManager::Settings::HDR::keyValue"] = sGlobal["$HDRPostFX::keyValue"];
            sGlobal["$PostFXManager::Settings::HDR::minLuminace"] = sGlobal["$HDRPostFX::minLuminace"];
            sGlobal["$PostFXManager::Settings::HDR::whiteCutoff"] = sGlobal["$HDRPostFX::whiteCutoff"];
            //sGlobal["$PostFXManager::Settings::ColorCorrectionRamp"] = sGlobal["$HDRPostFX::colorCorrectionRamp"];
            sGlobal["$PostFXManager::Settings::ColorCorrectionRamp"] = Extendable.PostEffect.mColorCorrectionFileName;

            postVerbose("% - PostFX Manager - Settings Saved - HDR");
            }

        public void settingsApplyLightRays()
            {
            sGlobal["$PostFXManager::Settings::LightRays::brightScalar"] = sGlobal["$LightRayPostFX::brightScalar"];

            postVerbose("% - PostFX Manager - Settings Saved - Light Rays");
            }

        public void settingsApplyDOF()
            {
            sGlobal["$PostFXManager::Settings::DOF::EnableAutoFocus"] = sGlobal["$DOFPostFx::EnableAutoFocus"];
            sGlobal["$PostFXManager::Settings::DOF::BlurMin"] = sGlobal["$DOFPostFx::BlurMin"];
            sGlobal["$PostFXManager::Settings::DOF::BlurMax"] = sGlobal["$DOFPostFx::BlurMax"];
            sGlobal["$PostFXManager::Settings::DOF::FocusRangeMin"] = sGlobal["$DOFPostFx::FocusRangeMin"];
            sGlobal["$PostFXManager::Settings::DOF::FocusRangeMax"] = sGlobal["$DOFPostFx::FocusRangeMax"];
            sGlobal["$PostFXManager::Settings::DOF::BlurCurveNear"] = sGlobal["$DOFPostFx::BlurCurveNear"];
            sGlobal["$PostFXManager::Settings::DOF::BlurCurveFar"] = sGlobal["$DOFPostFx::BlurCurveFar"];

            postVerbose("% - PostFX Manager - Settings Saved - DOF");
            }

        public void settingsApplySharpen()
        {   
           sGlobal["$PostFXManager::Settings::Sharpen::sharpRange"] = sGlobal["$SharpPostFx::sharpRange"];
           sGlobal["$PostFXManager::Settings::Sharpen::sharpWidth"] = sGlobal["$SharpPostFx::sharpWidth"];
           sGlobal["$PostFXManager::Settings::Sharpen::sharpPower"] = sGlobal["$SharpPostFx::sharpPower"];

           postVerbose("% - PostFX Manager - Settings Saved - Sharpen");   
        }

        public void settingsApplyNightVision()
        {   
           sGlobal["$PostFXManager::Settings::NightVision::brightThreshold"] = sGlobal["$NVPostFx::brightThreshold"];
           sGlobal["$PostFXManager::Settings::NightVision::DistFreq"] = sGlobal["$NVPostFx::DistFreq"];
           sGlobal["$PostFXManager::Settings::NightVision::DistMul"] = sGlobal["$NVPostFx::DistMul"];
           sGlobal["$PostFXManager::Settings::NightVision::DistRoll"] = sGlobal["$NVPostFx::DistRoll"];
           sGlobal["$PostFXManager::Settings::NightVision::highMultiplier"] = sGlobal["$NVPostFx::highMultiplier"];
           sGlobal["$PostFXManager::Settings::NightVision::lowMultiplier"] = sGlobal["$NVPostFx::lowMultiplier"];
   
           postVerbose("% - PostFX Manager - Settings Saved - Night Vision");   
        }

        [ConsoleInteraction(true)]
        public void settingsApplyAll()
            {
            // Apply settings which control if effects are on/off altogether.
            sGlobal["$PostFXManager::Settings::EnablePostFX"] = sGlobal["$PostFXManager::PostFX::Enabled"];
            sGlobal["$PostFXManager::Settings::EnableNightVision"] = sGlobal["$PostFXManager::PostFX::EnableNightVision"];
            sGlobal["$PostFXManager::Settings::EnableSharpen"] = sGlobal["$PostFXManager::PostFX::EnableSharpen"];
            sGlobal["$PostFXManager::Settings::EnableDOF"] = sGlobal["$PostFXManager::PostFX::EnableDOF"];
            sGlobal["$PostFXManager::Settings::EnableLightRays"] = sGlobal["$PostFXManager::PostFX::EnableLightRays"];
            sGlobal["$PostFXManager::Settings::EnableHDR"] = sGlobal["$PostFXManager::PostFX::EnableHDR"];
            sGlobal["$PostFXManager::Settings::EnabledSSAO"] = sGlobal["$PostFXManager::PostFX::EnableSSAO"];
            sGlobal["$PostFXManager::Settings::EnabledSSAO2"] = sGlobal["$PostFXManager::PostFX::EnableSSAO2"];
            sGlobal["$PostFXManager::Settings::EnableImageOpt"] = sGlobal["$PostFXManager::PostFX::EnableImageOpt"];

            // Apply settings should save the values in the system to the 
            // the preset structure ($PostFXManager::Settings::*)

            // SSAO Settings
            settingsApplySSAO();
            // SSAO2 Settings
            settingsApplySSAO2();
            // HDR settings
            settingsApplyHDR();
            // Light rays settings
            settingsApplyLightRays();
            // DOF
            settingsApplyDOF();
            // Sharpness
            settingsApplySharpen();
            // NV
            settingsApplyNightVision();
            // Image Optimization
            settingsApplyImageOpt();

            postVerbose("% - PostFX Manager - All Settings applied to $PostFXManager::Settings");
            }

        public void settingsApplyDefaultPreset()
            {
            loadPresetHandler(sGlobal["$PostFXManager::defaultPreset"]);
            }

        [ConsoleInteraction(true)]
        public void loadPresetFile()
            {
            //Load a preset file from the disk, and apply the settings to the
            //controls. If bApplySettings is true - the actual values in the engine
            //will be changed to reflect the settings from the file.
            //Show the dialog and set the flag
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename(sGlobal["$PostFXManager::fileFilter"], "PostFXManager.loadPresetHandler", "");
            }

        [ConsoleInteraction]
        public void loadPresetHandler(string filename)
            {
            if (!Main.isScriptFile(filename))
                return;
            filename = Util._expandFilename(filename);
            postVerbose("% - PostFX Manager - Executing " + filename);
            Util.exec(filename, false, false);
            settingsApplyFromPreset();
            }

        [ConsoleInteraction(true)]
        public void savePresetFile()
            {
            string defaultFile =
                Util.filePath(sGlobal["$Client::MissionFile"] + "/" + Util.fileBase(sGlobal["$Client::MissionFile"]));
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.SaveFileDialog.getSaveFilename(sGlobal["$PostFXManager::fileFilter"], "PostFXManager.savePresetHandler",
                defaultFile);
            }

        [ConsoleInteraction]
        public void savePresetHandler(string filename)
            {
            filename = Util.makeRelativePath(filename, Util.getMainDotCsDir());
            if (!filename.Contains("."))
                filename += sGlobal["$PostFXManager::fileExtension"];

            //Apply the current settings to the preset
            settingsApplyAll();

            Util.export("$PostFXManager::Settings::*", filename, false);
            postVerbose("% - PostFX Manager - Save complete. Preset saved at : " + filename);
            }

        [ConsoleInteraction(true)]
        public static void ppOptionsUpdateDOFSettings()
            {
            DOFPostEffect mDOFPostEffect = "DOFPostEffect";
            mDOFPostEffect.setFocusParams(omni.fGlobal["$DOFPostFx::BlurMin"], omni.fGlobal["$DOFPostFx::BlurMax"],
                omni.fGlobal["$DOFPostFx::FocusRangeMin"], omni.fGlobal["$DOFPostFx::FocusRangeMax"],
                -omni.fGlobal["$DOFPostFx::BlurCurveNear"], omni.fGlobal["$DOFPostFx::BlurCurveFar"]);
            mDOFPostEffect.setAutoFocus(omni.bGlobal["$DOFPostFx::EnableAutoFocus"]);
            mDOFPostEffect.setFocalDist("0");
            if (omni.bGlobal["$PostFXManager::PostFX::EnableDOF"])
                mDOFPostEffect.enable();
            else
                mDOFPostEffect.disable();
            }

        [ConsoleInteraction(true)]
        public static void ppColorCorrection_selectFile()
            {
            string filter =
                "Image Files (*.png, *.jpg, *.dds, *.bmp, *.gif, *.jng. *.tga)|*.png;*.jpg;*.dds;*.bmp;*.gif;*.jng;*.tga|All Files (*.*)|*.*";
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.OpenFileDialog.getLoadFilename(filter, "ppColorCorrection_selectFileHandler", "");
            }

        [ConsoleInteraction(true)]
        public static void ppColorCorrection_selectFileHandler(string filename)
            {
            if ((filename == "") || !omni.Util.isFile(filename))
                filename = "core/scripts/client/postFx/null_color_ramp.png";
            else
                filename = omni.Util.makeRelativePath(filename, omni.Util.getMainDotCsDir());

            Extendable.PostEffect.mColorCorrectionFileName = filename;

            //omni.sGlobal["$HDRPostFX::colorCorrectionRamp"] = filename;

            ((GuiTextEditCtrl)
                ((postFXManager)"PostFXManager").findObjectByInternalName("ColorCorrectionFileName", true)).text =
                filename;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(postFXManager ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(postFXManager ts, string simobjectid)
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
        public static implicit operator string(postFXManager ts)
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
        public static implicit operator postFXManager(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (postFXManager)Omni.self.getSimObject(simobjectid, typeof(postFXManager));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(postFXManager ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator postFXManager(int simobjectid)
            {
            return (postFXManager)Omni.self.getSimObject((uint)simobjectid, typeof(postFXManager));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(postFXManager ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator postFXManager(uint simobjectid)
            {
            return (postFXManager)Omni.self.getSimObject(simobjectid, typeof(postFXManager));
            }

        #endregion
        }

        public class postFXHelper
        {
            [ConsoleInteraction]
            public static void DumpShaderStatus()
            {
                foreach (ModelBase mb in Omni.self.SimDictionary)
                    {
                    if (typeof (PostEffect).IsSameOrSubclass(mb.GetType()))
                        {
                        Omni.self.Print("ID: " + mb.ID + " Name: " + mb.getName() + " Enabled: " + ((PostEffect)mb).isEnabled);
                        }
                    }
            }

        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnable>))]
    public class ppOptionsEnable : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            //Disable / Enable all PostFX
            ((postFXManager)"PostFXManager").settingsSetEnabled(getValue().AsBool());
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnable ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnable ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnable ts)
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
        public static implicit operator ppOptionsEnable(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnable)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnable));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnable ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnable(int simobjectid)
            {
            return (ppOptionsEnable)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnable));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnable ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnable(uint simobjectid)
            {
            return (ppOptionsEnable)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnable));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableSSAO>))]
    public class ppOptionsEnableSSAO : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            ((postFXManager)"PostFXManager").settingsEffectSetEnabled("SSAO",
                ((postFXManager)"PostFXManager").getEnableResultFromControl(this));
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableSSAO ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableSSAO ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableSSAO ts)
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
        public static implicit operator ppOptionsEnableSSAO(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableSSAO)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableSSAO));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableSSAO ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableSSAO(int simobjectid)
            {
            return (ppOptionsEnableSSAO)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableSSAO));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableSSAO ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableSSAO(uint simobjectid)
            {
            return (ppOptionsEnableSSAO)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableSSAO));
            }

        #endregion
        }

    //Original
    //function ppOptionsEnableSSAO2::onAction(%this)
    //{
    //   %toEnable = PostFXManager.getEnableResultFromControl(%this);
    //   PostFXManager.settingsEffectSetEnabled("SSAO2", %toEnable);
    //}

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableSSAO2>))]
    public class ppOptionsEnableSSAO2 : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            ((postFXManager)"PostFXManager").settingsEffectSetEnabled("SSAO2",
                ((postFXManager)"PostFXManager").getEnableResultFromControl(this));
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableSSAO2 ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableSSAO2 ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableSSAO2 ts)
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
        public static implicit operator ppOptionsEnableSSAO2(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableSSAO2)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableSSAO2));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableSSAO2 ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableSSAO2(int simobjectid)
            {
            return (ppOptionsEnableSSAO2)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableSSAO2));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableSSAO2 ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableSSAO2(uint simobjectid)
            {
            return (ppOptionsEnableSSAO2)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableSSAO2));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableHDR>))]
    public class ppOptionsEnableHDR : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            ((postFXManager)"PostFXManager").settingsEffectSetEnabled("HDR",
                ((postFXManager)"PostFXManager").getEnableResultFromControl(this));
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableHDR ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableHDR ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableHDR ts)
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
        public static implicit operator ppOptionsEnableHDR(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableHDR)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableHDR));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableHDR ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableHDR(int simobjectid)
            {
            return (ppOptionsEnableHDR)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableHDR));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableHDR ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableHDR(uint simobjectid)
            {
            return (ppOptionsEnableHDR)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableHDR));
            }

        #endregion
        }

    //Other controls, Quality dropdown
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableLightRays>))]
    public class ppOptionsEnableLightRays : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            ((postFXManager)"PostFXManager").settingsEffectSetEnabled("LightRays",
                ((postFXManager)"PostFXManager").getEnableResultFromControl(this));
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableLightRays ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableLightRays ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableLightRays ts)
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
        public static implicit operator ppOptionsEnableLightRays(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableLightRays)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableLightRays));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableLightRays ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableLightRays(int simobjectid)
            {
            return
                (ppOptionsEnableLightRays)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableLightRays));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableLightRays ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableLightRays(uint simobjectid)
            {
            return (ppOptionsEnableLightRays)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableLightRays));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableDOF>))]
    public class ppOptionsEnableDOF : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            ((postFXManager)"PostFXManager").settingsEffectSetEnabled("DOF",
                ((postFXManager)"PostFXManager").getEnableResultFromControl(this));
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableDOF ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableDOF ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableDOF ts)
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
        public static implicit operator ppOptionsEnableDOF(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableDOF)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableDOF));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableDOF ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableDOF(int simobjectid)
            {
            return (ppOptionsEnableDOF)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableDOF));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableDOF ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableDOF(uint simobjectid)
            {
            return (ppOptionsEnableDOF)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableDOF));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOQuality>))]
    public class ppOptionsSSAOQuality : GuiPopUpMenuCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onSelect(string id, string text)
            {
            if (id.AsInt() > -1 && id.AsInt() < 3)
                sGlobal["$SSAOPostFx::quality"] = id;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOQuality ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOQuality ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOQuality ts)
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
        public static implicit operator ppOptionsSSAOQuality(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOQuality)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOQuality));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOQuality ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOQuality(int simobjectid)
            {
            return (ppOptionsSSAOQuality)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOQuality));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOQuality ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOQuality(uint simobjectid)
            {
            return (ppOptionsSSAOQuality)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOQuality));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOOverallStrength>))]
    public class ppOptionsSSAOOverallStrength : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::overallStrength"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOOverallStrength ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOOverallStrength ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOOverallStrength ts)
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
        public static implicit operator ppOptionsSSAOOverallStrength(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsSSAOOverallStrength)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOOverallStrength));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOOverallStrength ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOOverallStrength(int simobjectid)
            {
            return
                (ppOptionsSSAOOverallStrength)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOOverallStrength));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOOverallStrength ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOOverallStrength(uint simobjectid)
            {
            return
                (ppOptionsSSAOOverallStrength)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOOverallStrength));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOBlurDepth>))]
    public class ppOptionsSSAOBlurDepth : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::blurDepthTol"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOBlurDepth ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOBlurDepth ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOBlurDepth ts)
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
        public static implicit operator ppOptionsSSAOBlurDepth(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOBlurDepth)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOBlurDepth));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOBlurDepth ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOBlurDepth(int simobjectid)
            {
            return (ppOptionsSSAOBlurDepth)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOBlurDepth));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOBlurDepth ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOBlurDepth(uint simobjectid)
            {
            return (ppOptionsSSAOBlurDepth)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOBlurDepth));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOBlurNormal>))]
    public class ppOptionsSSAOBlurNormal : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::blurNormalTol"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOBlurNormal ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOBlurNormal ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOBlurNormal ts)
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
        public static implicit operator ppOptionsSSAOBlurNormal(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOBlurNormal)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOBlurNormal));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOBlurNormal ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOBlurNormal(int simobjectid)
            {
            return
                (ppOptionsSSAOBlurNormal)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOBlurNormal));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOBlurNormal ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOBlurNormal(uint simobjectid)
            {
            return (ppOptionsSSAOBlurNormal)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOBlurNormal));
            }

        #endregion
        }

    //Near Tab
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAONearRadius>))]
    public class ppOptionsSSAONearRadius : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::sRadius"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAONearRadius ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAONearRadius ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAONearRadius ts)
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
        public static implicit operator ppOptionsSSAONearRadius(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAONearRadius)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearRadius));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAONearRadius ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearRadius(int simobjectid)
            {
            return
                (ppOptionsSSAONearRadius)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAONearRadius));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAONearRadius ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearRadius(uint simobjectid)
            {
            return (ppOptionsSSAONearRadius)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearRadius));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAONearStrength>))]
    public class ppOptionsSSAONearStrength : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::sStrength"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAONearStrength ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAONearStrength ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAONearStrength ts)
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
        public static implicit operator ppOptionsSSAONearStrength(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAONearStrength)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearStrength));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAONearStrength ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearStrength(int simobjectid)
            {
            return
                (ppOptionsSSAONearStrength)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAONearStrength));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAONearStrength ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearStrength(uint simobjectid)
            {
            return (ppOptionsSSAONearStrength)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearStrength));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAONearDepthMin>))]
    public class ppOptionsSSAONearDepthMin : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::sDepthMin"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAONearDepthMin ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAONearDepthMin ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAONearDepthMin ts)
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
        public static implicit operator ppOptionsSSAONearDepthMin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAONearDepthMin)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearDepthMin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAONearDepthMin ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearDepthMin(int simobjectid)
            {
            return
                (ppOptionsSSAONearDepthMin)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAONearDepthMin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAONearDepthMin ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearDepthMin(uint simobjectid)
            {
            return (ppOptionsSSAONearDepthMin)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearDepthMin));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAONearDepthMax>))]
    public class ppOptionsSSAONearDepthMax : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::sDepthMax"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAONearDepthMax ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAONearDepthMax ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAONearDepthMax ts)
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
        public static implicit operator ppOptionsSSAONearDepthMax(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAONearDepthMax)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearDepthMax));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAONearDepthMax ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearDepthMax(int simobjectid)
            {
            return
                (ppOptionsSSAONearDepthMax)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAONearDepthMax));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAONearDepthMax ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearDepthMax(uint simobjectid)
            {
            return (ppOptionsSSAONearDepthMax)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearDepthMax));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAONearToleranceNormal>))]
    public class ppOptionsSSAONearToleranceNormal : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::sNormalTol"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAONearToleranceNormal ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAONearToleranceNormal ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAONearToleranceNormal ts)
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
        public static implicit operator ppOptionsSSAONearToleranceNormal(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsSSAONearToleranceNormal)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearToleranceNormal));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAONearToleranceNormal ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearToleranceNormal(int simobjectid)
            {
            return
                (ppOptionsSSAONearToleranceNormal)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAONearToleranceNormal));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAONearToleranceNormal ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearToleranceNormal(uint simobjectid)
            {
            return
                (ppOptionsSSAONearToleranceNormal)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearToleranceNormal));
            }

        #endregion
        }


    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAONearTolerancePower>))]
    public class ppOptionsSSAONearTolerancePower : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::sNormalPow"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAONearTolerancePower ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAONearTolerancePower ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAONearTolerancePower ts)
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
        public static implicit operator ppOptionsSSAONearTolerancePower(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsSSAONearTolerancePower)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearTolerancePower));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAONearTolerancePower ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearTolerancePower(int simobjectid)
            {
            return
                (ppOptionsSSAONearTolerancePower)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAONearTolerancePower));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAONearTolerancePower ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAONearTolerancePower(uint simobjectid)
            {
            return
                (ppOptionsSSAONearTolerancePower)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAONearTolerancePower));
            }

        #endregion
        }

    //Far Tab
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarRadius>))]
    public class ppOptionsSSAOFarRadius : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::lRadius"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOFarRadius ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOFarRadius ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOFarRadius ts)
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
        public static implicit operator ppOptionsSSAOFarRadius(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOFarRadius)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarRadius));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOFarRadius ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarRadius(int simobjectid)
            {
            return (ppOptionsSSAOFarRadius)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOFarRadius));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOFarRadius ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarRadius(uint simobjectid)
            {
            return (ppOptionsSSAOFarRadius)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarRadius));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarStrength>))]
    public class ppOptionsSSAOFarStrength : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::lStrength"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOFarStrength ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOFarStrength ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOFarStrength ts)
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
        public static implicit operator ppOptionsSSAOFarStrength(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOFarStrength)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarStrength));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOFarStrength ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarStrength(int simobjectid)
            {
            return
                (ppOptionsSSAOFarStrength)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOFarStrength));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOFarStrength ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarStrength(uint simobjectid)
            {
            return (ppOptionsSSAOFarStrength)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarStrength));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarDepthMin>))]
    public class ppOptionsSSAOFarDepthMin : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::lDepthMin"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOFarDepthMin ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOFarDepthMin ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOFarDepthMin ts)
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
        public static implicit operator ppOptionsSSAOFarDepthMin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOFarDepthMin)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarDepthMin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOFarDepthMin ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarDepthMin(int simobjectid)
            {
            return
                (ppOptionsSSAOFarDepthMin)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOFarDepthMin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOFarDepthMin ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarDepthMin(uint simobjectid)
            {
            return (ppOptionsSSAOFarDepthMin)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarDepthMin));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarDepthMax>))]
    public class ppOptionsSSAOFarDepthMax : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::lDepthMax"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOFarDepthMax ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOFarDepthMax ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOFarDepthMax ts)
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
        public static implicit operator ppOptionsSSAOFarDepthMax(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSSAOFarDepthMax)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarDepthMax));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOFarDepthMax ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarDepthMax(int simobjectid)
            {
            return
                (ppOptionsSSAOFarDepthMax)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOFarDepthMax));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOFarDepthMax ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarDepthMax(uint simobjectid)
            {
            return (ppOptionsSSAOFarDepthMax)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarDepthMax));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarToleranceNormal>))]
    public class ppOptionsSSAOFarToleranceNormal : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::lNormalTol"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOFarToleranceNormal ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOFarToleranceNormal ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOFarToleranceNormal ts)
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
        public static implicit operator ppOptionsSSAOFarToleranceNormal(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsSSAOFarToleranceNormal)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarToleranceNormal));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOFarToleranceNormal ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarToleranceNormal(int simobjectid)
            {
            return
                (ppOptionsSSAOFarToleranceNormal)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOFarToleranceNormal));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOFarToleranceNormal ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarToleranceNormal(uint simobjectid)
            {
            return
                (ppOptionsSSAOFarToleranceNormal)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarToleranceNormal));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarTolerancePower>))]
    public class ppOptionsSSAOFarTolerancePower : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$SSAOPostFx::lNormalPow"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSSAOFarTolerancePower ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSSAOFarTolerancePower ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSSAOFarTolerancePower ts)
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
        public static implicit operator ppOptionsSSAOFarTolerancePower(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsSSAOFarTolerancePower)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarTolerancePower));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSSAOFarTolerancePower ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarTolerancePower(int simobjectid)
            {
            return
                (ppOptionsSSAOFarTolerancePower)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSSAOFarTolerancePower));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSSAOFarTolerancePower ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSSAOFarTolerancePower(uint simobjectid)
            {
            return
                (ppOptionsSSAOFarTolerancePower)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsSSAOFarTolerancePower));
            }

        #endregion
        }

    ////SSAO2
    //[TypeConverter(typeof(TypeConverterGeneric<ppOptionsSSAOFarTolerancePower>))]
    //class ppOptionsSSAOFarTolerancePower : GuiSliderCtrl
    //    {
    //    internal override bool OnFunctionNotFoundCallTorqueScript()
    //        {
    //        return false;
    //        }
    //    internal override void onMouseDragged()
    //        {
    //        dGlobal["$SSAOPostFx::lNormalPow"] = value;
    //        tooltip = "Value : " + value;
    //        }
    //    }


    //HDR Slider Controls
    //Brighness tab


    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRToneMappingAmount>))]
    public class ppOptionsHDRToneMappingAmount : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::enableToneMapping"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRToneMappingAmount ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRToneMappingAmount ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRToneMappingAmount ts)
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
        public static implicit operator ppOptionsHDRToneMappingAmount(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDRToneMappingAmount)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRToneMappingAmount));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRToneMappingAmount ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRToneMappingAmount(int simobjectid)
            {
            return
                (ppOptionsHDRToneMappingAmount)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRToneMappingAmount));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRToneMappingAmount ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRToneMappingAmount(uint simobjectid)
            {
            return
                (ppOptionsHDRToneMappingAmount)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRToneMappingAmount));
            }

        #endregion
        }


    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRKeyValue>))]
    public class ppOptionsHDRKeyValue : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::keyValue"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRKeyValue ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRKeyValue ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRKeyValue ts)
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
        public static implicit operator ppOptionsHDRKeyValue(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsHDRKeyValue)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRKeyValue));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRKeyValue ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRKeyValue(int simobjectid)
            {
            return (ppOptionsHDRKeyValue)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRKeyValue));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRKeyValue ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRKeyValue(uint simobjectid)
            {
            return (ppOptionsHDRKeyValue)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRKeyValue));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRMinLuminance>))]
    public class ppOptionsHDRMinLuminance : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::minLuminace"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRMinLuminance ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRMinLuminance ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRMinLuminance ts)
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
        public static implicit operator ppOptionsHDRMinLuminance(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsHDRMinLuminance)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRMinLuminance));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRMinLuminance ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRMinLuminance(int simobjectid)
            {
            return
                (ppOptionsHDRMinLuminance)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRMinLuminance));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRMinLuminance ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRMinLuminance(uint simobjectid)
            {
            return (ppOptionsHDRMinLuminance)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRMinLuminance));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRWhiteCutoff>))]
    public class ppOptionsHDRWhiteCutoff : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::whiteCutoff"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRWhiteCutoff ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRWhiteCutoff ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRWhiteCutoff ts)
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
        public static implicit operator ppOptionsHDRWhiteCutoff(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsHDRWhiteCutoff)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRWhiteCutoff));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRWhiteCutoff ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRWhiteCutoff(int simobjectid)
            {
            return
                (ppOptionsHDRWhiteCutoff)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRWhiteCutoff));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRWhiteCutoff ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRWhiteCutoff(uint simobjectid)
            {
            return (ppOptionsHDRWhiteCutoff)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRWhiteCutoff));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRBrightnessAdaptRate>))]
    public class ppOptionsHDRBrightnessAdaptRate : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::adaptRate"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRBrightnessAdaptRate ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRBrightnessAdaptRate ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRBrightnessAdaptRate ts)
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
        public static implicit operator ppOptionsHDRBrightnessAdaptRate(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDRBrightnessAdaptRate)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBrightnessAdaptRate));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRBrightnessAdaptRate ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBrightnessAdaptRate(int simobjectid)
            {
            return
                (ppOptionsHDRBrightnessAdaptRate)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRBrightnessAdaptRate));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRBrightnessAdaptRate ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBrightnessAdaptRate(uint simobjectid)
            {
            return
                (ppOptionsHDRBrightnessAdaptRate)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBrightnessAdaptRate));
            }

        #endregion
        }

    //Blur tab
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRBloomBlurBrightPassThreshold>))]
    public class ppOptionsHDRBloomBlurBrightPassThreshold : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::brightPassThreshold"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRBloomBlurBrightPassThreshold ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRBloomBlurBrightPassThreshold ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRBloomBlurBrightPassThreshold ts)
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
        public static implicit operator ppOptionsHDRBloomBlurBrightPassThreshold(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDRBloomBlurBrightPassThreshold)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurBrightPassThreshold));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRBloomBlurBrightPassThreshold ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurBrightPassThreshold(int simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurBrightPassThreshold)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRBloomBlurBrightPassThreshold));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRBloomBlurBrightPassThreshold ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurBrightPassThreshold(uint simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurBrightPassThreshold)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurBrightPassThreshold));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRBloomBlurMultiplier>))]
    public class ppOptionsHDRBloomBlurMultiplier : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::gaussMultiplier"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRBloomBlurMultiplier ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRBloomBlurMultiplier ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRBloomBlurMultiplier ts)
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
        public static implicit operator ppOptionsHDRBloomBlurMultiplier(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDRBloomBlurMultiplier)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurMultiplier));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRBloomBlurMultiplier ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurMultiplier(int simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurMultiplier)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRBloomBlurMultiplier));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRBloomBlurMultiplier ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurMultiplier(uint simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurMultiplier)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurMultiplier));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRBloomBlurMean>))]
    public class ppOptionsHDRBloomBlurMean : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::gaussMean"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRBloomBlurMean ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRBloomBlurMean ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRBloomBlurMean ts)
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
        public static implicit operator ppOptionsHDRBloomBlurMean(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsHDRBloomBlurMean)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurMean));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRBloomBlurMean ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurMean(int simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurMean)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRBloomBlurMean));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRBloomBlurMean ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurMean(uint simobjectid)
            {
            return (ppOptionsHDRBloomBlurMean)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurMean));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRBloomBlurStdDev>))]
    public class ppOptionsHDRBloomBlurStdDev : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$HDRPostFX::gaussStdDev"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRBloomBlurStdDev ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRBloomBlurStdDev ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRBloomBlurStdDev ts)
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
        public static implicit operator ppOptionsHDRBloomBlurStdDev(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDRBloomBlurStdDev)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurStdDev));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRBloomBlurStdDev ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurStdDev(int simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurStdDev)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRBloomBlurStdDev));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRBloomBlurStdDev ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloomBlurStdDev(uint simobjectid)
            {
            return
                (ppOptionsHDRBloomBlurStdDev)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloomBlurStdDev));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRBloom>))]
    public class ppOptionsHDRBloom : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            sGlobal["$HDRPostFX::enableBloom"] = getValue();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRBloom ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRBloom ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRBloom ts)
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
        public static implicit operator ppOptionsHDRBloom(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsHDRBloom)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloom));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRBloom ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloom(int simobjectid)
            {
            return (ppOptionsHDRBloom)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRBloom));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRBloom ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRBloom(uint simobjectid)
            {
            return (ppOptionsHDRBloom)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRBloom));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDRToneMapping>))]
    public class ppOptionsHDRToneMapping : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            //sGlobal["$HDRPostFX::enableToneMapping"] = getValue();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDRToneMapping ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDRToneMapping ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDRToneMapping ts)
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
        public static implicit operator ppOptionsHDRToneMapping(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsHDRToneMapping)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRToneMapping));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDRToneMapping ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRToneMapping(int simobjectid)
            {
            return
                (ppOptionsHDRToneMapping)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDRToneMapping));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDRToneMapping ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDRToneMapping(uint simobjectid)
            {
            return (ppOptionsHDRToneMapping)Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDRToneMapping));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDREffectsBlueShift>))]
    public class ppOptionsHDREffectsBlueShift : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            sGlobal["$HDRPostFX::enableBlueShift"] = getValue();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDREffectsBlueShift ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDREffectsBlueShift ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDREffectsBlueShift ts)
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
        public static implicit operator ppOptionsHDREffectsBlueShift(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDREffectsBlueShift)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDREffectsBlueShift));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDREffectsBlueShift ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDREffectsBlueShift(int simobjectid)
            {
            return
                (ppOptionsHDREffectsBlueShift)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDREffectsBlueShift));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDREffectsBlueShift ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDREffectsBlueShift(uint simobjectid)
            {
            return
                (ppOptionsHDREffectsBlueShift)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDREffectsBlueShift));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDREffectsBlueShiftColorBlend>))]
    public class ppOptionsHDREffectsBlueShiftColorBlend : GuiColorPickerCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            sGlobal["$HDRPostFX::blueShiftColor"] = pickColor.AsString();
            tooltip = "Color Values : " + pickColor.AsString();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDREffectsBlueShiftColorBlend ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDREffectsBlueShiftColorBlend ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDREffectsBlueShiftColorBlend ts)
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
        public static implicit operator ppOptionsHDREffectsBlueShiftColorBlend(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDREffectsBlueShiftColorBlend)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDREffectsBlueShiftColorBlend));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDREffectsBlueShiftColorBlend ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDREffectsBlueShiftColorBlend(int simobjectid)
            {
            return
                (ppOptionsHDREffectsBlueShiftColorBlend)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDREffectsBlueShiftColorBlend));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDREffectsBlueShiftColorBlend ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDREffectsBlueShiftColorBlend(uint simobjectid)
            {
            return
                (ppOptionsHDREffectsBlueShiftColorBlend)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDREffectsBlueShiftColorBlend));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsHDREffectsBlueShiftColorBaseColor>))]
    public class ppOptionsHDREffectsBlueShiftColorBaseColor : GuiColorPickerCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            ((GuiColorPickerCtrl)"ppOptionsHDREffectsBlueShiftColorBlend").baseColor = pickColor;
            tooltip = "Color Values : " + pickColor.AsString();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsHDREffectsBlueShiftColorBaseColor ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsHDREffectsBlueShiftColorBaseColor ts, string simobjectid)
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
        public static implicit operator string(ppOptionsHDREffectsBlueShiftColorBaseColor ts)
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
        public static implicit operator ppOptionsHDREffectsBlueShiftColorBaseColor(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsHDREffectsBlueShiftColorBaseColor)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDREffectsBlueShiftColorBaseColor));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsHDREffectsBlueShiftColorBaseColor ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsHDREffectsBlueShiftColorBaseColor(int simobjectid)
            {
            return
                (ppOptionsHDREffectsBlueShiftColorBaseColor)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsHDREffectsBlueShiftColorBaseColor));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsHDREffectsBlueShiftColorBaseColor ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsHDREffectsBlueShiftColorBaseColor(uint simobjectid)
            {
            return
                (ppOptionsHDREffectsBlueShiftColorBaseColor)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsHDREffectsBlueShiftColorBaseColor));
            }

        #endregion
        }

    //Light rays Slider Controls
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsLightRaysBrightScalar>))]
    public class ppOptionsLightRaysBrightScalar : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$LightRayPostFX::brightScalar"] = value;
            tooltip = "Value : " + value;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsLightRaysBrightScalar ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsLightRaysBrightScalar ts, string simobjectid)
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
        public static implicit operator string(ppOptionsLightRaysBrightScalar ts)
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
        public static implicit operator ppOptionsLightRaysBrightScalar(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsLightRaysBrightScalar)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsLightRaysBrightScalar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsLightRaysBrightScalar ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsLightRaysBrightScalar(int simobjectid)
            {
            return
                (ppOptionsLightRaysBrightScalar)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsLightRaysBrightScalar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsLightRaysBrightScalar ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsLightRaysBrightScalar(uint simobjectid)
            {
            return
                (ppOptionsLightRaysBrightScalar)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsLightRaysBrightScalar));
            }

        #endregion
        }

    //DOF General Tab
    //DOF Toggles
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFEnableDOF>))]
    public class ppOptionsDOFEnableDOF : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            sGlobal["$PostFXManager::PostFX::EnableDOF"] = getValue();
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFEnableDOF ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFEnableDOF ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFEnableDOF ts)
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
        public static implicit operator ppOptionsDOFEnableDOF(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsDOFEnableDOF)Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFEnableDOF));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFEnableDOF ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFEnableDOF(int simobjectid)
            {
            return (ppOptionsDOFEnableDOF)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFEnableDOF));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFEnableDOF ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFEnableDOF(uint simobjectid)
            {
            return (ppOptionsDOFEnableDOF)Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFEnableDOF));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFEnableAutoFocus>))]
    public class ppOptionsDOFEnableAutoFocus : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            sGlobal["$DOFPostFx::EnableAutoFocus"] = getValue();
            ((DOFPostEffect)"DOFPostEffect").setAutoFocus(getValue().AsBool());
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFEnableAutoFocus ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFEnableAutoFocus ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFEnableAutoFocus ts)
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
        public static implicit operator ppOptionsDOFEnableAutoFocus(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFEnableAutoFocus)Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFEnableAutoFocus));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFEnableAutoFocus ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFEnableAutoFocus(int simobjectid)
            {
            return
                (ppOptionsDOFEnableAutoFocus)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFEnableAutoFocus));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFEnableAutoFocus ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFEnableAutoFocus(uint simobjectid)
            {
            return
                (ppOptionsDOFEnableAutoFocus)Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFEnableAutoFocus));
            }

        #endregion
        }

    //DOF AutoFocus Slider controls
    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFFarBlurMinSlider>))]
    public class ppOptionsDOFFarBlurMinSlider : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$DOFPostFx::BlurMin"] = value;
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFFarBlurMinSlider ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFFarBlurMinSlider ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFFarBlurMinSlider ts)
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
        public static implicit operator ppOptionsDOFFarBlurMinSlider(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFFarBlurMinSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFarBlurMinSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFFarBlurMinSlider ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFarBlurMinSlider(int simobjectid)
            {
            return
                (ppOptionsDOFFarBlurMinSlider)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFFarBlurMinSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFFarBlurMinSlider ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFarBlurMinSlider(uint simobjectid)
            {
            return
                (ppOptionsDOFFarBlurMinSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFarBlurMinSlider));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFFarBlurMaxSlider>))]
    public class ppOptionsDOFFarBlurMaxSlider : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$DOFPostFx::BlurMax"] = value;
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFFarBlurMaxSlider ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFFarBlurMaxSlider ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFFarBlurMaxSlider ts)
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
        public static implicit operator ppOptionsDOFFarBlurMaxSlider(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFFarBlurMaxSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFarBlurMaxSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFFarBlurMaxSlider ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFarBlurMaxSlider(int simobjectid)
            {
            return
                (ppOptionsDOFFarBlurMaxSlider)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFFarBlurMaxSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFFarBlurMaxSlider ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFarBlurMaxSlider(uint simobjectid)
            {
            return
                (ppOptionsDOFFarBlurMaxSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFarBlurMaxSlider));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFFocusRangeMinSlider>))]
    public class ppOptionsDOFFocusRangeMinSlider : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$DOFPostFx::FocusRangeMin"] = value;
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFFocusRangeMinSlider ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFFocusRangeMinSlider ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFFocusRangeMinSlider ts)
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
        public static implicit operator ppOptionsDOFFocusRangeMinSlider(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFFocusRangeMinSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFocusRangeMinSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFFocusRangeMinSlider ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFocusRangeMinSlider(int simobjectid)
            {
            return
                (ppOptionsDOFFocusRangeMinSlider)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFFocusRangeMinSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFFocusRangeMinSlider ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFocusRangeMinSlider(uint simobjectid)
            {
            return
                (ppOptionsDOFFocusRangeMinSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFocusRangeMinSlider));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFFocusRangeMaxSlider>))]
    public class ppOptionsDOFFocusRangeMaxSlider : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$DOFPostFx::FocusRangeMax"] = value;
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFFocusRangeMaxSlider ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFFocusRangeMaxSlider ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFFocusRangeMaxSlider ts)
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
        public static implicit operator ppOptionsDOFFocusRangeMaxSlider(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFFocusRangeMaxSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFocusRangeMaxSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFFocusRangeMaxSlider ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFocusRangeMaxSlider(int simobjectid)
            {
            return
                (ppOptionsDOFFocusRangeMaxSlider)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFFocusRangeMaxSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFFocusRangeMaxSlider ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFFocusRangeMaxSlider(uint simobjectid)
            {
            return
                (ppOptionsDOFFocusRangeMaxSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFFocusRangeMaxSlider));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFBlurCurveNearSlider>))]
    public class ppOptionsDOFBlurCurveNearSlider : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$DOFPostFx::BlurCurveNear"] = value;
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFBlurCurveNearSlider ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFBlurCurveNearSlider ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFBlurCurveNearSlider ts)
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
        public static implicit operator ppOptionsDOFBlurCurveNearSlider(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFBlurCurveNearSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFBlurCurveNearSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFBlurCurveNearSlider ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFBlurCurveNearSlider(int simobjectid)
            {
            return
                (ppOptionsDOFBlurCurveNearSlider)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFBlurCurveNearSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFBlurCurveNearSlider ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFBlurCurveNearSlider(uint simobjectid)
            {
            return
                (ppOptionsDOFBlurCurveNearSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFBlurCurveNearSlider));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsDOFBlurCurveFarSlider>))]
    public class ppOptionsDOFBlurCurveFarSlider : GuiSliderCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onMouseDragged()
            {
            dGlobal["$DOFPostFx::BlurCurveFar"] = value;
            postFXManager.ppOptionsUpdateDOFSettings();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsDOFBlurCurveFarSlider ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsDOFBlurCurveFarSlider ts, string simobjectid)
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
        public static implicit operator string(ppOptionsDOFBlurCurveFarSlider ts)
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
        public static implicit operator ppOptionsDOFBlurCurveFarSlider(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (ppOptionsDOFBlurCurveFarSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFBlurCurveFarSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsDOFBlurCurveFarSlider ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFBlurCurveFarSlider(int simobjectid)
            {
            return
                (ppOptionsDOFBlurCurveFarSlider)
                    Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsDOFBlurCurveFarSlider));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsDOFBlurCurveFarSlider ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsDOFBlurCurveFarSlider(uint simobjectid)
            {
            return
                (ppOptionsDOFBlurCurveFarSlider)
                    Omni.self.getSimObject(simobjectid, typeof(ppOptionsDOFBlurCurveFarSlider));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableHDRDebug>))]
    public class ppOptionsEnableHDRDebug : GuiCheckBoxCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAction()
            {
            if (getValue().AsBool())
                ((PostEffect)"LuminanceVisPostFX").enable();
            else
                ((PostEffect)"LuminanceVisPostFX").disable();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableHDRDebug ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableHDRDebug ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableHDRDebug ts)
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
        public static implicit operator ppOptionsEnableHDRDebug(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableHDRDebug)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableHDRDebug));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableHDRDebug ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableHDRDebug(int simobjectid)
            {
            return
                (ppOptionsEnableHDRDebug)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableHDRDebug));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableHDRDebug ts)
            {
            return (uint)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableHDRDebug(uint simobjectid)
            {
            return (ppOptionsEnableHDRDebug)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableHDRDebug));
            }

        #endregion
        }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableSharpness>))]
    public class ppOptionsEnableSharpness : GuiCheckBoxCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            postFXManager PostFXManager = "PostFXManager";
            bool toEnable = PostFXManager.getEnableResultFromControl(this);
            PostFXManager.settingsEffectSetEnabled("Sharp", toEnable);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableSharpness ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableSharpness ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableSharpness ts)
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
        public static implicit operator ppOptionsEnableSharpness(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableSharpness)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableSharpness));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableSharpness ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableSharpness(int simobjectid)
        {
            return
                (ppOptionsEnableSharpness)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableSharpness));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableSharpness ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableSharpness(uint simobjectid)
        {
            return (ppOptionsEnableSharpness)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableSharpness));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableNV>))]
    public class ppOptionsEnableNV : GuiCheckBoxCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            postFXManager PostFXManager = "PostFXManager";
            bool toEnable = PostFXManager.getEnableResultFromControl(this);
            PostFXManager.settingsEffectSetEnabled("NV", toEnable);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableNV ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableNV ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableNV ts)
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
        public static implicit operator ppOptionsEnableNV(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableNV)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableNV));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableNV ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableNV(int simobjectid)
        {
            return
                (ppOptionsEnableNV)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableNV));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableNV ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableNV(uint simobjectid)
        {
            return (ppOptionsEnableNV)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableNV));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsEnableImageOpt>))]
    public class ppOptionsEnableImageOpt : GuiCheckBoxCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            postFXManager PostFXManager = "PostFXManager";
            bool toEnable = PostFXManager.getEnableResultFromControl(this);
            PostFXManager.settingsEffectSetEnabled("ImageOpt", toEnable);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsEnableImageOpt ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsEnableImageOpt ts, string simobjectid)
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
        public static implicit operator string(ppOptionsEnableImageOpt ts)
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
        public static implicit operator ppOptionsEnableImageOpt(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsEnableImageOpt)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableImageOpt));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsEnableImageOpt ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableImageOpt(int simobjectid)
        {
            return
                (ppOptionsEnableImageOpt)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsEnableImageOpt));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsEnableImageOpt ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsEnableImageOpt(uint simobjectid)
        {
            return (ppOptionsEnableImageOpt)Omni.self.getSimObject(simobjectid, typeof(ppOptionsEnableImageOpt));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptSharpen>))]
    public class ppOptionsImageOptSharpen : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::Sharpen"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptSharpen ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptSharpen ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptSharpen ts)
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
        public static implicit operator ppOptionsImageOptSharpen(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptSharpen)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptSharpen));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptSharpen ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptSharpen(int simobjectid)
        {
            return
                (ppOptionsImageOptSharpen)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptSharpen));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptSharpen ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptSharpen(uint simobjectid)
        {
            return (ppOptionsImageOptSharpen)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptSharpen));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptDesaturation>))]
    public class ppOptionsImageOptDesaturation : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::Desaturation"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptDesaturation ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptDesaturation ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptDesaturation ts)
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
        public static implicit operator ppOptionsImageOptDesaturation(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptDesaturation)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptDesaturation));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptDesaturation ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptDesaturation(int simobjectid)
        {
            return
                (ppOptionsImageOptDesaturation)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptDesaturation));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptDesaturation ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptDesaturation(uint simobjectid)
        {
            return (ppOptionsImageOptDesaturation)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptDesaturation));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptToned>))]
    public class ppOptionsImageOptToned : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::Toned"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptToned ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptToned ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptToned ts)
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
        public static implicit operator ppOptionsImageOptToned(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptToned)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptToned));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptToned ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptToned(int simobjectid)
        {
            return
                (ppOptionsImageOptToned)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptToned));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptToned ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptToned(uint simobjectid)
        {
            return (ppOptionsImageOptToned)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptToned));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptGamma>))]
    public class ppOptionsImageOptGamma : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::Gamma"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptGamma ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptGamma ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptGamma ts)
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
        public static implicit operator ppOptionsImageOptGamma(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptGamma)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptGamma));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptGamma ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptGamma(int simobjectid)
        {
            return
                (ppOptionsImageOptGamma)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptGamma));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptGamma ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptGamma(uint simobjectid)
        {
            return (ppOptionsImageOptGamma)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptGamma));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptRed>))]
    public class ppOptionsImageOptRed : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::ScaleR"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptRed ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptRed ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptRed ts)
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
        public static implicit operator ppOptionsImageOptRed(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptRed)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptRed));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptRed ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptRed(int simobjectid)
        {
            return
                (ppOptionsImageOptRed)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptRed));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptRed ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptRed(uint simobjectid)
        {
            return (ppOptionsImageOptRed)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptRed));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptGreen>))]
    public class ppOptionsImageOptGreen : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::ScaleG"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptGreen ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptGreen ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptGreen ts)
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
        public static implicit operator ppOptionsImageOptGreen(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptGreen)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptGreen));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptGreen ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptGreen(int simobjectid)
        {
            return
                (ppOptionsImageOptGreen)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptGreen));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptGreen ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptGreen(uint simobjectid)
        {
            return (ppOptionsImageOptGreen)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptGreen));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsImageOptBlue>))]
    public class ppOptionsImageOptBlue : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$ImageOptFX::ScaleB"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsImageOptBlue ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsImageOptBlue ts, string simobjectid)
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
        public static implicit operator string(ppOptionsImageOptBlue ts)
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
        public static implicit operator ppOptionsImageOptBlue(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsImageOptBlue)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptBlue));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsImageOptBlue ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptBlue(int simobjectid)
        {
            return
                (ppOptionsImageOptBlue)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsImageOptBlue));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsImageOptBlue ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsImageOptBlue(uint simobjectid)
        {
            return (ppOptionsImageOptBlue)Omni.self.getSimObject(simobjectid, typeof(ppOptionsImageOptBlue));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSharpenRange>))]
    public class ppOptionsSharpenRange : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$SharpPostFx::sharpRange"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSharpenRange ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSharpenRange ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSharpenRange ts)
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
        public static implicit operator ppOptionsSharpenRange(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSharpenRange)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSharpenRange));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSharpenRange ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSharpenRange(int simobjectid)
        {
            return
                (ppOptionsSharpenRange)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSharpenRange));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSharpenRange ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSharpenRange(uint simobjectid)
        {
            return (ppOptionsSharpenRange)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSharpenRange));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSharpenWidth>))]
    public class ppOptionsSharpenWidth : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$SharpPostFx::sharpWidth"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSharpenWidth ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSharpenWidth ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSharpenWidth ts)
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
        public static implicit operator ppOptionsSharpenWidth(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSharpenWidth)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSharpenWidth));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSharpenWidth ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSharpenWidth(int simobjectid)
        {
            return
                (ppOptionsSharpenWidth)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSharpenWidth));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSharpenWidth ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSharpenWidth(uint simobjectid)
        {
            return (ppOptionsSharpenWidth)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSharpenWidth));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsSharpenStrength>))]
    public class ppOptionsSharpenStrength : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$SharpPostFx::sharpPower"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsSharpenStrength ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsSharpenStrength ts, string simobjectid)
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
        public static implicit operator string(ppOptionsSharpenStrength ts)
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
        public static implicit operator ppOptionsSharpenStrength(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsSharpenStrength)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSharpenStrength));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsSharpenStrength ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsSharpenStrength(int simobjectid)
        {
            return
                (ppOptionsSharpenStrength)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsSharpenStrength));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsSharpenStrength ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsSharpenStrength(uint simobjectid)
        {
            return (ppOptionsSharpenStrength)Omni.self.getSimObject(simobjectid, typeof(ppOptionsSharpenStrength));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsNVBright>))]
    public class ppOptionsNVBright : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$NVPostFx::brightThreshold"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsNVBright ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsNVBright ts, string simobjectid)
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
        public static implicit operator string(ppOptionsNVBright ts)
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
        public static implicit operator ppOptionsNVBright(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsNVBright)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVBright));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsNVBright ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsNVBright(int simobjectid)
        {
            return
                (ppOptionsNVBright)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsNVBright));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsNVBright ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsNVBright(uint simobjectid)
        {
            return (ppOptionsNVBright)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVBright));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsNVLowMul>))]
    public class ppOptionsNVLowMul : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$NVPostFx::lowMultiplier"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsNVLowMul ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsNVLowMul ts, string simobjectid)
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
        public static implicit operator string(ppOptionsNVLowMul ts)
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
        public static implicit operator ppOptionsNVLowMul(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsNVLowMul)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVLowMul));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsNVLowMul ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsNVLowMul(int simobjectid)
        {
            return
                (ppOptionsNVLowMul)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsNVLowMul));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsNVLowMul ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsNVLowMul(uint simobjectid)
        {
            return (ppOptionsNVLowMul)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVLowMul));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsNVHighMul>))]
    public class ppOptionsNVHighMul : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$NVPostFx::highMultiplier"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsNVHighMul ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsNVHighMul ts, string simobjectid)
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
        public static implicit operator string(ppOptionsNVHighMul ts)
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
        public static implicit operator ppOptionsNVHighMul(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsNVHighMul)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVHighMul));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsNVHighMul ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsNVHighMul(int simobjectid)
        {
            return
                (ppOptionsNVHighMul)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsNVHighMul));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsNVHighMul ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsNVHighMul(uint simobjectid)
        {
            return (ppOptionsNVHighMul)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVHighMul));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsNVDistMul>))]
    public class ppOptionsNVDistMul : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$NVPostFx::DistMul"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsNVDistMul ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsNVDistMul ts, string simobjectid)
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
        public static implicit operator string(ppOptionsNVDistMul ts)
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
        public static implicit operator ppOptionsNVDistMul(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsNVDistMul)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVDistMul));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsNVDistMul ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsNVDistMul(int simobjectid)
        {
            return
                (ppOptionsNVDistMul)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsNVDistMul));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsNVDistMul ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsNVDistMul(uint simobjectid)
        {
            return (ppOptionsNVDistMul)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVDistMul));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsNVDistFreq>))]
    public class ppOptionsNVDistFreq : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$NVPostFx::DistFreq"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsNVDistFreq ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsNVDistFreq ts, string simobjectid)
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
        public static implicit operator string(ppOptionsNVDistFreq ts)
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
        public static implicit operator ppOptionsNVDistFreq(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsNVDistFreq)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVDistFreq));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsNVDistFreq ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsNVDistFreq(int simobjectid)
        {
            return
                (ppOptionsNVDistFreq)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsNVDistFreq));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsNVDistFreq ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsNVDistFreq(uint simobjectid)
        {
            return (ppOptionsNVDistFreq)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVDistFreq));
        }

        #endregion
    }

    [TypeConverter(typeof(TypeConverterGeneric<ppOptionsNVDistRoll>))]
    public class ppOptionsNVDistRoll : GuiSliderCtrl
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAction()
        {
            fGlobal["$NVPostFx::DistRoll"] = this.value;
            this.tooltip = "Value : " + this.value;
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ppOptionsNVDistRoll ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(ppOptionsNVDistRoll ts, string simobjectid)
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
        public static implicit operator string(ppOptionsNVDistRoll ts)
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
        public static implicit operator ppOptionsNVDistRoll(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ppOptionsNVDistRoll)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVDistRoll));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ppOptionsNVDistRoll ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ppOptionsNVDistRoll(int simobjectid)
        {
            return
                (ppOptionsNVDistRoll)Omni.self.getSimObject((uint)simobjectid, typeof(ppOptionsNVDistRoll));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ppOptionsNVDistRoll ts)
        {
            return (uint)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ppOptionsNVDistRoll(uint simobjectid)
        {
            return (ppOptionsNVDistRoll)Omni.self.getSimObject(simobjectid, typeof(ppOptionsNVDistRoll));
        }

        #endregion
    }

    /*
     WLE_OVERRIDE_PROXY_CLASSTYPE = ""; 
     [TypeConverter(typeof(TypeConverterGeneric<>))]
        class  : co
            {
        
            }
     */

    //SSAO Slider controls
    //General Tab
    }