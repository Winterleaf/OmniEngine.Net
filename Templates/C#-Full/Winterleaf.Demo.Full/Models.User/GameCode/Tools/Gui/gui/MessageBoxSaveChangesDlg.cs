using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<MessageBoxSaveChangesDlg>))]
    public class MessageBoxSaveChangesDlg : GuiControl
        {
        

        [ConsoleInteraction(true, "MessageBoxSaveChangesDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (MessageBoxSaveChangesDlg, EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "MessageBoxSaveChangesDlg, EditorGuiGroup",
                typeof (MessageBoxSaveChangesDlg));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiWindowCtrl (MBSaveChangesFrame)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiWindowCtrl", "MBSaveChangesFrame");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject7["HorizSizing"] = "center";
            oc_Newobject7["VertSizing"] = "center";
            oc_Newobject7["position"] = "362 274";
            oc_Newobject7["Extent"] = "340 164";
            oc_Newobject7["MinExtent"] = "48 92";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Save Changes";
            oc_Newobject7["maxLength"] = "255";
            oc_Newobject7["resizeWidth"] = "1";
            oc_Newobject7["resizeHeight"] = "1";
            oc_Newobject7["canMove"] = "1";
            oc_Newobject7["canClose"] = "0";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["minSize"] = "50 50";

            #region GuiIconButtonCtrl (mbSaveDlgSaveButton)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiIconButtonCtrl", "mbSaveDlgSaveButton",
                typeof (mbSaveDlgSaveButton));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "240 117";
            oc_Newobject1["Extent"] = "83 25";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["text"] = "Save";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["iconBitmap"] = "~/levelEditor/gui/images/iconAccept.png";
            oc_Newobject1["sizeIconToButton"] = "0";
            oc_Newobject1["textLocation"] = "Center";
            oc_Newobject1["textMargin"] = "4";
            oc_Newobject1["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject7["#Newobject1"] = oc_Newobject1;

            #region GuiIconButtonCtrl (mbSaveDlgCancelButton)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiIconButtonCtrl", "mbSaveDlgCancelButton",
                typeof (mbSaveDlgCancelButton));
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "158 117";
            oc_Newobject2["Extent"] = "83 25";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["text"] = "Cancel";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["iconBitmap"] = "~/levelEditor/gui/images/iconCancel.png";
            oc_Newobject2["sizeIconToButton"] = "0";
            oc_Newobject2["textLocation"] = "Center";
            oc_Newobject2["textMargin"] = "4";
            oc_Newobject2["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject7["#Newobject2"] = oc_Newobject2;

            #region GuiIconButtonCtrl (mbSaveDlgDontButton)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiIconButtonCtrl", "mbSaveDlgDontButton",
                typeof (mbSaveDlgDontButton));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "14 117";
            oc_Newobject3["Extent"] = "124 25";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "Don\'t Save";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["sizeIconToButton"] = "0";
            oc_Newobject3["textLocation"] = "Center";
            oc_Newobject3["textMargin"] = "4";
            oc_Newobject3["buttonMargin"] = "4 4";

            #endregion

            oc_Newobject7["#Newobject3"] = oc_Newobject3;

            #region GuiControl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiControl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "13 31";
            oc_Newobject6["Extent"] = "310 73";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Profile"] = "EditorTextHLBoldLeft";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "15 9";
            oc_Newobject4["Extent"] = "281 26";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["text"] = "Do you want to save changes to this document?";
            oc_Newobject4["maxLength"] = "1024";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "15 38";
            oc_Newobject5["Extent"] = "258 21";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["text"] = "If you don\'t save, your changes may be lost.";
            oc_Newobject5["maxLength"] = "1024";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
            }

        [ConsoleInteraction]
        public override void onWake()
            {
            GuiWindowCtrl MBSaveChangesFrame = "MBSaveChangesFrame";
            MBSaveChangesFrame.setWindowTitle(this["Data"]);
            }

        [ConsoleInteraction]
        // Deprecated when platform layers are all sufficient
        public static void checkSaveChangesOld(string data, string saveCallback, string dontSaveCallback)
            {
            MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
            GuiCanvas Canvas = "Canvas";

            // Sanity Check
            if (MessageBoxSaveChangesDlg.isAwake())
                {
                omni.Util._warn("Save Changes Dialog already Awake, NOT creating second instance.");
                return;
                }

            // Set Proper State
            MessageBoxSaveChangesDlg["SaveCallback"] = saveCallback;
            MessageBoxSaveChangesDlg["DontSaveCallback"] = dontSaveCallback;
            MessageBoxSaveChangesDlg["Data"] = data;

            // Show Dialog
            Canvas.pushDialog(MessageBoxSaveChangesDlg);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MessageBoxSaveChangesDlg ts, string simobjectid)
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
        public static bool operator !=(MessageBoxSaveChangesDlg ts, string simobjectid)
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
        public static implicit operator string(MessageBoxSaveChangesDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator MessageBoxSaveChangesDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (MessageBoxSaveChangesDlg) Omni.self.getSimObject(simobjectid, typeof (MessageBoxSaveChangesDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MessageBoxSaveChangesDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MessageBoxSaveChangesDlg(int simobjectid)
            {
            return
                (MessageBoxSaveChangesDlg) Omni.self.getSimObject((uint) simobjectid, typeof (MessageBoxSaveChangesDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MessageBoxSaveChangesDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MessageBoxSaveChangesDlg(uint simobjectid)
            {
            return (MessageBoxSaveChangesDlg) Omni.self.getSimObject(simobjectid, typeof (MessageBoxSaveChangesDlg));
            }

        #endregion

        [TypeConverter(typeof (TypeConverterGeneric<mbSaveDlgCancelButton>))]
        public class mbSaveDlgCancelButton : GuiIconButtonCtrl
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
                GuiCanvas Canvas = "Canvas";

                Canvas.popDialog(MessageBoxSaveChangesDlg);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(mbSaveDlgCancelButton ts, string simobjectid)
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
            public static bool operator !=(mbSaveDlgCancelButton ts, string simobjectid)
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
            public static implicit operator string(mbSaveDlgCancelButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgCancelButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (mbSaveDlgCancelButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgCancelButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(mbSaveDlgCancelButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgCancelButton(int simobjectid)
                {
                return
                    (mbSaveDlgCancelButton) Omni.self.getSimObject((uint) simobjectid, typeof (mbSaveDlgCancelButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(mbSaveDlgCancelButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator mbSaveDlgCancelButton(uint simobjectid)
                {
                return (mbSaveDlgCancelButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgCancelButton));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<mbSaveDlgDontButton>))]
        public class mbSaveDlgDontButton : GuiIconButtonCtrl
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
                GuiCanvas Canvas = "Canvas";

                if (MessageBoxSaveChangesDlg["DontSaveCallback"] != "")
                    Util.eval(MessageBoxSaveChangesDlg["DontSaveCallback"] + "(" + MessageBoxSaveChangesDlg["Data"] +
                               ");");
                Canvas.popDialog(MessageBoxSaveChangesDlg);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(mbSaveDlgDontButton ts, string simobjectid)
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
            public static bool operator !=(mbSaveDlgDontButton ts, string simobjectid)
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
            public static implicit operator string(mbSaveDlgDontButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgDontButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (mbSaveDlgDontButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgDontButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(mbSaveDlgDontButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgDontButton(int simobjectid)
                {
                return (mbSaveDlgDontButton) Omni.self.getSimObject((uint) simobjectid, typeof (mbSaveDlgDontButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(mbSaveDlgDontButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator mbSaveDlgDontButton(uint simobjectid)
                {
                return (mbSaveDlgDontButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgDontButton));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<mbSaveDlgSaveButton>))]
        public class mbSaveDlgSaveButton : GuiIconButtonCtrl
            {
            [ConsoleInteraction]
            public override void onClick(string SelectedidString)
                {
                MessageBoxSaveChangesDlg MessageBoxSaveChangesDlg = "MessageBoxSaveChangesDlg";
                GuiCanvas Canvas = "Canvas";

                if (MessageBoxSaveChangesDlg["SaveCallback"] != "")
                    Util.eval(MessageBoxSaveChangesDlg["SaveCallback"] + "(" + MessageBoxSaveChangesDlg["Data"] + ");");
                Canvas.popDialog(MessageBoxSaveChangesDlg);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(mbSaveDlgSaveButton ts, string simobjectid)
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
            public static bool operator !=(mbSaveDlgSaveButton ts, string simobjectid)
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
            public static implicit operator string(mbSaveDlgSaveButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgSaveButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (mbSaveDlgSaveButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgSaveButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(mbSaveDlgSaveButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator mbSaveDlgSaveButton(int simobjectid)
                {
                return (mbSaveDlgSaveButton) Omni.self.getSimObject((uint) simobjectid, typeof (mbSaveDlgSaveButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(mbSaveDlgSaveButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator mbSaveDlgSaveButton(uint simobjectid)
                {
                return (mbSaveDlgSaveButton) Omni.self.getSimObject(simobjectid, typeof (mbSaveDlgSaveButton));
                }

            #endregion
            }
        }
    }