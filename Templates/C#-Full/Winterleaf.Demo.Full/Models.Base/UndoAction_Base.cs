


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
    [TypeConverter(typeof(TypeConverterGeneric<UndoAction_Base>))]
    public partial class UndoAction_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(UndoAction_Base ts, string simobjectid)
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
        public static bool operator !=(UndoAction_Base ts, string simobjectid)
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
        public static implicit operator string( UndoAction_Base ts)
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
        public static implicit operator UndoAction_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (UndoAction_Base) Omni.self.getSimObject(simobjectid,typeof(UndoAction_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( UndoAction_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator UndoAction_Base(int simobjectid)
            {
            return  (UndoAction) Omni.self.getSimObject((uint)simobjectid,typeof(UndoAction_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( UndoAction_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator UndoAction_Base(uint simobjectid)
            {
            return  (UndoAction_Base) Omni.self.getSimObject(simobjectid,typeof(UndoAction_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// A brief description of the action, for UI representation of this undo/redo action.
/// </summary>
[MemberGroup("")]
public String actionName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".actionName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".actionName", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ), action.addToManager([undoManager]))
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addToManager(string undoManager = ""){

pInvokes.m_ts.fn_UndoAction_addToManager(_ID, undoManager);
}
/// <summary>
/// () - Reo action contained in undo. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void redo(){

pInvokes.m_ts.fn_UndoAction_redo(_ID);
}
/// <summary>
/// () - Undo action contained in undo. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void undo(){

pInvokes.m_ts.fn_UndoAction_undo(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public UndoAction_Base (){}
}}
