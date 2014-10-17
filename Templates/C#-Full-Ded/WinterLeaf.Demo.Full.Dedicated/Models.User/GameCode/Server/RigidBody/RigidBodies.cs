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

namespace Winterleaf.Demo.Full.Dedicated.Models.User.GameCode.Server.RigidBody
{
    public class RigidBodies
    {
        public static void initialize()
        {
            #region SFXProfile (boxFall0)        oc_Newobject1

            DatablockCreator oc_Newobject1 = new DatablockCreator("SFXProfile", "boxFall0");
            oc_Newobject1["filename"] = "art/sound/physics/boxFall0";
            oc_Newobject1["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject1["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject1.Create();

            #region SFXProfile (boxFall1)        oc_Newobject2

            DatablockCreator oc_Newobject2 = new DatablockCreator("SFXProfile", "boxFall1");
            oc_Newobject2["filename"] = "art/sound/physics/boxFall1";
            oc_Newobject2["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject2["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject2.Create();

            #region SFXProfile (boxFall2)        oc_Newobject3

            DatablockCreator oc_Newobject3 = new DatablockCreator("SFXProfile", "boxFall2");
            oc_Newobject3["filename"] = "art/sound/physics/boxFall2";
            oc_Newobject3["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject3["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject3.Create();

            #region RigidBodyData ( PhysBox )        oc_Newobject4

            DatablockCreator oc_Newobject4 = new DatablockCreator("RigidBodyData", " PhysBox ");
            oc_Newobject4["category"] = "RigidBody";
            oc_Newobject4["shapeFile"] = "art/shapes/crates/crate1.dts";
            oc_Newobject4["shapeType"] = new Creator.StringNoQuote("$ShapeType::Box");
            oc_Newobject4["mass"] = new Creator.StringNoQuote("2");
            oc_Newobject4["scale"] = "0.5 0.5 0.5";
            oc_Newobject4["minContactSpeed"] = new Creator.StringNoQuote("1.0");
            oc_Newobject4["slidingThreshold"] = new Creator.StringNoQuote("0.1");
            oc_Newobject4["collisionSoundsCount"] = new Creator.StringNoQuote("3");
            oc_Newobject4["collisionSound[0]"] = new Creator.StringNoQuote("boxFall0");
            oc_Newobject4["collisionSound[1]"] = new Creator.StringNoQuote("boxFall1");
            oc_Newobject4["collisionSound[2]"] = new Creator.StringNoQuote("boxFall2");

            #endregion

            oc_Newobject4.Create();

            #region SFXProfile (stoneRoll0)        oc_Newobject5

            DatablockCreator oc_Newobject5 = new DatablockCreator("SFXProfile", "stoneRoll0");
            oc_Newobject5["filename"] = "art/sound/physics/stoneRoll";
            oc_Newobject5["description"] = new Creator.StringNoQuote("AudioClosest3d");
            oc_Newobject5["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject5.Create();

            #region RigidBodyData ( StatPhysBox )        oc_Newobject6

            DatablockCreator oc_Newobject6 = new DatablockCreator("RigidBodyData", " StatPhysBox ");
            oc_Newobject6["category"] = "RigidBody";
            oc_Newobject6["shapeFile"] = "art/shapes/crates/crate1.dts";
            oc_Newobject6["shapeType"] = new Creator.StringNoQuote("$ShapeType::Box");
            oc_Newobject6["mass"] = new Creator.StringNoQuote("0");

            #endregion

            oc_Newobject6.Create();

            #region RigidBodyData ( PhysSphere )        oc_Newobject7

            DatablockCreator oc_Newobject7 = new DatablockCreator("RigidBodyData", " PhysSphere ");
            oc_Newobject7["category"] = "RigidBody";
            oc_Newobject7["shapeFile"] = "art/shapes/rocks/boulder.dts";
            oc_Newobject7["shapeType"] = new Creator.StringNoQuote("$ShapeType::Sphere");
            oc_Newobject7["mass"] = new Creator.StringNoQuote("5");
            oc_Newobject7["scale"] = "0.3 0.3 0.3";
            oc_Newobject7["slidingThreshold"] = new Creator.StringNoQuote("0.7");
            oc_Newobject7["minContactSpeed"] = new Creator.StringNoQuote("1.0");
            oc_Newobject7["collisionSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject7["collisionSound[0]"] = new Creator.StringNoQuote("boxFall0");
            oc_Newobject7["slideSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject7["slideSound[0]"] = new Creator.StringNoQuote("stoneRoll0");

            #endregion

            oc_Newobject7.Create();

            #region SFXProfile (barrelFall0)        oc_Newobject8

            DatablockCreator oc_Newobject8 = new DatablockCreator("SFXProfile", "barrelFall0");
            oc_Newobject8["filename"] = "art/sound/physics/barrelFall0";
            oc_Newobject8["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject8["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject8.Create();

            #region SFXProfile (barrelFall1)        oc_Newobject9

            DatablockCreator oc_Newobject9 = new DatablockCreator("SFXProfile", "barrelFall1");
            oc_Newobject9["filename"] = "art/sound/physics/barrelFall1";
            oc_Newobject9["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject9["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject9.Create();

            #region SFXProfile (barrelRoll)        oc_Newobject10

            DatablockCreator oc_Newobject10 = new DatablockCreator("SFXProfile", "barrelRoll");
            oc_Newobject10["filename"] = "art/sound/physics/barrelFall1";
            oc_Newobject10["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject10["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject10.Create();

            #region RigidBodyData ( PhysBarrel )        oc_Newobject11

            DatablockCreator oc_Newobject11 = new DatablockCreator("RigidBodyData", " PhysBarrel ");
            oc_Newobject11["category"] = "RigidBody";
            oc_Newobject11["shapeFile"] = "art/shapes/steel_barrel_green/steel_barrel_green.dts";
            oc_Newobject11["shapeType"] = new Creator.StringNoQuote("$ShapeType::Cylinder");
            oc_Newobject11["rotAngles"] = "0 0 0 0";
            oc_Newobject11["offset"] = "0 0 0.5 0";
            oc_Newobject11["mass"] = new Creator.StringNoQuote("4");
            oc_Newobject11["slidingThreshold"] = new Creator.StringNoQuote("0.7");
            oc_Newobject11["minContactSpeed"] = new Creator.StringNoQuote("1.0");
            oc_Newobject11["collisionSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject11["collisionSound[0]"] = new Creator.StringNoQuote("barrelFall0");
            oc_Newobject11["collisionSound[1]"] = new Creator.StringNoQuote("barrelFall1");
            oc_Newobject11["slideSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject11["slideSound[0]"] = new Creator.StringNoQuote("barrelRoll");

            #endregion

            oc_Newobject11.Create();

            #region SFXProfile (wheelFall0)        oc_Newobject12

            DatablockCreator oc_Newobject12 = new DatablockCreator("SFXProfile", "wheelFall0");
            oc_Newobject12["filename"] = "art/sound/physics/wheelFall0";
            oc_Newobject12["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject12["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject12.Create();

            #region SFXProfile (wheelFall1)        oc_Newobject13

            DatablockCreator oc_Newobject13 = new DatablockCreator("SFXProfile", "wheelFall1");
            oc_Newobject13["filename"] = "art/sound/physics/wheelFall1";
            oc_Newobject13["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject13["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject13.Create();

            #region SFXProfile (wheelFall2)        oc_Newobject14

            DatablockCreator oc_Newobject14 = new DatablockCreator("SFXProfile", "wheelFall2");
            oc_Newobject14["filename"] = "art/sound/physics/wheelFall2";
            oc_Newobject14["description"] = new Creator.StringNoQuote("AudioDefault3d");
            oc_Newobject14["preload"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject14.Create();

            #region RigidBodyData ( PhysWheel )        oc_Newobject15

            DatablockCreator oc_Newobject15 = new DatablockCreator("RigidBodyData", " PhysWheel ");
            oc_Newobject15["category"] = "RigidBody";
            oc_Newobject15["shapeFile"] = "art/shapes/Wheel/Wheel.dts";
            oc_Newobject15["shapeType"] = new Creator.StringNoQuote("$ShapeType::Cylinder");
            oc_Newobject15["mass"] = new Creator.StringNoQuote("1");
            oc_Newobject15["rotAngles"] = "0 90 0 0";
            oc_Newobject15["offset"] = "0 0 0 0";
            oc_Newobject15["slidingThreshold"] = new Creator.StringNoQuote("0.7");
            oc_Newobject15["minContactSpeed"] = new Creator.StringNoQuote("1.0");
            oc_Newobject15["collisionSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject15["collisionSound[0]"] = new Creator.StringNoQuote("wheelFall0");
            oc_Newobject15["collisionSound[1]"] = new Creator.StringNoQuote("wheelFall1");
            oc_Newobject15["collisionSound[2]"] = new Creator.StringNoQuote("wheelFall2");
            oc_Newobject15["slideSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject15["slideSound[0]"] = new Creator.StringNoQuote("wheelFall0");

            #endregion

            oc_Newobject15.Create();
        }
    }
}