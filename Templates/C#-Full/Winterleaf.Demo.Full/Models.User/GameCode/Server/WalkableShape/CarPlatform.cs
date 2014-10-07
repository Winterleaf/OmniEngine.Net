using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.WalkableShape
{
    [TypeConverter(typeof (TypeConverterGeneric<CarPlatform>))]
    internal class CarPlatform : Extendable.WalkableShape
    {
        public override void onObjectAttached(SceneObject obj)
        {
            if (!obj["client"].isObject())
                return;

            bool driverAvailable = (ClientGroup.Count > 1);
            if (driverAvailable)
                {
                ShapeBase driver = ((WheeledVehicle) this["car"]).getMountNodeObject(0);
                if (driver.isObject())
                    message.MessageClient(obj["client"], "MsgItemPickup", "\\c1Hang On!");
                else
                    message.MessageAllExcept(obj["client"], "-1", "MsgItemPickup", "\\c2%1 is on the Cheetah and needs a driver...", obj["client.playerName"]);
                }
            else
                message.MessageClient(obj["client"], "MsgItemPickup", "\\c2Good luck finding a driver...");
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CarPlatform ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(CarPlatform ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(CarPlatform ts)
        {
            if (ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator CarPlatform(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (CarPlatform) Omni.self.getSimObject(simobjectid, typeof (CarPlatform));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CarPlatform ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CarPlatform(int simobjectid)
        {
            return (CarPlatform) Omni.self.getSimObject((uint) simobjectid, typeof (CarPlatform));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CarPlatform ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CarPlatform(uint simobjectid)
        {
            return (CarPlatform) Omni.self.getSimObject(simobjectid, typeof (CarPlatform));
        }

        #endregion
    }
}