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

using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
{
    public class MeshRoadEditorPalette
    {
        public static uint initialize()
        {
            #region GuiControl (MeshRoadEditorPalette,EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "MeshRoadEditorPalette,EditorGuiGroup");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (EMeshRoadEditorSelectModeBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorSelectModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorSelectModeBtn));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "MeshRoadEditorSelectMode";
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
            oc_Newobject1["Command"] = "MeshRoadEditorGui.prepSelectionMode();";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Select Mesh Road (1)";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "tools/gui/images/menubar/arrow";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorMoveModeBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorMoveModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorMoveModeBtn));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "MeshRoadEditorMoveMode";
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
            oc_Newobject2["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorMoveMode\\\");";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Move Point (2)";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/road-river/move-point";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorRotateModeBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorRotateModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorRotateModeBtn));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "MeshRoadEditorRotateMode";
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
            oc_Newobject3["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorRotateMode\\\");";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Rotate Point (3)";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/road-river/rotate-point";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorScaleModeBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorScaleModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorScaleModeBtn));
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "MeshRoadEditorScaleMode";
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
            oc_Newobject4["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorScaleMode\\\");";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Scale Point (4)";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/road-river/scale-point";
            oc_Newobject4["buttonType"] = "RadioButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorAddModeBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorAddModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorAddModeBtn));
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "MeshRoadEditorAddRoadMode";
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
            oc_Newobject5["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorAddRoadMode\\\");";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Create Road (5)";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/worldEditor/images/road-river/add-mesh-road";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorInsertModeBtn)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorInsertModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorInsertModeBtn));
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "MeshRoadEditorInsertPointMode";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "25 19";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorInsertPointMode\\\");";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Insert Point (+)";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["bitmap"] = "tools/worldEditor/images/road-river/add-point";
            oc_Newobject6["buttonType"] = "RadioButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl (EMeshRoadEditorRemoveModeBtn)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "EMeshRoadEditorRemoveModeBtn", typeof (MeshRoadEditorGui.EMeshRoadEditorRemoveModeBtn));
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "MeshRoadEditorRemovePointMode";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "0 0";
            oc_Newobject7["Extent"] = "25 19";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "MeshRoadEditorGui.setMode(\\\"MeshRoadEditorRemovePointMode\\\");";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Remove Point (-)";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["bitmap"] = "tools/worldEditor/images/road-river/subtract-point";
            oc_Newobject7["buttonType"] = "RadioButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            return oc_Newobject8.Create();
        }
    }
}