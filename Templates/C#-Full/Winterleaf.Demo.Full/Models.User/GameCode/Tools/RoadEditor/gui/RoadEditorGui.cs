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
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<RoadEditorGui>))]
    public class RoadEditorGui : GuiRoadEditorCtrl
    {

        [ConsoleInteraction(true, "RoadEditorGui_initialize")]
        public static void initialize()
        {
            #region GuiRoadEditorCtrl (RoadEditorGui)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiRoadEditorCtrl", "RoadEditorGui", typeof (RoadEditorGui));
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "RoadEditorProfile";
            oc_Newobject18["HorizSizing"] = "width";
            oc_Newobject18["VertSizing"] = "height";
            oc_Newobject18["Position"] = "0 0";
            oc_Newobject18["Extent"] = "800 600";
            oc_Newobject18["MinExtent"] = "8 8";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["isDecoy"] = "0";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Docking"] = "None";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "0";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "0";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["cameraZRot"] = "0";
            oc_Newobject18["forceFOV"] = "0";
            oc_Newobject18["renderMissionArea"] = "0";
            oc_Newobject18["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject18["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject18["allowBorderMove"] = "0";
            oc_Newobject18["borderMovePixelSize"] = "20";
            oc_Newobject18["borderMoveSpeed"] = "0.1";
            oc_Newobject18["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject18["consoleFillColor"] = "0 0 0 0";
            oc_Newobject18["consoleSphereLevel"] = "1";
            oc_Newobject18["consoleCircleSegments"] = "32";
            oc_Newobject18["consoleLineWidth"] = "1";
            oc_Newobject18["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject18["DefaultWidth"] = "10";
            oc_Newobject18["HoverSplineColor"] = "0 255 0 255";
            oc_Newobject18["SelectedSplineColor"] = "255 0 255 255";
            oc_Newobject18["HoverNodeColor"] = "255 255 255 255";

            #region GuiWindowCollapseCtrl (RoadEditorTreeWindow)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCollapseCtrl", "RoadEditorTreeWindow", typeof (RoadEditorTreeWindow));
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
            oc_Newobject4["text"] = "Roads & Paths";

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

            #region GuiTreeViewCtrl (RoadTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "RoadTreeView", typeof (RoadTreeView));
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

            oc_Newobject18["#Newobject4"] = oc_Newobject4;

            #region GuiWindowCollapseCtrl (RoadEditorOptionsWindow)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiWindowCollapseCtrl", "RoadEditorOptionsWindow", typeof (RoadEditorOptionsWindow));
            oc_Newobject17["AllowPopWindow"] = "1";
            oc_Newobject17["internalName"] = "Window";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject17["HorizSizing"] = "windowRelative";
            oc_Newobject17["VertSizing"] = "windowRelative";
            oc_Newobject17["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC          getWord(EditorGuiToolbar.extent, 1) + getWord(RoadEditorTreeWindow.extent, 1) - 2");
            oc_Newobject17["Extent"] = "210 530";
            oc_Newobject17["MinExtent"] = "210 298";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["resizeWidth"] = "1";
            oc_Newobject17["resizeHeight"] = "1";
            oc_Newobject17["canMove"] = "1";
            oc_Newobject17["canClose"] = "0";
            oc_Newobject17["canMinimize"] = "0";
            oc_Newobject17["canMaximize"] = "0";
            oc_Newobject17["minSize"] = "50 50";
            oc_Newobject17["EdgeSnap"] = "1";
            oc_Newobject17["text"] = "Properties";

            #region GuiContainer (RoadEditorProperties)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiContainer", "RoadEditorProperties");
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "4 24";
            oc_Newobject10["Extent"] = "202 64";
            oc_Newobject10["Docking"] = "Top";
            oc_Newobject10["Margin"] = "3 3 3 3";

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "5 0";
            oc_Newobject5["Extent"] = "86 18";
            oc_Newobject5["text"] = "Node Properties";

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "7 21";
            oc_Newobject6["Extent"] = "46 18";
            oc_Newobject6["text"] = "Position";

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["internalName"] = "position";
            oc_Newobject7["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "57 21";
            oc_Newobject7["Extent"] = "141 18";
            oc_Newobject7["text"] = "";
            oc_Newobject7["AltCommand"] = "RoadEditorGui.editNodeDetails();";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "7 42";
            oc_Newobject8["Extent"] = "46 18";
            oc_Newobject8["text"] = "Width";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiTextEditCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject9["internalName"] = "width";
            oc_Newobject9["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "57 42";
            oc_Newobject9["Extent"] = "141 18";
            oc_Newobject9["text"] = "";
            oc_Newobject9["AltCommand"] = "RoadEditorGui.editNodeDetails();";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject17["#Newobject10"] = oc_Newobject10;

            #region GuiContainer ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiContainer", "");
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "inspectorStyleRolloutDarkProfile";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "4 91";
            oc_Newobject12["Extent"] = "202 31";
            oc_Newobject12["Docking"] = "Top";
            oc_Newobject12["Margin"] = "0 0 3 3";

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "5 0";
            oc_Newobject11["Extent"] = "121 18";
            oc_Newobject11["text"] = "Decal Road Properties";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject17["#Newobject12"] = oc_Newobject12;

            #region GuiContainer ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiContainer", "");
            oc_Newobject15["profile"] = new Creator.StringNoQuote("ToolsGuiDefaultProfile");
            oc_Newobject15["Position"] = "4 108";
            oc_Newobject15["Extent"] = "202 377";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "height";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Docking"] = "Client";
            oc_Newobject15["Margin"] = "-14 41 3 3";

            #region GuiScrollCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "height";
            oc_Newobject14["Position"] = "0 0";
            oc_Newobject14["Extent"] = "202 377";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["willFirstRespond"] = "1";
            oc_Newobject14["hScrollBar"] = "alwaysOff";
            oc_Newobject14["vScrollBar"] = "dynamic";
            oc_Newobject14["lockHorizScroll"] = "true";
            oc_Newobject14["lockVertScroll"] = "false";
            oc_Newobject14["constantThumbHeight"] = "0";
            oc_Newobject14["childMargin"] = "0 0";

            #region GuiInspector (RoadInspector)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiInspector", "RoadInspector", typeof (RoadInspector));
            oc_Newobject13["StackingType"] = "Vertical";
            oc_Newobject13["HorizStacking"] = "Left to Right";
            oc_Newobject13["VertStacking"] = "Top to Bottom";
            oc_Newobject13["Padding"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "height";
            oc_Newobject13["Position"] = "0 0";
            oc_Newobject13["Extent"] = "200 196";
            oc_Newobject13["MinExtent"] = "8 8";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["isDecoy"] = "0";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["dividerMargin"] = "5";
            oc_Newobject13["groupFilters"] = "+SimBase,+DecalRoad";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiMLTextCtrl (RoadFieldInfoControl)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiMLTextCtrl", "RoadFieldInfoControl");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "top";
            oc_Newobject16["Position"] = "1 485";
            oc_Newobject16["Extent"] = "202 42";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["lineSpacing"] = "2";
            oc_Newobject16["allowColorChars"] = "0";
            oc_Newobject16["maxChars"] = "-1";
            oc_Newobject16["useURLMouseCursor"] = "0";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject18.Create();
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            bGlobal["$DecalRoad::EditorOpen"] = true;

            int count = EWorldEditor.getSelectionSize();
            for (uint i = 0; i < count; i++)
                {
                SimObject obj = EWorldEditor.getSelectedObject((int) i);
                if (obj.getClassName() != "DecalRoad")
                    EWorldEditor.unselectObject(i.AsString());
                else
                    this.setSelectedRoad(obj);
                }

            this.onNodeSelected("-1", "0");
        }

        [ConsoleInteraction]
        public override void onSleep()
        {
            bGlobal["$DecalRoad::EditorOpen"] = false;
        }

        [ConsoleInteraction]
        public override void paletteSync(string mode)
        {
            ((GuiButtonBaseCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName(mode, true)).setStateOn(true);
        }

        [ConsoleInteraction]
        public void onDeleteKey()
        {
            int road = this.getSelectedRoad();
            int node = this.getSelectedNode();

            if (!road.AsString().isObject())
                return;

            if (node != -1)
                this.deleteNode();
            else
                messageBox.MessageBoxOKCancel("Notice", "Delete selected DecalRoad?", "RoadEditorGui.deleteRoad();", "");
        }

        [ConsoleInteraction]
        public bool onEscapePressed()
        {
            if (this.getMode() == "RoadEditorAddNodeMode")
                {
                this.prepSelectionMode();
                return true;
                }
            return false;
        }

        //just in case we need it later
        [ConsoleInteraction]
        public override void onRoadCreation()
        {
        }

        [ConsoleInteraction]
        public override void onRoadSelected(string road)
        {
            GuiTreeViewCtrl RoadTreeView = "RoadTreeView";
            this["road"] = road;

            // Update the materialEditorList
            if (road.isObject())
                sGlobal["$Tools::materialEditorList"] = road;
            else
                return;

            ((GuiInspector) "RoadInspector").inspect(road);
            RoadTreeView.buildVisibleTree(true);
            if (RoadTreeView.getSelectedObject() != road.AsInt())
                {
                RoadTreeView.clearSelection();
                int treeId = RoadTreeView.findItemByObjectId(road.getID());
                RoadTreeView.selectItem(treeId);
                }
        }

        [ConsoleInteraction]
        public override void onNodeSelected(string nodeIdx, string nodeWidth)
        {
            GuiContainer RoadEditorProperties = "RoadEditorProperties";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) RoadEditorProperties.findObjectByInternalName("position", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) RoadEditorProperties.findObjectByInternalName("width", true);
            if (nodeIdx == "-1")
                {
                positionTextEditCtrl.setActive(false);
                positionTextEditCtrl.setValue("");

                widthTextEditCtrl.setActive(false);
                widthTextEditCtrl.setValue("");
                }
            else
                {
                positionTextEditCtrl.setActive(true);
                positionTextEditCtrl.setValue(this.getNodePosition().AsString());

                widthTextEditCtrl.setActive(true);
                widthTextEditCtrl.setValue(this.getNodeWidth().AsString());
                }
        }

        [ConsoleInteraction]
        public override void onNodeModified(string nodeIdx)
        {
            GuiContainer RoadEditorProperties = "RoadEditorProperties";
            ((GuiTextEditCtrl) RoadEditorProperties.findObjectByInternalName("position", true)).setValue(this.getNodePosition().AsString());
            ((GuiTextEditCtrl) RoadEditorProperties.findObjectByInternalName("width", true)).setValue(this.getNodeWidth().AsString());
        }

        [ConsoleInteraction]
        public void editNodeDetails()
        {
            GuiContainer RoadEditorProperties = "RoadEditorProperties";
            this.setNodePosition(new Point3F(((GuiTextEditCtrl) RoadEditorProperties.findObjectByInternalName("position", true)).getText()));
            this.setNodeWidth(((GuiTextEditCtrl) RoadEditorProperties.findObjectByInternalName("width", true)).getText().AsFloat());
        }

        [ConsoleInteraction]
        public void onBrowseClicked()
        {
            //TODO
            //string filename = RETextureFileCtrl.getText();

            OpenFileDialog ofd = new OpenFileDialog {InitialDirectory = this["lastPath"], Filter = @"All Files (*.*)|*.*", CheckFileExists = true, Multiselect = false};

            DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

            /*ObjectCreator dlgCreator = new ObjectCreator("OpenFileDialog");
            dlgCreator["Filters"] = "All Files (*.*)|*.*|";
            dlgCreator["DefaultPath"] = this["lastPath"];

            //TODO
            //dlg["DefaultFile"] = filename;
            dlgCreator["ChangePath"] = false.AsString();
            dlgCreator["MustExist"] = true.AsString();

            coOpenFileDialog dlg = dlgCreator.Create();

            bool ret = dlg.Execute();*/
            //if (ret)
            if (dr == DialogResult.OK)
                {
                string fileName = Dialogs.GetForwardSlashFile(ofd.FileName);
                this["lastPath"] = console.Call("filePath", new string[] {fileName});
                //string filename = fileName;

                //TODO
                //this.setTextureFile(filename);
                //"RETextureFileCtrl".call("setText", new string[] {filename});
                }

            //dlg.delete();
        }

        [ConsoleInteraction]
        public void prepSelectionMode()
        {
            string mode = this.getMode();

            if (mode == "RoadEditorAddNodeMode")
                {
                if (this.getSelectedRoad() != 0)
                    this.deleteNode();
                }

            this.setMode("RoadEditorSelectMode");
            ((GuiBitmapButtonCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName("RoadEditorSelectMode", true)).setStateOn(true);
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERoadEditorAddModeBtn>))]
        public class ERoadEditorAddModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(ERoadEditorAddModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERoadEditorAddModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERoadEditorAddModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorAddModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERoadEditorAddModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorAddModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERoadEditorAddModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorAddModeBtn(int simobjectid)
            {
                return (ERoadEditorAddModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERoadEditorAddModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERoadEditorAddModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERoadEditorAddModeBtn(uint simobjectid)
            {
                return (ERoadEditorAddModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorAddModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERoadEditorInsertModeBtn>))]
        public class ERoadEditorInsertModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(ERoadEditorInsertModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERoadEditorInsertModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERoadEditorInsertModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorInsertModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERoadEditorInsertModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorInsertModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERoadEditorInsertModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorInsertModeBtn(int simobjectid)
            {
                return (ERoadEditorInsertModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERoadEditorInsertModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERoadEditorInsertModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERoadEditorInsertModeBtn(uint simobjectid)
            {
                return (ERoadEditorInsertModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorInsertModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERoadEditorMoveModeBtn>))]
        public class ERoadEditorMoveModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(ERoadEditorMoveModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERoadEditorMoveModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERoadEditorMoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorMoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERoadEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERoadEditorMoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorMoveModeBtn(int simobjectid)
            {
                return (ERoadEditorMoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERoadEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERoadEditorMoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERoadEditorMoveModeBtn(uint simobjectid)
            {
                return (ERoadEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorMoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERoadEditorRemoveModeBtn>))]
        public class ERoadEditorRemoveModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(ERoadEditorRemoveModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERoadEditorRemoveModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERoadEditorRemoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorRemoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERoadEditorRemoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorRemoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERoadEditorRemoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorRemoveModeBtn(int simobjectid)
            {
                return (ERoadEditorRemoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERoadEditorRemoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERoadEditorRemoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERoadEditorRemoveModeBtn(uint simobjectid)
            {
                return (ERoadEditorRemoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorRemoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERoadEditorScaleModeBtn>))]
        public class ERoadEditorScaleModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(ERoadEditorScaleModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERoadEditorScaleModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERoadEditorScaleModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorScaleModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERoadEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERoadEditorScaleModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorScaleModeBtn(int simobjectid)
            {
                return (ERoadEditorScaleModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERoadEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERoadEditorScaleModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERoadEditorScaleModeBtn(uint simobjectid)
            {
                return (ERoadEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorScaleModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ERoadEditorSelectModeBtn>))]
        public class ERoadEditorSelectModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(ERoadEditorSelectModeBtn ts, string simobjectid)
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
            public static bool operator !=(ERoadEditorSelectModeBtn ts, string simobjectid)
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
            public static implicit operator string(ERoadEditorSelectModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorSelectModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ERoadEditorSelectModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorSelectModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ERoadEditorSelectModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ERoadEditorSelectModeBtn(int simobjectid)
            {
                return (ERoadEditorSelectModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (ERoadEditorSelectModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ERoadEditorSelectModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ERoadEditorSelectModeBtn(uint simobjectid)
            {
                return (ERoadEditorSelectModeBtn) Omni.self.getSimObject(simobjectid, typeof (ERoadEditorSelectModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RoadDefaultWidthSliderCtrlContainer>))]
        public class RoadDefaultWidthSliderCtrlContainer : EditorGui.EditorDropdownSliderContainer
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                ((GuiSliderCtrl) (this).findObjectByInternalName("slider", true)).setValue(((GuiTextEditCtrl) ((GuiControl) "RoadDefaultWidthTextEditContainer").findObjectByInternalName("textEdit", true)).getText());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RoadDefaultWidthSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(RoadDefaultWidthSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(RoadDefaultWidthSliderCtrlContainer ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RoadDefaultWidthSliderCtrlContainer(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RoadDefaultWidthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (RoadDefaultWidthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RoadDefaultWidthSliderCtrlContainer ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RoadDefaultWidthSliderCtrlContainer(int simobjectid)
            {
                return (RoadDefaultWidthSliderCtrlContainer) Omni.self.getSimObject((uint) simobjectid, typeof (RoadDefaultWidthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RoadDefaultWidthSliderCtrlContainer ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RoadDefaultWidthSliderCtrlContainer(uint simobjectid)
            {
                return (RoadDefaultWidthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (RoadDefaultWidthSliderCtrlContainer));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RoadEditorOptionsWindow>))]
        public class RoadEditorOptionsWindow : GuiWindowCollapseCtrl
        {
            public override void onPopWindow()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RoadEditorPlugin").onActivated();
            }

            public override void onPopWindowClosed()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RoadEditorPlugin").onActivated();
                this.attachTo("RoadEditorTreeWindow");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RoadEditorOptionsWindow ts, string simobjectid)
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
            public static bool operator !=(RoadEditorOptionsWindow ts, string simobjectid)
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
            public static implicit operator string(RoadEditorOptionsWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RoadEditorOptionsWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RoadEditorOptionsWindow) Omni.self.getSimObject(simobjectid, typeof (RoadEditorOptionsWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RoadEditorOptionsWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RoadEditorOptionsWindow(int simobjectid)
            {
                return (RoadEditorOptionsWindow) Omni.self.getSimObject((uint) simobjectid, typeof (RoadEditorOptionsWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RoadEditorOptionsWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RoadEditorOptionsWindow(uint simobjectid)
            {
                return (RoadEditorOptionsWindow) Omni.self.getSimObject(simobjectid, typeof (RoadEditorOptionsWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RoadEditorTreeWindow>))]
        public class RoadEditorTreeWindow : GuiWindowCollapseCtrl
        {
            public override void onPopWindow()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RoadEditorPlugin").onActivated();
            }

            public override void onPopWindowClosed()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "RoadEditorPlugin").onActivated();
                this.attachTo("RoadEditorOptionsWindow");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RoadEditorTreeWindow ts, string simobjectid)
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
            public static bool operator !=(RoadEditorTreeWindow ts, string simobjectid)
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
            public static implicit operator string(RoadEditorTreeWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RoadEditorTreeWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RoadEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (RoadEditorTreeWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RoadEditorTreeWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RoadEditorTreeWindow(int simobjectid)
            {
                return (RoadEditorTreeWindow) Omni.self.getSimObject((uint) simobjectid, typeof (RoadEditorTreeWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RoadEditorTreeWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RoadEditorTreeWindow(uint simobjectid)
            {
                return (RoadEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (RoadEditorTreeWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RoadInspector>))]
        public class RoadInspector : GuiInspector
        {
            [ConsoleInteraction]
            public void inspect(SimObject obj)
            {
                string name = "";
                if (obj.isObject())
                    name = obj.getName();
                else
                    ((GuiMLTextCtrl) "RoadFieldInfoControl").setText("");

                //RoadInspectorNameEdit.setValue( %name );
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
                ((GuiMLTextCtrl) "RoadFieldInfoControl").setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") \n <font:Arial:14>" + fieldDoc);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RoadInspector ts, string simobjectid)
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
            public static bool operator !=(RoadInspector ts, string simobjectid)
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
            public static implicit operator string(RoadInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RoadInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RoadInspector) Omni.self.getSimObject(simobjectid, typeof (RoadInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RoadInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RoadInspector(int simobjectid)
            {
                return (RoadInspector) Omni.self.getSimObject((uint) simobjectid, typeof (RoadInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RoadInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RoadInspector(uint simobjectid)
            {
                return (RoadInspector) Omni.self.getSimObject(simobjectid, typeof (RoadInspector));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RoadTreeView>))]
        public class RoadTreeView : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onInspect(int itemOrObjectId)
            {
                ((GuiInspector) "RoadInspector").inspect(itemOrObjectId.AsString());
            }

            [ConsoleInteraction]
            public override void onSelect(string x, string y)
            {
                ((GuiRoadEditorCtrl) "RoadEditorGui")["road"] = x;
                ((GuiInspector) "RoadInspector").inspect(x);
                if (x.AsInt() != ((GuiRoadEditorCtrl) "RoadEditorGui").getSelectedRoad())
                    ((GuiRoadEditorCtrl) "RoadEditorGui").setSelectedRoad(x);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RoadTreeView ts, string simobjectid)
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
            public static bool operator !=(RoadTreeView ts, string simobjectid)
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
            public static implicit operator string(RoadTreeView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RoadTreeView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RoadTreeView) Omni.self.getSimObject(simobjectid, typeof (RoadTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RoadTreeView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RoadTreeView(int simobjectid)
            {
                return (RoadTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (RoadTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RoadTreeView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RoadTreeView(uint simobjectid)
            {
                return (RoadTreeView) Omni.self.getSimObject(simobjectid, typeof (RoadTreeView));
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
        public static bool operator ==(RoadEditorGui ts, string simobjectid)
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
        public static bool operator !=(RoadEditorGui ts, string simobjectid)
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
        public static implicit operator string(RoadEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator RoadEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (RoadEditorGui) Omni.self.getSimObject(simobjectid, typeof (RoadEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RoadEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RoadEditorGui(int simobjectid)
        {
            return (RoadEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (RoadEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RoadEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RoadEditorGui(uint simobjectid)
        {
            return (RoadEditorGui) Omni.self.getSimObject(simobjectid, typeof (RoadEditorGui));
        }

        #endregion
    }
}