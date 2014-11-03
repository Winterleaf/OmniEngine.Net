


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
    [TypeConverter(typeof(TypeConverterGeneric<SFXEnvironment_Base>))]
    public partial class SFXEnvironment_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SFXEnvironment_Base ts, string simobjectid)
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
        public static bool operator !=(SFXEnvironment_Base ts, string simobjectid)
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
        public static implicit operator string( SFXEnvironment_Base ts)
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
        public static implicit operator SFXEnvironment_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SFXEnvironment_Base) Omni.self.getSimObject(simobjectid,typeof(SFXEnvironment_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SFXEnvironment_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXEnvironment_Base(int simobjectid)
            {
            return  (SFXEnvironment) Omni.self.getSimObject((uint)simobjectid,typeof(SFXEnvironment_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SFXEnvironment_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXEnvironment_Base(uint simobjectid)
            {
            return  (SFXEnvironment_Base) Omni.self.getSimObject(simobjectid,typeof(SFXEnvironment_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Change in level per meter at high frequencies. 
/// </summary>
[MemberGroup("Reverb")]
public float airAbsorptionHF
       {
       get
          {
          return Omni.self.GetVar(_ID + ".airAbsorptionHF").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".airAbsorptionHF", value.AsString());
          }
       }
/// <summary>
/// High-frequency to mid-frequency decay time ratio. 
/// </summary>
[MemberGroup("Reverb")]
public float decayHFRatio
       {
       get
          {
          return Omni.self.GetVar(_ID + ".decayHFRatio").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".decayHFRatio", value.AsString());
          }
       }
/// <summary>
/// Low-frequency to mid-frequency decay time ratio. 
/// </summary>
[MemberGroup("Reverb")]
public float decayLFRatio
       {
       get
          {
          return Omni.self.GetVar(_ID + ".decayLFRatio").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".decayLFRatio", value.AsString());
          }
       }
/// <summary>
/// Reverberation decay time at mid frequencies. 
/// </summary>
[MemberGroup("Reverb")]
public float decayTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".decayTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".decayTime", value.AsString());
          }
       }
/// <summary>
/// Value that controls the modal density in the late reverberation decay. 
/// </summary>
[MemberGroup("Reverb")]
public float density
       {
       get
          {
          return Omni.self.GetVar(_ID + ".density").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".density", value.AsString());
          }
       }
/// <summary>
/// Value that controls the echo density in the late reverberation decay. 
/// </summary>
[MemberGroup("Reverb")]
public float diffusion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".diffusion").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".diffusion", value.AsString());
          }
       }
/// <summary>
/// Echo depth. 
/// </summary>
[MemberGroup("Reverb")]
public float echoDepth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".echoDepth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".echoDepth", value.AsString());
          }
       }
/// <summary>
/// Echo time. 
/// </summary>
[MemberGroup("Reverb")]
public float echoTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".echoTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".echoTime", value.AsString());
          }
       }
/// <summary>
/// Environment diffusion. 
/// </summary>
[MemberGroup("Reverb")]
public float envDiffusion
       {
       get
          {
          return Omni.self.GetVar(_ID + ".envDiffusion").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".envDiffusion", value.AsString());
          }
       }
/// <summary>
/// Environment size in meters. 
/// </summary>
[MemberGroup("Reverb")]
public float envSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".envSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".envSize", value.AsString());
          }
       }
/// <summary>
/// A bitfield of reverb flags.\n     @see REVERB_DECAYTIMESCALE\n     @see REVERB_REFLECTIONSSCALE\n     @see REVERB_REFLECTIONSDELAYSCALE\n     @see REVERB_REVERBSCALE\n     @see REVERB_REVERBDELAYSCALE\n     @see REVERB_DECAYHFLIMIT\n     @see REVERB_ECHOTIMESCALE\n     @see REVERB_MODULATIONTIMESCALE\n     @see REVERB_CORE0\n     @see REVERB_CORE1\n     @see REVERB_HIGHQUALITYREVERB\n     @see REVERB_HIGHQUALITYDPL2REVERB\n 
/// </summary>
[MemberGroup("Reverb")]
public int flags
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flags").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flags", value.AsString());
          }
       }
/// <summary>
/// Reference high frequency in Hertz. 
/// </summary>
[MemberGroup("Reverb")]
public float HFReference
       {
       get
          {
          return Omni.self.GetVar(_ID + ".HFReference").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".HFReference", value.AsString());
          }
       }
/// <summary>
/// Reference low frequency in Hertz. 
/// </summary>
[MemberGroup("Reverb")]
public float LFReference
       {
       get
          {
          return Omni.self.GetVar(_ID + ".LFReference").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".LFReference", value.AsString());
          }
       }
/// <summary>
/// Modulation depth. 
/// </summary>
[MemberGroup("Reverb")]
public float modulationDepth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".modulationDepth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".modulationDepth", value.AsString());
          }
       }
/// <summary>
/// Modulation time. 
/// </summary>
[MemberGroup("Reverb")]
public float modulationTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".modulationTime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".modulationTime", value.AsString());
          }
       }
/// <summary>
/// Early reflections level relative to room effect. 
/// </summary>
[MemberGroup("Reverb")]
public int reflections
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflections").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflections", value.AsString());
          }
       }
/// <summary>
/// Initial reflection delay time. 
/// </summary>
[MemberGroup("Reverb")]
public float reflectionsDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reflectionsDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reflectionsDelay", value.AsString());
          }
       }
[MemberGroup("Reverb")]
public arrayObject<float> reflectionsPan;
/// <summary>
/// Late reverberation level relative to room effect. 
/// </summary>
[MemberGroup("Reverb")]
public int reverb
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reverb").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reverb", value.AsString());
          }
       }
/// <summary>
/// Late reverberation delay time relative to initial reflection. 
/// </summary>
[MemberGroup("Reverb")]
public float reverbDelay
       {
       get
          {
          return Omni.self.GetVar(_ID + ".reverbDelay").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".reverbDelay", value.AsString());
          }
       }
[MemberGroup("Reverb")]
public arrayObject<float> reverbPan;
/// <summary>
/// Room effect level at mid-frequencies. 
/// </summary>
[MemberGroup("Reverb")]
public int room
       {
       get
          {
          return Omni.self.GetVar(_ID + ".room").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".room", value.AsString());
          }
       }
/// <summary>
/// Relative room effect level at high frequencies. 
/// </summary>
[MemberGroup("Reverb")]
public int roomHF
       {
       get
          {
          return Omni.self.GetVar(_ID + ".roomHF").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".roomHF", value.AsString());
          }
       }
/// <summary>
/// Relative room effect level at low frequencies. 
/// </summary>
[MemberGroup("Reverb")]
public int roomLF
       {
       get
          {
          return Omni.self.GetVar(_ID + ".roomLF").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".roomLF", value.AsString());
          }
       }
/// <summary>
/// Logarithmic distance attenuation rolloff scale factor for reverb room size effect. 
/// </summary>
[MemberGroup("Reverb")]
public float roomRolloffFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".roomRolloffFactor").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".roomRolloffFactor", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SFXEnvironment_Base (){reflectionsPan = new arrayObject<float>(3,"reflectionsPan","TypeVariable",false,this);    
reverbPan = new arrayObject<float>(3,"reverbPan","TypeVariable",false,this);    
}
}}
