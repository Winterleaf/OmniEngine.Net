using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
                {
                this.insertItem(pos.AsInt(), name != "-" ? name : "", accel);
                }
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
                Util._error("MenuBuilder::attachToMenuBar - Menu " + this["barName"] +
                            "property 'barPosition' is invalid, must be zero or greater.");
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
        public static bool operator !=(MenuBuilder ts, string simobjectid)
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