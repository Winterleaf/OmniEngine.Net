using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
    {
    [TypeConverter(typeof (TypeConverterGeneric<OptGraphicsDriverMenu>))]
    public class OptGraphicsDriverMenu : GuiPopUpMenuCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onSelect(string id, string text)
            {
            // Attempt to keep the same resolution settings:
            GuiPopUpMenuCtrl resMenu =
                ((OptionsDlg) "OptionsDlg").findObjectByInternalName("OptGraphicsResolutionMenu", true);
            string currRes = resMenu.getText();
            // If its empty the use the current.
            if (currRes == "")
                currRes = OptionsDlg._makePrettyResString(((GuiCanvas) "Canvas").getVideoMode());

            // Fill the resolution list.
            ((OptionsDlg) "optionsDlg").initResMenu();
            // Try to select the previous settings:

            int selId = resMenu.findText(currRes);
            if (selId == -1)
                selId = 0;
            resMenu.setSelected(selId);

            ((OptionsDlg) "optionsDlg")._updateApplyState();

            sGlobal["$pref::Video::displayDevice"] = this.getText();
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(OptGraphicsDriverMenu ts, string simobjectid)
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
        public static bool operator !=(OptGraphicsDriverMenu ts, string simobjectid)
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
        public static implicit operator string(OptGraphicsDriverMenu ts)
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
        public static implicit operator OptGraphicsDriverMenu(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (OptGraphicsDriverMenu) Omni.self.getSimObject(simobjectid, typeof (OptGraphicsDriverMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(OptGraphicsDriverMenu ts)
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
        public static implicit operator OptGraphicsDriverMenu(int simobjectid)
            {
            return (OptGraphicsDriverMenu) Omni.self.getSimObject((uint) simobjectid, typeof (OptGraphicsDriverMenu));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(OptGraphicsDriverMenu ts)
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
        public static implicit operator OptGraphicsDriverMenu(uint simobjectid)
            {
            return (OptGraphicsDriverMenu) Omni.self.getSimObject(simobjectid, typeof (OptGraphicsDriverMenu));
            }

        #endregion
        }
    }