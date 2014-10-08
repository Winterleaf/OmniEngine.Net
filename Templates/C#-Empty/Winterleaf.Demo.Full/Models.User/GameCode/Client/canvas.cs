#region

using WinterLeaf.Demo.Full.Models.User.GameCode;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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
                    omni.Util._warn(
                        "Warning: The requested windowed resolution is equal to or larger than the current desktop resolution. Attempting to find a better resolution");

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

            omni.sGlobal["$pref::Video::Canvas::mode"] = resX + " " + resY + " " + fs + " " + bpp + " " + rate + " " +
                                                         fsaa;

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
            ((GuiCanvas) "Canvas").setVideoMode((uint)resX, (uint)resY, fs.AsBool(), bpp.AsUint(), rate.AsUint(), fsaa.AsUint());

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
        public static bool operator !=(canvas ts, string simobjectid)
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