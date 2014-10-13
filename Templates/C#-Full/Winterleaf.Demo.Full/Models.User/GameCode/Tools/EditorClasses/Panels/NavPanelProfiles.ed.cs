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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.Panels
{
    public class NavPanelProfiles
    {
        [ConsoleInteraction(true, "NavPanelProfiles_initialize")]
        public static void initialize()
        {
            #region GuiControlProfile  (NavPanelProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile ", "NavPanelProfile");
            oc_Newobject1["opaque"] = new Creator.StringNoQuote("false");
            oc_Newobject1["border"] = new Creator.StringNoQuote("-2");
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (NavPanel : NavPanelProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "NavPanel : NavPanelProfile");
            oc_Newobject2["bitmap"] = "tools/editorClasses/gui/panels/navPanel";
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile  (NavPanelBlue : NavPanelProfile)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile ", "NavPanelBlue : NavPanelProfile");
            oc_Newobject3["bitmap"] = "tools/editorClasses/gui/panels/navPanel_blue";
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiControlProfile  (NavPanelGreen : NavPanelProfile)        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiControlProfile ", "NavPanelGreen : NavPanelProfile");
            oc_Newobject4["bitmap"] = "tools/editorClasses/gui/panels/navPanel_green";
            oc_Newobject4["category"] = "Editor";

            #endregion

            oc_Newobject4.Create();

            #region GuiControlProfile  (NavPanelRed : NavPanelProfile)        oc_Newobject5

            SingletonCreator oc_Newobject5 = new SingletonCreator("GuiControlProfile ", "NavPanelRed : NavPanelProfile");
            oc_Newobject5["bitmap"] = "tools/editorClasses/gui/panels/navPanel_red";
            oc_Newobject5["category"] = "Editor";

            #endregion

            oc_Newobject5.Create();

            #region GuiControlProfile  (NavPanelWhite : NavPanelProfile)        oc_Newobject6

            SingletonCreator oc_Newobject6 = new SingletonCreator("GuiControlProfile ", "NavPanelWhite : NavPanelProfile");
            oc_Newobject6["bitmap"] = "tools/editorClasses/gui/panels/navPanel_white";
            oc_Newobject6["category"] = "Editor";

            #endregion

            oc_Newobject6.Create();

            #region GuiControlProfile  (NavPanelYellow : NavPanelProfile)        oc_Newobject7

            SingletonCreator oc_Newobject7 = new SingletonCreator("GuiControlProfile ", "NavPanelYellow : NavPanelProfile");
            oc_Newobject7["bitmap"] = "tools/editorClasses/gui/panels/navPanel_yellow";
            oc_Newobject7["category"] = "Editor";

            #endregion

            oc_Newobject7.Create();

            #region GuiControlProfile  (menubarProfile : NavPanelProfile)        oc_Newobject8

            SingletonCreator oc_Newobject8 = new SingletonCreator("GuiControlProfile ", "menubarProfile : NavPanelProfile");
            oc_Newobject8["bitmap"] = "tools/editorClasses/gui/panels/menubar";
            oc_Newobject8["category"] = "Editor";

            #endregion

            oc_Newobject8.Create();

            #region GuiControlProfile  (editorMenubarProfile : NavPanelProfile)        oc_Newobject9

            SingletonCreator oc_Newobject9 = new SingletonCreator("GuiControlProfile ", "editorMenubarProfile : NavPanelProfile");
            oc_Newobject9["bitmap"] = "tools/editorClasses/gui/panels/editor-menubar";
            oc_Newobject9["category"] = "Editor";

            #endregion

            oc_Newobject9.Create();

            #region GuiControlProfile  (editorMenu_wBorderProfile : NavPanelProfile)        oc_Newobject10

            SingletonCreator oc_Newobject10 = new SingletonCreator("GuiControlProfile ", "editorMenu_wBorderProfile : NavPanelProfile");
            oc_Newobject10["bitmap"] = "tools/editorClasses/gui/panels/menu-fullborder";
            oc_Newobject10["category"] = "Editor";

            #endregion

            oc_Newobject10.Create();

            #region GuiControlProfile  (inspectorStyleRolloutProfile : NavPanelProfile)        oc_Newobject11

            SingletonCreator oc_Newobject11 = new SingletonCreator("GuiControlProfile ", "inspectorStyleRolloutProfile : NavPanelProfile");
            oc_Newobject11["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout";
            oc_Newobject11["category"] = "Editor";

            #endregion

            oc_Newobject11.Create();

            #region GuiControlProfile  (inspectorStyleRolloutListProfile : NavPanelProfile)        oc_Newobject12

            SingletonCreator oc_Newobject12 = new SingletonCreator("GuiControlProfile ", "inspectorStyleRolloutListProfile : NavPanelProfile");
            oc_Newobject12["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout-list";
            oc_Newobject12["category"] = "Editor";

            #endregion

            oc_Newobject12.Create();

            #region GuiControlProfile  (inspectorStyleRolloutDarkProfile : NavPanelProfile)        oc_Newobject13

            SingletonCreator oc_Newobject13 = new SingletonCreator("GuiControlProfile ", "inspectorStyleRolloutDarkProfile : NavPanelProfile");
            oc_Newobject13["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout-dark";
            oc_Newobject13["category"] = "Editor";

            #endregion

            oc_Newobject13.Create();

            #region GuiControlProfile  (inspectorStyleRolloutInnerProfile : NavPanelProfile)        oc_Newobject14

            SingletonCreator oc_Newobject14 = new SingletonCreator("GuiControlProfile ", "inspectorStyleRolloutInnerProfile : NavPanelProfile");
            oc_Newobject14["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout_inner";
            oc_Newobject14["category"] = "Editor";

            #endregion

            oc_Newobject14.Create();

            #region GuiControlProfile  (inspectorStyleRolloutNoHeaderProfile : NavPanelProfile)        oc_Newobject15

            SingletonCreator oc_Newobject15 = new SingletonCreator("GuiControlProfile ", "inspectorStyleRolloutNoHeaderProfile : NavPanelProfile");
            oc_Newobject15["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout-noheader";
            oc_Newobject15["category"] = "Editor";

            #endregion

            oc_Newobject15.Create();

            #region GuiControlProfile  (IconDropdownProfile : NavPanelProfile)        oc_Newobject16

            SingletonCreator oc_Newobject16 = new SingletonCreator("GuiControlProfile ", "IconDropdownProfile : NavPanelProfile");
            oc_Newobject16["bitmap"] = "tools/editorClasses/gui/panels/icon-dropdownbar";
            oc_Newobject16["category"] = "Editor";

            #endregion

            oc_Newobject16.Create();
        }
    }
}