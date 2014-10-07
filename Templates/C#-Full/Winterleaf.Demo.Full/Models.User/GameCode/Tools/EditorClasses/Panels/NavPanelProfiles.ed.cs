using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.Panels
    {
    public class NavPanelProfiles
        {
        [ConsoleInteraction(true, "NavPanelProfiles_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile  (NavPanelProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile ", "NavPanelProfile");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject1["border"] = new ObjectCreator.StringNoQuote("-2");
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (NavPanel : NavPanelProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "NavPanel : NavPanelProfile");
            oc_Newobject2["bitmap"] = "tools/editorClasses/gui/panels/navPanel";
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile  (NavPanelBlue : NavPanelProfile)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile ", "NavPanelBlue : NavPanelProfile");
            oc_Newobject3["bitmap"] = "tools/editorClasses/gui/panels/navPanel_blue";
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiControlProfile  (NavPanelGreen : NavPanelProfile)        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiControlProfile ",
                "NavPanelGreen : NavPanelProfile");
            oc_Newobject4["bitmap"] = "tools/editorClasses/gui/panels/navPanel_green";
            oc_Newobject4["category"] = "Editor";

            #endregion

            oc_Newobject4.Create();

            #region GuiControlProfile  (NavPanelRed : NavPanelProfile)        oc_Newobject5

            SingletonCreator oc_Newobject5 = new SingletonCreator("GuiControlProfile ", "NavPanelRed : NavPanelProfile");
            oc_Newobject5["bitmap"] = "tools/editorClasses/gui/panels/navPanel_red";
            oc_Newobject5["category"] = "Editor";

            #endregion

            oc_Newobject5.Create();

            #region GuiControlProfile  (NavPanelWhite : NavPanelProfile)        oc_Newobject6

            SingletonCreator oc_Newobject6 = new SingletonCreator("GuiControlProfile ",
                "NavPanelWhite : NavPanelProfile");
            oc_Newobject6["bitmap"] = "tools/editorClasses/gui/panels/navPanel_white";
            oc_Newobject6["category"] = "Editor";

            #endregion

            oc_Newobject6.Create();

            #region GuiControlProfile  (NavPanelYellow : NavPanelProfile)        oc_Newobject7

            SingletonCreator oc_Newobject7 = new SingletonCreator("GuiControlProfile ",
                "NavPanelYellow : NavPanelProfile");
            oc_Newobject7["bitmap"] = "tools/editorClasses/gui/panels/navPanel_yellow";
            oc_Newobject7["category"] = "Editor";

            #endregion

            oc_Newobject7.Create();

            #region GuiControlProfile  (menubarProfile : NavPanelProfile)        oc_Newobject8

            SingletonCreator oc_Newobject8 = new SingletonCreator("GuiControlProfile ",
                "menubarProfile : NavPanelProfile");
            oc_Newobject8["bitmap"] = "tools/editorClasses/gui/panels/menubar";
            oc_Newobject8["category"] = "Editor";

            #endregion

            oc_Newobject8.Create();

            #region GuiControlProfile  (editorMenubarProfile : NavPanelProfile)        oc_Newobject9

            SingletonCreator oc_Newobject9 = new SingletonCreator("GuiControlProfile ",
                "editorMenubarProfile : NavPanelProfile");
            oc_Newobject9["bitmap"] = "tools/editorClasses/gui/panels/editor-menubar";
            oc_Newobject9["category"] = "Editor";

            #endregion

            oc_Newobject9.Create();

            #region GuiControlProfile  (editorMenu_wBorderProfile : NavPanelProfile)        oc_Newobject10

            SingletonCreator oc_Newobject10 = new SingletonCreator("GuiControlProfile ",
                "editorMenu_wBorderProfile : NavPanelProfile");
            oc_Newobject10["bitmap"] = "tools/editorClasses/gui/panels/menu-fullborder";
            oc_Newobject10["category"] = "Editor";

            #endregion

            oc_Newobject10.Create();

            #region GuiControlProfile  (inspectorStyleRolloutProfile : NavPanelProfile)        oc_Newobject11

            SingletonCreator oc_Newobject11 = new SingletonCreator("GuiControlProfile ",
                "inspectorStyleRolloutProfile : NavPanelProfile");
            oc_Newobject11["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout";
            oc_Newobject11["category"] = "Editor";

            #endregion

            oc_Newobject11.Create();

            #region GuiControlProfile  (inspectorStyleRolloutListProfile : NavPanelProfile)        oc_Newobject12

            SingletonCreator oc_Newobject12 = new SingletonCreator("GuiControlProfile ",
                "inspectorStyleRolloutListProfile : NavPanelProfile");
            oc_Newobject12["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout-list";
            oc_Newobject12["category"] = "Editor";

            #endregion

            oc_Newobject12.Create();

            #region GuiControlProfile  (inspectorStyleRolloutDarkProfile : NavPanelProfile)        oc_Newobject13

            SingletonCreator oc_Newobject13 = new SingletonCreator("GuiControlProfile ",
                "inspectorStyleRolloutDarkProfile : NavPanelProfile");
            oc_Newobject13["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout-dark";
            oc_Newobject13["category"] = "Editor";

            #endregion

            oc_Newobject13.Create();

            #region GuiControlProfile  (inspectorStyleRolloutInnerProfile : NavPanelProfile)        oc_Newobject14

            SingletonCreator oc_Newobject14 = new SingletonCreator("GuiControlProfile ",
                "inspectorStyleRolloutInnerProfile : NavPanelProfile");
            oc_Newobject14["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout_inner";
            oc_Newobject14["category"] = "Editor";

            #endregion

            oc_Newobject14.Create();

            #region GuiControlProfile  (inspectorStyleRolloutNoHeaderProfile : NavPanelProfile)        oc_Newobject15

            SingletonCreator oc_Newobject15 = new SingletonCreator("GuiControlProfile ",
                "inspectorStyleRolloutNoHeaderProfile : NavPanelProfile");
            oc_Newobject15["bitmap"] = "tools/editorClasses/gui/panels/inspector-style-rollout-noheader";
            oc_Newobject15["category"] = "Editor";

            #endregion

            oc_Newobject15.Create();

            #region GuiControlProfile  (IconDropdownProfile : NavPanelProfile)        oc_Newobject16

            SingletonCreator oc_Newobject16 = new SingletonCreator("GuiControlProfile ",
                "IconDropdownProfile : NavPanelProfile");
            oc_Newobject16["bitmap"] = "tools/editorClasses/gui/panels/icon-dropdownbar";
            oc_Newobject16["category"] = "Editor";

            #endregion

            oc_Newobject16.Create();
            }
        }
    }