using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
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

            ObjectCreator oc_Newobject4 = new ObjectCreator("GuiWindowCtrl", "ConsoleDlgWindow",
                typeof (ConsoleDlgWindow));
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

            ObjectCreator oc_Newobject2 = new ObjectCreator("GuiConsole", "ConsoleMessageLogView",
                typeof (ConsoleMessageLogView));
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
                    {
                    ((GuiCanvas) "Canvas").popDialog("consoleDlg");
                    }
                else
                    {
                    ((GuiCanvas) "Canvas").pushDialog("consoleDlg");
                    }
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
                string p = Util.getWords(sGlobal["$ConsoleDefaultFillColor"], 0, 2) + " " +
                           (alpha.AsFloat()*255.00).AsString();
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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(ConsoleDlgWindow ts)
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
                            {
                            text = text + "()";
                            }
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

                if (
                    text.StartsWith("function") ||
                    text.StartsWith("datablock") ||
                    text.StartsWith("foreach(") ||
                    text.StartsWith("foreach$(") ||
                    text.StartsWith("if(") ||
                    text.StartsWith("while(") ||
                    text.StartsWith("for(") ||
                    text.StartsWith("switch(") ||
                    text.StartsWith("switch$(")
                    )
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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(ConsoleEntry ts)
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
                return object.ReferenceEquals(ts, null)
                    ? object.ReferenceEquals(simobjectid, null)
                    : ts.Equals(simobjectid);
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
                if (object.ReferenceEquals(ts, null))
                    return !object.ReferenceEquals(simobjectid, null);
                return !ts.Equals(simobjectid);
                }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator string(ConsoleMessageLogView ts)
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
                return
                    (ConsoleMessageLogView) Omni.self.getSimObject((uint) simobjectid, typeof (ConsoleMessageLogView));
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
        public static bool operator !=(ConsoleDlg ts, string simobjectid)
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
        public static implicit operator string(ConsoleDlg ts)
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