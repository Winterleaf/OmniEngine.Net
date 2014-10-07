using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Recordings
    {
    [TypeConverter(typeof (TypeConverterGeneric<recordingsDlg>))]
    public class recordingsDlg : GuiControl
        {
        public override void onWake()
            {
            ((GuiTextListCtrl) "RecordingsDlgList").clear();
            int i = 0;
            string filespec = sGlobal["$currentMod"] + "/recordings/*.rec";
            Util._echo(filespec);
            for (string file = Util.findFirstFile(filespec, true); file != ""; file = Util.findNextFile(filespec))
                ((GuiTextListCtrl) "RecordingsDlgList").add((i++).AsString(), Util.fileBase(file));

            ((GuiTextListCtrl) "RecordingsDlgList").sort("0");
            ((GuiTextListCtrl) "RecordingsDlgList").setSelectedRow(0);
            ((GuiTextListCtrl) "RecordingsDlgList").scrollVisible(0);
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(recordingsDlg ts, string simobjectid)
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
        public static bool operator !=(recordingsDlg ts, string simobjectid)
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
        public static implicit operator string(recordingsDlg ts)
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
        public static implicit operator recordingsDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (recordingsDlg) Omni.self.getSimObject(simobjectid, typeof (recordingsDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(recordingsDlg ts)
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
        public static implicit operator recordingsDlg(int simobjectid)
            {
            return (recordingsDlg) Omni.self.getSimObject((uint) simobjectid, typeof (recordingsDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(recordingsDlg ts)
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
        public static implicit operator recordingsDlg(uint simobjectid)
            {
            return (recordingsDlg) Omni.self.getSimObject(simobjectid, typeof (recordingsDlg));
            }

        #endregion
        }
    }