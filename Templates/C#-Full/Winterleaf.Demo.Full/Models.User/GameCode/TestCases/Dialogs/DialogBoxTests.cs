using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.TestCases.Dialogs
    {
    class DialogBoxTests
        {
        #region OpenFileDialog
        [ConsoleInteraction]
        public static void Test_FileDialogWithDelegate()
            {
            FileDialog fd = new OpenFileDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.FileDialog(ref fd, Test_FileDialogWithDelegate_finished);
            }

        public static void Test_FileDialogWithDelegate_finished(object o, DialogResult dr)
            {
            MessageBox.Show(dr.ToString());
            }

        public static void Test_FileDialogWithoutDelegate()
            {
            FileDialog fd = new OpenFileDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.FileDialog(ref fd);
            MessageBox.Show(dr.ToString());
            }

        #endregion

        #region FolderBrowserDialog
        [ConsoleInteraction]
        public static void Test_FolderBrowserDialogWithDelegate()
            {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.FolderBrowserDialog(ref fd, Test_FolderBrowserDialogWithDelegate_finished);
            }

        public static void Test_FolderBrowserDialogWithDelegate_finished(object o, DialogResult dr)
            {
            MessageBox.Show(dr.ToString());
            }

        public static void Test_FolderBrowserDialogWithoutDelegate()
            {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.FolderBrowserDialog(ref fd);
            MessageBox.Show(dr.ToString());
            }

        #endregion

        #region FolderBrowserDialog
        [ConsoleInteraction]
        public static void Test_OpenFileDialogWithDelegate()
            {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.OpenFileDialog(ref fd, Test_OpenFileDialogWithDelegate_finished);
            }

        public static void Test_OpenFileDialogWithDelegate_finished(object o, DialogResult dr)
            {
            MessageBox.Show(dr.ToString());
            }

        public static void Test_OpenFileDialogWithoutDelegate()
            {
            OpenFileDialog fd = new OpenFileDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.OpenFileDialog(ref fd);
            MessageBox.Show(dr.ToString());
            }

        #endregion

        #region FolderBrowserDialog
        [ConsoleInteraction]
        public static void Test_SaveFileDialogWithDelegate()
            {
            SaveFileDialog fd = new SaveFileDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.SaveFileDialog(ref fd, Test_SaveFileDialogWithDelegate_finished);
            }

        public static void Test_SaveFileDialogWithDelegate_finished(object o, DialogResult dr)
            {
            MessageBox.Show(dr.ToString());
            }

        public static void Test_SaveFileDialogWithoutDelegate()
            {
            SaveFileDialog fd = new SaveFileDialog();
            DialogResult dr = WinterLeaf.Engine.Classes.Helpers.Dialogs.SaveFileDialog(ref fd);
            MessageBox.Show(dr.ToString());
            }

        #endregion

        }

    }
