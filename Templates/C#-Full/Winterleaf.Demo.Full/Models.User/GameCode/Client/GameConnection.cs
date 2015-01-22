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

#region

using WinterLeaf.Demo.Full.Models.User.GameCode.Client;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server;
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
            Util.eval(@"function disconnect(){_disconnect();}");
        }

        [ConsoleInteraction(true)]
        public static void handleConnectionErrorMessage(string msgType, string msgString, string msgError)
        {
            console.SetVar("$ServerConnectionErrorMessage", msgError);
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

            messageBox.MessageBoxOK("TIMED OUT", "The server connection has timed out.", "");
        }

        [ConsoleInteraction(true)]
        public override void onConnectionDropped(string reason)
        {
            disconnectedCleanup();
            messageBox.MessageBoxOK("DISCONNECT", "The server has dropped the connection: " + reason, "");
        }

        [ConsoleInteraction(true)]
        public override void onConnectionError(string errorString)
        {
            disconnectedCleanup();
            console.Call("MessageBoxOk", new[] {"DISCONNECT", console.GetVarString("$ServerConnectionErrorMessage") + "(" + errorString + ")"});
            messageBox.MessageBoxOK("DISCONNECT", sGlobal["$ServerConnectionErrorMessage"] + "(" + errorString + ")", "");
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
                            messageBox.MessageBoxOK("REJECTED", "The Server Requires a Password", "");
                        else
                            {
                            console.SetVar("$Client::Password", "");
                            messageBox.MessageBoxOK("REJECTED", "That password is incorrect.", "");
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
            messageBox.MessageBoxOK("TIMED OUT", "Your connection to the server timed out.", "");
        }

        [ConsoleInteraction(true)]
        public static void _disconnect()
        {
            // We need to stop the client side simulation
            // else physics resources will not cleanup properly.
            Util.physicsStopSimulation("client");

            // Before we destroy the client physics world
            // make sure all ServerConnection objects are deleted.
            if ("ServerConnection".isObject())
                ((GameConnection) "ServerConnection").deleteAllObjects();

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
            if (console.GetVarBool("$Client::missionRunning"))
                mission.clientEndMission();

            // Disable mission lighting if it's going, this is here
            // in case we're disconnected while the mission is loading.
            bGlobal["$lightingMission"] = false;
            bGlobal["$sceneLighting::terminateLighting"] = true;

            // Clear misc script stuff
            ((MessageVector) "HudMessageVector").clear();
            ((GuiControl) "LagIcon").setVisible(false);

            ((PlayerListGui) "PlayerListGui").clear();

            centerPrint.clientCmdClearBottomPrint();
            centerPrint.clientCmdClearCenterPrint();

            if (console.isObject("MainMenuGui"))
                ((GuiCanvas) "Canvas").setContent("MainMenuGui");

            Util.physicsDestroyWorld("client");
        }
    }
}