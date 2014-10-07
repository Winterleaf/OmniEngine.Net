using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
    {
    public class audioDescriptions
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("SFXDescription", "AudioDefault3D : AudioEffect");
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 20.0;
            sc["MaxDistance"] = 100.0;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioSoft3D : AudioEffect");
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 20.0;
            sc["MaxDistance"] = 100.0;
            sc["volume"] = 0.4;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioClose3D : AudioEffect");
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 10.0;
            sc["MaxDistance"] = 60.0;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioClosest3D : AudioEffect");
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 5.0;
            sc["MaxDistance"] = 10.0;
            sc.Create();

            //-----------------------------------------------------------------------------
            // Looping sounds
            //-----------------------------------------------------------------------------

            sc = new SingletonCreator("SFXDescription", "AudioDefaultLoop3D : AudioEffect");
            sc["isLooping"] = true;
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 20.0;
            sc["MaxDistance"] = 100.0;
            sc.Create();


            sc = new SingletonCreator("SFXDescription", "AudioCloseLoop3D : AudioEffect");
            sc["isLooping"] = true;
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 18.0;
            sc["MaxDistance"] = 25.0;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioClosestLoop3D : AudioEffect");
            sc["isLooping"] = true;
            sc["is3D"] = true;
            sc["ReferenceDistance"] = 5.0;
            sc["MaxDistance"] = 10.0;
            sc.Create();

            // Used for non-looping environmental sounds (like power on, power off)

            sc = new SingletonCreator("SFXDescription", "Audio2D : AudioEffect");
            sc["isLooping"] = false;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioLoop2D : AudioEffect");
            sc["isLooping"] = true;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioStream2D : AudioEffect");
            sc["isStreaming"] = true;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioStreamLoop2D : AudioEffect");
            sc["isStreaming"] = true;
            sc["isLooping"] = true;
            sc.Create();

            //-----------------------------------------------------------------------------
            // Music
            //-----------------------------------------------------------------------------

            sc = new SingletonCreator("SFXDescription", "AudioMusic2D : AudioMusic");
            sc["isStreaming"] = true;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioMusicLoop2D : AudioEffect");
            sc["isStreaming"] = true;
            sc["isLooping"] = true;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioMusic3D : AudioEffect");
            sc["isStreaming"] = true;
            sc["is3D"] = true;
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioMusicLoop3D : AudioEffect");
            sc["isStreaming"] = true;
            sc["is3D"] = true;
            sc["isLooping"] = true;
            sc.Create();
            }
        }
    }