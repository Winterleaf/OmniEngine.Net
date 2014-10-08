using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
    {
    public class audioStates
        {
        public static void initialize()
            {
            //-----------------------------------------------------------------------------
            // Special audio state that will always and only be active when no other
            // state is active.  Useful for letting slots apply specifically when no
            // other slot in a list applies.

            SingletonCreator sc = new SingletonCreator("SFXState", "AudioStateNone");
            sc.Create();

            ((SFXState) "AudioStateNone").activate();

            sc = new SingletonCreator("SimGroup", "AudioLocation");
            sc.Create();

            // State when the listener is outside.
            sc = new SingletonCreator("SFXState", "AudioLocationOutside", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioLocation";
            sc["className"] = "AudioStateExclusive";
            sc.Create();

            // State when the listener is submerged.
            sc = new SingletonCreator("SFXState", "AudioLocationUnderwater", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioLocation";
            sc["className"] = "AudioStateExclusive";
            sc.Create();

            // State when the listener is indoors.
            sc = new SingletonCreator("SFXState", "AudioLocationInside", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioLocation";
            sc["className"] = "AudioStateExclusive";
            sc.Create();


            // Mood-dependent states.
            sc = new SingletonCreator("SimGroup", "AudioMood");
            sc.Create();

            sc = new SingletonCreator("SFXState", "AudioMoodNeutral", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioMood";
            sc["className"] = "AudioStateExclusive";
            sc.Create();

            sc = new SingletonCreator("SFXState", "AudioMoodAggressive", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioMood";
            sc["className"] = "AudioStateExclusive";
            sc.Create();

            sc = new SingletonCreator("SFXState", "AudioMoodTense", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioMood";
            sc["className"] = "AudioStateExclusive";
            sc.Create();

            sc = new SingletonCreator("SFXState", "AudioMoodVictory", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioMood";
            sc["className"] = "AudioStateExclusive";
            sc.Create();

            sc = new SingletonCreator("SFXState", "AudioMoodCalm", typeof (AudioStateExclusive));
            sc["parentGroup"] = "AudioMood";
            sc["className"] = "AudioStateExclusive";
            sc.Create();
            }

        [ConsoleInteraction(true)]
        public static SFXState sfxGetLocation()
            {
            return sfxGetActiveStateInGroup("AudioLocation");
            }

        // Return the currently active SFXState in AudioMood.
        [ConsoleInteraction(true)]
        public static SFXState sfxGetMood()
            {
            return sfxGetActiveStateInGroup("AudioMood");
            }

        [ConsoleInteraction(true)]
        // Return the first active SFXState in the given SimSet/SimGroup.
        public static SFXState sfxGetActiveStateInGroup(SimGroup group)
            {
            for (uint i = 0; i < group.getCount(); i++)
                {
                SFXState obj = group.getObject(i);
                if (!obj.isMemberOfClass("SFXState"))
                    continue;
                if (obj.isActive())
                    return obj;
                }
            return "0";
            }
        }
    }