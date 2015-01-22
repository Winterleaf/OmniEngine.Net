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
        public static void initialize()
        {
            pInvokes.iGlobal["$RemapCount"] = 0;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Forward";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "moveforward";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Backward";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "movebackward";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Strafe Left";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "moveleft";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Strafe Right";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "moveright";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Turn Left";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "turnLeft";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Turn Right";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "turnRight";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Look Up";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "panUp";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Look Down";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "panDown";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Jump";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "jump";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Fire Weapon";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "mouseFire";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Adjust Zoom";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "setZoomFov";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Toggle Zoom";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "toggleZoom";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Free Look";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "toggleFreeLook";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Switch 1st/3rd";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "toggleFirstPerson";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Chat to Everyone";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "toggleMessageHud";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Message Hud PageUp";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "pageMessageHudUp";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Message Hud PageDown";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "pageMessageHudDown";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Resize Message Hud";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "resizeMessageHud";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Show Scores";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "showPlayerList";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Animation - Wave";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "celebrationWave";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Animation - Salute";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "celebrationSalute";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Suicide";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "suicide";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Toggle Camera";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "toggleCamera";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Drop Camera at Player";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "dropCameraAtPlayer";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Drop Player at Camera";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "dropPlayerAtCamera";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;
            pInvokes.sGlobal["$RemapName[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "Bring up Options Dialog";
            pInvokes.sGlobal["$RemapCmd[" + pInvokes.iGlobal["$RemapCount"] + "]"] = "bringUpOptions";
            pInvokes.iGlobal["$RemapCount"] = pInvokes.iGlobal["$RemapCount"] + 1;

            pInvokes.iGlobal["$AudioTestHandle"] = 0;
            // Description to use for playing the volume test sound.  This isn't
            // played with the description of the channel that has its volume changed
            // because we know nothing about the playback state of the channel.  If it
            // is paused or stopped, the test sound would not play then.

            ObjectCreator oc = new ObjectCreator("SFXDescription");
            oc["sourceGroup"] = "AudioChannelMaster";

            pInvokes.sGlobal["$AudioTestDescription"] = oc.Create().AsString();
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
            if (volume == pInvokes.fGlobal["$pref::SFX::masterVolume"])
                return;

            audio.sfxSetMasterVolume(volume);
            pInvokes.fGlobal["$pref::SFX::masterVolume"] = volume;

            if (pInvokes.sGlobal["$AudioTestHandle"].isObject())
                pInvokes.iGlobal["$AudioTestHandle"] = pInvokes.Util.sfxPlayOnce("AudioChannel", "art/sound/ui/volumeTest.wav");
        }

        [ConsoleInteraction(true)]
        public static void OptAudioUpdateChannelVolume(SFXDescription description, float volume)
        {
            string channel = audio.sfxGroupToOldChannel(description["sourceGroup"]);
            if (volume == pInvokes.fGlobal["$pref::SFX::channelVolume[" + channel + "]"])
                return;

            audio.sfxSetChannelVolume(channel, volume);

            pInvokes.fGlobal["$pref::SFX::channelVolume[" + channel + "]"] = volume;

            if (pInvokes.sGlobal["$AudioTestHandle"].isObject())
                {
                ((SFXDescription) pInvokes.sGlobal["$AudioTestDescription"])["volume"] = volume.AsString();
                pInvokes.fGlobal["$AudioTestHandle"] = pInvokes.Util.sfxPlayOnce(pInvokes.sGlobal["$AudioTestDescription"], "art/sound/ui/volumeTest.wav");
                }
        }

        [ConsoleInteraction(true)]
        public static void OptMouseSetSensitivity(float value)
        {
            pInvokes.fGlobal["$pref::Input::LinkMouseSensitivity"] = value;
        }
    }
}
