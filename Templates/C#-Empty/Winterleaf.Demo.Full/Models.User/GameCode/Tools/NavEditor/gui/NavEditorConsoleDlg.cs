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
    public class NavEditorConsoleDlg
    {
        public static void initialize()
        {
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
                {
                #region GuiWindowCtrl (NavEditorConsoleDlg)        oc_Newobject00004

                oc_Newobject00004 = new ObjectCreator("GuiWindowCtrl", "NavEditorConsoleDlg");
                oc_Newobject00004["text"] = "Nav Console";
                oc_Newobject00004["resizeWidth"] = "1";
                oc_Newobject00004["resizeHeight"] = "1";
                oc_Newobject00004["canMove"] = "1";
                oc_Newobject00004["canClose"] = "1";
                oc_Newobject00004["canMinimize"] = "1";
                oc_Newobject00004["canMaximize"] = "1";
                oc_Newobject00004["canCollapse"] = "0";
                oc_Newobject00004["closeCommand"] = "NavEditorConsoleDlg.setVisible(false);";
                oc_Newobject00004["edgeSnap"] = "1";
                oc_Newobject00004["margin"] = "0 0 0 0";
                oc_Newobject00004["padding"] = "0 0 0 0";
                oc_Newobject00004["anchorTop"] = "1";
                oc_Newobject00004["anchorBottom"] = "0";
                oc_Newobject00004["anchorLeft"] = "1";
                oc_Newobject00004["anchorRight"] = "0";
                oc_Newobject00004["position"] = "238 170";
                oc_Newobject00004["extent"] = "320 240";
                oc_Newobject00004["minExtent"] = "8 2";
                oc_Newobject00004["horizSizing"] = "right";
                oc_Newobject00004["vertSizing"] = "bottom";
                oc_Newobject00004["profile"] = "GuiWindowProfile";
                oc_Newobject00004["visible"] = "1";
                oc_Newobject00004["active"] = "1";
                oc_Newobject00004["tooltipProfile"] = "GuiToolTipProfile";
                oc_Newobject00004["hovertime"] = "1000";
                oc_Newobject00004["isContainer"] = "1";
                oc_Newobject00004["canSave"] = "1";
                oc_Newobject00004["canSaveDynamicFields"] = "1";
                if (true)
                    {
                    #region GuiTextCtrl ()        oc_Newobject00001

                    oc_Newobject00001 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject00001["maxLength"] = "1024";
                    oc_Newobject00001["margin"] = "0 0 0 0";
                    oc_Newobject00001["padding"] = "0 0 0 0";
                    oc_Newobject00001["anchorTop"] = "1";
                    oc_Newobject00001["anchorBottom"] = "0";
                    oc_Newobject00001["anchorLeft"] = "1";
                    oc_Newobject00001["anchorRight"] = "0";
                    oc_Newobject00001["position"] = "3 222";
                    oc_Newobject00001["extent"] = "149 13";
                    oc_Newobject00001["minExtent"] = "8 2";
                    oc_Newobject00001["horizSizing"] = "right";
                    oc_Newobject00001["vertSizing"] = "top";
                    oc_Newobject00001["profile"] = "GuiTextProfile";
                    oc_Newobject00001["visible"] = "1";
                    oc_Newobject00001["active"] = "1";
                    oc_Newobject00001["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00001["hovertime"] = "1000";
                    oc_Newobject00001["isContainer"] = "1";
                    oc_Newobject00001["internalName"] = "StatusLeft";
                    oc_Newobject00001["canSave"] = "1";
                    oc_Newobject00001["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject00004["#Newobject00001"] = oc_Newobject00001;

                    #region GuiScrollCtrl ()        oc_Newobject00003

                    oc_Newobject00003 = new ObjectCreator("GuiScrollCtrl", "");
                    oc_Newobject00003["willFirstRespond"] = "1";
                    oc_Newobject00003["hScrollBar"] = "dynamic";
                    oc_Newobject00003["vScrollBar"] = "dynamic";
                    oc_Newobject00003["lockHorizScroll"] = "1";
                    oc_Newobject00003["lockVertScroll"] = "0";
                    oc_Newobject00003["constantThumbHeight"] = "0";
                    oc_Newobject00003["childMargin"] = "0 0";
                    oc_Newobject00003["mouseWheelScrollSpeed"] = "-1";
                    oc_Newobject00003["margin"] = "-14 41 3 3";
                    oc_Newobject00003["padding"] = "0 0 0 0";
                    oc_Newobject00003["anchorTop"] = "0";
                    oc_Newobject00003["anchorBottom"] = "0";
                    oc_Newobject00003["anchorLeft"] = "0";
                    oc_Newobject00003["anchorRight"] = "0";
                    oc_Newobject00003["position"] = "3 23";
                    oc_Newobject00003["extent"] = "314 194";
                    oc_Newobject00003["minExtent"] = "8 2";
                    oc_Newobject00003["horizSizing"] = "relative";
                    oc_Newobject00003["vertSizing"] = "relative";
                    oc_Newobject00003["profile"] = "GuiEditorScrollProfile";
                    oc_Newobject00003["visible"] = "1";
                    oc_Newobject00003["active"] = "1";
                    oc_Newobject00003["tooltipProfile"] = "GuiToolTipProfile";
                    oc_Newobject00003["hovertime"] = "1000";
                    oc_Newobject00003["isContainer"] = "1";
                    oc_Newobject00003["internalName"] = "OutputScroll";
                    oc_Newobject00003["canSave"] = "1";
                    oc_Newobject00003["canSaveDynamicFields"] = "0";
                    if (true)
                        {
                        #region GuiListBoxCtrl ()        oc_Newobject00002

                        oc_Newobject00002 = new ObjectCreator("GuiListBoxCtrl", "");
                        oc_Newobject00002["allowMultipleSelections"] = "0";
                        oc_Newobject00002["fitParentWidth"] = "1";
                        oc_Newobject00002["colorBullet"] = "1";
                        oc_Newobject00002["position"] = "1 1";
                        oc_Newobject00002["extent"] = "312 16";
                        oc_Newobject00002["minExtent"] = "8 2";
                        oc_Newobject00002["horizSizing"] = "relative";
                        oc_Newobject00002["vertSizing"] = "relative";
                        oc_Newobject00002["profile"] = "GuiListBoxProfile";
                        oc_Newobject00002["visible"] = "1";
                        oc_Newobject00002["active"] = "1";
                        oc_Newobject00002["tooltipProfile"] = "GuiToolTipProfile";
                        oc_Newobject00002["hovertime"] = "1000";
                        oc_Newobject00002["isContainer"] = "0";
                        oc_Newobject00002["internalName"] = "Output";
                        oc_Newobject00002["canSave"] = "1";
                        oc_Newobject00002["canSaveDynamicFields"] = "0";

                        #endregion

                        oc_Newobject00003["#Newobject00002"] = oc_Newobject00002;
                        }

                    #endregion

                    oc_Newobject00004["#Newobject00003"] = oc_Newobject00003;
                    }

                #endregion

                oc_Newobject00004.Create();
                }
        }
    }
}