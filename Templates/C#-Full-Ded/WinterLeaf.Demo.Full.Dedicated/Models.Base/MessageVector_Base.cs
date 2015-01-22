


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
    [TypeConverter(typeof(TypeConverterGeneric<MessageVector_Base>))]
    public partial class MessageVector_Base: SimObject
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
        public static bool operator !=(MessageVector_Base ts, string simobjectid)
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
        public static implicit operator string( MessageVector_Base ts)
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
        public static implicit operator MessageVector_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (MessageVector_Base) Omni.self.getSimObject(simobjectid,typeof(MessageVector_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( MessageVector_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator MessageVector_Base(int simobjectid)
            {
            return  (MessageVector) Omni.self.getSimObject((uint)simobjectid,typeof(MessageVector_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( MessageVector_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator MessageVector_Base(uint simobjectid)
            {
            return  (MessageVector_Base) Omni.self.getSimObject(simobjectid,typeof(MessageVector_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ), (string filename, string header=NULL)
///               Dump the message vector to a file, optionally prefixing a header.
/// 			  @hide)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void dump(string filename, string header = ""){

pInvokes.m_ts.fn_MessageVector_dump(_ID, filename, header);
}
/// <summary>
/// Clear all messages in the vector
///    @tsexample
///    HudMessageVector.clear();
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clear(){

pInvokes.m_ts.fnMessageVector_clear(_ID);
}
/// <summary>
/// Delete the line at the specified position.
///    @param deletePos Position in the vector containing the line to be deleted
///    @tsexample
///    // Delete the first line (index 0) in the vector...
///    HudMessageVector.deleteLine(0);
///    @endtsexample
///    @return False if deletePos is greater than the number of lines in the current vector)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool deleteLine(int deletePos){

return pInvokes.m_ts.fnMessageVector_deleteLine(_ID, deletePos);
}
/// <summary>
/// Scan through the vector, returning the line number of the first line that matches the specified tag; else returns -1 if no match was found.
///    @param tag Numerical value assigned to a message when it was added or inserted
///    @tsexample
///    // Locate a line of text tagged with the value \"1\", then delete it.
///    %taggedLine = HudMessageVector.getLineIndexByTag(1);
///    HudMessageVector.deleteLine(%taggedLine);
///    @endtsexample
///    @return Line with matching tag, other wise -1)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getLineIndexByTag(int tag){

return pInvokes.m_ts.fnMessageVector_getLineIndexByTag(_ID, tag);
}
/// <summary>
/// Get the tag of a specified line.
///    @param pos Position in vector to grab tag from
///    @tsexample
///    // Remove all lines that do not have a tag value of 1.
///    while( HudMessageVector.getNumLines())
///    {
///       %tag = HudMessageVector.getLineTag(1);
///       if(%tag != 1)
///          %tag.delete();
///       HudMessageVector.popFrontLine();
///    }
///    @endtsexample
///    @return Tag value of a given line, if the position is greater than the number of lines return 0)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getLineTag(int pos){

return pInvokes.m_ts.fnMessageVector_getLineTag(_ID, pos);
}
/// <summary>
/// Get the text at a specified line.
///    @param pos Position in vector to grab text from
///    @tsexample
///    // Print a line of text at position 1.
///    %text = HudMessageVector.getLineText(1);
///    echo(%text);
///    @endtsexample
///    @return Text at specified line, if the position is greater than the number of lines return \"\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLineText(int pos){

return pInvokes.m_ts.fnMessageVector_getLineText(_ID, pos);
}
/// <summary>
/// Scan through the lines in the vector, returning the first line that has a matching tag.
///    @param tag Numerical value assigned to a message when it was added or inserted
///    @tsexample
///    // Locate text in the vector tagged with the value \"1\", then print it
///    %taggedText = HudMessageVector.getLineTextByTag(1);
///    echo(%taggedText);
///    @endtsexample
///    @return Text from a line with matching tag, other wise \"\")
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLineTextByTag(int tag){

return pInvokes.m_ts.fnMessageVector_getLineTextByTag(_ID, tag);
}
/// <summary>
/// Get the number of lines in the vector.
///    @tsexample
///    // Find out how many lines have been stored in HudMessageVector
///    %chatLines = HudMessageVector.getNumLines();
///    echo(%chatLines);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumLines(){

return pInvokes.m_ts.fnMessageVector_getNumLines(_ID);
}
/// <summary>
/// Push a line onto the back of the list.
///    @param msg Text that makes up the message
///    @param tag Numerical value associated with this message, useful for searching.
///    @tsexample
///    // Add the message...
///    HudMessageVector.insertLine(1, \"Hello World\", 0);
///    @endtsexample
///    @return False if insertPos is greater than the number of lines in the current vector)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool insertLine(int insertPos, string msg, int tag){

return pInvokes.m_ts.fnMessageVector_insertLine(_ID, insertPos, msg, tag);
}
/// <summary>
/// Pop a line from the back of the list; destroys the line.
///    @tsexample
///    HudMessageVector.popBackLine();
///    @endtsexample
///    @return False if there are no lines to pop (underflow), true otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool popBackLine(){

return pInvokes.m_ts.fnMessageVector_popBackLine(_ID);
}
/// <summary>
/// Pop a line from the front of the vector, destroying the line.
///    @tsexample
///    HudMessageVector.popFrontLine();
///    @endtsexample
///    @return False if there are no lines to pop (underflow), true otherwise)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool popFrontLine(){

return pInvokes.m_ts.fnMessageVector_popFrontLine(_ID);
}
/// <summary>
/// Push a line onto the back of the list.
///    @param msg Text that makes up the message
///    @param tag Numerical value associated with this message, useful for searching.
///    @tsexample
///    // Add the message...
///    HudMessageVector.pushBackLine(\"Hello World\", 0);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushBackLine(string msg, int tag){

pInvokes.m_ts.fnMessageVector_pushBackLine(_ID, msg, tag);
}
/// <summary>
/// Push a line onto the front of the vector.
///    @param msg Text that makes up the message
///    @param tag Numerical value associated with this message, useful for searching.
///    @tsexample
///    // Add the message...
///    HudMessageVector.pushFrontLine(\"Hello World\", 0);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pushFrontLine(string msg, int tag){

pInvokes.m_ts.fnMessageVector_pushFrontLine(_ID, msg, tag);
}

#endregion
#region T3D Callbacks

#endregion
public MessageVector_Base (){}
}}
