using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
    {
    [TypeConverter(typeof (TypeConverterGeneric<GuiPopUpMenuCtrl>))]
    internal class OptAudioProviderList : GuiPopUpMenuCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }


        public override void onSelect(string id, string text)
            {
            // Skip empty provider selections.   
            if (text == "")
                return;

            sGlobal["$pref::SFX::provider"] = text;

            GuiPopUpMenuCtrl OptAudioDeviceList = "OptAudioDeviceList";
            OptAudioDeviceList.clear();

            string buffer = Util.sfxGetAvailableDevices();
            int count = Util.getRecordCount(buffer);

            for (int i = 0; i < count; i++)
                {
                string record = Util.getRecord(buffer, i);
                string provider = Util.getField(record, 0);
                string device = Util.getField(record, 1);

                if (provider != text)
                    continue;

                if (OptAudioDeviceList.findText(device) == -1)
                    OptAudioDeviceList.add(device, i);
                }
            // Find the previous selected device.
            int selId = OptAudioDeviceList.findText(sGlobal["$pref::SFX::device"]);
            if (selId == -1)
                OptAudioDeviceList.setFirstSelected();
            else
                OptAudioDeviceList.setSelected(selId);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OptAudioProviderList ts, string simobjectid)
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
        public static bool operator !=(OptAudioProviderList ts, string simobjectid)
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
        public static implicit operator string(OptAudioProviderList ts)
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
        public static implicit operator OptAudioProviderList(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (OptAudioProviderList) Omni.self.getSimObject(simobjectid, typeof (OptAudioProviderList));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(OptAudioProviderList ts)
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
        public static implicit operator OptAudioProviderList(int simobjectid)
            {
            return (OptAudioProviderList) Omni.self.getSimObject((uint) simobjectid, typeof (OptAudioProviderList));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(OptAudioProviderList ts)
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
        public static implicit operator OptAudioProviderList(uint simobjectid)
            {
            return (OptAudioProviderList) Omni.self.getSimObject(simobjectid, typeof (OptAudioProviderList));
            }

        #endregion
        }
    }