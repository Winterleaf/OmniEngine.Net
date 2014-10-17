// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System;
using System.ComponentModel;
using Winterleaf.Demo.Full.Dedicated.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.AI
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<DemoPlayer>))]
    public class DemoPlayer : AIPlayer
    {
        private static readonly Random r = new Random();
        private int holdcount = -1;

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        //public override void onTickCounter(string counterName)
        //    {
        //    if (counterName == "Combat::Attack")
        //        {
        //        //console.error("Tick Counter " + counterName);
        //        if (CheckForEnemy())
        //            TickCounterAdd("Combat::Attack", 48);
        //        else
        //            TickCounterAdd("Combat::Attack", 64);
        //        }
        //    }

        [ConsoleInteraction]
        public virtual void Think()
        {
            if (!isObject())
                return;
            if (getState() == "Dead")
                return;
            int nextdelay = CheckForEnemy() ? 2000 : 1000;
            AI.m_thoughtqueue.Add(new AI.AIInterval(DateTime.Now.AddMilliseconds(nextdelay), this));
        }

        public virtual void MoveToNode(uint index)
        {
            this["currentNode"] = index.AsString();
            ((SimSet) this["path"]).getObject(index);
            Marker node = ((SimSet) this["path"]).getObject(index);
            if (this.getMoveDestination() != node.getTransform().GetPosition())
                this.setMoveDestination(node.getTransform().GetPosition(), false);
        }

        public virtual void MoveToNextNode()
        {
            uint targetnode = this["targetNode"].AsUint();
            uint currentnode = this["currentNode"].AsUint();
            uint pathcount = (uint) ((SimSet) this["path"]).getCount();
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
                TransformF t = ((Player) nearestplayer).getTransform();
                if (dist < 30)
                    {
                    setAimObject(nearestplayer.AsString());
                    string currentweapon = ((SimObject) getMountedImage(0))["name"];

                    if (dist > 25)
                        {
                        if (currentweapon != "LurkerGrenadeLauncherImage")
                            {
                            if (hasInventory("LurkerGrenadeAmmo"))
                                mountImage("LurkerGrenadeLauncherImage", 0, true, "");
                            else if (currentweapon != "LurkerWeaponImage")
                                mountImage("LurkerWeaponImage", 0, true, "");
                            }
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

                    if (holdcount == -1)
                        holdcount++;
                    this["HoldAndFire"] = true.AsString();

                    if (holdcount == 5)
                        {
                        holdcount = -1;
                        this["HoldAndFire"] = false.AsString();
                        clearAim();
                        MoveToNode(this["currentNode"].AsUint());
                        }

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
        public static bool operator ==(DemoPlayer ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return ReferenceEquals(simobjectid, null);
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
        public static bool operator !=(DemoPlayer ts, string simobjectid)
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
        public static implicit operator string(DemoPlayer ts)
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
        public static implicit operator DemoPlayer(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (DemoPlayer) Omni.self.getSimObject(simobjectid, typeof (DemoPlayer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DemoPlayer ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DemoPlayer(int simobjectid)
        {
            return (DemoPlayer) Omni.self.getSimObject((uint) simobjectid, typeof (DemoPlayer));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DemoPlayer ts)
        {
            if (ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DemoPlayer(uint simobjectid)
        {
            return (DemoPlayer) Omni.self.getSimObject(simobjectid, typeof (DemoPlayer));
        }

        #endregion
    }
}