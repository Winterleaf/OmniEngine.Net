using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.Panels;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses.RSSNews;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.EditorClasses
    {
    public class main
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void initializeEditorClasses()
            {
            Omni.self.Print(" % - Initializing Tools Base");
            omni.sGlobal["$EditorClassesGroup"] = "EditorClassesCleanup";

            if (!omni.sGlobal["$EditorClassesGroup"].isObject())
                new ObjectCreator("SimGroup", omni.sGlobal["$EditorClassesGroup"]).Create();

            RSSFeedScript.initialize();

            //loadDirectory( expandFilename("./scripts/core") );
            //loadDirectory( expandFilename("./scripts/platform") );
            }

        [ConsoleInteraction]
        public static void destroyEditorClasses()
            {
            }
        }
    }