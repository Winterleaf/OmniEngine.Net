#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class AITurretShapeData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            base.onAdd(obj);
            obj["mountable"] = false.AsString();
            }

        public override int onThrow(ShapeBase player, int amount)
            {
            if (amount == 0)
                amount = 1;

            if (this["maxInventory"] != string.Empty)
                if (amount > this["maxInventory"].AsInt())
                    amount = this["maxInventory"].AsInt();

            if (amount == 0)
                return 0;

            player.decInventory(this, amount);
            TransformF rot = new TransformF(player.getEulerRotation());

            ObjectCreator tc_obj = new ObjectCreator("AITurretShape", string.Empty);
            tc_obj["datablock"] = this.getName();
            tc_obj["rotation"] = "0 0 1 " + rot.mPositionZ;
            tc_obj["count"] = "1";
            tc_obj["sourceObject"] = player;
            tc_obj["client"] = player["client"];
            tc_obj["isAiControlled"] = true;

            AITurretShape obj = tc_obj.Create();
            ((SimSet) "MissionGroup").pushToBack(obj);

            //todo change to csharp
            obj.addToIgnoreList(player);


            GameConnection client = player["client"];
            if (client.isObject())
                {
                if (client["ownedTurrets"] == string.Empty)
                    client["ownedTurrets"] = new ObjectCreator("SimSet", string.Empty).Create().AsString();

                SimSet SimSet_id = client["ownedTurrets"];
                int countofitems = SimSet_id.getCount();
                for (uint i = 0; i < countofitems; i++)
                    {
                    AITurretShape turret = SimSet_id.getObject(i);
                    turret.addToIgnoreList(obj);
                    obj.addToIgnoreList(turret);
                    }
                SimSet_id.pushToBack(obj);
                }

            return obj;
            }

        public override void onDestroyed(ShapeBase obj, string lastState)
            {
            AITurretShape aits = obj._ID;
            aits.playAudio(0, "TurretDestroyed");
            aits.setAllGunsFiring(false);
            aits.resetTarget();
            aits.setTurretState("Destroyed", false);


            for (int i = 0; i < this["numWeaponMountPoints"].AsInt(); i++)
                aits.setImageGenericTrigger(i, 0, true);

            base.onDestroyed(obj, lastState);
            }

        [ConsoleInteraction(true)]
        public virtual void onScanning(AITurretShape turret)
            {
            turret.startScanForTargets();
            turret.playAudio(0, "TurretScanningSound");
            }

        [ConsoleInteraction(true)]
        public virtual void onTarget(AITurretShape turret)
            {
            turret.startTrackingTarget();
            turret.playAudio(0, "TargetAquiredSound");
            }

        [ConsoleInteraction(true)]
        public virtual void onNoTarget(AITurretShape turret)
            {
            turret.setAllGunsFiring(false);
            turret.recenterTurret();
            turret.playAudio(0, "TargetLostSound");
            }

        [ConsoleInteraction(true)]
        public virtual void onFiring(AITurretShape turret)
            {
            turret.setAllGunsFiring(true);
            }

        [ConsoleInteraction(true)]
        public virtual void onThrown(AITurretShape turret)
            {
            turret.playAudio(0, "TurretThrown");
            }

        [ConsoleInteraction(true)]
        public virtual void onDeploy(AITurretShape turret)
            {
            for (int i = 0; i < this["numWeaponMountPoints"].AsInt(); i++)
                turret.setImageLoaded(i, true);

            turret.playAudio(0, "TurretActivatedSound");
            }
        }
    }