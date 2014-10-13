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
    [TypeConverter(typeof (TypeConverterGeneric<MessageVector_Base>))]
    public partial class MessageVector_Base : SimObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(MessageVector_Base ts, string simobjectid)
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
        public static bool operator !=(MessageVector_Base ts, string simobjectid)
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
        public static implicit operator string(MessageVector_Base ts)
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
        public static implicit operator MessageVector_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (MessageVector_Base) Omni.self.getSimObject(simobjectid, typeof (MessageVector_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(MessageVector_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MessageVector_Base(int simobjectid)
        {
            return (MessageVector) Omni.self.getSimObject((uint) simobjectid, typeof (MessageVector_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(MessageVector_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MessageVector_Base(uint simobjectid)
        {
            return (MessageVector_Base) Omni.self.getSimObject(simobjectid, typeof (MessageVector_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// ), (string filename, string header=NULL)              Dump the message vector to a file, optionally prefixing a header.			  @hide)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void dump(string filename, string header = "")
        {
            m_ts.fn_MessageVector_dump(_ID, filename, header);
        }

        /// <summary>
        /// Clear all messages in the vector   @tsexample   HudMessageVector.clear();   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void clear()
        {
            m_ts.fnMessageVector_clear(_ID);
        }

        /// <summary>
        /// Delete the line at the specified position.   @param deletePos Position in the vector containing the line to be deleted   @tsexample   // Delete the first line (index 0) in the vector...   HudMessageVector.deleteLine(0);   @endtsexample   @return False if deletePos is greater than the number of lines in the current vector)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool deleteLine(int deletePos)
        {
            return m_ts.fnMessageVector_deleteLine(_ID, deletePos);
        }

        /// <summary>
        /// Scan through the vector, returning the line number of the first line that matches the specified tag; else returns -1 if no match was found.   @param tag Numerical value assigned to a message when it was added or inserted   @tsexample   // Locate a line of text tagged with the value \"1\", then delete it.   %taggedLine = HudMessageVector.getLineIndexByTag(1);   HudMessageVector.deleteLine(%taggedLine);   @endtsexample   @return Line with matching tag, other wise -1)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getLineIndexByTag(int tag)
        {
            return m_ts.fnMessageVector_getLineIndexByTag(_ID, tag);
        }

        /// <summary>
        /// Get the tag of a specified line.   @param pos Position in vector to grab tag from   @tsexample   // Remove all lines that do not have a tag value of 1.   while( HudMessageVector.getNumLines())   {      %tag = HudMessageVector.getLineTag(1);      if(%tag != 1)         %tag.delete();      HudMessageVector.popFrontLine();   }   @endtsexample   @return Tag value of a given line, if the position is greater than the number of lines return 0)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getLineTag(int pos)
        {
            return m_ts.fnMessageVector_getLineTag(_ID, pos);
        }

        /// <summary>
        /// Get the text at a specified line.   @param pos Position in vector to grab text from   @tsexample   // Print a line of text at position 1.   %text = HudMessageVector.getLineText(1);   echo(%text);   @endtsexample   @return Text at specified line, if the position is greater than the number of lines return \"\")
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getLineText(int pos)
        {
            return m_ts.fnMessageVector_getLineText(_ID, pos);
        }

        /// <summary>
        /// Scan through the lines in the vector, returning the first line that has a matching tag.   @param tag Numerical value assigned to a message when it was added or inserted   @tsexample   // Locate text in the vector tagged with the value \"1\", then print it   %taggedText = HudMessageVector.getLineTextByTag(1);   echo(%taggedText);   @endtsexample   @return Text from a line with matching tag, other wise \"\")
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getLineTextByTag(int tag)
        {
            return m_ts.fnMessageVector_getLineTextByTag(_ID, tag);
        }

        /// <summary>
        /// Get the number of lines in the vector.   @tsexample   // Find out how many lines have been stored in HudMessageVector   %chatLines = HudMessageVector.getNumLines();   echo(%chatLines);   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getNumLines()
        {
            return m_ts.fnMessageVector_getNumLines(_ID);
        }

        /// <summary>
        /// Push a line onto the back of the list.   @param msg Text that makes up the message   @param tag Numerical value associated with this message, useful for searching.   @tsexample   // Add the message...   HudMessageVector.insertLine(1, \"Hello World\", 0);   @endtsexample   @return False if insertPos is greater than the number of lines in the current vector)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool insertLine(int insertPos, string msg, int tag)
        {
            return m_ts.fnMessageVector_insertLine(_ID, insertPos, msg, tag);
        }

        /// <summary>
        /// Pop a line from the back of the list; destroys the line.   @tsexample   HudMessageVector.popBackLine();   @endtsexample   @return False if there are no lines to pop (underflow), true otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool popBackLine()
        {
            return m_ts.fnMessageVector_popBackLine(_ID);
        }

        /// <summary>
        /// Pop a line from the front of the vector, destroying the line.   @tsexample   HudMessageVector.popFrontLine();   @endtsexample   @return False if there are no lines to pop (underflow), true otherwise)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool popFrontLine()
        {
            return m_ts.fnMessageVector_popFrontLine(_ID);
        }

        /// <summary>
        /// Push a line onto the back of the list.   @param msg Text that makes up the message   @param tag Numerical value associated with this message, useful for searching.   @tsexample   // Add the message...   HudMessageVector.pushBackLine(\"Hello World\", 0);   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushBackLine(string msg, int tag)
        {
            m_ts.fnMessageVector_pushBackLine(_ID, msg, tag);
        }

        /// <summary>
        /// Push a line onto the front of the vector.   @param msg Text that makes up the message   @param tag Numerical value associated with this message, useful for searching.   @tsexample   // Add the message...   HudMessageVector.pushFrontLine(\"Hello World\", 0);   @endtsexample)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pushFrontLine(string msg, int tag)
        {
            m_ts.fnMessageVector_pushFrontLine(_ID, msg, tag);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public MessageVector_Base()
        {
        }
    }
}