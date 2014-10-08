using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor
    {
    public class MiscFuncts
        {
        [ConsoleInteraction]
        public static void EPainter_TerrainMaterialUpdateCallback(TerrainMaterial mat, int matIndex)
            {
            if (matIndex == -1 || !mat.isObject())
                return;

            // Update the material and the UI.

            ((TerrainEditor) "ETerrainEditor").updateMaterial((uint)matIndex, mat.getInternalName());
            ((TerrainPainter) "TerrainPainter").setup(matIndex);
            }

        [ConsoleInteraction]
        public static void EPainter_TerrainMaterialAddCallback(TerrainMaterial mat, int matIndex)
            {
            if (!mat.isObject())
                return;

            ((TerrainEditor) "ETerrainEditor").addMaterial(mat.getInternalName());
            ((TerrainPainter) "TerrainPainter").setup(matIndex);
            }

        [ConsoleInteraction]
        public static void onNeedRelight()
            {
            GuiControl RelightMessage = "RelightMessage";
            if (RelightMessage.visible == false)
                RelightMessage.visible = true;
            }

        [ConsoleInteraction]
        public static string getPrefSetting(string pref, string sdefault)
            {
            if (pref == "")
                return sdefault;
            else
                return pref;
            }
        }
    }