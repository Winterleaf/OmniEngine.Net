using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<playGui>))]
    public class loadingGui : GuiChunkedBitmapCtrl
        {
        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public override void onAdd()
            {
            this["qLineCount"] = "0";
            }

        public override void onWake()
            {
            // Play sound...
            //CloseMessagePopup();
            }

        public override void onSleep()
            {
            // Clear the load info:
            if (this["qLineCount"] != "")
                for (int line = 0; line < this["qLineCount"].AsInt(); line++)
                    this["qLine[" + line + "]"] = "";

            this["qLineCount"] = "0";

            ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("0");
            ((GuiTextCtrl) "LoadingProgressTxt").setValue("WAITING FOR SERVER");

            // Stop sound...
            }

        public static void initialize()
            {
            #region GuiChunkedBitmapCtrl (LoadingGui)        oc_Newobject5

            SingletonCreator oc_Newobject5 = new SingletonCreator("GuiChunkedBitmapCtrl", "LoadingGui",
                typeof (loadingGui));
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "GuiContentProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "800 600";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "art/gui/background_g";
            oc_Newobject5["useVariable"] = "0";
            oc_Newobject5["tile"] = "0";

            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "GuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "center";
            oc_Newobject4["VertSizing"] = "center";
            oc_Newobject4["Position"] = "263 163";
            oc_Newobject4["Extent"] = "497 442";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";

            #region GuiBitmapCtrl (LoadingLogo)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapCtrl", "LoadingLogo");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "GuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "center";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "28 -55";
            oc_Newobject1["Extent"] = "443 418";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "art/gui/omni.png";
            oc_Newobject1["wrap"] = "0";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiProgressBitmapCtrl (LoadingProgress)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiProgressBitmapCtrl", "LoadingProgress");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "GuiProgressBitmapProfile";
            oc_Newobject2["HorizSizing"] = "center";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "12 384";
            oc_Newobject2["Extent"] = "464 24";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["maxLength"] = "1024";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl (LoadingProgressTxt)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiTextCtrl", "LoadingProgressTxt");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "GuiProgressTextProfile";
            oc_Newobject3["HorizSizing"] = "center";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "36 407";
            oc_Newobject3["Extent"] = "440 20";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["text"] = "WAITING FOR SERVER";
            oc_Newobject3["maxLength"] = "255";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject5.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(loadingGui ts, string simobjectid)
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
        public static bool operator !=(loadingGui ts, string simobjectid)
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
        public static implicit operator string(loadingGui ts)
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
        public static implicit operator loadingGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (loadingGui) Omni.self.getSimObject(simobjectid, typeof (loadingGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(loadingGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator loadingGui(int simobjectid)
            {
            return (loadingGui) Omni.self.getSimObject((uint) simobjectid, typeof (loadingGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(loadingGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator loadingGui(uint simobjectid)
            {
            return (loadingGui) Omni.self.getSimObject(simobjectid, typeof (loadingGui));
            }

        #endregion
        }
    }