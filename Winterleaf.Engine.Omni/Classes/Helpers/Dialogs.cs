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

using System;
using System.IO;
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
            Oper o = new Oper(ref fd, ref dr) {_callback = onfinish};
            Thread thread = new Thread(() => FileDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null)
                return DialogResult.OK;
            while (!o._isFinished)
                Thread.Sleep(100);
            return o._dr;
        }

        private static void FileDialog_DoWork(object e)
        {
            Oper o = (Oper) e;
            o._dr = o._fd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null)
                o._callback(o._fd, o._dr);
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
            Oper o = new Oper(ref fbd, ref dr) {_callback = onfinish};
            Thread thread = new Thread(() => FolderBrowserDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null)
                return DialogResult.OK;
            while (!o._isFinished)
                Thread.Sleep(100);
            return o._dr;
        }

        private static void FolderBrowserDialog_DoWork(object e)
        {
            Oper o = (Oper) e;
            o._dr = o._fbd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null)
                o._callback(o._fbd, o._dr);
        }

        /// <summary>
        /// Opens a OpenFileDialog window and returns a DialogResult if blocking otherwise dialog.ok
        /// </summary>
        /// <param name="fbd">Reference to a OpenFileDialog</param>
        /// <param name="onfinish">If a delegate is passed, then it doesn't block.</param>
        /// <returns></returns>
        public static DialogResult OpenFileDialog(ref OpenFileDialog fbd, onDialogFinished onfinish = null)
        {
            if (!Directory.Exists(fbd.InitialDirectory))
                {
                if (Directory.Exists(Path.Combine(Environment.CurrentDirectory, fbd.InitialDirectory)))
                    fbd.InitialDirectory = Path.Combine(Environment.CurrentDirectory, fbd.InitialDirectory);
                else
                    fbd.InitialDirectory = Environment.CurrentDirectory;
                }
            DialogResult dr = new DialogResult();
            Oper o = new Oper(ref fbd, ref dr);
            Thread thread = new Thread(() => OpenFileDialog_DoWork(o));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            if (onfinish != null)
                return DialogResult.OK;
            while (!o._isFinished)
                Thread.Sleep(100);
            return o._dr;
        }

        private static void OpenFileDialog_DoWork(object e)
        {
            Oper o = (Oper) e;
            o._dr = o._ofd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null)
                o._callback(o._ofd, o._dr);
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
            if (onfinish != null)
                return DialogResult.OK;
            while (!o._isFinished)
                Thread.Sleep(100);
            return o._dr;
        }

        private static void SaveFileDialog_DoWork(object e)
        {
            Oper o = (Oper) e;
            o._dr = o._sfd.ShowDialog();
            o._isFinished = true;
            if (o._callback != null)
                o._callback(o._sfd, o._dr);
        }

        public static string GetForwardSlashFile(string str)
        {
            return str.Replace("\\", "/");
        }

        private class Oper
        {
            public onDialogFinished _callback = null;
            public DialogResult _dr;
            public FolderBrowserDialog _fbd;
            public FileDialog _fd;
            public volatile bool _isFinished = false;
            public OpenFileDialog _ofd;
            public SaveFileDialog _sfd;

            public Oper(ref FileDialog filedialog, ref DialogResult dr)
            {
                _fd = filedialog;
                if (string.IsNullOrEmpty(_fd.InitialDirectory))
                    _fd.InitialDirectory = Environment.CurrentDirectory;
                _isFinished = false;
            }

            public Oper(ref FolderBrowserDialog folderBrowserDialog, ref DialogResult dr)
            {
                _fbd = folderBrowserDialog;
                if (string.IsNullOrEmpty(_fbd.SelectedPath))
                    _fbd.SelectedPath = Environment.CurrentDirectory;
                _isFinished = false;
            }

            public Oper(ref OpenFileDialog openFileDialog, ref DialogResult dr)
            {
                _ofd = openFileDialog;
                if (string.IsNullOrEmpty(_ofd.InitialDirectory))
                    _ofd.InitialDirectory = Environment.CurrentDirectory;
                _isFinished = false;
            }

            public Oper(ref SaveFileDialog saveFileDialog, ref DialogResult dr)
            {
                _sfd = saveFileDialog;
                if (string.IsNullOrEmpty(_sfd.InitialDirectory))
                    _sfd.InitialDirectory = Environment.CurrentDirectory;
                _isFinished = false;
            }
        }
    }
}