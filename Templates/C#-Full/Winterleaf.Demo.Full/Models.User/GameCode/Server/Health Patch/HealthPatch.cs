#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    [TypeConverter(typeof (TypeConverterGeneric<HealthPatch>))]
    public class HealthPatch : ItemData
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
            {
            if (!((collObj.GetType() == typeof (Player)) || (collObj.GetType() == typeof (AIPlayer))))
                return;
            Player player = (Player) collObj;


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
        public static bool operator ==(HealthPatch ts, string simobjectid)
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
        public static bool operator !=(HealthPatch ts, string simobjectid)
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
        public static implicit operator string(HealthPatch ts)
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
        public static implicit operator HealthPatch(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (HealthPatch) Omni.self.getSimObject(simobjectid, typeof (HealthPatch));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(HealthPatch ts)
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
        public static implicit operator HealthPatch(int simobjectid)
            {
            return (HealthPatch) Omni.self.getSimObject((uint) simobjectid, typeof (HealthPatch));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(HealthPatch ts)
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
        public static implicit operator HealthPatch(uint simobjectid)
            {
            return (HealthPatch) Omni.self.getSimObject(simobjectid, typeof (HealthPatch));
            }

        #endregion
        }
    }