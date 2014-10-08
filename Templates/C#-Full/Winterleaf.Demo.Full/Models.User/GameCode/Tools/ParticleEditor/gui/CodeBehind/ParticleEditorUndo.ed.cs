using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind
    {
    public class ParticleEditorUndo
        {
        //=============================================================================================
        //    BaseParticleEdAction.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        //=============================================================================================
        //    ActionRenameEmitter.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        //TODO

        //=============================================================================================
        //    ActionCreateNewEmitter.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionCreateNewEmitter>))]
        public class ActionCreateNewEmitter : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
                GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";

                SimObject emitter = this["emitter"];

                // Assign name.

                emitter["name"] = this["emitterName"];

                // Remove from unlisted.

                PE_UnlistedEmitters.remove(emitter);

                // Drop it in the dropdown and select it.

                GuiPopUpMenuCtrl popup = PEE_EmitterSelector;

                popup.add(emitter.getName(), emitter.getId());
                popup.sort();
                popup.setSelected(emitter.getId());

                // Sync up.

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
                GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
                ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

                SimObject emitter = this["emitter"];

                // Prevent a save dialog coming up on the emitter.

                if (emitter == PE_EmitterEditor.currEmitter)
                    PE_EmitterEditor.setEmitterNotDirty();

                // Add to unlisted.

                PE_UnlistedEmitters.add(emitter);

                // Remove it from in the dropdown and select prev emitter.

                GuiPopUpMenuCtrl popup = PEE_EmitterSelector;

                if (this["prevEmitter"].isObject())
                    popup.setSelected(this["prevEmitter"].getID());
                else
                    popup.setFirstSelected();

                popup.clearEntry(emitter.getId());

                // Unassign name.

                this["emitterName"] = emitter.name;
                emitter["name"] = "";

                // Sync up.

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionCreateNewEmitter ts, string simobjectid)
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
            public static bool operator !=(ActionCreateNewEmitter ts, string simobjectid)
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
            public static implicit operator string(ActionCreateNewEmitter ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateNewEmitter(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ActionCreateNewEmitter) Omni.self.getSimObject(simobjectid, typeof (ActionCreateNewEmitter));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionCreateNewEmitter ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateNewEmitter(int simobjectid)
                {
                return
                    (ActionCreateNewEmitter) Omni.self.getSimObject((uint) simobjectid, typeof (ActionCreateNewEmitter));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionCreateNewEmitter ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionCreateNewEmitter(uint simobjectid)
                {
                return (ActionCreateNewEmitter) Omni.self.getSimObject(simobjectid, typeof (ActionCreateNewEmitter));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ActionCreateNewParticle>))]
        public class ActionCreateNewParticle : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimSet PE_UnlistedParticles = "PE_UnlistedParticles";
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                string particleName = particle.getName();
                int particleId = particle.getId();
                string particleIndex = this["particleIndex"];
                SimObject emitter = this["emitter"];

                // Remove from unlisted.

                PE_UnlistedParticles.remove(particleId.AsString());

                // Add it to the dropdown.

                PEP_ParticleSelector.add(particleName, particleId);
                PEP_ParticleSelector.sort();
                PEP_ParticleSelector.setSelected(particleId, false);

                // Add particle to dropdowns in the emitter editor.

                for (int i = 1; i < 5; i ++)
                    {
                    GuiControl emitterParticle = "PEE_EmitterParticle" + i;
                    GuiPopUpMenuCtrl popup = emitterParticle.FOT("PopupMenu");

                    popup.add(particle, particleId);
                    popup.sort();

                    if (i == particleIndex.AsInt() + 1)
                        popup.setSelected(particleId);
                    }

                // Sync up.

                PE_ParticleEditor.loadNewParticle("");
                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimSet PE_UnlistedParticles = "PE_UnlistedParticles";
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";

                string particleName = particle.getName();
                int particleId = particle.getId();
                SimObject emitter = this["emitter"];

                // Add to unlisted.

                PE_UnlistedParticles.add(particleId.AsString());

                // Remove from dropdown.

                PEP_ParticleSelector.clearEntry(particleId);
                PEP_ParticleSelector.setFirstSelected(false);

                // Remove from particle dropdowns in emitter editor.

                for (int i = 1; i < 5; i ++)
                    {
                    GuiControl emitterParticle = "PEE_EmitterParticle" + i;
                    GuiPopUpMenuCtrl popup = emitterParticle.FOT("PopUpMenu");

                    if (popup.getSelected() == particleId)
                        popup.setSelected(this["prevParticle"].AsInt());

                    popup.clearEntry(particleId);
                    }

                // Sync up.

                PE_ParticleEditor.loadNewParticle("");
                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionCreateNewParticle ts, string simobjectid)
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
            public static bool operator !=(ActionCreateNewParticle ts, string simobjectid)
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
            public static implicit operator string(ActionCreateNewParticle ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateNewParticle(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ActionCreateNewParticle) Omni.self.getSimObject(simobjectid, typeof (ActionCreateNewParticle));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionCreateNewParticle ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionCreateNewParticle(int simobjectid)
                {
                return
                    (ActionCreateNewParticle)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionCreateNewParticle));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionCreateNewParticle ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionCreateNewParticle(uint simobjectid)
                {
                return (ActionCreateNewParticle) Omni.self.getSimObject(simobjectid, typeof (ActionCreateNewParticle));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionDeleteEmitter.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionDeleteEmitter>))]
        public class ActionDeleteEmitter : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
                PersistenceManager PE_EmitterSaver = "PE_EmitterSaver";
                ParticleEmitterEditor.PEE_EmitterSelector_Control PEE_EmitterSelector_Control =
                    "PEE_EmitterSelector_Control";

                GuiPopUpMenuCtrl PopUpMenu = PEE_EmitterSelector_Control.FOT("PopUpMenu");

                SimObject emitter = this["emitter"];

                // Unassign name.

                this["emitterName"] = emitter["name"];
                emitter["name"] = "";

                // Add to unlisted.

                PE_UnlistedEmitters.add(emitter);

                // Remove from file.

                if (emitter.getFilename() != ""
                    && emitter.getFilename() != "tools/particleEditor/particleEmitterEditor.ed.cs")
                    PE_EmitterSaver.removeObjectFromFile(emitter);

                // Select DefaultEmitter or first in list.

                GuiPopUpMenuCtrl popup = PopUpMenu;

                popup.setFirstSelected();

                // Remove from dropdown.

                popup.clearEntry(emitter);

                // Sync up.

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimSet PE_UnlistedEmitters = "PE_UnlistedEmitters";
                PersistenceManager PE_EmitterSaver = "PE_EmitterSaver";
                ParticleEmitterEditor.PEE_EmitterSelector_Control PEE_EmitterSelector_Control =
                    "PEE_EmitterSelector_Control";

                GuiPopUpMenuCtrl PopUpMenu = PEE_EmitterSelector_Control.FOT("PopUpMenu");

                SimObject emitter = this["emitter"];

                // Re-assign name.

                emitter["name"] = this["emitterName"];

                // Remove from unlisted.

                PE_UnlistedEmitters.remove(emitter);

                // Resave to file.

                if (this["emitterFname"] != ""
                    && this["emitterFname"] != "tools/particleEditor/particleEmitterEditor.ed.gui")
                    {
                    PE_EmitterSaver.setDirty(emitter, this["emitterFname"]);
                    PE_EmitterSaver.saveDirty();
                    }

                // Add it to the dropdown and selet it.

                GuiPopUpMenuCtrl popup = PopUpMenu;
                popup.add(emitter.getName(), emitter.getId());
                popup.sort();
                popup.setSelected(emitter.getId());

                // Sync up.

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionDeleteEmitter ts, string simobjectid)
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
            public static bool operator !=(ActionDeleteEmitter ts, string simobjectid)
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
            public static implicit operator string(ActionDeleteEmitter ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteEmitter(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ActionDeleteEmitter) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteEmitter));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionDeleteEmitter ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteEmitter(int simobjectid)
                {
                return (ActionDeleteEmitter) Omni.self.getSimObject((uint) simobjectid, typeof (ActionDeleteEmitter));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionDeleteEmitter ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionDeleteEmitter(uint simobjectid)
                {
                return (ActionDeleteEmitter) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteEmitter));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ActionDeleteParticle>))]
        public class ActionDeleteParticle : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimSet PE_UnlistedParticles = "PE_UnlistedParticles";
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";
                PersistenceManager PE_ParticleSaver = "PE_ParticleSaver";

                string particleName = particle.getName();
                int particleId = particle.getId();
                SimObject emitter = this["emitter"];

                // Add to unlisted.

                PE_UnlistedParticles.add(particleId.AsString());

                // Remove from file.

                if (particle.getFilename() != ""
                    && particle.getFilename() != "tools/particleEditor/particleParticleEditor.ed.cs")
                    PE_ParticleSaver.removeObjectFromFile(particleId.AsString());

                // Remove from dropdown.

                PEP_ParticleSelector.clearEntry(particleId);
                PEP_ParticleSelector.setFirstSelected();

                // Remove from particle selectors in emitter.

                for (int i = 1; i < 5; i ++)
                    {
                    GuiControl emitterParticle = "PEE_EmitterParticle" + i;
                    GuiPopUpMenuCtrl popup = emitterParticle.FOT("PopUpMenu");

                    if (popup.getSelected() == particleId)
                        {
                        this["particleIndex"] = (i - 1).AsString();
                        popup.setSelected(0); // Select "None".
                        }

                    popup.clearEntry(particleId);
                    }

                // Sync up.

                PE_ParticleEditor.loadNewParticle("");
                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimSet PE_UnlistedParticles = "PE_UnlistedParticles";
                GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";
                PersistenceManager PE_ParticleSaver = "PE_ParticleSaver";

                string particleName = particle.getName();
                int particleId = particle.getId();
                string particleIndex = this["particleIndex"];
                SimObject emitter = this["emitter"];

                // Remove from unlisted.

                PE_UnlistedParticles.remove(particleId.AsString());

                // Resave to file.

                if (particle.getFilename() != ""
                    && particle.getFilename() != "tools/particleEditor/particleParticleEditor.ed.gui")
                    {
                    PE_ParticleSaver.setDirty(particle);
                    PE_ParticleSaver.saveDirty();
                    }

                // Add to dropdown.

                PEP_ParticleSelector.add(particleName, particleId);
                PEP_ParticleSelector.sort();
                PEP_ParticleSelector.setSelected(particleId);

                // Add particle to dropdowns in the emitter editor.

                for (int i = 1; i < 5; i ++)
                    {
                    GuiControl emitterParticle = "PEE_EmitterParticle" + i;
                    GuiPopUpMenuCtrl popup = emitterParticle.FOT("PopUpMenu");

                    popup.add(particleName, particleId);
                    popup.sort();

                    if (i == particleIndex.AsInt() + 1)
                        popup.setSelected(particleId);
                    }

                // Sync up.

                PE_ParticleEditor.loadNewParticle("");
                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionDeleteParticle ts, string simobjectid)
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
            public static bool operator !=(ActionDeleteParticle ts, string simobjectid)
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
            public static implicit operator string(ActionDeleteParticle ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteParticle(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (ActionDeleteParticle) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteParticle));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionDeleteParticle ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionDeleteParticle(int simobjectid)
                {
                return (ActionDeleteParticle) Omni.self.getSimObject((uint) simobjectid, typeof (ActionDeleteParticle));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionDeleteParticle ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionDeleteParticle(uint simobjectid)
                {
                return (ActionDeleteParticle) Omni.self.getSimObject(simobjectid, typeof (ActionDeleteParticle));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionUpdateActiveEmitter.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveEmitter>))]
        public class ActionUpdateActiveEmitter : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimObject emitter = this["emitter"];
                emitter.setFieldValue(this["field"], this["newValue"], -1);

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimObject emitter = this["emitter"];
                emitter.setFieldValue(this["field"], this["oldValue"], -1);

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveEmitter ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveEmitter ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveEmitter ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitter(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveEmitter) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitter));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveEmitter ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitter(int simobjectid)
                {
                return
                    (ActionUpdateActiveEmitter)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveEmitter));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveEmitter ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitter(uint simobjectid)
                {
                return
                    (ActionUpdateActiveEmitter) Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitter));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionUpdateActiveEmitterLifeFields.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------


        //=============================================================================================
        //    ActionUpdateActiveEmitterAmountFields.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveEmitterAmountFields>))]
        public class ActionUpdateActiveEmitterAmountFields : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimObject emitter = this["emitter"];

                emitter["ejectionPeriodMS"] = this["newValueEjectionPeriodMS"];
                emitter["periodVarianceMS"] = this["newValuePeriodVarianceMS"];

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimObject emitter = this["emitter"];

                emitter["ejectionPeriodMS"] = this["oldValueEjectionPeriodMS"];
                emitter["periodVarianceMS"] = this["oldValuePeriodVarianceMS"];

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveEmitterAmountFields ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveEmitterAmountFields ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveEmitterAmountFields ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterAmountFields(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveEmitterAmountFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitterAmountFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveEmitterAmountFields ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterAmountFields(int simobjectid)
                {
                return
                    (ActionUpdateActiveEmitterAmountFields)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveEmitterAmountFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveEmitterAmountFields ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterAmountFields(uint simobjectid)
                {
                return
                    (ActionUpdateActiveEmitterAmountFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitterAmountFields));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveEmitterLifeFields>))]
        public class ActionUpdateActiveEmitterLifeFields : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimObject emitter = this["emitter"];

                emitter["lifetimeMS"] = this["newValueLifetimeMS"];
                emitter["lifetimeVarianceMS"] = this["newValueLifetimeVarianceMS"];

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimObject emitter = this["emitter"];

                emitter["lifetimeMS"] = this["oldValueLifetimeMS"];
                emitter["lifetimeVarianceMS"] = this["oldValueLifetimeVarianceMS"];

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveEmitterLifeFields ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveEmitterLifeFields ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveEmitterLifeFields ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterLifeFields(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveEmitterLifeFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitterLifeFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveEmitterLifeFields ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterLifeFields(int simobjectid)
                {
                return
                    (ActionUpdateActiveEmitterLifeFields)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveEmitterLifeFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveEmitterLifeFields ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterLifeFields(uint simobjectid)
                {
                return
                    (ActionUpdateActiveEmitterLifeFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitterLifeFields));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionUpdateActiveEmitterSpeedFields.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveEmitterSpeedFields>))]
        public class ActionUpdateActiveEmitterSpeedFields : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                SimObject emitter = this["emitter"];

                emitter["ejectionVelocity"] = this["newValueEjectionVelocity"];
                emitter["velocityVariance"] = this["newValueVelocityVariance"];

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                SimObject emitter = this["emitter"];

                emitter["ejectionVelocity"] = this["oldValueEjectionVelocity"];
                emitter["velocityVariance"] = this["oldValueVelocityVariance"];

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveEmitterSpeedFields ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveEmitterSpeedFields ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveEmitterSpeedFields ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterSpeedFields(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveEmitterSpeedFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitterSpeedFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveEmitterSpeedFields ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterSpeedFields(int simobjectid)
                {
                return
                    (ActionUpdateActiveEmitterSpeedFields)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveEmitterSpeedFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveEmitterSpeedFields ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveEmitterSpeedFields(uint simobjectid)
                {
                return
                    (ActionUpdateActiveEmitterSpeedFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveEmitterSpeedFields));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionCreateNewParticle.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------


        //=============================================================================================
        //    ActionUpdateActiveParticle.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveParticle>))]
        public class ActionUpdateActiveParticle : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                //SimObject particle = this["particle"];
                particle.setFieldValue(this["field"], this["newValue"], -1);

                base.redo();
                }

            [ConsoleInteraction]
            public override void undo()
                {
                //SimObject particle = this["particle"];
                particle.setFieldValue(this["field"], this["oldValue"], -1);

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveParticle ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveParticle ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveParticle ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticle(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveParticle)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveParticle));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveParticle ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticle(int simobjectid)
                {
                return
                    (ActionUpdateActiveParticle)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveParticle));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveParticle ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticle(uint simobjectid)
                {
                return
                    (ActionUpdateActiveParticle)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveParticle));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionUpdateActiveParticleLifeFields.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveParticleLifeFields>))]
        public class ActionUpdateActiveParticleLifeFields : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                //SimObject particle = this["particle"];

                particle["lifetimeMS"] = this["newValueLifetimeMS"];
                particle["lifetimeVarianceMS"] = this["newValueLifetimeVarianceMS"];

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                //SimObject particle = this["particle"];

                particle["lifetimeMS"] = this["oldValueLifetimeMS"];
                particle["lifetimeVarianceMS"] = this["oldValueLifetimeVarianceMS"];

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveParticleLifeFields ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveParticleLifeFields ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveParticleLifeFields ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticleLifeFields(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveParticleLifeFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveParticleLifeFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveParticleLifeFields ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticleLifeFields(int simobjectid)
                {
                return
                    (ActionUpdateActiveParticleLifeFields)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveParticleLifeFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveParticleLifeFields ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticleLifeFields(uint simobjectid)
                {
                return
                    (ActionUpdateActiveParticleLifeFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveParticleLifeFields));
                }

            #endregion
            }


        //=============================================================================================
        //    ActionUpdateActiveParticleSpinFields.
        //=============================================================================================

        //---------------------------------------------------------------------------------------------
        [TypeConverter(typeof (TypeConverterGeneric<ActionUpdateActiveParticleSpinFields>))]
        public class ActionUpdateActiveParticleSpinFields : BaseParticleEdAction
            {
            [ConsoleInteraction]
            public override void redo()
                {
                //SimObject particle = this["particle"];

                particle["spinRandomMax"] = this["newValueSpinRandomMax"];
                particle["spinRandomMin"] = this["newValueSpinRandomMin"];

                base.redo();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                //SimObject particle = this["particle"];

                particle["spinRandomMax"] = this["oldValueSpinRandomMax"];
                particle["spinRandomMin"] = this["oldValueSpinRandomMin"];

                base.undo();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ActionUpdateActiveParticleSpinFields ts, string simobjectid)
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
            public static bool operator !=(ActionUpdateActiveParticleSpinFields ts, string simobjectid)
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
            public static implicit operator string(ActionUpdateActiveParticleSpinFields ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticleSpinFields(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (ActionUpdateActiveParticleSpinFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveParticleSpinFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ActionUpdateActiveParticleSpinFields ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticleSpinFields(int simobjectid)
                {
                return
                    (ActionUpdateActiveParticleSpinFields)
                        Omni.self.getSimObject((uint) simobjectid, typeof (ActionUpdateActiveParticleSpinFields));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ActionUpdateActiveParticleSpinFields ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ActionUpdateActiveParticleSpinFields(uint simobjectid)
                {
                return
                    (ActionUpdateActiveParticleSpinFields)
                        Omni.self.getSimObject(simobjectid, typeof (ActionUpdateActiveParticleSpinFields));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<BaseParticleEdAction>))]
        public class BaseParticleEdAction : UndoScriptAction
            {
            public SimObject particle
            {
                get
                {
                    return this["particle"];
                }
                set
                {
                    this["particle"] = value;
                }
            }
            [ConsoleInteraction]
            public void sync()
                {
                ParticleParticleEditor.PE_ParticleEditor PE_ParticleEditor = "PE_ParticleEditor";
                ParticleEmitterEditor.PE_EmitterEditor PE_EmitterEditor = "PE_EmitterEditor";

                // Sync particle state.

                if (particle.isObject())
                    {
                    particle.call("reload");
                    PE_ParticleEditor.guiSync();

                    if (particle.getId() == PE_ParticleEditor.currParticle.getId())
                        PE_ParticleEditor.setParticleDirty();
                    }

                // Sync emitter state.

                if (this["emitter"].isObject())
                    {
                    this["emitter"].call("reload");

                    PE_EmitterEditor.guiSync();

                    if (this["emitter"].getID() == PE_EmitterEditor.currEmitter.getId())
                        PE_EmitterEditor.setEmitterDirty();
                    }
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void redo()
                {
                this.sync();
                }

            //---------------------------------------------------------------------------------------------
            [ConsoleInteraction]
            public override void undo()
                {
                this.sync();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(BaseParticleEdAction ts, string simobjectid)
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
            public static bool operator !=(BaseParticleEdAction ts, string simobjectid)
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
            public static implicit operator string(BaseParticleEdAction ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator BaseParticleEdAction(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (BaseParticleEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseParticleEdAction));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(BaseParticleEdAction ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator BaseParticleEdAction(int simobjectid)
                {
                return (BaseParticleEdAction) Omni.self.getSimObject((uint) simobjectid, typeof (BaseParticleEdAction));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(BaseParticleEdAction ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator BaseParticleEdAction(uint simobjectid)
                {
                return (BaseParticleEdAction) Omni.self.getSimObject(simobjectid, typeof (BaseParticleEdAction));
                }

            #endregion
            }
        }
    }