using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui
    {
    public class DebuggerGui
        {
        [ConsoleInteraction(true, "DebuggerGui_initialize")]
        public static void initialize()
            {
            #region GuiControl (DebuggerGui, EditorGuiGroup)        oc_Newobject39

            ObjectCreator oc_Newobject39 = new ObjectCreator("GuiControl", "DebuggerGui, EditorGuiGroup");
            oc_Newobject39["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject39["horizSizing"] = "right";
            oc_Newobject39["vertSizing"] = "bottom";
            oc_Newobject39["position"] = "0 0";
            oc_Newobject39["extent"] = "640 480";
            oc_Newobject39["minExtent"] = "8 8";
            oc_Newobject39["visible"] = "True";
            oc_Newobject39["setFirstResponder"] = "False";
            oc_Newobject39["modal"] = "True";
            oc_Newobject39["helpTag"] = "0";

            #region GuiButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject1["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "8 4";
            oc_Newobject1["extent"] = "56 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "True";
            oc_Newobject1["setFirstResponder"] = "False";
            oc_Newobject1["modal"] = "True";
            oc_Newobject1["command"] = "Canvas.pushDialog(DebuggerConnectDlg, 80);";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "Connect";

            #endregion

            oc_Newobject39["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject2["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject2["horizSizing"] = "right";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "72 4";
            oc_Newobject2["extent"] = "56 16";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "True";
            oc_Newobject2["setFirstResponder"] = "False";
            oc_Newobject2["modal"] = "True";
            oc_Newobject2["command"] = "Canvas.pushDialog(OpenFileDialog, 80);";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["text"] = "File";

            #endregion

            oc_Newobject39["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl ()        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["horizSizing"] = "right";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "72 4";
            oc_Newobject3["extent"] = "56 16";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "True";
            oc_Newobject3["setFirstResponder"] = "False";
            oc_Newobject3["modal"] = "True";
            oc_Newobject3["command"] = "dbgStepIn();";
            oc_Newobject3["accelerator"] = "f7";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["text"] = "Step In";

            #endregion

            oc_Newobject39["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject4["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject4["horizSizing"] = "right";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "136 4";
            oc_Newobject4["extent"] = "56 16";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "True";
            oc_Newobject4["setFirstResponder"] = "False";
            oc_Newobject4["modal"] = "True";
            oc_Newobject4["command"] = "dbgStepOver();";
            oc_Newobject4["accelerator"] = "f8";
            oc_Newobject4["helpTag"] = "0";
            oc_Newobject4["text"] = "Step Over";

            #endregion

            oc_Newobject39["#Newobject4"] = oc_Newobject4;

            #region GuiButtonCtrl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject5["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "200 4";
            oc_Newobject5["extent"] = "56 16";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "True";
            oc_Newobject5["setFirstResponder"] = "False";
            oc_Newobject5["modal"] = "True";
            oc_Newobject5["command"] = "dbgStepOut();";
            oc_Newobject5["accelerator"] = "f6";
            oc_Newobject5["helpTag"] = "0";
            oc_Newobject5["text"] = "Step Out";

            #endregion

            oc_Newobject39["#Newobject5"] = oc_Newobject5;

            #region GuiButtonCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject6["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject6["horizSizing"] = "right";
            oc_Newobject6["vertSizing"] = "bottom";
            oc_Newobject6["position"] = "264 4";
            oc_Newobject6["extent"] = "56 16";
            oc_Newobject6["minExtent"] = "8 8";
            oc_Newobject6["visible"] = "True";
            oc_Newobject6["setFirstResponder"] = "False";
            oc_Newobject6["modal"] = "True";
            oc_Newobject6["command"] = "dbgContinue();";
            oc_Newobject6["accelerator"] = "f9";
            oc_Newobject6["helpTag"] = "0";
            oc_Newobject6["text"] = "Run";

            #endregion

            oc_Newobject39["#Newobject6"] = oc_Newobject6;

            #region GuiButtonCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject7["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject7["horizSizing"] = "right";
            oc_Newobject7["vertSizing"] = "bottom";
            oc_Newobject7["position"] = "328 4";
            oc_Newobject7["extent"] = "56 16";
            oc_Newobject7["minExtent"] = "8 8";
            oc_Newobject7["visible"] = "True";
            oc_Newobject7["setFirstResponder"] = "False";
            oc_Newobject7["modal"] = "True";
            oc_Newobject7["command"] = "Canvas.pushDialog(DebuggerFindDlg, 80);";
            oc_Newobject7["helpTag"] = "0";
            oc_Newobject7["text"] = "Find";

            #endregion

            oc_Newobject39["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl (DebuggerCursorWatch)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "DebuggerCursorWatch");
            oc_Newobject8["profile"] = "ToolsGuiTextProfile";
            oc_Newobject8["horizSizing"] = "width";
            oc_Newobject8["vertSizing"] = "bottom";
            oc_Newobject8["position"] = "398 4";
            oc_Newobject8["extent"] = "126 18";
            oc_Newobject8["minExtent"] = "8 8";
            oc_Newobject8["visible"] = "True";
            oc_Newobject8["setFirstResponder"] = "False";
            oc_Newobject8["modal"] = "True";
            oc_Newobject8["helpTag"] = "0";
            oc_Newobject8["text"] = "";
            oc_Newobject8["justify"] = "left";

            #endregion

            oc_Newobject39["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl (DebuggerStatus)        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "DebuggerStatus");
            oc_Newobject9["profile"] = "ToolsGuiTextProfile";
            oc_Newobject9["horizSizing"] = "left";
            oc_Newobject9["vertSizing"] = "bottom";
            oc_Newobject9["position"] = "532 4";
            oc_Newobject9["extent"] = "100 18";
            oc_Newobject9["minExtent"] = "8 8";
            oc_Newobject9["visible"] = "True";
            oc_Newobject9["setFirstResponder"] = "False";
            oc_Newobject9["modal"] = "True";
            oc_Newobject9["helpTag"] = "0";
            oc_Newobject9["text"] = "NOT CONNECTED";
            oc_Newobject9["justify"] = "right";

            #endregion

            oc_Newobject39["#Newobject9"] = oc_Newobject9;

            #region GuiFrameSetCtrl (DebuggerRootFrame)        oc_Newobject38

            ObjectCreator oc_Newobject38 = new ObjectCreator("GuiFrameSetCtrl", "DebuggerRootFrame");
            oc_Newobject38["profile"] = "GuiContentProfile";
            oc_Newobject38["horizSizing"] = "width";
            oc_Newobject38["vertSizing"] = "height";
            oc_Newobject38["position"] = "0 24";
            oc_Newobject38["extent"] = "640 456";
            oc_Newobject38["minExtent"] = "8 8";
            oc_Newobject38["visible"] = "True";
            oc_Newobject38["setFirstResponder"] = "False";
            oc_Newobject38["modal"] = "True";
            oc_Newobject38["helpTag"] = "0";
            oc_Newobject38["columns"] = "0 486";
            oc_Newobject38["rows"] = "0";
            oc_Newobject38["borderWidth"] = "4";
            oc_Newobject38["borderEnable"] = "dynamic";
            oc_Newobject38["borderMovable"] = "dynamic";

            #region GuiFrameSetCtrl (DebuggerLeftFrame)        oc_Newobject23

            ObjectCreator oc_Newobject23 = new ObjectCreator("GuiFrameSetCtrl", "DebuggerLeftFrame");
            oc_Newobject23["profile"] = "GuiContentProfile";
            oc_Newobject23["horizSizing"] = "width";
            oc_Newobject23["vertSizing"] = "height";
            oc_Newobject23["position"] = "0 0";
            oc_Newobject23["extent"] = "482 456";
            oc_Newobject23["minExtent"] = "8 8";
            oc_Newobject23["visible"] = "True";
            oc_Newobject23["setFirstResponder"] = "False";
            oc_Newobject23["modal"] = "True";
            oc_Newobject23["helpTag"] = "0";
            oc_Newobject23["columns"] = "0";
            oc_Newobject23["rows"] = "0 350";
            oc_Newobject23["borderWidth"] = "4";
            oc_Newobject23["borderEnable"] = "dynamic";
            oc_Newobject23["borderMovable"] = "dynamic";

            #region GuiControl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiControl", "");
            oc_Newobject14["profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject14["horizSizing"] = "width";
            oc_Newobject14["vertSizing"] = "height";
            oc_Newobject14["position"] = "0 0";
            oc_Newobject14["extent"] = "482 346";
            oc_Newobject14["minExtent"] = "8 8";
            oc_Newobject14["visible"] = "True";
            oc_Newobject14["setFirstResponder"] = "True";
            oc_Newobject14["modal"] = "True";
            oc_Newobject14["helpTag"] = "0";

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["profile"] = "ToolsGuiTextProfile";
            oc_Newobject10["horizSizing"] = "right";
            oc_Newobject10["vertSizing"] = "bottom";
            oc_Newobject10["position"] = "8 4";
            oc_Newobject10["extent"] = "47 18";
            oc_Newobject10["minExtent"] = "8 8";
            oc_Newobject10["visible"] = "True";
            oc_Newobject10["setFirstResponder"] = "False";
            oc_Newobject10["modal"] = "True";
            oc_Newobject10["helpTag"] = "0";
            oc_Newobject10["text"] = "Open File:";

            #endregion

            oc_Newobject14["#Newobject10"] = oc_Newobject10;

            #region GuiPopUpMenuCtrl (DebuggerFilePopup)        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiPopUpMenuCtrl", "DebuggerFilePopup",
                typeof (CodeBehind.Debugger.DebuggerFilePopup));
            oc_Newobject11["profile"] = "ToolsGuiPopUpMenuProfile";
            oc_Newobject11["horizSizing"] = "right";
            oc_Newobject11["vertSizing"] = "bottom";
            oc_Newobject11["position"] = "64 4";
            oc_Newobject11["extent"] = "160 18";
            oc_Newobject11["minExtent"] = "8 8";
            oc_Newobject11["visible"] = "True";
            oc_Newobject11["setFirstResponder"] = "True";
            oc_Newobject11["modal"] = "True";
            oc_Newobject11["helpTag"] = "0";
            oc_Newobject11["maxPopupHeight"] = "200";

            #endregion

            oc_Newobject14["#Newobject11"] = oc_Newobject11;

            #region GuiScrollCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject13["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject13["horizSizing"] = "width";
            oc_Newobject13["vertSizing"] = "height";
            oc_Newobject13["position"] = "0 24";
            oc_Newobject13["extent"] = "482 321";
            oc_Newobject13["minExtent"] = "8 8";
            oc_Newobject13["visible"] = "True";
            oc_Newobject13["setFirstResponder"] = "False";
            oc_Newobject13["modal"] = "True";
            oc_Newobject13["helpTag"] = "0";
            oc_Newobject13["willFirstRespond"] = "True";
            oc_Newobject13["hScrollBar"] = "dynamic";
            oc_Newobject13["vScrollBar"] = "dynamic";
            oc_Newobject13["lockHorizScroll"] = "false";
            oc_Newobject13["lockVertScroll"] = "false";
            oc_Newobject13["constantThumbHeight"] = "False";

            #region DbgFileView (DebuggerFileView)        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("DbgFileView", "DebuggerFileView",
                typeof (CodeBehind.Debugger.DebuggerFileView));
            oc_Newobject12["profile"] = "ToolsGuiTextArrayProfile";
            oc_Newobject12["horizSizing"] = "right";
            oc_Newobject12["vertSizing"] = "bottom";
            oc_Newobject12["position"] = "0 -433";
            oc_Newobject12["extent"] = "509 3904";
            oc_Newobject12["minExtent"] = "8 8";
            oc_Newobject12["visible"] = "True";
            oc_Newobject12["setFirstResponder"] = "False";
            oc_Newobject12["modal"] = "True";
            oc_Newobject12["helpTag"] = "0";

            #endregion

            oc_Newobject13["#Newobject12"] = oc_Newobject12;

            #endregion

            oc_Newobject14["#Newobject13"] = oc_Newobject13;

            #endregion

            oc_Newobject23["#Newobject14"] = oc_Newobject14;

            #region GuiControl ()        oc_Newobject22

            ObjectCreator oc_Newobject22 = new ObjectCreator("GuiControl", "");
            oc_Newobject22["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject22["horizSizing"] = "right";
            oc_Newobject22["vertSizing"] = "bottom";
            oc_Newobject22["position"] = "0 350";
            oc_Newobject22["extent"] = "482 106";
            oc_Newobject22["minExtent"] = "8 8";
            oc_Newobject22["visible"] = "True";
            oc_Newobject22["setFirstResponder"] = "False";
            oc_Newobject22["modal"] = "True";
            oc_Newobject22["helpTag"] = "0";

            #region GuiButtonCtrl ()        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject15["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject15["horizSizing"] = "right";
            oc_Newobject15["vertSizing"] = "bottom";
            oc_Newobject15["position"] = "8 4";
            oc_Newobject15["extent"] = "56 16";
            oc_Newobject15["minExtent"] = "8 8";
            oc_Newobject15["visible"] = "True";
            oc_Newobject15["setFirstResponder"] = "False";
            oc_Newobject15["modal"] = "True";
            oc_Newobject15["command"] = "Canvas.pushDialog(DebuggerWatchDlg, 80);";
            oc_Newobject15["helpTag"] = "0";
            oc_Newobject15["text"] = "Add";

            #endregion

            oc_Newobject22["#Newobject15"] = oc_Newobject15;

            #region GuiButtonCtrl ()        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject16["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject16["horizSizing"] = "right";
            oc_Newobject16["vertSizing"] = "bottom";
            oc_Newobject16["position"] = "72 4";
            oc_Newobject16["extent"] = "56 16";
            oc_Newobject16["minExtent"] = "8 8";
            oc_Newobject16["visible"] = "True";
            oc_Newobject16["setFirstResponder"] = "False";
            oc_Newobject16["modal"] = "True";
            oc_Newobject16["command"] = "Canvas.pushDialog(DebuggerEditWatchDlg, 80);";
            oc_Newobject16["helpTag"] = "0";
            oc_Newobject16["text"] = "Edit";

            #endregion

            oc_Newobject22["#Newobject16"] = oc_Newobject16;

            #region GuiButtonCtrl ()        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject17["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject17["horizSizing"] = "right";
            oc_Newobject17["vertSizing"] = "bottom";
            oc_Newobject17["position"] = "136 4";
            oc_Newobject17["extent"] = "56 16";
            oc_Newobject17["minExtent"] = "8 8";
            oc_Newobject17["visible"] = "True";
            oc_Newobject17["setFirstResponder"] = "False";
            oc_Newobject17["modal"] = "True";
            oc_Newobject17["command"] = "DbgDeleteSelectedWatch();";
            oc_Newobject17["helpTag"] = "0";
            oc_Newobject17["text"] = "Delete";

            #endregion

            oc_Newobject22["#Newobject17"] = oc_Newobject17;

            #region GuiButtonCtrl ()        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject18["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject18["horizSizing"] = "right";
            oc_Newobject18["vertSizing"] = "bottom";
            oc_Newobject18["position"] = "200 4";
            oc_Newobject18["extent"] = "56 16";
            oc_Newobject18["minExtent"] = "8 8";
            oc_Newobject18["visible"] = "True";
            oc_Newobject18["setFirstResponder"] = "False";
            oc_Newobject18["modal"] = "True";
            oc_Newobject18["command"] = "DebuggerWatchView.clear();";
            oc_Newobject18["helpTag"] = "0";
            oc_Newobject18["text"] = "Clear";

            #endregion

            oc_Newobject22["#Newobject18"] = oc_Newobject18;

            #region GuiButtonCtrl ()        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject19["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject19["horizSizing"] = "right";
            oc_Newobject19["vertSizing"] = "bottom";
            oc_Newobject19["position"] = "264 4";
            oc_Newobject19["extent"] = "56 16";
            oc_Newobject19["minExtent"] = "8 8";
            oc_Newobject19["visible"] = "True";
            oc_Newobject19["setFirstResponder"] = "False";
            oc_Newobject19["modal"] = "True";
            oc_Newobject19["command"] = "DbgRefreshWatches();";
            oc_Newobject19["helpTag"] = "0";
            oc_Newobject19["text"] = "Refresh";

            #endregion

            oc_Newobject22["#Newobject19"] = oc_Newobject19;

            #region GuiScrollCtrl ()        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject21["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject21["horizSizing"] = "width";
            oc_Newobject21["vertSizing"] = "height";
            oc_Newobject21["position"] = "0 24";
            oc_Newobject21["extent"] = "481 80";
            oc_Newobject21["minExtent"] = "8 8";
            oc_Newobject21["visible"] = "True";
            oc_Newobject21["setFirstResponder"] = "False";
            oc_Newobject21["modal"] = "True";
            oc_Newobject21["helpTag"] = "0";
            oc_Newobject21["willFirstRespond"] = "True";
            oc_Newobject21["hScrollBar"] = "dynamic";
            oc_Newobject21["vScrollBar"] = "dynamic";
            oc_Newobject21["lockHorizScroll"] = "false";
            oc_Newobject21["lockVertScroll"] = "false";
            oc_Newobject21["constantThumbHeight"] = "False";

            #region GuiTextListCtrl (DebuggerWatchView)        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiTextListCtrl", "DebuggerWatchView");
            oc_Newobject20["profile"] = "ToolsGuiTextListProfile";
            oc_Newobject20["horizSizing"] = "right";
            oc_Newobject20["vertSizing"] = "bottom";
            oc_Newobject20["position"] = "0 0";
            oc_Newobject20["extent"] = "640 8";
            oc_Newobject20["minExtent"] = "8 8";
            oc_Newobject20["visible"] = "True";
            oc_Newobject20["setFirstResponder"] = "False";
            oc_Newobject20["modal"] = "True";
            oc_Newobject20["helpTag"] = "0";
            oc_Newobject20["enumerate"] = "False";
            oc_Newobject20["resizeCell"] = "True";
            oc_Newobject20["columns"] = "0 200";

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject22["#Newobject21"] = oc_Newobject21;

            #endregion

            oc_Newobject23["#Newobject22"] = oc_Newobject22;

            #endregion

            oc_Newobject38["#Newobject23"] = oc_Newobject23;

            #region GuiFrameSetCtrl (DebuggerRightFrame)        oc_Newobject37

            ObjectCreator oc_Newobject37 = new ObjectCreator("GuiFrameSetCtrl", "DebuggerRightFrame");
            oc_Newobject37["profile"] = "GuiContentProfile";
            oc_Newobject37["horizSizing"] = "right";
            oc_Newobject37["vertSizing"] = "bottom";
            oc_Newobject37["position"] = "486 0";
            oc_Newobject37["extent"] = "154 456";
            oc_Newobject37["minExtent"] = "8 8";
            oc_Newobject37["visible"] = "True";
            oc_Newobject37["setFirstResponder"] = "False";
            oc_Newobject37["modal"] = "True";
            oc_Newobject37["helpTag"] = "0";
            oc_Newobject37["columns"] = "0";
            oc_Newobject37["rows"] = "0 150 350";
            oc_Newobject37["borderWidth"] = "4";
            oc_Newobject37["borderEnable"] = "dynamic";
            oc_Newobject37["borderMovable"] = "dynamic";

            #region GuiScrollCtrl ()        oc_Newobject25

            ObjectCreator oc_Newobject25 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject25["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject25["horizSizing"] = "width";
            oc_Newobject25["vertSizing"] = "height";
            oc_Newobject25["position"] = "0 0";
            oc_Newobject25["extent"] = "154 146";
            oc_Newobject25["minExtent"] = "8 8";
            oc_Newobject25["visible"] = "True";
            oc_Newobject25["setFirstResponder"] = "False";
            oc_Newobject25["modal"] = "True";
            oc_Newobject25["helpTag"] = "0";
            oc_Newobject25["willFirstRespond"] = "True";
            oc_Newobject25["hScrollBar"] = "dynamic";
            oc_Newobject25["vScrollBar"] = "dynamic";
            oc_Newobject25["lockHorizScroll"] = "false";
            oc_Newobject25["lockVertScroll"] = "false";
            oc_Newobject25["constantThumbHeight"] = "False";

            #region GuiTextListCtrl (DebuggerCallStack)        oc_Newobject24

            ObjectCreator oc_Newobject24 = new ObjectCreator("GuiTextListCtrl", "DebuggerCallStack",
                typeof (CodeBehind.Debugger.DebuggerCallStack));
            oc_Newobject24["profile"] = "ToolsGuiTextListProfile";
            oc_Newobject24["horizSizing"] = "right";
            oc_Newobject24["vertSizing"] = "bottom";
            oc_Newobject24["position"] = "0 0";
            oc_Newobject24["extent"] = "640 8";
            oc_Newobject24["minExtent"] = "8 8";
            oc_Newobject24["visible"] = "True";
            oc_Newobject24["setFirstResponder"] = "False";
            oc_Newobject24["modal"] = "True";
            oc_Newobject24["helpTag"] = "0";
            oc_Newobject24["enumerate"] = "False";
            oc_Newobject24["resizeCell"] = "True";
            oc_Newobject24["columns"] = "-1 -1 0";

            #endregion

            oc_Newobject25["#Newobject24"] = oc_Newobject24;

            #endregion

            oc_Newobject37["#Newobject25"] = oc_Newobject25;

            #region GuiControl ()        oc_Newobject31

            ObjectCreator oc_Newobject31 = new ObjectCreator("GuiControl", "");
            oc_Newobject31["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject31["horizSizing"] = "right";
            oc_Newobject31["vertSizing"] = "bottom";
            oc_Newobject31["position"] = "0 150";
            oc_Newobject31["extent"] = "154 196";
            oc_Newobject31["minExtent"] = "8 8";
            oc_Newobject31["visible"] = "True";
            oc_Newobject31["setFirstResponder"] = "False";
            oc_Newobject31["modal"] = "True";
            oc_Newobject31["helpTag"] = "0";

            #region GuiButtonCtrl ()        oc_Newobject26

            ObjectCreator oc_Newobject26 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject26["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject26["horizSizing"] = "right";
            oc_Newobject26["vertSizing"] = "bottom";
            oc_Newobject26["position"] = "4 4";
            oc_Newobject26["extent"] = "56 16";
            oc_Newobject26["minExtent"] = "8 8";
            oc_Newobject26["visible"] = "True";
            oc_Newobject26["setFirstResponder"] = "False";
            oc_Newobject26["modal"] = "True";
            oc_Newobject26["command"] = "Canvas.pushDialog(DebuggerBreakConditionDlg, 80);";
            oc_Newobject26["helpTag"] = "0";
            oc_Newobject26["text"] = "Condition";

            #endregion

            oc_Newobject31["#Newobject26"] = oc_Newobject26;

            #region GuiButtonCtrl ()        oc_Newobject27

            ObjectCreator oc_Newobject27 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject27["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject27["horizSizing"] = "right";
            oc_Newobject27["vertSizing"] = "bottom";
            oc_Newobject27["position"] = "68 4";
            oc_Newobject27["extent"] = "56 16";
            oc_Newobject27["minExtent"] = "8 8";
            oc_Newobject27["visible"] = "True";
            oc_Newobject27["setFirstResponder"] = "False";
            oc_Newobject27["modal"] = "True";
            oc_Newobject27["command"] = "DbgDeleteSelectedBreak();";
            oc_Newobject27["helpTag"] = "0";
            oc_Newobject27["text"] = "Delete";

            #endregion

            oc_Newobject31["#Newobject27"] = oc_Newobject27;

            #region GuiButtonCtrl ()        oc_Newobject28

            ObjectCreator oc_Newobject28 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject28["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject28["horizSizing"] = "right";
            oc_Newobject28["vertSizing"] = "bottom";
            oc_Newobject28["position"] = "132 4";
            oc_Newobject28["extent"] = "56 16";
            oc_Newobject28["minExtent"] = "8 8";
            oc_Newobject28["visible"] = "True";
            oc_Newobject28["setFirstResponder"] = "False";
            oc_Newobject28["modal"] = "True";
            oc_Newobject28["command"] = "DebuggerBreakPoints.clearBreaks();";
            oc_Newobject28["helpTag"] = "0";
            oc_Newobject28["text"] = "Clear";

            #endregion

            oc_Newobject31["#Newobject28"] = oc_Newobject28;

            #region GuiScrollCtrl ()        oc_Newobject30

            ObjectCreator oc_Newobject30 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject30["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject30["horizSizing"] = "width";
            oc_Newobject30["vertSizing"] = "height";
            oc_Newobject30["position"] = "0 24";
            oc_Newobject30["extent"] = "153 171";
            oc_Newobject30["minExtent"] = "8 8";
            oc_Newobject30["visible"] = "True";
            oc_Newobject30["setFirstResponder"] = "False";
            oc_Newobject30["modal"] = "True";
            oc_Newobject30["helpTag"] = "0";
            oc_Newobject30["willFirstRespond"] = "True";
            oc_Newobject30["hScrollBar"] = "dynamic";
            oc_Newobject30["vScrollBar"] = "dynamic";
            oc_Newobject30["lockHorizScroll"] = "false";
            oc_Newobject30["lockVertScroll"] = "false";
            oc_Newobject30["constantThumbHeight"] = "False";

            #region GuiTextListCtrl (DebuggerBreakPoints)        oc_Newobject29

            ObjectCreator oc_Newobject29 = new ObjectCreator("GuiTextListCtrl", "DebuggerBreakPoints",
                typeof (CodeBehind.Debugger.DebuggerBreakPoints));
            oc_Newobject29["profile"] = "ToolsGuiTextListProfile";
            oc_Newobject29["horizSizing"] = "right";
            oc_Newobject29["vertSizing"] = "bottom";
            oc_Newobject29["position"] = "0 0";
            oc_Newobject29["extent"] = "182 16";
            oc_Newobject29["minExtent"] = "8 8";
            oc_Newobject29["visible"] = "True";
            oc_Newobject29["setFirstResponder"] = "False";
            oc_Newobject29["modal"] = "True";
            oc_Newobject29["helpTag"] = "0";
            oc_Newobject29["enumerate"] = "False";
            oc_Newobject29["resizeCell"] = "True";
            oc_Newobject29["columns"] = "16 56 156";

            #endregion

            oc_Newobject30["#Newobject29"] = oc_Newobject29;

            #endregion

            oc_Newobject31["#Newobject30"] = oc_Newobject30;

            #endregion

            oc_Newobject37["#Newobject31"] = oc_Newobject31;

            #region GuiControl ()        oc_Newobject36

            ObjectCreator oc_Newobject36 = new ObjectCreator("GuiControl", "");
            oc_Newobject36["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject36["horizSizing"] = "width";
            oc_Newobject36["vertSizing"] = "height";
            oc_Newobject36["position"] = "0 350";
            oc_Newobject36["extent"] = "154 106";
            oc_Newobject36["minExtent"] = "8 8";
            oc_Newobject36["visible"] = "True";
            oc_Newobject36["setFirstResponder"] = "False";
            oc_Newobject36["modal"] = "True";
            oc_Newobject36["helpTag"] = "0";

            #region GuiScrollCtrl ()        oc_Newobject33

            ObjectCreator oc_Newobject33 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject33["profile"] = "ToolsGuiScrollProfile";
            oc_Newobject33["horizSizing"] = "width";
            oc_Newobject33["vertSizing"] = "height";
            oc_Newobject33["position"] = "0 0";
            oc_Newobject33["extent"] = "153 80";
            oc_Newobject33["minExtent"] = "8 8";
            oc_Newobject33["visible"] = "True";
            oc_Newobject33["setFirstResponder"] = "False";
            oc_Newobject33["modal"] = "True";
            oc_Newobject33["helpTag"] = "0";
            oc_Newobject33["willFirstRespond"] = "True";
            oc_Newobject33["hScrollBar"] = "dynamic";
            oc_Newobject33["vScrollBar"] = "dynamic";
            oc_Newobject33["lockHorizScroll"] = "false";
            oc_Newobject33["lockVertScroll"] = "false";
            oc_Newobject33["constantThumbHeight"] = "False";

            #region GuiTextListCtrl (DebuggerConsoleView)        oc_Newobject32

            ObjectCreator oc_Newobject32 = new ObjectCreator("GuiTextListCtrl", "DebuggerConsoleView",
                typeof (CodeBehind.Debugger.DebuggerConsoleView));
            oc_Newobject32["profile"] = "ToolsGuiTextListProfile";
            oc_Newobject32["horizSizing"] = "right";
            oc_Newobject32["vertSizing"] = "bottom";
            oc_Newobject32["position"] = "0 0";
            oc_Newobject32["extent"] = "62 16";
            oc_Newobject32["minExtent"] = "8 8";
            oc_Newobject32["visible"] = "True";
            oc_Newobject32["setFirstResponder"] = "False";
            oc_Newobject32["modal"] = "True";
            oc_Newobject32["helpTag"] = "0";
            oc_Newobject32["enumerate"] = "False";
            oc_Newobject32["resizeCell"] = "True";
            oc_Newobject32["columns"] = "0";

            #endregion

            oc_Newobject33["#Newobject32"] = oc_Newobject32;

            #endregion

            oc_Newobject36["#Newobject33"] = oc_Newobject33;

            #region GuiTextCtrl ()        oc_Newobject34

            ObjectCreator oc_Newobject34 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject34["profile"] = "ToolsGuiTextProfile";
            oc_Newobject34["horizSizing"] = "right";
            oc_Newobject34["vertSizing"] = "top";
            oc_Newobject34["position"] = "15 83";
            oc_Newobject34["extent"] = "9 18";
            oc_Newobject34["minExtent"] = "8 8";
            oc_Newobject34["visible"] = "True";
            oc_Newobject34["setFirstResponder"] = "False";
            oc_Newobject34["modal"] = "True";
            oc_Newobject34["helpTag"] = "0";
            oc_Newobject34["text"] = "%";

            #endregion

            oc_Newobject36["#Newobject34"] = oc_Newobject34;

            #region GuiTextEditCtrl (DbgConsoleEntry)        oc_Newobject35

            ObjectCreator oc_Newobject35 = new ObjectCreator("GuiTextEditCtrl", "DbgConsoleEntry");
            oc_Newobject35["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject35["horizSizing"] = "width";
            oc_Newobject35["vertSizing"] = "top";
            oc_Newobject35["position"] = "29 83";
            oc_Newobject35["extent"] = "120 18";
            oc_Newobject35["minExtent"] = "8 8";
            oc_Newobject35["visible"] = "True";
            oc_Newobject35["setFirstResponder"] = "False";
            oc_Newobject35["modal"] = "True";
            oc_Newobject35["altCommand"] = "DbgConsoleEntryReturn();";
            oc_Newobject35["helpTag"] = "0";
            oc_Newobject35["historySize"] = "32";

            #endregion

            oc_Newobject36["#Newobject35"] = oc_Newobject35;

            #endregion

            oc_Newobject37["#Newobject36"] = oc_Newobject36;

            #endregion

            oc_Newobject38["#Newobject37"] = oc_Newobject37;

            #endregion

            oc_Newobject39["#Newobject38"] = oc_Newobject38;

            #endregion

            oc_Newobject39.Create();
            }
        }
    }