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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<MessageBoxSaveChangesDlg>))]
    public class MessageBoxSaveChangesDlg : GuiControl
    {

        [ConsoleInteraction(true, "MessageBoxSaveChangesDlg_initialize")]
        public static void initialize()
        {
            #region GuiControl (MessageBoxSaveChangesDlg, EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "MessageBoxSaveChangesDlg, EditorGuiGroup", typeof (MessageBoxSaveChangesDlg));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiWindowCtrl (MBSaveChangesFrame)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiWindowCtrl", "MBSaveChangesFrame");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject7["HorizSizing"] = "center";
            oc_Newobject7["VertSizing"] = "center";
            oc_Newobject7["position"] = "362 274";
            oc_Newobject7["Extent"] = "340 164";
            oc_Newobject7["MinExtent"] = "48 92";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Save Changes";
            oc_Newobject7["maxLength"] = "255";
            oc_Newobject7["resizeWidth"] = "1";
            oc_Newobject7["resizeHeight"] = "1";
            oc_Newobject7["canMove"] = "1";
            oc_Newobject7["canClose"] = "0";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["minSize"] = "50 50";

            #region GuiIconButtonCtrl (mbSaveDlgSaveButton)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiIconButtonCtrl", "mbSaveDlgSaveButton", typeof (mbSaveDlgSaveButton));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "240 117";
            oc_Newobject1["Extent"] = "83 25";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["text"] = "Save";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["iconBitmap"] = "~/levelEditor/gui/images/iconAccept.png";
            oc_Newobject1["sizeIconToButton"] = "0";
            oc_Newobject1["textLocation"] = "Center";
            oc_Newobject1["textMargin"] = "4";
            oc_Newobject1["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject7["#Newobject1"] = oc_Newobject1;

            #region GuiIconButtonCtrl (mbSaveDlgCancelButton)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiIconButtonCtrl", "mbSaveDlgCancelButton", typeof (mbSaveDlgCancelButton));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "158 117";
            oc_Newobject2["Extent"] = "83 25";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["text"] = "Cancel";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["iconBitmap"] = "~/levelEditor/gui/images/iconCancel.png";
            oc_Newobject2["sizeIconToButton"] = "0";
            oc_Newobject2["textLocation"] = "Center";
            oc_Newobject2["textMargin"] = "4";
            oc_Newobject2["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region GuiIconButtonCtrl (mbSaveDlgDontButton)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiIconButtonCtrl", "mbSaveDlgDontButton", typeof (mbSaveDlgDontButton));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "14 117";
            oc_Newobject3["Extent"] = "124 25";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "Don\'t Save";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["sizeIconToButton"] = "0";
            oc_Newobject3["textLocation"] = "Center";
            oc_Newobject3["textMargin"] = "4";
            oc_Newobject3["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "13 31";
            oc_Newobject6["Extent"] = "310 73";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Profile"] = "EditorTextHLBoldLeft";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "15 9";
            oc_Newobject4["Extent"] = "281 26";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["text"] = "Do you want to save changes to this document?";
            oc_Newobject4["maxLength"] = "1024";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "15 38";
            oc_Newobject5["Extent"] = "258 21";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = "If you don\'t save, your changes may be lost.";
            oc_Newobject5["maxLength"] = "1024";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
        }

        [ConsoleInteraction]
        public override void onWake()
        {
            GuiWindowCtrl MBSaveChangesFrame = "MBSaveChangesFrame";
            MBSaveChangesFrame.setWindowTitle(this["Data"]);
        }

        [ConsoleInteraction]
        // Deprecated when platform layers are all sufficient
        public static void checkSaveChangesOld(string data, string saveCallback, string dontSaveCallback)
        {
            MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
            GuiCanvas Canvas = "Canvas";

            // Sanity Check
            if (MessageBoxSaveChangesDlg.isAwake())
                {
                Util._warn("Save Changes Dialog already Awake, NOT creating second instance.");
                return;
                }

            // Set Proper State
            MessageBoxSaveChangesDlg["SaveCallback"] = saveCallback;
            MessageBoxSaveChangesDlg["DontSaveCallback"] = dontSaveCallback;
            MessageBoxSaveChangesDlg["Data"] = data;

            // Show Dialog
            Canvas.pushDialog(MessageBoxSaveChangesDlg);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MessageBoxSaveChangesDlg ts, string simobjectid)
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
        public static bool operator !=(MessageBoxSaveChangesDlg ts, string simobjectid)
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
        public static implicit operator string(MessageBoxSaveChangesDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MessageBoxSaveChangesDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (MessageBoxSaveChangesDlg) Omni.self.getSimObject(simobjectid, typeof (MessageBoxSaveChangesDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MessageBoxSaveChangesDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MessageBoxSaveChangesDlg(int simobjectid)
        {
            return (MessageBoxSaveChangesDlg) Omni.self.getSimObject((uint) simobjectid, typeof (MessageBoxSaveChangesDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MessageBoxSaveChangesDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MessageBoxSaveChangesDlg(uint simobjectid)
        {
            return (MessageBoxSaveChangesDlg) Omni.self.getSimObject(simobjectid, typeof (MessageBoxSaveChangesDlg));
        }

        #endregion

        [TypeConverter(typeof (TypeConverterGeneric<mbSaveDlgCancelButton>))]
        public class mbSaveDlgCancelButton : GuiIconButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
                GuiCanvas Canvas = "Canvas";

                Canvas.popDialog(MessageBoxSaveChangesDlg);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(mbSaveDlgCancelButton ts, string simobjectid)
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
            public static bool operator !=(mbSaveDlgCancelButton ts, string simobjectid)
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
            public static implicit operator string(mbSaveDlgCancelButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgCancelButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (mbSaveDlgCancelButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgCancelButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(mbSaveDlgCancelButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgCancelButton(int simobjectid)
            {
                return (mbSaveDlgCancelButton) Omni.self.getSimObject((uint) simobjectid, typeof (mbSaveDlgCancelButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(mbSaveDlgCancelButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator mbSaveDlgCancelButton(uint simobjectid)
            {
                return (mbSaveDlgCancelButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgCancelButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<mbSaveDlgDontButton>))]
        public class mbSaveDlgDontButton : GuiIconButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
                GuiCanvas Canvas = "Canvas";

                if (MessageBoxSaveChangesDlg["DontSaveCallback"] != "")
                    Util.eval(MessageBoxSaveChangesDlg["DontSaveCallback"] + "(" + MessageBoxSaveChangesDlg["Data"] + ");");
                Canvas.popDialog(MessageBoxSaveChangesDlg);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(mbSaveDlgDontButton ts, string simobjectid)
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
            public static bool operator !=(mbSaveDlgDontButton ts, string simobjectid)
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
            public static implicit operator string(mbSaveDlgDontButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgDontButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (mbSaveDlgDontButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgDontButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(mbSaveDlgDontButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgDontButton(int simobjectid)
            {
                return (mbSaveDlgDontButton) Omni.self.getSimObject((uint) simobjectid, typeof (mbSaveDlgDontButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(mbSaveDlgDontButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator mbSaveDlgDontButton(uint simobjectid)
            {
                return (mbSaveDlgDontButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgDontButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<mbSaveDlgSaveButton>))]
        public class mbSaveDlgSaveButton : GuiIconButtonCtrl
        {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
            {
                MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
                GuiCanvas Canvas = "Canvas";

                if (MessageBoxSaveChangesDlg["SaveCallback"] != "")
                    Util.eval(MessageBoxSaveChangesDlg["SaveCallback"] + "(" + MessageBoxSaveChangesDlg["Data"] + ");");
                Canvas.popDialog(MessageBoxSaveChangesDlg);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(mbSaveDlgSaveButton ts, string simobjectid)
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
            public static bool operator !=(mbSaveDlgSaveButton ts, string simobjectid)
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
            public static implicit operator string(mbSaveDlgSaveButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgSaveButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (mbSaveDlgSaveButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgSaveButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(mbSaveDlgSaveButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgSaveButton(int simobjectid)
            {
                return (mbSaveDlgSaveButton) Omni.self.getSimObject((uint) simobjectid, typeof (mbSaveDlgSaveButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(mbSaveDlgSaveButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator mbSaveDlgSaveButton(uint simobjectid)
            {
                return (mbSaveDlgSaveButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgSaveButton));
            }

            #endregion
        }
    }
}