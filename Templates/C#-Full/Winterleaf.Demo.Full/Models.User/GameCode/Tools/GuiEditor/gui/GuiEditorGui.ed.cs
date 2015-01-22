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
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using SaveFileDialog = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.SaveFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorGui>))]
    internal class GuiEditorGui : GuiControl
    {

        internal SimSet menuGroup
        {
            get { return this["menuGroup"]; }
            set { this["menuGroup"] = value; }
        }

        [ConsoleInteraction(true, "GuiEditorGui_initialize")]
        public static void initialize()
        {
            #region GuiControl (GuiEditorGui, EditorGuiGroup)        oc_Newobject78

            ObjectCreator oc_Newobject78 = new ObjectCreator("GuiControl", "GuiEditorGui, EditorGuiGroup", typeof (GuiEditorGui));
            oc_Newobject78["canSaveDynamicFields"] = "0";
            oc_Newobject78["isContainer"] = "1";
            oc_Newobject78["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject78["HorizSizing"] = "right";
            oc_Newobject78["VertSizing"] = "bottom";
            oc_Newobject78["Position"] = "0 0";
            oc_Newobject78["Extent"] = "800 600";
            oc_Newobject78["MinExtent"] = "8 2";
            oc_Newobject78["canSave"] = "1";
            oc_Newobject78["Visible"] = "1";
            oc_Newobject78["hovertime"] = "1000";

            #region GuiFrameSetCtrl ()        oc_Newobject73

            ObjectCreator oc_Newobject73 = new ObjectCreator("GuiFrameSetCtrl", "");
            oc_Newobject73["canSaveDynamicFields"] = "0";
            oc_Newobject73["isContainer"] = "1";
            oc_Newobject73["Profile"] = "ToolsGuiFrameSetProfile";
            oc_Newobject73["HorizSizing"] = "width";
            oc_Newobject73["VertSizing"] = "height";
            oc_Newobject73["Position"] = "0 0";
            oc_Newobject73["Extent"] = "800 583";
            oc_Newobject73["MinExtent"] = "8 2";
            oc_Newobject73["canSave"] = "1";
            oc_Newobject73["Visible"] = "1";
            oc_Newobject73["hovertime"] = "1000";
            oc_Newobject73["columns"] = "0 631";
            oc_Newobject73["rows"] = "0";
            oc_Newobject73["borderWidth"] = "1";
            oc_Newobject73["border"] = "0";
            oc_Newobject73["borderEnable"] = "dynamic";
            oc_Newobject73["borderMovable"] = "dynamic";
            oc_Newobject73["autoBalance"] = "1";
            oc_Newobject73["fudgeFactor"] = "3";

            #region GuiControl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiControl", "");
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject38["HorizSizing"] = "width";
            oc_Newobject38["VertSizing"] = "height";
            oc_Newobject38["Position"] = "0 0";
            oc_Newobject38["Extent"] = "627 583";
            oc_Newobject38["MinExtent"] = "64 64";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["hovertime"] = "1000";

            #region GuiContainer (GHToolBar)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiContainer", "GHToolBar");
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["profile"] = "menubarProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["extent"] = "16000 32";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl (GHWorldEditor)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "GHWorldEditor");
            oc_Newobject1["bitmap"] = "tools/worldEditor/images/toolbar/world";
            oc_Newobject1["bitmapMode"] = "Stretched";
            oc_Newobject1["autoFitExtents"] = "0";
            oc_Newobject1["groupNum"] = "0";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "4 3";
            oc_Newobject1["extent"] = "29 27";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["command"] = "GuiEditor.switchToWorldEditor();";
            oc_Newobject1["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "World Editor";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (GHGuiEditor)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "GHGuiEditor");
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/toolbar/gui";
            oc_Newobject2["bitmapMode"] = "Stretched";
            oc_Newobject2["autoFitExtents"] = "0";
            oc_Newobject2["groupNum"] = "0";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "34 3";
            oc_Newobject2["extent"] = "29 27";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Gui Editor";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/toolbar/playbutton";
            oc_Newobject3["bitmapMode"] = "Stretched";
            oc_Newobject3["autoFitExtents"] = "0";
            oc_Newobject3["groupNum"] = "0";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "64 3";
            oc_Newobject3["extent"] = "29 27";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["command"] = "GuiEdit(); Editor.close(\\\"PlayGui\\\");";
            oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Play Game";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject4["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject4["wrap"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "98 3";
            oc_Newobject4["extent"] = "2 26";
            oc_Newobject4["minExtent"] = "1 1";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject38["#Newobject5"] = oc_Newobject5;

            #region GuiControl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiControl", "");
            oc_Newobject30["isContainer"] = "1";
            oc_Newobject30["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject30["horizSizing"] = "width";
            oc_Newobject30["vertSizing"] = "bottom";
            oc_Newobject30["position"] = "99 0";
            oc_Newobject30["extent"] = "723 32";
            oc_Newobject30["minExtent"] = "8 2";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["canSaveDynamicFields"] = "0";

            #region GuiPopUpMenuCtrl (GuiEditorContentList)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiPopUpMenuCtrl", "GuiEditorContentList", typeof (GuiEditorContentList));
            oc_Newobject6["maxPopupHeight"] = "200";
            oc_Newobject6["sbUsesNAColor"] = "0";
            oc_Newobject6["reverseTextList"] = "0";
            oc_Newobject6["bitmapBounds"] = "16 16";
            oc_Newobject6["text"] = "NewGui - 8844";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "8 7";
            oc_Newobject6["extent"] = "145 18";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject6"] = oc_Newobject6;

            #region GuiPopUpMenuCtrl (GuiEditorResList)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiPopUpMenuCtrl", "GuiEditorResList", typeof (GuiEditorResList));
            oc_Newobject7["maxPopupHeight"] = "200";
            oc_Newobject7["sbUsesNAColor"] = "0";
            oc_Newobject7["reverseTextList"] = "0";
            oc_Newobject7["bitmapBounds"] = "16 16";
            oc_Newobject7["text"] = "1024 x 768 (XGA, 4:3)";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["margin"] = "0 0 0 0";
            oc_Newobject7["padding"] = "0 0 0 0";
            oc_Newobject7["anchorTop"] = "1";
            oc_Newobject7["anchorBottom"] = "0";
            oc_Newobject7["anchorLeft"] = "1";
            oc_Newobject7["anchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "161 7";
            oc_Newobject7["extent"] = "136 18";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject8["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject8["wrap"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["position"] = "307 3";
            oc_Newobject8["extent"] = "2 26";
            oc_Newobject8["minExtent"] = "1 1";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject8"] = oc_Newobject8;

            #region GuiControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "");
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "312 3";
            oc_Newobject12["extent"] = "95 27";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl (GuiEditorSnapCheckBox)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "GuiEditorSnapCheckBox", typeof (GuiEditorSnapCheckBox));
            oc_Newobject9["bitmap"] = "tools/gui/images/GUI-editor/snap-grid";
            oc_Newobject9["bitmapMode"] = "Stretched";
            oc_Newobject9["autoFitExtents"] = "0";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "ToggleButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["extent"] = "29 27";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Snap gui controls to a grid. Modify grid size under edit.";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapButtonCtrl (GuiEditorEdgeSnapping_btn)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapButtonCtrl", "GuiEditorEdgeSnapping_btn");
            oc_Newobject10["bitmap"] = "tools/gui/images/GUI-editor/edgesnap";
            oc_Newobject10["bitmapMode"] = "Stretched";
            oc_Newobject10["autoFitExtents"] = "0";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "ToggleButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "31 0";
            oc_Newobject10["extent"] = "29 27";
            oc_Newobject10["minExtent"] = "120 21";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["command"] = "GuiEditor.toggleEdgeSnap();";
            oc_Newobject10["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["ToolTip"] = "Toggles Edge Smart Snapping";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl (GuiEditorCenterSnapping_btn)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "GuiEditorCenterSnapping_btn");
            oc_Newobject11["bitmap"] = "tools/gui/images/GUI-editor/centersnap";
            oc_Newobject11["bitmapMode"] = "Stretched";
            oc_Newobject11["autoFitExtents"] = "0";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "ToggleButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "62 0";
            oc_Newobject11["extent"] = "29 27";
            oc_Newobject11["minExtent"] = "120 21";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["command"] = "GuiEditor.toggleCenterSnap();";
            oc_Newobject11["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["ToolTip"] = "Toggles Center Smart Snapping";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject30["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject13["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject13["wrap"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["position"] = "415 3";
            oc_Newobject13["extent"] = "2 26";
            oc_Newobject13["minExtent"] = "1 1";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject13"] = oc_Newobject13;

            #region GuiControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "");
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["position"] = "422 3";
            oc_Newobject17["extent"] = "95 27";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject14["bitmap"] = "tools/gui/images/GUI-editor/align-left";
            oc_Newobject14["bitmapMode"] = "Stretched";
            oc_Newobject14["autoFitExtents"] = "0";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["position"] = "0 0";
            oc_Newobject14["extent"] = "29 27";
            oc_Newobject14["minExtent"] = "120 21";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["command"] = "GuiEditor.Justify(0);";
            oc_Newobject14["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["ToolTip"] = "Align Left";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject17["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject15["bitmap"] = "tools/gui/images/GUI-editor/vertical-center";
            oc_Newobject15["bitmapMode"] = "Stretched";
            oc_Newobject15["autoFitExtents"] = "0";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["position"] = "20 0";
            oc_Newobject15["extent"] = "29 27";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["command"] = "GuiEditor.Justify(1);";
            oc_Newobject15["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["ToolTip"] = "Center Vertically ";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiBitmapButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject16["bitmap"] = "tools/gui/images/GUI-editor/align-right";
            oc_Newobject16["bitmapMode"] = "Stretched";
            oc_Newobject16["autoFitExtents"] = "0";
            oc_Newobject16["groupNum"] = "-1";
            oc_Newobject16["buttonType"] = "PushButton";
            oc_Newobject16["useMouseEvents"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["position"] = "40 0";
            oc_Newobject16["extent"] = "29 27";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["command"] = "GuiEditor.Justify(2);";
            oc_Newobject16["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["ToolTip"] = "Align Right";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject30["#Newobject17"] = oc_Newobject17;

            #region GuiControl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiControl", "");
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["position"] = "498 3";
            oc_Newobject21["extent"] = "95 27";
            oc_Newobject21["minExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject18["bitmap"] = "tools/gui/images/GUI-editor/align-top";
            oc_Newobject18["bitmapMode"] = "Stretched";
            oc_Newobject18["autoFitExtents"] = "0";
            oc_Newobject18["groupNum"] = "-1";
            oc_Newobject18["buttonType"] = "PushButton";
            oc_Newobject18["useMouseEvents"] = "0";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["position"] = "0 0";
            oc_Newobject18["extent"] = "29 27";
            oc_Newobject18["minExtent"] = "120 21";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["command"] = "GuiEditor.Justify(3);";
            oc_Newobject18["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["ToolTip"] = "Align Top";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject21["#Newobject18"] = oc_Newobject18;

            #region GuiBitmapButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject19["bitmap"] = "tools/gui/images/GUI-editor/horizontal-center";
            oc_Newobject19["bitmapMode"] = "Stretched";
            oc_Newobject19["autoFitExtents"] = "0";
            oc_Newobject19["groupNum"] = "-1";
            oc_Newobject19["buttonType"] = "PushButton";
            oc_Newobject19["useMouseEvents"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["position"] = "25 0";
            oc_Newobject19["extent"] = "29 27";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["command"] = "GuiEditor.Justify(7);";
            oc_Newobject19["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["ToolTip"] = "Center Horizontally";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject21["#Newobject19"] = oc_Newobject19;

            #region GuiBitmapButtonCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject20["bitmap"] = "tools/gui/images/GUI-editor/align-bottom";
            oc_Newobject20["bitmapMode"] = "Stretched";
            oc_Newobject20["autoFitExtents"] = "0";
            oc_Newobject20["groupNum"] = "-1";
            oc_Newobject20["buttonType"] = "PushButton";
            oc_Newobject20["useMouseEvents"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["position"] = "50 0";
            oc_Newobject20["extent"] = "29 27";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["command"] = "GuiEditor.Justify(4);";
            oc_Newobject20["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["ToolTip"] = "Align Bottom";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject30["#Newobject21"] = oc_Newobject21;

            #region GuiBitmapCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject22["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject22["wrap"] = "0";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["position"] = "582 3";
            oc_Newobject22["extent"] = "2 26";
            oc_Newobject22["minExtent"] = "1 1";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject22"] = oc_Newobject22;

            #region GuiBitmapCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject23["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject23["wrap"] = "0";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["position"] = "639 3";
            oc_Newobject23["extent"] = "2 26";
            oc_Newobject23["minExtent"] = "1 1";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject23"] = oc_Newobject23;

            #region GuiControl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "");
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["position"] = "615 3";
            oc_Newobject26["extent"] = "117 27";
            oc_Newobject26["minExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["visible"] = "1";
            oc_Newobject26["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject24["bitmap"] = "tools/gui/images/GUI-editor/send-to-back";
            oc_Newobject24["bitmapMode"] = "Stretched";
            oc_Newobject24["autoFitExtents"] = "0";
            oc_Newobject24["groupNum"] = "-1";
            oc_Newobject24["buttonType"] = "PushButton";
            oc_Newobject24["useMouseEvents"] = "0";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["position"] = "49 0";
            oc_Newobject24["extent"] = "29 27";
            oc_Newobject24["minExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["command"] = "GuiEditor.PushToBack();";
            oc_Newobject24["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["ToolTip"] = "Send to Back";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject24"] = oc_Newobject24;

            #region GuiBitmapButtonCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject25["bitmap"] = "tools/gui/images/GUI-editor/bring-to-front";
            oc_Newobject25["bitmapMode"] = "Stretched";
            oc_Newobject25["autoFitExtents"] = "0";
            oc_Newobject25["groupNum"] = "-1";
            oc_Newobject25["buttonType"] = "PushButton";
            oc_Newobject25["useMouseEvents"] = "0";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject25["horizSizing"] = "right";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["position"] = "27 0";
            oc_Newobject25["extent"] = "29 27";
            oc_Newobject25["minExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["visible"] = "1";
            oc_Newobject25["command"] = "GuiEditor.BringToFront();";
            oc_Newobject25["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["ToolTip"] = "Send to Front";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject30["#Newobject26"] = oc_Newobject26;

            #region GuiControl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiControl", "");
            oc_Newobject29["isContainer"] = "1";
            oc_Newobject29["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["horizSizing"] = "right";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["position"] = "583 3";
            oc_Newobject29["extent"] = "60 27";
            oc_Newobject29["minExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject27["bitmap"] = "tools/gui/images/GUI-editor/distribute-horizontal";
            oc_Newobject27["bitmapMode"] = "Stretched";
            oc_Newobject27["autoFitExtents"] = "0";
            oc_Newobject27["groupNum"] = "-1";
            oc_Newobject27["buttonType"] = "PushButton";
            oc_Newobject27["useMouseEvents"] = "0";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject27["horizSizing"] = "right";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["position"] = "0 0";
            oc_Newobject27["extent"] = "29 27";
            oc_Newobject27["minExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["visible"] = "1";
            oc_Newobject27["command"] = "GuiEditor.Justify(6);";
            oc_Newobject27["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject27["ToolTip"] = "Distribute Horizontally";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject29["#Newobject27"] = oc_Newobject27;

            #region GuiBitmapButtonCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject28["bitmap"] = "tools/gui/images/GUI-editor/distribute-vertical";
            oc_Newobject28["bitmapMode"] = "Stretched";
            oc_Newobject28["autoFitExtents"] = "0";
            oc_Newobject28["groupNum"] = "-1";
            oc_Newobject28["buttonType"] = "PushButton";
            oc_Newobject28["useMouseEvents"] = "0";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["position"] = "25 0";
            oc_Newobject28["extent"] = "29 27";
            oc_Newobject28["minExtent"] = "8 2";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["visible"] = "1";
            oc_Newobject28["command"] = "GuiEditor.Justify(5);";
            oc_Newobject28["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["ToolTip"] = "Distribute Vertically";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject38["#Newobject30"] = oc_Newobject30;

            #region GuiEditorRuler (GuiEditorTopRuler)        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiEditorRuler", "GuiEditorTopRuler");
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject31["HorizSizing"] = "width";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["Position"] = "10 32";
            oc_Newobject31["Extent"] = "614 10";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["refCtrl"] = "GuiEditorScroll";
            oc_Newobject31["editCtrl"] = "GuiEditor";

            #endregion

            oc_Newobject38["#Newobject31"] = oc_Newobject31;

            #region GuiEditorRuler (GuiEditorLeftRuler)        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiEditorRuler", "GuiEditorLeftRuler");
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "height";
            oc_Newobject32["Position"] = "0 42";
            oc_Newobject32["Extent"] = "10 523";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["refCtrl"] = "GuiEditorScroll";
            oc_Newobject32["editCtrl"] = "GuiEditor";

            #endregion

            oc_Newobject38["#Newobject32"] = oc_Newobject32;

            #region GuiScrollCtrl (GuiEditorScroll)        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiScrollCtrl", "GuiEditorScroll");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject37["HorizSizing"] = "width";
            oc_Newobject37["VertSizing"] = "height";
            oc_Newobject37["Position"] = "10 41";
            oc_Newobject37["Extent"] = "617 543";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["willFirstRespond"] = "1";
            oc_Newobject37["hScrollBar"] = "dynamic";
            oc_Newobject37["vScrollBar"] = "dynamic";
            oc_Newobject37["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject37["lockVertScroll"] = "false";
            oc_Newobject37["constantThumbHeight"] = "0";
            oc_Newobject37["childMargin"] = "0 0";

            #region GuiControl (GuiEditorRegion)        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiControl", "GuiEditorRegion");
            oc_Newobject36["canSaveDynamicFields"] = "0";
            oc_Newobject36["isContainer"] = "1";
            oc_Newobject36["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject36["HorizSizing"] = "left";
            oc_Newobject36["VertSizing"] = "top";
            oc_Newobject36["Position"] = "1 1";
            oc_Newobject36["Extent"] = "640 480";
            oc_Newobject36["MinExtent"] = "8 2";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["Visible"] = "1";
            oc_Newobject36["hovertime"] = "1000";

            #region GuiBitmapCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "GuiBackFillProfile";
            oc_Newobject33["HorizSizing"] = "width";
            oc_Newobject33["VertSizing"] = "height";
            oc_Newobject33["Position"] = "0 0";
            oc_Newobject33["Extent"] = "640 480";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["bitmap"] = "tools/guiEditor/gui/gridTiny2";
            oc_Newobject33["wrap"] = "1";

            #endregion

            oc_Newobject36["#Newobject33"] = oc_Newobject33;

            #region GuiControl (GuiEditorContent)        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiControl", "GuiEditorContent");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["isContainer"] = "1";
            oc_Newobject34["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject34["HorizSizing"] = "width";
            oc_Newobject34["VertSizing"] = "height";
            oc_Newobject34["Position"] = "0 0";
            oc_Newobject34["Extent"] = "640 480";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["hovertime"] = "1000";

            #endregion

            oc_Newobject36["#Newobject34"] = oc_Newobject34;

            #region GuiEditCtrl (GuiEditor)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiEditCtrl", "GuiEditor", typeof (GuiEditor));
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["Docking"] = "None";
            oc_Newobject35["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject35["HorizSizing"] = "width";
            oc_Newobject35["VertSizing"] = "height";
            oc_Newobject35["Position"] = "0 0";
            oc_Newobject35["Extent"] = "640 480";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["hovertime"] = "1000";

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject73["#Newobject38"] = oc_Newobject38;

            #region GuiControl (GuiEditorSidebar)        oc_Newobject72

            ObjectCreator oc_Newobject72 = new ObjectCreator("GuiControl", "GuiEditorSidebar");
            oc_Newobject72["isContainer"] = "1";
            oc_Newobject72["Profile"] = "menubarProfile";
            oc_Newobject72["HorizSizing"] = "width";
            oc_Newobject72["VertSizing"] = "height";
            oc_Newobject72["position"] = "798 0";
            oc_Newobject72["Extent"] = "226 768";
            oc_Newobject72["MinExtent"] = "8 2";
            oc_Newobject72["canSave"] = "1";
            oc_Newobject72["Visible"] = "1";
            oc_Newobject72["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject72["hovertime"] = "1000";
            oc_Newobject72["canSaveDynamicFields"] = "0";

            #region GuiTabBookCtrl (GuiEditorTabBook)        oc_Newobject67

            ObjectCreator oc_Newobject67 = new ObjectCreator("GuiTabBookCtrl", "GuiEditorTabBook", typeof (GuiEditorTabBook));
            oc_Newobject67["tabPosition"] = "Top";
            oc_Newobject67["tabMargin"] = "7";
            oc_Newobject67["minTabWidth"] = "40";
            oc_Newobject67["tabHeight"] = "20";
            oc_Newobject67["allowReorder"] = "1";
            oc_Newobject67["defaultPage"] = "0";
            oc_Newobject67["selectedPage"] = "0";
            oc_Newobject67["FrontTabPadding"] = "0";
            oc_Newobject67["Margin"] = "0 0 0 0";
            oc_Newobject67["Padding"] = "0 0 0 0";
            oc_Newobject67["AnchorTop"] = "1";
            oc_Newobject67["AnchorBottom"] = "0";
            oc_Newobject67["AnchorLeft"] = "1";
            oc_Newobject67["AnchorRight"] = "0";
            oc_Newobject67["isContainer"] = "1";
            oc_Newobject67["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject67["HorizSizing"] = "width";
            oc_Newobject67["VertSizing"] = "height";
            oc_Newobject67["position"] = "0 12";
            oc_Newobject67["Extent"] = "223 754";
            oc_Newobject67["MinExtent"] = "8 2";
            oc_Newobject67["canSave"] = "1";
            oc_Newobject67["Visible"] = "1";
            oc_Newobject67["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject67["hovertime"] = "1000";
            oc_Newobject67["canSaveDynamicFields"] = "0";

            #region GuiTabPageCtrl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject49["fitBook"] = "1";
            oc_Newobject49["text"] = "GUI";
            oc_Newobject49["maxLength"] = "1024";
            oc_Newobject49["docking"] = "client";
            oc_Newobject49["Margin"] = "-1 0 0 0";
            oc_Newobject49["Padding"] = "0 0 0 0";
            oc_Newobject49["AnchorTop"] = "1";
            oc_Newobject49["AnchorBottom"] = "0";
            oc_Newobject49["AnchorLeft"] = "1";
            oc_Newobject49["AnchorRight"] = "0";
            oc_Newobject49["isContainer"] = "1";
            oc_Newobject49["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject49["HorizSizing"] = "width";
            oc_Newobject49["VertSizing"] = "height";
            oc_Newobject49["position"] = "0 20";
            oc_Newobject49["Extent"] = "223 734";
            oc_Newobject49["MinExtent"] = "8 2";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["Visible"] = "1";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["canSaveDynamicFields"] = "0";
            oc_Newobject49["internalName"] = "guiPage";

            #region GuiFrameSetCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiFrameSetCtrl", "");
            oc_Newobject48["columns"] = "0";
            oc_Newobject48["rows"] = "0 338";
            oc_Newobject48["borderWidth"] = "1";
            oc_Newobject48["borderColor"] = "207 207 207 207";
            oc_Newobject48["borderEnable"] = "dynamic";
            oc_Newobject48["borderMovable"] = "dynamic";
            oc_Newobject48["autoBalance"] = "1";
            oc_Newobject48["fudgeFactor"] = "2";
            oc_Newobject48["Margin"] = "0 0 0 0";
            oc_Newobject48["Padding"] = "0 0 0 0";
            oc_Newobject48["AnchorTop"] = "1";
            oc_Newobject48["AnchorBottom"] = "0";
            oc_Newobject48["AnchorLeft"] = "1";
            oc_Newobject48["AnchorRight"] = "0";
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["Profile"] = "ToolsGuiFrameSetProfile";
            oc_Newobject48["HorizSizing"] = "width";
            oc_Newobject48["VertSizing"] = "height";
            oc_Newobject48["position"] = "0 0";
            oc_Newobject48["Extent"] = "222 734";
            oc_Newobject48["MinExtent"] = "8 64";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["Visible"] = "1";
            oc_Newobject48["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["canSaveDynamicFields"] = "0";

            #region GuiPanel ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiPanel", "");
            oc_Newobject43["position"] = "0 0";
            oc_Newobject43["extent"] = "222 337";

            #region GuiTextEditCtrl ( GuiEditorTreeFilter )        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiTextEditCtrl", "GuiEditorTreeFilter", typeof (treeViewFilterCtrls.GuiTreeViewFilterText));
            oc_Newobject39["position"] = "2 4";
            oc_Newobject39["extent"] = "200 18";
            oc_Newobject39["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject39["horizSizing"] = "width";
            oc_Newobject39["vertSizing"] = "bottom";
            //oc_Newobject39["class"] = "GuiTreeViewFilterText";
            oc_Newobject39["treeView"] = new Creator.StringNoQuote("GuiEditorTreeView");

            #endregion

            oc_Newobject43["#Newobject39"] = oc_Newobject39;

            #region GuiBitmapButtonCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof (treeViewFilterCtrls.GuiTreeViewFilterClearButton));
            oc_Newobject40["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject40["groupNum"] = "-1";
            oc_Newobject40["buttonType"] = "PushButton";
            oc_Newobject40["useMouseEvents"] = "0";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject40["HorizSizing"] = "left";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["position"] = "205 5";
            oc_Newobject40["Extent"] = "17 17";
            oc_Newobject40["MinExtent"] = "8 2";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["canSaveDynamicFields"] = "0";
            //oc_Newobject40["class"] = "GuiTreeViewFilterClearButton";
            oc_Newobject40["textCtrl"] = new Creator.StringNoQuote("GuiEditorTreeFilter");

            #endregion

            oc_Newobject43["#Newobject40"] = oc_Newobject40;

            #region GuiScrollCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject42["willFirstRespond"] = "1";
            oc_Newobject42["hScrollBar"] = "dynamic";
            oc_Newobject42["vScrollBar"] = "dynamic";
            oc_Newobject42["lockHorizScroll"] = "0";
            oc_Newobject42["lockVertScroll"] = "0";
            oc_Newobject42["constantThumbHeight"] = "0";
            oc_Newobject42["childMargin"] = "0 0";
            oc_Newobject42["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject42["Margin"] = "0 0 0 0";
            oc_Newobject42["Padding"] = "0 0 0 0";
            oc_Newobject42["AnchorTop"] = "1";
            oc_Newobject42["AnchorBottom"] = "0";
            oc_Newobject42["AnchorLeft"] = "1";
            oc_Newobject42["AnchorRight"] = "0";
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject42["HorizSizing"] = "width";
            oc_Newobject42["VertSizing"] = "height";
            oc_Newobject42["position"] = "0 25";
            oc_Newobject42["Extent"] = "222 312";
            oc_Newobject42["MinExtent"] = "8 64";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (GuiEditorTreeView)        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiTreeViewCtrl", "GuiEditorTreeView", typeof (GuiEditorTreeView));
            oc_Newobject41["tabSize"] = "16";
            oc_Newobject41["textOffset"] = "2";
            oc_Newobject41["fullRowSelect"] = "0";
            oc_Newobject41["itemHeight"] = "21";
            oc_Newobject41["destroyTreeOnSleep"] = "0";
            oc_Newobject41["MouseDragging"] = "1";
            oc_Newobject41["MultipleSelections"] = "1";
            oc_Newobject41["DeleteObjectAllowed"] = "1";
            oc_Newobject41["DragToItemAllowed"] = "0";
            oc_Newobject41["ClearAllOnSingleSelection"] = "1";
            oc_Newobject41["showRoot"] = "1";
            oc_Newobject41["useInspectorTooltips"] = "0";
            oc_Newobject41["tooltipOnWidthOnly"] = "0";
            oc_Newobject41["compareToObjectID"] = "1";
            oc_Newobject41["canRenameObjects"] = "1";
            oc_Newobject41["renameInternal"] = "0";
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["position"] = "1 22";
            oc_Newobject41["Extent"] = "89 2";
            oc_Newobject41["MinExtent"] = "8 2";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["showObjectIds"] = "0";
            oc_Newobject41["showClassNames"] = "0";
            oc_Newobject41["showObjectNames"] = "1";
            oc_Newobject41["showInternalNames"] = "1";
            oc_Newobject41["showClassNameForUnnamedObjects"] = "1";

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject43["#Newobject42"] = oc_Newobject42;

            #endregion

            oc_Newobject48["#Newobject43"] = oc_Newobject43;

            #region GuiControl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiControl", "");
            oc_Newobject47["isContainer"] = "1";
            oc_Newobject47["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject47["HorizSizing"] = "width";
            oc_Newobject47["VertSizing"] = "height";
            oc_Newobject47["position"] = "0 338";
            oc_Newobject47["Extent"] = "222 396";
            oc_Newobject47["MinExtent"] = "8 64";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["Visible"] = "1";
            oc_Newobject47["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject45["willFirstRespond"] = "1";
            oc_Newobject45["hScrollBar"] = "alwaysOff";
            oc_Newobject45["vScrollBar"] = "dynamic";
            oc_Newobject45["lockHorizScroll"] = "1";
            oc_Newobject45["lockVertScroll"] = "0";
            oc_Newobject45["constantThumbHeight"] = "0";
            oc_Newobject45["childMargin"] = "0 0";
            oc_Newobject45["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject45["Margin"] = "0 0 0 0";
            oc_Newobject45["Padding"] = "0 0 0 0";
            oc_Newobject45["AnchorTop"] = "1";
            oc_Newobject45["AnchorBottom"] = "0";
            oc_Newobject45["AnchorLeft"] = "1";
            oc_Newobject45["AnchorRight"] = "0";
            oc_Newobject45["isContainer"] = "1";
            oc_Newobject45["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject45["HorizSizing"] = "width";
            oc_Newobject45["VertSizing"] = "height";
            oc_Newobject45["position"] = "0 2";
            oc_Newobject45["Extent"] = "223 341";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["canSaveDynamicFields"] = "0";

            #region GuiInspector (GuiEditorInspectFields)        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiInspector", "GuiEditorInspectFields", typeof (GuiEditorInspectFields));
            oc_Newobject44["dividerMargin"] = "5";
            oc_Newobject44["showCustomFields"] = "1";
            oc_Newobject44["StackingType"] = "Vertical";
            oc_Newobject44["HorizStacking"] = "Left to Right";
            oc_Newobject44["VertStacking"] = "Top to Bottom";
            oc_Newobject44["Padding"] = "1";
            oc_Newobject44["DynamicSize"] = "1";
            oc_Newobject44["ChangeChildSizeToFit"] = "1";
            oc_Newobject44["ChangeChildPosition"] = "1";
            oc_Newobject44["isContainer"] = "1";
            oc_Newobject44["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject44["HorizSizing"] = "width";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["position"] = "1 1";
            oc_Newobject44["Extent"] = "221 24";
            oc_Newobject44["MinExtent"] = "8 24";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["Visible"] = "1";
            oc_Newobject44["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["canSaveDynamicFields"] = "0";
            //oc_Newobject44["superClass"] = "EditorInspectorBase";

            #endregion

            oc_Newobject45["#Newobject44"] = oc_Newobject44;

            #endregion

            oc_Newobject47["#Newobject45"] = oc_Newobject45;

            #region GuiMLTextCtrl (GuiEditorFieldInfo)        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiMLTextCtrl", "GuiEditorFieldInfo");
            oc_Newobject46["lineSpacing"] = "2";
            oc_Newobject46["allowColorChars"] = "0";
            oc_Newobject46["maxChars"] = "-1";
            oc_Newobject46["useURLMouseCursor"] = "0";
            oc_Newobject46["isContainer"] = "0";
            oc_Newobject46["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "top";
            oc_Newobject46["position"] = "0 349";
            oc_Newobject46["Extent"] = "213 13";
            oc_Newobject46["MinExtent"] = "8 2";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["Visible"] = "1";
            oc_Newobject46["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject47["#Newobject46"] = oc_Newobject46;

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject49["#Newobject48"] = oc_Newobject48;

            #endregion

            oc_Newobject67["#Newobject49"] = oc_Newobject49;

            #region GuiTabPageCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject52["fitBook"] = "1";
            oc_Newobject52["text"] = "Library";
            oc_Newobject52["maxLength"] = "1024";
            oc_Newobject52["docking"] = "client";
            oc_Newobject52["Margin"] = "-1 0 0 0";
            oc_Newobject52["Padding"] = "0 0 0 0";
            oc_Newobject52["AnchorTop"] = "1";
            oc_Newobject52["AnchorBottom"] = "0";
            oc_Newobject52["AnchorLeft"] = "1";
            oc_Newobject52["AnchorRight"] = "0";
            oc_Newobject52["isContainer"] = "1";
            oc_Newobject52["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject52["HorizSizing"] = "width";
            oc_Newobject52["VertSizing"] = "height";
            oc_Newobject52["position"] = "0 20";
            oc_Newobject52["Extent"] = "223 734";
            oc_Newobject52["MinExtent"] = "8 2";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["Visible"] = "0";
            oc_Newobject52["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["internalName"] = "toolboxPage";

            #region GuiScrollCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["Enabled"] = "1";
            oc_Newobject51["isContainer"] = "1";
            oc_Newobject51["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject51["HorizSizing"] = "width";
            oc_Newobject51["VertSizing"] = "height";
            oc_Newobject51["position"] = "0 0";
            oc_Newobject51["MinExtent"] = "8 2";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["willFirstRespond"] = "1";
            oc_Newobject51["hScrollBar"] = "alwaysOff";
            oc_Newobject51["vScrollBar"] = "dynamic";
            oc_Newobject51["lockHorizScroll"] = "true";
            oc_Newobject51["lockVertScroll"] = "false";
            oc_Newobject51["constantThumbHeight"] = "0";
            oc_Newobject51["childMargin"] = "0 0";
            oc_Newobject51["docking"] = "client";

            #region GuiStackControl (GuiEditorToolbox)        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiStackControl", "GuiEditorToolbox", typeof (GuiEditorToolbox));
            oc_Newobject50["StackingType"] = "Vertical";
            oc_Newobject50["HorizStacking"] = "Left to Right";
            oc_Newobject50["VertStacking"] = "Top to Bottom";
            oc_Newobject50["Padding"] = "2";
            oc_Newobject50["DynamicSize"] = "1";
            oc_Newobject50["ChangeChildSizeToFit"] = "1";
            oc_Newobject50["ChangeChildPosition"] = "1";
            oc_Newobject50["isContainer"] = "1";
            oc_Newobject50["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["position"] = "3 3";
            oc_Newobject50["Extent"] = "419 10008";
            oc_Newobject50["MinExtent"] = "16 16";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["Visible"] = "1";
            oc_Newobject50["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject51["#Newobject50"] = oc_Newobject50;

            #endregion

            oc_Newobject52["#Newobject51"] = oc_Newobject51;

            #endregion

            oc_Newobject67["#Newobject52"] = oc_Newobject52;

            #region GuiTabPageCtrl ()        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject66["fitBook"] = "1";
            oc_Newobject66["text"] = "Profiles";
            oc_Newobject66["maxLength"] = "1024";
            oc_Newobject66["docking"] = "client";
            oc_Newobject66["Margin"] = "-1 0 0 0";
            oc_Newobject66["Padding"] = "0 0 0 0";
            oc_Newobject66["AnchorTop"] = "1";
            oc_Newobject66["AnchorBottom"] = "0";
            oc_Newobject66["AnchorLeft"] = "1";
            oc_Newobject66["AnchorRight"] = "0";
            oc_Newobject66["isContainer"] = "1";
            oc_Newobject66["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject66["HorizSizing"] = "width";
            oc_Newobject66["VertSizing"] = "height";
            oc_Newobject66["position"] = "0 20";
            oc_Newobject66["Extent"] = "223 734";
            oc_Newobject66["MinExtent"] = "8 2";
            oc_Newobject66["canSave"] = "1";
            oc_Newobject66["Visible"] = "0";
            oc_Newobject66["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject66["hovertime"] = "1000";
            oc_Newobject66["canSaveDynamicFields"] = "0";
            oc_Newobject66["internalName"] = "profilesPage";

            #region GuiFrameSetCtrl ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiFrameSetCtrl", "");
            oc_Newobject65["columns"] = "0";
            oc_Newobject65["rows"] = "0 338";
            oc_Newobject65["borderWidth"] = "1";
            oc_Newobject65["borderColor"] = "207 207 207 207";
            oc_Newobject65["borderEnable"] = "dynamic";
            oc_Newobject65["borderMovable"] = "dynamic";
            oc_Newobject65["autoBalance"] = "1";
            oc_Newobject65["fudgeFactor"] = "2";
            oc_Newobject65["Margin"] = "0 0 0 0";
            oc_Newobject65["Padding"] = "0 0 0 0";
            oc_Newobject65["AnchorTop"] = "1";
            oc_Newobject65["AnchorBottom"] = "0";
            oc_Newobject65["AnchorLeft"] = "1";
            oc_Newobject65["AnchorRight"] = "0";
            oc_Newobject65["isContainer"] = "1";
            oc_Newobject65["Profile"] = "ToolsGuiFrameSetProfile";
            oc_Newobject65["HorizSizing"] = "width";
            oc_Newobject65["VertSizing"] = "height";
            oc_Newobject65["position"] = "0 0";
            oc_Newobject65["Extent"] = "222 734";
            oc_Newobject65["MinExtent"] = "8 64";
            oc_Newobject65["canSave"] = "1";
            oc_Newobject65["Visible"] = "1";
            oc_Newobject65["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject65["hovertime"] = "1000";
            oc_Newobject65["canSaveDynamicFields"] = "0";
            oc_Newobject65["internalName"] = "profileFrame";

            #region GuiPanel ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiPanel", "");
            oc_Newobject57["position"] = "0 0";
            oc_Newobject57["extent"] = "222 337";

            #region GuiTextEditCtrl ( GuiEditorProfilesTreeFilter )        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiTextEditCtrl", "GuiEditorProfilesTreeFilter", typeof (treeViewFilterCtrls.GuiTreeViewFilterText));
            oc_Newobject53["position"] = "2 4";
            oc_Newobject53["extent"] = "200 18";
            oc_Newobject53["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject53["horizSizing"] = "width";
            oc_Newobject53["vertSizing"] = "bottom";
            //oc_Newobject53["class"] = "GuiTreeViewFilterText";
            oc_Newobject53["treeView"] = new Creator.StringNoQuote("GuiEditorProfilesTree");

            #endregion

            oc_Newobject57["#Newobject53"] = oc_Newobject53;

            #region GuiBitmapButtonCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof (treeViewFilterCtrls.GuiTreeViewFilterClearButton));
            oc_Newobject54["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject54["groupNum"] = "-1";
            oc_Newobject54["buttonType"] = "PushButton";
            oc_Newobject54["useMouseEvents"] = "0";
            oc_Newobject54["isContainer"] = "0";
            oc_Newobject54["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject54["HorizSizing"] = "left";
            oc_Newobject54["VertSizing"] = "bottom";
            oc_Newobject54["position"] = "205 5";
            oc_Newobject54["Extent"] = "17 17";
            oc_Newobject54["MinExtent"] = "8 2";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["Visible"] = "1";
            oc_Newobject54["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject54["hovertime"] = "1000";
            oc_Newobject54["canSaveDynamicFields"] = "0";
            //oc_Newobject54["class"] = "GuiTreeViewFilterClearButton";
            oc_Newobject54["textCtrl"] = new Creator.StringNoQuote("GuiEditorProfilesTreeFilter");

            #endregion

            oc_Newobject57["#Newobject54"] = oc_Newobject54;

            #region GuiScrollCtrl ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject56["willFirstRespond"] = "1";
            oc_Newobject56["hScrollBar"] = "dynamic";
            oc_Newobject56["vScrollBar"] = "dynamic";
            oc_Newobject56["lockHorizScroll"] = "0";
            oc_Newobject56["lockVertScroll"] = "0";
            oc_Newobject56["constantThumbHeight"] = "0";
            oc_Newobject56["childMargin"] = "0 0";
            oc_Newobject56["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject56["Margin"] = "0 0 0 0";
            oc_Newobject56["Padding"] = "0 0 0 0";
            oc_Newobject56["AnchorTop"] = "1";
            oc_Newobject56["AnchorBottom"] = "0";
            oc_Newobject56["AnchorLeft"] = "1";
            oc_Newobject56["AnchorRight"] = "0";
            oc_Newobject56["isContainer"] = "1";
            oc_Newobject56["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject56["HorizSizing"] = "width";
            oc_Newobject56["VertSizing"] = "height";
            oc_Newobject56["position"] = "0 25";
            oc_Newobject56["Extent"] = "222 312";
            oc_Newobject56["MinExtent"] = "8 64";
            oc_Newobject56["canSave"] = "1";
            oc_Newobject56["Visible"] = "1";
            oc_Newobject56["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject56["hovertime"] = "1000";
            oc_Newobject56["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (GuiEditorProfilesTree)        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiTreeViewCtrl", "GuiEditorProfilesTree", typeof (GuiEditorProfiles.GuiEditorProfilesTree));
            oc_Newobject55["tabSize"] = "16";
            oc_Newobject55["textOffset"] = "2";
            oc_Newobject55["fullRowSelect"] = "0";
            oc_Newobject55["itemHeight"] = "21";
            oc_Newobject55["destroyTreeOnSleep"] = "0";
            oc_Newobject55["MouseDragging"] = "0";
            oc_Newobject55["MultipleSelections"] = "0";
            oc_Newobject55["DeleteObjectAllowed"] = "0";
            oc_Newobject55["DragToItemAllowed"] = "0";
            oc_Newobject55["ClearAllOnSingleSelection"] = "1";
            oc_Newobject55["showRoot"] = "1";
            oc_Newobject55["internalNamesOnly"] = "0";
            oc_Newobject55["objectNamesOnly"] = "0";
            oc_Newobject55["useInspectorTooltips"] = "0";
            oc_Newobject55["tooltipOnWidthOnly"] = "0";
            oc_Newobject55["compareToObjectID"] = "1";
            oc_Newobject55["canRenameObjects"] = "1";
            oc_Newobject55["renameInternal"] = "0";
            oc_Newobject55["isContainer"] = "1";
            oc_Newobject55["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject55["HorizSizing"] = "right";
            oc_Newobject55["VertSizing"] = "bottom";
            oc_Newobject55["position"] = "1 1";
            oc_Newobject55["Extent"] = "89 2";
            oc_Newobject55["MinExtent"] = "8 2";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject56["#Newobject55"] = oc_Newobject55;

            #endregion

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #endregion

            oc_Newobject65["#Newobject57"] = oc_Newobject57;

            #region GuiControl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiControl", "");
            oc_Newobject64["isContainer"] = "1";
            oc_Newobject64["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject64["HorizSizing"] = "width";
            oc_Newobject64["VertSizing"] = "height";
            oc_Newobject64["position"] = "0 338";
            oc_Newobject64["Extent"] = "222 396";
            oc_Newobject64["MinExtent"] = "8 64";
            oc_Newobject64["canSave"] = "1";
            oc_Newobject64["Visible"] = "1";
            oc_Newobject64["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject64["hovertime"] = "1000";
            oc_Newobject64["canSaveDynamicFields"] = "0";

            #region GuiTextEditCtrl (GuiEditorProfileFileName)        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiTextEditCtrl", "GuiEditorProfileFileName");
            oc_Newobject58["historySize"] = "0";
            oc_Newobject58["password"] = "0";
            oc_Newobject58["tabComplete"] = "0";
            oc_Newobject58["sinkAllKeyEvents"] = "0";
            oc_Newobject58["passwordMask"] = "•";
            oc_Newobject58["maxLength"] = "1024";
            oc_Newobject58["Margin"] = "0 0 0 0";
            oc_Newobject58["Padding"] = "0 0 0 0";
            oc_Newobject58["AnchorTop"] = "1";
            oc_Newobject58["AnchorBottom"] = "0";
            oc_Newobject58["AnchorLeft"] = "1";
            oc_Newobject58["AnchorRight"] = "0";
            oc_Newobject58["isContainer"] = "0";
            oc_Newobject58["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject58["HorizSizing"] = "width";
            oc_Newobject58["VertSizing"] = "bottom";
            oc_Newobject58["position"] = "0 2";
            oc_Newobject58["Extent"] = "180 17";
            oc_Newobject58["MinExtent"] = "8 2";
            oc_Newobject58["canSave"] = "1";
            oc_Newobject58["Visible"] = "1";
            oc_Newobject58["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject58["hovertime"] = "1000";
            oc_Newobject58["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject64["#Newobject58"] = oc_Newobject58;

            #region GuiBitmapButtonCtrl ()        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject59["bitmap"] = "tools/gui/images/save-icon";
            oc_Newobject59["groupNum"] = "-1";
            oc_Newobject59["buttonType"] = "PushButton";
            oc_Newobject59["useMouseEvents"] = "0";
            oc_Newobject59["isContainer"] = "0";
            oc_Newobject59["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject59["HorizSizing"] = "left";
            oc_Newobject59["VertSizing"] = "bottom";
            oc_Newobject59["position"] = "184 2";
            oc_Newobject59["Extent"] = "17 17";
            oc_Newobject59["MinExtent"] = "8 2";
            oc_Newobject59["canSave"] = "1";
            oc_Newobject59["Visible"] = "1";
            oc_Newobject59["Command"] = "GuiEditor.saveProfile( GuiEditorProfilesTree.getSelectedProfile(), GuiEditorProfileFileName.getText() );";
            oc_Newobject59["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject59["ToolTip"] = "Save the currently selected profile.";
            oc_Newobject59["internalName"] = "saveButton";
            oc_Newobject59["hovertime"] = "1000";
            oc_Newobject59["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject64["#Newobject59"] = oc_Newobject59;

            #region GuiBitmapButtonCtrl ()        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject60["bitmap"] = "tools/gui/images/save-as";
            oc_Newobject60["groupNum"] = "-1";
            oc_Newobject60["buttonType"] = "PushButton";
            oc_Newobject60["useMouseEvents"] = "0";
            oc_Newobject60["isContainer"] = "0";
            oc_Newobject60["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject60["HorizSizing"] = "left";
            oc_Newobject60["VertSizing"] = "bottom";
            oc_Newobject60["position"] = "205 2";
            oc_Newobject60["Extent"] = "17 17";
            oc_Newobject60["MinExtent"] = "8 2";
            oc_Newobject60["canSave"] = "1";
            oc_Newobject60["Visible"] = "1";
            oc_Newobject60["Command"] = "GuiEditor.showSaveProfileDialog( GuiEditorProfileFileName.getText() );";
            oc_Newobject60["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject60["ToolTip"] = "Save the currently selected profile to a different file.";
            oc_Newobject60["hovertime"] = "1000";
            oc_Newobject60["internalName"] = "saveAsButton";
            oc_Newobject60["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject64["#Newobject60"] = oc_Newobject60;

            #region GuiScrollCtrl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject62["willFirstRespond"] = "1";
            oc_Newobject62["hScrollBar"] = "alwaysOff";
            oc_Newobject62["vScrollBar"] = "dynamic";
            oc_Newobject62["lockHorizScroll"] = "1";
            oc_Newobject62["lockVertScroll"] = "0";
            oc_Newobject62["constantThumbHeight"] = "0";
            oc_Newobject62["childMargin"] = "0 0";
            oc_Newobject62["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject62["Margin"] = "0 0 0 0";
            oc_Newobject62["Padding"] = "0 0 0 0";
            oc_Newobject62["AnchorTop"] = "1";
            oc_Newobject62["AnchorBottom"] = "0";
            oc_Newobject62["AnchorLeft"] = "1";
            oc_Newobject62["AnchorRight"] = "0";
            oc_Newobject62["isContainer"] = "1";
            oc_Newobject62["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject62["HorizSizing"] = "width";
            oc_Newobject62["VertSizing"] = "height";
            oc_Newobject62["position"] = "0 22";
            oc_Newobject62["Extent"] = "223 321";
            oc_Newobject62["MinExtent"] = "8 2";
            oc_Newobject62["canSave"] = "1";
            oc_Newobject62["Visible"] = "1";
            oc_Newobject62["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject62["hovertime"] = "1000";
            oc_Newobject62["canSaveDynamicFields"] = "0";

            #region GuiInspector (GuiEditorProfileInspector)        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiInspector", "GuiEditorProfileInspector", typeof (GuiEditorProfiles.GuiEditorProfileInspector));
            oc_Newobject61["dividerMargin"] = "5";
            oc_Newobject61["showCustomFields"] = "1";
            oc_Newobject61["StackingType"] = "Vertical";
            oc_Newobject61["HorizStacking"] = "Left to Right";
            oc_Newobject61["VertStacking"] = "Top to Bottom";
            oc_Newobject61["Padding"] = "1";
            oc_Newobject61["DynamicSize"] = "1";
            oc_Newobject61["ChangeChildSizeToFit"] = "1";
            oc_Newobject61["ChangeChildPosition"] = "1";
            oc_Newobject61["isContainer"] = "1";
            oc_Newobject61["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject61["HorizSizing"] = "width";
            oc_Newobject61["VertSizing"] = "bottom";
            oc_Newobject61["position"] = "1 1";
            oc_Newobject61["Extent"] = "221 24";
            oc_Newobject61["MinExtent"] = "8 24";
            oc_Newobject61["canSave"] = "1";
            oc_Newobject61["Visible"] = "1";
            oc_Newobject61["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject61["hovertime"] = "1000";
            oc_Newobject61["canSaveDynamicFields"] = "0";
            //oc_Newobject61["superClass"] = "EditorInspectorBase";

            #endregion

            oc_Newobject62["#Newobject61"] = oc_Newobject61;

            #endregion

            oc_Newobject64["#Newobject62"] = oc_Newobject62;

            #region GuiMLTextCtrl (GuiEditorProfileFieldInfo)        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiMLTextCtrl", "GuiEditorProfileFieldInfo");
            oc_Newobject63["lineSpacing"] = "2";
            oc_Newobject63["allowColorChars"] = "0";
            oc_Newobject63["maxChars"] = "-1";
            oc_Newobject63["useURLMouseCursor"] = "0";
            oc_Newobject63["isContainer"] = "0";
            oc_Newobject63["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
            oc_Newobject63["HorizSizing"] = "width";
            oc_Newobject63["VertSizing"] = "top";
            oc_Newobject63["position"] = "0 349";
            oc_Newobject63["Extent"] = "213 13";
            oc_Newobject63["MinExtent"] = "8 2";
            oc_Newobject63["canSave"] = "1";
            oc_Newobject63["Visible"] = "1";
            oc_Newobject63["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject63["hovertime"] = "1000";
            oc_Newobject63["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject64["#Newobject63"] = oc_Newobject63;

            #endregion

            oc_Newobject65["#Newobject64"] = oc_Newobject64;

            #endregion

            oc_Newobject66["#Newobject65"] = oc_Newobject65;

            #endregion

            oc_Newobject67["#Newobject66"] = oc_Newobject66;

            #endregion

            oc_Newobject72["#Newobject67"] = oc_Newobject67;

            #region GuiBitmapButtonCtrl ()        oc_Newobject68

            ObjectCreator oc_Newobject68 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject68["bitmap"] = "tools/gui/images/delete";
            oc_Newobject68["groupNum"] = "-1";
            oc_Newobject68["buttonType"] = "PushButton";
            oc_Newobject68["useMouseEvents"] = "0";
            oc_Newobject68["isContainer"] = "0";
            oc_Newobject68["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject68["HorizSizing"] = "left";
            oc_Newobject68["VertSizing"] = "bottom";
            oc_Newobject68["position"] = "156 12";
            oc_Newobject68["Extent"] = "17 17";
            oc_Newobject68["MinExtent"] = "8 2";
            oc_Newobject68["canSave"] = "1";
            oc_Newobject68["Visible"] = "1";
            oc_Newobject68["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject68["hovertime"] = "1000";
            oc_Newobject68["internalName"] = "button1";
            oc_Newobject68["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject72["#Newobject68"] = oc_Newobject68;

            #region GuiBitmapButtonCtrl ()        oc_Newobject69

            ObjectCreator oc_Newobject69 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject69["bitmap"] = "tools/gui/images/delete";
            oc_Newobject69["groupNum"] = "-1";
            oc_Newobject69["buttonType"] = "PushButton";
            oc_Newobject69["useMouseEvents"] = "0";
            oc_Newobject69["isContainer"] = "0";
            oc_Newobject69["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject69["HorizSizing"] = "left";
            oc_Newobject69["VertSizing"] = "bottom";
            oc_Newobject69["position"] = "174 12";
            oc_Newobject69["Extent"] = "16 16";
            oc_Newobject69["MinExtent"] = "8 2";
            oc_Newobject69["canSave"] = "1";
            oc_Newobject69["Visible"] = "1";
            oc_Newobject69["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject69["hovertime"] = "1000";
            oc_Newobject69["internalName"] = "button2";
            oc_Newobject69["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject72["#Newobject69"] = oc_Newobject69;

            #region GuiBitmapButtonCtrl ()        oc_Newobject70

            ObjectCreator oc_Newobject70 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject70["bitmap"] = "tools/gui/images/delete";
            oc_Newobject70["groupNum"] = "-1";
            oc_Newobject70["buttonType"] = "PushButton";
            oc_Newobject70["useMouseEvents"] = "0";
            oc_Newobject70["isContainer"] = "0";
            oc_Newobject70["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject70["HorizSizing"] = "left";
            oc_Newobject70["VertSizing"] = "bottom";
            oc_Newobject70["position"] = "192 12";
            oc_Newobject70["Extent"] = "16 16";
            oc_Newobject70["MinExtent"] = "8 2";
            oc_Newobject70["canSave"] = "1";
            oc_Newobject70["Visible"] = "1";
            oc_Newobject70["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject70["hovertime"] = "1000";
            oc_Newobject70["internalName"] = "button3";
            oc_Newobject70["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject72["#Newobject70"] = oc_Newobject70;

            #region GuiBitmapButtonCtrl ()        oc_Newobject71

            ObjectCreator oc_Newobject71 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject71["bitmap"] = "tools/gui/images/delete";
            oc_Newobject71["groupNum"] = "-1";
            oc_Newobject71["buttonType"] = "PushButton";
            oc_Newobject71["useMouseEvents"] = "0";
            oc_Newobject71["isContainer"] = "0";
            oc_Newobject71["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject71["HorizSizing"] = "left";
            oc_Newobject71["VertSizing"] = "bottom";
            oc_Newobject71["position"] = "207 12";
            oc_Newobject71["Extent"] = "17 17";
            oc_Newobject71["MinExtent"] = "8 2";
            oc_Newobject71["canSave"] = "1";
            oc_Newobject71["Visible"] = "1";
            oc_Newobject71["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject71["hovertime"] = "1000";
            oc_Newobject71["internalName"] = "button4";
            oc_Newobject71["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject72["#Newobject71"] = oc_Newobject71;

            #endregion

            oc_Newobject73["#Newobject72"] = oc_Newobject72;

            #endregion

            oc_Newobject78["#Newobject73"] = oc_Newobject73;

            #region GuiControl ()        oc_Newobject77

            ObjectCreator oc_Newobject77 = new ObjectCreator("GuiControl", "");
            oc_Newobject77["position"] = "0 583";
            oc_Newobject77["extent"] = "800 17";
            oc_Newobject77["horizSizing"] = "width";
            oc_Newobject77["vertSizing"] = "top";
            oc_Newobject77["minExtent"] = "64 17";
            oc_Newobject77["canSave"] = "1";
            oc_Newobject77["visible"] = "1";
            oc_Newobject77["isContainer"] = "1";
            oc_Newobject77["profile"] = "menubarProfile";

            #region GuiTextCtrl ( GuiEditorStatusBar )        oc_Newobject74

            ObjectCreator oc_Newobject74 = new ObjectCreator("GuiTextCtrl", "GuiEditorStatusBar", typeof (GuiEditorStatusBar));
            oc_Newobject74["profile"] = "ToolsGuiTextProfile";
            oc_Newobject74["position"] = "5 0";
            oc_Newobject74["extent"] = "500 17";
            oc_Newobject74["minExtent"] = "64 17";
            oc_Newobject74["canSave"] = "1";
            oc_Newobject74["visible"] = "1";

            #endregion

            oc_Newobject77["#Newobject74"] = oc_Newobject74;

            #region GuiSeparatorCtrl ()        oc_Newobject75

            ObjectCreator oc_Newobject75 = new ObjectCreator("GuiSeparatorCtrl", "");
            oc_Newobject75["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject75["position"] = "505 0";
            oc_Newobject75["extent"] = "10 17";
            oc_Newobject75["minExtent"] = "10 17";
            oc_Newobject75["canSave"] = "1";
            oc_Newobject75["visible"] = "1";
            oc_Newobject75["horizSizing"] = "left";

            #endregion

            oc_Newobject77["#Newobject75"] = oc_Newobject75;

            #region GuiTextCtrl ( GuiEditorSelectionStatus )        oc_Newobject76

            ObjectCreator oc_Newobject76 = new ObjectCreator("GuiTextCtrl", "GuiEditorSelectionStatus");
            oc_Newobject76["profile"] = "ToolsGuiTextProfile";
            oc_Newobject76["position"] = "515 0";
            oc_Newobject76["extent"] = "100 17";
            oc_Newobject76["minExtent"] = "100 17";
            oc_Newobject76["canSave"] = "1";
            oc_Newobject76["visible"] = "1";
            oc_Newobject76["horizSizing"] = "left";

            #endregion

            oc_Newobject77["#Newobject76"] = oc_Newobject76;

            #endregion

            oc_Newobject78["#Newobject77"] = oc_Newobject77;

            #endregion

            oc_Newobject78.Create();

            bGlobal["$InGuiEditor"] = false;
            bGlobal["$MLAAFxGuiEditorTemp"] = false;

            ActionMap GlobalActionMap = "GlobalActionMap";

            GlobalActionMap.bind("keyboard", "f10", "toggleGuiEditor");

            Util.eval(@"package GuiEditor_BlockDialogs
            {
            function GuiCanvas::pushDialog() {}
            function GuiCanvas::popDialog() {}
            };");
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            GuiEditor GuiEditor = "GuiEditor";
            GuiEditorSnapCheckBox GuiEditorSnapCheckBox = "GuiEditorSnapCheckBox";
            GuiEditorSelectDlg GuiEditorSelectDlg = "GuiEditorSelectDlg";
            GuiBitmapButtonCtrl GHGuiEditor = "GHGuiEditor";
            GuiBitmapButtonCtrl GuiEditorEdgeSnapping_btn = "GuiEditorEdgeSnapping_btn";
            GuiBitmapButtonCtrl GuiEditorCenterSnapping_btn = "GuiEditorCenterSnapping_btn";
            GuiEditorToolbox GuiEditorToolbox = "GuiEditorToolbox";
            GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

            GHGuiEditor.setStateOn(true);

            if (!this.FOF("SelectControlsDlg").isObject())
                {
                this.add(GuiEditorSelectDlg);
                GuiEditorSelectDlg.setVisible(false);
                }

            // Attach our menus.

            if (this.menuGroup.isObject())
                {
                for (uint i = 0; i < this.menuGroup.getCount(); i ++)
                    ((PopupMenu) this.menuGroup.getObject(i)).attachToMenuBar("", 0, ""); //TODO
                }

            // Read settings.

            this.initSettings();
            this.readSettings();

            // Initialize toolbox.

            if (!GuiEditorToolbox.isInitialized)
                GuiEditorToolbox.initialize();

            // Set up initial menu toggle states.

            MenuBuilder SnapMenu = GuiEditCanvas.menuBar.FOF("SnapMenu");
            MenuBuilder EditMenu = GuiEditCanvas.menuBar.FOF("EditMenu");
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_EDGESNAP_INDEX"], GuiEditor.snapToEdges);
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_CENTERSNAP_INDEX"], GuiEditor.snapToCenters);
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_GUIDESNAP_INDEX"], GuiEditor.snapToGuides);
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_CONTROLSNAP_INDEX"], GuiEditor.snapToControls);
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_CANVASSNAP_INDEX"], GuiEditor.snapToCanvas);
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_GRIDSNAP_INDEX"], GuiEditor.snap2Grid);
            SnapMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_DRAWGUIDES_INDEX"], GuiEditor.drawGuides);
            EditMenu.checkItem(iGlobal["$GUI_EDITOR_MENU_FULLBOXSELECT_INDEX"], GuiEditor.fullBoxSelection);

            // Sync toolbar buttons.

            GuiEditorSnapCheckBox.setStateOn(GuiEditor.snap2Grid);
            GuiEditorEdgeSnapping_btn.setStateOn(GuiEditor.snapToEdges);
            GuiEditorCenterSnapping_btn.setStateOn(GuiEditor.snapToCenters);
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onSleep()
        {
            GuiEditor GuiEditor = "GuiEditor";

            // If we are editing a control, store its guide state.

            SimObject content = GuiEditor.getContentControl();
            if (content.isObject())
                GuiEditor.writeGuides(content);

            // Remove our menus.

            if (this.menuGroup.isObject())
                {
                for (uint i = 0; i < this.menuGroup.getCount(); i ++)
                    ((PopupMenu) this.menuGroup.getObject(i)).removeFromMenuBar();
                }

            // Store our preferences.

            this.writeSettings();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void initSettings()
        {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("GuiEditor", true);

            EditorSettings.setDefaultValue("lastPath", "");
            EditorSettings.setDefaultValue("previewResolution", "1024 768");

            EditorSettings.beginGroup("EngineDevelopment");
            EditorSettings.setDefaultValue("toggleIntoEditor", "0");
            EditorSettings.setDefaultValue("showEditorProfiles", "0");
            EditorSettings.setDefaultValue("showEditorGuis", "0");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Library");
            EditorSettings.setDefaultValue("viewType", "Categorized");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Snapping");
            EditorSettings.setDefaultValue("snapToControls", "1");
            EditorSettings.setDefaultValue("snapToGuides", "1");
            EditorSettings.setDefaultValue("snapToCanvas", "1");
            EditorSettings.setDefaultValue("snapToEdges", "1");
            EditorSettings.setDefaultValue("snapToCenters", "1");
            EditorSettings.setDefaultValue("sensitivity", "2");
            EditorSettings.setDefaultValue("snap2Grid", "0");
            EditorSettings.setDefaultValue("snap2GridSize", sGlobal["$GuiEditor::defaultGridSize"]);
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Selection");
            EditorSettings.setDefaultValue("fullBox", "0");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Rendering");
            EditorSettings.setDefaultValue("drawBorderLines", "1");
            EditorSettings.setDefaultValue("drawGuides", "1");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Help");
            EditorSettings.setDefaultValue("documentationURL", "http://www.garagegames.com/products/torque-3d/documentation/user");
            //RDTODO: make this point to Gui Editor docs when available

            // Create a path to the local documentation.  This is a bit of guesswork here.
            // It assumes that the project is located in a folder of the SDK root directory
            // (e.g. "Examples/" or "Demos/") and that from there the path to the game
            // folder is "<project>/game".
            EditorSettings.setDefaultValue("documentationLocal", "../../../Documentation/Official Documentation.html");

            EditorSettings.setDefaultValue("documentationReference", "../../../Documentation/Torque 3D - Script Manual.chm");

            EditorSettings.endGroup();

            EditorSettings.endGroup();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void readSettings()
        {
            Settings EditorSettings = "EditorSettings";
            GuiEditor GuiEditor = "GuiEditor";
            GuiEditorToolbox GuiEditorToolbox = "GuiEditorToolbox";

            EditorSettings.read();

            EditorSettings.beginGroup("GuiEditor", true);

            GuiEditor["lastPath"] = EditorSettings.value("lastPath");
            GuiEditor["previewResolution"] = EditorSettings.value("previewResolution");

            EditorSettings.beginGroup("EngineDevelopment");
            GuiEditor["toggleIntoEditor"] = EditorSettings.value("toggleIntoEditor");
            GuiEditor["showEditorProfiles"] = EditorSettings.value("showEditorProfiles");
            GuiEditor["showEditorGuis"] = EditorSettings.value("showEditorGuis");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Library");
            GuiEditorToolbox.currentViewType = EditorSettings.value("viewType");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Snapping");
            GuiEditor.snapToGuides = EditorSettings.value("snapToGuides").AsBool();
            GuiEditor.snapToControls = EditorSettings.value("snapToControls").AsBool();
            GuiEditor.snapToCanvas = EditorSettings.value("snapToCanvas").AsBool();
            GuiEditor.snapToEdges = EditorSettings.value("snapToEdges").AsBool();
            GuiEditor.snapToCenters = EditorSettings.value("snapToCenters").AsBool();
            GuiEditor.snapSensitivity = EditorSettings.value("sensitivity").AsInt();
            GuiEditor.snap2Grid = EditorSettings.value("snap2Grid").AsBool();
            GuiEditor["snap2GridSize"] = EditorSettings.value("snap2GridSize");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Selection");
            GuiEditor.fullBoxSelection = EditorSettings.value("fullBox").AsBool();
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Rendering");
            GuiEditor.drawBorderLines = EditorSettings.value("drawBorderLines").AsBool();
            GuiEditor.drawGuides = EditorSettings.value("drawGuides").AsBool();
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Help");
            GuiEditor["documentationURL"] = EditorSettings.value("documentationURL");
            GuiEditor["documentationLocal"] = EditorSettings.value("documentationLocal");
            GuiEditor["documentationReference"] = EditorSettings.value("documentationReference");
            EditorSettings.endGroup();

            EditorSettings.endGroup();

            if (GuiEditor.snap2Grid)
                GuiEditor.setSnapToGrid(GuiEditor["snap2GridSize"].AsUint());
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void writeSettings()
        {
            GuiEditor GuiEditor = "GuiEditor";
            Settings EditorSettings = "EditorSettings";
            GuiEditorToolbox GuiEditorToolbox = "GuiEditorToolbox";

            EditorSettings.beginGroup("GuiEditor", true);

            EditorSettings.setValue("lastPath", GuiEditor["lastPath"]);
            EditorSettings.setValue("previewResolution", GuiEditor["previewResolution"]);

            EditorSettings.beginGroup("EngineDevelopment");
            EditorSettings.setValue("toggleIntoEditor", GuiEditor["toggleIntoEditor"]);
            EditorSettings.setValue("showEditorProfiles", GuiEditor["showEditorProfiles"]);
            EditorSettings.setValue("showEditorGuis", GuiEditor["showEditorGuis"]);
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Library");
            EditorSettings.setValue("viewType", GuiEditorToolbox.currentViewType);
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Snapping");
            EditorSettings.setValue("snapToControls", GuiEditor.snapToControls.AsString());
            EditorSettings.setValue("snapToGuides", GuiEditor.snapToGuides.AsString());
            EditorSettings.setValue("snapToCanvas", GuiEditor.snapToCanvas.AsString());
            EditorSettings.setValue("snapToEdges", GuiEditor.snapToEdges.AsString());
            EditorSettings.setValue("snapToCenters", GuiEditor.snapToCenters.AsString());
            EditorSettings.setValue("sensitivity", GuiEditor.snapSensitivity.AsString());
            EditorSettings.setValue("snap2Grid", GuiEditor.snap2Grid.AsString());
            EditorSettings.setValue("snap2GridSize", GuiEditor["snap2GridSize"]);
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Selection");
            EditorSettings.setValue("fullBox", GuiEditor.fullBoxSelection.AsString());
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Rendering");
            EditorSettings.setValue("drawBorderLines", GuiEditor.drawBorderLines.AsString());
            EditorSettings.setValue("drawGuides", GuiEditor.drawGuides.AsString());
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Help");
            EditorSettings.setValue("documentationURL", GuiEditor["documentationURL"]);
            EditorSettings.setValue("documentationLocal", GuiEditor["documentationLocal"]);
            EditorSettings.setValue("documentationReference", GuiEditor["documentationReference"]);
            EditorSettings.endGroup();

            EditorSettings.endGroup();

            EditorSettings.write();
        }

        [ConsoleInteraction]
        public static void GuiEdit(string val)
        {
            GuiCanvas Canvas = "Canvas";
            GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";
            PostEffect MLAAFx = "MLAAFx";

            if (Canvas.isFullscreen())
                {
                messageBox.MessageBoxOK("Windowed Mode Required", "Please switch to windowed mode to access the GUI Editor.");
                return;
                }

            if (val != "")
                return;

            if (!bGlobal["$InGuiEditor"])
                {
                GuiEditContent(Canvas.getContent());

                //Temp fix to disable MLAA when in GUI editor
                if (MLAAFx.isObject() && MLAAFx.isEnabled)
                    {
                    MLAAFx.isEnabled = false;
                    bGlobal["$MLAAFxGuiEditorTemp"] = true;
                    }
                }
            else
                GuiEditCanvas.quit();
        }

        [ConsoleInteraction]
        public static void GuiEditContent(SimObject content)
        {
            GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";
            GuiEditor GuiEditor = "GuiEditor";

            if (!GuiEditCanvas.isObject())
                new ObjectCreator("GuiControl", "GuiEditCanvas,EditorGuiGroup", typeof (GuiEditCanvas)).Create();

            GuiEditor.openForEditing(content);

            bGlobal["$InGuiEditor"] = true;
        }

        [ConsoleInteraction]
        public static void toggleGuiEditor(bool make)
        {
            GuiEditor GuiEditor = "GuiEditor";

            if (make)
                {
                if (missionLoad.EditorIsActive() && !GuiEditor["toggleIntoEditorGui"].AsBool())
                    editor.toggleEditor(true);

                GuiEdit("");
                // Cancel the scheduled event to prevent
                // the level from cycling after it's duration
                // has elapsed.
                Util.cancel(iGlobal["$Game::Schedule"]);
                }
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditor>))]
        public class GuiEditor : GuiEditCtrl
        {
            public bool dontSyncTreeViewSelection
            {
                get { return this["dontSyncTreeViewSelection"].AsBool(); }
                set { this["dontSyncTreeViewSelection"] = value.AsString(); }
            }

            public bool snap2Grid
            {
                get { return this["snap2Grid"].AsBool(); }
                set { this["snap2Grid"] = value.AsString(); }
            }

            public int numDirtyProfiles
            {
                get { return this["numDirtyProfiles"].AsInt(); }
                set { this["numDirtyProfiles"] = value.AsString(); }
            }

            public GuiEditorUndo.GenericUndoAction pendingGenericUndoAction
            {
                get { return this["pendingGenericUndoAction"]; }
                set { this["pendingGenericUndoAction"] = value; }
            }

            [ConsoleInteraction]
            public void openForEditing(SimObject content)
            {
                GuiCanvas Canvas = "Canvas";
                GuiEditorGui GuiEditorGui = "GuiEditorGui";
                GuiControl GuiEditorContent = "GuiEditorContent";
                GuiEditorContentList GuiEditorContentList = "GuiEditorContentList";
                GuiEditorResList GuiEditorResList = "GuiEditorResList";
                GuiScrollCtrl GuiEditorScroll = "GuiEditorScroll";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiEditorProfiles.GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";
                GuiEditorProfiles.GuiEditorProfileChangeManager GuiEditorProfileChangeManager = "GuiEditorProfileChangeManager";

                Canvas.setContent(GuiEditorGui);
                while (GuiEditorContent.getCount() != 0)
                    "GuiGroup".call("add", new string[] {GuiEditorContent.getObject(0)});
                // get rid of anything being edited

                // Clear the current guide set and add the guides
                // from the control.

                this.clearGuides();
                this.readGuides(content);

                // Enumerate GUIs and put them into the content list.

                GuiEditorContentList.init();

                GuiEditorScroll.scrollToTop();
                Util.activatePackage("GuiEditor_BlockDialogs");
                Extendable.GuiCanvas.blockDialogs = true;
                GuiEditorContent.add(content);
                Util.deactivatePackage("GuiEditor_BlockDialogs");
                Extendable.GuiCanvas.blockDialogs = false;
                GuiEditorContentList.sort();

                string name = "";
                if (content.getName() == "")
                    name = "(unnamed) - " + content;
                else
                    name = content.getName() + " - " + content;

                GuiEditorContentList.setText(name);

                this.setContentControl(content);

                // Initialize the preview resolution list and select the current
                // preview resolution.

                GuiEditorResList.init();

                string res = this["previewResolution"];
                if (res == "")
                    res = "1024 768";
                GuiEditorResList.selectFormat(res);

                // Initialize the treeview and expand the first level.

                GuiEditorTreeView.init();
                GuiEditorTreeView.open(content);
                GuiEditorTreeView.expandItem(1);

                // Initialize profiles tree.

                if (!GuiEditorProfilesTree["isInitialized"].AsBool())
                    {
                    GuiEditorProfilesTree.init();
                    GuiEditorProfilesTree["isInitialized"] = true.AsString();
                    }

                // Create profile change manager if we haven't already.

                if (!GuiEditorProfileChangeManager.isObject())
                    new ObjectCreator("SimGroup", "GuiEditorProfileChangeManager", typeof (GuiEditorProfiles.GuiEditorProfileChangeManager)).Create();

                // clear the undo manager if we're switching controls.
                if (this["lastContent"] != content)
                    this.getUndoManager().clearAll();

                this.setFirstResponderX();

                this.updateUndoMenu();
                this["lastContent"] = content;
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void switchToWorldEditor()
            {
                GuiControl GuiEditorContent = "GuiEditorContent";

                bool editingWorldEditor = GuiEditorContent.getObject(0) == this.getId().AsString();

                GuiEdit("");

                if (!bGlobal["$missionRunning"])
                    MenuHandlers.EditorNewLevel("");
                else if (!editingWorldEditor)
                    editor.toggleEditor(true);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void enableMenuItems(bool val)
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                MenuBuilder menu = GuiEditCanvas.menuBar.FOT("EditMenu");

                menu.enableItem(3, val); // cut
                menu.enableItem(4, val); // copy
                menu.enableItem(5, val); // paste
                //menu.enableItem( 7, val ); // selectall
                //menu.enableItem( 8, val ); // deselectall
                menu.enableItem(9, val); // selectparents
                menu.enableItem(10, val); // selectchildren
                menu.enableItem(11, val); // addselectparents
                menu.enableItem(12, val); // addselectchildren
                menu.enableItem(15, val); // lock
                menu.enableItem(16, val); // hide
                menu.enableItem(18, val); // group
                menu.enableItem(19, val); // ungroup

                ((MenuBuilder) GuiEditCanvas.menuBar.FOT("LayoutMenu")).enableAllItems(val);
                ((MenuBuilder) GuiEditCanvas.menuBar.FOT("MoveMenu")).enableAllItems(val);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void showPrefsDialog()
            {
                GuiCanvas Canvas = "Canvas";
                GuiControl GuiEditorPrefsDlg = "GuiEditorPrefsDlg";

                Canvas.pushDialog(GuiEditorPrefsDlg);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public GuiEditorUndo.GuiEditorUndoManager getUndoManager()
            {
                GuiEditorUndo.GuiEditorUndoManager GuiEditorUndoManager = "GuiEditorUndoManager";
                if (!GuiEditorUndoManager.isObject())
                    new ObjectCreator("UndoManager", "GuiEditorUndoManager", typeof (GuiEditorUndo.GuiEditorUndoManager)).Create();

                return GuiEditorUndoManager;
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void undo()
            {
                string action = this.getUndoManager().getNextUndoName();
                GuiEditorStatusBar GuiEditorStatusBar = "GuiEditorStatusBar";

                this.getUndoManager().undo();
                this.updateUndoMenu();
                //this.clearSelection();

                GuiEditorStatusBar.print("Undid '" + action + "'");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void redo()
            {
                GuiEditorStatusBar GuiEditorStatusBar = "GuiEditorStatusBar";

                string action = this.getUndoManager().getNextRedoName();

                this.getUndoManager().redo();
                this.updateUndoMenu();
                //this.clearSelection();

                GuiEditorStatusBar.print("Redid '" + action + "'");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void updateUndoMenu()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                UndoManager uman = this.getUndoManager();
                string nextUndo = uman.getNextUndoName();
                string nextRedo = uman.getNextRedoName();

                MenuBuilder editMenu = GuiEditCanvas.menuBar.FOT("editMenu");

                editMenu.setItemName(0, "Undo " + nextUndo);
                editMenu.setItemName(1, "Redo " + nextRedo);

                editMenu.enableItem(0, (nextUndo != ""));
                editMenu.enableItem(1, (nextRedo != ""));
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public bool isFilteredClass(string className)
            {
                // Filter out all the internal GuiInspector classes.

                if (Util.startsWith(className, "GuiInspector", false) && className != "GuiInspector")
                    return true;

                // Filter out GuiEditor classes.

                if (Util.startsWith(className, "GuiEditor", false))
                    return true;

                // Filter out specific classes.

                switch (className)
                    {
                        case "GuiCanvas":
                            return true;
                        case "GuiAviBitmapCtrl":
                            return true; // For now.  Probably removed altogether.
                        case "GuiArrayCtrl":
                            return true; // Abstract base class really.
                        case "GuiScintillaTextCtrl":
                            return true; // Internal class.
                        case "GuiNoMouseCtrl":
                            return true; // Too odd.
                        case "GuiEditCtrl":
                            return true;
                        case "GuiBackgroundCtrl":
                            return true; // Just plain useless.
                        case "GuiTSCtrl":
                            return true; // Abstract base class.
                        case "GuiTickCtrl":
                            return true; // Abstract base class.
                        case "GuiWindowCollapseCtrl":
                            return true; // Legacy.
                    }

                return false;
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void editProfile(string profile)
            {
                GuiEditorTabBook GuiEditorTabBook = "GuiEditorTabBook";
                GuiTabPageCtrl profilesPage = GuiEditorTabBook.FOT("profilesPage");
                GuiEditorProfiles.GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";

                profilesPage.select();
                GuiEditorProfilesTree.setSelectedProfile(profile);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void createControl(string className)
            {
                SimObject ctrl = Util.eval("return new " + className + "();");
                if (!ctrl.isObject())
                    return;

                // Add the control.

                this.addNewCtrl(ctrl);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            /// Group all GuiControls in the currenct selection set under a new GuiControl.
            public void groupSelected()
            {
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiEditorUndo.GuiEditorGroupAction GuiEditorGroupAction = "GuiEditorGroupAction";

                SimSet selection = this.getSelection();
                if (selection.getCount() < 2)
                    return;

                // Create action.

                GuiEditorUndo.GuiEditorGroupAction action = GuiEditorGroupAction.create(selection, this.getContentControl().AsString());
                action.groupControls();

                // Update editor tree.

                this.clearSelection();
                this.addSelection(((SimObject) action["group[0]"])["groupObject"].AsInt());
                GuiEditorTreeView.update();

                // Update undo state.

                action.addToManager(this.getUndoManager());
                this.updateUndoMenu();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            /// Take all direct GuiControl instances in the selection set and reparent their child controls
            /// to each of the group's parents.  The GuiControl group objects are deleted.
            public void ungroupSelected()
            {
                GuiEditorUndo.GuiEditorUngroupAction GuiEditorUngroupAction = "GuiEditorUngroupAction";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                GuiEditorUndo.GuiEditorUngroupAction action = GuiEditorUngroupAction.create(this.getSelection().AsString(), "");
                action.ungroupControls();

                // Update editor tree.

                this.clearSelection();
                GuiEditorTreeView.update();

                // Update undo state.

                action.addToManager(this.getUndoManager());
                this.updateUndoMenu();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void deleteControl(SimObject ctrl)
            {
                GuiEditorUndo.UndoActionDeleteObject UndoActionDeleteObject = "UndoActionDeleteObject";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                // Unselect.

                this.removeSelection(ctrl);

                // Record undo.

                SimSet set = new ObjectCreator("SimSet").Create();
                set.parentGroup = "RootGroup";

                set.add(ctrl);

                GuiEditorUndo.UndoActionDeleteObject action = UndoActionDeleteObject.create(set, this.getTrash(), GuiEditorTreeView, true);
                action.addToManager(this.getUndoManager());
                this.updateUndoMenu();

                GuiEditorTreeView.update();
                set.delete();

                // Remove.

                ((SimSet) this.getTrash()).add(ctrl);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void setPreviewResolution(int width, int height)
            {
                GuiControl GuiEditorRegion = "GuiEditorRegion";
                GuiControl GuiEditorContent = "GuiEditorContent";

                GuiEditorRegion.resize(0, 0, width, height);
                ((GuiControl) GuiEditorContent.getObject(0)).resize(0, 0, width, height);

                this["previewResolution"] = width.AsString() + ' ' + height.AsString();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleEdgeSnap()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";
                GuiBitmapButtonCtrl GuiEditorEdgeSnapping_btn = "GuiEditorEdgeSnapping_btn";

                this.snapToEdges = !this.snapToEdges;
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_EDGESNAP_INDEX"], this.snapToEdges);
                GuiEditorEdgeSnapping_btn.setStateOn(this.snapToEdges);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleCenterSnap()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";
                GuiBitmapButtonCtrl GuiEditorCenterSnapping_btn = "GuiEditorCenterSnapping_btn";

                this.snapToCenters = !this.snapToCenters;
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_CENTERSNAP_INDEX"], this.snapToCenters);
                GuiEditorCenterSnapping_btn.setStateOn(this.snapToCenters);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleFullBoxSelection()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                this.fullBoxSelection = !this.fullBoxSelection;
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("EditMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_FULLBOXSELECT_INDEX"], this.fullBoxSelection);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleDrawGuides()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                this.drawGuides = !this.drawGuides;
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_DRAWGUIDES_INDEX"], this.drawGuides);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleGuideSnap()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                this.snapToGuides = !this["snapToGuides"].AsBool();
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_GUIDESNAP_INDEX"], this.snapToGuides);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleControlSnap()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                this.snapToControls = !this.snapToControls;
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_CONTROLSNAP_INDEX"], this.snapToControls);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleCanvasSnap()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";

                this.snapToCanvas = !this.snapToCanvas;
                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_CANVASSNAP_INDEX"], this.snapToCanvas);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleGridSnap()
            {
                GuiEditCanvas GuiEditCanvas = "GuiEditCanvas";
                GuiEditorSnapCheckBox GuiEditorSnapCheckBox = "GuiEditorSnapCheckBox";

                this.snap2Grid = !this.snap2Grid;
                if (!this.snap2Grid)
                    this.setSnapToGrid(0);
                else
                    this.setSnapToGrid(this["snap2GridSize"].AsUint());

                ((MenuBuilder) GuiEditCanvas.menuBar.FOF("SnapMenu")).checkItem(iGlobal["$GUI_EDITOR_MENU_GRIDSNAP_INDEX"], this.snap2Grid);
                GuiEditorSnapCheckBox.setStateOn(this.snap2Grid);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleLockSelection()
            {
                this.toggleFlagInAllSelectedObjects("locked");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleHideSelection()
            {
                this.toggleFlagInAllSelectedObjects("hidden");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void selectAllControlsInSet(SimSet set, bool deselect)
            {
                if (!set.isObject())
                    return;

                for (uint i = 0; i < set.getCount(); i++)
                    {
                    SimObject obj = set.getObject(i);
                    if (!obj.isMemberOfClass("GuiControl"))
                        continue;

                    if (!deselect)
                        this.addSelection(obj);
                    else
                        this.removeSelection(obj);
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void toggleFlagInAllSelectedObjects(string flagFieldName)
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";

                // Use the inspector's code here to record undo information
                // for the field edits.

                GuiEditorInspectFields.onInspectorPreFieldModification(flagFieldName, "-1");

                SimSet selected = this.getSelection();
                for (uint i = 0; i <= selected.getCount(); i++)
                    {
                    SimObject obj = selected.getObject(i);
                    obj.setFieldValue(flagFieldName, (!(obj.getFieldValue(flagFieldName, -1)).AsBool()).AsString(), -1);
                    }
                GuiEditorInspectFields.onInspectorPostFieldModification();
                GuiEditorInspectFields.refresh();
            }

            //=============================================================================================
            //    Event Handlers.
            //=============================================================================================

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onDelete()
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                GuiEditorTreeView.update();
                // clear out the gui inspector.
                GuiEditorInspectFields.update("0");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onSelectionMoved(GuiControl control)
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";

                GuiEditorInspectFields.update(control);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onSelectionResized(GuiControl control)
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";

                GuiEditorInspectFields.update(control);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onSelect(GuiControl ctrl)
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiTextCtrl GuiEditorSelectionStatus = "GuiEditorSelectionStatus";

                if (!this.dontSyncTreeViewSelection)
                    {
                    GuiEditorTreeView.clearSelection();
                    GuiEditorTreeView.addSelection(ctrl, false);
                    }

                GuiEditorInspectFields.update(ctrl);

                GuiEditorSelectionStatus.setText("1 Control Selected");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onAddSelected(GuiControl ctrl)
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiTextCtrl GuiEditorSelectionStatus = "GuiEditorSelectionStatus";

                if (!this.dontSyncTreeViewSelection)
                    {
                    GuiEditorTreeView.addSelection(ctrl, false);
                    GuiEditorTreeView.scrollVisibleByObjectId(ctrl);
                    }

                GuiEditorSelectionStatus.setText(this.getNumSelected() + " Controls Selected");

                // Add to inspection set.

                GuiEditorInspectFields.addInspect(ctrl);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onRemoveSelected(GuiControl ctrl)
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiTextCtrl GuiEditorSelectionStatus = "GuiEditorSelectionStatus";

                if (!this.dontSyncTreeViewSelection)
                    GuiEditorTreeView.removeSelection(ctrl);

                GuiEditorSelectionStatus.setText(this.getNumSelected() + " Controls Selected");

                // Remove from inspection set.

                GuiEditorInspectFields.removeInspect(ctrl);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onClearSelected()
            {
                GuiEditorInspectFields GuiEditorInspectFields = "GuiEditorInspectFields";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiTextCtrl GuiEditorSelectionStatus = "GuiEditorSelectionStatus";

                if (!this.dontSyncTreeViewSelection)
                    GuiEditorTreeView.clearSelection();

                GuiEditorInspectFields.update("0");
                GuiEditorSelectionStatus.setText("");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onControlDragged(GuiControl payload, string position)
            {
                GuiControl GuiEditorContent = "GuiEditorContent";

                // Make sure we have the right kind of D&D.

                if (!payload.parentGroup.isInNamespaceHierarchy("GuiDragAndDropControlType_GuiControl"))
                    return;

                // use the position under the mouse cursor, not the payload position.
                position = Util.VectorSub(position.AsPoint3F(), (GuiEditorContent.getGlobalPosition().AsString() + ' ' + "0").AsPoint3F()).AsString();
                int x = Util.getWord(position, 0).AsInt();
                int y = Util.getWord(position, 1).AsInt();
                GuiControl target = ((GuiControl) this.getContentControl()).findHitControl(x, y);

                // Make sure the target is a valid parent for our payload.

                while ((!target.isContainer || !target.acceptsAsChild(payload)) && target != this.getContentControl())
                    target = target.getParent();

                if (target != this.getCurrentAddSet())
                    this.setCurrentAddSet(target);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onControlDropped(GuiControl payload, string position)
            {
                // Make sure we have the right kind of D&D.

                if (!payload.parentGroup.isInNamespaceHierarchy("GuiDragAndDropControlType_GuiControl"))
                    return;

                string pos = payload.getGlobalPosition().AsString();
                int x = Util.getWord(pos, 0).AsInt();
                int y = Util.getWord(pos, 1).AsInt();

                this.addNewCtrl(payload);

                payload.setPositionGlobal(x, y);
                this.setFirstResponderX();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onGainFirstResponder(string ID)
            {
                this.enableMenuItems(true);

                // JCF: don't just turn them all on!
                // Undo/Redo is only enabled if those actions exist.
                this.updateUndoMenu();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onLoseFirstResponder(string ID)
            {
                this.enableMenuItems(false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onHierarchyChanged()
            {
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                GuiEditorTreeView.update();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onMouseModeChange()
            {
                GuiEditorStatusBar GuiEditorStatusBar = "GuiEditorStatusBar";

                GuiEditorStatusBar.setText(GuiEditorStatusBar.getMouseModeHelp());
            }

            [ConsoleInteraction]
            public void createNewProfile(string name, string copySource)
            {
                if (name == "")
                    return;

                // Make sure the object name is unique.

                if (name.isObject())
                    name = Util.getUniqueName(name);

                // Create the profile.

                if (copySource != "")
                    Util.eval("new GuiControlProfile( " + name + " : " + copySource.getName() + " );");
                else
                    Util.eval("new GuiControlProfile( " + name + " );");

                // Add the item and select it.

                string category = this.getProfileCategory(name);

                GuiEditorProfiles.GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";

                SimSet group = GuiEditorProfilesTree.findChildItemByName(0, category);

                int id = GuiEditorProfilesTree.insertItem(group, name + " (" + name.getID() + ")", name.getID().AsString(), "", 1, 1);

                GuiEditorProfilesTree.sort(0, true, true, false);
                GuiEditorProfilesTree.clearSelection();
                GuiEditorProfilesTree.selectItem(id);

                // Mark it as needing to be saved.

                this.setProfileDirty(name, true, false);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public string getProfileCategory(SimObject profile)
            {
                if (this.isDefaultProfile(name))
                    return "Default";
                else if (profile["category"] != "")
                    return profile["category"];
                else
                    return sGlobal["$GUI_EDITOR_DEFAULT_PROFILE_CATEGORY"];
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void showDeleteProfileDialog(string profile)
            {
                if (profile == "")
                    return;

                if (profile.call("isInUse").AsBool())
                    {
                    messageBox.MessageBoxOK("Error", "The profile '" + profile.getName() + "' is still used by Gui controls.");
                    return;
                    }

                messageBox.MessageBoxYesNo("Delete Profile?", "Do you really want to delete '" + profile.getName() + "'?", "GuiEditor.deleteProfile( " + profile + " );");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void deleteProfile(string profile)
            {
                GuiEditorProfiles.GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";
                ProfilePane ProfilePane = "ProfilePane";

                if ("GuiEditorProfilesPM".isObject())
                    new ObjectCreator("PersistenceManager", "GuiEditorProfilesPM").Create();

                // Clear dirty state.

                this.setProfileDirty(profile, false, false);

                // Remove from tree.

                int id = GuiEditorProfilesTree.findItemByValue(profile.getID().AsString());
                GuiEditorProfilesTree.removeItem(id);

                // Remove from file.

                PersistenceManager GuiEditorProfilesPM = "GuiEditorProfilesPM";
                GuiEditorProfilesPM.removeObjectFromFile(profile);

                // Delete profile object.

                profile.delete();

                ProfilePane.onProfileDeleted();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void showSaveProfileDialog(string currentFileName)
            {
                SaveFileDialog.getSaveFilename("TorqueScript Files|*.cs", this + ".doSaveProfile", currentFileName);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void doSaveProfile(string fileName)
            {
                GuiTextEditCtrl GuiEditorProfileFileName = "GuiEditorProfileFileName";
                GuiEditorProfiles.GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";

                string path = Util.makeRelativePath(fileName, Util.getMainDotCsDir());

                GuiEditorProfileFileName.setText(path);
                this.saveProfile(GuiEditorProfilesTree.getSelectedProfile(), path);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void saveProfile(SimObject profile, string fileName)
            {
                PersistenceManager GuiEditorProfilesPM = "GuiEditorProfilesPM";

                if (!GuiEditorProfilesPM.isObject())
                    GuiEditorProfilesPM = new ObjectCreator("PersistenceManager", "GuiEditorProfilesPM").Create();

                if (!GuiEditorProfilesPM.isDirty(profile) && (fileName == "" || fileName == profile.getFilename()))
                    return;

                // Update the filename, if requested.

                if (fileName != "")
                    {
                    profile.setFilename(fileName);
                    GuiEditorProfilesPM.setDirty(profile, fileName);
                    }

                // Save the object.

                GuiEditorProfilesPM.saveDirtyObject(profile);

                // Clear its dirty state.

                this.setProfileDirty(profile, false, true);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void revertProfile(string profile)
            {
                GuiEditorProfiles.GuiEditorProfileChangeManager GuiEditorProfileChangeManager = "GuiEditorProfileChangeManager";
                GuiEditorProfiles.GuiEditorProfileInspector GuiEditorProfileInspector = "GuiEditorProfileInspector";
                ProfilePane ProfilePane = "ProfilePane";

                // Revert changes.

                GuiEditorProfileChangeManager.revertEdits(profile);

                ProfilePane.onProfileReverted(profile);

                // Clear its dirty state.

                this.setProfileDirty(profile, false, false);

                // Refresh inspector.

                if (GuiEditorProfileInspector.getInspectObject() == profile)
                    GuiEditorProfileInspector.refresh();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public bool isProfileDirty(string profile)
            {
                PersistenceManager GuiEditorProfilesPM = "GuiEditorProfilesPM";

                if (!GuiEditorProfilesPM.isObject())
                    return false;

                return GuiEditorProfilesPM.isDirty(profile);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void setProfileDirty(SimObject profile, bool value, bool noCheck)
            {
                PersistenceManager GuiEditorProfilesPM = "GuiEditorProfilesPM";
                GuiEditorProfiles.GuiEditorProfilesTree GuiEditorProfilesTree = "GuiEditorProfilesTree";
                GuiEditorProfiles.GuiEditorProfileChangeManager GuiEditorProfileChangeManager = "GuiEditorProfileChangeManager";

                if (!GuiEditorProfilesPM.isObject())
                    GuiEditorProfilesPM = new ObjectCreator("PersistenceManager", "GuiEditorProfilesPM").Create();

                if (value)
                    {
                    if (!GuiEditorProfilesPM.isDirty(profile) || noCheck)
                        {
                        // If the profile hasn't yet been associated with a file,
                        // put it in the default file.

                        if (profile.getFilename() == "")
                            profile.setFilename(sGlobal["$GUI_EDITOR_DEFAULT_PROFILE_FILENAME"]);

                        // Add the profile to the dirty set.

                        GuiEditorProfilesPM.setDirty(profile);

                        // Show the item as dirty in the tree.

                        int id = GuiEditorProfilesTree.findItemByValue(profile.getId().AsString());
                        GuiEditorProfilesTree.editItem(id, GuiEditorProfilesTree.getItemText(id) + ' ' + "*", profile.getId().AsString());

                        // Count the number of unsaved profiles.  If this is
                        // the first one, indicate in the window title that
                        // we have unsaved profiles.

                        this.increaseNumDirtyProfiles();
                        }
                    }
                else
                    {
                    if (GuiEditorProfilesPM.isDirty(profile) || noCheck)
                        {
                        // Remove from dirty list.

                        GuiEditorProfilesPM.removeDirty(profile);

                        // Clear the dirty marker in the tree.

                        int id = GuiEditorProfilesTree.findItemByValue(profile.getId().AsString());
                        string text = GuiEditorProfilesTree.getItemText(id);
                        GuiEditorProfilesTree.editItem(id, Util.getSubStr(text, 0, Util.strlen(text) - 2), profile.getId().AsString());

                        // Count saved profiles.  If this was the last unsaved profile,
                        // remove the unsaved changes indicator from the window title.

                        this.decreaseNumDirtyProfiles();

                        // Remove saved edits from the change manager.

                        GuiEditorProfileChangeManager.clearEdits(profile);
                        }
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            /// Return true if the given profile name is the default profile for a
            /// GuiControl class or if it's the GuiDefaultProfile.
            public bool isDefaultProfile(string name)
            {
                if (name == "GuiDefaultProfile")
                    return true;

                if (!Util.endsWith(name, "Profile", false))
                    return false;

                string className = Util.getSubStr(name, 0, Util.strlen(name) - 7) + "Ctrl";
                if (!Util.isClass(className))
                    return false;

                return true;
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void increaseNumDirtyProfiles()
            {
                GuiEditorTabBook GuiEditorTabBook = "GuiEditorTabBook";
                GuiTabPageCtrl profilesPage = GuiEditorTabBook.FOT("profilesPage");

                this.numDirtyProfiles ++;
                if (this.numDirtyProfiles == 1)
                    {
                    GuiTabPageCtrl tab = profilesPage;
                    tab.setText(tab.text + " *");
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void decreaseNumDirtyProfiles()
            {
                GuiEditorTabBook GuiEditorTabBook = "GuiEditorTabBook";
                GuiTabPageCtrl profilesPage = GuiEditorTabBook.FOT("profilesPage");

                this.numDirtyProfiles --;
                if (this.numDirtyProfiles <= 0)
                    {
                    GuiTabPageCtrl tab = profilesPage;
                    string title = tab.text;
                    title = Util.getSubStr(title, 0, Util.strlen(title) - 2);

                    tab.setText(title);
                    }
            }

            //-----------------------------------------------------------------------------------------
            // Gui Editor Undo hooks from code

            [ConsoleInteraction]
            public override void onPreEdit(SimSet selection)
            {
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";
                GuiEditorUndo.GenericUndoAction GenericUndoAction = "GenericUndoAction";

                if (this.pendingGenericUndoAction.isObject())
                    {
                    Util._error("Error: attempting to create two generic undo actions at once in the same editor!");
                    return;
                    }

                //echo("pre edit");
                GuiEditorUndo.GenericUndoAction act = GenericUndoAction.create();
                act.watchSet(selection);
                act["tree"] = GuiEditorTreeView;

                this.pendingGenericUndoAction = act;

                this.updateUndoMenu();
            }

            [ConsoleInteraction]
            public override void onPostEdit(SimSet selection)
            {
                if (!this.pendingGenericUndoAction.isObject())
                    Util._error("Error: attempting to complete a GenericUndoAction that hasn't been started!");

                GuiEditorUndo.GenericUndoAction act = this.pendingGenericUndoAction;
                this.pendingGenericUndoAction = "";

                bool diffs = act.learnSet(selection);
                if (diffs)
                    {
                    //echo("adding generic undoaction to undo manager");
                    //%act.dump();
                    act.addToManager(this.getUndoManager());
                    }
                else
                    {
                    //echo("deleting empty generic undoaction");
                    act.delete();
                    }

                this.updateUndoMenu();
            }

            [ConsoleInteraction]
            public override void onPreSelectionNudged(SimSet selection)
            {
                this.onPreEdit(selection);
                this.pendingGenericUndoAction.actionName = "Nudge";
            }

            [ConsoleInteraction]
            public override void onPostSelectionNudged(SimSet selection)
            {
                this.onPostEdit(selection);
            }

            [ConsoleInteraction]
            public override void onAddNewCtrl(GuiControl ctrl)
            {
                GuiEditorUndo.UndoActionAddObject UndoActionAddObject = "UndoActionAddObject";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                SimSet set = new ObjectCreator("SimSet").Create();
                set.add(ctrl);
                GuiEditorUndo.UndoActionAddObject act = UndoActionAddObject.create(set, this.getTrash(), GuiEditorTreeView, false);
                set.delete();
                act.addToManager(this.getUndoManager());
                this.updateUndoMenu();
                //GuiEditorInspectFields.update(0);
            }

            [ConsoleInteraction]
            public override void onAddNewCtrlSet(SimSet set)
            {
                GuiEditorUndo.UndoActionAddObject UndoActionAddObject = "UndoActionAddObject";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                GuiEditorUndo.UndoActionAddObject act = UndoActionAddObject.create(set, this.getTrash(), GuiEditorTreeView, false);
                act.addToManager(this.getUndoManager());
                this.updateUndoMenu();
            }

            [ConsoleInteraction]
            public override void onTrashSelection(SimSet selection)
            {
                GuiEditorUndo.UndoActionDeleteObject UndoActionDeleteObject = "UndoActionDeleteObject";
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                GuiEditorUndo.UndoActionDeleteObject act = UndoActionDeleteObject.create(selection, this.getTrash(), GuiEditorTreeView, false);
                act.addToManager(this.getUndoManager());
                this.updateUndoMenu();
            }

            [ConsoleInteraction]
            public override void onControlInspectPreApply(GuiControl control)
            {
                SimSet set = new ObjectCreator("SimSet").Create();
                set.add(control);
                this.onPreEdit(set);
                this.pendingGenericUndoAction.actionName = "Change Properties";
                set.delete();
            }

            [ConsoleInteraction]
            public override void onControlInspectPostApply(GuiControl control)
            {
                GuiEditorTreeView GuiEditorTreeView = "GuiEditorTreeView";

                SimSet set = new ObjectCreator("SimSet").Create();
                set.add(control);
                this.onPostEdit(set);
                set.delete();
                GuiEditorTreeView.update();
            }

            [ConsoleInteraction]
            public override void onFitIntoParent(bool width, bool height)
            {
                SimObject selected = this.getSelection();
                //TODO
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditor ts, string simobjectid)
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
            public static bool operator !=(GuiEditor ts, string simobjectid)
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
            public static implicit operator string(GuiEditor ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditor(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditor) Omni.self.getSimObject(simobjectid, typeof (GuiEditor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditor ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditor(int simobjectid)
            {
                return (GuiEditor) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditor ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditor(uint simobjectid)
            {
                return (GuiEditor) Omni.self.getSimObject(simobjectid, typeof (GuiEditor));
            }

            #endregion
        }

        //=============================================================================================
        //    Resolution List.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorResList>))]
        public class GuiEditorResList : GuiPopUpMenuCtrl
        {
            [ConsoleInteraction]
            public void init()
            {
                this.clear();

                // Non-widescreen formats.

                this.add("640x480 (VGA, 4:3)", 640);
                this.add("800x600 (SVGA, 4:3)", 800);
                this.add("1024x768 (XGA, 4:3)", 1024);
                this.add("1280x1024 (SXGA, 4:3)", 1280);
                this.add("1600x1200 (UXGA, 4:3)", 1600);

                // Widescreen formats.

                this.add("1280x720 (WXGA, 16:9)", 720);
                this.add("1600x900 (16:9)", 900);
                this.add("1920x1080 (16:9)", 1080);
                this.add("1440x900 (WXGA+, 16:10)", 900);
                this.add("1680x1050 (WSXGA+, 16:10)", 1050);
                this.add("1920x1200 (WUXGA, 16:10)", 1200);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void selectFormat(string format)
            {
                int width = Util.getWord(format, 0).AsInt();
                int height = Util.getWord(format, 1).AsInt();

                switch (height)
                    {
                        case 720:
                            this.setSelected(720);
                            break;

                        case 900:
                            this.setSelected(900);
                            break;

                        case 1050:
                            this.setSelected(1050);
                            break;

                        case 1080:
                            this.setSelected(1080);
                            break;

                        default:

                            switch (width)
                                {
                                    case 640:
                                        this.setSelected(640);
                                        break;

                                    case 800:
                                        this.setSelected(800);
                                        break;

                                    case 1024:
                                        this.setSelected(1024);
                                        break;

                                    case 1280:
                                        this.setSelected(1280);
                                        break;

                                    case 1600:
                                        this.setSelected(1600);
                                        break;

                                    default:
                                        this.setSelected(1200);
                                        break;
                                }
                            break;
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onSelect(string id, string text)
            {
                GuiEditor GuiEditor = "GuiEditor";

                switch (id.AsInt())
                    {
                        case 640:
                            GuiEditor.setPreviewResolution(640, 480);
                            break;

                        case 800:
                            GuiEditor.setPreviewResolution(800, 600);
                            break;

                        case 1024:
                            GuiEditor.setPreviewResolution(1024, 768);
                            break;

                        case 1280:
                            GuiEditor.setPreviewResolution(1280, 1024);
                            break;

                        case 1600:
                            GuiEditor.setPreviewResolution(1600, 1200);
                            break;

                        case 720:
                            GuiEditor.setPreviewResolution(1280, 720);
                            break;

                        case 900:
                            GuiEditor.setPreviewResolution(1440, 900);
                            break;

                        case 1050:
                            GuiEditor.setPreviewResolution(1680, 1050);
                            break;

                        case 1080:
                            GuiEditor.setPreviewResolution(1920, 1080);
                            break;

                        case 1200:
                            GuiEditor.setPreviewResolution(1920, 1200);
                            break;
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorResList ts, string simobjectid)
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
            public static bool operator !=(GuiEditorResList ts, string simobjectid)
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
            public static implicit operator string(GuiEditorResList ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorResList(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorResList) Omni.self.getSimObject(simobjectid, typeof (GuiEditorResList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorResList ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorResList(int simobjectid)
            {
                return (GuiEditorResList) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorResList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorResList ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorResList(uint simobjectid)
            {
                return (GuiEditorResList) Omni.self.getSimObject(simobjectid, typeof (GuiEditorResList));
            }

            #endregion
        }

        //=============================================================================================
        //    Sidebar.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorSnapCheckBox>))]
        public class GuiEditorSnapCheckBox : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiEditor GuiEditor = "GuiEditor";

                float snap = GuiEditor["snap2grid"].AsFloat()*GuiEditor["snap2gridsize"].AsFloat();
                this.setValue(snap.AsString());
                GuiEditor.setSnapToGrid((uint) snap);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onAction()
            {
                GuiEditor GuiEditor = "GuiEditor";

                float snap = GuiEditor["snap2gridsize"].AsFloat()*this.getValue().AsFloat();
                GuiEditor["snap2grid"] = this.getValue();
                GuiEditor.setSnapToGrid((uint) snap);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorSnapCheckBox ts, string simobjectid)
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
            public static bool operator !=(GuiEditorSnapCheckBox ts, string simobjectid)
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
            public static implicit operator string(GuiEditorSnapCheckBox ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorSnapCheckBox(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorSnapCheckBox) Omni.self.getSimObject(simobjectid, typeof (GuiEditorSnapCheckBox));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorSnapCheckBox ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorSnapCheckBox(int simobjectid)
            {
                return (GuiEditorSnapCheckBox) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorSnapCheckBox));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorSnapCheckBox ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorSnapCheckBox(uint simobjectid)
            {
                return (GuiEditorSnapCheckBox) Omni.self.getSimObject(simobjectid, typeof (GuiEditorSnapCheckBox));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorTabBook>))]
        public class GuiEditorTabBook : GuiTabBookCtrl
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                MenuBuilder GuiEditorTabBookLibraryPopup = "GuiEditorTabBookLibraryPopup";

                if (!GuiEditorTabBookLibraryPopup.isObject())
                    {
                    ObjectCreator oc = new ObjectCreator("PopupMenu", "GuiEditorTabBookLibraryPopup", typeof (MenuBuilder));
                    oc["isPopup"] = true;

                    oc["item[0]"] = "Alphabetical View" + '\t' + "" + '\t' + "GuiEditorToolbox.setViewType( \\\"Alphabetical\\\" );";
                    oc["item[1]"] = "Categorized View" + '\t' + "" + '\t' + "GuiEditorToolbox.setViewType( \\\"Categorized\\\" );";

                    oc.Create();
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
            {
                GuiControl sidebar = "GuiEditorSidebar";
                string name = ((SimObject) this.getObject(index)).getInternalName();

                GuiBitmapButtonCtrl button1 = sidebar.FOT("button1");
                GuiBitmapButtonCtrl button2 = sidebar.FOT("button2");
                GuiBitmapButtonCtrl button3 = sidebar.FOT("button3");
                GuiBitmapButtonCtrl button4 = sidebar.FOT("button4");

                switch (name)
                    {
                        case "guiPage":

                            button1.setVisible(false);
                            button2.setVisible(false);
                            button3.setVisible(true);
                            button4.setVisible(true);

                            button4.setBitmap("tools/gui/images/delete");
                            button4.command = "GuiEditor.deleteSelection();";
                            button4.tooltip = "Delete Selected Control(s)";

                            button3.setBitmap("tools/gui/images/visible");
                            button3.command = "GuiEditor.toggleHideSelection();";
                            button3.tooltip = "Hide Selected Control(s)";
                            break;

                        case "profilesPage":

                            button1.setVisible(true);
                            button2.setVisible(true);
                            button3.setVisible(true);
                            button4.setVisible(true);

                            button4.setBitmap("tools/gui/images/delete");
                            button4.command = "GuiEditor.showDeleteProfileDialog( GuiEditorProfilesTree.getSelectedProfile() );";
                            button4.tooltip = "Delete Selected Profile";

                            button3.setBitmap("tools/gui/images/new");
                            button3.command = "GuiEditor.createNewProfile( \"Unnamed\" );";
                            button3.tooltip = "Create New Profile with Default Values";

                            button2.setBitmap("tools/gui/images/copy-btn");
                            button2.command = "GuiEditor.createNewProfile( GuiEditorProfilesTree.getSelectedProfile().getName(), GuiEditorProfilesTree.getSelectedProfile() );";
                            button2.tooltip = "Create New Profile by Copying the Selected Profile";

                            button1.setBitmap("tools/gui/images/reset-icon");
                            button1.command = "GuiEditor.revertProfile( GuiEditorProfilesTree.getSelectedProfile() );";
                            button1.tooltip = "Revert Changes to the Selected Profile";
                            break;

                        case "toolboxPage":

                            //TODO

                            button1.setVisible(false);
                            button2.setVisible(false);
                            button3.setVisible(false);
                            button4.setVisible(false);
                            break;
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onTabRightClick(string text, uint index)
            {
                string name = ((SimObject) this.getObject(index)).getInternalName();

                switch (name)
                    {
                        case "toolboxPage":

                            // Open toolbox popup.
                            MenuBuilder popup = "GuiEditorTabBookLibraryPopup";
                            GuiEditorToolbox GuiEditorToolbox = "GuiEditorToolbox";
                            GuiCanvas Canvas = "Canvas";

                            string currentViewType = GuiEditorToolbox.getViewType();
                            switch (currentViewType)
                                {
                                    case "Alphabetical":
                                        popup.checkRadioItem(0, 1, 0);
                                        break;

                                    case "Categorized":
                                        popup.checkRadioItem(0, 1, 1);
                                        break;
                                }

                            popup.showPopup(Canvas);
                            break;
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorTabBook ts, string simobjectid)
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
            public static bool operator !=(GuiEditorTabBook ts, string simobjectid)
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
            public static implicit operator string(GuiEditorTabBook ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorTabBook(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorTabBook) Omni.self.getSimObject(simobjectid, typeof (GuiEditorTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorTabBook ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorTabBook(int simobjectid)
            {
                return (GuiEditorTabBook) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorTabBook ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorTabBook(uint simobjectid)
            {
                return (GuiEditorTabBook) Omni.self.getSimObject(simobjectid, typeof (GuiEditorTabBook));
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
        public static bool operator ==(GuiEditorGui ts, string simobjectid)
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
        public static bool operator !=(GuiEditorGui ts, string simobjectid)
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
        public static implicit operator string(GuiEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorGui) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorGui(int simobjectid)
        {
            return (GuiEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorGui(uint simobjectid)
        {
            return (GuiEditorGui) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGui));
        }

        #endregion
    }
}