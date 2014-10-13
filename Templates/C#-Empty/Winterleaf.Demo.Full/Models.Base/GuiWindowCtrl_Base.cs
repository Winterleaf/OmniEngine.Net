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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiWindowCtrl_Base>))]
    public partial class GuiWindowCtrl_Base : GuiContainer
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiWindowCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiWindowCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiWindowCtrl_Base ts)
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
        public static implicit operator GuiWindowCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiWindowCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiWindowCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiWindowCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiWindowCtrl_Base(int simobjectid)
        {
            return (GuiWindowCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiWindowCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiWindowCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiWindowCtrl_Base(uint simobjectid)
        {
            return (GuiWindowCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiWindowCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Whether the window can be poped out.
        /// </summary>
        [MemberGroup("PopOut")]
        public bool AllowPopWindow
        {
            get { return Omni.self.GetVar(_ID + ".AllowPopWindow").AsBool(); }
            set { Omni.self.SetVar(_ID + ".AllowPopWindow", value.AsString()); }
        }

        /// <summary>
        /// Whether the window has a close button. 
        /// </summary>
        [MemberGroup("Window")]
        public bool canClose
        {
            get { return Omni.self.GetVar(_ID + ".canClose").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canClose", value.AsString()); }
        }

        /// <summary>
        /// Whether the window can be collapsed by clicking its title bar. 
        /// </summary>
        [MemberGroup("Window")]
        public bool canCollapse
        {
            get { return Omni.self.GetVar(_ID + ".canCollapse").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canCollapse", value.AsString()); }
        }

        /// <summary>
        /// Whether the window has a maximize button. 
        /// </summary>
        [MemberGroup("Window")]
        public bool canMaximize
        {
            get { return Omni.self.GetVar(_ID + ".canMaximize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canMaximize", value.AsString()); }
        }

        /// <summary>
        /// Whether the window has a minimize button. 
        /// </summary>
        [MemberGroup("Window")]
        public bool canMinimize
        {
            get { return Omni.self.GetVar(_ID + ".canMinimize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canMinimize", value.AsString()); }
        }

        /// <summary>
        /// Whether the window can be moved by dragging its titlebar. 
        /// </summary>
        [MemberGroup("Window")]
        public bool canMove
        {
            get { return Omni.self.GetVar(_ID + ".canMove").AsBool(); }
            set { Omni.self.SetVar(_ID + ".canMove", value.AsString()); }
        }

        /// <summary>
        /// Script code to execute when the window is closed. 
        /// </summary>
        [MemberGroup("Window")]
        public String closeCommand
        {
            get { return Omni.self.GetVar(_ID + ".closeCommand").AsString(); }
            set { Omni.self.SetVar(_ID + ".closeCommand", value.AsString()); }
        }

        /// <summary>
        /// If true, the window will snap to the edges of other windows when moved close to them. 
        /// </summary>
        [MemberGroup("Window")]
        public bool edgeSnap
        {
            get { return Omni.self.GetVar(_ID + ".edgeSnap").AsBool(); }
            set { Omni.self.SetVar(_ID + ".edgeSnap", value.AsString()); }
        }

        /// <summary>
        /// If the windowctrl is being shown on own canvas
        /// </summary>
        [MemberGroup("PopOut")]
        public bool isInPopup
        {
            get { return Omni.self.GetVar(_ID + ".isInPopup").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isInPopup", value.AsString()); }
        }

        /// <summary>
        /// Whether the window can be resized vertically. 
        /// </summary>
        [MemberGroup("Window")]
        public bool resizeHeight
        {
            get { return Omni.self.GetVar(_ID + ".resizeHeight").AsBool(); }
            set { Omni.self.SetVar(_ID + ".resizeHeight", value.AsString()); }
        }

        /// <summary>
        /// Whether the window can be resized horizontally. 
        /// </summary>
        [MemberGroup("Window")]
        public bool resizeWidth
        {
            get { return Omni.self.GetVar(_ID + ".resizeWidth").AsBool(); }
            set { Omni.self.SetVar(_ID + ".resizeWidth", value.AsString()); }
        }

        /// <summary>
        /// Allows the user to set the title of the control in the game. 
        /// </summary>
        [MemberGroup("Context Menu Options")]
        public bool setTitle
        {
            get { return Omni.self.GetVar(_ID + ".setTitle").AsBool(); }
            set { Omni.self.SetVar(_ID + ".setTitle", value.AsString()); }
        }

        /// <summary>
        /// Whether the Title Ctrl will show. 
        /// </summary>
        [MemberGroup("PopOut")]
        public bool ShowTitle
        {
            get { return Omni.self.GetVar(_ID + ".ShowTitle").AsBool(); }
            set { Omni.self.SetVar(_ID + ".ShowTitle", value.AsString()); }
        }

        /// <summary>
        /// Text label to display in titlebar. 
        /// </summary>
        [MemberGroup("Window")]
        public String text
        {
            get { return Omni.self.GetVar(_ID + ".text").AsString(); }
            set { Omni.self.SetVar(_ID + ".text", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        ///  )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void attachTo(string window)
        {
            m_ts.fnGuiWindowCtrl_attachTo(_ID, window);
        }

        /// <summary>
        /// Puts the guiwindow back on the main canvas. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void ClosePopOut()
        {
            m_ts.fnGuiWindowCtrl_ClosePopOut(_ID);
        }

        /// <summary>
        /// Returns the title of the window. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getWindowTitle()
        {
            return m_ts.fnGuiWindowCtrl_getWindowTitle(_ID);
        }

        /// <summary>
        /// Returns if the title can be set or not. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isTitleSet()
        {
            return m_ts.fnGuiWindowCtrl_isTitleSet(_ID);
        }

        /// <summary>
        /// Puts the guiwindow on a new canvas. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void OpenPopOut()
        {
            m_ts.fnGuiWindowCtrl_OpenPopOut(_ID);
        }

        /// <summary>
        /// Bring the window to the front. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void selectWindow()
        {
            m_ts.fnGuiWindowCtrl_selectWindow(_ID);
        }

        /// <summary>
        /// Set the window's collapsing state. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCollapseGroup(bool state)
        {
            m_ts.fnGuiWindowCtrl_setCollapseGroup(_ID, state);
        }

        /// <summary>
        /// Displays the option to set the title of the window. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setContextTitle(bool title)
        {
            m_ts.fnGuiWindowCtrl_setContextTitle(_ID, title);
        }

        /// <summary>
        /// Sets the title of the window. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setWindowTitle(string title)
        {
            m_ts.fnGuiWindowCtrl_setWindowTitle(_ID, title);
        }

        /// <summary>
        /// Toggle the window collapsing. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void toggleCollapseGroup()
        {
            m_ts.fnGuiWindowCtrl_toggleCollapseGroup(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when the close button has been pressed. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onClose()
        {
        }

        /// <summary>
        /// Called when the window has been minimized. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMinimize()
        {
        }

        /// <summary>
        /// Called when the window has been maximized. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMaximize()
        {
        }

        /// <summary>
        /// Called when the window is collapsed by clicking its title bar. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onCollapse()
        {
        }

        /// <summary>
        /// Called when the window is restored from minimized, maximized, or collapsed state. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onRestore()
        {
        }

        /// <summary>
        /// When the canvas the window is on loses focus)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onLoseFocus()
        {
        }

        /// <summary>
        /// When the canvas the window is on loses focus)
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onGainFocus()
        {
        }

        /// <summary>
        /// Called when the window is Popped out of the main canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPopWindow()
        {
        }

        /// <summary>
        /// Called when the window is Popped back into the main canvas. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPopWindowClosed()
        {
        }

        #endregion

        public GuiWindowCtrl_Base()
        {
        }
    }
}