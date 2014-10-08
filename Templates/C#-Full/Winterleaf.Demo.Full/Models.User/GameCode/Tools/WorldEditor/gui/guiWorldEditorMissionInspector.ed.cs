using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class guiWorldEditorMissionInspector
        {
        [ConsoleInteraction(true, "guiWorldEditorMissionInspector_initialize")]
        public static void initialize()
            {
            #region GuiControl (WorldEditorMissionInspector,EditorGuiGroup)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiControl", "WorldEditorMissionInspector,EditorGuiGroup",
                typeof (EWInspectorWindow));
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["isContainer"] = "1";
            oc_Newobject16["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "0 0";
            oc_Newobject16["Extent"] = "800 600";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";

            #region GuiWindowCtrl (EWInspectorWindow)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiWindowCtrl", "EWInspectorWindow");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["internalName"] = "InspectorWindow";
            oc_Newobject15["isContainer"] = "1";
            oc_Newobject15["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject15["HorizSizing"] = "left";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "333 26";
            oc_Newobject15["Extent"] = "304 448";
            oc_Newobject15["MinExtent"] = "304 448";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["Visible"] = "0";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["text"] = "Mission Inspector";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["resizeWidth"] = "1";
            oc_Newobject15["resizeHeight"] = "1";
            oc_Newobject15["canMove"] = "1";
            oc_Newobject15["canClose"] = "1";
            oc_Newobject15["canMinimize"] = "0";
            oc_Newobject15["canMaximize"] = "0";
            oc_Newobject15["minSize"] = "50 50";
            oc_Newobject15["closeCommand"] = "EWInspectorFrame.parentGroup.setVisible(false);";

            #region GuiFrameSetCtrl (EWInspectorFrame)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiFrameSetCtrl", "EWInspectorFrame");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiFrameSetProfile";
            oc_Newobject14["HorizSizing"] = "width";
            oc_Newobject14["VertSizing"] = "height";
            oc_Newobject14["position"] = "8 32";
            oc_Newobject14["Extent"] = "288 408";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["columns"] = "0";
            oc_Newobject14["rows"] = "0 206";
            oc_Newobject14["borderWidth"] = "0";
            oc_Newobject14["borderColor"] = "84 12 136 1";
            oc_Newobject14["borderEnable"] = "dynamic";
            oc_Newobject14["borderMovable"] = "dynamic";
            oc_Newobject14["autoBalance"] = "0";
            oc_Newobject14["fudgeFactor"] = "0";

            #region GuiControl (EWTreePane)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiControl", "EWTreePane");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "EditorDefaultProfile";
            oc_Newobject3["HorizSizing"] = "width";
            oc_Newobject3["VertSizing"] = "height";
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["Extent"] = "288 202";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";

            #region GuiScrollCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["isContainer"] = "1";
            oc_Newobject2["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject2["HorizSizing"] = "width";
            oc_Newobject2["VertSizing"] = "height";
            oc_Newobject2["position"] = "0 0";
            oc_Newobject2["Extent"] = "288 202";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["willFirstRespond"] = "1";
            oc_Newobject2["hScrollBar"] = "alwaysOff";
            oc_Newobject2["vScrollBar"] = "dynamic";
            oc_Newobject2["lockHorizScroll"] = "true";
            oc_Newobject2["lockVertScroll"] = "false";
            oc_Newobject2["constantThumbHeight"] = "0";
            oc_Newobject2["childMargin"] = "0 0";

            #region GuiTreeViewCtrl (EditorTree)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTreeViewCtrl", "EditorTree", typeof (EditorTree));
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["isContainer"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["position"] = "2 2";
            oc_Newobject1["Extent"] = "226 21";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["tabSize"] = "16";
            oc_Newobject1["textOffset"] = "2";
            oc_Newobject1["fullRowSelect"] = "0";
            oc_Newobject1["itemHeight"] = "21";
            oc_Newobject1["destroyTreeOnSleep"] = "1";
            oc_Newobject1["MouseDragging"] = "1";
            oc_Newobject1["MultipleSelections"] = "1";
            oc_Newobject1["DeleteObjectAllowed"] = "1";
            oc_Newobject1["DragToItemAllowed"] = "1";

            #endregion

            oc_Newobject2["#Newobject1"] = oc_Newobject1;

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject14["#Newobject3"] = oc_Newobject3;

            #region GuiControl (EWCreatorInspectorPane)        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiControl", "EWCreatorInspectorPane");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "EditorDefaultProfile";
            oc_Newobject13["HorizSizing"] = "width";
            oc_Newobject13["VertSizing"] = "height";
            oc_Newobject13["position"] = "0 206";
            oc_Newobject13["Extent"] = "288 202";
            oc_Newobject13["MinExtent"] = "8 8";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["hovertime"] = "1000";

            #region GuiScrollCtrl (EWCreatorPane)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiScrollCtrl", "EWCreatorPane");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "height";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["Extent"] = "288 202";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "0";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["willFirstRespond"] = "1";
            oc_Newobject5["hScrollBar"] = "dynamic";
            oc_Newobject5["vScrollBar"] = "dynamic";
            oc_Newobject5["lockHorizScroll"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject5["lockVertScroll"] = "false";
            oc_Newobject5["constantThumbHeight"] = "0";
            oc_Newobject5["childMargin"] = "0 0";

            #region GuiTreeViewCtrl (Creator)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTreeViewCtrl", "Creator");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["Profile"] = "ToolsGuiTreeViewProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "2 2";
            oc_Newobject4["Extent"] = "131 84";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["tabSize"] = "16";
            oc_Newobject4["textOffset"] = "2";
            oc_Newobject4["fullRowSelect"] = "0";
            oc_Newobject4["itemHeight"] = "21";
            oc_Newobject4["destroyTreeOnSleep"] = "1";
            oc_Newobject4["MouseDragging"] = "1";
            oc_Newobject4["MultipleSelections"] = "1";
            oc_Newobject4["DeleteObjectAllowed"] = "1";
            oc_Newobject4["DragToItemAllowed"] = "1";

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject13["#Newobject5"] = oc_Newobject5;

            #region GuiControl (EWInspectorPane)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiControl", "EWInspectorPane");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["isContainer"] = "1";
            oc_Newobject12["Profile"] = "EditorDefaultProfile";
            oc_Newobject12["HorizSizing"] = "width";
            oc_Newobject12["VertSizing"] = "height";
            oc_Newobject12["position"] = "0 0";
            oc_Newobject12["Extent"] = "288 202";
            oc_Newobject12["MinExtent"] = "8 8";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiSolidDefaultProfile";
            oc_Newobject9["HorizSizing"] = "width";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["Extent"] = "288 24";
            oc_Newobject9["MinExtent"] = "8 8";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["hovertime"] = "1000";

            #region GuiButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "2 2";
            oc_Newobject6["Extent"] = "40 20";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["Command"] = "EWorldEditor.isDirty = true;EWorldEditor.makeFirstResponder(true);";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["ToolTip"] = "Don\'t forget to hit Apply after making changes!";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["text"] = "Apply";
            oc_Newobject6["groupNum"] = "-1";
            oc_Newobject6["buttonType"] = "PushButton";
            oc_Newobject6["useMouseEvents"] = "0";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "GuiInspectorFieldProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "52 4";
            oc_Newobject7["Extent"] = "42 16";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["text"] = "Name:";
            oc_Newobject7["maxLength"] = "1024";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl (InspectorNameEdit)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "InspectorNameEdit");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "GuiInspectorBackgroundProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "97 4";
            oc_Newobject8["Extent"] = "758 18";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["AltCommand"] = "EWorldEditor.isDirty = true;";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["passwordMask"] = "*";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject12["#Newobject9"] = oc_Newobject9;

            #region GuiScrollCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["isContainer"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject11["HorizSizing"] = "width";
            oc_Newobject11["VertSizing"] = "height";
            oc_Newobject11["position"] = "0 24";
            oc_Newobject11["Extent"] = "288 178";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["willFirstRespond"] = "1";
            oc_Newobject11["hScrollBar"] = "dynamic";
            oc_Newobject11["vScrollBar"] = "dynamic";
            oc_Newobject11["lockHorizScroll"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject11["lockVertScroll"] = "false";
            oc_Newobject11["constantThumbHeight"] = "0";
            oc_Newobject11["childMargin"] = "0 0";

            #region GuiInspector (Inspector)        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiInspector", "Inspector", typeof(Inspector));
            oc_Newobject10["StackingType"] = "Vertical";
            oc_Newobject10["HorizStacking"] = "Left to Right";
            oc_Newobject10["VertStacking"] = "Top to Bottom";
            oc_Newobject10["Padding"] = "1";
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["isContainer"] = "1";
            oc_Newobject10["Profile"] = "GuiInspectorBackgroundProfile";
            oc_Newobject10["HorizSizing"] = "width";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["position"] = "2 2";
            oc_Newobject10["Extent"] = "266 8";
            oc_Newobject10["MinExtent"] = "8 8";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["hovertime"] = "1000";

            #endregion

            oc_Newobject11["#Newobject10"] = oc_Newobject10;

            #endregion

            oc_Newobject12["#Newobject11"] = oc_Newobject11;

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject15["#Newobject14"] = oc_Newobject14;

            #endregion

            oc_Newobject16["#Newobject15"] = oc_Newobject15;

            #endregion

            oc_Newobject16.Create();
            }
        }
    }