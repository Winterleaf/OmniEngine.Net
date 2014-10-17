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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<RiverEditorGui>))]
    public class RiverEditorGui : GuiRiverEditorCtrl
    {

        internal River river
        {
            get { return this["river"]; }
            set { this["river"] = value; }
        }

        [ConsoleInteraction(true, "RiverEditorGui_initialize")]
        public static void initialize()
        {
            #region GuiRiverEditorCtrl (RiverEditorGui, EditorGuiGroup)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiRiverEditorCtrl", "RiverEditorGui, EditorGuiGroup", typeof (RiverEditorGui));
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "RiverEditorProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "height";
            oc_Newobject21["Position"] = "0 0";
            oc_Newobject21["Extent"] = "800 600";
            oc_Newobject21["MinExtent"] = "8 8";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["Docking"] = "None";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "0";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "0";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["cameraZRot"] = "0";
            oc_Newobject21["forceFOV"] = "0";
            oc_Newobject21["renderMissionArea"] = "0";
            oc_Newobject21["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject21["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject21["allowBorderMove"] = "0";
            oc_Newobject21["borderMovePixelSize"] = "20";
            oc_Newobject21["borderMoveSpeed"] = "0.1";
            oc_Newobject21["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject21["consoleFillColor"] = "0 0 0 0";
            oc_Newobject21["consoleSphereLevel"] = "1";
            oc_Newobject21["consoleCircleSegments"] = "32";
            oc_Newobject21["consoleLineWidth"] = "1";
            oc_Newobject21["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject21["DefaultWidth"] = "10";
            oc_Newobject21["HoverSplineColor"] = "0 255 0 255";
            oc_Newobject21["SelectedSplineColor"] = "255 0 255 255";
            oc_Newobject21["HoverNodeColor"] = "255 255 255 255";

            #region GuiWindowCollapseCtrl (RiverEditorTreeWindow)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCollapseCtrl", "RiverEditorTreeWindow", typeof (RiverEditorTreeWindow));
            oc_Newobject4["AllowPopWindow"] = "1";
            oc_Newobject4["internalName"] = "";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject4["HorizSizing"] = "windowRelative";
            oc_Newobject4["VertSizing"] = "windowRelative";
            oc_Newobject4["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) - 1");
            oc_Newobject4["Extent"] = "210 167";
            oc_Newobject4["MinExtent"] = "210 100";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["resizeWidth"] = "1";
            oc_Newobject4["resizeHeight"] = "1";
            oc_Newobject4["canMove"] = "1";
            oc_Newobject4["canClose"] = "0";
            oc_Newobject4["canMinimize"] = "0";
            oc_Newobject4["canMaximize"] = "0";
            oc_Newobject4["minSize"] = "50 50";
            oc_Newobject4["EdgeSnap"] = "1";
            oc_Newobject4["text"] = "Rivers";

            #region GuiContainer ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiContainer", "");
            oc_Newobject3["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["Position"] = "5 25";
            oc_Newobject3["Extent"] = "200 120";
            oc_Newobject3["Docking"] = "Client";
            oc_Newobject3["Margin"] = "3 1 3 3 ";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["isContainer"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "200 118";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
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
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "true";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";

            #region GuiTreeViewCtrl (RiverTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "RiverTreeView", typeof (RiverTreeView));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "1 1";
            oc_Newobject1["Extent"] = "193 21";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["tabSize"] = "16";
            oc_Newobject1["textOffset"] = "2";
            oc_Newobject1["fullRowSelect"] = "0";
            oc_Newobject1["itemHeight"] = "21";
            oc_Newobject1["destroyTreeOnSleep"] = "1";
            oc_Newobject1["MouseDragging"] = "0";
            oc_Newobject1["MultipleSelections"] = "0";
            oc_Newobject1["DeleteObjectAllowed"] = "1";
            oc_Newobject1["DragToItemAllowed"] = "0";
            oc_Newobject1["showRoot"] = "0";
            oc_Newobject1["internalNamesOnly"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject21["#Newobject4"] = oc_Newobject4;

            #region GuiWindowCollapseCtrl (RiverEditorOptionsWindow)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiWindowCollapseCtrl", "RiverEditorOptionsWindow", typeof (RiverEditorOptionsWindow));
            oc_Newobject20["AllowPopWindow"] = "1";
            oc_Newobject20["internalName"] = "Window";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject20["HorizSizing"] = "windowRelative";
            oc_Newobject20["VertSizing"] = "windowRelative";
            oc_Newobject20["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209          SPC getWord(EditorGuiToolbar.extent, 1) + getWord(RiverEditorTreeWindow.extent, 1) - 2");
            oc_Newobject20["Extent"] = "210 530";
            oc_Newobject20["MinExtent"] = "210 300";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "0";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "0";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["resizeWidth"] = "1";
            oc_Newobject20["resizeHeight"] = "1";
            oc_Newobject20["canMove"] = "1";
            oc_Newobject20["canClose"] = "0";
            oc_Newobject20["canMinimize"] = "0";
            oc_Newobject20["canMaximize"] = "0";
            oc_Newobject20["minSize"] = "50 50";
            oc_Newobject20["EdgeSnap"] = "1";
            oc_Newobject20["text"] = "Properties";

            #region GuiContainer ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiContainer", "");
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "4 24";
            oc_Newobject14["Extent"] = "202 85";
            oc_Newobject14["Docking"] = "Top";
            oc_Newobject14["Margin"] = "3 3 3 3";

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "5 0";
            oc_Newobject5["Extent"] = "86 18";
            oc_Newobject5["text"] = "Node Properties";

            #endregion

            oc_Newobject14["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "7 21";
            oc_Newobject6["Extent"] = "46 18";
            oc_Newobject6["text"] = "Position";

            #endregion

            oc_Newobject14["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["internalName"] = "position";
            oc_Newobject7["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "57 21";
            oc_Newobject7["Extent"] = "141 18";
            oc_Newobject7["text"] = "";
            oc_Newobject7["AltCommand"] = "RiverEditorGui.editNodeDetails();";

            #endregion

            oc_Newobject14["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "7 42";
            oc_Newobject8["Extent"] = "46 18";
            oc_Newobject8["text"] = "Rotation";

            #endregion

            oc_Newobject14["#Newobject8"] = oc_Newobject8;

            #region GuiTextEditCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject9["internalName"] = "rotation";
            oc_Newobject9["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "57 42";
            oc_Newobject9["Extent"] = "141 18";
            oc_Newobject9["text"] = "";
            oc_Newobject9["AltCommand"] = "RiverEditorGui.editNodeDetails();";

            #endregion

            oc_Newobject14["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "7 63";
            oc_Newobject10["Extent"] = "46 18";
            oc_Newobject10["text"] = "Width";

            #endregion

            oc_Newobject14["#Newobject10"] = oc_Newobject10;

            #region GuiTextEditCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject11["internalName"] = "width";
            oc_Newobject11["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "57 63";
            oc_Newobject11["Extent"] = "52 18";
            oc_Newobject11["text"] = "";
            oc_Newobject11["AltCommand"] = "RiverEditorGui.editNodeDetails();";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "110 63";
            oc_Newobject12["Extent"] = "32 18";
            oc_Newobject12["text"] = "Depth";

            #endregion

            oc_Newobject14["#Newobject12"] = oc_Newobject12;

            #region GuiTextEditCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject13["internalName"] = "depth";
            oc_Newobject13["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "146 63";
            oc_Newobject13["Extent"] = "52 18";
            oc_Newobject13["text"] = "";
            oc_Newobject13["AltCommand"] = "RiverEditorGui.editNodeDetails();";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject20["#Newobject14"] = oc_Newobject14;

            #region GuiContainer ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiContainer", "");
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "4 112";
            oc_Newobject16["Extent"] = "202 31";
            oc_Newobject16["Docking"] = "Top";
            oc_Newobject16["Margin"] = "0 0 3 3";

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "5 0";
            oc_Newobject15["Extent"] = "121 18";
            oc_Newobject15["text"] = "River Properties";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject20["#Newobject16"] = oc_Newobject16;

            #region GuiScrollCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject18["HorizSizing"] = "width";
            oc_Newobject18["VertSizing"] = "height";
            oc_Newobject18["Position"] = "4 129";
            oc_Newobject18["Extent"] = "202 357";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Docking"] = "Client";
            oc_Newobject18["Margin"] = "-14 41 3 3";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "0";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "0";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["willFirstRespond"] = "1";
            oc_Newobject18["hScrollBar"] = "alwaysOff";
            oc_Newobject18["vScrollBar"] = "dynamic";
            oc_Newobject18["lockHorizScroll"] = "true";
            oc_Newobject18["lockVertScroll"] = "false";
            oc_Newobject18["constantThumbHeight"] = "0";
            oc_Newobject18["childMargin"] = "0 0";

            #region GuiInspector (RiverInspector)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiInspector", "RiverInspector", typeof (RiverInspector));
            oc_Newobject17["StackingType"] = "Vertical";
            oc_Newobject17["HorizStacking"] = "Left to Right";
            oc_Newobject17["VertStacking"] = "Top to Bottom";
            oc_Newobject17["Padding"] = "1";
            oc_Newobject17["name"] = "RiverInspector";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "height";
            oc_Newobject17["Position"] = "1 1";
            oc_Newobject17["Extent"] = "178 16";
            oc_Newobject17["MinExtent"] = "16 16";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["dividerMargin"] = "5";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject20["#Newobject18"] = oc_Newobject18;

            #region GuiMLTextCtrl (RiverFieldInfoControl)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiMLTextCtrl", "RiverFieldInfoControl");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "top";
            oc_Newobject19["Position"] = "1 485";
            oc_Newobject19["Extent"] = "202 42";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["lineSpacing"] = "2";
            oc_Newobject19["allowColorChars"] = "0";
            oc_Newobject19["maxChars"] = "-1";
            oc_Newobject19["useURLMouseCursor"] = "0";

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject21.Create();

            omni.bGlobal["$River::EditorOpen"] = false;
            omni.bGlobal["$River::wireframe"] = true;
            omni.bGlobal["$River::showSpline"] = true;
            omni.bGlobal["$River::showRiver"] = true;
            omni.bGlobal["$River::showWalls"] = true;
        }

        [ConsoleInteraction]
        public void onEditorActivated()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";
            int count = EWorldEditor.getSelectionSize();
            for (uint i = 0; i < count; i++)
                {
                SimObject obj = EWorldEditor.getSelectedObject((int) i);
                if (obj.getClassName() != "River")
                    EWorldEditor.unselectObject(obj);
                else
                    this.setSelectedRiver(obj);
                }

            this.onRiverSelected(this.getSelectedRiver().AsString());
            this.onNodeSelected("-1");
        }

        [ConsoleInteraction]
        public void onEditorDeactivated()
        {
        }

        [ConsoleInteraction]
        public override string createRiver()
        {
            ObjectCreator riverCreator = new ObjectCreator("River");
            riverCreator["rippleDir[0]"] = "0.000000 1.000000";
            riverCreator["rippleDir[1]"] = "0.707000 0.707000";
            riverCreator["rippleDir[2]"] = "0.500000 0.860000";

            riverCreator["rippleSpeed[0]"] = "-0.065";
            riverCreator["rippleSpeed[1]"] = "0.09";
            riverCreator["rippleSpeed[2]"] = "0.04";

            riverCreator["rippleTexScale[0]"] = "7.140000 7.140000";
            riverCreator["rippleTexScale[1]"] = "6.250000 12.500000";
            riverCreator["rippleTexScale[2]"] = "50.000000 50.000000";

            riverCreator["waveDir[0]"] = "0.000000 1.000000";
            riverCreator["waveDir[1]"] = "0.707000 0.707000";
            riverCreator["waveDir[2]"] = "0.500000 0.860000";

            riverCreator["waveSpeed[0]"] = "1";
            riverCreator["waveSpeed[1]"] = "1";
            riverCreator["waveSpeed[2]"] = "1";

            riverCreator["waveMagnitude[0]"] = "0.2";
            riverCreator["waveMagnitude[1]"] = "0.2";
            riverCreator["waveMagnitude[2]"] = "0.2";

            riverCreator["baseColor"] = "45 108 171 255";

            riverCreator["rippleTex"] = "art/water/ripple.dds";
            riverCreator["foamTex"] = "art/water/foam";
            riverCreator["depthGradientTex"] = "art/water/depthcolor_ramp";

            River river = riverCreator.Create();

            return river.ToString();
        }

        [ConsoleInteraction]
        public override void paletteSync(string mode)
        {
            ((GuiButtonBaseCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName(mode, true)).setStateOn(true);
        }

        [ConsoleInteraction]
        public bool onEscapePressed()
        {
            if (this.getMode() == "RiverEditorAddNodeMode")
                {
                this.prepSelectionMode();
                return true;
                }
            return false;
        }

        [ConsoleInteraction]
        public override void onRiverSelected(string river)
        {
            GuiInspector RiverInspector = "RiverInspector";
            GuiTreeViewCtrl RiverTreeView = "RiverTreeView";

            this.river = river;

            if (!river.isObject())
                return;

            RiverInspector.inspect(river);
            RiverTreeView.buildVisibleTree(true);
            if (RiverTreeView.getSelectedObject() != river.AsInt())
                {
                RiverTreeView.clearSelection();
                int treeId = RiverTreeView.findItemByObjectId(river.getID());
                RiverTreeView.selectItem(treeId);
                }
        }

        [ConsoleInteraction]
        public override void onNodeSelected(string nodeIdx)
        {
            GuiWindowCollapseCtrl RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("position", true);
            GuiTextEditCtrl rotationTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("rotation", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("width", true);
            GuiTextEditCtrl depthTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("depth", true);

            if (nodeIdx == "-1")
                {
                positionTextEditCtrl.setActive(false);
                positionTextEditCtrl.setValue("");

                rotationTextEditCtrl.setActive(false);
                rotationTextEditCtrl.setValue("");

                widthTextEditCtrl.setActive(false);
                widthTextEditCtrl.setValue("");

                depthTextEditCtrl.setActive(false);
                depthTextEditCtrl.setValue("");
                }
            else
                {
                positionTextEditCtrl.setActive(true);
                positionTextEditCtrl.setValue(this.getNodePosition().AsString());

                rotationTextEditCtrl.setActive(true);
                rotationTextEditCtrl.setValue(this.getNodeNormal().AsString());

                widthTextEditCtrl.setActive(true);
                widthTextEditCtrl.setValue(this.getNodeWidth().AsString());

                depthTextEditCtrl.setActive(true);
                depthTextEditCtrl.setValue(this.getNodeDepth().AsString());
                }
        }

        [ConsoleInteraction]
        public override void onNodeModified(string nodeIdx)
        {
            GuiWindowCollapseCtrl RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("position", true);
            GuiTextEditCtrl rotationTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("rotation", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("width", true);
            GuiTextEditCtrl depthTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("depth", true);

            positionTextEditCtrl.setValue(this.getNodePosition().AsString());
            rotationTextEditCtrl.setValue(this.getNodeNormal().AsString());
            widthTextEditCtrl.setValue(this.getNodeWidth().AsString());
            depthTextEditCtrl.setValue(this.getNodeDepth().AsString());
        }

        [ConsoleInteraction]
        public void editNodeDetails()
        {
            GuiWindowCollapseCtrl RiverEditorOptionsWindow = "RiverEditorOptionsWindow";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("position", true);
            GuiTextEditCtrl rotationTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("rotation", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("width", true);
            GuiTextEditCtrl depthTextEditCtrl = (GuiTextEditCtrl) RiverEditorOptionsWindow.findObjectByInternalName("depth", true);

            this.setNodePosition(new Point3F(positionTextEditCtrl.getText()));
            this.setNodeNormal(new Point3F(rotationTextEditCtrl.getText()));
            this.setNodeWidth(widthTextEditCtrl.getText().AsFloat());
            this.setNodeDepth(depthTextEditCtrl.getText().AsFloat());
        }

        [ConsoleInteraction]
        public void prepSelectionMode()
        {
            string mode = this.getMode();

            if (mode == "RiverEditorAddNodeMode")
                {
                if (this.getSelectedRiver() != 0)
                    this.deleteNode();
                }

            this.setMode("RiverEditorSelectMode");
            ((GuiBitmapButtonCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName("RiverEditorSelectMode", true)).setStateOn(true);
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorAddModeBtn>))]
        public class ERiverEditorAddModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorAddModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorAddModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorAddModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorAddModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorAddModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorAddModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorAddModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorAddModeBtn(int simobjectid)
            {
                return (ERiverEditorAddModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorAddModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorAddModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorAddModeBtn(uint simobjectid)
            {
                return (ERiverEditorAddModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorAddModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorInsertModeBtn>))]
        public class ERiverEditorInsertModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorInsertModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorInsertModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorInsertModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorInsertModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorInsertModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorInsertModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorInsertModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorInsertModeBtn(int simobjectid)
            {
                return (ERiverEditorInsertModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorInsertModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorInsertModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorInsertModeBtn(uint simobjectid)
            {
                return (ERiverEditorInsertModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorInsertModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorMoveModeBtn>))]
        public class ERiverEditorMoveModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorMoveModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorMoveModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorMoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorMoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorMoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorMoveModeBtn(int simobjectid)
            {
                return (ERiverEditorMoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorMoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorMoveModeBtn(uint simobjectid)
            {
                return (ERiverEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorMoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorRemoveModeBtn>))]
        public class ERiverEditorRemoveModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorRemoveModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorRemoveModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorRemoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorRemoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorRemoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorRemoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorRemoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorRemoveModeBtn(int simobjectid)
            {
                return (ERiverEditorRemoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorRemoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorRemoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorRemoveModeBtn(uint simobjectid)
            {
                return (ERiverEditorRemoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorRemoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorRotateModeBtn>))]
        public class ERiverEditorRotateModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorRotateModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorRotateModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorRotateModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorRotateModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorRotateModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorRotateModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorRotateModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorRotateModeBtn(int simobjectid)
            {
                return (ERiverEditorRotateModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorRotateModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorRotateModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorRotateModeBtn(uint simobjectid)
            {
                return (ERiverEditorRotateModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorRotateModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorScaleModeBtn>))]
        public class ERiverEditorScaleModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorScaleModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorScaleModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorScaleModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorScaleModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorScaleModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorScaleModeBtn(int simobjectid)
            {
                return (ERiverEditorScaleModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorScaleModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorScaleModeBtn(uint simobjectid)
            {
                return (ERiverEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorScaleModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERiverEditorSelectModeBtn>))]
        public class ERiverEditorSelectModeBtn : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                ((EditorGui.EditorGuiStatusBar) "EditorGuiStatusBar").setInfo(this["ToolTip"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ERiverEditorSelectModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERiverEditorSelectModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERiverEditorSelectModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorSelectModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERiverEditorSelectModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorSelectModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERiverEditorSelectModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERiverEditorSelectModeBtn(int simobjectid)
            {
                return (ERiverEditorSelectModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERiverEditorSelectModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERiverEditorSelectModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERiverEditorSelectModeBtn(uint simobjectid)
            {
                return (ERiverEditorSelectModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERiverEditorSelectModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RiverDefaultDepthSliderCtrlContainer>))]
        public class RiverDefaultDepthSliderCtrlContainer : EditorGui.EditorDropdownSliderContainer
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                ((GuiSliderCtrl) (this).findObjectByInternalName("slider", true)).setValue(((GuiTextEditCtrl) ((GuiControl) "RiverDefaultDepthTextEditContainer").findObjectByInternalName("textEdit", true)).getText());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RiverDefaultDepthSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(RiverDefaultDepthSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(RiverDefaultDepthSliderCtrlContainer ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RiverDefaultDepthSliderCtrlContainer(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RiverDefaultDepthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (RiverDefaultDepthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RiverDefaultDepthSliderCtrlContainer ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RiverDefaultDepthSliderCtrlContainer(int simobjectid)
            {
                return (RiverDefaultDepthSliderCtrlContainer) Omni.self.getSimObject((uint) simobjectid, typeof (RiverDefaultDepthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RiverDefaultDepthSliderCtrlContainer ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RiverDefaultDepthSliderCtrlContainer(uint simobjectid)
            {
                return (RiverDefaultDepthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (RiverDefaultDepthSliderCtrlContainer));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RiverDefaultWidthSliderCtrlContainer>))]
        public class RiverDefaultWidthSliderCtrlContainer : EditorGui.EditorDropdownSliderContainer
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                ((GuiSliderCtrl) (this).findObjectByInternalName("slider", true)).setValue(((GuiTextEditCtrl) ((GuiControl) "RiverDefaultWidthTextEditContainer").findObjectByInternalName("textEdit", true)).getText());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RiverDefaultWidthSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(RiverDefaultWidthSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(RiverDefaultWidthSliderCtrlContainer ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RiverDefaultWidthSliderCtrlContainer(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RiverDefaultWidthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (RiverDefaultWidthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RiverDefaultWidthSliderCtrlContainer ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RiverDefaultWidthSliderCtrlContainer(int simobjectid)
            {
                return (RiverDefaultWidthSliderCtrlContainer) Omni.self.getSimObject((uint) simobjectid, typeof (RiverDefaultWidthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RiverDefaultWidthSliderCtrlContainer ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RiverDefaultWidthSliderCtrlContainer(uint simobjectid)
            {
                return (RiverDefaultWidthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (RiverDefaultWidthSliderCtrlContainer));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RiverEditorOptionsWindow>))]
        public class RiverEditorOptionsWindow : GuiWindowCollapseCtrl
        {
            public override void onPopWindow()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RiverEditorPlugin").onActivated();
            }

            public override void onPopWindowClosed()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RiverEditorPlugin").onActivated();
                this.attachTo("RiverEditorTreeWindow");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RiverEditorOptionsWindow ts, string simobjectid)
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
            public static bool operator !=(RiverEditorOptionsWindow ts, string simobjectid)
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
            public static implicit operator string(RiverEditorOptionsWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RiverEditorOptionsWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RiverEditorOptionsWindow) Omni.self.getSimObject(simobjectid, typeof (RiverEditorOptionsWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RiverEditorOptionsWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RiverEditorOptionsWindow(int simobjectid)
            {
                return (RiverEditorOptionsWindow) Omni.self.getSimObject((uint) simobjectid, typeof (RiverEditorOptionsWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RiverEditorOptionsWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RiverEditorOptionsWindow(uint simobjectid)
            {
                return (RiverEditorOptionsWindow) Omni.self.getSimObject(simobjectid, typeof (RiverEditorOptionsWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RiverEditorTreeWindow>))]
        public class RiverEditorTreeWindow : GuiWindowCollapseCtrl
        {
            public override void onPopWindow()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RiverEditorPlugin").onActivated();
            }

            public override void onPopWindowClosed()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RiverEditorPlugin").onActivated();
                this.attachTo("RiverEditorOptionsWindow");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RiverEditorTreeWindow ts, string simobjectid)
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
            public static bool operator !=(RiverEditorTreeWindow ts, string simobjectid)
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
            public static implicit operator string(RiverEditorTreeWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RiverEditorTreeWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RiverEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (RiverEditorTreeWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RiverEditorTreeWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RiverEditorTreeWindow(int simobjectid)
            {
                return (RiverEditorTreeWindow) Omni.self.getSimObject((uint) simobjectid, typeof (RiverEditorTreeWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RiverEditorTreeWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RiverEditorTreeWindow(uint simobjectid)
            {
                return (RiverEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (RiverEditorTreeWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RiverInspector>))]
        public class RiverInspector : GuiInspector
        {
            [ConsoleInteraction]
            public void inspect(SimObject obj)
            {
                string name = "";
                if (obj.isObject())
                    name = obj.getName();
                else
                    ((GuiMLTextCtrl) "RiverFieldInfoControl").setText("");

                //RiverInspectorNameEdit.setValue( %name );
                base.inspect(obj);
            }

            [ConsoleInteraction]
            public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
            {
                // Same work to do as for the regular WorldEditor Inspector.
                ((Inspector) "Inspector").onInspectorFieldModified(objectx, fieldName, arrayIndex, oldValue, newValue);
            }

            [ConsoleInteraction]
            public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
            {
                ((GuiMLTextCtrl) "RiverFieldInfoControl").setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") \n <font:Arial:14>" + fieldDoc);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RiverInspector ts, string simobjectid)
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
            public static bool operator !=(RiverInspector ts, string simobjectid)
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
            public static implicit operator string(RiverInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RiverInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RiverInspector) Omni.self.getSimObject(simobjectid, typeof (RiverInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RiverInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RiverInspector(int simobjectid)
            {
                return (RiverInspector) Omni.self.getSimObject((uint) simobjectid, typeof (RiverInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RiverInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RiverInspector(uint simobjectid)
            {
                return (RiverInspector) Omni.self.getSimObject(simobjectid, typeof (RiverInspector));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RiverTreeView>))]
        public class RiverTreeView : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onInspect(int itemOrObjectId)
            {
                ((RiverInspector) "RiverInspector").inspect(itemOrObjectId);
            }

            [ConsoleInteraction]
            public override void onSelect(string x, string y)
            {
                GuiRiverEditorCtrl RiverEditorGui = "RiverEditorGui";
                RiverInspector RiverInspector = "RiverInspector";

                RiverEditorGui["river"] = x;
                RiverInspector.inspect(x);
                if (x.AsInt() != RiverEditorGui.getSelectedRiver())
                    RiverEditorGui.setSelectedRiver(x);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RiverTreeView ts, string simobjectid)
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
            public static bool operator !=(RiverTreeView ts, string simobjectid)
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
            public static implicit operator string(RiverTreeView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RiverTreeView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RiverTreeView) Omni.self.getSimObject(simobjectid, typeof (RiverTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RiverTreeView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RiverTreeView(int simobjectid)
            {
                return (RiverTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (RiverTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RiverTreeView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RiverTreeView(uint simobjectid)
            {
                return (RiverTreeView) Omni.self.getSimObject(simobjectid, typeof (RiverTreeView));
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
        public static bool operator ==(RiverEditorGui ts, string simobjectid)
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
        public static bool operator !=(RiverEditorGui ts, string simobjectid)
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
        public static implicit operator string(RiverEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator RiverEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (RiverEditorGui) Omni.self.getSimObject(simobjectid, typeof (RiverEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RiverEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RiverEditorGui(int simobjectid)
        {
            return (RiverEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (RiverEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RiverEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RiverEditorGui(uint simobjectid)
        {
            return (RiverEditorGui) Omni.self.getSimObject(simobjectid, typeof (RiverEditorGui));
        }

        #endregion
    }
}