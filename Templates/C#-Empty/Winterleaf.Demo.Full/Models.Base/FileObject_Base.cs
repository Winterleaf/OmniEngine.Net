


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
    [TypeConverter(typeof(TypeConverterGeneric<FileObject_Base>))]
    public partial class FileObject_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FileObject_Base ts, string simobjectid)
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
        public static bool operator !=(FileObject_Base ts, string simobjectid)
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
        public static implicit operator string( FileObject_Base ts)
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
        public static implicit operator FileObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (FileObject_Base) Omni.self.getSimObject(simobjectid,typeof(FileObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( FileObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FileObject_Base(int simobjectid)
            {
            return  (FileObject) Omni.self.getSimObject((uint)simobjectid,typeof(FileObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( FileObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FileObject_Base(uint simobjectid)
            {
            return  (FileObject_Base) Omni.self.getSimObject(simobjectid,typeof(FileObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ), FileObject.writeObject(SimObject, object prepend) 
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void writeObject(string simName, string objName = ""){

pInvokes.m_ts.fn_FileObject_writeObject(_ID, simName, objName);
}
/// <summary>
/// @brief Close the file.
///    
///    It is EXTREMELY important that you call this function when you are finished reading or writing to a file. 
///    Failing to do so is not only a bad programming practice, but could result in bad data or corrupt files. 
///    Remember: Open, Read/Write, Close, Delete...in that order!
///    
///    @tsexample
///    // Create a file object for reading
///    %fileRead = new FileObject();
///    // Open a text file, if it exists
///    %fileRead.OpenForRead(\"./test.txt\");
///    // Peek the first line
///    %line = %fileRead.peekLine();
///    // Print the line we just peeked
///    echo(%line);
///    // If we peek again...
///    %line = %fileRead.peekLine();
///    // We will get the same output as the first time
///    // since the stream did not move forward
///    echo(%line);
///    // Close the file when finished
///    %fileWrite.close();
///    // Cleanup the file object
///    %fileWrite.delete();
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void close(){

pInvokes.m_ts.fnFileObject_close(_ID);
}
/// <summary>
/// @brief Determines if the parser for this FileObject has reached the end of the file
///    
///    @tsexample
///    // Create a file object for reading
///    %fileRead = new FileObject();
///    // Open a text file, if it exists
///    %fileRead.OpenForRead(\"./test.txt\");
///    // Keep reading until we reach the end of the file
///    while( !%fileRead.isEOF() )
///    {
///       %line = %fileRead.readline();
///       echo(%line);
///    }
///    // Made it to the end
///    echo(\"Finished reading file\");
///    @endtsexample
/// 
///    @return True if the parser has reached the end of the file, false otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isEOF(){

return pInvokes.m_ts.fnFileObject_isEOF(_ID);
}
/// <summary>
/// @brief Open a specified file for writing, adding data to the end of the file
///    
///    There is no limit as to what kind of file you can write. Any format and data is allowable, not just text. Unlike openForWrite(), 
///    which will erase an existing file if it is opened, openForAppend() preserves data in an existing file and adds to it.
/// 
///    @param filename Path, name, and extension of file to append to
///    
///    @tsexample
///    // Create a file object for writing
///    %fileWrite = new FileObject();
///    // Open a file to write to, if it does not exist it will be created
///    // If it does exist, whatever we write will be added to the end
///    %result = %fileWrite.OpenForAppend(\"./test.txt\");
///    @endtsexample
/// 
///    @return True if file was successfully opened, false otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool openForAppend(string filename){

return pInvokes.m_ts.fnFileObject_openForAppend(_ID, filename);
}
/// <summary>
/// @brief Open a specified file for reading
///    
///    There is no limit as to what kind of file you can read. Any format and data contained within is accessible, not just text
/// 
///    @param filename Path, name, and extension of file to be read
///    
///    @tsexample
///    // Create a file object for reading
///    %fileRead = new FileObject();
///    // Open a text file, if it exists
///    %result = %fileRead.OpenForRead(\"./test.txt\");
///    @endtsexample
/// 
///    @return True if file was successfully opened, false otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool openForRead(string filename){

return pInvokes.m_ts.fnFileObject_openForRead(_ID, filename);
}
/// <summary>
/// @brief Open a specified file for writing
///    
///    There is no limit as to what kind of file you can write. Any format and data is allowable, not just text
/// 
///    @param filename Path, name, and extension of file to write to
///    
///    @tsexample
///    // Create a file object for writing
///    %fileWrite = new FileObject();
///    // Open a file to write to, if it does not exist it will be created
///    %result = %fileWrite.OpenForWrite(\"./test.txt\");
///    @endtsexample
/// 
///    @return True if file was successfully opened, false otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool openForWrite(string filename){

return pInvokes.m_ts.fnFileObject_openForWrite(_ID, filename);
}
/// <summary>
/// @brief Read a line from the file without moving the stream position.
///    
///    Emphasis on *line*, as in you cannot parse individual characters or chunks of data.  
///    There is no limitation as to what kind of data you can read. Unlike readLine, the parser does not move forward after reading.
/// 
///    @param filename Path, name, and extension of file to be read
///    
///    @tsexample
///    // Create a file object for reading
///    %fileRead = new FileObject();
///    // Open a text file, if it exists
///    %fileRead.OpenForRead(\"./test.txt\");
///    // Peek the first line
///    %line = %fileRead.peekLine();
///    // Print the line we just peeked
///    echo(%line);
///    // If we peek again...
///    %line = %fileRead.peekLine();
///    // We will get the same output as the first time
///    // since the stream did not move forward
///    echo(%line);
///    @endtsexample
/// 
///    @return String containing the line of data that was just peeked)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string peekLine(){

return pInvokes.m_ts.fnFileObject_peekLine(_ID);
}
/// <summary>
/// @brief Read a line from file.
///    
///    Emphasis on *line*, as in you cannot parse individual characters or chunks of data.  
///    There is no limitation as to what kind of data you can read.
///    
///    @tsexample
///    // Create a file object for reading
///    %fileRead = new FileObject();
///    // Open a text file, if it exists
///    %fileRead.OpenForRead(\"./test.txt\");
///    // Read in the first line
///    %line = %fileRead.readline();
///    // Print the line we just read
///    echo(%line);
///    @endtsexample
/// 
///    @return String containing the line of data that was just read)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string readLine(){

return pInvokes.m_ts.fnFileObject_readLine(_ID);
}
/// <summary>
/// @brief Write a line to the file, if it was opened for writing.
///    
///    There is no limit as to what kind of text you can write. Any format and data is allowable, not just text. 
///    Be careful of what you write, as whitespace, current values, and literals will be preserved.
/// 
///    @param text The data we are writing out to file.
///    
///    @tsexample
///    // Create a file object for writing
///    %fileWrite = new FileObject();
///    // Open a file to write to, if it does not exist it will be created
///    %fileWrite.OpenForWrite(\"./test.txt\");
///    // Write a line to the text files
///    %fileWrite.writeLine(\"READ. READ CODE. CODE\");
///    @endtsexample
/// 
///    @return True if file was successfully opened, false otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void writeLine(string text){

pInvokes.m_ts.fnFileObject_writeLine(_ID, text);
}

#endregion
#region T3D Callbacks

#endregion
public FileObject_Base (){}
}}
