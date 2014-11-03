


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
    [TypeConverter(typeof(TypeConverterGeneric<ParticleEmitterNode_Base>))]
    public partial class ParticleEmitterNode_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(ParticleEmitterNode_Base ts, string simobjectid)
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
        public static bool operator !=(ParticleEmitterNode_Base ts, string simobjectid)
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
        public static implicit operator string( ParticleEmitterNode_Base ts)
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
        public static implicit operator ParticleEmitterNode_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (ParticleEmitterNode_Base) Omni.self.getSimObject(simobjectid,typeof(ParticleEmitterNode_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( ParticleEmitterNode_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator ParticleEmitterNode_Base(int simobjectid)
            {
            return  (ParticleEmitterNode) Omni.self.getSimObject((uint)simobjectid,typeof(ParticleEmitterNode_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( ParticleEmitterNode_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator ParticleEmitterNode_Base(uint simobjectid)
            {
            return  (ParticleEmitterNode_Base) Omni.self.getSimObject(simobjectid,typeof(ParticleEmitterNode_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Controls whether particles are emitted from this node. 
/// </summary>
[MemberGroup("")]
public bool active
       {
       get
          {
          return Omni.self.GetVar(_ID + ".active").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".active", value.AsString());
          }
       }
/// <summary>
/// Datablock to use when emitting particles. 
/// </summary>
[MemberGroup("")]
public ParticleEmitterData emitter
       {
       get
          {
          return Omni.self.GetVar(_ID + ".emitter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".emitter", value.ToString());
          }
       }
/// <summary>
/// Velocity to use when emitting particles (in the direction of the    ParticleEmitterNode object's up (Z) axis). 
/// </summary>
[MemberGroup("")]
public float velocity
       {
       get
          {
          return Omni.self.GetVar(_ID + ".velocity").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".velocity", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Turns the emitter on or off.
///    @param active New emitter state )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setActive(bool active){

pInvokes.m_ts.fnParticleEmitterNode_setActive(_ID, active);
}
/// <summary>
/// Assigns the datablock for this emitter node.
///    @param emitterDatablock ParticleEmitterData datablock to assign
///    @tsexample
///    // Assign a new emitter datablock
///    %emitter.setEmitterDatablock( %emitterDatablock );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setEmitterDataBlock(string emitterDatablock = null ){
if (emitterDatablock== null) {emitterDatablock = null;}

pInvokes.m_ts.fnParticleEmitterNode_setEmitterDataBlock(_ID, emitterDatablock);
}

#endregion
#region T3D Callbacks

#endregion
public ParticleEmitterNode_Base (){}
}}
