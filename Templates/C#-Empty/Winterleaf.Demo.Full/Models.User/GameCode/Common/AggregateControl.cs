using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
            omni.Util._schedule(delayMS.AsString(), "0", "ShareValueSafe", source, dest);
            }

        [ConsoleInteraction]
        public static bool parseMissionGroup(string className, string childGroup = "")
            {
            SimGroup currentGroup = "";
            if (omni.Util.getWordCount(childGroup) == 0)
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
                if (omni.Util.strpos(numbers, firstChar, 0) != -1)
                    {
                    name = omni.Util.getSubStr(name, 1, name.Length - 1);
                    name = name.Trim();
                    }
                else
                    {
                    break;
                    }
                }
            // replace whitespaces with underscores
            name = name.Replace(" ", "");
            // remove any other invalid characters
            string invalidCharacters = "-+*/%$&§=()[].?\"#,;!~<>|°^{}";
            name = omni.Util.stripChars(name, invalidCharacters);
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
            if (omni.Util.strpos(text, word, 0) == -1)
                return -1;

            int count = omni.Util.getWordCount(text);
            for (int i = start; i < count; i++)
                {
                if (omni.Util.getWord(text, i) == word)
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
            if (omni.Util.strpos(text, field, 0) == -1)
                return -1;

            int count = omni.Util.getFieldCount(text);
            if (start > count)
                return -1;
            for (int i = start; i < count; i++)
                {
                if (omni.Util.getField(text, i) == field)
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
            if (omni.Util.getWordCount(childGroup) == 0)
                currentGroup = "MissionGroup";
            else
                currentGroup = childGroup;

            for (uint i = 0; i < currentGroup.getCount(); i++)
                {
                if (((SimObject) currentGroup.getObject(i)).getClassName() == className)
                    classIds += ((SimObject) currentGroup.getObject(i)).GetID() + " ";

                if (((SimObject) currentGroup.getObject(i)).getClassName() == "SimGroup")
                    classIds += parseMissionGroupForIds(className,
                        ((SimObject) currentGroup.getObject(i)).getId().AsString());
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
                    {
                    return obj.getValue();
                    }
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
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
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