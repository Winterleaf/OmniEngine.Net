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
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class TerrainPainterToolbar
    {
        [ConsoleInteraction(true, "TerrainPainterToolbar_initialize")]
        public static void initialize()
        {
            #region GuiControl (EWTerrainPainterToolbar,EditorGuiGroup)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiControl", "EWTerrainPainterToolbar,EditorGuiGroup");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["internalName"] = "TerrainPainterToolbar";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["Position"] = "306 0";
            oc_Newobject24["Extent"] = "800 40";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["hovertime"] = "1000";

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

            oc_Newobject24["#Newobject1"] = oc_Newobject1;

            #region GuiControl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiControl", "");
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "0 0";
            oc_Newobject23["Extent"] = "760 40";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["hovertime"] = "1000";

            #region GuiControl (EWTerrainPainterToolbarBrushType)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "EWTerrainPainterToolbarBrushType");
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

            oc_Newobject23["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["position"] = "152 3";
            oc_Newobject5["Extent"] = "2 26";
            oc_Newobject5["MinExtent"] = "1 1";
            oc_Newobject5["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject23["#Newobject5"] = oc_Newobject5;

            #region GuiControl (PaintBrushSizeTextEditContainer)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "PaintBrushSizeTextEditContainer");
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
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject7["position"] = "49 2";
            oc_Newobject7["Extent"] = "42 16";
            oc_Newobject7["MinExtent"] = "8 16";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ETerrainEditor.setBrushSize( $ThisControl.getText() );";
            oc_Newobject7["validate"] = "TerrainPainterPlugin.validateBrushSize();";
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
            oc_Newobject8["Command"] = "Canvas.pushDialog(PaintBrushSizeSliderCtrlContainer);";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Changes the size of the brush (CTRL + Mouse Wheel)";
            oc_Newobject8["hovertime"] = "750";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject23["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["position"] = "270 3";
            oc_Newobject10["Extent"] = "2 26";
            oc_Newobject10["MinExtent"] = "1 1";
            oc_Newobject10["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject23["#Newobject10"] = oc_Newobject10;

            #region GuiControl (PaintBrushSlopeControl)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "PaintBrushSlopeControl");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "262 5";
            oc_Newobject17["Extent"] = "256 50";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "21 5";
            oc_Newobject11["Extent"] = "78 10";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["tooltip"] = "Allows painting on the terrain within a specified slope";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["text"] = "Slope Mask   Min";
            oc_Newobject11["maxLength"] = "1024";

            #endregion

            oc_Newobject17["#Newobject11"] = oc_Newobject11;

            #region GuiTextEditCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject12["internalName"] = "SlopeMinAngle";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "104 2";
            oc_Newobject12["Extent"] = "51 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["validate"] = "TerrainPainterPlugin.validateSlopeMinAngle();";
            oc_Newobject12["Command"] = "ETerrainEditor.setSlopeLimitMinAngle( $ThisControl.getText() );";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["tooltip"] = "Minimum terrain angle that will be paintable";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["text"] = "0.0";
            oc_Newobject12["maxLength"] = "4";
            oc_Newobject12["historySize"] = "0";
            oc_Newobject12["password"] = "0";
            oc_Newobject12["tabComplete"] = "0";
            oc_Newobject12["sinkAllKeyEvents"] = "0";
            oc_Newobject12["passwordMask"] = "*";

            #endregion

            oc_Newobject17["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "137 2";
            oc_Newobject13["Extent"] = "18 18";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["tooltip"] = "Minimum terrain angle that will be paintable";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["bitmap"] = "tools/gui/images/dropslider";
            oc_Newobject13["Command"] = "Canvas.pushDialog(PaintBrushSlopeMinContainer);";

            #endregion

            oc_Newobject17["#Newobject13"] = oc_Newobject13;

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "165 5";
            oc_Newobject14["Extent"] = "27 10";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["text"] = "Max";
            oc_Newobject14["tooltip"] = "Max terrain angle that will be paintable";

            #endregion

            oc_Newobject17["#Newobject14"] = oc_Newobject14;

            #region GuiTextEditCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject15["internalName"] = "SlopeMaxAngle";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "190 2";
            oc_Newobject15["Extent"] = "51 18";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["validate"] = "TerrainPainterPlugin.validateSlopeMaxAngle();";
            oc_Newobject15["Command"] = "ETerrainEditor.setSlopeLimitMaxAngle( $ThisControl.getText() );";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["tooltip"] = "Max terrain angle that will be paintable";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["text"] = "90.0";
            oc_Newobject15["maxLength"] = "4";
            oc_Newobject15["historySize"] = "0";
            oc_Newobject15["password"] = "0";
            oc_Newobject15["tabComplete"] = "0";
            oc_Newobject15["sinkAllKeyEvents"] = "0";
            oc_Newobject15["passwordMask"] = "*";

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiBitmapButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "223 2";
            oc_Newobject16["Extent"] = "18 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["groupNum"] = "-1";
            oc_Newobject16["tooltip"] = "Max terrain angle that will be paintable";
            oc_Newobject16["buttonType"] = "PushButton";
            oc_Newobject16["useMouseEvents"] = "0";
            oc_Newobject16["bitmap"] = "tools/gui/images/dropslider";
            oc_Newobject16["Command"] = "Canvas.pushDialog(PaintBrushSlopeMaxContainer);";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject23["#Newobject17"] = oc_Newobject17;

            #region GuiBitmapCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["position"] = "525 3";
            oc_Newobject18["Extent"] = "2 26";
            oc_Newobject18["MinExtent"] = "1 1";
            oc_Newobject18["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject23["#Newobject18"] = oc_Newobject18;

            #region GuiControl (PaintBrushPressureTextEditContainer,EditorGuiGroup)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "PaintBrushPressureTextEditContainer,EditorGuiGroup");
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "540 5";
            oc_Newobject22["Extent"] = "120 50";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "0 5";
            oc_Newobject19["Extent"] = "47 10";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["Margin"] = "0 0 0 0";
            oc_Newobject19["Padding"] = "0 0 0 0";
            oc_Newobject19["AnchorTop"] = "1";
            oc_Newobject19["AnchorBottom"] = "0";
            oc_Newobject19["AnchorLeft"] = "1";
            oc_Newobject19["AnchorRight"] = "0";
            oc_Newobject19["text"] = "Pressure";
            oc_Newobject19["maxLength"] = "1024";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiTextEditCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["internalName"] = "textEdit";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "49 2";
            oc_Newobject20["Extent"] = "42 16";
            oc_Newobject20["MinExtent"] = "8 16";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["Command"] = "ETerrainEditor.setBrushPressure( ($ThisControl.getValue() / 100) );";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["text"] = "100";
            oc_Newobject20["maxLength"] = "3";
            oc_Newobject20["historySize"] = "0";
            oc_Newobject20["password"] = "0";
            oc_Newobject20["tabComplete"] = "0";
            oc_Newobject20["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["Position"] = "83 2";
            oc_Newobject21["Extent"] = "18 18";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["Command"] = "Canvas.pushDialog(PaintBrushPressureSliderCtrlContainer);";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["ToolTip"] = "Changes the pressure (CTRL + SHIFT + Mouse Wheel)";
            oc_Newobject21["hovertime"] = "750";
            oc_Newobject21["groupNum"] = "-1";
            oc_Newobject21["buttonType"] = "PushButton";
            oc_Newobject21["useMouseEvents"] = "0";
            oc_Newobject21["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject24.Create();

            #region GuiMouseEventCtrl (PaintBrushPressureSliderCtrlContainer,EditorGuiGroup)        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiMouseEventCtrl", "PaintBrushPressureSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.PaintBrushPressureSliderCtrlContainer));
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["position"] = "0 0";
            oc_Newobject26["extent"] = "1024 768";
            oc_Newobject26["minExtent"] = "8 8";
            oc_Newobject26["visible"] = "1";
            oc_Newobject26["helpTag"] = "0";
            //oc_Newobject26["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["internalName"] = "slider";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = new Creator.StringNoQuote("firstWord(PaintBrushPressureTextEditContainer.position) + firstWord(EWTerrainPainterToolbar.position) SPC          (getWord(PaintBrushPressureTextEditContainer, 1)) + 25");
            oc_Newobject25["Extent"] = "112 20";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["AltCommand"] = "PaintBrushPressureTextEditContainer-->textEdit.setValue(mFloatLength( ($ThisControl.getValue()), 2 )); ETerrainEditor.setBrushPressure( $ThisControl.value );";
            oc_Newobject25["range"] = "0 1";
            oc_Newobject25["ticks"] = "0";
            oc_Newobject25["value"] = "0";

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject26.Create();

            #region GuiMouseEventCtrl (PaintBrushSoftnessSliderCtrlContainer,EditorGuiGroup)        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiMouseEventCtrl", "PaintBrushSoftnessSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.PaintBrushSoftnessSliderCtrlContainer));
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["position"] = "0 0";
            oc_Newobject28["extent"] = "1024 768";
            oc_Newobject28["minExtent"] = "8 8";
            oc_Newobject28["visible"] = "1";
            oc_Newobject28["helpTag"] = "0";
            //oc_Newobject28["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["internalName"] = "slider";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = new Creator.StringNoQuote("firstWord(PaintBrushSoftnessTextEditContainer.position) + firstWord(EWTerrainPainterToolbar.position) SPC          (getWord(PaintBrushSoftnessTextEditContainer, 1)) + 25");
            oc_Newobject27["Extent"] = "112 20";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["AltCommand"] = "PaintBrushSoftnessTextEditContainer-->textEdit.setValue(mFloatLength( ($ThisControl.getValue()), 2 )); ETerrainEditor.setBrushSoftness( $ThisControl.value );";
            oc_Newobject27["range"] = "0 1";
            oc_Newobject27["ticks"] = "0";
            oc_Newobject27["value"] = "0";

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject28.Create();

            #region GuiMouseEventCtrl (PaintBrushSizeSliderCtrlContainer,EditorGuiGroup)        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiMouseEventCtrl", "PaintBrushSizeSliderCtrlContainer,EditorGuiGroup", typeof (EditorGui.PaintBrushSizeSliderCtrlContainer));
            oc_Newobject30["horizSizing"] = "right";
            oc_Newobject30["vertSizing"] = "bottom";
            oc_Newobject30["position"] = "0 0";
            oc_Newobject30["extent"] = "1024 768";
            oc_Newobject30["minExtent"] = "8 8";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["helpTag"] = "0";
            //oc_Newobject30["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["internalName"] = "slider";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = new Creator.StringNoQuote("firstWord(PaintBrushSizeTextEditContainer.position) + firstWord(EWTerrainPainterToolbar.position)+11 SPC          (getWord(PaintBrushSizeTextEditContainer, 1)) + 25");
            oc_Newobject29["Extent"] = "112 20";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["AltCommand"] = "PaintBrushSizeTextEditContainer-->textEdit.setValue(mFloatLength( ($ThisControl.getValue()), 2 )); ETerrainEditor.setBrushSize( $ThisControl.value );";
            oc_Newobject29["range"] = "1 40";
            oc_Newobject29["ticks"] = "0";
            oc_Newobject29["value"] = "0";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject30.Create();

            #region GuiMouseEventCtrl (PaintBrushSlopeMinContainer,EditorGuiGroup)        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiMouseEventCtrl", "PaintBrushSlopeMinContainer,EditorGuiGroup", typeof (PaintBrushSlopeMinContainer));
            oc_Newobject32["horizSizing"] = "right";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["position"] = "0 0";
            oc_Newobject32["extent"] = "1024 768";
            oc_Newobject32["minExtent"] = "8 8";
            oc_Newobject32["visible"] = "1";
            oc_Newobject32["helpTag"] = "0";
            //oc_Newobject32["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["internalName"] = "slider";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject31["HorizSizing"] = "right";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = new Creator.StringNoQuote("firstWord(PaintBrushSlopeControl.position) + firstWord(EWTerrainPainterToolbar.position)+firstWord(PaintBrushSlopeControl->SlopeMinAngle.position) - 40 SPC         (getWord(PaintBrushSlopeControl, 1)) + 25");
            oc_Newobject31["Extent"] = "112 20";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["AltCommand"] = "PaintBrushSlopeControl-->SlopeMinAngle.setValue(mFloatLength( ($ThisControl.getValue()), 1 )); ETerrainEditor.setSlopeLimitMinAngle(mFloatLength( ($ThisControl.getValue()), 1 ));TerrainPainterPlugin.validateSlopeMinAngle();";
            oc_Newobject31["range"] = "0 89.9";
            oc_Newobject31["ticks"] = "0";
            oc_Newobject31["value"] = "0";

            #endregion

            oc_Newobject32["#Newobject31"] = oc_Newobject31;

            #endregion

            oc_Newobject32.Create();

            #region GuiMouseEventCtrl (PaintBrushSlopeMaxContainer,EditorGuiGroup)        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiMouseEventCtrl", "PaintBrushSlopeMaxContainer,EditorGuiGroup", typeof (PaintBrushSlopeMaxContainer));
            oc_Newobject34["horizSizing"] = "right";
            oc_Newobject34["vertSizing"] = "bottom";
            oc_Newobject34["position"] = "0 0";
            oc_Newobject34["extent"] = "1024 768";
            oc_Newobject34["minExtent"] = "8 8";
            oc_Newobject34["visible"] = "1";
            oc_Newobject34["helpTag"] = "0";
            //oc_Newobject34["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["internalName"] = "slider";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["position"] = new Creator.StringNoQuote("firstWord(PaintBrushSlopeControl.position) + firstWord(EWTerrainPainterToolbar.position)+firstWord(PaintBrushSlopeControl->SlopeMaxAngle.position) - 40 SPC         (getWord(PaintBrushSlopeControl, 1)) + 25");
            oc_Newobject33["Extent"] = "112 20";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["AltCommand"] = "PaintBrushSlopeControl-->SlopeMaxAngle.setValue(mFloatLength( ($ThisControl.getValue()), 1 )); ETerrainEditor.setSlopeLimitMaxAngle(mFloatLength( ($ThisControl.getValue()), 1 ));TerrainPainterPlugin.validateSlopeMaxAngle();";
            oc_Newobject33["range"] = "0.1 90.0";
            oc_Newobject33["ticks"] = "0";
            oc_Newobject33["value"] = "0";

            #endregion

            oc_Newobject34["#Newobject33"] = oc_Newobject33;

            #endregion

            oc_Newobject34.Create();
        }

        [ConsoleInteraction]
        public static void setTerrainEditorMinSlope(float value)
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            float val = ETerrainEditor.setSlopeLimitMinAngle(value);
            GuiTextEditCtrl SlopeMinAngle = ((GuiControl) "PaintBrushSlopeControl").findObjectByInternalName("SlopeMinAngle", true);

            SlopeMinAngle.setValue(pInvokes.Util.mFloatLength(val, 1));
        }

        [ConsoleInteraction]
        public static void setTerrainEditorMaxSlope(float value)
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            float val = ETerrainEditor.setSlopeLimitMaxAngle(value);
            GuiTextEditCtrl SlopeMaxAngle = ((GuiControl) "PaintBrushSlopeControl").findObjectByInternalName("SlopeMaxAngle", true);

            SlopeMaxAngle.setValue(pInvokes.Util.mFloatLength(val, 1));
        }
    }

    [TypeConverter(typeof (TypeConverterGeneric<PaintBrushSlopeMaxContainer>))]
    public class PaintBrushSlopeMaxContainer : EditorGui.EditorDropdownSliderContainer
    {
        public override void onWake()
        {
            GuiSliderCtrl slider = this.findObjectByInternalName("slider", true);
            GuiTextEditCtrl SlopeMaxAngle = ((GuiControl) "PaintBrushSlopeControl").findObjectByInternalName("SlopeMaxAngle", true);

            slider.setValue(SlopeMaxAngle.getValue());
        }

        [ConsoleInteraction]
        public void init()
        {
            GuiSliderCtrl slider = this.findObjectByInternalName("slider", true);
            slider.setValue("90.0");
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PaintBrushSlopeMaxContainer ts, string simobjectid)
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
        public static bool operator !=(PaintBrushSlopeMaxContainer ts, string simobjectid)
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
        public static implicit operator string(PaintBrushSlopeMaxContainer ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator PaintBrushSlopeMaxContainer(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (PaintBrushSlopeMaxContainer) Omni.self.getSimObject(simobjectid, typeof (PaintBrushSlopeMaxContainer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PaintBrushSlopeMaxContainer ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PaintBrushSlopeMaxContainer(int simobjectid)
        {
            return (PaintBrushSlopeMaxContainer) Omni.self.getSimObject((uint) simobjectid, typeof (PaintBrushSlopeMaxContainer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PaintBrushSlopeMaxContainer ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PaintBrushSlopeMaxContainer(uint simobjectid)
        {
            return (PaintBrushSlopeMaxContainer) Omni.self.getSimObject(simobjectid, typeof (PaintBrushSlopeMaxContainer));
        }

        #endregion
    }

    [TypeConverter(typeof (TypeConverterGeneric<PaintBrushSlopeMinContainer>))]
    public class PaintBrushSlopeMinContainer : EditorGui.EditorDropdownSliderContainer
    {
        public override void onWake()
        {
            GuiSliderCtrl slider = this.findObjectByInternalName("slider", true);
            GuiTextEditCtrl SlopeMinAngle = ((GuiControl) "PaintBrushSlopeControl").findObjectByInternalName("SlopeMinAngle", true);
            slider.setValue(SlopeMinAngle.getValue());
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PaintBrushSlopeMinContainer ts, string simobjectid)
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
        public static bool operator !=(PaintBrushSlopeMinContainer ts, string simobjectid)
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
        public static implicit operator string(PaintBrushSlopeMinContainer ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator PaintBrushSlopeMinContainer(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (PaintBrushSlopeMinContainer) Omni.self.getSimObject(simobjectid, typeof (PaintBrushSlopeMinContainer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(PaintBrushSlopeMinContainer ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PaintBrushSlopeMinContainer(int simobjectid)
        {
            return (PaintBrushSlopeMinContainer) Omni.self.getSimObject((uint) simobjectid, typeof (PaintBrushSlopeMinContainer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(PaintBrushSlopeMinContainer ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PaintBrushSlopeMinContainer(uint simobjectid)
        {
            return (PaintBrushSlopeMinContainer) Omni.self.getSimObject(simobjectid, typeof (PaintBrushSlopeMinContainer));
        }

        #endregion
    }
}