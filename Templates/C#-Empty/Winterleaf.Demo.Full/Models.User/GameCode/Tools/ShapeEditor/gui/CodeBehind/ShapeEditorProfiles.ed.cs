using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ShapeEditor.gui.CodeBehind
    {
    public class ShapeEditorProfiles
        {
        [ConsoleInteraction(true, "ShapeEditorProfiles_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile (GuiShapeEdScrollProfile : GuiEditorScrollProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile",
                "GuiShapeEdScrollProfile : GuiEditorScrollProfile");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile (GuiShapeEdTextListProfile : ToolsGuiTextListProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile",
                "GuiShapeEdTextListProfile : ToolsGuiTextListProfile");
            oc_Newobject2["fontColorNA"] = "75 75 75";
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile (GuiShapeEdRolloutProfile : GuiInspectorRolloutProfile0)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile",
                "GuiShapeEdRolloutProfile : GuiInspectorRolloutProfile0");
            oc_Newobject3["bitmap"] = "tools/editorclasses/gui/images/rollout";
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();

            #region GuiControlProfile ( GuiShapeEdTransitionSliderProfile )        oc_Newobject4

            SingletonCreator oc_Newobject4 = new SingletonCreator("GuiControlProfile",
                "GuiShapeEdTransitionSliderProfile");
            oc_Newobject4["bitmap"] = "tools/shapeEditor/images/transition_slider";
            oc_Newobject4["category"] = "Core";

            #endregion

            oc_Newobject4.Create();
            }
        }
    }