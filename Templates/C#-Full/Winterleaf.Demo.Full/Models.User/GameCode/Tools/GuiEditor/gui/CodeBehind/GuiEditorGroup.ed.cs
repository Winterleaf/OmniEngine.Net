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
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorGroup>))]
    public class GuiEditorGroup : ScriptObject
    {
        internal GuiControl groupObject
        {
            get { return this["groupObject"]; }
            set { this["groupObject"] = value; }
        }

        internal GuiControl groupParent
        {
            get { return this["groupParent"]; }
            set { this["groupParent"] = value; }
        }

        internal int count
        {
            get { return this["count"].AsInt(); }
            set { this["count"] = value.AsString(); }
        }

        [ConsoleInteraction]
        public string getGlobalBounds()
        {
            int minX = 2147483647;
            int minY = 2147483647;
            int maxX = -2147483647;
            int maxY = -2147483647;

            for (int i = 0; i < this.count; i ++)
                {
                GuiControl ctrl = this["ctrl[" + i + "]"];

                string pos = ctrl.getGlobalPosition().AsString();
                string extent = ctrl.getExtent().AsString();

                // Min.      

                int posX = Util.getWord(pos, 0).AsInt();
                int posY = Util.getWord(pos, 1).AsInt();

                if (posX < minX)
                    minX = posX;
                if (posY < minY)
                    minY = posY;

                // Max.

                posX += Util.getWord(extent, 0).AsInt();
                posY += Util.getWord(extent, 1).AsInt();

                if (posX > maxX)
                    maxX = posX;
                if (posY > maxY)
                    maxY = posY;
                }

            return (minX + ' ' + minY + ' ' + (maxX - minX) + ' ' + (maxY - minY)).AsString();
        }

        [ConsoleInteraction]
        /// Create a new GuiControl and move all the controls contained in the GuiEditorGroup into it.
        public void group()
        {
            GuiControl parent = this.groupParent;

            // Create group.

            GuiControl group = new ObjectCreator("GuiControl").Create();
            parent.addGuiControl(group);
            this.groupObject = group;

            // Make group fit around selection.

            string bounds = this.getGlobalBounds();
            string parentGlobalPos = parent.getGlobalPosition().AsString();

            int x = Util.getWord(bounds, 0).AsInt() - Util.getWord(parentGlobalPos, 0).AsInt();
            int y = Util.getWord(bounds, 1).AsInt() - Util.getWord(parentGlobalPos, 1).AsInt();

            group.setPosition(x, y);
            group.setExtent(new Point2F(Util.getWord(bounds, 2).AsFloat(), Util.getWord(bounds, 3).AsFloat()));

            // Reparent all objects to group.

            for (int i = 0; i < this.count; i ++)
                {
                GuiControl ctrl = this["ctrl[" + i + "]"];

                // Save parent for undo.

                this["ctrlParent[" + i + "]"] = ctrl.parentGroup;

                // Reparent.

                group.addGuiControl(ctrl);

                // Move into place in new parent.

                string pos = ctrl.getPosition().AsString();
                ctrl.setPosition(Util.getWord(pos, 0).AsInt() - x, Util.getWord(pos, 1).AsInt() - y);
                }
        }

        [ConsoleInteraction]
        /// Move all controls out of group to either former parent or group parent.
        public void ungroup()
        {
            GuiControl defaultParent = this.groupParent;
            string groupPos = this.groupObject.getPosition().AsString();

            int x = Util.getWord(groupPos, 0).AsInt();
            int y = Util.getWord(groupPos, 1).AsInt();

            // Move each control to its former parent (or default parent when
            // there is no former parent).

            for (int i = 0; i < this.count; i ++)
                {
                GuiControl ctrl = this["ctrl[" + i + "]"];

                GuiControl parent = defaultParent;
                if (this["ctrlParent[" + i + "]"].isObject())
                    parent = this["ctrlParent[" + i + "]"];

                parent.addGuiControl(ctrl);

                // Move into place in new parent.

                string ctrlPos = ctrl.getPosition().AsString();
                ctrl.setPosition(Util.getWord(ctrlPos, 0).AsInt() + x, Util.getWord(ctrlPos, 1).AsInt() + y);
                }

            // Delete old group object.

            this.groupObject.delete();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorGroup ts, string simobjectid)
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
        public static bool operator !=(GuiEditorGroup ts, string simobjectid)
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
        public static implicit operator string(GuiEditorGroup ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorGroup(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorGroup) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGroup));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorGroup ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorGroup(int simobjectid)
        {
            return (GuiEditorGroup) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorGroup));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorGroup ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorGroup(uint simobjectid)
        {
            return (GuiEditorGroup) Omni.self.getSimObject(simobjectid, typeof (GuiEditorGroup));
        }

        #endregion
    }
}