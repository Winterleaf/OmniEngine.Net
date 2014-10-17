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

using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class SelectObjectsWindow
    {
        [ConsoleInteraction(true, "SelectObjectsWindow_initialize")]
        public static void initialize()
        {
            #region GuiControl (ESelectObjectsWindowContainer,EditorGuiGroup)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiControl", "ESelectObjectsWindowContainer,EditorGuiGroup");
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["extent"] = "1024 768";
            oc_Newobject24["minExtent"] = "8 2";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["fixedAspectRatio"] = "0";
            oc_Newobject24["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["active"] = "1";
            oc_Newobject24["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "1";

            #region GuiWindowCtrl (ESelectObjectsWindow)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiWindowCtrl", "ESelectObjectsWindow", typeof (ESelectObjectsWindow));
            oc_Newobject23["AllowPopWindow"] = "1";
            oc_Newobject23["text"] = "Select Objects";
            oc_Newobject23["resizeWidth"] = "0";
            oc_Newobject23["resizeHeight"] = "0";
            oc_Newobject23["canMove"] = "1";
            oc_Newobject23["canClose"] = "1";
            oc_Newobject23["canMinimize"] = "0";
            oc_Newobject23["canMaximize"] = "0";
            oc_Newobject23["canCollapse"] = "1";
            oc_Newobject23["closeCommand"] = "$ThisControl.toggleVisibility();";
            oc_Newobject23["edgeSnap"] = "1";
            oc_Newobject23["margin"] = "0 0 0 0";
            oc_Newobject23["padding"] = "0 0 0 0";
            oc_Newobject23["anchorTop"] = "1";
            oc_Newobject23["anchorBottom"] = "0";
            oc_Newobject23["anchorLeft"] = "1";
            oc_Newobject23["anchorRight"] = "0";
            oc_Newobject23["position"] = "268 177";
            oc_Newobject23["extent"] = "380 373";
            oc_Newobject23["minExtent"] = "200 100";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["fixedAspectRatio"] = "0";
            oc_Newobject23["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["active"] = "1";
            oc_Newobject23["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["canSaveDynamicFields"] = "0";
            //oc_Newobject23["class"] = "EObjectSelection";
            oc_Newobject23["internalName"] = "SelectObjectsWindow";

            #region GuiBitmapBorderCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject6["position"] = "7 104";
            oc_Newobject6["extent"] = "265 262";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["fixedAspectRatio"] = "0";
            oc_Newobject6["profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "0";
            oc_Newobject2["lockVertScroll"] = "0";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "10 25";
            oc_Newobject2["extent"] = "246 200";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["fixedAspectRatio"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject1["stackingType"] = "Vertical";
            oc_Newobject1["horizStacking"] = "Left to Right";
            oc_Newobject1["vertStacking"] = "Top to Bottom";
            oc_Newobject1["padding"] = "0";
            oc_Newobject1["dynamicSize"] = "1";
            oc_Newobject1["changeChildSizeToFit"] = "1";
            oc_Newobject1["changeChildPosition"] = "1";
            oc_Newobject1["position"] = "1 1";
            oc_Newobject1["extent"] = "246 1242";
            oc_Newobject1["minExtent"] = "16 16";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["fixedAspectRatio"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["internalName"] = "classList";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["text"] = "Select All";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["position"] = "10 231";
            oc_Newobject3["extent"] = "65 20";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["fixedAspectRatio"] = "0";
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["command"] = "ESelectObjectsWindow.selectAllInClassList( true );";
            oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Classes";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["position"] = "113 6";
            oc_Newobject4["extent"] = "40 17";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["fixedAspectRatio"] = "0";
            oc_Newobject4["profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject5["text"] = "Deselect All";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["position"] = "76 231";
            oc_Newobject5["extent"] = "65 20";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["fixedAspectRatio"] = "0";
            oc_Newobject5["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["command"] = "ESelectObjectsWindow.selectAllInClassList( false );";
            oc_Newobject5["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject23["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapBorderCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject14["position"] = "7 25";
            oc_Newobject14["extent"] = "366 74";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["horizSizing"] = "width";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["fixedAspectRatio"] = "0";
            oc_Newobject14["profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "Name Pattern";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["margin"] = "0 0 0 0";
            oc_Newobject7["padding"] = "0 0 0 0";
            oc_Newobject7["anchorTop"] = "1";
            oc_Newobject7["anchorBottom"] = "0";
            oc_Newobject7["anchorLeft"] = "1";
            oc_Newobject7["anchorRight"] = "0";
            oc_Newobject7["position"] = "11 9";
            oc_Newobject7["extent"] = "67 17";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["fixedAspectRatio"] = "0";
            oc_Newobject7["profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject7"] = oc_Newobject7;

            #region GuiCheckBoxCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject8["useInactiveState"] = "0";
            oc_Newobject8["text"] = "Retain Current Selection";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "ToggleButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["position"] = "216 46";
            oc_Newobject8["extent"] = "140 30";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["fixedAspectRatio"] = "0";
            oc_Newobject8["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["internalName"] = "retainSelection";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject8"] = oc_Newobject8;

            #region GuiCheckBoxCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject9["useInactiveState"] = "0";
            oc_Newobject9["text"] = "Create Selection Set";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "ToggleButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["position"] = "13 73";
            oc_Newobject9["extent"] = "117 30";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["fixedAspectRatio"] = "0";
            oc_Newobject9["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject9["visible"] = "0";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["internalName"] = "createSelectionSet";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject9"] = oc_Newobject9;

            #region GuiTextEditCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject10["historySize"] = "0";
            oc_Newobject10["tabComplete"] = "0";
            oc_Newobject10["sinkAllKeyEvents"] = "0";
            oc_Newobject10["password"] = "0";
            oc_Newobject10["passwordMask"] = "•";
            oc_Newobject10["maxLength"] = "1024";
            oc_Newobject10["margin"] = "0 0 0 0";
            oc_Newobject10["padding"] = "0 0 0 0";
            oc_Newobject10["anchorTop"] = "1";
            oc_Newobject10["anchorBottom"] = "0";
            oc_Newobject10["anchorLeft"] = "1";
            oc_Newobject10["anchorRight"] = "0";
            oc_Newobject10["position"] = "157 80";
            oc_Newobject10["extent"] = "199 17";
            oc_Newobject10["minExtent"] = "20 2";
            oc_Newobject10["horizSizing"] = "width";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["fixedAspectRatio"] = "0";
            oc_Newobject10["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject10["visible"] = "0";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["internalName"] = "selectionSetName";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject10"] = oc_Newobject10;

            #region GuiTextEditCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject11["historySize"] = "0";
            oc_Newobject11["tabComplete"] = "0";
            oc_Newobject11["sinkAllKeyEvents"] = "0";
            oc_Newobject11["password"] = "0";
            oc_Newobject11["passwordMask"] = "•";
            oc_Newobject11["maxLength"] = "1024";
            oc_Newobject11["margin"] = "0 0 0 0";
            oc_Newobject11["padding"] = "0 0 0 0";
            oc_Newobject11["anchorTop"] = "1";
            oc_Newobject11["anchorBottom"] = "0";
            oc_Newobject11["anchorLeft"] = "1";
            oc_Newobject11["anchorRight"] = "0";
            oc_Newobject11["position"] = "91 9";
            oc_Newobject11["extent"] = "265 17";
            oc_Newobject11["minExtent"] = "20 2";
            oc_Newobject11["horizSizing"] = "width";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["fixedAspectRatio"] = "0";
            oc_Newobject11["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["internalName"] = "namePattern";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["text"] = "Select Objects in Group";
            oc_Newobject12["maxLength"] = "1024";
            oc_Newobject12["margin"] = "0 0 0 0";
            oc_Newobject12["padding"] = "0 0 0 0";
            oc_Newobject12["anchorTop"] = "1";
            oc_Newobject12["anchorBottom"] = "0";
            oc_Newobject12["anchorLeft"] = "1";
            oc_Newobject12["anchorRight"] = "0";
            oc_Newobject12["position"] = "11 30";
            oc_Newobject12["extent"] = "116 17";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["fixedAspectRatio"] = "0";
            oc_Newobject12["profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject12"] = oc_Newobject12;

            #region GuiPopUpMenuCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject13["maxPopupHeight"] = "200";
            oc_Newobject13["sbUsesNAColor"] = "0";
            oc_Newobject13["reverseTextList"] = "0";
            oc_Newobject13["bitmapBounds"] = "16 16";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["margin"] = "0 0 0 0";
            oc_Newobject13["padding"] = "0 0 0 0";
            oc_Newobject13["anchorTop"] = "1";
            oc_Newobject13["anchorBottom"] = "0";
            oc_Newobject13["anchorLeft"] = "1";
            oc_Newobject13["anchorRight"] = "0";
            oc_Newobject13["position"] = "138 30";
            oc_Newobject13["extent"] = "218 17";
            oc_Newobject13["minExtent"] = "20 2";
            oc_Newobject13["horizSizing"] = "width";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["fixedAspectRatio"] = "0";
            oc_Newobject13["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["internalName"] = "groupList";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject23["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapBorderCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject20["position"] = "246 104";
            oc_Newobject20["extent"] = "233 262";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["fixedAspectRatio"] = "0";
            oc_Newobject20["profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject20["visible"] = "0";
            oc_Newobject20["active"] = "1";
            oc_Newobject20["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject16["willFirstRespond"] = "1";
            oc_Newobject16["hScrollBar"] = "alwaysOff";
            oc_Newobject16["vScrollBar"] = "dynamic";
            oc_Newobject16["lockHorizScroll"] = "0";
            oc_Newobject16["lockVertScroll"] = "0";
            oc_Newobject16["constantThumbHeight"] = "0";
            oc_Newobject16["childMargin"] = "0 0";
            oc_Newobject16["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject16["margin"] = "0 0 0 0";
            oc_Newobject16["padding"] = "0 0 0 0";
            oc_Newobject16["anchorTop"] = "1";
            oc_Newobject16["anchorBottom"] = "0";
            oc_Newobject16["anchorLeft"] = "1";
            oc_Newobject16["anchorRight"] = "0";
            oc_Newobject16["position"] = "9 25";
            oc_Newobject16["extent"] = "215 200";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["fixedAspectRatio"] = "0";
            oc_Newobject16["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject15["stackingType"] = "Vertical";
            oc_Newobject15["horizStacking"] = "Left to Right";
            oc_Newobject15["vertStacking"] = "Top to Bottom";
            oc_Newobject15["padding"] = "0";
            oc_Newobject15["dynamicSize"] = "1";
            oc_Newobject15["changeChildSizeToFit"] = "1";
            oc_Newobject15["changeChildPosition"] = "1";
            oc_Newobject15["position"] = "1 1";
            oc_Newobject15["extent"] = "215 16";
            oc_Newobject15["minExtent"] = "16 16";
            oc_Newobject15["horizSizing"] = "width";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["fixedAspectRatio"] = "0";
            oc_Newobject15["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["internalName"] = "filterList";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject20["#Newobject16"] = oc_Newobject16;

            #region GuiButtonCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject17["text"] = "Select All";
            oc_Newobject17["groupNum"] = "-1";
            oc_Newobject17["buttonType"] = "PushButton";
            oc_Newobject17["useMouseEvents"] = "0";
            oc_Newobject17["position"] = "9 231";
            oc_Newobject17["extent"] = "65 20";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["fixedAspectRatio"] = "0";
            oc_Newobject17["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject17"] = oc_Newobject17;

            #region GuiTextCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject18["text"] = "Filters";
            oc_Newobject18["maxLength"] = "1024";
            oc_Newobject18["margin"] = "0 0 0 0";
            oc_Newobject18["padding"] = "0 0 0 0";
            oc_Newobject18["anchorTop"] = "1";
            oc_Newobject18["anchorBottom"] = "0";
            oc_Newobject18["anchorLeft"] = "1";
            oc_Newobject18["anchorRight"] = "0";
            oc_Newobject18["position"] = "101 6";
            oc_Newobject18["extent"] = "30 17";
            oc_Newobject18["minExtent"] = "8 2";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["fixedAspectRatio"] = "0";
            oc_Newobject18["profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject18"] = oc_Newobject18;

            #region GuiButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject19["text"] = "Deselect All";
            oc_Newobject19["groupNum"] = "-1";
            oc_Newobject19["buttonType"] = "PushButton";
            oc_Newobject19["useMouseEvents"] = "0";
            oc_Newobject19["position"] = "75 231";
            oc_Newobject19["extent"] = "65 20";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["fixedAspectRatio"] = "0";
            oc_Newobject19["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["active"] = "1";
            oc_Newobject19["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject23["#Newobject20"] = oc_Newobject20;

            #region GuiButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject21["text"] = "Select";
            oc_Newobject21["groupNum"] = "-1";
            oc_Newobject21["buttonType"] = "PushButton";
            oc_Newobject21["useMouseEvents"] = "0";
            oc_Newobject21["position"] = "278 104";
            oc_Newobject21["extent"] = "95 30";
            oc_Newobject21["minExtent"] = "8 2";
            oc_Newobject21["horizSizing"] = "left";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["fixedAspectRatio"] = "0";
            oc_Newobject21["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["command"] = "ESelectObjectsWindow.onSelectObjects(true);";
            oc_Newobject21["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject23["#Newobject21"] = oc_Newobject21;

            #region GuiButtonCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject22["text"] = "Deselect";
            oc_Newobject22["groupNum"] = "-1";
            oc_Newobject22["buttonType"] = "PushButton";
            oc_Newobject22["useMouseEvents"] = "0";
            oc_Newobject22["position"] = "278 137";
            oc_Newobject22["extent"] = "95 30";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["horizSizing"] = "left";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["fixedAspectRatio"] = "0";
            oc_Newobject22["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["command"] = "ESelectObjectsWindow.onSelectObjects(false);";
            oc_Newobject22["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject24.Create();
        }
    }
}