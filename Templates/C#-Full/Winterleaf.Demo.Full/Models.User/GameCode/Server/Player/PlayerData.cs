#region

using System;
using System.Collections.Generic;
using WinterLeaf.Demo.Full.Models.User.CustomObjects;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using message = WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities.message;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    public partial class PlayerData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            Player player = obj.getId();
            player["mountVehicle"] = true.AsString();
            player.setRechargeRate(this["rechargeRate"].AsFloat());
            player.setRepairRate(0);
            }

        public override void onRemove(GameBase obj)
            {
            Player player = obj.getId();
            if (player["client.player"] == player)
                player["client.player"] = "0";
            }

        public override void onMount(GameBase obj, SceneObject mountObj, int node)
            {
            Player player = obj.getId();
            VehicleData vehicleDataBlock = mountObj.getDataBlock();
            if (node == 0)
                {
                player.setTransform(new TransformF("0 0 0 0 0 1 0"));
                string mountPose = vehicleDataBlock["mountPose[" + node + "]"];
                player.setActionThread(mountPose, true, true);
                player["lastWeapon"] = player.getMountedImage(Constants.WeaponSlot).AsString();
                GameConnection client = player["client"];
                if (client.isObject())
                    player["lastperson"] = client.isFirstPerson().AsString();
                player.unmountImage(Constants.WeaponSlot);
                player.setControlObject(mountObj);
                if (player.getClassName() == "Player")
                    console.commandToClient(player["client"], console.addTaggedString("toggleVehicleMapToggle"),
                        new[] { "true" });
                }
            else
                {
                string pose = vehicleDataBlock["mountPose[" + node + "]"];
                player.setActionThread(pose != string.Empty ? pose : "root", false, true);
                }
            }

        public override void onUnmount(GameBase obj, SceneObject mountObj, int node)
            {
            Player player = obj.getId();
            if (node != 0)
                return;

            player.mountImage(player["lastWeapon"], Constants.WeaponSlot, true, string.Empty);
            player.setControlObject(string.Empty);

            if (!player["lastperson"].AsBool())
                return;

            GameConnection client = player["client"];
            if (client.isObject())
                client.setFirstPerson(player["lastperson"].AsBool());
            }

        public override void doDismount(Player obj)
            {
            Player player = obj.getId();

            Vehicle vehicle = player["mVehicle"];
            if (!vehicle.isObject())
                return;
            if (!player.isMounted())
                return;


            Point3F vvel = vehicle.getVelocity();
            VehicleData vdb = vehicle.getDataBlock();
            int maxDismountSpeed = vdb["maxDismountSpeed"].AsInt();
            if ((vvel.len() <= maxDismountSpeed)) //|| (forced))
                {
                TransformF pos = player.getTransform();
                TransformF rot = pos;
                TransformF oldpos = pos.copy();

                List<Point3F> vecs = new List<Point3F>
                    {
                    new Point3F(-1, 0, 0),
                    new Point3F(0, 0, 1),
                    new Point3F(0, 0, -1),
                    new Point3F(1, 0, 0),
                    new Point3F(0, -1, 0),
                    new Point3F(0, 0, 0)
                    };

                Point3F impulsevec = new Point3F(0, 0, 0);


                TransformF r = math.MatrixMulVector(player.getTransform(), vecs[0]);

                vecs[0] = r.GetPosition();
                pos.mPositionX = 0;
                pos.mPositionY = 0;
                pos.mPositionZ = 0;

                const int numofAttempts = 5;
                int success = -1;

                for (int i = 0; i < numofAttempts; i++)
                    {
                    Point3F vectorscale = vecs[i].vectorScale(3);

                    pos = oldpos + new TransformF(vectorscale);
                    if (!player.checkDismountPoint(oldpos.GetPosition(), pos.GetPosition()))
                        continue;
                    success = i;
                    impulsevec = vecs[i].copy();
                    break;
                    }
                //if ((forced) && (success == -1))
                if (success == -1)
                    pos = oldpos.copy();

                player["mountVehicle"] = false.AsString();
                player.schedule("4000", "mountVehicles", "true");
                player.unmount();
                player.setTransform(new TransformF(pos.mPositionX, pos.mPositionY, pos.mPositionZ, rot.mOrientationX,
                    rot.mOrientationY, rot.mOrientationZ, rot.MAngle));


                Point3F velo = impulsevec.vectorScale(player["mass"].AsFloat());
                velo.z = 1;

                player.applyImpulse(pos.GetPosition(), velo);


                Point3F vel = player.getVelocity();
                float vec = Point3F.vectorDot(vel, vel.normalizeSafe());
                if (vec > 50)
                    {
                    float scale = 50 / vec;
                    player.setVelocity(vel.vectorScale(scale));
                    }
                }
            else
                {
                message.MessageClient(player["client"], "msgUnmount", @"\c2Cannot exit %1 while moving.",
                    console.GetVarString(vdb + ".nameTag"));
                }
            }

        public override void onCollision(ShapeBase obj, SceneObject col, Point3F vec, float len)
            {
            Player player = obj.getId();
            if (player.getState() == "Dead")
                return;
            // Try and pickup all items
            if (col.getClassName() == "Item")
                {
                player.pickup(col.ID, 1);
                return;
                }

            if (col.GetType() != typeof(WheeledVehicle))
                return;

            WheeledVehicle vcol = (WheeledVehicle)col;

            //AI are not allowed to drive they are lousey drivers....
            GameConnection client = player["client"];

            if (!client.isObject())
                return;
            //Mount Vehicle.
            if ((console.getTypeMask(col) & (UInt32)SceneObjectTypesAsUint.GameBaseObjectType) !=
                (UInt32)SceneObjectTypesAsUint.GameBaseObjectType)
                return;
            VehicleData db = vcol.getDataBlock();
            if (
                !(((db.getClassName() == "WheeledVehicleData") || player["mountVehicle"].AsBool() ||
                   player.getState() == "Move" || col["mountable"].AsBool())))
                return;
            // Only mount drivers for now.

            // For this specific example, only one person can fit
            // into a vehicle
            int mount = vcol.getMountNodeObject(0);

            if (mount > 0)
                {
                try
                    {
                    Player p = mount;
                    return;
                    }
                catch (Exception err)
                    {
                    //Water particle emitters seem to take up the seat when the vehicle is in water.
                    vcol.unmountObject(mount.AsString());
                    vcol.mountObject(player, 0, new TransformF());
                    ((GameConnection)player["client"]).setFirstPerson(false);
                    console.commandToClient(client, "PushVehicleMap");
                    }
                }
            else
                {
                vcol.mountObject(player, 0, new TransformF());
                ((GameConnection)player["client"]).setFirstPerson(false);
                console.commandToClient(client, "PushVehicleMap");
                }
            //if (mount > 0)
            //return;
            // For this specific FPS Example, always mount the player to node 0

            player["mVehicle"] = col;
            }

        public override void onImpact(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
            {
            Player player = obj.getId();
            TransformF p = player.getTransform() + new TransformF(vec);

            float speedDamageScale = len + this["speedDamageScale"].AsFloat();
            //Do not confuse the player.event_damage with the PlayerData.event_damage...
            player.damage(0, p.GetPosition(), speedDamageScale, "Impact");
            }


        public override void damage(ShapeBase obj, Point3F position, GameBase sourceobject, float damage,
            string damagetype)
            {
            Player pobj = obj._ID;

            if (!pobj.isObject() || pobj.getState() == "Dead" || !damage.AsBool())
                return;

            obj.applyDamage(damage);

            GameConnection client = obj["client"];

            if (!client.isObject())
                return;
            if (damagetype != "Suicide")
                pobj.setDamageDirection(sourceobject, new TransformF(position));

            if (pobj.getState() == "Dead")
                client.onDeath(sourceobject, sourceobject["client"].isObject() ? sourceobject["client"] : "0",
                    damagetype, "Body");
            }

        public override void onDamage(ShapeBase obj, float delta)
            {
            Player player = obj.getId();
            // This method is invoked by the ShapeBase code whenever the
            // object's damage level changes.
            if ((delta <= 0) || player.getState() == "Dead")
                return;
            // Apply a damage flash
            player.setDamageFlash(1);
            // If the pain is excessive, let's hear about it.
            if (delta > 10)
                player.playPain();
            }

        public override void onDisabled(ShapeBase obj, string lastState)
            {
            Player player = obj.getId();
            player.setImageTrigger(0, false);
            GameBaseData item = (((GameBaseData)(player.getMountedImage(Constants.WeaponSlot)))["item"]);

            if (item.isObject())
                {
                int amount = player.getInventory(item["image.ammo"]);

                if (amount.AsBool())
                    player.Throw(item["image.clip"], 1);
                }
            player.tossPatch();
            player.playDeathCry();
            player.playDeathAnimation();


            //If it's a player check.....
            GameConnection client = player["client"];


            if (client.isObject())
                //todo Remove the console.commandToClient since the default one now shows in the Util class.
                console.commandToClient(client, console.addTaggedString("toggleVehicleMapToggle"), new[] { "false" });
            //Util._commandToClient(client, "toggleVehicleMap", false.AsString());

            int ctov = iGlobal["$CorpseTimeoutValue"];

            player.schedule((ctov - 1000).AsString(), "startFade", "1000", "0", "true");
            player.schedule(ctov.AsString(), "delete");
            }

        public override void onLeaveMissionArea(Player obj)
            {
            ((GameConnection)obj["client"]).onLeaveMissionArea();
            }

        public override void onEnterMissionArea(Player obj)
            {
            ((GameConnection)obj["client"]).onEnterMissionArea();
            }

        public override void onEnterLiquid(Player obj, float coverage, string type)
            {
            }

        public override void onLeaveLiquid(Player obj, string type)
            {
            }

        public override void onTrigger(ShapeBase obj, int index, bool state)
            {
            // This method is invoked when the player receives a trigger move event.
            // The player automatically triggers slot 0 and slot one off of triggers #
            // 0 & 1.  Trigger # 2 is also used as the jump key.
            }

        public override void onPoseChange(Player obj, string oldPose, string newPose)
            {
            obj.setImageScriptAnimPrefix(Constants.WeaponSlot, Util.addTaggedString(newPose));
            }

        public override void onStartSprintMotion(Player obj)
            {
            obj.setImageGenericTrigger(Constants.WeaponSlot, 0, true);
            }

        public override void onStopSprintMotion(Player obj)
            {
            obj.setImageGenericTrigger(Constants.WeaponSlot, 0, false);
            }
        }
    }