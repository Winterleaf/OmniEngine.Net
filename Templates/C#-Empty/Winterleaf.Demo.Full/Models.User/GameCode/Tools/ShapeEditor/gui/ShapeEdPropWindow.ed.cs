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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEdPropWindow>))]
    public class ShapeEdPropWindow : GuiWindowCollapseCtrl
    {
        [ConsoleInteraction(true, "ShapeEdPropWindow_initialize")]
        public static void initialize()
        {
            #region GuiWindowCollapseCtrl (ShapeEdPropWindow)        oc_Newobject92

            ObjectCreator oc_Newobject92 = new ObjectCreator("GuiWindowCollapseCtrl", "ShapeEdPropWindow", typeof (ShapeEdPropWindow));
            oc_Newobject92["AllowPopWindow"] = "1";
            oc_Newobject92["canSaveDynamicFields"] = "0";
            oc_Newobject92["isContainer"] = "1";
            oc_Newobject92["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject92["HorizSizing"] = "windowRelative";
            oc_Newobject92["VertSizing"] = "windowRelative";
            oc_Newobject92["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1) + getWord(ShapeEdSelectWindow.extent, 1) - 2");
            oc_Newobject92["Extent"] = "210 484";
            oc_Newobject92["MinExtent"] = "210 352";
            oc_Newobject92["canSave"] = "1";
            oc_Newobject92["Visible"] = "0";
            oc_Newobject92["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject92["hovertime"] = "1000";
            oc_Newobject92["Margin"] = "4 4 4 4";
            oc_Newobject92["Padding"] = "0 0 0 0";
            oc_Newobject92["AnchorTop"] = "1";
            oc_Newobject92["AnchorBottom"] = "0";
            oc_Newobject92["AnchorLeft"] = "1";
            oc_Newobject92["AnchorRight"] = "0";
            oc_Newobject92["resizeWidth"] = "1";
            oc_Newobject92["resizeHeight"] = "1";
            oc_Newobject92["canMove"] = "1";
            oc_Newobject92["canClose"] = "0";
            oc_Newobject92["canMinimize"] = "0";
            oc_Newobject92["canMaximize"] = "0";
            oc_Newobject92["minSize"] = "50 50";
            oc_Newobject92["EdgeSnap"] = "1";
            oc_Newobject92["text"] = "Properties";

            #region GuiTabBookCtrl (ShapeEdSeqNodeTabBook)        oc_Newobject88

            ObjectCreator oc_Newobject88 = new ObjectCreator("GuiTabBookCtrl", "ShapeEdSeqNodeTabBook", typeof (CodeBehind.ShapeEditor.ShapeEdSeqNodeTabBook));
            oc_Newobject88["canSaveDynamicFields"] = "0";
            oc_Newobject88["isContainer"] = "1";
            oc_Newobject88["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject88["HorizSizing"] = "width";
            oc_Newobject88["VertSizing"] = "height";
            oc_Newobject88["position"] = "4 42";
            oc_Newobject88["Extent"] = "202 437";
            oc_Newobject88["MinExtent"] = "8 8";
            oc_Newobject88["canSave"] = "1";
            oc_Newobject88["Visible"] = "1";
            oc_Newobject88["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject88["hovertime"] = "1000";
            oc_Newobject88["Docking"] = "client";
            oc_Newobject88["Margin"] = "3 1 3 3";
            oc_Newobject88["Padding"] = "0 0 0 0";
            oc_Newobject88["AnchorTop"] = "1";
            oc_Newobject88["AnchorBottom"] = "0";
            oc_Newobject88["AnchorLeft"] = "1";
            oc_Newobject88["AnchorRight"] = "0";
            oc_Newobject88["TabPosition"] = "Top";
            oc_Newobject88["TabMargin"] = "6";
            oc_Newobject88["MinTabWidth"] = "32";

            #region GuiTabPageCtrl (ShapeEdSequences)        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiTabPageCtrl", "ShapeEdSequences", typeof (CodeBehind.ShapeEditor.ShapeEdSequences));
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject38["HorizSizing"] = "width";
            oc_Newobject38["VertSizing"] = "height";
            oc_Newobject38["Position"] = "0 19";
            oc_Newobject38["Extent"] = "202 418";
            oc_Newobject38["MinExtent"] = "0 -500";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "0";
            oc_Newobject38["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["Margin"] = "0 0 0 0";
            oc_Newobject38["Padding"] = "0 0 0 0";
            oc_Newobject38["AnchorTop"] = "1";
            oc_Newobject38["AnchorBottom"] = "0";
            oc_Newobject38["AnchorLeft"] = "1";
            oc_Newobject38["AnchorRight"] = "0";
            oc_Newobject38["text"] = "Seq";
            oc_Newobject38["maxLength"] = "1024";

            #region GuiContainer ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiContainer", "");
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "GuiInspectorProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["Position"] = "0 0";
            oc_Newobject1["Extent"] = "202 418";
            oc_Newobject1["MinExtent"] = "0 8";

            #endregion

            oc_Newobject38["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapBorderCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "202 418";
            oc_Newobject2["MinExtent"] = "0 8";

            #endregion

            oc_Newobject38["#Newobject2"] = oc_Newobject2;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "202 211";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiScrollCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "202 211";
            oc_Newobject5["MinExtent"] = "8 25";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["willFirstRespond"] = "1";
            oc_Newobject5["hScrollBar"] = "dynamic";
            oc_Newobject5["vScrollBar"] = "dynamic";
            oc_Newobject5["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject5["lockVertScroll"] = "false";
            oc_Newobject5["constantThumbHeight"] = "0";
            oc_Newobject5["childMargin"] = "0 0";
            oc_Newobject5["mouseWheelScrollSpeed"] = "-1";

            #region GuiContainer ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiContainer", "");
            oc_Newobject3["internalName"] = "sequenceListHeader";
            oc_Newobject3["Profile"] = "inspectorStyleRolloutListProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "1 1";
            oc_Newobject3["Extent"] = "200 19";
            oc_Newobject3["MinExtent"] = "8 2";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiTextListCtrl (ShapeEdSequenceList)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextListCtrl", "ShapeEdSequenceList", typeof (CodeBehind.ShapeEditor.ShapeEdSequenceList));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "GuiShapeEdTextListProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "202 20";
            oc_Newobject4["MinExtent"] = "8 11";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "ShapeEdPropWindow.update_onSeqSelectionChanged();";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["enumerate"] = "0";
            oc_Newobject4["resizeCell"] = "1";
            oc_Newobject4["columns"] = "0 100 145 190 235";
            oc_Newobject4["fitParentWidth"] = "0";
            oc_Newobject4["clipColumnText"] = "1";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject38["#Newobject6"] = oc_Newobject6;

            #region GuiControl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiControl", "");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject37["HorizSizing"] = "width";
            oc_Newobject37["VertSizing"] = "top";
            oc_Newobject37["Position"] = "0 210";
            oc_Newobject37["Extent"] = "202 209";
            oc_Newobject37["MinExtent"] = "8 11";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiContainer", "");
            oc_Newobject23["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "0 0";
            oc_Newobject23["Extent"] = "202 103";
            oc_Newobject23["isContainer"] = new Creator.StringNoQuote("true");

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "5 1";
            oc_Newobject7["Extent"] = "104 16";
            oc_Newobject7["text"] = "Sequence Properties";

            #endregion

            oc_Newobject23["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "16 22";
            oc_Newobject8["Extent"] = "27 16";
            oc_Newobject8["text"] = "Name";

            #endregion

            oc_Newobject23["#Newobject8"] = oc_Newobject8;

            #region GuiTextEditCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject9["internalName"] = "seqName";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "46 21";
            oc_Newobject9["Extent"] = "152 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["AltCommand"] = "ShapeEdSequences.onEditName();";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Name of the selected sequence (edit to rename)";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["maxLength"] = "256";
            oc_Newobject9["historySize"] = "0";
            oc_Newobject9["password"] = "0";
            oc_Newobject9["tabComplete"] = "0";
            oc_Newobject9["sinkAllKeyEvents"] = "0";
            oc_Newobject9["passwordMask"] = "*";

            #endregion

            oc_Newobject23["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "-5 42";
            oc_Newobject10["Extent"] = "48 18";
            oc_Newobject10["text"] = "Source";
            oc_Newobject10["tooltip"] = "Animation source data";

            #endregion

            oc_Newobject23["#Newobject10"] = oc_Newobject10;

            #region GuiPopUpMenuCtrl (ShapeEdSeqFromMenu)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiPopUpMenuCtrl", "ShapeEdSeqFromMenu", typeof (CodeBehind.ShapeEditor.ShapeEdSeqFromMenu));
            oc_Newobject11["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "46 41";
            oc_Newobject11["Extent"] = "91 18";

            #endregion

            oc_Newobject23["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "32 62";
            oc_Newobject12["Extent"] = "11 16";
            oc_Newobject12["text"] = "in";

            #endregion

            oc_Newobject23["#Newobject12"] = oc_Newobject12;

            #region GuiTextEditCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject13["internalName"] = "startFrame";
            oc_Newobject13["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "46 61";
            oc_Newobject13["Extent"] = "32 18";
            oc_Newobject13["text"] = "";
            oc_Newobject13["AltCommand"] = "ShapeEdSequences.onEditSeqInOut(\\\"in\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject23["#Newobject13"] = oc_Newobject13;

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject14["HorizSizing"] = "left";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "85 62";
            oc_Newobject14["Extent"] = "18 16";
            oc_Newobject14["text"] = "out";

            #endregion

            oc_Newobject23["#Newobject14"] = oc_Newobject14;

            #region GuiTextEditCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject15["internalName"] = "endFrame";
            oc_Newobject15["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject15["HorizSizing"] = "left";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "105 61";
            oc_Newobject15["Extent"] = "32 18";
            oc_Newobject15["text"] = "";
            oc_Newobject15["AltCommand"] = "ShapeEdSequences.onEditSeqInOut(\\\"out\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject23["#Newobject15"] = oc_Newobject15;

            #region GuiCheckBoxCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject16["internalName"] = "cyclicFlag";
            oc_Newobject16["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject16["HorizSizing"] = "left";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "143 43";
            oc_Newobject16["Extent"] = "39 13";
            oc_Newobject16["Command"] = "ShapeEdSequences.onToggleCyclic();";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["ToolTip"] = "Loop Animation. Toggles the cyclic flag.";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["text"] = "Loop";

            #endregion

            oc_Newobject23["#Newobject16"] = oc_Newobject16;

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject17["HorizSizing"] = "left";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "136 62";
            oc_Newobject17["Extent"] = "41 16";
            oc_Newobject17["text"] = "Priority";

            #endregion

            oc_Newobject23["#Newobject17"] = oc_Newobject17;

            #region GuiTextEditCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject18["internalName"] = "priority";
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject18["HorizSizing"] = "left";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "179 61";
            oc_Newobject18["Extent"] = "19 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["AltCommand"] = "ShapeEdSequences.onEditPriority();";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["ToolTip"] = "Priority of the selected sequence";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["maxLength"] = "5";
            oc_Newobject18["historySize"] = "0";
            oc_Newobject18["password"] = "0";
            oc_Newobject18["tabComplete"] = "0";
            oc_Newobject18["sinkAllKeyEvents"] = "0";
            oc_Newobject18["passwordMask"] = "*";

            #endregion

            oc_Newobject23["#Newobject18"] = oc_Newobject18;

            #region GuiCheckBoxCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject19["internalName"] = "blendFlag";
            oc_Newobject19["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "2 82";
            oc_Newobject19["Extent"] = "45 16";
            oc_Newobject19["Command"] = "ShapeEdSequences.onEditBlend();";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["ToolTip"] = "Toggle the blend flag for the selected sequence";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["text"] = "Blend";

            #endregion

            oc_Newobject23["#Newobject19"] = oc_Newobject19;

            #region GuiPopUpMenuCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject20["internalName"] = "blendSeq";
            oc_Newobject20["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject20["HorizSizing"] = "width";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["Position"] = "46 81";
            oc_Newobject20["Extent"] = "91 18";
            oc_Newobject20["tooltip"] = "Blend reference sequence";
            oc_Newobject20["Command"] = "ShapeEdSequences.onEditBlend();";

            #endregion

            oc_Newobject23["#Newobject20"] = oc_Newobject20;

            #region GuiTextCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject21["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["Position"] = "142 81";
            oc_Newobject21["Extent"] = "29 18";
            oc_Newobject21["text"] = "Frame";

            #endregion

            oc_Newobject23["#Newobject21"] = oc_Newobject21;

            #region GuiTextEditCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject22["internalName"] = "blendFrame";
            oc_Newobject22["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject22["HorizSizing"] = "left";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "173 81";
            oc_Newobject22["Extent"] = "25 18";
            oc_Newobject22["text"] = "";
            oc_Newobject22["tooltip"] = "Blend reference frame";
            oc_Newobject22["AltCommand"] = "ShapeEdSequences.onEditBlend();";

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject37["#Newobject23"] = oc_Newobject23;

            #region GuiContainer ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiContainer", "");
            oc_Newobject36["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject36["HorizSizing"] = "width";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["position"] = "0 102";
            oc_Newobject36["Extent"] = "202 106";
            oc_Newobject36["isContainer"] = new Creator.StringNoQuote("true");

            #region GuiTextCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "5 0";
            oc_Newobject24["Extent"] = "50 18";
            oc_Newobject24["text"] = "Triggers";

            #endregion

            oc_Newobject36["#Newobject24"] = oc_Newobject24;

            #region GuiBitmapButtonCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject25["internalName"] = "addTriggerBtn";
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject25["HorizSizing"] = "left";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["Position"] = "170 2";
            oc_Newobject25["Extent"] = "15 15";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["Command"] = "ShapeEdSequences.onAddTrigger();";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["ToolTip"] = "Add a new trigger";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["groupNum"] = "0";
            oc_Newobject25["buttonType"] = "PushButton";
            oc_Newobject25["useMouseEvents"] = "0";
            oc_Newobject25["bitmap"] = "tools/gui/images/new";

            #endregion

            oc_Newobject36["#Newobject25"] = oc_Newobject25;

            #region GuiBitmapButtonCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject26["internalName"] = "deleteTriggerBtn";
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject26["HorizSizing"] = "left";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "185 2";
            oc_Newobject26["Extent"] = "15 15";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["Command"] = "ShapeEdTriggerList.onDeleteSelection();";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["ToolTip"] = "Delete the selected trigger";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["groupNum"] = "0";
            oc_Newobject26["buttonType"] = "PushButton";
            oc_Newobject26["useMouseEvents"] = "0";
            oc_Newobject26["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject36["#Newobject26"] = oc_Newobject26;

            #region GuiControl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiControl", "");
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["isContainer"] = "1";
            oc_Newobject30["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject30["HorizSizing"] = "width";
            oc_Newobject30["VertSizing"] = "height";
            oc_Newobject30["Position"] = "0 17";
            oc_Newobject30["Extent"] = "202 66";
            oc_Newobject30["MinExtent"] = "8 8";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";

            #region GuiScrollCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["isContainer"] = "1";
            oc_Newobject29["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject29["HorizSizing"] = "width";
            oc_Newobject29["VertSizing"] = "height";
            oc_Newobject29["Position"] = "0 0";
            oc_Newobject29["Extent"] = "202 66";
            oc_Newobject29["MinExtent"] = "8 8";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["Margin"] = "0 0 0 0";
            oc_Newobject29["Padding"] = "0 0 0 0";
            oc_Newobject29["AnchorTop"] = "0";
            oc_Newobject29["AnchorBottom"] = "0";
            oc_Newobject29["AnchorLeft"] = "1";
            oc_Newobject29["AnchorRight"] = "0";
            oc_Newobject29["willFirstRespond"] = "1";
            oc_Newobject29["hScrollBar"] = "alwaysOff";
            oc_Newobject29["vScrollBar"] = "dynamic";
            oc_Newobject29["lockHorizScroll"] = "true";
            oc_Newobject29["lockVertScroll"] = "false";
            oc_Newobject29["constantThumbHeight"] = "0";
            oc_Newobject29["childMargin"] = "0 0";
            oc_Newobject29["mouseWheelScrollSpeed"] = "-1";

            #region GuiContainer ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiContainer", "");
            oc_Newobject27["Profile"] = "inspectorStyleRolloutListProfile";
            oc_Newobject27["HorizSizing"] = "width";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = "1 1";
            oc_Newobject27["Extent"] = "200 19";

            #endregion

            oc_Newobject29["#Newobject27"] = oc_Newobject27;

            #region GuiTextListCtrl (ShapeEdTriggerList)        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextListCtrl", "ShapeEdTriggerList", typeof (CodeBehind.ShapeEditor.ShapeEdTriggerList));
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["Profile"] = "GuiShapeEdTextListProfile";
            oc_Newobject28["HorizSizing"] = "right";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["Position"] = "1 1";
            oc_Newobject28["Extent"] = "177 16";
            oc_Newobject28["MinExtent"] = "8 11";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["Command"] = "ShapeEdPropWindow.onTriggerSelectionChanged();";
            oc_Newobject28["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["enumerate"] = "0";
            oc_Newobject28["resizeCell"] = "1";
            oc_Newobject28["columns"] = "-1 0 60 118";
            oc_Newobject28["fitParentWidth"] = "1";
            oc_Newobject28["clipColumnText"] = "1";

            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject36["#Newobject30"] = oc_Newobject30;

            #region GuiTextCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject31["HorizSizing"] = "right";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["Position"] = "5 85";
            oc_Newobject31["Extent"] = "35 18";
            oc_Newobject31["text"] = "Frame";

            #endregion

            oc_Newobject36["#Newobject31"] = oc_Newobject31;

            #region GuiTextEditCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject32["internalName"] = "triggerFrame";
            oc_Newobject32["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["Position"] = "36 85";
            oc_Newobject32["Extent"] = "32 18";
            oc_Newobject32["text"] = "";
            oc_Newobject32["AltCommand"] = "ShapeEdTriggerList.onEditSelection();";

            #endregion

            oc_Newobject36["#Newobject32"] = oc_Newobject32;

            #region GuiTextCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["Position"] = "75 85";
            oc_Newobject33["Extent"] = "35 18";
            oc_Newobject33["text"] = "Trigger";

            #endregion

            oc_Newobject36["#Newobject33"] = oc_Newobject33;

            #region GuiTextEditCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject34["internalName"] = "triggerNum";
            oc_Newobject34["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["Position"] = "110 85";
            oc_Newobject34["Extent"] = "32 18";
            oc_Newobject34["text"] = "";
            oc_Newobject34["AltCommand"] = "ShapeEdTriggerList.onEditSelection();";

            #endregion

            oc_Newobject36["#Newobject34"] = oc_Newobject34;

            #region GuiCheckBoxCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject35["internalName"] = "triggerOnOff";
            oc_Newobject35["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject35["HorizSizing"] = "left";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["Position"] = "152 87";
            oc_Newobject35["Extent"] = "47 13";
            oc_Newobject35["text"] = "On/off";
            oc_Newobject35["Command"] = "ShapeEdTriggerList.onEditSelection();";

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject88["#Newobject38"] = oc_Newobject38;

            #region GuiTabPageCtrl (ShapeEdNodes)        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiTabPageCtrl", "ShapeEdNodes", typeof (CodeBehind.ShapeEditor.ShapeEdNodes));
            oc_Newobject57["canSaveDynamicFields"] = "0";
            oc_Newobject57["isContainer"] = "1";
            oc_Newobject57["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject57["HorizSizing"] = "width";
            oc_Newobject57["VertSizing"] = "height";
            oc_Newobject57["Position"] = "0 19";
            oc_Newobject57["Extent"] = "202 418";
            oc_Newobject57["MinExtent"] = "0 -500";
            oc_Newobject57["canSave"] = "1";
            oc_Newobject57["Visible"] = "0";
            oc_Newobject57["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject57["hovertime"] = "1000";
            oc_Newobject57["Margin"] = "0 0 0 0";
            oc_Newobject57["Padding"] = "0 0 0 0";
            oc_Newobject57["AnchorTop"] = "1";
            oc_Newobject57["AnchorBottom"] = "0";
            oc_Newobject57["AnchorLeft"] = "1";
            oc_Newobject57["AnchorRight"] = "0";
            oc_Newobject57["text"] = "Node";
            oc_Newobject57["maxLength"] = "1024";

            #region GuiBitmapBorderCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject39["HorizSizing"] = "width";
            oc_Newobject39["VertSizing"] = "height";
            oc_Newobject39["Position"] = "0 0";
            oc_Newobject39["Extent"] = "202 418";
            oc_Newobject39["MinExtent"] = "0 8";

            #endregion

            oc_Newobject57["#Newobject39"] = oc_Newobject39;

            #region GuiTextEditCtrl (NodeTreeFilter)        oc_Newobject96

            ObjectCreator oc_Newobject96 = new ObjectCreator("GuiTextEditCtrl", "NodeTreeFilter", typeof (treeViewFilterCtrls.GuiTreeViewFilterText));
            oc_Newobject96["position"] = "2 4";
            oc_Newobject96["extent"] = "175 18";
            oc_Newobject96["profile"] = "GuiTextEditProfile";
            oc_Newobject96["horizSizing"] = "width";
            oc_Newobject96["vertSizing"] = "bottom";
            //oc_Newobject96["class"] = "GuiTreeViewFilterText";
            oc_Newobject96["treeView"] = new Creator.StringNoQuote("ShapeEdNodeTreeView");

            #endregion

            oc_Newobject57["#Newobject96"] = oc_Newobject96;

            #region GuiBitmapButtonCtrl ()        oc_Newobject97

            ObjectCreator oc_Newobject97 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof (treeViewFilterCtrls.GuiTreeViewFilterClearButton));
            oc_Newobject97["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject97["groupNum"] = "-1";
            oc_Newobject97["buttonType"] = "PushButton";
            oc_Newobject97["useMouseEvents"] = "0";
            oc_Newobject97["isContainer"] = "0";
            oc_Newobject97["Profile"] = "GuiDefaultProfile";
            oc_Newobject97["HorizSizing"] = "left";
            oc_Newobject97["VertSizing"] = "bottom";
            oc_Newobject97["position"] = "180 5";
            oc_Newobject97["Extent"] = "17 17";
            oc_Newobject97["MinExtent"] = "8 2";
            oc_Newobject97["canSave"] = "1";
            oc_Newobject97["Visible"] = "1";
            oc_Newobject97["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject97["hovertime"] = "1000";
            oc_Newobject97["canSaveDynamicFields"] = "0";
            //oc_Newobject97["class"] = "GuiTreeViewFilterClearButton";
            oc_Newobject97["textCtrl"] = new Creator.StringNoQuote("NodeTreeFilter");

            #endregion

            oc_Newobject57["#Newobject97"] = oc_Newobject97;

            #region GuiScrollCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject41["HorizSizing"] = "width";
            oc_Newobject41["VertSizing"] = "height";
            oc_Newobject41["Position"] = "0 32";
            oc_Newobject41["Extent"] = "202 256";
            oc_Newobject41["MinExtent"] = "8 0";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["Margin"] = "0 0 0 0";
            oc_Newobject41["Padding"] = "0 0 0 0";
            oc_Newobject41["AnchorTop"] = "0";
            oc_Newobject41["AnchorBottom"] = "0";
            oc_Newobject41["AnchorLeft"] = "1";
            oc_Newobject41["AnchorRight"] = "0";
            oc_Newobject41["willFirstRespond"] = "1";
            oc_Newobject41["hScrollBar"] = "dynamic";
            oc_Newobject41["vScrollBar"] = "dynamic";
            oc_Newobject41["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject41["lockVertScroll"] = "false";
            oc_Newobject41["constantThumbHeight"] = "0";
            oc_Newobject41["childMargin"] = "0 0";
            oc_Newobject41["mouseWheelScrollSpeed"] = "-1";

            #region GuiTreeViewCtrl (ShapeEdNodeTreeView)        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTreeViewCtrl", "ShapeEdNodeTreeView", typeof (CodeBehind.ShapeEditor.ShapeEdNodeTreeView));
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["isContainer"] = "1";
            oc_Newobject40["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject40["HorizSizing"] = "right";
            oc_Newobject40["VertSizing"] = "height";
            oc_Newobject40["Position"] = "1 1";
            oc_Newobject40["Extent"] = "122 21";
            oc_Newobject40["MinExtent"] = "8 8";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["tabSize"] = "16";
            oc_Newobject40["textOffset"] = "2";
            oc_Newobject40["fullRowSelect"] = "0";
            oc_Newobject40["itemHeight"] = "21";
            oc_Newobject40["destroyTreeOnSleep"] = "1";
            oc_Newobject40["MouseDragging"] = "0";
            oc_Newobject40["MultipleSelections"] = "0";
            oc_Newobject40["DeleteObjectAllowed"] = "1";
            oc_Newobject40["DragToItemAllowed"] = "0";
            oc_Newobject40["showRoot"] = "0";
            oc_Newobject40["internalNamesOnly"] = "0";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject57["#Newobject41"] = oc_Newobject41;

            #region GuiContainer ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiContainer", "");
            oc_Newobject56["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject56["HorizSizing"] = "width";
            oc_Newobject56["VertSizing"] = "top";
            oc_Newobject56["position"] = "0 287";
            oc_Newobject56["Extent"] = "202 131";
            oc_Newobject56["isContainer"] = new Creator.StringNoQuote("true");

            #region GuiTextCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject42["HorizSizing"] = "right";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["position"] = "5 1";
            oc_Newobject42["Extent"] = "104 16";
            oc_Newobject42["text"] = "Node Properties";

            #endregion

            oc_Newobject56["#Newobject42"] = oc_Newobject42;

            #region GuiControl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiControl", "");
            oc_Newobject48["canSaveDynamicFields"] = "0";
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject48["HorizSizing"] = "right";
            oc_Newobject48["VertSizing"] = "top";
            oc_Newobject48["Position"] = "6 18";
            oc_Newobject48["Extent"] = "50 108";
            oc_Newobject48["MinExtent"] = "8 2";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["Visible"] = "1";
            oc_Newobject48["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject43["HorizSizing"] = "right";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject43["position"] = "9 6";
            oc_Newobject43["Extent"] = "40 16";
            oc_Newobject43["text"] = "Name";

            #endregion

            oc_Newobject48["#Newobject43"] = oc_Newobject43;

            #region GuiTextCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject44["HorizSizing"] = "right";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject44["position"] = "10 26";
            oc_Newobject44["Extent"] = "40 16";
            oc_Newobject44["text"] = "Parent";

            #endregion

            oc_Newobject48["#Newobject44"] = oc_Newobject44;

            #region GuiTextCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject45["position"] = "-5 49";
            oc_Newobject45["Extent"] = "54 16";
            oc_Newobject45["text"] = "Transform";

            #endregion

            oc_Newobject48["#Newobject45"] = oc_Newobject45;

            #region GuiTextCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject46["HorizSizing"] = "right";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject46["position"] = "11 73";
            oc_Newobject46["Extent"] = "39 16";
            oc_Newobject46["text"] = "Position";

            #endregion

            oc_Newobject48["#Newobject46"] = oc_Newobject46;

            #region GuiTextCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject47["HorizSizing"] = "right";
            oc_Newobject47["VertSizing"] = "bottom";
            oc_Newobject47["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject47["position"] = "8 93";
            oc_Newobject47["Extent"] = "42 16";
            oc_Newobject47["text"] = "Rotation";

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject56["#Newobject48"] = oc_Newobject48;

            #region GuiControl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiControl", "");
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["isContainer"] = "1";
            oc_Newobject55["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject55["HorizSizing"] = "width";
            oc_Newobject55["VertSizing"] = "top";
            oc_Newobject55["Position"] = "49 16";
            oc_Newobject55["Extent"] = "155 109";
            oc_Newobject55["MinExtent"] = "8 2";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject55["hovertime"] = "1000";

            #region GuiTextEditCtrl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject49["internalName"] = "nodeName";
            oc_Newobject49["canSaveDynamicFields"] = "0";
            oc_Newobject49["isContainer"] = "0";
            oc_Newobject49["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject49["HorizSizing"] = "width";
            oc_Newobject49["VertSizing"] = "bottom";
            oc_Newobject49["Position"] = "12 5";
            oc_Newobject49["Extent"] = "137 18";
            oc_Newobject49["MinExtent"] = "8 2";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["Visible"] = "1";
            oc_Newobject49["AltCommand"] = "ShapeEdNodes.onEditName();";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["ToolTip"] = "Name of the selected node (edit to rename)";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["Margin"] = "0 0 0 0";
            oc_Newobject49["Padding"] = "0 0 0 0";
            oc_Newobject49["AnchorTop"] = "1";
            oc_Newobject49["AnchorBottom"] = "0";
            oc_Newobject49["AnchorLeft"] = "1";
            oc_Newobject49["AnchorRight"] = "0";
            oc_Newobject49["maxLength"] = "1024";
            oc_Newobject49["historySize"] = "0";
            oc_Newobject49["password"] = "0";
            oc_Newobject49["tabComplete"] = "0";
            oc_Newobject49["sinkAllKeyEvents"] = "0";
            oc_Newobject49["passwordMask"] = "*";

            #endregion

            oc_Newobject55["#Newobject49"] = oc_Newobject49;

            #region GuiPopUpMenuCtrl (ShapeEdNodeParentMenu)        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiPopUpMenuCtrl", "ShapeEdNodeParentMenu", typeof (CodeBehind.ShapeEditor.ShapeEdNodeParentMenu));
            oc_Newobject50["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["Position"] = "12 25";
            oc_Newobject50["Extent"] = "137 18";
            oc_Newobject50["tooltip"] = "Selected node's parent";

            #endregion

            oc_Newobject55["#Newobject50"] = oc_Newobject50;

            #region GuiIconButtonCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject51["internalName"] = "worldTransform";
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["isContainer"] = "0";
            oc_Newobject51["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject51["HorizSizing"] = "right";
            oc_Newobject51["VertSizing"] = "bottom";
            oc_Newobject51["Position"] = "12 45";
            oc_Newobject51["Extent"] = "65 25";
            oc_Newobject51["MinExtent"] = "8 8";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["Command"] = "ShapeEdPropWindow.update_onNodeTransformChanged();";
            oc_Newobject51["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject51["ToolTip"] = "View global node transform";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["text"] = "World";
            oc_Newobject51["groupNum"] = "0";
            oc_Newobject51["buttonType"] = "RadioButton";
            oc_Newobject51["useMouseEvents"] = "0";
            oc_Newobject51["buttonMargin"] = "0 4";
            oc_Newobject51["iconBitmap"] = "tools/gui/images/menubar/world-transform_n";
            oc_Newobject51["textMargin"] = "25";

            #endregion

            oc_Newobject55["#Newobject51"] = oc_Newobject51;

            #region GuiIconButtonCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject52["internalName"] = "objectTransform";
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["isContainer"] = "0";
            oc_Newobject52["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject52["HorizSizing"] = "left";
            oc_Newobject52["VertSizing"] = "bottom";
            oc_Newobject52["Position"] = "84 45";
            oc_Newobject52["Extent"] = "65 25";
            oc_Newobject52["MinExtent"] = "8 8";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["Visible"] = "1";
            oc_Newobject52["Command"] = "ShapeEdPropWindow.update_onNodeTransformChanged();";
            oc_Newobject52["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject52["ToolTip"] = "View local node transform (relative to parent)";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["text"] = "Object";
            oc_Newobject52["groupNum"] = "0";
            oc_Newobject52["buttonType"] = "RadioButton";
            oc_Newobject52["useMouseEvents"] = "0";
            oc_Newobject52["buttonMargin"] = "0 4";
            oc_Newobject52["iconBitmap"] = "tools/gui/images/menubar/object-transform_n";
            oc_Newobject52["textMargin"] = "26";

            #endregion

            oc_Newobject55["#Newobject52"] = oc_Newobject52;

            #region GuiTextEditCtrl ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject53["internalName"] = "nodePosition";
            oc_Newobject53["canSaveDynamicFields"] = "0";
            oc_Newobject53["isContainer"] = "0";
            oc_Newobject53["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject53["HorizSizing"] = "width";
            oc_Newobject53["VertSizing"] = "bottom";
            oc_Newobject53["Position"] = "12 72";
            oc_Newobject53["Extent"] = "137 18";
            oc_Newobject53["MinExtent"] = "8 2";
            oc_Newobject53["canSave"] = "1";
            oc_Newobject53["Visible"] = "1";
            oc_Newobject53["AltCommand"] = "ShapeEdNodes.onEditTransform();";
            oc_Newobject53["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject53["ToolTip"] = "Node position (x y z)";
            oc_Newobject53["hovertime"] = "1000";
            oc_Newobject53["Margin"] = "0 0 0 0";
            oc_Newobject53["Padding"] = "0 0 0 0";
            oc_Newobject53["AnchorTop"] = "1";
            oc_Newobject53["AnchorBottom"] = "0";
            oc_Newobject53["AnchorLeft"] = "1";
            oc_Newobject53["AnchorRight"] = "0";
            oc_Newobject53["maxLength"] = "1024";
            oc_Newobject53["historySize"] = "0";
            oc_Newobject53["password"] = "0";
            oc_Newobject53["tabComplete"] = "0";
            oc_Newobject53["sinkAllKeyEvents"] = "0";
            oc_Newobject53["passwordMask"] = "*";

            #endregion

            oc_Newobject55["#Newobject53"] = oc_Newobject53;

            #region GuiTextEditCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject54["internalName"] = "nodeRotation";
            oc_Newobject54["canSaveDynamicFields"] = "0";
            oc_Newobject54["isContainer"] = "0";
            oc_Newobject54["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject54["HorizSizing"] = "width";
            oc_Newobject54["VertSizing"] = "bottom";
            oc_Newobject54["Position"] = "12 92";
            oc_Newobject54["Extent"] = "137 18";
            oc_Newobject54["MinExtent"] = "8 2";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["Visible"] = "1";
            oc_Newobject54["AltCommand"] = "ShapeEdNodes.onEditTransform();";
            oc_Newobject54["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject54["ToolTip"] = "Node rotation (axis.x axis.y axis.z angle)";
            oc_Newobject54["hovertime"] = "1000";
            oc_Newobject54["Margin"] = "0 0 0 0";
            oc_Newobject54["Padding"] = "0 0 0 0";
            oc_Newobject54["AnchorTop"] = "1";
            oc_Newobject54["AnchorBottom"] = "0";
            oc_Newobject54["AnchorLeft"] = "1";
            oc_Newobject54["AnchorRight"] = "0";
            oc_Newobject54["maxLength"] = "1024";
            oc_Newobject54["historySize"] = "0";
            oc_Newobject54["password"] = "0";
            oc_Newobject54["tabComplete"] = "0";
            oc_Newobject54["sinkAllKeyEvents"] = "0";
            oc_Newobject54["passwordMask"] = "*";

            #endregion

            oc_Newobject55["#Newobject54"] = oc_Newobject54;

            #endregion

            oc_Newobject56["#Newobject55"] = oc_Newobject55;

            #endregion

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #endregion

            oc_Newobject88["#Newobject57"] = oc_Newobject57;

            #region GuiTabPageCtrl (ShapeEdDetails)        oc_Newobject76

            ObjectCreator oc_Newobject76 = new ObjectCreator("GuiTabPageCtrl", "ShapeEdDetails", typeof (CodeBehind.ShapeEditor.ShapeEdDetails));
            oc_Newobject76["fitBook"] = "0";
            oc_Newobject76["text"] = "Detail";
            oc_Newobject76["maxLength"] = "1024";
            oc_Newobject76["Margin"] = "0 0 0 0";
            oc_Newobject76["Padding"] = "0 0 0 0";
            oc_Newobject76["AnchorTop"] = "1";
            oc_Newobject76["AnchorBottom"] = "0";
            oc_Newobject76["AnchorLeft"] = "1";
            oc_Newobject76["AnchorRight"] = "0";
            oc_Newobject76["position"] = "0 19";
            oc_Newobject76["extent"] = "202 418";
            oc_Newobject76["MinExtent"] = "0 -500";
            oc_Newobject76["HorizSizing"] = "width";
            oc_Newobject76["VertSizing"] = "height";
            oc_Newobject76["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject76["Visible"] = "0";
            oc_Newobject76["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject76["hovertime"] = "1000";
            oc_Newobject76["isContainer"] = "1";

            #region GuiContainer ()        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiContainer", "");
            oc_Newobject58["position"] = "0 0";
            oc_Newobject58["extent"] = "202 418";
            oc_Newobject58["minExtent"] = "0 8";
            oc_Newobject58["horizSizing"] = "width";
            oc_Newobject58["vertSizing"] = "height";
            oc_Newobject58["profile"] = "GuiInspectorProfile";
            oc_Newobject58["isContainer"] = "1";

            #endregion

            oc_Newobject76["#Newobject58"] = oc_Newobject58;

            #region GuiBitmapBorderCtrl ()        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject59["position"] = "0 0";
            oc_Newobject59["extent"] = "202 418";
            oc_Newobject59["minExtent"] = "0 8";
            oc_Newobject59["HorizSizing"] = "width";
            oc_Newobject59["VertSizing"] = "height";
            oc_Newobject59["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject59["isContainer"] = "1";

            #endregion

            oc_Newobject76["#Newobject59"] = oc_Newobject59;

            #region GuiControl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiControl", "");
            oc_Newobject62["Position"] = "0 0";
            oc_Newobject62["extent"] = "202 276";
            oc_Newobject62["MinExtent"] = "8 8";
            oc_Newobject62["HorizSizing"] = "width";
            oc_Newobject62["VertSizing"] = "height";
            oc_Newobject62["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject62["Visible"] = "1";
            oc_Newobject62["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject62["hovertime"] = "1000";
            oc_Newobject62["isContainer"] = "1";
            oc_Newobject62["canSave"] = "1";
            oc_Newobject62["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject61["willFirstRespond"] = "1";
            oc_Newobject61["hScrollBar"] = "dynamic";
            oc_Newobject61["vScrollBar"] = "dynamic";
            oc_Newobject61["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject61["lockVertScroll"] = "false";
            oc_Newobject61["constantThumbHeight"] = "0";
            oc_Newobject61["childMargin"] = "0 0";
            oc_Newobject61["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject61["Margin"] = "0 0 0 0";
            oc_Newobject61["Padding"] = "0 0 0 0";
            oc_Newobject61["AnchorTop"] = "1";
            oc_Newobject61["AnchorBottom"] = "0";
            oc_Newobject61["AnchorLeft"] = "1";
            oc_Newobject61["AnchorRight"] = "0";
            oc_Newobject61["Position"] = "0 0";
            oc_Newobject61["extent"] = "202 276";
            oc_Newobject61["MinExtent"] = "8 25";
            oc_Newobject61["HorizSizing"] = "width";
            oc_Newobject61["VertSizing"] = "height";
            oc_Newobject61["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject61["Visible"] = "1";
            oc_Newobject61["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject61["hovertime"] = "1000";
            oc_Newobject61["isContainer"] = "1";
            oc_Newobject61["canSave"] = "1";
            oc_Newobject61["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (ShapeEdDetailTree)        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiTreeViewCtrl", "ShapeEdDetailTree", typeof (CodeBehind.ShapeEditor.ShapeEdDetailTree));
            oc_Newobject60["tabSize"] = "16";
            oc_Newobject60["textOffset"] = "2";
            oc_Newobject60["fullRowSelect"] = "0";
            oc_Newobject60["itemHeight"] = "21";
            oc_Newobject60["destroyTreeOnSleep"] = "1";
            oc_Newobject60["MouseDragging"] = "0";
            oc_Newobject60["MultipleSelections"] = "0";
            oc_Newobject60["DeleteObjectAllowed"] = "1";
            oc_Newobject60["DragToItemAllowed"] = "0";
            oc_Newobject60["showRoot"] = "0";
            oc_Newobject60["Position"] = "1 1";
            oc_Newobject60["extent"] = "85 110";
            oc_Newobject60["MinExtent"] = "8 8";
            oc_Newobject60["HorizSizing"] = "right";
            oc_Newobject60["VertSizing"] = "height";
            oc_Newobject60["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject60["Visible"] = "1";
            oc_Newobject60["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject60["hovertime"] = "1000";
            oc_Newobject60["isContainer"] = "1";
            oc_Newobject60["canSave"] = "1";
            oc_Newobject60["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject61["#Newobject60"] = oc_Newobject60;

            #endregion

            oc_Newobject62["#Newobject61"] = oc_Newobject61;

            #endregion

            oc_Newobject76["#Newobject62"] = oc_Newobject62;

            #region GuiControl ()        oc_Newobject75

            ObjectCreator oc_Newobject75 = new ObjectCreator("GuiControl", "");
            oc_Newobject75["position"] = "0 275";
            oc_Newobject75["extent"] = "202 143";
            oc_Newobject75["MinExtent"] = "8 8";
            oc_Newobject75["HorizSizing"] = "width";
            oc_Newobject75["vertSizing"] = "top";
            oc_Newobject75["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject75["Visible"] = "1";
            oc_Newobject75["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject75["hovertime"] = "1000";
            oc_Newobject75["isContainer"] = "1";
            oc_Newobject75["canSave"] = "1";
            oc_Newobject75["canSaveDynamicFields"] = "0";

            #region GuiContainer ()        oc_Newobject74

            ObjectCreator oc_Newobject74 = new ObjectCreator("GuiContainer", "");
            oc_Newobject74["position"] = "0 0";
            oc_Newobject74["extent"] = "202 143";
            oc_Newobject74["HorizSizing"] = "width";
            oc_Newobject74["VertSizing"] = "bottom";
            oc_Newobject74["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject74["isContainer"] = "1";

            #region GuiTextCtrl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject63["text"] = "Detail/Object Properties";
            oc_Newobject63["position"] = "4 1";
            oc_Newobject63["extent"] = "112 16";
            oc_Newobject63["HorizSizing"] = "right";
            oc_Newobject63["VertSizing"] = "bottom";

            #endregion

            oc_Newobject74["#Newobject63"] = oc_Newobject63;

            #region GuiTextEditCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject64["position"] = "5 23";
            oc_Newobject64["extent"] = "130 18";
            oc_Newobject64["MinExtent"] = "8 2";
            oc_Newobject64["HorizSizing"] = "right";
            oc_Newobject64["VertSizing"] = "bottom";
            oc_Newobject64["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject64["Visible"] = "1";
            oc_Newobject64["AltCommand"] = "ShapeEdDetails.onEditName();";
            oc_Newobject64["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject64["ToolTip"] = "Edit this value to rename the current object or detail";
            oc_Newobject64["hovertime"] = "1000";
            oc_Newobject64["internalName"] = "meshName";
            oc_Newobject64["canSave"] = "1";
            oc_Newobject64["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject74["#Newobject64"] = oc_Newobject64;

            #region GuiTextEditCtrl ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject65["position"] = "157 23";
            oc_Newobject65["extent"] = "40 18";
            oc_Newobject65["MinExtent"] = "8 2";
            oc_Newobject65["HorizSizing"] = "right";
            oc_Newobject65["VertSizing"] = "bottom";
            oc_Newobject65["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject65["Visible"] = "1";
            oc_Newobject65["AltCommand"] = "ShapeEdDetails.onEditSize();";
            oc_Newobject65["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject65["ToolTip"] = "Edit this value to change the size of the current mesh or detail";
            oc_Newobject65["hovertime"] = "1000";
            oc_Newobject65["internalName"] = "meshSize";
            oc_Newobject65["canSave"] = "1";
            oc_Newobject65["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject74["#Newobject65"] = oc_Newobject65;

            #region GuiTextCtrl ()        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject66["text"] = "Billboarding";
            oc_Newobject66["position"] = "5 44";
            oc_Newobject66["extent"] = "57 16";
            oc_Newobject66["HorizSizing"] = "right";
            oc_Newobject66["VertSizing"] = "bottom";

            #endregion

            oc_Newobject74["#Newobject66"] = oc_Newobject66;

            #region GuiPopUpMenuCtrl ()        oc_Newobject67

            ObjectCreator oc_Newobject67 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject67["position"] = "88 45";
            oc_Newobject67["extent"] = "109 18";
            oc_Newobject67["HorizSizing"] = "right";
            oc_Newobject67["vertSizing"] = "bottom";
            oc_Newobject67["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject67["Command"] = "ShapeEdDetails.onEditBBType();";
            oc_Newobject67["ToolTip"] = "The type of billboarding used by the mesh";
            oc_Newobject67["internalName"] = "bbType";

            #endregion

            oc_Newobject74["#Newobject67"] = oc_Newobject67;

            #region GuiTextCtrl ()        oc_Newobject68

            ObjectCreator oc_Newobject68 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject68["text"] = "Object Node";
            oc_Newobject68["position"] = "5 66";
            oc_Newobject68["extent"] = "60 16";
            oc_Newobject68["HorizSizing"] = "right";
            oc_Newobject68["VertSizing"] = "bottom";

            #endregion

            oc_Newobject74["#Newobject68"] = oc_Newobject68;

            #region GuiPopUpMenuCtrl ()        oc_Newobject69

            ObjectCreator oc_Newobject69 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject69["position"] = "88 67";
            oc_Newobject69["extent"] = "109 18";
            oc_Newobject69["HorizSizing"] = "right";
            oc_Newobject69["vertSizing"] = "bottom";
            oc_Newobject69["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject69["Command"] = "ShapeEdDetails.onSetObjectNode();";
            oc_Newobject69["ToolTip"] = "The node this object is attached to (all detail levels)";
            oc_Newobject69["internalName"] = "objectNode";

            #endregion

            oc_Newobject74["#Newobject69"] = oc_Newobject69;

            #region GuiBitmapCtrl ()        oc_Newobject70

            ObjectCreator oc_Newobject70 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject70["bitmap"] = "tools/gui/images/inactive-overlay";
            oc_Newobject70["position"] = "4 45";
            oc_Newobject70["extent"] = "193 42";
            oc_Newobject70["tooltip"] = "A mesh must be selected to edit these properties";
            oc_Newobject70["hovertime"] = "500";
            oc_Newobject70["isContainer"] = "1";
            oc_Newobject70["internalName"] = "editMeshInactive";

            #endregion

            oc_Newobject74["#Newobject70"] = oc_Newobject70;

            #region GuiButtonCtrl ()        oc_Newobject71

            ObjectCreator oc_Newobject71 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject71["text"] = "Import Shape into...";
            oc_Newobject71["groupNum"] = "-1";
            oc_Newobject71["buttonType"] = "PushButton";
            oc_Newobject71["useMouseEvents"] = "0";
            oc_Newobject71["position"] = "4 91";
            oc_Newobject71["extent"] = "102 22";
            oc_Newobject71["MinExtent"] = "8 2";
            oc_Newobject71["HorizSizing"] = "right";
            oc_Newobject71["vertSizing"] = "bottom";
            oc_Newobject71["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject71["Visible"] = "1";
            oc_Newobject71["Command"] = "ShapeEdDetails.onAddMeshFromFile(\\\"\\\");";
            oc_Newobject71["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject71["ToolTip"] = "Add geometry from a different model file into the current shape";
            oc_Newobject71["hovertime"] = "1000";
            oc_Newobject71["isContainer"] = "0";
            oc_Newobject71["canSave"] = "1";
            oc_Newobject71["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject74["#Newobject71"] = oc_Newobject71;

            #region GuiPopUpMenuCtrl ()        oc_Newobject72

            ObjectCreator oc_Newobject72 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject72["position"] = "111 92";
            oc_Newobject72["extent"] = "85 18";
            oc_Newobject72["horizSizing"] = "right";
            oc_Newobject72["vertSizing"] = "bottom";
            oc_Newobject72["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject72["tooltip"] = "Select which detail level new geometry will be added to";
            oc_Newobject72["internalName"] = "addGeomTo";

            #endregion

            oc_Newobject74["#Newobject72"] = oc_Newobject72;

            #region GuiButtonCtrl ()        oc_Newobject73

            ObjectCreator oc_Newobject73 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject73["text"] = "Re-compute bounds";
            oc_Newobject73["groupNum"] = "-1";
            oc_Newobject73["buttonType"] = "PushButton";
            oc_Newobject73["useMouseEvents"] = "0";
            oc_Newobject73["position"] = "40 117";
            oc_Newobject73["extent"] = "122 22";
            oc_Newobject73["MinExtent"] = "8 2";
            oc_Newobject73["HorizSizing"] = "right";
            oc_Newobject73["vertSizing"] = "bottom";
            oc_Newobject73["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject73["Visible"] = "1";
            oc_Newobject73["Command"] = "ShapeEditor.doSetBounds();";
            oc_Newobject73["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject73["ToolTip"] = "Recompute the shape bounding box using the geometry in the current detail level";
            oc_Newobject73["hovertime"] = "1000";
            oc_Newobject73["isContainer"] = "0";
            oc_Newobject73["canSave"] = "1";
            oc_Newobject73["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject74["#Newobject73"] = oc_Newobject73;

            #endregion

            oc_Newobject75["#Newobject74"] = oc_Newobject74;

            #endregion

            oc_Newobject76["#Newobject75"] = oc_Newobject75;

            #endregion

            oc_Newobject88["#Newobject76"] = oc_Newobject76;

            #region GuiTabPageCtrl (ShapeEdMaterials)        oc_Newobject87

            ObjectCreator oc_Newobject87 = new ObjectCreator("GuiTabPageCtrl", "ShapeEdMaterials", typeof (CodeBehind.ShapeEditor.ShapeEdMaterials));
            oc_Newobject87["canSaveDynamicFields"] = "0";
            oc_Newobject87["isContainer"] = "1";
            oc_Newobject87["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject87["HorizSizing"] = "width";
            oc_Newobject87["VertSizing"] = "height";
            oc_Newobject87["Position"] = "0 19";
            oc_Newobject87["Extent"] = "202 418";
            oc_Newobject87["MinExtent"] = "0 -500";
            oc_Newobject87["canSave"] = "1";
            oc_Newobject87["Visible"] = "0";
            oc_Newobject87["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject87["hovertime"] = "1000";
            oc_Newobject87["Margin"] = "0 0 0 0";
            oc_Newobject87["Padding"] = "0 0 0 0";
            oc_Newobject87["AnchorTop"] = "1";
            oc_Newobject87["AnchorBottom"] = "0";
            oc_Newobject87["AnchorLeft"] = "1";
            oc_Newobject87["AnchorRight"] = "0";
            oc_Newobject87["text"] = "Mat";
            oc_Newobject87["maxLength"] = "1024";

            #region GuiContainer ()        oc_Newobject77

            ObjectCreator oc_Newobject77 = new ObjectCreator("GuiContainer", "");
            oc_Newobject77["isContainer"] = "1";
            oc_Newobject77["Profile"] = "GuiInspectorProfile";
            oc_Newobject77["HorizSizing"] = "width";
            oc_Newobject77["VertSizing"] = "height";
            oc_Newobject77["Position"] = "0 0";
            oc_Newobject77["Extent"] = "202 418";
            oc_Newobject77["MinExtent"] = "0 8";

            #endregion

            oc_Newobject87["#Newobject77"] = oc_Newobject77;

            #region GuiBitmapBorderCtrl ()        oc_Newobject78

            ObjectCreator oc_Newobject78 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject78["isContainer"] = "1";
            oc_Newobject78["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject78["HorizSizing"] = "width";
            oc_Newobject78["VertSizing"] = "height";
            oc_Newobject78["Position"] = "0 0";
            oc_Newobject78["Extent"] = "202 418";
            oc_Newobject78["MinExtent"] = "0 8";

            #endregion

            oc_Newobject87["#Newobject78"] = oc_Newobject78;

            #region GuiControl ()        oc_Newobject82

            ObjectCreator oc_Newobject82 = new ObjectCreator("GuiControl", "");
            oc_Newobject82["canSaveDynamicFields"] = "0";
            oc_Newobject82["isContainer"] = "1";
            oc_Newobject82["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject82["HorizSizing"] = "width";
            oc_Newobject82["VertSizing"] = "height";
            oc_Newobject82["Position"] = "0 0";
            oc_Newobject82["Extent"] = "202 345";
            oc_Newobject82["MinExtent"] = "8 8";
            oc_Newobject82["canSave"] = "1";
            oc_Newobject82["Visible"] = "1";
            oc_Newobject82["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject82["hovertime"] = "1000";

            #region GuiScrollCtrl ()        oc_Newobject81

            ObjectCreator oc_Newobject81 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject81["canSaveDynamicFields"] = "0";
            oc_Newobject81["isContainer"] = "1";
            oc_Newobject81["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject81["HorizSizing"] = "width";
            oc_Newobject81["VertSizing"] = "height";
            oc_Newobject81["Position"] = "0 0";
            oc_Newobject81["Extent"] = "202 345";
            oc_Newobject81["MinExtent"] = "8 25";
            oc_Newobject81["canSave"] = "1";
            oc_Newobject81["Visible"] = "1";
            oc_Newobject81["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject81["hovertime"] = "1000";
            oc_Newobject81["Margin"] = "0 0 0 0";
            oc_Newobject81["Padding"] = "0 0 0 0";
            oc_Newobject81["AnchorTop"] = "1";
            oc_Newobject81["AnchorBottom"] = "0";
            oc_Newobject81["AnchorLeft"] = "1";
            oc_Newobject81["AnchorRight"] = "0";
            oc_Newobject81["willFirstRespond"] = "1";
            oc_Newobject81["hScrollBar"] = "dynamic";
            oc_Newobject81["vScrollBar"] = "dynamic";
            oc_Newobject81["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject81["lockVertScroll"] = "false";
            oc_Newobject81["constantThumbHeight"] = "0";
            oc_Newobject81["childMargin"] = "0 0";
            oc_Newobject81["mouseWheelScrollSpeed"] = "-1";

            #region GuiContainer ()        oc_Newobject79

            ObjectCreator oc_Newobject79 = new ObjectCreator("GuiContainer", "");
            oc_Newobject79["internalName"] = "materialListHeader";
            oc_Newobject79["Profile"] = "inspectorStyleRolloutListProfile";
            oc_Newobject79["HorizSizing"] = "width";
            oc_Newobject79["VertSizing"] = "bottom";
            oc_Newobject79["Position"] = "1 1";
            oc_Newobject79["Extent"] = "200 19";
            oc_Newobject79["MinExtent"] = "8 2";

            #endregion

            oc_Newobject81["#Newobject79"] = oc_Newobject79;

            #region GuiTextListCtrl (ShapeEdMaterialList)        oc_Newobject80

            ObjectCreator oc_Newobject80 = new ObjectCreator("GuiTextListCtrl", "ShapeEdMaterialList");
            oc_Newobject80["canSaveDynamicFields"] = "0";
            oc_Newobject80["isContainer"] = "1";
            oc_Newobject80["Profile"] = "GuiShapeEdTextListProfile";
            oc_Newobject80["HorizSizing"] = "right";
            oc_Newobject80["VertSizing"] = "bottom";
            oc_Newobject80["Position"] = "0 0";
            oc_Newobject80["Extent"] = "202 20";
            oc_Newobject80["MinExtent"] = "8 11";
            oc_Newobject80["canSave"] = "1";
            oc_Newobject80["Visible"] = "1";
            oc_Newobject80["Command"] = "ShapeEdMaterials.updateSelectedMaterial(ShapeEdMaterials-->highlightMaterial.getValue());";
            oc_Newobject80["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject80["hovertime"] = "1000";
            oc_Newobject80["enumerate"] = "0";
            oc_Newobject80["resizeCell"] = "1";
            oc_Newobject80["columns"] = "0 130";
            oc_Newobject80["fitParentWidth"] = "0";
            oc_Newobject80["clipColumnText"] = "1";

            #endregion

            oc_Newobject81["#Newobject80"] = oc_Newobject80;

            #endregion

            oc_Newobject82["#Newobject81"] = oc_Newobject81;

            #endregion

            oc_Newobject87["#Newobject82"] = oc_Newobject82;

            #region GuiContainer ()        oc_Newobject86

            ObjectCreator oc_Newobject86 = new ObjectCreator("GuiContainer", "");
            oc_Newobject86["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject86["HorizSizing"] = "width";
            oc_Newobject86["VertSizing"] = "top";
            oc_Newobject86["Position"] = "0 344";
            oc_Newobject86["Extent"] = "202 74";
            oc_Newobject86["isContainer"] = new Creator.StringNoQuote("true");

            #region GuiTextCtrl ()        oc_Newobject83

            ObjectCreator oc_Newobject83 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject83["HorizSizing"] = "right";
            oc_Newobject83["VertSizing"] = "bottom";
            oc_Newobject83["position"] = "5 1";
            oc_Newobject83["Extent"] = "104 16";
            oc_Newobject83["text"] = "Material Options";

            #endregion

            oc_Newobject86["#Newobject83"] = oc_Newobject83;

            #region GuiIconButtonCtrl ()        oc_Newobject84

            ObjectCreator oc_Newobject84 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject84["canSaveDynamicFields"] = "0";
            oc_Newobject84["isContainer"] = "0";
            oc_Newobject84["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject84["HorizSizing"] = "right";
            oc_Newobject84["VertSizing"] = "bottom";
            oc_Newobject84["Position"] = "0 21";
            oc_Newobject84["Extent"] = "150 25";
            oc_Newobject84["MinExtent"] = "8 8";
            oc_Newobject84["canSave"] = "1";
            oc_Newobject84["Visible"] = "1";
            oc_Newobject84["Command"] = "ShapeEdMaterials.editSelectedMaterial();";
            oc_Newobject84["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject84["ToolTip"] = "Open the Material Editor to edit the selected material";
            oc_Newobject84["hovertime"] = "1000";
            oc_Newobject84["text"] = "Edit the selected Material";
            oc_Newobject84["groupNum"] = "0";
            oc_Newobject84["buttonType"] = "PushButton";
            oc_Newobject84["useMouseEvents"] = "0";
            oc_Newobject84["buttonMargin"] = "0 4";
            oc_Newobject84["iconBitmap"] = "tools/worldEditor/images/toolbar/matterial-editor_n";
            oc_Newobject84["textMargin"] = "25";

            #endregion

            oc_Newobject86["#Newobject84"] = oc_Newobject84;

            #region GuiCheckBoxCtrl ()        oc_Newobject85

            ObjectCreator oc_Newobject85 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject85["internalName"] = "highlightMaterial";
            oc_Newobject85["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject85["HorizSizing"] = "right";
            oc_Newobject85["VertSizing"] = "bottom";
            oc_Newobject85["Position"] = "7 52";
            oc_Newobject85["Extent"] = "150 13";
            oc_Newobject85["Command"] = "ShapeEdMaterials.updateSelectedMaterial($ThisControl.getValue());";
            oc_Newobject85["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject85["ToolTip"] = "Highlight the primitives that use the selected Material";
            oc_Newobject85["hovertime"] = "1000";
            oc_Newobject85["text"] = "Highlight selected Material";

            #endregion

            oc_Newobject86["#Newobject85"] = oc_Newobject85;

            #endregion

            oc_Newobject87["#Newobject86"] = oc_Newobject86;

            #endregion

            oc_Newobject88["#Newobject87"] = oc_Newobject87;

            #endregion

            oc_Newobject92["#Newobject88"] = oc_Newobject88;

            #region GuiBitmapButtonCtrl ()        oc_Newobject89

            ObjectCreator oc_Newobject89 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject89["internalName"] = "saveBtn";
            oc_Newobject89["canSaveDynamicFields"] = "0";
            oc_Newobject89["isContainer"] = "0";
            oc_Newobject89["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject89["HorizSizing"] = "left";
            oc_Newobject89["VertSizing"] = "bottom";
            oc_Newobject89["Position"] = "154 25";
            oc_Newobject89["Extent"] = "17 17";
            oc_Newobject89["MinExtent"] = "8 2";
            oc_Newobject89["canSave"] = "1";
            oc_Newobject89["Visible"] = "1";
            oc_Newobject89["Command"] = "ShapeEditor.saveChanges();";
            oc_Newobject89["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject89["ToolTip"] = "Save the current shape";
            oc_Newobject89["hovertime"] = "1000";
            oc_Newobject89["groupNum"] = "0";
            oc_Newobject89["buttonType"] = "PushButton";
            oc_Newobject89["useMouseEvents"] = "0";
            oc_Newobject89["bitmap"] = "tools/gui/images/save-icon";

            #endregion

            oc_Newobject92["#Newobject89"] = oc_Newobject89;

            #region GuiBitmapButtonCtrl ()        oc_Newobject90

            ObjectCreator oc_Newobject90 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject90["internalName"] = "newBtn";
            oc_Newobject90["canSaveDynamicFields"] = "0";
            oc_Newobject90["isContainer"] = "0";
            oc_Newobject90["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject90["HorizSizing"] = "left";
            oc_Newobject90["VertSizing"] = "bottom";
            oc_Newobject90["Position"] = "176 25";
            oc_Newobject90["Extent"] = "17 17";
            oc_Newobject90["MinExtent"] = "8 2";
            oc_Newobject90["canSave"] = "1";
            oc_Newobject90["Visible"] = "1";
            oc_Newobject90["Command"] = "";
            oc_Newobject90["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject90["ToolTip"] = "";
            oc_Newobject90["hovertime"] = "1000";
            oc_Newobject90["groupNum"] = "0";
            oc_Newobject90["buttonType"] = "PushButton";
            oc_Newobject90["useMouseEvents"] = "0";
            oc_Newobject90["bitmap"] = "tools/gui/images/new";

            #endregion

            oc_Newobject92["#Newobject90"] = oc_Newobject90;

            #region GuiBitmapButtonCtrl ()        oc_Newobject91

            ObjectCreator oc_Newobject91 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject91["internalName"] = "deleteBtn";
            oc_Newobject91["canSaveDynamicFields"] = "0";
            oc_Newobject91["isContainer"] = "0";
            oc_Newobject91["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject91["HorizSizing"] = "left";
            oc_Newobject91["VertSizing"] = "bottom";
            oc_Newobject91["Position"] = "190 25";
            oc_Newobject91["Extent"] = "17 17";
            oc_Newobject91["MinExtent"] = "8 2";
            oc_Newobject91["canSave"] = "1";
            oc_Newobject91["Visible"] = "1";
            oc_Newobject91["Command"] = "";
            oc_Newobject91["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject91["ToolTip"] = "";
            oc_Newobject91["hovertime"] = "1000";
            oc_Newobject91["groupNum"] = "0";
            oc_Newobject91["buttonType"] = "PushButton";
            oc_Newobject91["useMouseEvents"] = "0";
            oc_Newobject91["bitmap"] = "tools/gui/images/delete";

            #endregion

            oc_Newobject92["#Newobject91"] = oc_Newobject91;

            #endregion

            oc_Newobject92.Create();

            #region GuiControl (GenImposterGui,EditorGuiGroup)        oc_Newobject95

            ObjectCreator oc_Newobject95 = new ObjectCreator("GuiControl", "GenImposterGui,EditorGuiGroup", typeof (GenImposterGui));
            oc_Newobject95["isContainer"] = "1";
            oc_Newobject95["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject95["HorizSizing"] = "right";
            oc_Newobject95["VertSizing"] = "bottom";
            oc_Newobject95["position"] = "0 0";
            oc_Newobject95["Extent"] = "800 600";
            oc_Newobject95["MinExtent"] = "8 2";
            oc_Newobject95["canSave"] = "1";
            oc_Newobject95["Visible"] = "1";
            oc_Newobject95["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject95["hovertime"] = "1000";
            oc_Newobject95["canSaveDynamicFields"] = "1";

            #region GuiControl ()        oc_Newobject94

            ObjectCreator oc_Newobject94 = new ObjectCreator("GuiControl", "");
            oc_Newobject94["isContainer"] = "1";
            oc_Newobject94["Profile"] = "editorMenu_wBorderProfile";
            oc_Newobject94["HorizSizing"] = "center";
            oc_Newobject94["VertSizing"] = "center";
            oc_Newobject94["position"] = "277 271";
            oc_Newobject94["Extent"] = "245 57";
            oc_Newobject94["MinExtent"] = "8 2";
            oc_Newobject94["canSave"] = "1";
            oc_Newobject94["Visible"] = "1";
            oc_Newobject94["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject94["hovertime"] = "1000";
            oc_Newobject94["internalName"] = "Dialog";
            oc_Newobject94["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject93

            ObjectCreator oc_Newobject93 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject93["text"] = "Generating imposter bitmaps...";
            oc_Newobject93["maxLength"] = "1024";
            oc_Newobject93["Margin"] = "0 0 0 0";
            oc_Newobject93["Padding"] = "0 0 0 0";
            oc_Newobject93["AnchorTop"] = "1";
            oc_Newobject93["AnchorBottom"] = "0";
            oc_Newobject93["AnchorLeft"] = "1";
            oc_Newobject93["AnchorRight"] = "0";
            oc_Newobject93["isContainer"] = "0";
            oc_Newobject93["Profile"] = "ToolsGuiTextBoldCenterProfile";
            oc_Newobject93["HorizSizing"] = "width";
            oc_Newobject93["VertSizing"] = "center";
            oc_Newobject93["position"] = "5 19";
            oc_Newobject93["Extent"] = "236 18";
            oc_Newobject93["MinExtent"] = "8 2";
            oc_Newobject93["canSave"] = "1";
            oc_Newobject93["Visible"] = "1";
            oc_Newobject93["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject93["hovertime"] = "1000";
            oc_Newobject93["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject94["#Newobject93"] = oc_Newobject93;

            #endregion

            oc_Newobject95["#Newobject94"] = oc_Newobject94;

            #endregion

            oc_Newobject95.Create();
        }

        // Update the GUI in response to the shape selection changing
        [ConsoleInteraction]
        public void update_onShapeSelectionChanged()
        {
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
            TSShapeConstructor shape = ShapeEditor.shape;
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
            CodeBehind.ShapeEditor.ShapeEdMaterials ShapeEdMaterials = "ShapeEdMaterials";
            GuiPopUpMenuCtrl objectNode = ShapeEdDetails.FOT("objectNode");

            // --- NODES TAB ---
            ShapeEdNodeTreeView.removeItem(0);
            int rootId = ShapeEdNodeTreeView.insertItem(0, "<root>", "0", "", 1, 1);
            int shapenNodeCount = shape.getNodeCount();
            for (int i = 0; i < shapenNodeCount; i++)
                {
                string name = shape.getNodeName(i);
                if (shape.getNodeParentName(name) == "")
                    ShapeEdNodeTreeView.call("addNodeTree", name);
                }
            this.update_onNodeSelectionChanged(-1); // no node selected

            // --- SEQUENCES TAB ---
            ShapeEdSequenceList.clear();
            ShapeEdSequenceList.addRow(-1, "Name" + '\t' + "Cyclic" + '\t' + "Blend" + '\t' + "Frames" + '\t' + "Priority", -1);
            ShapeEdSequenceList.setRowActive(-1, false);
            ShapeEdSequenceList.addRow(0, "<rootpose>" + '\t' + "" + '\t' + "" + '\t' + "" + '\t' + "", -1);

            int count = shape.getSequenceCount();
            for (int i = 0; i < count; i++)
                {
                string name = shape.getSequenceName(i);

                // Ignore __backup__ sequences (only used by editor)
                if (!Util.startsWith(name, "__backup__", true))
                    ShapeEdSequenceList.call("addItem", name);
                }

            ShapeEdThreadWindow.call("onAddThread"); // add thread 0

            // --- DETAILS TAB ---
            // Add detail levels and meshes to tree
            ShapeEdDetailTree.clearSelection();
            ShapeEdDetailTree.removeItem(0);
            int root = ShapeEdDetailTree.insertItem(0, "<root>", "", "", 1, 1);
            int objCount = shape.getObjectCount();
            for (int i = 0; i < objCount; i++)
                {
                string objName = shape.getObjectName(i);
                int meshCount = shape.getMeshCount(objName);
                for (int j = 0; j < meshCount; j++)
                    {
                    string meshName = shape.getMeshName(objName, j);
                    ShapeEdDetailTree.call("addMeshEntry", meshName, "1");
                    }
                }

            // Initialise object node list
            objectNode.clear();
            objectNode.add("<root>");
            int nodeCount = shape.getNodeCount();
            for (int i = 0; i < nodeCount; i++)
                objectNode.add(shape.getNodeName(i));

            // --- MATERIALS TAB ---
            ShapeEdMaterials.call("updateMaterialList");
        }

        //------------------------------------------------------------------------------
        // Node Editing
        //------------------------------------------------------------------------------

        // Update the GUI in response to the node selection changing
        [ConsoleInteraction]
        public void update_onNodeSelectionChanged(int id)
        {
            CodeBehind.ShapeEditor.ShapeEdSeqNodeTabBook ShapeEdSeqNodeTabBook = "ShapeEdSeqNodeTabBook";
            CodeBehind.ShapeEditor.ShapeEdNodes ShapeEdNodes = "ShapeEdNodes";
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            CodeBehind.ShapeEditor.ShapeEdNodeParentMenu ShapeEdNodeParentMenu = "ShapeEdNodeParentMenu";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            GuiBitmapButtonCtrl deleteBtn = this.FOT("deleteBtn");
            GuiTextEditCtrl nodeName = ShapeEdNodes.FOT("nodeName");
            GuiTextEditCtrl nodePosition = ShapeEdNodes.FOT("nodePosition");
            GuiTextEditCtrl nodeRotation = ShapeEdNodes.FOT("nodeRotation");
            GuiIconButtonCtrl worldTransform = ShapeEdNodes.FOT("worldTransform");
            TSShapeConstructor shape = ShapeEditor.shape;

            if (id > 0)
                {
                // Enable delete button and edit boxes
                if (ShapeEdSeqNodeTabBook["activePage"] == "Node")
                    deleteBtn.setActive(true);
                nodeName.setActive(true);
                nodePosition.setActive(true);
                nodeRotation.setActive(true);

                // Update the node inspection data
                string name = ShapeEdNodeTreeView.getItemText(id);

                nodeName.setText(name);

                // Node parent list => ancestor and sibling nodes only (can't re-parent to a descendent)
                ShapeEdNodeParentMenu.clear();
                string parentNames = ShapeEditor.getNodeNames("", "<root>", name);
                int count = Util.getWordCount(parentNames);
                for (int i = 0; i < count; i++)
                    ShapeEdNodeParentMenu.add(Util.getWord(parentNames, i), i);

                string pName = shape.getNodeParentName(name);
                if (pName == "")
                    pName = "<root>";
                ShapeEdNodeParentMenu.setText(pName);

                string txfm = "";
                if (worldTransform.getValue().AsBool())
                    {
                    // Global transform
                    txfm = shape.getNodeTransform(name, true).AsString();
                    nodePosition.setText(Util.getWords(txfm, 0, 2));
                    nodeRotation.setText(Util.getWords(txfm, 3, 6));
                    }
                else
                    {
                    // Local transform (relative to parent)
                    txfm = shape.getNodeTransform(name, false).AsString();
                    nodePosition.setText(Util.getWords(txfm, 0, 2));
                    nodeRotation.setText(Util.getWords(txfm, 3, 6));
                    }

                ShapeEdShapeView["selectedNode"] = shape.getNodeIndex(name).AsString();
                }
            else
                {
                // Disable delete button and edit boxes
                if (ShapeEdSeqNodeTabBook["activePage"] == "Node")
                    deleteBtn.setActive(false);
                nodeName.setActive(false);
                nodePosition.setActive(false);
                nodeRotation.setActive(false);

                nodeName.setText("");
                nodePosition.setText("");
                nodeRotation.setText("");

                ShapeEdShapeView.selectedNode = -1;
                }
        }

        // Update the GUI in response to a node being added
        [ConsoleInteraction]
        public void update_onNodeAdded(string nodeName, int oldTreeIndex)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            CodeBehind.ShapeEditor.ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

            GuiPopUpMenuCtrl objectNode = ShapeEdDetails.FOT("objectNode");
            GuiPopUpMenuCtrl mountNode = ShapeEdMountWindow.FOT("mountNode");

            // --- MISC ---
            ShapeEdShapeView.refreshShape();
            ShapeEdShapeView.updateNodeTransforms();
            ShapeEdSelectWindow.updateHints();

            // --- MOUNT WINDOW ---
            if (ShapeEdMountWindow.isMountableNode(nodeName))
                {
                mountNode.add(nodeName);
                mountNode.sort();
                }

            // --- NODES TAB ---
            int id = ShapeEdNodeTreeView.addNodeTree(nodeName);
            if (oldTreeIndex <= 0)
                {
                // This is a new node => make it the current selection
                if (id > 0)
                    {
                    ShapeEdNodeTreeView.clearSelection();
                    ShapeEdNodeTreeView.selectItem(id);
                    }
                }
            else
                {
                // This node has been un-deleted. Inserting a new item puts it at the
                // end of the siblings, but we want to restore the original order as
                // if the item was never deleted, so move it up as required.
                int childIndex = ShapeEdNodeTreeView.getChildIndexByName(nodeName);
                while (childIndex > oldTreeIndex)
                    {
                    ShapeEdNodeTreeView.moveItemUp(id);
                    childIndex--;
                    }
                }

            // --- DETAILS TAB ---
            objectNode.add(nodeName);
        }

        // Update the GUI in response to a node(s) being removed
        [ConsoleInteraction]
        public void update_onNodeRemoved(string nameList, int nameCount)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            CodeBehind.ShapeEditor.ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

            GuiPopUpMenuCtrl objectNode = ShapeEdDetails.FOT("objectNode");
            GuiPopUpMenuCtrl mountNode = ShapeEdMountWindow.FOT("mountNode");
            GuiTextListCtrl mountList = ShapeEdMountWindow.FOT("mountList");

            // --- MISC ---
            ShapeEdShapeView.refreshShape();
            ShapeEdShapeView.updateNodeTransforms();
            ShapeEdSelectWindow.updateHints();

            // Remove nodes from the mountable list, and any shapes mounted to the node
            for (int i = 0; i < nameCount; i++)
                {
                string nodeName = Util.getField(nameList, i);
                mountNode.clearEntry(mountNode.findText(nodeName));

                for (int j = mountList.rowCount() - 1; j >= 1; j--)
                    {
                    string text = mountList.getRowText(j);
                    if (Util.getField(text, 1) == nodeName)
                        {
                        ShapeEdShapeView.unmountShape(j - 1);
                        mountList.removeRow(j);
                        }
                    }
                }

            // --- NODES TAB ---
            string lastName = Util.getField(nameList, nameCount - 1);
            int id = ShapeEdNodeTreeView.findItemByName(lastName); // only need to remove the parent item
            if (id > 0)
                {
                ShapeEdNodeTreeView.removeItem(id);
                if (ShapeEdNodeTreeView.getSelectedItem() <= 0)
                    this.update_onNodeSelectionChanged(-1);
                }

            // --- DETAILS TAB ---
            for (int i = 0; i < nameCount; i++)
                {
                string nodeName = Util.getField(nameList, i);
                objectNode.clearEntry(objectNode.findText(nodeName));
                }
        }

        // Update the GUI in response to a node being renamed
        [ConsoleInteraction]
        public void update_onNodeRenamed(string oldName, string newName)
        {
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            CodeBehind.ShapeEditor.ShapeEdMountWindow ShapeEdMountWindow = "ShapeEdMountWindow";
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
            CodeBehind.ShapeEditor.ShapeEdNodes ShapeEdNodes = "ShapeEdNodes";

            GuiTextEditCtrl nodeName = ShapeEdNodes.FOT("nodeName");
            GuiPopUpMenuCtrl objectNode = ShapeEdDetails.FOT("objectNode");
            GuiPopUpMenuCtrl mountNode = ShapeEdMountWindow.FOT("mountNode");
            GuiTextListCtrl mountList = ShapeEdMountWindow.FOT("mountList");

            // --- MISC ---
            ShapeEdSelectWindow.updateHints();

            // --- MOUNT WINDOW ---
            // Update entries for any shapes mounted to this node
            int rowCount = mountList.rowCount();
            for (int i = 1; i < rowCount; i++)
                {
                string text = mountList.getRowText(i);
                if (Util.getField(text, 1) == oldName)
                    {
                    text = Util.setField(text, 1, newName);
                    mountList.setRowById(mountList.getRowId(i), text);
                    }
                }

            // Update list of mountable nodes
            mountNode.clearEntry(mountNode.findText(oldName));
            if (ShapeEdMountWindow.isMountableNode(newName))
                {
                mountNode.add(newName);
                mountNode.sort();
                }

            // --- NODES TAB ---
            int id = ShapeEdNodeTreeView.findItemByName(oldName);
            ShapeEdNodeTreeView.editItem(id, newName, "0");
            if (ShapeEdNodeTreeView.getSelectedItem() == id)
                nodeName.setText(newName);

            // --- DETAILS TAB ---
            id = objectNode.findText(oldName);
            if (id != -1)
                {
                objectNode.clearEntry(id);
                objectNode.add(newName, id);
                objectNode.sortID();
                if (objectNode.getText() == oldName)
                    objectNode.setText(newName);
                }
        }

        // Update the GUI in response to a node's parent being changed
        [ConsoleInteraction]
        public void update_onNodeParentChanged(string nodeName)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";

            // --- MISC ---
            ShapeEdShapeView.updateNodeTransforms();

            // --- NODES TAB ---
            bool isSelected = false;
            int id = ShapeEdNodeTreeView.findItemByName(nodeName);
            if (id > 0)
                {
                isSelected = (ShapeEdNodeTreeView.getSelectedItem() == id);
                ShapeEdNodeTreeView.removeItem(id);
                }
            ShapeEdNodeTreeView.addNodeTree(nodeName);
            if (isSelected)
                ShapeEdNodeTreeView.selectItem(ShapeEdNodeTreeView.findItemByName(nodeName));
        }

        [ConsoleInteraction]
        public void update_onNodeTransformChanged(string nodeName)
        {
            CodeBehind.ShapeEditor.ShapeEdNodeTreeView ShapeEdNodeTreeView = "ShapeEdNodeTreeView";
            CodeBehind.ShapeEditor.ShapeEdNodes ShapeEdNodes = "ShapeEdNodes";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";

            GuiIconButtonCtrl objectTransform = ShapeEdNodes.FOT("objectTransform");
            GuiIconButtonCtrl worldTransform = ShapeEdNodes.FOT("worldTransform");
            GuiTextEditCtrl nodePosition = ShapeEdNodes.FOT("nodePosition");
            GuiTextEditCtrl nodeRotation = ShapeEdNodes.FOT("nodeRotation");

            int id = 0;

            // Default to the selected node if none is specified
            if (nodeName == "")
                {
                id = ShapeEdNodeTreeView.getSelectedItem();
                if (id > 0)
                    nodeName = ShapeEdNodeTreeView.getItemText(id);
                else
                    return;
                }

            // --- MISC ---
            ShapeEdShapeView.updateNodeTransforms();
            if (objectTransform.getValue().AsBool())
                GlobalGizmoProfile.setFieldValue("alignment", "Object", -1);
            else
                GlobalGizmoProfile.setFieldValue("alignment", "World", -1);

            // --- NODES TAB ---
            // Update the node transform fields if necessary
            id = ShapeEdNodeTreeView.getSelectedItem();
            if ((id > 0) && (ShapeEdNodeTreeView.getItemText(id) == nodeName))
                {
                bool isWorld = worldTransform.getValue().AsBool();
                string transform = ShapeEditor.shape.getNodeTransform(nodeName, isWorld).AsString();
                nodePosition.setText(Util.getWords(transform, 0, 2));
                nodeRotation.setText(Util.getWords(transform, 3, 6));
                }
        }

        //------------------------------------------------------------------------------
        // Sequence Editing
        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onWake()
        {
            CodeBehind.ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";

            ShapeEdTriggerList["triggerId"] = "1";

            ShapeEdTriggerList.addRow(-1, "-1" + '\t' + "Frame" + '\t' + "Trigger" + '\t' + "State", -1);
            ShapeEdTriggerList.setRowActive(-1, false);
        }

        [ConsoleInteraction]
        public void update_onSeqSelectionChanged()
        {
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdThreadWindow ShapeEdThreadWindow = "ShapeEdThreadWindow";
            CodeBehind.ShapeEditor.ShapeEdSeqFromMenu ShapeEdSeqFromMenu = "ShapeEdSeqFromMenu";
            CodeBehind.ShapeEditor.ShapeEdSeqNodeTabBook ShapeEdSeqNodeTabBook = "ShapeEdSeqNodeTabBook";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";

            GuiTextListCtrl seqList = ShapeEdThreadWindow.FOT("seqList");
            GuiPopUpMenuCtrl blendSeq = ShapeEdSequences.FOT("blendSeq");
            GuiTextEditCtrl seqName = ShapeEdSequences.FOT("seqName");

            GuiTextEditCtrl blendFrame = ShapeEdSequences.FOT("blendFrame");
            GuiCheckBoxCtrl blendFlag = ShapeEdSequences.FOT("blendFlag");
            GuiCheckBoxCtrl cyclicFlag = ShapeEdSequences.FOT("cyclicFlag");
            GuiTextEditCtrl priority = ShapeEdSequences.FOT("priority");
            GuiBitmapButtonCtrl addTriggerBtn = ShapeEdSequences.FOT("addTriggerBtn");
            GuiBitmapButtonCtrl deleteTriggerBtn = ShapeEdSequences.FOT("deleteTriggerBtn");
            GuiContainer sequenceListHeader = ShapeEdSequences.FOT("sequenceListHeader");
            GuiBitmapButtonCtrl deleteBtn = this.FOT("deleteBtn");

            // Sync the Thread window sequence selection
            int row = ShapeEdSequenceList.getSelectedRow();
            if (seqList.getSelectedRow() != (row - 1))
                {
                seqList.setSelectedRow(row - 1);
                return; // selecting a sequence in the Thread window will re-call this function
                }

            ShapeEdSeqFromMenu.clear();
            blendSeq.clear();

            // Clear the trigger list
            ShapeEdTriggerList.removeAll();

            // Update the active sequence data
            string sequenceName = ShapeEdSequenceList.getSelectedName();
            if (sequenceName != "")
                {
                // Enable delete button and edit boxes
                if (ShapeEdSeqNodeTabBook["activePage"] == "Seq")
                    deleteBtn.setActive(true);
                seqName.setActive(true);
                blendFlag.setActive(true);
                cyclicFlag.setActive(true);
                priority.setActive(true);
                addTriggerBtn.setActive(true);
                deleteTriggerBtn.setActive(true);

                // Initialise the sequence properties
                string blendData = ShapeEditor.shape.getSequenceBlend(sequenceName);
                seqName.setText(sequenceName);
                cyclicFlag.setValue(ShapeEditor.shape.getSequenceCyclic(sequenceName).AsString());
                blendFlag.setValue(Util.getField(blendData, 0));
                priority.setText(ShapeEditor.shape.getSequencePriority(sequenceName).AsString());

                // 'From' and 'Blend' sequence menus
                ShapeEdSeqFromMenu.add("Browse...");
                int count = ShapeEdSequenceList.rowCount();
                for (int i = 2; i < count; i++) // skip header row and <rootpose>
                    {
                    string name = ShapeEdSequenceList.getItemName(i);
                    if (name != sequenceName)
                        {
                        ShapeEdSeqFromMenu.add(name);
                        blendSeq.add(name);
                        }
                    }
                blendSeq.setText(Util.getField(blendData, 1));
                blendFrame.setText(Util.getField(blendData, 2));

                this.syncPlaybackDetails();

                // Triggers (must occur after syncPlaybackDetails is called so the slider range is correct)
                count = ShapeEditor.shape.getTriggerCount(sequenceName);
                for (int i = 0; i < count; i++)
                    {
                    string trigger = ShapeEditor.shape.getTrigger(sequenceName, i);
                    ShapeEdTriggerList.addItem(Util.getWord(trigger, 0).AsInt(), Util.getWord(trigger, 1).AsInt());
                    }
                }
            else
                {
                // Disable delete button and edit boxes
                if (ShapeEdSeqNodeTabBook["activePage"] == "Seq")
                    deleteBtn.setActive(false);
                seqName.setActive(false);
                blendFlag.setActive(false);
                cyclicFlag.setActive(false);
                priority.setActive(false);
                addTriggerBtn.setActive(false);
                deleteTriggerBtn.setActive(false);

                // Clear sequence properties
                seqName.setText("");
                cyclicFlag.setValue("0");
                blendSeq.setText("");
                blendFlag.setValue("0");
                priority.setText("0");

                this.syncPlaybackDetails();
                }

            this.onTriggerSelectionChanged();

            sequenceListHeader.setExtent(new Point2F(Util.getWord(ShapeEdSequenceList["extent"], 0) + ' ' + "19"));

            // Reset current frame
            //ShapeEdAnimWindow.setKeyframe( ShapeEdAnimWindow-->seqIn.getText() );
        }

        // Update the GUI in response to a sequence being added
        [ConsoleInteraction]
        public void update_onSequenceAdded(string seqName, int oldIndex)
        {
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";

            // --- MISC ---
            ShapeEdSelectWindow.updateHints();

            // --- SEQUENCES TAB ---
            if (oldIndex == -1)
                {
                // This is a brand new sequence => add it to the list and make it the
                // current selection
                int row = ShapeEdSequenceList.insertItem(seqName, ShapeEdSequenceList.rowCount());
                ShapeEdSequenceList.scrollVisible(row);
                ShapeEdSequenceList.setSelectedRow(row);
                }
            else
                {
                // This sequence has been un-deleted => add it back to the list at the
                // original position
                ShapeEdSequenceList.insertItem(seqName, oldIndex);
                }
        }

        [ConsoleInteraction]
        public void update_onSequenceRemoved(string seqName)
        {
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            // --- MISC ---
            ShapeEdSelectWindow.updateHints();

            // --- SEQUENCES TAB ---
            bool isSelected = (ShapeEdSequenceList.getSelectedName() == seqName);
            ShapeEdSequenceList.removeItem(seqName);
            if (isSelected)
                this.update_onSeqSelectionChanged();

            // --- THREADS WINDOW ---
            ShapeEdShapeView.refreshThreadSequences();
        }

        [ConsoleInteraction]
        public void update_onSequenceRenamed(string oldName, string newName)
        {
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";

            GuiTextEditCtrl seqName = ShapeEdSequences.FOT("seqName");

            // --- MISC ---
            ShapeEdSelectWindow.updateHints();

            // Rename the proxy sequence as well
            string oldProxy = ShapeEditor.getProxyName(oldName);
            string newProxy = ShapeEditor.getProxyName(newName);
            if (ShapeEditor.shape.getSequenceIndex(oldProxy) != -1)
                ShapeEditor.shape.renameSequence(oldProxy, newProxy);

            // --- SEQUENCES TAB ---
            ShapeEdSequenceList.editColumn(oldName, 0, newName);
            if (ShapeEdSequenceList.getSelectedName() == newName)
                seqName.setText(newName);

            // --- THREADS WINDOW ---
            // Update any threads that use this sequence
            string active = ShapeEdShapeView["activeThread"];
            for (int i = 0; i < ShapeEdShapeView.getThreadCount(); i++)
                {
                ShapeEdShapeView.activeThread = i;
                if (ShapeEdShapeView.getThreadSequence() == oldName)
                    ShapeEdShapeView.setThreadSequence(newName, 0, ShapeEdShapeView.threadPos, false);
                else if (ShapeEdShapeView.getThreadSequence() == oldProxy)
                    ShapeEdShapeView.setThreadSequence(newProxy, 0, ShapeEdShapeView.threadPos, false);
                }
            ShapeEdShapeView["activeThread"] = active;
        }

        [ConsoleInteraction]
        public void update_onSequenceCyclicChanged(string seqName, bool cyclic)
        {
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";

            GuiCheckBoxCtrl cyclicFlag = ShapeEdSequences.FOT("cyclicFlag");

            // --- MISC ---
            // Apply the same transformation to the proxy animation if necessary
            string proxyName = ShapeEditor.getProxyName(seqName);
            if (ShapeEditor.shape.getSequenceIndex(proxyName) != -1)
                ShapeEditor.shape.setSequenceCyclic(proxyName, cyclic);

            // --- SEQUENCES TAB ---
            ShapeEdSequenceList.editColumn(seqName, 1, cyclic ? "yes" : "no");
            if (ShapeEdSequenceList.getSelectedName() == seqName)
                cyclicFlag.setStateOn(cyclic);
        }

        [ConsoleInteraction]
        public void update_onSequenceBlendChanged(string seqName, bool blend, string oldBlendSeq, int oldBlendFrame, string blendSeq, int blendFrame)
        {
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";

            GuiPopUpMenuCtrl ShapeEdSequencesblendSeq = ShapeEdSequences.FOT("blendSeq");
            GuiTextEditCtrl ShapeEdSequencesblendFrame = ShapeEdSequences.FOT("blendFrame");
            GuiCheckBoxCtrl ShapeEdSequencesblendFlag = ShapeEdSequences.FOT("blendFlag");

            // --- MISC ---
            // Apply the same transformation to the proxy animation if necessary
            string proxyName = ShapeEditor.getProxyName(seqName);
            if (ShapeEditor.shape.getSequenceIndex(proxyName) != -1)
                {
                //TODO
                if (blend /*&& oldBlend*/)
                    ShapeEditor.shape.setSequenceBlend(proxyName, false, oldBlendSeq, oldBlendFrame);
                ShapeEditor.shape.setSequenceBlend(proxyName, blend, blendSeq, blendFrame);
                }
            ShapeEdShapeView.updateNodeTransforms();

            // --- SEQUENCES TAB ---
            ShapeEdSequenceList.editColumn(seqName, 2, blend ? "yes" : "no");
            if (ShapeEdSequenceList.getSelectedName() == seqName)
                {
                ShapeEdSequencesblendFlag.setStateOn(blend);
                ShapeEdSequencesblendSeq.setText(blendSeq);
                ShapeEdSequencesblendFrame.setText(blendFrame.AsString());
                }
        }

        [ConsoleInteraction]
        public void update_onSequencePriorityChanged(string seqName)
        {
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";

            GuiTextEditCtrl ShapeEdSequencespriority = ShapeEdSequences.FOT("priority");

            // --- SEQUENCES TAB ---
            float priority = ShapeEditor.shape.getSequencePriority(seqName);
            ShapeEdSequenceList.editColumn(seqName, 4, priority.AsString());
            if (ShapeEdSequenceList.getSelectedName() == seqName)
                ShapeEdSequencespriority.setText(priority.AsString());
        }

        [ConsoleInteraction]
        public void update_onSequenceGroundSpeedChanged(string seqName)
        {
            // nothing to do yet
        }

        [ConsoleInteraction]
        public void syncPlaybackDetails()
        {
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            ShapeEdAnimWindow ShapeEdAnimWindow = "ShapeEdAnimWindow";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdSeqFromMenu ShapeEdSeqFromMenu = "ShapeEdSeqFromMenu";
            CodeBehind.ShapeEditor.ShapeEdSeqSlider ShapeEdSeqSlider = "ShapeEdSeqSlider";
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";
            CodeBehind.ShapeEditor.ShapeEdThreadSlider ShapeEdThreadSlider = "ShapeEdThreadSlider";

            GuiBitmapButtonCtrl seqInBar = ShapeEdAnimWindow.FOT("seqInBar");
            GuiBitmapButtonCtrl seqOutBar = ShapeEdAnimWindow.FOT("seqOutBar");
            GuiTextEditCtrl startFrame = ShapeEdSequences.FOT("startFrame");
            GuiTextEditCtrl endFrame = ShapeEdSequences.FOT("endFrame");

            string seqName = ShapeEdSequenceList.getSelectedName();
            if (seqName != "")
                {
                // Show sequence in/out bars
                seqInBar.setVisible(true);
                seqOutBar.setVisible(true);

                // Sync playback controls
                string sourceData = ShapeEditor.getSequenceSource(seqName);
                string seqFrom = Util.rtrim(Util.getFields(sourceData, 0, 1));
                int seqStart = Util.getField(sourceData, 2).AsInt();
                int seqEnd = Util.getField(sourceData, 3).AsInt();
                string seqFromTotal = Util.getField(sourceData, 4);

                // Display the original source for edited sequences
                if (Util.startsWith(seqFrom, "__backup__", true))
                    {
                    string backupData = ShapeEditor.getSequenceSource(Util.getField(seqFrom, 0));
                    seqFrom = Util.rtrim(Util.getFields(backupData, 0, 1));
                    }

                ShapeEdSeqFromMenu.setText(seqFrom);
                ShapeEdSeqFromMenu["tooltip"] = ShapeEdSeqFromMenu.getText(); // use tooltip to show long names
                startFrame.setText(seqStart.AsString());
                endFrame.setText(seqEnd.AsString());

                float val = (ShapeEdSeqSlider.getValue()/Util.getWord(ShapeEdSeqSlider["range"], 1).AsFloat());
                ShapeEdSeqSlider["range"] = "0" + ' ' + (seqFromTotal.AsFloat() - 1);
                ShapeEdSeqSlider.setValue((val*Util.getWord(ShapeEdSeqSlider["range"], 1).AsFloat()).AsString());
                ShapeEdThreadSlider["range"] = ShapeEdSeqSlider["range"];
                ShapeEdThreadSlider.setValue(ShapeEdSeqSlider["value"]);

                ShapeEdAnimWindow.setSequence(seqName);
                ShapeEdAnimWindow.setPlaybackLimit("in", seqStart);
                ShapeEdAnimWindow.setPlaybackLimit("out", seqEnd);
                }
            else
                {
                // Hide sequence in/out bars
                seqInBar.setVisible(false);
                seqOutBar.setVisible(false);

                ShapeEdSeqFromMenu.setText("");
                ShapeEdSeqFromMenu["tooltip"] = "";
                startFrame.setText("0");
                endFrame.setText("0");

                ShapeEdSeqSlider["range"] = "0 1";
                ShapeEdSeqSlider.setValue("0");
                ShapeEdThreadSlider["range"] = ShapeEdSeqSlider["range"];
                ShapeEdThreadSlider.setValue(ShapeEdSeqSlider["value"]);
                ShapeEdAnimWindow.setPlaybackLimit("in", 0);
                ShapeEdAnimWindow.setPlaybackLimit("out", 1);
                ShapeEdAnimWindow.setSequence("");
                }
        }

        //------------------------------------------------------------------------------
        // Trigger Editing
        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onTriggerSelectionChanged()
        {
            CodeBehind.ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";
            CodeBehind.ShapeEditor.ShapeEdSequences ShapeEdSequences = "ShapeEdSequences";

            GuiTextEditCtrl triggerFrame = ShapeEdSequences.FOT("triggerFrame");
            GuiTextEditCtrl triggerNum = ShapeEdSequences.FOT("triggerNum");
            GuiCheckBoxCtrl triggerOnOff = ShapeEdSequences.FOT("triggerOnOff");

            int row = ShapeEdTriggerList.getSelectedRow();
            if (row > 0) // skip header row
                {
                string text = ShapeEdTriggerList.getRowText(row);

                triggerFrame.setActive(true);
                triggerNum.setActive(true);
                triggerOnOff.setActive(true);

                triggerFrame.setText(Util.getField(text, 1));
                triggerNum.setText(Util.getField(text, 2));
                triggerOnOff.setValue((Util.getField(text, 3) == "on").AsString());
                }
            else
                {
                // No trigger selected
                triggerFrame.setActive(false);
                triggerNum.setActive(false);
                triggerOnOff.setActive(false);

                triggerFrame.setText("");
                triggerNum.setText("");
                triggerOnOff.setValue("0");
                }
        }

        [ConsoleInteraction]
        public void update_onTriggerAdded(string seqName, int frame, float state)
        {
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";

            // --- SEQUENCES TAB ---
            // Add trigger to list if this sequence is selected
            if (ShapeEdSequenceList.getSelectedName() == seqName)
                ShapeEdTriggerList.addItem(frame, state);
        }

        [ConsoleInteraction]
        public void update_onTriggerRemoved(string seqName, int frame, float state)
        {
            CodeBehind.ShapeEditor.ShapeEdSequenceList ShapeEdSequenceList = "ShapeEdSequenceList";
            CodeBehind.ShapeEditor.ShapeEdTriggerList ShapeEdTriggerList = "ShapeEdTriggerList";
            // --- SEQUENCES TAB ---
            // Remove trigger from list if this sequence is selected
            if (ShapeEdSequenceList.getSelectedName() == seqName)
                ShapeEdTriggerList.removeItem(frame, state);
        }

        [ConsoleInteraction]
        public void update_onDetailRenamed(string oldName, string newName)
        {
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

            GuiTextEditCtrl meshName = ShapeEdDetails.FOT("meshName");

            // --- DETAILS TAB ---
            // Rename detail entry
            int id = ShapeEdDetailTree.findItemByName(oldName);
            if (id > 0)
                {
                string size = ShapeEdDetailTree.getItemValue(id);
                ShapeEdDetailTree.editItem(id, newName, size);

                // Sync text if item is selected
                if (ShapeEdDetailTree.isItemSelected(id) && (meshName.getText() != newName))
                    meshName.setText(Util.stripTrailingNumber(newName));
                }
        }

        [ConsoleInteraction]
        public void update_onDetailSizeChanged(string oldSize, string newSize)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEdAdvancedWindow ShapeEdAdvancedWindow = "ShapeEdAdvancedWindow";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

            GuiTextEditCtrl meshSize = ShapeEdDetails.FOT("meshSize");
            GuiTextEditCtrl detailSize = ShapeEdAdvancedWindow.FOT("detailSize");
            // --- MISC ---
            ShapeEdShapeView.refreshShape();
            int dl = ShapeEditor.shape.getDetailLevelIndex(newSize.AsInt());
            if (detailSize.getText() == oldSize)
                {
                ShapeEdShapeView["currentDL"] = dl.AsString();
                detailSize.setText(newSize);
                meshSize.setText(newSize);
                }

            // --- DETAILS TAB ---
            // Update detail entry then resort details by size
            int id = ShapeEdDetailTree.findItemByValue(oldSize);
            string detName = ShapeEditor.shape.getDetailLevelName(dl);
            ShapeEdDetailTree.editItem(id, detName, newSize);

            for (int sibling = ShapeEdDetailTree.getPrevSibling(id); (sibling > 0) && (ShapeEdDetailTree.getItemValue(sibling).AsInt() < newSize.AsInt()); sibling = ShapeEdDetailTree.getPrevSibling(id))
                ShapeEdDetailTree.moveItemUp(id);

            for (int sibling = ShapeEdDetailTree.getNextSibling(id); (sibling > 0) && (ShapeEdDetailTree.getItemValue(sibling).AsInt() > newSize.AsInt()); sibling = ShapeEdDetailTree.getNextSibling(id))
                ShapeEdDetailTree.moveItemDown(id);

            // Update size values for meshes of this detail
            for (int child = ShapeEdDetailTree.getChild(id); child > 0; child = ShapeEdDetailTree.getNextSibling(child))
                {
                string meshName = Util.stripTrailingNumber(ShapeEdDetailTree.getItemText(child));
                ShapeEdDetailTree.editItem(child, meshName + ' ' + newSize, "");
                }
        }

        [ConsoleInteraction]
        public void update_onObjectNodeChanged(string objName)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";

            GuiTextEditCtrl meshName = ShapeEdDetails.FOT("meshName");
            GuiPopUpMenuCtrl objectNode = ShapeEdDetails.FOT("objectNode");

            // --- MISC ---
            ShapeEdShapeView.refreshShape();

            // --- DETAILS TAB ---
            // Update the node popup menu if this object is selected
            if (meshName.getText() == objName)
                {
                string nodeName = ShapeEditor.shape.getObjectNode(objName);
                if (nodeName == "")
                    nodeName = "<root>";
                int id = objectNode.findText(nodeName);
                objectNode.setSelected(id, false);
                }
        }

        [ConsoleInteraction]
        public void update_onObjectRenamed(string oldName, string newName)
        {
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";
            CodeBehind.ShapeEditor.ShapeEdDetails ShapeEdDetails = "ShapeEdDetails";

            GuiTextEditCtrl meshName = ShapeEdDetails.FOT("meshName");

            // --- DETAILS TAB + ---
            // Rename tree entries for this object
            int count = ShapeEditor.shape.getMeshCount(newName);
            for (int i = 0; i < count; i++)
                {
                int size = Util.getTrailingNumber(ShapeEditor.shape.getMeshName(newName, i));
                int id = ShapeEdDetailTree.findItemByName(oldName + ' ' + size);
                if (id > 0)
                    {
                    ShapeEdDetailTree.editItem(id, newName + ' ' + size, "");

                    // Sync text if item is selected
                    if (ShapeEdDetailTree.isItemSelected(id) && (meshName.getText() != newName))
                        meshName.setText(newName);
                    }
                }
        }

        [ConsoleInteraction]
        public void update_onMeshAdded(string meshName)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdColWindow ShapeEdColWindow = "ShapeEdColWindow";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

            GuiPopUpMenuCtrl colTarget = ShapeEdColWindow.FOT("colTarget");
            int id;

            // --- MISC ---
            ShapeEdShapeView.refreshShape();
            ShapeEdShapeView.updateNodeTransforms();

            // --- COLLISION WINDOW ---
            // Add object to target list if it does not already exist
            if (!ShapeEditor.isCollisionMesh(meshName))
                {
                string objName = Util.stripTrailingNumber(meshName);
                id = colTarget.findText(objName);
                if (id == -1)
                    colTarget.add(objName);
                }

            // --- DETAILS TAB ---
            id = ShapeEdDetailTree.addMeshEntry(meshName, false);
            ShapeEdDetailTree.clearSelection();
            ShapeEdDetailTree.selectItem(id);
        }

        [ConsoleInteraction]
        public void update_onMeshSizeChanged(string meshName, string oldSize, string newSize)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

            // --- MISC ---
            ShapeEdShapeView.refreshShape();

            // --- DETAILS TAB ---
            // Move the mesh to the new location in the tree
            int selected = ShapeEdDetailTree.getSelectedItem();
            int id = ShapeEdDetailTree.findItemByName(meshName + ' ' + oldSize);
            ShapeEdDetailTree.removeMeshEntry(meshName + ' ' + oldSize, -1);
            int newId = ShapeEdDetailTree.addMeshEntry(meshName + ' ' + newSize, false);

            // Re-select the new entry if it was selected
            if (selected == id)
                {
                ShapeEdDetailTree.clearSelection();
                ShapeEdDetailTree.selectItem(newId);
                }
        }

        [ConsoleInteraction]
        public void update_onMeshRemoved(string meshName)
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            CodeBehind.ShapeEditor.ShapeEdColWindow ShapeEdColWindow = "ShapeEdColWindow";
            CodeBehind.ShapeEditor.ShapeEdDetailTree ShapeEdDetailTree = "ShapeEdDetailTree";

            GuiPopUpMenuCtrl colTarget = ShapeEdColWindow.FOT("colTarget");
            int id;

            // --- MISC ---
            ShapeEdShapeView.refreshShape();

            // --- COLLISION WINDOW ---
            // Remove object from target list if it no longer exists
            string objName = Util.stripTrailingNumber(meshName);
            if (ShapeEditor.shape.getObjectIndex(objName) == -1)
                {
                id = colTarget.findText(objName);
                if (id != -1)
                    colTarget.clearEntry(id);
                }

            // --- DETAILS TAB ---
            // Determine which item to select next
            id = ShapeEdDetailTree.findItemByName(meshName);
            if (id > 0)
                {
                int nextId = ShapeEdDetailTree.getPrevSibling(id);
                if (nextId <= 0)
                    {
                    nextId = ShapeEdDetailTree.getNextSibling(id);
                    if (nextId <= 0)
                        nextId = 2;
                    }

                // Remove the entry from the tree
                int meshSize = Util.getTrailingNumber(meshName);
                ShapeEdDetailTree.removeMeshEntry(meshName, meshSize);

                // Change selection if needed
                if (ShapeEdDetailTree.getSelectedItem() == -1)
                    ShapeEdDetailTree.selectItem(nextId);
                }
        }

        [ConsoleInteraction]
        public override void onPopWindow()
        {
            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";

            EditorGui.DeactivateAll();
            ShapeEditorPlugin.onActivated();
            //ShapeEdShapeTreeView.open(MissionGroup);
            //ShapeEdShapeTreeView.buildVisibleTree(true);
        }

        [ConsoleInteraction]
        public override void onPopWindowClosed()
        {
            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";

            EditorGui.DeactivateAll();
            ShapeEditorPlugin.onActivated();
            this.attachTo(ShapeEdSelectWindow);
            //ShapeEdShapeTreeView.open(MissionGroup);
            //ShapeEdShapeTreeView.buildVisibleTree(true);
        }

        [TypeConverter(typeof (TypeConverterGeneric<GenImposterGui>))]
        public class GenImposterGui : GuiControl
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiControl Dialog = this.FOT("Dialog");
                Point2I res = this.getExtent();
                int resX = Util.getWord(res.AsString(), 0).AsInt();
                int resY = Util.getWord(res.AsString(), 1).AsInt();

                Point2I dialogExtent = Dialog.getExtent();
                int dialogWidth = Util.getWord(dialogExtent.AsString(), 0).AsInt();
                int dialogHeight = Util.getWord(dialogExtent.AsString(), 1).AsInt();
                Point2I dialogPostion = Dialog.getPosition();

                int posX = (resX/2) - (dialogWidth/2);
                int posY = (resY/2) - (dialogHeight/2);
                Dialog.setPosition(posX, posY);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GenImposterGui ts, string simobjectid)
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
            public static bool operator !=(GenImposterGui ts, string simobjectid)
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
            public static implicit operator string(GenImposterGui ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GenImposterGui(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GenImposterGui) Omni.self.getSimObject(simobjectid, typeof (GenImposterGui));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GenImposterGui ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GenImposterGui(int simobjectid)
            {
                return (GenImposterGui) Omni.self.getSimObject((uint) simobjectid, typeof (GenImposterGui));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GenImposterGui ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GenImposterGui(uint simobjectid)
            {
                return (GenImposterGui) Omni.self.getSimObject(simobjectid, typeof (GenImposterGui));
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
        public static bool operator ==(ShapeEdPropWindow ts, string simobjectid)
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
        public static bool operator !=(ShapeEdPropWindow ts, string simobjectid)
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
        public static implicit operator string(ShapeEdPropWindow ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdPropWindow(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ShapeEdPropWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdPropWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEdPropWindow ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdPropWindow(int simobjectid)
        {
            return (ShapeEdPropWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdPropWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEdPropWindow ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEdPropWindow(uint simobjectid)
        {
            return (ShapeEdPropWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdPropWindow));
        }

        #endregion
    }
}