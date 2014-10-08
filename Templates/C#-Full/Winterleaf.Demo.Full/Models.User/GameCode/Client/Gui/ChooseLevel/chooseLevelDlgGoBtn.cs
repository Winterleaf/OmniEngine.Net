using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.ChooseLevel
    {
    [TypeConverter(typeof (TypeConverterGeneric<chooseLevelDlgGoBtn>))]
    public class chooseLevelDlgGoBtn : GuiButtonCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        // Do this onMouseUp not via Command which occurs onMouseDown so we do
        // not have a lingering mouseUp event lingering in the ether.
        public override void onMouseUp()
            {
            // So we can't fire the button when loading is in progress.
            if ("ServerGroup".isObject())
                return;

            if (((chooseLevelDlg) "ChooseLevelDlg")["launchInEditor"].AsBool())
                {
                Util.activatePackage("BootEditor");
                ((chooseLevelDlg) "ChooseLevelDlg")["launchInEditor"] = false.AsString();
                chooseLevelDlg.StartLevel("", "SinglePlayer");
                }
            else
                {
                chooseLevelDlg.StartLevel("", "");
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(chooseLevelDlgGoBtn ts, string simobjectid)
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
        public static bool operator !=(chooseLevelDlgGoBtn ts, string simobjectid)
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
        public static implicit operator string(chooseLevelDlgGoBtn ts)
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
        public static implicit operator chooseLevelDlgGoBtn(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (chooseLevelDlgGoBtn) Omni.self.getSimObject(simobjectid, typeof (chooseLevelDlgGoBtn));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(chooseLevelDlgGoBtn ts)
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
        public static implicit operator chooseLevelDlgGoBtn(int simobjectid)
            {
            return (chooseLevelDlgGoBtn) Omni.self.getSimObject((uint) simobjectid, typeof (chooseLevelDlgGoBtn));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(chooseLevelDlgGoBtn ts)
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
        public static implicit operator chooseLevelDlgGoBtn(uint simobjectid)
            {
            return (chooseLevelDlgGoBtn) Omni.self.getSimObject(simobjectid, typeof (chooseLevelDlgGoBtn));
            }

        #endregion
        }
    }