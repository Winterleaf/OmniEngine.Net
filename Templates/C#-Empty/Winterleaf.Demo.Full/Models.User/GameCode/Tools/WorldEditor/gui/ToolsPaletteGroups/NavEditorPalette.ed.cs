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

using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
{
    public class NavEditorPalette
    {
        public static uint initialize()
        {
            ObjectCreator oc_Newobject00006;
            ObjectCreator oc_Newobject00005;
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
                {
                #region GuiControl (NavEditorPalette,EditorGuiGroup)        oc_Newobject00006

                oc_Newobject00006 = new ObjectCreator("GuiControl", "NavEditorPalette,EditorGuiGroup");
                oc_Newobject00006["canSaveDynamicFields"] = "0";
                oc_Newobject00006["Enabled"] = "1";
                oc_Newobject00006["isContainer"] = "1";
                oc_Newobject00006["Profile"] = "GuiDefaultProfile";
                oc_Newobject00006["HorizSizing"] = "right";
                oc_Newobject00006["VertSizing"] = "bottom";
                oc_Newobject00006["Position"] = "0 0";
                oc_Newobject00006["Extent"] = "1024 768";
                oc_Newobject00006["MinExtent"] = "8 2";
                oc_Newobject00006["canSave"] = "1";
                oc_Newobject00006["Visible"] = "1";
                oc_Newobject00006["hovertime"] = "1000";
                if (true)
                    {
                    #region GuiBitmapButtonCtrl (ENavEditorSelectModeBtn)        oc_Newobject00001

                    oc_Newobject00001 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorSelectModeBtn", typeof (ENavEditorPaletteButton));
                    oc_Newobject00001["canSaveDynamicFields"] = "1";
                    //oc_Newobject00001["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00001["internalName"] = "NavEditorSelectMode";
                    oc_Newobject00001["Enabled"] = "1";
                    oc_Newobject00001["isContainer"] = "0";
                    oc_Newobject00001["Profile"] = "GuiButtonProfile";
                    oc_Newobject00001["HorizSizing"] = "right";
                    oc_Newobject00001["VertSizing"] = "bottom";
                    oc_Newobject00001["Position"] = "0 0";
                    oc_Newobject00001["Extent"] = "25 19";
                    oc_Newobject00001["MinExtent"] = "8 2";
                    oc_Newobject00001["canSave"] = "1";
                    oc_Newobject00001["Visible"] = "1";
                    oc_Newobject00001["Command"] = "NavEditorGui.prepSelectionMode();";
                    oc_Newobject00001["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00001["ToolTip"] = "View NavMesh (1).";
                    oc_Newobject00001["DetailedDesc"] = "";
                    oc_Newobject00001["hovertime"] = "1000";
                    oc_Newobject00001["bitmap"] = "tools/gui/images/menubar/visibility-toggle";
                    oc_Newobject00001["buttonType"] = "RadioButton";
                    oc_Newobject00001["useMouseEvents"] = "0";

                    #endregion

                    oc_Newobject00006["#Newobject00001"] = oc_Newobject00001;

                    #region GuiBitmapButtonCtrl (ENavEditorLinkModeBtn)        oc_Newobject00002

                    oc_Newobject00002 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorLinkModeBtn", typeof (ENavEditorPaletteButton));
                    oc_Newobject00002["canSaveDynamicFields"] = "1";
                    //oc_Newobject00002["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00002["internalName"] = "NavEditorLinkMode";
                    oc_Newobject00002["Enabled"] = "1";
                    oc_Newobject00002["isContainer"] = "0";
                    oc_Newobject00002["Profile"] = "GuiButtonProfile";
                    oc_Newobject00002["HorizSizing"] = "right";
                    oc_Newobject00002["VertSizing"] = "bottom";
                    oc_Newobject00002["Position"] = "0 0";
                    oc_Newobject00002["Extent"] = "25 19";
                    oc_Newobject00002["MinExtent"] = "8 2";
                    oc_Newobject00002["canSave"] = "1";
                    oc_Newobject00002["Visible"] = "1";
                    oc_Newobject00002["Command"] = "NavEditorGui.setMode(\\\"LinkMode\\\");";
                    oc_Newobject00002["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00002["ToolTip"] = "Create off-mesh links (2).";
                    oc_Newobject00002["DetailedDesc"] = "Click to select/add. Shift-click to add multiple end points.";
                    oc_Newobject00002["hovertime"] = "1000";
                    oc_Newobject00002["bitmap"] = "tools/navEditor/images/nav-link";
                    oc_Newobject00002["buttonType"] = "RadioButton";
                    oc_Newobject00002["useMouseEvents"] = "0";

                    #endregion

                    oc_Newobject00006["#Newobject00002"] = oc_Newobject00002;

                    #region GuiBitmapButtonCtrl (ENavEditorCoverModeBtn)        oc_Newobject00003

                    oc_Newobject00003 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorCoverModeBtn", typeof (ENavEditorPaletteButton));
                    oc_Newobject00003["canSaveDynamicFields"] = "1";
                    //oc_Newobject00003["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00003["internalName"] = "NavEditorCoverMode";
                    oc_Newobject00003["Enabled"] = "1";
                    oc_Newobject00003["isContainer"] = "0";
                    oc_Newobject00003["Profile"] = "GuiButtonProfile";
                    oc_Newobject00003["HorizSizing"] = "right";
                    oc_Newobject00003["VertSizing"] = "bottom";
                    oc_Newobject00003["Position"] = "0 0";
                    oc_Newobject00003["Extent"] = "25 19";
                    oc_Newobject00003["MinExtent"] = "8 2";
                    oc_Newobject00003["canSave"] = "1";
                    oc_Newobject00003["Visible"] = "1";
                    oc_Newobject00003["Command"] = "NavEditorGui.setMode(\\\"CoverMode\\\");";
                    oc_Newobject00003["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00003["ToolTip"] = "Edit cover (3).";
                    oc_Newobject00003["DetailedDesc"] = "";
                    oc_Newobject00003["hovertime"] = "1000";
                    oc_Newobject00003["bitmap"] = "tools/navEditor/images/nav-cover";
                    oc_Newobject00003["buttonType"] = "RadioButton";
                    oc_Newobject00003["useMouseEvents"] = "0";

                    #endregion

                    oc_Newobject00006["#Newobject00003"] = oc_Newobject00003;

                    #region GuiBitmapButtonCtrl (ENavEditorTileModeBtn)        oc_Newobject00004

                    oc_Newobject00004 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorTileModeBtn", typeof (ENavEditorPaletteButton));
                    oc_Newobject00004["canSaveDynamicFields"] = "1";
                    //oc_Newobject00004["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00004["internalName"] = "NavEditorTileMode";
                    oc_Newobject00004["Enabled"] = "1";
                    oc_Newobject00004["isContainer"] = "0";
                    oc_Newobject00004["Profile"] = "GuiButtonProfile";
                    oc_Newobject00004["HorizSizing"] = "right";
                    oc_Newobject00004["VertSizing"] = "bottom";
                    oc_Newobject00004["Position"] = "0 0";
                    oc_Newobject00004["Extent"] = "25 19";
                    oc_Newobject00004["MinExtent"] = "8 2";
                    oc_Newobject00004["canSave"] = "1";
                    oc_Newobject00004["Visible"] = "1";
                    oc_Newobject00004["Command"] = "NavEditorGui.setMode(\\\"TileMode\\\");";
                    oc_Newobject00004["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00004["ToolTip"] = "View tiles (4).";
                    oc_Newobject00004["DetailedDesc"] = "Click to select.";
                    oc_Newobject00004["hovertime"] = "1000";
                    oc_Newobject00004["bitmap"] = "tools/gui/images/menubar/select-bounds";
                    oc_Newobject00004["buttonType"] = "RadioButton";
                    oc_Newobject00004["useMouseEvents"] = "0";

                    #endregion

                    oc_Newobject00006["#Newobject00004"] = oc_Newobject00004;

                    #region GuiBitmapButtonCtrl (ENavEditorTestModeBtn)        oc_Newobject00005

                    oc_Newobject00005 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorTestModeBtn", typeof (ENavEditorPaletteButton));
                    oc_Newobject00005["canSaveDynamicFields"] = "1";
                    //oc_Newobject00005["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00005["internalName"] = "NavEditorTestMode";
                    oc_Newobject00005["Enabled"] = "1";
                    oc_Newobject00005["isContainer"] = "0";
                    oc_Newobject00005["Profile"] = "GuiButtonProfile";
                    oc_Newobject00005["HorizSizing"] = "right";
                    oc_Newobject00005["VertSizing"] = "bottom";
                    oc_Newobject00005["Position"] = "0 0";
                    oc_Newobject00005["Extent"] = "25 19";
                    oc_Newobject00005["MinExtent"] = "8 2";
                    oc_Newobject00005["canSave"] = "1";
                    oc_Newobject00005["Visible"] = "1";
                    oc_Newobject00005["Command"] = "NavEditorGui.setMode(\\\"TestMode\\\");";
                    oc_Newobject00005["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00005["ToolTip"] = "Test pathfinding (5).";
                    oc_Newobject00005["DetailedDesc"] = "Click to select/move character, CTRL-click to spawn, SHIFT-click to deselect.";
                    oc_Newobject00005["hovertime"] = "1000";
                    oc_Newobject00005["bitmap"] = "tools/worldEditor/images/toolbar/3rd-person-camera";
                    oc_Newobject00005["buttonType"] = "RadioButton";
                    oc_Newobject00005["useMouseEvents"] = "0";

                    #endregion

                    oc_Newobject00006["#Newobject00005"] = oc_Newobject00005;
                    }

                #endregion

                return oc_Newobject00006.Create();
                }
        }
    }
}