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
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ShapeBaseData_Base>))]
    public partial class ShapeBaseData_Base : GameBaseData
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
        public static bool operator !=(ShapeBaseData_Base ts, string simobjectid)
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
        public static implicit operator string(ShapeBaseData_Base ts)
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
        public static implicit operator ShapeBaseData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ShapeBaseData_Base) Omni.self.getSimObject(simobjectid, typeof (ShapeBaseData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ShapeBaseData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ShapeBaseData_Base(int simobjectid)
        {
            return (ShapeBaseData) Omni.self.getSimObject((uint) simobjectid, typeof (ShapeBaseData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ShapeBaseData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ShapeBaseData_Base(uint simobjectid)
        {
            return (ShapeBaseData_Base) Omni.self.getSimObject(simobjectid, typeof (ShapeBaseData_Base));
        }

        #endregion

        #region Init Persists

        #endregion

        #region Member Functions

        /// <summary>
        /// @brief Check if there is the space at the given transform is free to spawn into.   The shape's bounding box volume is used to check for collisions at the given world    transform.  Only interior and static objects are checked for collision.   @param txfm Deploy transform to check   @return True if the space is free, false if there is already something in    the way.   @note This is a server side only check, and is not actually limited to spawning.)
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool checkDeployPos(TransformF txfm)
        {
            return m_ts.fnShapeBaseData_checkDeployPos(_ID, txfm.AsString());
        }

        /// <summary>
        /// @brief Helper method to get a transform from a position and vector (suitable for use with setTransform).   @param pos Desired transform position   @param normal Vector of desired direction   @return The deploy transform )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public TransformF getDeployTransform(Point3F pos, Point3F normal)
        {
            return new TransformF(m_ts.fnShapeBaseData_getDeployTransform(_ID, pos.AsString(), normal.AsString()));
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// @brief Called when the object damage state changes to Enabled.   @param obj The ShapeBase object   @param lastState The previous damage state )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEnabled(ShapeBase obj, string lastState)
        {
        }

        /// <summary>
        /// @brief Called when the object damage state changes to Disabled.   @param obj The ShapeBase object   @param lastState The previous damage state )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDisabled(ShapeBase obj, string lastState)
        {
        }

        /// <summary>
        /// @brief Called when the object damage state changes to Destroyed.   @param obj The ShapeBase object   @param lastState The previous damage state )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDestroyed(ShapeBase obj, string lastState)
        {
        }

        /// <summary>
        /// @brief Called when we collide with another object beyond some impact speed.   The Player class makes use of this callback when a collision speed is more than PlayerData::minImpactSpeed.   @param obj The ShapeBase object   @param collObj The object we collided with   @param vec Collision impact vector   @param len Length of the impact vector )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onImpact(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
        {
        }

        /// <summary>
        /// @brief Called when we collide with another object.   @param obj The ShapeBase object   @param collObj The object we collided with   @param vec Collision impact vector   @param len Length of the impact vector )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len)
        {
        }

        /// <summary>
        /// @brief Called when the object is damaged.   @param obj The ShapeBase object   @param obj The ShapeBase object   @param delta The amount of damage received. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onDamage(ShapeBase obj, float delta)
        {
        }

        /// <summary>
        /// @brief Called when a move trigger input changes state.   @param obj The ShapeBase object   @param index Index of the trigger that changed   @param state New state of the trigger )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTrigger(ShapeBase obj, int index, bool state)
        {
        }

        /// <summary>
        /// @brief Called when a thread playing a non-cyclic sequence reaches the end of the    sequence.   @param obj The ShapeBase object   @param slot Thread slot that finished playing )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onEndSequence(ShapeBase obj, int slot)
        {
        }

        /// <summary>
        /// @brief Called when the object is forced to uncloak.   @param obj The ShapeBase object   @param reason String describing why the object was uncloaked )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onForceUncloak(ShapeBase obj, string reason)
        {
        }

        #endregion

        public ShapeBaseData_Base()
        {
        }
    }
}