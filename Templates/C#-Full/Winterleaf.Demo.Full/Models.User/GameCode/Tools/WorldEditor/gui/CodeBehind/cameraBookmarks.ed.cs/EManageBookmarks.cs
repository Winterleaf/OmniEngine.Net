using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs
    {
    [TypeConverter(typeof (TypeConverterGeneric<EManageBookmarks>))]
    public class EManageBookmarks : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction]
        public void hideDialog()
            {
            this.setVisible(false);
            }

        [ConsoleInteraction]
        public void ToggleVisibility()
            {
            if (visible)
                {
                setVisible(false);
                ((EWorldEditor) "EWorldEditor")["EManageBookmarksDisplayed"] = false.AsString();
                }
            else
                {
                setVisible(true);
                selectWindow();
                setCollapseGroup(false);
                ((WinterLeaf.Demo.Full.Models.User.Extendable.WorldEditor) "EWorldEditor")["EManageBookmarksDisplayed"] = true.AsString();
                }
            }

        [ConsoleInteraction]
        public void addBookmark(SimObject mark, int index)
            {
            ObjectCreator oc = new ObjectCreator("GuiControl");
            oc["internalName"] = mark.getInternalName();
            oc["Enabled"] = "1";
            oc["Profile"] = "ToolsGuiDefaultProfile";
            oc["HorizSizing"] = "right";
            oc["VertSizing"] = "bottom";
            oc["Position"] = "0 0";
            oc["Extent"] = "300 20";
            oc["MinExtent"] = "78 20";
            oc["Visible"] = "1";
            oc["Bookmark"] = mark;

            ObjectCreator oc1 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof (EManageBookmarksGoToButton));
            oc1["class"] = "EManageBookmarksGoToButton";
            oc1["bitmap"] = "tools/gui/images/camera-btn";
            oc1["groupNum"] = "-1";
            oc1["buttonType"] = "PushButton";
            oc1["useMouseEvents"] = "0";
            oc1["isContainer"] = "0";
            oc1["Profile"] = "ToolsGuiButtonProfile";
            oc1["HorizSizing"] = "right";
            oc1["VertSizing"] = "bottom";
            oc1["position"] = "2 2";
            oc1["Extent"] = "17 17";
            oc1["MinExtent"] = "8 2";
            oc1["canSave"] = "1";
            oc1["Visible"] = "1";
            oc1["Command"] = "";
            oc1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc1["ToolTip"] = "Go to bookmark";
            oc1["hovertime"] = "1000";
            oc1["internalName"] = "goToBookmark";
            oc1["canSaveDynamicFields"] = "0";

            oc["#1"] = oc1;

            ObjectCreator oc2 = new ObjectCreator("GuiTextEditCtrl", "", typeof (EManageBookmarksTextEdit));
            oc2["class"] = "EManageBookmarksTextEdit";
            oc2["internalName"] = "BookmarkName";
            oc2["profile"] = "ToolsGuiTextEditProfile";
            oc2["HorizSizing"] = "width";
            oc2["VertSizing"] = "bottom";
            oc2["position"] = "22 2";
            oc2["Extent"] = "260 18";
            oc2["text"] = mark.getInternalName();
            oc2["maxLength"] = "1024";
            oc2["AltCommand"] = "";
            oc["#2"] = oc2;

            ObjectCreator oc3 = new ObjectCreator("GuiBitmapButtonCtrl", "", typeof (EManageBookmarksDeleteButton));
            oc3["class"] = "EManageBookmarksDeleteButton";
            oc3["bitmap"] = "tools/gui/images/delete";
            oc3["groupNum"] = "-1";
            oc3["buttonType"] = "PushButton";
            oc3["useMouseEvents"] = "0";
            oc3["isContainer"] = "0";
            oc3["Profile"] = "ToolsGuiButtonProfile";
            oc3["HorizSizing"] = "left";
            oc3["VertSizing"] = "bottom";
            oc3["position"] = "284 3";
            oc3["Extent"] = "16 16";
            oc3["MinExtent"] = "8 2";
            oc3["canSave"] = "1";
            oc3["Visible"] = "1";
            oc3["Command"] = "";
            oc3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc3["ToolTip"] = "Delete camera bookmark";
            oc3["hovertime"] = "1000";
            oc3["internalName"] = "deleteBookmark";
            oc3["canSaveDynamicFields"] = "0";
            oc["#3"] = oc3;

            GuiControl gui = oc.Create();

            ((GuiStackControl)
                ((EManageBookmarks) "EManageBookmarks").findObjectByInternalName("ManageBookmarksWindowStack", true))
                .addGuiControl(gui);
            }

        [ConsoleInteraction]
        public void deleteBookmark(SimObject mark, int index)
            {
            GuiControl gui =
                ((GuiStackControl)
                    ((EManageBookmarks) "EManageBookmarks").findObjectByInternalName("ManageBookmarksWindowStack", true))
                    .findObjectByInternalName(mark.internalName, true);

            if (gui.isObject())
                gui.delete();
            else
                Util._warn("EManageBookmarks::deleteBookmark(): Could not find bookmark " + mark + " at index " + index);
            }

        [TypeConverter(typeof (TypeConverterGeneric<EAddBookmarkWindowName>))]
        public class EAddBookmarkWindowName : GuiTextEditCtrl
            {
            public override void onReturn()
                {
                ((ManageBookmarksContainer) "ManageBookmarksContainer").onOK();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EAddBookmarkWindowName ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
            public static bool operator !=(EAddBookmarkWindowName ts, string simobjectid)
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
            public static implicit operator string(EAddBookmarkWindowName ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EAddBookmarkWindowName(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EAddBookmarkWindowName) Omni.self.getSimObject(simobjectid, typeof (EAddBookmarkWindowName));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EAddBookmarkWindowName ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EAddBookmarkWindowName(int simobjectid)
                {
                return
                    (EAddBookmarkWindowName) Omni.self.getSimObject((uint) simobjectid, typeof (EAddBookmarkWindowName));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EAddBookmarkWindowName ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EAddBookmarkWindowName(uint simobjectid)
                {
                return (EAddBookmarkWindowName) Omni.self.getSimObject(simobjectid, typeof (EAddBookmarkWindowName));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<EManageBookmarksDeleteButton>))]
        public class EManageBookmarksDeleteButton : GuiBitmapButtonCtrl
            {
            public override void onClick(string SelectedidString)
                {
                SimObject mark = ((SimObject) this.getParent())["Bookmark"];
                ((EditorGui) "EditorGui").schedule("0", "removeCameraBookmark", mark.getInternalName());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EManageBookmarksDeleteButton ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
            public static bool operator !=(EManageBookmarksDeleteButton ts, string simobjectid)
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
            public static implicit operator string(EManageBookmarksDeleteButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EManageBookmarksDeleteButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (EManageBookmarksDeleteButton)
                        Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksDeleteButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EManageBookmarksDeleteButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EManageBookmarksDeleteButton(int simobjectid)
                {
                return
                    (EManageBookmarksDeleteButton)
                        Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarksDeleteButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EManageBookmarksDeleteButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EManageBookmarksDeleteButton(uint simobjectid)
                {
                return
                    (EManageBookmarksDeleteButton)
                        Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksDeleteButton));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<EManageBookmarksGoToButton>))]
        public class EManageBookmarksGoToButton : GuiBitmapButtonCtrl
            {
            public override void onClick(string SelectedidString)
                {
                EditorGui EditorGui = "EditorGui";

                SimObject mark = ((SimObject) this.getParent())["Bookmark"];
                EditorGui.jumpToBookmark(mark.getInternalName());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EManageBookmarksGoToButton ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
            public static bool operator !=(EManageBookmarksGoToButton ts, string simobjectid)
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
            public static implicit operator string(EManageBookmarksGoToButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EManageBookmarksGoToButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (EManageBookmarksGoToButton)
                        Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksGoToButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EManageBookmarksGoToButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EManageBookmarksGoToButton(int simobjectid)
                {
                return
                    (EManageBookmarksGoToButton)
                        Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarksGoToButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EManageBookmarksGoToButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EManageBookmarksGoToButton(uint simobjectid)
                {
                return
                    (EManageBookmarksGoToButton)
                        Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksGoToButton));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<EManageBookmarksTextEdit>))]
        public class EManageBookmarksTextEdit : GuiTextEditCtrl
            {
            private SimGroup CameraBookMarks
                {
                get { return "CameraBookmarks"; }
                }

            public override void onGainFirstResponder(string ID)
                {
                if (isActive())
                    selectAllText();
                }

            public override void onReturn()
                {
                onValidate();
                }

            public override void onValidate()
                {
                CameraBookmark mark = ((SimObject) this.getParent())["Bookmark"];
                string oldname = mark.getInternalName();
                string newname = getText();

                // If the new name is the same as the old, do nothing
                if (newname == oldname)
                    return;

                // Make sure the new name doesn't conflict with a current bookmark
                if ("CameraBookmarks".isObject() && CameraBookMarks.findObjectByInternalName(newname, true) != "")
                    {
                    int id = getId();

                    string callback = id + ".setText(\"" + oldname + "\"); " + id + ".makeFirstResponder(true); " + id +
                                      ".selectAllText();";
                    messageBox.MessageBoxOK("Create Bookmark", "You must provide a unique name for the new bookmark.",
                        callback);
                    return;
                    }
                // Rename the bookmark and update
                ((SimObject) this.getParent()).setInternalName(newname);
                mark.setInternalName(newname);
                Inspector Inspector = "Inspector";
                if (Inspector.getInspectObject() == mark.getId().AsString())
                    {
                    Inspector.inspect(mark);
                    Inspector.apply();
                    }
                else
                    {
                    // User is not inspecting the bookmark, so manually
                    // update the menu.
                    mark.onInspectPostApply();
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EManageBookmarksTextEdit ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
            public static bool operator !=(EManageBookmarksTextEdit ts, string simobjectid)
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
            public static implicit operator string(EManageBookmarksTextEdit ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EManageBookmarksTextEdit(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EManageBookmarksTextEdit) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksTextEdit));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EManageBookmarksTextEdit ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EManageBookmarksTextEdit(int simobjectid)
                {
                return
                    (EManageBookmarksTextEdit)
                        Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarksTextEdit));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EManageBookmarksTextEdit ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EManageBookmarksTextEdit(uint simobjectid)
                {
                return (EManageBookmarksTextEdit) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksTextEdit));
                }

            #endregion
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EManageBookmarks ts, string simobjectid)
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
        public static bool operator !=(EManageBookmarks ts, string simobjectid)
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
        public static implicit operator string(EManageBookmarks ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EManageBookmarks(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EManageBookmarks) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarks));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EManageBookmarks ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EManageBookmarks(int simobjectid)
            {
            return (EManageBookmarks) Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarks));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EManageBookmarks ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EManageBookmarks(uint simobjectid)
            {
            return (EManageBookmarks) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarks));
            }

        #endregion
        }
    }