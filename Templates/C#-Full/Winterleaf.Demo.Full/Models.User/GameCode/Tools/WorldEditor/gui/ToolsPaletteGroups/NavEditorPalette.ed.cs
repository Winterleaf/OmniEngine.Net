using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.NavEditor.gui;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups
{
    public class NavEditorPalette
    {
        public static uint initialize()
        {
            ObjectCreator oc_Newobject00006;
            ObjectCreator oc_Newobject00005;
            ObjectCreator oc_Newobject00004;
            ObjectCreator oc_Newobject00003;
            ObjectCreator oc_Newobject00002;
            ObjectCreator oc_Newobject00001;
            if (true)
            {

                #region GuiControl (NavEditorPalette,EditorGuiGroup)        oc_Newobject00006
                oc_Newobject00006 = new ObjectCreator("GuiControl", "NavEditorPalette,EditorGuiGroup");
                oc_Newobject00006["canSaveDynamicFields"] = "0";
                oc_Newobject00006["Enabled"] = "1";
                oc_Newobject00006["isContainer"] = "1";
                oc_Newobject00006["Profile"] = "GuiDefaultProfile";
                oc_Newobject00006["HorizSizing"] = "right";
                oc_Newobject00006["VertSizing"] = "bottom";
                oc_Newobject00006["Position"] = "0 0";
                oc_Newobject00006["Extent"] = "1024 768";
                oc_Newobject00006["MinExtent"] = "8 2";
                oc_Newobject00006["canSave"] = "1";
                oc_Newobject00006["Visible"] = "1";
                oc_Newobject00006["hovertime"] = "1000";
                if (true)
                {

                    #region GuiBitmapButtonCtrl (ENavEditorSelectModeBtn)        oc_Newobject00001
                    oc_Newobject00001 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorSelectModeBtn", typeof(ENavEditorPaletteButton));
                    oc_Newobject00001["canSaveDynamicFields"] = "1";
                    //oc_Newobject00001["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00001["internalName"] = "NavEditorSelectMode";
                    oc_Newobject00001["Enabled"] = "1";
                    oc_Newobject00001["isContainer"] = "0";
                    oc_Newobject00001["Profile"] = "GuiButtonProfile";
                    oc_Newobject00001["HorizSizing"] = "right";
                    oc_Newobject00001["VertSizing"] = "bottom";
                    oc_Newobject00001["Position"] = "0 0";
                    oc_Newobject00001["Extent"] = "25 19";
                    oc_Newobject00001["MinExtent"] = "8 2";
                    oc_Newobject00001["canSave"] = "1";
                    oc_Newobject00001["Visible"] = "1";
                    oc_Newobject00001["Command"] = "NavEditorGui.prepSelectionMode();";
                    oc_Newobject00001["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00001["ToolTip"] = "View NavMesh (1).";
                    oc_Newobject00001["DetailedDesc"] = "";
                    oc_Newobject00001["hovertime"] = "1000";
                    oc_Newobject00001["bitmap"] = "tools/gui/images/menubar/visibility-toggle";
                    oc_Newobject00001["buttonType"] = "RadioButton";
                    oc_Newobject00001["useMouseEvents"] = "0";
                    #endregion

                    oc_Newobject00006["#Newobject00001"] = oc_Newobject00001;

                    #region GuiBitmapButtonCtrl (ENavEditorLinkModeBtn)        oc_Newobject00002
                    oc_Newobject00002 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorLinkModeBtn", typeof(ENavEditorPaletteButton));
                    oc_Newobject00002["canSaveDynamicFields"] = "1";
                    //oc_Newobject00002["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00002["internalName"] = "NavEditorLinkMode";
                    oc_Newobject00002["Enabled"] = "1";
                    oc_Newobject00002["isContainer"] = "0";
                    oc_Newobject00002["Profile"] = "GuiButtonProfile";
                    oc_Newobject00002["HorizSizing"] = "right";
                    oc_Newobject00002["VertSizing"] = "bottom";
                    oc_Newobject00002["Position"] = "0 0";
                    oc_Newobject00002["Extent"] = "25 19";
                    oc_Newobject00002["MinExtent"] = "8 2";
                    oc_Newobject00002["canSave"] = "1";
                    oc_Newobject00002["Visible"] = "1";
                    oc_Newobject00002["Command"] = "NavEditorGui.setMode(\\\"LinkMode\\\");";
                    oc_Newobject00002["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00002["ToolTip"] = "Create off-mesh links (2).";
                    oc_Newobject00002["DetailedDesc"] = "Click to select/add. Shift-click to add multiple end points.";
                    oc_Newobject00002["hovertime"] = "1000";
                    oc_Newobject00002["bitmap"] = "tools/navEditor/images/nav-link";
                    oc_Newobject00002["buttonType"] = "RadioButton";
                    oc_Newobject00002["useMouseEvents"] = "0";
                    #endregion

                    oc_Newobject00006["#Newobject00002"] = oc_Newobject00002;

                    #region GuiBitmapButtonCtrl (ENavEditorCoverModeBtn)        oc_Newobject00003
                    oc_Newobject00003 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorCoverModeBtn", typeof(ENavEditorPaletteButton));
                    oc_Newobject00003["canSaveDynamicFields"] = "1";
                    //oc_Newobject00003["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00003["internalName"] = "NavEditorCoverMode";
                    oc_Newobject00003["Enabled"] = "1";
                    oc_Newobject00003["isContainer"] = "0";
                    oc_Newobject00003["Profile"] = "GuiButtonProfile";
                    oc_Newobject00003["HorizSizing"] = "right";
                    oc_Newobject00003["VertSizing"] = "bottom";
                    oc_Newobject00003["Position"] = "0 0";
                    oc_Newobject00003["Extent"] = "25 19";
                    oc_Newobject00003["MinExtent"] = "8 2";
                    oc_Newobject00003["canSave"] = "1";
                    oc_Newobject00003["Visible"] = "1";
                    oc_Newobject00003["Command"] = "NavEditorGui.setMode(\\\"CoverMode\\\");";
                    oc_Newobject00003["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00003["ToolTip"] = "Edit cover (3).";
                    oc_Newobject00003["DetailedDesc"] = "";
                    oc_Newobject00003["hovertime"] = "1000";
                    oc_Newobject00003["bitmap"] = "tools/navEditor/images/nav-cover";
                    oc_Newobject00003["buttonType"] = "RadioButton";
                    oc_Newobject00003["useMouseEvents"] = "0";
                    #endregion

                    oc_Newobject00006["#Newobject00003"] = oc_Newobject00003;

                    #region GuiBitmapButtonCtrl (ENavEditorTileModeBtn)        oc_Newobject00004
                    oc_Newobject00004 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorTileModeBtn", typeof(ENavEditorPaletteButton));
                    oc_Newobject00004["canSaveDynamicFields"] = "1";
                    //oc_Newobject00004["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00004["internalName"] = "NavEditorTileMode";
                    oc_Newobject00004["Enabled"] = "1";
                    oc_Newobject00004["isContainer"] = "0";
                    oc_Newobject00004["Profile"] = "GuiButtonProfile";
                    oc_Newobject00004["HorizSizing"] = "right";
                    oc_Newobject00004["VertSizing"] = "bottom";
                    oc_Newobject00004["Position"] = "0 0";
                    oc_Newobject00004["Extent"] = "25 19";
                    oc_Newobject00004["MinExtent"] = "8 2";
                    oc_Newobject00004["canSave"] = "1";
                    oc_Newobject00004["Visible"] = "1";
                    oc_Newobject00004["Command"] = "NavEditorGui.setMode(\\\"TileMode\\\");";
                    oc_Newobject00004["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00004["ToolTip"] = "View tiles (4).";
                    oc_Newobject00004["DetailedDesc"] = "Click to select.";
                    oc_Newobject00004["hovertime"] = "1000";
                    oc_Newobject00004["bitmap"] = "tools/gui/images/menubar/select-bounds";
                    oc_Newobject00004["buttonType"] = "RadioButton";
                    oc_Newobject00004["useMouseEvents"] = "0";
                    #endregion

                    oc_Newobject00006["#Newobject00004"] = oc_Newobject00004;

                    #region GuiBitmapButtonCtrl (ENavEditorTestModeBtn)        oc_Newobject00005
                    oc_Newobject00005 = new ObjectCreator("GuiBitmapButtonCtrl", "ENavEditorTestModeBtn", typeof(ENavEditorPaletteButton));
                    oc_Newobject00005["canSaveDynamicFields"] = "1";
                    //oc_Newobject00005["class"] = new ObjectCreator.StringNoQuote("ENavEditorPaletteButton");
                    oc_Newobject00005["internalName"] = "NavEditorTestMode";
                    oc_Newobject00005["Enabled"] = "1";
                    oc_Newobject00005["isContainer"] = "0";
                    oc_Newobject00005["Profile"] = "GuiButtonProfile";
                    oc_Newobject00005["HorizSizing"] = "right";
                    oc_Newobject00005["VertSizing"] = "bottom";
                    oc_Newobject00005["Position"] = "0 0";
                    oc_Newobject00005["Extent"] = "25 19";
                    oc_Newobject00005["MinExtent"] = "8 2";
                    oc_Newobject00005["canSave"] = "1";
                    oc_Newobject00005["Visible"] = "1";
                    oc_Newobject00005["Command"] = "NavEditorGui.setMode(\\\"TestMode\\\");";
                    oc_Newobject00005["tooltipprofile"] = "GuiToolTipProfile";
                    oc_Newobject00005["ToolTip"] = "Test pathfinding (5).";
                    oc_Newobject00005["DetailedDesc"] = "Click to select/move character, CTRL-click to spawn, SHIFT-click to deselect.";
                    oc_Newobject00005["hovertime"] = "1000";
                    oc_Newobject00005["bitmap"] = "tools/worldEditor/images/toolbar/3rd-person-camera";
                    oc_Newobject00005["buttonType"] = "RadioButton";
                    oc_Newobject00005["useMouseEvents"] = "0";
                    #endregion

                    oc_Newobject00006["#Newobject00005"] = oc_Newobject00005;

                }
                #endregion
                return oc_Newobject00006.Create();

            }
        }
    }
}
