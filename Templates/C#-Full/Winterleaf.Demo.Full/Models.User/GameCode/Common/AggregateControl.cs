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

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Common
{
    [TypeConverter(typeof (TypeConverterGeneric<AggregateControl>))]
    public class AggregateControl : GuiControl
    {

        [ConsoleInteraction]
        public static void setValueSafe(GuiControl dest, string value)
        {
            string cmd = dest["command"];
            string alt = dest["altCommand"];
            dest["command"] = "";
            dest["altCommand"] = "";
            dest.setValue(value);
            dest["command"] = cmd;
            dest["altCommand"] = alt;
        }

        [ConsoleInteraction]
        public static void shareValueSafe(GuiControl source, GuiControl dest)
        {
            setValueSafe(dest, source.getValue());
        }

        [ConsoleInteraction]
        public static void shareValueSafeDelay(GuiControl source, GuiControl dest, int delayMS)
        {
            Util._schedule(delayMS.AsString(), "0", "ShareValueSafe", source, dest);
        }

        [ConsoleInteraction]
        public static bool parseMissionGroup(string className, string childGroup = "")
        {
            SimGroup currentGroup = "";
            if (Util.getWordCount(childGroup) == 0)
                currentGroup = "MissionGroup";
            else
                currentGroup = childGroup;

            for (uint i = 0; i < currentGroup.getCount(); i++)
                {
                if (((SimObject) currentGroup.getObject(i)).getClassName() == className)
                    return true;

                if (((SimObject) currentGroup.getObject(i)).getClassName() == "SimGroup")
                    {
                    if (parseMissionGroup(className, currentGroup.getObject(i).getID().AsString()))
                        return true;
                    }
                }
            return false;
        }

        [ConsoleInteraction]
        public static string validateDatablockName(string name)
        {
            // remove whitespaces at beginning and end
            name = name.Trim();

            // remove numbers at the beginning
            string numbers = "0123456789";
            while (name.Length > 0)
                {
                // the first character
                string firstChar = name.Substring(0, 1);
                // if the character is a number remove it
                if (Util.strpos(numbers, firstChar, 0) != -1)
                    {
                    name = Util.getSubStr(name, 1, name.Length - 1);
                    name = name.Trim();
                    }
                else
                    break;
                }
            // replace whitespaces with underscores
            name = name.Replace(" ", "");
            // remove any other invalid characters
            string invalidCharacters = "-+*/%$&§=()[].?\"#,;!~<>|°^{}";
            name = Util.stripChars(name, invalidCharacters);
            if (name == "")
                name = "Unnamed";
            return name;
        }

        //--------------------------------------------------------------------------
        // Finds location of %word in %text, starting at %start.  Works just like strPos
        //--------------------------------------------------------------------------
        [ConsoleInteraction]
        public static int wordPos(string text, string word, int start = 0)
        {
            if (Util.strpos(text, word, 0) == -1)
                return -1;

            int count = Util.getWordCount(text);
            for (int i = start; i < count; i++)
                {
                if (Util.getWord(text, i) == word)
                    return i;
                }
            return -1;
        }

        //--------------------------------------------------------------------------
        // Finds location of %field in %text, starting at %start.  Works just like strPos
        //--------------------------------------------------------------------------
        [ConsoleInteraction]
        public static int fieldPos(string text, string field, int start = 0)
        {
            if (Util.strpos(text, field, 0) == -1)
                return -1;

            int count = Util.getFieldCount(text);
            if (start > count)
                return -1;
            for (int i = start; i < count; i++)
                {
                if (Util.getField(text, i) == field)
                    return i;
                }
            return -1;
        }

        //--------------------------------------------------------------------------
        // returns the text in a file with "\n" at the end of each line
        //--------------------------------------------------------------------------

        [ConsoleInteraction]
        public static string loadFileText(string file)
        {
            FileObject fo = new ObjectCreator("FileObject").Create();
            fo.openForRead(file);
            string text = "";
            while (!fo.isEOF())
                {
                text = text + fo.readLine();
                if (!fo.isEOF())
                    text = text + "\n";
                }
            fo.delete();
            return text;
        }

        [ConsoleInteraction]
        public static string parseMissionGroupForIds(string className, string childGroup)
        {
            string classIds = "";
            SimGroup currentGroup;
            if (Util.getWordCount(childGroup) == 0)
                currentGroup = "MissionGroup";
            else
                currentGroup = childGroup;

            for (uint i = 0; i < currentGroup.getCount(); i++)
                {
                if (((SimObject) currentGroup.getObject(i)).getClassName() == className)
                    classIds += ((SimObject) currentGroup.getObject(i)).GetID() + " ";

                if (((SimObject) currentGroup.getObject(i)).getClassName() == "SimGroup")
                    classIds += parseMissionGroupForIds(className, ((SimObject) currentGroup.getObject(i)).getId().AsString());
                }
            return classIds;
        }

        //------------------------------------------------------------------------------
        // An Aggregate Control is a plain GuiControl that contains other controls, 
        // which all share a single job or represent a single value.
        //------------------------------------------------------------------------------

        // AggregateControl.setValue( ) propagates the value to any control that has an 
        // internal name.

        [ConsoleInteraction]
        public virtual void setValue(string val, SimObject child)
        {
            for (uint i = 0; i < this.getCount(); i++)
                {
                GuiControl obj = this.getObject(i);
                if (obj == child)
                    continue;

                if (obj.internalName != "")
                    setValueSafe(obj, val);
                }
        }

        // AggregateControl.getValue() uses the value of the first control that has an
        // internal name, if it has not cached a value via .setValue

        [ConsoleInteraction]
        public virtual string getValue()
        {
            for (uint i = 0; i < getCount(); i++)
                {
                GuiControl obj = this.getObject(i);
                if (obj.internalName != "")
                    return obj.getValue();
                }
            return "";
        }

        // AggregateControl.updateFromChild( ) is called by child controls to propagate
        // a new value, and to trigger the onAction() callback.
        [ConsoleInteraction]
        public void updateFromChild(GuiControl child)
        {
            string val = child.call("getValue");
            if (val.AsFloat() == Math.Ceiling(val.AsFloat()))
                val = Math.Ceiling(val.AsFloat()).AsString();
            else
                {
                if (val.AsFloat() <= -100)
                    val = Math.Ceiling(val.AsFloat()).AsString();
                else if (val.AsFloat() <= -10)
                    val = Util.mFloatLength(val.AsFloat(), 1);
                else if (val.AsFloat() < 0)
                    val = Util.mFloatLength(val.AsFloat(), 2);
                else if (val.AsFloat() >= 1000)
                    val = Math.Ceiling(val.AsFloat()).AsString();
                else if (val.AsFloat() >= 100)
                    val = Util.mFloatLength(val.AsFloat(), 1);
                else if (val.AsFloat() >= 10)
                    val = Util.mFloatLength(val.AsFloat(), 2);
                else if (val.AsFloat() >= 0)
                    val = Util.mFloatLength(val.AsFloat(), 3);
                }

            this.setValue(val, child);
            onAction();
        }

        // default onAction stub, here only to prevent console spam warnings.
        [ConsoleInteraction]
        public override void onAction()
        {
        }

        // call a method on all children that have an internalName and that implement the method.
        public void callMethod(string method, string args)
        {
            for (uint i = 0; i < getCount(); i++)
                {
                GuiControl obj = getObject(i);
                if (obj.internalName != "" && obj.isMethod(method))
                    Util.eval(obj + "." + method + "(" + args + ");");
                }
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AggregateControl ts, string simobjectid)
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
        public static bool operator !=(AggregateControl ts, string simobjectid)
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
        public static implicit operator string(AggregateControl ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator AggregateControl(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (AggregateControl) Omni.self.getSimObject(simobjectid, typeof (AggregateControl));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AggregateControl ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AggregateControl(int simobjectid)
        {
            return (AggregateControl) Omni.self.getSimObject((uint) simobjectid, typeof (AggregateControl));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AggregateControl ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AggregateControl(uint simobjectid)
        {
            return (AggregateControl) Omni.self.getSimObject(simobjectid, typeof (AggregateControl));
        }

        #endregion
    }
}