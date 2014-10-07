#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.Camera
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<Observer>))]
    public class Observer : CameraData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onTrigger(WinterLeaf.Demo.Full.Models.User.Extendable.Camera obj, string trigger, bool state)
            {
            // state = 0 means that a trigger key was released
            if (state == false)
                return;

            // Default player triggers: 0=fire 1=altFire 2=jump
            GameConnection client = obj.getControllingClient();
            string mode = obj["mode"];
            switch (mode)
                {
                    case "Observer":
                        // Do something interesting.
                        break;
                    case "Corpse":
                        if (obj["orbitObj"].isObject())
                            {
                            Util.cancelAll(obj["orbitObj"]);
                            SceneObject orbitobj = obj["orbitObj"];
                            orbitobj.schedule("0", "startFade", "1000", "0", "true");
                            orbitobj.schedule("1000", "delete");
                            }
                        
                        this.setMode(obj, "Observer", "", "", "");
                        break;
                }
            }

        public override void setMode(Models.User.Extendable.Camera camera, string mode, SceneObject arg1, string arg2, string arg3)
            {
            switch (mode)
                {
                    case "Observer":
                        camera.setFlyMode();
                        break;
                    case "Corpse":
                        camera.setOrbitMode(arg1, arg1.getTransform(), (float) 0.5, (float) 4.5, (float) 4.5, false,
                            new Point3F(), false);
                        camera["orbitObj"] = arg1;
                        break;
                }
            camera["mode"] = mode;
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Observer ts, string simobjectid)
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
        public static bool operator !=(Observer ts, string simobjectid)
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
        public static implicit operator string(Observer ts)
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
        public static implicit operator Observer(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (Observer) Omni.self.getSimObject(simobjectid, typeof (Observer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Observer ts)
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
        public static implicit operator Observer(int simobjectid)
            {
            return (Observer) Omni.self.getSimObject((uint) simobjectid, typeof (Observer));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Observer ts)
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
        public static implicit operator Observer(uint simobjectid)
            {
            return (Observer) Omni.self.getSimObject(simobjectid, typeof (Observer));
            }

        #endregion
        }
    }