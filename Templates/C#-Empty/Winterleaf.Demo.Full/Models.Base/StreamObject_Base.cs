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
    [TypeConverter(typeof (TypeConverterGeneric<StreamObject_Base>))]
    public partial class StreamObject_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(StreamObject_Base ts, string simobjectid)
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
        public static bool operator !=(StreamObject_Base ts, string simobjectid)
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
        public static implicit operator string(StreamObject_Base ts)
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
        public static implicit operator StreamObject_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (StreamObject_Base) Omni.self.getSimObject(simobjectid, typeof (StreamObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(StreamObject_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator StreamObject_Base(int simobjectid)
        {
            return (StreamObject) Omni.self.getSimObject((uint) simobjectid, typeof (StreamObject_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(StreamObject_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator StreamObject_Base(uint simobjectid)
        {
            return (StreamObject_Base) Omni.self.getSimObject(simobjectid, typeof (StreamObject_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Copy from another StreamObject into this StreamObject   @param other The StreamObject to copy from.   @return True if the copy was successful.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool copyFrom(string other)
        {
            return m_ts.fnStreamObject_copyFrom(_ID, other);
        }

        /// <summary>
        /// @brief Gets the position in the stream      The easiest way to visualize this is to think of a cursor in a text file. If you have moved the cursor by    five characters, the current position is 5. If you move ahead 10 more characters, the position is now 15.    For StreamObject, when you read in the line the position is increased by the number of characters parsed,    the null terminator, and a newline.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   // This file contains two lines of text repeated:   // Hello World   // Hello World   %fsObject.open(\"./test.txt\", \"read\");   // Read in the first line   %line = %fsObject.readLine();   // Get the position of the stream   %position = %fsObject.getPosition();   // Print the current position   // Should be 13, 10 for the words, 1 for the space, 1 for the null terminator, and 1 for the newline   echo(%position);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return Number of bytes which stream has parsed so far, null terminators and newlines are included      @see setPosition())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getPosition()
        {
            return m_ts.fnStreamObject_getPosition(_ID);
        }

        /// <summary>
        /// @brief Gets a printable string form of the stream's status      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Get the status and print it   %status = %fsObject.getStatus();   echo(%status);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return String containing status constant, one of the following:   	OK - Stream is active and no file errors   	IOError - Something went wrong during read or writing the stream   	EOS - End of Stream reached (mostly for reads)   	IllegalCall - An unsupported operation used.  Always w/ accompanied by AssertWarn     Closed - Tried to operate on a closed stream (or detached filter)   	UnknownError - Catch all for an error of some kind   	Invalid - Entire stream is invalid)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getStatus()
        {
            return m_ts.fnStreamObject_getStatus(_ID);
        }

        /// <summary>
        /// @brief Gets the size of the stream      The size is dependent on the type of stream being used. If it is a file stream, returned value will    be the size of the file. If it is a memory stream, it will be the size of the allocated buffer.         @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   // This file contains the following two lines:   // HelloWorld   // HelloWorld   %fsObject.open(\"./test.txt\", \"read\");   // Found out how large the file stream is   // Then print it to the console   // Should be 22   %streamSize = %fsObject.getStreamSize();   echo(%streamSize);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return Size of stream, in bytes)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getStreamSize()
        {
            return m_ts.fnStreamObject_getStreamSize(_ID);
        }

        /// <summary>
        /// @brief Tests if the stream has reached the end of the file      This is an alternative name for isEOS. Both functions are interchangeable. This simply exists    for those familiar with some C++ file I/O standards.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Keep reading until we reach the end of the file   while( !%fsObject.isEOF() )   {      %line = %fsObject.readLine();      echo(%line);   }   // Made it to the end   echo(\"Finished reading file\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return True if the parser has reached the end of the file, false otherwise      @see isEOS())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isEOF()
        {
            return m_ts.fnStreamObject_isEOF(_ID);
        }

        /// <summary>
        /// @brief Tests if the stream has reached the end of the file      This is an alternative name for isEOF. Both functions are interchangeable. This simply exists    for those familiar with some C++ file I/O standards.   @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   %fsObject.open(\"./test.txt\", \"read\");   // Keep reading until we reach the end of the file   while( !%fsObject.isEOS() )   {      %line = %fsObject.readLine();      echo(%line);   }   // Made it to the end   echo(\"Finished reading file\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return True if the parser has reached the end of the file, false otherwise   @see isEOF())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isEOS()
        {
            return m_ts.fnStreamObject_isEOS(_ID);
        }

        /// <summary>
        /// @brief Read a line from the stream.      Emphasis on *line*, as in you cannot parse individual characters or chunks of data.    There is no limitation as to what kind of data you can read.      @tsexample   // Create a file stream object for reading   // This file contains the following two lines:   // HelloWorld   // HelloWorld   %fsObject = new FileStreamObject();   %fsObject.open(\"./test.txt\", \"read\");   // Read in the first line   %line = %fsObject.readLine();   // Print the line we just read   echo(%line);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return String containing the line of data that was just read      @see writeLine())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string readLine()
        {
            return m_ts.fnStreamObject_readLine(_ID);
        }

        /// <summary>
        /// @brief Read in a string up to the given maximum number of characters.   @param maxLength The maximum number of characters to read in.   @return The string that was read from the stream.   @see writeLongString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string readLongString(int maxLength)
        {
            return m_ts.fnStreamObject_readLongString(_ID, maxLength);
        }

        /// <summary>
        /// @brief Read a string up to a maximum of 256 characters   @return The string that was read from the stream.   @see writeString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string readString()
        {
            return m_ts.fnStreamObject_readString(_ID);
        }

        /// <summary>
        /// @brief Read in a string and place it on the string table.   @param caseSensitive If false then case will not be taken into account when attempting    to match the read in string with what is already in the string table.   @return The string that was read from the stream.   @see writeString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string readSTString(bool caseSensitive = false)
        {
            return m_ts.fnStreamObject_readSTString(_ID, caseSensitive);
        }

        /// <summary>
        /// @brief Gets the position in the stream      The easiest way to visualize this is to think of a cursor in a text file. If you have moved the cursor by    five characters, the current position is 5. If you move ahead 10 more characters, the position is now 15.    For StreamObject, when you read in the line the position is increased by the number of characters parsed,    the null terminator, and a newline. Using setPosition allows you to skip to specific points of the file.      @tsexample   // Create a file stream object for reading   %fsObject = new FileStreamObject();   // Open a file for reading   // This file contains the following two lines:   // 11111111111   // Hello World   %fsObject.open(\"./test.txt\", \"read\");   // Skip ahead by 12, which will bypass the first line entirely   %fsObject.setPosition(12);   // Read in the next line   %line = %fsObject.readLine();   // Print the line just read in, should be \"Hello World\"   echo(%line);   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample   @return Number of bytes which stream has parsed so far, null terminators and newlines are included      @see getPosition())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool setPosition(int newPosition)
        {
            return m_ts.fnStreamObject_setPosition(_ID, newPosition);
        }

        /// <summary>
        /// @brief Write a line to the stream, if it was opened for writing.      There is no limit as to what kind of data you can write. Any format and data is allowable, not just text.    Be careful of what you write, as whitespace, current values, and literals will be preserved.   @param line The data we are writing out to file.      @tsexample   // Create a file stream   %fsObject = new FileStreamObject();   // Open the file for writing   // If it does not exist, it is created. If it does exist, the file is cleared   %fsObject.open(\"./test.txt\", \"write\");   // Write a line to the file   %fsObject.writeLine(\"Hello World\");   // Write another line to the file   %fsObject.writeLine(\"Documentation Rocks!\");   // Always remember to close a file stream when finished   %fsObject.close();   @endtsexample      @see readLine())
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void writeLine(string line)
        {
            m_ts.fnStreamObject_writeLine(_ID, line);
        }

        /// <summary>
        /// @brief Write out a string up to the maximum number of characters.   @param maxLength The maximum number of characters that will be written.   @param string The string to write out to the stream.   @see readLongString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void writeLongString(int maxLength, string stringx)
        {
            m_ts.fnStreamObject_writeLongString(_ID, maxLength, stringx);
        }

        /// <summary>
        /// @brief Write out a string with a default maximum length of 256 characters.   @param string The string to write out to the stream   @param maxLength The maximum string length to write out with a default of 256 characters.  This    value should not be larger than 256 as it is written to the stream as a single byte.   @see readString()      @note When working with these particular string reading and writing methods, the stream    begins with the length of the string followed by the string itself, and does not include    a NULL terminator.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void writeString(string stringx, int maxLength = 256)
        {
            m_ts.fnStreamObject_writeString(_ID, stringx, maxLength);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public StreamObject_Base()
        {
        }
    }
}