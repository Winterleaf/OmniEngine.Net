


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXPlayList_Base>))]
    public partial class SFXPlayList_Base: SFXTrack
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
        public static bool operator !=(SFXPlayList_Base ts, string simobjectid)
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
        public static implicit operator string( SFXPlayList_Base ts)
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
        public static implicit operator SFXPlayList_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXPlayList_Base) Omni.self.getSimObject(simobjectid,typeof(SFXPlayList_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXPlayList_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXPlayList_Base(int simobjectid)
            {
            return  (SFXPlayList) Omni.self.getSimObject((uint)simobjectid,typeof(SFXPlayList_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXPlayList_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXPlayList_Base(uint simobjectid)
            {
            return  (SFXPlayList_Base) Omni.self.getSimObject(simobjectid,typeof(SFXPlayList_Base));
            }
#endregion
#region Init Persists
[MemberGroup("Sound")]
public arrayObject<float> delayTimeIn;
[MemberGroup("Sound")]
public arrayObject<Point2F> delayTimeInVariance;
[MemberGroup("Sound")]
public arrayObject<float> delayTimeOut;
[MemberGroup("Sound")]
public arrayObject<Point2F> delayTimeOutVariance;
[MemberGroup("Sound")]
public arrayObject<float> fadeTimeIn;
[MemberGroup("Sound")]
public arrayObject<Point2F> fadeTimeInVariance;
[MemberGroup("Sound")]
public arrayObject<float> fadeTimeOut;
[MemberGroup("Sound")]
public arrayObject<Point2F> fadeTimeOutVariance;
/// <summary>
/// Behavior when description has looping enabled.\n     The loop mode determines whether the list will loop over a single slot or loop over      all the entire list of slots being played.\n\n     @see SFXDescription::isLooping 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXPlayListLoopMode loopMode
       {
       get
          {          return (TypeSFXPlayListLoopMode) Omni.self.GetVar(_ID + ".loopMode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".loopMode", value.ToString());
          }
       }
[MemberGroup("Sound")]
public arrayObject<float> maxDistance;
[MemberGroup("Sound")]
public arrayObject<Point2F> maxDistanceVariance;
/// <summary>
/// Number of slots to play.\n     Up to a maximum of 16, this field determines the number of slots that are taken from the      list for playback. Only slots that have a valid #track assigned will be considered for      this. 
/// </summary>
[MemberGroup("Sound")]
public int numSlotsToPlay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".numSlotsToPlay").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".numSlotsToPlay", value.AsString());
          }
       }
[MemberGroup("Sound")]
public arrayObject<float> pitchScale;
[MemberGroup("Sound")]
public arrayObject<Point2F> pitchScaleVariance;
/// <summary>
/// Slot playback order randomization pattern.\n     By setting this field to something other than \NotRandom\ to order in which slots of the      playlist are processed can be changed from sequential to a random pattern. This allows to      to create more varied playback patterns.\n     Defaults to \NotRandom\. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXPlayListRandomMode random
       {
       get
          {          return (TypeSFXPlayListRandomMode) Omni.self.GetVar(_ID + ".random");
          }
       set
          {
          Omni.self.SetVar(_ID + ".random", value.ToString());
          }
       }
[MemberGroup("Sound")]
public arrayObject<float> referenceDistance;
[MemberGroup("Sound")]
public arrayObject<Point2F> referenceDistanceVariance;
[MemberGroup("Sound")]
public arrayObject<int> repeatCount;
[MemberGroup("Sound")]
public arrayObject<TypeSFXPlayListReplayMode> replay;
[MemberGroup("Sound")]
public arrayObject<TypeSFXStateName> state;
[MemberGroup("Sound")]
public arrayObject<TypeSFXPlayListStateMode> stateMode;
/// <summary>
/// Enable/disable execution tracing for this playlist (local only).\n     If this is true, SFXControllers attached to the list will automatically run in trace mode. 
/// </summary>
[MemberGroup("Debug")]
public bool trace
       {
       get
          {
          return Omni.self.GetVar(_ID + ".trace").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".trace", value.AsString());
          }
       }
[MemberGroup("Sound")]
public arrayObject<TypeSFXTrackName> track;
[MemberGroup("Sound")]
public arrayObject<TypeSFXPlayListTransitionMode> transitionIn;
[MemberGroup("Sound")]
public arrayObject<TypeSFXPlayListTransitionMode> transitionOut;
[MemberGroup("Sound")]
public arrayObject<float> volumeScale;
[MemberGroup("Sound")]
public arrayObject<Point2F> volumeScaleVariance;

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SFXPlayList_Base (){delayTimeIn = new arrayObject<float>(16,"delayTimeIn","TypeVariable",false,this);    
delayTimeInVariance = new arrayObject<Point2F>(16,"delayTimeInVariance","TypeVariable",false,this);    
delayTimeOut = new arrayObject<float>(16,"delayTimeOut","TypeVariable",false,this);    
delayTimeOutVariance = new arrayObject<Point2F>(16,"delayTimeOutVariance","TypeVariable",false,this);    
fadeTimeIn = new arrayObject<float>(16,"fadeTimeIn","TypeVariable",false,this);    
fadeTimeInVariance = new arrayObject<Point2F>(16,"fadeTimeInVariance","TypeVariable",false,this);    
fadeTimeOut = new arrayObject<float>(16,"fadeTimeOut","TypeVariable",false,this);    
fadeTimeOutVariance = new arrayObject<Point2F>(16,"fadeTimeOutVariance","TypeVariable",false,this);    
maxDistance = new arrayObject<float>(16,"maxDistance","TypeVariable",false,this);    
maxDistanceVariance = new arrayObject<Point2F>(16,"maxDistanceVariance","TypeVariable",false,this);    
pitchScale = new arrayObject<float>(16,"pitchScale","TypeVariable",false,this);    
pitchScaleVariance = new arrayObject<Point2F>(16,"pitchScaleVariance","TypeVariable",false,this);    
referenceDistance = new arrayObject<float>(16,"referenceDistance","TypeVariable",false,this);    
referenceDistanceVariance = new arrayObject<Point2F>(16,"referenceDistanceVariance","TypeVariable",false,this);    
repeatCount = new arrayObject<int>(16,"repeatCount","TypeVariable",false,this);    
replay = new arrayObject<TypeSFXPlayListReplayMode>(16,"replay","TypeEnumeration",false,this);    
state = new arrayObject<TypeSFXStateName>(16,"state","TypeVariable",false,this);    
stateMode = new arrayObject<TypeSFXPlayListStateMode>(16,"stateMode","TypeEnumeration",false,this);    
track = new arrayObject<TypeSFXTrackName>(16,"track","TypeVariable",false,this);    
transitionIn = new arrayObject<TypeSFXPlayListTransitionMode>(16,"transitionIn","TypeEnumeration",false,this);    
transitionOut = new arrayObject<TypeSFXPlayListTransitionMode>(16,"transitionOut","TypeEnumeration",false,this);    
volumeScale = new arrayObject<float>(16,"volumeScale","TypeVariable",false,this);    
volumeScaleVariance = new arrayObject<Point2F>(16,"volumeScaleVariance","TypeVariable",false,this);    
}
}}
