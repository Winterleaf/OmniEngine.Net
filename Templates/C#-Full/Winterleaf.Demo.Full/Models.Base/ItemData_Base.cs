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
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<ItemData_Base>))]
    public partial class ItemData_Base : ShapeBaseData
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ItemData_Base ts, string simobjectid)
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
        public static bool operator !=(ItemData_Base ts, string simobjectid)
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
        public static implicit operator string(ItemData_Base ts)
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
        public static implicit operator ItemData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ItemData_Base) Omni.self.getSimObject(simobjectid, typeof (ItemData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ItemData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ItemData_Base(int simobjectid)
        {
            return (ItemData) Omni.self.getSimObject((uint) simobjectid, typeof (ItemData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ItemData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ItemData_Base(uint simobjectid)
        {
            return (ItemData_Base) Omni.self.getSimObject(simobjectid, typeof (ItemData_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// A floating-point value specifying how 'bouncy' this ItemData is.
        /// </summary>
        [MemberGroup("")]
        public float elasticity
        {
            get { return Omni.self.GetVar(_ID + ".elasticity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".elasticity", value.AsString()); }
        }

        /// <summary>
        /// A floating-point value specifying how much velocity is lost to impact and sliding friction.
        /// </summary>
        [MemberGroup("")]
        public float friction
        {
            get { return Omni.self.GetVar(_ID + ".friction").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".friction", value.AsString()); }
        }

        /// <summary>
        /// Floating point value to multiply the existing gravity with, just for this ItemData.
        /// </summary>
        [MemberGroup("")]
        public float gravityMod
        {
            get { return Omni.self.GetVar(_ID + ".gravityMod").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".gravityMod", value.AsString()); }
        }

        /// <summary>
        /// @brief Color value to make this light. Example: \1.0,1.0,1.0\\n\n   @see lightType\n
        /// </summary>
        [MemberGroup("")]
        public ColorF lightColor
        {
            get { return Omni.self.GetVar(_ID + ".lightColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".lightColor", value.AsString()); }
        }

        /// <summary>
        /// @brief If true, this ItemData will only cast a light if the Item for this ItemData has a static value of true.\n\n   @see lightType\n
        /// </summary>
        [MemberGroup("")]
        public bool lightOnlyStatic
        {
            get { return Omni.self.GetVar(_ID + ".lightOnlyStatic").AsBool(); }
            set { Omni.self.SetVar(_ID + ".lightOnlyStatic", value.AsString()); }
        }

        /// <summary>
        /// @brief Distance from the center point of this ItemData for the light to affect\n\n   @see lightType\n
        /// </summary>
        [MemberGroup("")]
        public float lightRadius
        {
            get { return Omni.self.GetVar(_ID + ".lightRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".lightRadius", value.AsString()); }
        }

        /// <summary>
        /// @brief Time value for the light of this ItemData, used to control the pulse speed of the PulsingLight LightType.\n\n   @see lightType\n
        /// </summary>
        [MemberGroup("")]
        public int lightTime
        {
            get { return Omni.self.GetVar(_ID + ".lightTime").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lightTime", value.AsString()); }
        }

        /// <summary>
        /// Type of light to apply to this ItemData. Options are NoLight, ConstantLight, PulsingLight. Default is NoLight. 
        /// </summary>
        [MemberGroup("")]
        public TypeItemLightType lightType
        {
            get { return (TypeItemLightType) Omni.self.GetVar(_ID + ".lightType"); }
            set { Omni.self.SetVar(_ID + ".lightType", value.ToString()); }
        }

        /// <summary>
        /// Maximum velocity that this ItemData is able to move.
        /// </summary>
        [MemberGroup("")]
        public float maxVelocity
        {
            get { return Omni.self.GetVar(_ID + ".maxVelocity").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxVelocity", value.AsString()); }
        }

        /// <summary>
        /// @brief Determines if only simple server-side collision will be used (for pick ups).\n\n   If set to true then only simple, server-side collision detection will be used. This is often the case    if the item is used for a pick up object, such as ammo. If set to false then a full collision volume    will be used as defined by the shape. The default is true.\n   @note Only applies when using a physics library.\n   @see TurretShape and ProximityMine for examples that should set this to false to allow them to be    shot by projectiles.\n
        /// </summary>
        [MemberGroup("")]
        public bool simpleServerCollision
        {
            get { return Omni.self.GetVar(_ID + ".simpleServerCollision").AsBool(); }
            set { Omni.self.SetVar(_ID + ".simpleServerCollision", value.AsString()); }
        }

        /// <summary>
        /// @brief If true, ItemData will 'stick' to any surface it collides with.\n\n   When an item does stick to a surface, the Item::onStickyCollision() callback is called. The Item has methods to retrieve    the world position and normal the Item is stuck to.\n   @note Valid objects to stick to must be of StaticShapeObjectType.\n
        /// </summary>
        [MemberGroup("")]
        public bool sticky
        {
            get { return Omni.self.GetVar(_ID + ".sticky").AsBool(); }
            set { Omni.self.SetVar(_ID + ".sticky", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public ItemData_Base()
        {
        }
    }
}