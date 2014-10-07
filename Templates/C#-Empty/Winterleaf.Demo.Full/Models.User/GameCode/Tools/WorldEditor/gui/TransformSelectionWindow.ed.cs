using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class TransformSelectionWindow
        {
        [ConsoleInteraction(true, "TransformSelectionWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl (TransformSelectionContainer, EditorGuiGroup)        oc_Newobject59

            ObjectCreator oc_Newobject59 = new ObjectCreator("GuiControl", "TransformSelectionContainer, EditorGuiGroup");
            oc_Newobject59["canSaveDynamicFields"] = "0";
            oc_Newobject59["Enabled"] = "1";
            oc_Newobject59["isContainer"] = "1";
            oc_Newobject59["Profile"] = "ToolsGuiModelessDialogProfile";
            oc_Newobject59["HorizSizing"] = "right";
            oc_Newobject59["VertSizing"] = "bottom";
            oc_Newobject59["Position"] = "0 0";
            oc_Newobject59["Extent"] = "800 600";
            oc_Newobject59["MinExtent"] = "8 2";
            oc_Newobject59["canSave"] = "1";
            oc_Newobject59["isDecoy"] = "0";
            oc_Newobject59["Visible"] = "1";
            oc_Newobject59["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject59["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (ETransformSelection)        oc_Newobject58

            ObjectCreator oc_Newobject58 = new ObjectCreator("GuiWindowCollapseCtrl", "ETransformSelection",
                typeof (ETransformSelection));
            oc_Newobject58["internalName"] = "TransformSelectionWindow";
            oc_Newobject58["Enabled"] = "1";
            oc_Newobject58["isContainer"] = "1";
            oc_Newobject58["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject58["HorizSizing"] = "windowRelative";
            oc_Newobject58["VertSizing"] = "windowRelative";
            oc_Newobject58["resizeWidth"] = "1";
            oc_Newobject58["resizeHeight"] = "1";
            oc_Newobject58["canClose"] = "1";
            oc_Newobject58["canMinimize"] = "0";
            oc_Newobject58["canMaximize"] = "0";
            oc_Newobject58["position"] = "40 70";
            oc_Newobject58["extent"] = "180 508";
            oc_Newobject58["MinExtent"] = "120 130";
            oc_Newobject58["text"] = "Transform Selection";
            oc_Newobject58["closeCommand"] = "ETransformSelection.hideDialog();";
            oc_Newobject58["EdgeSnap"] = "0";
            oc_Newobject58["canCollapse"] = "0";
            oc_Newobject58["visible"] = "0";
            oc_Newobject58["Margin"] = "5 5 5 5";
            oc_Newobject58["Padding"] = "5 5 5 5";

            #region GuiScrollCtrl ()        oc_Newobject54

            ObjectCreator oc_Newobject54 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject54["canSaveDynamicFields"] = "0";
            oc_Newobject54["Enabled"] = "1";
            oc_Newobject54["isContainer"] = "1";
            oc_Newobject54["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject54["HorizSizing"] = "width";
            oc_Newobject54["VertSizing"] = "height";
            oc_Newobject54["Position"] = "4 12";
            oc_Newobject54["Extent"] = "156 190";
            oc_Newobject54["MinExtent"] = "8 2";
            oc_Newobject54["canSave"] = "1";
            oc_Newobject54["isDecoy"] = "0";
            oc_Newobject54["Visible"] = "1";
            oc_Newobject54["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject54["hovertime"] = "1000";
            oc_Newobject54["Docking"] = "Client";
            oc_Newobject54["Margin"] = "5 5 5 4";
            oc_Newobject54["Padding"] = "0 0 0 0";
            oc_Newobject54["AnchorTop"] = "1";
            oc_Newobject54["AnchorBottom"] = "0";
            oc_Newobject54["AnchorLeft"] = "1";
            oc_Newobject54["AnchorRight"] = "0";
            oc_Newobject54["willFirstRespond"] = "1";
            oc_Newobject54["hScrollBar"] = "alwaysOff";
            oc_Newobject54["vScrollBar"] = "dynamic";
            oc_Newobject54["lockHorizScroll"] = "true";
            oc_Newobject54["lockVertScroll"] = "false";
            oc_Newobject54["constantThumbHeight"] = "0";
            oc_Newobject54["childMargin"] = "2 2";

            #region GuiStackControl ()        oc_Newobject53

            ObjectCreator oc_Newobject53 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject53["StackingType"] = "Vertical";
            oc_Newobject53["HorizStacking"] = "Left to Right";
            oc_Newobject53["VertStacking"] = "Top to Bottom";
            oc_Newobject53["Padding"] = "5";
            oc_Newobject53["canSaveDynamicFields"] = "0";
            oc_Newobject53["Enabled"] = "1";
            oc_Newobject53["isContainer"] = "1";
            oc_Newobject53["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject53["HorizSizing"] = "width";
            oc_Newobject53["VertSizing"] = "bottom";
            oc_Newobject53["Position"] = "0 0";
            oc_Newobject53["Extent"] = "140 300";
            oc_Newobject53["MinExtent"] = "16 16";
            oc_Newobject53["canSave"] = "1";
            oc_Newobject53["isDecoy"] = "0";
            oc_Newobject53["Visible"] = "1";
            oc_Newobject53["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject53["hovertime"] = "1000";

            #region GuiControl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiControl", "");
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "0 0";
            oc_Newobject10["Extent"] = "140 106";
            oc_Newobject10["MinExtent"] = "16 16";
            oc_Newobject10["Visible"] = "1";

            #region GuiCheckBoxCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject1["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject1["internalName"] = "DoPosition";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject1["position"] = "1 0";
            oc_Newobject1["Extent"] = "190 18";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["tooltip"] = "Apply changes to position";
            oc_Newobject1["text"] = "Position";
            oc_Newobject1["Command"] = "";

            #endregion

            oc_Newobject10["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "",
                typeof (ETransformSelection.ETransformSelectionButtonClass));
            //oc_Newobject2["class"] = "ETransformSelectionButtonClass";
            oc_Newobject2["internalName"] = "GetPosButton";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "100 0";
            oc_Newobject2["Extent"] = "30 18";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "ETransformSelection.getAbsPosition();";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["tooltip"] = "Get absolute position for selected objects";
            oc_Newobject2["text"] = "Get";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject10["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "20 22";
            oc_Newobject3["Extent"] = "20 18";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["text"] = "X:";
            oc_Newobject3["maxLength"] = "1024";

            #endregion

            oc_Newobject10["#Newobject3"] = oc_Newobject3;

            #region GuiTextEditCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject4["class"] = "ETransformSelectionTextEdit";
            oc_Newobject4["internalName"] = "PosX";
            oc_Newobject4["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject4["HorizSizing"] = "width";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["position"] = "40 22";
            oc_Newobject4["Extent"] = "90 18";
            oc_Newobject4["text"] = "0.0";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["AltCommand"] = "";

            #endregion

            oc_Newobject10["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["position"] = "20 44";
            oc_Newobject5["Extent"] = "20 18";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["text"] = "Y:";
            oc_Newobject5["maxLength"] = "1024";

            #endregion

            oc_Newobject10["#Newobject5"] = oc_Newobject5;

            #region GuiTextEditCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject6["class"] = "ETransformSelectionTextEdit";
            oc_Newobject6["internalName"] = "PosY";
            oc_Newobject6["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["position"] = "40 44";
            oc_Newobject6["Extent"] = "90 18";
            oc_Newobject6["text"] = "0.0";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["AltCommand"] = "";

            #endregion

            oc_Newobject10["#Newobject6"] = oc_Newobject6;

            #region GuiTextCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["position"] = "20 66";
            oc_Newobject7["Extent"] = "20 18";
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
            oc_Newobject7["text"] = "Z:";
            oc_Newobject7["maxLength"] = "1024";

            #endregion

            oc_Newobject10["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject8["class"] = "ETransformSelectionTextEdit";
            oc_Newobject8["internalName"] = "PosZ";
            oc_Newobject8["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject8["HorizSizing"] = "width";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["position"] = "40 66";
            oc_Newobject8["Extent"] = "90 18";
            oc_Newobject8["text"] = "0.0";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["AltCommand"] = "";

            #endregion

            oc_Newobject10["#Newobject8"] = oc_Newobject8;

            #region GuiCheckBoxCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject9["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject9["internalName"] = "PosRelative";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject9["position"] = "40 88";
            oc_Newobject9["Extent"] = "120 18";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["tooltip"] = "Add values to current position (checked) or set absolute position (unchecked)";
            oc_Newobject9["text"] = "Relative";
            oc_Newobject9["Command"] = "";

            #endregion

            oc_Newobject10["#Newobject9"] = oc_Newobject9;

            #endregion

            oc_Newobject53["#Newobject10"] = oc_Newobject10;

            #region GuiBitmapCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject11["position"] = "0 0";
            oc_Newobject11["Extent"] = "100 2";
            oc_Newobject11["MinExtent"] = "1 1";
            oc_Newobject11["bitmap"] = "tools/gui/images/separator-v.png";

            #endregion

            oc_Newobject53["#Newobject11"] = oc_Newobject11;

            #region GuiControl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "");
            oc_Newobject22["Enabled"] = "1";
            oc_Newobject22["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject22["HorizSizing"] = "width";
            oc_Newobject22["VertSizing"] = "bottom";
            oc_Newobject22["Position"] = "0 0";
            oc_Newobject22["Extent"] = "140 128";
            oc_Newobject22["MinExtent"] = "16 16";
            oc_Newobject22["Visible"] = "1";

            #region GuiCheckBoxCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject12["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject12["internalName"] = "DoRotation";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject12["position"] = "1 0";
            oc_Newobject12["Extent"] = "190 18";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["tooltip"] = "Apply changes to rotation";
            oc_Newobject12["text"] = "Rotation";
            oc_Newobject12["Command"] = "";

            #endregion

            oc_Newobject22["#Newobject12"] = oc_Newobject12;

            #region GuiButtonCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiButtonCtrl", "",
                typeof (ETransformSelection.ETransformSelectionButtonClass));
            //oc_Newobject13["class"] = "ETransformSelectionButtonClass";
            oc_Newobject13["internalName"] = "GetRotButton";
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject13["HorizSizing"] = "left";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "100 0";
            oc_Newobject13["Extent"] = "30 18";
            oc_Newobject13["MinExtent"] = "8 8";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["Command"] = "ETransformSelection.getAbsRotation();";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["tooltip"] = "Get absolute rotation for selected objects";
            oc_Newobject13["text"] = "Get";
            oc_Newobject13["groupNum"] = "-1";
            oc_Newobject13["buttonType"] = "PushButton";
            oc_Newobject13["useMouseEvents"] = "0";

            #endregion

            oc_Newobject22["#Newobject13"] = oc_Newobject13;

            #region GuiTextCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["position"] = "20 22";
            oc_Newobject14["Extent"] = "20 18";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["Margin"] = "0 0 0 0";
            oc_Newobject14["Padding"] = "0 0 0 0";
            oc_Newobject14["AnchorTop"] = "1";
            oc_Newobject14["AnchorBottom"] = "0";
            oc_Newobject14["AnchorLeft"] = "1";
            oc_Newobject14["AnchorRight"] = "0";
            oc_Newobject14["text"] = "H:";
            oc_Newobject14["maxLength"] = "1024";

            #endregion

            oc_Newobject22["#Newobject14"] = oc_Newobject14;

            #region GuiTextEditCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject15["class"] = "ETransformSelectionTextEdit";
            oc_Newobject15["internalName"] = "Heading";
            oc_Newobject15["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject15["HorizSizing"] = "width";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["position"] = "40 22";
            oc_Newobject15["Extent"] = "90 18";
            oc_Newobject15["text"] = "0.0";
            oc_Newobject15["maxLength"] = "1024";
            oc_Newobject15["AltCommand"] = "";

            #endregion

            oc_Newobject22["#Newobject15"] = oc_Newobject15;

            #region GuiTextCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["position"] = "20 44";
            oc_Newobject16["Extent"] = "20 18";
            oc_Newobject16["MinExtent"] = "8 2";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["text"] = "P:";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject22["#Newobject16"] = oc_Newobject16;

            #region GuiTextEditCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject17["class"] = "ETransformSelectionTextEdit";
            oc_Newobject17["internalName"] = "Pitch";
            oc_Newobject17["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject17["HorizSizing"] = "width";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["position"] = "40 44";
            oc_Newobject17["Extent"] = "90 18";
            oc_Newobject17["text"] = "0.0";
            oc_Newobject17["maxLength"] = "1024";
            oc_Newobject17["AltCommand"] = "";

            #endregion

            oc_Newobject22["#Newobject17"] = oc_Newobject17;

            #region GuiTextCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "0";
            oc_Newobject18["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject18["HorizSizing"] = "right";
            oc_Newobject18["VertSizing"] = "bottom";
            oc_Newobject18["position"] = "20 66";
            oc_Newobject18["Extent"] = "20 18";
            oc_Newobject18["MinExtent"] = "8 2";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["Visible"] = "1";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["Margin"] = "0 0 0 0";
            oc_Newobject18["Padding"] = "0 0 0 0";
            oc_Newobject18["AnchorTop"] = "1";
            oc_Newobject18["AnchorBottom"] = "0";
            oc_Newobject18["AnchorLeft"] = "1";
            oc_Newobject18["AnchorRight"] = "0";
            oc_Newobject18["text"] = "B:";
            oc_Newobject18["maxLength"] = "1024";

            #endregion

            oc_Newobject22["#Newobject18"] = oc_Newobject18;

            #region GuiTextEditCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject19["class"] = "ETransformSelectionTextEdit";
            oc_Newobject19["internalName"] = "Bank";
            oc_Newobject19["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject19["HorizSizing"] = "width";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["position"] = "40 66";
            oc_Newobject19["Extent"] = "90 18";
            oc_Newobject19["text"] = "0.0";
            oc_Newobject19["maxLength"] = "1024";
            oc_Newobject19["AltCommand"] = "";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiCheckBoxCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject20["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject20["internalName"] = "RotRelative";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject20["position"] = "40 88";
            oc_Newobject20["Extent"] = "120 18";
            oc_Newobject20["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["tooltip"] = "Add values to current rotation (checked) or set absolute rotation (unchecked)";
            oc_Newobject20["text"] = "Relative";
            oc_Newobject20["Command"] = "ETransformSelection.RotRelativeChanged();";

            #endregion

            oc_Newobject22["#Newobject20"] = oc_Newobject20;

            #region GuiCheckBoxCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject21["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject21["internalName"] = "RotLocal";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject21["position"] = "40 110";
            oc_Newobject21["Extent"] = "120 18";
            oc_Newobject21["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";
            oc_Newobject21["tooltip"] = "Use object's local origin to rotate from";
            oc_Newobject21["text"] = "Local Center";
            oc_Newobject21["Command"] = "ETransformSelection.RotLocalChanged();";

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject53["#Newobject22"] = oc_Newobject22;

            #region GuiBitmapCtrl ()        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiBitmapCtrl", "");
            oc_Newobject23["Enabled"] = "1";
            oc_Newobject23["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject23["position"] = "0 0";
            oc_Newobject23["Extent"] = "100 2";
            oc_Newobject23["MinExtent"] = "1 1";
            oc_Newobject23["bitmap"] = "tools/gui/images/separator-v.png";

            #endregion

            oc_Newobject53["#Newobject23"] = oc_Newobject23;

            #region GuiTabBookCtrl ()        oc_Newobject52

            ObjectCreator oc_Newobject52 = new ObjectCreator("GuiTabBookCtrl", "");
            oc_Newobject52["internalName"] = "ScaleTabBook";
            oc_Newobject52["canSaveDynamicFields"] = "0";
            oc_Newobject52["isContainer"] = "1";
            oc_Newobject52["Profile"] = "ToolsGuiTabBookProfile";
            oc_Newobject52["HorizSizing"] = "width";
            oc_Newobject52["VertSizing"] = "bottom";
            oc_Newobject52["position"] = "0 0";
            oc_Newobject52["Extent"] = "140 176";
            oc_Newobject52["MinExtent"] = "16 16";
            oc_Newobject52["canSave"] = "1";
            oc_Newobject52["Visible"] = "1";
            oc_Newobject52["hovertime"] = "1000";
            oc_Newobject52["Margin"] = "3 2 3 3";
            oc_Newobject52["Padding"] = "0 0 0 0";
            oc_Newobject52["AnchorTop"] = "1";
            oc_Newobject52["AnchorBottom"] = "0";
            oc_Newobject52["AnchorLeft"] = "1";
            oc_Newobject52["AnchorRight"] = "0";
            oc_Newobject52["TabPosition"] = "Top";
            oc_Newobject52["TabMargin"] = "0";
            oc_Newobject52["MinTabWidth"] = "50";

            #region GuiTabPageCtrl ()        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject37["canSaveDynamicFields"] = "0";
            oc_Newobject37["Enabled"] = "1";
            oc_Newobject37["isContainer"] = "1";
            oc_Newobject37["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject37["HorizSizing"] = "width";
            oc_Newobject37["VertSizing"] = "height";
            oc_Newobject37["position"] = "0 19";
            oc_Newobject37["Extent"] = "140 156";
            oc_Newobject37["MinExtent"] = "8 2";
            oc_Newobject37["canSave"] = "1";
            oc_Newobject37["Visible"] = "1";
            oc_Newobject37["hovertime"] = "1000";
            oc_Newobject37["Margin"] = "0 0 0 0";
            oc_Newobject37["Padding"] = "0 0 0 0";
            oc_Newobject37["AnchorTop"] = "1";
            oc_Newobject37["AnchorBottom"] = "0";
            oc_Newobject37["AnchorLeft"] = "1";
            oc_Newobject37["AnchorRight"] = "0";
            oc_Newobject37["text"] = "Scale";
            oc_Newobject37["maxLength"] = "1024";

            #region GuiBitmapBorderCtrl ()        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject24["canSaveDynamicFields"] = "0";
            oc_Newobject24["Enabled"] = "1";
            oc_Newobject24["isContainer"] = "0";
            oc_Newobject24["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject24["HorizSizing"] = "width";
            oc_Newobject24["VertSizing"] = "bottom";
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["Extent"] = "134 156";
            oc_Newobject24["MinExtent"] = "8 2";
            oc_Newobject24["canSave"] = "0";
            oc_Newobject24["Visible"] = "1";
            oc_Newobject24["hovertime"] = "1000";

            #endregion

            oc_Newobject37["#Newobject24"] = oc_Newobject24;

            #region GuiControl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiControl", "");
            oc_Newobject36["Enabled"] = "1";
            oc_Newobject36["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject36["HorizSizing"] = "width";
            oc_Newobject36["VertSizing"] = "bottom";
            oc_Newobject36["Position"] = "0 0";
            oc_Newobject36["Extent"] = "134 156";
            oc_Newobject36["MinExtent"] = "16 16";
            oc_Newobject36["Visible"] = "1";

            #region GuiCheckBoxCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject25["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject25["internalName"] = "DoScale";
            oc_Newobject25["Enabled"] = "1";
            oc_Newobject25["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject25["position"] = "2 4";
            oc_Newobject25["Extent"] = "100 18";
            oc_Newobject25["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject25["hovertime"] = "1000";
            oc_Newobject25["tooltip"] = "Apply changes to scale";
            oc_Newobject25["text"] = "Scale";
            oc_Newobject25["Command"] = "";

            #endregion

            oc_Newobject36["#Newobject25"] = oc_Newobject25;

            #region GuiButtonCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiButtonCtrl", "",
                typeof (ETransformSelection.ETransformSelectionButtonClass));
            //oc_Newobject26["class"] = "ETransformSelectionButtonClass";
            oc_Newobject26["internalName"] = "GetScaleButton";
            oc_Newobject26["canSaveDynamicFields"] = "0";
            oc_Newobject26["Enabled"] = "1";
            oc_Newobject26["isContainer"] = "0";
            oc_Newobject26["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject26["HorizSizing"] = "left";
            oc_Newobject26["VertSizing"] = "bottom";
            oc_Newobject26["Position"] = "100 4";
            oc_Newobject26["Extent"] = "30 18";
            oc_Newobject26["MinExtent"] = "8 8";
            oc_Newobject26["canSave"] = "1";
            oc_Newobject26["Visible"] = "1";
            oc_Newobject26["Command"] = "ETransformSelection.getAbsScale();";
            oc_Newobject26["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject26["hovertime"] = "1000";
            oc_Newobject26["tooltip"] = "Get absolute scale for selected objects";
            oc_Newobject26["text"] = "Get";
            oc_Newobject26["groupNum"] = "-1";
            oc_Newobject26["buttonType"] = "PushButton";
            oc_Newobject26["useMouseEvents"] = "0";

            #endregion

            oc_Newobject36["#Newobject26"] = oc_Newobject26;

            #region GuiTextCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject27["canSaveDynamicFields"] = "0";
            oc_Newobject27["Enabled"] = "1";
            oc_Newobject27["isContainer"] = "0";
            oc_Newobject27["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject27["HorizSizing"] = "right";
            oc_Newobject27["VertSizing"] = "bottom";
            oc_Newobject27["position"] = "20 26";
            oc_Newobject27["Extent"] = "20 18";
            oc_Newobject27["MinExtent"] = "8 2";
            oc_Newobject27["canSave"] = "1";
            oc_Newobject27["Visible"] = "1";
            oc_Newobject27["hovertime"] = "1000";
            oc_Newobject27["Margin"] = "0 0 0 0";
            oc_Newobject27["Padding"] = "0 0 0 0";
            oc_Newobject27["AnchorTop"] = "1";
            oc_Newobject27["AnchorBottom"] = "0";
            oc_Newobject27["AnchorLeft"] = "1";
            oc_Newobject27["AnchorRight"] = "0";
            oc_Newobject27["text"] = "X:";
            oc_Newobject27["maxLength"] = "1024";

            #endregion

            oc_Newobject36["#Newobject27"] = oc_Newobject27;

            #region GuiTextEditCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject28["class"] = "ETransformSelectionTextEdit";
            oc_Newobject28["internalName"] = "ScaleX";
            oc_Newobject28["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject28["HorizSizing"] = "width";
            oc_Newobject28["VertSizing"] = "bottom";
            oc_Newobject28["position"] = "40 26";
            oc_Newobject28["Extent"] = "90 18";
            oc_Newobject28["text"] = "1.0";
            oc_Newobject28["maxLength"] = "1024";
            oc_Newobject28["AltCommand"] = "";

            #endregion

            oc_Newobject36["#Newobject28"] = oc_Newobject28;

            #region GuiTextCtrl ()        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject29["canSaveDynamicFields"] = "0";
            oc_Newobject29["Enabled"] = "1";
            oc_Newobject29["isContainer"] = "0";
            oc_Newobject29["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject29["HorizSizing"] = "right";
            oc_Newobject29["VertSizing"] = "bottom";
            oc_Newobject29["position"] = "20 48";
            oc_Newobject29["Extent"] = "20 18";
            oc_Newobject29["MinExtent"] = "8 2";
            oc_Newobject29["canSave"] = "1";
            oc_Newobject29["Visible"] = "1";
            oc_Newobject29["hovertime"] = "1000";
            oc_Newobject29["Margin"] = "0 0 0 0";
            oc_Newobject29["Padding"] = "0 0 0 0";
            oc_Newobject29["AnchorTop"] = "1";
            oc_Newobject29["AnchorBottom"] = "0";
            oc_Newobject29["AnchorLeft"] = "1";
            oc_Newobject29["AnchorRight"] = "0";
            oc_Newobject29["text"] = "Y:";
            oc_Newobject29["maxLength"] = "1024";

            #endregion

            oc_Newobject36["#Newobject29"] = oc_Newobject29;

            #region GuiTextEditCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject30["class"] = "ETransformSelectionTextEdit";
            oc_Newobject30["internalName"] = "ScaleY";
            oc_Newobject30["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject30["HorizSizing"] = "width";
            oc_Newobject30["VertSizing"] = "bottom";
            oc_Newobject30["position"] = "40 48";
            oc_Newobject30["Extent"] = "90 18";
            oc_Newobject30["text"] = "1.0";
            oc_Newobject30["maxLength"] = "1024";
            oc_Newobject30["AltCommand"] = "";

            #endregion

            oc_Newobject36["#Newobject30"] = oc_Newobject30;

            #region GuiTextCtrl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject31["canSaveDynamicFields"] = "0";
            oc_Newobject31["Enabled"] = "1";
            oc_Newobject31["isContainer"] = "0";
            oc_Newobject31["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject31["HorizSizing"] = "right";
            oc_Newobject31["VertSizing"] = "bottom";
            oc_Newobject31["position"] = "20 70";
            oc_Newobject31["Extent"] = "20 18";
            oc_Newobject31["MinExtent"] = "8 2";
            oc_Newobject31["canSave"] = "1";
            oc_Newobject31["Visible"] = "1";
            oc_Newobject31["hovertime"] = "1000";
            oc_Newobject31["Margin"] = "0 0 0 0";
            oc_Newobject31["Padding"] = "0 0 0 0";
            oc_Newobject31["AnchorTop"] = "1";
            oc_Newobject31["AnchorBottom"] = "0";
            oc_Newobject31["AnchorLeft"] = "1";
            oc_Newobject31["AnchorRight"] = "0";
            oc_Newobject31["text"] = "Z:";
            oc_Newobject31["maxLength"] = "1024";

            #endregion

            oc_Newobject36["#Newobject31"] = oc_Newobject31;

            #region GuiTextEditCtrl ()        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject32["class"] = "ETransformSelectionTextEdit";
            oc_Newobject32["internalName"] = "ScaleZ";
            oc_Newobject32["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject32["HorizSizing"] = "width";
            oc_Newobject32["VertSizing"] = "bottom";
            oc_Newobject32["position"] = "40 70";
            oc_Newobject32["Extent"] = "90 18";
            oc_Newobject32["text"] = "1.0";
            oc_Newobject32["maxLength"] = "1024";
            oc_Newobject32["AltCommand"] = "";

            #endregion

            oc_Newobject36["#Newobject32"] = oc_Newobject32;

            #region GuiCheckBoxCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject33["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject33["internalName"] = "ScaleRelative";
            oc_Newobject33["Enabled"] = "1";
            oc_Newobject33["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject33["position"] = "40 92";
            oc_Newobject33["Extent"] = "120 18";
            oc_Newobject33["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject33["hovertime"] = "1000";
            oc_Newobject33["tooltip"] = "Add values to current scale (checked) or set absolute scale (unchecked)";
            oc_Newobject33["text"] = "Relative";
            oc_Newobject33["Command"] = "";

            #endregion

            oc_Newobject36["#Newobject33"] = oc_Newobject33;

            #region GuiCheckBoxCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject34["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject34["internalName"] = "ScaleLocal";
            oc_Newobject34["Enabled"] = "1";
            oc_Newobject34["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject34["position"] = "40 114";
            oc_Newobject34["Extent"] = "120 18";
            oc_Newobject34["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject34["hovertime"] = "1000";
            oc_Newobject34["tooltip"] = "Use object's local origin to scale from";
            oc_Newobject34["text"] = "Local Center";
            oc_Newobject34["Command"] = "";

            #endregion

            oc_Newobject36["#Newobject34"] = oc_Newobject34;

            #region GuiCheckBoxCtrl (ETransformSelectionScaleProportional)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiCheckBoxCtrl", "ETransformSelectionScaleProportional",
                typeof (ETransformSelection.ETransformSelectionScaleProportional));
            //oc_Newobject35["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject35["internalName"] = "ScaleProportional";
            oc_Newobject35["Enabled"] = "1";
            oc_Newobject35["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject35["position"] = "40 136";
            oc_Newobject35["Extent"] = "120 18";
            oc_Newobject35["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject35["hovertime"] = "1000";
            oc_Newobject35["tooltip"] = "Scale equally in all directions";
            oc_Newobject35["text"] = "Constrain Proportions";
            oc_Newobject35["Command"] = "";

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject52["#Newobject37"] = oc_Newobject37;

            #region GuiTabPageCtrl ()        oc_Newobject51

            ObjectCreator oc_Newobject51 = new ObjectCreator("GuiTabPageCtrl", "");
            oc_Newobject51["canSaveDynamicFields"] = "0";
            oc_Newobject51["Enabled"] = "1";
            oc_Newobject51["isContainer"] = "1";
            oc_Newobject51["Profile"] = "ToolsGuiTabPageProfile";
            oc_Newobject51["HorizSizing"] = "width";
            oc_Newobject51["VertSizing"] = "height";
            oc_Newobject51["position"] = "0 19";
            oc_Newobject51["Extent"] = "140 156";
            oc_Newobject51["MinExtent"] = "8 2";
            oc_Newobject51["canSave"] = "1";
            oc_Newobject51["Visible"] = "1";
            oc_Newobject51["hovertime"] = "1000";
            oc_Newobject51["Margin"] = "0 0 0 0";
            oc_Newobject51["Padding"] = "0 0 0 0";
            oc_Newobject51["AnchorTop"] = "1";
            oc_Newobject51["AnchorBottom"] = "0";
            oc_Newobject51["AnchorLeft"] = "1";
            oc_Newobject51["AnchorRight"] = "0";
            oc_Newobject51["text"] = "Size";
            oc_Newobject51["maxLength"] = "1024";

            #region GuiBitmapBorderCtrl ()        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject38["canSaveDynamicFields"] = "0";
            oc_Newobject38["Enabled"] = "1";
            oc_Newobject38["isContainer"] = "0";
            oc_Newobject38["Profile"] = "ToolsGuiTabBorderProfile";
            oc_Newobject38["HorizSizing"] = "width";
            oc_Newobject38["VertSizing"] = "bottom";
            oc_Newobject38["position"] = "0 0";
            oc_Newobject38["Extent"] = "134 156";
            oc_Newobject38["MinExtent"] = "8 2";
            oc_Newobject38["canSave"] = "0";
            oc_Newobject38["Visible"] = "1";
            oc_Newobject38["hovertime"] = "1000";

            #endregion

            oc_Newobject51["#Newobject38"] = oc_Newobject38;

            #region GuiControl ()        oc_Newobject50

            ObjectCreator oc_Newobject50 = new ObjectCreator("GuiControl", "");
            oc_Newobject50["Enabled"] = "1";
            oc_Newobject50["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject50["HorizSizing"] = "width";
            oc_Newobject50["VertSizing"] = "bottom";
            oc_Newobject50["Position"] = "0 0";
            oc_Newobject50["Extent"] = "134 156";
            oc_Newobject50["MinExtent"] = "16 16";
            oc_Newobject50["Visible"] = "1";

            #region GuiCheckBoxCtrl ()        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject39["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject39["internalName"] = "DoSize";
            oc_Newobject39["Enabled"] = "1";
            oc_Newobject39["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject39["position"] = "2 4";
            oc_Newobject39["Extent"] = "100 18";
            oc_Newobject39["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject39["hovertime"] = "1000";
            oc_Newobject39["tooltip"] = "Apply changes to size";
            oc_Newobject39["text"] = "Size";
            oc_Newobject39["Command"] = "";

            #endregion

            oc_Newobject50["#Newobject39"] = oc_Newobject39;

            #region GuiButtonCtrl ()        oc_Newobject40

            ObjectCreator oc_Newobject40 = new ObjectCreator("GuiButtonCtrl", "",
                typeof (ETransformSelection.ETransformSelectionButtonClass));
            //oc_Newobject40["class"] = "ETransformSelectionButtonClass";
            oc_Newobject40["internalName"] = "GetSizeButton";
            oc_Newobject40["canSaveDynamicFields"] = "0";
            oc_Newobject40["Enabled"] = "1";
            oc_Newobject40["isContainer"] = "0";
            oc_Newobject40["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject40["HorizSizing"] = "left";
            oc_Newobject40["VertSizing"] = "bottom";
            oc_Newobject40["Position"] = "100 4";
            oc_Newobject40["Extent"] = "30 18";
            oc_Newobject40["MinExtent"] = "8 8";
            oc_Newobject40["canSave"] = "1";
            oc_Newobject40["Visible"] = "1";
            oc_Newobject40["Command"] = "ETransformSelection.getAbsSize();";
            oc_Newobject40["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject40["hovertime"] = "1000";
            oc_Newobject40["tooltip"] = "Get absolute size for selected objects";
            oc_Newobject40["text"] = "Get";
            oc_Newobject40["groupNum"] = "-1";
            oc_Newobject40["buttonType"] = "PushButton";
            oc_Newobject40["useMouseEvents"] = "0";

            #endregion

            oc_Newobject50["#Newobject40"] = oc_Newobject40;

            #region GuiTextCtrl ()        oc_Newobject41

            ObjectCreator oc_Newobject41 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject41["canSaveDynamicFields"] = "0";
            oc_Newobject41["Enabled"] = "1";
            oc_Newobject41["isContainer"] = "0";
            oc_Newobject41["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject41["HorizSizing"] = "right";
            oc_Newobject41["VertSizing"] = "bottom";
            oc_Newobject41["position"] = "20 26";
            oc_Newobject41["Extent"] = "20 18";
            oc_Newobject41["MinExtent"] = "8 2";
            oc_Newobject41["canSave"] = "1";
            oc_Newobject41["Visible"] = "1";
            oc_Newobject41["hovertime"] = "1000";
            oc_Newobject41["Margin"] = "0 0 0 0";
            oc_Newobject41["Padding"] = "0 0 0 0";
            oc_Newobject41["AnchorTop"] = "1";
            oc_Newobject41["AnchorBottom"] = "0";
            oc_Newobject41["AnchorLeft"] = "1";
            oc_Newobject41["AnchorRight"] = "0";
            oc_Newobject41["text"] = "X:";
            oc_Newobject41["maxLength"] = "1024";

            #endregion

            oc_Newobject50["#Newobject41"] = oc_Newobject41;

            #region GuiTextEditCtrl ()        oc_Newobject42

            ObjectCreator oc_Newobject42 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject42["class"] = "ETransformSelectionTextEdit";
            oc_Newobject42["internalName"] = "SizeX";
            oc_Newobject42["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject42["HorizSizing"] = "width";
            oc_Newobject42["VertSizing"] = "bottom";
            oc_Newobject42["position"] = "40 26";
            oc_Newobject42["Extent"] = "90 18";
            oc_Newobject42["text"] = "1.0";
            oc_Newobject42["maxLength"] = "1024";
            oc_Newobject42["AltCommand"] = "";

            #endregion

            oc_Newobject50["#Newobject42"] = oc_Newobject42;

            #region GuiTextCtrl ()        oc_Newobject43

            ObjectCreator oc_Newobject43 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject43["canSaveDynamicFields"] = "0";
            oc_Newobject43["Enabled"] = "1";
            oc_Newobject43["isContainer"] = "0";
            oc_Newobject43["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject43["HorizSizing"] = "right";
            oc_Newobject43["VertSizing"] = "bottom";
            oc_Newobject43["position"] = "20 48";
            oc_Newobject43["Extent"] = "20 18";
            oc_Newobject43["MinExtent"] = "8 2";
            oc_Newobject43["canSave"] = "1";
            oc_Newobject43["Visible"] = "1";
            oc_Newobject43["hovertime"] = "1000";
            oc_Newobject43["Margin"] = "0 0 0 0";
            oc_Newobject43["Padding"] = "0 0 0 0";
            oc_Newobject43["AnchorTop"] = "1";
            oc_Newobject43["AnchorBottom"] = "0";
            oc_Newobject43["AnchorLeft"] = "1";
            oc_Newobject43["AnchorRight"] = "0";
            oc_Newobject43["text"] = "Y:";
            oc_Newobject43["maxLength"] = "1024";

            #endregion

            oc_Newobject50["#Newobject43"] = oc_Newobject43;

            #region GuiTextEditCtrl ()        oc_Newobject44

            ObjectCreator oc_Newobject44 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject44["class"] = "ETransformSelectionTextEdit";
            oc_Newobject44["internalName"] = "SizeY";
            oc_Newobject44["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject44["HorizSizing"] = "width";
            oc_Newobject44["VertSizing"] = "bottom";
            oc_Newobject44["position"] = "40 48";
            oc_Newobject44["Extent"] = "90 18";
            oc_Newobject44["text"] = "1.0";
            oc_Newobject44["maxLength"] = "1024";
            oc_Newobject44["AltCommand"] = "";

            #endregion

            oc_Newobject50["#Newobject44"] = oc_Newobject44;

            #region GuiTextCtrl ()        oc_Newobject45

            ObjectCreator oc_Newobject45 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject45["canSaveDynamicFields"] = "0";
            oc_Newobject45["Enabled"] = "1";
            oc_Newobject45["isContainer"] = "0";
            oc_Newobject45["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject45["HorizSizing"] = "right";
            oc_Newobject45["VertSizing"] = "bottom";
            oc_Newobject45["position"] = "20 70";
            oc_Newobject45["Extent"] = "20 18";
            oc_Newobject45["MinExtent"] = "8 2";
            oc_Newobject45["canSave"] = "1";
            oc_Newobject45["Visible"] = "1";
            oc_Newobject45["hovertime"] = "1000";
            oc_Newobject45["Margin"] = "0 0 0 0";
            oc_Newobject45["Padding"] = "0 0 0 0";
            oc_Newobject45["AnchorTop"] = "1";
            oc_Newobject45["AnchorBottom"] = "0";
            oc_Newobject45["AnchorLeft"] = "1";
            oc_Newobject45["AnchorRight"] = "0";
            oc_Newobject45["text"] = "Z:";
            oc_Newobject45["maxLength"] = "1024";

            #endregion

            oc_Newobject50["#Newobject45"] = oc_Newobject45;

            #region GuiTextEditCtrl ()        oc_Newobject46

            ObjectCreator oc_Newobject46 = new ObjectCreator("GuiTextEditCtrl", "",
                typeof (ETransformSelection.ETransformSelectionTextEdit));
            //oc_Newobject46["class"] = "ETransformSelectionTextEdit";
            oc_Newobject46["internalName"] = "SizeZ";
            oc_Newobject46["profile"] = "ToolsGuiNumericTextEditProfile";
            oc_Newobject46["HorizSizing"] = "width";
            oc_Newobject46["VertSizing"] = "bottom";
            oc_Newobject46["position"] = "40 70";
            oc_Newobject46["Extent"] = "90 18";
            oc_Newobject46["text"] = "1.0";
            oc_Newobject46["maxLength"] = "1024";
            oc_Newobject46["AltCommand"] = "";

            #endregion

            oc_Newobject50["#Newobject46"] = oc_Newobject46;

            #region GuiCheckBoxCtrl ()        oc_Newobject47

            ObjectCreator oc_Newobject47 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject47["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject47["internalName"] = "SizeRelative";
            oc_Newobject47["Enabled"] = "1";
            oc_Newobject47["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject47["position"] = "40 92";
            oc_Newobject47["Extent"] = "120 18";
            oc_Newobject47["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject47["hovertime"] = "1000";
            oc_Newobject47["tooltip"] = "Add values to current size (checked) or set absolute size (unchecked)";
            oc_Newobject47["text"] = "Relative";
            oc_Newobject47["Command"] = "";

            #endregion

            oc_Newobject50["#Newobject47"] = oc_Newobject47;

            #region GuiCheckBoxCtrl ()        oc_Newobject48

            ObjectCreator oc_Newobject48 = new ObjectCreator("GuiCheckBoxCtrl", "",
                typeof (ETransformSelection.ETransformSelectionCheckBoxClass));
            //oc_Newobject48["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject48["internalName"] = "SizeLocal";
            oc_Newobject48["Enabled"] = "1";
            oc_Newobject48["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject48["position"] = "40 114";
            oc_Newobject48["Extent"] = "120 18";
            oc_Newobject48["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject48["hovertime"] = "1000";
            oc_Newobject48["tooltip"] = "Use object's local origin to size from";
            oc_Newobject48["text"] = "Local Center";
            oc_Newobject48["Command"] = "";

            #endregion

            oc_Newobject50["#Newobject48"] = oc_Newobject48;

            #region GuiCheckBoxCtrl (ETransformSelectionSizeProportional)        oc_Newobject49

            ObjectCreator oc_Newobject49 = new ObjectCreator("GuiCheckBoxCtrl", "ETransformSelectionSizeProportional",
                typeof (ETransformSelection.ETransformSelectionSizeProportional));
            //oc_Newobject49["class"] = "ETransformSelectionCheckBoxClass";
            oc_Newobject49["internalName"] = "SizeProportional";
            oc_Newobject49["Enabled"] = "1";
            oc_Newobject49["Profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject49["position"] = "40 136";
            oc_Newobject49["Extent"] = "120 18";
            oc_Newobject49["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject49["hovertime"] = "1000";
            oc_Newobject49["tooltip"] = "Size equally in all directions";
            oc_Newobject49["text"] = "Constrain Proportions";
            oc_Newobject49["Command"] = "";

            #endregion

            oc_Newobject50["#Newobject49"] = oc_Newobject49;

            #endregion

            oc_Newobject51["#Newobject50"] = oc_Newobject50;

            #endregion

            oc_Newobject52["#Newobject51"] = oc_Newobject51;

            #endregion

            oc_Newobject53["#Newobject52"] = oc_Newobject52;

            #endregion

            oc_Newobject54["#Newobject53"] = oc_Newobject53;

            #endregion

            oc_Newobject58["#Newobject54"] = oc_Newobject54;

            #region GuiContainer ()        oc_Newobject57

            ObjectCreator oc_Newobject57 = new ObjectCreator("GuiContainer", "");
            oc_Newobject57["HorizSizing"] = "width";
            oc_Newobject57["VertSizing"] = "height";
            oc_Newobject57["Position"] = "0 0";
            oc_Newobject57["Extent"] = "190 24";
            oc_Newobject57["Docking"] = "Bottom";
            oc_Newobject57["Margin"] = "5 5 5 5";
            oc_Newobject57["Padding"] = "0 0 0 0";
            oc_Newobject57["AnchorTop"] = "1";
            oc_Newobject57["AnchorBottom"] = "0";
            oc_Newobject57["AnchorLeft"] = "1";
            oc_Newobject57["AnchorRight"] = "0";

            #region GuiButtonCtrl ()        oc_Newobject55

            ObjectCreator oc_Newobject55 = new ObjectCreator("GuiButtonCtrl", "",
                typeof (ETransformSelection.ETransformSelectionButtonClass));
            //oc_Newobject55["class"] = "ETransformSelectionButtonClass";
            oc_Newobject55["internalName"] = "ApplyButton";
            oc_Newobject55["canSaveDynamicFields"] = "0";
            oc_Newobject55["Enabled"] = "1";
            oc_Newobject55["isContainer"] = "0";
            oc_Newobject55["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject55["HorizSizing"] = "right";
            oc_Newobject55["VertSizing"] = "bottom";
            oc_Newobject55["Position"] = "0 0";
            oc_Newobject55["Extent"] = "50 23";
            oc_Newobject55["MinExtent"] = "8 8";
            oc_Newobject55["canSave"] = "1";
            oc_Newobject55["Visible"] = "1";
            oc_Newobject55["Command"] = "ETransformSelection.apply();";
            oc_Newobject55["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject55["hovertime"] = "1000";
            oc_Newobject55["text"] = "Apply";
            oc_Newobject55["groupNum"] = "-1";
            oc_Newobject55["buttonType"] = "PushButton";
            oc_Newobject55["useMouseEvents"] = "0";

            #endregion

            oc_Newobject57["#Newobject55"] = oc_Newobject55;

            #region GuiButtonCtrl ()        oc_Newobject56

            ObjectCreator oc_Newobject56 = new ObjectCreator("GuiButtonCtrl", "",
                typeof (ETransformSelection.ETransformSelectionButtonClass));
            //oc_Newobject56["class"] = "ETransformSelectionButtonClass";
            oc_Newobject56["internalName"] = "CloseButton";
            oc_Newobject56["canSaveDynamicFields"] = "0";
            oc_Newobject56["Enabled"] = "1";
            oc_Newobject56["isContainer"] = "0";
            oc_Newobject56["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject56["HorizSizing"] = "left";
            oc_Newobject56["VertSizing"] = "bottom";
            oc_Newobject56["Position"] = "140 0";
            oc_Newobject56["Extent"] = "50 23";
            oc_Newobject56["MinExtent"] = "8 8";
            oc_Newobject56["canSave"] = "1";
            oc_Newobject56["Visible"] = "1";
            oc_Newobject56["Command"] = "ETransformSelection.hideDialog();";
            oc_Newobject56["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject56["hovertime"] = "1000";
            oc_Newobject56["text"] = "Close";
            oc_Newobject56["groupNum"] = "-1";
            oc_Newobject56["buttonType"] = "PushButton";
            oc_Newobject56["useMouseEvents"] = "0";

            #endregion

            oc_Newobject57["#Newobject56"] = oc_Newobject56;

            #endregion

            oc_Newobject58["#Newobject57"] = oc_Newobject57;

            #endregion

            oc_Newobject59["#Newobject58"] = oc_Newobject58;

            #endregion

            oc_Newobject59.Create();
            }
        }
    }