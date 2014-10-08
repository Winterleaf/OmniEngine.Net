using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger
    {
    public class main
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void initializeDebugger()
            {
            Omni.self.Print(" % - Initializing Debugger");

            // Load the scripts.
            // And the guis.
            DebuggerBreakConditionDlg.initialize();
            DebuggerConnectDlg.initialize();
            DebuggerEditWatchDlg.initialize();
            DebuggerFindDlg.initialize();
            DebuggerGui.initialize();
            DebuggerWatchDlg.initialize();
            }

        [ConsoleInteraction]
        public static void destroyDebugger()
            {
            }

        [ConsoleInteraction]
        public static void startDebugger()
            {
            // Clean up first.
            destroyDebugger();
            new ObjectCreator("TCPObject", "TCPDebugger",
                typeof (WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui.CodeBehind.Debugger.TCPDebugger))
                .Create();


            // Used to get unique IDs for breakpoints and watch expressions.
            omni.iGlobal["$DbgBreakId"] = 0;
            omni.iGlobal["$DbgWatchSeq"] = 1;


            // Set up the GUI.
            WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui.CodeBehind.Debugger.DebuggerConsoleView
                DebuggerConsoleView = "DebuggerConsoleView";
            DebuggerConsoleView.setActive(false);

            ((GuiCanvas) "Canvas").pushDialog("DebuggerGui");
            }
        }
    }