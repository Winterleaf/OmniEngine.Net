using WinterLeaf.Engine.Classes;
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
        private static readonly pInvokes omni = new pInvokes();

        // Game event descriptions, which may or may not include text messages, can be
        // sent using the message* functions in core/scripts/server/message.cs.  Those
        // functions do commandToClient with the tag ServerMessage, which invokes the
        // function below.

        // For ServerMessage messages, the client can install callbacks that will be
        // run, according to the "type" of the message.
        [ConsoleInteraction(true)]
        public static void clientCmdChatMessage(string sender, string voice, string pitch, string msgString, string a1,
            string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
            {
            chatHud.OnChatMessage(omni.Util.detag(msgString), voice, pitch);
            }

        // Called by the client to install a callback for a particular type of
        // ServerMessage.
        [ConsoleInteraction(true)]
        public static void clientCmdServerMessage(string msgType, string msgString, string a1, string a2, string a3,
            string a4, string a5, string a6, string a7, string a8, string a9, string a10)
            {
            string tag = msgType.Split(' ')[0].Trim();
            string funct;

            int i = 0;
            funct = omni.console.GetVarString(@"$MSGCB["""", " + i.AsString() + "]");
            while (funct != "")
                {
                omni.console.Call(funct, new[] {msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});
                i++;
                funct = omni.console.GetVarString(@"$MSGCB["""", " + i.AsString() + "]");
                }

            // Next look for a callback for this particular type of ServerMessage.
            if (tag == "")
                return;
            i = 0;
            funct = omni.console.GetVarString(@"$MSGCB[""" + tag + @""", " + i.AsString() + "]");
            while (funct != "")
                {
                omni.console.Call(funct, new[] {msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});
                i++;
                funct = omni.console.GetVarString(@"$MSGCB[""" + tag + @""", " + i.AsString() + "]");
                }
            }

        // The following is the callback that will be executed for every ServerMessage,
        // because we're going to install it without a specified type.  Any type-
        // specific callbacks will be executed afterward.

        // This just invokes onServerMessage, which can be overridden by the game
        //static internal void OnServerMessage(string a, string b = "", string c = "", string d = "", string e = "", string f = "", string g = "", string h = "", string i = "")
        //    {
        //    omni.console.print("onServerMessage: ");
        //    if (a != "") omni.console.print("  +- a: " + a);
        //    if (b != "") omni.console.print("  +- b: " + b);
        //    if (c != "") omni.console.print("  +- c: " + c);
        //    if (d != "") omni.console.print("  +- d: " + d);
        //    if (e != "") omni.console.print("  +- e: " + e);
        //    if (f != "") omni.console.print("  +- f: " + f);
        //    if (g != "") omni.console.print("  +- g: " + g);
        //    if (h != "") omni.console.print("  +- h: " + h);
        //    if (i != "") omni.console.print("  +- i: " + i);
        //    }

        [ConsoleInteraction(true)]
        public static void addMessageCallback(string msgType, string func)
            {
            //For some reason, when the msgType is "" it makes it " "... somewheres it must
            //be appending an empty space to the string, just no clue whear.
            //msgType = msgType.Trim();
            string afunc = "";
            int i = 0;
            afunc = omni.console.GetVarString("$MSGCB[\"" + msgType + "\", " + i.AsString() + "]");
            while (afunc != "")
                {
                if (afunc == func)
                    return;
                i++;
                afunc = omni.console.GetVarString("$MSGCB[\"" + msgType + "\", " + i.AsString() + "]");
                }
            omni.console.SetVar("$MSGCB[\"" + msgType + "\", " + i.AsString() + "]", func);
            }

        [ConsoleInteraction(true)]
        public static void defaultMessageCallback(string msgType, string msgString, string a1, string a2, string a3,
            string a4, string a5, string a6, string a7, string a8, string a9, string a10)
            {
            chatHud.OnServerMessage(omni.Util.detag(msgString));
            }

        public static void initialize()
            {
            addMessageCallback("", "defaultMessageCallback");
            }
        }
    }