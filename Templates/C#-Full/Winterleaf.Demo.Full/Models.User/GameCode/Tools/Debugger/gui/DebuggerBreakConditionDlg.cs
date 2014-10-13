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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui
{
    [TypeConverter(typeof (DebuggerBreakConditionDlg))]
    public class DebuggerBreakConditionDlg : GuiControl
    {
        [ConsoleInteraction(true, "DebuggerBreakConditionDlg_initialize")]
        public static void initialize()
        {
            #region GuiControl (DebuggerBreakConditionDlg, EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "DebuggerBreakConditionDlg, EditorGuiGroup", typeof (DebuggerBreakConditionDlg));
            oc_Newobject10["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["extent"] = "640 480";
            oc_Newobject10["minExtent"] = "8 8";
            oc_Newobject10["visible"] = "True";
            oc_Newobject10["setFirstResponder"] = "False";
            oc_Newobject10["modal"] = "True";
            oc_Newobject10["helpTag"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject9["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "220 146";
            oc_Newobject9["extent"] = "200 188";
            oc_Newobject9["minExtent"] = "8 8";
            oc_Newobject9["visible"] = "True";
            oc_Newobject9["setFirstResponder"] = "False";
            oc_Newobject9["modal"] = "True";
            oc_Newobject9["helpTag"] = "0";
            oc_Newobject9["text"] = "Set the break condition";
            oc_Newobject9["resizeWidth"] = "True";
            oc_Newobject9["resizeHeight"] = "True";
            oc_Newobject9["canMove"] = "False";
            oc_Newobject9["canClose"] = "False";
            oc_Newobject9["canMinimize"] = "False";
            oc_Newobject9["canMaximize"] = "False";
            oc_Newobject9["minSize"] = "50 50";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "20 28";
            oc_Newobject1["extent"] = "121 18";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "True";
            oc_Newobject1["setFirstResponder"] = "False";
            oc_Newobject1["modal"] = "True";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "Enter the break condition:";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (BreakCondition)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "BreakCondition");
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "20 44";
            oc_Newobject2["extent"] = "160 18";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "True";
            oc_Newobject2["setFirstResponder"] = "False";
            oc_Newobject2["modal"] = "True";
            oc_Newobject2["altCommand"] = "DbgBreakConditionSet();";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["historySize"] = "0";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["profile"] = "ToolsGuiTextProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "20 68";
            oc_Newobject3["extent"] = "57 18";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "True";
            oc_Newobject3["setFirstResponder"] = "False";
            oc_Newobject3["modal"] = "True";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["text"] = "Pass Count:";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl (BreakPassCount)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "BreakPassCount");
            oc_Newobject4["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "20 84";
            oc_Newobject4["extent"] = "160 18";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "True";
            oc_Newobject4["setFirstResponder"] = "False";
            oc_Newobject4["modal"] = "True";
            oc_Newobject4["helpTag"] = "0";
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["returnTab"] = "true";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "20 108";
            oc_Newobject5["extent"] = "27 18";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "True";
            oc_Newobject5["setFirstResponder"] = "False";
            oc_Newobject5["modal"] = "True";
            oc_Newobject5["helpTag"] = "0";
            oc_Newobject5["text"] = "Clear:";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiTextEditCtrl (BreakClear)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextEditCtrl", "BreakClear");
            oc_Newobject6["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "20 124";
            oc_Newobject6["extent"] = "160 18";
            oc_Newobject6["minExtent"] = "8 8";
            oc_Newobject6["visible"] = "True";
            oc_Newobject6["setFirstResponder"] = "False";
            oc_Newobject6["modal"] = "True";
            oc_Newobject6["helpTag"] = "0";
            oc_Newobject6["historySize"] = "0";
            oc_Newobject6["returnTab"] = "true";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject7["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "56 156";
            oc_Newobject7["extent"] = "40 16";
            oc_Newobject7["minExtent"] = "8 8";
            oc_Newobject7["visible"] = "True";
            oc_Newobject7["setFirstResponder"] = "False";
            oc_Newobject7["modal"] = "True";
            oc_Newobject7["command"] = "DbgBreakConditionSet();";
            oc_Newobject7["helpTag"] = "0";
            oc_Newobject7["text"] = "Set";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject8["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["position"] = "104 156";
            oc_Newobject8["extent"] = "40 16";
            oc_Newobject8["minExtent"] = "8 8";
            oc_Newobject8["visible"] = "True";
            oc_Newobject8["setFirstResponder"] = "False";
            oc_Newobject8["modal"] = "True";
            oc_Newobject8["command"] = "Canvas.popDialog(DebuggerBreakConditionDlg);";
            oc_Newobject8["helpTag"] = "0";
            oc_Newobject8["text"] = "Cancel";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DebuggerBreakConditionDlg ts, string simobjectid)
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
        public static bool operator !=(DebuggerBreakConditionDlg ts, string simobjectid)
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
        public static implicit operator string(DebuggerBreakConditionDlg ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DebuggerBreakConditionDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DebuggerBreakConditionDlg) Omni.self.getSimObject(simobjectid, typeof (DebuggerBreakConditionDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DebuggerBreakConditionDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DebuggerBreakConditionDlg(int simobjectid)
        {
            return (DebuggerBreakConditionDlg) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerBreakConditionDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DebuggerBreakConditionDlg ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DebuggerBreakConditionDlg(uint simobjectid)
        {
            return (DebuggerBreakConditionDlg) Omni.self.getSimObject(simobjectid, typeof (DebuggerBreakConditionDlg));
        }

        #endregion
    }
}