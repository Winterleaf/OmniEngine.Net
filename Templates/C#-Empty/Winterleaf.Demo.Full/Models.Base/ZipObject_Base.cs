


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
    [TypeConverter(typeof(TypeConverterGeneric<ZipObject_Base>))]
    public partial class ZipObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ZipObject_Base ts, string simobjectid)
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
        public static bool operator !=(ZipObject_Base ts, string simobjectid)
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
        public static implicit operator string( ZipObject_Base ts)
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
        public static implicit operator ZipObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ZipObject_Base) Omni.self.getSimObject(simobjectid,typeof(ZipObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ZipObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ZipObject_Base(int simobjectid)
            {
            return  (ZipObject) Omni.self.getSimObject((uint)simobjectid,typeof(ZipObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ZipObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ZipObject_Base(uint simobjectid)
            {
            return  (ZipObject_Base) Omni.self.getSimObject(simobjectid,typeof(ZipObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Add a file to the zip archive
///    
///    @param filename The path and name of the file to add to the zip archive.
///    @param pathInZip The path and name to be given to the file within the zip archive.
///    @param replace If a file already exists within the zip archive at the same location as this 
///    new file, this parameter indicates if it should be replaced.  By default, it will be replaced.
///    @return True if the file was successfully added to the zip archive.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool addFile(string filename, string pathInZip, bool replace = true){

return pInvokes.m_ts.fnZipObject_addFile(_ID, filename, pathInZip, replace);
}
/// <summary>
/// @brief Close an already opened zip archive.
///    @see openArchive())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void closeArchive(){

pInvokes.m_ts.fnZipObject_closeArchive(_ID);
}
/// <summary>
/// @brief Close a previously opened file within the zip archive.
///    @param stream The StreamObject of a previously opened file within the zip archive.
///    @see openFileForRead()
///    @see openFileForWrite())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void closeFile(string stream){

pInvokes.m_ts.fnZipObject_closeFile(_ID, stream);
}
/// <summary>
/// @brief Deleted the given file from the zip archive
///    @param pathInZip The path and name of the file to be deleted from the zip archive.
///    @return True of the file was successfully deleted.
/// 
///    @note Files that have been deleted from the archive will still show up with a 
///    getFileEntryCount() until you close the archive.  If you need to have the file 
///    count up to date with only valid files within the archive, you could close and then 
///    open the archive again.
/// 
///    @see getFileEntryCount()
///    @see closeArchive()
///    @see openArchive())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool deleteFile(string pathInZip){

return pInvokes.m_ts.fnZipObject_deleteFile(_ID, pathInZip);
}
/// <summary>
/// @brief Extact a file from the zip archive and save it to the requested location.
///    @param pathInZip The path and name of the file to be extracted within the zip archive.
///    @param filename The path and name to give the extracted file.
///    @return True if the file was successfully extracted.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool extractFile(string pathInZip, string filename){

return pInvokes.m_ts.fnZipObject_extractFile(_ID, pathInZip, filename);
}
/// <summary>
/// @brief Get information on the requested file within the zip archive.
/// 
///    This methods provides five different pieces of information for the requested file:
///    ul>li>filename - The path and name of the file within the zip archive/li>
///    li>uncompressed size/li>
///    li>compressed size/li>
///    li>compression method/li>
///    li>CRC32/li>/ul>
/// 
///    Use getFileEntryCount() to obtain the total number of files within the archive.
/// 
///    @param index The index of the file within the zip archive.  Use getFileEntryCount() to determine the number of files.
///    @return A tab delimited list of information on the requested file, or an empty string if the file could not be found.
/// 
///    @see getFileEntryCount())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getFileEntry(int index){

return pInvokes.m_ts.fnZipObject_getFileEntry(_ID, index);
}
/// <summary>
/// @brief Get the number of files within the zip archive.
/// 
///    Use getFileEntry() to retrive information on each file within the archive.
/// 
///    @return The number of files within the zip archive.
/// 
///    @note The returned count will include any files that have been deleted from 
///    the archive using deleteFile().  To clear out all deleted files, you could 
///    close and then open the archive again.
/// 
///    @see getFileEntry()
///    @see closeArchive()
///    @see openArchive())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getFileEntryCount(){

return pInvokes.m_ts.fnZipObject_getFileEntryCount(_ID);
}
/// <summary>
/// read ),
///    @brief Open a zip archive for manipulation.
/// 
///    Once a zip archive is opened use the various ZipObject methods for 
///    working with the files within the archive.  Be sure to close the archive when 
///    you are done with it.
/// 
///    @param filename The path and file name of the zip archive to open.
///    @param accessMode One of read, write or readwrite
/// 
///    @return True is the archive was successfully opened.
///    
///    @note If you wish to make any changes to the archive, be sure to open it 
///    with a write or readwrite access mode.
/// 
///    @see closeArchive())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool openArchive(string filename, string accessMode = "read"){

return pInvokes.m_ts.fnZipObject_openArchive(_ID, filename, accessMode);
}
/// <summary>
/// @brief Open a file within the zip archive for reading.
/// 
///    Be sure to close the file when you are done with it.
/// 
///    @param filename The path and name of the file to open within the zip archive.
/// 
///    @return A standard StreamObject is returned for working with the file.
///    @note You must first open the zip archive before working with files within it.
/// 
///    @see closeFile()
///    @see openArchive())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string openFileForRead(string filename){

return pInvokes.m_ts.fnZipObject_openFileForRead(_ID, filename);
}
/// <summary>
/// @brief Open a file within the zip archive for writing to.
///    
///    Be sure to close the file when you are done with it.
/// 
///    @param filename The path and name of the file to open within the zip archive.
/// 
///    @return A standard StreamObject is returned for working with the file.
///    @note You must first open the zip archive before working with files within it.
/// 
///    @see closeFile()
///    @see openArchive())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string openFileForWrite(string filename){

return pInvokes.m_ts.fnZipObject_openFileForWrite(_ID, filename);
}

#endregion
#region T3D Callbacks

#endregion
public ZipObject_Base (){}
}}
