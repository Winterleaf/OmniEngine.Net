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
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Demo.Full.Models.User.GameCode.Client.Gui;
using WinterLeaf.Demo.Full.Models.User.GameCode.Tools.DatablockEditor.gui.CodeBehind;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.View.Creators;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

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
                messageBox.MessageBoxOK("Error", "You do not currently have FMOD selected as your sound system.\r\n" + "\r\n" + "To install FMOD, place the FMOD DLLs (" + fmodex + " and " + fmodevent + ") " + "in your game/ folder alongside your game executable " + "and restart Torque.\r\n\r\n" + "To select FMOD as your sound system, choose it as the sound provider in " + "the audio tab of the Game Options dialog.");
                return;
                }

            // Make sure we have the FMOD Event DLL loaded.
            uint deviceCaps = Util.getField(Util.sfxGetDeviceInfo(), iGlobal["$SFX::DEVICE_INFO_CAPS"]).AsUint();

            if ((deviceCaps & uGlobal["$SFX::DEVICE_CAPS_FMODDESIGNER"]) != 1)
                {
                messageBox.MessageBoxOK("Error", "You do not have the requisite FMOD Event DLL in place.\r\n\r\n Please copy " + fmodevent + " into your game/ folder and restart Torque.");
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

            Util.eval("new SFXFMODProject( " + objName + ") {" + "fileName = \"" + fileName + "\";" + "mediaPath = \"" + mediaPath + "\";" + "};");
            Util.popInstantGroup();

            if (!objName.isObject())
                {
                messageBox.MessageBoxOK("Error", "Failed to create the object.  Please take a look at the log for details.");
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

            OpenFileDialog ofd = new OpenFileDialog {Title = @"Select Compiled FMOD Designer Event File...", InitialDirectory = sGlobal["$pref::WorldEditor::AddFMODProjectDlg::lastPath"], FileName = ((GuiTextEditCtrl) this.findObjectByInternalName("fileNameField", true)).getText(), Filter = @"Compiled Event Files (*.fev)|*.fev|All Files (*.*)|*.*", CheckFileExists = true, Multiselect = false,};

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
                defaultPath = Util.filePath(((GuiTextEditCtrl) this.findObjectByInternalName("fileNameField", true)).getText());

                if (defaultPath == "")
                    defaultPath = Util.getMainDotCsDir();
                else
                    defaultPath = Util.makeFullPath(defaultPath, "");
                }

            OpenFileDialog ofd = new OpenFileDialog {Title = @"Select Media Path...", InitialDirectory = defaultPath,
                //Filter = @"All Files (*.*)|*.*|",
                CheckFileExists = true, Multiselect = false};

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
        public static bool operator !=(AddFMODProjectDlg ts, string simobjectid)
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