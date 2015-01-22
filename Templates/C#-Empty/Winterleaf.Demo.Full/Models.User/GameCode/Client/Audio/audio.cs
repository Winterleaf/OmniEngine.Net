﻿// WinterLeaf Entertainment
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

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Enums;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio
{
    public class audio
    {
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

            pInvokes.iGlobal["$GuiAudioType"] = 1; // Interface.
            pInvokes.iGlobal["$SimAudioType"] = 2; // Game.
            pInvokes.iGlobal["$MessageAudioType"] = 3; // Notifications.
            pInvokes.iGlobal["$MusicAudioType"] = 4; // Music.

            pInvokes.sGlobal["$AudioChannels[0]"] = "AudioChannelDefault";
            pInvokes.sGlobal["$AudioChannels[" + pInvokes.sGlobal["$GuiAudioType"] + "]"] = "AudioChannelGui";
            pInvokes.sGlobal["$AudioChannels[" + pInvokes.sGlobal["$SimAudioType"] + "]"] = "AudioChannelEffects";
            pInvokes.sGlobal["$AudioChannels[" + pInvokes.sGlobal["$MessageAudioType"] + "]"] = "AudioChannelMessages";
            pInvokes.sGlobal["$AudioChannels[" + pInvokes.sGlobal["$MusicAudioType"] + "]"] = "AudioChannelMusic";

            sc = new SingletonCreator("SimSet", "SFXPausedSet");
            sc.Create();
        }

        public static void sfxStartup()
        {
            // The console builds should re-detect, by default, so that it plays nicely 
            // along side a PC build in the same script directory.
            if (pInvokes.console.GetVarString("$platform") == "xenon")
                {
                if (pInvokes.console.GetVarString("$pref::SFX::provider") == "DirectSound" || pInvokes.console.GetVarString("$pref::SFX::provider") == "OpenAL")
                    pInvokes.console.SetVar("$pref::SFX::provider", "");
                if (pInvokes.console.GetVarString("$pref::SFX::provider") == "")
                    {
                    pInvokes.console.SetVar("$pref::SFX::autoDetect", 1);
                    pInvokes.console.warn("Xbox360 is auto-detecting available sound providers...");
                    pInvokes.console.warn("   - You may wish to alter this functionality before release (core/scripts/client/audio.cs)");
                    }
                }
            pInvokes.console.print("sfxStartup...");
            // If we have a provider set, try initialize a device now.

            if (pInvokes.sGlobal["$pref::SFX::provider"] == "")
                {
                if (sfxInit())
                    return;
                else
                    {
                    // Force auto-detection.
                    pInvokes.bGlobal["$pref::SFX::autoDetect"] = true;
                    if (sfxAutodetect())
                        return;
                    }
                }
            else
                {
                pInvokes.bGlobal["$pref::SFX::autoDetect"] = true;
                if (sfxAutodetect())
                    return;
                }
            // Failure.
            pInvokes.console.error("Failed to initialize device!\n\n");
            pInvokes.sGlobal["$pref::SFX::provider"] = "";
            pInvokes.sGlobal["$pref::SFX::device"] = "";
        }

        public static bool sfxInit()
        {
            // This initializes the sound system device from
            // the defaults in the $pref::SFX:: globals.
            // If already initialized, shut down the current device first.
            if (pInvokes.Util.sfxGetDeviceInfo() != "")
                sfxShutdown();
            // Start it up!

            int maxBuffers = pInvokes.bGlobal["$pref::SFX::useHardware"] ? -1 : pInvokes.iGlobal["$pref::SFX::maxSoftwareBuffers"];
            if (!pInvokes.Util.sfxCreateDevice(pInvokes.sGlobal["$pref::SFX::provider"], pInvokes.sGlobal["$pref::SFX::device"], pInvokes.bGlobal["$pref::SFX::useHardware"], maxBuffers))
                return false;

            // This returns a tab seperated string with
            // the initialized system info.
            string info = pInvokes.Util.sfxGetDeviceInfo();
            pInvokes.sGlobal["$pref::SFX::provider"] = pInvokes.Util.getField(info, 0);
            pInvokes.sGlobal["$pref::SFX::device"] = pInvokes.Util.getField(info, 1);
            pInvokes.sGlobal["$pref::SFX::useHardware"] = pInvokes.Util.getField(info, 2);

            string useHardware = pInvokes.bGlobal["$pref::SFX::useHardware"] ? "Yes" : "No";
            maxBuffers = pInvokes.Util.getField(info, 3).AsInt();

            pInvokes.console.print("   Provider: " + pInvokes.console.GetVarString("$pref::SFX::provider"));
            pInvokes.console.print("   Device: " + pInvokes.console.GetVarString("$pref::SFX::device"));
            pInvokes.console.print("   Hardware: " + useHardware);
            pInvokes.console.print("   Buffers: " + maxBuffers.AsString());

            if (pInvokes.Util.isDefined("$pref::SFX::distanceModel") && pInvokes.sGlobal["$pref::SFX::distanceModel"] != "")
                {
                TypeSFXDistanceModel t = pInvokes.sGlobal["$pref::SFX::distanceModel"];
                pInvokes.Util.sfxSetDistanceModel(t);
                }
            if (pInvokes.Util.isDefined("$pref::SFX::dopplerFactor"))
                pInvokes.Util.sfxSetDopplerFactor(pInvokes.fGlobal["$pref::SFX::dopplerFactor"]);

            if (pInvokes.Util.isDefined("$pref::SFX::rolloffFactor") && pInvokes.sGlobal["$pref::SFX::rolloffFactor"] != "")
                pInvokes.Util.sfxSetRolloffFactor(pInvokes.fGlobal["$pref::SFX::rolloffFactor"]);
            // Restore master volume.

            sfxSetMasterVolume(pInvokes.fGlobal["$pref::SFX::masterVolume"]);

            // Restore channel volumes.
            for (int channel = 0; channel <= 8; channel++)
                sfxSetChannelVolume(((SimSet) channel), pInvokes.fGlobal["$pref::SFX::channelVolume[" + channel.AsString() + "]"]);
            return true;
        }

        // Destroys the current sound system device.
        public static void sfxShutdown()
        {
            pInvokes.fGlobal["$pref::SFX::masterVolume"] = sfxGetMasterVolume();

            for (int channel = 0; channel <= 8; channel++)
                pInvokes.sGlobal["$pref::SFX::channelVolume[" + channel.AsString() + "]"] = sfxGetChannelVolume(channel);

            // We're assuming here that a null info 
            // string means that no device is loaded.
            if (pInvokes.Util.sfxGetDeviceInfo() == "")
                return;
            pInvokes.Util.sfxDeleteDevice();
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
            string devices = pInvokes.Util.sfxGetAvailableDevices();
            // Collect and sort the devices by preferentiality.

            int count = pInvokes.Util.getRecordCount(devices);

            ArrayObject deviceTrySequence = new ObjectCreator("ArrayObject").Create().AsString();

            for (int i = 0; i < count; i++)
                {
                string info = pInvokes.Util.getRecord(devices, i);
                string provider = pInvokes.Util.getField(info, 0);
                deviceTrySequence.push_back(provider, info);
                }
            deviceTrySequence.sortfk("sfxCompareProvider");
            // Try the devices in order.

            count = deviceTrySequence.count();
            for (int i = 0; i < count; i++)
                {
                string provider = deviceTrySequence.getKey(i);
                string info = deviceTrySequence.getValue(i);
                pInvokes.sGlobal["$pref::SFX::provider"] = provider;
                pInvokes.sGlobal["$pref::SFX::device"] = pInvokes.Util.getField(info, 1);
                pInvokes.sGlobal["$pref::SFX::useHardware"] = pInvokes.Util.getField(info, 2);
                // By default we've decided to avoid hardware devices as
                // they are buggy and prone to problems.
                pInvokes.bGlobal["$pref::SFX::useHardware"] = false;
                if (!sfxInit())
                    continue;
                pInvokes.bGlobal["$pref::SFX::autoDetect"] = false;
                deviceTrySequence.delete();
                return true;
                }
            // Found no suitable device.
            pInvokes.console.error("sfxAutodetect - Could not initialize a valid SFX device.");
            pInvokes.sGlobal["$pref::SFX::provider"] = "";
            pInvokes.sGlobal["$pref::SFX::device"] = "";
            pInvokes.sGlobal["$pref::SFX::useHardware"] = "";
            deviceTrySequence.delete();
            return false;
        }

        [ConsoleInteraction(true)]
        public static SFXSource sfxOldChannelToGroup(string channel)
        {
            return pInvokes.sGlobal["$AudioChannels[" + channel + "]"];
        }

        [ConsoleInteraction(true)]
        public static string sfxGroupToOldChannel(string group)
        {
            string id = group.getID().AsString();
            for (int i = 0;; i++)
                {
                if (!pInvokes.isGlobal["$AudioChannels[" + i.AsString() + "]"])
                    return "-1";
                else if (pInvokes.sGlobal["$AudioChannels[" + i.AsString() + "]"] == id)
                    return i.AsString();
                }
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