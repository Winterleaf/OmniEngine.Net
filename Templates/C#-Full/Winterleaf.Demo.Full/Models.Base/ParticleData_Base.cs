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
    [TypeConverter(typeof (TypeConverterGeneric<ParticleData_Base>))]
    public partial class ParticleData_Base : SimDataBlock
    {
        #region ProxyObjects Operator Overrides

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ParticleData_Base ts, string simobjectid)
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
        public static bool operator !=(ParticleData_Base ts, string simobjectid)
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
        public static implicit operator string(ParticleData_Base ts)
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
        public static implicit operator ParticleData_Base(string ts)
        {
            uint simobjectid = resolveobject(ts);
            return (ParticleData_Base) Omni.self.getSimObject(simobjectid, typeof (ParticleData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(ParticleData_Base ts)
        {
            return (int) ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleData_Base(int simobjectid)
        {
            return (ParticleData) Omni.self.getSimObject((uint) simobjectid, typeof (ParticleData_Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(ParticleData_Base ts)
        {
            return ts._iID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleData_Base(uint simobjectid)
        {
            return (ParticleData_Base) Omni.self.getSimObject(simobjectid, typeof (ParticleData_Base));
        }

        #endregion

        #region Init Persists

        [MemberGroup("")] public arrayObject<ColorF> colors;
        [MemberGroup("")] public arrayObject<Point2F> textureCoords;

        /// <summary>
        /// If true, allow the particle texture to be an animated sprite. 
        /// </summary>
        [MemberGroup("")]
        public bool animateTexture
        {
            get { return Omni.self.GetVar(_ID + ".animateTexture").AsBool(); }
            set { Omni.self.SetVar(_ID + ".animateTexture", value.AsString()); }
        }

        /// <summary>
        /// @brief A list of frames and/or frame ranges to use for particle    animation if animateTexture is true.\n\n   Each frame token must be separated by whitespace. A frame token must be    a positive integer frame number or a range of frame numbers separated    with a '-'. The range separator, '-', cannot have any whitspace around    it.\n\n   Ranges can be specified to move through the frames in reverse as well    as forward (eg. 19-14). Frame numbers exceeding the number of tiles will    wrap.\n   @tsexample\n   animTexFrames = \0-16 20 19 18 17 31-21\;\n   @endtsexample\n 
        /// </summary>
        [MemberGroup("")]
        public String animTexFrames
        {
            get { return Omni.self.GetVar(_ID + ".animTexFrames").AsString(); }
            set { Omni.self.SetVar(_ID + ".animTexFrames", value.AsString()); }
        }

        /// <summary>
        /// @brief Texture file to use for this particle if animateTexture is true.\n\n   Deprecated. Use textureName instead. 
        /// </summary>
        [MemberGroup("")]
        public String animTexName
        {
            get { return Omni.self.GetVar(_ID + ".animTexName").AsString(); }
            set { Omni.self.SetVar(_ID + ".animTexName", value.AsString()); }
        }

        /// <summary>
        /// @brief The number of frames, in rows and columns stored in textureName    (when animateTexture is true).\n\n   A maximum of 256 frames can be stored in a single texture when using    animTexTiling. Value should be \NumColumns NumRows\, for example \4 4\. 
        /// </summary>
        [MemberGroup("")]
        public Point2I animTexTiling
        {
            get { return Omni.self.GetVar(_ID + ".animTexTiling").AsPoint2I(); }
            set { Omni.self.SetVar(_ID + ".animTexTiling", value.AsString()); }
        }

        /// <summary>
        /// Constant acceleration to apply to this particle. 
        /// </summary>
        [MemberGroup("")]
        public float constantAcceleration
        {
            get { return Omni.self.GetVar(_ID + ".constantAcceleration").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".constantAcceleration", value.AsString()); }
        }

        /// <summary>
        /// Particle physics drag amount. 
        /// </summary>
        [MemberGroup("")]
        public float dragCoefficient
        {
            get { return Omni.self.GetVar(_ID + ".dragCoefficient").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".dragCoefficient", value.AsString()); }
        }

        /// <summary>
        /// If animateTexture is true, this defines the frames per second of the    sprite animation. 
        /// </summary>
        [MemberGroup("")]
        public int framesPerSec
        {
            get { return Omni.self.GetVar(_ID + ".framesPerSec").AsInt(); }
            set { Omni.self.SetVar(_ID + ".framesPerSec", value.AsString()); }
        }

        /// <summary>
        /// Strength of gravity on the particles. 
        /// </summary>
        [MemberGroup("")]
        public float gravityCoefficient
        {
            get { return Omni.self.GetVar(_ID + ".gravityCoefficient").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".gravityCoefficient", value.AsString()); }
        }

        /// <summary>
        /// Amount of emitter velocity to add to particle initial velocity. 
        /// </summary>
        [MemberGroup("")]
        public float inheritedVelFactor
        {
            get { return Omni.self.GetVar(_ID + ".inheritedVelFactor").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".inheritedVelFactor", value.AsString()); }
        }

        /// <summary>
        /// Time in milliseconds before this particle is destroyed. 
        /// </summary>
        [MemberGroup("")]
        public int lifetimeMS
        {
            get { return Omni.self.GetVar(_ID + ".lifetimeMS").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lifetimeMS", value.AsString()); }
        }

        /// <summary>
        /// Variance in lifetime of particle, from 0 - lifetimeMS. 
        /// </summary>
        [MemberGroup("")]
        public int lifetimeVarianceMS
        {
            get { return Omni.self.GetVar(_ID + ".lifetimeVarianceMS").AsInt(); }
            set { Omni.self.SetVar(_ID + ".lifetimeVarianceMS", value.AsString()); }
        }

        /// <summary>
        /// @brief Particle size keyframe values.\n\n   The particle size will linearly interpolate between the size/time keys    over the lifetime of the particle. 
        /// </summary>
        [MemberGroup("")]
        public float sizes
        {
            get { return Omni.self.GetVar(_ID + ".sizes").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".sizes", value.AsString()); }
        }

        /// <summary>
        /// Maximum allowed spin speed of this particle, between spinRandomMin and 1000. 
        /// </summary>
        [MemberGroup("")]
        public float spinRandomMax
        {
            get { return Omni.self.GetVar(_ID + ".spinRandomMax").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".spinRandomMax", value.AsString()); }
        }

        /// <summary>
        /// Minimum allowed spin speed of this particle, between -1000 and spinRandomMax. 
        /// </summary>
        [MemberGroup("")]
        public float spinRandomMin
        {
            get { return Omni.self.GetVar(_ID + ".spinRandomMin").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".spinRandomMin", value.AsString()); }
        }

        /// <summary>
        /// Speed at which to spin the particle. 
        /// </summary>
        [MemberGroup("")]
        public float spinSpeed
        {
            get { return Omni.self.GetVar(_ID + ".spinSpeed").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".spinSpeed", value.AsString()); }
        }

        /// <summary>
        /// Texture file to use for this particle. 
        /// </summary>
        [MemberGroup("")]
        public String textureName
        {
            get { return Omni.self.GetVar(_ID + ".textureName").AsString(); }
            set { Omni.self.SetVar(_ID + ".textureName", value.AsString()); }
        }

        /// <summary>
        /// @brief Time keys used with the colors and sizes keyframes.\n\n   Values are from 0.0 (particle creation) to 1.0 (end of lifespace). 
        /// </summary>
        [MemberGroup("")]
        public float times
        {
            get { return Omni.self.GetVar(_ID + ".times").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".times", value.AsString()); }
        }

        /// <summary>
        /// @brief Controls how particles blend with the scene.\n\n   If true, particles blend like ParticleBlendStyle NORMAL, if false,    blend like ParticleBlendStyle ADDITIVE.\n   @note If ParticleEmitterData::blendStyle is set, it will override this value. 
        /// </summary>
        [MemberGroup("")]
        public bool useInvAlpha
        {
            get { return Omni.self.GetVar(_ID + ".useInvAlpha").AsBool(); }
            set { Omni.self.SetVar(_ID + ".useInvAlpha", value.AsString()); }
        }

        /// <summary>
        /// Strength of wind on the particles. 
        /// </summary>
        [MemberGroup("")]
        public float windCoefficient
        {
            get { return Omni.self.GetVar(_ID + ".windCoefficient").AsFloat(); }
            set { Omni.self.SetVar(_ID + ".windCoefficient", value.AsString()); }
        }

        #endregion

        #region Member Functions

        /// <summary>
        /// Reloads this particle.   @tsexample   // Get the editor's current particle   %particle = PE_ParticleEditor.currParticle   // Change a particle value   %particle.setFieldValue( %propertyField, %value );   // Reload it   %particle.reload();   @endtsexample )
        /// </summary>
        [MemberFunctionConsoleInteraction(true)]
        public void reload()
        {
            m_ts.fnParticleData_reload(_ID);
        }

        #endregion

        #region T3D Callbacks

        #endregion

        public ParticleData_Base()
        {
            colors = new arrayObject<ColorF>(4, "colors", "TypeVariable", false, this);
            textureCoords = new arrayObject<Point2F>(4, "textureCoords", "TypeVariable", false, this);
        }
    }
}