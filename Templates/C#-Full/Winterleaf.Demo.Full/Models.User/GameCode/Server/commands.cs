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

using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Weapons;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
{
    public class commands
    {
        //-----------------------------------------------------------------------------
        // Misc. server commands avialable to clients
        //-----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        // Debug commands
        //----------------------------------------------------------------------------

        public static void syncEditorGui()
        {
            EditorGui EditorGui = "EditorGui";
            if (EditorGui.isObject())
                //pInvokes.console.Call("EditorGui", "syncCameraGui");
                EditorGui.syncCameraGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdNetSimulateLag(GameConnection client, int msDelay, float packetLossPercent)
        {
            if (client["isAdmin"].AsBool())
                client.setSimulatedNetParams((packetLossPercent/100.0f), msDelay);
        }

        //----------------------------------------------------------------------------
        // Camera commands
        //----------------------------------------------------------------------------
        [ConsoleInteraction(true)]
        public static void serverCmdTogglePathCamera(GameConnection client, bool val)
        {
            string control = val ? client["PathCamera"] : client["camera"];

            client.setControlObject(control);

            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdToggleCamera(GameConnection client)
        {
            string control;
            if (client.getControlObject() == client["player"])
                {
                ((Extendable.Camera) client["camera"]).setVelocity(new Point3F("0 0 0"));
                control = client["camera"];
                }
            else
                {
                ((Player) client["player"]).setVelocity(new Point3F("0 0 0"));
                control = client["player"];
                }
            client.setControlObject(control);

            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraPlayer(GameConnection client)
        {
            ((Player) client["player"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["player"]);
            client.setFirstPerson(true);
            pInvokes.bGlobal["$isFirstPersonVar"] = true;
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraPlayerThird(GameConnection client)
        {
            ((Player) client["player"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["player"]);
            client.setFirstPerson(false);
            pInvokes.bGlobal["$isFirstPersonVar"] = false;
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdDropPlayerAtCamera(GameConnection client)
        {
            // If the player is mounted to something (like a vehicle) drop that at the
            // camera instead. The player will remain mounted.
            Player player = client["player"];
            ShapeBase obj = null;

            obj = player.getObjectMount();
            if (!pInvokes.console.isObject(obj))
                obj = client["player"];

            obj.setTransform(((Extendable.Camera) client["Camera"]).getTransform());
            obj.setVelocity(new Point3F("0 0 0"));
            client.setControlObject(player);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdDropCameraAtPlayer(GameConnection client)
        {
            Player player = client["player"];
            ((Extendable.Camera) client["camera"]).setTransform(player.getEyeTransform());
            ((Extendable.Camera) client["camera"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["camera"]);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdCycleCameraFlyType(GameConnection client)
        {
            Extendable.Camera camera = client["camera"];
            if (camera.getMode() != TypeCameraMotionMode.Fly)
                return;
            if (camera["newtonMode"].AsBool() == false)
                {
                camera["newtonMode"] = true.AsString();
                camera["newtonRotation"] = false.AsString();
                camera.setVelocity(new Point3F("0 0 0"));
                }
            else if (camera["newtonRotation"].AsBool() == false)
                {
                camera["newtonMode"] = true.AsString();
                camera["newtonRotation"] = true.AsString();
                camera.setAngularVelocity(new Point3F("0 0 0"));
                }
            else
                {
                camera["newtonMode"] = false.AsString();
                camera["newtonRotation"] = false.AsString();
                }
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraStandard(GameConnection client)
        {
            Extendable.Camera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = false.AsString();
            camera["newtonRotation"] = false.AsString();
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraNewton(GameConnection client)
        {
            Extendable.Camera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = true.AsString();
            camera["newtonRotation"] = false.AsString();
            camera.setVelocity(new Point3F("0 0 0"));
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraNewtonDamped(GameConnection client)
        {
            Extendable.Camera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = true.AsString();
            camera["newtonRotation"] = true.AsString();
            camera.setAngularVelocity(new Point3F("0 0 0"));
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorOrbitCamera(GameConnection client)
        {
            Extendable.Camera camera = client["camera"];
            camera.setEditOrbitMode();
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorFlyCamera(GameConnection client)
        {
            Extendable.Camera camera = client["camera"];
            camera.setFlyMode();
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdEditorOrbitCameraSelectChange(GameConnection client, int size, Point3F center)
        {
            Extendable.Camera camera = client["camera"];
            if (size > 0)
                {
                camera.setValidEditOrbitPoint(true);
                camera.setEditOrbitPoint(center);
                }
            else
                camera.setValidEditOrbitPoint(false);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdEditorCameraAutoFit(GameConnection client, float radius)
        {
            Extendable.Camera camera = client["camera"];
            camera.autoFitRadius(radius);
            client.setControlObject(camera);
            syncEditorGui();
        }

        //----------------------------------------------------------------------------
        // Server admin
        //----------------------------------------------------------------------------

        [ConsoleInteraction(true)]
        public static void serverCmdSAD(GameConnection client, string password)
        {
            if (password == string.Empty || password != pInvokes.sGlobal["$Pref::Server::AdminPassword"])
                return;
            client["isAdmin"] = true.AsString();
            client["isSuperAdmin"] = true.AsString();

            string name = pInvokes.console.getTaggedString(client["playerName"]);

            message.MessageAll("MsgAdminForce", pInvokes.console.ColorEncode(string.Format(@"\c2{0} has become Admin by force.", name)), client);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSADSetPassword(GameConnection client, string password)
        {
            if (client["isSuperAdmin"].AsBool())
                pInvokes.sGlobal["$Pref::Server::AdminPassword"] = password;
        }

        //----------------------------------------------------------------------------
        // Server chat message handlers
        //----------------------------------------------------------------------------

        [ConsoleInteraction(true)]
        public static void serverCmdTeamMessageSent(GameConnection client, string text)
        {
            if (text.Trim().Length >= pInvokes.iGlobal["$Pref::Server::MaxChatLen"])
                text = text.Substring(0, pInvokes.iGlobal["$Pref::Server::MaxChatLen"]);
            message.ChatMessageTeam(client, client["team"], pInvokes.console.ColorEncode(@"\c3%1: %2"), client["playerName"], text);
        }

        [ConsoleInteraction(true)]
        public static void ServerCmdMessageSent(GameConnection client, string text)
        {
            if (text.Trim().Length >= pInvokes.iGlobal["$Pref::Server::MaxChatLen"])
                text = text.Substring(0, pInvokes.iGlobal["$Pref::Server::MaxChatLen"]);
            message.ChatMessageAll(client, pInvokes.console.ColorEncode(@"\c4%1: %2"), client["playerName"], text);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSuicide(GameConnection client)
        {
            if (client.isObject())
                ((Player) client["player"]).kill("Suicide");
        }

        [ConsoleInteraction(true)]
        public static void serverCmdPlayCel(GameConnection client, string anim)
        {
            if (client.isObject())
                ((Player) client["player"]).playCelAnimation(anim);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdPlayDeath(GameConnection client, string anim)
        {
            if (client.isObject())
                ((Player) client["player"]).playDeathAnimation();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdThrow(GameConnection client, string data)
        {
            Player player = client["player"];

            if (!player.isObject() || (player.getState() == "Dead") || !pInvokes.bGlobal["$Game::Running"])
                return;

            SimObject mountedimage = player.getMountedImage(pInvokes.iGlobal["$WeaponSlot"]);
            switch (data)
                {
                    case "Weapon":
                    {
                        if (mountedimage != "0")
                            {
                            ItemData item = mountedimage["item"];
                            player.Throw(item, 1);
                            }
                    }
                        break;
                    case "Ammo":
                    {
                        if (mountedimage != "0")
                            {
                            SimObject item = mountedimage;
                            if (item["ammo"] != string.Empty)
                                player.Throw(item["ammo"]);
                            }
                    }
                        break;
                    default:
                        if (player.hasInventory(data.getName()))
                            player.Throw(data);
                        break;
                }
        }

        [ConsoleInteraction(true)]
        public static void serverCmdCycleWeapon(GameConnection client, string direction)
        {
            ShapeBase obj = client["player"];
            obj.cycleWeapon(direction);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdUnmountWeapon(GameConnection client)
        {
            ((Player) client["player"]).unmountImage(pInvokes.iGlobal["$WeaponSlot"]);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdReloadWeapon(GameConnection client)
        {
            Player player = client["player"];

            WeaponImage image = player.getMountedImage(pInvokes.iGlobal["$WeaponSlot"]);

            if (player.getInventory(image["ammo"]) == image["ammo.maxInventory"].AsInt())
                return;

            if (image > 0)
                image.clearAmmoClip(player, pInvokes.sGlobal["$WeaponSlot"].AsInt());
        }
    }
}
