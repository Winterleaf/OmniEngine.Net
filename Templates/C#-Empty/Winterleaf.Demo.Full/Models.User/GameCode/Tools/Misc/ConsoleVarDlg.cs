// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Misc
{
    [TypeConverter(typeof (TypeConverterGeneric<ConsoleVarDlg>))]
    public class ConsoleVarDlg : GuiControl
    {
        public static void initialize()
        {
            #region GuiControl (ConsoleVarDlg)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "ConsoleVarDlg", typeof (ConsoleVarDlg));
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "GuiModelessDialogProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["Extent"] = "1024 768";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "1";
            oc_Newobject7["noCursor"] = new Creator.StringNoQuote("true");

            #region GuiWindowCtrl (ConsoleVarDlgWindow)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiWindowCtrl", "ConsoleVarDlgWindow", typeof (ConsoleVarDlgWindow));
            oc_Newobject6["text"] = "Console Variables";
            oc_Newobject6["resizeWidth"] = "1";
            oc_Newobject6["resizeHeight"] = "1";
            oc_Newobject6["canMove"] = "1";
            oc_Newobject6["canClose"] = "1";
            oc_Newobject6["canMinimize"] = "1";
            oc_Newobject6["canMaximize"] = "1";
            oc_Newobject6["canCollapse"] = "0";
            oc_Newobject6["closeCommand"] = "Canvas.popDialog( ConsoleVarDlg );";
            oc_Newobject6["edgeSnap"] = "1";
            oc_Newobject6["setTitle"] = "0";
            oc_Newobject6["ShowTitle"] = "1";
            oc_Newobject6["AllowPopWindow"] = "1";
            oc_Newobject6["isInPopup"] = "0";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["position"] = "131 153";
            oc_Newobject6["extent"] = "194 324";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "1920 1080";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiWindowProfile";
            oc_Newobject6["controlFontColor"] = "0 0 0 0";
            oc_Newobject6["controlFillColor"] = "0 0 0 0";
            oc_Newobject6["backgroundColor"] = "255 255 255 255";
            oc_Newobject6["controlFontSize"] = "14";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["alphaValue"] = "1";
            oc_Newobject6["mouseOverAlphaValue"] = "1";
            oc_Newobject6["alphaFadeTime"] = "1000";
            oc_Newobject6["moveControl"] = "1";
            oc_Newobject6["lockControl"] = "0";
            oc_Newobject6["windowSettings"] = "1";
            oc_Newobject6["alpha"] = "1";
            oc_Newobject6["mouseOverAlpha"] = "1";
            oc_Newobject6["alphaFade"] = "1";
            oc_Newobject6["contextFontColor"] = "0";
            oc_Newobject6["contextBackColor"] = "0";
            oc_Newobject6["contextFillColor"] = "0";
            oc_Newobject6["contextFontSize"] = "0";
            oc_Newobject6["internalName"] = "window";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Filter:";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["docking"] = "Top";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "1 21";
            oc_Newobject1["extent"] = "192 20";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "1920 1080";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiTextProfile";
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

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (txtFilter)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "txtFilter");
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "30 23";
            oc_Newobject2["extent"] = "139 18";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "1920 1080";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiTextEditProfile";
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

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (btnSearch)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "btnSearch", typeof (btnSearch));
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/toolbar/playbutton";
            oc_Newobject3["bitmapMode"] = "Stretched";
            oc_Newobject3["autoFitExtents"] = "0";
            oc_Newobject3["useModifiers"] = "0";
            oc_Newobject3["useStates"] = "1";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "1";
            oc_Newobject3["position"] = "175 23";
            oc_Newobject3["extent"] = "12 13";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["maxExtent"] = "1920 1080";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiDefaultProfile";
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

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiScrollCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject5["willFirstRespond"] = "1";
            oc_Newobject5["hScrollBar"] = "alwaysOff";
            oc_Newobject5["vScrollBar"] = "dynamic";
            oc_Newobject5["lockHorizScroll"] = "0";
            oc_Newobject5["lockVertScroll"] = "0";
            oc_Newobject5["constantThumbHeight"] = "0";
            oc_Newobject5["childMargin"] = "0 0";
            oc_Newobject5["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject5["docking"] = "Client";
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["position"] = "1 41";
            oc_Newobject5["extent"] = "192 280";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "1920 1080";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiScrollProfile";
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
            oc_Newobject5["windowSettings"] = "1";
            oc_Newobject5["alpha"] = "1";
            oc_Newobject5["mouseOverAlpha"] = "1";
            oc_Newobject5["alphaFade"] = "1";
            oc_Newobject5["contextFontColor"] = "0";
            oc_Newobject5["contextBackColor"] = "0";
            oc_Newobject5["contextFillColor"] = "0";
            oc_Newobject5["contextFontSize"] = "0";
            oc_Newobject5["internalName"] = "Scroll";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";

            #region GuiVariableInspector (ConsoleVarInspector)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiVariableInspector", "ConsoleVarInspector");
            oc_Newobject4["dividerMargin"] = "5";
            oc_Newobject4["showCustomFields"] = "1";
            oc_Newobject4["stackingType"] = "Vertical";
            oc_Newobject4["horizStacking"] = "Left to Right";
            oc_Newobject4["vertStacking"] = "Top to Bottom";
            oc_Newobject4["padding"] = "1";
            oc_Newobject4["dynamicSize"] = "1";
            oc_Newobject4["dynamicNonStackExtent"] = "0";
            oc_Newobject4["dynamicPos"] = "0";
            oc_Newobject4["changeChildSizeToFit"] = "1";
            oc_Newobject4["changeChildPosition"] = "1";
            oc_Newobject4["position"] = "1 1";
            oc_Newobject4["extent"] = "175 298";
            oc_Newobject4["minExtent"] = "16 16";
            oc_Newobject4["maxExtent"] = "1920 1080";
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiTransparentProfile";
            oc_Newobject4["controlFontColor"] = "0 0 0 0";
            oc_Newobject4["controlFillColor"] = "0 0 0 0";
            oc_Newobject4["backgroundColor"] = "255 255 255 255";
            oc_Newobject4["controlFontSize"] = "14";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
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

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject7.Create();
        }

        [ConsoleInteraction]
        public static void InspectVars(string filter = "*")
        {
            MenuHandlers.EditorHelpMenu DiagnosticMenu = "DiagnosticMenu";
            GuiTextEditCtrl txtFilter = "txtFilter";
            txtFilter.setText(filter);

            ConsoleVarDlg ConsoleVarDlg = "ConsoleVarDlg";

            if (!ConsoleVarDlg.isAwake())
                {
                ((GuiCanvas) "Canvas").pushDialog("ConsoleVarDlg", 100);
                DiagnosticMenu.checkItem(2, true);
                }
            else
                {
                if (((GuiWindowCtrl) "ConsoleVarDlgWindow").isInPopup)
                    ((GuiWindowCtrl) "ConsoleVarDlgWindow").ClosePopOut();
                ((GuiCanvas) "Canvas").popDialog("ConsoleVarDlg");
                DiagnosticMenu.checkItem(2, false);
                }

            GuiVariableInspector GuiVariableInspector = "ConsoleVarInspector";

            GuiVariableInspector.loadVars(filter);
        }

        [ConsoleInteraction]
        public static void InspectVarsToggleCursor()
        {
            ConsoleVarDlg ConsoleVarDlg = "ConsoleVarDlg";
            ConsoleVarDlg["noCursor"] = (!(ConsoleVarDlg["noCursor"].AsBool())).AsString();
        }

        [TypeConverter(typeof (TypeConverterGeneric<ConsoleVarDlgWindow>))]
        public class ConsoleVarDlgWindow : GuiWindowCtrl
        {
            public override void onClose()
            {
                MenuHandlers.EditorHelpMenu DiagnosticMenu = "DiagnosticMenu";
                DiagnosticMenu.checkItem(2, false);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ConsoleVarDlgWindow ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            public static bool operator !=(ConsoleVarDlgWindow ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(ConsoleVarDlgWindow ts)
            {
                if (ReferenceEquals(ts, null))
                    return "0";
                return ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ConsoleVarDlgWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ConsoleVarDlgWindow) Omni.self.getSimObject(simobjectid, typeof (ConsoleVarDlgWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ConsoleVarDlgWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ConsoleVarDlgWindow(int simobjectid)
            {
                return (ConsoleVarDlgWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleVarDlgWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ConsoleVarDlgWindow ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ConsoleVarDlgWindow(uint simobjectid)
            {
                return (ConsoleVarDlgWindow) Omni.self.getSimObject(simobjectid, typeof (ConsoleVarDlgWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<btnSearch>))]
        public class btnSearch : GuiBitmapButtonCtrl
        {
            public override void onClick(string SelectedidString)
            {
                GuiTextEditCtrl txtFilter = "txtFilter";
                string filter = txtFilter.getText().Trim();
                if (!filter.EndsWith("*"))
                    filter += "*";
                GuiVariableInspector GuiVariableInspector = "ConsoleVarInspector";
                GuiVariableInspector.loadVars(filter);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(btnSearch ts, string simobjectid)
            {
                return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            public static bool operator !=(btnSearch ts, string simobjectid)
            {
                if (ReferenceEquals(ts, null))
                    return !ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(btnSearch ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator btnSearch(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (btnSearch) Omni.self.getSimObject(simobjectid, typeof (btnSearch));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(btnSearch ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator btnSearch(int simobjectid)
            {
                return (btnSearch) Omni.self.getSimObject((uint) simobjectid, typeof (btnSearch));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(btnSearch ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator btnSearch(uint simobjectid)
            {
                return (btnSearch) Omni.self.getSimObject(simobjectid, typeof (btnSearch));
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
        public static bool operator ==(ConsoleVarDlg ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(ConsoleVarDlg ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(ConsoleVarDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConsoleVarDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ConsoleVarDlg) Omni.self.getSimObject(simobjectid, typeof (ConsoleVarDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConsoleVarDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConsoleVarDlg(int simobjectid)
        {
            return (ConsoleVarDlg) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleVarDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConsoleVarDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConsoleVarDlg(uint simobjectid)
        {
            return (ConsoleVarDlg) Omni.self.getSimObject(simobjectid, typeof (ConsoleVarDlg));
        }

        #endregion
    }
}