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
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using WinterLeaf.Engine.Containers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Client.art.gui
{
    [TypeConverter(typeof (TypeConverterGeneric<ConsoleDlg>))]
    public class ConsoleDlg : GuiControl
    {
        public static void initialize()
        {
            #region GuiControl (ConsoleDlg)        oc_Newobject5

            ObjectCreator oc_Newobject5 = new ObjectCreator("GuiControl", "ConsoleDlg", typeof (ConsoleDlg));
            oc_Newobject5["profile"] = "GuiDefaultProfile";
            oc_Newobject5["horizSizing"] = "right";
            oc_Newobject5["vertSizing"] = "bottom";
            oc_Newobject5["position"] = "0 0";
            oc_Newobject5["extent"] = "640 480";
            oc_Newobject5["minExtent"] = "8 8";
            oc_Newobject5["visible"] = "1";
            oc_Newobject5["helpTag"] = "0";

            #region GuiWindowCtrl (ConsoleDlgWindow)        oc_Newobject4

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCtrl", "ConsoleDlgWindow", typeof (ConsoleDlgWindow));
            oc_Newobject4["isContainer"] = "1";
            oc_Newobject4["AllowPopWindow"] = "1";
            oc_Newobject4["profile"] = "GuiWindowProfile";
            oc_Newobject4["HorizSizing"] = "windowRelative";
            oc_Newobject4["VertSizing"] = "windowRelative";
            oc_Newobject4["AnchorTop"] = "1";
            oc_Newobject4["AnchorBottom"] = "0";
            oc_Newobject4["AnchorLeft"] = "1";
            oc_Newobject4["AnchorRight"] = "0";
            oc_Newobject4["position"] = "0 0";
            oc_Newobject4["extent"] = "640 480";
            oc_Newobject4["minExtent"] = "8 8";
            oc_Newobject4["visible"] = "1";
            oc_Newobject4["helpTag"] = "0";
            oc_Newobject4["text"] = "Console";
            oc_Newobject4["canMove"] = "1";
            oc_Newobject4["canClose"] = "0";
            oc_Newobject4["canMinimize"] = "0";
            oc_Newobject4["canMaximize"] = "0";

            #region GuiConsoleEditCtrl (ConsoleEntry)        oc_Newobject1

            ObjectCreator oc_Newobject1 = new ObjectCreator("GuiConsoleEditCtrl", "ConsoleEntry", typeof (ConsoleEntry));
            oc_Newobject1["profile"] = "ConsoleTextEditProfile";
            oc_Newobject1["horizSizing"] = "width";
            oc_Newobject1["vertSizing"] = "top";
            oc_Newobject1["position"] = "0 462";
            oc_Newobject1["extent"] = "640 18";
            oc_Newobject1["minExtent"] = "8 8";
            oc_Newobject1["visible"] = "1";
            oc_Newobject1["altCommand"] = "ConsoleEntry.eval();";
            oc_Newobject1["helpTag"] = "0";
            oc_Newobject1["maxLength"] = "255";
            oc_Newobject1["historySize"] = "40";
            oc_Newobject1["password"] = "0";
            oc_Newobject1["tabComplete"] = "0";
            oc_Newobject1["sinkAllKeyEvents"] = "1";
            oc_Newobject1["useSiblingScroller"] = "1";

            #endregion

            oc_Newobject4["#Newobject1"] = oc_Newobject1;

            #region GuiScrollCtrl (ConsoleEntryScroll)        oc_Newobject3

            ObjectCreator oc_Newobject3 = new ObjectCreator("GuiScrollCtrl", "ConsoleEntryScroll");
            oc_Newobject3["internalName"] = "Scroll";
            oc_Newobject3["profile"] = "ConsoleScrollProfile";
            oc_Newobject3["horizSizing"] = "width";
            oc_Newobject3["vertSizing"] = "height";
            oc_Newobject3["position"] = "0 20";
            oc_Newobject3["extent"] = "640 442";
            oc_Newobject3["minExtent"] = "8 8";
            oc_Newobject3["visible"] = "1";
            oc_Newobject3["helpTag"] = "0";
            oc_Newobject3["willFirstRespond"] = "1";
            oc_Newobject3["hScrollBar"] = "alwaysOn";
            oc_Newobject3["vScrollBar"] = "alwaysOn";
            oc_Newobject3["lockHorizScroll"] = "false";
            oc_Newobject3["lockVertScroll"] = "false";
            oc_Newobject3["constantThumbHeight"] = "0";
            oc_Newobject3["childMargin"] = "0 0";

            #region GuiConsole ( ConsoleMessageLogView )        oc_Newobject2

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiConsole", "ConsoleMessageLogView", typeof (ConsoleMessageLogView));
            oc_Newobject2["profile"] = "GuiConsoleProfile";
            oc_Newobject2["position"] = "0 0";

            #endregion

            oc_Newobject3["#Newobject2"] = oc_Newobject2;

            #endregion

            oc_Newobject4["#Newobject3"] = oc_Newobject3;

            #endregion

            oc_Newobject5["#Newobject4"] = oc_Newobject4;

            #endregion

            oc_Newobject5.Create();
        }

        [ConsoleInteraction]
        public static void ToggleConsole(bool make)
        {
            if (make)
                {
                if (((ConsoleDlg) "ConsoleDlg").isAwake())
                    ((GuiCanvas) "Canvas").popDialog("consoleDlg");
                else
                    ((GuiCanvas) "Canvas").pushDialog("consoleDlg");
                }
            ((GuiCanvas) "Canvas").checkCursor();
        }

        [ConsoleInteraction]
        public void hideWindow()
        {
            ((GuiScrollCtrl) this.FOT("Scroll")).setVisible(false);
        }

        [ConsoleInteraction]
        public void showWindow()
        {
            ((GuiScrollCtrl) this.FOT("Scroll")).setVisible(true);
        }

        [ConsoleInteraction]
        public void setAlpha(string alpha)
        {
            GuiControlProfile ConsoleScrollProfile = "ConsoleScrollProfile";

            if (alpha == "")
                ConsoleScrollProfile.fillColor = new ColorI(sGlobal["$ConsoleDefaultFillColor"]);
            else
                {
                string p = Util.getWords(sGlobal["$ConsoleDefaultFillColor"], 0, 2) + " " + (alpha.AsFloat()*255.00).AsString();
                ConsoleScrollProfile.fillColor = new ColorI(p);
                }

            GuiControl parent = this["parent"];

            this.resize(0, 0, parent.extent.x, parent.extent.y);
        }

        [TypeConverter(typeof (TypeConverterGeneric<ConsoleDlgWindow>))]
        public class ConsoleDlgWindow : GuiWindowCtrl
        {
            public override void onLoseFocus()
            {
                ((GuiCanvas) "Canvas").popDialog("consoleDlg");
                ((GuiCanvas) "Canvas").checkCursor();
            }

            public override void onGainFocus()
            {
                ((GuiCanvas) "Canvas").pushDialog("consoleDlg", 99);
                ((GuiCanvas) "Canvas").checkCursor();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ConsoleDlgWindow ts, string simobjectid)
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
            public static bool operator !=(ConsoleDlgWindow ts, string simobjectid)
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
            public static implicit operator string(ConsoleDlgWindow ts)
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
            public static implicit operator ConsoleDlgWindow(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ConsoleDlgWindow) Omni.self.getSimObject(simobjectid, typeof (ConsoleDlgWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ConsoleDlgWindow ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ConsoleDlgWindow(int simobjectid)
            {
                return (ConsoleDlgWindow) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleDlgWindow));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ConsoleDlgWindow ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ConsoleDlgWindow(uint simobjectid)
            {
                return (ConsoleDlgWindow) Omni.self.getSimObject(simobjectid, typeof (ConsoleDlgWindow));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ConsoleEntry>))]
        public class ConsoleEntry : GuiConsoleEditCtrl
        {
            [ConsoleInteraction]
            public void eval()
            {
                string text = this.getValue().Trim();
                if (text == "")
                    return;
                // If it's missing a trailing () and it's not a variable,
                // append the parentheses.

                if (Util.strpos(text, "(", 0) == -1 && !Util.isDefined(text))
                    {
                    if (Util.strpos(text, "=", 0) == -1 && Util.strpos(text, " ", 0) == -1)
                        {
                        if (Util.strpos(text, "{", 0) == -1 && Util.strpos(text, "}", 0) == -1)
                            text = text + "()";
                        }
                    }
                // Append a semicolon if need be.
                int pos = text.Length - 1;
                if (Util.strpos(text, ";", pos) == -1 && Util.strpos(text, "}", 0) == -1)
                    text += ";";

                // Turn off warnings for assigning from void
                // and evaluate the snippet.

                bool oldWarnVoidAssignment;
                if (Util.isDefined("$Con::warnVoidAssignment"))
                    oldWarnVoidAssignment = true;
                else
                    oldWarnVoidAssignment = bGlobal["$Con::warnVoidAssignment"];

                bGlobal["$Con::warnVoidAssignment"] = false;

                Util._echo("==>" + text);
                string result = "";

                if (text.StartsWith("function") || text.StartsWith("datablock") || text.StartsWith("foreach(") || text.StartsWith("foreach$(") || text.StartsWith("if(") || text.StartsWith("while(") || text.StartsWith("for(") || text.StartsWith("switch(") || text.StartsWith("switch$("))
                    result = Util.eval("%result = " + text + "return %result;");
                else
                    Util.eval(text);
                bGlobal["$Con::warnVoidAssignment"] = oldWarnVoidAssignment;

                this.setValue("");

                // Echo result.
                if (result != "")
                    Util._echo(result);

                GuiScrollCtrl ConsoleEntryScroll = "ConsoleEntryScroll";
                ConsoleEntryScroll.scrollToBottom();
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ConsoleEntry ts, string simobjectid)
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
            public static bool operator !=(ConsoleEntry ts, string simobjectid)
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
            public static implicit operator string(ConsoleEntry ts)
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
            public static implicit operator ConsoleEntry(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ConsoleEntry) Omni.self.getSimObject(simobjectid, typeof (ConsoleEntry));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ConsoleEntry ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ConsoleEntry(int simobjectid)
            {
                return (ConsoleEntry) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleEntry));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ConsoleEntry ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ConsoleEntry(uint simobjectid)
            {
                return (ConsoleEntry) Omni.self.getSimObject(simobjectid, typeof (ConsoleEntry));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<ConsoleMessageLogView>))]
        public class ConsoleMessageLogView : GuiConsole
        {
            public virtual void onMessageSelected(string level, string message)
            {
                //Not needed anymore, since there is no more script.
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(ConsoleMessageLogView ts, string simobjectid)
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
            public static bool operator !=(ConsoleMessageLogView ts, string simobjectid)
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
            public static implicit operator string(ConsoleMessageLogView ts)
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
            public static implicit operator ConsoleMessageLogView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (ConsoleMessageLogView) Omni.self.getSimObject(simobjectid, typeof (ConsoleMessageLogView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(ConsoleMessageLogView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator ConsoleMessageLogView(int simobjectid)
            {
                return (ConsoleMessageLogView) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleMessageLogView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(ConsoleMessageLogView ts)
            {
                return (uint) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator ConsoleMessageLogView(uint simobjectid)
            {
                return (ConsoleMessageLogView) Omni.self.getSimObject(simobjectid, typeof (ConsoleMessageLogView));
            }

            #endregion
        }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ConsoleDlg ts, string simobjectid)
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
        public static bool operator !=(ConsoleDlg ts, string simobjectid)
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
        public static implicit operator string(ConsoleDlg ts)
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
        public static implicit operator ConsoleDlg(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ConsoleDlg) Omni.self.getSimObject(simobjectid, typeof (ConsoleDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ConsoleDlg ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ConsoleDlg(int simobjectid)
        {
            return (ConsoleDlg) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleDlg));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ConsoleDlg ts)
        {
            return (uint) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ConsoleDlg(uint simobjectid)
        {
            return (ConsoleDlg) Omni.self.getSimObject(simobjectid, typeof (ConsoleDlg));
        }

        #endregion
    }
}