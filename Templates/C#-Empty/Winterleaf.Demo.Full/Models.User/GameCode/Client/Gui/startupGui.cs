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

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
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
            iGlobal["$StartupIdx"] = 0;
            // A list of the splash screens and logos
            // to cycle through. Note that they have to
            // be in consecutive numerical order
            startupGui StartupGui = "startupGui";
            if (!"StartupGui".isObject())
                return;
            StartupGui.bitmap0 = "art/gui/background_g";
            StartupGui.logo0 = "art/gui/png";
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
                        StartupLogo.setExtent(new Point2F(this["logoExtent" + mStartupIdx]));

                    StartupLogo.setVisible(true);
                    }
                else
                    StartupLogo.setVisible(false);
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
                    StartupLogoSecondary.setVisible(false);
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
                next();
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
        public static bool operator !=(startupGui ts, string simobjectid)
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
        public static implicit operator string(startupGui ts)
        {
            if (ReferenceEquals(ts, null))
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