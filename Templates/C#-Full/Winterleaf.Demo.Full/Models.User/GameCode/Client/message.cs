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

using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    //-----------------------------------------------------------------------------
    // Functions that process commands sent from the server.

    // This function is for chat messages only; it is invoked on the client when
    // the server does a commandToClient with the tag ChatMessage.  (Cf. the
    // functions chatMessage* in core/scripts/server/message.cs.)

    // This just invokes onChatMessage, which the mod code must define.
    public class message
    {
        // Game event descriptions, which may or may not include text messages, can be
        // sent using the message* functions in core/scripts/server/message.cs.  Those
        // functions do commandToClient with the tag ServerMessage, which invokes the
        // function below.

        // For ServerMessage messages, the client can install callbacks that will be
        // run, according to the "type" of the message.
        [ConsoleInteraction(true)]
        public static void clientCmdChatMessage(string sender, string voice, string pitch, string msgString, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
        {
            chatHud.OnChatMessage(pInvokes.Util.detag(msgString), voice, pitch);
        }

        // Called by the client to install a callback for a particular type of
        // ServerMessage.
        [ConsoleInteraction(true)]
        public static void clientCmdServerMessage(string msgType, string msgString, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
        {
            string tag = msgType.Split(' ')[0].Trim();
            string funct;

            int i = 0;
            funct = pInvokes.console.GetVarString(@"$MSGCB["""", " + i.AsString() + "]");
            while (funct != "")
                {
                pInvokes.console.Call(funct, new[] {msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});
                i++;
                funct = pInvokes.console.GetVarString(@"$MSGCB["""", " + i.AsString() + "]");
                }

            // Next look for a callback for this particular type of ServerMessage.
            if (tag == "")
                return;
            i = 0;
            funct = pInvokes.console.GetVarString(@"$MSGCB[""" + tag + @""", " + i.AsString() + "]");
            while (funct != "")
                {
                pInvokes.console.Call(funct, new[] {msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});
                i++;
                funct = pInvokes.console.GetVarString(@"$MSGCB[""" + tag + @""", " + i.AsString() + "]");
                }
        }

        // The following is the callback that will be executed for every ServerMessage,
        // because we're going to install it without a specified type.  Any type-
        // specific callbacks will be executed afterward.

        // This just invokes onServerMessage, which can be overridden by the game
        //static internal void OnServerMessage(string a, string b = "", string c = "", string d = "", string e = "", string f = "", string g = "", string h = "", string i = "")
        //    {
        //    pInvokes.console.print("onServerMessage: ");
        //    if (a != "") pInvokes.console.print("  +- a: " + a);
        //    if (b != "") pInvokes.console.print("  +- b: " + b);
        //    if (c != "") pInvokes.console.print("  +- c: " + c);
        //    if (d != "") pInvokes.console.print("  +- d: " + d);
        //    if (e != "") pInvokes.console.print("  +- e: " + e);
        //    if (f != "") pInvokes.console.print("  +- f: " + f);
        //    if (g != "") pInvokes.console.print("  +- g: " + g);
        //    if (h != "") pInvokes.console.print("  +- h: " + h);
        //    if (i != "") pInvokes.console.print("  +- i: " + i);
        //    }

        [ConsoleInteraction(true)]
        public static void addMessageCallback(string msgType, string func)
        {
            //For some reason, when the msgType is "" it makes it " "... somewheres it must
            //be appending an empty space to the string, just no clue whear.
            //msgType = msgType.Trim();
            string afunc = "";
            int i = 0;
            afunc = pInvokes.console.GetVarString("$MSGCB[\"" + msgType + "\", " + i.AsString() + "]");
            while (afunc != "")
                {
                if (afunc == func)
                    return;
                i++;
                afunc = pInvokes.console.GetVarString("$MSGCB[\"" + msgType + "\", " + i.AsString() + "]");
                }
            pInvokes.console.SetVar("$MSGCB[\"" + msgType + "\", " + i.AsString() + "]", func);
        }

        [ConsoleInteraction(true)]
        public static void defaultMessageCallback(string msgType, string msgString, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
        {
            chatHud.OnServerMessage(pInvokes.Util.detag(msgString));
        }

        public static void initialize()
        {
            addMessageCallback("", "defaultMessageCallback");
        }
    }
}
