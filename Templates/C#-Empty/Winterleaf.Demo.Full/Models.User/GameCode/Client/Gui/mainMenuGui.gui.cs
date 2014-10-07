using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.ChooseLevel;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<mainMenuGui>))]
    public class mainMenuGui : GuiChunkedBitmapCtrl
        {
        public static void initialize()
            {
                ObjectCreator oc_Newobject00022;
                ObjectCreator oc_Newobject00021;
                ObjectCreator oc_Newobject00020;
                ObjectCreator oc_Newobject00019;
                ObjectCreator oc_Newobject00018;
                ObjectCreator oc_Newobject00017;
                ObjectCreator oc_Newobject00016;
                ObjectCreator oc_Newobject00015;
                ObjectCreator oc_Newobject00014;
                ObjectCreator oc_Newobject00013;
                ObjectCreator oc_Newobject00012;
                ObjectCreator oc_Newobject00011;
                ObjectCreator oc_Newobject00010;
                ObjectCreator oc_Newobject00009;
                ObjectCreator oc_Newobject00008;
                ObjectCreator oc_Newobject00007;
                ObjectCreator oc_Newobject00006;
                ObjectCreator oc_Newobject00005;
                ObjectCreator oc_Newobject00004;
                ObjectCreator oc_Newobject00003;
                ObjectCreator oc_Newobject00002;
                ObjectCreator oc_Newobject00001;
                if (true)
                {

                    #region GuiChunkedBitmapCtrl (MainMenuGui)        oc_Newobject00022
                    oc_Newobject00022 = new ObjectCreator("GuiChunkedBitmapCtrl", "MainMenuGui", typeof(mainMenuGui));
                    oc_Newobject00022["bitmap"] = "art/gui/background";
                    oc_Newobject00022["useVariable"] = "0";
                    oc_Newobject00022["tile"] = "0";
                    oc_Newobject00022["position"] = "0 0";
                    oc_Newobject00022["extent"] = "1024 768";
                    oc_Newobject00022["minExtent"] = "8 8";
                    oc_Newobject00022["maxExtent"] = "1920 1080";
                    oc_Newobject00022["horizSizing"] = "width";
                    oc_Newobject00022["vertSizing"] = "height";
                    oc_Newobject00022["profile"] = "GuiDefaultProfile";
                    oc_Newobject00022["controlFontColor"] = "0 0 0 0";
                    oc_Newobject00022["controlFillColor"] = "0 0 0 0";
                    oc_Newobject00022["backgroundColor"] = "255 255 255 255";
                    oc_Newobject00022["controlFontSize"] = "14";
                    oc_Newobject00022["visible"] = "1";
                    oc_Newobject00022["active"] = "1";
                    oc_Newobject00022["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00022["hovertime"] = "1000";
                    oc_Newobject00022["isContainer"] = "1";
                    oc_Newobject00022["alphaValue"] = "1";
                    oc_Newobject00022["mouseOverAlphaValue"] = "1";
                    oc_Newobject00022["alphaFadeTime"] = "1000";
                    oc_Newobject00022["moveControl"] = "0";
                    oc_Newobject00022["lockControl"] = "0";
                    oc_Newobject00022["windowSettings"] = "1";
                    oc_Newobject00022["alpha"] = "1";
                    oc_Newobject00022["mouseOverAlpha"] = "1";
                    oc_Newobject00022["alphaFade"] = "1";
                    oc_Newobject00022["contextFontColor"] = "0";
                    oc_Newobject00022["contextBackColor"] = "0";
                    oc_Newobject00022["contextFillColor"] = "0";
                    oc_Newobject00022["contextFontSize"] = "0";
                    oc_Newobject00022["editable"] = "0";
                    oc_Newobject00022["canSave"] = "1";
                    oc_Newobject00022["canSaveDynamicFields"] = "1";
                    oc_Newobject00022["Enabled"] = "1";
                    oc_Newobject00022["guidesVertical"] = "8";
                    oc_Newobject00022["isDecoy"] = "0";
                    if (true)
                    {

                        #region GuiControl ()        oc_Newobject00006
                        oc_Newobject00006 = new ObjectCreator("GuiControl", "");
                        oc_Newobject00006["position"] = "37 87";
                        oc_Newobject00006["extent"] = "306 434";
                        oc_Newobject00006["minExtent"] = "8 2";
                        oc_Newobject00006["maxExtent"] = "1920 1080";
                        oc_Newobject00006["horizSizing"] = "windowRelative";
                        oc_Newobject00006["vertSizing"] = "windowRelative";
                        oc_Newobject00006["profile"] = "GuiDefaultProfile";
                        oc_Newobject00006["controlFontColor"] = "0 0 0 0";
                        oc_Newobject00006["controlFillColor"] = "0 0 0 0";
                        oc_Newobject00006["backgroundColor"] = "255 255 255 255";
                        oc_Newobject00006["controlFontSize"] = "14";
                        oc_Newobject00006["visible"] = "1";
                        oc_Newobject00006["active"] = "1";
                        oc_Newobject00006["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00006["hovertime"] = "1000";
                        oc_Newobject00006["isContainer"] = "1";
                        oc_Newobject00006["alphaValue"] = "1";
                        oc_Newobject00006["mouseOverAlphaValue"] = "1";
                        oc_Newobject00006["alphaFadeTime"] = "1000";
                        oc_Newobject00006["moveControl"] = "0";
                        oc_Newobject00006["lockControl"] = "0";
                        oc_Newobject00006["windowSettings"] = "1";
                        oc_Newobject00006["alpha"] = "1";
                        oc_Newobject00006["mouseOverAlpha"] = "1";
                        oc_Newobject00006["alphaFade"] = "1";
                        oc_Newobject00006["contextFontColor"] = "0";
                        oc_Newobject00006["contextBackColor"] = "0";
                        oc_Newobject00006["contextFillColor"] = "0";
                        oc_Newobject00006["contextFontSize"] = "0";
                        oc_Newobject00006["editable"] = "0";
                        oc_Newobject00006["canSave"] = "1";
                        oc_Newobject00006["canSaveDynamicFields"] = "0";
                        oc_Newobject00006["Enabled"] = "1";
                        if (true)
                        {

                            #region GuiButtonCtrl ()        oc_Newobject00001
                            oc_Newobject00001 = new ObjectCreator("GuiButtonCtrl", "");
                            oc_Newobject00001["text"] = "Join Hosted Game";
                            oc_Newobject00001["groupNum"] = "-1";
                            oc_Newobject00001["buttonType"] = "PushButton";
                            oc_Newobject00001["useMouseEvents"] = "0";
                            oc_Newobject00001["position"] = "10 175";
                            oc_Newobject00001["extent"] = "288 75";
                            oc_Newobject00001["minExtent"] = "8 8";
                            oc_Newobject00001["maxExtent"] = "1920 1080";
                            oc_Newobject00001["horizSizing"] = "relative";
                            oc_Newobject00001["vertSizing"] = "bottom";
                            oc_Newobject00001["profile"] = "GuiMenuButtonProfile";
                            oc_Newobject00001["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00001["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00001["controlFontSize"] = "18";
                            oc_Newobject00001["visible"] = "1";
                            oc_Newobject00001["active"] = "1";
                            oc_Newobject00001["command"] = "Canvas.pushDialog(JoinServerDlg);";
                            oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00001["hovertime"] = "1000";
                            oc_Newobject00001["isContainer"] = "0";
                            oc_Newobject00001["alphaValue"] = "1";
                            oc_Newobject00001["mouseOverAlphaValue"] = "1";
                            oc_Newobject00001["alphaFadeTime"] = "1000";
                            oc_Newobject00001["windowSettings"] = "1";
                            oc_Newobject00001["alpha"] = "1";
                            oc_Newobject00001["mouseOverAlpha"] = "1";
                            oc_Newobject00001["alphaFade"] = "1";
                            oc_Newobject00001["contextFontColor"] = "0";
                            oc_Newobject00001["contextBackColor"] = "0";
                            oc_Newobject00001["contextFontSize"] = "0";
                            oc_Newobject00001["editable"] = "0";
                            oc_Newobject00001["canSave"] = "1";
                            oc_Newobject00001["canSaveDynamicFields"] = "0";
                            oc_Newobject00001["Enabled"] = "1";
                            #endregion

                            oc_Newobject00006["#Newobject00001"] = oc_Newobject00001;

                            #region GuiButtonCtrl ()        oc_Newobject00002
                            oc_Newobject00002 = new ObjectCreator("GuiButtonCtrl", "");
                            oc_Newobject00002["text"] = "Options";
                            oc_Newobject00002["groupNum"] = "-1";
                            oc_Newobject00002["buttonType"] = "PushButton";
                            oc_Newobject00002["useMouseEvents"] = "0";
                            oc_Newobject00002["position"] = "10 25";
                            oc_Newobject00002["extent"] = "288 75";
                            oc_Newobject00002["minExtent"] = "8 8";
                            oc_Newobject00002["maxExtent"] = "1920 1080";
                            oc_Newobject00002["horizSizing"] = "relative";
                            oc_Newobject00002["vertSizing"] = "bottom";
                            oc_Newobject00002["profile"] = "GuiMenuButtonProfile";
                            oc_Newobject00002["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00002["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00002["controlFontSize"] = "18";
                            oc_Newobject00002["visible"] = "1";
                            oc_Newobject00002["active"] = "1";
                            oc_Newobject00002["command"] = "Canvas.pushDialog(optionsDlg);";
                            oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00002["hovertime"] = "1000";
                            oc_Newobject00002["isContainer"] = "0";
                            oc_Newobject00002["alphaValue"] = "1";
                            oc_Newobject00002["mouseOverAlphaValue"] = "1";
                            oc_Newobject00002["alphaFadeTime"] = "1000";
                            oc_Newobject00002["windowSettings"] = "1";
                            oc_Newobject00002["alpha"] = "1";
                            oc_Newobject00002["mouseOverAlpha"] = "1";
                            oc_Newobject00002["alphaFade"] = "1";
                            oc_Newobject00002["contextFontColor"] = "0";
                            oc_Newobject00002["contextBackColor"] = "0";
                            oc_Newobject00002["contextFontSize"] = "0";
                            oc_Newobject00002["editable"] = "0";
                            oc_Newobject00002["canSave"] = "1";
                            oc_Newobject00002["canSaveDynamicFields"] = "0";
                            oc_Newobject00002["Enabled"] = "1";
                            #endregion

                            oc_Newobject00006["#Newobject00002"] = oc_Newobject00002;

                            #region GuiButtonCtrl ()        oc_Newobject00003
                            oc_Newobject00003 = new ObjectCreator("GuiButtonCtrl", "");
                            oc_Newobject00003["text"] = "Gui Editor";
                            oc_Newobject00003["groupNum"] = "-1";
                            oc_Newobject00003["buttonType"] = "PushButton";
                            oc_Newobject00003["useMouseEvents"] = "0";
                            oc_Newobject00003["position"] = "10 100";
                            oc_Newobject00003["extent"] = "288 75";
                            oc_Newobject00003["minExtent"] = "8 8";
                            oc_Newobject00003["maxExtent"] = "1920 1080";
                            oc_Newobject00003["horizSizing"] = "relative";
                            oc_Newobject00003["vertSizing"] = "bottom";
                            oc_Newobject00003["profile"] = "GuiMenuButtonProfile";
                            oc_Newobject00003["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00003["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00003["controlFontSize"] = "18";
                            oc_Newobject00003["visible"] = "1";
                            oc_Newobject00003["active"] = "1";
                            oc_Newobject00003["command"] = "GuiEdit();";
                            oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00003["tooltip"] = "The GUI Editor is accessible in-game by pressing F10";
                            oc_Newobject00003["hovertime"] = "1000";
                            oc_Newobject00003["isContainer"] = "0";
                            oc_Newobject00003["alphaValue"] = "1";
                            oc_Newobject00003["mouseOverAlphaValue"] = "1";
                            oc_Newobject00003["alphaFadeTime"] = "1000";
                            oc_Newobject00003["windowSettings"] = "1";
                            oc_Newobject00003["alpha"] = "1";
                            oc_Newobject00003["mouseOverAlpha"] = "1";
                            oc_Newobject00003["alphaFade"] = "1";
                            oc_Newobject00003["contextFontColor"] = "0";
                            oc_Newobject00003["contextBackColor"] = "0";
                            oc_Newobject00003["contextFontSize"] = "0";
                            oc_Newobject00003["internalName"] = "GuiEditorButton";
                            oc_Newobject00003["editable"] = "0";
                            oc_Newobject00003["canSave"] = "1";
                            oc_Newobject00003["canSaveDynamicFields"] = "0";
                            oc_Newobject00003["Enabled"] = "1";
                            #endregion

                            oc_Newobject00006["#Newobject00003"] = oc_Newobject00003;

                            #region GuiButtonCtrl ()        oc_Newobject00004
                            oc_Newobject00004 = new ObjectCreator("GuiButtonCtrl", "");
                            oc_Newobject00004["text"] = "Tools";
                            oc_Newobject00004["groupNum"] = "-1";
                            oc_Newobject00004["buttonType"] = "PushButton";
                            oc_Newobject00004["useMouseEvents"] = "0";
                            oc_Newobject00004["position"] = "10 250";
                            oc_Newobject00004["extent"] = "288 75";
                            oc_Newobject00004["minExtent"] = "8 8";
                            oc_Newobject00004["maxExtent"] = "1920 1080";
                            oc_Newobject00004["horizSizing"] = "relative";
                            oc_Newobject00004["vertSizing"] = "bottom";
                            oc_Newobject00004["profile"] = "GuiMenuButtonProfile";
                            oc_Newobject00004["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00004["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00004["controlFontSize"] = "18";
                            oc_Newobject00004["visible"] = "1";
                            oc_Newobject00004["active"] = "1";
                            oc_Newobject00004["command"] = "Canvas.pushDialog(ToolsDlg);";
                            oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00004["hovertime"] = "1000";
                            oc_Newobject00004["isContainer"] = "0";
                            oc_Newobject00004["alphaValue"] = "1";
                            oc_Newobject00004["mouseOverAlphaValue"] = "1";
                            oc_Newobject00004["alphaFadeTime"] = "1000";
                            oc_Newobject00004["windowSettings"] = "1";
                            oc_Newobject00004["alpha"] = "1";
                            oc_Newobject00004["mouseOverAlpha"] = "1";
                            oc_Newobject00004["alphaFade"] = "1";
                            oc_Newobject00004["contextFontColor"] = "0";
                            oc_Newobject00004["contextBackColor"] = "0";
                            oc_Newobject00004["contextFontSize"] = "0";
                            oc_Newobject00004["editable"] = "0";
                            oc_Newobject00004["canSave"] = "1";
                            oc_Newobject00004["canSaveDynamicFields"] = "0";
                            oc_Newobject00004["Enabled"] = "1";
                            #endregion

                            oc_Newobject00006["#Newobject00004"] = oc_Newobject00004;

                            #region GuiButtonCtrl ()        oc_Newobject00005
                            oc_Newobject00005 = new ObjectCreator("GuiButtonCtrl", "");
                            oc_Newobject00005["text"] = "Exit";
                            oc_Newobject00005["groupNum"] = "-1";
                            oc_Newobject00005["buttonType"] = "PushButton";
                            oc_Newobject00005["useMouseEvents"] = "0";
                            oc_Newobject00005["position"] = "10 325";
                            oc_Newobject00005["extent"] = "288 75";
                            oc_Newobject00005["minExtent"] = "8 8";
                            oc_Newobject00005["maxExtent"] = "1920 1080";
                            oc_Newobject00005["horizSizing"] = "relative";
                            oc_Newobject00005["vertSizing"] = "bottom";
                            oc_Newobject00005["profile"] = "GuiMenuButtonProfile";
                            oc_Newobject00005["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00005["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00005["controlFontSize"] = "18";
                            oc_Newobject00005["visible"] = "1";
                            oc_Newobject00005["active"] = "1";
                            oc_Newobject00005["command"] = "quit();";
                            oc_Newobject00005["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00005["hovertime"] = "1000";
                            oc_Newobject00005["isContainer"] = "0";
                            oc_Newobject00005["alphaValue"] = "1";
                            oc_Newobject00005["mouseOverAlphaValue"] = "1";
                            oc_Newobject00005["alphaFadeTime"] = "1000";
                            oc_Newobject00005["windowSettings"] = "1";
                            oc_Newobject00005["alpha"] = "1";
                            oc_Newobject00005["mouseOverAlpha"] = "1";
                            oc_Newobject00005["alphaFade"] = "1";
                            oc_Newobject00005["contextFontColor"] = "0";
                            oc_Newobject00005["contextBackColor"] = "0";
                            oc_Newobject00005["contextFontSize"] = "0";
                            oc_Newobject00005["internalName"] = "ExitButton";
                            oc_Newobject00005["editable"] = "0";
                            oc_Newobject00005["canSave"] = "1";
                            oc_Newobject00005["canSaveDynamicFields"] = "0";
                            oc_Newobject00005["Enabled"] = "1";
                            #endregion

                            oc_Newobject00006["#Newobject00005"] = oc_Newobject00005;

                        }
                        #endregion

                        oc_Newobject00022["#Newobject00006"] = oc_Newobject00006;

                        #region GuiBitmapCtrl (MainMenuAppLogo)        oc_Newobject00007
                        oc_Newobject00007 = new ObjectCreator("GuiBitmapCtrl", "MainMenuAppLogo");
                        oc_Newobject00007["bitmap"] = "art/gui/omni-logo.png";
                        oc_Newobject00007["wrap"] = "0";
                        oc_Newobject00007["setBitmap"] = "0";
                        oc_Newobject00007["position"] = "47 537";
                        oc_Newobject00007["extent"] = "280 172";
                        oc_Newobject00007["minExtent"] = "8 2";
                        oc_Newobject00007["maxExtent"] = "1920 1080";
                        oc_Newobject00007["horizSizing"] = "windowRelative";
                        oc_Newobject00007["vertSizing"] = "windowRelative";
                        oc_Newobject00007["profile"] = "GuiDefaultProfile";
                        oc_Newobject00007["controlFontColor"] = "0 0 0 0";
                        oc_Newobject00007["controlFillColor"] = "0 0 0 0";
                        oc_Newobject00007["backgroundColor"] = "255 255 255 255";
                        oc_Newobject00007["controlFontSize"] = "14";
                        oc_Newobject00007["visible"] = "1";
                        oc_Newobject00007["active"] = "1";
                        oc_Newobject00007["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00007["hovertime"] = "1000";
                        oc_Newobject00007["isContainer"] = "0";
                        oc_Newobject00007["alphaValue"] = "1";
                        oc_Newobject00007["mouseOverAlphaValue"] = "1";
                        oc_Newobject00007["alphaFadeTime"] = "1000";
                        oc_Newobject00007["moveControl"] = "0";
                        oc_Newobject00007["lockControl"] = "0";
                        oc_Newobject00007["windowSettings"] = "1";
                        oc_Newobject00007["alpha"] = "1";
                        oc_Newobject00007["mouseOverAlpha"] = "1";
                        oc_Newobject00007["alphaFade"] = "1";
                        oc_Newobject00007["contextFontColor"] = "0";
                        oc_Newobject00007["contextBackColor"] = "0";
                        oc_Newobject00007["contextFillColor"] = "0";
                        oc_Newobject00007["contextFontSize"] = "0";
                        oc_Newobject00007["editable"] = "0";
                        oc_Newobject00007["canSave"] = "1";
                        oc_Newobject00007["canSaveDynamicFields"] = "1";
                        oc_Newobject00007["Enabled"] = "1";
                        oc_Newobject00007["isDecoy"] = "0";
                        #endregion

                        oc_Newobject00022["#Newobject00007"] = oc_Newobject00007;

                        #region GuiControl (ChooseLevelDlg)        oc_Newobject00021
                        oc_Newobject00021 = new ObjectCreator("GuiControl", "ChooseLevelDlg", typeof(chooseLevelDlg));
                        oc_Newobject00021["position"] = "357 60";
                        oc_Newobject00021["extent"] = "659 692";
                        oc_Newobject00021["minExtent"] = "8 2";
                        oc_Newobject00021["maxExtent"] = "1920 1080";
                        oc_Newobject00021["horizSizing"] = "right";
                        oc_Newobject00021["vertSizing"] = "bottom";
                        oc_Newobject00021["profile"] = "GuiDefaultProfile";
                        oc_Newobject00021["controlFontColor"] = "0 0 0 0";
                        oc_Newobject00021["controlFillColor"] = "0 0 0 0";
                        oc_Newobject00021["backgroundColor"] = "255 255 255 255";
                        oc_Newobject00021["controlFontSize"] = "14";
                        oc_Newobject00021["visible"] = "1";
                        oc_Newobject00021["active"] = "1";
                        oc_Newobject00021["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00021["hovertime"] = "1000";
                        oc_Newobject00021["isContainer"] = "1";
                        oc_Newobject00021["alphaValue"] = "1";
                        oc_Newobject00021["mouseOverAlphaValue"] = "1";
                        oc_Newobject00021["alphaFadeTime"] = "1000";
                        oc_Newobject00021["moveControl"] = "0";
                        oc_Newobject00021["lockControl"] = "0";
                        oc_Newobject00021["windowSettings"] = "1";
                        oc_Newobject00021["alpha"] = "1";
                        oc_Newobject00021["mouseOverAlpha"] = "1";
                        oc_Newobject00021["alphaFade"] = "1";
                        oc_Newobject00021["contextFontColor"] = "0";
                        oc_Newobject00021["contextBackColor"] = "0";
                        oc_Newobject00021["contextFillColor"] = "0";
                        oc_Newobject00021["contextFontSize"] = "0";
                        oc_Newobject00021["editable"] = "0";
                        oc_Newobject00021["canSave"] = "1";
                        oc_Newobject00021["canSaveDynamicFields"] = "0";
                        oc_Newobject00021["Enabled"] = "1";
                        if (true)
                        {

                            #region GuiWindowCtrl (ChooseLevelWindow)        oc_Newobject00020
                            oc_Newobject00020 = new ObjectCreator("GuiWindowCtrl", "ChooseLevelWindow",
                                typeof(ChooseLevelWindow));
                            oc_Newobject00020["text"] = "New Window";
                            oc_Newobject00020["resizeWidth"] = "0";
                            oc_Newobject00020["resizeHeight"] = "0";
                            oc_Newobject00020["canMove"] = "0";
                            oc_Newobject00020["canClose"] = "0";
                            oc_Newobject00020["canMinimize"] = "0";
                            oc_Newobject00020["canMaximize"] = "0";
                            oc_Newobject00020["canCollapse"] = "0";
                            oc_Newobject00020["edgeSnap"] = "1";
                            oc_Newobject00020["setTitle"] = "0";
                            oc_Newobject00020["ShowTitle"] = "0";
                            oc_Newobject00020["AllowPopWindow"] = "0";
                            oc_Newobject00020["isInPopup"] = "0";
                            oc_Newobject00020["margin"] = "0 0 0 0";
                            oc_Newobject00020["padding"] = "0 0 0 0";
                            oc_Newobject00020["anchorTop"] = "1";
                            oc_Newobject00020["anchorBottom"] = "0";
                            oc_Newobject00020["anchorLeft"] = "1";
                            oc_Newobject00020["anchorRight"] = "0";
                            oc_Newobject00020["position"] = "16 9";
                            oc_Newobject00020["extent"] = "649 646";
                            oc_Newobject00020["minExtent"] = "8 2";
                            oc_Newobject00020["maxExtent"] = "1920 1080";
                            oc_Newobject00020["horizSizing"] = "right";
                            oc_Newobject00020["vertSizing"] = "bottom";
                            oc_Newobject00020["profile"] = "GuiWindowProfile";
                            oc_Newobject00020["controlFontColor"] = "0 0 0 0";
                            oc_Newobject00020["controlFillColor"] = "0 0 0 0";
                            oc_Newobject00020["backgroundColor"] = "255 255 255 255";
                            oc_Newobject00020["controlFontSize"] = "14";
                            oc_Newobject00020["visible"] = "1";
                            oc_Newobject00020["active"] = "1";
                            oc_Newobject00020["tooltipProfile"] = "GuiToolTipProfile";
                            oc_Newobject00020["hovertime"] = "1000";
                            oc_Newobject00020["isContainer"] = "1";
                            oc_Newobject00020["alphaValue"] = "1";
                            oc_Newobject00020["mouseOverAlphaValue"] = "1";
                            oc_Newobject00020["alphaFadeTime"] = "1000";
                            oc_Newobject00020["moveControl"] = "1";
                            oc_Newobject00020["lockControl"] = "0";
                            oc_Newobject00020["windowSettings"] = "1";
                            oc_Newobject00020["alpha"] = "1";
                            oc_Newobject00020["mouseOverAlpha"] = "1";
                            oc_Newobject00020["alphaFade"] = "1";
                            oc_Newobject00020["contextFontColor"] = "0";
                            oc_Newobject00020["contextBackColor"] = "0";
                            oc_Newobject00020["contextFillColor"] = "0";
                            oc_Newobject00020["contextFontSize"] = "0";
                            oc_Newobject00020["editable"] = "0";
                            oc_Newobject00020["canSave"] = "1";
                            oc_Newobject00020["canSaveDynamicFields"] = "0";
                            oc_Newobject00020["Enabled"] = "1";
                            if (true)
                            {

                                #region GuiBitmapCtrl ()        oc_Newobject00008
                                oc_Newobject00008 = new ObjectCreator("GuiBitmapCtrl", "");
                                oc_Newobject00008["wrap"] = "0";
                                oc_Newobject00008["setBitmap"] = "0";
                                oc_Newobject00008["position"] = "10 30";
                                oc_Newobject00008["extent"] = "399 302";
                                oc_Newobject00008["minExtent"] = "8 2";
                                oc_Newobject00008["maxExtent"] = "1920 1080";
                                oc_Newobject00008["horizSizing"] = "windowRelative";
                                oc_Newobject00008["vertSizing"] = "windowRelative";
                                oc_Newobject00008["profile"] = "GuiDefaultProfile";
                                oc_Newobject00008["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00008["controlFillColor"] = "0 0 0 0";
                                oc_Newobject00008["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00008["controlFontSize"] = "14";
                                oc_Newobject00008["visible"] = "1";
                                oc_Newobject00008["active"] = "1";
                                oc_Newobject00008["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00008["hovertime"] = "1000";
                                oc_Newobject00008["isContainer"] = "0";
                                oc_Newobject00008["alphaValue"] = "1";
                                oc_Newobject00008["mouseOverAlphaValue"] = "1";
                                oc_Newobject00008["alphaFadeTime"] = "1000";
                                oc_Newobject00008["moveControl"] = "0";
                                oc_Newobject00008["lockControl"] = "0";
                                oc_Newobject00008["windowSettings"] = "1";
                                oc_Newobject00008["alpha"] = "1";
                                oc_Newobject00008["mouseOverAlpha"] = "1";
                                oc_Newobject00008["alphaFade"] = "1";
                                oc_Newobject00008["contextFontColor"] = "0";
                                oc_Newobject00008["contextBackColor"] = "0";
                                oc_Newobject00008["contextFillColor"] = "0";
                                oc_Newobject00008["contextFontSize"] = "0";
                                oc_Newobject00008["internalName"] = "CurrentPreview";
                                oc_Newobject00008["editable"] = "0";
                                oc_Newobject00008["canSave"] = "1";
                                oc_Newobject00008["canSaveDynamicFields"] = "1";
                                oc_Newobject00008["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00008"] = oc_Newobject00008;

                                #region GuiTextCtrl ()        oc_Newobject00009
                                oc_Newobject00009 = new ObjectCreator("GuiTextCtrl", "");
                                oc_Newobject00009["maxLength"] = "255";
                                oc_Newobject00009["margin"] = "0 0 0 0";
                                oc_Newobject00009["padding"] = "0 0 0 0";
                                oc_Newobject00009["anchorTop"] = "1";
                                oc_Newobject00009["anchorBottom"] = "0";
                                oc_Newobject00009["anchorLeft"] = "1";
                                oc_Newobject00009["anchorRight"] = "0";
                                oc_Newobject00009["position"] = "419 30";
                                oc_Newobject00009["extent"] = "165 19";
                                oc_Newobject00009["minExtent"] = "8 8";
                                oc_Newobject00009["maxExtent"] = "1920 1080";
                                oc_Newobject00009["horizSizing"] = "windowRelative";
                                oc_Newobject00009["vertSizing"] = "windowRelative";
                                oc_Newobject00009["profile"] = "GuiMediumTextProfile";
                                oc_Newobject00009["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00009["controlFillColor"] = "0 0 0 0";
                                oc_Newobject00009["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00009["controlFontSize"] = "24";
                                oc_Newobject00009["visible"] = "1";
                                oc_Newobject00009["active"] = "1";
                                oc_Newobject00009["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00009["hovertime"] = "1000";
                                oc_Newobject00009["isContainer"] = "0";
                                oc_Newobject00009["alphaValue"] = "1";
                                oc_Newobject00009["mouseOverAlphaValue"] = "1";
                                oc_Newobject00009["alphaFadeTime"] = "1000";
                                oc_Newobject00009["moveControl"] = "0";
                                oc_Newobject00009["lockControl"] = "0";
                                oc_Newobject00009["windowSettings"] = "1";
                                oc_Newobject00009["alpha"] = "1";
                                oc_Newobject00009["mouseOverAlpha"] = "1";
                                oc_Newobject00009["alphaFade"] = "1";
                                oc_Newobject00009["contextFontColor"] = "0";
                                oc_Newobject00009["contextBackColor"] = "0";
                                oc_Newobject00009["contextFillColor"] = "0";
                                oc_Newobject00009["contextFontSize"] = "0";
                                oc_Newobject00009["internalName"] = "LevelName";
                                oc_Newobject00009["editable"] = "0";
                                oc_Newobject00009["canSave"] = "1";
                                oc_Newobject00009["canSaveDynamicFields"] = "0";
                                oc_Newobject00009["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00009"] = oc_Newobject00009;

                                #region GuiTextCtrl ()        oc_Newobject00010
                                oc_Newobject00010 = new ObjectCreator("GuiTextCtrl", "");
                                oc_Newobject00010["text"] = "Description:";
                                oc_Newobject00010["maxLength"] = "255";
                                oc_Newobject00010["margin"] = "0 0 0 0";
                                oc_Newobject00010["padding"] = "0 0 0 0";
                                oc_Newobject00010["anchorTop"] = "1";
                                oc_Newobject00010["anchorBottom"] = "0";
                                oc_Newobject00010["anchorLeft"] = "1";
                                oc_Newobject00010["anchorRight"] = "0";
                                oc_Newobject00010["position"] = "419 50";
                                oc_Newobject00010["extent"] = "72 19";
                                oc_Newobject00010["minExtent"] = "8 8";
                                oc_Newobject00010["maxExtent"] = "1920 1080";
                                oc_Newobject00010["horizSizing"] = "windowRelative";
                                oc_Newobject00010["vertSizing"] = "windowRelative";
                                oc_Newobject00010["profile"] = "GuiTextProfile";
                                oc_Newobject00010["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00010["controlFillColor"] = "0 0 0 0";
                                oc_Newobject00010["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00010["controlFontSize"] = "14";
                                oc_Newobject00010["visible"] = "1";
                                oc_Newobject00010["active"] = "1";
                                oc_Newobject00010["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00010["hovertime"] = "1000";
                                oc_Newobject00010["isContainer"] = "0";
                                oc_Newobject00010["alphaValue"] = "1";
                                oc_Newobject00010["mouseOverAlphaValue"] = "1";
                                oc_Newobject00010["alphaFadeTime"] = "1000";
                                oc_Newobject00010["moveControl"] = "0";
                                oc_Newobject00010["lockControl"] = "0";
                                oc_Newobject00010["windowSettings"] = "1";
                                oc_Newobject00010["alpha"] = "1";
                                oc_Newobject00010["mouseOverAlpha"] = "1";
                                oc_Newobject00010["alphaFade"] = "1";
                                oc_Newobject00010["contextFontColor"] = "0";
                                oc_Newobject00010["contextBackColor"] = "0";
                                oc_Newobject00010["contextFillColor"] = "0";
                                oc_Newobject00010["contextFontSize"] = "0";
                                oc_Newobject00010["editable"] = "0";
                                oc_Newobject00010["canSave"] = "1";
                                oc_Newobject00010["canSaveDynamicFields"] = "0";
                                oc_Newobject00010["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00010"] = oc_Newobject00010;

                                #region GuiMLTextCtrl ()        oc_Newobject00011
                                oc_Newobject00011 = new ObjectCreator("GuiMLTextCtrl", "");
                                oc_Newobject00011["lineSpacing"] = "2";
                                oc_Newobject00011["allowColorChars"] = "0";
                                oc_Newobject00011["maxChars"] = "-1";
                                oc_Newobject00011["useURLMouseCursor"] = "0";
                                oc_Newobject00011["position"] = "419 74";
                                oc_Newobject00011["extent"] = "165 14";
                                oc_Newobject00011["minExtent"] = "8 8";
                                oc_Newobject00011["maxExtent"] = "1920 1080";
                                oc_Newobject00011["horizSizing"] = "windowRelative";
                                oc_Newobject00011["vertSizing"] = "windowRelative";
                                oc_Newobject00011["profile"] = "GuiMLTextProfile";
                                oc_Newobject00011["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00011["controlFillColor"] = "0 0 0 0";
                                oc_Newobject00011["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00011["controlFontSize"] = "14";
                                oc_Newobject00011["visible"] = "1";
                                oc_Newobject00011["active"] = "1";
                                oc_Newobject00011["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00011["hovertime"] = "1000";
                                oc_Newobject00011["isContainer"] = "0";
                                oc_Newobject00011["alphaValue"] = "1";
                                oc_Newobject00011["mouseOverAlphaValue"] = "1";
                                oc_Newobject00011["alphaFadeTime"] = "1000";
                                oc_Newobject00011["windowSettings"] = "1";
                                oc_Newobject00011["alpha"] = "1";
                                oc_Newobject00011["mouseOverAlpha"] = "1";
                                oc_Newobject00011["alphaFade"] = "1";
                                oc_Newobject00011["contextFontColor"] = "0";
                                oc_Newobject00011["contextBackColor"] = "0";
                                oc_Newobject00011["contextFillColor"] = "0";
                                oc_Newobject00011["contextFontSize"] = "0";
                                oc_Newobject00011["internalName"] = "LevelDescription";
                                oc_Newobject00011["editable"] = "0";
                                oc_Newobject00011["canSave"] = "1";
                                oc_Newobject00011["canSaveDynamicFields"] = "0";
                                oc_Newobject00011["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00011"] = oc_Newobject00011;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00012
                                oc_Newobject00012 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                oc_Newobject00012["text"] = "Host";
                                oc_Newobject00012["groupNum"] = "-1";
                                oc_Newobject00012["buttonType"] = "ToggleButton";
                                oc_Newobject00012["useMouseEvents"] = "0";
                                oc_Newobject00012["position"] = "431 140";
                                oc_Newobject00012["extent"] = "45 22";
                                oc_Newobject00012["minExtent"] = "8 8";
                                oc_Newobject00012["maxExtent"] = "1920 1080";
                                oc_Newobject00012["horizSizing"] = "windowRelative";
                                oc_Newobject00012["vertSizing"] = "windowRelative";
                                oc_Newobject00012["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00012["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00012["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00012["controlFontSize"] = "14";
                                oc_Newobject00012["visible"] = "1";
                                oc_Newobject00012["active"] = "1";
                                oc_Newobject00012["variable"] = "pref::HostMultiPlayer";
                                oc_Newobject00012["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00012["hovertime"] = "1000";
                                oc_Newobject00012["isContainer"] = "0";
                                oc_Newobject00012["alphaValue"] = "1";
                                oc_Newobject00012["mouseOverAlphaValue"] = "1";
                                oc_Newobject00012["alphaFadeTime"] = "1000";
                                oc_Newobject00012["windowSettings"] = "1";
                                oc_Newobject00012["alpha"] = "1";
                                oc_Newobject00012["mouseOverAlpha"] = "1";
                                oc_Newobject00012["alphaFade"] = "1";
                                oc_Newobject00012["contextFontColor"] = "0";
                                oc_Newobject00012["contextBackColor"] = "0";
                                oc_Newobject00012["contextFontSize"] = "0";
                                oc_Newobject00012["editable"] = "0";
                                oc_Newobject00012["canSave"] = "1";
                                oc_Newobject00012["canSaveDynamicFields"] = "0";
                                oc_Newobject00012["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00012"] = oc_Newobject00012;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00013
                                oc_Newobject00013 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                oc_Newobject00013["text"] = "Open in World Editor";
                                oc_Newobject00013["groupNum"] = "10";
                                oc_Newobject00013["buttonType"] = "RadioButton";
                                oc_Newobject00013["useMouseEvents"] = "0";
                                oc_Newobject00013["position"] = "431 166";
                                oc_Newobject00013["extent"] = "119 22";
                                oc_Newobject00013["minExtent"] = "8 8";
                                oc_Newobject00013["maxExtent"] = "1920 1080";
                                oc_Newobject00013["horizSizing"] = "windowRelative";
                                oc_Newobject00013["vertSizing"] = "windowRelative";
                                oc_Newobject00013["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00013["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00013["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00013["controlFontSize"] = "14";
                                oc_Newobject00013["visible"] = "1";
                                oc_Newobject00013["active"] = "1";
                                oc_Newobject00013["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00013["hovertime"] = "1000";
                                oc_Newobject00013["isContainer"] = "0";
                                oc_Newobject00013["alphaValue"] = "1";
                                oc_Newobject00013["mouseOverAlphaValue"] = "1";
                                oc_Newobject00013["alphaFadeTime"] = "1000";
                                oc_Newobject00013["windowSettings"] = "1";
                                oc_Newobject00013["alpha"] = "1";
                                oc_Newobject00013["mouseOverAlpha"] = "1";
                                oc_Newobject00013["alphaFade"] = "1";
                                oc_Newobject00013["contextFontColor"] = "0";
                                oc_Newobject00013["contextBackColor"] = "0";
                                oc_Newobject00013["contextFontSize"] = "0";
                                oc_Newobject00013["editable"] = "0";
                                oc_Newobject00013["canSave"] = "1";
                                oc_Newobject00013["canSaveDynamicFields"] = "0";
                                oc_Newobject00013["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00013"] = oc_Newobject00013;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00014
                                oc_Newobject00014 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                oc_Newobject00014["text"] = "Play";
                                oc_Newobject00014["internalName"] = "PlayButton";
                                oc_Newobject00014["groupNum"] = "10";
                                oc_Newobject00014["buttonType"] = "RadioButton";
                                oc_Newobject00014["useMouseEvents"] = "0";
                                oc_Newobject00014["position"] = "431 192";
                                oc_Newobject00014["extent"] = "119 22";
                                oc_Newobject00014["minExtent"] = "8 8";
                                oc_Newobject00014["maxExtent"] = "1920 1080";
                                oc_Newobject00014["horizSizing"] = "windowRelative";
                                oc_Newobject00014["vertSizing"] = "windowRelative";
                                oc_Newobject00014["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00014["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00014["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00014["controlFontSize"] = "14";
                                oc_Newobject00014["visible"] = "1";
                                oc_Newobject00014["active"] = "1";
                                oc_Newobject00014["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00014["hovertime"] = "1000";
                                oc_Newobject00014["isContainer"] = "0";
                                oc_Newobject00014["alphaValue"] = "1";
                                oc_Newobject00014["mouseOverAlphaValue"] = "1";
                                oc_Newobject00014["alphaFadeTime"] = "1000";
                                oc_Newobject00014["windowSettings"] = "1";
                                oc_Newobject00014["alpha"] = "1";
                                oc_Newobject00014["mouseOverAlpha"] = "1";
                                oc_Newobject00014["alphaFade"] = "1";
                                oc_Newobject00014["contextFontColor"] = "0";
                                oc_Newobject00014["contextBackColor"] = "0";
                                oc_Newobject00014["contextFontSize"] = "0";
                                oc_Newobject00014["editable"] = "0";
                                oc_Newobject00014["canSave"] = "1";
                                oc_Newobject00014["canSaveDynamicFields"] = "0";
                                oc_Newobject00014["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00014"] = oc_Newobject00014;

                                #region GuiButtonCtrl (ChooseLevelDlgGoBtn)        oc_Newobject00015
                                oc_Newobject00015 = new ObjectCreator("GuiButtonCtrl", "ChooseLevelDlgGoBtn", typeof(chooseLevelDlgGoBtn));
                                oc_Newobject00015["text"] = "Go!";
                                oc_Newobject00015["groupNum"] = "-1";
                                oc_Newobject00015["buttonType"] = "PushButton";
                                oc_Newobject00015["useMouseEvents"] = "1";
                                oc_Newobject00015["position"] = "458 288";
                                oc_Newobject00015["extent"] = "142 56";
                                oc_Newobject00015["minExtent"] = "8 8";
                                oc_Newobject00015["maxExtent"] = "1920 1080";
                                oc_Newobject00015["horizSizing"] = "windowRelative";
                                oc_Newobject00015["vertSizing"] = "windowRelative";
                                oc_Newobject00015["profile"] = "GuiMenuButtonProfile";
                                oc_Newobject00015["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00015["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00015["controlFontSize"] = "18";
                                oc_Newobject00015["visible"] = "1";
                                oc_Newobject00015["active"] = "1";
                                oc_Newobject00015["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00015["hovertime"] = "1000";
                                oc_Newobject00015["isContainer"] = "0";
                                oc_Newobject00015["alphaValue"] = "1";
                                oc_Newobject00015["mouseOverAlphaValue"] = "1";
                                oc_Newobject00015["alphaFadeTime"] = "1000";
                                oc_Newobject00015["windowSettings"] = "1";
                                oc_Newobject00015["alpha"] = "1";
                                oc_Newobject00015["mouseOverAlpha"] = "1";
                                oc_Newobject00015["alphaFade"] = "1";
                                oc_Newobject00015["contextFontColor"] = "0";
                                oc_Newobject00015["contextBackColor"] = "0";
                                oc_Newobject00015["contextFontSize"] = "0";
                                oc_Newobject00015["editable"] = "0";
                                oc_Newobject00015["canSave"] = "1";
                                oc_Newobject00015["canSaveDynamicFields"] = "0";
                                oc_Newobject00015["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00015"] = oc_Newobject00015;

                                #region GuiBitmapButtonCtrl ()        oc_Newobject00016
                                oc_Newobject00016 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                                oc_Newobject00016["bitmap"] = "art/gui/previous-button";
                                oc_Newobject00016["bitmapMode"] = "Stretched";
                                oc_Newobject00016["autoFitExtents"] = "0";
                                oc_Newobject00016["useModifiers"] = "0";
                                oc_Newobject00016["useStates"] = "1";
                                oc_Newobject00016["groupNum"] = "-1";
                                oc_Newobject00016["buttonType"] = "PushButton";
                                oc_Newobject00016["useMouseEvents"] = "0";
                                oc_Newobject00016["position"] = "10 343";
                                oc_Newobject00016["extent"] = "11 81";
                                oc_Newobject00016["minExtent"] = "8 2";
                                oc_Newobject00016["maxExtent"] = "1920 1080";
                                oc_Newobject00016["horizSizing"] = "windowRelative";
                                oc_Newobject00016["vertSizing"] = "windowRelative";
                                oc_Newobject00016["profile"] = "GuiDefaultProfile";
                                oc_Newobject00016["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00016["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00016["controlFontSize"] = "14";
                                oc_Newobject00016["visible"] = "1";
                                oc_Newobject00016["active"] = "1";
                                oc_Newobject00016["command"] = "ChooseLevelWindow.previousPreviews();";
                                oc_Newobject00016["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00016["hovertime"] = "1000";
                                oc_Newobject00016["isContainer"] = "0";
                                oc_Newobject00016["alphaValue"] = "1";
                                oc_Newobject00016["mouseOverAlphaValue"] = "1";
                                oc_Newobject00016["alphaFadeTime"] = "1000";
                                oc_Newobject00016["windowSettings"] = "1";
                                oc_Newobject00016["alpha"] = "1";
                                oc_Newobject00016["mouseOverAlpha"] = "1";
                                oc_Newobject00016["alphaFade"] = "1";
                                oc_Newobject00016["contextFontColor"] = "0";
                                oc_Newobject00016["contextBackColor"] = "0";
                                oc_Newobject00016["contextFontSize"] = "0";
                                oc_Newobject00016["internalName"] = "PreviousSmallPreviews";
                                oc_Newobject00016["editable"] = "0";
                                oc_Newobject00016["canSave"] = "1";
                                oc_Newobject00016["canSaveDynamicFields"] = "1";
                                oc_Newobject00016["Enabled"] = "1";
                                oc_Newobject00016["wrap"] = "0";
                                #endregion

                                oc_Newobject00020["#Newobject00016"] = oc_Newobject00016;

                                #region GuiDynamicCtrlArrayControl ()        oc_Newobject00017
                                oc_Newobject00017 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
                                oc_Newobject00017["colCount"] = "3";
                                oc_Newobject00017["internalName"] = "SmallPreviews";
                                oc_Newobject00017["position"] = "24 343";
                                oc_Newobject00017["extent"] = "600 81";
                                oc_Newobject00017["rowCount"] = "1";
                                oc_Newobject00017["colSpacing"] = "3";
                                oc_Newobject00017["autoCellSize"] = "1";
                                oc_Newobject00017["fillFirstRow"] = "0";
                                #endregion

                                oc_Newobject00020["#Newobject00017"] = oc_Newobject00017;

                                #region GuiBitmapButtonCtrl ()        oc_Newobject00018
                                oc_Newobject00018 = new ObjectCreator("GuiBitmapButtonCtrl", "");
                                oc_Newobject00018["bitmap"] = "art/gui/next-button";
                                oc_Newobject00018["bitmapMode"] = "Stretched";
                                oc_Newobject00018["autoFitExtents"] = "0";
                                oc_Newobject00018["useModifiers"] = "0";
                                oc_Newobject00018["useStates"] = "1";
                                oc_Newobject00018["groupNum"] = "-1";
                                oc_Newobject00018["buttonType"] = "PushButton";
                                oc_Newobject00018["useMouseEvents"] = "0";
                                oc_Newobject00018["position"] = "579 343";
                                oc_Newobject00018["extent"] = "11 81";
                                oc_Newobject00018["minExtent"] = "8 2";
                                oc_Newobject00018["maxExtent"] = "1920 1080";
                                oc_Newobject00018["horizSizing"] = "right";
                                oc_Newobject00018["vertSizing"] = "bottom";
                                oc_Newobject00018["profile"] = "GuiDefaultProfile";
                                oc_Newobject00018["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00018["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00018["controlFontSize"] = "14";
                                oc_Newobject00018["visible"] = "1";
                                oc_Newobject00018["active"] = "1";
                                oc_Newobject00018["command"] = "ChooseLevelWindow.nextPreviews();";
                                oc_Newobject00018["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00018["hovertime"] = "1000";
                                oc_Newobject00018["isContainer"] = "0";
                                oc_Newobject00018["alphaValue"] = "1";
                                oc_Newobject00018["mouseOverAlphaValue"] = "1";
                                oc_Newobject00018["alphaFadeTime"] = "1000";
                                oc_Newobject00018["windowSettings"] = "1";
                                oc_Newobject00018["alpha"] = "1";
                                oc_Newobject00018["mouseOverAlpha"] = "1";
                                oc_Newobject00018["alphaFade"] = "1";
                                oc_Newobject00018["contextFontColor"] = "0";
                                oc_Newobject00018["contextBackColor"] = "0";
                                oc_Newobject00018["contextFontSize"] = "0";
                                oc_Newobject00018["internalName"] = "NextSmallPreviews";
                                oc_Newobject00018["editable"] = "0";
                                oc_Newobject00018["canSave"] = "1";
                                oc_Newobject00018["canSaveDynamicFields"] = "1";
                                oc_Newobject00018["Enabled"] = "1";
                                oc_Newobject00018["wrap"] = "0";
                                #endregion

                                oc_Newobject00020["#Newobject00018"] = oc_Newobject00018;

                                #region GuiTextListCtrl (CL_levelList)        oc_Newobject00019
                                oc_Newobject00019 = new ObjectCreator("GuiTextListCtrl", "CL_levelList");
                                oc_Newobject00019["columns"] = "0";
                                oc_Newobject00019["fitParentWidth"] = "1";
                                oc_Newobject00019["clipColumnText"] = "0";
                                oc_Newobject00019["position"] = "1 1";
                                oc_Newobject00019["extent"] = "80 8";
                                oc_Newobject00019["minExtent"] = "8 8";
                                oc_Newobject00019["maxExtent"] = "1920 1080";
                                oc_Newobject00019["horizSizing"] = "right";
                                oc_Newobject00019["vertSizing"] = "bottom";
                                oc_Newobject00019["profile"] = "GuiTextArrayProfile";
                                oc_Newobject00019["controlFontColor"] = "0 0 0 0";
                                oc_Newobject00019["controlFillColor"] = "0 0 0 0";
                                oc_Newobject00019["backgroundColor"] = "255 255 255 255";
                                oc_Newobject00019["controlFontSize"] = "14";
                                oc_Newobject00019["visible"] = "0";
                                oc_Newobject00019["active"] = "1";
                                oc_Newobject00019["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00019["hovertime"] = "1000";
                                oc_Newobject00019["isContainer"] = "1";
                                oc_Newobject00019["alphaValue"] = "1";
                                oc_Newobject00019["mouseOverAlphaValue"] = "1";
                                oc_Newobject00019["alphaFadeTime"] = "1000";
                                oc_Newobject00019["moveControl"] = "0";
                                oc_Newobject00019["lockControl"] = "0";
                                oc_Newobject00019["windowSettings"] = "1";
                                oc_Newobject00019["alpha"] = "1";
                                oc_Newobject00019["mouseOverAlpha"] = "1";
                                oc_Newobject00019["alphaFade"] = "1";
                                oc_Newobject00019["contextFontColor"] = "0";
                                oc_Newobject00019["contextBackColor"] = "0";
                                oc_Newobject00019["contextFillColor"] = "0";
                                oc_Newobject00019["contextFontSize"] = "0";
                                oc_Newobject00019["hidden"] = "1";
                                oc_Newobject00019["editable"] = "0";
                                oc_Newobject00019["canSave"] = "1";
                                oc_Newobject00019["canSaveDynamicFields"] = "0";
                                oc_Newobject00019["Enabled"] = "1";
                                #endregion

                                oc_Newobject00020["#Newobject00019"] = oc_Newobject00019;

                            }
                            #endregion

                            oc_Newobject00021["#Newobject00020"] = oc_Newobject00020;

                        }
                        #endregion

                        oc_Newobject00022["#Newobject00021"] = oc_Newobject00021;

                    }
                    #endregion
                    oc_Newobject00022.Create();

                }
            }

        public override void onWake()
            {
                ((GuiCheckBoxCtrl)this.FOT("PlayButton")).setStateOn(true);
            if (Util.getWebDeployment() && this.FOT("ExitButton").isObject())
                {
                ((GuiButtonCtrl) this.FOT("ExitButton")).setVisible(false);
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(mainMenuGui ts, string simobjectid)
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
        public static bool operator !=(mainMenuGui ts, string simobjectid)
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
        public static implicit operator string(mainMenuGui ts)
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
        public static implicit operator mainMenuGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (mainMenuGui) Omni.self.getSimObject(simobjectid, typeof (mainMenuGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(mainMenuGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator mainMenuGui(int simobjectid)
            {
            return (mainMenuGui) Omni.self.getSimObject((uint) simobjectid, typeof (mainMenuGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(mainMenuGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator mainMenuGui(uint simobjectid)
            {
            return (mainMenuGui) Omni.self.getSimObject(simobjectid, typeof (mainMenuGui));
            }

        #endregion
        }
    }