


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXAmbience_Base>))]
    public partial class SFXAmbience_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXAmbience_Base ts, string simobjectid)
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
        public static bool operator !=(SFXAmbience_Base ts, string simobjectid)
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
        public static implicit operator string( SFXAmbience_Base ts)
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
        public static implicit operator SFXAmbience_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXAmbience_Base) Omni.self.getSimObject(simobjectid,typeof(SFXAmbience_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXAmbience_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXAmbience_Base(int simobjectid)
            {
            return  (SFXAmbience) Omni.self.getSimObject((uint)simobjectid,typeof(SFXAmbience_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXAmbience_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXAmbience_Base(uint simobjectid)
            {
            return  (SFXAmbience_Base) Omni.self.getSimObject(simobjectid,typeof(SFXAmbience_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The factor to apply to the doppler affect in this space.\n     Defaults to 0.5.\n\n     @ref SFXSource_doppler 
/// </summary>
[MemberGroup("Sound")]
public float dopplerFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dopplerFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dopplerFactor", value.AsString());
          }
       }
/// <summary>
/// Reverb environment active in the ambience zone.\n     @ref SFX_reverb 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXEnvironmentName environment
       {
       get
          {
          return Omni.self.GetVar(_ID + ".environment").AsTypeSFXEnvironmentName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".environment", value.AsString());
          }
       }
/// <summary>
/// The rolloff factor to apply to distance-based volume attenuation in this space.\n     Defaults to 1.0.\n\n     @note This applies to the logarithmic distance model only.\n\n     @ref SFXSource_volume 
/// </summary>
[MemberGroup("Sound")]
public float rolloffFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".rolloffFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".rolloffFactor", value.AsString());
          }
       }
/// <summary>
/// Sound track to play in the ambience zone. 
/// </summary>
[MemberGroup("Sound")]
public TypeSFXTrackName soundTrack
       {
       get
          {
          return Omni.self.GetVar(_ID + ".soundTrack").AsTypeSFXTrackName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundTrack", value.AsString());
          }
       }
[MemberGroup("Sound")]
public arrayObject<TypeSFXStateName> states;

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SFXAmbience_Base (){states = new arrayObject<TypeSFXStateName>(4,"states","TypeVariable",false,this);    
}
}}
