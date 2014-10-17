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
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Common
{
    [TypeConverter(typeof (TypeConverterGeneric<FrameOverlayGui>))]
    public class FrameOverlayGui : GuiControl
    {
        public static void initialize()
        {
            #region GuiControl (FrameOverlayGui)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiControl", "FrameOverlayGui", typeof (FrameOverlayGui));
            oc_Newobject2["profile"] = "GuiModelessDialogProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["extent"] = "640 350";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "True";
            oc_Newobject2["setFirstResponder"] = "False";
            oc_Newobject2["modal"] = "false";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["noCursor"] = new Creator.StringNoQuote("true");

            #region GuiWindowCtrl (MetricsWindow)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiWindowCtrl", "FrameOverlayGuiWindow");
            oc_Newobject22["text"] = "Metrics Display";
            oc_Newobject22["resizeWidth"] = "1";
            oc_Newobject22["resizeHeight"] = "1";
            oc_Newobject22["canMove"] = "1";
            oc_Newobject22["canClose"] = "0";
            oc_Newobject22["canMinimize"] = "0";
            oc_Newobject22["canMaximize"] = "0";
            oc_Newobject22["canCollapse"] = "0";
            oc_Newobject22["edgeSnap"] = "1";
            oc_Newobject22["setTitle"] = "0";
            oc_Newobject22["ShowTitle"] = "1";
            oc_Newobject22["AllowPopWindow"] = "1";
            oc_Newobject22["isInPopup"] = "0";
            oc_Newobject22["margin"] = "0 0 0 0";
            oc_Newobject22["padding"] = "0 0 0 0";
            oc_Newobject22["anchorTop"] = "1";
            oc_Newobject22["anchorBottom"] = "0";
            oc_Newobject22["anchorLeft"] = "1";
            oc_Newobject22["anchorRight"] = "0";
            oc_Newobject22["position"] = "0 20";
            oc_Newobject22["extent"] = "640 350";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["maxExtent"] = "1920 1080";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["profile"] = "GuiWindowProfile";
            oc_Newobject22["controlFontColor"] = "0 0 0 0";
            oc_Newobject22["controlFillColor"] = "0 0 0 0";
            oc_Newobject22["backgroundColor"] = "255 255 255 255";
            oc_Newobject22["controlFontSize"] = "14";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["alphaValue"] = "1";
            oc_Newobject22["mouseOverAlphaValue"] = "1";
            oc_Newobject22["alphaFadeTime"] = "1000";
            oc_Newobject22["moveControl"] = "1";
            oc_Newobject22["lockControl"] = "0";
            oc_Newobject22["windowSettings"] = "1";
            oc_Newobject22["alpha"] = "1";
            oc_Newobject22["mouseOverAlpha"] = "1";
            oc_Newobject22["alphaFade"] = "1";
            oc_Newobject22["contextFontColor"] = "0";
            oc_Newobject22["contextBackColor"] = "0";
            oc_Newobject22["contextFillColor"] = "0";
            oc_Newobject22["contextFontSize"] = "0";
            oc_Newobject22["editable"] = "0";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiPanel", "");
            oc_Newobject21["docking"] = "Top";
            oc_Newobject21["margin"] = "0 0 0 0";
            oc_Newobject21["padding"] = "0 0 0 0";
            oc_Newobject21["anchorTop"] = "1";
            oc_Newobject21["anchorBottom"] = "1";
            oc_Newobject21["anchorLeft"] = "1";
            oc_Newobject21["anchorRight"] = "1";
            oc_Newobject21["position"] = "1 0";
            oc_Newobject21["extent"] = "640 350";
            oc_Newobject21["minExtent"] = "16 16";
            oc_Newobject21["maxExtent"] = "1920 1080";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["profile"] = "GuiDefaultProfile";
            oc_Newobject21["controlFontColor"] = "0 0 0 0";
            oc_Newobject21["controlFillColor"] = "0 0 0 0";
            oc_Newobject21["backgroundColor"] = "255 255 255 255";
            oc_Newobject21["controlFontSize"] = "14";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["alphaValue"] = "1";
            oc_Newobject21["mouseOverAlphaValue"] = "1";
            oc_Newobject21["alphaFadeTime"] = "1000";
            oc_Newobject21["moveControl"] = "0";
            oc_Newobject21["lockControl"] = "0";
            oc_Newobject21["windowSettings"] = "1";
            oc_Newobject21["alpha"] = "1";
            oc_Newobject21["mouseOverAlpha"] = "1";
            oc_Newobject21["alphaFade"] = "1";
            oc_Newobject21["contextFontColor"] = "0";
            oc_Newobject21["contextBackColor"] = "0";
            oc_Newobject21["contextFillColor"] = "0";
            oc_Newobject21["contextFontSize"] = "0";
            oc_Newobject21["editable"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";

            #region GuiConsoleTextCtrl (TextOverlayControl)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiConsoleTextCtrl", "TextOverlayControl");
            oc_Newobject1["profile"] = "GuiConsoleTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 5";
            oc_Newobject1["extent"] = "130 18";
            oc_Newobject1["minExtent"] = "4 4";
            oc_Newobject1["visible"] = "True";
            oc_Newobject1["setFirstResponder"] = "True";
            oc_Newobject1["modal"] = "True";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["expression"] = "10";

            #endregion

            #endregion

            oc_Newobject21["#newobject1"] = oc_Newobject1;

            oc_Newobject22["#newobject1"] = oc_Newobject21;

            oc_Newobject2["#Newobject1"] = oc_Newobject22;

            //oc_Newobject21;

            #endregion

            oc_Newobject2.Create();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FrameOverlayGui ts, string simobjectid)
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
        public static bool operator !=(FrameOverlayGui ts, string simobjectid)
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
        public static implicit operator string(FrameOverlayGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator FrameOverlayGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (FrameOverlayGui) Omni.self.getSimObject(simobjectid, typeof (FrameOverlayGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(FrameOverlayGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FrameOverlayGui(int simobjectid)
        {
            return (FrameOverlayGui) Omni.self.getSimObject((uint) simobjectid, typeof (FrameOverlayGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(FrameOverlayGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FrameOverlayGui(uint simobjectid)
        {
            return (FrameOverlayGui) Omni.self.getSimObject(simobjectid, typeof (FrameOverlayGui));
        }

        #endregion
    }
}