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
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui
{
    [TypeConverter(typeof (ForestEditToolbar))]
    public class ForestEditToolbar : GuiControl
    {
        [ConsoleInteraction(true, "ForestEditToolbar_initialize")]
        public static void initialize()
        {
            #region GuiControl (ForestEditToolbar,EditorGuiGroup)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "ForestEditToolbar,EditorGuiGroup", typeof (ForestEditToolbar));
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "306 0";
            oc_Newobject17["Extent"] = "800 40";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["internalName"] = "ForestEditToolbar";
            oc_Newobject17["canSaveDynamicFields"] = "1";
            oc_Newobject17["enabled"] = "1";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Brush Settings";
            oc_Newobject1["maxLength"] = "255";
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
            oc_Newobject1["position"] = "6 7";
            oc_Newobject1["Extent"] = "70 16";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject17["#Newobject1"] = oc_Newobject1;

            #region GuiControl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiControl", "");
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "0 0";
            oc_Newobject16["Extent"] = "760 40";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #region GuiControl (ForestBrushSizeTextEditContainer)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiControl", "ForestBrushSizeTextEditContainer");
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "72 5";
            oc_Newobject5["Extent"] = "120 50";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["text"] = "Size";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "21 5";
            oc_Newobject2["Extent"] = "47 10";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiTextEditCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject3["historySize"] = "0";
            oc_Newobject3["password"] = "0";
            oc_Newobject3["tabComplete"] = "0";
            oc_Newobject3["sinkAllKeyEvents"] = "0";
            oc_Newobject3["passwordMask"] = "*";
            oc_Newobject3["text"] = "9";
            oc_Newobject3["maxLength"] = "4";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "49 2";
            oc_Newobject3["Extent"] = "42 18";
            oc_Newobject3["MinExtent"] = "8 16";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["AltCommand"] = "ForestTools->BrushTool.size = $ThisControl.getValue();";
            oc_Newobject3["validate"] = "ForestEditorGui.validateBrushSize();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["internalName"] = "textEdit";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject4["bitmap"] = "tools/gui/images/dropslider";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "83 2";
            oc_Newobject4["Extent"] = "18 18";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "Canvas.pushDialog(ForestBrushSizeSliderCtrlContainer);";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Changes size of the brush";
            oc_Newobject4["hovertime"] = "750";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject16["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject6["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject6["wrap"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "200 3";
            oc_Newobject6["Extent"] = "2 26";
            oc_Newobject6["MinExtent"] = "1 1";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject6"] = oc_Newobject6;

            #region GuiControl (ForestBrushPressureTextEditContainer)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "ForestBrushPressureTextEditContainer");
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "208 5";
            oc_Newobject10["Extent"] = "120 50";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "Pressure";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 5";
            oc_Newobject7["Extent"] = "47 10";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";
            oc_Newobject8["passwordMask"] = "*";
            oc_Newobject8["text"] = "100";
            oc_Newobject8["maxLength"] = "3";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "49 2";
            oc_Newobject8["Extent"] = "42 18";
            oc_Newobject8["MinExtent"] = "8 16";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "ForestTools->BrushTool.pressure = $ThisControl.getValue() / 100;";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["internalName"] = "textEdit";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["bitmap"] = "tools/gui/images/dropslider";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "83 2";
            oc_Newobject9["Extent"] = "18 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "Canvas.pushDialog(ForestBrushPressureSliderCtrlContainer);";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Changes the pressure";
            oc_Newobject9["hovertime"] = "750";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject16["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject11["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject11["wrap"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "336 3";
            oc_Newobject11["Extent"] = "2 26";
            oc_Newobject11["MinExtent"] = "1 1";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "0";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject11"] = oc_Newobject11;

            #region GuiControl (ForestBrushHardnessTextEditContainer)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiControl", "ForestBrushHardnessTextEditContainer");
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "352 5";
            oc_Newobject15["Extent"] = "120 50";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "0";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["text"] = "Hardness";
            oc_Newobject12["maxLength"] = "1024";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "0 5";
            oc_Newobject12["Extent"] = "47 10";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject15["#Newobject12"] = oc_Newobject12;

            #region GuiTextEditCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject13["historySize"] = "0";
            oc_Newobject13["password"] = "0";
            oc_Newobject13["tabComplete"] = "0";
            oc_Newobject13["sinkAllKeyEvents"] = "0";
            oc_Newobject13["passwordMask"] = "*";
            oc_Newobject13["text"] = "1";
            oc_Newobject13["maxLength"] = "3";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "49 2";
            oc_Newobject13["Extent"] = "42 18";
            oc_Newobject13["MinExtent"] = "8 16";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "ForestTools->BrushTool.hardness = $ThisControl.getValue() / 100);";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["internalName"] = "textEdit";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject15["#Newobject13"] = oc_Newobject13;

            #region GuiBitmapButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject14["bitmap"] = "tools/gui/images/dropslider";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "83 2";
            oc_Newobject14["Extent"] = "18 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["Command"] = "Canvas.pushDialog(ForestBrushHardnessSliderCtrlContainer);";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["ToolTip"] = "Changes the hardness curve.";
            oc_Newobject14["hovertime"] = "750";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject17.Create();

            #region GuiMouseEventCtrl (ForestBrushSizeSliderCtrlContainer,EditorGuiGroup)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiMouseEventCtrl", "ForestBrushSizeSliderCtrlContainer,EditorGuiGroup", typeof (ForestEditorGui.ForestBrushSizeSliderCtrlContainer));
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["position"] = "0 0";
            oc_Newobject19["extent"] = "1024 768";
            oc_Newobject19["minExtent"] = "8 8";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["helpTag"] = "0";
            //oc_Newobject19["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["internalName"] = "slider";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = new Creator.StringNoQuote("firstWord(ForestBrushSizeTextEditContainer.position) + firstWord(ForestEditToolbar.position)+11 SPC          (getWord(ForestBrushSizeTextEditContainer, 1)) + 25");
            oc_Newobject18["Extent"] = "112 20";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["AltCommand"] = "ForestTools->BrushTool.size = $ThisControl.value;";
            oc_Newobject18["range"] = new Creator.StringNoQuote("\"1\" SPC getWord(ETerrainEditor.maxBrushSize, 0)");
            oc_Newobject18["ticks"] = "0";
            oc_Newobject18["value"] = "0";

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject19.Create();

            #region GuiMouseEventCtrl (ForestBrushPressureSliderCtrlContainer,EditorGuiGroup)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiMouseEventCtrl", "ForestBrushPressureSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.EditorDropdownSliderContainer));
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["position"] = "0 0";
            oc_Newobject21["extent"] = "1024 768";
            oc_Newobject21["minExtent"] = "8 8";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["helpTag"] = "0";
            //oc_Newobject21["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["internalName"] = "slider";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = new Creator.StringNoQuote("firstWord(ForestBrushPressureTextEditContainer.position) + firstWord(ForestEditToolbar.position) SPC          (getWord(ForestBrushPressureTextEditContainer, 1)) + 25");
            oc_Newobject20["Extent"] = "112 20";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["AltCommand"] = "ForestTools->BrushTool.pressure = $ThisControl.value;";
            oc_Newobject20["range"] = "0.01 1";
            oc_Newobject20["ticks"] = "0";
            oc_Newobject20["value"] = "0";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject21.Create();

            #region GuiMouseEventCtrl (ForestBrushHardnessSliderCtrlContainer,EditorGuiGroup)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiMouseEventCtrl", "ForestBrushHardnessSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.EditorDropdownSliderContainer));
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["position"] = "0 0";
            oc_Newobject23["extent"] = "1024 768";
            oc_Newobject23["minExtent"] = "8 8";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["helpTag"] = "0";
            //oc_Newobject23["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["internalName"] = "slider";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = new Creator.StringNoQuote("firstWord(ForestBrushHardnessTextEditContainer.position) + firstWord(ForestEditToolbar.position) SPC          (getWord(TForestBrushHardnessTextEditContainer, 1)) + 25");
            oc_Newobject22["Extent"] = "112 20";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["AltCommand"] = "ForestTools->BrushTool.hardness = $ThisControl.value;";
            oc_Newobject22["range"] = "0 1";
            oc_Newobject22["ticks"] = "0";
            oc_Newobject22["value"] = "0";

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject23.Create();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ForestEditToolbar ts, string simobjectid)
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
        public static bool operator !=(ForestEditToolbar ts, string simobjectid)
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
        public static implicit operator string(ForestEditToolbar ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ForestEditToolbar(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ForestEditToolbar) Omni.self.getSimObject(simobjectid, typeof (ForestEditToolbar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ForestEditToolbar ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestEditToolbar(int simobjectid)
        {
            return (ForestEditToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditToolbar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ForestEditToolbar ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestEditToolbar(uint simobjectid)
        {
            return (ForestEditToolbar) Omni.self.getSimObject(simobjectid, typeof (ForestEditToolbar));
        }

        #endregion
    }
}