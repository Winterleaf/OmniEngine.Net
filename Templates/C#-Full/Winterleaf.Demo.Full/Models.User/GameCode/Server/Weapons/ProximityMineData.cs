#region

using System;
using WinterLeaf.Demo.Full.Models.User.CustomObjects;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class ProximityMineData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        /*note In torquescript they used a classname call to the weapon class to perform
         * the onPickUp and onUse.  Unfortunately, we don't have that ability in CSharp.
         */

        public override bool onPickup(Item obj, ShapeBase user, int amount)
            {
            if (!base.onPickup(obj, user, amount))
                return false;
            Audio.AudioServerPlay3D("WeaponPickupSound", user.getTransform());

            //todo do really like this, I guess they didn't want aiPlayer picking shit up.
            if (user.getClassName() == "Player" && user.getMountedImage(Constants.WeaponSlot) == 0)
                return user.Use(this);

            return false;
            }

        public override bool onUse(ShapeBase obj)
            {
            if (obj.getMountedImage(Constants.WeaponSlot) == this["image"].AsInt())
                return false;

            Audio.AudioServerPlay3D("WeaponUseSound", obj.getTransform());


            obj.mountImage(this["image"], Constants.WeaponSlot, true, string.Empty);

            if (obj["client"].AsBool())
                {
                if (this["description"] != string.Empty)
                    message.MessageClient(obj["client"], "MsgWeaponUsed", "\\c3%1 \\c5 selected.", this["description"]);
                else
                    message.MessageClient(obj["client"], "MsgWeaponUsed", console.addTaggedString(@"\c0Weapon selected"));
                }

            if (obj.isInNamespaceHierarchy("Player"))
                return false;

            Player player = obj._ID;

            player.allowAllPoses();
            SimObject image = this["image"];

            if (image["jumpingDisallowed"].AsBool())
                player.allowJumping(false);

            if (image["jetJumpingDisallowed"].AsBool())
                player.allowJetJumping(false);

            if (image["sprintDisallowed"].AsBool())
                player.allowSprinting(false);

            if (image["crouchDisallowed"].AsBool())
                player.allowCrouching(false);

            if (image["proneDisallowed"].AsBool())
                player.allowProne(false);

            if (image["swimmingDisallowed"].AsBool())
                player.allowSwimming(false);

            return true;
            }

        public override void onInventory(ShapeBase obj, int amount)
            {
            GameConnection client = obj["client"];
            if (client.isObject())
                client.setAmmoAmountHud(1, amount);


            //todo Something funny here, probally should look at it.
            if (amount == 0)
                obj.cycleWeapon("prev");
            }

        public override int onThrow(ShapeBase player, int amount)
            {
            player.decInventory(this, 1);
            ObjectCreator tch = new ObjectCreator("ProximityMine", string.Empty);
            tch["datablock"] = getName();
            tch["sourceObject"] = player;
            tch["rotation"] = new AngAxisF(0, 0, 1, (float) (new Random().NextDouble()*360));
            tch["static"] = false;
            tch["client"] = player["client"];
            ProximityMine pm = (tch.Create());
            ((SimSet) "MissionCleanup").pushToBack(pm);
            return pm;
            }

        public override void onTriggered(ProximityMine obj, SceneObject target)
            {
            }

        public override void onExplode(ProximityMine obj, Point3F pos)
            {
            if (this["damageRadius"].AsFloat() > 0)
                radiusDamage.RadiusDamage(obj, pos, this["damageRadius"].AsFloat(), this["radiusDamage"].AsFloat(),
                    this["damageType"], this["areaImpulse"].AsFloat());
            }

        public override void damage(ShapeBase obj, Point3F position, GameBase source, float damage,
            string damagetype)
            {
            // Explode if any damage is applied to the mine
            int r = 50 + (new Random().Next(0, 50));
            schedule(r.AsString(), "explode");
            }
        }
    }