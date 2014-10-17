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

using System;
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
    [TypeConverter(typeof (TypeConverterGeneric<GuiRolloutCtrl_Base>))]
    public partial class GuiRolloutCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiRolloutCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiRolloutCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiRolloutCtrl_Base ts)
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
        public static implicit operator GuiRolloutCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiRolloutCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiRolloutCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiRolloutCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiRolloutCtrl_Base(int simobjectid)
        {
            return (GuiRolloutCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiRolloutCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiRolloutCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiRolloutCtrl_Base(uint simobjectid)
        {
            return (GuiRolloutCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiRolloutCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Whether to automatically collapse sibling rollouts.\n\n     If this is true, the rollout will automatically collapse all sibling rollout controls when it      is expanded. If this is false, the auto-collapse behavior can be triggered by CTRL (CMD on MAC)      clicking the rollout header. CTRL/CMD clicking also works if this is false, in which case the      auto-collapsing of sibling controls will be temporarily deactivated. 
        /// </summary>
        [MemberGroup("Rollout")]
        public bool autoCollapseSiblings
        {
            get { return Omni.self.GetVar(_ID + ".autoCollapseSiblings").AsBool(); }
            set { Omni.self.SetVar(_ID + ".autoCollapseSiblings", value.AsString()); }
        }

        /// <summary>
        /// Text label to display on the rollout header. 
        /// </summary>
        [MemberGroup("Rollout")]
        public String caption
        {
            get { return Omni.self.GetVar(_ID + ".caption").AsString(); }
            set { Omni.self.SetVar(_ID + ".caption", value.AsString()); }
        }

        /// <summary>
        /// Whether the rollout can be collapsed by clicking its header. 
        /// </summary>
        [MemberGroup("Rollout")]
        public bool clickCollapse
        {
            get { return Omni.self.GetVar(_ID + ".clickCollapse").AsBool(); }
            set { Omni.self.SetVar(_ID + ".clickCollapse", value.AsString()); }
        }

        /// <summary>
        /// Default height of the client area. This is used when no child control has been added to the rollout. 
        /// </summary>
        [MemberGroup("Rollout")]
        public int defaultHeight
        {
            get { return Omni.self.GetVar(_ID + ".defaultHeight").AsInt(); }
            set { Omni.self.SetVar(_ID + ".defaultHeight", value.AsString()); }
        }

        /// <summary>
        /// The current rollout expansion state. 
        /// </summary>
        [MemberGroup("Rollout")]
        public bool expanded
        {
            get { return Omni.self.GetVar(_ID + ".expanded").AsBool(); }
            set { Omni.self.SetVar(_ID + ".expanded", value.AsString()); }
        }

        /// <summary>
        /// Whether to render the rollout header.\n\n     @note If this is false, the user cannot toggle the rollout state with the mouse. 
        /// </summary>
        [MemberGroup("Rollout")]
        public bool hideHeader
        {
            get { return Omni.self.GetVar(_ID + ".hideHeader").AsBool(); }
            set { Omni.self.SetVar(_ID + ".hideHeader", value.AsString()); }
        }

        /// <summary>
        /// Margin to put around child control. 
        /// </summary>
        [MemberGroup("Rollout")]
        public RectI margin
        {
            get { return Omni.self.GetVar(_ID + ".margin").AsRectI(); }
            set { Omni.self.SetVar(_ID + ".margin", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Collapse the rollout if it is currently expanded.  This will make the rollout's child control invisible.   @note The rollout will animate to collapsed state.  To instantly collapse without animation, use instantCollapse(). )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void collapse()
        {
            m_ts.fnGuiRolloutCtrl_collapse(_ID);
        }

        /// <summary>
        /// Expand the rollout if it is currently collapsed.  This will make the rollout's child control visible.   @note The rollout will animate to expanded state.  To instantly expand without animation, use instantExpand(). )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void expand()
        {
            m_ts.fnGuiRolloutCtrl_expand(_ID);
        }

        /// <summary>
        /// Instantly collapse the rollout without animation.  To smoothly slide the rollout to collapsed state, use collapse(). )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void instantCollapse()
        {
            m_ts.fnGuiRolloutCtrl_instantCollapse(_ID);
        }

        /// <summary>
        /// Instantly expand the rollout without animation.  To smoothly slide the rollout to expanded state, use expand(). )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void instantExpand()
        {
            m_ts.fnGuiRolloutCtrl_instantExpand(_ID);
        }

        /// <summary>
        /// Determine whether the rollout is currently expanded, i.e. whether the child control is visible.   @return True if the rollout is expanded, false if not. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new bool isExpanded()
        {
            return m_ts.fnGuiRolloutCtrl_isExpanded(_ID);
        }

        /// <summary>
        /// Resize the rollout to exactly fit around its child control.  This can be used to manually trigger a recomputation of    the rollout size. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void sizeToContents()
        {
            m_ts.fnGuiRolloutCtrl_sizeToContents(_ID);
        }

        /// <summary>
        /// Toggle the current collapse state of the rollout.  If it is currently expanded, then collapse it.  If it    is currently collapsed, then expand it. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void toggleCollapse()
        {
            m_ts.fnGuiRolloutCtrl_toggleCollapse(_ID);
        }

        /// <summary>
        /// Toggle the current expansion state of the rollout  If it is currently expanded, then collapse it.  If it    is currently collapsed, then expand it.   @param instant If true, the rollout will toggle its state without animation.  Otherwise, the rollout will       smoothly slide into the opposite state. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void toggleExpanded(bool instantly = false)
        {
            m_ts.fnGuiRolloutCtrl_toggleExpanded(_ID, instantly);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when the user right-clicks on the rollout's header.  This is useful for implementing    context menus for rollouts. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onHeaderRightClick()
        {
        }

        /// <summary>
        /// Called when the rollout is expanded. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onExpanded()
        {
        }

        /// <summary>
        /// Called when the rollout is collapsed. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onCollapsed()
        {
        }

        #endregion

        public GuiRolloutCtrl_Base()
        {
        }
    }
}