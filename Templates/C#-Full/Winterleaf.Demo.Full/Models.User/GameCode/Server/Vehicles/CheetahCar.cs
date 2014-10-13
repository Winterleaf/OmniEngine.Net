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

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
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
            if (ReferenceEquals(ts, null))
                return ReferenceEquals(simobjectid, null);
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
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(CheetahCar ts)
        {
            if (ReferenceEquals(ts, null))
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
            if (ReferenceEquals(ts, null))
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
            if (ReferenceEquals(ts, null))
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