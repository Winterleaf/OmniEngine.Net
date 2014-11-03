


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
    [TypeConverter(typeof(TypeConverterGeneric<GuiTheoraCtrl_Base>))]
    public partial class GuiTheoraCtrl_Base: GuiControl
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
        public static bool operator !=(GuiTheoraCtrl_Base ts, string simobjectid)
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
        public static implicit operator string( GuiTheoraCtrl_Base ts)
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
        public static implicit operator GuiTheoraCtrl_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GuiTheoraCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTheoraCtrl_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GuiTheoraCtrl_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GuiTheoraCtrl_Base(int simobjectid)
            {
            return  (GuiTheoraCtrl) Omni.self.getSimObject((uint)simobjectid,typeof(GuiTheoraCtrl_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GuiTheoraCtrl_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GuiTheoraCtrl_Base(uint simobjectid)
            {
            return  (GuiTheoraCtrl_Base) Omni.self.getSimObject(simobjectid,typeof(GuiTheoraCtrl_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Fill color when video is not playing. 
/// </summary>
[MemberGroup("Playback")]
public ColorI backgroundColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".backgroundColor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".backgroundColor", value.AsString());
          }
       }
/// <summary>
/// Whether to automatically match control extents to the video size. 
/// </summary>
[MemberGroup("Playback")]
public bool matchVideoSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".matchVideoSize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".matchVideoSize", value.AsString());
          }
       }
/// <summary>
/// Whether to start playing video when control is woken up. 
/// </summary>
[MemberGroup("Playback")]
public bool playOnWake
       {
       get
          {
          return Omni.self.GetVar(_ID + ".playOnWake").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".playOnWake", value.AsString());
          }
       }
/// <summary>
/// If true, displays an overlay on top of the video with useful debugging information. 
/// </summary>
[MemberGroup("Playback")]
public bool renderDebugInfo
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderDebugInfo").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderDebugInfo", value.AsString());
          }
       }
/// <summary>
/// Whether to stop video when control is set to sleep.\n\n     If this is not set to true, the video will be paused when the control is put to sleep. This is because there is no support      for seeking in the video stream in the player backend and letting the time source used to synchronize video (either audio      or a raw timer) get far ahead of frame decoding will cause possibly very long delays when the control is woken up again. 
/// </summary>
[MemberGroup("Playback")]
public bool stopOnSleep
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stopOnSleep").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stopOnSleep", value.AsString());
          }
       }
/// <summary>
/// Theora video file to play. 
/// </summary>
[MemberGroup("Playback")]
public String theoraFile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".theoraFile").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".theoraFile", value.AsString());
          }
       }
/// <summary>
/// The routine to use for Y'CbCr to RGB conversion. 
/// </summary>
[MemberGroup("Playback")]
public TypeGuiTheoraTranscoder transcoder
       {
       get
          {          return (TypeGuiTheoraTranscoder) Omni.self.GetVar(_ID + ".transcoder");
          }
       set
          {
          Omni.self.SetVar(_ID + ".transcoder", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the current playback time.
///    @return The elapsed playback time in seconds. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  float getCurrentTime(){

return pInvokes.m_ts.fnGuiTheoraCtrl_getCurrentTime(_ID);
}
/// <summary>
/// Test whether the video has finished playing.
///    @return True if the video has finished playing, false otherwise. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isPlaybackDone(){

return pInvokes.m_ts.fnGuiTheoraCtrl_isPlaybackDone(_ID);
}
/// <summary>
/// Pause playback of the video.  If the video is not currently playing, the call is ignored.
///    While stopped, the control displays the last frame. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void pause(){

pInvokes.m_ts.fnGuiTheoraCtrl_pause(_ID);
}
/// <summary>
/// Start playing the video.  If the video is already playing, the call is ignored. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void play(){

pInvokes.m_ts.fnGuiTheoraCtrl_play(_ID);
}
/// <summary>
/// Set the video file to play.  If a video is already playing, playback is stopped and 
///    the new video file is loaded.
///    @param filename The video file to load. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setFile(string filename){

pInvokes.m_ts.fnGuiTheoraCtrl_setFile(_ID, filename);
}
/// <summary>
/// Stop playback of the video.  The next call to play() will then start playback from the beginning of the video.
///    While stopped, the control renders empty with just the background color. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stop(){

pInvokes.m_ts.fnGuiTheoraCtrl_stop(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public GuiTheoraCtrl_Base (){}
}}
