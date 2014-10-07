using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.ForestEditor.gui
    {
    public class ForestEditor
        {
        [ConsoleInteraction(true, "ForestEditor_initialize")]
        public static void initialize()
            {
            #region GuiControlProfile  (ForestEditorProfile)        oc_Newobject1

            SingletonCreator oc_Newobject1 = new SingletonCreator("GuiControlProfile ", "ForestEditorProfile");
            oc_Newobject1["canKeyFocus"] = new ObjectCreator.StringNoQuote("true");
            oc_Newobject1["category"] = "Editor";

            #endregion

            oc_Newobject1.Create();
            }
        }
    }