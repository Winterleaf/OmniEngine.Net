using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorCameraBookmarksMenu>))]
    public class EditorCameraBookmarksMenu : MenuBuilder
        {
        private bool NoneItem
            {
            get { return this["NoneItem"].AsBool(); }
            set { this["NoneItem"] = value.AsString(); }
            }

        private SimGroup CameraBookMarks
            {
            get { return "CameraBookmarks"; }
            }

        public override void onAdd()
            {
            if (!this["canvas"].isObject())
                this["canvas"] = "Canvas";
            // Add any existing bookmarks
            this.rebuildBookmarks();
            }

        [ConsoleInteraction]
        public override void addItem(string pos, string item = "")
            {
            if (NoneItem == true)
                {
                NoneItem = false;
                this.removeItem(0);
                }

            this.insertItem(pos.AsInt(), name != "-" ? name : "", "");
            }

        [ConsoleInteraction]
        public void deleteItem(int pos)
            {
            removeItem(pos);
            if (this.getItemCount() == 0 && NoneItem != true)
                {
                addItem("0", "None");
                enableItem(0, false);
                NoneItem = true;
                }
            }

        public override bool onSelectItem(string pos, string text)
            {
            if (pos.AsInt() >= 0 && pos.AsInt() < CameraBookMarks.getCount())
                {
                EditorGui EditorGui = "EditorGui";
                SimObject mark = CameraBookMarks.getObject(pos.AsUInt());
                EditorGui.jumpToBookmark(mark.internalName);
                return true;
                }
            return false;
            }

        public void rebuildBookmarks()
            {
            while (this.getItemCount() > 0)
                removeItem(0);

            // Add back in all of the bookmarks

            if ("CameraBookmarks".isObject() && CameraBookMarks.getCount() > 0)
                {
                for (int i = 0; i < CameraBookMarks.getCount(); i++)
                    {
                    SimObject mark = CameraBookMarks.getObject((uint) i);
                    addItem(i.AsString(), mark.internalName);
                    }
                NoneItem = false;
                }
            else
                {
                addItem("0", "None");
                this.enableItem(0, false);
                NoneItem = true;
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorCameraBookmarksMenu ts, string simobjectid)
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
        public static bool operator !=(EditorCameraBookmarksMenu ts, string simobjectid)
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
        public static implicit operator string(EditorCameraBookmarksMenu ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorCameraBookmarksMenu(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorCameraBookmarksMenu) Omni.self.getSimObject(simobjectid, typeof (EditorCameraBookmarksMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorCameraBookmarksMenu ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorCameraBookmarksMenu(int simobjectid)
            {
            return
                (EditorCameraBookmarksMenu)
                    Omni.self.getSimObject((uint) simobjectid, typeof (EditorCameraBookmarksMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorCameraBookmarksMenu ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorCameraBookmarksMenu(uint simobjectid)
            {
            return (EditorCameraBookmarksMenu) Omni.self.getSimObject(simobjectid, typeof (EditorCameraBookmarksMenu));
            }

        #endregion
        }
    }