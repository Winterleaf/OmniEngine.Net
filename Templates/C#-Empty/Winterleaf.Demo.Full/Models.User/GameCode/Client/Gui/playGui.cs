using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<playGui>))]
    public class playGui : GameTSCtrl
        {
        public static void initialize()
            {
            #region GameTSCtrl (PlayGui)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GameTSCtrl", "PlayGui", typeof (playGui));
            oc_Newobject20["cameraZRot"] = "0";
            oc_Newobject20["forceFOV"] = "0";
            oc_Newobject20["reflectPriority"] = "1";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "GuiContentProfile";
            oc_Newobject20["HorizSizing"] = "right";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["Extent"] = "1024 768";
            oc_Newobject20["MinExtent"] = "8 8";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["canSaveDynamicFields"] = "1";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["helpTag"] = "0";
            oc_Newobject20["noCursor"] = "1";

            #region GuiBitmapCtrl (CenterPrintDlg)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "CenterPrintDlg");
            oc_Newobject2["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject2["wrap"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "CenterPrintProfile";
            oc_Newobject2["HorizSizing"] = "center";
            oc_Newobject2["VertSizing"] = "center";
            oc_Newobject2["position"] = "237 375";
            oc_Newobject2["Extent"] = "550 20";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "0";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiMLTextCtrl (CenterPrintText)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiMLTextCtrl", "CenterPrintText",
                typeof (printText));
            oc_Newobject1["lineSpacing"] = "2";
            oc_Newobject1["allowColorChars"] = "0";
            oc_Newobject1["maxChars"] = "-1";
            oc_Newobject1["useURLMouseCursor"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "CenterPrintTextProfile";
            oc_Newobject1["HorizSizing"] = "center";
            oc_Newobject1["VertSizing"] = "center";
            oc_Newobject1["position"] = "0 0";
            oc_Newobject1["Extent"] = "546 12";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject20["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapCtrl (BottomPrintDlg)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "BottomPrintDlg");
            oc_Newobject4["bitmap"] = "art/gui/hudfill.png";
            oc_Newobject4["wrap"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "CenterPrintProfile";
            oc_Newobject4["HorizSizing"] = "center";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["position"] = "237 719";
            oc_Newobject4["Extent"] = "550 20";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "0";
            oc_Newobject4["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiMLTextCtrl (BottomPrintText)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiMLTextCtrl", "BottomPrintText",
                typeof (printText));
            oc_Newobject3["lineSpacing"] = "2";
            oc_Newobject3["allowColorChars"] = "0";
            oc_Newobject3["maxChars"] = "-1";
            oc_Newobject3["useURLMouseCursor"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "CenterPrintTextProfile";
            oc_Newobject3["HorizSizing"] = "center";
            oc_Newobject3["VertSizing"] = "center";
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["Extent"] = "546 12";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject20["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapCtrl (LagIcon)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "LagIcon");
            oc_Newobject5["bitmap"] = "art/gui/lagIcon.png";
            oc_Newobject5["wrap"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "GuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "572 3";
            oc_Newobject5["Extent"] = "32 32";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "0";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject20["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject20.Create();
            }

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onWake()
            {
            // Turn off any shell sounds...
            // sfxStop( ... );

            bGlobal["$enableDirectInput"] = true;
            Util.activateDirectInput();

          
            // just update the action map here
            ((ActionMap) "moveMap").push();

            refreshCenterTextCtrl();
            refreshBottomTextCtrl();
            }

        public override void onSleep()
            {
           
            // pop the keymaps
            ((ActionMap) "moveMap").pop();
            }


        public virtual void clearHud()
            {
            ((GuiCanvas) "Canvas").popDialog("MainChatHud");

            while (getCount() > 0)
                getObject(0).delete();
            }

        public void refreshBottomTextCtrl()
            {
            ((GuiMLTextCtrl) "BottomPrintText").position = new Point2I(0, 0);
            }

        public void refreshCenterTextCtrl()
            {
            ((GuiMLTextCtrl) "CenterPrintText").position = new Point2I(0, 0);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(playGui ts, string simobjectid)
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
        public static bool operator !=(playGui ts, string simobjectid)
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
        public static implicit operator string(playGui ts)
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
        public static implicit operator playGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (playGui) Omni.self.getSimObject(simobjectid, typeof (playGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(playGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator playGui(int simobjectid)
            {
            return (playGui) Omni.self.getSimObject((uint) simobjectid, typeof (playGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(playGui ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator playGui(uint simobjectid)
            {
            return (playGui) Omni.self.getSimObject(simobjectid, typeof (playGui));
            }

        #endregion
        }
    }