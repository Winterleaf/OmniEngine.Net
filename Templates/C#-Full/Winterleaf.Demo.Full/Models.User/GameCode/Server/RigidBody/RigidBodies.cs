using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.RigidBody
{
    public class RigidBodies
    {
        public static void initialize()
        {
            #region SFXProfile (boxFall0)        oc_Newobject1
            DatablockCreator oc_Newobject1 = new DatablockCreator("SFXProfile", "boxFall0");
            oc_Newobject1["filename"] = "art/sound/physics/boxFall0";
            oc_Newobject1["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject1["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject1.Create();

            #region SFXProfile (boxFall1)        oc_Newobject2
            DatablockCreator oc_Newobject2 = new DatablockCreator("SFXProfile", "boxFall1");
            oc_Newobject2["filename"] = "art/sound/physics/boxFall1";
            oc_Newobject2["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject2["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject2.Create();

            #region SFXProfile (boxFall2)        oc_Newobject3
            DatablockCreator oc_Newobject3 = new DatablockCreator("SFXProfile", "boxFall2");
            oc_Newobject3["filename"] = "art/sound/physics/boxFall2";
            oc_Newobject3["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject3["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject3.Create();

            #region RigidBodyData ( PhysBox )        oc_Newobject4
            DatablockCreator oc_Newobject4 = new DatablockCreator("RigidBodyData", " PhysBox ");
            oc_Newobject4["category"] = "RigidBody";
            oc_Newobject4["shapeFile"] = "art/shapes/crates/crate1.dts";
            oc_Newobject4["shapeType"] = new ObjectCreator.StringNoQuote("$ShapeType::Box");
            oc_Newobject4["mass"] = new ObjectCreator.StringNoQuote("2");
            oc_Newobject4["scale"] = "0.5 0.5 0.5";
            oc_Newobject4["minContactSpeed"] = new ObjectCreator.StringNoQuote("1.0");
            oc_Newobject4["slidingThreshold"] = new ObjectCreator.StringNoQuote("0.1");
            oc_Newobject4["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("3");
            oc_Newobject4["collisionSound[0]"] = new ObjectCreator.StringNoQuote("boxFall0");
            oc_Newobject4["collisionSound[1]"] = new ObjectCreator.StringNoQuote("boxFall1");
            oc_Newobject4["collisionSound[2]"] = new ObjectCreator.StringNoQuote("boxFall2");
            #endregion
            oc_Newobject4.Create();

            #region SFXProfile (stoneRoll0)        oc_Newobject5
            DatablockCreator oc_Newobject5 = new DatablockCreator("SFXProfile", "stoneRoll0");
            oc_Newobject5["filename"] = "art/sound/physics/stoneRoll";
            oc_Newobject5["description"] = new ObjectCreator.StringNoQuote("AudioClosest3d");
            oc_Newobject5["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject5.Create();

            #region RigidBodyData ( StatPhysBox )        oc_Newobject6
            DatablockCreator oc_Newobject6 = new DatablockCreator("RigidBodyData", " StatPhysBox ");
            oc_Newobject6["category"] = "RigidBody";
            oc_Newobject6["shapeFile"] = "art/shapes/crates/crate1.dts";
            oc_Newobject6["shapeType"] = new ObjectCreator.StringNoQuote("$ShapeType::Box");
            oc_Newobject6["mass"] = new ObjectCreator.StringNoQuote("0");
            #endregion
            oc_Newobject6.Create();

            #region RigidBodyData ( PhysSphere )        oc_Newobject7
            DatablockCreator oc_Newobject7 = new DatablockCreator("RigidBodyData", " PhysSphere ");
            oc_Newobject7["category"] = "RigidBody";
            oc_Newobject7["shapeFile"] = "art/shapes/rocks/boulder.dts";
            oc_Newobject7["shapeType"] = new ObjectCreator.StringNoQuote("$ShapeType::Sphere");
            oc_Newobject7["mass"] = new ObjectCreator.StringNoQuote("5");
            oc_Newobject7["scale"] = "0.3 0.3 0.3";
            oc_Newobject7["slidingThreshold"] = new ObjectCreator.StringNoQuote("0.7");
            oc_Newobject7["minContactSpeed"] = new ObjectCreator.StringNoQuote("1.0");
            oc_Newobject7["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject7["collisionSound[0]"] = new ObjectCreator.StringNoQuote("boxFall0");
            oc_Newobject7["slideSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject7["slideSound[0]"] = new ObjectCreator.StringNoQuote("stoneRoll0");
            #endregion
            oc_Newobject7.Create();

            #region SFXProfile (barrelFall0)        oc_Newobject8
            DatablockCreator oc_Newobject8 = new DatablockCreator("SFXProfile", "barrelFall0");
            oc_Newobject8["filename"] = "art/sound/physics/barrelFall0";
            oc_Newobject8["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject8["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject8.Create();

            #region SFXProfile (barrelFall1)        oc_Newobject9
            DatablockCreator oc_Newobject9 = new DatablockCreator("SFXProfile", "barrelFall1");
            oc_Newobject9["filename"] = "art/sound/physics/barrelFall1";
            oc_Newobject9["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject9["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject9.Create();

            #region SFXProfile (barrelRoll)        oc_Newobject10
            DatablockCreator oc_Newobject10 = new DatablockCreator("SFXProfile", "barrelRoll");
            oc_Newobject10["filename"] = "art/sound/physics/barrelFall1";
            oc_Newobject10["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject10["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject10.Create();

            #region RigidBodyData ( PhysBarrel )        oc_Newobject11
            DatablockCreator oc_Newobject11 = new DatablockCreator("RigidBodyData", " PhysBarrel ");
            oc_Newobject11["category"] = "RigidBody";
            oc_Newobject11["shapeFile"] = "art/shapes/steel_barrel_green/steel_barrel_green.dts";
            oc_Newobject11["shapeType"] = new ObjectCreator.StringNoQuote("$ShapeType::Cylinder");
            oc_Newobject11["rotAngles"] = "0 0 0 0";
            oc_Newobject11["offset"] = "0 0 0.5 0";
            oc_Newobject11["mass"] = new ObjectCreator.StringNoQuote("4");
            oc_Newobject11["slidingThreshold"] = new ObjectCreator.StringNoQuote("0.7");
            oc_Newobject11["minContactSpeed"] = new ObjectCreator.StringNoQuote("1.0");
            oc_Newobject11["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject11["collisionSound[0]"] = new ObjectCreator.StringNoQuote("barrelFall0");
            oc_Newobject11["collisionSound[1]"] = new ObjectCreator.StringNoQuote("barrelFall1");
            oc_Newobject11["slideSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject11["slideSound[0]"] = new ObjectCreator.StringNoQuote("barrelRoll");
            #endregion
            oc_Newobject11.Create();

            #region SFXProfile (wheelFall0)        oc_Newobject12
            DatablockCreator oc_Newobject12 = new DatablockCreator("SFXProfile", "wheelFall0");
            oc_Newobject12["filename"] = "art/sound/physics/wheelFall0";
            oc_Newobject12["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject12["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject12.Create();

            #region SFXProfile (wheelFall1)        oc_Newobject13
            DatablockCreator oc_Newobject13 = new DatablockCreator("SFXProfile", "wheelFall1");
            oc_Newobject13["filename"] = "art/sound/physics/wheelFall1";
            oc_Newobject13["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject13["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject13.Create();

            #region SFXProfile (wheelFall2)        oc_Newobject14
            DatablockCreator oc_Newobject14 = new DatablockCreator("SFXProfile", "wheelFall2");
            oc_Newobject14["filename"] = "art/sound/physics/wheelFall2";
            oc_Newobject14["description"] = new ObjectCreator.StringNoQuote("AudioDefault3d");
            oc_Newobject14["preload"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject14.Create();

            #region RigidBodyData ( PhysWheel )        oc_Newobject15
            DatablockCreator oc_Newobject15 = new DatablockCreator("RigidBodyData", " PhysWheel ");
            oc_Newobject15["category"] = "RigidBody";
            oc_Newobject15["shapeFile"] = "art/shapes/Wheel/Wheel.dts";
            oc_Newobject15["shapeType"] = new ObjectCreator.StringNoQuote("$ShapeType::Cylinder");
            oc_Newobject15["mass"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject15["rotAngles"] = "0 90 0 0";
            oc_Newobject15["offset"] = "0 0 0 0";
            oc_Newobject15["slidingThreshold"] = new ObjectCreator.StringNoQuote("0.7");
            oc_Newobject15["minContactSpeed"] = new ObjectCreator.StringNoQuote("1.0");
            oc_Newobject15["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject15["collisionSound[0]"] = new ObjectCreator.StringNoQuote("wheelFall0");
            oc_Newobject15["collisionSound[1]"] = new ObjectCreator.StringNoQuote("wheelFall1");
            oc_Newobject15["collisionSound[2]"] = new ObjectCreator.StringNoQuote("wheelFall2");
            oc_Newobject15["slideSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject15["slideSound[0]"] = new ObjectCreator.StringNoQuote("wheelFall0");
            #endregion
            oc_Newobject15.Create();
        }
    }
}
