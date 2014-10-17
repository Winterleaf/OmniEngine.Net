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
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Weapons
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<WeaponImage>))]
    internal class WeaponImage : ShapeBaseImageData
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onImageMount(ShapeBase obj, int slot, float dt)
        {
            GameConnection client = obj["client"];

            string ammoName = string.Empty;
            ammoName = this["ammo"].getName();

            int currentammo = 0;
            int ammountinClips = 0;
            if (isField("clip"))
                {
                if (obj.getInventory(this["ammo"]).AsBool())
                    {
                    obj.setImageAmmo(slot, true);
                    currentammo = obj.getInventory(this["ammo"]);
                    }
                else if (obj.getInventory(this["clip"]) > 0)
                    {
                    obj.setInventory(this["ammo"], this["ammo.maxInventory"].AsInt());
                    obj.setImageAmmo(slot, true);
                    currentammo = this["ammo.maxInventory"].AsInt();
                    ammountinClips += obj["remaining" + ammoName].AsInt();
                    }
                else
                    currentammo = obj["remaining" + ammoName].AsInt();

                ammountinClips = obj.getInventory(this["clip"]);
                ammountinClips *= this["ammo.maxInventory"].AsInt();

                if ((obj["client"] != string.Empty) && !obj["isAiControlled"].AsBool())
                    client.refreshWeaponHud(currentammo, this["item.previewImage"], this["item.reticle"], this["item.zoomReticle"], ammountinClips);
                }
            else if (this["ammo"] != string.Empty)
                {
                if (obj.getInventory(this["ammo"]).AsBool())
                    {
                    obj.setImageAmmo(slot, true);
                    currentammo = obj.getInventory(this["ammo"]);
                    }
                else
                    currentammo = 0;

                if (obj["client"] != string.Empty && !obj["isAiControlled"].AsBool())
                    client.refreshWeaponHud(1, this["item.previewImage"], this["item.reticle"], this["item.zoomReticle"], currentammo);
                }
        }

        public override void onImageUnmount(ShapeBase obj, int slot, float dt)
        {
            GameConnection client = obj["client"];
            if (client != string.Empty && obj["isAiControlled"].AsBool())
                client.refreshWeaponHud(0, string.Empty, string.Empty, string.Empty, 0);
        }

        public override void onFire(ShapeBase obj, int slot)
        {
            if (!((ProjectileData) this["projectile"]).isObject())
                {
                console.error("WeaponImage::onFire() - Invalid projectile datablock");
                return;
                }
            // Decrement inventory ammo. The image's ammo state is updated
            // automatically by the ammo inventory hooks.

            if (!this["infiniteAmmo"].AsBool())
                obj.decInventory(this["ammo"], 1);

            // Get the player's velocity, we'll then add it to that of the projectile
            int numProjectiles = this["projectileNum"].AsInt();
            if (numProjectiles == 0)
                numProjectiles = 1;
            TransformF muzzleVector = new TransformF();

            for (int i = 0; i < numProjectiles; i++)
                {
                if (this["projectileSpread"].AsBool())
                    {
                    // We'll need to "skew" this projectile a little bit.  We start by
                    // getting the straight ahead aiming point of the gun
                    Point3F vec = obj.getMuzzleVector(slot);
                    // Then we'll create a spread matrix by randomly generating x, y, and z
                    // points in a circle
                    Random r = new Random();
                    TransformF matrix = new TransformF();
                    matrix.mPositionX = (float) ((r.NextDouble() - .5)*2*Math.PI*this["projectileSpread"].AsFloat());
                    matrix.mPositionY = (float) ((r.NextDouble() - .5)*2*Math.PI*this["projectileSpread"].AsFloat());
                    matrix.mPositionZ = (float) ((r.NextDouble() - .5)*2*Math.PI*this["projectileSpread"].AsFloat());
                    TransformF mat = math.MatrixCreateFromEuler(matrix);

                    muzzleVector = math.MatrixMulVector(mat, vec);
                    }
                else
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                Point3F objectVelocity = obj.getVelocity();

                muzzleVector = muzzleVector.vectorScale(this["projectile.muzzleVelocity"].AsFloat());

                objectVelocity = objectVelocity.vectorScale(this["projectile.velInheritFactor"].AsFloat());

                Point3F muzzleVelocity = muzzleVector.GetPosition() + objectVelocity;

                ObjectCreator tch = new ObjectCreator(this["projectileType"]);
                tch["dataBlock"] = this["projectile"];
                tch["initialVelocity"] = muzzleVelocity;
                tch["initialPosition"] = obj.getMuzzlePoint(slot);
                tch["sourceObject"] = obj;
                tch["sourceSlot"] = slot;
                tch["client"] = obj["client"];
                tch["sourceClass"] = obj.getClassName();

                Projectile projectile = tch.Create();

                ((SimSet) "MissionCleanup").pushToBack(projectile);
                }
        }

        public override void onAltFire(ShapeBase obj, int slot)
        {
            if (!this["projectile"].isObject())
                {
                console.error("WeaponImage::onFire() - Invalid projectile datablock");
                return;
                }
            // Decrement inventory ammo. The image's ammo state is updated
            // automatically by the ammo inventory hooks.

            if (!this["infiniteAmmo"].AsBool())
                obj.decInventory(this["ammo"], 1);

            // Get the player's velocity, we'll then add it to that of the projectile
            int numProjectiles = this["altProjectileNum"].AsInt();
            if (numProjectiles == 0)
                numProjectiles = 1;
            TransformF muzzleVector = new TransformF();

            for (int i = 0; i < numProjectiles; i++)
                {
                if (this["altProjectileSpread"].AsBool())
                    {
                    // We'll need to "skew" this projectile a little bit.  We start by
                    // getting the straight ahead aiming point of the gun
                    Point3F vec = obj.getMuzzleVector(slot);
                    // Then we'll create a spread matrix by randomly generating x, y, and z
                    // points in a circle
                    Random r = new Random();
                    TransformF matrix = new TransformF();
                    matrix.mPositionX = (float) ((r.NextDouble() - .5)*2*Math.PI*this["altProjectileSpread"].AsFloat());
                    matrix.mPositionY = (float) ((r.NextDouble() - .5)*2*Math.PI*this["altProjectileSpread"].AsFloat());
                    matrix.mPositionZ = (float) ((r.NextDouble() - .5)*2*Math.PI*this["altProjectileSpread"].AsFloat());
                    TransformF mat = math.MatrixCreateFromEuler(matrix);

                    muzzleVector = math.MatrixMulVector(mat, vec);
                    }
                else
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                Point3F objectVelocity = obj.getVelocity();

                muzzleVector = muzzleVector.vectorScale(this["altProjectile.muzzleVelocity"].AsFloat());
                objectVelocity = objectVelocity.vectorScale(this["altProjectile.velInheritFactor"].AsFloat());
                Point3F muzzleVelocity = muzzleVector.GetPosition() + objectVelocity;

                ObjectCreator tch = new ObjectCreator(((Item) this["altProjectileType"]).getName(), "");
                tch["dataBlock"] = this["altProjectile"];
                tch["initialVelocity"] = muzzleVelocity;
                tch["initialPosition"] = obj.getMuzzlePoint(slot);
                tch["sourceObject"] = obj;
                tch["sourceSlot"] = slot;
                tch["client"] = obj["client"];
                tch["sourceClass"] = obj.getClassName();

                Item projectile = tch.Create();
                ((SimSet) "MissionCleanup").pushToBack(projectile);
                }
        }

        public override void onWetFire(ShapeBase obj, int slot)
        {
            if (!this["projectile"].isObject())
                {
                console.error("WeaponImage::onFire() - Invalid projectile datablock");
                return;
                }
            // Decrement inventory ammo. The image's ammo state is updated
            // automatically by the ammo inventory hooks.
            if (!this["infiniteAmmo"].AsBool())
                obj.decInventory(this["ammo"], 1);

            // Get the player's velocity, we'll then add it to that of the projectile
            int numProjectiles = this["projectileNum"].AsInt();
            if (numProjectiles == 0)
                numProjectiles = 1;
            TransformF muzzleVector = new TransformF();

            for (int i = 0; i < numProjectiles; i++)
                {
                if (this["wetProjectileSpread"].AsBool())
                    {
                    // We'll need to "skew" this projectile a little bit.  We start by
                    // getting the straight ahead aiming point of the gun
                    Point3F vec = obj.getMuzzleVector(slot);
                    // Then we'll create a spread matrix by randomly generating x, y, and z
                    // points in a circle
                    Random r = new Random();
                    TransformF matrix = new TransformF();
                    matrix.mPositionX = (float) ((r.NextDouble() - .5)*2*Math.PI*this["wetProjectileSpread"].AsFloat());
                    matrix.mPositionY = (float) ((r.NextDouble() - .5)*2*Math.PI*this["wetProjectileSpread"].AsFloat());
                    matrix.mPositionZ = (float) ((r.NextDouble() - .5)*2*Math.PI*this["wetProjectileSpread"].AsFloat());
                    TransformF mat = math.MatrixCreateFromEuler(matrix);

                    muzzleVector = math.MatrixMulVector(mat, vec);
                    }
                else
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                Point3F objectVelocity = obj.getVelocity();

                muzzleVector = muzzleVector.vectorScale(this["wetProjectile.muzzleVelocity"].AsFloat());

                objectVelocity = objectVelocity.vectorScale(this["wetProjectile.velInheritFactor"].AsFloat());
                Point3F muzzleVelocity = muzzleVector.GetPosition() + objectVelocity;

                ObjectCreator tch = new ObjectCreator(this["projectileType"]);

                tch["dataBlock"] = this["wetProjectile"];
                tch["initialVelocity"] = muzzleVelocity;
                tch["initialPosition"] = obj.getMuzzlePoint(slot);
                tch["sourceObject"] = obj;
                tch["sourceSlot"] = slot;
                tch["client"] = obj["client"];
                tch["sourceClass"] = obj.getClassName();

                Item projectile = tch.Create();
                ((SimSet) "MissionCleanup").pushToBack(projectile);
                }
        }

        [ConsoleInteraction(true)]
        public virtual void onClipEmpty(ShapeBase obj, int slot)
        {
            this.schedule("0", "reloadAmmoClip", obj, slot.AsString());
        }

        [ConsoleInteraction(true)]
        public virtual void reloadAmmoClip(ShapeBase obj, int slot)
        {
            if (this != obj.getMountedImage(slot))
                return;

            if (!this.isField("clip"))
                return;

            if (obj.getInventory(this["clip"]) > 0)
                {
                obj.decInventory(this["clip"], 1);
                obj.setInventory(this["ammo"], this["ammo.maxInventory"].AsInt());

                obj.setImageAmmo(slot, true);
                }
            else
                {
                int amountInPocket = obj["remaining" + ((Item) this["ammo"]).getName()].AsInt();
                if (amountInPocket > 0)
                    {
                    obj["remaining" + ((Item) this["ammo"]).getName()] = "0";

                    obj.setInventory(this["ammo"], amountInPocket);
                    obj.setImageAmmo(slot, true);
                    }
                }
        }

        [ConsoleInteraction(true)]
        public virtual void clearAmmoClip(ShapeBase obj, int slot)
        {
            //echo("WeaponImage::clearAmmoClip: " SPC %this SPC %obj SPC %slot);

            // if we're not empty put the remaining bullets from the current clip
            // in to the player's "pocket".

            if (!this["clip"].isObject())
                return;
            // Commenting out this line will use a "hard clip" system, where
            // A player will lose any ammo currently in the gun when reloading.
            int pocketAmount = stashSpareAmmo(obj);

            if (obj.getInventory(this["clip"]) > 0 || pocketAmount != 0)
                obj.setImageAmmo(slot, false);
        }

        [ConsoleInteraction(true)]
        public virtual int stashSpareAmmo(ShapeBase obj)
        {
            // If the amount in our pocket plus what we are about to add from the clip
            // Is over a clip, add a clip to inventory and keep the remainder
            // on the player
            ShapeBaseData ammo = this["ammo"];

            if (obj.getInventory(ammo) < this["ammo.maxInventory"].AsInt())
                {
                string nameOfAmmoField = "remaining" + ammo.getName();

                int amountInPocket = obj[nameOfAmmoField].AsInt();

                int amountIngun = obj.getInventory(this["ammo"]);
                int combinedammo = amountInPocket + amountIngun;

                if (combinedammo >= this["ammo.maxInventory"].AsInt())
                    {
                    obj[nameOfAmmoField] = (combinedammo - this["ammo.maxInventory"].AsInt()).AsString();

                    obj.incInventory(this["clip"], 1);
                    }
                else if (obj.getInventory(this["clip"]) > 0)
                    obj[nameOfAmmoField] = combinedammo.AsString();

                return obj[nameOfAmmoField].AsInt();
                }

            return 0;
        }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WeaponImage ts, string simobjectid)
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
        public static bool operator !=(WeaponImage ts, string simobjectid)
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
        public static implicit operator string(WeaponImage ts)
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
        public static implicit operator WeaponImage(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (WeaponImage) Omni.self.getSimObject(simobjectid, typeof (WeaponImage));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(WeaponImage ts)
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
        public static implicit operator WeaponImage(int simobjectid)
        {
            return (WeaponImage) Omni.self.getSimObject((uint) simobjectid, typeof (WeaponImage));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(WeaponImage ts)
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
        public static implicit operator WeaponImage(uint simobjectid)
        {
            return (WeaponImage) Omni.self.getSimObject(simobjectid, typeof (WeaponImage));
        }

        #endregion
    }
}