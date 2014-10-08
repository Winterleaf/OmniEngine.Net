#region

using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using centerPrint = WinterLeaf.Demo.Full.Models.User.GameCode.Client.CenterPrint.centerPrint;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.Extendable
    {
    public partial class GameConnection
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void initialize()
            {
            omni.Util.eval(@"function disconnect(){_disconnect();}");
            }

        [ConsoleInteraction(true)]
        public static void handleConnectionErrorMessage(string msgType, string msgString, string msgError)
            {
            omni.console.SetVar("$ServerConnectionErrorMessage", msgError);
            }

        [ConsoleInteraction(true)]
        public override void initialControlSet()
            {
            console.print("*** Initial Control Object");

            // The first control object has been set by the server
            // and we are now ready to go.

            // first check if the editor is active

            if (!Util.isToolBuild() && console.Call_Classname("Editor", "checkActiveLoadDone").AsBool())
                return;
            if (((GuiCanvas) "Canvas").getContent() == "PlayGui".getID())
                return;
            ((GuiCanvas) "Canvas").setContent("PlayGui");
            }

        [ConsoleInteraction(true)]
        public override void onControlObjectChange()
            {
            console.print("*** Control Object Changed");
            // Reset the current FOV to match the new object
            // and turn off any current zoom.
            defaultBind.resetCurrentFOV();
            defaultBind.turnOffZoom();
            }

        [ConsoleInteraction(true)]
        public override void setLagIcon(bool state)
            {
            if (getAddress() == "local")
                return;

            ((GuiControl) "LagIcon").setVisible(state);
            }

        [ConsoleInteraction(true)]
        public override void onFlash(bool state)
            {
            if (state)
                ((PostEffect) "FlashFx").enable();
            else
                ((PostEffect) "FlashFx").disable();
            }

        [ConsoleInteraction(true)]
        public override void onConnectionAccepted()
            {
            // Called on the new connection object after connect() succeeds.
            ((GuiControl) "LagIcon").setVisible(false);
            // Startup the physics world on the client before any
            // datablocks and objects are ghosted over.
            Util.physicsInitWorld("client");
            }

        [ConsoleInteraction(true)]
        public override void onConnectionTimedOut()
            {
            // Called when an established connection times out

            disconnectedCleanup();


            messageBox.MessageBoxOK("TIMED OUT",
                "The server connection has timed out.", "");
            }

        [ConsoleInteraction(true)]
        public override void onConnectionDropped(string reason)
            {
            disconnectedCleanup();
            messageBox.MessageBoxOK("DISCONNECT",
                "The server has dropped the connection: " + reason, "");
            }

        [ConsoleInteraction(true)]
        public override void onConnectionError(string errorString)
            {
            disconnectedCleanup();
            console.Call("MessageBoxOk",
                new[] {"DISCONNECT", console.GetVarString("$ServerConnectionErrorMessage") + "(" + errorString + ")"});
            messageBox.MessageBoxOK("DISCONNECT",
                sGlobal["$ServerConnectionErrorMessage"] + "(" + errorString + ")", "");
            }

        [ConsoleInteraction(true)]
        public override void onConnectRequestRejected(string reason)
            {
            string error = "";
            switch (reason)
                {
                    case "CR_INVALID_PROTOCOL_VERSION":
                        error = "Incompatible protocol version: Your game version is not compatible with this server.";
                        break;
                    case "CR_INVALID_CONNECT_PACKET":
                        error = "Internal Error: badly formed network packet";
                        break;
                    case "CR_YOUAREBANNED":
                        error = "You are not allowed to play on this server.";
                        break;
                    case "CR_SERVERFULL":
                        error = "This server is full.";
                        break;
                    case "CHR_PASSWORD":
                        if (console.GetVarString("$Client::Password") == "")
                            messageBox.MessageBoxOK("REJECTED",
                                "The Server Requires a Password", "");
                        else
                            {
                            console.SetVar("$Client::Password", "");
                            messageBox.MessageBoxOK("REJECTED",
                                "That password is incorrect.", "");
                            }
                        return;
                    case "CHR_PROTOCOL":
                        error = "Incompatible protocol version: Your game version is not compatible with this server.";
                        break;
                    case "CHR_CLASSCRC":
                        error = "Incompatible game classes: Your game version is not compatible with this server.";
                        break;
                    case "CHR_INVALID_CHALLENGE_PACKET":
                        error = "Internal Error: Invalid server response packet";
                        break;
                    default:
                        error = "Connection error.  Please try another server.  Error code: (" + reason + ")";
                        break;
                }
            disconnectedCleanup();
            messageBox.MessageBoxOK("REJECTED", error, "");
            }

        [ConsoleInteraction(true)]
        public override void onConnectRequestTimedOut()
            {
            disconnectedCleanup();
            messageBox.MessageBoxOK("TIMED OUT",
                "Your connection to the server timed out.", "");
            }

        [ConsoleInteraction(true)]
        public static void _disconnect()
            {
            // We need to stop the client side simulation
            // else physics resources will not cleanup properly.
            omni.Util.physicsStopSimulation("client");

            // Before we destroy the client physics world
            // make sure all ServerConnection objects are deleted.
            if ("ServerConnection".isObject())
                {
                ((GameConnection) "ServerConnection").deleteAllObjects();
                }

            // Delete the connection if it's still there.
            if ("ServerConnection".isObject())
                "ServerConnection".delete();

            disconnectedCleanup();
            // Call destroyServer in case we're hosting
            server.destroyServer();
            }

        [ConsoleInteraction(true)]
        public static void disconnectedCleanup()
            {
            // End mission, if it's running.
            if (omni.console.GetVarBool("$Client::missionRunning"))
                mission.clientEndMission();

            // Disable mission lighting if it's going, this is here
            // in case we're disconnected while the mission is loading.
            omni.bGlobal["$lightingMission"] = false;
            omni.bGlobal["$sceneLighting::terminateLighting"] = true;

            // Clear misc script stuff
            ((MessageVector) "HudMessageVector").clear();
            ((GuiControl) "LagIcon").setVisible(false);

         

            centerPrint.clientCmdClearBottomPrint();
            centerPrint.clientCmdClearCenterPrint();

            if (omni.console.isObject("MainMenuGui"))
                ((GuiCanvas) "Canvas").setContent("MainMenuGui");


            omni.Util.physicsDestroyWorld("client");
            }
        }
    }