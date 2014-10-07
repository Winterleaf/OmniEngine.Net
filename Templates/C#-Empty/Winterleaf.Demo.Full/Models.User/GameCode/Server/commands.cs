#region

using WinterLeaf.Demo.Full.Models.User.CustomObjects.Utilities;
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

       

        
    }
}