//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using WinterLeaf.Engine.Classes.Decorations;
//using WinterLeaf.Engine.Classes.Extensions;
//using WinterLeaf.Engine.Classes.View.Creators;
//using WinterLeaf.Engine.Containers;

//namespace WinterLeaf.Demo.Full.Models.User.Extendable
//{
//    public partial class PhysicsBodyData
//    {
//        [ConsoleInteraction]
//        public virtual void onContact(ShapeBase obj, VectorFloat pos, float vel, float slideOrCollide)
//        {
//            //echo(" RigidBodyData::onContact ", %vel SPC %slideOrCollide);
//            if(this["collisionSoundsCount"].AsFloat() > 0 || this["slideSoundsCount"].AsFloat() > 0)
//            {
//                //we're sliding
//                if(this["slidingThreshold"] !="" && this["slidingThreshold"].AsFloat() > slideOrCollide)
//                {
//                    if(this["slideSoundsCount"].AsFloat() > 0)
//                    {
//                        string snd = this["slideSound[" + Util.getRandom(this["slideSoundsCount"].AsInt() - 1)];
//                        obj.playAudio(0, snd);
//                        //%obj.slideSnd = sfxPlayOnce(%snd, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
//                    }
//                }
//                //we're colliding
//                else
//                {
//                    if(this["collisionSoundsCount"].AsInt() > 0)
//                    {
//                        //echo("Collide ", %obj SPC %vel);
//                        string snd = this["collisionSound[" + Util.getRandom(this["collisionSoundsCount"].AsInt() - 1)];
//                        obj.playAudio(0, snd);
//                        //Calc volume from velocity.
//                        /*
//                        %vol = mClamp(%vel / 6, 0.2, 1);
//                        if(isObject(%obj.collideSnd) && %vol >= %obj.collideSndVol)
//                        %obj.collideSnd.stop();
//                        %obj.collideSnd = sfxPlayOnce(%snd, getWord(%pos, 0), getWord(%pos, 1), getWord(%pos, 2));
//                        %obj.collideSndVol = %vol;
//                        %obj.collideSnd.setVolume(%vol);
//                        */
//                    }
//                }
//            }
//        }
//    }

//    public partial class RigidBodyData
//    {
//        // Hook into the mission editor.
//        [ConsoleInteraction]
//        public virtual string create(SimObject data)
//        {
//            // The mission editor invokes this method when it wants to create
//            // an object of the given datablock type.
//            ObjectCreator oc = new ObjectCreator("RigidBody");
//            oc["dataBlock"] = data;
//            oc["scale"] = data["scale"];
//            return oc.Create().AsString();
//        }
//    }

//    public partial class SoftBodyData
//    {
//        [ConsoleInteraction]
//        public override string create(SimObject data)
//        {
//            ObjectCreator oc = new ObjectCreator("SoftBody");
//            oc["dataBlock"] = data;
//            oc["scale"] = data["scale"];
//            return oc.Create().AsString();
//        }
//    }
//}
