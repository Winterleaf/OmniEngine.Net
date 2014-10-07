#region

using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
                    {
                    currentammo = obj["remaining" + ammoName].AsInt();
                    }

                ammountinClips = obj.getInventory(this["clip"]);
                ammountinClips *= this["ammo.maxInventory"].AsInt();

                if ((obj["client"] != string.Empty) && !obj["isAiControlled"].AsBool())
                    {
                    client.refreshWeaponHud(currentammo, this["item.previewImage"], this["item.reticle"],
                        this["item.zoomReticle"], ammountinClips);
                    }
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
                    client.refreshWeaponHud(1, this["item.previewImage"], this["item.reticle"], this["item.zoomReticle"],
                        currentammo);
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
                    {
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                    }
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
                    {
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                    }
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
                    {
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                    }
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
        public static bool operator !=(WeaponImage ts, string simobjectid)
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
        public static implicit operator string(WeaponImage ts)
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
            if (object.ReferenceEquals(ts, null))
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