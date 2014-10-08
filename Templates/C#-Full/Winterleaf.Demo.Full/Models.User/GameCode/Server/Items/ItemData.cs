#region

using System;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class ItemData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override int onThrow(ShapeBase user, int amount)
            {
            if (amount == 0)
                amount = 1;

            if (this["maxInventory"] != string.Empty)
                if (amount > this["maxInventory"].AsInt())
                    amount = this["maxInventory"].AsInt();

            if (!amount.AsBool())
                return 0;

            user.decInventory(this, amount);
            //ShapeBaseShapeBaseDecInventory(player, datablock, amount);

            // Construct the actual object in the world, and add it to
            // the mission group so it's cleaned up when the mission is
            // done.  The object is given a random z rotation.
            ObjectCreator tch = new ObjectCreator("Item", string.Empty);
            tch["datablock"] = this;
            tch["rotation"] = "0 0 1 " + (new Random().Next(0, 360));
            tch["count"] = amount;

            Item item = tch.Create();

            ((SimSet) "MissionGroup").pushToBack(item);

            item.SchedulePop();

            return item;
            }

        public override bool onPickup(Item obj, ShapeBase user, int amount)
            {
            int count = obj["count"].AsInt();

            //string count = console.GetVarString(item + ".count");

            if (count == 0)
                {
                count = this["count"].AsInt();
                if (count == 0)
                    {
                    if (this["maxInventory"] != string.Empty)
                        {
                        if (count != this["maxInventory"].AsInt())
                            return false;
                        }
                    else
                        count = 1;
                    }
                }
            user.incInventory(((this).getName()), count);

            GameConnection client = user["client"];
            if (client.isObject())
                message.MessageClient(client, "MsgItemPickup", console.ColorEncode(@"\c0You picked up %1"),
                    this["pickupName"]);


            // If the item is a static respawn item, then go ahead and
            // respawn it, otherwise remove it from the world.
            // Anything not taken up by inventory is lost.

            if (obj.isStatic())
                obj.Respawn();
            else
                obj.delete();


            return true;
            }

        public static Item createItem(ItemData datablock)
            {
            ObjectCreator tch = new ObjectCreator("Item");
            tch["dataBlock"] = datablock;
            tch["static"] = true;
            tch["rotate"] = true;
            return tch.Create();
            }

        public override bool onUse(ShapeBase user)
            {
            return false;
            }

        public override void onInventory(ShapeBase user, int value)
            {
            }
        }
    }