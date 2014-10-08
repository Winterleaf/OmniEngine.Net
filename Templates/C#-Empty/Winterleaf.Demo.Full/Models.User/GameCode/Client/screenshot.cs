using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class screenshot
        {
        private static readonly pInvokes omni = new pInvokes();

        public static void initialize()
            {
            omni.iGlobal["$screenshotNumber"] = 0;
            }

        [ConsoleInteraction(true)]
        public static string formatImageNumber(int number)
            {
            string newnumber = number.AsString();

            if (number < 10)
                newnumber = "0" + newnumber;
            if (number < 100)
                newnumber = "0" + newnumber;
            if (number < 1000)
                newnumber = "0" + newnumber;
            if (number < 10000)
                newnumber = "0" + newnumber;

            return newnumber;
            }

        [ConsoleInteraction(true)]
        public static string formatSessionNumber(int number)
            {
            string newnumber = number.AsString();

            if (number < 10)
                newnumber = "0" + newnumber;
            if (number < 100)
                newnumber = "0" + newnumber;
            return newnumber;
            }

        [ConsoleInteraction(true)]
        public static void recordMovie(string movieName, float fps, string encoder)
            {
            if (!"canvas".isObject())
                return;

            if (encoder == "")
                encoder = "THEORA";

            string resolution = ((GuiCanvas) "canvas").getVideoMode();
            omni.Util.startVideoCapture("canvas", movieName, encoder, fps, new Point2I(0, 0));
            }

        [ConsoleInteraction(true)]
        public static void stopMovie()
            {
            omni.Util.stopVideoCapture();
            }

        // This is bound in initializeCommon() to take
        // a screenshot on a keypress.
        [ConsoleInteraction(true)]
        public static void doScreenShot(int val)
            {
            if (val == 0)
                return;

            _screenShot(1);
            }

        [ConsoleInteraction(true)]
        public static void _screenShot(uint tiles, float overlap = 0f)
            {
            if (omni.sGlobal["$pref::Video::screenShotSession"] == "")
                omni.iGlobal["$pref::Video::screenShotSession"] = 0;

            if (omni.iGlobal["$screenshotNumber"] == 0)
                omni.iGlobal["$pref::Video::screenShotSession"]++;

            if (omni.iGlobal["$pref::Video::screenShotSession"] > 999)
                omni.iGlobal["$pref::Video::screenShotSession"] = 1;

            string name = "screenshot_" + formatSessionNumber(omni.iGlobal["$pref::Video::screenShotSession"]) + "-" +
                          formatImageNumber(omni.iGlobal["$screenshotNumber"]);
            name = omni.Util._expandFilename(name);

            omni.iGlobal["$screenshotNumber"]++;

            if ((omni.sGlobal["$pref::Video::screenShotFormat"] == "JPEG") ||
                (omni.sGlobal["$pref::Video::screenShotFormat"] == "JPG"))
                omni.Util.screenShot("screenshots\\" +name, "JPEG", tiles, overlap);
            else
                omni.Util.screenShot("screenshots\\" +name, "PNG", tiles, overlap);
            }

        // This will close the console and take a large format
        // screenshot by tiling the current backbuffer and save
        // it to the root game folder.
        //
        // For instance a tile setting of 4 with a window set to
        // 800x600 will output a 3200x2400 screenshot.
        [ConsoleInteraction(true)]
        public static void tiledScreenShot(uint tiles, float overlap = 0f)
            {
            ((GuiCanvas) "Canvas").popDialog("ConsoleDlg");
            _screenShot(tiles, overlap);
            }
        }
    }