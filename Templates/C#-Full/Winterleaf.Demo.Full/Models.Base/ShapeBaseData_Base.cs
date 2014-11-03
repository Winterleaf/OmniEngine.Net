


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
    [TypeConverter(typeof(TypeConverterGeneric<ShapeBaseData_Base>))]
    public partial class ShapeBaseData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ShapeBaseData_Base ts, string simobjectid)
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
        public static bool operator !=(ShapeBaseData_Base ts, string simobjectid)
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
        public static implicit operator string( ShapeBaseData_Base ts)
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
        public static implicit operator ShapeBaseData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ShapeBaseData_Base) Omni.self.getSimObject(simobjectid,typeof(ShapeBaseData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ShapeBaseData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeBaseData_Base(int simobjectid)
            {
            return  (ShapeBaseData) Omni.self.getSimObject((uint)simobjectid,typeof(ShapeBaseData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ShapeBaseData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeBaseData_Base(uint simobjectid)
            {
            return  (ShapeBaseData_Base) Omni.self.getSimObject(simobjectid,typeof(ShapeBaseData_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Check if there is the space at the given transform is free to spawn into.
/// 
///    The shape's bounding box volume is used to check for collisions at the given world 
///    transform.  Only interior and static objects are checked for collision.
/// 
///    @param txfm Deploy transform to check
///    @return True if the space is free, false if there is already something in 
///    the way.
/// 
///    @note This is a server side only check, and is not actually limited to spawning.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool checkDeployPos(TransformF txfm){

return pInvokes.m_ts.fnShapeBaseData_checkDeployPos(_ID, txfm.AsString());
}
/// <summary>
/// @brief Helper method to get a transform from a position and vector (suitable for use with setTransform).
///    @param pos Desired transform position
///    @param normal Vector of desired direction
///    @return The deploy transform )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TransformF getDeployTransform(Point3F pos, Point3F normal){

return new TransformF ( pInvokes.m_ts.fnShapeBaseData_getDeployTransform(_ID, pos.AsString(), normal.AsString()));
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when the object damage state changes to Enabled.   @param obj The ShapeBase object   @param lastState The previous damage state )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnabled(ShapeBase obj, string lastState){}

        /// <summary>
        /// @brief Called when the object damage state changes to Disabled.   @param obj The ShapeBase object   @param lastState The previous damage state )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDisabled(ShapeBase obj, string lastState){}

        /// <summary>
        /// @brief Called when the object damage state changes to Destroyed.   @param obj The ShapeBase object   @param lastState The previous damage state )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDestroyed(ShapeBase obj, string lastState){}

        /// <summary>
        /// @brief Called when we collide with another object beyond some impact speed.   The Player class makes use of this callback when a collision speed is more than PlayerData::minImpactSpeed.   @param obj The ShapeBase object   @param collObj The object we collided with   @param vec Collision impact vector   @param len Length of the impact vector )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onImpact(ShapeBase obj, SceneObject collObj, Point3F vec, float len){}

        /// <summary>
        /// @brief Called when we collide with another object.   @param obj The ShapeBase object   @param collObj The object we collided with   @param vec Collision impact vector   @param len Length of the impact vector )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len){}

        /// <summary>
        /// @brief Called when the object is damaged.   @param obj The ShapeBase object   @param obj The ShapeBase object   @param delta The amount of damage received. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onDamage(ShapeBase obj, float delta){}

        /// <summary>
        /// @brief Called when a move trigger input changes state.   @param obj The ShapeBase object   @param index Index of the trigger that changed   @param state New state of the trigger )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onTrigger(ShapeBase obj, int index, bool state){}

        /// <summary>
        /// @brief Called when a thread playing a non-cyclic sequence reaches the end of the    sequence.   @param obj The ShapeBase object   @param slot Thread slot that finished playing   @param name Thread name that finished playing)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEndSequence(ShapeBase obj, int slot, string name){}

        /// <summary>
        /// @brief Called when the object is forced to uncloak.   @param obj The ShapeBase object   @param reason String describing why the object was uncloaked )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onForceUncloak(ShapeBase obj, string reason){}

#endregion
public ShapeBaseData_Base (){}
}}
