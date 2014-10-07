using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<RemapDlg>))]
    public class RemapDlg : GuiControl
        {
        public static void initialize()
            {
            #region GuiControl (RemapDlg)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "RemapDlg", typeof (RemapDlg));
            oc_Newobject4["position"] = "0 0";
            oc_Newobject4["extent"] = "1024 768";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiDefaultProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "1";
            oc_Newobject4["helpTag"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject3["text"] = "Remap Control";
            oc_Newobject3["resizeWidth"] = "1";
            oc_Newobject3["resizeHeight"] = "1";
            oc_Newobject3["canMove"] = "1";
            oc_Newobject3["canClose"] = "1";
            oc_Newobject3["canMinimize"] = "1";
            oc_Newobject3["canMaximize"] = "1";
            oc_Newobject3["canCollapse"] = "0";
            oc_Newobject3["edgeSnap"] = "1";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["position"] = "390 352";
            oc_Newobject3["extent"] = "243 64";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["horizSizing"] = "center";
            oc_Newobject3["vertSizing"] = "center";
            oc_Newobject3["profile"] = "GuiWindowProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Re-bind control to...";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "49 32";
            oc_Newobject1["extent"] = "144 20";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "height";
            oc_Newobject1["profile"] = "GuiTextProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["internalName"] = "OptRemapText";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiInputCtrl (OptRemapInputCtrl)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiInputCtrl", "OptRemapInputCtrl",
                typeof (OptRemapInputCtrl));
            oc_Newobject2["lockMouse"] = "0";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["extent"] = "64 64";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["horizSizing"] = "center";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiInputCtrlProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject4.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RemapDlg ts, string simobjectid)
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
        public static bool operator !=(RemapDlg ts, string simobjectid)
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
        public static implicit operator string(RemapDlg ts)
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
        public static implicit operator RemapDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (RemapDlg) Omni.self.getSimObject(simobjectid, typeof (RemapDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RemapDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RemapDlg(int simobjectid)
            {
            return (RemapDlg) Omni.self.getSimObject((uint) simobjectid, typeof (RemapDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RemapDlg ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RemapDlg(uint simobjectid)
            {
            return (RemapDlg) Omni.self.getSimObject(simobjectid, typeof (RemapDlg));
            }

        #endregion
        }
    }