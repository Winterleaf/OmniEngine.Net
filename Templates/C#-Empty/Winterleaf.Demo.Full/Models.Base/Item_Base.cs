


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
    [TypeConverter(typeof(TypeConverterGeneric<Item_Base>))]
    public partial class Item_Base: ShapeBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Item_Base ts, string simobjectid)
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
        public static bool operator !=(Item_Base ts, string simobjectid)
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
        public static implicit operator string( Item_Base ts)
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
        public static implicit operator Item_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Item_Base) Omni.self.getSimObject(simobjectid,typeof(Item_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Item_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Item_Base(int simobjectid)
            {
            return  (Item) Omni.self.getSimObject((uint)simobjectid,typeof(Item_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Item_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Item_Base(uint simobjectid)
            {
            return  (Item_Base) Omni.self.getSimObject(simobjectid,typeof(Item_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If true, the object will automatically rotate around its Z axis.\n
/// </summary>
[MemberGroup("Misc")]
public bool rotate
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rotate").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rotate", value.AsString());
          }
       }
/// <summary>
/// If true, the object is not moving in the world.\n
/// </summary>
[MemberGroup("Misc")]
public bool staticx
       {
       get
          {
          return Omni.self.GetVar(_ID + ".static").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".static", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Get the normal of the surface on which the object is stuck.   
///    @return Returns The XYZ normal from where this Item is stuck.
///    @tsexample
/// 	   // Acquire the position where this Item is currently stuck
/// 	   %stuckPosition = %item.getLastStickPos();
///    @endtsexample
///    @note Server side only.
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLastStickyNormal(){

return pInvokes.m_ts.fnItem_getLastStickyNormal(_ID);
}
/// <summary>
/// @brief Get the position on the surface on which this Item is stuck.   
///    @return Returns The XYZ position of where this Item is stuck.
///    @tsexample
/// 	   // Acquire the position where this Item is currently stuck
/// 	   %stuckPosition = %item.getLastStickPos();
///    @endtsexample
///    @note Server side only.
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getLastStickyPos(){

return pInvokes.m_ts.fnItem_getLastStickyPos(_ID);
}
/// <summary>
/// @brief Is the object at rest (ie, no longer moving)?   
///    @return True if the object is at rest, false if it is not.
///    @tsexample
/// 	   // Query the item on if it is or is not at rest.
/// 	   %isAtRest = %item.isAtRest();
///    @endtsexample
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isAtRest(){

return pInvokes.m_ts.fnItem_isAtRest(_ID);
}
/// <summary>
/// @brief Is the object still rotating?   
///    @return True if the object is still rotating, false if it is not.
///    @tsexample
/// 	   // Query the item on if it is or is not rotating.
/// 	   %isRotating = %itemData.isRotating();
///    @endtsexample
///    @see rotate
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isRotating(){

return pInvokes.m_ts.fnItem_isRotating(_ID);
}
/// <summary>
/// @brief Is the object static (ie, non-movable)?   
///    @return True if the object is static, false if it is not.
///    @tsexample
/// 	   // Query the item on if it is or is not static.
/// 	   %isStatic = %itemData.isStatic();
///    @endtsexample
///    @see static
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isStatic(){

return pInvokes.m_ts.fnItem_isStatic(_ID);
}
/// <summary>
/// @brief Temporarily disable collisions against a specific ShapeBase object.
/// 
///    This is useful to prevent a player from immediately picking up an Item they have 
///    just thrown.  Only one object may be on the timeout list at a time.  The timeout is 
///    defined as 15 ticks.
/// 
///    @param objectID ShapeBase object ID to disable collisions against.
///    @return Returns true if the ShapeBase object requested could be found, false if it could not.
/// 
///    @tsexample
/// 	   // Set the ShapeBase Object ID to disable collisions against
/// 	   %ignoreColObj = %player.getID();
/// 	   // Inform this Item object to ignore collisions temproarily against the %ignoreColObj.
/// 	   %item.setCollisionTimeout(%ignoreColObj);
///    @endtsexample
///    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setCollisionTimeout(int ignoreColObj){

return pInvokes.m_ts.fnItem_setCollisionTimeout(_ID, ignoreColObj);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Informs the Item object that it is now sticking to another object.   This callback is only called if the ItemData::sticky property for this Item is true.   @param objID Object ID this Item object.   @note Server side only.   @see Item, ItemData)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStickyCollision(string objID){}

        /// <summary>
        /// Informs an Item object that it has entered liquid, along with information about the liquid type.   @param objID Object ID for this Item object.   @param waterCoverage How much coverage of water this Item object has.   @param liquidType The type of liquid that this Item object has entered.   @note Server side only.   @see Item, ItemData, WaterObject)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterLiquid(string objID, string waterCoverage, string liquidType){}

        /// <summary>
        /// Informs an Item object that it has left a liquid, along with information about the liquid type.   @param objID Object ID for this Item object.   @param liquidType The type of liquid that this Item object has left.   @note Server side only.   @see Item, ItemData, WaterObject)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveLiquid(string objID, string liquidType){}

#endregion
public Item_Base (){}
}}
