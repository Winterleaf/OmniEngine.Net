using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;


namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
    {
    // Game specific audio descriptions. Always declare SFXDescription's (the type of sound)
// before SFXProfile's (the sound itself) when creating new ones
    public class audioData
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("SFXDescription", "BulletFireDesc : AudioEffect");
            sc["isLooping"] = false;
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 10.0;
            sc["MaxDistance"] = 60.0;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "BulletImpactDesc : AudioEffect");
            sc["isLooping"] = false;
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 10.0;
            sc["MaxDistance"] = 30.0;
            sc["volume"] = 0.4;
            sc["pitch"] = 1.4;
            sc.Create();

            if (omni.Util.isFile("scripts/client/audioData.cs"))
                omni.Util.exec("scripts/client/audioData.cs", false, false);
            }
        }
    }