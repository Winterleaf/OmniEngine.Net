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

#region

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    internal class messageBox
    {
        public static void initialize()
        {
            if ("MessagePopupDlg".isObject())
                "MessagePopupDlg".delete();
            if ("MessageBoxYesNoDlg".isObject())
                "MessageBoxYesNoDlg".delete();
            if ("MessageBoxYesNoCancelDlg".isObject())
                "MessageBoxYesNoCancelDlg".delete();
            if ("MessageBoxOKCancelDetailsDlg".isObject())
                "MessageBoxOKCancelDetailsDlg".delete();
            if ("MessageBoxOKCancelDlg".isObject())
                "MessageBoxOKCancelDlg".delete();
            if ("MessageBoxOKDlg".isObject())
                "MessageBoxOKDlg".delete();
            if ("IODropdownDlg".isObject())
                "IODropdownDlg".delete();

            #region exec("./messageBoxOk.ed.gui");

            pInvokes.console.Eval(@"

%guiContent = new GuiControl(MessageBoxOKDlg) {
   WLE_OVERRIDE_PROXY_CLASSTYPE = """ + typeof (MessageBoxOKDlg).FullName + @""";
   profile = ""GuiOverlayProfile"";
   horizSizing = ""width"";
   vertSizing = ""height"";
   position = ""0 0"";
   extent = ""640 480"";
   minExtent = ""8 8"";
   visible = ""1"";
   helpTag = ""0"";

   new GuiWindowCtrl(MBOKFrame) {
      profile = ""GuiWindowProfile"";
      horizSizing = ""center"";
      vertSizing = ""center"";
      position = ""170 175"";
      extent = ""300 107"";
      minExtent = ""48 95"";
      visible = ""1"";
      helpTag = ""0"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""0"";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";
      text = """";

      new GuiMLTextCtrl(MBOKText) {
         profile = ""GuiMLTextProfile"";
         horizSizing = ""center"";
         vertSizing = ""bottom"";
         position = ""9 35"";
         extent = ""281 24"";
         minExtent = ""8 8"";
         visible = ""1"";
         helpTag = ""0"";
         lineSpacing = ""2"";
         allowColorChars = ""0"";
         maxChars = ""-1"";
      };
      new GuiButtonCtrl() {
         profile = ""GuiButtonProfile"";
         horizSizing = ""right"";
         vertSizing = ""top"";
         position = ""111 75"";
         extent = ""80 24"";
         minExtent = ""8 8"";
         visible = ""1"";
         command = ""MessageCallback(MessageBoxOKDlg,MessageBoxOKDlg.callback);"";
         accelerator = ""return"";
         helpTag = ""0"";
         text = ""Ok"";
            simpleStyle = ""0"";
      };
   };
};
");

            #endregion

            #region exec("./messageBoxYesNo.ed.gui");

            pInvokes.console.Eval(@"
%guiContent = new GuiControl(MessageBoxYesNoDlg) {

WLE_OVERRIDE_PROXY_CLASSTYPE = """ + typeof (MessageBoxYesNoDlg).FullName + @""";
   
	profile = ""GuiOverlayProfile"";
	horizSizing = ""width"";
	vertSizing = ""height"";
	position = ""0 0"";
	extent = ""640 480"";
	minExtent = ""8 8"";
	visible = ""1"";
	helpTag = ""0"";

	new GuiWindowCtrl(MBYesNoFrame) {
      profile = ""GuiWindowProfile"";
      horizSizing = ""center"";
      vertSizing = ""center"";
      position = ""170 175"";
      extent = ""300 100"";
      minExtent = ""48 92"";
      visible = ""1"";
      helpTag = ""0"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""1"";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";
      text = """";
      closeCommand = ""MessageCallback(MessageBoxYesNoDlg,MessageBoxYesNoDlg.noCallback);"";

		new GuiMLTextCtrl(MBYesNoText) {
         profile = ""GuiMLTextProfile"";
         horizSizing = ""center"";
         vertSizing = ""bottom"";
         position = ""11 38"";
         extent = ""280 14"";
         minExtent = ""8 8"";
         visible = ""1"";
         helpTag = ""0"";
         lineSpacing = ""2"";
         allowColorChars = ""0"";
         maxChars = ""-1"";
		};
		new GuiButtonCtrl() {
         profile = ""GuiButtonProfile"";
         horizSizing = ""right"";
         vertSizing = ""top"";
         position = ""70 68"";
         extent = ""80 22"";
         minExtent = ""8 8"";
         visible = ""1"";
			command = ""MessageCallback(MessageBoxYesNoDlg,MessageBoxYesNoDlg.yesCallback);"";
         accelerator = ""return"";
         helpTag = ""0"";
         text = ""Yes"";
         simpleStyle = ""0"";
		};
		new GuiButtonCtrl() {
         profile = ""GuiButtonProfile"";
         horizSizing = ""right"";
         vertSizing = ""top"";
         position = ""167 68"";
         extent = ""80 22"";
         minExtent = ""8 8"";
         visible = ""1"";
			command = ""MessageCallback(MessageBoxYesNoDlg,MessageBoxYesNoDlg.noCallback);"";
         accelerator = ""escape"";
         helpTag = ""0"";
         text = ""No"";
         simpleStyle = ""0"";
		};
	};
};
");

            #endregion

            #region exec("./messageBoxYesNoCancel.ed.gui");

            pInvokes.console.Eval(@"
%guiContent = new GuiControl(MessageBoxYesNoCancelDlg) {
WLE_OVERRIDE_PROXY_CLASSTYPE = """ + typeof (MessageBoxYesNoCancelDlg).FullName + @""";
   
   canSaveDynamicFields = ""0"";
   Profile = ""GuiOverlayProfile"";
   HorizSizing = ""width"";
   VertSizing = ""height"";
   position = ""0 0"";
   Extent = ""800 600"";
   MinExtent = ""8 8"";
   canSave = ""1"";
   Visible = ""1"";
   hovertime = ""1000"";

   new GuiWindowCtrl(MBYesNoCancelFrame) {
      canSaveDynamicFields = ""0"";
      Profile = ""GuiWindowProfile"";
      HorizSizing = ""center"";
      VertSizing = ""center"";
      position = ""250 235"";
      Extent = ""300 102"";
      MinExtent = ""48 92"";
      canSave = ""1"";
      Visible = ""1"";
      hovertime = ""1000"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""1"";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";
      text = """";
      closeCommand=""MessageCallback(MessageBoxYesNoCancelDlg,MessageBoxYesNoCancelDlg.cancelCallback);"";

      new GuiMLTextCtrl(MBYesNoCancelText) {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiMLTextProfile"";
         HorizSizing = ""center"";
         VertSizing = ""bottom"";
         position = ""7 38"";
         Extent = ""286 14"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         hovertime = ""1000"";
         lineSpacing = ""2"";
         allowColorChars = ""0"";
         maxChars = ""-1"";
      };
      new GuiButtonCtrl() {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiButtonProfile"";
         HorizSizing = ""right"";
         VertSizing = ""top"";
         position = ""7 71"";
         Extent = ""80 22"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         Command = ""MessageCallback(MessageBoxYesNoCancelDlg,MessageBoxYesNoCancelDlg.yesCallback);"";
         Accelerator = ""return"";
         hovertime = ""1000"";
         text = ""Yes"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
      };
      new GuiButtonCtrl() {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiButtonProfile"";
         HorizSizing = ""right"";
         VertSizing = ""top"";
         position = ""92 71"";
         Extent = ""80 22"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         Command = ""MessageCallback(MessageBoxYesNoCancelDlg,MessageBoxYesNoCancelDlg.noCallback);"";
         hovertime = ""1000"";
         text = ""No"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
      };
      new GuiButtonCtrl() {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiButtonProfile"";
         HorizSizing = ""right"";
         VertSizing = ""top"";
         position = ""213 71"";
         Extent = ""80 22"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         Command = ""MessageCallback(MessageBoxYesNoCancelDlg,MessageBoxYesNoCancelDlg.cancelCallback);"";
         Accelerator = ""escape"";
         hovertime = ""1000"";
         text = ""Cancel"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
      };
   };
};


");

            #endregion

            #region exec("./messageBoxOKCancel.ed.gui");

            pInvokes.console.Eval(@"
//--- OBJECT WRITE BEGIN ---
%guiContent = new GuiControl(MessageBoxOKCancelDlg) {
   WLE_OVERRIDE_PROXY_CLASSTYPE = ""WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.Message_Boxes.MessageBoxOKCancelDlg"";
   profile = ""GuiOverlayProfile"";
   horizSizing = ""width"";
   vertSizing = ""height"";
   position = ""0 0"";
   extent = ""640 480"";
   minExtent = ""8 8"";
   visible = ""1"";
   helpTag = ""0"";

   new GuiWindowCtrl(MBOKCancelFrame) {
      profile = ""GuiWindowProfile"";
      horizSizing = ""center"";
      vertSizing = ""center"";
      position = ""170 175"";
      extent = ""300 100"";
      minExtent = ""48 92"";
      visible = ""1"";
      helpTag = ""0"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""0"";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";
      text = """";

      new GuiMLTextCtrl(MBOKCancelText) {
         profile = ""GuiMLTextProfile"";
         horizSizing = ""center"";
         vertSizing = ""bottom"";
         position = ""8 34"";
         extent = ""283 24"";
         minExtent = ""8 8"";
         visible = ""1"";
         helpTag = ""0"";
         lineSpacing = ""2"";
         allowColorChars = ""0"";
         maxChars = ""-1"";
         
      };
      new GuiButtonCtrl() {
         profile = ""GuiButtonProfile"";
         horizSizing = ""right"";
         vertSizing = ""top"";
         position = ""66 68"";
         extent = ""80 24"";
         minExtent = ""8 8"";
         visible = ""1"";
         command = ""MessageCallback(MessageBoxOKCancelDlg,MessageBoxOKCancelDlg.callback);"";
         accelerator = ""return"";
         helpTag = ""0"";
         text = ""Ok"";
         simpleStyle = ""0"";
      };
      new GuiButtonCtrl() {
         profile = ""GuiButtonProfile"";
         horizSizing = ""right"";
         vertSizing = ""top"";
         position = ""156 68"";
         extent = ""80 24"";
         minExtent = ""8 8"";
         visible = ""1"";
         command = ""MessageCallback(MessageBoxOKCancelDlg,MessageBoxOKCancelDlg.cancelCallback);"";
         accelerator = ""escape"";
         helpTag = ""0"";
         text = ""Cancel"";
         simpleStyle = ""0"";
      };
   };
};
//--- OBJECT WRITE END ---

");

            #endregion

            #region exec("./messageBoxOKCancelDetailsDlg.ed.gui");

            pInvokes.console.Eval(@"
//--- OBJECT WRITE BEGIN ---
%guiContent = new GuiControl(MessageBoxOKCancelDetailsDlg) {
   WLE_OVERRIDE_PROXY_CLASSTYPE = ""WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.Message_Boxes.MessageBoxOKCancelDetailsDlg"";
   canSaveDynamicFields = ""0"";
   Profile = ""GuiOverlayProfile"";
   HorizSizing = ""width"";
   VertSizing = ""height"";
   position = ""0 0"";
   Extent = ""1024 768"";
   MinExtent = ""8 8"";
   canSave = ""1"";
   Visible = ""1"";
   hovertime = ""1000"";

   new GuiWindowCtrl(MBOKCancelDetailsFrame) {
      canSaveDynamicFields = ""0"";
      Profile = ""GuiWindowProfile"";
      HorizSizing = ""center"";
      VertSizing = ""center"";
      position = ""362 219"";
      Extent = ""300 330"";
      MinExtent = ""48 92"";
      canSave = ""1"";
      Visible = ""1"";
      hovertime = ""1000"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""0"";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";
      text = """";

      new GuiMLTextCtrl(MBOKCancelDetailsText) {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiMLTextProfile"";
         HorizSizing = ""center"";
         VertSizing = ""bottom"";
         position = ""32 39"";
         Extent = ""236 70"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         hovertime = ""1000"";
         lineSpacing = ""2"";
         allowColorChars = ""0"";
         maxChars = ""-1"";
      };
      new GuiButtonCtrl() {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiButtonProfile"";
         HorizSizing = ""right"";
         VertSizing = ""top"";
         position = ""158 273"";
         Extent = ""110 23"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         Command = ""MessageCallback(MessageBoxOKCancelDetailsDlg,MessageBoxOKCancelDetailsDlg.callback);"";
         Accelerator = ""return"";
         hovertime = ""1000"";
         text = ""OK"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
      };
      new GuiButtonCtrl() {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiButtonProfile"";
         HorizSizing = ""right"";
         VertSizing = ""top"";
         position = ""30 273"";
         Extent = ""110 23"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         Command = ""MessageCallback(MessageBoxOKCancelDetailsDlg,MessageBoxOKCancelDetailsDlg.cancelCallback);"";
         Accelerator = ""escape"";
         hovertime = ""1000"";
         text = ""CANCEL"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
      };
      new GuiButtonCtrl(MBOKCancelDetailsButton) {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiButtonProfile"";
         HorizSizing = ""right"";
         VertSizing = ""top"";
         position = ""9 302"";
         Extent = ""86 17"";
         MinExtent = ""8 8"";
         canSave = ""1"";
         Visible = ""1"";
         Command = ""MBOKCancelDetailsToggleInfoFrame();"";
         hovertime = ""1000"";
         text = ""Details"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
      };
      new GuiScrollCtrl(MBOKCancelDetailsScroll) {
         canSaveDynamicFields = ""0"";
         Profile = ""GuiScrollProfile"";
         HorizSizing = ""right"";
         VertSizing = ""bottom"";
         position = ""8 115"";
         Extent = ""281 138"";
         MinExtent = ""8 2"";
         canSave = ""1"";
         Visible = ""1"";
         hovertime = ""1000"";
         willFirstRespond = ""1"";
         hScrollBar = ""alwaysOff"";
         vScrollBar = ""dynamic"";
         lockHorizScroll = ""true"";
         lockVertScroll = ""false"";
         constantThumbHeight = ""0"";
         childMargin = ""0 0"";

         new GuiMLTextCtrl(MBOKCancelDetailsInfoText) {
            canSaveDynamicFields = ""0"";
            Profile = ""GuiMLTextProfile"";
            HorizSizing = ""right"";
            VertSizing = ""bottom"";
            position = ""2 2"";
            Extent = ""259 56"";
            MinExtent = ""8 2"";
            canSave = ""1"";
            Visible = ""1"";
            hovertime = ""1000"";
            lineSpacing = ""2"";
            allowColorChars = ""0"";
            maxChars = ""-1"";
         };
      };
   };
};
//--- OBJECT WRITE END ---


");

            #endregion

            #region exec("./messagePopup.ed.gui");

            pInvokes.console.Eval(@"
//--- OBJECT WRITE BEGIN ---
%guiContent = new GuiControl(MessagePopupDlg) {
   profile = ""GuiDefaultProfile"";
   horizSizing = ""width"";
   vertSizing = ""height"";
   position = ""0 0"";
   extent = ""640 480"";
   minExtent = ""8 8"";
   visible = ""1"";
   helpTag = ""0"";

   new GuiWindowCtrl(MessagePopFrame) {
      profile = ""GuiWindowProfile"";
      horizSizing = ""center"";
      vertSizing = ""center"";
      position = ""170 175"";
      extent = ""300 92"";
      minExtent = ""48 92"";
      visible = ""1"";
      helpTag = ""0"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""1"";
      text = """";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";

      new GuiMLTextCtrl(MessagePopText) {
         profile = ""GuiMLTextProfile"";
         horizSizing = ""center"";
         vertSizing = ""bottom"";
         position = ""32 39"";
         extent = ""236 24"";
         minExtent = ""8 8"";
         visible = ""1"";
         helpTag = ""0"";
         lineSpacing = ""2"";
         allowColorChars = ""0"";
         maxChars = ""-1"";
      };
   };
};
//--- OBJECT WRITE END ---

");

            #endregion

            #region exec("./IODropdownDlg.ed.gui");

            pInvokes.console.Eval(@"
//--- OBJECT WRITE BEGIN ---
%guiContent = new GuiControl(IODropdownDlg) {
   WLE_OVERRIDE_PROXY_CLASSTYPE = ""WinterLeaf.userObjects.GameCode.Client.Gui.Message_Boxes.IODropdownDlg"";
	profile = ""GuiDefaultProfile"";
	horizSizing = ""width"";
	vertSizing = ""height"";
	position = ""0 0"";
	extent = ""640 480"";
	minExtent = ""8 8"";
	visible = ""1"";
	helpTag = ""0"";
   new GuiWindowCtrl(IODropdownFrame) {
      canSaveDynamicFields = ""0"";
      Profile = ""GuiWindowProfile"";
      horizSizing = ""center"";
      vertSizing = ""center"";
      position = ""272 77"";
      extent = ""256 117"";
      minExtent = ""256 8"";
      canSave = ""1"";
      Visible = ""1"";
      hovertime = ""1000"";
      maxLength = ""255"";
      resizeWidth = ""1"";
      resizeHeight = ""1"";
      canMove = ""1"";
      canClose = ""1"";
      canMinimize = ""0"";
      canMaximize = ""0"";
      minSize = ""50 50"";
      text = """";
      closeCommand=""IOCallback(IODropdownDlg,IODropdownDlg.cancelCallback);"";

      new GuiMLTextCtrl(IODropdownText) {
         text = """";
         maxLength = ""1024"";
         margin = ""0 0 0 0"";
         padding = ""0 0 0 0"";
         anchorTop = ""1"";
         anchorBottom = ""0"";
         anchorLeft = ""1"";
         anchorRight = ""0"";
         isContainer = ""0"";
         profile = ""GuiMLTextProfile"";
         horizSizing = ""center"";
         vertSizing = ""bottom"";
         position = ""9 26"";
         extent = ""237 16"";
         minExtent = ""8 8"";
         canSave = ""1"";
         visible = ""1"";
         tooltipprofile = ""GuiToolTipProfile"";
         hovertime = ""1000"";
         canSaveDynamicFields = ""0"";
      };
      new GuiBitmapBorderCtrl() {
         isContainer = ""0"";
         profile = ""GuiGroupBorderProfile"";
         horizSizing = ""width"";
         vertSizing = ""bottom"";
         position = ""7 51"";
         extent = ""243 28"";
         minExtent = ""0 0"";
         canSave = ""1"";
         visible = ""1"";
         tooltipprofile = ""GuiToolTipProfile"";
         hovertime = ""1000"";
         canSaveDynamicFields = ""0"";

         new GuiTextCtrl(IOInputText) {
            text = ""Decal Datablock"";
            maxLength = ""1024"";
            margin = ""0 0 0 0"";
            padding = ""0 0 0 0"";
            anchorTop = ""1"";
            anchorBottom = ""0"";
            anchorLeft = ""1"";
            anchorRight = ""0"";
            isContainer = ""0"";
            profile = ""GuiTextRightProfile"";
            horizSizing = ""right"";
            vertSizing = ""bottom"";
            position = ""5 5"";
            extent = ""105 18"";
            minExtent = ""8 2"";
            canSave = ""1"";
            visible = ""1"";
            tooltipprofile = ""GuiToolTipProfile"";
            hovertime = ""1000"";
            canSaveDynamicFields = ""0"";
         };
         new GuiPopUpMenuCtrl(IODropdownMenu) {
            maxPopupHeight = ""200"";
            sbUsesNAColor = ""0"";
            reverseTextList = ""0"";
            bitmapBounds = ""16 16"";
            maxLength = ""1024"";
            margin = ""0 0 0 0"";
            padding = ""0 0 0 0"";
            anchorTop = ""1"";
            anchorBottom = ""0"";
            anchorLeft = ""1"";
            anchorRight = ""0"";
            isContainer = ""0"";
            profile = ""GuiPopUpMenuProfile"";
            horizSizing = ""width"";
            vertSizing = ""bottom"";
            position = ""115 5"";
            extent = ""122 18"";
            minExtent = ""8 2"";
            canSave = ""1"";
            visible = ""1"";
            tooltipprofile = ""GuiToolTipProfile"";
            hovertime = ""1000"";
            canSaveDynamicFields = ""0"";
         };
      };
      new GuiButtonCtrl() {
         text = ""OK"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
         useMouseEvents = ""0"";
         isContainer = ""0"";
         profile = ""GuiButtonProfile"";
         horizSizing = ""width"";
         vertSizing = ""top"";
         position = ""7 85"";
         extent = ""156 24"";
         minExtent = ""8 8"";
         canSave = ""1"";
         visible = ""1"";
         accelerator = ""return"";
         command = ""IOCallback(IODropdownDlg,IODropdownDlg.callback);"";
         tooltipprofile = ""GuiToolTipProfile"";
         hovertime = ""1000"";
         canSaveDynamicFields = ""0"";
      };
      new GuiButtonCtrl() {
         text = ""Cancel"";
         groupNum = ""-1"";
         buttonType = ""PushButton"";
         useMouseEvents = ""0"";
         isContainer = ""0"";
         profile = ""GuiButtonProfile"";
         horizSizing = ""left"";
         vertSizing = ""top"";
         position = ""170 85"";
         extent = ""80 24"";
         minExtent = ""8 8"";
         canSave = ""1"";
         visible = ""1"";
         accelerator = ""escape"";
         command = ""IOCallback(IODropdownDlg,IODropdownDlg.cancelCallback);"";
         tooltipprofile = ""GuiToolTipProfile"";
         hovertime = ""1000"";
         canSaveDynamicFields = ""0"";
      };
   };
};
//--- OBJECT WRITE END ---

");

            #endregion

            #region new SFXDescription(MessageBoxAudioDescription)

            pInvokes.console.Eval(@"
new SFXDescription(MessageBoxAudioDescription)
{
   volume      = 1.0;
   isLooping   = false;
   is3D        = false;
   channel     = $GuiAudioType;
};

new SFXProfile(messageBoxBeep)
{
   filename    = ""core/scripts/gui/messageBoxes/messageBoxSound"";
   description = MessageBoxAudioDescription;
   preload     = true;
};
");

            #endregion
        }

        /// <summary>
        /// messageCallback
        /// Calls a callback passed to a message box.
        /// </summary>
        /// <param name="dlg"></param>
        /// <param name="callback"></param>
        [ConsoleInteraction(true)]
        public static void messageCallback(GuiControl dlg, string callback)
        {
            ((GuiCanvas) "Canvas").popDialog(dlg);
            if (callback.Trim() != "")
                pInvokes.Util.eval(callback);
            //pInvokes.console.Eval(callback);
        }

        /// <summary>
        /// The # in the function passed replaced with the output 
        /// of the preset menu.
        /// </summary>
        /// <param name="dlg"></param>
        /// <param name="callback"></param>
        [ConsoleInteraction(true)]
        public static void IOCallback(GuiControl dlg, string callback)
        {
            GuiPopUpMenuCtrl IODropdownMenu = "IODropdownMenu";
            int id = IODropdownMenu.getSelected();
            string text = IODropdownMenu.getTextById(id);
            callback = callback.Replace("#", text);
            pInvokes.console.Eval(callback);
            ((GuiCanvas) "Canvas").popDialog(dlg);
        }

        public static void MBSetText(GuiMLTextCtrl text, GuiWindowCtrl frame, string msg)
        {
            // Get the extent of the text box.
            Point2I ext = text.getExtent();
            // Set the text in the center of the text box.
            text.setText("<just:center>" + msg);
            // Force the textbox to resize itself vertically.
            text.forceReflow();
            // Grab the new extent of the text box.
            Point2I newExtent = text.getExtent();
            // Get the vertical change in extent.

            int deltaY = newExtent.y - ext.y;

            // Resize the window housing the text box.
            Point2I windowPos = frame.getPosition();
            Point2I windowExt = frame.getExtent();
            frame.resize(windowPos.x, (windowPos.y - (deltaY/2)), windowExt.x, (windowExt.y + deltaY));

            frame.canMove = false;
            frame.resizeWidth = false;
            frame.resizeHeight = false;
            frame.canMinimize = false;
            frame.canMaximize = false;

            //TODO
            //pInvokes.Util._sfxPlayOnce("messageBoxBeep");
        }

        [ConsoleInteraction(true)]
        public static void MessageBoxOK(string title, string message, string callback = "")
        {
            ((GuiWindowCtrl) "MBOKFrame").text = title;
            ((GuiCanvas) "Canvas").pushDialog("MessageBoxOKDlg", 0, true);
            MBSetText("MBOKText", "MBOKFrame", message);
            ((GuiControl) "MessageBoxOKDlg")["callback"] = callback;
        }

        [ConsoleInteraction(true)]
        public static void MessageBoxOKCancel(string title, string message, string callback = "", string cancelCallBack = "")
        {
            ((GuiWindowCtrl) "MBOKCancelFrame").text = title;
            ((GuiCanvas) "Canvas").pushDialog("MessageBoxOKCancelDlg");
            MBSetText("MBOKCancelText", "MBOKCancelFrame", message);
            ((GuiControl) "MessageBoxOKCancelDlg")["callback"] = callback;
            ((GuiControl) "MessageBoxOKCancelDlg")["cancelCallback"] = cancelCallBack;
        }

        [ConsoleInteraction(true)]
        public static void MessageBoxOKCancelDetails(string title, string message, string details, string callback = "", string cancelCallback = "")
        {
            if (details == "")
                ((GuiButtonCtrl) "MBOKCancelDetailsButton").setVisible(false);

            ((GuiScrollCtrl) "MBOKCancelDetailsScroll").setVisible(false);
            ((GuiWindowCtrl) "MBOKCancelDetailsFrame").text = title;
            ((GuiCanvas) "Canvas").pushDialog("MessageBoxOKCancelDetailsDlg");
            MBSetText("MBOKCancelDetailsText", "MBOKCancelDetailsFrame", message);
            ((GuiMLTextCtrl) "MBOKCancelDetailsInfoText").setText(details);

            Point2I textExtent = ((GuiMLTextCtrl) "MBOKCancelDetailsInfoText").getExtent();
            int textExtentY = textExtent.y;

            Point2I textPos = ((GuiMLTextCtrl) "MBOKCancelDetailsInfoText").getPosition();
            int textPosY = textPos.y;

            int extentY = textPosY + textExtentY + 65;

            ((GuiMLTextCtrl) "MBOKCancelDetailsInfoText").setExtent(new Point2F(285, 128));

            ((GuiWindowCtrl) "MBOKCancelDetailsFrame").setExtent(new Point2F(300, extentY));

            ((MessageBoxOKCancelDetailsDlg) "MessageBoxOKCancelDetailsDlg")["callback"] = callback;
            ((MessageBoxOKCancelDetailsDlg) "MessageBoxOKCancelDetailsDlg")["cancelCallback"] = cancelCallback;

            ((GuiWindowCtrl) "MBOKCancelDetailsFrame")["defaultExtent"] = ((GuiWindowCtrl) "MBOKCancelDetailsFrame").getExtent().AsString();
        }

        [ConsoleInteraction(true)]
        public static void MBOKCancelDetailsToggleInfoFrame()
        {
            GuiScrollCtrl MBOKCancelDetailsScroll = "MBOKCancelDetailsScroll";
            if (!MBOKCancelDetailsScroll.isVisible())
                {
                MBOKCancelDetailsScroll.setVisible(true);
                GuiMLTextCtrl MBOKCancelDetailsText = "MBOKCancelDetailsText";
                Point2I textExtent = MBOKCancelDetailsText.getExtent();
                int textExtentY = textExtent.y;
                Point2I textPos = MBOKCancelDetailsText.getPosition();
                int textPosY = textPos.y;

                int verticalStretch = textExtentY;

                if (verticalStretch > 260 || verticalStretch < 0)
                    verticalStretch = 260;

                Point2I extent = new Point2I(((GuiWindowCtrl) "MBOKCancelDetailsFrame")["defaultExtent"]);
                int height = extent.y;

                int posY = textPosY + textExtentY + 10;

                int posX = MBOKCancelDetailsScroll.getPosition().x;

                MBOKCancelDetailsScroll.setPosition(posX, posY);
                MBOKCancelDetailsScroll.setExtent(new Point2F(MBOKCancelDetailsScroll.extent.x, verticalStretch));
                ((GuiWindowCtrl) "MBOKCancelDetailsFrame").setExtent(new Point2F(300, (height + verticalStretch + 10)));
                }
            else
                {
                Point2I extent = new Point2I(((GuiWindowCtrl) "MBOKCancelDetailsFrame")["defaultExtent"]);
                int width = extent.x;
                int height = extent.y;
                ((GuiWindowCtrl) "MBOKCancelDetailsFrame").setExtent(new Point2F(width, height));
                MBOKCancelDetailsScroll.setVisible(false);
                }
        }

        [ConsoleInteraction(true)]
        public static void MessageBoxYesNo(string title, string message, string yesCallback = "", string noCallback = "")
        {
            ((GuiWindowCtrl) "MBYesNoFrame").text = title;
            ((MessageBoxYesNoDlg) "MessageBoxYesNoDlg").profile = "GuiOverlayProfile";
            ((GuiCanvas) "Canvas").pushDialog("MessageBoxYesNoDlg");
            MBSetText("MBYesNoText", "MBYesNoFrame", message);
            ((GuiControl) "MessageBoxYesNoDlg")["yesCallBack"] = yesCallback;
            ((GuiControl) "MessageBoxYesNoDlg")["noCallback"] = noCallback;
        }

        [ConsoleInteraction(true)]
        public static void MessageBoxYesNoCancel(string title, string message, string yesCallback = "", string noCallback = "", string cancelCallback = "")
        {
            ((GuiWindowCtrl) "MBYesNoCancelFrame").text = title;
            ((MessageBoxYesNoCancelDlg) "MessageBoxYesNoCancelDlg").profile = "GuiOverlayProfile";
            //bug GuiCanvas.pushDialog doesn't seem to work the mouse right.
            ((GuiCanvas) "Canvas").pushDialog("MessageBoxYesNoCancelDlg");
            MBSetText("MBYesNoCancelText", "MBYesNoCancelFrame", message);
            ((GuiControl) "MessageBoxYesNoCancelDlg")["yesCallBack"] = yesCallback;
            ((GuiControl) "MessageBoxYesNoCancelDlg")["noCallback"] = noCallback;
            ((GuiControl) "MessageBoxYesNoCancelDlg")["cancelCallback"] = cancelCallback;
        }

        [ConsoleInteraction(true)]
        public static void MessagePopup(string title, string message, int delay = 0)
        {
            ((GuiWindowCtrl) "MBYesNoCancelFrame").text = title;
            //bug GuiCanvas.pushDialog doesn't seem to work the mouse right.
            ((GuiCanvas) "Canvas").pushDialog("MessagePopupDlg");
            MBSetText("MessagePopText", "MessagePopFrame", message);
            if (delay != 0)
                pInvokes.Util._schedule(delay.AsString(), "0", "CloseMessagePopup");
        }

        [ConsoleInteraction(true)]
        public static void IODropdown(string title, string message, SimGroup simgroup, string callback, string cancelCallback)
        {
            ((GuiWindowCtrl) "IODropdownFrame").text = title;
            //bug GuiCanvas.pushDialog doesn't seem to work the mouse right.
            ((GuiCanvas) "Canvas").pushDialog("IODropdownDlg");
            MBSetText("IODropdownText", "IODropdownFrame", message);
            GuiPopUpMenuCtrl IODropdownMenu = "IODropdownMenu";

            if (simgroup.isObject())
                {
                for (uint i = 0; i < simgroup.getCount(); i++)
                    IODropdownMenu.add(simgroup.getObject(i).getName());
                }

            IODropdownMenu.sort();
            IODropdownMenu.setFirstSelected(false);
            ((GuiControl) "IODropdownDlg")["callback"] = callback;
            ((GuiControl) "IODropdownDlg")["cancelCallback"] = cancelCallback;
        }

        [ConsoleInteraction(true)]
        public static void CloseMessagePopup()
        {
            //bug GuiCanvas.popDialog doesn't work correctly.
            ((GuiCanvas) "canvas").popDialog("MessagePopupDlg");
        }

        public static void MessageBoxOKOld(string title, string message, string callback)
        {
            MessageBoxOK(title, message, callback);
        }

        public static void MessageBoxOKCancelOld(string title, string message, string callback, string cancelCallback)
        {
            MessageBoxOKCancel(title, message, callback, cancelCallback);
        }

        public static void MessageBoxYesNoOld(string title, string message, string yesCallback, string noCallback)
        {
            MessageBoxYesNo(title, message, yesCallback, noCallback);
        }
    }
}