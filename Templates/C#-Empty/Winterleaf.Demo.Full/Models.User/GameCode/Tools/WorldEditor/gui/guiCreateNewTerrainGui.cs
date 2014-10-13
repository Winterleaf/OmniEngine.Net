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
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<guiCreateNewTerrainGui>))]
    public class guiCreateNewTerrainGui : GuiControl
    {
        [ConsoleInteraction(true, "guiCreateNewTerrainGui_initialize")]
        public static void initialize()
        {
            #region GuiControl (CreateNewTerrainGui, EditorGuiGroup)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "CreateNewTerrainGui, EditorGuiGroup", typeof (guiCreateNewTerrainGui));
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiOverlayProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "0 0";
            oc_Newobject12["Extent"] = "640 480";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["isDecoy"] = "0";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject11["HorizSizing"] = "center";
            oc_Newobject11["VertSizing"] = "center";
            oc_Newobject11["Position"] = "182 94";
            oc_Newobject11["Extent"] = "250 140";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "1";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "1";
            oc_Newobject11["resizeWidth"] = "0";
            oc_Newobject11["resizeHeight"] = "0";
            oc_Newobject11["canMove"] = "1";
            oc_Newobject11["canClose"] = "1";
            oc_Newobject11["canMinimize"] = "0";
            oc_Newobject11["canMaximize"] = "0";
            oc_Newobject11["minSize"] = "50 50";
            oc_Newobject11["closeCommand"] = "Canvas.popDialog( CreateNewTerrainGui );";
            oc_Newobject11["EdgeSnap"] = "0";
            oc_Newobject11["text"] = "Create New Terrain";

            #region GuiTextEditCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "theName";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "68 30";
            oc_Newobject1["Extent"] = "171 18";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["isDecoy"] = "0";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["historySize"] = "0";
            oc_Newobject1["password"] = "0";
            oc_Newobject1["tabComplete"] = "0";
            oc_Newobject1["sinkAllKeyEvents"] = "0";
            oc_Newobject1["text"] = "myNewTerrain";
            oc_Newobject1["passwordMask"] = "*";

            #endregion

            oc_Newobject11["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "32 31";
            oc_Newobject2["Extent"] = "31 16";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["text"] = "Name:";
            oc_Newobject2["maxLength"] = "1024";

            #endregion

            oc_Newobject11["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "10 108";
            oc_Newobject3["Extent"] = "138 24";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "CreateNewTerrainGui.create();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "Create New";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["accelerator"] = "return";

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "159 108";
            oc_Newobject4["Extent"] = "80 24";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "Canvas.popDialog( CreateNewTerrainGui );";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["text"] = "Cancel";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["accelerator"] = "escape";

            #endregion

            oc_Newobject11["#Newobject4"] = oc_Newobject4;

            #region GuiRadioCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiRadioCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "flatRadio";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiRadioProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "155 80";
            oc_Newobject5["Extent"] = "40 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = "Flat";
            oc_Newobject5["groupNum"] = "1";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["useInactiveState"] = "0";

            #endregion

            oc_Newobject11["#Newobject5"] = oc_Newobject5;

            #region GuiRadioCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiRadioCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "noiseRadio";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiRadioProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "195 80";
            oc_Newobject6["Extent"] = "45 18";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "Noise";
            oc_Newobject6["groupNum"] = "1";
            oc_Newobject6["buttonType"] = "RadioButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["useInactiveState"] = "0";

            #endregion

            oc_Newobject11["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "23 56";
            oc_Newobject7["Extent"] = "40 16";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["text"] = "Material: ";
            oc_Newobject7["maxLength"] = "1024";

            #endregion

            oc_Newobject11["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "10 81";
            oc_Newobject8["Extent"] = "52 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "Resolution:";
            oc_Newobject8["maxLength"] = "1024";

            #endregion

            oc_Newobject11["#Newobject8"] = oc_Newobject8;

            #region GuiPopUpMenuCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["internalName"] = "theRezList";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "68 80";
            oc_Newobject9["Extent"] = "57 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["isDecoy"] = "0";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["maxLength"] = "1024";
            oc_Newobject9["maxPopupHeight"] = "200";
            oc_Newobject9["sbUsesNAColor"] = "0";
            oc_Newobject9["reverseTextList"] = "0";
            oc_Newobject9["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiPopUpMenuCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "theMaterialList";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "68 55";
            oc_Newobject10["Extent"] = "171 18";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["isDecoy"] = "0";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["maxLength"] = "1024";
            oc_Newobject10["maxPopupHeight"] = "200";
            oc_Newobject10["sbUsesNAColor"] = "0";
            oc_Newobject10["reverseTextList"] = "0";
            oc_Newobject10["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject12.Create();
        }

        [ConsoleInteraction(true)]
        public override void onWake()
        {
            /*
   %this-->theName.setText( "" );

   %matList = %this-->theMaterialList;
   %matList.clear();
   %count = TerrainMaterialSet.getCount();
   for ( %i=0; %i < %count; %i++ )
      %matList.add( TerrainMaterialSet.getObject( %i ).internalName, %i );
   %matList.setSelected( 0 );
   
   %rezList = %this-->theRezList;
   %rezList.clear();
   %rezList.add( "256", 256 );
   %rezList.add( "512", 512 );
   %rezList.add( "1024", 1024 );
   %rezList.add( "2048", 2048 );
   //%rezList.add( "4096", 4096 );
   %rezList.setSelected( 256 );
   
   %this-->flatRadio.setStateOn( true );            
             */
            ((GuiTextEditCtrl) this.findObjectByInternalName("theName", true)).setText("");
            GuiPopUpMenuCtrl matList = this.findObjectByInternalName("theMaterialList", true);
            matList.clear();
            SimSet TerrainMaterialSet = "TerrainMaterialSet";
            int count = TerrainMaterialSet.getCount();
            for (uint i = 0; i < count; i++)
                matList.add(((SimObject) TerrainMaterialSet.getObject(i)).internalName, (int) i);
            matList.setSelected(0);

            GuiPopUpMenuCtrl rezList = this.findObjectByInternalName("theRezList", true);
            rezList.clear();
            rezList.add("256", 256);
            rezList.add("512", 512);
            rezList.add("1024", 1024);
            rezList.add("2048", 2048);

            rezList.setSelected(256);

            ((GuiRadioCtrl) this.findObjectByInternalName("flatRadio", true)).setStateOn(true);
        }

        [ConsoleInteraction]
        public void create()
        {
            /*
            %terrainName = %this-->theName.getText();   
               %resolution = %this-->theRezList.getSelected();
               %materialName = %this-->theMaterialList.getText();
               %genNoise = %this-->noiseRadio.getValue();

               %obj = TerrainBlock::createNew( %terrainName, %resolution, %materialName, %genNoise );
   
               if( %genNoise )
                  ETerrainEditor.isDirty = true;

               if( isObject( %obj ) )
               {
                  // Submit an undo action. 
                  MECreateUndoAction::submit(%obj);
   
                  assert( isObject( EWorldEditor ), 
                     "ObjectBuilderGui::processNewObject - EWorldEditor is missing!" );

                  // Select it in the editor.
                  EWorldEditor.clearSelection();
                  EWorldEditor.selectObject(%obj);

                  // When we drop the selection don't store undo
                  // state for it... the creation deals with it.
                  EWorldEditor.dropSelection( true );
               }

               Canvas.popDialog( %this );
            */

            string terrainName = ((GuiTextEditCtrl) this.findObjectByInternalName("theName", true)).getText();
            GuiPopUpMenuCtrl rezList = this.findObjectByInternalName("theRezList", true);
            GuiPopUpMenuCtrl matList = this.findObjectByInternalName("theMaterialList", true);
            string resolution = rezList.getSelected().AsString();
            string materialName = matList.getText();
            string genNoise = ((GuiRadioCtrl) this.findObjectByInternalName("noiseRadio", true)).getValue();

            TerrainBlock obj = console.Eval("TerrainBlock::createNew(\"" + terrainName + "\",\"" + resolution + "\",\"" + materialName + "\",\"" + genNoise + "\");", true);
            if (genNoise.AsBool())
                ((SimObject) "ETerrainEditor")["isDirty"] = "1";

            if (obj.isObject())
                {
                EWorldEditor EWorldEditor = "EWorldEditor";
                // Submit an undo action. 
                Extendable.MECreateUndoAction.submit(obj);
                // Select it in the editor.
                EWorldEditor.clearSelection();
                EWorldEditor.selectObject(obj);

                // When we drop the selection don't store undo
                // state for it... the creation deals with it.

                EWorldEditor.dropSelection(true);
                }
            ((GuiCanvas) "Canvas").popDialog(this);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(guiCreateNewTerrainGui ts, string simobjectid)
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
        public static bool operator !=(guiCreateNewTerrainGui ts, string simobjectid)
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
        public static implicit operator string(guiCreateNewTerrainGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator guiCreateNewTerrainGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (guiCreateNewTerrainGui) Omni.self.getSimObject(simobjectid, typeof (guiCreateNewTerrainGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(guiCreateNewTerrainGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator guiCreateNewTerrainGui(int simobjectid)
        {
            return (guiCreateNewTerrainGui) Omni.self.getSimObject((uint) simobjectid, typeof (guiCreateNewTerrainGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(guiCreateNewTerrainGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator guiCreateNewTerrainGui(uint simobjectid)
        {
            return (guiCreateNewTerrainGui) Omni.self.getSimObject(simobjectid, typeof (guiCreateNewTerrainGui));
        }

        #endregion
    }
}