// WinterLeaf Entertainment
// Copyright (c) 2014, WinterLeaf Entertainment LLC
// 
// All rights reserved.
// 
// The use of the WinterLeaf Entertainment LLC OMNI "Community Edition" is governed by this license agreement ("Agreement").
// 
// These license terms are an agreement between WinterLeaf Entertainment LLC and you.  Please read them. They apply to the source code and any other assets or works that are included with the product named above, which includes the media on which you received it, if any. These terms also apply to any updates, supplements, internet-based services, and support services for this software and its associated assets, unless other terms accompany those items. If so, those terms apply. You must read and agree to this Agreement terms BEFORE installing OMNI "Community Edition" to your hard drive or using OMNI in any way. If you do not agree to the license terms, do not download, install or use OMNI. Please make copies of this Agreement for all those in your organization who need to be familiar with the license terms.
// 
// This license allows companies of any size, government entities or individuals to create, sell, rent, lease, or otherwise profit commercially from, games using executables created from the source code that accompanies OMNI "Community Edition".
// 
// BY CLICKING THE ACCEPTANCE BUTTON AND/OR INSTALLING OR USING OMNI "Community Edition", THE INDIVIDUAL ACCESSING OMNI ("LICENSEE") IS CONSENTING TO BE BOUND BY AND BECOME A PARTY TO THIS AGREEMENT. IF YOU DO NOT ACCEPT THESE TERMS, DO NOT INSTALL OR USE OMNI. IF YOU COMPLY WITH THESE LICENSE TERMS, YOU HAVE THE RIGHTS BELOW:
// 
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     Redistributions of source code must retain the all copyright notice, this list of conditions and the following disclaimer.
//     Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//     With respect to any Product that the Licensee develop using the Software:
//     Licensee shall:
//         display the OMNI Logo, in the start-up sequence of the Product (unless waived by WinterLeaf Entertainment);
//         display in the "About" box or in the credits screen of the Product the text "OMNI by WinterLeaf Entertainment";
//         display the OMNI Logo, on all external Product packaging materials and the back cover of any printed instruction manual or the end of any electronic instruction manual;
//         notify WinterLeaf Entertainment in writing that You are publicly releasing a Product that was developed using the Software within the first 30 days following the release; and
//         the Licensee hereby grant WinterLeaf Entertainment permission to refer to the Licensee or the name of any Product the Licensee develops using the Software for marketing purposes. All goodwill in each party's trademarks and logos will inure to the sole benefit of that party.
//     Neither the name of WinterLeaf Entertainment LLC or OMNI nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//     The following restrictions apply to the use of OMNI "Community Edition":
//     Licensee may not:
//         create any derivative works of OMNI Engine, including but not limited to translations, localizations, or game making software other than Games;
//         redistribute, encumber, sell, rent, lease, sublicense, or otherwise transfer rights to OMNI "Community Edition"; or
//         remove or alter any trademark, logo, copyright or other proprietary notices, legends, symbols or labels in OMNI Engine; or
//         use the Software to develop or distribute any software that competes with the Software without WinterLeaf Entertainment’s prior written consent; or
//         use the Software for any illegal purpose.
// 
// THIS SOFTWARE IS PROVIDED BY WINTERLEAF ENTERTAINMENT LLC ''AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL WINTERLEAF ENTERTAINMENT LLC BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 

#region

using System.ComponentModel;
using WinterLeaf.Demo.Full.Models.User.Extendable;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Classes.Interopt;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<AITurretShape_Base>))]
    public partial class AITurretShape_Base : TurretShape
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
            return ReferenceEquals(ts, null) ? ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            return (this._ID == (string) myReflections.ChangeType(obj, typeof (string)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(AITurretShape_Base ts, string simobjectid)
        {
            if (ReferenceEquals(ts, null))
                return !ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(AITurretShape_Base ts)
        {
            if (ReferenceEquals(ts, null))
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
            return (AITurretShape_Base) Omni.self.getSimObject(simobjectid, typeof (AITurretShape_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(AITurretShape_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator AITurretShape_Base(int simobjectid)
        {
            return (AITurretShape) Omni.self.getSimObject((uint) simobjectid, typeof (AITurretShape_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(AITurretShape_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator AITurretShape_Base(uint simobjectid)
        {
            return (AITurretShape_Base) Omni.self.getSimObject(simobjectid, typeof (AITurretShape_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Activate a turret from a deactive state.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void activateTurret()
        {
            m_ts.fnAITurretShape_activateTurret(_ID);
        }

        /// <summary>
        /// @brief Adds object to the turret's ignore list.   All objects in this list will be ignored by the turret's targeting.   @param obj The ShapeBase object to ignore.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addToIgnoreList(string obj)
        {
            m_ts.fnAITurretShape_addToIgnoreList(_ID, obj);
        }

        /// <summary>
        /// @brief Deactivate a turret from an active state.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void deactivateTurret()
        {
            m_ts.fnAITurretShape_deactivateTurret(_ID);
        }

        /// <summary>
        /// @brief Get the turret's current target.   @returns The object that is the target's current target, or 0 if no target.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getTarget()
        {
            return m_ts.fnAITurretShape_getTarget(_ID);
        }

        /// <summary>
        /// @brief Get the turret's defined projectile velocity that helps with target leading.   @returns The defined weapon projectile speed, or 0 if leading is disabled.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getWeaponLeadVelocity()
        {
            return m_ts.fnAITurretShape_getWeaponLeadVelocity(_ID);
        }

        /// <summary>
        /// @brief Indicates if the turret has a target.   @returns True if the turret has a target.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool hasTarget()
        {
            return m_ts.fnAITurretShape_hasTarget(_ID);
        }

        /// <summary>
        /// @brief Recenter the turret's weapon.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void recenterTurret()
        {
            m_ts.fnAITurretShape_recenterTurret(_ID);
        }

        /// <summary>
        /// @brief Removes object from the turret's ignore list.   All objects in this list will be ignored by the turret's targeting.   @param obj The ShapeBase object to once again allow for targeting.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeFromIgnoreList(string obj)
        {
            m_ts.fnAITurretShape_removeFromIgnoreList(_ID, obj);
        }

        /// <summary>
        /// @brief Resets the turret's target tracking.   Only resets the internal target tracking.  Does not modify the turret's facing.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void resetTarget()
        {
            m_ts.fnAITurretShape_resetTarget(_ID);
        }

        /// <summary>
        /// @brief Set the firing state of the turret's guns.   @param fire Set to true to activate all guns.  False to deactivate them.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setAllGunsFiring(bool fire)
        {
            m_ts.fnAITurretShape_setAllGunsFiring(_ID, fire);
        }

        /// <summary>
        /// @brief Set the firing state of the given gun slot.   @param slot The gun to modify.  Valid range is 0-3 that corresponds to the weapon mount point.   @param fire Set to true to activate the gun.  False to deactivate it.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setGunSlotFiring(int slot, bool fire)
        {
            m_ts.fnAITurretShape_setGunSlotFiring(_ID, slot, fire);
        }

        /// <summary>
        /// @brief Set the turret's current state.   Normally the turret's state comes from updating the state machine but this method    allows you to override this and jump to the requested state immediately.   @param newState The name of the new state.   @param force Is true then force the full processing of the new state even if it is the    same as the current state.  If false then only the time out value is reset and the state's    script method is called, if any.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTurretState(string newState, bool force = false)
        {
            m_ts.fnAITurretShape_setTurretState(_ID, newState, force);
        }

        /// <summary>
        /// @brief Set the turret's projectile velocity to help lead the target.   This value normally comes from AITurretShapeData::weaponLeadVelocity but this method    allows you to override the datablock value.  This can be useful if the turret changes    ammunition, uses a different weapon than the default, is damaged, etc.   @note Setting this to 0 will disable target leading.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setWeaponLeadVelocity(float velocity)
        {
            m_ts.fnAITurretShape_setWeaponLeadVelocity(_ID, velocity);
        }

        /// <summary>
        /// @brief Begin scanning for a target.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void startScanForTargets()
        {
            m_ts.fnAITurretShape_startScanForTargets(_ID);
        }

        /// <summary>
        /// @brief Have the turret track the current target.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void startTrackingTarget()
        {
            m_ts.fnAITurretShape_startTrackingTarget(_ID);
        }

        /// <summary>
        /// @brief Stop scanning for targets.   @note Only impacts the scanning for new targets.  Does not effect a turret's current    target lock.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void stopScanForTargets()
        {
            m_ts.fnAITurretShape_stopScanForTargets(_ID);
        }

        /// <summary>
        /// @brief Stop the turret from tracking the current target.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void stopTrackingTarget()
        {
            m_ts.fnAITurretShape_stopTrackingTarget(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public AITurretShape_Base()
        {
        }
    }
}