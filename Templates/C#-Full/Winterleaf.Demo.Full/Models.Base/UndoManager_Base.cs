


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
    [TypeConverter(typeof(TypeConverterGeneric<UndoManager_Base>))]
    public partial class UndoManager_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(UndoManager_Base ts, string simobjectid)
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
        public static bool operator !=(UndoManager_Base ts, string simobjectid)
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
        public static implicit operator string( UndoManager_Base ts)
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
        public static implicit operator UndoManager_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (UndoManager_Base) Omni.self.getSimObject(simobjectid,typeof(UndoManager_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( UndoManager_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator UndoManager_Base(int simobjectid)
            {
            return  (UndoManager) Omni.self.getSimObject((uint)simobjectid,typeof(UndoManager_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( UndoManager_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator UndoManager_Base(uint simobjectid)
            {
            return  (UndoManager_Base) Omni.self.getSimObject(simobjectid,typeof(UndoManager_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Number of undo and redo levels.
/// </summary>
[MemberGroup("")]
public int numLevels
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numLevels").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numLevels", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Clears the undo manager.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void clearAll(){

pInvokes.m_ts.fn_UndoManager_clearAll(_ID);
}
/// <summary>
/// UndoManager.getNextRedoName();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getNextRedoName(){

return pInvokes.m_ts.fn_UndoManager_getNextRedoName(_ID);
}
/// <summary>
/// UndoManager.getNextUndoName();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getNextUndoName(){

return pInvokes.m_ts.fn_UndoManager_getNextUndoName(_ID);
}
/// <summary>
/// (index))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRedoAction(int index){

return pInvokes.m_ts.fn_UndoManager_getRedoAction(_ID, index);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getRedoCount(){

return pInvokes.m_ts.fn_UndoManager_getRedoCount(_ID);
}
/// <summary>
/// (index))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getRedoName(int index){

return pInvokes.m_ts.fn_UndoManager_getRedoName(_ID, index);
}
/// <summary>
/// (index))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getUndoAction(int index){

return pInvokes.m_ts.fn_UndoManager_getUndoAction(_ID, index);
}
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getUndoCount(){

return pInvokes.m_ts.fn_UndoManager_getUndoCount(_ID);
}
/// <summary>
/// (index))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getUndoName(int index){

return pInvokes.m_ts.fn_UndoManager_getUndoName(_ID, index);
}
/// <summary>
/// ( bool discard=false ) - Pop the current CompoundUndoAction off the stack. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void popCompound(bool discard = false){

pInvokes.m_ts.fn_UndoManager_popCompound(_ID, discard);
}
/// <summary>
/// \"\"), ( string name=\"\" ) - Push a CompoundUndoAction onto the compound stack for assembly. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string pushCompound(string name = "\"\""){

return pInvokes.m_ts.fn_UndoManager_pushCompound(_ID, name);
}
/// <summary>
/// UndoManager.redo();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void redo(){

pInvokes.m_ts.fn_UndoManager_redo(_ID);
}
/// <summary>
/// UndoManager.undo();)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void undo(){

pInvokes.m_ts.fn_UndoManager_undo(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onClear(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemoveUndo(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUndo(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRedo(){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAddUndo(){}

#endregion
public UndoManager_Base (){}
}}
