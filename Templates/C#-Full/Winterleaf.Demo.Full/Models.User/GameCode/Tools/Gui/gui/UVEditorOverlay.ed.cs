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
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<UVEditorOverlay>))]
    public class UVEditorOverlay : GuiControl
    {
        [ConsoleInteraction(true, "UVEditorOverlay_initialize")]
        public static void initialize()
        {
            #region GuiControl (UVEditorOverlay, EditorGuiGroup)        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "UVEditorOverlay, EditorGuiGroup", typeof (UVEditorOverlay));
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "0 0";
            oc_Newobject26["Extent"] = "1024 768";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["hovertime"] = "1000";

            #region GuiWindowCtrl (UVEditor)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiWindowCtrl", "UVEditor", typeof (UVEditor));
            oc_Newobject25["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject25["HorizSizing"] = "center";
            oc_Newobject25["VertSizing"] = "center";
            oc_Newobject25["resizeWidth"] = "0";
            oc_Newobject25["resizeHeight"] = "0";
            oc_Newobject25["canClose"] = "1";
            oc_Newobject25["canMinimize"] = "0";
            oc_Newobject25["canMaximize"] = "0";
            oc_Newobject25["position"] = "72 98";
            oc_Newobject25["extent"] = " 453 340";
            oc_Newobject25["MinExtent"] = "453 340";
            oc_Newobject25["text"] = "UV Editor";
            oc_Newobject25["closeCommand"] = "UVEditor.hideDialog();";
            oc_Newobject25["EdgeSnap"] = "0";
            oc_Newobject25["canCollapse"] = "0";
            oc_Newobject25["visible"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "0.0";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "26 24";
            oc_Newobject1["Extent"] = "32 14";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject25["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["text"] = "U";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "138 24";
            oc_Newobject2["Extent"] = "32 14";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject25["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "1.0";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "250 24";
            oc_Newobject3["Extent"] = "32 14";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject25["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "0.0";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "4 36";
            oc_Newobject4["Extent"] = "18 14";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject25["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "V";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "4 159";
            oc_Newobject5["Extent"] = "18 14";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject25["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "1.0";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "4 282";
            oc_Newobject6["Extent"] = "18 14";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject25["#Newobject6"] = oc_Newobject6;

            #region GuiControl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "");
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject7["position"] = "25 37";
            oc_Newobject7["extent"] = "258 258";

            #endregion

            oc_Newobject25["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject8["internalName"] = "bitmapPreview";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["position"] = "26 38";
            oc_Newobject8["extent"] = "256 256";
            oc_Newobject8["wrap"] = "0";
            oc_Newobject8["bitmap"] = "";

            #endregion

            oc_Newobject25["#Newobject8"] = oc_Newobject8;

            #region GuiRectHandles ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiRectHandles", "", typeof (UVEditorRectHandles));
            oc_Newobject9["internalName"] = "uvHandles";
            //oc_Newobject9["class"] = "UVEditorRectHandles";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "26 38";
            oc_Newobject9["extent"] = "256 256";

            #endregion

            oc_Newobject25["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapBorderCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject12["profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject12["horizSizing"] = "width";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "26 300";
            oc_Newobject12["extent"] = "256 30";
            oc_Newobject12["minExtent"] = "0 0";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["setFirstResponder"] = "0";
            oc_Newobject12["modal"] = "1";
            oc_Newobject12["helpTag"] = "0";

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["text"] = "Handle Color:";
            oc_Newobject10["maxLength"] = "1024";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "10 7";
            oc_Newobject10["Extent"] = "70 14";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiPopupMenuCtrlEx ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiPopupMenuCtrlEx", "");
            oc_Newobject11["internalName"] = "colorPopup";
            oc_Newobject11["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject11["Position"] = "80 5";
            oc_Newobject11["Extent"] = "126 20";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Command"] = "UVEditor.onColorSelect();";
            oc_Newobject11["reverseTextList"] = "0";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject25["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapBorderCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject22["profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject22["horizSizing"] = "width";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["position"] = "292 38";
            oc_Newobject22["extent"] = "151 256";
            oc_Newobject22["minExtent"] = "0 0";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["setFirstResponder"] = "0";
            oc_Newobject22["modal"] = "1";
            oc_Newobject22["helpTag"] = "0";

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["text"] = "U:";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "10 12";
            oc_Newobject13["Extent"] = "32 14";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject13"] = oc_Newobject13;

            #region GuiTextEditCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextEditCtrl", "", typeof (UVEditorUVTextEdit));
            oc_Newobject14["internalName"] = "UVX";
            //oc_Newobject14["class"] = "UVEditorUVTextEdit";
            oc_Newobject14["historySize"] = "0";
            oc_Newobject14["password"] = "0";
            oc_Newobject14["tabComplete"] = "0";
            oc_Newobject14["sinkAllKeyEvents"] = "0";
            oc_Newobject14["passwordMask"] = "*";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "44 10";
            oc_Newobject14["Extent"] = "64 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject22["#Newobject14"] = oc_Newobject14;

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["text"] = "V:";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "10 32";
            oc_Newobject15["Extent"] = "32 14";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject15"] = oc_Newobject15;

            #region GuiTextEditCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextEditCtrl", "", typeof (UVEditorUVTextEdit));
            oc_Newobject16["internalName"] = "UVY";
            //oc_Newobject16["class"] = "UVEditorUVTextEdit";
            oc_Newobject16["historySize"] = "0";
            oc_Newobject16["password"] = "0";
            oc_Newobject16["tabComplete"] = "0";
            oc_Newobject16["sinkAllKeyEvents"] = "0";
            oc_Newobject16["passwordMask"] = "*";
            oc_Newobject16["maxLength"] = "1024";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "44 30";
            oc_Newobject16["Extent"] = "64 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject22["#Newobject16"] = oc_Newobject16;

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["text"] = "Width:";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "10 52";
            oc_Newobject17["Extent"] = "32 14";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject17"] = oc_Newobject17;

            #region GuiTextEditCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextEditCtrl", "", typeof (UVEditorUVTextEdit));
            oc_Newobject18["internalName"] = "UVW";
            //oc_Newobject18["class"] = "UVEditorUVTextEdit";
            oc_Newobject18["historySize"] = "0";
            oc_Newobject18["password"] = "0";
            oc_Newobject18["tabComplete"] = "0";
            oc_Newobject18["sinkAllKeyEvents"] = "0";
            oc_Newobject18["passwordMask"] = "*";
            oc_Newobject18["maxLength"] = "1024";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "44 50";
            oc_Newobject18["Extent"] = "64 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject22["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["text"] = "Height:";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["Margin"] = "0 0 0 0";
            oc_Newobject19["Padding"] = "0 0 0 0";
            oc_Newobject19["AnchorTop"] = "1";
            oc_Newobject19["AnchorBottom"] = "0";
            oc_Newobject19["AnchorLeft"] = "1";
            oc_Newobject19["AnchorRight"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "10 72";
            oc_Newobject19["Extent"] = "32 14";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiTextEditCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextEditCtrl", "", typeof (UVEditorUVTextEdit));
            oc_Newobject20["internalName"] = "UVH";
            //oc_Newobject20["class"] = "UVEditorUVTextEdit";
            oc_Newobject20["historySize"] = "0";
            oc_Newobject20["password"] = "0";
            oc_Newobject20["tabComplete"] = "0";
            oc_Newobject20["sinkAllKeyEvents"] = "0";
            oc_Newobject20["passwordMask"] = "*";
            oc_Newobject20["maxLength"] = "1024";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "44 70";
            oc_Newobject20["Extent"] = "64 18";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "top";
            oc_Newobject21["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject21["position"] = "44 94";
            oc_Newobject21["extent"] = "64 20";
            oc_Newobject21["text"] = "Reset";
            oc_Newobject21["command"] = "UVEditor.reset();";
            oc_Newobject21["tooltip"] = "Reset the UV fields to their original values.";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject25["#Newobject22"] = oc_Newobject22;

            #region GuiButtonCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject23["internalName"] = "OKButton";
            oc_Newobject23["HorizSizing"] = "left";
            oc_Newobject23["VertSizing"] = "top";
            oc_Newobject23["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject23["position"] = "292 306";
            oc_Newobject23["extent"] = "94 24";
            oc_Newobject23["text"] = "OK";
            oc_Newobject23["command"] = "UVEditor.apply();";
            oc_Newobject23["Accelerator"] = "return";

            #endregion

            oc_Newobject25["#Newobject23"] = oc_Newobject23;

            #region GuiButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject24["HorizSizing"] = "left";
            oc_Newobject24["VertSizing"] = "top";
            oc_Newobject24["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject24["position"] = "391 306";
            oc_Newobject24["extent"] = "52 24";
            oc_Newobject24["text"] = "Cancel";
            oc_Newobject24["command"] = "UVEditor.hideDialog();";
            oc_Newobject24["Accelerator"] = "escape";

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject26.Create();
        }

        [TypeConverter(typeof (UVEditor))]
        public class UVEditor : GuiWindowCtrl
        {
            [ConsoleInteraction]
            public void showDialog(string applyCallback, SimObject obj, string uv)
            {
                Settings EditorSettings = "EditorSettings";
                GuiCanvas Canvas = "Canvas";
                UVEditorOverlay UVEditorOverlay = "UVEditorOverlay";

                UVEditorRectHandles uvHandles = this.FOT("uvHandles");
                GuiBitmapCtrl bitmapPreview = this.FOT("bitmapPreview");
                GuiPopUpMenuCtrlEx colorPopup = this.FOT("colorPopup");

                // Set the select callback
                this["applyCallback"] = applyCallback;

                // Set the initial UV coordinates
                this["originalUV"] = uv;
                uvHandles.handleRect = uv.AsRectF();
                this.setTextValues(uv);

                // Get the preview bitmap.  Code copied from Material Selector.

                string previewImage = "";

                Material material = obj["material"];
                if (material.toneMap[0] == "" && material.diffuseMap[0] == "" && !material.cubemap.isObject())
                    previewImage = "core/art/warnmat";
                else
                    {
                    if (material.toneMap[0] != "")
                        previewImage = material.toneMap[0];
                    else if (material.diffuseMap[0] != "")
                        previewImage = material.diffuseMap[0];
                    else if (((SimObject) material.cubemap)["cubeFace[0]"] != "")
                        previewImage = ((SimObject) material.cubemap)["cubeFace[0]"];

                    string materialDiffuse = previewImage;
                    string materialPath = material.getFilename();
                    if (Util.strchr(materialDiffuse, "/") == "")
                        {
                        int k = 0;
                        while (Util.strpos(materialPath, "/", k) != -1)
                            {
                            int foo = Util.strpos(materialPath, "/", k);
                            k = foo + 1;
                            }

                        string foobar = Util.getSubStr(materialPath, k, 99);
                        previewImage = Util.strreplace(materialPath, foobar, previewImage);
                        }
                    else
                        previewImage = Util.strreplace(materialPath, materialPath, previewImage);
                    }

                bitmapPreview.setBitmapX(previewImage);

                // Set up the color popup
                GuiPopUpMenuCtrlEx popup = colorPopup;
                popup.clear();
                popup.add("Default1|255|134|0");
                popup.add("Default2|0|121|255");
                popup.add("Black|0|0|0");
                popup.add("Gray|100|100|100");
                popup.add("White|255|255|255");
                popup.add("Red|255|0|0");
                popup.add("Green|0|255|0");
                popup.add("Blue|0|0|255");
                popup.add("Yellow|255|255|0");
                popup.add("Magenta|255|0|255");
                popup.add("Cyan|0|255|255");
                popup.setSelected(EditorSettings.value("WorldEditor/Color/uvEditorHandleColor").AsInt());
                uvHandles.useCustomColor = true;
                uvHandles.handleColor = popup.getColorById(popup.getSelected());

                Canvas.pushDialog(UVEditorOverlay);
                this.setVisible(true);
            }

            [ConsoleInteraction]
            public void hideDialog()
            {
                GuiCanvas Canvas = "Canvas";
                UVEditorOverlay UVEditorOverlay = "UVEditorOverlay";

                this.setVisible(false);
                Canvas.popDialog(UVEditorOverlay);
            }

            [ConsoleInteraction]
            public void apply()
            {
                UVEditorRectHandles uvHandles = this.FOT("uvHandles");

                Util.eval("" + this["applyCallback"] + "(\"" + uvHandles.handleRect + "\");");
                this.hideDialog();
            }

            [ConsoleInteraction]
            public void reset()
            {
                UVEditorRectHandles uvHandles = this.FOT("uvHandles");

                uvHandles.handleRect = this["originalUV"].AsRectF();
                this.setTextValues(this["originalUV"]);
            }

            [ConsoleInteraction]
            public void setTextValues(string uv)
            {
                UVEditorUVTextEdit UVX = this.FOT("UVX");
                UVEditorUVTextEdit UVY = this.FOT("UVY");
                UVEditorUVTextEdit UVW = this.FOT("UVW");
                UVEditorUVTextEdit UVH = this.FOT("UVH");

                UVX.setText(Util.getWord(uv, 0));
                UVY.setText(Util.getWord(uv, 1));
                UVW.setText(Util.getWord(uv, 2));
                UVH.setText(Util.getWord(uv, 3));
            }

            [ConsoleInteraction]
            public void onColorSelect()
            {
                Settings EditorSettings = "EditorSettings";

                UVEditorRectHandles uvHandles = this.FOT("uvHandles");

                uvHandles.useCustomColor = true;
                string sel = sGlobal["$ThisControl"].call("getSelected");
                uvHandles.handleColor = sGlobal["$ThisControl"].call("getColorById", new string[] {sel}).AsColorI();
                EditorSettings.setValue("WorldEditor/Color/uvEditorHandleColor", sel);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(UVEditor ts, string simobjectid)
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
            public static bool operator !=(UVEditor ts, string simobjectid)
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
            public static implicit operator string(UVEditor ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator UVEditor(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (UVEditor) Omni.self.getSimObject(simobjectid, typeof (UVEditor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(UVEditor ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator UVEditor(int simobjectid)
            {
                return (UVEditor) Omni.self.getSimObject((uint) simobjectid, typeof (UVEditor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(UVEditor ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator UVEditor(uint simobjectid)
            {
                return (UVEditor) Omni.self.getSimObject(simobjectid, typeof (UVEditor));
            }

            #endregion
        }

        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<UVEditorRectHandles>))]
        public class UVEditorRectHandles : GuiRectHandles
        {
            [ConsoleInteraction]
            public override void onHandleRectChange()
            {
                UVEditor UVEditor = "UVEditor";
                UVEditorRectHandles uvHandles = UVEditor.FOT("uvHandles");

                string uv = uvHandles.handleRect.AsString();
                UVEditor.setTextValues(uv);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(UVEditorRectHandles ts, string simobjectid)
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
            public static bool operator !=(UVEditorRectHandles ts, string simobjectid)
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
            public static implicit operator string(UVEditorRectHandles ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator UVEditorRectHandles(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (UVEditorRectHandles) Omni.self.getSimObject(simobjectid, typeof (UVEditorRectHandles));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(UVEditorRectHandles ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator UVEditorRectHandles(int simobjectid)
            {
                return (UVEditorRectHandles) Omni.self.getSimObject((uint) simobjectid, typeof (UVEditorRectHandles));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(UVEditorRectHandles ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator UVEditorRectHandles(uint simobjectid)
            {
                return (UVEditorRectHandles) Omni.self.getSimObject(simobjectid, typeof (UVEditorRectHandles));
            }

            #endregion
        }

        //-----------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<UVEditorUVTextEdit>))]
        public class UVEditorUVTextEdit : GuiTextEditCtrl
        {
            [ConsoleInteraction]
            public override void onValidate()
            {
                UVEditor UVEditor = "UVEditor";

                UVEditorRectHandles uvHandles = UVEditor.FOT("uvHandles");
                UVEditorUVTextEdit UVX = UVEditor.FOT("UVX");
                UVEditorUVTextEdit UVY = UVEditor.FOT("UVY");
                UVEditorUVTextEdit UVW = UVEditor.FOT("UVW");
                UVEditorUVTextEdit UVH = UVEditor.FOT("UVH");

                int u = UVX.getValue().AsInt();
                int v = UVY.getValue().AsInt();
                int w = UVW.getValue().AsInt();
                int h = UVH.getValue().AsInt();

                // Check limits

                if (u < 0)
                    u = 0;
                if (u > 1)
                    u = 1;
                if (v < 0)
                    v = 0;
                if (v > 1)
                    v = 1;

                if (w < 0)
                    w = 0;
                if (w > 1)
                    w = 1;
                if (h < 0)
                    h = 0;
                if (h > 1)
                    h = 1;

                if ((u + w) > 1)
                    w = 1 - u;
                if ((v + h) > 1)
                    h = 1 - v;

                // Apply values
                UVX.setText(u.AsString());
                UVY.setText(v.AsString());
                UVW.setText(w.AsString());
                UVH.setText(h.AsString());

                uvHandles.handleRect = (u.AsString() + ' ' + v.AsString() + ' ' + w.AsString() + ' ' + h.AsString()).AsRectF();
            }

            [ConsoleInteraction]
            public override void onGainFirstResponder(string ID)
            {
                this.selectAllText();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(UVEditorUVTextEdit ts, string simobjectid)
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
            public static bool operator !=(UVEditorUVTextEdit ts, string simobjectid)
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
            public static implicit operator string(UVEditorUVTextEdit ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator UVEditorUVTextEdit(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (UVEditorUVTextEdit) Omni.self.getSimObject(simobjectid, typeof (UVEditorUVTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(UVEditorUVTextEdit ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator UVEditorUVTextEdit(int simobjectid)
            {
                return (UVEditorUVTextEdit) Omni.self.getSimObject((uint) simobjectid, typeof (UVEditorUVTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(UVEditorUVTextEdit ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator UVEditorUVTextEdit(uint simobjectid)
            {
                return (UVEditorUVTextEdit) Omni.self.getSimObject(simobjectid, typeof (UVEditorUVTextEdit));
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
        public static bool operator ==(UVEditorOverlay ts, string simobjectid)
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
        public static bool operator !=(UVEditorOverlay ts, string simobjectid)
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
        public static implicit operator string(UVEditorOverlay ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator UVEditorOverlay(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (UVEditorOverlay) Omni.self.getSimObject(simobjectid, typeof (UVEditorOverlay));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(UVEditorOverlay ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator UVEditorOverlay(int simobjectid)
        {
            return (UVEditorOverlay) Omni.self.getSimObject((uint) simobjectid, typeof (UVEditorOverlay));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(UVEditorOverlay ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator UVEditorOverlay(uint simobjectid)
        {
            return (UVEditorOverlay) Omni.self.getSimObject(simobjectid, typeof (UVEditorOverlay));
        }

        #endregion
    }
}