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
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<WindowSettings>))]
    public class WindowSettings : GuiControl
    {
        internal GuiControl ctrl
        {
            get { return this["ctrl"]; }
            set { this["ctrl"] = value; }
        }

        [ConsoleInteraction(true, "WindowSettings_initialize")]
        public static void initialize()
        {
            #region GuiControl (windowSettings, IngameGuiGroup)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "WindowSettings, IngameGuiGroup", typeof (WindowSettings));
            oc_Newobject17["position"] = "0 0";
            oc_Newobject17["extent"] = "1024 768";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["maxExtent"] = "500 500";
            oc_Newobject17["horizSizing"] = "width";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["profile"] = "GuiDefaultProfile";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["hideControl"] = "0";
            oc_Newobject17["moveControl"] = "0";
            oc_Newobject17["lockControl"] = "0";
            oc_Newobject17["windowSettings"] = "1";
            oc_Newobject17["editable"] = "0";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "1";
            oc_Newobject17["hideControl"] = "0";
            oc_Newobject17["ctrl"] = "1714";
            oc_Newobject17["oldAlphaFadeTime"] = "500";
            oc_Newobject17["oldAlphaValue"] = "1";
            oc_Newobject17["oldMouseOverAlphaValue"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject16["text"] = "Window Settings";
            oc_Newobject16["resizeWidth"] = "0";
            oc_Newobject16["resizeHeight"] = "0";
            oc_Newobject16["canMove"] = "1";
            oc_Newobject16["canClose"] = "1";
            oc_Newobject16["canMinimize"] = "0";
            oc_Newobject16["canMaximize"] = "0";
            oc_Newobject16["canCollapse"] = "0";
            oc_Newobject16["closeCommand"] = "Canvas.popDialog(WindowSettings); WindowSettings.resetValue();";
            oc_Newobject16["edgeSnap"] = "1";
            oc_Newobject16["margin"] = "0 0 0 0";
            oc_Newobject16["padding"] = "0 0 0 0";
            oc_Newobject16["anchorTop"] = "1";
            oc_Newobject16["anchorBottom"] = "0";
            oc_Newobject16["anchorLeft"] = "1";
            oc_Newobject16["anchorRight"] = "0";
            oc_Newobject16["position"] = "387 321";
            oc_Newobject16["extent"] = "362 263";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["maxExtent"] = "500 500";
            oc_Newobject16["horizSizing"] = "center";
            oc_Newobject16["vertSizing"] = "center";
            oc_Newobject16["profile"] = "GuiWindowProfile";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["hideControl"] = "0";
            oc_Newobject16["moveControl"] = "1";
            oc_Newobject16["lockControl"] = "0";
            oc_Newobject16["windowSettings"] = "1";
            oc_Newobject16["editable"] = "0";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["hideControl"] = "0";

            #region GuiButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject1["text"] = "OK";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["position"] = "23 207";
            oc_Newobject1["extent"] = "140 30";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "500 500";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiButtonProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["command"] = "Canvas.popDialog(WindowSettings); GuiEditorTreeView.update();";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["hideControl"] = "0";
            oc_Newobject1["moveControl"] = "0";
            oc_Newobject1["lockControl"] = "0";
            oc_Newobject1["windowSettings"] = "1";
            oc_Newobject1["editable"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["hideControl"] = "0";

            #endregion

            oc_Newobject16["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject2["text"] = "Cancel";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["position"] = "191 207";
            oc_Newobject2["extent"] = "140 30";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "500 500";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiButtonProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["command"] = "Canvas.popDialog(WindowSettings); WindowSettings.resetValue();";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["hideControl"] = "0";
            oc_Newobject2["moveControl"] = "0";
            oc_Newobject2["lockControl"] = "0";
            oc_Newobject2["windowSettings"] = "1";
            oc_Newobject2["editable"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["hideControl"] = "0";

            #endregion

            oc_Newobject16["#Newobject2"] = oc_Newobject2;

            #region GuiControl (AlphaLevelControl)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "AlphaLevelControl");
            oc_Newobject7["position"] = "37 29";
            oc_Newobject7["extent"] = "160 96";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["maxExtent"] = "500 500";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiDefaultProfile";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["hideControl"] = "0";
            oc_Newobject7["moveControl"] = "0";
            oc_Newobject7["lockControl"] = "0";
            oc_Newobject7["windowSettings"] = "1";
            oc_Newobject7["editable"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["hideControl"] = "0";

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Normal Opacity";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["position"] = "13 22";
            oc_Newobject3["extent"] = "87 32";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["maxExtent"] = "500 500";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiTextProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["hideControl"] = "0";
            oc_Newobject3["moveControl"] = "1";
            oc_Newobject3["lockControl"] = "0";
            oc_Newobject3["windowSettings"] = "1";
            oc_Newobject3["internalName"] = "normalAlpha";
            oc_Newobject3["editable"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["hideControl"] = "0";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject6["position"] = "1 51";
            oc_Newobject6["extent"] = "144 64";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "500 500";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiDefaultProfile";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["hideControl"] = "0";
            oc_Newobject6["moveControl"] = "0";
            oc_Newobject6["lockControl"] = "0";
            oc_Newobject6["windowSettings"] = "1";
            //oc_Newobject6["class"] = "AggregateControl";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["hideControl"] = "0";

            #region GuiTextEditCtrl (AlphaLevelText)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "AlphaLevelText");
            oc_Newobject4["historySize"] = "2";
            oc_Newobject4["tabComplete"] = "0";
            oc_Newobject4["sinkAllKeyEvents"] = "0";
            oc_Newobject4["password"] = "0";
            oc_Newobject4["passwordMask"] = "*";
            oc_Newobject4["text"] = "1";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["position"] = "86 8";
            oc_Newobject4["extent"] = "58 18";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["maxExtent"] = "500 500";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiTextEditProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["command"] = "$ThisControl.getParent().updateFromChild($ThisControl); WindowSettings.setAlphaValueControl($ThisControl.getValue());";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["hideControl"] = "0";
            oc_Newobject4["moveControl"] = "0";
            oc_Newobject4["lockControl"] = "0";
            oc_Newobject4["windowSettings"] = "1";
            oc_Newobject4["internalName"] = "alphaTextValue";
            oc_Newobject4["editable"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["hideControl"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiSliderCtrl (AlphaLevelSlider)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiSliderCtrl", "AlphaLevelSlider");
            oc_Newobject5["range"] = "0 1";
            oc_Newobject5["ticks"] = "10";
            oc_Newobject5["snap"] = "0";
            oc_Newobject5["value"] = "1";
            oc_Newobject5["position"] = "4 8";
            oc_Newobject5["extent"] = "75 40";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "500 500";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiSliderProfile";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["command"] = "WindowSettings.setAlphaValueControl($ThisControl.getValue() );";
            oc_Newobject5["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); WindowSettings.setAlphaValueControl($ThisControl.getValue() );";
            oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["hideControl"] = "0";
            oc_Newobject5["moveControl"] = "0";
            oc_Newobject5["lockControl"] = "0";
            oc_Newobject5["windowSettings"] = "1";
            oc_Newobject5["internalName"] = "alphaSliderValue";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["hideControl"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject16["#Newobject7"] = oc_Newobject7;

            #region GuiControl (MouseOverAlphaControl)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "MouseOverAlphaControl");
            oc_Newobject12["position"] = "190 29";
            oc_Newobject12["extent"] = "160 96";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["maxExtent"] = "500 500";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["profile"] = "GuiDefaultProfile";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["hideControl"] = "0";
            oc_Newobject12["moveControl"] = "0";
            oc_Newobject12["lockControl"] = "0";
            oc_Newobject12["windowSettings"] = "1";
            oc_Newobject12["editable"] = "0";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["hideControl"] = "0";

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["text"] = "Mouse Over Opacity";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["position"] = "13 22";
            oc_Newobject8["extent"] = "104 31";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["maxExtent"] = "500 500";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["profile"] = "GuiTextProfile";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["hideControl"] = "0";
            oc_Newobject8["moveControl"] = "0";
            oc_Newobject8["lockControl"] = "0";
            oc_Newobject8["windowSettings"] = "1";
            oc_Newobject8["internalName"] = "mouseOverAlpha";
            oc_Newobject8["editable"] = "0";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["hideControl"] = "0";

            #endregion

            oc_Newobject12["#Newobject8"] = oc_Newobject8;

            #region GuiControl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject11["position"] = "1 51";
            oc_Newobject11["extent"] = "144 64";
            oc_Newobject11["minExtent"] = "8 2";
            oc_Newobject11["maxExtent"] = "500 500";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["profile"] = "GuiDefaultProfile";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["hideControl"] = "0";
            oc_Newobject11["moveControl"] = "0";
            oc_Newobject11["lockControl"] = "0";
            oc_Newobject11["windowSettings"] = "1";
            //oc_Newobject11["class"] = "AggregateControl";
            oc_Newobject11["editable"] = "0";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["hideControl"] = "0";

            #region GuiTextEditCtrl (MouseOverAlphaLevelText)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "MouseOverAlphaLevelText");
            oc_Newobject9["historySize"] = "2";
            oc_Newobject9["tabComplete"] = "0";
            oc_Newobject9["sinkAllKeyEvents"] = "0";
            oc_Newobject9["password"] = "0";
            oc_Newobject9["passwordMask"] = "*";
            oc_Newobject9["text"] = "0";
            oc_Newobject9["maxLength"] = "1024";
            oc_Newobject9["margin"] = "0 0 0 0";
            oc_Newobject9["padding"] = "0 0 0 0";
            oc_Newobject9["anchorTop"] = "1";
            oc_Newobject9["anchorBottom"] = "0";
            oc_Newobject9["anchorLeft"] = "1";
            oc_Newobject9["anchorRight"] = "0";
            oc_Newobject9["position"] = "86 8";
            oc_Newobject9["extent"] = "58 18";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["maxExtent"] = "500 500";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["profile"] = "GuiTextEditProfile";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["hideControl"] = "0";
            oc_Newobject9["moveControl"] = "0";
            oc_Newobject9["lockControl"] = "0";
            oc_Newobject9["windowSettings"] = "1";
            oc_Newobject9["internalName"] = "mouseOverAlphaTextValue";
            oc_Newobject9["editable"] = "0";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["hideControl"] = "0";

            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiSliderCtrl (MouseOverAlphaLevelSlider)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiSliderCtrl", "MouseOverAlphaLevelSlider");
            oc_Newobject10["range"] = "0 1";
            oc_Newobject10["ticks"] = "10";
            oc_Newobject10["snap"] = "0";
            oc_Newobject10["value"] = "0";
            oc_Newobject10["position"] = "4 8";
            oc_Newobject10["extent"] = "75 40";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["maxExtent"] = "500 500";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["profile"] = "GuiSliderProfile";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["command"] = "WindowSettings.setMouseOverAlphaValueControl($ThisControl.getValue() );";
            oc_Newobject10["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); WindowSettings.setMouseOverAlphaValueControl($ThisControl.getValue() );";
            oc_Newobject10["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["hideControl"] = "0";
            oc_Newobject10["moveControl"] = "0";
            oc_Newobject10["lockControl"] = "0";
            oc_Newobject10["windowSettings"] = "1";
            oc_Newobject10["internalName"] = "mouseOverAlphaSliderValue";
            oc_Newobject10["editable"] = "0";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["hideControl"] = "0";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject16["#Newobject12"] = oc_Newobject12;

            #region GuiControl (AlphaFadeControl)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiControl", "AlphaFadeControl");
            oc_Newobject15["position"] = "80 150";
            oc_Newobject15["extent"] = "188 46";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["maxExtent"] = "500 500";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["profile"] = "GuiDefaultProfile";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["hideControl"] = "0";
            oc_Newobject15["moveControl"] = "0";
            oc_Newobject15["lockControl"] = "0";
            oc_Newobject15["windowSettings"] = "1";
            oc_Newobject15["editable"] = "0";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["hideControl"] = "0";

            #region GuiTextEditCtrl (AlphaFadeTimeText)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "AlphaFadeTimeText");
            oc_Newobject13["historySize"] = "2";
            oc_Newobject13["tabComplete"] = "0";
            oc_Newobject13["sinkAllKeyEvents"] = "0";
            oc_Newobject13["password"] = "0";
            oc_Newobject13["passwordMask"] = "*";
            oc_Newobject13["text"] = "500";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["margin"] = "0 0 0 0";
            oc_Newobject13["padding"] = "0 0 0 0";
            oc_Newobject13["anchorTop"] = "1";
            oc_Newobject13["anchorBottom"] = "0";
            oc_Newobject13["anchorLeft"] = "1";
            oc_Newobject13["anchorRight"] = "0";
            oc_Newobject13["position"] = "130 10";
            oc_Newobject13["extent"] = "58 18";
            oc_Newobject13["minExtent"] = "8 2";
            oc_Newobject13["maxExtent"] = "500 500";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["profile"] = "GuiTextEditProfile";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["command"] = "WindowSettings.setAlphaFadeTimeControl($ThisControl.getValue() );";
            oc_Newobject13["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["hideControl"] = "0";
            oc_Newobject13["moveControl"] = "0";
            oc_Newobject13["lockControl"] = "0";
            oc_Newobject13["windowSettings"] = "1";
            oc_Newobject13["internalName"] = "alphaFadeText";
            oc_Newobject13["editable"] = "0";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["hideControl"] = "0";

            #endregion

            oc_Newobject15["#Newobject13"] = oc_Newobject13;

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["text"] = "Alpha Fade Time (in ms)";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["margin"] = "0 0 0 0";
            oc_Newobject14["padding"] = "0 0 0 0";
            oc_Newobject14["anchorTop"] = "1";
            oc_Newobject14["anchorBottom"] = "0";
            oc_Newobject14["anchorLeft"] = "1";
            oc_Newobject14["anchorRight"] = "0";
            oc_Newobject14["position"] = "0 10";
            oc_Newobject14["extent"] = "115 18";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["maxExtent"] = "500 500";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["profile"] = "GuiTextProfile";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["hideControl"] = "0";
            oc_Newobject14["moveControl"] = "0";
            oc_Newobject14["lockControl"] = "0";
            oc_Newobject14["windowSettings"] = "1";
            oc_Newobject14["internalName"] = "alphaFade";
            oc_Newobject14["editable"] = "0";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["hideControl"] = "0";

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject17.Create();
        }

        [ConsoleInteraction]
        public void loadDialog(GuiControl ctrl)
        {
            GuiCanvas Canvas = "Canvas";
            GuiSliderCtrl AlphaLevelSlider = "AlphaLevelSlider";
            GuiSliderCtrl MouseOverAlphaLevelSlider = "MouseOverAlphaLevelSlider";
            GuiTextEditCtrl AlphaLevelText = "AlphaLevelText";
            GuiTextEditCtrl MouseOverAlphaLevelText = "MouseOverAlphaLevelText";
            GuiTextEditCtrl AlphaFadeTimeText = "AlphaFadeTimeText";

            this["ctrl"] = ctrl;
            this.checkAllowedDialogs();
            Canvas.pushDialog(this);

            if (this.ctrl["alpha"].AsBool())
                {
                this["oldAlphaValue"] = ctrl.getAlphaValue().AsString();
                AlphaLevelSlider["value"] = this["oldAlphaValue"];
                AlphaLevelText["text"] = this["oldAlphaValue"];
                }
            if (this.ctrl.mouseOverAlpha)
                {
                this["oldMouseOverAlphaValue"] = ctrl.getMouseOverAlphaValue().AsString();
                MouseOverAlphaLevelSlider["value"] = this["oldMouseOverAlphaValue"];
                MouseOverAlphaLevelText["text"] = this["oldMouseOverAlphaValue"];
                }
            if (this.ctrl.alphaFade)
                {
                this["oldAlphaFadeTime"] = ctrl.getAlphaFadeTime().AsString();
                AlphaFadeTimeText["text"] = this["oldAlphaFadeTime"];
                }
        }

        [ConsoleInteraction]
        public void setAlphaValueControl(string value)
        {
            this.ctrl.setAlphaValue(value.AsFloat());
        }

        [ConsoleInteraction]
        public void resetValue()
        {
            if (this.ctrl["alpha"].AsBool())
                this.ctrl.setAlphaValue(this["oldAlphaValue"].AsFloat());
            if (this.ctrl["mouseOverAlpha"].AsBool())
                this.ctrl.setMouseOverAlphaValue(this["oldMouseOverAlphaValue"].AsFloat());
            if (this.ctrl["alphaFade"].AsBool())
                this.ctrl.setAlphaFadeTime(this["oldAlphaFadeTime"].AsInt());
        }

        [ConsoleInteraction]
        public void setMouseOverAlphaValueControl(string value)
        {
            this.ctrl.setMouseOverAlphaValue(value.AsFloat());
        }

        [ConsoleInteraction]
        public void setAlphaFadeTimeControl(string value)
        {
            this.ctrl.setAlphaFadeTime(value.AsInt());
        }

        [ConsoleInteraction]
        public void checkAllowedDialogs()
        {
            GuiControl AlphaLevelControl = "AlphaLevelControl";
            GuiControl MouseOverAlphaControl = "MouseOverAlphaControl";
            GuiControl AlphaFadeControl = "AlphaFadeControl";

            if (!this.ctrl["alpha"].AsBool())
                AlphaLevelControl["visible"] = "0";
            else
                AlphaLevelControl["visible"] = "1";

            if (!this.ctrl["mouseOverAlpha"].AsBool())
                MouseOverAlphaControl["visible"] = "0";
            else
                MouseOverAlphaControl["visible"] = "1";

            if (!this.ctrl["alphaFade"].AsBool())
                AlphaFadeControl["visible"] = "0";
            else
                AlphaFadeControl["visible"] = "1";
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WindowSettings ts, string simobjectid)
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
        public static bool operator !=(WindowSettings ts, string simobjectid)
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
        public static implicit operator string(WindowSettings ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator WindowSettings(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (WindowSettings) Omni.self.getSimObject(simobjectid, typeof (WindowSettings));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(WindowSettings ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WindowSettings(int simobjectid)
        {
            return (WindowSettings) Omni.self.getSimObject((uint) simobjectid, typeof (WindowSettings));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(WindowSettings ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WindowSettings(uint simobjectid)
        {
            return (WindowSettings) Omni.self.getSimObject(simobjectid, typeof (WindowSettings));
        }

        #endregion
    }
}