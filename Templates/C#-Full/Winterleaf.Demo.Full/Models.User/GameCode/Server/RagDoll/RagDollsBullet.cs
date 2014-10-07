using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.RagDoll
{
    //-----------------------------------------------------------------------------
    // Sample rag dolls for bullet
    //-----------------------------------------------------------------------------

    //shape $ShapeType::Box,$ShapeType::Sphere, $ShapeType::Capsule - 2   
    //joint $JointType::ConeTwist, $JointType::Hinge, $JointType::Dof6", $JointType::BallSocket"
    public class RagDollsBullet
    {
        public static void initialize()
        {
            #region RagDollData (SpaceOrcRagDoll)        oc_Newobject1
            DatablockCreator oc_Newobject1 = new DatablockCreator("RagDollData", "SpaceOrcRagDoll");
            oc_Newobject1["category"] = "RigidBody";
            oc_Newobject1["shapeFile"] = "art/shapes/actors/SpaceOrc/SpaceOrc.dts";
            oc_Newobject1["minContactSpeed"] = new ObjectCreator.StringNoQuote("5.0");
            oc_Newobject1["slidingThreshold"] = new ObjectCreator.StringNoQuote("0.5");
            oc_Newobject1["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["collisionSound[0]"] = new ObjectCreator.StringNoQuote("bodyFall0");
            oc_Newobject1["boneNodeName[0]"] = "Bip01 Pelvis";
            oc_Newobject1["boneSize[0]"] = "0.4 0.1 0.0";
            oc_Newobject1["boneMass[0]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[0]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[0]"] = "0 0 0";
            oc_Newobject1["boneParentNodeName[1]"] = "Bip01 Pelvis";
            oc_Newobject1["boneNodeName[1]"] = "Bip01 Spine2";
            oc_Newobject1["boneSize[1]"] = "0.2 0.2 0.0";
            oc_Newobject1["boneMass[1]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[1]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneJointType[1]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneOffset[1]"] = "0 0 0";
            oc_Newobject1["boneJointParam[1]"] = "0 1.57 0";
            oc_Newobject1["boneParentNodeName[2]"] = "Bip01 Spine2";
            oc_Newobject1["boneNodeName[2]"] = "Bip01 Head";
            oc_Newobject1["boneSize[2]"] = "0.2 0.1 0.0";
            oc_Newobject1["boneMass[2]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[2]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[2]"] = "0 0 0";
            oc_Newobject1["boneJointType[2]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[2]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[3]"] = "Bip01 Spine2";
            oc_Newobject1["boneNodeName[3]"] = "Bip01 L UpperArm";
            oc_Newobject1["boneSize[3]"] = "0.2 0.3 0.0";
            oc_Newobject1["boneMass[3]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[3]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[3]"] = "0 0 0";
            oc_Newobject1["boneJointType[3]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[3]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[4]"] = "Bip01 L UpperArm";
            oc_Newobject1["boneNodeName[4]"] = "Bip01 L Forearm";
            oc_Newobject1["boneSize[4]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[4]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[4]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[4]"] = "0 0 0";
            oc_Newobject1["boneJointType[4]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[4]"] = "-1.57 0 0";
            oc_Newobject1["boneParentNodeName[5]"] = "Bip01 Spine2";
            oc_Newobject1["boneNodeName[5]"] = "Bip01 R UpperArm";
            oc_Newobject1["boneSize[5]"] = "0.2 0.3 0.0";
            oc_Newobject1["boneMass[5]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[5]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[5]"] = "0 0 0";
            oc_Newobject1["boneJointType[5]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[5]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[6]"] = "Bip01 R UpperArm";
            oc_Newobject1["boneNodeName[6]"] = "Bip01 R Forearm";
            oc_Newobject1["boneSize[6]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[6]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[6]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[6]"] = "0 0 0";
            oc_Newobject1["boneJointType[6]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[6]"] = "-1.57 0 0";
            oc_Newobject1["boneParentNodeName[7]"] = "Bip01 Pelvis";
            oc_Newobject1["boneNodeName[7]"] = "Bip01 L Thigh";
            oc_Newobject1["boneSize[7]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[7]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[7]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[7]"] = "0 0 0";
            oc_Newobject1["boneJointType[7]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[7]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[8]"] = "Bip01 L Thigh";
            oc_Newobject1["boneNodeName[8]"] = "Bip01 L Calf";
            oc_Newobject1["boneSize[8]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[8]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[8]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[8]"] = "0 0 0";
            oc_Newobject1["boneJointType[8]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[8]"] = "-1.57 0 0";
            oc_Newobject1["boneParentNodeName[9]"] = "Bip01 Pelvis";
            oc_Newobject1["boneNodeName[9]"] = "Bip01 R Thigh";
            oc_Newobject1["boneSize[9]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[9]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[9]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[9]"] = "0 0 0";
            oc_Newobject1["boneJointType[9]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[9]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[10]"] = "Bip01 R Thigh";
            oc_Newobject1["boneNodeName[10]"] = "Bip01 R Calf";
            oc_Newobject1["boneSize[10]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[10]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject1["boneShape[10]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[10]"] = "0 0 0";
            oc_Newobject1["boneJointType[10]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[10]"] = "-1.57 0 0";
            #endregion
            oc_Newobject1.Create();

            #region RagDollData (ElfRagDoll)        oc_Newobject2
            DatablockCreator oc_Newobject2 = new DatablockCreator("RagDollData", "ElfRagDoll");
            oc_Newobject2["category"] = "RigidBody";
            oc_Newobject2["shapeFile"] = "art/shapes/actors/Elf/Elf.dts";
            oc_Newobject2["minContactSpeed"] = new ObjectCreator.StringNoQuote("2.0");
            oc_Newobject2["collisionSoundsCount"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["collisionSound[0]"] = new ObjectCreator.StringNoQuote("bodyFall0");
            oc_Newobject2["boneNodeName[0]"] = "Bip01 Pelvis";
            oc_Newobject2["boneSize[0]"] = "0.2 0.2 0.7";
            oc_Newobject2["boneMass[0]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[0]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[0]"] = "0 0 0";
            oc_Newobject2["boneParentNodeName[1]"] = "Bip01 Pelvis";
            oc_Newobject2["boneNodeName[1]"] = "Bip01 Spine2";
            oc_Newobject2["boneSize[1]"] = "0.2 0.2 0.7";
            oc_Newobject2["boneMass[1]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[1]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneJointType[1]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneOffset[1]"] = "-0.3 0 0";
            oc_Newobject2["boneJointParam[1]"] = "0 1.57 0";
            oc_Newobject2["boneParentNodeName[2]"] = "Bip01 Spine2";
            oc_Newobject2["boneNodeName[2]"] = "Bip01 Head";
            oc_Newobject2["boneSize[2]"] = "0.2 0.2 0.2";
            oc_Newobject2["boneMass[2]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[2]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[2]"] = "0 0 0";
            oc_Newobject2["boneJointType[2]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[2]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[3]"] = "Bip01 Spine2";
            oc_Newobject2["boneNodeName[3]"] = "Bip01 L UpperArm";
            oc_Newobject2["boneSize[3]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[3]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[3]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[3]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[3]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[3]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[4]"] = "Bip01 L UpperArm";
            oc_Newobject2["boneNodeName[4]"] = "Bip01 L Forearm";
            oc_Newobject2["boneSize[4]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[4]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[4]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[4]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[4]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[4]"] = "-1.57 0 0";
            oc_Newobject2["boneParentNodeName[5]"] = "Bip01 Spine2";
            oc_Newobject2["boneNodeName[5]"] = "Bip01 R UpperArm";
            oc_Newobject2["boneSize[5]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[5]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[5]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[5]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[5]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[5]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[6]"] = "Bip01 R UpperArm";
            oc_Newobject2["boneNodeName[6]"] = "Bip01 R Forearm";
            oc_Newobject2["boneSize[6]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[6]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[6]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[6]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[6]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[6]"] = "-1.57 0 0";
            oc_Newobject2["boneParentNodeName[7]"] = "Bip01 Pelvis";
            oc_Newobject2["boneNodeName[7]"] = "Bip01 L Thigh";
            oc_Newobject2["boneSize[7]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[7]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[7]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[7]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[7]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[7]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[8]"] = "Bip01 L Thigh";
            oc_Newobject2["boneNodeName[8]"] = "Bip01 L Calf";
            oc_Newobject2["boneSize[8]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[8]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[8]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[8]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[8]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[8]"] = "-1.57 0 0";
            oc_Newobject2["boneParentNodeName[9]"] = "Bip01 Pelvis";
            oc_Newobject2["boneNodeName[9]"] = "Bip01 R Thigh";
            oc_Newobject2["boneSize[9]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[9]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[9]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[9]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[9]"] = new ObjectCreator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[9]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[10]"] = "Bip01 R Thigh";
            oc_Newobject2["boneNodeName[10]"] = "Bip01 R Calf";
            oc_Newobject2["boneSize[10]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[10]"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["boneShape[10]"] = new ObjectCreator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[10]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[10]"] = new ObjectCreator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[10]"] = "-1.57 0 0";
            #endregion
            oc_Newobject2.Create();
        }
    }
}
