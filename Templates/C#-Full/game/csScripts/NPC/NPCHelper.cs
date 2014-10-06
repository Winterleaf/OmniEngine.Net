using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.CustomObjects.Scripted.AI
    {
    class NPCHelper
        {
        public static readonly pInvokes omni = new pInvokes();
        private static readonly Random r = new Random();

        [ConsoleInteraction]
        public static void SpawnCustomDemoPlayer()
            {
            CustomDemoPlayer aiPlayer = SpawnOnPath("MyCustomNPC", "MissionGroup/Paths/team1Path");
            if (aiPlayer == null)
                {
                omni.console.error("UNABLE TO SPAWN MONSTER!@!!!!!a");
                return;
                }
            if (!omni.console.isObject(aiPlayer))
                {
                omni.console.error("UNABLE TO SPAWN MONSTER!@!!!!!");
                return;
                }


            aiPlayer.FollowPath("MissionGroup/Paths/team1Path", 0);
            aiPlayer.setMoveSpeed(0.8f);

            aiPlayer.setInventory("Lurker", 1);
            aiPlayer.setInventory("LurkerClip", 1000);
            aiPlayer.setInventory("LurkerAmmo", 1000);
            aiPlayer.setInventory("LurkerGrenadeLauncher", 1);
            aiPlayer.setInventory("LurkerGrenadeAmmo", 10);
            aiPlayer.setInventory("ProxMine", 5);
            aiPlayer.setInventory("DeployableTurret", 5);

            aiPlayer.mountImage("LurkerWeaponImage", 0, true, "");


            TransformF t = aiPlayer.getTransform();
            t.mPositionZ += r.Next(0, 200);
            aiPlayer.setTransform(t);
            aiPlayer.Think();
            }

        public static CustomDemoPlayer SpawnOnPath(string ainame, SimSet path)
            {
            if (!omni.console.isObject(path))
                return null;

            Marker node = path.getObject((uint)r.Next(0, path.getCount() - 1));

            TransformF transform = node.getTransform();
            return Spawn(ainame, transform);
            }

        public static UInt32 Spawn(string name, TransformF spawnpoint)
            {
            ObjectCreator npcScriptObject = new ObjectCreator("AIPlayer", "", typeof(CustomDemoPlayer));
            npcScriptObject["dataBlock"] = "DemoPlayer";
            npcScriptObject["path"] = "";
            AIPlayer npc = npcScriptObject.Create();
            if (npc != 0)
                {
                ((SimSet)"MissionCleanup").pushToBack(npc);
                npc.setShapeName(name);
                npc.setTransform(spawnpoint);
                }

            return npc;
            }

        }
    }
