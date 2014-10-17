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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using Creator = WinterLeaf.Engine.Classes.View.Creators.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    [TypeConverter(typeof (TerrainPainterWindow))]
    public class TerrainPainterWindow : GuiWindowCollapseCtrl
    {
        [ConsoleInteraction(true, "TerrainPainterWindow_initialize")]
        public static uint initialize()
        {
            #region GuiControl (TerrainPainterContainer,EditorGuiGroup)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControl", "TerrainPainterContainer,EditorGuiGroup");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "0 0";
            oc_Newobject11["Extent"] = "800 600";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (TerrainPainter)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiWindowCollapseCtrl", "TerrainPainter", typeof (TerrainPainter));
            oc_Newobject3["AllowPopWindow"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "TerrainPainter";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject3["HorizSizing"] = "windowRelative";
            oc_Newobject3["VertSizing"] = "windowRelative";
            oc_Newobject3["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1)+249");
            oc_Newobject3["Extent"] = "210 446";
            oc_Newobject3["MinExtent"] = "210 100";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "0";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Docking"] = "None";
            oc_Newobject3["Margin"] = "4 4 4 4";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "0";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "0";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["resizeWidth"] = "1";
            oc_Newobject3["resizeHeight"] = "1";
            oc_Newobject3["canMove"] = "1";
            oc_Newobject3["canClose"] = "0";
            oc_Newobject3["canMinimize"] = "0";
            oc_Newobject3["canMaximize"] = "0";
            oc_Newobject3["minSize"] = "152 300";
            oc_Newobject3["closeCommand"] = "TerrainPainter.parentGroup.setVisible(false);";
            oc_Newobject3["EdgeSnap"] = "1";
            oc_Newobject3["text"] = "Terrain Painter Material Selector";

            #region GuiTextEditCtrl (TerrainSelectorTextEdit)        oc_Newobject100

            ObjectCreator oc_Newobject100 = new ObjectCreator("GuiTextEditCtrl", "TerrainSelectorTextEdit", typeof (TerrainPainter.TerrainSelectorTextEdit));
            oc_Newobject100["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject100["HorizSizing"] = "width";
            oc_Newobject100["VertSizing"] = "bottom";
            oc_Newobject100["position"] = "4 25";
            oc_Newobject100["Extent"] = "177 18";

            #endregion

            oc_Newobject3["#Newobject100"] = oc_Newobject100;

            #region GuiBitmapButtonCtrl (TerrainSelectorClearButton)        oc_Newobject101

            ObjectCreator oc_Newobject101 = new ObjectCreator("GuiBitmapButtonCtrl", "TerrainSelectorClearButton", typeof (TerrainPainter.TerrainSelectorClearButton));
            oc_Newobject101["canSaveDynamicFields"] = "0";
            oc_Newobject101["isContainer"] = "0";
            oc_Newobject101["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject101["HorizSizing"] = "left";
            oc_Newobject101["VertSizing"] = "bottom";
            oc_Newobject101["position"] = "187 25";
            oc_Newobject101["Extent"] = "17 17";
            oc_Newobject101["MinExtent"] = "8 2";
            oc_Newobject101["canSave"] = "1";
            oc_Newobject101["Visible"] = "1";
            oc_Newobject101["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject101["groupNum"] = "-1";
            oc_Newobject101["buttonType"] = "PushButton";
            oc_Newobject101["useMouseEvents"] = "0";
            oc_Newobject101["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject101["textCtrl"] = new Creator.StringNoQuote("TerrainSelectorTextEdit");

            #endregion

            oc_Newobject3["#Newobject101"] = oc_Newobject101;

            #region GuiScrollCtrl ( EPainterScroll )        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "EPainterScroll");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "4 47";
            oc_Newobject2["Extent"] = "202 395";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Docking"] = "Bottom";
            oc_Newobject2["Margin"] = "3 1 3 3";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "true";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";

            #region GuiStackControl ( EPainterStack )        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiStackControl", "EPainterStack");
            oc_Newobject1["StackingType"] = "Vertical";
            oc_Newobject1["HorizStacking"] = "Left to Right";
            oc_Newobject1["VertStacking"] = "Top to Bottom";
            oc_Newobject1["Padding"] = "-2";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "theMaterialList";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "1 3";
            oc_Newobject1["Extent"] = "200 16";
            oc_Newobject1["MinExtent"] = "16 16";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["isDecoy"] = "0";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiWindowCollapseCtrl (TerrainPainterPreview)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiWindowCollapseCtrl", "TerrainPainterPreview", typeof (TerrainPainterWindow));
            oc_Newobject10["AllowPopWindow"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "TerrainPainterPreview";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject10["HorizSizing"] = "windowRelative";
            oc_Newobject10["VertSizing"] = "windowRelative";
            oc_Newobject10["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject10["Extent"] = "210 251";
            oc_Newobject10["MinExtent"] = "210 251";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["isDecoy"] = "0";
            oc_Newobject10["Visible"] = "0";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Docking"] = "None";
            oc_Newobject10["Margin"] = "4 4 4 4";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "0";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "0";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["resizeWidth"] = "1";
            oc_Newobject10["resizeHeight"] = "1";
            oc_Newobject10["canMove"] = "1";
            oc_Newobject10["canClose"] = "0";
            oc_Newobject10["canMinimize"] = "0";
            oc_Newobject10["canMaximize"] = "0";
            oc_Newobject10["minSize"] = "152 300";
            oc_Newobject10["closeCommand"] = "TerrainPainter.parentGroup.setVisible(false);";
            oc_Newobject10["EdgeSnap"] = "1";
            oc_Newobject10["text"] = "Terrain Painter Material Preview";

            #region GuiContainer ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiContainer", "");
            oc_Newobject6["Docking"] = "Client";
            oc_Newobject6["Margin"] = "3 22 3 3";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "4 24";
            oc_Newobject6["Extent"] = "202 202";

            #region GuiBitmapCtrl (ETerrainMaterialSelected)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "ETerrainMaterialSelected");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "202 202";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["wrap"] = "0";
            oc_Newobject4["bitmap"] = "tools/materialeditor/gui/unknownImage";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl (ETerrainMaterialSelectedBorder)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "ETerrainMaterialSelectedBorder");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "202 202";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/worldEditor/images/terrainpainter/terrain-painter-border-large";
            oc_Newobject5["wrap"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl (ETerrainMaterialSelectedEdit)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "ETerrainMaterialSelectedEdit");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "left";
            oc_Newobject7["VertSizing"] = "top";
            oc_Newobject7["Position"] = "170 229";
            oc_Newobject7["Extent"] = "36 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "0";
            oc_Newobject7["Command"] = "TerrainMaterialDlg.show(ETerrainMaterialSelected.selectedMatIndex, ETerrainMaterialSelected.selectedMat, EPainter_TerrainMaterialUpdateCallback);";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Edit";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl (TerrainTextureText)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "TerrainTextureText");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "top";
            oc_Newobject8["Position"] = "5 230";
            oc_Newobject8["Extent"] = "162 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "None";
            oc_Newobject8["maxLength"] = "1024";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "GuiButtonProfile";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "100 229";
            oc_Newobject9["Extent"] = "50 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "autoLayers();";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["tooltip"] = "Generate a layer mask for this material.";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["text"] = "AutoPaint";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            return oc_Newobject11.Create();
        }

        public override void onPopWindow()
        {
            EditorGui.DeactivateAll();
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            TerrainPainterPlugin.onActivated();
        }

        public override void onPopWindowClosed()
        {
            EditorGui.DeactivateAll();
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            TerrainPainterPlugin.onActivated();
            TerrainPainter TerrainPainter = "TerrainPainter";
            TerrainPainter.attachTo("TerrainPainterPreview");
        }
    }
}