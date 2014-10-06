

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;

using WinterLeaf.Engine;

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Classes.Extensions;



namespace WinterLeaf.Demo.Full.Models.User.CustomObjects.Scripted.AI
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<CustomDemoPlayer>))]
    public class CustomDemoPlayer : AIPlayer
        {
        private static readonly Random r = new Random();

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction]
        public static void doThink(CustomDemoPlayer ai)
            {
            ai.Think();
            }

        public virtual void Think()
            {
            if (!isObject())
                return;
            if (getState() == "Dead")
                return;
            int nextdelay = CheckForEnemy() ? 2000 : 1000;
            this.schedule(nextdelay.AsString(), "doThink", this);
                
            
            }

        public virtual void MoveToNode(uint index)
            {
            this["currentNode"] = index.AsString();
            ((SimSet)this["path"]).getObject(index);
            Marker node = ((SimSet)this["path"]).getObject(index);
            if (this.getMoveDestination() != node.getTransform().GetPosition())
                this.setMoveDestination(node.getTransform().GetPosition(), false);
            }

        public virtual void MoveToNextNode()
            {
            uint targetnode = this["targetNode"].AsUint();
            uint currentnode = this["currentNode"].AsUint();
            uint pathcount = (uint)((SimSet)this["path"]).getCount();
            if ((targetnode < 0) || (currentnode < targetnode))
                MoveToNode(currentnode < pathcount - 1 ? (currentnode + 1) : 0);
            else
                MoveToNode(currentnode == 0 ? (pathcount - 1) : (currentnode - 1));
            }

        public virtual bool CheckForEnemy()
            {
            if (!isObject())
                return false;
            int nearestplayer = GetNearestPlayerTarget();
            if (nearestplayer != -1)
                {
                float dist = GetTargetDistance(nearestplayer);
                TransformF t = ((Player)nearestplayer).getTransform();
                if (dist < 30)
                    {
                    setAimObject(nearestplayer.AsString());
                    string currentweapon = ((SimObject)getMountedImage(0))["name"];

                    if (dist > 25)
                        {
                        if (currentweapon != "LurkerGrenadeLauncherImage")
                            if (hasInventory("LurkerGrenadeAmmo"))
                                mountImage("LurkerGrenadeLauncherImage", 0, true, "");
                            else if (currentweapon != "LurkerWeaponImage")
                                mountImage("LurkerWeaponImage", 0, true, "");
                        }
                    else if (dist > 10)
                        {
                        if (currentweapon != "LurkerWeaponImage")
                            mountImage("LurkerWeaponImage", 0, true, "");
                        }
                    else
                        {
                        //if (ShapeBaseShapeBaseHasInventory(npc, "ProxMine"))
                        //    {
                        //    ShapeBaseShapeBaseThrow(npc, "ProxMine", 1);
                        //    }
                        if (currentweapon != "LurkerWeaponImage")
                            mountImage("LurkerWeaponImage", 0, true, "");
                        }

                    this["HoldAndFire"] = true.AsString();

                    if (TargetIsInLos(nearestplayer))
                        {
                        setImageTrigger(0, true);
                        setImageTrigger(0, false);
                        }
                    else
                        {
                        if (currentweapon == "LurkerGrenadeLauncherImage")
                            {
                            setImageTrigger(0, true);
                            setImageTrigger(0, false);
                            }
                        }

                    if (dist < 10)
                        stop();
                    else
                        setMoveDestination(t.GetPosition(), false);
                    return false;
                    }

                setMoveDestination(t.GetPosition(), false);
                return false;
                }
            setImageTrigger(0, false);
            this["HoldAndFire"] = false.AsString();

            clearAim();
            MoveToNode(this["currentNode"].AsUint());
            return true;
            }

        public override void onMoveStuck(AIPlayer obj)
            {
            SimSet path = this["path"];
            uint targetnode = this["targetNode"].AsUint();
            Marker node = path.getObject(targetnode);
            TransformF t = node.getTransform();
            t.mPositionZ += r.Next(10, 100);
            t.mPositionX += r.Next(10, 30);
            t.mPositionY += r.Next(10, 30);
            this.setTransform(t);
            }

        public override void onReachDestination(AIPlayer obj)
            {
            if (this["HoldAndFire"].AsBool())
                return;
            if (this["path"] == "")
                return;
            MoveToNextNode();
            }

        public override void onTargetEnterLOS(AIPlayer obj)
            {
            setImageTrigger(0, true);
            }

        public override void onTargetExitLOS(AIPlayer obj)
            {
            setImageTrigger(0, false);
            }

        public override void damage(GameBase sourceobject, Point3F position, float damage, string damagetype)
            {
            if (!isObject())
                return;
            if (getState() == "Dead")
                return;
            if (damage == 0.0)
                return;


            applyDamage(damage);

            if (getState() == "Dead")
                return;

            Point3F ejectvel = getVelocity();

            if (ejectvel.z <= 0)
                {
                ejectvel += new Point3F(0, 0, 5);
                SimDataBlock d = getDataBlock();
                if (d.isObject())
                    ejectvel = ejectvel.vectorScale(d["mass"].AsFloat());
                applyImpulse(getPosition(), ejectvel);
                }


            Point3F currentpos = getPosition();
            currentpos.x += r.Next(-5, 5);
            currentpos.y += r.Next(-5, 5);

            if (getDamageLevel() > 50)
                {
                currentpos.x += r.Next(-50, 50);
                currentpos.y += r.Next(-50, 50);
                }


            setMoveDestination(currentpos, false);
            }

        public virtual void FollowPath(SimSet path, int node)
            {
            stopThread(0);

            if (!path.isObject() || !isObject())
                {
                this["path"] = "";
                return;
                }

            if (node > path.getCount() - 1)
                this["targetNode"] = (path.getCount() - 1).AsString();
            else
                this["targetNode"] = node.AsString();

            if ((this["path"]) == path)
                MoveToNode(this["currentNode"].AsUint());

            else
                {
                this["path"] = path;
                MoveToNode(0);
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CustomDemoPlayer ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(CustomDemoPlayer ts, string simobjectid)
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
        public static implicit operator string(CustomDemoPlayer ts)
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
        public static implicit operator CustomDemoPlayer(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (CustomDemoPlayer)Omni.self.getSimObject(simobjectid, typeof(CustomDemoPlayer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CustomDemoPlayer ts)
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
        public static implicit operator CustomDemoPlayer(int simobjectid)
            {
            return (CustomDemoPlayer)Omni.self.getSimObject((uint)simobjectid, typeof(CustomDemoPlayer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CustomDemoPlayer ts)
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
        public static implicit operator CustomDemoPlayer(uint simobjectid)
            {
            return (CustomDemoPlayer)Omni.self.getSimObject(simobjectid, typeof(CustomDemoPlayer));
            }

        #endregion
        }
    }