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
    [TypeConverter(typeof (TypeConverterGeneric<SFXSource_Base>))]
    public partial class SFXSource_Base : SimGroup
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXSource_Base ts, string simobjectid)
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
        public static bool operator !=(SFXSource_Base ts, string simobjectid)
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
        public static implicit operator string(SFXSource_Base ts)
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
        public static implicit operator SFXSource_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SFXSource_Base) Omni.self.getSimObject(simobjectid, typeof (SFXSource_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SFXSource_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXSource_Base(int simobjectid)
        {
            return (SFXSource) Omni.self.getSimObject((uint) simobjectid, typeof (SFXSource_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SFXSource_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXSource_Base(uint simobjectid)
        {
            return (SFXSource_Base) Omni.self.getSimObject(simobjectid, typeof (SFXSource_Base));
        }

        #endregion

        #region Init Persists

        /// <summary>
        /// The playback configuration that determines the initial sound properties and setup.\n     Any SFXSource must have an associated SFXDescription. 
        /// </summary>
        [MemberGroup("Sound")]
        public TypeSFXDescriptionName description
        {
            get { return Omni.self.GetVar(_ID + ".description").AsTypeSFXDescriptionName(); }
            set { Omni.self.SetVar(_ID + ".description", value.AsString()); }
        }

        /// <summary>
        /// Name of function to call when the status of the source changes.\n\n     The source that had its status changed is passed as the first argument to the function and the      new status of the source is passed as the second argument. 
        /// </summary>
        [MemberGroup("Sound")]
        public String statusCallback
        {
            get { return Omni.self.GetVar(_ID + ".statusCallback").AsString(); }
            set { Omni.self.SetVar(_ID + ".statusCallback", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        ///  ),   ( vector position [, vector direction ] )    Set the position and orientation of a 3D sound source.   @hide )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setTransform(string position, string direction = "")
        {
            m_ts.fn_SFXSource_setTransform(_ID, position, direction);
        }

        /// <summary>
        /// Add a notification marker called @a name at @a pos seconds of playback.   @param name Symbolic name for the marker that will be passed to the onMarkerPassed() callback.   @param pos Playback position in seconds when the notification should trigger.  Note that this is a soft limit and there       may be a delay between the play cursor actually passing the position and the callback being triggered.   @note For looped sounds, the marker will trigger on each iteration.   @tsexample   // Create a new source.   $source = sfxCreateSource( AudioMusicLoop2D, \"art/sound/backgroundMusic\" );      // Assign a class to the source.   $source.class = \"BackgroundMusic\";      // Add a playback marker at one minute into playback.   $source.addMarker( \"first\", 60 );      // Define the callback function.  This function will be called when the playback position passes the one minute mark.   function BackgroundMusic::onMarkerPassed( %this, %markerName )   {      if( %markerName $= \"first\" )         echo( \"Playback has passed the 60 seconds mark.\" );   }      // Play the sound.   $source.play();   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addMarker(string name, float pos)
        {
            m_ts.fnSFXSource_addMarker(_ID, name, pos);
        }

        /// <summary>
        /// Attach @a parameter to the source,   Once attached, the source will react to value changes of the given @a parameter.  Attaching a parameter    will also trigger an initial read-out of the parameter's current value.   @param parameter The parameter to attach to the source. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void addParameter(string parameter)
        {
            m_ts.fnSFXSource_addParameter(_ID, parameter);
        }

        /// <summary>
        /// Get the final effective volume level of the source.   This method returns the volume level as it is after source group volume modulation, fades, and distance-based    volume attenuation have been applied to the base volume level.   @return The effective volume of the source.   @ref SFXSource_volume )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getAttenuatedVolume()
        {
            return m_ts.fnSFXSource_getAttenuatedVolume(_ID);
        }

        /// <summary>
        /// Get the fade-in time set on the source.   This will initially be SFXDescription::fadeInTime.   @return The fade-in time set on the source in seconds.   @see SFXDescription::fadeInTime   @ref SFXSource_fades )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getFadeInTime()
        {
            return m_ts.fnSFXSource_getFadeInTime(_ID);
        }

        /// <summary>
        /// Get the fade-out time set on the source.   This will initially be SFXDescription::fadeOutTime.   @return The fade-out time set on the source in seconds.   @see SFXDescription::fadeOutTime   @ref SFXSource_fades )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getFadeOutTime()
        {
            return m_ts.fnSFXSource_getFadeOutTime(_ID);
        }

        /// <summary>
        /// Get the parameter at the given index.   @param index Index of the parameter to fetch.  Must be 0=index=getParameterCount().   @return The parameter at the given @a index or null if @a index is out of range.   @tsexample      // Print the name ofo each parameter attached to %source.      %numParams = %source.getParameterCount();      for( %i = 0; %i  %numParams; %i ++ )         echo( %source.getParameter( %i ).getParameterName() );   @endtsexample   @see getParameterCount )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public string getParameter(int index)
        {
            return m_ts.fnSFXSource_getParameter(_ID, index);
        }

        /// <summary>
        /// Get the number of SFXParameters that are attached to the source.   @return The number of parameters attached to the source.   @tsexample      // Print the name ofo each parameter attached to %source.      %numParams = %source.getParameterCount();      for( %i = 0; %i  %numParams; %i ++ )         echo( %source.getParameter( %i ).getParameterName() );   @endtsexample   @see getParameter   @see addParameter )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public int getParameterCount()
        {
            return m_ts.fnSFXSource_getParameterCount(_ID);
        }

        /// <summary>
        /// Get the pitch scale of the source.   Pitch determines the playback speed of the source (default: 1).   @return The current pitch scale factor of the source.   @see setPitch   @see SFXDescription::pitch )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getPitch()
        {
            return m_ts.fnSFXSource_getPitch(_ID);
        }

        /// <summary>
        /// Get the current playback status.   @return Te current playback status )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public TypeSFXStatus getStatus()
        {
            return (TypeSFXStatus) (m_ts.fnSFXSource_getStatus(_ID));
        }

        /// <summary>
        /// Get the current base volume level of the source.   This is not the final effective volume that the source is playing at but rather the starting    volume level before source group modulation, fades, or distance-based volume attenuation are applied.   @return The current base volume level.   @see setVolume   @see SFXDescription::volume   @ref SFXSource_volume )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public float getVolume()
        {
            return m_ts.fnSFXSource_getVolume(_ID);
        }

        /// <summary>
        /// Test whether the source is currently paused.   @return True if the source is in paused state, false otherwise.   @see pause   @see getStatus   @see SFXStatus )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isPaused()
        {
            return m_ts.fnSFXSource_isPaused(_ID);
        }

        /// <summary>
        /// Test whether the source is currently playing.   @return True if the source is in playing state, false otherwise.   @see play   @see getStatus   @see SFXStatus )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isPlaying()
        {
            return m_ts.fnSFXSource_isPlaying(_ID);
        }

        /// <summary>
        /// Test whether the source is currently stopped.   @return True if the source is in stopped state, false otherwise.   @see stop   @see getStatus   @see SFXStatus )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public bool isStopped()
        {
            return m_ts.fnSFXSource_isStopped(_ID);
        }

        /// <summary>
        /// Pause playback of the source.   @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be       configured on the description.      Be aware that if a fade-out effect is used, the source will not immediately to paused state but will       rather remain in playing state until the fade-out time has expired.. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void pause(float fadeOutTime = -1.0f)
        {
            m_ts.fnSFXSource_pause(_ID, fadeOutTime);
        }

        /// <summary>
        /// Start playback of the source.   If the sound data for the source has not yet been fully loaded, there will be a delay after calling    play and playback will start after the data has become available.   @param fadeInTime Seconds for the sound to reach full volume.  If -1, the SFXDescription::fadeInTime       set in the source's associated description is used.  Pass 0 to disable a fade-in effect that may       be configured on the description. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void play(float fadeInTime = -1.0f)
        {
            m_ts.fnSFXSource_play(_ID, fadeInTime);
        }

        /// <summary>
        /// Detach @a parameter from the source.   Once detached, the source will no longer react to value changes of the given @a parameter.   If the parameter is not attached to the source, the method will do nothing.   @param parameter The parameter to detach from the source. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void removeParameter(string parameter)
        {
            m_ts.fnSFXSource_removeParameter(_ID, parameter);
        }

        /// <summary>
        /// Set up the 3D volume cone for the source.   @param innerAngle Angle of the inner sound cone in degrees (@ref SFXDescription::coneInsideAngle).  Must be 0=innerAngle=360.   @param outerAngle Angle of the outer sound cone in degrees (@ref SFXDescription::coneOutsideAngle).  Must be 0=outerAngle=360.   @param outsideVolume Volume scale factor outside of outer cone (@ref SFXDescription::coneOutsideVolume).  Must be 0=outsideVolume=1.   @note This method has no effect on the source if the source is not 3D. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setCone(float innerAngle, float outerAngle, float outsideVolume)
        {
            m_ts.fnSFXSource_setCone(_ID, innerAngle, outerAngle, outsideVolume);
        }

        /// <summary>
        /// Set the fade time parameters of the source.   @param fadeInTime The new fade-in time in seconds.   @param fadeOutTime The new fade-out time in seconds.   @see SFXDescription::fadeInTime   @see SFXDescription::fadeOutTime   @ref SFXSource_fades )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setFadeTimes(float fadeInTime, float fadeOutTime)
        {
            m_ts.fnSFXSource_setFadeTimes(_ID, fadeInTime, fadeOutTime);
        }

        /// <summary>
        /// Set the pitch scale of the source.   Pitch determines the playback speed of the source (default: 1).   @param pitch The new pitch scale factor.   @see getPitch   @see SFXDescription::pitch )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setPitch(float pitch)
        {
            m_ts.fnSFXSource_setPitch(_ID, pitch);
        }

        /// <summary>
        /// Set the base volume level for the source.   This volume will be the starting point for source group volume modulation, fades, and distance-based    volume attenuation.   @param volume The new base volume level for the source.  Must be 0>=volume=1.   @see getVolume   @ref SFXSource_volume )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void setVolume(float volume)
        {
            m_ts.fnSFXSource_setVolume(_ID, volume);
        }

        /// <summary>
        /// Stop playback of the source.   @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be       configured on the description.      Be aware that if a fade-out effect is used, the source will not immediately transtion to stopped state but       will rather remain in playing state until the fade-out time has expired. )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void stop(float fadeOutTime = -1.0f)
        {
            m_ts.fnSFXSource_stop(_ID, fadeOutTime);
        }

        #endregion

        #region T3D Callbacks

        /// <summary>
        /// Called when the playback status of the source changes.   @param newStatus The new playback status. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onStatusChange(TypeSFXStatus newStatus)
        {
        }

        /// <summary>
        /// Called when a parameter attached to the source changes value.   This callback will be triggered before the value change has actually been applied to the source.   @param parameter The parameter that has changed value.   @note This is also triggered when the parameter is first attached to the source. )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onParameterValueChange(SFXParameter parameter)
        {
        }

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
        public virtual void onMarkerPassed(string idString)
        {
        }

        #endregion

        public SFXSource_Base()
        {
        }
    }
}