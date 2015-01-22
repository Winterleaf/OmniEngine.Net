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
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    public class ManageSFXParametersWindow
    {
        [ConsoleInteraction(true, "ManageSFXParametersWindow_initialize")]
        public static void initialize()
        {
            //=============================================================================
            //    Constants.
            //=============================================================================

            // File to save newly created SFXParameters in by default.
            pInvokes.sGlobal["$SFX_PARAMETER_FILE"] = "scripts/client/audioData.cs";

            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[0]"] = "Volume";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[1]"] = "Pitch";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[2]"] = "Priority";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[3]"] = "MinDistance";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[4]"] = "MaxDistance";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[5]"] = "ConeInsideAngle";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[6]"] = "ConeOutsideAngle";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[7]"] = "ConeOutsideVolume";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[8]"] = "PositionX";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[9]"] = "PositionY";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[10]"] = "PositionZ";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[11]"] = "RotationX";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[12]"] = "RotationY";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[13]"] = "RotationZ";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[14]"] = "VelocityX";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[15]"] = "VelocityY";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[16]"] = "VelocityZ";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[17]"] = "Cursor";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[18]"] = "User0";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[19]"] = "User1";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[20]"] = "User2";
            pInvokes.sGlobal["$SFX_PARAMETER_CHANNELS[21]"] = "User3";

            pInvokes.iGlobal["$SFX_PARAMETER_CHANNELS_COUNT"] = 22;

            // Interval (in milliseconds) between GUI updates.  Each update
            // syncs the displayed values to the actual parameter states.

            pInvokes.iGlobal["$SFX_PARAMETERS_UPDATE_INTERVAL"] = 50;

            #region GuiControl (ManageSFXParametersContainer,EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "ManageSFXParametersContainer,EditorGuiGroup");
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiModelessDialogProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["Extent"] = "1024 768";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "1";
            oc_Newobject10["enabled"] = "1";
            oc_Newobject10["isDecoy"] = "0";

            #region GuiWindowCollapseCtrl (EManageSFXParameters)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiWindowCollapseCtrl", "EManageSFXParameters", typeof (EManageSFXParameters));
            oc_Newobject9["AllowPopWindow"] = "1";
            oc_Newobject9["CollapseGroup"] = "-1";
            oc_Newobject9["CollapseGroupNum"] = "-1";
            oc_Newobject9["resizeWidth"] = "1";
            oc_Newobject9["resizeHeight"] = "1";
            oc_Newobject9["canMove"] = "1";
            oc_Newobject9["canClose"] = "1";
            oc_Newobject9["canMinimize"] = "0";
            oc_Newobject9["canMaximize"] = "0";
            oc_Newobject9["minSize"] = "50 50";
            oc_Newobject9["closeCommand"] = "EManageSFXParameters.setVisible( false );";
            oc_Newobject9["EdgeSnap"] = "0";
            oc_Newobject9["text"] = "Audio Parameters";
            oc_Newobject9["Margin"] = "5 5 5 5";
            oc_Newobject9["Padding"] = "5 5 5 5";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject9["HorizSizing"] = "windowRelative";
            oc_Newobject9["VertSizing"] = "windowRelative";
            oc_Newobject9["position"] = "49 68";
            oc_Newobject9["Extent"] = "446 392";
            oc_Newobject9["MinExtent"] = "120 130";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["internalName"] = "ManageSFXParametersWindow";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "4 23";
            oc_Newobject6["Extent"] = "484 20";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Name";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "1 2";
            oc_Newobject1["Extent"] = "29 17";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["passwordMask"] = "•";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "36 2";
            oc_Newobject2["Extent"] = "226 17";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["internalName"] = "AddSFXParameterName";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["bitmap"] = "tools/gui/images/new";
            oc_Newobject3["autoFit"] = "0";
            oc_Newobject3["text"] = "Create";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "left";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "266 2";
            oc_Newobject3["Extent"] = "17 17";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "EManageSFXParameters.createNewParameter( EManageSFXParameters-->AddSFXParameterName.getText() );";
            oc_Newobject3["Accelerator"] = "return";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Create New SFX Parameter";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiPopUpMenuCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject4["maxPopupHeight"] = "200";
            oc_Newobject4["sbUsesNAColor"] = "0";
            oc_Newobject4["reverseTextList"] = "0";
            oc_Newobject4["bitmapBounds"] = "16 16";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject4["HorizSizing"] = "left";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "325 1";
            oc_Newobject4["Extent"] = "113 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "EManageSFXParameters.initList( $ThisControl.getText() );";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["internalName"] = "SFXParameterFilter";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Filter";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "296 2";
            oc_Newobject5["Extent"] = "24 17";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiScrollCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject8["willFirstRespond"] = "1";
            oc_Newobject8["hScrollBar"] = "alwaysOff";
            oc_Newobject8["vScrollBar"] = "dynamic";
            oc_Newobject8["lockHorizScroll"] = "1";
            oc_Newobject8["lockVertScroll"] = "0";
            oc_Newobject8["constantThumbHeight"] = "0";
            oc_Newobject8["childMargin"] = "2 2";
            oc_Newobject8["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "4 46";
            oc_Newobject8["Extent"] = "438 344";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiStackControl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject7["StackingType"] = "Vertical";
            oc_Newobject7["HorizStacking"] = "Left to Right";
            oc_Newobject7["VertStacking"] = "Top to Bottom";
            oc_Newobject7["Padding"] = "2";
            oc_Newobject7["DynamicSize"] = "1";
            oc_Newobject7["ChangeChildSizeToFit"] = "1";
            oc_Newobject7["ChangeChildPosition"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "3 3";
            oc_Newobject7["Extent"] = "419 10008";
            oc_Newobject7["MinExtent"] = "16 16";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["internalName"] = "SFXParametersStack";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();
        }
    }
}