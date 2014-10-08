#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class WheeledVehicleData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            WheeledVehicle wheeledvehicle = obj._ID;
            base.onAdd(obj);
            //int nsd = (nameSpaceDepth + 1);
            //console.ParentExecute(thisobj, "onAdd", nsd, new string[] { thisobj, obj });
            // Setup the car with some tires & springs
            for (int i = wheeledvehicle.getWheelCount() - 1; i >= 0; i--)
                {
                wheeledvehicle.setWheelTire(i, "CheetahCarTire");
                wheeledvehicle.setWheelSpring(i, "CheetahCarSpring");
                wheeledvehicle.setWheelPowered(i, false);
                }
            // Steer with the front tires
            wheeledvehicle.setWheelSteering(0, 1);
            wheeledvehicle.setWheelSteering(1, 1);

            // Only power the two rear wheels... assuming there are only 4 wheels.
            wheeledvehicle.setWheelPowered(2, true);
            wheeledvehicle.setWheelPowered(3, true);
            }

        public override void onCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
            {
            // Collision with other objects, including items
            }

        // Used to kick the players out of the car that your crosshair is over

        [ConsoleInteraction(true)]
        public static void serverCmdcarUnmountObj(GameConnection client, Player obj)
            {
            obj.unmount();
            obj.setControlObject(obj);

            TransformF ejectpos = obj.getTransform();
            ejectpos += new TransformF(0, 0, 5);
            obj.setTransform(ejectpos);

            Vehicle mvehicle = obj["mVehicle"];

            Point3F ejectvel = mvehicle.getVelocity();
            ejectvel += new Point3F(0, 0, 10);

            ejectvel = ejectvel.vectorScale(((SimDataBlock) (obj.getDataBlock()))["mass"].AsFloat());

            obj.applyImpulse(ejectpos.GetPosition(), ejectvel);
            }

        // Used to flip the car over if it manages to get stuck upside down

        [ConsoleInteraction(true)]
        public static void serverCmdflipCar(GameConnection client)
            {
            Player player = client["player"];

            Vehicle car = player.getControlObject();
            if (car.getClassName() != "WheeledVehicle")
                return;
            TransformF carpos = car.getTransform();
            carpos += new TransformF(0, 0, 3);
            car.setTransform(carpos);
            }

        [ConsoleInteraction(true)]
        public static void serverCmdsetPlayerControl(GameConnection client)
            {
            Player player = client["player"];
            client.setControlObject(player);
            }

        [ConsoleInteraction(true)]
        public static void serverCmddismountVehicle(GameConnection client)
            {
            Player player = client["player"];
            Vehicle car = player.getControlObject();
            Player passenger = car.getMountNodeObject(0);

            ((PlayerData) passenger.getDataBlock()).doDismount(passenger);
            client.setControlObject(player);
            }
        }
    }