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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
{
    public class DecalEditorPalette
    {
        public static uint initialize()
        {
            #region GuiControl (DecalEditorPalette,EditorGuiGroup)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "DecalEditorPalette,EditorGuiGroup");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "1024 768";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (EDecalEditorSelectDecalBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "EDecalEditorSelectDecalBtn");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "SelectDecalMode";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "0 0";
            oc_Newobject1["Extent"] = "25 19";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "DecalEditorGui.setMode(\\\"SelectDecalMode\\\");";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Select Decal (1)";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "tools/gui/images/menubar/arrow";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (EDecalEditorMoveDecalBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "EDecalEditorMoveDecalBtn");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "MoveDecalMode";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "0 0";
            oc_Newobject2["Extent"] = "25 19";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "DecalEditorGui.setMode(\\\"MoveDecalMode\\\");";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Move Decal (2)";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/road-river/move-point";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (EDecalEditorRotateDecalBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "EDecalEditorRotateDecalBtn");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "RotateDecalMode";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "0 0";
            oc_Newobject3["Extent"] = "25 19";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "DecalEditorGui.setMode(\\\"RotateDecalMode\\\");";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Rotate Decal (3)";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/road-river/rotate-point";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (EDecalEditorScaleDecalBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "EDecalEditorScaleDecalBtn");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "ScaleDecalMode";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "0 0";
            oc_Newobject4["Extent"] = "25 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "DecalEditorGui.setMode(\\\"ScaleDecalMode\\\");";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Scale Decal (4)";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/road-river/scale-point";
            oc_Newobject4["buttonType"] = "RadioButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (EDecalEditorAddDecalBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "EDecalEditorAddDecalBtn");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "AddDecalMode";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "25 19";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "DecalEditorGui.setMode(\\\"AddDecalMode\\\");";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Add Decal (5)";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/decalEditor/add-decal";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            return oc_Newobject6.Create();
        }
    }
}