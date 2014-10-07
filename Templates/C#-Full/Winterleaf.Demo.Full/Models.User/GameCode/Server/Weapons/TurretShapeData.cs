#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class TurretShapeData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            ShapeBase sbobj = obj._ID;
            sbobj.setRechargeRate(this["rechargeRate"].AsFloat());
            sbobj.setEnergyLevel(this["MaxEnergy"].AsFloat());
            sbobj.setRepairRate(0);


            if (obj["mountable"] == "1" || obj["mountable"] == string.Empty)
                this.isMountable((TurretShape) sbobj, true.AsString());
            else
                this.isMountable((TurretShape) sbobj, false.AsString());

            if (this["nameTag"] != string.Empty)
                sbobj.setShapeName(this["nameTag"]);
            for (int i = 0; i < this["numWeaponMountPoints"].AsInt(); i++)
                {
                sbobj.incInventory(this["weapon[" + i + "]"], 1);
                ItemData weaponAmmo = this["weaponAmmo[" + i + "]"];
                string weaponAmmoAmount = this["weaponAmmoAmount[" + i + "]"];
                sbobj.incInventory(weaponAmmo, weaponAmmoAmount.AsInt());
                bool startLoaded = this["startLoaded"].AsBool();
                sbobj.mountImage(this["weapon[" + i + "].Image"], i, startLoaded, string.Empty);
                sbobj.setImageGenericTrigger(i, 0, false);
                }
            if (this["enterSequence"] != string.Empty)
                {
                obj["entranceThread"] = "0";
                int et = obj["entranceThread"].AsInt();
                string es = this["enterSequence"];
                sbobj.playThread(et, es);
                sbobj.pauseThread(et);
                }
            else
                {
                obj["entranceThread"] = "-1";
                }
            }

        public override void onRemove(GameBase obj)
            {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                if (obj.getMountNodeObject(i) == 0)
                    continue;

                Player passenger = obj.getMountNodeObject(i).AsString();

                //change to csharp
                ((TurretShapeData) passenger.getDataBlock()).call("doDismount", true.AsString());
                }
            }

        public override void damage(ShapeBase obj, Point3F position, GameBase source, float damage,
            string damagetype)
            {
            if (obj.getDamageState() == "Dead")
                return;

            obj.applyDamage(damage);

            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                Player player = obj.getMountNodeObject(i);
                if (player != 0)
                    player.damage(source, position, 10000.0f, "");
                }
            }

        public override void onDamage(ShapeBase obj, float delta)
            {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage level changes.
            }

        public override void onDestroyed(ShapeBase obj, string lastState)
            {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage state changes.

            // Fade out the destroyed object.  Then schedule a return.
            int destroydelay = iGlobal["$TurretShape::DestroyedFadeDelay"];
            obj.startFade(1000, destroydelay, true);

            obj.schedule((destroydelay + 1000).AsString(), "delete");

            TurretShape ts = obj.ID;
            if (ts.doRespawn())
                ((SimSet) "MissionGroup").schedule(sGlobal["$TurretShape::RespawnTime"], "respawnTurret", this,
                    console.GetClassName(obj), obj.getTransform().AsString(), true.AsString(), true.AsString());
            }


        public override void onDisabled(ShapeBase obj, string lastState)
            {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage state changes.
            }

        public override void onEnabled(ShapeBase obj, string lastState)
            {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage state changes.
            }

        public override void onMount(GameBase obj, SceneObject mountObj, int node)
            {
            //todo change to csharp
            ((GameConnection) mountObj["client"]).call("RefreshVehicleHud", obj, this["reticle"], this["zoomReticle"]);
            }

        public override void onUnmount(GameBase obj, SceneObject mountObj, int node)
            {
            //todo change to csharp
            mountObj.call("RefreshVehicleHud", "0", string.Empty, string.Empty);
            }

        [ConsoleInteraction(true)]
        public virtual void isMountable(TurretShape obj, string val)
            {
            obj["mountable"] = val;
            }

        [ConsoleInteraction(true)]
        public virtual void onMountObject(TurretShape turret, ShapeBase player, int node)
            {
            if (turret["entranceThread"].AsInt() < 0)
                return;

            int et = turret["entranceThread"].AsInt();

            turret.setThreadDir(et, false);
            turret.setThreadPosition(et, 0);
            turret.playThread(et, string.Empty);
            }

        [ConsoleInteraction(true)]
        public virtual void onUnmountObject(TurretShape turret, ShapeBase player)
            {
            if (turret["entranceThread"].AsInt() < 0)
                return;

            int et = turret["entranceThread"].AsInt();

            // Play the entrance thread backwards for an exit

            turret.setThreadDir(et, false);
            turret.setThreadPosition(et, (float) 1.0);
            turret.playThread(et, string.Empty);
            }

        [ConsoleInteraction(true)]
        public virtual void mountPlayer(TurretShape turret, ShapeBase player)
            {
            if (turret.isObject() && turret.getDamageState() != "Destroyed")
                //todo change to csharp

                turret.call("setMountTurret", player);
            }

        [ConsoleInteraction(true)]
        public virtual void setMountTurret(TurretShape turret, ShapeBase player)
            {
            if (!turret.isObject() || turret.getDamageState() == "Destroyed")
                return;

            //todo convert to csharp
            int node = call("findEmptySeat", turret, player).AsInt();
            if (node < 0)
                return;
            turret.mountObject(player, node, new TransformF("0 0 0"));

            player["mVehicle"] = turret;
            }

        [ConsoleInteraction(true)]
        public virtual int findEmptySeat(TurretShape turret, ShapeBase player)
            {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                int node = turret.getMountNodeObject(i);
                if (node == 0)
                    return i;
                }
            return -1;
            }

        [ConsoleInteraction(true)]
        public virtual int switchSeats(TurretShape turret, ShapeBase player)
            {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                int node = turret.getMountNodeObject(i);
                if (node == player || node != 0)
                    continue;
                if (node == 0)
                    return i;
                }
            return -1;
            }
        }
    }