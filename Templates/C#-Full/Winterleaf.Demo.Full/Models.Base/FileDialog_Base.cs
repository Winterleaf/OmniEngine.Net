


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<FileDialog_Base>))]
    public partial class FileDialog_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FileDialog_Base ts, string simobjectid)
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
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(FileDialog_Base ts, string simobjectid)
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
        public static implicit operator string( FileDialog_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
                 return "0";
            return ts._ID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator FileDialog_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (FileDialog_Base) Omni.self.getSimObject(simobjectid,typeof(FileDialog_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( FileDialog_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FileDialog_Base(int simobjectid)
            {
            return  (FileDialog) Omni.self.getSimObject((uint)simobjectid,typeof(FileDialog_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( FileDialog_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FileDialog_Base(uint simobjectid)
            {
            return  (FileDialog_Base) Omni.self.getSimObject(simobjectid,typeof(FileDialog_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Launches the OS file browser
/// 
///    After an Execute() call, the chosen file name and path is available in one of two areas.  
///    If only a single file selection is permitted, the results will be stored in the @a fileName 
///    attribute.
/// 
///    If multiple file selection is permitted, the results will be stored in the 
///    @a files array.  The total number of files in the array will be stored in the 
///    @a fileCount attribute.
/// 
///    @tsexample
///    // NOTE: This is not he preferred class to use, but this still works
///    // Create the file dialog
///    %baseFileDialog = new FileDialog()
///    {
///       // Allow browsing of all file types
///       filters = \"*.*\";
///       // No default file
///       defaultFile = ;
///       // Set default path relative to project
///       defaultPath = \"./\";
///       // Set the title
///       title = \"Durpa\";
///       // Allow changing of path you are browsing
///       changePath = true;
///    };
///     // Launch the file dialog
///     %baseFileDialog.Execute();
///     
///     // Don't forget to cleanup
///     %baseFileDialog.delete();
/// 
///     // A better alternative is to use the 
///     // derived classes which are specific to file open and save
///     // Create a dialog dedicated to opening files
///     %openFileDlg = new OpenFileDialog()
///     {
///        // Look for jpg image files
///        // First part is the descriptor|second part is the extension
///        Filters = \"Jepg Files|*.jpg\";
///        // Allow browsing through other folders
///        ChangePath = true;
///        // Only allow opening of one file at a time
///        MultipleFiles = false;
///     };
///     // Launch the open file dialog
///     %result = %openFileDlg.Execute();
///     // Obtain the chosen file name and path
///     if ( %result )
///     {
///        %seletedFile = %openFileDlg.file;
///     }
///     else
///     {
///        %selectedFile = \"\";
///     }
///     // Cleanup
///     %openFileDlg.delete();
/// 
///     // Create a dialog dedicated to saving a file
///     %saveFileDlg = new SaveFileDialog()
///     {
///        // Only allow for saving of COLLADA files
///        Filters = \"COLLADA Files (*.dae)|*.dae|\";
///        // Default save path to where the WorldEditor last saved
///        DefaultPath = $pref::WorldEditor::LastPath;
///        // No default file specified
///        DefaultFile = \"\";
///        // Do not allow the user to change to a new directory
///        ChangePath = false;
///        // Prompt the user if they are going to overwrite an existing file
///        OverwritePrompt = true;
///     };
///     // Launch the save file dialog
///     %result = %saveFileDlg.Execute();
///     // Obtain the file name
///     %selectedFile = \"\";
///     if ( %result )
///        %selectedFile = %saveFileDlg.file;
///     // Cleanup
///     %saveFileDlg.delete();
///    @endtsexample
/// 
///    @return True if the file was selected was successfully found (opened) or declared (saved).)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool Execute(){

return pInvokes.m_ts.fnFileDialog_Execute(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public FileDialog_Base (){}
}}
