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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using Creator = WinterLeaf.Engine.Classes.View.Creators.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<CameraSettingsTab>))]
    public class CameraSettingsTab : GuiTabPageCtrl
    {
        [ConsoleInteraction(true, "CameraSettingsTab_initialize")]
        public static void initialize()
        {
            #region GuiControl (CameraSettingsTab,EditorGuiGroup)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "CameraSettingsTab,EditorGuiGroup");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["Extent"] = "800 600";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "1";

            #region GuiTabPageCtrl (ECameraSettingsPage)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTabPageCtrl", "ECameraSettingsPage", typeof (CameraSettingsTab));
            oc_Newobject8["fitBook"] = "1";
            oc_Newobject8["text"] = "Camera Settings";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "245 568";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "1";

            #region GuiScrollCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject7["willFirstRespond"] = "1";
            oc_Newobject7["hScrollBar"] = "alwaysOff";
            oc_Newobject7["vScrollBar"] = "dynamic";
            oc_Newobject7["lockHorizScroll"] = "1";
            oc_Newobject7["lockVertScroll"] = "0";
            oc_Newobject7["constantThumbHeight"] = "0";
            oc_Newobject7["childMargin"] = "0 0";
            oc_Newobject7["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "height";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["Extent"] = "245 568";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject6["internalName"] = "content";
            oc_Newobject6["StackingType"] = "Vertical";
            oc_Newobject6["HorizStacking"] = "Left to Right";
            oc_Newobject6["VertStacking"] = "Top to Bottom";
            oc_Newobject6["Padding"] = "0";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "1 1";
            oc_Newobject6["extent"] = "245 210";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiRolloutCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiRolloutCtrl", "");
            oc_Newobject5["Profile"] = "GuiRolloutProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "10 10";
            oc_Newobject5["extent"] = "208 95";
            oc_Newobject5["Caption"] = "Mouse Control";
            oc_Newobject5["Margin"] = "0 0 0 -3";
            oc_Newobject5["DragSizable"] = new Creator.StringNoQuote("false");
            oc_Newobject5["container"] = new Creator.StringNoQuote("true");

            #region GuiStackControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject4["StackingType"] = "Vertical";
            oc_Newobject4["HorizStacking"] = "Left to Right";
            oc_Newobject4["VertStacking"] = "Top to Bottom";
            oc_Newobject4["Padding"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "0 0";
            oc_Newobject4["Extent"] = "208 0";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";

            #region GuiContainer ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiContainer", "");
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "-1 0";
            oc_Newobject3["Extent"] = "208 41";
            oc_Newobject3["Docking"] = "none";

            #region GuiCheckBoxCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject1["useInactiveState"] = "0";
            oc_Newobject1["text"] = "Invert Y Axis";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "ToggleButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 5";
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
            oc_Newobject1["editorSettingsValue"] = "Camera/invertYAxis";
            oc_Newobject1["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiCheckBoxCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiCheckBoxCtrl", "", typeof (ESettingsWindow.ESettingsWindowCheckbox));
            oc_Newobject2["useInactiveState"] = "0";
            oc_Newobject2["text"] = "Invert X Axis";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "ToggleButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "5 22";
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
            oc_Newobject2["editorSettingsValue"] = "Camera/invertXAxis";
            oc_Newobject2["editorSettingsWrite"] = "EditorGui.writeWorldEditorSettings();";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
        }

        [ConsoleInteraction]
        public void init()
        {
            Settings EditorSettings = "EditorSettings";

            this["currentLevel"] = "";
            this["currentRolloutCtrl"] = "";

            string levelInfoPath = "LevelInformation/levels";
            for (string fieldName = EditorSettings.findFirstValue(levelInfoPath, true, true); fieldName != ""; fieldName = EditorSettings.findNextValue())
                {
                int fieldSlashPos = 0;
                int levelSlashPos = 0;
                while (Util.strpos(fieldName, "/", fieldSlashPos) != -1)
                    {
                    levelSlashPos = fieldSlashPos;

                    int temp = Util.strpos(fieldName, "/", fieldSlashPos);
                    fieldSlashPos = temp + 1;
                    }
                string levelName = Util.getSubStr(fieldName, levelSlashPos, ((fieldSlashPos - levelSlashPos) - 1));

                GuiStackControl content = this.FOT("content");
                bool alreadyExist = false;
                for (uint i = 0; i < content.getCount(); i++)
                    {
                    alreadyExist = false;
                    if (((SimObject) content.getObject(i))["caption"] == levelName)
                        {
                        alreadyExist = true;
                        break;
                        }
                    }

                if (this["currentLevel"] != levelName && !alreadyExist)
                    {
                    //Hold current level and reset gui params
                    this["currentLevel"] = levelName;
                    //%this.currentLevel = "\""@%levelName@"\"";

                    //Create and hold current rollout ctrl

                    #region GuiRolloutCtrl ()        oc_Newobject20

                    ObjectCreator oc_Newobject20 = new ObjectCreator("GuiRolloutCtrl", "");
                    oc_Newobject20["Profile"] = "GuiRolloutProfile";
                    oc_Newobject20["HorizSizing"] = "width";
                    oc_Newobject20["VertSizing"] = "bottom";
                    oc_Newobject20["position"] = "10 10";
                    oc_Newobject20["extent"] = "208 95";
                    oc_Newobject20["Caption"] = levelName;
                    oc_Newobject20["Margin"] = "0 0 0 -3";
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

                    #region GuiContainer ()        oc_Newobject10

                    ObjectCreator oc_Newobject10 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject10["HorizSizing"] = "right";
                    oc_Newobject10["VertSizing"] = "bottom";
                    oc_Newobject10["Position"] = "0 0";
                    oc_Newobject10["Extent"] = "208 2";

                    #endregion

                    oc_Newobject19["#Newobject10"] = oc_Newobject10;

                    #region GuiContainer ()        oc_Newobject13

                    ObjectCreator oc_Newobject13 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject13["HorizSizing"] = "right";
                    oc_Newobject13["VertSizing"] = "bottom";
                    oc_Newobject13["Position"] = "0 0";
                    oc_Newobject13["Extent"] = "208 22";
                    oc_Newobject13["Docking"] = "none";

                    #region GuiTextCtrl ()        oc_Newobject11

                    ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject11["text"] = "Camera Speed Min:";
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
                    oc_Newobject11["position"] = "5 3";
                    oc_Newobject11["extent"] = "96 16";
                    oc_Newobject11["minExtent"] = "8 2";
                    oc_Newobject11["visible"] = "1";
                    oc_Newobject11["active"] = "1";
                    oc_Newobject11["tooltipProfile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject11["hovertime"] = "1000";
                    oc_Newobject11["canSave"] = "1";
                    oc_Newobject11["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject13["#Newobject11"] = oc_Newobject11;

                    #region GuiTextEditCtrl ()        oc_Newobject12

                    ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextEditCtrl", "");
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
                    oc_Newobject12["profile"] = "ToolsGuiNumericTextEditProfile";
                    oc_Newobject12["horizSizing"] = "width";
                    oc_Newobject12["vertSizing"] = "bottom";
                    oc_Newobject12["position"] = "106 2";
                    oc_Newobject12["extent"] = "95 18";
                    oc_Newobject12["minExtent"] = "8 2";
                    oc_Newobject12["visible"] = "1";
                    oc_Newobject12["active"] = "1";
                    oc_Newobject12["tooltipProfile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject12["hovertime"] = "1000";
                    oc_Newobject12["canSave"] = "1";
                    oc_Newobject12["canSaveDynamicFields"] = "1";
                    oc_Newobject12["class"] = "ESettingsWindowTextEdit";
                    oc_Newobject12["editorSettingsRead"] = "EditorGui.readCameraSettings( \\\"" + levelName + "\\\" );";
                    oc_Newobject12["editorSettingsValue"] = "LevelInformation/levels/" + levelName + "/cameraSpeedMin";
                    oc_Newobject12["editorSettingsWrite"] = "EditorGui.writeCameraSettings( \\\"" + levelName + "\\\" );";

                    #endregion

                    oc_Newobject13["#Newobject12"] = oc_Newobject12;

                    #endregion

                    oc_Newobject19["#Newobject13"] = oc_Newobject13;

                    #region GuiContainer ()        oc_Newobject16

                    ObjectCreator oc_Newobject16 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject16["HorizSizing"] = "right";
                    oc_Newobject16["VertSizing"] = "bottom";
                    oc_Newobject16["Position"] = "0 0";
                    oc_Newobject16["Extent"] = "208 22";
                    oc_Newobject16["Docking"] = "none";

                    #region GuiTextCtrl ()        oc_Newobject14

                    ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
                    oc_Newobject14["text"] = "Camera Speed Max:";
                    oc_Newobject14["maxLength"] = "1024";
                    oc_Newobject14["margin"] = "0 0 0 0";
                    oc_Newobject14["padding"] = "0 0 0 0";
                    oc_Newobject14["anchorTop"] = "1";
                    oc_Newobject14["anchorBottom"] = "0";
                    oc_Newobject14["anchorLeft"] = "1";
                    oc_Newobject14["anchorRight"] = "0";
                    oc_Newobject14["isContainer"] = "0";
                    oc_Newobject14["profile"] = "ToolsGuiTextRightProfile";
                    oc_Newobject14["horizSizing"] = "right";
                    oc_Newobject14["vertSizing"] = "bottom";
                    oc_Newobject14["position"] = "5 3";
                    oc_Newobject14["extent"] = "96 16";
                    oc_Newobject14["minExtent"] = "8 2";
                    oc_Newobject14["visible"] = "1";
                    oc_Newobject14["active"] = "1";
                    oc_Newobject14["tooltipProfile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject14["hovertime"] = "1000";
                    oc_Newobject14["canSave"] = "1";
                    oc_Newobject14["canSaveDynamicFields"] = "0";

                    #endregion

                    oc_Newobject16["#Newobject14"] = oc_Newobject14;

                    #region GuiTextEditCtrl ()        oc_Newobject15

                    ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "");
                    oc_Newobject15["historySize"] = "0";
                    oc_Newobject15["password"] = "0";
                    oc_Newobject15["tabComplete"] = "0";
                    oc_Newobject15["sinkAllKeyEvents"] = "0";
                    oc_Newobject15["passwordMask"] = "*";
                    oc_Newobject15["maxLength"] = "1024";
                    oc_Newobject15["margin"] = "0 0 0 0";
                    oc_Newobject15["padding"] = "0 0 0 0";
                    oc_Newobject15["anchorTop"] = "1";
                    oc_Newobject15["anchorBottom"] = "0";
                    oc_Newobject15["anchorLeft"] = "1";
                    oc_Newobject15["anchorRight"] = "0";
                    oc_Newobject15["isContainer"] = "0";
                    oc_Newobject15["profile"] = "ToolsGuiNumericTextEditProfile";
                    oc_Newobject15["horizSizing"] = "width";
                    oc_Newobject15["vertSizing"] = "bottom";
                    oc_Newobject15["position"] = "106 2";
                    oc_Newobject15["extent"] = "95 18";
                    oc_Newobject15["minExtent"] = "8 2";
                    oc_Newobject15["visible"] = "1";
                    oc_Newobject15["active"] = "1";
                    oc_Newobject15["tooltipProfile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject15["hovertime"] = "1000";
                    oc_Newobject15["canSave"] = "1";
                    oc_Newobject15["canSaveDynamicFields"] = "1";
                    oc_Newobject15["class"] = "ESettingsWindowTextEdit";
                    oc_Newobject15["editorSettingsRead"] = "EditorGui.readCameraSettings( \\\"" + levelName + "\\\" );";
                    oc_Newobject15["editorSettingsValue"] = "LevelInformation/levels/" + levelName + "/cameraSpeedMax";
                    oc_Newobject15["editorSettingsWrite"] = "EditorGui.writeCameraSettings( \\\"" + levelName + "\\\" );";

                    #endregion

                    oc_Newobject16["#Newobject15"] = oc_Newobject15;

                    #endregion

                    oc_Newobject19["#Newobject16"] = oc_Newobject16;

                    #region GuiContainer ()        oc_Newobject18

                    ObjectCreator oc_Newobject18 = new ObjectCreator("GuiContainer", "");
                    oc_Newobject18["HorizSizing"] = "right";
                    oc_Newobject18["VertSizing"] = "bottom";
                    oc_Newobject18["Position"] = "0 0";
                    oc_Newobject18["Extent"] = "208 24";
                    oc_Newobject18["Docking"] = "none";

                    #region GuiButtonCtrl ()        oc_Newobject17

                    ObjectCreator oc_Newobject17 = new ObjectCreator("GuiButtonCtrl", "");
                    oc_Newobject17["canSaveDynamicFields"] = "0";
                    oc_Newobject17["Enabled"] = "1";
                    oc_Newobject17["isContainer"] = "0";
                    oc_Newobject17["HorizSizing"] = "width";
                    oc_Newobject17["VertSizing"] = "bottom";
                    oc_Newobject17["Position"] = "5 2";
                    oc_Newobject17["Extent"] = "196 18";
                    oc_Newobject17["MinExtent"] = "8 8";
                    oc_Newobject17["canSave"] = "1";
                    oc_Newobject17["isDecoy"] = "0";
                    oc_Newobject17["Visible"] = "1";
                    oc_Newobject17["Command"] = "ECameraSettingsPage.deleteCameraSettingsGroup(\\\"" + levelName + "\\\", $ThisControl.getParent().getParent().getParent());";
                    oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
                    oc_Newobject17["hovertime"] = "1000";
                    oc_Newobject17["text"] = "Delete Level Settings";
                    oc_Newobject17["groupNum"] = "-1";
                    oc_Newobject17["buttonType"] = "PushButton";
                    oc_Newobject17["useMouseEvents"] = "1";

                    #endregion

                    oc_Newobject18["#Newobject17"] = oc_Newobject17;

                    #endregion

                    oc_Newobject19["#Newobject18"] = oc_Newobject18;

                    #endregion

                    oc_Newobject20["#Newobject19"] = oc_Newobject19;

                    #endregion

                    this["currentRolloutCtrl"] = oc_Newobject20.Create().AsString();
                    content.add(this["currentRolloutCtrl"]);
                    }
                }
        }

        [ConsoleInteraction(true)]
        public void deleteCameraSettingsGroup(string levelName, GuiControl rolloutCtrl)
        {
            Settings EditorSettings = "EditorSettings";
            if (levelName == ((EditorGui) "EditorGui")["levelName"])
                {
                messageBox.MessageBoxOK("Error", "You may not delete the settings group associated with the currently loaded level");
                return;
                }

            string levelInfoPath = "LevelInformation/levels/" + levelName;
            string fieldname = EditorSettings.findFirstValue(levelInfoPath, true, true);
            while (fieldname != "")
                {
                EditorSettings.remove(fieldname, true);
                fieldname = EditorSettings.findNextValue();
                }
            rolloutCtrl.delete();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CameraSettingsTab ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(CameraSettingsTab ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(CameraSettingsTab ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator CameraSettingsTab(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (CameraSettingsTab) Omni.self.getSimObject(simobjectid, typeof (CameraSettingsTab));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CameraSettingsTab ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CameraSettingsTab(int simobjectid)
        {
            return (CameraSettingsTab) Omni.self.getSimObject((uint) simobjectid, typeof (CameraSettingsTab));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CameraSettingsTab ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CameraSettingsTab(uint simobjectid)
        {
            return (CameraSettingsTab) Omni.self.getSimObject(simobjectid, typeof (CameraSettingsTab));
        }

        #endregion
    }
}