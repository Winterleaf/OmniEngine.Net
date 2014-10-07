#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class VehicleData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            Vehicle vehicle = obj._ID;
            vehicle.setRechargeRate(this["rechargeRate"].AsFloat());
            vehicle.setEnergyLevel(this["MaxEnergy"].AsFloat());
            vehicle.setRepairRate(0);

                {
                if (obj["mountable"].AsBool() || (obj["mountable"] == string.Empty))
                    isMountable(vehicle, true);
                else
                    isMountable(vehicle, false);
                }


            string nametag = this["nameTag"];


            if (nametag.Trim() != string.Empty)
                vehicle.setShapeName(nametag);
            }

        public override void onRemove(GameBase obj)
            {
            // if there are passengers/driver, kick them out
            for (int i = 0; i < ((VehicleData) obj.getDataBlock())["numMountPoints"].AsInt(); i++)
                {
                if (!((SimObject) obj.getMountNodeObject(i)).isMemberOfClass("Player"))
                    continue;
                Player passenger = obj.getMountNodeObject(i);
                if (passenger != "0")
                    {
                    PlayerData passengerdatablock = passenger.getDataBlock();
                    passengerdatablock.doDismount(passenger);
                    }
                }
            }

        public virtual void isMountable(Vehicle obj, bool val)
            {
            obj["mountable"] = val.AsString();
            }

        public virtual void mountPlayer(Vehicle vehicle, Player player)
            {
            if (!vehicle.isObject() || vehicle.getDamageState() == "Destroyed")
                return;
            player.startFade(1000, 0, true);
            this.schedule("1000", "setMountVehicle", vehicle, player);
            player.schedule("1500", "startFade", "1000", "0", "false");
            }

        /// <summary>
        /// This function needs to be exposed in the T3D engine so it can be called via a timer.
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="player"></param>
        [ConsoleInteraction(true)]
        public virtual void setMountVehicle(Vehicle vehicle, Player player)
            {
            if (!vehicle.isObject() || vehicle.getDamageState() == "Destroyed")
                return;

            int node = findEmptySeat(vehicle, player);
            if (node == -1)
                return;
            vehicle.mountObject(player, node, new TransformF());
            player["mVehicle"] = vehicle;
            }

        public virtual int findEmptySeat(Vehicle vehicle, Player player)
            {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                int node = vehicle.getMountNodeObject(i);
                if (node != 0)
                    return i;
                }
            return -1;
            }

        public virtual int switchSeats(Vehicle vehicle, Player player)
            {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                int node = vehicle.getMountNodeObject(i);
                if (node == player || node > 0)
                    continue;
                if (node == 0)
                    return i;
                }
            return -1;
            }
        }
    }