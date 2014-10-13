#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    [TypeConverter(typeof(TypeConverterGeneric<CustomHealthPatch>))]
    public class CustomHealthPatch : ItemData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
            {
            if (!((collObj.GetType() == typeof(Player)) || (collObj.GetType() == typeof(AIPlayer))))
                return;
            Player player = (Player)collObj;


            if (player.getDamageLevel() <= 0.00 || player.getState() == "Dead")
                return;

            player.applyRepair(this["repairAmount"].AsFloat());
            player.setEnergyLevel(1);

            obj.schedule((100).AsString(), "startFade", "1000", "0", "true");
            obj.schedule((1200).AsString(), "delete");
            Audio.AudioServerPlay3D("HealthUseSound", player.getTransform());
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CustomHealthPatch ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(CustomHealthPatch ts, string simobjectid)
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
        public static implicit operator string(CustomHealthPatch ts)
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
        public static implicit operator CustomHealthPatch(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (CustomHealthPatch)Omni.self.getSimObject(simobjectid, typeof(CustomHealthPatch));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CustomHealthPatch ts)
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
        public static implicit operator CustomHealthPatch(int simobjectid)
            {
            return (CustomHealthPatch)Omni.self.getSimObject((uint)simobjectid, typeof(CustomHealthPatch));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CustomHealthPatch ts)
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
        public static implicit operator CustomHealthPatch(uint simobjectid)
            {
            return (CustomHealthPatch)Omni.self.getSimObject(simobjectid, typeof(CustomHealthPatch));
            }

        #endregion
        }
    }