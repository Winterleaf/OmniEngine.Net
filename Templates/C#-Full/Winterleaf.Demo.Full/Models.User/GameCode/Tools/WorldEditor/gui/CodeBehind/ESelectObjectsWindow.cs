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
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    [TypeConverter(typeof (TypeConverterGeneric<ESelectObjectsWindow>))]
    public class ESelectObjectsWindow : EObjectSelection
    {
        private SimGroup selectionSet
        {
            get { return this["selectionSet"]; }
        }

        [ConsoleInteraction(true, "ESelectObjectsWindow_Initialize")]
        public static void initialize()
        {
            SingletonCreator sc = new SingletonCreator("SimGroup", "EWorldEditorSelectionFilters");
            sc.Create();
        }

        [ConsoleInteraction]
        public void toggleVisibility()
        {
            setVisible(!isVisible());
        }

        /// Function called by EObjectSelection::onSelectObjects to determine where
        /// to start searching for objects.
        [ConsoleInteraction]
        public override SimGroup getRootGroup()
        {
            return "MissionGroup";
        }

        //internal override bool includeClass(string className)
        //    {
        //    return base.includeClass(className);
        //    }

        public override SimObject getFilterSet()
        {
            return "EWorldEditorSelectionFilters";
        }

        /// Method called by EObjectSelection::initClassList to determine if the given
        /// class should be included in the class list.
        [ConsoleInteraction]
        public override bool includeClass(string className)
        {
            Console.WriteLine("------------->" + className);

            return Util.isMemberOfClass(className, "SceneObject") || className == "SimGroup" || className == "LevelInfo";
        }

        /// Method called by the EObjectSelection machinery when an object has been
        /// matched against the given criteria.
        [ConsoleInteraction]
        public override void selectObject(SimObject obj, bool val)
        {
            if (selectionSet.isObject())
                {
                if (val)
                    selectionSet.add(obj);
                else
                    selectionSet.remove(obj);
                }
            else if (val)
                ((EWorldEditor) "EWorldEditor").selectObject(obj);
            else
                ((EWorldEditor) "EWorldEditor").unselectObject(obj);
        }

        [ConsoleInteraction]
        public override void clearSelection()
        {
            if (selectionSet.isObject())
                selectionSet.clear();
            else
                ((EWorldEditor) "EWorldEditor").clearSelection();
        }

        public override void onWake()
        {
            if (!this["isInitialized"].AsBool())
                {
                this.init();
                this["isInitialized"] = true.AsString();
                }

            // Re-initialize the group list on each wake.

            this.initGroupList();
        }

        public override void onSelectObjects(bool val, bool reuseExistingSet = false)
        {
            string sel = "";
            // See if we should create an independent selection set.
            GuiCheckBoxCtrl createSelectionSet = this.findObjectByInternalName("createSelectionSet", true);
            if (createSelectionSet.isStateOn())
                {
                string sname = ((GuiTextEditCtrl) this.findObjectByInternalName("selectionSetName", true)).getText();
                // See if we should create or re-use a set.

                if (sname.isObject())
                    {
                    SimObject name = sname;
                    if (name.isMemberOfClass("WorldEditorSelection"))
                        {
                        messageBox.MessageBoxOK("Error", "An object called '" + name + "' already exists and is not a selection.  Please choose a different name.");
                        return;
                        }
                    else if (!reuseExistingSet)
                        {
                        messageBox.MessageBoxYesNo("Question", "A selection called '" + name + "' already exists. Modify the existing selection?", this + ".onSelectObjects( " + val + ", true );", "");
                        return;
                        }
                    else
                        sel = name;
                    }
                else
                    {
                    editor Editor = "Editor";
                    if (!Editor.validateObjectName(name, false))
                        return;

                    // Create a new selection set.
                    sel = console.Eval("%sel = new WorldEditorSelection( " + name + " ) { parentGroup = Selections; canSave = true; };return sel;", true);

                    if (!sel.isObject())
                        {
                        messageBox.MessageBoxOK("Error", "Could not create the selection set.  Please look at the console.log for details.");
                        return;
                        }
                    }

                this["selectionSet"] = sel;
                }
            else
                this["selectionSet"] = "";

            base.onSelectObjects(val, false);

            // Refresh editor tree just in case.
            EditorTree EditorTree = "EditorTree";

            EditorTree.buildVisibleTree();
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ESelectObjectsWindow ts, string simobjectid)
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
        public static bool operator !=(ESelectObjectsWindow ts, string simobjectid)
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
        public static implicit operator string(ESelectObjectsWindow ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ESelectObjectsWindow(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ESelectObjectsWindow) Omni.self.getSimObject(simobjectid, typeof (ESelectObjectsWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ESelectObjectsWindow ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ESelectObjectsWindow(int simobjectid)
        {
            return (ESelectObjectsWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ESelectObjectsWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ESelectObjectsWindow ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ESelectObjectsWindow(uint simobjectid)
        {
            return (ESelectObjectsWindow) Omni.self.getSimObject(simobjectid, typeof (ESelectObjectsWindow));
        }

        #endregion
    }
}