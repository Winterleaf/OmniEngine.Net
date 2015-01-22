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
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ParticleEditor>))]
    public class ParticleEditor : ScriptObject
    {

        [ConsoleInteraction(true, "ParticleEditor_initialize")]
        public static void initialize()
        {
            sGlobal["$PE_guielement_pos_single_container"] = "0 0";
            sGlobal["$PE_guielement_ext_single_container"] = "184 20";
            sGlobal["$PE_guielement_pos_name"] = "1 0";
            sGlobal["$PE_guielement_ext_name"] = "70 18";
            sGlobal["$PE_guielement_pos_slider"] = "74 2";
            sGlobal["$PE_guielement_ext_slider"] = "58 12";
            sGlobal["$PE_guielement_pos_value"] = "138 0";
            sGlobal["$PE_guielement_ext_value"] = "36 18";
            sGlobal["$PE_guielement_pos_textedit"] = "74 0";
            sGlobal["$PE_guielement_ext_textedit"] = "100 18";
            sGlobal["$PE_guielement_ext_checkbox_name"] = "156 18";
            sGlobal["$PE_guielement_pos_checkbox"] = "161 0";
            sGlobal["$PE_guielement_ext_checkbox"] = "15 18";
            sGlobal["$PE_guielement_pos_colorpicker"] = "158 0";
            sGlobal["$PE_guielement_ext_colorpicker"] = "18 18";

            #region GuiWindowCollapseCtrl (PE_Window)        oc_Newobject243

            ObjectCreator oc_Newobject243 = new ObjectCreator("GuiWindowCollapseCtrl", "PE_Window", typeof (PE_Window));
            oc_Newobject243["AllowPopWindow"] = "1";
            oc_Newobject243["canSaveDynamicFields"] = "0";
            oc_Newobject243["Enabled"] = "1";
            oc_Newobject243["isContainer"] = "1";
            oc_Newobject243["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject243["Position"] = new Creator.StringNoQuote("firstWord($pref::Video::mode) - 209      SPC getWord(EditorGuiToolbar.extent, 1) -1");
            oc_Newobject243["Extent"] = "210 696";
            oc_Newobject243["MinExtent"] = "210 140";
            oc_Newobject243["HorizSizing"] = "windowRelative";
            oc_Newobject243["VertSizing"] = "windowRelative";
            oc_Newobject243["canSave"] = "1";
            oc_Newobject243["Visible"] = "1";
            oc_Newobject243["hovertime"] = "1000";
            oc_Newobject243["Margin"] = "0 0 0 0";
            oc_Newobject243["Padding"] = "0 0 0 0";
            oc_Newobject243["AnchorTop"] = "1";
            oc_Newobject243["AnchorBottom"] = "0";
            oc_Newobject243["AnchorLeft"] = "1";
            oc_Newobject243["AnchorRight"] = "0";
            oc_Newobject243["resizeWidth"] = "1";
            oc_Newobject243["resizeHeight"] = "1";
            oc_Newobject243["canMove"] = "1";
            oc_Newobject243["canClose"] = "0";
            oc_Newobject243["canMinimize"] = "0";
            oc_Newobject243["canMaximize"] = "0";
            oc_Newobject243["minSize"] = "50 50";
            oc_Newobject243["closeCommand"] = "";
            oc_Newobject243["EdgeSnap"] = "0";
            oc_Newobject243["text"] = "Particle Editor";

            #region GuiTabBookCtrl (PE_TabBook)        oc_Newobject240

            ObjectCreator oc_Newobject240 = new ObjectCreator("GuiTabBookCtrl", "PE_TabBook", typeof (PE_TabBook));
            oc_Newobject240["canSaveDynamicFields"] = "0";
            oc_Newobject240["isContainer"] = "1";
            oc_Newobject240["internalName"] = "EditorTabBook";
            oc_Newobject240["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject240["HorizSizing"] = "width";
            oc_Newobject240["VertSizing"] = "height";
            oc_Newobject240["position"] = "6 27";
            oc_Newobject240["Extent"] = "197 289";
            oc_Newobject240["MinExtent"] = "8 2";
            oc_Newobject240["canSave"] = "1";
            oc_Newobject240["Visible"] = "1";
            oc_Newobject240["hovertime"] = "1000";
            oc_Newobject240["Margin"] = "3 2 3 3";
            oc_Newobject240["Docking"] = "client";
            oc_Newobject240["Padding"] = "0 0 0 0";
            oc_Newobject240["AnchorTop"] = "1";
            oc_Newobject240["AnchorBottom"] = "0";
            oc_Newobject240["AnchorLeft"] = "1";
            oc_Newobject240["AnchorRight"] = "0";
            oc_Newobject240["TabPosition"] = "Top";
            oc_Newobject240["TabMargin"] = "0";
            oc_Newobject240["MinTabWidth"] = "64";

            #region GuiTabPageCtrl (PE_EmitterEditor)        oc_Newobject127

            ObjectCreator oc_Newobject127 = new ObjectCreator("GuiTabPageCtrl", "PE_EmitterEditor", typeof (ParticleEmitterEditor.PE_EmitterEditor));
            oc_Newobject127["canSaveDynamicFields"] = "0";
            oc_Newobject127["Enabled"] = "1";
            oc_Newobject127["isContainer"] = "1";
            oc_Newobject127["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject127["HorizSizing"] = "width";
            oc_Newobject127["VertSizing"] = "height";
            oc_Newobject127["position"] = "0 19";
            oc_Newobject127["Extent"] = "197 271";
            oc_Newobject127["MinExtent"] = "8 2";
            oc_Newobject127["canSave"] = "1";
            oc_Newobject127["Visible"] = "1";
            oc_Newobject127["hovertime"] = "1000";
            oc_Newobject127["Margin"] = "0 0 0 0";
            oc_Newobject127["Padding"] = "0 0 0 0";
            oc_Newobject127["AnchorTop"] = "1";
            oc_Newobject127["AnchorBottom"] = "0";
            oc_Newobject127["AnchorLeft"] = "1";
            oc_Newobject127["AnchorRight"] = "0";
            oc_Newobject127["text"] = "Emitter";
            oc_Newobject127["maxLength"] = "1024";

            #region GuiScrollCtrl ()        oc_Newobject126

            ObjectCreator oc_Newobject126 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject126["canSaveDynamicFields"] = "0";
            oc_Newobject126["Enabled"] = "1";
            oc_Newobject126["isContainer"] = "1";
            oc_Newobject126["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject126["HorizSizing"] = "width";
            oc_Newobject126["VertSizing"] = "height";
            oc_Newobject126["Position"] = "0 0";
            oc_Newobject126["Extent"] = "197 271";
            oc_Newobject126["MinExtent"] = "8 8";
            oc_Newobject126["canSave"] = "1";
            oc_Newobject126["Visible"] = "1";
            oc_Newobject126["hovertime"] = "1000";
            oc_Newobject126["willFirstRespond"] = "1";
            oc_Newobject126["hScrollBar"] = "alwaysOff";
            oc_Newobject126["vScrollBar"] = "dynamic";
            oc_Newobject126["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject126["lockVertScroll"] = "false";
            oc_Newobject126["constantThumbHeight"] = "0";
            oc_Newobject126["childMargin"] = "0 0";

            #region GuiStackControl ()        oc_Newobject125

            ObjectCreator oc_Newobject125 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject125["StackingType"] = "Vertical";
            oc_Newobject125["HorizStacking"] = "Left to Right";
            oc_Newobject125["VertStacking"] = "Top to Bottom";
            oc_Newobject125["Padding"] = "0";
            oc_Newobject125["canSaveDynamicFields"] = "0";
            oc_Newobject125["Enabled"] = "1";
            oc_Newobject125["isContainer"] = "1";
            oc_Newobject125["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject125["HorizSizing"] = "width";
            oc_Newobject125["VertSizing"] = "bottom";
            oc_Newobject125["Position"] = "1 3";
            oc_Newobject125["Extent"] = "197 16";
            oc_Newobject125["MinExtent"] = "16 16";
            oc_Newobject125["canSave"] = "1";
            oc_Newobject125["isDecoy"] = "0";
            oc_Newobject125["Visible"] = "1";
            oc_Newobject125["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject125["hovertime"] = "1000";

            #region GuiControl (PEE_EmitterSelector_Control)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "PEE_EmitterSelector_Control", typeof (ParticleEmitterEditor.PEE_EmitterSelector_Control));
            //oc_Newobject6["class"] = "QuickEditDropDownTextEditCtrl";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject6["Extent"] = "197 26";

            #region GuiPopUpMenuCtrl (PEE_EmitterSelector)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiPopUpMenuCtrl", "PEE_EmitterSelector");
            oc_Newobject1["internalName"] = "PopUpMenu";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "4 4";
            oc_Newobject1["Extent"] = "123 18";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.onNewEmitter();";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["maxPopupHeight"] = "200";
            oc_Newobject1["sbUsesNAColor"] = "0";
            oc_Newobject1["reverseTextList"] = "0";
            oc_Newobject1["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject2["internalName"] = "TextEdit";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "GuiDropdownTextEditProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "4 4";
            oc_Newobject2["Extent"] = "107 18";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["text"] = "None";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["AltCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl);";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "left";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "131 5";
            oc_Newobject3["Extent"] = "17 17";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "PE_EmitterEditor.showNewDialog();";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["bitmap"] = "tools/gui/images/new";
            oc_Newobject3["tooltip"] = "Create New Emitter";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "left";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "147 5";
            oc_Newobject4["Extent"] = "17 17";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["bitmap"] = "tools/gui/images/save-icon";
            oc_Newobject4["command"] = new Creator.StringNoQuote("\"PE_EmitterEditor.saveEmitter( \" @ PE_EmitterEditor.currEmitter @ \" ); PE_ParticleEditor.saveParticle( PE_ParticleEditor.currParticle );\"");
            oc_Newobject4["tooltip"] = "Save Current Emitter";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "164 5";
            oc_Newobject5["Extent"] = "17 17";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "PE_EmitterEditor.showDeleteDialog();";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["bitmap"] = "tools/gui/images/delete";
            oc_Newobject5["tooltip"] = "Delete Current Emitter";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject125["#Newobject6"] = oc_Newobject6;

            #region GuiRolloutCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject29["class"] = "BehaviorQuickEditRollout";
            oc_Newobject29["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject29["Profile"] = "GuiRolloutProfile";
            oc_Newobject29["HorizSizing"] = "width";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["Position"] = "0 0";
            oc_Newobject29["Extent"] = "197 0";
            oc_Newobject29["Caption"] = "Basic";
            oc_Newobject29["Margin"] = "4 4 4 0";
            oc_Newobject29["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject29["container"] = new Creator.StringNoQuote("true");
            oc_Newobject29["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject29["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject28["StackingType"] = "Vertical";
            oc_Newobject28["HorizStacking"] = "Left to Right";
            oc_Newobject28["VertStacking"] = "Top to Bottom";
            oc_Newobject28["Padding"] = "0";
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["Enabled"] = "1";
            oc_Newobject28["isContainer"] = "1";
            oc_Newobject28["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject28["HorizSizing"] = "width";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["Position"] = "1 3";
            oc_Newobject28["Extent"] = "197 16";
            oc_Newobject28["MinExtent"] = "16 16";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["isDecoy"] = "0";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject10["isContainer"] = "1";
            //oc_Newobject10["class"] = "AggregateControl";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject10["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject7["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["text"] = "Life";
            oc_Newobject7["maxLength"] = "255";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiSliderCtrl (PEE_lifetimeMS)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiSliderCtrl", "PEE_lifetimeMS");
            oc_Newobject8["internalName"] = "PEE_lifetimeMS_slider";
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject8["HorizSizing"] = "left";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject8["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "PE_EmitterEditor.updateLifeFields( false, $ThisControl.getValue(), true, true );";
            oc_Newobject8["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateLifeFields( false, $ThisControl.getValue(), true, false );";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["range"] = "0 1000";
            oc_Newobject8["ticks"] = "0";
            oc_Newobject8["value"] = "0";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiTextEditCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject9["internalName"] = "PEE_lifetimeMS_textEdit";
            oc_Newobject9["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject9["HorizSizing"] = "left";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateLifeFields( false, $ThisControl.getValue() );";
            oc_Newobject9["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject9["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject28["#Newobject10"] = oc_Newobject10;

            #region GuiControl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject14["isContainer"] = "1";
            // oc_Newobject14["class"] = "AggregateControl";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject14["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject11["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["text"] = "Life Random";
            oc_Newobject11["maxLength"] = "255";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiSliderCtrl (PEE_lifetimeVarianceMS)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiSliderCtrl", "PEE_lifetimeVarianceMS");
            oc_Newobject12["internalName"] = "PEE_lifetimeVarianceMS_slider";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject12["HorizSizing"] = "left";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject12["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "PE_EmitterEditor.updateLifeFields( true, $ThisControl.getValue(), true, true );";
            oc_Newobject12["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateLifeFields( true, $ThisControl.getValue(), true, false );";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["range"] = "0 1000";
            oc_Newobject12["ticks"] = "0";
            oc_Newobject12["value"] = "";

            #endregion

            oc_Newobject14["#Newobject12"] = oc_Newobject12;

            #region GuiTextEditCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject13["internalName"] = "PEE_lifetimeVarianceMS_textEdit";
            oc_Newobject13["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject13["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject13["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateLifeFields( true, $ThisControl.getValue() );";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject28["#Newobject14"] = oc_Newobject14;

            #region GuiControl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "");
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject17["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject15["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject15["text"] = "Infinite Loop";

            #endregion

            oc_Newobject17["#Newobject15"] = oc_Newobject15;

            #region GuiCheckBoxCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject16["internalName"] = "PEE_infiniteLoop";
            oc_Newobject16["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject16["HorizSizing"] = "left";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject16["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject16["Command"] = "PE_EmitterEditor.updateLifeFieldsInfiniteLoop();";
            oc_Newobject16["text"] = "";

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject28["#Newobject17"] = oc_Newobject17;

            #region GuiControl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiControl", "");
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["Position"] = "0 0";
            oc_Newobject19["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject18["position"] = "0 3";
            oc_Newobject18["extent"] = "188 2";
            oc_Newobject18["HorizSizing"] = "width";
            oc_Newobject18["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject28["#Newobject19"] = oc_Newobject19;

            #region GuiControl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            // oc_Newobject23["class"] = "AggregateControl";
            oc_Newobject23["isContainer"] = "1";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject23["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject20["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject20["HorizSizing"] = "width";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject20["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject20["text"] = "Amount";

            #endregion

            oc_Newobject23["#Newobject20"] = oc_Newobject20;

            #region GuiSliderCtrl (PEE_ejectionPeriodMS)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiSliderCtrl", "PEE_ejectionPeriodMS");
            oc_Newobject21["internalName"] = "PEE_ejectionPeriodMS_slider";
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject21["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["Command"] = "PE_EmitterEditor.updateAmountFields( false, $ThisControl.getValue(), true, true );";
            oc_Newobject21["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateAmountFields( false, $ThisControl.getValue(), true, false );";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["range"] = "1 1000";
            oc_Newobject21["ticks"] = "0";
            oc_Newobject21["value"] = "1";

            #endregion

            oc_Newobject23["#Newobject21"] = oc_Newobject21;

            #region GuiTextEditCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject22["internalName"] = "PEE_ejectionPeriodMS_textEdit";
            oc_Newobject22["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject22["HorizSizing"] = "left";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject22["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject22["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateAmountFields( false, $ThisControl.getValue() );";

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject28["#Newobject23"] = oc_Newobject23;

            #region GuiControl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            // oc_Newobject27["class"] = "AggregateControl";
            oc_Newobject27["isContainer"] = "1";
            oc_Newobject27["HorizSizing"] = "width";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject27["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject24["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject24["HorizSizing"] = "width";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject24["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject24["text"] = "Amount Random";

            #endregion

            oc_Newobject27["#Newobject24"] = oc_Newobject24;

            #region GuiSliderCtrl (PEE_periodVarianceMS)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiSliderCtrl", "PEE_periodVarianceMS");
            oc_Newobject25["internalName"] = "PEE_periodVarianceMS_slider";
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject25["HorizSizing"] = "left";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject25["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["Command"] = "PE_EmitterEditor.updateAmountFields( true, $ThisControl.getValue(), true, true );";
            oc_Newobject25["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateAmountFields( true, $ThisControl.getValue(), true, false );";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["range"] = "0 999";
            oc_Newobject25["ticks"] = "0";
            oc_Newobject25["value"] = "1";

            #endregion

            oc_Newobject27["#Newobject25"] = oc_Newobject25;

            #region GuiTextEditCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject26["internalName"] = "PEE_periodVarianceMS_textEdit";
            oc_Newobject26["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject26["HorizSizing"] = "left";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject26["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject26["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateAmountFields( true, $ThisControl.getValue() );";

            #endregion

            oc_Newobject27["#Newobject26"] = oc_Newobject26;

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject125["#Newobject29"] = oc_Newobject29;

            #region GuiRolloutCtrl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject50["class"] = "BehaviorQuickEditRollout";
            oc_Newobject50["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject50["Profile"] = "GuiRolloutProfile";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["Position"] = "0 0";
            oc_Newobject50["Extent"] = "197 0";
            oc_Newobject50["Caption"] = "Motion";
            oc_Newobject50["Margin"] = "4 4 4 0";
            oc_Newobject50["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject50["container"] = new Creator.StringNoQuote("true");
            oc_Newobject50["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject50["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject49["StackingType"] = "Vertical";
            oc_Newobject49["HorizStacking"] = "Left to Right";
            oc_Newobject49["VertStacking"] = "Top to Bottom";
            oc_Newobject49["Padding"] = "0";
            oc_Newobject49["canSaveDynamicFields"] = "0";
            oc_Newobject49["Enabled"] = "1";
            oc_Newobject49["isContainer"] = "1";
            oc_Newobject49["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject49["HorizSizing"] = "width";
            oc_Newobject49["VertSizing"] = "bottom";
            oc_Newobject49["Position"] = "1 3";
            oc_Newobject49["Extent"] = "197 16";
            oc_Newobject49["MinExtent"] = "16 16";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["isDecoy"] = "0";
            oc_Newobject49["Visible"] = "1";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            // oc_Newobject33["class"] = "AggregateControl";
            oc_Newobject33["isContainer"] = "1";
            oc_Newobject33["HorizSizing"] = "width";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject33["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject30["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject30["HorizSizing"] = "width";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject30["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject30["text"] = "Speed";

            #endregion

            oc_Newobject33["#Newobject30"] = oc_Newobject30;

            #region GuiSliderCtrl (PEE_ejectionVelocity)        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiSliderCtrl", "PEE_ejectionVelocity");
            oc_Newobject31["internalName"] = "PEE_ejectionVelocity_slider";
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["Enabled"] = "1";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject31["HorizSizing"] = "left";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject31["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["Command"] = "PE_EmitterEditor.updateSpeedFields( false, $ThisControl.getValue(), true, true );";
            oc_Newobject31["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateSpeedFields( false, $ThisControl.getValue(), true, false );";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["range"] = "0 100";
            oc_Newobject31["ticks"] = "0";
            oc_Newobject31["value"] = "0";

            #endregion

            oc_Newobject33["#Newobject31"] = oc_Newobject31;

            #region GuiTextEditCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject32["internalName"] = "PEE_ejectionVelocity_textEdit";
            oc_Newobject32["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject32["HorizSizing"] = "left";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject32["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject32["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateSpeedFields( false, $ThisControl.getValue() );";

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject49["#Newobject33"] = oc_Newobject33;

            #region GuiControl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject37["class"] = "AggregateControl";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["HorizSizing"] = "width";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject37["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject34["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject34["HorizSizing"] = "width";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject34["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject34["text"] = "Speed Random";

            #endregion

            oc_Newobject37["#Newobject34"] = oc_Newobject34;

            #region GuiSliderCtrl (PEE_velocityVariance)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiSliderCtrl", "PEE_velocityVariance");
            oc_Newobject35["internalName"] = "PEE_velocityVariance_slider";
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["Enabled"] = "1";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject35["HorizSizing"] = "left";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject35["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["Command"] = "PE_EmitterEditor.updateSpeedFields( true, $ThisControl.getValue(), true, true );";
            oc_Newobject35["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateSpeedFields( true, $ThisControl.getValue(), true, false );";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["range"] = "0 100";
            oc_Newobject35["ticks"] = "0";
            oc_Newobject35["value"] = "0";

            #endregion

            oc_Newobject37["#Newobject35"] = oc_Newobject35;

            #region GuiTextEditCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject36["internalName"] = "PEE_velocityVariance_textEdit";
            oc_Newobject36["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject36["HorizSizing"] = "left";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject36["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject36["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateSpeedFields( true, $ThisControl.getValue() );";

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject49["#Newobject37"] = oc_Newobject37;

            #region GuiControl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiControl", "");
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["HorizSizing"] = "width";
            oc_Newobject39["Position"] = "0 0";
            oc_Newobject39["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject38["position"] = "0 3";
            oc_Newobject38["extent"] = "188 2";
            oc_Newobject38["HorizSizing"] = "width";
            oc_Newobject38["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject49["#Newobject39"] = oc_Newobject39;

            #region GuiControl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiControl", "");
            oc_Newobject42["isContainer"] = "1";
            oc_Newobject42["HorizSizing"] = "width";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject42["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject40["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject40["HorizSizing"] = "width";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject40["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject40["text"] = "Orient to Movment Direction";

            #endregion

            oc_Newobject42["#Newobject40"] = oc_Newobject40;

            #region GuiCheckBoxCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject41["internalName"] = "PEE_orientParticles";
            oc_Newobject41["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject41["HorizSizing"] = "left";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject41["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject41["text"] = "";
            oc_Newobject41["command"] = "PE_EmitterEditor.updateEmitter( \\\"orientParticles\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject42["#Newobject41"] = oc_Newobject41;

            #endregion

            oc_Newobject49["#Newobject42"] = oc_Newobject42;

            #region GuiControl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiControl", "");
            oc_Newobject45["isContainer"] = "1";
            oc_Newobject45["HorizSizing"] = "width";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject45["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject43["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject43["HorizSizing"] = "width";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject43["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject43["text"] = "Align to a Direction";

            #endregion

            oc_Newobject45["#Newobject43"] = oc_Newobject43;

            #region GuiCheckBoxCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject44["internalName"] = "PEE_alignParticles";
            oc_Newobject44["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject44["HorizSizing"] = "left";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject44["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject44["text"] = "";
            oc_Newobject44["command"] = "PE_EmitterEditor.updateEmitter( \\\"alignParticles\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject45["#Newobject44"] = oc_Newobject44;

            #endregion

            oc_Newobject49["#Newobject45"] = oc_Newobject45;

            #region GuiControl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiControl", "");
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["HorizSizing"] = "width";
            oc_Newobject48["VertSizing"] = "bottom";
            oc_Newobject48["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject48["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject46["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject46["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject46["text"] = "Align Direction";

            #endregion

            oc_Newobject48["#Newobject46"] = oc_Newobject46;

            #region GuiTextEditCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject47["internalName"] = "PEE_alignDirection";
            oc_Newobject47["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject47["HorizSizing"] = "left";
            oc_Newobject47["VertSizing"] = "bottom";
            oc_Newobject47["position"] = new Creator.StringNoQuote("$PE_guielement_pos_textedit");
            oc_Newobject47["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_textedit");
            oc_Newobject47["text"] = "0  0  0";
            oc_Newobject47["altCommand"] = "PE_EmitterEditor.updateEmitter( \\\"alignDirection\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject49["#Newobject48"] = oc_Newobject48;

            #endregion

            oc_Newobject50["#Newobject49"] = oc_Newobject49;

            #endregion

            oc_Newobject125["#Newobject50"] = oc_Newobject50;

            #region GuiRolloutCtrl ()        oc_Newobject80

            ObjectCreator oc_Newobject80 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject80["class"] = "BehaviorQuickEditRollout";
            oc_Newobject80["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject80["Profile"] = "GuiRolloutProfile";
            oc_Newobject80["HorizSizing"] = "width";
            oc_Newobject80["VertSizing"] = "bottom";
            oc_Newobject80["Position"] = "0 0";
            oc_Newobject80["Extent"] = "197 0";
            oc_Newobject80["Caption"] = "Spread";
            oc_Newobject80["Margin"] = "4 4 4 0";
            oc_Newobject80["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject80["container"] = new Creator.StringNoQuote("true");
            oc_Newobject80["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject80["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject79

            ObjectCreator oc_Newobject79 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject79["StackingType"] = "Vertical";
            oc_Newobject79["HorizStacking"] = "Left to Right";
            oc_Newobject79["VertStacking"] = "Top to Bottom";
            oc_Newobject79["Padding"] = "0";
            oc_Newobject79["canSaveDynamicFields"] = "0";
            oc_Newobject79["Enabled"] = "1";
            oc_Newobject79["isContainer"] = "1";
            oc_Newobject79["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject79["HorizSizing"] = "width";
            oc_Newobject79["VertSizing"] = "bottom";
            oc_Newobject79["Position"] = "1 3";
            oc_Newobject79["Extent"] = "197 16";
            oc_Newobject79["MinExtent"] = "16 16";
            oc_Newobject79["canSave"] = "1";
            oc_Newobject79["isDecoy"] = "0";
            oc_Newobject79["Visible"] = "1";
            oc_Newobject79["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject79["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject59["isContainer"] = "1";
            //oc_Newobject59["class"] = "AggregateControl";
            oc_Newobject59["HorizSizing"] = "width";
            oc_Newobject59["VertSizing"] = "bottom";
            oc_Newobject59["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject59["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiBitmapCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject51["HorizSizing"] = "left";
            oc_Newobject51["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+4 SPC \"0\"");
            oc_Newobject51["Extent"] = "2 18";
            oc_Newobject51["minExtent"] = "0 0";
            oc_Newobject51["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject51["tooltip"] = "0 Degrees ( Up )";

            #endregion

            oc_Newobject59["#Newobject51"] = oc_Newobject51;

            #region GuiBitmapCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject52["HorizSizing"] = "left";
            oc_Newobject52["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/4)+1 SPC \"0\"");
            oc_Newobject52["Extent"] = "2 18";
            oc_Newobject52["minExtent"] = "0 0";
            oc_Newobject52["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject52["tooltip"] = "90 Degrees ( Left )";

            #endregion

            oc_Newobject59["#Newobject52"] = oc_Newobject52;

            #region GuiBitmapCtrl ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject53["HorizSizing"] = "left";
            oc_Newobject53["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2)-1 SPC \"0\"");
            oc_Newobject53["Extent"] = "2 18";
            oc_Newobject53["minExtent"] = "0 0";
            oc_Newobject53["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject53["tooltip"] = "180 Degrees ( Down )";

            #endregion

            oc_Newobject59["#Newobject53"] = oc_Newobject53;

            #region GuiBitmapCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject54["HorizSizing"] = "left";
            oc_Newobject54["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2+mCeil(getWord($PE_guielement_ext_slider,0)/4))-4 SPC \"0\"");
            oc_Newobject54["Extent"] = "2 18";
            oc_Newobject54["minExtent"] = "0 0";
            oc_Newobject54["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject54["tooltip"] = "270 Degrees ( Right )";

            #endregion

            oc_Newobject59["#Newobject54"] = oc_Newobject54;

            #region GuiBitmapCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject55["HorizSizing"] = "left";
            oc_Newobject55["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0))-5 SPC \"0\"");
            oc_Newobject55["Extent"] = "2 18";
            oc_Newobject55["minExtent"] = "0 0";
            oc_Newobject55["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject55["tooltip"] = "360 Degrees ( Up )";

            #endregion

            oc_Newobject59["#Newobject55"] = oc_Newobject55;

            #region GuiTextCtrl ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject56["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject56["HorizSizing"] = "width";
            oc_Newobject56["VertSizing"] = "bottom";
            oc_Newobject56["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject56["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject56["text"] = "Angle Min";

            #endregion

            oc_Newobject59["#Newobject56"] = oc_Newobject56;

            #region GuiSliderCtrl (PEE_thetaMin)        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiSliderCtrl", "PEE_thetaMin");
            oc_Newobject57["internalName"] = "PEE_thetaMin_slider";
            oc_Newobject57["canSaveDynamicFields"] = "0";
            oc_Newobject57["Enabled"] = "1";
            oc_Newobject57["isContainer"] = "0";
            oc_Newobject57["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject57["HorizSizing"] = "left";
            oc_Newobject57["VertSizing"] = "bottom";
            oc_Newobject57["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject57["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject57["MinExtent"] = "8 2";
            oc_Newobject57["canSave"] = "1";
            oc_Newobject57["Visible"] = "1";
            oc_Newobject57["Command"] = "PE_EmitterEditor.updateEmitter( \\\"thetaMin\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject57["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"thetaMin\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject57["hovertime"] = "1000";
            oc_Newobject57["range"] = "0 180";
            oc_Newobject57["ticks"] = "0";
            oc_Newobject57["value"] = "0";

            #endregion

            oc_Newobject59["#Newobject57"] = oc_Newobject57;

            #region GuiTextEditCtrl ()        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject58["internalname"] = "PEE_thetaMin_textEdit";
            oc_Newobject58["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject58["HorizSizing"] = "left";
            oc_Newobject58["VertSizing"] = "bottom";
            oc_Newobject58["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject58["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject58["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"thetaMin\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject59["#Newobject58"] = oc_Newobject58;

            #endregion

            oc_Newobject79["#Newobject59"] = oc_Newobject59;

            #region GuiControl ()        oc_Newobject68

            ObjectCreator oc_Newobject68 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject68["isContainer"] = "1";
            //oc_Newobject68["class"] = "AggregateControl";
            oc_Newobject68["HorizSizing"] = "width";
            oc_Newobject68["VertSizing"] = "bottom";
            oc_Newobject68["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject68["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiBitmapCtrl ()        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject60["HorizSizing"] = "left";
            oc_Newobject60["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+4 SPC \"0\"");
            oc_Newobject60["Extent"] = "2 18";
            oc_Newobject60["minExtent"] = "0 0";
            oc_Newobject60["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject60["tooltip"] = "0 Degrees ( Up )";

            #endregion

            oc_Newobject68["#Newobject60"] = oc_Newobject60;

            #region GuiBitmapCtrl ()        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject61["HorizSizing"] = "left";
            oc_Newobject61["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/4)+1 SPC \"0\"");
            oc_Newobject61["Extent"] = "2 18";
            oc_Newobject61["minExtent"] = "0 0";
            oc_Newobject61["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject61["tooltip"] = "90 Degrees ( Left )";

            #endregion

            oc_Newobject68["#Newobject61"] = oc_Newobject61;

            #region GuiBitmapCtrl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject62["HorizSizing"] = "left";
            oc_Newobject62["minExtent"] = "0 0";
            oc_Newobject62["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2)-1 SPC \"0\"");
            oc_Newobject62["Extent"] = "2 18";
            oc_Newobject62["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject62["tooltip"] = "180 Degrees ( Down )";

            #endregion

            oc_Newobject68["#Newobject62"] = oc_Newobject62;

            #region GuiBitmapCtrl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject63["HorizSizing"] = "left";
            oc_Newobject63["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2+mCeil(getWord($PE_guielement_ext_slider,0)/4))-4 SPC \"0\"");
            oc_Newobject63["Extent"] = "2 18";
            oc_Newobject63["minExtent"] = "0 0";
            oc_Newobject63["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject63["tooltip"] = "270 Degrees ( Right )";

            #endregion

            oc_Newobject68["#Newobject63"] = oc_Newobject63;

            #region GuiBitmapCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject64["HorizSizing"] = "left";
            oc_Newobject64["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0))-5 SPC \"0\"");
            oc_Newobject64["Extent"] = "2 18";
            oc_Newobject64["minExtent"] = "0 0";
            oc_Newobject64["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject64["tooltip"] = "360 Degrees ( Up )";

            #endregion

            oc_Newobject68["#Newobject64"] = oc_Newobject64;

            #region GuiTextCtrl ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject65["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject65["HorizSizing"] = "width";
            oc_Newobject65["VertSizing"] = "bottom";
            oc_Newobject65["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject65["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject65["text"] = "Angle Max";

            #endregion

            oc_Newobject68["#Newobject65"] = oc_Newobject65;

            #region GuiSliderCtrl (PEE_thetaMax)        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiSliderCtrl", "PEE_thetaMax");
            oc_Newobject66["internalName"] = "PEE_thetaMax_slider";
            oc_Newobject66["canSaveDynamicFields"] = "0";
            oc_Newobject66["Enabled"] = "1";
            oc_Newobject66["isContainer"] = "0";
            oc_Newobject66["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject66["HorizSizing"] = "left";
            oc_Newobject66["VertSizing"] = "bottom";
            oc_Newobject66["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject66["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject66["MinExtent"] = "8 2";
            oc_Newobject66["canSave"] = "1";
            oc_Newobject66["Visible"] = "1";
            oc_Newobject66["Command"] = "PE_EmitterEditor.updateEmitter( \\\"thetaMax\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject66["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"thetaMax\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject66["hovertime"] = "1000";
            oc_Newobject66["range"] = "0 180";
            oc_Newobject66["ticks"] = "0";
            oc_Newobject66["value"] = "0";

            #endregion

            oc_Newobject68["#Newobject66"] = oc_Newobject66;

            #region GuiTextEditCtrl ()        oc_Newobject67

            ObjectCreator oc_Newobject67 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject67["internalName"] = "PEE_thetaMax_textEdit";
            oc_Newobject67["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject67["HorizSizing"] = "left";
            oc_Newobject67["VertSizing"] = "bottom";
            oc_Newobject67["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject67["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject67["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"thetaMax\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject68["#Newobject67"] = oc_Newobject67;

            #endregion

            oc_Newobject79["#Newobject68"] = oc_Newobject68;

            #region GuiControl ()        oc_Newobject70

            ObjectCreator oc_Newobject70 = new ObjectCreator("GuiControl", "");
            oc_Newobject70["isContainer"] = "1";
            oc_Newobject70["HorizSizing"] = "width";
            oc_Newobject70["Position"] = "0 0";
            oc_Newobject70["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject69

            ObjectCreator oc_Newobject69 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject69["position"] = "0 3";
            oc_Newobject69["extent"] = "188 2";
            oc_Newobject69["HorizSizing"] = "width";
            oc_Newobject69["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject70["#Newobject69"] = oc_Newobject69;

            #endregion

            oc_Newobject79["#Newobject70"] = oc_Newobject70;

            #region GuiControl ()        oc_Newobject74

            ObjectCreator oc_Newobject74 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            oc_Newobject74["isContainer"] = "1";
            //oc_Newobject74["class"] = "AggregateControl";
            oc_Newobject74["HorizSizing"] = "width";
            oc_Newobject74["VertSizing"] = "bottom";
            oc_Newobject74["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject74["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject71

            ObjectCreator oc_Newobject71 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject71["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject71["HorizSizing"] = "width";
            oc_Newobject71["VertSizing"] = "bottom";
            oc_Newobject71["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject71["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject71["text"] = "Depth";

            #endregion

            oc_Newobject74["#Newobject71"] = oc_Newobject71;

            #region GuiSliderCtrl (PEE_phiVariance)        oc_Newobject72

            ObjectCreator oc_Newobject72 = new ObjectCreator("GuiSliderCtrl", "PEE_phiVariance");
            oc_Newobject72["internalName"] = "PEE_phiVariance_slider";
            oc_Newobject72["canSaveDynamicFields"] = "0";
            oc_Newobject72["Enabled"] = "1";
            oc_Newobject72["isContainer"] = "0";
            oc_Newobject72["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject72["HorizSizing"] = "left";
            oc_Newobject72["VertSizing"] = "bottom";
            oc_Newobject72["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject72["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject72["MinExtent"] = "8 2";
            oc_Newobject72["canSave"] = "1";
            oc_Newobject72["Visible"] = "1";
            oc_Newobject72["Command"] = "PE_EmitterEditor.updateEmitter( \\\"phiVariance\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject72["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"phiVariance\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject72["hovertime"] = "1000";
            oc_Newobject72["range"] = "0 360";
            oc_Newobject72["ticks"] = "0";
            oc_Newobject72["value"] = "360";

            #endregion

            oc_Newobject74["#Newobject72"] = oc_Newobject72;

            #region GuiTextEditCtrl ()        oc_Newobject73

            ObjectCreator oc_Newobject73 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject73["internalName"] = "PEE_phiVariance_textEdit";
            oc_Newobject73["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject73["HorizSizing"] = "left";
            oc_Newobject73["VertSizing"] = "bottom";
            oc_Newobject73["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject73["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject73["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"phiVariance\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject74["#Newobject73"] = oc_Newobject73;

            #endregion

            oc_Newobject79["#Newobject74"] = oc_Newobject74;

            #region GuiControl ()        oc_Newobject78

            ObjectCreator oc_Newobject78 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject78["class"] = "AggregateControl";
            oc_Newobject78["isContainer"] = "1";
            oc_Newobject78["HorizSizing"] = "width";
            oc_Newobject78["VertSizing"] = "bottom";
            oc_Newobject78["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject78["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject75

            ObjectCreator oc_Newobject75 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject75["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject75["HorizSizing"] = "width";
            oc_Newobject75["VertSizing"] = "bottom";
            oc_Newobject75["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject75["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject75["text"] = "Offset";

            #endregion

            oc_Newobject78["#Newobject75"] = oc_Newobject75;

            #region GuiSliderCtrl (PEE_ejectionOffset)        oc_Newobject76

            ObjectCreator oc_Newobject76 = new ObjectCreator("GuiSliderCtrl", "PEE_ejectionOffset");
            oc_Newobject76["internalName"] = "PEE_ejectionOffset_slider";
            oc_Newobject76["canSaveDynamicFields"] = "0";
            oc_Newobject76["Enabled"] = "1";
            oc_Newobject76["isContainer"] = "0";
            oc_Newobject76["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject76["HorizSizing"] = "left";
            oc_Newobject76["VertSizing"] = "bottom";
            oc_Newobject76["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject76["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject76["MinExtent"] = "8 2";
            oc_Newobject76["canSave"] = "1";
            oc_Newobject76["Visible"] = "1";
            oc_Newobject76["Command"] = "PE_EmitterEditor.updateEmitter( \\\"ejectionOffset\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject76["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"ejectionOffset\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject76["hovertime"] = "1000";
            oc_Newobject76["range"] = "0 10";
            oc_Newobject76["ticks"] = "0";
            oc_Newobject76["value"] = "0";

            #endregion

            oc_Newobject78["#Newobject76"] = oc_Newobject76;

            #region GuiTextEditCtrl ()        oc_Newobject77

            ObjectCreator oc_Newobject77 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject77["internalName"] = "PEE_ejectionOffset_textEdit";
            oc_Newobject77["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject77["HorizSizing"] = "left";
            oc_Newobject77["VertSizing"] = "bottom";
            oc_Newobject77["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject77["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject77["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"ejectionOffset\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject78["#Newobject77"] = oc_Newobject77;

            #endregion

            oc_Newobject79["#Newobject78"] = oc_Newobject78;

            #endregion

            oc_Newobject80["#Newobject79"] = oc_Newobject79;

            #endregion

            oc_Newobject125["#Newobject80"] = oc_Newobject80;

            #region GuiRolloutCtrl ()        oc_Newobject97

            ObjectCreator oc_Newobject97 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject97["class"] = "BehaviorQuickEditRollout";
            oc_Newobject97["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject97["Profile"] = "GuiRolloutProfile";
            oc_Newobject97["HorizSizing"] = "width";
            oc_Newobject97["VertSizing"] = "bottom";
            oc_Newobject97["Position"] = "0 0";
            oc_Newobject97["Extent"] = "197 0";
            oc_Newobject97["Caption"] = "Particles";
            oc_Newobject97["Margin"] = "4 4 4 0";
            oc_Newobject97["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject97["container"] = new Creator.StringNoQuote("true");
            oc_Newobject97["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject97["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject96

            ObjectCreator oc_Newobject96 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject96["StackingType"] = "Vertical";
            oc_Newobject96["HorizStacking"] = "Left to Right";
            oc_Newobject96["VertStacking"] = "Top to Bottom";
            oc_Newobject96["Padding"] = "0";
            oc_Newobject96["canSaveDynamicFields"] = "0";
            oc_Newobject96["Enabled"] = "1";
            oc_Newobject96["isContainer"] = "1";
            oc_Newobject96["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject96["HorizSizing"] = "width";
            oc_Newobject96["VertSizing"] = "bottom";
            oc_Newobject96["Position"] = "1 3";
            oc_Newobject96["Extent"] = "197 16";
            oc_Newobject96["MinExtent"] = "16 16";
            oc_Newobject96["canSave"] = "1";
            oc_Newobject96["isDecoy"] = "0";
            oc_Newobject96["Visible"] = "1";
            oc_Newobject96["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject96["hovertime"] = "1000";

            #region GuiControl (PEE_EmitterParticle1)        oc_Newobject83

            ObjectCreator oc_Newobject83 = new ObjectCreator("GuiControl", "PEE_EmitterParticle1");
            oc_Newobject83["isContainer"] = "1";
            oc_Newobject83["HorizSizing"] = "width";
            oc_Newobject83["VertSizing"] = "bottom";
            oc_Newobject83["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject83["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject81

            ObjectCreator oc_Newobject81 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject81["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject81["HorizSizing"] = "width";
            oc_Newobject81["VertSizing"] = "bottom";
            oc_Newobject81["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject81["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject81["text"] = "Particle 1";

            #endregion

            oc_Newobject83["#Newobject81"] = oc_Newobject81;

            #region GuiPopUpMenuCtrl (PEE_EmitterParticleSelector1)        oc_Newobject82

            ObjectCreator oc_Newobject82 = new ObjectCreator("GuiPopUpMenuCtrl", "PEE_EmitterParticleSelector1");
            oc_Newobject82["internalName"] = "PopUpMenu";
            oc_Newobject82["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject82["HorizSizing"] = "left";
            oc_Newobject82["VertSizing"] = "bottom";
            oc_Newobject82["position"] = new Creator.StringNoQuote("$PE_guielement_pos_textedit");
            oc_Newobject82["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_textedit");
            oc_Newobject82["text"] = "";
            oc_Newobject82["command"] = "PE_EmitterEditor.updateParticlesFields($ThisControl);";

            #endregion

            oc_Newobject83["#Newobject82"] = oc_Newobject82;

            #endregion

            oc_Newobject96["#Newobject83"] = oc_Newobject83;

            #region GuiControl (PEE_EmitterParticle2)        oc_Newobject87

            ObjectCreator oc_Newobject87 = new ObjectCreator("GuiControl", "PEE_EmitterParticle2");
            oc_Newobject87["isContainer"] = "1";
            oc_Newobject87["HorizSizing"] = "width";
            oc_Newobject87["VertSizing"] = "bottom";
            oc_Newobject87["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject87["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject84

            ObjectCreator oc_Newobject84 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject84["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject84["HorizSizing"] = "width";
            oc_Newobject84["VertSizing"] = "bottom";
            oc_Newobject84["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject84["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject84["text"] = "Particle 2";

            #endregion

            oc_Newobject87["#Newobject84"] = oc_Newobject84;

            #region GuiPopUpMenuCtrl (PEE_EmitterParticleSelector2)        oc_Newobject85

            ObjectCreator oc_Newobject85 = new ObjectCreator("GuiPopUpMenuCtrl", "PEE_EmitterParticleSelector2");
            oc_Newobject85["internalName"] = "PopUpMenu";
            oc_Newobject85["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject85["HorizSizing"] = "left";
            oc_Newobject85["VertSizing"] = "bottom";
            oc_Newobject85["position"] = new Creator.StringNoQuote("$PE_guielement_pos_textedit");
            oc_Newobject85["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_textedit");
            oc_Newobject85["text"] = "None";
            oc_Newobject85["command"] = "PE_EmitterEditor.updateParticlesFields();";

            #endregion

            oc_Newobject87["#Newobject85"] = oc_Newobject85;

            #region GuiBitmapButtonCtrl ()        oc_Newobject86

            ObjectCreator oc_Newobject86 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject86["canSaveDynamicFields"] = "0";
            oc_Newobject86["Enabled"] = "1";
            oc_Newobject86["isContainer"] = "0";
            oc_Newobject86["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject86["HorizSizing"] = "left";
            oc_Newobject86["VertSizing"] = "bottom";
            oc_Newobject86["position"] = "56 1";
            oc_Newobject86["Extent"] = "17 17";
            oc_Newobject86["MinExtent"] = "8 2";
            oc_Newobject86["canSave"] = "1";
            oc_Newobject86["Visible"] = "1";
            oc_Newobject86["Command"] = "particleId = PEE_EmitterParticle2-->PopUpMenu.findText( \\\"None\\\" ); PEE_EmitterParticle2-->PopUpMenu.setSelected( particleId );PE_EmitterEditor.updateParticlesFields();";
            oc_Newobject86["hovertime"] = "1000";
            oc_Newobject86["tooltip"] = "Clear Particle 2 from Emitter";
            oc_Newobject86["text"] = "";
            oc_Newobject86["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject86["groupNum"] = "-1";
            oc_Newobject86["buttonType"] = "PushButton";
            oc_Newobject86["useMouseEvents"] = "0";

            #endregion

            oc_Newobject87["#Newobject86"] = oc_Newobject86;

            #endregion

            oc_Newobject96["#Newobject87"] = oc_Newobject87;

            #region GuiControl (PEE_EmitterParticle3)        oc_Newobject91

            ObjectCreator oc_Newobject91 = new ObjectCreator("GuiControl", "PEE_EmitterParticle3");
            oc_Newobject91["isContainer"] = "1";
            oc_Newobject91["HorizSizing"] = "width";
            oc_Newobject91["VertSizing"] = "bottom";
            oc_Newobject91["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject91["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject88

            ObjectCreator oc_Newobject88 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject88["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject88["HorizSizing"] = "width";
            oc_Newobject88["VertSizing"] = "bottom";
            oc_Newobject88["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject88["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject88["text"] = "Particle 3";

            #endregion

            oc_Newobject91["#Newobject88"] = oc_Newobject88;

            #region GuiPopUpMenuCtrl (PEE_EmitterParticleSelector3)        oc_Newobject89

            ObjectCreator oc_Newobject89 = new ObjectCreator("GuiPopUpMenuCtrl", "PEE_EmitterParticleSelector3");
            oc_Newobject89["internalName"] = "PopUpMenu";
            oc_Newobject89["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject89["HorizSizing"] = "left";
            oc_Newobject89["VertSizing"] = "bottom";
            oc_Newobject89["position"] = new Creator.StringNoQuote("$PE_guielement_pos_textedit");
            oc_Newobject89["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_textedit");
            oc_Newobject89["text"] = "None";
            oc_Newobject89["command"] = "PE_EmitterEditor.updateParticlesFields();";

            #endregion

            oc_Newobject91["#Newobject89"] = oc_Newobject89;

            #region GuiBitmapButtonCtrl ()        oc_Newobject90

            ObjectCreator oc_Newobject90 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject90["canSaveDynamicFields"] = "0";
            oc_Newobject90["Enabled"] = "1";
            oc_Newobject90["isContainer"] = "0";
            oc_Newobject90["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject90["HorizSizing"] = "left";
            oc_Newobject90["VertSizing"] = "bottom";
            oc_Newobject90["position"] = "56 1";
            oc_Newobject90["Extent"] = "17 17";
            oc_Newobject90["MinExtent"] = "8 2";
            oc_Newobject90["canSave"] = "1";
            oc_Newobject90["Visible"] = "1";
            oc_Newobject90["Command"] = "particleId = PEE_EmitterParticle3-->PopUpMenu.findText( \\\"None\\\" ); PEE_EmitterParticle3-->PopUpMenu.setSelected( particleId );PE_EmitterEditor.updateParticlesFields();";
            oc_Newobject90["hovertime"] = "1000";
            oc_Newobject90["tooltip"] = "Clear Particle 3 from Emitter";
            oc_Newobject90["text"] = "";
            oc_Newobject90["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject90["groupNum"] = "-1";
            oc_Newobject90["buttonType"] = "PushButton";
            oc_Newobject90["useMouseEvents"] = "0";

            #endregion

            oc_Newobject91["#Newobject90"] = oc_Newobject90;

            #endregion

            oc_Newobject96["#Newobject91"] = oc_Newobject91;

            #region GuiControl (PEE_EmitterParticle4)        oc_Newobject95

            ObjectCreator oc_Newobject95 = new ObjectCreator("GuiControl", "PEE_EmitterParticle4");
            oc_Newobject95["isContainer"] = "1";
            oc_Newobject95["HorizSizing"] = "width";
            oc_Newobject95["VertSizing"] = "bottom";
            oc_Newobject95["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject95["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject92

            ObjectCreator oc_Newobject92 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject92["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject92["HorizSizing"] = "width";
            oc_Newobject92["VertSizing"] = "bottom";
            oc_Newobject92["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject92["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject92["text"] = "Particle 4";

            #endregion

            oc_Newobject95["#Newobject92"] = oc_Newobject92;

            #region GuiPopUpMenuCtrl (PEE_EmitterParticleSelector4)        oc_Newobject93

            ObjectCreator oc_Newobject93 = new ObjectCreator("GuiPopUpMenuCtrl", "PEE_EmitterParticleSelector4");
            oc_Newobject93["internalName"] = "PopUpMenu";
            oc_Newobject93["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject93["HorizSizing"] = "left";
            oc_Newobject93["VertSizing"] = "bottom";
            oc_Newobject93["position"] = new Creator.StringNoQuote("$PE_guielement_pos_textedit");
            oc_Newobject93["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_textedit");
            oc_Newobject93["text"] = "None";
            oc_Newobject93["command"] = "PE_EmitterEditor.updateParticlesFields();";

            #endregion

            oc_Newobject95["#Newobject93"] = oc_Newobject93;

            #region GuiBitmapButtonCtrl ()        oc_Newobject94

            ObjectCreator oc_Newobject94 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject94["canSaveDynamicFields"] = "0";
            oc_Newobject94["Enabled"] = "1";
            oc_Newobject94["isContainer"] = "0";
            oc_Newobject94["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject94["HorizSizing"] = "left";
            oc_Newobject94["VertSizing"] = "bottom";
            oc_Newobject94["position"] = "56 1";
            oc_Newobject94["Extent"] = "17 17";
            oc_Newobject94["MinExtent"] = "8 2";
            oc_Newobject94["canSave"] = "1";
            oc_Newobject94["Visible"] = "1";
            oc_Newobject94["Command"] = "particleId = PEE_EmitterParticle4-->PopUpMenu.findText( \\\"None\\\" ); PEE_EmitterParticle4-->PopUpMenu.setSelected( particleId );PE_EmitterEditor.updateParticlesFields();";
            oc_Newobject94["hovertime"] = "1000";
            oc_Newobject94["tooltip"] = "Clear Particle 4 from Emitter";
            oc_Newobject94["text"] = "";
            oc_Newobject94["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject94["groupNum"] = "-1";
            oc_Newobject94["buttonType"] = "PushButton";
            oc_Newobject94["useMouseEvents"] = "0";

            #endregion

            oc_Newobject95["#Newobject94"] = oc_Newobject94;

            #endregion

            oc_Newobject96["#Newobject95"] = oc_Newobject95;

            #endregion

            oc_Newobject97["#Newobject96"] = oc_Newobject96;

            #endregion

            oc_Newobject125["#Newobject97"] = oc_Newobject97;

            #region GuiRolloutCtrl ()        oc_Newobject124

            ObjectCreator oc_Newobject124 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject124["class"] = "BehaviorQuickEditRollout";
            oc_Newobject124["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject124["Profile"] = "GuiRolloutProfile";
            oc_Newobject124["HorizSizing"] = "width";
            oc_Newobject124["VertSizing"] = "bottom";
            oc_Newobject124["Position"] = "0 0";
            oc_Newobject124["Extent"] = "197 0";
            oc_Newobject124["Caption"] = "Blending";
            oc_Newobject124["Margin"] = "4 4 4 0";
            oc_Newobject124["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject124["container"] = new Creator.StringNoQuote("true");
            oc_Newobject124["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject124["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject123

            ObjectCreator oc_Newobject123 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject123["StackingType"] = "Vertical";
            oc_Newobject123["HorizStacking"] = "Left to Right";
            oc_Newobject123["VertStacking"] = "Top to Bottom";
            oc_Newobject123["Padding"] = "0";
            oc_Newobject123["canSaveDynamicFields"] = "0";
            oc_Newobject123["Enabled"] = "1";
            oc_Newobject123["isContainer"] = "1";
            oc_Newobject123["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject123["HorizSizing"] = "width";
            oc_Newobject123["VertSizing"] = "bottom";
            oc_Newobject123["Position"] = "1 3";
            oc_Newobject123["Extent"] = "197 16";
            oc_Newobject123["MinExtent"] = "16 16";
            oc_Newobject123["canSave"] = "1";
            oc_Newobject123["isDecoy"] = "0";
            oc_Newobject123["Visible"] = "1";
            oc_Newobject123["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject123["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject100

            ObjectCreator oc_Newobject100 = new ObjectCreator("GuiControl", "");
            oc_Newobject100["isContainer"] = "1";
            oc_Newobject100["HorizSizing"] = "width";
            oc_Newobject100["VertSizing"] = "bottom";
            oc_Newobject100["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject100["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject98

            ObjectCreator oc_Newobject98 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject98["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject98["HorizSizing"] = "width";
            oc_Newobject98["VertSizing"] = "bottom";
            oc_Newobject98["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject98["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject98["text"] = "Blend Type";

            #endregion

            oc_Newobject100["#Newobject98"] = oc_Newobject98;

            #region GuiPopUpMenuCtrl ()        oc_Newobject99

            ObjectCreator oc_Newobject99 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject99["internalName"] = "PEE_blendType";
            oc_Newobject99["HorizSizing"] = "left";
            oc_Newobject99["VertSizing"] = "bottom";
            oc_Newobject99["position"] = new Creator.StringNoQuote("$PE_guielement_pos_textedit");
            oc_Newobject99["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_textedit");
            oc_Newobject99["command"] = "PE_EmitterEditor.updateEmitter( \\\"blendStyle\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject100["#Newobject99"] = oc_Newobject99;

            #endregion

            oc_Newobject123["#Newobject100"] = oc_Newobject100;

            #region GuiControl ()        oc_Newobject104

            ObjectCreator oc_Newobject104 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject104["class"] = "AggregateControl";
            oc_Newobject104["isContainer"] = "1";
            oc_Newobject104["HorizSizing"] = "width";
            oc_Newobject104["VertSizing"] = "bottom";
            oc_Newobject104["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject104["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject101

            ObjectCreator oc_Newobject101 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject101["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject101["HorizSizing"] = "width";
            oc_Newobject101["VertSizing"] = "bottom";
            oc_Newobject101["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject101["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject101["text"] = "Softness Distance ";

            #endregion

            oc_Newobject104["#Newobject101"] = oc_Newobject101;

            #region GuiSliderCtrl ()        oc_Newobject102

            ObjectCreator oc_Newobject102 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject102["internalName"] = "PEE_softnessDistance_slider";
            oc_Newobject102["canSaveDynamicFields"] = "0";
            oc_Newobject102["Enabled"] = "1";
            oc_Newobject102["isContainer"] = "0";
            oc_Newobject102["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject102["HorizSizing"] = "left";
            oc_Newobject102["VertSizing"] = "bottom";
            oc_Newobject102["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject102["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject102["MinExtent"] = "8 2";
            oc_Newobject102["canSave"] = "1";
            oc_Newobject102["Visible"] = "1";
            oc_Newobject102["Command"] = "";
            oc_Newobject102["hovertime"] = "1000";
            oc_Newobject102["range"] = "0 1000";
            oc_Newobject102["ticks"] = "0";
            oc_Newobject102["value"] = "0";
            oc_Newobject102["Command"] = "PE_EmitterEditor.updateEmitter( \\\"softnessDistance\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject102["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"softnessDistance\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject104["#Newobject102"] = oc_Newobject102;

            #region GuiTextEditCtrl ()        oc_Newobject103

            ObjectCreator oc_Newobject103 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject103["internalName"] = "PEE_softnessDistance_textEdit";
            oc_Newobject103["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject103["HorizSizing"] = "left";
            oc_Newobject103["VertSizing"] = "bottom";
            oc_Newobject103["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject103["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject103["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"softnessDistance\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject104["#Newobject103"] = oc_Newobject103;

            #endregion

            oc_Newobject123["#Newobject104"] = oc_Newobject104;

            #region GuiControl ()        oc_Newobject108

            ObjectCreator oc_Newobject108 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject108["class"] = "AggregateControl";
            oc_Newobject108["isContainer"] = "1";
            oc_Newobject108["HorizSizing"] = "width";
            oc_Newobject108["VertSizing"] = "bottom";
            oc_Newobject108["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject108["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject105

            ObjectCreator oc_Newobject105 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject105["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject105["HorizSizing"] = "width";
            oc_Newobject105["VertSizing"] = "bottom";
            oc_Newobject105["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject105["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject105["text"] = "Ambient Factor";

            #endregion

            oc_Newobject108["#Newobject105"] = oc_Newobject105;

            #region GuiSliderCtrl ()        oc_Newobject106

            ObjectCreator oc_Newobject106 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject106["internalName"] = "PEE_ambientFactor_slider";
            oc_Newobject106["canSaveDynamicFields"] = "0";
            oc_Newobject106["Enabled"] = "1";
            oc_Newobject106["isContainer"] = "0";
            oc_Newobject106["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject106["HorizSizing"] = "left";
            oc_Newobject106["VertSizing"] = "bottom";
            oc_Newobject106["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject106["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject106["MinExtent"] = "8 2";
            oc_Newobject106["canSave"] = "1";
            oc_Newobject106["Visible"] = "1";
            oc_Newobject106["Command"] = "";
            oc_Newobject106["hovertime"] = "1000";
            oc_Newobject106["range"] = "0 10";
            oc_Newobject106["ticks"] = "0";
            oc_Newobject106["value"] = "0";
            oc_Newobject106["Command"] = "PE_EmitterEditor.updateEmitter( \\\"ambientFactor\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject106["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"ambientFactor\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject108["#Newobject106"] = oc_Newobject106;

            #region GuiTextEditCtrl ()        oc_Newobject107

            ObjectCreator oc_Newobject107 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject107["internalName"] = "PEE_ambientFactor_textEdit";
            oc_Newobject107["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject107["HorizSizing"] = "left";
            oc_Newobject107["VertSizing"] = "bottom";
            oc_Newobject107["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject107["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject107["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_EmitterEditor.updateEmitter( \\\"ambientFactor\\\", $ThisControl.getText));";

            #endregion

            oc_Newobject108["#Newobject107"] = oc_Newobject107;

            #endregion

            oc_Newobject123["#Newobject108"] = oc_Newobject108;

            #region GuiControl ()        oc_Newobject110

            ObjectCreator oc_Newobject110 = new ObjectCreator("GuiControl", "");
            oc_Newobject110["isContainer"] = "1";
            oc_Newobject110["HorizSizing"] = "width";
            oc_Newobject110["Position"] = "0 0";
            oc_Newobject110["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject109

            ObjectCreator oc_Newobject109 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject109["position"] = "0 3";
            oc_Newobject109["extent"] = "188 2";
            oc_Newobject109["HorizSizing"] = "width";
            oc_Newobject109["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject110["#Newobject109"] = oc_Newobject109;

            #endregion

            oc_Newobject123["#Newobject110"] = oc_Newobject110;

            #region GuiControl ()        oc_Newobject113

            ObjectCreator oc_Newobject113 = new ObjectCreator("GuiControl", "");
            oc_Newobject113["isContainer"] = "1";
            oc_Newobject113["HorizSizing"] = "width";
            oc_Newobject113["VertSizing"] = "bottom";
            oc_Newobject113["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject113["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject111

            ObjectCreator oc_Newobject111 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject111["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject111["HorizSizing"] = "width";
            oc_Newobject111["VertSizing"] = "bottom";
            oc_Newobject111["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject111["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject111["text"] = "Sort Particles";

            #endregion

            oc_Newobject113["#Newobject111"] = oc_Newobject111;

            #region GuiCheckBoxCtrl ()        oc_Newobject112

            ObjectCreator oc_Newobject112 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject112["internalName"] = "PEE_softParticles";
            oc_Newobject112["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject112["HorizSizing"] = "left";
            oc_Newobject112["VertSizing"] = "bottom";
            oc_Newobject112["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject112["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject112["text"] = "";
            oc_Newobject112["command"] = "PE_EmitterEditor.updateEmitter( \\\"softParticles\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject113["#Newobject112"] = oc_Newobject112;

            #endregion

            oc_Newobject123["#Newobject113"] = oc_Newobject113;

            #region GuiControl ()        oc_Newobject116

            ObjectCreator oc_Newobject116 = new ObjectCreator("GuiControl", "");
            oc_Newobject116["isContainer"] = "1";
            oc_Newobject116["HorizSizing"] = "width";
            oc_Newobject116["VertSizing"] = "bottom";
            oc_Newobject116["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject116["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject114

            ObjectCreator oc_Newobject114 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject114["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject114["HorizSizing"] = "width";
            oc_Newobject114["VertSizing"] = "bottom";
            oc_Newobject114["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject114["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject114["text"] = "Reverse Order";

            #endregion

            oc_Newobject116["#Newobject114"] = oc_Newobject114;

            #region GuiCheckBoxCtrl ()        oc_Newobject115

            ObjectCreator oc_Newobject115 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject115["internalName"] = "PEE_reverseOrder";
            oc_Newobject115["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject115["HorizSizing"] = "left";
            oc_Newobject115["VertSizing"] = "bottom";
            oc_Newobject115["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject115["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject115["text"] = "";
            oc_Newobject115["command"] = "PE_EmitterEditor.updateEmitter( \\\"reverseOrder\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject116["#Newobject115"] = oc_Newobject115;

            #endregion

            oc_Newobject123["#Newobject116"] = oc_Newobject116;

            #region GuiControl ()        oc_Newobject119

            ObjectCreator oc_Newobject119 = new ObjectCreator("GuiControl", "");
            oc_Newobject119["isContainer"] = "1";
            oc_Newobject119["HorizSizing"] = "width";
            oc_Newobject119["VertSizing"] = "bottom";
            oc_Newobject119["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject119["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject117

            ObjectCreator oc_Newobject117 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject117["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject117["HorizSizing"] = "width";
            oc_Newobject117["VertSizing"] = "bottom";
            oc_Newobject117["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject117["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject117["text"] = "Use Emitter Size";

            #endregion

            oc_Newobject119["#Newobject117"] = oc_Newobject117;

            #region GuiCheckBoxCtrl (PEE_useEmitterSizes)        oc_Newobject118

            ObjectCreator oc_Newobject118 = new ObjectCreator("GuiCheckBoxCtrl", "PEE_useEmitterSizes");
            oc_Newobject118["internalName"] = "PEE_useEmitterSizes";
            oc_Newobject118["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject118["HorizSizing"] = "left";
            oc_Newobject118["VertSizing"] = "bottom";
            oc_Newobject118["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject118["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject118["text"] = "";
            oc_Newobject118["command"] = "PE_EmitterEditor.updateEmitter( \\\"useEmitterSizes\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject119["#Newobject118"] = oc_Newobject118;

            #endregion

            oc_Newobject123["#Newobject119"] = oc_Newobject119;

            #region GuiControl ()        oc_Newobject122

            ObjectCreator oc_Newobject122 = new ObjectCreator("GuiControl", "");
            oc_Newobject122["isContainer"] = "1";
            oc_Newobject122["HorizSizing"] = "width";
            oc_Newobject122["VertSizing"] = "bottom";
            oc_Newobject122["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject122["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject120

            ObjectCreator oc_Newobject120 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject120["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject120["HorizSizing"] = "width";
            oc_Newobject120["VertSizing"] = "bottom";
            oc_Newobject120["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject120["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox_name");
            oc_Newobject120["text"] = "Use Material Effect Color";

            #endregion

            oc_Newobject122["#Newobject120"] = oc_Newobject120;

            #region GuiCheckBoxCtrl (PEE_useEmitterColors)        oc_Newobject121

            ObjectCreator oc_Newobject121 = new ObjectCreator("GuiCheckBoxCtrl", "PEE_useEmitterColors");
            oc_Newobject121["internalName"] = "PEE_useEmitterColors";
            oc_Newobject121["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject121["HorizSizing"] = "left";
            oc_Newobject121["VertSizing"] = "bottom";
            oc_Newobject121["position"] = new Creator.StringNoQuote("$PE_guielement_pos_checkbox");
            oc_Newobject121["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_checkbox");
            oc_Newobject121["text"] = "";
            oc_Newobject121["command"] = "PE_EmitterEditor.updateEmitter( \\\"useEmitterColors\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject122["#Newobject121"] = oc_Newobject121;

            #endregion

            oc_Newobject123["#Newobject122"] = oc_Newobject122;

            #endregion

            oc_Newobject124["#Newobject123"] = oc_Newobject123;

            #endregion

            oc_Newobject125["#Newobject124"] = oc_Newobject124;

            #endregion

            oc_Newobject126["#Newobject125"] = oc_Newobject125;

            #endregion

            oc_Newobject127["#Newobject126"] = oc_Newobject126;

            #endregion

            oc_Newobject240["#Newobject127"] = oc_Newobject127;

            #region GuiTabPageCtrl (PE_ParticleEditor)        oc_Newobject239

            ObjectCreator oc_Newobject239 = new ObjectCreator("GuiTabPageCtrl", "PE_ParticleEditor", typeof (ParticleParticleEditor.PE_ParticleEditor));
            oc_Newobject239["canSaveDynamicFields"] = "0";
            oc_Newobject239["Enabled"] = "1";
            oc_Newobject239["isContainer"] = "1";
            oc_Newobject239["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject239["HorizSizing"] = "width";
            oc_Newobject239["VertSizing"] = "height";
            oc_Newobject239["position"] = "0 19";
            oc_Newobject239["Extent"] = "197 271";
            oc_Newobject239["MinExtent"] = "8 2";
            oc_Newobject239["canSave"] = "1";
            oc_Newobject239["Visible"] = "1";
            oc_Newobject239["hovertime"] = "1000";
            oc_Newobject239["Margin"] = "0 0 0 0";
            oc_Newobject239["Padding"] = "0 0 0 0";
            oc_Newobject239["AnchorTop"] = "1";
            oc_Newobject239["AnchorBottom"] = "0";
            oc_Newobject239["AnchorLeft"] = "1";
            oc_Newobject239["AnchorRight"] = "0";
            oc_Newobject239["text"] = "Particle";
            oc_Newobject239["maxLength"] = "1024";

            #region GuiScrollCtrl ()        oc_Newobject238

            ObjectCreator oc_Newobject238 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject238["canSaveDynamicFields"] = "0";
            oc_Newobject238["Enabled"] = "1";
            oc_Newobject238["isContainer"] = "1";
            oc_Newobject238["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject238["HorizSizing"] = "width";
            oc_Newobject238["VertSizing"] = "height";
            oc_Newobject238["Position"] = "0 0";
            oc_Newobject238["Extent"] = "197 271";
            oc_Newobject238["MinExtent"] = "8 8";
            oc_Newobject238["canSave"] = "1";
            oc_Newobject238["Visible"] = "1";
            oc_Newobject238["hovertime"] = "1000";
            oc_Newobject238["willFirstRespond"] = "1";
            oc_Newobject238["hScrollBar"] = "alwaysOff";
            oc_Newobject238["vScrollBar"] = "dynamic";
            oc_Newobject238["lockHorizScroll"] = new Creator.StringNoQuote("false");
            oc_Newobject238["lockVertScroll"] = "false";
            oc_Newobject238["constantThumbHeight"] = "0";
            oc_Newobject238["childMargin"] = "0 0";

            #region GuiStackControl ()        oc_Newobject237

            ObjectCreator oc_Newobject237 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject237["StackingType"] = "Vertical";
            oc_Newobject237["HorizStacking"] = "Left to Right";
            oc_Newobject237["VertStacking"] = "Top to Bottom";
            oc_Newobject237["Padding"] = "0";
            oc_Newobject237["canSaveDynamicFields"] = "0";
            oc_Newobject237["Enabled"] = "1";
            oc_Newobject237["isContainer"] = "1";
            oc_Newobject237["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject237["HorizSizing"] = "width";
            oc_Newobject237["VertSizing"] = "bottom";
            oc_Newobject237["Position"] = "1 3";
            oc_Newobject237["Extent"] = "197 16";
            oc_Newobject237["MinExtent"] = "16 16";
            oc_Newobject237["canSave"] = "1";
            oc_Newobject237["isDecoy"] = "0";
            oc_Newobject237["Visible"] = "1";
            oc_Newobject237["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject237["hovertime"] = "1000";

            #region GuiControl (PEP_ParticleSelector_Control)        oc_Newobject133

            ObjectCreator oc_Newobject133 = new ObjectCreator("GuiControl", "PEP_ParticleSelector_Control", typeof (ParticleParticleEditor.PEP_ParticleSelector_Control));
            oc_Newobject133["isContainer"] = "1";
            //oc_Newobject133["class"] = "QuickEditDropDownTextEditCtrl";
            oc_Newobject133["HorizSizing"] = "width";
            oc_Newobject133["VertSizing"] = "bottom";
            oc_Newobject133["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject133["Extent"] = "197 26";

            #region GuiPopUpMenuCtrl (PEP_ParticleSelector)        oc_Newobject128

            ObjectCreator oc_Newobject128 = new ObjectCreator("GuiPopUpMenuCtrl", "PEP_ParticleSelector");
            oc_Newobject128["internalName"] = "PopUpMenu";
            oc_Newobject128["canSaveDynamicFields"] = "0";
            oc_Newobject128["Enabled"] = "1";
            oc_Newobject128["isContainer"] = "0";
            oc_Newobject128["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject128["HorizSizing"] = "width";
            oc_Newobject128["VertSizing"] = "bottom";
            oc_Newobject128["position"] = "4 4";
            oc_Newobject128["Extent"] = "123 18";
            oc_Newobject128["MinExtent"] = "8 2";
            oc_Newobject128["canSave"] = "1";
            oc_Newobject128["Visible"] = "1";
            oc_Newobject128["Command"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.onNewParticle();";
            oc_Newobject128["hovertime"] = "1000";
            oc_Newobject128["Margin"] = "0 0 0 0";
            oc_Newobject128["Padding"] = "0 0 0 0";
            oc_Newobject128["AnchorTop"] = "1";
            oc_Newobject128["AnchorBottom"] = "0";
            oc_Newobject128["AnchorLeft"] = "1";
            oc_Newobject128["AnchorRight"] = "0";
            oc_Newobject128["maxLength"] = "255";
            oc_Newobject128["maxPopupHeight"] = "200";
            oc_Newobject128["sbUsesNAColor"] = "0";
            oc_Newobject128["reverseTextList"] = "0";
            oc_Newobject128["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject133["#Newobject128"] = oc_Newobject128;

            #region GuiTextEditCtrl ()        oc_Newobject129

            ObjectCreator oc_Newobject129 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject129["internalName"] = "TextEdit";
            oc_Newobject129["canSaveDynamicFields"] = "0";
            oc_Newobject129["Enabled"] = "1";
            oc_Newobject129["isContainer"] = "0";
            oc_Newobject129["Profile"] = "GuiDropdownTextEditProfile";
            oc_Newobject129["HorizSizing"] = "width";
            oc_Newobject129["VertSizing"] = "bottom";
            oc_Newobject129["position"] = "4 4";
            oc_Newobject129["Extent"] = "107 18";
            oc_Newobject129["MinExtent"] = "8 2";
            oc_Newobject129["canSave"] = "1";
            oc_Newobject129["Visible"] = "1";
            oc_Newobject129["hovertime"] = "1000";
            oc_Newobject129["Margin"] = "0 0 0 0";
            oc_Newobject129["Padding"] = "0 0 0 0";
            oc_Newobject129["AnchorTop"] = "1";
            oc_Newobject129["AnchorBottom"] = "0";
            oc_Newobject129["AnchorLeft"] = "1";
            oc_Newobject129["AnchorRight"] = "0";
            oc_Newobject129["text"] = "None";
            oc_Newobject129["maxLength"] = "1024";
            oc_Newobject129["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl);";

            #endregion

            oc_Newobject133["#Newobject129"] = oc_Newobject129;

            #region GuiBitmapButtonCtrl ( PEP_NewParticleButton )        oc_Newobject130

            ObjectCreator oc_Newobject130 = new ObjectCreator("GuiBitmapButtonCtrl", "PEP_NewParticleButton", typeof (ParticleParticleEditor.PEP_NewParticleButton));
            oc_Newobject130["canSaveDynamicFields"] = "0";
            oc_Newobject130["Enabled"] = "1";
            oc_Newobject130["isContainer"] = "0";
            oc_Newobject130["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject130["HorizSizing"] = "left";
            oc_Newobject130["VertSizing"] = "bottom";
            oc_Newobject130["position"] = "131 5";
            oc_Newobject130["Extent"] = "17 17";
            oc_Newobject130["MinExtent"] = "8 2";
            oc_Newobject130["canSave"] = "1";
            oc_Newobject130["Visible"] = "1";
            oc_Newobject130["hovertime"] = "1000";
            oc_Newobject130["groupNum"] = "-1";
            oc_Newobject130["buttonType"] = "PushButton";
            oc_Newobject130["useMouseEvents"] = "0";
            oc_Newobject130["bitmap"] = "tools/gui/images/new";
            oc_Newobject130["tooltip"] = "Add New Particle To Current Emitter";
            oc_Newobject130["useModifiers"] = "1";

            #endregion

            oc_Newobject133["#Newobject130"] = oc_Newobject130;

            #region GuiBitmapButtonCtrl ()        oc_Newobject131

            ObjectCreator oc_Newobject131 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject131["canSaveDynamicFields"] = "0";
            oc_Newobject131["Enabled"] = "1";
            oc_Newobject131["isContainer"] = "0";
            oc_Newobject131["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject131["HorizSizing"] = "left";
            oc_Newobject131["VertSizing"] = "bottom";
            oc_Newobject131["position"] = "147 5";
            oc_Newobject131["Extent"] = "17 17";
            oc_Newobject131["MinExtent"] = "8 2";
            oc_Newobject131["canSave"] = "1";
            oc_Newobject131["Visible"] = "1";
            oc_Newobject131["hovertime"] = "1000";
            oc_Newobject131["groupNum"] = "-1";
            oc_Newobject131["buttonType"] = "PushButton";
            oc_Newobject131["useMouseEvents"] = "0";
            oc_Newobject131["bitmap"] = "tools/gui/images/save-icon";
            oc_Newobject131["command"] = "PE_ParticleEditor.saveParticle( PE_ParticleEditor.currParticle );";
            oc_Newobject131["tooltip"] = "Save Current Particle";

            #endregion

            oc_Newobject133["#Newobject131"] = oc_Newobject131;

            #region GuiBitmapButtonCtrl ()        oc_Newobject132

            ObjectCreator oc_Newobject132 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject132["canSaveDynamicFields"] = "0";
            oc_Newobject132["Enabled"] = "1";
            oc_Newobject132["isContainer"] = "0";
            oc_Newobject132["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject132["HorizSizing"] = "left";
            oc_Newobject132["VertSizing"] = "bottom";
            oc_Newobject132["position"] = "164 5";
            oc_Newobject132["Extent"] = "17 17";
            oc_Newobject132["MinExtent"] = "8 2";
            oc_Newobject132["canSave"] = "1";
            oc_Newobject132["Visible"] = "1";
            oc_Newobject132["Command"] = "PE_ParticleEditor.showDeleteDialog();";
            oc_Newobject132["hovertime"] = "1000";
            oc_Newobject132["groupNum"] = "-1";
            oc_Newobject132["buttonType"] = "PushButton";
            oc_Newobject132["useMouseEvents"] = "0";
            oc_Newobject132["bitmap"] = "tools/gui/images/delete";
            oc_Newobject132["tooltip"] = "Delete Current Particle";

            #endregion

            oc_Newobject133["#Newobject132"] = oc_Newobject132;

            #endregion

            oc_Newobject237["#Newobject133"] = oc_Newobject133;

            #region GuiRolloutCtrl ()        oc_Newobject153

            ObjectCreator oc_Newobject153 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject153["class"] = "BehaviorQuickEditRollout";
            oc_Newobject153["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject153["Profile"] = "GuiRolloutProfile";
            oc_Newobject153["HorizSizing"] = "width";
            oc_Newobject153["VertSizing"] = "bottom";
            oc_Newobject153["Position"] = "0 0";
            oc_Newobject153["Extent"] = "197 0";
            oc_Newobject153["Caption"] = "Basic";
            oc_Newobject153["Margin"] = "4 4 4 0";
            oc_Newobject153["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject153["container"] = new Creator.StringNoQuote("true");
            oc_Newobject153["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject153["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject152

            ObjectCreator oc_Newobject152 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject152["StackingType"] = "Vertical";
            oc_Newobject152["HorizStacking"] = "Left to Right";
            oc_Newobject152["VertStacking"] = "Top to Bottom";
            oc_Newobject152["Padding"] = "0";
            oc_Newobject152["canSaveDynamicFields"] = "0";
            oc_Newobject152["Enabled"] = "1";
            oc_Newobject152["isContainer"] = "1";
            oc_Newobject152["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject152["HorizSizing"] = "width";
            oc_Newobject152["VertSizing"] = "bottom";
            oc_Newobject152["Position"] = "1 3";
            oc_Newobject152["Extent"] = "197 16";
            oc_Newobject152["MinExtent"] = "16 16";
            oc_Newobject152["canSave"] = "1";
            oc_Newobject152["isDecoy"] = "0";
            oc_Newobject152["Visible"] = "1";
            oc_Newobject152["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject152["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject141

            ObjectCreator oc_Newobject141 = new ObjectCreator("GuiContainer", "");
            oc_Newobject141["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject141["isContainer"] = "1";
            oc_Newobject141["position"] = "0 0";
            oc_Newobject141["Extent"] = "185 52";
            oc_Newobject141["HorizSizing"] = "width";

            #region GuiBitmapCtrl ()        oc_Newobject134

            ObjectCreator oc_Newobject134 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject134["canSaveDynamicFields"] = "0";
            oc_Newobject134["Enabled"] = "1";
            oc_Newobject134["isContainer"] = "0";
            oc_Newobject134["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject134["HorizSizing"] = "right";
            oc_Newobject134["VertSizing"] = "bottom";
            oc_Newobject134["position"] = "1 1";
            oc_Newobject134["Extent"] = "48 48";
            oc_Newobject134["MinExtent"] = "8 2";
            oc_Newobject134["canSave"] = "1";
            oc_Newobject134["Visible"] = "1";
            oc_Newobject134["hovertime"] = "1000";
            oc_Newobject134["bitmap"] = "tools/materialeditor/gui/unknownImage";
            oc_Newobject134["wrap"] = "0";

            #endregion

            oc_Newobject141["#Newobject134"] = oc_Newobject134;

            #region GuiTextCtrl ()        oc_Newobject135

            ObjectCreator oc_Newobject135 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject135["canSaveDynamicFields"] = "0";
            oc_Newobject135["Enabled"] = "1";
            oc_Newobject135["isContainer"] = "0";
            oc_Newobject135["Profile"] = "EditorTextProfile";
            oc_Newobject135["HorizSizing"] = "right";
            oc_Newobject135["VertSizing"] = "bottom";
            oc_Newobject135["position"] = "56 -2";
            oc_Newobject135["Extent"] = "72 18";
            oc_Newobject135["MinExtent"] = "8 2";
            oc_Newobject135["canSave"] = "1";
            oc_Newobject135["Visible"] = "1";
            oc_Newobject135["hovertime"] = "1000";
            oc_Newobject135["Margin"] = "0 0 0 0";
            oc_Newobject135["Padding"] = "0 0 0 0";
            oc_Newobject135["AnchorTop"] = "1";
            oc_Newobject135["AnchorBottom"] = "0";
            oc_Newobject135["AnchorLeft"] = "1";
            oc_Newobject135["AnchorRight"] = "0";
            oc_Newobject135["text"] = "Texture Map";
            oc_Newobject135["maxLength"] = "1024";

            #endregion

            oc_Newobject141["#Newobject135"] = oc_Newobject135;

            #region GuiBitmapButtonCtrl ()        oc_Newobject136

            ObjectCreator oc_Newobject136 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject136["internalName"] = "PEP_previewImage";
            oc_Newobject136["canSaveDynamicFields"] = "0";
            oc_Newobject136["Enabled"] = "1";
            oc_Newobject136["isContainer"] = "0";
            oc_Newobject136["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject136["HorizSizing"] = "right";
            oc_Newobject136["VertSizing"] = "bottom";
            oc_Newobject136["position"] = "1 1";
            oc_Newobject136["Extent"] = "48 48";
            oc_Newobject136["MinExtent"] = "8 2";
            oc_Newobject136["canSave"] = "1";
            oc_Newobject136["Visible"] = "1";
            oc_Newobject136["Command"] = "";
            oc_Newobject136["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject136["ToolTip"] = "Edit Selected Particle.";
            oc_Newobject136["hovertime"] = "1000";
            oc_Newobject136["groupNum"] = "-1";
            oc_Newobject136["buttonType"] = "PushButton";
            oc_Newobject136["useMouseEvents"] = "0";
            oc_Newobject136["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";

            #endregion

            oc_Newobject141["#Newobject136"] = oc_Newobject136;

            #region GuiBitmapButtonCtrl ()        oc_Newobject137

            ObjectCreator oc_Newobject137 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject137["canSaveDynamicFields"] = "0";
            oc_Newobject137["Enabled"] = "1";
            oc_Newobject137["isContainer"] = "0";
            oc_Newobject137["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject137["HorizSizing"] = "right";
            oc_Newobject137["VertSizing"] = "bottom";
            oc_Newobject137["position"] = "1 1";
            oc_Newobject137["Extent"] = "48 48";
            oc_Newobject137["MinExtent"] = "8 2";
            oc_Newobject137["canSave"] = "1";
            oc_Newobject137["Visible"] = "1";
            oc_Newobject137["Command"] = "";
            oc_Newobject137["tooltipprofile"] = "ToolsGuiDefaultProfile";
            oc_Newobject137["ToolTip"] = "Edit Selected Particle.";
            oc_Newobject137["hovertime"] = "1000";
            oc_Newobject137["groupNum"] = "-1";
            oc_Newobject137["buttonType"] = "PushButton";
            oc_Newobject137["useMouseEvents"] = "0";
            oc_Newobject137["bitmap"] = "tools/materialEditor/gui/cubemapBtnBorder";
            oc_Newobject137["Command"] = "PE_ParticleEditor.updateParticleTexture(1);";

            #endregion

            oc_Newobject141["#Newobject137"] = oc_Newobject137;

            #region GuiCheckBoxCtrl ()        oc_Newobject138

            ObjectCreator oc_Newobject138 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject138["internalName"] = "PEP_inverseAlpha";
            oc_Newobject138["HorizSizing"] = "width";
            oc_Newobject138["VertSizing"] = "bottom";
            oc_Newobject138["position"] = "55 14";
            oc_Newobject138["Extent"] = "84 18";
            oc_Newobject138["MinExtent"] = "8 2";
            oc_Newobject138["text"] = "Inverse Alpha";
            oc_Newobject138["command"] = "PE_ParticleEditor.updateParticle( \\\"useInvAlpha\\\", $ThisControl.getValue());";

            #endregion

            oc_Newobject141["#Newobject138"] = oc_Newobject138;

            #region GuiTextEditCtrl (PEP_textureName)        oc_Newobject139

            ObjectCreator oc_Newobject139 = new ObjectCreator("GuiTextEditCtrl", "PEP_textureName");
            oc_Newobject139["internalName"] = "PEP_previewImageName";
            oc_Newobject139["canSaveDynamicFields"] = "0";
            oc_Newobject139["Enabled"] = "1";
            oc_Newobject139["isContainer"] = "0";
            oc_Newobject139["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject139["HorizSizing"] = "width";
            oc_Newobject139["VertSizing"] = "bottom";
            oc_Newobject139["position"] = "55 31";
            oc_Newobject139["Extent"] = "120 18";
            oc_Newobject139["MinExtent"] = "8 2";
            oc_Newobject139["canSave"] = "1";
            oc_Newobject139["Visible"] = "1";
            oc_Newobject139["hovertime"] = "1000";
            oc_Newobject139["Margin"] = "0 0 0 0";
            oc_Newobject139["Padding"] = "0 0 0 0";
            oc_Newobject139["AnchorTop"] = "1";
            oc_Newobject139["AnchorBottom"] = "0";
            oc_Newobject139["AnchorLeft"] = "1";
            oc_Newobject139["AnchorRight"] = "0";
            oc_Newobject139["text"] = "None";
            oc_Newobject139["maxLength"] = "1024";

            #endregion

            oc_Newobject141["#Newobject139"] = oc_Newobject139;

            #region GuiButtonCtrl ()        oc_Newobject140

            ObjectCreator oc_Newobject140 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject140["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject140["text"] = "Edit";
            oc_Newobject140["HorizSizing"] = "left";
            oc_Newobject140["VertSizing"] = "bottom";
            oc_Newobject140["position"] = "138 0";
            oc_Newobject140["Extent"] = "36 18";
            oc_Newobject140["buttonType"] = "PushButton";
            oc_Newobject140["Command"] = "PE_ParticleEditor.updateParticleTexture(1);";

            #endregion

            oc_Newobject141["#Newobject140"] = oc_Newobject140;

            #endregion

            oc_Newobject152["#Newobject141"] = oc_Newobject141;

            #region GuiControl ()        oc_Newobject143

            ObjectCreator oc_Newobject143 = new ObjectCreator("GuiControl", "");
            oc_Newobject143["isContainer"] = "1";
            oc_Newobject143["HorizSizing"] = "width";
            oc_Newobject143["Position"] = "0 0";
            oc_Newobject143["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject142

            ObjectCreator oc_Newobject142 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject142["position"] = "0 3";
            oc_Newobject142["extent"] = "188 2";
            oc_Newobject142["HorizSizing"] = "width";
            oc_Newobject142["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject143["#Newobject142"] = oc_Newobject142;

            #endregion

            oc_Newobject152["#Newobject143"] = oc_Newobject143;

            #region GuiControl ()        oc_Newobject147

            ObjectCreator oc_Newobject147 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject147["class"] = "AggregateControl";
            oc_Newobject147["isContainer"] = "1";
            oc_Newobject147["HorizSizing"] = "width";
            oc_Newobject147["VertSizing"] = "bottom";
            oc_Newobject147["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject147["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject144

            ObjectCreator oc_Newobject144 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject144["canSaveDynamicFields"] = "0";
            oc_Newobject144["Enabled"] = "1";
            oc_Newobject144["isContainer"] = "0";
            oc_Newobject144["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject144["HorizSizing"] = "width";
            oc_Newobject144["VertSizing"] = "bottom";
            oc_Newobject144["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject144["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject144["MinExtent"] = "8 2";
            oc_Newobject144["canSave"] = "1";
            oc_Newobject144["Visible"] = "1";
            oc_Newobject144["hovertime"] = "1000";
            oc_Newobject144["Margin"] = "0 0 0 0";
            oc_Newobject144["Padding"] = "0 0 0 0";
            oc_Newobject144["AnchorTop"] = "1";
            oc_Newobject144["AnchorBottom"] = "0";
            oc_Newobject144["AnchorLeft"] = "1";
            oc_Newobject144["AnchorRight"] = "0";
            oc_Newobject144["text"] = "Life";
            oc_Newobject144["maxLength"] = "255";

            #endregion

            oc_Newobject147["#Newobject144"] = oc_Newobject144;

            #region GuiSliderCtrl (PEP_lifetimeMS)        oc_Newobject145

            ObjectCreator oc_Newobject145 = new ObjectCreator("GuiSliderCtrl", "PEP_lifetimeMS");
            oc_Newobject145["internalName"] = "PEP_lifetimeMS_slider";
            oc_Newobject145["canSaveDynamicFields"] = "0";
            oc_Newobject145["Enabled"] = "1";
            oc_Newobject145["isContainer"] = "0";
            oc_Newobject145["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject145["HorizSizing"] = "left";
            oc_Newobject145["VertSizing"] = "bottom";
            oc_Newobject145["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject145["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject145["MinExtent"] = "8 2";
            oc_Newobject145["canSave"] = "1";
            oc_Newobject145["Visible"] = "1";
            oc_Newobject145["Command"] = "PE_ParticleEditor.updateLifeFields( false, $ThisControl.getValue(), true, true );";
            oc_Newobject145["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateLifeFields( false, $ThisControl.getValue(), true, false );";
            oc_Newobject145["hovertime"] = "1000";
            oc_Newobject145["range"] = "1 9000";
            oc_Newobject145["ticks"] = "0";
            oc_Newobject145["value"] = "3000";

            #endregion

            oc_Newobject147["#Newobject145"] = oc_Newobject145;

            #region GuiTextEditCtrl ()        oc_Newobject146

            ObjectCreator oc_Newobject146 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject146["internalName"] = "PEP_lifetimeMS_textEdit";
            oc_Newobject146["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject146["HorizSizing"] = "left";
            oc_Newobject146["VertSizing"] = "bottom";
            oc_Newobject146["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject146["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject146["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateLifeFields( false, $ThisControl.getText() );";

            #endregion

            oc_Newobject147["#Newobject146"] = oc_Newobject146;

            #endregion

            oc_Newobject152["#Newobject147"] = oc_Newobject147;

            #region GuiControl ()        oc_Newobject151

            ObjectCreator oc_Newobject151 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject151["class"] = "AggregateControl";
            oc_Newobject151["isContainer"] = "1";
            oc_Newobject151["HorizSizing"] = "width";
            oc_Newobject151["VertSizing"] = "bottom";
            oc_Newobject151["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject151["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject148

            ObjectCreator oc_Newobject148 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject148["canSaveDynamicFields"] = "0";
            oc_Newobject148["Enabled"] = "1";
            oc_Newobject148["isContainer"] = "0";
            oc_Newobject148["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject148["HorizSizing"] = "width";
            oc_Newobject148["VertSizing"] = "bottom";
            oc_Newobject148["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject148["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject148["MinExtent"] = "8 2";
            oc_Newobject148["canSave"] = "1";
            oc_Newobject148["Visible"] = "1";
            oc_Newobject148["hovertime"] = "1000";
            oc_Newobject148["Margin"] = "0 0 0 0";
            oc_Newobject148["Padding"] = "0 0 0 0";
            oc_Newobject148["AnchorTop"] = "1";
            oc_Newobject148["AnchorBottom"] = "0";
            oc_Newobject148["AnchorLeft"] = "1";
            oc_Newobject148["AnchorRight"] = "0";
            oc_Newobject148["text"] = "Life Random";
            oc_Newobject148["maxLength"] = "255";

            #endregion

            oc_Newobject151["#Newobject148"] = oc_Newobject148;

            #region GuiSliderCtrl (PEP_lifetimeVarianceMS)        oc_Newobject149

            ObjectCreator oc_Newobject149 = new ObjectCreator("GuiSliderCtrl", "PEP_lifetimeVarianceMS");
            oc_Newobject149["internalName"] = "PEP_lifetimeVarianceMS_slider";
            oc_Newobject149["canSaveDynamicFields"] = "0";
            oc_Newobject149["Enabled"] = "1";
            oc_Newobject149["isContainer"] = "0";
            oc_Newobject149["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject149["HorizSizing"] = "left";
            oc_Newobject149["VertSizing"] = "bottom";
            oc_Newobject149["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject149["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject149["MinExtent"] = "8 2";
            oc_Newobject149["canSave"] = "1";
            oc_Newobject149["Visible"] = "1";
            oc_Newobject149["Command"] = "PE_ParticleEditor.updateLifeFields( true, $ThisControl.getValue(), true, true );";
            oc_Newobject149["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateLifeFields( true, $ThisControl.getValue(), true, false );";
            oc_Newobject149["hovertime"] = "1000";
            oc_Newobject149["range"] = "0 8999";
            oc_Newobject149["ticks"] = "0";
            oc_Newobject149["value"] = "3000";

            #endregion

            oc_Newobject151["#Newobject149"] = oc_Newobject149;

            #region GuiTextEditCtrl ()        oc_Newobject150

            ObjectCreator oc_Newobject150 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject150["internalName"] = "PEP_lifetimeVarianceMS_textEdit";
            oc_Newobject150["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject150["HorizSizing"] = "left";
            oc_Newobject150["VertSizing"] = "bottom";
            oc_Newobject150["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject150["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject150["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateLifeFields( true, $ThisControl.getText() );";

            #endregion

            oc_Newobject151["#Newobject150"] = oc_Newobject150;

            #endregion

            oc_Newobject152["#Newobject151"] = oc_Newobject151;

            #endregion

            oc_Newobject153["#Newobject152"] = oc_Newobject152;

            #endregion

            oc_Newobject237["#Newobject153"] = oc_Newobject153;

            #region GuiRolloutCtrl ()        oc_Newobject174

            ObjectCreator oc_Newobject174 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject174["class"] = "BehaviorQuickEditRollout";
            oc_Newobject174["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject174["Profile"] = "GuiRolloutProfile";
            oc_Newobject174["HorizSizing"] = "width";
            oc_Newobject174["VertSizing"] = "bottom";
            oc_Newobject174["Position"] = "0 0";
            oc_Newobject174["Extent"] = "197 0";
            oc_Newobject174["Caption"] = "Motion";
            oc_Newobject174["Margin"] = "4 4 4 0";
            oc_Newobject174["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject174["container"] = new Creator.StringNoQuote("true");
            oc_Newobject174["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject174["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject173

            ObjectCreator oc_Newobject173 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject173["StackingType"] = "Vertical";
            oc_Newobject173["HorizStacking"] = "Left to Right";
            oc_Newobject173["VertStacking"] = "Top to Bottom";
            oc_Newobject173["Padding"] = "0";
            oc_Newobject173["canSaveDynamicFields"] = "0";
            oc_Newobject173["Enabled"] = "1";
            oc_Newobject173["isContainer"] = "1";
            oc_Newobject173["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject173["HorizSizing"] = "width";
            oc_Newobject173["VertSizing"] = "bottom";
            oc_Newobject173["Position"] = "1 3";
            oc_Newobject173["Extent"] = "197 16";
            oc_Newobject173["MinExtent"] = "16 16";
            oc_Newobject173["canSave"] = "1";
            oc_Newobject173["isDecoy"] = "0";
            oc_Newobject173["Visible"] = "1";
            oc_Newobject173["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject173["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject157

            ObjectCreator oc_Newobject157 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject157["class"] = "AggregateControl";
            oc_Newobject157["isContainer"] = "1";
            oc_Newobject157["HorizSizing"] = "width";
            oc_Newobject157["VertSizing"] = "bottom";
            oc_Newobject157["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject157["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject154

            ObjectCreator oc_Newobject154 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject154["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject154["HorizSizing"] = "width";
            oc_Newobject154["VertSizing"] = "bottom";
            oc_Newobject154["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject154["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject154["text"] = "Initial Speed";

            #endregion

            oc_Newobject157["#Newobject154"] = oc_Newobject154;

            #region GuiSliderCtrl (PEP_inheritedVelFactor)        oc_Newobject155

            ObjectCreator oc_Newobject155 = new ObjectCreator("GuiSliderCtrl", "PEP_inheritedVelFactor");
            oc_Newobject155["internalName"] = "PEP_inheritedVelFactor_slider";
            oc_Newobject155["canSaveDynamicFields"] = "0";
            oc_Newobject155["Enabled"] = "1";
            oc_Newobject155["isContainer"] = "0";
            oc_Newobject155["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject155["HorizSizing"] = "left";
            oc_Newobject155["VertSizing"] = "bottom";
            oc_Newobject155["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject155["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject155["MinExtent"] = "8 2";
            oc_Newobject155["canSave"] = "1";
            oc_Newobject155["Visible"] = "1";
            oc_Newobject155["Command"] = "PE_ParticleEditor.updateParticle( \\\"inheritedVelFactor\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject155["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"inheritedVelFactor\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject155["hovertime"] = "1000";
            oc_Newobject155["range"] = "0 10";
            oc_Newobject155["ticks"] = "0";
            oc_Newobject155["value"] = "0";

            #endregion

            oc_Newobject157["#Newobject155"] = oc_Newobject155;

            #region GuiTextEditCtrl ()        oc_Newobject156

            ObjectCreator oc_Newobject156 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject156["internalName"] = "PEP_inheritedVelFactor_textEdit";
            oc_Newobject156["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject156["HorizSizing"] = "left";
            oc_Newobject156["VertSizing"] = "bottom";
            oc_Newobject156["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject156["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject156["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"inheritedVelFactor\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject157["#Newobject156"] = oc_Newobject156;

            #endregion

            oc_Newobject173["#Newobject157"] = oc_Newobject157;

            #region GuiControl ()        oc_Newobject161

            ObjectCreator oc_Newobject161 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject161["class"] = "AggregateControl";
            oc_Newobject161["isContainer"] = "1";
            oc_Newobject161["HorizSizing"] = "width";
            oc_Newobject161["VertSizing"] = "bottom";
            oc_Newobject161["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject161["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject158

            ObjectCreator oc_Newobject158 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject158["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject158["HorizSizing"] = "width";
            oc_Newobject158["VertSizing"] = "bottom";
            oc_Newobject158["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject158["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject158["text"] = "Acceleration";

            #endregion

            oc_Newobject161["#Newobject158"] = oc_Newobject158;

            #region GuiSliderCtrl (PEP_constantAcceleration)        oc_Newobject159

            ObjectCreator oc_Newobject159 = new ObjectCreator("GuiSliderCtrl", "PEP_constantAcceleration");
            oc_Newobject159["internalName"] = "PEP_constantAcceleration_slider";
            oc_Newobject159["canSaveDynamicFields"] = "0";
            oc_Newobject159["Enabled"] = "1";
            oc_Newobject159["isContainer"] = "0";
            oc_Newobject159["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject159["HorizSizing"] = "left";
            oc_Newobject159["VertSizing"] = "bottom";
            oc_Newobject159["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject159["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject159["MinExtent"] = "8 2";
            oc_Newobject159["canSave"] = "1";
            oc_Newobject159["Visible"] = "1";
            oc_Newobject159["Command"] = "PE_ParticleEditor.updateParticle( \\\"constantAcceleration\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject159["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"constantAcceleration\\\", $ThisControl.getValue(), true, false);";
            oc_Newobject159["hovertime"] = "1000";
            oc_Newobject159["range"] = "-10 10";
            oc_Newobject159["ticks"] = "0";
            oc_Newobject159["value"] = "0";

            #endregion

            oc_Newobject161["#Newobject159"] = oc_Newobject159;

            #region GuiTextEditCtrl ()        oc_Newobject160

            ObjectCreator oc_Newobject160 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject160["internalName"] = "PEP_constantAcceleration_textEdit";
            oc_Newobject160["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject160["HorizSizing"] = "left";
            oc_Newobject160["VertSizing"] = "bottom";
            oc_Newobject160["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject160["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject160["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"constantAcceleration\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject161["#Newobject160"] = oc_Newobject160;

            #endregion

            oc_Newobject173["#Newobject161"] = oc_Newobject161;

            #region GuiControl ()        oc_Newobject163

            ObjectCreator oc_Newobject163 = new ObjectCreator("GuiControl", "");
            oc_Newobject163["isContainer"] = "1";
            oc_Newobject163["HorizSizing"] = "width";
            oc_Newobject163["Position"] = "0 0";
            oc_Newobject163["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject162

            ObjectCreator oc_Newobject162 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject162["position"] = "0 3";
            oc_Newobject162["extent"] = "188 2";
            oc_Newobject162["HorizSizing"] = "width";
            oc_Newobject162["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject163["#Newobject162"] = oc_Newobject162;

            #endregion

            oc_Newobject173["#Newobject163"] = oc_Newobject163;

            #region GuiControl ()        oc_Newobject168

            ObjectCreator oc_Newobject168 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject168["class"] = "AggregateControl";
            oc_Newobject168["isContainer"] = "1";
            oc_Newobject168["HorizSizing"] = "width";
            oc_Newobject168["VertSizing"] = "bottom";
            oc_Newobject168["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject168["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiBitmapCtrl ()        oc_Newobject164

            ObjectCreator oc_Newobject164 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject164["HorizSizing"] = "left";
            oc_Newobject164["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2)-1 SPC \"0\"");
            oc_Newobject164["Extent"] = "2 18";
            oc_Newobject164["minExtent"] = "0 0";
            oc_Newobject164["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject164["tooltip"] = "0 Gravity";

            #endregion

            oc_Newobject168["#Newobject164"] = oc_Newobject164;

            #region GuiTextCtrl ()        oc_Newobject165

            ObjectCreator oc_Newobject165 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject165["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject165["HorizSizing"] = "width";
            oc_Newobject165["VertSizing"] = "bottom";
            oc_Newobject165["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject165["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject165["text"] = "Gravity";

            #endregion

            oc_Newobject168["#Newobject165"] = oc_Newobject165;

            #region GuiSliderCtrl (PEP_gravityCoefficient)        oc_Newobject166

            ObjectCreator oc_Newobject166 = new ObjectCreator("GuiSliderCtrl", "PEP_gravityCoefficient");
            oc_Newobject166["internalName"] = "PEP_gravityCoefficient_slider";
            oc_Newobject166["canSaveDynamicFields"] = "0";
            oc_Newobject166["Enabled"] = "1";
            oc_Newobject166["isContainer"] = "0";
            oc_Newobject166["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject166["HorizSizing"] = "left";
            oc_Newobject166["VertSizing"] = "bottom";
            oc_Newobject166["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject166["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject166["MinExtent"] = "8 2";
            oc_Newobject166["canSave"] = "1";
            oc_Newobject166["Visible"] = "1";
            oc_Newobject166["Command"] = "PE_ParticleEditor.updateParticle( \\\"gravityCoefficient\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject166["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"gravityCoefficient\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject166["hovertime"] = "1000";
            oc_Newobject166["range"] = "-1 1";
            oc_Newobject166["ticks"] = "0";
            oc_Newobject166["value"] = "0";

            #endregion

            oc_Newobject168["#Newobject166"] = oc_Newobject166;

            #region GuiTextEditCtrl ()        oc_Newobject167

            ObjectCreator oc_Newobject167 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject167["internalName"] = "PEP_gravityCoefficient_textEdit";
            oc_Newobject167["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject167["HorizSizing"] = "left";
            oc_Newobject167["VertSizing"] = "bottom";
            oc_Newobject167["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject167["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject167["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"gravityCoefficient\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject168["#Newobject167"] = oc_Newobject167;

            #endregion

            oc_Newobject173["#Newobject168"] = oc_Newobject168;

            #region GuiControl ()        oc_Newobject172

            ObjectCreator oc_Newobject172 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject172["class"] = "AggregateControl";
            oc_Newobject172["isContainer"] = "1";
            oc_Newobject172["HorizSizing"] = "width";
            oc_Newobject172["VertSizing"] = "bottom";
            oc_Newobject172["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject172["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject169

            ObjectCreator oc_Newobject169 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject169["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject169["HorizSizing"] = "width";
            oc_Newobject169["VertSizing"] = "bottom";
            oc_Newobject169["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject169["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject169["text"] = "Drag";

            #endregion

            oc_Newobject172["#Newobject169"] = oc_Newobject169;

            #region GuiSliderCtrl (PEP_dragCoefficient)        oc_Newobject170

            ObjectCreator oc_Newobject170 = new ObjectCreator("GuiSliderCtrl", "PEP_dragCoefficient");
            oc_Newobject170["internalName"] = "PEP_dragCoefficient_slider";
            oc_Newobject170["canSaveDynamicFields"] = "0";
            oc_Newobject170["Enabled"] = "1";
            oc_Newobject170["isContainer"] = "0";
            oc_Newobject170["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject170["HorizSizing"] = "left";
            oc_Newobject170["VertSizing"] = "bottom";
            oc_Newobject170["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject170["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject170["MinExtent"] = "8 2";
            oc_Newobject170["canSave"] = "1";
            oc_Newobject170["Visible"] = "1";
            oc_Newobject170["Command"] = "PE_ParticleEditor.updateParticle( \\\"dragCoefficient\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject170["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"dragCoefficient\\\", $ThisControl.getValue(), true, false );";
            oc_Newobject170["hovertime"] = "1000";
            oc_Newobject170["range"] = "0 1";
            oc_Newobject170["ticks"] = "0";
            oc_Newobject170["value"] = "0.298143";

            #endregion

            oc_Newobject172["#Newobject170"] = oc_Newobject170;

            #region GuiTextEditCtrl ()        oc_Newobject171

            ObjectCreator oc_Newobject171 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject171["internalName"] = "PEP_dragCoefficient_textEdit";
            oc_Newobject171["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject171["HorizSizing"] = "left";
            oc_Newobject171["VertSizing"] = "bottom";
            oc_Newobject171["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject171["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject171["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"dragCoefficient\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject172["#Newobject171"] = oc_Newobject171;

            #endregion

            oc_Newobject173["#Newobject172"] = oc_Newobject172;

            #endregion

            oc_Newobject174["#Newobject173"] = oc_Newobject173;

            #endregion

            oc_Newobject237["#Newobject174"] = oc_Newobject174;

            #region GuiRolloutCtrl ()        oc_Newobject192

            ObjectCreator oc_Newobject192 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject192["class"] = "BehaviorQuickEditRollout";
            oc_Newobject192["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject192["Profile"] = "GuiRolloutProfile";
            oc_Newobject192["HorizSizing"] = "width";
            oc_Newobject192["VertSizing"] = "bottom";
            oc_Newobject192["Position"] = "0 0";
            oc_Newobject192["Extent"] = "197 0";
            oc_Newobject192["Caption"] = "Spin";
            oc_Newobject192["Margin"] = "4 4 4 0";
            oc_Newobject192["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject192["container"] = new Creator.StringNoQuote("true");
            oc_Newobject192["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject192["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject191

            ObjectCreator oc_Newobject191 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject191["StackingType"] = "Vertical";
            oc_Newobject191["HorizStacking"] = "Left to Right";
            oc_Newobject191["VertStacking"] = "Top to Bottom";
            oc_Newobject191["Padding"] = "0";
            oc_Newobject191["canSaveDynamicFields"] = "0";
            oc_Newobject191["Enabled"] = "1";
            oc_Newobject191["isContainer"] = "1";
            oc_Newobject191["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject191["HorizSizing"] = "width";
            oc_Newobject191["VertSizing"] = "bottom";
            oc_Newobject191["Position"] = "1 3";
            oc_Newobject191["Extent"] = "197 16";
            oc_Newobject191["MinExtent"] = "16 16";
            oc_Newobject191["canSave"] = "1";
            oc_Newobject191["isDecoy"] = "0";
            oc_Newobject191["Visible"] = "1";
            oc_Newobject191["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject191["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject179

            ObjectCreator oc_Newobject179 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject179["class"] = "AggregateControl";
            oc_Newobject179["isContainer"] = "1";
            oc_Newobject179["HorizSizing"] = "width";
            oc_Newobject179["VertSizing"] = "bottom";
            oc_Newobject179["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject179["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiBitmapCtrl ()        oc_Newobject175

            ObjectCreator oc_Newobject175 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject175["HorizSizing"] = "left";
            oc_Newobject175["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2)-1 SPC \"0\"");
            oc_Newobject175["Extent"] = "2 18";
            oc_Newobject175["minExtent"] = "0 0";
            oc_Newobject175["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject175["tooltip"] = "No Spin";

            #endregion

            oc_Newobject179["#Newobject175"] = oc_Newobject175;

            #region GuiTextCtrl ()        oc_Newobject176

            ObjectCreator oc_Newobject176 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject176["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject176["HorizSizing"] = "width";
            oc_Newobject176["VertSizing"] = "bottom";
            oc_Newobject176["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject176["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject176["text"] = "Spin Min";

            #endregion

            oc_Newobject179["#Newobject176"] = oc_Newobject176;

            #region GuiSliderCtrl (PEP_spinRandomMin)        oc_Newobject177

            ObjectCreator oc_Newobject177 = new ObjectCreator("GuiSliderCtrl", "PEP_spinRandomMin");
            oc_Newobject177["internalName"] = "PEP_spinRandomMin_slider";
            oc_Newobject177["canSaveDynamicFields"] = "0";
            oc_Newobject177["Enabled"] = "1";
            oc_Newobject177["isContainer"] = "0";
            oc_Newobject177["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject177["HorizSizing"] = "left";
            oc_Newobject177["VertSizing"] = "bottom";
            oc_Newobject177["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject177["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject177["MinExtent"] = "8 2";
            oc_Newobject177["canSave"] = "1";
            oc_Newobject177["Visible"] = "1";
            oc_Newobject177["Command"] = "PE_ParticleEditor.updateSpinFields( true, $ThisControl.getValue(), true, true );";
            oc_Newobject177["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateSpinFields( true, $ThisControl.getValue(), true, false );";
            oc_Newobject177["hovertime"] = "1000";
            oc_Newobject177["range"] = "-1000 999";
            oc_Newobject177["ticks"] = "0";
            oc_Newobject177["value"] = "0";

            #endregion

            oc_Newobject179["#Newobject177"] = oc_Newobject177;

            #region GuiTextEditCtrl ()        oc_Newobject178

            ObjectCreator oc_Newobject178 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject178["internalName"] = "PEP_spinRandomMin_textEdit";
            oc_Newobject178["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject178["HorizSizing"] = "left";
            oc_Newobject178["VertSizing"] = "bottom";
            oc_Newobject178["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject178["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject178["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateSpinFields( true, $ThisControl.getText() );";

            #endregion

            oc_Newobject179["#Newobject178"] = oc_Newobject178;

            #endregion

            oc_Newobject191["#Newobject179"] = oc_Newobject179;

            #region GuiControl ()        oc_Newobject184

            ObjectCreator oc_Newobject184 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject184["class"] = "AggregateControl";
            oc_Newobject184["isContainer"] = "1";
            oc_Newobject184["HorizSizing"] = "width";
            oc_Newobject184["VertSizing"] = "bottom";
            oc_Newobject184["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject184["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiBitmapCtrl ()        oc_Newobject180

            ObjectCreator oc_Newobject180 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject180["HorizSizing"] = "left";
            oc_Newobject180["position"] = new Creator.StringNoQuote("getWord($PE_guielement_pos_slider,0)+mCeil(getWord($PE_guielement_ext_slider,0)/2)-1 SPC \"0\"");
            oc_Newobject180["Extent"] = "2 18";
            oc_Newobject180["minExtent"] = "0 0";
            oc_Newobject180["bitmap"] = "tools/gui/images/separator-h";
            oc_Newobject180["tooltip"] = "No Spin";

            #endregion

            oc_Newobject184["#Newobject180"] = oc_Newobject180;

            #region GuiTextCtrl ()        oc_Newobject181

            ObjectCreator oc_Newobject181 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject181["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject181["HorizSizing"] = "width";
            oc_Newobject181["VertSizing"] = "bottom";
            oc_Newobject181["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject181["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject181["text"] = "Spin Max";

            #endregion

            oc_Newobject184["#Newobject181"] = oc_Newobject181;

            #region GuiSliderCtrl (PEP_spinRandomMax)        oc_Newobject182

            ObjectCreator oc_Newobject182 = new ObjectCreator("GuiSliderCtrl", "PEP_spinRandomMax");
            oc_Newobject182["internalName"] = "PEP_spinRandomMax_slider";
            oc_Newobject182["canSaveDynamicFields"] = "0";
            oc_Newobject182["Enabled"] = "1";
            oc_Newobject182["isContainer"] = "0";
            oc_Newobject182["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject182["HorizSizing"] = "left";
            oc_Newobject182["VertSizing"] = "bottom";
            oc_Newobject182["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject182["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject182["MinExtent"] = "8 2";
            oc_Newobject182["canSave"] = "1";
            oc_Newobject182["Visible"] = "1";
            oc_Newobject182["Command"] = "PE_ParticleEditor.updateSpinFields( false, $ThisControl.getValue(), true, true );";
            oc_Newobject182["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateSpinFields( false, $ThisControl.getValue(), true, false );";
            oc_Newobject182["hovertime"] = "1000";
            oc_Newobject182["range"] = "-999 1000";
            oc_Newobject182["ticks"] = "0";
            oc_Newobject182["value"] = "0";

            #endregion

            oc_Newobject184["#Newobject182"] = oc_Newobject182;

            #region GuiTextEditCtrl ()        oc_Newobject183

            ObjectCreator oc_Newobject183 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject183["internalName"] = "PEP_spinRandomMax_textEdit";
            oc_Newobject183["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject183["HorizSizing"] = "left";
            oc_Newobject183["VertSizing"] = "bottom";
            oc_Newobject183["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject183["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject183["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateSpinFields( false, $ThisControl.getText() );";

            #endregion

            oc_Newobject184["#Newobject183"] = oc_Newobject183;

            #endregion

            oc_Newobject191["#Newobject184"] = oc_Newobject184;

            #region GuiControl ()        oc_Newobject186

            ObjectCreator oc_Newobject186 = new ObjectCreator("GuiControl", "");
            oc_Newobject186["isContainer"] = "1";
            oc_Newobject186["HorizSizing"] = "width";
            oc_Newobject186["Position"] = "0 0";
            oc_Newobject186["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject185

            ObjectCreator oc_Newobject185 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject185["position"] = "0 3";
            oc_Newobject185["extent"] = "188 2";
            oc_Newobject185["HorizSizing"] = "width";
            oc_Newobject185["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject186["#Newobject185"] = oc_Newobject185;

            #endregion

            oc_Newobject191["#Newobject186"] = oc_Newobject186;

            #region GuiControl ()        oc_Newobject190

            ObjectCreator oc_Newobject190 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject190["class"] = "AggregateControl";
            oc_Newobject190["isContainer"] = "1";
            oc_Newobject190["HorizSizing"] = "width";
            oc_Newobject190["VertSizing"] = "bottom";
            oc_Newobject190["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject190["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject187

            ObjectCreator oc_Newobject187 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject187["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject187["HorizSizing"] = "width";
            oc_Newobject187["VertSizing"] = "bottom";
            oc_Newobject187["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject187["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject187["text"] = "Spin Speed";

            #endregion

            oc_Newobject190["#Newobject187"] = oc_Newobject187;

            #region GuiSliderCtrl (PEP_spinSpeed)        oc_Newobject188

            ObjectCreator oc_Newobject188 = new ObjectCreator("GuiSliderCtrl", "PEP_spinSpeed");
            oc_Newobject188["internalName"] = "PEP_spinSpeed_slider";
            oc_Newobject188["canSaveDynamicFields"] = "0";
            oc_Newobject188["Enabled"] = "1";
            oc_Newobject188["isContainer"] = "0";
            oc_Newobject188["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject188["HorizSizing"] = "left";
            oc_Newobject188["VertSizing"] = "bottom";
            oc_Newobject188["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject188["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject188["MinExtent"] = "8 2";
            oc_Newobject188["canSave"] = "1";
            oc_Newobject188["Visible"] = "1";
            oc_Newobject188["hovertime"] = "1000";
            oc_Newobject188["range"] = "0 1";
            oc_Newobject188["ticks"] = "0";
            oc_Newobject188["value"] = "0";
            oc_Newobject188["Command"] = "PE_ParticleEditor.updateParticle( \\\"spinSpeed\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject188["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"spinSpeed\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject190["#Newobject188"] = oc_Newobject188;

            #region GuiTextEditCtrl ()        oc_Newobject189

            ObjectCreator oc_Newobject189 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject189["internalName"] = "PEP_spinSpeed_textEdit";
            oc_Newobject189["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject189["HorizSizing"] = "left";
            oc_Newobject189["VertSizing"] = "bottom";
            oc_Newobject189["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject189["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject189["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"spinSpeed\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject190["#Newobject189"] = oc_Newobject189;

            #endregion

            oc_Newobject191["#Newobject190"] = oc_Newobject190;

            #endregion

            oc_Newobject192["#Newobject191"] = oc_Newobject191;

            #endregion

            oc_Newobject237["#Newobject192"] = oc_Newobject192;

            #region GuiRolloutCtrl ()        oc_Newobject236

            ObjectCreator oc_Newobject236 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject236["class"] = "BehaviorQuickEditRollout";
            oc_Newobject236["superclass"] = new Creator.StringNoQuote("LBQuickEditRollout");
            oc_Newobject236["Profile"] = "GuiRolloutProfile";
            oc_Newobject236["HorizSizing"] = "width";
            oc_Newobject236["VertSizing"] = "bottom";
            oc_Newobject236["Position"] = "0 0";
            oc_Newobject236["Extent"] = "197 0";
            oc_Newobject236["Caption"] = "Overtime";
            oc_Newobject236["Margin"] = "4 4 4 0";
            oc_Newobject236["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject236["container"] = new Creator.StringNoQuote("true");
            oc_Newobject236["parentRollout"] = new Creator.StringNoQuote("this.rollout");
            oc_Newobject236["object"] = new Creator.StringNoQuote("behavior");

            #region GuiStackControl ()        oc_Newobject235

            ObjectCreator oc_Newobject235 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject235["StackingType"] = "Vertical";
            oc_Newobject235["HorizStacking"] = "Left to Right";
            oc_Newobject235["VertStacking"] = "Top to Bottom";
            oc_Newobject235["Padding"] = "0";
            oc_Newobject235["canSaveDynamicFields"] = "0";
            oc_Newobject235["Enabled"] = "1";
            oc_Newobject235["isContainer"] = "1";
            oc_Newobject235["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject235["HorizSizing"] = "width";
            oc_Newobject235["VertSizing"] = "bottom";
            oc_Newobject235["Position"] = "1 3";
            oc_Newobject235["Extent"] = "197 16";
            oc_Newobject235["MinExtent"] = "16 16";
            oc_Newobject235["canSave"] = "1";
            oc_Newobject235["isDecoy"] = "0";
            oc_Newobject235["Visible"] = "1";
            oc_Newobject235["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject235["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject198

            ObjectCreator oc_Newobject198 = new ObjectCreator("GuiControl", "");
            oc_Newobject198["class"] = "";
            oc_Newobject198["isContainer"] = "1";
            oc_Newobject198["HorizSizing"] = "width";
            oc_Newobject198["VertSizing"] = "bottom";
            oc_Newobject198["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject198["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject193

            ObjectCreator oc_Newobject193 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject193["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject193["HorizSizing"] = "width";
            oc_Newobject193["VertSizing"] = "bottom";
            oc_Newobject193["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject193["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject193["text"] = "Colors";

            #endregion

            oc_Newobject198["#Newobject193"] = oc_Newobject193;

            #region GuiSwatchButtonCtrl (PE_ColorTintSwatch0)        oc_Newobject194

            ObjectCreator oc_Newobject194 = new ObjectCreator("GuiSwatchButtonCtrl", "PE_ColorTintSwatch0", typeof (ParticleParticleEditor.PE_ColorTintSwatch));
            oc_Newobject194["canSaveDynamicFields"] = "0";
            oc_Newobject194["Enabled"] = "1";
            oc_Newobject194["isContainer"] = "0";
            oc_Newobject194["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject194["HorizSizing"] = "left";
            oc_Newobject194["VertSizing"] = "bottom";
            oc_Newobject194["position"] = "75 0";
            oc_Newobject194["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_colorpicker");
            oc_Newobject194["MinExtent"] = "8 2";
            oc_Newobject194["canSave"] = "1";
            oc_Newobject194["Visible"] = "1";
            oc_Newobject194["Command"] = "getColorF( PE_ParticleEditor.currParticle.colors[0], \\\"PE_ColorTintSwatch0.updateParticleColor\\\");";
            oc_Newobject194["altCommand"] = "$ThisControl.updateParticleColor( $ThisControl.color );";
            oc_Newobject194["hovertime"] = "1000";
            oc_Newobject194["groupNum"] = "-1";
            oc_Newobject194["buttonType"] = "PushButton";
            oc_Newobject194["useMouseEvents"] = "1";
            oc_Newobject194["arrayNum"] = "0";
            //oc_Newobject194["class"] = "PE_ColorTintSwatch" ;

            #endregion

            oc_Newobject198["#Newobject194"] = oc_Newobject194;

            #region GuiSwatchButtonCtrl (PE_ColorTintSwatch1)        oc_Newobject195

            ObjectCreator oc_Newobject195 = new ObjectCreator("GuiSwatchButtonCtrl", "PE_ColorTintSwatch1", typeof (ParticleParticleEditor.PE_ColorTintSwatch));
            oc_Newobject195["canSaveDynamicFields"] = "0";
            oc_Newobject195["Enabled"] = "1";
            oc_Newobject195["isContainer"] = "0";
            oc_Newobject195["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject195["HorizSizing"] = "left";
            oc_Newobject195["VertSizing"] = "bottom";
            oc_Newobject195["position"] = "102 0";
            oc_Newobject195["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_colorpicker");
            oc_Newobject195["MinExtent"] = "8 2";
            oc_Newobject195["canSave"] = "1";
            oc_Newobject195["Visible"] = "1";
            oc_Newobject195["Command"] = "getColorF( PE_ParticleEditor.currParticle.colors[1], \\\"PE_ColorTintSwatch1.updateParticleColor\\\");";
            oc_Newobject195["altCommand"] = "$ThisControl.updateParticleColor( $ThisControl.color );";
            oc_Newobject195["hovertime"] = "1000";
            oc_Newobject195["groupNum"] = "-1";
            oc_Newobject195["buttonType"] = "PushButton";
            oc_Newobject195["useMouseEvents"] = "1";
            oc_Newobject195["arrayNum"] = "1";
            //oc_Newobject195["class"] = "PE_ColorTintSwatch" ;

            #endregion

            oc_Newobject198["#Newobject195"] = oc_Newobject195;

            #region GuiSwatchButtonCtrl (PE_ColorTintSwatch2)        oc_Newobject196

            ObjectCreator oc_Newobject196 = new ObjectCreator("GuiSwatchButtonCtrl", "PE_ColorTintSwatch2", typeof (ParticleParticleEditor.PE_ColorTintSwatch));
            oc_Newobject196["canSaveDynamicFields"] = "0";
            oc_Newobject196["Enabled"] = "1";
            oc_Newobject196["isContainer"] = "0";
            oc_Newobject196["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject196["HorizSizing"] = "left";
            oc_Newobject196["VertSizing"] = "bottom";
            oc_Newobject196["position"] = "129 0";
            oc_Newobject196["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_colorpicker");
            oc_Newobject196["MinExtent"] = "8 2";
            oc_Newobject196["canSave"] = "1";
            oc_Newobject196["Visible"] = "1";
            oc_Newobject196["Command"] = "getColorF( PE_ParticleEditor.currParticle.colors[2], \\\"PE_ColorTintSwatch2.updateParticleColor\\\");";
            oc_Newobject196["altCommand"] = "$ThisControl.updateParticleColor( $ThisControl.color );";
            oc_Newobject196["hovertime"] = "1000";
            oc_Newobject196["groupNum"] = "-1";
            oc_Newobject196["buttonType"] = "PushButton";
            oc_Newobject196["useMouseEvents"] = "1";
            oc_Newobject196["arrayNum"] = "2";
            //oc_Newobject196["class"] = "PE_ColorTintSwatch" ;

            #endregion

            oc_Newobject198["#Newobject196"] = oc_Newobject196;

            #region GuiSwatchButtonCtrl (PE_ColorTintSwatch3)        oc_Newobject197

            ObjectCreator oc_Newobject197 = new ObjectCreator("GuiSwatchButtonCtrl", "PE_ColorTintSwatch3", typeof (ParticleParticleEditor.PE_ColorTintSwatch));
            oc_Newobject197["canSaveDynamicFields"] = "0";
            oc_Newobject197["Enabled"] = "1";
            oc_Newobject197["isContainer"] = "0";
            oc_Newobject197["Profile"] = "GuiInspectorSwatchButtonProfile";
            oc_Newobject197["HorizSizing"] = "left";
            oc_Newobject197["VertSizing"] = "bottom";
            oc_Newobject197["position"] = "156 0";
            oc_Newobject197["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_colorpicker");
            oc_Newobject197["MinExtent"] = "8 2";
            oc_Newobject197["canSave"] = "1";
            oc_Newobject197["Visible"] = "1";
            oc_Newobject197["Command"] = "getColorF( PE_ParticleEditor.currParticle.colors[3], \\\"PE_ColorTintSwatch3.updateParticleColor\\\");";
            oc_Newobject197["altCommand"] = "$ThisControl.updateParticleColor( $ThisControl.color );";
            oc_Newobject197["hovertime"] = "1000";
            oc_Newobject197["groupNum"] = "-1";
            oc_Newobject197["buttonType"] = "PushButton";
            oc_Newobject197["useMouseEvents"] = "1";
            oc_Newobject197["arrayNum"] = "3";
            //oc_Newobject197["class"] = "PE_ColorTintSwatch" ;

            #endregion

            oc_Newobject198["#Newobject197"] = oc_Newobject197;

            #endregion

            oc_Newobject235["#Newobject198"] = oc_Newobject198;

            #region GuiControl ()        oc_Newobject200

            ObjectCreator oc_Newobject200 = new ObjectCreator("GuiControl", "");
            oc_Newobject200["isContainer"] = "1";
            oc_Newobject200["HorizSizing"] = "width";
            oc_Newobject200["Position"] = "0 0";
            oc_Newobject200["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject199

            ObjectCreator oc_Newobject199 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject199["position"] = "0 3";
            oc_Newobject199["extent"] = "188 2";
            oc_Newobject199["HorizSizing"] = "width";
            oc_Newobject199["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject200["#Newobject199"] = oc_Newobject199;

            #endregion

            oc_Newobject235["#Newobject200"] = oc_Newobject200;

            #region GuiControl ()        oc_Newobject204

            ObjectCreator oc_Newobject204 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject204["class"] = "AggregateControl";
            oc_Newobject204["isContainer"] = "1";
            oc_Newobject204["HorizSizing"] = "width";
            oc_Newobject204["VertSizing"] = "bottom";
            oc_Newobject204["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject204["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject201

            ObjectCreator oc_Newobject201 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject201["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject201["HorizSizing"] = "width";
            oc_Newobject201["VertSizing"] = "bottom";
            oc_Newobject201["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject201["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject201["text"] = "Size 1";

            #endregion

            oc_Newobject204["#Newobject201"] = oc_Newobject201;

            #region GuiSliderCtrl ()        oc_Newobject202

            ObjectCreator oc_Newobject202 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject202["internalName"] = "PEP_pointSize_slider0";
            oc_Newobject202["canSaveDynamicFields"] = "0";
            oc_Newobject202["Enabled"] = "1";
            oc_Newobject202["isContainer"] = "0";
            oc_Newobject202["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject202["HorizSizing"] = "left";
            oc_Newobject202["VertSizing"] = "bottom";
            oc_Newobject202["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject202["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject202["MinExtent"] = "8 2";
            oc_Newobject202["canSave"] = "1";
            oc_Newobject202["Visible"] = "1";
            oc_Newobject202["Command"] = "";
            oc_Newobject202["hovertime"] = "1000";
            oc_Newobject202["range"] = "0 50";
            oc_Newobject202["ticks"] = "0";
            oc_Newobject202["value"] = "0";
            oc_Newobject202["Command"] = "PE_ParticleEditor.updateParticle( \\\"sizes[0]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject202["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[0]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject204["#Newobject202"] = oc_Newobject202;

            #region GuiTextEditCtrl ()        oc_Newobject203

            ObjectCreator oc_Newobject203 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject203["internalName"] = "PEP_pointSize_textEdit0";
            oc_Newobject203["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject203["HorizSizing"] = "left";
            oc_Newobject203["VertSizing"] = "bottom";
            oc_Newobject203["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject203["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject203["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[0]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject204["#Newobject203"] = oc_Newobject203;

            #endregion

            oc_Newobject235["#Newobject204"] = oc_Newobject204;

            #region GuiControl ()        oc_Newobject208

            ObjectCreator oc_Newobject208 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject208["class"] = "AggregateControl";
            oc_Newobject208["isContainer"] = "1";
            oc_Newobject208["HorizSizing"] = "width";
            oc_Newobject208["VertSizing"] = "bottom";
            oc_Newobject208["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject208["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject205

            ObjectCreator oc_Newobject205 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject205["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject205["HorizSizing"] = "width";
            oc_Newobject205["VertSizing"] = "bottom";
            oc_Newobject205["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject205["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject205["text"] = "Size 2";

            #endregion

            oc_Newobject208["#Newobject205"] = oc_Newobject205;

            #region GuiSliderCtrl ()        oc_Newobject206

            ObjectCreator oc_Newobject206 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject206["internalName"] = "PEP_pointSize_slider1";
            oc_Newobject206["canSaveDynamicFields"] = "0";
            oc_Newobject206["Enabled"] = "1";
            oc_Newobject206["isContainer"] = "0";
            oc_Newobject206["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject206["HorizSizing"] = "left";
            oc_Newobject206["VertSizing"] = "bottom";
            oc_Newobject206["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject206["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject206["MinExtent"] = "8 2";
            oc_Newobject206["canSave"] = "1";
            oc_Newobject206["Visible"] = "1";
            oc_Newobject206["Command"] = "";
            oc_Newobject206["hovertime"] = "1000";
            oc_Newobject206["range"] = "0 50";
            oc_Newobject206["ticks"] = "0";
            oc_Newobject206["value"] = "0";
            oc_Newobject206["Command"] = "PE_ParticleEditor.updateParticle( \\\"sizes[1]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject206["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[1]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject208["#Newobject206"] = oc_Newobject206;

            #region GuiTextEditCtrl ()        oc_Newobject207

            ObjectCreator oc_Newobject207 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject207["internalName"] = "PEP_pointSize_textEdit1";
            oc_Newobject207["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject207["HorizSizing"] = "left";
            oc_Newobject207["VertSizing"] = "bottom";
            oc_Newobject207["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject207["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject207["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[1]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject208["#Newobject207"] = oc_Newobject207;

            #endregion

            oc_Newobject235["#Newobject208"] = oc_Newobject208;

            #region GuiControl ()        oc_Newobject212

            ObjectCreator oc_Newobject212 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject212["class"] = "AggregateControl";
            oc_Newobject212["isContainer"] = "1";
            oc_Newobject212["HorizSizing"] = "width";
            oc_Newobject212["VertSizing"] = "bottom";
            oc_Newobject212["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject212["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject209

            ObjectCreator oc_Newobject209 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject209["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject209["HorizSizing"] = "width";
            oc_Newobject209["VertSizing"] = "bottom";
            oc_Newobject209["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject209["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject209["text"] = "Size 3";

            #endregion

            oc_Newobject212["#Newobject209"] = oc_Newobject209;

            #region GuiSliderCtrl ()        oc_Newobject210

            ObjectCreator oc_Newobject210 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject210["internalName"] = "PEP_pointSize_slider2";
            oc_Newobject210["canSaveDynamicFields"] = "0";
            oc_Newobject210["Enabled"] = "1";
            oc_Newobject210["isContainer"] = "0";
            oc_Newobject210["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject210["HorizSizing"] = "left";
            oc_Newobject210["VertSizing"] = "bottom";
            oc_Newobject210["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject210["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject210["MinExtent"] = "8 2";
            oc_Newobject210["canSave"] = "1";
            oc_Newobject210["Visible"] = "1";
            oc_Newobject210["Command"] = "";
            oc_Newobject210["hovertime"] = "1000";
            oc_Newobject210["range"] = "0 50";
            oc_Newobject210["ticks"] = "0";
            oc_Newobject210["value"] = "0";
            oc_Newobject210["Command"] = "PE_ParticleEditor.updateParticle( \\\"sizes[2]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject210["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[2]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject212["#Newobject210"] = oc_Newobject210;

            #region GuiTextEditCtrl ()        oc_Newobject211

            ObjectCreator oc_Newobject211 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject211["internalName"] = "PEP_pointSize_textEdit2";
            oc_Newobject211["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject211["HorizSizing"] = "left";
            oc_Newobject211["VertSizing"] = "bottom";
            oc_Newobject211["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject211["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject211["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[2]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject212["#Newobject211"] = oc_Newobject211;

            #endregion

            oc_Newobject235["#Newobject212"] = oc_Newobject212;

            #region GuiControl ()        oc_Newobject216

            ObjectCreator oc_Newobject216 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject216["class"] = "AggregateControl";
            oc_Newobject216["isContainer"] = "1";
            oc_Newobject216["HorizSizing"] = "width";
            oc_Newobject216["VertSizing"] = "bottom";
            oc_Newobject216["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject216["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject213

            ObjectCreator oc_Newobject213 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject213["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject213["HorizSizing"] = "width";
            oc_Newobject213["VertSizing"] = "bottom";
            oc_Newobject213["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject213["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject213["text"] = "Size 4";

            #endregion

            oc_Newobject216["#Newobject213"] = oc_Newobject213;

            #region GuiSliderCtrl ()        oc_Newobject214

            ObjectCreator oc_Newobject214 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject214["internalName"] = "PEP_pointSize_slider3";
            oc_Newobject214["canSaveDynamicFields"] = "0";
            oc_Newobject214["Enabled"] = "1";
            oc_Newobject214["isContainer"] = "0";
            oc_Newobject214["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject214["HorizSizing"] = "left";
            oc_Newobject214["VertSizing"] = "bottom";
            oc_Newobject214["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject214["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject214["MinExtent"] = "8 2";
            oc_Newobject214["canSave"] = "1";
            oc_Newobject214["Visible"] = "1";
            oc_Newobject214["Command"] = "";
            oc_Newobject214["hovertime"] = "1000";
            oc_Newobject214["range"] = "0 50";
            oc_Newobject214["ticks"] = "0";
            oc_Newobject214["value"] = "0";
            oc_Newobject214["Command"] = "PE_ParticleEditor.updateParticle( \\\"sizes[3]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject214["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[3]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject216["#Newobject214"] = oc_Newobject214;

            #region GuiTextEditCtrl ()        oc_Newobject215

            ObjectCreator oc_Newobject215 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject215["internalName"] = "PEP_pointSize_textEdit3";
            oc_Newobject215["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject215["HorizSizing"] = "left";
            oc_Newobject215["VertSizing"] = "bottom";
            oc_Newobject215["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject215["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject215["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"sizes[3]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject216["#Newobject215"] = oc_Newobject215;

            #endregion

            oc_Newobject235["#Newobject216"] = oc_Newobject216;

            #region GuiControl ()        oc_Newobject218

            ObjectCreator oc_Newobject218 = new ObjectCreator("GuiControl", "");
            oc_Newobject218["isContainer"] = "1";
            oc_Newobject218["HorizSizing"] = "width";
            oc_Newobject218["Position"] = "0 0";
            oc_Newobject218["Extent"] = "194 8";

            #region GuiBitmapCtrl ()        oc_Newobject217

            ObjectCreator oc_Newobject217 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject217["position"] = "0 3";
            oc_Newobject217["extent"] = "188 2";
            oc_Newobject217["HorizSizing"] = "width";
            oc_Newobject217["bitmap"] = "tools/gui/images/separator-v";

            #endregion

            oc_Newobject218["#Newobject217"] = oc_Newobject217;

            #endregion

            oc_Newobject235["#Newobject218"] = oc_Newobject218;

            #region GuiControl ()        oc_Newobject222

            ObjectCreator oc_Newobject222 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject222["class"] = "AggregateControl";
            oc_Newobject222["isContainer"] = "1";
            oc_Newobject222["HorizSizing"] = "width";
            oc_Newobject222["VertSizing"] = "bottom";
            oc_Newobject222["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject222["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject219

            ObjectCreator oc_Newobject219 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject219["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject219["HorizSizing"] = "width";
            oc_Newobject219["VertSizing"] = "bottom";
            oc_Newobject219["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject219["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject219["text"] = "Time 1";

            #endregion

            oc_Newobject222["#Newobject219"] = oc_Newobject219;

            #region GuiSliderCtrl ()        oc_Newobject220

            ObjectCreator oc_Newobject220 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject220["internalName"] = "PEP_pointTime_slider0";
            oc_Newobject220["canSaveDynamicFields"] = "0";
            oc_Newobject220["Enabled"] = "1";
            oc_Newobject220["isContainer"] = "0";
            oc_Newobject220["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject220["HorizSizing"] = "left";
            oc_Newobject220["VertSizing"] = "bottom";
            oc_Newobject220["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject220["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject220["MinExtent"] = "8 2";
            oc_Newobject220["canSave"] = "1";
            oc_Newobject220["Visible"] = "1";
            oc_Newobject220["Command"] = "";
            oc_Newobject220["hovertime"] = "1000";
            oc_Newobject220["range"] = "0 1";
            oc_Newobject220["ticks"] = "0";
            oc_Newobject220["value"] = "0";
            oc_Newobject220["Command"] = "PE_ParticleEditor.updateParticle( \\\"times[0]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject220["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[0]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject222["#Newobject220"] = oc_Newobject220;

            #region GuiTextEditCtrl ()        oc_Newobject221

            ObjectCreator oc_Newobject221 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject221["internalName"] = "PEP_pointTime_textEdit0";
            oc_Newobject221["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject221["HorizSizing"] = "left";
            oc_Newobject221["VertSizing"] = "bottom";
            oc_Newobject221["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject221["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject221["altCommand"] = "$ThisControl.setText(mClamp( $ThisControl.getValue(), 0.0, 1.0)); $ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[0]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject222["#Newobject221"] = oc_Newobject221;

            #endregion

            oc_Newobject235["#Newobject222"] = oc_Newobject222;

            #region GuiControl ()        oc_Newobject226

            ObjectCreator oc_Newobject226 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject226["class"] = "AggregateControl";
            oc_Newobject226["isContainer"] = "1";
            oc_Newobject226["HorizSizing"] = "width";
            oc_Newobject226["VertSizing"] = "bottom";
            oc_Newobject226["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject226["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject223

            ObjectCreator oc_Newobject223 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject223["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject223["HorizSizing"] = "width";
            oc_Newobject223["VertSizing"] = "bottom";
            oc_Newobject223["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject223["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject223["text"] = "Time 2";

            #endregion

            oc_Newobject226["#Newobject223"] = oc_Newobject223;

            #region GuiSliderCtrl ()        oc_Newobject224

            ObjectCreator oc_Newobject224 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject224["internalName"] = "PEP_pointTime_slider1";
            oc_Newobject224["canSaveDynamicFields"] = "0";
            oc_Newobject224["Enabled"] = "1";
            oc_Newobject224["isContainer"] = "0";
            oc_Newobject224["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject224["HorizSizing"] = "left";
            oc_Newobject224["VertSizing"] = "bottom";
            oc_Newobject224["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject224["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject224["MinExtent"] = "8 2";
            oc_Newobject224["canSave"] = "1";
            oc_Newobject224["Visible"] = "1";
            oc_Newobject224["Command"] = "";
            oc_Newobject224["hovertime"] = "1000";
            oc_Newobject224["range"] = "0 1";
            oc_Newobject224["ticks"] = "0";
            oc_Newobject224["value"] = "0";
            oc_Newobject224["Command"] = "PE_ParticleEditor.updateParticle( \\\"times[1]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject224["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[1]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject226["#Newobject224"] = oc_Newobject224;

            #region GuiTextEditCtrl ()        oc_Newobject225

            ObjectCreator oc_Newobject225 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject225["internalName"] = "PEP_pointTime_textEdit1";
            oc_Newobject225["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject225["HorizSizing"] = "left";
            oc_Newobject225["VertSizing"] = "bottom";
            oc_Newobject225["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject225["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject225["altCommand"] = "$ThisControl.setText(mClamp( $ThisControl.getValue(), 0.0, 1.0)); $ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[1]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject226["#Newobject225"] = oc_Newobject225;

            #endregion

            oc_Newobject235["#Newobject226"] = oc_Newobject226;

            #region GuiControl ()        oc_Newobject230

            ObjectCreator oc_Newobject230 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject230["class"] = "AggregateControl";
            oc_Newobject230["isContainer"] = "1";
            oc_Newobject230["HorizSizing"] = "width";
            oc_Newobject230["VertSizing"] = "bottom";
            oc_Newobject230["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject230["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject227

            ObjectCreator oc_Newobject227 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject227["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject227["HorizSizing"] = "width";
            oc_Newobject227["VertSizing"] = "bottom";
            oc_Newobject227["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject227["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject227["text"] = "Time 3";

            #endregion

            oc_Newobject230["#Newobject227"] = oc_Newobject227;

            #region GuiSliderCtrl ()        oc_Newobject228

            ObjectCreator oc_Newobject228 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject228["internalName"] = "PEP_pointTime_slider2";
            oc_Newobject228["canSaveDynamicFields"] = "0";
            oc_Newobject228["Enabled"] = "1";
            oc_Newobject228["isContainer"] = "0";
            oc_Newobject228["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject228["HorizSizing"] = "left";
            oc_Newobject228["VertSizing"] = "bottom";
            oc_Newobject228["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject228["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject228["MinExtent"] = "8 2";
            oc_Newobject228["canSave"] = "1";
            oc_Newobject228["Visible"] = "1";
            oc_Newobject228["Command"] = "";
            oc_Newobject228["hovertime"] = "1000";
            oc_Newobject228["range"] = "0 1";
            oc_Newobject228["ticks"] = "0";
            oc_Newobject228["value"] = "0";
            oc_Newobject228["Command"] = "PE_ParticleEditor.updateParticle( \\\"times[2]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject228["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[2]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject230["#Newobject228"] = oc_Newobject228;

            #region GuiTextEditCtrl ()        oc_Newobject229

            ObjectCreator oc_Newobject229 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject229["internalName"] = "PEP_pointTime_textEdit2";
            oc_Newobject229["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject229["HorizSizing"] = "left";
            oc_Newobject229["VertSizing"] = "bottom";
            oc_Newobject229["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject229["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject229["altCommand"] = "$ThisControl.setText(mClamp( $ThisControl.getValue(), 0.0, 1.0)); $ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[2]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject230["#Newobject229"] = oc_Newobject229;

            #endregion

            oc_Newobject235["#Newobject230"] = oc_Newobject230;

            #region GuiControl ()        oc_Newobject234

            ObjectCreator oc_Newobject234 = new ObjectCreator("GuiControl", "", typeof (AggregateControl));
            //oc_Newobject234["class"] = "AggregateControl";
            oc_Newobject234["isContainer"] = "1";
            oc_Newobject234["HorizSizing"] = "width";
            oc_Newobject234["VertSizing"] = "bottom";
            oc_Newobject234["Position"] = new Creator.StringNoQuote("$PE_guielement_pos_single_container");
            oc_Newobject234["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_single_container");

            #region GuiTextCtrl ()        oc_Newobject231

            ObjectCreator oc_Newobject231 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject231["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject231["HorizSizing"] = "width";
            oc_Newobject231["VertSizing"] = "bottom";
            oc_Newobject231["position"] = new Creator.StringNoQuote("$PE_guielement_pos_name");
            oc_Newobject231["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_name");
            oc_Newobject231["text"] = "Time 4";

            #endregion

            oc_Newobject234["#Newobject231"] = oc_Newobject231;

            #region GuiSliderCtrl ()        oc_Newobject232

            ObjectCreator oc_Newobject232 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject232["internalName"] = "PEP_pointTime_slider3";
            oc_Newobject232["canSaveDynamicFields"] = "0";
            oc_Newobject232["Enabled"] = "1";
            oc_Newobject232["isContainer"] = "0";
            oc_Newobject232["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject232["HorizSizing"] = "left";
            oc_Newobject232["VertSizing"] = "bottom";
            oc_Newobject232["position"] = new Creator.StringNoQuote("$PE_guielement_pos_slider");
            oc_Newobject232["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_slider");
            oc_Newobject232["MinExtent"] = "8 2";
            oc_Newobject232["canSave"] = "1";
            oc_Newobject232["Visible"] = "1";
            oc_Newobject232["Command"] = "";
            oc_Newobject232["hovertime"] = "1000";
            oc_Newobject232["range"] = "0 1";
            oc_Newobject232["ticks"] = "0";
            oc_Newobject232["value"] = "0";
            oc_Newobject232["Command"] = "PE_ParticleEditor.updateParticle( \\\"times[3]\\\", $ThisControl.getValue(), true, true );";
            oc_Newobject232["altCommand"] = "$ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[3]\\\", $ThisControl.getValue(), true, false );";

            #endregion

            oc_Newobject234["#Newobject232"] = oc_Newobject232;

            #region GuiTextEditCtrl ()        oc_Newobject233

            ObjectCreator oc_Newobject233 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject233["internalName"] = "PEP_pointTime_textEdit3";
            oc_Newobject233["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject233["HorizSizing"] = "left";
            oc_Newobject233["VertSizing"] = "bottom";
            oc_Newobject233["position"] = new Creator.StringNoQuote("$PE_guielement_pos_value");
            oc_Newobject233["Extent"] = new Creator.StringNoQuote("$PE_guielement_ext_value");
            oc_Newobject233["altCommand"] = "$ThisControl.setText(mClamp( $ThisControl.getValue(), 0.0, 1.0)); $ThisControl.getParent().updateFromChild($ThisControl); PE_ParticleEditor.updateParticle( \\\"times[3]\\\", $ThisControl.getText());";

            #endregion

            oc_Newobject234["#Newobject233"] = oc_Newobject233;

            #endregion

            oc_Newobject235["#Newobject234"] = oc_Newobject234;

            #endregion

            oc_Newobject236["#Newobject235"] = oc_Newobject235;

            #endregion

            oc_Newobject237["#Newobject236"] = oc_Newobject236;

            #endregion

            oc_Newobject238["#Newobject237"] = oc_Newobject237;

            #endregion

            oc_Newobject239["#Newobject238"] = oc_Newobject238;

            #endregion

            oc_Newobject240["#Newobject239"] = oc_Newobject239;

            #endregion

            oc_Newobject243["#Newobject240"] = oc_Newobject240;

            #region GuiBitmapButtonCtrl ()        oc_Newobject241

            ObjectCreator oc_Newobject241 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject241["canSaveDynamicFields"] = "0";
            oc_Newobject241["Enabled"] = "1";
            oc_Newobject241["isContainer"] = "0";
            oc_Newobject241["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject241["HorizSizing"] = "left";
            oc_Newobject241["VertSizing"] = "bottom";
            oc_Newobject241["Position"] = "169 25";
            oc_Newobject241["Extent"] = "18 18";
            oc_Newobject241["MinExtent"] = "8 2";
            oc_Newobject241["canSave"] = "1";
            oc_Newobject241["Visible"] = "1";
            oc_Newobject241["Command"] = "ParticleEditor.updateEmitterNode();";
            oc_Newobject241["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject241["ToolTip"] = "Play Particle Effect from Start";
            oc_Newobject241["hovertime"] = "1000";
            oc_Newobject241["bitmap"] = "tools/particleEditor/images/play_btn";
            oc_Newobject241["buttonType"] = "PushButton";
            oc_Newobject241["groupNum"] = "-1";
            oc_Newobject241["text"] = "";
            oc_Newobject241["useMouseEvents"] = "0";

            #endregion

            oc_Newobject243["#Newobject241"] = oc_Newobject241;

            #region GuiBitmapButtonCtrl ()        oc_Newobject242

            ObjectCreator oc_Newobject242 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject242["canSaveDynamicFields"] = "0";
            oc_Newobject242["Enabled"] = "1";
            oc_Newobject242["isContainer"] = "0";
            oc_Newobject242["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject242["HorizSizing"] = "left";
            oc_Newobject242["VertSizing"] = "bottom";
            oc_Newobject242["Position"] = "189 26";
            oc_Newobject242["Extent"] = "16 16";
            oc_Newobject242["MinExtent"] = "8 2";
            oc_Newobject242["canSave"] = "1";
            oc_Newobject242["Visible"] = "1";
            oc_Newobject242["Command"] = "ParticleEditor.resetEmitterNode();";
            oc_Newobject242["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject242["ToolTip"] = "Drops Particle Effect in front of the Camera";
            oc_Newobject242["hovertime"] = "1000";
            oc_Newobject242["bitmap"] = "tools/classIcons/camera";
            oc_Newobject242["buttonType"] = "PushButton";
            oc_Newobject242["groupNum"] = "-1";
            oc_Newobject242["text"] = "";
            oc_Newobject242["useMouseEvents"] = "0";

            #endregion

            oc_Newobject243["#Newobject242"] = oc_Newobject242;

            #endregion

            oc_Newobject243.Create();
        }

        [ConsoleInteraction]
        public void initEditor()
        {
            SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector1 = "PEE_EmitterParticleSelector1";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector2 = "PEE_EmitterParticleSelector2";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector3 = "PEE_EmitterParticleSelector3";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector4 = "PEE_EmitterParticleSelector4";
            GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
            GuiWindowCollapseCtrl PE_Window = "PE_Window";
            ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

            GuiPopUpMenuCtrl PEE_blendType = PE_EmitterEditor.FOT("PEE_blendType");
            GuiTabBookCtrl EditorTabBook = PE_Window.FOT("EditorTabBook");

            Util._echo("Initializing ParticleEmitterData and ParticleData DataBlocks...");

            SingletonCreator object1 = new SingletonCreator("ParticleEmitterData", "PE_EmitterEditor_NotDirtyEmitter");
            object1["particles"] = "DefaultParticle";
            object1.Create();

            SingletonCreator object2 = new SingletonCreator("ParticleData", "PE_ParticleEditor_NotDirtyParticle");
            object2["textureName"] = "art/particles/defaultParticle";
            object2.Create();

            PE_UnlistedEmitters.add("PE_EmitterEditor_NotDirtyEmitter");
            PE_UnlistedEmitters.add("PE_ParticleEditor_NotDirtyParticle");

            PEE_EmitterSelector.clear();
            PEE_EmitterParticleSelector1.clear();
            PEE_EmitterParticleSelector2.clear();
            PEE_EmitterParticleSelector3.clear();
            PEE_EmitterParticleSelector4.clear();

            PEP_ParticleSelector.clear();

            this.createParticleList();

            PEE_EmitterParticleSelector2.add("None", 0);
            PEE_EmitterParticleSelector3.add("None", 0);
            PEE_EmitterParticleSelector4.add("None", 0);

            PEE_EmitterParticleSelector1.sort();
            PEE_EmitterParticleSelector2.sort();
            PEE_EmitterParticleSelector3.sort();
            PEE_EmitterParticleSelector4.sort();

            PEE_blendType.clear();
            PEE_blendType.add("NORMAL", 0);
            PEE_blendType.add("ADDITIVE", 1);
            PEE_blendType.add("SUBTRACTIVE", 2);
            PEE_blendType.add("PREMULTALPHA", 3);

            PEE_EmitterSelector.setFirstSelected();

            EditorTabBook.selectPage(0);
        }

        [ConsoleInteraction]
        public void createParticleList()
        {
            SimGroup DatablockGroup = "DatablockGroup";
            SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
            SimSet PE_UnlistedParticles = "PE_UnlistedParticles";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector1 = "PEE_EmitterParticleSelector1";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector2 = "PEE_EmitterParticleSelector2";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector3 = "PEE_EmitterParticleSelector3";
            GuiPopUpMenuCtrl PEE_EmitterParticleSelector4 = "PEE_EmitterParticleSelector4";
            // This function creates the list of all particles and particle emitters

            int emitterCount = 0;
            int particleCount = 0;

            for (uint i = 0; i < DatablockGroup.getCount(); i++)
                {
                SimObject obj = DatablockGroup.getObject(i);
                if (obj.isMemberOfClass("ParticleEmitterData"))
                    {
                    // Filter out emitters on the PE_UnlistedEmitters list.

                    bool unlistedFound = false;
                    for (uint j = 0; j < PE_UnlistedEmitters.getCount(); j++)
                        {
                        SimObject unlisted = PE_UnlistedEmitters.getObject(j);
                        if (unlisted.getId() == obj.getId())
                            {
                            unlistedFound = true;
                            break;
                            }
                        }

                    if (unlistedFound)
                        continue;

                    // To prevent our default emitters from getting changed,
                    // prevent them from populating the list. Default emitters
                    // should only be used as a template for creating new ones.
                    if (obj.getName() == "DefaultEmitter")
                        continue;

                    PEE_EmitterSelector.add(obj.getName(), obj.getId());
                    emitterCount++;
                    }
                else if (obj.isMemberOfClass("ParticleData"))
                    {
                    bool unlistedFound = false;
                    for (uint k = 0; k < PE_UnlistedParticles.getCount(); k++)
                        {
                        SimObject unlisted = PE_UnlistedParticles.getObject(k);
                        if (unlisted.getId() == obj.getId())
                            {
                            unlistedFound = true;
                            break;
                            }
                        }

                    if (unlistedFound)
                        continue;

                    string name = obj.getName();
                    string id = obj.getId().AsString();

                    if (name == "DefaultParticle")
                        continue;

                    // Add to particle dropdown selectors.

                    PEE_EmitterParticleSelector1.add(name, id.AsInt());
                    PEE_EmitterParticleSelector2.add(name, id.AsInt());
                    PEE_EmitterParticleSelector3.add(name, id.AsInt());
                    PEE_EmitterParticleSelector4.add(name, id.AsInt());

                    particleCount++;
                    }
                }

            PEE_EmitterSelector.sort();
            PEE_EmitterParticleSelector1.sort();
            PEE_EmitterParticleSelector2.sort();
            PEE_EmitterParticleSelector3.sort();
            PEE_EmitterParticleSelector4.sort();

            Util._echo("Found" + ' ' + emitterCount + ' ' + "emitters and" + ' ' + particleCount + ' ' + "particles.");
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void openEmitterPane()
        {
            GuiWindowCollapseCtrl PE_Window = "PE_Window";
            ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

            PE_Window["text"] = "Particle Editor - Emitters";
            PE_EmitterEditor.guiSync();
            this["activeEditor"] = PE_EmitterEditor;

            if (!PE_EmitterEditor["dirty"].AsBool())
                PE_EmitterEditor.setEmitterNotDirty();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void openParticlePane()
        {
            GuiWindowCollapseCtrl PE_Window = "PE_Window";
            ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

            PE_Window["text"] = "Particle Editor - Particles";

            PE_ParticleEditor.guiSync();
            this["activeEditor"] = PE_ParticleEditor;

            if (!PE_ParticleEditor["dirty"].AsBool())
                PE_ParticleEditor.setParticleNotDirty();
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void resetEmitterNode()
        {
            GameConnection ServerConnection = "ServerConnection";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";

            ShapeBase controlObject = ServerConnection.getControlObject();
            string tform = controlObject.getEyeTransform().AsString();
            string vec = Util.VectorNormalize(controlObject.getForwardVector()).AsString();
            vec = Util.VectorScale(vec.AsPoint3F(), 4).AsString();
            tform = Util.setWord(tform, 0, (Util.getWord(tform, 0).AsFloat() + Util.getWord(vec, 0).AsFloat()).AsString());
            tform = Util.setWord(tform, 1, (Util.getWord(tform, 1).AsFloat() + Util.getWord(vec, 1).AsFloat()).AsString());
            tform = Util.setWord(tform, 2, (Util.getWord(tform, 2).AsFloat() + Util.getWord(vec, 2).AsFloat()).AsString());

            if (!sGlobal["$ParticleEditor::emitterNode"].isObject())
                {
                if (!"TestEmitterNodeData".isObject())
                    {
                    DatablockCreator object1 = new DatablockCreator("ParticleEmitterNodeData", "TestEmitterNodeData");
                    object1["timeMultiple"] = "1";
                    object1.Create();
                    }
                ParticleEmitterNodeData TestEmitterNodeData = "TestEmitterNodeData";
                ObjectCreator object2 = new ObjectCreator("ParticleEmitterNode");
                object2["emitter"] = PEE_EmitterSelector.getText();
                object2["velocity"] = 1;
                object2["position"] = Util.getWords(tform, 0, 2);
                object2["rotation"] = Util.getWords(tform, 3, 6);
                object2["datablock"] = TestEmitterNodeData;
                object2["parentGroup"] = new Creator.StringNoQuote("MissionCleanup");

                sGlobal["$ParticleEditor::emitterNode"] = object2.Create().AsString();
                }
            else
                {
                ((ParticleEmitterNode) sGlobal["$ParticleEditor::emitterNode"]).setTransform(tform.AsTransformF());

                SimObject clientObject = ((ParticleEmitterNode) sGlobal["$ParticleEditor::emitterNode"]).getClientObject();
                if (clientObject.isObject())
                    clientObject.call("setTransform", tform);

                this.updateEmitterNode();
                }
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void updateEmitterNode()
        {
            ParticleEmitterEditor.PEE_EmitterSelector_Control PEE_EmitterSelector_Control = "PEE_EmitterSelector_Control";

            GuiPopUpMenuCtrl PopUpMenu = PEE_EmitterSelector_Control.FOT("PopUpMenu");

            if (sGlobal["$ParticleEditor::emitterNode"].isObject())
                {
                int id = PopUpMenu.getSelected();

                SimObject clientObject = ((SimObject) sGlobal["$ParticleEditor::emitterNode"]).call("getClientObject");
                if (clientObject.isObject())
                    clientObject.call("setEmitterDataBlock", id.AsString());
                }
            else
                this.resetEmitterNode();
        }

        // [ConsoleInteraction]
        public T createUndo<T>(string desc)
        {
            Util.pushInstantGroup();

            ObjectCreator actionCreator = new ObjectCreator("UndoScriptAction", "", typeof (T));
            //class = %class;
            //superClass = BaseParticleEdAction;
            actionCreator["actionName"] = desc;

            T action = myReflections.ChangeType<T>(actionCreator.Create());

            Util.popInstantGroup();
            return action;
        }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void submitUndo(UndoScriptAction action)
        {
            editor Editor = "Editor";

            action.addToManager(Editor.getUndoManager());
        }

        //=============================================================================================
        //    PE_TabBook.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<PE_TabBook>))]
        public class PE_TabBook : GuiTabBookCtrl
        {
            [ConsoleInteraction]
            public override void onTabSelected(string text, uint index)
            {
                if (!"ParticleEditor".isObject())
                    return;

                ParticleEditor ParticleEditor = "ParticleEditor";

                if (index == 0)
                    ParticleEditor.openEmitterPane();
                else
                    ParticleEditor.openParticlePane();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PE_TabBook ts, string simobjectid)
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
            public static bool operator !=(PE_TabBook ts, string simobjectid)
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
            public static implicit operator string(PE_TabBook ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PE_TabBook(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (PE_TabBook) Omni.self.getSimObject(simobjectid, typeof (PE_TabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PE_TabBook ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PE_TabBook(int simobjectid)
            {
                return (PE_TabBook) Omni.self.getSimObject((uint) simobjectid, typeof (PE_TabBook));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PE_TabBook ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PE_TabBook(uint simobjectid)
            {
                return (PE_TabBook) Omni.self.getSimObject(simobjectid, typeof (PE_TabBook));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<PE_Window>))]
        public class PE_Window : GuiWindowCollapseCtrl
        {
            [ConsoleInteraction]
            public override void onPopWindow()
            {
                ParticleEditorPlugin ParticleEditorPlugin = "ParticleEditorPlugin";

                EditorGui.DeactivateAll();
                ParticleEditorPlugin.onActivated();
            }

            [ConsoleInteraction]
            public override void onPopWindowClosed()
            {
                ParticleEditorPlugin ParticleEditorPlugin = "ParticleEditorPlugin";

                EditorGui.DeactivateAll();
                ParticleEditorPlugin.onActivated();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PE_Window ts, string simobjectid)
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
            public static bool operator !=(PE_Window ts, string simobjectid)
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
            public static implicit operator string(PE_Window ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PE_Window(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (PE_Window) Omni.self.getSimObject(simobjectid, typeof (PE_Window));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PE_Window ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PE_Window(int simobjectid)
            {
                return (PE_Window) Omni.self.getSimObject((uint) simobjectid, typeof (PE_Window));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PE_Window ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PE_Window(uint simobjectid)
            {
                return (PE_Window) Omni.self.getSimObject(simobjectid, typeof (PE_Window));
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
        public static bool operator ==(ParticleEditor ts, string simobjectid)
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
        public static bool operator !=(ParticleEditor ts, string simobjectid)
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
        public static implicit operator string(ParticleEditor ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ParticleEditor(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ParticleEditor) Omni.self.getSimObject(simobjectid, typeof (ParticleEditor));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ParticleEditor ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleEditor(int simobjectid)
        {
            return (ParticleEditor) Omni.self.getSimObject((uint) simobjectid, typeof (ParticleEditor));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ParticleEditor ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleEditor(uint simobjectid)
        {
            return (ParticleEditor) Omni.self.getSimObject(simobjectid, typeof (ParticleEditor));
        }

        #endregion
    }
}