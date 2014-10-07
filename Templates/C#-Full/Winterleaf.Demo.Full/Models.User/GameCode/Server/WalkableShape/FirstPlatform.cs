using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.WalkableShape
{
    [TypeConverter(typeof (TypeConverterGeneric<FirstPlatform>))]
    internal class FirstPlatform : Platform
    {
        public override void onAdd()
        {
            base.onAdd();
            // This is not a looping path. It travels between two fixed positions.
            this.setLooping(false);
        }

        public override void onObjectAttached(SceneObject obj)
        {
            // Start moving forward whenever we get a rider
            this.setMoveState(TypePathShapeState.Forward);

            if (obj["client"].isObject())
                {
                if (!obj["client.gotInstructions"].AsBool())
                    {
                    message.MessageClient(obj["client"], "MsgItemPickup", "\\c1Hop to the center grey platform to win.");
                    obj["client.gotInstructions"] = "true";
                    }

                if (obj["client.miniStartTime"] == "")
                    {
                    // Record this as their start time and clear the tracking variables
                    obj["client.miniStartTime"] = Util.getSimTime().AsString();
                    for (int i = 0; i < 4; i++)
                        obj["client.touchedPlatform[" + i + "]"] = "false";
                    }
                }
            base.onObjectAttached(obj);
        }

        public override void onObjectDetached(SceneObject obj)
        {
            // If no riders are left, return to the start position
            if (!this.hasHumanRider())
                this.setMoveState(TypePathShapeState.Backward);

            base.onObjectDetached(obj);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FirstPlatform ts, string simobjectid)
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
        public static bool operator !=(FirstPlatform ts, string simobjectid)
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
        public static implicit operator string(FirstPlatform ts)
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
        public static implicit operator FirstPlatform(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (FirstPlatform) Omni.self.getSimObject(simobjectid, typeof (FirstPlatform));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(FirstPlatform ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FirstPlatform(int simobjectid)
        {
            return (FirstPlatform) Omni.self.getSimObject((uint) simobjectid, typeof (FirstPlatform));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(FirstPlatform ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FirstPlatform(uint simobjectid)
        {
            return (FirstPlatform) Omni.self.getSimObject(simobjectid, typeof (FirstPlatform));
        }

        #endregion
    }
}