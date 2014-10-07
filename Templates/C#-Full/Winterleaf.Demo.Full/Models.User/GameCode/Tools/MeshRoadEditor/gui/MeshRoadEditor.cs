using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MeshRoadEditor.gui
    {
    public class MeshRoadEditor
        {
        [ConsoleInteraction(true, "MeshRoadEditor_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile ( MeshRoadEditorProfile )        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile", "MeshRoadEditorProfile");
            oc_Newobject1["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["fillColor"] = "192 192 192 192";
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (GuiDisabledTextEditProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "GuiDisabledTextEditProfile");
            oc_Newobject2["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["border"] = new ObjectCreator.StringNoQuote("0");
            oc_Newobject2["bitmap"] = "tools/gui/images/textEdit";
            oc_Newobject2["borderColor"] = "255 255 255 200";
            oc_Newobject2["fontColor"] = "0 0 0";
            oc_Newobject2["fontColorHL"] = "255 255 255";
            oc_Newobject2["fontColorNA"] = "128 128 128";
            oc_Newobject2["textOffset"] = "4 2";
            oc_Newobject2["autoSizeWidth"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["autoSizeHeight"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["tab"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["canKeyFocus"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();

            #region GuiControlProfile  (GuiSimpleBorderProfile)        oc_Newobject3

            SingletonCreator oc_Newobject3 = new SingletonCreator("GuiControlProfile ", "GuiSimpleBorderProfile");
            oc_Newobject3["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject3["border"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject3["category"] = "Editor";

            #endregion

            oc_Newobject3.Create();
            }
        }
    }