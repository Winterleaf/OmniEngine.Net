using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class devHelpers
        {
        private static readonly pInvokes omni = new pInvokes();

        /// Shortcut for typing dbgSetParameters with the default values torsion uses.
        public static void dbgTorsion()
            {
            omni.console.Call("dbgSetParameters", new string[] {"6060", "password", "false"});
            }

        // Reset the input state to a default of all-keys-up.
        // A helpful remedy for when Torque misses a button up event do to your breakpoints
        // and can't stop shooting / jumping / strafing.
        public static void mvReset()
            {
            //         for ( %i = 0; %i < 6; %i++ )
            //setVariable( "mvTriggerCount" @ %i, 0 );
            for (int i = 0; i < 6; i++)
                omni.iGlobal["mvTriggerCount" + i] = 0;

            omni.iGlobal["$mvUpAction"] = 0;
            omni.iGlobal["$mvDownAction"] = 0;
            omni.iGlobal["$mvLeftAction"] = 0;
            omni.iGlobal["$mvRightAction"] = 0;
            }
        }
    }