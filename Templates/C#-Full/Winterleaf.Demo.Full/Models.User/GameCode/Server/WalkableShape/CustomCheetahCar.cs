using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Vehicles;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server.WalkableShape
{
    [TypeConverter(typeof (TypeConverterGeneric<CustomCheetahCar>))]
    internal class CustomCheetahCar : CheetahCar
    {
        public int turretSlot
        {
            get { return this["turretSlot"].AsInt(); }
            set { this["turretSlot"] = value.AsString(); }
        }

        public override void onAdd(GameBase obj)
        {
            ShapeBase sb = (ShapeBase) obj;
            // Do standard cheetah init
            base.onAdd(obj);
            // Remove the turret from the roof
            sb.unmountImage(this.turretSlot);
            ObjectCreator ocplatform = new ObjectCreator("WalkableShape", "CarPlatform", typeof (CarPlatform));
            ocplatform["UseAutoAttach"] = 1;
            ocplatform["RayLength"] = 1.5f;
            ocplatform["shapeName"] = "art/shapes/rocks/boulder.dts";
            ocplatform["scale"] = "1 1 0.1";
            // Create our walkable platform
            CarPlatform platform = (CarPlatform) ocplatform.Create();
            sb["platform"] = platform;
            platform["car"] = sb;
            // Mount the platform to the Turret slot
            sb.mountImage(platform, this.turretSlot);
        }

        public override void onRemove(GameBase obj)
        {
            ShapeBase sb = (ShapeBase) obj;
            sb.unmountImage(sb["platform"].AsInt());
            if (sb["platform"].isObject())
                sb["platform"].delete();
            base.onRemove(obj);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CustomCheetahCar ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(CustomCheetahCar ts, string simobjectid)
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
        public static implicit operator string(CustomCheetahCar ts)
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
        public static implicit operator CustomCheetahCar(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (CustomCheetahCar) Omni.self.getSimObject(simobjectid, typeof (CustomCheetahCar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CustomCheetahCar ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CustomCheetahCar(int simobjectid)
        {
            return (CustomCheetahCar) Omni.self.getSimObject((uint) simobjectid, typeof (CustomCheetahCar));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CustomCheetahCar ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CustomCheetahCar(uint simobjectid)
        {
            return (CustomCheetahCar) Omni.self.getSimObject(simobjectid, typeof (CustomCheetahCar));
        }

        #endregion
    }
}