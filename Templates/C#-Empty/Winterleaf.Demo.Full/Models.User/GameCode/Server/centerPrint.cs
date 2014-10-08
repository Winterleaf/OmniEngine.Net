#region

using System.Linq;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class centerPrint
        {
        public static pInvokes t3d = new pInvokes();

        [ConsoleInteraction(true)]
        public static void CenterPrintAll(string message, string time, string lines)
            {
            if (lines == "" || lines.AsInt() > 3 || lines.AsInt() < 1)
                lines = "1";

            foreach (
                GameConnection client in
                    t3d.ClientGroup.Where(client => !((GameConnection) client).isAIControlled()))
                t3d.console.commandToClient(client, "centerPrint", new[] {message, time, lines});
            }

        [ConsoleInteraction(true)]
        public static void BottomPrintAll(string message, string time, string lines)
            {
            if (lines == "" || lines.AsInt() > 3 || lines.AsInt() < 1)
                lines = "1";
            foreach (
                GameConnection client in
                    t3d.ClientGroup.Where(client => !((GameConnection) client).isAIControlled()))
                t3d.console.commandToClient(client, "bottomPrint", new[] {message, time, lines});
            }

        [ConsoleInteraction(true)]
        public static void CenterPrint(GameConnection client, string message, string time, string lines)
            {
            if (lines == "" || lines.AsInt() > 3 || lines.AsInt() < 1)
                lines = "1";

            t3d.console.commandToClient(client, "centerPrint", new[] {message, time, lines});
            }

        [ConsoleInteraction(true)]
        public static void BottomPrint(GameConnection client, string message, string time, string lines)
            {
            if (lines == "" || lines.AsInt() > 3 || lines.AsInt() < 1)
                lines = "1";

            t3d.console.commandToClient(client, "bottomPrint", new[] {message, time, lines});
            }

        [ConsoleInteraction(true)]
        public static void ClearCenterPrint(GameConnection client)
            {
            t3d.console.commandToClient(client, "ClearCenterPrint");
            }

        [ConsoleInteraction(true)]
        public static void ClearBottomPrint(GameConnection client)
            {
            t3d.console.commandToClient(client, "clearBottomPrint");
            }

        [ConsoleInteraction(true)]
        public static void ClearCenterPrintAll()
            {
            SimSet ClientGroup = "ClientGroup";
            int count = ClientGroup.getCount();
            for (uint i = 0; i < count; i++)
                {
                GameConnection cl = ClientGroup.getObject(i);
                if (!cl.isAIControlled())
                    t3d.console.commandToClient(cl, "ClearCenterPrint");
                }
            //foreach (uint client in t3d.ClientGroup.Cast<GameConnection>().Where(client => !client.isAIControlled()))
            //   t3d.console.commandToClient(client.AsString(), "ClearCenterPrint");
            }

        [ConsoleInteraction(true)]
        public static void ClearBottomPrintAll()
            {
            SimSet ClientGroup = "ClientGroup";
            int count = ClientGroup.getCount();
            for (uint i = 0; i < count; i++)
                {
                GameConnection cl = ClientGroup.getObject(i);
                if (!cl.isAIControlled())
                    t3d.console.commandToClient(cl, "ClearBottomPrint");
                }
            //foreach (uint client in t3d.ClientGroup.Cast<GameConnection>().Where(client => !client.isAIControlled()))
            //    t3d.console.commandToClient(client.AsString(), "clearBottomPrint");
            }
        }
    }