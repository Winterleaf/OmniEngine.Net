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

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<FileObject_Base>))]
    public partial class FileObject_Base : SimObject
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
        public static bool operator !=(FileObject_Base ts, string simobjectid)
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
        public static implicit operator string(FileObject_Base ts)
        {
            if (ReferenceEquals(ts, null))
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
            return (FileObject_Base) Omni.self.getSimObject(simobjectid, typeof (FileObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(FileObject_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator FileObject_Base(int simobjectid)
        {
            return (FileObject) Omni.self.getSimObject((uint) simobjectid, typeof (FileObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(FileObject_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator FileObject_Base(uint simobjectid)
        {
            return (FileObject_Base) Omni.self.getSimObject(simobjectid, typeof (FileObject_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// ), FileObject.writeObject(SimObject, object prepend) 			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void writeObject(string simName, string objName = "")
        {
            m_ts.fn_FileObject_writeObject(_ID, simName, objName);
        }

        /// <summary>
        /// @brief Close the file.      It is EXTREMELY important that you call this function when you are finished reading or writing to a file.    Failing to do so is not only a bad programming practice, but could result in bad data or corrupt files.    Remember: Open, Read/Write, Close, Delete...in that order!      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Peek the first line   %line = %fileRead.peekLine();   // Print the line we just peeked   echo(%line);   // If we peek again...   %line = %fileRead.peekLine();   // We will get the same output as the first time   // since the stream did not move forward   echo(%line);   // Close the file when finished   %fileWrite.close();   // Cleanup the file object   %fileWrite.delete();   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void close()
        {
            m_ts.fnFileObject_close(_ID);
        }

        /// <summary>
        /// @brief Determines if the parser for this FileObject has reached the end of the file      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Keep reading until we reach the end of the file   while( !%fileRead.isEOF() )   {      %line = %fileRead.readline();      echo(%line);   }   // Made it to the end   echo(\"Finished reading file\");   @endtsexample   @return True if the parser has reached the end of the file, false otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isEOF()
        {
            return m_ts.fnFileObject_isEOF(_ID);
        }

        /// <summary>
        /// @brief Open a specified file for writing, adding data to the end of the file      There is no limit as to what kind of file you can write. Any format and data is allowable, not just text. Unlike openForWrite(),    which will erase an existing file if it is opened, openForAppend() preserves data in an existing file and adds to it.   @param filename Path, name, and extension of file to append to      @tsexample   // Create a file object for writing   %fileWrite = new FileObject();   // Open a file to write to, if it does not exist it will be created   // If it does exist, whatever we write will be added to the end   %result = %fileWrite.OpenForAppend(\"./test.txt\");   @endtsexample   @return True if file was successfully opened, false otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool openForAppend(string filename)
        {
            return m_ts.fnFileObject_openForAppend(_ID, filename);
        }

        /// <summary>
        /// @brief Open a specified file for reading      There is no limit as to what kind of file you can read. Any format and data contained within is accessible, not just text   @param filename Path, name, and extension of file to be read      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %result = %fileRead.OpenForRead(\"./test.txt\");   @endtsexample   @return True if file was successfully opened, false otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool openForRead(string filename)
        {
            return m_ts.fnFileObject_openForRead(_ID, filename);
        }

        /// <summary>
        /// @brief Open a specified file for writing      There is no limit as to what kind of file you can write. Any format and data is allowable, not just text   @param filename Path, name, and extension of file to write to      @tsexample   // Create a file object for writing   %fileWrite = new FileObject();   // Open a file to write to, if it does not exist it will be created   %result = %fileWrite.OpenForWrite(\"./test.txt\");   @endtsexample   @return True if file was successfully opened, false otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool openForWrite(string filename)
        {
            return m_ts.fnFileObject_openForWrite(_ID, filename);
        }

        /// <summary>
        /// @brief Read a line from the file without moving the stream position.      Emphasis on *line*, as in you cannot parse individual characters or chunks of data.     There is no limitation as to what kind of data you can read. Unlike readLine, the parser does not move forward after reading.   @param filename Path, name, and extension of file to be read      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Peek the first line   %line = %fileRead.peekLine();   // Print the line we just peeked   echo(%line);   // If we peek again...   %line = %fileRead.peekLine();   // We will get the same output as the first time   // since the stream did not move forward   echo(%line);   @endtsexample   @return String containing the line of data that was just peeked)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string peekLine()
        {
            return m_ts.fnFileObject_peekLine(_ID);
        }

        /// <summary>
        /// @brief Read a line from file.      Emphasis on *line*, as in you cannot parse individual characters or chunks of data.     There is no limitation as to what kind of data you can read.      @tsexample   // Create a file object for reading   %fileRead = new FileObject();   // Open a text file, if it exists   %fileRead.OpenForRead(\"./test.txt\");   // Read in the first line   %line = %fileRead.readline();   // Print the line we just read   echo(%line);   @endtsexample   @return String containing the line of data that was just read)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string readLine()
        {
            return m_ts.fnFileObject_readLine(_ID);
        }

        /// <summary>
        /// @brief Write a line to the file, if it was opened for writing.      There is no limit as to what kind of text you can write. Any format and data is allowable, not just text.    Be careful of what you write, as whitespace, current values, and literals will be preserved.   @param text The data we are writing out to file.      @tsexample   // Create a file object for writing   %fileWrite = new FileObject();   // Open a file to write to, if it does not exist it will be created   %fileWrite.OpenForWrite(\"./test.txt\");   // Write a line to the text files   %fileWrite.writeLine(\"READ. READ CODE. CODE\");   @endtsexample   @return True if file was successfully opened, false otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void writeLine(string text)
        {
            m_ts.fnFileObject_writeLine(_ID, text);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public FileObject_Base()
        {
        }
    }
}