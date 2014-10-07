using System.ComponentModel;
using System.Security.AccessControl;
using System.Windows.Forms;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;

namespace WinterLeaf.Demo.Full.Models.User.GameCode.Tools.GuiEditor.gui.CodeBehind
    {
    public class GuiEditorFileDialog
        {
        [TypeConverter(typeof(TypeConverterGeneric<GuiBuilder>))]
        public class GuiBuilder : SimObject
            {


            [ConsoleInteraction(true, "GuiBuilder_initialize")]
            public static void initialize()
                {
                omni.sGlobal["$GUI::FileSpec"] = "Torque Gui Files (*.gui)|*.gui|All Files (*.*)|*.*";
                }


            /// GuiBuilder::getSaveName - Open a Native File dialog and retrieve the
            ///  location to save the current document.
            /// @arg defaultFileName   The FileName to default in the field and to be selected when a path is opened
            public static string GetSaveName(string defaultFileName)
                {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                string defaultPath = GuiEditor["LastPath"];

                if (defaultFileName == "")
                    {
                    string prefix = "";
                    if (omni.Util.isFunction("isScriptPathExpando"))
                        {
                        // if we're editing a game, we want to default to the games dir.
                        // if we're not, then we default to the tools directory or the base.
                        if (omni.console.Call("isScriptPathExpando", new string[] { "^game" }).AsBool())
                            prefix = "^game/";
                        else if (omni.console.Call("isScriptPathExpando", new string[] { "^tools" }).AsBool())
                            prefix = "^tools/";
                        }

                    defaultFileName = omni.Util._expandFilename(prefix + "gui/untitled.gui");
                    }
                else
                    defaultPath = omni.Util.filePath(defaultFileName);

                var sfd = new System.Windows.Forms.SaveFileDialog
                {
                    Filter = omni.sGlobal["$GUI::FileSpec"],
                    InitialDirectory = omni.Util.makeFullPath(defaultPath, ""),
                    FileName = defaultFileName,
                    OverwritePrompt = true,
                };

                string filename = "";

                DialogResult dr = Dialogs.SaveFileDialog(ref sfd);

                if (dr == DialogResult.OK)
                    {
                    filename = Dialogs.GetForwardSlashFile(sfd.FileName);
                    GuiEditor["LastPath"] = omni.Util.filePath(filename);
                    //filename = dlg["FileName"];
                    if (omni.Util.fileExt(filename) != ".gui")
                        filename = filename + ".gui";
                    }

                //dlg.delete();

                return filename;
                }

            [ConsoleInteraction]
            public string getSaveName(string defaultFileName)
                {
                return GetSaveName(defaultFileName);
                }

            [ConsoleInteraction]
            public string getOpenName(string defaultFileName)
                {
                GuiEditorGui.GuiEditor GuiEditor = "GuiEditor";

                if (defaultFileName == "")
                    defaultFileName = omni.Util._expandFilename("^game/gui/untitled.gui");

                var ofd = new System.Windows.Forms.OpenFileDialog
                {
                    FileName = defaultFileName,
                    InitialDirectory = GuiEditor["LastPath"],
                    Filter = omni.sGlobal["$GUI::FileSpec"],
                    CheckFileExists = true,
                    Multiselect = false
                };

                DialogResult dr = Dialogs.OpenFileDialog(ref ofd);

                if (dr == DialogResult.OK)
                    {
                    var fileName = Dialogs.GetForwardSlashFile(ofd.FileName);
                    GuiEditor["LastPath"] = omni.Util.filePath(fileName);
                    return fileName;
                    }
                return "";
                }

            #region ProxyObjects Operator Overrides

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator ==(GuiBuilder ts, string simobjectid)
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
                return (this._ID == (string)myReflections.ChangeType(obj, typeof(string)));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static bool operator !=(GuiBuilder ts, string simobjectid)
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
            public static implicit operator string(GuiBuilder ts)
                {
                return ReferenceEquals(ts, null) ? "0" : ts._ID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator GuiBuilder(string ts)
                {
                uint simobjectid = resolveobject(ts);
                return (GuiBuilder)Omni.self.getSimObject(simobjectid, typeof(GuiBuilder));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator int(GuiBuilder ts)
                {
                return (int)ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="simobjectid"></param>
            /// <returns></returns>
            public static implicit operator GuiBuilder(int simobjectid)
                {
                return (GuiBuilder)Omni.self.getSimObject((uint)simobjectid, typeof(GuiBuilder));
                }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="ts"></param>
            /// <returns></returns>
            public static implicit operator uint(GuiBuilder ts)
                {
                return ts._iID;
                }

            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public static implicit operator GuiBuilder(uint simobjectid)
                {
                return (GuiBuilder)Omni.self.getSimObject(simobjectid, typeof(GuiBuilder));
                }

            #endregion
            }
        }
    }