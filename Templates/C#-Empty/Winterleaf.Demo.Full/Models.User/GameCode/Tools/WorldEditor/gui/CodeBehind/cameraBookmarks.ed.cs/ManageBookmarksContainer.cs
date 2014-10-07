using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs
    {
    [TypeConverter(typeof (TypeConverterGeneric<ManageBookmarksContainer>))]
    public class ManageBookmarksContainer : GuiControl
        {
        private SimGroup CameraBookMarks
            {
            get { return "CameraBookmarks"; }
            }

        [ConsoleInteraction]
        public void onOK()
            {
            string name = ((EManageBookmarks.EAddBookmarkWindowName) "EAddBookmarkWindowName").getText();
            ((EManageBookmarks.EAddBookmarkWindowName) "EAddBookmarkWindowName").clearFirstResponder(false);

            if (name == "")
                {
                // look for a NewCamera name to grab
                for (int i = 0;; i++)
                    {
                    name = "NewCamera_" + i;
                    if (CameraBookMarks.findObjectByInternalName(name, true) == "")
                        break;
                    }
                }

            if ("CameraBookmarks".isObject() && CameraBookMarks.findObjectByInternalName(name, true) != "")
                {
                string username = name;
                for (int i = 0;; i++)
                    {
                    name = username + "_" + i;
                    if (CameraBookMarks.findObjectByInternalName(name, true) == "")
                        break;
                    }
                }

            ((EditorGui) "EditorGui").addCameraBookmark(name);
            ((EManageBookmarks.EAddBookmarkWindowName) "EAddBookmarkWindowName").text = "";
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ManageBookmarksContainer ts, string simobjectid)
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
        public static bool operator !=(ManageBookmarksContainer ts, string simobjectid)
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
        public static implicit operator string(ManageBookmarksContainer ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ManageBookmarksContainer(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ManageBookmarksContainer) Omni.self.getSimObject(simobjectid, typeof (ManageBookmarksContainer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ManageBookmarksContainer ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ManageBookmarksContainer(int simobjectid)
            {
            return
                (ManageBookmarksContainer) Omni.self.getSimObject((uint) simobjectid, typeof (ManageBookmarksContainer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ManageBookmarksContainer ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ManageBookmarksContainer(uint simobjectid)
            {
            return (ManageBookmarksContainer) Omni.self.getSimObject(simobjectid, typeof (ManageBookmarksContainer));
            }

        #endregion
        }
    }