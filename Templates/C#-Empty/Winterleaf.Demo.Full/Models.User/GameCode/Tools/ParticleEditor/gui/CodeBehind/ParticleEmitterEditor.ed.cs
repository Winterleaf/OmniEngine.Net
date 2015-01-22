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
using WinterLeaf.Demo.Full.Models.User.GameCode.Common;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind
{
    public class ParticleEmitterEditor
    {
        [ConsoleInteraction(true, "ParticleEmitterEditor_initialize")]
        public static void initialize()
        {
            pInvokes.sGlobal["$PE_EMITTEREDITOR_DEFAULT_FILENAME"] = "art/particles/managedParticleEmitterData.cs";
        }

        //=============================================================================================
        //    PE_EmitterEditor.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        //=============================================================================================
        //    PEE_EmitterSelector_Control.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (PEE_EmitterSelector_Control))]
        public class PEE_EmitterSelector_Control : QuickEditDropDownTextEditCtrl
        {
            [ConsoleInteraction]
            public override void onRenameItem()
            {
                PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

                GuiPopUpMenuCtrl PopupMenu = this.FOT("PopupMenu");

                base.onRenameItem();

                //FIXME: need to check for validity of name and name clashes

                PE_EmitterEditor.setEmitterDirty();

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
            public static bool operator ==(PEE_EmitterSelector_Control ts, string simobjectid)
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
            public static bool operator !=(PEE_EmitterSelector_Control ts, string simobjectid)
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
            public static implicit operator string(PEE_EmitterSelector_Control ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PEE_EmitterSelector_Control(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (PEE_EmitterSelector_Control) Omni.self.getSimObject(simobjectid, typeof (PEE_EmitterSelector_Control));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PEE_EmitterSelector_Control ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PEE_EmitterSelector_Control(int simobjectid)
            {
                return (PEE_EmitterSelector_Control) Omni.self.getSimObject((uint) simobjectid, typeof (PEE_EmitterSelector_Control));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PEE_EmitterSelector_Control ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PEE_EmitterSelector_Control(uint simobjectid)
            {
                return (PEE_EmitterSelector_Control) Omni.self.getSimObject(simobjectid, typeof (PEE_EmitterSelector_Control));
            }

            #endregion
        }

        [TypeConverter(typeof (PE_EmitterEditor))]
        public class PE_EmitterEditor : GuiTabPageCtrl
        {
            public SimObject currEmitter
            {
                get { return this["currEmitter"]; }
                set { this["currEmitter"] = value; }
            }

            public bool dirty
            {
                get { return this["dirty"].AsBool(); }
                set { this["dirty"] = value.AsString(); }
            }

            public string text
            {
                get { return this["text"]; }
                set { this["text"] = value; }
            }

            [ConsoleInteraction]
            public void guiSync()
            {
                GuiCheckBoxCtrl PEE_infiniteLoop = this.FOT("PEE_infiniteLoop");
                GuiCheckBoxCtrl PEE_orientParticles = this.FOT("PEE_orientParticles");
                GuiCheckBoxCtrl PEE_alignParticles = this.FOT("PEE_alignParticles");
                GuiCheckBoxCtrl PEE_softParticles = this.FOT("PEE_softParticles");
                GuiCheckBoxCtrl PEE_reverseOrder = this.FOT("PEE_reverseOrder");
                GuiCheckBoxCtrl PEE_useEmitterSizes = this.FOT("PEE_useEmitterSizes");
                GuiCheckBoxCtrl PEE_useEmitterColors = this.FOT("PEE_useEmitterColors");
                GuiSliderCtrl PEE_lifetimeMS_slider = this.FOT("PEE_lifetimeMS_slider");
                GuiSliderCtrl PEE_lifetimeVarianceMS_slider = this.FOT("PEE_lifetimeVarianceMS_slider");
                GuiSliderCtrl PEE_ejectionVelocity_slider = this.FOT("PEE_ejectionVelocity_slider");
                GuiSliderCtrl PEE_ejectionPeriodMS_slider = this.FOT("PEE_ejectionPeriodMS_slider");
                GuiSliderCtrl PEE_periodVarianceMS_slider = this.FOT("PEE_periodVarianceMS_slider");
                GuiSliderCtrl PEE_velocityVariance_slider = this.FOT("PEE_velocityVariance_slider");
                GuiSliderCtrl PEE_thetaMin_slider = this.FOT("PEE_thetaMin_slider");
                GuiSliderCtrl PEE_thetaMax_slider = this.FOT("PEE_thetaMax_slider");
                GuiSliderCtrl PEE_phiVariance_slider = this.FOT("PEE_phiVariance_slider");
                GuiSliderCtrl PEE_ejectionOffset_slider = this.FOT("PEE_ejectionOffset_slider");
                GuiSliderCtrl PEE_softnessDistance_slider = this.FOT("PEE_softnessDistance_slider");
                GuiSliderCtrl PEE_ambientFactor_slider = this.FOT("PEE_ambientFactor_slider");
                GuiTextEditCtrl PEE_lifetimeMS_textEdit = this.FOT("PEE_lifetimeMS_textEdit");
                GuiTextEditCtrl PEE_lifetimeVarianceMS_textEdit = this.FOT("PEE_lifetimeVarianceMS_textEdit");
                GuiTextEditCtrl PEE_ejectionPeriodMS_textEdit = this.FOT("PEE_ejectionPeriodMS_textEdit");
                GuiTextEditCtrl PEE_periodVarianceMS_textEdit = this.FOT("PEE_periodVarianceMS_textEdit");
                GuiTextEditCtrl PEE_ejectionVelocity_textEdit = this.FOT("PEE_ejectionVelocity_textEdit");
                GuiTextEditCtrl PEE_velocityVariance_textEdit = this.FOT("PEE_velocityVariance_textEdit");
                GuiTextEditCtrl PEE_alignDirection = this.FOT("PEE_alignDirection");
                GuiTextEditCtrl PEE_thetaMin_textEdit = this.FOT("PEE_thetaMin_textEdit");
                GuiTextEditCtrl PEE_thetaMax_textEdit = this.FOT("PEE_thetaMax_textEdit");
                GuiTextEditCtrl PEE_phiVariance_textEdit = this.FOT("PEE_phiVariance_textEdit");
                GuiTextEditCtrl PEE_ejectionOffset_textEdit = this.FOT("PEE_ejectionOffset_textEdit");
                GuiTextEditCtrl PEE_softnessDistance_textEdit = this.FOT("PEE_softnessDistance_textEdit");
                GuiTextEditCtrl PEE_ambientFactor_textEdit = this.FOT("PEE_ambientFactor_textEdit");
                GuiPopUpMenuCtrl PEE_blendType = this.FOT("PEE_blendType");

                SimObject data = this.currEmitter;

                // Sync up sliders and number boxes.

                if (PEE_infiniteLoop.isStateOn())
                    {
                    PEE_lifetimeMS_slider.setActive(false);
                    PEE_lifetimeMS_textEdit.setActive(false);
                    PEE_lifetimeVarianceMS_slider.setActive(false);
                    PEE_lifetimeVarianceMS_textEdit.setActive(false);
                    }
                else
                    {
                    PEE_lifetimeMS_slider.setActive(true);
                    PEE_lifetimeMS_textEdit.setActive(true);
                    PEE_lifetimeVarianceMS_slider.setActive(true);
                    PEE_lifetimeVarianceMS_textEdit.setActive(true);

                    PEE_lifetimeMS_slider.setValue(data["lifetimeMS"]);
                    PEE_lifetimeMS_textEdit.setText(data["lifetimeMS"]);
                    PEE_lifetimeVarianceMS_slider.setValue(data["lifetimeVarianceMS"]);
                    PEE_lifetimeVarianceMS_textEdit.setText(data["lifetimeVarianceMS"]);
                    }

                PEE_ejectionPeriodMS_slider.setValue(data["ejectionPeriodMS"]);
                PEE_ejectionPeriodMS_textEdit.setText(data["ejectionPeriodMS"]);

                PEE_periodVarianceMS_slider.setValue(data["periodVarianceMS"]);
                PEE_periodVarianceMS_textEdit.setText(data["periodVarianceMS"]);

                PEE_ejectionVelocity_slider.setValue(data["ejectionVelocity"]);
                PEE_ejectionVelocity_textEdit.setText(data["ejectionVelocity"]);

                PEE_velocityVariance_slider.setValue(data["velocityVariance"]);
                PEE_velocityVariance_textEdit.setText(data["velocityVariance"]);

                PEE_orientParticles.setValue(data["orientParticles"]);
                PEE_alignParticles.setValue(data["alignParticles"]);
                PEE_alignDirection.setText(data["alignDirection"]);

                PEE_thetaMin_slider.setValue(data["thetaMin"]);
                PEE_thetaMin_textEdit.setText(data["thetaMin"]);

                PEE_thetaMax_slider.setValue(data["thetaMax"]);
                PEE_thetaMax_textEdit.setText(data["thetaMax"]);

                PEE_phiVariance_slider.setValue(data["phiVariance"]);
                PEE_phiVariance_textEdit.setText(data["phiVariance"]);

                PEE_ejectionOffset_slider.setValue(data["ejectionOffset"]);
                PEE_ejectionOffset_textEdit.setText(data["ejectionOffset"]);

                int blendTypeId = PEE_blendType.findText(data["blendStyle"]);
                PEE_blendType.setSelected(blendTypeId, false);

                PEE_softnessDistance_slider.setValue(data["softnessDistance"]);
                PEE_softnessDistance_textEdit.setText(data["softnessDistance"]);

                PEE_ambientFactor_slider.setValue(data["ambientFactor"]);
                PEE_ambientFactor_textEdit.setText(data["ambientFactor"]);

                PEE_softParticles.setValue(data["softParticles"]);
                PEE_reverseOrder.setValue(data["reverseOrder"]);
                PEE_useEmitterSizes.setValue(data["useEmitterSizes"]);
                PEE_useEmitterColors.setValue(data["useEmitterColors"]);

                // Sync up particle selectors.

                for (int index = 0; index < 4; index++)
                    {
                    GuiControl ctrl = "PEE_EmitterParticle" + (index + 1);
                    GuiPopUpMenuCtrl popup = ctrl.FOT("PopUpMenu");

                    string particle = Util.getWord(data["particles"], index);
                    if (particle.Trim() == "")
                        popup.setSelected(0, false); // Select "None".
                    else if (particle.isObject())
                        popup.setSelected(particle.getID(), false);
                    else
                        popup.setSelected(0, false); // Select "None".
                    }
            }

            //---------------------------------------------------------------------------------------------

            // Generic updateEmitter method
            [ConsoleInteraction]
            public void updateEmitter(string propertyField, string value, bool isSlider, bool onMouseUp)
            {
                ParticleEditor ParticleEditor = "ParticleEditor";
                editor Editor = "Editor";

                this.setEmitterDirty();

                SimObject emitter = this.currEmitter;

                SimObject last = Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"]).AsBool() && (!last["onMouseUp"].AsBool()))
                    {
                    last["field"] = propertyField;
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValue"] = value;
                    }
                else
                    {
                    ParticleEditorUndo.ActionUpdateActiveEmitter action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveEmitter>("Update Active Emitter");
                    action["emitter"] = emitter;
                    action["field"] = propertyField;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();
                    action["newValue"] = value;
                    action["oldValue"] = emitter.getFieldValue(propertyField, -1);

                    ParticleEditor.submitUndo(action);
                    }

                emitter.setFieldValue(propertyField, value, -1);
                emitter.call("reload");
            }

            //---------------------------------------------------------------------------------------------

            // Special case updateEmitter methods
            [ConsoleInteraction]
            public void updateLifeFields(bool isRandom, float value, bool isSlider, bool onMouseUp)
            {
                GuiCheckBoxCtrl PEE_infiniteLoop = this.FOT("PEE_infiniteLoop");
                GuiSliderCtrl PEE_lifetimeMS_slider = this.FOT("PEE_lifetimeMS_slider");
                GuiSliderCtrl PEE_lifetimeVarianceMS_slider = this.FOT("PEE_lifetimeVarianceMS_slider");
                GuiTextEditCtrl PEE_lifetimeVarianceMS_textEdit = this.FOT("PEE_lifetimeVarianceMS_textEdit");
                GuiTextEditCtrl PEE_lifetimeMS_textEdit = this.FOT("PEE_lifetimeMS_textEdit");
                editor Editor = "Editor";
                ParticleEditor ParticleEditor = "ParticleEditor";

                this.setEmitterDirty();

                SimObject emitter = this.currEmitter;

                // Transfer values over to gui controls.

                if (isRandom)
                    {
                    if (value > 0)
                        value++;

                    if (value > PEE_lifetimeMS_slider.getValue())
                        {
                        PEE_lifetimeMS_textEdit.setText(value.AsString());
                        PEE_lifetimeMS_slider.setValue(value.AsString());
                        }
                    }
                else
                    {
                    if (value > 0)
                        value--;

                    if (value < PEE_lifetimeVarianceMS_slider.getValue())
                        {
                        PEE_lifetimeVarianceMS_textEdit.setText(value.AsString());
                        PEE_lifetimeVarianceMS_slider.setValue(value.AsString());
                        }
                    }

                // Submit undo.

                SimObject last = Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValueLifetimeMS"] = PEE_lifetimeMS_textEdit.getText();
                    last["newValueLifetimeVarianceMS"] = PEE_lifetimeVarianceMS_textEdit.getText();
                    }
                else
                    {
                    ParticleEditorUndo.ActionUpdateActiveEmitterLifeFields action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveEmitterLifeFields>("Update Active Emitter");
                    action["emitter"] = emitter;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();

                    action["newValueLifetimeMS"] = PEE_lifetimeMS_textEdit.getText();
                    action["oldValueLifetimeMS"] = emitter["lifetimeMS"];

                    action["newValueLifetimeVarianceMS"] = PEE_lifetimeVarianceMS_textEdit.getText();
                    action["oldValueLifetimeVarianceMS"] = emitter["lifetimeVarianceMS"];

                    ParticleEditor.submitUndo(action);
                    }

                // Set the values on the current emitter.

                emitter["lifetimeMS"] = PEE_lifetimeMS_textEdit.getText();
                emitter["lifetimeVarianceMS"] = PEE_lifetimeVarianceMS_textEdit.getText();
                emitter.call("reload");

                // Keep the infiniteLoop checkbox up to date.

                PEE_infiniteLoop.setStateOn(emitter["lifetimeMS"].AsInt() == 0);
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void updateLifeFieldsInfiniteLoop()
            {
                GuiCheckBoxCtrl PEE_infiniteLoop = this.FOT("PEE_infiniteLoop");
                GuiTextEditCtrl PEE_lifetimeVarianceMS_textEdit = this.FOT("PEE_lifetimeVarianceMS_textEdit");
                GuiTextEditCtrl PEE_lifetimeMS_textEdit = this.FOT("PEE_lifetimeMS_textEdit");
                ParticleEditor ParticleEditor = "ParticleEditor";

                SimObject emitter = this.currEmitter;
                bool isEnabled = PEE_infiniteLoop.isStateOn();

                // Submit undo.

                ParticleEditorUndo.ActionUpdateActiveEmitterLifeFields action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveEmitterLifeFields>("Update Active Emitter");
                action["emitter"] = emitter;

                if (isEnabled)
                    {
                    action["newValueLifetimeMS"] = "0";
                    action["newvalueLifetimeVarianceMS"] = "0";
                    action["oldValueLifetimeMS"] = PEE_lifetimeMS_textEdit.getText();
                    action["oldValueLifetimeVarianceMS"] = PEE_lifetimeVarianceMS_textEdit.getText();
                    }
                else
                    {
                    action["newValueLifetimeMS"] = PEE_lifetimeMS_textEdit.getText();
                    action["newvalueLifetimeVarianceMS"] = PEE_lifetimeVarianceMS_textEdit.getText();
                    action["oldValueLifetimeMS"] = "0";
                    action["oldValueLifetimeVarianceMS"] = "0";
                    }

                ParticleEditor.submitUndo(action);

                // Execute action.

                action.redo();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void updateAmountFields(bool isRandom, float value, bool isSlider, bool onMouseUp)
            {
                GuiSliderCtrl PEE_ejectionPeriodMS_slider = this.FOT("PEE_ejectionPeriodMS_slider");
                GuiSliderCtrl PEE_periodVarianceMS_slider = this.FOT("PEE_periodVarianceMS_slider");
                GuiTextEditCtrl PEE_ejectionPeriodMS_textEdit = this.FOT("PEE_ejectionPeriodMS_textEdit");
                GuiTextEditCtrl PEE_periodVarianceMS_textEdit = this.FOT("PEE_periodVarianceMS_textEdit");
                editor Editor = "Editor";
                ParticleEditor ParticleEditor = "ParticleEditor";

                this.setEmitterDirty();
                SimObject emitter = this.currEmitter;

                // Transfer values over to gui controls.

                if (isRandom)
                    {
                    value++;
                    if (value > PEE_ejectionPeriodMS_slider.getValue())
                        {
                        PEE_ejectionPeriodMS_textEdit.setText(value.AsString());
                        PEE_ejectionPeriodMS_slider.setValue(value.AsString());
                        }
                    }
                else
                    {
                    value--;
                    if (value < PEE_periodVarianceMS_slider.getValue())
                        {
                        PEE_periodVarianceMS_textEdit.setText(value.AsString());
                        PEE_periodVarianceMS_slider.setValue(value.AsString());
                        }
                    }

                // Submit undo.

                SimObject last = Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValueEjectionPeriodMS"] = PEE_ejectionPeriodMS_textEdit.getText();
                    last["newValuePeriodVarianceMS"] = PEE_periodVarianceMS_textEdit.getText();
                    }
                else
                    {
                    ParticleEditorUndo.ActionUpdateActiveEmitterAmountFields action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveEmitterAmountFields>("Update Active Emitter");
                    action["emitter"] = emitter;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();

                    action["newValueEjectionPeriodMS"] = PEE_ejectionPeriodMS_textEdit.getText();
                    action["oldValueEjectionPeriodMS"] = emitter["ejectionPeriodMS"];

                    action["newValuePeriodVarianceMS"] = PEE_periodVarianceMS_textEdit.getText();
                    action["oldValuePeriodVarianceMS"] = emitter["periodVarianceMS"];

                    ParticleEditor.submitUndo(action);
                    }

                // Set the values on the current emitter.

                emitter["ejectionPeriodMS"] = PEE_ejectionPeriodMS_textEdit.getText();
                emitter["periodVarianceMS"] = PEE_periodVarianceMS_textEdit.getText();
                emitter.call("reload");
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void updateSpeedFields(bool isRandom, float value, bool isSlider, bool onMouseUp)
            {
                GuiSliderCtrl PEE_ejectionVelocity_slider = this.FOT("PEE_ejectionVelocity_slider");
                GuiSliderCtrl PEE_velocityVariance_slider = this.FOT("PEE_velocityVariance_slider");
                GuiTextEditCtrl PEE_ejectionVelocity_textEdit = this.FOT("PEE_ejectionVelocity_textEdit");
                GuiTextEditCtrl PEE_velocityVariance_textEdit = this.FOT("PEE_velocityVariance_textEdit");
                editor Editor = "Editor";
                ParticleEditor ParticleEditor = "ParticleEditor";

                this.setEmitterDirty();
                SimObject emitter = this.currEmitter;

                // Transfer values over to gui controls.

                if (isRandom)
                    {
                    if (value > PEE_ejectionVelocity_slider.getValue())
                        {
                        PEE_ejectionVelocity_textEdit.setText(value.AsString());
                        PEE_ejectionVelocity_slider.setValue(value.AsString());
                        }
                    }
                else
                    {
                    if (value < PEE_velocityVariance_slider.getValue())
                        {
                        PEE_velocityVariance_textEdit.setText(value.AsString());
                        PEE_velocityVariance_slider.setValue(value.AsString());
                        }
                    }

                // Submit undo.

                SimObject last = Editor.getUndoManager().getUndoAction((Editor.getUndoManager().getUndoCount() - 1));
                if ((isSlider) && (last["isSlider"].AsBool()) && (!last["onMouseUp"].AsBool()))
                    {
                    last["isSlider"] = isSlider.AsString();
                    last["onMouseUp"] = onMouseUp.AsString();
                    last["newValueEjectionVelocity"] = PEE_ejectionVelocity_textEdit.getText();
                    last["newValueVelocityVariance"] = PEE_velocityVariance_textEdit.getText();
                    }
                else
                    {
                    ParticleEditorUndo.ActionUpdateActiveEmitterSpeedFields action = ParticleEditor.createUndo<ParticleEditorUndo.ActionUpdateActiveEmitterSpeedFields>("Update Active Emitter");
                    action["emitter"] = emitter;
                    action["isSlider"] = isSlider.AsString();
                    action["onMouseUp"] = onMouseUp.AsString();

                    action["newValueEjectionVelocity"] = PEE_ejectionVelocity_textEdit.getText();
                    action["oldValueEjectionVelocity"] = emitter["ejectionVelocity"];

                    action["newValueVelocityVariance"] = PEE_velocityVariance_textEdit.getText();
                    action["oldValueVelocityVariance"] = emitter["velocityVariance"];

                    ParticleEditor.submitUndo(action);
                    }

                // Set the values on the current emitter.

                emitter["ejectionVelocity"] = PEE_ejectionVelocity_textEdit.getText();
                emitter["velocityVariance"] = PEE_velocityVariance_textEdit.getText();
                emitter.call("reload");
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void updateParticlesFields()
            {
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                string particles = "";
                for (int i = 1; i < 5; i++)
                    {
                    GuiControl emitterParticle = "PEE_EmitterParticle" + i;
                    GuiPopUpMenuCtrl popup = emitterParticle.FOT("PopUpMenu");
                    string text = popup.getText();

                    if (text == "" || text == "None")
                        continue;

                    if (particles == "")
                        particles = text;
                    else
                        particles = particles + ' ' + text;
                    }

                int changedEditParticle = 1;
                string currParticle = PE_ParticleEditor.currParticle.getName();

                foreach (string particleName in particles.Split(' '))
                    {
                    if (particleName == currParticle)
                        {
                        changedEditParticle = 0;
                        break;
                        }
                    }

                // True only if the currently edited particle has not been found and the 
                // ParticleEditor is dirty.

                if (changedEditParticle == 1 && PE_ParticleEditor.dirty)
                    messageBox.MessageBoxYesNoCancel("Save Particle Changes?", "Do you wish to save the changes made to the <br>current particle before changing the particle?", "PE_ParticleEditor.saveParticle( " + PE_ParticleEditor.currParticle.getName() + " ); PE_EmitterEditor.updateEmitter( \"particles\"," + particles + ");", "PE_ParticleEditor.saveParticleDialogDontSave( " + PE_ParticleEditor.currParticle.getName() + " ); PE_EmitterEditor.updateEmitter( \"particles\"," + particles + ");", "PE_EmitterEditor.guiSync();");
                else
                    this.updateEmitter("particles", particles, false, false);
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void onNewEmitter()
            {
                GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                if (this.currEmitter.isObject() && this.currEmitter == PEE_EmitterSelector.getSelected())
                    return;

                //FIXME: disregards particle tab dirty state

                if (this.dirty)
                    {
                    if (PE_ParticleEditor.dirty)
                        messageBox.MessageBoxYesNo("Save Existing Particle?", "Do you want to save changes to <br><br>" + PE_ParticleEditor.currParticle.getName(), "PE_ParticleEditor.saveParticle(" + PE_ParticleEditor.currParticle + ");");

                    SimObject savedEmitter = this.currEmitter;
                    messageBox.MessageBoxYesNoCancel("Save Existing Emitter?", "Do you want to save changes to <br><br>" + savedEmitter.getName(), "PE_EmitterEditor.saveEmitter(" + savedEmitter + "); PE_EmitterEditor.loadNewEmitter();", "PE_EmitterEditor.saveEmitterDialogDontSave(" + savedEmitter + "); PE_EmitterEditor.loadNewEmitter();");
                    }
                else
                    this.loadNewEmitter("");
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void loadNewEmitter(string emitter)
            {
                ParticleEditor ParticleEditor = "ParticleEditor";
                GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
                ParticleEmitterData PE_EmitterEditor_NotDirtyEmitter = "PE_EmitterEditor_NotDirtyEmitter";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                GuiCheckBoxCtrl PEE_infiniteLoop = this.FOT("PEE_infiniteLoop");

                SimObject current;
                if (emitter.isObject())
                    current = emitter.getID();
                else
                    current = PEE_EmitterSelector.getSelected();

                this.currEmitter = current;
                PE_EmitterEditor_NotDirtyEmitter.assignFieldsFrom(current);
                PE_EmitterEditor_NotDirtyEmitter["originalName"] = current["name"];

                this.guiSync();
                this.setEmitterNotDirty();

                PE_ParticleEditor.loadNewParticle(Util.getWord(current["particles"], 0));

                ParticleEditor.updateEmitterNode();

                PEE_infiniteLoop.setStateOn(current["lifetimeMS"].AsInt() == 0);
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void setEmitterDirty()
            {
                PersistenceManager PE_EmitterSaver = "PE_EmitterSaver";

                this.text = "Emitter *";
                this.dirty = true;

                SimObject emitter = this.currEmitter;

                if (emitter.getFilename() == "" || emitter.getFilename() == "tools/particleEditor/particleEmitterEditor.ed.cs")
                    PE_EmitterSaver.setDirty(emitter, sGlobal["$PE_EMITTEREDITOR_DEFAULT_FILENAME"]);
                else
                    PE_EmitterSaver.setDirty(emitter);
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void setEmitterNotDirty()
            {
                PersistenceManager PE_EmitterSaver = "PE_EmitterSaver";

                this.text = "Emitter";
                this.dirty = false;

                PE_EmitterSaver.clearAll();
            }

            //---------------------------------------------------------------------------------------------

            // Create Functionality
            [ConsoleInteraction]
            public void showNewDialog()
            {
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";
                //FIXME: disregards particle tab dirty state

                // Open a dialog if the current emitter is dirty.

                if (PE_ParticleEditor.dirty)
                    messageBox.MessageBoxYesNo("Save Existing Particle?", "Do you want to save changes to <br><br>" + PE_ParticleEditor.currParticle.getName(), "PE_ParticleEditor.saveParticle(" + PE_ParticleEditor.currParticle + ");");

                if (this.dirty)
                    messageBox.MessageBoxYesNoCancel("Save Emitter Changes?", "Do you wish to save the changes made to the <br>current emitter before changing the emitter?", "PE_EmitterEditor.saveEmitter( " + this.currEmitter.getName() + " ); PE_EmitterEditor.createEmitter();", "PE_EmitterEditor.saveEmitterDialogDontSave( " + this.currEmitter.getName() + " ); PE_EmitterEditor.createEmitter();");
                else
                    this.createEmitter();
            }

            //---------------------------------------------------------------------------------------------

            [ConsoleInteraction]
            public void createEmitter()
            {
                ParticleEditor ParticleEditor = "ParticleEditor";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                // Create a new emitter.
                string emitter = Util.getUniqueName("newEmitter");
                DatablockCreator oc = new DatablockCreator("ParticleEmitterData", emitter + " : DefaultEmitter", typeof (ParticleEmitterData));
                SimObject emitterNode = oc.Create();

                // Submit undo.

                ParticleEditorUndo.ActionCreateNewEmitter action = ParticleEditor.createUndo<ParticleEditorUndo.ActionCreateNewEmitter>("Create New Emitter");
                action["prevEmitter"] = this.currEmitter;
                action["emitter"] = emitterNode;
                action["emitterName"] = emitter;

                ParticleEditor.submitUndo(action);

                // Execute action.

                action.redo();

                PE_ParticleEditor.createParticle("");
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void showDeleteDialog()
            {
                if (this.currEmitter.getName() == "DefaultEmitter")
                    {
                    messageBox.MessageBoxOK("Error", "Cannot delete DefaultEmitter");
                    return;
                    }

                if (this.currEmitter.isObject())
                    messageBox.MessageBoxYesNoCancel("Delete Emitter?", "Are you sure you want to delete<br><br>" + this.currEmitter.getName() + "<br><br> Emitter deletion won't take affect until the level is exited.", "PE_EmitterEditor.saveEmitterDialogDontSave( " + this.currEmitter.getName() + " ); PE_EmitterEditor.deleteEmitter();");
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void deleteEmitter()
            {
                ParticleEditor ParticleEditor = "ParticleEditor";
                SimObject emitter = this.currEmitter;

                // Create undo.

                ParticleEditorUndo.ActionDeleteEmitter action = ParticleEditor.createUndo<ParticleEditorUndo.ActionDeleteEmitter>("Delete Emitter");
                action["emitter"] = emitter;
                action["emitterFname"] = emitter.getFilename();

                ParticleEditor.submitUndo(action);

                // Execute action.

                action.redo();
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void saveEmitter(SimObject emitter)
            {
                PEE_EmitterSelector_Control PEE_EmitterSelector_Control = "PEE_EmitterSelector_Control";
                ParticleEmitterData PE_EmitterEditor_NotDirtyEmitter = "PE_EmitterEditor_NotDirtyEmitter";
                PersistenceManager PE_EmitterSaver = "PE_EmitterSaver";
                ParticleEditor ParticleEditor = "ParticleEditor";

                GuiTextEditCtrl TextEdit = PEE_EmitterSelector_Control.FOT("TextEdit");

                string newName;
                if (emitter == "")
                    newName = TextEdit.getText();
                else
                    newName = emitter.getName();

                this.currEmitter.setName(newName);
                PE_EmitterEditor_NotDirtyEmitter.assignFieldsFrom(emitter);
                PE_EmitterEditor_NotDirtyEmitter["originalName"] = newName;

                PE_EmitterSaver.saveDirty();

                this.currEmitter = newName.getID();
                this.setEmitterNotDirty();

                ParticleEditor.createParticleList();
            }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public void saveEmitterDialogDontSave(SimObject emitter)
            {
                ParticleEmitterData PE_EmitterEditor_NotDirtyEmitter = "PE_EmitterEditor_NotDirtyEmitter";

                emitter.setName(PE_EmitterEditor_NotDirtyEmitter["originalName"]);
                emitter.assignFieldsFrom(PE_EmitterEditor_NotDirtyEmitter);
                this.setEmitterNotDirty();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PE_EmitterEditor ts, string simobjectid)
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
            public static bool operator !=(PE_EmitterEditor ts, string simobjectid)
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
            public static implicit operator string(PE_EmitterEditor ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PE_EmitterEditor(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (PE_EmitterEditor) Omni.self.getSimObject(simobjectid, typeof (PE_EmitterEditor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PE_EmitterEditor ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PE_EmitterEditor(int simobjectid)
            {
                return (PE_EmitterEditor) Omni.self.getSimObject((uint) simobjectid, typeof (PE_EmitterEditor));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PE_EmitterEditor ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PE_EmitterEditor(uint simobjectid)
            {
                return (PE_EmitterEditor) Omni.self.getSimObject(simobjectid, typeof (PE_EmitterEditor));
            }

            #endregion
        }
    }
}