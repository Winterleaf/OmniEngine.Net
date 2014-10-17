// Copyright (C) 2012 Winterleaf Entertainment L,L,C.

#region

using System;
using System.Diagnostics;
using System.Drawing;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using WinterLeaf.Engine;

#endregion
[assembly: SecurityRules(SecurityRuleSet.Level1)]
namespace Winterleaf.Game
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        private static Omni omni;

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
            //Application.Run(new main_window());
            omni = new Omni(Process.GetCurrentProcess().Handle);
            //Initialize Torque, pass a handle to this form into T3D so it knows where to rendor the screen to.
            //If you don't do this, you can't pass the mouse and key strokes, w/out the mouse and keystrokes
            //being redirected the application will hang intermittently.
#if DEBUG
            omni.Initialize(MessageBox.Show("Dedicated", "Dedicated", MessageBoxButtons.YesNo) == DialogResult.Yes ?
                new[] {"-dedicated", "-mission", @"levels/Empty_Terrain.mis"} :
                new[] {""}, "<!!__PROJECTNAME__!!>_DEBUG", "WinterLeaf.Demo.Full.dll", "WinterLeaf.Demo.Full", "csScripts");
#else
            omni.Initialize(MessageBox.Show("Dedicated", "Dedicated", MessageBoxButtons.YesNo) == DialogResult.Yes ?
                new[] { "-dedicated", "-mission", @"levels/Empty_Terrain.mis" } :
                new[] { "" }, "<!!__PROJECTNAME__!!>", "WinterLeaf.Demo.Full.dll", "WinterLeaf.Demo.Full", "csScripts");
#endif
            omni.Debugging = false;
            omni.ScriptExtensions_Allow = true;
            omni.ScriptExtensions_HandleExceptions = true;
            
            omni.DebuggingShowScriptCalls = false;
            omni.WindowIcon = new Icon("Omni.ico");
            while (omni.IsRunning)
                Thread.Sleep(1000);

                if (omni.LastError != null)
                    MessageBox.Show("An Error has occurred in the application.  " + omni.LastError);
            omni = null;
            }
            catch (Exception err)
            {
                MessageBox.Show("An Error has occurred in the application.  " + err.Message);
            }
            Application.Exit();
        }
    }
}