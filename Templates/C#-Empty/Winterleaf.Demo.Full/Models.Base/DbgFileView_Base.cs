


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
    [TypeConverter(typeof(TypeConverterGeneric<DbgFileView_Base>))]
    public partial class DbgFileView_Base: GuiArrayCtrl
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DbgFileView_Base ts, string simobjectid)
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
        public static bool operator !=(DbgFileView_Base ts, string simobjectid)
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
        public static implicit operator string( DbgFileView_Base ts)
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
        public static implicit operator DbgFileView_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (DbgFileView_Base) Omni.self.getSimObject(simobjectid,typeof(DbgFileView_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( DbgFileView_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DbgFileView_Base(int simobjectid)
            {
            return  (DbgFileView) Omni.self.getSimObject((uint)simobjectid,typeof(DbgFileView_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( DbgFileView_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DbgFileView_Base(uint simobjectid)
            {
            return  (DbgFileView_Base) Omni.self.getSimObject(simobjectid,typeof(DbgFileView_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// ()
///               Clear all break points in the current file.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearBreakPositions(){

pInvokes.m_ts.fn_DbgFileView_clearBreakPositions(_ID);
}
/// <summary>
/// (string findThis)
///               Find the specified string in the currently viewed file and 
///               scroll it into view.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool findString(string findThis){

return pInvokes.m_ts.fn_DbgFileView_findString(_ID, findThis);
}
/// <summary>
/// ()
///               Get the currently executing file and line, if any.
///               @returns A string containing the file, a tab, and then the line number.
///                Use getField() with this.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getCurrentLine(){

return pInvokes.m_ts.fn_DbgFileView_getCurrentLine(_ID);
}
/// <summary>
/// (string filename)
///               Open a file for viewing.
///               @note This loads the file from the local system.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool open(string filename){

return pInvokes.m_ts.fn_DbgFileView_open(_ID, filename);
}
/// <summary>
/// (int line)
///               Remove a breakpoint from the specified line.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeBreak(uint line){

pInvokes.m_ts.fn_DbgFileView_removeBreak(_ID, line);
}
/// <summary>
/// (int line)
///               Set a breakpoint at the specified line.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBreak(uint line){

pInvokes.m_ts.fn_DbgFileView_setBreak(_ID, line);
}
/// <summary>
/// (int line)
///               Set a breakpoint at the specified line.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setBreakPosition(uint line){

pInvokes.m_ts.fn_DbgFileView_setBreakPosition(_ID, line);
}
/// <summary>
/// (int line, bool selected)
///               Set the current highlighted line.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCurrentLine(int line, bool selected){

pInvokes.m_ts.fn_DbgFileView_setCurrentLine(_ID, line, selected);
}

#endregion
#region T3D Callbacks

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemoveBreakPoint(string line){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSetBreakPoint(string line){}

        /// <summary>
        ///  )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onSetWatch(string variable){}

#endregion
public DbgFileView_Base (){}
}}
