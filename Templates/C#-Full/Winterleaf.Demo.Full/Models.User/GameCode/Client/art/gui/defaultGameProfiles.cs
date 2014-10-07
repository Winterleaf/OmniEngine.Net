using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui
    {
    public class defaultGameProfiles
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void Initialize()
            {
            SingletonCreator ts = new SingletonCreator("GuiControlProfile", "ChatHudEditProfile");
            ts["opaque"] = "false";
            ts["fillColor"] = "255 255 255";
            ts["fillColorHL"] = "128 128 128";
            ts["border"] = "false";
            ts["borderThickness"] = "0";
            ts["borderColor"] = "40 231 240";
            ts["fontColor"] = "40 231 240";
            ts["fontColorHL"] = "40 231 240";
            ts["fontColorNA"] = "128 128 128";
            ts["textOffset"] = "0 2";
            ts["autoSizeWidth"] = "false";
            ts["autoSizeHeight"] = "true";
            ts["tab"] = "true";
            ts["canKeyFocus"] = "true";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "ChatHudTextProfile");
            ts["opaque"] = "false";
            ts["fillColor"] = "255 255 255";
            ts["fillColorHL"] = "128 128 128";
            ts["border"] = "false";
            ts["borderThickness"] = "0";
            ts["borderColor"] = "40 231 240";
            ts["fontColor"] = "40 231 240";
            ts["fontColorHL"] = "40 231 240";
            ts["fontColorNA"] = "128 128 128";
            ts["textOffset"] = "0 0";
            ts["autoSizeWidth"] = "true";
            ts["autoSizeHeight"] = "true";
            ts["tab"] = "true";
            ts["canKeyFocus"] = "true";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "ChatHudMessageProfile");
            ts["fontType"] = "Arial";
            ts["fontSize"] = "16";
            ts["fontColor"] = "44 172 181"; // default color (death msgs, scoring, inventory)
            ts["fontColors[1]"] = "4 235 105"; // client join/drop, tournament mode
            ts["fontColors[2]"] = "219 200 128"; // gameplay, admin/voting, pack/deployable
            ts["fontColors[3]"] = "77 253 95"; // team chat, spam protection message, client tasks
            ts["fontColors[4]"] = "40 231 240"; // global chat
            ts["fontColors[5]"] = "200 200 50 200"; // used in single player game
            // WARNING! Colors 6-9 are reserved for name coloring
            ts["autoSizeWidth"] = "true";
            ts["autoSizeHeight"] = "true";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "ChatHudScrollProfile");
            ts["opaque"] = "false";
            ts["borderThickness"] = "0";
            ts["borderColor"] = "0 255 0";
            ts["bitmap"] = "core/art/gui/images/scrollBar";
            ts["hasBitmapArray"] = "true";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "HudScrollProfile");
            ts["opaque"] = "false";
            ts["border"] = "true";
            ts["borderColor"] = "0 255 0";
            ts["bitmap"] = "core/art/gui/images/scrollBar";
            ts["hasBitmapArray"] = "true";
            ts.Create();


            ts = new SingletonCreator("GuiControlProfile", "ChatHudBorderProfile");
            ts["bitmap"] = "core/art/gui/images/chatHudBorderArray";
            ts["hasBitmapArray"] = "true";
            ts["opaque"] = "false";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "CenterPrintProfile");
            ts["opaque"] = "false";
            ts["fillColor"] = "128 128 128";
            ts["fontColor"] = "0 255 0";
            ts["border"] = "true";
            ts["borderColor"] = "0 255 0";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "CenterPrintProfile");
            ts["opaque"] = "false";
            ts["fontType"] = "Arial";
            ts["fontSize"] = "12";
            ts["fontColor"] = "0 255 0";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "HudTextNormalProfile");
            ts["opaque"] = "false";
            ts["fontType"] = "Arial";
            ts["fontSize"] = "14";
            ts["fontColor"] = "255 255 255";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "HudTextItalicProfile : HudTextNormalProfile");
            ts["fontType"] = "ArialItalic";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "HudTextBoldProfile : HudTextNormalProfile");
            ts["fontType"] = "ArialBold";
            ts.Create();

            ts = new SingletonCreator("GuiControlProfile", "NumericHealthProfile");
            ts["opaque"] = "true";
            ts["justify"] = "center";
            ts["fontType"] = "ArialBold";
            ts["fontSize"] = "32";
            ts["fontColor"] = "255 255 255";
            ts.Create();
            }
        }
    }