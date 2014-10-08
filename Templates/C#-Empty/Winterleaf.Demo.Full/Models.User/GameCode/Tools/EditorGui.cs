using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DecalEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MaterialEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ParticleEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RoadEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.PlugIns;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.ToolsPaletteGroups;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;
using Creator = WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.Creator;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools
    {
    public class EditorGui : GuiContainer
        {
        

        internal EditorPlugin currentEditor
            {
            get { return this["currentEditor"]; }
            set { this["currentEditor"] = value; }
            }

        internal bool isInitialized
            {
            get { return this["isInitialized"].AsBool(); }
            set { this["isInitialized"] = value.AsString(); }
            }

        internal MenuBar menuBar
            {
            get { return this["menuBar"]; }
            set { this["menuBar"] = value; }
            }

        internal MenuHandlers.EditorCameraSpeedMenu cameraSpeedMenu
            {
            get { return this["cameraSpeedMenu"]; }
            set { this["cameraSpeedMenu"] = value; }
            }

        internal MenuHandlers.EditorFreeCameraTypeMenu freeCameraTypeMenu
            {
            get { return this["freeCameraTypeMenu"]; }
            set { this["freeCameraTypeMenu"] = value; }
            }

        internal MenuHandlers.EditorPlayerCameraTypeMenu playerCameraTypeMenu
            {
            get { return this["playerCameraTypeMenu"]; }
            set { this["playerCameraTypeMenu"] = value; }
            }

        internal EditorCameraBookmarksMenu cameraBookmarksMenu
            {
            get { return this["cameraBookmarksMenu"]; }
            set { this["cameraBookmarksMenu"] = value; }
            }

        internal MenuBuilder viewTypeMenu
            {
            get { return this["viewTypeMenu"]; }
            set { this["viewTypeMenu"] = value; }
            }

        internal MenuHandlers.EditorDropTypeMenu dropTypeMenu
            {
            get { return this["dropTypeMenu"]; }
            set { this["dropTypeMenu"] = value; }
            }

        internal MenuHandlers.EditorAlignBoundsMenu alignBoundsMenu
            {
            get { return this["alignBoundsMenu"]; }
            set { this["alignBoundsMenu"] = value; }
            }

        internal MenuHandlers.EditorAlignCenterMenu alignCenterMenu
            {
            get { return this["alignCenterMenu"]; }
            set { this["alignCenterMenu"] = value; }
            }

        internal MenuHandlers.EditorWorldMenu worldMenu
            {
            get { return this["worldMenu"]; }
            set { this["worldMenu"] = value; }
            }

        [ConsoleInteraction(true, "EditorGui_initialize")]
        public static void initialize()
            {
            #region GuiContainer (EditorGui,EditorGuiGroup)        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiContainer", "EditorGui,EditorGuiGroup",
                typeof (EditorGui));
            oc_Newobject57["canSaveDynamicFields"] = "0";
            oc_Newobject57["Enabled"] = "1";
            oc_Newobject57["isContainer"] = "1";
            oc_Newobject57["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject57["HorizSizing"] = "right";
            oc_Newobject57["VertSizing"] = "bottom";
            oc_Newobject57["Position"] = "0 0";
            oc_Newobject57["Extent"] = "800 600";
            oc_Newobject57["MinExtent"] = "8 8";
            oc_Newobject57["canSave"] = "1";
            oc_Newobject57["Visible"] = "1";
            oc_Newobject57["hovertime"] = "1000";
            oc_Newobject57["Margin"] = "0 0 0 0";
            oc_Newobject57["Padding"] = "0 0 0 0";
            oc_Newobject57["AnchorTop"] = "1";
            oc_Newobject57["AnchorBottom"] = "0";
            oc_Newobject57["AnchorLeft"] = "1";
            oc_Newobject57["AnchorRight"] = "0";

            #region GuiContainer (EditorGuiToolbar)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiContainer", "EditorGuiToolbar");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "menubarProfile";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "0 0";
            oc_Newobject15["Extent"] = "800 32";
            oc_Newobject15["MinExtent"] = "8 8";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["hovertime"] = "1000";

            #region GuiBitmapButtonCtrl (EHWorldEditor)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "EHWorldEditor");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "4 3";
            oc_Newobject1["Extent"] = "29 27";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["ToolTip"] = "Open the WorldEditor";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "tools/worldEditor/images/toolbar/world";
            oc_Newobject1["groupNum"] = "0";
            oc_Newobject1["buttonType"] = "RadioButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject15["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl (EHGuiEditor)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "EHGuiEditor");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "34 3";
            oc_Newobject2["Extent"] = "29 27";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "toggleEditor( true ); GuiEdit(); $GuiEditorBtnPressed = true;";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["ToolTip"] = "Open the GuiEditor";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["bitmap"] = "tools/worldEditor/images/toolbar/gui";
            oc_Newobject2["groupNum"] = "0";
            oc_Newobject2["buttonType"] = "RadioButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject15["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "64 3";
            oc_Newobject3["Extent"] = "29 27";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "Editor.close(\\\"PlayGui\\\");";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["ToolTip"] = "Play Game";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "tools/worldEditor/images/toolbar/playbutton";
            oc_Newobject3["groupNum"] = "0";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject15["#Newobject3"] = oc_Newobject3;

            #region GuiBitmapCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject4["position"] = "98 3";
            oc_Newobject4["Extent"] = "2 26";
            oc_Newobject4["MinExtent"] = "1 1";
            oc_Newobject4["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject15["#Newobject4"] = oc_Newobject4;

            #region GuiBitmapButtonCtrl (EWorldEditorToggleCamera)        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiBitmapButtonCtrl", "EWorldEditorToggleCamera",
                typeof (EWorldEditor.EWorldEditorToggleCamera));
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "102 3";
            oc_Newobject6["Extent"] = "29 27";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "CameraTypesDropdownToggle();";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Toggle Camera Modes";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["bitmap"] = "tools/worldEditor/images/toolbar/player";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "ToggleButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject5["HorizSizing"] = "left";
            oc_Newobject5["VertSizing"] = "top";
            oc_Newobject5["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(EWorldEditorToggleCamera.extent, 0)-6 SPC getWord(EWorldEditorToggleCamera.extent, 1)-6");
            oc_Newobject5["Extent"] = "4 4";
            oc_Newobject5["MinExtent"] = "4 4";
            oc_Newobject5["bitmap"] = "tools/gui/images/dropdown-button-arrow";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject15["#Newobject6"] = oc_Newobject6;

            #region GuiControl (CameraSpeedDropdownContainer, EditorGuiGroup)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl",
                "CameraSpeedDropdownContainer, EditorGuiGroup");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "136 5";
            oc_Newobject10["Extent"] = "136 27";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "0 6";
            oc_Newobject7["Extent"] = "78 10";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["text"] = "Camera Speed";
            oc_Newobject7["maxLength"] = "1024";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl (EWorldEditorCameraSpeed)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "EWorldEditorCameraSpeed",
                typeof (EWorldEditor.EWorldEditorCameraSpeed));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["internalName"] = "textEdit";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["profile"] = "ToolsGuiNumericDropSliderTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "78 2";
            oc_Newobject8["Extent"] = "42 16";
            oc_Newobject8["MinExtent"] = "8 16";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["Command"] = "EWorldEditorCameraSpeed.updateMenuBar( $ThisControl );";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["text"] = "100";
            oc_Newobject8["maxLength"] = "4";
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiBitmapButtonCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "112 2";
            oc_Newobject9["Extent"] = "18 18";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["Command"] = "Canvas.pushDialog(CameraSpeedDropdownCtrlContainer);";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["ToolTip"] = "Changes the Camera Speed";
            oc_Newobject9["hovertime"] = "750";
            oc_Newobject9["groupNum"] = "-1";
            oc_Newobject9["buttonType"] = "PushButton";
            oc_Newobject9["useMouseEvents"] = "0";
            oc_Newobject9["bitmap"] = "tools/gui/images/dropslider";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject15["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapButtonCtrl (visibilityToggleBtn)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiBitmapButtonCtrl", "visibilityToggleBtn");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "270 3";
            oc_Newobject12["Extent"] = "29 27";
            oc_Newobject12["MinExtent"] = "8 8";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["Command"] = "VisibilityDropdownToggle();";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["ToolTip"] = "Toggle Visibility Modes (ALT V)";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["bitmap"] = "tools/gui/images/menubar/visibility-toggle";
            oc_Newobject12["groupNum"] = "-1";
            oc_Newobject12["buttonType"] = "ToggleButton";
            oc_Newobject12["useMouseEvents"] = "0";

            #region GuiBitmapCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject11["HorizSizing"] = "left";
            oc_Newobject11["VertSizing"] = "top";
            oc_Newobject11["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(visibilityToggleBtn.extent, 0)-6 SPC getWord(visibilityToggleBtn.extent, 1)-6");
            oc_Newobject11["Extent"] = "4 4";
            oc_Newobject11["MinExtent"] = "4 4";
            oc_Newobject11["bitmap"] = "tools/gui/images/dropdown-button-arrow";

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject15["#Newobject12"] = oc_Newobject12;

            #region GuiBitmapCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject13["position"] = "303 3";
            oc_Newobject13["Extent"] = "2 26";
            oc_Newobject13["MinExtent"] = "1 1";
            oc_Newobject13["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject15["#Newobject13"] = oc_Newobject13;

            #region GuiPopUpMenuCtrl (EWorldEditorAlignPopup)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiPopUpMenuCtrl", "EWorldEditorAlignPopup",
                typeof (EWorldEditor.EWorldEditorAlignPopup));
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["internalName"] = "";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "439 2";
            oc_Newobject14["Extent"] = "70 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "0";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["maxLength"] = "1024";
            oc_Newobject14["maxPopupHeight"] = "200";
            oc_Newobject14["sbUsesNAColor"] = "0";
            oc_Newobject14["reverseTextList"] = "0";
            oc_Newobject14["bitmapBounds"] = "16 16";

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject57["#Newobject15"] = oc_Newobject15;

            #region GuiContainer (EditorGuiStatusBar)        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiContainer", "EditorGuiStatusBar",
                typeof (EditorGuiStatusBar));
            oc_Newobject22["canSaveDynamicFields"] = "0";
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["isContainer"] = "1";
            oc_Newobject22["Profile"] = "menubarProfile";
            oc_Newobject22["HorizSizing"] = "width";
            oc_Newobject22["VertSizing"] = "top";
            oc_Newobject22["Position"] = "0 578";
            oc_Newobject22["Extent"] = "800 22";
            oc_Newobject22["MinExtent"] = "8 8";
            oc_Newobject22["canSave"] = "1";
            oc_Newobject22["Visible"] = "1";
            oc_Newobject22["hovertime"] = "1000";
            oc_Newobject22["Docking"] = "Bottom";

            #region GuiTextCtrl (EWorldEditorStatusBarInfo)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "EWorldEditorStatusBarInfo");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject16["HorizSizing"] = "width";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "3 2";
            oc_Newobject16["Extent"] = "450 18";
            oc_Newobject16["MinExtent"] = "8 8";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "Current Tool";
            oc_Newobject16["maxLength"] = "255";

            #endregion

            oc_Newobject22["#Newobject16"] = oc_Newobject16;

            #region GuiBitmapCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject17["HorizSizing"] = "left";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "459 2";
            oc_Newobject17["Extent"] = "2 18";
            oc_Newobject17["MinExtent"] = "1 1";
            oc_Newobject17["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject22["#Newobject17"] = oc_Newobject17;

            #region GuiTextCtrl (EWorldEditorStatusBarSelection)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextCtrl", "EWorldEditorStatusBarSelection");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject18["HorizSizing"] = "left";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["Position"] = "469 2";
            oc_Newobject18["Extent"] = "180 18";
            oc_Newobject18["MinExtent"] = "8 8";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["text"] = "";
            oc_Newobject18["maxLength"] = "255";

            #endregion

            oc_Newobject22["#Newobject18"] = oc_Newobject18;

            #region GuiBitmapCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject19["Enabled"] = "1";
            oc_Newobject19["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject19["HorizSizing"] = "left";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "659 2";
            oc_Newobject19["Extent"] = "2 18";
            oc_Newobject19["MinExtent"] = "1 1";
            oc_Newobject19["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiPopUpMenuCtrl (EWorldEditorStatusBarCamera)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiPopUpMenuCtrl", "EWorldEditorStatusBarCamera",
                typeof (EWorldEditorStatusBarCamera));
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "0";
            oc_Newobject20["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject20["HorizSizing"] = "left";
            oc_Newobject20["VertSizing"] = "bottom";
            oc_Newobject20["Position"] = "667 2";
            oc_Newobject20["Extent"] = "120 18";
            oc_Newobject20["MinExtent"] = "8 8";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiBitmapCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject21["HorizSizing"] = "left";
            oc_Newobject21["VertSizing"] = "bottom";
            oc_Newobject21["position"] = "800 2";
            oc_Newobject21["Extent"] = "2 18";
            oc_Newobject21["MinExtent"] = "1 1";
            oc_Newobject21["bitmap"] = "tools/gui/images/separator-h.png";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject57["#Newobject22"] = oc_Newobject22;

            #region WorldEditor (EWorldEditor)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("WorldEditor", "EWorldEditor", typeof (EWorldEditor));
            oc_Newobject23["canSaveDynamicFields"] = "0";
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["isContainer"] = "0";
            oc_Newobject23["Profile"] = "WorldEditorProfile";
            oc_Newobject23["HorizSizing"] = "width";
            oc_Newobject23["VertSizing"] = "height";
            oc_Newobject23["Position"] = "0 0";
            oc_Newobject23["Extent"] = "800 600";
            oc_Newobject23["MinExtent"] = "8 8";
            oc_Newobject23["canSave"] = "1";
            oc_Newobject23["Visible"] = "1";
            oc_Newobject23["hovertime"] = "1000";
            oc_Newobject23["Docking"] = "None";
            oc_Newobject23["Margin"] = "0 0 0 0";
            oc_Newobject23["Padding"] = "0 0 0 0";
            oc_Newobject23["AnchorTop"] = "0";
            oc_Newobject23["AnchorBottom"] = "0";
            oc_Newobject23["AnchorLeft"] = "0";
            oc_Newobject23["AnchorRight"] = "0";
            oc_Newobject23["cameraZRot"] = "0";
            oc_Newobject23["forceFOV"] = "0";
            oc_Newobject23["renderMissionArea"] = "0";
            oc_Newobject23["missionAreaFillColor"] = "255 0 0 20";
            oc_Newobject23["missionAreaFrameColor"] = "255 0 0 128";
            oc_Newobject23["allowBorderMove"] = "0";
            oc_Newobject23["borderMovePixelSize"] = "20";
            oc_Newobject23["borderMoveSpeed"] = "0.1";
            oc_Newobject23["consoleFrameColor"] = "255 0 0 255";
            oc_Newobject23["consoleFillColor"] = "0 0 0 0";
            oc_Newobject23["consoleSphereLevel"] = "1";
            oc_Newobject23["consoleCircleSegments"] = "32";
            oc_Newobject23["consoleLineWidth"] = "1";
            oc_Newobject23["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject23["isDirty"] = "0";
            oc_Newobject23["stickToGround"] = "0";
            oc_Newobject23["dropAtBounds"] = "1";
            oc_Newobject23["dropBelowCameraOffset"] = "15";
            oc_Newobject23["dropType"] = "screenCenter";
            oc_Newobject23["boundingBoxCollision"] = "1";
            oc_Newobject23["renderPopupBackground"] = "1";
            oc_Newobject23["popupBackgroundColor"] = "100 100 100 255";
            oc_Newobject23["popupTextColor"] = "255 255 0 255";
            oc_Newobject23["objectTextColor"] = "255 255 255 255";
            oc_Newobject23["objectsUseBoxCenter"] = "1";
            oc_Newobject23["objSelectColor"] = "255 0 0 255";
            oc_Newobject23["objMouseOverSelectColor"] = "0 0 255 255";
            oc_Newobject23["objMouseOverColor"] = "0 255 0 255";
            oc_Newobject23["showMousePopupInfo"] = "1";
            oc_Newobject23["dragRectColor"] = "255 255 0 255";
            oc_Newobject23["renderObjText"] = "1";
            oc_Newobject23["renderObjHandle"] = "1";
            oc_Newobject23["objTextFormat"] = "$name|class$";
            oc_Newobject23["faceSelectColor"] = "0 0 100 100";
            oc_Newobject23["renderSelectionBox"] = "1";
            oc_Newobject23["selectionBoxColor"] = "255 255 0 255";
            oc_Newobject23["selectionLocked"] = "0";
            oc_Newobject23["toggleIgnoreList"] = "0";
            oc_Newobject23["selectHandle"] = "tools/worldEditor/images/SelectHandle.png";
            oc_Newobject23["defaultHandle"] = "tools/worldEditor/images/DefaultHandle.png";
            oc_Newobject23["lockedHandle"] = "tools/worldEditor/images/LockedHandle.png";

            #endregion

            oc_Newobject57["#Newobject23"] = oc_Newobject23;

            #region TerrainEditor (ETerrainEditor)        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("TerrainEditor", "ETerrainEditor");
            oc_Newobject28["canSaveDynamicFields"] = "0";
            oc_Newobject28["Enabled"] = "1";
            oc_Newobject28["isContainer"] = "0";
            oc_Newobject28["Profile"] = "WorldEditorProfile";
            oc_Newobject28["HorizSizing"] = "width";
            oc_Newobject28["VertSizing"] = "height";
            oc_Newobject28["Position"] = "0 0";
            oc_Newobject28["Extent"] = "800 600";
            oc_Newobject28["MinExtent"] = "8 8";
            oc_Newobject28["canSave"] = "1";
            oc_Newobject28["Visible"] = "0";
            oc_Newobject28["hovertime"] = "1000";
            oc_Newobject28["Docking"] = "None";
            oc_Newobject28["Margin"] = "0 0 0 0";
            oc_Newobject28["Padding"] = "0 0 0 0";
            oc_Newobject28["AnchorTop"] = "0";
            oc_Newobject28["AnchorBottom"] = "0";
            oc_Newobject28["AnchorLeft"] = "0";
            oc_Newobject28["AnchorRight"] = "0";
            oc_Newobject28["cameraZRot"] = "0";
            oc_Newobject28["forceFOV"] = "0";
            oc_Newobject28["renderMissionArea"] = "0";
            oc_Newobject28["missionAreaFillColor"] = "0 0 0 20";
            oc_Newobject28["missionAreaFrameColor"] = "0 0 0 128";
            oc_Newobject28["allowBorderMove"] = "0";
            oc_Newobject28["borderMovePixelSize"] = "20";
            oc_Newobject28["borderMoveSpeed"] = "0.1";
            oc_Newobject28["consoleFrameColor"] = "0 0 0 255";
            oc_Newobject28["consoleFillColor"] = "0 0 0 0";
            oc_Newobject28["consoleSphereLevel"] = "1";
            oc_Newobject28["consoleCircleSegments"] = "32";
            oc_Newobject28["consoleLineWidth"] = "1";
            oc_Newobject28["GizmoProfile"] = "GlobalGizmoProfile";
            oc_Newobject28["isDirty"] = "0";
            oc_Newobject28["isMissionDirty"] = "0";
            oc_Newobject28["renderBorder"] = "1";
            oc_Newobject28["borderHeight"] = "10";
            oc_Newobject28["borderFillColor"] = "0 255 0 20";
            oc_Newobject28["borderFrameColor"] = "0 255 0 128";
            oc_Newobject28["borderLineMode"] = "0";
            oc_Newobject28["selectionHidden"] = "1";
            oc_Newobject28["renderVertexSelection"] = "1";
            oc_Newobject28["processUsesBrush"] = "0";
            oc_Newobject28["maxBrushSize"] = "40 40";
            oc_Newobject28["adjustHeightVal"] = "10";
            oc_Newobject28["setHeightVal"] = "100";
            oc_Newobject28["scaleVal"] = "1";
            oc_Newobject28["smoothFactor"] = "0.1";
            oc_Newobject28["materialGroup"] = "0";
            oc_Newobject28["softSelectRadius"] = "50";
            oc_Newobject28["softSelectFilter"] = "1.000000 0.833333 0.666667 0.500000 0.333333 0.166667 0.000000";
            oc_Newobject28["softSelectDefaultFilter"] = "1.000000 0.833333 0.666667 0.500000 0.333333 0.166667 0.000000";
            oc_Newobject28["adjustHeightMouseScale"] = "0.1";
            oc_Newobject28["paintIndex"] = "-1";

            #region GuiTextCtrl (TESelectionInfo)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextCtrl", "TESelectionInfo");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "EditorTextProfile";
            oc_Newobject24["HorizSizing"] = "right";
            oc_Newobject24["VertSizing"] = "top";
            oc_Newobject24["Position"] = "288 549";
            oc_Newobject24["Extent"] = "120 18";
            oc_Newobject24["MinExtent"] = "8 8";
            oc_Newobject24["canSave"] = "1";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["hovertime"] = "1000";
            oc_Newobject24["Margin"] = "0 0 0 0";
            oc_Newobject24["Padding"] = "0 0 0 0";
            oc_Newobject24["AnchorTop"] = "1";
            oc_Newobject24["AnchorBottom"] = "0";
            oc_Newobject24["AnchorLeft"] = "1";
            oc_Newobject24["AnchorRight"] = "0";
            oc_Newobject24["text"] = " (Selection) #: 0  avg: 0";
            oc_Newobject24["maxLength"] = "255";

            #endregion

            oc_Newobject28["#Newobject24"] = oc_Newobject24;

            #region GuiTextCtrl (TEMouseBrushInfo)        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiTextCtrl", "TEMouseBrushInfo");
            oc_Newobject25["canSaveDynamicFields"] = "0";
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["isContainer"] = "0";
            oc_Newobject25["Profile"] = "EditorTextProfile";
            oc_Newobject25["HorizSizing"] = "right";
            oc_Newobject25["VertSizing"] = "top";
            oc_Newobject25["Position"] = "40 549";
            oc_Newobject25["Extent"] = "107 18";
            oc_Newobject25["MinExtent"] = "8 8";
            oc_Newobject25["canSave"] = "1";
            oc_Newobject25["Visible"] = "1";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["Margin"] = "0 0 0 0";
            oc_Newobject25["Padding"] = "0 0 0 0";
            oc_Newobject25["AnchorTop"] = "1";
            oc_Newobject25["AnchorBottom"] = "0";
            oc_Newobject25["AnchorLeft"] = "1";
            oc_Newobject25["AnchorRight"] = "0";
            oc_Newobject25["text"] = " (Mouse) #: 0  avg: 0";
            oc_Newobject25["maxLength"] = "255";

            #endregion

            oc_Newobject28["#Newobject25"] = oc_Newobject25;

            #region GuiTextCtrl (TESelectionInfo1)        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiTextCtrl", "TESelectionInfo1");
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "EditorTextProfileWhite";
            oc_Newobject26["HorizSizing"] = "right";
            oc_Newobject26["VertSizing"] = "top";
            oc_Newobject26["Position"] = "289 550";
            oc_Newobject26["Extent"] = "120 18";
            oc_Newobject26["MinExtent"] = "8 8";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["Margin"] = "0 0 0 0";
            oc_Newobject26["Padding"] = "0 0 0 0";
            oc_Newobject26["AnchorTop"] = "1";
            oc_Newobject26["AnchorBottom"] = "0";
            oc_Newobject26["AnchorLeft"] = "1";
            oc_Newobject26["AnchorRight"] = "0";
            oc_Newobject26["text"] = " (Selection) #: 0  avg: 0";
            oc_Newobject26["maxLength"] = "255";

            #endregion

            oc_Newobject28["#Newobject26"] = oc_Newobject26;

            #region GuiTextCtrl (TEMouseBrushInfo1)        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextCtrl", "TEMouseBrushInfo1");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "EditorTextProfileWhite";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "top";
            oc_Newobject27["Position"] = "41 550";
            oc_Newobject27["Extent"] = "107 18";
            oc_Newobject27["MinExtent"] = "8 8";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["Margin"] = "0 0 0 0";
            oc_Newobject27["Padding"] = "0 0 0 0";
            oc_Newobject27["AnchorTop"] = "1";
            oc_Newobject27["AnchorBottom"] = "0";
            oc_Newobject27["AnchorLeft"] = "1";
            oc_Newobject27["AnchorRight"] = "0";
            oc_Newobject27["text"] = " (Mouse) #: 0  avg: 0";
            oc_Newobject27["maxLength"] = "255";

            #endregion

            oc_Newobject28["#Newobject27"] = oc_Newobject27;

            #endregion

            oc_Newobject57["#Newobject28"] = oc_Newobject28;

            #region GuiControl (RelightStatus)        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiControl", "RelightStatus");
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["Enabled"] = "1";
            oc_Newobject31["isContainer"] = "1";
            oc_Newobject31["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject31["HorizSizing"] = "center";
            oc_Newobject31["VertSizing"] = "center";
            oc_Newobject31["Position"] = "223 277";
            oc_Newobject31["Extent"] = "353 45";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["Visible"] = "0";
            oc_Newobject31["hovertime"] = "1000";

            #region GuiProgressBitmapCtrl (RelightProgress)        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiProgressBitmapCtrl", "RelightProgress");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";
            oc_Newobject29["isContainer"] = "1";
            oc_Newobject29["Profile"] = "ToolsGuiRLProgressBitmapProfile";
            oc_Newobject29["HorizSizing"] = "center";
            oc_Newobject29["VertSizing"] = "center";
            oc_Newobject29["position"] = "5 0";
            oc_Newobject29["Extent"] = "440 24";
            oc_Newobject29["MinExtent"] = "8 8";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["Margin"] = "0 0 0 0";
            oc_Newobject29["Padding"] = "0 0 0 0";
            oc_Newobject29["AnchorTop"] = "1";
            oc_Newobject29["AnchorBottom"] = "0";
            oc_Newobject29["AnchorLeft"] = "1";
            oc_Newobject29["AnchorRight"] = "0";
            oc_Newobject29["maxLength"] = "1024";

            #endregion

            oc_Newobject31["#Newobject29"] = oc_Newobject29;

            #region GuiTextCtrl (RelightProgressTxt)        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiTextCtrl", "RelightProgressTxt");
            oc_Newobject30["canSaveDynamicFields"] = "0";
            oc_Newobject30["Enabled"] = "1";
            oc_Newobject30["isContainer"] = "0";
            oc_Newobject30["Profile"] = "ToolsGuiProgressTextProfile";
            oc_Newobject30["HorizSizing"] = "right";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = "5 20";
            oc_Newobject30["Extent"] = "440 20";
            oc_Newobject30["MinExtent"] = "8 8";
            oc_Newobject30["canSave"] = "1";
            oc_Newobject30["Visible"] = "1";
            oc_Newobject30["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject30["hovertime"] = "1000";
            oc_Newobject30["Margin"] = "0 0 0 0";
            oc_Newobject30["Padding"] = "0 0 0 0";
            oc_Newobject30["AnchorTop"] = "1";
            oc_Newobject30["AnchorBottom"] = "0";
            oc_Newobject30["AnchorLeft"] = "1";
            oc_Newobject30["AnchorRight"] = "0";
            oc_Newobject30["text"] = "Loading Mission";
            oc_Newobject30["maxLength"] = "255";

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject57["#Newobject31"] = oc_Newobject31;

            #region GuiControl (RelightMessage)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiControl", "RelightMessage");
            oc_Newobject35["canSaveDynamicFields"] = "0";
            oc_Newobject35["Enabled"] = "1";
            oc_Newobject35["isContainer"] = "1";
            oc_Newobject35["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject35["HorizSizing"] = "width";
            oc_Newobject35["VertSizing"] = "top";
            oc_Newobject35["Position"] = "19 570";
            oc_Newobject35["Extent"] = "583 23";
            oc_Newobject35["MinExtent"] = "8 2";
            oc_Newobject35["canSave"] = "1";
            oc_Newobject35["Visible"] = "0";
            oc_Newobject35["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject32["canSaveDynamicFields"] = "0";
            oc_Newobject32["Enabled"] = "1";
            oc_Newobject32["isContainer"] = "0";
            oc_Newobject32["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject32["HorizSizing"] = "width";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["Position"] = "5 1";
            oc_Newobject32["Extent"] = "449 18";
            oc_Newobject32["MinExtent"] = "8 2";
            oc_Newobject32["canSave"] = "1";
            oc_Newobject32["Visible"] = "1";
            oc_Newobject32["hovertime"] = "1000";
            oc_Newobject32["Margin"] = "0 0 0 0";
            oc_Newobject32["Padding"] = "0 0 0 0";
            oc_Newobject32["AnchorTop"] = "1";
            oc_Newobject32["AnchorBottom"] = "0";
            oc_Newobject32["AnchorLeft"] = "1";
            oc_Newobject32["AnchorRight"] = "0";
            oc_Newobject32["text"] = "A lightmapped object has been altered; relight the scene!";
            oc_Newobject32["maxLength"] = "255";

            #endregion

            oc_Newobject35["#Newobject32"] = oc_Newobject32;

            #region GuiButtonCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject33["canSaveDynamicFields"] = "0";
            oc_Newobject33["Enabled"] = "1";
            oc_Newobject33["isContainer"] = "0";
            oc_Newobject33["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject33["HorizSizing"] = "left";
            oc_Newobject33["VertSizing"] = "bottom";
            oc_Newobject33["Position"] = "468 2";
            oc_Newobject33["Extent"] = "75 18";
            oc_Newobject33["MinExtent"] = "8 2";
            oc_Newobject33["canSave"] = "1";
            oc_Newobject33["Visible"] = "1";
            oc_Newobject33["Command"] = "Editor.lightScene(\\\"\\\", forceAlways); RelightMessage.visible = false;";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["text"] = "Relight Scene";
            oc_Newobject33["groupNum"] = "-1";
            oc_Newobject33["buttonType"] = "PushButton";
            oc_Newobject33["useMouseEvents"] = "0";

            #endregion

            oc_Newobject35["#Newobject33"] = oc_Newobject33;

            #region GuiButtonCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject34["canSaveDynamicFields"] = "0";
            oc_Newobject34["Enabled"] = "1";
            oc_Newobject34["isContainer"] = "0";
            oc_Newobject34["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject34["HorizSizing"] = "left";
            oc_Newobject34["VertSizing"] = "bottom";
            oc_Newobject34["Position"] = "548 2";
            oc_Newobject34["Extent"] = "32 18";
            oc_Newobject34["MinExtent"] = "8 2";
            oc_Newobject34["canSave"] = "1";
            oc_Newobject34["Visible"] = "1";
            oc_Newobject34["Command"] = "RelightMessage.visible = false;";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["text"] = "Hide";
            oc_Newobject34["groupNum"] = "-1";
            oc_Newobject34["buttonType"] = "PushButton";
            oc_Newobject34["useMouseEvents"] = "0";

            #endregion

            oc_Newobject35["#Newobject34"] = oc_Newobject34;

            #endregion

            oc_Newobject57["#Newobject35"] = oc_Newobject35;

            #region GuiControl (PhysicsEditMessage)        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiControl", "PhysicsEditMessage");
            oc_Newobject39["canSaveDynamicFields"] = "0";
            oc_Newobject39["Enabled"] = "1";
            oc_Newobject39["isContainer"] = "1";
            oc_Newobject39["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject39["HorizSizing"] = "center";
            oc_Newobject39["VertSizing"] = "top";
            oc_Newobject39["Position"] = "180 560";
            oc_Newobject39["Extent"] = "440 32";
            oc_Newobject39["MinExtent"] = "8 2";
            oc_Newobject39["canSave"] = "1";
            oc_Newobject39["Visible"] = "0";
            oc_Newobject39["hovertime"] = "1000";

            #region GuiTextCtrl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject36["canSaveDynamicFields"] = "0";
            oc_Newobject36["Enabled"] = "1";
            oc_Newobject36["isContainer"] = "0";
            oc_Newobject36["Profile"] = "EditorTextProfile";
            oc_Newobject36["HorizSizing"] = "width";
            oc_Newobject36["VertSizing"] = "center";
            oc_Newobject36["Position"] = "5 0";
            oc_Newobject36["Extent"] = "238 18";
            oc_Newobject36["MinExtent"] = "8 2";
            oc_Newobject36["canSave"] = "1";
            oc_Newobject36["Visible"] = "1";
            oc_Newobject36["hovertime"] = "1000";
            oc_Newobject36["Margin"] = "0 0 0 0";
            oc_Newobject36["Padding"] = "0 0 0 0";
            oc_Newobject36["AnchorTop"] = "1";
            oc_Newobject36["AnchorBottom"] = "0";
            oc_Newobject36["AnchorLeft"] = "1";
            oc_Newobject36["AnchorRight"] = "0";
            oc_Newobject36["text"] = "PHYSICS SIMULATION PAUSED FOR EDITING...";
            oc_Newobject36["maxLength"] = "255";

            #endregion

            oc_Newobject39["#Newobject36"] = oc_Newobject36;

            #region GuiButtonCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";
            oc_Newobject37["isContainer"] = "0";
            oc_Newobject37["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject37["HorizSizing"] = "left";
            oc_Newobject37["VertSizing"] = "bottom";
            oc_Newobject37["Position"] = "337 3";
            oc_Newobject37["Extent"] = "43 26";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["Command"] = "physicsStart(); PhysicsEditMessage.visible = false;";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["text"] = "Start";
            oc_Newobject37["groupNum"] = "-1";
            oc_Newobject37["buttonType"] = "PushButton";
            oc_Newobject37["useMouseEvents"] = "0";

            #endregion

            oc_Newobject39["#Newobject37"] = oc_Newobject37;

            #region GuiButtonCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["Enabled"] = "1";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject38["HorizSizing"] = "left";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["Position"] = "392 3";
            oc_Newobject38["Extent"] = "43 26";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "1";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["Command"] = "PhysicsEditMessage.visible = false;";
            oc_Newobject38["hovertime"] = "1000";
            oc_Newobject38["text"] = "Hide";
            oc_Newobject38["groupNum"] = "-1";
            oc_Newobject38["buttonType"] = "PushButton";
            oc_Newobject38["useMouseEvents"] = "0";

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject57["#Newobject39"] = oc_Newobject39;

            #region GuiContainer (CameraTypesDropdown)        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiContainer", "CameraTypesDropdown");
            oc_Newobject48["Profile"] = "IconDropdownProfile";
            oc_Newobject48["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(EWorldEditorToggleCamera.position, 0)-5 SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject48["Extent"] = new ObjectCreator.StringNoQuote("\"137\" SPC ((6*28)+6)");
            oc_Newobject48["isContainer"] = "1";
            oc_Newobject48["visible"] = "0";

            #region GuiDynamicCtrlArrayControl (cameraDropdownArray)        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiDynamicCtrlArrayControl", "cameraDropdownArray");
            oc_Newobject46["canSaveDynamicFields"] = "0";
            oc_Newobject46["Enabled"] = "1";
            oc_Newobject46["isContainer"] = "1";
            oc_Newobject46["Profile"] = "ToolsGuiTransparentProfile";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "height";
            oc_Newobject46["Position"] = "5 5";
            oc_Newobject46["Extent"] =
                new ObjectCreator.StringNoQuote("\"132\" SPC getWord(CameraTypesDropdown.extent, 1)-5");
            oc_Newobject46["MinExtent"] = "8 2";
            oc_Newobject46["canSave"] = "1";
            oc_Newobject46["Visible"] = "1";
            oc_Newobject46["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject46["hovertime"] = "1000";
            oc_Newobject46["colCount"] = "1";
            oc_Newobject46["colSize"] = "127";
            oc_Newobject46["rowCount"] = "0";
            oc_Newobject46["RowSize"] = "64";
            oc_Newobject46["rowSpacing"] = "3";
            oc_Newobject46["colSpacing"] = "3";
            oc_Newobject46["autoCellSize"] = "1";
            oc_Newobject46["fillRowFirst"] = "0";

            #region GuiIconButtonCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["internalName"] = "StandardCamera";
            oc_Newobject40["Enabled"] = "1";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject40["HorizSizing"] = "right";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["Position"] = "5 5";
            oc_Newobject40["Extent"] = "127 25";
            oc_Newobject40["MinExtent"] = "8 8";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["Command"] =
                "CameraTypesDropdownToggle(); EditorGuiStatusBar.setCamera(\\\"Standard Camera\\\");";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["ToolTip"] = "Free Camera";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["iconBitmap"] = "tools/worldEditor/images/toolbar/camera_n";
            oc_Newobject40["groupNum"] = "0";
            oc_Newobject40["text"] = "Free Camera";
            oc_Newobject40["buttonMargin"] = "0 4";
            oc_Newobject40["textMargin"] = "38";
            // oc_Newobject40["groupNum"] = "0";
            oc_Newobject40["buttonType"] = "RadioButton";
            oc_Newobject40["useMouseEvents"] = "0";

            #endregion

            oc_Newobject46["#Newobject40"] = oc_Newobject40;

            #region GuiIconButtonCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["internalName"] = "OrbitCamera";
            oc_Newobject41["Enabled"] = "1";
            oc_Newobject41["isContainer"] = "0";
            oc_Newobject41["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["Position"] = "5 32";
            oc_Newobject41["Extent"] = "127 25";
            oc_Newobject41["MinExtent"] = "8 8";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["Command"] =
                "CameraTypesDropdownToggle(); EditorGuiStatusBar.setCamera(\\\"Orbit Camera\\\");";
            oc_Newobject41["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject41["ToolTip"] = "Toggle Orbit Cam";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["iconBitmap"] = "tools/gui/images/menubar/orbit-cam_n";
            oc_Newobject41["groupNum"] = "0";
            oc_Newobject41["text"] = "Orbit Camera";
            oc_Newobject41["buttonMargin"] = "0 4";
            oc_Newobject41["textMargin"] = "38";
            // oc_Newobject41["groupNum"] = "0";
            oc_Newobject41["buttonType"] = "RadioButton";
            oc_Newobject41["useMouseEvents"] = "0";

            #endregion

            oc_Newobject46["#Newobject41"] = oc_Newobject41;

            #region GuiIconButtonCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject42["canSaveDynamicFields"] = "0";
            oc_Newobject42["internalName"] = "PlayerCamera";
            oc_Newobject42["Enabled"] = "1";
            oc_Newobject42["isContainer"] = "0";
            oc_Newobject42["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject42["HorizSizing"] = "right";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["Position"] = "5 5";
            oc_Newobject42["Extent"] = "127 25";
            oc_Newobject42["MinExtent"] = "8 8";
            oc_Newobject42["canSave"] = "1";
            oc_Newobject42["Visible"] = "1";
            oc_Newobject42["Command"] =
                "CameraTypesDropdownToggle(); EditorGuiStatusBar.setCamera(\\\"1st Person Camera\\\");";
            oc_Newobject42["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject42["ToolTip"] = "Player Camera";
            oc_Newobject42["hovertime"] = "1000";
            oc_Newobject42["iconBitmap"] = "tools/worldEditor/images/toolbar/player_n";
            oc_Newobject42["groupNum"] = "0";
            oc_Newobject42["text"] = "Player Camera";
            oc_Newobject42["buttonMargin"] = "0 4";
            oc_Newobject42["textMargin"] = "38";
            //oc_Newobject42["groupNum"] = "0";
            oc_Newobject42["buttonType"] = "RadioButton";
            oc_Newobject42["useMouseEvents"] = "0";

            #endregion

            oc_Newobject46["#Newobject42"] = oc_Newobject42;

            #region GuiIconButtonCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["internalName"] = "trdPersonCamera";
            oc_Newobject43["Enabled"] = "1";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject43["HorizSizing"] = "right";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["Position"] = "5 5";
            oc_Newobject43["Extent"] = "127 25";
            oc_Newobject43["MinExtent"] = "8 8";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["Visible"] = "1";
            oc_Newobject43["Command"] =
                "CameraTypesDropdownToggle(); EditorGuiStatusBar.setCamera(\\\"3rd Person Camera\\\");";
            oc_Newobject43["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject43["ToolTip"] = "3rd Person Camera";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["iconBitmap"] = "tools/worldEditor/images/toolbar/3rd-person-camera_n";
            oc_Newobject43["groupNum"] = "0";
            oc_Newobject43["text"] = "3rd Person Cam";
            oc_Newobject43["buttonMargin"] = "0 4";
            oc_Newobject43["textMargin"] = "38";
            //oc_Newobject43["groupNum"] = "0";
            oc_Newobject43["buttonType"] = "RadioButton";
            oc_Newobject43["useMouseEvents"] = "0";

            #endregion

            oc_Newobject46["#Newobject43"] = oc_Newobject43;

            #region GuiIconButtonCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject44["canSaveDynamicFields"] = "0";
            oc_Newobject44["internalName"] = "NewtonianCamera";
            oc_Newobject44["Enabled"] = "1";
            oc_Newobject44["isContainer"] = "0";
            oc_Newobject44["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject44["HorizSizing"] = "right";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["Position"] = "5 64";
            oc_Newobject44["Extent"] = "127 25";
            oc_Newobject44["MinExtent"] = "8 8";
            oc_Newobject44["canSave"] = "1";
            oc_Newobject44["Visible"] = "1";
            oc_Newobject44["Command"] =
                "CameraTypesDropdownToggle(); EditorGuiStatusBar.setCamera(\\\"Smooth Camera\\\");";
            oc_Newobject44["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject44["ToolTip"] = "Toggle Newtonian Cam";
            oc_Newobject44["hovertime"] = "1000";
            oc_Newobject44["iconBitmap"] = "tools/gui/images/menubar/smooth-cam_n";
            oc_Newobject44["groupNum"] = "0";
            oc_Newobject44["text"] = "Smooth Camera";
            oc_Newobject44["buttonMargin"] = "0 4";
            oc_Newobject44["textMargin"] = "38";
            //oc_Newobject44["groupNum"] = "0";
            oc_Newobject44["buttonType"] = "RadioButton";
            oc_Newobject44["useMouseEvents"] = "0";

            #endregion

            oc_Newobject46["#Newobject44"] = oc_Newobject44;

            #region GuiIconButtonCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiIconButtonCtrl", "");
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["internalName"] = "NewtonianRotationCamera";
            oc_Newobject45["Enabled"] = "1";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["Profile"] = "ToolsGuiIconButtonProfile";
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["Position"] = "5 64";
            oc_Newobject45["Extent"] = "127 25";
            oc_Newobject45["MinExtent"] = "8 8";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["Command"] =
                "CameraTypesDropdownToggle(); EditorGuiStatusBar.setCamera(\\\"Smooth Rot Camera\\\");";
            oc_Newobject45["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject45["ToolTip"] = "Toggle Smooth Camera with Smooth Rotation";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["iconBitmap"] = "tools/gui/images/menubar/smooth-cam-rot_n";
            oc_Newobject45["groupNum"] = "0";
            oc_Newobject45["text"] = "Smooth Rotate";
            oc_Newobject45["buttonMargin"] = "0 4";
            oc_Newobject45["textMargin"] = "38";
            //oc_Newobject45["groupNum"] = "0";
            oc_Newobject45["buttonType"] = "RadioButton";
            oc_Newobject45["useMouseEvents"] = "0";

            #endregion

            oc_Newobject46["#Newobject45"] = oc_Newobject45;

            #endregion

            oc_Newobject48["#Newobject46"] = oc_Newobject46;

            #region GuiDecoyCtrl (CameraTypesDropdownDecoy)        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiDecoyCtrl", "CameraTypesDropdownDecoy",
                typeof (CameraTypesDropdownDecoy));
            oc_Newobject47["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject47["horizSizing"] = "right";
            oc_Newobject47["vertSizing"] = "bottom";
            oc_Newobject47["position"] = "0 0";
            oc_Newobject47["extent"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(CameraTypesDropdown.extent, 0) SPC getWord(CameraTypesDropdown.extent, 1)");
            oc_Newobject47["minExtent"] = "8 8";
            oc_Newobject47["visible"] = "1";
            oc_Newobject47["helpTag"] = "0";
            oc_Newobject47["useMouseEvents"] = "1";
            oc_Newobject47["isDecoy"] = "1";

            #endregion

            oc_Newobject48["#Newobject47"] = oc_Newobject47;

            #endregion

            oc_Newobject57["#Newobject48"] = oc_Newobject48;

            #region GuiContainer (VisibilityDropdown)        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiContainer", "VisibilityDropdown");
            oc_Newobject56["Profile"] = "IconDropdownProfile";
            oc_Newobject56["Position"] =
                new ObjectCreator.StringNoQuote(
                    "getWord(visibilityToggleBtn.position, 0)-5 SPC getWord(EditorGuiToolbar.extent, 1)-1");
            oc_Newobject56["Extent"] = "159 261";
            oc_Newobject56["isContainer"] = "1";
            oc_Newobject56["visible"] = "0";

            #region GuiTabBookCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiTabBookCtrl", "");
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject55["HorizSizing"] = "width";
            oc_Newobject55["VertSizing"] = "height";
            oc_Newobject55["Docking"] = "Client";
            oc_Newobject55["Margin"] = "3 3 3 3";
            oc_Newobject55["Position"] = "5 24";
            oc_Newobject55["Extent"] = "170 226";
            oc_Newobject55["MinExtent"] = "8 2";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["TabPosition"] = "Top";
            oc_Newobject55["TabHeight"] = "22";
            oc_Newobject55["TabMargin"] = "7";
            oc_Newobject55["MinTabWidth"] = "64";

            #region GuiTabPageCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject51["HorizSizing"] = "width";
            oc_Newobject51["VertSizing"] = "height";
            oc_Newobject51["Docking"] = "Client";
            oc_Newobject51["Margin"] = "-1 0 0 0";
            oc_Newobject51["Position"] = "0 14";
            oc_Newobject51["Extent"] = "164 220";
            oc_Newobject51["MinExtent"] = "8 2";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "0";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["text"] = "Viz Toggles";
            oc_Newobject51["maxLength"] = "255";

            #region GuiScrollCtrl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject50["canSaveDynamicFields"] = "0";
            oc_Newobject50["Enabled"] = "1";
            oc_Newobject50["isContainer"] = "1";
            oc_Newobject50["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["VertSizing"] = "height";
            oc_Newobject50["Docking"] = "Client";
            oc_Newobject50["Position"] = "4 12";
            oc_Newobject50["Extent"] = "156 190";
            oc_Newobject50["MinExtent"] = "8 2";
            oc_Newobject50["canSave"] = "1";
            oc_Newobject50["isDecoy"] = "0";
            oc_Newobject50["Visible"] = "1";
            oc_Newobject50["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject50["hovertime"] = "1000";
            oc_Newobject50["Margin"] = "0 0 0 0";
            oc_Newobject50["Padding"] = "0 0 0 0";
            oc_Newobject50["AnchorTop"] = "1";
            oc_Newobject50["AnchorBottom"] = "0";
            oc_Newobject50["AnchorLeft"] = "1";
            oc_Newobject50["AnchorRight"] = "0";
            oc_Newobject50["willFirstRespond"] = "1";
            oc_Newobject50["hScrollBar"] = "alwaysOff";
            oc_Newobject50["vScrollBar"] = "dynamic";
            oc_Newobject50["lockHorizScroll"] = "true";
            oc_Newobject50["lockVertScroll"] = "false";
            oc_Newobject50["constantThumbHeight"] = "0";
            oc_Newobject50["childMargin"] = "2 0";

            #region GuiStackControl ()        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject49["StackingType"] = "Vertical";
            oc_Newobject49["HorizStacking"] = "Left to Right";
            oc_Newobject49["VertStacking"] = "Top to Bottom";
            oc_Newobject49["Padding"] = "-2";
            oc_Newobject49["canSaveDynamicFields"] = "0";
            oc_Newobject49["internalName"] = "theVisOptionsList";
            oc_Newobject49["Enabled"] = "1";
            oc_Newobject49["isContainer"] = "1";
            oc_Newobject49["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject49["HorizSizing"] = "width";
            oc_Newobject49["VertSizing"] = "bottom";
            oc_Newobject49["Position"] = "1 0";
            oc_Newobject49["Extent"] = "156 16";
            oc_Newobject49["MinExtent"] = "16 16";
            oc_Newobject49["canSave"] = "1";
            oc_Newobject49["isDecoy"] = "0";
            oc_Newobject49["Visible"] = "1";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";

            #endregion

            oc_Newobject50["#Newobject49"] = oc_Newobject49;

            #endregion

            oc_Newobject51["#Newobject50"] = oc_Newobject50;

            #endregion

            oc_Newobject55["#Newobject51"] = oc_Newobject51;

            #region GuiTabPageCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject54["canSaveDynamicFields"] = "0";
            oc_Newobject54["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject54["HorizSizing"] = "width";
            oc_Newobject54["VertSizing"] = "height";
            oc_Newobject54["Docking"] = "Client";
            oc_Newobject54["Margin"] = "-1 0 0 0";
            oc_Newobject54["Position"] = "0 14";
            oc_Newobject54["Extent"] = "164 220";
            oc_Newobject54["MinExtent"] = "8 2";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["Visible"] = "0";
            oc_Newobject54["hovertime"] = "1000";
            oc_Newobject54["text"] = "Class Toggles";
            oc_Newobject54["maxLength"] = "255";

            #region GuiScrollCtrl ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject53["canSaveDynamicFields"] = "0";
            oc_Newobject53["Enabled"] = "1";
            oc_Newobject53["isContainer"] = "1";
            oc_Newobject53["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject53["HorizSizing"] = "width";
            oc_Newobject53["VertSizing"] = "height";
            oc_Newobject53["Docking"] = "Client";
            oc_Newobject53["Position"] = "4 12";
            oc_Newobject53["Extent"] = "156 190";
            oc_Newobject53["MinExtent"] = "8 2";
            oc_Newobject53["canSave"] = "1";
            oc_Newobject53["isDecoy"] = "0";
            oc_Newobject53["Visible"] = "1";
            oc_Newobject53["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject53["hovertime"] = "1000";
            oc_Newobject53["Margin"] = "0 0 0 0";
            oc_Newobject53["Padding"] = "0 0 0 0";
            oc_Newobject53["AnchorTop"] = "1";
            oc_Newobject53["AnchorBottom"] = "0";
            oc_Newobject53["AnchorLeft"] = "1";
            oc_Newobject53["AnchorRight"] = "0";
            oc_Newobject53["willFirstRespond"] = "1";
            oc_Newobject53["hScrollBar"] = "alwaysOff";
            oc_Newobject53["vScrollBar"] = "dynamic";
            oc_Newobject53["lockHorizScroll"] = "true";
            oc_Newobject53["lockVertScroll"] = "false";
            oc_Newobject53["constantThumbHeight"] = "0";
            oc_Newobject53["childMargin"] = "2 0";

            #region GuiStackControl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject52["StackingType"] = "Vertical";
            oc_Newobject52["HorizStacking"] = "Left to Right";
            oc_Newobject52["VertStacking"] = "Top to Bottom";
            oc_Newobject52["Padding"] = "-2";
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["internalName"] = "theClassVisList";
            oc_Newobject52["Enabled"] = "1";
            oc_Newobject52["isContainer"] = "1";
            oc_Newobject52["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject52["HorizSizing"] = "width";
            oc_Newobject52["VertSizing"] = "bottom";
            oc_Newobject52["Position"] = "1 0";
            oc_Newobject52["Extent"] = "156 16";
            oc_Newobject52["MinExtent"] = "16 16";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["isDecoy"] = "0";
            oc_Newobject52["Visible"] = "1";
            oc_Newobject52["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject52["hovertime"] = "1000";

            #endregion

            oc_Newobject53["#Newobject52"] = oc_Newobject52;

            #endregion

            oc_Newobject54["#Newobject53"] = oc_Newobject53;

            #endregion

            oc_Newobject55["#Newobject54"] = oc_Newobject54;

            #endregion

            oc_Newobject56["#Newobject55"] = oc_Newobject55;

            #endregion

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #endregion

            oc_Newobject57.Create();

            #region GuiMouseEventCtrl (CameraSpeedDropdownCtrlContainer, EditorGuiGroup)        oc_Newobject66

            ObjectCreator oc_Newobject66 = new ObjectCreator("GuiMouseEventCtrl",
                "CameraSpeedDropdownCtrlContainer, EditorGuiGroup", typeof (CameraSpeedDropdownCtrlContainer));
            oc_Newobject66["internalName"] = "AggregateControl";
            oc_Newobject66["horizSizing"] = "right";
            oc_Newobject66["vertSizing"] = "bottom";
            oc_Newobject66["position"] = "0 0";
            oc_Newobject66["extent"] = "1024 768";
            oc_Newobject66["minExtent"] = "8 8";
            oc_Newobject66["visible"] = "1";
            oc_Newobject66["helpTag"] = "0";
            //oc_Newobject66["class"] = "EditorDropdownSliderContainer";

            #region GuiContainer ()        oc_Newobject65

            ObjectCreator oc_Newobject65 = new ObjectCreator("GuiContainer", "");
            oc_Newobject65["position"] =
                new ObjectCreator.StringNoQuote(
                    "firstWord(CameraSpeedDropdownContainer.position) + firstWord(EditorGuiToolbar.position) + -6 SPC             (getWord(CameraSpeedDropdownContainer, 1)) + 31");
            oc_Newobject65["extent"] = "146 39";
            oc_Newobject65["isContainer"] = "1";
            oc_Newobject65["Profile"] = "IconDropdownProfile";
            oc_Newobject65["HorizSizing"] = "right";
            oc_Newobject65["VertSizing"] = "bottom";

            #region GuiBitmapCtrl ()        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject58["position"] = "105 15";
            oc_Newobject58["extent"] = "2 8";
            oc_Newobject58["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject58["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject58["HorizSizing"] = "right";
            oc_Newobject58["VertSizing"] = "bottom";

            #endregion

            oc_Newobject65["#Newobject58"] = oc_Newobject58;

            #region GuiBitmapCtrl ()        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject59["position"] = "73 15";
            oc_Newobject59["extent"] = "2 8";
            oc_Newobject59["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject59["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject59["HorizSizing"] = "right";
            oc_Newobject59["VertSizing"] = "bottom";

            #endregion

            oc_Newobject65["#Newobject59"] = oc_Newobject59;

            #region GuiBitmapCtrl ()        oc_Newobject60

            ObjectCreator oc_Newobject60 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject60["position"] = "41 15";
            oc_Newobject60["extent"] = "2 8";
            oc_Newobject60["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject60["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject60["HorizSizing"] = "right";
            oc_Newobject60["VertSizing"] = "bottom";

            #endregion

            oc_Newobject65["#Newobject60"] = oc_Newobject60;

            #region GuiSliderCtrl ()        oc_Newobject61

            ObjectCreator oc_Newobject61 = new ObjectCreator("GuiSliderCtrl", "");
            oc_Newobject61["internalName"] = "slider";
            oc_Newobject61["position"] = "9 17";
            oc_Newobject61["extent"] = "129 15";
            oc_Newobject61["bitmap"] = "tools/gui/images/separator-h.png";
            oc_Newobject61["HorizSizing"] = "width";
            oc_Newobject61["VertSizing"] = "bottom";
            oc_Newobject61["range"] = "1 200";
            oc_Newobject61["ticks"] = "0";
            oc_Newobject61["value"] = "100";
            oc_Newobject61["AltCommand"] = "EWorldEditorCameraSpeed.updateMenuBar( $ThisControl );";

            #endregion

            oc_Newobject65["#Newobject61"] = oc_Newobject61;

            #region GuiTextCtrl ()        oc_Newobject62

            ObjectCreator oc_Newobject62 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject62["internalName"] = "text";
            oc_Newobject62["position"] = "54 3";
            oc_Newobject62["extent"] = "39 18";
            oc_Newobject62["text"] = "Normal";
            oc_Newobject62["Profile"] = "ToolsGuiTextCenterProfile";
            oc_Newobject62["HorizSizing"] = "right";
            oc_Newobject62["VertSizing"] = "bottom";

            #endregion

            oc_Newobject65["#Newobject62"] = oc_Newobject62;

            #region GuiTextCtrl ()        oc_Newobject63

            ObjectCreator oc_Newobject63 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject63["position"] = "11 2";
            oc_Newobject63["extent"] = "39 18";
            oc_Newobject63["text"] = "-";
            oc_Newobject63["Profile"] = "ToolsGuiTextProfile";
            oc_Newobject63["HorizSizing"] = "right";
            oc_Newobject63["VertSizing"] = "bottom";

            #endregion

            oc_Newobject65["#Newobject63"] = oc_Newobject63;

            #region GuiTextCtrl ()        oc_Newobject64

            ObjectCreator oc_Newobject64 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject64["position"] = "98 5";
            oc_Newobject64["extent"] = "39 13";
            oc_Newobject64["text"] = "+";
            oc_Newobject64["Profile"] = "ToolsGuiTextRightProfile";
            oc_Newobject64["HorizSizing"] = "right";
            oc_Newobject64["VertSizing"] = "bottom";

            #endregion

            oc_Newobject65["#Newobject64"] = oc_Newobject64;

            #endregion

            oc_Newobject66["#Newobject65"] = oc_Newobject65;

            #endregion

            oc_Newobject66.Create();
            }

        [ConsoleInteraction(true, "EditorPrefs_initialize")]
        public static void editorPrefsInitialize()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("WorldEditor", true);
            EditorSettings.setDefaultValue("currentEditor", "WorldEditorInspectorPlugin");
            EditorSettings.setDefaultValue("dropType", "screenCenter");
            EditorSettings.setDefaultValue("undoLimit", "40");
            EditorSettings.setDefaultValue("forceLoadDAE", "0");
            EditorSettings.setDefaultValue("displayType", omni.sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
            EditorSettings.setDefaultValue("orthoFOV", "50");
            EditorSettings.setDefaultValue("orthoShowGrid", "1");
            EditorSettings.setDefaultValue("currentEditor", "WorldEditorInspectorPlugin");
            EditorSettings.setDefaultValue("newLevelFile", "tools/levels/BlankRoom.mis");

            if (omni.Util.isFile("C:/Program Files/Torsion/Torsion.exe"))
                EditorSettings.setDefaultValue("torsionPath", "C:/Program Files/Torsion/Torsion.exe");
            else if (omni.Util.isFile("C:/Program Files (x86)/Torsion/Torsion.exe"))
                EditorSettings.setDefaultValue("torsionPath", "C:/Program Files (x86)/Torsion/Torsion.exe");
            else
                EditorSettings.setDefaultValue("torsionPath", "");

            EditorSettings.beginGroup("ObjectIcons");
            EditorSettings.setDefaultValue("fadeIcons", "1");
            EditorSettings.setDefaultValue("fadeIconsStartDist", "8");
            EditorSettings.setDefaultValue("fadeIconsEndDist", "20");
            EditorSettings.setDefaultValue("fadeIconsStartAlpha", "255");
            EditorSettings.setDefaultValue("fadeIconsEndAlpha", "0");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Grid");
            EditorSettings.setDefaultValue("gridSize", "1");
            EditorSettings.setDefaultValue("gridSnap", "0");
            EditorSettings.setDefaultValue("gridColor", "102 102 102 100");
            EditorSettings.setDefaultValue("gridOriginColor", "255 255 255 100");
            EditorSettings.setDefaultValue("gridMinorColor", "51 51 51 100");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Tools");
            EditorSettings.setDefaultValue("snapGround", "0");
            EditorSettings.setDefaultValue("snapSoft", "0");
            EditorSettings.setDefaultValue("snapSoftSize", "2.0");
            EditorSettings.setDefaultValue("boundingBoxCollision", "0");
            EditorSettings.setDefaultValue("objectsUseBoxCenter", "1");
            EditorSettings.setDefaultValue("dropAtScreenCenterScalar", "1.0");
            EditorSettings.setDefaultValue("dropAtScreenCenterMax", "100.0");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Render");
            EditorSettings.setDefaultValue("renderObjHandle", "1");
            EditorSettings.setDefaultValue("renderObjText", "1");
            EditorSettings.setDefaultValue("renderPopupBackground", "1");
            EditorSettings.setDefaultValue("renderSelectionBox", "1"); //<-- Does not currently render
            EditorSettings.setDefaultValue("showMousePopupInfo", "1");
            //EditorSettings.setDefaultValue(  "visibleDistanceScale",    "1"               );
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Color");
            EditorSettings.setDefaultValue("dragRectColor", "255 255 0 255");
            EditorSettings.setDefaultValue("objectTextColor", "255 255 255 255");
            EditorSettings.setDefaultValue("objMouseOverColor", "0 255 0 255");
            //<-- Currently ignored by editor (always white)
            EditorSettings.setDefaultValue("objMouseOverSelectColor", "0 0 255 255");
            //<-- Currently ignored by editor (always white)
            EditorSettings.setDefaultValue("objSelectColor", "255 0 0 255");
            //<-- Currently ignored by editor (always white)
            EditorSettings.setDefaultValue("popupBackgroundColor", "100 100 100 255");
            EditorSettings.setDefaultValue("popupTextColor", "255 255 0 255");
            EditorSettings.setDefaultValue("raceSelectColor", "0 0 100 100"); //<-- What is this used for?
            EditorSettings.setDefaultValue("selectionBoxColor", "255 255 0 255"); //<-- Does not currently render
            EditorSettings.setDefaultValue("uvEditorHandleColor", "1"); //<-- Index into color popup
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Images");
            EditorSettings.setDefaultValue("defaultHandle", "tools/worldEditor/images/DefaultHandle");
            EditorSettings.setDefaultValue("lockedHandle", "tools/worldEditor/images/LockedHandle");
            EditorSettings.setDefaultValue("selectHandle", "tools/worldEditor/images/SelectHandle");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Docs");
            EditorSettings.setDefaultValue("documentationLocal", "../../../Documentation/Official Documentation.html");
            EditorSettings.setDefaultValue("documentationReference",
                "../../../Documentation/Torque 3D - Script Manual.chm");
            EditorSettings.setDefaultValue("documentationURL",
                "http://www.garagegames.com/products/torque-3d/documentation/user");
            EditorSettings.setDefaultValue("forumURL", "http://www.garagegames.com/products/torque-3d/forums");
            EditorSettings.endGroup();

            EditorSettings.endGroup(); // WorldEditor

            //-------------------------------------

            // After setting up the default value, this field should be altered immediately
            // after successfully using such functionality such as Open... or Save As...
            EditorSettings.beginGroup("LevelInformation");
            EditorSettings.setDefaultValue("levelsDirectory", "levels");
            EditorSettings.endGroup();

            //-------------------------------------

            EditorSettings.beginGroup("AxisGizmo", true);

            EditorSettings.setDefaultValue("axisGizmoMaxScreenLen", "100"); //<-- What is this used for?
            EditorSettings.setDefaultValue("rotationSnap", "15"); //<-- Not currently used
            EditorSettings.setDefaultValue("snapRotations", "0"); //<-- Not currently used
            EditorSettings.setDefaultValue("mouseRotateScalar", "0.8");
            EditorSettings.setDefaultValue("mouseScaleScalar", "0.8");
            EditorSettings.setDefaultValue("renderWhenUsed", "0");
            EditorSettings.setDefaultValue("renderInfoText", "1");

            EditorSettings.beginGroup("Grid");
            EditorSettings.setDefaultValue("gridColor", "255 255 255 20");
            EditorSettings.setDefaultValue("gridSize", "10 10 10");
            EditorSettings.setDefaultValue("snapToGrid", "0"); //<-- Not currently used
            EditorSettings.setDefaultValue("renderPlane", "0");
            EditorSettings.setDefaultValue("renderPlaneHashes", "0");
            EditorSettings.setDefaultValue("planeDim", "500");
            EditorSettings.endGroup();

            EditorSettings.endGroup();

            //-------------------------------------

            EditorSettings.beginGroup("TerrainEditor", true);

            EditorSettings.setDefaultValue("currentAction", "raiseHeight");

            EditorSettings.beginGroup("Brush");
            EditorSettings.setDefaultValue("maxBrushSize", "40 40");
            EditorSettings.setDefaultValue("brushSize", "1 1");
            EditorSettings.setDefaultValue("brushType", "box");
            EditorSettings.setDefaultValue("brushPressure", "1");
            EditorSettings.setDefaultValue("brushSoftness", "1");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("ActionValues");
            EditorSettings.setDefaultValue("adjustHeightVal", "10");
            EditorSettings.setDefaultValue("setHeightVal", "100");
            EditorSettings.setDefaultValue("scaleVal", "1"); //<-- Tool not currently implemented
            EditorSettings.setDefaultValue("smoothFactor", "0.1");
            EditorSettings.setDefaultValue("noiseFactor", "1.0");
            EditorSettings.setDefaultValue("softSelectRadius", "50");
            EditorSettings.setDefaultValue("softSelectFilter",
                "1.000000 0.833333 0.666667 0.500000 0.333333 0.166667 0.000000");
            EditorSettings.setDefaultValue("softSelectDefaultFilter",
                "1.000000 0.833333 0.666667 0.500000 0.333333 0.166667 0.000000");
            EditorSettings.setDefaultValue("slopeMinAngle", "0");
            EditorSettings.setDefaultValue("slopeMaxAngle", "90");
            EditorSettings.endGroup();

            EditorSettings.endGroup();

            //-------------------------------------

            EditorSettings.beginGroup("TerrainPainter", true);
            EditorSettings.endGroup();

            //-------------------------------------

            setDefault("$pref::WorldEditor::visibleDistanceScale", "1");
            // DAW: Keep this around for now as is used by EditTSCtrl
            }

        [ConsoleInteraction]
        public static void setDefault(string name, string value)
            {
            if (!omni.Util.isDefined(name))
                omni.Util.eval(name + ' ' + "=" + ' ' + "\"" + value + "\";");
            }

        [ConsoleInteraction]
        public static void DeactivateAll()
            {
            WorldEditorInspectorPlugin WorldEditorInspectorPlugin = "WorldEditorInspectorPlugin";
            TerrainPainterPlugin TerrainPainterPlugin = "TerrainPainterPlugin";
            ShapeEditorPlugin ShapeEditorPlugin = "ShapeEditorPlugin";
            MeshRoadEditorPlugin MeshRoadEditorPlugin = "MeshRoadEditorPlugin";
            RoadEditorPlugin RoadEditorPlugin = "RoadEditorPlugin";
            RiverEditorPlugin RiverEditorPlugin = "RiverEditorPlugin";
            ParticleEditorPlugin ParticleEditorPlugin = "ParticleEditorPlugin";
            MissionAreaEditorPlugin MissionAreaEditorPlugin = "MissionAreaEditorPlugin";
            ForestEditorPlugin ForestEditorPlugin = "ForestEditorPlugin";
            DecalEditorPlugin DecalEditorPlugin = "DecalEditorPlugin";
            DatablockEditorPlugin DatablockEditorPlugin = "DatablockEditorPlugin";
            MaterialEditorPlugin MaterialEditorPlugin = "MaterialEditorPlugin";

            WorldEditorInspectorPlugin.onDeactivated();
            TerrainPainterPlugin.onDeactivated();
            ShapeEditorPlugin.onDeactivated();
            MeshRoadEditorPlugin.onDeactivated();
            RoadEditorPlugin.onDeactivated();
            RiverEditorPlugin.onDeactivated();
            ParticleEditorPlugin.onDeactivated();
            MissionAreaEditorPlugin.onDeactivated();
            ForestEditorPlugin.onDeactivated();
            DecalEditorPlugin.onDeactivated();
            DatablockEditorPlugin.onDeactivated();
            MaterialEditorPlugin.onDeactivated();
            }

        [ConsoleInteraction]
        public void init()
            {
            //EWTreeWindow EWTreeWindow = "EWTreeWindow";
            //EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
            //GuiControl EWorldEditorToolbar = "EWorldEditorToolbar";
            //GuiControl EWTerrainEditToolbar = "EWTerrainEditToolbar";
            //GuiControl EWTerrainPainterToolbar = "EWTerrainPainterToolbar";
            //EWToolsToolbar EWToolsToolbar = "EWToolsToolbar";
            //EVisibility EVisibility = "EVisibility";
            //GuiTabBookCtrl EVisibilityTabBook = "EVisibilityTabBook";
            //ESettingsWindow ESettingsWindow = "ESettingsWindow";
            //GuiTabPageCtrl EGeneralSettingsPage = "EGeneralSettingsPage";
            //GuiTabPageCtrl EObjectEditorSettingsPage = "EObjectEditorSettingsPage";
            //GuiTabPageCtrl EAxisGizmoSettingsPage = "EAxisGizmoSettingsPage";
            //GuiTabPageCtrl ETerrainEditorSettingsPage = "ETerrainEditorSettingsPage";
            //GuiTabPageCtrl ECameraSettingsPage = "ECameraSettingsPage";
            //ESnapOptions ESnapOptions = "ESnapOptions";
            //GuiTabBookCtrl ESnapOptionsTabBook = "ESnapOptionsTabBook";
            //ETransformSelection ETransformSelection = "ETransformSelection";
            //EManageBookmarks EManageBookmarks = "EManageBookmarks";
            //GuiWindowCollapseCtrl EManageSFXParameters = "EManageSFXParameters";
            //ESelectObjectsWindow ESelectObjectsWindow = "ESelectObjectsWindow";
            //Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";
            //objectBuilderGui ObjectBuilderGui = "ObjectBuilderGui";
            //EWorldEditor.EWorldEditorToggleCamera EWorldEditorToggleCamera = "EWorldEditorToggleCamera";
            //GuiPopUpMenuCtrl EWorldEditorAlignPopup = "EWorldEditorAlignPopup";
            //GuiContainer CameraTypesDropdown = "CameraTypesDropdown";
            //GuiContainer VisibilityDropdown = "VisibilityDropdown";
            //objectTransformDropdown objectTransformDropdown = "objectTransformDropdown";
            //objectCenterDropdown objectCenterDropdown = "objectCenterDropdown";
            ////TODO not present
            //GuiContainer objectSnapDropdown = "objectSnapDropdown";
            //SimSet EditorPluginSet = "EditorPluginSet";

            //EWToolsPaletteWindow ToolsPaletteWindow = this.FOT("ToolsPaletteWindow");
            //GuiWindowCollapseCtrl TreeWindow = this.FOT("TreeWindow");
            //GuiWindowCollapseCtrl InspectorWindow = this.FOT("InspectorWindow");
            //GuiControl WorldEditorToolbar = this.FOT("WorldEditorToolbar");
            //GuiControl TerrainEditToolbar = this.FOT("TerrainEditToolbar");
            //TerrainPainter TerrainPainter = this.FOT("TerrainPainter");
            //GuiControl TerrainPainterToolbar = this.FOT("TerrainPainterToolbar");
            //GuiContainer ToolsToolbar = this.FOT("ToolsToolbar");
            //EVisibility VisibilityLayerWindow = this.FOT("VisibilityLayerWindow");
            //ESettingsWindow EditorSettingsWindow = this.FOT("EditorSettingsWindow");
            //ESnapOptions SnapOptionsWindow = this.FOT("SnapOptionsWindow");
            //GuiWindowCollapseCtrl TransformSelectionWindow = this.FOT("TransformSelectionWindow");
            //EManageBookmarks ManageBookmarksWindow = this.FOT("ManageBookmarksWindow");
            //GuiWindowCollapseCtrl ManageSFXParametersWindow = this.FOT("ManageSFXParametersWindow");
            //ESelectObjectsWindow SelectObjectsWindow = this.FOT("SelectObjectsWindow");
            //GuiTabBookCtrl EditorTree = EWTreeWindow.FOT("EditorTree");


            EWorldEditor EWorldEditor = "EWorldEditor";
            TerrainEditor ETerrainEditor = "ETerrainEditor";
            EWorldEditor["isDirty"] = false.AsString();
            ETerrainEditor["isDirty"] = false.AsString();
            ETerrainEditor["isMissionDirty"] = false.AsString();

            if (this.isInitialized)
                return;

            this.readWorldEditorSettings();

            iGlobal["$SelectedOperation"] = -1;
            iGlobal["$NextOperationId"] = 1;
            iGlobal["$HeightfieldDirtyRow"] = -1;

            this.buildMenus();

            if (!FOT("ToolsPaletteWindow").isObject())
                {
                Tools.WorldEditor.gui.ToolsPaletteWindow.initialize();
                EWToolsPaletteWindow EWToolsPaletteWindow = "EWToolsPaletteWindow";
                if (EWToolsPaletteWindow.isObject())
                    {
                    this.add(EWToolsPaletteWindow);
                    EWToolsPaletteWindow.init();
                    EWToolsPaletteWindow.setVisible(false);
                    }
                }

            if (!FOT("TreeWindow").isObject())
                {
                // Load Creator/Inspector GUI
                //WLECONVERT
                //exec("~/worldEditor/gui/WorldEditorTreeWindow.ed.gui");
                //console.Call("WorldEditorTreeWindow_initialize");      
                WorldEditorTreeWindow.initialize();
                EWTreeWindow EWTreeWindow = "EWTreeWindow";
                GuiTabBookCtrl EditorTree = EWTreeWindow.FOT("EditorTree");
                if (EWTreeWindow.isObject())
                    {
                    this.add(EWTreeWindow);
                    EditorTree.selectPage(0);
                    EWTreeWindow.setVisible(false);
                    }
                }

            if (!FOT("InspectorWindow").isObject())
                {
                // Load Creator/Inspector GUI
                //WLECONVERT      
                //exec("~/worldEditor/gui/WorldEditorInspectorWindow.ed.gui");
                //console.Call("WorldEditorInspectorWindow_initialize");
                WorldEditorInspectorWindow.initialize();
                EWInspectorWindow EWInspectorWindow = "EWInspectorWindow";
                //EWInspectorWindow.resize(getWord(EWInspectorWindow.Position, 0), getWord(EWInspectorWindow.Position, 1), getWord(EWInspectorWindow.extent, 0), getWord(EWInspectorWindow.extent, 1));
                if (EWInspectorWindow.isObject())
                    {
                    this.add(EWInspectorWindow);
                    EWInspectorWindow.setVisible(false);
                    }
                }

            if (!FOT("WorldEditorToolbar").isObject())
                {
                // Load Creator/Inspector GUI
                //WLECONVERT
                //exec("~/worldEditor/gui/WorldEditorToolbar.ed.gui");
                //console.Call("WorldEditorToolbar_initialize");
                WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.WorldEditorToolbar.initialize();
                GuiControl EWorldEditorToolbar = "EWorldEditorToolbar";
                if (EWorldEditorToolbar.isObject())
                    {
                    this.add(EWorldEditorToolbar);
                    EWorldEditorToolbar.setVisible(false);
                    }
                }

            if (!FOT("TerrainEditToolbar").isObject())
                {
                // Load Terrain Edit GUI
                //WLECONVERT
                //exec("~/worldEditor/gui/TerrainEditToolbar.ed.gui");
                //console.Call("TerrainEditToolbar_initialize");
                Tools.WorldEditor.gui.TerrainEditToolbar.initialize();
                GuiControl EWTerrainEditToolbar = "EWTerrainEditToolbar";
                if (EWTerrainEditToolbar.isObject())
                    {
                    this.add(EWTerrainEditToolbar);
                    EWTerrainEditToolbar.setVisible(false);
                    }
                }

            if (!FOT("TerrainPainter").isObject())
                {
                // Load Terrain Painter GUI
                //WLECONVERT   
                //exec("~/worldEditor/gui/TerrainPainterWindow.ed.gui");
                GuiControl guiContent = TerrainPainterWindow.initialize();
                // console.Call("TerrainPainterWindow_initialize");

                if (guiContent.isObject())
                    {
                    TerrainPainter TerrainPainter = guiContent.FOF("TerrainPainter");
                    GuiWindowCollapseCtrl TerrainPainterPreview = guiContent.FOF("TerrainPainterPreview");
                    this.add(TerrainPainter);
                    this.add(TerrainPainterPreview);
                    }

                //WLECONVERT   
                //exec("~/worldEditor/gui/guiTerrainMaterialDlg.ed.gui"); 
                //console.Call("guiTerrainMaterialDlg_initialize");
                guiTerrainMaterialDlg.initialize();


                //WLECONVERT   
                //exec("~/worldEditor/gui/TerrainBrushSoftnessCurveDlg.ed.gui");        
                //console.Call("TerrainBrushSoftnessCurveDlg_initialize");
                TerrainBrushSoftnessCurveDlg.initialize();
                }
            if (!FOT("TerrainPainterToolbar").isObject())
                {
                // Load Terrain Edit GUI
                //WLECONVERT   
                //exec("~/worldEditor/gui/TerrainPainterToolbar.ed.gui");
                //console.Call("TerrainPainterToolbar_initialize");
                Tools.WorldEditor.gui.TerrainPainterToolbar.initialize();
                GuiControl EWTerrainPainterToolbar = "EWTerrainPainterToolbar";
                if (EWTerrainPainterToolbar.isObject())
                    {
                    this.add(EWTerrainPainterToolbar);
                    EWTerrainPainterToolbar.setVisible(false);
                    }
                }

            if (!FOT("ToolsToolbar").isObject())
                {
                // Load Creator/Inspector GUI
                //WLECONVERT   
                //exec("~/worldEditor/gui/ToolsToolbar.ed.gui");
                //console.Call("ToolsToolbar_initialize");
                Tools.WorldEditor.gui.ToolsToolbar.initialize();
                EWToolsToolbar EWToolsToolbar = "EWToolsToolbar";
                if (EWToolsToolbar.isObject())
                    {
                    this.add(EWToolsToolbar);
                    EWToolsToolbar.setVisible(true);
                    }
                }

            // Visibility Layer Window
            if (!FOT("VisibilityLayerWindow").isObject())
                {
                EVisibility EVisibility = "EVisibility";
                GuiTabBookCtrl EVisibilityTabBook = "EVisibilityTabBook";
                this.add(EVisibility);
                EVisibility.setVisible(false);
                EVisibilityTabBook.selectPage(0);
                }

            // Editor Settings Window
            ESettingsWindow ESettingsWindow = "ESettingsWindow";
            if (!FOT("EditorSettingsWindow").isObject())
                {
                //WLECONVERT
                //exec("~/worldEditor/gui/EditorSettingsWindow.ed.gui");
                //console.Call("EditorSettingsWindow_initialize");
                Tools.WorldEditor.gui.EditorSettingsWindow.initialize();

                //Util.exec("~/worldEditor/scripts/editorSettingsWindow.ed.cs", false, false);
                ESettingsWindow = "ESettingsWindow";
                this.add(ESettingsWindow);
                ESettingsWindow.setVisible(false);

                // Start the standard settings tabs pages
                //WLECONVERT
                //exec( "~/worldEditor/gui/GeneralSettingsTab.ed.gui" );
                //console.Call("GeneralSettingsTab_initialize");
                GeneralSettingsTab.initialize();
                GuiTabPageCtrl EGeneralSettingsPage = "EGeneralSettingsPage";
                ESettingsWindow.addTabPage(EGeneralSettingsPage);

                //WLECONVERT
                //exec("~/worldEditor/gui/ObjectEditorSettingsTab.ed.gui");
                //console.Call("ObjectEditorSettingsTab_initialize");
                ObjectEditorSettingsTab.initialize();
                GuiTabPageCtrl EObjectEditorSettingsPage = "EObjectEditorSettingsPage";

                ESettingsWindow.addTabPage(EObjectEditorSettingsPage);

                //WLECONVERT
                //exec("~/worldEditor/gui/AxisGizmoSettingsTab.ed.gui");
                //console.Call("AxisGizmoSettingsTab_initialize");
                AxisGizmoSettingsTab.initialize();
                GuiTabPageCtrl EAxisGizmoSettingsPage = "EAxisGizmoSettingsPage";
                ESettingsWindow.addTabPage(EAxisGizmoSettingsPage);

                //WLECONVERT
                //exec("~/worldEditor/gui/TerrainEditorSettingsTab.ed.gui");
                //console.Call("TerrainEditorSettingsTab_initialize");
                TerrainEditorSettingsTab.initialize();
                GuiTabPageCtrl ETerrainEditorSettingsPage = "ETerrainEditorSettingsPage";

                ESettingsWindow.addTabPage(ETerrainEditorSettingsPage);

                //WLECONVERT
                //console.Call("CameraSettingsTab_initialize");
                CameraSettingsTab.initialize();
                //exec("~/worldEditor/gui/CameraSettingsTab.ed.gui");
                GuiTabPageCtrl ECameraSettingsPage = "ECameraSettingsPage";

                ESettingsWindow.addTabPage(ECameraSettingsPage);
                }

            // Object Snap Options Window
            if (!FOT("SnapOptionsWindow").isObject())
                {
                //WLECONVERT
                //exec("~/worldEditor/gui/ObjectSnapOptionsWindow.ed.gui");
                //console.Call("ObjectSnapOptionsWindow_initialize");
                ObjectSnapOptionsWindow.initialize();

                //Util.exec("~/worldEditor/scripts/objectSnapOptions.ed.cs", false, false);
                GuiTabBookCtrl ESnapOptionsTabBook = "ESnapOptionsTabBook";
                ESnapOptions ESnapOptions = "ESnapOptions";
                this.add(ESnapOptions);
                ESnapOptions.setVisible(false);
                ESnapOptionsTabBook.selectPage(0);
                }

            // Transform Selection Window
            if (!FOT("TransformSelectionWindow").isObject())
                {
                //WLECONVERT
                //exec("~/worldEditor/gui/TransformSelectionWindow.ed.gui");
                //console.Call("TransformSelectionWindow_initialize");
                Tools.WorldEditor.gui.TransformSelectionWindow.initialize();

                //Util.exec("~/worldEditor/scripts/transformSelection.ed.cs", false, false);
                ETransformSelection ETransformSelection = "ETransformSelection";
                this.add(ETransformSelection);
                ETransformSelection.setVisible(false);
                }

            // Manage Bookmarks Window
            if (!FOT("ManageBookmarksWindow").isObject())
                {
                EManageBookmarks EManageBookmarks = "EManageBookmarks";
                this.add(EManageBookmarks);
                EManageBookmarks.setVisible(false);
                }

            // Manage SFXParameters Window
            if (!FOT("ManageSFXParametersWindow").isObject())
                {
                GuiWindowCollapseCtrl EManageSFXParameters = "EManageSFXParameters";
                this.add(EManageSFXParameters);
                EManageSFXParameters.setVisible(false);
                }

            // Select Objects Window
            if (!FOT("SelectObjectsWindow").isObject())
                {
                ESelectObjectsWindow ESelectObjectsWindow = "ESelectObjectsWindow";
                this.add(ESelectObjectsWindow);
                ESelectObjectsWindow.setVisible(false);
                }

            EWorldEditor.init();
            ETerrainEditor.init();

            //Creator.init();
            Creator.EWCreatorWindow EWCreatorWindow = "EWCreatorWindow";
            EWCreatorWindow.init();
            objectBuilderGui ObjectBuilderGui = "ObjectBuilderGui";
            ObjectBuilderGui.init();

            this.setMenuDefaultState();
            EWorldEditor.EWorldEditorToggleCamera EWorldEditorToggleCamera = "EWorldEditorToggleCamera";
            EWorldEditorToggleCamera.setBitmap("tools/worldEditor/images/toolbar/player");

            /*
            EWorldEditorCameraSpeed.clear();
            EWorldEditorCameraSpeed.add("Slowest - Camera 1",0);
            EWorldEditorCameraSpeed.add("Slow - Camera 2",1);
            EWorldEditorCameraSpeed.add("Slower - Camera 3",2);
            EWorldEditorCameraSpeed.add("Normal - Camera 4",3);
            EWorldEditorCameraSpeed.add("Faster - Camera 5",4);
            EWorldEditorCameraSpeed.add("Fast - Camera 6",5);
            EWorldEditorCameraSpeed.add("Fastest - Camera 7",6);
            EWorldEditorCameraSpeed.setSelected(3);
            */
            GuiPopUpMenuCtrl EWorldEditorAlignPopup = "EWorldEditorAlignPopup";
            EWorldEditorAlignPopup.clear();
            EWorldEditorAlignPopup.add("World", 0);
            EWorldEditorAlignPopup.add("Object", 1);
            EWorldEditorAlignPopup.setSelected(0);


            // sync camera gui
            this.syncCameraGui();

            // this will brind CameraTypesDropdown to front so that it goes over the menubar
            GuiContainer CameraTypesDropdown = "CameraTypesDropdown";
            this.pushToBack(CameraTypesDropdown);
            GuiContainer VisibilityDropdown = "VisibilityDropdown";
            this.pushToBack(VisibilityDropdown);

            // dropdowns out so that they display correctly in editor gui
            objectTransformDropdown objectTransformDropdown = "objectTransformDropdown";
            objectTransformDropdown["parentGroup"] = "editorGui";
            objectCenterDropdown objectCenterDropdown = "objectCenterDropdown";
            objectCenterDropdown["parentGroup"] = "editorGui";
            GuiContainer objectSnapDropdown = "objectSnapDropdown";
            objectSnapDropdown["parentGroup"] = "editorGui";

            // make sure to show the default world editor guis
            this.bringToFront(EWorldEditor);
            EWorldEditor.setVisible(false);

            // Call the startup callback on the editor plugins.   
            SimSet EditorPluginSet = "EditorPluginSet";
            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin obj = EditorPluginSet.getObject(i);
                obj.onWorldEditorStartup();
                }

            // With everything loaded, start up the settings window
            //ESettingsWindow ESettingsWindow = "ESettingsWindow";
            ESettingsWindow.startup();

            // Start up initial editor plugin.

            string initialEditor = this.currentEditor; // Read from prefs.
            this.currentEditor = "";

            if (initialEditor == "")
                initialEditor = "WorldEditorInspectorPlugin";
            this.setEditor(initialEditor, true);

            // Done.

            this.isInitialized = true;
            }

        //------------------------------------------------------------------------------
        // Editor Gui's interactions with Camera Settings
        [ConsoleInteraction]
        public void setupDefaultCameraSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("LevelInformation/levels/" + this["levelName"]);

            EditorSettings.setDefaultValue("cameraSpeedMin", "5");
            EditorSettings.setDefaultValue("cameraSpeedMax", "200");

            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void readCameraSettings(string levelName)
            {
            MenuHandlers.EditorCameraSpeedMenu EditorCameraSpeedOptions = "EditorCameraSpeedOptions";
            if (levelName != this["levelName"])
                return;

            EditorCameraSpeedOptions.setupGuiControls();
            }

        [ConsoleInteraction]
        public void writeCameraSettings()
            {
            Settings EditorSettings = "EditorSettings";

            EditorSettings.beginGroup("LevelInformation/levels/" + this["levelName"]);

            EditorSettings.setValue("cameraSpeed", fGlobal["$Camera::movementSpeed"].AsString());

            EditorSettings.endGroup();
            }

        //------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void shutdown()
            {
            SimSet EditorPluginSet = "EditorPluginSet";

            // Store settings.
            this.writeWorldEditorSettings();

            // Deactivate current editor.
            this.setEditor("", true);

            // Call the shutdown callback on the editor plugins.   
            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin plugin = EditorPluginSet.getObject(i);
                plugin.onWorldEditorShutdown();
                }
            }

        /// This is used to add an editor to the Editors menu which
        /// will take over the default world editor window.
        [ConsoleInteraction]
        public string addToEditorsMenu(string displayName, string accel, EditorPlugin newPlugin)
            {
            MenuBuilder windowMenu = this.findMenu("Editors");
            int count = windowMenu.getItemCount();


            bool alreadyExists = false;
            for (int i = 0; i < count; i++)
                {
                EditorPlugin existingPlugins = Util.getField(windowMenu["Item[" + i + "]"], 2);

                if (newPlugin == existingPlugins)
                    alreadyExists = true;
                }

            if (accel == "" && count < 9)
                accel = "F" + (count + 1);
            else
                accel = "";

            if (!alreadyExists)
                windowMenu.addItem(count.AsString(), displayName + '\t' + accel + '\t' + newPlugin.getName());

            return accel;
            }

        [ConsoleInteraction]
        public void addToToolsToolbar(string pluginName, string internalName, string bitmap, string tooltip)
            {
            GuiDynamicCtrlArrayControl ToolsToolbarArray = "ToolsToolbarArray";

            int count = ToolsToolbarArray.getCount();

            bool alreadyExists = false;
            for (uint i = 0; i < count; i++)
                {
                string existingInternalName =
                    ((SimObject) ToolsToolbarArray.getObject(i)).getFieldValue("internalName", -1);

                if (internalName == existingInternalName)
                    {
                    alreadyExists = true;
                    break;
                    }
                }

            if (!alreadyExists)
                {
                ObjectCreator ocf = new ObjectCreator("GuiBitmapButtonCtrl", "btn_" + internalName);
                ocf["canSaveDynamicFields"] = "0";
                ocf["internalName"] = internalName;
                ocf["Enabled"] = "1";
                ocf["isContainer"] = "0";
                ocf["Profile"] = "ToolsGuiButtonProfile";
                ocf["HorizSizing"] = "right";
                ocf["VertSizing"] = "bottom";
                ocf["position"] = "180 0";
                ocf["Extent"] = "25 19";
                ocf["MinExtent"] = "8 2";
                ocf["canSave"] = "1";
                ocf["Visible"] = "1";
                ocf["Command"] = "EditorGui.setEditor(" + pluginName + ");";
                ocf["tooltipprofile"] = "ToolsGuiToolTipProfile";
                ocf["ToolTip"] = tooltip;
                ocf["hovertime"] = "750";
                ocf["bitmap"] = bitmap;
                ocf["buttonType"] = "RadioButton";
                ocf["groupNum"] = "0";
                ocf["useMouseEvents"] = "0";

                GuiBitmapButtonCtrl button = ocf.Create();
                ToolsToolbarArray.add(button);
                }
            }

        //-----------------------------------------------------------------------------
        [ConsoleInteraction]
        public void setDisplayType(string type)
            {
            GameConnection LocalClientConnection = "LocalClientConnection";

            EditTSCtrl gui = this.currentEditor["editorGui"];
            if (!gui.isObject())
                return;

            ((PopupMenu) this["viewTypeMenu"]).checkRadioItem(0, 7, type.AsInt());

            // Store the current camera rotation so we can restore it correctly when
            // switching back to perspective view
            if (gui.getDisplayType() == iGlobal["$EditTSCtrl::DisplayTypePerspective"])
                this["lastPerspectiveCamRotation"] = ((SimObject) LocalClientConnection["camera"]).call("getRotation");

            gui.setDisplayType(type.AsInt());

            if (gui.getDisplayType() == iGlobal["$EditTSCtrl::DisplayTypePerspective"])
                ((SimObject) LocalClientConnection["camera"]).call("setRotation", this["lastPerspectiveCamRotation"]);

            this["currentDisplayType"] = type;
            }

        //-----------------------------------------------------------------------------
        [ConsoleInteraction]
        public void setEditor(EditorPlugin newEditor, bool dontActivate)
            {
            if (this.currentEditor.isObject())
                {
                if (newEditor.isObject() && this.currentEditor.getId() == newEditor.getId())
                    return;

                if (this.currentEditor.isActivated)
                    this.currentEditor.onDeactivated();

                if (this.currentEditor["editorGui"].isObject())
                    this["currentOrthoFOV"] = ((EditTSCtrl) this.currentEditor["editorGui"]).getOrthoFOV().AsString();
                }

            if (!newEditor.isObject())
                {
                this.currentEditor = "";
                return;
                }

            //So not all editors implement this function.
            //So the default implementation returns NULL.
            //This lets us know that the derived class doesn't use this function.
            //Otherwise it will return a bool, which means it does implement this function.
            // :)
            bool? result = newEditor.setEditorFunction();
            if (result != null)
                {
                if ((bool) result)

                    #region "true"

                    {
                    this.syncEditor(newEditor, false);
                    this.currentEditor = (EditorPlugin) newEditor;

                    if (!dontActivate)
                        this.currentEditor.onActivated();
                    }
                    #endregion

                else
                    #region false

                    {
                    // if were falling back and were the same editor, why are we going to just shove ourself
                    // into the editor position again? opt for a fallback
                    if (!this.currentEditor.isObject())
                        this.currentEditor = "WorldEditorInspectorPlugin";
                    else if (this.currentEditor.getId() == newEditor.getId())
                        this.currentEditor = "WorldEditorInspectorPlugin";

                    this.syncEditor(this.currentEditor, true);

                    if (!dontActivate)
                        this.currentEditor.onActivated();
                    }

                #endregion
                }
            else
                {
                this.syncEditor(newEditor, false);
                this.currentEditor = (EditorPlugin) newEditor;

                if (!dontActivate)
                    this.currentEditor.onActivated();
                }

            // Sync display type.

            EditTSCtrl gui = this.currentEditor["editorGui"];
            if (gui.isObject())
                {
                gui.setDisplayType(this["currentDisplayType"].AsInt());
                gui.setOrthoFOV(this["currentOrthoFOV"].AsInt());
                this.syncCameraGui();
                }
            }

        [ConsoleInteraction]
        public void syncEditor(EditorPlugin newEditor, bool newEditorFailed)
            {
            GuiDynamicCtrlArrayControl ToolsToolbarArray = "ToolsToolbarArray";
            EWToolsToolbar EWToolsToolbar = "EWToolsToolbar";

            EWToolsPaletteWindow ToolsPaletteWindow = this.FOT("ToolsPaletteWindow");

            // Sync with menu bar
            PopupMenu menu = this.findMenu("Editors");
            int count = menu.getItemCount();
            for (int i = 0; i < count; i++)
                {
                string pluginObj = Util.getField(menu["item[" + i + "]"], 2);
                if (pluginObj == newEditor)
                    {
                    menu.checkRadioItem(0, count, i);
                    break;
                    }
                }

            // In order to hook up a palette, the word Palette must be able to be
            // switched out in order to read correctly, if not, no palette will be used
            string paletteName = Util.strreplace(newEditor.getName(), "Plugin", "Palette");

            // Sync with ToolsToolbar
            for (uint i = 0; i < ToolsToolbarArray.getCount(); i++)
                {
                string toolbarButton = ((SimObject) ToolsToolbarArray.getObject(i))["internalName"];
                if (paletteName == toolbarButton)
                    {
                    ((GuiBitmapButtonCtrl) ToolsToolbarArray.getObject(i)).setStateOn(true);
                    break;
                    }
                }

            // Handles quit game and gui editor changes in wierd scenarios
            if (newEditorFailed && EWToolsToolbar.isDynamic)
                {
                if (EWToolsToolbar.isClosed)
                    EWToolsToolbar.reset();
                EWToolsToolbar.toggleSize(false);
                }

            // Toggle the editor specific palette; we define special cases here
            switch (paletteName)
                {
                    case "MaterialEditorPalette":
                        paletteName = "WorldEditorInspectorPalette";
                        break;
                    case "DatablockEditorPalette":
                        paletteName = "WorldEditorInspectorPalette";
                        break;
                    case "ParticleEditorPalette":
                        paletteName = "WorldEditorInspectorPalette";
                        break;
                }

            ToolsPaletteWindow.togglePalette(paletteName);
            }

        [ConsoleInteraction]
        public override void onWake()
            {
            GuiBitmapButtonCtrl EHWorldEditor = "EHWorldEditor";
            //

            //SimObject DemoEditorAlert = "DemoEditorAlert";
            GuiCanvas Canvas = "Canvas";

            EHWorldEditor.setStateOn(true);

            // Notify the editor plugins that the editor has started.
            SimSet EditorPluginSet = "EditorPluginSet";
            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin plugin = EditorPluginSet.getObject(i);
                plugin.onEditorWake();
                }

            // Push the ActionMaps in the order that we want to have them
            // before activating an editor plugin, so that if the plugin
            // installs an ActionMap, it will be highest on the stack.
            ActionMap MoveMap = "MoveMap";
            ActionMap EditorMap = "EditorMap";
            MoveMap.push();
            EditorMap.push();

            // Active the current editor plugin.

            if (!this.currentEditor.isActivated)
                this.currentEditor.onActivated();

            int slashPos = 0;
            while (Util.strpos(sGlobal["$Server::MissionFile"], "/", slashPos) != -1)
                {
                slashPos = Util.strpos(sGlobal["$Server::MissionFile"], "/", slashPos) + 1;
                }
            string levelName = Util.getSubStr(sGlobal["$Server::MissionFile"], slashPos, 99);

            if (levelName != this["levelName"])
                this.onNewLevelLoaded(levelName);

            //if (Util._isObject(DemoEditorAlert) && DemoEditorAlert["helpTag"].AsInt() < 2)
            //Canvas.pushDialog(DemoEditorAlert);
            }

        [ConsoleInteraction]
        public override void onSleep()
            {
            SimSet EditorPluginSet = "EditorPluginSet";
            ActionMap MoveMap = "MoveMap";
            ActionMap EditorMap = "EditorMap";

            // Deactivate the current editor plugin.

            if (this.currentEditor.isActivated)
                this.currentEditor.onDeactivated();

            // Remove the editor's ActionMaps.

            EditorMap.pop();
            MoveMap.pop();

            // Notify the editor plugins that the editor will be closing.

            for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                {
                EditorPlugin plugin = EditorPluginSet.getObject(i);
                plugin.onEditorSleep();
                }

            if (sGlobal["$Server::CurrentScene"] != "")
                if (sGlobal["$Server::CurrentScene"].isObject())
                    sGlobal["$Server::CurrentScene"].call("open");
            }

        [ConsoleInteraction]
        public void onNewLevelLoaded(string levelName)
            {
            CameraSettingsTab ECameraSettingsPage = "ECameraSettingsPage";
            MenuHandlers.EditorCameraSpeedMenu EditorCameraSpeedOptions = "EditorCameraSpeedOptions";

            this["levelName"] = levelName;
            this.setupDefaultCameraSettings();

            ECameraSettingsPage.init();
            EditorCameraSpeedOptions.setupDefaultState();

            #region ScriptObject ( EditorMissionCleanup )        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("ScriptObject", " EditorMissionCleanup",
                typeof (EditorMissionCleanup));
            oc_Newobject2["parentGroup"] = "MissionCleanup";

            #endregion

            oc_Newobject2.Create();
            }


        //-----------------------------------------------------------------------------

        // Called when we have been set as the content and onWake has been called
        [ConsoleInteraction]
        public override void onSetContent(string oldContent)
            {
            this.attachMenus();
            }

        // Called before onSleep when the canvas content is changed
        [ConsoleInteraction]
        public override void onUnsetContent(string newContent)
            {
            this.detachMenus();
            }

        //------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void toggleSFXParametersWindow()
            {
            GuiWindowCollapseCtrl ManageSFXParametersWindow = this.FOT("ManageSFXParametersWindow");

            GuiWindowCollapseCtrl window = ManageSFXParametersWindow;
            window.setVisible(!window.isVisible());
            }

        //------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void addCameraBookmark(string name)
            {
            SimGroup CameraBookmarks = "CameraBookmarks";
            SimGroup MissionGroup = "MissionGroup";
            GameConnection LocalClientConnection = "LocalClientConnection";
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";

            ObjectCreator ocf = new ObjectCreator("CameraBookmark");
            ocf["datablock"] = "CameraBookmarkMarker";
            ocf["internalName"] = name;

            CameraBookmark obj = ocf.Create();

            // Place into correct group
            if (!CameraBookmarks.isObject())
                {
                SimGroup grp = new ObjectCreator("SimGroup", "CameraBookmarks").Create();
                MissionGroup.add(grp);
                }
            CameraBookmarks.add(obj);

            TransformF cam = ((SimObject) LocalClientConnection["camera"]).call("getTransform").AsTransformF();
            obj.setTransform(cam);

            EWorldEditor.isDirty = true;
            EditorTree.buildVisibleTree(true);
            }

        [ConsoleInteraction]
        public void removeCameraBookmark(string name)
            {
            SimGroup CameraBookmarks = "CameraBookmarks";
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";

            if (!CameraBookmarks.isObject())
                return;

            SimObject mark = CameraBookmarks.findObjectByInternalName(name, true);
            //TODO
            if ((mark).isObject())
                return;

            Extendable.MEDeleteUndoAction.submit(mark, false);
            EWorldEditor.isDirty = true;
            EditorTree.buildVisibleTree(true);
            }

        [ConsoleInteraction]
        public void removeCameraBookmarkIndex(int index)
            {
            SimGroup CameraBookmarks = "CameraBookmarks";
            EWorldEditor EWorldEditor = "EWorldEditor";
            EditorTree EditorTree = "EditorTree";

            if (!CameraBookmarks.isObject())
                return;

            if (index < 0 || index >= CameraBookmarks.getCount())
                return;

            SimObject obj = CameraBookmarks.getObject((uint) index);
            Extendable.MEDeleteUndoAction.submit(obj, false);
            EWorldEditor.isDirty = true;
            EditorTree.buildVisibleTree(true);
            }

        [ConsoleInteraction]
        public void jumpToBookmark(string name)
            {
            SimGroup CameraBookmarks = "CameraBookmarks";
            GameConnection LocalClientConnection = "LocalClientConnection";

            if (!CameraBookmarks.isObject())
                return;

            SimObject mark = CameraBookmarks.findObjectByInternalName(name, true);
            //TODO
            if (mark.isObject())
                return;

            ((SimObject) LocalClientConnection["camera"]).call("setTransform", mark.call("getTransform"));
            return;
            }

        [ConsoleInteraction]
        public void jumpToBookmarkIndex(int index)
            {
            SimGroup CameraBookmarks = "CameraBookmarks";
            GameConnection LocalClientConnection = "LocalClientConnection";

            if (!CameraBookmarks.isObject())
                return;

            if (index < 0 || index >= CameraBookmarks.getCount())
                return;

            TransformF trans =
                ((SimObject) CameraBookmarks.getObject((uint) index)).call("getTransform").AsTransformF();
            ((SimObject) LocalClientConnection["camera"]).call("setTransform", trans.AsString());
            }

        [ConsoleInteraction]
        public void addCameraBookmarkByGui()
            {
            SimGroup CameraBookmarks = "CameraBookmarks";

            // look for a NewCamera name to grab
            string name;
            for (int i = 0;; i++)
                {
                name = "NewCamera_" + i;
                if (!(CameraBookmarks.findObjectByInternalName(name, false)).isObject())
                    {
                    break;
                    }
                }
            this.addCameraBookmark(name);
            }

        [ConsoleInteraction]
        public void toggleCameraBookmarkWindow()
            {
            EManageBookmarks EManageBookmarks = "EManageBookmarks";

            EManageBookmarks.ToggleVisibility();
            }

        [ConsoleInteraction]
        public void toggleObjectSelectionsWindow()
            {
            ESelectObjectsWindow ESelectObjectsWindow = "ESelectObjectsWindow";

            ESelectObjectsWindow.toggleVisibility();
            }

        [ConsoleInteraction]
        public void toggleOrthoGrid()
            {
            EWorldEditor EWorldEditor = "EWorldEditor";

            EWorldEditor.renderOrthoGrid = !EWorldEditor["renderOrthoGrid"].AsBool();
            }

        //------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void syncCameraGui()
            {
            GameConnection LocalClientConnection = "LocalClientConnection";
            EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";
            EWorldEditor.EWorldEditorToggleCamera EWorldEditorToggleCamera = "EWorldEditorToggleCamera";
            MenuBuilder EditorFreeCameraTypeOptions = "EditorFreeCameraTypeOptions";
            MenuBuilder EditorPlayerCameraTypeOptions = "EditorPlayerCameraTypeOptions";

            GuiIconButtonCtrl NewtonianRotationCamera = this.FOT("NewtonianRotationCamera");
            GuiIconButtonCtrl NewtonianCamera = this.FOT("NewtonianCamera");
            GuiIconButtonCtrl OrbitCamera = this.FOT("OrbitCamera");
            GuiIconButtonCtrl StandardCamera = this.FOT("StandardCamera");
            GuiIconButtonCtrl trdPersonCamera = this.FOT("trdPersonCamera");
            GuiIconButtonCtrl PlayerCamera = this.FOT("PlayerCamera");

            SimObject camera = LocalClientConnection["camera"];

            if (!console.Call("EditorIsActive").AsBool())
                return;

            // Sync projection type
            int displayType = ((EditTSCtrl) this.currentEditor["editorGui"]).getDisplayType();
            ((PopupMenu) this["viewTypeMenu"]).checkRadioItem(0, 7, displayType);

            // Set the camera object's mode and rotation so that it moves correctly
            // based on the current editor mode
            if (displayType != iGlobal["$EditTSCtrl::DisplayTypePerspective"])
                {
                string name = "", camRot = "";

                if (displayType == iGlobal["$EditTSCtrl::DisplayTypeTop"])
                    {
                    name = "Top View";
                    camRot = "0 0 0";
                    }
                else if (displayType == iGlobal["$EditTSCtrl::DisplayTypeBottom"])
                    {
                    name = "Bottom View";
                    camRot = "3.14159 0 0";
                    }
                else if (displayType == iGlobal["$EditTSCtrl::DisplayTypeLeft"])
                    {
                    name = "Left View";
                    camRot = "-1.571 0 1.571";
                    }
                else if (displayType == iGlobal["$EditTSCtrl::DisplayTypeRight"])
                    {
                    name = "Right View";
                    camRot = "-1.571 0 -1.571";
                    }
                else if (displayType == iGlobal["$EditTSCtrl::DisplayTypeFront"])
                    {
                    name = "Front View";
                    camRot = "-1.571 0 3.14159";
                    }
                else if (displayType == iGlobal["$EditTSCtrl::DisplayTypeBack"])
                    {
                    name = "Back View";
                    camRot = "-1.571 0 0";
                    }
                else if (displayType == iGlobal["$EditTSCtrl::DisplayTypeIsometric"])
                    {
                    name = "Isometric View";
                    camRot = "0 0 0";
                    }

                camera["controlMode"] = "Fly";
                camera.call("setRotation", camRot);
                EditorGuiStatusBar.setCamera(name);
                return;
                }

            // Sync camera settings.
            int flyModeRadioItem = -1;
            if (LocalClientConnection.getControlObject() != LocalClientConnection["player"])
                {
                string mode = camera.call("getMode");

                if (mode == "Fly" && camera["newtonMode"].AsBool())
                    {
                    if (camera["newtonRotation"].AsBool())
                        {
                        NewtonianRotationCamera.setStateOn(true);
                        EWorldEditorToggleCamera.setBitmap("tools/gui/images/menubar/smooth-cam-rot");
                        flyModeRadioItem = 4;
                        EditorGuiStatusBar.setCamera("Smooth Rot Camera");
                        }
                    else
                        {
                        NewtonianCamera.setStateOn(true);
                        EWorldEditorToggleCamera.setBitmap("tools/gui/images/menubar/smooth-cam");
                        flyModeRadioItem = 3;
                        EditorGuiStatusBar.setCamera("Smooth Camera");
                        }
                    }
                else if (mode == "EditOrbit")
                    {
                    OrbitCamera.setStateOn(true);
                    EWorldEditorToggleCamera.setBitmap("tools/gui/images/menubar/orbit-cam");
                    flyModeRadioItem = 1;
                    EditorGuiStatusBar.setCamera("Orbit Camera");
                    }
                else // default camera mode
                    {
                    StandardCamera.setStateOn(true);
                    EWorldEditorToggleCamera.setBitmap("tools/worldEditor/images/toolbar/camera");
                    flyModeRadioItem = 0;
                    EditorGuiStatusBar.setCamera("Standard Camera");
                    }

                //quick way select menu bar options
                ((MenuBuilder) this.findMenu("Camera")).checkRadioItem(0, 1, 0);
                EditorFreeCameraTypeOptions.checkRadioItem(0, 4, flyModeRadioItem);
                EditorPlayerCameraTypeOptions.checkRadioItem(0, 4, -1);
                }
            else if (!bGlobal["$isFirstPersonVar"]) // if 3rd person
                {
                trdPersonCamera.setStateOn(true);
                EWorldEditorToggleCamera.setBitmap("tools/worldEditor/images/toolbar/3rd-person-camera");
                flyModeRadioItem = 1;
                //quick way select menu bar options
                ((MenuBuilder) this.findMenu("Camera")).checkRadioItem(0, 1, 1);
                EditorPlayerCameraTypeOptions.checkRadioItem(0, 2, flyModeRadioItem);
                EditorGuiStatusBar.setCamera("3rd Person Camera");
                }
            else if (bGlobal["$isFirstPersonVar"]) // if 1st Person
                {
                PlayerCamera.setStateOn(true);
                EWorldEditorToggleCamera.setBitmap("tools/worldEditor/images/toolbar/player");
                flyModeRadioItem = 0;
                //quick way select menu bar options
                ((MenuBuilder) this.findMenu("Camera")).checkRadioItem(0, 1, 1);
                EditorPlayerCameraTypeOptions.checkRadioItem(0, 2, flyModeRadioItem);
                EditorFreeCameraTypeOptions.checkRadioItem(0, 4, -1);
                EditorGuiStatusBar.setCamera("1st Person Camera");
                }
            }

        [ConsoleInteraction]
        public void readWorldEditorSettings()
            {
            Settings EditorSettings = "EditorSettings";
            EWorldEditor EWorldEditor = "EWorldEditor";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            EditorSettings.beginGroup("WorldEditor", true);
            if (EditorSettings.value("dropType") != "")
                EWorldEditor.dropType = EditorSettings.value("dropType"); //$pref::WorldEditor::dropType;
            EWorldEditor["undoLimit"] = EditorSettings.value("undoLimit"); //$pref::WorldEditor::undoLimit;
            EWorldEditor["forceLoadDAE"] = EditorSettings.value("forceLoadDAE"); //$pref::WorldEditor::forceLoadDAE;
            this["currentDisplayType"] = EditorSettings.value("displayType");
            this["currentOrthoFOV"] = EditorSettings.value("orthoFOV");
            EWorldEditor.renderOrthoGrid = EditorSettings.value("orthoShowGrid").AsBool();
            try
                {
                this.currentEditor = EditorSettings.value("currentEditor");
                }
            catch (Exception)
                {
                
                }
            this["torsionPath"] = EditorSettings.value("torsionPath");

            EditorSettings.beginGroup("ObjectIcons");
            EWorldEditor.fadeIcons = EditorSettings.value("fadeIcons").AsBool();
            EWorldEditor["fadeIconsStartDist"] = EditorSettings.value("fadeIconsStartDist");
            EWorldEditor["fadeIconsEndDist"] = EditorSettings.value("fadeIconsEndDist");
            EWorldEditor["fadeIconsStartAlpha"] = EditorSettings.value("fadeIconsStartAlpha");
            EWorldEditor["fadeIconsEndAlpha"] = EditorSettings.value("fadeIconsEndAlpha");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Grid");
            EWorldEditor.gridSize = EditorSettings.value("gridSize").AsFloat();
            EWorldEditor.gridSnap = EditorSettings.value("gridSnap").AsBool();
            EWorldEditor.gridColor = EditorSettings.value("gridColor").AsColorI();
            EWorldEditor.gridOriginColor = EditorSettings.value("gridOriginColor").AsColorI();
            EWorldEditor["gridMinorColor"] = EditorSettings.value("gridMinorColor");
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Tools");
            EWorldEditor.stickToGround = EditorSettings.value("snapGround").AsBool(); //$pref::WorldEditor::snapGround;
            EWorldEditor.setSoftSnap(EditorSettings.value("snapSoft").AsBool());
            //$pref::WorldEditor::snapSoft
            EWorldEditor.setSoftSnapSize(EditorSettings.value("snapSoftSize").AsInt());
            //$pref::WorldEditor::snapSoftSize
            EWorldEditor.boundingBoxCollision = EditorSettings.value("boundingBoxCollision").AsBool();
            //$pref::WorldEditor::boundingBoxCollision;
            EWorldEditor.objectsUseBoxCenter = EditorSettings.value("objectsUseBoxCenter").AsBool();
            //$pref::WorldEditor::objectsUseBoxCenter;
            EWorldEditor.dropAtScreenCenterScalar = EditorSettings.value("dropAtScreenCenterScalar").AsFloat();
            EWorldEditor.dropAtScreenCenterMax = EditorSettings.value("dropAtScreenCenterMax").AsFloat();
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Render");
            EWorldEditor.renderObjHandle = EditorSettings.value("renderObjHandle").AsBool();
            //$pref::WorldEditor::renderObjHandle;
            EWorldEditor.renderObjText = EditorSettings.value("renderObjText").AsBool();
            //$pref::WorldEditor::renderObjText;
            EWorldEditor.renderPopupBackground = EditorSettings.value("renderPopupBackground").AsBool();
            //$pref::WorldEditor::renderPopupBackground;
            EWorldEditor.renderSelectionBox = EditorSettings.value("renderSelectionBox").AsBool();
            //$pref::WorldEditor::renderSelectionBox;   
            EWorldEditor.showMousePopupInfo = EditorSettings.value("showMousePopupInfo").AsBool();
            //$pref::WorldEditor::showMousePopupInfo;   
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Color");
            EWorldEditor.dragRectColor = EditorSettings.value("dragRectColor").AsColorI();
            //$pref::WorldEditor::dragRectColor;
            EWorldEditor.objectTextColor = EditorSettings.value("objectTextColor").AsColorI();
            //$pref::WorldEditor::objectTextColor;
            EWorldEditor.objMouseOverColor = EditorSettings.value("objMouseOverColor").AsColorI();
            //$pref::WorldEditor::objMouseOverColor;
            EWorldEditor.objMouseOverSelectColor = EditorSettings.value("objMouseOverSelectColor").AsColorI();
            //$pref::WorldEditor::objMouseOverSelectColor;
            EWorldEditor.objSelectColor = EditorSettings.value("objSelectColor").AsColorI();
            //$pref::WorldEditor::objSelectColor;
            EWorldEditor.popupBackgroundColor = EditorSettings.value("popupBackgroundColor").AsColorI();
            //$pref::WorldEditor::popupBackgroundColor;
            EWorldEditor.popupTextColor = EditorSettings.value("popupTextColor").AsColorI();
            //$pref::WorldEditor::popupTextColor;   
            EWorldEditor.selectionBoxColor = EditorSettings.value("selectionBoxColor").AsColorI();
            //$pref::WorldEditor::selectionBoxColor;
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Images");
            EWorldEditor.defaultHandle = EditorSettings.value("defaultHandle"); //$pref::WorldEditor::defaultHandle;
            EWorldEditor.lockedHandle = EditorSettings.value("lockedHandle"); //$pref::WorldEditor::lockedHandle;
            EWorldEditor.selectHandle = EditorSettings.value("selectHandle"); //$pref::WorldEditor::selectHandle;
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Docs");
            EWorldEditor["documentationLocal"] = EditorSettings.value("documentationLocal");
            EWorldEditor["documentationURL"] = EditorSettings.value("documentationURL");
            EWorldEditor["documentationReference"] = EditorSettings.value("documentationReference");
            EWorldEditor["forumURL"] = EditorSettings.value("forumURL");
            EditorSettings.endGroup();

            //EWorldEditor.planarMovement            = $pref::WorldEditor::planarMovement;   //<-- What is this used for?

            EditorSettings.endGroup(); // WorldEditor

            EditorSettings.beginGroup("AxisGizmo", true);
            GlobalGizmoProfile["screenLength"] = EditorSettings.value("axisGizmoMaxScreenLen");
            //$pref::WorldEditor::axisGizmoMaxScreenLen;
            GlobalGizmoProfile["rotationSnap"] = EditorSettings.value("rotationSnap");
            //$pref::WorldEditor::rotationSnap;
            GlobalGizmoProfile["snapRotations"] = EditorSettings.value("snapRotations");
            //$pref::WorldEditor::snapRotations;
            GlobalGizmoProfile["rotateScalar"] = EditorSettings.value("mouseRotateScalar");
            //$pref::WorldEditor::mouseRotateScalar;
            GlobalGizmoProfile["scaleScalar"] = EditorSettings.value("mouseScaleScalar");
            //$pref::WorldEditor::mouseScaleScalar;
            GlobalGizmoProfile["renderWhenUsed"] = EditorSettings.value("renderWhenUsed");
            GlobalGizmoProfile["renderInfoText"] = EditorSettings.value("renderInfoText");

            EditorSettings.beginGroup("Grid");
            GlobalGizmoProfile["gridColor"] = EditorSettings.value("gridColor"); //$pref::WorldEditor::gridColor;
            GlobalGizmoProfile["gridSize"] = EditorSettings.value("gridSize"); //$pref::WorldEditor::gridSize;
            GlobalGizmoProfile["snapToGrid"] = EditorSettings.value("snapToGrid"); //$pref::WorldEditor::snapToGrid;
            GlobalGizmoProfile["renderPlane"] = EditorSettings.value("renderPlane"); //$pref::WorldEditor::renderPlane;
            GlobalGizmoProfile["renderPlaneHashes"] = EditorSettings.value("renderPlaneHashes");
            //$pref::WorldEditor::renderPlaneHashes;   
            GlobalGizmoProfile["planeDim"] = EditorSettings.value("planeDim"); //$pref::WorldEditor::planeDim;
            EditorSettings.endGroup();

            EditorSettings.endGroup(); // AxisGizmo
            }

        [ConsoleInteraction]
        public void writeWorldEditorSettings()
            {
            Settings EditorSettings = "EditorSettings";
            EWorldEditor EWorldEditor = "EWorldEditor";
            GizmoProfile GlobalGizmoProfile = "GlobalGizmoProfile";

            EditorSettings.beginGroup("WorldEditor", true);
            EditorSettings.setValue("dropType", EWorldEditor["dropType"]); //$pref::WorldEditor::dropType
            EditorSettings.setValue("undoLimit", EWorldEditor["undoLimit"]); //$pref::WorldEditor::undoLimit
            EditorSettings.setValue("forceLoadDAE", EWorldEditor["forceLoadDAE"]); //$pref::WorldEditor::forceLoadDAE
            EditorSettings.setValue("displayType", this["currentDisplayType"]);
            EditorSettings.setValue("orthoFOV", this["currentOrthoFOV"]);
            EditorSettings.setValue("orthoShowGrid", EWorldEditor["renderOrthoGrid"]);
            EditorSettings.setValue("currentEditor", this.currentEditor.getName());
            EditorSettings.setValue("torsionPath", this["torsionPath"]);

            EditorSettings.beginGroup("ObjectIcons");
            EditorSettings.setValue("fadeIcons", EWorldEditor.fadeIcons.AsString());
            EditorSettings.setValue("fadeIconsStartDist", EWorldEditor["fadeIconsStartDist"]);
            EditorSettings.setValue("fadeIconsEndDist", EWorldEditor["fadeIconsEndDist"]);
            EditorSettings.setValue("fadeIconsStartAlpha", EWorldEditor["fadeIconsStartAlpha"]);
            EditorSettings.setValue("fadeIconsEndAlpha", EWorldEditor["fadeIconsEndAlpha"]);
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Grid");
            EditorSettings.setValue("gridSize", EWorldEditor.gridSize.AsString());
            EditorSettings.setValue("gridSnap", EWorldEditor.gridSnap.AsString());
            EditorSettings.setValue("gridColor", EWorldEditor.gridColor.AsString());
            EditorSettings.setValue("gridOriginColor", EWorldEditor.gridOriginColor.AsString());
            EditorSettings.setValue("gridMinorColor", EWorldEditor["gridMinorColor"]);
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Tools");
            EditorSettings.setValue("snapGround", EWorldEditor.stickToGround.AsString());
            //$Pref::WorldEditor::snapGround
            EditorSettings.setValue("snapSoft", EWorldEditor.getSoftSnap().AsString()); //$Pref::WorldEditor::snapSoft
            EditorSettings.setValue("snapSoftSize", EWorldEditor.getSoftSnapSize().AsString());
            //$Pref::WorldEditor::snapSoftSize
            EditorSettings.setValue("boundingBoxCollision", EWorldEditor.boundingBoxCollision.AsString());
            //$Pref::WorldEditor::boundingBoxCollision
            EditorSettings.setValue("objectsUseBoxCenter", EWorldEditor.objectsUseBoxCenter.AsString());
            //$Pref::WorldEditor::objectsUseBoxCenter
            EditorSettings.setValue("dropAtScreenCenterScalar", EWorldEditor.dropAtScreenCenterScalar.AsString());
            EditorSettings.setValue("dropAtScreenCenterMax", EWorldEditor.dropAtScreenCenterMax.AsString());
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Render");
            EditorSettings.setValue("renderObjHandle", EWorldEditor.renderObjHandle.AsString());
            //$Pref::WorldEditor::renderObjHandle
            EditorSettings.setValue("renderObjText", EWorldEditor.renderObjText.AsString());
            //$Pref::WorldEditor::renderObjText
            EditorSettings.setValue("renderPopupBackground", EWorldEditor.renderPopupBackground.AsString());
            //$Pref::WorldEditor::renderPopupBackground
            EditorSettings.setValue("renderSelectionBox", EWorldEditor.renderSelectionBox.AsString());
            //$Pref::WorldEditor::renderSelectionBox
            EditorSettings.setValue("showMousePopupInfo", EWorldEditor.showMousePopupInfo.AsString());
            //$Pref::WorldEditor::showMousePopupInfo
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Color");
            EditorSettings.setValue("dragRectColor", EWorldEditor.dragRectColor.AsString());
            //$Pref::WorldEditor::dragRectColor
            EditorSettings.setValue("objectTextColor", EWorldEditor.objectTextColor.AsString());
            //$Pref::WorldEditor::objectTextColor
            EditorSettings.setValue("objMouseOverColor", EWorldEditor.objMouseOverColor.AsString());
            //$Pref::WorldEditor::objMouseOverColor
            EditorSettings.setValue("objMouseOverSelectColor", EWorldEditor.objMouseOverSelectColor.AsString());
            //$Pref::WorldEditor::objMouseOverSelectColor
            EditorSettings.setValue("objSelectColor", EWorldEditor.objSelectColor.AsString());
            //$Pref::WorldEditor::objSelectColor
            EditorSettings.setValue("popupBackgroundColor", EWorldEditor.popupBackgroundColor.AsString());
            //$Pref::WorldEditor::popupBackgroundColor
            EditorSettings.setValue("selectionBoxColor", EWorldEditor.selectionBoxColor.AsString());
            //$Pref::WorldEditor::selectionBoxColor
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Images");
            EditorSettings.setValue("defaultHandle", EWorldEditor.defaultHandle); //$Pref::WorldEditor::defaultHandle
            EditorSettings.setValue("selectHandle", EWorldEditor.selectHandle); //$Pref::WorldEditor::selectHandle
            EditorSettings.setValue("lockedHandle", EWorldEditor.lockedHandle); //$Pref::WorldEditor::lockedHandle
            EditorSettings.endGroup();

            EditorSettings.beginGroup("Docs");
            EditorSettings.setValue("documentationLocal", EWorldEditor["documentationLocal"]);
            EditorSettings.setValue("documentationReference", EWorldEditor["documentationReference"]);
            EditorSettings.setValue("documentationURL", EWorldEditor["documentationURL"]);
            EditorSettings.setValue("forumURL", EWorldEditor["forumURL"]);
            EditorSettings.endGroup();

            EditorSettings.endGroup(); // WorldEditor

            EditorSettings.beginGroup("AxisGizmo", true);

            EditorSettings.setValue("axisGizmoMaxScreenLen", GlobalGizmoProfile["screenLength"]);
            //$Pref::WorldEditor::axisGizmoMaxScreenLen
            EditorSettings.setValue("rotationSnap", GlobalGizmoProfile["rotationSnap"]);
            //$Pref::WorldEditor::rotationSnap
            EditorSettings.setValue("snapRotations", GlobalGizmoProfile["snapRotations"]);
            //$Pref::WorldEditor::snapRotations
            EditorSettings.setValue("mouseRotateScalar", GlobalGizmoProfile["rotateScalar"]);
            //$Pref::WorldEditor::mouseRotateScalar
            EditorSettings.setValue("mouseScaleScalar", GlobalGizmoProfile["scaleScalar"]);
            //$Pref::WorldEditor::mouseScaleScalar
            EditorSettings.setValue("renderWhenUsed", GlobalGizmoProfile["renderWhenUsed"]);
            EditorSettings.setValue("renderInfoText", GlobalGizmoProfile["renderInfoText"]);

            EditorSettings.beginGroup("Grid");
            EditorSettings.setValue("gridColor", GlobalGizmoProfile["gridColor"]); //$Pref::WorldEditor::gridColor
            EditorSettings.setValue("gridSize", GlobalGizmoProfile["gridSize"]); //$Pref::WorldEditor::gridSize
            EditorSettings.setValue("snapToGrid", GlobalGizmoProfile["snapToGrid"]); //$Pref::WorldEditor::snapToGrid
            EditorSettings.setValue("renderPlane", GlobalGizmoProfile["renderPlane"]); //$Pref::WorldEditor::renderPlane
            EditorSettings.setValue("renderPlaneHashes", GlobalGizmoProfile["renderPlaneHashes"]);
            //$Pref::WorldEditor::renderPlaneHashes
            EditorSettings.setValue("planeDim", GlobalGizmoProfile["planeDim"]); //$Pref::WorldEditor::planeDim
            EditorSettings.endGroup();

            EditorSettings.endGroup(); // AxisGizmo
            }

        [ConsoleInteraction]
        public void readTerrainEditorSettings()
            {
            Settings EditorSettings = "EditorSettings";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            EditorSettings.beginGroup("TerrainEditor", true);

            ETerrainEditor["savedAction"] = EditorSettings.value("currentAction");

            EditorSettings.beginGroup("Brush");
            ETerrainEditor["maxBrushSize"] = EditorSettings.value("maxBrushSize");


            ETerrainEditor.setBrushSize(EditorSettings.value("brushSize").Split(' ')[0].AsInt(), EditorSettings.value("brushSize").Split(' ')[1].AsInt());
            ETerrainEditor.setBrushType(EditorSettings.value("brushType"));
            ETerrainEditor.setBrushPressure(EditorSettings.value("brushPressure").AsFloat());
            ETerrainEditor.setBrushSoftness(EditorSettings.value("brushSoftness").AsFloat());
            EditorSettings.endGroup();

            EditorSettings.beginGroup("ActionValues");
            ETerrainEditor["adjustHeightVal"] = EditorSettings.value("adjustHeightVal");
            ETerrainEditor["setHeightVal"] = EditorSettings.value("setHeightVal");
            ETerrainEditor["scaleVal"] = EditorSettings.value("scaleVal");
            ETerrainEditor["smoothFactor"] = EditorSettings.value("smoothFactor");
            ETerrainEditor["noiseFactor"] = EditorSettings.value("noiseFactor");
            ETerrainEditor["softSelectRadius"] = EditorSettings.value("softSelectRadius");
            ETerrainEditor["softSelectFilter"] = EditorSettings.value("softSelectFilter");
            ETerrainEditor.softSelectDefaultFilter = EditorSettings.value("softSelectDefaultFilter");
            ETerrainEditor.setSlopeLimitMinAngle(EditorSettings.value("slopeMinAngle").AsFloat());
            ETerrainEditor.setSlopeLimitMaxAngle(EditorSettings.value("slopeMaxAngle").AsFloat());
            EditorSettings.endGroup();

            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void writeTerrainEditorSettings()
            {
            Settings EditorSettings = "EditorSettings";
            TerrainEditor ETerrainEditor = "ETerrainEditor";

            EditorSettings.beginGroup("TerrainEditor", true);

            EditorSettings.setValue("currentAction", ETerrainEditor["savedAction"]);

            EditorSettings.beginGroup("Brush");
            EditorSettings.setValue("maxBrushSize", ETerrainEditor["maxBrushSize"]);
            EditorSettings.setValue("brushSize", ETerrainEditor.getBrushSize());
            EditorSettings.setValue("brushType", ETerrainEditor.getBrushType());
            EditorSettings.setValue("brushSoftness", ETerrainEditor.getBrushSoftness().AsString());
            EditorSettings.endGroup();

            EditorSettings.beginGroup("ActionValues");
            EditorSettings.setValue("adjustHeightVal", ETerrainEditor["adjustHeightVal"]);
            EditorSettings.setValue("setHeightVal", ETerrainEditor["setHeightVal"]);
            EditorSettings.setValue("scaleVal", ETerrainEditor["scaleVal"]);
            EditorSettings.setValue("smoothFactor", ETerrainEditor["smoothFactor"]);
            EditorSettings.setValue("noiseFactor", ETerrainEditor["noiseFactor"]);
            EditorSettings.setValue("softSelectRadius", ETerrainEditor["softSelectRadius"]);
            EditorSettings.setValue("softSelectFilter", ETerrainEditor["softSelectFilter"]);
            EditorSettings.setValue("softSelectDefaultFilter", ETerrainEditor["softSelectDefaultFilter"]);
            EditorSettings.setValue("slopeMinAngle", ETerrainEditor.getSlopeLimitMinAngle().AsString());
            EditorSettings.setValue("slopeMaxAngle", ETerrainEditor.getSlopeLimitMaxAngle().AsString());
            EditorSettings.endGroup();

            EditorSettings.endGroup();
            }

        [ConsoleInteraction]
        public void buildMenus()
            {
            string cmdCtrl, menuCmdCtrl, quitShortcut, redoShortcut;

            if (this.menuBar.isObject())
                return;

            //set up cmdctrl variable so that it matches OS standards
            if (sGlobal["$platform"] == "macos")
                {
                cmdCtrl = "Cmd";
                menuCmdCtrl = "Cmd";
                quitShortcut = "Cmd Q";
                redoShortcut = "Cmd-Shift Z";
                }
            else
                {
                cmdCtrl = "Ctrl";
                menuCmdCtrl = "Alt";
                quitShortcut = "Alt F4";
                redoShortcut = "Ctrl Y";
                }

            // Sub menus (temporary, until MenuBuilder gets updated)
            // The speed increments located here are overwritten in EditorCameraSpeedMenu::setupDefaultState.
            // The new min/max for the editor camera speed range can be set in each level's levelInfo object.

            ObjectCreator cameraCreator = new ObjectCreator("PopupMenu", "EditorCameraSpeedOptions",
                typeof (MenuHandlers.EditorCameraSpeedMenu));

            cameraCreator["item[0]"] = "Slowest" + '\t' + cmdCtrl + "-Shift 1" + '\t' + "5";
            cameraCreator["item[1]"] = "Slow" + '\t' + cmdCtrl + "-Shift 2" + '\t' + "35";
            cameraCreator["item[2]"] = "Slower" + '\t' + cmdCtrl + "-Shift 3" + '\t' + "70";
            cameraCreator["item[3]"] = "Normal" + '\t' + cmdCtrl + "-Shift 4" + '\t' + "100";
            cameraCreator["item[4]"] = "Faster" + '\t' + cmdCtrl + "-Shift 5" + '\t' + "130";
            cameraCreator["item[5]"] = "Fast" + '\t' + cmdCtrl + "-Shift 6" + '\t' + "165";
            cameraCreator["item[6]"] = "Fastest" + '\t' + cmdCtrl + "-Shift 7" + '\t' + "200";

            this.cameraSpeedMenu = cameraCreator.Create();

            ObjectCreator freeCameraCreator =
                new ObjectCreator("PopupMenu", "EditorFreeCameraTypeOptions",
                    typeof (MenuHandlers.EditorFreeCameraTypeMenu));

            freeCameraCreator["item[0]"] = "Standard" + '\t' + "Ctrl 1" + '\t' +
                                           "EditorGuiStatusBar.setCamera(\\\"Standard Camera\\\");";
            freeCameraCreator["item[1]"] = "Orbit Camera" + '\t' + "Ctrl 2" + '\t' +
                                           "EditorGuiStatusBar.setCamera(\\\"Orbit Camera\\\");";
            freeCameraCreator["item[2]"] = "-";
            freeCameraCreator["item[3]"] = "Smoothed" + '\t' + "" + '\t' +
                                           "EditorGuiStatusBar.setCamera(\\\"Smooth Camera\\\");";
            freeCameraCreator["item[4]"] = "Smoothed Rotate" + '\t' + "" + '\t' +
                                           "EditorGuiStatusBar.setCamera(\\\"Smooth Rot Camera\\\");";

            this.freeCameraTypeMenu = freeCameraCreator.Create();

            ObjectCreator playerCameraCreator =
                new ObjectCreator("PopupMenu", "EditorPlayerCameraTypeOptions",
                    typeof (MenuHandlers.EditorPlayerCameraTypeMenu));

            playerCameraCreator["item[0]"] = "First Person" + '\t' + "" + '\t' +
                                             "EditorGuiStatusBar.setCamera(\\\"1st Person Camera\\\");";
            playerCameraCreator["item[1]"] = "Third Person" + '\t' + "" + '\t' +
                                             "EditorGuiStatusBar.setCamera(\\\"3rd Person Camera\\\");";

            this.playerCameraTypeMenu = playerCameraCreator.Create();

            this.cameraBookmarksMenu =
                new ObjectCreator("PopupMenu", "EditorCameraBookmarks", typeof (EditorCameraBookmarksMenu)).Create();

            //item[0] = "None";

            ObjectCreator viewCreator = new ObjectCreator("PopupMenu", "", typeof (MenuBuilder));

            viewCreator["item[0]"] = "Top" + '\t' + "Alt 2" + '\t' + "EditorGuiStatusBar.setCamera(\\\"Top View\\\");";
            viewCreator["item[1]"] = "Bottom" + '\t' + "Alt 5" + '\t' +
                                     "EditorGuiStatusBar.setCamera(\\\"Bottom View\\\");";
            viewCreator["item[2]"] = "Front" + '\t' + "Alt 3" + '\t' +
                                     "EditorGuiStatusBar.setCamera(\\\"Front View\\\");";
            viewCreator["item[3]"] = "Back" + '\t' + "Alt 6" + '\t' + "EditorGuiStatusBar.setCamera(\\\"Back View\\\");";
            viewCreator["item[4]"] = "Left" + '\t' + "Alt 4" + '\t' + "EditorGuiStatusBar.setCamera(\\\"Left View\\\");";
            viewCreator["item[5]"] = "Right" + '\t' + "Alt 7" + '\t' +
                                     "EditorGuiStatusBar.setCamera(\\\"Right View\\\");";
            viewCreator["item[6]"] = "Perspective" + '\t' + "Alt 1" + '\t' +
                                     "EditorGuiStatusBar.setCamera(\\\"Standard Camera\\\");";
            viewCreator["item[7]"] = "Isometric" + '\t' + "Alt 8" + '\t' +
                                     "EditorGuiStatusBar.setCamera(\\\"Isometric View\\\");";

            this.viewTypeMenu = viewCreator.Create();

            // Menu bar
            ObjectCreator menuBarCreator = new ObjectCreator("MenuBar", "");
            menuBarCreator["dynamicItemInsertPos"] = "3";

            this.menuBar = menuBarCreator.Create();

            // File Menu
            ObjectCreator fileMenuCreator =
                new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorFileMenu));
            fileMenuCreator["barTitle"] = "File";

            MenuHandlers.EditorFileMenu fileMenu = fileMenuCreator.Create();

            if (!Util.isWebDemo())
                {
                fileMenu.appendItem("New Level" + '\t' + "" + '\t' + "schedule( 1, 0, \"EditorNewLevel\" );");
                fileMenu.appendItem("Open Level..." + '\t' + cmdCtrl + ' ' + "O" + '\t' +
                                    "schedule( 1, 0, \"EditorOpenMission\" );");
                fileMenu.appendItem("Save Level" + '\t' + cmdCtrl + ' ' + "S" + '\t' + "EditorSaveMissionMenu();");
                fileMenu.appendItem("Save Level As..." + '\t' + "" + '\t' + "EditorSaveMissionAs();");
                fileMenu.appendItem("-");

                if (sGlobal["$platform"] == "windows")
                    {
                    fileMenu.appendItem("Open Project in Torsion" + '\t' + "" + '\t' + "EditorOpenTorsionProject();");
                    fileMenu.appendItem("Open Level File in Torsion" + '\t' + "" + '\t' + "EditorOpenFileInTorsion();");
                    fileMenu.appendItem("-");
                    }
                }

            fileMenu.appendItem("Create Blank Terrain" + '\t' + "" + '\t' + "Canvas.pushDialog( CreateNewTerrainGui );");
            fileMenu.appendItem("Import Terrain Heightmap" + '\t' + "" + '\t' + "Canvas.pushDialog( TerrainImportGui );");

            if (!Util.isWebDemo())
                {
                fileMenu.appendItem("Export Terrain Heightmap" + '\t' + "" + '\t' +
                                    "Canvas.pushDialog( TerrainExportGui );");
                fileMenu.appendItem("-");
                fileMenu.appendItem("Export To COLLADA..." + '\t' + "" + '\t' + "EditorExportToCollada();");
                //item[5] = "Import Terraform Data..." + '\t' + "" + '\t' + "Heightfield::import();";
                //item[6] = "Import Texture Data..." + '\t' + "" + '\t' + "Texture::import();";
                //item[7] = "-";
                //item[8] = "Export Terraform Data..." + '\t' + "" + '\t' + "Heightfield::saveBitmap(\"\");";
                }

            fileMenu.appendItem("-");
            fileMenu.appendItem("Add FMOD Designer Audio..." + '\t' + "" + '\t' + "AddFMODProjectDlg.show();");

            fileMenu.appendItem("-");
            fileMenu.appendItem("Play Level" + '\t' + "F11" + '\t' + "Editor.close(\"PlayGui\");");

            if (!Util.isWebDemo())
                {
                fileMenu.appendItem("Exit Level" + '\t' + "" + '\t' + "EditorExitMission();");
                fileMenu.appendItem("Quit" + '\t' + quitShortcut + '\t' + "EditorQuitGame();");
                }
            this.menuBar.insert(fileMenu, this.menuBar.getCount());

            // Edit Menu
            ObjectCreator editMenuCreator =
                new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorEditMenu));
            editMenuCreator["internalName"] = "EditMenu";
            editMenuCreator["barTitle"] = "Edit";

            editMenuCreator["item[0]"] = "Undo" + '\t' + cmdCtrl + ' ' + "Z" + '\t' + "Editor.getUndoManager().undo();";
            editMenuCreator["item[1]"] = "Redo" + '\t' + redoShortcut + '\t' + "Editor.getUndoManager().redo();";
            editMenuCreator["item[2]"] = "-";
            editMenuCreator["item[3]"] = "Cut" + '\t' + cmdCtrl + ' ' + "X" + '\t' + "EditorMenuEditCut();";
            editMenuCreator["item[4]"] = "Copy" + '\t' + cmdCtrl + ' ' + "C" + '\t' + "EditorMenuEditCopy();";
            editMenuCreator["item[5]"] = "Paste" + '\t' + cmdCtrl + ' ' + "V" + '\t' + "EditorMenuEditPaste();";
            editMenuCreator["item[6]"] = "Delete" + '\t' + "Delete" + '\t' + "EditorMenuEditDelete();";
            editMenuCreator["item[7]"] = "-";
            editMenuCreator["item[8]"] = "Deselect" + '\t' + "X" + '\t' + "EditorMenuEditDeselect();";
            editMenuCreator["item[9]"] = "Select..." + '\t' + "" + '\t' + "EditorGui.toggleObjectSelectionsWindow();";
            editMenuCreator["item[10]"] = "-";
            editMenuCreator["item[11]"] = "Audio Parameters..." + '\t' + "" + '\t' +
                                          "EditorGui.toggleSFXParametersWindow();";
            editMenuCreator["item[12]"] = "Editor Settings..." + '\t' + "" + '\t' +
                                          "ESettingsWindow.ToggleVisibility();";
            editMenuCreator["item[13]"] = "Snap Options..." + '\t' + "" + '\t' + "ESnapOptions.ToggleVisibility();";
            editMenuCreator["item[14]"] = "-";
            editMenuCreator["item[15]"] = "Game Options..." + '\t' + "" + '\t' + "Canvas.pushDialog(optionsDlg);";
            editMenuCreator["item[16]"] = "PostEffect Manager" + '\t' + "" + '\t' + "Canvas.pushDialog(PostFXManager);";

            MenuHandlers.EditorEditMenu editMenu = editMenuCreator.Create();

            this.menuBar.insert(editMenu, this.menuBar.getCount());

            // View Menu
            ObjectCreator viewMenuCreator =
                new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorViewMenu));
            viewMenuCreator["internalName"] = "viewMenu";

            viewMenuCreator["barTitle"] = "View";

            viewMenuCreator["item[0]"] = "Visibility Layers" + '\t' + "Alt V" + '\t' + "VisibilityDropdownToggle();";
            viewMenuCreator["item[1]"] =
                "Show Grid in Ortho Views" + '\t' + cmdCtrl + "-Shift-Alt G" + '\t' + "EditorGui.toggleOrthoGrid();";

            MenuHandlers.EditorViewMenu viewMenu = viewMenuCreator.Create();

            this.menuBar.insert(viewMenu, this.menuBar.getCount());

            // Camera Menu
            ObjectCreator cameraMenuCreator =
                new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorCameraMenu));

            cameraMenuCreator["barTitle"] = "Camera";

            cameraMenuCreator["item[0]"] = "World Camera" + '\t' + this.freeCameraTypeMenu;
            cameraMenuCreator["item[1]"] = "Player Camera" + '\t' + this.playerCameraTypeMenu;
            cameraMenuCreator["item[2]"] = "-";
            cameraMenuCreator["item[3]"] = "Toggle Camera" + '\t' + menuCmdCtrl + ' ' + "C" + '\t' +
                                           "commandToServer('ToggleCamera');";
            cameraMenuCreator["item[4]"] = "Place Camera at Selection" + '\t' + "Ctrl Q" + '\t' +
                                           "EWorldEditor.dropCameraToSelection();";
            cameraMenuCreator["item[5]"] = "Place Camera at Player" + '\t' + "Alt Q" + '\t' +
                                           "commandToServer('dropCameraAtPlayer');";
            cameraMenuCreator["item[6]"] = "Place Player at Camera" + '\t' + "Alt W" + '\t' +
                                           "commandToServer('DropPlayerAtCamera');";
            cameraMenuCreator["item[7]"] = "-";
            cameraMenuCreator["item[8]"] = "Fit View to Selection" + '\t' + "F" + '\t' +
                                           "commandToServer('EditorCameraAutoFit', EWorldEditor.getSelectionRadius()+1);";
            cameraMenuCreator["item[9]"] =
                //new ObjectCreator.StringNoQuote(
                "Fit View To Selection and Orbit" + '\t' + "Alt F" + '\t' +
                "EditorGuiStatusBar.setCamera(\\\"Orbit Camera\\\"); commandToServer('EditorCameraAutoFit', EWorldEditor.getSelectionRadius()+1);";
            cameraMenuCreator["item[10]"] = "-";
            cameraMenuCreator["item[11]"] = "Speed" + '\t' + this.cameraSpeedMenu;
            cameraMenuCreator["item[12]"] = "View" + '\t' + this.viewTypeMenu;
            cameraMenuCreator["item[13]"] = "-";
            cameraMenuCreator["item[14]"] = "Add Bookmark..." + '\t' + "Ctrl B" + '\t' +
                                            "EditorGui.addCameraBookmarkByGui();";
            cameraMenuCreator["item[15]"] = "Manage Bookmarks..." + '\t' + "Ctrl-Shift B" + '\t' +
                                            "EditorGui.toggleCameraBookmarkWindow();";
            cameraMenuCreator["item[16]"] = "Jump to Bookmark" + '\t' + this.cameraBookmarksMenu;

            MenuHandlers.EditorCameraMenu cameraMenu = cameraMenuCreator.Create();

            this.menuBar.insert(cameraMenu, this.menuBar.getCount());

            // Editors Menu
            ObjectCreator editorsMenuCreator =
                new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorToolsMenu));

            editorsMenuCreator["barTitle"] = "Editors";

            //item[0] = "Object Editor" + '\t' + "F1" + '\t' + WorldEditorInspectorPlugin;
            //item[1] = "Material Editor" + '\t' + "F2" + '\t' + MaterialEditorPlugin;
            //item[2] = "-";
            //item[3] = "Terrain Editor" + '\t' + "F3" + '\t' + TerrainEditorPlugin;
            //item[4] = "Terrain Painter" + '\t' + "F4" + '\t' + TerrainPainterPlugin;
            //item[5] = "-";

            MenuHandlers.EditorToolsMenu editorsMenu = editorsMenuCreator.Create();

            this.menuBar.insert(editorsMenu, this.menuBar.getCount());

            // Lighting Menu
            ObjectCreator lightingMenuCreator = new ObjectCreator("PopupMenu", "", typeof (EditorLightingMenu));
            lightingMenuCreator["barTitle"] = "Lighting";

            lightingMenuCreator["item[0]"] = "Full Relight" + '\t' + "Alt L" + '\t' +
                                             "Editor.lightScene(\\\"\\\", forceAlways);";
            lightingMenuCreator["item[1]"] = "Toggle ShadowViz" + '\t' + "" + '\t' + "toggleShadowViz();";
            lightingMenuCreator["item[2]"] = "-";

            // NOTE: The light managers will be inserted as the
            // last menu items in EditorLightingMenu::onAdd().

            EditorLightingMenu lightingMenu = lightingMenuCreator.Create();

            this.menuBar.insert(lightingMenu, this.menuBar.getCount());

            // Help Menu
            ObjectCreator helpMenuCreator =
                new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorHelpMenu));

            helpMenuCreator["barTitle"] = "Help";

            helpMenuCreator["item[0]"] = "Online Documentation..." + '\t' + "Alt F1" + '\t' +
                                         "gotoWebPage(EWorldEditor.documentationURL);";
            helpMenuCreator["item[1]"] = "Offline User Guide..." + '\t' + "" + '\t' +
                                         "gotoWebPage(EWorldEditor.documentationLocal);";
            helpMenuCreator["item[2]"] = "Offline Reference Guide..." + '\t' + "" + '\t' +
                                         "shellexecute(EWorldEditor.documentationReference);";
            helpMenuCreator["item[3]"] = "Torque 3D Forums..." + '\t' + "" + '\t' +
                                         "gotoWebPage(EWorldEditor.forumURL);";

            MenuHandlers.EditorHelpMenu helpMenu = helpMenuCreator.Create();

            this.menuBar.insert(helpMenu, this.menuBar.getCount());

            ObjectCreator oDiagnosticMenu = new ObjectCreator("PopupMenu", "DiagnosticMenu",
                typeof (MenuHandlers.EditorHelpMenu));
            oDiagnosticMenu["barTitle"] = "Diagnostics";
            oDiagnosticMenu["item[0]"] = "Net Usage Graph" + "\t" + "" + "\t" + "toggleNetGraph(); DiagnosticMenu.checkItem(0, !DiagnosticMenu.isItemChecked(0));";
            oDiagnosticMenu["item[1]"] = "Metrics Menu" + "\t" + "" + "\t" + "toggleMetricsGui()";
            oDiagnosticMenu["item[2]"] = "Inspect Globals" + '\t' + "" + '\t' + "InspectVars();";
            MenuHandlers.EditorHelpMenu diagMenu = oDiagnosticMenu.Create();
            this.menuBar.insert(diagMenu, this.menuBar.getCount());


            // Menus that are added/removed dynamically (temporary)

            // World Menu
            if (!this.worldMenu.isObject())
                {
                ObjectCreator dropTypeCreator =
                    new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorDropTypeMenu));

                // The onSelectItem() callback for this menu re-purposes the command field
                // as the MenuBuilder version is not used.
                dropTypeCreator["item[0]"] = "at Origin" + '\t' + "" + '\t' + "atOrigin";
                dropTypeCreator["item[1]"] = "at Camera" + '\t' + "" + '\t' + "atCamera";
                dropTypeCreator["item[2]"] = "at Camera w/Rotation" + '\t' + "" + '\t' + "atCameraRot";
                dropTypeCreator["item[3]"] = "Below Camera" + '\t' + "" + '\t' + "belowCamera";
                dropTypeCreator["item[4]"] = "Screen Center" + '\t' + "" + '\t' + "screenCenter";
                dropTypeCreator["item[5]"] = "at Centroid" + '\t' + "" + '\t' + "atCentroid";
                dropTypeCreator["item[6]"] = "to Terrain" + '\t' + "" + '\t' + "toTerrain";
                dropTypeCreator["item[7]"] = "Below Selection" + '\t' + "" + '\t' + "belowSelection";

                this.dropTypeMenu = dropTypeCreator.Create();

                ObjectCreator alignBoundsCreator =
                    new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorAlignBoundsMenu));

                // The onSelectItem() callback for this menu re-purposes the command field
                // as the MenuBuilder version is not used.
                alignBoundsCreator["item[0]"] = "+X Axis" + '\t' + "" + '\t' + "0";
                alignBoundsCreator["item[1]"] = "+Y Axis" + '\t' + "" + '\t' + "1";
                alignBoundsCreator["item[2]"] = "+Z Axis" + '\t' + "" + '\t' + "2";
                alignBoundsCreator["item[3]"] = "-X Axis" + '\t' + "" + '\t' + "3";
                alignBoundsCreator["item[4]"] = "-Y Axis" + '\t' + "" + '\t' + "4";
                alignBoundsCreator["item[5]"] = "-Z Axis" + '\t' + "" + '\t' + "5";

                this.alignBoundsMenu = alignBoundsCreator.Create();

                ObjectCreator alignCenterCreator =
                    new ObjectCreator("PopupMenu", "", typeof (MenuHandlers.EditorAlignCenterMenu));

                // The onSelectItem() callback for this menu re-purposes the command field
                // as the MenuBuilder version is not used.
                alignCenterCreator["item[0]"] = "X Axis" + '\t' + "" + '\t' + "0";
                alignCenterCreator["item[1]"] = "Y Axis" + '\t' + "" + '\t' + "1";
                alignCenterCreator["item[2]"] = "Z Axis" + '\t' + "" + '\t' + "2";

                this.alignCenterMenu = alignCenterCreator.Create();

                ObjectCreator worldMenuCreator = new ObjectCreator("PopupMenu", "",
                    typeof (MenuHandlers.EditorWorldMenu));

                worldMenuCreator["barTitle"] = "Object";

                worldMenuCreator["item[0]"] = "Lock Selection" + '\t' + cmdCtrl + " L" + '\t' +
                                              "EWorldEditor.lockSelection(true); EWorldEditor.syncGui();";
                worldMenuCreator["item[1]"] = "Unlock Selection" + '\t' + cmdCtrl + "-Shift L" + '\t' +
                                              "EWorldEditor.lockSelection(false); EWorldEditor.syncGui();";
                worldMenuCreator["item[2]"] = "-";
                worldMenuCreator["item[3]"] = "Hide Selection" + '\t' + cmdCtrl + " H" + '\t' +
                                              "EWorldEditor.hideSelection(true); EWorldEditor.syncGui();";
                worldMenuCreator["item[4]"] = "Show Selection" + '\t' + cmdCtrl + "-Shift H" + '\t' +
                                              "EWorldEditor.hideSelection(false); EWorldEditor.syncGui();";
                worldMenuCreator["item[5]"] = "-";
                worldMenuCreator["item[6]"] = "Align Bounds" + '\t' + this.alignBoundsMenu;
                worldMenuCreator["item[7]"] = "Align Center" + '\t' + this.alignCenterMenu;
                worldMenuCreator["item[8]"] = "-";
                worldMenuCreator["item[9]"] = "Reset Transforms" + '\t' + "Ctrl R" + '\t' +
                                              "EWorldEditor.resetTransforms();";
                worldMenuCreator["item[10]"] = "Reset Selected Rotation" + '\t' + "" + '\t' +
                                               "EWorldEditor.resetSelectedRotation();";
                worldMenuCreator["item[11]"] = "Reset Selected Scale" + '\t' + "" + '\t' +
                                               "EWorldEditor.resetSelectedScale();";
                worldMenuCreator["item[12]"] = "Transform Selection..." + '\t' + "Ctrl T" + '\t' +
                                               "ETransformSelection.ToggleVisibility();";
                worldMenuCreator["item[13]"] = "-";
                //item[13] = "Drop Camera to Selection" + '\t' + "Ctrl Q" + '\t' + "EWorldEditor.dropCameraToSelection();";
                //item[14] = "Add Selection to Instant Group" + '\t' + "" + '\t' + "EWorldEditor.addSelectionToAddGroup();";
                worldMenuCreator["item[14]"] = "Drop Selection" + '\t' + "Ctrl D" + '\t' +
                                               "EWorldEditor.dropSelection();";
                //item[15] = "-";
                worldMenuCreator["item[15]"] = "Drop Location" + '\t' + this.dropTypeMenu;
                worldMenuCreator["item[16]"] = "-";
                worldMenuCreator["item[17]"] = "Make Selection Prefab" + '\t' + "" + '\t' + "EditorMakePrefab();";
                worldMenuCreator["item[18]"] = "Explode Selected Prefab" + '\t' + "" + '\t' + "EditorExplodePrefab();";
                worldMenuCreator["item[19]"] = "-";
                worldMenuCreator["item[20]"] = "Mount Selection A to B" + '\t' + "" + '\t' + "EditorMount();";
                worldMenuCreator["item[21]"] = "Unmount Selected Object" + '\t' + "" + '\t' + "EditorUnmount();";

                this.worldMenu = worldMenuCreator.Create();
                }
            }

        //////////////////////////////////////////////////////////////////////////
        [ConsoleInteraction]
        public void attachMenus()
            {
            GuiCanvas Canvas = "Canvas";

            this.menuBar.attachToCanvas(Canvas, 0);
            }

        [ConsoleInteraction]
        public void detachMenus()
            {
            this.menuBar.removeFromCanvas();
            }

        [ConsoleInteraction]
        public void setMenuDefaultState()
            {
            if (!this.menuBar.isObject())
                return;

            for (uint i = 0; i < this.menuBar.getCount(); i++)
                {
                MenuBuilder menu = this.menuBar.getObject(i);
                menu.setupDefaultState();
                }

            this.worldMenu.setupDefaultState();
            }

        //////////////////////////////////////////////////////////////////////////

        [ConsoleInteraction]
        public string findMenu(string name)
            {
            if (!this.menuBar.isObject())
                return "0";

            for (uint i = 0; i < this.menuBar.getCount(); i++)
                {
                MenuBuilder menu = this.menuBar.getObject(i);

                if (name == menu["barTitle"])
                    return menu;
                }

            return "0";
            }

        [ConsoleInteraction]
        public void handleEscape()
            {
            editor Editor = "Editor";

            bool result = false;
            if (this.currentEditor.isObject())
                result = this.currentEditor.handleEscape();

            if (!result)
                {
                Editor.close("PlayGui");
                }
            }

        [ConsoleInteraction]
        public static void CameraTypesDropdownToggle()
            {
            GuiContainer CameraTypesDropdown = "CameraTypesDropdown";
            EWorldEditor.EWorldEditorToggleCamera EWorldEditorToggleCamera = "EWorldEditorToggleCamera";
            CameraTypesDropdownDecoy CameraTypesDropdownDecoy = "CameraTypesDropdownDecoy";

            if (CameraTypesDropdown.visible)
                {
                EWorldEditorToggleCamera.setStateOn(false);
                CameraTypesDropdownDecoy.setVisible(false);
                CameraTypesDropdownDecoy.setActive(false);
                CameraTypesDropdown.setVisible(false);
                }
            else
                {
                CameraTypesDropdown.setVisible(true);
                CameraTypesDropdownDecoy.setVisible(true);
                CameraTypesDropdownDecoy.setActive(true);
                EWorldEditorToggleCamera.setStateOn(true);
                }
            }

        [ConsoleInteraction]
        public static void VisibilityDropdownToggle()
            {
            EVisibility EVisibility = "EVisibility";
            GuiBitmapButtonCtrl visibilityToggleBtn = "visibilityToggleBtn";

            if (EVisibility.visible)
                {
                EVisibility.setVisible(false);
                visibilityToggleBtn.setStateOn(false);
                }
            else
                {
                EVisibility.setVisible(true);
                visibilityToggleBtn.setStateOn(true);
                }
            }

        [ConsoleInteraction]
        public static void toggleSnappingOptions(string var)
        {
            var = var.ToLower();
            EWorldEditor EWorldEditor = "EWorldEditor";
            GuiControl SnapToBar = "SnapToBar";
            GuiTabBookCtrl ESnapOptionsTabBook = "ESnapOptionsTabBook";

            GuiBitmapButtonCtrl objectSnapDownBtn = SnapToBar.FOT("objectSnapDownBtn");
            GuiBitmapButtonCtrl objectSnapBtn = SnapToBar.FOT("objectSnapBtn");

            if (objectSnapDownBtn.getValue().AsBool() && objectSnapBtn.getValue().AsBool())
                {
                if (var == "terrain")
                    {
                    EWorldEditor["stickToGround"] = "1";
                    EWorldEditor.setSoftSnap(false);
                    ESnapOptionsTabBook.selectPage(0);
                    objectSnapBtn.setStateOn(false);
                    }
                else
                    {
                    // soft snapping
                    EWorldEditor["stickToGround"] = "0";
                    EWorldEditor.setSoftSnap(true);
                    ESnapOptionsTabBook.selectPage(1);
                    objectSnapDownBtn.setStateOn(false);
                    }
                }
            else if (var == "terrain" && EWorldEditor["stickToGround"].AsInt() == 0)
                {
                // Terrain Snapping
                EWorldEditor["stickToGround"] = "1";
                EWorldEditor.setSoftSnap(false);
                ESnapOptionsTabBook.selectPage(0);
                objectSnapDownBtn.setStateOn(true);
                objectSnapBtn.setStateOn(false);
                }
            else if (var == "soft" && EWorldEditor.getSoftSnap() == false)
                {
                // Object Snapping
                EWorldEditor["stickToGround"] = "0";
                EWorldEditor.setSoftSnap(true);
                ESnapOptionsTabBook.selectPage(1);
                objectSnapBtn.setStateOn(true);
                objectSnapDownBtn.setStateOn(false);
                }
            else if (var == "grid")
                {
                EWorldEditor.setGridSnap(!EWorldEditor.getGridSnap());
                }
            else
                {
                // No snapping.

                EWorldEditor["stickToGround"] = false.AsString();
                EWorldEditor.setGridSnap(false);
                EWorldEditor.setSoftSnap(false);

                objectSnapDownBtn.setStateOn(false);
                objectSnapBtn.setStateOn(false);
                }

            EWorldEditor.syncGui();
            }

        [TypeConverter(typeof (TypeConverterGeneric<CameraSpeedDropdownCtrlContainer>))]
        public class CameraSpeedDropdownCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiControl CameraSpeedDropdownContainer = "CameraSpeedDropdownContainer";

                GuiTextEditCtrl textEdit = CameraSpeedDropdownContainer.FOT("textEdit");
                GuiSliderCtrl slider = this.FOT("slider");

                slider.setValue(textEdit.getText());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(CameraSpeedDropdownCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(CameraSpeedDropdownCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(CameraSpeedDropdownCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator CameraSpeedDropdownCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (CameraSpeedDropdownCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (CameraSpeedDropdownCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(CameraSpeedDropdownCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator CameraSpeedDropdownCtrlContainer(int simobjectid)
                {
                return
                    (CameraSpeedDropdownCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (CameraSpeedDropdownCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(CameraSpeedDropdownCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator CameraSpeedDropdownCtrlContainer(uint simobjectid)
                {
                return
                    (CameraSpeedDropdownCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (CameraSpeedDropdownCtrlContainer));
                }

            #endregion
            }


        [TypeConverter(typeof (CameraTypesDropdownDecoy))]
        public class CameraTypesDropdownDecoy : GuiDecoyCtrl
            {
            [ConsoleInteraction]
            public override void onMouseLeave()
                {
                CameraTypesDropdownToggle();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(CameraTypesDropdownDecoy ts, string simobjectid)
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
            public static bool operator !=(CameraTypesDropdownDecoy ts, string simobjectid)
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
            public static implicit operator string(CameraTypesDropdownDecoy ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator CameraTypesDropdownDecoy(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (CameraTypesDropdownDecoy) Omni.self.getSimObject(simobjectid, typeof (CameraTypesDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(CameraTypesDropdownDecoy ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator CameraTypesDropdownDecoy(int simobjectid)
                {
                return
                    (CameraTypesDropdownDecoy)
                        Omni.self.getSimObject((uint) simobjectid, typeof (CameraTypesDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(CameraTypesDropdownDecoy ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator CameraTypesDropdownDecoy(uint simobjectid)
                {
                return (CameraTypesDropdownDecoy) Omni.self.getSimObject(simobjectid, typeof (CameraTypesDropdownDecoy));
                }

            #endregion
            }

        [TypeConverter(typeof (EWAddSimGroupButton))]
        public class EWAddSimGroupButton : GuiBitmapButtonCtrl
            {
            [ConsoleInteraction]
            public override void onDefaultClick()
                {
                EWorldEditor EWorldEditor = "EWorldEditor";

                EWorldEditor.addSimGroup(false);
                }

            [ConsoleInteraction]
            public override void onCtrlClick()
                {
                EWorldEditor EWorldEditor = "EWorldEditor";

                EWorldEditor.addSimGroup(true);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWAddSimGroupButton ts, string simobjectid)
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
            public static bool operator !=(EWAddSimGroupButton ts, string simobjectid)
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
            public static implicit operator string(EWAddSimGroupButton ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWAddSimGroupButton(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EWAddSimGroupButton) Omni.self.getSimObject(simobjectid, typeof (EWAddSimGroupButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWAddSimGroupButton ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWAddSimGroupButton(int simobjectid)
                {
                return (EWAddSimGroupButton) Omni.self.getSimObject((uint) simobjectid, typeof (EWAddSimGroupButton));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWAddSimGroupButton ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWAddSimGroupButton(uint simobjectid)
                {
                return (EWAddSimGroupButton) Omni.self.getSimObject(simobjectid, typeof (EWAddSimGroupButton));
                }

            #endregion
            }


        //------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<EWToolsToolbar>))]
        public class EWToolsToolbar : GuiContainer
            {
            public bool isClosed
                {
                get { return this["isClosed"].AsBool(); }
                set { this["isClosed"] = value.AsString(); }
                }

            public bool isDynamic
                {
                get { return this["isDynamic"].AsBool(); }
                set { this["isDynamic"] = value.AsString(); }
                }

            [ConsoleInteraction]
            public void reset()
                {
                GuiDynamicCtrlArrayControl ToolsToolbarArray = "ToolsToolbarArray";
                EWToolsToolbarDecoy EWToolsToolbarDecoy = "EWToolsToolbarDecoy";

                GuiBitmapButtonCtrl resizeArrow = this.FOT("resizeArrow");

                int count = ToolsToolbarArray.getCount();
                for (uint i = 0; i < count; i++)
                    ((GuiControl) ToolsToolbarArray.getObject(i)).setVisible(true);

                this.setExtent(new Point2F( ((29 + 4)*count + 12), 33));
                this.isClosed = false;
                this.isDynamic = false;

                EWToolsToolbarDecoy.setVisible(false);
                EWToolsToolbarDecoy.setExtent(new Point2F( ((29 + 4)*count + 4), 31));

                resizeArrow.setBitmap("tools/gui/images/collapse-toolbar");
                }

            [ConsoleInteraction]
            public void toggleSize(bool useDynamics)
                {
                GuiDynamicCtrlArrayControl ToolsToolbarArray = "ToolsToolbarArray";
                EWToolsToolbarDecoy EWToolsToolbarDecoy = "EWToolsToolbarDecoy";

                GuiBitmapButtonCtrl resizeArrow = this.FOT("resizeArrow");

                string image;

                // toggles the size of the tooltoolbar. also goes through 
                // and hides each control not currently selected. we hide the controls
                // in a very neat, spiffy way

                if (!this.isClosed)
                    {
                    image = "tools/gui/images/expand-toolbar";

                    for (uint i = 0; i < ToolsToolbarArray.getCount(); i++)
                        {
                        if (((GuiControl) ToolsToolbarArray.getObject(i)).getValue().AsInt() != 1)
                            ((GuiControl) ToolsToolbarArray.getObject(i)).setVisible(false);
                        }

                    this.setExtent(new Point2F(43, 33));
                    this.isClosed = true;

                    if (!useDynamics)
                        {
                        EWToolsToolbarDecoy.setVisible(true);
                        this.isDynamic = true;
                        }

                    EWToolsToolbarDecoy.setExtent(new Point2F(35, 31));
                    }
                else
                    {
                    image = "tools/gui/images/collapse-toolbar";

                    int count = ToolsToolbarArray.getCount();
                    for (uint i = 0; i < count; i++)
                        ((GuiControl) ToolsToolbarArray.getObject(i)).setVisible(true);

                    this.setExtent(new Point2F(((29 + 4)*count + 12), 33));
                    this.isClosed = false;

                    if (!useDynamics)
                        {
                        EWToolsToolbarDecoy.setVisible(false);
                        this.isDynamic = false;
                        }

                    EWToolsToolbarDecoy.setExtent(new Point2F(((29 + 4)*count + 4), 32));
                    }

                resizeArrow.setBitmap(image);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWToolsToolbar ts, string simobjectid)
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
            public static bool operator !=(EWToolsToolbar ts, string simobjectid)
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
            public static implicit operator string(EWToolsToolbar ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWToolsToolbar(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EWToolsToolbar) Omni.self.getSimObject(simobjectid, typeof (EWToolsToolbar));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWToolsToolbar ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWToolsToolbar(int simobjectid)
                {
                return (EWToolsToolbar) Omni.self.getSimObject((uint) simobjectid, typeof (EWToolsToolbar));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWToolsToolbar ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWToolsToolbar(uint simobjectid)
                {
                return (EWToolsToolbar) Omni.self.getSimObject(simobjectid, typeof (EWToolsToolbar));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<EWToolsToolbarDecoy>))]
        public class EWToolsToolbarDecoy : GuiDecoyCtrl
            {
            [ConsoleInteraction]
            public override void onMouseEnter()
                {
                EWToolsToolbar EWToolsToolbar = "EWToolsToolbar";

                EWToolsToolbar.toggleSize(true);
                }

            [ConsoleInteraction]
            public override void onMouseLeave()
                {
                EWToolsToolbar EWToolsToolbar = "EWToolsToolbar";

                EWToolsToolbar.toggleSize(true);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWToolsToolbarDecoy ts, string simobjectid)
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
            public static bool operator !=(EWToolsToolbarDecoy ts, string simobjectid)
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
            public static implicit operator string(EWToolsToolbarDecoy ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWToolsToolbarDecoy(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EWToolsToolbarDecoy) Omni.self.getSimObject(simobjectid, typeof (EWToolsToolbarDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWToolsToolbarDecoy ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWToolsToolbarDecoy(int simobjectid)
                {
                return (EWToolsToolbarDecoy) Omni.self.getSimObject((uint) simobjectid, typeof (EWToolsToolbarDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWToolsToolbarDecoy ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWToolsToolbarDecoy(uint simobjectid)
                {
                return (EWToolsToolbarDecoy) Omni.self.getSimObject(simobjectid, typeof (EWToolsToolbarDecoy));
                }

            #endregion
            }


        //------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<EWorldEditorStatusBarCamera>))]
        public class EWorldEditorStatusBarCamera : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                this.add("Standard Camera");
                this.add("1st Person Camera");
                this.add("3rd Person Camera");
                this.add("Orbit Camera");
                this.add("Top View");
                this.add("Bottom View");
                this.add("Left View");
                this.add("Right View");
                this.add("Front View");
                this.add("Back View");
                this.add("Isometric View");
                this.add("Smooth Camera");
                this.add("Smooth Rot Camera");
                }

            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                EditorGui EditorGui = "EditorGui";

                switch (text)
                    {
                        case "Top View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeTop"]);
                            break;

                        case "Bottom View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeBottom"]);
                            break;

                        case "Left View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeLeft"]);
                            break;

                        case "Right View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeRight"]);
                            break;

                        case "Front View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeFront"]);
                            break;

                        case "Back View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeBack"]);
                            break;

                        case "Isometric View":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypeIsometric"]);
                            break;

                        case "Standard Camera":
                            console.commandToServer("SetEditorCameraStandard");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
                            break;

                        case "1st Person Camera":
                            console.commandToServer("SetEditorCameraPlayer");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
                            break;

                        case "3rd Person Camera":
                            console.commandToServer("SetEditorCameraPlayerThird");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
                            break;

                        case "Orbit Camera":
                            console.commandToServer("SetEditorOrbitCamera");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
                            break;

                        case "Smooth Camera":
                            console.commandToServer("SetEditorCameraNewton");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
                            break;

                        case "Smooth Rot Camera":
                            console.commandToServer("SetEditorCameraNewtonDamped");
                            EditorGui.setDisplayType(sGlobal["$EditTsCtrl::DisplayTypePerspective"]);
                            break;
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EWorldEditorStatusBarCamera ts, string simobjectid)
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
            public static bool operator !=(EWorldEditorStatusBarCamera ts, string simobjectid)
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
            public static implicit operator string(EWorldEditorStatusBarCamera ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorStatusBarCamera(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (EWorldEditorStatusBarCamera)
                        Omni.self.getSimObject(simobjectid, typeof (EWorldEditorStatusBarCamera));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EWorldEditorStatusBarCamera ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EWorldEditorStatusBarCamera(int simobjectid)
                {
                return
                    (EWorldEditorStatusBarCamera)
                        Omni.self.getSimObject((uint) simobjectid, typeof (EWorldEditorStatusBarCamera));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EWorldEditorStatusBarCamera ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EWorldEditorStatusBarCamera(uint simobjectid)
                {
                return
                    (EWorldEditorStatusBarCamera)
                        Omni.self.getSimObject(simobjectid, typeof (EWorldEditorStatusBarCamera));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<EditorDropdownSliderContainer>))]
        public class EditorDropdownSliderContainer : GuiMouseEventCtrl
            {
            [ConsoleInteraction]
            public override void onMouseDown(byte modifier, Point2I mousePoint, byte mouseClickCount)
                {
                GuiCanvas Canvas = "Canvas";

                Canvas.popDialog(this);
                }

            [ConsoleInteraction]
            public override void onRightMouseDown(byte modifier, Point2I mousePoint, byte mouseClickCount)
                {
                GuiCanvas Canvas = "Canvas";

                Canvas.popDialog(this);
                }
            }

        [TypeConverter(typeof (TypeConverterGeneric<EditorGuiStatusBar>))]
        public class EditorGuiStatusBar : GuiContainer
            {
            [ConsoleInteraction]
            public void reset()
                {
                GuiTextCtrl EWorldEditorStatusBarInfo = "EWorldEditorStatusBarInfo";

                //TODO
                //EWorldEditorStatusBarInfo.clearInfo();
                this.clearInfo();
                }

            [ConsoleInteraction]
            public string getInfo()
                {
                GuiTextCtrl EWorldEditorStatusBarInfo = "EWorldEditorStatusBarInfo";

                return EWorldEditorStatusBarInfo.getValue();
                }

            [ConsoleInteraction]
            public void setInfo(string text)
                {
                GuiTextCtrl EWorldEditorStatusBarInfo = "EWorldEditorStatusBarInfo";

                EWorldEditorStatusBarInfo.setText(text);
                }

            [ConsoleInteraction]
            public void clearInfo()
                {
                GuiTextCtrl EWorldEditorStatusBarInfo = "EWorldEditorStatusBarInfo";

                EWorldEditorStatusBarInfo.setText("");
                }

            [ConsoleInteraction]
            public string getSelection()
                {
                GuiTextCtrl EWorldEditorStatusBarSelection = "EWorldEditorStatusBarSelection";

                return EWorldEditorStatusBarSelection.getValue();
                }

            [ConsoleInteraction]
            public void setSelection(string text)
                {
                GuiTextCtrl EWorldEditorStatusBarSelection = "EWorldEditorStatusBarSelection";

                EWorldEditorStatusBarSelection.setText(text);
                }

            [ConsoleInteraction]
            public override void setSelectionObjectsByCount(string count)
                {
                GuiTextCtrl EWorldEditorStatusBarSelection = "EWorldEditorStatusBarSelection";

                string text = " objects selected";
                if (count.AsInt() == 1)
                    text = " object selected";

                EWorldEditorStatusBarSelection.setText(count + text);
                }

            [ConsoleInteraction]
            public void clearSelection()
                {
                GuiTextCtrl EWorldEditorStatusBarSelection = "EWorldEditorStatusBarSelection";

                EWorldEditorStatusBarSelection.setText("");
                }

            [ConsoleInteraction]
            public string getCamera()
                {
                EWorldEditorStatusBarCamera EWorldEditorStatusBarCamera = "EWorldEditorStatusBarCamera";

                return EWorldEditorStatusBarCamera.getText();
                }

            [ConsoleInteraction]
            public void setCamera(string text)
                {
                EWorldEditorStatusBarCamera EWorldEditorStatusBarCamera = "EWorldEditorStatusBarCamera";

                int id = EWorldEditorStatusBarCamera.findText(text);
                if (id != -1)
                    {
                    if (EWorldEditorStatusBarCamera.getSelected() != id)
                        EWorldEditorStatusBarCamera.setSelected(id, true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorGuiStatusBar ts, string simobjectid)
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
            public static bool operator !=(EditorGuiStatusBar ts, string simobjectid)
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
            public static implicit operator string(EditorGuiStatusBar ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorGuiStatusBar(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EditorGuiStatusBar) Omni.self.getSimObject(simobjectid, typeof (EditorGuiStatusBar));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorGuiStatusBar ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorGuiStatusBar(int simobjectid)
                {
                return (EditorGuiStatusBar) Omni.self.getSimObject((uint) simobjectid, typeof (EditorGuiStatusBar));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorGuiStatusBar ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorGuiStatusBar(uint simobjectid)
                {
                return (EditorGuiStatusBar) Omni.self.getSimObject(simobjectid, typeof (EditorGuiStatusBar));
                }

            #endregion
            }

        [TypeConverter(typeof (EditorMissionCleanup))]
        public class EditorMissionCleanup : ScriptObject
            {
            [ConsoleInteraction]
            public override void onRemove(string ID)
                {
                SimSet EditorPluginSet = "EditorPluginSet";

                this["levelName"] = "";
                for (uint i = 0; i < EditorPluginSet.getCount(); i++)
                    {
                    EditorPlugin plugin = EditorPluginSet.getObject(i);
                    plugin.onExitMission();
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(EditorMissionCleanup ts, string simobjectid)
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
            public static bool operator !=(EditorMissionCleanup ts, string simobjectid)
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
            public static implicit operator string(EditorMissionCleanup ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator EditorMissionCleanup(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (EditorMissionCleanup) Omni.self.getSimObject(simobjectid, typeof (EditorMissionCleanup));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(EditorMissionCleanup ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator EditorMissionCleanup(int simobjectid)
                {
                return (EditorMissionCleanup) Omni.self.getSimObject((uint) simobjectid, typeof (EditorMissionCleanup));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(EditorMissionCleanup ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator EditorMissionCleanup(uint simobjectid)
                {
                return (EditorMissionCleanup) Omni.self.getSimObject(simobjectid, typeof (EditorMissionCleanup));
                }

            #endregion
            }


        //------------------------------------------------------------------------------------
        // Each a gui slider bar is pushed on the editor gui, it maps itself with value
        // located in its connected text control
        //------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<PaintBrushPressureSliderCtrlContainer>))]
        public class PaintBrushPressureSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiSliderCtrl slider = this.FOT("slider");
                GuiControl PaintBrushPressureTextEditContainer = "PaintBrushPressureTextEditContainer";

                GuiTextEditCtrl textEdit = PaintBrushPressureTextEditContainer.FOT("textEdit");

                slider.setValue((textEdit.getValue().AsFloat()/100.0).AsString());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PaintBrushPressureSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(PaintBrushPressureSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(PaintBrushPressureSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PaintBrushPressureSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (PaintBrushPressureSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (PaintBrushPressureSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PaintBrushPressureSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PaintBrushPressureSliderCtrlContainer(int simobjectid)
                {
                return
                    (PaintBrushPressureSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (PaintBrushPressureSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PaintBrushPressureSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PaintBrushPressureSliderCtrlContainer(uint simobjectid)
                {
                return
                    (PaintBrushPressureSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (PaintBrushPressureSliderCtrlContainer));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<PaintBrushSizeSliderCtrlContainer>))]
        public class PaintBrushSizeSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                TerrainEditor ETerrainEditor = "ETerrainEditor";
                GuiControl PaintBrushSizeTextEditContainer = "PaintBrushSizeTextEditContainer";

                GuiSliderCtrl slider = this.FOT("slider");
                GuiTextEditCtrl textEdit = PaintBrushSizeTextEditContainer.FOT("textEdit");

                slider.range = ("1" + ' ' + Util.getWord(ETerrainEditor.maxBrushSize.AsString(), 0)).AsPoint2F();
                slider.setValue(textEdit.getValue());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PaintBrushSizeSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(PaintBrushSizeSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(PaintBrushSizeSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PaintBrushSizeSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (PaintBrushSizeSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (PaintBrushSizeSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PaintBrushSizeSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PaintBrushSizeSliderCtrlContainer(int simobjectid)
                {
                return
                    (PaintBrushSizeSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (PaintBrushSizeSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PaintBrushSizeSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PaintBrushSizeSliderCtrlContainer(uint simobjectid)
                {
                return
                    (PaintBrushSizeSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (PaintBrushSizeSliderCtrlContainer));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<PaintBrushSoftnessSliderCtrlContainer>))]
        public class PaintBrushSoftnessSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiSliderCtrl slider = this.FOT("slider");
                GuiControl PaintBrushSoftnessTextEditContainer = "PaintBrushSoftnessTextEditContainer";

                GuiTextEditCtrl textEdit = PaintBrushSoftnessTextEditContainer.FOT("textEdit");

                slider.setValue((textEdit.getValue().AsFloat()/100.0).AsString());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(PaintBrushSoftnessSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(PaintBrushSoftnessSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(PaintBrushSoftnessSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator PaintBrushSoftnessSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (PaintBrushSoftnessSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (PaintBrushSoftnessSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(PaintBrushSoftnessSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator PaintBrushSoftnessSliderCtrlContainer(int simobjectid)
                {
                return
                    (PaintBrushSoftnessSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (PaintBrushSoftnessSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(PaintBrushSoftnessSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator PaintBrushSoftnessSliderCtrlContainer(uint simobjectid)
                {
                return
                    (PaintBrushSoftnessSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (PaintBrushSoftnessSliderCtrlContainer));
                }

            #endregion
            }


        //------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<TerrainBrushPressureSliderCtrlContainer>))]
        public class TerrainBrushPressureSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiControl TerrainBrushPressureTextEditContainer = "TerrainBrushPressureTextEditContainer";

                GuiTextEditCtrl textEdit = TerrainBrushPressureTextEditContainer.FOT("textEdit");
                GuiSliderCtrl slider = this.FOT("slider");

                string value = (textEdit.getValue().AsFloat()/100.0).AsString();

                slider.setValue(value);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainBrushPressureSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(TerrainBrushPressureSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(TerrainBrushPressureSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainBrushPressureSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (TerrainBrushPressureSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainBrushPressureSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainBrushPressureSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainBrushPressureSliderCtrlContainer(int simobjectid)
                {
                return
                    (TerrainBrushPressureSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (TerrainBrushPressureSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainBrushPressureSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainBrushPressureSliderCtrlContainer(uint simobjectid)
                {
                return
                    (TerrainBrushPressureSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainBrushPressureSliderCtrlContainer));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<TerrainBrushSizeSliderCtrlContainer>))]
        public class TerrainBrushSizeSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                TerrainEditor ETerrainEditor = "ETerrainEditor";
                GuiControl TerrainBrushSizeTextEditContainer = "TerrainBrushSizeTextEditContainer";

                GuiTextEditCtrl textEdit = TerrainBrushSizeTextEditContainer.FOT("textEdit");
                GuiSliderCtrl slider = this.FOT("slider");

                slider.range = ("1" + ' ' + Util.getWord(ETerrainEditor.maxBrushSize.AsString(), 0)).AsPoint2F();
                slider.setValue(textEdit.getValue());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainBrushSizeSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(TerrainBrushSizeSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(TerrainBrushSizeSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainBrushSizeSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (TerrainBrushSizeSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainBrushSizeSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainBrushSizeSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainBrushSizeSliderCtrlContainer(int simobjectid)
                {
                return
                    (TerrainBrushSizeSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (TerrainBrushSizeSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainBrushSizeSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainBrushSizeSliderCtrlContainer(uint simobjectid)
                {
                return
                    (TerrainBrushSizeSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainBrushSizeSliderCtrlContainer));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<TerrainBrushSoftnessSliderCtrlContainer>))]
        public class TerrainBrushSoftnessSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiControl TerrainBrushSoftnessTextEditContainer = "TerrainBrushSoftnessTextEditContainer";

                GuiTextEditCtrl textEdit = TerrainBrushSoftnessTextEditContainer.FOT("textEdit");
                GuiSliderCtrl slider = this.FOT("slider");

                slider.setValue((textEdit.getValue().AsFloat()/100.0).AsString());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainBrushSoftnessSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(TerrainBrushSoftnessSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(TerrainBrushSoftnessSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainBrushSoftnessSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (TerrainBrushSoftnessSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainBrushSoftnessSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainBrushSoftnessSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainBrushSoftnessSliderCtrlContainer(int simobjectid)
                {
                return
                    (TerrainBrushSoftnessSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (TerrainBrushSoftnessSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainBrushSoftnessSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainBrushSoftnessSliderCtrlContainer(uint simobjectid)
                {
                return
                    (TerrainBrushSoftnessSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainBrushSoftnessSliderCtrlContainer));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<TerrainSetHeightSliderCtrlContainer>))]
        public class TerrainSetHeightSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiControl TerrainSetHeightTextEditContainer = "TerrainSetHeightTextEditContainer";

                GuiTextEditCtrl textEdit = TerrainSetHeightTextEditContainer.FOT("textEdit");
                GuiSliderCtrl slider = this.FOT("slider");

                slider.setValue(textEdit.getValue());
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainSetHeightSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(TerrainSetHeightSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(TerrainSetHeightSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainSetHeightSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (TerrainSetHeightSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainSetHeightSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainSetHeightSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainSetHeightSliderCtrlContainer(int simobjectid)
                {
                return
                    (TerrainSetHeightSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (TerrainSetHeightSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainSetHeightSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainSetHeightSliderCtrlContainer(uint simobjectid)
                {
                return
                    (TerrainSetHeightSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (TerrainSetHeightSliderCtrlContainer));
                }

            #endregion
            }

        [TypeConverter(typeof (TerrainTextureEditorTool))]
        public class TerrainTextureEditorTool : GuiControl
            {
            [ConsoleInteraction]
            public void onActivated()
                {
                EditorGui EditorGui = "EditorGui";
                TerrainEditor ETerrainEditor = "ETerrainEditor";
                EditorGuiStatusBar EditorGuiStatusBar = "EditorGuiStatusBar";

                GuiControl TextureEditor = EditorGui.FOT("TextureEditor");

                EditorGui.bringToFront(ETerrainEditor);
                ETerrainEditor.setVisible(true);
                ETerrainEditor.attachTerrain();
                ETerrainEditor.makeFirstResponder(true);

                TextureEditor.setVisible(true);

                EditorGuiStatusBar.setSelection("");
                }

            [ConsoleInteraction]
            public void onDeactivated()
                {
                EditorGui EditorGui = "EditorGui";
                TerrainEditor ETerrainEditor = "ETerrainEditor";

                GuiControl TextureEditor = EditorGui.FOT("TextureEditor");

                TextureEditor.setVisible(false);

                ETerrainEditor.setVisible(false);
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TerrainTextureEditorTool ts, string simobjectid)
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
            public static bool operator !=(TerrainTextureEditorTool ts, string simobjectid)
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
            public static implicit operator string(TerrainTextureEditorTool ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TerrainTextureEditorTool(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (TerrainTextureEditorTool) Omni.self.getSimObject(simobjectid, typeof (TerrainTextureEditorTool));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TerrainTextureEditorTool ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TerrainTextureEditorTool(int simobjectid)
                {
                return
                    (TerrainTextureEditorTool)
                        Omni.self.getSimObject((uint) simobjectid, typeof (TerrainTextureEditorTool));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TerrainTextureEditorTool ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TerrainTextureEditorTool(uint simobjectid)
                {
                return (TerrainTextureEditorTool) Omni.self.getSimObject(simobjectid, typeof (TerrainTextureEditorTool));
                }

            #endregion
            }

        [TypeConverter(typeof (objectCenterDropdown))]
        public class objectCenterDropdown : GuiContainer
            {
            [ConsoleInteraction]
            public void toggle()
                {
                GuiControl EWorldEditorToolbar = "EWorldEditorToolbar";
                objectCenterDropdownDecoy objectCenterDropdownDecoy = "objectCenterDropdownDecoy";

                GuiBitmapButtonCtrl centerObject = EWorldEditorToolbar.FOT("centerObject");

                if (this["visible"].AsBool())
                    {
                    centerObject.setStateOn(false);
                    objectCenterDropdownDecoy.setVisible(false);
                    objectCenterDropdownDecoy.setActive(false);
                    this.setVisible(false);
                    }
                else
                    {
                    centerObject.setStateOn(true);
                    this.setVisible(true);
                    objectCenterDropdownDecoy.setActive(true);
                    objectCenterDropdownDecoy.setVisible(true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(objectCenterDropdown ts, string simobjectid)
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
            public static bool operator !=(objectCenterDropdown ts, string simobjectid)
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
            public static implicit operator string(objectCenterDropdown ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator objectCenterDropdown(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (objectCenterDropdown) Omni.self.getSimObject(simobjectid, typeof (objectCenterDropdown));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(objectCenterDropdown ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator objectCenterDropdown(int simobjectid)
                {
                return (objectCenterDropdown) Omni.self.getSimObject((uint) simobjectid, typeof (objectCenterDropdown));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(objectCenterDropdown ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator objectCenterDropdown(uint simobjectid)
                {
                return (objectCenterDropdown) Omni.self.getSimObject(simobjectid, typeof (objectCenterDropdown));
                }

            #endregion
            }

        [TypeConverter(typeof (objectCenterDropdownDecoy))]
        public class objectCenterDropdownDecoy : GuiDecoyCtrl
            {
            [ConsoleInteraction]
            public override void onMouseLeave()
                {
                objectCenterDropdown objectCenterDropdown = "objectCenterDropdown";

                objectCenterDropdown.toggle();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(objectCenterDropdownDecoy ts, string simobjectid)
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
            public static bool operator !=(objectCenterDropdownDecoy ts, string simobjectid)
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
            public static implicit operator string(objectCenterDropdownDecoy ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator objectCenterDropdownDecoy(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (objectCenterDropdownDecoy) Omni.self.getSimObject(simobjectid, typeof (objectCenterDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(objectCenterDropdownDecoy ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator objectCenterDropdownDecoy(int simobjectid)
                {
                return
                    (objectCenterDropdownDecoy)
                        Omni.self.getSimObject((uint) simobjectid, typeof (objectCenterDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(objectCenterDropdownDecoy ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator objectCenterDropdownDecoy(uint simobjectid)
                {
                return
                    (objectCenterDropdownDecoy) Omni.self.getSimObject(simobjectid, typeof (objectCenterDropdownDecoy));
                }

            #endregion
            }

        [TypeConverter(typeof (objectSnapDropdownDecoy))]
        public class objectSnapDropdownDecoy : GuiDecoyCtrl
            {
            [ConsoleInteraction]
            public override void onMouseLeave()
                {
                GuiControl objectSnapDropdown = "objectSnapDropdown";

                objectSnapDropdown.call("toggle");
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(objectSnapDropdownDecoy ts, string simobjectid)
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
            public static bool operator !=(objectSnapDropdownDecoy ts, string simobjectid)
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
            public static implicit operator string(objectSnapDropdownDecoy ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator objectSnapDropdownDecoy(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (objectSnapDropdownDecoy) Omni.self.getSimObject(simobjectid, typeof (objectSnapDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(objectSnapDropdownDecoy ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator objectSnapDropdownDecoy(int simobjectid)
                {
                return
                    (objectSnapDropdownDecoy)
                        Omni.self.getSimObject((uint) simobjectid, typeof (objectSnapDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(objectSnapDropdownDecoy ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator objectSnapDropdownDecoy(uint simobjectid)
                {
                return (objectSnapDropdownDecoy) Omni.self.getSimObject(simobjectid, typeof (objectSnapDropdownDecoy));
                }

            #endregion
            }

        [TypeConverter(typeof (objectTransformDropdown))]
        public class objectTransformDropdown : GuiContainer
            {
            [ConsoleInteraction]
            public void toggle()
                {
                GuiControl EWorldEditorToolbar = "EWorldEditorToolbar";
                objectTransformDropdownDecoy objectTransformDropdownDecoy = "objectTransformDropdownDecoy";

                GuiBitmapButtonCtrl objectTransform = EWorldEditorToolbar.FOT("objectTransform");

                if (this["visible"].AsBool())
                    {
                    objectTransform.setStateOn(false);
                    objectTransformDropdownDecoy.setVisible(false);
                    objectTransformDropdownDecoy.setActive(false);
                    this.setVisible(false);
                    }
                else
                    {
                    objectTransform.setStateOn(true);
                    this.setVisible(true);
                    objectTransformDropdownDecoy.setActive(true);
                    objectTransformDropdownDecoy.setVisible(true);
                    }
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(objectTransformDropdown ts, string simobjectid)
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
            public static bool operator !=(objectTransformDropdown ts, string simobjectid)
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
            public static implicit operator string(objectTransformDropdown ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator objectTransformDropdown(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (objectTransformDropdown) Omni.self.getSimObject(simobjectid, typeof (objectTransformDropdown));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(objectTransformDropdown ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator objectTransformDropdown(int simobjectid)
                {
                return
                    (objectTransformDropdown)
                        Omni.self.getSimObject((uint) simobjectid, typeof (objectTransformDropdown));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(objectTransformDropdown ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator objectTransformDropdown(uint simobjectid)
                {
                return (objectTransformDropdown) Omni.self.getSimObject(simobjectid, typeof (objectTransformDropdown));
                }

            #endregion
            }

        [TypeConverter(typeof (objectTransformDropdownDecoy))]
        public class objectTransformDropdownDecoy : GuiDecoyCtrl
            {
            [ConsoleInteraction]
            public override void onMouseLeave()
                {
                objectTransformDropdown objectTransformDropdown = "objectTransformDropdown";
                objectTransformDropdown.toggle();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(objectTransformDropdownDecoy ts, string simobjectid)
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
            public static bool operator !=(objectTransformDropdownDecoy ts, string simobjectid)
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
            public static implicit operator string(objectTransformDropdownDecoy ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator objectTransformDropdownDecoy(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (objectTransformDropdownDecoy)
                        Omni.self.getSimObject(simobjectid, typeof (objectTransformDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(objectTransformDropdownDecoy ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator objectTransformDropdownDecoy(int simobjectid)
                {
                return
                    (objectTransformDropdownDecoy)
                        Omni.self.getSimObject((uint) simobjectid, typeof (objectTransformDropdownDecoy));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(objectTransformDropdownDecoy ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator objectTransformDropdownDecoy(uint simobjectid)
                {
                return
                    (objectTransformDropdownDecoy)
                        Omni.self.getSimObject(simobjectid, typeof (objectTransformDropdownDecoy));
                }

            #endregion
            }

        [TypeConverter(typeof (TypeConverterGeneric<softSnapSizeSliderCtrlContainer>))]
        public class softSnapSizeSliderCtrlContainer : EditorDropdownSliderContainer
            {
            [ConsoleInteraction]
            public override void onWake()
                {
                GuiControl EWorldEditorToolbar = "EWorldEditorToolbar";

                GuiTextEditCtrl softSnapSizeTextEdit = EWorldEditorToolbar.FOT("softSnapSizeTextEdit");
                GuiSliderCtrl slider = this.FOT("slider");

                slider.setValue(softSnapSizeTextEdit.getValue());
                }

            [ConsoleInteraction]
            public void onSliderChanged()
                {
                EWorldEditor EWorldEditor = "EWorldEditor";

                GuiSliderCtrl slider = this.FOT("slider");

                EWorldEditor.setSoftSnapSize(slider.value);
                EWorldEditor.syncGui();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(softSnapSizeSliderCtrlContainer ts, string simobjectid)
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
            public static bool operator !=(softSnapSizeSliderCtrlContainer ts, string simobjectid)
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
            public static implicit operator string(softSnapSizeSliderCtrlContainer ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator softSnapSizeSliderCtrlContainer(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return
                    (softSnapSizeSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (softSnapSizeSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(softSnapSizeSliderCtrlContainer ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator softSnapSizeSliderCtrlContainer(int simobjectid)
                {
                return
                    (softSnapSizeSliderCtrlContainer)
                        Omni.self.getSimObject((uint) simobjectid, typeof (softSnapSizeSliderCtrlContainer));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(softSnapSizeSliderCtrlContainer ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator softSnapSizeSliderCtrlContainer(uint simobjectid)
                {
                return
                    (softSnapSizeSliderCtrlContainer)
                        Omni.self.getSimObject(simobjectid, typeof (softSnapSizeSliderCtrlContainer));
                }

            #endregion
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(EditorGui ts, string simobjectid)
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
        public static bool operator !=(EditorGui ts, string simobjectid)
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
        public static implicit operator string(EditorGui ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator EditorGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (EditorGui) Omni.self.getSimObject(simobjectid, typeof (EditorGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(EditorGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator EditorGui(int simobjectid)
            {
            return (EditorGui) Omni.self.getSimObject((uint) simobjectid, typeof (EditorGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(EditorGui ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator EditorGui(uint simobjectid)
            {
            return (EditorGui) Omni.self.getSimObject(simobjectid, typeof (EditorGui));
            }

        #endregion

        //------------------------------------------------------------------------------------
        }
    }

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class EditTSCtrl
        {
        [ConsoleInteraction]
        public void updateGizmoMode(string mode)
            {
            GuiContainer EditorGuiToolbar = "EditorGuiToolbar";
            GuiBitmapButtonCtrl NoneModeBtn = EditorGuiToolbar.FOF("NoneModeBtn");
            GuiBitmapButtonCtrl MoveModeBtn = EditorGuiToolbar.FOF("MoveModeBtn");
            GuiBitmapButtonCtrl RotateModeBtn = EditorGuiToolbar.FOF("RotateModeBtn");
            GuiBitmapButtonCtrl ScaleModeBtn = EditorGuiToolbar.FOF("ScaleModeBtn");

            // Called when the gizmo mode is changed from C++

            if (mode == "None")
                NoneModeBtn.performClick();
            else if (mode == "Move")
                MoveModeBtn.performClick();
            else if (mode == "Rotate")
                RotateModeBtn.performClick();
            else if (mode == "Scale")
                ScaleModeBtn.performClick();
            }
        }
    }

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class SpawnSphere
        {
        [ConsoleInteraction]
        public override void onEditorRender(string editor, string selected, string expanded)
            {
            if (selected == "true")
                {
                ((SimObject) editor)["consoleFrameColor"] = "255 0 0";
                ((SimObject) editor)["consoleFillColor"] = "0 160 0 95";
                ((EditTSCtrl) editor).renderSphere(this.getWorldBoxCenter(), this.radius, 1);
                }
            }
        }
    }