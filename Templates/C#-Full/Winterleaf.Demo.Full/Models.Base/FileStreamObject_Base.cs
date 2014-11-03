


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
    [TypeConverter(typeof(TypeConverterGeneric<FileStreamObject_Base>))]
    public partial class FileStreamObject_Base: StreamObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(FileStreamObject_Base ts, string simobjectid)
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
        public static bool operator !=(FileStreamObject_Base ts, string simobjectid)
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
        public static implicit operator string( FileStreamObject_Base ts)
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
        public static implicit operator FileStreamObject_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (FileStreamObject_Base) Omni.self.getSimObject(simobjectid,typeof(FileStreamObject_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( FileStreamObject_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FileStreamObject_Base(int simobjectid)
            {
            return  (FileStreamObject) Omni.self.getSimObject((uint)simobjectid,typeof(FileStreamObject_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( FileStreamObject_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FileStreamObject_Base(uint simobjectid)
            {
            return  (FileStreamObject_Base) Omni.self.getSimObject(simobjectid,typeof(FileStreamObject_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Close the file. You can no longer read or write to it unless you open it again.
///    
///    @tsexample
///    // Create a file stream object for reading
///    %fsObject = new FileStreamObject();
///    // Open a file for reading
///    %fsObject.open(\"./test.txt\", \"read\");
///    // Always remember to close a file stream when finished
///    %fsObject.close();
///    @endtsexample
///    
///    @see open())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void close(){

pInvokes.m_ts.fnFileStreamObject_close(_ID);
}
/// <summary>
/// @brief Open a file for reading, writing, reading and writing, or appending
///    
///    Using \"Read\" for the open mode allows you to parse the contents of file, but not making modifications. \"Write\" will create a new 
///    file if it does not exist, or erase the contents of an existing file when opened. Write also allows you to modify the contents of the file.
/// 
///    \"ReadWrite\" will provide the ability to parse data (read it in) and manipulate data (write it out) interchangeably. Keep in mind the stream can 
///    move during each operation. Finally, \"WriteAppend\" will open a file if it exists, but will not clear the contents. You can write new data starting 
///     at the end of the files existing contents.
/// 
///    @param filename Name of file to open
///    @param openMode One of \"Read\", \"Write\", \"ReadWrite\" or \"WriteAppend\"
/// 
///    @tsexample
///    // Create a file stream object for reading
///    %fsObject = new FileStreamObject();
///    // Open a file for reading
///    %fsObject.open(\"./test.txt\", \"read\");
///    // Get the status and print it
///    %status = %fsObject.getStatus();
///    echo(%status);
///    // Always remember to close a file stream when finished
///    %fsObject.close();
///    @endtsexample
/// 
///    @return True if the file was successfully opened, false if something went wrong
///    
///    @see close())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool open(string filename, string openMode){

return pInvokes.m_ts.fnFileStreamObject_open(_ID, filename, openMode);
}

#endregion
#region T3D Callbacks

#endregion
public FileStreamObject_Base (){}
}}
