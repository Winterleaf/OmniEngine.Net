using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.RiverEditor.gui
    {
    public class RiverEditor
        {
        [ConsoleInteraction(true, "RiverEditor_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile ( RiverEditorProfile )        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile", "RiverEditorProfile");
            oc_Newobject1["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["fillColor"] = "192 192 192 192";
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();

            #region GuiControlProfile  (GuiSimpleBorderProfile)        oc_Newobject2

            SingletonCreator oc_Newobject2 = new SingletonCreator("GuiControlProfile ", "GuiSimpleBorderProfile");
            oc_Newobject2["opaque"] = new ObjectCreator.StringNoQuote("false");
            oc_Newobject2["border"] = new ObjectCreator.StringNoQuote("1");
            oc_Newobject2["category"] = "Editor";

            #endregion

            oc_Newobject2.Create();
            }
        }
    }