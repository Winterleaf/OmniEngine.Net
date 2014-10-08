using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Common
    {
    [TypeConverter(typeof (TypeConverterGeneric<FrameOverlayGui>))]
    public class FrameOverlayGui : GuiControl
        {
        public static void initialize()
            {
            #region GuiControl (FrameOverlayGui)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiControl", "FrameOverlayGui", typeof (FrameOverlayGui));
            oc_Newobject2["profile"] = "GuiModelessDialogProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["extent"] = "640 350";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "True";
            oc_Newobject2["setFirstResponder"] = "False";
            oc_Newobject2["modal"] = "false";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["noCursor"] = new ObjectCreator.StringNoQuote("true");

            #region GuiWindowCtrl (MetricsWindow)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiWindowCtrl", "FrameOverlayGuiWindow");
            oc_Newobject22["text"] = "Metrics Display";
            oc_Newobject22["resizeWidth"] = "1";
            oc_Newobject22["resizeHeight"] = "1";
            oc_Newobject22["canMove"] = "1";
            oc_Newobject22["canClose"] = "0";
            oc_Newobject22["canMinimize"] = "0";
            oc_Newobject22["canMaximize"] = "0";
            oc_Newobject22["canCollapse"] = "0";
            oc_Newobject22["edgeSnap"] = "1";
            oc_Newobject22["setTitle"] = "0";
            oc_Newobject22["ShowTitle"] = "1";
            oc_Newobject22["AllowPopWindow"] = "1";
            oc_Newobject22["isInPopup"] = "0";
            oc_Newobject22["margin"] = "0 0 0 0";
            oc_Newobject22["padding"] = "0 0 0 0";
            oc_Newobject22["anchorTop"] = "1";
            oc_Newobject22["anchorBottom"] = "0";
            oc_Newobject22["anchorLeft"] = "1";
            oc_Newobject22["anchorRight"] = "0";
            oc_Newobject22["position"] = "0 20";
            oc_Newobject22["extent"] = "640 350";
            oc_Newobject22["minExtent"] = "8 2";
            oc_Newobject22["maxExtent"] = "1920 1080";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["profile"] = "GuiWindowProfile";
            oc_Newobject22["controlFontColor"] = "0 0 0 0";
            oc_Newobject22["controlFillColor"] = "0 0 0 0";
            oc_Newobject22["backgroundColor"] = "255 255 255 255";
            oc_Newobject22["controlFontSize"] = "14";
            oc_Newobject22["visible"] = "1";
            oc_Newobject22["active"] = "1";
            oc_Newobject22["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["alphaValue"] = "1";
            oc_Newobject22["mouseOverAlphaValue"] = "1";
            oc_Newobject22["alphaFadeTime"] = "1000";
            oc_Newobject22["moveControl"] = "1";
            oc_Newobject22["lockControl"] = "0";
            oc_Newobject22["windowSettings"] = "1";
            oc_Newobject22["alpha"] = "1";
            oc_Newobject22["mouseOverAlpha"] = "1";
            oc_Newobject22["alphaFade"] = "1";
            oc_Newobject22["contextFontColor"] = "0";
            oc_Newobject22["contextBackColor"] = "0";
            oc_Newobject22["contextFillColor"] = "0";
            oc_Newobject22["contextFontSize"] = "0";
            oc_Newobject22["editable"] = "0";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiPanel", "");
            oc_Newobject21["docking"] = "Top";
            oc_Newobject21["margin"] = "0 0 0 0";
            oc_Newobject21["padding"] = "0 0 0 0";
            oc_Newobject21["anchorTop"] = "1";
            oc_Newobject21["anchorBottom"] = "1";
            oc_Newobject21["anchorLeft"] = "1";
            oc_Newobject21["anchorRight"] = "1";
            oc_Newobject21["position"] = "1 0";
            oc_Newobject21["extent"] = "640 350";
            oc_Newobject21["minExtent"] = "16 16";
            oc_Newobject21["maxExtent"] = "1920 1080";
            oc_Newobject21["horizSizing"] = "right";
            oc_Newobject21["vertSizing"] = "bottom";
            oc_Newobject21["profile"] = "GuiDefaultProfile";
            oc_Newobject21["controlFontColor"] = "0 0 0 0";
            oc_Newobject21["controlFillColor"] = "0 0 0 0";
            oc_Newobject21["backgroundColor"] = "255 255 255 255";
            oc_Newobject21["controlFontSize"] = "14";
            oc_Newobject21["visible"] = "1";
            oc_Newobject21["active"] = "1";
            oc_Newobject21["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["alphaValue"] = "1";
            oc_Newobject21["mouseOverAlphaValue"] = "1";
            oc_Newobject21["alphaFadeTime"] = "1000";
            oc_Newobject21["moveControl"] = "0";
            oc_Newobject21["lockControl"] = "0";
            oc_Newobject21["windowSettings"] = "1";
            oc_Newobject21["alpha"] = "1";
            oc_Newobject21["mouseOverAlpha"] = "1";
            oc_Newobject21["alphaFade"] = "1";
            oc_Newobject21["contextFontColor"] = "0";
            oc_Newobject21["contextBackColor"] = "0";
            oc_Newobject21["contextFillColor"] = "0";
            oc_Newobject21["contextFontSize"] = "0";
            oc_Newobject21["editable"] = "0";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";

            #region GuiConsoleTextCtrl (TextOverlayControl)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiConsoleTextCtrl", "TextOverlayControl");
            oc_Newobject1["profile"] = "GuiConsoleTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 5";
            oc_Newobject1["extent"] = "130 18";
            oc_Newobject1["minExtent"] = "4 4";
            oc_Newobject1["visible"] = "True";
            oc_Newobject1["setFirstResponder"] = "True";
            oc_Newobject1["modal"] = "True";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["expression"] = "10";

            #endregion

            #endregion

            oc_Newobject21["#newobject1"] = oc_Newobject1;

            oc_Newobject22["#newobject1"] = oc_Newobject21;

            oc_Newobject2["#Newobject1"] = oc_Newobject22;

            //oc_Newobject21;

            #endregion

            oc_Newobject2.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FrameOverlayGui ts, string simobjectid)
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
        public static bool operator !=(FrameOverlayGui ts, string simobjectid)
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
        public static implicit operator string(FrameOverlayGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator FrameOverlayGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (FrameOverlayGui) Omni.self.getSimObject(simobjectid, typeof (FrameOverlayGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(FrameOverlayGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FrameOverlayGui(int simobjectid)
            {
            return (FrameOverlayGui) Omni.self.getSimObject((uint) simobjectid, typeof (FrameOverlayGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(FrameOverlayGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FrameOverlayGui(uint simobjectid)
            {
            return (FrameOverlayGui) Omni.self.getSimObject(simobjectid, typeof (FrameOverlayGui));
            }

        #endregion
        }
    }