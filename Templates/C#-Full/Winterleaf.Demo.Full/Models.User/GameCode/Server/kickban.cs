#region

using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class kickban
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction(true)]
        public static void Kick(GameConnection client)
            {
            message.MessageAll("MsgAdminForce", omni.console.ColorEncode(@"\c2The Admin has kicked %1."),
                client["playerName"]);
            if (!client.isAIControlled())
                omni.console.Call_Classname("BanList", "add",
                    new[] {client["guid"], client.getAddress(), omni.sGlobal["$Pref::Server::KickBanTime"]});
            client.delete("You have been kicked from this server");
            }

        [ConsoleInteraction(true)]
        public static void Ban(GameConnection client)
            {
            message.MessageAll("MsgAdminForce", omni.console.ColorEncode(@"\c2The Admin has banned %1."),
                client["playerName"]);
            if (!client.isAIControlled())
                omni.console.Call_Classname("BanList", "add",
                    new[] {client["guid"], client.getAddress(), omni.sGlobal["$Pref::Server::BanTime"]});
            client.delete("You have been banned from this server");
            }
        }
    }