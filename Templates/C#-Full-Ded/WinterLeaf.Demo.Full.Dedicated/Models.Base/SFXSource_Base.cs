


#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinterLeaf.Engine;
using WinterLeaf.Engine.Classes;
using WinterLeaf.Engine.Containers;
using WinterLeaf.Engine.Enums;
using System.ComponentModel;
using System.Threading;
using  WinterLeaf.Engine.Classes.Interopt;
using WinterLeaf.Engine.Classes.Decorations;
using WinterLeaf.Engine.Classes.Extensions;
using WinterLeaf.Engine.Classes.Helpers;
using WinterLeaf.Demo.Full.Models.User.Extendable;
#endregion

namespace WinterLeaf.Demo.Full.Models.Base
    {
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TypeConverterGeneric<SFXSource_Base>))]
    public partial class SFXSource_Base: SimGroup
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
            return object.ReferenceEquals(ts, null) ? object.ReferenceEquals(simobjectid, null) : ts.Equals(simobjectid);
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
            
            return (this._ID ==(string)myReflections.ChangeType( obj,typeof(string)));
            }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(SFXSource_Base ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);

            }


            /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string( SFXSource_Base ts)
            {
            if (object.ReferenceEquals(ts, null))
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
           return  (SFXSource_Base) Omni.self.getSimObject(simobjectid,typeof(SFXSource_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXSource_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXSource_Base(int simobjectid)
            {
            return  (SFXSource) Omni.self.getSimObject((uint)simobjectid,typeof(SFXSource_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXSource_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXSource_Base(uint simobjectid)
            {
            return  (SFXSource_Base) Omni.self.getSimObject(simobjectid,typeof(SFXSource_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The playback configuration that determines the initial sound properties and setup.\n     Any SFXSource must have an associated SFXDescription. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXDescriptionName description
       {
       get
          {
          return Omni.self.GetVar(_ID + ".description").AsTypeSFXDescriptionName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".description", value.AsString());
          }
       }
/// <summary>
/// Name of function to call when the status of the source changes.\n\n     The source that had its status changed is passed as the first argument to the function and the      new status of the source is passed as the second argument. 
/// </summary>
[MemberGroup("Sound")]
public String statusCallback
       {
       get
          {
          return Omni.self.GetVar(_ID + ".statusCallback").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".statusCallback", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
///  ),
///    ( vector position [, vector direction ] ) 
///    Set the position and orientation of a 3D sound source.
///    @hide )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTransform(string position, string direction = ""){

pInvokes.m_ts.fn_SFXSource_setTransform(_ID, position, direction);
}
/// <summary>
/// Add a notification marker called @a name at @a pos seconds of playback.
///    @param name Symbolic name for the marker that will be passed to the onMarkerPassed() callback.
///    @param pos Playback position in seconds when the notification should trigger.  Note that this is a soft limit and there 
///       may be a delay between the play cursor actually passing the position and the callback being triggered.
///    @note For looped sounds, the marker will trigger on each iteration.
///    @tsexample
///    // Create a new source.
///    $source = sfxCreateSource( AudioMusicLoop2D, \"art/sound/backgroundMusic\" );
///    
///    // Assign a class to the source.
///    $source.class = \"BackgroundMusic\";
///    
///    // Add a playback marker at one minute into playback.
///    $source.addMarker( \"first\", 60 );
///    
///    // Define the callback function.  This function will be called when the playback position passes the one minute mark.
///    function BackgroundMusic::onMarkerPassed( %this, %markerName )
///    {
///       if( %markerName $= \"first\" )
///          echo( \"Playback has passed the 60 seconds mark.\" );
///    }
///    
///    // Play the sound.
///    $source.play();
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addMarker(string name, float pos){

pInvokes.m_ts.fnSFXSource_addMarker(_ID, name, pos);
}
/// <summary>
/// Attach @a parameter to the source,
///    Once attached, the source will react to value changes of the given @a parameter.  Attaching a parameter 
///    will also trigger an initial read-out of the parameter's current value.
///    @param parameter The parameter to attach to the source. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void addParameter(string parameter){

pInvokes.m_ts.fnSFXSource_addParameter(_ID, parameter);
}
/// <summary>
/// Get the final effective volume level of the source.
///    This method returns the volume level as it is after source group volume modulation, fades, and distance-based 
///    volume attenuation have been applied to the base volume level.
///    @return The effective volume of the source.
///    @ref SFXSource_volume )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getAttenuatedVolume(){

return pInvokes.m_ts.fnSFXSource_getAttenuatedVolume(_ID);
}
/// <summary>
/// Get the fade-in time set on the source.
///    This will initially be SFXDescription::fadeInTime.
///    @return The fade-in time set on the source in seconds.
///    @see SFXDescription::fadeInTime
///    @ref SFXSource_fades )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getFadeInTime(){

return pInvokes.m_ts.fnSFXSource_getFadeInTime(_ID);
}
/// <summary>
/// Get the fade-out time set on the source.
///    This will initially be SFXDescription::fadeOutTime.
///    @return The fade-out time set on the source in seconds.
///    @see SFXDescription::fadeOutTime
///    @ref SFXSource_fades )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getFadeOutTime(){

return pInvokes.m_ts.fnSFXSource_getFadeOutTime(_ID);
}
/// <summary>
/// Get the parameter at the given index.
///    @param index Index of the parameter to fetch.  Must be 0=index=getParameterCount().
///    @return The parameter at the given @a index or null if @a index is out of range.
///    @tsexample
///       // Print the name ofo each parameter attached to %source.
///       %numParams = %source.getParameterCount();
///       for( %i = 0; %i  %numParams; %i ++ )
///          echo( %source.getParameter( %i ).getParameterName() );
///    @endtsexample
///    @see getParameterCount )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getParameter(int index){

return pInvokes.m_ts.fnSFXSource_getParameter(_ID, index);
}
/// <summary>
/// Get the number of SFXParameters that are attached to the source.
///    @return The number of parameters attached to the source.
///    @tsexample
///       // Print the name ofo each parameter attached to %source.
///       %numParams = %source.getParameterCount();
///       for( %i = 0; %i  %numParams; %i ++ )
///          echo( %source.getParameter( %i ).getParameterName() );
///    @endtsexample
///    @see getParameter
///    @see addParameter )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getParameterCount(){

return pInvokes.m_ts.fnSFXSource_getParameterCount(_ID);
}
/// <summary>
/// Get the pitch scale of the source.
///    Pitch determines the playback speed of the source (default: 1).
///    @return The current pitch scale factor of the source.
///    @see setPitch
///    @see SFXDescription::pitch )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getPitch(){

return pInvokes.m_ts.fnSFXSource_getPitch(_ID);
}
/// <summary>
/// Get the current playback status.
///    @return Te current playback status )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  TypeSFXStatus getStatus(){

return (TypeSFXStatus)( pInvokes.m_ts.fnSFXSource_getStatus(_ID));
}
/// <summary>
/// Get the current base volume level of the source.
///    This is not the final effective volume that the source is playing at but rather the starting 
///    volume level before source group modulation, fades, or distance-based volume attenuation are applied.
///    @return The current base volume level.
///    @see setVolume
///    @see SFXDescription::volume
///    @ref SFXSource_volume )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getVolume(){

return pInvokes.m_ts.fnSFXSource_getVolume(_ID);
}
/// <summary>
/// Test whether the source is currently paused.
///    @return True if the source is in paused state, false otherwise.
///    @see pause
///    @see getStatus
///    @see SFXStatus )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isPaused(){

return pInvokes.m_ts.fnSFXSource_isPaused(_ID);
}
/// <summary>
/// Test whether the source is currently playing.
///    @return True if the source is in playing state, false otherwise.
///    @see play
///    @see getStatus
///    @see SFXStatus )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isPlaying(){

return pInvokes.m_ts.fnSFXSource_isPlaying(_ID);
}
/// <summary>
/// Test whether the source is currently stopped.
///    @return True if the source is in stopped state, false otherwise.
///    @see stop
///    @see getStatus
///    @see SFXStatus )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isStopped(){

return pInvokes.m_ts.fnSFXSource_isStopped(_ID);
}
/// <summary>
/// Pause playback of the source.
///    @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime 
///       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be 
///       configured on the description.
///       Be aware that if a fade-out effect is used, the source will not immediately to paused state but will 
///       rather remain in playing state until the fade-out time has expired.. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pause(float fadeOutTime = -1.0f){

pInvokes.m_ts.fnSFXSource_pause(_ID, fadeOutTime);
}
/// <summary>
/// Start playback of the source.
///    If the sound data for the source has not yet been fully loaded, there will be a delay after calling 
///    play and playback will start after the data has become available.
///    @param fadeInTime Seconds for the sound to reach full volume.  If -1, the SFXDescription::fadeInTime 
///       set in the source's associated description is used.  Pass 0 to disable a fade-in effect that may 
///       be configured on the description. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void play(float fadeInTime = -1.0f){

pInvokes.m_ts.fnSFXSource_play(_ID, fadeInTime);
}
/// <summary>
/// Detach @a parameter from the source.
///    Once detached, the source will no longer react to value changes of the given @a parameter.
///    If the parameter is not attached to the source, the method will do nothing.
///    @param parameter The parameter to detach from the source. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void removeParameter(string parameter){

pInvokes.m_ts.fnSFXSource_removeParameter(_ID, parameter);
}
/// <summary>
/// Set up the 3D volume cone for the source.
///    @param innerAngle Angle of the inner sound cone in degrees (@ref SFXDescription::coneInsideAngle).  Must be 0=innerAngle=360.
///    @param outerAngle Angle of the outer sound cone in degrees (@ref SFXDescription::coneOutsideAngle).  Must be 0=outerAngle=360.
///    @param outsideVolume Volume scale factor outside of outer cone (@ref SFXDescription::coneOutsideVolume).  Must be 0=outsideVolume=1.
///    @note This method has no effect on the source if the source is not 3D. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setCone(float innerAngle, float outerAngle, float outsideVolume){

pInvokes.m_ts.fnSFXSource_setCone(_ID, innerAngle, outerAngle, outsideVolume);
}
/// <summary>
/// Set the fade time parameters of the source.
///    @param fadeInTime The new fade-in time in seconds.
///    @param fadeOutTime The new fade-out time in seconds.
///    @see SFXDescription::fadeInTime
///    @see SFXDescription::fadeOutTime
///    @ref SFXSource_fades )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFadeTimes(float fadeInTime, float fadeOutTime){

pInvokes.m_ts.fnSFXSource_setFadeTimes(_ID, fadeInTime, fadeOutTime);
}
/// <summary>
/// Set the pitch scale of the source.
///    Pitch determines the playback speed of the source (default: 1).
///    @param pitch The new pitch scale factor.
///    @see getPitch
///    @see SFXDescription::pitch )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPitch(float pitch){

pInvokes.m_ts.fnSFXSource_setPitch(_ID, pitch);
}
/// <summary>
/// Set the base volume level for the source.
///    This volume will be the starting point for source group volume modulation, fades, and distance-based 
///    volume attenuation.
///    @param volume The new base volume level for the source.  Must be 0>=volume=1.
///    @see getVolume
///    @ref SFXSource_volume )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setVolume(float volume){

pInvokes.m_ts.fnSFXSource_setVolume(_ID, volume);
}
/// <summary>
/// Stop playback of the source.
///    @param fadeOutTime Seconds for the sound to fade down to zero volume.  If -1, the SFXDescription::fadeOutTime 
///       set in the source's associated description is used.  Pass 0 to disable a fade-out effect that may be 
///       configured on the description.
///       Be aware that if a fade-out effect is used, the source will not immediately transtion to stopped state but 
///       will rather remain in playing state until the fade-out time has expired. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stop(float fadeOutTime = -1.0f){

pInvokes.m_ts.fnSFXSource_stop(_ID, fadeOutTime);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the playback status of the source changes.   @param newStatus The new playback status. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStatusChange(TypeSFXStatus newStatus){}

        /// <summary>
        /// Called when a parameter attached to the source changes value.   This callback will be triggered before the value change has actually been applied to the source.   @param parameter The parameter that has changed value.   @note This is also triggered when the parameter is first attached to the source. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onParameterValueChange(SFXParameter parameter){}

        /// <summary>
        /// )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onMarkerPassed(string idString){}

#endregion
public SFXSource_Base (){}
}}
