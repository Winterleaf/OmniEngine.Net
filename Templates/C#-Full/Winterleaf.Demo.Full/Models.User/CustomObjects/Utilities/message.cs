// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
//
// All rights reserved.
//
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
//
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
//
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
//
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
//
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
//
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities
{
    internal class message
    {
        private static int SPAM_PROTECTION_PERIOD = 1000;
        private static int SPAM_MESSAGE_THRESHOLD = 4;
        private static int SPAM_PENALTY_PERIOD = 10000;
        private static string _SPAM_MESSAGE = "";

        public static string SPAM_MESSAGE
        {
            get
            {
                if (_SPAM_MESSAGE == "")
                    _SPAM_MESSAGE = pInvokes.console.ColorEncode(@"\c3FLOOD PROTECTION:\cr You must wait another %1 seconds.");
                return _SPAM_MESSAGE;
            }
        }

        public static void MessageTeam(string team, string msgType, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
        {
            foreach (GameConnection clientid in pInvokes.ClientGroup.Where(clientid => ((GameConnection) clientid)["team"] == team))
                MessageClient(clientid, msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
        }

        public static void MessageTeamExcept(GameConnection client, string msgType, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
        {
            string team = client["team"];
            foreach (GameConnection clientid in pInvokes.ClientGroup.Where(clientid => client["team"] == team && (clientid != client)))
                MessageClient(clientid, msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
        }

        public static void MessageAllExcept(string client, string team, string msgtype, string msgstring, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
        {
            foreach (GameConnection recipient in pInvokes.ClientGroup.Where(recipient => ((GameConnection) recipient != client) && ((GameConnection) recipient)["team"] != team))
                MessageClient(recipient, msgtype, msgstring, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
        }

        public static void GameConnectSpamMessageTimeOut(GameConnection thisobj)
        {
            if (thisobj["spamMessageCount"].AsInt() > 0)
                thisobj["spamMessageCount"] = (thisobj["spamMessageCount"].AsInt() - 1).AsString();
        }

        public static void GameConnectionspamReset(GameConnection thisobj)
        {
            thisobj["isSpamming"] = false.AsString();
        }

        public static bool SpamAlert(GameConnection client)
        {
            if (!pInvokes.bGlobal["$Pref::Server::FloodProtectionEnabled"])
                return false;

            if (!client["isSpamming"].AsBool() && client["spamMessageCount"].AsInt() >= SPAM_MESSAGE_THRESHOLD)
                {
                pInvokes.console.error("Client " + client + " is spamming, message count = " + client["spamMessageCount"]);
                client["spamProtectStart"] = pInvokes.console.getSimTime().AsString();
                client["isSpamming"] = true.AsString();
                using (BackgroundWorker bwr_SPAM_PENALTY_PERIOD = new BackgroundWorker())
                    {
                    bwr_SPAM_PENALTY_PERIOD.DoWork += new DoWorkEventHandler(bwr_SPAM_PENALTY_PERIOD_DoWork);
                    bwr_SPAM_PENALTY_PERIOD.RunWorkerAsync(client);
                    }
                }

            if (client["isSpamming"].AsBool())
                {
                double wait = Math.Floor((SPAM_PENALTY_PERIOD - (pInvokes.console.getSimTime() - client["spamProtectStart"].AsDouble())/1000));
                MessageClient(client, "", SPAM_MESSAGE, wait.AsString());
                return true;
                }
            client["spamMessageCount"] = (client["spamMessageCount"].AsInt() + 1).AsString();

            using (BackgroundWorker bwrSPAM_PROTECTION_PERIOD = new BackgroundWorker())
                bwrSPAM_PROTECTION_PERIOD.DoWork += new DoWorkEventHandler(bwrSPAM_PROTECTION_PERIOD_DoWork);

            return false;
        }

        private static void bwrSPAM_PROTECTION_PERIOD_DoWork(object sender, DoWorkEventArgs e)
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
                GameConnection thisobj = (GameConnection) e.Argument;
                if (thisobj["spamMessageCount"].AsInt() > 0)
                    thisobj["spamMessageCount"] = (thisobj["spamMessageCount"].AsInt() - 1).AsString();
                }
        }

        private static void bwr_SPAM_PENALTY_PERIOD_DoWork(object sender, DoWorkEventArgs e)
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMilliseconds(SPAM_PENALTY_PERIOD);
            while (end > start)
                {
                start = DateTime.Now;
                Thread.Sleep(100);
                }
            lock (Omni.self.tick)
                ((GameConnection) e.Argument)["isSpamming"] = false.AsString();
        }

        public static void ChatMessageClient(GameConnection client, GameConnection sender, string voiceTag, string voicePitch, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
        {
            if (pInvokes.console.isObject(client))
                {
                if (!client["muted[" + sender + "]"].AsBool())
                    pInvokes.console.commandToClient(client, "ChatMessage", new string[] {sender, voiceTag, voicePitch, pInvokes.console.addTaggedString(msgString), a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});
                }
        }

        public static void ChatMessageTeam(GameConnection sender, string team, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
        {
            if ((msgString.Trim().Length == 0) || SpamAlert(sender))
                return;

            foreach (GameConnection obj in pInvokes.ClientGroup.Where(obj => ((GameConnection) obj)["team"] == sender["team"]))
                ChatMessageClient(obj, sender, pInvokes.console.GetVarString(string.Format("{0}.voiceTag", sender)), pInvokes.console.GetVarString(string.Format("{0}.voicePitch", sender)), msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10);
        }

        public static void ChatMessageAll(GameConnection sender, string msgString, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "")
        {
            if ((msgString.Trim().Length == 0) || SpamAlert(sender))
                return;
            foreach (GameConnection obj in pInvokes.ClientGroup)
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

        public static void MessageClient(GameConnection client, string msgtype, string msgstring, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
        {
            string function = pInvokes.console.addTaggedString("ServerMessage");

            string tmsgtype = "";
            if (msgtype.Length > 0)
                tmsgtype = (byte) msgtype[0] == (byte) 1 ? msgtype : pInvokes.console.addTaggedString(msgtype);
            string tmsgstring = "";
            if (msgstring.Length > 0)
                tmsgstring = (byte) msgstring[0] == (byte) 1 ? msgstring : pInvokes.console.addTaggedString(msgstring);
            if (pInvokes.console.isObject(client))
                pInvokes.console.commandToClient(client, function, new[] {tmsgtype, tmsgstring, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13});
        }

        public static void MessageAll(string msgtype, string msgstring, string a1 = "", string a2 = "", string a3 = "", string a4 = "", string a5 = "", string a6 = "", string a7 = "", string a8 = "", string a9 = "", string a10 = "", string a11 = "", string a12 = "", string a13 = "")
        {
            foreach (GameConnection clientid in pInvokes.ClientGroup)
                MessageClient(clientid, msgtype, msgstring, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13);
        }

    }
}
