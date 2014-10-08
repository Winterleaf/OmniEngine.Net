using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Base.Utils;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorTreeWindow>))]
    public class DatablockEditorTreeWindow : GuiWindowCollapseCtrl
        {
        [ConsoleInteraction(true, "DatablockEditorTreeWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiControl", "");
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "0 0";
            oc_Newobject13["Extent"] = "1024 768";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #region GuiWindowCollapseCtrl (DatablockEditorTreeWindow)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiWindowCollapseCtrl", "DatablockEditorTreeWindow",
                typeof (DatablockEditorTreeWindow));
            oc_Newobject12["internalName"] = "DatablockEditorTreeWindow";
            oc_Newobject12["AllowPopWindow"] = "1";
            oc_Newobject12["resizeWidth"] = "1";
            oc_Newobject12["resizeHeight"] = "1";
            oc_Newobject12["canMove"] = "1";
            oc_Newobject12["canClose"] = "0";
            oc_Newobject12["canMinimize"] = "0";
            oc_Newobject12["canMaximize"] = "0";
            oc_Newobject12["minSize"] = "50 50";
            oc_Newobject12["closeCommand"] = "DatablockInspectorTreeWindow.setVisible(false);";
            oc_Newobject12["EdgeSnap"] = "1";
            oc_Newobject12["text"] = "Datablock Library";
            oc_Newobject12["Margin"] = "8 8 8 8";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject12["HorizSizing"] = "windowRelative";
            oc_Newobject12["VertSizing"] = "windowRelative";
            oc_Newobject12["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord($pref::Video::mode, 0) - 209         SPC getWord(EditorGuiToolbar.extent, 1) - 1");
            oc_Newobject12["Extent"] = "210 324";
            oc_Newobject12["MinExtent"] = "210 140";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["canSaveDynamicFields"] = "0";

            #region GuiTabBookCtrl (DatablockEditorTreeTabBook)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTabBookCtrl", "DatablockEditorTreeTabBook",
                typeof (CodeBehind.DatablockEditor.DatablockEditorTreeTabBook));
            oc_Newobject9["TabPosition"] = "Top";
            oc_Newobject9["TabMargin"] = "0";
            oc_Newobject9["MinTabWidth"] = "64";
            oc_Newobject9["Docking"] = "Client";
            oc_Newobject9["Margin"] = "3 2 3 3";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "height";
            oc_Newobject9["position"] = "4 25";
            oc_Newobject9["Extent"] = "202 294";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["internalName"] = "DatablockEditorTree";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #region GuiTabPageCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject5["text"] = "Existing";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["position"] = "0 19";
            oc_Newobject5["Extent"] = "202 276";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "0";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #region GuiTextEditCtrl ( DatablockEditorTreeFilter )        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextEditCtrl", "DatablockEditorTreeFilter",
                typeof (treeViewFilterCtrls.GuiTreeViewFilterText));
            oc_Newobject1["position"] = "2 4";
            oc_Newobject1["extent"] = "180 18";
            oc_Newobject1["profile"] = "GuiTextEditProfile";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "bottom";
            //oc_Newobject1["class"] = "GuiTreeViewFilterText";
            oc_Newobject1["treeView"] = new ObjectCreator.StringNoQuote("DatablockEditorTree");

            #endregion

            oc_Newobject5["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "",
                typeof (treeViewFilterCtrls.GuiTreeViewFilterClearButton));
            oc_Newobject2["bitmap"] = "tools/gui/images/clear-icon";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["position"] = "185 5";
            oc_Newobject2["Extent"] = "17 17";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            //oc_Newobject2["class"] = "GuiTreeViewFilterClearButton";
            oc_Newobject2["textCtrl"] = new ObjectCreator.StringNoQuote("DatablockEditorTreeFilter");

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiScrollCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject4["willFirstRespond"] = "1";
            oc_Newobject4["hScrollBar"] = "dynamic";
            oc_Newobject4["vScrollBar"] = "dynamic";
            oc_Newobject4["lockHorizScroll"] = "0";
            oc_Newobject4["lockVertScroll"] = "0";
            oc_Newobject4["constantThumbHeight"] = "0";
            oc_Newobject4["childMargin"] = "0 0";
            oc_Newobject4["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "height";
            oc_Newobject4["position"] = "0 25";
            oc_Newobject4["Extent"] = "202 251";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (DatablockEditorTree)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTreeViewCtrl", "DatablockEditorTree",
                typeof (CodeBehind.DatablockEditor.DatablockEditorTree));
            oc_Newobject3["tabSize"] = "16";
            oc_Newobject3["textOffset"] = "2";
            oc_Newobject3["fullRowSelect"] = "0";
            oc_Newobject3["itemHeight"] = "21";
            oc_Newobject3["destroyTreeOnSleep"] = "0";
            oc_Newobject3["MouseDragging"] = "0";
            oc_Newobject3["MultipleSelections"] = "1";
            oc_Newobject3["DeleteObjectAllowed"] = "1";
            oc_Newobject3["DragToItemAllowed"] = "0";
            oc_Newobject3["ClearAllOnSingleSelection"] = "1";
            oc_Newobject3["showRoot"] = "1";
            oc_Newobject3["internalNamesOnly"] = "0";
            oc_Newobject3["objectNamesOnly"] = "0";
            oc_Newobject3["compareToObjectID"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "1 1";
            oc_Newobject3["Extent"] = "198 21";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiTabPageCtrl (DatablockEditorCreator)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTabPageCtrl", "DatablockEditorCreator");
            oc_Newobject8["text"] = "New";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiEditorTabPage";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "height";
            oc_Newobject8["position"] = "0 19";
            oc_Newobject8["Extent"] = "202 276";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["internalName"] = "DatablockEditorCreator";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject7["willFirstRespond"] = "1";
            oc_Newobject7["hScrollBar"] = "dynamic";
            oc_Newobject7["vScrollBar"] = "dynamic";
            oc_Newobject7["lockHorizScroll"] = "0";
            oc_Newobject7["lockVertScroll"] = "0";
            oc_Newobject7["constantThumbHeight"] = "0";
            oc_Newobject7["childMargin"] = "0 0";
            oc_Newobject7["mouseWheelScrollSpeed"] = "-1";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject7["HorizSizing"] = "width";
            oc_Newobject7["VertSizing"] = "height";
            oc_Newobject7["position"] = "0 0";
            oc_Newobject7["Extent"] = "202 276";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #region GuiTreeViewCtrl (DatablockEditorTypeTree)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTreeViewCtrl", "DatablockEditorTypeTree");
            oc_Newobject6["tabSize"] = "16";
            oc_Newobject6["textOffset"] = "2";
            oc_Newobject6["fullRowSelect"] = "0";
            oc_Newobject6["itemHeight"] = "21";
            oc_Newobject6["destroyTreeOnSleep"] = "0";
            oc_Newobject6["MouseDragging"] = "0";
            oc_Newobject6["MultipleSelections"] = "0";
            oc_Newobject6["DeleteObjectAllowed"] = "0";
            oc_Newobject6["DragToItemAllowed"] = "0";
            oc_Newobject6["ClearAllOnSingleSelection"] = "1";
            oc_Newobject6["showRoot"] = "1";
            oc_Newobject6["internalNamesOnly"] = "0";
            oc_Newobject6["objectNamesOnly"] = "0";
            oc_Newobject6["compareToObjectID"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "1 1";
            oc_Newobject6["Extent"] = "196 260";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["altCommand"] = "DatablockEditorPlugin.createDatablock();";

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject10["bitmap"] = "tools/gui/images/delete";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "PushButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["HorizSizing"] = "left";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "190 26";
            oc_Newobject10["Extent"] = "16 16";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["Command"] = "DatablockEditorPlugin.deleteDatablock();";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["ToolTip"] = "Delete Datablock";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["internalName"] = "DeleteSelection";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject11["bitmap"] = "tools/gui/images/new";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject11["HorizSizing"] = "left";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "192 25";
            oc_Newobject11["Extent"] = "17 17";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "0";
            oc_Newobject11["Command"] = "DatablockEditorPlugin.createDatablock();";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["tooltip"] = "Create New Datablock";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["internalName"] = "CreateSelection";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject13.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DatablockEditorTreeWindow ts, string simobjectid)
            {
            return ReferenceEquals(ts, null)
                ? ReferenceEquals(simobjectid, null)
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
        public static bool operator !=(DatablockEditorTreeWindow ts, string simobjectid)
            {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(DatablockEditorTreeWindow ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator DatablockEditorTreeWindow(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (DatablockEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTreeWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(DatablockEditorTreeWindow ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DatablockEditorTreeWindow(int simobjectid)
            {
            return
                (DatablockEditorTreeWindow)
                    Omni.self.getSimObject((uint) simobjectid, typeof (DatablockEditorTreeWindow));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(DatablockEditorTreeWindow ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DatablockEditorTreeWindow(uint simobjectid)
            {
            return (DatablockEditorTreeWindow) Omni.self.getSimObject(simobjectid, typeof (DatablockEditorTreeWindow));
            }

        #endregion
        }
    }