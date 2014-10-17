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

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui.OptionsDlg
{
    internal class Misc
    {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
        {
            omni.iGlobal["$RemapCount"] = 0;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Forward";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "moveforward";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Backward";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "movebackward";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Strafe Left";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "moveleft";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Strafe Right";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "moveright";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Turn Left";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "turnLeft";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Turn Right";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "turnRight";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Look Up";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "panUp";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Look Down";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "panDown";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Jump";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "jump";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Fire Weapon";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "mouseFire";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Adjust Zoom";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "setZoomFov";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Toggle Zoom";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "toggleZoom";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Free Look";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "toggleFreeLook";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Switch 1st/3rd";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "toggleFirstPerson";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Chat to Everyone";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "toggleMessageHud";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Message Hud PageUp";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "pageMessageHudUp";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Message Hud PageDown";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "pageMessageHudDown";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Resize Message Hud";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "resizeMessageHud";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Show Scores";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "showPlayerList";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Animation - Wave";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "celebrationWave";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Animation - Salute";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "celebrationSalute";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Suicide";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "suicide";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Toggle Camera";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "toggleCamera";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Drop Camera at Player";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "dropCameraAtPlayer";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Drop Player at Camera";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "dropPlayerAtCamera";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;
            omni.sGlobal["$RemapName[" + omni.iGlobal["$RemapCount"] + "]"] = "Bring up Options Dialog";
            omni.sGlobal["$RemapCmd[" + omni.iGlobal["$RemapCount"] + "]"] = "bringUpOptions";
            omni.iGlobal["$RemapCount"] = omni.iGlobal["$RemapCount"] + 1;

            omni.iGlobal["$AudioTestHandle"] = 0;
            // Description to use for playing the volume test sound.  This isn't
            // played with the description of the channel that has its volume changed
            // because we know nothing about the playback state of the channel.  If it
            // is paused or stopped, the test sound would not play then.

            ObjectCreator oc = new ObjectCreator("SFXDescription");
            oc["sourceGroup"] = "AudioChannelMaster";

            omni.sGlobal["$AudioTestDescription"] = oc.Create().AsString();
        }

        [ConsoleInteraction(true)]
        public static void restoreDefaultMappings()
        {
            ((ActionMap) "moveMap").delete();
            defaultBind.initialize();
            ((OptionsDlg) "optionsDlg").fillRemapList();
        }

        [ConsoleInteraction(true)]
        public static void OptAudioUpdateMasterVolume(float volume)
        {
            if (volume == omni.fGlobal["$pref::SFX::masterVolume"])
                return;

            audio.sfxSetMasterVolume(volume);
            omni.fGlobal["$pref::SFX::masterVolume"] = volume;

            if (omni.sGlobal["$AudioTestHandle"].isObject())
                omni.iGlobal["$AudioTestHandle"] = omni.Util.sfxPlayOnce("AudioChannel", "art/sound/ui/volumeTest.wav");
        }

        [ConsoleInteraction(true)]
        public static void OptAudioUpdateChannelVolume(SFXDescription description, float volume)
        {
            string channel = audio.sfxGroupToOldChannel(description["sourceGroup"]);
            if (volume == omni.fGlobal["$pref::SFX::channelVolume[" + channel + "]"])
                return;

            audio.sfxSetChannelVolume(channel, volume);

            omni.fGlobal["$pref::SFX::channelVolume[" + channel + "]"] = volume;

            if (omni.sGlobal["$AudioTestHandle"].isObject())
                {
                ((SFXDescription) omni.sGlobal["$AudioTestDescription"])["volume"] = volume.AsString();
                omni.fGlobal["$AudioTestHandle"] = omni.Util.sfxPlayOnce(omni.sGlobal["$AudioTestDescription"], "art/sound/ui/volumeTest.wav");
                }
        }

        [ConsoleInteraction(true)]
        public static void OptMouseSetSensitivity(float value)
        {
            omni.fGlobal["$pref::Input::LinkMouseSensitivity"] = value;
        }
    }
}