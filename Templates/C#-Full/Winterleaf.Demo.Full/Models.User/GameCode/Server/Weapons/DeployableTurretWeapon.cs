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
    [TypeConverter(typeof (TypeConverterGeneric<DeployableTurretWeapon>))]
    public class DeployableTurretWeapon : AITurretShapeData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        /*note In torquescript they used a classname call to the weapon class to perform
 * the onPickUp and onUse.  Unfortunately, we don't have that ability in CSharp.
 */

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

        public override void onInventory(ShapeBase obj, int amount)
            {
            if (amount != 0 || !obj.isMethod("getMountSlot"))
                return;
            int slot = obj.getMountSlot(this["image"]);
            obj.unmountImage(slot);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DeployableTurretWeapon ts, string simobjectid)
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
        public static bool operator !=(DeployableTurretWeapon ts, string simobjectid)
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
        public static implicit operator string(DeployableTurretWeapon ts)
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
        public static implicit operator DeployableTurretWeapon(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (DeployableTurretWeapon) Omni.self.getSimObject(simobjectid, typeof (DeployableTurretWeapon));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DeployableTurretWeapon ts)
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
        public static implicit operator DeployableTurretWeapon(int simobjectid)
            {
            return (DeployableTurretWeapon) Omni.self.getSimObject((uint) simobjectid, typeof (DeployableTurretWeapon));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DeployableTurretWeapon ts)
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
        public static implicit operator DeployableTurretWeapon(uint simobjectid)
            {
            return (DeployableTurretWeapon) Omni.self.getSimObject(simobjectid, typeof (DeployableTurretWeapon));
            }

        #endregion
        }
    }