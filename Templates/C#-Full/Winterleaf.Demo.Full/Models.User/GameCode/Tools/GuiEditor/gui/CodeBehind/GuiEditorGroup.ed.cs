using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
            group.setExtent(new Point2F( Util.getWord(bounds, 2).AsFloat(), Util.getWord(bounds, 3).AsFloat()));

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
        public static bool operator !=(GuiEditorGroup ts, string simobjectid)
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