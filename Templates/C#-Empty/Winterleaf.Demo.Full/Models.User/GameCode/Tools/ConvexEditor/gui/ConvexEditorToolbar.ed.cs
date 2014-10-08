using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ConvexEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<ConvexEditorToolbar>))]
    public class ConvexEditorToolbar : GuiControl
        {
        [ConsoleInteraction(true, "ConvexEditorToolbar_initialize")]
        public static void initialize()
            {
            #region GuiControl (convexEditorToolbar, EditorGuiGroup)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiControl", "convexEditorToolbar, EditorGuiGroup",
                typeof (ConvexEditorToolbar));
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "305 0";
            oc_Newobject7["Extent"] = new ObjectCreator.StringNoQuote("\"550\" SPC getWord(EditorGuiToolbar.extent, 1)");
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canMove"] = "0";
            oc_Newobject7["canClose"] = "0";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["resizeWidth"] = "0";
            oc_Newobject7["resizeHeight"] = "0";
            oc_Newobject7["EdgeSnap"] = "0";
            oc_Newobject7["text"] = "";

            #region GuiContainer ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiContainer", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "menubarProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "0 0";
            oc_Newobject6["Extent"] = "800 32";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "15 7";
            oc_Newobject1["extent"] = "86 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["text"] = "Sketch Tool";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["helpTag"] = "0";

            #endregion

            oc_Newobject6["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["position"] = "94 3";
            oc_Newobject2["Extent"] = "2 26";
            oc_Newobject2["MinExtent"] = "1 1";
            oc_Newobject2["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject6["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (ConvexEditorCreateBoxBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "ConvexEditorCreateBoxBtn");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "100 3";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "ConvexEditorGui.createConvexBox();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] =
                new ObjectCreator.StringNoQuote(
                    "\"Create ConvexShape Box\" NL \"Use Alt + Click-Drag instead of this for more control of starting placement.\"");
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/convexEditor/images/convex-editor-btn";
            oc_Newobject3["text"] = "";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (ConvexEditorSplitFaceBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "ConvexEditorSplitFaceBtn");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "134 3";
            oc_Newobject4["Extent"] = "29 27";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "ConvexEditorGui.splitSelectedFace();";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] =
                new ObjectCreator.StringNoQuote(
                    "\"Split selected face\" NL \"Use Ctrl + Rotate instead for more control.\"");
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/convexEditor/images/split-face-btn";
            oc_Newobject4["text"] = "";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (ConvexEditorDeleteFaceBtn)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "ConvexEditorDeleteFaceBtn");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "166 3";
            oc_Newobject5["Extent"] = "29 27";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ConvexEditorGui.handleDelete();";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = new ObjectCreator.StringNoQuote("\"Delete selected face\" NL \"(Delete)\"");
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/gui/images/menubar/delete-btn";
            oc_Newobject5["text"] = "";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "PushButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject7.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConvexEditorToolbar ts, string simobjectid)
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
        public static bool operator !=(ConvexEditorToolbar ts, string simobjectid)
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
        public static implicit operator string(ConvexEditorToolbar ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorToolbar(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ConvexEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorToolbar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConvexEditorToolbar ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConvexEditorToolbar(int simobjectid)
            {
            return (ConvexEditorToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (ConvexEditorToolbar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConvexEditorToolbar ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConvexEditorToolbar(uint simobjectid)
            {
            return (ConvexEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (ConvexEditorToolbar));
            }

        #endregion
        }
    }