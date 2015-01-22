﻿// WinterLeaf Entertainment
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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorPrefsDlg>))]
    public class GuiEditorPrefsDlg : GuiControl
    {

        [ConsoleInteraction(true, "GuiEditorPrefsDlg_initialize")]
        public static void initialize()
        {
            #region GuiControl (GuiEditorPrefsDlg, EditorGuiGroup)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "GuiEditorPrefsDlg, EditorGuiGroup", typeof (GuiEditorPrefsDlg));
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["Extent"] = "800 600";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject8["HorizSizing"] = "center";
            oc_Newobject8["VertSizing"] = "center";
            oc_Newobject8["position"] = "250 210";
            oc_Newobject8["Extent"] = "280 95";
            oc_Newobject8["MinExtent"] = "344 144";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["resizeWidth"] = "0";
            oc_Newobject8["resizeHeight"] = "0";
            oc_Newobject8["canMove"] = "1";
            oc_Newobject8["canClose"] = "1";
            oc_Newobject8["canMinimize"] = "0";
            oc_Newobject8["canMaximize"] = "0";
            oc_Newobject8["minSize"] = "50 50";
            oc_Newobject8["closeCommand"] = "Canvas.popDialog(\\\"GuiEditorPrefsDlg\\\");";
            oc_Newobject8["EdgeSnap"] = "0";
            oc_Newobject8["text"] = "Gui Editor Grid Preferences";

            #region GuiButtonCtrl (GuiEditorPrefsDlgCancelBtn)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "GuiEditorPrefsDlgCancelBtn", typeof (GuiEditorPrefsDlgCancelBtn));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "left";
            oc_Newobject1["VertSizing"] = "top";
            oc_Newobject1["position"] = "100 60";
            oc_Newobject1["Extent"] = "80 25";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Accelerator"] = "escape";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["text"] = "Cancel";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl (GuiEditorPrefsDlgOkBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "GuiEditorPrefsDlgOkBtn", typeof (GuiEditorPrefsDlgOkBtn));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "top";
            oc_Newobject2["position"] = "190 60";
            oc_Newobject2["Extent"] = "80 25";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["text"] = "Ok";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl (GuiEditorPrefsDlgDefaultsBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "GuiEditorPrefsDlgDefaultsBtn", typeof (GuiEditorPrefsDlgDefaultsBtn));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "top";
            oc_Newobject3["position"] = "10 60";
            oc_Newobject3["Extent"] = "60 24";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "Reset";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject8["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject7["HorizSizing"] = "center";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "-3 20";
            oc_Newobject7["Extent"] = "288 48";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "16 10";
            oc_Newobject4["Extent"] = "48 18";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["text"] = "Grid Size:";
            oc_Newobject4["maxLength"] = "1024";

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiTextEditCtrl (GuiEditorPrefsDlgGridEdit)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextEditCtrl", "GuiEditorPrefsDlgGridEdit", typeof (GuiEditorPrefsDlgGridEdit));
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "textEdit";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["Component"] = "textEdit";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "72 11";
            oc_Newobject5["Extent"] = "32 18";
            oc_Newobject5["MinExtent"] = "8 18";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "GuiEditorPrefsDlgGridEdit.onAction();";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["historySize"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["tabComplete"] = "0";
            oc_Newobject5["sinkAllKeyEvents"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["passwordMask"] = "*";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiSliderCtrl (GuiEditorPrefsDlgGridSlider)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiSliderCtrl", "GuiEditorPrefsDlgGridSlider", typeof (GuiEditorPrefsDlgGridSlider));
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["internalName"] = "Slider";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["Component"] = "Slider";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "112 14";
            oc_Newobject6["Extent"] = "160 12";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["AltCommand"] = "GuiEditorPrefsDlgGridSlider.onAction();";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["range"] = "0 64";
            oc_Newobject6["ticks"] = "0";
            oc_Newobject6["value"] = "0";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();

            iGlobal["$GuiEditor::defaultGridSize"] = 8;
            iGlobal["$GuiEditor::minGridSize"] = 3;
        }

        //-----------------------------------------------------------------------------------------
        // Buttons
        //  -----------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorPrefsDlgCancelBtn>))]
        public class GuiEditorPrefsDlgCancelBtn : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onAction()
            {
                GuiEditorPrefsDlg GuiEditorPrefsDlg = "GuiEditorPrefsDlg";
                GuiCanvas Canvas = "Canvas";

                Canvas.popDialog(GuiEditorPrefsDlg);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorPrefsDlgCancelBtn ts, string simobjectid)
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
            public static bool operator !=(GuiEditorPrefsDlgCancelBtn ts, string simobjectid)
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
            public static implicit operator string(GuiEditorPrefsDlgCancelBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgCancelBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorPrefsDlgCancelBtn) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgCancelBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorPrefsDlgCancelBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgCancelBtn(int simobjectid)
            {
                return (GuiEditorPrefsDlgCancelBtn) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorPrefsDlgCancelBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorPrefsDlgCancelBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgCancelBtn(uint simobjectid)
            {
                return (GuiEditorPrefsDlgCancelBtn) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgCancelBtn));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorPrefsDlgDefaultsBtn>))]
        public class GuiEditorPrefsDlgDefaultsBtn : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onAction()
            {
                GuiEditorPrefsDlgGridSlider GuiEditorPrefsDlgGridSlider = "GuiEditorPrefsDlgGridSlider";

                GuiEditorPrefsDlgGridSlider.setValue(sGlobal["$GuiEditor::defaultGridSize"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorPrefsDlgDefaultsBtn ts, string simobjectid)
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
            public static bool operator !=(GuiEditorPrefsDlgDefaultsBtn ts, string simobjectid)
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
            public static implicit operator string(GuiEditorPrefsDlgDefaultsBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgDefaultsBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorPrefsDlgDefaultsBtn) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgDefaultsBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorPrefsDlgDefaultsBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgDefaultsBtn(int simobjectid)
            {
                return (GuiEditorPrefsDlgDefaultsBtn) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorPrefsDlgDefaultsBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorPrefsDlgDefaultsBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgDefaultsBtn(uint simobjectid)
            {
                return (GuiEditorPrefsDlgDefaultsBtn) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgDefaultsBtn));
            }

            #endregion
        }

        //-----------------------------------------------------------------------------------------
        // Grid
        //-----------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorPrefsDlgGridEdit>))]
        public class GuiEditorPrefsDlgGridEdit : GuiTextEditCtrl
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                this.setValue(GuiEditor["snap2gridsize"]);
            }

            [ConsoleInteraction]
            public override void onAction()
            {
                GuiEditorPrefsDlgGridSlider GuiEditorPrefsDlgGridSlider = "GuiEditorPrefsDlgGridSlider";

                float value = this.getValue().AsFloat();
                if (value < fGlobal["$GuiEditor::minGridSize"])
                    {
                    value = fGlobal["$GuiEditor::minGridSize"];
                    this.setValue(value.AsString());
                    }

                GuiEditorPrefsDlgGridSlider.setValue(value.AsString());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorPrefsDlgGridEdit ts, string simobjectid)
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
            public static bool operator !=(GuiEditorPrefsDlgGridEdit ts, string simobjectid)
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
            public static implicit operator string(GuiEditorPrefsDlgGridEdit ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgGridEdit(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorPrefsDlgGridEdit) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgGridEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorPrefsDlgGridEdit ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgGridEdit(int simobjectid)
            {
                return (GuiEditorPrefsDlgGridEdit) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorPrefsDlgGridEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorPrefsDlgGridEdit ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgGridEdit(uint simobjectid)
            {
                return (GuiEditorPrefsDlgGridEdit) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgGridEdit));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorPrefsDlgGridSlider>))]
        public class GuiEditorPrefsDlgGridSlider : GuiSliderCtrl
        {
            [ConsoleInteraction]
            public override void onWake()
            {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                this.setValue(GuiEditor["snap2gridsize"]);
            }

            [ConsoleInteraction]
            public override void onAction()
            {
                GuiEditorPrefsDlgGridEdit GuiEditorPrefsDlgGridEdit = "GuiEditorPrefsDlgGridEdit";

                float value = this.value;
                if (value < fGlobal["$GuiEditor::minGridSize"])
                    {
                    value = fGlobal["$GuiEditor::minGridSize"];
                    this.setValue(value.AsString());
                    }

                GuiEditorPrefsDlgGridEdit.setValue(Util.mCeil(value).AsString());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorPrefsDlgGridSlider ts, string simobjectid)
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
            public static bool operator !=(GuiEditorPrefsDlgGridSlider ts, string simobjectid)
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
            public static implicit operator string(GuiEditorPrefsDlgGridSlider ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgGridSlider(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorPrefsDlgGridSlider) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgGridSlider));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorPrefsDlgGridSlider ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgGridSlider(int simobjectid)
            {
                return (GuiEditorPrefsDlgGridSlider) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorPrefsDlgGridSlider));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorPrefsDlgGridSlider ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgGridSlider(uint simobjectid)
            {
                return (GuiEditorPrefsDlgGridSlider) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgGridSlider));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorPrefsDlgOkBtn>))]
        public class GuiEditorPrefsDlgOkBtn : GuiButtonCtrl
        {
            [ConsoleInteraction]
            public override void onAction()
            {
                GuiEditorPrefsDlg GuiEditorPrefsDlg = "GuiEditorPrefsDlg";
                GuiEditorPrefsDlgGridEdit GuiEditorPrefsDlgGridEdit = "GuiEditorPrefsDlgGridEdit";
                GuiCanvas Canvas = "Canvas";

                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
                GuiEditor["snap2gridsize"] = GuiEditorPrefsDlgGridEdit.getValue();
                if (GuiEditor["snap2grid"].AsBool())
                    GuiEditor.setSnapToGrid(GuiEditor["snap2gridsize"].AsUint());

                Canvas.popDialog(GuiEditorPrefsDlg);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorPrefsDlgOkBtn ts, string simobjectid)
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
            public static bool operator !=(GuiEditorPrefsDlgOkBtn ts, string simobjectid)
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
            public static implicit operator string(GuiEditorPrefsDlgOkBtn ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgOkBtn(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorPrefsDlgOkBtn) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgOkBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorPrefsDlgOkBtn ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgOkBtn(int simobjectid)
            {
                return (GuiEditorPrefsDlgOkBtn) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorPrefsDlgOkBtn));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorPrefsDlgOkBtn ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorPrefsDlgOkBtn(uint simobjectid)
            {
                return (GuiEditorPrefsDlgOkBtn) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlgOkBtn));
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
        public static bool operator ==(GuiEditorPrefsDlg ts, string simobjectid)
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
        public static bool operator !=(GuiEditorPrefsDlg ts, string simobjectid)
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
        public static implicit operator string(GuiEditorPrefsDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorPrefsDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorPrefsDlg) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorPrefsDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorPrefsDlg(int simobjectid)
        {
            return (GuiEditorPrefsDlg) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorPrefsDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorPrefsDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorPrefsDlg(uint simobjectid)
        {
            return (GuiEditorPrefsDlg) Omni.self.getSimObject(simobjectid, typeof (GuiEditorPrefsDlg));
        }

        #endregion
    }
}