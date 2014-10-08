using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<RiverEditorToolbar>))]
    public class RiverEditorToolbar : GuiControl
        {
        [ConsoleInteraction(true, "RiverEditorToolbar_initialize")]
        public static void initialize()
            {
            #region GuiControl (RiverEditorToolbar, EditorGuiGroup)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControl", "RiverEditorToolbar, EditorGuiGroup",
                typeof (RiverEditorToolbar));
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["internalName"] = "MeshRoadEditorToolbar";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "306 0";
            oc_Newobject14["Extent"] = "800 32";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "0";
            oc_Newobject14["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "6 6";
            oc_Newobject1["extent"] = "100 20";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["text"] = "River Settings";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["helpTag"] = "0";

            #endregion

            oc_Newobject14["#Newobject1"] = oc_Newobject1;

            #region GuiDynamicCtrlArrayControl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiDynamicCtrlArrayControl", "");
            oc_Newobject5["Position"] = "83 3";
            oc_Newobject5["extent"] = "111 32";
            oc_Newobject5["colCount"] = "31";
            oc_Newobject5["colSize"] = "29";
            oc_Newobject5["rowCount"] = "1";
            oc_Newobject5["RowSize"] = "27";
            oc_Newobject5["rowSpacing"] = "2";
            oc_Newobject5["colspacing"] = "4";

            #region GuiBitmapButtonCtrl (RiverEditorShowSplineBtn)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "RiverEditorShowSplineBtn");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "167 3";
            oc_Newobject2["Extent"] = "29 27";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Variable"] = "$River::showSpline";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["toolTip"] = "Show Spline";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/road-river/menubar/show-spline";
            oc_Newobject2["groupNum"] = "7";
            oc_Newobject2["buttonType"] = "ToggleButton";
            oc_Newobject2["useMouseEvents"] = "0";
            oc_Newobject2["useInactiveState"] = "0";

            #endregion

            oc_Newobject5["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (RiverEditorWireframeBtn)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "RiverEditorWireframeBtn");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "253 3";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Variable"] = "$River::showWireframe";
            oc_Newobject3["Command"] = "$River::showWireframe = $ThisControl.getValue();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["toolTip"] = "Show Wireframe";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/road-river/menubar/show-wireframe";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "ToggleButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["useInactiveState"] = "0";

            #endregion

            oc_Newobject5["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl (RiverEditorShowRoadBtn)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "RiverEditorShowRoadBtn");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "GuiDefalutProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "89 3";
            oc_Newobject4["Extent"] = "29 27";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Variable"] = "$River::showRiver";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["toolTip"] = "Show River Texture";
            oc_Newobject4["bitmap"] = "tools/worldEditor/images/road-river/menubar/show-texture";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "ToggleButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["useInactiveState"] = "0";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject14["#Newobject5"] = oc_Newobject5;

            #region GuiControl (RiverDefaultWidthTextEditContainer)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "RiverDefaultWidthTextEditContainer");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "197 5";
            oc_Newobject9["Extent"] = "120 50";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "0 6";
            oc_Newobject6["Extent"] = "68 10";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["text"] = "Default Width";
            oc_Newobject6["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "textEdit";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "67 2";
            oc_Newobject7["Extent"] = "42 16";
            oc_Newobject7["MinExtent"] = "8 16";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "RiverEditorGui.DefaultWidth = $ThisControl.getValue();";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "10";
            oc_Newobject7["maxLength"] = "3";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "101 2";
            oc_Newobject8["Extent"] = "18 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "Canvas.pushDialog(RiverDefaultWidthSliderCtrlContainer);";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Changes Default River Width";
            oc_Newobject8["hovertime"] = "750";
            oc_Newobject8["groupNum"] = "-1";
            oc_Newobject8["buttonType"] = "PushButton";
            oc_Newobject8["useMouseEvents"] = "0";
            oc_Newobject8["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject14["#Newobject9"] = oc_Newobject9;

            #region GuiControl (RiverDefaultDepthTextEditContainer)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiControl", "RiverDefaultDepthTextEditContainer");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["position"] = "327 5";
            oc_Newobject13["Extent"] = "120 50";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "0 6";
            oc_Newobject10["Extent"] = "68 10";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["text"] = "Default Depth";
            oc_Newobject10["maxLength"] = "1024";

            #endregion

            oc_Newobject13["#Newobject10"] = oc_Newobject10;

            #region GuiTextEditCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["internalName"] = "textEdit";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["position"] = "67 2";
            oc_Newobject11["Extent"] = "42 16";
            oc_Newobject11["MinExtent"] = "8 16";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "RiverEditorGui.DefaultDepth = $ThisControl.getValue();";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["text"] = "10";
            oc_Newobject11["maxLength"] = "3";
            oc_Newobject11["historySize"] = "0";
            oc_Newobject11["password"] = "0";
            oc_Newobject11["tabComplete"] = "0";
            oc_Newobject11["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject13["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "101 2";
            oc_Newobject12["Extent"] = "18 18";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "Canvas.pushDialog(RiverDefaultDepthSliderCtrlContainer);";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["ToolTip"] = "Changes Default River Depth";
            oc_Newobject12["hovertime"] = "750";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "PushButton";
            oc_Newobject12["useMouseEvents"] = "0";
            oc_Newobject12["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject14.Create();

            #region GuiMouseEventCtrl (RiverDefaultWidthSliderCtrlContainer, EditorGuiGroup)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiMouseEventCtrl",
                "RiverDefaultWidthSliderCtrlContainer, EditorGuiGroup",
                typeof (RiverEditorGui.RiverDefaultWidthSliderCtrlContainer));
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["position"] = "0 0";
            oc_Newobject16["extent"] = "1024 768";
            oc_Newobject16["minExtent"] = "8 8";
            oc_Newobject16["visible"] = "1";
            oc_Newobject16["helpTag"] = "0";
            //oc_Newobject16["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["internalName"] = "slider";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] =
                new ObjectCreator.StringNoQuote(
                    "firstWord(RiverDefaultWidthTextEditContainer.position) + firstWord(RiverEditorToolbar.position) + 10 SPC          (getWord(RiverDefaultWidthTextEditContainer, 1)) + 25");
            oc_Newobject15["Extent"] = "112 20";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["AltCommand"] =
                "RiverDefaultWidthTextEditContainer-->textEdit.setText( mFloatLength($ThisControl.getValue(), 2)); RiverEditorGui.DefaultWidth = $ThisControl.getValue();";
            oc_Newobject15["range"] = "0 100";
            oc_Newobject15["ticks"] = "0";
            oc_Newobject15["value"] = "10";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject16.Create();

            #region GuiMouseEventCtrl (RiverDefaultDepthSliderCtrlContainer, EditorGuiGroup)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiMouseEventCtrl",
                "RiverDefaultDepthSliderCtrlContainer, EditorGuiGroup",
                typeof (RiverEditorGui.RiverDefaultDepthSliderCtrlContainer));
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["position"] = "0 0";
            oc_Newobject18["extent"] = "1024 768";
            oc_Newobject18["minExtent"] = "8 8";
            oc_Newobject18["visible"] = "1";
            oc_Newobject18["helpTag"] = "0";
            //oc_Newobject18["class"] = "EditorDropdownSliderContainer";

            #region GuiSliderCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "slider";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "ToolsGuiSliderBoxProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] =
                new ObjectCreator.StringNoQuote(
                    "firstWord(RiverDefaultDepthTextEditContainer.position) + firstWord(RiverEditorToolbar.position) + 10 SPC          (getWord(RiverDefaultDepthTextEditContainer, 1)) + 25");
            oc_Newobject17["Extent"] = "112 20";
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["AltCommand"] =
                "RiverDefaultDepthTextEditContainer-->textEdit.setValue( mFloatLength($ThisControl.getValue(), 2)); RiverEditorGui.DefaultWidth =  $ThisControl.getValue();";
            oc_Newobject17["range"] = "0 100";
            oc_Newobject17["ticks"] = "0";
            oc_Newobject17["value"] = "10";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject18.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RiverEditorToolbar ts, string simobjectid)
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
        public static bool operator !=(RiverEditorToolbar ts, string simobjectid)
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
        public static implicit operator string(RiverEditorToolbar ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator RiverEditorToolbar(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (RiverEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (RiverEditorToolbar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(RiverEditorToolbar ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RiverEditorToolbar(int simobjectid)
            {
            return (RiverEditorToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (RiverEditorToolbar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(RiverEditorToolbar ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RiverEditorToolbar(uint simobjectid)
            {
            return (RiverEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (RiverEditorToolbar));
            }

        #endregion
        }
    }