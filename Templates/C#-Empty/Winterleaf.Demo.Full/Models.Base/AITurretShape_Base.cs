


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
    [TypeConverter(typeof(TypeConverterGeneric<AITurretShape_Base>))]
    public partial class AITurretShape_Base: TurretShape
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(AITurretShape_Base ts, string simobjectid)
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
        public static bool operator !=(AITurretShape_Base ts, string simobjectid)
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
        public static implicit operator string( AITurretShape_Base ts)
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
        public static implicit operator AITurretShape_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (AITurretShape_Base) Omni.self.getSimObject(simobjectid,typeof(AITurretShape_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( AITurretShape_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AITurretShape_Base(int simobjectid)
            {
            return  (AITurretShape) Omni.self.getSimObject((uint)simobjectid,typeof(AITurretShape_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( AITurretShape_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AITurretShape_Base(uint simobjectid)
            {
            return  (AITurretShape_Base) Omni.self.getSimObject(simobjectid,typeof(AITurretShape_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Activate a turret from a deactive state.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void activateTurret(){

pInvokes.m_ts.fnAITurretShape_activateTurret(_ID);
}
/// <summary>
/// @brief Adds object to the turret's ignore list.
///    All objects in this list will be ignored by the turret's targeting.
///    @param obj The ShapeBase object to ignore.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addToIgnoreList(string obj){

pInvokes.m_ts.fnAITurretShape_addToIgnoreList(_ID, obj);
}
/// <summary>
/// @brief Deactivate a turret from an active state.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deactivateTurret(){

pInvokes.m_ts.fnAITurretShape_deactivateTurret(_ID);
}
/// <summary>
/// @brief Get the turret's current target.
///    @returns The object that is the target's current target, or 0 if no target.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getTarget(){

return pInvokes.m_ts.fnAITurretShape_getTarget(_ID);
}
/// <summary>
/// @brief Get the turret's defined projectile velocity that helps with target leading.
///    @returns The defined weapon projectile speed, or 0 if leading is disabled.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getWeaponLeadVelocity(){

return pInvokes.m_ts.fnAITurretShape_getWeaponLeadVelocity(_ID);
}
/// <summary>
/// @brief Indicates if the turret has a target.
///    @returns True if the turret has a target.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool hasTarget(){

return pInvokes.m_ts.fnAITurretShape_hasTarget(_ID);
}
/// <summary>
/// @brief Recenter the turret's weapon.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void recenterTurret(){

pInvokes.m_ts.fnAITurretShape_recenterTurret(_ID);
}
/// <summary>
/// @brief Removes object from the turret's ignore list.
///    All objects in this list will be ignored by the turret's targeting.
///    @param obj The ShapeBase object to once again allow for targeting.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeFromIgnoreList(string obj){

pInvokes.m_ts.fnAITurretShape_removeFromIgnoreList(_ID, obj);
}
/// <summary>
/// @brief Resets the turret's target tracking.
///    Only resets the internal target tracking.  Does not modify the turret's facing.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void resetTarget(){

pInvokes.m_ts.fnAITurretShape_resetTarget(_ID);
}
/// <summary>
/// @brief Set the firing state of the turret's guns.
///    @param fire Set to true to activate all guns.  False to deactivate them.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAllGunsFiring(bool fire){

pInvokes.m_ts.fnAITurretShape_setAllGunsFiring(_ID, fire);
}
/// <summary>
/// @brief Set the firing state of the given gun slot.
///    @param slot The gun to modify.  Valid range is 0-3 that corresponds to the weapon mount point.
///    @param fire Set to true to activate the gun.  False to deactivate it.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setGunSlotFiring(int slot, bool fire){

pInvokes.m_ts.fnAITurretShape_setGunSlotFiring(_ID, slot, fire);
}
/// <summary>
/// @brief Set the turret's current state.
///    Normally the turret's state comes from updating the state machine but this method 
///    allows you to override this and jump to the requested state immediately.
///    @param newState The name of the new state.
///    @param force Is true then force the full processing of the new state even if it is the 
///    same as the current state.  If false then only the time out value is reset and the state's 
///    script method is called, if any.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTurretState(string newState, bool force = false){

pInvokes.m_ts.fnAITurretShape_setTurretState(_ID, newState, force);
}
/// <summary>
/// @brief Set the turret's projectile velocity to help lead the target.
///    This value normally comes from AITurretShapeData::weaponLeadVelocity but this method 
///    allows you to override the datablock value.  This can be useful if the turret changes 
///    ammunition, uses a different weapon than the default, is damaged, etc.
///    @note Setting this to 0 will disable target leading.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setWeaponLeadVelocity(float velocity){

pInvokes.m_ts.fnAITurretShape_setWeaponLeadVelocity(_ID, velocity);
}
/// <summary>
/// @brief Begin scanning for a target.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void startScanForTargets(){

pInvokes.m_ts.fnAITurretShape_startScanForTargets(_ID);
}
/// <summary>
/// @brief Have the turret track the current target.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void startTrackingTarget(){

pInvokes.m_ts.fnAITurretShape_startTrackingTarget(_ID);
}
/// <summary>
/// @brief Stop scanning for targets.
///    @note Only impacts the scanning for new targets.  Does not effect a turret's current 
///    target lock.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stopScanForTargets(){

pInvokes.m_ts.fnAITurretShape_stopScanForTargets(_ID);
}
/// <summary>
/// @brief Stop the turret from tracking the current target.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stopTrackingTarget(){

pInvokes.m_ts.fnAITurretShape_stopTrackingTarget(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public AITurretShape_Base (){}
}}
