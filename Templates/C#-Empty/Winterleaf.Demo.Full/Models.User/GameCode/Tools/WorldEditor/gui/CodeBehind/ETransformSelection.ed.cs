using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<ETransformSelection>))]
    public class ETransformSelection : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction]
        public override void onWake()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            GuiCheckBoxCtrl PosRelative = this.FOT("PosRelative");
            GuiCheckBoxCtrl RotRelative = this.FOT("RotRelative");
            GuiCheckBoxCtrl ScaleRelative = this.FOT("ScaleRelative");
            GuiCheckBoxCtrl SizeRelative = this.FOT("SizeRelative");
            GuiButtonCtrl GetPosButton = this.FOT("GetPosButton");
            GuiButtonCtrl GetRotButton = this.FOT("GetRotButton");
            GuiButtonCtrl GetScaleButton = this.FOT("GetScaleButton");
            GuiButtonCtrl GetSizeButton = this.FOT("GetSizeButton");
            GuiCheckBoxCtrl SizeLocal = this.FOT("SizeLocal");
            GuiTabBookCtrl ScaleTabBook = this.FOT("ScaleTabBook");
            GuiButtonCtrl ApplyButton = this.FOT("ApplyButton");

            // Make everything relative
            PosRelative.setStateOn(true);
            RotRelative.setStateOn(true);
            ScaleRelative.setStateOn(true);
            SizeRelative.setStateOn(false);

            GetPosButton.setActive(false);
            GetRotButton.setActive(false);
            GetScaleButton.setActive(false);
            GetSizeButton.setActive(false);

            // Size is always local
            SizeLocal.setStateOn(true);
            SizeLocal.setActive(false);

            ScaleTabBook.selectPage(0); // Scale page

            ApplyButton.setActive(false);

            EWorldEditor["ETransformSelectionDisplayed"] = false.AsString();
            }

        [ConsoleInteraction]
        public override void onVisible(bool state)
            {
            // If we are made visible, sync to the world editor
            // selection.

            if (state)
                this.onSelectionChanged();
            }

        [ConsoleInteraction]
        public void hideDialog()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            this.setVisible(false);
            EWorldEditor["ETransformSelectionDisplayed"] = false.AsString();
            }

        [ConsoleInteraction]
        public void ToggleVisibility()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            if (this.visible)
                {
                this.setVisible(false);
                EWorldEditor["ETransformSelectionDisplayed"] = false.AsString();
                }
            else
                {
                this.setVisible(true);
                this.selectWindow();
                this.setCollapseGroup(false);
                EWorldEditor["ETransformSelectionDisplayed"] = true.AsString();
                }
            }

        [ConsoleInteraction]
        public void disableAllButtons()
            {
            GuiButtonCtrl GetPosButton = this.FOT("GetPosButton");
            GuiButtonCtrl GetRotButton = this.FOT("GetRotButton");
            GuiButtonCtrl GetScaleButton = this.FOT("GetScaleButton");
            GuiButtonCtrl GetSizeButton = this.FOT("GetSizeButton");
            GuiButtonCtrl ApplyButton = this.FOT("ApplyButton");

            GetPosButton.setActive(false);
            GetRotButton.setActive(false);
            GetScaleButton.setActive(false);
            GetSizeButton.setActive(false);

            ApplyButton.setActive(false);
            }

        [ConsoleInteraction]
        public void onSelectionChanged()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            GuiCheckBoxCtrl RotRelative = this.FOT("RotRelative");
            GuiCheckBoxCtrl RotLocal = this.FOT("RotLocal");
            GuiButtonCtrl GetPosButton = this.FOT("GetPosButton");
            GuiButtonCtrl GetRotButton = this.FOT("GetRotButton");
            GuiButtonCtrl GetScaleButton = this.FOT("GetScaleButton");
            GuiButtonCtrl GetSizeButton = this.FOT("GetSizeButton");
            GuiButtonCtrl ApplyButton = this.FOT("ApplyButton");

            // Count the number of selected SceneObjects.  There are
            // other object classes that could be selected, such
            // as SimGroups.
            int count = EWorldEditor.getSelectionSize();
            int sceneObjects = 0;
            int globalBoundsObjects = 0;
            for (int i = 0; i < count; i++)
                {
                SimObject obj = EWorldEditor.getSelectedObject(i);
                if (obj.isMemberOfClass("SceneObject"))
                    {
                    sceneObjects++;

                    if (obj.call("isGlobalBounds").AsBool())
                        {
                        globalBoundsObjects++;
                        }
                    }
                }

            if (sceneObjects == 0)
                {
                // With nothing selected, disable all Get buttons
                this.disableAllButtons();
                }
            else if (sceneObjects == 1)
                {
                // With one selected, all Get buttons are active
                GetPosButton.setActive(true);
                GetRotButton.setActive(true);

                // Special case for Scale and Size for global bounds objects
                if (globalBoundsObjects == 1)
                    {
                    GetSizeButton.setActive(false);
                    GetScaleButton.setActive(false);
                    }
                else
                    {
                    GetSizeButton.setActive(true);
                    GetScaleButton.setActive(true);
                    }

                ApplyButton.setActive(true);
                }
            else
                {
                // With more than one selected, only the position button
                // is active
                GetPosButton.setActive(true);
                GetRotButton.setActive(false);
                GetScaleButton.setActive(false);
                GetSizeButton.setActive(false);

                ApplyButton.setActive(true);

                // If both RotRelative and RotLocal are unchecked, then go with RotLocal
                if (RotRelative.getValue().AsInt() == 0 && RotLocal.getValue().AsInt() == 0)
                    {
                    RotLocal.setStateOn(true);
                    }
                }
            }

        [ConsoleInteraction]
        public void apply()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            GuiCheckBoxCtrl DoPosition = this.FOT("DoPosition");
            GuiCheckBoxCtrl DoRotation = this.FOT("DoRotation");
            GuiCheckBoxCtrl DoScale = this.FOT("DoScale");
            GuiCheckBoxCtrl DoSize = this.FOT("DoSize");
            GuiCheckBoxCtrl PosRelative = this.FOT("PosRelative");
            GuiCheckBoxCtrl RotRelative = this.FOT("RotRelative");
            GuiCheckBoxCtrl RotLocal = this.FOT("RotLocal");
            GuiCheckBoxCtrl ScaleRelative = this.FOT("ScaleRelative");
            GuiCheckBoxCtrl ScaleLocal = this.FOT("ScaleLocal");
            GuiCheckBoxCtrl SizeRelative = this.FOT("SizeRelative");
            GuiCheckBoxCtrl SizeLocal = this.FOT("SizeLocal");
            GuiTextEditCtrl PosY = this.FOT("PosY");
            GuiTextEditCtrl PosX = this.FOT("PosX");
            GuiTextEditCtrl PosZ = this.FOT("PosZ");
            GuiTextEditCtrl ScaleX = this.FOT("ScaleX");
            GuiTextEditCtrl ScaleY = this.FOT("ScaleY");
            GuiTextEditCtrl ScaleZ = this.FOT("ScaleZ");
            GuiTextEditCtrl SizeX = this.FOT("SizeX");
            GuiTextEditCtrl SizeY = this.FOT("SizeY");
            GuiTextEditCtrl SizeZ = this.FOT("SizeZ");
            GuiTextEditCtrl Pitch = this.FOT("Pitch");
            GuiTextEditCtrl Bank = this.FOT("Bank");
            GuiTextEditCtrl Heading = this.FOT("Heading");
            GuiTabBookCtrl ScaleTabBook = this.FOT("ScaleTabBook");

            string position = DoPosition.getValue().AsString();
            string p = PosX.getValue() + ' ' + PosY.getValue() + ' ' + PosZ.getValue();
            string relativePos = PosRelative.getValue();

            string rotate = DoRotation.getValue();
            string r = Util.mDegToRad(Pitch.getValue().AsFloat()) + ' ' + Util.mDegToRad(Bank.getValue().AsFloat()) +
                       ' ' + Util.mDegToRad(Heading.getValue().AsFloat()).AsString();
            string relativeRot = RotRelative.getValue();
            string rotLocal = RotLocal.getValue();

            string scale, s, sRelative, sLocal, size;

            // We need to check which Tab page is active
            if (ScaleTabBook.getSelectedPage() == 0)
                {
                // Scale Page
                scale = DoScale.getValue();
                s = ScaleX.getValue() + ' ' + ScaleY.getValue() + ' ' + ScaleZ.getValue();
                sRelative = ScaleRelative.getValue();
                sLocal = ScaleLocal.getValue();

                size = false.AsString();
                }
            else
                {
                // Size Page
                size = DoSize.getValue();
                s = SizeX.getValue() + ' ' + SizeY.getValue() + ' ' + SizeZ.getValue();
                sRelative = SizeRelative.getValue();
                sLocal = SizeLocal.getValue();

                scale = false.AsString();
                }

            EWorldEditor.transformSelection(position.AsBool(), p.AsPoint3F(), relativePos.AsBool(), rotate.AsBool(), r.AsPoint3F(), relativeRot.AsBool(), rotLocal.AsBool(),
                (scale.AsBool() ? 1 : (size.AsBool() ? 2 : 0)), s.AsPoint3F(), sRelative.AsBool(), sLocal.AsBool());
            }

        [ConsoleInteraction]
        public void getAbsPosition()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            GuiCheckBoxCtrl DoPosition = this.FOT("DoPosition");
            GuiCheckBoxCtrl PosRelative = this.FOT("PosRelative");
            GuiTextEditCtrl PosY = this.FOT("PosY");
            GuiTextEditCtrl PosX = this.FOT("PosX");
            GuiTextEditCtrl PosZ = this.FOT("PosZ");

            string pos = EWorldEditor.getSelectionCentroid();
            PosX.setText(Util.getWord(pos, 0));
            PosY.setText(Util.getWord(pos, 1));
            PosZ.setText(Util.getWord(pos, 2));

            // Turn off relative as we're populating absolute values
            PosRelative.setValue("0");

            // Finally, set the Position check box as active.  The user
            // likely wants this if they're getting the position.
            DoPosition.setValue("1");
            }

        [ConsoleInteraction]
        public void getAbsRotation()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            GuiCheckBoxCtrl DoRotation = this.FOT("DoRotation");
            GuiCheckBoxCtrl RotRelative = this.FOT("RotRelative");
            GuiCheckBoxCtrl RotLocal = this.FOT("RotLocal");
            GuiTextEditCtrl Bank = this.FOT("Bank");
            GuiTextEditCtrl Pitch = this.FOT("Pitch");
            GuiTextEditCtrl Heading = this.FOT("Heading");

            int count = EWorldEditor.getSelectionSize();

            // If we have more than one SceneObject selected,
            // we must exit.
            SimObject obj = -1;
            for (int i = 0; i < count; i++)
                {
                SimObject test = EWorldEditor.getSelectedObject(i);
                if (test.isMemberOfClass("SceneObject"))
                    {
                    if (obj != -1)
                        return;

                    obj = test;
                    }
                }

            if (obj == -1)
                {
                // No SceneObjects selected
                return;
                }

            string rot = obj.call("getEulerRotation");
            Pitch.setText(Util.getWord(rot, 0));
            Bank.setText(Util.getWord(rot, 1));
            Heading.setText(Util.getWord(rot, 2));

            // Turn off relative as we're populating absolute values.
            // Of course this means that we need to set local on.
            RotRelative.setValue("0");
            RotLocal.setValue("1");

            // Finally, set the Rotation check box as active.  The user
            // likely wants this if they're getting the position.
            DoRotation.setValue("1");
            }

        [ConsoleInteraction]
        public void getAbsScale()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            GuiCheckBoxCtrl ETransformSelectionScaleProportional = "ETransformSelectionScaleProportional";

            GuiCheckBoxCtrl DoScale = this.FOT("DoScale");
            GuiCheckBoxCtrl ScaleRelative = this.FOT("ScaleRelative");
            GuiTextEditCtrl ScaleX = this.FOT("ScaleX");
            GuiTextEditCtrl ScaleY = this.FOT("ScaleY");
            GuiTextEditCtrl ScaleZ = this.FOT("ScaleZ");

            int count = EWorldEditor.getSelectionSize();

            // If we have more than one SceneObject selected,
            // we must exit.
            SimObject obj = -1;
            for (int i = 0; i < count; i++)
                {
                SimObject test = EWorldEditor.getSelectedObject(i);
                if (test.isMemberOfClass("SceneObject"))
                    {
                    if (obj != -1)
                        return;

                    obj = test;
                    }
                }

            if (obj == -1)
                {
                // No SceneObjects selected
                return;
                }

            string scale = obj["scale"];
            string scalex = Util.getWord(scale, 0);
            ScaleX.setText(scalex);
            if (!ETransformSelectionScaleProportional.getValue().AsBool())
                {
                ScaleY.setText(Util.getWord(scale, 1));
                ScaleZ.setText(Util.getWord(scale, 2));
                }
            else
                {
                ScaleY.setText(scalex);
                ScaleZ.setText(scalex);
                }

            // Turn off relative as we're populating absolute values
            ScaleRelative.setValue("0");

            // Finally, set the Scale check box as active.  The user
            // likely wants this if they're getting the position.
            DoScale.setValue("1");
            }

        [ConsoleInteraction]
        public void getAbsSize()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";
            GuiCheckBoxCtrl ETransformSelectionSizeProportional = "ETransformSelectionSizeProportional";

            GuiCheckBoxCtrl DoSize = this.FOT("DoSize");
            GuiCheckBoxCtrl SizeRelative = this.FOT("SizeRelative");
            GuiTextEditCtrl SizeX = this.FOT("SizeX");
            GuiTextEditCtrl SizeY = this.FOT("SizeY");
            GuiTextEditCtrl SizeZ = this.FOT("SizeZ");

            int count = EWorldEditor.getSelectionSize();

            // If we have more than one SceneObject selected,
            // we must exit.
            SimObject obj = -1;
            for (int i = 0; i < count; i++)
                {
                SimObject test = EWorldEditor.getSelectedObject(i);
                if (test.isMemberOfClass("SceneObject"))
                    {
                    if (obj != -1)
                        return;

                    obj = test;
                    }
                }

            if (obj == -1)
                {
                // No SceneObjects selected
                return;
                }

            string size = obj.call("getObjectBox");
            string scale = obj.call("getScale");

            string sizex =
                ((Util.getWord(size, 3).AsFloat() - Util.getWord(size, 0).AsFloat())*Util.getWord(scale, 0).AsFloat())
                    .AsString();
            SizeX.setText(sizex);
            if (!ETransformSelectionSizeProportional.getValue().AsBool())
                {
                SizeY.setText(
                    ((Util.getWord(size, 4).AsFloat() - Util.getWord(size, 1).AsFloat())*
                     Util.getWord(scale, 1).AsFloat()).AsString());
                SizeZ.setText(
                    ((Util.getWord(size, 5).AsFloat() - Util.getWord(size, 2).AsFloat())*
                     Util.getWord(scale, 2).AsFloat()).AsString());
                }
            else
                {
                SizeY.setText(sizex);
                SizeZ.setText(sizex);
                }

            // Turn off relative as we're populating absolute values
            SizeRelative.setValue("0");

            // Finally, set the Size check box as active.  The user
            // likely wants this if they're getting the position.
            DoSize.setValue("1");
            }

        [ConsoleInteraction]
        public void RotRelativeChanged()
            {
            GuiCheckBoxCtrl RotRelative = this.FOT("RotRelative");
            GuiCheckBoxCtrl RotLocal = this.FOT("RotLocal");

            if (RotRelative.getValue().AsInt() == 0)
                {
                // With absolute rotation, it must happen locally
                RotLocal.setStateOn(true);
                }
            }

        [ConsoleInteraction]
        public void RotLocalChanged()
            {
            GuiCheckBoxCtrl RotRelative = this.FOT("RotRelative");
            GuiCheckBoxCtrl RotLocal = this.FOT("RotLocal");

            if (RotLocal.getValue().AsInt() == 0)
                {
                // Non-local rotation can only happen relatively
                RotRelative.setStateOn(true);
                }
            }

        //-----------------------------------------------------------------------------

        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<ETransformSelectionButtonClass>))]
        public class ETransformSelectionButtonClass : GuiButtonCtrl
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                ETransformSelection ETransformSelection = "ETransformSelection";

                GuiControl id = ((GuiControl) this.getRoot()).getFirstResponder();
                if (id > -1 && ETransformSelection.controlIsChild(id))
                    {
                    id.clearFirstResponder(true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ETransformSelectionButtonClass ts, string simobjectid)
                {
                return ReferenceEquals(ts, null)
                    ? ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ETransformSelectionButtonClass ts, string simobjectid)
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
            public static implicit operator string(ETransformSelectionButtonClass ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionButtonClass(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ETransformSelectionButtonClass)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionButtonClass));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ETransformSelectionButtonClass ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionButtonClass(int simobjectid)
                {
                return
                    (ETransformSelectionButtonClass)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ETransformSelectionButtonClass));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ETransformSelectionButtonClass ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ETransformSelectionButtonClass(uint simobjectid)
                {
                return
                    (ETransformSelectionButtonClass)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionButtonClass));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ETransformSelectionCheckBoxClass>))]
        public class ETransformSelectionCheckBoxClass : GuiCheckBoxCtrl
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                ETransformSelection ETransformSelection = "ETransformSelection";

                GuiControl id = ((GuiControl) this.getRoot()).getFirstResponder();
                if (id > -1 && ETransformSelection.controlIsChild(id))
                    {
                    id.clearFirstResponder(true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ETransformSelectionCheckBoxClass ts, string simobjectid)
                {
                return ReferenceEquals(ts, null)
                    ? ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ETransformSelectionCheckBoxClass ts, string simobjectid)
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
            public static implicit operator string(ETransformSelectionCheckBoxClass ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionCheckBoxClass(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ETransformSelectionCheckBoxClass)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionCheckBoxClass));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ETransformSelectionCheckBoxClass ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionCheckBoxClass(int simobjectid)
                {
                return
                    (ETransformSelectionCheckBoxClass)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ETransformSelectionCheckBoxClass));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ETransformSelectionCheckBoxClass ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ETransformSelectionCheckBoxClass(uint simobjectid)
                {
                return
                    (ETransformSelectionCheckBoxClass)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionCheckBoxClass));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ETransformSelectionScaleProportional>))]
        public class ETransformSelectionScaleProportional : ETransformSelectionCheckBoxClass
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                ETransformSelection ETransformSelection = "ETransformSelection";

                GuiTextEditCtrl ScaleX = ETransformSelection.FOT("ScaleX");
                GuiTextEditCtrl ScaleY = ETransformSelection.FOT("ScaleY");
                GuiTextEditCtrl ScaleZ = ETransformSelection.FOT("ScaleZ");

                if (this.getValue().AsInt() == 1)
                    {
                    string scalex = ScaleX.getValue();
                    ScaleY.setValue(scalex);
                    ScaleZ.setValue(scalex);

                    ScaleY.setActive(false);
                    ScaleZ.setActive(false);
                    }
                else
                    {
                    ScaleY.setActive(true);
                    ScaleZ.setActive(true);
                    }

                base.onClick(SelectedidString);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ETransformSelectionScaleProportional ts, string simobjectid)
                {
                return ReferenceEquals(ts, null)
                    ? ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ETransformSelectionScaleProportional ts, string simobjectid)
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
            public static implicit operator string(ETransformSelectionScaleProportional ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionScaleProportional(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ETransformSelectionScaleProportional)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionScaleProportional));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ETransformSelectionScaleProportional ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionScaleProportional(int simobjectid)
                {
                return
                    (ETransformSelectionScaleProportional)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ETransformSelectionScaleProportional));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ETransformSelectionScaleProportional ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ETransformSelectionScaleProportional(uint simobjectid)
                {
                return
                    (ETransformSelectionScaleProportional)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionScaleProportional));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ETransformSelectionSizeProportional>))]
        public class ETransformSelectionSizeProportional : ETransformSelectionCheckBoxClass
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                ETransformSelection ETransformSelection = "ETransformSelection";

                GuiTextEditCtrl SizeX = ETransformSelection.FOT("SizeX");
                GuiTextEditCtrl SizeY = ETransformSelection.FOT("SizeY");
                GuiTextEditCtrl SizeZ = ETransformSelection.FOT("SizeZ");

                if (this.getValue().AsInt() == 1)
                    {
                    string scalex = SizeX.getValue();
                    SizeY.setValue(scalex);
                    SizeZ.setValue(scalex);

                    SizeY.setActive(false);
                    SizeZ.setActive(false);
                    }
                else
                    {
                    SizeY.setActive(true);
                    SizeZ.setActive(true);
                    }

                base.onClick(SelectedidString);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ETransformSelectionSizeProportional ts, string simobjectid)
                {
                return ReferenceEquals(ts, null)
                    ? ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ETransformSelectionSizeProportional ts, string simobjectid)
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
            public static implicit operator string(ETransformSelectionSizeProportional ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionSizeProportional(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ETransformSelectionSizeProportional)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionSizeProportional));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ETransformSelectionSizeProportional ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionSizeProportional(int simobjectid)
                {
                return
                    (ETransformSelectionSizeProportional)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ETransformSelectionSizeProportional));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ETransformSelectionSizeProportional ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ETransformSelectionSizeProportional(uint simobjectid)
                {
                return
                    (ETransformSelectionSizeProportional)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionSizeProportional));
                }

            #endregion
            }


        //-----------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<ETransformSelectionTextEdit>))]
        public class ETransformSelectionTextEdit : GuiTextEditCtrl
            {
            [ConsoleInteraction]
            public override void onGainFirstResponder(string ID)
                {
                if (this.isActive())
                    {
                    this.selectAllText();
                    }
                }

            [ConsoleInteraction]
            public override void onValidate()
                {
                ETransformSelectionScaleProportional ETransformSelectionScaleProportional =
                    "ETransformSelectionScaleProportional";
                ETransformSelectionSizeProportional ETransformSelectionSizeProportional =
                    "ETransformSelectionSizeProportional";
                ETransformSelection ETransformSelection = "ETransformSelection";

                GuiTextEditCtrl ScaleX = ETransformSelection.FOT("ScaleX");
                GuiTextEditCtrl ScaleY = ETransformSelection.FOT("ScaleY");
                GuiTextEditCtrl ScaleZ = ETransformSelection.FOT("ScaleZ");
                GuiTextEditCtrl SizeX = ETransformSelection.FOT("SizeX");
                GuiTextEditCtrl SizeY = ETransformSelection.FOT("SizeY");
                GuiTextEditCtrl SizeZ = ETransformSelection.FOT("SizeZ");

                if (this.getInternalName() == "ScaleX" && ETransformSelectionScaleProportional.getValue().AsBool())
                    {
                    // Set the Y and Z values to match
                    string scalex = ScaleX.getValue();
                    ScaleY.setValue(scalex);
                    ScaleZ.setValue(scalex);
                    }

                if (this.getInternalName() == "SizeX" && ETransformSelectionSizeProportional.getValue().AsBool())
                    {
                    // Set the Y and Z values to match
                    string sizex = SizeX.getValue();
                    SizeY.setValue(sizex);
                    SizeZ.setValue(sizex);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ETransformSelectionTextEdit ts, string simobjectid)
                {
                return ReferenceEquals(ts, null)
                    ? ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(ETransformSelectionTextEdit ts, string simobjectid)
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
            public static implicit operator string(ETransformSelectionTextEdit ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionTextEdit(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ETransformSelectionTextEdit)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionTextEdit));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ETransformSelectionTextEdit ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ETransformSelectionTextEdit(int simobjectid)
                {
                return
                    (ETransformSelectionTextEdit)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ETransformSelectionTextEdit));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ETransformSelectionTextEdit ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ETransformSelectionTextEdit(uint simobjectid)
                {
                return
                    (ETransformSelectionTextEdit)
                        Omni.self.getSimObject(simobjectid, typeof (ETransformSelectionTextEdit));
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
        public static bool operator ==(ETransformSelection ts, string simobjectid)
            {
            return ReferenceEquals(ts, null)
                ? ReferenceEquals(simobjectid, null)
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
        public static bool operator !=(ETransformSelection ts, string simobjectid)
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
        public static implicit operator string(ETransformSelection ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ETransformSelection(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ETransformSelection) Omni.self.getSimObject(simobjectid, typeof (ETransformSelection));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ETransformSelection ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ETransformSelection(int simobjectid)
            {
            return (ETransformSelection) Omni.self.getSimObject((uint) simobjectid, typeof (ETransformSelection));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ETransformSelection ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ETransformSelection(uint simobjectid)
            {
            return (ETransformSelection) Omni.self.getSimObject(simobjectid, typeof (ETransformSelection));
            }

        #endregion
        }
    }