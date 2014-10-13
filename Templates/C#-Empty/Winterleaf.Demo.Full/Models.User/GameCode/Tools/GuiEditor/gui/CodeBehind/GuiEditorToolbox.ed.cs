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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<GuiEditorToolbox>))]
    public class GuiEditorToolbox : GuiStackControl
    {

        public string currentViewType
        {
            get { return this["currentViewType"]; }
            set { this["currentViewType"] = value; }
        }

        public bool isInitialized
        {
            get { return this["isInitialized"].AsBool(); }
            set { this["isInitialized"] = value.AsString(); }
        }

        // Code for the toolbox tab of the Gui Editor sidebar.
        [ConsoleInteraction]
        public void initialize()
        {
            // Set up contents.

            string viewType = this.currentViewType;
            if (viewType == "")
                viewType = "Categorized";

            this.currentViewType = "";
            this.setViewType(viewType);

            this.isInitialized = true;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public string getViewType()
        {
            return this.currentViewType;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void setViewType(string viewType)
        {
            if (this.currentViewType == viewType || !this.isMethod("setViewType" + viewType))
                return;

            this.clear();
            Util.eval(this + ".setViewType" + viewType + "();");
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void setViewTypeAlphabetical()
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";
            string controls = Util.enumerateConsoleClassesByCategory("Gui");
            ArrayObject classes = new ObjectCreator("ArrayObject").Create();

            // Collect relevant classes.

            foreach (string className in controls.Split('\t'))
                {
                if (GuiEditor.isFilteredClass(className) || !(Util.isMemberOfClass(className, "GuiControl")))
                    continue;

                classes.push_back(className, "");
                }

            // Sort classes alphabetically.

            classes.sortk(true);

            // Add toolbox buttons.

            int numClasses = classes.count();
            for (int i = 0; i < numClasses; i ++)
                {
                string className = classes.getKey(i);

                #region GuiIconButtonCtrl ()        oc_Newobject2

                ObjectCreator oc_Newobject2 = new ObjectCreator("GuiIconButtonCtrl", "", typeof (GuiEditorToolboxButton));
                oc_Newobject2["profile"] = "ToolsGuiIconButtonSmallProfile";
                oc_Newobject2["extent"] = "128 18";
                oc_Newobject2["text"] = className;
                oc_Newobject2["iconBitmap"] = console.Call_Classname("EditorIconRegistry", "findIconByClassName", new string[] {className});
                oc_Newobject2["buttonMargin"] = "2 2";
                oc_Newobject2["iconLocation"] = "left";
                oc_Newobject2["textLocation"] = "left";
                oc_Newobject2["textMargin"] = "24";
                oc_Newobject2["AutoSize"] = new Creator.StringNoQuote("true");
                oc_Newobject2["command"] = "GuiEditor.createControl( " + className + " );";
                oc_Newobject2["useMouseEvents"] = new Creator.StringNoQuote("true");
                oc_Newobject2["tooltip"] = className + '\n' + "\n" + Util.getDescriptionOfClass(className);
                oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";

                #endregion

                GuiIconButtonCtrl ctrl = oc_Newobject2.Create();

                this.add(ctrl);
                }

            classes.delete();
            this.currentViewType = "Alphabetical";
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void setViewTypeCategorized()
        {
            GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

            // Create rollouts for each class category we have and
            // record the classes in each category in a temporary array
            // on the rollout so we can later sort the class names before
            // creating the actual controls in the toolbox.

            string controls = Util.enumerateConsoleClassesByCategory("Gui");
            foreach (string className in controls.Split('\t'))
                {
                if (GuiEditor.isFilteredClass(className) || !Util.isMemberOfClass(className, "GuiControl"))
                    continue;

                // Get the class's next category under Gui.

                string category = Util.getWord(Util.getCategoryOfClass(className), 1);
                if (category == "")
                    continue;

                // Find or create the rollout for the category.

                GuiRolloutCtrl rollout = this.getOrCreateRolloutForCategory(category);

                // Insert the item.

                if (!rollout["classes"].AsBool())
                    rollout["classes"] = new ObjectCreator("ArrayObject").Create().AsString();

                ((ArrayObject) rollout["classes"]).push_back(className, "");
                }

            // Go through the rollouts, sort the class names, and
            // create the toolbox controls.

            for (uint i = 0; i < this.getCount(); i++)
                {
                GuiRolloutCtrl rollout = this.getObject(i);
                if (!rollout.isMemberOfClass("GuiRolloutCtrl"))
                    continue;

                // Get the array with the class names and sort it.
                // Sort in descending order to counter reversal of order
                // when we later add the controls to the stack.

                ArrayObject classes = rollout["classes"];
                classes.sortk(true);

                // Add a control for each of the classes to the
                // rollout's stack control.

                GuiDynamicCtrlArrayControl stack = rollout.FOT("array");
                int numClasses = classes.count();
                for (int n = 0; n < numClasses; n ++)
                    {
                    string className = classes.getKey(n);

                    #region GuiIconButtonCtrl ()        oc_Newobject3

                    ObjectCreator oc_Newobject3 = new ObjectCreator("GuiIconButtonCtrl", "", typeof (GuiEditorToolboxButton));
                    oc_Newobject3["profile"] = "ToolsGuiIconButtonSmallProfile";
                    oc_Newobject3["extent"] = "128 18";
                    oc_Newobject3["text"] = className;
                    oc_Newobject3["iconBitmap"] = console.Call_Classname("EditorIconRegistry", "findIconByClassName", new string[] {className});
                    oc_Newobject3["buttonMargin"] = "2 2";
                    oc_Newobject3["iconLocation"] = "left";
                    oc_Newobject3["textLocation"] = "left";
                    oc_Newobject3["textMargin"] = "24";
                    oc_Newobject3["AutoSize"] = new Creator.StringNoQuote("true");
                    oc_Newobject3["command"] = "GuiEditor.createControl( " + className + " );";
                    oc_Newobject3["useMouseEvents"] = new Creator.StringNoQuote("true");

                    //TODO doesn't work for every control.
                    //oc_Newobject3["tooltip"] = className + '\n' + "\n" + Util.getDescriptionOfClass( className ); 
                    oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";

                    #endregion

                    GuiIconButtonCtrl ctrl = oc_Newobject3.Create();

                    stack.add(ctrl);
                    }

                // Delete the temporary array.

                rollout["classes"] = "";
                classes.delete();
                }

            this.currentViewType = "Categorized";
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public string getOrCreateRolloutForCategory(string category)
        {
            // Try to find an existing rollout.

            GuiRolloutCtrl ctrl = this.getRolloutForCategory(category);
            if (ctrl != "0")
                return ctrl;

            // None there.  Create a new one.

            #region GuiRolloutCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiRolloutCtrl", "", typeof (GuiEditorToolboxRolloutCtrl));
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["DefaultHeight"] = "40";
            oc_Newobject6["Expanded"] = "1";
            oc_Newobject6["ClickCollapse"] = "1";
            oc_Newobject6["HideHeader"] = "0";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "GuiRolloutProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "0 0";
            oc_Newobject6["Extent"] = "421 114";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["autoCollapseSiblings"] = new Creator.StringNoQuote("true");
            oc_Newobject6["caption"] = category;

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "421 64";
            oc_Newobject5["MinExtent"] = "64 64";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["padding"] = "6 2 4 0";
            oc_Newobject5["colSpacing"] = "1";
            oc_Newobject5["rowSpacing"] = "9";
            oc_Newobject5["dynamicSize"] = new Creator.StringNoQuote("true");
            oc_Newobject5["autoCellSize"] = new Creator.StringNoQuote("true");
            oc_Newobject5["internalName"] = "array";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            ctrl = oc_Newobject6.Create().AsString();

            this.add(ctrl);
            ctrl.collapse();

            // Sort the rollouts by their caption.

            this.sort("_GuiEditorToolboxSortRollouts");

            return ctrl;
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public string getRolloutForCategory(string category)
        {
            for (uint i = 0; i < this.getCount(); i++)
                {
                SimObject obj = this.getObject(i);
                if (!obj.isMemberOfClass("GuiRolloutCtrl"))
                    continue;

                if (Util.stricmp(obj["caption"], category) == 0)
                    return obj;
                }

            return "0";
        }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void startGuiControlDrag(string className)
        {
            GuiCanvas Canvas = "Canvas";

            // Create a new control of the given class.

            GuiControl payload = Util.eval("return new " + className + "();");
            if (!payload.isObject())
                return;

            // this offset puts the cursor in the middle of the dragged object.
            int xOffset = Util.getWord(payload.extent.AsString(), 0).AsInt()/2;
            int yOffset = Util.getWord(payload.extent.AsString(), 1).AsInt()/2;

            // position where the drag will start, to prevent visible jumping.
            Point2I cursorpos = Canvas.getCursorPos();
            int xPos = Util.getWord(cursorpos.AsString(), 0).AsInt() - xOffset;
            int yPos = Util.getWord(cursorpos.AsString(), 1).AsInt() - yOffset;

            // Create drag&drop control.

            ObjectCreator oc = new ObjectCreator("GuiDragAndDropControl");
            oc["canSaveDynamicFields"] = "0";
            oc["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc["HorizSizing"] = "right";
            oc["VertSizing"] = "bottom";
            oc["Position"] = xPos + ' ' + yPos;
            oc["extent"] = payload.extent;
            oc["MinExtent"] = "32 32";
            oc["canSave"] = "1";
            oc["Visible"] = "1";
            oc["hovertime"] = "1000";
            oc["deleteOnMouseUp"] = true;
            oc["class"] = "GuiDragAndDropControlType_GuiControl";

            GuiDragAndDropControl dragCtrl = oc.Create();

            dragCtrl.add(payload);
            ((SimSet) Canvas.getContent()).add(dragCtrl);

            // Start drag.

            dragCtrl.startDragging(xOffset, yOffset);
        }

        //=============================================================================================
        //    GuiEditorToolboxRolloutCtrl.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        //=============================================================================================
        //    Misc.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        /// Utility function to sort rollouts by their caption.
        public static int _GuiEditorToolboxSortRollouts(SimObject a, SimObject b)
        {
            return omni.Util.strinatcmp(a["caption"], b["caption"]);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiEditorToolbox ts, string simobjectid)
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
        public static bool operator !=(GuiEditorToolbox ts, string simobjectid)
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
        public static implicit operator string(GuiEditorToolbox ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorToolbox(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiEditorToolbox) Omni.self.getSimObject(simobjectid, typeof (GuiEditorToolbox));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEditorToolbox ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEditorToolbox(int simobjectid)
        {
            return (GuiEditorToolbox) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorToolbox));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEditorToolbox ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEditorToolbox(uint simobjectid)
        {
            return (GuiEditorToolbox) Omni.self.getSimObject(simobjectid, typeof (GuiEditorToolbox));
        }

        #endregion

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorToolboxButton>))]
        public class GuiEditorToolboxButton : GuiIconButtonCtrl
        {
            [ConsoleInteraction]
            public override void onMouseDragged()
            {
                GuiEditorToolbox GuiEditorToolbox = "GuiEditorToolbox";

                GuiEditorToolbox.startGuiControlDrag(this.text);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorToolboxButton ts, string simobjectid)
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
            public static bool operator !=(GuiEditorToolboxButton ts, string simobjectid)
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
            public static implicit operator string(GuiEditorToolboxButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorToolboxButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorToolboxButton) Omni.self.getSimObject(simobjectid, typeof (GuiEditorToolboxButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorToolboxButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorToolboxButton(int simobjectid)
            {
                return (GuiEditorToolboxButton) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorToolboxButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorToolboxButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorToolboxButton(uint simobjectid)
            {
                return (GuiEditorToolboxButton) Omni.self.getSimObject(simobjectid, typeof (GuiEditorToolboxButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<GuiEditorToolboxRolloutCtrl>))]
        public class GuiEditorToolboxRolloutCtrl : GuiRolloutCtrl
        {
            [ConsoleInteraction]
            public override void onHeaderRightClick()
            {
                MenuBuilder GuiEditorToolboxRolloutCtrlMenu = "GuiEditorToolboxRolloutCtrlMenu";

                if (!GuiEditorToolboxRolloutCtrlMenu.isObject())
                    {
                    ObjectCreator oc = new ObjectCreator("PopupMenu", "GuiEditorToolboxRolloutCtrlMenu", typeof (MenuBuilder));
                    oc["isPopup"] = true;

                    oc["item[0]"] = "Expand All" + '\t' + "" + '\t' + "GuiEditorToolboxRolloutCtrl.expandAll();";
                    oc["item[1]"] = "Collapse All" + '\t' + "" + '\t' + "GuiEditorToolboxRolloutCtrl.collapseAll();";
                    GuiEditorToolboxRolloutCtrlMenu = oc.Create();
                    }

                GuiEditorToolboxRolloutCtrlMenu.showPopup(this.getRoot());
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void expandAll()
            {
                for (uint i = 0; i < ((SimSet) this.parentGroup).getCount(); i++)
                    {
                    SimObject ctrl = ((SimSet) this.parentGroup).getObject(i);
                    if (ctrl.isMemberOfClass("GuiRolloutCtrl"))
                        ((GuiRolloutCtrl) ctrl).instantExpand();
                    }
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void collapseAll()
            {
                for (uint i = 0; i < ((SimSet) this.parentGroup).getCount(); i++)
                    {
                    SimObject ctrl = ((SimSet) this.parentGroup).getObject(i);
                    if (ctrl.isMemberOfClass("GuiRolloutCtrl"))
                        ((GuiRolloutCtrl) ctrl).instantCollapse();
                    }
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEditorToolboxRolloutCtrl ts, string simobjectid)
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
            public static bool operator !=(GuiEditorToolboxRolloutCtrl ts, string simobjectid)
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
            public static implicit operator string(GuiEditorToolboxRolloutCtrl ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorToolboxRolloutCtrl(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (GuiEditorToolboxRolloutCtrl) Omni.self.getSimObject(simobjectid, typeof (GuiEditorToolboxRolloutCtrl));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEditorToolboxRolloutCtrl ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEditorToolboxRolloutCtrl(int simobjectid)
            {
                return (GuiEditorToolboxRolloutCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEditorToolboxRolloutCtrl));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEditorToolboxRolloutCtrl ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEditorToolboxRolloutCtrl(uint simobjectid)
            {
                return (GuiEditorToolboxRolloutCtrl) Omni.self.getSimObject(simobjectid, typeof (GuiEditorToolboxRolloutCtrl));
            }

            #endregion
        }
    }
}