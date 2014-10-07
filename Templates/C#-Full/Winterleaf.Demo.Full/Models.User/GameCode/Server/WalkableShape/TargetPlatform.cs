using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.WalkableShape
{
    [TypeConverter(typeof (TypeConverterGeneric<TargetPlatform>))]
    internal class TargetPlatform : Platform
    {

        public override void onAdd()
        {
            base.onAdd();
            this.setLooping(false);

            //Put some Lights on it
            this.mountObject("RedLight", 0, new TransformF("0.15 0 9 1 0 0 64"));
            this.mountObject("BlueLight", 0, new TransformF("-0.15 0 9 1 0 0 90"));
        }

        public override void onNode(int node)
        {
            // Run back and forth between nodes 0 and 4 unless someone is on the platform
            if (!this.hasHumanRider())
                {
                if (node == 0)
                    this.setMoveState(TypePathShapeState.Forward);
                else if (node == 4)
                    this.setMoveState(TypePathShapeState.Backward);
                }
        }

        public override void onObjectAttached(SceneObject obj)
        {
            if (obj["client"].isObject())
                {
                this.setMoveState(TypePathShapeState.Forward);
                this.checkWinner(obj["client"]);
                }
            base.onObjectAttached(obj);
        }

        public override void onObjectDetached(SceneObject obj)
        {
            // If no riders are left, return to the start
            if (!this.hasHumanRider())
                this.setMoveState(TypePathShapeState.Backward);

            base.onObjectDetached(obj);
        }

        public void checkWinner(GameConnection client)
        {
            for (int i = 0; i < 4; i++)
                {
                if (!client["touchedPlatform[" + i + "]"].AsBool())
                    return; // Skipped a platform, no winner message for you!
                }
            // Get the total time it took them
            double totalTime = Util.getSimTime() - client["miniStartTime"].AsDouble();
            string timeStr = timeToText(totalTime);

            // See if they beat the best time
            if (sGlobal["$Pref::Server::miniWalkableBest"] == "")
                dGlobal["$Pref::Server::miniWalkableBest"] = totalTime;
            else if (totalTime < dGlobal["$Pref::Server::miniWalkableBest"])
                {
                dGlobal["$Pref::Server::miniWalkableBest"] = totalTime;
                timeStr += "\nA new best time!";
                }

            message.MessageClient(client, "MsgItemPickup", "\\c1Congratulations! You reached the platform in %1", timeStr);
            message.MessageAllExcept(client, "-1", "MsgItemPickup", "\\c1%1 reached the platform in %2", client["PlayerName"], timeStr);

            // Reset so they can play again
            client["miniStartTime"] = "";
        }

        public string timeToText(double timeMS)
        {
            int seconds = (int) Math.Floor(timeMS/1000);
            int minutes = (int) Math.Floor(seconds/60d);
            int lseconds = seconds - (minutes*60);

            return minutes + " Minute " + lseconds + " seconds.";
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TargetPlatform ts, string simobjectid)
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
        public static bool operator !=(TargetPlatform ts, string simobjectid)
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
        public static implicit operator string(TargetPlatform ts)
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
        public static implicit operator TargetPlatform(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TargetPlatform) Omni.self.getSimObject(simobjectid, typeof (TargetPlatform));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TargetPlatform ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TargetPlatform(int simobjectid)
        {
            return (TargetPlatform) Omni.self.getSimObject((uint) simobjectid, typeof (TargetPlatform));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TargetPlatform ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TargetPlatform(uint simobjectid)
        {
            return (TargetPlatform) Omni.self.getSimObject(simobjectid, typeof (TargetPlatform));
        }

        #endregion
    }
}