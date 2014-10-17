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

#endregion

namespace WinterLeaf.Demo.Full.Models.Base
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (TypeConverterGeneric<SFXEnvironment_Base>))]
    public partial class SFXEnvironment_Base : SimDataBlock
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
        public static bool operator !=(SFXEnvironment_Base ts, string simobjectid)
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
        public static implicit operator string(SFXEnvironment_Base ts)
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
        public static implicit operator SFXEnvironment_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (SFXEnvironment_Base) Omni.self.getSimObject(simobjectid, typeof (SFXEnvironment_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(SFXEnvironment_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SFXEnvironment_Base(int simobjectid)
        {
            return (SFXEnvironment) Omni.self.getSimObject((uint) simobjectid, typeof (SFXEnvironment_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(SFXEnvironment_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SFXEnvironment_Base(uint simobjectid)
        {
            return (SFXEnvironment_Base) Omni.self.getSimObject(simobjectid, typeof (SFXEnvironment_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("Reverb")] public arrayObject<float> reflectionsPan;
        [MemberGroup("Reverb")] public arrayObject<float> reverbPan;

        /// <summary>
        /// Change in level per meter at high frequencies. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float airAbsorptionHF
        {
            get { return Omni.self.GetVar(_ID + ".airAbsorptionHF").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".airAbsorptionHF", value.AsString()); }
        }

        /// <summary>
        /// High-frequency to mid-frequency decay time ratio. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float decayHFRatio
        {
            get { return Omni.self.GetVar(_ID + ".decayHFRatio").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".decayHFRatio", value.AsString()); }
        }

        /// <summary>
        /// Low-frequency to mid-frequency decay time ratio. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float decayLFRatio
        {
            get { return Omni.self.GetVar(_ID + ".decayLFRatio").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".decayLFRatio", value.AsString()); }
        }

        /// <summary>
        /// Reverberation decay time at mid frequencies. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float decayTime
        {
            get { return Omni.self.GetVar(_ID + ".decayTime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".decayTime", value.AsString()); }
        }

        /// <summary>
        /// Value that controls the modal density in the late reverberation decay. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float density
        {
            get { return Omni.self.GetVar(_ID + ".density").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".density", value.AsString()); }
        }

        /// <summary>
        /// Value that controls the echo density in the late reverberation decay. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float diffusion
        {
            get { return Omni.self.GetVar(_ID + ".diffusion").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".diffusion", value.AsString()); }
        }

        /// <summary>
        /// Echo depth. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float echoDepth
        {
            get { return Omni.self.GetVar(_ID + ".echoDepth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".echoDepth", value.AsString()); }
        }

        /// <summary>
        /// Echo time. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float echoTime
        {
            get { return Omni.self.GetVar(_ID + ".echoTime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".echoTime", value.AsString()); }
        }

        /// <summary>
        /// Environment diffusion. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float envDiffusion
        {
            get { return Omni.self.GetVar(_ID + ".envDiffusion").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".envDiffusion", value.AsString()); }
        }

        /// <summary>
        /// Environment size in meters. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float envSize
        {
            get { return Omni.self.GetVar(_ID + ".envSize").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".envSize", value.AsString()); }
        }

        /// <summary>
        /// A bitfield of reverb flags.\n     @see REVERB_DECAYTIMESCALE\n     @see REVERB_REFLECTIONSSCALE\n     @see REVERB_REFLECTIONSDELAYSCALE\n     @see REVERB_REVERBSCALE\n     @see REVERB_REVERBDELAYSCALE\n     @see REVERB_DECAYHFLIMIT\n     @see REVERB_ECHOTIMESCALE\n     @see REVERB_MODULATIONTIMESCALE\n     @see REVERB_CORE0\n     @see REVERB_CORE1\n     @see REVERB_HIGHQUALITYREVERB\n     @see REVERB_HIGHQUALITYDPL2REVERB\n 
        /// </summary>
        [MemberGroup("Reverb")]
        public int flags
        {
            get { return Omni.self.GetVar(_ID + ".flags").AsInt(); }
            set { Omni.self.SetVar(_ID + ".flags", value.AsString()); }
        }

        /// <summary>
        /// Reference high frequency in Hertz. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float HFReference
        {
            get { return Omni.self.GetVar(_ID + ".HFReference").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".HFReference", value.AsString()); }
        }

        /// <summary>
        /// Reference low frequency in Hertz. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float LFReference
        {
            get { return Omni.self.GetVar(_ID + ".LFReference").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".LFReference", value.AsString()); }
        }

        /// <summary>
        /// Modulation depth. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float modulationDepth
        {
            get { return Omni.self.GetVar(_ID + ".modulationDepth").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".modulationDepth", value.AsString()); }
        }

        /// <summary>
        /// Modulation time. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float modulationTime
        {
            get { return Omni.self.GetVar(_ID + ".modulationTime").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".modulationTime", value.AsString()); }
        }

        /// <summary>
        /// Early reflections level relative to room effect. 
        /// </summary>
        [MemberGroup("Reverb")]
        public int reflections
        {
            get { return Omni.self.GetVar(_ID + ".reflections").AsInt(); }
            set { Omni.self.SetVar(_ID + ".reflections", value.AsString()); }
        }

        /// <summary>
        /// Initial reflection delay time. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float reflectionsDelay
        {
            get { return Omni.self.GetVar(_ID + ".reflectionsDelay").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reflectionsDelay", value.AsString()); }
        }

        /// <summary>
        /// Late reverberation level relative to room effect. 
        /// </summary>
        [MemberGroup("Reverb")]
        public int reverb
        {
            get { return Omni.self.GetVar(_ID + ".reverb").AsInt(); }
            set { Omni.self.SetVar(_ID + ".reverb", value.AsString()); }
        }

        /// <summary>
        /// Late reverberation delay time relative to initial reflection. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float reverbDelay
        {
            get { return Omni.self.GetVar(_ID + ".reverbDelay").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".reverbDelay", value.AsString()); }
        }

        /// <summary>
        /// Room effect level at mid-frequencies. 
        /// </summary>
        [MemberGroup("Reverb")]
        public int room
        {
            get { return Omni.self.GetVar(_ID + ".room").AsInt(); }
            set { Omni.self.SetVar(_ID + ".room", value.AsString()); }
        }

        /// <summary>
        /// Relative room effect level at high frequencies. 
        /// </summary>
        [MemberGroup("Reverb")]
        public int roomHF
        {
            get { return Omni.self.GetVar(_ID + ".roomHF").AsInt(); }
            set { Omni.self.SetVar(_ID + ".roomHF", value.AsString()); }
        }

        /// <summary>
        /// Relative room effect level at low frequencies. 
        /// </summary>
        [MemberGroup("Reverb")]
        public int roomLF
        {
            get { return Omni.self.GetVar(_ID + ".roomLF").AsInt(); }
            set { Omni.self.SetVar(_ID + ".roomLF", value.AsString()); }
        }

        /// <summary>
        /// Logarithmic distance attenuation rolloff scale factor for reverb room size effect. 
        /// </summary>
        [MemberGroup("Reverb")]
        public float roomRolloffFactor
        {
            get { return Omni.self.GetVar(_ID + ".roomRolloffFactor").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".roomRolloffFactor", value.AsString()); }
        }

        #endregion

        #region Member Functions

        #endregion

        #region T3D Callbacks

        #endregion

        public SFXEnvironment_Base()
        {
            reflectionsPan = new arrayObject<float>(3, "reflectionsPan", "TypeVariable", false, this);
            reverbPan = new arrayObject<float>(3, "reverbPan", "TypeVariable", false, this);
        }
    }
}