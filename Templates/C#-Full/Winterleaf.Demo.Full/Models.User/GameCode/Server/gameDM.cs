using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Game;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    class gameDM : gameBase
        {
        public static pInvokes omni = new pInvokes();

        //To extend the base game functionality override the functions here.
        public override void onMissionLoaded()
            {
            base.onMissionLoaded();
            console.print("##Mission Loaded###");
            }

        public override void startGame()
            {
            base.startGame();
            console.print("###Game Started###");
            }


        [ConsoleInteraction(true)]
        public static void sendMsgClientKilled_Impact(string msgtype, GameConnection client, GameConnection sourceclient, string damloc)
            {
            if (client.isObject())

                message.MessageAll(msgtype, "%1 fell to his death!", client["playerName"]);
            // console.GetVarString(string.Format("{0}.playerName", client)));
            }

        [ConsoleInteraction(true)]
        public static void sendMsgClientKilled_Suicide(string msgtype, GameConnection client, GameConnection sourceclient, string damloc)
            {
            if (client.isObject())

                message.MessageAll(msgtype, "%1 takes his own life!", client["playerName"]);
            }

        [ConsoleInteraction(true)]
        public static void sendMsgClientKilled_Default(string msgtype, GameConnection client, GameConnection sourceclient, string damloc)
            {
            if (!client.isObject())
                return;
            if (sourceclient == client)
                sendMsgClientKilled_Suicide(msgtype, client, sourceclient, damloc);

            else if (omni.console.GetVarString(sourceclient["team"]) != string.Empty &&
                     sourceclient["team"] != client["team"])
                message.MessageAll(msgtype, "%1 killed by %2 - friendly fire!",
                    client["playerName"], sourceclient["playerName"]);
            else
                {
                message.MessageAll(msgtype, "%1 gets nailed by %2!", client["playerName"],
                    sourceclient.isObject() ? sourceclient["playerName"] : "a Bot!");
                }
            }
        }
    }
