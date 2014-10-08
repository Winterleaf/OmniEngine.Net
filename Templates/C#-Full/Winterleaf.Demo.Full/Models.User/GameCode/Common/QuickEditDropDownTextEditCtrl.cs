using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Common
    {
    [TypeConverter(typeof (TypeConverterGeneric<QuickEditDropDownTextEditCtrl>))]
    public class QuickEditDropDownTextEditCtrl : GuiControl
        {
        [ConsoleInteraction]
        public virtual void onRenameItem()
            {
            }

        [ConsoleInteraction]
        public virtual void updateFromChild(GuiControl ctrl)
            {
            if (ctrl.internalName == "PopupMenu")
                ((GuiControl) this.FOF("TextEdit")).call("setText", ctrl.call("getText"));
            else if (ctrl.internalName == "textEdit")
                {
                GuiPopUpMenuCtrl popup = this.FOF("PopupMenu");
                popup.changeTextById(popup.getSelected(), ctrl.call("getText"));
                onRenameItem();
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(QuickEditDropDownTextEditCtrl ts, string simobjectid)
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
        public static bool operator !=(QuickEditDropDownTextEditCtrl ts, string simobjectid)
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
        public static implicit operator string(QuickEditDropDownTextEditCtrl ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator QuickEditDropDownTextEditCtrl(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (QuickEditDropDownTextEditCtrl)
                    Omni.self.getSimObject(simobjectid, typeof (QuickEditDropDownTextEditCtrl));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(QuickEditDropDownTextEditCtrl ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator QuickEditDropDownTextEditCtrl(int simobjectid)
            {
            return
                (QuickEditDropDownTextEditCtrl)
                    Omni.self.getSimObject((uint) simobjectid, typeof (QuickEditDropDownTextEditCtrl));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(QuickEditDropDownTextEditCtrl ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator QuickEditDropDownTextEditCtrl(uint simobjectid)
            {
            return
                (QuickEditDropDownTextEditCtrl)
                    Omni.self.getSimObject(simobjectid, typeof (QuickEditDropDownTextEditCtrl));
            }

        #endregion
        }
    }