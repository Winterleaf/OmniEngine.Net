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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiFrameSetCtrl_Base>))]
    public partial class GuiFrameSetCtrl_Base : GuiContainer
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiFrameSetCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiFrameSetCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiFrameSetCtrl_Base ts)
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
        public static implicit operator GuiFrameSetCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiFrameSetCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiFrameSetCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiFrameSetCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiFrameSetCtrl_Base(int simobjectid)
        {
            return (GuiFrameSetCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiFrameSetCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiFrameSetCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiFrameSetCtrl_Base(uint simobjectid)
        {
            return (GuiFrameSetCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiFrameSetCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// If true, row and column offsets are automatically scaled to match the    new extents when the control is resized. 
        /// </summary>
        [MemberGroup("")]
        public bool autoBalance
        {
            get { return Omni.self.GetVar(_ID + ".autoBalance").AsBool(); }
            set { Omni.self.SetVar(_ID + ".autoBalance", value.AsString()); }
        }

        /// <summary>
        /// Color of interior borders between cells. 
        /// </summary>
        [MemberGroup("")]
        public ColorI borderColor
        {
            get { return Omni.self.GetVar(_ID + ".borderColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".borderColor", value.AsString()); }
        }

        /// <summary>
        /// Controls whether frame borders are enabled.\n\nFrames use this value    unless overridden for that frame using i%ctrl.frameBorder(index)/i 
        /// </summary>
        [MemberGroup("")]
        public TypeGuiFrameState borderEnable
        {
            get { return (TypeGuiFrameState) Omni.self.GetVar(_ID + ".borderEnable"); }
            set { Omni.self.SetVar(_ID + ".borderEnable", value.ToString()); }
        }

        /// <summary>
        /// Controls whether borders can be dynamically repositioned with the mouse    by the user.\n\nFrames use this value unless overridden for that frame    using i%ctrl.frameMovable(index)/i 
        /// </summary>
        [MemberGroup("")]
        public TypeGuiFrameState borderMovable
        {
            get { return (TypeGuiFrameState) Omni.self.GetVar(_ID + ".borderMovable"); }
            set { Omni.self.SetVar(_ID + ".borderMovable", value.ToString()); }
        }

        /// <summary>
        /// Width of interior borders between cells in pixels. 
        /// </summary>
        [MemberGroup("")]
        public int borderWidth
        {
            get { return Omni.self.GetVar(_ID + ".borderWidth").AsInt(); }
            set { Omni.self.SetVar(_ID + ".borderWidth", value.AsString()); }
        }

        /// <summary>
        /// A vector of column offsets (determines the width of each column). 
        /// </summary>
        [MemberGroup("")]
        public VectorInt columns
        {
            get { return Omni.self.GetVar(_ID + ".columns").AsVectorInt(); }
            set { Omni.self.SetVar(_ID + ".columns", value.AsString()); }
        }

        /// <summary>
        /// Offset for row and column dividers in pixels 
        /// </summary>
        [MemberGroup("")]
        public int fudgeFactor
        {
            get { return Omni.self.GetVar(_ID + ".fudgeFactor").AsInt(); }
            set { Omni.self.SetVar(_ID + ".fudgeFactor", value.AsString()); }
        }

        /// <summary>
        /// A vector of row offsets (determines the height of each row). 
        /// </summary>
        [MemberGroup("")]
        public VectorInt rows
        {
            get { return Omni.self.GetVar(_ID + ".rows").AsVectorInt(); }
            set { Omni.self.SetVar(_ID + ".rows", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Add a new column. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addColumn()
        {
            m_ts.fnGuiFrameSetCtrl_addColumn(_ID);
        }

        /// <summary>
        /// Add a new row. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addRow()
        {
            m_ts.fnGuiFrameSetCtrl_addRow(_ID);
        }

        /// <summary>
        /// dynamic ),   Override the i>borderEnable/i> setting for this frame.   @param index  Index of the frame to modify   @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void frameBorder(int index, string state = "dynamic")
        {
            m_ts.fnGuiFrameSetCtrl_frameBorder(_ID, index, state);
        }

        /// <summary>
        /// Set the minimum width and height for the frame. It will not be possible    for the user to resize the frame smaller than this.   @param index  Index of the frame to modify   @param width  Minimum width in pixels   @param height Minimum height in pixels )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void frameMinExtent(int index, int width, int height)
        {
            m_ts.fnGuiFrameSetCtrl_frameMinExtent(_ID, index, width, height);
        }

        /// <summary>
        /// dynamic ),   Override the i>borderMovable/i> setting for this frame.   @param index  Index of the frame to modify   @param state  New borderEnable state: \"on\", \"off\" or \"dynamic\" )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void frameMovable(int index, string state = "dynamic")
        {
            m_ts.fnGuiFrameSetCtrl_frameMovable(_ID, index, state);
        }

        /// <summary>
        /// Set the padding for this frame. Padding introduces blank space on the inside    edge of the frame.   @param index     Index of the frame to modify   @param padding   Frame top, bottom, left, and right padding )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void framePadding(int index, RectSpacingI padding)
        {
            m_ts.fnGuiFrameSetCtrl_framePadding(_ID, index, padding.AsString());
        }

        /// <summary>
        /// Get the number of columns.   @return The number of columns )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getColumnCount()
        {
            return m_ts.fnGuiFrameSetCtrl_getColumnCount(_ID);
        }

        /// <summary>
        /// Get the horizontal offset of a column.   @param index Index of the column to query   @return Column offset in pixels )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getColumnOffset(int index)
        {
            return m_ts.fnGuiFrameSetCtrl_getColumnOffset(_ID, index);
        }

        /// <summary>
        /// Get the padding for this frame.   @param index     Index of the frame to query )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public RectSpacingI getFramePadding(int index)
        {
            return new RectSpacingI(m_ts.fnGuiFrameSetCtrl_getFramePadding(_ID, index));
        }

        /// <summary>
        /// Get the number of rows.   @return The number of rows )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRowCount()
        {
            return m_ts.fnGuiFrameSetCtrl_getRowCount(_ID);
        }

        /// <summary>
        /// Get the vertical offset of a row.   @param index Index of the row to query   @return Row offset in pixels )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getRowOffset(int index)
        {
            return m_ts.fnGuiFrameSetCtrl_getRowOffset(_ID, index);
        }

        /// <summary>
        /// Remove the last (rightmost) column. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeColumn()
        {
            m_ts.fnGuiFrameSetCtrl_removeColumn(_ID);
        }

        /// <summary>
        /// Remove the last (bottom) row. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeRow()
        {
            m_ts.fnGuiFrameSetCtrl_removeRow(_ID);
        }

        /// <summary>
        /// Set the horizontal offset of a column.   Note that column offsets must always be in increasing order, and therefore    this offset must be between the offsets of the colunns either side.   @param index  Index of the column to modify   @param offset New column offset )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setColumnOffset(int index, int offset)
        {
            m_ts.fnGuiFrameSetCtrl_setColumnOffset(_ID, index, offset);
        }

        /// <summary>
        /// Set the vertical offset of a row.   Note that row offsets must always be in increasing order, and therefore    this offset must be between the offsets of the rows either side.   @param index  Index of the row to modify   @param offset New row offset )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setRowOffset(int index, int offset)
        {
            m_ts.fnGuiFrameSetCtrl_setRowOffset(_ID, index, offset);
        }

        /// <summary>
        /// Recalculates child control sizes. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void updateSizes()
        {
            m_ts.fnGuiFrameSetCtrl_updateSizes(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiFrameSetCtrl_Base()
        {
        }
    }
}