using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind.EditorChooseLevelGui.ed.cs
    {
    public class staticFunctions
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void WE_EditLevel(string levelFile)
            {
            omni.Util._call("EditorOpenMission", levelFile);
            }

        [ConsoleInteraction]
        public static void WE_ReturnToMainMenu()
            {
            omni.Util._call("loadMainMenu");
            }

        [ConsoleInteraction]
        public static string getLevelDisplayName(string levelFile)
            {
            ObjectCreator oc = new ObjectCreator("FileObject");

            FileObject file = oc.Create();

            string MissionInfoObject = "";

            if (file.openForRead(levelFile))
                {
                bool inInfoBlock = false;
                while (!file.isEOF())
                    {
                    string line = file.readLine();
                    line = line.Trim();

                    if (line == "new ScriptObject(MissionInfo) {")
                        inInfoBlock = true;
                    else if (line == "new LevelInfo(theLevelInfo) {")
                        inInfoBlock = true;
                    else if (inInfoBlock && line == "};")
                        {
                        inInfoBlock = false;
                        MissionInfoObject = MissionInfoObject + line;
                        break;
                        }

                    if (inInfoBlock)
                        MissionInfoObject = MissionInfoObject + line + " ";
                    }
                file.close();
                }
            MissionInfoObject = "%MissionInfoObject = " + MissionInfoObject + "; return %MissionInfoObject;";
            MissionInfoObject = omni.console.Eval(MissionInfoObject, true);

            file.delete();
            string name = "";
            if (((SimObject) MissionInfoObject)["LevelName"] != "")
                name = ((SimObject) MissionInfoObject)["LevelName"];
            else
                name = omni.Util.fileBase(levelFile);

            MissionInfoObject.delete();

            return name;
            }
        }
    }