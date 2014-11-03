


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
    [TypeConverter(typeof(TypeConverterGeneric<Debris_Base>))]
    public partial class Debris_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Debris_Base ts, string simobjectid)
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
        public static bool operator !=(Debris_Base ts, string simobjectid)
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
        public static implicit operator string( Debris_Base ts)
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
        public static implicit operator Debris_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Debris_Base) Omni.self.getSimObject(simobjectid,typeof(Debris_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Debris_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Debris_Base(int simobjectid)
            {
            return  (Debris) Omni.self.getSimObject((uint)simobjectid,typeof(Debris_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Debris_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Debris_Base(uint simobjectid)
            {
            return  (Debris_Base) Omni.self.getSimObject(simobjectid,typeof(Debris_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Length of time for this debris object to exist. When expired, the object will be deleted.\n\n     The initial lifetime value comes from the DebrisData datablock.\n     @see DebrisData::lifetime\n     @see DebrisData::lifetimeVariance\n
/// </summary>
[MemberGroup("Debris")]
public float lifetime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifetime").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifetime", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// 1.0 1.0 1.0, 1.0 0.0 0.0), 
///    @brief Manually set this piece of debris at the given position with the given velocity.
/// 
///    Usually you do not manually create Debris objects as they are generated through other means, 
///    such as an Explosion.  This method exists when you do manually create a Debris object and 
///    want to have it start moving.
/// 
///    @param inputPosition Position to place the debris.
///    @param inputVelocity Velocity to move the debris after it has been placed.
///    @return Always returns true.
/// 
///    @tsexample
///       // Define the position
///       %position = \"1.0 1.0 1.0\";
///       // Define the velocity
///       %velocity = \"1.0 0.0 0.0\";
///       // Inform the debris object of its new position and velocity
///       %debris.init(%position,%velocity);
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool init(string inputPosition = "1.01.01.0", string inputVelocity = "1.00.00.0"){

return pInvokes.m_ts.fnDebris_init(_ID, inputPosition, inputVelocity);
}

#endregion
#region T3D Callbacks

#endregion
public Debris_Base (){}
}}
