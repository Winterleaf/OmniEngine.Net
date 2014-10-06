


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
    [TypeConverter(typeof(TypeConverterGeneric<GameBaseData_Base>))]
    public partial class GameBaseData_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GameBaseData_Base ts, string simobjectid)
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
        public static bool operator !=(GameBaseData_Base ts, string simobjectid)
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
        public static implicit operator string( GameBaseData_Base ts)
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
        public static implicit operator GameBaseData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GameBaseData_Base) Omni.self.getSimObject(simobjectid,typeof(GameBaseData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GameBaseData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GameBaseData_Base(int simobjectid)
            {
            return  (GameBaseData) Omni.self.getSimObject((uint)simobjectid,typeof(GameBaseData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GameBaseData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GameBaseData_Base(uint simobjectid)
            {
            return  (GameBaseData_Base) Omni.self.getSimObject(simobjectid,typeof(GameBaseData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The group that this datablock will show up in under the \Scripted\      tab in the World Editor Library. 
/// </summary>
[MemberGroup("Scripting")]
public String category
       {
       get
          {
          return Omni.self.GetVar(_ID + ".category").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".category", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when the object is added to the scene.   @param obj the GameBase object   @tsexample      datablock GameBaseData(MyObjectData)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(GameBase obj){}

        /// <summary>
        /// @brief Called when the object has a new datablock assigned.   @param obj the GameBase object   @see onAdd for an example )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onNewDataBlock(GameBase obj){}

        /// <summary>
        /// @brief Called when the object is removed from the scene.   @param obj the GameBase object   @see onAdd for an example )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onRemove(GameBase obj){}

        /// <summary>
        /// @brief Called when the object is mounted to another object in the scene.   @param obj the GameBase object being mounted   @param mountObj the object we are mounted to   @param node the mountObj node we are mounted to   @see onAdd for an example )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMount(GameBase obj, SceneObject mountObj, int node){}

        /// <summary>
        /// @brief Called when the object is unmounted from another object in the scene.   @param obj the GameBase object being unmounted   @param mountObj the object we are unmounted from   @param node the mountObj node we are unmounted from   @see onAdd for an example )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onUnmount(GameBase obj, SceneObject mountObj, int node){}

#endregion
public GameBaseData_Base (){}
}}
