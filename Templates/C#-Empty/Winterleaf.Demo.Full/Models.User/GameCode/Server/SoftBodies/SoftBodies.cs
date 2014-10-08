using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//-----------------------------------------------------------------------------
// Logicking's Game Factory
// Copyright (C) Logicking.com, Inc.
//-----------------------------------------------------------------------------
// Sample soft bodies
//-----------------------------------------------------------------------------
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.SoftBodies
{
    public class SoftBodies
    {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
        {
            #region SoftBodyData ( PhysFlag )        oc_Newobject1
            DatablockCreator oc_Newobject1 = new DatablockCreator("SoftBodyData", " PhysFlag ");
            oc_Newobject1["category"] = "SoftBody";
            oc_Newobject1["shapeFile"] = "art/shapes/flag/Triapko.dts";
            oc_Newobject1["mass"] = new ObjectCreator.StringNoQuote("5");
            oc_Newobject1["poseMatchKoef"] = new ObjectCreator.StringNoQuote("0");
            oc_Newobject1["scale"] = "1 1 1";
            oc_Newobject1["attachedPointsNum"] = new ObjectCreator.StringNoQuote("2");
            oc_Newobject1["attachedPoints[0]"] = "-10 10 0";
            oc_Newobject1["attachedPoints[1]"] = "10 10 0";
            oc_Newobject1["onlyOnClient"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject1.Create();

            #region SoftBodyData ( PhysSoftSphere )        oc_Newobject2
            DatablockCreator oc_Newobject2 = new DatablockCreator("SoftBodyData", " PhysSoftSphere ");
            oc_Newobject2["category"] = "SoftBody";
            oc_Newobject2["shapeFile"] = "art/shapes/ball/ball.dts";
            oc_Newobject2["shapeType"] = new ObjectCreator.StringNoQuote("$ShapeType::SoftMesh");
            oc_Newobject2["mass"] = new ObjectCreator.StringNoQuote("3");
            oc_Newobject2["scale"] = "0.4 0.4 0.4";
            oc_Newobject2["poseMatchKoef"] = new ObjectCreator.StringNoQuote("0.2");
            oc_Newobject2["slidingThreshold"] = new ObjectCreator.StringNoQuote("0.7");
            oc_Newobject2["minContactSpeed"] = new ObjectCreator.StringNoQuote("1.0");
            oc_Newobject2["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["collisionSound[0]"] = new ObjectCreator.StringNoQuote("boxFall0");
            oc_Newobject2["slideSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["slideSound[0]"] = new ObjectCreator.StringNoQuote("stoneRoll0");
            oc_Newobject2["onlyOnClient"] = new ObjectCreator.StringNoQuote("true");
            #endregion
            oc_Newobject2.Create();

            //-----------------------------------------------------------------------------
            // for Game Mechanics Editor
            //-----------------------------------------------------------------------------
            omni.Util.activatePackage("TemplateFunctions");

            //TODO FIX
            //inheritTemplate("PhysFlag", "AbstractRigidBody");
            //registerTemplate("PhysFlag", "Physics", "SoftBodyData::create(PhysFlag);");

            //inheritTemplate("PhysSoftSphere", "AbstractRigidBody");
            //registerTemplate("PhysSoftSphere", "Physics", "SoftBodyData::create(PhysSoftSphere);");

            omni.Util.deactivatePackage("TemplateFunctions");
        }
    }
}
