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

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui
{
    [TypeConverter(typeof (TypeConverterGeneric<EObjectSelection>))]
    public class EObjectSelection : GuiWindowCtrl
    {
        [ConsoleInteraction]
        public void init()
        {
            // Initialize the class list.

            string classList = findObjectByInternalName("classList", true);
            if (classList.isObject())
                initClassList();

            // Initialize the filter list.
            string filterList = findObjectByInternalName("filterList", true);
            if (filterList.isObject())
                initFilterList();

            string groupList = findObjectByInternalName("groupList", true);
            if (groupList.isObject())
                initGroupList();
        }

        [ConsoleInteraction]
        public void cleanup()
        {
            GuiStackControl classList = findObjectByInternalName("classList", true);
            if (classList.isObject())
                classList.clear();

            // Initialize the filter list.
            GuiStackControl filterList = findObjectByInternalName("filterList", true);
            if (filterList.isObject())
                filterList.clear();

            GuiPopUpMenuCtrl groupList = findObjectByInternalName("groupList", true);
            if (groupList.isObject())
                groupList.clear();

            if (this["classArray"].isObject())
                this["classArray"].delete();
        }

        //=============================================================================================
        //    Methods to override in a subclass.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        /// Return the group object where onSelectObjects should begin searching for objects.
        [ConsoleInteraction]
        public virtual SimGroup getRootGroup()
        {
            return "RootGroup";
        }

        /// Return a set that contains all filter objects to include in the filter list.
        /// Returning 0 will leave the filter list empty.
        [ConsoleInteraction]
        public virtual SimObject getFilterSet()
        {
            return "0";
        }

        //---------------------------------------------------------------------------------------------

        /// Return true if the given class should be included in the class list.
        [ConsoleInteraction]
        public virtual bool includeClass(string className)
        {
            return true;
        }

        //---------------------------------------------------------------------------------------------

        /// The object has met the given criteria.  Select or deselect it depending on %val.
        [ConsoleInteraction]
        public virtual void selectObject(SimObject obj, bool val)
        {
        }

        [ConsoleInteraction]
        public virtual void onSelectObjects(bool val, bool reuseExistingSet = false)
        {
            SimGroup root;
            // Get the root group to search in.
            GuiPopUpMenuCtrl groupList = findObjectByInternalName("groupList", true);
            if (groupList.isObject())
                root = getRootGroup();
            else
                root = groupList.getSelected();

            if (!root.isObject())
                return;
            // Fetch the object name pattern.
            string namePatternField = findObjectByInternalName("namePattern", true);
            if (namePatternField.isObject())
                this["namePattern"] = ((GuiTextEditCtrl) namePatternField).getText();
            else
                this["namePattern"] = "";

            // Clear current selection first, if need be.
            if (val)
                {
                string retainSelectionBox = findObjectByInternalName("retainSelection", true);
                if (retainSelectionBox.isObject() && !((GuiCheckBoxCtrl) retainSelectionBox).isStateOn())
                    clearSelection();
                }

            // (De)Select all matching objects in it.
            selectObjectsIn(root, val, true);
        }

        [ConsoleInteraction]
        public virtual void selectObjectsIn(string group, bool val, bool excludeGroup = false)
        {
            // Match to the group itself.
            if (!excludeGroup && objectMatchesCriteria(group))
                selectObject(group, val);

            // Recursively match all children.
            for (uint i = 0; i < ((SimGroup) group).getCount(); i++)
                {
                SimObject obj = ((SimGroup) group).getObject(i);
                if (obj.isMemberOfClass("SimSet"))
                    selectObjectsIn(obj, val);
                else if (objectMatchesCriteria(obj))
                    selectObject(obj, val);
                }
        }

        [ConsoleInteraction]
        public virtual bool objectMatchesCriteria(SimObject obj)
        {
            if (this["namePattern"] != "" && !Util.strIsMatchExpr(this["NamePattern"], obj.getName(), false))
                return false;
            // Check class.

            if (!isClassEnabled(obj.getClassName()))
                return false;

            return true;
        }

        [ConsoleInteraction]
        public virtual void initGroupList()
        {
            GuiPopUpMenuCtrl groupList = findObjectByInternalName("groupList", true);

            int selected = 0;

            if (groupList.size() > 0)
                selected = groupList.getSelected();

            groupList.clear();

            SimGroup root = getRootGroup();

            if (!root.isObject())
                return;
            // Add all non-empty groups.
            scanGroup(root, groupList, 0);

            // Select initial group.
            if (selected != 0 && selected.AsString().isObject())
                groupList.setSelected(selected);
            else
                groupList.setSelected(root.getId());
        }

        [ConsoleInteraction]
        public virtual void scanGroup(SimGroup group, GuiPopUpMenuCtrl list, int indentLevel)
        {
            // Create a display name for the group.
            string text = group.getName();
            if (text == "")
                text = group.getClassName();

            string internalName = group.getInternalName();

            if (internalName != "")
                text = text + "[" + internalName + "]";

            // Indent the name according to the depth in the hierarchy.

            if (indentLevel > 0)
                text = Util.strrepeat(" ", indentLevel, "") + text;

            // Add it to the list.

            list.add(text, group.getId());

            // Recurse into SimSets with at least one child.

            for (uint i = 0; i < group.getCount(); i++)
                {
                SimObject obj = group.getObject(i);
                if (!obj.isMemberOfClass("SimSet") || obj.call("getCount").AsInt() == 0)
                    continue;

                scanGroup(obj.GetID(), list, indentLevel + 1);
                }
        }

        [ConsoleInteraction]
        public virtual void initFilterList()
        {
            // %filterList = %this-->filterList;
        }

        [ConsoleInteraction]
        public virtual void initClassList()
        {
            ArrayObject classArray = new ObjectCreator("ArrayObject").Create();
            this["classArray"] = classArray;

            // Add all classes to the array.

            string classes = Util._call("enumerateConsoleClasses");
            foreach (string className in classes.Split('\t'))
                {
                if (!includeClass(className))
                    continue;

                classArray.push_back(className, "true");
                }
            // Sort the class list.
            classArray.sortk(true);

            // Add checkboxes for all classes to the list.

            GuiStackControl classList = findObjectByInternalName("classList", true);
            int count = classArray.count();
            for (int i = 0; i < count; i++)
                {
                string className = classArray.getKey(i);
                int textLength = className.Length;
                string text = " " + className;

                ObjectCreator oc = new ObjectCreator("GuiCheckBoxCtrl");
                oc["canSaveDynamicFields"] = "0";
                oc["isContainer"] = "0";
                oc["Profile"] = "ToolsGuiCheckBoxListFlipedProfile";
                oc["HorizSizing"] = "right";
                oc["VertSizing"] = "bottom";
                oc["Position"] = "0 0";
                oc["Extent"] = (textLength*4) + " 18";
                oc["MinExtent"] = "8 2";
                oc["canSave"] = "0";
                oc["Visible"] = "1";
                oc["tooltipprofile"] = "ToolsGuiToolTipProfile";
                oc["hovertime"] = "1000";
                oc["tooltip"] = "Include/exclude all " + className + " objects.";
                oc["text"] = text;
                oc["groupNum"] = "-1";
                oc["buttonType"] = "ToggleButton";
                oc["useMouseEvents"] = "0";
                oc["useInactiveState"] = "0";
                oc["command"] = classArray + ".setValue( $ThisControl.getValue(), " + i + " );";

                GuiCheckBoxCtrl checkBox = oc.Create();
                checkBox.setStateOn(true);
                classList.addGuiControl(checkBox);
                }
        }

        [ConsoleInteraction]
        public virtual void selectAllInClassList(string state)
        {
            GuiStackControl classList = findObjectByInternalName("classList", true);

            for (uint i = 0; i < classList.getCount(); i++)
                {
                SimObject ctrl = classList.getObject(i);
                if (ctrl.call("getValue") == state)
                    ctrl.call("performClick");
                }
        }

        [ConsoleInteraction]
        public virtual bool isClassEnabled(string className)
        {
            int index = this["classArray"].call("getIndexFromKey", new string[] {className}).AsInt();
            if (index == -1)
                return false;
            return this["classArray"].call("getValue", new string[] {index.AsString()}).AsBool();
        }

        [ConsoleInteraction]
        public virtual void clearSelection()
        {
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EObjectSelection ts, string simobjectid)
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
        public static bool operator !=(EObjectSelection ts, string simobjectid)
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
        public static implicit operator string(EObjectSelection ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EObjectSelection(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (EObjectSelection) Omni.self.getSimObject(simobjectid, typeof (EObjectSelection));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EObjectSelection ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EObjectSelection(int simobjectid)
        {
            return (EObjectSelection) Omni.self.getSimObject((uint) simobjectid, typeof (EObjectSelection));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EObjectSelection ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EObjectSelection(uint simobjectid)
        {
            return (EObjectSelection) Omni.self.getSimObject(simobjectid, typeof (EObjectSelection));
        }

        #endregion
    }
}