


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
    [TypeConverter(typeof(TypeConverterGeneric<InspectorFieldUndoAction_Base>))]
    public partial class InspectorFieldUndoAction_Base: UndoAction
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(InspectorFieldUndoAction_Base ts, string simobjectid)
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
        public static bool operator !=(InspectorFieldUndoAction_Base ts, string simobjectid)
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
        public static implicit operator string( InspectorFieldUndoAction_Base ts)
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
        public static implicit operator InspectorFieldUndoAction_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (InspectorFieldUndoAction_Base) Omni.self.getSimObject(simobjectid,typeof(InspectorFieldUndoAction_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( InspectorFieldUndoAction_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator InspectorFieldUndoAction_Base(int simobjectid)
            {
            return  (InspectorFieldUndoAction) Omni.self.getSimObject((uint)simobjectid,typeof(InspectorFieldUndoAction_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( InspectorFieldUndoAction_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator InspectorFieldUndoAction_Base(uint simobjectid)
            {
            return  (InspectorFieldUndoAction_Base) Omni.self.getSimObject(simobjectid,typeof(InspectorFieldUndoAction_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String arrayIndex
       {
       get
          {
          return Omni.self.GetVar(_ID + ".arrayIndex").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".arrayIndex", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String fieldName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fieldName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fieldName", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public String fieldValue
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fieldValue").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fieldValue", value.AsString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public GuiInspector inspectorGui
       {
       get
          {
          return Omni.self.GetVar(_ID + ".inspectorGui");
          }
       set
          {
          Omni.self.SetVar(_ID + ".inspectorGui", value.ToString());
          }
       }
/// <summary>
/// 
/// </summary>
[MemberGroup("")]
public int objectId
       {
       get
          {
          return Omni.self.GetVar(_ID + ".objectId").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".objectId", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public InspectorFieldUndoAction_Base (){}
}}
