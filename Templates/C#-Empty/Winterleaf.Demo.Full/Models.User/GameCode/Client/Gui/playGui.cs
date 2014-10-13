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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    [TypeConverter(typeof (TypeConverterGeneric<playGui>))]
    public class playGui : GameTSCtrl
    {
        public static void initialize()
        {
            #region GameTSCtrl (PlayGui)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GameTSCtrl", "PlayGui", typeof (playGui));
            oc_Newobject20["cameraZRot"] = "0";
            oc_Newobject20["forceFOV"] = "0";
            oc_Newobject20["reflectPriority"] = "1";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "GuiContentProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["Extent"] = "1024 768";
            oc_Newobject20["MinExtent"] = "8 8";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "1";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["helpTag"] = "0";
            oc_Newobject20["noCursor"] = "1";

            #region GuiBitmapCtrl (CenterPrintDlg)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "CenterPrintDlg");
            oc_Newobject2["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject2["wrap"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "CenterPrintProfile";
            oc_Newobject2["HorizSizing"] = "center";
            oc_Newobject2["VertSizing"] = "center";
            oc_Newobject2["position"] = "237 375";
            oc_Newobject2["Extent"] = "550 20";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "0";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiMLTextCtrl (CenterPrintText)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiMLTextCtrl", "CenterPrintText", typeof (printText));
            oc_Newobject1["lineSpacing"] = "2";
            oc_Newobject1["allowColorChars"] = "0";
            oc_Newobject1["maxChars"] = "-1";
            oc_Newobject1["useURLMouseCursor"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "CenterPrintTextProfile";
            oc_Newobject1["HorizSizing"] = "center";
            oc_Newobject1["VertSizing"] = "center";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["Extent"] = "546 12";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject20["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapCtrl (BottomPrintDlg)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "BottomPrintDlg");
            oc_Newobject4["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject4["wrap"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "CenterPrintProfile";
            oc_Newobject4["HorizSizing"] = "center";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["position"] = "237 719";
            oc_Newobject4["Extent"] = "550 20";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "0";
            oc_Newobject4["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiMLTextCtrl (BottomPrintText)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiMLTextCtrl", "BottomPrintText", typeof (printText));
            oc_Newobject3["lineSpacing"] = "2";
            oc_Newobject3["allowColorChars"] = "0";
            oc_Newobject3["maxChars"] = "-1";
            oc_Newobject3["useURLMouseCursor"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "CenterPrintTextProfile";
            oc_Newobject3["HorizSizing"] = "center";
            oc_Newobject3["VertSizing"] = "center";
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["Extent"] = "546 12";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject20["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl (LagIcon)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "LagIcon");
            oc_Newobject5["bitmap"] = "art/gui/lagIcon.png";
            oc_Newobject5["wrap"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "GuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "572 3";
            oc_Newobject5["Extent"] = "32 32";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "0";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject20.Create();
        }

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onWake()
        {
            // Turn off any shell sounds...
            // sfxStop( ... );

            bGlobal["$enableDirectInput"] = true;
            Util.activateDirectInput();

            // just update the action map here
            ((ActionMap) "moveMap").push();

            refreshCenterTextCtrl();
            refreshBottomTextCtrl();
        }

        public override void onSleep()
        {
            // pop the keymaps
            ((ActionMap) "moveMap").pop();
        }

        public virtual void clearHud()
        {
            ((GuiCanvas) "Canvas").popDialog("MainChatHud");

            while (getCount() > 0)
                getObject(0).delete();
        }

        public void refreshBottomTextCtrl()
        {
            ((GuiMLTextCtrl) "BottomPrintText").position = new Point2I(0, 0);
        }

        public void refreshCenterTextCtrl()
        {
            ((GuiMLTextCtrl) "CenterPrintText").position = new Point2I(0, 0);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(playGui ts, string simobjectid)
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
        public static bool operator !=(playGui ts, string simobjectid)
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
        public static implicit operator string(playGui ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator playGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (playGui) Omni.self.getSimObject(simobjectid, typeof (playGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(playGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator playGui(int simobjectid)
        {
            return (playGui) Omni.self.getSimObject((uint) simobjectid, typeof (playGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(playGui ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator playGui(uint simobjectid)
        {
            return (playGui) Omni.self.getSimObject(simobjectid, typeof (playGui));
        }

        #endregion
    }
}