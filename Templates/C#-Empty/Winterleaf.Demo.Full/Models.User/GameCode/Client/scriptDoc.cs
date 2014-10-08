using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class scriptDoc
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true)]
        public static void writeOutFunctions()
            {
            /*
             new ConsoleLogger(logger, "scriptFunctions.txt", false);
   dumpConsoleFunctions();
   logger.delete();
             */
            omni.console.Eval("new ConsoleLogger(logger, \"scriptFunctions.txt\", false);");
            omni.Util.dumpConsoleFunctions(true, true);
            "logger".delete();
            }

        [ConsoleInteraction(true)]
        public static void writeOutClasses()
            {
            /*
                new ConsoleLogger(logger, "scriptClasses.txt", false);
   dumpConsoleClasses();
   logger.delete();
             */
            omni.console.Eval("new ConsoleLogger(logger, \"scriptClasses.txt\", false);");
            omni.Util.dumpConsoleClasses(true, true);
            "logger".delete();
            }
        }
    }