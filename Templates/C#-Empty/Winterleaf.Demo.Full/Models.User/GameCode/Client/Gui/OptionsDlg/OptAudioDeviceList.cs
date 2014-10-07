using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
    {
    [TypeConverter(typeof (TypeConverterGeneric<OptAudioDeviceList>))]
    public class OptAudioDeviceList : GuiPopUpMenuCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onSelect(string id, string text)
            {
            if (text == "")
                return;

            sGlobal["$pref::SFX::device"] = text;
            if (
                !Util.sfxCreateDevice(sGlobal["$pref::SFX::provider"], sGlobal["$pref::SFX::device"],
                    bGlobal["$pref::SFX::useHardware"], -1))
                Util._error("Unable to create SFX device: " + sGlobal["$pref::SFX::provider"] + " " +
                            sGlobal["$pref::SFX::device"] + " " + bGlobal["$pref::SFX::useHardware"]);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OptAudioDeviceList ts, string simobjectid)
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
        public static bool operator !=(OptAudioDeviceList ts, string simobjectid)
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
        public static implicit operator string(OptAudioDeviceList ts)
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
        public static implicit operator OptAudioDeviceList(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (OptAudioDeviceList) Omni.self.getSimObject(simobjectid, typeof (OptAudioDeviceList));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(OptAudioDeviceList ts)
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
        public static implicit operator OptAudioDeviceList(int simobjectid)
            {
            return (OptAudioDeviceList) Omni.self.getSimObject((uint) simobjectid, typeof (OptAudioDeviceList));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(OptAudioDeviceList ts)
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
        public static implicit operator OptAudioDeviceList(uint simobjectid)
            {
            return (OptAudioDeviceList) Omni.self.getSimObject(simobjectid, typeof (OptAudioDeviceList));
            }

        #endregion
        }
    }