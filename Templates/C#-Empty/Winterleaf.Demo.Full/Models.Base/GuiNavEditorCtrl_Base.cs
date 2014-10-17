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
    [TypeConverter(typeof (TypeConverterGeneric<GuiNavEditorCtrl_Base>))]
    public partial class GuiNavEditorCtrl_Base : EditTSCtrl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiNavEditorCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiNavEditorCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiNavEditorCtrl_Base ts)
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
        public static implicit operator GuiNavEditorCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiNavEditorCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiNavEditorCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiNavEditorCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiNavEditorCtrl_Base(int simobjectid)
        {
            return (GuiNavEditorCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiNavEditorCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiNavEditorCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiNavEditorCtrl_Base(uint simobjectid)
        {
            return (GuiNavEditorCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiNavEditorCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// 
        /// </summary>
        [MemberGroup("")]
        public bool isDirty
        {
            get { return Omni.self.GetVar(_ID + ".isDirty").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isDirty", value.AsString()); }
        }

        /// <summary>
        /// Class of object to spawn in test mode.
        /// </summary>
        [MemberGroup("")]
        public String spawnClass
        {
            get { return Omni.self.GetVar(_ID + ".spawnClass").AsString(); }
            set { Omni.self.SetVar(_ID + ".spawnClass", value.AsString()); }
        }

        /// <summary>
        /// Datablock to give new objects in test mode.
        /// </summary>
        [MemberGroup("")]
        public String spawnDatablock
        {
            get { return Omni.self.GetVar(_ID + ".spawnDatablock").AsString(); }
            set { Omni.self.SetVar(_ID + ".spawnDatablock", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// )
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getMode()
        {
            return m_ts.fn_GuiNavEditorCtrl_getMode(_ID);
        }

        /// <summary>
        /// setMode(String mode))
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setMode(string newMode)
        {
            m_ts.fn_GuiNavEditorCtrl_setMode(_ID, newMode);
        }

        /// <summary>
        /// @brief Build the currently selected tile.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void buildTile()
        {
            m_ts.fnGuiNavEditorCtrl_buildTile(_ID);
        }

        /// <summary>
        /// @brief Delete the currently selected link.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void deleteLink()
        {
            m_ts.fnGuiNavEditorCtrl_deleteLink(_ID);
        }

        /// <summary>
        /// @brief Deselect whatever is currently selected in the editor.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void deselect()
        {
            m_ts.fnGuiNavEditorCtrl_deselect(_ID);
        }

        /// <summary>
        /// @brief Select a NavMesh object.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getMesh()
        {
            return m_ts.fnGuiNavEditorCtrl_getMesh(_ID);
        }

        /// <summary>
        /// @brief Select a NavMesh object.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getPlayer()
        {
            return m_ts.fnGuiNavEditorCtrl_getPlayer(_ID);
        }

        /// <summary>
        /// @brief Select a NavMesh object.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void selectMesh(int id)
        {
            m_ts.fnGuiNavEditorCtrl_selectMesh(_ID, id);
        }

        /// <summary>
        /// @Brief Set jump and drop properties of the selected link.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setLinkFlags(uint flags)
        {
            m_ts.fnGuiNavEditorCtrl_setLinkFlags(_ID, flags);
        }

        /// <summary>
        /// @brief Spawn an AIPlayer at the centre of the screen.)
        /// 
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void spawnPlayer()
        {
            m_ts.fnGuiNavEditorCtrl_spawnPlayer(_ID);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onLinkDeselected()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlayerDeselected()
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onPlayerSelected(int linkDataFlags)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onLinkSelected(int linkDataFlags)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onModeSet(string mode)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void paletteSync(string mode)
        {
        }

        #endregion

        public GuiNavEditorCtrl_Base()
        {
        }
    }
}