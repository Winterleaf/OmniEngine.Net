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
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<RoadEditorToolbar>))]
    public class RoadEditorToolbar : GuiControl
    {
        [ConsoleInteraction(true, "RoadEditorToolbar_initialize")]
        public static void initialize()
        {
            #region GuiControl (RoadEditorToolbar)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "RoadEditorToolbar", typeof (RoadEditorToolbar));
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["internalName"] = "RoadEditorToolbar";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "306 0";
            oc_Newobject10["Extent"] = "800 32";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "0";
            oc_Newobject10["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "6 6";
            oc_Newobject1["extent"] = "70 20";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["text"] = "Road Settings";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["helpTag"] = "0";

            #endregion

            oc_Newobject10["#Newobject1"] = oc_Newobject1;

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject5["Position"] = "83 3";
            oc_Newobject5["extent"] = "111 32";
            oc_Newobject5["colCount"] = "31";
            oc_Newobject5["colSize"] = "29";
            oc_Newobject5["rowCount"] = "1";
            oc_Newobject5["RowSize"] = "27";
            oc_Newobject5["rowSpacing"] = "2";
            oc_Newobject5["colspacing"] = "4";

            #region GuiBitmapButtonCtrl (RoadEditorShowSplineBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "RoadEditorShowSplineBtn");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "167 3";
            oc_Newobject2["Extent"] = "29 27";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Variable"] = "$DecalRoad::showSpline";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["toolTip"] = "Show Spline";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/road-river/menubar/show-spline";
            oc_Newobject2["groupNum"] = "7";
            oc_Newobject2["buttonType"] = "ToggleButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["useInactiveState"] = "0";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (RoadEditorWireframeBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "RoadEditorWireframeBtn");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "253 3";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Variable"] = "$DecalRoad::wireframe";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["toolTip"] = "Show Wireframe";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/road-river/menubar/show-wireframe";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "ToggleButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["useInactiveState"] = "0";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (RoadEditorShowRoadBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "RoadEditorShowRoadBtn");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "GuiDefalutProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "89 3";
            oc_Newobject4["Extent"] = "29 27";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Variable"] = "$DecalRoad::showRoad";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["toolTip"] = "Show Road Texture";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/road-river/menubar/show-texture";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "ToggleButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["useInactiveState"] = "0";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiControl (RoadDefaultWidthTextEditContainer)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "RoadDefaultWidthTextEditContainer");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "197 5";
            oc_Newobject9["Extent"] = "120 50";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "0 6";
            oc_Newobject6["Extent"] = "68 10";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Default Width";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "textEdit";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "67 2";
            oc_Newobject7["Extent"] = "42 16";
            oc_Newobject7["MinExtent"] = "8 16";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "RoadEditorGui.DefaultWidth = $ThisControl.getValue();";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "10";
            oc_Newobject7["maxLength"] = "3";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "101 2";
            oc_Newobject8["Extent"] = "18 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "Canvas.pushDialog(RoadDefaultWidthSliderCtrlContainer);";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Changes Default Road Width";
            oc_Newobject8["hovertime"] = "750";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();

            #region GuiMouseEventCtrl (RoadDefaultWidthSliderCtrlContainer, EditorGuiGroup)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiMouseEventCtrl", "RoadDefaultWidthSliderCtrlContainer, EditorGuiGroup", typeof (RoadEditorGui.RoadDefaultWidthSliderCtrlContainer));
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "0 0";
            oc_Newobject12["extent"] = "1024 768";
            oc_Newobject12["minExtent"] = "8 8";
            oc_Newobject12["visible"] = "1";
            oc_Newobject12["helpTag"] = "0";
            //oc_Newobject12["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["internalName"] = "slider";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = new Creator.StringNoQuote("firstWord(RoadDefaultWidthTextEditContainer.position) + firstWord(RoadEditorToolbar.position) + 10 SPC          (getWord(RoadDefaultWidthTextEditContainer, 1)) + 25");
            oc_Newobject11["Extent"] = "112 20";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["AltCommand"] = "RoadDefaultWidthTextEditContainer-->textEdit.setText( mFloatLength($ThisControl.getValue(), 2)); RoadEditorGui.DefaultWidth = $ThisControl.getValue();";
            oc_Newobject11["range"] = "0 100";
            oc_Newobject11["ticks"] = "0";
            oc_Newobject11["value"] = "10";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject12.Create();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RoadEditorToolbar ts, string simobjectid)
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
        public static bool operator !=(RoadEditorToolbar ts, string simobjectid)
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
        public static implicit operator string(RoadEditorToolbar ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator RoadEditorToolbar(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (RoadEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (RoadEditorToolbar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RoadEditorToolbar ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RoadEditorToolbar(int simobjectid)
        {
            return (RoadEditorToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (RoadEditorToolbar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RoadEditorToolbar ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RoadEditorToolbar(uint simobjectid)
        {
            return (RoadEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (RoadEditorToolbar));
        }

        #endregion
    }
}