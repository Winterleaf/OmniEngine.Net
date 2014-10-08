#region

using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Server
    {
    public class spawn
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void init()
            {
            // Leave $Game::defaultPlayerClass and $Game::defaultPlayerDataBlock as empty strings ("")
            // to spawn a the $Game::defaultCameraClass as the control object.
            omni.sGlobal["$Game::DefaultPlayerClass"] = "Player";
            omni.sGlobal["$Game::DefaultPlayerDataBlock"] = "DefaultPlayerData";
            omni.sGlobal["$Game::DefaultPlayerSpawnGroups"] = "PlayerSpawnPoints";

            //-----------------------------------------------------------------------------
            // What kind of "camera" is spawned is either controlled directly by the
            // SpawnSphere or it defaults back to the values set here. This also controls
            // which SimGroups to attempt to select the spawn sphere's from by walking down
            // the list of SpawnGroups till it finds a valid spawn object.
            //-----------------------------------------------------------------------------
            omni.sGlobal["$Game::DefaultCameraClass"] = "Camera";
            omni.sGlobal["$Game::DefaultCameraDataBlock"] = "Observer";
            omni.sGlobal["$Game::DefaultCameraSpawnGroups"] = "CameraSpawnPoints PlayerSpawnPoints";
            }
        }
    }