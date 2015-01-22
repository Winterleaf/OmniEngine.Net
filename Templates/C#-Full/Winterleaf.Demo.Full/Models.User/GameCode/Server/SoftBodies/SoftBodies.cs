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
        public static void initialize()
        {
            #region SoftBodyData ( PhysFlag )        oc_Newobject1

            DatablockCreator oc_Newobject1 = new DatablockCreator("SoftBodyData", " PhysFlag ");
            oc_Newobject1["category"] = "SoftBody";
            oc_Newobject1["shapeFile"] = "art/shapes/flag/Triapko.dts";
            oc_Newobject1["mass"] = new Creator.StringNoQuote("5");
            oc_Newobject1["poseMatchKoef"] = new Creator.StringNoQuote("0");
            oc_Newobject1["scale"] = "1 1 1";
            oc_Newobject1["attachedPointsNum"] = new Creator.StringNoQuote("2");
            oc_Newobject1["attachedPoints[0]"] = "-10 10 0";
            oc_Newobject1["attachedPoints[1]"] = "10 10 0";
            oc_Newobject1["onlyOnClient"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject1.Create();

            #region SoftBodyData ( PhysSoftSphere )        oc_Newobject2

            DatablockCreator oc_Newobject2 = new DatablockCreator("SoftBodyData", " PhysSoftSphere ");
            oc_Newobject2["category"] = "SoftBody";
            oc_Newobject2["shapeFile"] = "art/shapes/ball/ball.dts";
            oc_Newobject2["shapeType"] = new Creator.StringNoQuote("$ShapeType::SoftMesh");
            oc_Newobject2["mass"] = new Creator.StringNoQuote("3");
            oc_Newobject2["scale"] = "0.4 0.4 0.4";
            oc_Newobject2["poseMatchKoef"] = new Creator.StringNoQuote("0.2");
            oc_Newobject2["slidingThreshold"] = new Creator.StringNoQuote("0.7");
            oc_Newobject2["minContactSpeed"] = new Creator.StringNoQuote("1.0");
            oc_Newobject2["collisionSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject2["collisionSound[0]"] = new Creator.StringNoQuote("boxFall0");
            oc_Newobject2["slideSoundsCount"] = new Creator.StringNoQuote("1");
            oc_Newobject2["slideSound[0]"] = new Creator.StringNoQuote("stoneRoll0");
            oc_Newobject2["onlyOnClient"] = new Creator.StringNoQuote("true");

            #endregion

            oc_Newobject2.Create();

            //-----------------------------------------------------------------------------
            // for Game Mechanics Editor
            //-----------------------------------------------------------------------------
            pInvokes.Util.activatePackage("TemplateFunctions");

            //TODO FIX
            //inheritTemplate("PhysFlag", "AbstractRigidBody");
            //registerTemplate("PhysFlag", "Physics", "SoftBodyData::create(PhysFlag);");

            //inheritTemplate("PhysSoftSphere", "AbstractRigidBody");
            //registerTemplate("PhysSoftSphere", "Physics", "SoftBodyData::create(PhysSoftSphere);");

            pInvokes.Util.deactivatePackage("TemplateFunctions");
        }
    }
}
