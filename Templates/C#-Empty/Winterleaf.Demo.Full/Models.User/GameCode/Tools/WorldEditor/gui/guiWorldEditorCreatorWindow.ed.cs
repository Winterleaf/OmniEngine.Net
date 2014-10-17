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
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class guiWorldEditorCreatorWindow
    {
        [ConsoleInteraction(true, "guiWorldEditorCreatorWindow_initialize")]
        public static void initialize()
        {
            #region GuiControl (WorldEditorCreatorWindowContainer)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "WorldEditorCreatorWindowContainer");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "0 0";
            oc_Newobject12["Extent"] = "800 600";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiWindowCtrl (EWCreatorWindow)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiWindowCtrl", "EWCreatorWindow", typeof (Creator.EWCreatorWindow));
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["internalName"] = "CreatorWindow";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "38 36";
            oc_Newobject11["Extent"] = "354 276";
            oc_Newobject11["MinExtent"] = "354 207";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["resizeWidth"] = "1";
            oc_Newobject11["resizeHeight"] = "1";
            oc_Newobject11["canMove"] = "1";
            oc_Newobject11["canClose"] = "1";
            oc_Newobject11["canMinimize"] = "0";
            oc_Newobject11["canMaximize"] = "0";
            oc_Newobject11["minSize"] = "30 30";
            oc_Newobject11["EdgeSnap"] = "0";
            oc_Newobject11["text"] = "Creator";

            #region GuiContainer ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiContainer", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["Position"] = "2 80";
            oc_Newobject3["Extent"] = "348 195";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "4 4 4 4";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "EditorLightScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "4 4";
            oc_Newobject2["Extent"] = "340 187";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Docking"] = "Client";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "dynamic";
            oc_Newobject2["vScrollBar"] = "alwaysOff";
            oc_Newobject2["lockHorizScroll"] = "false";
            oc_Newobject2["lockVertScroll"] = "true";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";

            #region GuiDynamicCtrlArrayControl (CreatorIconArray)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiDynamicCtrlArrayControl", "CreatorIconArray");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["Position"] = "2 2";
            oc_Newobject1["Extent"] = "335 183";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["colCount"] = "9";
            oc_Newobject1["colSize"] = "64";
            oc_Newobject1["rowCount"] = "0";
            oc_Newobject1["RowSize"] = "64";
            oc_Newobject1["rowSpacing"] = "4";
            oc_Newobject1["colSpacing"] = "4";
            oc_Newobject1["frozen"] = "0";
            oc_Newobject1["autoCellSize"] = "1";
            oc_Newobject1["fillRowFirst"] = "0";
            oc_Newobject1["dynamicSize"] = "1";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "4 24";
            oc_Newobject10["Extent"] = "348 55";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (CreatorNavUpButton)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "CreatorNavUpButton");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "left";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "319 33";
            oc_Newobject4["Extent"] = "20 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "EWCreatorWindow.navigateUp();";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["Bitmap"] = "tools/gui/images/folderUp.png";
            oc_Newobject4["autoSize"] = "0";

            #endregion

            oc_Newobject10["#Newobject4"] = oc_Newobject4;

            #region GuiPopUpMenuCtrl (CreatorPopupMenu)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiPopUpMenuCtrl", "CreatorPopupMenu", typeof (Creator.CreatorPopupMenu));
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "4 33";
            oc_Newobject5["Extent"] = "308 17";
            oc_Newobject5["MinExtent"] = "8 2";
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
            oc_Newobject5["text"] = "Objects";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["maxPopupHeight"] = "200";
            oc_Newobject5["sbUsesNAColor"] = "0";
            oc_Newobject5["reverseTextList"] = "0";
            oc_Newobject5["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiTabBookCtrl (CreatorTabBook)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTabBookCtrl", "CreatorTabBook", typeof (Creator.CreatorTabBook));
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "4 4";
            oc_Newobject9["Extent"] = "342 21";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Docking"] = "None";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["TabPosition"] = "Top";
            oc_Newobject9["TabMargin"] = "7";
            oc_Newobject9["MinTabWidth"] = "64";

            #region GuiTabPageCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "0 0";
            oc_Newobject6["MinExtent"] = "0 0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "0";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Shapes";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiTabPageCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "0 0";
            oc_Newobject7["Extent"] = "0 0";
            oc_Newobject7["MinExtent"] = "0 0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "0";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["text"] = "Geometry";
            oc_Newobject7["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiTabPageCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "0 0";
            oc_Newobject8["MinExtent"] = "0 0";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "MissionObjects";
            oc_Newobject8["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject12.Create();
        }
    }
}