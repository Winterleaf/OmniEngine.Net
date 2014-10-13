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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ForestEditorGui>))]
    public class ForestEditorGui : ForestEditorCtrl
    {
        [ConsoleInteraction(true, "ForestEditorGui_initialize")]
        public static void initialize()
        {
            #region ForestEditorCtrl (ForestEditorGui,EditorGuiGroup)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("ForestEditorCtrl", "ForestEditorGui,EditorGuiGroup", typeof (ForestEditorGui));
            oc_Newobject19["renderMissionArea"] = "0";
            oc_Newobject19["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject19["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject19["allowBorderMove"] = "0";
            oc_Newobject19["borderMovePixelSize"] = "20";
            oc_Newobject19["borderMoveSpeed"] = "0.1";
            oc_Newobject19["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject19["consoleFillColor"] = "255 0 0 120";
            oc_Newobject19["consoleSphereLevel"] = "1";
            oc_Newobject19["consoleCircleSegments"] = "32";
            oc_Newobject19["consoleLineWidth"] = "1";
            oc_Newobject19["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject19["cameraZRot"] = "0";
            oc_Newobject19["forceFOV"] = "0";
            oc_Newobject19["reflectPriority"] = "1";
            oc_Newobject19["Margin"] = "0 0 0 0";
            oc_Newobject19["Padding"] = "0 0 0 0";
            oc_Newobject19["AnchorTop"] = "0";
            oc_Newobject19["AnchorBottom"] = "0";
            oc_Newobject19["AnchorLeft"] = "0";
            oc_Newobject19["AnchorRight"] = "0";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ForestEditorProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "height";
            oc_Newobject19["position"] = "0 0";
            oc_Newobject19["Extent"] = "800 600";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["canSaveDynamicFields"] = "1";

            #region GuiWindowCollapseCtrl (ForestEditorPalleteWindow)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiWindowCollapseCtrl", "ForestEditorPalleteWindow", typeof (ForestEditorPalleteWindow));
            oc_Newobject15["internalName"] = "ForestEditorPalleteWindow";
            oc_Newobject15["AllowPopWindow"] = "1";
            oc_Newobject15["CollapseGroup"] = "-1";
            oc_Newobject15["CollapseGroupNum"] = "-1";
            oc_Newobject15["resizeWidth"] = "1";
            oc_Newobject15["resizeHeight"] = "1";
            oc_Newobject15["canMove"] = "1";
            oc_Newobject15["canClose"] = "0";
            oc_Newobject15["canMinimize"] = "0";
            oc_Newobject15["canMaximize"] = "0";
            oc_Newobject15["minSize"] = "50 50";
            oc_Newobject15["EdgeSnap"] = "1";
            oc_Newobject15["text"] = "Forest Editor";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiWindowCollapseProfile";
            oc_Newobject15["HorizSizing"] = "windowRelative";
            oc_Newobject15["VertSizing"] = "windowRelative";
            oc_Newobject15["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209          SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject15["Extent"] = "210 252";
            oc_Newobject15["MinExtent"] = "210 100";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #region GuiTabBookCtrl (ForestEditTabBook)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTabBookCtrl", "ForestEditTabBook", typeof (ForestEditTabBook));
            oc_Newobject7["TabPosition"] = "Top";
            oc_Newobject7["TabMargin"] = "10";
            oc_Newobject7["MinTabWidth"] = "60";
            oc_Newobject7["TabHeight"] = "20";
            oc_Newobject7["AllowReorder"] = "0";
            oc_Newobject7["FrontTabPadding"] = "0";
            oc_Newobject7["Docking"] = "Client";
            oc_Newobject7["Margin"] = "3 1 3 3";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "height";
            oc_Newobject7["position"] = "3 44";
            oc_Newobject7["Extent"] = "210 205";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiTabPageCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject3["fitBook"] = "0";
            oc_Newobject3["text"] = "Brushes";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["Docking"] = "Client";
            oc_Newobject3["Margin"] = "-1 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "0 22";
            oc_Newobject3["Extent"] = "210 194";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "0";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["internalName"] = "BrushesTab";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = new Creator.StringNoQuote("true");
            oc_Newobject2["lockVertScroll"] = "0";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject2["Docking"] = "Client";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["Extent"] = "210 194";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (ForestEditBrushTree)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "ForestEditBrushTree", typeof (ForestEditBrushTree));
            oc_Newobject1["tabSize"] = "16";
            oc_Newobject1["textOffset"] = "2";
            oc_Newobject1["fullRowSelect"] = "0";
            oc_Newobject1["itemHeight"] = "21";
            oc_Newobject1["destroyTreeOnSleep"] = "1";
            oc_Newobject1["MouseDragging"] = "1";
            oc_Newobject1["MultipleSelections"] = "1";
            oc_Newobject1["DeleteObjectAllowed"] = "1";
            oc_Newobject1["DragToItemAllowed"] = "1";
            oc_Newobject1["ClearAllOnSingleSelection"] = "1";
            oc_Newobject1["showRoot"] = "0";
            oc_Newobject1["internalNamesOnly"] = "1";
            oc_Newobject1["objectNamesOnly"] = "0";
            oc_Newobject1["useInspectorTooltips"] = "0";
            oc_Newobject1["tooltipOnWidthOnly"] = "0";
            oc_Newobject1["compareToObjectID"] = "1";
            oc_Newobject1["canRenameObjects"] = "1";
            oc_Newobject1["renameInternal"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "1 1";
            oc_Newobject1["Extent"] = "208 2";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiTabPageCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject6["fitBook"] = "0";
            oc_Newobject6["text"] = "Meshes";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Docking"] = "Client";
            oc_Newobject6["Margin"] = "-1 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "0 22";
            oc_Newobject6["Extent"] = "210 183";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["internalName"] = "MeshesTab";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject5["willFirstRespond"] = "1";
            oc_Newobject5["hScrollBar"] = "alwaysOff";
            oc_Newobject5["vScrollBar"] = "dynamic";
            oc_Newobject5["lockHorizScroll"] = new Creator.StringNoQuote("true");
            oc_Newobject5["lockVertScroll"] = "0";
            oc_Newobject5["constantThumbHeight"] = "0";
            oc_Newobject5["childMargin"] = "0 0";
            oc_Newobject5["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject5["Docking"] = "Client";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "210 194";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (ForestEditMeshTree)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTreeViewCtrl", "ForestEditMeshTree", typeof (ForestEditMeshTree));
            oc_Newobject4["tabSize"] = "16";
            oc_Newobject4["textOffset"] = "2";
            oc_Newobject4["fullRowSelect"] = "0";
            oc_Newobject4["itemHeight"] = "21";
            oc_Newobject4["destroyTreeOnSleep"] = "1";
            oc_Newobject4["MouseDragging"] = "0";
            oc_Newobject4["MultipleSelections"] = "0";
            oc_Newobject4["DeleteObjectAllowed"] = "0";
            oc_Newobject4["DragToItemAllowed"] = "0";
            oc_Newobject4["ClearAllOnSingleSelection"] = "1";
            oc_Newobject4["showRoot"] = "0";
            oc_Newobject4["internalNamesOnly"] = "0";
            oc_Newobject4["objectNamesOnly"] = "1";
            oc_Newobject4["useInspectorTooltips"] = "0";
            oc_Newobject4["tooltipOnWidthOnly"] = "0";
            oc_Newobject4["compareToObjectID"] = "1";
            oc_Newobject4["canRenameObjects"] = "1";
            oc_Newobject4["renameInternal"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "1 -67";
            oc_Newobject4["Extent"] = "208 2";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["AltCommand"] = "$ThisControl.onDoubleClick();";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject15["#Newobject7"] = oc_Newobject7;

            #region GuiStackControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject10["StackingType"] = "Horizontal";
            oc_Newobject10["HorizStacking"] = "Left to Right";
            oc_Newobject10["VertStacking"] = "Top to Bottom";
            oc_Newobject10["Padding"] = "3";
            oc_Newobject10["DynamicSize"] = "1";
            oc_Newobject10["ChangeChildSizeToFit"] = "0";
            oc_Newobject10["ChangeChildPosition"] = "0";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "left";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "170 25";
            oc_Newobject10["Extent"] = "35 17";
            oc_Newobject10["MinExtent"] = "16 16";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "0";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["internalName"] = "MeshButtonGroup";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["bitmap"] = "tools/forestEditor/images/new-mesh";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "left";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "16 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "ForestEditorGui.newMesh();";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Add New Mesh";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["bitmap"] = "tools/gui/images/delete";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "19 0";
            oc_Newobject9["Extent"] = "16 16";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "ForestEditorGui.deleteMesh();";
            oc_Newobject9["tooltip"] = "Delete Selected";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject15["#Newobject10"] = oc_Newobject10;

            #region GuiStackControl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject14["StackingType"] = "Horizontal";
            oc_Newobject14["HorizStacking"] = "Left to Right";
            oc_Newobject14["VertStacking"] = "Top to Bottom";
            oc_Newobject14["Padding"] = "3";
            oc_Newobject14["DynamicSize"] = "1";
            oc_Newobject14["ChangeChildSizeToFit"] = "0";
            oc_Newobject14["ChangeChildPosition"] = "0";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "left";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "151 25";
            oc_Newobject14["Extent"] = "54 17";
            oc_Newobject14["MinExtent"] = "16 16";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["internalName"] = "BrushButtonGroup";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #region GuiBitmapButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject11["bitmap"] = "tools/forestEditor/images/new-brush";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "left";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "0 0";
            oc_Newobject11["Extent"] = "16 16";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "ForestEditorGui.newBrush();";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["ToolTip"] = "Add New Brush Group";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject12["bitmap"] = "tools/forestEditor/images/new-element";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["useMouseEvents"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "19 0";
            oc_Newobject12["Extent"] = "16 16";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "ForestEditorGui.newElement();";
            oc_Newobject12["tooltip"] = "Add New Brush Element";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject13["bitmap"] = "tools/gui/images/delete";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "38 0";
            oc_Newobject13["Extent"] = "16 16";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "ForestEditorGui.deleteBrushOrElement();";
            oc_Newobject13["tooltip"] = "Delete Selected";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject19["#Newobject15"] = oc_Newobject15;

            #region GuiWindowCollapseCtrl (ForestEditorPropertiesWindow)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiWindowCollapseCtrl", "ForestEditorPropertiesWindow", typeof (ForestEditorPropertiesWindow));
            oc_Newobject18["internalName"] = "ForestEditorPropertiesWindow";
            oc_Newobject18["AllowPopWindow"] = "1";
            oc_Newobject18["CollapseGroup"] = "-1";
            oc_Newobject18["CollapseGroupNum"] = "-1";
            oc_Newobject18["resizeWidth"] = "1";
            oc_Newobject18["resizeHeight"] = "1";
            oc_Newobject18["canMove"] = "1";
            oc_Newobject18["canClose"] = "0";
            oc_Newobject18["canMinimize"] = "0";
            oc_Newobject18["canMaximize"] = "0";
            oc_Newobject18["minSize"] = "50 50";
            oc_Newobject18["EdgeSnap"] = "1";
            oc_Newobject18["text"] = "Properties";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "ToolsGuiWindowCollapseProfile";
            oc_Newobject18["HorizSizing"] = "windowRelative";
            oc_Newobject18["VertSizing"] = "windowRelative";
            oc_Newobject18["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) + getWord(ForestEditorPalleteWindow.extent, 1) - 2");
            oc_Newobject18["Extent"] = "210 460";
            oc_Newobject18["MinExtent"] = "210 50";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject17["willFirstRespond"] = "1";
            oc_Newobject17["hScrollBar"] = "alwaysOff";
            oc_Newobject17["vScrollBar"] = "dynamic";
            oc_Newobject17["lockHorizScroll"] = new Creator.StringNoQuote("true");
            oc_Newobject17["lockVertScroll"] = "0";
            oc_Newobject17["constantThumbHeight"] = "0";
            oc_Newobject17["childMargin"] = "0 0";
            oc_Newobject17["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject17["Docking"] = "Client";
            oc_Newobject17["Margin"] = "3 1 3 3";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "3 23";
            oc_Newobject17["Extent"] = "210 263";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #region GuiInspector (ForestEditorInspector)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiInspector", "ForestEditorInspector", typeof (ForestEditorInspector));
            oc_Newobject16["dividerMargin"] = "5";
            oc_Newobject16["showCustomFields"] = "0";
            oc_Newobject16["StackingType"] = "Vertical";
            oc_Newobject16["HorizStacking"] = "Left to Right";
            oc_Newobject16["VertStacking"] = "Top to Bottom";
            oc_Newobject16["Padding"] = "1";
            oc_Newobject16["DynamicSize"] = "1";
            oc_Newobject16["ChangeChildSizeToFit"] = "1";
            oc_Newobject16["ChangeChildPosition"] = "1";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "GuiInspectorProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "height";
            oc_Newobject16["position"] = "1 1";
            oc_Newobject16["Extent"] = "193 16";
            oc_Newobject16["MinExtent"] = "16 16";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["internalName"] = "Inspector";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject19.Create();
        }

        // ForestEditorGui Script Methods
        [ConsoleInteraction]
        public void setActiveTool(string tool)
        {
            SimSet ForestTools = "ForestTools";
            ForestBrushTool BrushTool = ForestTools.FOF("BrushTool");
            ForestEditTabBook ForestEditTabBook = "ForestEditTabBook";

            if (tool.getID() == BrushTool.getId())
                ForestEditTabBook.selectPage(0);

            base.setActiveTool(tool);
        }

        public override void onActiveForestUpdated(string forest, string createNew)
        {
            bool gotForest = forest.isObject();

            // Give the user a chance to add a forest.
            if (!gotForest && createNew.AsBool())
                {
                messageBox.MessageBoxYesNo("Forest", "There is not a Forest in this mission.  Do you want to add one?", this + ".createForest();", "");
                return;
                }
        }

        /// Called from a message box when a forest is not found.
        [ConsoleInteraction]
        public void createForest()
        {
            //Forest theForest = "theForest";
            ForestEditorInspector ForestEditorInspector = "ForestEditorInspector";
            EWorldEditor EWorldEditor = "EWorldEditor";

            //ASWIN... bad Aswin...
            //if ( Util._isObject( theForest ) )
            if ("theForest".isObject())
                {
                Util._error("Cannot create a second 'theForest' Forest!");
                return;
                }

            // Allocate the Forest and make it undoable.

            ObjectCreator ocf = new ObjectCreator("Forest", "theForest");
            ocf["dataFile"] = "";
            ocf["parentGroup"] = "MissionGroup";
            Forest theForest = ocf.Create();

            Extendable.MECreateUndoAction.submit(theForest);

            ForestEditorInspector.inspect(theForest);

            EWorldEditor.isDirty = true;
        }

        [ConsoleInteraction]
        public void newBrush()
        {
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

            string internalName = Util.getUniqueInternalName("Brush", ForestBrushGroup, true);

            ObjectCreator brushCreator = new ObjectCreator("ForestBrush");
            brushCreator["internalName"] = internalName;
            brushCreator["parentGroup"] = ForestBrushGroup;

            ForestBrush brush = brushCreator.Create();

            Extendable.MECreateUndoAction.submit(brush);

            ForestEditBrushTree.open(ForestBrushGroup);
            ForestEditBrushTree.buildVisibleTree(true);
            SimObject item = ForestEditBrushTree.findItemByObjectId(brush);
            ForestEditBrushTree.clearSelection();
            ForestEditBrushTree.addSelection(item, false);
            ForestEditBrushTree.scrollVisible(item);

            ForestEditorPlugin["dirty"] = true.AsString();
        }

        [ConsoleInteraction]
        public void newElement()
        {
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

            string parentGroup;

            SimObject sel = ForestEditBrushTree.getSelectedObject();

            if (!sel.isObject())
                parentGroup = ForestBrushGroup;
            else
                {
                if (sel.getClassName() == "ForestBrushElement")
                    parentGroup = sel["parentGroup"];
                else
                    parentGroup = sel;
                }

            string internalName = Util.getUniqueInternalName("Element", ForestBrushGroup, true);

            ObjectCreator elementCreator = new ObjectCreator("ForestBrushElement");
            elementCreator["internalName"] = internalName;
            elementCreator["parentGroup"] = parentGroup;

            ForestBrushElement element = elementCreator.Create();

            Extendable.MECreateUndoAction.submit(element);

            ForestEditBrushTree.clearSelection();
            ForestEditBrushTree.buildVisibleTree(true);
            SimObject item = ForestEditBrushTree.findItemByObjectId(element.getId());
            ForestEditBrushTree.scrollVisible(item);
            ForestEditBrushTree.addSelection(item, false);

            ForestEditorPlugin["dirty"] = true.AsString();
        }

        [ConsoleInteraction]
        public void deleteBrushOrElement()
        {
            ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

            ForestEditBrushTree.deleteSelection();
            ForestEditorPlugin["dirty"] = true.AsString();
        }

        [ConsoleInteraction]
        public void newMesh()
        {
            ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";
            ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            PersistenceManager ForestDataManager = "ForestDataManager";
            SimGroup ForestBrushGroup = "ForestBrushGroup";
            editor Editor = "Editor";
            ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

            const string spec = "All Mesh Files|*.dts;*.dae|DTS|*.dts|DAE|*.dae";

            string fullPath = "", file = "";

            OpenFileDialog fd = new OpenFileDialog {Filter = spec, InitialDirectory = sGlobal["$Pref::WorldEditor::LastPath"], FileName = ""};

            DialogResult dr = Dialogs.OpenFileDialog(ref fd);
            switch (dr)
                {
                    case DialogResult.OK:
                        string fileName = Dialogs.GetForwardSlashFile(fd.FileName);

                        sGlobal["$Pref::WorldEditor::LastPath"] = Util.filePath(fileName);
                        fullPath = Util.makeRelativePath(fileName, Util.getMainDotCsDir());
                        file = Util.fileBase(fullPath);
                        break;
                    case DialogResult.Abort:
                    case DialogResult.Ignore:
                    case DialogResult.No:
                    case DialogResult.Cancel:
                    case DialogResult.None:
                        return;
                }

            string name = Util.getUniqueName(file);

            string str = "datablock TSForestItemData( " + name + " ) { shapeFile = \"" + fullPath + "\"; };";
            Util.eval(str);

            TSForestItemData itemData = name;

            if (itemData.isObject())
                {
                ForestEditMeshTree.clearSelection();
                ForestEditMeshTree.buildVisibleTree(true);
                SimObject item = ForestEditMeshTree.findItemByObjectId(itemData.getId());
                ForestEditMeshTree.scrollVisible(item);
                ForestEditMeshTree.addSelection(item, false);

                ForestDataManager.setDirty(itemData.getName(), "art/forest/managedItemData.cs");

                ObjectCreator elementCreator = new ObjectCreator("ForestBrushElement");
                elementCreator["internalName"] = itemData.getName();
                elementCreator["forestItemData"] = itemData;
                elementCreator["parentGroup"] = ForestBrushGroup;

                ForestBrushElement element = elementCreator.Create();

                ForestEditBrushTree.clearSelection();
                ForestEditBrushTree.buildVisibleTree(true);
                item = ForestEditBrushTree.findItemByObjectId(element.getId());
                ForestEditBrushTree.scrollVisible(item);
                ForestEditBrushTree.addSelection(item, false);

                Util.pushInstantGroup();
                ObjectCreator actionCreator = new ObjectCreator("MECreateUndoAction");
                actionCreator["actionName"] = "Create TSForestItemData";

                MECreateUndoAction action = actionCreator.Create();
                Util.popInstantGroup();

                action.addObject(itemData);
                action.addObject(element);
                action.addToManager(Editor.getUndoManager());

                ForestEditorPlugin["dirty"] = true.AsString();
                }
        }

        [ConsoleInteraction]
        public void deleteMesh()
        {
            ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";

            SimObject obj = ForestEditMeshTree.getSelectedObject();

            // Can't delete itemData's that are in use without
            // crashing at the moment...

            if (obj.isObject())
                messageBox.MessageBoxOKCancel("Warning", "Deleting this mesh will also delete BrushesElements and ForestItems referencing it.", "ForestEditorGui.okDeleteMesh(" + obj + ");", "");
        }

        [ConsoleInteraction]
        public void okDeleteMesh(string mesh)
        {
            ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";
            ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
            PersistenceManager ForestDataManager = "ForestDataManager";

            ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";
            // Remove mesh from file
            ForestDataManager.removeObjectFromFile(mesh, "art/forest/managedItemData.cs");

            // Submitting undo actions is handled in code.
            this.deleteMeshSafe(mesh);

            // Update TreeViews.
            ForestEditBrushTree.buildVisibleTree(true);
            ForestEditMeshTree.buildVisibleTree(true);

            ForestEditorPlugin["dirty"] = true.AsString();
        }

        [ConsoleInteraction]
        public void validateBrushSize()
        {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            int minBrushSize = 1;
            string maxBrushSize = Util.getWord(ETerrainEditor["maxBrushSize"], 0);

            string val = "$ThisControl.getText()";
            Util.eval(val);
            if (val.AsInt() < minBrushSize)
                Util.eval("$ThisControl.setValue(minBrushSize)");
            else if (val.AsInt() > maxBrushSize.AsInt())
                Util.eval("$ThisControl.setValue(maxBrushSize)");
        }

        [TypeConverter(typeof (ForestBrushSizeSliderCtrlContainer))]
        public class ForestBrushSizeSliderCtrlContainer : EditorGui.EditorDropdownSliderContainer
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiControl ForestBrushSizeTextEditContainer = "ForestBrushSizeTextEditContainer";
                TerrainEditor ETerrainEditor = "ETerrainEditor";

                GuiSliderCtrl slider = this.FOT("slider");
                GuiTextEditCtrl textEdit = ForestBrushSizeTextEditContainer.FOT("textEdit");

                slider["range"] = "1" + ' ' + Util.getWord(ETerrainEditor["maxBrushSize"], 0);
                slider.setValue(textEdit.getValue());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestBrushSizeSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(ForestBrushSizeSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(ForestBrushSizeSliderCtrlContainer ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestBrushSizeSliderCtrlContainer(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestBrushSizeSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (ForestBrushSizeSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestBrushSizeSliderCtrlContainer ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestBrushSizeSliderCtrlContainer(int simobjectid)
            {
                return (ForestBrushSizeSliderCtrlContainer) Omni.self.getSimObject((uint) simobjectid, typeof (ForestBrushSizeSliderCtrlContainer));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestBrushSizeSliderCtrlContainer ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestBrushSizeSliderCtrlContainer(uint simobjectid)
            {
                return (ForestBrushSizeSliderCtrlContainer) Omni.self.getSimObject(simobjectid, typeof (ForestBrushSizeSliderCtrlContainer));
            }

            #endregion
        }

        [TypeConverter(typeof (ForestEditBrushTree))]
        public class ForestEditBrushTree : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onDeleteSelection()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

                string list = this.getSelectedObjectList();

                Extendable.MEDeleteUndoAction.submit(list, true);

                ForestEditorPlugin["dirty"] = true.AsString();
            }

            [ConsoleInteraction]
            public override void onRemoveSelection(int obj)
            {
                SimSet ForestTools = "ForestTools";
                ForestBrushTool BrushTool = ForestTools.FOF("BrushTool");
                ForestEditorInspector ForestEditorInspector = "ForestEditorInspector";

                this.buildVisibleTree(true);
                BrushTool.collectElements();

                if (this.getSelectedItemsCount() == 1)
                    ForestEditorInspector.inspect(obj);
                else
                    ForestEditorInspector.inspect("");
            }

            [ConsoleInteraction]
            public override void onAddSelection(int obj, bool isLastSelection)
            {
                SimSet ForestTools = "ForestTools";
                ForestBrushTool BrushTool = ForestTools.FOF("BrushTool");
                ForestEditorInspector ForestEditorInspector = "ForestEditorInspector";

                this.buildVisibleTree(true);
                BrushTool.collectElements();

                if (this.getSelectedItemsCount() == 1)
                    ForestEditorInspector.inspect(obj);
                else
                    ForestEditorInspector.inspect("");
            }

            [ConsoleInteraction]
            public override void onDragDropped()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";
                ForestEditorPlugin["dirty"] = true.AsString();
            }

            [ConsoleInteraction]
            public override bool handleRenameObject(string name, SimObject obj)
            {
                SimGroup ForestBrushGroup = "ForestBrushGroup";
                EWorldEditor EWorldEditor = "EWorldEditor";
                editor Editor = "Editor";

                if (name != "")
                    {
                    string found = ForestBrushGroup.findObjectByInternalName(name, false);
                    if (found.isObject() && found.getID() != obj.getId())
                        {
                        messageBox.MessageBoxOK("Error", "Brush or Element with that name already exists.", "");

                        // true as in, we handled it, don't rename the object.      
                        return true;
                        }
                    }
                // Since we aren't showing any groups whens inspecting a ForestBrushGroup
                // we can't push this event off to the inspector to handle.

                //return GuiTreeViewCtrl::handleRenameObject( this, name, obj );      

                // The instant group will try to add our
                // UndoAction if we don't disable it.   
                Util.pushInstantGroup();

                string nameOrClass = obj.getName();
                if (nameOrClass == "")
                    nameOrClass = obj.getClassName();

                ObjectCreator actionCreator = new ObjectCreator("InspectorFieldUndoAction");
                actionCreator["actionName"] = nameOrClass + "." + "internalName" + " Change";
                actionCreator["objectId"] = obj.getId().AsString();
                actionCreator["fieldName"] = "internalName";
                actionCreator["fieldValue"] = obj["internalName"];
                actionCreator["arrayIndex"] = "0";

                actionCreator["inspectorGui"] = "";

                InspectorFieldUndoAction action = actionCreator.Create();

                // Restore the instant group.
                Util.popInstantGroup();

                action.addToManager(Editor.getUndoManager());
                EWorldEditor.isDirty = true;

                return false;
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestEditBrushTree ts, string simobjectid)
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
            public static bool operator !=(ForestEditBrushTree ts, string simobjectid)
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
            public static implicit operator string(ForestEditBrushTree ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestEditBrushTree(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestEditBrushTree) Omni.self.getSimObject(simobjectid, typeof (ForestEditBrushTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestEditBrushTree ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestEditBrushTree(int simobjectid)
            {
                return (ForestEditBrushTree) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditBrushTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestEditBrushTree ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestEditBrushTree(uint simobjectid)
            {
                return (ForestEditBrushTree) Omni.self.getSimObject(simobjectid, typeof (ForestEditBrushTree));
            }

            #endregion
        }

        // Child-control Script Methods
        [TypeConverter(typeof (ForestEditMeshTree))]
        public class ForestEditMeshTree : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onSelect(string x, string y)
            {
                ForestEditorInspector ForestEditorInspector = "ForestEditorInspector";

                ForestEditorInspector.inspect(x);
            }

            [ConsoleInteraction]
            public override void onDragDropped()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

                ForestEditorPlugin["dirty"] = true.AsString();
            }

            [ConsoleInteraction]
            public override bool onDeleteObject(SimObject objectx)
            {
                // return true - skip delete.
                return true;
            }

            [ConsoleInteraction]
            public void onDoubleClick()
            {
                SimGroup ForestBrushGroup = "ForestBrushGroup";
                ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

                SimObject obj = this.getSelectedObject();

                string name = Util.getUniqueInternalName(obj.getName(), ForestBrushGroup, true);

                ObjectCreator elementCreator = new ObjectCreator("ForestBrushElement");
                elementCreator["internalName"] = name;
                elementCreator["forestItemData"] = obj.getName();
                elementCreator["parentGroup"] = ForestBrushGroup;

                ForestBrushElement element = elementCreator.Create();

                //ForestDataManager.setDirty( element, "art/forest/brushes.cs" );                 

                ForestEditBrushTree.clearSelection();
                ForestEditBrushTree.buildVisibleTree(true);
                SimObject item = ForestEditBrushTree.findItemByObjectId(element);
                ForestEditBrushTree.scrollVisible(item);
                ForestEditBrushTree.addSelection(item, false);

                ForestEditorPlugin["dirty"] = true.AsString();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestEditMeshTree ts, string simobjectid)
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
            public static bool operator !=(ForestEditMeshTree ts, string simobjectid)
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
            public static implicit operator string(ForestEditMeshTree ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestEditMeshTree(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestEditMeshTree) Omni.self.getSimObject(simobjectid, typeof (ForestEditMeshTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestEditMeshTree ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestEditMeshTree(int simobjectid)
            {
                return (ForestEditMeshTree) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditMeshTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestEditMeshTree ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestEditMeshTree(uint simobjectid)
            {
                return (ForestEditMeshTree) Omni.self.getSimObject(simobjectid, typeof (ForestEditMeshTree));
            }

            #endregion
        }

        [TypeConverter(typeof (ForestEditTabBook))]
        public class ForestEditTabBook : GuiTabBookCtrl
        {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
            {
                ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";
                ForestEditorInspector ForestEditorInspector = "ForestEditorInspector";
                ForestEditBrushTree ForestEditBrushTree = "ForestEditBrushTree";
                ForestEditMeshTree ForestEditMeshTree = "ForestEditMeshTree";

                GuiStackControl bbg = ForestEditorPalleteWindow.findObjectByInternalName("BrushButtonGroup", false);
                GuiStackControl mbg = ForestEditorPalleteWindow.findObjectByInternalName("MeshButtonGroup", false);

                bbg.setVisible(false);
                mbg.setVisible(false);

                SimObject obj;
                if (text == "Brushes")
                    {
                    bbg.setVisible(true);
                    obj = ForestEditBrushTree.getSelectedObject();
                    ForestEditorInspector.inspect(obj);
                    }
                else if (text == "Meshes")
                    {
                    mbg.setVisible(true);
                    obj = ForestEditMeshTree.getSelectedObject();
                    ForestEditorInspector.inspect(obj);
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestEditTabBook ts, string simobjectid)
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
            public static bool operator !=(ForestEditTabBook ts, string simobjectid)
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
            public static implicit operator string(ForestEditTabBook ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestEditTabBook(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestEditTabBook) Omni.self.getSimObject(simobjectid, typeof (ForestEditTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestEditTabBook ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestEditTabBook(int simobjectid)
            {
                return (ForestEditTabBook) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestEditTabBook ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestEditTabBook(uint simobjectid)
            {
                return (ForestEditTabBook) Omni.self.getSimObject(simobjectid, typeof (ForestEditTabBook));
            }

            #endregion
        }

        [TypeConverter(typeof (ForestEditorInspector))]
        public class ForestEditorInspector : GuiInspector
        {
            [ConsoleInteraction]
            public void inspect(SimObject obj)
            {
                string className = "";
                if (obj.isObject())
                    className = obj.getClassName();

                this["showObjectName"] = false.AsString();
                this["showCustomFields"] = false.AsString();

                switch (className)
                    {
                        case "ForestBrush":
                            this["groupFilters"] = "+NOTHING,-Ungrouped";
                            break;

                        case "ForestBrushElement":
                            this["groupFilters"] = "+ForestBrushElement,-Ungrouped";
                            break;

                        case "TSForestItemData":
                            this["groupFilters"] = "+Media,+Wind";
                            break;

                        default:
                            this["groupFilters"] = "";
                            break;
                    }

                base.inspect(obj);
            }

            [ConsoleInteraction]
            public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
            {
                SimObject obj = objectx;
                editor Editor = "Editor";
                PersistenceManager ForestDataManager = "ForestDataManager";
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

                // The instant group will try to add our
                // UndoAction if we don't disable it.   
                int instantGroup = iGlobal["$InstantGroup"];
                iGlobal["$InstantGroup"] = 0;

                string nameOrClass = obj.getName();
                if (nameOrClass == "")
                    nameOrClass = obj.getClassName();

                ObjectCreator actionCreator = new ObjectCreator("InspectorFieldUndoAction");
                actionCreator["actionName"] = nameOrClass + "." + fieldName + " Change";
                actionCreator["objectId"] = obj.getId().AsString();
                actionCreator["fieldName"] = fieldName;
                actionCreator["fieldValue"] = oldValue;
                actionCreator["inspectorGui"] = this;

                InspectorFieldUndoAction action = actionCreator.Create();

                // Restore the instant group.
                iGlobal["$InstantGroup"] = instantGroup;

                action.addToManager(Editor.getUndoManager());

                if (obj.getClassName() == "TSForestItemData")
                    ForestDataManager.setDirty(objectx);

                ForestEditorPlugin["dirty"] = true.AsString();
            }

            [ConsoleInteraction]
            public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
            {
                //FieldInfoControl.setText( "<font:ArialBold:14>" @ fieldName @ "<font:ArialItalic:14> (" @ fieldTypeStr @ ") " NL "<font:Arial:14>" @ fieldDoc );
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestEditorInspector ts, string simobjectid)
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
            public static bool operator !=(ForestEditorInspector ts, string simobjectid)
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
            public static implicit operator string(ForestEditorInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestEditorInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestEditorInspector) Omni.self.getSimObject(simobjectid, typeof (ForestEditorInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestEditorInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestEditorInspector(int simobjectid)
            {
                return (ForestEditorInspector) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditorInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestEditorInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestEditorInspector(uint simobjectid)
            {
                return (ForestEditorInspector) Omni.self.getSimObject(simobjectid, typeof (ForestEditorInspector));
            }

            #endregion
        }

        [TypeConverter(typeof (ForestEditorPalleteWindow))]
        public class ForestEditorPalleteWindow : GuiWindowCollapseCtrl
        {
            [ConsoleInteraction]
            public override void onPopWindow()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

                EditorGui.DeactivateAll();
                ForestEditorPlugin.onActivated();
            }

            [ConsoleInteraction]
            public override void onPopWindowClosed()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";
                ForestEditorPropertiesWindow ForestEditorPropertiesWindow = "ForestEditorPropertiesWindow";

                EditorGui.DeactivateAll();
                ForestEditorPlugin.onActivated();
                this.attachTo(ForestEditorPropertiesWindow);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestEditorPalleteWindow ts, string simobjectid)
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
            public static bool operator !=(ForestEditorPalleteWindow ts, string simobjectid)
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
            public static implicit operator string(ForestEditorPalleteWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestEditorPalleteWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestEditorPalleteWindow) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPalleteWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestEditorPalleteWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestEditorPalleteWindow(int simobjectid)
            {
                return (ForestEditorPalleteWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditorPalleteWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestEditorPalleteWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestEditorPalleteWindow(uint simobjectid)
            {
                return (ForestEditorPalleteWindow) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPalleteWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (ForestEditorPropertiesWindow))]
        public class ForestEditorPropertiesWindow : GuiWindowCollapseCtrl
        {
            [ConsoleInteraction]
            public override void onPopWindow()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";

                EditorGui.DeactivateAll();
                ForestEditorPlugin.onActivated();
            }

            [ConsoleInteraction]
            public override void onPopWindowClosed()
            {
                ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";
                ForestEditorPalleteWindow ForestEditorPalleteWindow = "ForestEditorPalleteWindow";

                EditorGui.DeactivateAll();
                ForestEditorPlugin.onActivated();
                this.attachTo(ForestEditorPalleteWindow);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ForestEditorPropertiesWindow ts, string simobjectid)
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
            public static bool operator !=(ForestEditorPropertiesWindow ts, string simobjectid)
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
            public static implicit operator string(ForestEditorPropertiesWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ForestEditorPropertiesWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ForestEditorPropertiesWindow) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPropertiesWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ForestEditorPropertiesWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ForestEditorPropertiesWindow(int simobjectid)
            {
                return (ForestEditorPropertiesWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditorPropertiesWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ForestEditorPropertiesWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ForestEditorPropertiesWindow(uint simobjectid)
            {
                return (ForestEditorPropertiesWindow) Omni.self.getSimObject(simobjectid, typeof (ForestEditorPropertiesWindow));
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
        public static bool operator ==(ForestEditorGui ts, string simobjectid)
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
        public static bool operator !=(ForestEditorGui ts, string simobjectid)
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
        public static implicit operator string(ForestEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ForestEditorGui) Omni.self.getSimObject(simobjectid, typeof (ForestEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ForestEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ForestEditorGui(int simobjectid)
        {
            return (ForestEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (ForestEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ForestEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ForestEditorGui(uint simobjectid)
        {
            return (ForestEditorGui) Omni.self.getSimObject(simobjectid, typeof (ForestEditorGui));
        }

        #endregion
    }
}