using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<GuiEaseEditDlg>))]
    public class GuiEaseEditDlg : GuiControl
        {
        

        [ConsoleInteraction(true, "GuiEaseEditDlg_initialize")]
        public static void initialize()
            {
            #region GuiControl (GuiEaseEditDlg,EditorGuiGroup)        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControl", "GuiEaseEditDlg,EditorGuiGroup",
                typeof (GuiEaseEditDlg));
            oc_Newobject14["isContainer"] = "1";
            oc_Newobject14["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "bottom";
            oc_Newobject14["Position"] = "0 0";
            oc_Newobject14["Extent"] = "1024 768";
            oc_Newobject14["MinExtent"] = "8 2";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["canSaveDynamicFields"] = "1";

            #region GuiWindowCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject13["resizeWidth"] = "0";
            oc_Newobject13["resizeHeight"] = "0";
            oc_Newobject13["canMove"] = "1";
            oc_Newobject13["canClose"] = "1";
            oc_Newobject13["canMinimize"] = "0";
            oc_Newobject13["canMaximize"] = "0";
            oc_Newobject13["minSize"] = "50 50";
            oc_Newobject13["closeCommand"] = "GuiEaseEditDlg.onCancel();";
            oc_Newobject13["EdgeSnap"] = "1";
            oc_Newobject13["text"] = "Edit Easing Curve";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["isContainer"] = "1";
            oc_Newobject13["Profile"] = "ToolsGuiWindowProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "334 145";
            oc_Newobject13["Extent"] = "269 214";
            oc_Newobject13["MinExtent"] = "8 2";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["internalName"] = "window";
            oc_Newobject13["canSaveDynamicFields"] = "0";

            #region GuiBitmapBorderCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiBitmapBorderCtrl", "");
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["Profile"] = "ToolsGuiGroupBorderProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "5 27";
            oc_Newobject9["Extent"] = "95 151";
            oc_Newobject9["MinExtent"] = "8 2";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Direction";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["Margin"] = "0 0 0 0";
            oc_Newobject1["Padding"] = "0 0 0 0";
            oc_Newobject1["AnchorTop"] = "1";
            oc_Newobject1["AnchorBottom"] = "0";
            oc_Newobject1["AnchorLeft"] = "1";
            oc_Newobject1["AnchorRight"] = "0";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "bottom";
            oc_Newobject1["Position"] = "6 3";
            oc_Newobject1["Extent"] = "43 17";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject1"] = oc_Newobject1;

            #region GuiPopUpMenuCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiPopUpMenuCtrl", "", typeof (GuiEaseEditDirectionList));
            oc_Newobject2["maxPopupHeight"] = "200";
            oc_Newobject2["sbUsesNAColor"] = "0";
            oc_Newobject2["reverseTextList"] = "0";
            oc_Newobject2["bitmapBounds"] = "16 16";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["Margin"] = "0 0 0 0";
            oc_Newobject2["Padding"] = "0 0 0 0";
            oc_Newobject2["AnchorTop"] = "1";
            oc_Newobject2["AnchorBottom"] = "0";
            oc_Newobject2["AnchorLeft"] = "1";
            oc_Newobject2["AnchorRight"] = "0";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "bottom";
            oc_Newobject2["Position"] = "6 20";
            oc_Newobject2["Extent"] = "83 17";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["internalName"] = "directionList";
            oc_Newobject2["canSaveDynamicFields"] = "0";
            //oc_Newobject2["class"] = "GuiEaseEditDirectionList";
            //oc_Newobject2["className"] = "GuiEaseEditDirectionList";

            #endregion

            oc_Newobject9["#Newobject2"] = oc_Newobject2;

            #region GuiTextCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject3["text"] = "Type";
            oc_Newobject3["maxLength"] = "1024";
            oc_Newobject3["Margin"] = "0 0 0 0";
            oc_Newobject3["Padding"] = "0 0 0 0";
            oc_Newobject3["AnchorTop"] = "1";
            oc_Newobject3["AnchorBottom"] = "0";
            oc_Newobject3["AnchorLeft"] = "1";
            oc_Newobject3["AnchorRight"] = "0";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["Position"] = "6 40";
            oc_Newobject3["Extent"] = "25 17";
            oc_Newobject3["MinExtent"] = "8 2";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject3"] = oc_Newobject3;

            #region GuiPopUpMenuCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiPopUpMenuCtrl", "", typeof (GuiEaseEditTypeList));
            oc_Newobject4["maxPopupHeight"] = "200";
            oc_Newobject4["sbUsesNAColor"] = "0";
            oc_Newobject4["reverseTextList"] = "0";
            oc_Newobject4["bitmapBounds"] = "16 16";
            oc_Newobject4["maxLength"] = "1024";
            oc_Newobject4["Margin"] = "0 0 0 0";
            oc_Newobject4["Padding"] = "0 0 0 0";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "bottom";
            oc_Newobject4["Position"] = "6 57";
            oc_Newobject4["Extent"] = "83 17";
            oc_Newobject4["MinExtent"] = "8 2";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["internalName"] = "typeList";
            oc_Newobject4["canSaveDynamicFields"] = "0";
            //oc_Newobject4["class"] = "GuiEaseEditTypeList";
            //oc_Newobject4["className"] = "GuiEaseEditTypeList";

            #endregion

            oc_Newobject9["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Param1";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["Margin"] = "0 0 0 0";
            oc_Newobject5["Padding"] = "0 0 0 0";
            oc_Newobject5["AnchorTop"] = "1";
            oc_Newobject5["AnchorBottom"] = "0";
            oc_Newobject5["AnchorLeft"] = "1";
            oc_Newobject5["AnchorRight"] = "0";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "6 76";
            oc_Newobject5["Extent"] = "38 17";
            oc_Newobject5["MinExtent"] = "8 2";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject5"] = oc_Newobject5;

            #region GuiTextCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject6["text"] = "Param2";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["Profile"] = "ToolsGuiAutoSizeTextProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "6 111";
            oc_Newobject6["Extent"] = "38 17";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditSliderCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditSliderCtrl", "");
            oc_Newobject7["format"] = "3.2f";
            oc_Newobject7["range"] = "-1e+03 1e+03";
            oc_Newobject7["increment"] = "0.1";
            oc_Newobject7["focusOnMouseWheel"] = "0";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";
            oc_Newobject7["passwordMask"] = "•";
            oc_Newobject7["text"] = "-1.00";
            oc_Newobject7["maxLength"] = "1024";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "6 93";
            oc_Newobject7["Extent"] = "83 17";
            oc_Newobject7["MinExtent"] = "8 2";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["AltCommand"] = "GuiEaseEditDlg.onSetParam1( $ThisControl.getValue() );";
            oc_Newobject7["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["internalName"] = "param1Value";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject7"] = oc_Newobject7;

            #region GuiTextEditSliderCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextEditSliderCtrl", "");
            oc_Newobject8["format"] = "3.2f";
            oc_Newobject8["range"] = "-1e+03 1e+03";
            oc_Newobject8["increment"] = "0.1";
            oc_Newobject8["focusOnMouseWheel"] = "0";
            oc_Newobject8["historySize"] = "0";
            oc_Newobject8["password"] = "0";
            oc_Newobject8["tabComplete"] = "0";
            oc_Newobject8["sinkAllKeyEvents"] = "0";
            oc_Newobject8["passwordMask"] = "•";
            oc_Newobject8["text"] = "-1.00";
            oc_Newobject8["maxLength"] = "1024";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "6 128";
            oc_Newobject8["Extent"] = "83 17";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["AltCommand"] = "GuiEaseEditDlg.onSetParam2( $ThisControl.getValue() );";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["internalName"] = "param2Value";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject13["#Newobject9"] = oc_Newobject9;

            #region GuiButtonCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject10["text"] = "OK";
            oc_Newobject10["groupNum"] = "-1";
            oc_Newobject10["buttonType"] = "PushButton";
            oc_Newobject10["useMouseEvents"] = "0";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "67 184";
            oc_Newobject10["Extent"] = "115 24";
            oc_Newobject10["MinExtent"] = "8 2";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["Command"] = "GuiEaseEditDlg.onOK();";
            oc_Newobject10["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject13["#Newobject10"] = oc_Newobject10;

            #region GuiButtonCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject11["text"] = "Cancel";
            oc_Newobject11["groupNum"] = "-1";
            oc_Newobject11["buttonType"] = "PushButton";
            oc_Newobject11["useMouseEvents"] = "0";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "ToolsGuiButtonProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "184 184";
            oc_Newobject11["Extent"] = "73 24";
            oc_Newobject11["MinExtent"] = "8 2";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["Command"] = "GuiEaseEditDlg.onCancel();";
            oc_Newobject11["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject13["#Newobject11"] = oc_Newobject11;

            #region GuiEaseViewCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiEaseViewCtrl", "");
            oc_Newobject12["wrap"] = "0";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "107 28";
            oc_Newobject12["Extent"] = "150 150";
            oc_Newobject12["MinExtent"] = "8 2";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["internalName"] = "easeView";
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["ease"] = "1 2 -1 -1";
            oc_Newobject12["easeColor"] = "0.537255 0.537255 0.537255 1";
            oc_Newobject12["easeWidth"] = "4";
            oc_Newobject12["axisColor"] = "0.509804 0.509804 0.509804 1";

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject14.Create();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public static void GetEaseF(string currentEase, string callback, GuiCanvas root)
            {
            GuiEaseEditDlg GuiEaseEditDlg = "GuiEaseEditDlg";
            GuiCanvas Canvas = "Canvas";

            GuiEaseEditDlg.init(currentEase, callback);

            if (!root.isObject())
                root = Canvas;

            root.pushDialog(GuiEaseEditDlg);
            }

        //=============================================================================================
        //    GuiEaseEditDlg
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void init(string ease, string callback)
            {
            GuiPopUpMenuCtrl directionList = this.FOT("directionList");
            GuiPopUpMenuCtrl typeList = this.FOT("typeList");
            // Initialize direction popup.

            if (directionList.size() == 0)
                {
                directionList.add("InOut", iGlobal["$Ease::InOut"]);
                directionList.add("In", iGlobal["$Ease::In"]);
                directionList.add("Out", iGlobal["$Ease::Out"]);
                }

            // Initialize type popup.

            if (typeList.size() == 0)
                {
                typeList.add("Linear", iGlobal["$Ease::Linear"]);
                typeList.add("Quadratic", iGlobal["$Ease::Quadratic"]);
                typeList.add("Cubic", iGlobal["$Ease::Cubic"]);
                typeList.add("Quartic", iGlobal["$Ease::Quartic"]);
                typeList.add("Quintic", iGlobal["$Ease::Quintic"]);
                typeList.add("Sinusoidal", iGlobal["$Ease::Sinusoidal"]);
                typeList.add("Exponential", iGlobal["$Ease::Exponential"]);
                typeList.add("Circular", iGlobal["$Ease::Circular"]);
                typeList.add("Elastic", iGlobal["$Ease::Elastic"]);
                typeList.add("Back", iGlobal["$Ease::Back"]);
                typeList.add("Bounce", iGlobal["$Ease::Bounce"]);
                }

            // Set the initial easing curve.

            this["oldEase"] = ease;
            this.setEase(ease);

            // Remember callback.

            this["callback"] = callback;
            }

        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public void setEase(string ease)
            {
            GuiPopUpMenuCtrl directionList = this.FOT("directionList");
            GuiPopUpMenuCtrl typeList = this.FOT("typeList");
            GuiEaseViewCtrl easeView = this.FOT("easeView");
            GuiTextEditSliderCtrl param1Value = this.FOT("param1Value");
            GuiTextEditSliderCtrl param2Value = this.FOT("param2Value");

            easeView.ease = ease.AsEaseF();
            directionList.setSelected(omni.Util.getWord(ease, 0).AsInt(), false);
            typeList.setSelected(omni.Util.getWord(ease, 1).AsInt(), false);
            param1Value.setValue(omni.Util.getWord(ease, 2));
            param2Value.setValue(omni.Util.getWord(ease, 3));

            this.onEaseTypeSet();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onEaseTypeSet()
            {
            GuiPopUpMenuCtrl typeList = this.FOT("typeList");
            GuiTextEditSliderCtrl param1Value = this.FOT("param1Value");
            GuiTextEditSliderCtrl param2Value = this.FOT("param2Value");

            int selected = typeList.getSelected();
            if (selected == iGlobal["$Ease::Elastic"])
                {
                param1Value.setActive(true);
                param2Value.setActive(true);
                }
            else if (selected == iGlobal["Ease::Back"])
                {
                param1Value.setActive(true);
                param2Value.setActive(false);
                }
            else
                {
                param1Value.setActive(false);
                param2Value.setActive(false);
                }
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onOK()
            {
            GuiEaseViewCtrl easeView = this.FOT("easeView");

            Util.eval(this["callback"] + "( \"" + easeView.ease + "\" );");
            ((GuiCanvas) this.getRoot()).popDialog(this);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onCancel()
            {
            ((GuiCanvas) this.getRoot()).popDialog(this);
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onSetParam1(string value)
            {
            GuiEaseViewCtrl easeView = this.FOT("easeView");

            string ease = easeView.ease.AsString();
            ease = Util.setWord(ease.AsString(), 2, value);
            easeView.ease = ease.AsEaseF();
            }

        //---------------------------------------------------------------------------------------------

        [ConsoleInteraction]
        public void onSetParam2(string value)
            {
            GuiEaseViewCtrl easeView = this.FOT("easeView");

            string ease = easeView.ease.AsString();
            ease = Util.setWord(ease, 3, value);
            easeView.ease = ease.AsEaseF();
            }

        //=============================================================================================
        //    GuiEaseEditDirectionList
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiEaseEditDirectionList>))]
        public class GuiEaseEditDirectionList : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                GuiEaseEditDlg GuiEaseEditDlg = "GuiEaseEditDlg";
                GuiEaseViewCtrl easeView = GuiEaseEditDlg.FOT("easeView");

                string ease = easeView.ease.AsString();
                ease = Util.setWord(ease, 0, id);
                easeView.ease = ease.AsEaseF();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEaseEditDirectionList ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(GuiEaseEditDirectionList ts, string simobjectid)
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
            public static implicit operator string(GuiEaseEditDirectionList ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEaseEditDirectionList(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (GuiEaseEditDirectionList) Omni.self.getSimObject(simobjectid, typeof (GuiEaseEditDirectionList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEaseEditDirectionList ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEaseEditDirectionList(int simobjectid)
                {
                return
                    (GuiEaseEditDirectionList)
                        Omni.self.getSimObject((uint) simobjectid, typeof (GuiEaseEditDirectionList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEaseEditDirectionList ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEaseEditDirectionList(uint simobjectid)
                {
                return (GuiEaseEditDirectionList) Omni.self.getSimObject(simobjectid, typeof (GuiEaseEditDirectionList));
                }

            #endregion
            }


        //=============================================================================================
        //    GuiEaseEditTypeList
        //=============================================================================================

        //---------------------------------------------------------------------------------------------

        [TypeConverter(typeof (TypeConverterGeneric<GuiEaseEditTypeList>))]
        public class GuiEaseEditTypeList : GuiPopUpMenuCtrl
            {
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
                {
                GuiEaseEditDlg GuiEaseEditDlg = "GuiEaseEditDlg";
                GuiEaseViewCtrl easeView = GuiEaseEditDlg.FOT("easeView");

                string ease = easeView.ease.AsString();
                ease = Util.setWord(ease, 1, id);
                easeView.ease = ease.AsEaseF();

                GuiEaseEditDlg.onEaseTypeSet();
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiEaseEditTypeList ts, string simobjectid)
                {
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
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
            public static bool operator !=(GuiEaseEditTypeList ts, string simobjectid)
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
            public static implicit operator string(GuiEaseEditTypeList ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiEaseEditTypeList(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (GuiEaseEditTypeList) Omni.self.getSimObject(simobjectid, typeof (GuiEaseEditTypeList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiEaseEditTypeList ts)
                {
                return (int) ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiEaseEditTypeList(int simobjectid)
                {
                return (GuiEaseEditTypeList) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEaseEditTypeList));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiEaseEditTypeList ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiEaseEditTypeList(uint simobjectid)
                {
                return (GuiEaseEditTypeList) Omni.self.getSimObject(simobjectid, typeof (GuiEaseEditTypeList));
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
        public static bool operator ==(GuiEaseEditDlg ts, string simobjectid)
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
        public static bool operator !=(GuiEaseEditDlg ts, string simobjectid)
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
        public static implicit operator string(GuiEaseEditDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator GuiEaseEditDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (GuiEaseEditDlg) Omni.self.getSimObject(simobjectid, typeof (GuiEaseEditDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiEaseEditDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiEaseEditDlg(int simobjectid)
            {
            return (GuiEaseEditDlg) Omni.self.getSimObject((uint) simobjectid, typeof (GuiEaseEditDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiEaseEditDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiEaseEditDlg(uint simobjectid)
            {
            return (GuiEaseEditDlg) Omni.self.getSimObject(simobjectid, typeof (GuiEaseEditDlg));
            }

        #endregion
        }
    }