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
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    public class oculusVR
    {
        // Only load these functions if an Oculus VR device is present
        [ConsoleInteraction(true)]
        public static string oculusSensorMetricsCallback()
        {
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return "";

            return "  | OVR Sensor 0 |" + "  rot: " + pInvokes.Util._call("getOVRSensorEulerRotation", "0");
        }

        // Call this function from createCanvas() to have the Canvas attach itself
        // to the Rift's display.  The Canvas' window will still open on the primary
        // display if that is different from the Rift, but it will move to the Rift
        // when it goes full screen.  If the Rift is not connected then nothing
        // will happen.
        [ConsoleInteraction(true)]
        public static void pointCanvasToOculusVRDisplay()
        {
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return;
            pInvokes.sGlobal["$pref::Video::displayOutputDevice"] = pInvokes.Util._call("getOVRHMDDisplayDeviceName", "0");
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
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return;
            pInvokes.Util._call("setOVRHMDAsGameConnectionDisplayDevice", gameConnection);
            ((GameConnection) "PlayGui")["renderStyle"] = "stereo side by side";

            if (trueStereoRendering)
                ((PostEffect) "OVRBarrelDistortionPostFX")["isEnabled"] = "true";
            else
                ((PostEffect) "OVRBarrelDistortionMonoPostFX")["isEnabled"] = "true";

            // Reset all sensors
            pInvokes.Util._call("ovrResetAllSensors");
        }

        // Call this function when ever you wish to turn off the stereo rendering
        // and barrel distortion for the Rift.
        [ConsoleInteraction(true)]
        public static void disableOculusVRDisplay(GameConnection gameConnection)
        {
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return;
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
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return;
            gameConnection.setControlSchemeParameters(true, true, pInvokes.Util._call("isOVRHMDSimulated", "0").AsBool());
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
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return;
            Point2I res = new Point2I(pInvokes.Util._call("getOVRHMDResolution", "0"));
            ((GuiCanvas) "canvas").setVideoMode((uint) res.x, (uint) res.y, fullscreen.AsBool(), 32, 4);
        }

        // Reset all Oculus Rift sensors.  This will make the Rift's current heading
        // be considered the origin.
        [ConsoleInteraction(true)]
        public static void resetOculusVRSensors()
        {
            if (!pInvokes.Util.isFunction("isOculusVRDeviceActive"))
                return;
            pInvokes.Util._call("ovrResetAllSensors");
        }
    }
}
