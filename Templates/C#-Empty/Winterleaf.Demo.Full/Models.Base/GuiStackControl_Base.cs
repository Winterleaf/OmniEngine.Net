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
    [TypeConverter(typeof (TypeConverterGeneric<GuiStackControl_Base>))]
    public partial class GuiStackControl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiStackControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiStackControl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiStackControl_Base ts)
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
        public static implicit operator GuiStackControl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiStackControl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiStackControl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiStackControl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiStackControl_Base(int simobjectid)
        {
            return (GuiStackControl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiStackControl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiStackControl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiStackControl_Base(uint simobjectid)
        {
            return (GuiStackControl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiStackControl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Determines whether to reposition child controls.\n\n   If true, horizontally stacked children are aligned along the top edge of    the stack control. Vertically stacked children are aligned along the left    edge of the stack control. If false, horizontally stacked children retain    their Y position, and vertically stacked children retain their X position. 
        /// </summary>
        [MemberGroup("Stacking")]
        public bool changeChildPosition
        {
            get { return Omni.self.GetVar(_ID + ".changeChildPosition").AsBool(); }
            set { Omni.self.SetVar(_ID + ".changeChildPosition", value.AsString()); }
        }

        /// <summary>
        /// Determines whether to resize child controls.\n\n   If true, horizontally stacked children keep their width, but have their    height set to the stack control height. Vertically stacked children keep    their height, but have their width set to the stack control width. If    false, child controls are not resized. 
        /// </summary>
        [MemberGroup("Stacking")]
        public bool changeChildSizeToFit
        {
            get { return Omni.self.GetVar(_ID + ".changeChildSizeToFit").AsBool(); }
            set { Omni.self.SetVar(_ID + ".changeChildSizeToFit", value.AsString()); }
        }

        /// <summary>
        /// Determines whether to resize the stack control along the non-stack axis (change    height for horizontal stacking, change width for vertical stacking). No effect    if dynamicSize is false.\n\n   If true, the stack will be resized to the maximum of the child control widths/heights.    If false, the stack will not be resized. 
        /// </summary>
        [MemberGroup("Stacking")]
        public bool dynamicNonStackExtent
        {
            get { return Omni.self.GetVar(_ID + ".dynamicNonStackExtent").AsBool(); }
            set { Omni.self.SetVar(_ID + ".dynamicNonStackExtent", value.AsString()); }
        }

        /// <summary>
        /// Determines whether to reposition the stack along the stack axis when it is    auto-resized. No effect if dynamicSize is false.\n\n   If true, the stack will grow left for horizontal stacking, and grow up for vertical stacking.\n   If false, the stack will grow right for horizontal stacking, and grow down for vertical stacking.\n 
        /// </summary>
        [MemberGroup("Stacking")]
        public bool dynamicPos
        {
            get { return Omni.self.GetVar(_ID + ".dynamicPos").AsBool(); }
            set { Omni.self.SetVar(_ID + ".dynamicPos", value.AsString()); }
        }

        /// <summary>
        /// Determines whether to resize the stack control along the stack axis (change    width for horizontal stacking, change height for vertical stacking).\n\n   If true, the stack width/height will be resized to the sum of the child control widths/heights.    If false, the stack will not be resized. 
        /// </summary>
        [MemberGroup("Stacking")]
        public bool dynamicSize
        {
            get { return Omni.self.GetVar(_ID + ".dynamicSize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".dynamicSize", value.AsString()); }
        }

        /// <summary>
        /// Controls the type of horizontal stacking to use (iLeft to Right/i or    iRight to Left/i) 
        /// </summary>
        [MemberGroup("Stacking")]
        public TypeGuiHorizontalStackingType horizStacking
        {
            get { return (TypeGuiHorizontalStackingType) Omni.self.GetVar(_ID + ".horizStacking"); }
            set { Omni.self.SetVar(_ID + ".horizStacking", value.ToString()); }
        }

        /// <summary>
        /// Distance (in pixels) between stacked child controls. 
        /// </summary>
        [MemberGroup("Stacking")]
        public int padding
        {
            get { return Omni.self.GetVar(_ID + ".padding").AsInt(); }
            set { Omni.self.SetVar(_ID + ".padding", value.AsString()); }
        }

        /// <summary>
        /// Determines the method used to position the child controls.\n\n 
        /// </summary>
        [MemberGroup("Stacking")]
        public TypeGuiStackingType stackingType
        {
            get { return (TypeGuiStackingType) Omni.self.GetVar(_ID + ".stackingType"); }
            set { Omni.self.SetVar(_ID + ".stackingType", value.ToString()); }
        }

        /// <summary>
        /// Controls the type of vertical stacking to use (iTop to Bottom/i or    iBottom to Top/i) 
        /// </summary>
        [MemberGroup("Stacking")]
        public TypeGuiVerticalStackingType vertStacking
        {
            get { return (TypeGuiVerticalStackingType) Omni.self.GetVar(_ID + ".vertStacking"); }
            set { Omni.self.SetVar(_ID + ".vertStacking", value.ToString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Prevents control from restacking - useful when adding or removing child controls   @param freeze True to freeze the control, false to unfreeze it   @tsexample   %stackCtrl.freeze(true);   // add controls to stack   %stackCtrl.freeze(false);   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void freeze(bool freeze)
        {
            m_ts.fnGuiStackControl_freeze(_ID, freeze);
        }

        /// <summary>
        /// Return whether or not this control is frozen )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isFrozen()
        {
            return m_ts.fnGuiStackControl_isFrozen(_ID);
        }

        /// <summary>
        /// Restack the child controls. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void updateStack()
        {
            m_ts.fnGuiStackControl_updateStack(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiStackControl_Base()
        {
        }
    }
}