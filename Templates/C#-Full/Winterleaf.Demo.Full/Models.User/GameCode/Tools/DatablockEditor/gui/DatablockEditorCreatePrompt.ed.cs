using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<DatablockEditorCreatePrompt>))]
    public class DatablockEditorCreatePrompt : GuiControl
        {
        [ConsoleInteraction(true, "DatablockEditorCreatePrompt_initialize")]
        public static void initialize()
            {
            #region GuiControl (DatablockEditorCreatePrompt,EditorGuiGroup)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiControl", "DatablockEditorCreatePrompt,EditorGuiGroup",
                typeof (DatablockEditorCreatePrompt));
            oc_Newobject9["position"] = "0 0";
            oc_Newobject9["extent"] = "1024 768";
            oc_Newobject9["minExtent"] = "8 2";
            oc_Newobject9["horizSizing"] = "right";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["fixedAspectRatio"] = "0";
            oc_Newobject9["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject9["visible"] = "1";
            oc_Newobject9["active"] = "1";
            oc_Newobject9["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["isContainer"] = "1";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["canSaveDynamicFields"] = "1";

            #region GuiWindowCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject8["text"] = "Create New Datablock";
            oc_Newobject8["resizeWidth"] = "0";
            oc_Newobject8["resizeHeight"] = "0";
            oc_Newobject8["canMove"] = "0";
            oc_Newobject8["canClose"] = "1";
            oc_Newobject8["canMinimize"] = "0";
            oc_Newobject8["canMaximize"] = "0";
            oc_Newobject8["canCollapse"] = "0";
            oc_Newobject8["closeCommand"] = "canvas.popDialog(DatablockEditorCreatePrompt);";
            oc_Newobject8["edgeSnap"] = "0";
            oc_Newobject8["margin"] = "0 0 0 0";
            oc_Newobject8["padding"] = "0 0 0 0";
            oc_Newobject8["anchorTop"] = "1";
            oc_Newobject8["anchorBottom"] = "0";
            oc_Newobject8["anchorLeft"] = "1";
            oc_Newobject8["anchorRight"] = "0";
            oc_Newobject8["position"] = "389 252";
            oc_Newobject8["extent"] = "207 167";
            oc_Newobject8["minExtent"] = "8 2";
            oc_Newobject8["horizSizing"] = "right";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["fixedAspectRatio"] = "0";
            oc_Newobject8["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject8["visible"] = "1";
            oc_Newobject8["active"] = "1";
            oc_Newobject8["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["canSaveDynamicFields"] = "0";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["text"] = "Your new datablock must have a name";
            oc_Newobject1["maxLength"] = "1024";
            oc_Newobject1["margin"] = "0 0 0 0";
            oc_Newobject1["padding"] = "0 0 0 0";
            oc_Newobject1["anchorTop"] = "1";
            oc_Newobject1["anchorBottom"] = "0";
            oc_Newobject1["anchorLeft"] = "1";
            oc_Newobject1["anchorRight"] = "0";
            oc_Newobject1["position"] = "7 26";
            oc_Newobject1["extent"] = "190 15";
            oc_Newobject1["minExtent"] = "8 2";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["fixedAspectRatio"] = "0";
            oc_Newobject1["profile"] = "ToolsGuiTextProfile";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["active"] = "1";
            oc_Newobject1["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject2["historySize"] = "0";
            oc_Newobject2["tabComplete"] = "0";
            oc_Newobject2["sinkAllKeyEvents"] = "0";
            oc_Newobject2["password"] = "0";
            oc_Newobject2["passwordMask"] = "*";
            oc_Newobject2["text"] = "Name";
            oc_Newobject2["maxLength"] = "1024";
            oc_Newobject2["margin"] = "0 0 0 0";
            oc_Newobject2["padding"] = "0 0 0 0";
            oc_Newobject2["anchorTop"] = "1";
            oc_Newobject2["anchorBottom"] = "0";
            oc_Newobject2["anchorLeft"] = "1";
            oc_Newobject2["anchorRight"] = "0";
            oc_Newobject2["position"] = "7 45";
            oc_Newobject2["extent"] = "191 17";
            oc_Newobject2["minExtent"] = "8 2";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["fixedAspectRatio"] = "0";
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["active"] = "1";
            oc_Newobject2["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["internalName"] = "CreateDatablockName";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["text"] = "Create";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";
            oc_Newobject3["position"] = "7 137";
            oc_Newobject3["extent"] = "122 22";
            oc_Newobject3["minExtent"] = "8 2";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["fixedAspectRatio"] = "0";
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["active"] = "1";
            oc_Newobject3["command"] = "DatablockEditorPlugin.createPromptNameCheck();";
            oc_Newobject3["accelerator"] = "return";
            oc_Newobject3["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject4["text"] = "Cancel";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";
            oc_Newobject4["position"] = "135 137";
            oc_Newobject4["extent"] = "63 22";
            oc_Newobject4["minExtent"] = "8 2";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["fixedAspectRatio"] = "0";
            oc_Newobject4["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["active"] = "1";
            oc_Newobject4["command"] = "canvas.popDialog(DatablockEditorCreatePrompt);";
            oc_Newobject4["accelerator"] = "escape";
            oc_Newobject4["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject4"] = oc_Newobject4;

            #region GuiTextCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject5["text"] = "Copy values from";
            oc_Newobject5["maxLength"] = "1024";
            oc_Newobject5["margin"] = "0 0 0 0";
            oc_Newobject5["padding"] = "0 0 0 0";
            oc_Newobject5["anchorTop"] = "1";
            oc_Newobject5["anchorBottom"] = "0";
            oc_Newobject5["anchorLeft"] = "1";
            oc_Newobject5["anchorRight"] = "0";
            oc_Newobject5["position"] = "7 66";
            oc_Newobject5["extent"] = "100 17";
            oc_Newobject5["minExtent"] = "8 2";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["fixedAspectRatio"] = "0";
            oc_Newobject5["profile"] = "ToolsGuiTextProfile";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["active"] = "1";
            oc_Newobject5["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["isContainer"] = "0";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject5"] = oc_Newobject5;

            #region GuiPopUpMenuCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiPopUpMenuCtrl", "");
            oc_Newobject6["maxPopupHeight"] = "200";
            oc_Newobject6["sbUsesNAColor"] = "0";
            oc_Newobject6["reverseTextList"] = "0";
            oc_Newobject6["bitmapBounds"] = "16 16";
            oc_Newobject6["maxLength"] = "1024";
            oc_Newobject6["margin"] = "0 0 0 0";
            oc_Newobject6["padding"] = "0 0 0 0";
            oc_Newobject6["anchorTop"] = "1";
            oc_Newobject6["anchorBottom"] = "0";
            oc_Newobject6["anchorLeft"] = "1";
            oc_Newobject6["anchorRight"] = "0";
            oc_Newobject6["position"] = "7 87";
            oc_Newobject6["extent"] = "191 19";
            oc_Newobject6["minExtent"] = "8 2";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["fixedAspectRatio"] = "0";
            oc_Newobject6["profile"] = "GuiPopUpMenuProfile";
            oc_Newobject6["visible"] = "1";
            oc_Newobject6["active"] = "1";
            oc_Newobject6["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["isContainer"] = "0";
            oc_Newobject6["internalName"] = "CopySourceDropdown";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject6"] = oc_Newobject6;

            #region GuiCheckBoxCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiCheckBoxCtrl", "");
            oc_Newobject7["useInactiveState"] = "0";
            oc_Newobject7["text"] = "Client-Side Datablock";
            oc_Newobject7["groupNum"] = "-1";
            oc_Newobject7["buttonType"] = "ToggleButton";
            oc_Newobject7["useMouseEvents"] = "0";
            oc_Newobject7["position"] = "7 105";
            oc_Newobject7["extent"] = "140 30";
            oc_Newobject7["minExtent"] = "8 2";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["fixedAspectRatio"] = "0";
            oc_Newobject7["profile"] = "ToolsGuiCheckBoxProfile";
            oc_Newobject7["visible"] = "1";
            oc_Newobject7["active"] = "1";
            oc_Newobject7["tooltipProfile"] = "ToolsGuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["internalName"] = "ClientSideCheckBox";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["canSaveDynamicFields"] = "0";

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject9["#Newobject8"] = oc_Newobject8;

            #endregion

            oc_Newobject9.Create();
            }
        }
    }