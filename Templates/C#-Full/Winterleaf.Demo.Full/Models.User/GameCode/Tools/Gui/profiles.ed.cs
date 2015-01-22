// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use  Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE  IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
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

using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui
{
    public class profiles : pInvokes
    {
        public static void initialize()
        {
            sGlobal["$Gui::clipboardFile"] = Util._expandFilename("tools/gui/clipboard.gui");

            if (!Util.isObject("ToolsGuiDefaultProfile"))
                {
                #region GuiControlProfile  (ToolsGuiDefaultProfile)        oc_Newobject1

                ObjectCreator oc_Newobject1 = new ObjectCreator("GuiControlProfile ", "ToolsGuiDefaultProfile");
                oc_Newobject1["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject1["canKeyFocus"] = new Creator.StringNoQuote("false");
                oc_Newobject1["hasBitmapArray"] = new Creator.StringNoQuote("false");
                oc_Newobject1["mouseOverSelected"] = new Creator.StringNoQuote("false");
                oc_Newobject1["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject1["fillColor"] = "32 32 32 255";
                oc_Newobject1["fillColorHL"] = "72 72 72 255";
                oc_Newobject1["fillColorSEL"] = "18 18 18 255";
                oc_Newobject1["fillColorNA"] = "72 12 0  255";
                oc_Newobject1["border"] = new Creator.StringNoQuote("0");
                oc_Newobject1["borderColor"] = "21 21 21 255";
                oc_Newobject1["borderColorHL"] = "72 72 72 255";
                oc_Newobject1["borderColorNA"] = "72 72 72 255";
                oc_Newobject1["fontType"] = "Arial";
                oc_Newobject1["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject1["fontCharset"] = new Creator.StringNoQuote("ANSI");
                oc_Newobject1["fontColor"] = "196 196 196 255";
                oc_Newobject1["fontColorHL"] = "255 255 255 255";
                oc_Newobject1["fontColorNA"] = "128 128 128 255";
                oc_Newobject1["fontColorSEL"] = "196 116 108 255";
                oc_Newobject1["bitmap"] = "";
                oc_Newobject1["bitmapBase"] = "";
                oc_Newobject1["textOffset"] = "0 0";
                oc_Newobject1["modal"] = new Creator.StringNoQuote("true");
                oc_Newobject1["justify"] = "left";
                oc_Newobject1["autoSizeWidth"] = new Creator.StringNoQuote("false");
                oc_Newobject1["autoSizeHeight"] = new Creator.StringNoQuote("false");
                oc_Newobject1["returnTab"] = new Creator.StringNoQuote("false");
                oc_Newobject1["numbersOnly"] = new Creator.StringNoQuote("false");
                oc_Newobject1["cursorColor"] = "0 0 0 255";

                #endregion

                oc_Newobject1.Create();
                }

            if (!Util.isObject("ToolsGuiEditorProfile"))
                {
                #region GuiControlProfile  (ToolsGuiEditorProfile)        oc_Newobject2

                ObjectCreator oc_Newobject2 = new ObjectCreator("GuiControlProfile ", "ToolsGuiEditorProfile");
                oc_Newobject2["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject2["canKeyFocus"] = new Creator.StringNoQuote("false");
                oc_Newobject2["hasBitmapArray"] = new Creator.StringNoQuote("false");
                oc_Newobject2["mouseOverSelected"] = new Creator.StringNoQuote("false");
                oc_Newobject2["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject2["fillColor"] = "32 32 32 255";
                oc_Newobject2["fillColorHL"] = "72 72 72 255";
                oc_Newobject2["fillColorSEL"] = "18 18 18 255";
                oc_Newobject2["fillColorNA"] = "72 12 0  255";
                oc_Newobject2["border"] = new Creator.StringNoQuote("0");
                oc_Newobject2["borderColor"] = "21 21 21 255";
                oc_Newobject2["borderColorHL"] = "72 72 72 255";
                oc_Newobject2["borderColorNA"] = "72 72 72 255";
                oc_Newobject2["fontType"] = "Arial";
                oc_Newobject2["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject2["fontCharset"] = new Creator.StringNoQuote("ANSI");
                oc_Newobject2["fontColor"] = "196 196 196 255";
                oc_Newobject2["fontColorHL"] = "255 255 255 255";
                oc_Newobject2["fontColorNA"] = "128 128 128 255";
                oc_Newobject2["fontColorSEL"] = "196 116 108 255";
                oc_Newobject2["bitmap"] = "";
                oc_Newobject2["bitmapBase"] = "";
                oc_Newobject2["textOffset"] = "0 0";
                oc_Newobject2["modal"] = new Creator.StringNoQuote("true");
                oc_Newobject2["justify"] = "left";
                oc_Newobject2["autoSizeWidth"] = new Creator.StringNoQuote("false");
                oc_Newobject2["autoSizeHeight"] = new Creator.StringNoQuote("false");
                oc_Newobject2["returnTab"] = new Creator.StringNoQuote("false");
                oc_Newobject2["numbersOnly"] = new Creator.StringNoQuote("false");
                oc_Newobject2["cursorColor"] = "0 0 0 255";

                #endregion

                oc_Newobject2.Create();
                }

            if (!Util.isObject("ToolsGuiSolidDefaultProfile"))
                {
                #region GuiControlProfile  (ToolsGuiSolidDefaultProfile)        oc_Newobject3

                ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControlProfile ", "ToolsGuiSolidDefaultProfile");
                oc_Newobject3["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject3["border"] = new Creator.StringNoQuote("false");
                oc_Newobject3["category"] = "Tools";

                #endregion

                oc_Newobject3.Create();
                }

            if (!Util.isObject("ToolsGuiTransparentProfile"))
                {
                #region GuiControlProfile  (ToolsGuiTransparentProfile)        oc_Newobject4

                ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControlProfile ", "ToolsGuiTransparentProfile");
                oc_Newobject4["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject4["border"] = new Creator.StringNoQuote("false");
                oc_Newobject4["category"] = "Tools";

                #endregion

                oc_Newobject4.Create();
                }

            if (!Util.isObject("ToolsGuiGroupBorderProfile"))
                {
                #region GuiControlProfile ( ToolsGuiGroupBorderProfile )        oc_Newobject5

                ObjectCreator oc_Newobject5 = new ObjectCreator("GuiControlProfile", " ToolsGuiGroupBorderProfile ");
                oc_Newobject5["border"] = new Creator.StringNoQuote("false");
                oc_Newobject5["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject5["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject5["bitmap"] = "tools/gui/images/group-border";
                oc_Newobject5["category"] = "Tools";

                #endregion

                oc_Newobject5.Create();
                }

            if (!Util.isObject("ToolsGuiTabBorderProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTabBorderProfile )        oc_Newobject6

                ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControlProfile", " ToolsGuiTabBorderProfile ");
                oc_Newobject6["border"] = new Creator.StringNoQuote("false");
                oc_Newobject6["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject6["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject6["bitmap"] = "tools/gui/images/tab-border";
                oc_Newobject6["category"] = "Tools";

                #endregion

                oc_Newobject6.Create();
                }

            if (!Util.isObject("ToolsGuiToolTipProfile"))
                {
                #region GuiControlProfile  (ToolsGuiToolTipProfile)        oc_Newobject7

                ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControlProfile ", "ToolsGuiToolTipProfile");
                oc_Newobject7["fillColor"] = "72 72 72";
                oc_Newobject7["borderColor"] = "196 196 196 255";
                oc_Newobject7["fontType"] = "Arial";
                oc_Newobject7["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject7["fontColor"] = "255 255 255 255";
                oc_Newobject7["category"] = "Tools";

                #endregion

                oc_Newobject7.Create();
                }

            if (!Util.isObject("ToolsGuiModelessDialogProfile"))
                {
                #region GuiControlProfile ( ToolsGuiModelessDialogProfile )        oc_Newobject8

                ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControlProfile", " ToolsGuiModelessDialogProfile ");
                oc_Newobject8["modal"] = new Creator.StringNoQuote("false");
                oc_Newobject8["category"] = "Tools";

                #endregion

                oc_Newobject8.Create();
                }

            if (!Util.isObject("ToolsGuiFrameSetProfile"))
                {
                #region GuiControlProfile  (ToolsGuiFrameSetProfile)        oc_Newobject9

                ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControlProfile ", "ToolsGuiFrameSetProfile");
                oc_Newobject9["fillcolor"] = "32 32 32 255";
                oc_Newobject9["borderColor"] = "72 72 72";
                oc_Newobject9["opaque"] = "1";
                oc_Newobject9["border"] = new Creator.StringNoQuote("false");
                oc_Newobject9["category"] = "Tools";

                #endregion

                oc_Newobject9.Create();
                }

            if (!Util.isObject("ToolsGuiWindowProfile"))
                {
                #region GuiControlProfile  (ToolsGuiWindowProfile)        oc_Newobject10

                ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControlProfile ", "ToolsGuiWindowProfile");
                oc_Newobject10["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject10["border"] = new Creator.StringNoQuote("2");
                oc_Newobject10["fillColor"] = "32 32 32 255";
                oc_Newobject10["fillColorHL"] = "72 72 72 255";
                oc_Newobject10["fillColorNA"] = "18 18 18 255";
                oc_Newobject10["fontColor"] = "196 196 196 255";
                oc_Newobject10["fontColorHL"] = "255 255 255 255";
                oc_Newobject10["bevelColorHL"] = "255 255 255";
                oc_Newobject10["bevelColorLL"] = "0 0 0";
                oc_Newobject10["text"] = "untitled";
                oc_Newobject10["bitmap"] = "tools/gui/images/window";
                oc_Newobject10["textOffset"] = "8 4";
                oc_Newobject10["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject10["justify"] = "left";
                oc_Newobject10["category"] = "Tools";
                oc_Newobject10["fontColors[0]"] = "196 196 196 255";
                oc_Newobject10["fillColorSEL"] = "72 12 0 255";
                oc_Newobject10["fontColors[1]"] = "255 255 255 255";
                oc_Newobject10["fontColors[2]"] = "18 18 18 255";
                oc_Newobject10["fontColors[3]"] = "196 116 108 255";
                oc_Newobject10["fontColors[4]"] = "160 72 64 255";
                oc_Newobject10["fontColors[5]"] = "196 116 108 255";
                oc_Newobject10["fontColorNA"] = "18 18 18 255";
                oc_Newobject10["fontColorSEL"] = "196 116 108 255";
                oc_Newobject10["fontColorLink"] = "160 72 64 255";
                oc_Newobject10["fontColorLinkHL"] = "196 116 108 255";

                #endregion

                oc_Newobject10.Create();
                }

            if (!Util.isObject("ToolsGuiToolbarWindowProfile"))
                {
                #region GuiControlProfile (ToolsGuiToolbarWindowProfile : ToolsGuiWindowProfile)        oc_Newobject11

                ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControlProfile", "ToolsGuiToolbarWindowProfile : ToolsGuiWindowProfile");
                oc_Newobject11["bitmap"] = "tools/gui/images/toolbar-window";
                oc_Newobject11["text"] = "";
                oc_Newobject11["category"] = "Tools";

                #endregion

                oc_Newobject11.Create();
                }

            if (!Util.isObject("ToolsGuiWindowCollapseProfile"))
                {
                #region GuiControlProfile  (ToolsGuiWindowCollapseProfile : ToolsGuiWindowProfile)        oc_Newobject12

                ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControlProfile ", "ToolsGuiWindowCollapseProfile : ToolsGuiWindowProfile");
                oc_Newobject12["category"] = "Tools";

                #endregion

                oc_Newobject12.Create();
                }

            if (!Util.isObject("ToolsGuiTextProfile"))
                {
                #region GuiControlProfile  (ToolsGuiTextProfile)        oc_Newobject13

                ObjectCreator oc_Newobject13 = new ObjectCreator("GuiControlProfile ", "ToolsGuiTextProfile");
                oc_Newobject13["justify"] = "left";
                oc_Newobject13["fontColor"] = "196 196 196 255";
                oc_Newobject13["category"] = "Tools";
                oc_Newobject13["fontColors[0]"] = "196 196 196 255";
                oc_Newobject13["fontColors[1]"] = "255 255 255 255";
                oc_Newobject13["fontColors[2]"] = "128 128 128 255";
                oc_Newobject13["fontColors[3]"] = "196 116 108 255";
                oc_Newobject13["fontColors[4]"] = "160 72 64 255";
                oc_Newobject13["fontColors[5]"] = "196 116 108 255";
                oc_Newobject13["fontColorHL"] = "255 255 255 255";
                oc_Newobject13["fontColorNA"] = "128 128 128 255";
                oc_Newobject13["fontColorSEL"] = "196 116 108 255";
                oc_Newobject13["fontColorLink"] = "160 72 64 255";
                oc_Newobject13["fontColorLinkHL"] = "196 116 108 255";
                oc_Newobject13["fillColor"] = "32 32 32 255";
                oc_Newobject13["fillColorHL"] = "72 72 72 255";
                oc_Newobject13["fillColorNA"] = "18 18 18 255";
                oc_Newobject13["fillColorSEL"] = "72 12 0 255";

                #endregion

                oc_Newobject13.Create();
                }

            if (!Util.isObject("ToolsGuiTextBoldCenterProfile"))
                {
                #region GuiControlProfile  (ToolsGuiTextBoldCenterProfile : ToolsGuiTextProfile)        oc_Newobject14

                ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControlProfile ", "ToolsGuiTextBoldCenterProfile : ToolsGuiTextProfile");
                oc_Newobject14["fontColor"] = "252 252 252";
                oc_Newobject14["fontType"] = "Arial Bold";
                oc_Newobject14["fontSize"] = new Creator.StringNoQuote("16");
                oc_Newobject14["justify"] = "center";
                oc_Newobject14["category"] = "Tools";

                #endregion

                oc_Newobject14.Create();
                }

            if (!Util.isObject("ToolsGuiTextRightProfile"))
                {
                #region GuiControlProfile  (ToolsGuiTextRightProfile : ToolsGuiTextProfile)        oc_Newobject15

                ObjectCreator oc_Newobject15 = new ObjectCreator("GuiControlProfile ", "ToolsGuiTextRightProfile : ToolsGuiTextProfile");
                oc_Newobject15["justify"] = "right";
                oc_Newobject15["category"] = "Tools";

                #endregion

                oc_Newobject15.Create();
                }

            if (!Util.isObject("ToolsGuiTextCenterProfile"))
                {
                #region GuiControlProfile  (ToolsGuiTextCenterProfile : ToolsGuiTextProfile)        oc_Newobject16

                ObjectCreator oc_Newobject16 = new ObjectCreator("GuiControlProfile ", "ToolsGuiTextCenterProfile : ToolsGuiTextProfile");
                oc_Newobject16["justify"] = "center";
                oc_Newobject16["category"] = "Tools";

                #endregion

                oc_Newobject16.Create();
                }

            if (!Util.isObject("ToolsGuiInspectorTitleTextProfile"))
                {
                #region GuiControlProfile  (ToolsGuiInspectorTitleTextProfile)        oc_Newobject17

                ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControlProfile ", "ToolsGuiInspectorTitleTextProfile");
                oc_Newobject17["fontColor"] = "100 100 100";
                oc_Newobject17["category"] = "Tools";

                #endregion

                oc_Newobject17.Create();
                }

            if (!Util.isObject("ToolsGuiAutoSizeTextProfile"))
                {
                #region GuiControlProfile  (ToolsGuiAutoSizeTextProfile)        oc_Newobject18

                ObjectCreator oc_Newobject18 = new ObjectCreator("GuiControlProfile ", "ToolsGuiAutoSizeTextProfile");
                oc_Newobject18["fontColor"] = "196 196 196 255";
                oc_Newobject18["autoSizeWidth"] = new Creator.StringNoQuote("true");
                oc_Newobject18["autoSizeHeight"] = new Creator.StringNoQuote("true");
                oc_Newobject18["category"] = "Tools";
                oc_Newobject18["fontColors[0]"] = "255 255 255 255";

                #endregion

                oc_Newobject18.Create();
                }

            if (!Util.isObject("ToolsGuiMLTextProfile"))
                {
                #region GuiControlProfile ( ToolsGuiMLTextProfile )        oc_Newobject19

                ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControlProfile", " ToolsGuiMLTextProfile ");
                oc_Newobject19["fontColorLink"] = "160 72 64 255";
                oc_Newobject19["fontColorLinkHL"] = "196 116 108 255";
                oc_Newobject19["autoSizeWidth"] = new Creator.StringNoQuote("true");
                oc_Newobject19["autoSizeHeight"] = new Creator.StringNoQuote("true");
                oc_Newobject19["border"] = new Creator.StringNoQuote("false");
                oc_Newobject19["category"] = "Tools";
                oc_Newobject19["fillColor"] = "32 32 32 255";
                oc_Newobject19["fontColors[0]"] = "196 196 196 255";
                oc_Newobject19["fontColors[1]"] = "255 255 255 255";
                oc_Newobject19["fontColors[2]"] = "128 128 128 255";
                oc_Newobject19["fontColors[3]"] = "196 116 108 255";
                oc_Newobject19["fontColors[4]"] = "160 72 64 255";
                oc_Newobject19["fontColors[5]"] = "196 116 108 255";
                oc_Newobject19["fontColor"] = "196 196 196 255";
                oc_Newobject19["fontColorHL"] = "255 255 255 255";
                oc_Newobject19["fontColorNA"] = "128 128 128 255";
                oc_Newobject19["fontColorSEL"] = "196 116 108 255";
                oc_Newobject19["fillColorHL"] = "72 72 72 255";
                oc_Newobject19["fillColorNA"] = "18 18 18 255";
                oc_Newobject19["fillColorSEL"] = "72 12 0 255";

                #endregion

                oc_Newobject19.Create();
                }

            if (!Util.isObject("ToolsGuiTextArrayProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTextArrayProfile : ToolsGuiTextProfile )        oc_Newobject20

                ObjectCreator oc_Newobject20 = new ObjectCreator("GuiControlProfile", " ToolsGuiTextArrayProfile : ToolsGuiTextProfile ");
                oc_Newobject20["fontColor"] = "50 50 50";
                oc_Newobject20["fontColorHL"] = " 0 0 0";
                oc_Newobject20["fontColorSEL"] = "0 0 0";
                oc_Newobject20["fillColor"] = "200 200 200";
                oc_Newobject20["fillColorHL"] = "228 228 235";
                oc_Newobject20["fillColorSEL"] = "200 200 200";
                oc_Newobject20["border"] = new Creator.StringNoQuote("false");
                oc_Newobject20["category"] = "Tools";

                #endregion

                oc_Newobject20.Create();
                }

            if (!Util.isObject("ToolsGuiTextListProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTextListProfile : ToolsGuiTextProfile )        oc_Newobject21

                ObjectCreator oc_Newobject21 = new ObjectCreator("GuiControlProfile", " ToolsGuiTextListProfile : ToolsGuiTextProfile ");
                oc_Newobject21["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject21["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject21["category"] = "Tools";

                #endregion

                oc_Newobject21.Create();
                }

            if (!Util.isObject("ToolsGuiTextEditProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTextEditProfile )        oc_Newobject22

                ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControlProfile", " ToolsGuiTextEditProfile ");
                oc_Newobject22["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject22["bitmap"] = "tools/gui/images/textEditFrame";
                oc_Newobject22["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject22["border"] = new Creator.StringNoQuote("-2");
                oc_Newobject22["fillColor"] = "21 21 21 255";
                oc_Newobject22["fillColorHL"] = "72 72 72 255";
                oc_Newobject22["fontColor"] = "196 196 196 255";
                oc_Newobject22["fontColorHL"] = "255 255 255";
                oc_Newobject22["fontColorSEL"] = "72 12 0 255";
                oc_Newobject22["fontColorNA"] = "128 128 128 255";
                oc_Newobject22["textOffset"] = "4 2";
                oc_Newobject22["autoSizeWidth"] = new Creator.StringNoQuote("false");
                oc_Newobject22["autoSizeHeight"] = new Creator.StringNoQuote("true");
                oc_Newobject22["justify"] = "left";
                oc_Newobject22["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject22["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject22["category"] = "Tools";
                oc_Newobject22["fontColors[1]"] = "255 255 255 255";
                oc_Newobject22["fontColors[2]"] = "128 128 128 255";
                oc_Newobject22["fontColors[3]"] = "72 12 0 255";
                oc_Newobject22["fillColorNA"] = "18 18 18 0";
                oc_Newobject22["fillColorSEL"] = "72 72 72 255";
                oc_Newobject22["fontColors[0]"] = "196 196 196 255";

                #endregion

                oc_Newobject22.Create();
                }

            if (!Util.isObject("ToolsGuiNumericTextEditProfile"))
                {
                #region GuiControlProfile ( ToolsGuiNumericTextEditProfile : ToolsGuiTextEditProfile )        oc_Newobject23

                ObjectCreator oc_Newobject23 = new ObjectCreator("GuiControlProfile", " ToolsGuiNumericTextEditProfile : ToolsGuiTextEditProfile ");
                oc_Newobject23["numbersOnly"] = new Creator.StringNoQuote("true");
                oc_Newobject23["category"] = "Tools";

                #endregion

                oc_Newobject23.Create();
                }

            if (!Util.isObject("ToolsGuiNumericDropSliderTextProfile"))
                {
                #region GuiControlProfile ( ToolsGuiNumericDropSliderTextProfile : ToolsGuiTextEditProfile )        oc_Newobject24

                ObjectCreator oc_Newobject24 = new ObjectCreator("GuiControlProfile", " ToolsGuiNumericDropSliderTextProfile : ToolsGuiTextEditProfile ");
                oc_Newobject24["bitmap"] = "tools/gui/images/textEditSliderBox";
                oc_Newobject24["category"] = "Tools";

                #endregion

                oc_Newobject24.Create();
                }

            if (!Util.isObject("ToolsGuiRLProgressBitmapProfile"))
                {
                #region GuiControlProfile ( ToolsGuiRLProgressBitmapProfile )        oc_Newobject25

                ObjectCreator oc_Newobject25 = new ObjectCreator("GuiControlProfile", " ToolsGuiRLProgressBitmapProfile ");
                oc_Newobject25["border"] = new Creator.StringNoQuote("false");
                oc_Newobject25["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject25["bitmap"] = "tools/gui/images/rl-loadingbar";
                oc_Newobject25["category"] = "Tools";

                #endregion

                oc_Newobject25.Create();
                }

            if (!Util.isObject("ToolsGuiProgressTextProfile"))
                {
                #region GuiControlProfile ( ToolsGuiProgressTextProfile )        oc_Newobject26

                ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControlProfile", " ToolsGuiProgressTextProfile ");
                oc_Newobject26["fontSize"] = "14";
                oc_Newobject26["fontType"] = "Arial";
                oc_Newobject26["fontColor"] = "196 196 196 255";
                oc_Newobject26["justify"] = "center";
                oc_Newobject26["category"] = "Tools";

                #endregion

                oc_Newobject26.Create();
                }

            if (!Util.isObject("ToolsGuiButtonProfile"))
                {
                #region GuiControlProfile ( ToolsGuiButtonProfile )        oc_Newobject27

                ObjectCreator oc_Newobject27 = new ObjectCreator("GuiControlProfile", " ToolsGuiButtonProfile ");
                oc_Newobject27["opaque"] = "0";
                oc_Newobject27["border"] = "1";
                oc_Newobject27["fontColor"] = "224 224 224 255";
                oc_Newobject27["fontColorHL"] = "255 255 255 255";
                oc_Newobject27["fontColorNA"] = "200 200 200";
                oc_Newobject27["fixedExtent"] = new Creator.StringNoQuote("0");
                oc_Newobject27["justify"] = "center";
                oc_Newobject27["canKeyFocus"] = "1";
                oc_Newobject27["bitmap"] = "tools/gui/images/button";
                oc_Newobject27["hasBitmapArray"] = new Creator.StringNoQuote("false");
                oc_Newobject27["category"] = "Tools";
                oc_Newobject27["fillColor"] = "21 21 21 255";
                oc_Newobject27["fillColorHL"] = "128 128 128 255";
                oc_Newobject27["fillColorNA"] = "24 24 24 255";
                oc_Newobject27["fillColorSEL"] = "90 90 90 255";
                oc_Newobject27["fontColors[0]"] = "224 224 224 255";
                oc_Newobject27["fontColors[2]"] = "200 200 200 255";
                oc_Newobject27["fontColors[1]"] = "255 255 255 255";
                oc_Newobject27["fontColors[4]"] = "160 72 64 255";
                oc_Newobject27["fontColorLink"] = "160 72 64 255";
                oc_Newobject27["fontColors[5]"] = "196 116 108 255";
                oc_Newobject27["fontColorLinkHL"] = "196 116 108 255";

                #endregion

                oc_Newobject27.Create();
                }

            if (!Util.isObject("ToolsGuiThumbHighlightButtonProfile"))
                {
                #region GuiControlProfile ( ToolsGuiThumbHighlightButtonProfile : ToolsGuiButtonProfile )        oc_Newobject28

                ObjectCreator oc_Newobject28 = new ObjectCreator("GuiControlProfile", " ToolsGuiThumbHighlightButtonProfile : ToolsGuiButtonProfile ");
                oc_Newobject28["bitmap"] = "tools/gui/images/thumbHightlightButton";
                oc_Newobject28["category"] = "Tools";

                #endregion

                oc_Newobject28.Create();
                }

            if (!Util.isObject("ToolsGuiIconButtonProfile"))
                {
                #region GuiControlProfile ( ToolsGuiIconButtonProfile )        oc_Newobject29

                ObjectCreator oc_Newobject29 = new ObjectCreator("GuiControlProfile", " ToolsGuiIconButtonProfile ");
                oc_Newobject29["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject29["border"] = new Creator.StringNoQuote("true");
                oc_Newobject29["fontColor"] = "196 196 196";
                oc_Newobject29["fontColorHL"] = "255 255 255";
                oc_Newobject29["fontColorNA"] = "128 128 128";
                oc_Newobject29["fixedExtent"] = new Creator.StringNoQuote("false");
                oc_Newobject29["justify"] = "center";
                oc_Newobject29["canKeyFocus"] = new Creator.StringNoQuote("false");
                oc_Newobject29["bitmap"] = "tools/gui/images/iconbutton";
                oc_Newobject29["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject29["category"] = "Tools";

                #endregion

                oc_Newobject29.Create();
                }

            if (!Util.isObject("ToolsGuiIconButtonSmallProfile"))
                {
                #region GuiControlProfile ( ToolsGuiIconButtonSmallProfile : ToolsGuiIconButtonProfile )        oc_Newobject30

                ObjectCreator oc_Newobject30 = new ObjectCreator("GuiControlProfile", " ToolsGuiIconButtonSmallProfile : ToolsGuiIconButtonProfile ");
                oc_Newobject30["bitmap"] = "tools/gui/images/iconbuttonsmall";
                oc_Newobject30["category"] = "Tools";

                #endregion

                oc_Newobject30.Create();
                }

            if (!Util.isObject("ToolsGuiEditorTabPage"))
                {
                #region GuiControlProfile (ToolsGuiEditorTabPage)        oc_Newobject31

                ObjectCreator oc_Newobject31 = new ObjectCreator("GuiControlProfile", "ToolsGuiEditorTabPage");
                oc_Newobject31["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject31["border"] = new Creator.StringNoQuote("false");
                oc_Newobject31["fontColor"] = "196 196 196 255";
                oc_Newobject31["fontColorHL"] = "255 255 255 255";
                oc_Newobject31["fixedExtent"] = new Creator.StringNoQuote("0");
                oc_Newobject31["justify"] = "center";
                oc_Newobject31["canKeyFocus"] = new Creator.StringNoQuote("false");
                oc_Newobject31["bitmap"] = "tools/gui/images/tab";
                oc_Newobject31["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject31["category"] = "Tools";
                oc_Newobject31["fontColors[1]"] = "255 255 255 255";

                #endregion

                oc_Newobject31.Create();
                }

            if (!Util.isObject("ToolsGuiCheckBoxProfile"))
                {
                #region GuiControlProfile ( ToolsGuiCheckBoxProfile )        oc_Newobject32

                ObjectCreator oc_Newobject32 = new ObjectCreator("GuiControlProfile", " ToolsGuiCheckBoxProfile ");
                oc_Newobject32["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject32["fillColor"] = "21 21 21 255";
                oc_Newobject32["border"] = new Creator.StringNoQuote("false");
                oc_Newobject32["borderColor"] = "100 100 100";
                oc_Newobject32["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject32["fontColor"] = "196 196 196 255";
                oc_Newobject32["fontColorHL"] = "196 196 196 255";
                oc_Newobject32["fontColorNA"] = "128 128 128 255";
                oc_Newobject32["fixedExtent"] = new Creator.StringNoQuote("1");
                oc_Newobject32["justify"] = "left";
                oc_Newobject32["bitmap"] = "tools/gui/images/checkbox";
                oc_Newobject32["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject32["category"] = "Tools";
                oc_Newobject32["fontColors[0]"] = "196 196 196 255";
                oc_Newobject32["fontColors[1]"] = "196 196 196 255";
                oc_Newobject32["fontColors[2]"] = "128 128 128 255";

                #endregion

                oc_Newobject32.Create();
                }

            if (!Util.isObject("ToolsGuiCheckBoxListProfile"))
                {
                #region GuiControlProfile ( ToolsGuiCheckBoxListProfile : ToolsGuiCheckBoxProfile)        oc_Newobject33

                ObjectCreator oc_Newobject33 = new ObjectCreator("GuiControlProfile", " ToolsGuiCheckBoxListProfile : ToolsGuiCheckBoxProfile");
                oc_Newobject33["bitmap"] = "tools/gui/images/checkbox-list";
                oc_Newobject33["category"] = "Tools";
                oc_Newobject33["fillColor"] = "21 21 21 255";

                #endregion

                oc_Newobject33.Create();
                }

            if (!Util.isObject("ToolsGuiCheckBoxListFlipedProfile"))
                {
                #region GuiControlProfile ( ToolsGuiCheckBoxListFlipedProfile : ToolsGuiCheckBoxProfile)        oc_Newobject34

                ObjectCreator oc_Newobject34 = new ObjectCreator("GuiControlProfile", " ToolsGuiCheckBoxListFlipedProfile : ToolsGuiCheckBoxProfile");
                oc_Newobject34["bitmap"] = "tools/gui/images/checkbox-list_fliped";
                oc_Newobject34["category"] = "Tools";
                oc_Newobject34["fillColor"] = "21 21 21 255";

                #endregion

                oc_Newobject34.Create();
                }

            if (!Util.isObject("ToolsGuiInspectorCheckBoxTitleProfile"))
                {
                #region GuiControlProfile ( ToolsGuiInspectorCheckBoxTitleProfile : ToolsGuiCheckBoxProfile )        oc_Newobject35

                ObjectCreator oc_Newobject35 = new ObjectCreator("GuiControlProfile", " ToolsGuiInspectorCheckBoxTitleProfile : ToolsGuiCheckBoxProfile ");
                oc_Newobject35["fontColor"] = "196 196 196 255";
                oc_Newobject35["category"] = "Tools";
                oc_Newobject35["fillColor"] = "32 32 32 255";
                oc_Newobject35["fontColors[0]"] = "196 196 196 255";

                #endregion

                oc_Newobject35.Create();
                }

            if (!Util.isObject("ToolsGuiRadioProfile"))
                {
                #region GuiControlProfile ( ToolsGuiRadioProfile )        oc_Newobject36

                ObjectCreator oc_Newobject36 = new ObjectCreator("GuiControlProfile", " ToolsGuiRadioProfile ");
                oc_Newobject36["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject36["fillColor"] = "32 32 32 255";
                oc_Newobject36["fontColor"] = "196 196 196 255";
                oc_Newobject36["fontColorHL"] = "255 255 255 255";
                oc_Newobject36["fixedExtent"] = new Creator.StringNoQuote("1");
                oc_Newobject36["bitmap"] = "tools/gui/images/radioButton";
                oc_Newobject36["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject36["category"] = "Tools";
                oc_Newobject36["modal"] = "1";
                oc_Newobject36["fontColors[0]"] = "196 196 196 255";
                oc_Newobject36["fontColors[1]"] = "255 255 255 255";

                #endregion

                oc_Newobject36.Create();
                }

            if (!Util.isObject("ToolsGuiScrollProfile"))
                {
                #region GuiControlProfile ( ToolsGuiScrollProfile )        oc_Newobject37

                ObjectCreator oc_Newobject37 = new ObjectCreator("GuiControlProfile", " ToolsGuiScrollProfile ");
                oc_Newobject37["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject37["fillcolor"] = "21 21 21 255";
                oc_Newobject37["fontColor"] = "0 0 0";
                oc_Newobject37["fontColorHL"] = "150 150 150";
                oc_Newobject37["border"] = "1";
                oc_Newobject37["bitmap"] = "tools/gui/images/scrollBar";
                oc_Newobject37["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject37["category"] = "Tools";
                oc_Newobject37["fontColors[0]"] = "0 0 0 255";
                oc_Newobject37["fontColors[1]"] = "150 150 150 255";

                #endregion

                oc_Newobject37.Create();
                }

            if (!Util.isObject("ToolsGuiOverlayProfile"))
                {
                #region GuiControlProfile ( ToolsGuiOverlayProfile )        oc_Newobject00037

                ObjectCreator oc_Newobject00037 = new ObjectCreator("GuiControlProfile", " ToolsGuiOverlayProfile ");
                oc_Newobject00037["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject00037["fillcolor"] = "255 255 255";
                oc_Newobject00037["fontColor"] = "0 0 0";
                oc_Newobject00037["fontColorHL"] = "255 255 255";
                oc_Newobject00037["fillColor"] = "0 0 0 100";
                oc_Newobject00037["category"] = "Tools";

                #endregion

                oc_Newobject00037.Create();
                }

            if (!Util.isObject("ToolsGuiSliderProfile"))
                {
                #region GuiControlProfile ( ToolsGuiSliderProfile )        oc_Newobject00038

                ObjectCreator oc_Newobject00038 = new ObjectCreator("GuiControlProfile", " ToolsGuiSliderProfile ");
                oc_Newobject00038["bitmap"] = "tools/gui/images/slider";
                oc_Newobject00038["category"] = "Tools";

                #endregion

                oc_Newobject00038.Create();
                }

            if (!Util.isObject("ToolsGuiSliderBoxProfile"))
                {
                #region GuiControlProfile ( ToolsGuiSliderBoxProfile )        oc_Newobject00039

                ObjectCreator oc_Newobject00039 = new ObjectCreator("GuiControlProfile", " ToolsGuiSliderBoxProfile ");
                oc_Newobject00039["bitmap"] = "tools/gui/images/slider-w-box";
                oc_Newobject00039["category"] = "Tools";

                #endregion

                oc_Newobject00039.Create();
                }

            if (!Util.isObject("ToolsGuiPopupMenuItemBorder"))
                {
                #region GuiControlProfile ( ToolsGuiPopupMenuItemBorder )        oc_Newobject38

                ObjectCreator oc_Newobject38 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopupMenuItemBorder ");
                oc_Newobject38["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject38["fillcolor"] = "21 21 21 255";
                oc_Newobject38["fontColor"] = "196 196 196 255";
                oc_Newobject38["fontColorHL"] = "255 255 255 255";
                oc_Newobject38["fillColor"] = "0 0 0 100";
                oc_Newobject38["category"] = "Tools";
                oc_Newobject38["canKeyFocus"] = "0";
                oc_Newobject38["fillColorHL"] = "72 72 72 255";
                oc_Newobject38["fillColorNA"] = "18 18 18 255";
                oc_Newobject38["fillColorSEL"] = "116 116 116 255";
                oc_Newobject38["fontColors[0]"] = "196 196 196 255";
                oc_Newobject38["fontColors[1]"] = "255 255 255 255";
                oc_Newobject38["fontColors[2]"] = "128 128 128 255";
                oc_Newobject38["fontColors[4]"] = "160 72 64 255";
                oc_Newobject38["fontColors[5]"] = "196 116 108 255";
                oc_Newobject38["fontColorNA"] = "128 128 128 255";
                oc_Newobject38["fontColorLink"] = "160 72 64 255";
                oc_Newobject38["fontColorLinkHL"] = "196 116 108 255";
                oc_Newobject38["fontColors[3]"] = "255 255 255 255";
                oc_Newobject38["fontColorSEL"] = "255 255 255 255";

                #endregion

                oc_Newobject38.Create();
                }

            if (!Util.isObject("ToolsGuiPopUpMenuEditProfile"))
                {
                #region GuiControlProfile ( ToolsGuiPopUpMenuEditProfile )        oc_Newobject39

                ObjectCreator oc_Newobject39 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopUpMenuEditProfile ");
                oc_Newobject39["bitmap"] = "tools/gui/images/dropDown";
                oc_Newobject39["category"] = "Tools";
                oc_Newobject39["canKeyFocus"] = "1";
                oc_Newobject39["fillColor"] = "21 21 21 255";
                oc_Newobject39["fillColorHL"] = "72 72 72 255";
                oc_Newobject39["fillColorNA"] = "18 18 18 255";
                oc_Newobject39["fillColorSEL"] = "116 116 116 255";
                oc_Newobject39["border"] = "1";
                oc_Newobject39["textOffset"] = "6 4";
                oc_Newobject39["profileForChildren"] = "ToolsGuiPopUpMenuDefault";
                oc_Newobject39["fontColors[0]"] = "196 196 196 255";
                oc_Newobject39["fontColors[1]"] = "255 255 255 255";
                oc_Newobject39["fontColors[2]"] = "128 128 128 255";
                oc_Newobject39["fontColors[4]"] = "160 72 64 255";
                oc_Newobject39["fontColors[5]"] = "196 116 108 255";
                oc_Newobject39["fontColor"] = "196 196 196 255";
                oc_Newobject39["fontColorHL"] = "255 255 255 255";
                oc_Newobject39["fontColorNA"] = "128 128 128 255";
                oc_Newobject39["fontColorLink"] = "160 72 64 255";
                oc_Newobject39["fontColorLinkHL"] = "196 116 108 255";

                #endregion

                oc_Newobject39.Create();
                }

            if (!Util.isObject("ToolsGuiPopUpMenuDefault"))
                {
                #region GuiControlProfile ( ToolsGuiPopUpMenuDefault )        oc_Newobject40

                ObjectCreator oc_Newobject40 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopUpMenuDefault ");
                oc_Newobject40["bitmap"] = "tools/gui/images/scrollBar";
                oc_Newobject40["category"] = "Tools";
                oc_Newobject40["mouseOverSelected"] = "1";
                oc_Newobject40["opaque"] = "1";
                oc_Newobject40["borderThickness"] = "0";
                oc_Newobject40["textOffset"] = "3 3";
                oc_Newobject40["hasBitmapArray"] = "1";
                oc_Newobject40["profileForChildren"] = "ToolsGuiPopupMenuItemBorder";
                oc_Newobject40["fixedExtent"] = "1";
                oc_Newobject40["fillColorHL"] = "72 72 72 255";
                oc_Newobject40["fillColorNA"] = "18 18 18 255";
                oc_Newobject40["fillColorSEL"] = "116 116 116 255";
                oc_Newobject40["fontColors[0]"] = "196 196 196 255";
                oc_Newobject40["fontColors[1]"] = "255 255 255 255";
                oc_Newobject40["fontColors[2]"] = "128 128 128 255";
                oc_Newobject40["fontColors[4]"] = "160 72 64 255";
                oc_Newobject40["fontColors[5]"] = "196 116 108 255";
                oc_Newobject40["fontColor"] = "196 196 196 255";
                oc_Newobject40["fontColorHL"] = "255 255 255 255";
                oc_Newobject40["fontColorNA"] = "128 128 128 255";
                oc_Newobject40["fontColorLink"] = "160 72 64 255";
                oc_Newobject40["fontColorLinkHL"] = "196 116 108 255";

                #endregion

                oc_Newobject40.Create();
                }

            if (!Util.isObject("ToolsGuiPopupMenuItemBorder"))
                {
                #region GuiControlProfile ( ToolsGuiPopupMenuItemBorder : ToolsGuiButtonProfile )        oc_Newobject41

                ObjectCreator oc_Newobject41 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopupMenuItemBorder : ToolsGuiButtonProfile ");
                oc_Newobject41["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject41["border"] = new Creator.StringNoQuote("true");
                oc_Newobject41["fontColor"] = "196 196 196 255";
                oc_Newobject41["fontColorHL"] = "255 255 255 255";
                oc_Newobject41["fontColorNA"] = "128 128 128 255";
                oc_Newobject41["fontColorLink"] = "160 72 64 255";
                oc_Newobject41["fontColorLinkHL"] = "196 116 108 255";
                oc_Newobject41["fixedExtent"] = new Creator.StringNoQuote("false");
                oc_Newobject41["justify"] = "center";
                oc_Newobject41["canKeyFocus"] = new Creator.StringNoQuote("false");
                oc_Newobject41["bitmap"] = "tools/gui/images/button";
                oc_Newobject41["category"] = "Tools";

                #endregion

                oc_Newobject41.Create();
                }

            if (!Util.isObject("ToolsGuiPopUpMenuTabProfile"))
                {
                #region GuiControlProfile ( ToolsGuiPopUpMenuTabProfile : ToolsGuiDefaultProfile )        oc_Newobject42

                ObjectCreator oc_Newobject42 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopUpMenuTabProfile : ToolsGuiDefaultProfile ");
                oc_Newobject42["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject42["mouseOverSelected"] = new Creator.StringNoQuote("true");
                oc_Newobject42["textOffset"] = "6 4";
                oc_Newobject42["border"] = "0";
                oc_Newobject42["borderThickness"] = new Creator.StringNoQuote("0");
                oc_Newobject42["bitmap"] = "tools/gui/images/dropDown-tab";
                oc_Newobject42["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject42["profileForChildren"] = "ToolsGuiPopUpMenuDefault";
                oc_Newobject42["fillColor"] = "21 21 21 255";
                oc_Newobject42["fillColorHL"] = "72 72 72 255";
                oc_Newobject42["fillColorSEL"] = "116 116 116 255";
                oc_Newobject42["borderColor"] = "100 100 100";
                oc_Newobject42["category"] = "Tools";
                oc_Newobject42["canKeyFocus"] = "1";
                oc_Newobject42["fillColorNA"] = "18 18 18 255";
                oc_Newobject42["fontColors[0]"] = "196 196 196 255";
                oc_Newobject42["fontColors[1]"] = "255 255 255 255";
                oc_Newobject42["fontColors[2]"] = "255 255 255 255";
                oc_Newobject42["fontColor"] = "196 196 196 255";
                oc_Newobject42["fontColorNA"] = "255 255 255 255";
                oc_Newobject42["fontColorHL"] = "255 255 255 255";
                oc_Newobject42["fontColorSEL"] = "255 255 255";

                #endregion

                oc_Newobject42.Create();
                }

            if (!Util.isObject("ToolsGuiPopUpMenuProfile"))
                {
                #region GuiControlProfile ( ToolsGuiPopUpMenuProfile : ToolsGuiPopUpMenuDefault )        oc_Newobject43

                ObjectCreator oc_Newobject43 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopUpMenuProfile : ToolsGuiPopUpMenuDefault ");
                oc_Newobject43["textOffset"] = "6 4";
                oc_Newobject43["bitmap"] = "tools/gui/images/dropDown";
                oc_Newobject43["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject43["border"] = new Creator.StringNoQuote("1");
                oc_Newobject43["profileForChildren"] = new Creator.StringNoQuote("ToolsGuiPopUpMenuDefault");
                oc_Newobject43["category"] = "Tools";
                oc_Newobject43["fillColor"] = "21 21 21 255";
                oc_Newobject43["fillColorHL"] = "72 72 72 255";
                oc_Newobject43["fillColorNA"] = "18 18 18 255";
                oc_Newobject43["fillColorSEL"] = "116 116 116 255";
                oc_Newobject43["borderColor"] = "128 128 128 255";
                oc_Newobject43["fontColors[0]"] = "196 196 196 255";
                oc_Newobject43["fontColors[1]"] = "255 255 255 255";
                oc_Newobject43["fontColors[2]"] = "128 128 128 255";
                oc_Newobject43["fontColors[3]"] = "255 255 255 255";
                oc_Newobject43["fontColors[4]"] = "160 72 64 255";
                oc_Newobject43["fontColors[5]"] = "196 116 108 255";
                oc_Newobject43["fontColor"] = "196 196 196 255";
                oc_Newobject43["fontColorHL"] = "255 255 255 255";
                oc_Newobject43["fontColorNA"] = "128 128 128 255";
                oc_Newobject43["fontColorSEL"] = "255 255 255 255";
                oc_Newobject43["fontColorLink"] = "160 72 64 255";
                oc_Newobject43["fontColorLinkHL"] = "196 116 108 255";

                #endregion

                oc_Newobject43.Create();
                }

            if (!Util.isObject("ToolsGuiPopUpMenuTabProfile"))
                {
                #region GuiControlProfile ( ToolsGuiPopUpMenuTabProfile : ToolsGuiPopUpMenuDefault )        oc_Newobject44

                ObjectCreator oc_Newobject44 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopUpMenuTabProfile : ToolsGuiPopUpMenuDefault ");
                oc_Newobject44["bitmap"] = "tools/gui/images/dropDown-tab";
                oc_Newobject44["textOffset"] = "6 4";
                oc_Newobject44["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject44["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject44["border"] = new Creator.StringNoQuote("1");
                oc_Newobject44["profileForChildren"] = new Creator.StringNoQuote("ToolsGuiPopUpMenuDefault");
                oc_Newobject44["category"] = "Tools";
                oc_Newobject44["fontColor"] = "255 255 255 255";
                oc_Newobject44["fontColorHL"] = "255 255 255 255";
                oc_Newobject44["fontColorNA"] = "255 255 255 255";
                oc_Newobject44["fontColorSEL"] = "255 255 255 255";

                #endregion

                oc_Newobject44.Create();
                }

            if (!Util.isObject("ToolsGuiPopUpMenuEditProfile"))
                {
                #region GuiControlProfile ( ToolsGuiPopUpMenuEditProfile : ToolsGuiPopUpMenuDefault )        oc_Newobject45

                ObjectCreator oc_Newobject45 = new ObjectCreator("GuiControlProfile", " ToolsGuiPopUpMenuEditProfile : ToolsGuiPopUpMenuDefault ");
                oc_Newobject45["textOffset"] = "6 4";
                oc_Newobject45["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject45["bitmap"] = "tools/gui/images/dropDown";
                oc_Newobject45["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject45["border"] = new Creator.StringNoQuote("1");
                oc_Newobject45["profileForChildren"] = new Creator.StringNoQuote("ToolsGuiPopUpMenuDefault");
                oc_Newobject45["category"] = "Tools";

                #endregion

                oc_Newobject45.Create();
                }

            if (!Util.isObject("ToolsGuiListBoxProfile"))
                {
                #region GuiControlProfile ( ToolsGuiListBoxProfile )        oc_Newobject46

                ObjectCreator oc_Newobject46 = new ObjectCreator("GuiControlProfile", " ToolsGuiListBoxProfile ");
                oc_Newobject46["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject46["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject46["category"] = "Tools";

                #endregion

                oc_Newobject46.Create();
                }

            if (!Util.isObject("ToolsGuiTabBookProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTabBookProfile )        oc_Newobject47

                ObjectCreator oc_Newobject47 = new ObjectCreator("GuiControlProfile", " ToolsGuiTabBookProfile ");
                oc_Newobject47["fillColorHL"] = "100 100 100";
                oc_Newobject47["fillColorNA"] = "150 150 150";
                oc_Newobject47["fontColor"] = "224 224 224 255";
                oc_Newobject47["fontColorHL"] = "255 255 255 255";
                oc_Newobject47["fontColorNA"] = "64 64 64 255";
                oc_Newobject47["fontType"] = "Arial";
                oc_Newobject47["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject47["justify"] = "center";
                oc_Newobject47["bitmap"] = "tools/gui/images/tab";
                oc_Newobject47["tabWidth"] = new Creator.StringNoQuote("64");
                oc_Newobject47["tabHeight"] = new Creator.StringNoQuote("24");
                oc_Newobject47["tabPosition"] = "Top";
                oc_Newobject47["tabRotation"] = "Horizontal";
                oc_Newobject47["textOffset"] = "0 -3";
                oc_Newobject47["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject47["cankeyfocus"] = new Creator.StringNoQuote("true");
                oc_Newobject47["category"] = "Tools";
                oc_Newobject47["fontColors[0]"] = "224 224 224 255";
                oc_Newobject47["fontColors[2]"] = "64 64 64 255";
                oc_Newobject47["fontColors[3]"] = "255 255 255 255";
                oc_Newobject47["fontColorSEL"] = "255 255 255 255";

                #endregion

                oc_Newobject47.Create();
                }

            if (!Util.isObject("ToolsGuiTabBookNoBitmapProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTabBookNoBitmapProfile : ToolsGuiTabBookProfile )        oc_Newobject48

                ObjectCreator oc_Newobject48 = new ObjectCreator("GuiControlProfile", " ToolsGuiTabBookNoBitmapProfile : ToolsGuiTabBookProfile ");
                oc_Newobject48["bitmap"] = "";
                oc_Newobject48["category"] = "Tools";

                #endregion

                oc_Newobject48.Create();
                }

            if (!Util.isObject("ToolsGuiTabPageProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTabPageProfile : ToolsGuiDefaultProfile )        oc_Newobject49

                ObjectCreator oc_Newobject49 = new ObjectCreator("GuiControlProfile", " ToolsGuiTabPageProfile : ToolsGuiDefaultProfile ");
                oc_Newobject49["fontType"] = "Arial";
                oc_Newobject49["fontSize"] = new Creator.StringNoQuote("10");
                oc_Newobject49["justify"] = "center";
                oc_Newobject49["bitmap"] = "tools/gui/images/tab";
                oc_Newobject49["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject49["fillColor"] = "21 21 21 255";
                oc_Newobject49["category"] = "Tools";

                #endregion

                oc_Newobject49.Create();
                }

            if (!Util.isObject("ToolsGuiTreeViewProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTreeViewProfile )        oc_Newobject50

                ObjectCreator oc_Newobject50 = new ObjectCreator("GuiControlProfile", " ToolsGuiTreeViewProfile ");
                oc_Newobject50["bitmap"] = "tools/gui/images/treeView";
                oc_Newobject50["autoSizeHeight"] = new Creator.StringNoQuote("true");
                oc_Newobject50["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject50["fillColor"] = "21 21 21 255";
                oc_Newobject50["fillColorHL"] = "72 72 72 255";
                oc_Newobject50["fillColorSEL"] = "128 128 128 255";
                oc_Newobject50["fillColorNA"] = "21 21 21 255";
                oc_Newobject50["fontColor"] = "196 196 196 255";
                oc_Newobject50["fontColorHL"] = "255 255 255 255";
                oc_Newobject50["fontColorSEL"] = "255 255 255 255";
                oc_Newobject50["fontColorNA"] = "128 128 128 255";
                oc_Newobject50["borderColor"] = "128 000 000";
                oc_Newobject50["borderColorHL"] = "255 228 235";
                oc_Newobject50["fontSize"] = new Creator.StringNoQuote("14");
                oc_Newobject50["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject50["border"] = new Creator.StringNoQuote("false");
                oc_Newobject50["category"] = "Tools";
                oc_Newobject50["fontColors[0]"] = "196 196 196 255";
                oc_Newobject50["fontColors[1]"] = "255 255 255 255";
                oc_Newobject50["fontColors[2]"] = "128 128 128 255";
                oc_Newobject50["fontColors[3]"] = "255 255 255 255";

                #endregion

                oc_Newobject50.Create();
                }

            if (!Util.isObject("ToolsGuiTextPadProfile"))
                {
                #region GuiControlProfile ( ToolsGuiTextPadProfile )        oc_Newobject51

                ObjectCreator oc_Newobject51 = new ObjectCreator("GuiControlProfile", " ToolsGuiTextPadProfile ");
                oc_Newobject51["fontType"] = "Lucida Console";
                oc_Newobject51["fontSize"] = "12";
                oc_Newobject51["tab"] = new Creator.StringNoQuote("true");
                oc_Newobject51["canKeyFocus"] = new Creator.StringNoQuote("true");
                oc_Newobject51["opaque"] = new Creator.StringNoQuote("true");
                oc_Newobject51["fillColor"] = "21 21 21 255";
                oc_Newobject51["border"] = new Creator.StringNoQuote("0");
                oc_Newobject51["category"] = "Tools";

                #endregion

                oc_Newobject51.Create();
                }

            if (!Util.isObject("ToolsGuiFormProfile"))
                {
                #region GuiControlProfile ( ToolsGuiFormProfile : ToolsGuiTextProfile )        oc_Newobject52

                ObjectCreator oc_Newobject52 = new ObjectCreator("GuiControlProfile", " ToolsGuiFormProfile : ToolsGuiTextProfile ");
                oc_Newobject52["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject52["border"] = new Creator.StringNoQuote("5");
                oc_Newobject52["justify"] = "center";
                oc_Newobject52["profileForChildren"] = new Creator.StringNoQuote("ToolsGuiButtonProfile");
                oc_Newobject52["opaque"] = new Creator.StringNoQuote("false");
                oc_Newobject52["hasBitmapArray"] = new Creator.StringNoQuote("true");
                oc_Newobject52["bitmap"] = "tools/gui/images/button";
                oc_Newobject52["category"] = "Tools";

                #endregion

                oc_Newobject52.Create();
                }

            #region GuiControlProfile ( GuiEditorClassProfile )        oc_Newobject53

            SingletonCreator oc_Newobject53 = new SingletonCreator("GuiControlProfile", " GuiEditorClassProfile ");
            oc_Newobject53["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject53["fillColor"] = "32 32 32 255";
            oc_Newobject53["border"] = new Creator.StringNoQuote("0");
            oc_Newobject53["borderColor"] = "40 40 40 140";
            oc_Newobject53["borderColorHL"] = "127 127 127";
            oc_Newobject53["fontColor"] = "196 196 196 255";
            oc_Newobject53["fontColorHL"] = "255 255 255 255";
            oc_Newobject53["fixedExtent"] = new Creator.StringNoQuote("true");
            oc_Newobject53["justify"] = "center";
            oc_Newobject53["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject53["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject53["category"] = "Editor";

            #endregion

            oc_Newobject53.Create();

            #region GuiControlProfile ( GuiBackFillProfile )        oc_Newobject54

            SingletonCreator oc_Newobject54 = new SingletonCreator("GuiControlProfile", " GuiBackFillProfile ");
            oc_Newobject54["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject54["fillColor"] = "36 36 36 255";
            oc_Newobject54["border"] = new Creator.StringNoQuote("false");
            oc_Newobject54["borderColor"] = "255 128 128";
            oc_Newobject54["fontType"] = "Arial";
            oc_Newobject54["fontSize"] = new Creator.StringNoQuote("12");
            oc_Newobject54["fontColor"] = "196 196 196 255";
            oc_Newobject54["fontColorHL"] = "255 255 255 255";
            oc_Newobject54["fixedExtent"] = new Creator.StringNoQuote("true");
            oc_Newobject54["justify"] = "center";
            oc_Newobject54["category"] = "Editor";

            #endregion

            oc_Newobject54.Create();

            #region GuiControlProfile ( GuiControlListPopupProfile )        oc_Newobject55

            SingletonCreator oc_Newobject55 = new SingletonCreator("GuiControlProfile", " GuiControlListPopupProfile ");
            oc_Newobject55["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject55["fillColor"] = "32 32 32 255";
            oc_Newobject55["fillColorHL"] = "72 72 72 255";
            oc_Newobject55["border"] = new Creator.StringNoQuote("false");
            oc_Newobject55["fontColor"] = "196 196 196 255";
            oc_Newobject55["fontColorHL"] = "255 255 255 255";
            oc_Newobject55["fontColorNA"] = "128 128 128 255";
            oc_Newobject55["textOffset"] = "0 2";
            oc_Newobject55["autoSizeWidth"] = new Creator.StringNoQuote("false");
            oc_Newobject55["autoSizeHeight"] = new Creator.StringNoQuote("true");
            oc_Newobject55["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject55["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject55["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject55["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject55["category"] = "Editor";

            #endregion

            oc_Newobject55.Create();

            #region GuiControlProfile ( GuiSceneGraphEditProfile )        oc_Newobject56

            SingletonCreator oc_Newobject56 = new SingletonCreator("GuiControlProfile", " GuiSceneGraphEditProfile ");
            oc_Newobject56["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject56["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject56["category"] = "Editor";

            #endregion

            oc_Newobject56.Create();

            #region GuiControlProfile ( GuiPreviewBackgroundProfile )        oc_Newobject57

            SingletonCreator oc_Newobject57 = new SingletonCreator("GuiControlProfile", " GuiPreviewBackgroundProfile ");
            oc_Newobject57["borderColor"] = "21 21 21 255";
            oc_Newobject57["borderColorNA"] = "72 72 72 255";
            oc_Newobject57["fillColorNA"] = "36 36 36 0";
            oc_Newobject57["borderColorHL"] = "0 0 0 255";
            oc_Newobject57["bitmap"] = "tools/gui/images/preview_grid";
            oc_Newobject57["category"] = "Editor";

            #endregion

            oc_Newobject57.Create();

            #region GuiControlProfile ( GuiInspectorButtonProfile : ToolsGuiButtonProfile )        oc_Newobject58

            SingletonCreator oc_Newobject58 = new SingletonCreator("GuiControlProfile", " GuiInspectorButtonProfile : ToolsGuiButtonProfile ");
            oc_Newobject58["justify"] = "Center";
            oc_Newobject58["category"] = "Editor";

            #endregion

            oc_Newobject58.Create();

            #region GuiControlProfile ( GuiInspectorSwatchButtonProfile )        oc_Newobject59

            SingletonCreator oc_Newobject59 = new SingletonCreator("GuiControlProfile", " GuiInspectorSwatchButtonProfile ");
            oc_Newobject59["borderColor"] = "100 100 100 255";
            oc_Newobject59["borderColorNA"] = "200 200 200 255";
            oc_Newobject59["fillColorNA"] = "255 255 255 0";
            oc_Newobject59["borderColorHL"] = "0 0 0 255";
            oc_Newobject59["category"] = "Editor";

            #endregion

            oc_Newobject59.Create();

            #region GuiControlProfile ( GuiInspectorTextEditProfile )        oc_Newobject60

            SingletonCreator oc_Newobject60 = new SingletonCreator("GuiControlProfile", " GuiInspectorTextEditProfile ");
            oc_Newobject60["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject60["fillColor"] = "21 21 21 0";
            oc_Newobject60["fillColorHL"] = "72 72 72 255";
            oc_Newobject60["border"] = new Creator.StringNoQuote("false");
            oc_Newobject60["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject60["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject60["fontType"] = "Arial";
            oc_Newobject60["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject60["fontColor"] = "196 196 196 255";
            oc_Newobject60["fontColorSEL"] = "196 116 108 255";
            oc_Newobject60["fontColorHL"] = "255 255 255 255";
            oc_Newobject60["fontColorNA"] = "128 128 128 255";
            oc_Newobject60["category"] = "Editor";

            #endregion

            oc_Newobject60.Create();

            #region GuiControlProfile ( GuiDropdownTextEditProfile :  ToolsGuiTextEditProfile )        oc_Newobject61

            SingletonCreator oc_Newobject61 = new SingletonCreator("GuiControlProfile", " GuiDropdownTextEditProfile :  ToolsGuiTextEditProfile ");
            oc_Newobject61["bitmap"] = "tools/gui/images/dropdown-textEdit";
            oc_Newobject61["category"] = "Editor";

            #endregion

            oc_Newobject61.Create();

            #region GuiControlProfile ( GuiInspectorTextEditRightProfile : GuiInspectorTextEditProfile )        oc_Newobject62

            SingletonCreator oc_Newobject62 = new SingletonCreator("GuiControlProfile", " GuiInspectorTextEditRightProfile : GuiInspectorTextEditProfile ");
            oc_Newobject62["justify"] = "right";
            oc_Newobject62["category"] = "Editor";

            #endregion

            oc_Newobject62.Create();

            #region GuiControlProfile ( GuiInspectorGroupProfile )        oc_Newobject63

            SingletonCreator oc_Newobject63 = new SingletonCreator("GuiControlProfile", " GuiInspectorGroupProfile ");
            oc_Newobject63["fontType"] = "Arial";
            oc_Newobject63["fontSize"] = "14";
            oc_Newobject63["fillColor"] = "32 32 32 255";
            oc_Newobject63["fillColorHL"] = "72 72 72 255";
            oc_Newobject63["fontColor"] = "196 196 196 255";
            oc_Newobject63["fontColorSEL"] = "196 116 108 255";
            oc_Newobject63["fontColorHL"] = "255 255 255 255";
            oc_Newobject63["fontColorNA"] = "128 128 128 255";
            oc_Newobject63["justify"] = "left";
            oc_Newobject63["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject63["border"] = new Creator.StringNoQuote("false");
            oc_Newobject63["bitmap"] = "tools/editorclasses/gui/images/rollout";
            oc_Newobject63["textOffset"] = "20 0";
            oc_Newobject63["category"] = "Editor";

            #endregion

            oc_Newobject63.Create();

            #region GuiControlProfile ( GuiInspectorFieldProfile)        oc_Newobject64

            SingletonCreator oc_Newobject64 = new SingletonCreator("GuiControlProfile", " GuiInspectorFieldProfile");
            oc_Newobject64["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject64["fillColor"] = "21 21 21 255";
            oc_Newobject64["fillColorHL"] = "64 64 64 255";
            oc_Newobject64["fillColorNA"] = "19 19 19 255";
            oc_Newobject64["border"] = new Creator.StringNoQuote("false");
            oc_Newobject64["borderColor"] = "190 190 190";
            oc_Newobject64["borderColorHL"] = "156 156 156";
            oc_Newobject64["borderColorNA"] = "200 200 200";
            oc_Newobject64["fontType"] = "Arial";
            oc_Newobject64["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject64["fontColor"] = "196 196 196 255";
            oc_Newobject64["fontColorSEL"] = "196 116 108 255";
            oc_Newobject64["fontColorHL"] = "255 255 255 255";
            oc_Newobject64["fontColorNA"] = "128 128 128 255";
            oc_Newobject64["textOffset"] = "10 0";
            oc_Newobject64["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject64["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject64["category"] = "Editor";

            #endregion

            oc_Newobject64.Create();

            #region GuiControlProfile ( GuiInspectorMultiFieldDifferentProfile : GuiInspectorFieldProfile )        oc_Newobject65

            SingletonCreator oc_Newobject65 = new SingletonCreator("GuiControlProfile", " GuiInspectorMultiFieldDifferentProfile : GuiInspectorFieldProfile ");
            oc_Newobject65["border"] = new Creator.StringNoQuote("false");
            oc_Newobject65["borderColor"] = "21 21 21 255";

            #endregion

            oc_Newobject65.Create();

            #region GuiControlProfile ( GuiInspectorDynamicFieldProfile : GuiInspectorFieldProfile )        oc_Newobject66

            SingletonCreator oc_Newobject66 = new SingletonCreator("GuiControlProfile", " GuiInspectorDynamicFieldProfile : GuiInspectorFieldProfile ");
            oc_Newobject66["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject66["fillColor"] = "21 21 21 0";
            oc_Newobject66["fillColorHL"] = "72 72 72 255";
            oc_Newobject66["border"] = new Creator.StringNoQuote("false");
            oc_Newobject66["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject66["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject66["fontType"] = "Arial";
            oc_Newobject66["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject66["fontColor"] = "196 196 196 255";
            oc_Newobject66["fontColorSEL"] = "196 116 108 255";
            oc_Newobject66["fontColorHL"] = "255 255 255 255";
            oc_Newobject66["fontColorNA"] = "128 128 128 255";
            oc_Newobject66["category"] = "Editor";

            #endregion

            oc_Newobject66.Create();

            #region GuiControlProfile ( GuiRolloutProfile )        oc_Newobject67

            SingletonCreator oc_Newobject67 = new SingletonCreator("GuiControlProfile", " GuiRolloutProfile ");
            oc_Newobject67["border"] = new Creator.StringNoQuote("0");
            oc_Newobject67["borderColor"] = "200 200 200";
            oc_Newobject67["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject67["bitmap"] = "tools/editorClasses/gui/images/rollout";
            oc_Newobject67["textoffset"] = "17 0";
            oc_Newobject67["category"] = "Editor";

            #endregion

            oc_Newobject67.Create();

            #region GuiControlProfile ( GuiInspectorRolloutProfile0 )        oc_Newobject68

            SingletonCreator oc_Newobject68 = new SingletonCreator("GuiControlProfile", " GuiInspectorRolloutProfile0 ");
            oc_Newobject68["fontType"] = "Arial";
            oc_Newobject68["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject68["fillColor"] = "21 21 21 255";
            oc_Newobject68["fillColorHL"] = "72 72 72 255";
            oc_Newobject68["fontColor"] = "196 196 196 255";
            oc_Newobject68["fontColorSEL"] = "196 116 108 255";
            oc_Newobject68["fontColorHL"] = "255 255 255 255";
            oc_Newobject68["fontColorNA"] = "128 128 128 255";
            oc_Newobject68["justify"] = "left";
            oc_Newobject68["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject68["border"] = new Creator.StringNoQuote("0");
            oc_Newobject68["borderColor"] = "72 72 72";
            oc_Newobject68["borderColorHL"] = "72 72 72";
            oc_Newobject68["borderColorNA"] = "72 72 72";
            oc_Newobject68["bitmap"] = "tools/editorclasses/gui/images/rollout_plusminus_header";
            oc_Newobject68["textOffset"] = "20 0";
            oc_Newobject68["category"] = "Editor";

            #endregion

            oc_Newobject68.Create();

            #region GuiControlProfile ( GuiInspectorStackProfile )        oc_Newobject69

            SingletonCreator oc_Newobject69 = new SingletonCreator("GuiControlProfile", " GuiInspectorStackProfile ");
            oc_Newobject69["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject69["border"] = new Creator.StringNoQuote("false");
            oc_Newobject69["category"] = "Editor";

            #endregion

            oc_Newobject69.Create();

            #region GuiControlProfile ( GuiInspectorProfile  : GuiInspectorFieldProfile )        oc_Newobject70

            SingletonCreator oc_Newobject70 = new SingletonCreator("GuiControlProfile", " GuiInspectorProfile  : GuiInspectorFieldProfile ");
            oc_Newobject70["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject70["fillColor"] = "21 21 21 255";
            oc_Newobject70["border"] = new Creator.StringNoQuote("0");
            oc_Newobject70["cankeyfocus"] = new Creator.StringNoQuote("true");
            oc_Newobject70["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject70["category"] = "Editor";

            #endregion

            oc_Newobject70.Create();

            #region GuiControlProfile ( GuiInspectorInfoProfile  : GuiInspectorFieldProfile )        oc_Newobject71

            SingletonCreator oc_Newobject71 = new SingletonCreator("GuiControlProfile", " GuiInspectorInfoProfile  : GuiInspectorFieldProfile ");
            oc_Newobject71["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject71["fillColor"] = "21 21 21 255";
            oc_Newobject71["border"] = new Creator.StringNoQuote("0");
            oc_Newobject71["cankeyfocus"] = new Creator.StringNoQuote("true");
            oc_Newobject71["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject71["category"] = "Editor";

            #endregion

            oc_Newobject71.Create();

            #region GuiControlProfile ( GuiInspectorBackgroundProfile : GuiInspectorFieldProfile )        oc_Newobject72

            SingletonCreator oc_Newobject72 = new SingletonCreator("GuiControlProfile", " GuiInspectorBackgroundProfile : GuiInspectorFieldProfile ");
            oc_Newobject72["border"] = new Creator.StringNoQuote("0");
            oc_Newobject72["cankeyfocus"] = new Creator.StringNoQuote("true");
            oc_Newobject72["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject72["category"] = "Editor";

            #endregion

            oc_Newobject72.Create();

            #region GuiControlProfile ( GuiInspectorTypeFileNameProfile )        oc_Newobject73

            SingletonCreator oc_Newobject73 = new SingletonCreator("GuiControlProfile", " GuiInspectorTypeFileNameProfile ");
            oc_Newobject73["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject73["border"] = new Creator.StringNoQuote("0");
            oc_Newobject73["tab"] = new Creator.StringNoQuote("true");
            oc_Newobject73["canKeyFocus"] = new Creator.StringNoQuote("true");
            oc_Newobject73["fontType"] = "Arial";
            oc_Newobject73["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject73["justify"] = "center";
            oc_Newobject73["fillColor"] = "21 21 21 255";
            oc_Newobject73["fillColorHL"] = "72 72 72 255";
            oc_Newobject73["fontColor"] = "196 196 196 255";
            oc_Newobject73["fontColorSEL"] = "196 116 108 255";
            oc_Newobject73["fontColorHL"] = "255 255 255 255";
            oc_Newobject73["fontColorNA"] = "128 128 128 255";
            oc_Newobject73["borderColor"] = "72 72 72";
            oc_Newobject73["borderColorHL"] = "72 72 72";
            oc_Newobject73["borderColorNA"] = "72 72 72";
            oc_Newobject73["category"] = "Editor";

            #endregion

            oc_Newobject73.Create();

            #region GuiControlProfile ( GuiInspectorColumnCtrlProfile : GuiInspectorFieldProfile )        oc_Newobject74

            SingletonCreator oc_Newobject74 = new SingletonCreator("GuiControlProfile", " GuiInspectorColumnCtrlProfile : GuiInspectorFieldProfile ");
            oc_Newobject74["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject74["fillColor"] = "210 210 210 255";
            oc_Newobject74["border"] = new Creator.StringNoQuote("0");
            oc_Newobject74["category"] = "Editor";

            #endregion

            oc_Newobject74.Create();

            #region GuiControlProfile ( InspectorTypeEnumProfile : GuiInspectorFieldProfile )        oc_Newobject75

            SingletonCreator oc_Newobject75 = new SingletonCreator("GuiControlProfile", " InspectorTypeEnumProfile : GuiInspectorFieldProfile ");
            oc_Newobject75["mouseOverSelected"] = new Creator.StringNoQuote("true");
            oc_Newobject75["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject75["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject75["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject75["border"] = new Creator.StringNoQuote("false");
            oc_Newobject75["textOffset"] = "4 0";
            oc_Newobject75["category"] = "Editor";

            #endregion

            oc_Newobject75.Create();

            #region GuiControlProfile ( InspectorTypeCheckboxProfile : GuiInspectorFieldProfile )        oc_Newobject76

            SingletonCreator oc_Newobject76 = new SingletonCreator("GuiControlProfile", " InspectorTypeCheckboxProfile : GuiInspectorFieldProfile ");
            oc_Newobject76["bitmap"] = "tools/gui/images/checkBox";
            oc_Newobject76["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject76["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject76["border"] = new Creator.StringNoQuote("false");
            oc_Newobject76["textOffset"] = "4 0";
            oc_Newobject76["category"] = "Editor";

            #endregion

            oc_Newobject76.Create();

            #region GuiControlProfile ( GuiToolboxButtonProfile : ToolsGuiButtonProfile )        oc_Newobject77

            SingletonCreator oc_Newobject77 = new SingletonCreator("GuiControlProfile", " GuiToolboxButtonProfile : ToolsGuiButtonProfile ");
            oc_Newobject77["justify"] = "center";
            oc_Newobject77["fontColor"] = "196 196 196 255";
            oc_Newobject77["fontColorHL"] = "255 255 255 255";
            oc_Newobject77["fontColorNA"] = "128 128 128 255";
            oc_Newobject77["fontColorLink"] = "160 72 64 255";
            oc_Newobject77["fontColorLinkHL"] = "196 116 108 255";
            oc_Newobject77["border"] = new Creator.StringNoQuote("0");
            oc_Newobject77["textOffset"] = "0 0";
            oc_Newobject77["category"] = "Editor";

            #endregion

            oc_Newobject77.Create();

            #region GuiControlProfile ( GuiDirectoryTreeProfile : ToolsGuiTreeViewProfile )        oc_Newobject78

            SingletonCreator oc_Newobject78 = new SingletonCreator("GuiControlProfile", " GuiDirectoryTreeProfile : ToolsGuiTreeViewProfile ");
            oc_Newobject78["fillColor"] = "21 21 21 255";
            oc_Newobject78["fillColorHL"] = "72 72 72 255";
            oc_Newobject78["fontColor"] = "196 196 196 255";
            oc_Newobject78["fontColorSEL"] = "196 116 108 255";
            oc_Newobject78["fontColorHL"] = "255 255 255 255";
            oc_Newobject78["fontColorNA"] = "128 128 128 255";
            oc_Newobject78["fontType"] = "Arial";
            oc_Newobject78["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject78["category"] = "Editor";

            #endregion

            oc_Newobject78.Create();

            #region GuiControlProfile ( GuiDirectoryFileListProfile )        oc_Newobject79

            SingletonCreator oc_Newobject79 = new SingletonCreator("GuiControlProfile", " GuiDirectoryFileListProfile ");
            oc_Newobject79["fillColor"] = "21 21 21 255";
            oc_Newobject79["fillColorHL"] = "72 72 72 255";
            oc_Newobject79["fontColor"] = "196 196 196 255";
            oc_Newobject79["fontColorSEL"] = "196 116 108 255";
            oc_Newobject79["fontColorHL"] = "255 255 255 255";
            oc_Newobject79["fontColorNA"] = "128 128 128 255";
            oc_Newobject79["fontType"] = "Arial";
            oc_Newobject79["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject79["category"] = "Editor";

            #endregion

            oc_Newobject79.Create();

            #region GuiControlProfile ( GuiDragAndDropProfile )        oc_Newobject80

            SingletonCreator oc_Newobject80 = new SingletonCreator("GuiControlProfile", " GuiDragAndDropProfile ");
            oc_Newobject80["category"] = "Editor";

            #endregion

            oc_Newobject80.Create();

            #region GuiControlProfile ( GuiInspectorFieldInfoPaneProfile )        oc_Newobject81

            SingletonCreator oc_Newobject81 = new SingletonCreator("GuiControlProfile", " GuiInspectorFieldInfoPaneProfile ");
            oc_Newobject81["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject81["fillcolor"] = new Creator.StringNoQuote("GuiInspectorBackgroundProfile.fillColor");
            oc_Newobject81["borderColor"] = new Creator.StringNoQuote("ToolsGuiDefaultProfile.borderColor");
            oc_Newobject81["border"] = new Creator.StringNoQuote("0");
            oc_Newobject81["category"] = "Editor";

            #endregion

            oc_Newobject81.Create();

            #region GuiControlProfile ( GuiInspectorFieldInfoMLTextProfile : ToolsGuiMLTextProfile )        oc_Newobject82

            SingletonCreator oc_Newobject82 = new SingletonCreator("GuiControlProfile", " GuiInspectorFieldInfoMLTextProfile : ToolsGuiMLTextProfile ");
            oc_Newobject82["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject82["border"] = new Creator.StringNoQuote("0");
            oc_Newobject82["textOffset"] = "5 0";
            oc_Newobject82["category"] = "Editor";

            #endregion

            oc_Newobject82.Create();

            #region GuiControlProfile ( GuiEditorScrollProfile )        oc_Newobject83

            SingletonCreator oc_Newobject83 = new SingletonCreator("GuiControlProfile", " GuiEditorScrollProfile ");
            oc_Newobject83["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject83["fillcolor"] = new Creator.StringNoQuote("GuiInspectorBackgroundProfile.fillColor");
            oc_Newobject83["borderColor"] = new Creator.StringNoQuote("ToolsGuiDefaultProfile.borderColor");
            oc_Newobject83["border"] = new Creator.StringNoQuote("0");
            oc_Newobject83["bitmap"] = "tools/gui/images/scrollBar";
            oc_Newobject83["hasBitmapArray"] = new Creator.StringNoQuote("true");
            oc_Newobject83["category"] = "Editor";

            #endregion

            oc_Newobject83.Create();

            #region GuiControlProfile ( GuiCreatorIconButtonProfile )        oc_Newobject84

            SingletonCreator oc_Newobject84 = new SingletonCreator("GuiControlProfile", " GuiCreatorIconButtonProfile ");
            oc_Newobject84["opaque"] = new Creator.StringNoQuote("true");
            oc_Newobject84["fillColor"] = "64 64 64 255";
            oc_Newobject84["fillColorHL"] = "128 128 128 255";
            oc_Newobject84["fillColorNA"] = "21 21 21 255";
            oc_Newobject84["fillColorSEL"] = "72 72 72 255";
            oc_Newobject84["fontType"] = "Arial";
            oc_Newobject84["fontSize"] = new Creator.StringNoQuote("14");
            oc_Newobject84["fontColor"] = "196 196 196 255";
            oc_Newobject84["fontColorSEL"] = "212 212 212 255";
            oc_Newobject84["fontColorHL"] = "255 255 255 255";
            oc_Newobject84["fontColorNA"] = "128 128 128 255";
            oc_Newobject84["border"] = new Creator.StringNoQuote("false");
            oc_Newobject84["borderColor"] = "72 72 72 0";
            oc_Newobject84["borderColorHL"] = "72 72 72 0";
            oc_Newobject84["borderColorNA"] = "72 72 72 0";
            oc_Newobject84["category"] = "Editor";

            #endregion

            oc_Newobject84.Create();
        }
    }
}