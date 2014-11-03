


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXSound_Base>))]
    public partial class SFXSound_Base: SFXSource
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXSound_Base ts, string simobjectid)
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
        public static bool operator !=(SFXSound_Base ts, string simobjectid)
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
        public static implicit operator string( SFXSound_Base ts)
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
        public static implicit operator SFXSound_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXSound_Base) Omni.self.getSimObject(simobjectid,typeof(SFXSound_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXSound_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXSound_Base(int simobjectid)
            {
            return  (SFXSound) Omni.self.getSimObject((uint)simobjectid,typeof(SFXSound_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXSound_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXSound_Base(uint simobjectid)
            {
            return  (SFXSound_Base) Omni.self.getSimObject(simobjectid,typeof(SFXSound_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// Get the total play time (in seconds) of the sound data attached to the sound.
///    @return 
///    @note Be aware that for looped sounds, this will not return the total playback time of the sound. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getDuration(){

return pInvokes.m_ts.fnSFXSound_getDuration(_ID);
}
/// <summary>
/// Get the current playback position in seconds.
///    @return The current play cursor offset. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getPosition(){

return pInvokes.m_ts.fnSFXSound_getPosition(_ID);
}
/// <summary>
/// Test whether the sound data associated with the sound has been fully loaded and is ready for playback.
///    For streamed sounds, this will be false during playback when the stream queue for the sound is starved and 
///    waiting for data.  For buffered sounds, only an initial loading phase will potentially cause isReady to 
///    return false.
///    @return True if the sound is ready for playback. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isReady(){

return pInvokes.m_ts.fnSFXSound_isReady(_ID);
}
/// <summary>
/// Set the current playback position in seconds.
///    If the source is currently playing, playback will jump to the new position.  If playback is stopped or paused, 
///    playback will resume at the given position when play() is called.
///    @param position The new position of the play cursor (in seconds). )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setPosition(float position){

pInvokes.m_ts.fnSFXSound_setPosition(_ID, position);
}

#endregion
#region T3D Callbacks

#endregion
public SFXSound_Base (){}
}}
