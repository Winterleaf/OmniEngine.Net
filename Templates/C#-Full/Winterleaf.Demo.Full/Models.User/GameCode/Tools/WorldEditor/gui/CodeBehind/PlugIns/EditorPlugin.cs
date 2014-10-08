using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorPlugin>))]
    public class EditorPlugin : ScriptObject
        {
        internal bool isActivated
            {
            get { return this["isActivated"].AsBool(); }
            set { this["isActivated"] = value.AsString(); }
            }

        ///
        /// This is used to register editor extensions and tools.
        ///
        /// There are various callbacks you can overload to hook in your
        /// own functionality without changing the core editor code.
        ///
        /// At the moment this is primarily for the World/Mission 
        /// Editor and the callbacks mostly make sense in that context.
        ///
        /// Example:
        ///
        ///   %obj = new ScriptObject()
        ///   {
        ///      superclass = "EditorPlugin";
        ///      class = "RoadEditor";
        ///   };
        ///   
        ///   EditorPlugin::register( %obj );
        ///
        /// For an a full example see: tools/roadEditor/main.cs
        ///                        or: tools/riverEditor/main.cs
        ///                        or: tools/decalEditor/main.cs
        ///
        /// It is not intended for the user to overload this method.
        /// If you do make sure you call the parent.
        public override void onAdd(string ID)
            {
            ((SimSet) "EditorPluginSet").add(this);
            }

        /// Callback when the world editor is first started.  It
        /// is a good place to insert menus and menu items as well as 
        /// preparing guis.
        [ConsoleInteraction]
        public virtual void onWorldEditorStartup()
            {
            }

        public virtual bool? setEditorFunction(string overrideGroup = "")
            {
            return null;
            }


        /// Callback when the world editor is about to be totally deleted.
        /// At the time of this writing this occurs when the engine is shut down
        /// and the editor had been initialized.
        [ConsoleInteraction]
        public virtual void onWorldEditorShutdown()
            {
            }

        /// Callback right before the editor is opened.
        [ConsoleInteraction]
        public virtual void onEditorWake()
            {
            }

        /// Callback right before the editor is closed.
        [ConsoleInteraction]
        public virtual void onEditorSleep()
            {
            }

        /// Callback when the tool is 'activated' by the WorldEditor
        /// Push Gui's, stuff like that
        [ConsoleInteraction]
        public virtual void onActivated()
            {
            if (Util.isDemo())
                console.Call("startToolTime", new string[] {this.getName()});

            this.isActivated = true;
            }

        /// Callback when the tool is 'deactivated' / closed by the WorldEditor
        /// Pop Gui's, stuff like that
        [ConsoleInteraction]
        public virtual void onDeactivated()
            {
            if (Util.isDemo())
                console.Call("endToolTime", new string[] {this.getName()});

            this.isActivated = false;
            }

        /// Callback when tab is pressed.
        /// Used by the WorldEditor to toggle between inspector/creator, for example.
        [ConsoleInteraction]
        public virtual void onToggleToolWindows()
            {
            }

        /// Callback when the edit menu is clicked or prior to handling an accelerator 
        /// key event mapped to an edit menu item.
        /// It is up to the active editor to determine if these actions are
        /// appropriate in the current state.
        [ConsoleInteraction]
        public virtual void onEditMenuSelect(string editMenu)
            {
            ((PopupMenu) editMenu).enableItem(3, false);
            ((PopupMenu) editMenu).enableItem(4, false);
            ((PopupMenu) editMenu).enableItem(5, false);
            ((PopupMenu) editMenu).enableItem(6, false);
            ((PopupMenu) editMenu).enableItem(8, false);
            }

        /// If this tool keeps track of changes that necessitate resaving the mission
        /// return true in that case.
        [ConsoleInteraction]
        public virtual bool isDirty()
            {
            return false;
            }

        /// This gives tools a chance to clear whatever internal variables keep track of changes
        /// since the last save.
        [ConsoleInteraction]
        public virtual void clearDirty()
            {
            }

        /// This gives tools chance to save data out when the mission is being saved.
        /// This will only be called if the tool says it is dirty.
        [ConsoleInteraction]
        public virtual void onSaveMission(string missionFile)
            {
            }

        /// Called when during mission cleanup to notify plugins.
        [ConsoleInteraction]
        public virtual void onExitMission()
            {
            }

        /// Called on the active plugin when a SceneObject is selected.
        ///
        /// @param object The object being selected.
        [ConsoleInteraction]
        public virtual void onObjectSelected(SimObject obj)
            {
            }

        /// Called on the active plugin when a SceneObject is deselected.
        ///
        /// @param object The object being deselected.
        [ConsoleInteraction]
        public virtual void onObjectDeselected(SimObject obj)
            {
            }

        /// Called on the active plugin when the selection of SceneObjects is cleared.
        [ConsoleInteraction]
        public virtual void onSelectionCleared()
            {
            }

        /// Callback when the the delete item of the edit menu is selected or its
        /// accelerator is pressed.
        [ConsoleInteraction]
        public virtual void handleDelete()
            {
            Util._warn("EditorPlugin::handleDelete( " + this.getName() +
                       " )\r\n Was not implemented in child namespace, yet menu item was enabled.");
            }

        /// Callback when the the deselect item of the edit menu is selected or its
        /// accelerator is pressed.
        [ConsoleInteraction]
        public virtual void handleDeselect()
            {
            Util._warn("EditorPlugin::handleDeselect( " + this.getName() +
                       " )\r\n Was not implemented in child namespace, yet menu item was enabled.");
            }

        /// Callback when the the cut item of the edit menu is selected or its
        /// accelerator is pressed.
        [ConsoleInteraction]
        public virtual void handleCut()
            {
            Util._warn("EditorPlugin::handleCut( " + this.getName() +
                       " )\r\n Was not implemented in child namespace, yet menu item was enabled.");
            }

        /// Callback when the the copy item of the edit menu is selected or its
        /// accelerator is pressed.
        [ConsoleInteraction]
        public virtual void handleCopy()
            {
            Util._warn("EditorPlugin::handleCopy( " + this.getName() +
                       " )\r\n Was not implemented in child namespace, yet menu item was enabled.");
            }

        /// Callback when the the paste item of the edit menu is selected or its
        /// accelerator is pressed.
        [ConsoleInteraction]
        public virtual void handlePaste()
            {
            Util._warn("EditorPlugin::handlePaste( " + this.getName() +
                       " )\r\n Was not implemented in child namespace, yet menu item was enabled.");
            }


        /// Callback when the escape key is pressed.
        /// Return true if this tool has handled the key event in a custom way.
        /// If false is returned the WorldEditor default behavior is to return
        /// to the ObjectEditor.
        [ConsoleInteraction]
        public virtual bool handleEscape()
            {
            return false;
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorPlugin ts, string simobjectid)
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
        public static bool operator !=(EditorPlugin ts, string simobjectid)
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
        public static implicit operator string(EditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorPlugin) Omni.self.getSimObject(simobjectid, typeof (EditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorPlugin(int simobjectid)
            {
            return (EditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (EditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorPlugin(uint simobjectid)
            {
            return (EditorPlugin) Omni.self.getSimObject(simobjectid, typeof (EditorPlugin));
            }

        #endregion
        }
    }