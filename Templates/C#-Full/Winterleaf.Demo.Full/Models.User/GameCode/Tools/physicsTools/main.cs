using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.physicsTools
    {
    public class main
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void initializePhysicsTools()
            {
            Omni.self.Print(" % - Initializing Physics Tools");

            if (!omni.Util.physicsPluginPresent())
                {
                omni.Util._echo("No physics plugin exists.");
                return;
                }
            ActionMap globalactionmap = "globalactionmap";

            globalactionmap.bindCmd("keyboard", "alt t", "physicsToggleSimulation();", "");
            globalactionmap.bindCmd("keyboard", "alt r", "physicsRestoreState();", "");

            ObjectCreator o = new ObjectCreator("ScriptObject", "PhysicsEditorPlugin", typeof (PhysicsEditorPlugin));
            o["editorGui"] = "EWorldEditor";
            o.Create();
            }

        [ConsoleInteraction]
        public static void destroyPhysicsTools()
            {
            }

        [ConsoleInteraction]
        public static void physicsToggleSimulation()
            {
            bool isEnabled = omni.Util.physicsSimulationEnabled();
            if (isEnabled)
                {
                // physicsStateText.setText("Simulation is paused.");
                omni.Util._echo("Simulation is paused.");
                omni.Util.physicsStopSimulation("client");
                omni.Util.physicsStopSimulation("server");
                }
            else
                {
                omni.Util._echo("Simulation is unpaused.");
                omni.Util.physicsStartSimulation("client");
                omni.Util.physicsStartSimulation("server");
                }
            }
        }
    }