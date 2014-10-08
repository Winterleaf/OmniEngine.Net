using System.ComponentModel;
using System.Security.AccessControl;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.WorldEditor.gui.CodeBehind
    {
    [TypeConverter(typeof (TypeConverterGeneric<AddFMODProjectDlg>))]
    public class AddFMODProjectDlg : GuiControl
        {
        [ConsoleInteraction]
        public void show()
            {
            string fmodex = "fmodex.dll";
            string fmodevent = "fmod_event.dll";
            if (sGlobal["$platform"] == "macos")
                {
                fmodex = "libfmodex.dylib";
                fmodevent = "libfmodevent.dylib";
                }

            // Make sure we have FMOD running.

            if (Util.getField(Util.sfxGetDeviceInfo(), iGlobal["$SFX::DEVICE_INFO_PROVIDER"]) == "FMOD")
                {
                messageBox.MessageBoxOK("Error",
                    "You do not currently have FMOD selected as your sound system.\r\n" +
                    "\r\n" +
                    "To install FMOD, place the FMOD DLLs (" + fmodex + " and " + fmodevent + ") " +
                    "in your game/ folder alongside your game executable " +
                    "and restart Torque.\r\n\r\n" +
                    "To select FMOD as your sound system, choose it as the sound provider in " +
                    "the audio tab of the Game Options dialog.");
                return;
                }

            // Make sure we have the FMOD Event DLL loaded.
            uint deviceCaps = Util.getField(Util.sfxGetDeviceInfo(), iGlobal["$SFX::DEVICE_INFO_CAPS"]).AsUInt();

            if ((deviceCaps & uGlobal["$SFX::DEVICE_CAPS_FMODDESIGNER"]) != 1)
                {
                messageBox.MessageBoxOK("Error",
                    "You do not have the requisite FMOD Event DLL in place.\r\n\r\n Please copy " + fmodevent +
                    " into your game/ folder and restart Torque.");
                return;
                }

            ((GuiCanvas) "Canvas").pushDialog(this, 0, true);
            }

        public override void onWake()
            {
            this["persistenceMgr"] = new ObjectCreator("PersistenceManager").Create().AsString();
            }

        public override void onSleep()
            {
            this["persistenceMgr"].delete();
            }

        [ConsoleInteraction]
        public void onCancel()
            {
            ((GuiCanvas) "Canvas").popDialog(this);
            }

        [ConsoleInteraction]
        public void onOK()
            {
            editor Editor = "Editor";

            string objName = ((GuiTextEditCtrl) findObjectByInternalName("projectNameField", true)).getText();
            string fileName = ((GuiTextEditCtrl) findObjectByInternalName("fileNameField", true)).getText();
            string mediaPath = ((GuiTextEditCtrl) findObjectByInternalName("mediaPathField", true)).getText();

            // Make sure the object name is valid.
            if (!Editor.validateObjectName(objName, true))
                return;

            // Make sure the .fev file exists.

            if (fileName == "")
                {
                messageBox.MessageBoxOK("Error", "Please enter a project file name.");
                return;
                }

            if (!Util.isFile(fileName))
                {
                messageBox.MessageBoxOK("Error", "'" + fileName + "' is not a valid file.");
                return;
                }

            // Make sure the media path exists.
            if (!Util.IsDirectory(mediaPath))
                {
                messageBox.MessageBoxOK("Error", "'" + mediaPath + "' is not a valid directory.");
                return;
                }

            // If an event script exists from a previous instantiation,
            // delete it first.

            Util.pushInstantGroup();

            Util.eval("new SFXFMODProject( " + objName + ") {" + "fileName = \"" + fileName + "\";" + "mediaPath = \"" +
                       mediaPath + "\";" + "};");
            Util.popInstantGroup();

            if (!objName.isObject())
                {
                messageBox.MessageBoxOK("Error",
                    "Failed to create the object.  Please take a look at the log for details.");
                return;
                }
            else
                {
                // Save the object.
                SFXFMODProject obj = objName;
                obj.setFilename("scripts/client/audioData.cs");
                ((PersistenceManager) this["persistenceMgr"]).setDirty(objName);
                ((PersistenceManager) this["persistenceMgr"]).saveDirty();
                }

            ((GuiCanvas) "Canvas").popDialog(this);
            // Trigger a reinit on the datablock editor, just in case.

            DatablockEditorPlugin DatablockEditorPlugin = "DatablockEditorPlugin";
            if (DatablockEditorPlugin.isObject())
                DatablockEditorPlugin.populateTrees();
            }

        [ConsoleInteraction]
        public void onSelectFile()
            {
            if (sGlobal["$pref::WorldEditor::AddFMODProjectDlg::lastPath"] == "")
                sGlobal["$pref::WorldEditor::AddFMODProjectDlg::lastPath"] = Util.getMainDotCsDir();

            var ofd = new System.Windows.Forms. OpenFileDialog
            {
                Title = @"Select Compiled FMOD Designer Event File...",
                InitialDirectory = sGlobal["$pref::WorldEditor::AddFMODProjectDlg::lastPath"],
                FileName = ((GuiTextEditCtrl) this.findObjectByInternalName("fileNameField", true)).getText(),
                Filter = @"Compiled Event Files (*.fev)|*.fev|All Files (*.*)|*.*",
                CheckFileExists = true,
                Multiselect = false,
                
            };

            string file = "";

            DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

            switch (dr)
            {
                case DialogResult.OK:
                    file = Dialogs.GetForwardSlashFile(ofd.FileName);
                    sGlobal["$pref::WorldEditor::AddFMODProjectDlg::lastPath"] = Util.filePath(file);
                    break;
                case DialogResult.Abort:
                case DialogResult.Ignore:
                case DialogResult.No:
                case DialogResult.Cancel:
                case DialogResult.None:
                    return;
            }

            file = Util.makeRelativePath(file, Util.getMainDotCsDir());

            ((GuiTextCtrl) this.findObjectByInternalName("fileNameField", true)).setText(file);

            GuiTextEditCtrl projectNameField = this.findObjectByInternalName("projectNameField", true);

            if (projectNameField.getText() == "")
                {
                string projectName = "fmod" + Util.fileBase(file);
                if (Util.isValidObjectName(projectNameField))
                    projectNameField.setText(projectName);
                }
            }

        [ConsoleInteraction]
        public void onSelectMediaPath()
            {
            string defaultPath = ((GuiTextEditCtrl) this.findObjectByInternalName("mediaPathField", true)).getText();
            if (defaultPath == "")
                {
                defaultPath =
                    Util.filePath(((GuiTextEditCtrl) this.findObjectByInternalName("fileNameField", true)).getText());

                if (defaultPath == "")
                    defaultPath = Util.getMainDotCsDir();
                else
                    defaultPath = Util.makeFullPath(defaultPath, "");
                }

            var ofd = new System.Windows.Forms.OpenFileDialog
            {
                Title = @"Select Media Path...",
                InitialDirectory = defaultPath,
                //Filter = @"All Files (*.*)|*.*|",
                CheckFileExists = true,
                Multiselect = false
            };

            string file = "";

            DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

            switch (dr)
            {
                case DialogResult.OK:
                    file = Dialogs.GetForwardSlashFile(ofd.FileName);
                    break;
                case DialogResult.Abort:
                case DialogResult.Ignore:
                case DialogResult.No:
                case DialogResult.Cancel:
                case DialogResult.None:
                    return;
            }

            file = Util.makeRelativePath(file, Util.getMainDotCsDir());

            ((GuiTextEditCtrl) this.findObjectByInternalName("mediaPathField", true)).setText(file);
            }

        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AddFMODProjectDlg ts, string simobjectid)
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
        public static bool operator !=(AddFMODProjectDlg ts, string simobjectid)
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
        public static implicit operator string(AddFMODProjectDlg ts)
            {
            return ReferenceEquals(ts, null) ? "0" : ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator AddFMODProjectDlg(string ts)
            {
            uint simobjectid = resolveobject(ts);
            return (AddFMODProjectDlg) Omni.self.getSimObject(simobjectid, typeof (AddFMODProjectDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AddFMODProjectDlg ts)
            {
            return (int) ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AddFMODProjectDlg(int simobjectid)
            {
            return (AddFMODProjectDlg) Omni.self.getSimObject((uint) simobjectid, typeof (AddFMODProjectDlg));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AddFMODProjectDlg ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AddFMODProjectDlg(uint simobjectid)
            {
            return (AddFMODProjectDlg) Omni.self.getSimObject(simobjectid, typeof (AddFMODProjectDlg));
            }

        #endregion
        }
    }