#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Weapons
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<DeployableTurretWeaponImage>))]
    public class DeployableTurretWeaponImage : DeployableTurretImage
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onImageMount(ShapeBase obj, int slot, float dt)
            {
            obj.setImageAmmo(slot, true);

            int numTurrets = obj.getInventory(this["item"]);

            if (obj["client"] != string.Empty && obj.isAiControlled == false)
                ((GameConnection) obj["client"]).refreshWeaponHud(1, this["item.previewImage"], this["item.reticle"],
                    this["item.zoomReticle"], numTurrets);
            }

        public override void onImageUnmount(ShapeBase obj, int slot, float dt)
            {
            if (obj["client"] != string.Empty && obj.isAiControlled == false)
                ((GameConnection) obj["client"]).refreshWeaponHud(0, string.Empty, string.Empty, string.Empty, 0);
            }

        public override void onFire(ShapeBase obj, int slot)
            {
            obj.schedule("0", "throw", this["item"]);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DeployableTurretWeaponImage ts, string simobjectid)
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
        public static bool operator !=(DeployableTurretWeaponImage ts, string simobjectid)
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
        public static implicit operator string(DeployableTurretWeaponImage ts)
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
        public static implicit operator DeployableTurretWeaponImage(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (DeployableTurretWeaponImage) Omni.self.getSimObject(simobjectid, typeof (DeployableTurretWeaponImage));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DeployableTurretWeaponImage ts)
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
        public static implicit operator DeployableTurretWeaponImage(int simobjectid)
            {
            return
                (DeployableTurretWeaponImage)
                    Omni.self.getSimObject((uint) simobjectid, typeof (DeployableTurretWeaponImage));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DeployableTurretWeaponImage ts)
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
        public static implicit operator DeployableTurretWeaponImage(uint simobjectid)
            {
            return
                (DeployableTurretWeaponImage) Omni.self.getSimObject(simobjectid, typeof (DeployableTurretWeaponImage));
            }

        #endregion
        }
    }