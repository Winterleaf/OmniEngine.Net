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
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace Winterleaf.Demo.Full.Dedicated.Models.User.Extendable
{
    public partial class Player
    {
        public override bool OnFunctionNotFoundCallTorqueScript()
        {
            return false;
        }

        public override void onTickCounter(string counterName)
        {
            if (counterName == "TestCheck")
                console.warn("------------->Tick of TestCheck!");
        }

        //private int counter = 0;

        //public override void onTickClientBefore()
        //    {
        //    console.warn("Client Side Tick");
        //    }

        //public override void onTickServerBefore()
        //    {
        //    counter++;
        //    console.warn("Counter: " + counter);
        //    if (counter > 500)
        //        this.delete();
        //    }

        [ConsoleInteraction(true)]
        public static void PlayPain()
        {
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void playPain()
        {
            playAudio(0, "PainCrySound");
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void playDeathCry()
        {
            playAudio(0, "DeathCrySound");
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void playDeathAnimation()
        {
            int numDeathAnimations = getNumDeathAnimations();
            if (numDeathAnimations <= 0)
                return;

            GameConnection client = this["client"];
            if (client.isObject())
                {
                int deathidx = client["deathIdx"].AsInt();
                if ((deathidx > numDeathAnimations) || (deathidx == 0))
                    deathidx = 1;
                setActionThread("Death" + deathidx, false, true);
                deathidx++;
                client["deathIdx"] = deathidx.AsString();
                }
            else
                {
                int r = new Random().Next(1, numDeathAnimations);
                setActionThread("Death" + r, false, true);
                }
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void setDamageDirection(GameBase sourceObject, TransformF damagePos)
        {
            if (sourceObject.isObject())
                damagePos = console.isField(sourceObject, "initialPosition") ? new TransformF(sourceObject["initialPosition"]) : sourceObject.getTransform();

            TransformF dp = damagePos;
            Point3F wbc = getWorldBoxCenter();

            TransformF damagevec = dp - new TransformF(wbc);
            damagevec = damagevec.normalizeSafe();

            GameConnection client = this["client"];
            if (!client.isObject())
                return;

            ShapeBase cameraobject = client.getCameraObject();

            TransformF inverseTransform = cameraobject.getInverseTransform();
            damagevec = math.MatrixMulVector(inverseTransform, damagevec.GetPosition());

            float[] components = new float[6];
            string[] directions = new string[6];
            directions[0] = "Left";
            directions[1] = "Right";
            directions[2] = "Bottom";
            directions[3] = "Front";
            directions[4] = "Bottom";
            directions[5] = "Top";

            components[0] = -damagevec.mPositionX;
            components[1] = damagevec.mPositionX;
            components[2] = -damagevec.mPositionY;
            components[3] = damagevec.mPositionY;
            components[4] = -damagevec.mPositionZ;
            components[5] = damagevec.mPositionZ;
            string damagedirection = string.Empty;
            float max = 0;
            for (int i = 0; i < 6; i++)
                {
                if (components[i] <= max)
                    continue;
                damagedirection = directions[i];
                max = components[i];
                }

            if (console.isObject(client))
                // Util._commandToClient(client, console.addTaggedString("setDamageDirection"), damagedirection);
                console.commandToClient(client, console.addTaggedString("setDamageDirection"), new[] {damagedirection});
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void kill(string damagetype)
        {
            //  ShapeBaseDamage(player, "0", player.getTransform().GetPosition(), 10000, damageType);
            //%this.damage(0, %this.getPosition(), 10000, %damageType);
            damage("0", this.getPosition(), 10000, damagetype);
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void mountVehicles(bool can)
        {
            this["mountVehicle"] = can.AsString();
        }

        //todo This shouldn't need to be exposed to T3D+
        [ConsoleInteraction(true)]
        public bool isPilot()
        {
            Vehicle vehicle = getObjectMount();
            if (vehicle.isObject())
                {
                if (vehicle.getMountNodeObject(0) == this)
                    return true;
                }

            return false;
        }

        //todo This shouldn't need to be exposed to T3D
        [ConsoleInteraction(true)]
        public void playCelAnimation(string anim)
        {
            if (getState() != "Dead")
                setActionThread(string.Format("cel{0}", anim), false, true);
        }

        public override bool Use(ItemData data)
        {
            if (isPilot())
                return false;
            //Instead of going through the parent stuff, we can now just call the parent function via base.
            return base.Use(data);
        }

        public void AddObjectTo_MobSearchGroup(int team)
        {
            SimSet MobSearchGroup = "MobSearchGroup_" + team;
            if (!MobSearchGroup.isObject())
                MobSearchGroup = new ObjectCreator("SimSet", "MobSearchGroup_" + team).Create();
            MobSearchGroup.add(this);
        }

        public virtual void event_startFade(int time, int delay, bool fade)
        {
            this.startFade(time, delay, fade);
        }

        public virtual void event_Delete()
        {
            delete();
        }
    }
}