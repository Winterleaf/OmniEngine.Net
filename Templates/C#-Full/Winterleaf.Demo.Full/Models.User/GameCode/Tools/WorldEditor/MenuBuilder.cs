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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
{
    [TypeConverter(typeof (TypeConverterGeneric<MenuBuilder>))]
    public class MenuBuilder : PopupMenu
    {
        [ConsoleInteraction]
        public virtual void addItem(string pos, string item = "")
        {
            if (item == "")
                item = this["item[" + pos + "]"];

            if (item != this["item[" + pos + "]"])
                this["item[" + pos + "]"] = item;

            string name = Util.getField(item, 0);
            string accel = Util.getField(item, 1);
            string cmd = Util.getField(item, 2);

            // We replace the [this] token with our object ID
            cmd = Util.strreplace(cmd, "[this]", this);
            this["item[" + pos + "]"] = Util.setField(item, 2, cmd);

//            console.print("Command is '" + cmd + "'.");

            if (accel.isObject())
                {
                // If %accel is an object, we want to add a sub menu
                this.insertSubMenu(pos.AsInt(), name, accel);
                }
            else
                this.insertItem(pos.AsInt(), name != "-" ? name : "", accel);
        }

        [ConsoleInteraction]
        public virtual int appendItem(string item)
        {
            addItem(getItemCount().AsString(), item);
            return this.getItemCount() - 1;
        }

        [ConsoleInteraction]
        public virtual void removeAllItems()
        {
            int itemCount = getItemCount();
            for (int i = 0; i < itemCount; i++)
                removeItem(i);
        }

        public override void onAdd()
        {
            if (!this["canvas"].isObject())
                this["canvas"] = "canvas";

            int i = 0;
            string item = this["item[" + i + "]"];
            while (item != "")
                {
                addItem(i.AsString());
                i++;
                item = this["item[" + i + "]"];
                }
        }

        public override void onRemove()
        {
            removeFromMenuBar();
        }

        [ConsoleInteraction]
        public virtual bool onSelectItem(string id, string text)
        {
            string cmd = Util.getField(this["item[" + id + "]"], 2);
            ((GuiCanvas) this["canvas"]).setPopupShown(false);
            if (cmd != "")
                {
                console.Eval(cmd);
                return true;
                }
            return false;
        }

        /// Sets a new name on an existing menu item.
        [ConsoleInteraction]
        public virtual void setItemName(int id, string name)
        {
            string item = this["item[" + id + "]"];
            string accel = Util.getField(item, 1);
            this.setItem(id, name, accel);
        }

        /// Sets a new command on an existing menu item.
        [ConsoleInteraction]
        public virtual void setItemCommand(string id, string command)
        {
            this["item[" + id + "]"] = Util.setField(this["item[" + id + "]"], 2, command);
        }

        /// (SimID this)
        /// Wraps the attachToMenuBar call so that it does not require knowledge of
        /// barName or barIndex to be removed/attached.  This makes the individual 
        /// MenuBuilder items very easy to add and remove dynamically from a bar.
        ///
        [ConsoleInteraction]
        public virtual bool attachToMenuBar()
        {
            if (this["barName"] == "")
                {
                Util._error("MenuBuilder::attachToMenuBar - Menu property 'barName' not specified.");
                return false;
                }
            if (this["BarPosition"].AsInt() < 0)
                {
                Util._error("MenuBuilder::attachToMenuBar - Menu " + this["barName"] + "property 'barPosition' is invalid, must be zero or greater.");
                return false;
                }

            base.attachToMenuBar(this["canvas"], this["barPosition"].AsInt(), this["barName"]);
            return true;
        }

        //////////////////////////////////////////////////////////////////////////

        // Callbacks from PopupMenu. These callbacks are now passed on to submenus
        // in C++, which was previously not the case. Thus, no longer anything to
        // do in these. I am keeping the callbacks in case they are needed later.

        [ConsoleInteraction]
        public override void onAttachToMenuBar(string canvas, string pos, string title)
        {
        }

        [ConsoleInteraction]
        public override void onRemoveFromMenuBar(string canvas)
        {
        }

        //////////////////////////////////////////////////////////////////////////

        /// Method called to setup default state for the menu. Expected to be overriden
        /// on an individual menu basis. See the mission editor for an example.
        /// 
        [ConsoleInteraction]
        public virtual void setupDefaultState()
        {
            int i = 0;
            string item = this["item[" + i + "]"];
            while (item != "")
                {
                string name = Util.getField(item, 0);
                string accel = Util.getField(item, 1);
                string cmd = Util.getField(item, 2);

                // Pass on to sub menus
                if (accel.isObject())
                    accel.call("setupDefaultState");

                i++;
                item = this["item[" + i + "]"];
                }
        }

        /// Method called to easily enable or disable all items in a menu.
        [ConsoleInteraction]
        public virtual void enableAllItems(bool enable)
        {
            int i = 0;
            string item = this["item[" + i + "]"];
            while (item != "")
                {
                enableItem(i, enable);

                i++;
                item = this["item[" + i + "]"];
                }
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MenuBuilder ts, string simobjectid)
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
        public static bool operator !=(MenuBuilder ts, string simobjectid)
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
        public static implicit operator string(MenuBuilder ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MenuBuilder(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (MenuBuilder) Omni.self.getSimObject(simobjectid, typeof (MenuBuilder));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MenuBuilder ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MenuBuilder(int simobjectid)
        {
            return (MenuBuilder) Omni.self.getSimObject((uint) simobjectid, typeof (MenuBuilder));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MenuBuilder ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MenuBuilder(uint simobjectid)
        {
            return (MenuBuilder) Omni.self.getSimObject(simobjectid, typeof (MenuBuilder));
        }

        #endregion
    }
}