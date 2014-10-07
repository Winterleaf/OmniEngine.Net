using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<ScriptEditorDlg>))]
    public class ScriptEditorDlg : GuiControl
        {
        

        [ConsoleInteraction(true, "ScriptEditorDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (ScriptEditorDlg,EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "ScriptEditorDlg,EditorGuiGroup",
                typeof (ScriptEditorDlg));
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "0 0";
            oc_Newobject8["Extent"] = "1024 768";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiWindowCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject7["resizeWidth"] = "0";
            oc_Newobject7["resizeHeight"] = "0";
            oc_Newobject7["canMove"] = "1";
            oc_Newobject7["canClose"] = "1";
            oc_Newobject7["canMinimize"] = "1";
            oc_Newobject7["canMaximize"] = "1";
            oc_Newobject7["minSize"] = "50 50";
            oc_Newobject7["closeCommand"] = "ScriptEditorDlg.close();";
            oc_Newobject7["EdgeSnap"] = "1";
            oc_Newobject7["text"] = "Text Pad";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject7["HorizSizing"] = "center";
            oc_Newobject7["VertSizing"] = "center";
            oc_Newobject7["position"] = "176 120";
            oc_Newobject7["Extent"] = "656 464";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ScriptEditorDlg.close();";
            oc_Newobject7["Accelerator"] = "escape";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "");
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["position"] = "8 24";
            oc_Newobject4["Extent"] = "640 392";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiControl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "");
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["position"] = "8 7";
            oc_Newobject3["Extent"] = "627 380";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["willFirstRespond"] = "0";
            oc_Newobject2["hScrollBar"] = "dynamic";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "0";
            oc_Newobject2["lockVertScroll"] = "0";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "1 1";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["Extent"] = "627 380";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiMLTextEditCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiMLTextEditCtrl", "");
            oc_Newobject1["lineSpacing"] = "2";
            oc_Newobject1["allowColorChars"] = "0";
            oc_Newobject1["maxChars"] = "-1";
            oc_Newobject1["useURLMouseCursor"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiTextPadProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "height";
            oc_Newobject1["position"] = "2 2";
            oc_Newobject1["Extent"] = "623 380";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["internalName"] = "TextPad";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiIconButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject5["buttonMargin"] = "4 4";
            oc_Newobject5["iconBitmap"] = "tools/gui/images/iconCancel.png";
            oc_Newobject5["iconLocation"] = "Left";
            oc_Newobject5["sizeIconToButton"] = "0";
            oc_Newobject5["makeIconSquare"] = "0";
            oc_Newobject5["textLocation"] = "Center";
            oc_Newobject5["textMargin"] = "4";
            oc_Newobject5["autoSize"] = "0";
            oc_Newobject5["text"] = "Cancel";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "top";
            oc_Newobject5["position"] = "460 424";
            oc_Newobject5["Extent"] = "80 25";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ScriptEditorDlg.close();";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject5"] = oc_Newobject5;

            #region GuiIconButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject6["buttonMargin"] = "4 4";
            oc_Newobject6["iconBitmap"] = "tools/gui/images/iconAccept.png";
            oc_Newobject6["iconLocation"] = "Left";
            oc_Newobject6["sizeIconToButton"] = "0";
            oc_Newobject6["makeIconSquare"] = "0";
            oc_Newobject6["textLocation"] = "Center";
            oc_Newobject6["textMargin"] = "4";
            oc_Newobject6["autoSize"] = "0";
            oc_Newobject6["text"] = "Ok";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "left";
            oc_Newobject6["VertSizing"] = "top";
            oc_Newobject6["position"] = "560 424";
            oc_Newobject6["Extent"] = "80 25";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "_TextPadOnOk();";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
            }

        [ConsoleInteraction]
        public static void TextPad(string text, string callback, GuiCanvas root)
            {
            ScriptEditorDlg ScriptEditorDlg = "ScriptEditorDlg";
            GuiMLTextEditCtrl textpad = ScriptEditorDlg.FOT("TextPad");
            GuiCanvas Canvas = "Canvas";

            textpad.setText(text);
            ScriptEditorDlg["callback"] = callback;

            if (!root.isObject())
                root = Canvas;

            root.pushDialog(ScriptEditorDlg);
            }

        [ConsoleInteraction]
        public static void _TextPadOnOk()
            {
            ScriptEditorDlg ScriptEditorDlg = "ScriptEditorDlg";
            GuiMLTextEditCtrl textpad = ScriptEditorDlg.FOT("TextPad");

            if (ScriptEditorDlg["callback"] != "")
                {
                string text = textpad.getText();
                string command = ScriptEditorDlg["callback"] + "( text );";
                omni.Util.eval(command);
                }
            ScriptEditorDlg["callback"] = "";
            ((GuiCanvas) ScriptEditorDlg.getRoot()).popDialog(ScriptEditorDlg);
            }

        [ConsoleInteraction]
        public void close()
            {
            ((GuiCanvas) this.getRoot()).popDialog(this);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ScriptEditorDlg ts, string simobjectid)
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
        public static bool operator !=(ScriptEditorDlg ts, string simobjectid)
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
        public static implicit operator string(ScriptEditorDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ScriptEditorDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ScriptEditorDlg) Omni.self.getSimObject(simobjectid, typeof (ScriptEditorDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ScriptEditorDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ScriptEditorDlg(int simobjectid)
            {
            return (ScriptEditorDlg) Omni.self.getSimObject((uint) simobjectid, typeof (ScriptEditorDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ScriptEditorDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ScriptEditorDlg(uint simobjectid)
            {
            return (ScriptEditorDlg) Omni.self.getSimObject(simobjectid, typeof (ScriptEditorDlg));
            }

        #endregion
        }
    }