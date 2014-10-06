


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
    [TypeConverter(typeof(TypeConverterGeneric<ParticleEmitterNodeData_Base>))]
    public partial class ParticleEmitterNodeData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ParticleEmitterNodeData_Base ts, string simobjectid)
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
        public static bool operator !=(ParticleEmitterNodeData_Base ts, string simobjectid)
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
        public static implicit operator string( ParticleEmitterNodeData_Base ts)
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
        public static implicit operator ParticleEmitterNodeData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ParticleEmitterNodeData_Base) Omni.self.getSimObject(simobjectid,typeof(ParticleEmitterNodeData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ParticleEmitterNodeData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleEmitterNodeData_Base(int simobjectid)
            {
            return  (ParticleEmitterNodeData) Omni.self.getSimObject((uint)simobjectid,typeof(ParticleEmitterNodeData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ParticleEmitterNodeData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleEmitterNodeData_Base(uint simobjectid)
            {
            return  (ParticleEmitterNodeData_Base) Omni.self.getSimObject(simobjectid,typeof(ParticleEmitterNodeData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Time multiplier for particle emitter nodes.\n\n   Increasing timeMultiple is like running the emitter at a faster rate - single-shot    emitters will complete in a shorter time, and continuous emitters will generate    particles more quickly.\n\n   Valid range is 0.01 - 100. 
/// </summary>
[MemberGroup("")]
public float timeMultiple
       {
       get
          {
          return Omni.self.GetVar(_ID + ".timeMultiple").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".timeMultiple", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public ParticleEmitterNodeData_Base (){}
}}
