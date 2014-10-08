using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
    {
    [TypeConverter(typeof (TypeConverterGeneric<AudioStateExclusive>))]
    public class AudioStateExclusive : SFXState
        {
        //-----------------------------------------------------------------------------
        // AudioStateExclusive class.
        //
        // Automatically deactivates sibling SFXStates in its parent SimGroup
        // when activated.
        public override void onActivate()
            {
            base.onActivate();

            SimGroup group = parentGroup.ID;

            for (uint i = 0; i < group.getCount(); i++)
                {
                SFXState obj = group.getObject(i);

                if (obj.getId() != this.getId() && isMemberOfClass("SFXState") && isActive())
                    obj.deactivate();
                }
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AudioStateExclusive ts, string simobjectid)
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
        public static bool operator !=(AudioStateExclusive ts, string simobjectid)
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
        public static implicit operator string(AudioStateExclusive ts)
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
        public static implicit operator AudioStateExclusive(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (AudioStateExclusive) Omni.self.getSimObject(simobjectid, typeof (AudioStateExclusive));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AudioStateExclusive ts)
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
        public static implicit operator AudioStateExclusive(int simobjectid)
            {
            return (AudioStateExclusive) Omni.self.getSimObject((uint) simobjectid, typeof (AudioStateExclusive));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AudioStateExclusive ts)
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
        public static implicit operator AudioStateExclusive(uint simobjectid)
            {
            return (AudioStateExclusive) Omni.self.getSimObject(simobjectid, typeof (AudioStateExclusive));
            }

        #endregion
        }
    }