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

using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using Creator = WinterLeaf.Engine.Classes.View.Creators.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class TerrainEditorSettingsTab
    {
        [ConsoleInteraction(true, "TerrainEditorSettingsTab_initialize")]
        public static void initialize()
        {
            #region GuiControl (TerrainEditorSettingsTab,EditorGuiGroup)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiControl", "TerrainEditorSettingsTab,EditorGuiGroup");
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "0 0";
            oc_Newobject15["Extent"] = "800 600";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (ETerrainEditorSettingsPage)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTabPageCtrl", "ETerrainEditorSettingsPage");
            oc_Newobject14["fitBook"] = "1";
            oc_Newobject14["text"] = "Terrain Editor";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "height";
            oc_Newobject14["position"] = "0 0";
            oc_Newobject14["Extent"] = "208 400";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject13["willFirstRespond"] = "1";
            oc_Newobject13["hScrollBar"] = "alwaysOff";
            oc_Newobject13["vScrollBar"] = "dynamic";
            oc_Newobject13["lockHorizScroll"] = "1";
            oc_Newobject13["lockVertScroll"] = "0";
            oc_Newobject13["constantThumbHeight"] = "0";
            oc_Newobject13["childMargin"] = "0 0";
            oc_Newobject13["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "height";
            oc_Newobject13["position"] = "0 0";
            oc_Newobject13["Extent"] = "208 400";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject12["StackingType"] = "Vertical";
            oc_Newobject12["HorizStacking"] = "Left to Right";
            oc_Newobject12["VertStacking"] = "Top to Bottom";
            oc_Newobject12["Padding"] = "0";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "1 1";
            oc_Newobject12["extent"] = "208 210";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["isDecoy"] = "0";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject11["Profile"] = "GuiRolloutProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "10 10";
            oc_Newobject11["extent"] = "208 95";
            oc_Newobject11["Caption"] = "Tool Values";
            oc_Newobject11["Margin"] = "0 3 0 0";
            oc_Newobject11["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject11["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject10["StackingType"] = "Vertical";
            oc_Newobject10["HorizStacking"] = "Left to Right";
            oc_Newobject10["VertStacking"] = "Top to Bottom";
            oc_Newobject10["Padding"] = "0";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["Extent"] = "208 0";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["isDecoy"] = "0";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["padding"] = "3";

            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Raise/Lower Height:";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 1";
            oc_Newobject1["Extent"] = "70 16";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "81 0";
            oc_Newobject2["Extent"] = "121 18";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "1";
            //oc_Newobject2["class"] = "ESettingsWindowTextEdit";
            //oc_Newobject2["className"] = "ESettingsWindowTextEdit";
            oc_Newobject2["editorSettingsRead"] = "ETerrainEditor.adjustHeightVal = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject2["editorSettingsValue"] = "TerrainEditor/ActionValues/adjustHeightVal";
            oc_Newobject2["editorSettingsWrite"] = "EditorGui.writeTerrainEditorSettings();";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject10["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Smooth Factor:";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "5 1";
            oc_Newobject4["Extent"] = "70 16";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiTextEditCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject5["historySize"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["tabComplete"] = "0";
            oc_Newobject5["sinkAllKeyEvents"] = "0";
            oc_Newobject5["passwordMask"] = "*";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "81 0";
            oc_Newobject5["Extent"] = "121 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "1";
            //oc_Newobject5["class"] = "ESettingsWindowTextEdit";
            //oc_Newobject5["className"] = "ESettingsWindowTextEdit";
            oc_Newobject5["editorSettingsRead"] = "ETerrainEditor.smoothFactor = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject5["editorSettingsValue"] = "TerrainEditor/ActionValues/smoothFactor";
            oc_Newobject5["editorSettingsWrite"] = "EditorGui.writeTerrainEditorSettings();";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiControl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "Noise Factor:";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "5 1";
            oc_Newobject7["Extent"] = "70 18";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";
            oc_Newobject8["passwordMask"] = "*";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "81 0";
            oc_Newobject8["Extent"] = "121 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "1";
            //oc_Newobject8["class"] = "ESettingsWindowTextEdit";
            //oc_Newobject8["className"] = "ESettingsWindowTextEdit";
            oc_Newobject8["editorSettingsRead"] = "ETerrainEditor.noiseFactor = EditorSettings.value(%this.editorSettingsValue);";
            oc_Newobject8["editorSettingsValue"] = "TerrainEditor/ActionValues/noiseFactor";
            oc_Newobject8["editorSettingsWrite"] = "EditorGui.writeTerrainEditorSettings();";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject15.Create();
        }
    }
}