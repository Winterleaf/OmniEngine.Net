using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeParticleEditor()
            {
            Omni.self.Print(" % - Initializing Particle Editor");
            gui.ParticleEditor.initialize();
            ParticleEmitterEditor.initialize();
            ParticleParticleEditor.initialize();
            GuiWindowCollapseCtrl pe_Window = "PE_Window";

            pe_Window.setVisible(false);
            EditorGui EditorGui = "EditorGui";
            EditorGui.add("PE_Window");

            ObjectCreator oParticleEditorPlugin = new ObjectCreator("ScriptObject", "ParticleEditorPlugin",
                typeof (
                    WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind.ParticleEditorPlugin));
            oParticleEditorPlugin["editorGui"] = "EWorldEditor";
            oParticleEditorPlugin.Create();

            ParticleEditorPlugin ParticleEditorPlugin = "ParticleEditorPlugin";

            ParticleEditorPlugin.initialize();
            }

        [ConsoleInteraction]
        public static void destroyParticleEditor()
            {
            }
        }
    }