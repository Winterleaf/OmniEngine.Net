using System.ComponentModel;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    [TypeConverter(typeof (TypeConverterGeneric<EditorLightingMenu>))]
    public class EditorLightingMenu : MenuBuilder
        {
        private int lmFirstIndex
            {
            get { return this["lmFirstIndex"].AsInt(); }
            set { this["lmFirstIndex"] = value.AsString(); }
            }

        private int lmLastIndex
            {
            get { return this["lmLastIndex"].AsInt(); }
            set { this["lmLastIndex"] = value.AsString(); }
            }


        public override void onAdd()
            {
            base.onAdd();
            // Get the light manager names.
            string lightManagers = Util.getLightManagerNames();
            // Where we gonna insert them?

            int lmFirstIndex = this.getItemCount();
            // Add the light mangers to the lighting menu.
            int count = Util.getFieldCount(lightManagers);
            int index = 0;
            for (int i = 0; i < count; i++)
                {
                string lm = Util.getField(lightManagers, i);
                // Store a reverse lookup of the light manager
                // name to the menu index... used in onMenuSelect.

                index = lmFirstIndex + i;

                this["lmToIndex[" + lm + "]"] = index.AsString();
                // The command just sets the light manager.

                string cmd = "setLightManager(\"" + lm + "\"); $pref::lightManager = \"" + lm + "\";";

                // Add it.

                addItem(index.AsString(), lm + "\t" + "" + "\t" + cmd);
                }
            // Store for later in EditorLightingMenu.
            lmLastIndex = index;
            }

        public override void onMenuSelect()
            {
            string lm = Util.getActiveLightManager();
            int index = this["lmToIndex[" + lm + "]"].AsInt();

            checkRadioItem(lmFirstIndex, lmLastIndex, index);
            //%selSize = EWorldEditor.getSelectionSize();
            enableItem(1, true);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorLightingMenu ts, string simobjectid)
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
        public static bool operator !=(EditorLightingMenu ts, string simobjectid)
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
        public static implicit operator string(EditorLightingMenu ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorLightingMenu(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorLightingMenu) Omni.self.getSimObject(simobjectid, typeof (EditorLightingMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorLightingMenu ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorLightingMenu(int simobjectid)
            {
            return (EditorLightingMenu) Omni.self.getSimObject((uint) simobjectid, typeof (EditorLightingMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorLightingMenu ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorLightingMenu(uint simobjectid)
            {
            return (EditorLightingMenu) Omni.self.getSimObject(simobjectid, typeof (EditorLightingMenu));
            }

        #endregion
        }
    }