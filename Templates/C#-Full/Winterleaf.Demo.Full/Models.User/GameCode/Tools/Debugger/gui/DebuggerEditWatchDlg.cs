using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<DebuggerEditWatchDlg>))]
    public class DebuggerEditWatchDlg : GuiControl
        {
        [ConsoleInteraction(true, "DebuggerEditWatchDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (DebuggerEditWatchDlg, EditorGuiGroup)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "DebuggerEditWatchDlg, EditorGuiGroup",
                typeof (DebuggerEditWatchDlg));
            oc_Newobject6["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "0 0";
            oc_Newobject6["extent"] = "640 480";
            oc_Newobject6["minExtent"] = "8 8";
            oc_Newobject6["visible"] = "True";
            oc_Newobject6["setFirstResponder"] = "False";
            oc_Newobject6["modal"] = "True";
            oc_Newobject6["helpTag"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject5["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "220 180";
            oc_Newobject5["extent"] = "200 108";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "True";
            oc_Newobject5["setFirstResponder"] = "False";
            oc_Newobject5["modal"] = "True";
            oc_Newobject5["helpTag"] = "0";
            oc_Newobject5["text"] = "Edit a Variable";
            oc_Newobject5["resizeWidth"] = "True";
            oc_Newobject5["resizeHeight"] = "True";
            oc_Newobject5["canMove"] = "False";
            oc_Newobject5["canClose"] = "False";
            oc_Newobject5["canMinimize"] = "False";
            oc_Newobject5["canMaximize"] = "False";
            oc_Newobject5["minSize"] = "50 50";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "20 28";
            oc_Newobject1["extent"] = "99 18";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "True";
            oc_Newobject1["setFirstResponder"] = "False";
            oc_Newobject1["modal"] = "True";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "Enter the new value:";

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (EditWatchDialogValue)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "EditWatchDialogValue");
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "20 44";
            oc_Newobject2["extent"] = "160 18";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "True";
            oc_Newobject2["setFirstResponder"] = "False";
            oc_Newobject2["modal"] = "True";
            oc_Newobject2["altCommand"] = "DbgWatchDialogEdit();";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["fontHL"] = "14 253 Arial";
            oc_Newobject2["font"] = "14 244 Arial";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "56 80";
            oc_Newobject3["extent"] = "40 16";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "True";
            oc_Newobject3["setFirstResponder"] = "False";
            oc_Newobject3["modal"] = "True";
            oc_Newobject3["command"] = "DbgWatchDialogEdit();";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["text"] = "Edit";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject4["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "104 80";
            oc_Newobject4["extent"] = "40 16";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "True";
            oc_Newobject4["setFirstResponder"] = "False";
            oc_Newobject4["modal"] = "True";
            oc_Newobject4["command"] = "Canvas.popDialog(DebuggerEditWatchDlg);";
            oc_Newobject4["helpTag"] = "0";
            oc_Newobject4["text"] = "Cancel";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject6.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DebuggerEditWatchDlg ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null)
                ? object.ReferenceEquals(simobjectid, null)
                : ts.Equals(simobjectid);
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
        public static bool operator !=(DebuggerEditWatchDlg ts, string simobjectid)
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
        public static implicit operator string(DebuggerEditWatchDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DebuggerEditWatchDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (DebuggerEditWatchDlg) Omni.self.getSimObject(simobjectid, typeof (DebuggerEditWatchDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DebuggerEditWatchDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DebuggerEditWatchDlg(int simobjectid)
            {
            return (DebuggerEditWatchDlg) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerEditWatchDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DebuggerEditWatchDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DebuggerEditWatchDlg(uint simobjectid)
            {
            return (DebuggerEditWatchDlg) Omni.self.getSimObject(simobjectid, typeof (DebuggerEditWatchDlg));
            }

        #endregion
        }
    }