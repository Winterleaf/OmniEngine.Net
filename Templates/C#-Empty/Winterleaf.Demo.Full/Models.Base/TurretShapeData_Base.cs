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
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<TurretShapeData_Base>))]
    public partial class TurretShapeData_Base : ItemData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TurretShapeData_Base ts, string simobjectid)
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
        public static bool operator !=(TurretShapeData_Base ts, string simobjectid)
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
        public static implicit operator string(TurretShapeData_Base ts)
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
        public static implicit operator TurretShapeData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (TurretShapeData_Base) Omni.self.getSimObject(simobjectid, typeof (TurretShapeData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(TurretShapeData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TurretShapeData_Base(int simobjectid)
        {
            return (TurretShapeData) Omni.self.getSimObject((uint) simobjectid, typeof (TurretShapeData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(TurretShapeData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TurretShapeData_Base(uint simobjectid)
        {
            return (TurretShapeData_Base) Omni.self.getSimObject(simobjectid, typeof (TurretShapeData_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Vertical (Z axis) height of the camera above the turret. 
        /// </summary>
        [MemberGroup("")]
        public float cameraOffset
        {
            get { return Omni.self.GetVar(_ID + ".cameraOffset").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".cameraOffset", value.AsString()); }
        }

        /// <summary>
        /// @brief Degrees per second rotation.\n\n   A value of 0 means no rotation is allowed. A value less than 0 means the rotation is instantaneous.\n
        /// </summary>
        [MemberGroup("")]
        public float headingRate
        {
            get { return Omni.self.GetVar(_ID + ".headingRate").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".headingRate", value.AsString()); }
        }

        /// <summary>
        /// @brief Maximum number of degrees to rotate from center.\n\n   A value of 180 or more degrees indicates the turret may rotate completely around.\n
        /// </summary>
        [MemberGroup("")]
        public float maxHeading
        {
            get { return Omni.self.GetVar(_ID + ".maxHeading").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxHeading", value.AsString()); }
        }

        /// <summary>
        /// @brief Maximum number of degrees to rotate up from straight ahead.\n\n
        /// </summary>
        [MemberGroup("")]
        public float maxPitch
        {
            get { return Omni.self.GetVar(_ID + ".maxPitch").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxPitch", value.AsString()); }
        }

        /// <summary>
        /// @brief Minimum number of degrees to rotate down from straight ahead.\n\n
        /// </summary>
        [MemberGroup("")]
        public float minPitch
        {
            get { return Omni.self.GetVar(_ID + ".minPitch").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".minPitch", value.AsString()); }
        }

        /// <summary>
        /// @brief Degrees per second rotation.\n\n   A value of 0 means no rotation is allowed. A value less than 0 means the rotation is instantaneous.\n
        /// </summary>
        [MemberGroup("")]
        public float pitchRate
        {
            get { return Omni.self.GetVar(_ID + ".pitchRate").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".pitchRate", value.AsString()); }
        }

        /// <summary>
        /// @brief Does the turret's mounted weapon(s) start in a loaded state.\n\n   True indicates that all mounted weapons start in a loaded state.\n   @see ShapeBase::setImageLoaded()
        /// </summary>
        [MemberGroup("")]
        public bool startLoaded
        {
            get { return Omni.self.GetVar(_ID + ".startLoaded").AsBool(); }
            set { Omni.self.SetVar(_ID + ".startLoaded", value.AsString()); }
        }

        /// <summary>
        /// @brief Set how the mounted weapons are linked and triggered.\n\n   ulliFireTogether: All weapons fire under trigger 0./li   liGroupedFire: Weapon mounts 0,2 fire under trigger 0, mounts 1,3 fire under trigger 1./li   liIndividualFire: Each weapon mount fires under its own trigger 0-3./li/ul\n   @see TurretShapeFireLinkType
        /// </summary>
        [MemberGroup("")]
        public TypeTurretShapeFireLinkType weaponLinkType
        {
            get { return (TypeTurretShapeFireLinkType) Omni.self.GetVar(_ID + ".weaponLinkType"); }
            set { Omni.self.SetVar(_ID + ".weaponLinkType", value.ToString()); }
        }

        /// <summary>
        /// @brief Should the turret allow only z rotations.\n\n   True indicates that the turret may only be rotated on its z axis, just like the Item class.    This keeps the turret always upright regardless of the surface it lands on.\n
        /// </summary>
        [MemberGroup("")]
        public bool zRotOnly
        {
            get { return Omni.self.GetVar(_ID + ".zRotOnly").AsBool(); }
            set { Omni.self.SetVar(_ID + ".zRotOnly", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Informs the TurretShapeData object that a player is mounting it.   @param turret The TurretShape object.   @param obj The player that is mounting.   @param node The node the player is mounting to.   @note Server side only.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMountObject(TurretShape turret, SceneObject obj, int node)
        {
        }

        /// <summary>
        /// @brief Informs the TurretShapeData object that a player is unmounting it.   @param turret The TurretShape object.   @param obj The player that is unmounting.   @note Server side only.)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onUnmountObject(TurretShape turret, SceneObject obj)
        {
        }

        /// <summary>
        /// @brief Informs the TurretData object that it is now sticking to another object.   This callback is only called if the TurretData::sticky property for this Turret is true.   @param obj The Turret object that is colliding.   @note Server side only.   @see TurretShape, TurretData)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onStickyCollision(TurretShape obj)
        {
        }

        #endregion

        public TurretShapeData_Base()
        {
        }
    }
}