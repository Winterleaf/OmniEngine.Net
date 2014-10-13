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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<SetTitle>))]
    public class SetTitle : GuiControl
    {
        public GuiWindowCtrl ctrl
        {
            get { return this["ctrl"]; }
            set { this["ctrl"] = value; }
        }

        [ConsoleInteraction(true, "SetTitle_initialize")]
        public static void initialize()
        {
            #region GuiControl (setTitle, IngameGuiGroup)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "SetTitle, IngameGuiGroup", typeof (SetTitle));
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["extent"] = "1024 768";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["maxExtent"] = "500 500";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiDefaultProfile";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["hideControl"] = "0";
            oc_Newobject7["moveControl"] = "0";
            oc_Newobject7["lockControl"] = "0";
            oc_Newobject7["windowSettings"] = "1";
            oc_Newobject7["alpha"] = "1";
            oc_Newobject7["mouseOverAlpha"] = "1";
            oc_Newobject7["alphaFade"] = "1";
            oc_Newobject7["editable"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "1";
            oc_Newobject7["hideControl"] = "0";
            oc_Newobject7["hideControl"] = "0";
            oc_Newobject7["hideControl"] = "0";
            oc_Newobject7["hideControl"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject6["text"] = "Set Title";
            oc_Newobject6["resizeWidth"] = "1";
            oc_Newobject6["resizeHeight"] = "1";
            oc_Newobject6["canMove"] = "1";
            oc_Newobject6["canClose"] = "1";
            oc_Newobject6["canMinimize"] = "1";
            oc_Newobject6["canMaximize"] = "1";
            oc_Newobject6["canCollapse"] = "0";
            oc_Newobject6["edgeSnap"] = "1";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["position"] = "308 211";
            oc_Newobject6["extent"] = "233 124";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "500 500";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiWindowProfile";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["hideControl"] = "0";
            oc_Newobject6["moveControl"] = "1";
            oc_Newobject6["lockControl"] = "0";
            oc_Newobject6["windowSettings"] = "1";
            oc_Newobject6["alpha"] = "1";
            oc_Newobject6["mouseOverAlpha"] = "1";
            oc_Newobject6["alphaFade"] = "1";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["hideControl"] = "0";
            oc_Newobject6["hideControl"] = "0";
            oc_Newobject6["hideControl"] = "0";
            oc_Newobject6["hideControl"] = "0";
            oc_Newobject6["closeCommand"] = "Canvas.popDialog(setTitle); setTitle.resetValue();";

            #region GuiControl (SetTitleControl)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "SetTitleControl");
            oc_Newobject3["position"] = "36 28";
            oc_Newobject3["extent"] = "173 41";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["maxExtent"] = "500 500";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiDefaultProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["hideControl"] = "0";
            oc_Newobject3["moveControl"] = "1";
            oc_Newobject3["lockControl"] = "0";
            oc_Newobject3["windowSettings"] = "1";
            oc_Newobject3["alpha"] = "1";
            oc_Newobject3["mouseOverAlpha"] = "1";
            oc_Newobject3["alphaFade"] = "1";
            oc_Newobject3["editable"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["hideControl"] = "0";
            oc_Newobject3["hideControl"] = "0";
            oc_Newobject3["hideControl"] = "0";
            oc_Newobject3["hideControl"] = "0";

            #region GuiTextEditCtrl (TitleText)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "TitleText");
            oc_Newobject1["historySize"] = "0";
            oc_Newobject1["tabComplete"] = "0";
            oc_Newobject1["sinkAllKeyEvents"] = "0";
            oc_Newobject1["password"] = "0";
            oc_Newobject1["passwordMask"] = "*";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "63 11";
            oc_Newobject1["extent"] = "100 18";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "500 500";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiTextEditProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["hideControl"] = "0";
            oc_Newobject1["moveControl"] = "0";
            oc_Newobject1["lockControl"] = "0";
            oc_Newobject1["windowSettings"] = "1";
            oc_Newobject1["alpha"] = "1";
            oc_Newobject1["mouseOverAlpha"] = "1";
            oc_Newobject1["alphaFade"] = "1";
            oc_Newobject1["editable"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["hideControl"] = "0";
            oc_Newobject1["hideControl"] = "0";
            oc_Newobject1["hideControl"] = "0";
            oc_Newobject1["hideControl"] = "0";
            oc_Newobject1["command"] = "setTitle.setTitle($ThisControl.getValue());";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["text"] = "Title name";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "0 6";
            oc_Newobject2["extent"] = "64 28";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "500 500";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiTextProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["hideControl"] = "0";
            oc_Newobject2["moveControl"] = "0";
            oc_Newobject2["lockControl"] = "0";
            oc_Newobject2["windowSettings"] = "1";
            oc_Newobject2["alpha"] = "1";
            oc_Newobject2["mouseOverAlpha"] = "1";
            oc_Newobject2["alphaFade"] = "1";
            oc_Newobject2["editable"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["hideControl"] = "0";
            oc_Newobject2["hideControl"] = "0";
            oc_Newobject2["hideControl"] = "0";
            oc_Newobject2["hideControl"] = "0";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject4["text"] = "OK";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["position"] = "19 76";
            oc_Newobject4["extent"] = "88 30";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["maxExtent"] = "500 500";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiButtonProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["hideControl"] = "0";
            oc_Newobject4["moveControl"] = "0";
            oc_Newobject4["lockControl"] = "0";
            oc_Newobject4["windowSettings"] = "1";
            oc_Newobject4["alpha"] = "1";
            oc_Newobject4["mouseOverAlpha"] = "1";
            oc_Newobject4["alphaFade"] = "1";
            oc_Newobject4["editable"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["hideControl"] = "0";
            oc_Newobject4["hideControl"] = "0";
            oc_Newobject4["hideControl"] = "0";
            oc_Newobject4["hideControl"] = "0";
            oc_Newobject4["command"] = "Canvas.popDialog(setTitle); GuiEditorTreeView.update();";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject5["text"] = "Cancel";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["position"] = "126 76";
            oc_Newobject5["extent"] = "88 30";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "500 500";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiButtonProfile";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["hideControl"] = "0";
            oc_Newobject5["moveControl"] = "0";
            oc_Newobject5["lockControl"] = "0";
            oc_Newobject5["windowSettings"] = "1";
            oc_Newobject5["alpha"] = "1";
            oc_Newobject5["mouseOverAlpha"] = "1";
            oc_Newobject5["alphaFade"] = "1";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["hideControl"] = "0";
            oc_Newobject5["hideControl"] = "0";
            oc_Newobject5["hideControl"] = "0";
            oc_Newobject5["hideControl"] = "0";
            oc_Newobject5["command"] = "Canvas.popDialog(setTitle); setTitle.resetValue();";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject7.Create();
        }

        [ConsoleInteraction]
        public void loadDialog(GuiWindowCtrl ctrl)
        {
            GuiCanvas Canvas = "Canvas";
            GuiTextEditCtrl TitleText = "TitleText";

            this.ctrl = ctrl;
            this["oldTitleName"] = ctrl.getWindowTitle();
            Canvas.pushDialog(this);
            TitleText.text = this["oldTitleName"];
        }

        [ConsoleInteraction]
        public void resetValue()
        {
            this.setTitle(this["oldTitleName"]);
        }

        [ConsoleInteraction]
        public void setTitle(string value)
        {
            this.ctrl.setWindowTitle(value);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SetTitle ts, string simobjectid)
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
        public static bool operator !=(SetTitle ts, string simobjectid)
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
        public static implicit operator string(SetTitle ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator SetTitle(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SetTitle) Omni.self.getSimObject(simobjectid, typeof (SetTitle));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SetTitle ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SetTitle(int simobjectid)
        {
            return (SetTitle) Omni.self.getSimObject((uint) simobjectid, typeof (SetTitle));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SetTitle ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SetTitle(uint simobjectid)
        {
            return (SetTitle) Omni.self.getSimObject(simobjectid, typeof (SetTitle));
        }

        #endregion
    }
}