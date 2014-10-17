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
    [TypeConverter(typeof (TypeConverterGeneric<SFXPlayList_Base>))]
    public partial class SFXPlayList_Base : SFXTrack
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXPlayList_Base ts, string simobjectid)
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
        public static bool operator !=(SFXPlayList_Base ts, string simobjectid)
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
        public static implicit operator string(SFXPlayList_Base ts)
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
        public static implicit operator SFXPlayList_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SFXPlayList_Base) Omni.self.getSimObject(simobjectid, typeof (SFXPlayList_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SFXPlayList_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXPlayList_Base(int simobjectid)
        {
            return (SFXPlayList) Omni.self.getSimObject((uint) simobjectid, typeof (SFXPlayList_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SFXPlayList_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXPlayList_Base(uint simobjectid)
        {
            return (SFXPlayList_Base) Omni.self.getSimObject(simobjectid, typeof (SFXPlayList_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("Sound")] public arrayObject<float> delayTimeIn;
        [MemberGroup("Sound")] public arrayObject<Point2F> delayTimeInVariance;
        [MemberGroup("Sound")] public arrayObject<float> delayTimeOut;
        [MemberGroup("Sound")] public arrayObject<Point2F> delayTimeOutVariance;
        [MemberGroup("Sound")] public arrayObject<float> fadeTimeIn;
        [MemberGroup("Sound")] public arrayObject<Point2F> fadeTimeInVariance;
        [MemberGroup("Sound")] public arrayObject<float> fadeTimeOut;
        [MemberGroup("Sound")] public arrayObject<Point2F> fadeTimeOutVariance;

        [MemberGroup("Sound")] public arrayObject<float> maxDistance;
        [MemberGroup("Sound")] public arrayObject<Point2F> maxDistanceVariance;

        [MemberGroup("Sound")] public arrayObject<float> pitchScale;
        [MemberGroup("Sound")] public arrayObject<Point2F> pitchScaleVariance;

        [MemberGroup("Sound")] public arrayObject<float> referenceDistance;
        [MemberGroup("Sound")] public arrayObject<Point2F> referenceDistanceVariance;
        [MemberGroup("Sound")] public arrayObject<int> repeatCount;
        [MemberGroup("Sound")] public arrayObject<TypeSFXPlayListReplayMode> replay;
        [MemberGroup("Sound")] public arrayObject<TypeSFXStateName> state;
        [MemberGroup("Sound")] public arrayObject<TypeSFXPlayListStateMode> stateMode;

        [MemberGroup("Sound")] public arrayObject<TypeSFXTrackName> track;
        [MemberGroup("Sound")] public arrayObject<TypeSFXPlayListTransitionMode> transitionIn;
        [MemberGroup("Sound")] public arrayObject<TypeSFXPlayListTransitionMode> transitionOut;
        [MemberGroup("Sound")] public arrayObject<float> volumeScale;
        [MemberGroup("Sound")] public arrayObject<Point2F> volumeScaleVariance;

        /// <summary>
        /// Behavior when description has looping enabled.\n     The loop mode determines whether the list will loop over a single slot or loop over      all the entire list of slots being played.\n\n     @see SFXDescription::isLooping 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXPlayListLoopMode loopMode
        {
            get { return (TypeSFXPlayListLoopMode) Omni.self.GetVar(_ID + ".loopMode"); }
            set { Omni.self.SetVar(_ID + ".loopMode", value.ToString()); }
        }

        /// <summary>
        /// Number of slots to play.\n     Up to a maximum of 16, this field determines the number of slots that are taken from the      list for playback. Only slots that have a valid #track assigned will be considered for      this. 
        /// </summary>
        [MemberGroup("Sound")]
        public int numSlotsToPlay
        {
            get { return Omni.self.GetVar(_ID + ".numSlotsToPlay").AsInt(); }
            set { Omni.self.SetVar(_ID + ".numSlotsToPlay", value.AsString()); }
        }

        /// <summary>
        /// Slot playback order randomization pattern.\n     By setting this field to something other than \NotRandom\ to order in which slots of the      playlist are processed can be changed from sequential to a random pattern. This allows to      to create more varied playback patterns.\n     Defaults to \NotRandom\. 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXPlayListRandomMode random
        {
            get { return (TypeSFXPlayListRandomMode) Omni.self.GetVar(_ID + ".random"); }
            set { Omni.self.SetVar(_ID + ".random", value.ToString()); }
        }

        /// <summary>
        /// Enable/disable execution tracing for this playlist (local only).\n     If this is true, SFXControllers attached to the list will automatically run in trace mode. 
        /// </summary>
        [MemberGroup("Debug")]
        public bool trace
        {
            get { return Omni.self.GetVar(_ID + ".trace").AsBool(); }
            set { Omni.self.SetVar(_ID + ".trace", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public SFXPlayList_Base()
        {
            delayTimeIn = new arrayObject<float>(16, "delayTimeIn", "TypeVariable", false, this);
            delayTimeInVariance = new arrayObject<Point2F>(16, "delayTimeInVariance", "TypeVariable", false, this);
            delayTimeOut = new arrayObject<float>(16, "delayTimeOut", "TypeVariable", false, this);
            delayTimeOutVariance = new arrayObject<Point2F>(16, "delayTimeOutVariance", "TypeVariable", false, this);
            fadeTimeIn = new arrayObject<float>(16, "fadeTimeIn", "TypeVariable", false, this);
            fadeTimeInVariance = new arrayObject<Point2F>(16, "fadeTimeInVariance", "TypeVariable", false, this);
            fadeTimeOut = new arrayObject<float>(16, "fadeTimeOut", "TypeVariable", false, this);
            fadeTimeOutVariance = new arrayObject<Point2F>(16, "fadeTimeOutVariance", "TypeVariable", false, this);
            maxDistance = new arrayObject<float>(16, "maxDistance", "TypeVariable", false, this);
            maxDistanceVariance = new arrayObject<Point2F>(16, "maxDistanceVariance", "TypeVariable", false, this);
            pitchScale = new arrayObject<float>(16, "pitchScale", "TypeVariable", false, this);
            pitchScaleVariance = new arrayObject<Point2F>(16, "pitchScaleVariance", "TypeVariable", false, this);
            referenceDistance = new arrayObject<float>(16, "referenceDistance", "TypeVariable", false, this);
            referenceDistanceVariance = new arrayObject<Point2F>(16, "referenceDistanceVariance", "TypeVariable", false, this);
            repeatCount = new arrayObject<int>(16, "repeatCount", "TypeVariable", false, this);
            replay = new arrayObject<TypeSFXPlayListReplayMode>(16, "replay", "TypeEnumeration", false, this);
            state = new arrayObject<TypeSFXStateName>(16, "state", "TypeVariable", false, this);
            stateMode = new arrayObject<TypeSFXPlayListStateMode>(16, "stateMode", "TypeEnumeration", false, this);
            track = new arrayObject<TypeSFXTrackName>(16, "track", "TypeVariable", false, this);
            transitionIn = new arrayObject<TypeSFXPlayListTransitionMode>(16, "transitionIn", "TypeEnumeration", false, this);
            transitionOut = new arrayObject<TypeSFXPlayListTransitionMode>(16, "transitionOut", "TypeEnumeration", false, this);
            volumeScale = new arrayObject<float>(16, "volumeScale", "TypeVariable", false, this);
            volumeScaleVariance = new arrayObject<Point2F>(16, "volumeScaleVariance", "TypeVariable", false, this);
        }
    }
}