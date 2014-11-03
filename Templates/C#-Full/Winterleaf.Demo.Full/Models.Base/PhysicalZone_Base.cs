


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
    [TypeConverter(typeof(TypeConverterGeneric<PhysicalZone_Base>))]
    public partial class PhysicalZone_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PhysicalZone_Base ts, string simobjectid)
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
        public static bool operator !=(PhysicalZone_Base ts, string simobjectid)
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
        public static implicit operator string( PhysicalZone_Base ts)
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
        public static implicit operator PhysicalZone_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PhysicalZone_Base) Omni.self.getSimObject(simobjectid,typeof(PhysicalZone_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PhysicalZone_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PhysicalZone_Base(int simobjectid)
            {
            return  (PhysicalZone) Omni.self.getSimObject((uint)simobjectid,typeof(PhysicalZone_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PhysicalZone_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PhysicalZone_Base(uint simobjectid)
            {
            return  (PhysicalZone_Base) Omni.self.getSimObject(simobjectid,typeof(PhysicalZone_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Three-element floating point value representing forces in three axes to apply to objects entering PhysicalZone.
/// </summary>
[MemberGroup("Misc")]
public Point3F appliedForce
       {
       get
          {
          return Omni.self.GetVar(_ID + ".appliedForce").AsPoint3F();
          }
       set
          {
          Omni.self.SetVar(_ID + ".appliedForce", value.AsString());
          }
       }
/// <summary>
/// Gravity in PhysicalZone. Multiplies against standard gravity.
/// </summary>
[MemberGroup("Misc")]
public float gravityMod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".gravityMod").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".gravityMod", value.AsString());
          }
       }
/// <summary>
/// The polyhedron type is really a quadrilateral and consists of a corner   point followed by three vectors representing the edges extending from the corner. 
/// </summary>
[MemberGroup("Misc")]
public Polyhedron polyhedron
       {
       get
          {
          return Omni.self.GetVar(_ID + ".polyhedron").AsPolyhedron();
          }
       set
          {
          Omni.self.SetVar(_ID + ".polyhedron", value.AsString());
          }
       }
/// <summary>
/// Multiply velocity of objects entering zone by this value every tick.
/// </summary>
[MemberGroup("Misc")]
public float velocityMod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".velocityMod").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".velocityMod", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Activate the physical zone's effects.
/// 													@tsexample
/// 														// Activate effects for a specific physical zone.
/// 														%thisPhysicalZone.activate();
/// 													@endtsexample
/// 													@ingroup Datablocks
/// 				  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void activate(){

pInvokes.m_ts.fnPhysicalZone_activate(_ID);
}
/// <summary>
/// Deactivate the physical zone's effects.
/// 													@tsexample
/// 														// Deactivate effects for a specific physical zone.
/// 														%thisPhysicalZone.deactivate();
/// 													@endtsexample
/// 													@ingroup Datablocks
/// 				  )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void deactivate(){

pInvokes.m_ts.fnPhysicalZone_deactivate(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public PhysicalZone_Base (){}
}}
