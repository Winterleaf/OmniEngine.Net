using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor.gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.InGameEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeInGameEditor()
            {
            Omni.self.Print(" % - Initializing In-game GUI Editor");
            SetTitle.initialize();
            WindowSettings.initialize();
            ChangeFontSize.initialize();
            ObjectCreator oIngameContext = new ObjectCreator("GuiControl", "IngameContext, IngameGuiGroup",
                typeof (gui.CodeBehind.InGameContext));
            oIngameContext.Create();
            }

        [ConsoleInteraction]
        public static void destroyInGameEditor()
            {
            }
        }
    }