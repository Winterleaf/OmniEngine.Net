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
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<TimeAdjustGui>))]
    public class TimeAdjustGui : GuiSliderCtrl
    {
        [ConsoleInteraction(true, "TimeAdjustGui_initialize")]
        public static void initialize()
        {
            #region GuiControl (TimeAdjustGui, EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "TimeAdjustGui, EditorGuiGroup");
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiModelessDialogProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "1";

            #region GuiWindowCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject7["resizeWidth"] = "0";
            oc_Newobject7["resizeHeight"] = "0";
            oc_Newobject7["canMove"] = "1";
            oc_Newobject7["canClose"] = "1";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["minSize"] = "50 50";
            oc_Newobject7["EdgeSnap"] = "1";
            oc_Newobject7["text"] = "Time Adjust Gui";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "338 63";
            oc_Newobject7["Extent"] = "462 84";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["closeCommand"] = "Canvas.popDialog(TimeAdjustGui);";

            #region GuiSliderCtrl (TimeAdjustSliderCtrl)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiSliderCtrl", "TimeAdjustSliderCtrl", typeof (TimeAdjustGui));
            oc_Newobject1["range"] = "0 1";
            oc_Newobject1["ticks"] = "100";
            oc_Newobject1["value"] = "0.1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiSliderProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "37 27";
            oc_Newobject1["Extent"] = "389 19";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["altCommand"] = "$ThisControl.onAction();";

            #endregion

            oc_Newobject7["#Newobject1"] = oc_Newobject1;

            #region GuiTextCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject2["text"] = "Sunrise";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "11 53";
            oc_Newobject2["Extent"] = "59 19";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Sunset";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "206 53";
            oc_Newobject3["Extent"] = "59 19";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Noon";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "108 53";
            oc_Newobject4["Extent"] = "59 19";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Midnight";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "307 53";
            oc_Newobject5["Extent"] = "59 19";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "Sunrise";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "393 53";
            oc_Newobject6["Extent"] = "59 19";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
        }

        public override void onAction()
        {
            // NOTE: Though this is a GuiControl which exists on the client-side
            // we access and modify the server-side TimeOfDay object. This is acceptible
            // because this is a "tools" gui which is not intended for a real-game
            // or multiplayer situation.

            if (!this["tod"].isObject())
                {
                if ("MissionGroup".isObject())
                    {
                    SimSet MissionGroup = "MissionGroup";
                    for (uint i = 0; i < MissionGroup.getCount(); i++)
                        {
                        SimObject obj = MissionGroup.getObject(i);
                        if (obj.getClassName() == "TimeOfDay")
                            {
                            this["tod"] = obj;
                            break;
                            }
                        }
                    }
                }
            if (!this["tod"].isObject())
                return;

            TimeOfDay tod = this["tod"];
            tod.time = this.getValue();
        }

        [ConsoleInteraction]
        public static void toggleTimeAdjustGui()
        {
            TimeAdjustGui oTimeAdjustGui = "TimeAdjustGui";
            if (oTimeAdjustGui.isAwake())
                ((GuiCanvas) "canvas").popDialog(oTimeAdjustGui);
            else
                ((GuiCanvas) "canvas").popDialog(oTimeAdjustGui);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TimeAdjustGui ts, string simobjectid)
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
        public static bool operator !=(TimeAdjustGui ts, string simobjectid)
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
        public static implicit operator string(TimeAdjustGui ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TimeAdjustGui(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TimeAdjustGui) Omni.self.getSimObject(simobjectid, typeof (TimeAdjustGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TimeAdjustGui ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TimeAdjustGui(int simobjectid)
        {
            return (TimeAdjustGui) Omni.self.getSimObject((uint) simobjectid, typeof (TimeAdjustGui));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TimeAdjustGui ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TimeAdjustGui(uint simobjectid)
        {
            return (TimeAdjustGui) Omni.self.getSimObject(simobjectid, typeof (TimeAdjustGui));
        }

        #endregion
    }
}