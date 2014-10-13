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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEdSelectWindow>))]
    public class ShapeEdSelectWindow : GuiWindowCollapseCtrl
    {

        [ConsoleInteraction(true, "ShapeEdSelectWindow_initialize")]
        public static void initialize()
        {
            #region GuiControl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiControl", "");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["HorizSizing"] = "width";
            oc_Newobject25["VertSizing"] = "height";
            oc_Newobject25["Position"] = "0 0";
            oc_Newobject25["Extent"] = "1024 768";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (ShapeEdSelectWindow)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiWindowCollapseCtrl", "ShapeEdSelectWindow", typeof (ShapeEdSelectWindow));
            oc_Newobject24["AllowPopWindow"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject24["HorizSizing"] = "windowRelative";
            oc_Newobject24["VertSizing"] = "windowRelative";
            oc_Newobject24["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC  getWord(EditorGuiToolbar.extent, 1) - 1");
            oc_Newobject24["Extent"] = "210 213";
            oc_Newobject24["MinExtent"] = "210 114";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "0";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["Margin"] = "4 4 4 4";
            oc_Newobject24["Padding"] = "0 0 0 0";
            oc_Newobject24["AnchorTop"] = "1";
            oc_Newobject24["AnchorBottom"] = "0";
            oc_Newobject24["AnchorLeft"] = "1";
            oc_Newobject24["AnchorRight"] = "0";
            oc_Newobject24["resizeWidth"] = "1";
            oc_Newobject24["resizeHeight"] = "1";
            oc_Newobject24["canMove"] = "1";
            oc_Newobject24["canClose"] = "0";
            oc_Newobject24["canMinimize"] = "0";
            oc_Newobject24["canMaximize"] = "0";
            oc_Newobject24["minSize"] = "50 50";
            oc_Newobject24["EdgeSnap"] = "1";
            oc_Newobject24["text"] = "Shapes";

            #region GuiTabBookCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTabBookCtrl", "");
            oc_Newobject22["internalName"] = "TabBook";
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject22["HorizSizing"] = "width";
            oc_Newobject22["VertSizing"] = "height";
            oc_Newobject22["position"] = "4 24";
            oc_Newobject22["Extent"] = "202 165";
            oc_Newobject22["MinExtent"] = "8 -500";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["docking"] = "client";
            oc_Newobject22["Margin"] = "3 1 3 3";
            oc_Newobject22["Padding"] = "0 0 0 0";
            oc_Newobject22["AnchorTop"] = "1";
            oc_Newobject22["AnchorBottom"] = "0";
            oc_Newobject22["AnchorLeft"] = "1";
            oc_Newobject22["AnchorRight"] = "0";
            oc_Newobject22["TabPosition"] = "Top";
            oc_Newobject22["TabMargin"] = "6";
            oc_Newobject22["MinTabWidth"] = "32";

            #region GuiTabPageCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["Position"] = "0 19";
            oc_Newobject3["Extent"] = "202 146";
            oc_Newobject3["MinExtent"] = "0 -500";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "0";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["text"] = "Scene";
            oc_Newobject3["maxLength"] = "1024";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["Extent"] = "202 146";
            oc_Newobject2["MinExtent"] = "8 -500";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "dynamic";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";

            #region GuiTreeViewCtrl (ShapeEdShapeTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "ShapeEdShapeTreeView", typeof (CodeBehind.ShapeEditor.ShapeEdShapeTreeView));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "1 1";
            oc_Newobject1["Extent"] = "190 144";
            oc_Newobject1["MinExtent"] = "8 -500";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["TabSize"] = "16";
            oc_Newobject1["textOffset"] = "2";
            oc_Newobject1["fullRowSelect"] = "0";
            oc_Newobject1["itemHeight"] = "21";
            oc_Newobject1["destroyTreeOnSleep"] = "1";
            oc_Newobject1["MouseDragging"] = "1";
            oc_Newobject1["MultipleSelections"] = "1";
            oc_Newobject1["DeleteObjectAllowed"] = "1";
            oc_Newobject1["DragToItemAllowed"] = "1";
            oc_Newobject1["showRoot"] = "1";
            oc_Newobject1["internalNamesOnly"] = "0";
            oc_Newobject1["showObjectIds"] = "0";
            oc_Newobject1["showClassNames"] = "0";
            oc_Newobject1["showObjectNames"] = "1";
            oc_Newobject1["showInternalNames"] = "1";
            oc_Newobject1["showClassNameForUnnamedObjects"] = "1";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject22["#Newobject3"] = oc_Newobject3;

            #region GuiTabPageCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "height";
            oc_Newobject10["position"] = "0 19";
            oc_Newobject10["Extent"] = "202 146";
            oc_Newobject10["MinExtent"] = "0 -500";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "0";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["text"] = "Library";
            oc_Newobject10["maxLength"] = "1024";

            #region GuiContainer ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiContainer", "");
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["position"] = "0 0";
            oc_Newobject4["Extent"] = "202 146";
            oc_Newobject4["MinExtent"] = "0 -500";
            oc_Newobject4["Profile"] = "GuiInspectorProfile";

            #endregion

            oc_Newobject10["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapBorderCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "202 146";
            oc_Newobject5["MinExtent"] = "0 -500";
            oc_Newobject5["Profile"] = "ToolsGuiTabBorderProfile";

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "3 4";
            oc_Newobject6["Extent"] = "20 19";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "ShapeEdSelectWindow.navigateUp();";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["groupNum"] = "0";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["bitmap"] = "tools/gui/images/folderUp";

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiPopUpMenuCtrl (ShapeEdSelectMenu)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiPopUpMenuCtrl", "ShapeEdSelectMenu", typeof (CodeBehind.ShapeEditor.ShapeEdSelectMenu));
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "26 4";
            oc_Newobject7["Extent"] = "172 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["text"] = "art";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["maxPopupHeight"] = "200";
            oc_Newobject7["sbUsesNAColor"] = "0";
            oc_Newobject7["reverseTextList"] = "0";
            oc_Newobject7["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiScrollCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "height";
            oc_Newobject9["position"] = "0 24";
            oc_Newobject9["Extent"] = "202 122";
            oc_Newobject9["MinExtent"] = "8 -500";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["willFirstRespond"] = "1";
            oc_Newobject9["hScrollBar"] = "dynamic";
            oc_Newobject9["vScrollBar"] = "dynamic";
            oc_Newobject9["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject9["lockVertScroll"] = "false";
            oc_Newobject9["constantThumbHeight"] = "0";
            oc_Newobject9["childMargin"] = "0 0";
            oc_Newobject9["mouseWheelScrollSpeed"] = "-1";

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject8["internalName"] = "shapeLibrary";
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "1 1";
            oc_Newobject8["Extent"] = "189 42";
            oc_Newobject8["MinExtent"] = "8 11";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["colCount"] = "1";
            oc_Newobject8["colSize"] = "64";
            oc_Newobject8["rowCount"] = "0";
            oc_Newobject8["RowSize"] = "64";
            oc_Newobject8["rowSpacing"] = "4";
            oc_Newobject8["colSpacing"] = "4";
            oc_Newobject8["frozen"] = "0";
            oc_Newobject8["autoCellSize"] = "1";
            oc_Newobject8["fillRowFirst"] = "1";
            oc_Newobject8["dynamicSize"] = "1";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject22["#Newobject10"] = oc_Newobject10;

            #region GuiTabPageCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "height";
            oc_Newobject21["position"] = "0 19";
            oc_Newobject21["Extent"] = "202 146";
            oc_Newobject21["MinExtent"] = "0 -500";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "0";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["text"] = "Hints";
            oc_Newobject21["maxLength"] = "1024";

            #region GuiContainer ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiContainer", "");
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "height";
            oc_Newobject11["position"] = "0 0";
            oc_Newobject11["Extent"] = "202 146";
            oc_Newobject11["MinExtent"] = "0 -500";
            oc_Newobject11["Profile"] = "GuiInspectorProfile";

            #endregion

            oc_Newobject21["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapBorderCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "height";
            oc_Newobject12["position"] = "0 0";
            oc_Newobject12["Extent"] = "202 146";
            oc_Newobject12["MinExtent"] = "0 -500";
            oc_Newobject12["Profile"] = "ToolsGuiTabBorderProfile";

            #endregion

            oc_Newobject21["#Newobject12"] = oc_Newobject12;

            #region GuiScrollCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject18["HorizSizing"] = "width";
            oc_Newobject18["VertSizing"] = "height";
            oc_Newobject18["position"] = "0 24";
            oc_Newobject18["Extent"] = "202 123";
            oc_Newobject18["MinExtent"] = "8 -500";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["willFirstRespond"] = "1";
            oc_Newobject18["hScrollBar"] = "dynamic";
            oc_Newobject18["vScrollBar"] = "dynamic";
            oc_Newobject18["lockHorizScroll"] = new Creator.StringNoQuote("true");
            oc_Newobject18["lockVertScroll"] = "false";
            oc_Newobject18["constantThumbHeight"] = "0";
            oc_Newobject18["childMargin"] = "0 0";
            oc_Newobject18["mouseWheelScrollSpeed"] = "-1";

            #region GuiStackControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "0 1";
            oc_Newobject17["Extent"] = "185 50";
            oc_Newobject17["MinExtent"] = "8 8";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["StackingType"] = "Vertical";
            oc_Newobject17["HorizStacking"] = "Left to Right";
            oc_Newobject17["VertStacking"] = "Top to Bottom";
            oc_Newobject17["Padding"] = "2";

            #region GuiRolloutCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject14["Profile"] = "GuiShapeEdRolloutProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "1 0";
            oc_Newobject14["Extent"] = "184 24";
            oc_Newobject14["MinExtent"] = "8 -500";
            oc_Newobject14["Caption"] = "Nodes";
            oc_Newobject14["Margin"] = "2 2 2 2";
            oc_Newobject14["Expanded"] = "0";

            #region GuiStackControl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject13["internalName"] = "nodeHints";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "0 24";
            oc_Newobject13["Extent"] = "184 0";
            oc_Newobject13["MinExtent"] = "8 -500";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["StackingType"] = "Vertical";
            oc_Newobject13["HorizStacking"] = "Left to Right";
            oc_Newobject13["VertStacking"] = "Top to Bottom";
            oc_Newobject13["Padding"] = "2";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject17["#Newobject14"] = oc_Newobject14;

            #region GuiRolloutCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject16["Profile"] = "GuiShapeEdRolloutProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "1 26";
            oc_Newobject16["Extent"] = "184 24";
            oc_Newobject16["MinExtent"] = "8 -500";
            oc_Newobject16["Caption"] = "Sequences";
            oc_Newobject16["Margin"] = "2 2 2 2";
            oc_Newobject16["Expanded"] = "0";

            #region GuiStackControl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject15["internalName"] = "sequenceHints";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "0 0";
            oc_Newobject15["Extent"] = "184 24";
            oc_Newobject15["MinExtent"] = "8 -500";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["StackingType"] = "Vertical";
            oc_Newobject15["HorizStacking"] = "Left to Right";
            oc_Newobject15["VertStacking"] = "Top to Bottom";
            oc_Newobject15["Padding"] = "2";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject21["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["Position"] = "5 5";
            oc_Newobject19["Extent"] = "60 16";
            oc_Newobject19["text"] = "Shape Type";

            #endregion

            oc_Newobject21["#Newobject19"] = oc_Newobject19;

            #region GuiPopUpMenuCtrl (ShapeEdHintMenu)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiPopUpMenuCtrl", "ShapeEdHintMenu", typeof (CodeBehind.ShapeEditor.ShapeEdHintMenu));
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject20["HorizSizing"] = "width";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "66 4";
            oc_Newobject20["Extent"] = "132 18";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["text"] = "art";
            oc_Newobject20["maxLength"] = "1024";
            oc_Newobject20["maxPopupHeight"] = "200";
            oc_Newobject20["sbUsesNAColor"] = "0";
            oc_Newobject20["reverseTextList"] = "0";
            oc_Newobject20["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject24["#Newobject22"] = oc_Newobject22;

            #region GuiCheckBoxCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject23["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject23["HorizSizing"] = "left";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "135 27";
            oc_Newobject23["Extent"] = "72 13";
            oc_Newobject23["Variable"] = "EWorldEditor.forceLoadDAE";
            oc_Newobject23["Command"] = "EWorldEditor.forceLoadDAE = $ThisControl.getValue(); EditorSettings.setValue(\\\"forceLoadDAE\\\", EWorldEditor.forceLoadDAE);";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["ToolTip"] = "Forces loading of DAE files (ignores cached.dts if present)";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["text"] = " Force DAE";

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject25.Create();
        }

        [ConsoleInteraction]
        public void onSelect(string path)
        {
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            GuiControl ColladaImportDlg = "ColladaImportDlg";
            string cmd = "";

            // Prompt user to save the old shape if it is dirty
            if (ShapeEditor.isDirty())
                {
                cmd = "ColladaImportDlg.showDialog( \"" + path + "\", \"ShapeEditor.selectShape( \\\"" + path + "\\\", ";
                messageBox.MessageBoxYesNoCancel("Shape Modified", "Would you like to save your changes?", cmd + "true );\" );", cmd + "false );\" );");
                }
            else
                {
                cmd = "ShapeEditor.selectShape( \"" + path + "\", false );";
                ColladaImportDlg.call("showDialog", path, cmd);
                }
        }

        // Find all DTS or COLLADA models. Note: most of this section was shamelessly
        // stolen from creater.ed.cs => great work whoever did the original!
        [ConsoleInteraction]
        public void navigate(string address)
        {
            CodeBehind.ShapeEditor.ShapeEdSelectMenu ShapeEdSelectMenu = "ShapeEdSelectMenu";
            GuiDynamicCtrlArrayControl shapeLibrary = this.FOT("shapeLibrary");

            // Freeze the icon array so it doesn't update until we've added all of the
            // icons
            shapeLibrary.frozen = true;
            shapeLibrary.clear();
            ShapeEdSelectMenu.clear();

            string filePatterns = "*.dts" + '\t' + "*.dae" + '\t' + "*.kmz";
            string fullPath = Util.findFirstFileMultiExpr(filePatterns, true);

            while (fullPath != "")
                {
                // Ignore cached DTS files
                if (Util.endsWith(fullPath, "cached.dts", false))
                    {
                    fullPath = Util.findNextFileMultiExpr(filePatterns);
                    continue;
                    }

                // Ignore assets in the tools folder
                fullPath = Util.makeRelativePath(fullPath, Util.getMainDotCsDir());
                string splitPath = Util.strreplace(fullPath, "/", " ");
                if (Util.getWord(splitPath, 0) == "tools")
                    {
                    fullPath = Util.findNextFileMultiExpr(filePatterns);
                    continue;
                    }

                int dirCount = Util.getWordCount(splitPath) - 1;
                string pathFolders = Util.getWords(splitPath, 0, dirCount - 1);

                // Add this file's path ( parent folders ) to the
                // popup menu if it isn't there yet.
                string temp = Util.strreplace(pathFolders, " ", "/");
                int r = ShapeEdSelectMenu.findText(temp);
                if (r == -1)
                    ShapeEdSelectMenu.add(temp);

                // Is this file in the current folder?
                if (Util.stricmp(pathFolders, address) == 0)
                    this.addShapeIcon(fullPath);
                    // Then is this file in a subfolder we need to add
                    // a folder icon for?
                else
                    {
                    int wordIdx = 0;
                    bool add = false;

                    if (address == "")
                        {
                        add = true;
                        wordIdx = 0;
                        }
                    else
                        {
                        for (; wordIdx < dirCount; wordIdx++)
                            {
                            temp = Util.getWords(splitPath, 0, wordIdx);
                            if (Util.stricmp(temp, address) == 0)
                                {
                                add = true;
                                wordIdx++;
                                break;
                                }
                            }
                        }

                    if (add)
                        {
                        string folder = Util.getWord(splitPath, wordIdx);

                        // Add folder icon if not already present
                        string ctrl = this.findIconCtrl(folder);
                        if (ctrl == "-1")
                            this.addFolderIcon(folder);
                        }
                    }

                fullPath = Util.findNextFileMultiExpr(filePatterns);
                }

            shapeLibrary.sort("alphaIconCompare");
            for (uint i = 0; i < shapeLibrary.getCount(); i++)
                ((SimObject) shapeLibrary.getObject(i))["autoSize"] = false.AsString();

            shapeLibrary.frozen = false;
            shapeLibrary.refresh();
            this["address"] = address;

            ShapeEdSelectMenu.sort();

            string str = Util.strreplace(address, " ", "/");
            int s = ShapeEdSelectMenu.findText(str);
            if (s != -1)
                ShapeEdSelectMenu.setSelected(s, false);
            else
                ShapeEdSelectMenu.setText(str);
        }

        [ConsoleInteraction]
        public void navigateDown(string folder)
        {
            string address = "";
            if (this["address"] == "")
                address = folder;
            else
                address = this["address"] + ' ' + folder;

            // Because this is called from an IconButton::onClick command
            // we have to wait a tick before actually calling navigate, else
            // we would delete the button out from under itself.
            this.schedule("1", "navigate", address);
        }

        [ConsoleInteraction]
        public void navigateUp()
        {
            string address = "";

            int count = Util.getWordCount(this["address"]);

            if (count == 0)
                return;

            address = count == 1 ? "" : Util.getWords(this["address"], 0, count - 2);

            this.navigate(address);
        }

        [ConsoleInteraction]
        public string findIconCtrl(string name)
        {
            GuiDynamicCtrlArrayControl shapeLibrary = this.FOT("shapeLibrary");

            for (uint i = 0; i < shapeLibrary.getCount(); i++)
                {
                SimObject ctrl = shapeLibrary.getObject(i);
                if (ctrl["text"] == name)
                    return ctrl;
                }
            return "-1";
        }

        [ConsoleInteraction]
        public string createIcon()
        {
            #region GuiIconButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject3["profile"] = "GuiCreatorIconButtonProfile";
            oc_Newobject3["iconLocation"] = "Left";
            oc_Newobject3["textLocation"] = "Right";
            oc_Newobject3["extent"] = "348 19";
            oc_Newobject3["textMargin"] = new Creator.StringNoQuote("8");
            oc_Newobject3["buttonMargin"] = "2 2";
            oc_Newobject3["autoSize"] = new Creator.StringNoQuote("false");
            oc_Newobject3["sizeIconToButton"] = new Creator.StringNoQuote("true");
            oc_Newobject3["makeIconSquare"] = new Creator.StringNoQuote("true");
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["groupNum"] = "-1";

            #endregion

            GuiIconButtonCtrl ctrl = oc_Newobject3.Create();

            return ctrl;
        }

        [ConsoleInteraction]
        public void addFolderIcon(string text)
        {
            GuiIconButtonCtrl ctrl = this.createIcon();
            GuiDynamicCtrlArrayControl shapeLibrary = this.FOT("shapeLibrary");

            ctrl.altCommand = "ShapeEdSelectWindow.navigateDown( \"" + text + "\" );";
            ctrl.iconBitmap = "tools/gui/images/folder.png";
            ctrl.text = text;
            ctrl.tooltip = text;
            //ctrl["class"] = "CreatorFolderIconBtn";

            ctrl.buttonType = "RadioButton";
            ctrl["groupNum"] = "-1";

            shapeLibrary.addGuiControl(ctrl);
        }

        [ConsoleInteraction]
        public void addShapeIcon(string fullPath)
        {
            GuiIconButtonCtrl ctrl = this.createIcon();
            GuiDynamicCtrlArrayControl shapeLibrary = this.FOT("shapeLibrary");

            string ext = Util.fileExt(fullPath);
            string file = Util.fileBase(fullPath);
            string fileLong = file + ext;
            string tip = fileLong + '\n' + "Size: " + Util.fileSize(fullPath)/1000.0 + ' ' + "KB" + '\n' + "Date Created: " + Util.fileCreatedTime(fullPath) + '\n' + "Last Modified: " + Util.fileModifiedTime(fullPath);

            ctrl.altCommand = "ShapeEdSelectWindow.onSelect( \"" + fullPath + "\" );";
            ctrl.iconBitmap = ((ext == ".dts") ? console.Call_Classname("EditorIconRegistry", "findIconByClassName", new string[] {"TSStatic"}) : "tools/gui/images/iconCollada");
            ctrl.text = file;
            //ctrl["class"] = "CreatorStaticIconBtn";
            ctrl.tooltip = tip;

            ctrl.buttonType = "RadioButton";
            ctrl.groupNum = -1;

            // Check if a shape specific icon is available
            const string formats = ".png .jpg .dds .bmp .gif .jng .tga";
            int count = Util.getWordCount(formats);
            for (int i = 0; i < count; i++)
                {
                ext = Util.getWord(formats, i);
                if (Util.isFile(fullPath + ext))
                    {
                    ctrl["iconBitmap"] = fullPath + ext;
                    break;
                    }
                }

            shapeLibrary.addGuiControl(ctrl);
        }

        [ConsoleInteraction]
        public void updateHints()
        {
            CodeBehind.ShapeEditor.ShapeEdHintMenu ShapeEdHintMenu = "ShapeEdHintMenu";
            GuiStackControl nodeHints = this.FOT("nodeHints");
            GuiStackControl sequenceHints = this.FOT("sequenceHints");
            SimGroup ShapeHintControls = "ShapeHintControls";
            SimGroup ShapeHintGroup = "ShapeHintGroup";

            string objectType = ShapeEdHintMenu.getText();

            nodeHints.freeze(true);
            sequenceHints.freeze(true);

            // Move all current hint controls to a holder SimGroup
            for (int i = nodeHints.getCount() - 1; i >= 0; i--)
                ShapeHintControls.add(nodeHints.getObject((uint) i));
            for (int i = sequenceHints.getCount() - 1; i >= 0; i--)
                ShapeHintControls.add(sequenceHints.getObject((uint) i));

            // Update node and sequence hints, modifying and/or creating gui controls as needed
            for (uint i = 0; i < ShapeHintGroup.getCount(); i++)
                {
                SimObject hint = ShapeHintGroup.getObject(i);
                if ((objectType == hint["objectType"]) || Util.isMemberOfClass(objectType, hint["objectType"]))
                    {
                    for (int idx = 0; hint["node[" + idx + "]"] != ""; idx++)
                        ShapeEdHintMenu.processHint("node", hint["node[" + idx + "]"]);

                    for (int idx = 0; hint["sequence[" + idx + "]"] != ""; idx++)
                        ShapeEdHintMenu.processHint("sequence", hint["sequence[" + idx + "]"]);
                    }
                }

            nodeHints.freeze(false);
            nodeHints.updateStack();
            sequenceHints.freeze(false);
            sequenceHints.updateStack();
        }

        [ConsoleInteraction]
        public void addObjectHint(string type, string name, string desc, bool present, string start, string end)
        {
            SimGroup ShapeHintControls = "ShapeHintControls";
            GuiIconButtonCtrl ctrl = "";
            GuiStackControl nodeHints = this.FOT("nodeHints");
            GuiStackControl sequenceHints = this.FOT("sequenceHints");

            // Get a hint gui control (create one if needed)
            if (ShapeHintControls.getCount() == 0)
                {
                #region GuiIconButtonCtrl ()        oc_Newobject4

                ObjectCreator oc_Newobject4 = new ObjectCreator("GuiIconButtonCtrl", "");
                oc_Newobject4["profile"] = "GuiCreatorIconButtonProfile";
                oc_Newobject4["iconLocation"] = "Left";
                oc_Newobject4["textLocation"] = "Right";
                oc_Newobject4["extent"] = "348 19";
                oc_Newobject4["textMargin"] = new Creator.StringNoQuote("8");
                oc_Newobject4["buttonMargin"] = "2 2";
                oc_Newobject4["autoSize"] = new Creator.StringNoQuote("true");
                oc_Newobject4["buttonType"] = "RadioButton";
                oc_Newobject4["groupNum"] = "-1";
                oc_Newobject4["iconBitmap"] = "tools/editorClasses/gui/images/iconCancel";
                oc_Newobject4["text"] = "hint";
                oc_Newobject4["tooltip"] = "";

                #endregion

                ctrl = oc_Newobject4.Create();

                ShapeHintControls.add(ctrl);
                }

            ctrl = ShapeHintControls.getObject(0);

            // Initialise the control, then add it to the appropriate list
            name = name + start;
            if (end != start)
                ctrl["text"] = name + "-" + end;
            else
                ctrl["text"] = name;

            ctrl["tooltip"] = desc;
            ctrl.setBitmap("tools/editorClasses/gui/images/" + (present ? "iconAccept" : "iconCancel"));
            ctrl.setStateOn(false);
            ctrl.resetState();

            switch (type)
                {
                    case "node":
                        ctrl["altCommand"] = present ? "" : "ShapeEdNodes.onAddNode( \"" + name + "\" );";
                        nodeHints.addGuiControl(ctrl);
                        break;
                    case "sequence":
                        ctrl["altCommand"] = present ? "" : "ShapeEdSequences.onAddSequence( \"" + name + "\" );";
                        sequenceHints.addGuiControl(ctrl);
                        break;
                }
        }

        [ConsoleInteraction]
        public override void onPopWindow()
        {
            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";
            CodeBehind.ShapeEditor.ShapeEdShapeTreeView ShapeEdShapeTreeView = "ShapeEdShapeTreeView";
            SimGroup MissionGroup = "MissionGroup";

            EditorGui.DeactivateAll();
            ShapeEditorPlugin.onActivated();
            ShapeEdShapeTreeView.open(MissionGroup);
            ShapeEdShapeTreeView.buildVisibleTree(true);
        }

        [ConsoleInteraction]
        public override void onPopWindowClosed()
        {
            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";
            CodeBehind.ShapeEditor.ShapeEdShapeTreeView ShapeEdShapeTreeView = "ShapeEdShapeTreeView";
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            SimGroup MissionGroup = "MissionGroup";

            EditorGui.DeactivateAll();
            ShapeEditorPlugin.onActivated();
            this.attachTo(ShapeEdPropWindow);
            ShapeEdShapeTreeView.open(MissionGroup);
            ShapeEdShapeTreeView.buildVisibleTree(true);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ShapeEdSelectWindow ts, string simobjectid)
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
        public static bool operator !=(ShapeEdSelectWindow ts, string simobjectid)
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
        public static implicit operator string(ShapeEdSelectWindow ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdSelectWindow(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ShapeEdSelectWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSelectWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEdSelectWindow ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdSelectWindow(int simobjectid)
        {
            return (ShapeEdSelectWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdSelectWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEdSelectWindow ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEdSelectWindow(uint simobjectid)
        {
            return (ShapeEdSelectWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdSelectWindow));
        }

        #endregion
    }
}