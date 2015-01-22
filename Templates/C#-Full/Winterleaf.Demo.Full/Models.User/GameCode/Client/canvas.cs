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

#region

using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client
{
    public class canvas : GuiCanvas
    {
        public override void onWindowClose()
        {
            //If they close this canvas then quit.
            Main.Quit();
        }

        public new static void initialize()
        {
            omni.bGlobal["$canvasCreated"] = false;
        }

        public static void initializeCanvas()
        {
            if (omni.bGlobal["$canvasCreated"])
                {
                omni.console.error("Cannot instantiate more than one canvas!");
                return;
                }

            if (!createCanvas(omni.sGlobal["$appName"]))
                {
                omni.console.error("Canvas creation failed. Shutting down.");
                Main.Quit();
                //t3d.Util.quit();
                }
            omni.bGlobal["$canvasCreated"] = true;
        }

        public static bool createCanvas(string windowTitle)
        {
            if (omni.bGlobal["$isDedicated"])
                {
                omni.console.Call_Classname("GFXInit", "createNullDevice");
                return true;
                }
            // Create the Canvas

            GuiCanvas canvas = new ObjectCreator("GuiCanvas", "Canvas", typeof (canvas)).Create();

            if (canvas.isObject())
                canvas.setWindowTitle(omni.Util.getEngineName() + " - " + omni.sGlobal["$appName"]);
            return true;
        }

        [ConsoleInteraction(true)]
        public static void configureCanvas()
        {
            if (omni.sGlobal["$pref::Video::Canvas::mode"] == "")
                omni.sGlobal["$pref::Video::Canvas::mode"] = "1024 768 false 32 60 4";

            string resolution = omni.sGlobal["$pref::Video::Canvas::mode"];
            float resX = resolution.Split(' ')[omni.iGlobal["$WORD::RES_X"]].AsFloat();
            float resY = resolution.Split(' ')[omni.iGlobal["$WORD::RES_Y"]].AsFloat();
            string fs = resolution.Split(' ')[omni.iGlobal["$WORD::FULLSCREEN"]];
            string bpp = resolution.Split(' ')[omni.iGlobal["$WORD::BITDEPTH"]];
            string rate = resolution.Split(' ')[omni.iGlobal["$WORD::REFRESH"]];
            string fsaa = resolution.Split(' ')[omni.iGlobal["$WORD::AA"]];

            omni.console.print("--------------");
            omni.console.print("Attempting to set resolution to \"" + resolution + "\"");

            Point3F deskRes = omni.Util.getDesktopResolution();
            float deskResX = deskRes.x;
            float deskResY = deskRes.y;
            float deskResBPP = deskRes.z;

            // We shouldn't be getting this any more but just in case...
            if (bpp == "Default")
                bpp = deskResBPP.AsString();

            // Make sure we are running at a valid resolution
            if (!fs.AsBool())
                {
                // Windowed mode has to use the same bit depth as the desktop
                if (resX >= deskResX || resY >= deskResY)
                    {
                    omni.Util._warn("Warning: The requested windowed resolution is equal to or larger than the current desktop resolution. Attempting to find a better resolution");

                    int resCount = ((GuiCanvas) "Canvas").getModeCount();
                    for (int i = (resCount - 1); i >= 0; i--)
                        {
                        string testRes = ((GuiCanvas) "Canvas").getMode(i);
                        float testResX = testRes.Split(' ')[omni.iGlobal["$WORD::RES_X"]].AsFloat();
                        float testResY = testRes.Split(' ')[omni.iGlobal["$WORD::RES_Y"]].AsFloat();
                        string testBPP = testRes.Split(' ')[omni.iGlobal["$WORD::BITDEPTH"]];

                        if (testBPP.AsInt() != bpp.AsInt())
                            continue;

                        if ((testResX >= deskResX) || (testResY >= deskResY))
                            continue;
                        // This will work as our new resolution
                        resX = testResX;
                        resY = testResY;

                        omni.Util._warn("Warning: Switching to \"" + resX + " " + resY + " " + bpp + "\"");
                        break;
                        }
                    }
                }

            omni.sGlobal["$pref::Video::Canvas::mode"] = resX + " " + resY + " " + fs + " " + bpp + " " + rate + " " + fsaa;

            string fsLabel = "No";
            if (fs.AsBool())
                fsLabel = "Yes";

            omni.console.print("Accepted Mode: ");
            omni.console.print("--Resolution : " + resX + " " + resY);
            omni.console.print("--Full Screen : " + fsLabel);
            omni.console.print("--Bits Per Pixel : " + bpp);
            omni.console.print("--Refresh Rate : " + rate);
            omni.console.print("--FSAA Level : " + fsaa);
            omni.console.print("--------------");

            // Actually set the new video mode
            ((GuiCanvas)"Canvas").setVideoMode((uint)resX, (uint)resY, fs.AsBool(), bpp.AsUint(), rate.AsUint(), fsaa.AsUint());

            // FXAA piggybacks on the FSAA setting in $pref::Video::mode.
            if ("FXAA_PostEffect".isObject())
                ((PostEffect) "FXAA_PostEffect").isEnabled = (fsaa.AsInt() > 0);
        }

        [ConsoleInteraction(true)]
        public static void resetCanvas()
        {
            if ("Canvas".isObject())
                ((GuiCanvas) "Canvas").repaint(-1);
        }

        public override void onResize(string width, string height)
        {
            ((ConsoleDlg) "ConsoleDlg").extent = new Point2I(width.AsInt(), height.AsInt());
            ((ConsoleDlg.ConsoleDlgWindow) "ConsoleDlgWindow").extent = new Point2I(width.AsInt(), height.AsInt());
            ((GuiScrollCtrl) "ConsoleEntryScroll").extent = new Point2I(width.AsInt(), (height.AsInt() - 38));
            ((GuiConsoleEditCtrl) "ConsoleEntry").position = new Point2I(0, (height.AsInt() - 18));
            ((GuiConsoleEditCtrl) "ConsoleEntry").extent = new Point2I(width.AsInt(), 18);
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(canvas ts, string simobjectid)
        {
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
        public static bool operator !=(canvas ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(canvas ts)
        {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator canvas(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (canvas) Omni.self.getSimObject(simobjectid, typeof (canvas));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(canvas ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator canvas(int simobjectid)
        {
            return (canvas) Omni.self.getSimObject((uint) simobjectid, typeof (canvas));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(canvas ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator canvas(uint simobjectid)
        {
            return (canvas) Omni.self.getSimObject(simobjectid, typeof (canvas));
        }

        #endregion
    }
}