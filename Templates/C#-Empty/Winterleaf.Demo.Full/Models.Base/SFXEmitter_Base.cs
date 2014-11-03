


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXEmitter_Base>))]
    public partial class SFXEmitter_Base: SceneObject
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
        public static bool operator !=(SFXEmitter_Base ts, string simobjectid)
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
        public static implicit operator string( SFXEmitter_Base ts)
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
        public static implicit operator SFXEmitter_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXEmitter_Base) Omni.self.getSimObject(simobjectid,typeof(SFXEmitter_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXEmitter_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXEmitter_Base(int simobjectid)
            {
            return  (SFXEmitter) Omni.self.getSimObject((uint)simobjectid,typeof(SFXEmitter_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXEmitter_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXEmitter_Base(uint simobjectid)
            {
            return  (SFXEmitter_Base) Omni.self.getSimObject(simobjectid,typeof(SFXEmitter_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Angle of inner volume cone of 3D sound in degrees.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneInsideAngle 
/// </summary>
[MemberGroup("3D Sound")]
public int coneInsideAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coneInsideAngle").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coneInsideAngle", value.AsString());
          }
       }
/// <summary>
/// Angle of outer volume cone of 3D sound in degrees\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneOutsideAngle 
/// </summary>
[MemberGroup("3D Sound")]
public int coneOutsideAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coneOutsideAngle").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coneOutsideAngle", value.AsString());
          }
       }
/// <summary>
/// Volume scale factor of outside of outer volume 3D sound cone.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::coneOutsideVolume 
/// </summary>
[MemberGroup("3D Sound")]
public float coneOutsideVolume
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coneOutsideVolume").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coneOutsideVolume", value.AsString());
          }
       }
/// <summary>
/// Number of seconds to gradually fade in volume from zero when playback starts.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::fadeInTime 
/// </summary>
[MemberGroup("Sound")]
public float fadeInTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeInTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeInTime", value.AsString());
          }
       }
/// <summary>
/// Number of seconds to gradually fade out volume down to zero when playback is stopped or paused.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::fadeOutTime 
/// </summary>
[MemberGroup("Sound")]
public float fadeOutTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeOutTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeOutTime", value.AsString());
          }
       }
/// <summary>
/// The sound file to play.\n     Use @b either this property @b or #track. If both are assigned, #track takes precendence. The primary purpose of this      field is to avoid the need for the user to define SFXTrack datablocks for all sounds used in a level. 
/// </summary>
[MemberGroup("Media")]
public String fileName
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fileName").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fileName", value.AsString());
          }
       }
/// <summary>
/// Whether to play #fileName as a positional (3D) sound or not.\n     If a #track is assigned, the value of this field is ignored.\n\n     @see SFXDescription::is3D 
/// </summary>
[MemberGroup("3D Sound")]
public bool is3D
       {
       get
          {
          return Omni.self.GetVar(_ID + ".is3D").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".is3D", value.AsString());
          }
       }
/// <summary>
/// Whether to play #fileName in an infinite loop.\n     If a #track is assigned, the value of this field is ignored.\n     @see SFXDescription::isLooping 
/// </summary>
[MemberGroup("Sound")]
public bool isLooping
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isLooping").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isLooping", value.AsString());
          }
       }
/// <summary>
/// Whether to use streamed playback for #fileName.\n     If a #track is assigned, the value of this field is ignored.\n     @see SFXDescription::isStreaming\n\n     @ref SFX_streaming 
/// </summary>
[MemberGroup("Sound")]
public bool isStreaming
       {
       get
          {
          return Omni.self.GetVar(_ID + ".isStreaming").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".isStreaming", value.AsString());
          }
       }
/// <summary>
/// Distance at which to stop volume attenuation of the 3D sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::maxDistance 
/// </summary>
[MemberGroup("3D Sound")]
public float maxDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxDistance", value.AsString());
          }
       }
/// <summary>
/// Pitch shift to apply to the sound. Default is 1 = play at normal speed.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::pitch 
/// </summary>
[MemberGroup("Sound")]
public float pitch
       {
       get
          {
          return Omni.self.GetVar(_ID + ".pitch").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".pitch", value.AsString());
          }
       }
/// <summary>
/// Whether playback of the emitter's sound should start as soon as the emitter object is added to the level.\n     If this is true, the emitter will immediately start to play when the level is loaded. 
/// </summary>
[MemberGroup("Sound")]
public bool playOnAdd
       {
       get
          {
          return Omni.self.GetVar(_ID + ".playOnAdd").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".playOnAdd", value.AsString());
          }
       }
/// <summary>
/// Distance at which to start volume attenuation of the 3D sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::referenceDistance 
/// </summary>
[MemberGroup("3D Sound")]
public float referenceDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".referenceDistance").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".referenceDistance", value.AsString());
          }
       }
/// <summary>
/// Bounds on random offset to apply to initial 3D sound position.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::scatterDistance 
/// </summary>
[MemberGroup("3D Sound")]
public Point3F scatterDistance
       {
       get
          {
          return Omni.self.GetVar(_ID + ".scatterDistance").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".scatterDistance", value.AsString());
          }
       }
/// <summary>
/// The SFXSource to which to assign the sound of this emitter as a child.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::sourceGroup 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXSourceName sourceGroup
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sourceGroup").AsTypeSFXSourceName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sourceGroup", value.AsString());
          }
       }
/// <summary>
/// The track which the emitter should play.\n     @note If assigned, this field will take precedence over a #fileName that may also be assigned to the       emitter. 
/// </summary>
[MemberGroup("Media")]
public TypeSFXTrackName track
       {
       get
          {
          return Omni.self.GetVar(_ID + ".track").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".track", value.AsString());
          }
       }
/// <summary>
/// If this is true, all fields except for #playOnAdd and #track are ignored on the emitter object.\n     This is useful to prevent fields in the #track's description from being overridden by emitter fields. 
/// </summary>
[MemberGroup("Sound")]
public bool useTrackDescriptionOnly
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useTrackDescriptionOnly").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useTrackDescriptionOnly", value.AsString());
          }
       }
/// <summary>
/// Volume level to apply to the sound.\n     @note This field is ignored if #useTrackDescriptionOnly is true.\n\n     @see SFXDescription::volume 
/// </summary>
[MemberGroup("Sound")]
public float volume
       {
       get
          {
          return Omni.self.GetVar(_ID + ".volume").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".volume", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Get the sound source object from the emitter.
///    @return The sound source used by the emitter or null.
///    @note This method will return null when called on the server-side SFXEmitter object.  Only client-side ghosts 
///       actually hold on to %SFXSources. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getSource(){

return pInvokes.m_ts.fnSFXEmitter_getSource(_ID);
}
/// <summary>
/// Manually start playback of the emitter's sound.
///    If this is called on the server-side object, the play command will be related to all client-side ghosts. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void play(){

pInvokes.m_ts.fnSFXEmitter_play(_ID);
}
/// <summary>
/// Manually stop playback of the emitter's sound.
///    If this is called on the server-side object, the stop command will be related to all client-side ghosts. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void stop(){

pInvokes.m_ts.fnSFXEmitter_stop(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public SFXEmitter_Base (){}
}}
