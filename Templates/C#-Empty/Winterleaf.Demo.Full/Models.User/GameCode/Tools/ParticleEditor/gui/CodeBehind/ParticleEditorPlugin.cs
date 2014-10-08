using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<ParticleEditorPlugin>))]
    public class ParticleEditorPlugin : WorldEditorPlugin
        {
        internal ActionMap map
            {
            get { return this["map"]; }
            set { this["map"] = value; }
            }

        [ConsoleInteraction]
        public void initialize()
            {
            ActionMap map = new ObjectCreator("ActionMap").Create();
            map.bindCmd("keyboard", "1", "EWorldEditorNoneModeBtn.performClick();", ""); // Select
            map.bindCmd("keyboard", "2", "EWorldEditorMoveModeBtn.performClick();", ""); // Move
            map.bindCmd("keyboard", "3", "EWorldEditorRotateModeBtn.performClick();", ""); // Rotate
            map.bindCmd("keyboard", "4", "EWorldEditorScaleModeBtn.performClick();", ""); // Scale

            this.map = map;

            new ObjectCreator("ScriptObject", "ParticleEditor", typeof (ParticleEditor)).Create();

            new ObjectCreator("PersistenceManager", "PE_EmitterSaver").Create();
            new ObjectCreator("PersistenceManager", "PE_ParticleSaver").Create();

            new ObjectCreator("SimSet", "PE_UnlistedParticles").Create();
            new ObjectCreator("SimSet", "PE_UnlistedEmitters").Create();
            }

        [ConsoleInteraction]
        public override void onWorldEditorStartup()
            {
            EditorGui EditorGui = "EditorGui";

            // Add ourselves to the window menu.
            string accel = EditorGui.addToEditorsMenu("Particle Editor", "", this);

            // Add ourselves to the ToolsToolbar
            string tooltip = "Particle Editor (" + accel + ")";
            EditorGui.addToToolsToolbar("ParticleEditorPlugin", "ParticleEditorPalette",
                Util._expandFilename("tools/worldEditor/images/toolbar/particleeditor"), tooltip);
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onActivated()
            {
            ParticleEditor ParticleEditor = "ParticleEditor";
            EditorGui EditorGui = "EditorGui";
            EditorGui.EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            ParticleEditor.PE_Window PE_Window = "PE_Window";

            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            this["isActive"] = true.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!ParticleEditor["isInitialized"].AsBool())
                {
                ParticleEditor.initEditor();
                ParticleEditor["isInitialized"] = true.AsString();
                }

            WorldEditorToolbar.setVisible(true);
            EditorGui.bringToFront(PE_Window);
            PE_Window.setVisible(true);
            PE_Window.makeFirstResponder(true);

            this.map.push();

            ParticleEditor.resetEmitterNode();

            // Set the status bar here
            EditorGuiStatusBar.setInfo("Particle editor.");
            EditorGuiStatusBar.setSelection("");

            base.onActivated();
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onDeactivated()
            {
            EditorGui EditorGui = "EditorGui";
            ParticleEditor.PE_Window PE_Window = "PE_Window";

            GuiControl WorldEditorToolbar = EditorGui.FOT("WorldEditorToolbar");

            //Copyright Winterleaf Entertainment L.L.C. 2013
            if (!this["isActive"].AsBool())
                return;
            this["isActive"] = false.AsString();
            //Copyright Winterleaf Entertainment L.L.C. 2013  
            WorldEditorToolbar.setVisible(false);
            PE_Window.setVisible(false);

            if (sGlobal["$ParticleEditor::emitterNode"].isObject())
                sGlobal["$ParticleEditor::emitterNode"].delete();

            this.map.pop();

            base.onDeactivated();
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public override void onExitMission()
            {
            ParticleEditor ParticleEditor = "ParticleEditor";

            // Force Particle Editor to re-initialize.
            ParticleEditor["isInitialized"] = false.AsString();

            base.onExitMission();
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void initSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("ParticleEditor", true);

            EditorSettings.setDefaultValue("selectedTab", "0");

            EditorSettings.endGroup();
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void readSettings()
            {
            Settings EditorSettings = "EditorSettings";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
            ParticleEditor.PE_TabBook PE_TabBook = "PE_TabBook";
            GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";

            EditorSettings.beginGroup("ParticleEditor", true);

            string selectedEmitter = EditorSettings.value("selectedEmitter");
            if (selectedEmitter.isObject())
                PEE_EmitterSelector.setSelected(selectedEmitter.getID());

            string selectedParticle = EditorSettings.value("selectedParticle");
            if (selectedParticle.isObject())
                PEP_ParticleSelector.setSelected(selectedParticle.getID());

            PE_TabBook.selectPage(EditorSettings.value("selectedPage").AsInt());

            EditorSettings.endGroup();
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void writeSettings()
            {
            Settings EditorSettings = "EditorSettings";
            GuiPopUpMenuCtrl PEE_EmitterSelector = "PEE_EmitterSelector";
            ParticleEditor.PE_TabBook PE_TabBook = "PE_TabBook";
            GuiPopUpMenuCtrl PEP_ParticleSelector = "PEP_ParticleSelector";

            EditorSettings.beginGroup("ParticleEditor", true);

            EditorSettings.setValue("selectedEmitter", PEE_EmitterSelector.getText());
            EditorSettings.setValue("selectedParticle", PEP_ParticleSelector.getText());
            EditorSettings.setValue("selectedTab", PE_TabBook.getSelectedPage().AsString());

            EditorSettings.endGroup();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ParticleEditorPlugin ts, string simobjectid)
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
        public static bool operator !=(ParticleEditorPlugin ts, string simobjectid)
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
        public static implicit operator string(ParticleEditorPlugin ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ParticleEditorPlugin(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ParticleEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ParticleEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ParticleEditorPlugin ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleEditorPlugin(int simobjectid)
            {
            return (ParticleEditorPlugin) Omni.self.getSimObject((uint) simobjectid, typeof (ParticleEditorPlugin));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ParticleEditorPlugin ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleEditorPlugin(uint simobjectid)
            {
            return (ParticleEditorPlugin) Omni.self.getSimObject(simobjectid, typeof (ParticleEditorPlugin));
            }

        #endregion
        }
    }