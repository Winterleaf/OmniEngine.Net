using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
            public static bool operator !=(ESettingsWindowCheckbox ts, string simobjectid)
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
                return
                    (ESettingsWindowCheckbox)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowCheckbox));
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

                ((GuiSwatchButtonCtrl) this.findObjectByInternalName("ColorButton", true))["color"] =
                    ColorPickerDlg.ColorIntToFloat(color);
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
            public static bool operator !=(ESettingsWindowColor ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowColorButton ts, string simobjectid)
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
                return
                    (ESettingsWindowColorButton)
                        Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColorButton));
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
                return
                    (ESettingsWindowColorButton)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowColorButton));
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
                return
                    (ESettingsWindowColorButton)
                        Omni.self.getSimObject(simobjectid, typeof (ESettingsWindowColorButton));
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
            public static bool operator !=(ESettingsWindowColorEdit ts, string simobjectid)
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
                return
                    (ESettingsWindowColorEdit)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowColorEdit));
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
            public static bool operator !=(ESettingsWindowList ts, string simobjectid)
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
            public static bool operator !=(ESettingsWindowTextEdit ts, string simobjectid)
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
                return
                    (ESettingsWindowTextEdit)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ESettingsWindowTextEdit));
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
        public static bool operator !=(ESettingsWindow ts, string simobjectid)
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