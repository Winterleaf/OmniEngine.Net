using WinterLeaf.Engine.Classes;
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
            oc_Newobject2["node0"] =
                new ObjectCreator.StringNoQuote("\"cam\" TAB \"This node is used as the 3rd person camera position.\"");
            oc_Newobject2["node1"] =
                new ObjectCreator.StringNoQuote("\"eye\" TAB \"This node is used as the 1st person camera position.\"");
            oc_Newobject2["node2"] =
                new ObjectCreator.StringNoQuote(
                    "\"ear\" TAB \"This node is where the SFX listener is mounted on (if missing, eye is used).\"");
            oc_Newobject2["node3"] =
                new ObjectCreator.StringNoQuote(
                    "\"mount0-31\" TAB \"Nodes used for mounting ShapeBaseImages to this object\"");
            oc_Newobject2["node4"] = new ObjectCreator.StringNoQuote("\"AIRepairNode\" TAB \"unused\"");
            oc_Newobject2["sequence0"] =
                new ObjectCreator.StringNoQuote(
                    "\"Visibility\" TAB \"2 frame sequence used to show object damage (start=no damage, end=fully damaged)\"");
            oc_Newobject2["sequence1"] =
                new ObjectCreator.StringNoQuote(
                    "\"Damage\" TAB \"Sequence used to show object damage (start=no damage, end=fully damaged)\"");

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region ScriptObject ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("ScriptObject", "");
            oc_Newobject3["objectType"] = "ShapeBaseImageData";
            oc_Newobject3["node0"] =
                new ObjectCreator.StringNoQuote(
                    "\"ejectPoint\" TAB \"Node from which shell casings are emitted (for weapon ShapeImages)\"");
            oc_Newobject3["node1"] =
                new ObjectCreator.StringNoQuote(
                    "\"muzzlePoint\" TAB \"Node used to fire projectiles and particles (for weapon ShapeImages)\"");
            oc_Newobject3["node2"] =
                new ObjectCreator.StringNoQuote(
                    "\"retractionPoint\" TAB \"Nearest point to use as muzzle when up against a wall (and muzzle node is inside wall)\"");
            oc_Newobject3["node3"] =
                new ObjectCreator.StringNoQuote("\"mountPoint\" TAB \"Where to attach to on this object\"");
            oc_Newobject3["sequence0"] =
                new ObjectCreator.StringNoQuote("\"ambient\" TAB \"Cyclic sequence to play while image is mounted\"");
            oc_Newobject3["sequence1"] =
                new ObjectCreator.StringNoQuote("\"spin\" TAB \"Cyclic sequence to play while image is mounted\"");

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region ScriptObject ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("ScriptObject", "");
            oc_Newobject4["objectType"] = "Player";
            oc_Newobject4["node0"] = new ObjectCreator.StringNoQuote("\"Bip01 Pelvis\" TAB \"\"");
            oc_Newobject4["node1"] = new ObjectCreator.StringNoQuote("\"Bip01 Spine\" TAB \"\"");
            oc_Newobject4["node2"] = new ObjectCreator.StringNoQuote("\"Bip01 Spine1\" TAB \"\"");
            oc_Newobject4["node3"] = new ObjectCreator.StringNoQuote("\"Bip01 Spine2\" TAB \"\"");
            oc_Newobject4["node4"] = new ObjectCreator.StringNoQuote("\"Bip01 Neck\" TAB \"\"");
            oc_Newobject4["node5"] = new ObjectCreator.StringNoQuote("\"Bip01 Head\" TAB \"\"");
            oc_Newobject4["sequence0"] =
                new ObjectCreator.StringNoQuote(
                    "\"head\" TAB \"Vertical head movement (for looking) (start=full up, end=full down)\"");
            oc_Newobject4["sequence1"] =
                new ObjectCreator.StringNoQuote(
                    "\"headside\" TAB \"Horizontal head movement (for looking) (start=full left, end=full right)\"");
            oc_Newobject4["sequence2"] =
                new ObjectCreator.StringNoQuote(
                    "\"look\" TAB \"Vertical arm movement (for looking) (start=full up, end=full down)\"");
            oc_Newobject4["sequence3"] =
                new ObjectCreator.StringNoQuote("\"light_recoil\" TAB \"Player has been hit lightly\"");
            oc_Newobject4["sequence4"] =
                new ObjectCreator.StringNoQuote("\"medium_recoil\" TAB \"Player has been hit moderately hard\"");
            oc_Newobject4["sequence5"] =
                new ObjectCreator.StringNoQuote("\"heavy_recoil\" TAB \"Player has been hit hard\"");
            oc_Newobject4["sequence6"] = new ObjectCreator.StringNoQuote("\"root\" TAB \"Player is not moving\"");
            oc_Newobject4["sequence7"] = new ObjectCreator.StringNoQuote("\"run\" TAB \"Player is running forward\"");
            oc_Newobject4["sequence8"] = new ObjectCreator.StringNoQuote("\"back\" TAB \"Player is running backward\"");
            oc_Newobject4["sequence9"] =
                new ObjectCreator.StringNoQuote("\"side\" TAB \"Player is running sideways left (strafing)\"");
            oc_Newobject4["sequence9"] =
                new ObjectCreator.StringNoQuote("\"side_right\" TAB \"Player is running sideways right (strafing)\"");
            oc_Newobject4["sequence10"] =
                new ObjectCreator.StringNoQuote("\"crouch_root\" TAB \"Player is crouched and not moving\"");
            oc_Newobject4["sequence11"] =
                new ObjectCreator.StringNoQuote("\"crouch_forward\" TAB \"Player is crouched and moving forward\"");
            oc_Newobject4["sequence11"] =
                new ObjectCreator.StringNoQuote("\"crouch_backward\" TAB \"Player is crouched and moving backward\"");
            oc_Newobject4["sequence11"] =
                new ObjectCreator.StringNoQuote("\"crouch_side\" TAB \"Player is crouched and moving sideways left\"");
            oc_Newobject4["sequence11"] =
                new ObjectCreator.StringNoQuote("\"crouch_right\" TAB \"Player is crouched and moving sideways right\"");
            oc_Newobject4["sequence12"] =
                new ObjectCreator.StringNoQuote("\"prone_root\" TAB \"Player is lying down and not moving\"");
            oc_Newobject4["sequence13"] =
                new ObjectCreator.StringNoQuote("\"prone_forward\" TAB \"Player is lying down and moving forward\"");
            oc_Newobject4["sequence13"] =
                new ObjectCreator.StringNoQuote("\"prone_backward\" TAB \"Player is lying down and moving backward\"");
            oc_Newobject4["sequence14"] =
                new ObjectCreator.StringNoQuote("\"swim_root\" TAB \"Player is swimming and not moving\"");
            oc_Newobject4["sequence15"] =
                new ObjectCreator.StringNoQuote("\"swim_forward\" TAB \"Player is swimming and moving forward\"");
            oc_Newobject4["sequence16"] =
                new ObjectCreator.StringNoQuote("\"swim_backward\" TAB \"Player is swimming and moving backward\"");
            oc_Newobject4["sequence17"] =
                new ObjectCreator.StringNoQuote("\"swim_left\" TAB \"Player is swimming and moving left\"");
            oc_Newobject4["sequence18"] =
                new ObjectCreator.StringNoQuote("\"swim_right\" TAB \"Player is swimming and moving right\"");
            oc_Newobject4["sequence19"] = new ObjectCreator.StringNoQuote("\"fall\" TAB \"Player is falling\"");
            oc_Newobject4["sequence20"] =
                new ObjectCreator.StringNoQuote("\"jump\" TAB \"Player has jumped from a moving start\"");
            oc_Newobject4["sequence21"] =
                new ObjectCreator.StringNoQuote("\"standjump\" TAB \"Player has jumped from a standing start\"");
            oc_Newobject4["sequence22"] =
                new ObjectCreator.StringNoQuote("\"land\" TAB \"Player has landed after falling\"");
            oc_Newobject4["sequence23"] = new ObjectCreator.StringNoQuote("\"jet\" TAB \"Player is jetting\"");
            oc_Newobject4["sequence24"] =
                new ObjectCreator.StringNoQuote(
                    "\"death1-11\" TAB \"Player has been killed (only one of these will play)\"");

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region ScriptObject ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("ScriptObject", "");
            oc_Newobject5["objectType"] = "WheeledVehicle";
            oc_Newobject5["node0"] = new ObjectCreator.StringNoQuote("\"hub0-7\" TAB \"Placement node for wheel X\"");
            oc_Newobject5["sequence0"] =
                new ObjectCreator.StringNoQuote(
                    "\"spring0-7\" TAB \"Spring suspension for wheel X (start=fully compressed, end=fully extended)\"");
            oc_Newobject5["sequence1"] =
                new ObjectCreator.StringNoQuote(
                    "\"steering\" TAB \"Steering mechanism (start=full left, end=full right)\"");
            oc_Newobject5["sequence2"] =
                new ObjectCreator.StringNoQuote(
                    "\"brakelight\" TAB \"Sequence to play when braking (start=brakes off, end=brakes on)\"");

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region ScriptObject ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("ScriptObject", "");
            oc_Newobject6["objectType"] = "HoverVehicle";
            oc_Newobject6["node0"] =
                new ObjectCreator.StringNoQuote(
                    "\"JetNozzle0-3\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject6["node1"] =
                new ObjectCreator.StringNoQuote("\"JetNozzleX\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject6["sequence0"] =
                new ObjectCreator.StringNoQuote(
                    "\"activateBack\" TAB \"Non-cyclic sequence to play when vehicle first starts moving backwards\"");
            oc_Newobject6["sequence1"] =
                new ObjectCreator.StringNoQuote(
                    "\"maintainBack\" TAB \"Cyclic sequence to play when vehicle continues moving backwards\"");

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region ScriptObject ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("ScriptObject", "");
            oc_Newobject7["objectType"] = "FlyingVehicle";
            oc_Newobject7["node0"] =
                new ObjectCreator.StringNoQuote(
                    "\"JetNozzle0-3\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject7["node1"] =
                new ObjectCreator.StringNoQuote("\"JetNozzleX\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject7["node2"] =
                new ObjectCreator.StringNoQuote("\"JetNozzleY\" TAB \"Nodes for jet engine exhaust particle emission\"");
            oc_Newobject7["node3"] =
                new ObjectCreator.StringNoQuote("\"contrail0-3\" TAB \"Nodes for contrail particle emission\"");
            oc_Newobject7["sequence0"] =
                new ObjectCreator.StringNoQuote(
                    "\"activateBack\" TAB \"Sequence to play when vehicle first starts thrusting backwards\"");
            oc_Newobject7["sequence1"] =
                new ObjectCreator.StringNoQuote(
                    "\"maintainBack\" TAB \"Cyclic sequence to play when vehicle continues thrusting backwards\"");
            oc_Newobject7["sequence2"] =
                new ObjectCreator.StringNoQuote(
                    "\"activateBot\" TAB \"Non-cyclic sequence to play when vehicle first starts thrusting upwards\"");
            oc_Newobject7["sequence3"] =
                new ObjectCreator.StringNoQuote(
                    "\"maintainBot\" TAB \"Cyclic sequence to play when vehicle continues thrusting upwards\"");

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region ScriptObject ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("ScriptObject", "");
            oc_Newobject8["objectType"] = "Projectile";
            oc_Newobject8["sequence0"] =
                new ObjectCreator.StringNoQuote(
                    "\"activate\" TAB \"Non-cyclic sequence to play when projectile is first created\"");
            oc_Newobject8["sequence1"] =
                new ObjectCreator.StringNoQuote(
                    "\"maintain\" TAB \"Cyclic sequence to play for remainder of projectile lifetime\"");

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
            }
        }
    }