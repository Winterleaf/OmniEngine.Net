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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.Extendable //namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
{
    public partial class UndoManager
    {
        [TypeConverter(typeof (TypeConverterGeneric<EUndoManager>))]
        public class EUndoManager : UndoManager
        {
            [ConsoleInteraction]
            public override void onUndo()
            {
            }

            [ConsoleInteraction]
            public override void onRedo()
            {
            }

            [ConsoleInteraction]
            public override void onAddUndo()
            {
            }

            [ConsoleInteraction]
            public override void onRemoveUndo()
            {
            }

            [ConsoleInteraction]
            public override void onClear()
            {
            }

            [ConsoleInteraction]
            public void updateUndoMenu(MenuBuilder editMenu)
            {
                // TODO: If we ever fix the TerrainEditor and WorldEditor
                // to have descriptive UndoAction names then we can change
                // the text as part of the menu update.

                string undoName = this.getNextUndoName();
                string redoName = this.getNextRedoName();

                editMenu.setItemName(0, "Undo " + undoName);
                editMenu.setItemName(1, "Redo " + redoName);

                editMenu.enableItem(0, (undoName != ""));
                editMenu.enableItem(1, (redoName != ""));
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EUndoManager ts, string simobjectid)
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
            public static bool operator !=(EUndoManager ts, string simobjectid)
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
            public static implicit operator string(EUndoManager ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EUndoManager(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (EUndoManager) Omni.self.getSimObject(simobjectid, typeof (EUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EUndoManager ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EUndoManager(int simobjectid)
            {
                return (EUndoManager) Omni.self.getSimObject((uint) simobjectid, typeof (EUndoManager));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EUndoManager ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EUndoManager(uint simobjectid)
            {
                return (EUndoManager) Omni.self.getSimObject(simobjectid, typeof (EUndoManager));
            }

            #endregion
        }
    }
}

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    public partial class MECreateUndoAction
    {

        [ConsoleInteraction]
        /// A helper for submitting a creation undo action.
        public static void submit(SimObject undoObject)
        {
            editor Editor = "Editor";

            // The instant group will try to add our
            // UndoAction if we don't disable it.   
            omni.Util.pushInstantGroup();

            // Create the undo action.     
            ObjectCreator actionCreator = new ObjectCreator("MECreateUndoAction");
            actionCreator["actionName"] = "Create " + undoObject.getClassName();

            MECreateUndoAction action = actionCreator.Create();

            // Restore the instant group.
            omni.Util.popInstantGroup();

            // Set the object to undo.
            action.addObject(undoObject);

            // Submit it.
            action.addToManager(Editor.getUndoManager());
        }

        [ConsoleInteraction]
        public override void onUndone()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
        }

        [ConsoleInteraction]
        public override void onRedone()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
        }
    }

    public partial class MEDeleteUndoAction
    {

        //todo need to change this.
        //[ConsoleInteraction ]
        /// A helper for submitting a delete undo action.
        /// If %wordSeperated is not specified or is false it is assumed %deleteObjects
        /// is tab sperated.
        public static void submit(string deleteObjects, bool wordSeperated)
        {
            editor Editor = "Editor";

            // The instant group will try to add our
            // UndoAction if we don't disable it.   
            omni.Util.pushInstantGroup();

            // Create the undo action.     
            ObjectCreator actionCreator = new ObjectCreator("MEDeleteUndoAction");
            actionCreator["actionName"] = "Delete";

            MEDeleteUndoAction action = actionCreator.Create();

            // Restore the instant group.
            omni.Util.popInstantGroup();

            // Add the deletion objects to the action which
            // will take care of properly deleting them.
            deleteObjects = omni.Util.trim(deleteObjects);

            if (wordSeperated)
                {
                int count = omni.Util.getWordCount(deleteObjects);
                for (int i = 0; i < count; i++)
                    {
                    SimObject xobject = omni.Util.getWord(deleteObjects, i);
                    action.deleteObject(xobject);
                    }
                }
            else
                {
                int count = omni.Util.getFieldCount(deleteObjects);
                for (int i = 0; i < count; i++)
                    {
                    SimObject xobject = omni.Util.getField(deleteObjects, i);
                    action.deleteObject(xobject);
                    }
                }

            // Submit it.
            action.addToManager(Editor.getUndoManager());
        }

        [ConsoleInteraction]
        public override void onUndone()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
        }

        [ConsoleInteraction]
        public override void onRedone()
        {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.syncGui();
        }
    }
}