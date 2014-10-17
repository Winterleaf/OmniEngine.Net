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
    public class TerrainEditPalette
    {
        public static uint initialize()
        {
            #region GuiControl (TerrainEditorPalette,EditorGuiGroup)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiControl", "TerrainEditorPalette,EditorGuiGroup");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "0 0";
            oc_Newobject11["Extent"] = "1024 768";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["internalName"] = "brushAdjustHeight";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "72 0";
            oc_Newobject1["Extent"] = "25 19";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "ETerrainEditor.switchAction( brushAdjustHeight );";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Grab Terrain (1)";
            oc_Newobject1["hovertime"] = "750";
            oc_Newobject1["text"] = "Button";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["bitmap"] = "tools/worldEditor/images/brushAdjustHeight";

            #endregion

            oc_Newobject11["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["internalName"] = "raiseHeight";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["Extent"] = "25 19";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "ETerrainEditor.switchAction( raiseHeight );";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Raise Height (2)";
            oc_Newobject2["hovertime"] = "750";
            oc_Newobject2["text"] = "Button";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/raiseHeight";

            #endregion

            oc_Newobject11["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "lowerHeight";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "36 0";
            oc_Newobject3["Extent"] = "25 19";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "ETerrainEditor.switchAction( lowerHeight );";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Lower Height (3)";
            oc_Newobject3["hovertime"] = "750";
            oc_Newobject3["text"] = "Button";
            oc_Newobject3["buttonType"] = "RadioButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/lowerHeight";

            #endregion

            oc_Newobject11["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "smoothHeight";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "144 0";
            oc_Newobject4["Extent"] = "25 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "ETerrainEditor.switchAction( smoothHeight );";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Smooth (4)";
            oc_Newobject4["hovertime"] = "750";
            oc_Newobject4["text"] = "Button";
            oc_Newobject4["buttonType"] = "RadioButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/smoothHeight";

            #endregion

            oc_Newobject11["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "smoothSlope";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "GuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "144 0";
            oc_Newobject5["Extent"] = "25 19";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ETerrainEditor.switchAction( smoothSlope );";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Smooth Slope (5)";
            oc_Newobject5["hovertime"] = "750";
            oc_Newobject5["text"] = "Button";
            oc_Newobject5["buttonType"] = "RadioButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["bitmap"] = "tools/worldEditor/images/softCurve";

            #endregion

            oc_Newobject11["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "paintNoise";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "72 36";
            oc_Newobject6["Extent"] = "25 19";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "ETerrainEditor.switchAction( paintNoise );";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Paint Noise (6)";
            oc_Newobject6["hovertime"] = "750";
            oc_Newobject6["text"] = "Button";
            oc_Newobject6["buttonType"] = "RadioButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["bitmap"] = "tools/worldEditor/images/brushPaintNoise";

            #endregion

            oc_Newobject11["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "flattenHeight";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "108 0";
            oc_Newobject7["Extent"] = "25 19";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ETerrainEditor.switchAction( flattenHeight );";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Flatten (7)";
            oc_Newobject7["hovertime"] = "750";
            oc_Newobject7["text"] = "Button";
            oc_Newobject7["buttonType"] = "RadioButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["bitmap"] = "tools/worldEditor/images/flattenHeight";

            #endregion

            oc_Newobject11["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["internalName"] = "setHeight";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "180 0";
            oc_Newobject8["Extent"] = "25 19";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "ETerrainEditor.switchAction( setHeight );";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Set Height (8)";
            oc_Newobject8["hovertime"] = "750";
            oc_Newobject8["text"] = "Button";
            oc_Newobject8["buttonType"] = "RadioButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["bitmap"] = "tools/worldEditor/images/setHeight";

            #endregion

            oc_Newobject11["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["internalName"] = "setEmpty";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 36";
            oc_Newobject9["Extent"] = "25 19";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "ETerrainEditor.switchAction( setEmpty );";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Clear Terrain (9)";
            oc_Newobject9["hovertime"] = "750";
            oc_Newobject9["text"] = "Button";
            oc_Newobject9["buttonType"] = "RadioButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["bitmap"] = "tools/worldEditor/images/setEmpty";

            #endregion

            oc_Newobject11["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "clearEmpty";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "36 36";
            oc_Newobject10["Extent"] = "25 19";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["Command"] = "ETerrainEditor.switchAction( clearEmpty );";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["ToolTip"] = "Restore Terrain (0)";
            oc_Newobject10["hovertime"] = "750";
            oc_Newobject10["text"] = "Button";
            oc_Newobject10["buttonType"] = "RadioButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["bitmap"] = "tools/worldEditor/images/clearEmpty";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            return oc_Newobject11.Create();
        }
    }
}