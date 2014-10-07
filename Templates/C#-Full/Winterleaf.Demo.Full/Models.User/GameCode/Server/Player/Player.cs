#region

using System;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class Player
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onTickCounter(string counterName)
        {
        if (counterName =="TestCheck")    
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
        static public void PlayPain()
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
                    {
                    deathidx = 1;
                    }
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
                damagePos = console.isField(sourceObject, "initialPosition")
                    ? new TransformF(sourceObject["initialPosition"])
                    : sourceObject.getTransform();


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
                console.commandToClient(client, console.addTaggedString("setDamageDirection"), new[] { damagedirection });
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
                if (vehicle.getMountNodeObject(0) == this)
                    return true;

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
                {
                MobSearchGroup = new ObjectCreator("SimSet", "MobSearchGroup_" + team).Create();
                }
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