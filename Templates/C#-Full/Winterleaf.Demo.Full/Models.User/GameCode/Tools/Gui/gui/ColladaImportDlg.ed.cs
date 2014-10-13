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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ColladaImportDlg>))]
    public class ColladaImportDlg : GuiControl
    {

        internal string path
        {
            get { return this["path"]; }
            set { this["path"] = value; }
        }

        internal string cmd
        {
            get { return this["cmd"]; }
            set { this["cmd"] = value; }
        }

        public SimObject constructor
        {
            get { return this["constructor"]; }
            set { this["constructor"] = value; }
        }

        [ConsoleInteraction(true, "ColladaImportDlg_initialize")]
        public static void initialize()
        {
            #region GuiControl (ColladaImportDlg,EditorGuiGroup)        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiControl", "ColladaImportDlg,EditorGuiGroup", typeof (ColladaImportDlg));
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject48["HorizSizing"] = "width";
            oc_Newobject48["VertSizing"] = "height";
            oc_Newobject48["position"] = "0 0";
            oc_Newobject48["Extent"] = "1024 768";
            oc_Newobject48["MinExtent"] = "8 2";
            oc_Newobject48["canSave"] = "1";
            oc_Newobject48["Visible"] = "1";
            oc_Newobject48["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["canSaveDynamicFields"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject47["resizeWidth"] = "0";
            oc_Newobject47["resizeHeight"] = "0";
            oc_Newobject47["canMove"] = "1";
            oc_Newobject47["canClose"] = "1";
            oc_Newobject47["canMinimize"] = "0";
            oc_Newobject47["canMaximize"] = "0";
            oc_Newobject47["minSize"] = "50 50";
            oc_Newobject47["closeCommand"] = "Canvas.popDialog(ColladaImportDlg);";
            oc_Newobject47["EdgeSnap"] = "1";
            oc_Newobject47["text"] = "";
            oc_Newobject47["Margin"] = "0 0 0 0";
            oc_Newobject47["Padding"] = "0 0 0 0";
            oc_Newobject47["AnchorTop"] = "1";
            oc_Newobject47["AnchorBottom"] = "0";
            oc_Newobject47["AnchorLeft"] = "1";
            oc_Newobject47["AnchorRight"] = "0";
            oc_Newobject47["isContainer"] = "1";
            oc_Newobject47["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject47["HorizSizing"] = "center";
            oc_Newobject47["VertSizing"] = "center";
            oc_Newobject47["position"] = "254 136";
            oc_Newobject47["Extent"] = "516 447";
            oc_Newobject47["MinExtent"] = "8 8";
            oc_Newobject47["canSave"] = "1";
            oc_Newobject47["Visible"] = "1";
            oc_Newobject47["Accelerator"] = "escape";
            oc_Newobject47["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["internalName"] = "window";
            oc_Newobject47["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["position"] = "8 24";
            oc_Newobject3["Extent"] = "238 417";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "dynamic";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "0";
            oc_Newobject2["lockVertScroll"] = "0";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "0 3";
            oc_Newobject2["Extent"] = "238 366";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "1";

            #region GuiTreeViewCtrl (ColladaImportTreeView)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "ColladaImportTreeView", typeof (ColladaImportTreeView));
            oc_Newobject1["tabSize"] = "16";
            oc_Newobject1["textOffset"] = "2";
            oc_Newobject1["fullRowSelect"] = "0";
            oc_Newobject1["itemHeight"] = "21";
            oc_Newobject1["destroyTreeOnSleep"] = "0";
            oc_Newobject1["MouseDragging"] = "0";
            oc_Newobject1["MultipleSelections"] = "0";
            oc_Newobject1["DeleteObjectAllowed"] = "0";
            oc_Newobject1["DragToItemAllowed"] = "0";
            oc_Newobject1["ClearAllOnSingleSelection"] = "1";
            oc_Newobject1["showRoot"] = "1";
            oc_Newobject1["internalNamesOnly"] = "0";
            oc_Newobject1["objectNamesOnly"] = "0";
            oc_Newobject1["useInspectorTooltips"] = "0";
            oc_Newobject1["tooltipOnWidthOnly"] = "0";
            oc_Newobject1["compareToObjectID"] = "1";
            oc_Newobject1["canRenameObjects"] = "1";
            oc_Newobject1["renameInternal"] = "0";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["position"] = "1 1";
            oc_Newobject1["Extent"] = "74 63";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject47["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiControl", "");
            oc_Newobject46["isContainer"] = "1";
            oc_Newobject46["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "height";
            oc_Newobject46["position"] = "254 24";
            oc_Newobject46["Extent"] = "254 417";
            oc_Newobject46["MinExtent"] = "8 2";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["Visible"] = "1";
            oc_Newobject46["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["canSaveDynamicFields"] = "0";

            #region GuiBitmapBorderCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "0 3";
            oc_Newobject16["Extent"] = "254 60";
            oc_Newobject16["MinExtent"] = "8 8";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Nodes";
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
            oc_Newobject4["position"] = "42 2";
            oc_Newobject4["Extent"] = "32 16";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "90 2";
            oc_Newobject5["Extent"] = "60 16";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["internalName"] = "nodes";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "Meshes";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "36 22";
            oc_Newobject6["Extent"] = "38 16";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["text"] = "";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "90 22";
            oc_Newobject7["Extent"] = "60 16";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["internalName"] = "meshes";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["text"] = "Polygons";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "132 22";
            oc_Newobject8["Extent"] = "47 16";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["text"] = "";
            oc_Newobject9["maxLength"] = "1024";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "193 22";
            oc_Newobject9["Extent"] = "60 16";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["internalName"] = "polygons";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["text"] = "Materials";
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
            oc_Newobject10["position"] = "135 2";
            oc_Newobject10["Extent"] = "44 16";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject10"] = oc_Newobject10;

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["text"] = "";
            oc_Newobject11["maxLength"] = "1024";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "193 2";
            oc_Newobject11["Extent"] = "60 16";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["internalName"] = "Materials";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["text"] = "Lights";
            oc_Newobject12["maxLength"] = "1024";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["position"] = "23 41";
            oc_Newobject12["Extent"] = "52 16";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject12"] = oc_Newobject12;

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["text"] = "";
            oc_Newobject13["maxLength"] = "1024";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "91 41";
            oc_Newobject13["Extent"] = "60 16";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["internalName"] = "lights";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject13"] = oc_Newobject13;

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["text"] = "Animations";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "127 41";
            oc_Newobject14["Extent"] = "52 16";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject14"] = oc_Newobject14;

            #region GuiTextCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject15["text"] = "";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["Margin"] = "0 0 0 0";
            oc_Newobject15["Padding"] = "0 0 0 0";
            oc_Newobject15["AnchorTop"] = "1";
            oc_Newobject15["AnchorBottom"] = "0";
            oc_Newobject15["AnchorLeft"] = "1";
            oc_Newobject15["AnchorRight"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "191 41";
            oc_Newobject15["Extent"] = "60 16";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["internalName"] = "animations";
            oc_Newobject15["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject46["#Newobject16"] = oc_Newobject16;

            #region GuiBitmapBorderCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject30["isContainer"] = "1";
            oc_Newobject30["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = "0 68";
            oc_Newobject30["Extent"] = "254 153";
            oc_Newobject30["MinExtent"] = "8 8";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject17["text"] = "LOD";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "59 6";
            oc_Newobject17["Extent"] = "22 16";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject17"] = oc_Newobject17;

            #region GuiPopUpMenuCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject18["maxPopupHeight"] = "200";
            oc_Newobject18["sbUsesNAColor"] = "0";
            oc_Newobject18["reverseTextList"] = "0";
            oc_Newobject18["bitmapBounds"] = "16 16";
            oc_Newobject18["text"] = "DetectDTS";
            oc_Newobject18["maxLength"] = "1024";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "97 6";
            oc_Newobject18["Extent"] = "92 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject18["ToolTip"] = "Method used to determine LOD for meshes in the model";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["internalName"] = "lodType";
            oc_Newobject18["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject18"] = oc_Newobject18;

            #region GuiTextEditCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject19["historySize"] = "0";
            oc_Newobject19["password"] = "0";
            oc_Newobject19["tabComplete"] = "0";
            oc_Newobject19["sinkAllKeyEvents"] = "0";
            oc_Newobject19["passwordMask"] = "*";
            oc_Newobject19["text"] = "";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["Margin"] = "0 0 0 0";
            oc_Newobject19["Padding"] = "0 0 0 0";
            oc_Newobject19["AnchorTop"] = "1";
            oc_Newobject19["AnchorBottom"] = "0";
            oc_Newobject19["AnchorLeft"] = "1";
            oc_Newobject19["AnchorRight"] = "0";
            oc_Newobject19["isContainer"] = "0";
            oc_Newobject19["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "196 6";
            oc_Newobject19["Extent"] = "49 18";
            oc_Newobject19["MinExtent"] = "8 2";
            oc_Newobject19["canSave"] = "1";
            oc_Newobject19["Visible"] = "1";
            oc_Newobject19["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject19["ToolTip"] = "Detail size for all meshes in this model (when LOD type is SingleSize)";
            oc_Newobject19["hovertime"] = "1000";
            oc_Newobject19["internalName"] = "singleDetailSize";
            oc_Newobject19["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject19"] = oc_Newobject19;

            #region GuiTextCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject20["text"] = "Materials Prefix";
            oc_Newobject20["maxLength"] = "1024";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "11 32";
            oc_Newobject20["Extent"] = "73 16";
            oc_Newobject20["MinExtent"] = "8 2";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject20"] = oc_Newobject20;

            #region GuiTextEditCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject21["historySize"] = "0";
            oc_Newobject21["password"] = "0";
            oc_Newobject21["tabComplete"] = "0";
            oc_Newobject21["sinkAllKeyEvents"] = "0";
            oc_Newobject21["passwordMask"] = "*";
            oc_Newobject21["maxLength"] = "1024";
            oc_Newobject21["Margin"] = "0 0 0 0";
            oc_Newobject21["Padding"] = "0 0 0 0";
            oc_Newobject21["AnchorTop"] = "1";
            oc_Newobject21["AnchorBottom"] = "0";
            oc_Newobject21["AnchorLeft"] = "1";
            oc_Newobject21["AnchorRight"] = "0";
            oc_Newobject21["isContainer"] = "0";
            oc_Newobject21["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject21["HorizSizing"] = "right";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "97 32";
            oc_Newobject21["Extent"] = "148 18";
            oc_Newobject21["MinExtent"] = "8 2";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["AltCommand"] = "ColladaImportTreeView.refresh(\\\"materials\\\");";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["internalName"] = "materialPrefix";
            oc_Newobject21["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject21"] = oc_Newobject21;

            #region GuiTextCtrl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject22["text"] = "Import Nodes";
            oc_Newobject22["maxLength"] = "1024";
            oc_Newobject22["Margin"] = "0 0 0 0";
            oc_Newobject22["Padding"] = "0 0 0 0";
            oc_Newobject22["AnchorTop"] = "1";
            oc_Newobject22["AnchorBottom"] = "0";
            oc_Newobject22["AnchorLeft"] = "1";
            oc_Newobject22["AnchorRight"] = "0";
            oc_Newobject22["isContainer"] = "0";
            oc_Newobject22["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject22["HorizSizing"] = "right";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["position"] = "13 58";
            oc_Newobject22["Extent"] = "72 16";
            oc_Newobject22["MinExtent"] = "8 2";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject22"] = oc_Newobject22;

            #region GuiTextEditCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject23["historySize"] = "0";
            oc_Newobject23["password"] = "0";
            oc_Newobject23["tabComplete"] = "0";
            oc_Newobject23["sinkAllKeyEvents"] = "0";
            oc_Newobject23["passwordMask"] = "*";
            oc_Newobject23["maxLength"] = "1024";
            oc_Newobject23["Margin"] = "0 0 0 0";
            oc_Newobject23["Padding"] = "0 0 0 0";
            oc_Newobject23["AnchorTop"] = "1";
            oc_Newobject23["AnchorBottom"] = "0";
            oc_Newobject23["AnchorLeft"] = "1";
            oc_Newobject23["AnchorRight"] = "0";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject23["HorizSizing"] = "right";
            oc_Newobject23["VertSizing"] = "bottom";
            oc_Newobject23["position"] = "97 58";
            oc_Newobject23["Extent"] = "148 18";
            oc_Newobject23["MinExtent"] = "8 2";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["AltCommand"] = "ColladaImportTreeView.refresh(\\\"nodes\\\");";
            oc_Newobject23["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["internalName"] = "alwaysImport";
            oc_Newobject23["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject23"] = oc_Newobject23;

            #region GuiTextCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject24["text"] = "Ignore Nodes";
            oc_Newobject24["maxLength"] = "1024";
            oc_Newobject24["Margin"] = "0 0 0 0";
            oc_Newobject24["Padding"] = "0 0 0 0";
            oc_Newobject24["AnchorTop"] = "1";
            oc_Newobject24["AnchorBottom"] = "0";
            oc_Newobject24["AnchorLeft"] = "1";
            oc_Newobject24["AnchorRight"] = "0";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "20 82";
            oc_Newobject24["Extent"] = "65 16";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject24"] = oc_Newobject24;

            #region GuiTextEditCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject25["historySize"] = "0";
            oc_Newobject25["password"] = "0";
            oc_Newobject25["tabComplete"] = "0";
            oc_Newobject25["sinkAllKeyEvents"] = "0";
            oc_Newobject25["passwordMask"] = "*";
            oc_Newobject25["maxLength"] = "1024";
            oc_Newobject25["Margin"] = "0 0 0 0";
            oc_Newobject25["Padding"] = "0 0 0 0";
            oc_Newobject25["AnchorTop"] = "1";
            oc_Newobject25["AnchorBottom"] = "0";
            oc_Newobject25["AnchorLeft"] = "1";
            oc_Newobject25["AnchorRight"] = "0";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "bottom";
            oc_Newobject25["position"] = "97 82";
            oc_Newobject25["Extent"] = "148 18";
            oc_Newobject25["MinExtent"] = "8 2";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["AltCommand"] = "ColladaImportTreeView.refresh(\\\"nodes\\\");";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["internalName"] = "neverImport";
            oc_Newobject25["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject25"] = oc_Newobject25;

            #region GuiTextCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject26["text"] = "Import Meshes";
            oc_Newobject26["maxLength"] = "1024";
            oc_Newobject26["Margin"] = "0 0 0 0";
            oc_Newobject26["Padding"] = "0 0 0 0";
            oc_Newobject26["AnchorTop"] = "1";
            oc_Newobject26["AnchorBottom"] = "0";
            oc_Newobject26["AnchorLeft"] = "1";
            oc_Newobject26["AnchorRight"] = "0";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["position"] = "13 106";
            oc_Newobject26["Extent"] = "72 16";
            oc_Newobject26["MinExtent"] = "8 2";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject26"] = oc_Newobject26;

            #region GuiTextEditCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject27["historySize"] = "0";
            oc_Newobject27["password"] = "0";
            oc_Newobject27["tabComplete"] = "0";
            oc_Newobject27["sinkAllKeyEvents"] = "0";
            oc_Newobject27["passwordMask"] = "*";
            oc_Newobject27["maxLength"] = "1024";
            oc_Newobject27["Margin"] = "0 0 0 0";
            oc_Newobject27["Padding"] = "0 0 0 0";
            oc_Newobject27["AnchorTop"] = "1";
            oc_Newobject27["AnchorBottom"] = "0";
            oc_Newobject27["AnchorLeft"] = "1";
            oc_Newobject27["AnchorRight"] = "0";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = "97 106";
            oc_Newobject27["Extent"] = "148 18";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["AltCommand"] = "ColladaImportTreeView.refresh(\\\"nodes\\\");";
            oc_Newobject27["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["internalName"] = "alwaysImportMesh";
            oc_Newobject27["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject27"] = oc_Newobject27;

            #region GuiTextCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject28["text"] = "Ignore Meshes";
            oc_Newobject28["maxLength"] = "1024";
            oc_Newobject28["Margin"] = "0 0 0 0";
            oc_Newobject28["Padding"] = "0 0 0 0";
            oc_Newobject28["AnchorTop"] = "1";
            oc_Newobject28["AnchorBottom"] = "0";
            oc_Newobject28["AnchorLeft"] = "1";
            oc_Newobject28["AnchorRight"] = "0";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject28["HorizSizing"] = "right";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["position"] = "13 130";
            oc_Newobject28["Extent"] = "72 16";
            oc_Newobject28["MinExtent"] = "8 2";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["Visible"] = "1";
            oc_Newobject28["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject28"] = oc_Newobject28;

            #region GuiTextEditCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject29["historySize"] = "0";
            oc_Newobject29["password"] = "0";
            oc_Newobject29["tabComplete"] = "0";
            oc_Newobject29["sinkAllKeyEvents"] = "0";
            oc_Newobject29["passwordMask"] = "*";
            oc_Newobject29["maxLength"] = "1024";
            oc_Newobject29["Margin"] = "0 0 0 0";
            oc_Newobject29["Padding"] = "0 0 0 0";
            oc_Newobject29["AnchorTop"] = "1";
            oc_Newobject29["AnchorBottom"] = "0";
            oc_Newobject29["AnchorLeft"] = "1";
            oc_Newobject29["AnchorRight"] = "0";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = "97 130";
            oc_Newobject29["Extent"] = "148 18";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["AltCommand"] = "ColladaImportTreeView.refresh(\\\"nodes\\\");";
            oc_Newobject29["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["internalName"] = "neverImportMesh";
            oc_Newobject29["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject46["#Newobject30"] = oc_Newobject30;

            #region GuiBitmapBorderCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject39["HorizSizing"] = "right";
            oc_Newobject39["VertSizing"] = "bottom";
            oc_Newobject39["position"] = "0 226";
            oc_Newobject39["Extent"] = "254 105";
            oc_Newobject39["MinExtent"] = "8 8";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["Visible"] = "1";
            oc_Newobject39["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["canSaveDynamicFields"] = "0";

            #region GuiCheckBoxCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject31["useInactiveState"] = "0";
            oc_Newobject31["text"] = " Override up_axis";
            oc_Newobject31["groupNum"] = "-1";
            oc_Newobject31["buttonType"] = "ToggleButton";
            oc_Newobject31["useMouseEvents"] = "0";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject31["HorizSizing"] = "right";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = "11 7";
            oc_Newobject31["Extent"] = "102 13";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["Command"] = "ColladaImportDlg.updateOverrideUpAxis($ThisControl.getValue());";
            oc_Newobject31["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject31["ToolTip"] = "Overrides the <up_axis> specified in the DAE file";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["internalName"] = "overrideUpAxis";
            oc_Newobject31["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject31"] = oc_Newobject31;

            #region GuiPopUpMenuCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject32["maxPopupHeight"] = "200";
            oc_Newobject32["sbUsesNAColor"] = "0";
            oc_Newobject32["reverseTextList"] = "0";
            oc_Newobject32["bitmapBounds"] = "16 16";
            oc_Newobject32["maxLength"] = "1024";
            oc_Newobject32["Margin"] = "0 0 0 0";
            oc_Newobject32["Padding"] = "0 0 0 0";
            oc_Newobject32["AnchorTop"] = "1";
            oc_Newobject32["AnchorBottom"] = "0";
            oc_Newobject32["AnchorLeft"] = "1";
            oc_Newobject32["AnchorRight"] = "0";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject32["HorizSizing"] = "right";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["position"] = "151 6";
            oc_Newobject32["Extent"] = "66 18";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["internalName"] = "upAxis";
            oc_Newobject32["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject32"] = oc_Newobject32;

            #region GuiCheckBoxCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject33["useInactiveState"] = "0";
            oc_Newobject33["text"] = " Override scale";
            oc_Newobject33["groupNum"] = "-1";
            oc_Newobject33["buttonType"] = "ToggleButton";
            oc_Newobject33["useMouseEvents"] = "0";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject33["HorizSizing"] = "right";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["position"] = "11 27";
            oc_Newobject33["Extent"] = "92 13";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["Command"] = "ColladaImportDlg.updateOverrideScale($ThisControl.getValue());";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["ToolTip"] = "Overrides the <unit> scale specified in the DAE file";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["internalName"] = "overrideScale";
            oc_Newobject33["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject33"] = oc_Newobject33;

            #region GuiTextEditCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject34["historySize"] = "0";
            oc_Newobject34["password"] = "0";
            oc_Newobject34["tabComplete"] = "0";
            oc_Newobject34["sinkAllKeyEvents"] = "0";
            oc_Newobject34["passwordMask"] = "*";
            oc_Newobject34["text"] = "";
            oc_Newobject34["maxLength"] = "1024";
            oc_Newobject34["Margin"] = "0 0 0 0";
            oc_Newobject34["Padding"] = "0 0 0 0";
            oc_Newobject34["AnchorTop"] = "1";
            oc_Newobject34["AnchorBottom"] = "0";
            oc_Newobject34["AnchorLeft"] = "1";
            oc_Newobject34["AnchorRight"] = "0";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject34["HorizSizing"] = "right";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["position"] = "151 27";
            oc_Newobject34["Extent"] = "66 18";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["internalName"] = "scale";
            oc_Newobject34["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject34"] = oc_Newobject34;

            #region GuiCheckBoxCtrl ()        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject35["useInactiveState"] = "0";
            oc_Newobject35["text"] = " Ignore bone scaling";
            oc_Newobject35["groupNum"] = "-1";
            oc_Newobject35["buttonType"] = "ToggleButton";
            oc_Newobject35["useMouseEvents"] = "0";
            oc_Newobject35["isContainer"] = "0";
            oc_Newobject35["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject35["HorizSizing"] = "right";
            oc_Newobject35["VertSizing"] = "bottom";
            oc_Newobject35["position"] = "11 48";
            oc_Newobject35["Extent"] = "114 13";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "1";
            oc_Newobject35["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject35["ToolTip"] = "Ignores <scale> elements within <node>s to fix issues with some models";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["internalName"] = "ignoreNodeScale";
            oc_Newobject35["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject35"] = oc_Newobject35;

            #region GuiCheckBoxCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject36["useInactiveState"] = "0";
            oc_Newobject36["text"] = " Center model";
            oc_Newobject36["groupNum"] = "-1";
            oc_Newobject36["buttonType"] = "ToggleButton";
            oc_Newobject36["useMouseEvents"] = "0";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject36["HorizSizing"] = "right";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["position"] = "11 67";
            oc_Newobject36["Extent"] = "82 13";
            oc_Newobject36["MinExtent"] = "8 2";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["Visible"] = "1";
            oc_Newobject36["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject36["ToolTip"] = "Translates model so the origin is at the center";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["internalName"] = "adjustCenter";
            oc_Newobject36["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject36"] = oc_Newobject36;

            #region GuiCheckBoxCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject37["useInactiveState"] = "0";
            oc_Newobject37["text"] = " Floor model";
            oc_Newobject37["groupNum"] = "-1";
            oc_Newobject37["buttonType"] = "ToggleButton";
            oc_Newobject37["useMouseEvents"] = "0";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject37["HorizSizing"] = "right";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["position"] = "151 67";
            oc_Newobject37["Extent"] = "72 13";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject37["ToolTip"] = "Translates model so the origin is at the bottom";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["internalName"] = "adjustFloor";
            oc_Newobject37["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject37"] = oc_Newobject37;

            #region GuiCheckBoxCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject38["useInactiveState"] = "0";
            oc_Newobject38["text"] = " Force update materials.cs";
            oc_Newobject38["groupNum"] = "-1";
            oc_Newobject38["buttonType"] = "ToggleButton";
            oc_Newobject38["useMouseEvents"] = "0";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject38["HorizSizing"] = "right";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["position"] = "11 86";
            oc_Newobject38["Extent"] = "148 13";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject38["ToolTip"] = "Forces update of materials.cs (even if Materials already exist)";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["internalName"] = "forceUpdateMaterials";
            oc_Newobject38["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject46["#Newobject39"] = oc_Newobject39;

            #region GuiBitmapBorderCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject41["isContainer"] = "1";
            oc_Newobject41["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["position"] = "0 338";
            oc_Newobject41["Extent"] = "254 24";
            oc_Newobject41["MinExtent"] = "8 8";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["canSaveDynamicFields"] = "0";

            #region GuiCheckBoxCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject40["useInactiveState"] = "0";
            oc_Newobject40["text"] = " Add lights to scene";
            oc_Newobject40["groupNum"] = "-1";
            oc_Newobject40["buttonType"] = "ToggleButton";
            oc_Newobject40["useMouseEvents"] = "0";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject40["HorizSizing"] = "right";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["position"] = "11 5";
            oc_Newobject40["Extent"] = "148 13";
            oc_Newobject40["MinExtent"] = "8 2";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["ToolTip"] = "Loads the lights from the DAE file and adds them to the current scene.";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["internalName"] = "loadLights";
            oc_Newobject40["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject41["#Newobject40"] = oc_Newobject40;

            #endregion

            oc_Newobject46["#Newobject41"] = oc_Newobject41;

            #region GuiButtonCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject42["text"] = "Load from .cfg";
            oc_Newobject42["groupNum"] = "-1";
            oc_Newobject42["buttonType"] = "PushButton";
            oc_Newobject42["useMouseEvents"] = "0";
            oc_Newobject42["isContainer"] = "0";
            oc_Newobject42["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject42["HorizSizing"] = "right";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["position"] = "11 368";
            oc_Newobject42["Extent"] = "86 22";
            oc_Newobject42["MinExtent"] = "8 2";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["Command"] = "ColladaImportDlg.readDtsConfig();";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject46["#Newobject42"] = oc_Newobject42;

            #region GuiButtonCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject43["text"] = "Save to .cfg";
            oc_Newobject43["groupNum"] = "-1";
            oc_Newobject43["buttonType"] = "PushButton";
            oc_Newobject43["useMouseEvents"] = "0";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject43["HorizSizing"] = "right";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["position"] = "11 395";
            oc_Newobject43["Extent"] = "86 22";
            oc_Newobject43["MinExtent"] = "8 2";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["Visible"] = "1";
            oc_Newobject43["Command"] = "ColladaImportDlg.writeDtsConfig();";
            oc_Newobject43["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject46["#Newobject43"] = oc_Newobject43;

            #region GuiButtonCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject44["text"] = "OK";
            oc_Newobject44["groupNum"] = "-1";
            oc_Newobject44["buttonType"] = "PushButton";
            oc_Newobject44["useMouseEvents"] = "0";
            oc_Newobject44["isContainer"] = "0";
            oc_Newobject44["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject44["HorizSizing"] = "right";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["position"] = "159 368";
            oc_Newobject44["Extent"] = "86 22";
            oc_Newobject44["MinExtent"] = "8 2";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["Visible"] = "1";
            oc_Newobject44["Command"] = "ColladaImportDlg.onOK();";
            oc_Newobject44["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject44["ToolTip"] = "Load the COLLADA model";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject46["#Newobject44"] = oc_Newobject44;

            #region GuiButtonCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject45["text"] = "Cancel";
            oc_Newobject45["groupNum"] = "-1";
            oc_Newobject45["buttonType"] = "PushButton";
            oc_Newobject45["useMouseEvents"] = "0";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["position"] = "159 395";
            oc_Newobject45["Extent"] = "86 22";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["Command"] = "ColladaImportDlg.onCancel();";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject45["ToolTip"] = "Exit without loading the COLLADA model";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject46["#Newobject45"] = oc_Newobject45;

            #endregion

            oc_Newobject47["#Newobject46"] = oc_Newobject46;

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject48.Create();

            #region GuiControl (ColladaImportProgress,EditorGuiGroup)        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiControl", "ColladaImportProgress,EditorGuiGroup");
            oc_Newobject52["isContainer"] = "1";
            oc_Newobject52["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject52["HorizSizing"] = "width";
            oc_Newobject52["VertSizing"] = "height";
            oc_Newobject52["position"] = "0 0";
            oc_Newobject52["Extent"] = "1024 768";
            oc_Newobject52["MinExtent"] = "8 8";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["Visible"] = "1";
            oc_Newobject52["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["canSaveDynamicFields"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject51["internalName"] = "window";
            oc_Newobject51["resizeWidth"] = "0";
            oc_Newobject51["resizeHeight"] = "0";
            oc_Newobject51["canMove"] = "1";
            oc_Newobject51["canClose"] = "0";
            oc_Newobject51["canMinimize"] = "0";
            oc_Newobject51["canMaximize"] = "0";
            oc_Newobject51["minSize"] = "50 50";
            oc_Newobject51["EdgeSnap"] = "1";
            oc_Newobject51["text"] = "Importing cowboy.dae";
            oc_Newobject51["Margin"] = "0 0 0 0";
            oc_Newobject51["Padding"] = "0 0 0 0";
            oc_Newobject51["AnchorTop"] = "1";
            oc_Newobject51["AnchorBottom"] = "0";
            oc_Newobject51["AnchorLeft"] = "1";
            oc_Newobject51["AnchorRight"] = "0";
            oc_Newobject51["isContainer"] = "1";
            oc_Newobject51["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject51["HorizSizing"] = "center";
            oc_Newobject51["VertSizing"] = "center";
            oc_Newobject51["position"] = "362 338";
            oc_Newobject51["Extent"] = "300 92";
            oc_Newobject51["MinExtent"] = "48 92";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["canSaveDynamicFields"] = "0";

            #region GuiProgressBitmapCtrl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiProgressBitmapCtrl", "");
            oc_Newobject49["internalName"] = "progressBar";
            oc_Newobject49["maxLength"] = "1024";
            oc_Newobject49["Margin"] = "0 0 0 0";
            oc_Newobject49["Padding"] = "0 0 0 0";
            oc_Newobject49["AnchorTop"] = "1";
            oc_Newobject49["AnchorBottom"] = "0";
            oc_Newobject49["AnchorLeft"] = "1";
            oc_Newobject49["AnchorRight"] = "0";
            oc_Newobject49["isContainer"] = "1";
            oc_Newobject49["Profile"] = "ToolsGuiRLProgressBitmapProfile";
            oc_Newobject49["HorizSizing"] = "width";
            oc_Newobject49["VertSizing"] = "bottom";
            oc_Newobject49["position"] = "10 34";
            oc_Newobject49["Extent"] = "280 24";
            oc_Newobject49["MinExtent"] = "8 8";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["Visible"] = "1";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject51["#Newobject49"] = oc_Newobject49;

            #region GuiTextCtrl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject50["internalName"] = "progressText";
            oc_Newobject50["maxLength"] = "1024";
            oc_Newobject50["Margin"] = "0 0 0 0";
            oc_Newobject50["Padding"] = "0 0 0 0";
            oc_Newobject50["AnchorTop"] = "1";
            oc_Newobject50["AnchorBottom"] = "0";
            oc_Newobject50["AnchorLeft"] = "1";
            oc_Newobject50["AnchorRight"] = "0";
            oc_Newobject50["isContainer"] = "0";
            oc_Newobject50["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["position"] = "10 62";
            oc_Newobject50["Extent"] = "280 16";
            oc_Newobject50["MinExtent"] = "8 2";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["Visible"] = "1";
            oc_Newobject50["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject51["#Newobject50"] = oc_Newobject50;

            #endregion

            oc_Newobject52["#Newobject51"] = oc_Newobject51;

            #endregion

            oc_Newobject52.Create();
        }

        [ConsoleInteraction]
        public string showDialog(string shapePath, string cmd)
        {
            ColladaImportTreeView ColladaImportTreeView = "ColladaImportTreeView";
            ShapeEditor.gui.CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";
            Settings EditorSettings = "EditorSettings";
            GuiCanvas Canvas = "Canvas";

            this.path = shapePath;
            this.cmd = cmd;

            // Only allow loading lights if creating a new scene object
            bool canLoadLights = (Util.strstr(this.cmd, "EWCreatorWindow.create") != -1);

            // Check for an existing TSShapeConstructor object. Need to exec the script
            // manually as the DAE resource may not have been loaded yet
            string csPath = Util.filePath(this.path) + "/" + Util.fileBase(this.path) + ".cs";
            if (Util.isFile(csPath))
                Util.exec(csPath, false, false);

            this["constructor"] = ShapeEditor.findConstructor(this.path);

            // Only show the import dialog if required. Note that 'enumColladaScene' will
            // fail if the COLLADA file is missing, or a cached.dts is available.
            bGlobal["$collada::forceLoadDAE"] = EditorSettings.value("forceLoadDAE").AsBool();
            if ((Util.fileExt(shapePath) == ".dts") || !Util.enumColladaForImport(shapePath, ColladaImportTreeView))
                {
                string id = Util.eval(cmd);
                bGlobal["$collada::forceLoadDAE"] = false;

                // Load lights from the DAE if possible
                if (canLoadLights && (this.constructor > 0) && (this.constructor["loadLights"].AsInt() == 1))
                    this.loadLights();

                return id;
                }

            bGlobal["$collada::forceLoadDAE"] = false;

            // Initialise GUI
            ColladaImportTreeView.onDefineIcons();

            GuiWindowCtrl window = this.FOT("window");
            GuiPopUpMenuCtrl upAxis = this.FOT("upAxis");
            GuiPopUpMenuCtrl lodType = this.FOT("lodType");
            GuiCheckBoxCtrl loadLights = this.FOT("loadLights");
            GuiTextEditCtrl scale = this.FOT("scale");
            GuiTextCtrl nodes = this.FOT("nodes");
            GuiTextCtrl meshes = this.FOT("meshes");
            GuiTextCtrl polygons = this.FOT("polygons");
            GuiTextCtrl materials = this.FOT("Materials");
            GuiTextCtrl lights = this.FOT("Lights");
            GuiTextCtrl animations = this.FOT("Animations");
            GuiTextEditCtrl singleDetailSize = this.FOT("singleDetailSize");
            GuiTextEditCtrl materialPrefix = this.FOT("materialPrefix");
            GuiTextEditCtrl alwaysImport = this.FOT("alwaysImport");
            GuiTextEditCtrl neverImport = this.FOT("neverImport");
            GuiTextEditCtrl alwaysImportMesh = this.FOT("alwaysImportMesh");
            GuiTextEditCtrl neverImportMesh = this.FOT("neverImportMesh");
            GuiCheckBoxCtrl ignoreNodeScale = this.FOT("ignoreNodeScale");
            GuiCheckBoxCtrl adjustCenter = this.FOT("adjustCenter");
            GuiCheckBoxCtrl adjustFloor = this.FOT("adjustFloor");
            GuiCheckBoxCtrl forceUpdateMaterials = this.FOT("forceUpdateMaterials");

            window.text = "COLLADA Import:" + ' ' + this.path;

            upAxis.clear();
            upAxis.add("X_AXIS", 1);
            upAxis.add("Y_AXIS", 2);
            upAxis.add("Z_AXIS", 3);

            lodType.clear();
            lodType.add("DetectDTS", 1);
            lodType.add("SingleSize", 2);
            lodType.add("TrailingNumber", 3);

            loadLights.setActive(canLoadLights);

            // Set model details
            nodes.setText(ColladaImportTreeView["_nodeCount"]);
            meshes.setText(ColladaImportTreeView["_meshCount"]);
            polygons.setText(ColladaImportTreeView["_polygonCount"]);
            materials.setText(ColladaImportTreeView["_materialCount"]);
            lights.setText(ColladaImportTreeView["_lightCount"]);
            animations.setText(ColladaImportTreeView["_animCount"]);

            this.updateOverrideUpAxis(false);
            this.updateOverrideScale(false);

            if (this.constructor > 0)
                {
                if (this.constructor["upAxis"] != "DEFAULT")
                    {
                    upAxis.setText(this.constructor["upAxis"]);
                    this.updateOverrideUpAxis(true);
                    }
                if (this.constructor["unit"].AsInt() > 0)
                    {
                    scale.setText(this.constructor["unit"]);
                    this.updateOverrideScale(true);
                    }

                lodType.setText(this.constructor["lodType"]);
                singleDetailSize.setText(this.constructor["singleDetailSize"]);
                materialPrefix.setText(this.constructor["matNamePrefix"]);
                alwaysImport.setText(Util.strreplace(this.constructor["alwaysImport"], "\t", ";"));
                neverImport.setText(Util.strreplace(this.constructor["neverImport"], "\t", ";"));
                alwaysImportMesh.setText(Util.strreplace(this.constructor["alwaysImportMesh"], "\t", ";"));
                neverImportMesh.setText(Util.strreplace(this.constructor["neverImportMesh"], "\t", ";"));
                ignoreNodeScale.setStateOn(this.constructor["ignoreNodeScale"].AsBool());
                adjustCenter.setStateOn(this.constructor["adjustCenter"].AsBool());
                adjustFloor.setStateOn(this.constructor["adjustFloor"].AsBool());
                forceUpdateMaterials.setStateOn(this.constructor["forceUpdateMaterials"].AsBool());
                loadLights.setStateOn(this.constructor["loadLights"].AsBool());
                }
            else
                {
                // Default settings
                lodType.setText("DetectDTS");
                singleDetailSize.setText("2");
                materialPrefix.setText("");
                alwaysImport.setText("");
                neverImport.setText("");
                alwaysImportMesh.setText("");
                neverImportMesh.setText("");
                ignoreNodeScale.setStateOn(false);
                adjustCenter.setStateOn(false);
                adjustFloor.setStateOn(false);
                forceUpdateMaterials.setStateOn(false);
                loadLights.setStateOn(false);
                }

            Canvas.pushDialog(this);

            ColladaImportTreeView.refresh("all");

            return "0";
        }

        [ConsoleInteraction]
        public void readDtsConfig()
        {
            string filename = Util.filePath(this.path) + "/" + Util.fileBase(this.path) + ".cfg";
            string filename2 = Util.filePath(this.path) + "/" + "dtsScene.cfg";

            FileObject fo = new ObjectCreator("FileObject").Create();

            if (fo.openForRead(filename) || fo.openForRead(filename2))
                {
                string alwaysImport = "";
                string neverImport = "";

                string mode = "none";
                while (!fo.isEOF())
                    {
                    string line = Util.trim(fo.readLine());

                    if (line == "AlwaysExport:") // Start of the AlwaysExport list
                        mode = "always";
                    else if (line == "NeverExport:") // Start of the NeverExport list
                        mode = "never";
                    else if (Util.startsWith(line, "+", false) || Util.startsWith(line, "-", false))
                        // Boolean parameters (not supported)
                        mode = "none";
                    else if (Util.startsWith(line, "=", false)) // Float and integer parameters (not supported)
                        mode = "none";
                    else if (!Util.startsWith(line, "//", false)) // Non-commented lines
                        {
                        switch (mode)
                            {
                                case "always":
                                    alwaysImport = alwaysImport + '\t' + line;
                                    break;
                                case "never":
                                    neverImport = neverImport + '\t' + line;
                                    break;
                            }
                        }
                    }

                fo.close();

                alwaysImport = Util.strreplace(Util.trim(alwaysImport), "\t", ";");
                neverImport = Util.strreplace(Util.trim(neverImport), "\t", ";");

                ((GuiTextEditCtrl) this.FOT(alwaysImport)).setText(alwaysImport);
                ((GuiTextEditCtrl) this.FOT(neverImport)).setText(neverImport);
                }
            else
                Util._error("Failed to open " + filename + " or " + filename2 + " for reading");

            fo.delete();
        }

        [ConsoleInteraction]
        public void writeDtsConfig()
        {
            string filename = Util.filePath(this.path) + "/" + Util.fileBase(this.path) + ".cfg";

            FileObject fo = new ObjectCreator("FileObject").Create();
            if (fo.openForWrite(filename))
                {
                // AlwaysImport
                fo.writeLine("AlwaysExport:");
                string alwaysImport = Util.trim(Util.strreplace(((GuiTextEditCtrl) this.FOT("alwaysImport")).getText(), ";", "\t"));
                int count1 = Util.getFieldCount(alwaysImport);
                for (int i = 0; i < count1; i++)
                    fo.writeLine(Util.getField(alwaysImport, i));
                fo.writeLine("");

                // NeverImport
                fo.writeLine("NeverExport:");
                string neverImport = Util.trim(Util.strreplace(((GuiTextEditCtrl) this.FOT("neverImport")).getText(), ";", "\t"));
                int count = Util.getFieldCount(neverImport);
                for (int i = 0; i < count; i++)
                    fo.writeLine(Util.getField(neverImport, i));
                fo.writeLine("");

                fo.close();
                }
            else
                Util._error("Failed to open " + filename + " for writing");

            fo.delete();
        }

        [ConsoleInteraction]
        public void updateOverrideUpAxis(bool overrideState)
        {
            ColladaImportTreeView ColladaImportTreeView = "ColladaImportTreeView";

            GuiCheckBoxCtrl overrideUpAxis = this.FOT("overrideUpAxis");
            GuiPopUpMenuCtrl upAxis = this.FOT("upAxis");

            overrideUpAxis.setStateOn(overrideState);
            upAxis.setActive(overrideState);
            if (!overrideState)
                upAxis.setText(ColladaImportTreeView["_upAxis"]);
        }

        [ConsoleInteraction]
        public void updateOverrideScale(bool overrideState)
        {
            ColladaImportTreeView ColladaImportTreeView = "ColladaImportTreeView";

            GuiTextEditCtrl scale = this.FOT("scale");
            GuiCheckBoxCtrl overrideScale = this.FOT("overrideScale");

            overrideScale.setStateOn(overrideState);
            scale.setActive(overrideState);
            if (!overrideState)
                scale.setText(ColladaImportTreeView["_unit"]);
        }

        [ConsoleInteraction]
        public void onCancel()
        {
            ColladaImportTreeView ColladaImportTreeView = "ColladaImportTreeView";
            GuiCanvas Canvas = "Canvas";

            Canvas.popDialog(this);
            ColladaImportTreeView.clear();
        }

        [ConsoleInteraction]
        public void onOK()
        {
            ColladaImportTreeView ColladaImportTreeView = "ColladaImportTreeView";
            GuiCanvas Canvas = "Canvas";
            ShapeEditor.gui.CodeBehind.ShapeEditor ShapeEditor = "ShapeEditor";

            GuiPopUpMenuCtrl upAxis = this.FOT("upAxis");
            GuiPopUpMenuCtrl lodType = this.FOT("lodType");
            GuiCheckBoxCtrl loadLights = this.FOT("loadLights");
            GuiTextEditCtrl scale = this.FOT("scale");
            GuiCheckBoxCtrl overrideUpAxis = this.FOT("overrideUpAxis");
            GuiCheckBoxCtrl overrideScale = this.FOT("overrideScale");
            GuiTextEditCtrl singleDetailSize = this.FOT("singleDetailSize");
            GuiTextEditCtrl materialPrefix = this.FOT("materialPrefix");
            GuiTextEditCtrl alwaysImport = this.FOT("alwaysImport");
            GuiTextEditCtrl neverImport = this.FOT("neverImport");
            GuiTextEditCtrl alwaysImportMesh = this.FOT("alwaysImportMesh");
            GuiTextEditCtrl neverImportMesh = this.FOT("neverImportMesh");
            GuiCheckBoxCtrl ignoreNodeScale = this.FOT("ignoreNodeScale");
            GuiCheckBoxCtrl adjustCenter = this.FOT("adjustCenter");
            GuiCheckBoxCtrl adjustFloor = this.FOT("adjustFloor");
            GuiCheckBoxCtrl forceUpdateMaterials = this.FOT("forceUpdateMaterials");

            Canvas.popDialog(this);
            ColladaImportTreeView.clear();

            // Need to create a TSShapeConstructor object if any settings are not
            // at the default values
            if ((overrideUpAxis.getValue().AsInt() != 0) || (overrideScale.getValue().AsInt() != 0) || (lodType.getText() != "DetectDTS") || (singleDetailSize.getText() != "2") || (materialPrefix.getText() != "") || (alwaysImport.getText() != "") || (neverImport.getText() != "") || (alwaysImportMesh.getText() != "") || (neverImportMesh.getText() != "") || (ignoreNodeScale.getValue().AsInt() != 0) || (adjustCenter.getValue().AsInt() != 0) || (adjustFloor.getValue().AsInt() != 0) || (forceUpdateMaterials.getValue().AsInt() != 0) || (loadLights.getValue().AsInt() != 0))
                {
                if (this.constructor <= 0)
                    {
                    // Create a new TSShapeConstructor object
                    this.constructor = ShapeEditor.createConstructor(this.path);
                    }
                }

            if (this.constructor > 0)
                {
                // Store values from GUI
                if (overrideUpAxis.getValue().AsBool())
                    this.constructor["upAxis"] = upAxis.getText();
                else
                    this.constructor["upAxis"] = "DEFAULT";

                if (overrideScale.getValue().AsBool())
                    this.constructor["unit"] = scale.getText();
                else
                    this.constructor["unit"] = "-1";

                this.constructor["lodType"] = lodType.getText();
                this.constructor["singleDetailSize"] = singleDetailSize.getText();
                this.constructor["matNamePrefix"] = materialPrefix.getText();
                this.constructor["alwaysImport"] = Util.strreplace(alwaysImport.getText(), ";", "\t");
                this.constructor["neverImport"] = Util.strreplace(neverImport.getText(), ";", "\t");
                this.constructor["alwaysImportMesh"] = Util.strreplace(alwaysImportMesh.getText(), ";", "\t");
                this.constructor["neverImportMesh"] = Util.strreplace(neverImportMesh.getText(), ";", "\t");
                this.constructor["ignoreNodeScale"] = ignoreNodeScale.getValue();
                this.constructor["adjustCenter"] = adjustCenter.getValue();
                this.constructor["adjustFloor"] = adjustFloor.getValue();
                this.constructor["forceUpdateMaterials"] = forceUpdateMaterials.getValue();
                this.constructor["loadLights"] = loadLights.getValue();

                // Save new settings to file
                ShapeEditor.saveConstructor(this.constructor);
                }

            // Load the shape (always from the DAE)
            bGlobal["$collada::forceLoadDAE"] = true;
            Util.eval(this.cmd);
            bGlobal["$collada::forceLoadDAE"] = false;

            // Optionally load the lights from the DAE as well (only if adding a new shape
            // to the scene)
            if (loadLights.getValue().AsBool())
                this.loadLights();
        }

        [ConsoleInteraction]
        public void loadLights()
        {
            SimGroup MissionGroup = "MissionGroup";
            EditorTree EditorTree = "EditorTree";

            // Get the ID of the last object added
            SimObject obj = MissionGroup.getObject((uint) MissionGroup.getCount() - 1);

            // Create a new SimGroup to hold the model and lights
            SimGroup group = new ObjectCreator("SimGroup").Create();
            Util.loadColladaLights(this.path, group, obj);

            // Delete the SimGroup if no lights were found. Otherwise, add the model to
            // the group as well.
            if (group.getCount() > 0)
                {
                group.add(obj);
                group.bringToFront(obj);
                MissionGroup.add(group);
                if (EditorTree.isVisible())
                    {
                    EditorTree.removeItem(EditorTree.findItemByObjectId(obj));
                    EditorTree.buildVisibleTree(true);
                    }
                }
            else
                group.delete();
        }

        [ConsoleInteraction]
        public static void updateTSShapeLoadProgress(float progress, string msg)
        {
            GuiCanvas Canvas = "Canvas";
            GuiChunkedBitmapCtrl LoadingGui = "LoadingGui";
            GuiControl ColladaImportProgress = "ColladaImportProgress";
            GuiProgressBitmapCtrl LoadingProgress = "LoadingProgress";
            GuiTextCtrl LoadingProgressTxt = "LoadingProgressTxt";

            GuiControl progressCtrl;
            GuiTextCtrl textCtrl;

            // Check if the loading GUI is visible and use that instead of the
            // separate import progress GUI if possible
            if (LoadingGui.isObject() && LoadingGui.isAwake())
                {
                // Save/Restore load progress at the start/end of the import process
                if (progress == 0)
                    {
                    ColladaImportProgress["savedProgress"] = LoadingProgress.getValue();
                    ColladaImportProgress["savedText"] = LoadingProgressTxt.getValue();

                    ColladaImportProgress["msgPrefix"] = "Importing " + msg;
                    msg = "Reading file into memory...";
                    }
                else if (progress == 1.0)
                    {
                    LoadingProgress.setValue(ColladaImportProgress["savedProgress"]);
                    LoadingProgressTxt.setValue(ColladaImportProgress["savedText"]);
                    }

                msg = ColladaImportProgress["msgPrefix"] + ": " + msg;

                progressCtrl = LoadingProgress;
                textCtrl = LoadingProgressTxt;
                }
            else
                {
                GuiWindowCtrl window = ColladaImportProgress.FOT("window");
                GuiProgressBitmapCtrl progressBar = ColladaImportProgress.FOT("progressBar");
                GuiTextCtrl progressText = ColladaImportProgress.FOT("progressText");

                // Show/Hide gui at the start/end of the import process
                if (progress == 0)
                    {
                    window.text = "Importing" + ' ' + msg;
                    msg = "Reading file into memory...";
                    Canvas.pushDialog(ColladaImportProgress);
                    }
                else if (progress == 1.0)
                    Canvas.popDialog(ColladaImportProgress);

                progressCtrl = progressBar;
                textCtrl = progressText;
                }

            // Update progress indicators
            if (progress == 0)
                {
                progressCtrl.setValue("0.001");
                textCtrl.setText(msg);
                }
            else if (progress != 1.0)
                {
                progressCtrl.setValue(progress.AsString());
                progressCtrl.setValue(progress.AsString());
                textCtrl.setText(msg);
                }

            Canvas.repaint(33);
        }

        [ConsoleInteraction]
        // Convert all COLLADA models that match the given pattern (defaults to *) to DTS
        public static void convertColladaModels(string pattern)
        {
            // Force loading the COLLADA file (to ensure cached DTS is updated)
            omni.bGlobal["$collada::forceLoadDAE"] = true;

            string fullPath = omni.Util.findFirstFile("*.dae", false);
            while (fullPath != "")
                {
                // Check if this file is inside the given path
                fullPath = omni.Util.makeRelativePath(fullPath, omni.Util.getMainDotCsDir());
                if ((pattern == "") || omni.Util.strIsMatchMultipleExpr(pattern, fullPath, false))
                    {
                    // Load the model by creating a temporary TSStatic
                    omni.Util._echo("Converting " + fullPath + " to DTS...");
                    ObjectCreator tempCreator = new ObjectCreator("TSStatic");
                    tempCreator["shapeName"] = fullPath;
                    tempCreator["collisionType"] = "None";

                    TSStatic temp = tempCreator.Create();

                    temp.delete();
                    }

                fullPath = omni.Util.findNextFile("*.dae");
                }

            omni.bGlobal["$collada::forceLoadDAE"] = false;
        }

        [TypeConverter(typeof (TypeConverterGeneric<ColladaImportTreeView>))]
        public class ColladaImportTreeView : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public override void onDefineIcons()
            {
                // Set the tree view icon indices and texture paths
                this["_imageNone"] = "0";
                this["_imageNode"] = "1";
                this["_imageMesh"] = "2";
                this["_imageMaterial"] = "3";
                this["_imageLight"] = "4";
                this["_imageAnimation"] = "5";
                this["_imageExNode"] = "6";
                this["_imageExMaterial"] = "7";

                string icons = ":" + // no icon
                               "tools/gui/images/ColladaImport/iconNode:" + // normal node
                               "tools/gui/images/ColladaImport/iconMesh:" + // mesh
                               "tools/gui/images/ColladaImport/iconMaterial:" + // new material
                               "tools/gui/images/ColladaImport/iconLight:" + // light
                               "tools/gui/images/ColladaImport/iconAnimation:" + // sequence
                               "tools/gui/images/ColladaImport/iconIgnoreNode:" + // ignored node
                               "tools/gui/images/ColladaImport/iconExistingMaterial"; // existing material

                this.buildIconTable(icons);
            }

            [ConsoleInteraction]
            public void refresh(string what)
            {
                ColladaImportDlg ColladaImportDlg = "ColladaImportDlg";

                GuiTextEditCtrl materialPrefix = ColladaImportDlg.FOT("materialPrefix");
                GuiTextEditCtrl alwaysImport = ColladaImportDlg.FOT("alwaysImport");
                GuiTextEditCtrl neverImport = ColladaImportDlg.FOT("neverImport");
                GuiTextEditCtrl alwaysImportMesh = ColladaImportDlg.FOT("alwaysImportMesh");
                GuiTextEditCtrl neverImportMesh = ColladaImportDlg.FOT("neverImportMesh");

                SimObject shapeRoot = this.getFirstRootItem();
                SimObject materialsRoot = this.getNextSibling(shapeRoot);
                SimObject animRoot = this.getNextSibling(materialsRoot);

                // Refresh nodes
                if ((what == "all") || (what == "nodes"))
                    {
                    // Indicate whether nodes will be ignored on import
                    this["_alwaysImport"] = Util.strreplace(alwaysImport.getText(), ";", "\t");
                    this["_neverImport"] = Util.strreplace(neverImport.getText(), ";", "\t");
                    this["_alwaysImportMesh"] = Util.strreplace(alwaysImportMesh.getText(), ";", "\t");
                    this["_neverImportMesh"] = Util.strreplace(neverImportMesh.getText(), ";", "\t");
                    this.refreshNode(this.getChild(shapeRoot));
                    }

                // Refresh materials
                if ((what == "all") || (what == "materials"))
                    {
                    string matPrefix = materialPrefix.getText();
                    int id = this.getChild(materialsRoot);
                    while (id > 0)
                        {
                        string baseName = this.getItemValue(id);
                        string name = matPrefix + baseName;

                        // Indicate whether material name is already mapped
                        this.editItem(id, name, baseName);
                        string mapped = Util.getMaterialMapping(name);
                        if (mapped == "")
                            {
                            this.setItemTooltip(id, "A new material will be mapped to this name");
                            this.setItemImages(id, this["_imageMaterial"].AsSbyte(), this["_imageMaterial"].AsSbyte());
                            }
                        else
                            {
                            this.setItemTooltip(id, mapped + ' ' + "is already mapped to this material name");
                            this.setItemImages(id, this["_imageExMaterial"].AsSbyte(), this["_imageExMaterial"].AsSbyte());
                            }

                        id = this.getNextSibling(id);
                        }
                    }

                // Refresh animations
                if ((what == "all") || (what == "animations"))
                    {
                    int id = this.getChild(animRoot);
                    while (id > 0)
                        {
                        this.setItemImages(id, this["_imageAnim"].AsSbyte(), this["_imageAnim"].AsSbyte());
                        id = this.getNextSibling(id);
                        }
                    }
            }

            [ConsoleInteraction]
            public void refreshNode(int id)
            {
                while (id > 0)
                    {
                    switch (this.getItemValue(id))
                        {
                            case "mesh":
                                // Check if this mesh will be ignored on import
                                if (Util.strIsMatchMultipleExpr(this["_alwaysImportMesh"], this.getItemText(id), false) || !Util.strIsMatchMultipleExpr(this["_neverImportMesh"], this.getItemText(id), false))
                                    {
                                    this.setItemTooltip(id, "");
                                    this.setItemImages(id, this["_imageMesh"].AsSbyte(), this["_imageMesh"].AsSbyte());
                                    }
                                else
                                    {
                                    this.setItemTooltip(id, "This mesh will be ignored on import");
                                    this.setItemImages(id, this["_imageExNode"].AsSbyte(), this["_imageExNode"].AsSbyte());
                                    }
                                break;

                            case "light":
                                this.setItemImages(id, this["_imageLight"].AsSbyte(), this["_imageLight"].AsSbyte());
                                break;

                            case "node":
                                // Check if this node will be ignored on import
                                if (Util.strIsMatchMultipleExpr(this["_alwaysImport"], this.getItemText(id), false) || !Util.strIsMatchMultipleExpr(this["_neverImport"], this.getItemText(id), false))
                                    {
                                    this.setItemTooltip(id, "");
                                    this.setItemImages(id, this["_imageNode"].AsSbyte(), this["_imageNode"].AsSbyte());
                                    }
                                else
                                    {
                                    this.setItemTooltip(id, "This node will be ignored on import");
                                    this.setItemImages(id, this["_imageExNode"].AsSbyte(), this["_imageExNode"].AsSbyte());
                                    }
                                break;
                        }

                    // recurse through children and siblings
                    this.refreshNode(this.getChild(id));
                    id = this.getNextSibling(id);
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ColladaImportTreeView ts, string simobjectid)
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
            public static bool operator !=(ColladaImportTreeView ts, string simobjectid)
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
            public static implicit operator string(ColladaImportTreeView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ColladaImportTreeView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ColladaImportTreeView) Omni.self.getSimObject(simobjectid, typeof (ColladaImportTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ColladaImportTreeView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ColladaImportTreeView(int simobjectid)
            {
                return (ColladaImportTreeView) Omni.self.getSimObject((uint) simobjectid, typeof (ColladaImportTreeView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ColladaImportTreeView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ColladaImportTreeView(uint simobjectid)
            {
                return (ColladaImportTreeView) Omni.self.getSimObject(simobjectid, typeof (ColladaImportTreeView));
            }

            #endregion
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ColladaImportDlg ts, string simobjectid)
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
        public static bool operator !=(ColladaImportDlg ts, string simobjectid)
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
        public static implicit operator string(ColladaImportDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ColladaImportDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ColladaImportDlg) Omni.self.getSimObject(simobjectid, typeof (ColladaImportDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ColladaImportDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ColladaImportDlg(int simobjectid)
        {
            return (ColladaImportDlg) Omni.self.getSimObject((uint) simobjectid, typeof (ColladaImportDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ColladaImportDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ColladaImportDlg(uint simobjectid)
        {
            return (ColladaImportDlg) Omni.self.getSimObject(simobjectid, typeof (ColladaImportDlg));
        }

        #endregion
    }
}