using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.MenuBar
    {
    [TypeConverter(typeof (TypeConverterGeneric<BaseEditorFileMenu>))]
    public class BaseEditorFileMenu : MenuBuilder
        {
        [ConsoleInteraction]
        public void onNew()
            {
            }

        [ConsoleInteraction]
        public void onOpen()
            {
            }

        [ConsoleInteraction]
        public void onSave()
            {
            }

        [ConsoleInteraction]
        public void onSaveAs()
            {
            }

        [ConsoleInteraction]
        public void onSaveAll()
            {
            }

        [ConsoleInteraction]
        public void onRevert()
            {
            }

        [ConsoleInteraction]
        public void onClose()
            {
            }

        [ConsoleInteraction]
        public void onImport()
            {
            }

        [ConsoleInteraction]
        public void onExport()
            {
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(BaseEditorFileMenu ts, string simobjectid)
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
        public static bool operator !=(BaseEditorFileMenu ts, string simobjectid)
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
        public static implicit operator string(BaseEditorFileMenu ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator BaseEditorFileMenu(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (BaseEditorFileMenu) Omni.self.getSimObject(simobjectid, typeof (BaseEditorFileMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(BaseEditorFileMenu ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator BaseEditorFileMenu(int simobjectid)
            {
            return (BaseEditorFileMenu) Omni.self.getSimObject((uint) simobjectid, typeof (BaseEditorFileMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(BaseEditorFileMenu ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator BaseEditorFileMenu(uint simobjectid)
            {
            return (BaseEditorFileMenu) Omni.self.getSimObject(simobjectid, typeof (BaseEditorFileMenu));
            }

        #endregion
        }
    }