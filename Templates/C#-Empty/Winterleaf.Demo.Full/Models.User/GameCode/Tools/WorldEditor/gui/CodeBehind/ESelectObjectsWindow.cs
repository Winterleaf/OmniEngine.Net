using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
                if (val)
                    selectionSet.add(obj);
                else
                    selectionSet.remove(obj);
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
                        messageBox.MessageBoxOK("Error",
                            "An object called '" + name +
                            "' already exists and is not a selection.  Please choose a different name.");
                        return;
                        }
                    else if (!reuseExistingSet)
                        {
                        messageBox.MessageBoxYesNo("Question",
                            "A selection called '" + name + "' already exists. Modify the existing selection?",
                            this + ".onSelectObjects( " + val + ", true );", "");
                        return;
                        }
                    else
                        {
                        sel = name;
                        }
                    }
                else
                    {
                    editor Editor = "Editor";
                    if (!Editor.validateObjectName(name, false))
                        return;

                    // Create a new selection set.
                    sel =
                        console.Eval("%sel = new WorldEditorSelection( " + name +
                                     " ) { parentGroup = Selections; canSave = true; };return sel;", true);

                    if (!sel.isObject())
                        {
                        messageBox.MessageBoxOK("Error",
                            "Could not create the selection set.  Please look at the console.log for details.");
                        return;
                        }
                    }

                this["selectionSet"] = sel;
                }
            else
                {
                this["selectionSet"] = "";
                }

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
        public static bool operator !=(ESelectObjectsWindow ts, string simobjectid)
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