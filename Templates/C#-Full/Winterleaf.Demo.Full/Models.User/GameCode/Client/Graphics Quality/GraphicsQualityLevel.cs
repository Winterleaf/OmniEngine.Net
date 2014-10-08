#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.GraphicsQuality;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GraphicsQualityLevel>))]
    public class GraphicsQualityLevel : ArrayObject
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        [ConsoleInteraction(true)]
        public virtual void apply()
            {
            for (int i = 0; i < this.count(); i++)
                {
                string pref = this.getKey(i);
                string value = this.getValue(i);
                sGlobal[pref] = value;
                }
            // If we have an overloaded onApply method then
            // call it now to finalize the changes.

            QualityGroup group = this.getGroup();
            if (group.isObject())
                group.onApply(this);
            }

        [ConsoleInteraction(true)]
        public virtual bool isCurrent()
            {
            for (int i = 0; i < this.count(); i++)
                {
                string pref = getKey(i);
                string value = getValue(i);

                if (value.ToLower() == "true")
                    value = "1";
                else if (value.ToLower() == "false")
                    value = "0";

                if (sGlobal[pref] != value)
                    return false;
                }
            return true;
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GraphicsQualityLevel ts, string simobjectid)
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
        public static bool operator !=(GraphicsQualityLevel ts, string simobjectid)
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
        public static implicit operator string(GraphicsQualityLevel ts)
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
        public static implicit operator GraphicsQualityLevel(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GraphicsQualityLevel) Omni.self.getSimObject(simobjectid, typeof (GraphicsQualityLevel));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GraphicsQualityLevel ts)
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
        public static implicit operator GraphicsQualityLevel(int simobjectid)
            {
            return (GraphicsQualityLevel) Omni.self.getSimObject((uint) simobjectid, typeof (GraphicsQualityLevel));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GraphicsQualityLevel ts)
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
        public static implicit operator GraphicsQualityLevel(uint simobjectid)
            {
            return (GraphicsQualityLevel) Omni.self.getSimObject(simobjectid, typeof (GraphicsQualityLevel));
            }

        #endregion
        }
    }