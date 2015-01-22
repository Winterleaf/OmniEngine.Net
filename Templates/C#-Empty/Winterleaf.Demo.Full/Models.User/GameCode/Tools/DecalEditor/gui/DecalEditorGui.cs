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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<DecalEditorGui>))]
    public class DecalEditorGui : GuiDecalEditorCtrl
    {
        [ConsoleInteraction(true, "DecalEditorGui_initialize")]
        public static void initialize()
        {
            #region GuiDecalEditorCtrl (DecalEditorGui)        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiDecalEditorCtrl", "DecalEditorGui", typeof (DecalEditorGui));
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["Enabled"] = "1";
            oc_Newobject45["isContainer"] = "1";
            oc_Newobject45["Profile"] = "WorldEditorProfile";
            oc_Newobject45["HorizSizing"] = "width";
            oc_Newobject45["VertSizing"] = "height";
            oc_Newobject45["Position"] = "0 0";
            oc_Newobject45["Extent"] = "800 600";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["isDecoy"] = "0";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["Margin"] = "0 0 0 0";
            oc_Newobject45["Padding"] = "0 0 0 0";
            oc_Newobject45["AnchorTop"] = "1";
            oc_Newobject45["AnchorBottom"] = "0";
            oc_Newobject45["AnchorLeft"] = "1";
            oc_Newobject45["AnchorRight"] = "0";
            oc_Newobject45["cameraZRot"] = "0";
            oc_Newobject45["forceFOV"] = "0";
            oc_Newobject45["renderMissionArea"] = "0";
            oc_Newobject45["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject45["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject45["allowBorderMove"] = "0";
            oc_Newobject45["borderMovePixelSize"] = "20";
            oc_Newobject45["borderMoveSpeed"] = "0.1";
            oc_Newobject45["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject45["consoleFillColor"] = "255 0 0 120";
            oc_Newobject45["consoleSphereLevel"] = "1";
            oc_Newobject45["consoleCircleSegments"] = "32";
            oc_Newobject45["consoleLineWidth"] = "1";
            oc_Newobject45["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject45["currentDecalID"] = "175";
            oc_Newobject45["Docking"] = "None";

            #region GuiWindowCollapseCtrl (DecalEditorWindow)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiWindowCollapseCtrl", "DecalEditorWindow", typeof (DecalEditorWindow));
            oc_Newobject16["AllowPopWindow"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject16["HorizSizing"] = "windowRelative";
            oc_Newobject16["VertSizing"] = "windowRelative";
            oc_Newobject16["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1) -1");
            oc_Newobject16["Extent"] = "210 600";
            oc_Newobject16["MinExtent"] = "210 100";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["isDecoy"] = "0";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "2 2 2 2";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["resizeWidth"] = "1";
            oc_Newobject16["resizeHeight"] = "1";
            oc_Newobject16["canMove"] = "1";
            oc_Newobject16["canClose"] = "0";
            oc_Newobject16["canMinimize"] = "0";
            oc_Newobject16["canMaximize"] = "0";
            oc_Newobject16["minSize"] = "50 50";
            oc_Newobject16["closeCommand"] = "EditorGui.setEditor( WorldEditorInspectorPlugin );";
            oc_Newobject16["EdgeSnap"] = "1";
            oc_Newobject16["text"] = "Decal Editor";

            #region GuiTabBookCtrl (DecalEditorTabBook)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTabBookCtrl", "DecalEditorTabBook", typeof (DecalEditorTabBook));
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "height";
            oc_Newobject11["position"] = "0 0";
            oc_Newobject11["Extent"] = "202 502";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "3 1 3 3";
            oc_Newobject11["Docking"] = "client";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["TabPosition"] = "Top";
            oc_Newobject11["TabMargin"] = "0";
            oc_Newobject11["MinTabWidth"] = "64";

            #region GuiTabPageCtrl (LibraryTabControl)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTabPageCtrl", "LibraryTabControl");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "202 483";
            oc_Newobject5["Docking"] = "client";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "-1 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Library";
            oc_Newobject5["maxLength"] = "1024";

            #region GuiContainer ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiContainer", "");
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "202 483";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Docking"] = "client";
            oc_Newobject2["MinExtent"] = "0 8";
            oc_Newobject2["Profile"] = "GuiInspectorProfile";

            #region GuiBitmapBorderCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["Position"] = "0 0";
            oc_Newobject1["Extent"] = "202 483";
            oc_Newobject1["MinExtent"] = "0 -500";
            oc_Newobject1["Profile"] = "ToolsGuiTabBorderProfile";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "202 483";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "alwaysOff";
            oc_Newobject4["vScrollBar"] = "dynamic";
            oc_Newobject4["lockHorizScroll"] = "true";
            oc_Newobject4["lockVertScroll"] = "false";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "0 0";

            #region GuiListBoxCtrl (DecalDataList)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiListBoxCtrl", "DecalDataList", typeof (DecalDataList));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiListBoxProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "474 48";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["AllowMultipleSelections"] = "0";
            oc_Newobject3["fitParentWidth"] = "0";
            oc_Newobject3["mirrorSet"] = "DecalDataSet";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject11["#Newobject5"] = oc_Newobject5;

            #region GuiTabPageCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "instanceTab";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "height";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["Extent"] = "202 483";
            oc_Newobject10["Docking"] = "client";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "-1 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["text"] = "Instances";
            oc_Newobject10["maxLength"] = "1024";

            #region GuiContainer ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiContainer", "");
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "height";
            oc_Newobject7["Position"] = "0 0";
            oc_Newobject7["Extent"] = "202 483";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Docking"] = "client";
            oc_Newobject7["MinExtent"] = "0 8";
            oc_Newobject7["Profile"] = "GuiInspectorProfile";

            #region GuiBitmapBorderCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "202 483";
            oc_Newobject6["MinExtent"] = "0 -500";
            oc_Newobject6["Profile"] = "ToolsGuiTabBorderProfile";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiScrollCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "height";
            oc_Newobject9["Position"] = "0 0";
            oc_Newobject9["Extent"] = "202 483";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["isDecoy"] = "0";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Docking"] = "None";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "0";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "0";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["willFirstRespond"] = "1";
            oc_Newobject9["hScrollBar"] = "alwaysOff";
            oc_Newobject9["vScrollBar"] = "dynamic";
            oc_Newobject9["lockHorizScroll"] = "true";
            oc_Newobject9["lockVertScroll"] = "false";
            oc_Newobject9["constantThumbHeight"] = "0";
            oc_Newobject9["childMargin"] = "0 0";

            #region GuiTreeViewCtrl (DecalEditorTreeView)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTreeViewCtrl", "DecalEditorTreeView", typeof (DecalEditorTreeView));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "1 1";
            oc_Newobject8["Extent"] = "200 100";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["tabSize"] = "16";
            oc_Newobject8["textOffset"] = "2";
            oc_Newobject8["fullRowSelect"] = "0";
            oc_Newobject8["itemHeight"] = "21";
            oc_Newobject8["destroyTreeOnSleep"] = "1";
            oc_Newobject8["MouseDragging"] = "0";
            oc_Newobject8["MultipleSelections"] = "0";
            oc_Newobject8["DeleteObjectAllowed"] = "1";
            oc_Newobject8["DragToItemAllowed"] = "0";
            oc_Newobject8["showRoot"] = "0";
            oc_Newobject8["internalNamesOnly"] = "0";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject16["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapButtonCtrl (SaveDecalsButton)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "SaveDecalsButton");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "137 26";
            oc_Newobject12["Extent"] = "16 16";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["isDecoy"] = "0";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "DecalPMan.saveDirty(); DecalInspector::removeDirty();";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["text"] = "";
            oc_Newobject12["tooltip"] = "Save All";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["useMouseEvents"] = "0";
            oc_Newobject12["bitmap"] = "tools/gui/images/save-icon";

            #endregion

            oc_Newobject16["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl (RetargetDecalButton)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "RetargetDecalButton", typeof (RetargetDecalButton));
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "157 26";
            oc_Newobject13["Extent"] = "16 16";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["isDecoy"] = "0";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["tooltip"] = "Retarget missing decals to an existing decal datablock";
            oc_Newobject13["bitmap"] = "tools/gui/images/retarget-btn";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject13"] = oc_Newobject13;

            #region GuiBitmapButtonCtrl (NewDecalButton)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapButtonCtrl", "NewDecalButton", typeof (NewDecalButton));
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject14["HorizSizing"] = "left";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "177 26";
            oc_Newobject14["Extent"] = "16 16";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["isDecoy"] = "0";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["tooltip"] = "Create New Decal Template";
            oc_Newobject14["bitmap"] = "tools/gui/images/new";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapButtonCtrl (DeleteDecalButton)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapButtonCtrl", "DeleteDecalButton", typeof (DeleteDecalButton));
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject15["HorizSizing"] = "left";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "190 26";
            oc_Newobject15["Extent"] = "16 16";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["isDecoy"] = "0";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["text"] = "";
            oc_Newobject15["tooltip"] = "Delete Selected Decal Template";
            oc_Newobject15["bitmap"] = "tools/gui/images/delete";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";
            oc_Newobject15["tabSelected"] = "0";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject45["#Newobject16"] = oc_Newobject16;

            #region GuiWindowCollapseCtrl (DecalPreviewWindow)        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiWindowCollapseCtrl", "DecalPreviewWindow", typeof (DecalPreviewWindow));
            oc_Newobject44["AllowPopWindow"] = "1";
            oc_Newobject44["canSaveDynamicFields"] = "0";
            oc_Newobject44["internalName"] = "";
            oc_Newobject44["Enabled"] = "1";
            oc_Newobject44["isContainer"] = "1";
            oc_Newobject44["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject44["HorizSizing"] = "windowRelative";
            oc_Newobject44["VertSizing"] = "windowRelative";
            oc_Newobject44["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209 SPC getWord(EditorGuiToolbar.extent, 1) + getWord(DecalEditorWindow.extent, 1) - 2");
            oc_Newobject44["Extent"] = "210 335";
            oc_Newobject44["MinExtent"] = "210 335";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["Visible"] = "0";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["Docking"] = "None";
            oc_Newobject44["Margin"] = "0 0 0 0";
            oc_Newobject44["Padding"] = "0 0 0 0";
            oc_Newobject44["AnchorTop"] = "0";
            oc_Newobject44["AnchorBottom"] = "0";
            oc_Newobject44["AnchorLeft"] = "0";
            oc_Newobject44["AnchorRight"] = "0";
            oc_Newobject44["resizeWidth"] = "1";
            oc_Newobject44["resizeHeight"] = "1";
            oc_Newobject44["canMove"] = "1";
            oc_Newobject44["canClose"] = "0";
            oc_Newobject44["canMinimize"] = "0";
            oc_Newobject44["canMaximize"] = "0";
            oc_Newobject44["minSize"] = "152 235";
            oc_Newobject44["closeCommand"] = "TerrainPainter.parentGroup.setVisible(false);";
            oc_Newobject44["EdgeSnap"] = "1";
            oc_Newobject44["text"] = "Decal Properties";

            #region GuiScrollCtrl (DecalEditorTemplateProperties)        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiScrollCtrl", "DecalEditorTemplateProperties");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["Enabled"] = "1";
            oc_Newobject34["isContainer"] = "1";
            oc_Newobject34["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["HorizSizing"] = "width";
            oc_Newobject34["Position"] = "4 24";
            oc_Newobject34["Extent"] = "202 259";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["isDecoy"] = "0";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["AnchorTop"] = "0";
            oc_Newobject34["AnchorBottom"] = "0";
            oc_Newobject34["AnchorLeft"] = "0";
            oc_Newobject34["AnchorRight"] = "0";
            oc_Newobject34["willFirstRespond"] = "1";
            oc_Newobject34["Docking"] = "client";
            oc_Newobject34["Margin"] = "3 1 3 3";
            oc_Newobject34["hScrollBar"] = "alwaysOff";
            oc_Newobject34["vScrollBar"] = "dynamic";
            oc_Newobject34["lockHorizScroll"] = new Creator.StringNoQuote("true");
            oc_Newobject34["lockVertScroll"] = "false";
            oc_Newobject34["constantThumbHeight"] = "0";
            oc_Newobject34["childMargin"] = "0 0";

            #region GuiStackControl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject33["StackingType"] = "Vertical";
            oc_Newobject33["HorizStacking"] = "Left to Right";
            oc_Newobject33["VertStacking"] = "Top to Bottom";
            oc_Newobject33["Padding"] = "0";
            oc_Newobject33["isContainer"] = "1";
            oc_Newobject33["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject33["HorizSizing"] = "width";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["position"] = "0 0";
            oc_Newobject33["Extent"] = "189 0";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["isDecoy"] = "0";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject21["class"] = "BehaviorQuickEditRollout";
            oc_Newobject21["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject21["Profile"] = "GuiRolloutProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["Position"] = "0 0";
            oc_Newobject21["Extent"] = "208 0";
            oc_Newobject21["Caption"] = "Decal Instance Preview";
            oc_Newobject21["Margin"] = "0 0 0 -3";
            oc_Newobject21["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject21["container"] = new Creator.StringNoQuote("true");
            oc_Newobject21["parentRollout"] = new Creator.StringNoQuote("%this.rollout");
            oc_Newobject21["object"] = new Creator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject20["StackingType"] = "Vertical";
            oc_Newobject20["HorizStacking"] = "Left to Right";
            oc_Newobject20["VertStacking"] = "Top to Bottom";
            oc_Newobject20["Padding"] = "0";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject20["HorizSizing"] = "width";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["Extent"] = "208 0";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["isDecoy"] = "0";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiContainer", "");
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "-1 0";
            oc_Newobject19["Extent"] = "202 187";
            oc_Newobject19["Docking"] = "none";

            #region GuiBitmapCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "instancePreview";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "center";
            oc_Newobject17["VertSizing"] = "height";
            oc_Newobject17["Position"] = "0 0";
            oc_Newobject17["Extent"] = "188 186";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["isDecoy"] = "0";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["wrap"] = "0";
            oc_Newobject17["bitmap"] = "tools/materialeditor/gui/unknownImage";

            #endregion

            oc_Newobject19["#Newobject17"] = oc_Newobject17;

            #region GuiBitmapCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["HorizSizing"] = "center";
            oc_Newobject18["VertSizing"] = "height";
            oc_Newobject18["Position"] = "0 0";
            oc_Newobject18["Extent"] = "188 186";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["isDecoy"] = "0";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["bitmap"] = "tools/worldEditor/images/terrainpainter/terrain-painter-border-large";
            oc_Newobject18["wrap"] = "0";

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject33["#Newobject21"] = oc_Newobject21;

            #region GuiRolloutCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject32["class"] = "BehaviorQuickEditRollout";
            oc_Newobject32["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject32["Profile"] = "GuiRolloutProfile";
            oc_Newobject32["HorizSizing"] = "width";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["Position"] = "0 0";
            oc_Newobject32["Extent"] = "202 0";
            oc_Newobject32["Caption"] = "Decal Instance Properties";
            oc_Newobject32["Margin"] = "0 0 0 0";
            oc_Newobject32["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject32["container"] = new Creator.StringNoQuote("true");
            oc_Newobject32["parentRollout"] = new Creator.StringNoQuote("%this.rollout");
            oc_Newobject32["object"] = new Creator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject31["StackingType"] = "Vertical";
            oc_Newobject31["HorizStacking"] = "Left to Right";
            oc_Newobject31["VertStacking"] = "Top to Bottom";
            oc_Newobject31["Padding"] = "0";
            oc_Newobject31["isContainer"] = "1";
            oc_Newobject31["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["HorizSizing"] = "width";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = "0 0";
            oc_Newobject31["Extent"] = "208 0";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["isDecoy"] = "0";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";

            #region GuiContainer (DecalEditorDetailContainer)        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiContainer", "DecalEditorDetailContainer");
            oc_Newobject30["Position"] = "0 202";
            oc_Newobject30["Extent"] = "202 79";
            oc_Newobject30["HorizSizing"] = "width";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["isContainer"] = "1";

            #region GuiTextCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject22["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "3 2";
            oc_Newobject22["Extent"] = "47 16";
            oc_Newobject22["text"] = "Instance";

            #endregion

            oc_Newobject30["#Newobject22"] = oc_Newobject22;

            #region GuiTextCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject23["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject23["internalName"] = "instanceId";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = "54 2";
            oc_Newobject23["Extent"] = "128 18";
            oc_Newobject23["text"] = "";

            #endregion

            oc_Newobject30["#Newobject23"] = oc_Newobject23;

            #region GuiTextCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject24["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["Position"] = "3 21";
            oc_Newobject24["Extent"] = "47 16";
            oc_Newobject24["text"] = "Translate";

            #endregion

            oc_Newobject30["#Newobject24"] = oc_Newobject24;

            #region GuiTextEditCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject25["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject25["internalName"] = "nodePosition";
            oc_Newobject25["HorizSizing"] = "width";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["AltCommand"] = "DecalEditorGui.editNodeDetails();";
            oc_Newobject25["Position"] = "54 20";
            oc_Newobject25["Extent"] = "128 18";
            oc_Newobject25["text"] = "";

            #endregion

            oc_Newobject30["#Newobject25"] = oc_Newobject25;

            #region GuiTextCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject26["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "3 41";
            oc_Newobject26["Extent"] = "47 16";
            oc_Newobject26["text"] = "Tangent";

            #endregion

            oc_Newobject30["#Newobject26"] = oc_Newobject26;

            #region GuiTextEditCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject27["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject27["internalName"] = "nodeTangent";
            oc_Newobject27["HorizSizing"] = "width";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["AltCommand"] = "DecalEditorGui.editNodeDetails();";
            oc_Newobject27["Position"] = "54 40";
            oc_Newobject27["Extent"] = "128 18";
            oc_Newobject27["text"] = "";

            #endregion

            oc_Newobject30["#Newobject27"] = oc_Newobject27;

            #region GuiTextCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject28["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject28["HorizSizing"] = "right";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["Position"] = "3 61";
            oc_Newobject28["Extent"] = "47 16";
            oc_Newobject28["text"] = "Size";

            #endregion

            oc_Newobject30["#Newobject28"] = oc_Newobject28;

            #region GuiTextEditCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject29["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject29["internalName"] = "nodeSize";
            oc_Newobject29["HorizSizing"] = "width";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["AltCommand"] = "DecalEditorGui.editNodeDetails();";
            oc_Newobject29["Position"] = "54 60";
            oc_Newobject29["Extent"] = "128 18";
            oc_Newobject29["text"] = "";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject32["#Newobject31"] = oc_Newobject31;

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject34["#Newobject33"] = oc_Newobject33;

            #endregion

            oc_Newobject44["#Newobject34"] = oc_Newobject34;

            #region GuiScrollCtrl (DecalEditorLibraryProperties)        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiScrollCtrl", "DecalEditorLibraryProperties");
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["Enabled"] = "1";
            oc_Newobject43["isContainer"] = "1";
            oc_Newobject43["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["HorizSizing"] = "width";
            oc_Newobject43["Position"] = "4 24";
            oc_Newobject43["Extent"] = "202 259";
            oc_Newobject43["MinExtent"] = "8 2";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["isDecoy"] = "0";
            oc_Newobject43["Visible"] = "1";
            oc_Newobject43["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["AnchorTop"] = "0";
            oc_Newobject43["AnchorBottom"] = "0";
            oc_Newobject43["AnchorLeft"] = "0";
            oc_Newobject43["AnchorRight"] = "0";
            oc_Newobject43["willFirstRespond"] = "1";
            oc_Newobject43["Docking"] = "client";
            oc_Newobject43["Margin"] = "3 1 3 3";
            oc_Newobject43["hScrollBar"] = "alwaysOff";
            oc_Newobject43["vScrollBar"] = "dynamic";
            oc_Newobject43["lockHorizScroll"] = new Creator.StringNoQuote("true");
            oc_Newobject43["lockVertScroll"] = "false";
            oc_Newobject43["constantThumbHeight"] = "0";
            oc_Newobject43["childMargin"] = "0 0";

            #region GuiStackControl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject42["StackingType"] = "Vertical";
            oc_Newobject42["HorizStacking"] = "Left to Right";
            oc_Newobject42["VertStacking"] = "Top to Bottom";
            oc_Newobject42["Padding"] = "0";
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject42["HorizSizing"] = "width";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["position"] = "0 0";
            oc_Newobject42["Extent"] = "187 0";
            oc_Newobject42["MinExtent"] = "8 2";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["isDecoy"] = "0";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject39["class"] = "BehaviorQuickEditRollout";
            oc_Newobject39["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject39["Profile"] = "GuiRolloutProfile";
            oc_Newobject39["HorizSizing"] = "width";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["Position"] = "0 0";
            oc_Newobject39["Extent"] = "208 0";
            oc_Newobject39["Caption"] = "Decal Template Preview";
            oc_Newobject39["Margin"] = "0 0 0 -3";
            oc_Newobject39["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject39["container"] = new Creator.StringNoQuote("true");
            oc_Newobject39["parentRollout"] = new Creator.StringNoQuote("%this.rollout");
            oc_Newobject39["object"] = new Creator.StringNoQuote("%behavior");

            #region GuiStackControl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject38["StackingType"] = "Vertical";
            oc_Newobject38["HorizStacking"] = "Left to Right";
            oc_Newobject38["VertStacking"] = "Top to Bottom";
            oc_Newobject38["Padding"] = "0";
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject38["HorizSizing"] = "width";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["position"] = "0 0";
            oc_Newobject38["Extent"] = "208 0";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["isDecoy"] = "0";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiContainer", "");
            oc_Newobject37["HorizSizing"] = "width";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["Position"] = "-1 0";
            oc_Newobject37["Extent"] = "202 187";
            oc_Newobject37["Docking"] = "none";

            #region GuiBitmapCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["internalName"] = "decalPreview";
            oc_Newobject35["Enabled"] = "1";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject35["HorizSizing"] = "center";
            oc_Newobject35["VertSizing"] = "height";
            oc_Newobject35["Position"] = "0 0";
            oc_Newobject35["Extent"] = "188 186";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["isDecoy"] = "0";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["wrap"] = "0";
            oc_Newobject35["bitmap"] = "tools/materialeditor/gui/unknownImage";

            #endregion

            oc_Newobject37["#Newobject35"] = oc_Newobject35;

            #region GuiBitmapCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject36["canSaveDynamicFields"] = "0";
            oc_Newobject36["Enabled"] = "1";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject36["HorizSizing"] = "center";
            oc_Newobject36["VertSizing"] = "height";
            oc_Newobject36["Position"] = "0 0";
            oc_Newobject36["Extent"] = "188 186";
            oc_Newobject36["MinExtent"] = "8 2";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["isDecoy"] = "0";
            oc_Newobject36["Visible"] = "1";
            oc_Newobject36["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["bitmap"] = "tools/worldEditor/images/terrainpainter/terrain-painter-border-large";
            oc_Newobject36["wrap"] = "0";

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject42["#Newobject39"] = oc_Newobject39;

            #region GuiRolloutCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject41["class"] = "BehaviorQuickEditRollout";
            oc_Newobject41["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject41["Profile"] = "GuiRolloutProfile";
            oc_Newobject41["HorizSizing"] = "width";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["Position"] = "0 0";
            oc_Newobject41["Extent"] = "202 0";
            oc_Newobject41["Caption"] = "Decal Template Properties";
            oc_Newobject41["Margin"] = "0 0 0 0";
            oc_Newobject41["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject41["container"] = new Creator.StringNoQuote("true");
            oc_Newobject41["parentRollout"] = new Creator.StringNoQuote("%this.rollout");
            oc_Newobject41["object"] = new Creator.StringNoQuote("%behavior");

            #region GuiInspector (DecalInspector)        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiInspector", "DecalInspector", typeof (DecalInspector));
            oc_Newobject40["StackingType"] = "Vertical";
            oc_Newobject40["HorizStacking"] = "Left to Right";
            oc_Newobject40["VertStacking"] = "Top to Bottom";
            oc_Newobject40["Padding"] = "1";
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["Enabled"] = "1";
            oc_Newobject40["isContainer"] = "1";
            oc_Newobject40["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject40["HorizSizing"] = "width";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["Position"] = "1 1";
            oc_Newobject40["Extent"] = "200 257";
            oc_Newobject40["MinExtent"] = "16 16";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["isDecoy"] = "0";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["dividerMargin"] = "5";
            oc_Newobject40["groupFilters"] = "+General,+SimBase,+Decal,+Rendering,+Texturing";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject43["#Newobject42"] = oc_Newobject42;

            #endregion

            oc_Newobject44["#Newobject43"] = oc_Newobject43;

            #endregion

            oc_Newobject45["#Newobject44"] = oc_Newobject44;

            #endregion

            oc_Newobject45.Create();
        }

        [ConsoleInteraction]
        public override void onWake()
        {
        }

        [ConsoleInteraction]
        public override void onSelectInstance(string decalId, string lookupName)
        {
            DecalEditorTreeView DecalEditorTreeView = "DecalEditorTreeView";

            if (this["selDecalInstanceId"] == decalId)
                return;
            // Lets remember the new Id
            this["selDecalInstanceId"] = decalId;
            DecalEditorTreeView.clearSelection();

            string name = decalId + ' ' + lookupName;
            int item = DecalEditorTreeView.findItemByName(name);
            DecalEditorTreeView.selectItem(item);
            this.syncNodeDetails();
        }

        [ConsoleInteraction]
        public override void onCreateInstance(string decalId, string lookupName)
        {
            DecalEditorTreeView DecalEditorTreeView = "DecalEditorTreeView";

            // Lets remember the new Id
            this["selDecalInstanceId"] = decalId;

            // Add the new instance to the node tree
            DecalEditorTreeView.addNodeTree(decalId, lookupName);
            DecalEditorTreeView.clearSelection();

            string name = decalId + ' ' + lookupName;
            int item = DecalEditorTreeView.findItemByName(name);
            DecalEditorTreeView.selectItem(item);
            this.syncNodeDetails();
        }

        [ConsoleInteraction]
        public override void onDeleteInstance(string decalId, string lookupName)
        {
            DecalEditorTreeView DecalEditorTreeView = "DecalEditorTreeView";

            if (decalId == this["selDecalInstanceId"])
                this["selDecalInstanceId"] = "-1";

            int id = DecalEditorTreeView.findItemByName(decalId + ' ' + lookupName);
            DecalEditorTreeView.removeItem(id);
        }

        [ConsoleInteraction]
        public void editNodeDetails()
        {
            GuiContainer DecalEditorDetailContainer = "DecalEditorDetailContainer";
            GuiTextEditCtrl nodePosition = DecalEditorDetailContainer.FOT("nodePosition");
            GuiTextEditCtrl nodeTangent = DecalEditorDetailContainer.FOT("nodeTangent");
            GuiTextEditCtrl nodeSize = DecalEditorDetailContainer.FOT("nodeSize");

            string decalId = this["selDecalInstanceId"];
            if (decalId == "-1")
                return;

            string nodeDetails = nodePosition.getText();
            nodeDetails = nodeDetails + " " + nodeTangent.getText();
            nodeDetails = nodeDetails + " " + nodeSize.getText();

            if (Util.getWordCount(nodeDetails) == 7)
                this.doEditNodeDetails(decalId.AsUint(), nodeDetails, false);
        }

        // Stores the information when the gizmo is first used
        [ConsoleInteraction]
        public override void prepGizmoTransform(string decalId, string nodeDetails)
        {
            this["gizmoDetails"] = nodeDetails;
        }

        // Activated in onMouseUp while gizmo is dirty
        [ConsoleInteraction]
        public override void completeGizmoTransform(string decalId, string nodeDetails)
        {
            this.doEditNodeDetails(decalId.AsUint(), nodeDetails, true);
        }

        [ConsoleInteraction]
        public override void onSleep()
        {
        }

        [ConsoleInteraction]
        public override void syncNodeDetails()
        {
            GuiContainer DecalEditorDetailContainer = "DecalEditorDetailContainer";
            GuiTextCtrl instanceId = DecalEditorDetailContainer.FOT("instanceId");
            GuiTextEditCtrl nodePosition = DecalEditorDetailContainer.FOT("nodePosition");
            GuiTextEditCtrl nodeTangent = DecalEditorDetailContainer.FOT("nodeTangent");
            GuiTextEditCtrl nodeSize = DecalEditorDetailContainer.FOT("nodeSize");

            string decalId = this["selDecalInstanceId"];
            if (decalId == "-1")
                return;

            SimObject lookupName = this.getDecalLookupName(decalId.AsUint());
            this.updateInstancePreview(lookupName["material"]);

            instanceId.setText(decalId + " " + lookupName);
            string transformData = this.getDecalTransform(decalId.AsUint());
            nodePosition.setText(Util.getWords(transformData, 0, 2));
            nodeTangent.setText(Util.getWords(transformData, 3, 5));
            nodeSize.setText(Util.getWord(transformData, 6));
        }

        [ConsoleInteraction]
        public override void paletteSync(string mode)
        {
            string evalShortcut = "ToolsPaletteArray-->" + mode + ".setStateOn(1);";
            Util.eval(evalShortcut);
        }

        // Intended for gui use. The undo/redo functionality for deletion of datablocks
        // will enable itself automatically after using this function.
        [ConsoleInteraction]
        public void deleteSelectedDecalDatablock()
        {
            GuiListBoxCtrl DecalDataList = "DecalDataList";
            PersistenceManager DecalPMan = "DecalPMan";

            int id = DecalDataList.getSelectedItem();
            SimObject datablock = DecalDataList.getItemText(id);

            this.deleteDecalDatablock(datablock);

            if (datablock.getFilename() != "")
                {
                DecalPMan.removeDirty(datablock);
                DecalPMan.removeObjectFromFile(datablock);
                }

            DecalDataList.addFilteredItem(datablock);
        }

        [ConsoleInteraction]
        public void updateDecalPreview(Material material)
        {
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiBitmapCtrl decalPreview = DecalPreviewWindow.FOT("decalPreview");
            MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";

            if (material.isObject())
                decalPreview.setBitmapX(MaterialEditorGui.searchForTexture(material.getId().AsString(), material.diffuseMap[0]));
            else
                decalPreview.setBitmapX("tools/materialeditor/gui/unknownImage");
        }

        [ConsoleInteraction]
        public void updateInstancePreview(Material material)
        {
            GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
            GuiBitmapCtrl instancePreview = DecalPreviewWindow.FOT("decalPreview");
            MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";

            if (material.isObject())
                instancePreview.setBitmapX(MaterialEditorGui.searchForTexture(material, material.diffuseMap[0]));
            else
                instancePreview.setBitmapX("tools/materialeditor/gui/unknownImage");
        }

        [ConsoleInteraction]
        public override void rebuildInstanceTree()
        {
            DecalEditorTreeView DecalEditorTreeView = "DecalEditorTreeView";

            // Initialize the instance tree when the tab is selected
            DecalEditorTreeView.removeItem(0);
            int rootId = DecalEditorTreeView.insertItem(0, "<root>", "0", "", 1, 1);
            int count = this.getDecalCount();
            for (uint i = 0; i < count; i++)
                {
                string name = this.getDecalLookupName(i);
                if (name == "invalid")
                    continue;

                DecalEditorTreeView.addNodeTree(i.AsString(), name);
                }
        }

        //[ConsoleInteraction]
        public T createAction<T>(string desc)
        {
            Util.pushInstantGroup();
            ObjectCreator ocf = new ObjectCreator("UndoScriptAction", "", typeof (T));
            //action["class"] = className;
            //action["superClass"] = "BaseDecalEdAction";
            ocf["actionName"] = desc;
            ocf["tree"] = "DecalEditorTreeView";

            T action = myReflections.ChangeType<T>(ocf.Create());
            Util.popInstantGroup();
            return action;
        }

        [ConsoleInteraction]
        public void doAction(DecalEditorActions.BaseDecalEdAction action)
        {
            editor Editor = "Editor";
            if (action.doit())
                action.addToManager(Editor.getUndoManager());
        }

        //------------------------------------------------------------------------------
        // Edit node
        [ConsoleInteraction]
        public void doEditNodeDetails(uint instanceId, string transformData, bool gizmo)
        {
            DecalEditorActions.ActionEditNodeDetails action = this.createAction<DecalEditorActions.ActionEditNodeDetails>("Edit Decal Transform");
            action["instanceId"] = instanceId.AsString();
            action["newTransformData"] = transformData;

            if (gizmo)
                action["oldTransformData"] = this["gizmoDetails"];
            else
                action["oldTransformData"] = this.getDecalTransform(instanceId);

            this.doAction(action);
        }

        //------------------------------------------------------------------------------
        // Delete Decal Datablocks

        // This functionality solely depends on the undo/redo datablock callbacks in 
        // source.

        [ConsoleInteraction]
        public override void redoDeleteDecalDatablock(string datablock)
        {
            PersistenceManager DecalPMan = "DecalPMan";
            GuiListBoxCtrl DecalDataList = "DecalDataList";

            // Remove the object from file and place a filter
            if (((SimObject) datablock).getFilename() != "")
                {
                DecalPMan.removeDirty(datablock);
                DecalPMan.removeObjectFromFile(datablock);
                }

            DecalDataList.addFilteredItem(datablock);
        }

        [ConsoleInteraction]
        public override void undoDeleteDecalDatablock(string datablock)
        {
            PersistenceManager DecalPMan = "DecalPMan";
            GuiListBoxCtrl DecalDataList = "DecalDataList";

            // Replace the object in file and remove the filter
            string filename = ((SimObject) datablock).getFilename();
            if (filename != "")
                {
                DecalPMan.setDirty(datablock, filename);
                DecalPMan.saveDirty();
                }

            DecalDataList.removeFilteredItem(datablock);
        }

        [TypeConverter(typeof (TypeConverterGeneric<DecalDataList>))]
        public class DecalDataList : GuiListBoxCtrl
        {
            [ConsoleInteraction]
            public override void onSelect(string index, string itemText)
            {
                DecalEditorGui DecalEditorGui = "DecalEditorGui";
                GuiInspector DecalInspector = "DecalInspector";

                string obj = this.getItemObject(index.AsInt());
                DecalEditorGui["currentDecalData"] = obj;

                int itemNum = this.getSelectedItem();
                if (itemNum == -1)
                    return;

                SimObject data = this.getItemObject(itemNum);

                // Update the materialEditorList
                iGlobal["$Tools::materialEditorList"] = data.getId();

                //Canvas.pushDialog( DecalEditDlg );
                DecalInspector.inspect(data);
                DecalEditorGui.updateDecalPreview(data["material"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DecalDataList ts, string simobjectid)
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
            public static bool operator !=(DecalDataList ts, string simobjectid)
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
            public static implicit operator string(DecalDataList ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DecalDataList(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DecalDataList) Omni.self.getSimObject(simobjectid, typeof (DecalDataList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DecalDataList ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DecalDataList(int simobjectid)
            {
                return (DecalDataList) Omni.self.getSimObject((uint) simobjectid, typeof (DecalDataList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DecalDataList ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DecalDataList(uint simobjectid)
            {
                return (DecalDataList) Omni.self.getSimObject(simobjectid, typeof (DecalDataList));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DecalEditorTabBook>))]
        public class DecalEditorTabBook : GuiTabBookCtrl
        {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
            {
                GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";
                GuiScrollCtrl DecalEditorLibraryProperties = "DecalEditorLibraryProperties";
                GuiScrollCtrl DecalEditorTemplateProperties = "DecalEditorTemplateProperties";
                GuiBitmapButtonCtrl RetargetDecalButton = "RetargetDecalButton";
                GuiBitmapButtonCtrl SaveDecalsButton = "SaveDecalsButton";
                GuiBitmapButtonCtrl NewDecalButton = "NewDecalButton";
                GuiBitmapButtonCtrl DeleteDecalButton = "DeleteDecalButton";

                if (index == 0)
                    {
                    DecalPreviewWindow.text = "Template Properties";
                    DecalEditorLibraryProperties.setVisible(true);
                    DecalEditorTemplateProperties.setVisible(false);
                    RetargetDecalButton.setVisible(true);
                    SaveDecalsButton.setVisible(true);
                    NewDecalButton.setVisible(true);
                    DeleteDecalButton["tabSelected"] = index.AsString();
                    }
                else
                    {
                    DecalPreviewWindow.text = "Instance Properties";
                    RetargetDecalButton.setVisible(false);
                    NewDecalButton.setVisible(false);
                    SaveDecalsButton.setVisible(false);
                    DeleteDecalButton["tabSelected"] = index.AsString();
                    DecalEditorLibraryProperties.setVisible(false);
                    DecalEditorTemplateProperties.setVisible(true);
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DecalEditorTabBook ts, string simobjectid)
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
            public static bool operator !=(DecalEditorTabBook ts, string simobjectid)
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
            public static implicit operator string(DecalEditorTabBook ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DecalEditorTabBook(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DecalEditorTabBook) Omni.self.getSimObject(simobjectid, typeof (DecalEditorTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DecalEditorTabBook ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DecalEditorTabBook(int simobjectid)
            {
                return (DecalEditorTabBook) Omni.self.getSimObject((uint) simobjectid, typeof (DecalEditorTabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DecalEditorTabBook ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DecalEditorTabBook(uint simobjectid)
            {
                return (DecalEditorTabBook) Omni.self.getSimObject(simobjectid, typeof (DecalEditorTabBook));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DecalEditorTreeView>))]
        public class DecalEditorTreeView : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onDefineIcons()
            {
                const string icons = "tools/gui/images/treeview/default:" + "tools/classIcons/decal:" + "tools/classIcons/decalNode:";

                this.buildIconTable(icons);
            }

            [ConsoleInteraction]
            public override void onSelect(string x, string y)
            {
                DecalEditorGui DecalEditorGui = "DecalEditorGui";

                SimObject instanceTag = Util.getWord(this.getItemText(x.AsInt()), 1);
                if (!instanceTag.isObject())
                    return;

                if (instanceTag.getClassName() != "DecalData")
                    return;

                // Grab the id from the tree view
                string decalId = Util.getWord(this.getItemText(x.AsInt()), 0);

                if (DecalEditorGui["selDecalInstanceId"] == decalId)
                    return;

                // Set the curent decalinstances id
                DecalEditorGui["selDecalInstanceId"] = decalId;

                DecalEditorGui.selectDecal(decalId.AsUint());
                DecalEditorGui.syncNodeDetails();
            }

            // Creating per node in the instance tree
            [ConsoleInteraction]
            public void addNodeTree(string nodeName, string parentName)
            {
                // If my template isnt there...put it there
                if (this.findItemByName(parentName) == 0)
                    {
                    int rootId = this.findItemByName("<root>");
                    this.insertItem(rootId, parentName, "0", "", 1, 1);
                    }

                nodeName = nodeName + ' ' + parentName;
                int parentId = this.findItemByName(parentName);
                int id = this.insertItem(parentId, nodeName, "0", "", 2, 2);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DecalEditorTreeView ts, string simobjectid)
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
            public static bool operator !=(DecalEditorTreeView ts, string simobjectid)
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
            public static implicit operator string(DecalEditorTreeView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DecalEditorTreeView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DecalEditorTreeView) Omni.self.getSimObject(simobjectid, typeof (DecalEditorTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DecalEditorTreeView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DecalEditorTreeView(int simobjectid)
            {
                return (DecalEditorTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (DecalEditorTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DecalEditorTreeView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DecalEditorTreeView(uint simobjectid)
            {
                return (DecalEditorTreeView) Omni.self.getSimObject(simobjectid, typeof (DecalEditorTreeView));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DecalEditorWindow>))]
        public class DecalEditorWindow : GuiWindowCollapseCtrl
        {
            [ConsoleInteraction]
            public override void onPopWindow()
            {
                EditorPlugin DecalEditorPlugin = "DecalEditorPlugin";

                EditorGui.DeactivateAll();
                DecalEditorPlugin.onActivated();
            }

            [ConsoleInteraction]
            public override void onPopWindowClosed()
            {
                EditorPlugin DecalEditorPlugin = "DecalEditorPlugin";
                GuiWindowCollapseCtrl DecalPreviewWindow = "DecalPreviewWindow";

                EditorGui.DeactivateAll();
                DecalEditorPlugin.onActivated();
                this.attachTo(DecalPreviewWindow);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DecalEditorWindow ts, string simobjectid)
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
            public static bool operator !=(DecalEditorWindow ts, string simobjectid)
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
            public static implicit operator string(DecalEditorWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DecalEditorWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DecalEditorWindow) Omni.self.getSimObject(simobjectid, typeof (DecalEditorWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DecalEditorWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DecalEditorWindow(int simobjectid)
            {
                return (DecalEditorWindow) Omni.self.getSimObject((uint) simobjectid, typeof (DecalEditorWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DecalEditorWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DecalEditorWindow(uint simobjectid)
            {
                return (DecalEditorWindow) Omni.self.getSimObject(simobjectid, typeof (DecalEditorWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DecalInspector>))]
        public class DecalInspector : GuiInspector
        {
            [ConsoleInteraction]
            public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
            {
                DecalEditorGui DecalEditorGui = "DecalEditorGui";
                Inspector Inspector = "Inspector";

                if (fieldName == "Material")
                    DecalEditorGui.updateDecalPreview(newValue);

                // Same work to do as for the regular WorldEditor Inspector.
                Inspector.onInspectorFieldModified(objectx, fieldName, arrayIndex, oldValue, newValue);

                if (oldValue != newValue || oldValue != newValue)
                    this.setDirty(objectx);
            }

            [ConsoleInteraction]
            public void setDirty(string obj)
            {
                PersistenceManager DecalPMan = "DecalPMan";
                GuiTabPageCtrl LibraryTabControl = "LibraryTabControl";

                DecalPMan.setDirty(obj);

                if (Util.strchr(LibraryTabControl.text, "*") == "")
                    LibraryTabControl.text = LibraryTabControl.text + "*";
            }

            [ConsoleInteraction]
            public void removeDirty()
            {
                GuiTabPageCtrl LibraryTabControl = "LibraryTabControl";

                if (Util.strchr(LibraryTabControl.text, "*") != "")
                    LibraryTabControl.text = Util.stripChars(LibraryTabControl.text, "*");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DecalInspector ts, string simobjectid)
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
            public static bool operator !=(DecalInspector ts, string simobjectid)
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
            public static implicit operator string(DecalInspector ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DecalInspector(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DecalInspector) Omni.self.getSimObject(simobjectid, typeof (DecalInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DecalInspector ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DecalInspector(int simobjectid)
            {
                return (DecalInspector) Omni.self.getSimObject((uint) simobjectid, typeof (DecalInspector));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DecalInspector ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DecalInspector(uint simobjectid)
            {
                return (DecalInspector) Omni.self.getSimObject(simobjectid, typeof (DecalInspector));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DecalPreviewWindow>))]
        public class DecalPreviewWindow : GuiWindowCollapseCtrl
        {
            [ConsoleInteraction]
            public override void onPopWindow()
            {
                EditorPlugin DecalEditorPlugin = "DecalEditorPlugin";

                EditorGui.DeactivateAll();
                DecalEditorPlugin.onActivated();
            }

            [ConsoleInteraction]
            public override void onPopWindowClosed()
            {
                EditorPlugin DecalEditorPlugin = "DecalEditorPlugin";
                GuiWindowCollapseCtrl DecalEditorWindow = "DecalEditorWindow";

                EditorGui.DeactivateAll();
                DecalEditorPlugin.onActivated();
                this.attachTo(DecalEditorWindow);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DecalPreviewWindow ts, string simobjectid)
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
            public static bool operator !=(DecalPreviewWindow ts, string simobjectid)
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
            public static implicit operator string(DecalPreviewWindow ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DecalPreviewWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DecalPreviewWindow) Omni.self.getSimObject(simobjectid, typeof (DecalPreviewWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DecalPreviewWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DecalPreviewWindow(int simobjectid)
            {
                return (DecalPreviewWindow) Omni.self.getSimObject((uint) simobjectid, typeof (DecalPreviewWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DecalPreviewWindow ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DecalPreviewWindow(uint simobjectid)
            {
                return (DecalPreviewWindow) Omni.self.getSimObject(simobjectid, typeof (DecalPreviewWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DeleteDecalButton>))]
        public class DeleteDecalButton : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                GuiTabBookCtrl DecalEditorTabBook = "DecalEditorTabBook";
                GuiListBoxCtrl DecalDataList = "DecalDataList";
                DecalEditorGui DecalEditorGui = "DecalEditorGui";

                if (DecalEditorTabBook.getSelectedPage() == 0) // library
                    {
                    int id = DecalDataList.getSelectedItem();
                    string datablock = DecalDataList.getItemText(id);

                    messageBox.MessageBoxYesNoCancel("Delete Decal Datablock?", "Are you sure you want to delete<br><br>" + datablock + "<br><br> Datablock deletion won't take affect until the engine is quit.", "DecalEditorGui.deleteSelectedDecalDatablock();", "", "");
                    }
                else // instances
                    DecalEditorGui.deleteSelectedDecal();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DeleteDecalButton ts, string simobjectid)
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
            public static bool operator !=(DeleteDecalButton ts, string simobjectid)
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
            public static implicit operator string(DeleteDecalButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DeleteDecalButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DeleteDecalButton) Omni.self.getSimObject(simobjectid, typeof (DeleteDecalButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DeleteDecalButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DeleteDecalButton(int simobjectid)
            {
                return (DeleteDecalButton) Omni.self.getSimObject((uint) simobjectid, typeof (DeleteDecalButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DeleteDecalButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DeleteDecalButton(uint simobjectid)
            {
                return (DeleteDecalButton) Omni.self.getSimObject(simobjectid, typeof (DeleteDecalButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<NewDecalButton>))]
        public class NewDecalButton : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                PersistenceManager DecalPMan = "DecalPMan";
                GuiTabPageCtrl LibraryTabControl = "LibraryTabControl";
                GuiListBoxCtrl DecalDataList = "DecalDataList";
                GuiCanvas Canvas = "Canvas";
                GuiInspector DecalInspector = "DecalInspector";

                string name = Util.getUniqueName("NewDecalData");

                string str = "datablock DecalData( " + name + " ) { Material = \"WarningMaterial\"; };";
                Util.eval(str);

                DecalPMan.setDirty(name, sGlobal["$decalDataFile"]);

                if (Util.strchr(LibraryTabControl.text, "*") == "")
                    LibraryTabControl.text = LibraryTabControl.text + "*";

                DecalDataList.doMirror();
                int id = DecalDataList.findItemText(name, false);
                DecalDataList.setSelected(id, true);

                //TODO
                Canvas.pushDialog("DecalEditDlg");
                DecalInspector.inspect(name);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(NewDecalButton ts, string simobjectid)
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
            public static bool operator !=(NewDecalButton ts, string simobjectid)
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
            public static implicit operator string(NewDecalButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator NewDecalButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (NewDecalButton) Omni.self.getSimObject(simobjectid, typeof (NewDecalButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(NewDecalButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator NewDecalButton(int simobjectid)
            {
                return (NewDecalButton) Omni.self.getSimObject((uint) simobjectid, typeof (NewDecalButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(NewDecalButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator NewDecalButton(uint simobjectid)
            {
                return (NewDecalButton) Omni.self.getSimObject(simobjectid, typeof (NewDecalButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<RetargetDecalButton>))]
        public class RetargetDecalButton : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                GuiListBoxCtrl DecalDataList = "DecalDataList";
                DecalEditorGui DecalEditorGui = "DecalEditorGui";

                int id = DecalDataList.getSelectedItem();
                string datablock = DecalDataList.getItemText(id);

                if (!datablock.isObject())
                    {
                    messageBox.MessageBoxOK("Error", "A valid Decal Template must be selected.");
                    return;
                    }

                // This is the first place IODropdown is used. The # in the function passed replaced with the output 
                // of the preset menu.

                messageBox.IODropdown("Retarget Decal Instances", "Retarget DecalInstances from " + datablock.getName() + " over to....", "decalDataSet", "DecalEditorGui.retargetDecalDatablock(" + datablock.getName() + ", #);", "");
                DecalEditorGui.rebuildInstanceTree();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(RetargetDecalButton ts, string simobjectid)
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
            public static bool operator !=(RetargetDecalButton ts, string simobjectid)
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
            public static implicit operator string(RetargetDecalButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator RetargetDecalButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (RetargetDecalButton) Omni.self.getSimObject(simobjectid, typeof (RetargetDecalButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(RetargetDecalButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator RetargetDecalButton(int simobjectid)
            {
                return (RetargetDecalButton) Omni.self.getSimObject((uint) simobjectid, typeof (RetargetDecalButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(RetargetDecalButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator RetargetDecalButton(uint simobjectid)
            {
                return (RetargetDecalButton) Omni.self.getSimObject(simobjectid, typeof (RetargetDecalButton));
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
        public static bool operator ==(DecalEditorGui ts, string simobjectid)
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
        public static bool operator !=(DecalEditorGui ts, string simobjectid)
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
        public static implicit operator string(DecalEditorGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DecalEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DecalEditorGui) Omni.self.getSimObject(simobjectid, typeof (DecalEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DecalEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DecalEditorGui(int simobjectid)
        {
            return (DecalEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (DecalEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DecalEditorGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DecalEditorGui(uint simobjectid)
        {
            return (DecalEditorGui) Omni.self.getSimObject(simobjectid, typeof (DecalEditorGui));
        }

        #endregion
    }
}