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
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Debugger.gui.CodeBehind
{
    public class Debugger
    {
        //---------------------------------------------------------------------------------------------
        // onLine is invoked whenever the TCP object receives a line from the server. Treat the first
        // word as a "command" and dispatch to an appropriate handler.
        //---------------------------------------------------------------------------------------------
        private static readonly pInvokes omni = new pInvokes();

        //---------------------------------------------------------------------------------------------
        // Various support functions.
        //---------------------------------------------------------------------------------------------

        // Add a watch expression.
        [ConsoleInteraction]
        public static void DbgWatchDialogAdd()
        {
            GuiTextEditCtrl WatchDialogExpression = "WatchDialogExpression";
            GuiTextListCtrl DebuggerWatchView = "DebuggerWatchView";
            TCPDebugger TCPDebugger = "TCPDebugger";
            DebuggerWatchDlg DebuggerWatchDlg = "DebuggerWatchDlg";
            GuiCanvas Canvas = "Canvas";

            string expr = WatchDialogExpression.getValue();
            if (expr != "")
                {
                DebuggerWatchView.setRowById(omni.iGlobal["$DbgWatchSeq"], expr + "\t(unknown)");
                TCPDebugger.send("EVAL " + omni.iGlobal["$DbgWatchSeq"] + " 0 " + expr + "\r\n");
                omni.iGlobal["$DbgWatchSeq"]++;
                }
            Canvas.popDialog(DebuggerWatchDlg);
        }

        // Edit a watch expression.
        [ConsoleInteraction]
        public static void DbgWatchDialogEdit()
        {
            GuiTextEditCtrl EditWatchDialogValue = "EditWatchDialogValue";
            GuiTextListCtrl DebuggerWatchView = "DebuggerWatchView";
            DebuggerEditWatchDlg DebuggerEditWatchDlg = "DebuggerEditWatchDlg";
            TCPDebugger TCPDebugger = "TCPDebugger";
            GuiCanvas Canvas = "Canvas";

            string newValue = EditWatchDialogValue.getValue();
            int id = DebuggerWatchView.getSelectedId();
            if (id >= 0)
                {
                string row = DebuggerWatchView.getRowTextById(id);
                string expr = omni.Util.getField(row, 0);
                string assignment;
                if (newValue == "")
                    assignment = expr + " = \"\"";
                else
                    assignment = expr + " = " + newValue;
                TCPDebugger.send("EVAL " + id + " 0 " + assignment + "\r\n");
                }
            Canvas.popDialog(DebuggerEditWatchDlg);
        }

        // Set/change the singular "cursor watch" expression.
        [ConsoleInteraction]
        public static void DbgSetCursorWatch(string expr)
        {
            GuiTextCtrl DebuggerCursorWatch = "DebuggerCursorWatch";
            TCPDebugger TCPDebugger = "TCPDebugger";

            DebuggerCursorWatch["expr"] = expr;
            if (DebuggerCursorWatch["expr"] == "")
                DebuggerCursorWatch.setText("");
            else
                TCPDebugger.send("EVAL -1 0 " + DebuggerCursorWatch["expr"] + "\r\n");
        }

        // Connect to the server with the given addr/port/password.
        [ConsoleInteraction]
        public static void DbgConnect()
        {
            TCPDebugger TCPDebugger = "TCPDebugger";
            GuiTextEditCtrl DebuggerConnectAddress = "DebuggerConnectAddress";
            GuiTextEditCtrl DebuggerConnectPort = "DebuggerConnectPort";
            GuiTextEditCtrl DebuggerConnectPassword = "DebuggerConnectPassword";
            DebuggerConnectDlg DebuggerConnectDlg = "DebuggerConnectDlg";
            GuiCanvas Canvas = "Canvas";

            string address = DebuggerConnectAddress.getValue();
            string port = DebuggerConnectPort.getValue();
            string password = DebuggerConnectPassword.getValue();

            if ((address != "") && (port != "") && (password != ""))
                {
                TCPDebugger.connect(address + ":" + port);
                TCPDebugger.schedule("5000", "send", password + "\r\n");
                TCPDebugger["password"] = password;
                }

            Canvas.popDialog(DebuggerConnectDlg);
        }

        // Put a condition on a breakpoint.
        [ConsoleInteraction]
        public static void DbgBreakConditionSet()
        {
            DebuggerBreakConditionDlg DebuggerBreakConditionDlg = "DebuggerBreakConditionDlg";
            DebuggerBreakPoints DebuggerBreakPoints = "DebuggerBreakPoints";
            GuiTextEditCtrl BreakCondition = "BreakCondition";
            GuiTextEditCtrl BreakPassCount = "BreakPassCount";
            GuiTextEditCtrl BreakClear = "BreakClear";
            GuiCanvas Canvas = "Canvas";

            // Read the condition.
            string condition = BreakCondition.getValue();
            string passct = BreakPassCount.getValue();
            string clear = BreakClear.getValue();
            if (condition == "")
                condition = "true";
            if (passct == "")
                passct = "0";
            if (clear == "")
                clear = "false";

            // Set the condition.
            int id = DebuggerBreakPoints.getSelectedId();
            if (id != -1)
                {
                string bkp = DebuggerBreakPoints.getRowTextById(id);
                DbgSetBreakPoint(omni.Util.getField(bkp, 1), omni.Util.getField(bkp, 0).AsUint(), clear.AsBool(), passct, condition);
                }

            Canvas.popDialog(DebuggerBreakConditionDlg);
        }

        // Open a file, go to the indicated line, and optionally select the line.
        [ConsoleInteraction]
        public static void DbgOpenFile(string file, int line, bool selectLine)
        {
            DebuggerFileView DebuggerFileView = "DebuggerFileView";
            TCPDebugger TCPDebugger = "TCPDebugger";

            if (file != "")
                {
                // Open the file in the file view.
                if (DebuggerFileView.open(file))
                    {
                    // Go to the line.
                    DebuggerFileView.setCurrentLine(line, selectLine);
                    // Get the breakpoints for this file.
                    if (file != omni.sGlobal["$DebuggerFile"])
                        {
                        TCPDebugger.send("BREAKLIST " + file + "\r\n");
                        omni.sGlobal["$DebuggerFile"] = file;
                        }
                    }
                }
        }

        // Search in the fileview GUI.
        [ConsoleInteraction]
        public static void DbgFileViewFind()
        {
            DebuggerFileView DebuggerFileView = "DebuggerFileView";
            GuiTextEditCtrl DebuggerFindStringText = "DebuggerFindStringText";
            GuiCanvas Canvas = "Canvas";
            DebuggerFindDlg DebuggerFindDlg = "DebuggerFindDlg";

            string searchString = DebuggerFindStringText.getValue();
            DebuggerFileView.findString(searchString);

            Canvas.popDialog(DebuggerFindDlg);
        }

        // Set a breakpoint, optionally with condition.
        [ConsoleInteraction]
        public static void DbgSetBreakPoint(string file, uint line, bool clear, string passct, string expr)
        {
            DebuggerFileView DebuggerFileView = "DebuggerFileView";
            DebuggerBreakPoints DebuggerBreakPoints = "DebuggerBreakPoints";
            TCPDebugger TCPDebugger = "TCPDebugger";

            if (!clear)
                {
                if (file == omni.sGlobal["$DebuggerFile"])
                    DebuggerFileView.setBreak(line);
                }
            DebuggerBreakPoints.addBreak(file, line.AsString(), clear, passct, expr);
            TCPDebugger.send("BRKSET " + file + " " + line + " " + clear + " " + passct + " " + expr + "\r\n");
        }

        // Remove a breakpoint.
        [ConsoleInteraction]
        public static void DbgRemoveBreakPoint(string file, uint line)
        {
            DebuggerFileView DebuggerFileView = "DebuggerFileView";
            DebuggerBreakPoints DebuggerBreakPoints = "DebuggerBreakPoints";
            TCPDebugger TCPDebugger = "TCPDebugger";

            if (file == omni.sGlobal["$DebuggerFile"])
                DebuggerFileView.removeBreak(line);
            TCPDebugger.send("BRKCLR " + file + " " + line + "\r\n");
            DebuggerBreakPoints.removeBreak(file, line.AsString());
        }

        // Remove whatever breakpoint is selected in the breakpoints GUI.
        public static void DbgDeleteSelectedBreak()
        {
            DebuggerBreakPoints DebuggerBreakPoints = "DebuggerBreakPoints";

            int selectedBreak = DebuggerBreakPoints.getSelectedId();
            //TODO
            int rowNum = DebuggerBreakPoints.getRowNumById(selectedBreak);
            if (rowNum >= 0)
                {
                string breakText = DebuggerBreakPoints.getRowText(rowNum);
                string breakLine = omni.Util.getField(breakText, 0);
                string breakFile = omni.Util.getField(breakText, 1);
                DbgRemoveBreakPoint(breakFile, breakLine.AsUint());
                }
        }

        // Send an expression to the server for evaluation.
        [ConsoleInteraction]
        public static void DbgConsoleEntryReturn()
        {
            DebuggerConsoleView DebuggerConsoleView = "DebuggerConsoleView";
            TCPDebugger TCPDebugger = "TCPDebugger";
            GuiTextEditCtrl DbgConsoleEntry = "DbgConsoleEntry";
            GuiTextCtrl DebuggerStatus = "DebuggerStatus";

            string msg = DbgConsoleEntry.getValue();
            if (msg != "")
                {
                DebuggerConsoleView.print("" + msg);
                if (DebuggerStatus.getValue() == "NOT CONNECTED")
                    DebuggerConsoleView.print("*** Not connected.");
                else if (DebuggerStatus.getValue() == "BREAK")
                    DebuggerConsoleView.print("*** Target is in BREAK mode.");
                else
                    TCPDebugger.send("CEVAL " + msg + "\r\n");
                }
            DbgConsoleEntry.setValue("");
        }

        // Print a line from the server.
        [ConsoleInteraction]
        public static void DbgConsolePrint(string status)
        {
            DebuggerConsoleView DebuggerConsoleView = "DebuggerConsoleView";

            DebuggerConsoleView.print(status);
        }

        // Delete the currently selected watch expression.
        [ConsoleInteraction]
        public static void DbgDeleteSelectedWatch()
        {
            GuiTextListCtrl DebuggerWatchView = "DebuggerWatchView";

            int selectedWatch = DebuggerWatchView.getSelectedId();
            int rowNum = DebuggerWatchView.getRowNumById(selectedWatch);
            DebuggerWatchView.removeRow(rowNum);
        }

        // Evaluate all the watch expressions.
        [ConsoleInteraction]
        public static void DbgRefreshWatches()
        {
            GuiTextListCtrl DebuggerWatchView = "DebuggerWatchView";
            TCPDebugger TCPDebugger = "TCPDebugger";

            for (int i = 0; i < DebuggerWatchView.rowCount(); i++)
                {
                int id = DebuggerWatchView.getRowId(i);
                string row = DebuggerWatchView.getRowTextById(id);
                string expr = omni.Util.getField(row, 0);
                TCPDebugger.send("EVAL " + id + " 0 " + expr + "\r\n");
                }
        }

        //---------------------------------------------------------------------------------------------
        // Incremental execution functions
        // These just send commands to the server.
        //---------------------------------------------------------------------------------------------
        [ConsoleInteraction]
        public static void dbgStepIn()
        {
            TCPDebugger TCPDebugger = "TCPDebugger";

            TCPDebugger.send("STEPIN\r\n");
        }

        [ConsoleInteraction]
        public static void dbgStepOut()
        {
            TCPDebugger TCPDebugger = "TCPDebugger";

            TCPDebugger.send("STEPOUT\r\n");
        }

        [ConsoleInteraction]
        public static void dbgStepOver()
        {
            TCPDebugger TCPDebugger = "TCPDebugger";

            TCPDebugger.send("STEPOVER\r\n");
        }

        [ConsoleInteraction]
        public static void dbgContinue()
        {
            TCPDebugger TCPDebugger = "TCPDebugger";

            TCPDebugger.send("CONTINUE\r\n");
        }

        [TypeConverter(typeof (TypeConverterGeneric<DebuggerBreakPoints>))]
        public class DebuggerBreakPoints : GuiTextListCtrl
        {
            // Add a breakpoint at the selected spot, if it doesn't already exist.
            [ConsoleInteraction]
            public void addBreak(string file, string line, bool clear, string passct, string expr)
            {
                // columns 0 = line, 1 = file, 2 = expr
                string textLine = line + "\t" + file + "\t" + expr + "\t" + passct + "\t" + clear;
                int selId = this.getSelectedId();
                string selText = this.getRowTextById(selId);
                if ((Util.getField(selText, 0) == line) && (Util.getField(selText, 1) == file))
                    this.setRowById(selId, textLine);
                else
                    {
                    this.addRow(iGlobal["$DbgBreakId"], textLine, -1);
                    iGlobal["$DbgBreakId"]++;
                    }
            }

            // Remove the selected breakpoint.
            [ConsoleInteraction]
            public void removeBreak(string file, string line)
            {
                for (int i = 0; i < this.rowCount(); i++)
                    {
                    int id = this.getRowId(i);
                    string text = this.getRowTextById(id);
                    if ((Util.getField(text, 0) == line) && (Util.getField(text, 1) == file))
                        {
                        this.removeRowById(id);
                        return;
                        }
                    }
            }

            // Remove all breakpoints.
            [ConsoleInteraction]
            public void clearBreaks()
            {
                while (this.rowCount() > 0)
                    {
                    int id = this.getRowId(0);
                    string text = this.getRowTextById(id);
                    string file = Util.getField(text, 1);
                    string line = Util.getField(text, 0);
                    DbgRemoveBreakPoint(file, line.AsUint());
                    }
            }

            // Go to file & line for the selected breakpoint.
            [ConsoleInteraction]
            public override void onAction()
            {
                int id = this.getSelectedId();
                if (id == -1)
                    return;
                string text = this.getRowTextById(id);
                string line = Util.getField(text, 0);
                string file = Util.getField(text, 1);

                DbgOpenFile(file, line.AsInt(), false);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DebuggerBreakPoints ts, string simobjectid)
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
            public static bool operator !=(DebuggerBreakPoints ts, string simobjectid)
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
            public static implicit operator string(DebuggerBreakPoints ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DebuggerBreakPoints(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DebuggerBreakPoints) Omni.self.getSimObject(simobjectid, typeof (DebuggerBreakPoints));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DebuggerBreakPoints ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DebuggerBreakPoints(int simobjectid)
            {
                return (DebuggerBreakPoints) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerBreakPoints));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DebuggerBreakPoints ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DebuggerBreakPoints(uint simobjectid)
            {
                return (DebuggerBreakPoints) Omni.self.getSimObject(simobjectid, typeof (DebuggerBreakPoints));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DebuggerCallStack>))]
        public class DebuggerCallStack : GuiTextListCtrl
        {
            // When entry on call stack selected, open the file and go to the line.
            [ConsoleInteraction]
            public override void onAction()
            {
                int id = this.getSelectedId();
                if (id == -1)
                    return;
                string text = this.getRowTextById(id);
                string file = Util.getField(text, 0);
                string line = Util.getField(text, 1);

                DbgOpenFile(file, line.AsInt(), (id == 0));
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DebuggerCallStack ts, string simobjectid)
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
            public static bool operator !=(DebuggerCallStack ts, string simobjectid)
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
            public static implicit operator string(DebuggerCallStack ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DebuggerCallStack(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DebuggerCallStack) Omni.self.getSimObject(simobjectid, typeof (DebuggerCallStack));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DebuggerCallStack ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DebuggerCallStack(int simobjectid)
            {
                return (DebuggerCallStack) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerCallStack));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DebuggerCallStack ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DebuggerCallStack(uint simobjectid)
            {
                return (DebuggerCallStack) Omni.self.getSimObject(simobjectid, typeof (DebuggerCallStack));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DebuggerConsoleView>))]
        public class DebuggerConsoleView : GuiTextListCtrl
        {
            // Print a line of response from the server.
            [ConsoleInteraction]
            public void print(string line)
            {
                int row = this.addRow(0, line, -1);
                this.scrollVisible(row);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DebuggerConsoleView ts, string simobjectid)
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
            public static bool operator !=(DebuggerConsoleView ts, string simobjectid)
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
            public static implicit operator string(DebuggerConsoleView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DebuggerConsoleView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DebuggerConsoleView) Omni.self.getSimObject(simobjectid, typeof (DebuggerConsoleView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DebuggerConsoleView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DebuggerConsoleView(int simobjectid)
            {
                return (DebuggerConsoleView) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerConsoleView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DebuggerConsoleView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DebuggerConsoleView(uint simobjectid)
            {
                return (DebuggerConsoleView) Omni.self.getSimObject(simobjectid, typeof (DebuggerConsoleView));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DebuggerFilePopup>))]
        public class DebuggerFilePopup : GuiPopUpMenuCtrl
        {
            // When entry in file list selected, open the file.
            [ConsoleInteraction]
            public override void onSelect(string id, string text)
            {
                DbgOpenFile(text, 0, false);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DebuggerFilePopup ts, string simobjectid)
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
            public static bool operator !=(DebuggerFilePopup ts, string simobjectid)
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
            public static implicit operator string(DebuggerFilePopup ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DebuggerFilePopup(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DebuggerFilePopup) Omni.self.getSimObject(simobjectid, typeof (DebuggerFilePopup));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DebuggerFilePopup ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DebuggerFilePopup(int simobjectid)
            {
                return (DebuggerFilePopup) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerFilePopup));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DebuggerFilePopup ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DebuggerFilePopup(uint simobjectid)
            {
                return (DebuggerFilePopup) Omni.self.getSimObject(simobjectid, typeof (DebuggerFilePopup));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<DebuggerFileView>))]
        public class DebuggerFileView : DbgFileView
        {
            // Handle breakpoint removal executed from the file-view GUI.
            [ConsoleInteraction]
            public override void onRemoveBreakPoint(string line)
            {
                string file = sGlobal["$DebuggerFile"];
                DbgRemoveBreakPoint(file, line.AsUint());
            }

            // Handle breakpoint addition executed from the file-view GUI.
            [ConsoleInteraction]
            public override void onSetBreakPoint(string line)
            {
                string file = sGlobal["$DebuggerFile"];
                DbgSetBreakPoint(file, line.AsUint(), false, "0", "true");
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(DebuggerFileView ts, string simobjectid)
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
            public static bool operator !=(DebuggerFileView ts, string simobjectid)
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
            public static implicit operator string(DebuggerFileView ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator DebuggerFileView(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (DebuggerFileView) Omni.self.getSimObject(simobjectid, typeof (DebuggerFileView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(DebuggerFileView ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator DebuggerFileView(int simobjectid)
            {
                return (DebuggerFileView) Omni.self.getSimObject((uint) simobjectid, typeof (DebuggerFileView));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(DebuggerFileView ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator DebuggerFileView(uint simobjectid)
            {
                return (DebuggerFileView) Omni.self.getSimObject(simobjectid, typeof (DebuggerFileView));
            }

            #endregion
        }

        [TypeConverter(typeof (TypeConverterGeneric<TCPDebugger>))]
        public class TCPDebugger : TCPObject
        {
            [ConsoleInteraction]
            public override void onLine(string line)
            {
                Util._echo("Got line=>" + line);
                string cmd = Util.firstWord(line);
                string rest = Util.restWords(line);

                if (cmd == "PASS")
                    this.handlePass(rest);
                else if (cmd == "COUT")
                    this.handleLineOut(rest);
                else if (cmd == "FILELISTOUT")
                    this.handleFileList(rest);
                else if (cmd == "BREAKLISTOUT")
                    this.handleBreakList(rest);
                else if (cmd == "BREAK")
                    this.handleBreak(rest);
                else if (cmd == "RUNNING")
                    this.handleRunning();
                else if (cmd == "EVALOUT")
                    this.handleEvalOut(rest);
                else
                    this.handleError(line);
            }

            // Handler for PASS response.
            [ConsoleInteraction]
            public void handlePass(string message)
            {
                DebuggerConsoleView DebuggerConsoleView = "DebuggerConsoleView";
                GuiTextCtrl DebuggerStatus = "DebuggerStatus";

                if (message == "WrongPass")
                    {
                    DebuggerConsoleView.print("Disconnected - wrong password.");
                    this.disconnect();
                    }
                else if (message == "Connected.")
                    {
                    DebuggerConsoleView.print("Connected.");
                    DebuggerStatus.setValue("CONNECTED");
                    this.send("FILELIST\r\n");
                    }
            }

            // Handler for COUT response.
            [ConsoleInteraction]
            public void handleLineOut(string line)
            {
                DebuggerConsoleView DebuggerConsoleView = "DebuggerConsoleView";

                DebuggerConsoleView.print(line);
            }

            // Handler for FILELISTOUT response.
            [ConsoleInteraction]
            public void handleFileList(string line)
            {
                DebuggerFilePopup DebuggerFilePopup = "DebuggerFilePopup";

                DebuggerFilePopup.clear();
                int word = 0;
                string file;
                while ((file = Util.getWord(line, word)) != "")
                    {
                    word++;
                    DebuggerFilePopup.add(file, word);
                    }
            }

            // Handler for BREAKLISTOUT response.
            [ConsoleInteraction]
            public void handleBreakList(string line)
            {
                DebuggerFileView DebuggerFileView = "DebuggerFileView";
                DebuggerBreakPoints DebuggerBreakPoints = "DebuggerBreakPoints";

                string file = Util.getWord(line, 0);
                if (file != sGlobal["$DebuggerFile"])
                    return;
                int pairs = Util.getWord(line, 1).AsInt();
                uint curLine = 1;
                DebuggerFileView.clearBreakPositions();

                // Set the possible break positions.
                for (int i = 0; i < pairs; i++)
                    {
                    uint skip = Util.getWord(line, i*2 + 2).AsUint();
                    int breaks = Util.getWord(line, i*2 + 3).AsInt();
                    curLine += skip;
                    for (int j = 0; j < breaks; j++)
                        {
                        DebuggerFileView.setBreakPosition(curLine);
                        curLine++;
                        }
                    }

                // Now set the actual break points.
                for (int i = 0; i < DebuggerBreakPoints.rowCount(); i++)
                    {
                    string breakText = DebuggerBreakPoints.getRowText(i);
                    string breakLine = Util.getField(breakText, 0);
                    string breakFile = Util.getField(breakText, 1);
                    if (breakFile == sGlobal["$DebuggerFile"])
                        DebuggerFileView.setBreak(breakLine.AsUint());
                    }
            }

            // Handler for BREAK response.
            [ConsoleInteraction]
            public void handleBreak(string line)
            {
                GuiTextCtrl DebuggerStatus = "DebuggerStatus";
                GuiTextListCtrl DebuggerWatchView = "DebuggerWatchView";
                DebuggerCallStack DebuggerCallStack = "DebuggerCallStack";

                DebuggerStatus.setValue("BREAK");

                // Query all the watches.
                for (int i = 0; i < DebuggerWatchView.rowCount(); i++)
                    {
                    int id = DebuggerWatchView.getRowId(i);
                    string row = DebuggerWatchView.getRowTextById(id);
                    string expr = Util.getField(row, 0);
                    this.send("EVAL " + id + " 0 " + expr + "\r\n");
                    }

                // Update the call stack window.
                DebuggerCallStack.clear();

                string file = Util.getWord(line, 0);
                string lineNumber = Util.getWord(line, 1);
                string funcName = Util.getWord(line, 2);

                DbgOpenFile(file, lineNumber.AsInt(), true);

                int nextWord = 3;
                //int rowId = 0;
                int iD = 0;
                while (true)
                    {
                    DebuggerCallStack.setRowById(iD, file + "\t" + lineNumber + "\t" + funcName);
                    iD++;
                    file = Util.getWord(line, nextWord);
                    lineNumber = Util.getWord(line, nextWord + 1);
                    funcName = Util.getWord(line, nextWord + 2);
                    nextWord += 3;
                    if (file == "")
                        break;
                    }
            }

            // Handler for RUNNING response.
            [ConsoleInteraction]
            public void handleRunning()
            {
                DebuggerFileView DebuggerFileView = "DebuggerFileView";
                DebuggerCallStack DebuggerCallStack = "DebuggerCallStack";
                GuiTextCtrl DebuggerStatus = "DebuggerStatus";

                DebuggerFileView.setCurrentLine(-1, true);
                DebuggerCallStack.clear();
                DebuggerStatus.setValue("RUNNING...");
            }

            // Handler for EVALOUT response.
            [ConsoleInteraction]
            public void handleEvalOut(string line)
            {
                GuiTextCtrl DebuggerCursorWatch = "DebuggerCursorWatch";
                GuiTextListCtrl DebuggerWatchView = "DebuggerWatchView";

                int id = Util.firstWord(line).AsInt();
                string value = Util.restWords(line);

                // See if it's the cursor watch, or from the watch window.
                if (id < 0)
                    DebuggerCursorWatch.setText(DebuggerCursorWatch["expr"] + ' ' + "=" + ' ' + value);
                else
                    {
                    string row = DebuggerWatchView.getRowTextById(id);
                    if (row == "")
                        return;
                    string expr = Util.getField(row, 0);
                    DebuggerWatchView.setRowById(id, expr + "\t" + value);
                    }
            }

            // Handler for unrecognized response.
            [ConsoleInteraction]
            public void handleError(string line)
            {
                DebuggerConsoleView DebuggerConsoleView = "DebuggerConsoleView";

                DebuggerConsoleView.print("ERROR - bogus message: " + line);
            }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(TCPDebugger ts, string simobjectid)
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
            public static bool operator !=(TCPDebugger ts, string simobjectid)
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
            public static implicit operator string(TCPDebugger ts)
            {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator TCPDebugger(string ts)
            {
                uint simobjectid = resolveobject(ts);
                return (TCPDebugger) Omni.self.getSimObject(simobjectid, typeof (TCPDebugger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(TCPDebugger ts)
            {
                return (int) ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator TCPDebugger(int simobjectid)
            {
                return (TCPDebugger) Omni.self.getSimObject((uint) simobjectid, typeof (TCPDebugger));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(TCPDebugger ts)
            {
                return ts._iID;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator TCPDebugger(uint simobjectid)
            {
                return (TCPDebugger) Omni.self.getSimObject(simobjectid, typeof (TCPDebugger));
            }

            #endregion
        }
    }
}