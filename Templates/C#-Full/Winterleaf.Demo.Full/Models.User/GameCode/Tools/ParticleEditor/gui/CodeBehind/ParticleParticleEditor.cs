using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind
    {
    public class ParticleParticleEditor
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true, "ParticleParticleEditor_intialize")]
        public static void initialize()
            {
            omni.sGlobal["$PE_PARTICLEEDITOR_DEFAULT_FILENAME"] = "art/particles/managedParticleData.cs";
            }

        //=============================================================================================
        //    PE_ParticleEditor.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------


        //=============================================================================================
        //    PEP_NewParticleButton.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<PEP_NewParticleButton>))]
        public class PEP_NewParticleButton : GuiBitmapButtonCtrl
            {
            [ConsoleInteraction]
            public override void onDefaultClick()
                {
                PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                PE_ParticleEditor.showNewDialog("");
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void onCtrlClick()
                {
                PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";

                int replaceSlot = 0;

                for (int i = 1; i < 5; i ++)
                    {
                    GuiPopUpMenuCtrl popup = "PEE_EmitterParticleSelector" + i;
                    if (popup.getSelected() == PEP_ParticleSelector.getSelected())
                        {
                        replaceSlot = i;
                        break;
                        }
                    }

                PE_ParticleEditor.showNewDialog(replaceSlot.AsString());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PEP_NewParticleButton ts, string simobjectid)
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
            public static bool operator !=(PEP_NewParticleButton ts, string simobjectid)
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
            public static implicit operator string(PEP_NewParticleButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PEP_NewParticleButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (PEP_NewParticleButton) Omni.self.getSimObject(simobjectid, typeof (PEP_NewParticleButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PEP_NewParticleButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PEP_NewParticleButton(int simobjectid)
                {
                return
                    (PEP_NewParticleButton) Omni.self.getSimObject((uint) simobjectid, typeof (PEP_NewParticleButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PEP_NewParticleButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PEP_NewParticleButton(uint simobjectid)
                {
                return (PEP_NewParticleButton) Omni.self.getSimObject(simobjectid, typeof (PEP_NewParticleButton));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<PEP_ParticleSelector_Control>))]
        public class PEP_ParticleSelector_Control : QuickEditDropDownTextEditCtrl
            {
            [ConsoleInteraction]
            public override void onRenameItem()
                {
                PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                GuiPopUpMenuCtrl PopupMenu = this.FOT("PopupMenu");

                base.onRenameItem();

                //FIXME: need to check for validity of name and name clashes

                PE_ParticleEditor.setParticleDirty();

                // Resort menu.

                PopupMenu.sort();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PEP_ParticleSelector_Control ts, string simobjectid)
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
            public static bool operator !=(PEP_ParticleSelector_Control ts, string simobjectid)
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
            public static implicit operator string(PEP_ParticleSelector_Control ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PEP_ParticleSelector_Control(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (PEP_ParticleSelector_Control)
                        Omni.self.getSimObject(simobjectid, typeof (PEP_ParticleSelector_Control));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PEP_ParticleSelector_Control ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PEP_ParticleSelector_Control(int simobjectid)
                {
                return
                    (PEP_ParticleSelector_Control)
                        Omni.self.getSimObject((uint) simobjectid, typeof (PEP_ParticleSelector_Control));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PEP_ParticleSelector_Control ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PEP_ParticleSelector_Control(uint simobjectid)
                {
                return
                    (PEP_ParticleSelector_Control)
                        Omni.self.getSimObject(simobjectid, typeof (PEP_ParticleSelector_Control));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<PE_ColorTintSwatch>))]
        public class PE_ColorTintSwatch : GuiSwatchButtonCtrl
            {
            [ConsoleInteraction]
            public void updateParticleColor(string color)
                {
                PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                string arrayNum = this["arrayNum"];

                string r = Util.getWord(color, 0);
                string g = Util.getWord(color, 1);
                string b = Util.getWord(color, 2);
                string a = Util.getWord(color, 3);

                color = r + ' ' + g + ' ' + b + ' ' + a;
                this["color"] = color;

                PE_ParticleEditor.updateParticle("colors[" + arrayNum + "]", color, false, false);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PE_ColorTintSwatch ts, string simobjectid)
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
            public static bool operator !=(PE_ColorTintSwatch ts, string simobjectid)
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
            public static implicit operator string(PE_ColorTintSwatch ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PE_ColorTintSwatch(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (PE_ColorTintSwatch) Omni.self.getSimObject(simobjectid, typeof (PE_ColorTintSwatch));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PE_ColorTintSwatch ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PE_ColorTintSwatch(int simobjectid)
                {
                return (PE_ColorTintSwatch) Omni.self.getSimObject((uint) simobjectid, typeof (PE_ColorTintSwatch));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PE_ColorTintSwatch ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PE_ColorTintSwatch(uint simobjectid)
                {
                return (PE_ColorTintSwatch) Omni.self.getSimObject(simobjectid, typeof (PE_ColorTintSwatch));
                }

            #endregion
            }

        [TypeConverter(typeof (PE_ParticleEditor))]
        public class PE_ParticleEditor : GuiTabPageCtrl
            {
            public SimObject currParticle
                {
                get { return this["currParticle"]; }
                set { this["currParticle"] = value; }
                }

            public bool dirty
                {
                get { return this["dirty"].AsBool(); }
                set { this["dirty"] = value.AsString(); }
                }

            [ConsoleInteraction]
            public void guiSync()
                {
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";
                MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";
                GuiSwatchButtonCtrl PE_ColorTintSwatch0 = "PE_ColorTintSwatch0";
                GuiSwatchButtonCtrl PE_ColorTintSwatch1 = "PE_ColorTintSwatch1";
                GuiSwatchButtonCtrl PE_ColorTintSwatch2 = "PE_ColorTintSwatch2";
                GuiSwatchButtonCtrl PE_ColorTintSwatch3 = "PE_ColorTintSwatch3";

                GuiBitmapButtonCtrl PEP_previewImage = this.FOT("PEP_previewImage");
                GuiTextEditCtrl PEP_previewImageName = this.FOT("PEP_previewImageName");
                GuiTextEditCtrl PEP_lifetimeMS_textEdit = this.FOT("PEP_lifetimeMS_textEdit");
                GuiTextEditCtrl PEP_lifetimeVarianceMS_textEdit = this.FOT("PEP_lifetimeVarianceMS_textEdit");
                GuiTextEditCtrl PEP_inheritedVelFactor_textEdit = this.FOT("PEP_inheritedVelFactor_textEdit");
                GuiTextEditCtrl PEP_constantAcceleration_textEdit = this.FOT("PEP_constantAcceleration_textEdit");
                GuiTextEditCtrl PEP_gravityCoefficient_textEdit = this.FOT("PEP_gravityCoefficient_textEdit");
                GuiTextEditCtrl PEP_dragCoefficient_textEdit = this.FOT("PEP_dragCoefficient_textEdit");
                GuiTextEditCtrl PEP_spinRandomMin_textEdit = this.FOT("PEP_spinRandomMin_textEdit");
                GuiTextEditCtrl PEP_spinRandomMax_textEdit = this.FOT("PEP_spinRandomMax_textEdit");
                GuiTextEditCtrl PEP_spinSpeed_textEdit = this.FOT("PEP_spinSpeed_textEdit");
                GuiTextEditCtrl PEP_pointSize_textEdit0 = this.FOT("PEP_pointSize_textEdit0");
                GuiTextEditCtrl PEP_pointSize_textEdit1 = this.FOT("PEP_pointSize_textEdit1");
                GuiTextEditCtrl PEP_pointSize_textEdit2 = this.FOT("PEP_pointSize_textEdit2");
                GuiTextEditCtrl PEP_pointSize_textEdit3 = this.FOT("PEP_pointSize_textEdit3");
                GuiTextEditCtrl PEP_pointTime_textEdit0 = this.FOT("PEP_pointTime_textEdit0");
                GuiTextEditCtrl PEP_pointTime_textEdit1 = this.FOT("PEP_pointTime_textEdit1");
                GuiTextEditCtrl PEP_pointTime_textEdit2 = this.FOT("PEP_pointTime_textEdit2");
                GuiTextEditCtrl PEP_pointTime_textEdit3 = this.FOT("PEP_pointTime_textEdit3");
                GuiCheckBoxCtrl PEP_inverseAlpha = this.FOT("PEP_inverseAlpha");
                GuiSliderCtrl PEP_lifetimeMS_slider = this.FOT("PEP_lifetimeMS_slider");
                GuiSliderCtrl PEP_lifetimeVarianceMS_slider = this.FOT("PEP_lifetimeVarianceMS_slider");
                GuiSliderCtrl PEP_inheritedVelFactor_slider = this.FOT("PEP_inheritedVelFactor_slider");
                GuiSliderCtrl PEP_constantAcceleration_slider = this.FOT("PEP_constantAcceleration_slider");
                GuiSliderCtrl PEP_gravityCoefficient_slider = this.FOT("PEP_gravityCoefficient_slider");
                GuiSliderCtrl PEP_dragCoefficient_slider = this.FOT("PEP_dragCoefficient_slider");
                GuiSliderCtrl PEP_spinRandomMin_slider = this.FOT("PEP_spinRandomMin_slider");
                GuiSliderCtrl PEP_spinRandomMax_slider = this.FOT("PEP_spinRandomMax_slider");
                GuiSliderCtrl PEP_spinSpeed_slider = this.FOT("PEP_spinSpeed_slider");
                GuiSliderCtrl PEP_pointSize_slider0 = this.FOT("PEP_pointSize_slider0");
                GuiSliderCtrl PEP_pointSize_slider1 = this.FOT("PEP_pointSize_slider1");
                GuiSliderCtrl PEP_pointSize_slider2 = this.FOT("PEP_pointSize_slider2");
                GuiSliderCtrl PEP_pointSize_slider3 = this.FOT("PEP_pointSize_slider3");
                GuiSliderCtrl PEP_pointTime_slider0 = this.FOT("PEP_pointTime_slider0");
                GuiSliderCtrl PEP_pointTime_slider1 = this.FOT("PEP_pointTime_slider1");
                GuiSliderCtrl PEP_pointTime_slider2 = this.FOT("PEP_pointTime_slider2");
                GuiSliderCtrl PEP_pointTime_slider3 = this.FOT("PEP_pointTime_slider3");

                // Populate the selector with the particles assigned
                // to the current emitter.

                bool containsCurrParticle = false;
                GuiPopUpMenuCtrl popup = PEP_ParticleSelector;
                popup.clear();

                foreach (SimObject particle in PE_EmitterEditor.currEmitter["particles"].Split(' '))
                    {
                    if (particle.getId() == this.currParticle)
                        containsCurrParticle = true;

                    popup.add(particle.getName(), particle.getId());
                    }

                // Just in case the particle doesn't exist, fallback gracefully

                if (!containsCurrParticle)
                    this.currParticle = Util.getWord(PE_EmitterEditor.currEmitter["particles"], 0).getID();

                SimObject data = this.currParticle;

                popup.sort();
                popup.setSelected(data);

                string bitmap = MaterialEditorGui.searchForTexture(data.getName(), data["textureName"]);


                if (bitmap != "")
                    {
                    PEP_previewImage.setBitmap(bitmap);
                    PEP_previewImageName.setText(bitmap);
                    PEP_previewImageName.tooltip = bitmap;
                    }
                else
                    {
                    PEP_previewImage.setBitmap("");
                    PEP_previewImageName.setText("None");
                    PEP_previewImageName.tooltip = "None";
                    }

                PEP_inverseAlpha.setValue(data["useInvAlpha"]);

                PEP_lifetimeMS_slider.setValue(data["lifetimeMS"]);
                PEP_lifetimeMS_textEdit.setText(data["lifetimeMS"]);

                PEP_lifetimeVarianceMS_slider.setValue(data["lifetimeVarianceMS"]);
                PEP_lifetimeVarianceMS_textEdit.setText(data["lifetimeVarianceMS"]);

                PEP_inheritedVelFactor_slider.setValue(data["inheritedVelFactor"]);
                PEP_inheritedVelFactor_textEdit.setText(data["inheritedVelFactor"]);

                PEP_constantAcceleration_slider.setValue(data["constantAcceleration"]);
                PEP_constantAcceleration_textEdit.setText(data["constantAcceleration"]);

                PEP_gravityCoefficient_slider.setValue(data["gravityCoefficient"]);
                PEP_gravityCoefficient_textEdit.setText(data["gravityCoefficient"]);

                PEP_dragCoefficient_slider.setValue(data["dragCoefficient"]);
                PEP_dragCoefficient_textEdit.setText(data["dragCoefficient"]);

                PEP_spinRandomMin_slider.setValue(data["spinRandomMin"]);
                PEP_spinRandomMin_textEdit.setText(data["spinRandomMin"]);

                PEP_spinRandomMax_slider.setValue(data["spinRandomMax"]);
                PEP_spinRandomMax_textEdit.setText(data["spinRandomMax"]);

                PEP_spinRandomMax_slider.setValue(data["spinRandomMax"]);
                PEP_spinRandomMax_textEdit.setText(data["spinRandomMax"]);

                PEP_spinSpeed_slider.setValue(data["spinSpeed"]);
                PEP_spinSpeed_textEdit.setText(data["spinSpeed"]);

                PE_ColorTintSwatch0["color"] = data["colors[0]"];
                PE_ColorTintSwatch1["color"] = data["colors[1]"];
                PE_ColorTintSwatch2["color"] = data["colors[2]"];
                PE_ColorTintSwatch3["color"] = data["colors[3]"];

                PEP_pointSize_slider0.setValue(data["sizes[0]"]);
                PEP_pointSize_textEdit0.setText(data["sizes[0]"]);

                PEP_pointSize_slider1.setValue(data["sizes[1]"]);
                PEP_pointSize_textEdit1.setText(data["sizes[1]"]);

                PEP_pointSize_slider2.setValue(data["sizes[2]"]);
                PEP_pointSize_textEdit2.setText(data["sizes[2]"]);

                PEP_pointSize_slider3.setValue(data["sizes[3]"]);
                PEP_pointSize_textEdit3.setText(data["sizes[3]"]);

                PEP_pointTime_slider0.setValue(data["times[0]"]);
                PEP_pointTime_textEdit0.setText(data["times[0]"]);

                PEP_pointTime_slider1.setValue(data["times[1]"]);
                PEP_pointTime_textEdit1.setText(data["times[1]"]);

                PEP_pointTime_slider2.setValue(data["times[2]"]);
                PEP_pointTime_textEdit2.setText(data["times[2]"]);

                PEP_pointTime_slider3.setValue(data["times[3]"]);
                PEP_pointTime_textEdit3.setText(data["times[3]"]);
                }

            //---------------------------------------------------------------------------------------------

            // Generic updateParticle method
            [ConsoleInteraction]
            public void updateParticle(string propertyField, string value, bool isSlider, bool onMouseUp)
                {
                editor Editor = "Editor";
                ParticleEditor ParticleEditor = "ParticleEditor";

                this.setParticleDirty();
                SimObject particle = this.currParticle;

                SimObject last =
                    Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["field"] = propertyField;
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValue"] = value;
                    }
                else
                    {
                    var action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveParticle>("Update Active Particle");
                    action["particle"] = particle;
                    action["field"] = propertyField;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();
                    action["newValue"] = value;
                    action["oldValue"] = particle.getFieldValue(propertyField, -1);

                    ParticleEditor.submitUndo(action);
                    }

                particle.setFieldValue(propertyField, value, -1);
                particle.call("reload");
                }

            //---------------------------------------------------------------------------------------------

            // Special case updateEmitter methods
            [ConsoleInteraction]
            public void updateParticleTexture(bool action)
                {
                MaterialEditor.gui.CodeBehind.MaterialEditor.MaterialEditorGui MaterialEditorGui = "MaterialEditorGui";

                GuiBitmapButtonCtrl PEP_previewImage = this.FOT("PEP_previewImage");
                GuiTextEditCtrl PEP_previewImageName = this.FOT("PEP_previewImageName");


                if (action)
                    {
                    string texture = MaterialEditorGui.openFile("texture");
                    if (texture != "")
                        {
                        PEP_previewImage.setBitmap(texture);
                        PEP_previewImageName.setText(texture);
                        PEP_previewImageName.tooltip = texture;

                        this.updateParticle("textureName", texture, false, false);
                        }
                    }
                else
                    {
                    PEP_previewImage.setBitmap("");
                    PEP_previewImageName.setText("");
                    PEP_previewImageName.tooltip = "";

                    this.updateParticle("textureName", "", false, false);
                    }
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void updateLifeFields(bool isRandom, float value, bool isSlider, bool onMouseUp)
                {
                editor Editor = "Editor";
                ParticleEditor ParticleEditor = "ParticleEditor";

                GuiTextEditCtrl PEP_lifetimeMS_textEdit = this.FOT("PEP_lifetimeMS_textEdit");
                GuiTextEditCtrl PEP_lifetimeVarianceMS_textEdit = this.FOT("PEP_lifetimeVarianceMS_textEdit");
                GuiSliderCtrl PEP_lifetimeMS_slider = this.FOT("PEP_lifetimeMS_slider");
                GuiSliderCtrl PEP_lifetimeVarianceMS_slider = this.FOT("PEP_lifetimeVarianceMS_slider");

                this.setParticleDirty();
                SimObject particle = this.currParticle;

                //Transfer values over to gui controls.

                if (isRandom)
                    {
                    value ++;
                    if (value > PEP_lifetimeMS_slider.getValue())
                        {
                        PEP_lifetimeMS_textEdit.setText(value.AsString());
                        PEP_lifetimeMS_slider.setValue(value.AsString());
                        }
                    }
                else
                    {
                    value --;
                    if (value < PEP_lifetimeVarianceMS_slider.getValue())
                        {
                        PEP_lifetimeVarianceMS_textEdit.setText(value.AsString());
                        PEP_lifetimeVarianceMS_slider.setValue(value.AsString());
                        }
                    }

                // Submit undo.
                SimObject last =
                    Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValueLifetimeMS"] = PEP_lifetimeMS_textEdit.getText();
                    last["newValueLifetimeVarianceMS"] = PEP_lifetimeVarianceMS_textEdit.getText();
                    }
                else
                    {
                    var action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveParticleLifeFields>("Update Active Particle");
                    action["particle"] = particle;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();
                    action["newValueLifetimeMS"] = PEP_lifetimeMS_textEdit.getText();
                    action["oldValueLifetimeMS"] = particle["lifetimeMS"];

                    action["newValueLifetimeVarianceMS"] = PEP_lifetimeVarianceMS_textEdit.getText();
                    action["oldValueLifetimeVarianceMS"] = particle["lifetimeVarianceMS"];

                    ParticleEditor.submitUndo(action);
                    }

                particle["lifetimeMS"] = PEP_lifetimeMS_textEdit.getText();
                particle["lifetimeVarianceMS"] = PEP_lifetimeVarianceMS_textEdit.getText();
                particle.call("reload");
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void updateSpinFields(bool isMax, float value, bool isSlider, bool onMouseUp)
                {
                editor Editor = "Editor";
                ParticleEditor ParticleEditor = "ParticleEditor";

                GuiTextEditCtrl PEP_spinRandomMin_textEdit = this.FOT("PEP_spinRandomMin_textEdit");
                GuiTextEditCtrl PEP_spinRandomMax_textEdit = this.FOT("PEP_spinRandomMax_textEdit");
                GuiSliderCtrl PEP_spinRandomMin_slider = this.FOT("PEP_spinRandomMin_slider");
                GuiSliderCtrl PEP_spinRandomMax_slider = this.FOT("PEP_spinRandomMax_slider");

                this.setParticleDirty();
                SimObject particle = this.currParticle;

                // Transfer values over to gui controls.
                if (isMax)
                    {
                    value ++;
                    if (value > PEP_spinRandomMax_slider.getValue())
                        {
                        PEP_spinRandomMax_textEdit.setText(value.AsString());
                        PEP_spinRandomMax_slider.setValue(value.AsString());
                        }
                    }
                else
                    {
                    value --;
                    if (value < PEP_spinRandomMin_slider.getValue())
                        {
                        PEP_spinRandomMin_textEdit.setText(value.AsString());
                        PEP_spinRandomMin_slider.setValue(value.AsString());
                        }
                    }

                // Submit undo.
                SimObject last =
                    Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValueSpinRandomMax"] = PEP_spinRandomMax_textEdit.getText();
                    last["newValueSpinRandomMin"] = PEP_spinRandomMin_textEdit.getText();
                    }
                else
                    {
                    var action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveParticleSpinFields>("Update Active Particle");
                    action["particle"] = particle;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();
                    action["newValueSpinRandomMax"] = PEP_spinRandomMax_textEdit.getText();
                    action["oldValueSpinRandomMax"] = particle["spinRandomMax"];

                    action["newValueSpinRandomMin"] = PEP_spinRandomMin_textEdit.getText();
                    action["oldValueSpinRandomMin"] = particle["spinRandomMin"];

                    ParticleEditor.submitUndo(action);
                    }

                particle["spinRandomMax"] = PEP_spinRandomMax_textEdit.getText();
                particle["spinRandomMin"] = PEP_spinRandomMin_textEdit.getText();
                particle.call("reload");
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void onNewParticle()
                {
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";

                // Bail if the user selected the same particle.

                SimObject id = PEP_ParticleSelector.getSelected();
                if (id == this.currParticle)
                    return;

                // Load new particle if we're not in a dirty state
                if (this.dirty)
                    {
                    messageBox.MessageBoxYesNoCancel("Save Existing Particle?",
                        "Do you want to save changes to <br><br>" + this.currParticle.getName(),
                        "PE_ParticleEditor.saveParticle(" + this.currParticle + ");",
                        "PE_ParticleEditor.saveParticleDialogDontSave(" + this.currParticle +
                        "); PE_ParticleEditor.loadNewParticle();"
                        );
                    }
                else
                    {
                    this.loadNewParticle("");
                    }
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void loadNewParticle(SimObject particle)
                {
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleData PE_ParticleEditor_NotDirtyParticle = "PE_ParticleEditor_NotDirtyParticle";

                if (particle.isObject())
                    particle = particle.getId().AsString();
                else
                    particle = PEP_ParticleSelector.getSelected().AsString();

                this.currParticle = particle;

                particle.call("reload");

                PE_ParticleEditor_NotDirtyParticle.assignFieldsFrom(particle);
                PE_ParticleEditor_NotDirtyParticle["originalName"] = particle.getName();

                this.guiSync();
                this.setParticleNotDirty();
                }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void setParticleDirty()
                {
                PersistenceManager PE_ParticleSaver = "PE_ParticleSaver";
                this["text"] = "Particle *";
                this.dirty = true;

                SimObject particle = this.currParticle;

                if (particle.getFilename() == "" ||
                    particle.getFilename() == "tools/particleEditor/particleParticleEditor.ed.cs")
                    PE_ParticleSaver.setDirty(particle, sGlobal["$PE_PARTICLEEDITOR_DEFAULT_FILENAME"]);
                else
                    PE_ParticleSaver.setDirty(particle);
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void setParticleNotDirty()
                {
                PersistenceManager PE_ParticleSaver = "PE_ParticleSaver";

                this["text"] = "Particle";
                this.dirty = false;

                PE_ParticleSaver.clearAll();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void showNewDialog(string replaceSlot)
                {
                // Open a dialog if the current Particle is dirty
                if (this.dirty)
                    {
                    messageBox.MessageBoxYesNoCancel("Save Particle Changes?",
                        "Do you wish to save the changes made to the <br>current particle before changing the particle?",
                        "PE_ParticleEditor.saveParticle( " + this.currParticle.getName() +
                        " ); PE_ParticleEditor.createParticle( " + replaceSlot + " );",
                        "PE_ParticleEditor.saveParticleDialogDontSave( " + this.currParticle.getName() +
                        " ); PE_ParticleEditor.createParticle( " + replaceSlot + " );"
                        );
                    }
                else
                    {
                    this.createParticle(replaceSlot);
                    }
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void createParticle(string replaceSlot)
                {
                ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";
                ParticleEditor ParticleEditor = "ParticleEditor";


                int particleIndex;
                // Make sure we have a spare slot on the current emitter.

                if (replaceSlot == "")
                    {
                    int numExistingParticles = Util.getWordCount(PE_EmitterEditor.currEmitter["particles"]);
                    if (numExistingParticles > 3)
                        {
                        messageBox.MessageBoxOK("Error", "An emitter cannot have more than 4 particles assigned to it.");
                        return;
                        }

                    particleIndex = numExistingParticles;
                    }
                else
                    particleIndex = replaceSlot.AsInt() - 1;

                // Create the particle datablock and add to the emitter.

                string newParticle = Util.getUniqueName("newParticle");

                SimObject newParticleNode = new DatablockCreator("ParticleData", newParticle + " : DefaultParticle", typeof(ParticleData)).Create();

                // Submit undo.

                var action = ParticleEditor.createUndo<ParticleEditorUndo.ActionCreateNewParticle>("Create New Particle");
                action["particle"] = newParticleNode;
                action["particleIndex"] = particleIndex.AsString();
                action["prevParticle"] =
                    ((GuiPopUpMenuCtrl) ("PEE_EmitterParticleSelector" + (particleIndex + 1))).getSelected()
                        .AsString();
                action["emitter"] = PE_EmitterEditor.currEmitter;

                ParticleEditor.submitUndo(action);

                // Execute action.

                action.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void showDeleteDialog()
                {
                ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

                // Don't allow deleting DefaultParticle.

                if (this.currParticle.getName() == "DefaultParticle")
                    {
                    messageBox.MessageBoxOK("Error", "Cannot delete DefaultParticle");
                    return;
                    }

                // Check to see if the particle emitter has more than 1 particle on it.

                if (Util.getWordCount(PE_EmitterEditor.currEmitter["particles"]) == 1)
                    {
                    messageBox.MessageBoxOK("Error", "At least one particle must remain on the particle emitter.");
                    return;
                    }

                // Bring up requester for confirmation.

                if (this.currParticle.isObject())
                    {
                    messageBox.MessageBoxYesNoCancel("Delete Particle?",
                        "Are you sure you want to delete<br><br>" + this.currParticle.getName() +
                        "<br><br> Particle deletion won't take affect until the engine is quit.",
                        "PE_ParticleEditor.saveParticleDialogDontSave( " + this.currParticle.getName() +
                        " ); PE_ParticleEditor.deleteParticle();",
                        "",
                        ""
                        );
                    }
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void deleteParticle()
                {
                ParticleEditor ParticleEditor = "ParticleEditor";
                ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

                SimObject particle = this.currParticle;

                // Submit undo.

                var action = ParticleEditor.createUndo<ParticleEditorUndo.ActionDeleteParticle>("Delete Particle");
                action["particle"] = particle;
                action["emitter"] = PE_EmitterEditor.currEmitter;

                ParticleEditor.submitUndo(action);

                // Execute action.

                action.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void saveParticle(SimObject particle)
                {
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleData PE_ParticleEditor_NotDirtyParticle = "PE_ParticleEditor_NotDirtyParticle";
                PersistenceManager PE_ParticleSaver = "PE_ParticleSaver";
                ParticleEditor ParticleEditor = "ParticleEditor";

                particle.setName(PEP_ParticleSelector.getText());

                PE_ParticleEditor_NotDirtyParticle.assignFieldsFrom(particle);
                PE_ParticleEditor_NotDirtyParticle["originalName"] = particle.getName();

                PE_ParticleSaver.saveDirty();
                this.setParticleNotDirty();

                ParticleEditor.createParticleList();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void saveParticleDialogDontSave(SimObject particle)
                {
                ParticleData PE_ParticleEditor_NotDirtyParticle = "PE_ParticleEditor_NotDirtyParticle";

                particle.setName(PE_ParticleEditor_NotDirtyParticle["originalName"]);
                particle.assignFieldsFrom(PE_ParticleEditor_NotDirtyParticle);

                this.setParticleNotDirty();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PE_ParticleEditor ts, string simobjectid)
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
            public static bool operator !=(PE_ParticleEditor ts, string simobjectid)
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
            public static implicit operator string(PE_ParticleEditor ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PE_ParticleEditor(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (PE_ParticleEditor) Omni.self.getSimObject(simobjectid, typeof (PE_ParticleEditor));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PE_ParticleEditor ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PE_ParticleEditor(int simobjectid)
                {
                return (PE_ParticleEditor) Omni.self.getSimObject((uint) simobjectid, typeof (PE_ParticleEditor));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PE_ParticleEditor ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PE_ParticleEditor(uint simobjectid)
                {
                return (PE_ParticleEditor) Omni.self.getSimObject(simobjectid, typeof (PE_ParticleEditor));
                }

            #endregion
            }
        }
    }