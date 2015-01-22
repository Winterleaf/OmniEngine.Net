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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<NavEditorGui>))]
    public class NavEditorGui : GuiNavEditorCtrl
    {
        public NavMesh selectedObject
        {
            get { return this["selectedObject"]; }
            set { this["selectedObject"] = value; }
        }

        public static void initialize()
        {
            ObjectCreator oc_Newobject00056;
            ObjectCreator oc_Newobject00055;
            ObjectCreator oc_Newobject00054;
            ObjectCreator oc_Newobject00053;
            ObjectCreator oc_Newobject00052;
            ObjectCreator oc_Newobject00051;
            ObjectCreator oc_Newobject00050;
            ObjectCreator oc_Newobject00049;
            ObjectCreator oc_Newobject00048;
            ObjectCreator oc_Newobject00047;
            ObjectCreator oc_Newobject00046;
            ObjectCreator oc_Newobject00045;
            ObjectCreator oc_Newobject00044;
            ObjectCreator oc_Newobject00043;
            ObjectCreator oc_Newobject00042;
            ObjectCreator oc_Newobject00041;
            ObjectCreator oc_Newobject00040;
            ObjectCreator oc_Newobject00039;
            ObjectCreator oc_Newobject00038;
            ObjectCreator oc_Newobject00037;
            ObjectCreator oc_Newobject00036;
            ObjectCreator oc_Newobject00035;
            ObjectCreator oc_Newobject00034;
            ObjectCreator oc_Newobject00033;
            ObjectCreator oc_Newobject00032;
            ObjectCreator oc_Newobject00031;
            ObjectCreator oc_Newobject00030;
            ObjectCreator oc_Newobject00029;
            ObjectCreator oc_Newobject00028;
            ObjectCreator oc_Newobject00027;
            ObjectCreator oc_Newobject00026;
            ObjectCreator oc_Newobject00025;
            ObjectCreator oc_Newobject00024;
            ObjectCreator oc_Newobject00023;
            ObjectCreator oc_Newobject00022;
            ObjectCreator oc_Newobject00021;
            ObjectCreator oc_Newobject00020;
            ObjectCreator oc_Newobject00019;
            ObjectCreator oc_Newobject00018;
            ObjectCreator oc_Newobject00017;
            ObjectCreator oc_Newobject00016;
            ObjectCreator oc_Newobject00015;
            ObjectCreator oc_Newobject00014;
            ObjectCreator oc_Newobject00013;
            ObjectCreator oc_Newobject00012;
            ObjectCreator oc_Newobject00011;
            ObjectCreator oc_Newobject00010;
            ObjectCreator oc_Newobject00009;
            ObjectCreator oc_Newobject00008;
            ObjectCreator oc_Newobject00007;
            ObjectCreator oc_Newobject00006;
            ObjectCreator oc_Newobject00005;
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
                {
                #region GuiNavEditorCtrl (NavEditorGui, EditorGuiGroup)        oc_Newobject00056

                oc_Newobject00056 = new ObjectCreator("GuiNavEditorCtrl", "NavEditorGui, EditorGuiGroup", typeof (NavEditorGui));
                oc_Newobject00056["canSaveDynamicFields"] = "0";
                oc_Newobject00056["Enabled"] = "1";
                oc_Newobject00056["isContainer"] = "1";
                oc_Newobject00056["Profile"] = "NavEditorProfile";
                oc_Newobject00056["HorizSizing"] = "width";
                oc_Newobject00056["VertSizing"] = "height";
                oc_Newobject00056["Position"] = "0 0";
                oc_Newobject00056["Extent"] = "800 600";
                oc_Newobject00056["MinExtent"] = "8 8";
                oc_Newobject00056["canSave"] = "1";
                oc_Newobject00056["Visible"] = "1";
                oc_Newobject00056["tooltipprofile"] = "GuiToolTipProfile";
                oc_Newobject00056["hovertime"] = "1000";
                oc_Newobject00056["Docking"] = "None";
                oc_Newobject00056["Margin"] = "0 0 0 0";
                oc_Newobject00056["Padding"] = "0 0 0 0";
                oc_Newobject00056["AnchorTop"] = "0";
                oc_Newobject00056["AnchorBottom"] = "0";
                oc_Newobject00056["AnchorLeft"] = "0";
                oc_Newobject00056["AnchorRight"] = "0";
                oc_Newobject00056["cameraZRot"] = "0";
                oc_Newobject00056["forceFOV"] = "0";
                oc_Newobject00056["renderMissionArea"] = "0";
                oc_Newobject00056["missionAreaFillColor"] = "255 0 0 20";
                oc_Newobject00056["missionAreaFrameColor"] = "255 0 0 128";
                oc_Newobject00056["allowBorderMove"] = "0";
                oc_Newobject00056["borderMovePixelSize"] = "20";
                oc_Newobject00056["borderMoveSpeed"] = "0.1";
                oc_Newobject00056["consoleFrameColor"] = "255 0 0 255";
                oc_Newobject00056["consoleFillColor"] = "0 0 0 0";
                oc_Newobject00056["consoleSphereLevel"] = "1";
                oc_Newobject00056["consoleCircleSegments"] = "32";
                oc_Newobject00056["consoleLineWidth"] = "1";
                oc_Newobject00056["GizmoProfile"] = "GlobalGizmoProfile";
                if (true)
                    {
                    #region GuiWindowCollapseCtrl (NavEditorTreeWindow)        oc_Newobject00005

                    oc_Newobject00005 = new ObjectCreator("GuiWindowCollapseCtrl", "NavEditorTreeWindow");
                    oc_Newobject00005["internalName"] = "";
                    oc_Newobject00005["canSaveDynamicFields"] = "0";
                    oc_Newobject00005["Enabled"] = "1";
                    oc_Newobject00005["isContainer"] = "1";
                    oc_Newobject00005["Profile"] = "GuiWindowProfile";
                    oc_Newobject00005["HorizSizing"] = "windowRelative";
                    oc_Newobject00005["VertSizing"] = "windowRelative";
                    oc_Newobject00005["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) - 1");
                    oc_Newobject00005["Extent"] = "210 167";
                    oc_Newobject00005["MinExtent"] = "210 100";
                    oc_Newobject00005["canSave"] = "1";
                    oc_Newobject00005["isDecoy"] = "0";
                    oc_Newobject00005["Visible"] = "1";
                    oc_Newobject00005["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00005["hovertime"] = "1000";
                    oc_Newobject00005["Margin"] = "0 0 0 0";
                    oc_Newobject00005["Padding"] = "0 0 0 0";
                    oc_Newobject00005["AnchorTop"] = "1";
                    oc_Newobject00005["AnchorBottom"] = "0";
                    oc_Newobject00005["AnchorLeft"] = "1";
                    oc_Newobject00005["AnchorRight"] = "0";
                    oc_Newobject00005["resizeWidth"] = "1";
                    oc_Newobject00005["resizeHeight"] = "1";
                    oc_Newobject00005["canMove"] = "1";
                    oc_Newobject00005["canClose"] = "0";
                    oc_Newobject00005["canMinimize"] = "0";
                    oc_Newobject00005["canMaximize"] = "0";
                    oc_Newobject00005["minSize"] = "50 50";
                    oc_Newobject00005["EdgeSnap"] = "1";
                    oc_Newobject00005["text"] = "Navigation";
                    if (true)
                        {
                        #region GuiButtonCtrl ()        oc_Newobject00001

                        oc_Newobject00001 = new ObjectCreator("GuiButtonCtrl", "");
                        oc_Newobject00001["Profile"] = "GuiButtonProfile";
                        oc_Newobject00001["buttonType"] = "PushButton";
                        oc_Newobject00001["HorizSizing"] = "right";
                        oc_Newobject00001["VertSizing"] = "bottom";
                        oc_Newobject00001["position"] = "115 2";
                        oc_Newobject00001["extent"] = "90 18";
                        oc_Newobject00001["text"] = "New NavMesh";
                        oc_Newobject00001["command"] = "Canvas.pushDialog(CreateNewNavMeshDlg);";

                        #endregion

                        oc_Newobject00005["#Newobject00001"] = oc_Newobject00001;

                        #region GuiContainer ()        oc_Newobject00004

                        oc_Newobject00004 = new ObjectCreator("GuiContainer", "");
                        oc_Newobject00004["profile"] = new Creator.StringNoQuote("GuiDefaultProfile");
                        oc_Newobject00004["Position"] = "5 25";
                        oc_Newobject00004["Extent"] = "200 120";
                        oc_Newobject00004["Docking"] = "Client";
                        oc_Newobject00004["Margin"] = "3 1 3 3 ";
                        oc_Newobject00004["HorizSizing"] = "width";
                        oc_Newobject00004["VertSizing"] = "height";
                        oc_Newobject00004["isContainer"] = "1";
                        if (true)
                            {
                            #region GuiScrollCtrl ()        oc_Newobject00003

                            oc_Newobject00003 = new ObjectCreator("GuiScrollCtrl", "");
                            oc_Newobject00003["canSaveDynamicFields"] = "0";
                            oc_Newobject00003["Enabled"] = "1";
                            oc_Newobject00003["isContainer"] = "1";
                            oc_Newobject00003["Profile"] = "GuiEditorScrollProfile";
                            oc_Newobject00003["HorizSizing"] = "width";
                            oc_Newobject00003["VertSizing"] = "height";
                            oc_Newobject00003["Position"] = "0 0";
                            oc_Newobject00003["Extent"] = "200 118";
                            oc_Newobject00003["MinExtent"] = "8 8";
                            oc_Newobject00003["canSave"] = "1";
                            oc_Newobject00003["isDecoy"] = "0";
                            oc_Newobject00003["Visible"] = "1";
                            oc_Newobject00003["tooltipprofile"] = "GuiToolTipProfile";
                            oc_Newobject00003["hovertime"] = "1000";
                            oc_Newobject00003["Docking"] = "Client";
                            oc_Newobject00003["Margin"] = "0 0 0 0";
                            oc_Newobject00003["Padding"] = "0 0 0 0";
                            oc_Newobject00003["AnchorTop"] = "1";
                            oc_Newobject00003["AnchorBottom"] = "0";
                            oc_Newobject00003["AnchorLeft"] = "1";
                            oc_Newobject00003["AnchorRight"] = "0";
                            oc_Newobject00003["willFirstRespond"] = "1";
                            oc_Newobject00003["hScrollBar"] = "alwaysOff";
                            oc_Newobject00003["vScrollBar"] = "dynamic";
                            oc_Newobject00003["lockHorizScroll"] = "true";
                            oc_Newobject00003["lockVertScroll"] = "false";
                            oc_Newobject00003["constantThumbHeight"] = "0";
                            oc_Newobject00003["childMargin"] = "0 0";
                            oc_Newobject00003["mouseWheelScrollSpeed"] = "-1";
                            if (true)
                                {
                                #region GuiTreeViewCtrl (NavTreeView)        oc_Newobject00002

                                oc_Newobject00002 = new ObjectCreator("GuiTreeViewCtrl", "NavTreeView", typeof (NavTreeView));
                                oc_Newobject00002["canSaveDynamicFields"] = "0";
                                oc_Newobject00002["Enabled"] = "1";
                                oc_Newobject00002["isContainer"] = "1";
                                oc_Newobject00002["Profile"] = "ToolsGuiTreeViewProfile";
                                oc_Newobject00002["HorizSizing"] = "right";
                                oc_Newobject00002["VertSizing"] = "bottom";
                                oc_Newobject00002["Position"] = "1 1";
                                oc_Newobject00002["Extent"] = "193 21";
                                oc_Newobject00002["MinExtent"] = "8 8";
                                oc_Newobject00002["canSave"] = "1";
                                oc_Newobject00002["Visible"] = "1";
                                oc_Newobject00002["hovertime"] = "1000";
                                oc_Newobject00002["tabSize"] = "16";
                                oc_Newobject00002["textOffset"] = "2";
                                oc_Newobject00002["fullRowSelect"] = "0";
                                oc_Newobject00002["itemHeight"] = "21";
                                oc_Newobject00002["destroyTreeOnSleep"] = "1";
                                oc_Newobject00002["MouseDragging"] = "0";
                                oc_Newobject00002["MultipleSelections"] = "0";
                                oc_Newobject00002["DeleteObjectAllowed"] = "1";
                                oc_Newobject00002["DragToItemAllowed"] = "0";
                                oc_Newobject00002["showRoot"] = "0";
                                oc_Newobject00002["internalNamesOnly"] = "0";

                                #endregion

                                oc_Newobject00003["#Newobject00002"] = oc_Newobject00002;
                                }

                            #endregion

                            oc_Newobject00004["#Newobject00003"] = oc_Newobject00003;
                            }

                        #endregion

                        oc_Newobject00005["#Newobject00004"] = oc_Newobject00004;
                        }

                    #endregion

                    oc_Newobject00056["#Newobject00005"] = oc_Newobject00005;

                    #region GuiWindowCollapseCtrl (NavEditorOptionsWindow)        oc_Newobject00055

                    oc_Newobject00055 = new ObjectCreator("GuiWindowCollapseCtrl", "NavEditorOptionsWindow");
                    oc_Newobject00055["internalName"] = "Window";
                    oc_Newobject00055["canSaveDynamicFields"] = "0";
                    oc_Newobject00055["Enabled"] = "1";
                    oc_Newobject00055["isContainer"] = "1";
                    oc_Newobject00055["Profile"] = "GuiWindowProfile";
                    oc_Newobject00055["HorizSizing"] = "windowRelative";
                    oc_Newobject00055["VertSizing"] = "windowRelative";
                    oc_Newobject00055["Position"] = new Creator.StringNoQuote("getWord($pref::Video::mode, 0) - 209          SPC getWord(EditorGuiToolbar.extent, 1) + getWord(NavEditorTreeWindow.extent, 1) - 2");
                    oc_Newobject00055["Extent"] = "210 530";
                    oc_Newobject00055["MinExtent"] = "210 300";
                    oc_Newobject00055["canSave"] = "1";
                    oc_Newobject00055["Visible"] = "1";
                    oc_Newobject00055["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00055["hovertime"] = "1000";
                    oc_Newobject00055["Margin"] = "0 0 0 0";
                    oc_Newobject00055["Padding"] = "0 0 0 0";
                    oc_Newobject00055["AnchorTop"] = "0";
                    oc_Newobject00055["AnchorBottom"] = "0";
                    oc_Newobject00055["AnchorLeft"] = "0";
                    oc_Newobject00055["AnchorRight"] = "0";
                    oc_Newobject00055["resizeWidth"] = "1";
                    oc_Newobject00055["resizeHeight"] = "1";
                    oc_Newobject00055["canMove"] = "1";
                    oc_Newobject00055["canClose"] = "0";
                    oc_Newobject00055["canMinimize"] = "0";
                    oc_Newobject00055["canMaximize"] = "0";
                    oc_Newobject00055["minSize"] = "50 50";
                    oc_Newobject00055["EdgeSnap"] = "1";
                    oc_Newobject00055["text"] = "Properties";
                    if (true)
                        {
                        #region GuiContainer ()        oc_Newobject00025

                        oc_Newobject00025 = new ObjectCreator("GuiContainer", "");
                        oc_Newobject00025["isContainer"] = "1";
                        oc_Newobject00025["Profile"] = "inspectorStyleRolloutDarkProfile";
                        oc_Newobject00025["HorizSizing"] = "width";
                        oc_Newobject00025["VertSizing"] = "bottom";
                        oc_Newobject00025["Position"] = "4 24";
                        oc_Newobject00025["Extent"] = "202 85";
                        oc_Newobject00025["Docking"] = "Top";
                        oc_Newobject00025["Margin"] = "3 3 3 3";
                        oc_Newobject00025["internalName"] = "ActionsBox";
                        if (true)
                            {
                            #region GuiTextCtrl ()        oc_Newobject00006

                            oc_Newobject00006 = new ObjectCreator("GuiTextCtrl", "");
                            oc_Newobject00006["Profile"] = "GuiDefaultProfile";
                            oc_Newobject00006["HorizSizing"] = "right";
                            oc_Newobject00006["VertSizing"] = "bottom";
                            oc_Newobject00006["Position"] = "5 0";
                            oc_Newobject00006["Extent"] = "86 18";
                            oc_Newobject00006["text"] = "Actions";

                            #endregion

                            oc_Newobject00025["#Newobject00006"] = oc_Newobject00006;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00011

                            oc_Newobject00011 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00011["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00011["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00011["internalName"] = "SelectActions";
                            oc_Newobject00011["position"] = "7 21";
                            oc_Newobject00011["extent"] = "190 64";
                            if (true)
                                {
                                #region GuiButtonCtrl ()        oc_Newobject00007

                                oc_Newobject00007 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00007["Profile"] = "GuiButtonProfile";
                                oc_Newobject00007["buttonType"] = "PushButton";
                                oc_Newobject00007["HorizSizing"] = "right";
                                oc_Newobject00007["VertSizing"] = "bottom";
                                oc_Newobject00007["Extent"] = "182 18";
                                oc_Newobject00007["text"] = "Build NavMesh";
                                oc_Newobject00007["command"] = "NavEditorGui.buildSelectedMeshes();";

                                #endregion

                                oc_Newobject00011["#Newobject00007"] = oc_Newobject00007;

                                #region GuiCheckboxCtrl ()        oc_Newobject00008

                                oc_Newobject00008 = new ObjectCreator("GuiCheckboxCtrl", "");
                                oc_Newobject00008["internalName"] = "BackgroundBuildButton";
                                oc_Newobject00008["text"] = "Background";
                                oc_Newobject00008["groupNum"] = "-1";
                                oc_Newobject00008["buttonType"] = "ToggleButton";
                                oc_Newobject00008["useMouseEvents"] = "0";
                                oc_Newobject00008["extent"] = "75 20";
                                oc_Newobject00008["minExtent"] = "8 2";
                                oc_Newobject00008["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00008["visible"] = "1";
                                oc_Newobject00008["active"] = "1";
                                oc_Newobject00008["variable"] = "$Nav::Editor::backgroundBuild";
                                oc_Newobject00008["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00008["hovertime"] = "1000";
                                oc_Newobject00008["isContainer"] = "0";
                                oc_Newobject00008["canSave"] = "1";
                                oc_Newobject00008["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00011["#Newobject00008"] = oc_Newobject00008;

                                #region GuiCheckboxCtrl ()        oc_Newobject00009

                                oc_Newobject00009 = new ObjectCreator("GuiCheckboxCtrl", "");
                                oc_Newobject00009["internalName"] = "SaveIntermediatesButton";
                                oc_Newobject00009["text"] = "Keep intermediates";
                                oc_Newobject00009["groupNum"] = "-1";
                                oc_Newobject00009["buttonType"] = "ToggleButton";
                                oc_Newobject00009["useMouseEvents"] = "0";
                                oc_Newobject00009["extent"] = "105 20";
                                oc_Newobject00009["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00009["visible"] = "1";
                                oc_Newobject00009["active"] = "1";
                                oc_Newobject00009["variable"] = "$Nav::Editor::saveIntermediates";
                                oc_Newobject00009["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00009["hovertime"] = "1000";
                                oc_Newobject00009["isContainer"] = "0";
                                oc_Newobject00009["canSave"] = "1";
                                oc_Newobject00009["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00011["#Newobject00009"] = oc_Newobject00009;

                                #region GuiCheckboxCtrl ()        oc_Newobject00010

                                oc_Newobject00010 = new ObjectCreator("GuiCheckboxCtrl", "");
                                oc_Newobject00010["internalName"] = "BuildSoundButton";
                                oc_Newobject00010["text"] = "Play sound when done";
                                oc_Newobject00010["groupNum"] = "-1";
                                oc_Newobject00010["buttonType"] = "ToggleButton";
                                oc_Newobject00010["useMouseEvents"] = "0";
                                oc_Newobject00010["extent"] = "150 20";
                                oc_Newobject00010["minExtent"] = "8 2";
                                oc_Newobject00010["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00010["visible"] = "1";
                                oc_Newobject00010["active"] = "1";
                                oc_Newobject00010["variable"] = "$Nav::Editor::playSoundWhenDone";
                                oc_Newobject00010["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00010["hovertime"] = "1000";
                                oc_Newobject00010["isContainer"] = "0";
                                oc_Newobject00010["canSave"] = "1";
                                oc_Newobject00010["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00011["#Newobject00010"] = oc_Newobject00010;
                                }

                            #endregion

                            oc_Newobject00025["#Newobject00011"] = oc_Newobject00011;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00013

                            oc_Newobject00013 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00013["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00013["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00013["internalName"] = "LinkActions";
                            oc_Newobject00013["position"] = "7 21";
                            oc_Newobject00013["extent"] = "190 64";
                            if (true)
                                {
                                #region GuiButtonCtrl ()        oc_Newobject00012

                                oc_Newobject00012 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00012["Profile"] = "GuiButtonProfile";
                                oc_Newobject00012["buttonType"] = "PushButton";
                                oc_Newobject00012["HorizSizing"] = "right";
                                oc_Newobject00012["VertSizing"] = "bottom";
                                oc_Newobject00012["Extent"] = "182 18";
                                oc_Newobject00012["text"] = "Rebuild links";
                                oc_Newobject00012["command"] = "NavEditorGui.buildLinks();";

                                #endregion

                                oc_Newobject00013["#Newobject00012"] = oc_Newobject00012;
                                }

                            #endregion

                            oc_Newobject00025["#Newobject00013"] = oc_Newobject00013;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00016

                            oc_Newobject00016 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00016["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00016["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00016["internalName"] = "CoverActions";
                            oc_Newobject00016["position"] = "7 21";
                            oc_Newobject00016["extent"] = "190 64";
                            if (true)
                                {
                                #region GuiButtonCtrl ()        oc_Newobject00014

                                oc_Newobject00014 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00014["Profile"] = "GuiButtonProfile";
                                oc_Newobject00014["buttonType"] = "PushButton";
                                oc_Newobject00014["HorizSizing"] = "right";
                                oc_Newobject00014["VertSizing"] = "bottom";
                                oc_Newobject00014["Extent"] = "182 18";
                                oc_Newobject00014["text"] = "Create Cover";
                                oc_Newobject00014["command"] = "NavEditorGui.createCoverPoints();";

                                #endregion

                                oc_Newobject00016["#Newobject00014"] = oc_Newobject00014;

                                #region GuiButtonCtrl ()        oc_Newobject00015

                                oc_Newobject00015 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00015["Profile"] = "GuiButtonProfile";
                                oc_Newobject00015["buttonType"] = "PushButton";
                                oc_Newobject00015["HorizSizing"] = "right";
                                oc_Newobject00015["VertSizing"] = "bottom";
                                oc_Newobject00015["Extent"] = "182 18";
                                oc_Newobject00015["text"] = "Delete Cover";
                                oc_Newobject00015["command"] = "NavEditorGui.deleteCoverPoints();";

                                #endregion

                                oc_Newobject00016["#Newobject00015"] = oc_Newobject00015;
                                }

                            #endregion

                            oc_Newobject00025["#Newobject00016"] = oc_Newobject00016;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00018

                            oc_Newobject00018 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00018["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00018["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00018["internalName"] = "TileActions";
                            oc_Newobject00018["position"] = "7 21";
                            oc_Newobject00018["extent"] = "190 64";
                            if (true)
                                {
                                #region GuiButtonCtrl ()        oc_Newobject00017

                                oc_Newobject00017 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00017["Profile"] = "GuiButtonProfile";
                                oc_Newobject00017["buttonType"] = "PushButton";
                                oc_Newobject00017["HorizSizing"] = "right";
                                oc_Newobject00017["VertSizing"] = "bottom";
                                oc_Newobject00017["Extent"] = "182 18";
                                oc_Newobject00017["text"] = "Rebuild tile";
                                oc_Newobject00017["command"] = "NavEditorGui.buildTile();";

                                #endregion

                                oc_Newobject00018["#Newobject00017"] = oc_Newobject00017;
                                }

                            #endregion

                            oc_Newobject00025["#Newobject00018"] = oc_Newobject00018;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00024

                            oc_Newobject00024 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00024["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00024["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00024["internalName"] = "TestActions";
                            oc_Newobject00024["position"] = "7 21";
                            oc_Newobject00024["extent"] = "190 64";
                            if (true)
                                {
                                #region GuiButtonCtrl ()        oc_Newobject00019

                                oc_Newobject00019 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00019["Profile"] = "GuiButtonProfile";
                                oc_Newobject00019["buttonType"] = "PushButton";
                                oc_Newobject00019["HorizSizing"] = "right";
                                oc_Newobject00019["VertSizing"] = "bottom";
                                oc_Newobject00019["Extent"] = "180 18";
                                oc_Newobject00019["text"] = "Spawn";
                                oc_Newobject00019["command"] = "NavEditorGui.spawnPlayer();";

                                #endregion

                                oc_Newobject00024["#Newobject00019"] = oc_Newobject00019;

                                #region GuiButtonCtrl ()        oc_Newobject00020

                                oc_Newobject00020 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00020["Profile"] = "GuiButtonProfile";
                                oc_Newobject00020["buttonType"] = "PushButton";
                                oc_Newobject00020["HorizSizing"] = "right";
                                oc_Newobject00020["VertSizing"] = "bottom";
                                oc_Newobject00020["Extent"] = "90 18";
                                oc_Newobject00020["text"] = "Delete";
                                oc_Newobject00020["command"] = "NavEditorGui.getPlayer().delete();";

                                #endregion

                                oc_Newobject00024["#Newobject00020"] = oc_Newobject00020;

                                #region GuiButtonCtrl ()        oc_Newobject00021

                                oc_Newobject00021 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00021["Profile"] = "GuiButtonProfile";
                                oc_Newobject00021["buttonType"] = "PushButton";
                                oc_Newobject00021["HorizSizing"] = "right";
                                oc_Newobject00021["VertSizing"] = "bottom";
                                oc_Newobject00021["Extent"] = "90 18";
                                oc_Newobject00021["text"] = "Find cover";
                                oc_Newobject00021["command"] = "NavEditorGui.findCover();";

                                #endregion

                                oc_Newobject00024["#Newobject00021"] = oc_Newobject00021;

                                #region GuiButtonCtrl ()        oc_Newobject00022

                                oc_Newobject00022 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00022["Profile"] = "GuiButtonProfile";
                                oc_Newobject00022["buttonType"] = "PushButton";
                                oc_Newobject00022["HorizSizing"] = "right";
                                oc_Newobject00022["VertSizing"] = "bottom";
                                oc_Newobject00022["Extent"] = "90 18";
                                oc_Newobject00022["text"] = "Follow";
                                oc_Newobject00022["command"] = "NavEditorGui.followObject();";

                                #endregion

                                oc_Newobject00024["#Newobject00022"] = oc_Newobject00022;

                                #region GuiButtonCtrl ()        oc_Newobject00023

                                oc_Newobject00023 = new ObjectCreator("GuiButtonCtrl", "");
                                oc_Newobject00023["Profile"] = "GuiButtonProfile";
                                oc_Newobject00023["buttonType"] = "PushButton";
                                oc_Newobject00023["HorizSizing"] = "right";
                                oc_Newobject00023["VertSizing"] = "bottom";
                                oc_Newobject00023["Extent"] = "90 18";
                                oc_Newobject00023["text"] = "Stop";
                                oc_Newobject00023["command"] = "NavEditorGui.getPlayer().stop();";

                                #endregion

                                oc_Newobject00024["#Newobject00023"] = oc_Newobject00023;
                                }

                            #endregion

                            oc_Newobject00025["#Newobject00024"] = oc_Newobject00024;
                            }

                        #endregion

                        oc_Newobject00055["#Newobject00025"] = oc_Newobject00025;

                        #region GuiContainer ()        oc_Newobject00027

                        oc_Newobject00027 = new ObjectCreator("GuiContainer", "");
                        oc_Newobject00027["isContainer"] = "1";
                        oc_Newobject00027["Profile"] = "inspectorStyleRolloutDarkProfile";
                        oc_Newobject00027["HorizSizing"] = "width";
                        oc_Newobject00027["VertSizing"] = "bottom";
                        oc_Newobject00027["Position"] = "4 112";
                        oc_Newobject00027["Extent"] = "202 31";
                        oc_Newobject00027["Docking"] = "Top";
                        oc_Newobject00027["Margin"] = "0 0 3 3";
                        if (true)
                            {
                            #region GuiTextCtrl ()        oc_Newobject00026

                            oc_Newobject00026 = new ObjectCreator("GuiTextCtrl", "");
                            oc_Newobject00026["Profile"] = "GuiDefaultProfile";
                            oc_Newobject00026["HorizSizing"] = "right";
                            oc_Newobject00026["VertSizing"] = "bottom";
                            oc_Newobject00026["Position"] = "5 0";
                            oc_Newobject00026["Extent"] = "121 18";
                            oc_Newobject00026["text"] = "Properties";

                            #endregion

                            oc_Newobject00027["#Newobject00026"] = oc_Newobject00026;
                            }

                        #endregion

                        oc_Newobject00055["#Newobject00027"] = oc_Newobject00027;

                        #region GuiScrollCtrl ()        oc_Newobject00053

                        oc_Newobject00053 = new ObjectCreator("GuiScrollCtrl", "");
                        oc_Newobject00053["canSaveDynamicFields"] = "0";
                        oc_Newobject00053["Enabled"] = "1";
                        oc_Newobject00053["isContainer"] = "1";
                        oc_Newobject00053["Profile"] = "GuiEditorScrollProfile";
                        oc_Newobject00053["HorizSizing"] = "width";
                        oc_Newobject00053["VertSizing"] = "height";
                        oc_Newobject00053["Position"] = "4 129";
                        oc_Newobject00053["Extent"] = "202 357";
                        oc_Newobject00053["MinExtent"] = "8 2";
                        oc_Newobject00053["canSave"] = "1";
                        oc_Newobject00053["Visible"] = "1";
                        oc_Newobject00053["tooltipprofile"] = "GuiToolTipProfile";
                        oc_Newobject00053["hovertime"] = "1000";
                        oc_Newobject00053["Docking"] = "Client";
                        oc_Newobject00053["Margin"] = "-14 41 3 3";
                        oc_Newobject00053["Padding"] = "0 0 0 0";
                        oc_Newobject00053["AnchorTop"] = "0";
                        oc_Newobject00053["AnchorBottom"] = "0";
                        oc_Newobject00053["AnchorLeft"] = "0";
                        oc_Newobject00053["AnchorRight"] = "0";
                        oc_Newobject00053["willFirstRespond"] = "1";
                        oc_Newobject00053["hScrollBar"] = "alwaysOff";
                        oc_Newobject00053["vScrollBar"] = "dynamic";
                        oc_Newobject00053["lockHorizScroll"] = "true";
                        oc_Newobject00053["lockVertScroll"] = "false";
                        oc_Newobject00053["constantThumbHeight"] = "0";
                        oc_Newobject00053["childMargin"] = "0 0";
                        oc_Newobject00053["internalName"] = "PropertiesBox";
                        if (true)
                            {
                            #region GuiInspector (NavInspector)        oc_Newobject00028

                            oc_Newobject00028 = new ObjectCreator("GuiInspector", "NavInspector", typeof (NavInspector));
                            oc_Newobject00028["StackingType"] = "Vertical";
                            oc_Newobject00028["HorizStacking"] = "Left to Right";
                            oc_Newobject00028["VertStacking"] = "Top to Bottom";
                            oc_Newobject00028["Padding"] = "1";
                            oc_Newobject00028["name"] = "NavInspector";
                            oc_Newobject00028["canSaveDynamicFields"] = "0";
                            oc_Newobject00028["Enabled"] = "1";
                            oc_Newobject00028["isContainer"] = "1";
                            oc_Newobject00028["Profile"] = "GuiTransparentProfile";
                            oc_Newobject00028["HorizSizing"] = "width";
                            oc_Newobject00028["VertSizing"] = "height";
                            oc_Newobject00028["Position"] = "1 1";
                            oc_Newobject00028["Extent"] = "178 16";
                            oc_Newobject00028["MinExtent"] = "16 16";
                            oc_Newobject00028["canSave"] = "1";
                            oc_Newobject00028["Visible"] = "1";
                            oc_Newobject00028["tooltipprofile"] = "GuiToolTipProfile";
                            oc_Newobject00028["hovertime"] = "1000";
                            oc_Newobject00028["dividerMargin"] = "5";

                            #endregion

                            oc_Newobject00053["#Newobject00028"] = oc_Newobject00028;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00035

                            oc_Newobject00035 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00035["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00035["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00035["internalName"] = "LinkProperties";
                            oc_Newobject00035["position"] = "7 21";
                            oc_Newobject00035["extent"] = "186 64";
                            oc_Newobject00035["padding"] = "2 2 2 2";
                            if (true)
                                {
                                #region GuiCheckBoxCtrl ()        oc_Newobject00029

                                oc_Newobject00029 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshLinkFlagButton));
                                oc_Newobject00029["internalName"] = "LinkWalkFlag";
                                //oc_Newobject00029["class"] = "NavMeshLinkFlagButton";
                                oc_Newobject00029["text"] = " Walk";
                                oc_Newobject00029["buttonType"] = "ToggleButton";
                                oc_Newobject00029["useMouseEvents"] = "0";
                                oc_Newobject00029["extent"] = "159 15";
                                oc_Newobject00029["minExtent"] = "8 2";
                                oc_Newobject00029["horizSizing"] = "right";
                                oc_Newobject00029["vertSizing"] = "bottom";
                                oc_Newobject00029["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00029["visible"] = "1";
                                oc_Newobject00029["active"] = "0";
                                oc_Newobject00029["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00029["toolTip"] = "This link is just ordinary flat ground.";
                                oc_Newobject00029["hovertime"] = "1000";
                                oc_Newobject00029["isContainer"] = "0";
                                oc_Newobject00029["canSave"] = "1";
                                oc_Newobject00029["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00035["#Newobject00029"] = oc_Newobject00029;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00030

                                oc_Newobject00030 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshLinkFlagButton));
                                oc_Newobject00030["internalName"] = "LinkJumpFlag";
                                //oc_Newobject00030["class"] = "NavMeshLinkFlagButton";
                                oc_Newobject00030["text"] = " Jump";
                                oc_Newobject00030["buttonType"] = "ToggleButton";
                                oc_Newobject00030["useMouseEvents"] = "0";
                                oc_Newobject00030["extent"] = "159 15";
                                oc_Newobject00030["minExtent"] = "8 2";
                                oc_Newobject00030["horizSizing"] = "right";
                                oc_Newobject00030["vertSizing"] = "bottom";
                                oc_Newobject00030["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00030["visible"] = "1";
                                oc_Newobject00030["active"] = "0";
                                oc_Newobject00030["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00030["toolTip"] = "Does this link require a jump?";
                                oc_Newobject00030["hovertime"] = "1000";
                                oc_Newobject00030["isContainer"] = "0";
                                oc_Newobject00030["canSave"] = "1";
                                oc_Newobject00030["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00035["#Newobject00030"] = oc_Newobject00030;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00031

                                oc_Newobject00031 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshLinkFlagButton));
                                oc_Newobject00031["internalName"] = "LinkDropFlag";
                                //oc_Newobject00031["class"] = "NavMeshLinkFlagButton";
                                oc_Newobject00031["text"] = " Drop";
                                oc_Newobject00031["buttonType"] = "ToggleButton";
                                oc_Newobject00031["useMouseEvents"] = "0";
                                oc_Newobject00031["extent"] = "159 15";
                                oc_Newobject00031["minExtent"] = "8 2";
                                oc_Newobject00031["horizSizing"] = "right";
                                oc_Newobject00031["vertSizing"] = "bottom";
                                oc_Newobject00031["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00031["visible"] = "1";
                                oc_Newobject00031["active"] = "0";
                                oc_Newobject00031["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00031["toolTip"] = "Does this link involve a significant drop?";
                                oc_Newobject00031["hovertime"] = "1000";
                                oc_Newobject00031["isContainer"] = "0";
                                oc_Newobject00031["canSave"] = "1";
                                oc_Newobject00031["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00035["#Newobject00031"] = oc_Newobject00031;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00032

                                oc_Newobject00032 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshLinkFlagButton));
                                oc_Newobject00032["internalName"] = "LinkLedgeFlag";
                                //oc_Newobject00032["class"] = "NavMeshLinkFlagButton";
                                oc_Newobject00032["text"] = " Ledge";
                                oc_Newobject00032["buttonType"] = "ToggleButton";
                                oc_Newobject00032["useMouseEvents"] = "0";
                                oc_Newobject00032["extent"] = "159 15";
                                oc_Newobject00032["minExtent"] = "8 2";
                                oc_Newobject00032["horizSizing"] = "right";
                                oc_Newobject00032["vertSizing"] = "bottom";
                                oc_Newobject00032["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00032["visible"] = "1";
                                oc_Newobject00032["active"] = "0";
                                oc_Newobject00032["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00032["toolTip"] = "Should the character jump at the next ledge?";
                                oc_Newobject00032["hovertime"] = "1000";
                                oc_Newobject00032["isContainer"] = "0";
                                oc_Newobject00032["canSave"] = "1";
                                oc_Newobject00032["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00035["#Newobject00032"] = oc_Newobject00032;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00033

                                oc_Newobject00033 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshLinkFlagButton));
                                oc_Newobject00033["internalName"] = "LinkClimbFlag";
                                //oc_Newobject00033["class"] = "NavMeshLinkFlagButton";
                                oc_Newobject00033["text"] = " Climb";
                                oc_Newobject00033["buttonType"] = "ToggleButton";
                                oc_Newobject00033["useMouseEvents"] = "0";
                                oc_Newobject00033["extent"] = "159 15";
                                oc_Newobject00033["minExtent"] = "8 2";
                                oc_Newobject00033["horizSizing"] = "right";
                                oc_Newobject00033["vertSizing"] = "bottom";
                                oc_Newobject00033["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00033["visible"] = "1";
                                oc_Newobject00033["active"] = "0";
                                oc_Newobject00033["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00033["toolTip"] = "Does this link involve climbing?";
                                oc_Newobject00033["hovertime"] = "1000";
                                oc_Newobject00033["isContainer"] = "0";
                                oc_Newobject00033["canSave"] = "1";
                                oc_Newobject00033["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00035["#Newobject00033"] = oc_Newobject00033;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00034

                                oc_Newobject00034 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshLinkFlagButton));
                                oc_Newobject00034["internalName"] = "LinkTeleportFlag";
                                //oc_Newobject00034["class"] = "NavMeshLinkFlagButton";
                                oc_Newobject00034["text"] = " Teleport";
                                oc_Newobject00034["buttonType"] = "ToggleButton";
                                oc_Newobject00034["useMouseEvents"] = "0";
                                oc_Newobject00034["extent"] = "159 15";
                                oc_Newobject00034["minExtent"] = "8 2";
                                oc_Newobject00034["horizSizing"] = "right";
                                oc_Newobject00034["vertSizing"] = "bottom";
                                oc_Newobject00034["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00034["visible"] = "1";
                                oc_Newobject00034["active"] = "0";
                                oc_Newobject00034["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00034["toolTip"] = "Is this link a teleporter?";
                                oc_Newobject00034["hovertime"] = "1000";
                                oc_Newobject00034["isContainer"] = "0";
                                oc_Newobject00034["canSave"] = "1";
                                oc_Newobject00034["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00035["#Newobject00034"] = oc_Newobject00034;
                                }

                            #endregion

                            oc_Newobject00053["#Newobject00035"] = oc_Newobject00035;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00038

                            oc_Newobject00038 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00038["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00038["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00038["internalName"] = "TileProperties";
                            oc_Newobject00038["position"] = "7 21";
                            oc_Newobject00038["extent"] = "186 64";
                            oc_Newobject00038["padding"] = "2 2 2 2";
                            if (true)
                                {
                                #region GuiCheckBoxCtrl ()        oc_Newobject00036

                                oc_Newobject00036 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                oc_Newobject00036["text"] = " Display input geometry";
                                oc_Newobject00036["buttonType"] = "ToggleButton";
                                oc_Newobject00036["useMouseEvents"] = "0";
                                oc_Newobject00036["extent"] = "159 15";
                                oc_Newobject00036["minExtent"] = "8 2";
                                oc_Newobject00036["horizSizing"] = "right";
                                oc_Newobject00036["vertSizing"] = "bottom";
                                oc_Newobject00036["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00036["visible"] = "1";
                                oc_Newobject00036["active"] = "1";
                                oc_Newobject00036["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00036["hovertime"] = "1000";
                                oc_Newobject00036["isContainer"] = "0";
                                oc_Newobject00036["canSave"] = "1";
                                oc_Newobject00036["canSaveDynamicFields"] = "0";
                                oc_Newobject00036["variable"] = "$Nav::Editor::renderInput";

                                #endregion

                                oc_Newobject00038["#Newobject00036"] = oc_Newobject00036;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00037

                                oc_Newobject00037 = new ObjectCreator("GuiCheckBoxCtrl", "");
                                oc_Newobject00037["text"] = " Display voxels";
                                oc_Newobject00037["buttonType"] = "ToggleButton";
                                oc_Newobject00037["useMouseEvents"] = "0";
                                oc_Newobject00037["extent"] = "159 15";
                                oc_Newobject00037["minExtent"] = "8 2";
                                oc_Newobject00037["horizSizing"] = "right";
                                oc_Newobject00037["vertSizing"] = "bottom";
                                oc_Newobject00037["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00037["visible"] = "1";
                                oc_Newobject00037["active"] = "1";
                                oc_Newobject00037["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00037["hovertime"] = "1000";
                                oc_Newobject00037["isContainer"] = "0";
                                oc_Newobject00037["canSave"] = "1";
                                oc_Newobject00037["canSaveDynamicFields"] = "0";
                                oc_Newobject00037["variable"] = "$Nav::Editor::renderVoxels";

                                #endregion

                                oc_Newobject00038["#Newobject00037"] = oc_Newobject00037;
                                }

                            #endregion

                            oc_Newobject00053["#Newobject00038"] = oc_Newobject00038;

                            #region GuiFlexibleArrayControl ()        oc_Newobject00052

                            oc_Newobject00052 = new ObjectCreator("GuiFlexibleArrayControl", "");
                            oc_Newobject00052["colSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00052["rowSpacing"] = new Creator.StringNoQuote("2");
                            oc_Newobject00052["internalName"] = "TestProperties";
                            oc_Newobject00052["position"] = "7 21";
                            oc_Newobject00052["extent"] = "186 64";
                            oc_Newobject00052["padding"] = "2 2 2 2";
                            if (true)
                                {
                                #region GuiTextCtrl ()        oc_Newobject00039

                                oc_Newobject00039 = new ObjectCreator("GuiTextCtrl", "");
                                oc_Newobject00039["text"] = "Cover";
                                oc_Newobject00039["profile"] = "GuiTextProfile";
                                oc_Newobject00039["extent"] = "180 20";
                                oc_Newobject00039["minExtent"] = "8 2";
                                oc_Newobject00039["visible"] = "1";

                                #endregion

                                oc_Newobject00052["#Newobject00039"] = oc_Newobject00039;

                                #region GuiTextEditCtrl ()        oc_Newobject00040

                                oc_Newobject00040 = new ObjectCreator("GuiTextEditCtrl", "");
                                oc_Newobject00040["internalName"] = "CoverRadius";
                                oc_Newobject00040["text"] = "10";
                                oc_Newobject00040["profile"] = "GuiTextEditProfile";
                                oc_Newobject00040["extent"] = "40 20";
                                oc_Newobject00040["minExtent"] = "8 2";
                                oc_Newobject00040["visible"] = "1";
                                oc_Newobject00040["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00040["toolTip"] = "Radius for cover-finding.";

                                #endregion

                                oc_Newobject00052["#Newobject00040"] = oc_Newobject00040;

                                #region GuiTextEditCtrl ()        oc_Newobject00041

                                oc_Newobject00041 = new ObjectCreator("GuiTextEditCtrl", "");
                                oc_Newobject00041["internalName"] = "CoverPosition";
                                oc_Newobject00041["text"] = "LocalClientConnection.getControlObject().getPosition();";
                                oc_Newobject00041["profile"] = "GuiTextEditProfile";
                                oc_Newobject00041["extent"] = "140 20";
                                oc_Newobject00041["minExtent"] = "8 2";
                                oc_Newobject00041["visible"] = "1";
                                oc_Newobject00041["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00041["toolTip"] = "Position to find cover from.";

                                #endregion

                                oc_Newobject00052["#Newobject00041"] = oc_Newobject00041;

                                #region GuiTextCtrl ()        oc_Newobject00042

                                oc_Newobject00042 = new ObjectCreator("GuiTextCtrl", "");
                                oc_Newobject00042["text"] = "Follow";
                                oc_Newobject00042["profile"] = "GuiTextProfile";
                                oc_Newobject00042["extent"] = "180 20";
                                oc_Newobject00042["minExtent"] = "8 2";
                                oc_Newobject00042["visible"] = "1";

                                #endregion

                                oc_Newobject00052["#Newobject00042"] = oc_Newobject00042;

                                #region GuiTextEditCtrl ()        oc_Newobject00043

                                oc_Newobject00043 = new ObjectCreator("GuiTextEditCtrl", "");
                                oc_Newobject00043["internalName"] = "FollowRadius";
                                oc_Newobject00043["text"] = "1";
                                oc_Newobject00043["profile"] = "GuiTextEditProfile";
                                oc_Newobject00043["extent"] = "40 20";
                                oc_Newobject00043["minExtent"] = "8 2";
                                oc_Newobject00043["visible"] = "1";
                                oc_Newobject00043["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00043["toolTip"] = "Radius for following.";

                                #endregion

                                oc_Newobject00052["#Newobject00043"] = oc_Newobject00043;

                                #region GuiTextEditCtrl ()        oc_Newobject00044

                                oc_Newobject00044 = new ObjectCreator("GuiTextEditCtrl", "");
                                oc_Newobject00044["internalName"] = "FollowObject";
                                oc_Newobject00044["text"] = "LocalClientConnection.player";
                                oc_Newobject00044["profile"] = "GuiTextEditProfile";
                                oc_Newobject00044["extent"] = "140 20";
                                oc_Newobject00044["minExtent"] = "8 2";
                                oc_Newobject00044["visible"] = "1";
                                oc_Newobject00044["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00044["toolTip"] = "Object to follow.";

                                #endregion

                                oc_Newobject00052["#Newobject00044"] = oc_Newobject00044;

                                #region GuiTextCtrl ()        oc_Newobject00045

                                oc_Newobject00045 = new ObjectCreator("GuiTextCtrl", "");
                                oc_Newobject00045["text"] = "Movement";
                                oc_Newobject00045["profile"] = "GuiTextProfile";
                                oc_Newobject00045["extent"] = "180 20";
                                oc_Newobject00045["minExtent"] = "8 2";
                                oc_Newobject00045["visible"] = "1";

                                #endregion

                                oc_Newobject00052["#Newobject00045"] = oc_Newobject00045;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00046

                                oc_Newobject00046 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshTestFlagButton));
                                oc_Newobject00046["internalName"] = "LinkWalkFlag";
                                //oc_Newobject00046["class"] = "NavMeshTestFlagButton";
                                oc_Newobject00046["text"] = " Walk";
                                oc_Newobject00046["buttonType"] = "ToggleButton";
                                oc_Newobject00046["useMouseEvents"] = "0";
                                oc_Newobject00046["extent"] = "159 15";
                                oc_Newobject00046["minExtent"] = "8 2";
                                oc_Newobject00046["horizSizing"] = "right";
                                oc_Newobject00046["vertSizing"] = "bottom";
                                oc_Newobject00046["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00046["visible"] = "1";
                                oc_Newobject00046["active"] = "0";
                                oc_Newobject00046["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00046["toolTip"] = "Can this character walk on ground?";
                                oc_Newobject00046["hovertime"] = "1000";
                                oc_Newobject00046["isContainer"] = "0";
                                oc_Newobject00046["canSave"] = "1";
                                oc_Newobject00046["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00052["#Newobject00046"] = oc_Newobject00046;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00047

                                oc_Newobject00047 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshTestFlagButton));
                                oc_Newobject00047["internalName"] = "LinkJumpFlag";
                                //oc_Newobject00047["class"] = "NavMeshTestFlagButton";
                                oc_Newobject00047["text"] = " Jump";
                                oc_Newobject00047["buttonType"] = "ToggleButton";
                                oc_Newobject00047["useMouseEvents"] = "0";
                                oc_Newobject00047["extent"] = "159 15";
                                oc_Newobject00047["minExtent"] = "8 2";
                                oc_Newobject00047["horizSizing"] = "right";
                                oc_Newobject00047["vertSizing"] = "bottom";
                                oc_Newobject00047["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00047["visible"] = "1";
                                oc_Newobject00047["active"] = "0";
                                oc_Newobject00047["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00047["toolTip"] = "Can this character jump?";
                                oc_Newobject00047["hovertime"] = "1000";
                                oc_Newobject00047["isContainer"] = "0";
                                oc_Newobject00047["canSave"] = "1";
                                oc_Newobject00047["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00052["#Newobject00047"] = oc_Newobject00047;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00048

                                oc_Newobject00048 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshTestFlagButton));
                                oc_Newobject00048["internalName"] = "LinkDropFlag";
                                //oc_Newobject00048["class"] = "NavMeshTestFlagButton";
                                oc_Newobject00048["text"] = " Drop";
                                oc_Newobject00048["buttonType"] = "ToggleButton";
                                oc_Newobject00048["useMouseEvents"] = "0";
                                oc_Newobject00048["extent"] = "159 15";
                                oc_Newobject00048["minExtent"] = "8 2";
                                oc_Newobject00048["horizSizing"] = "right";
                                oc_Newobject00048["vertSizing"] = "bottom";
                                oc_Newobject00048["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00048["visible"] = "1";
                                oc_Newobject00048["active"] = "0";
                                oc_Newobject00048["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00048["toolTip"] = "Can this character drop over edges?";
                                oc_Newobject00048["hovertime"] = "1000";
                                oc_Newobject00048["isContainer"] = "0";
                                oc_Newobject00048["canSave"] = "1";
                                oc_Newobject00048["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00052["#Newobject00048"] = oc_Newobject00048;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00049

                                oc_Newobject00049 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshTestFlagButton));
                                oc_Newobject00049["internalName"] = "LinkLedgeFlag";
                                //oc_Newobject00049["class"] = "NavMeshTestFlagButton";
                                oc_Newobject00049["text"] = " Ledge";
                                oc_Newobject00049["buttonType"] = "ToggleButton";
                                oc_Newobject00049["useMouseEvents"] = "0";
                                oc_Newobject00049["extent"] = "159 15";
                                oc_Newobject00049["minExtent"] = "8 2";
                                oc_Newobject00049["horizSizing"] = "right";
                                oc_Newobject00049["vertSizing"] = "bottom";
                                oc_Newobject00049["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00049["visible"] = "1";
                                oc_Newobject00049["active"] = "0";
                                oc_Newobject00049["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00049["toolTip"] = "Can this character jump from ledges?";
                                oc_Newobject00049["hovertime"] = "1000";
                                oc_Newobject00049["isContainer"] = "0";
                                oc_Newobject00049["canSave"] = "1";
                                oc_Newobject00049["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00052["#Newobject00049"] = oc_Newobject00049;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00050

                                oc_Newobject00050 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshTestFlagButton));
                                oc_Newobject00050["internalName"] = "LinkClimbFlag";
                                //oc_Newobject00050["class"] = "NavMeshTestFlagButton";
                                oc_Newobject00050["text"] = " Climb";
                                oc_Newobject00050["buttonType"] = "ToggleButton";
                                oc_Newobject00050["useMouseEvents"] = "0";
                                oc_Newobject00050["extent"] = "159 15";
                                oc_Newobject00050["minExtent"] = "8 2";
                                oc_Newobject00050["horizSizing"] = "right";
                                oc_Newobject00050["vertSizing"] = "bottom";
                                oc_Newobject00050["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00050["visible"] = "1";
                                oc_Newobject00050["active"] = "0";
                                oc_Newobject00050["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00050["toolTip"] = "Can this character climb?";
                                oc_Newobject00050["hovertime"] = "1000";
                                oc_Newobject00050["isContainer"] = "0";
                                oc_Newobject00050["canSave"] = "1";
                                oc_Newobject00050["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00052["#Newobject00050"] = oc_Newobject00050;

                                #region GuiCheckBoxCtrl ()        oc_Newobject00051

                                oc_Newobject00051 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (NavMeshTestFlagButton));
                                oc_Newobject00051["internalName"] = "LinkTeleportFlag";
                                //oc_Newobject00051["class"] = "NavMeshTestFlagButton";
                                oc_Newobject00051["text"] = " Teleport";
                                oc_Newobject00051["buttonType"] = "ToggleButton";
                                oc_Newobject00051["useMouseEvents"] = "0";
                                oc_Newobject00051["extent"] = "159 15";
                                oc_Newobject00051["minExtent"] = "8 2";
                                oc_Newobject00051["horizSizing"] = "right";
                                oc_Newobject00051["vertSizing"] = "bottom";
                                oc_Newobject00051["profile"] = "GuiCheckBoxProfile";
                                oc_Newobject00051["visible"] = "1";
                                oc_Newobject00051["active"] = "0";
                                oc_Newobject00051["tooltipProfile"] = "GuiToolTipProfile";
                                oc_Newobject00051["toolTip"] = "Can this character teleport?";
                                oc_Newobject00051["hovertime"] = "1000";
                                oc_Newobject00051["isContainer"] = "0";
                                oc_Newobject00051["canSave"] = "1";
                                oc_Newobject00051["canSaveDynamicFields"] = "0";

                                #endregion

                                oc_Newobject00052["#Newobject00051"] = oc_Newobject00051;
                                }

                            #endregion

                            oc_Newobject00053["#Newobject00052"] = oc_Newobject00052;
                            }

                        #endregion

                        oc_Newobject00055["#Newobject00053"] = oc_Newobject00053;

                        #region GuiMLTextCtrl (NavFieldInfoControl)        oc_Newobject00054

                        oc_Newobject00054 = new ObjectCreator("GuiMLTextCtrl", "NavFieldInfoControl");
                        oc_Newobject00054["canSaveDynamicFields"] = "0";
                        oc_Newobject00054["Enabled"] = "1";
                        oc_Newobject00054["isContainer"] = "0";
                        oc_Newobject00054["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
                        oc_Newobject00054["HorizSizing"] = "width";
                        oc_Newobject00054["VertSizing"] = "top";
                        oc_Newobject00054["Position"] = "1 485";
                        oc_Newobject00054["Extent"] = "202 42";
                        oc_Newobject00054["MinExtent"] = "8 2";
                        oc_Newobject00054["canSave"] = "1";
                        oc_Newobject00054["Visible"] = "1";
                        oc_Newobject00054["tooltipprofile"] = "GuiToolTipProfile";
                        oc_Newobject00054["hovertime"] = "1000";
                        oc_Newobject00054["lineSpacing"] = "2";
                        oc_Newobject00054["allowColorChars"] = "0";
                        oc_Newobject00054["maxChars"] = "-1";
                        oc_Newobject00054["useURLMouseCursor"] = "0";

                        #endregion

                        oc_Newobject00055["#Newobject00054"] = oc_Newobject00054;
                        }

                    #endregion

                    oc_Newobject00056["#Newobject00055"] = oc_Newobject00055;
                    }

                #endregion

                oc_Newobject00056.Create();
                }

            bGlobal["$Nav::EditorOpen"] = false;
            bGlobal["$Nav::Editor::renderMesh"] = true;
            bGlobal["$Nav::Editor::renderPortals"] = false;
            bGlobal["$Nav::Editor::renderBVTree"] = false;
            bGlobal["$Nav::Editor::backgroundBuild"] = true;
            bGlobal["$Nav::Editor::saveIntermediates"] = false;
            bGlobal["$Nav::Editor::playSoundWhenDone"] = false;
        }

        [ConsoleInteraction]
        public void onEditorActivated()
        {
            if (selectedObject != 0)
                selectObject(selectedObject);
            prepSelectionMode();
        }

        [ConsoleInteraction]
        public void onEditorDeactivated()
        {
            if (getMesh() != 0)
                deselect();
        }

        [ConsoleInteraction]
        public override void onModeSet(string mode)
        {
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            NavInspector NavInspector = "NavInspector";
            GuiContainer actions = NavEditorOptionsWindow.FOT("ActionsBox");
            GuiScrollCtrl properties = NavEditorOptionsWindow.FOT("PropertiesBox");
            GuiFlexibleArrayControl SelectActions = actions.FOT("SelectActions");
            GuiFlexibleArrayControl LinkActions = actions.FOT("LinkActions");
            GuiFlexibleArrayControl CoverActions = actions.FOT("CoverActions");
            GuiFlexibleArrayControl TileActions = actions.FOT("TileActions");
            GuiFlexibleArrayControl TestActions = actions.FOT("TestActions");

            GuiFlexibleArrayControl LinkProperties = properties.FOT("LinkProperties");
            GuiFlexibleArrayControl TileProperties = properties.FOT("TileProperties");
            GuiFlexibleArrayControl TestProperties = properties.FOT("TestProperties");

            // Callback when the nav editor changes mode. Set the appropriate dynamic
            // GUI contents in the properties/actions boxes.
            NavInspector.setVisible(false);

            SelectActions.setVisible(false);
            LinkActions.setVisible(false);
            CoverActions.setVisible(false);
            TileActions.setVisible(false);
            TestActions.setVisible(false);

            LinkProperties.setVisible(false);
            TileProperties.setVisible(false);
            TestProperties.setVisible(false);

            switch (mode)
                {
                    case "SelectMode":
                        NavInspector.setVisible(true);
                        SelectActions.setVisible(true);
                        break;
                    case "LinkMode":
                        LinkActions.setVisible(true);
                        LinkProperties.setVisible(true);
                        break;
                    case "CoverMode":
                        CoverActions.setVisible(true);
                        break;
                    case "TileMode":
                        TileActions.setVisible(true);
                        TileProperties.setVisible(true);
                        break;
                    case "TestMode":
                        TestActions.setVisible(true);
                        TestProperties.setVisible(true);
                        break;
                }
        }

        [ConsoleInteraction]
        public override void paletteSync(string mode)
        {
            // Synchronise the palette (small buttons on the left) with the actual mode
            // the nav editor is in.
            string evalShortcut = "ToolsPaletteArray-->" + mode + ".setStateOn(1);";
            Util.eval(evalShortcut);
        }

        [ConsoleInteraction]
        public bool onEscapePressed()
        {
            return false;
        }

        [ConsoleInteraction]
        public void selectObject(NavMesh obj)
        {
            NavTreeView NavTreeView = "NavTreeView";
            NavTreeView.clearSelection();
            if (Util.isObject(obj))
                NavTreeView.selectItem(obj);
            onObjectSelected(obj);
        }

        [ConsoleInteraction]
        public void onObjectSelected(NavMesh obj)
        {
            if (Util.isObject(selectedObject))
                deselect();
            selectedObject = obj;
            if (Util.isObject(obj))
                {
                selectMesh(obj);
                NavInspector NavInspector = "NavInspector";
                NavInspector.inspect(obj);
                }
        }

        [ConsoleInteraction]
        public void deleteMesh()
        {
            if (Util.isObject(selectedObject))
                {
                selectedObject.delete();
                selectObject(0);
                }
        }

        [ConsoleInteraction]
        public void deleteSelected()
        {
            switch (getMode())
                {
                    case "SelectMode":
                        // Try to delete the selected NavMesh.
                        if (Util.isObject(selectedObject))
                            messageBox.MessageBoxYesNo("Warning", "Are you sure you want to delete" + " " + selectedObject.getName(), "NavEditorGui.deleteMesh();");
                        break;
                    case "TestMode":
                        ((SimObject) getPlayer()).delete();
                        onPlayerDeselected();
                        break;
                    case "LinkMode":
                        deleteLink();
                        isDirty = true;
                        break;
                }
        }

        [ConsoleInteraction]
        public void buildSelectedMeshes()
        {
            if (Util.isObject(getMesh().AsString()))
                {
                ((NavMesh) getMesh()).build(bGlobal["$Nav::Editor::backgroundBuild"], bGlobal["$Nav::Editor::saveIntermediates"]);
                isDirty = true;
                }
        }

        [ConsoleInteraction]
        public void buildLinks()
        {
            if (Util.isObject(getMesh().AsString()))
                {
                ((NavMesh) getMesh()).buildLinks();
                isDirty = true;
                }
        }

        [ConsoleInteraction]
        public static void updateLinkData(GuiControl control, int flags)
        {
            GuiCheckBoxCtrl LinkWalkFlag = control.FOT("LinkWalkFlag");
            GuiCheckBoxCtrl LinkJumpFlag = control.FOT("LinkJumpFlag");
            GuiCheckBoxCtrl LinkDropFlag = control.FOT("LinkDropFlag");
            GuiCheckBoxCtrl LinkLedgeFlag = control.FOT("LinkLedgeFlag");
            GuiCheckBoxCtrl LinkClimbFlag = control.FOT("LinkClimbFlag");
            GuiCheckBoxCtrl LinkTeleportFlag = control.FOT("LinkTeleportFlag");
            LinkWalkFlag.setActive(true);
            LinkJumpFlag.setActive(true);
            LinkDropFlag.setActive(true);
            LinkLedgeFlag.setActive(true);
            LinkClimbFlag.setActive(true);
            LinkTeleportFlag.setActive(true);

            LinkWalkFlag.setStateOn(flags == iGlobal["$Nav::WalkFlag"]);
            LinkJumpFlag.setStateOn(flags == iGlobal["$Nav::JumpFlag"]);
            LinkDropFlag.setStateOn(flags == iGlobal["$Nav::DropFlag"]);
            LinkLedgeFlag.setStateOn(flags == iGlobal["$Nav::LedgeFlag"]);
            LinkClimbFlag.setStateOn(flags == iGlobal["$Nav::ClimbFlag"]);
            LinkTeleportFlag.setStateOn(flags == iGlobal["$Nav::TeleportFlag"]);
        }

        [ConsoleInteraction]
        public static int getLinkFlags(GuiControl control)
        {
            GuiCheckBoxCtrl LinkWalkFlag = control.FOT("LinkWalkFlag");
            GuiCheckBoxCtrl LinkJumpFlag = control.FOT("LinkJumpFlag");
            GuiCheckBoxCtrl LinkDropFlag = control.FOT("LinkDropFlag");
            GuiCheckBoxCtrl LinkLedgeFlag = control.FOT("LinkLedgeFlag");
            GuiCheckBoxCtrl LinkClimbFlag = control.FOT("LinkClimbFlag");
            GuiCheckBoxCtrl LinkTeleportFlag = control.FOT("LinkTeleportFlag");

            return (LinkWalkFlag.isStateOn() ? iGlobal["$Nav::WalkFlag"] : 0) | (LinkJumpFlag.isStateOn() ? iGlobal["$Nav::JumpFlag"] : 0) | (LinkDropFlag.isStateOn() ? iGlobal["$Nav::DropFlag"] : 0) | (LinkLedgeFlag.isStateOn() ? iGlobal["$Nav::LedgeFlag"] : 0) | (LinkClimbFlag.isStateOn() ? iGlobal["$Nav::ClimbFlag"] : 0) | (LinkTeleportFlag.isStateOn() ? iGlobal["$Nav::TeleportFlag"] : 0);
        }

        [ConsoleInteraction]
        public static void disableLinkData(GuiControl control)
        {
            GuiCheckBoxCtrl LinkWalkFlag = control.FOT("LinkWalkFlag");
            GuiCheckBoxCtrl LinkJumpFlag = control.FOT("LinkJumpFlag");
            GuiCheckBoxCtrl LinkDropFlag = control.FOT("LinkDropFlag");
            GuiCheckBoxCtrl LinkLedgeFlag = control.FOT("LinkLedgeFlag");
            GuiCheckBoxCtrl LinkClimbFlag = control.FOT("LinkClimbFlag");
            GuiCheckBoxCtrl LinkTeleportFlag = control.FOT("LinkTeleportFlag");

            LinkWalkFlag.setActive(false);
            LinkJumpFlag.setActive(false);
            LinkDropFlag.setActive(false);
            LinkLedgeFlag.setActive(false);
            LinkClimbFlag.setActive(false);
            LinkTeleportFlag.setActive(false);
        }

        [ConsoleInteraction]
        public override void onLinkSelected(int linkDataFlags)
        {
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiFlexibleArrayControl LinkProperties = NavEditorOptionsWindow.FOT("LinkProperties");

            updateLinkData(LinkProperties, linkDataFlags);
        }

        [ConsoleInteraction]
        public override void onPlayerSelected(int linkDataFlags)
        {
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiFlexibleArrayControl TestProperties = NavEditorOptionsWindow.FOT("TestProperties");
            updateLinkData(TestProperties, linkDataFlags);
        }

        [ConsoleInteraction]
        public void updateLinkFlags()
        {
            if (Util.isObject(getMesh().AsString()))
                {
                GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
                GuiFlexibleArrayControl properties = NavEditorOptionsWindow.FOT("LinkProperties");
                setLinkFlags((uint) getLinkFlags(properties));
                isDirty = true;
                }
        }

        [ConsoleInteraction]
        public void updateTestFlags()
        {
            if (Util.isObject(getPlayer().AsString()))
                {
                GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
                GuiFlexibleArrayControl properties = NavEditorOptionsWindow.FOT("TestProperties");

                GuiCheckBoxCtrl LinkWalkFlag = properties.FOT("LinkWalkFlag");
                GuiCheckBoxCtrl LinkJumpFlag = properties.FOT("LinkJumpFlag");
                GuiCheckBoxCtrl LinkDropFlag = properties.FOT("LinkDropFlag");
                GuiCheckBoxCtrl LinkLedgeFlag = properties.FOT("LinkLedgeFlag");
                GuiCheckBoxCtrl LinkClimbFlag = properties.FOT("LinkClimbFlag");
                GuiCheckBoxCtrl LinkTeleportFlag = properties.FOT("LinkTeleportFlag");

                SimObject player = this.getPlayer();

                player["allowWwalk"] = LinkWalkFlag.isStateOn().AsString();
                player["allowJump"] = LinkJumpFlag.isStateOn().AsString();
                player["allowDrop"] = LinkDropFlag.isStateOn().AsString();
                player["allowLedge"] = LinkLedgeFlag.isStateOn().AsString();
                player["allowClimb"] = LinkClimbFlag.isStateOn().AsString();
                player["allowTeleport"] = LinkTeleportFlag.isStateOn().AsString();

                isDirty = true;
                }
        }

        [ConsoleInteraction]
        public override void onLinkDeselected()
        {
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiFlexibleArrayControl LinkProperties = NavEditorOptionsWindow.FOT("LinkProperties");
            disableLinkData(LinkProperties);
        }

        [ConsoleInteraction]
        public override void onPlayerDeselected()
        {
            GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
            GuiFlexibleArrayControl TestProperties = NavEditorOptionsWindow.FOT("TestProperties");
            disableLinkData(TestProperties);
        }

        [ConsoleInteraction]
        public void createCoverPoints()
        {
            if (Util.isObject(getMesh().AsString()))
                {
                ((NavMesh) getMesh()).createCoverPoints();
                isDirty = true;
                }
        }

        [ConsoleInteraction]
        public void deleteCoverPoints()
        {
            if (Util.isObject(getMesh().AsString()))
                {
                ((NavMesh) getMesh()).deleteCoverPoints();
                isDirty = true;
                }
        }

        [ConsoleInteraction]
        public void findCover()
        {
            if (getMode() == "TestMode" && Util.isObject(getPlayer().AsString()))
                {
                GameConnection LocalClientConnection = "LocalClientConnection";
                GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
                GuiFlexibleArrayControl TestProperties = NavEditorOptionsWindow.FOT("TestProperties");
                GuiTextEditCtrl CoverPosition = TestProperties.FOT("CoverPosition");
                GuiTextEditCtrl CoverRadius = TestProperties.FOT("CoverRadius");

                Point3F pos = ((SceneObject) LocalClientConnection.getControlObject()).getPosition();
                string text = CoverPosition.getText();
                if (text != "")
                    pos = Util.eval(text).AsPoint3F();
                ((AIPlayer) getPlayer()).findCover(pos, CoverRadius.getText().AsFloat());
                }
        }

        [ConsoleInteraction]
        public void followObject()
        {
            if (getMode() == "TestMode" && Util.isObject(getPlayer().AsString()))
                {
                GameConnection LocalClientConnection = "LocalClientConnection";
                GuiWindowCollapseCtrl NavEditorOptionsWindow = "NavEditorOptionsWindow";
                GuiFlexibleArrayControl TestProperties = NavEditorOptionsWindow.FOT("TestProperties");
                GuiTextEditCtrl FollowObject = TestProperties.FOT("FollowObject");
                GuiTextEditCtrl FollowRadius = TestProperties.FOT("FollowRadius");

                SimObject obj = LocalClientConnection["player"];
                string text = FollowObject.getText();
                if (text != "")
                    {
                    obj = Util.eval("%obj = " + text + ";return %obj;");
                    if (!Util.isObject(obj))
                        messageBox.MessageBoxOK("Error", "Cannot find object" + " " + text);
                    }
                if (Util.isObject(obj))
                    ((AIPlayer) getPlayer()).followObject(obj, FollowRadius.getText().AsFloat());
                }
        }

        [ConsoleInteraction]
        public void prepSelectionMode()
        {
            GuiDynamicCtrlArrayControl ToolsPaletteArray = "ToolsPaletteArray";
            GuiBitmapButtonCtrl NavEditorSelectMode = ToolsPaletteArray.FOT("NavEditorSelectMode");
            setMode("SelectMode");
            NavEditorSelectMode.setStateOn(true);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavEditorGui ts, string simobjectid)
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
        public static bool operator !=(NavEditorGui ts, string simobjectid)
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
        public static implicit operator string(NavEditorGui ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator NavEditorGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavEditorGui) Omni.self.getSimObject(simobjectid, typeof (NavEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavEditorGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavEditorGui(int simobjectid)
        {
            return (NavEditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (NavEditorGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavEditorGui ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavEditorGui(uint simobjectid)
        {
            return (NavEditorGui) Omni.self.getSimObject(simobjectid, typeof (NavEditorGui));
        }

        #endregion
    }

    [TypeConverter(typeof (TypeConverterGeneric<NavInspector>))]
    public class NavInspector : GuiInspector
    {
        [ConsoleInteraction]
        public void inspect(string obj)
        {
            GuiMLTextCtrl NavFieldInfoControl = "NavFieldInfoControl";
            string name = "";
            if (Util.isObject(obj))
                name = obj.getName();
            else
                NavFieldInfoControl.setText("");

            base.inspect(obj);
        }

        [ConsoleInteraction]
        public override void onInspectorFieldModified(string objectx, string fieldName, string arrayIndex, string oldValue, string newValue)
        {
            // Same work to do as for the regular WorldEditor Inspector.
            Inspector Inspector = "Inspector";
            Inspector.onInspectorFieldModified(objectx, fieldName, arrayIndex, oldValue, newValue);
        }

        [ConsoleInteraction]
        public override void onFieldSelected(string fieldName, string fieldTypeStr, string fieldDoc)
        {
            GuiMLTextCtrl NavFieldInfoControl = "NavFieldInfoControl";
            NavFieldInfoControl.setText("<font:ArialBold:14>" + fieldName + "<font:ArialItalic:14> (" + fieldTypeStr + ") " + '\n' + "<font:Arial:14>" + fieldDoc);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavInspector ts, string simobjectid)
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
        public static bool operator !=(NavInspector ts, string simobjectid)
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
        public static implicit operator string(NavInspector ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator NavInspector(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavInspector) Omni.self.getSimObject(simobjectid, typeof (NavInspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavInspector ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavInspector(int simobjectid)
        {
            return (NavInspector) Omni.self.getSimObject((uint) simobjectid, typeof (NavInspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavInspector ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavInspector(uint simobjectid)
        {
            return (NavInspector) Omni.self.getSimObject(simobjectid, typeof (NavInspector));
        }

        #endregion
    }

    [TypeConverter(typeof (TypeConverterGeneric<NavTreeView>))]
    public class NavTreeView : GuiTreeViewCtrl
    {
        [ConsoleInteraction]
        public override void onInspect(int obj)
        {
            NavInspector NavInspector = "NavInspector";
            NavInspector.inspect(obj.AsString());
        }

        [ConsoleInteraction]
        public override void onSelect(string obj, string y)
        {
            NavInspector NavInspector = "NavInspector";
            NavEditorGui NavEditorGui = "NavEditorGui";

            NavInspector.inspect(obj);
            NavEditorGui.onObjectSelected(obj);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavTreeView ts, string simobjectid)
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
        public static bool operator !=(NavTreeView ts, string simobjectid)
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
        public static implicit operator string(NavTreeView ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator NavTreeView(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavTreeView) Omni.self.getSimObject(simobjectid, typeof (NavTreeView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavTreeView ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavTreeView(int simobjectid)
        {
            return (NavTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (NavTreeView));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavTreeView ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavTreeView(uint simobjectid)
        {
            return (NavTreeView) Omni.self.getSimObject(simobjectid, typeof (NavTreeView));
        }

        #endregion
    }

    //-----------------------------------------------------------------------------
    [TypeConverter(typeof (TypeConverterGeneric<ENavEditorPaletteButton>))]
    public class ENavEditorPaletteButton : GuiBitmapButtonCtrl
    {
        [ConsoleInteraction]
        public override void onClick(string SelectedidString)
        {
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            // When clicking on a pelette button, add its description to the bottom of
            // the editor window.
            EditorGuiStatusBar.setInfo(this["DetailedDesc"]);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ENavEditorPaletteButton ts, string simobjectid)
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
        public static bool operator !=(ENavEditorPaletteButton ts, string simobjectid)
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
        public static implicit operator string(ENavEditorPaletteButton ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ENavEditorPaletteButton(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ENavEditorPaletteButton) Omni.self.getSimObject(simobjectid, typeof (ENavEditorPaletteButton));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ENavEditorPaletteButton ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ENavEditorPaletteButton(int simobjectid)
        {
            return (ENavEditorPaletteButton) Omni.self.getSimObject((uint) simobjectid, typeof (ENavEditorPaletteButton));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ENavEditorPaletteButton ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ENavEditorPaletteButton(uint simobjectid)
        {
            return (ENavEditorPaletteButton) Omni.self.getSimObject(simobjectid, typeof (ENavEditorPaletteButton));
        }

        #endregion
    }

    //-----------------------------------------------------------------------------
    [TypeConverter(typeof (TypeConverterGeneric<NavMeshLinkFlagButton>))]
    public class NavMeshLinkFlagButton : GuiCheckBoxCtrl
    {
        [ConsoleInteraction]
        public override void onClick(string SelectedidString)
        {
            NavEditorGui NavEditorGui = "NavEditorGui";
            NavEditorGui.updateLinkFlags();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavMeshLinkFlagButton ts, string simobjectid)
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
        public static bool operator !=(NavMeshLinkFlagButton ts, string simobjectid)
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
        public static implicit operator string(NavMeshLinkFlagButton ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator NavMeshLinkFlagButton(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavMeshLinkFlagButton) Omni.self.getSimObject(simobjectid, typeof (NavMeshLinkFlagButton));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavMeshLinkFlagButton ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavMeshLinkFlagButton(int simobjectid)
        {
            return (NavMeshLinkFlagButton) Omni.self.getSimObject((uint) simobjectid, typeof (NavMeshLinkFlagButton));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavMeshLinkFlagButton ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavMeshLinkFlagButton(uint simobjectid)
        {
            return (NavMeshLinkFlagButton) Omni.self.getSimObject(simobjectid, typeof (NavMeshLinkFlagButton));
        }

        #endregion
    }

    [TypeConverter(typeof (TypeConverterGeneric<NavMeshTestFlagButton>))]
    public class NavMeshTestFlagButton : GuiCheckBoxCtrl
    {
        [ConsoleInteraction]
        public override void onClick(string SelectedidString)
        {
            NavEditorGui NavEditorGui = "NavEditorGui";
            NavEditorGui.updateTestFlags();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(NavMeshTestFlagButton ts, string simobjectid)
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
        public static bool operator !=(NavMeshTestFlagButton ts, string simobjectid)
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
        public static implicit operator string(NavMeshTestFlagButton ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator NavMeshTestFlagButton(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (NavMeshTestFlagButton) Omni.self.getSimObject(simobjectid, typeof (NavMeshTestFlagButton));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(NavMeshTestFlagButton ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator NavMeshTestFlagButton(int simobjectid)
        {
            return (NavMeshTestFlagButton) Omni.self.getSimObject((uint) simobjectid, typeof (NavMeshTestFlagButton));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(NavMeshTestFlagButton ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator NavMeshTestFlagButton(uint simobjectid)
        {
            return (NavMeshTestFlagButton) Omni.self.getSimObject(simobjectid, typeof (NavMeshTestFlagButton));
        }

        #endregion
    }
}