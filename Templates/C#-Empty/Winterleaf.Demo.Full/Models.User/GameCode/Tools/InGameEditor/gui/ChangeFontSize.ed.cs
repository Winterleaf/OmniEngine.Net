using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor.gui
    {
    [TypeConverter(typeof (ChangeFontSize))]
    public class ChangeFontSize : GuiControl
        {
        [ConsoleInteraction(true, "ChangeFontSize_initialize")]
        public static void initialize()
            {
            #region GuiControl (ChangeFontSize, IngameGuiGroup)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "ChangeFontSize, IngameGuiGroup",
                typeof (ChangeFontSize));
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["extent"] = "1024 768";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["maxExtent"] = "1920 1080";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["profile"] = "GuiDefaultProfile";
            oc_Newobject7["controlFontColor"] = "0 0 0 0";
            oc_Newobject7["controlFillColor"] = "0 0 0 0";
            oc_Newobject7["backgroundColor"] = "255 255 255 255";
            oc_Newobject7["controlFontSize"] = "14";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["moveControl"] = "0";
            oc_Newobject7["lockControl"] = "0";
            oc_Newobject7["windowSettings"] = "1";
            oc_Newobject7["alpha"] = "1";
            oc_Newobject7["mouseOverAlpha"] = "1";
            oc_Newobject7["alphaFade"] = "1";
            oc_Newobject7["contextFontColor"] = "0";
            oc_Newobject7["contextBackColor"] = "0";
            oc_Newobject7["contextFillColor"] = "0";
            oc_Newobject7["contextFontSize"] = "0";
            oc_Newobject7["alphaValue"] = "1";
            oc_Newobject7["mouseOverAlphaValue"] = "1";
            oc_Newobject7["alphaFadeTime"] = "1000";
            oc_Newobject7["editable"] = "0";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "1";

            #region GuiWindowCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject6["text"] = "Change font size";
            oc_Newobject6["resizeWidth"] = "1";
            oc_Newobject6["resizeHeight"] = "1";
            oc_Newobject6["canMove"] = "1";
            oc_Newobject6["canClose"] = "1";
            oc_Newobject6["canMinimize"] = "1";
            oc_Newobject6["canMaximize"] = "1";
            oc_Newobject6["canCollapse"] = "0";
            oc_Newobject6["closeCommand"] = "Canvas.popDialog(ChangeFontSize); ChangeFontSize.resetValue();";
            oc_Newobject6["edgeSnap"] = "1";
            oc_Newobject6["setTitle"] = "0";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["position"] = "292 295";
            oc_Newobject6["extent"] = "221 128";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["maxExtent"] = "1920 1080";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiWindowProfile";
            oc_Newobject6["controlFontColor"] = "0 0 0 0";
            oc_Newobject6["controlFillColor"] = "0 0 0 0";
            oc_Newobject6["backgroundColor"] = "255 255 255 255";
            oc_Newobject6["controlFontSize"] = "14";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["moveControl"] = "1";
            oc_Newobject6["lockControl"] = "0";
            oc_Newobject6["windowSettings"] = "1";
            oc_Newobject6["alpha"] = "1";
            oc_Newobject6["mouseOverAlpha"] = "1";
            oc_Newobject6["alphaFade"] = "1";
            oc_Newobject6["contextFontColor"] = "0";
            oc_Newobject6["contextBackColor"] = "0";
            oc_Newobject6["contextFillColor"] = "0";
            oc_Newobject6["contextFontSize"] = "0";
            oc_Newobject6["alphaValue"] = "1";
            oc_Newobject6["mouseOverAlphaValue"] = "1";
            oc_Newobject6["alphaFadeTime"] = "1000";
            oc_Newobject6["editable"] = "0";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #region GuiButtonCtrl (fontOK)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "fontOK");
            oc_Newobject1["text"] = "OK";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";
            oc_Newobject1["position"] = "21 79";
            oc_Newobject1["extent"] = "75 30";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["maxExtent"] = "1920 1080";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiButtonProfile";
            oc_Newobject1["controlFontColor"] = "0 0 0 0";
            oc_Newobject1["backgroundColor"] = "255 255 255 255";
            oc_Newobject1["controlFontSize"] = "14";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["command"] = "Canvas.popDialog(ChangeFontSize);";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["windowSettings"] = "1";
            oc_Newobject1["alpha"] = "1";
            oc_Newobject1["mouseOverAlpha"] = "1";
            oc_Newobject1["alphaFade"] = "1";
            oc_Newobject1["contextFontColor"] = "0";
            oc_Newobject1["contextBackColor"] = "0";
            oc_Newobject1["contextFontSize"] = "0";
            oc_Newobject1["alphaValue"] = "1";
            oc_Newobject1["mouseOverAlphaValue"] = "1";
            oc_Newobject1["alphaFadeTime"] = "1000";
            oc_Newobject1["editable"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl (fontCancel)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "fontCancel");
            oc_Newobject2["text"] = "Cancel";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["position"] = "119 79";
            oc_Newobject2["extent"] = "78 30";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["maxExtent"] = "1920 1080";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiButtonProfile";
            oc_Newobject2["controlFontColor"] = "0 0 0 0";
            oc_Newobject2["backgroundColor"] = "255 255 255 255";
            oc_Newobject2["controlFontSize"] = "14";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["command"] = "Canvas.popDialog(ChangeFontSize); ChangeFontSize.resetValue();";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["windowSettings"] = "1";
            oc_Newobject2["alpha"] = "1";
            oc_Newobject2["mouseOverAlpha"] = "1";
            oc_Newobject2["alphaFade"] = "1";
            oc_Newobject2["contextFontColor"] = "0";
            oc_Newobject2["contextBackColor"] = "0";
            oc_Newobject2["contextFontSize"] = "0";
            oc_Newobject2["alphaValue"] = "1";
            oc_Newobject2["mouseOverAlphaValue"] = "1";
            oc_Newobject2["alphaFadeTime"] = "1000";
            oc_Newobject2["editable"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiControl (fontSizeControl)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiControl", "fontSizeControl");
            oc_Newobject5["position"] = "24 30";
            oc_Newobject5["extent"] = "172 41";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["maxExtent"] = "1920 1080";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["profile"] = "GuiDefaultProfile";
            oc_Newobject5["controlFontColor"] = "0 0 0 0";
            oc_Newobject5["controlFillColor"] = "0 0 0 0";
            oc_Newobject5["backgroundColor"] = "255 255 255 255";
            oc_Newobject5["controlFontSize"] = "14";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["moveControl"] = "0";
            oc_Newobject5["lockControl"] = "0";
            oc_Newobject5["windowSettings"] = "1";
            oc_Newobject5["alpha"] = "1";
            oc_Newobject5["mouseOverAlpha"] = "1";
            oc_Newobject5["alphaFade"] = "1";
            oc_Newobject5["contextFontColor"] = "0";
            oc_Newobject5["contextBackColor"] = "0";
            oc_Newobject5["contextFillColor"] = "0";
            oc_Newobject5["contextFontSize"] = "0";
            oc_Newobject5["alphaValue"] = "1";
            oc_Newobject5["mouseOverAlphaValue"] = "1";
            oc_Newobject5["alphaFadeTime"] = "1000";
            oc_Newobject5["editable"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Font Size";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["margin"] = "0 0 0 0";
            oc_Newobject3["padding"] = "0 0 0 0";
            oc_Newobject3["anchorTop"] = "1";
            oc_Newobject3["anchorBottom"] = "0";
            oc_Newobject3["anchorLeft"] = "1";
            oc_Newobject3["anchorRight"] = "0";
            oc_Newobject3["position"] = "32 10";
            oc_Newobject3["extent"] = "50 23";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["maxExtent"] = "1920 1080";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiTextProfile";
            oc_Newobject3["controlFontColor"] = "0 0 0 0";
            oc_Newobject3["controlFillColor"] = "0 0 0 0";
            oc_Newobject3["backgroundColor"] = "255 255 255 255";
            oc_Newobject3["controlFontSize"] = "14";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["moveControl"] = "0";
            oc_Newobject3["lockControl"] = "0";
            oc_Newobject3["windowSettings"] = "1";
            oc_Newobject3["alpha"] = "1";
            oc_Newobject3["mouseOverAlpha"] = "1";
            oc_Newobject3["alphaFade"] = "1";
            oc_Newobject3["contextFontColor"] = "0";
            oc_Newobject3["contextBackColor"] = "0";
            oc_Newobject3["contextFillColor"] = "0";
            oc_Newobject3["contextFontSize"] = "0";
            oc_Newobject3["alphaValue"] = "1";
            oc_Newobject3["mouseOverAlphaValue"] = "1";
            oc_Newobject3["alphaFadeTime"] = "1000";
            oc_Newobject3["editable"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl (fontSizeText)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "fontSizeText");
            oc_Newobject4["historySize"] = "0";
            oc_Newobject4["tabComplete"] = "0";
            oc_Newobject4["sinkAllKeyEvents"] = "0";
            oc_Newobject4["password"] = "0";
            oc_Newobject4["passwordMask"] = "*";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["position"] = "90 12";
            oc_Newobject4["extent"] = "59 18";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["maxExtent"] = "1920 1080";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiTextEditProfile";
            oc_Newobject4["controlFontColor"] = "0 0 0 0";
            oc_Newobject4["controlFillColor"] = "0 0 0 0";
            oc_Newobject4["backgroundColor"] = "255 255 255 255";
            oc_Newobject4["controlFontSize"] = "14";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["command"] = "ChangeFontSize.setFontSize($ThisControl.getValue());";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["windowSettings"] = "1";
            oc_Newobject4["alpha"] = "1";
            oc_Newobject4["mouseOverAlpha"] = "1";
            oc_Newobject4["alphaFade"] = "1";
            oc_Newobject4["contextFontColor"] = "0";
            oc_Newobject4["contextBackColor"] = "0";
            oc_Newobject4["contextFillColor"] = "0";
            oc_Newobject4["contextFontSize"] = "0";
            oc_Newobject4["alphaValue"] = "1";
            oc_Newobject4["mouseOverAlphaValue"] = "1";
            oc_Newobject4["alphaFadeTime"] = "1000";
            oc_Newobject4["editable"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject7.Create();
            }

        [ConsoleInteraction]
        public void loadDialog(GuiControl ctrl)
            {
            GuiCanvas Canvas = "Canvas";
            GuiTextEditCtrl fontSizeText = "fontSizeText";

            this["ctrl"] = ctrl;
            this["oldFontSize"] = ctrl.getControlFontSize().AsString();
            Canvas.pushDialog(this);
            fontSizeText.text = this["oldFontSize"];
            }

        [ConsoleInteraction]
        public void resetValue()
            {
            this.setFontSize(this["oldFontSize"]);
            }

        [ConsoleInteraction]
        public void setFontSize(string value)
            {
            if (value == "")
                value = "1";
            ((GuiControl) this["ctrl"]).setControlFontSize(value.AsInt());
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ChangeFontSize ts, string simobjectid)
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
        public static bool operator !=(ChangeFontSize ts, string simobjectid)
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
        public static implicit operator string(ChangeFontSize ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ChangeFontSize(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ChangeFontSize) Omni.self.getSimObject(simobjectid, typeof (ChangeFontSize));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ChangeFontSize ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ChangeFontSize(int simobjectid)
            {
            return (ChangeFontSize) Omni.self.getSimObject((uint) simobjectid, typeof (ChangeFontSize));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ChangeFontSize ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ChangeFontSize(uint simobjectid)
            {
            return (ChangeFontSize) Omni.self.getSimObject(simobjectid, typeof (ChangeFontSize));
            }

        #endregion
        }
    }