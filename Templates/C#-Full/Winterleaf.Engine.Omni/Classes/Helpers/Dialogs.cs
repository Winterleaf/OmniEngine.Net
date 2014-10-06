using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace WinterLeaf.Engine.Classes.Helpers
    {
    /// <summary>
    /// Class used to handle Dialog Prompts.
    /// </summary>
    public class Dialogs
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dialog"></param>
        public delegate void onDialogFinished(Object dialog, DialogResult result);

        /// <summary>
        /// Opens a "FileDialog" prompt window and returns the Dialog Result if blocking, otherwise DialogResult.OK.
        /// Call will block if a delegate isn't passed.
        /// </summary>
        /// <param name="fd">Reference of a FileDialog </param>
        /// <param name="onfinish">If a delegate is passed, then it doesn't block.</param>
        /// <returns></returns>
        public static DialogResult FileDialog(ref FileDialog fd, onDialogFinished onfinish = null)
            {
            DialogResult dr = new DialogResult();
            Oper o = new Oper(ref fd, ref dr) { _callback = onfinish };
            Thread thread = new Thread(() => FileDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null) return DialogResult.OK;
            while (!o._isFinished) Thread.Sleep(100);
            return o._dr;
            }

        private static void FileDialog_DoWork(object e)
            {
            Oper o = (Oper)e;
            o._dr = o._fd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null) o._callback(o._fd, o._dr);
            }

        /// <summary>
        /// Opens a FolderBrowserDialog and returns a Dialog Result if blocking, otherwise a Dialog.OK
        /// </summary>
        /// <param name="fbd">Reference fo a FolderBrowserDialog</param>
        /// <param name="onfinish">If a delegate is passed, then it doesn't block.</param>
        /// <returns></returns>
        public static DialogResult FolderBrowserDialog(ref FolderBrowserDialog fbd, onDialogFinished onfinish = null)
            {
            DialogResult dr = new DialogResult();
            Oper o = new Oper(ref fbd, ref dr) { _callback = onfinish };
            Thread thread = new Thread(() => FolderBrowserDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null) return DialogResult.OK;
            while (!o._isFinished) Thread.Sleep(100);
            return o._dr;
            }

        private static void FolderBrowserDialog_DoWork(object e)
            {
            Oper o = (Oper)e;
            o._dr = o._fbd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null) o._callback(o._fbd, o._dr);
            }


        /// <summary>
        /// Opens a OpenFileDialog window and returns a DialogResult if blocking otherwise dialog.ok
        /// </summary>
        /// <param name="fbd">Reference to a OpenFileDialog</param>
        /// <param name="onfinish">If a delegate is passed, then it doesn't block.</param>
        /// <returns></returns>
        public static DialogResult OpenFileDialog(ref OpenFileDialog fbd, onDialogFinished onfinish = null)
            {

            if (!System.IO.Directory.Exists(fbd.InitialDirectory))
                if (System.IO.Directory.Exists(System.IO.Path.Combine(Environment.CurrentDirectory, fbd.InitialDirectory)))
                    fbd.InitialDirectory = System.IO.Path.Combine(Environment.CurrentDirectory, fbd.InitialDirectory);
                else
                    fbd.InitialDirectory = Environment.CurrentDirectory;
            DialogResult dr = new DialogResult();
            Oper o = new Oper(ref fbd, ref dr);
            Thread thread = new Thread(() => OpenFileDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null) return DialogResult.OK;
            while (!o._isFinished) Thread.Sleep(100);
            return o._dr;
            }

        private static void OpenFileDialog_DoWork(object e)
            {
            Oper o = (Oper)e;
            o._dr = o._ofd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null) o._callback(o._ofd, o._dr);
            }

        /// <summary>
        /// Opens a SaveFileDialog and returns a Dialogresult if blocking otherwise a dialog.ok
        /// </summary>
        /// <param name="fbd">Reference to a SaveFileDialog</param>
        /// <param name="onfinish">If a delegate is passed, then it doesn't block.</param>
        /// <returns></returns>
        public static DialogResult SaveFileDialog(ref SaveFileDialog fbd, onDialogFinished onfinish = null)
            {
            DialogResult dr = new DialogResult();
            Oper o = new Oper(ref fbd, ref dr);
            Thread thread = new Thread(() => SaveFileDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null) return DialogResult.OK;
            while (!o._isFinished) Thread.Sleep(100);
            return o._dr;
            }

        private static void SaveFileDialog_DoWork(object e)
            {
            Oper o = (Oper)e;
            o._dr = o._sfd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null) o._callback(o._sfd, o._dr);
            }

        private class Oper
            {
            public DialogResult _dr;
            public FolderBrowserDialog _fbd;
            public FileDialog _fd;
            public volatile bool _isFinished = false;
            public OpenFileDialog _ofd;
            public SaveFileDialog _sfd;
            public onDialogFinished _callback = null;

            public Oper(ref FileDialog filedialog, ref DialogResult dr)
                {
                _fd = filedialog;
                if (string.IsNullOrEmpty(_fd.InitialDirectory))
                    {
                    _fd.InitialDirectory = Environment.CurrentDirectory;
                    }
                _isFinished = false;
                }

            public Oper(ref FolderBrowserDialog folderBrowserDialog, ref DialogResult dr)
                {
                _fbd = folderBrowserDialog;
                if (string.IsNullOrEmpty(_fbd.SelectedPath))
                    {
                    _fbd.SelectedPath = Environment.CurrentDirectory;
                    }
                _isFinished = false;
                }

            public Oper(ref OpenFileDialog openFileDialog, ref DialogResult dr)
                {
                _ofd = openFileDialog;
                if (string.IsNullOrEmpty(_ofd.InitialDirectory))
                    {
                    _ofd.InitialDirectory = Environment.CurrentDirectory;
                    }
                _isFinished = false;
                }

            public Oper(ref SaveFileDialog saveFileDialog, ref DialogResult dr)
                {
                _sfd = saveFileDialog;
                if (string.IsNullOrEmpty(_sfd.InitialDirectory))
                    {
                    _sfd.InitialDirectory = Environment.CurrentDirectory;
                    }
                _isFinished = false;
                }
            }

        public static string GetForwardSlashFile(string str)
            {
            return str.Replace("\\", "/");
            }
        }
    }