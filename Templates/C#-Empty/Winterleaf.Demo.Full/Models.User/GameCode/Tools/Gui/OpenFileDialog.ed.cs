using System;
using System.IO;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui
    {
    public class OpenFileDialog
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void getLoadFilename(string filespec, string callback, string currentFile)
        {
            if (filespec.EndsWith("|"))
                filespec = filespec.Substring(0, filespec.Length - 1);

            var ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.FileName = currentFile;
            try
                {
                ofd.Filter = filespec;
                }
            catch (Exception)
                {
                ofd.Filter = "files (*.*)|*.*";
               // throw;
                }
            
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            //FileDialog fd = ofd;

            if (omni.Util.filePath(currentFile) != "")
                ofd.InitialDirectory = omni.Util.filePath(currentFile);

            DialogResult dr = Engine.Classes.Helpers.Dialogs.OpenFileDialog(ref ofd);


            if (dr == DialogResult.OK)
            {
                var fileName = Dialogs.GetForwardSlashFile(ofd.FileName);
                omni.Util.eval(callback + "(\"" + fileName + "\");");
                omni.sGlobal["$Tools::FileDialogs::LastFilePath"] = omni.Util.filePath(fileName);
            }
            }
        }
    }