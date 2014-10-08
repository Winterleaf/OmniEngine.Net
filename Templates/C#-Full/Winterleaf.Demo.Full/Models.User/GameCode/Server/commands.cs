#region

using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
using WinterLeaf.Demo.Full.Models.User.GameCode.Server.Weapons;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
{
    public class commands
    {
        private static readonly pInvokes omni = new pInvokes();
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
                //omni.console.Call("EditorGui", "syncCameraGui");
                EditorGui.syncCameraGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdNetSimulateLag(GameConnection client, int msDelay, float packetLossPercent)
        {
            if (client["isAdmin"].AsBool())
                client.setSimulatedNetParams((packetLossPercent / 100.0f), msDelay);
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
                ((WinterLeaf.Demo.Full.Models.User.Extendable.Camera)client["camera"]).setVelocity(new Point3F("0 0 0"));
                control = client["camera"];
            }
            else
            {
                ((Player)client["player"]).setVelocity(new Point3F("0 0 0"));
                control = client["player"];
            }
            client.setControlObject(control);

            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraPlayer(GameConnection client)
        {
            ((Player)client["player"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["player"]);
            client.setFirstPerson(true);
            omni.bGlobal["$isFirstPersonVar"] = true;
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraPlayerThird(GameConnection client)
        {
            ((Player)client["player"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["player"]);
            client.setFirstPerson(false);
            omni.bGlobal["$isFirstPersonVar"] = false;
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
            if (!omni.console.isObject(obj))
                obj = client["player"];

            obj.setTransform(((WinterLeaf.Demo.Full.Models.User.Extendable.Camera)client["Camera"]).getTransform());
            obj.setVelocity(new Point3F("0 0 0"));
            client.setControlObject(player);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdDropCameraAtPlayer(GameConnection client)
        {
            Player player = client["player"];
            ((WinterLeaf.Demo.Full.Models.User.Extendable.Camera)client["camera"]).setTransform(player.getEyeTransform());
            ((Models.User.Extendable.Camera)client["camera"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["camera"]);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdCycleCameraFlyType(GameConnection client)
        {
            Models.User.Extendable.Camera camera = client["camera"];
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
            Models.User.Extendable.Camera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = false.AsString();
            camera["newtonRotation"] = false.AsString();
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorCameraNewton(GameConnection client)
        {
            Models.User.Extendable.Camera camera = client["camera"];
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
            Models.User.Extendable.Camera camera = client["camera"];
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
            Models.User.Extendable.Camera camera = client["camera"];
            camera.setEditOrbitMode();
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSetEditorFlyCamera(GameConnection client)
        {
            Models.User.Extendable.Camera camera = client["camera"];
            camera.setFlyMode();
            client.setControlObject(camera);
            syncEditorGui();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdEditorOrbitCameraSelectChange(GameConnection client, int size, Point3F center)
        {
            Models.User.Extendable.Camera camera = client["camera"];
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
            Models.User.Extendable.Camera camera = client["camera"];
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
            if (password == string.Empty || password != omni.sGlobal["$Pref::Server::AdminPassword"])
                return;
            client["isAdmin"] = true.AsString();
            client["isSuperAdmin"] = true.AsString();


            string name = omni.console.getTaggedString(client["playerName"]);

            message.MessageAll("MsgAdminForce",
                omni.console.ColorEncode(string.Format(@"\c2{0} has become Admin by force.", name)), client);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSADSetPassword(GameConnection client, string password)
        {
            if (client["isSuperAdmin"].AsBool())
                omni.sGlobal["$Pref::Server::AdminPassword"] = password;
        }

        //----------------------------------------------------------------------------
        // Server chat message handlers
        //----------------------------------------------------------------------------

        [ConsoleInteraction(true)]
        public static void serverCmdTeamMessageSent(GameConnection client, string text)
        {
            if (text.Trim().Length >= omni.iGlobal["$Pref::Server::MaxChatLen"])
                text = text.Substring(0, omni.iGlobal["$Pref::Server::MaxChatLen"]);
            message.ChatMessageTeam(client, client["team"],
                omni.console.ColorEncode(@"\c3%1: %2"), client["playerName"], text);
        }

        [ConsoleInteraction(true)]
        public static void ServerCmdMessageSent(GameConnection client, string text)
        {
            if (text.Trim().Length >= omni.iGlobal["$Pref::Server::MaxChatLen"])
                text = text.Substring(0, omni.iGlobal["$Pref::Server::MaxChatLen"]);
            message.ChatMessageAll(client, omni.console.ColorEncode(@"\c4%1: %2"),
                client["playerName"], text);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdSuicide(GameConnection client)
        {
            if (client.isObject())
                ((Player)client["player"]).kill("Suicide");
        }

        [ConsoleInteraction(true)]
        public static void serverCmdPlayCel(GameConnection client, string anim)
        {
            if (client.isObject())
                ((Player)client["player"]).playCelAnimation(anim);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdPlayDeath(GameConnection client, string anim)
        {
            if (client.isObject())
                ((Player)client["player"]).playDeathAnimation();
        }

        [ConsoleInteraction(true)]
        public static void serverCmdThrow(GameConnection client, string data)
        {
            Player player = client["player"];

            if (!player.isObject() || (player.getState() == "Dead") || !omni.bGlobal["$Game::Running"])
                return;

            SimObject mountedimage = player.getMountedImage(omni.iGlobal["$WeaponSlot"]);
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
            ((Player)client["player"]).unmountImage(omni.iGlobal["$WeaponSlot"]);
        }

        [ConsoleInteraction(true)]
        public static void serverCmdReloadWeapon(GameConnection client)
        {

        Player player = client["player"];

            WeaponImage image = player.getMountedImage(omni.iGlobal["$WeaponSlot"]);

            if (player.getInventory(image["ammo"]) == image["ammo.maxInventory"].AsInt())
            {
                return;
            }

            if (image > 0)
                image.clearAmmoClip(player, omni.sGlobal["$WeaponSlot"].AsInt());
        }
    }
}