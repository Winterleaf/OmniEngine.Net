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
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Engine;
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
                ((Extendable.WorldEditor) "EWorldEditor")["EManageBookmarksDisplayed"] = true.AsString();
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

            ((GuiStackControl) ((EManageBookmarks) "EManageBookmarks").findObjectByInternalName("ManageBookmarksWindowStack", true)).addGuiControl(gui);
        }

        [ConsoleInteraction]
        public void deleteBookmark(SimObject mark, int index)
        {
            GuiControl gui = ((GuiStackControl) ((EManageBookmarks) "EManageBookmarks").findObjectByInternalName("ManageBookmarksWindowStack", true)).findObjectByInternalName(mark.internalName, true);

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
            public static bool operator !=(EAddBookmarkWindowName ts, string simobjectid)
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
                return (EAddBookmarkWindowName) Omni.self.getSimObject((uint) simobjectid, typeof (EAddBookmarkWindowName));
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
            public static bool operator !=(EManageBookmarksDeleteButton ts, string simobjectid)
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
                return (EManageBookmarksDeleteButton) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksDeleteButton));
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
                return (EManageBookmarksDeleteButton) Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarksDeleteButton));
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
                return (EManageBookmarksDeleteButton) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksDeleteButton));
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
            public static bool operator !=(EManageBookmarksGoToButton ts, string simobjectid)
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
                return (EManageBookmarksGoToButton) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksGoToButton));
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
                return (EManageBookmarksGoToButton) Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarksGoToButton));
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
                return (EManageBookmarksGoToButton) Omni.self.getSimObject(simobjectid, typeof (EManageBookmarksGoToButton));
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

                    string callback = id + ".setText(\"" + oldname + "\"); " + id + ".makeFirstResponder(true); " + id + ".selectAllText();";
                    messageBox.MessageBoxOK("Create Bookmark", "You must provide a unique name for the new bookmark.", callback);
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
            public static bool operator !=(EManageBookmarksTextEdit ts, string simobjectid)
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
                return (EManageBookmarksTextEdit) Omni.self.getSimObject((uint) simobjectid, typeof (EManageBookmarksTextEdit));
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
        public static bool operator !=(EManageBookmarks ts, string simobjectid)
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