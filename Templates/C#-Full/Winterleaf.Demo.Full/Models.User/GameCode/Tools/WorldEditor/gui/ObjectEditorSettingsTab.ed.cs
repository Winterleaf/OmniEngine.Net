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
    public class ObjectEditorSettingsTab
    {
        [ConsoleInteraction(true, "ObjectEditorSettingsTab_initialize")]
        public static void initialize()
        {
            #region GuiControl (ObjectEditorSettingsTab,EditorGuiGroup)        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiControl", "ObjectEditorSettingsTab,EditorGuiGroup");
            oc_Newobject50["isContainer"] = "1";
            oc_Newobject50["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject50["horizSizing"] = "right";
            oc_Newobject50["vertSizing"] = "bottom";
            oc_Newobject50["position"] = "0 0";
            oc_Newobject50["extent"] = "1024 768";
            oc_Newobject50["minExtent"] = "8 2";
            oc_Newobject50["visible"] = "1";
            oc_Newobject50["active"] = "1";
            oc_Newobject50["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (EObjectEditorSettingsPage)        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiTabPageCtrl", "EObjectEditorSettingsPage");
            oc_Newobject49["fitBook"] = "1";
            oc_Newobject49["text"] = "Object Editor";
            oc_Newobject49["maxLength"] = "1024";
            oc_Newobject49["margin"] = "0 0 0 0";
            oc_Newobject49["padding"] = "0 0 0 0";
            oc_Newobject49["anchorTop"] = "1";
            oc_Newobject49["anchorBottom"] = "0";
            oc_Newobject49["anchorLeft"] = "1";
            oc_Newobject49["anchorRight"] = "0";
            oc_Newobject49["isContainer"] = "1";
            oc_Newobject49["profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject49["horizSizing"] = "width";
            oc_Newobject49["vertSizing"] = "height";
            oc_Newobject49["position"] = "0 0";
            oc_Newobject49["extent"] = "208 568";
            oc_Newobject49["minExtent"] = "8 2";
            oc_Newobject49["visible"] = "1";
            oc_Newobject49["active"] = "1";
            oc_Newobject49["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject48["willFirstRespond"] = "1";
            oc_Newobject48["hScrollBar"] = "alwaysOff";
            oc_Newobject48["vScrollBar"] = "dynamic";
            oc_Newobject48["lockHorizScroll"] = "1";
            oc_Newobject48["lockVertScroll"] = "0";
            oc_Newobject48["constantThumbHeight"] = "0";
            oc_Newobject48["childMargin"] = "0 0";
            oc_Newobject48["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject48["margin"] = "0 0 0 0";
            oc_Newobject48["padding"] = "0 0 0 0";
            oc_Newobject48["anchorTop"] = "1";
            oc_Newobject48["anchorBottom"] = "0";
            oc_Newobject48["anchorLeft"] = "1";
            oc_Newobject48["anchorRight"] = "0";
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject48["horizSizing"] = "width";
            oc_Newobject48["vertSizing"] = "height";
            oc_Newobject48["position"] = "0 0";
            oc_Newobject48["extent"] = "208 568";
            oc_Newobject48["minExtent"] = "8 2";
            oc_Newobject48["visible"] = "1";
            oc_Newobject48["active"] = "1";
            oc_Newobject48["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject47["StackingType"] = "Vertical";
            oc_Newobject47["HorizStacking"] = "Left to Right";
            oc_Newobject47["VertStacking"] = "Top to Bottom";
            oc_Newobject47["Padding"] = "0";
            oc_Newobject47["isContainer"] = "1";
            oc_Newobject47["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject47["HorizSizing"] = "width";
            oc_Newobject47["VertSizing"] = "bottom";
            oc_Newobject47["position"] = "1 1";
            oc_Newobject47["extent"] = "208 210";
            oc_Newobject47["MinExtent"] = "8 2";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["isDecoy"] = "0";
            oc_Newobject47["Visible"] = "1";
            oc_Newobject47["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject6["Profile"] = "GuiRolloutProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "10 10";
            oc_Newobject6["extent"] = "208 95";
            oc_Newobject6["Caption"] = "Render";
            oc_Newobject6["Margin"] = "4 3 0 0";
            oc_Newobject6["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject6["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject5["StackingType"] = "Vertical";
            oc_Newobject5["HorizStacking"] = "Left to Right";
            oc_Newobject5["VertStacking"] = "Top to Bottom";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "208 0";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["padding"] = "3";

            #region GuiCheckBoxCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject1["useInactiveState"] = "0";
            oc_Newobject1["text"] = "Object Icons";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "ToggleButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 10";
            oc_Newobject1["extent"] = "140 14";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "1";
            //oc_Newobject1["class"] = "ESettingsWindowCheckbox";
            oc_Newobject1["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject1["editorSettingsValue"] = "WorldEditor/Render/renderObjHandle";
            oc_Newobject1["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiCheckBoxCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject2["useInactiveState"] = "0";
            oc_Newobject2["text"] = "Object Text";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "ToggleButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "5 30";
            oc_Newobject2["extent"] = "140 14";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "1";
            //oc_Newobject2["class"] = "ESettingsWindowCheckbox";
            oc_Newobject2["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject2["editorSettingsValue"] = "WorldEditor/Render/renderObjText";
            oc_Newobject2["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiCheckBoxCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject3["useInactiveState"] = "0";
            oc_Newobject3["text"] = "Mouse Popup Info";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "ToggleButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "5 50";
            oc_Newobject3["extent"] = "140 14";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "1";
            //oc_Newobject3["class"] = "ESettingsWindowCheckbox";
            oc_Newobject3["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject3["editorSettingsValue"] = "WorldEditor/Render/showMousePopupInfo";
            oc_Newobject3["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiCheckBoxCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject4["useInactiveState"] = "0";
            oc_Newobject4["text"] = "Popup Menu Background";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "ToggleButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "5 70";
            oc_Newobject4["extent"] = "140 14";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "1";
            //oc_Newobject4["class"] = "ESettingsWindowCheckbox";
            oc_Newobject4["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject4["editorSettingsValue"] = "WorldEditor/Render/renderPopupBackground";
            oc_Newobject4["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject47["#Newobject6"] = oc_Newobject6;

            #region GuiRolloutCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject36["Profile"] = "GuiRolloutProfile";
            oc_Newobject36["HorizSizing"] = "right";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["position"] = "10 10";
            oc_Newobject36["extent"] = "208 95";
            oc_Newobject36["Caption"] = "Colors";
            oc_Newobject36["Margin"] = "0 3 0 0";
            oc_Newobject36["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject36["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject35["StackingType"] = "Vertical";
            oc_Newobject35["HorizStacking"] = "Left to Right";
            oc_Newobject35["VertStacking"] = "Top to Bottom";
            oc_Newobject35["isContainer"] = "1";
            oc_Newobject35["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject35["HorizSizing"] = "width";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["position"] = "0 0";
            oc_Newobject35["Extent"] = "208 0";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["isDecoy"] = "0";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["padding"] = "3";

            #region GuiControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "5 90";
            oc_Newobject10["extent"] = "204 18";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["active"] = "1";
            oc_Newobject10["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "1";
            //oc_Newobject10["class"] = "ESettingsWindowColor";
            oc_Newobject10["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject10["editorSettingsValue"] = "WorldEditor/Grid/gridColor";
            oc_Newobject10["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "Grid Major:";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["margin"] = "0 0 0 0";
            oc_Newobject7["padding"] = "0 0 0 0";
            oc_Newobject7["anchorTop"] = "1";
            oc_Newobject7["anchorBottom"] = "0";
            oc_Newobject7["anchorLeft"] = "1";
            oc_Newobject7["anchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 1";
            oc_Newobject7["extent"] = "70 16";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";
            oc_Newobject8["passwordMask"] = "*";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject8["horizSizing"] = "width";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["position"] = "80 0";
            oc_Newobject8["extent"] = "104 18";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["internalName"] = "ColorEdit";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "1";
            //oc_Newobject8["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiSwatchButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject9["color"] = "1 1 1 1";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["horizSizing"] = "left";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "188 2";
            oc_Newobject9["extent"] = "14 14";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["internalName"] = "ColorButton";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "1";
            //oc_Newobject9["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject35["#Newobject10"] = oc_Newobject10;

            #region GuiControl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["position"] = "5 110";
            oc_Newobject14["extent"] = "204 18";
            oc_Newobject14["minExtent"] = "8 2";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["active"] = "1";
            oc_Newobject14["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["canSaveDynamicFields"] = "1";
            // oc_Newobject14["class"] = "ESettingsWindowColor";
            oc_Newobject14["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject14["editorSettingsValue"] = "WorldEditor/Grid/gridMinorColor";
            oc_Newobject14["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["text"] = "Grid Minor:";
            oc_Newobject11["maxLength"] = "1024";
            oc_Newobject11["margin"] = "0 0 0 0";
            oc_Newobject11["padding"] = "0 0 0 0";
            oc_Newobject11["anchorTop"] = "1";
            oc_Newobject11["anchorBottom"] = "0";
            oc_Newobject11["anchorLeft"] = "1";
            oc_Newobject11["anchorRight"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "0 1";
            oc_Newobject11["extent"] = "70 16";
            oc_Newobject11["minExtent"] = "8 2";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["active"] = "1";
            oc_Newobject11["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiTextEditCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject12["historySize"] = "0";
            oc_Newobject12["password"] = "0";
            oc_Newobject12["tabComplete"] = "0";
            oc_Newobject12["sinkAllKeyEvents"] = "0";
            oc_Newobject12["passwordMask"] = "*";
            oc_Newobject12["maxLength"] = "1024";
            oc_Newobject12["margin"] = "0 0 0 0";
            oc_Newobject12["padding"] = "0 0 0 0";
            oc_Newobject12["anchorTop"] = "1";
            oc_Newobject12["anchorBottom"] = "0";
            oc_Newobject12["anchorLeft"] = "1";
            oc_Newobject12["anchorRight"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject12["horizSizing"] = "width";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "80 0";
            oc_Newobject12["extent"] = "104 18";
            oc_Newobject12["minExtent"] = "8 2";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["active"] = "1";
            oc_Newobject12["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["internalName"] = "ColorEdit";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["canSaveDynamicFields"] = "1";
            //oc_Newobject12["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject14["#Newobject12"] = oc_Newobject12;

            #region GuiSwatchButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject13["color"] = "1 1 1 1";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["horizSizing"] = "left";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["position"] = "188 2";
            oc_Newobject13["extent"] = "14 14";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["active"] = "1";
            oc_Newobject13["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["internalName"] = "ColorButton";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["canSaveDynamicFields"] = "1";
            //oc_Newobject13["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject35["#Newobject14"] = oc_Newobject14;

            #region GuiControl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["position"] = "5 130";
            oc_Newobject18["extent"] = "204 18";
            oc_Newobject18["minExtent"] = "8 2";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["active"] = "1";
            oc_Newobject18["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["canSaveDynamicFields"] = "1";
            //oc_Newobject18["class"] = "ESettingsWindowColor";
            oc_Newobject18["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject18["editorSettingsValue"] = "WorldEditor/Grid/gridOriginColor";
            oc_Newobject18["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["text"] = "Grid Origin:";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["margin"] = "0 0 0 0";
            oc_Newobject15["padding"] = "0 0 0 0";
            oc_Newobject15["anchorTop"] = "1";
            oc_Newobject15["anchorBottom"] = "0";
            oc_Newobject15["anchorLeft"] = "1";
            oc_Newobject15["anchorRight"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["position"] = "0 1";
            oc_Newobject15["extent"] = "70 16";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["active"] = "1";
            oc_Newobject15["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject18["#Newobject15"] = oc_Newobject15;

            #region GuiTextEditCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject16["historySize"] = "0";
            oc_Newobject16["password"] = "0";
            oc_Newobject16["tabComplete"] = "0";
            oc_Newobject16["sinkAllKeyEvents"] = "0";
            oc_Newobject16["passwordMask"] = "*";
            oc_Newobject16["maxLength"] = "1024";
            oc_Newobject16["margin"] = "0 0 0 0";
            oc_Newobject16["padding"] = "0 0 0 0";
            oc_Newobject16["anchorTop"] = "1";
            oc_Newobject16["anchorBottom"] = "0";
            oc_Newobject16["anchorLeft"] = "1";
            oc_Newobject16["anchorRight"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject16["horizSizing"] = "width";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["position"] = "80 0";
            oc_Newobject16["extent"] = "104 17";
            oc_Newobject16["minExtent"] = "8 2";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["active"] = "1";
            oc_Newobject16["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["internalName"] = "ColorEdit";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["canSaveDynamicFields"] = "1";
            // oc_Newobject16["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject18["#Newobject16"] = oc_Newobject16;

            #region GuiSwatchButtonCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject17["color"] = "1 1 1 1";
            oc_Newobject17["groupNum"] = "-1";
            oc_Newobject17["buttonType"] = "PushButton";
            oc_Newobject17["useMouseEvents"] = "0";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["horizSizing"] = "left";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["position"] = "188 2";
            oc_Newobject17["extent"] = "14 14";
            oc_Newobject17["minExtent"] = "8 2";
            oc_Newobject17["visible"] = "1";
            oc_Newobject17["active"] = "1";
            oc_Newobject17["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["internalName"] = "ColorButton";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["canSaveDynamicFields"] = "1";
            //oc_Newobject17["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject35["#Newobject18"] = oc_Newobject18;

            #region GuiControl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["position"] = "5 10";
            oc_Newobject22["extent"] = "204 18";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "1";
            //oc_Newobject22["class"] = "ESettingsWindowColor";
            oc_Newobject22["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject22["editorSettingsValue"] = "WorldEditor/Color/dragRectColor";
            oc_Newobject22["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject19["text"] = "Drag Rect:";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["margin"] = "0 0 0 0";
            oc_Newobject19["padding"] = "0 0 0 0";
            oc_Newobject19["anchorTop"] = "1";
            oc_Newobject19["anchorBottom"] = "0";
            oc_Newobject19["anchorLeft"] = "1";
            oc_Newobject19["anchorRight"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["position"] = "0 1";
            oc_Newobject19["extent"] = "70 16";
            oc_Newobject19["minExtent"] = "8 2";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["active"] = "1";
            oc_Newobject19["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiTextEditCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject20["historySize"] = "0";
            oc_Newobject20["password"] = "0";
            oc_Newobject20["tabComplete"] = "0";
            oc_Newobject20["sinkAllKeyEvents"] = "0";
            oc_Newobject20["passwordMask"] = "*";
            oc_Newobject20["maxLength"] = "1024";
            oc_Newobject20["margin"] = "0 0 0 0";
            oc_Newobject20["padding"] = "0 0 0 0";
            oc_Newobject20["anchorTop"] = "1";
            oc_Newobject20["anchorBottom"] = "0";
            oc_Newobject20["anchorLeft"] = "1";
            oc_Newobject20["anchorRight"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject20["horizSizing"] = "width";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["position"] = "80 0";
            oc_Newobject20["extent"] = "104 18";
            oc_Newobject20["minExtent"] = "8 2";
            oc_Newobject20["visible"] = "1";
            oc_Newobject20["active"] = "1";
            oc_Newobject20["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["internalName"] = "ColorEdit";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["canSaveDynamicFields"] = "1";
            //oc_Newobject20["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiSwatchButtonCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject21["color"] = "1 1 1 1";
            oc_Newobject21["groupNum"] = "-1";
            oc_Newobject21["buttonType"] = "PushButton";
            oc_Newobject21["useMouseEvents"] = "0";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["horizSizing"] = "left";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["position"] = "188 2";
            oc_Newobject21["extent"] = "14 14";
            oc_Newobject21["minExtent"] = "8 2";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["internalName"] = "ColorButton";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "1";
            // oc_Newobject21["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject35["#Newobject22"] = oc_Newobject22;

            #region GuiControl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject26["isContainer"] = "1";
            oc_Newobject26["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["position"] = "5 30";
            oc_Newobject26["extent"] = "204 18";
            oc_Newobject26["minExtent"] = "8 2";
            oc_Newobject26["visible"] = "1";
            oc_Newobject26["active"] = "1";
            oc_Newobject26["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["canSaveDynamicFields"] = "1";
            // oc_Newobject26["class"] = "ESettingsWindowColor";
            oc_Newobject26["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject26["editorSettingsValue"] = "WorldEditor/Color/objectTextColor";
            oc_Newobject26["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject23["text"] = "Object Text:";
            oc_Newobject23["maxLength"] = "1024";
            oc_Newobject23["margin"] = "0 0 0 0";
            oc_Newobject23["padding"] = "0 0 0 0";
            oc_Newobject23["anchorTop"] = "1";
            oc_Newobject23["anchorBottom"] = "0";
            oc_Newobject23["anchorLeft"] = "1";
            oc_Newobject23["anchorRight"] = "0";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject23["horizSizing"] = "right";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["position"] = "0 1";
            oc_Newobject23["extent"] = "70 16";
            oc_Newobject23["minExtent"] = "8 2";
            oc_Newobject23["visible"] = "1";
            oc_Newobject23["active"] = "1";
            oc_Newobject23["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject26["#Newobject23"] = oc_Newobject23;

            #region GuiTextEditCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject24["historySize"] = "0";
            oc_Newobject24["password"] = "0";
            oc_Newobject24["tabComplete"] = "0";
            oc_Newobject24["sinkAllKeyEvents"] = "0";
            oc_Newobject24["passwordMask"] = "*";
            oc_Newobject24["maxLength"] = "1024";
            oc_Newobject24["margin"] = "0 0 0 0";
            oc_Newobject24["padding"] = "0 0 0 0";
            oc_Newobject24["anchorTop"] = "1";
            oc_Newobject24["anchorBottom"] = "0";
            oc_Newobject24["anchorLeft"] = "1";
            oc_Newobject24["anchorRight"] = "0";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject24["horizSizing"] = "width";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["position"] = "80 0";
            oc_Newobject24["extent"] = "104 18";
            oc_Newobject24["minExtent"] = "8 2";
            oc_Newobject24["visible"] = "1";
            oc_Newobject24["active"] = "1";
            oc_Newobject24["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["internalName"] = "ColorEdit";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["canSaveDynamicFields"] = "1";
            //oc_Newobject24["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject26["#Newobject24"] = oc_Newobject24;

            #region GuiSwatchButtonCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject25["color"] = "1 1 1 1";
            oc_Newobject25["groupNum"] = "-1";
            oc_Newobject25["buttonType"] = "PushButton";
            oc_Newobject25["useMouseEvents"] = "0";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject25["horizSizing"] = "left";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["position"] = "188 2";
            oc_Newobject25["extent"] = "14 14";
            oc_Newobject25["minExtent"] = "8 2";
            oc_Newobject25["visible"] = "1";
            oc_Newobject25["active"] = "1";
            oc_Newobject25["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["internalName"] = "ColorButton";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["canSaveDynamicFields"] = "1";
            //oc_Newobject25["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject26["#Newobject25"] = oc_Newobject25;

            #endregion

            oc_Newobject35["#Newobject26"] = oc_Newobject26;

            #region GuiControl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject30["isContainer"] = "1";
            oc_Newobject30["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject30["horizSizing"] = "right";
            oc_Newobject30["vertSizing"] = "bottom";
            oc_Newobject30["position"] = "5 50";
            oc_Newobject30["extent"] = "204 18";
            oc_Newobject30["minExtent"] = "8 2";
            oc_Newobject30["visible"] = "1";
            oc_Newobject30["active"] = "1";
            oc_Newobject30["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["canSaveDynamicFields"] = "1";
            // oc_Newobject30["class"] = "ESettingsWindowColor";
            oc_Newobject30["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject30["editorSettingsValue"] = "WorldEditor/Color/popupTextColor";
            oc_Newobject30["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject27["text"] = "Popup Text:";
            oc_Newobject27["maxLength"] = "1024";
            oc_Newobject27["margin"] = "0 0 0 0";
            oc_Newobject27["padding"] = "0 0 0 0";
            oc_Newobject27["anchorTop"] = "1";
            oc_Newobject27["anchorBottom"] = "0";
            oc_Newobject27["anchorLeft"] = "1";
            oc_Newobject27["anchorRight"] = "0";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject27["horizSizing"] = "right";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["position"] = "0 1";
            oc_Newobject27["extent"] = "70 16";
            oc_Newobject27["minExtent"] = "8 2";
            oc_Newobject27["visible"] = "1";
            oc_Newobject27["active"] = "1";
            oc_Newobject27["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject30["#Newobject27"] = oc_Newobject27;

            #region GuiTextEditCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject28["historySize"] = "0";
            oc_Newobject28["password"] = "0";
            oc_Newobject28["tabComplete"] = "0";
            oc_Newobject28["sinkAllKeyEvents"] = "0";
            oc_Newobject28["passwordMask"] = "*";
            oc_Newobject28["maxLength"] = "1024";
            oc_Newobject28["margin"] = "0 0 0 0";
            oc_Newobject28["padding"] = "0 0 0 0";
            oc_Newobject28["anchorTop"] = "1";
            oc_Newobject28["anchorBottom"] = "0";
            oc_Newobject28["anchorLeft"] = "1";
            oc_Newobject28["anchorRight"] = "0";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject28["horizSizing"] = "width";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["position"] = "80 0";
            oc_Newobject28["extent"] = "104 18";
            oc_Newobject28["minExtent"] = "8 2";
            oc_Newobject28["visible"] = "1";
            oc_Newobject28["active"] = "1";
            oc_Newobject28["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["internalName"] = "ColorEdit";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["canSaveDynamicFields"] = "1";
            //oc_Newobject28["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject30["#Newobject28"] = oc_Newobject28;

            #region GuiSwatchButtonCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject29["color"] = "1 1 1 1";
            oc_Newobject29["groupNum"] = "-1";
            oc_Newobject29["buttonType"] = "PushButton";
            oc_Newobject29["useMouseEvents"] = "0";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["horizSizing"] = "left";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["position"] = "188 2";
            oc_Newobject29["extent"] = "14 14";
            oc_Newobject29["minExtent"] = "8 2";
            oc_Newobject29["visible"] = "1";
            oc_Newobject29["active"] = "1";
            oc_Newobject29["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["internalName"] = "ColorButton";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["canSaveDynamicFields"] = "1";
            //oc_Newobject29["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject35["#Newobject30"] = oc_Newobject30;

            #region GuiControl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject34["isContainer"] = "1";
            oc_Newobject34["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject34["horizSizing"] = "right";
            oc_Newobject34["vertSizing"] = "bottom";
            oc_Newobject34["position"] = "5 70";
            oc_Newobject34["extent"] = "204 18";
            oc_Newobject34["minExtent"] = "8 2";
            oc_Newobject34["visible"] = "1";
            oc_Newobject34["active"] = "1";
            oc_Newobject34["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["canSaveDynamicFields"] = "1";
            //oc_Newobject34["class"] = "ESettingsWindowColor";
            oc_Newobject34["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject34["editorSettingsValue"] = "WorldEditor/Color/popupBackgroundColor";
            oc_Newobject34["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #region GuiTextCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject31["text"] = "Popup Back:";
            oc_Newobject31["maxLength"] = "1024";
            oc_Newobject31["margin"] = "0 0 0 0";
            oc_Newobject31["padding"] = "0 0 0 0";
            oc_Newobject31["anchorTop"] = "1";
            oc_Newobject31["anchorBottom"] = "0";
            oc_Newobject31["anchorLeft"] = "1";
            oc_Newobject31["anchorRight"] = "0";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["position"] = "0 1";
            oc_Newobject31["extent"] = "70 16";
            oc_Newobject31["minExtent"] = "8 2";
            oc_Newobject31["visible"] = "1";
            oc_Newobject31["active"] = "1";
            oc_Newobject31["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject34["#Newobject31"] = oc_Newobject31;

            #region GuiTextEditCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject32["historySize"] = "0";
            oc_Newobject32["password"] = "0";
            oc_Newobject32["tabComplete"] = "0";
            oc_Newobject32["sinkAllKeyEvents"] = "0";
            oc_Newobject32["passwordMask"] = "*";
            oc_Newobject32["maxLength"] = "1024";
            oc_Newobject32["margin"] = "0 0 0 0";
            oc_Newobject32["padding"] = "0 0 0 0";
            oc_Newobject32["anchorTop"] = "1";
            oc_Newobject32["anchorBottom"] = "0";
            oc_Newobject32["anchorLeft"] = "1";
            oc_Newobject32["anchorRight"] = "0";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject32["horizSizing"] = "width";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["position"] = "80 0";
            oc_Newobject32["extent"] = "104 18";
            oc_Newobject32["minExtent"] = "8 2";
            oc_Newobject32["visible"] = "1";
            oc_Newobject32["active"] = "1";
            oc_Newobject32["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["internalName"] = "ColorEdit";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["canSaveDynamicFields"] = "1";
            // oc_Newobject32["class"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject34["#Newobject32"] = oc_Newobject32;

            #region GuiSwatchButtonCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject33["color"] = "1 1 1 1";
            oc_Newobject33["groupNum"] = "-1";
            oc_Newobject33["buttonType"] = "PushButton";
            oc_Newobject33["useMouseEvents"] = "0";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject33["horizSizing"] = "left";
            oc_Newobject33["vertSizing"] = "bottom";
            oc_Newobject33["position"] = "188 2";
            oc_Newobject33["extent"] = "14 14";
            oc_Newobject33["minExtent"] = "8 2";
            oc_Newobject33["visible"] = "1";
            oc_Newobject33["active"] = "1";
            oc_Newobject33["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["internalName"] = "ColorButton";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["canSaveDynamicFields"] = "1";
            //oc_Newobject33["class"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject34["#Newobject33"] = oc_Newobject33;

            #endregion

            oc_Newobject35["#Newobject34"] = oc_Newobject34;

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject47["#Newobject36"] = oc_Newobject36;

            #region GuiRolloutCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject46["Profile"] = "GuiRolloutProfile";
            oc_Newobject46["HorizSizing"] = "right";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["position"] = "10 10";
            oc_Newobject46["extent"] = "208 95";
            oc_Newobject46["Caption"] = "Misc";
            oc_Newobject46["Margin"] = "0 3 0 0";
            oc_Newobject46["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject46["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject45["StackingType"] = "Vertical";
            oc_Newobject45["HorizStacking"] = "Left to Right";
            oc_Newobject45["VertStacking"] = "Top to Bottom";
            oc_Newobject45["Padding"] = "0";
            oc_Newobject45["isContainer"] = "1";
            oc_Newobject45["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject45["HorizSizing"] = "width";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["position"] = "0 0";
            oc_Newobject45["Extent"] = "208 0";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["isDecoy"] = "0";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["padding"] = "3";

            #region GuiControl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiControl", "");
            oc_Newobject38["isContainer"] = "1";
            oc_Newobject38["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject38["horizSizing"] = "right";
            oc_Newobject38["vertSizing"] = "bottom";
            oc_Newobject38["position"] = "0 0";
            oc_Newobject38["extent"] = "210 14";

            #region GuiCheckBoxCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject37["useInactiveState"] = "0";
            oc_Newobject37["text"] = "Force Load DAE";
            oc_Newobject37["groupNum"] = "-1";
            oc_Newobject37["buttonType"] = "ToggleButton";
            oc_Newobject37["useMouseEvents"] = "0";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject37["horizSizing"] = "right";
            oc_Newobject37["vertSizing"] = "bottom";
            oc_Newobject37["position"] = "5 0";
            oc_Newobject37["extent"] = "140 14";
            oc_Newobject37["minExtent"] = "8 2";
            oc_Newobject37["visible"] = "1";
            oc_Newobject37["active"] = "1";
            oc_Newobject37["variable"] = "EWorldEditor.forceLoadDAE";
            oc_Newobject37["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["canSaveDynamicFields"] = "1";
            //oc_Newobject37["class"] = "ESettingsWindowCheckbox";
            oc_Newobject37["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject37["editorSettingsValue"] = "WorldEditor/forceLoadDAE";
            oc_Newobject37["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject45["#Newobject38"] = oc_Newobject38;

            #region GuiControl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiControl", "");
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject41["horizSizing"] = "right";
            oc_Newobject41["vertSizing"] = "bottom";
            oc_Newobject41["position"] = "5 70";
            oc_Newobject41["extent"] = "210 18";

            #region GuiTextCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject39["text"] = "Screen Center Scalar:";
            oc_Newobject39["maxLength"] = "1024";
            oc_Newobject39["margin"] = "0 0 0 0";
            oc_Newobject39["padding"] = "0 0 0 0";
            oc_Newobject39["anchorTop"] = "1";
            oc_Newobject39["anchorBottom"] = "0";
            oc_Newobject39["anchorLeft"] = "1";
            oc_Newobject39["anchorRight"] = "0";
            oc_Newobject39["isContainer"] = "0";
            oc_Newobject39["profile"] = "ToolsGuiTextProfile";
            oc_Newobject39["horizSizing"] = "right";
            oc_Newobject39["vertSizing"] = "bottom";
            oc_Newobject39["position"] = "5 1";
            oc_Newobject39["extent"] = "110 16";
            oc_Newobject39["minExtent"] = "8 2";
            oc_Newobject39["visible"] = "1";
            oc_Newobject39["active"] = "1";
            oc_Newobject39["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject39"] = oc_Newobject39;

            #region GuiTextEditCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject40["historySize"] = "0";
            oc_Newobject40["password"] = "0";
            oc_Newobject40["tabComplete"] = "0";
            oc_Newobject40["sinkAllKeyEvents"] = "0";
            oc_Newobject40["passwordMask"] = "*";
            oc_Newobject40["maxLength"] = "1024";
            oc_Newobject40["margin"] = "0 0 0 0";
            oc_Newobject40["padding"] = "0 0 0 0";
            oc_Newobject40["anchorTop"] = "1";
            oc_Newobject40["anchorBottom"] = "0";
            oc_Newobject40["anchorLeft"] = "1";
            oc_Newobject40["anchorRight"] = "0";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject40["horizSizing"] = "width";
            oc_Newobject40["vertSizing"] = "bottom";
            oc_Newobject40["position"] = "120 0";
            oc_Newobject40["extent"] = "80 18";
            oc_Newobject40["minExtent"] = "8 2";
            oc_Newobject40["visible"] = "1";
            oc_Newobject40["active"] = "1";
            oc_Newobject40["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["canSaveDynamicFields"] = "1";
            //oc_Newobject40["class"] = "ESettingsWindowTextEdit";
            oc_Newobject40["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject40["editorSettingsValue"] = "WorldEditor/Tools/dropAtScreenCenterScalar";
            oc_Newobject40["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject45["#Newobject41"] = oc_Newobject41;

            #region GuiControl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiControl", "");
            oc_Newobject44["isContainer"] = "1";
            oc_Newobject44["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject44["horizSizing"] = "right";
            oc_Newobject44["vertSizing"] = "bottom";
            oc_Newobject44["position"] = "5 70";
            oc_Newobject44["extent"] = "210 18";

            #region GuiTextCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject42["text"] = "Screen Center Max:";
            oc_Newobject42["maxLength"] = "1024";
            oc_Newobject42["margin"] = "0 0 0 0";
            oc_Newobject42["padding"] = "0 0 0 0";
            oc_Newobject42["anchorTop"] = "1";
            oc_Newobject42["anchorBottom"] = "0";
            oc_Newobject42["anchorLeft"] = "1";
            oc_Newobject42["anchorRight"] = "0";
            oc_Newobject42["isContainer"] = "0";
            oc_Newobject42["profile"] = "ToolsGuiTextProfile";
            oc_Newobject42["horizSizing"] = "right";
            oc_Newobject42["vertSizing"] = "bottom";
            oc_Newobject42["position"] = "5 1";
            oc_Newobject42["extent"] = "110 16";
            oc_Newobject42["minExtent"] = "8 2";
            oc_Newobject42["visible"] = "1";
            oc_Newobject42["active"] = "1";
            oc_Newobject42["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject44["#Newobject42"] = oc_Newobject42;

            #region GuiTextEditCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject43["historySize"] = "0";
            oc_Newobject43["password"] = "0";
            oc_Newobject43["tabComplete"] = "0";
            oc_Newobject43["sinkAllKeyEvents"] = "0";
            oc_Newobject43["passwordMask"] = "*";
            oc_Newobject43["maxLength"] = "1024";
            oc_Newobject43["margin"] = "0 0 0 0";
            oc_Newobject43["padding"] = "0 0 0 0";
            oc_Newobject43["anchorTop"] = "1";
            oc_Newobject43["anchorBottom"] = "0";
            oc_Newobject43["anchorLeft"] = "1";
            oc_Newobject43["anchorRight"] = "0";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject43["horizSizing"] = "width";
            oc_Newobject43["vertSizing"] = "bottom";
            oc_Newobject43["position"] = "120 0";
            oc_Newobject43["extent"] = "80 18";
            oc_Newobject43["minExtent"] = "8 2";
            oc_Newobject43["visible"] = "1";
            oc_Newobject43["active"] = "1";
            oc_Newobject43["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["canSaveDynamicFields"] = "1";
            //oc_Newobject43["class"] = "ESettingsWindowTextEdit";
            oc_Newobject43["editorSettingsRead"] = "EditorGui.readWorldEditorSettings();";
            oc_Newobject43["editorSettingsValue"] = "WorldEditor/Tools/dropAtScreenCenterMax";
            oc_Newobject43["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject44["#Newobject43"] = oc_Newobject43;

            #endregion

            oc_Newobject45["#Newobject44"] = oc_Newobject44;

            #endregion

            oc_Newobject46["#Newobject45"] = oc_Newobject45;

            #endregion

            oc_Newobject47["#Newobject46"] = oc_Newobject46;

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject49["#Newobject48"] = oc_Newobject48;

            #endregion

            oc_Newobject50["#Newobject49"] = oc_Newobject49;

            #endregion

            oc_Newobject50.Create();
        }
    }
}