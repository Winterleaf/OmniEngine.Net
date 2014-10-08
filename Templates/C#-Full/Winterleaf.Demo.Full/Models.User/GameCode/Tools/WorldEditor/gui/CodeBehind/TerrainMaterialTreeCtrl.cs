using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<TerrainMaterialTreeCtrl>))]
    public class TerrainMaterialTreeCtrl : GuiTreeViewCtrl
        {
        public override void onSelect(string x, string y)
            {
            ((TerrainMaterialDlg) "TerrainMaterialDlg").onSelect(x);
            }

        public override void onUnselect(int itemOrObjectId)
            {
            ((TerrainMaterialDlg) "TerrainMaterialDlg").onUnSelect(itemOrObjectId);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TerrainMaterialTreeCtrl ts, string simobjectid)
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
        public static bool operator !=(TerrainMaterialTreeCtrl ts, string simobjectid)
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
        public static implicit operator string(TerrainMaterialTreeCtrl ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator TerrainMaterialTreeCtrl(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (TerrainMaterialTreeCtrl) Omni.self.getSimObject(simobjectid, typeof (TerrainMaterialTreeCtrl));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TerrainMaterialTreeCtrl ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TerrainMaterialTreeCtrl(int simobjectid)
            {
            return
                (TerrainMaterialTreeCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (TerrainMaterialTreeCtrl));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TerrainMaterialTreeCtrl ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TerrainMaterialTreeCtrl(uint simobjectid)
            {
            return (TerrainMaterialTreeCtrl) Omni.self.getSimObject(simobjectid, typeof (TerrainMaterialTreeCtrl));
            }

        #endregion
        }
    }