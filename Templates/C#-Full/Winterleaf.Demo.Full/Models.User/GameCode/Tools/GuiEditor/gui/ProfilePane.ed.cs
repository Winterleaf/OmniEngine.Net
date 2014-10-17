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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ProfilePane>))]
    public class ProfilePane : GuiWindowCtrl
    {
        private GuiControlProfile controlProfile
        {
            get { return this["controlProfile"]; }
            set { this["controlProfile"] = value; }
        }

        private string externalControl
        {
            get { return this["externalControl"]; }
            set { this["externalControl"] = value; }
        }

        private GuiControl mainGuiControl
        {
            get { return this["mainGuiControl"]; }
            set { this["mainGuiControl"] = value; }
        }

        public static void initialize()
        {
            #region GuiWindowCtrl (ProfilePane)        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiWindowCtrl", "ProfilePane", typeof (ProfilePane));
            oc_Newobject58["text"] = "Profile Pane";
            oc_Newobject58["resizeWidth"] = "1";
            oc_Newobject58["resizeHeight"] = "1";
            oc_Newobject58["canMove"] = "1";
            oc_Newobject58["canClose"] = "1";
            oc_Newobject58["canMinimize"] = "1";
            oc_Newobject58["canMaximize"] = "1";
            oc_Newobject58["canCollapse"] = "0";
            oc_Newobject58["edgeSnap"] = "1";
            oc_Newobject58["setTitle"] = "0";
            oc_Newobject58["ShowTitle"] = "1";
            oc_Newobject58["AllowPopWindow"] = "1";
            oc_Newobject58["isInPopup"] = "0";
            oc_Newobject58["margin"] = "0 0 0 0";
            oc_Newobject58["padding"] = "0 0 0 0";
            oc_Newobject58["anchorTop"] = "1";
            oc_Newobject58["anchorBottom"] = "0";
            oc_Newobject58["anchorLeft"] = "1";
            oc_Newobject58["anchorRight"] = "0";
            oc_Newobject58["position"] = "0 0";
            oc_Newobject58["extent"] = "1024 768";
            oc_Newobject58["minExtent"] = "8 2";
            oc_Newobject58["maxExtent"] = "1920 1080";
            oc_Newobject58["horizSizing"] = "right";
            oc_Newobject58["vertSizing"] = "bottom";
            oc_Newobject58["profile"] = "GuiWindowProfile";
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
            oc_Newobject58["moveControl"] = "1";
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

            #region GuiFrameSetCtrl ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiFrameSetCtrl", "");
            oc_Newobject57["columns"] = "0 762";
            oc_Newobject57["rows"] = "0";
            oc_Newobject57["borderWidth"] = "4";
            oc_Newobject57["borderColor"] = "205 205 205 205";
            oc_Newobject57["borderEnable"] = "dynamic";
            oc_Newobject57["borderMovable"] = "dynamic";
            oc_Newobject57["autoBalance"] = "1";
            oc_Newobject57["fudgeFactor"] = "0";
            oc_Newobject57["docking"] = "None";
            oc_Newobject57["margin"] = "0 0 0 0";
            oc_Newobject57["padding"] = "0 0 0 0";
            oc_Newobject57["anchorTop"] = "1";
            oc_Newobject57["anchorBottom"] = "0";
            oc_Newobject57["anchorLeft"] = "1";
            oc_Newobject57["anchorRight"] = "0";
            oc_Newobject57["position"] = "2 21";
            oc_Newobject57["extent"] = "1022 744";
            oc_Newobject57["minExtent"] = "8 2";
            oc_Newobject57["maxExtent"] = "1920 1080";
            oc_Newobject57["horizSizing"] = "relative";
            oc_Newobject57["vertSizing"] = "relative";
            oc_Newobject57["profile"] = "GuiFrameSetProfile";
            oc_Newobject57["controlFontColor"] = "0 0 0 0";
            oc_Newobject57["controlFillColor"] = "0 0 0 0";
            oc_Newobject57["backgroundColor"] = "255 255 255 255";
            oc_Newobject57["controlFontSize"] = "14";
            oc_Newobject57["visible"] = "1";
            oc_Newobject57["active"] = "1";
            oc_Newobject57["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject57["hovertime"] = "1000";
            oc_Newobject57["isContainer"] = "1";
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

            #region GuiContainer ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiContainer", "");
            oc_Newobject55["docking"] = "Left";
            oc_Newobject55["margin"] = "0 0 0 0";
            oc_Newobject55["padding"] = "0 0 0 0";
            oc_Newobject55["anchorTop"] = "1";
            oc_Newobject55["anchorBottom"] = "0";
            oc_Newobject55["anchorLeft"] = "1";
            oc_Newobject55["anchorRight"] = "0";
            oc_Newobject55["position"] = "0 0";
            oc_Newobject55["extent"] = "758 744";
            oc_Newobject55["minExtent"] = "8 2";
            oc_Newobject55["maxExtent"] = "1920 1080";
            oc_Newobject55["horizSizing"] = "width";
            oc_Newobject55["vertSizing"] = "height";
            oc_Newobject55["profile"] = "GuiDefaultProfile";
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
            oc_Newobject55["moveControl"] = "0";
            oc_Newobject55["lockControl"] = "0";
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

            #region GuiContainer ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiContainer", "");
            oc_Newobject9["margin"] = "0 0 0 0";
            oc_Newobject9["padding"] = "0 0 0 0";
            oc_Newobject9["anchorTop"] = "1";
            oc_Newobject9["anchorBottom"] = "1";
            oc_Newobject9["anchorLeft"] = "1";
            oc_Newobject9["anchorRight"] = "0";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["extent"] = "510 34";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["maxExtent"] = "1920 1080";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["profile"] = "GuiTextEditProfile";
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

            #region GuiBitmapButtonCtrl (profileNewBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "profileNewBtn");
            oc_Newobject1["bitmap"] = "tools/gui/images/new";
            oc_Newobject1["bitmapMode"] = "Stretched";
            oc_Newobject1["autoFitExtents"] = "0";
            oc_Newobject1["useModifiers"] = "0";
            oc_Newobject1["useStates"] = "1";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["position"] = "5 5";
            oc_Newobject1["extent"] = "25 25";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "1920 1080";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiDefaultProfile";
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
            oc_Newobject1["Command"] = "GuiEditor.createNewProfile( \\\"Unnamed\\\" );";
            oc_Newobject1["ToolTip"] = "Create New Profile with Default Values";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (profileSaveBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "profileSaveBtn");
            oc_Newobject2["bitmap"] = "tools/gui/images/save-icon";
            oc_Newobject2["bitmapMode"] = "Stretched";
            oc_Newobject2["autoFitExtents"] = "0";
            oc_Newobject2["useModifiers"] = "0";
            oc_Newobject2["useStates"] = "1";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["position"] = "40 5";
            oc_Newobject2["extent"] = "25 25";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "1920 1080";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiDefaultProfile";
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
            oc_Newobject2["Command"] = "GuiEditor.saveProfile( GuiEditorProfilesTree.getSelectedProfile(), GuiEditorProfileFileName.getText() );";
            oc_Newobject2["ToolTip"] = "Save the currently selected profile.";
            oc_Newobject2["Enabled"] = "1";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (profileSaveAsBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "profileSaveAsBtn");
            oc_Newobject3["bitmap"] = "tools/gui/images/save-as";
            oc_Newobject3["bitmapMode"] = "Stretched";
            oc_Newobject3["autoFitExtents"] = "0";
            oc_Newobject3["useModifiers"] = "0";
            oc_Newobject3["useStates"] = "1";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["position"] = "75 5";
            oc_Newobject3["extent"] = "25 25";
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
            oc_Newobject3["Command"] = "GuiEditor.showSaveProfileDialog( GuiEditorProfileFileName.getText() );";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["ToolTip"] = "Save the currently selected profile to a different file.";
            oc_Newobject3["Enabled"] = "1";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (profileCopyBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "profileCopyBtn");
            oc_Newobject4["bitmap"] = "tools/gui/images/copy-btn";
            oc_Newobject4["bitmapMode"] = "Stretched";
            oc_Newobject4["autoFitExtents"] = "0";
            oc_Newobject4["useModifiers"] = "0";
            oc_Newobject4["useStates"] = "1";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["position"] = "110 5";
            oc_Newobject4["extent"] = "25 25";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["maxExtent"] = "1920 1080";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiDefaultProfile";
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
            oc_Newobject4["Command"] = "GuiEditor.createNewProfile( GuiEditorProfilesTree.getSelectedProfile().getName(), GuiEditorProfilesTree.getSelectedProfile() );";
            oc_Newobject4["ToolTip"] = "Create New Profile by Copying the Selected Profile";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (profileUndoBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "profileUndoBtn");
            oc_Newobject5["bitmap"] = "tools/gui/images/reset-icon";
            oc_Newobject5["bitmapMode"] = "Stretched";
            oc_Newobject5["autoFitExtents"] = "0";
            oc_Newobject5["useModifiers"] = "0";
            oc_Newobject5["useStates"] = "1";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["position"] = "145 5";
            oc_Newobject5["extent"] = "25 25";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "1920 1080";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiDefaultProfile";
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
            oc_Newobject5["Command"] = "ProfilePane.getUndoManager().undo();";
            oc_Newobject5["ToolTip"] = "Undo Profile Changes";
            oc_Newobject5["Enabled"] = "1";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl (profileRedoBtn)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "profileRedoBtn");
            oc_Newobject6["bitmap"] = "tools/gui/images/redo-icon";
            oc_Newobject6["bitmapMode"] = "Stretched";
            oc_Newobject6["autoFitExtents"] = "0";
            oc_Newobject6["useModifiers"] = "0";
            oc_Newobject6["useStates"] = "1";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["position"] = "180 5";
            oc_Newobject6["extent"] = "25 25";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "1920 1080";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiDefaultProfile";
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
            oc_Newobject6["Command"] = "ProfilePane.getUndoManager().redo();";
            oc_Newobject6["ToolTip"] = "Redo Profile Changes";
            oc_Newobject6["Enabled"] = "1";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl (profileResetBtn)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "profileResetBtn");
            oc_Newobject7["bitmap"] = "tools/gui/images/clear-btn";
            oc_Newobject7["bitmapMode"] = "Stretched";
            oc_Newobject7["autoFitExtents"] = "0";
            oc_Newobject7["useModifiers"] = "0";
            oc_Newobject7["useStates"] = "1";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["position"] = "215 5";
            oc_Newobject7["extent"] = "25 25";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["maxExtent"] = "1920 1080";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiDefaultProfile";
            oc_Newobject7["controlFontColor"] = "0 0 0 0";
            oc_Newobject7["backgroundColor"] = "255 255 255 255";
            oc_Newobject7["controlFontSize"] = "14";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Revert Changes to the Selected Profile";
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
            oc_Newobject7["Command"] = "GuiEditor.revertProfile( GuiEditorProfilesTree.getSelectedProfile() );";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl (profileDeleteBtn)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "profileDeleteBtn");
            oc_Newobject8["bitmap"] = "tools/gui/images/delete";
            oc_Newobject8["bitmapMode"] = "Stretched";
            oc_Newobject8["autoFitExtents"] = "0";
            oc_Newobject8["useModifiers"] = "0";
            oc_Newobject8["useStates"] = "1";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["position"] = "250 5";
            oc_Newobject8["extent"] = "25 25";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["maxExtent"] = "1920 1080";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["profile"] = "GuiDefaultProfile";
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
            oc_Newobject8["Command"] = "GuiEditor.showDeleteProfileDialog( GuiEditorProfilesTree.getSelectedProfile() );";
            oc_Newobject8["ToolTip"] = "Delete Selected Profile";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #region GuiPopUpMenuCtrl (profileControlPopUp)        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiPopUpMenuCtrl", "profileControlPopUp", typeof (ProfilePopUp));
            oc_Newobject59["maxPopupHeight"] = "200";
            oc_Newobject59["sbUsesNAColor"] = "0";
            oc_Newobject59["reverseTextList"] = "0";
            oc_Newobject59["bitmapBounds"] = "16 16";
            oc_Newobject59["text"] = "Select a new Control";
            oc_Newobject59["maxLength"] = "1024";
            oc_Newobject59["margin"] = "0 0 0 0";
            oc_Newobject59["padding"] = "0 0 0 0";
            oc_Newobject59["anchorTop"] = "1";
            oc_Newobject59["anchorBottom"] = "0";
            oc_Newobject59["anchorLeft"] = "1";
            oc_Newobject59["anchorRight"] = "0";
            oc_Newobject59["position"] = "334 6";
            oc_Newobject59["extent"] = "165 22";
            oc_Newobject59["minExtent"] = "8 2";
            oc_Newobject59["maxExtent"] = "1920 1080";
            oc_Newobject59["horizSizing"] = "right";
            oc_Newobject59["vertSizing"] = "bottom";
            oc_Newobject59["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject59["controlFontColor"] = "0 0 0 0";
            oc_Newobject59["controlFillColor"] = "0 0 0 0";
            oc_Newobject59["backgroundColor"] = "255 255 255 255";
            oc_Newobject59["controlFontSize"] = "14";
            oc_Newobject59["visible"] = "1";
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
            oc_Newobject59["editable"] = "0";
            oc_Newobject59["canSave"] = "1";
            oc_Newobject59["canSaveDynamicFields"] = "0";
            oc_Newobject59["Enabled"] = "1";

            #endregion

            oc_Newobject9["#Newobject59"] = oc_Newobject59;

            #endregion

            oc_Newobject55["#Newobject9"] = oc_Newobject9;

            #region GuiContainer ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiContainer", "");
            oc_Newobject53["margin"] = "0 0 0 0";
            oc_Newobject53["padding"] = "0 0 0 0";
            oc_Newobject53["anchorTop"] = "1";
            oc_Newobject53["anchorBottom"] = "0";
            oc_Newobject53["anchorLeft"] = "1";
            oc_Newobject53["anchorRight"] = "0";
            oc_Newobject53["position"] = "5 90";
            oc_Newobject53["extent"] = "263 400";
            oc_Newobject53["minExtent"] = "8 2";
            oc_Newobject53["maxExtent"] = "1920 1080";
            oc_Newobject53["horizSizing"] = "right";
            oc_Newobject53["vertSizing"] = "bottom";
            oc_Newobject53["profile"] = "GuiTextEditProfile";
            oc_Newobject53["controlFontColor"] = "0 0 0 0";
            oc_Newobject53["controlFillColor"] = "0 0 0 0";
            oc_Newobject53["backgroundColor"] = "255 255 255 255";
            oc_Newobject53["controlFontSize"] = "14";
            oc_Newobject53["visible"] = "1";
            oc_Newobject53["active"] = "1";
            oc_Newobject53["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject53["hovertime"] = "1000";
            oc_Newobject53["isContainer"] = "1";
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

            #region GuiTabBookCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiTabBookCtrl", "");
            oc_Newobject52["tabPosition"] = "Right";
            oc_Newobject52["internalName"] = "profileTabBook";
            oc_Newobject52["tabMargin"] = "7";
            oc_Newobject52["minTabWidth"] = "64";
            oc_Newobject52["tabHeight"] = "24";
            oc_Newobject52["allowReorder"] = "0";
            oc_Newobject52["defaultPage"] = "-1";
            oc_Newobject52["selectedPage"] = "0";
            oc_Newobject52["frontTabPadding"] = "0";
            oc_Newobject52["margin"] = "0 0 0 0";
            oc_Newobject52["padding"] = "0 0 0 0";
            oc_Newobject52["anchorTop"] = "1";
            oc_Newobject52["anchorBottom"] = "0";
            oc_Newobject52["anchorLeft"] = "1";
            oc_Newobject52["anchorRight"] = "0";
            oc_Newobject52["position"] = "0 0";
            oc_Newobject52["extent"] = "263 400";
            oc_Newobject52["minExtent"] = "8 2";
            oc_Newobject52["maxExtent"] = "1920 1080";
            oc_Newobject52["horizSizing"] = "right";
            oc_Newobject52["vertSizing"] = "bottom";
            oc_Newobject52["profile"] = "GuiTabBookProfile";
            oc_Newobject52["controlFontColor"] = "0 0 0 0";
            oc_Newobject52["controlFillColor"] = "0 0 0 0";
            oc_Newobject52["backgroundColor"] = "255 255 255 255";
            oc_Newobject52["controlFontSize"] = "14";
            oc_Newobject52["visible"] = "1";
            oc_Newobject52["active"] = "1";
            oc_Newobject52["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["isContainer"] = "1";
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

            #region GuiTabPageCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject19["fitBook"] = "1";
            oc_Newobject19["text"] = "Fill";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["margin"] = "0 0 0 0";
            oc_Newobject19["padding"] = "0 0 0 0";
            oc_Newobject19["anchorTop"] = "1";
            oc_Newobject19["anchorBottom"] = "0";
            oc_Newobject19["anchorLeft"] = "1";
            oc_Newobject19["anchorRight"] = "0";
            oc_Newobject19["position"] = "0 0";
            oc_Newobject19["extent"] = "239 400";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["maxExtent"] = "1920 1080";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["profile"] = "GuiTabPageProfile";
            oc_Newobject19["controlFontColor"] = "0 0 0 0";
            oc_Newobject19["controlFillColor"] = "0 0 0 0";
            oc_Newobject19["backgroundColor"] = "255 255 255 255";
            oc_Newobject19["controlFontSize"] = "10";
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
            oc_Newobject19["internalName"] = "fillPage";
            oc_Newobject19["editable"] = "0";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";

            #region GuiContainer ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiContainer", "");
            oc_Newobject18["docking"] = "Client";
            oc_Newobject18["margin"] = "0 0 0 0";
            oc_Newobject18["padding"] = "0 0 0 0";
            oc_Newobject18["anchorTop"] = "1";
            oc_Newobject18["anchorBottom"] = "0";
            oc_Newobject18["anchorLeft"] = "1";
            oc_Newobject18["anchorRight"] = "0";
            oc_Newobject18["position"] = "0 0";
            oc_Newobject18["extent"] = "239 400";
            oc_Newobject18["minExtent"] = "8 2";
            oc_Newobject18["maxExtent"] = "1920 1080";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["profile"] = "GuiDefaultProfile";
            oc_Newobject18["controlFontColor"] = "0 0 0 0";
            oc_Newobject18["controlFillColor"] = "0 0 0 0";
            oc_Newobject18["backgroundColor"] = "255 255 255 255";
            oc_Newobject18["controlFontSize"] = "14";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["tooltipProfile"] = "GuiToolTipProfile";
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
            oc_Newobject18["editable"] = "0";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject11["bitmapMode"] = "Stretched";
            oc_Newobject11["autoFitExtents"] = "0";
            oc_Newobject11["useModifiers"] = "0";
            oc_Newobject11["useStates"] = "1";
            oc_Newobject11["text"] = "Fill Color";
            oc_Newobject11["groupNum"] = "1";
            oc_Newobject11["buttonType"] = "RadioButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["position"] = "45 29";
            oc_Newobject11["extent"] = "140 30";
            oc_Newobject11["minExtent"] = "8 2";
            oc_Newobject11["maxExtent"] = "1920 1080";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["profile"] = "GuiDefaultProfile";
            oc_Newobject11["controlFontColor"] = "0 0 0 0";
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

            #region GuiSwatchButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject10["color"] = "1 1 1 1";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "PushButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["position"] = "0 23";
            oc_Newobject10["extent"] = "140 7";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["maxExtent"] = "1920 1080";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject10["controlFontSize"] = "14";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "0";
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
            oc_Newobject10["contextFontSize"] = "0";
            oc_Newobject10["editable"] = "0";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject18["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject13["bitmapMode"] = "Stretched";
            oc_Newobject13["autoFitExtents"] = "0";
            oc_Newobject13["useModifiers"] = "0";
            oc_Newobject13["useStates"] = "1";
            oc_Newobject13["text"] = "Fill Color HL";
            oc_Newobject13["groupNum"] = "1";
            oc_Newobject13["buttonType"] = "RadioButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["position"] = "45 85";
            oc_Newobject13["extent"] = "140 30";
            oc_Newobject13["minExtent"] = "8 2";
            oc_Newobject13["maxExtent"] = "1920 1080";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["profile"] = "GuiDefaultProfile";
            oc_Newobject13["controlFontColor"] = "0 0 0 0";
            oc_Newobject13["backgroundColor"] = "255 255 255 255";
            oc_Newobject13["controlFontSize"] = "14";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "1";
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

            #region GuiSwatchButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject12["color"] = "1 1 1 1";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["useMouseEvents"] = "0";
            oc_Newobject12["position"] = "0 23";
            oc_Newobject12["extent"] = "140 7";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["maxExtent"] = "1920 1080";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject12["controlFontSize"] = "14";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "0";
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
            oc_Newobject12["contextFontSize"] = "0";
            oc_Newobject12["editable"] = "0";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject18["#Newobject13"] = oc_Newobject13;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject15["bitmapMode"] = "Stretched";
            oc_Newobject15["autoFitExtents"] = "0";
            oc_Newobject15["useModifiers"] = "0";
            oc_Newobject15["useStates"] = "1";
            oc_Newobject15["text"] = "Fill Color NA";
            oc_Newobject15["groupNum"] = "1";
            oc_Newobject15["buttonType"] = "RadioButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["position"] = "45 141";
            oc_Newobject15["extent"] = "140 30";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["maxExtent"] = "1920 1080";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["profile"] = "GuiDefaultProfile";
            oc_Newobject15["controlFontColor"] = "0 0 0 0";
            oc_Newobject15["backgroundColor"] = "255 255 255 255";
            oc_Newobject15["controlFontSize"] = "14";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["isContainer"] = "1";
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

            #region GuiSwatchButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject14["color"] = "1 1 1 1";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";
            oc_Newobject14["position"] = "0 23";
            oc_Newobject14["extent"] = "140 7";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["maxExtent"] = "1920 1080";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject14["controlFontSize"] = "14";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "0";
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
            oc_Newobject14["contextFontSize"] = "0";
            oc_Newobject14["editable"] = "0";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject18["#Newobject15"] = oc_Newobject15;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject17["bitmapMode"] = "Stretched";
            oc_Newobject17["autoFitExtents"] = "0";
            oc_Newobject17["useModifiers"] = "0";
            oc_Newobject17["useStates"] = "1";
            oc_Newobject17["text"] = "Fill Color SEL";
            oc_Newobject17["groupNum"] = "1";
            oc_Newobject17["buttonType"] = "RadioButton";
            oc_Newobject17["useMouseEvents"] = "0";
            oc_Newobject17["position"] = "45 195";
            oc_Newobject17["extent"] = "140 30";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["maxExtent"] = "1920 1080";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["profile"] = "GuiDefaultProfile";
            oc_Newobject17["controlFontColor"] = "0 0 0 0";
            oc_Newobject17["backgroundColor"] = "255 255 255 255";
            oc_Newobject17["controlFontSize"] = "14";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "1";
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

            #region GuiSwatchButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject16["color"] = "1 1 1 1";
            oc_Newobject16["groupNum"] = "-1";
            oc_Newobject16["buttonType"] = "PushButton";
            oc_Newobject16["useMouseEvents"] = "0";
            oc_Newobject16["position"] = "0 23";
            oc_Newobject16["extent"] = "140 7";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["maxExtent"] = "1920 1080";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject16["controlFontSize"] = "14";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "0";
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
            oc_Newobject16["contextFontSize"] = "0";
            oc_Newobject16["editable"] = "0";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject52["#Newobject19"] = oc_Newobject19;

            #region GuiTabPageCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject33["fitBook"] = "1";
            oc_Newobject33["text"] = "Font";
            oc_Newobject33["maxLength"] = "1024";
            oc_Newobject33["margin"] = "0 0 0 0";
            oc_Newobject33["padding"] = "0 0 0 0";
            oc_Newobject33["anchorTop"] = "1";
            oc_Newobject33["anchorBottom"] = "0";
            oc_Newobject33["anchorLeft"] = "1";
            oc_Newobject33["anchorRight"] = "0";
            oc_Newobject33["position"] = "0 0";
            oc_Newobject33["extent"] = "239 400";
            oc_Newobject33["minExtent"] = "8 2";
            oc_Newobject33["maxExtent"] = "1920 1080";
            oc_Newobject33["horizSizing"] = "right";
            oc_Newobject33["vertSizing"] = "bottom";
            oc_Newobject33["profile"] = "GuiTabPageProfile";
            oc_Newobject33["controlFontColor"] = "0 0 0 0";
            oc_Newobject33["controlFillColor"] = "0 0 0 0";
            oc_Newobject33["backgroundColor"] = "255 255 255 255";
            oc_Newobject33["controlFontSize"] = "10";
            oc_Newobject33["visible"] = "0";
            oc_Newobject33["active"] = "1";
            oc_Newobject33["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["isContainer"] = "1";
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
            oc_Newobject33["internalName"] = "fontPage";
            oc_Newobject33["hidden"] = "1";
            oc_Newobject33["editable"] = "0";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["Enabled"] = "1";

            #region GuiContainer ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiContainer", "");
            oc_Newobject32["docking"] = "Client";
            oc_Newobject32["margin"] = "0 0 0 0";
            oc_Newobject32["padding"] = "0 0 0 0";
            oc_Newobject32["anchorTop"] = "1";
            oc_Newobject32["anchorBottom"] = "0";
            oc_Newobject32["anchorLeft"] = "1";
            oc_Newobject32["anchorRight"] = "0";
            oc_Newobject32["position"] = "0 0";
            oc_Newobject32["extent"] = "239 400";
            oc_Newobject32["minExtent"] = "8 2";
            oc_Newobject32["maxExtent"] = "1920 1080";
            oc_Newobject32["horizSizing"] = "right";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["profile"] = "GuiDefaultProfile";
            oc_Newobject32["controlFontColor"] = "0 0 0 0";
            oc_Newobject32["controlFillColor"] = "0 0 0 0";
            oc_Newobject32["backgroundColor"] = "255 255 255 255";
            oc_Newobject32["controlFontSize"] = "14";
            oc_Newobject32["visible"] = "1";
            oc_Newobject32["active"] = "1";
            oc_Newobject32["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["isContainer"] = "1";
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

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject21["bitmapMode"] = "Stretched";
            oc_Newobject21["autoFitExtents"] = "0";
            oc_Newobject21["useModifiers"] = "0";
            oc_Newobject21["useStates"] = "1";
            oc_Newobject21["text"] = "Font Color";
            oc_Newobject21["groupNum"] = "2";
            oc_Newobject21["buttonType"] = "RadioButton";
            oc_Newobject21["useMouseEvents"] = "0";
            oc_Newobject21["position"] = "45 29";
            oc_Newobject21["extent"] = "140 30";
            oc_Newobject21["minExtent"] = "8 2";
            oc_Newobject21["maxExtent"] = "1920 1080";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["profile"] = "GuiDefaultProfile";
            oc_Newobject21["controlFontColor"] = "0 0 0 0";
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
            oc_Newobject21["windowSettings"] = "1";
            oc_Newobject21["alpha"] = "1";
            oc_Newobject21["mouseOverAlpha"] = "1";
            oc_Newobject21["alphaFade"] = "1";
            oc_Newobject21["contextFontColor"] = "0";
            oc_Newobject21["contextBackColor"] = "0";
            oc_Newobject21["contextFontSize"] = "0";
            oc_Newobject21["editable"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject20["color"] = "1 1 1 1";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "PushButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["position"] = "0 23";
            oc_Newobject20["extent"] = "140 7";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["maxExtent"] = "1920 1080";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject20["controlFontSize"] = "14";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["active"] = "0";
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
            oc_Newobject20["contextFontSize"] = "0";
            oc_Newobject20["editable"] = "0";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject32["#Newobject21"] = oc_Newobject21;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject23["bitmapMode"] = "Stretched";
            oc_Newobject23["autoFitExtents"] = "0";
            oc_Newobject23["useModifiers"] = "0";
            oc_Newobject23["useStates"] = "1";
            oc_Newobject23["text"] = "Font Color HL";
            oc_Newobject23["groupNum"] = "2";
            oc_Newobject23["buttonType"] = "RadioButton";
            oc_Newobject23["useMouseEvents"] = "0";
            oc_Newobject23["position"] = "45 85";
            oc_Newobject23["extent"] = "140 30";
            oc_Newobject23["minExtent"] = "8 2";
            oc_Newobject23["maxExtent"] = "1920 1080";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["profile"] = "GuiDefaultProfile";
            oc_Newobject23["controlFontColor"] = "0 0 0 0";
            oc_Newobject23["backgroundColor"] = "255 255 255 255";
            oc_Newobject23["controlFontSize"] = "14";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["active"] = "1";
            oc_Newobject23["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["alphaValue"] = "1";
            oc_Newobject23["mouseOverAlphaValue"] = "1";
            oc_Newobject23["alphaFadeTime"] = "1000";
            oc_Newobject23["windowSettings"] = "1";
            oc_Newobject23["alpha"] = "1";
            oc_Newobject23["mouseOverAlpha"] = "1";
            oc_Newobject23["alphaFade"] = "1";
            oc_Newobject23["contextFontColor"] = "0";
            oc_Newobject23["contextBackColor"] = "0";
            oc_Newobject23["contextFontSize"] = "0";
            oc_Newobject23["editable"] = "0";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject22["color"] = "1 1 1 1";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["buttonType"] = "PushButton";
            oc_Newobject22["useMouseEvents"] = "0";
            oc_Newobject22["position"] = "0 23";
            oc_Newobject22["extent"] = "140 7";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["maxExtent"] = "1920 1080";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject22["controlFontSize"] = "14";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "0";
            oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["alphaValue"] = "1";
            oc_Newobject22["mouseOverAlphaValue"] = "1";
            oc_Newobject22["alphaFadeTime"] = "1000";
            oc_Newobject22["windowSettings"] = "1";
            oc_Newobject22["alpha"] = "1";
            oc_Newobject22["mouseOverAlpha"] = "1";
            oc_Newobject22["alphaFade"] = "1";
            oc_Newobject22["contextFontSize"] = "0";
            oc_Newobject22["editable"] = "0";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject32["#Newobject23"] = oc_Newobject23;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject25["bitmapMode"] = "Stretched";
            oc_Newobject25["autoFitExtents"] = "0";
            oc_Newobject25["useModifiers"] = "0";
            oc_Newobject25["useStates"] = "1";
            oc_Newobject25["text"] = "Font Color NA";
            oc_Newobject25["groupNum"] = "2";
            oc_Newobject25["buttonType"] = "RadioButton";
            oc_Newobject25["useMouseEvents"] = "0";
            oc_Newobject25["position"] = "45 141";
            oc_Newobject25["extent"] = "140 30";
            oc_Newobject25["minExtent"] = "8 2";
            oc_Newobject25["maxExtent"] = "1920 1080";
            oc_Newobject25["horizSizing"] = "right";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["profile"] = "GuiDefaultProfile";
            oc_Newobject25["controlFontColor"] = "0 0 0 0";
            oc_Newobject25["backgroundColor"] = "255 255 255 255";
            oc_Newobject25["controlFontSize"] = "14";
            oc_Newobject25["visible"] = "1";
            oc_Newobject25["active"] = "1";
            oc_Newobject25["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["alphaValue"] = "1";
            oc_Newobject25["mouseOverAlphaValue"] = "1";
            oc_Newobject25["alphaFadeTime"] = "1000";
            oc_Newobject25["windowSettings"] = "1";
            oc_Newobject25["alpha"] = "1";
            oc_Newobject25["mouseOverAlpha"] = "1";
            oc_Newobject25["alphaFade"] = "1";
            oc_Newobject25["contextFontColor"] = "0";
            oc_Newobject25["contextBackColor"] = "0";
            oc_Newobject25["contextFontSize"] = "0";
            oc_Newobject25["editable"] = "0";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject24["color"] = "1 1 1 1";
            oc_Newobject24["groupNum"] = "-1";
            oc_Newobject24["buttonType"] = "PushButton";
            oc_Newobject24["useMouseEvents"] = "0";
            oc_Newobject24["position"] = "0 23";
            oc_Newobject24["extent"] = "140 7";
            oc_Newobject24["minExtent"] = "8 2";
            oc_Newobject24["maxExtent"] = "1920 1080";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject24["controlFontSize"] = "14";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["active"] = "0";
            oc_Newobject24["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["alphaValue"] = "1";
            oc_Newobject24["mouseOverAlphaValue"] = "1";
            oc_Newobject24["alphaFadeTime"] = "1000";
            oc_Newobject24["windowSettings"] = "1";
            oc_Newobject24["alpha"] = "1";
            oc_Newobject24["mouseOverAlpha"] = "1";
            oc_Newobject24["alphaFade"] = "1";
            oc_Newobject24["contextFontSize"] = "0";
            oc_Newobject24["editable"] = "0";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject32["#Newobject25"] = oc_Newobject25;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject27["bitmapMode"] = "Stretched";
            oc_Newobject27["autoFitExtents"] = "0";
            oc_Newobject27["useModifiers"] = "0";
            oc_Newobject27["useStates"] = "1";
            oc_Newobject27["text"] = "Font Color SEL";
            oc_Newobject27["groupNum"] = "2";
            oc_Newobject27["buttonType"] = "RadioButton";
            oc_Newobject27["useMouseEvents"] = "0";
            oc_Newobject27["position"] = "45 195";
            oc_Newobject27["extent"] = "140 30";
            oc_Newobject27["minExtent"] = "8 2";
            oc_Newobject27["maxExtent"] = "1920 1080";
            oc_Newobject27["horizSizing"] = "right";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["profile"] = "GuiDefaultProfile";
            oc_Newobject27["controlFontColor"] = "0 0 0 0";
            oc_Newobject27["backgroundColor"] = "255 255 255 255";
            oc_Newobject27["controlFontSize"] = "14";
            oc_Newobject27["visible"] = "1";
            oc_Newobject27["active"] = "1";
            oc_Newobject27["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["isContainer"] = "1";
            oc_Newobject27["alphaValue"] = "1";
            oc_Newobject27["mouseOverAlphaValue"] = "1";
            oc_Newobject27["alphaFadeTime"] = "1000";
            oc_Newobject27["windowSettings"] = "1";
            oc_Newobject27["alpha"] = "1";
            oc_Newobject27["mouseOverAlpha"] = "1";
            oc_Newobject27["alphaFade"] = "1";
            oc_Newobject27["contextFontColor"] = "0";
            oc_Newobject27["contextBackColor"] = "0";
            oc_Newobject27["contextFontSize"] = "0";
            oc_Newobject27["editable"] = "0";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject26["color"] = "1 1 1 1";
            oc_Newobject26["groupNum"] = "-1";
            oc_Newobject26["buttonType"] = "PushButton";
            oc_Newobject26["useMouseEvents"] = "0";
            oc_Newobject26["position"] = "0 23";
            oc_Newobject26["extent"] = "140 7";
            oc_Newobject26["minExtent"] = "8 2";
            oc_Newobject26["maxExtent"] = "1920 1080";
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject26["controlFontSize"] = "14";
            oc_Newobject26["visible"] = "1";
            oc_Newobject26["active"] = "0";
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
            oc_Newobject26["contextFontSize"] = "0";
            oc_Newobject26["editable"] = "0";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";

            #endregion

            oc_Newobject27["#Newobject26"] = oc_Newobject26;

            #endregion

            oc_Newobject32["#Newobject27"] = oc_Newobject27;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject29["bitmapMode"] = "Stretched";
            oc_Newobject29["autoFitExtents"] = "0";
            oc_Newobject29["useModifiers"] = "0";
            oc_Newobject29["useStates"] = "1";
            oc_Newobject29["text"] = "Font Color Link";
            oc_Newobject29["groupNum"] = "2";
            oc_Newobject29["buttonType"] = "RadioButton";
            oc_Newobject29["useMouseEvents"] = "0";
            oc_Newobject29["position"] = "47 248";
            oc_Newobject29["extent"] = "140 30";
            oc_Newobject29["minExtent"] = "8 2";
            oc_Newobject29["maxExtent"] = "1920 1080";
            oc_Newobject29["horizSizing"] = "right";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["profile"] = "GuiDefaultProfile";
            oc_Newobject29["controlFontColor"] = "0 0 0 0";
            oc_Newobject29["backgroundColor"] = "255 255 255 255";
            oc_Newobject29["controlFontSize"] = "14";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["active"] = "1";
            oc_Newobject29["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["isContainer"] = "1";
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
            oc_Newobject29["editable"] = "0";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject28["color"] = "1 1 1 1";
            oc_Newobject28["groupNum"] = "-1";
            oc_Newobject28["buttonType"] = "PushButton";
            oc_Newobject28["useMouseEvents"] = "0";
            oc_Newobject28["position"] = "0 23";
            oc_Newobject28["extent"] = "140 7";
            oc_Newobject28["minExtent"] = "8 2";
            oc_Newobject28["maxExtent"] = "1920 1080";
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject28["controlFontSize"] = "14";
            oc_Newobject28["visible"] = "1";
            oc_Newobject28["active"] = "0";
            oc_Newobject28["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["alphaValue"] = "1";
            oc_Newobject28["mouseOverAlphaValue"] = "1";
            oc_Newobject28["alphaFadeTime"] = "1000";
            oc_Newobject28["windowSettings"] = "1";
            oc_Newobject28["alpha"] = "1";
            oc_Newobject28["mouseOverAlpha"] = "1";
            oc_Newobject28["alphaFade"] = "1";
            oc_Newobject28["contextFontSize"] = "0";
            oc_Newobject28["editable"] = "0";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["Enabled"] = "1";

            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject32["#Newobject29"] = oc_Newobject29;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject31["bitmapMode"] = "Stretched";
            oc_Newobject31["autoFitExtents"] = "0";
            oc_Newobject31["useModifiers"] = "0";
            oc_Newobject31["useStates"] = "1";
            oc_Newobject31["text"] = "Font Color Link HL";
            oc_Newobject31["groupNum"] = "2";
            oc_Newobject31["buttonType"] = "RadioButton";
            oc_Newobject31["useMouseEvents"] = "0";
            oc_Newobject31["position"] = "47 300";
            oc_Newobject31["extent"] = "140 30";
            oc_Newobject31["minExtent"] = "8 2";
            oc_Newobject31["maxExtent"] = "1920 1080";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["profile"] = "GuiDefaultProfile";
            oc_Newobject31["controlFontColor"] = "0 0 0 0";
            oc_Newobject31["backgroundColor"] = "255 255 255 255";
            oc_Newobject31["controlFontSize"] = "14";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["active"] = "1";
            oc_Newobject31["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["isContainer"] = "1";
            oc_Newobject31["alphaValue"] = "1";
            oc_Newobject31["mouseOverAlphaValue"] = "1";
            oc_Newobject31["alphaFadeTime"] = "1000";
            oc_Newobject31["windowSettings"] = "1";
            oc_Newobject31["alpha"] = "1";
            oc_Newobject31["mouseOverAlpha"] = "1";
            oc_Newobject31["alphaFade"] = "1";
            oc_Newobject31["contextFontColor"] = "0";
            oc_Newobject31["contextBackColor"] = "0";
            oc_Newobject31["contextFontSize"] = "0";
            oc_Newobject31["editable"] = "0";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject30["color"] = "1 1 1 1";
            oc_Newobject30["groupNum"] = "-1";
            oc_Newobject30["buttonType"] = "PushButton";
            oc_Newobject30["useMouseEvents"] = "0";
            oc_Newobject30["position"] = "0 23";
            oc_Newobject30["extent"] = "140 7";
            oc_Newobject30["minExtent"] = "8 2";
            oc_Newobject30["maxExtent"] = "1920 1080";
            oc_Newobject30["horizSizing"] = "right";
            oc_Newobject30["vertSizing"] = "bottom";
            oc_Newobject30["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject30["controlFontSize"] = "14";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["active"] = "0";
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
            oc_Newobject30["contextFontSize"] = "0";
            oc_Newobject30["editable"] = "0";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["Enabled"] = "1";

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject32["#Newobject31"] = oc_Newobject31;

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject52["#Newobject33"] = oc_Newobject33;

            #region GuiTabPageCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject43["fitBook"] = "1";
            oc_Newobject43["text"] = "Bevel";
            oc_Newobject43["maxLength"] = "1024";
            oc_Newobject43["margin"] = "0 0 0 0";
            oc_Newobject43["padding"] = "0 0 0 0";
            oc_Newobject43["anchorTop"] = "1";
            oc_Newobject43["anchorBottom"] = "0";
            oc_Newobject43["anchorLeft"] = "1";
            oc_Newobject43["anchorRight"] = "0";
            oc_Newobject43["position"] = "0 0";
            oc_Newobject43["extent"] = "239 400";
            oc_Newobject43["minExtent"] = "8 2";
            oc_Newobject43["maxExtent"] = "1920 1080";
            oc_Newobject43["horizSizing"] = "right";
            oc_Newobject43["vertSizing"] = "bottom";
            oc_Newobject43["profile"] = "GuiTabPageProfile";
            oc_Newobject43["controlFontColor"] = "0 0 0 0";
            oc_Newobject43["controlFillColor"] = "0 0 0 0";
            oc_Newobject43["backgroundColor"] = "255 255 255 255";
            oc_Newobject43["controlFontSize"] = "10";
            oc_Newobject43["visible"] = "0";
            oc_Newobject43["active"] = "1";
            oc_Newobject43["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["isContainer"] = "1";
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
            oc_Newobject43["internalName"] = "bevelPage";
            oc_Newobject43["hidden"] = "1";
            oc_Newobject43["editable"] = "0";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["Enabled"] = "1";

            #region GuiContainer ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiContainer", "");
            oc_Newobject42["docking"] = "Client";
            oc_Newobject42["margin"] = "0 0 0 0";
            oc_Newobject42["padding"] = "0 0 0 0";
            oc_Newobject42["anchorTop"] = "1";
            oc_Newobject42["anchorBottom"] = "0";
            oc_Newobject42["anchorLeft"] = "1";
            oc_Newobject42["anchorRight"] = "0";
            oc_Newobject42["position"] = "0 0";
            oc_Newobject42["extent"] = "239 400";
            oc_Newobject42["minExtent"] = "8 2";
            oc_Newobject42["maxExtent"] = "1920 1080";
            oc_Newobject42["horizSizing"] = "right";
            oc_Newobject42["vertSizing"] = "bottom";
            oc_Newobject42["profile"] = "GuiDefaultProfile";
            oc_Newobject42["controlFontColor"] = "0 0 0 0";
            oc_Newobject42["controlFillColor"] = "0 0 0 0";
            oc_Newobject42["backgroundColor"] = "255 255 255 255";
            oc_Newobject42["controlFontSize"] = "14";
            oc_Newobject42["visible"] = "1";
            oc_Newobject42["active"] = "1";
            oc_Newobject42["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["isContainer"] = "1";
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

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject35["bitmapMode"] = "Stretched";
            oc_Newobject35["autoFitExtents"] = "0";
            oc_Newobject35["useModifiers"] = "0";
            oc_Newobject35["useStates"] = "1";
            oc_Newobject35["text"] = "Bevel Color";
            oc_Newobject35["groupNum"] = "3";
            oc_Newobject35["buttonType"] = "RadioButton";
            oc_Newobject35["useMouseEvents"] = "0";
            oc_Newobject35["position"] = "45 29";
            oc_Newobject35["extent"] = "140 30";
            oc_Newobject35["minExtent"] = "8 2";
            oc_Newobject35["maxExtent"] = "1920 1080";
            oc_Newobject35["horizSizing"] = "right";
            oc_Newobject35["vertSizing"] = "bottom";
            oc_Newobject35["profile"] = "GuiDefaultProfile";
            oc_Newobject35["controlFontColor"] = "0 0 0 0";
            oc_Newobject35["backgroundColor"] = "255 255 255 255";
            oc_Newobject35["controlFontSize"] = "14";
            oc_Newobject35["visible"] = "1";
            oc_Newobject35["active"] = "1";
            oc_Newobject35["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["isContainer"] = "1";
            oc_Newobject35["alphaValue"] = "1";
            oc_Newobject35["mouseOverAlphaValue"] = "1";
            oc_Newobject35["alphaFadeTime"] = "1000";
            oc_Newobject35["windowSettings"] = "1";
            oc_Newobject35["alpha"] = "1";
            oc_Newobject35["mouseOverAlpha"] = "1";
            oc_Newobject35["alphaFade"] = "1";
            oc_Newobject35["contextFontColor"] = "0";
            oc_Newobject35["contextBackColor"] = "0";
            oc_Newobject35["contextFontSize"] = "0";
            oc_Newobject35["editable"] = "0";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject34["color"] = "1 1 1 1";
            oc_Newobject34["groupNum"] = "-1";
            oc_Newobject34["buttonType"] = "PushButton";
            oc_Newobject34["useMouseEvents"] = "0";
            oc_Newobject34["position"] = "0 23";
            oc_Newobject34["extent"] = "140 7";
            oc_Newobject34["minExtent"] = "8 2";
            oc_Newobject34["maxExtent"] = "1920 1080";
            oc_Newobject34["horizSizing"] = "right";
            oc_Newobject34["vertSizing"] = "bottom";
            oc_Newobject34["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject34["controlFontSize"] = "14";
            oc_Newobject34["visible"] = "1";
            oc_Newobject34["active"] = "0";
            oc_Newobject34["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["alphaValue"] = "1";
            oc_Newobject34["mouseOverAlphaValue"] = "1";
            oc_Newobject34["alphaFadeTime"] = "1000";
            oc_Newobject34["windowSettings"] = "1";
            oc_Newobject34["alpha"] = "1";
            oc_Newobject34["mouseOverAlpha"] = "1";
            oc_Newobject34["alphaFade"] = "1";
            oc_Newobject34["contextFontSize"] = "0";
            oc_Newobject34["editable"] = "0";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["Enabled"] = "1";

            #endregion

            oc_Newobject35["#Newobject34"] = oc_Newobject34;

            #endregion

            oc_Newobject42["#Newobject35"] = oc_Newobject35;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject37["bitmapMode"] = "Stretched";
            oc_Newobject37["autoFitExtents"] = "0";
            oc_Newobject37["useModifiers"] = "0";
            oc_Newobject37["useStates"] = "1";
            oc_Newobject37["text"] = "Bevel Color NA";
            oc_Newobject37["groupNum"] = "3";
            oc_Newobject37["buttonType"] = "RadioButton";
            oc_Newobject37["useMouseEvents"] = "0";
            oc_Newobject37["position"] = "45 85";
            oc_Newobject37["extent"] = "140 30";
            oc_Newobject37["minExtent"] = "8 2";
            oc_Newobject37["maxExtent"] = "1920 1080";
            oc_Newobject37["horizSizing"] = "right";
            oc_Newobject37["vertSizing"] = "bottom";
            oc_Newobject37["profile"] = "GuiDefaultProfile";
            oc_Newobject37["controlFontColor"] = "0 0 0 0";
            oc_Newobject37["backgroundColor"] = "255 255 255 255";
            oc_Newobject37["controlFontSize"] = "14";
            oc_Newobject37["visible"] = "1";
            oc_Newobject37["active"] = "1";
            oc_Newobject37["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["alphaValue"] = "1";
            oc_Newobject37["mouseOverAlphaValue"] = "1";
            oc_Newobject37["alphaFadeTime"] = "1000";
            oc_Newobject37["windowSettings"] = "1";
            oc_Newobject37["alpha"] = "1";
            oc_Newobject37["mouseOverAlpha"] = "1";
            oc_Newobject37["alphaFade"] = "1";
            oc_Newobject37["contextFontColor"] = "0";
            oc_Newobject37["contextBackColor"] = "0";
            oc_Newobject37["contextFontSize"] = "0";
            oc_Newobject37["editable"] = "0";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject36["color"] = "1 1 1 1";
            oc_Newobject36["groupNum"] = "-1";
            oc_Newobject36["buttonType"] = "PushButton";
            oc_Newobject36["useMouseEvents"] = "0";
            oc_Newobject36["position"] = "0 23";
            oc_Newobject36["extent"] = "140 7";
            oc_Newobject36["minExtent"] = "8 2";
            oc_Newobject36["maxExtent"] = "1920 1080";
            oc_Newobject36["horizSizing"] = "right";
            oc_Newobject36["vertSizing"] = "bottom";
            oc_Newobject36["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject36["controlFontSize"] = "14";
            oc_Newobject36["visible"] = "1";
            oc_Newobject36["active"] = "0";
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
            oc_Newobject36["contextFontSize"] = "0";
            oc_Newobject36["editable"] = "0";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["canSaveDynamicFields"] = "0";
            oc_Newobject36["Enabled"] = "1";

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject42["#Newobject37"] = oc_Newobject37;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject39["bitmapMode"] = "Stretched";
            oc_Newobject39["autoFitExtents"] = "0";
            oc_Newobject39["useModifiers"] = "0";
            oc_Newobject39["useStates"] = "1";
            oc_Newobject39["text"] = "Bevel Color HL";
            oc_Newobject39["groupNum"] = "3";
            oc_Newobject39["buttonType"] = "RadioButton";
            oc_Newobject39["useMouseEvents"] = "0";
            oc_Newobject39["position"] = "45 141";
            oc_Newobject39["extent"] = "140 30";
            oc_Newobject39["minExtent"] = "8 2";
            oc_Newobject39["maxExtent"] = "1920 1080";
            oc_Newobject39["horizSizing"] = "right";
            oc_Newobject39["vertSizing"] = "bottom";
            oc_Newobject39["profile"] = "GuiDefaultProfile";
            oc_Newobject39["controlFontColor"] = "0 0 0 0";
            oc_Newobject39["backgroundColor"] = "255 255 255 255";
            oc_Newobject39["controlFontSize"] = "14";
            oc_Newobject39["visible"] = "1";
            oc_Newobject39["active"] = "1";
            oc_Newobject39["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["alphaValue"] = "1";
            oc_Newobject39["mouseOverAlphaValue"] = "1";
            oc_Newobject39["alphaFadeTime"] = "1000";
            oc_Newobject39["windowSettings"] = "1";
            oc_Newobject39["alpha"] = "1";
            oc_Newobject39["mouseOverAlpha"] = "1";
            oc_Newobject39["alphaFade"] = "1";
            oc_Newobject39["contextFontColor"] = "0";
            oc_Newobject39["contextBackColor"] = "0";
            oc_Newobject39["contextFontSize"] = "0";
            oc_Newobject39["editable"] = "0";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject38["color"] = "1 1 1 1";
            oc_Newobject38["groupNum"] = "-1";
            oc_Newobject38["buttonType"] = "PushButton";
            oc_Newobject38["useMouseEvents"] = "0";
            oc_Newobject38["position"] = "0 23";
            oc_Newobject38["extent"] = "140 7";
            oc_Newobject38["minExtent"] = "8 2";
            oc_Newobject38["maxExtent"] = "1920 1080";
            oc_Newobject38["horizSizing"] = "right";
            oc_Newobject38["vertSizing"] = "bottom";
            oc_Newobject38["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject38["controlFontSize"] = "14";
            oc_Newobject38["visible"] = "1";
            oc_Newobject38["active"] = "0";
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
            oc_Newobject38["contextFontSize"] = "0";
            oc_Newobject38["editable"] = "0";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["Enabled"] = "1";

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject42["#Newobject39"] = oc_Newobject39;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject41["bitmapMode"] = "Stretched";
            oc_Newobject41["autoFitExtents"] = "0";
            oc_Newobject41["useModifiers"] = "0";
            oc_Newobject41["useStates"] = "1";
            oc_Newobject41["text"] = "Bevel Color LL";
            oc_Newobject41["groupNum"] = "3";
            oc_Newobject41["buttonType"] = "RadioButton";
            oc_Newobject41["useMouseEvents"] = "0";
            oc_Newobject41["position"] = "45 195";
            oc_Newobject41["extent"] = "140 30";
            oc_Newobject41["minExtent"] = "8 2";
            oc_Newobject41["maxExtent"] = "1920 1080";
            oc_Newobject41["horizSizing"] = "right";
            oc_Newobject41["vertSizing"] = "bottom";
            oc_Newobject41["profile"] = "GuiDefaultProfile";
            oc_Newobject41["controlFontColor"] = "0 0 0 0";
            oc_Newobject41["backgroundColor"] = "255 255 255 255";
            oc_Newobject41["controlFontSize"] = "14";
            oc_Newobject41["visible"] = "1";
            oc_Newobject41["active"] = "1";
            oc_Newobject41["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["alphaValue"] = "1";
            oc_Newobject41["mouseOverAlphaValue"] = "1";
            oc_Newobject41["alphaFadeTime"] = "1000";
            oc_Newobject41["windowSettings"] = "1";
            oc_Newobject41["alpha"] = "1";
            oc_Newobject41["mouseOverAlpha"] = "1";
            oc_Newobject41["alphaFade"] = "1";
            oc_Newobject41["contextFontColor"] = "0";
            oc_Newobject41["contextBackColor"] = "0";
            oc_Newobject41["contextFontSize"] = "0";
            oc_Newobject41["editable"] = "0";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject40["color"] = "1 1 1 1";
            oc_Newobject40["groupNum"] = "-1";
            oc_Newobject40["buttonType"] = "PushButton";
            oc_Newobject40["useMouseEvents"] = "0";
            oc_Newobject40["position"] = "0 23";
            oc_Newobject40["extent"] = "140 7";
            oc_Newobject40["minExtent"] = "8 2";
            oc_Newobject40["maxExtent"] = "1920 1080";
            oc_Newobject40["horizSizing"] = "right";
            oc_Newobject40["vertSizing"] = "bottom";
            oc_Newobject40["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject40["controlFontSize"] = "14";
            oc_Newobject40["visible"] = "1";
            oc_Newobject40["active"] = "0";
            oc_Newobject40["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["alphaValue"] = "1";
            oc_Newobject40["mouseOverAlphaValue"] = "1";
            oc_Newobject40["alphaFadeTime"] = "1000";
            oc_Newobject40["windowSettings"] = "1";
            oc_Newobject40["alpha"] = "1";
            oc_Newobject40["mouseOverAlpha"] = "1";
            oc_Newobject40["alphaFade"] = "1";
            oc_Newobject40["contextFontSize"] = "0";
            oc_Newobject40["editable"] = "0";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["Enabled"] = "1";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject43["#Newobject42"] = oc_Newobject42;

            #endregion

            oc_Newobject52["#Newobject43"] = oc_Newobject43;

            #region GuiTabPageCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject51["fitBook"] = "1";
            oc_Newobject51["text"] = "Border";
            oc_Newobject51["maxLength"] = "1024";
            oc_Newobject51["margin"] = "0 0 0 0";
            oc_Newobject51["padding"] = "0 0 0 0";
            oc_Newobject51["anchorTop"] = "1";
            oc_Newobject51["anchorBottom"] = "0";
            oc_Newobject51["anchorLeft"] = "1";
            oc_Newobject51["anchorRight"] = "0";
            oc_Newobject51["position"] = "0 0";
            oc_Newobject51["extent"] = "239 400";
            oc_Newobject51["minExtent"] = "8 2";
            oc_Newobject51["maxExtent"] = "1920 1080";
            oc_Newobject51["horizSizing"] = "right";
            oc_Newobject51["vertSizing"] = "bottom";
            oc_Newobject51["profile"] = "GuiTabPageProfile";
            oc_Newobject51["controlFontColor"] = "0 0 0 0";
            oc_Newobject51["controlFillColor"] = "0 0 0 0";
            oc_Newobject51["backgroundColor"] = "255 255 255 255";
            oc_Newobject51["controlFontSize"] = "10";
            oc_Newobject51["visible"] = "0";
            oc_Newobject51["active"] = "1";
            oc_Newobject51["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["isContainer"] = "1";
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
            oc_Newobject51["internalName"] = "borderPage";
            oc_Newobject51["hidden"] = "1";
            oc_Newobject51["editable"] = "0";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["Enabled"] = "1";

            #region GuiContainer ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiContainer", "");
            oc_Newobject50["docking"] = "Client";
            oc_Newobject50["margin"] = "0 0 0 0";
            oc_Newobject50["padding"] = "0 0 0 0";
            oc_Newobject50["anchorTop"] = "1";
            oc_Newobject50["anchorBottom"] = "0";
            oc_Newobject50["anchorLeft"] = "1";
            oc_Newobject50["anchorRight"] = "0";
            oc_Newobject50["position"] = "0 0";
            oc_Newobject50["extent"] = "239 400";
            oc_Newobject50["minExtent"] = "8 2";
            oc_Newobject50["maxExtent"] = "1920 1080";
            oc_Newobject50["horizSizing"] = "right";
            oc_Newobject50["vertSizing"] = "bottom";
            oc_Newobject50["profile"] = "GuiDefaultProfile";
            oc_Newobject50["controlFontColor"] = "0 0 0 0";
            oc_Newobject50["controlFillColor"] = "0 0 0 0";
            oc_Newobject50["backgroundColor"] = "255 255 255 255";
            oc_Newobject50["controlFontSize"] = "14";
            oc_Newobject50["visible"] = "1";
            oc_Newobject50["active"] = "1";
            oc_Newobject50["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["isContainer"] = "1";
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

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject45["bitmapMode"] = "Stretched";
            oc_Newobject45["autoFitExtents"] = "0";
            oc_Newobject45["useModifiers"] = "0";
            oc_Newobject45["useStates"] = "1";
            oc_Newobject45["text"] = "Border Color";
            oc_Newobject45["groupNum"] = "4";
            oc_Newobject45["buttonType"] = "RadioButton";
            oc_Newobject45["useMouseEvents"] = "0";
            oc_Newobject45["position"] = "45 29";
            oc_Newobject45["extent"] = "140 30";
            oc_Newobject45["minExtent"] = "8 2";
            oc_Newobject45["maxExtent"] = "1920 1080";
            oc_Newobject45["horizSizing"] = "right";
            oc_Newobject45["vertSizing"] = "bottom";
            oc_Newobject45["profile"] = "GuiDefaultProfile";
            oc_Newobject45["controlFontColor"] = "0 0 0 0";
            oc_Newobject45["backgroundColor"] = "255 255 255 255";
            oc_Newobject45["controlFontSize"] = "14";
            oc_Newobject45["visible"] = "1";
            oc_Newobject45["active"] = "1";
            oc_Newobject45["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["isContainer"] = "1";
            oc_Newobject45["alphaValue"] = "1";
            oc_Newobject45["mouseOverAlphaValue"] = "1";
            oc_Newobject45["alphaFadeTime"] = "1000";
            oc_Newobject45["windowSettings"] = "1";
            oc_Newobject45["alpha"] = "1";
            oc_Newobject45["mouseOverAlpha"] = "1";
            oc_Newobject45["alphaFade"] = "1";
            oc_Newobject45["contextFontColor"] = "0";
            oc_Newobject45["contextBackColor"] = "0";
            oc_Newobject45["contextFontSize"] = "0";
            oc_Newobject45["editable"] = "0";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject44["color"] = "1 1 1 1";
            oc_Newobject44["groupNum"] = "-1";
            oc_Newobject44["buttonType"] = "PushButton";
            oc_Newobject44["useMouseEvents"] = "0";
            oc_Newobject44["position"] = "0 23";
            oc_Newobject44["extent"] = "140 7";
            oc_Newobject44["minExtent"] = "8 2";
            oc_Newobject44["maxExtent"] = "1920 1080";
            oc_Newobject44["horizSizing"] = "right";
            oc_Newobject44["vertSizing"] = "bottom";
            oc_Newobject44["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject44["controlFontSize"] = "14";
            oc_Newobject44["visible"] = "1";
            oc_Newobject44["active"] = "0";
            oc_Newobject44["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["isContainer"] = "0";
            oc_Newobject44["alphaValue"] = "1";
            oc_Newobject44["mouseOverAlphaValue"] = "1";
            oc_Newobject44["alphaFadeTime"] = "1000";
            oc_Newobject44["windowSettings"] = "1";
            oc_Newobject44["alpha"] = "1";
            oc_Newobject44["mouseOverAlpha"] = "1";
            oc_Newobject44["alphaFade"] = "1";
            oc_Newobject44["contextFontSize"] = "0";
            oc_Newobject44["editable"] = "0";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["canSaveDynamicFields"] = "0";
            oc_Newobject44["Enabled"] = "1";

            #endregion

            oc_Newobject45["#Newobject44"] = oc_Newobject44;

            #endregion

            oc_Newobject50["#Newobject45"] = oc_Newobject45;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject47["bitmapMode"] = "Stretched";
            oc_Newobject47["autoFitExtents"] = "0";
            oc_Newobject47["useModifiers"] = "0";
            oc_Newobject47["useStates"] = "1";
            oc_Newobject47["text"] = "Border Color HL";
            oc_Newobject47["groupNum"] = "4";
            oc_Newobject47["buttonType"] = "RadioButton";
            oc_Newobject47["useMouseEvents"] = "0";
            oc_Newobject47["position"] = "45 85";
            oc_Newobject47["extent"] = "140 30";
            oc_Newobject47["minExtent"] = "8 2";
            oc_Newobject47["maxExtent"] = "1920 1080";
            oc_Newobject47["horizSizing"] = "right";
            oc_Newobject47["vertSizing"] = "bottom";
            oc_Newobject47["profile"] = "GuiDefaultProfile";
            oc_Newobject47["controlFontColor"] = "0 0 0 0";
            oc_Newobject47["backgroundColor"] = "255 255 255 255";
            oc_Newobject47["controlFontSize"] = "14";
            oc_Newobject47["visible"] = "1";
            oc_Newobject47["active"] = "1";
            oc_Newobject47["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["isContainer"] = "1";
            oc_Newobject47["alphaValue"] = "1";
            oc_Newobject47["mouseOverAlphaValue"] = "1";
            oc_Newobject47["alphaFadeTime"] = "1000";
            oc_Newobject47["windowSettings"] = "1";
            oc_Newobject47["alpha"] = "1";
            oc_Newobject47["mouseOverAlpha"] = "1";
            oc_Newobject47["alphaFade"] = "1";
            oc_Newobject47["contextFontColor"] = "0";
            oc_Newobject47["contextBackColor"] = "0";
            oc_Newobject47["contextFontSize"] = "0";
            oc_Newobject47["editable"] = "0";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["canSaveDynamicFields"] = "0";
            oc_Newobject47["Enabled"] = "1";

            #region GuiSwatchButtonCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject46["color"] = "1 1 1 1";
            oc_Newobject46["groupNum"] = "-1";
            oc_Newobject46["buttonType"] = "PushButton";
            oc_Newobject46["useMouseEvents"] = "0";
            oc_Newobject46["position"] = "0 23";
            oc_Newobject46["extent"] = "140 7";
            oc_Newobject46["minExtent"] = "8 2";
            oc_Newobject46["maxExtent"] = "1920 1080";
            oc_Newobject46["horizSizing"] = "right";
            oc_Newobject46["vertSizing"] = "bottom";
            oc_Newobject46["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject46["controlFontSize"] = "14";
            oc_Newobject46["visible"] = "1";
            oc_Newobject46["active"] = "0";
            oc_Newobject46["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["isContainer"] = "0";
            oc_Newobject46["alphaValue"] = "1";
            oc_Newobject46["mouseOverAlphaValue"] = "1";
            oc_Newobject46["alphaFadeTime"] = "1000";
            oc_Newobject46["windowSettings"] = "1";
            oc_Newobject46["alpha"] = "1";
            oc_Newobject46["mouseOverAlpha"] = "1";
            oc_Newobject46["alphaFade"] = "1";
            oc_Newobject46["contextFontSize"] = "0";
            oc_Newobject46["editable"] = "0";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["canSaveDynamicFields"] = "0";
            oc_Newobject46["Enabled"] = "1";

            #endregion

            oc_Newobject47["#Newobject46"] = oc_Newobject46;

            #endregion

            oc_Newobject50["#Newobject47"] = oc_Newobject47;

            #region GuiBitmapButtonTextCtrl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiBitmapButtonTextCtrl", "", typeof (ProfileColorButton));
            oc_Newobject49["bitmapMode"] = "Stretched";
            oc_Newobject49["autoFitExtents"] = "0";
            oc_Newobject49["useModifiers"] = "0";
            oc_Newobject49["useStates"] = "1";
            oc_Newobject49["text"] = "Border Color NA";
            oc_Newobject49["groupNum"] = "4";
            oc_Newobject49["buttonType"] = "RadioButton";
            oc_Newobject49["useMouseEvents"] = "0";
            oc_Newobject49["position"] = "45 141";
            oc_Newobject49["extent"] = "140 30";
            oc_Newobject49["minExtent"] = "8 2";
            oc_Newobject49["maxExtent"] = "1920 1080";
            oc_Newobject49["horizSizing"] = "right";
            oc_Newobject49["vertSizing"] = "bottom";
            oc_Newobject49["profile"] = "GuiDefaultProfile";
            oc_Newobject49["controlFontColor"] = "0 0 0 0";
            oc_Newobject49["backgroundColor"] = "255 255 255 255";
            oc_Newobject49["controlFontSize"] = "14";
            oc_Newobject49["visible"] = "1";
            oc_Newobject49["active"] = "1";
            oc_Newobject49["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["isContainer"] = "1";
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

            #region GuiSwatchButtonCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiSwatchButtonCtrl", "");
            oc_Newobject48["color"] = "1 1 1 1";
            oc_Newobject48["groupNum"] = "-1";
            oc_Newobject48["buttonType"] = "PushButton";
            oc_Newobject48["useMouseEvents"] = "0";
            oc_Newobject48["position"] = "0 23";
            oc_Newobject48["extent"] = "140 7";
            oc_Newobject48["minExtent"] = "8 2";
            oc_Newobject48["maxExtent"] = "1920 1080";
            oc_Newobject48["horizSizing"] = "right";
            oc_Newobject48["vertSizing"] = "bottom";
            oc_Newobject48["profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject48["controlFontSize"] = "14";
            oc_Newobject48["visible"] = "1";
            oc_Newobject48["active"] = "0";
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
            oc_Newobject48["contextFontSize"] = "0";
            oc_Newobject48["editable"] = "0";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["canSaveDynamicFields"] = "0";
            oc_Newobject48["Enabled"] = "1";

            #endregion

            oc_Newobject49["#Newobject48"] = oc_Newobject48;

            #endregion

            oc_Newobject50["#Newobject49"] = oc_Newobject49;

            #endregion

            oc_Newobject51["#Newobject50"] = oc_Newobject50;

            #endregion

            oc_Newobject52["#Newobject51"] = oc_Newobject51;

            #endregion

            oc_Newobject53["#Newobject52"] = oc_Newobject52;

            #endregion

            oc_Newobject55["#Newobject53"] = oc_Newobject53;

            #region GuiContainer (profileControlContainer)        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiContainer", "profileControlContainer");
            oc_Newobject54["margin"] = "0 0 0 0";
            oc_Newobject54["padding"] = "0 0 0 0";
            oc_Newobject54["anchorTop"] = "1";
            oc_Newobject54["anchorBottom"] = "0";
            oc_Newobject54["anchorLeft"] = "1";
            oc_Newobject54["anchorRight"] = "0";
            oc_Newobject54["position"] = "337 253";
            oc_Newobject54["extent"] = "329 151";
            oc_Newobject54["minExtent"] = "8 2";
            oc_Newobject54["maxExtent"] = "1920 1080";
            oc_Newobject54["horizSizing"] = "relative";
            oc_Newobject54["vertSizing"] = "relative";
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
            oc_Newobject54["editable"] = "0";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["canSaveDynamicFields"] = "0";
            oc_Newobject54["Enabled"] = "1";

            #endregion

            oc_Newobject55["#Newobject54"] = oc_Newobject54;

            #endregion

            oc_Newobject57["#Newobject55"] = oc_Newobject55;

            #region GuiContainer (profileRightPane)        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiContainer", "profileRightPane");
            oc_Newobject56["docking"] = "Right";
            oc_Newobject56["margin"] = "0 0 0 0";
            oc_Newobject56["padding"] = "0 0 0 0";
            oc_Newobject56["anchorTop"] = "1";
            oc_Newobject56["anchorBottom"] = "0";
            oc_Newobject56["anchorLeft"] = "1";
            oc_Newobject56["anchorRight"] = "0";
            oc_Newobject56["position"] = "762 0";
            oc_Newobject56["extent"] = "260 744";
            oc_Newobject56["minExtent"] = "8 2";
            oc_Newobject56["maxExtent"] = "1920 1080";
            oc_Newobject56["horizSizing"] = "width";
            oc_Newobject56["vertSizing"] = "height";
            oc_Newobject56["profile"] = "GuiDefaultProfile";
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

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #endregion

            oc_Newobject58["#Newobject57"] = oc_Newobject57;

            #endregion

            oc_Newobject58.Create();
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            ProfilePopUp profileControlPopUp = "profileControlPopUp";

            profileControlPopUp.clear();

            string controls = Util.enumerateConsoleClassesByCategory("Gui");

            foreach (string className in controls.Split('\t'))
                {
                if (GuiEditor.isFilteredClass(className) || !(Util.isMemberOfClass(className, "GuiControl")))
                    continue;

                profileControlPopUp.add(className, -1, 0);
                }

            profileControlPopUp.text = "Select a new control";

            GuiEditorGui.GuiEditorTabBook GuiEditorTabBook = "GuiEditorTabBook";
            GuiFrameSetCtrl profileFrame = GuiEditorTabBook.FOT("profileFrame");

            GuiContainer profileRightPane = "profileRightPane";

            GuiBitmapButtonCtrl saveAsButton = profileFrame.FOT("saveAsButton");
            GuiBitmapButtonCtrl saveButton = profileFrame.FOT("saveButton");

            profileRightPane.addGuiControl(profileFrame);

            profileFrame.remove(saveAsButton, saveButton);

            profileFrame.docking = TypeGuiDockingType.Client;
        }

        [ConsoleInteraction]
        public void setExternalControl(string control)
        {
            externalControl = control;
            createMainControl();
        }

        [ConsoleInteraction]
        public void onProfileDeleted()
        {
            GuiContainer profileControlContainer = "profileControlContainer";
            GuiTabBookCtrl profileTabBook = FOT("profileTabBook");

            controlProfile = 0;
            profileControlContainer.clear();

            profileTabBook.callOnChildren("onSwatchButtonColorChanged");
        }

        [ConsoleInteraction]
        public void onProfileReverted(GuiControlProfile profile)
        {
            controlProfile = profile;
            onProfileSelected();
        }

        [ConsoleInteraction]
        public void onProfileSelected()
        {
            //GuiEditorGui.GuiEditorTabBook GuiEditorTabBook = "GuiEditorTabBook";
            GuiEditorProfiles.GuiEditorProfileInspector GuiEditorProfileInspector = "GuiEditorProfileInspector";
            GuiTabBookCtrl profileTabBook = FOT("profileTabBook");

            controlProfile = GuiEditorProfileInspector.getInspectObject();

            /*GuiControlProfile tempControlProfileOld = "tempControlProfileOld";
            if (tempControlProfileOld != 0)
                tempControlProfileOld.delete();

            GuiControlProfile tempControlProfileNew = "tempControlProfileNew";
            if (tempControlProfileNew != 0)
                tempControlProfileNew.delete();

            tempControlProfile = 0;*/

            profileTabBook.callOnChildren("onSwatchButtonColorChanged");
        }

        [ConsoleInteraction]
        public bool isProfileSelected()
        {
            return controlProfile != 0;
        }

        [ConsoleInteraction]
        public void createMainControl()
        {
            GuiContainer profileControlContainer = "profileControlContainer";

            profileControlContainer.clear();

            Point2I position = new Point2I(profileControlContainer.getExtent().x/2 - 15, profileControlContainer.getExtent().y/2 - 15);

            if (externalControl == "")
                {
                if (controlProfile["controlBound"] != "All")
                    mainGuiControl = Util.eval("return %temp = new " + controlProfile["controlBound"] + "() { HorizSizing = \"center\"; text= \"TEXT\"; VertSizing = \"center\"; Extent = \"130 30\"; internalName = \"tempGuiControl\"; Position =\"" + position.x + " " + position.y + "\"; };");
                else
                    mainGuiControl = Util.eval("return %temp = new GuiControl() { HorizSizing = \"center\"; VertSizing = \"center\"; Extent = \"130 30\"; internalName = \"tempGuiControl\"; Position =\"" + position.x + " " + position.y + "\"; };");
                }
            else
                mainGuiControl = Util.eval("return %temp = new " + externalControl + "() { HorizSizing = \"center\"; text= \"TEXT\"; VertSizing = \"center\"; Extent = \"130 30\"; internalName = \"tempGuiControl\"; Position =\"" + position.x + " " + position.y + "\"; };");

            mainGuiControl.setProfile(controlProfile);
            profileControlContainer.addGuiControl(mainGuiControl);
        }

        [ConsoleInteraction]
        public UndoManager getUndoManager()
        {
            if (!"ProfilePaneUndoManager".isObject())
                new ObjectCreator("UndoManager", "ProfilePaneUndoManager", typeof (ProfilePaneUndoManager)).Create();

            return "ProfilePaneUndoManager";
        }

        [TypeConverter(typeof (TypeConverterGeneric<ProfileColorButton>))]
        public class ProfileColorButton : GuiBitmapButtonTextCtrl
        {
            private GuiSwatchButtonCtrl swatchButton
            {
                get { return this["swatchButton"]; }
                set { this["swatchButton"] = value; }
            }

            [ConsoleInteraction]
            public override void onWake()
            {
                swatchButton = getObject(0);
                onSwatchButtonColorChanged();
            }

            [ConsoleInteraction]
            public void onSwatchButtonColorChanged()
            {
                ProfilePane ProfilePane = "ProfilePane";

                if (ProfilePane.controlProfile != 0 && swatchButton != null)
                    {
                    // Get the property name for the controlProfile.
                    string property = Util.strreplace(this.text, " ", "");
                    // Set the color of the swatchbutton to the property.
                    swatchButton.color = new ColorF(ColorPickerDlg.ColorIntToFloat(ProfilePane.controlProfile[property]));

                    /*if (ProfilePane.tempControlProfile == 0)
                    {
                        ProfilePane.tempControlProfile =
                            Util.eval("return %temp = new GuiControlProfile( tempControlProfileOld : " +
                                      ProfilePane.controlProfile.getName() + " );");
                    }
                    else
                    {
                        GuiControlProfile tempControlProfileNew = "tempControlProfileNew";
                        if (tempControlProfileNew != 0)
                        {
                            GuiControlProfile tempControlProfileOld = "tempControlProfileOld";
                            //if (tempControlProfileOld != 0)
                            //    tempControlProfileOld.delete();

                            ProfilePane.tempControlProfile =
                                Util.eval(
                                    "return %temp = new GuiControlProfile(  : tempControlProfileNew ){ " +
                                    property + " = \"" + ProfilePane.controlProfile[property] + "\"; };");

                            //Util.eval("tempControlProfileOld = tempControlProfileNew;");
                            tempControlProfileOld.assignFieldsFrom(tempControlProfileNew);
                            tempControlProfileNew.assignFieldsFrom(ProfilePane.tempControlProfile);

                            //Util.eval("tempControlProfileNew = " + ProfilePane.tempControlProfile + ";");

                            //Util.eval(
                            //    "return %temp = new GuiControlProfile( tempControlProfileOld : tempControlProfileNew ){ " +
                            //    property + " = \"" + ProfilePane.controlProfile[property] + "\"; };");

                            //tempControlProfileNew.delete();

                            

                            //Util.eval("new GuiControlProfile( tempControlProfileNew : tempControlProfileOld );");
                        }
                        else
                        {
                            ProfilePane.tempControlProfile =
                                Util.eval(
                                    "return %temp = new GuiControlProfile( tempControlProfileNew : tempControlProfileOld ){ " +
                                    property + " = \"" + ProfilePane.controlProfile[property] + "\"; };");
                        }

                    }*/

                    //ProfilePane.createMainControl(ProfilePane.tempControlProfile);
                    ProfilePane.createMainControl();
                    }
                else
                    swatchButton.color = new ColorF(1, 1, 1, 1);
            }

            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ProfilePane ProfilePane = "ProfilePane";

                if (ProfilePane.controlProfile != 0)
                    {
                    // Get the color picker dialog for the button when pressed.
                    ColorPickerDlg.GetColorI(ColorPickerDlg.ColorFloatToInt(swatchButton.color.AsString()), getId() + ".setDataColor", swatchButton.getRoot(), "", "");
                    }
            }

            [ConsoleInteraction]
            public void setDataColor(ColorI color, int callbackType)
            {
                GuiEditorProfiles.GuiEditorProfileInspector GuiEditorProfileInspector = "GuiEditorProfileInspector";
                ProfilePane ProfilePane = "ProfilePane";
                if (ProfilePane.controlProfile != 0)
                    {
                    string property = Util.strreplace(this.text, " ", "");

                    // Set the object field to the color.
                    GuiEditorProfileInspector.setObjectField(property, color.AsString());

                    // Update the color of the swatchbutton.
                    onSwatchButtonColorChanged();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ProfileColorButton ts, string simobjectid)
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
            public static bool operator !=(ProfileColorButton ts, string simobjectid)
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
            public static implicit operator string(ProfileColorButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ProfileColorButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ProfileColorButton) Omni.self.getSimObject(simobjectid, typeof (ProfileColorButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ProfileColorButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ProfileColorButton(int simobjectid)
            {
                return (ProfileColorButton) Omni.self.getSimObject((uint) simobjectid, typeof (ProfileColorButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ProfileColorButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ProfileColorButton(uint simobjectid)
            {
                return (ProfileColorButton) Omni.self.getSimObject(simobjectid, typeof (ProfileColorButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ProfilePaneUndoManager>))]
        public class ProfilePaneUndoManager : UndoManager
        {
            [ConsoleInteraction]
            public override void onUndo()
            {
                ProfilePane ProfilePane = "ProfilePane";

                ProfilePane.onProfileSelected();
            }

            [ConsoleInteraction]
            public override void onRedo()
            {
                ProfilePane ProfilePane = "ProfilePane";

                ProfilePane.onProfileSelected();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ProfilePaneUndoManager ts, string simobjectid)
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
            public static bool operator !=(ProfilePaneUndoManager ts, string simobjectid)
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
            public static implicit operator string(ProfilePaneUndoManager ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ProfilePaneUndoManager(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ProfilePaneUndoManager) Omni.self.getSimObject(simobjectid, typeof (ProfilePaneUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ProfilePaneUndoManager ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ProfilePaneUndoManager(int simobjectid)
            {
                return (ProfilePaneUndoManager) Omni.self.getSimObject((uint) simobjectid, typeof (ProfilePaneUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ProfilePaneUndoManager ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ProfilePaneUndoManager(uint simobjectid)
            {
                return (ProfilePaneUndoManager) Omni.self.getSimObject(simobjectid, typeof (ProfilePaneUndoManager));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ProfilePopUp>))]
        public class ProfilePopUp : GuiPopUpMenuCtrl
        {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
            {
                ProfilePane ProfilePane = "ProfilePane";
                if (ProfilePane.isProfileSelected())
                    ProfilePane.setExternalControl(text);
                else
                    this.text = "Select a new control";
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ProfilePopUp ts, string simobjectid)
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
            public static bool operator !=(ProfilePopUp ts, string simobjectid)
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
            public static implicit operator string(ProfilePopUp ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ProfilePopUp(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ProfilePopUp) Omni.self.getSimObject(simobjectid, typeof (ProfilePopUp));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ProfilePopUp ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ProfilePopUp(int simobjectid)
            {
                return (ProfilePopUp) Omni.self.getSimObject((uint) simobjectid, typeof (ProfilePopUp));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ProfilePopUp ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ProfilePopUp(uint simobjectid)
            {
                return (ProfilePopUp) Omni.self.getSimObject(simobjectid, typeof (ProfilePopUp));
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
        public static bool operator ==(ProfilePane ts, string simobjectid)
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
        public static bool operator !=(ProfilePane ts, string simobjectid)
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
        public static implicit operator string(ProfilePane ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ProfilePane(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ProfilePane) Omni.self.getSimObject(simobjectid, typeof (ProfilePane));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ProfilePane ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ProfilePane(int simobjectid)
        {
            return (ProfilePane) Omni.self.getSimObject((uint) simobjectid, typeof (ProfilePane));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ProfilePane ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ProfilePane(uint simobjectid)
        {
            return (ProfilePane) Omni.self.getSimObject(simobjectid, typeof (ProfilePane));
        }

        #endregion
    }
}