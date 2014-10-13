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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<GuiObjectInspector>))]
    public class GuiObjectInspector : GuiWindowCollapseCtrl
    {

        [ConsoleInteraction(true, "GuiObjectInspector_initialize")]
        public static uint initialize()
        {
            #region GuiWindowCollapseCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiWindowCollapseCtrl", "", typeof (GuiObjectInspector));
            oc_Newobject15["collapseGroup"] = "-1";
            oc_Newobject15["collapseGroupNum"] = "-1";
            oc_Newobject15["resizeWidth"] = "1";
            oc_Newobject15["resizeHeight"] = "1";
            oc_Newobject15["canMove"] = "1";
            oc_Newobject15["canClose"] = "1";
            oc_Newobject15["canMinimize"] = "1";
            oc_Newobject15["canMaximize"] = "1";
            oc_Newobject15["minSize"] = "50 50";
            oc_Newobject15["closeCommand"] = "$ThisControl.onClose();";
            oc_Newobject15["edgeSnap"] = "1";
            oc_Newobject15["text"] = "Object Inspector";
            oc_Newobject15["margin"] = "0 0 0 0";
            oc_Newobject15["padding"] = "0 0 0 0";
            oc_Newobject15["anchorTop"] = "1";
            oc_Newobject15["anchorBottom"] = "0";
            oc_Newobject15["anchorLeft"] = "1";
            oc_Newobject15["anchorRight"] = "0";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["position"] = "152 130";
            oc_Newobject15["extent"] = "658 472";
            oc_Newobject15["minExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["visible"] = "1";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["canSaveDynamicFields"] = "1";
            // oc_Newobject15["class"] = "GuiObjectInspector";
            //oc_Newobject15["className"] = "GuiObjectInspector";

            #region GuiSplitContainer ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiSplitContainer", "");
            oc_Newobject14["orientation"] = "Vertical";
            oc_Newobject14["splitterSize"] = "2";
            oc_Newobject14["splitPoint"] = "300 100";
            oc_Newobject14["fixedPanel"] = "None";
            oc_Newobject14["fixedSize"] = "100";
            oc_Newobject14["docking"] = "Client";
            oc_Newobject14["margin"] = "0 0 0 0";
            oc_Newobject14["padding"] = "0 0 0 0";
            oc_Newobject14["anchorTop"] = "1";
            oc_Newobject14["anchorBottom"] = "0";
            oc_Newobject14["anchorLeft"] = "1";
            oc_Newobject14["anchorRight"] = "0";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["horizSizing"] = "right";
            oc_Newobject14["vertSizing"] = "bottom";
            oc_Newobject14["position"] = "1 21";
            oc_Newobject14["extent"] = "656 448";
            oc_Newobject14["minExtent"] = "64 64";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["internalName"] = "Splitter";
            oc_Newobject14["canSaveDynamicFields"] = "0";

            #region GuiPanel ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiPanel", "");
            oc_Newobject5["docking"] = "Client";
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["horizSizing"] = "width";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["extent"] = "298 448";
            oc_Newobject5["minExtent"] = "16 16";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["internalName"] = "Panel1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiTextEditCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "", typeof (GuiObjectInspectorTreeFilter));
            oc_Newobject1["position"] = "2 3";
            oc_Newobject1["extent"] = "278 18";
            oc_Newobject1["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "bottom";
            //oc_Newobject1["superClass"] = "GuiTreeViewFilterText";
            //oc_Newobject1["class"] = "GuiObjectInspectorTreeFilter";
            oc_Newobject1["internalName"] = "FilterText";

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof (GuiObjectInspectorTreeFilterClearButton));
            oc_Newobject2["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "281 4";
            oc_Newobject2["Extent"] = "17 17";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            //oc_Newobject2["superClass"] = "GuiTreeViewFilterClearButton";
            //oc_Newobject2["class"] = "GuiObjectInspectorTreeFilterClearButton";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "dynamic";
            oc_Newobject4["vScrollBar"] = "dynamic";
            oc_Newobject4["lockHorizScroll"] = "0";
            oc_Newobject4["lockVertScroll"] = "0";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "0 0";
            oc_Newobject4["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "height";
            oc_Newobject4["position"] = "1 22";
            oc_Newobject4["extent"] = "297 426";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTreeViewCtrl", "", typeof (GuiObjectInspectorTree));
            oc_Newobject3["tabSize"] = "16";
            oc_Newobject3["textOffset"] = "2";
            oc_Newobject3["fullRowSelect"] = "0";
            oc_Newobject3["itemHeight"] = "21";
            oc_Newobject3["destroyTreeOnSleep"] = "0";
            oc_Newobject3["mouseDragging"] = "0";
            oc_Newobject3["multipleSelections"] = "0";
            oc_Newobject3["deleteObjectAllowed"] = "0";
            oc_Newobject3["dragToItemAllowed"] = "0";
            oc_Newobject3["clearAllOnSingleSelection"] = "1";
            oc_Newobject3["showRoot"] = "1";
            oc_Newobject3["internalNamesOnly"] = "0";
            oc_Newobject3["objectNamesOnly"] = "0";
            oc_Newobject3["useInspectorTooltips"] = "0";
            oc_Newobject3["tooltipOnWidthOnly"] = "0";
            oc_Newobject3["compareToObjectID"] = "1";
            oc_Newobject3["canRenameObjects"] = "1";
            oc_Newobject3["renameInternal"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject3["horizSizing"] = "width";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "1 1";
            oc_Newobject3["extent"] = "166 21";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["internalName"] = "TreeView";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            //oc_Newobject3["class"] = "GuiObjectInspectorTree";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject14["#Newobject5"] = oc_Newobject5;

            #region GuiPanel ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiPanel", "");
            oc_Newobject13["docking"] = "Client";
            oc_Newobject13["margin"] = "0 0 0 0";
            oc_Newobject13["padding"] = "0 0 0 0";
            oc_Newobject13["anchorTop"] = "1";
            oc_Newobject13["anchorBottom"] = "0";
            oc_Newobject13["anchorLeft"] = "1";
            oc_Newobject13["anchorRight"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["horizSizing"] = "right";
            oc_Newobject13["vertSizing"] = "bottom";
            oc_Newobject13["position"] = "302 0";
            oc_Newobject13["extent"] = "354 448";
            oc_Newobject13["minExtent"] = "16 16";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["internalName"] = "panel2";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #region GuiSplitContainer ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiSplitContainer", "");
            oc_Newobject12["orientation"] = "Horizontal";
            oc_Newobject12["splitterSize"] = "2";
            oc_Newobject12["splitPoint"] = "100 300";
            oc_Newobject12["fixedPanel"] = "None";
            oc_Newobject12["fixedSize"] = "100";
            oc_Newobject12["docking"] = "Client";
            oc_Newobject12["margin"] = "0 0 0 0";
            oc_Newobject12["padding"] = "0 0 0 0";
            oc_Newobject12["anchorTop"] = "1";
            oc_Newobject12["anchorBottom"] = "0";
            oc_Newobject12["anchorLeft"] = "1";
            oc_Newobject12["anchorRight"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "0 2";
            oc_Newobject12["extent"] = "354 448";
            oc_Newobject12["minExtent"] = "64 64";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #region GuiPanel ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiPanel", "");
            oc_Newobject8["docking"] = "Client";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["extent"] = "354 298";
            oc_Newobject8["minExtent"] = "16 16";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["internalName"] = "Panel1";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject7["willFirstRespond"] = "1";
            oc_Newobject7["hScrollBar"] = "alwaysOff";
            oc_Newobject7["vScrollBar"] = "dynamic";
            oc_Newobject7["lockHorizScroll"] = "0";
            oc_Newobject7["lockVertScroll"] = "0";
            oc_Newobject7["constantThumbHeight"] = "0";
            oc_Newobject7["childMargin"] = "0 0";
            oc_Newobject7["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject7["docking"] = "Client";
            oc_Newobject7["margin"] = "0 0 0 0";
            oc_Newobject7["padding"] = "0 0 0 0";
            oc_Newobject7["anchorTop"] = "1";
            oc_Newobject7["anchorBottom"] = "0";
            oc_Newobject7["anchorLeft"] = "1";
            oc_Newobject7["anchorRight"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["extent"] = "354 298";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiInspector ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiInspector", "", typeof (EditorInspectorBase));
            oc_Newobject6["dividerMargin"] = "5";
            oc_Newobject6["showCustomFields"] = "1";
            oc_Newobject6["stackingType"] = "Vertical";
            oc_Newobject6["horizStacking"] = "Left to Right";
            oc_Newobject6["vertStacking"] = "Top to Bottom";
            oc_Newobject6["padding"] = "1";
            oc_Newobject6["dynamicSize"] = "1";
            oc_Newobject6["changeChildSizeToFit"] = "1";
            oc_Newobject6["changeChildPosition"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["profile"] = "GuiInspectorProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "1 1";
            oc_Newobject6["extent"] = "337 16";
            oc_Newobject6["minExtent"] = "16 16";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["internalName"] = "inspector";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["class"] = "GuiObjectInspectorFields";
            oc_Newobject6["className"] = "GuiObjectInspectorFields";
            //oc_Newobject6["superClass"] = "EditorInspectorBase";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject12["#Newobject8"] = oc_Newobject8;

            #region GuiPanel ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiPanel", "");
            oc_Newobject11["docking"] = "Client";
            oc_Newobject11["margin"] = "0 0 0 0";
            oc_Newobject11["padding"] = "0 0 0 0";
            oc_Newobject11["anchorTop"] = "1";
            oc_Newobject11["anchorBottom"] = "0";
            oc_Newobject11["anchorLeft"] = "1";
            oc_Newobject11["anchorRight"] = "0";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "0 302";
            oc_Newobject11["extent"] = "354 146";
            oc_Newobject11["minExtent"] = "16 50";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["internalName"] = "panel2";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject10["willFirstRespond"] = "1";
            oc_Newobject10["hScrollBar"] = "dynamic";
            oc_Newobject10["vScrollBar"] = "dynamic";
            oc_Newobject10["lockHorizScroll"] = "0";
            oc_Newobject10["lockVertScroll"] = "0";
            oc_Newobject10["constantThumbHeight"] = "0";
            oc_Newobject10["childMargin"] = "0 0";
            oc_Newobject10["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject10["docking"] = "Client";
            oc_Newobject10["margin"] = "0 0 0 0";
            oc_Newobject10["padding"] = "0 0 0 0";
            oc_Newobject10["anchorTop"] = "1";
            oc_Newobject10["anchorBottom"] = "0";
            oc_Newobject10["anchorLeft"] = "1";
            oc_Newobject10["anchorRight"] = "0";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["extent"] = "354 146";
            oc_Newobject10["minExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTreeViewCtrl", "", typeof (GuiObjectInspectorMethodList));
            oc_Newobject9["tabSize"] = "16";
            oc_Newobject9["textOffset"] = "2";
            oc_Newobject9["fullRowSelect"] = "0";
            oc_Newobject9["itemHeight"] = "21";
            oc_Newobject9["destroyTreeOnSleep"] = "1";
            oc_Newobject9["mouseDragging"] = "0";
            oc_Newobject9["multipleSelections"] = "0";
            oc_Newobject9["deleteObjectAllowed"] = "0";
            oc_Newobject9["dragToItemAllowed"] = "0";
            oc_Newobject9["clearAllOnSingleSelection"] = "1";
            oc_Newobject9["showRoot"] = "1";
            oc_Newobject9["internalNamesOnly"] = "0";
            oc_Newobject9["objectNamesOnly"] = "0";
            oc_Newobject9["useInspectorTooltips"] = "0";
            oc_Newobject9["tooltipOnWidthOnly"] = "0";
            oc_Newobject9["compareToObjectID"] = "1";
            oc_Newobject9["canRenameObjects"] = "1";
            oc_Newobject9["renameInternal"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "1 1";
            oc_Newobject9["extent"] = "109 42";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["internalName"] = "methodList";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            //oc_Newobject9["class"] = "GuiObjectInspectorMethodList";
            //oc_Newobject9["className"] = "GuiObjectInspectorMethodList";

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

            return oc_Newobject15.Create();
        }

        [ConsoleInteraction]
        /// Bring up a new inspector window on the given object.
        public static void inspectObject(string objectx)
        {
            GuiCanvas Canvas = "Canvas";

            if (!objectx.isObject())
                {
                omni.Util._error("inspectObject: no object '" + objectx + "'");
                return;
                }

            // Create a new object inspector window.
            //exec( "./guiObjectInspector.ed.gui" );
            GuiObjectInspector guiContent = omni.console.Call("GuiObjectInspector_initialize");

            if (!guiContent.isObject())
                {
                omni.Util._error("InspectObject: failed to create GUI from 'guiObjectInspector.ed.gui'");
                return;
                }

            // Initialize the inspector.

            guiContent.init(objectx);

            ((GuiControl) Canvas.getContent()).add(guiContent);
        }

        //=============================================================================================
        //    GuiObjectInspector
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void init(SimObject objectx)
        {
            GuiPanel panel2 = this.FOT("panel2");
            GuiSplitContainer splitter = this.FOT("Splitter");
            GuiInspector inspector = this.FOT("inspector");
            GuiObjectInspectorMethodList methodList = this.FOT("methodList");
            GuiObjectInspectorTree treeView = this.FOT("TreeView");

            if (!objectx.isMemberOfClass("SimSet"))
                {
                // Complete deletely the splitter and the left-side part of the inspector
                // leaving only the field inspector.

                this.add(panel2);
                splitter.delete();
                inspector.inspect(objectx);
                methodList.init(objectx);
                }
            else
                {
                treeView.inspectorCtrl = inspector;
                treeView.methodList = methodList;

                treeView.open(objectx);
                }

            // Set window caption.

            string caption = "Object Inspector - " + objectx.getId() + " : " + objectx.getClassName();

            string name = objectx.getName();
            if (name != "")
                caption = caption + " - " + name;

            this.text = caption;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public override void onClose()
        {
            // Delete us.
            this.schedule("1", "delete");
        }

        //=============================================================================================
        //    GuiObjectInspectorTree
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        //=============================================================================================
        //    GuiObjectInspectorMethodList
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiObjectInspectorMethodList>))]
        public class GuiObjectInspectorMethodList : GuiTreeViewCtrl
        {
            [ConsoleInteraction]
            public void init(SimObject objectx)
            {
                this.clear();

                ArrayObject methods = objectx.dumpMethods();
                int count = methods.count();
                int methodsGroup = this.insertItem(0, "Methods", "", "", 1, 1);
                int parentScripted = this.insertItem(methodsGroup, "Scripted", "", "", 1, 1);
                int parentNative = this.insertItem(methodsGroup, "Native", "", "", 1, 1);

                for (int i = 0; i < count; i ++)
                    {
                    string name = methods.getKey(i);
                    string value = methods.getValue(i);
                    string prototype = Util.getRecord(value, 2);
                    string fileName = Util.getRecord(value, 3);
                    string lineNumber = Util.getRecord(value, 4);
                    string usage = Util.getRecords(value, 5, -1);

                    int parent;

                    tooltip = prototype;
                    if (Util.isFile(fileName))
                        {
                        parent = parentScripted;
                        tooltip = tooltip + '\n' + "Declared in: " + fileName + ":" + lineNumber;
                        }
                    else
                        parent = parentNative;

                    tooltip = tooltip + "\n\n" + usage;

                    int id = this.insertItem(parent, prototype, fileName + '\n' + lineNumber, "", 1, 1);
                    this.setItemTooltip(id, tooltip);
                    }

                methods.delete();

                if (objectx.isMethod("getDebugInfo"))
                    {
                    ArrayObject debugInfo = objectx.getDebugInfo();
                    count = debugInfo.count();
                    int parent = this.insertItem(0, "Debug Info", "", "", 1, 1);

                    for (int i = 0; i < count; i ++)
                        this.insertItem(parent, debugInfo.getKey(i) + ": " + debugInfo.getValue(i), "", "", 1, 1);

                    debugInfo.delete();
                    }

                this.sort(0, true);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onRightMouseUp(int item, string mousePos, SimObject objectx)
            {
                string value = this.getItemValue(item);
                if (value == "")
                    return;

                string fileName = Util.getRecord(value, 0);
                string lineNumber = Util.getRecord(value, 1);

                if (Util.isFile(fileName))
                    {
                    GuiCanvas Canvas = "Canvas";

                    MenuBuilder GuiInspectorMethodListPopup = "GuiInspectorMethodListPopup";

                    if (!GuiInspectorMethodListPopup.isObject())
                        {
                        ObjectCreator ocf = new ObjectCreator("PopupMenu", "GuiInspectorMethodListPopup", typeof (MenuBuilder));
                        ocf["isPopup"] = true.AsString();

                        ocf["item[0]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' + "EditorOpenFileInTorsion( this.jumpFileName, this.jumpLineNumber );";

                        ocf["jumpFileName"] = "";
                        ocf["jumpLineNumber"] = "";

                        GuiInspectorMethodListPopup = ocf.Create();
                        }

                    GuiInspectorMethodListPopup["jumpFileName"] = fileName;
                    GuiInspectorMethodListPopup["jumpLineNumber"] = lineNumber;

                    GuiInspectorMethodListPopup.showPopup(Canvas);
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiObjectInspectorMethodList ts, string simobjectid)
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
            public static bool operator !=(GuiObjectInspectorMethodList ts, string simobjectid)
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
            public static implicit operator string(GuiObjectInspectorMethodList ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorMethodList(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiObjectInspectorMethodList) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorMethodList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiObjectInspectorMethodList ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorMethodList(int simobjectid)
            {
                return (GuiObjectInspectorMethodList) Omni.self.getSimObject((uint) simobjectid, typeof (GuiObjectInspectorMethodList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiObjectInspectorMethodList ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorMethodList(uint simobjectid)
            {
                return (GuiObjectInspectorMethodList) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorMethodList));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiObjectInspectorTree>))]
        public class GuiObjectInspectorTree : GuiTreeViewCtrl
        {
            public GuiInspector inspectorCtrl
            {
                get { return this["inspectorCtrl"]; }
                set { this["inspectorCtrl"] = value; }
            }

            public GuiObjectInspectorMethodList methodList
            {
                get { return this["methodList"]; }
                set { this["methodList"] = value; }
            }

            [ConsoleInteraction]
            public override void onSelect(string objectx, string y)
            {
                if (objectx.isObject())
                    {
                    this.inspectorCtrl.inspect(objectx);
                    this.methodList.init(objectx);
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public override void onRightMouseUp(int itemId, string mousePos, SimObject objectx)
            {
                MenuBuilder GuiObjectInspectorTreePopup = "GuiObjectInspectorTreePopup";
                GuiCanvas Canvas = "Canvas";

                if (!GuiObjectInspectorTreePopup.isObject())
                    {
                    ObjectCreator ocf = new ObjectCreator("PopupMenu", "GuiObjectInspectorTreePopup", typeof (MenuBuilder));
                    ocf["isPopup"] = true.AsString();

                    ocf["item[0]"] = "Jump to Definition in Torsion" + '\t' + "" + '\t' + "EditorOpenDeclarationInTorsion( GuiObjectInspectorTreePopup.object );";

                    ocf["object"] = "";

                    GuiObjectInspectorTreePopup = ocf.Create();
                    }

                GuiObjectInspectorTreePopup["object"] = objectx;
                GuiObjectInspectorTreePopup.showPopup(Canvas);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiObjectInspectorTree ts, string simobjectid)
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
            public static bool operator !=(GuiObjectInspectorTree ts, string simobjectid)
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
            public static implicit operator string(GuiObjectInspectorTree ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTree(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiObjectInspectorTree) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiObjectInspectorTree ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTree(int simobjectid)
            {
                return (GuiObjectInspectorTree) Omni.self.getSimObject((uint) simobjectid, typeof (GuiObjectInspectorTree));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiObjectInspectorTree ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTree(uint simobjectid)
            {
                return (GuiObjectInspectorTree) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorTree));
            }

            #endregion
        }

        //=============================================================================================
        //    GuiObjectInspectorTreeFilter
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiObjectInspectorTreeFilter>))]
        public class GuiObjectInspectorTreeFilter : treeViewFilterCtrls.GuiTreeViewFilterText
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiTreeViewCtrl treeView = ((GuiControl) this.getParent()).FOT("TreeView");
                if (treeView.isObject())
                    this["treeView"] = treeView;

                base.onWake();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiObjectInspectorTreeFilter ts, string simobjectid)
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
            public static bool operator !=(GuiObjectInspectorTreeFilter ts, string simobjectid)
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
            public static implicit operator string(GuiObjectInspectorTreeFilter ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTreeFilter(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiObjectInspectorTreeFilter) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorTreeFilter));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiObjectInspectorTreeFilter ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTreeFilter(int simobjectid)
            {
                return (GuiObjectInspectorTreeFilter) Omni.self.getSimObject((uint) simobjectid, typeof (GuiObjectInspectorTreeFilter));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiObjectInspectorTreeFilter ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTreeFilter(uint simobjectid)
            {
                return (GuiObjectInspectorTreeFilter) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorTreeFilter));
            }

            #endregion
        }

        //=============================================================================================
        //    GuiObjectInspectorTreeFilter
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiObjectInspectorTreeFilterClearButton>))]
        public class GuiObjectInspectorTreeFilterClearButton : GuiBitmapButtonCtrl
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiTextEditCtrl filterText = ((GuiControl) this.getParent()).FOT("FilterText");
                if (filterText.isObject())
                    this["textCtrl"] = filterText;
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiObjectInspectorTreeFilterClearButton ts, string simobjectid)
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
            public static bool operator !=(GuiObjectInspectorTreeFilterClearButton ts, string simobjectid)
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
            public static implicit operator string(GuiObjectInspectorTreeFilterClearButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTreeFilterClearButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiObjectInspectorTreeFilterClearButton) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorTreeFilterClearButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiObjectInspectorTreeFilterClearButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTreeFilterClearButton(int simobjectid)
            {
                return (GuiObjectInspectorTreeFilterClearButton) Omni.self.getSimObject((uint) simobjectid, typeof (GuiObjectInspectorTreeFilterClearButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiObjectInspectorTreeFilterClearButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiObjectInspectorTreeFilterClearButton(uint simobjectid)
            {
                return (GuiObjectInspectorTreeFilterClearButton) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspectorTreeFilterClearButton));
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
        public static bool operator ==(GuiObjectInspector ts, string simobjectid)
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
        public static bool operator !=(GuiObjectInspector ts, string simobjectid)
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
        public static implicit operator string(GuiObjectInspector ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiObjectInspector(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiObjectInspector) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiObjectInspector ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiObjectInspector(int simobjectid)
        {
            return (GuiObjectInspector) Omni.self.getSimObject((uint) simobjectid, typeof (GuiObjectInspector));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiObjectInspector ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiObjectInspector(uint simobjectid)
        {
            return (GuiObjectInspector) Omni.self.getSimObject(simobjectid, typeof (GuiObjectInspector));
        }

        #endregion
    }
}