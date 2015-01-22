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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
{
    [TypeConverter(typeof (TypeConverterGeneric<OptRemapInputCtrl>))]
    public class OptRemapInputCtrl : GuiInputCtrl
    {

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onInputEvent(string device, string action, bool state)
        {
            //error( "** onInputEvent called - device = " @ %device @ ", action = " @ %action @ " **" );
            ((GuiCanvas) "Canvas").popDialog("RemapDlg");

            // Test for the reserved keystrokes:
            if (device == "keyboard")
                {
                //Cancel
                if (action == "escape")
                    {
                    //do Nothing
                    return;
                    }
                }

            string cmd = sGlobal["$RemapCmd[" + this["index"] + "]"];
            cmd = sGlobal["$RemapName[" + this["index"] + "]"];

            // Grab the friendly display name for this action
            // which we'll use when prompting the user below.

            string mapName = OptionsDlg.getMapDisplayName(device, action);

            string prevMap = ((ActionMap) "MoveMap").getCommand(device, action);

            // If nothing was mapped to the previous command 

            // mapping then it's easy... just bind it.
            OptionsDlg optionsDlg = "optionsDlg";

            if (prevMap == "")
                {
                unbindExtraActions(cmd, 1);
                ((ActionMap) "moveMap").bind(device, action, cmd);
                ((GuiTextListCtrl) optionsDlg.findObjectByInternalName("OptRemapList", true)).setRowById(this["index"].AsInt(), OptionsDlg.buildFullMapString(this["index"].AsInt()));
                return;
                }

            // If the previous command is the same as the 
            // current then they hit the same input as what
            // was already assigned.

            if (prevMap == cmd)
                {
                unbindExtraActions(cmd, 0);
                ((ActionMap) "moveMap").bind(cmd, action, cmd);
                ((GuiTextListCtrl) optionsDlg.findObjectByInternalName("OptRemapList", true)).setRowById(this["index"].AsInt(), OptionsDlg.buildFullMapString(this["index"].AsInt()));
                return;
                }
            // Look for the index of the previous mapping.
            int prevMapIndex = findRemapCmdIndex(prevMap);

            // If we get a negative index then the previous 
            // mapping was to an item that isn't included in
            // the mapping list... so we cannot unmap it.

            if (prevMapIndex == -1)
                {
                messageBox.MessageBoxOK("Remap Failed", "\"" + mapName + "\" is already bound to a non-remappable command!", "");
                return;
                }

            // Setup the forced remapping callback command.
            string callback = "redoMapping(" + device + ",\"" + action + "\",\"" + cmd + "\", " + prevMapIndex + ", " + this["index"] + ");";
            // Warn that we're about to remove the old mapping and
            // replace it with another.
            string prevCmdName = sGlobal["$RemapName[" + prevMapIndex + "];"];

            messageBox.MessageBoxYesNo("Warning", "\"" + mapName + "\" is already bound to \"" + prevCmdName + "\"!\nDo you wish to replace this mapping?", callback, "");
        }

        [ConsoleInteraction(true)]
        public static int findRemapCmdIndex(string command)
        {
            for (int i = 0; i < iGlobal["$RemapCount"]; i++)
                {
                if (command == sGlobal["$RemapCmd[" + i + "]"])
                    return i;
                }
            return -1;
        }

        [ConsoleInteraction(true)]
        // This unbinds actions beyond %count associated to the
        // particular moveMap %commmand.
        public static void unbindExtraActions(string command, int count)
        {
            string temp = ((ActionMap) "moveMap").getBinding(command);
            if (temp == "")
                return;

            count = Util.getFieldCount(temp) - (count*2);
            for (int i = 0; i < count; i += 2)
                {
                string device = Util.getField(temp, i + 0);
                string action = Util.getField(temp, i + 1);
                ((ActionMap) "moveMap").unbind(device, action);
                }
        }

        [ConsoleInteraction(true)]
        public static void redoMapping(string device, string action, string cmd, int oldIndex, int newIndex)
        {
            ((ActionMap) "moveMap").bind(device, action, cmd);

            GuiTextListCtrl remapList = ((OptRemapInputCtrl) "OptRemapInputCtrl").findObjectByInternalName("OptRemapList", true);
            remapList.setRowById(oldIndex, OptionsDlg.buildFullMapString(oldIndex));
            remapList.setRowById(newIndex, OptionsDlg.buildFullMapString(newIndex));
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OptRemapInputCtrl ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
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
        public static bool operator !=(OptRemapInputCtrl ts, string simobjectid)
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
        public static implicit operator string(OptRemapInputCtrl ts)
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
        public static implicit operator OptRemapInputCtrl(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (OptRemapInputCtrl) Omni.self.getSimObject(simobjectid, typeof (OptRemapInputCtrl));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(OptRemapInputCtrl ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator OptRemapInputCtrl(int simobjectid)
        {
            return (OptRemapInputCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (OptRemapInputCtrl));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(OptRemapInputCtrl ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator OptRemapInputCtrl(uint simobjectid)
        {
            return (OptRemapInputCtrl) Omni.self.getSimObject(simobjectid, typeof (OptRemapInputCtrl));
        }

        #endregion
    }
}