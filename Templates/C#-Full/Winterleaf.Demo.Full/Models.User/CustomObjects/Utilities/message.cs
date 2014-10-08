using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities
    {
    class message
        {
        static int SPAM_PROTECTION_PERIOD = 1000;
        static int SPAM_MESSAGE_THRESHOLD = 4;
        static int SPAM_PENALTY_PERIOD = 10000;
        static private string _SPAM_MESSAGE = "";

        private static pInvokes tst = new pInvokes();

        public static string SPAM_MESSAGE
            {
            get
                {
                if (_SPAM_MESSAGE == "")
                    _SPAM_MESSAGE = tst.console.ColorEncode(@"\c3FLOOD PROTECTION:\cr You must wait another %1 seconds.");
                return _SPAM_MESSAGE;
                }
            }

        static public void MessageTeam(string team, string msgType, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
            {
            foreach (GameConnection clientid in tst.ClientGroup.Where(clientid => ((GameConnection)clientid)["team"] == team))
                MessageClient(clientid, msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
            }

        static public void MessageTeamExcept(GameConnection client, string msgType, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
            {
            string team = client["team"];
            foreach (GameConnection clientid in tst.ClientGroup.Where(clientid => client["team"] == team && (clientid != client)))
                MessageClient(clientid, msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
            }

        static public void MessageAllExcept(string client, string team, string msgtype, string msgstring, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
            {
            foreach (GameConnection recipient in tst.ClientGroup.Where(recipient => ((GameConnection)recipient != client) && ((GameConnection)recipient)["team"] != team))
                MessageClient(recipient, msgtype, msgstring, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
            }

        static public void GameConnectSpamMessageTimeOut(GameConnection thisobj)
            {
            if (thisobj["spamMessageCount"].AsInt() > 0)
                thisobj["spamMessageCount"] = (thisobj["spamMessageCount"].AsInt() - 1).AsString();
            }

        static public void GameConnectionspamReset(GameConnection thisobj)
            {
            thisobj["isSpamming"] = false.AsString();
            }

        static public bool SpamAlert(GameConnection client)
            {
            if (!tst.bGlobal["$Pref::Server::FloodProtectionEnabled"])
                return false;

            if (!client["isSpamming"].AsBool() && client["spamMessageCount"].AsInt() >= SPAM_MESSAGE_THRESHOLD)
                {
                tst.console.error("Client " + client + " is spamming, message count = " + client["spamMessageCount"]);
                client["spamProtectStart"] = tst.console.getSimTime().AsString();
                client["isSpamming"] = true.AsString();
                using (BackgroundWorker bwr_SPAM_PENALTY_PERIOD = new BackgroundWorker())
                    {
                    bwr_SPAM_PENALTY_PERIOD.DoWork += new DoWorkEventHandler(bwr_SPAM_PENALTY_PERIOD_DoWork);
                    bwr_SPAM_PENALTY_PERIOD.RunWorkerAsync(client);
                    }
                }

            if (client["isSpamming"].AsBool())
                {
                double wait = Math.Floor((SPAM_PENALTY_PERIOD - (tst.console.getSimTime() - client["spamProtectStart"].AsDouble()) / 1000));
                MessageClient(client, "", SPAM_MESSAGE, wait.AsString());
                return true;
                }
            client["spamMessageCount"] = (client["spamMessageCount"].AsInt() + 1).AsString();

            using (BackgroundWorker bwrSPAM_PROTECTION_PERIOD = new BackgroundWorker())
                {
                bwrSPAM_PROTECTION_PERIOD.DoWork += new DoWorkEventHandler(bwrSPAM_PROTECTION_PERIOD_DoWork);
                }

            


            return false;
            }

        static void bwrSPAM_PROTECTION_PERIOD_DoWork(object sender, DoWorkEventArgs e)
            {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMilliseconds(SPAM_PROTECTION_PERIOD);
            while (end > start)
                {
                start = DateTime.Now;
                Thread.Sleep(100);
                }
            lock (Omni.self.tick)
                {
                GameConnection thisobj = (GameConnection)e.Argument;
                if (thisobj["spamMessageCount"].AsInt() > 0)
                    thisobj["spamMessageCount"] = (thisobj["spamMessageCount"].AsInt() - 1).AsString();
                }
            }

        static void bwr_SPAM_PENALTY_PERIOD_DoWork(object sender, DoWorkEventArgs e)
            {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMilliseconds(SPAM_PENALTY_PERIOD);
            while (end > start)
                {
                start = DateTime.Now;
                Thread.Sleep(100);
                }
            lock (Omni.self.tick)
                ((GameConnection)e.Argument)["isSpamming"] = false.AsString();

            }

        static public void ChatMessageClient(GameConnection client, GameConnection sender, string voiceTag, string voicePitch, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
            {
            if (tst.console.isObject(client))
                if (!client["muted[" + sender + "]"].AsBool())
                    tst.console.commandToClient(client, "ChatMessage", new string[] { sender, voiceTag, voicePitch, tst.console.addTaggedString(msgString), a1, a2, a3, a4, a5, a6, a7, a8, a9, a10 });
            }

        static public void ChatMessageTeam(GameConnection sender, string team, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
            {
            if ((msgString.Trim().Length == 0) || SpamAlert(sender))
                return;

            foreach (GameConnection obj in tst.ClientGroup.Where(obj => ((GameConnection)obj)["team"] == sender["team"]))
                ChatMessageClient(obj, sender, tst.console.GetVarString(string.Format("{0}.voiceTag", sender)), tst.console.GetVarString(string.Format("{0}.voicePitch", sender)), msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
            }

        static public void ChatMessageAll(GameConnection sender, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
            {
            if ((msgString.Trim().Length == 0) || SpamAlert(sender))
                return;
            foreach (GameConnection obj in tst.ClientGroup)
                {
                if (sender["team"].AsInt() != 0)
                    ChatMessageClient(obj, sender, sender["voiceTag"], sender["voicePitch"], msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);

                else
                    {
                    if (obj["team"] == sender["team"])
                        ChatMessageClient(obj, sender, sender["voiceTag"], sender["voicePitch"], msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
                    }
                }
            }

        static public void MessageClient(GameConnection client, string msgtype, string msgstring, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
            {
            string function = tst.console.addTaggedString("ServerMessage");


            string tmsgtype = "";
            if (msgtype.Length > 0)
                tmsgtype = (byte)msgtype[0] == (byte)1 ? msgtype : tst.console.addTaggedString(msgtype);
            string tmsgstring = "";
            if (msgstring.Length > 0)
                tmsgstring = (byte)msgstring[0] == (byte)1 ? msgstring : tst.console.addTaggedString(msgstring);
            if (tst.console.isObject(client))
                tst.console.commandToClient(client, function, new[] { tmsgtype, tmsgstring, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13 });
            }

        static public void MessageAll(string msgtype, string msgstring, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
            {
            foreach (GameConnection clientid in tst.ClientGroup)
                MessageClient(clientid, msgtype, msgstring, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
            }

        }
    }
