using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui.gui;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui
    {
    public class guiDialogs
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            //omni.Util.exec("tools/gui/fileDialogBase.ed.cs",false,false);
            MessageBoxSaveChangesDlg.initialize();
            simViewDlg.initialize();
            ColorPickerDlg.initialize();
            MaterialSelector.initialize();
            ScriptEditorDlg.initialize();
            ColladaImportDlg.initialize();
            EditorLoadingGui.initialize();
            GuiEaseEditDlg.initialize();
            GuiObjectInspector.initialize();
            UVEditorOverlay.initialize();
            }
        }
    }