using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

namespace WinterLeaf.Demo.Full.Models.User.GameCode
    {
    public class commands
        {
        // Sync the Camera and the EditorGui
        [ConsoleInteraction(true)]
        public static void clientCmdSyncEditorGui()
            {
            EditorGui EditorGui = "EditorGui";

            if (EditorGui.isObject())
                EditorGui.syncCameraGui();
            }
        }
    }