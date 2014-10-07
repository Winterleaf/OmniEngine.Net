using WinterLeaf.Demo.Full.Models.User.GameCode;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class lighting
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true)]
        public static void initLightingSystems()
            {
            omni.console.print("\n--------- Initializing Lighting Systems ---------");

            omni.console.print("\n--------- Initializing Advanced Lighting ---------");
            Lighting.advanced.init.initialize();

            omni.console.print("\n--------- Initializing Basic Lighting ---------");
            Lighting.basic.init.initialize();

            omni.console.print("\n--------- Initializing ShadowMaps Lighting ---------");
            Lighting.shadowMaps.init.initialize();

            omni.console.print("\n--------- Finished Initializing Advanced Lighting ---------");

            // Try the perfered one first.
            bool success = omni.Util.setLightManager(omni.sGlobal["$pref::lightManager"]);
            if (!success)
                {
                // The perfered one fell thru... so go thru the default
                // light managers until we find one that works.
                int lmCount = omni.Util.getFieldCount(omni.sGlobal["$lightManager::defaults"]);
                for (int i = 0; i < lmCount; i++)
                    {
                    string lmName = omni.Util.getField(omni.sGlobal["$lightManager::defaults"], i);
                    success = omni.Util.setLightManager(lmName);
                    if (success)
                        break;
                    }
                }
            // Did we completely fail to initialize a light manager?
            if (!success)
                {
                // If we completely failed to initialize a light 
                // manager then the 3d scene cannot be rendered.
                //t3d.Util.quitWithErrorMessage("Failed to set a light manager!");
                Main.quitWithErrorMessage("Failed to set a light manager!");
                }
            omni.console.print("\n");
            }

        [ConsoleInteraction(true)]
        public static void onLightManagerActivate(string lmName)
            {
            omni.sGlobal["$pref::lightManager"] = lmName;
            omni.console.print("Using " + lmName);

            string activateNewFn = "onActivate" + lmName.Split(' ')[0] + "LM";
            if (omni.console.isFunction(activateNewFn))
                omni.console.Call(activateNewFn);
            }

        [ConsoleInteraction(true)]
        public static void onLightManagerDeactivate(string lmName)
            {
            string deactivateOldfn = "onDeactivate" + lmName.Split(' ')[0] + "LM";
            if (omni.console.isFunction(deactivateOldfn))
                omni.console.Call(deactivateOldfn);
            }
        }
    }