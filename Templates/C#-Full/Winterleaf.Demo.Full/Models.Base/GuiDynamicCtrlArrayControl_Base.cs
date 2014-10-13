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
    [TypeConverter(typeof (TypeConverterGeneric<GuiDynamicCtrlArrayControl_Base>))]
    public partial class GuiDynamicCtrlArrayControl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiDynamicCtrlArrayControl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiDynamicCtrlArrayControl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiDynamicCtrlArrayControl_Base ts)
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
        public static implicit operator GuiDynamicCtrlArrayControl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiDynamicCtrlArrayControl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiDynamicCtrlArrayControl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiDynamicCtrlArrayControl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiDynamicCtrlArrayControl_Base(int simobjectid)
        {
            return (GuiDynamicCtrlArrayControl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiDynamicCtrlArrayControl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiDynamicCtrlArrayControl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiDynamicCtrlArrayControl_Base(uint simobjectid)
        {
            return (GuiDynamicCtrlArrayControl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiDynamicCtrlArrayControl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// When true, the cell size is set to the widest/tallest child control. 
        /// </summary>
        [MemberGroup("")]
        public bool autoCellSize
        {
            get { return Omni.self.GetVar(_ID + ".autoCellSize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".autoCellSize", value.AsString()); }
        }

        /// <summary>
        /// Number of columns the child controls have been arranged into. This    value is calculated automatically when children are added, removed or    resized; writing it directly has no effect. 
        /// </summary>
        [MemberGroup("")]
        public int colCount
        {
            get { return Omni.self.GetVar(_ID + ".colCount").AsInt(); }
            set { Omni.self.SetVar(_ID + ".colCount", value.AsString()); }
        }

        /// <summary>
        /// Width of each column. If iautoCellSize/i is set, this will be    calculated automatically from the widest child control 
        /// </summary>
        [MemberGroup("")]
        public int colSize
        {
            get { return Omni.self.GetVar(_ID + ".colSize").AsInt(); }
            set { Omni.self.SetVar(_ID + ".colSize", value.AsString()); }
        }

        /// <summary>
        /// Spacing between columns 
        /// </summary>
        [MemberGroup("")]
        public int colSpacing
        {
            get { return Omni.self.GetVar(_ID + ".colSpacing").AsInt(); }
            set { Omni.self.SetVar(_ID + ".colSpacing", value.AsString()); }
        }

        /// <summary>
        /// If true, the width or height of this control will be automatically    calculated based on the number of child controls (width if    ifillRowFirst/i is false, height if ifillRowFirst/i is true). 
        /// </summary>
        [MemberGroup("")]
        public bool dynamicSize
        {
            get { return Omni.self.GetVar(_ID + ".dynamicSize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".dynamicSize", value.AsString()); }
        }

        /// <summary>
        /// Controls whether rows or columns are filled first.\n\nIf true, controls are    added to the grid left-to-right (to fill a row
        /// </summary>
        [MemberGroup("")]
        public bool fillRowFirst
        {
            get { return Omni.self.GetVar(_ID + ".fillRowFirst").AsBool(); }
            set { Omni.self.SetVar(_ID + ".fillRowFirst", value.AsString()); }
        }

        /// <summary>
        /// When true, the array will not update when new children are added or in    response to child resize events. This is useful to prevent unnecessary    resizing when adding, removing or resizing a number of child controls. 
        /// </summary>
        [MemberGroup("")]
        public bool frozen
        {
            get { return Omni.self.GetVar(_ID + ".frozen").AsBool(); }
            set { Omni.self.SetVar(_ID + ".frozen", value.AsString()); }
        }

        /// <summary>
        /// Padding around the top, bottom, left, and right of this control. This    reduces the area available for child controls. 
        /// </summary>
        [MemberGroup("")]
        public RectSpacingI padding
        {
            get { return Omni.self.GetVar(_ID + ".padding").AsRectSpacingI(); }
            set { Omni.self.SetVar(_ID + ".padding", value.AsString()); }
        }

        /// <summary>
        /// Number of rows the child controls have been arranged into. This value    is calculated automatically when children are added, removed or resized;    writing it directly has no effect. 
        /// </summary>
        [MemberGroup("")]
        public int rowCount
        {
            get { return Omni.self.GetVar(_ID + ".rowCount").AsInt(); }
            set { Omni.self.SetVar(_ID + ".rowCount", value.AsString()); }
        }

        /// <summary>
        /// Height of each row. If iautoCellSize/i is set, this will be    calculated automatically from the tallest child control 
        /// </summary>
        [MemberGroup("")]
        public int rowSize
        {
            get { return Omni.self.GetVar(_ID + ".rowSize").AsInt(); }
            set { Omni.self.SetVar(_ID + ".rowSize", value.AsString()); }
        }

        /// <summary>
        /// Spacing between rows 
        /// </summary>
        [MemberGroup("")]
        public int rowSpacing
        {
            get { return Omni.self.GetVar(_ID + ".rowSpacing").AsInt(); }
            set { Omni.self.SetVar(_ID + ".rowSpacing", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Recalculates the position and size of this control and all its children. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public new void refresh()
        {
            m_ts.fnGuiDynamicCtrlArrayControl_refresh(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiDynamicCtrlArrayControl_Base()
        {
        }
    }
}