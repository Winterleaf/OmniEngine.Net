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
            oc_Newobject1["minContactSpeed"] = new Creator.StringNoQuote("5.0");
            oc_Newobject1["slidingThreshold"] = new Creator.StringNoQuote("0.5");
            oc_Newobject1["collisionSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject1["collisionSound[0]"] = new Creator.StringNoQuote("bodyFall0");
            oc_Newobject1["boneNodeName[0]"] = "Bip01 Pelvis";
            oc_Newobject1["boneSize[0]"] = "0.4 0.1 0.0";
            oc_Newobject1["boneMass[0]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[0]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[0]"] = "0 0 0";
            oc_Newobject1["boneParentNodeName[1]"] = "Bip01 Pelvis";
            oc_Newobject1["boneNodeName[1]"] = "Bip01 Spine2";
            oc_Newobject1["boneSize[1]"] = "0.2 0.2 0.0";
            oc_Newobject1["boneMass[1]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[1]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneJointType[1]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneOffset[1]"] = "0 0 0";
            oc_Newobject1["boneJointParam[1]"] = "0 1.57 0";
            oc_Newobject1["boneParentNodeName[2]"] = "Bip01 Spine2";
            oc_Newobject1["boneNodeName[2]"] = "Bip01 Head";
            oc_Newobject1["boneSize[2]"] = "0.2 0.1 0.0";
            oc_Newobject1["boneMass[2]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[2]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[2]"] = "0 0 0";
            oc_Newobject1["boneJointType[2]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[2]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[3]"] = "Bip01 Spine2";
            oc_Newobject1["boneNodeName[3]"] = "Bip01 L UpperArm";
            oc_Newobject1["boneSize[3]"] = "0.2 0.3 0.0";
            oc_Newobject1["boneMass[3]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[3]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[3]"] = "0 0 0";
            oc_Newobject1["boneJointType[3]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[3]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[4]"] = "Bip01 L UpperArm";
            oc_Newobject1["boneNodeName[4]"] = "Bip01 L Forearm";
            oc_Newobject1["boneSize[4]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[4]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[4]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[4]"] = "0 0 0";
            oc_Newobject1["boneJointType[4]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[4]"] = "-1.57 0 0";
            oc_Newobject1["boneParentNodeName[5]"] = "Bip01 Spine2";
            oc_Newobject1["boneNodeName[5]"] = "Bip01 R UpperArm";
            oc_Newobject1["boneSize[5]"] = "0.2 0.3 0.0";
            oc_Newobject1["boneMass[5]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[5]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[5]"] = "0 0 0";
            oc_Newobject1["boneJointType[5]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[5]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[6]"] = "Bip01 R UpperArm";
            oc_Newobject1["boneNodeName[6]"] = "Bip01 R Forearm";
            oc_Newobject1["boneSize[6]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[6]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[6]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[6]"] = "0 0 0";
            oc_Newobject1["boneJointType[6]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[6]"] = "-1.57 0 0";
            oc_Newobject1["boneParentNodeName[7]"] = "Bip01 Pelvis";
            oc_Newobject1["boneNodeName[7]"] = "Bip01 L Thigh";
            oc_Newobject1["boneSize[7]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[7]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[7]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[7]"] = "0 0 0";
            oc_Newobject1["boneJointType[7]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[7]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[8]"] = "Bip01 L Thigh";
            oc_Newobject1["boneNodeName[8]"] = "Bip01 L Calf";
            oc_Newobject1["boneSize[8]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[8]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[8]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[8]"] = "0 0 0";
            oc_Newobject1["boneJointType[8]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[8]"] = "-1.57 0 0";
            oc_Newobject1["boneParentNodeName[9]"] = "Bip01 Pelvis";
            oc_Newobject1["boneNodeName[9]"] = "Bip01 R Thigh";
            oc_Newobject1["boneSize[9]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[9]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[9]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[9]"] = "0 0 0";
            oc_Newobject1["boneJointType[9]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject1["boneJointParam[9]"] = "0.785 0.785 0";
            oc_Newobject1["boneParentNodeName[10]"] = "Bip01 R Thigh";
            oc_Newobject1["boneNodeName[10]"] = "Bip01 R Calf";
            oc_Newobject1["boneSize[10]"] = "0.2 0.4 0.0";
            oc_Newobject1["boneMass[10]"] = new Creator.StringNoQuote("1");
            oc_Newobject1["boneShape[10]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject1["boneOffset[10]"] = "0 0 0";
            oc_Newobject1["boneJointType[10]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject1["boneJointParam[10]"] = "-1.57 0 0";

            #endregion

            oc_Newobject1.Create();

            #region RagDollData (ElfRagDoll)        oc_Newobject2

            DatablockCreator oc_Newobject2 = new DatablockCreator("RagDollData", "ElfRagDoll");
            oc_Newobject2["category"] = "RigidBody";
            oc_Newobject2["shapeFile"] = "art/shapes/actors/Elf/Elf.dts";
            oc_Newobject2["minContactSpeed"] = new Creator.StringNoQuote("2.0");
            oc_Newobject2["collisionSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject2["collisionSound[0]"] = new Creator.StringNoQuote("bodyFall0");
            oc_Newobject2["boneNodeName[0]"] = "Bip01 Pelvis";
            oc_Newobject2["boneSize[0]"] = "0.2 0.2 0.7";
            oc_Newobject2["boneMass[0]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[0]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[0]"] = "0 0 0";
            oc_Newobject2["boneParentNodeName[1]"] = "Bip01 Pelvis";
            oc_Newobject2["boneNodeName[1]"] = "Bip01 Spine2";
            oc_Newobject2["boneSize[1]"] = "0.2 0.2 0.7";
            oc_Newobject2["boneMass[1]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[1]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneJointType[1]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneOffset[1]"] = "-0.3 0 0";
            oc_Newobject2["boneJointParam[1]"] = "0 1.57 0";
            oc_Newobject2["boneParentNodeName[2]"] = "Bip01 Spine2";
            oc_Newobject2["boneNodeName[2]"] = "Bip01 Head";
            oc_Newobject2["boneSize[2]"] = "0.2 0.2 0.2";
            oc_Newobject2["boneMass[2]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[2]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[2]"] = "0 0 0";
            oc_Newobject2["boneJointType[2]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[2]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[3]"] = "Bip01 Spine2";
            oc_Newobject2["boneNodeName[3]"] = "Bip01 L UpperArm";
            oc_Newobject2["boneSize[3]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[3]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[3]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[3]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[3]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[3]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[4]"] = "Bip01 L UpperArm";
            oc_Newobject2["boneNodeName[4]"] = "Bip01 L Forearm";
            oc_Newobject2["boneSize[4]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[4]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[4]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[4]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[4]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[4]"] = "-1.57 0 0";
            oc_Newobject2["boneParentNodeName[5]"] = "Bip01 Spine2";
            oc_Newobject2["boneNodeName[5]"] = "Bip01 R UpperArm";
            oc_Newobject2["boneSize[5]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[5]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[5]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[5]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[5]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[5]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[6]"] = "Bip01 R UpperArm";
            oc_Newobject2["boneNodeName[6]"] = "Bip01 R Forearm";
            oc_Newobject2["boneSize[6]"] = "0.1 0.2 0.2";
            oc_Newobject2["boneMass[6]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[6]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[6]"] = "0.1 0 0";
            oc_Newobject2["boneJointType[6]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[6]"] = "-1.57 0 0";
            oc_Newobject2["boneParentNodeName[7]"] = "Bip01 Pelvis";
            oc_Newobject2["boneNodeName[7]"] = "Bip01 L Thigh";
            oc_Newobject2["boneSize[7]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[7]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[7]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[7]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[7]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[7]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[8]"] = "Bip01 L Thigh";
            oc_Newobject2["boneNodeName[8]"] = "Bip01 L Calf";
            oc_Newobject2["boneSize[8]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[8]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[8]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[8]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[8]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[8]"] = "-1.57 0 0";
            oc_Newobject2["boneParentNodeName[9]"] = "Bip01 Pelvis";
            oc_Newobject2["boneNodeName[9]"] = "Bip01 R Thigh";
            oc_Newobject2["boneSize[9]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[9]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[9]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[9]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[9]"] = new Creator.StringNoQuote("$JointType::ConeTwist");
            oc_Newobject2["boneJointParam[9]"] = "0.785 0.785 0";
            oc_Newobject2["boneParentNodeName[10]"] = "Bip01 R Thigh";
            oc_Newobject2["boneNodeName[10]"] = "Bip01 R Calf";
            oc_Newobject2["boneSize[10]"] = "0.15 0.4 0.2";
            oc_Newobject2["boneMass[10]"] = new Creator.StringNoQuote("1");
            oc_Newobject2["boneShape[10]"] = new Creator.StringNoQuote("$ShapeType::Capsule");
            oc_Newobject2["boneOffset[10]"] = "0.0 0 0";
            oc_Newobject2["boneJointType[10]"] = new Creator.StringNoQuote("$JointType::Hinge");
            oc_Newobject2["boneJointParam[10]"] = "-1.57 0 0";

            #endregion

            oc_Newobject2.Create();
        }
    }
}