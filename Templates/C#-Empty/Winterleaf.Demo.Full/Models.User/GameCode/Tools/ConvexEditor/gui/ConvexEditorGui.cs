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
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ConvexEditorGui>))]
    public class ConvexEditorGui : GuiConvexEditorCtrl
    {

        [ConsoleInteraction(true, "ConvexEditorGui_initialize")]
        public static void initialize()
        {
            #region GuiConvexEditorCtrl (ConvexEditorGui)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiConvexEditorCtrl", "ConvexEditorGui", typeof (ConvexEditorGui));
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["Profile"] = "ConvexEditorProfile";
            oc_Newobject24["HorizSizing"] = "width";
            oc_Newobject24["VertSizing"] = "height";
            oc_Newobject24["Position"] = "0 0";
            oc_Newobject24["Extent"] = "800 600";
            oc_Newobject24["MinExtent"] = "8 8";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["Docking"] = "None";
            oc_Newobject24["Margin"] = "0 0 0 0";
            oc_Newobject24["Padding"] = "0 0 0 0";
            oc_Newobject24["AnchorTop"] = "0";
            oc_Newobject24["AnchorBottom"] = "0";
            oc_Newobject24["AnchorLeft"] = "0";
            oc_Newobject24["AnchorRight"] = "0";
            oc_Newobject24["cameraZRot"] = "0";
            oc_Newobject24["forceFOV"] = "0";
            oc_Newobject24["renderMissionArea"] = "0";
            oc_Newobject24["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject24["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject24["allowBorderMove"] = "0";
            oc_Newobject24["borderMovePixelSize"] = "20";
            oc_Newobject24["borderMoveSpeed"] = "0.1";
            oc_Newobject24["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject24["consoleFillColor"] = "0 0 0 0";
            oc_Newobject24["consoleSphereLevel"] = "1";
            oc_Newobject24["consoleCircleSegments"] = "32";
            oc_Newobject24["consoleLineWidth"] = "1";
            oc_Newobject24["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject24["DefaultWidth"] = "10";
            oc_Newobject24["HoverSplineColor"] = "0 255 0 255";
            oc_Newobject24["SelectedSplineColor"] = "255 0 255 255";
            oc_Newobject24["HoverNodeColor"] = "255 255 255 255";

            #region GuiWindowCollapseCtrl (ConvexEditorTreeWindow)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCollapseCtrl", "ConvexEditorTreeWindow");
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
            oc_Newobject4["closeCommand"] = "EditorGui.setEditor( WorldEditorInspectorPlugin );";
            oc_Newobject4["EdgeSnap"] = "1";
            oc_Newobject4["text"] = "ConvexShapes";

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

            #region GuiTreeViewCtrl (ConvexTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "ConvexTreeView");
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
            oc_Newobject1["showRoot"] = "1";
            oc_Newobject1["internalNamesOnly"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject24["#Newobject4"] = oc_Newobject4;

            #region GuiWindowCollapseCtrl (ConvexEditorOptionsWindow)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiWindowCollapseCtrl", "ConvexEditorOptionsWindow");
            oc_Newobject20["internalName"] = "Window";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject20["HorizSizing"] = "windowRelative";
            oc_Newobject20["VertSizing"] = "windowRelative";
            oc_Newobject20["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) + getWord(ConvexEditorTreeWindow.extent, 1) - 2");
            oc_Newobject20["Extent"] = "210 530";
            oc_Newobject20["MinExtent"] = "210 298";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["resizeWidth"] = "1";
            oc_Newobject20["resizeHeight"] = "1";
            oc_Newobject20["canMove"] = "1";
            oc_Newobject20["canClose"] = "0";
            oc_Newobject20["canMinimize"] = "0";
            oc_Newobject20["canMaximize"] = "0";
            oc_Newobject20["minSize"] = "50 50";
            oc_Newobject20["closeCommand"] = "EditorGui.setEditor( WorldEditorPlugin );";
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
            oc_Newobject7["AltCommand"] = "ConvexEditorGui.editNodeDetails();";

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
            oc_Newobject9["AltCommand"] = "ConvexEditorGui.editNodeDetails();";

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
            oc_Newobject11["AltCommand"] = "ConvexEditorGui.editNodeDetails();";

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
            oc_Newobject13["AltCommand"] = "ConvexEditorGui.editNodeDetails();";

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
            oc_Newobject15["text"] = "ConvexShape Properties";

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
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["willFirstRespond"] = "1";
            oc_Newobject18["hScrollBar"] = "alwaysOff";
            oc_Newobject18["vScrollBar"] = "dynamic";
            oc_Newobject18["lockHorizScroll"] = "true";
            oc_Newobject18["lockVertScroll"] = "false";
            oc_Newobject18["constantThumbHeight"] = "0";
            oc_Newobject18["childMargin"] = "0 0";

            #region GuiInspector (ConvexInspector)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiInspector", "ConvexInspector");
            oc_Newobject17["StackingType"] = "Vertical";
            oc_Newobject17["HorizStacking"] = "Left to Right";
            oc_Newobject17["VertStacking"] = "Top to Bottom";
            oc_Newobject17["Padding"] = "1";
            oc_Newobject17["name"] = "ConvexInspector";
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "1 1";
            oc_Newobject17["Extent"] = "179 16";
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

            #region GuiMLTextCtrl (ConvexFieldInfoControl)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiMLTextCtrl", "ConvexFieldInfoControl");
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

            oc_Newobject24["#Newobject20"] = oc_Newobject20;

            #region GuiWindowCollapseCtrl (ConvexEditorTipsWindow)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiWindowCollapseCtrl", "ConvexEditorTipsWindow");
            oc_Newobject23["CollapseGroup"] = "-1";
            oc_Newobject23["CollapseGroupNum"] = "-1";
            oc_Newobject23["resizeWidth"] = "1";
            oc_Newobject23["resizeHeight"] = "1";
            oc_Newobject23["canMove"] = "1";
            oc_Newobject23["canClose"] = "0";
            oc_Newobject23["canMinimize"] = "0";
            oc_Newobject23["canMaximize"] = "0";
            oc_Newobject23["minSize"] = "50 50";
            oc_Newobject23["EdgeSnap"] = "1";
            oc_Newobject23["text"] = "Tips";
            oc_Newobject23["Margin"] = "0 0 0 0";
            oc_Newobject23["Padding"] = "0 0 0 0";
            oc_Newobject23["AnchorTop"] = "1";
            oc_Newobject23["AnchorBottom"] = "0";
            oc_Newobject23["AnchorLeft"] = "1";
            oc_Newobject23["AnchorRight"] = "0";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["Profile"] = "ToolsGuiWindowCollapseProfile";
            oc_Newobject23["HorizSizing"] = "windowRelative";
            oc_Newobject23["VertSizing"] = "windowRelative";
            oc_Newobject23["position"] = "6 483";
            oc_Newobject23["Extent"] = "136 246";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "0";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject22["willFirstRespond"] = "1";
            oc_Newobject22["hScrollBar"] = "alwaysOff";
            oc_Newobject22["vScrollBar"] = "dynamic";
            oc_Newobject22["lockHorizScroll"] = "1";
            oc_Newobject22["lockVertScroll"] = "0";
            oc_Newobject22["constantThumbHeight"] = "0";
            oc_Newobject22["childMargin"] = "0 0";
            oc_Newobject22["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject22["Docking"] = "Client";
            oc_Newobject22["Margin"] = "3 1 3 3";
            oc_Newobject22["Padding"] = "0 0 0 0";
            oc_Newobject22["AnchorTop"] = "1";
            oc_Newobject22["AnchorBottom"] = "0";
            oc_Newobject22["AnchorLeft"] = "1";
            oc_Newobject22["AnchorRight"] = "0";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "4 24";
            oc_Newobject22["Extent"] = "128 218";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSaveDynamicFields"] = "0";

            #region GuiTextListCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextListCtrl", "");
            oc_Newobject21["columns"] = "0";
            oc_Newobject21["fitParentWidth"] = "1";
            oc_Newobject21["clipColumnText"] = "0";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiTextListProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "top";
            oc_Newobject21["position"] = "1 1";
            oc_Newobject21["Extent"] = "126 2";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["internalName"] = "TextList";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject24.Create();
        }

        [ConsoleInteraction]
        public override void onWake()
        {
        }

        [ConsoleInteraction]
        public override void onSleep()
        {
        }

        [ConsoleInteraction]
        public void createConvexBox()
        {
            SimObject obj = Tools.WorldEditor.gui.CodeBehind.Creator.genericCreateObject("ConvexShape");
            this.handleDeselect();
            this.selectConvex(obj);
            this.dropSelectionAtScreenCenter();
        }

        [ConsoleInteraction]
        public override void onSelectionChanged(string shape, string face)
        {
            GuiBitmapButtonCtrl ConvexEditorSplitFaceBtn = "ConvexEditorSplitFaceBtn";
            GuiBitmapButtonCtrl ConvexEditorDeleteFaceBtn = "ConvexEditorDeleteFaceBtn";

            //echo( "onSelectionChanged: " @ %shape SPC %face );

            ConvexEditorSplitFaceBtn.setActive(false);
            ConvexEditorSplitFaceBtn["ToolTip"] = "Split selected face [Disabled]" + '\n' + "Use Ctrl + Rotate instead for more control";
            ConvexEditorDeleteFaceBtn.setActive(false);
            ConvexEditorDeleteFaceBtn["ToolTip"] = "Delete selection [Disabled] (Delete)";

            if (!shape.isObject())
                return;

            ConvexEditorDeleteFaceBtn.setActive(true);

            if (face == "-1")
                ConvexEditorDeleteFaceBtn["ToolTip"] = "Delete selected ConvexShape (Delete)";
            else
                {
                ConvexEditorDeleteFaceBtn["ToolTip"] = "Delete selected Face (Delete)";

                ConvexEditorSplitFaceBtn["ToolTip"] = "Split selected face" + '\n' + "Use Ctrl + Rotate instead for more control";
                ConvexEditorSplitFaceBtn.setActive(true);
                }
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConvexEditorGui ts, string simobjectid)
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
        public static bool operator !=(ConvexEditorGui ts, string simobjectid)
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
        public static implicit operator string(ConvexEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ConvexEditorGui) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConvexEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorGui(int simobjectid)
        {
            return (ConvexEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (ConvexEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConvexEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConvexEditorGui(uint simobjectid)
        {
            return (ConvexEditorGui) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorGui));
        }

        #endregion
    }
}