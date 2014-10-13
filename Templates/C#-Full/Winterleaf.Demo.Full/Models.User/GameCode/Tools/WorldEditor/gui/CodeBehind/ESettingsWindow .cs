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
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
{
    //ESettingsWindowColor
    [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindow>))]
    public class ESettingsWindow : GuiWindowCollapseCtrl
    {
        internal GuiTabBookCtrl eSettingsWindowTabBook
        {
            get { return "ESettingsWindowTabBook"; }
        }

        internal GuiTextListCtrl eSettingsWindowList
        {
            get { return "ESettingsWindowList"; }
        }

        [ConsoleInteraction]
        public void startup()
        {
            eSettingsWindowTabBook.selectPage(0);
            eSettingsWindowList.setSelectedById(0);
        }

        public override void onWake()
        {
            base.onWake();
        }

        [ConsoleInteraction]
        public void hideDialog()
        {
            this.setVisible(false);
        }

        [ConsoleInteraction]
        public void ToggleVisibility()
        {
            if (visible)
                setVisible(false);
            else
                {
                setVisible(true);
                selectWindow();
                setCollapseGroup(false);
                }
        }

        [ConsoleInteraction]
        public void addTabPage(GuiTabPageCtrl page)
        {
            eSettingsWindowTabBook.add(page);
            eSettingsWindowList.addRow(eSettingsWindowTabBook.getSelectedPage(), page.text, -1);
            eSettingsWindowList.sort("0");
        }

        [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowCheckbox>))]
        public class ESettingsWindowCheckbox : GuiCheckBoxCtrl
        {
            public override void onWake()
            {
                Settings EditorSettings = "EditorSettings";

                this.setStateOn(EditorSettings.value(this["editorSettingsValue"]).AsBool());
            }

            public override void onClick(string SelectedidString)
            {
                Settings EditorSettings = "EditorSettings";
                EditorSettings.setValue(this["editorSettingsValue"], getValue());
                Util.eval(this["editorSettingsRead"]);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ESettingsWindowCheckbox ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowCheckbox ts, string simobjectid)
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
            public static implicit operator string(ESettingsWindowCheckbox ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowCheckbox(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ESettingsWindowCheckbox) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowCheckbox));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ESettingsWindowCheckbox ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowCheckbox(int simobjectid)
            {
                return (ESettingsWindowCheckbox) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowCheckbox));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ESettingsWindowCheckbox ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ESettingsWindowCheckbox(uint simobjectid)
            {
                return (ESettingsWindowCheckbox) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowCheckbox));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowColor>))]
        public class ESettingsWindowColor : GuiControl
        {
            [ConsoleInteraction]
            public void apply(string color)
            {
                Settings EditorSettings = "EditorSettings";
                EditorSettings.setValue(this["editorSettingsValue"], color);
                Util.eval(this["editorSettingsRead"]);

                ((GuiTextEditCtrl) this.findObjectByInternalName("ColorEdit", true)).setText(color);

                ((GuiSwatchButtonCtrl) this.findObjectByInternalName("ColorButton", true))["color"] = ColorPickerDlg.ColorIntToFloat(color);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ESettingsWindowColor ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowColor ts, string simobjectid)
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
            public static implicit operator string(ESettingsWindowColor ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColor(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ESettingsWindowColor) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ESettingsWindowColor ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColor(int simobjectid)
            {
                return (ESettingsWindowColor) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowColor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ESettingsWindowColor ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColor(uint simobjectid)
            {
                return (ESettingsWindowColor) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColor));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowColorButton>))]
        public class ESettingsWindowColorButton : GuiSwatchButtonCtrl
        {
            public override void onWake()
            {
                Settings EditorSettings = "EditorSettings";
                string color = EditorSettings.value(((SimObject) getParent())["editorSettingsValue"]);

                this["color"] = ColorPickerDlg.ColorIntToFloat(color);
            }

            public override void onClick(string SelectedidString)
            {
                string colorfloattoint = ColorPickerDlg.ColorFloatToInt(this["color"]);
                ColorPickerDlg.GetColorI(colorfloattoint, getId() + ".apply", getRoot(), "", "");
            }

            [ConsoleInteraction]
            public void apply(string color)
            {
                ((GuiControl) getParent()).call("apply", color);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ESettingsWindowColorButton ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowColorButton ts, string simobjectid)
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
            public static implicit operator string(ESettingsWindowColorButton ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColorButton(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ESettingsWindowColorButton) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColorButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ESettingsWindowColorButton ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColorButton(int simobjectid)
            {
                return (ESettingsWindowColorButton) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowColorButton));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ESettingsWindowColorButton ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColorButton(uint simobjectid)
            {
                return (ESettingsWindowColorButton) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColorButton));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowColorEdit>))]
        public class ESettingsWindowColorEdit : GuiTextEditCtrl
        {
            public override void onWake()
            {
                Settings EditorSettings = "EditorSettings";
                this.setText(EditorSettings.value(((SimObject) getParent())["editorSettingsValue"]));
            }

            public override void onValidate()
            {
                //I think this is right.
                ((GuiControl) getParent()).call("apply", getValue());
            }

            public override void onGainFirstResponder(string ID)
            {
                this.selectAllText();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ESettingsWindowColorEdit ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowColorEdit ts, string simobjectid)
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
            public static implicit operator string(ESettingsWindowColorEdit ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColorEdit(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ESettingsWindowColorEdit) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColorEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ESettingsWindowColorEdit ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColorEdit(int simobjectid)
            {
                return (ESettingsWindowColorEdit) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowColorEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ESettingsWindowColorEdit ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ESettingsWindowColorEdit(uint simobjectid)
            {
                return (ESettingsWindowColorEdit) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColorEdit));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowList>))]
        public class ESettingsWindowList : GuiTextListCtrl
        {
            public GuiTabBookCtrl eSettingsWindowTabBook
            {
                get { return "ESettingsWindowTabBook"; }
            }

            public override void onSelect(string x, string y)
            {
                eSettingsWindowTabBook.selectPage(x.AsInt());
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ESettingsWindowList ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowList ts, string simobjectid)
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
            public static implicit operator string(ESettingsWindowList ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowList(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ESettingsWindowList) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ESettingsWindowList ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowList(int simobjectid)
            {
                return (ESettingsWindowList) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowList));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ESettingsWindowList ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ESettingsWindowList(uint simobjectid)
            {
                return (ESettingsWindowList) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowList));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ESettingsWindowTextEdit>))]
        public class ESettingsWindowTextEdit : GuiTextEditCtrl
        {
            public override void onWake()
            {
                Settings EditorSettings = "EditorSettings";
                this.setText(EditorSettings.value(this["editorSettingsValue"]));
            }

            public override void onValidate()
            {
                Settings EditorSettings = "EditorSettings";
                EditorSettings.setValue(this["editorSettingsValue"], getValue());
                Util.eval(this["editorSettingsRead"]);
            }

            public override void onGainFirstResponder(string ID)
            {
                selectAllText();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ESettingsWindowTextEdit ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowTextEdit ts, string simobjectid)
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
            public static implicit operator string(ESettingsWindowTextEdit ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowTextEdit(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ESettingsWindowTextEdit) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ESettingsWindowTextEdit ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ESettingsWindowTextEdit(int simobjectid)
            {
                return (ESettingsWindowTextEdit) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowTextEdit));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ESettingsWindowTextEdit ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ESettingsWindowTextEdit(uint simobjectid)
            {
                return (ESettingsWindowTextEdit) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowTextEdit));
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
        public static bool operator ==(ESettingsWindow ts, string simobjectid)
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
        public static bool operator !=(ESettingsWindow ts, string simobjectid)
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
        public static implicit operator string(ESettingsWindow ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ESettingsWindow(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ESettingsWindow) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ESettingsWindow ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ESettingsWindow(int simobjectid)
        {
            return (ESettingsWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindow));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ESettingsWindow ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ESettingsWindow(uint simobjectid)
        {
            return (ESettingsWindow) Omni.self.getSimObject(simobjectid, typeof (ESettingsWindow));
        }

        #endregion
    }
}