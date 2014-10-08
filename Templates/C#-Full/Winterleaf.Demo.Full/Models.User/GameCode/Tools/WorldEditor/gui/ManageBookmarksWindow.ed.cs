using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.cameraBookmarks.ed.cs;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui
    {
    public class ManageBookmarksWindow
        {
        [ConsoleInteraction(true, "ManageBookmarksWindow_initialize")]
        public static void initialize()
            {
            #region GuiControl (ManageBookmarksContainer, EditorGuiGroup)        oc_Newobject8

            ObjectCreator oc_Newobject8 = new ObjectCreator("GuiControl", "ManageBookmarksContainer, EditorGuiGroup",
                typeof (ManageBookmarksContainer));
            oc_Newobject8["canSaveDynamicFields"] = "0";
            oc_Newobject8["Enabled"] = "1";
            oc_Newobject8["isContainer"] = "1";
            oc_Newobject8["Profile"] = "ToolsGuiModelessDialogProfile";
            oc_Newobject8["HorizSizing"] = "right";
            oc_Newobject8["VertSizing"] = "bottom";
            oc_Newobject8["Position"] = "0 0";
            oc_Newobject8["Extent"] = "800 600";
            oc_Newobject8["MinExtent"] = "8 2";
            oc_Newobject8["canSave"] = "1";
            oc_Newobject8["isDecoy"] = "0";
            oc_Newobject8["Visible"] = "1";
            oc_Newobject8["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject8["hovertime"] = "1000";

            #region GuiWindowCollapseCtrl (EManageBookmarks)        oc_Newobject7

            ObjectCreator oc_Newobject7 = new ObjectCreator("GuiWindowCollapseCtrl", "EManageBookmarks",
                typeof (EManageBookmarks));
            oc_Newobject7["AllowPopWindow"] = "1";
            oc_Newobject7["internalName"] = "ManageBookmarksWindow";
            oc_Newobject7["Enabled"] = "1";
            oc_Newobject7["isContainer"] = "1";
            oc_Newobject7["profile"] = "ToolsGuiWindowProfile";
            oc_Newobject7["HorizSizing"] = "windowRelative";
            oc_Newobject7["VertSizing"] = "windowRelative";
            oc_Newobject7["resizeWidth"] = "1";
            oc_Newobject7["resizeHeight"] = "1";
            oc_Newobject7["canClose"] = "1";
            oc_Newobject7["canMinimize"] = "0";
            oc_Newobject7["canMaximize"] = "0";
            oc_Newobject7["position"] = "50 90";
            oc_Newobject7["extent"] = "180 306";
            oc_Newobject7["MinExtent"] = "120 130";
            oc_Newobject7["text"] = "Camera Bookmark Manager";
            oc_Newobject7["closeCommand"] = "EManageBookmarks.hideDialog();";
            oc_Newobject7["EdgeSnap"] = "0";
            oc_Newobject7["canCollapse"] = "0";
            oc_Newobject7["visible"] = "0";
            oc_Newobject7["Margin"] = "5 5 5 5";
            oc_Newobject7["Padding"] = "5 5 5 5";

            #region GuiControl ()        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiControl", "");
            oc_Newobject4["horizSizing"] = "width";
            oc_Newobject4["vertSizing"] = "bottom";
            oc_Newobject4["position"] = "4 23";
            oc_Newobject4["extent"] = "170 20";

            #region GuiTextCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiTextCtrl", "");
            oc_Newobject1["profile"] = "GuiCenterTextProfile";
            oc_Newobject1["horizSizing"] = "right";
            oc_Newobject1["vertSizing"] = "bottom";
            oc_Newobject1["position"] = "1 2";
            oc_Newobject1["extent"] = "24 16";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["setFirstResponder"] = "0";
            oc_Newobject1["modal"] = "1";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["text"] = "New";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiTextEditCtrl (EAddBookmarkWindowName)        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiTextEditCtrl", "EAddBookmarkWindowName",
                typeof (EManageBookmarks.EAddBookmarkWindowName));
            oc_Newobject2["profile"] = "ToolsGuiTextEditProfile";
            oc_Newobject2["horizSizing"] = "width";
            oc_Newobject2["vertSizing"] = "bottom";
            oc_Newobject2["position"] = "27 2";
            oc_Newobject2["extent"] = "126 18";
            oc_Newobject2["minExtent"] = "8 8";
            oc_Newobject2["visible"] = "1";
            oc_Newobject2["setFirstResponder"] = "0";
            oc_Newobject2["modal"] = "1";
            oc_Newobject2["helpTag"] = "0";
            oc_Newobject2["historySize"] = "0";

            #endregion

            oc_Newobject4["#Newobject2"] = oc_Newobject2;

            #region GuiBitmapButtonCtrl (EAddBookmarkWindowOK)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiBitmapButtonCtrl", "EAddBookmarkWindowOK");
            oc_Newobject3["profile"] = "ToolsGuiButtonProfile";
            oc_Newobject3["horizSizing"] = "left";
            oc_Newobject3["vertSizing"] = "bottom";
            oc_Newobject3["position"] = "158 3";
            oc_Newobject3["extent"] = "17 17";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["setFirstResponder"] = "0";
            oc_Newobject3["modal"] = "1";
            oc_Newobject3["command"] = "ManageBookmarksContainer.onOK();";
            oc_Newobject3["bitmap"] = "tools/gui/images/new";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["text"] = "Create";
            oc_Newobject3["tooltip"] = "Create New Camera Bookmark";
            oc_Newobject3["accelerator"] = "return";

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject7["#Newobject4"] = oc_Newobject4;

            #region GuiScrollCtrl ()        oc_Newobject6

            ObjectCreator oc_Newobject6 = new ObjectCreator("GuiScrollCtrl", "");
            oc_Newobject6["canSaveDynamicFields"] = "0";
            oc_Newobject6["Enabled"] = "1";
            oc_Newobject6["isContainer"] = "1";
            oc_Newobject6["Profile"] = "ToolsGuiScrollProfile";
            oc_Newobject6["HorizSizing"] = "width";
            oc_Newobject6["VertSizing"] = "height";
            oc_Newobject6["Position"] = "4 12";
            oc_Newobject6["Extent"] = "300 200";
            oc_Newobject6["MinExtent"] = "8 2";
            oc_Newobject6["canSave"] = "1";
            oc_Newobject6["isDecoy"] = "0";
            oc_Newobject6["Visible"] = "1";
            oc_Newobject6["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject6["hovertime"] = "1000";
            oc_Newobject6["Docking"] = "Client";
            oc_Newobject6["Margin"] = "26 1 3 3";
            oc_Newobject6["Padding"] = "0 0 0 0";
            oc_Newobject6["AnchorTop"] = "1";
            oc_Newobject6["AnchorBottom"] = "0";
            oc_Newobject6["AnchorLeft"] = "1";
            oc_Newobject6["AnchorRight"] = "0";
            oc_Newobject6["willFirstRespond"] = "1";
            oc_Newobject6["hScrollBar"] = "alwaysOff";
            oc_Newobject6["vScrollBar"] = "dynamic";
            oc_Newobject6["lockHorizScroll"] = "true";
            oc_Newobject6["lockVertScroll"] = "false";
            oc_Newobject6["constantThumbHeight"] = "0";
            oc_Newobject6["childMargin"] = "2 2";

            #region GuiStackControl ()        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiStackControl", "");
            oc_Newobject5["internalName"] = "ManageBookmarksWindowStack";
            oc_Newobject5["StackingType"] = "Vertical";
            oc_Newobject5["HorizStacking"] = "Left to Right";
            oc_Newobject5["VertStacking"] = "Top to Bottom";
            oc_Newobject5["Padding"] = "2";
            oc_Newobject5["canSaveDynamicFields"] = "0";
            oc_Newobject5["Enabled"] = "1";
            oc_Newobject5["isContainer"] = "1";
            oc_Newobject5["Profile"] = "ToolsGuiDefaultProfile";
            oc_Newobject5["HorizSizing"] = "width";
            oc_Newobject5["VertSizing"] = "bottom";
            oc_Newobject5["Position"] = "0 0";
            oc_Newobject5["Extent"] = "300 200";
            oc_Newobject5["MinExtent"] = "16 16";
            oc_Newobject5["canSave"] = "1";
            oc_Newobject5["isDecoy"] = "0";
            oc_Newobject5["Visible"] = "1";
            oc_Newobject5["tooltipprofile"] = "ToolsGuiToolTipProfile";
            oc_Newobject5["hovertime"] = "1000";

            #endregion

            oc_Newobject6["#Newobject5"] = oc_Newobject5;

            #endregion

            oc_Newobject7["#Newobject6"] = oc_Newobject6;

            #endregion

            oc_Newobject8["#Newobject7"] = oc_Newobject7;

            #endregion

            oc_Newobject8.Create();
            }
        }
    }