using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
    {
    public class audioAmbiences
        {
        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("SFXAmbience", "AudioAmbienceDefault");
            sc["environment"] = "AudioEnvOff";
            sc.Create();

            sc = new SingletonCreator("SFXAmbience", "AudioAmbienceOutside");
            sc["environment"] = "AudioEnvPlain";
            sc["states[0]"] = "AudioLocationOutside";
            sc.Create();

            sc = new SingletonCreator("SFXAmbience", "AudioAmbienceInside");
            sc["environment"] = "AudioEnvRoom";
            sc["states[0]"] = "AudioLocationInside";
            sc.Create();

            sc = new SingletonCreator("SFXAmbience", "AudioAmbienceUnderwater");
            sc["environment"] = "AudioEnvUnderwater";
            sc["states[0]"] = "AudioLocationUnderwater";
            sc.Create();
            }
        }
    }