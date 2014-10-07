using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Audio;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

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
                omni.fGlobal["$AudioTestHandle"] = omni.Util.sfxPlayOnce(omni.sGlobal["$AudioTestDescription"],
                    "art/sound/ui/volumeTest.wav");
                }
            }

        [ConsoleInteraction(true)]
        public static void OptMouseSetSensitivity(float value)
            {
            omni.fGlobal["$pref::Input::LinkMouseSensitivity"] = value;
            }
        }
    }