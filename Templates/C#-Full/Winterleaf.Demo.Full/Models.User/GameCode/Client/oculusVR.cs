using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
    {
    public class oculusVR
        {
        private static readonly pInvokes omni = new pInvokes();

        // Only load these functions if an Oculus VR device is present
        [ConsoleInteraction(true)]
        public static string oculusSensorMetricsCallback()
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return "";

            return "  | OVR Sensor 0 |" + "  rot: " + omni.Util._call("getOVRSensorEulerRotation", "0");
            }

        // Call this function from createCanvas() to have the Canvas attach itself
        // to the Rift's display.  The Canvas' window will still open on the primary
        // display if that is different from the Rift, but it will move to the Rift
        // when it goes full screen.  If the Rift is not connected then nothing
        // will happen.
        [ConsoleInteraction(true)]
        public static void pointCanvasToOculusVRDisplay()
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return;
            omni.sGlobal["$pref::Video::displayOutputDevice"] = omni.Util._call("getOVRHMDDisplayDeviceName", "0");
            }

        // Call this function from GameConnection::initialControlSet() just before
        // your "Canvas.setContent(PlayGui);" call, or at any time you wish to switch
        // to a side-by-side rendering and the appropriate barrel distortion.  This
        // will turn on side-by-side rendering and tell the GameConnection to use the
        // Rift as its display device.
        // Parameters:
        // %gameConnection - The client GameConnection instance
        // %trueStereoRendering - If true will enable stereo rendering with an eye
        // offset for each viewport.  This will render each frame twice.  If false
        // then a pseudo stereo rendering is done with only a single render per frame.
        [ConsoleInteraction(true)]
        public static void enableOculusVRDisplay(GameConnection gameConnection, bool trueStereoRendering)
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return;
            omni.Util._call("setOVRHMDAsGameConnectionDisplayDevice", gameConnection);
            ((GameConnection) "PlayGui")["renderStyle"] = "stereo side by side";

            if (trueStereoRendering)
                ((PostEffect) "OVRBarrelDistortionPostFX")["isEnabled"] = "true";
            else
                ((PostEffect) "OVRBarrelDistortionMonoPostFX")["isEnabled"] = "true";

            // Reset all sensors
            omni.Util._call("ovrResetAllSensors");
            }

        // Call this function when ever you wish to turn off the stereo rendering
        // and barrel distortion for the Rift.
        [ConsoleInteraction(true)]
        public static void disableOculusVRDisplay(GameConnection gameConnection)
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return;
            gameConnection.clearDisplayDevice();
            ((GameConnection) "PlayGui")["renderStyle"] = "standard";
            ((PostEffect) "OVRBarrelDistortionPostFX")["isEnabled"] = "false";
            ((PostEffect) "OVRBarrelDistortionChromaPostFX")["isEnabled"] = "false";
            ((PostEffect) "OVRBarrelDistortionMonoPostFX")["isEnabled"] = "false";
            }

        // Helper function to set the standard Rift control scheme.  You could place
        // this function in GameConnection::initialControlSet() at the same time
        // you call enableOculusVRDisplay().
        [ConsoleInteraction(true)]
        public static void setStandardOculusVRControlScheme(GameConnection gameConnection)
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return;
            gameConnection.setControlSchemeParameters(true, true, omni.Util._call("isOVRHMDSimulated", "0").AsBool());
            }

        //-----------------------------------------------------------------------------

        // Helper function to set the resolution for the Rift.
        // Parameters:
        // %fullscreen - If true then the display will be forced to full screen.  If
        // pointCanvasToOculusVRDisplay() was called before the Canvas was created, then
        // the full screen display will appear on the Rift.
        [ConsoleInteraction(true)]
        public static void setVideoModeForOculusVRDisplay(string fullscreen)
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return;
            Point2I res = new Point2I(omni.Util._call("getOVRHMDResolution", "0"));
            ((GuiCanvas) "canvas").setVideoMode((uint)res.x, (uint)res.y, fullscreen.AsBool(), 32, 4);
            }

        // Reset all Oculus Rift sensors.  This will make the Rift's current heading
        // be considered the origin.
        [ConsoleInteraction(true)]
        public static void resetOculusVRSensors()
            {
            if (!omni.Util.isFunction("isOculusVRDeviceActive")) return;
            omni.Util._call("ovrResetAllSensors");
            }
        }
    }