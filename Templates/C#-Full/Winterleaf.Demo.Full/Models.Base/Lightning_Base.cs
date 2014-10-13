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
using WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Containers;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<Lightning_Base>))]
    public partial class Lightning_Base : GameBase
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Lightning_Base ts, string simobjectid)
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
        public static bool operator !=(Lightning_Base ts, string simobjectid)
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
        public static implicit operator string(Lightning_Base ts)
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
        public static implicit operator Lightning_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (Lightning_Base) Omni.self.getSimObject(simobjectid, typeof (Lightning_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(Lightning_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Lightning_Base(int simobjectid)
        {
            return (Lightning) Omni.self.getSimObject((uint) simobjectid, typeof (Lightning_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(Lightning_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Lightning_Base(uint simobjectid)
        {
            return (Lightning_Base) Omni.self.getSimObject(simobjectid, typeof (Lightning_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// @brief Radial distance from the center of the Lightning object for the    start point of the bolt.\n\n   The actual start point will be a random point within this radius. 
        /// </summary>
        [MemberGroup("Bolts")]
        public float boltStartRadius
        {
            get { return Omni.self.GetVar(_ID + ".boltStartRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".boltStartRadius", value.AsString()); }
        }

        /// <summary>
        /// Percentage chance (0-1) that a given lightning bolt will hit something. 
        /// </summary>
        [MemberGroup("Bolts")]
        public float chanceToHitTarget
        {
            get { return Omni.self.GetVar(_ID + ".chanceToHitTarget").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".chanceToHitTarget", value.AsString()); }
        }

        /// <summary>
        /// Color to blend the strike texture with. 
        /// </summary>
        [MemberGroup("Colors")]
        public ColorF color
        {
            get { return Omni.self.GetVar(_ID + ".color").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".color", value.AsString()); }
        }

        /// <summary>
        /// @brief Color to blend the strike texture with when the bolt is fading away.\n\n   Bolts fade away automatically shortly after the strike occurs. 
        /// </summary>
        [MemberGroup("Colors")]
        public ColorF fadeColor
        {
            get { return Omni.self.GetVar(_ID + ".fadeColor").AsColorF(); }
            set { Omni.self.SetVar(_ID + ".fadeColor", value.AsString()); }
        }

        /// <summary>
        /// @brief Horizontal size (XY plane) of the search box used to find and    damage Player or Vehicle objects within range of the strike.\n\n   Only the object at highest altitude with a clear line of sight to the    bolt will be hit. 
        /// </summary>
        [MemberGroup("Strikes")]
        public float strikeRadius
        {
            get { return Omni.self.GetVar(_ID + ".strikeRadius").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".strikeRadius", value.AsString()); }
        }

        /// <summary>
        /// @brief Number of lightning strikes to perform per minute.\n\n   Automatically invokes strikeRandomPoint() at regular intervals. 
        /// </summary>
        [MemberGroup("Strikes")]
        public int strikesPerMinute
        {
            get { return Omni.self.GetVar(_ID + ".strikesPerMinute").AsInt(); }
            set { Omni.self.SetVar(_ID + ".strikesPerMinute", value.AsString()); }
        }

        /// <summary>
        /// Width of a lightning bolt. 
        /// </summary>
        [MemberGroup("Strikes")]
        public float strikeWidth
        {
            get { return Omni.self.GetVar(_ID + ".strikeWidth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".strikeWidth", value.AsString()); }
        }

        /// <summary>
        /// Controls whether lightning bolts are affected by fog when they are rendered. 
        /// </summary>
        [MemberGroup("Bolts")]
        public bool useFog
        {
            get { return Omni.self.GetVar(_ID + ".useFog").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useFog", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Creates a LightningStrikeEvent which strikes a specific object.   @note This method is currently unimplemented. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void strikeObject(string pSB)
        {
            m_ts.fnLightning_strikeObject(_ID, pSB);
        }

        /// <summary>
        /// Creates a LightningStrikeEvent which attempts to strike and damage a random    object in range of the Lightning object.   @tsexample   // Generate a damaging lightning strike effect on all clients   %lightning.strikeRandomPoint();   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void strikeRandomPoint()
        {
            m_ts.fnLightning_strikeRandomPoint(_ID);
        }

        /// <summary>
        /// @brief Creates a LightningStrikeEvent that triggers harmless lightning    bolts on all clients.   No objects will be damaged by these bolts.   @tsexample   // Generate a harmless lightning strike effect on all clients   %lightning.warningFlashes();   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void warningFlashes()
        {
            m_ts.fnLightning_warningFlashes(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Informs an object that it was hit by a lightning bolt and needs to take damage.   @param hitPosition World position hit by the lightning bolt.   @param hitNormal Surface normal at @a hitPosition.   @param hitObject Player or Vehicle object that was hit.   @tsexample   function Lightning::applyDamage( %this, %hitPosition, %hitNormal, %hitObject )   {      // apply damage to the player      %hitObject.applyDamage( 25 )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void applyDamage(string hitPosition, string hitNormal, SceneObject hitObject)
        {
        }

        #endregion

        public Lightning_Base()
        {
        }
    }
}