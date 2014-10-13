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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui
{
    public class MeshRoadEditorSettingsTab
    {
        [ConsoleInteraction(true, "MeshRoadEditorSettingsTab_initialize")]
        public static void initialize()
        {
            #region GuiControl (MeshRoadEditorSettingsTab,EditorGuiGroup)        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiControl", "MeshRoadEditorSettingsTab,EditorGuiGroup");
            oc_Newobject34["isContainer"] = "1";
            oc_Newobject34["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["position"] = "0 0";
            oc_Newobject34["Extent"] = "208 600";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (EMeshRoadEditorSettingsPage)        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiTabPageCtrl", "EMeshRoadEditorSettingsPage");
            oc_Newobject33["fitBook"] = "1";
            oc_Newobject33["text"] = "Mesh Road Editor";
            oc_Newobject33["maxLength"] = "1024";
            oc_Newobject33["Margin"] = "0 0 0 0";
            oc_Newobject33["Padding"] = "0 0 0 0";
            oc_Newobject33["AnchorTop"] = "1";
            oc_Newobject33["AnchorBottom"] = "0";
            oc_Newobject33["AnchorLeft"] = "1";
            oc_Newobject33["AnchorRight"] = "0";
            oc_Newobject33["isContainer"] = "1";
            oc_Newobject33["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject33["HorizSizing"] = "width";
            oc_Newobject33["VertSizing"] = "height";
            oc_Newobject33["position"] = "0 0";
            oc_Newobject33["Extent"] = "208 400";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject32["willFirstRespond"] = "1";
            oc_Newobject32["hScrollBar"] = "alwaysOff";
            oc_Newobject32["vScrollBar"] = "dynamic";
            oc_Newobject32["lockHorizScroll"] = "1";
            oc_Newobject32["lockVertScroll"] = "0";
            oc_Newobject32["constantThumbHeight"] = "0";
            oc_Newobject32["childMargin"] = "0 0";
            oc_Newobject32["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject32["Margin"] = "0 0 0 0";
            oc_Newobject32["Padding"] = "0 0 0 0";
            oc_Newobject32["AnchorTop"] = "1";
            oc_Newobject32["AnchorBottom"] = "0";
            oc_Newobject32["AnchorLeft"] = "1";
            oc_Newobject32["AnchorRight"] = "0";
            oc_Newobject32["isContainer"] = "1";
            oc_Newobject32["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject32["HorizSizing"] = "width";
            oc_Newobject32["VertSizing"] = "height";
            oc_Newobject32["position"] = "0 0";
            oc_Newobject32["Extent"] = "208 400";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject31["StackingType"] = "Vertical";
            oc_Newobject31["HorizStacking"] = "Left to Right";
            oc_Newobject31["VertStacking"] = "Top to Bottom";
            oc_Newobject31["Padding"] = "0";
            oc_Newobject31["isContainer"] = "1";
            oc_Newobject31["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["HorizSizing"] = "width";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = "1 1";
            oc_Newobject31["extent"] = "208 210";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["isDecoy"] = "0";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject31["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject20["Profile"] = "GuiRolloutProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "10 10";
            oc_Newobject20["extent"] = "208 95";
            oc_Newobject20["Caption"] = "Defaults";
            oc_Newobject20["Margin"] = "0 3 0 0";
            oc_Newobject20["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject20["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject19["StackingType"] = "Vertical";
            oc_Newobject19["HorizStacking"] = "Left to Right";
            oc_Newobject19["VertStacking"] = "Top to Bottom";
            oc_Newobject19["Padding"] = "0";
            oc_Newobject19["isContainer"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "0 0";
            oc_Newobject19["Extent"] = "208 0";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["isDecoy"] = "0";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["padding"] = "3";

            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Width:";
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
            oc_Newobject2["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject2["editorSettingsValue"] = "MeshRoadEditor/DefaultWidth";
            oc_Newobject2["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject19["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Depth:";
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
            oc_Newobject5["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject5["editorSettingsValue"] = "MeshRoadEditor/DefaultDepth";
            oc_Newobject5["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject19["#Newobject6"] = oc_Newobject6;

            #region GuiControl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "Normal:";
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
            oc_Newobject7["Extent"] = "70 14";
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
            oc_Newobject8["Profile"] = "ToolsGuiTextEditProfile";
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
            oc_Newobject8["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject8["editorSettingsValue"] = "MeshRoadEditor/DefaultNormal";
            oc_Newobject8["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject19["#Newobject9"] = oc_Newobject9;

            #region GuiControl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "");
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["text"] = "Top Material:";
            oc_Newobject10["maxLength"] = "1024";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "5 1";
            oc_Newobject10["Extent"] = "70 16";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiTextEditCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject11["historySize"] = "0";
            oc_Newobject11["password"] = "0";
            oc_Newobject11["tabComplete"] = "0";
            oc_Newobject11["sinkAllKeyEvents"] = "0";
            oc_Newobject11["passwordMask"] = "*";
            oc_Newobject11["maxLength"] = "1024";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "81 0";
            oc_Newobject11["Extent"] = "121 18";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSaveDynamicFields"] = "1";
            //oc_Newobject11["class"] = "ESettingsWindowTextEdit";
            //oc_Newobject11["className"] = "ESettingsWindowTextEdit";
            oc_Newobject11["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject11["editorSettingsValue"] = "MeshRoadEditor/TopMaterialName";
            oc_Newobject11["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject19["#Newobject12"] = oc_Newobject12;

            #region GuiControl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiControl", "");
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["text"] = "Bottom Material:";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "5 1";
            oc_Newobject13["Extent"] = "70 16";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject15["#Newobject13"] = oc_Newobject13;

            #region GuiTextEditCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject14["historySize"] = "0";
            oc_Newobject14["password"] = "0";
            oc_Newobject14["tabComplete"] = "0";
            oc_Newobject14["sinkAllKeyEvents"] = "0";
            oc_Newobject14["passwordMask"] = "*";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "81 0";
            oc_Newobject14["Extent"] = "121 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSaveDynamicFields"] = "1";
            //oc_Newobject14["class"] = "ESettingsWindowTextEdit";
            //oc_Newobject14["className"] = "ESettingsWindowTextEdit";
            oc_Newobject14["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject14["editorSettingsValue"] = "MeshRoadEditor/BottomMaterialName";
            oc_Newobject14["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject19["#Newobject15"] = oc_Newobject15;

            #region GuiControl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiControl", "");
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["extent"] = "208 18";

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["text"] = "Side Material:";
            oc_Newobject16["maxLength"] = "1024";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "5 1";
            oc_Newobject16["Extent"] = "70 16";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject18["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowTextEdit));
            oc_Newobject17["historySize"] = "0";
            oc_Newobject17["password"] = "0";
            oc_Newobject17["tabComplete"] = "0";
            oc_Newobject17["sinkAllKeyEvents"] = "0";
            oc_Newobject17["passwordMask"] = "*";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "81 0";
            oc_Newobject17["Extent"] = "121 18";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSaveDynamicFields"] = "1";
            //oc_Newobject17["class"] = "ESettingsWindowTextEdit";
            // oc_Newobject17["className"] = "ESettingsWindowTextEdit";
            oc_Newobject17["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject17["editorSettingsValue"] = "MeshRoadEditor/SideMaterialName";
            oc_Newobject17["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject19["#Newobject18"] = oc_Newobject18;

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject31["#Newobject20"] = oc_Newobject20;

            #region GuiRolloutCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject30["Profile"] = "GuiRolloutProfile";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = "10 10";
            oc_Newobject30["extent"] = "208 95";
            oc_Newobject30["Caption"] = "Colors";
            oc_Newobject30["Margin"] = "0 3 0 0";
            oc_Newobject30["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject30["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject29["StackingType"] = "Vertical";
            oc_Newobject29["HorizStacking"] = "Left to Right";
            oc_Newobject29["VertStacking"] = "Top to Bottom";
            oc_Newobject29["Padding"] = "0";
            oc_Newobject29["isContainer"] = "1";
            oc_Newobject29["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["HorizSizing"] = "width";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = "0 0";
            oc_Newobject29["Extent"] = "208 0";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["isDecoy"] = "0";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["padding"] = "3";

            #region GuiControl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject24["isContainer"] = "1";
            oc_Newobject24["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["extent"] = "208 18";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["canSaveDynamicFields"] = "1";
            //oc_Newobject24["class"] = "ESettingsWindowColor";
            //oc_Newobject24["className"] = "ESettingsWindowColor";
            oc_Newobject24["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject24["editorSettingsValue"] = "MeshRoadEditor/HoverSplineColor";
            oc_Newobject24["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject21["text"] = "Hover Spline:";
            oc_Newobject21["maxLength"] = "1024";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["position"] = "4 2";
            oc_Newobject21["extent"] = "70 14";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject24["#Newobject21"] = oc_Newobject21;

            #region GuiTextEditCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject22["historySize"] = "0";
            oc_Newobject22["password"] = "0";
            oc_Newobject22["tabComplete"] = "0";
            oc_Newobject22["sinkAllKeyEvents"] = "0";
            oc_Newobject22["passwordMask"] = "*";
            oc_Newobject22["maxLength"] = "1024";
            oc_Newobject22["Margin"] = "0 0 0 0";
            oc_Newobject22["Padding"] = "0 0 0 0";
            oc_Newobject22["AnchorTop"] = "1";
            oc_Newobject22["AnchorBottom"] = "0";
            oc_Newobject22["AnchorLeft"] = "1";
            oc_Newobject22["AnchorRight"] = "0";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject22["horizSizing"] = "width";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["position"] = "80 0";
            oc_Newobject22["extent"] = "104 18";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["internalName"] = "ColorEdit";
            oc_Newobject22["canSaveDynamicFields"] = "1";
            //oc_Newobject22["class"] = "ESettingsWindowColorEdit";
            //oc_Newobject22["className"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject24["#Newobject22"] = oc_Newobject22;

            #region GuiSwatchButtonCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject23["color"] = "1 1 1 1";
            oc_Newobject23["groupNum"] = "-1";
            oc_Newobject23["buttonType"] = "PushButton";
            oc_Newobject23["useMouseEvents"] = "0";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["horizSizing"] = "left";
            oc_Newobject23["vertSizing"] = "bottom";
            oc_Newobject23["position"] = "188 2";
            oc_Newobject23["extent"] = "14 14";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["internalName"] = "ColorButton";
            oc_Newobject23["canSaveDynamicFields"] = "1";
            //oc_Newobject23["class"] = "ESettingsWindowColorButton";
            //oc_Newobject23["className"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject24["#Newobject23"] = oc_Newobject23;

            #endregion

            oc_Newobject29["#Newobject24"] = oc_Newobject24;

            #region GuiControl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiControl", "", typeof (ESettingsWindow.ESettingsWindowColor));
            oc_Newobject28["isContainer"] = "1";
            oc_Newobject28["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["position"] = "0 0";
            oc_Newobject28["extent"] = "208 18";
            oc_Newobject28["MinExtent"] = "8 2";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["canSaveDynamicFields"] = "1";
            //oc_Newobject28["class"] = "ESettingsWindowColor";
            //oc_Newobject28["className"] = "ESettingsWindowColor";
            oc_Newobject28["editorSettingsRead"] = "MeshRoadEditorPlugin.readSettings();";
            oc_Newobject28["editorSettingsValue"] = "MeshRoadEditor/SelectedSplineColor";
            oc_Newobject28["editorSettingsWrite"] = "MeshRoadEditorPlugin.writeSettings();";

            #region GuiTextCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject25["text"] = "Sel. Spline:";
            oc_Newobject25["maxLength"] = "1024";
            oc_Newobject25["Margin"] = "0 0 0 0";
            oc_Newobject25["Padding"] = "0 0 0 0";
            oc_Newobject25["AnchorTop"] = "1";
            oc_Newobject25["AnchorBottom"] = "0";
            oc_Newobject25["AnchorLeft"] = "1";
            oc_Newobject25["AnchorRight"] = "0";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject25["horizSizing"] = "right";
            oc_Newobject25["vertSizing"] = "bottom";
            oc_Newobject25["position"] = "4 2";
            oc_Newobject25["extent"] = "70 14";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["canSaveDynamicFields"] = "1";

            #endregion

            oc_Newobject28["#Newobject25"] = oc_Newobject25;

            #region GuiTextEditCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiTextEditCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorEdit));
            oc_Newobject26["historySize"] = "0";
            oc_Newobject26["password"] = "0";
            oc_Newobject26["tabComplete"] = "0";
            oc_Newobject26["sinkAllKeyEvents"] = "0";
            oc_Newobject26["passwordMask"] = "*";
            oc_Newobject26["maxLength"] = "1024";
            oc_Newobject26["Margin"] = "0 0 0 0";
            oc_Newobject26["Padding"] = "0 0 0 0";
            oc_Newobject26["AnchorTop"] = "1";
            oc_Newobject26["AnchorBottom"] = "0";
            oc_Newobject26["AnchorLeft"] = "1";
            oc_Newobject26["AnchorRight"] = "0";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject26["horizSizing"] = "width";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["position"] = "80 0";
            oc_Newobject26["extent"] = "104 18";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["internalName"] = "ColorEdit";
            oc_Newobject26["canSaveDynamicFields"] = "1";
            //oc_Newobject26["class"] = "ESettingsWindowColorEdit";
            //oc_Newobject26["className"] = "ESettingsWindowColorEdit";

            #endregion

            oc_Newobject28["#Newobject26"] = oc_Newobject26;

            #region GuiSwatchButtonCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiSwatchButtonCtrl", "", typeof (ESettingsWindow.ESettingsWindowColorButton));
            oc_Newobject27["color"] = "1 1 1 1";
            oc_Newobject27["groupNum"] = "-1";
            oc_Newobject27["buttonType"] = "PushButton";
            oc_Newobject27["useMouseEvents"] = "0";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject27["horizSizing"] = "left";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["position"] = "188 2";
            oc_Newobject27["extent"] = "14 14";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["internalName"] = "ColorButton";
            oc_Newobject27["canSaveDynamicFields"] = "1";
            // oc_Newobject27["class"] = "ESettingsWindowColorButton";
            // oc_Newobject27["className"] = "ESettingsWindowColorButton";

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject29["#Newobject28"] = oc_Newobject28;

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject32["#Newobject31"] = oc_Newobject31;

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject34["#Newobject33"] = oc_Newobject33;

            #endregion

            oc_Newobject34.Create();
        }
    }
}