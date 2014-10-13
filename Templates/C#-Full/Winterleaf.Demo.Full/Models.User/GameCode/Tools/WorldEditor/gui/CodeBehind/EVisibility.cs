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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<EVisibility>))]
    public class EVisibility : GuiWindowCtrl
    {
        private ArrayObject array
        {
            get { return this["array"]; }
        }

        private ArrayObject classArray
        {
            get { return this["classArray"]; }
        }

        public override void onWake()
        {
            if (!this["array"].isObject())
                this["array"] = new ObjectCreator("ArrayObject").Create().AsString();

            // Create the array if it
            // doesn't already exist.

            if (!this["classArray"].isObject())
                {
                this["classArray"] = new ObjectCreator("ArrayObject").Create().AsString();
                this.addClassOptions();
                }
            this.updateOptions();
        }

        [ConsoleInteraction]
        public void updateOptions()
        {
            GuiStackControl theVisOptionsList = this.findObjectByInternalName("theVisOptionsList", true);
            theVisOptionsList.clear();

            // Go through all the
            // parameters in our array and
            // create a check box for each.
            for (int i = 0; i < array.count(); i++)
                {
                string text = "  " + array.getValue(i);
                string val = array.getKey(i);
                string var = Util.getWord(val, 0);
                string toggleFunction = Util.getWord(val, 1);

                int textLength = text.Length;

                string cmd = "";

                if (toggleFunction != "")
                    cmd = toggleFunction + "( $thisControl.getValue() );";

                ObjectCreator oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "1";
                oc["Visible"] = "1";
                oc["Variable"] = var;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";
                oc["Command"] = cmd;

                GuiCheckBoxCtrl ctrl = oc.Create();

                theVisOptionsList.addGuiControl(ctrl);
                }
        }

        [ConsoleInteraction]
        public void addOption(string text, string varName, string toggleFunction)
        {
            // Create the array if it
            // doesn't already exist.
            if (!this["array"].isObject())
                this["array"] = new ObjectCreator("ArrayObject").Create().AsString();
            this.array.push_back(varName + " " + toggleFunction, text);
            this.array.uniqueKey();
            this.array.sortd();
            this.updateOptions();
        }

        [ConsoleInteraction]
        public void addClassOptions()
        {
            GuiStackControl visList = this.findObjectByInternalName("theClassVisList", true);
            GuiStackControl selList = this.findObjectByInternalName("theClassSelList", true);

            // First clear the stack control.
            visList.clear();
            selList.clear();

            string classList = Util._call("enumerateConsoleClasses", "SceneObject");
            int classCount = Util.getFieldCount(classList);

            for (int i = 0; i < classCount; i++)
                {
                string className = Util.getField(classList, i);
                classArray.push_back(className, "");
                }

            // Remove duplicates and sort by key.
            this.classArray.uniqueKey();
            this.classArray.sortkd();

            // Go through all the
            // parameters in our array and
            // create a check box for each.

            for (int i = 0; i < classArray.count(); i++)
                {
                string Class = classArray.getKey(i);

                string visVar = "$" + Class + "::isRenderable";
                string selVar = "$" + Class + "::isSelectable";

                int textLength = Class.Length;

                string text = "  " + Class;

                // Add visibility toggle.

                ObjectCreator oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListFlipedProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "1";
                oc["Visible"] = "1";
                oc["Variable"] = visVar;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["tooltip"] = "Show/hide all " + Class + " objects.";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";

                GuiCheckBoxCtrl ctrl = oc.Create();
                visList.addGuiControl(ctrl);
                // Add selectability toggle.
                oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListFlipedProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "1";
                oc["Visible"] = "1";
                oc["Variable"] = selVar;
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["tooltip"] = "Enable/disable selection of all " + Class + " objects.";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";
                ctrl = oc.Create();

                selList.addGuiControl(ctrl);
                }
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EVisibility ts, string simobjectid)
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
        public static bool operator !=(EVisibility ts, string simobjectid)
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
        public static implicit operator string(EVisibility ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EVisibility(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (EVisibility) Omni.self.getSimObject(simobjectid, typeof (EVisibility));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EVisibility ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EVisibility(int simobjectid)
        {
            return (EVisibility) Omni.self.getSimObject((uint) simobjectid, typeof (EVisibility));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EVisibility ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EVisibility(uint simobjectid)
        {
            return (EVisibility) Omni.self.getSimObject(simobjectid, typeof (EVisibility));
        }

        #endregion
    }
}