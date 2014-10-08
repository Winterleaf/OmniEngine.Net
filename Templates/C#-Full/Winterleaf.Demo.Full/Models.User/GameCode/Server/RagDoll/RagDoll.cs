//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
//using WinterLeaf.Engine.Classes.Decorations;
//using WinterLeaf.Engine.Classes.Extensions;
//using WinterLeaf.Engine.Classes.Interopt;
//using WinterLeaf.Engine.Classes.View.Creators;
//using WinterLeaf.Engine.Containers;

//namespace WinterLeaf.Demo.Full.Models.User.Extendable
//{
//    public partial class RagDollData
//    {
//        private static readonly pInvokes omni = new pInvokes();

//        [ConsoleInteraction]
//        public virtual string create(string block)
//        {   
//            // The mission editor invokes this method when it wants to create   
//            // an object of the given datablock type.   
//            #region RagDoll ()        oc_Newobject1
//            ObjectCreator oc_Newobject1 = new ObjectCreator("RagDoll", "");
//            oc_Newobject1["dataBlock"] = block;
//            #endregion
//            return oc_Newobject1.Create().AsString();
//        }

//        [ConsoleInteraction]
//        public static string createRagDoll(string ragdollData, SimObject obj)
//        {
//            #region RagDoll ()        oc_Newobject2
//            ObjectCreator oc_Newobject2 = new ObjectCreator("RagDoll", "");
//            oc_Newobject2["position"] = "0 0 0" ;
//            oc_Newobject2["rotation"] = "1 0 0 0" ;
//            oc_Newobject2["dataBlock"] = ragdollData;
//            #endregion
//            RagDoll ragDoll_obj = oc_Newobject2.Create();
            
//            ragDoll_obj.initRagDoll(obj);
   
//            Point3F force = omni.Util.VectorSub(obj.call("getPosition").AsPoint3F(), obj["damagePos"].AsPoint3F());
//            force = omni.Util.setWord(force.AsString(), 2, "0").AsPoint3F();
//            force = omni.Util.VectorNormalize(force);
//            force = omni.Util.VectorScale(force,1500);
//            ragDoll_obj.applyImpulse(obj["damagePos"].AsPoint3F(),force);
//            //%ragDoll_obj.applyImpulse(%obj.damagePos, "1500 0 0");

//            ragDoll_obj.schedule((omni.iGlobal["$CorpseTimeoutValue"] - 1000).AsString(), "startFade", "1000", "0", true.AsString());
//            ragDoll_obj.schedule(omni.sGlobal["$CorpseTimeoutValue"], "delete");

//            return ragDoll_obj;
//        }

//        [ConsoleInteraction]
//        public static void cro()
//        {
//            #region AIBot (orc)        oc_Newobject3
//            ObjectCreator oc_Newobject3 = new ObjectCreator("AIBot", "orc");
//            oc_Newobject3["dataBlock"] = "SpaceOrcBotData";
//            oc_Newobject3["position"] = "530 660 256.41";
//            oc_Newobject3["rotation"] = "1 0 0 0";
//            oc_Newobject3["scale"] = "1 1 1";
//            oc_Newobject3["canSave"] = "1";
//            oc_Newobject3["canSaveDynamicFields"] = "1";
//            oc_Newobject3["Enabled"] = "1";
//            oc_Newobject3["blockMovement"] = "false";
//            oc_Newobject3["category"] = "AI";
//            oc_Newobject3["editorIcon"] = "tools/LogickingEditor/images/AI";
//            oc_Newobject3["guardCloseDist"] = "3";
//            oc_Newobject3["guardFarDist"] = "5";
//            oc_Newobject3["Health"] = "100";
//            oc_Newobject3["invBlasterAmmo"] = "3000";
//            oc_Newobject3["Item"] = "HealthPatch";
//            oc_Newobject3["perceptionEnabled"] = "false";
//            oc_Newobject3["templateName"] = "SpaceOrcBot";
//            oc_Newobject3["viewDist"] = "40";
//            #endregion
//            oc_Newobject3.Create();
//        }

//        [ConsoleInteraction]
//        public static void ite()
//        {
//            #region Item (ite)        oc_Newobject4
//            ObjectCreator oc_Newobject4 = new ObjectCreator("Item", "ite");
//            oc_Newobject4["position"] = "530 660 256.41";
//            oc_Newobject4["rotation"] = "1 0 0 0";
//            oc_Newobject4["dataBlock"] = "HealthPatch";
//            oc_Newobject4["rotate"] = new ObjectCreator.StringNoQuote("true");
//            #endregion
//            oc_Newobject4.Create();
//        }

//        [ConsoleInteraction]
//        public static void en()
//        {
//            AIBot orc = "orc";
//            orc.setEnemy(omni.sGlobal["$playerForAi"]);
//        }

//        [ConsoleInteraction]
//        public static void sh()
//        {
//            AIBot orc = "orc";
//            orc.setImageTrigger(0, true);
//            orc.setImageTrigger(0, false);
//        }

//        [ConsoleInteraction]
//        public static void de()
//        {
//            AIBot orc = "orc";
//            orc.delete();
//        }

//        [ConsoleInteraction]
//        public static void rag()
//        {
//            #region RagDoll ( rd)        oc_Newobject5
//            ObjectCreator oc_Newobject5 = new ObjectCreator("RagDoll", " rd");
//            oc_Newobject5["position"] = "530 660 256.41";
//            oc_Newobject5["rotation"] = "1 0 0 0";
//            oc_Newobject5["dataBlock"] = new ObjectCreator.StringNoQuote("SpaceOrcRagDoll");
//            #endregion
//            oc_Newobject5.Create();
//        }

//        [ConsoleInteraction]
//        public static void bar()
//        {
//            #region StaticShape (bar)        oc_Newobject6
//            ObjectCreator oc_Newobject6 = new ObjectCreator("StaticShape", "bar", typeof(Breakable));
//            oc_Newobject6["receiveSunLight"] = "1";
//            oc_Newobject6["receiveLMLighting"] = "1";
//            oc_Newobject6["useCustomAmbientLighting"] = "0";
//            oc_Newobject6["customAmbientLighting"] = "0 0 0 1";
//            oc_Newobject6["dataBlock"] = "SteelBarrel";
//            oc_Newobject6["position"] = "530 660 256.41";
//            oc_Newobject6["rotation"] = "1 0 0 0";
//            oc_Newobject6["scale"] = "1 1 1";
//            oc_Newobject6["canSaveDynamicFields"] = "1";
//            //oc_Newobject6["class"] = "Breakable";
//            //oc_Newobject6["className"] = "Breakable";
//            oc_Newobject6["Enabled"] = "1";
//            oc_Newobject6["category"] = "Breakables";
//            oc_Newobject6["Collision"] = "0";
//            oc_Newobject6["editorIcon"] = "tools/missionEditor/images/Breakable";
//            oc_Newobject6["health"] = "60";
//            oc_Newobject6["healthBound"] = "50";
//            oc_Newobject6["templateName"] = "SteelBarrel";
//            #endregion
//            oc_Newobject6.Create();
//        }
//    }
//}
