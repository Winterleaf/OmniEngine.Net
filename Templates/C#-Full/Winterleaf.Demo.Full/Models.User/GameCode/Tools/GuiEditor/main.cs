using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor
    {
    public class main
        {
        [ConsoleInteraction]
        public static void initializeGuiEditor()
            {
            GuiEditorGui.initialize();
            GuiEditorNewGuiDialog.initialize();
            GuiEditorPrefsDlg.initialize();
            GuiEditorSelectDlg.initialize();
            EditorChooseGUI.initialize();
            GuiEditorProfiles.initialize();
            GuiEditorContentList.initialize();
            GuiEditorFileDialog.GuiBuilder.initialize();
            ProfilePane.initialize();
            }

        [ConsoleInteraction]
        public static void destroyGuiEditor()
            {
            }
        }
    }