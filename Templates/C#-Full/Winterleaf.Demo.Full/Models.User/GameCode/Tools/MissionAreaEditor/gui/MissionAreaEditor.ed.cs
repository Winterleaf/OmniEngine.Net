using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.MissionAreaEditor.gui
    {
    public class MissionAreaEditor
        {
        [ConsoleInteraction(true, "MissionAreaEditor_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile ( MissionAreaEditorProfile )        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile", "MissionAreaEditorProfile");
            oc_Newobject1["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["opaque"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["fillColor"] = "192 192 192";
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();
            }
        }
    }