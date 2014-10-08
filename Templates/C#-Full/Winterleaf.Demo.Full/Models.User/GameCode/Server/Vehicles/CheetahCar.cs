#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Vehicles
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<CheetahCar>))]
    public class CheetahCar : WheeledVehicleData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd(GameBase obj)
            {
            WheeledVehicle vehicle = obj._ID;
            base.onAdd(obj);

            WheeledVehicleTire CheetahCarTire = "CheetahCarTire";
            WheeledVehicleTire CheetahCarTireRear = "CheetahCarTireRear";
            WheeledVehicleSpring CheetahCarSpring = "CheetahCarSpring";

            //int nsd = (nameSpaceDepth.AsInt() + 1);
            //console.ParentExecute(datablock, "onAdd", nsd, new string[] { datablock, vehicle.ID });
            vehicle.setWheelTire(0, CheetahCarTire);
            vehicle.setWheelTire(1, CheetahCarTire);
            vehicle.setWheelTire(2, CheetahCarTireRear);
            vehicle.setWheelTire(3, CheetahCarTireRear);


            // Setup the car with some tires & springs
            for (int i = vehicle.getWheelCount() - 1; i >= 0; i--)
                {
                vehicle.setWheelPowered(i, true);
                vehicle.setWheelSpring(i, CheetahCarSpring);
                }
            // Steer with the front tires
            vehicle.setWheelSteering(0, 1);
            vehicle.setWheelSteering(1, 1);


            // Add tail lights
            ObjectCreator tc = new ObjectCreator("PointLight", "");
            tc["radius"] = 1;
            tc["isEnabled"] = false;
            tc["color"] = new ColorF(1, 0, 0.141176f, 1); // , @"""1 0 0.141176 1""");
            tc["brightness"] = 2;
            tc["castShadows"] = true;
            tc["priority"] = 1;
            tc["animate"] = false;
            tc["animationPeriod"] = 1;
            tc["animationPhase"] = 1;
            tc["flareScale"] = 1;
            tc["attenuationRatio"] = new Point3F(0, 1, 1); //, @"""0 1 1""");
            tc["shadowType"] = "\"DualParaboloidSinglePass\"";
            tc["texSize"] = 512;
            tc["overDarkFactor"] = new Point4F(2000, 1000, 500, 100); //, @"""2000 1000 500 100""");
            tc["shadowDistance"] = 400; // "400");
            tc["shadowSoftness"] = 0.15;
            tc["numSplits"] = 1; //, "1");
            tc["logWeight"] = 0.91;
            tc["fadeStartDistance"] = 0; //, "0");
            tc["lastSplitTerrainOnly"] = false;
            tc["representedInLightmap"] = false; //, "0");
            tc["shadowDarkenColor"] = new ColorF(0, 0, 0, -1); //, @"""0 0 0 -1""");
            tc["includeLightmappedGeometryInShadow"] = false; //, "0");
            tc["rotation"] = new AngAxisF(1, 0, 0, 0); //, @"""1 0 0 0 """);
            tc["canSave"] = true; //, "1");
            tc["canSaveDynamicFields"] = true; //, "1");
            tc["splitFadeDistances"] = "10 20 30 40";


            vehicle["rightBrakeLight"] = ((PointLight) tc.Create());
            vehicle["leftBrakeLight"] = ((PointLight) tc.Create());
            vehicle["inv[BulletAmmo]"] = "1000";

            // Mount a ShapeBaseImageData
            vehicle.mountImage("TurretImage", this["turretSlot"].AsInt(), true, string.Empty);

            // Mount the brake lights
            vehicle.mountObject(vehicle["rightBrakeLight"], this["rightBrakeSlot"].AsInt(), new TransformF());
            vehicle.mountObject(vehicle["leftbrakelight"], this["leftBrakeSlot"].AsInt(), new TransformF());
            }

        public override void onRemove(GameBase obj)
            {
            WheeledVehicle vehicle = obj._ID;
            base.onRemove(obj);
            //int nsd = (nameSpaceDepth.AsInt() + 1);
            //console.ParentExecute(datablock, "onRemove", nsd, new[] { datablock.ID, vehicle.ID });
            if ((vehicle["rightBrakeLight"]).isObject())
                (vehicle["rightBrakeLight"]).delete();
            if ((vehicle["leftBrakeLight"]).isObject())
                (vehicle["leftBrakeLight"]).delete();
            if ((vehicle["turret"]).isObject())
                (vehicle["turret"]).delete();
            }

        public override void onTrigger(ShapeBase obj, int index, bool state)
            {
            WheeledVehicle vehicle = obj._ID;
            // Pass trigger states on to TurretImage (to fire weapon)
            switch (index)
                {
                    case 0:
                        vehicle.setImageTrigger(this["turretSlot"].AsInt(), state);
                        break;
                    case 1:
                        vehicle.setImageAltTrigger(this["turretSlot"].AsInt(), state);
                        break;
                }
            }

        public override void onMount(GameBase obj, SceneObject mountObj, int node)
            {
            WheeledVehicle vehicle = obj._ID;
            vehicle.setImageAmmo(node, true);
            }

        [ConsoleInteraction(true)]
        public static void ServerCmdtoggleBrakeLights(GameConnection client)
            {
            Player player = client["player"];
            //Remember to pay attention to what type of object your looking at.
            WheeledVehicle vehicle = player.getControlObject().AsString();
            if (vehicle.getClassName() != "WheeledVehicle")
                return;

            if (vehicle["rightBrakeLight.isEnabled"].AsBool())
                {
                ((PointLight) vehicle["rightBrakeLight"]).setLightEnabled(false);
                ((PointLight) vehicle["leftBrakeLight"]).setLightEnabled(false);
                }
            else
                {
                ((PointLight) vehicle["rightBrakeLight"]).setLightEnabled(true);
                ((PointLight) vehicle["leftBrakeLight"]).setLightEnabled(true);
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CheetahCar ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(CheetahCar ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(CheetahCar ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator CheetahCar(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (CheetahCar) Omni.self.getSimObject(simobjectid, typeof (CheetahCar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CheetahCar ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CheetahCar(int simobjectid)
            {
            return (CheetahCar) Omni.self.getSimObject((uint) simobjectid, typeof (CheetahCar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CheetahCar ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CheetahCar(uint simobjectid)
            {
            return (CheetahCar) Omni.self.getSimObject(simobjectid, typeof (CheetahCar));
            }

        #endregion
        }
    }