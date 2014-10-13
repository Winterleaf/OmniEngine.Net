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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class TerrainEditToolbar
    {
        [ConsoleInteraction(true, "TerrainEditToolbar_initialize")]
        public static void initialize()
        {
            #region GuiControl (EWTerrainEditToolbar,EditorGuiGroup)        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiControl", "EWTerrainEditToolbar,EditorGuiGroup");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["internalName"] = "TerrainEditToolbar";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "1";
            oc_Newobject27["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["Position"] = "306 0";
            oc_Newobject27["Extent"] = "800 40";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "6 7";
            oc_Newobject1["extent"] = "70 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["text"] = "Brush Settings";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["helpTag"] = "0";

            #endregion

            oc_Newobject27["#Newobject1"] = oc_Newobject1;

            #region GuiControl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "0 0";
            oc_Newobject26["Extent"] = "760 40";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["hovertime"] = "1000";

            #region GuiControl (EWTerrainEditToolbarBrushType)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "EWTerrainEditToolbarBrushType");
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["Position"] = "83 2";
            oc_Newobject4["Extent"] = "94 27";

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "ellipse";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "29 27";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "ETerrainEditor.toggleBrushType($ThisControl);";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Circle Brush (V)";
            oc_Newobject2["hovertime"] = "750";
            oc_Newobject2["groupNum"] = "0";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/circleBrush";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "box";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "31 0";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "ETerrainEditor.toggleBrushType($ThisControl);";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Box Brush (B)";
            oc_Newobject3["hovertime"] = "750";
            oc_Newobject3["groupNum"] = "0";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/boxBrush";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject26["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["position"] = "152 3";
            oc_Newobject5["Extent"] = "2 26";
            oc_Newobject5["MinExtent"] = "1 1";
            oc_Newobject5["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject26["#Newobject5"] = oc_Newobject5;

            #region GuiControl (TerrainBrushSizeTextEditContainer)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "TerrainBrushSizeTextEditContainer");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "145 5";
            oc_Newobject9["Extent"] = "120 50";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "21 5";
            oc_Newobject6["Extent"] = "47 10";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Size";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "textEdit";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "49 2";
            oc_Newobject7["Extent"] = "42 16";
            oc_Newobject7["MinExtent"] = "8 16";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ETerrainEditor.setBrushSize( $ThisControl.getText() );";
            oc_Newobject7["validate"] = "TerrainEditorPlugin.validateBrushSize();";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "9";
            oc_Newobject7["maxLength"] = "4";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "83 2";
            oc_Newobject8["Extent"] = "18 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "Canvas.pushDialog(TerrainBrushSizeSliderCtrlContainer);";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Changes size of the brush (CTRL + Mouse Wheel)";
            oc_Newobject8["hovertime"] = "750";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject26["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["position"] = "272 3";
            oc_Newobject10["Extent"] = "2 26";
            oc_Newobject10["MinExtent"] = "1 1";
            oc_Newobject10["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject26["#Newobject10"] = oc_Newobject10;

            #region GuiControl (TerrainBrushPressureTextEditContainer)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControl", "TerrainBrushPressureTextEditContainer");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "287 5";
            oc_Newobject14["Extent"] = "120 50";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "0 5";
            oc_Newobject11["Extent"] = "47 10";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["text"] = "Pressure";
            oc_Newobject11["maxLength"] = "1024";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiTextEditCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["internalName"] = "textEdit";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "49 2";
            oc_Newobject12["Extent"] = "42 16";
            oc_Newobject12["MinExtent"] = "8 16";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "ETerrainEditor.setBrushPressure( ($ThisControl.getValue() / 100) );";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["text"] = "100";
            oc_Newobject12["maxLength"] = "3";
            oc_Newobject12["historySize"] = "0";
            oc_Newobject12["password"] = "0";
            oc_Newobject12["tabComplete"] = "0";
            oc_Newobject12["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject14["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "83 2";
            oc_Newobject13["Extent"] = "18 18";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "Canvas.pushDialog(TerrainBrushPressureSliderCtrlContainer);";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["ToolTip"] = "Changes the pressure (CTRL + SHIFT + Mouse Wheel)";
            oc_Newobject13["hovertime"] = "750";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject26["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["position"] = "412 3";
            oc_Newobject15["Extent"] = "2 26";
            oc_Newobject15["MinExtent"] = "1 1";
            oc_Newobject15["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject26["#Newobject15"] = oc_Newobject15;

            #region GuiControl (TerrainBrushSoftnessTextEditContainer)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControl", "TerrainBrushSoftnessTextEditContainer");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "429 5";
            oc_Newobject19["Extent"] = "120 50";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "0 5";
            oc_Newobject16["Extent"] = "47 10";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "Softness";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject19["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "textEdit";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "49 2";
            oc_Newobject17["Extent"] = "42 16";
            oc_Newobject17["MinExtent"] = "8 16";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["Command"] = "ETerrainEditor.setBrushSoftness( ($ThisControl.getValue() / 100) );";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["text"] = "1";
            oc_Newobject17["maxLength"] = "3";
            oc_Newobject17["historySize"] = "0";
            oc_Newobject17["password"] = "0";
            oc_Newobject17["tabComplete"] = "0";
            oc_Newobject17["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject19["#Newobject17"] = oc_Newobject17;

            #region GuiBitmapButtonCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "83 2";
            oc_Newobject18["Extent"] = "18 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["Command"] = "Canvas.pushDialog(TerrainBrushSoftnessSliderCtrlContainer);";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["ToolTip"] = "Changes the softness (SHIFT + Mouse Wheel)";
            oc_Newobject18["hovertime"] = "750";
            oc_Newobject18["groupNum"] = "-1";
            oc_Newobject18["buttonType"] = "PushButton";
            oc_Newobject18["useMouseEvents"] = "0";
            oc_Newobject18["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject26["#Newobject19"] = oc_Newobject19;

            #region GuiBitmapButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["Position"] = "547 3";
            oc_Newobject20["Extent"] = "29 27";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["Command"] = "Canvas.pushDialog( TerrainBrushSoftnessCurveDlg );";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["ToolTip"] = "Changes the softness curve";
            oc_Newobject20["hovertime"] = "750";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "PushButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["bitmap"] = "tools/worldEditor/images/softCurve";

            #endregion

            oc_Newobject26["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["position"] = "589 3";
            oc_Newobject21["Extent"] = "2 26";
            oc_Newobject21["MinExtent"] = "1 1";
            oc_Newobject21["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject26["#Newobject21"] = oc_Newobject21;

            #region GuiControl (TerrainSetHeightTextEditContainer)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiControl", "TerrainSetHeightTextEditContainer");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["isContainer"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = "605 5";
            oc_Newobject25["Extent"] = "120 50";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "0 5";
            oc_Newobject22["Extent"] = "33 10";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["Margin"] = "0 0 0 0";
            oc_Newobject22["Padding"] = "0 0 0 0";
            oc_Newobject22["AnchorTop"] = "1";
            oc_Newobject22["AnchorBottom"] = "0";
            oc_Newobject22["AnchorLeft"] = "1";
            oc_Newobject22["AnchorRight"] = "0";
            oc_Newobject22["text"] = "Height";
            oc_Newobject22["maxLength"] = "1024";

            #endregion

            oc_Newobject25["#Newobject22"] = oc_Newobject22;

            #region GuiTextEditCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["internalName"] = "textEdit";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "34 2";
            oc_Newobject23["Extent"] = "62 16";
            oc_Newobject23["MinExtent"] = "8 16";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["Command"] = "ETerrainEditor.setHeightVal = $ThisControl.getValue();";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["text"] = "1";
            oc_Newobject23["maxLength"] = "7";
            oc_Newobject23["historySize"] = "0";
            oc_Newobject23["password"] = "0";
            oc_Newobject23["tabComplete"] = "0";
            oc_Newobject23["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject25["#Newobject23"] = oc_Newobject23;

            #region GuiBitmapButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["Position"] = "88 2";
            oc_Newobject24["Extent"] = "18 18";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["Command"] = "Canvas.pushDialog(TerrainSetHeightSliderCtrlContainer);";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["ToolTip"] = "Changes the height for the SetHeight tool (ALT + Left Mouse)";
            oc_Newobject24["hovertime"] = "750";
            oc_Newobject24["groupNum"] = "-1";
            oc_Newobject24["buttonType"] = "PushButton";
            oc_Newobject24["useMouseEvents"] = "0";
            oc_Newobject24["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject27["#Newobject26"] = oc_Newobject26;

            #endregion

            oc_Newobject27.Create();

            #region GuiMouseEventCtrl (TerrainBrushSizeSliderCtrlContainer,EditorGuiGroup)        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiMouseEventCtrl", "TerrainBrushSizeSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.TerrainBrushSizeSliderCtrlContainer));
            oc_Newobject29["horizSizing"] = "right";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["position"] = "0 0";
            oc_Newobject29["extent"] = "1024 768";
            oc_Newobject29["minExtent"] = "8 8";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["helpTag"] = "0";
            //oc_Newobject29["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["internalName"] = "slider";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject28["HorizSizing"] = "right";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["position"] = new Creator.StringNoQuote("firstWord(TerrainBrushSizeTextEditContainer.position) + firstWord(EWTerrainEditToolbar.position)+11 SPC          (getWord(TerrainBrushSizeTextEditContainer, 1)) + 25");
            oc_Newobject28["Extent"] = "112 20";
            oc_Newobject28["MinExtent"] = "8 2";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["AltCommand"] = "TerrainBrushSizeTextEditContainer-->textEdit.setValue(mCeil($ThisControl.getValue())); ETerrainEditor.setBrushSize( $ThisControl.value );";
            oc_Newobject28["range"] = "1 40";
            oc_Newobject28["ticks"] = "0";
            oc_Newobject28["value"] = "0";

            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject29.Create();

            #region GuiMouseEventCtrl (TerrainBrushPressureSliderCtrlContainer,EditorGuiGroup)        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiMouseEventCtrl", "TerrainBrushPressureSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.TerrainBrushPressureSliderCtrlContainer));
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["position"] = "0 0";
            oc_Newobject31["extent"] = "1024 768";
            oc_Newobject31["minExtent"] = "8 8";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["helpTag"] = "0";
            //oc_Newobject31["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["internalName"] = "slider";
            oc_Newobject30["isContainer"] = "0";
            oc_Newobject30["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = new Creator.StringNoQuote("firstWord(TerrainBrushPressureTextEditContainer.position) + firstWord(EWTerrainEditToolbar.position) SPC          (getWord(TerrainBrushPressureTextEditContainer, 1)) + 25");
            oc_Newobject30["Extent"] = "112 20";
            oc_Newobject30["MinExtent"] = "8 2";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["AltCommand"] = "TerrainBrushPressureTextEditContainer-->textEdit.setValue( mCeil(100 * $ThisControl.getValue()) @ \\\"%\\\"); ETerrainEditor.setBrushPressure( $ThisControl.value );";
            oc_Newobject30["range"] = "0.01 1";
            oc_Newobject30["ticks"] = "0";
            oc_Newobject30["value"] = "0";

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject31.Create();

            #region GuiMouseEventCtrl (TerrainBrushSoftnessSliderCtrlContainer,EditorGuiGroup)        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiMouseEventCtrl", "TerrainBrushSoftnessSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.TerrainBrushSoftnessSliderCtrlContainer));
            oc_Newobject33["horizSizing"] = "right";
            oc_Newobject33["vertSizing"] = "bottom";
            oc_Newobject33["position"] = "0 0";
            oc_Newobject33["extent"] = "1024 768";
            oc_Newobject33["minExtent"] = "8 8";
            oc_Newobject33["visible"] = "1";
            oc_Newobject33["helpTag"] = "0";
            //oc_Newobject33["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["internalName"] = "slider";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["position"] = new Creator.StringNoQuote("firstWord(TerrainBrushSoftnessTextEditContainer.position) + firstWord(EWTerrainEditToolbar.position) SPC          (getWord(TerrainBrushSoftnessTextEditContainer, 1)) + 25");
            oc_Newobject32["Extent"] = "112 20";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["AltCommand"] = "TerrainBrushSoftnessTextEditContainer-->textEdit.setValue( mCeil(100 * $ThisControl.getValue()) @ \\\"%\\\"); ETerrainEditor.setBrushSoftness( $ThisControl.value );";
            oc_Newobject32["range"] = "0 1";
            oc_Newobject32["ticks"] = "0";
            oc_Newobject32["value"] = "0";

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject33.Create();

            #region GuiMouseEventCtrl (TerrainSetHeightSliderCtrlContainer,EditorGuiGroup)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiMouseEventCtrl", "TerrainSetHeightSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.TerrainSetHeightSliderCtrlContainer));
            oc_Newobject35["horizSizing"] = "right";
            oc_Newobject35["vertSizing"] = "bottom";
            oc_Newobject35["position"] = "0 0";
            oc_Newobject35["extent"] = "1024 768";
            oc_Newobject35["minExtent"] = "8 8";
            oc_Newobject35["visible"] = "1";
            oc_Newobject35["helpTag"] = "0";
            //oc_Newobject35["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["internalName"] = "slider";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["position"] = new Creator.StringNoQuote("firstWord(TerrainSetHeightTextEditContainer.position) + firstWord(EWTerrainEditToolbar.position) SPC          (getWord(TerrainSetHeightTextEditContainer, 1)) + 25");
            oc_Newobject34["Extent"] = "112 20";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["AltCommand"] = "TerrainSetHeightTextEditContainer-->textEdit.setValue( $ThisControl.getValue() ); ETerrainEditor.setHeightVal = $ThisControl.getValue();";
            oc_Newobject34["range"] = "0 2047";
            oc_Newobject34["ticks"] = "0";
            oc_Newobject34["value"] = "100";

            #endregion

            oc_Newobject35["#Newobject34"] = oc_Newobject34;

            #endregion

            oc_Newobject35.Create();
        }
    }
}