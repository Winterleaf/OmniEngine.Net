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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<MeshRoadEditorGui>))]
    public class MeshRoadEditorGui : GuiMeshRoadEditorCtrl
    {

        [ConsoleInteraction(true, "MeshRoadEditorGui_initialize")]
        public static void initialize()
        {
            #region GuiMeshRoadEditorCtrl (MeshRoadEditorGui,EditorGuiGroup)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiMeshRoadEditorCtrl", "MeshRoadEditorGui,EditorGuiGroup", typeof (MeshRoadEditorGui));
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "MeshRoadEditorProfile";
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

            #region GuiWindowCollapseCtrl (MeshRoadEditorTreeWindow)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCollapseCtrl", "MeshRoadEditorTreeWindow", typeof (MeshRoadEditorTreeWindow));
            oc_Newobject4["internalName"] = "MeshRoadEditorTreeWindow";
            oc_Newobject4["AllowPopWindow"] = "1";
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
            oc_Newobject4["text"] = "Mesh Roads";

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

            #region GuiTreeViewCtrl (MeshRoadTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "MeshRoadTreeView", typeof (MeshRoadTreeView));
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

            #region GuiWindowCollapseCtrl (MeshRoadEditorOptionsWindow)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiWindowCollapseCtrl", "MeshRoadEditorOptionsWindow", typeof (MeshRoadEditorOptionsWindow));
            oc_Newobject20["internalName"] = "MeshRoadEditorOptionsWindow";
            oc_Newobject20["AllowPopWindow"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject20["HorizSizing"] = "windowRelative";
            oc_Newobject20["VertSizing"] = "windowRelative";
            oc_Newobject20["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) + getWord(MeshRoadEditorTreeWindow.extent, 1) - 2");
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
            oc_Newobject7["AltCommand"] = "MeshRoadEditorGui.editNodeDetails();";

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
            oc_Newobject9["AltCommand"] = "MeshRoadEditorGui.editNodeDetails();";

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
            oc_Newobject11["AltCommand"] = "MeshRoadEditorGui.editNodeDetails();";

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
            oc_Newobject13["AltCommand"] = "MeshRoadEditorGui.editNodeDetails();";

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
            oc_Newobject15["text"] = "Mesh Road Properties";

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

            #region GuiInspector (MeshRoadInspector)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiInspector", "MeshRoadInspector", typeof (MeshRoadInspector));
            oc_Newobject17["StackingType"] = "Vertical";
            oc_Newobject17["HorizStacking"] = "Left to Right";
            oc_Newobject17["VertStacking"] = "Top to Bottom";
            oc_Newobject17["Padding"] = "1";
            oc_Newobject17["name"] = "MeshRoadInspector";
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

            #region GuiMLTextCtrl (MeshFieldInfoControl)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiMLTextCtrl", "MeshFieldInfoControl");
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

            omni.bGlobal["$MeshRoad::wireframe"] = true;
            omni.bGlobal["$MeshRoad::showSpline"] = true;
            omni.bGlobal["$MeshRoad::showReflectPlane"] = false;
            omni.bGlobal["$MeshRoad::showRoad"] = true;
            omni.dGlobal["$MeshRoad::breakAngle"] = 3.0;
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";
            omni.bGlobal["$MeshRoad::EditorOpen"] = true;

            int count = EWorldEditor.getSelectionSize();
            for (int i = 0; i < count; i++)
                {
                SimObject obj = EWorldEditor.getSelectedObject(i);
                if (obj.getClassName() != "MeshRoad")
                    EWorldEditor.unselectObject(obj);
                else
                    this.setSelectedRoad(obj);
                }

            //%this-->TabBook.selectPage(0);

            this.onNodeSelected("-1");
        }

        [ConsoleInteraction]
        public override void onSleep()
        {
            omni.bGlobal["$MeshRoad::EditorOpen"] = false;
        }

        [ConsoleInteraction]
        public override void paletteSync(string mode)
        {
            ((GuiButtonBaseCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName(mode, true)).setStateOn(true);
        }

        [ConsoleInteraction]
        public bool onEscapePressed()
        {
            if (this.getMode() == "MeshRoadEditorAddNodeMode")
                {
                this.prepSelectionMode();
                return true;
                }
            return false;
        }

        [ConsoleInteraction]
        public override void onRoadSelected(string road)
        {
            GuiInspector MeshRoadInspector = "MeshRoadInspector";
            GuiTreeViewCtrl MeshRoadTreeView = "MeshRoadTreeView";

            this["road"] = road;

            // Update the materialEditorList
            if (road.isObject())
                omni.sGlobal["$Tools::materialEditorList"] = road;
            else
                return;

            MeshRoadInspector.inspect(road);
            MeshRoadTreeView.buildVisibleTree(true);
            if (MeshRoadTreeView.getSelectedObject() != road.AsInt())
                {
                MeshRoadTreeView.clearSelection();
                int treeId = MeshRoadTreeView.findItemByObjectId(road.getID());
                MeshRoadTreeView.selectItem(treeId);
                }
        }

        [ConsoleInteraction]
        public override void onNodeSelected(string nodeIdx)
        {
            GuiWindowCollapseCtrl MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("position", true);
            GuiTextEditCtrl rotationTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("rotation", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("width", true);
            GuiTextEditCtrl depthTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("depth", true);

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
            GuiWindowCollapseCtrl MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("position", true);
            GuiTextEditCtrl rotationTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("rotation", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("width", true);
            GuiTextEditCtrl depthTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("depth", true);

            positionTextEditCtrl.setValue(this.getNodePosition().AsString());
            rotationTextEditCtrl.setValue(this.getNodeNormal().AsString());
            widthTextEditCtrl.setValue(this.getNodeWidth().AsString());
            depthTextEditCtrl.setValue(this.getNodeDepth().AsString());
        }

        [ConsoleInteraction]
        public void editNodeDetails()
        {
            GuiWindowCollapseCtrl MeshRoadEditorOptionsWindow = "MeshRoadEditorOptionsWindow";
            GuiTextEditCtrl positionTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("position", true);
            GuiTextEditCtrl rotationTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("rotation", true);
            GuiTextEditCtrl widthTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("width", true);
            GuiTextEditCtrl depthTextEditCtrl = (GuiTextEditCtrl) MeshRoadEditorOptionsWindow.findObjectByInternalName("depth", true);

            this.setNodePosition(new Point3F(positionTextEditCtrl.getText()));
            this.setNodeNormal(new Point3F(rotationTextEditCtrl.getText()));
            this.setNodeWidth(widthTextEditCtrl.getText().AsFloat());
            this.setNodeDepth(depthTextEditCtrl.getText().AsFloat());
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
                this["lastPath"] = omni.console.Call("filePath", new string[] {fileName});
                //string filename = dlg["FileName"];

                //TODO
                //this.setTextureFile(filename);
                //"MeshRoadEditorTextureFileCtrl".call("setText", new string[] {filename});
                }

            // dlg.delete();
        }

        [ConsoleInteraction]
        public void prepSelectionMode()
        {
            string mode = this.getMode();

            if (mode == "MeshRoadEditorAddNodeMode")
                {
                if (this.getSelectedRoad() != 0)
                    this.deleteNode();
                }

            this.setMode("MeshRoadEditorSelectMode");
            ((GuiBitmapButtonCtrl) ((GuiDynamicCtrlArrayControl) "ToolsPaletteArray").findObjectByInternalName("MeshRoadEditorSelectMode", true)).setStateOn(true);
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorAddModeBtn>))]
        public class EMeshRoadEditorAddModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorAddModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorAddModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorAddModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorAddModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorAddModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorAddModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorAddModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorAddModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorAddModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorAddModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorAddModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorAddModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorAddModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorAddModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorInsertModeBtn>))]
        public class EMeshRoadEditorInsertModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorInsertModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorInsertModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorInsertModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorInsertModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorInsertModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorInsertModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorInsertModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorInsertModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorInsertModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorInsertModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorInsertModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorInsertModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorInsertModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorInsertModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorMoveModeBtn>))]
        public class EMeshRoadEditorMoveModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorMoveModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorMoveModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorMoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorMoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorMoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorMoveModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorMoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorMoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorMoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorMoveModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorMoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorMoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorRemoveModeBtn>))]
        public class EMeshRoadEditorRemoveModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorRemoveModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorRemoveModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorRemoveModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorRemoveModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorRemoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorRemoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorRemoveModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorRemoveModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorRemoveModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorRemoveModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorRemoveModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorRemoveModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorRemoveModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorRemoveModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorRotateModeBtn>))]
        public class EMeshRoadEditorRotateModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorRotateModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorRotateModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorRotateModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorRotateModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorRotateModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorRotateModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorRotateModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorRotateModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorRotateModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorRotateModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorRotateModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorRotateModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorRotateModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorRotateModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorScaleModeBtn>))]
        public class EMeshRoadEditorScaleModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorScaleModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorScaleModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorScaleModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorScaleModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorScaleModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorScaleModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorScaleModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorScaleModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorScaleModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorScaleModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorScaleModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorScaleModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<EMeshRoadEditorSelectModeBtn>))]
        public class EMeshRoadEditorSelectModeBtn : GuiBitmapButtonCtrl
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
            public static bool operator ==(EMeshRoadEditorSelectModeBtn ts, string simobjectid)
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
            public static bool operator !=(EMeshRoadEditorSelectModeBtn ts, string simobjectid)
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
            public static implicit operator string(EMeshRoadEditorSelectModeBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorSelectModeBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EMeshRoadEditorSelectModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorSelectModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EMeshRoadEditorSelectModeBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorSelectModeBtn(int simobjectid)
            {
                return (EMeshRoadEditorSelectModeBtn) Omni.self.getSimObject((uint) simobjectid, typeof (EMeshRoadEditorSelectModeBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EMeshRoadEditorSelectModeBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EMeshRoadEditorSelectModeBtn(uint simobjectid)
            {
                return (EMeshRoadEditorSelectModeBtn) Omni.self.getSimObject(simobjectid, typeof (EMeshRoadEditorSelectModeBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MeshRoadDefaultDepthSliderCtrlContainer>))]
        public class MeshRoadDefaultDepthSliderCtrlContainer : EditorGui.EditorDropdownSliderContainer
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                ((GuiSliderCtrl) (this).findObjectByInternalName("slider", true)).setValue(((GuiTextEditCtrl) ((GuiControl) "MeshRoadDefaultDepthTextEditContainer").findObjectByInternalName("textEdit", true)).getText());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MeshRoadDefaultDepthSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(MeshRoadDefaultDepthSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(MeshRoadDefaultDepthSliderCtrlContainer ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadDefaultDepthSliderCtrlContainer(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MeshRoadDefaultDepthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (MeshRoadDefaultDepthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MeshRoadDefaultDepthSliderCtrlContainer ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadDefaultDepthSliderCtrlContainer(int simobjectid)
            {
                return (MeshRoadDefaultDepthSliderCtrlContainer) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadDefaultDepthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MeshRoadDefaultDepthSliderCtrlContainer ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MeshRoadDefaultDepthSliderCtrlContainer(uint simobjectid)
            {
                return (MeshRoadDefaultDepthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (MeshRoadDefaultDepthSliderCtrlContainer));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MeshRoadDefaultWidthSliderCtrlContainer>))]
        public class MeshRoadDefaultWidthSliderCtrlContainer : EditorGui.EditorDropdownSliderContainer
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                ((GuiSliderCtrl) (this).findObjectByInternalName("slider", true)).setValue(((GuiTextEditCtrl) ((GuiControl) "MeshRoadDefaultWidthTextEditContainer").findObjectByInternalName("textEdit", true)).getText());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MeshRoadDefaultWidthSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(MeshRoadDefaultWidthSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(MeshRoadDefaultWidthSliderCtrlContainer ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadDefaultWidthSliderCtrlContainer(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MeshRoadDefaultWidthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (MeshRoadDefaultWidthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MeshRoadDefaultWidthSliderCtrlContainer ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadDefaultWidthSliderCtrlContainer(int simobjectid)
            {
                return (MeshRoadDefaultWidthSliderCtrlContainer) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadDefaultWidthSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MeshRoadDefaultWidthSliderCtrlContainer ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MeshRoadDefaultWidthSliderCtrlContainer(uint simobjectid)
            {
                return (MeshRoadDefaultWidthSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (MeshRoadDefaultWidthSliderCtrlContainer));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MeshRoadEditorOptionsWindow>))]
        public class MeshRoadEditorOptionsWindow : GuiWindowCollapseCtrl
        {
            public override void onPopWindow()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "MeshRoadEditorPlugin").onActivated();
            }

            public override void onPopWindowClosed()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "MeshRoadEditorPlugin").onActivated();
                this.attachTo("MeshRoadEditorTreeWindow");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MeshRoadEditorOptionsWindow ts, string simobjectid)
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
            public static bool operator !=(MeshRoadEditorOptionsWindow ts, string simobjectid)
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
            public static implicit operator string(MeshRoadEditorOptionsWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadEditorOptionsWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MeshRoadEditorOptionsWindow) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorOptionsWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MeshRoadEditorOptionsWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadEditorOptionsWindow(int simobjectid)
            {
                return (MeshRoadEditorOptionsWindow) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadEditorOptionsWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MeshRoadEditorOptionsWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MeshRoadEditorOptionsWindow(uint simobjectid)
            {
                return (MeshRoadEditorOptionsWindow) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorOptionsWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MeshRoadEditorTreeWindow>))]
        public class MeshRoadEditorTreeWindow : GuiWindowCollapseCtrl
        {
            public override void onPopWindow()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "MeshRoadEditorPlugin").onActivated();
            }

            public override void onPopWindowClosed()
            {
                EditorGui.DeactivateAll();
                ((EditorPlugin) "MeshRoadEditorPlugin").onActivated();
                this.attachTo("MeshRoadEditorOptionsWindow");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MeshRoadEditorTreeWindow ts, string simobjectid)
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
            public static bool operator !=(MeshRoadEditorTreeWindow ts, string simobjectid)
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
            public static implicit operator string(MeshRoadEditorTreeWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadEditorTreeWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MeshRoadEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorTreeWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MeshRoadEditorTreeWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadEditorTreeWindow(int simobjectid)
            {
                return (MeshRoadEditorTreeWindow) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadEditorTreeWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MeshRoadEditorTreeWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MeshRoadEditorTreeWindow(uint simobjectid)
            {
                return (MeshRoadEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorTreeWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MeshRoadInspector>))]
        public class MeshRoadInspector : GuiInspector
        {
            [ConsoleInteraction]
            public void inspect(SimObject obj)
            {
                string name = "";
                if (obj.isObject())
                    name = obj.getName();
                else
                    ((GuiMLTextCtrl) "MeshFieldInfoControl").setText("");

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
                ((GuiMLTextCtrl) "MeshFieldInfoControl").setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") \n <font:Arial:14>" + fieldDoc);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MeshRoadInspector ts, string simobjectid)
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
            public static bool operator !=(MeshRoadInspector ts, string simobjectid)
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
            public static implicit operator string(MeshRoadInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MeshRoadInspector) Omni.self.getSimObject(simobjectid, typeof (MeshRoadInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MeshRoadInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadInspector(int simobjectid)
            {
                return (MeshRoadInspector) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MeshRoadInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MeshRoadInspector(uint simobjectid)
            {
                return (MeshRoadInspector) Omni.self.getSimObject(simobjectid, typeof (MeshRoadInspector));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<MeshRoadTreeView>))]
        public class MeshRoadTreeView : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onInspect(int itemOrObjectId)
            {
                ((MeshRoadInspector) "MeshRoadInspector").inspect(itemOrObjectId);
            }

            [ConsoleInteraction]
            public override void onSelect(string x, string y)
            {
                GuiMeshRoadEditorCtrl MeshRoadEditorGui = "MeshRoadEditorGui";
                MeshRoadInspector MeshRoadInspector = "MeshRoadInspector";

                MeshRoadEditorGui["road"] = x;
                MeshRoadInspector.inspect(x);
                if (x.AsInt() != MeshRoadEditorGui.getSelectedRoad())
                    MeshRoadEditorGui.setSelectedRoad(x);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(MeshRoadTreeView ts, string simobjectid)
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
            public static bool operator !=(MeshRoadTreeView ts, string simobjectid)
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
            public static implicit operator string(MeshRoadTreeView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadTreeView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (MeshRoadTreeView) Omni.self.getSimObject(simobjectid, typeof (MeshRoadTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(MeshRoadTreeView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator MeshRoadTreeView(int simobjectid)
            {
                return (MeshRoadTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(MeshRoadTreeView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator MeshRoadTreeView(uint simobjectid)
            {
                return (MeshRoadTreeView) Omni.self.getSimObject(simobjectid, typeof (MeshRoadTreeView));
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
        public static bool operator ==(MeshRoadEditorGui ts, string simobjectid)
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
        public static bool operator !=(MeshRoadEditorGui ts, string simobjectid)
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
        public static implicit operator string(MeshRoadEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MeshRoadEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (MeshRoadEditorGui) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MeshRoadEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MeshRoadEditorGui(int simobjectid)
        {
            return (MeshRoadEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (MeshRoadEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MeshRoadEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MeshRoadEditorGui(uint simobjectid)
        {
            return (MeshRoadEditorGui) Omni.self.getSimObject(simobjectid, typeof (MeshRoadEditorGui));
        }

        #endregion
    }
}