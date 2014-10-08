#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Weapons
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ProxMineImage>))]
    public class ProxMineImage : ShapeBaseImageData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onImageMount(ShapeBase obj, int slot, float dt)
            {
            obj.setImageAmmo(slot, true);
            int numofmines = obj.getInventory(this["item"]);

            string previewImage = this["item.previewImage"];
            string reticle = this["item.reticle"];
            string zoomReticle = this["item.zoomReticle"];

            GameConnection client = obj["client"];
            client.refreshWeaponHud(1, previewImage, reticle, zoomReticle, numofmines);
            }

        public override void onImageUnmount(ShapeBase obj, int slot, float dt)
            {
            GameConnection client = obj["client"];
            client.refreshWeaponHud(0, string.Empty, string.Empty, string.Empty, 0);
            }

        public override void onFire(ShapeBase obj, int slot)
            {
            obj.Throw(this["item"]);
            }

        [ConsoleInteraction(true)]
        public static void sendMsgClientKilled_MineDamage(string msgType, GameConnection client,
            GameConnection sourceClient, string damLoc)
            {
            // Customized kill message for deaths caused by proximity mines
            if (sourceClient == 0)
                message.MessageAll(msgType, "%1 was blown up!", client["playerName"]);
            else if (sourceClient == client)
                message.MessageAll(msgType, "%1 stepped on his own mine!", client["playerName"]);
            else
                message.MessageAll(msgType, "%1 was blown up by %2!", client["playerName"], sourceClient["playerName"]);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ProxMineImage ts, string simobjectid)
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
        public static bool operator !=(ProxMineImage ts, string simobjectid)
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
        public static implicit operator string(ProxMineImage ts)
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
        public static implicit operator ProxMineImage(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ProxMineImage) Omni.self.getSimObject(simobjectid, typeof (ProxMineImage));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ProxMineImage ts)
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
        public static implicit operator ProxMineImage(int simobjectid)
            {
            return (ProxMineImage) Omni.self.getSimObject((uint) simobjectid, typeof (ProxMineImage));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ProxMineImage ts)
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
        public static implicit operator ProxMineImage(uint simobjectid)
            {
            return (ProxMineImage) Omni.self.getSimObject(simobjectid, typeof (ProxMineImage));
            }

        #endregion
        }
    }