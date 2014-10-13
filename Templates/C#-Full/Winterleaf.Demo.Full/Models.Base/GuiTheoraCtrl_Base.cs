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
using WinterLeaf.Engine.Enums;

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<GuiTheoraCtrl_Base>))]
    public partial class GuiTheoraCtrl_Base : GuiControl
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GuiTheoraCtrl_Base ts, string simobjectid)
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
        public static bool operator !=(GuiTheoraCtrl_Base ts, string simobjectid)
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
        public static implicit operator string(GuiTheoraCtrl_Base ts)
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
        public static implicit operator GuiTheoraCtrl_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (GuiTheoraCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTheoraCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(GuiTheoraCtrl_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTheoraCtrl_Base(int simobjectid)
        {
            return (GuiTheoraCtrl) Omni.self.getSimObject((uint) simobjectid, typeof (GuiTheoraCtrl_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(GuiTheoraCtrl_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTheoraCtrl_Base(uint simobjectid)
        {
            return (GuiTheoraCtrl_Base) Omni.self.getSimObject(simobjectid, typeof (GuiTheoraCtrl_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Fill color when video is not playing. 
        /// </summary>
        [MemberGroup("Playback")]
        public ColorI backgroundColor
        {
            get { return Omni.self.GetVar(_ID + ".backgroundColor").AsColorI(); }
            set { Omni.self.SetVar(_ID + ".backgroundColor", value.AsString()); }
        }

        /// <summary>
        /// Whether to automatically match control extents to the video size. 
        /// </summary>
        [MemberGroup("Playback")]
        public bool matchVideoSize
        {
            get { return Omni.self.GetVar(_ID + ".matchVideoSize").AsBool(); }
            set { Omni.self.SetVar(_ID + ".matchVideoSize", value.AsString()); }
        }

        /// <summary>
        /// Whether to start playing video when control is woken up. 
        /// </summary>
        [MemberGroup("Playback")]
        public bool playOnWake
        {
            get { return Omni.self.GetVar(_ID + ".playOnWake").AsBool(); }
            set { Omni.self.SetVar(_ID + ".playOnWake", value.AsString()); }
        }

        /// <summary>
        /// If true, displays an overlay on top of the video with useful debugging information. 
        /// </summary>
        [MemberGroup("Playback")]
        public bool renderDebugInfo
        {
            get { return Omni.self.GetVar(_ID + ".renderDebugInfo").AsBool(); }
            set { Omni.self.SetVar(_ID + ".renderDebugInfo", value.AsString()); }
        }

        /// <summary>
        /// Whether to stop video when control is set to sleep.\n\n     If this is not set to true, the video will be paused when the control is put to sleep. This is because there is no support      for seeking in the video stream in the player backend and letting the time source used to synchronize video (either audio      or a raw timer) get far ahead of frame decoding will cause possibly very long delays when the control is woken up again. 
        /// </summary>
        [MemberGroup("Playback")]
        public bool stopOnSleep
        {
            get { return Omni.self.GetVar(_ID + ".stopOnSleep").AsBool(); }
            set { Omni.self.SetVar(_ID + ".stopOnSleep", value.AsString()); }
        }

        /// <summary>
        /// Theora video file to play. 
        /// </summary>
        [MemberGroup("Playback")]
        public String theoraFile
        {
            get { return Omni.self.GetVar(_ID + ".theoraFile").AsString(); }
            set { Omni.self.SetVar(_ID + ".theoraFile", value.AsString()); }
        }

        /// <summary>
        /// The routine to use for Y'CbCr to RGB conversion. 
        /// </summary>
        [MemberGroup("Playback")]
        public TypeGuiTheoraTranscoder transcoder
        {
            get { return (TypeGuiTheoraTranscoder) Omni.self.GetVar(_ID + ".transcoder"); }
            set { Omni.self.SetVar(_ID + ".transcoder", value.ToString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Get the current playback time.   @return The elapsed playback time in seconds. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getCurrentTime()
        {
            return m_ts.fnGuiTheoraCtrl_getCurrentTime(_ID);
        }

        /// <summary>
        /// Test whether the video has finished playing.   @return True if the video has finished playing, false otherwise. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isPlaybackDone()
        {
            return m_ts.fnGuiTheoraCtrl_isPlaybackDone(_ID);
        }

        /// <summary>
        /// Pause playback of the video.  If the video is not currently playing, the call is ignored.   While stopped, the control displays the last frame. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pause()
        {
            m_ts.fnGuiTheoraCtrl_pause(_ID);
        }

        /// <summary>
        /// Start playing the video.  If the video is already playing, the call is ignored. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void play()
        {
            m_ts.fnGuiTheoraCtrl_play(_ID);
        }

        /// <summary>
        /// Set the video file to play.  If a video is already playing, playback is stopped and    the new video file is loaded.   @param filename The video file to load. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setFile(string filename)
        {
            m_ts.fnGuiTheoraCtrl_setFile(_ID, filename);
        }

        /// <summary>
        /// Stop playback of the video.  The next call to play() will then start playback from the beginning of the video.   While stopped, the control renders empty with just the background color. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void stop()
        {
            m_ts.fnGuiTheoraCtrl_stop(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public GuiTheoraCtrl_Base()
        {
        }
    }
}