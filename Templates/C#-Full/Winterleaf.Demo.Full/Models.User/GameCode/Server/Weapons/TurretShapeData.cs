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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
{
    public partial class TurretShapeData
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onAdd(GameBase obj)
        {
            ShapeBase sbobj = obj._ID;
            sbobj.setRechargeRate(this["rechargeRate"].AsFloat());
            sbobj.setEnergyLevel(this["MaxEnergy"].AsFloat());
            sbobj.setRepairRate(0);

            if (obj["mountable"] == "1" || obj["mountable"] == string.Empty)
                this.isMountable((TurretShape) sbobj, true.AsString());
            else
                this.isMountable((TurretShape) sbobj, false.AsString());

            if (this["nameTag"] != string.Empty)
                sbobj.setShapeName(this["nameTag"]);
            for (int i = 0; i < this["numWeaponMountPoints"].AsInt(); i++)
                {
                sbobj.incInventory(this["weapon[" + i + "]"], 1);
                ItemData weaponAmmo = this["weaponAmmo[" + i + "]"];
                string weaponAmmoAmount = this["weaponAmmoAmount[" + i + "]"];
                sbobj.incInventory(weaponAmmo, weaponAmmoAmount.AsInt());
                bool startLoaded = this["startLoaded"].AsBool();
                sbobj.mountImage(this["weapon[" + i + "].Image"], i, startLoaded, string.Empty);
                sbobj.setImageGenericTrigger(i, 0, false);
                }
            if (this["enterSequence"] != string.Empty)
                {
                obj["entranceThread"] = "0";
                int et = obj["entranceThread"].AsInt();
                string es = this["enterSequence"];
                sbobj.playThread(et, es);
                sbobj.pauseThread(et);
                }
            else
                obj["entranceThread"] = "-1";
        }

        public override void onRemove(GameBase obj)
        {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                if (obj.getMountNodeObject(i) == 0)
                    continue;

                Player passenger = obj.getMountNodeObject(i).AsString();

                //change to csharp
                ((TurretShapeData) passenger.getDataBlock()).call("doDismount", true.AsString());
                }
        }

        public override void damage(ShapeBase obj, Point3F position, GameBase source, float damage, string damagetype)
        {
            if (obj.getDamageState() == "Dead")
                return;

            obj.applyDamage(damage);

            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                Player player = obj.getMountNodeObject(i);
                if (player != 0)
                    player.damage(source, position, 10000.0f, "");
                }
        }

        public override void onDamage(ShapeBase obj, float delta)
        {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage level changes.
        }

        public override void onDestroyed(ShapeBase obj, string lastState)
        {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage state changes.

            // Fade out the destroyed object.  Then schedule a return.
            int destroydelay = iGlobal["$TurretShape::DestroyedFadeDelay"];
            obj.startFade(1000, destroydelay, true);

            obj.schedule((destroydelay + 1000).AsString(), "delete");

            TurretShape ts = obj.ID;
            if (ts.doRespawn())
                ((SimSet) "MissionGroup").schedule(sGlobal["$TurretShape::RespawnTime"], "respawnTurret", this, console.GetClassName(obj), obj.getTransform().AsString(), true.AsString(), true.AsString());
        }

        public override void onDisabled(ShapeBase obj, string lastState)
        {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage state changes.
        }

        public override void onEnabled(ShapeBase obj, string lastState)
        {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage state changes.
        }

        public override void onMount(GameBase obj, SceneObject mountObj, int node)
        {
            //todo change to csharp
            ((GameConnection) mountObj["client"]).call("RefreshVehicleHud", obj, this["reticle"], this["zoomReticle"]);
        }

        public override void onUnmount(GameBase obj, SceneObject mountObj, int node)
        {
            //todo change to csharp
            mountObj.call("RefreshVehicleHud", "0", string.Empty, string.Empty);
        }

        [ConsoleInteraction(true)]
        public virtual void isMountable(TurretShape obj, string val)
        {
            obj["mountable"] = val;
        }

        [ConsoleInteraction(true)]
        public virtual void onMountObject(TurretShape turret, ShapeBase player, int node)
        {
            if (turret["entranceThread"].AsInt() < 0)
                return;

            int et = turret["entranceThread"].AsInt();

            turret.setThreadDir(et, false);
            turret.setThreadPosition(et, 0);
            turret.playThread(et, string.Empty);
        }

        [ConsoleInteraction(true)]
        public virtual void onUnmountObject(TurretShape turret, ShapeBase player)
        {
            if (turret["entranceThread"].AsInt() < 0)
                return;

            int et = turret["entranceThread"].AsInt();

            // Play the entrance thread backwards for an exit

            turret.setThreadDir(et, false);
            turret.setThreadPosition(et, (float) 1.0);
            turret.playThread(et, string.Empty);
        }

        [ConsoleInteraction(true)]
        public virtual void mountPlayer(TurretShape turret, ShapeBase player)
        {
            if (turret.isObject() && turret.getDamageState() != "Destroyed")
                //todo change to csharp

                turret.call("setMountTurret", player);
        }

        [ConsoleInteraction(true)]
        public virtual void setMountTurret(TurretShape turret, ShapeBase player)
        {
            if (!turret.isObject() || turret.getDamageState() == "Destroyed")
                return;

            //todo convert to csharp
            int node = call("findEmptySeat", turret, player).AsInt();
            if (node < 0)
                return;
            turret.mountObject(player, node, new TransformF("0 0 0"));

            player["mVehicle"] = turret;
        }

        [ConsoleInteraction(true)]
        public virtual int findEmptySeat(TurretShape turret, ShapeBase player)
        {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                int node = turret.getMountNodeObject(i);
                if (node == 0)
                    return i;
                }
            return -1;
        }

        [ConsoleInteraction(true)]
        public virtual int switchSeats(TurretShape turret, ShapeBase player)
        {
            for (int i = 0; i < this["numMountPoints"].AsInt(); i++)
                {
                int node = turret.getMountNodeObject(i);
                if (node == player || node != 0)
                    continue;
                if (node == 0)
                    return i;
                }
            return -1;
        }
    }
}