using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<ShapeEditorToolbar>))]
    public class ShapeEditorToolbar : GuiControl
        {
        [ConsoleInteraction(true, "ShapeEditorToolbar_initialize")]
        public static void initialize()
            {
            #region GuiControl (ShapeEditorToolbar, EditorGuiGroup)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiControl", "ShapeEditorToolbar, EditorGuiGroup",
                typeof (ShapeEditorToolbar));
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["internalName"] = "";
            oc_Newobject17["isContainer"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "102 0";
            oc_Newobject17["Extent"] = new ObjectCreator.StringNoQuote("\"550\" SPC getWord(EditorGuiToolbar.extent, 1)");
            oc_Newobject17["MinExtent"] = "8 2";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["canMove"] = "0";
            oc_Newobject17["canClose"] = "0";
            oc_Newobject17["canMinimize"] = "0";
            oc_Newobject17["canMaximize"] = "0";
            oc_Newobject17["resizeWidth"] = "0";
            oc_Newobject17["resizeHeight"] = "0";
            oc_Newobject17["EdgeSnap"] = "0";
            oc_Newobject17["text"] = "";

            #region GuiContainer ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiContainer", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "menubarProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "0 0";
            oc_Newobject16["Extent"] = "800 32";
            oc_Newobject16["MinExtent"] = "8 8";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "5 7";
            oc_Newobject1["extent"] = "86 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["text"] = "Preview Settings";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["helpTag"] = "0";

            #endregion

            oc_Newobject16["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject2["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject2["position"] = "94 3";
            oc_Newobject2["Extent"] = "2 26";
            oc_Newobject2["MinExtent"] = "1 1";
            oc_Newobject2["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject16["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["internalName"] = "showGridBtn";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "100 3";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "ShapeEdShapeView.renderGrid = $ThisControl.getValue();";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Show grid";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/gui/images/menubar/show-grid";
            oc_Newobject3["text"] = "";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "ToggleButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["internalName"] = "fitToShapeBtn";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "134 3";
            oc_Newobject4["Extent"] = "29 27";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "ShapeEdShapeView.fitToShape();";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["ToolTip"] = "Fit Camera to Shape (F)";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["bitmap"] = "tools/gui/images/menubar/fit-selection";
            oc_Newobject4["text"] = "";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["internalName"] = "orbitNodeBtn";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "168 3";
            oc_Newobject5["Extent"] = "29 27";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["Command"] = "ShapeEdShapeView.orbitNode = $ThisControl.getValue();";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["ToolTip"] = "Orbit the selected node";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["bitmap"] = "tools/gui/images/menubar/orbit-cam";
            oc_Newobject5["text"] = "";
            oc_Newobject5["groupNum"] = "-1";
            oc_Newobject5["buttonType"] = "ToggleButton";
            oc_Newobject5["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject5"] = oc_Newobject5;

            #region GuiBitmapCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject6["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject6["position"] = "202 3";
            oc_Newobject6["Extent"] = "2 26";
            oc_Newobject6["MinExtent"] = "1 1";
            oc_Newobject6["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject16["#Newobject6"] = oc_Newobject6;

            #region GuiBitmapButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["internalName"] = "showNodes";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "210 3";
            oc_Newobject7["Extent"] = "29 27";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Command"] = "ShapeEdShapeView.renderNodes = $ThisControl.getValue();";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["ToolTip"] = "Show Nodes (N)";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["bitmap"] = "tools/shapeEditor/images/shownodes_btn";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "ToggleButton";
            oc_Newobject7["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject7"] = oc_Newobject7;

            #region GuiBitmapButtonCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject8["internalName"] = "ghostMode";
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "243 3";
            oc_Newobject8["Extent"] = "29 27";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "ShapeEdShapeView.renderGhost = $ThisControl.getValue();";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["ToolTip"] = "Toggle shape transparency in the preview window (T)";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["bitmap"] = "tools/shapeEditor/images/ghost_btn";
            oc_Newobject8["buttonType"] = "ToggleButton";
            oc_Newobject8["groupNum"] = "0";
            oc_Newobject8["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["internalName"] = "wireframeMode";
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "276 3";
            oc_Newobject9["Extent"] = "29 27";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "shapeEditorWireframeMode();";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Toggle shape wireframe in the preview window (R)";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["bitmap"] = "tools/shapeEditor/images/show-wireframe";
            oc_Newobject9["buttonType"] = "ToggleButton";
            oc_Newobject9["groupNum"] = "0";
            oc_Newobject9["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject9"] = oc_Newobject9;

            #region GuiBitmapCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["position"] = "309 3";
            oc_Newobject10["Extent"] = "2 26";
            oc_Newobject10["MinExtent"] = "1 1";
            oc_Newobject10["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject16["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["internalName"] = "showBounds";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "315 3";
            oc_Newobject11["Extent"] = "29 27";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "ShapeEdShapeView.renderbounds = $ThisControl.getValue();";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["ToolTip"] = "Toggle shape bounding box in the preview window";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["bitmap"] = "tools/shapeEditor/images/object-bounds";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "ToggleButton";
            oc_Newobject11["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject11"] = oc_Newobject11;

            #region GuiBitmapButtonCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["internalName"] = "showObjBox";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "348 3";
            oc_Newobject12["Extent"] = "29 27";
            oc_Newobject12["MinExtent"] = "8 8";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "ShapeEdShapeView.renderObjBox = $ThisControl.getValue();";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["ToolTip"] = "Toggle selected object bounding box in the preview window";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["bitmap"] = "tools/shapeEditor/images/object-fit-bounds";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "ToggleButton";
            oc_Newobject12["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["internalName"] = "renderColMeshes";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "381 3";
            oc_Newobject13["Extent"] = "29 27";
            oc_Newobject13["MinExtent"] = "8 8";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "shapeEdShapeView.renderColMeshes = $ThisControl.getValue();";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["ToolTip"] = "Toggle rendering of collision meshes in the preview window";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["bitmap"] = "tools/shapeEditor/images/collision-shape";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "ToggleButton";
            oc_Newobject13["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject13"] = oc_Newobject13;

            #region GuiBitmapCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["position"] = "415 3";
            oc_Newobject14["Extent"] = "2 26";
            oc_Newobject14["MinExtent"] = "1 1";
            oc_Newobject14["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject16["#Newobject14"] = oc_Newobject14;

            #region GuiBitmapButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject15["internalName"] = "showAdvanced";
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "423 3";
            oc_Newobject15["Extent"] = "29 27";
            oc_Newobject15["MinExtent"] = "8 2";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["Command"] = "ShapeEdAdvancedWindow.setVisible( $ThisControl.getValue() );";
            oc_Newobject15["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject15["ToolTip"] = "Toggle Advanced Properties Window";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["bitmap"] = "tools/shapeEditor/images/detail-levels_btn";
            oc_Newobject15["buttonType"] = "ToggleButton";
            oc_Newobject15["groupNum"] = "0";
            oc_Newobject15["useMouseEvents"] = "0";

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject17["#Newobject16"] = oc_Newobject16;

            #endregion

            oc_Newobject17.Create();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ShapeEditorToolbar ts, string simobjectid)
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
        public static bool operator !=(ShapeEditorToolbar ts, string simobjectid)
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
        public static implicit operator string(ShapeEditorToolbar ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator ShapeEditorToolbar(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (ShapeEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (ShapeEditorToolbar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeEditorToolbar ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeEditorToolbar(int simobjectid)
            {
            return (ShapeEditorToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeEditorToolbar));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeEditorToolbar ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeEditorToolbar(uint simobjectid)
            {
            return (ShapeEditorToolbar) Omni.self.getSimObject(simobjectid, typeof (ShapeEditorToolbar));
            }

        #endregion
        }
    }