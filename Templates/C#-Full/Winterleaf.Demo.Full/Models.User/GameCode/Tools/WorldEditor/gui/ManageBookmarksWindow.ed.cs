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

using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class ManageBookmarksWindow
    {
        [ConsoleInteraction(true, "ManageBookmarksWindow_initialize")]
        public static void initialize()
        {
            #region GuiControl (ManageBookmarksContainer, EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "ManageBookmarksContainer, EditorGuiGroup", typeof (ManageBookmarksContainer));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiModelessDialogProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "800 600";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (EManageBookmarks)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiWindowCollapseCtrl", "EManageBookmarks", typeof (EManageBookmarks));
            oc_Newobject7["AllowPopWindow"] = "1";
            oc_Newobject7["internalName"] = "ManageBookmarksWindow";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject7["HorizSizing"] = "windowRelative";
            oc_Newobject7["VertSizing"] = "windowRelative";
            oc_Newobject7["resizeWidth"] = "1";
            oc_Newobject7["resizeHeight"] = "1";
            oc_Newobject7["canClose"] = "1";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["position"] = "50 90";
            oc_Newobject7["extent"] = "180 306";
            oc_Newobject7["MinExtent"] = "120 130";
            oc_Newobject7["text"] = "Camera Bookmark Manager";
            oc_Newobject7["closeCommand"] = "EManageBookmarks.hideDialog();";
            oc_Newobject7["EdgeSnap"] = "0";
            oc_Newobject7["canCollapse"] = "0";
            oc_Newobject7["visible"] = "0";
            oc_Newobject7["Margin"] = "5 5 5 5";
            oc_Newobject7["Padding"] = "5 5 5 5";

            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "");
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "4 23";
            oc_Newobject4["extent"] = "170 20";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "GuiCenterTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "1 2";
            oc_Newobject1["extent"] = "24 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["setFirstResponder"] = "0";
            oc_Newobject1["modal"] = "1";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "New";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (EAddBookmarkWindowName)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "EAddBookmarkWindowName", typeof (EManageBookmarks.EAddBookmarkWindowName));
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["horizSizing"] = "width";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "27 2";
            oc_Newobject2["extent"] = "126 18";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["setFirstResponder"] = "0";
            oc_Newobject2["modal"] = "1";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["historySize"] = "0";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (EAddBookmarkWindowOK)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "EAddBookmarkWindowOK");
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["horizSizing"] = "left";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "158 3";
            oc_Newobject3["extent"] = "17 17";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["setFirstResponder"] = "0";
            oc_Newobject3["modal"] = "1";
            oc_Newobject3["command"] = "ManageBookmarksContainer.onOK();";
            oc_Newobject3["bitmap"] = "tools/gui/images/new";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["text"] = "Create";
            oc_Newobject3["tooltip"] = "Create New Camera Bookmark";
            oc_Newobject3["accelerator"] = "return";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiScrollCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "4 12";
            oc_Newobject6["Extent"] = "300 200";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Docking"] = "Client";
            oc_Newobject6["Margin"] = "26 1 3 3";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["willFirstRespond"] = "1";
            oc_Newobject6["hScrollBar"] = "alwaysOff";
            oc_Newobject6["vScrollBar"] = "dynamic";
            oc_Newobject6["lockHorizScroll"] = "true";
            oc_Newobject6["lockVertScroll"] = "false";
            oc_Newobject6["constantThumbHeight"] = "0";
            oc_Newobject6["childMargin"] = "2 2";

            #region GuiStackControl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject5["internalName"] = "ManageBookmarksWindowStack";
            oc_Newobject5["StackingType"] = "Vertical";
            oc_Newobject5["HorizStacking"] = "Left to Right";
            oc_Newobject5["VertStacking"] = "Top to Bottom";
            oc_Newobject5["Padding"] = "2";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "300 200";
            oc_Newobject5["MinExtent"] = "16 16";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
        }
    }
}