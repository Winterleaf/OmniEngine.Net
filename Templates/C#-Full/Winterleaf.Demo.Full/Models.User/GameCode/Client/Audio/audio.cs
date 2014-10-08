using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Enums;


namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
    {
    public class audio
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            SingletonCreator sc = new SingletonCreator("SFXDescription", "AudioMaster");
            sc.Create();

            sc = new SingletonCreator("SFXSource", "AudioChannelMaster");
            sc["description"] = "AudioMaster";
            sc.Create();

            sc = new SingletonCreator("SFXDescription", "AudioChannel");
            sc["sourceGroup"] = "AudioChannelMaster";
            sc.Create();

            sc = new SingletonCreator("SFXSource", "AudioChannelDefault");
            sc["description"] = "AudioChannel";
            sc.Create();

            sc = new SingletonCreator("SFXSource", "AudioChannelGui");
            sc["description"] = "AudioChannel";
            sc.Create();

            sc = new SingletonCreator("SFXSource", "AudioChannelEffects");
            sc["description"] = "AudioChannel";
            sc.Create();

            sc = new SingletonCreator("SFXSource", "AudioChannelMessages");
            sc["description"] = "AudioChannel";
            sc.Create();

            sc = new SingletonCreator("SFXSource", "AudioChannelMusic");
            sc["description"] = "AudioChannel";
            sc.Create();

            // Set default playback states of the channels.

            ((SFXSource) "AudioChannelMaster").play(-1);
            ((SFXSource) "AudioChannelDefault").play(-1);
            ((SFXSource) "AudioChannelGui").play(-1);
            ((SFXSource) "AudioChannelMusic").play(-1);
            ((SFXSource) "AudioChannelMessages").play(-1);
            // Stop in-game effects channels.
            ((SFXSource) "AudioChannelEffects").stop(-1);

            //-----------------------------------------------------------------------------
            //    Master SFXDescriptions.
            //-----------------------------------------------------------------------------

            // Master description for interface audio.

            sc = new SingletonCreator("SFXDescription", "AudioGui");
            sc["volume"] = 1.0;
            sc["sourceGroup"] = "AudioChannelGui";
            sc.Create();

            // Master description for game effects audio.
            sc = new SingletonCreator("SFXDescription", "AudioEffect");
            sc["volume"] = 1.0;
            sc["sourceGroup"] = "AudioChannelEffects";
            sc.Create();

            // Master description for audio in notifications.
            sc = new SingletonCreator("SFXDescription", "AudioMessage");
            sc["volume"] = 1.0;
            sc["sourceGroup"] = "AudioChannelMessages";
            sc.Create();

            // Master description for music.
            sc = new SingletonCreator("SFXDescription", "AudioMusic");
            sc["volume"] = 1.0;
            sc["sourceGroup"] = "AudioChannelMusic";
            sc.Create();

            //-----------------------------------------------------------------------------
            //    Backwards-compatibility with old channel system.
            //-----------------------------------------------------------------------------

            // Volume channel IDs for backwards-compatibility.

            omni.iGlobal["$GuiAudioType"] = 1; // Interface.
            omni.iGlobal["$SimAudioType"] = 2; // Game.
            omni.iGlobal["$MessageAudioType"] = 3; // Notifications.
            omni.iGlobal["$MusicAudioType"] = 4; // Music.

            omni.sGlobal["$AudioChannels[0]"] = "AudioChannelDefault";
            omni.sGlobal["$AudioChannels[" + omni.sGlobal["$GuiAudioType"] + "]"] = "AudioChannelGui";
            omni.sGlobal["$AudioChannels[" + omni.sGlobal["$SimAudioType"] + "]"] = "AudioChannelEffects";
            omni.sGlobal["$AudioChannels[" + omni.sGlobal["$MessageAudioType"] + "]"] = "AudioChannelMessages";
            omni.sGlobal["$AudioChannels[" + omni.sGlobal["$MusicAudioType"] + "]"] = "AudioChannelMusic";


            sc = new SingletonCreator("SimSet", "SFXPausedSet");
            sc.Create();
            }

        public static void sfxStartup()
            {
            // The console builds should re-detect, by default, so that it plays nicely 
            // along side a PC build in the same script directory.
            if (omni.console.GetVarString("$platform") == "xenon")
                {
                if (omni.console.GetVarString("$pref::SFX::provider") == "DirectSound" ||
                    omni.console.GetVarString("$pref::SFX::provider") == "OpenAL")
                    omni.console.SetVar("$pref::SFX::provider", "");
                if (omni.console.GetVarString("$pref::SFX::provider") == "")
                    {
                    omni.console.SetVar("$pref::SFX::autoDetect", 1);
                    omni.console.warn("Xbox360 is auto-detecting available sound providers...");
                    omni.console.warn(
                        "   - You may wish to alter this functionality before release (core/scripts/client/audio.cs)");
                    }
                }
            omni.console.print("sfxStartup...");
            // If we have a provider set, try initialize a device now.

            if (omni.sGlobal["$pref::SFX::provider"] == "")
                {
                if (sfxInit())
                    return;
                else
                    {
                    // Force auto-detection.
                    omni.bGlobal["$pref::SFX::autoDetect"] = true;
                    if (sfxAutodetect())
                        return;
                    }
                }
            else
                {
                omni.bGlobal["$pref::SFX::autoDetect"] = true;
                if (sfxAutodetect())
                    return;
                }
            // Failure.
            omni.console.error("Failed to initialize device!\n\n");
            omni.sGlobal["$pref::SFX::provider"] = "";
            omni.sGlobal["$pref::SFX::device"] = "";
            }

        public static bool sfxInit()
            {
            // This initializes the sound system device from
            // the defaults in the $pref::SFX:: globals.
            // If already initialized, shut down the current device first.
            if (omni.Util.sfxGetDeviceInfo() != "")
                sfxShutdown();
            // Start it up!

            int maxBuffers = omni.bGlobal["$pref::SFX::useHardware"]
                ? -1
                : omni.iGlobal["$pref::SFX::maxSoftwareBuffers"];
            if (
                !omni.Util.sfxCreateDevice(omni.sGlobal["$pref::SFX::provider"], omni.sGlobal["$pref::SFX::device"],
                    omni.bGlobal["$pref::SFX::useHardware"], maxBuffers))
                return false;

            // This returns a tab seperated string with
            // the initialized system info.
            string info = omni.Util.sfxGetDeviceInfo();
            omni.sGlobal["$pref::SFX::provider"] = omni.Util.getField(info, 0);
            omni.sGlobal["$pref::SFX::device"] = omni.Util.getField(info, 1);
            omni.sGlobal["$pref::SFX::useHardware"] = omni.Util.getField(info, 2);


            string useHardware = omni.bGlobal["$pref::SFX::useHardware"] ? "Yes" : "No";
            maxBuffers = omni.Util.getField(info, 3).AsInt();

            omni.console.print("   Provider: " + omni.console.GetVarString("$pref::SFX::provider"));
            omni.console.print("   Device: " + omni.console.GetVarString("$pref::SFX::device"));
            omni.console.print("   Hardware: " + useHardware);
            omni.console.print("   Buffers: " + maxBuffers.AsString());


            if (omni.Util.isDefined("$pref::SFX::distanceModel") && omni.sGlobal["$pref::SFX::distanceModel"] != "")
                {
                TypeSFXDistanceModel t = omni.sGlobal["$pref::SFX::distanceModel"];
                omni.Util.sfxSetDistanceModel(t);
                }
            if (omni.Util.isDefined("$pref::SFX::dopplerFactor"))
                {
                omni.Util.sfxSetDopplerFactor(omni.fGlobal["$pref::SFX::dopplerFactor"]);
                }

            if (omni.Util.isDefined("$pref::SFX::rolloffFactor") && omni.sGlobal["$pref::SFX::rolloffFactor"] != "")
                {
                omni.Util.sfxSetRolloffFactor(omni.fGlobal["$pref::SFX::rolloffFactor"]);
                }
            // Restore master volume.

            sfxSetMasterVolume(omni.fGlobal["$pref::SFX::masterVolume"]);


            // Restore channel volumes.
            for (int channel = 0; channel <= 8; channel++)
                sfxSetChannelVolume(((SimSet) channel),
                    omni.fGlobal["$pref::SFX::channelVolume[" + channel.AsString() + "]"]);
            return true;
            }

        // Destroys the current sound system device.
        public static void sfxShutdown()
            {
            omni.fGlobal["$pref::SFX::masterVolume"] = sfxGetMasterVolume();

            for (int channel = 0; channel <= 8; channel++)
                omni.sGlobal["$pref::SFX::channelVolume[" + channel.AsString() + "]"] = sfxGetChannelVolume(channel);

            // We're assuming here that a null info 
            // string means that no device is loaded.
            if (omni.Util.sfxGetDeviceInfo() == "")
                return;
            omni.Util.sfxDeleteDevice();
            }

        // Determines which of the two SFX providers is preferable.
        [ConsoleInteraction(true)]
        public static string sfxCompareProvider(string providerA, string providerB)
            {
            if (providerA == providerB)
                return "0";
            switch (providerA)
                {
                        // Always prefer FMOD over anything else.
                    case "FMOD":
                        return "1";
                        // Prefer OpenAL over anything but FMOD.
                    case "OpenAL":
                        return providerB == "FMOD" ? "-1" : "1";
                        // As long as the XAudio SFX provider still has issues,
                        // choose stable DSound over it.
                    case "DirectSound":
                        return providerB == "FMOD" || providerB == "OpenAL" ? "-1" : "0";
                    case "XAudio":
                        return providerB == "FMOD" && providerB != "OpenAL" && providerB != "DirectSound" ? "1" : "-1";
                    default:
                        return "-1";
                }
            }

        public static bool sfxAutodetect()
            {
            // Get all the available devices.
            string devices = omni.Util.sfxGetAvailableDevices();
            // Collect and sort the devices by preferentiality.


            int count = omni.Util.getRecordCount(devices);


            ArrayObject deviceTrySequence = new ObjectCreator("ArrayObject").Create().AsString();


            for (int i = 0; i < count; i++)
                {
                string info = omni.Util.getRecord(devices, i);
                string provider = omni.Util.getField(info, 0);
                deviceTrySequence.push_back(provider, info);
                }
            deviceTrySequence.sortfk("sfxCompareProvider");
            // Try the devices in order.

            count = deviceTrySequence.count();
            for (int i = 0; i < count; i++)
                {
                string provider = deviceTrySequence.getKey(i);
                string info = deviceTrySequence.getValue(i);
                omni.sGlobal["$pref::SFX::provider"] = provider;
                omni.sGlobal["$pref::SFX::device"] = omni.Util.getField(info, 1);
                omni.sGlobal["$pref::SFX::useHardware"] = omni.Util.getField(info, 2);
                // By default we've decided to avoid hardware devices as
                // they are buggy and prone to problems.
                omni.bGlobal["$pref::SFX::useHardware"] = false;
                if (!sfxInit())
                    continue;
                omni.bGlobal["$pref::SFX::autoDetect"] = false;
                deviceTrySequence.delete();
                return true;
                }
            // Found no suitable device.
            omni.console.error("sfxAutodetect - Could not initialize a valid SFX device.");
            omni.sGlobal["$pref::SFX::provider"] = "";
            omni.sGlobal["$pref::SFX::device"] = "";
            omni.sGlobal["$pref::SFX::useHardware"] = "";
            deviceTrySequence.delete();
            return false;
            }

        [ConsoleInteraction(true)]
        public static SFXSource sfxOldChannelToGroup(string channel)
            {
            return omni.sGlobal["$AudioChannels[" + channel + "]"];
            }

        [ConsoleInteraction(true)]
        public static string sfxGroupToOldChannel(string group)
            {
            string id = group.getID().AsString();
            for (int i = 0;; i++)
                if (!omni.isGlobal["$AudioChannels[" + i.AsString() + "]"])
                    return "-1";
                else if (omni.sGlobal["$AudioChannels[" + i.AsString() + "]"] == id)
                    return i.AsString();
            }

        [ConsoleInteraction(true)]
        public static void sfxSetMasterVolume(float volume)
            {
            ((SFXSource) "AudioChannelMaster").setVolume(volume);
            }


        public static float sfxGetMasterVolume()
            {
            return ((SFXSource) "AudioChannelMaster").getVolume();
            }

        [ConsoleInteraction(true)]
        public static void sfxStopAll(SimSet channel)
            {
            channel = sfxOldChannelToGroup(channel);

            if (!channel.isObject())
                return;

            for (uint i = 0; i < channel.getCount(); i++)
                ((SFXSource) channel.getObject(i)).stop(-1);
            //SFXSource.stop(channel.getObject(i), -1);
            }


        public static string sfxGetChannelVolume(SimSet channel)
            {
            SFXSource obj = sfxOldChannelToGroup(channel);
            return obj.isObject() ? obj.getVolume().AsString() : "0";
            }

        [ConsoleInteraction(true)]
        public static void sfxSetChannelVolume(SimSet channel, float volume)
            {
            SFXSource obj = sfxOldChannelToGroup(channel);
            if (obj.isObject())
                obj.setVolume(volume);
            }
        }
    }