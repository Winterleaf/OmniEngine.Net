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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiAutoScrollCtrl_Base>))]
    public partial class GuiAutoScrollCtrl_Base : GuiTickCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiAutoScrollCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiAutoScrollCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiAutoScrollCtrl_Base ts)
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
        public static implicit operator GuiAutoScrollCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiAutoScrollCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiAutoScrollCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiAutoScrollCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiAutoScrollCtrl_Base(int simobjectid)
        {
            return (GuiAutoScrollCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiAutoScrollCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiAutoScrollCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiAutoScrollCtrl_Base(uint simobjectid)
        {
            return (GuiAutoScrollCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiAutoScrollCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Padding to put around child control (in pixels). 
        /// </summary>
        [MemberGroup("Scrolling")]
        public int childBorder
        {
            get { return Omni.self.GetVar(_ID + ".childBorder").AsInt(); }
            set { Omni.self.SetVar(_ID + ".childBorder", value.AsString()); }
        }

        /// <summary>
        /// If true, the scrolling will reset to the beginning once completing a cycle. 
        /// </summary>
        [MemberGroup("Scrolling")]
        public bool isLooping
        {
            get { return Omni.self.GetVar(_ID + ".isLooping").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isLooping", value.AsString()); }
        }

        /// <summary>
        /// Seconds to wait after scrolling completes before resetting and starting over.\n\n     @note Only takes effect if #isLooping is true. 
        /// </summary>
        [MemberGroup("Scrolling")]
        public float resetDelay
        {
            get { return Omni.self.GetVar(_ID + ".resetDelay").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".resetDelay", value.AsString()); }
        }

        /// <summary>
        /// Direction in which the child control is moved. 
        /// </summary>
        [MemberGroup("Scrolling")]
        public TypeGuiAutoScrollDirection scrollDirection
        {
            get { return (TypeGuiAutoScrollDirection) Omni.self.GetVar(_ID + ".scrollDirection"); }
            set { Omni.self.SetVar(_ID + ".scrollDirection", value.ToString()); }
        }

        /// <summary>
        /// If true, the child control will be completely scrolled out of sight; otherwise it will only scroll      until the other end becomes visible. 
        /// </summary>
        [MemberGroup("Scrolling")]
        public bool scrollOutOfSight
        {
            get { return Omni.self.GetVar(_ID + ".scrollOutOfSight").AsBool(); }
            set { Omni.self.SetVar(_ID + ".scrollOutOfSight", value.AsString()); }
        }

        /// <summary>
        /// Scrolling speed in pixels per second. 
        /// </summary>
        [MemberGroup("Scrolling")]
        public float scrollSpeed
        {
            get { return Omni.self.GetVar(_ID + ".scrollSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".scrollSpeed", value.AsString()); }
        }

        /// <summary>
        /// Seconds to wait before starting to scroll. 
        /// </summary>
        [MemberGroup("Scrolling")]
        public float startDelay
        {
            get { return Omni.self.GetVar(_ID + ".startDelay").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".startDelay", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Reset scrolling. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reset()
        {
            m_ts.fnGuiAutoScrollCtrl_reset(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called every 32ms on the control. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onTick()
        {
        }

        /// <summary>
        /// Called when the control starts to scroll. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onStart()
        {
        }

        /// <summary>
        /// Called when the child control has been scrolled in entirety. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onComplete()
        {
        }

        /// <summary>
        /// Called when the child control is reset to its initial position and the cycle starts again. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onReset()
        {
        }

        #endregion

        public GuiAutoScrollCtrl_Base()
        {
        }
    }
}