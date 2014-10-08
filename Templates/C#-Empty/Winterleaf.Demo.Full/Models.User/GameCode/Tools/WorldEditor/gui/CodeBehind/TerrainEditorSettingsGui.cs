using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    //Todo I cannot find where this code is used by anything.  Is it a artifact?
    [TypeConverter(typeof (TypeConverterGeneric<TerrainEditorSettingsGui>))]
    public class TerrainEditorSettingsGui : GuiControl
        {
        public override void onWake()
            {
            ((GuiFilterCtrl) "TESoftSelectFilter").setValue(((TerrainEditor) "ETerrainEditor")["softSelectFilter"]);
            }

        public override void onSleep()
            {
            ((TerrainEditor) "ETerrainEditor")["softSelectFilter"] =
                ((GuiFilterCtrl) "TESoftSelectFilter").getValue();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainEditorSettingsGui ts, string simobjectid)
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
        public static bool operator !=(TerrainEditorSettingsGui ts, string simobjectid)
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
        public static implicit operator string(TerrainEditorSettingsGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainEditorSettingsGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (TerrainEditorSettingsGui) Omni.self.getSimObject(simobjectid, typeof (TerrainEditorSettingsGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainEditorSettingsGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainEditorSettingsGui(int simobjectid)
            {
            return
                (TerrainEditorSettingsGui) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainEditorSettingsGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainEditorSettingsGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainEditorSettingsGui(uint simobjectid)
            {
            return (TerrainEditorSettingsGui) Omni.self.getSimObject(simobjectid, typeof (TerrainEditorSettingsGui));
            }

        #endregion
        }
    }