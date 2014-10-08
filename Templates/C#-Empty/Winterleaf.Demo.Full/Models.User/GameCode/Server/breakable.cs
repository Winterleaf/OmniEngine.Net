//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
//using WinterLeaf.Demo.Full.Models.User.Extendable;
//using WinterLeaf.Engine;
//using WinterLeaf.Engine.Classes.Decorations;
//using WinterLeaf.Engine.Classes.Extensions;
//using WinterLeaf.Engine.Classes.Helpers;
//using WinterLeaf.Engine.Classes.View.Creators;
//using WinterLeaf.Engine.Containers;

//namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
//{
//    //-----------------------------------------------------------------------------
//    // BreakableData  - a base class for breakable objects,
//    //-----------------------------------------------------------------------------
//    [TypeConverter(typeof(TypeConverterGeneric<Breakable>))]
//    public class Breakable : StaticShape
//    {
//        private VisualEffect preparatoryEffect
//        {
//            get
//            {
//                return this["preparatoryEffect"];
//            }
//            set
//            {
//                this["preparatoryEffect"] = value;
//            }
//        }

//        [ConsoleInteraction]
//        public virtual void prepareExplosion(SimObject obj)
//        {
//            //TODO FIX
//            //this = obj.getDataBlock();
//            if(obj["explosionPrepared"] != "") 
//                return;
//            obj["explosionPrepared"] = true.AsString();

//            if(this.preparatoryEffect != 0)
//            {
//                ObjectCreator oc = new ObjectCreator("VisualEffect");
//                oc["dataBlock"] = this.preparatoryEffect;
//                oc["position"] = obj.call("getPosition");
//                obj["preparatoryEffectInstance"] = oc.Create().AsString();
//            }
//            obj.schedule((this["timeToBreak"].AsFloat() + (this["timeToBreakVariance"].AsFloat() * Util.getRandom()).AsString()), "explode");
//        }

//        [ConsoleInteraction]
//        public virtual void explode(SimObject obj)
//        {
//            if(obj["exploded"] != "") 
//                return;
//            obj["exploded"] = true.AsString();
	
//            obj.schedule((((SimObject)obj.getDataBlock())["timeToVanish"].AsFloat() - 1000).AsString(), "startFade", "1000", "0", true.AsString());
//            obj.schedule(((SimObject)obj.getDataBlock())["timeToVanish"], "delete");
	
//            if(Util.isObject(obj["preparatoryEffectInstance"]))
//                ((VisualEffect)obj["preparatoryEffectInstance"]).schedule("100", "delete");
//            obj["preparatoryEffectInstance"] = "";
	
//            if(((SimObject)obj.getDataBlock())["breakEffect"] != "")
//            {
//                ObjectCreator oc = new ObjectCreator("VisualEffect");
//                oc["dataBlock"] = ((SimObject)obj.getDataBlock())["breakEffect"];
//                oc["position"] = obj.call("getPosition");
//                oc.Create();
//            }
	
//            if(((SimObject)obj.getDataBlock())["breakAnimation"] != "") 
//            {
//                obj.call("playThread", "0", ((SimObject)obj.getDataBlock())["breakAnimation"]);
//            }
//        }

//        [TypeConverter(typeof(TypeConverterGeneric<BreakableData>))]
//        public class BreakableData : ShapeBaseData
//        {
//            [ConsoleInteraction]
//            public virtual string create(string data)
//            {
//                ObjectCreator oc = new ObjectCreator("StaticShape", "", typeof(Breakable));
//                oc["dataBlock"] = data;
//                return oc.Create().AsString();
//            }

//            [ConsoleInteraction]
//            public override void onAdd(GameBase obj)
//            {
//                if(obj["health"] == "")
//                    obj["health"] = this["health"];
//                if(obj["healthBound"] == "")
//                    obj["healthBound"] = this["healthBound"];
//            }

//            [ConsoleInteraction]
//            public override void damage(ShapeBase obj, Point3F position, GameBase source, float amount, string damagetype)
//            {
//                if(obj["enabled"] != true.AsString()) 
//                    return;
//                base.damage(obj, position, source, amount, damagetype);
   
//                float curHealth = obj["health"].AsFloat() - amount;
//                if(obj["health"].AsFloat() > 0)
//                {
//                    obj["health"] = curHealth.AsString();
//                    if(curHealth <= 0)
//                    {
//                        //((Breakable)obj).explode();
//                    }
//                    else if(curHealth <= obj["healthBound"].AsFloat())
//                    {
//                        //((Breakable)obj).prepareExplosion();
//                    }
//                }
//            }

//            #region ProxyObjects Operator Overrides

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <param name="simobjectid"></param>
//        /// <returns></returns>
//        public static bool operator ==(BreakableData ts, string simobjectid)
//            {
//            return object.ReferenceEquals(ts, null)
//                ? object.ReferenceEquals(simobjectid, null)
//                : ts.Equals(simobjectid);
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        public override int GetHashCode()
//            {
//            return base.GetHashCode();
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="obj"></param>
//        /// <returns></returns>
//        public override bool Equals(object obj)
//            {
//            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <param name="simobjectid"></param>
//        /// <returns></returns>
//        public static bool operator !=(BreakableData ts, string simobjectid)
//            {
//            if (object.ReferenceEquals(ts, null))
//                return !object.ReferenceEquals(simobjectid, null);
//            return !ts.Equals(simobjectid);
//            }


//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator string(BreakableData ts)
//            {
//            return ReferenceEquals(ts, null) ? "0" : ts._ID;
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator BreakableData(string ts)
//            {
//            uint simobjectid = resolveobject(ts);
//            return (BreakableData) Omni.self.getSimObject(simobjectid, typeof (BreakableData));
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator int(BreakableData ts)
//            {
//            return (int) ts._iID;
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="simobjectid"></param>
//        /// <returns></returns>
//        public static implicit operator BreakableData(int simobjectid)
//            {
//            return (BreakableData) Omni.self.getSimObject((uint) simobjectid, typeof (BreakableData));
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator uint(BreakableData ts)
//            {
//            return ts._iID;
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        public static implicit operator BreakableData(uint simobjectid)
//            {
//            return (BreakableData) Omni.self.getSimObject(simobjectid, typeof (BreakableData));
//            }

//        #endregion
//        }
        
//        #region ProxyObjects Operator Overrides

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <param name="simobjectid"></param>
//        /// <returns></returns>
//        public static bool operator ==(Breakable ts, string simobjectid)
//            {
//            return object.ReferenceEquals(ts, null)
//                ? object.ReferenceEquals(simobjectid, null)
//                : ts.Equals(simobjectid);
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        public override int GetHashCode()
//            {
//            return base.GetHashCode();
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="obj"></param>
//        /// <returns></returns>
//        public override bool Equals(object obj)
//            {
//            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <param name="simobjectid"></param>
//        /// <returns></returns>
//        public static bool operator !=(Breakable ts, string simobjectid)
//            {
//            if (object.ReferenceEquals(ts, null))
//                return !object.ReferenceEquals(simobjectid, null);
//            return !ts.Equals(simobjectid);
//            }


//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator string(Breakable ts)
//            {
//            return ReferenceEquals(ts, null) ? "0" : ts._ID;
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator Breakable(string ts)
//            {
//            uint simobjectid = resolveobject(ts);
//            return (Breakable) Omni.self.getSimObject(simobjectid, typeof (Breakable));
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator int(Breakable ts)
//            {
//            return (int) ts._iID;
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="simobjectid"></param>
//        /// <returns></returns>
//        public static implicit operator Breakable(int simobjectid)
//            {
//            return (Breakable) Omni.self.getSimObject((uint) simobjectid, typeof (Breakable));
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="ts"></param>
//        /// <returns></returns>
//        public static implicit operator uint(Breakable ts)
//            {
//            return ts._iID;
//            }

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <returns></returns>
//        public static implicit operator Breakable(uint simobjectid)
//            {
//            return (Breakable) Omni.self.getSimObject(simobjectid, typeof (Breakable));
//            }

//        #endregion
        
//    }
//}

//namespace WinterLeaf.Demo.Full.Models.User.Extendable
//{
//    public partial class VisualEffectData
//    {
//        //temporary, for allowing explosions to actually damage objects
//        public void doDamage(GameBase obj, float radius, float damage, string damageType, float impulse)
//        {
//            //echo("doDamage:  radius ",%radius, ", damage ", %damage, ", type ", %damageType, ", impulse ", %impulse);
//            radiusDamage.RadiusDamage(obj, obj.getPosition(), radius, damage, damageType, impulse);
//        }
//    }
//}
