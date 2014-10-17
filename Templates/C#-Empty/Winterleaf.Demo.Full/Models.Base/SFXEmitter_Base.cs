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
    [TypeConverter(typeof (TypeConverterGeneric<SFXEmitter_Base>))]
    public partial class SFXEmitter_Base : SceneObject
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXEmitter_Base ts, string simobjectid)
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
        public static bool operator !=(SFXEmitter_Base ts, string simobjectid)
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
        public static implicit operator string(SFXEmitter_Base ts)
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
        public static implicit operator SFXEmitter_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SFXEmitter_Base) Omni.self.getSimObject(simobjectid, typeof (SFXEmitter_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SFXEmitter_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXEmitter_Base(int simobjectid)
        {
            return (SFXEmitter) Omni.self.getSimObject((uint) simobjectid, typeof (SFXEmitter_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SFXEmitter_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXEmitter_Base(uint simobjectid)
        {
            return (SFXEmitter_Base) Omni.self.getSimObject(simobjectid, typeof (SFXEmitter_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// Angle of inner volume cone of 3D sound in degrees.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneInsideAngle 
        /// </summary>
        [MemberGroup("3D Sound")]
        public int coneInsideAngle
        {
            get { return Omni.self.GetVar(_ID + ".coneInsideAngle").AsInt(); }
            set { Omni.self.SetVar(_ID + ".coneInsideAngle", value.AsString()); }
        }

        /// <summary>
        /// Angle of outer volume cone of 3D sound in degrees\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneOutsideAngle 
        /// </summary>
        [MemberGroup("3D Sound")]
        public int coneOutsideAngle
        {
            get { return Omni.self.GetVar(_ID + ".coneOutsideAngle").AsInt(); }
            set { Omni.self.SetVar(_ID + ".coneOutsideAngle", value.AsString()); }
        }

        /// <summary>
        /// Volume scale factor of outside of outer volume 3D sound cone.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneOutsideVolume 
        /// </summary>
        [MemberGroup("3D Sound")]
        public float coneOutsideVolume
        {
            get { return Omni.self.GetVar(_ID + ".coneOutsideVolume").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".coneOutsideVolume", value.AsString()); }
        }

        /// <summary>
        /// Number of seconds to gradually fade in volume from zero when playback starts.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::fadeInTime 
        /// </summary>
        [MemberGroup("Sound")]
        public float fadeInTime
        {
            get { return Omni.self.GetVar(_ID + ".fadeInTime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fadeInTime", value.AsString()); }
        }

        /// <summary>
        /// Number of seconds to gradually fade out volume down to zero when playback is stopped or paused.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::fadeOutTime 
        /// </summary>
        [MemberGroup("Sound")]
        public float fadeOutTime
        {
            get { return Omni.self.GetVar(_ID + ".fadeOutTime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".fadeOutTime", value.AsString()); }
        }

        /// <summary>
        /// The sound file to play.\n     Use @b either this property @b or #track. If both are assigned, #track takes precendence. The primary purpose of this      field is to avoid the need for the user to define SFXTrack datablocks for all sounds used in a level. 
        /// </summary>
        [MemberGroup("Media")]
        public String fileName
        {
            get { return Omni.self.GetVar(_ID + ".fileName").AsString(); }
            set { Omni.self.SetVar(_ID + ".fileName", value.AsString()); }
        }

        /// <summary>
        /// Whether to play #fileName as a positional (3D) sound or not.\n     If a #track is assigned, the value of this field is ignored.\n\n     @see SFXDescription::is3D 
        /// </summary>
        [MemberGroup("3D Sound")]
        public bool is3D
        {
            get { return Omni.self.GetVar(_ID + ".is3D").AsBool(); }
            set { Omni.self.SetVar(_ID + ".is3D", value.AsString()); }
        }

        /// <summary>
        /// Whether to play #fileName in an infinite loop.\n     If a #track is assigned, the value of this field is ignored.\n     @see SFXDescription::isLooping 
        /// </summary>
        [MemberGroup("Sound")]
        public bool isLooping
        {
            get { return Omni.self.GetVar(_ID + ".isLooping").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isLooping", value.AsString()); }
        }

        /// <summary>
        /// Whether to use streamed playback for #fileName.\n     If a #track is assigned, the value of this field is ignored.\n     @see SFXDescription::isStreaming\n\n     @ref SFX_streaming 
        /// </summary>
        [MemberGroup("Sound")]
        public bool isStreaming
        {
            get { return Omni.self.GetVar(_ID + ".isStreaming").AsBool(); }
            set { Omni.self.SetVar(_ID + ".isStreaming", value.AsString()); }
        }

        /// <summary>
        /// Distance at which to stop volume attenuation of the 3D sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::maxDistance 
        /// </summary>
        [MemberGroup("3D Sound")]
        public float maxDistance
        {
            get { return Omni.self.GetVar(_ID + ".maxDistance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".maxDistance", value.AsString()); }
        }

        /// <summary>
        /// Pitch shift to apply to the sound. Default is 1 = play at normal speed.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::pitch 
        /// </summary>
        [MemberGroup("Sound")]
        public float pitch
        {
            get { return Omni.self.GetVar(_ID + ".pitch").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".pitch", value.AsString()); }
        }

        /// <summary>
        /// Whether playback of the emitter's sound should start as soon as the emitter object is added to the level.\n     If this is true, the emitter will immediately start to play when the level is loaded. 
        /// </summary>
        [MemberGroup("Sound")]
        public bool playOnAdd
        {
            get { return Omni.self.GetVar(_ID + ".playOnAdd").AsBool(); }
            set { Omni.self.SetVar(_ID + ".playOnAdd", value.AsString()); }
        }

        /// <summary>
        /// Distance at which to start volume attenuation of the 3D sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::referenceDistance 
        /// </summary>
        [MemberGroup("3D Sound")]
        public float referenceDistance
        {
            get { return Omni.self.GetVar(_ID + ".referenceDistance").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".referenceDistance", value.AsString()); }
        }

        /// <summary>
        /// Bounds on random offset to apply to initial 3D sound position.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::scatterDistance 
        /// </summary>
        [MemberGroup("3D Sound")]
        public Point3F scatterDistance
        {
            get { return Omni.self.GetVar(_ID + ".scatterDistance").AsPoint3F(); }
            set { Omni.self.SetVar(_ID + ".scatterDistance", value.AsString()); }
        }

        /// <summary>
        /// The SFXSource to which to assign the sound of this emitter as a child.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::sourceGroup 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXSourceName sourceGroup
        {
            get { return Omni.self.GetVar(_ID + ".sourceGroup").AsTypeSFXSourceName(); }
            set { Omni.self.SetVar(_ID + ".sourceGroup", value.AsString()); }
        }

        /// <summary>
        /// The track which the emitter should play.\n     @note If assigned, this field will take precedence over a #fileName that may also be assigned to the       emitter. 
        /// </summary>
        [MemberGroup("Media")]
        public TypeSFXTrackName track
        {
            get { return Omni.self.GetVar(_ID + ".track").AsTypeSFXTrackName(); }
            set { Omni.self.SetVar(_ID + ".track", value.AsString()); }
        }

        /// <summary>
        /// If this is true, all fields except for #playOnAdd and #track are ignored on the emitter object.\n     This is useful to prevent fields in the #track's description from being overridden by emitter fields. 
        /// </summary>
        [MemberGroup("Sound")]
        public bool useTrackDescriptionOnly
        {
            get { return Omni.self.GetVar(_ID + ".useTrackDescriptionOnly").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useTrackDescriptionOnly", value.AsString()); }
        }

        /// <summary>
        /// Volume level to apply to the sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::volume 
        /// </summary>
        [MemberGroup("Sound")]
        public float volume
        {
            get { return Omni.self.GetVar(_ID + ".volume").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".volume", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Get the sound source object from the emitter.   @return The sound source used by the emitter or null.   @note This method will return null when called on the server-side SFXEmitter object.  Only client-side ghosts       actually hold on to %SFXSources. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getSource()
        {
            return m_ts.fnSFXEmitter_getSource(_ID);
        }

        /// <summary>
        /// Manually start playback of the emitter's sound.   If this is called on the server-side object, the play command will be related to all client-side ghosts. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void play()
        {
            m_ts.fnSFXEmitter_play(_ID);
        }

        /// <summary>
        /// Manually stop playback of the emitter's sound.   If this is called on the server-side object, the stop command will be related to all client-side ghosts. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void stop()
        {
            m_ts.fnSFXEmitter_stop(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public SFXEmitter_Base()
        {
        }
    }
}