//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using WinterLeaf.Demo.Full.Models.User.Extendable;
//using WinterLeaf.Engine.Classes.Decorations;
//using WinterLeaf.Engine.Classes.Interopt;
//using WinterLeaf.Engine.Classes.View.Creators;
//using WinterLeaf.Engine.Containers;

//namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.RigidBody
//{
//    public class RigidBodiesTest
//    {
//        private static readonly pInvokes omni = new pInvokes();

//        [ConsoleInteraction]
//        public static void coll()
//        {
//            #region TSStatic (coll)        oc_Newobject1
//            ObjectCreator oc_Newobject1 = new ObjectCreator("TSStatic", "coll");
//            oc_Newobject1["canSaveDynamicFields"] = "1";
//            oc_Newobject1["Enabled"] = "1";
//            oc_Newobject1["position"] = "560.095 659.057 258.09";
//            oc_Newobject1["rotation"] = "1 0 0 0";
//            oc_Newobject1["scale"] = "1 1 1";
//            oc_Newobject1["shapeName"] = "art/shapes/test/LMA_LampBase2.dae";
//            oc_Newobject1["receiveSunLight"] = "1";
//            oc_Newobject1["receiveLMLighting"] = "1";
//            oc_Newobject1["useCustomAmbientLighting"] = "0";
//            oc_Newobject1["customAmbientLighting"] = "0 0 0 1";
//            oc_Newobject1["usePolysoup"] = "0";
//            oc_Newobject1["allowPlayerStep"] = "1";
//            oc_Newobject1["renderNormals"] = "0";
//            #endregion
//            oc_Newobject1.Create();
//        }

//        [ConsoleInteraction]
//        public static void crai()
//        {
//            #region RigidBody (rsh)        oc_Newobject1
//            ObjectCreator oc_Newobject1 = new ObjectCreator("RigidBody", "rsh");
//            oc_Newobject1["canSaveDynamicFields"] = "1";
//            oc_Newobject1["Enabled"] = "1";
//            oc_Newobject1["position"] = new ObjectCreator.StringNoQuote("$playerForAi.getPosition()");
//            oc_Newobject1["rotation"] = "1 0 0 0";
//            oc_Newobject1["scale"] = "0.5 0.5 0.5";
//            oc_Newobject1["dataBlock"] = "PhysBox";
//            oc_Newobject1["collision"] = "0";
//            #endregion
//            oc_Newobject1.Create();
//        }

//        [ConsoleInteraction]
//        public static void crpx()
//        {
//            #region PxMultiActor (rsh)        oc_Newobject2
//            ObjectCreator oc_Newobject2 = new ObjectCreator("PxMultiActor", "rsh");
//            oc_Newobject2["canSaveDynamicFields"] = "1";
//            oc_Newobject2["Enabled"] = "1";
//            oc_Newobject2["position"] = "560.095 661.057 261.09";
//            oc_Newobject2["rotation"] = "1 0 0 0";
//            oc_Newobject2["scale"] = "1 1 1";
//            oc_Newobject2["dataBlock"] = "pxBlackBarrel";
//            oc_Newobject2["collision"] = "0";
//            #endregion
//            oc_Newobject2.Create();
//        }

//        [ConsoleInteraction]
//        public static void fl()
//        {
//            #region SoftBody (fl)        oc_Newobject3
//            ObjectCreator oc_Newobject3 = new ObjectCreator("SoftBody", "fl");
//            oc_Newobject3["canSaveDynamicFields"] = "1";
//            oc_Newobject3["Enabled"] = "1";
//            oc_Newobject3["position"] = "560 661 261";
//            oc_Newobject3["rotation"] = "1 0 0 0";
//            oc_Newobject3["scale"] = "1 1 1";
//            oc_Newobject3["dataBlock"] = "PhysFlag";
//            oc_Newobject3["collision"] = "0";
//            #endregion
//            oc_Newobject3.Create();
//        }

//        [ConsoleInteraction]
//        public static void crs2()
//        {
//            #region SoftBody (rsh2)        oc_Newobject4
//            ObjectCreator oc_Newobject4 = new ObjectCreator("SoftBody", "rsh2");
//            oc_Newobject4["canSaveDynamicFields"] = "1";
//            oc_Newobject4["Enabled"] = "1";
//            oc_Newobject4["position"] = "560.095 661.057 261.09";
//            oc_Newobject4["rotation"] = "1 0 0 0";
//            oc_Newobject4["scale"] = "0.3 0.3 0.3";
//            oc_Newobject4["dataBlock"] = "PhysSoftSphere";
//            oc_Newobject4["collision"] = "0";
//            #endregion
//            oc_Newobject4.Create();
//        }

//        [ConsoleInteraction]
//        public static void cr()
//        {
//            #region RigidBody (rsh)        oc_Newobject5
//            ObjectCreator oc_Newobject5 = new ObjectCreator("RigidBody", "rsh");
//            oc_Newobject5["canSaveDynamicFields"] = "1";
//            oc_Newobject5["Enabled"] = "1";
//            oc_Newobject5["position"] = "560.095 661.057 261.09";
//            oc_Newobject5["rotation"] = "1 0 0 0";
//            oc_Newobject5["scale"] = "0.5 0.5 0.5";
//            oc_Newobject5["dataBlock"] = "PhysBox";
//            oc_Newobject5["collision"] = "0";
//            #endregion
//            oc_Newobject5.Create();
//        }

//        [ConsoleInteraction]
//        public static void crup()
//        {
//            SoftBody rsh2 = "rsh2";
//            rsh2.call("setPosition", omni.Util.VectorAdd(new Point3F(0, 0, 2), rsh2.getPosition()).AsString());
//        }

//        [ConsoleInteraction]
//        public static void cr2()
//        {
//            #region RigidBody (rsh2)        oc_Newobject6
//            ObjectCreator oc_Newobject6 = new ObjectCreator("RigidBody", "rsh2");
//            oc_Newobject6["canSaveDynamicFields"] = "1";
//            oc_Newobject6["Enabled"] = "1";
//            oc_Newobject6["position"] = "560.095 661.057 261.09";
//            oc_Newobject6["rotation"] = "1 0 0 0";
//            oc_Newobject6["scale"] = "0.3 0.3 0.3";
//            oc_Newobject6["dataBlock"] = "PhysSphere";
//            oc_Newobject6["collision"] = "0";
//            #endregion
//            oc_Newobject6.Create();
//        }

//        [ConsoleInteraction]
//        public static void cr3()
//        {
//            #region RigidBody (rsh3)        oc_Newobject7
//            ObjectCreator oc_Newobject7 = new ObjectCreator("RigidBody", "rsh3");
//            oc_Newobject7["canSaveDynamicFields"] = "1";
//            oc_Newobject7["Enabled"] = "1";
//            oc_Newobject7["position"] = "355 570 142";
//            oc_Newobject7["rotation"] = "1 0 0 0";
//            oc_Newobject7["scale"] = "1 1 1";
//            oc_Newobject7["dataBlock"] = "PhysBarrel";
//            oc_Newobject7["collision"] = "0";
//            #endregion
//            oc_Newobject7.Create();
//        }

//        [ConsoleInteraction]
//        public static void cr4()
//        {
//            #region RigidBody (rsh4)        oc_Newobject8
//            ObjectCreator oc_Newobject8 = new ObjectCreator("RigidBody", "rsh4");
//            oc_Newobject8["canSaveDynamicFields"] = "1";
//            oc_Newobject8["Enabled"] = "1";
//            oc_Newobject8["position"] = "355 570 142";
//            oc_Newobject8["rotation"] = "1 0 0 0";
//            oc_Newobject8["scale"] = "1 1 1";
//            oc_Newobject8["dataBlock"] = "PhysWheel";
//            oc_Newobject8["collision"] = "0";
//            #endregion
//            oc_Newobject8.Create();
//        }

//        [ConsoleInteraction]
//        public static void ra()
//        {
//            #region RagDoll (rc)        oc_Newobject9
//            ObjectCreator oc_Newobject9 = new ObjectCreator("RagDoll", "rc");
//            oc_Newobject9["canSaveDynamicFields"] = "1";
//            oc_Newobject9["Enabled"] = "1";
//            oc_Newobject9["position"] = "560.095 661.057 257";
//            oc_Newobject9["rotation"] = "1 0 0 0";
//            oc_Newobject9["scale"] = "1 1 1";
//            oc_Newobject9["dataBlock"] = "SpaceOrcRagDoll";
//            oc_Newobject9["collision"] = "0";
//            #endregion
//            oc_Newobject9.Create();
//        }

//        [ConsoleInteraction]
//        public static void orc()
//        {
//            #region AIBot (orc)        oc_Newobject10
//            ObjectCreator oc_Newobject10 = new ObjectCreator("AIBot", "orc");
//            oc_Newobject10["canSaveDynamicFields"] = "1";
//            oc_Newobject10["Enabled"] = "1";
//            oc_Newobject10["position"] = "560.095 661.057 261.09";
//            oc_Newobject10["rotation"] = "1 0 0 0";
//            oc_Newobject10["scale"] = "1 1 1";
//            oc_Newobject10["dataBlock"] = "SpaceOrcBotData";
//            oc_Newobject10["collision"] = "0";
//            #endregion
//            oc_Newobject10.Create();
//        }

//        [ConsoleInteraction]
//        public static void ra2()
//        {
//            #region RagDoll (rc2)        oc_Newobject11
//            ObjectCreator oc_Newobject11 = new ObjectCreator("RagDoll", "rc2");
//            oc_Newobject11["canSaveDynamicFields"] = "1";
//            oc_Newobject11["Enabled"] = "1";
//            oc_Newobject11["position"] = "560.095 661.057 257.09";
//            oc_Newobject11["rotation"] = "1 0 0 0";
//            oc_Newobject11["scale"] = "1 1 1";
//            oc_Newobject11["dataBlock"] = "ElfRagDoll";
//            oc_Newobject11["collision"] = "0";
//            #endregion
//            oc_Newobject11.Create();
//        }

//        [ConsoleInteraction]
//        public static void elf()
//        {
//            #region AIBot (elf)        oc_Newobject12
//            ObjectCreator oc_Newobject12 = new ObjectCreator("AIBot", "elf");
//            oc_Newobject12["canSaveDynamicFields"] = "1";
//            oc_Newobject12["Enabled"] = "1";
//            oc_Newobject12["position"] = "560.095 661.057 257.09";
//            oc_Newobject12["rotation"] = "1 0 0 0";
//            oc_Newobject12["scale"] = "1 1 1";
//            oc_Newobject12["dataBlock"] = "ElfBotData";
//            oc_Newobject12["collision"] = "0";
//            #endregion
//            oc_Newobject12.Create();
//        }

//        [ConsoleInteraction]
//        public static void ra3()
//        {
//            #region RagDoll (rc3)        oc_Newobject13
//            ObjectCreator oc_Newobject13 = new ObjectCreator("RagDoll", "rc3");
//            oc_Newobject13["canSaveDynamicFields"] = "1";
//            oc_Newobject13["Enabled"] = "1";
//            oc_Newobject13["position"] = "357 570 140.763";
//            oc_Newobject13["rotation"] = "1 0 0 0";
//            oc_Newobject13["scale"] = "1 1 1";
//            oc_Newobject13["dataBlock"] = "CasualFemaleRagDoll";
//            oc_Newobject13["collision"] = "0";
//            #endregion
//            oc_Newobject13.Create();
//        }

//        [ConsoleInteraction]
//        public static void casual()
//        {
//            #region AIBot (casual)        oc_Newobject14
//            ObjectCreator oc_Newobject14 = new ObjectCreator("AIBot", "casual");
//            oc_Newobject14["canSaveDynamicFields"] = "1";
//            oc_Newobject14["Enabled"] = "1";
//            oc_Newobject14["position"] = "357 570 140.763";
//            oc_Newobject14["rotation"] = "1 0 0 0";
//            oc_Newobject14["scale"] = "1 1 1";
//            oc_Newobject14["dataBlock"] = "CasualFemaleBotData";
//            oc_Newobject14["collision"] = "0";
//            #endregion
//            oc_Newobject14.Create();
//        }
//    }
//}
