#region

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<TeleporterTrigger>))]
    public class TeleporterTrigger : TriggerData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            if (obj["exit"] == string.Empty)
                obj["exit"] = "NameOfTeleporterExit";

            if (obj["teleporterCooldown"] == string.Empty)
                obj["teleporterCooldown"] = this["teleporterCooldown"];

            if (obj["exitVelocityScale"] == string.Empty)
                obj["exitVelocityScale"] = this["exitVelocityScale"];

            if (obj["reorientPlayer"] == string.Empty)
                obj["reorientPlayer"] = this["reorientPlayer"];

            if (obj["oneSided"] == string.Empty)
                obj["oneSided"] = this["oneSided"];

            if (obj["entranceEffect"] == string.Empty)
                obj["entranceEffect"] = this["entranceEffect"];

            if (obj["exitEffect"] == string.Empty)
                obj["exitEffect"] = this["exitEffect"];
            // We do not want to save this variable between levels, 
            // clear it out every time the teleporter is added 
            // to the scene.

            obj["timeOfLastTeleport"] = string.Empty;
            }

        public override void onLeaveTrigger(Trigger trigger, GameBase obj)
            {
            obj["isTeleporting"] = false.AsString();
            }

        public override void onEnterTrigger(Trigger trigger, GameBase obj)
            {
            //if (!console.isMemberOfClass(obj, "Player"))
            //    return;

            if (obj["isTeleporting"].AsBool())
                return;
            // Get the location of our target position
            Trigger exit = trigger["exit"];

            bool valid = verifyObject(obj, trigger, exit);
            if (!valid)
                return;

            teleFrag(obj, exit);
            // Create our entrance effects on all clients.


            SimObject entranceeffect = trigger["entranceEffect"];
            if (entranceeffect.isObject())
                foreach (GameConnection client in ClientGroup)
                    {
                    if (console.isObject(client))
                        console.commandToClient(client, "PlayTeleportEffect",
                            new[] {trigger["position"], entranceeffect.getId().AsString()});
                    }


            teleportPlayer(obj, exit);
            // Create our exit effects on all clients.

            SimObject exitEffect = trigger["exitEffect"];
            if (exitEffect.isObject())
                foreach (GameConnection client in ClientGroup)
                    {
                    if (console.isObject(client))
                        console.commandToClient(client, "PlayTeleportEffect",
                            new[] {trigger["position"], exitEffect.getId().AsString()});
                    }

            // Record what time we last teleported so we can determine if enough
            // time has elapsed to teleport again
            int tolt = console.getSimTime();
            trigger["timeOfLastTeleport"] = tolt.AsString();

            // If this is a bidirectional teleporter, log it's exit too.
            if (exit["exit"] == trigger["name"])
                exit["timeOfLastTeleport"] = tolt.AsString();


            // Tell the client to play the 2D sound for the player that teleported.
            if (((SimObject) this["teleportSound"]).isObject() && ((GameConnection) obj["client"]).isObject())
                {
                ((GameConnection) obj["client"]).play2D(this["teleportSound"]);
                //GameConnection.play2D(obj, thisobj["teleportSound"]);
                }
            }

        public virtual bool verifyObject(GameBase gobj, SceneObject entrance, SceneObject exit)
            {
            ShapeBase obj = gobj._ID;


            // Bail out early if we couldn't find an exit for this teleporter.
            if (!exit.isObject())
                {
                console.error(string.Format("Cound not find an exit for {0}", console.GetVarString(entrance + ".name")));
                return false;
                }


            if (!obj.isMemberOfClass("Player"))
                return false;

            // If the entrance is once sided, make sure the object
            // approached it from it's front.
            if (entrance["oneSided"].AsBool())
                {
                TransformF forwardvector = new TransformF(entrance.getForwardVector());

                Point3F velocity = obj.getVelocity();
                float dotProduct = TransformF.vectorDot(forwardvector, velocity);
                if (dotProduct > 0)
                    return false;
                // If we are coming directly from another teleporter and it happens
                // to be bidirectional, We need to avoid ending sending objects through
                // an infinite loop.

                if (obj["isTeleporting"].AsBool())
                    return false;
                // We only want to teleport players
                // So bail out early if we have found any 
                // other object.


                if (entrance["timeOfLastTeleport"].AsInt() > 0 && entrance["teleporterCooldown"].AsInt() > 0)
                    {
                    int currentTime = console.getSimTime();
                    int timedifference = currentTime - entrance["timeOfLastTeleport"].AsInt();
                    SimDataBlock db = console.getDatablock(entrance);
                    if (timedifference <= db["teleporterCooldown"].AsInt())
                        return false;
                    }
                }
            return true;
            }

        public virtual void teleFrag(GameBase player, Trigger exit)
            {
            // When a telefrag happens, there are two cases we have to consider.
            // The first case occurs when the player's bounding box is much larger than the exit location, 
            // it is possible to have players colide even though a player is not within the bounds 
            // of the trigger Because of this we first check a radius the size of a player's bounding 
            // box around the exit location.

            // Get the bounding box of the player

            Point3F boundingBoxSize = new Point3F(((PlayerData) player.getDataBlock())["boundingBox"]);
            float radius = boundingBoxSize.x;
            float boxSizeY = boundingBoxSize.y;
            float boxSizeZ = boundingBoxSize.z;

            // Use the largest dimention as the radius to check
            if (boxSizeY > radius)
                radius = boxSizeY;
            if (boxSizeZ > radius)
                radius = boxSizeZ;

            Point3F position = exit.getTransform().GetPosition(); // new TransformF(con.getTransform(exit));
            uint mask = (uint) SceneObjectTypesAsUint.PlayerObjectType;

            // Check all objects within the found radius of the exit location, and telefrag
            // any players that meet the conditions.

            Dictionary<uint, float> r = console.initContainerRadiusSearch(position, radius, mask);
            foreach (
                ShapeBase objectNearExit in
                    r.Keys.Where(objectNearExit => ((ShapeBase) objectNearExit).isMemberOfClass("Player"))
                        .Where(objectNearExit => objectNearExit.AsString() != player))
                {
                objectNearExit.damage(player, exit.getTransform().GetPosition(), 10000, "Telefrag");
                }
            // The second case occurs when the bounds of the trigger are much larger
            // than the bounding box of the player. (So multiple players can exist within the
            // same trigger). For this case we check all objects contained within the trigger
            // and telefrag all players.

            int objectsInExit = exit.getNumObjects();
            // Loop through all objects in the teleporter exit
            // And kill any players
            for (int i = 0; i < objectsInExit; i++)
                {
                ShapeBase objectInTeleporter = console.Call(exit, "getObject", new[] {i.AsString()});
                if (objectInTeleporter.isMemberOfClass("Player"))
                    continue;
                // Avoid killing the player that is teleporting in the case of two
                // Teleporters near eachother.
                if (objectInTeleporter == player)
                    continue;

                objectInTeleporter.damage(player, exit.getTransform().GetPosition(), 10000, "Telefrag");
                }
            }

        public virtual void teleportPlayer(GameBase gplayer, SceneObject exit)
            {
            Player player = gplayer._ID;
            TransformF targetPosition;
            if (exit["reorientPlayer"].AsBool())
                {
                targetPosition = exit.getTransform();
                }
            else
                {
                targetPosition = exit.getTransform();
                TransformF playerrot = player.getTransform();
                targetPosition.mOrientationX = playerrot.mOrientationX;
                targetPosition.mOrientationY = playerrot.mOrientationY;
                targetPosition.mOrientationZ = playerrot.mOrientationZ;
                targetPosition.MAngle = playerrot.MAngle;
                }
            player.setTransform(targetPosition);
            Point3F playervelocity = player.getVelocity();
            playervelocity = playervelocity.vectorScale(exit["exitVelocityScale"].AsFloat());
            player.setVelocity(playervelocity);
            // Prevent the object from doing an immediate second teleport
            // In the case of a bidirectional teleporter
            player["isTeleporting"] = true.AsString();
            }

        [ConsoleInteraction(true)]
        public static void sendMsgClientKilled_Telefrag(string msgType, GameConnection client,
            GameConnection sourceClient, string damLoc)
            {
            CustomObjects.Utilities.message.MessageAll(msgType, "%1 was telefragged by %2!", client["playerName"],
                sourceClient["playerName"]);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TeleporterTrigger ts, string simobjectid)
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
        public static bool operator !=(TeleporterTrigger ts, string simobjectid)
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
        public static implicit operator string(TeleporterTrigger ts)
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
        public static implicit operator TeleporterTrigger(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (TeleporterTrigger) Omni.self.getSimObject(simobjectid, typeof (TeleporterTrigger));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TeleporterTrigger ts)
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
        public static implicit operator TeleporterTrigger(int simobjectid)
            {
            return (TeleporterTrigger) Omni.self.getSimObject((uint) simobjectid, typeof (TeleporterTrigger));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TeleporterTrigger ts)
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
        public static implicit operator TeleporterTrigger(uint simobjectid)
            {
            return (TeleporterTrigger) Omni.self.getSimObject(simobjectid, typeof (TeleporterTrigger));
            }

        #endregion
        }
    }