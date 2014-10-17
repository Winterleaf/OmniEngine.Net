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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind
{
    public class ShapeEditorHints
    {
        [ConsoleInteraction(true, "ShapeEditorHints_initialize")]
        public static void initialize()
        {
            #region SimGroup  (ShapeHintControls)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("SimGroup ", "ShapeHintControls");

            #endregion

            oc_Newobject1.Create();

            #region SimGroup  (ShapeHintGroup)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("SimGroup ", "ShapeHintGroup");

            #region ScriptObject ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("ScriptObject", "");
            oc_Newobject2["objectType"] = "ShapeBase";
            oc_Newobject2["node0"] = new Creator.StringNoQuote("\"cam\" TAB \"This node is used as the 3rd person camera position.\"");
            oc_Newobject2["node1"] = new Creator.StringNoQuote("\"eye\" TAB \"This node is used as the 1st person camera position.\"");
            oc_Newobject2["node2"] = new Creator.StringNoQuote("\"ear\" TAB \"This node is where the SFX listener is mounted on (if missing, eye is used).\"");
            oc_Newobject2["node3"] = new Creator.StringNoQuote("\"mount0-31\" TAB \"Nodes used for mounting ShapeBaseImages to this object\"");
            oc_Newobject2["node4"] = new Creator.StringNoQuote("\"AIRepairNode\" TAB \"unused\"");
            oc_Newobject2["sequence0"] = new Creator.StringNoQuote("\"Visibility\" TAB \"2 frame sequence used to show object damage (start=no damage, end=fully damaged)\"");
            oc_Newobject2["sequence1"] = new Creator.StringNoQuote("\"Damage\" TAB \"Sequence used to show object damage (start=no damage, end=fully damaged)\"");

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region ScriptObject ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("ScriptObject", "");
            oc_Newobject3["objectType"] = "ShapeBaseImageData";
            oc_Newobject3["node0"] = new Creator.StringNoQuote("\"ejectPoint\" TAB \"Node from which shell casings are emitted (for weapon ShapeImages)\"");
            oc_Newobject3["node1"] = new Creator.StringNoQuote("\"muzzlePoint\" TAB \"Node used to fire projectiles and particles (for weapon ShapeImages)\"");
            oc_Newobject3["node2"] = new Creator.StringNoQuote("\"retractionPoint\" TAB \"Nearest point to use as muzzle when up against a wall (and muzzle node is inside wall)\"");
            oc_Newobject3["node3"] = new Creator.StringNoQuote("\"mountPoint\" TAB \"Where to attach to on this object\"");
            oc_Newobject3["sequence0"] = new Creator.StringNoQuote("\"ambient\" TAB \"Cyclic sequence to play while image is mounted\"");
            oc_Newobject3["sequence1"] = new Creator.StringNoQuote("\"spin\" TAB \"Cyclic sequence to play while image is mounted\"");

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region ScriptObject ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("ScriptObject", "");
            oc_Newobject4["objectType"] = "Player";
            oc_Newobject4["node0"] = new Creator.StringNoQuote("\"Bip01 Pelvis\" TAB \"\"");
            oc_Newobject4["node1"] = new Creator.StringNoQuote("\"Bip01 Spine\" TAB \"\"");
            oc_Newobject4["node2"] = new Creator.StringNoQuote("\"Bip01 Spine1\" TAB \"\"");
            oc_Newobject4["node3"] = new Creator.StringNoQuote("\"Bip01 Spine2\" TAB \"\"");
            oc_Newobject4["node4"] = new Creator.StringNoQuote("\"Bip01 Neck\" TAB \"\"");
            oc_Newobject4["node5"] = new Creator.StringNoQuote("\"Bip01 Head\" TAB \"\"");
            oc_Newobject4["sequence0"] = new Creator.StringNoQuote("\"head\" TAB \"Vertical head movement (for looking) (start=full up, end=full down)\"");
            oc_Newobject4["sequence1"] = new Creator.StringNoQuote("\"headside\" TAB \"Horizontal head movement (for looking) (start=full left, end=full right)\"");
            oc_Newobject4["sequence2"] = new Creator.StringNoQuote("\"look\" TAB \"Vertical arm movement (for looking) (start=full up, end=full down)\"");
            oc_Newobject4["sequence3"] = new Creator.StringNoQuote("\"light_recoil\" TAB \"Player has been hit lightly\"");
            oc_Newobject4["sequence4"] = new Creator.StringNoQuote("\"medium_recoil\" TAB \"Player has been hit moderately hard\"");
            oc_Newobject4["sequence5"] = new Creator.StringNoQuote("\"heavy_recoil\" TAB \"Player has been hit hard\"");
            oc_Newobject4["sequence6"] = new Creator.StringNoQuote("\"root\" TAB \"Player is not moving\"");
            oc_Newobject4["sequence7"] = new Creator.StringNoQuote("\"run\" TAB \"Player is running forward\"");
            oc_Newobject4["sequence8"] = new Creator.StringNoQuote("\"back\" TAB \"Player is running backward\"");
            oc_Newobject4["sequence9"] = new Creator.StringNoQuote("\"side\" TAB \"Player is running sideways left (strafing)\"");
            oc_Newobject4["sequence9"] = new Creator.StringNoQuote("\"side_right\" TAB \"Player is running sideways right (strafing)\"");
            oc_Newobject4["sequence10"] = new Creator.StringNoQuote("\"crouch_root\" TAB \"Player is crouched and not moving\"");
            oc_Newobject4["sequence11"] = new Creator.StringNoQuote("\"crouch_forward\" TAB \"Player is crouched and moving forward\"");
            oc_Newobject4["sequence11"] = new Creator.StringNoQuote("\"crouch_backward\" TAB \"Player is crouched and moving backward\"");
            oc_Newobject4["sequence11"] = new Creator.StringNoQuote("\"crouch_side\" TAB \"Player is crouched and moving sideways left\"");
            oc_Newobject4["sequence11"] = new Creator.StringNoQuote("\"crouch_right\" TAB \"Player is crouched and moving sideways right\"");
            oc_Newobject4["sequence12"] = new Creator.StringNoQuote("\"prone_root\" TAB \"Player is lying down and not moving\"");
            oc_Newobject4["sequence13"] = new Creator.StringNoQuote("\"prone_forward\" TAB \"Player is lying down and moving forward\"");
            oc_Newobject4["sequence13"] = new Creator.StringNoQuote("\"prone_backward\" TAB \"Player is lying down and moving backward\"");
            oc_Newobject4["sequence14"] = new Creator.StringNoQuote("\"swim_root\" TAB \"Player is swimming and not moving\"");
            oc_Newobject4["sequence15"] = new Creator.StringNoQuote("\"swim_forward\" TAB \"Player is swimming and moving forward\"");
            oc_Newobject4["sequence16"] = new Creator.StringNoQuote("\"swim_backward\" TAB \"Player is swimming and moving backward\"");
            oc_Newobject4["sequence17"] = new Creator.StringNoQuote("\"swim_left\" TAB \"Player is swimming and moving left\"");
            oc_Newobject4["sequence18"] = new Creator.StringNoQuote("\"swim_right\" TAB \"Player is swimming and moving right\"");
            oc_Newobject4["sequence19"] = new Creator.StringNoQuote("\"fall\" TAB \"Player is falling\"");
            oc_Newobject4["sequence20"] = new Creator.StringNoQuote("\"jump\" TAB \"Player has jumped from a moving start\"");
            oc_Newobject4["sequence21"] = new Creator.StringNoQuote("\"standjump\" TAB \"Player has jumped from a standing start\"");
            oc_Newobject4["sequence22"] = new Creator.StringNoQuote("\"land\" TAB \"Player has landed after falling\"");
            oc_Newobject4["sequence23"] = new Creator.StringNoQuote("\"jet\" TAB \"Player is jetting\"");
            oc_Newobject4["sequence24"] = new Creator.StringNoQuote("\"death1-11\" TAB \"Player has been killed (only one of these will play)\"");

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region ScriptObject ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("ScriptObject", "");
            oc_Newobject5["objectType"] = "WheeledVehicle";
            oc_Newobject5["node0"] = new Creator.StringNoQuote("\"hub0-7\" TAB \"Placement node for wheel X\"");
            oc_Newobject5["sequence0"] = new Creator.StringNoQuote("\"spring0-7\" TAB \"Spring suspension for wheel X (start=fully compressed, end=fully extended)\"");
            oc_Newobject5["sequence1"] = new Creator.StringNoQuote("\"steering\" TAB \"Steering mechanism (start=full left, end=full right)\"");
            oc_Newobject5["sequence2"] = new Creator.StringNoQuote("\"brakelight\" TAB \"Sequence to play when braking (start=brakes off, end=brakes on)\"");

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region ScriptObject ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("ScriptObject", "");
            oc_Newobject6["objectType"] = "HoverVehicle";
            oc_Newobject6["node0"] = new Creator.StringNoQuote("\"JetNozzle0-3\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject6["node1"] = new Creator.StringNoQuote("\"JetNozzleX\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject6["sequence0"] = new Creator.StringNoQuote("\"activateBack\" TAB \"Non-cyclic sequence to play when vehicle first starts moving backwards\"");
            oc_Newobject6["sequence1"] = new Creator.StringNoQuote("\"maintainBack\" TAB \"Cyclic sequence to play when vehicle continues moving backwards\"");

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region ScriptObject ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("ScriptObject", "");
            oc_Newobject7["objectType"] = "FlyingVehicle";
            oc_Newobject7["node0"] = new Creator.StringNoQuote("\"JetNozzle0-3\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject7["node1"] = new Creator.StringNoQuote("\"JetNozzleX\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject7["node2"] = new Creator.StringNoQuote("\"JetNozzleY\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject7["node3"] = new Creator.StringNoQuote("\"contrail0-3\" TAB \"Nodes for contrail particle emission\"");
            oc_Newobject7["sequence0"] = new Creator.StringNoQuote("\"activateBack\" TAB \"Sequence to play when vehicle first starts thrusting backwards\"");
            oc_Newobject7["sequence1"] = new Creator.StringNoQuote("\"maintainBack\" TAB \"Cyclic sequence to play when vehicle continues thrusting backwards\"");
            oc_Newobject7["sequence2"] = new Creator.StringNoQuote("\"activateBot\" TAB \"Non-cyclic sequence to play when vehicle first starts thrusting upwards\"");
            oc_Newobject7["sequence3"] = new Creator.StringNoQuote("\"maintainBot\" TAB \"Cyclic sequence to play when vehicle continues thrusting upwards\"");

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region ScriptObject ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("ScriptObject", "");
            oc_Newobject8["objectType"] = "Projectile";
            oc_Newobject8["sequence0"] = new Creator.StringNoQuote("\"activate\" TAB \"Non-cyclic sequence to play when projectile is first created\"");
            oc_Newobject8["sequence1"] = new Creator.StringNoQuote("\"maintain\" TAB \"Cyclic sequence to play for remainder of projectile lifetime\"");

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
        }
    }
}