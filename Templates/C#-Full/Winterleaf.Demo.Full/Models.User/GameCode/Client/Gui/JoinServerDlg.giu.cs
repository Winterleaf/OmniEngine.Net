using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<JoinServerDlg>))]
    public class JoinServerDlg : GuiControl
        {
        

        public static void initialize()
            {
            #region GuiControl (JoinServerDlg)        oc_Newobject21

            ObjectCreator oc_Newobject21 = new ObjectCreator("GuiControl", "JoinServerDlg", typeof (JoinServerDlg));
            oc_Newobject21["canSaveDynamicFields"] = "0";
            oc_Newobject21["Enabled"] = "1";
            oc_Newobject21["isContainer"] = "1";
            oc_Newobject21["Profile"] = "GuiOverlayProfile";
            oc_Newobject21["HorizSizing"] = "width";
            oc_Newobject21["VertSizing"] = "height";
            oc_Newobject21["position"] = "0 0";
            oc_Newobject21["Extent"] = "1024 768";
            oc_Newobject21["MinExtent"] = "8 8";
            oc_Newobject21["canSave"] = "1";
            oc_Newobject21["Visible"] = "1";
            oc_Newobject21["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject21["hovertime"] = "1000";

            #region GuiWindowCtrl ()        oc_Newobject20

            ObjectCreator oc_Newobject20 = new ObjectCreator("GuiWindowCtrl", "");
            oc_Newobject20["canSaveDynamicFields"] = "0";
            oc_Newobject20["Enabled"] = "1";
            oc_Newobject20["isContainer"] = "1";
            oc_Newobject20["Profile"] = "GuiWindowProfile";
            oc_Newobject20["HorizSizing"] = "center";
            oc_Newobject20["VertSizing"] = "center";
            oc_Newobject20["Position"] = "252 224";
            oc_Newobject20["Extent"] = "520 320";
            oc_Newobject20["MinExtent"] = "8 8";
            oc_Newobject20["canSave"] = "1";
            oc_Newobject20["isDecoy"] = "0";
            oc_Newobject20["Visible"] = "1";
            oc_Newobject20["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject20["hovertime"] = "1000";
            oc_Newobject20["Margin"] = "0 0 0 0";
            oc_Newobject20["Padding"] = "0 0 0 0";
            oc_Newobject20["AnchorTop"] = "1";
            oc_Newobject20["AnchorBottom"] = "0";
            oc_Newobject20["AnchorLeft"] = "1";
            oc_Newobject20["AnchorRight"] = "0";
            oc_Newobject20["resizeWidth"] = "0";
            oc_Newobject20["resizeHeight"] = "0";
            oc_Newobject20["canMove"] = "1";
            oc_Newobject20["canClose"] = "1";
            oc_Newobject20["canMinimize"] = "0";
            oc_Newobject20["canMaximize"] = "0";
            oc_Newobject20["minSize"] = "50 50";
            oc_Newobject20["EdgeSnap"] = "1";
            oc_Newobject20["text"] = "Join Server";
            oc_Newobject20["closeCommand"] = "Canvas.popDialog(JoinServerDlg);";

            #region GuiButtonCtrl (JS_queryMaster)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiButtonCtrl", "JS_queryMaster");
            oc_Newobject1["canSaveDynamicFields"] = "0";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "GuiButtonProfile";
            oc_Newobject1["HorizSizing"] = "right";
            oc_Newobject1["VertSizing"] = "top";
            oc_Newobject1["Position"] = "216 289";
            oc_Newobject1["Extent"] = "90 23";
            oc_Newobject1["MinExtent"] = "8 8";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["isDecoy"] = "0";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["Command"] = "JoinServerDlg.query();";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["text"] = "Query Master";
            oc_Newobject1["groupNum"] = "-1";
            oc_Newobject1["buttonType"] = "PushButton";
            oc_Newobject1["useMouseEvents"] = "0";

            #endregion

            oc_Newobject20["#Newobject1"] = oc_Newobject1;

            #region GuiButtonCtrl (JS_queryLan)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiButtonCtrl", "JS_queryLan");
            oc_Newobject2["canSaveDynamicFields"] = "0";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "GuiButtonProfile";
            oc_Newobject2["HorizSizing"] = "right";
            oc_Newobject2["VertSizing"] = "top";
            oc_Newobject2["Position"] = "114 289";
            oc_Newobject2["Extent"] = "90 23";
            oc_Newobject2["MinExtent"] = "8 8";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["isDecoy"] = "0";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["Command"] = "JoinServerDlg.queryLan();";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["text"] = "Query LAN";
            oc_Newobject2["groupNum"] = "-1";
            oc_Newobject2["buttonType"] = "PushButton";
            oc_Newobject2["useMouseEvents"] = "0";

            #endregion

            oc_Newobject20["#Newobject2"] = oc_Newobject2;

            #region GuiButtonCtrl (JS_refreshServer)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiButtonCtrl", "JS_refreshServer");
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "0";
            oc_Newobject3["Profile"] = "GuiButtonProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "top";
            oc_Newobject3["Position"] = "318 289";
            oc_Newobject3["Extent"] = "90 23";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["isDecoy"] = "0";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["Command"] = "JoinServerDlg.refresh();";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["text"] = "Refresh Server";
            oc_Newobject3["groupNum"] = "-1";
            oc_Newobject3["buttonType"] = "PushButton";
            oc_Newobject3["useMouseEvents"] = "0";

            #endregion

            oc_Newobject20["#Newobject3"] = oc_Newobject3;

            #region GuiButtonCtrl (JS_joinServer)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiButtonCtrl", "JS_joinServer");
            oc_Newobject4["canSaveDynamicFields"] = "0";
            oc_Newobject4["Enabled"] = "1";
            oc_Newobject4["isContainer"] = "0";
            oc_Newobject4["Profile"] = "GuiButtonProfile";
            oc_Newobject4["HorizSizing"] = "right";
            oc_Newobject4["VertSizing"] = "top";
            oc_Newobject4["Position"] = "420 289";
            oc_Newobject4["Extent"] = "90 23";
            oc_Newobject4["MinExtent"] = "8 8";
            oc_Newobject4["canSave"] = "1";
            oc_Newobject4["isDecoy"] = "0";
            oc_Newobject4["Visible"] = "1";
            oc_Newobject4["Command"] = "JoinServerDlg.join();";
            oc_Newobject4["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject4["hovertime"] = "1000";
            oc_Newobject4["text"] = "Join Server!";
            oc_Newobject4["groupNum"] = "-1";
            oc_Newobject4["buttonType"] = "PushButton";
            oc_Newobject4["useMouseEvents"] = "0";

            #endregion

            oc_Newobject20["#Newobject4"] = oc_Newobject4;

            #region GuiScrollCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "GuiScrollProfile";
            oc_Newobject6["HorizSizing"] = "right";
            oc_Newobject6["VertSizing"] = "bottom";
            oc_Newobject6["Position"] = "10 80";
            oc_Newobject6["Extent"] = "500 197";
            oc_Newobject6["MinExtent"] = "8 8";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Margin"] = "0 0 0 0";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["willFirstRespond"] = "1";
            oc_Newobject6["hScrollBar"] = "dynamic";
            oc_Newobject6["vScrollBar"] = "alwaysOn";
            oc_Newobject6["lockHorizScroll"] = "false";
            oc_Newobject6["lockVertScroll"] = "false";
            oc_Newobject6["constantThumbHeight"] = "0";
            oc_Newobject6["childMargin"] = "0 0";
            oc_Newobject6["mouseWheelScrollSpeed"] = "-1";

            #region GuiTextListCtrl (JS_serverList)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiTextListCtrl", "JS_serverList");
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "GuiTextArrayProfile";
            oc_Newobject5["HorizSizing"] = "right";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "1 1";
            oc_Newobject5["Extent"] = "485 8";
            oc_Newobject5["MinExtent"] = "8 8";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";
            oc_Newobject5["enumerate"] = "0";
            oc_Newobject5["resizeCell"] = "1";
            oc_Newobject5["columns"] = "0 200 270 335 400";
            oc_Newobject5["fitParentWidth"] = "1";
            oc_Newobject5["clipColumnText"] = "0";
            oc_Newobject5["altCommand"] = "JoinServerDlg.join();";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject20["#Newobject6"] = oc_Newobject6;

            #region GuiTextEditCtrl ()        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiTextEditCtrl", "");
            oc_Newobject7["canSaveDynamicFields"] = "0";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "0";
            oc_Newobject7["Profile"] = "GuiTextEditProfile";
            oc_Newobject7["HorizSizing"] = "right";
            oc_Newobject7["VertSizing"] = "bottom";
            oc_Newobject7["Position"] = "84 31";
            oc_Newobject7["Extent"] = "144 18";
            oc_Newobject7["MinExtent"] = "8 8";
            oc_Newobject7["canSave"] = "1";
            oc_Newobject7["isDecoy"] = "0";
            oc_Newobject7["Visible"] = "1";
            oc_Newobject7["Variable"] = "pref::Player::Name";
            oc_Newobject7["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject7["hovertime"] = "1000";
            oc_Newobject7["Margin"] = "0 0 0 0";
            oc_Newobject7["Padding"] = "0 0 0 0";
            oc_Newobject7["AnchorTop"] = "1";
            oc_Newobject7["AnchorBottom"] = "0";
            oc_Newobject7["AnchorLeft"] = "1";
            oc_Newobject7["AnchorRight"] = "0";
            oc_Newobject7["maxLength"] = "255";
            oc_Newobject7["historySize"] = "0";
            oc_Newobject7["password"] = "0";
            oc_Newobject7["tabComplete"] = "0";
            oc_Newobject7["sinkAllKeyEvents"] = "0";
            oc_Newobject7["passwordMask"] = "*";

            #endregion

            oc_Newobject20["#Newobject7"] = oc_Newobject7;

            #region GuiTextCtrl ()        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "0";
            oc_Newobject8["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "12 31";
            oc_Newobject8["Extent"] = "63 18";
            oc_Newobject8["MinExtent"] = "8 8";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";
            oc_Newobject8["Margin"] = "0 0 0 0";
            oc_Newobject8["Padding"] = "0 0 0 0";
            oc_Newobject8["AnchorTop"] = "1";
            oc_Newobject8["AnchorBottom"] = "0";
            oc_Newobject8["AnchorLeft"] = "1";
            oc_Newobject8["AnchorRight"] = "0";
            oc_Newobject8["text"] = "Player Name:";
            oc_Newobject8["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject8"] = oc_Newobject8;

            #region GuiTextCtrl ()        oc_Newobject9

            ObjectCreator oc_Newobject9 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject9["canSaveDynamicFields"] = "0";
            oc_Newobject9["Enabled"] = "1";
            oc_Newobject9["isContainer"] = "0";
            oc_Newobject9["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject9["HorizSizing"] = "right";
            oc_Newobject9["VertSizing"] = "bottom";
            oc_Newobject9["Position"] = "269 59";
            oc_Newobject9["Extent"] = "36 18";
            oc_Newobject9["MinExtent"] = "8 8";
            oc_Newobject9["canSave"] = "1";
            oc_Newobject9["isDecoy"] = "0";
            oc_Newobject9["Visible"] = "1";
            oc_Newobject9["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject9["hovertime"] = "1000";
            oc_Newobject9["Margin"] = "0 0 0 0";
            oc_Newobject9["Padding"] = "0 0 0 0";
            oc_Newobject9["AnchorTop"] = "1";
            oc_Newobject9["AnchorBottom"] = "0";
            oc_Newobject9["AnchorLeft"] = "1";
            oc_Newobject9["AnchorRight"] = "0";
            oc_Newobject9["text"] = "Players";
            oc_Newobject9["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject9"] = oc_Newobject9;

            #region GuiTextCtrl ()        oc_Newobject10

            ObjectCreator oc_Newobject10 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject10["canSaveDynamicFields"] = "0";
            oc_Newobject10["Enabled"] = "1";
            oc_Newobject10["isContainer"] = "0";
            oc_Newobject10["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject10["HorizSizing"] = "right";
            oc_Newobject10["VertSizing"] = "bottom";
            oc_Newobject10["Position"] = "335 59";
            oc_Newobject10["Extent"] = "38 18";
            oc_Newobject10["MinExtent"] = "8 8";
            oc_Newobject10["canSave"] = "1";
            oc_Newobject10["isDecoy"] = "0";
            oc_Newobject10["Visible"] = "1";
            oc_Newobject10["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject10["hovertime"] = "1000";
            oc_Newobject10["Margin"] = "0 0 0 0";
            oc_Newobject10["Padding"] = "0 0 0 0";
            oc_Newobject10["AnchorTop"] = "1";
            oc_Newobject10["AnchorBottom"] = "0";
            oc_Newobject10["AnchorLeft"] = "1";
            oc_Newobject10["AnchorRight"] = "0";
            oc_Newobject10["text"] = "Version";
            oc_Newobject10["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject10"] = oc_Newobject10;

            #region GuiTextCtrl ()        oc_Newobject11

            ObjectCreator oc_Newobject11 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject11["canSaveDynamicFields"] = "0";
            oc_Newobject11["Enabled"] = "1";
            oc_Newobject11["isContainer"] = "0";
            oc_Newobject11["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject11["HorizSizing"] = "right";
            oc_Newobject11["VertSizing"] = "bottom";
            oc_Newobject11["Position"] = "412 59";
            oc_Newobject11["Extent"] = "28 18";
            oc_Newobject11["MinExtent"] = "8 8";
            oc_Newobject11["canSave"] = "1";
            oc_Newobject11["isDecoy"] = "0";
            oc_Newobject11["Visible"] = "1";
            oc_Newobject11["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject11["hovertime"] = "1000";
            oc_Newobject11["Margin"] = "0 0 0 0";
            oc_Newobject11["Padding"] = "0 0 0 0";
            oc_Newobject11["AnchorTop"] = "1";
            oc_Newobject11["AnchorBottom"] = "0";
            oc_Newobject11["AnchorLeft"] = "1";
            oc_Newobject11["AnchorRight"] = "0";
            oc_Newobject11["text"] = "Game";
            oc_Newobject11["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject11"] = oc_Newobject11;

            #region GuiTextCtrl ()        oc_Newobject12

            ObjectCreator oc_Newobject12 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject12["canSaveDynamicFields"] = "0";
            oc_Newobject12["Enabled"] = "1";
            oc_Newobject12["isContainer"] = "0";
            oc_Newobject12["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject12["HorizSizing"] = "right";
            oc_Newobject12["VertSizing"] = "bottom";
            oc_Newobject12["Position"] = "212 59";
            oc_Newobject12["Extent"] = "20 18";
            oc_Newobject12["MinExtent"] = "8 8";
            oc_Newobject12["canSave"] = "1";
            oc_Newobject12["isDecoy"] = "0";
            oc_Newobject12["Visible"] = "1";
            oc_Newobject12["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject12["hovertime"] = "1000";
            oc_Newobject12["Margin"] = "0 0 0 0";
            oc_Newobject12["Padding"] = "0 0 0 0";
            oc_Newobject12["AnchorTop"] = "1";
            oc_Newobject12["AnchorBottom"] = "0";
            oc_Newobject12["AnchorLeft"] = "1";
            oc_Newobject12["AnchorRight"] = "0";
            oc_Newobject12["text"] = "Ping";
            oc_Newobject12["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject12"] = oc_Newobject12;

            #region GuiTextCtrl ()        oc_Newobject13

            ObjectCreator oc_Newobject13 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject13["canSaveDynamicFields"] = "0";
            oc_Newobject13["Enabled"] = "1";
            oc_Newobject13["isContainer"] = "0";
            oc_Newobject13["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject13["HorizSizing"] = "right";
            oc_Newobject13["VertSizing"] = "bottom";
            oc_Newobject13["Position"] = "12 59";
            oc_Newobject13["Extent"] = "63 18";
            oc_Newobject13["MinExtent"] = "8 8";
            oc_Newobject13["canSave"] = "1";
            oc_Newobject13["isDecoy"] = "0";
            oc_Newobject13["Visible"] = "1";
            oc_Newobject13["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject13["hovertime"] = "1000";
            oc_Newobject13["Margin"] = "0 0 0 0";
            oc_Newobject13["Padding"] = "0 0 0 0";
            oc_Newobject13["AnchorTop"] = "1";
            oc_Newobject13["AnchorBottom"] = "0";
            oc_Newobject13["AnchorLeft"] = "1";
            oc_Newobject13["AnchorRight"] = "0";
            oc_Newobject13["text"] = "Server Name";
            oc_Newobject13["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject13"] = oc_Newobject13;

            #region GuiButtonCtrl ()        oc_Newobject14

            ObjectCreator oc_Newobject14 = new ObjectCreator("GuiButtonCtrl", "");
            oc_Newobject14["canSaveDynamicFields"] = "0";
            oc_Newobject14["Enabled"] = "1";
            oc_Newobject14["isContainer"] = "0";
            oc_Newobject14["Profile"] = "GuiButtonProfile";
            oc_Newobject14["HorizSizing"] = "right";
            oc_Newobject14["VertSizing"] = "top";
            oc_Newobject14["Position"] = "12 289";
            oc_Newobject14["Extent"] = "90 23";
            oc_Newobject14["MinExtent"] = "8 8";
            oc_Newobject14["canSave"] = "1";
            oc_Newobject14["isDecoy"] = "0";
            oc_Newobject14["Visible"] = "1";
            oc_Newobject14["Command"] = "JoinServerDlg.exit();";
            oc_Newobject14["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject14["hovertime"] = "1000";
            oc_Newobject14["text"] = "< Back";
            oc_Newobject14["groupNum"] = "-1";
            oc_Newobject14["buttonType"] = "PushButton";
            oc_Newobject14["useMouseEvents"] = "0";

            #endregion

            oc_Newobject20["#Newobject14"] = oc_Newobject14;

            #region GuiWindowCtrl (JS_queryStatus)        oc_Newobject18

            ObjectCreator oc_Newobject18 = new ObjectCreator("GuiWindowCtrl", "JS_queryStatus");
            oc_Newobject18["canSaveDynamicFields"] = "0";
            oc_Newobject18["Enabled"] = "1";
            oc_Newobject18["isContainer"] = "1";
            oc_Newobject18["Profile"] = "GuiWindowProfile";
            oc_Newobject18["HorizSizing"] = "center";
            oc_Newobject18["VertSizing"] = "center";
            oc_Newobject18["Position"] = "105 135";
            oc_Newobject18["Extent"] = "310 50";
            oc_Newobject18["MinExtent"] = "8 8";
            oc_Newobject18["canSave"] = "1";
            oc_Newobject18["isDecoy"] = "0";
            oc_Newobject18["Visible"] = "0";
            oc_Newobject18["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject18["hovertime"] = "1000";
            oc_Newobject18["resizeWidth"] = "0";
            oc_Newobject18["resizeHeight"] = "0";
            oc_Newobject18["canMove"] = "0";
            oc_Newobject18["canClose"] = "0";
            oc_Newobject18["canMinimize"] = "0";
            oc_Newobject18["canMaximize"] = "0";
            oc_Newobject18["canCollapse"] = "0";
            oc_Newobject18["text"] = "Status";

            #region GuiButtonCtrl (JS_cancelQuery)        oc_Newobject15

            ObjectCreator oc_Newobject15 = new ObjectCreator("GuiButtonCtrl", "JS_cancelQuery");
            oc_Newobject15["canSaveDynamicFields"] = "0";
            oc_Newobject15["Enabled"] = "1";
            oc_Newobject15["isContainer"] = "0";
            oc_Newobject15["Profile"] = "GuiButtonProfile";
            oc_Newobject15["HorizSizing"] = "right";
            oc_Newobject15["VertSizing"] = "bottom";
            oc_Newobject15["Position"] = "9 25";
            oc_Newobject15["Extent"] = "64 20";
            oc_Newobject15["MinExtent"] = "8 8";
            oc_Newobject15["canSave"] = "1";
            oc_Newobject15["isDecoy"] = "0";
            oc_Newobject15["Visible"] = "1";
            oc_Newobject15["Command"] = "JoinServerDlg.cancel();";
            oc_Newobject15["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject15["hovertime"] = "1000";
            oc_Newobject15["text"] = "Cancel!";
            oc_Newobject15["groupNum"] = "-1";
            oc_Newobject15["buttonType"] = "PushButton";
            oc_Newobject15["useMouseEvents"] = "0";

            #endregion

            oc_Newobject18["#Newobject15"] = oc_Newobject15;

            #region GuiProgressCtrl (JS_statusBar)        oc_Newobject16

            ObjectCreator oc_Newobject16 = new ObjectCreator("GuiProgressCtrl", "JS_statusBar");
            oc_Newobject16["canSaveDynamicFields"] = "0";
            oc_Newobject16["Enabled"] = "1";
            oc_Newobject16["isContainer"] = "0";
            oc_Newobject16["Profile"] = "GuiProgressProfile";
            oc_Newobject16["HorizSizing"] = "right";
            oc_Newobject16["VertSizing"] = "bottom";
            oc_Newobject16["Position"] = "84 25";
            oc_Newobject16["Extent"] = "207 20";
            oc_Newobject16["MinExtent"] = "8 8";
            oc_Newobject16["canSave"] = "1";
            oc_Newobject16["isDecoy"] = "0";
            oc_Newobject16["Visible"] = "1";
            oc_Newobject16["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject16["hovertime"] = "1000";
            oc_Newobject16["Margin"] = "0 0 0 0";
            oc_Newobject16["Padding"] = "0 0 0 0";
            oc_Newobject16["AnchorTop"] = "1";
            oc_Newobject16["AnchorBottom"] = "0";
            oc_Newobject16["AnchorLeft"] = "1";
            oc_Newobject16["AnchorRight"] = "0";
            oc_Newobject16["maxLength"] = "1024";

            #endregion

            oc_Newobject18["#Newobject16"] = oc_Newobject16;

            #region GuiTextCtrl (JS_statusText)        oc_Newobject17

            ObjectCreator oc_Newobject17 = new ObjectCreator("GuiTextCtrl", "JS_statusText");
            oc_Newobject17["canSaveDynamicFields"] = "0";
            oc_Newobject17["Enabled"] = "1";
            oc_Newobject17["isContainer"] = "0";
            oc_Newobject17["Profile"] = "GuiProgressTextProfile";
            oc_Newobject17["HorizSizing"] = "right";
            oc_Newobject17["VertSizing"] = "bottom";
            oc_Newobject17["Position"] = "85 25";
            oc_Newobject17["Extent"] = "205 20";
            oc_Newobject17["MinExtent"] = "8 8";
            oc_Newobject17["canSave"] = "1";
            oc_Newobject17["isDecoy"] = "0";
            oc_Newobject17["Visible"] = "1";
            oc_Newobject17["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject17["hovertime"] = "1000";
            oc_Newobject17["Margin"] = "0 0 0 0";
            oc_Newobject17["Padding"] = "0 0 0 0";
            oc_Newobject17["AnchorTop"] = "1";
            oc_Newobject17["AnchorBottom"] = "0";
            oc_Newobject17["AnchorLeft"] = "1";
            oc_Newobject17["AnchorRight"] = "0";
            oc_Newobject17["text"] = "Querying master server";
            oc_Newobject17["maxLength"] = "255";

            #endregion

            oc_Newobject18["#Newobject17"] = oc_Newobject17;

            #endregion

            oc_Newobject20["#Newobject18"] = oc_Newobject18;

            #region GuiTextCtrl (JS_status)        oc_Newobject19

            ObjectCreator oc_Newobject19 = new ObjectCreator("GuiTextCtrl", "JS_status");
            oc_Newobject19["canSaveDynamicFields"] = "0";
            oc_Newobject19["Profile"] = "GuiAutoSizeTextProfile";
            oc_Newobject19["HorizSizing"] = "right";
            oc_Newobject19["VertSizing"] = "bottom";
            oc_Newobject19["Position"] = "245 31";
            oc_Newobject19["Extent"] = "177 19";
            oc_Newobject19["MinExtent"] = "8 8";
            oc_Newobject19["text"] = "";
            oc_Newobject19["visible"] = "1";
            oc_Newobject19["maxLength"] = "255";

            #endregion

            oc_Newobject20["#Newobject19"] = oc_Newobject19;

            #endregion

            oc_Newobject21["#Newobject20"] = oc_Newobject20;

            #endregion

            oc_Newobject21.Create();
            }

        public override void onWake()
            {
            ((GuiButtonCtrl) "JS_joinServer").setActive(((GuiTextListCtrl) "JS_serverList").rowCount() > 0);
            }

        [ConsoleInteraction]
        public void query()
            {
            Util.queryMasterServer(
                uGlobal["$pref::Net::Port"],
                0, // Query flags
                sGlobal["$Client::GameTypeQuery"], // gameTypes
                sGlobal["$Client::MissionTypeQuery"], // missionType
                0, // minPlayers
                100, // maxPlayers
                0, // maxBots
                2, // regionMask
                0, // maxPing
                100, // minCPU
                0 // filterFlags
                );
            }

        [ConsoleInteraction]
        public void queryLan()
            {
            //GameConnection conn = new ObjectCreator("GameConnection", "ServerConnection").Create();
            //conn.setConnectArgs(sGlobal["$pref::Player::Name"]);
            //conn.setJoinPassword(sGlobal["$Client::Password"]);
            //conn.connect("192.168.0.87:28000");

            //return;

            Util.queryLanServers(
                uGlobal["$pref::Net::Port"], // lanPort for local queries
                0, // Query flags
                sGlobal["$Client::GameTypeQuery"], // gameTypes
                "Deathmatch", //sGlobal["$Client::MissionTypeQuery"], // missionType
                0, // minPlayers
                100, // maxPlayers
                0, // maxBots
                2, // regionMask
                0, // maxPing
                100, // minCPU
                0 // filterFlags
                );
            }

        [ConsoleInteraction]
        public void cancel()
            {
            Util.cancelServerQuery();
            ((GuiWindowCtrl) "JS_queryStatus").setVisible(false);
            }

        [ConsoleInteraction]
        public void join()
            {
            Util.cancelServerQuery();
            int index = ((GuiTextListCtrl) "JS_serverList").getSelectedId();
            // The server info index is stored in the row along with the
            // rest of displayed info.

            if (Util.setServerInfo((uint)index))
                {
                ((GuiCanvas) "Canvas").setContent("LoadingGui");
                ((GuiProgressBitmapCtrl) "LoadingProgress").setValue("1");
                ((GuiTextCtrl) "LoadingProgressTxt").setValue("WAITING FOR SERVER");
                ((GuiCanvas) "Canvas").repaint(-1);

                if ("ServerConnection".isObject())
                    "ServerConnection".delete();

                GameConnection conn = new ObjectCreator("GameConnection", "ServerConnection").Create();
                conn.setConnectArgs(sGlobal["$pref::Player::Name"]);
                conn.setJoinPassword(sGlobal["$Client::Password"]);
                conn.connect(sGlobal["$ServerInfo::Address"]);
                }
            }

        [ConsoleInteraction]
        public void refresh()
            {
            Util.cancelServerQuery();
            int index = ((GuiTextListCtrl) "JS_serverList").getSelectedId();

            // The server info index is stored in the row along with the
            // rest of displayed info.

            if (Util.setServerInfo((uint)index))
                Util.querySingleServer(sGlobal["$ServerInfo::Address"], 0);
            }

        [ConsoleInteraction]
        public void refreshSelectedServer()
            {
            Util.querySingleServer(sGlobal["$JoinGameAddress"], 0);
            }

        [ConsoleInteraction]
        public void exit()
            {
            Util.cancelServerQuery();
            ((GuiCanvas) "Canvas").popDialog("JoinServerDlg");
            }

        [ConsoleInteraction]
        public void update()
            {
            // Copy the servers into the server list.
            ((GuiWindowCtrl) "JS_queryStatus").setVisible(false);

            GuiTextListCtrl JS_serverList = "JS_serverList";

            JS_serverList.clear();

            int sc = Util.getServerCount();

            for (int i = 0; i < sc; i++)
                {
                Util.setServerInfo((uint)i);
                JS_serverList.addRow(i,
                    sGlobal["$ServerInfo::Name"] + '\t' + sGlobal["$ServerInfo::Ping"] + "\t" +
                    sGlobal["$ServerInfo::PlayerCount"] + "/" + sGlobal["$ServerInfo::MaxPlayers"] + "/t" +
                    sGlobal["$ServerInfo::Version"] + "\t" + sGlobal["$ServerInfo::MissionName"], -1);
                }
            JS_serverList.sort("0");
            JS_serverList.setSelectedRow(0);
            JS_serverList.scrollVisible(0);
            ((GuiButtonCtrl) "JS_joinServer").setActive(JS_serverList.rowCount() > 0);
            }

        [ConsoleInteraction]
        public static void onServerQueryStatus(string status, string msg, string value)
            {
            omni.Util._echo("ServerQuery: " + " " + status + " " + msg + " " + value);
            // Update query status
            // States: start, update, ping, query, done
            // value = % (0-1) done for ping and query states

            if (!((GuiWindowCtrl) "JS_queryStatus").isVisible())
                ((GuiWindowCtrl) "JS_queryStatus").setVisible(true);

            switch (status)
                {
                    case "start":
                        ((GuiButtonCtrl) "JS_joinServer").setActive(false);
                        ((GuiButtonCtrl) "JS_queryMaster").setActive(false);
                        ((GuiTextCtrl) "JS_statusText").setText(msg);
                        ((GuiProgressCtrl) "JS_statusBar").setValue("0");
                        ((GuiTextListCtrl) "JS_serverList").clear();
                        break;
                    case "ping":
                        ((GuiTextCtrl) "JS_statusText").setText("Ping Server");
                        ((GuiProgressCtrl) "JS_statusBar").setValue(value);
                        break;

                    case "query":
                        ((GuiTextCtrl) "JS_statusText").setText("Query Server");
                        ((GuiProgressCtrl) "JS_statusBar").setValue(value);
                        break;
                    case "done":
                        ((GuiButtonCtrl) "JS_queryMaster").setActive(true);
                        ((GuiWindowCtrl) "JS_queryStatus").setVisible(false);
                        ((GuiTextCtrl) "JS_status").setText(msg);
                        ((JoinServerDlg) "JoinServerDlg").update();
                        break;
                }
            }

        #region AutoGen Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(JoinServerDlg ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
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
        public static bool operator !=(JoinServerDlg ts, string simobjectid)
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
        public static implicit operator string(JoinServerDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator JoinServerDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (JoinServerDlg) Omni.self.getSimObject(simobjectid, typeof (JoinServerDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(JoinServerDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator JoinServerDlg(int simobjectid)
            {
            return (JoinServerDlg) Omni.self.getSimObject((uint) simobjectid, typeof (JoinServerDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(JoinServerDlg ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._ID, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator JoinServerDlg(uint simobjectid)
            {
            return (JoinServerDlg) Omni.self.getSimObject(simobjectid, typeof (JoinServerDlg));
            }

        #endregion
        }
    }