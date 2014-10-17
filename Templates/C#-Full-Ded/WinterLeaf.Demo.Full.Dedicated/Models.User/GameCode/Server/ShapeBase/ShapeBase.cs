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
using Winterleaf.Demo.Full.Dedicated.Models.User.CustomObjects;
using Winterleaf.Demo.Full.Dedicated.Models.User.CustomObjects.Utilities;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.Extendable
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ShapeBase
    {
        private static pInvokes tst = new pInvokes();

        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        //todo this does not need to be exposed to T3D in the end.

        [ConsoleInteraction(true)]
        public virtual void damage(GameBase sourceobject, Point3F position, float damage, string damagetype)
        {
            if (!isObject())
                return;
            ShapeBaseData datablock = getDataBlock();
            datablock.damage(this, position, sourceobject, damage, damagetype);
        }

        //todo this does not need to be exposed to T3D in the end.
        [ConsoleInteraction(true)]
        public virtual void setDamageDT(float damageAmount, string damageType)
        {
            // This function is used to apply damage over time.  The damage is applied
            // at a fixed rate (50 ms).  Damage could be applied over time using the
            // built in ShapBase C++ repair functions (using a neg. repair), but this
            // has the advantage of going through the normal script channels.

            if (getDamageState() != "Dead")
                {
                damage(0, new Point3F("0 0 0"), damageAmount, damageType);
                this["damageSchedule"] = schedule("50", "setDamageDt", damageAmount.AsString(), damageType).AsString();
                }
            else
                this["damageSchedule"] = string.Empty;
        }

        //todo this does not need to be exposed to T3D in the end.
        [ConsoleInteraction(true)]
        public virtual void clearDamageDt()
        {
            //I could think of soo much better ways of doing this... even if my grammar blows.

            if (this["damageSchedule"] == string.Empty)
                return;

            new pInvokes().Util.cancel(this["damageSchedule"].AsInt());
            this["damageSchedule"] = string.Empty;
        }

        [ConsoleInteraction(true)]
        public static void serverCmdUse(GameConnection client, ItemData data)
        {
            if (((Player) client.getControlObject()).isObject())
                ((Player) client.getControlObject()).Use(data);
        }

        [ConsoleInteraction(true)]
        public virtual int incInventory(ItemData datablock, int amount)
        {
            int maxamount = maxInventory(datablock);

            int total = this["inv[" + datablock.getName() + "]"].AsInt();

            if (total < maxamount)
                {
                if (total + amount > maxamount)
                    amount = (maxamount - total);
                setInventory(datablock, (total + amount));
                return amount;
                }
            return 0;
        }

        [ConsoleInteraction(true)]
        public virtual int decInventory(ItemData data, int amount = 0)
        {
            int total = this["inv[" + data.getName() + "]"].AsInt();

            if (total > 0)
                {
                if (total < amount)
                    amount = total;

                setInventory(data, (total - amount));
                return amount;
                }
            return 0;
        }

        [ConsoleInteraction(true)]
        public virtual int setInventory(ItemData data, int value = 0)
        {
            int max = 0;

            max = maxInventory(data);
            if (value > max)
                value = max;

            int amount = this["inv[" + data.getName() + "]"].AsInt();

            if (amount != value)
                {
                this["inv[" + data.getName() + "]"] = value.AsString();
                //console.warn("Setting " + data.getName() + " to " + value);

                data.onInventory(this, value);
                }
            return value;
        }

        [ConsoleInteraction(true)]
        public virtual void clearInventory()
        {
            //todo Fill this in.
        }

        [ConsoleInteraction(true)]
        public virtual void onInventory(ShapeBase thisobj, ModelBase data, string value)
        {
            // Invoked on ShapeBase objects whenever their inventory changes
            // for the given datablock.
        }

        [ConsoleInteraction(true)]
        public virtual int getInventory(ModelBase data)
        {
            if (data != null)
                return isObject() ? this["inv[" + data.getName() + "]"].AsInt() : 0;
            return 0;
        }

        [ConsoleInteraction(true)]
        public virtual int maxInventory(ModelBase data)
        {
            if (data.isField("clip"))
                return data["maxInventory"].AsInt();

            return ((SimDataBlock) getDataBlock())["maxInv[" + data.getName() + "]"].AsInt();
        }

        [ConsoleInteraction(true)]
        public virtual bool hasInventory(ModelBase data)
        {
            return this["inv[" + data.getName() + "]"].AsInt() > 0;
        }

        [ConsoleInteraction(true)]
        public virtual bool hasAmmo(Item weapon)
        {
            ShapeBaseImageData weaponimageammo = weapon["image.ammo"];
            if (weaponimageammo == string.Empty)
                return true;
            return getInventory(weaponimageammo) > 0;
        }

        //todo this does not need to be exposed to T3D in the end.
        [ConsoleInteraction(true)]
        public virtual bool Throw(ItemData data, int amount = 1)
        {
            bool functionresult = false;
            if (getInventory(data) > 0)
                {
                Item objectid = data.onThrow(this, amount);
                    {
                    if (objectid != 0)
                        {
                        throwObject(objectid);
                        Audio.AudioServerPlay3D("ThrowSnd", this.getTransform());
                        functionresult = true;
                        }
                    }
                }
            return functionresult;
        }

        //todo doesn't need to be exposed to T3D.
        [ConsoleInteraction(true)]
        public string tossPatch()
        {
            if (!isObject())
                return string.Empty;

            Item item = ItemData.createItem("HealthKitPatch");
            item["istemp"] = true.AsString();

            item["sourceObject"] = this;
            item["static"] = false.AsString();

            ((SimSet) "MissionCleanup").pushToBack(item);

            Random r = new Random();

            Point3F vec = new Point3F(-1 + (float) r.NextDouble()*2, -1*(float) r.NextDouble()*2, (float) r.NextDouble());
            vec = vec.vecotrScale(10);
            Point3F eye = getEyeVector();
            float dot = new Point3F("0 0 1 ").vectorDot(eye);
            if (dot < 0)
                dot = -dot;

            vec = vec + new Point3F("0 0 8").vecotrScale(1 - dot);
            vec = vec + getVelocity();

            TransformF pos = new TransformF(getWorldBox().Get_MinExtents());
            item.setTransform(pos);
            item.applyImpulse(pos.GetPosition(), vec);
            item.setCollisionTimeout(this);

            item.SchedulePop();

            return item;
        }

        public string doRayCast(float range, UInt32 mask)
        {
            Point3F eyeVec = getEyeVector();
            TransformF eyeTran = getEyeTransform();

            Point3F eyePos = eyeTran.GetPosition();

            Point3F nEyeVec = Util.VectorNormalize(eyeVec);

            Point3F scEyeVec = Util.VectorScale(nEyeVec, range);

            Point3F eyeEnd = Util.VectorAdd(eyePos, scEyeVec);

            return Util.containerRayCast(eyePos, eyeEnd, mask, this, false);
        }

        [ConsoleInteraction(true)]
        public virtual bool Use(ItemData data)
        {
            GameConnection client = getControllingClient();
            if (client.isObject())
                {
                double defaultfov = client.getControlCameraDefaultFov();
                double fov = client.getControlCameraFov();
                if (defaultfov != fov)
                    return false;
                }
            if (getInventory(data) > 0)

                return data.onUse(_ID);

            return false;
        }

        [ConsoleInteraction(true)]
        public virtual bool pickup(Item obj, int amount)
        {
            ItemData data = obj.getDataBlock();

            if (amount == 0)
                {
                int maxamount = maxInventory(data);

                int curamount = getInventory(data);

                amount = (maxamount - curamount);
                }

            return amount > 0 && data.onPickup(obj, this, amount);
        }

        [ConsoleInteraction(true)]
        public virtual void throwObject(Item obj)
        {
            // Throw the given object in the direction the shape is looking.
            // The force value is hardcoded according to the current default
            // object mass and mission gravity (20m/s^2).

            float throwforce = ((SimDataBlock) getDataBlock())["throwForce"].AsFloat();
            if (throwforce == 0)
                throwforce = 20;

            // Start with the shape's eye vector...

            Point3F eye = getEyeVector();
            Point3F vec = eye.vectorScale(throwforce);

            // Add a vertical component to give the object a better arc
            double verticalForce = throwforce/2.0;
            float dot = Point3F.vectorDot(new Point3F("0 0 1"), eye);
            if (dot < 0)
                dot = dot*-1;

            vec = vec + Point3F.vectorScale(new Point3F(string.Format("0 0 {0}", verticalForce)), 1 - dot);
            vec = vec + getVelocity();

            // Set the object's position and initial velocity

            TransformF pos = new TransformF(Util.getBoxCenter(getWorldBox()));

            obj.setTransform(pos);

            obj.applyImpulse(pos.GetPosition(), vec);

            // Since the object is thrown from the center of the shape,
            // the object needs to avoid colliding with it's thrower.

            obj.setCollisionTimeout(this);

            //todo Should we add this code in to destroy things after they have been thrown?
            if ((obj.getClassName() != "AITurretShape") && (obj.getClassName() != "ProximityMine"))
                obj.schedule("2000", "delete");
        }

        [ConsoleInteraction(true)]
        public virtual void clearWeaponCycle()
        {
            this["totalCycledWeapons"] = "0";
        }

        [ConsoleInteraction(true)]
        public virtual void addToWeaponCycle(string weapon)
        {
            this["cycleWeapon[" + this["totalCycledWeapons"].AsString() + "]"] = weapon;
            this["totalCycledWeapons"] = (this["totalCycledWeapons"].AsInt() + 1).AsString();
        }

        [ConsoleInteraction(true)]
        public virtual void cycleWeapon(string direction)
        {
            //I sure seem to retrieve "thisobj.totalCycledWeapons" alot,
            //So to save so work, I'm just gonna grab it here.
            int totalCycledWeapons = this["totalCycledWeapons"].AsInt();

            // Can't cycle what we don't have
            if (totalCycledWeapons == 0)
                return;
            // Find out the index of the current weapon, if any (not all
            // available weapons may be part of the cycle)
            int currentIndex = -1;

            ShapeBaseImageData mountedimage = this.getMountedImage(Constants.WeaponSlot);

            if (mountedimage.isObject())
                {
                string curWeapon = mountedimage["item"];
                for (int i = 0; i < totalCycledWeapons; i++)
                    {
                    if (this["cycleWeapon[" + i + "]"] != curWeapon)
                        continue;
                    currentIndex = i;
                    break;
                    }
                }

            int nextIndex = 0;
            int dir = 1;
            if (currentIndex != -1)
                {
                if (direction == "prev")
                    {
                    dir = -1;
                    nextIndex = currentIndex - 1;
                    if (nextIndex < 0)
                        nextIndex = totalCycledWeapons - 1;
                    }
                else
                    {
                    nextIndex = currentIndex + 1;
                    if (nextIndex >= totalCycledWeapons)
                        nextIndex = 0;
                    }
                }
            bool found = false;
            ItemData weapon = null;
            for (int i = 0; i < totalCycledWeapons; i++)
                {
                weapon = this["cycleWeapon[" + i + "]"];
                if ((weapon != 0) && (hasInventory(weapon)))
                    {
                    found = true;
                    break;
                    }
                nextIndex = nextIndex + dir;
                if (nextIndex < 0)
                    nextIndex = totalCycledWeapons - 1;
                else if (nextIndex >= totalCycledWeapons)
                    nextIndex = 0;
                }
            if (!found)
                return;
            weapon = this["cycleWeapon[" + nextIndex + "]"];

            Use(weapon);
        }
    }
}