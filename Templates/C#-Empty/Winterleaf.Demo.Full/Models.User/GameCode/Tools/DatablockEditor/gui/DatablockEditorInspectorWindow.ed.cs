using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorInspectorWindow>))]
    public class DatablockEditorInspectorWindow : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction(true, "DatablockEditorInspectorWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["Extent"] = "1024 768";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #region GuiWindowCollapseCtrl (DatablockEditorInspectorWindow)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiWindowCollapseCtrl", "DatablockEditorInspectorWindow",
                typeof (DatablockEditorInspectorWindow));
            oc_Newobject8["internalName"] = "DatablockEditorInspectorWindow";
            oc_Newobject8["AllowPopWindow"] = "1";
            oc_Newobject8["resizeWidth"] = "1";
            oc_Newobject8["resizeHeight"] = "1";
            oc_Newobject8["canMove"] = "1";
            oc_Newobject8["canClose"] = "0";
            oc_Newobject8["canMinimize"] = "0";
            oc_Newobject8["canMaximize"] = "0";
            oc_Newobject8["minSize"] = "50 50";
            oc_Newobject8["closeCommand"] = "DatablockEditorInspectorWindow.setVisible(false);";
            oc_Newobject8["EdgeSnap"] = "1";
            oc_Newobject8["text"] = "Datablock";
            oc_Newobject8["Margin"] = "8 8 8 8";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject8["HorizSizing"] = "windowRelative";
            oc_Newobject8["VertSizing"] = "windowRelative";
            oc_Newobject8["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209          SPC getWord(EditorGuiToolbar.extent, 1) + getWord(DatablockEditorTreeWindow.extent, 1) - 2");
            oc_Newobject8["Extent"] = "210 373";
            oc_Newobject8["MinExtent"] = "210 140";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiContainer ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiContainer", "");
            oc_Newobject3["Docking"] = "Client";
            oc_Newobject3["Margin"] = "22 41 3 3";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["position"] = "4 41";
            oc_Newobject3["Extent"] = "202 287";
            oc_Newobject3["MinExtent"] = "64 64";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject2["lockVertScroll"] = "0";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";
            oc_Newobject2["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject2["Docking"] = "Client";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "GuiEditorScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["Extent"] = "202 287";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #region GuiInspector (DatablockEditorInspector)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiInspector", "DatablockEditorInspector",
                typeof (CodeBehind.DatablockEditor.DatablockEditorInspector));
            oc_Newobject1["dividerMargin"] = "5";
            oc_Newobject1["StackingType"] = "Vertical";
            oc_Newobject1["HorizStacking"] = "Left to Right";
            oc_Newobject1["VertStacking"] = "Top to Bottom";
            oc_Newobject1["Padding"] = "1";
            oc_Newobject1["ChangeChildSizeToFit"] = "1";
            oc_Newobject1["ChangeChildPosition"] = "1";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "GuiInspectorProfile";
            oc_Newobject1["HorizSizing"] = "width";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "1 1";
            oc_Newobject1["Extent"] = "190 8";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";
            //oc_Newobject1["superClass"] = "EditorInspectorBase";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject8["#Newobject3"] = oc_Newobject3;

            #region GuiMLTextCtrl (DatablockFieldInfoControl)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiMLTextCtrl", "DatablockFieldInfoControl");
            oc_Newobject4["lineSpacing"] = "2";
            oc_Newobject4["allowColorChars"] = "0";
            oc_Newobject4["maxChars"] = "-1";
            oc_Newobject4["useURLMouseCursor"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "GuiInspectorFieldInfoMLTextProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["position"] = "1 328";
            oc_Newobject4["Extent"] = "205 14";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject4"] = oc_Newobject4;

            #region GuiTextEditCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject5["historySize"] = "0";
            oc_Newobject5["password"] = "0";
            oc_Newobject5["tabComplete"] = "0";
            oc_Newobject5["sinkAllKeyEvents"] = "0";
            oc_Newobject5["passwordMask"] = "*";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "GuiTextEditProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "4 23";
            oc_Newobject5["Extent"] = "159 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["internalName"] = "DatablockFile";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["active"] = "0";

            #endregion

            oc_Newobject8["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject6["bitmap"] = "tools/gui/images/save-icon";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["HorizSizing"] = "left";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "167 23";
            oc_Newobject6["Extent"] = "17 17";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "DatablockEditorPlugin.save();";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Save Datablock (ALT S)";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["bitmap"] = "tools/gui/images/save-as";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "PushButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "left";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "187 23";
            oc_Newobject7["Extent"] = "17 17";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "DatablockEditorPlugin.showSaveNewFileDialog();";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Save Datablock to a New File";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "saveAsButton";

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DatablockEditorInspectorWindow ts, string simobjectid)
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
        public static bool operator !=(DatablockEditorInspectorWindow ts, string simobjectid)
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
        public static implicit operator string(DatablockEditorInspectorWindow ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DatablockEditorInspectorWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return
                (DatablockEditorInspectorWindow)
                    Omni.self.getSimObject(simobjectid, typeof (DatablockEditorInspectorWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DatablockEditorInspectorWindow ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DatablockEditorInspectorWindow(int simobjectid)
            {
            return
                (DatablockEditorInspectorWindow)
                    Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorInspectorWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DatablockEditorInspectorWindow ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DatablockEditorInspectorWindow(uint simobjectid)
            {
            return
                (DatablockEditorInspectorWindow)
                    Omni.self.getSimObject(simobjectid, typeof (DatablockEditorInspectorWindow));
            }

        #endregion
        }
    }