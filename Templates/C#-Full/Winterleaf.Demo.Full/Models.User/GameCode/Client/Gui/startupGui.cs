using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui
    {
    [TypeConverter(typeof (TypeConverterGeneric<startupGui>))]
    internal class startupGui : GuiFadeinBitmapCtrl
        {
        
        private int mStartupIdx = 0;

        public string bitmap0
            {
            get { return this["bitmap0"]; }
            set { this["bitmap0"] = value; }
            }

        public string logo0
            {
            get { return this["logo0"]; }
            set { this["logo0"] = value; }
            }

        public Point2I logoPos0
            {
            get { return new Point2I(this["logoPos0"]); }
            set { this["logoPos0"] = value.AsString(); }
            }

        public Point2I logoExtent0
            {
            get { return new Point2I(this["logoExtent0"]); }
            set { this["logoExtent0"] = value.AsString(); }
            }

        public new bool done
            {
            get { return this["done"].AsBool(); }
            set { this["done"] = value.AsString(); }
            }

        public static void initialize()
            {
            #region GuiFadeinBitmapCtrl (StartupGui)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiFadeinBitmapCtrl", "StartupGui", typeof (startupGui));
            oc_Newobject3["canSaveDynamicFields"] = "0";
            oc_Newobject3["Enabled"] = "1";
            oc_Newobject3["isContainer"] = "1";
            oc_Newobject3["Profile"] = "GuiInputCtrlProfile";
            oc_Newobject3["HorizSizing"] = "right";
            oc_Newobject3["VertSizing"] = "bottom";
            oc_Newobject3["position"] = "0 0";
            oc_Newobject3["Extent"] = "800 600";
            oc_Newobject3["MinExtent"] = "8 8";
            oc_Newobject3["canSave"] = "1";
            oc_Newobject3["Visible"] = "1";
            oc_Newobject3["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject3["hovertime"] = "1000";
            oc_Newobject3["bitmap"] = "";
            oc_Newobject3["wrap"] = "0";
            oc_Newobject3["fadeinTime"] = "1000";
            oc_Newobject3["waitTime"] = "4000";
            oc_Newobject3["fadeoutTime"] = "1000";
            oc_Newobject3["done"] = "1";

            #region GuiBitmapButtonCtrl ()        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject1["canSaveDynamicFields"] = "1";
            oc_Newobject1["internalName"] = "StartupLogo";
            oc_Newobject1["Enabled"] = "1";
            oc_Newobject1["autoFitExtents"] = "1";
            oc_Newobject1["isContainer"] = "0";
            oc_Newobject1["Profile"] = "GuiDefaultProfile";
            oc_Newobject1["HorizSizing"] = "center";
            oc_Newobject1["VertSizing"] = "center";
            oc_Newobject1["position"] = "399 302";
            oc_Newobject1["Extent"] = "253  253";
            oc_Newobject1["MinExtent"] = "8 2";
            oc_Newobject1["canSave"] = "1";
            oc_Newobject1["Visible"] = "1";
            oc_Newobject1["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject1["hovertime"] = "1000";
            oc_Newobject1["bitmap"] = "";
            oc_Newobject1["wrap"] = "0";
            oc_Newobject1["command"] = "StartupGui.click();";

            #endregion

            oc_Newobject3["#Newobject1"] = oc_Newobject1;

            #region GuiBitmapButtonCtrl ()        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiBitmapButtonCtrl", "");
            oc_Newobject2["canSaveDynamicFields"] = "1";
            oc_Newobject2["internalName"] = "StartupLogoSecondary";
            oc_Newobject2["Enabled"] = "1";
            oc_Newobject2["isContainer"] = "0";
            oc_Newobject2["Profile"] = "GuiDefaultProfile";
            oc_Newobject2["HorizSizing"] = "left";
            oc_Newobject2["VertSizing"] = "top";
            oc_Newobject2["position"] = "275 440";
            oc_Newobject2["Extent"] = "530 171";
            oc_Newobject2["MinExtent"] = "8 2";
            oc_Newobject2["canSave"] = "1";
            oc_Newobject2["Visible"] = "1";
            oc_Newobject2["tooltipprofile"] = "GuiToolTipProfile";
            oc_Newobject2["hovertime"] = "1000";
            oc_Newobject2["bitmap"] = "";
            oc_Newobject2["wrap"] = "0";
            oc_Newobject2["command"] = "StartupGui.click();";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject3.Create();
            }


        public override bool OnFunctionNotFoundCallTorqueScript()
            {
            return false;
            }

        public static void loadStartup()
            {
            // The index of the current splash screen
            omni.iGlobal["$StartupIdx"] = 0;
            // A list of the splash screens and logos
            // to cycle through. Note that they have to
            // be in consecutive numerical order
            startupGui StartupGui = "startupGui";
            if (!"StartupGui".isObject())
                return;
            StartupGui.bitmap0 = "art/gui/background_g";
            StartupGui.logo0 = "art/gui/omni.png";
            StartupGui.logoPos0 = new Point2I(178, 251);
            StartupGui.logoExtent0 = new Point2I(443, 139);
            // Call the next() function to set our firt
            // splash screen

            StartupGui.next();

            // Play our startup sound
            //SFXPlayOnce(AudioGui, "art/sound/gui/startup");//SFXPlay(startsnd);
            }

        public override void click()
            {
            done = true;
            onDone();
            }

        public void next()
            {
            // Set us to a blank screen while we load the next one
            GuiCanvas Canvas = "Canvas";
            Canvas.setContent("BlankGui");
            // Set our bitmap and reset the done variable

            this.setBitmapX(this["bitmap" + mStartupIdx]);
            done = false;

            // If we have a logo then set it
            GuiBitmapButtonCtrl StartupLogo = findObjectByInternalName("StartupLogo", false);


            if (StartupLogo.isObject())
                {
                if (this["logo" + mStartupIdx] != "")
                    {
                    StartupLogo.setBitmap(this["logo" + mStartupIdx]);
                    if (this["logoPos" + mStartupIdx] != "")
                        {
                        Point2I logoPos = new Point2I(this["logoPos" + mStartupIdx]);
                        StartupLogo.setPosition(logoPos.x, logoPos.y);
                        }
                    if (this["logoExtent" + mStartupIdx] != "")
                        StartupLogo.setExtent(new Point2F( this["logoExtent" + mStartupIdx]));

                    StartupLogo.setVisible(true);
                    }
                else
                    {
                    StartupLogo.setVisible(false);
                    }
                }

            GuiBitmapButtonCtrl StartupLogoSecondary = findObjectByInternalName("StartupLogoSecondary", false);
            if (StartupLogoSecondary.isObject())
                {
                if (this["seclogo" + mStartupIdx] != "")
                    {
                    StartupLogoSecondary.setBitmap(this["seclogo" + mStartupIdx]);
                    if (this["seclogoPos" + mStartupIdx] != "")
                        {
                        Point2I logoPos = new Point2I(this["seclogoPos" + mStartupIdx]);
                        StartupLogoSecondary.setPosition(logoPos.x, logoPos.y);
                        }
                    if (this["seclogoExtent" + mStartupIdx] != "")
                        StartupLogoSecondary.setExtent(new Point2F(this["seclogoExtent" + mStartupIdx]));

                    StartupLogoSecondary.setVisible(true);
                    }
                else
                    {
                    StartupLogoSecondary.setVisible(false);
                    }
                }

            mStartupIdx++;

            ((GuiCanvas) "Canvas").setContent(this);
            }

        public override void onDone()
            {
            if (!done)
                return;
            if (this["bitmap" + mStartupIdx] == "")
                {
                done = true;
                init.loadMainMenu();
                }
            else
                {
                next();
                }
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(startupGui ts, string simobjectid)
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
        public static bool operator !=(startupGui ts, string simobjectid)
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
        public static implicit operator string(startupGui ts)
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
        public static implicit operator startupGui(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (startupGui) Omni.self.getSimObject(simobjectid, typeof (startupGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(startupGui ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator startupGui(int simobjectid)
            {
            return (startupGui) Omni.self.getSimObject((uint) simobjectid, typeof (startupGui));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(startupGui ts)
            {
            return (uint) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator startupGui(uint simobjectid)
            {
            return (startupGui) Omni.self.getSimObject(simobjectid, typeof (startupGui));
            }

        #endregion
        }
    }