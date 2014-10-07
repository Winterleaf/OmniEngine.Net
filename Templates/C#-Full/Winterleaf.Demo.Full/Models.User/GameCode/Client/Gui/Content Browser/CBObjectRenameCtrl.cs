using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
{
    [TypeConverter(typeof(TypeConverterGeneric<CBObjectRenameCtrl>))]
    public class CBObjectRenameCtrl : GuiControl
    {
        internal string associatedButton
        {
            get
            {
                return this["associatedButton"];
            }
            set
            {
                this["associatedButton"] = value;
            }
        }
        internal string OKCallback
        {
            get
            {
                return this["OKCallback"];
            }
            set
            {
                this["OKCallback"] = value;
            }
        }
        internal string cancelCallback
        {
            get
            {
                return this["cancelCallback"];
            }
            set
            {
                this["cancelCallback"] = value;
            }
        }
        [ConsoleInteraction(true, "CBObjectRenameCtrl_initialize")]
        public static void initialize()
        {
            #region GuiControl (CBObjectRenameCtrl)        oc_Newobject6
            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "CBObjectRenameCtrl", typeof(CBObjectRenameCtrl));
            oc_Newobject6["position"] = "0 0";
            oc_Newobject6["extent"] = "1024 768";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["profile"] = "GuiDefaultProfile";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "1";

            #region GuiWindowCtrl ()        oc_Newobject5
            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject5["text"] = "Rename object";
            oc_Newobject5["resizeWidth"] = "1";
            oc_Newobject5["resizeHeight"] = "1";
            oc_Newobject5["canMove"] = "1";
            oc_Newobject5["canClose"] = "1";
            oc_Newobject5["canMinimize"] = "1";
            oc_Newobject5["canMaximize"] = "1";
            oc_Newobject5["canCollapse"] = "0";
            oc_Newobject5["closeCommand"] = "Canvas.popDialog($ThisControl.getParent());";
            oc_Newobject5["edgeSnap"] = "1";
            oc_Newobject5["setTitle"] = "0";
            oc_Newobject5["ShowTitle"] = "1";
            oc_Newobject5["AllowPopWindow"] = "0";
            oc_Newobject5["isInPopup"] = "0";
            oc_Newobject5["LastWindowPosition"] = "0 0";
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["position"] = "381 263";
            oc_Newobject5["extent"] = "216 113";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["horizSizing"] = "center";
            oc_Newobject5["vertSizing"] = "center";
            oc_Newobject5["profile"] = "GuiWindowProfile";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiTextEditCtrl ()        oc_Newobject1
            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject1["internalName"] = "textEdit";
            oc_Newobject1["historySize"] = "1";
            oc_Newobject1["tabComplete"] = "0";
            oc_Newobject1["sinkAllKeyEvents"] = "0";
            oc_Newobject1["password"] = "0";
            oc_Newobject1["passwordMask"] = "*";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "84 39";
            oc_Newobject1["extent"] = "93 18";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["profile"] = "GuiTextEditProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl (CBOkButton)        oc_Newobject2
            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "CBOkButton");
            oc_Newobject2["text"] = "OK";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["position"] = "15 76";
            oc_Newobject2["extent"] = "73 20";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["profile"] = "GuiButtonProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["command"] = "CBObjectRenameCtrl.onOKClicked();";
            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3
            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["text"] = "Cancel";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["position"] = "114 76";
            oc_Newobject3["extent"] = "73 20";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["profile"] = "GuiButtonProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["command"] = "CBObjectRenameCtrl.onCancelClicked();";
            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiTextCtrl ()        oc_Newobject4
            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["text"] = "Name";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["margin"] = "0 0 0 0";
            oc_Newobject4["padding"] = "0 0 0 0";
            oc_Newobject4["anchorTop"] = "1";
            oc_Newobject4["anchorBottom"] = "0";
            oc_Newobject4["anchorLeft"] = "1";
            oc_Newobject4["anchorRight"] = "0";
            oc_Newobject4["position"] = "46 42";
            oc_Newobject4["extent"] = "29 13";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["profile"] = "GuiTextProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["tooltipProfile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion
            oc_Newobject6.Create();
        }

        [ConsoleInteraction]
        public void createRenameCtrl(string button, string textValue, string OKCallback, string cancelCallback)
        {
            associatedButton = button;
            ((GuiTextEditCtrl)FOT("textEdit")).text = textValue;
            this.OKCallback = OKCallback;
            this.cancelCallback = cancelCallback;  
            ((canvas)"Canvas").pushDialog(this);
        }

        [ConsoleInteraction]
        public void onOKClicked( )
        {
            GuiTextEditCtrl textEdit = FOT("textEdit");

            if( OKCallback != "" )
                Util.eval(OKCallback + "(" + associatedButton + ", " + textEdit.getText() + ");");
            ((canvas)"Canvas").popDialog(this);
        }

        [ConsoleInteraction]
        public void onCancelClicked( )
        {
            GuiTextEditCtrl textEdit = FOT("textEdit");

            if( cancelCallback != "" )
                Util.eval(cancelCallback + "(" + associatedButton + ", " + textEdit.getText() + ");");
            ((canvas)"Canvas").popDialog(this);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CBObjectRenameCtrl ts, string simobjectid)
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
            return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(CBObjectRenameCtrl ts, string simobjectid)
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
        public static implicit operator string(CBObjectRenameCtrl ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator CBObjectRenameCtrl(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (CBObjectRenameCtrl)Omni.self.getSimObject(simobjectid, typeof(CBObjectRenameCtrl));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(CBObjectRenameCtrl ts)
        {
            return (int)ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CBObjectRenameCtrl(int simobjectid)
        {
            return
                (CBObjectRenameCtrl)Omni.self.getSimObject((uint)simobjectid, typeof(CBObjectRenameCtrl));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(CBObjectRenameCtrl ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CBObjectRenameCtrl(uint simobjectid)
        {
            return (CBObjectRenameCtrl)Omni.self.getSimObject(simobjectid, typeof(CBObjectRenameCtrl));
        }

        #endregion
    }
}
