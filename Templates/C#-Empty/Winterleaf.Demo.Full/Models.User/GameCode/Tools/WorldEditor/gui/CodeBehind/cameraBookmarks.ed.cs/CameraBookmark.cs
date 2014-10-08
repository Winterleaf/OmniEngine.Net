#region

using WinterLeaf.Demo.Full.Models.Base;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class CameraBookmark : CameraBookmark_Base
        {
        private SimGroup CameraBookMarks
            {
            get { return "CameraBookmarks"; }
            }

        private EditorCameraBookmarksMenu EditorCameraBookmarks
            {
            get { return "EditorCameraBookmarks"; }
            }

        private EManageBookmarks EManageBookmarks
            {
            get { return "EManageBookmarks"; }
            }

        public override void onAdd()
            {
            base.onAdd();
            }

        public override void onRemove()
            {
            if ("EditorCameraBookmarks".isObject())
                {
                int pos = CameraBookMarks.getObjectIndex(this);
                if (pos != -1)
                    {
                    EditorCameraBookmarks.deleteItem(pos);
                    EManageBookmarks.deleteBookmark(this, pos);
                    }
                }
            }

        public override void onGroupAdd()
            {
            // If we're added to the CameraBookmarks group, then also add us
            // to the menu and Manage Bookmarks window.
            if ("CameraBookmarks".isObject())
                {
                int pos = CameraBookMarks.getObjectIndex(this);
                if (pos != -1)
                    {
                    EditorCameraBookmarks.addItem(pos.AsString(), this.internalName);
                    EManageBookmarks.addBookmark(this, pos);
                    }
                }
            }

        public override void onGroupRemove()
            {
            // If we're part of the CameraBookmarks group, then also remove us from
            // the menu and Manage Bookmarks window.
            if ("CameraBookmarks".isObject())
                {
                int pos = CameraBookMarks.getObjectIndex(this);
                if (pos != -1)
                    {
                    EditorCameraBookmarks.deleteItem(pos);
                    EManageBookmarks.deleteBookmark(this, pos);
                    }
                }
            }

        public override void onInspectPostApply()
            {
            EditorCameraBookmarks.rebuildBookmarks();
            }
        }
    }