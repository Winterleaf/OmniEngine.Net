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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class ToolsToolbar
    {
        [ConsoleInteraction(true, "ToolsToolbar_initialize")]
        public static void initialize()
        {
            #region GuiContainer (EWToolsToolbar)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiContainer", "EWToolsToolbar", typeof (EditorGui.EWToolsToolbar));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "0";
            oc_Newobject4["internalName"] = "ToolsToolbar";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "editorMenubarProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 31";
            oc_Newobject4["Extent"] = new Creator.StringNoQuote("(29 + 4) * 15 + 12 SPC \"33\"");
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isClosed"] = "0";
            oc_Newobject4["isDynamic"] = "0";

            #region GuiDynamicCtrlArrayControl (ToolsToolbarArray)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiDynamicCtrlArrayControl", "ToolsToolbarArray");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "4 3";
            oc_Newobject1["Extent"] = "290 32";
            oc_Newobject1["MinExtent"] = "1024 32";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["colCount"] = "1";
            oc_Newobject1["colSize"] = "29";
            oc_Newobject1["RowSize"] = "27";
            oc_Newobject1["rowSpacing"] = "2";
            oc_Newobject1["colSpacing"] = "4";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["internalName"] = "resizeArrow";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = new Creator.StringNoQuote("getWord(EWToolsToolbar.Extent, 0) - 7 SPC \"0\"");
            oc_Newobject2["extent"] = "7 33";
            oc_Newobject2["MinExtent"] = "7 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "EWToolsToolbar.ToggleSize();";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Collapse Toolbar";
            oc_Newobject2["hovertime"] = "750";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["bitmap"] = "tools/gui/images/collapse-toolbar";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiDecoyCtrl (EWToolsToolbarDecoy)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiDecoyCtrl", "EWToolsToolbarDecoy", typeof (EditorGui.EWToolsToolbarDecoy));
            oc_Newobject3["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "1 1";
            oc_Newobject3["extent"] = "35 31";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "0";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["useMouseEvents"] = "1";
            oc_Newobject3["isDecoy"] = "1";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject4.Create();
        }
    }
}