using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.Gui
    {
    public class SaveFileDialog
        {
        private static readonly pInvokes omni = new pInvokes();

        [ConsoleInteraction]
        public static void getSaveFilename(string filespec, string callback, string currentFile, bool overwrite = true)
            {
            var sfd = new System.Windows.Forms.SaveFileDialog
            {
                Filter = filespec,
                FileName = currentFile,
                OverwritePrompt = overwrite,
            };

            if (omni.Util.filePath(currentFile) != "")
                sfd.InitialDirectory = omni.Util.filePath(currentFile);
            else
                sfd.InitialDirectory = omni.Util.getMainDotCsDir();

            DialogResult dr = Dialogs.SaveFileDialog(ref sfd);

            if (dr == DialogResult.OK)
                {
                //string filename = dlg["FileName"];
                string filename = Dialogs.GetForwardSlashFile(sfd.FileName);
                omni.Util.eval(callback + "(\"" + filename + "\");");
                }
            }
        }
    }