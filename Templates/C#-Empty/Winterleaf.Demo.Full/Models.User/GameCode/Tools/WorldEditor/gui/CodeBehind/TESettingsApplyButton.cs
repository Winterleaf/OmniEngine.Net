using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<TESettingsApplyButton>))]
    public class TESettingsApplyButton : GuiButtonCtrl
        {
        public override void onAction()
            {
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            ETerrainEditor.softSelectFilter = ((GuiFilterCtrl) "TESoftSelectFilter").getValue();
            ETerrainEditor.resetSelWeights(true);
            ETerrainEditor.processAction("softSelect");
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TESettingsApplyButton ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(TESettingsApplyButton ts, string simobjectid)
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
        public static implicit operator string(TESettingsApplyButton ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TESettingsApplyButton(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (TESettingsApplyButton) Omni.self.getSimObject(simobjectid, typeof (TESettingsApplyButton));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TESettingsApplyButton ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TESettingsApplyButton(int simobjectid)
            {
            return (TESettingsApplyButton) Omni.self.getSimObject((uint) simobjectid, typeof (TESettingsApplyButton));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TESettingsApplyButton ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TESettingsApplyButton(uint simobjectid)
            {
            return (TESettingsApplyButton) Omni.self.getSimObject(simobjectid, typeof (TESettingsApplyButton));
            }

        #endregion
        }
    }