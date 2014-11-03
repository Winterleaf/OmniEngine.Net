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

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class ProceduralTerrainPainterGui
    {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "ProceduralTerrainPainterGui_initialize")]
        public static void initialize()
        {
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

            #region GuiControl (ProceduralTerrainPainterGui)        oc_Newobject00016
            oc_Newobject00016 = new ObjectCreator("GuiControl", "ProceduralTerrainPainterGui");
            oc_Newobject00016["canSaveDynamicFields"] = "0";
            oc_Newobject00016["isContainer"] = "1";
            oc_Newobject00016["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject00016["HorizSizing"] = "right";
            oc_Newobject00016["VertSizing"] = "bottom";
            oc_Newobject00016["Position"] = "0 0";
            oc_Newobject00016["Extent"] = "1024 768";
            oc_Newobject00016["MinExtent"] = "8 2";
            oc_Newobject00016["canSave"] = "1";
            oc_Newobject00016["Visible"] = "1";
            oc_Newobject00016["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject00016["hovertime"] = "1000";
            if (true)
                {

                #region GuiWindowCtrl (ProceduralTerrainPainterDescription)        oc_Newobject00015
                oc_Newobject00015 = new ObjectCreator("GuiWindowCtrl", "ProceduralTerrainPainterDescription");
                oc_Newobject00015["canSaveDynamicFields"] = "0";
                oc_Newobject00015["isContainer"] = "1";
                oc_Newobject00015["Profile"] = "ToolsGuiWindowProfile";
                oc_Newobject00015["HorizSizing"] = "right";
                oc_Newobject00015["VertSizing"] = "bottom";
                oc_Newobject00015["Position"] = "285 83";
                oc_Newobject00015["Extent"] = "175 233";
                oc_Newobject00015["MinExtent"] = "8 2";
                oc_Newobject00015["canSave"] = "1";
                oc_Newobject00015["Visible"] = "1";
                oc_Newobject00015["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc_Newobject00015["hovertime"] = "1000";
                oc_Newobject00015["Margin"] = "0 0 0 0";
                oc_Newobject00015["Padding"] = "0 0 0 0";
                oc_Newobject00015["AnchorTop"] = "1";
                oc_Newobject00015["AnchorBottom"] = "0";
                oc_Newobject00015["AnchorLeft"] = "1";
                oc_Newobject00015["AnchorRight"] = "0";
                oc_Newobject00015["resizeWidth"] = "0";
                oc_Newobject00015["resizeHeight"] = "0";
                oc_Newobject00015["canMove"] = "1";
                oc_Newobject00015["canClose"] = "1";
                oc_Newobject00015["canMinimize"] = "0";
                oc_Newobject00015["canMaximize"] = "0";
                oc_Newobject00015["minSize"] = "50 50";
                oc_Newobject00015["EdgeSnap"] = "1";
                oc_Newobject00015["canCollapse"] = "0";
                oc_Newobject00015["CollapseGroup"] = "-1";
                oc_Newobject00015["CollapseGroupNum"] = "-1";
                oc_Newobject00015["closeCommand"] = "Canvas.popDialog(ProceduralTerrainPainterGui);";
                oc_Newobject00015["text"] = "Generate layer mask";
                if (true)
                    {

                    #region GuiButtonCtrl ()        oc_Newobject00001
                    oc_Newobject00001 = new ObjectCreator("GuiButtonCtrl", "");
                    oc_Newobject00001["canSaveDynamicFields"] = "0";
                    oc_Newobject00001["isContainer"] = "0";
                    oc_Newobject00001["Profile"] = "ToolsGuiButtonProfile";
                    oc_Newobject00001["HorizSizing"] = "right";
                    oc_Newobject00001["VertSizing"] = "bottom";
                    oc_Newobject00001["Position"] = "19 193";
                    oc_Newobject00001["Extent"] = "140 30";
                    oc_Newobject00001["MinExtent"] = "8 2";
                    oc_Newobject00001["canSave"] = "1";
                    oc_Newobject00001["Visible"] = "1";
                    oc_Newobject00001["Command"] = "generateProceduralTerrainMask();";
                    oc_Newobject00001["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00001["hovertime"] = "1000";
                    oc_Newobject00001["text"] = "Generate";
                    oc_Newobject00001["groupNum"] = "-1";
                    oc_Newobject00001["buttonType"] = "PushButton";
                    oc_Newobject00001["useMouseEvents"] = "0";
                    #endregion

                    oc_Newobject00015["#Newobject00001"] = oc_Newobject00001;

                    #region GuiTextCtrl ()        oc_Newobject00002
                    oc_Newobject00002 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00002["canSaveDynamicFields"] = "0";
                    oc_Newobject00002["isContainer"] = "0";
                    oc_Newobject00002["Profile"] = "GuiTextProfile";
                    oc_Newobject00002["HorizSizing"] = "right";
                    oc_Newobject00002["VertSizing"] = "bottom";
                    oc_Newobject00002["Position"] = "15 37";
                    oc_Newobject00002["Extent"] = "33 13";
                    oc_Newobject00002["MinExtent"] = "8 2";
                    oc_Newobject00002["canSave"] = "1";
                    oc_Newobject00002["Visible"] = "1";
                    oc_Newobject00002["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00002["hovertime"] = "1000";
                    oc_Newobject00002["Margin"] = "0 0 0 0";
                    oc_Newobject00002["Padding"] = "0 0 0 0";
                    oc_Newobject00002["AnchorTop"] = "1";
                    oc_Newobject00002["AnchorBottom"] = "0";
                    oc_Newobject00002["AnchorLeft"] = "1";
                    oc_Newobject00002["AnchorRight"] = "0";
                    oc_Newobject00002["text"] = "HEIGHT";
                    oc_Newobject00002["maxLength"] = "1024";
                    #endregion

                    oc_Newobject00015["#Newobject00002"] = oc_Newobject00002;

                    #region GuiTextCtrl ()        oc_Newobject00003
                    oc_Newobject00003 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00003["canSaveDynamicFields"] = "0";
                    oc_Newobject00003["isContainer"] = "0";
                    oc_Newobject00003["Profile"] = "GuiTextProfile";
                    oc_Newobject00003["HorizSizing"] = "right";
                    oc_Newobject00003["VertSizing"] = "bottom";
                    oc_Newobject00003["Position"] = "59 37";
                    oc_Newobject00003["Extent"] = "23 14";
                    oc_Newobject00003["MinExtent"] = "8 2";
                    oc_Newobject00003["canSave"] = "1";
                    oc_Newobject00003["Visible"] = "1";
                    oc_Newobject00003["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00003["hovertime"] = "1000";
                    oc_Newobject00003["Margin"] = "0 0 0 0";
                    oc_Newobject00003["Padding"] = "0 0 0 0";
                    oc_Newobject00003["AnchorTop"] = "1";
                    oc_Newobject00003["AnchorBottom"] = "0";
                    oc_Newobject00003["AnchorLeft"] = "1";
                    oc_Newobject00003["AnchorRight"] = "0";
                    oc_Newobject00003["text"] = "Min.";
                    oc_Newobject00003["maxLength"] = "1024";
                    #endregion

                    oc_Newobject00015["#Newobject00003"] = oc_Newobject00003;

                    #region GuiTextCtrl ()        oc_Newobject00004
                    oc_Newobject00004 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00004["canSaveDynamicFields"] = "0";
                    oc_Newobject00004["isContainer"] = "0";
                    oc_Newobject00004["Profile"] = "GuiTextProfile";
                    oc_Newobject00004["HorizSizing"] = "right";
                    oc_Newobject00004["VertSizing"] = "bottom";
                    oc_Newobject00004["Position"] = "59 62";
                    oc_Newobject00004["Extent"] = "23 14";
                    oc_Newobject00004["MinExtent"] = "8 2";
                    oc_Newobject00004["canSave"] = "1";
                    oc_Newobject00004["Visible"] = "1";
                    oc_Newobject00004["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00004["hovertime"] = "1000";
                    oc_Newobject00004["Margin"] = "0 0 0 0";
                    oc_Newobject00004["Padding"] = "0 0 0 0";
                    oc_Newobject00004["AnchorTop"] = "1";
                    oc_Newobject00004["AnchorBottom"] = "0";
                    oc_Newobject00004["AnchorLeft"] = "1";
                    oc_Newobject00004["AnchorRight"] = "0";
                    oc_Newobject00004["text"] = "Max.";
                    oc_Newobject00004["maxLength"] = "1024";
                    #endregion

                    oc_Newobject00015["#Newobject00004"] = oc_Newobject00004;

                    #region GuiTextEditCtrl ()        oc_Newobject00005
                    oc_Newobject00005 = new ObjectCreator("GuiTextEditCtrl", "");
                    oc_Newobject00005["canSaveDynamicFields"] = "0";
                    oc_Newobject00005["isContainer"] = "0";
                    oc_Newobject00005["Profile"] = "GuiTextEditProfile";
                    oc_Newobject00005["HorizSizing"] = "right";
                    oc_Newobject00005["VertSizing"] = "bottom";
                    oc_Newobject00005["Position"] = "97 35";
                    oc_Newobject00005["Extent"] = "66 18";
                    oc_Newobject00005["MinExtent"] = "8 2";
                    oc_Newobject00005["canSave"] = "1";
                    oc_Newobject00005["Visible"] = "1";
                    oc_Newobject00005["Variable"] = "$TPPHeightMin";
                    oc_Newobject00005["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00005["hovertime"] = "1000";
                    oc_Newobject00005["Margin"] = "0 0 0 0";
                    oc_Newobject00005["Padding"] = "0 0 0 0";
                    oc_Newobject00005["AnchorTop"] = "1";
                    oc_Newobject00005["AnchorBottom"] = "0";
                    oc_Newobject00005["AnchorLeft"] = "1";
                    oc_Newobject00005["AnchorRight"] = "0";
                    oc_Newobject00005["maxLength"] = "1024";
                    oc_Newobject00005["historySize"] = "0";
                    oc_Newobject00005["password"] = "0";
                    oc_Newobject00005["tabComplete"] = "0";
                    oc_Newobject00005["sinkAllKeyEvents"] = "0";
                    oc_Newobject00005["passwordMask"] = "*";
                    #endregion

                    oc_Newobject00015["#Newobject00005"] = oc_Newobject00005;

                    #region GuiTextEditCtrl ()        oc_Newobject00006
                    oc_Newobject00006 = new ObjectCreator("GuiTextEditCtrl", "");
                    oc_Newobject00006["canSaveDynamicFields"] = "0";
                    oc_Newobject00006["isContainer"] = "0";
                    oc_Newobject00006["Profile"] = "GuiTextEditProfile";
                    oc_Newobject00006["HorizSizing"] = "right";
                    oc_Newobject00006["VertSizing"] = "bottom";
                    oc_Newobject00006["Position"] = "97 60";
                    oc_Newobject00006["Extent"] = "66 18";
                    oc_Newobject00006["MinExtent"] = "8 2";
                    oc_Newobject00006["canSave"] = "1";
                    oc_Newobject00006["Visible"] = "1";
                    oc_Newobject00006["Variable"] = "$TPPHeightMax";
                    oc_Newobject00006["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00006["hovertime"] = "1000";
                    oc_Newobject00006["Margin"] = "0 0 0 0";
                    oc_Newobject00006["Padding"] = "0 0 0 0";
                    oc_Newobject00006["AnchorTop"] = "1";
                    oc_Newobject00006["AnchorBottom"] = "0";
                    oc_Newobject00006["AnchorLeft"] = "1";
                    oc_Newobject00006["AnchorRight"] = "0";
                    oc_Newobject00006["maxLength"] = "1024";
                    oc_Newobject00006["historySize"] = "0";
                    oc_Newobject00006["password"] = "0";
                    oc_Newobject00006["tabComplete"] = "0";
                    oc_Newobject00006["sinkAllKeyEvents"] = "0";
                    oc_Newobject00006["passwordMask"] = "*";
                    #endregion

                    oc_Newobject00015["#Newobject00006"] = oc_Newobject00006;

                    #region GuiTextCtrl ()        oc_Newobject00007
                    oc_Newobject00007 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00007["canSaveDynamicFields"] = "0";
                    oc_Newobject00007["isContainer"] = "0";
                    oc_Newobject00007["Profile"] = "GuiTextProfile";
                    oc_Newobject00007["HorizSizing"] = "right";
                    oc_Newobject00007["VertSizing"] = "bottom";
                    oc_Newobject00007["Position"] = "15 101";
                    oc_Newobject00007["Extent"] = "33 13";
                    oc_Newobject00007["MinExtent"] = "8 2";
                    oc_Newobject00007["canSave"] = "1";
                    oc_Newobject00007["Visible"] = "1";
                    oc_Newobject00007["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00007["hovertime"] = "1000";
                    oc_Newobject00007["Margin"] = "0 0 0 0";
                    oc_Newobject00007["Padding"] = "0 0 0 0";
                    oc_Newobject00007["AnchorTop"] = "1";
                    oc_Newobject00007["AnchorBottom"] = "0";
                    oc_Newobject00007["AnchorLeft"] = "1";
                    oc_Newobject00007["AnchorRight"] = "0";
                    oc_Newobject00007["text"] = "SLOPE";
                    oc_Newobject00007["maxLength"] = "1024";
                    #endregion

                    oc_Newobject00015["#Newobject00007"] = oc_Newobject00007;

                    #region GuiTextCtrl ()        oc_Newobject00008
                    oc_Newobject00008 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00008["canSaveDynamicFields"] = "0";
                    oc_Newobject00008["isContainer"] = "0";
                    oc_Newobject00008["Profile"] = "GuiTextProfile";
                    oc_Newobject00008["HorizSizing"] = "right";
                    oc_Newobject00008["VertSizing"] = "bottom";
                    oc_Newobject00008["Position"] = "59 101";
                    oc_Newobject00008["Extent"] = "23 14";
                    oc_Newobject00008["MinExtent"] = "8 2";
                    oc_Newobject00008["canSave"] = "1";
                    oc_Newobject00008["Visible"] = "1";
                    oc_Newobject00008["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00008["hovertime"] = "1000";
                    oc_Newobject00008["Margin"] = "0 0 0 0";
                    oc_Newobject00008["Padding"] = "0 0 0 0";
                    oc_Newobject00008["AnchorTop"] = "1";
                    oc_Newobject00008["AnchorBottom"] = "0";
                    oc_Newobject00008["AnchorLeft"] = "1";
                    oc_Newobject00008["AnchorRight"] = "0";
                    oc_Newobject00008["text"] = "Min.";
                    oc_Newobject00008["maxLength"] = "1024";
                    #endregion

                    oc_Newobject00015["#Newobject00008"] = oc_Newobject00008;

                    #region GuiTextCtrl ()        oc_Newobject00009
                    oc_Newobject00009 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00009["canSaveDynamicFields"] = "0";
                    oc_Newobject00009["isContainer"] = "0";
                    oc_Newobject00009["Profile"] = "ToolsGuiTextProfile";
                    oc_Newobject00009["HorizSizing"] = "right";
                    oc_Newobject00009["VertSizing"] = "bottom";
                    oc_Newobject00009["Position"] = "59 126";
                    oc_Newobject00009["Extent"] = "23 14";
                    oc_Newobject00009["MinExtent"] = "8 2";
                    oc_Newobject00009["canSave"] = "1";
                    oc_Newobject00009["Visible"] = "1";
                    oc_Newobject00009["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00009["hovertime"] = "1000";
                    oc_Newobject00009["Margin"] = "0 0 0 0";
                    oc_Newobject00009["Padding"] = "0 0 0 0";
                    oc_Newobject00009["AnchorTop"] = "1";
                    oc_Newobject00009["AnchorBottom"] = "0";
                    oc_Newobject00009["AnchorLeft"] = "1";
                    oc_Newobject00009["AnchorRight"] = "0";
                    oc_Newobject00009["text"] = "Max.";
                    oc_Newobject00009["maxLength"] = "1024";
                    #endregion

                    oc_Newobject00015["#Newobject00009"] = oc_Newobject00009;

                    #region GuiTextEditCtrl ()        oc_Newobject00010
                    oc_Newobject00010 = new ObjectCreator("GuiTextEditCtrl", "");
                    oc_Newobject00010["canSaveDynamicFields"] = "0";
                    oc_Newobject00010["isContainer"] = "0";
                    oc_Newobject00010["Profile"] = "ToolsGuiTextEditProfile";
                    oc_Newobject00010["HorizSizing"] = "right";
                    oc_Newobject00010["VertSizing"] = "bottom";
                    oc_Newobject00010["Position"] = "97 99";
                    oc_Newobject00010["Extent"] = "66 18";
                    oc_Newobject00010["MinExtent"] = "8 2";
                    oc_Newobject00010["canSave"] = "1";
                    oc_Newobject00010["Visible"] = "1";
                    oc_Newobject00010["Variable"] = "$TPPSlopeMin";
                    oc_Newobject00010["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00010["hovertime"] = "1000";
                    oc_Newobject00010["Margin"] = "0 0 0 0";
                    oc_Newobject00010["Padding"] = "0 0 0 0";
                    oc_Newobject00010["AnchorTop"] = "1";
                    oc_Newobject00010["AnchorBottom"] = "0";
                    oc_Newobject00010["AnchorLeft"] = "1";
                    oc_Newobject00010["AnchorRight"] = "0";
                    oc_Newobject00010["maxLength"] = "1024";
                    oc_Newobject00010["historySize"] = "0";
                    oc_Newobject00010["password"] = "0";
                    oc_Newobject00010["tabComplete"] = "0";
                    oc_Newobject00010["sinkAllKeyEvents"] = "0";
                    oc_Newobject00010["passwordMask"] = "*";
                    #endregion

                    oc_Newobject00015["#Newobject00010"] = oc_Newobject00010;

                    #region GuiTextEditCtrl ()        oc_Newobject00011
                    oc_Newobject00011 = new ObjectCreator("GuiTextEditCtrl", "");
                    oc_Newobject00011["canSaveDynamicFields"] = "0";
                    oc_Newobject00011["isContainer"] = "0";
                    oc_Newobject00011["Profile"] = "ToolsGuiTextEditProfile";
                    oc_Newobject00011["HorizSizing"] = "right";
                    oc_Newobject00011["VertSizing"] = "bottom";
                    oc_Newobject00011["Position"] = "97 124";
                    oc_Newobject00011["Extent"] = "66 18";
                    oc_Newobject00011["MinExtent"] = "8 2";
                    oc_Newobject00011["canSave"] = "1";
                    oc_Newobject00011["Visible"] = "1";
                    oc_Newobject00011["Variable"] = "$TPPSlopeMax";
                    oc_Newobject00011["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00011["hovertime"] = "1000";
                    oc_Newobject00011["Margin"] = "0 0 0 0";
                    oc_Newobject00011["Padding"] = "0 0 0 0";
                    oc_Newobject00011["AnchorTop"] = "1";
                    oc_Newobject00011["AnchorBottom"] = "0";
                    oc_Newobject00011["AnchorLeft"] = "1";
                    oc_Newobject00011["AnchorRight"] = "0";
                    oc_Newobject00011["maxLength"] = "1024";
                    oc_Newobject00011["historySize"] = "0";
                    oc_Newobject00011["password"] = "0";
                    oc_Newobject00011["tabComplete"] = "0";
                    oc_Newobject00011["sinkAllKeyEvents"] = "0";
                    oc_Newobject00011["passwordMask"] = "*";
                    #endregion

                    oc_Newobject00015["#Newobject00011"] = oc_Newobject00011;

                    #region GuiTextCtrl ()        oc_Newobject00012
                    oc_Newobject00012 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00012["text"] = "COVERAGE";
                    oc_Newobject00012["maxLength"] = "1024";
                    oc_Newobject00012["margin"] = "0 0 0 0";
                    oc_Newobject00012["padding"] = "0 0 0 0";
                    oc_Newobject00012["anchorTop"] = "1";
                    oc_Newobject00012["anchorBottom"] = "0";
                    oc_Newobject00012["anchorLeft"] = "1";
                    oc_Newobject00012["anchorRight"] = "0";
                    oc_Newobject00012["position"] = "10 165";
                    oc_Newobject00012["extent"] = "55 13";
                    oc_Newobject00012["minExtent"] = "8 2";
                    oc_Newobject00012["horizSizing"] = "right";
                    oc_Newobject00012["vertSizing"] = "bottom";
                    oc_Newobject00012["profile"] = "GuiTextProfile";
                    oc_Newobject00012["visible"] = "1";
                    oc_Newobject00012["active"] = "1";
                    oc_Newobject00012["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00012["hovertime"] = "1000";
                    oc_Newobject00012["isContainer"] = "0";
                    oc_Newobject00012["canSave"] = "1";
                    oc_Newobject00012["canSaveDynamicFields"] = "0";
                    #endregion

                    oc_Newobject00015["#Newobject00012"] = oc_Newobject00012;

                    #region GuiTextEditCtrl ()        oc_Newobject00013
                    oc_Newobject00013 = new ObjectCreator("GuiTextEditCtrl", "");
                    oc_Newobject00013["historySize"] = "0";
                    oc_Newobject00013["tabComplete"] = "0";
                    oc_Newobject00013["sinkAllKeyEvents"] = "0";
                    oc_Newobject00013["password"] = "0";
                    oc_Newobject00013["passwordMask"] = "*";
                    oc_Newobject00013["text"] = "1";
                    oc_Newobject00013["maxLength"] = "1024";
                    oc_Newobject00013["margin"] = "0 0 0 0";
                    oc_Newobject00013["padding"] = "0 0 0 0";
                    oc_Newobject00013["anchorTop"] = "1";
                    oc_Newobject00013["anchorBottom"] = "0";
                    oc_Newobject00013["anchorLeft"] = "1";
                    oc_Newobject00013["anchorRight"] = "0";
                    oc_Newobject00013["position"] = "97 162";
                    oc_Newobject00013["extent"] = "66 18";
                    oc_Newobject00013["minExtent"] = "8 2";
                    oc_Newobject00013["horizSizing"] = "right";
                    oc_Newobject00013["vertSizing"] = "bottom";
                    oc_Newobject00013["profile"] = "GuiTextEditProfile";
                    oc_Newobject00013["visible"] = "1";
                    oc_Newobject00013["active"] = "1";
                    oc_Newobject00013["variable"] = "$TPPCoverage";
                    oc_Newobject00013["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00013["hovertime"] = "1000";
                    oc_Newobject00013["isContainer"] = "0";
                    oc_Newobject00013["canSave"] = "1";
                    oc_Newobject00013["canSaveDynamicFields"] = "0";
                    #endregion

                    oc_Newobject00015["#Newobject00013"] = oc_Newobject00013;

                    #region GuiTextCtrl ()        oc_Newobject00014
                    oc_Newobject00014 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00014["text"] = "%";
                    oc_Newobject00014["maxLength"] = "1024";
                    oc_Newobject00014["margin"] = "0 0 0 0";
                    oc_Newobject00014["padding"] = "0 0 0 0";
                    oc_Newobject00014["anchorTop"] = "1";
                    oc_Newobject00014["anchorBottom"] = "0";
                    oc_Newobject00014["anchorLeft"] = "1";
                    oc_Newobject00014["anchorRight"] = "0";
                    oc_Newobject00014["position"] = "77 164";
                    oc_Newobject00014["extent"] = "11 14";
                    oc_Newobject00014["minExtent"] = "8 2";
                    oc_Newobject00014["horizSizing"] = "right";
                    oc_Newobject00014["vertSizing"] = "bottom";
                    oc_Newobject00014["profile"] = "ToolsGuiTextProfile";
                    oc_Newobject00014["visible"] = "1";
                    oc_Newobject00014["active"] = "1";
                    oc_Newobject00014["tooltipProfile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject00014["hovertime"] = "1000";
                    oc_Newobject00014["isContainer"] = "0";
                    oc_Newobject00014["canSave"] = "1";
                    oc_Newobject00014["canSaveDynamicFields"] = "0";
                    #endregion

                    oc_Newobject00015["#Newobject00014"] = oc_Newobject00014;

                    }
                #endregion

                oc_Newobject00016["#Newobject00015"] = oc_Newobject00015;

                }
            #endregion
            oc_Newobject00016.Create();

            }

            omni.iGlobal["$TPPHeightMin"] = -10000;
            omni.iGlobal["$TPPHeightMax"] = 10000;
            omni.iGlobal["$TPPSlopeMin"] = 0;
            omni.iGlobal["$TPPSlopeMax"] = 90;
            omni.iGlobal["$TPPCoverage"] = 100;

        }

        [ConsoleInteraction]
        public static void autoLayers()
        {
            ((GuiCanvas) "Canvas").pushDialog("ProceduralTerrainPainterGui");
        }

        [ConsoleInteraction]
        public static void generateProceduralTerrainMask()
        {
            ((GuiCanvas) "Canvas").popDialog("ProceduralTerrainPainterGui");
            ((TerrainEditor) "ETerrainEditor").autoMaterialLayer(omni.fGlobal["$TPPHeightMin"],
                omni.fGlobal["$TPPHeightMax"], omni.fGlobal["$TPPSlopeMin"], omni.fGlobal["$TPPSlopeMax"], omni.fGlobal["$TPPCoverage"]);
        }
    }
}