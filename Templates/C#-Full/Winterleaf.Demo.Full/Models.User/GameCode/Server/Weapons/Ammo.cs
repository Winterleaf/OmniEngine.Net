#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Weapons
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<Ammo>))]
    public class Ammo : ItemData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override bool onPickup(Item obj, ShapeBase user, int amount)
            {
            if (base.onPickup(obj, user, amount))
                {
                Audio.AudioServerPlay3D("AmmoPickupSound", user.getTransform());
                return true;
                }
            return false;
            }

        public override void onInventory(ShapeBase user, int value)
            {
            //Player can be either a player object or a aiturret...

            GameConnection client = user["client"];
            for (int i = 0; i < 8; i++)
                {
                if (user.GetType() == typeof (Player))
                    {
                    ShapeBaseImageData image = (user).getMountedImage(i);
                    if (image <= 0)
                        continue;

                    if (!image["ammo"].isObject())
                        continue;
                    if (((SimObject) image["ammo"]).getId() != this.getId())
                        continue;


                    (user).setImageAmmo(i, value != 0);
                    }
                else if (user.GetType() == typeof (AITurretShape))
                    {
                    ShapeBaseImageData image = (user).getMountedImage(i);
                    if (image <= 0)
                        continue;

                    if (!image["ammo"].isObject())
                        continue;
                    if (((SimObject) image["ammo"]).getId() != getId())
                        continue;


                    (user).setImageAmmo(i, value != 0);
                    }


                int currentammo = user.getInventory(this); // ShapeBaseShapeBaseGetInventory(player, thisobj);

                if (user.getClassName() != "Player")
                    continue;

                int amountInClips;

                if (this["clip"].isObject())
                    {
                    amountInClips = user.getInventory(this["clip"]);
                    // ShapeBaseShapeBaseGetInventory(player, thisobj["clip"]);

                    amountInClips *= this["maxInventory"].AsInt();

                    amountInClips += user["remaining" + getName()].AsInt();
                    }
                else
                    {
                    amountInClips = currentammo;
                    currentammo = 1;
                    }
                if (user["client"] != string.Empty && !user["isAiControlled"].AsBool())
                    {
                    client.setAmmoAmountHud(currentammo, amountInClips);
                    }
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Ammo ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(Ammo ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(Ammo ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator Ammo(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (Ammo) Omni.self.getSimObject(simobjectid, typeof (Ammo));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Ammo ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Ammo(int simobjectid)
            {
            return (Ammo) Omni.self.getSimObject((uint) simobjectid, typeof (Ammo));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Ammo ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Ammo(uint simobjectid)
            {
            return (Ammo) Omni.self.getSimObject(simobjectid, typeof (Ammo));
            }

        #endregion
        }
    }