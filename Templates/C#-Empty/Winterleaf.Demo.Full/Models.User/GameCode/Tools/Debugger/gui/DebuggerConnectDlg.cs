using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<DebuggerConnectDlg>))]
    public class DebuggerConnectDlg : GuiControl
        {
        [ConsoleInteraction(true, "DebuggerConnnectDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (DebuggerConnectDlg, EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "DebuggerConnectDlg, EditorGuiGroup",
                typeof (DebuggerConnectDlg));
            oc_Newobject10["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 0";
            oc_Newobject10["extent"] = "640 480";
            oc_Newobject10["minExtent"] = "8 8";
            oc_Newobject10["visible"] = "True";
            oc_Newobject10["setFirstResponder"] = "False";
            oc_Newobject10["modal"] = "True";
            oc_Newobject10["helpTag"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject9["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "220 146";
            oc_Newobject9["extent"] = "200 188";
            oc_Newobject9["minExtent"] = "8 8";
            oc_Newobject9["visible"] = "True";
            oc_Newobject9["setFirstResponder"] = "False";
            oc_Newobject9["modal"] = "True";
            oc_Newobject9["helpTag"] = "0";
            oc_Newobject9["text"] = "Connect to server:";
            oc_Newobject9["resizeWidth"] = "True";
            oc_Newobject9["resizeHeight"] = "True";
            oc_Newobject9["canMove"] = "False";
            oc_Newobject9["canClose"] = "False";
            oc_Newobject9["canMinimize"] = "False";
            oc_Newobject9["canMaximize"] = "False";
            oc_Newobject9["minSize"] = "50 50";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "20 28";
            oc_Newobject1["extent"] = "55 18";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "True";
            oc_Newobject1["setFirstResponder"] = "False";
            oc_Newobject1["modal"] = "True";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "IP Address:";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (DebuggerConnectAddress)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "DebuggerConnectAddress");
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "20 44";
            oc_Newobject2["extent"] = "160 18";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "True";
            oc_Newobject2["setFirstResponder"] = "False";
            oc_Newobject2["modal"] = "True";
            oc_Newobject2["variable"] = "$pref::DBGConnectAddress";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["returnTab"] = "true";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["profile"] = "ToolsGuiTextProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "20 68";
            oc_Newobject3["extent"] = "21 18";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "True";
            oc_Newobject3["setFirstResponder"] = "False";
            oc_Newobject3["modal"] = "True";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["text"] = "Port:";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl (DebuggerConnectPort)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "DebuggerConnectPort");
            oc_Newobject4["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "20 84";
            oc_Newobject4["extent"] = "160 18";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "True";
            oc_Newobject4["setFirstResponder"] = "False";
            oc_Newobject4["modal"] = "True";
            oc_Newobject4["variable"] = "$pref::DBGConnectPort";
            oc_Newobject4["helpTag"] = "0";
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["returnTab"] = "true";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "20 108";
            oc_Newobject5["extent"] = "52 18";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "True";
            oc_Newobject5["setFirstResponder"] = "False";
            oc_Newobject5["modal"] = "True";
            oc_Newobject5["helpTag"] = "0";
            oc_Newobject5["text"] = "Password:";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiTextEditCtrl (DebuggerConnectPassword)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextEditCtrl", "DebuggerConnectPassword");
            oc_Newobject6["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "20 124";
            oc_Newobject6["extent"] = "160 18";
            oc_Newobject6["minExtent"] = "8 8";
            oc_Newobject6["visible"] = "True";
            oc_Newobject6["setFirstResponder"] = "False";
            oc_Newobject6["modal"] = "True";
            oc_Newobject6["variable"] = "$pref::DBGConnectPassword";
            oc_Newobject6["helpTag"] = "0";
            oc_Newobject6["historySize"] = "0";
            oc_Newobject6["returnTab"] = "true";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject7["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "56 156";
            oc_Newobject7["extent"] = "40 16";
            oc_Newobject7["minExtent"] = "8 8";
            oc_Newobject7["visible"] = "True";
            oc_Newobject7["setFirstResponder"] = "False";
            oc_Newobject7["modal"] = "True";
            oc_Newobject7["command"] = "DbgConnect();";
            oc_Newobject7["helpTag"] = "0";
            oc_Newobject7["text"] = "Open";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject8["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["position"] = "104 156";
            oc_Newobject8["extent"] = "40 16";
            oc_Newobject8["minExtent"] = "8 8";
            oc_Newobject8["visible"] = "True";
            oc_Newobject8["setFirstResponder"] = "False";
            oc_Newobject8["modal"] = "True";
            oc_Newobject8["command"] = "Canvas.popDialog(DebuggerConnectDlg);";
            oc_Newobject8["helpTag"] = "0";
            oc_Newobject8["text"] = "Cancel";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject10.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DebuggerConnectDlg ts, string simobjectid)
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
        public static bool operator !=(DebuggerConnectDlg ts, string simobjectid)
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
        public static implicit operator string(DebuggerConnectDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DebuggerConnectDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (DebuggerConnectDlg) Omni.self.getSimObject(simobjectid, typeof (DebuggerConnectDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DebuggerConnectDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DebuggerConnectDlg(int simobjectid)
            {
            return (DebuggerConnectDlg) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerConnectDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DebuggerConnectDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DebuggerConnectDlg(uint simobjectid)
            {
            return (DebuggerConnectDlg) Omni.self.getSimObject(simobjectid, typeof (DebuggerConnectDlg));
            }

        #endregion
        }
    }