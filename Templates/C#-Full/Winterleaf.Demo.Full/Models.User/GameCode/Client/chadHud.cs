using System;
using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    [TypeConverter(typeof (TypeConverterGeneric<chatHud>))]
    public class chatHud : GuiMessageVectorCtrl
        {
        

        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void initialize()
            {
            //-----------------------------------------------------------------------------
            // Message Hud
            //-----------------------------------------------------------------------------

            // chat hud sizes in lines
            omni.iGlobal["$outerChatLenY[1]"] = 4;
            omni.iGlobal["$outerChatLenY[2]"] = 9;
            omni.iGlobal["$outerChatLenY[3]"] = 13;
            omni.iGlobal["$LastHudTarget"] = 0;

            // Only play sound files that are <= 5000ms in length.
            omni.iGlobal["$MaxMessageWavLength"] = 5000;
            //new MessageVector(HudMessageVector);
            ObjectCreator oc = new ObjectCreator("MessageVector", "HudMessageVector");
            oc.Create();
            }

        public void AddLine(string text)
            {
            int textHeight = console.GetVarInt(string.Format("{0}.profile.fontSize", this)) +
                             console.GetVarInt(string.Format("{0}.lineSpacing", this));
            if (textHeight <= 0)
                textHeight = 12;

            string scrollBox = getGroup();
            //See if the two are eqaul, and if they are use the split instead of the getword.
            //int chatScrollHeight = Util.getWord(con.GetVarString(string.Format("{0}.extent", scrollBox)), 1).AsInt() -
            //                       2 * con.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));

            int chatScrollHeight = console.GetVarString(string.Format("{0}.extent", scrollBox)).Split(' ')[1].AsInt() -
                                   2*console.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));

            int chatPosition = Util.getWord(console.GetVarString(string.Format("{0}.extent", this)), 1).AsInt() -
                               chatScrollHeight +
                               Util.getWord(console.GetVarString(string.Format("{0}.position", this)), 1).AsInt() -
                               console.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));

            int linesToScroll = (int) Math.Floor(((chatPosition)/((double) textHeight) + .5));

            string origPosition = "";
            if (linesToScroll > 0)
                origPosition = console.GetVarString(string.Format("{0}.position", this));


            GuiButtonCtrl chatPageDown = "chatPageDown";
            MessageVector HudMessageVector = "HudMessageVector";
            //remove old messages from the top only if scrolled down all the way
            while (!chatPageDown.isVisible() && HudMessageVector.getNumLines() > 0 &&
                   HudMessageVector.getNumLines() >= iGlobal["$pref::HudMessageLogSize"])
                {
                string tag = ((MessageVector) "HudMessageVector").getLineTag(0).AsString();
                if (tag.AsInt() != 0)
                    tag.delete();
                ((MessageVector) "HudMessageVector").popFrontLine();
                }
            //add the message...
            ((MessageVector) "HudMessageVector").pushBackLine(text, console.GetVarInt("$LastHudTarget"));
            console.SetVar("$LastHudTarget", 0);
            //now that we've added the message, see if we need to reset the position
            if (linesToScroll > 0)
                {
                ((GuiControl) "ChatPageDown").setVisible(true);
                console.SetVar(this + ".position", origPosition);
                }
            else
                ((GuiControl) "ChatPageDown").setVisible(false);
            }

        public void PageUp()
            {
            int textHeight = console.GetVarInt(string.Format("{0}.profile.fontSize", this)) +
                             console.GetVarInt(string.Format("{0}.lineSpacing", this));
            if (textHeight <= 0)
                textHeight = 12;

            string scrollBox = getGroup();
            int chatScrollHeight = console.GetVarString(string.Format("{0}.extent", scrollBox)).Split(' ')[1].AsInt() -
                                   2*console.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));
            if (chatScrollHeight <= 0)
                return;

            int pageLines = (int) Math.Floor(chatScrollHeight/(double) textHeight) - 1;
            if (pageLines <= 0)
                pageLines = 1;

            // See how many lines we actually can scroll up:
            int chatPosition = -1*console.GetVarString(string.Format("{0}.position", this)).Split('0')[1].AsInt() -
                               console.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));
            int linesToScroll = (int) (Math.Floor(chatPosition/(double) textHeight) + .5);
            if (linesToScroll <= 0)
                return;

            int scrollLines = 0;
            scrollLines = linesToScroll > pageLines ? pageLines : linesToScroll;

            string position = console.GetVarString(this + ".position");

            // Now set the position
            console.SetVar(string.Format("{0}.position", this),
                string.Format("{0} {1} {2}", position.Split(' ')[0], position.Split(' ')[1],
                    (scrollLines*textHeight).AsString()));
            // Display the pageup icon
            ((GuiControl) "ChatPageDown").setVisible(true);
            }

        public void PageDown()
            {
            int textHeight = console.GetVarInt(string.Format("{0}.profile.fontSize", this)) +
                             console.GetVarInt(string.Format("{0}.lineSpacing", this));
            if (textHeight <= 0)
                textHeight = 12;

            string scrollBox = getGroup();

            //int chatScrollHeight = Util.getWord(con.GetVarString(string.Format("{0}.extent", scrollBox)), 1).AsInt() -
            //                       2 * con.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));
            int chatScrollHeight = console.GetVarString(string.Format("{0}.extent", scrollBox)).Split(' ')[1].AsInt() -
                                   2*console.GetVarInt(string.Format("{0}.profile.borderThickness", scrollBox));
            if (chatScrollHeight <= 0)
                return;

            int pageLines = (int) Math.Floor(chatScrollHeight/(double) textHeight) - 1;
            if (pageLines <= 0)
                pageLines = 1;

            int chatPosition = console.GetVarString(this + ".extent").Split(' ')[1].AsInt() - chatScrollHeight +
                               console.GetVarString(this + ".position").Split(' ')[1].AsInt() -
                               console.GetVarInt(scrollBox + ".profile.borderThickness");

            int linesToScroll = (int) (Math.Floor(chatScrollHeight/(double) textHeight) + .5);
            if (linesToScroll <= 0)
                return;

            int scrollLines = linesToScroll > pageLines ? pageLines : linesToScroll;

            // Now set the position
            string pos = this["position"];
            console.SetVar(string.Format("{0}.position", this),
                string.Format("{0} {1}", pos.Split(' ')[0],
                    (pos.Split(' ')[1].AsInt() - (scrollLines*textHeight)).AsString()));

            // See if we have should (still) display the pagedown icon
            ((GuiControl) "ChatPageDown").setVisible(scrollLines < linesToScroll ? true : false);
            }

        // Helper function to play a sound file if the message indicates.
        // Returns starting position of wave file indicator.
        public static int PlayMessageSound(string message, string voice, string pitch)
            {
            int wavstart = omni.Util.strstr(message, "~w");
            if (wavstart == -1)
                return -1;

            string wav = message.Substring(wavstart + 2, 1000);

            string wavFile = voice != ""
                ? string.Format("art/sound/voice/{0}/{1}", voice, wav)
                : string.Format("art/sound/{0}", wav);

            string wavSource = "";

            // XXX This only expands to a single filepath, of course; it
            // would be nice to support checking in each mod path if we
            // have multiple mods active.

            if (omni.Util.strstr(wavFile, ".wav") != wavFile.Length - 4)
                wavFile = wavFile + ".wav";

            wavSource = omni.Util._expandFilename(wavFile);

            if (wavSource.isObject())
                {
                    {
                    int wavLengthMs = omni.console.Call(wavSource, "getDuration").AsInt()*pitch.AsInt();

                    if (wavLengthMs == 0)
                        omni.console.error(string.Format(
                            "** WAV file \"{0}\" is nonexistent or sound is zero-length **", wavFile));
                    else if (wavLengthMs <= omni.console.GetVarInt("$MaxMessageWavLength"))
                        {
                        if (omni.console.isObject("$ClientChatHandle[0]"))
                            omni.sGlobal["$ClientChatHandle[0]"].delete();

                        omni.console.SetVar("$ClientChatHandle[0]", wavSource);

                        if (pitch.AsInt() != 1)
                            omni.console.Call("$ClientChatHandle[0]", "setPitch", new[] {pitch});

                        omni.console.Call("$ClientChatHandle[0]", "play");
                        }
                    else
                        {
                        omni.console.error(string.Format("** WAV file \"{0}\" is too long **", wavFile));
                        }
                    }
                }
            else
                {
                omni.console.error(string.Format("** Unable to load WAV file : \"{0}\" **", wavFile));
                }
            return wavstart;
            }

        public static void OnChatMessage(string message, string voice, string pitch)
            {
            // XXX Client objects on the server must have voiceTag and voicePitch
            // fields for values to be passed in for %voice and %pitch... in
            // this example mod, they don't have those fields.

            // Clients are not allowed to trigger general game sounds with their
            // chat messages... a voice directory MUST be specified.

            if (voice == "")
                voice = "default";

            // See if there's a sound at the end of the message, and play it.
            int wavStart = PlayMessageSound(message, voice, pitch);
            if (wavStart != -1)
                message = message.Substring(0, wavStart);

            if (message.Trim() != "")
                ((chatHud) "ChatHud").AddLine(message);
            }

        [ConsoleInteraction(true)]
        public static void OnServerMessage(string message)
            {
            int wavStart = PlayMessageSound(message, "", "");
            if (wavStart != -1)
                message = message.Substring(0, wavStart);

            if (message.Trim() != "")
                ((chatHud) "ChatHud").AddLine(message);
            }

        [ConsoleInteraction(true)]
        public static void PageUpMessageHud()
            {
            ((chatHud) "ChatHud").PageUp();
            }

        [ConsoleInteraction(true)]
        public static void PageDownMessageHud()
            {
            ((chatHud) "ChatHud").PageDown();
            }

        [ConsoleInteraction(true)]
        public static void CycleMessageHudSize()
            {
            ((MainChatHud) "MainChatHud").nextChatHudLen();
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(chatHud ts, string simobjectid)
            {
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            return base.GetHashCode();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(chatHud ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(chatHud ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator chatHud(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (chatHud) Omni.self.getSimObject(simobjectid, typeof (chatHud));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(chatHud ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator chatHud(int simobjectid)
            {
            return (chatHud) Omni.self.getSimObject((uint) simobjectid, typeof (chatHud));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(chatHud ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator chatHud(uint simobjectid)
            {
            return (chatHud) Omni.self.getSimObject(simobjectid, typeof (chatHud));
            }

        #endregion
        }
    }