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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEdAdvancedWindow>))]
    public class ShapeEdAdvancedWindow : GuiWindowCollapseCtrl
    {
        [ConsoleInteraction(true, "ShapeEdAdvancedWindow_initialize")]
        public static void initialize()
        {
            #region GuiWindowCollapseCtrl (ShapeEdAdvancedWindow, EditorGuiGroup)        oc_Newobject117

            ObjectCreator oc_Newobject117 = new ObjectCreator("GuiWindowCollapseCtrl", "ShapeEdAdvancedWindow, EditorGuiGroup", typeof (ShapeEdAdvancedWindow));
            oc_Newobject117["AllowPopWindow"] = "1";
            oc_Newobject117["text"] = "Advanced Properties";
            oc_Newobject117["resizeWidth"] = "0";
            oc_Newobject117["resizeHeight"] = "0";
            oc_Newobject117["canMove"] = "1";
            oc_Newobject117["canClose"] = "1";
            oc_Newobject117["canMinimize"] = "0";
            oc_Newobject117["canMaximize"] = "0";
            oc_Newobject117["closeCommand"] = "ShapeEditorToolbar-->showAdvanced.performClick();";
            oc_Newobject117["EdgeSnap"] = "1";
            oc_Newobject117["Margin"] = "4 4 4 4";
            oc_Newobject117["Padding"] = "0 0 0 0";
            oc_Newobject117["AnchorTop"] = "1";
            oc_Newobject117["AnchorBottom"] = "0";
            oc_Newobject117["AnchorLeft"] = "1";
            oc_Newobject117["AnchorRight"] = "0";
            oc_Newobject117["position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 - 209 SPC getWord(EditorGuiToolbar.extent, 1) - 1");
            oc_Newobject117["extent"] = "210 272";
            oc_Newobject117["MinExtent"] = "210 253";
            oc_Newobject117["HorizSizing"] = "windowRelative";
            oc_Newobject117["VertSizing"] = "windowRelative";
            oc_Newobject117["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject117["Visible"] = "0";
            oc_Newobject117["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject117["hovertime"] = "1000";
            oc_Newobject117["isContainer"] = "1";
            oc_Newobject117["canSave"] = "1";
            oc_Newobject117["canSaveDynamicFields"] = "0";
            oc_Newobject117["minSize"] = "50 50";

            #region GuiTabBookCtrl ()        oc_Newobject116

            ObjectCreator oc_Newobject116 = new ObjectCreator("GuiTabBookCtrl", "");
            oc_Newobject116["TabPosition"] = "Top";
            oc_Newobject116["TabMargin"] = "6";
            oc_Newobject116["MinTabWidth"] = "32";
            oc_Newobject116["docking"] = "client";
            oc_Newobject116["Margin"] = "3 1 3 3";
            oc_Newobject116["Padding"] = "0 0 0 0";
            oc_Newobject116["AnchorTop"] = "1";
            oc_Newobject116["AnchorBottom"] = "0";
            oc_Newobject116["AnchorLeft"] = "1";
            oc_Newobject116["AnchorRight"] = "0";
            oc_Newobject116["position"] = "4 24";
            oc_Newobject116["extent"] = "202 243";
            oc_Newobject116["MinExtent"] = "8 -500";
            oc_Newobject116["HorizSizing"] = "width";
            oc_Newobject116["VertSizing"] = "height";
            oc_Newobject116["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject116["Visible"] = "1";
            oc_Newobject116["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject116["hovertime"] = "1000";
            oc_Newobject116["isContainer"] = "1";
            oc_Newobject116["internalName"] = "tabBook";
            oc_Newobject116["canSave"] = "1";
            oc_Newobject116["canSaveDynamicFields"] = "0";

            #region GuiTabPageCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject43["text"] = "Details";
            oc_Newobject43["maxLength"] = "1024";
            oc_Newobject43["Margin"] = "0 0 0 0";
            oc_Newobject43["Padding"] = "0 0 0 0";
            oc_Newobject43["AnchorTop"] = "1";
            oc_Newobject43["AnchorBottom"] = "0";
            oc_Newobject43["AnchorLeft"] = "1";
            oc_Newobject43["AnchorRight"] = "0";
            oc_Newobject43["Position"] = "0 19";
            oc_Newobject43["extent"] = "202 224";
            oc_Newobject43["MinExtent"] = "0 -500";
            oc_Newobject43["HorizSizing"] = "width";
            oc_Newobject43["VertSizing"] = "height";
            oc_Newobject43["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject43["Visible"] = "0";
            oc_Newobject43["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["isContainer"] = "1";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["canSaveDynamicFields"] = "0";

            #region GuiContainer ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiContainer", "");
            oc_Newobject42["docking"] = "client";
            oc_Newobject42["Margin"] = "0 0 0 0";
            oc_Newobject42["Padding"] = "0 0 0 0";
            oc_Newobject42["AnchorTop"] = "1";
            oc_Newobject42["AnchorBottom"] = "0";
            oc_Newobject42["AnchorLeft"] = "1";
            oc_Newobject42["AnchorRight"] = "0";
            oc_Newobject42["position"] = "0 0";
            oc_Newobject42["extent"] = "202 224";
            oc_Newobject42["MinExtent"] = "8 8";
            oc_Newobject42["HorizSizing"] = "width";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["canSaveDynamicFields"] = "0";

            #region GuiContainer ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiContainer", "");
            oc_Newobject26["position"] = "0 0";
            oc_Newobject26["extent"] = "202 157";
            oc_Newobject26["HorizSizing"] = "width";
            oc_Newobject26["VertSizing"] = "height";
            oc_Newobject26["Profile"] = "inspectorStyleRolloutDarkProfile";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Levels";
            oc_Newobject1["position"] = "4 1";
            oc_Newobject1["Extent"] = "192 16";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject26["#Newobject1"] = oc_Newobject1;

            #region GuiCheckBoxCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject2["useInactiveState"] = "0";
            oc_Newobject2["text"] = "Levels";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "ToggleButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["position"] = "5 22";
            oc_Newobject2["Extent"] = "49 13";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Variable"] = "ShapeEdShapeView.fixedDetail";
            oc_Newobject2["Command"] = "ShapeEdAdvancedWindow-->detailSlider.setActive($ThisControl.getValue()); ShapeEdAdvancedWindow-->levelsInactive.setVisible( !$ThisControl.getValue() );";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Allow the slider to select the current detail level";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject2"] = oc_Newobject2;

            #region GuiSliderCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject3["range"] = "0 0";
            oc_Newobject3["ticks"] = "1";
            oc_Newobject3["snap"] = "1";
            oc_Newobject3["value"] = "0";
            oc_Newobject3["position"] = "57 22";
            oc_Newobject3["Extent"] = "118 14";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Variable"] = "ShapeEdShapeView.currentDL";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Drag the slider to change the current detail level";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["internalName"] = "detailSlider";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject4["bitmap"] = "tools/gui/images/inactive-overlay";
            oc_Newobject4["position"] = "57 19";
            oc_Newobject4["Extent"] = "122 20";
            oc_Newobject4["tooltip"] = "Levels needs to be selected to enable the detail level slider";
            oc_Newobject4["hovertime"] = "500";
            oc_Newobject4["isContainer"] = new Creator.StringNoQuote("true");
            oc_Newobject4["internalName"] = "levelsInactive";

            #endregion

            oc_Newobject26["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "0";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["position"] = "182 20";
            oc_Newobject5["Extent"] = "15 16";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Variable"] = "ShapeEdShapeView.currentDL";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Index of the current detail level";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "Polys";
            oc_Newobject6["position"] = "37 40";
            oc_Newobject6["extent"] = "26 16";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "0";
            oc_Newobject7["position"] = "67 40";
            oc_Newobject7["Extent"] = "40 16";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Variable"] = "ShapeEdShapeView.detailPolys";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Number of polygons in the current detail level";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["text"] = "Size";
            oc_Newobject8["position"] = "127 40";
            oc_Newobject8["extent"] = "24 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject8"] = oc_Newobject8;

            #region GuiTextEditCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject9["position"] = "160 39";
            oc_Newobject9["extent"] = "35 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Variable"] = "ShapeEdShapeView.detailSize";
            oc_Newobject9["AltCommand"] = "ShapeEdAdvancedWindow.onEditDetailSize();";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Edit this value to change the size of the current detail";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["internalName"] = "detailSize";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["text"] = "Pixels";
            oc_Newobject10["position"] = "35 60";
            oc_Newobject10["extent"] = "28 16";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject10"] = oc_Newobject10;

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["text"] = "0";
            oc_Newobject11["position"] = "67 60";
            oc_Newobject11["Extent"] = "40 16";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Variable"] = "ShapeEdShapeView.pixelSize";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["ToolTip"] = "Current size (in pixels) of the shape";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["text"] = "Distance";
            oc_Newobject12["position"] = "109 60";
            oc_Newobject12["Extent"] = "42 16";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject12"] = oc_Newobject12;

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["text"] = "";
            oc_Newobject13["position"] = "160 60";
            oc_Newobject13["extent"] = "38 16";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Variable"] = "ShapeEdShapeView.orbitDist";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["ToolTip"] = "Current distance from the shape to the camera";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject13"] = oc_Newobject13;

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["text"] = "Materials";
            oc_Newobject14["position"] = "20 80";
            oc_Newobject14["extent"] = "43 16";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject14"] = oc_Newobject14;

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["text"] = "";
            oc_Newobject15["position"] = "67 80";
            oc_Newobject15["extent"] = "40 16";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["Variable"] = "ShapeEdShapeView.numMaterials";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["ToolTip"] = "Number of materials used by all meshes at this detail level";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject15"] = oc_Newobject15;

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["text"] = "Bones";
            oc_Newobject16["position"] = "120 80";
            oc_Newobject16["extent"] = "31 16";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject16"] = oc_Newobject16;

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["text"] = "5";
            oc_Newobject17["position"] = "160 80";
            oc_Newobject17["extent"] = "38 16";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["Variable"] = "ShapeEdShapeView.numBones";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["ToolTip"] = "Number of bones at this detail level (skins only)";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject17"] = oc_Newobject17;

            #region GuiTextCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject18["text"] = "Primitives";
            oc_Newobject18["position"] = "19 100";
            oc_Newobject18["extent"] = "44 16";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["text"] = "";
            oc_Newobject19["position"] = "67 100";
            oc_Newobject19["extent"] = "40 16";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["Variable"] = "ShapeEdShapeView.numDrawCalls";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["ToolTip"] = "Total number of mesh primitives (triangle lists) at this detail level";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject19"] = oc_Newobject19;

            #region GuiTextCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject20["text"] = "Weights";
            oc_Newobject20["position"] = "109 100";
            oc_Newobject20["Extent"] = "42 16";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject20"] = oc_Newobject20;

            #region GuiTextCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject21["text"] = "5";
            oc_Newobject21["position"] = "160 100";
            oc_Newobject21["extent"] = "38 16";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["Variable"] = "ShapeEdShapeView.numWeights";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["ToolTip"] = "Number of vertex weights at this detail level (skins only)";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject21"] = oc_Newobject21;

            #region GuiTextCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject22["text"] = "Col Meshes";
            oc_Newobject22["position"] = "7 120";
            oc_Newobject22["extent"] = "56 16";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";

            #endregion

            oc_Newobject26["#Newobject22"] = oc_Newobject22;

            #region GuiTextCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject23["text"] = "";
            oc_Newobject23["position"] = "67 120";
            oc_Newobject23["extent"] = "40 16";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["Variable"] = "ShapeEdShapeView.colMeshes";

            #endregion

            oc_Newobject26["#Newobject23"] = oc_Newobject23;

            #region GuiTextCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject24["text"] = "Col Polys";
            oc_Newobject24["position"] = "108 120";
            oc_Newobject24["extent"] = "43 16";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";

            #endregion

            oc_Newobject26["#Newobject24"] = oc_Newobject24;

            #region GuiTextCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject25["text"] = "";
            oc_Newobject25["position"] = "160 120";
            oc_Newobject25["extent"] = "38 16";
            oc_Newobject25["horizSizing"] = "right";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["Variable"] = "ShapeEdShapeView.colPolys";

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject42["#Newobject26"] = oc_Newobject26;

            #region GuiContainer ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiContainer", "");
            oc_Newobject41["position"] = "0 138";
            oc_Newobject41["Extent"] = "202 87";
            oc_Newobject41["MinExtent"] = "8 8";
            oc_Newobject41["HorizSizing"] = "width";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject41["isContainer"] = "1";

            #region GuiTextCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject27["text"] = "Imposters";
            oc_Newobject27["position"] = "4 1";
            oc_Newobject27["Extent"] = "192 16";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["Profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject41["#Newobject27"] = oc_Newobject27;

            #region GuiCheckBoxCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject28["useInactiveState"] = "0";
            oc_Newobject28["text"] = "Use Imposters";
            oc_Newobject28["groupNum"] = "-1";
            oc_Newobject28["buttonType"] = "ToggleButton";
            oc_Newobject28["useMouseEvents"] = "0";
            oc_Newobject28["position"] = "113 2";
            oc_Newobject28["Extent"] = "83 13";
            oc_Newobject28["MinExtent"] = "8 2";
            oc_Newobject28["HorizSizing"] = "left";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["Command"] = "ShapeEdDetails.onToggleImposter( $ThisControl.getValue() );";
            oc_Newobject28["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["ToolTip"] = "Controls whether this shape uses an imposter detail level";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["internalName"] = "bbUseImposters";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject28"] = oc_Newobject28;

            #region GuiTextCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject29["text"] = "Detail Level";
            oc_Newobject29["maxLength"] = "1024";
            oc_Newobject29["Margin"] = "0 0 0 0";
            oc_Newobject29["Padding"] = "0 0 0 0";
            oc_Newobject29["AnchorTop"] = "1";
            oc_Newobject29["AnchorBottom"] = "0";
            oc_Newobject29["AnchorLeft"] = "1";
            oc_Newobject29["AnchorRight"] = "0";
            oc_Newobject29["position"] = "6 23";
            oc_Newobject29["Extent"] = "57 16";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject29"] = oc_Newobject29;

            #region GuiTextEditCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject30["position"] = "68 22";
            oc_Newobject30["Extent"] = "36 18";
            oc_Newobject30["MinExtent"] = "8 2";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["AltCommand"] = "ShapeEdDetails.onEditImposter();";
            oc_Newobject30["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["ToolTip"] = "Specifies the detail level used to generate the imposters";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["internalName"] = "bbDetailLevel";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject30"] = oc_Newobject30;

            #region GuiTextCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject31["text"] = "Dimension";
            oc_Newobject31["position"] = "6 43";
            oc_Newobject31["Extent"] = "57 16";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["HorizSizing"] = "right";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject31"] = oc_Newobject31;

            #region GuiTextEditCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject32["position"] = "68 43";
            oc_Newobject32["Extent"] = "36 18";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["AltCommand"] = "ShapeEdDetails.onEditImposter();";
            oc_Newobject32["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject32["ToolTip"] = "Specifies the dimension (width/height) of the imposters in pixels";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["internalName"] = "bbDimension";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject32"] = oc_Newobject32;

            #region GuiTextCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject33["text"] = "X Steps";
            oc_Newobject33["position"] = "6 65";
            oc_Newobject33["Extent"] = "57 16";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject33"] = oc_Newobject33;

            #region GuiTextEditCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject34["position"] = "68 64";
            oc_Newobject34["Extent"] = "36 18";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["AltCommand"] = "ShapeEdDetails.onEditImposter();";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["ToolTip"] = "Number of steps in the horizontal axis";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["internalName"] = "bbEquatorSteps";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject34"] = oc_Newobject34;

            #region GuiCheckBoxCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject35["useInactiveState"] = "0";
            oc_Newobject35["text"] = "Include Poles";
            oc_Newobject35["groupNum"] = "-1";
            oc_Newobject35["buttonType"] = "ToggleButton";
            oc_Newobject35["position"] = "113 24";
            oc_Newobject35["Extent"] = "83 18";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["HorizSizing"] = "right";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["Command"] = "ShapeEdDetails.onEditImposter();";
            oc_Newobject35["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject35["ToolTip"] = "Specifies whether to include the poles (top and bottom) of the shape";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["internalName"] = "bbIncludePoles";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject35"] = oc_Newobject35;

            #region GuiTextCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject36["text"] = "Y Steps";
            oc_Newobject36["maxLength"] = "1024";
            oc_Newobject36["Margin"] = "0 0 0 0";
            oc_Newobject36["Padding"] = "0 0 0 0";
            oc_Newobject36["AnchorTop"] = "1";
            oc_Newobject36["AnchorBottom"] = "0";
            oc_Newobject36["AnchorLeft"] = "1";
            oc_Newobject36["AnchorRight"] = "0";
            oc_Newobject36["position"] = "116 44";
            oc_Newobject36["Extent"] = "41 16";
            oc_Newobject36["MinExtent"] = "8 2";
            oc_Newobject36["HorizSizing"] = "right";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject36["Visible"] = "1";
            oc_Newobject36["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject36["Tooltip"] = "Number of steps in the vertical axis";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject36"] = oc_Newobject36;

            #region GuiTextEditCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject37["position"] = "161 43";
            oc_Newobject37["Extent"] = "36 18";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["HorizSizing"] = "right";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["AltCommand"] = "ShapeEdDetails.onEditImposter();";
            oc_Newobject37["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["internalName"] = "bbPolarSteps";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject37"] = oc_Newobject37;

            #region GuiTextCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject38["text"] = "Y Angle";
            oc_Newobject38["position"] = "116 65";
            oc_Newobject38["Extent"] = "41 16";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["HorizSizing"] = "right";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["tooltip"] = "Polar Angle - Y axis";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject38"] = oc_Newobject38;

            #region GuiTextEditCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject39["position"] = "161 64";
            oc_Newobject39["Extent"] = "36 18";
            oc_Newobject39["MinExtent"] = "8 2";
            oc_Newobject39["HorizSizing"] = "right";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject39["Visible"] = "1";
            oc_Newobject39["AltCommand"] = "ShapeEdDetails.onEditImposter();";
            oc_Newobject39["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["internalName"] = "bbPolarAngle";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject39"] = oc_Newobject39;

            #region GuiBitmapCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject40["bitmap"] = "tools/gui/images/inactive-overlay";
            oc_Newobject40["position"] = "4 18";
            oc_Newobject40["Extent"] = "193 64";
            oc_Newobject40["tooltip"] = "Imposters must be enabled, and an imposter detail level selected to edit these properties";
            oc_Newobject40["hovertime"] = "500";
            oc_Newobject40["isContainer"] = "1";
            oc_Newobject40["internalName"] = "imposterInactive";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject43["#Newobject42"] = oc_Newobject42;

            #endregion

            oc_Newobject116["#Newobject43"] = oc_Newobject43;

            #region GuiTabPageCtrl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject63["text"] = "Mounting";
            oc_Newobject63["maxLength"] = "1024";
            oc_Newobject63["Margin"] = "0 0 0 0";
            oc_Newobject63["Padding"] = "0 0 0 0";
            oc_Newobject63["AnchorTop"] = "1";
            oc_Newobject63["AnchorBottom"] = "0";
            oc_Newobject63["AnchorLeft"] = "1";
            oc_Newobject63["AnchorRight"] = "0";
            oc_Newobject63["Position"] = "0 19";
            oc_Newobject63["extent"] = "202 224";
            oc_Newobject63["MinExtent"] = "0 -500";
            oc_Newobject63["HorizSizing"] = "width";
            oc_Newobject63["VertSizing"] = "height";
            oc_Newobject63["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject63["Visible"] = "0";
            oc_Newobject63["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject63["hovertime"] = "1000";
            oc_Newobject63["canSave"] = "1";
            oc_Newobject63["canSaveDynamicFields"] = "0";
            oc_Newobject63["isContainer"] = "1";

            #region GuiControl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiControl", "");
            oc_Newobject44["docking"] = "client";
            oc_Newobject44["Margin"] = "0 0 0 0";
            oc_Newobject44["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject44["position"] = "0 0";
            oc_Newobject44["extent"] = "202 224";

            #endregion

            oc_Newobject63["#Newobject44"] = oc_Newobject44;

            #region GuiContainer (ShapeEdMountWindow)        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiContainer", "ShapeEdMountWindow", typeof (CodeBehind.ShapeEditor.ShapeEdMountWindow));
            oc_Newobject62["docking"] = "none";
            oc_Newobject62["Margin"] = "0 0 0 0";
            oc_Newobject62["Padding"] = "0 0 0 0";
            oc_Newobject62["AnchorTop"] = "1";
            oc_Newobject62["AnchorBottom"] = "0";
            oc_Newobject62["AnchorLeft"] = "1";
            oc_Newobject62["AnchorRight"] = "0";
            oc_Newobject62["isContainer"] = "1";
            oc_Newobject62["position"] = "0 0";
            oc_Newobject62["extent"] = "202 224";
            oc_Newobject62["MinExtent"] = "8 8";
            oc_Newobject62["HorizSizing"] = "width";
            oc_Newobject62["vertSizing"] = "height";
            oc_Newobject62["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject62["Visible"] = "1";
            oc_Newobject62["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject62["hovertime"] = "1000";
            oc_Newobject62["canSave"] = "1";
            oc_Newobject62["canSaveDynamicFields"] = "0";

            #region GuiCheckBoxCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject45["useInactiveState"] = "0";
            oc_Newobject45["text"] = " Render mounted shapes";
            oc_Newobject45["groupNum"] = "-1";
            oc_Newobject45["buttonType"] = "ToggleButton";
            oc_Newobject45["useMouseEvents"] = "0";
            oc_Newobject45["position"] = "2 2";
            oc_Newobject45["extent"] = "139 13";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["Variable"] = "ShapeEdShapeView.renderMounts";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject45["ToolTip"] = "Controls whether mounted shapes will be rendered in the 3D view";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["internalName"] = "renderMounts";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject62["#Newobject45"] = oc_Newobject45;

            #region GuiScrollCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject48["willFirstRespond"] = "1";
            oc_Newobject48["hScrollBar"] = "alwaysOff";
            oc_Newobject48["vScrollBar"] = "dynamic";
            oc_Newobject48["lockHorizScroll"] = "true";
            oc_Newobject48["lockVertScroll"] = "false";
            oc_Newobject48["constantThumbHeight"] = "0";
            oc_Newobject48["childMargin"] = "0 0";
            oc_Newobject48["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject48["Margin"] = "0 0 0 0";
            oc_Newobject48["Padding"] = "0 0 0 0";
            oc_Newobject48["AnchorTop"] = "0";
            oc_Newobject48["AnchorBottom"] = "0";
            oc_Newobject48["AnchorLeft"] = "1";
            oc_Newobject48["AnchorRight"] = "0";
            oc_Newobject48["position"] = "0 17";
            oc_Newobject48["extent"] = "202 124";
            oc_Newobject48["MinExtent"] = "8 8";
            oc_Newobject48["HorizSizing"] = "width";
            oc_Newobject48["VertSizing"] = "height";
            oc_Newobject48["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject48["Visible"] = "1";
            oc_Newobject48["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["canSaveDynamicFields"] = "0";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["isContainer"] = "1";

            #region GuiContainer ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiContainer", "");
            oc_Newobject46["position"] = "0 0";
            oc_Newobject46["extent"] = "200 121";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "height";
            oc_Newobject46["Profile"] = "inspectorStyleRolloutListProfile";

            #endregion

            oc_Newobject48["#Newobject46"] = oc_Newobject46;

            #region GuiTextListCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiTextListCtrl", "");
            oc_Newobject47["columns"] = "-1 0 110 152";
            oc_Newobject47["fitParentWidth"] = "1";
            oc_Newobject47["clipColumnText"] = "1";
            oc_Newobject47["Position"] = "1 1";
            oc_Newobject47["Extent"] = "200 11";
            oc_Newobject47["MinExtent"] = "8 11";
            oc_Newobject47["HorizSizing"] = "right";
            oc_Newobject47["VertSizing"] = "bottom";
            oc_Newobject47["Profile"] = "GuiShapeEdTextListProfile";
            oc_Newobject47["Visible"] = "1";
            oc_Newobject47["Command"] = "ShapeEdMountWindow.update_onMountSelectionChanged();";
            oc_Newobject47["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["internalName"] = "mountList";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject62["#Newobject48"] = oc_Newobject48;

            #region GuiContainer ()        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiContainer", "");
            oc_Newobject61["position"] = "0 140";
            oc_Newobject61["extent"] = "202 85";
            oc_Newobject61["HorizSizing"] = "width";
            oc_Newobject61["VertSizing"] = "top";
            oc_Newobject61["Profile"] = "inspectorStyleRolloutDarkProfile";

            #region GuiTextCtrl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject49["text"] = "Mount Item";
            oc_Newobject49["position"] = "5 1";
            oc_Newobject49["extent"] = "134 16";
            oc_Newobject49["minExtent"] = "8 2";
            oc_Newobject49["horizSizing"] = "right";
            oc_Newobject49["vertSizing"] = "bottom";
            oc_Newobject49["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject61["#Newobject49"] = oc_Newobject49;

            #region GuiBitmapButtonCtrl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject50["bitmap"] = "tools/gui/images/delete";
            oc_Newobject50["groupNum"] = "-1";
            oc_Newobject50["buttonType"] = "PushButton";
            oc_Newobject50["useMouseEvents"] = "0";
            oc_Newobject50["position"] = "182 1";
            oc_Newobject50["Extent"] = "16 16";
            oc_Newobject50["MinExtent"] = "8 2";
            oc_Newobject50["HorizSizing"] = "left";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject50["Visible"] = "1";
            oc_Newobject50["Command"] = "ShapeEdMountWindow.unmountShape();";
            oc_Newobject50["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject50["ToolTip"] = "Delete the selected mount item";
            oc_Newobject50["canSaveDynamicFields"] = "0";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["isContainer"] = "0";

            #endregion

            oc_Newobject61["#Newobject50"] = oc_Newobject50;

            #region GuiBitmapButtonCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject51["bitmap"] = "tools/gui/images/new";
            oc_Newobject51["groupNum"] = "-1";
            oc_Newobject51["buttonType"] = "PushButton";
            oc_Newobject51["useMouseEvents"] = "0";
            oc_Newobject51["position"] = "168 1";
            oc_Newobject51["Extent"] = "16 16";
            oc_Newobject51["MinExtent"] = "8 2";
            oc_Newobject51["HorizSizing"] = "left";
            oc_Newobject51["VertSizing"] = "bottom";
            oc_Newobject51["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["Command"] = "ShapeEdMountWindow.mountShape(-1);";
            oc_Newobject51["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject51["ToolTip"] = "Mounts a new shape to the current model";
            oc_Newobject51["isContainer"] = "0";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject61["#Newobject51"] = oc_Newobject51;

            #region GuiTextCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject52["text"] = "Shape";
            oc_Newobject52["position"] = "5 21";
            oc_Newobject52["extent"] = "33 16";
            oc_Newobject52["minExtent"] = "8 2";
            oc_Newobject52["horizSizing"] = "right";
            oc_Newobject52["vertSizing"] = "bottom";
            oc_Newobject52["profile"] = "ToolsGuiTextRightProfile";

            #endregion

            oc_Newobject61["#Newobject52"] = oc_Newobject52;

            #region GuiPopUpMenuCtrl (ShapeEdMountShapeMenu)        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiPopUpMenuCtrl", "ShapeEdMountShapeMenu", typeof (CodeBehind.ShapeEditor.ShapeEdMountShapeMenu));
            oc_Newobject53["position"] = "42 20";
            oc_Newobject53["extent"] = "156 18";
            oc_Newobject53["HorizSizing"] = "width";
            oc_Newobject53["vertSizing"] = "bottom";
            oc_Newobject53["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject53["ToolTip"] = "Select the model to mount";

            #endregion

            oc_Newobject61["#Newobject53"] = oc_Newobject53;

            #region GuiTextCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject54["text"] = "Node";
            oc_Newobject54["position"] = "5 42";
            oc_Newobject54["extent"] = "33 16";
            oc_Newobject54["minExtent"] = "8 2";
            oc_Newobject54["horizSizing"] = "right";
            oc_Newobject54["vertSizing"] = "bottom";
            oc_Newobject54["profile"] = "ToolsGuiTextRightProfile";

            #endregion

            oc_Newobject61["#Newobject54"] = oc_Newobject54;

            #region GuiPopUpMenuCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject55["position"] = "42 41";
            oc_Newobject55["extent"] = "62 18";
            oc_Newobject55["minExtent"] = "8 2";
            oc_Newobject55["horizSizing"] = "width";
            oc_Newobject55["vertSizing"] = "bottom";
            oc_Newobject55["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject55["Command"] = "ShapeEdMountWindow.updateSelectedMount();";
            oc_Newobject55["ToolTip"] = "Select the node on which to mount the model";
            oc_Newobject55["internalName"] = "mountNode";

            #endregion

            oc_Newobject61["#Newobject55"] = oc_Newobject55;

            #region GuiTextCtrl ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject56["text"] = "Type";
            oc_Newobject56["position"] = "110 42";
            oc_Newobject56["extent"] = "24 16";
            oc_Newobject56["minExtent"] = "8 2";
            oc_Newobject56["horizSizing"] = "left";
            oc_Newobject56["vertSizing"] = "bottom";
            oc_Newobject56["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject61["#Newobject56"] = oc_Newobject56;

            #region GuiPopUpMenuCtrl ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject57["position"] = "138 41";
            oc_Newobject57["extent"] = "60 18";
            oc_Newobject57["horizSizing"] = "left";
            oc_Newobject57["vertSizing"] = "bottom";
            oc_Newobject57["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject57["Command"] = "ShapeEdMountWindow.updateSelectedMount();";
            oc_Newobject57["ToolTip"] = "Select the type of mounting to use";
            oc_Newobject57["internalName"] = "mountType";

            #endregion

            oc_Newobject61["#Newobject57"] = oc_Newobject57;

            #region GuiPopUpMenuCtrl ()        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject58["position"] = "5 62";
            oc_Newobject58["extent"] = "99 18";
            oc_Newobject58["HorizSizing"] = "width";
            oc_Newobject58["vertSizing"] = "bottom";
            oc_Newobject58["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject58["Command"] = "ShapeEdMountWindow.setMountThreadSequence();";
            oc_Newobject58["ToolTip"] = "Select the sequence to play on the mounted model";
            oc_Newobject58["internalName"] = "mountSeq";

            #endregion

            oc_Newobject61["#Newobject58"] = oc_Newobject58;

            #region GuiSliderCtrl (ShapeEdMountSeqSlider)        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiSliderCtrl", "ShapeEdMountSeqSlider", typeof (CodeBehind.ShapeEditor.ShapeEdMountSeqSlider));
            oc_Newobject59["range"] = "0 1";
            oc_Newobject59["ticks"] = "0";
            oc_Newobject59["snap"] = "0";
            oc_Newobject59["value"] = "0";
            oc_Newobject59["position"] = "109 64";
            oc_Newobject59["extent"] = "68 14";
            oc_Newobject59["MinExtent"] = "8 2";
            oc_Newobject59["HorizSizing"] = "width";
            oc_Newobject59["VertSizing"] = "top";
            oc_Newobject59["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject59["Visible"] = "1";
            oc_Newobject59["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject59["ToolTip"] = "Drag the slider to scrub through the sequence keyframes";
            oc_Newobject59["hovertime"] = "1000";
            oc_Newobject59["isContainer"] = "0";
            oc_Newobject59["canSave"] = "1";
            oc_Newobject59["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject61["#Newobject59"] = oc_Newobject59;

            #region GuiBitmapButtonCtrl ()        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject60["bitmap"] = "tools/shapeEditor/images/playfwd_btn";
            oc_Newobject60["groupNum"] = "0";
            oc_Newobject60["buttonType"] = "ToggleButton";
            oc_Newobject60["useMouseEvents"] = "0";
            oc_Newobject60["position"] = "180 62";
            oc_Newobject60["Extent"] = "18 18";
            oc_Newobject60["MinExtent"] = "8 2";
            oc_Newobject60["HorizSizing"] = "left";
            oc_Newobject60["vertSizing"] = "top";
            oc_Newobject60["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject60["Visible"] = "1";
            oc_Newobject60["Command"] = "ShapeEdMountWindow.toggleMountThreadPlayback();";
            oc_Newobject60["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject60["ToolTip"] = "Play forwards";
            oc_Newobject60["hovertime"] = "1000";
            oc_Newobject60["isContainer"] = "0";
            oc_Newobject60["internalName"] = "mountPlayBtn";
            oc_Newobject60["canSave"] = "1";
            oc_Newobject60["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject61["#Newobject60"] = oc_Newobject60;

            #endregion

            oc_Newobject62["#Newobject61"] = oc_Newobject61;

            #endregion

            oc_Newobject63["#Newobject62"] = oc_Newobject62;

            #endregion

            oc_Newobject116["#Newobject63"] = oc_Newobject63;

            #region GuiTabPageCtrl ()        oc_Newobject85

            ObjectCreator oc_Newobject85 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject85["text"] = "Threads";
            oc_Newobject85["maxLength"] = "1024";
            oc_Newobject85["Margin"] = "0 0 0 0";
            oc_Newobject85["Padding"] = "0 0 0 0";
            oc_Newobject85["AnchorTop"] = "1";
            oc_Newobject85["AnchorBottom"] = "0";
            oc_Newobject85["AnchorLeft"] = "1";
            oc_Newobject85["AnchorRight"] = "0";
            oc_Newobject85["Position"] = "0 19";
            oc_Newobject85["extent"] = "202 224";
            oc_Newobject85["MinExtent"] = "0 -500";
            oc_Newobject85["HorizSizing"] = "width";
            oc_Newobject85["VertSizing"] = "height";
            oc_Newobject85["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject85["Visible"] = "0";
            oc_Newobject85["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject85["hovertime"] = "1000";
            oc_Newobject85["isContainer"] = "1";
            oc_Newobject85["canSave"] = "1";
            oc_Newobject85["canSaveDynamicFields"] = "0";

            #region GuiContainer (ShapeEdThreadWindow)        oc_Newobject84

            ObjectCreator oc_Newobject84 = new ObjectCreator("GuiContainer", "ShapeEdThreadWindow", typeof (CodeBehind.ShapeEditor.ShapeEdThreadWindow));
            oc_Newobject84["docking"] = "client";
            oc_Newobject84["Margin"] = "0 0 0 0";
            oc_Newobject84["Padding"] = "0 0 0 0";
            oc_Newobject84["AnchorTop"] = "1";
            oc_Newobject84["AnchorBottom"] = "0";
            oc_Newobject84["AnchorLeft"] = "1";
            oc_Newobject84["AnchorRight"] = "0";
            oc_Newobject84["position"] = "0 0";
            oc_Newobject84["extent"] = "202 224";
            oc_Newobject84["MinExtent"] = "8 8";
            oc_Newobject84["HorizSizing"] = "width";
            oc_Newobject84["VertSizing"] = "bottom";
            oc_Newobject84["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject84["Visible"] = "1";
            oc_Newobject84["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject84["hovertime"] = "1000";
            oc_Newobject84["isContainer"] = "1";
            oc_Newobject84["canSave"] = "1";
            oc_Newobject84["canSaveDynamicFields"] = "0";

            #region GuiContainer ()        oc_Newobject72

            ObjectCreator oc_Newobject72 = new ObjectCreator("GuiContainer", "");
            oc_Newobject72["position"] = "0 0";
            oc_Newobject72["extent"] = "203 141";
            oc_Newobject72["HorizSizing"] = "width";
            oc_Newobject72["VertSizing"] = "height";
            oc_Newobject72["Profile"] = "inspectorStyleRolloutDarkProfile";

            #region GuiTextCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject64["text"] = "Thread";
            oc_Newobject64["position"] = "4 1";
            oc_Newobject64["extent"] = "41 16";
            oc_Newobject64["minExtent"] = "8 2";
            oc_Newobject64["horizSizing"] = "right";
            oc_Newobject64["vertSizing"] = "bottom";
            oc_Newobject64["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject72["#Newobject64"] = oc_Newobject64;

            #region GuiScrollCtrl ()        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject66["willFirstRespond"] = "1";
            oc_Newobject66["hScrollBar"] = "alwaysOff";
            oc_Newobject66["vScrollBar"] = "dynamic";
            oc_Newobject66["lockHorizScroll"] = "true";
            oc_Newobject66["lockVertScroll"] = "false";
            oc_Newobject66["constantThumbHeight"] = "0";
            oc_Newobject66["childMargin"] = "0 0";
            oc_Newobject66["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject66["Margin"] = "0 0 0 0";
            oc_Newobject66["Padding"] = "0 0 0 0";
            oc_Newobject66["AnchorTop"] = "0";
            oc_Newobject66["AnchorBottom"] = "0";
            oc_Newobject66["AnchorLeft"] = "1";
            oc_Newobject66["AnchorRight"] = "0";
            oc_Newobject66["position"] = "0 17";
            oc_Newobject66["extent"] = "47 124";
            oc_Newobject66["MinExtent"] = "8 8";
            oc_Newobject66["HorizSizing"] = "right";
            oc_Newobject66["VertSizing"] = "height";
            oc_Newobject66["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject66["Visible"] = "1";
            oc_Newobject66["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject66["hovertime"] = "1000";
            oc_Newobject66["isContainer"] = "1";
            oc_Newobject66["canSave"] = "1";
            oc_Newobject66["canSaveDynamicFields"] = "0";

            #region GuiTextListCtrl (ShapeEdThreadList)        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiTextListCtrl", "ShapeEdThreadList", typeof (CodeBehind.ShapeEditor.ShapeEdThreadList));
            oc_Newobject65["fitParentWidth"] = "1";
            oc_Newobject65["clipColumnText"] = "1";
            oc_Newobject65["position"] = "1 1";
            oc_Newobject65["extent"] = "45 11";
            oc_Newobject65["MinExtent"] = "8 11";
            oc_Newobject65["HorizSizing"] = "right";
            oc_Newobject65["VertSizing"] = "bottom";
            oc_Newobject65["Profile"] = "GuiShapeEdTextListProfile";
            oc_Newobject65["Visible"] = "1";
            oc_Newobject65["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject65["hovertime"] = "1000";
            oc_Newobject65["canSave"] = "1";
            oc_Newobject65["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject66["#Newobject65"] = oc_Newobject65;

            #endregion

            oc_Newobject72["#Newobject66"] = oc_Newobject66;

            #region GuiTextCtrl ()        oc_Newobject67

            ObjectCreator oc_Newobject67 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject67["text"] = "Sequence";
            oc_Newobject67["position"] = "52 1";
            oc_Newobject67["extent"] = "53 16";
            oc_Newobject67["minExtent"] = "8 2";
            oc_Newobject67["horizSizing"] = "right";
            oc_Newobject67["vertSizing"] = "bottom";
            oc_Newobject67["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject72["#Newobject67"] = oc_Newobject67;

            #region GuiScrollCtrl ()        oc_Newobject69

            ObjectCreator oc_Newobject69 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject69["willFirstRespond"] = "1";
            oc_Newobject69["hScrollBar"] = "dynamic";
            oc_Newobject69["vScrollBar"] = "dynamic";
            oc_Newobject69["lockHorizScroll"] = "true";
            oc_Newobject69["lockVertScroll"] = "false";
            oc_Newobject69["constantThumbHeight"] = "0";
            oc_Newobject69["childMargin"] = "0 0";
            oc_Newobject69["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject69["Margin"] = "0 0 0 0";
            oc_Newobject69["Padding"] = "0 0 0 0";
            oc_Newobject69["AnchorTop"] = "0";
            oc_Newobject69["AnchorBottom"] = "0";
            oc_Newobject69["AnchorLeft"] = "1";
            oc_Newobject69["AnchorRight"] = "0";
            oc_Newobject69["position"] = "46 17";
            oc_Newobject69["extent"] = "157 124";
            oc_Newobject69["MinExtent"] = "8 8";
            oc_Newobject69["HorizSizing"] = "width";
            oc_Newobject69["VertSizing"] = "height";
            oc_Newobject69["Profile"] = "GuiShapeEdScrollProfile";
            oc_Newobject69["Visible"] = "1";
            oc_Newobject69["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject69["hovertime"] = "1000";
            oc_Newobject69["isContainer"] = "1";
            oc_Newobject69["canSave"] = "1";
            oc_Newobject69["canSaveDynamicFields"] = "0";

            #region GuiTextListCtrl ()        oc_Newobject68

            ObjectCreator oc_Newobject68 = new ObjectCreator("GuiTextListCtrl", "");
            oc_Newobject68["fitParentWidth"] = "1";
            oc_Newobject68["clipColumnText"] = "1";
            oc_Newobject68["Position"] = "1 1";
            oc_Newobject68["extent"] = "155 11";
            oc_Newobject68["MinExtent"] = "8 11";
            oc_Newobject68["HorizSizing"] = "right";
            oc_Newobject68["VertSizing"] = "bottom";
            oc_Newobject68["Profile"] = "GuiShapeEdTextListProfile";
            oc_Newobject68["Visible"] = "1";
            oc_Newobject68["Command"] = "ShapeEdSequenceList.setSelectedById( $ThisControl.getSelectedId() );";
            oc_Newobject68["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject68["hovertime"] = "1000";
            oc_Newobject68["internalName"] = "seqList";
            oc_Newobject68["canSave"] = "1";
            oc_Newobject68["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject69["#Newobject68"] = oc_Newobject68;

            #endregion

            oc_Newobject72["#Newobject69"] = oc_Newobject69;

            #region GuiBitmapButtonCtrl ()        oc_Newobject70

            ObjectCreator oc_Newobject70 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject70["bitmap"] = "tools/gui/images/delete";
            oc_Newobject70["groupNum"] = "-1";
            oc_Newobject70["buttonType"] = "PushButton";
            oc_Newobject70["useMouseEvents"] = "0";
            oc_Newobject70["position"] = "184 1";
            oc_Newobject70["Extent"] = "16 16";
            oc_Newobject70["MinExtent"] = "8 2";
            oc_Newobject70["HorizSizing"] = "left";
            oc_Newobject70["VertSizing"] = "bottom";
            oc_Newobject70["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject70["Visible"] = "1";
            oc_Newobject70["Command"] = "ShapeEdThreadWindow.onRemoveThread();";
            oc_Newobject70["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject70["ToolTip"] = "Delete the selected thread";
            oc_Newobject70["isContainer"] = "0";
            oc_Newobject70["canSave"] = "1";
            oc_Newobject70["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject72["#Newobject70"] = oc_Newobject70;

            #region GuiBitmapButtonCtrl ()        oc_Newobject71

            ObjectCreator oc_Newobject71 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject71["bitmap"] = "tools/gui/images/new";
            oc_Newobject71["groupNum"] = "-1";
            oc_Newobject71["buttonType"] = "PushButton";
            oc_Newobject71["useMouseEvents"] = "0";
            oc_Newobject71["position"] = "171 1";
            oc_Newobject71["Extent"] = "16 16";
            oc_Newobject71["MinExtent"] = "8 2";
            oc_Newobject71["HorizSizing"] = "left";
            oc_Newobject71["VertSizing"] = "bottom";
            oc_Newobject71["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject71["Visible"] = "1";
            oc_Newobject71["Command"] = "ShapeEdThreadWindow.onAddThread();";
            oc_Newobject71["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject71["ToolTip"] = "Add a new thread";
            oc_Newobject71["isContainer"] = "0";
            oc_Newobject71["canSave"] = "1";
            oc_Newobject71["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject72["#Newobject71"] = oc_Newobject71;

            #endregion

            oc_Newobject84["#Newobject72"] = oc_Newobject72;

            #region GuiSliderCtrl (ShapeEdThreadSlider)        oc_Newobject73

            ObjectCreator oc_Newobject73 = new ObjectCreator("GuiSliderCtrl", "ShapeEdThreadSlider", typeof (CodeBehind.ShapeEditor.ShapeEdThreadSlider));
            oc_Newobject73["range"] = "0 0";
            oc_Newobject73["ticks"] = "0";
            oc_Newobject73["snap"] = "0";
            oc_Newobject73["value"] = "0";
            oc_Newobject73["position"] = "29 146";
            oc_Newobject73["extent"] = "133 14";
            oc_Newobject73["MinExtent"] = "8 2";
            oc_Newobject73["HorizSizing"] = "width";
            oc_Newobject73["VertSizing"] = "top";
            oc_Newobject73["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject73["Visible"] = "1";
            oc_Newobject73["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject73["ToolTip"] = "Drag the slider to scrub through the sequence keyframes";
            oc_Newobject73["hovertime"] = "1000";
            oc_Newobject73["isContainer"] = "0";
            oc_Newobject73["canSave"] = "1";
            oc_Newobject73["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject84["#Newobject73"] = oc_Newobject73;

            #region GuiBitmapButtonCtrl ()        oc_Newobject74

            ObjectCreator oc_Newobject74 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject74["bitmap"] = "tools/shapeEditor/images/playbkwd_btn";
            oc_Newobject74["groupNum"] = "0";
            oc_Newobject74["buttonType"] = "RadioButton";
            oc_Newobject74["useMouseEvents"] = "0";
            oc_Newobject74["position"] = "6 144";
            oc_Newobject74["extent"] = "18 18";
            oc_Newobject74["MinExtent"] = "8 2";
            oc_Newobject74["HorizSizing"] = "right";
            oc_Newobject74["vertSizing"] = "top";
            oc_Newobject74["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject74["Visible"] = "1";
            oc_Newobject74["Command"] = "ShapeEdAnimWindow-->playBkwdBtn.performClick();";
            oc_Newobject74["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject74["ToolTip"] = "Play backwards";
            oc_Newobject74["hovertime"] = "1000";
            oc_Newobject74["isContainer"] = "0";
            oc_Newobject74["internalName"] = "playBkwdBtn";
            oc_Newobject74["canSave"] = "1";
            oc_Newobject74["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject84["#Newobject74"] = oc_Newobject74;

            #region GuiBitmapButtonCtrl ()        oc_Newobject75

            ObjectCreator oc_Newobject75 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject75["bitmap"] = "tools/shapeEditor/images/pause_btn";
            oc_Newobject75["groupNum"] = "0";
            oc_Newobject75["buttonType"] = "RadioButton";
            oc_Newobject75["useMouseEvents"] = "0";
            oc_Newobject75["position"] = "166 144";
            oc_Newobject75["Extent"] = "18 18";
            oc_Newobject75["MinExtent"] = "8 2";
            oc_Newobject75["HorizSizing"] = "left";
            oc_Newobject75["vertSizing"] = "top";
            oc_Newobject75["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject75["Visible"] = "1";
            oc_Newobject75["Command"] = "ShapeEdAnimWindow-->pauseBtn.performClick();";
            oc_Newobject75["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject75["ToolTip"] = "Toggle Pause (SPACE)";
            oc_Newobject75["hovertime"] = "1000";
            oc_Newobject75["isContainer"] = "0";
            oc_Newobject75["internalName"] = "pauseBtn";
            oc_Newobject75["canSave"] = "1";
            oc_Newobject75["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject84["#Newobject75"] = oc_Newobject75;

            #region GuiBitmapButtonCtrl ()        oc_Newobject76

            ObjectCreator oc_Newobject76 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject76["bitmap"] = "tools/shapeEditor/images/playfwd_btn";
            oc_Newobject76["groupNum"] = "0";
            oc_Newobject76["buttonType"] = "RadioButton";
            oc_Newobject76["useMouseEvents"] = "0";
            oc_Newobject76["position"] = "184 144";
            oc_Newobject76["Extent"] = "18 18";
            oc_Newobject76["MinExtent"] = "8 2";
            oc_Newobject76["HorizSizing"] = "left";
            oc_Newobject76["vertSizing"] = "top";
            oc_Newobject76["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject76["Visible"] = "1";
            oc_Newobject76["Command"] = "ShapeEdAnimWindow-->playFwdBtn.performClick();";
            oc_Newobject76["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject76["ToolTip"] = "Play forwards";
            oc_Newobject76["hovertime"] = "1000";
            oc_Newobject76["isContainer"] = "0";
            oc_Newobject76["internalName"] = "playFwdBtn";
            oc_Newobject76["canSave"] = "1";
            oc_Newobject76["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject84["#Newobject76"] = oc_Newobject76;

            #region GuiCheckBoxCtrl ()        oc_Newobject77

            ObjectCreator oc_Newobject77 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject77["useInactiveState"] = "0";
            oc_Newobject77["text"] = " Transition lasts";
            oc_Newobject77["groupNum"] = "-1";
            oc_Newobject77["buttonType"] = "ToggleButton";
            oc_Newobject77["useMouseEvents"] = "0";
            oc_Newobject77["position"] = "3 167";
            oc_Newobject77["extent"] = "88 13";
            oc_Newobject77["MinExtent"] = "8 2";
            oc_Newobject77["HorizSizing"] = "right";
            oc_Newobject77["VertSizing"] = "top";
            oc_Newobject77["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject77["Visible"] = "1";
            oc_Newobject77["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject77["ToolTip"] = "Controls whether the thread will smoothly transition when a new sequence is selected";
            oc_Newobject77["hovertime"] = "1000";
            oc_Newobject77["isContainer"] = "0";
            oc_Newobject77["internalName"] = "useTransitions";
            oc_Newobject77["canSave"] = "1";
            oc_Newobject77["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject84["#Newobject77"] = oc_Newobject77;

            #region GuiTextEditCtrl ()        oc_Newobject78

            ObjectCreator oc_Newobject78 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject78["position"] = "98 164";
            oc_Newobject78["extent"] = "49 18";
            oc_Newobject78["MinExtent"] = "8 2";
            oc_Newobject78["HorizSizing"] = "width";
            oc_Newobject78["VertSizing"] = "top";
            oc_Newobject78["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject78["Visible"] = "1";
            oc_Newobject78["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject78["ToolTip"] = "Number of seconds over which to transition to the new sequence";
            oc_Newobject78["hovertime"] = "1000";
            oc_Newobject78["internalName"] = "transitionTime";
            oc_Newobject78["canSave"] = "1";
            oc_Newobject78["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject84["#Newobject78"] = oc_Newobject78;

            #region GuiTextCtrl ()        oc_Newobject79

            ObjectCreator oc_Newobject79 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject79["text"] = "seconds";
            oc_Newobject79["position"] = "153 165";
            oc_Newobject79["extent"] = "44 16";
            oc_Newobject79["minExtent"] = "8 2";
            oc_Newobject79["horizSizing"] = "left";
            oc_Newobject79["vertSizing"] = "top";
            oc_Newobject79["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject84["#Newobject79"] = oc_Newobject79;

            #region GuiTextCtrl ()        oc_Newobject80

            ObjectCreator oc_Newobject80 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject80["text"] = "Transition to";
            oc_Newobject80["position"] = "4 186";
            oc_Newobject80["extent"] = "62 16";
            oc_Newobject80["minExtent"] = "8 2";
            oc_Newobject80["horizSizing"] = "right";
            oc_Newobject80["vertSizing"] = "top";
            oc_Newobject80["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject84["#Newobject80"] = oc_Newobject80;

            #region GuiPopUpMenuCtrl ()        oc_Newobject81

            ObjectCreator oc_Newobject81 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject81["position"] = "68 185";
            oc_Newobject81["extent"] = "133 18";
            oc_Newobject81["HorizSizing"] = "width";
            oc_Newobject81["vertSizing"] = "top";
            oc_Newobject81["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject81["ToolTip"] = "Select the start position of the new sequence";
            oc_Newobject81["internalName"] = "transitionTo";

            #endregion

            oc_Newobject84["#Newobject81"] = oc_Newobject81;

            #region GuiTextCtrl ()        oc_Newobject82

            ObjectCreator oc_Newobject82 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject82["text"] = "Target anim";
            oc_Newobject82["position"] = "4 207";
            oc_Newobject82["extent"] = "58 16";
            oc_Newobject82["minExtent"] = "8 2";
            oc_Newobject82["horizSizing"] = "right";
            oc_Newobject82["vertSizing"] = "top";
            oc_Newobject82["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject84["#Newobject82"] = oc_Newobject82;

            #region GuiPopUpMenuCtrl ()        oc_Newobject83

            ObjectCreator oc_Newobject83 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject83["position"] = "68 206";
            oc_Newobject83["extent"] = "133 18";
            oc_Newobject83["minExtent"] = "8 2";
            oc_Newobject83["horizSizing"] = "width";
            oc_Newobject83["vertSizing"] = "top";
            oc_Newobject83["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject83["ToolTip"] = "Select the initial play state of the new sequence";
            oc_Newobject83["internalName"] = "transitionTarget";

            #endregion

            oc_Newobject84["#Newobject83"] = oc_Newobject83;

            #endregion

            oc_Newobject85["#Newobject84"] = oc_Newobject84;

            #endregion

            oc_Newobject116["#Newobject85"] = oc_Newobject85;

            #region GuiTabPageCtrl ()        oc_Newobject115

            ObjectCreator oc_Newobject115 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject115["text"] = "Collision";
            oc_Newobject115["maxLength"] = "1024";
            oc_Newobject115["Margin"] = "0 0 0 0";
            oc_Newobject115["Padding"] = "0 0 0 0";
            oc_Newobject115["AnchorTop"] = "1";
            oc_Newobject115["AnchorBottom"] = "0";
            oc_Newobject115["AnchorLeft"] = "1";
            oc_Newobject115["AnchorRight"] = "0";
            oc_Newobject115["Position"] = "0 19";
            oc_Newobject115["extent"] = "202 224";
            oc_Newobject115["MinExtent"] = "0 -500";
            oc_Newobject115["HorizSizing"] = "width";
            oc_Newobject115["VertSizing"] = "height";
            oc_Newobject115["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject115["Visible"] = "0";
            oc_Newobject115["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject115["hovertime"] = "1000";
            oc_Newobject115["isContainer"] = "1";
            oc_Newobject115["canSave"] = "1";
            oc_Newobject115["canSaveDynamicFields"] = "0";

            #region GuiContainer (ShapeEdColWindow)        oc_Newobject114

            ObjectCreator oc_Newobject114 = new ObjectCreator("GuiContainer", "ShapeEdColWindow", typeof (CodeBehind.ShapeEditor.ShapeEdColWindow));
            oc_Newobject114["docking"] = "client";
            oc_Newobject114["Margin"] = "0 0 0 0";
            oc_Newobject114["Padding"] = "0 0 0 0";
            oc_Newobject114["AnchorTop"] = "1";
            oc_Newobject114["AnchorBottom"] = "0";
            oc_Newobject114["AnchorLeft"] = "1";
            oc_Newobject114["AnchorRight"] = "0";
            oc_Newobject114["position"] = "0 0";
            oc_Newobject114["extent"] = "202 225";
            oc_Newobject114["MinExtent"] = "8 8";
            oc_Newobject114["HorizSizing"] = "width";
            oc_Newobject114["VertSizing"] = "bottom";
            oc_Newobject114["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject114["Visible"] = "1";
            oc_Newobject114["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject114["hovertime"] = "1000";
            oc_Newobject114["isContainer"] = "1";
            oc_Newobject114["canSave"] = "1";
            oc_Newobject114["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject86

            ObjectCreator oc_Newobject86 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject86["text"] = "Fit Type";
            oc_Newobject86["position"] = "5 5";
            oc_Newobject86["extent"] = "41 16";
            oc_Newobject86["horizSizing"] = "right";
            oc_Newobject86["vertSizing"] = "bottom";

            #endregion

            oc_Newobject114["#Newobject86"] = oc_Newobject86;

            #region GuiPopUpMenuCtrl ()        oc_Newobject87

            ObjectCreator oc_Newobject87 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject87["position"] = "70 4";
            oc_Newobject87["extent"] = "108 18";
            oc_Newobject87["horizSizing"] = "right";
            oc_Newobject87["vertSizing"] = "bottom";
            oc_Newobject87["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject87["Command"] = "ShapeEdColWindow.editCollision();";
            oc_Newobject87["ToolTip"] = "Select the method used to auto-generate the collision geometry";
            oc_Newobject87["internalName"] = "colType";

            #endregion

            oc_Newobject114["#Newobject87"] = oc_Newobject87;

            #region GuiTextCtrl ()        oc_Newobject88

            ObjectCreator oc_Newobject88 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject88["text"] = "Fit Target";
            oc_Newobject88["position"] = "5 25";
            oc_Newobject88["extent"] = "45 16";
            oc_Newobject88["horizSizing"] = "right";
            oc_Newobject88["vertSizing"] = "bottom";

            #endregion

            oc_Newobject114["#Newobject88"] = oc_Newobject88;

            #region GuiPopUpMenuCtrl ()        oc_Newobject89

            ObjectCreator oc_Newobject89 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject89["position"] = "70 24";
            oc_Newobject89["extent"] = "108 18";
            oc_Newobject89["horizSizing"] = "right";
            oc_Newobject89["vertSizing"] = "bottom";
            oc_Newobject89["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject89["Command"] = "ShapeEdColWindow.editCollision();";
            oc_Newobject89["ToolTip"] = "Select the object to fit collision geometry to";
            oc_Newobject89["internalName"] = "colTarget";

            #endregion

            oc_Newobject114["#Newobject89"] = oc_Newobject89;

            #region GuiTextCtrl ()        oc_Newobject90

            ObjectCreator oc_Newobject90 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject90["text"] = "Max Depth";
            oc_Newobject90["position"] = "5 47";
            oc_Newobject90["extent"] = "53 16";
            oc_Newobject90["horizSizing"] = "right";
            oc_Newobject90["vertSizing"] = "bottom";
            oc_Newobject90["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject90"] = oc_Newobject90;

            #region GuiSliderCtrl ()        oc_Newobject91

            ObjectCreator oc_Newobject91 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject91["range"] = "0 8";
            oc_Newobject91["ticks"] = "4";
            oc_Newobject91["snap"] = "0";
            oc_Newobject91["value"] = "4";
            oc_Newobject91["position"] = "70 48";
            oc_Newobject91["extent"] = "104 14";
            oc_Newobject91["MinExtent"] = "8 2";
            oc_Newobject91["HorizSizing"] = "width";
            oc_Newobject91["VertSizing"] = "bottom";
            oc_Newobject91["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject91["Visible"] = "1";
            oc_Newobject91["AltCommand"] = "ShapeEdColWindow-->hullDepthText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject91["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject91["ToolTip"] = "Maximum hull split depth";
            oc_Newobject91["hovertime"] = "1000";
            oc_Newobject91["isContainer"] = "0";
            oc_Newobject91["internalName"] = "hullDepth";

            #endregion

            oc_Newobject114["#Newobject91"] = oc_Newobject91;

            #region GuiTextCtrl ()        oc_Newobject92

            ObjectCreator oc_Newobject92 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject92["text"] = "4";
            oc_Newobject92["position"] = "181 47";
            oc_Newobject92["extent"] = "18 16";
            oc_Newobject92["horizSizing"] = "right";
            oc_Newobject92["vertSizing"] = "bottom";
            oc_Newobject92["profile"] = "ToolsGuiTextProfile";
            oc_Newobject92["internalName"] = "hullDepthText";

            #endregion

            oc_Newobject114["#Newobject92"] = oc_Newobject92;

            #region GuiTextCtrl ()        oc_Newobject93

            ObjectCreator oc_Newobject93 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject93["text"] = "Merge %";
            oc_Newobject93["position"] = "5 68";
            oc_Newobject93["extent"] = "53 16";
            oc_Newobject93["horizSizing"] = "right";
            oc_Newobject93["vertSizing"] = "bottom";
            oc_Newobject93["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject93"] = oc_Newobject93;

            #region GuiSliderCtrl ()        oc_Newobject94

            ObjectCreator oc_Newobject94 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject94["range"] = "0 60";
            oc_Newobject94["ticks"] = "4";
            oc_Newobject94["snap"] = "0";
            oc_Newobject94["value"] = "30";
            oc_Newobject94["position"] = "70 69";
            oc_Newobject94["extent"] = "104 14";
            oc_Newobject94["MinExtent"] = "8 2";
            oc_Newobject94["HorizSizing"] = "width";
            oc_Newobject94["VertSizing"] = "bottom";
            oc_Newobject94["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject94["Visible"] = "1";
            oc_Newobject94["AltCommand"] = "ShapeEdColWindow-->hullMergeText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject94["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject94["ToolTip"] = "Hull volume merge threshold";
            oc_Newobject94["hovertime"] = "1000";
            oc_Newobject94["isContainer"] = "0";
            oc_Newobject94["internalName"] = "hullMergeThreshold";

            #endregion

            oc_Newobject114["#Newobject94"] = oc_Newobject94;

            #region GuiTextCtrl ()        oc_Newobject95

            ObjectCreator oc_Newobject95 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject95["text"] = "30";
            oc_Newobject95["position"] = "179 68";
            oc_Newobject95["extent"] = "18 16";
            oc_Newobject95["horizSizing"] = "right";
            oc_Newobject95["vertSizing"] = "bottom";
            oc_Newobject95["profile"] = "ToolsGuiTextProfile";
            oc_Newobject95["internalName"] = "hullMergeText";

            #endregion

            oc_Newobject114["#Newobject95"] = oc_Newobject95;

            #region GuiTextCtrl ()        oc_Newobject96

            ObjectCreator oc_Newobject96 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject96["text"] = "Concavity %";
            oc_Newobject96["position"] = "5 89";
            oc_Newobject96["extent"] = "59 16";
            oc_Newobject96["horizSizing"] = "right";
            oc_Newobject96["vertSizing"] = "bottom";
            oc_Newobject96["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject96"] = oc_Newobject96;

            #region GuiSliderCtrl ()        oc_Newobject97

            ObjectCreator oc_Newobject97 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject97["range"] = "0 60";
            oc_Newobject97["ticks"] = "4";
            oc_Newobject97["snap"] = "0";
            oc_Newobject97["value"] = "30";
            oc_Newobject97["position"] = "70 90";
            oc_Newobject97["extent"] = "104 14";
            oc_Newobject97["MinExtent"] = "8 2";
            oc_Newobject97["HorizSizing"] = "width";
            oc_Newobject97["VertSizing"] = "bottom";
            oc_Newobject97["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject97["Visible"] = "1";
            oc_Newobject97["AltCommand"] = "ShapeEdColWindow-->hullConcaveText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject97["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject97["ToolTip"] = "Hull concavity threshold";
            oc_Newobject97["hovertime"] = "1000";
            oc_Newobject97["isContainer"] = "0";
            oc_Newobject97["internalName"] = "hullConcaveThreshold";

            #endregion

            oc_Newobject114["#Newobject97"] = oc_Newobject97;

            #region GuiTextCtrl ()        oc_Newobject98

            ObjectCreator oc_Newobject98 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject98["text"] = "30";
            oc_Newobject98["position"] = "179 89";
            oc_Newobject98["extent"] = "18 16";
            oc_Newobject98["horizSizing"] = "right";
            oc_Newobject98["vertSizing"] = "bottom";
            oc_Newobject98["profile"] = "ToolsGuiTextProfile";
            oc_Newobject98["internalName"] = "hullConcaveText";

            #endregion

            oc_Newobject114["#Newobject98"] = oc_Newobject98;

            #region GuiTextCtrl ()        oc_Newobject99

            ObjectCreator oc_Newobject99 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject99["text"] = "Max Verts";
            oc_Newobject99["position"] = "5 110";
            oc_Newobject99["extent"] = "53 16";
            oc_Newobject99["horizSizing"] = "right";
            oc_Newobject99["vertSizing"] = "bottom";
            oc_Newobject99["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject99"] = oc_Newobject99;

            #region GuiSliderCtrl ()        oc_Newobject100

            ObjectCreator oc_Newobject100 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject100["range"] = "8 64";
            oc_Newobject100["ticks"] = "4";
            oc_Newobject100["snap"] = "0";
            oc_Newobject100["value"] = "32";
            oc_Newobject100["position"] = "70 111";
            oc_Newobject100["extent"] = "104 14";
            oc_Newobject100["MinExtent"] = "8 2";
            oc_Newobject100["HorizSizing"] = "width";
            oc_Newobject100["VertSizing"] = "bottom";
            oc_Newobject100["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject100["Visible"] = "1";
            oc_Newobject100["AltCommand"] = "ShapeEdColWindow-->hullMaxVertsText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject100["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject100["ToolTip"] = "Maximum number of verts in a convex hull";
            oc_Newobject100["hovertime"] = "1000";
            oc_Newobject100["isContainer"] = "0";
            oc_Newobject100["internalName"] = "hullMaxVerts";

            #endregion

            oc_Newobject114["#Newobject100"] = oc_Newobject100;

            #region GuiTextCtrl ()        oc_Newobject101

            ObjectCreator oc_Newobject101 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject101["text"] = "32";
            oc_Newobject101["position"] = "179 110";
            oc_Newobject101["extent"] = "18 16";
            oc_Newobject101["horizSizing"] = "right";
            oc_Newobject101["vertSizing"] = "bottom";
            oc_Newobject101["profile"] = "ToolsGuiTextProfile";
            oc_Newobject101["internalName"] = "hullMaxVertsText";

            #endregion

            oc_Newobject114["#Newobject101"] = oc_Newobject101;

            #region GuiTextCtrl ()        oc_Newobject102

            ObjectCreator oc_Newobject102 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject102["text"] = "Box %";
            oc_Newobject102["position"] = "5 131";
            oc_Newobject102["extent"] = "53 16";
            oc_Newobject102["horizSizing"] = "right";
            oc_Newobject102["vertSizing"] = "bottom";
            oc_Newobject102["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject102"] = oc_Newobject102;

            #region GuiSliderCtrl ()        oc_Newobject103

            ObjectCreator oc_Newobject103 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject103["range"] = "0 100";
            oc_Newobject103["ticks"] = "4";
            oc_Newobject103["snap"] = "0";
            oc_Newobject103["value"] = "30";
            oc_Newobject103["position"] = "70 132";
            oc_Newobject103["extent"] = "104 14";
            oc_Newobject103["MinExtent"] = "8 2";
            oc_Newobject103["HorizSizing"] = "width";
            oc_Newobject103["VertSizing"] = "bottom";
            oc_Newobject103["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject103["Visible"] = "1";
            oc_Newobject103["AltCommand"] = "ShapeEdColWindow-->hullMaxBoxErrorText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject103["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject103["ToolTip"] = "Maximum box volume error %";
            oc_Newobject103["hovertime"] = "1000";
            oc_Newobject103["isContainer"] = "0";
            oc_Newobject103["internalName"] = "hullMaxBoxError";

            #endregion

            oc_Newobject114["#Newobject103"] = oc_Newobject103;

            #region GuiTextCtrl ()        oc_Newobject104

            ObjectCreator oc_Newobject104 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject104["text"] = "30";
            oc_Newobject104["position"] = "179 131";
            oc_Newobject104["extent"] = "18 16";
            oc_Newobject104["horizSizing"] = "right";
            oc_Newobject104["vertSizing"] = "bottom";
            oc_Newobject104["profile"] = "ToolsGuiTextProfile";
            oc_Newobject104["internalName"] = "hullMaxBoxErrorText";

            #endregion

            oc_Newobject114["#Newobject104"] = oc_Newobject104;

            #region GuiTextCtrl ()        oc_Newobject105

            ObjectCreator oc_Newobject105 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject105["text"] = "Sphere %";
            oc_Newobject105["position"] = "5 152";
            oc_Newobject105["extent"] = "53 16";
            oc_Newobject105["horizSizing"] = "right";
            oc_Newobject105["vertSizing"] = "bottom";
            oc_Newobject105["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject105"] = oc_Newobject105;

            #region GuiSliderCtrl ()        oc_Newobject106

            ObjectCreator oc_Newobject106 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject106["range"] = "0 100";
            oc_Newobject106["ticks"] = "4";
            oc_Newobject106["snap"] = "0";
            oc_Newobject106["value"] = "30";
            oc_Newobject106["position"] = "70 153";
            oc_Newobject106["extent"] = "104 14";
            oc_Newobject106["MinExtent"] = "8 2";
            oc_Newobject106["HorizSizing"] = "width";
            oc_Newobject106["VertSizing"] = "bottom";
            oc_Newobject106["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject106["Visible"] = "1";
            oc_Newobject106["AltCommand"] = "ShapeEdColWindow-->hullMaxSphereErrorText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject106["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject106["ToolTip"] = "Maximum sphere volume error %";
            oc_Newobject106["hovertime"] = "1000";
            oc_Newobject106["isContainer"] = "0";
            oc_Newobject106["internalName"] = "hullMaxSphereError";

            #endregion

            oc_Newobject114["#Newobject106"] = oc_Newobject106;

            #region GuiTextCtrl ()        oc_Newobject107

            ObjectCreator oc_Newobject107 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject107["text"] = "30";
            oc_Newobject107["position"] = "179 152";
            oc_Newobject107["extent"] = "18 16";
            oc_Newobject107["horizSizing"] = "right";
            oc_Newobject107["vertSizing"] = "bottom";
            oc_Newobject107["profile"] = "ToolsGuiTextProfile";
            oc_Newobject107["internalName"] = "hullMaxSphereErrorText";

            #endregion

            oc_Newobject114["#Newobject107"] = oc_Newobject107;

            #region GuiTextCtrl ()        oc_Newobject108

            ObjectCreator oc_Newobject108 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject108["text"] = "Capsule %";
            oc_Newobject108["position"] = "5 173";
            oc_Newobject108["extent"] = "53 16";
            oc_Newobject108["horizSizing"] = "right";
            oc_Newobject108["vertSizing"] = "bottom";
            oc_Newobject108["profile"] = "ToolsGuiTextProfile";

            #endregion

            oc_Newobject114["#Newobject108"] = oc_Newobject108;

            #region GuiSliderCtrl ()        oc_Newobject109

            ObjectCreator oc_Newobject109 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject109["range"] = "0 100";
            oc_Newobject109["ticks"] = "4";
            oc_Newobject109["snap"] = "0";
            oc_Newobject109["value"] = "30";
            oc_Newobject109["position"] = "70 174";
            oc_Newobject109["extent"] = "104 14";
            oc_Newobject109["MinExtent"] = "8 2";
            oc_Newobject109["HorizSizing"] = "width";
            oc_Newobject109["VertSizing"] = "bottom";
            oc_Newobject109["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject109["Visible"] = "1";
            oc_Newobject109["AltCommand"] = "ShapeEdColWindow-->hullMaxCapsuleErrorText.setText( mFloor($ThisControl.getValue()) );";
            oc_Newobject109["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject109["ToolTip"] = "Maximum capsule volume error %";
            oc_Newobject109["hovertime"] = "1000";
            oc_Newobject109["isContainer"] = "0";
            oc_Newobject109["internalName"] = "hullMaxCapsuleError";

            #endregion

            oc_Newobject114["#Newobject109"] = oc_Newobject109;

            #region GuiTextCtrl ()        oc_Newobject110

            ObjectCreator oc_Newobject110 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject110["text"] = "30";
            oc_Newobject110["position"] = "179 173";
            oc_Newobject110["extent"] = "18 16";
            oc_Newobject110["horizSizing"] = "right";
            oc_Newobject110["vertSizing"] = "bottom";
            oc_Newobject110["profile"] = "ToolsGuiTextProfile";
            oc_Newobject110["internalName"] = "hullMaxCapsuleErrorText";

            #endregion

            oc_Newobject114["#Newobject110"] = oc_Newobject110;

            #region GuiButtonCtrl ()        oc_Newobject111

            ObjectCreator oc_Newobject111 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject111["text"] = "Update Hulls";
            oc_Newobject111["groupNum"] = "-1";
            oc_Newobject111["buttonType"] = "PushButton";
            oc_Newobject111["useMouseEvents"] = "0";
            oc_Newobject111["position"] = "7 200";
            oc_Newobject111["extent"] = "88 18";
            oc_Newobject111["MinExtent"] = "8 2";
            oc_Newobject111["HorizSizing"] = "right";
            oc_Newobject111["vertSizing"] = "bottom";
            oc_Newobject111["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject111["Visible"] = "1";
            oc_Newobject111["Command"] = "ShapeEdColWindow.editCollision();";
            oc_Newobject111["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject111["ToolTip"] = "Update the convex hull(s)";
            oc_Newobject111["hovertime"] = "1000";
            oc_Newobject111["isContainer"] = "0";
            oc_Newobject111["canSave"] = "1";
            oc_Newobject111["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject114["#Newobject111"] = oc_Newobject111;

            #region GuiButtonCtrl ()        oc_Newobject112

            ObjectCreator oc_Newobject112 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject112["text"] = "Revert Changes";
            oc_Newobject112["groupNum"] = "-1";
            oc_Newobject112["buttonType"] = "PushButton";
            oc_Newobject112["useMouseEvents"] = "0";
            oc_Newobject112["position"] = "105 200";
            oc_Newobject112["extent"] = "88 18";
            oc_Newobject112["MinExtent"] = "8 2";
            oc_Newobject112["HorizSizing"] = "right";
            oc_Newobject112["vertSizing"] = "bottom";
            oc_Newobject112["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject112["Visible"] = "1";
            oc_Newobject112["Command"] = "ShapeEdColWindow.update_onCollisionChanged();";
            oc_Newobject112["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject112["ToolTip"] = "Revert changes to settings";
            oc_Newobject112["hovertime"] = "1000";
            oc_Newobject112["isContainer"] = "0";
            oc_Newobject112["canSave"] = "1";
            oc_Newobject112["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject114["#Newobject112"] = oc_Newobject112;

            #region GuiBitmapCtrl ()        oc_Newobject113

            ObjectCreator oc_Newobject113 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject113["bitmap"] = "tools/gui/images/inactive-overlay";
            oc_Newobject113["position"] = "0 47";
            oc_Newobject113["extent"] = "199 175";
            oc_Newobject113["horizSizing"] = "right";
            oc_Newobject113["vertSizing"] = "bottom";
            oc_Newobject113["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject113["visible"] = "0";
            oc_Newobject113["canSave"] = "1";
            oc_Newobject113["canSaveDynamicFields"] = "0";
            oc_Newobject113["internalName"] = "hullInactive";

            #endregion

            oc_Newobject114["#Newobject113"] = oc_Newobject113;

            #endregion

            oc_Newobject115["#Newobject114"] = oc_Newobject114;

            #endregion

            oc_Newobject116["#Newobject115"] = oc_Newobject115;

            #endregion

            oc_Newobject117["#Newobject116"] = oc_Newobject116;

            #endregion

            oc_Newobject117.Create();

            #region GuiControl (ShapeEdWaitGui,EditorGuiGroup)        oc_Newobject120

            ObjectCreator oc_Newobject120 = new ObjectCreator("GuiControl", "ShapeEdWaitGui,EditorGuiGroup", typeof (ShapeEdWaitGui));
            oc_Newobject120["isContainer"] = "1";
            oc_Newobject120["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject120["HorizSizing"] = "right";
            oc_Newobject120["VertSizing"] = "bottom";
            oc_Newobject120["position"] = "0 0";
            oc_Newobject120["Extent"] = "800 600";
            oc_Newobject120["MinExtent"] = "8 2";
            oc_Newobject120["canSave"] = "1";
            oc_Newobject120["Visible"] = "1";
            oc_Newobject120["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject120["hovertime"] = "1000";
            oc_Newobject120["canSaveDynamicFields"] = "1";

            #region GuiControl ()        oc_Newobject119

            ObjectCreator oc_Newobject119 = new ObjectCreator("GuiControl", "");
            oc_Newobject119["isContainer"] = "1";
            oc_Newobject119["Profile"] = "editorMenu_wBorderProfile";
            oc_Newobject119["HorizSizing"] = "center";
            oc_Newobject119["VertSizing"] = "center";
            oc_Newobject119["position"] = "277 271";
            oc_Newobject119["Extent"] = "245 57";
            oc_Newobject119["MinExtent"] = "8 2";
            oc_Newobject119["canSave"] = "1";
            oc_Newobject119["Visible"] = "1";
            oc_Newobject119["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject119["hovertime"] = "1000";
            oc_Newobject119["internalName"] = "Dialog";
            oc_Newobject119["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject118

            ObjectCreator oc_Newobject118 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject118["text"] = "";
            oc_Newobject118["maxLength"] = "1024";
            oc_Newobject118["Margin"] = "0 0 0 0";
            oc_Newobject118["Padding"] = "0 0 0 0";
            oc_Newobject118["AnchorTop"] = "1";
            oc_Newobject118["AnchorBottom"] = "0";
            oc_Newobject118["AnchorLeft"] = "1";
            oc_Newobject118["AnchorRight"] = "0";
            oc_Newobject118["isContainer"] = "0";
            oc_Newobject118["Profile"] = "ToolsGuiTextBoldCenterProfile";
            oc_Newobject118["HorizSizing"] = "width";
            oc_Newobject118["VertSizing"] = "center";
            oc_Newobject118["position"] = "5 19";
            oc_Newobject118["Extent"] = "236 18";
            oc_Newobject118["MinExtent"] = "8 2";
            oc_Newobject118["canSave"] = "1";
            oc_Newobject118["Visible"] = "1";
            oc_Newobject118["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject118["hovertime"] = "1000";
            oc_Newobject118["canSaveDynamicFields"] = "0";
            oc_Newobject118["internalName"] = "message";

            #endregion

            oc_Newobject119["#Newobject118"] = oc_Newobject118;

            #endregion

            oc_Newobject120["#Newobject119"] = oc_Newobject119;

            #endregion

            oc_Newobject120.Create();
        }

        [ConsoleInteraction]
        public void update_onShapeSelectionChanged()
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            ShapeEdShapeView["currentDL"] = "0";
            ShapeEdShapeView.onDetailChanged();
        }

        [ConsoleInteraction]
        public void onEditDetailSize()
        {
            CodeBehind.ShapeEditor.ShapeEdShapeView ShapeEdShapeView = "ShapeEdShapeView";
            CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";

            GuiTextEditCtrl ShapeEdShapeViewdetailSize = this.FOT("detailSize");

            // Change the size of the current detail level
            int oldSize = ShapeEditor.shape.getDetailLevelSize(ShapeEdShapeView["currentDL"].AsInt());
            string detailSize = ShapeEdShapeViewdetailSize.getText();
            ShapeEditor.doEditDetailSize(oldSize, detailSize);
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
            ShapeEdPropWindow ShapeEdPropWindow = "ShapeEdPropWindow";
            ShapeEdSelectWindow ShapeEdSelectWindow = "ShapeEdSelectWindow";

            EditorGui.DeactivateAll();
            ShapeEditorPlugin.onActivated();
            ShapeEdPropWindow.attachTo(ShapeEdSelectWindow);
            //ShapeEdShapeTreeView.open(MissionGroup);
            //ShapeEdShapeTreeView.buildVisibleTree(true);
        }

        [TypeConverter(typeof (TypeConverterGeneric<ShapeEdWaitGui>))]
        public class ShapeEdWaitGui : GuiControl
        {
            [ConsoleInteraction]
            public void show(string text)
            {
                GuiTextCtrl message = this.FOT("message");
                GuiCanvas Canvas = "Canvas";

                message.setText(text);
                Canvas.pushDialog(this);
                Canvas.repaint(0);
            }

            [ConsoleInteraction]
            public void hide()
            {
                GuiCanvas Canvas = "Canvas";
                Canvas.popDialog(this);
            }

            [ConsoleInteraction]
            public override void onWake()
            {
                GuiControl Dialog = this.FOT("Dialog");

                string res = this.getExtent().AsString();
                int resX = Util.getWord(res, 0).AsInt();
                int resY = Util.getWord(res, 1).AsInt();

                string dialogExtent = Dialog.getExtent().AsString();
                int dialogWidth = Util.getWord(dialogExtent, 0).AsInt();
                int dialogHeight = Util.getWord(dialogExtent, 1).AsInt();

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
            public static bool operator ==(ShapeEdWaitGui ts, string simobjectid)
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
            public static bool operator !=(ShapeEdWaitGui ts, string simobjectid)
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
            public static implicit operator string(ShapeEdWaitGui ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdWaitGui(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ShapeEdWaitGui) Omni.self.getSimObject(simobjectid, typeof (ShapeEdWaitGui));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ShapeEdWaitGui ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ShapeEdWaitGui(int simobjectid)
            {
                return (ShapeEdWaitGui) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdWaitGui));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ShapeEdWaitGui ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ShapeEdWaitGui(uint simobjectid)
            {
                return (ShapeEdWaitGui) Omni.self.getSimObject(simobjectid, typeof (ShapeEdWaitGui));
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
        public static bool operator ==(ShapeEdAdvancedWindow ts, string simobjectid)
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
        public static bool operator !=(ShapeEdAdvancedWindow ts, string simobjectid)
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
        public static implicit operator string(ShapeEdAdvancedWindow ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdAdvancedWindow(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ShapeEdAdvancedWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdAdvancedWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEdAdvancedWindow ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEdAdvancedWindow(int simobjectid)
        {
            return (ShapeEdAdvancedWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEdAdvancedWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEdAdvancedWindow ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEdAdvancedWindow(uint simobjectid)
        {
            return (ShapeEdAdvancedWindow) Omni.self.getSimObject(simobjectid, typeof (ShapeEdAdvancedWindow));
        }

        #endregion
    }
}