#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects;
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
    [TypeConverter(typeof (TypeConverterGeneric<AmmoClip>))]
    public class AmmoClip : ItemData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override bool onPickup(Item obj, ShapeBase user, int amount)
            {
            if (!base.onPickup(obj, user, amount))
                return false;

            Audio.AudioServerPlay3D("WeaponPickupSound", user.getTransform());

            ShapeBaseImageData image = user.getMountedImage(Constants.WeaponSlot);

            if (image == 0)
                return false;

            if (!console.isField(image, "clip") || image["clip"].getID() != getId())
                return false;

            bool outOfAmmo = !user.getImageAmmo(Constants.WeaponSlot);

            int amountInClips = 0;

            int currentAmmo = user.getInventory(image["ammo"]);

            if (console.isObject(image["clip"]))
                amountInClips = user.getInventory(image["clip"]);


            int t = console.GetVarInt(string.Format("{0}.ammo.maxInventory", image));

            amountInClips *= t;

            int amountloadedingun =
                console.GetVarInt(string.Format("{0}.remaining{1}", obj,
                    console.GetVarString(string.Format("{0}.ammo", this))));

            amountInClips += amountloadedingun;


            GameConnection client = user["client"];
            client.setAmmoAmountHud(currentAmmo, amountInClips);

            if (outOfAmmo)
                ((WeaponImage) image.ID).onClipEmpty(user, Constants.WeaponSlot);

            return true;
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AmmoClip ts, string simobjectid)
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
        public static bool operator !=(AmmoClip ts, string simobjectid)
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
        public static implicit operator string(AmmoClip ts)
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
        public static implicit operator AmmoClip(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (AmmoClip) Omni.self.getSimObject(simobjectid, typeof (AmmoClip));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AmmoClip ts)
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
        public static implicit operator AmmoClip(int simobjectid)
            {
            return (AmmoClip) Omni.self.getSimObject((uint) simobjectid, typeof (AmmoClip));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AmmoClip ts)
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
        public static implicit operator AmmoClip(uint simobjectid)
            {
            return (AmmoClip) Omni.self.getSimObject(simobjectid, typeof (AmmoClip));
            }

        #endregion
        }
    }