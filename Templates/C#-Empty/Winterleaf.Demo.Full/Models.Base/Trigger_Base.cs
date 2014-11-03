


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
    [TypeConverter(typeof(TypeConverterGeneric<Trigger_Base>))]
    public partial class Trigger_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Trigger_Base ts, string simobjectid)
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
        public static bool operator !=(Trigger_Base ts, string simobjectid)
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
        public static implicit operator string( Trigger_Base ts)
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
        public static implicit operator Trigger_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Trigger_Base) Omni.self.getSimObject(simobjectid,typeof(Trigger_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Trigger_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Trigger_Base(int simobjectid)
            {
            return  (Trigger) Omni.self.getSimObject((uint)simobjectid,typeof(Trigger_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Trigger_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Trigger_Base(uint simobjectid)
            {
            return  (Trigger_Base) Omni.self.getSimObject(simobjectid,typeof(Trigger_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The command to execute when an object enters this trigger. Object id stored in %%obj. Maximum 1023 characters. 
/// </summary>
[MemberGroup("")]
public String enterCommand
       {
       get
          {
          return Omni.self.GetVar(_ID + ".enterCommand").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".enterCommand", value.AsString());
          }
       }
/// <summary>
/// The command to execute when an object leaves this trigger. Object id stored in %%obj. Maximum 1023 characters. 
/// </summary>
[MemberGroup("")]
public String leaveCommand
       {
       get
          {
          return Omni.self.GetVar(_ID + ".leaveCommand").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".leaveCommand", value.AsString());
          }
       }
/// <summary>
/// @brief Defines a non-rectangular area for the trigger.\n\n   Rather than the standard rectangular bounds, this optional parameter defines a quadrilateral    trigger area. The quadrilateral is defined as a corner point followed by three vectors    representing the edges extending from the corner.\n
/// </summary>
[MemberGroup("")]
public Polyhedron polyhedron
       {
       get
          {
          return Omni.self.GetVar(_ID + ".polyhedron").AsPolyhedron();
          }
       set
          {
          Omni.self.SetVar(_ID + ".polyhedron", value.AsString());
          }
       }
/// <summary>
/// The command to execute while an object is inside this trigger. Maximum 1023 characters. 
/// </summary>
[MemberGroup("")]
public String tickCommand
       {
       get
          {
          return Omni.self.GetVar(_ID + ".tickCommand").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".tickCommand", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Get the number of objects that are within the Trigger's bounds.
///    @see getObject())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getNumObjects(){

return pInvokes.m_ts.fnTrigger_getNumObjects(_ID);
}
/// <summary>
/// @brief Retrieve the requested object that is within the Trigger's bounds.
///    @param index Index of the object to get (range is 0 to getNumObjects()-1)
///    @returns The SimObjectID of the object, or -1 if the requested index is invalid.
///    @see getNumObjects())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getObject(int index){

return pInvokes.m_ts.fnTrigger_getObject(_ID, index);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when the Trigger is being created.   @param objectId the object id of the Trigger being created )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(uint objectId){}

        /// <summary>
        /// @brief Called just before the Trigger is deleted.   @param objectId the object id of the Trigger being deleted )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemove(uint objectId){}

#endregion
public Trigger_Base (){}
}}
