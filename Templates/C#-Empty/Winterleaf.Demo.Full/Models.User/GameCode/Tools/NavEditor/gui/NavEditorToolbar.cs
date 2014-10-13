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

using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui
{
    public class NavEditorToolbar
    {
        public static void initialize()
        {
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
                #region GuiControl (NavEditorToolbar,EditorGuiGroup)        oc_Newobject00008

                oc_Newobject00008 = new ObjectCreator("GuiControl", "NavEditorToolbar,EditorGuiGroup");
                oc_Newobject00008["position"] = "306 0";
                oc_Newobject00008["extent"] = "800 32";
                oc_Newobject00008["minExtent"] = "8 2";
                oc_Newobject00008["horizSizing"] = "right";
                oc_Newobject00008["vertSizing"] = "bottom";
                oc_Newobject00008["profile"] = "GuiDefaultProfile";
                oc_Newobject00008["visible"] = "1";
                oc_Newobject00008["active"] = "1";
                oc_Newobject00008["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00008["hovertime"] = "1000";
                oc_Newobject00008["isContainer"] = "1";
                oc_Newobject00008["internalName"] = "NavEditorToolbar";
                oc_Newobject00008["canSave"] = "1";
                oc_Newobject00008["canSaveDynamicFields"] = "1";
                oc_Newobject00008["enabled"] = "1";
                if (true)
                    {
                    #region GuiTextCtrl ()        oc_Newobject00001

                    oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00001["text"] = "Navigation Editor";
                    oc_Newobject00001["maxLength"] = "255";
                    oc_Newobject00001["margin"] = "0 0 0 0";
                    oc_Newobject00001["padding"] = "0 0 0 0";
                    oc_Newobject00001["anchorTop"] = "1";
                    oc_Newobject00001["anchorBottom"] = "0";
                    oc_Newobject00001["anchorLeft"] = "1";
                    oc_Newobject00001["anchorRight"] = "0";
                    oc_Newobject00001["position"] = "6 6";
                    oc_Newobject00001["extent"] = "150 20";
                    oc_Newobject00001["minExtent"] = "8 8";
                    oc_Newobject00001["horizSizing"] = "right";
                    oc_Newobject00001["vertSizing"] = "bottom";
                    oc_Newobject00001["profile"] = "GuiTextProfile";
                    oc_Newobject00001["visible"] = "1";
                    oc_Newobject00001["active"] = "1";
                    oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00001["hovertime"] = "1000";
                    oc_Newobject00001["isContainer"] = "1";
                    oc_Newobject00001["canSave"] = "1";
                    oc_Newobject00001["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00001"] = oc_Newobject00001;

                    #region GuiBitmapCtrl ()        oc_Newobject00002

                    oc_Newobject00002 = new ObjectCreator("GuiBitmapCtrl", "");
                    oc_Newobject00002["bitmap"] = "core/art/gui/images/separator-h.png";
                    oc_Newobject00002["wrap"] = "0";
                    oc_Newobject00002["position"] = "90 3";
                    oc_Newobject00002["extent"] = "2 26";
                    oc_Newobject00002["minExtent"] = "1 1";
                    oc_Newobject00002["horizSizing"] = "right";
                    oc_Newobject00002["vertSizing"] = "bottom";
                    oc_Newobject00002["profile"] = "GuiDefaultProfile";
                    oc_Newobject00002["visible"] = "1";
                    oc_Newobject00002["active"] = "1";
                    oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00002["hovertime"] = "1000";
                    oc_Newobject00002["isContainer"] = "0";
                    oc_Newobject00002["canSave"] = "1";
                    oc_Newobject00002["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00002"] = oc_Newobject00002;

                    #region GuiButtonCtrl (NavEditorAboutBtn)        oc_Newobject00003

                    oc_Newobject00003 = new ObjectCreator("GuiButtonCtrl", "NavEditorAboutBtn");
                    oc_Newobject00003["text"] = "About";
                    oc_Newobject00003["groupNum"] = "7";
                    oc_Newobject00003["buttonType"] = "PushButton";
                    oc_Newobject00003["useMouseEvents"] = "0";
                    oc_Newobject00003["position"] = "97 5";
                    oc_Newobject00003["extent"] = "36 20";
                    oc_Newobject00003["minExtent"] = "8 2";
                    oc_Newobject00003["horizSizing"] = "right";
                    oc_Newobject00003["vertSizing"] = "bottom";
                    oc_Newobject00003["profile"] = "GuiButtonProfile";
                    oc_Newobject00003["visible"] = "1";
                    oc_Newobject00003["active"] = "1";
                    oc_Newobject00003["command"] = "Canvas.pushDialog(NavEditorAboutDlg);";
                    oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00003["tooltip"] = "About the navigation editor";
                    oc_Newobject00003["hovertime"] = "1000";
                    oc_Newobject00003["isContainer"] = "0";
                    oc_Newobject00003["canSave"] = "1";
                    oc_Newobject00003["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00003"] = oc_Newobject00003;

                    #region GuiBitmapButtonCtrl (NavEditorConsoleBtn)        oc_Newobject00004

                    oc_Newobject00004 = new ObjectCreator("GuiBitmapButtonCtrl", "NavEditorConsoleBtn");
                    oc_Newobject00004["bitmap"] = "tools/navEditor/images/nav-console";
                    oc_Newobject00004["bitmapMode"] = "Stretched";
                    oc_Newobject00004["autoFitExtents"] = "0";
                    oc_Newobject00004["useModifiers"] = "0";
                    oc_Newobject00004["useStates"] = "1";
                    oc_Newobject00004["groupNum"] = "-1";
                    oc_Newobject00004["buttonType"] = "PushButton";
                    oc_Newobject00004["useMouseEvents"] = "0";
                    oc_Newobject00004["position"] = "135 3";
                    oc_Newobject00004["extent"] = "26 22";
                    oc_Newobject00004["minExtent"] = "8 2";
                    oc_Newobject00004["horizSizing"] = "right";
                    oc_Newobject00004["vertSizing"] = "bottom";
                    oc_Newobject00004["profile"] = "GuiDefaultProfile";
                    oc_Newobject00004["visible"] = "1";
                    oc_Newobject00004["active"] = "1";
                    oc_Newobject00004["command"] = "NavEditorConsoleDlg.setVisible(!NavEditorConsoleDlg.isVisible());";
                    oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00004["tooltip"] = "Show Console";
                    oc_Newobject00004["hovertime"] = "1000";
                    oc_Newobject00004["isContainer"] = "0";
                    oc_Newobject00004["canSave"] = "1";
                    oc_Newobject00004["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00004"] = oc_Newobject00004;

                    #region GuiCheckBoxCtrl ()        oc_Newobject00005

                    oc_Newobject00005 = new ObjectCreator("GuiCheckBoxCtrl", "");
                    oc_Newobject00005["internalName"] = "MeshButton";
                    oc_Newobject00005["text"] = "Mesh";
                    oc_Newobject00005["groupNum"] = "-1";
                    oc_Newobject00005["buttonType"] = "ToggleButton";
                    oc_Newobject00005["useMouseEvents"] = "0";
                    oc_Newobject00005["position"] = "167 1";
                    oc_Newobject00005["extent"] = "50 30";
                    oc_Newobject00005["minExtent"] = "8 2";
                    oc_Newobject00005["horizSizing"] = "right";
                    oc_Newobject00005["vertSizing"] = "bottom";
                    oc_Newobject00005["profile"] = "GuiCheckBoxProfile";
                    oc_Newobject00005["visible"] = "1";
                    oc_Newobject00005["active"] = "1";
                    oc_Newobject00005["variable"] = "$Nav::Editor::renderMesh";
                    oc_Newobject00005["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00005["hovertime"] = "1000";
                    oc_Newobject00005["isContainer"] = "0";
                    oc_Newobject00005["canSave"] = "1";
                    oc_Newobject00005["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00005"] = oc_Newobject00005;

                    #region GuiCheckBoxCtrl ()        oc_Newobject00006

                    oc_Newobject00006 = new ObjectCreator("GuiCheckBoxCtrl", "");
                    oc_Newobject00006["internalName"] = "PortalButton";
                    oc_Newobject00006["text"] = "Portals";
                    oc_Newobject00006["groupNum"] = "-1";
                    oc_Newobject00006["buttonType"] = "ToggleButton";
                    oc_Newobject00006["useMouseEvents"] = "0";
                    oc_Newobject00006["position"] = "224 1";
                    oc_Newobject00006["extent"] = "54 30";
                    oc_Newobject00006["minExtent"] = "8 2";
                    oc_Newobject00006["horizSizing"] = "right";
                    oc_Newobject00006["vertSizing"] = "bottom";
                    oc_Newobject00006["profile"] = "GuiCheckBoxProfile";
                    oc_Newobject00006["visible"] = "1";
                    oc_Newobject00006["active"] = "1";
                    oc_Newobject00006["variable"] = "$Nav::Editor::renderPortals";
                    oc_Newobject00006["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00006["hovertime"] = "1000";
                    oc_Newobject00006["isContainer"] = "0";
                    oc_Newobject00006["canSave"] = "1";
                    oc_Newobject00006["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00006"] = oc_Newobject00006;

                    #region GuiCheckBoxCtrl ()        oc_Newobject00007

                    oc_Newobject00007 = new ObjectCreator("GuiCheckBoxCtrl", "");
                    oc_Newobject00007["internalName"] = "BVTreeButton";
                    oc_Newobject00007["text"] = "BV tree";
                    oc_Newobject00007["groupNum"] = "-1";
                    oc_Newobject00007["buttonType"] = "ToggleButton";
                    oc_Newobject00007["useMouseEvents"] = "0";
                    oc_Newobject00007["position"] = "286 1";
                    oc_Newobject00007["extent"] = "140 30";
                    oc_Newobject00007["minExtent"] = "8 2";
                    oc_Newobject00007["horizSizing"] = "right";
                    oc_Newobject00007["vertSizing"] = "bottom";
                    oc_Newobject00007["profile"] = "GuiCheckBoxProfile";
                    oc_Newobject00007["visible"] = "1";
                    oc_Newobject00007["active"] = "1";
                    oc_Newobject00007["variable"] = "$Nav::Editor::renderBVTree";
                    oc_Newobject00007["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00007["hovertime"] = "1000";
                    oc_Newobject00007["isContainer"] = "0";
                    oc_Newobject00007["canSave"] = "1";
                    oc_Newobject00007["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00008["#Newobject00007"] = oc_Newobject00007;
                    }

                #endregion

                oc_Newobject00008.Create();
                }
        }
    }
}